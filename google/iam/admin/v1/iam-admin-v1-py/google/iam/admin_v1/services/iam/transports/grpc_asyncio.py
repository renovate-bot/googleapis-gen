# -*- coding: utf-8 -*-

# Copyright 2020 Google LLC
#
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
#
#     http://www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
#

import warnings
from typing import Awaitable, Callable, Dict, Optional, Sequence, Tuple

from google.api_core import gapic_v1                   # type: ignore
from google.api_core import grpc_helpers_async         # type: ignore
from google import auth                                # type: ignore
from google.auth import credentials                    # type: ignore
from google.auth.transport.grpc import SslCredentials  # type: ignore

import grpc                        # type: ignore
from grpc.experimental import aio  # type: ignore

from google.iam.admin_v1.types import iam
from google.iam.v1 import iam_policy_pb2 as iam_policy  # type: ignore
from google.iam.v1 import policy_pb2 as policy  # type: ignore
from google.protobuf import empty_pb2 as empty  # type: ignore

from .base import IAMTransport, DEFAULT_CLIENT_INFO
from .grpc import IAMGrpcTransport


class IAMGrpcAsyncIOTransport(IAMTransport):
    """gRPC AsyncIO backend transport for IAM.

    Creates and manages service account objects.

    Service account is an account that belongs to your project instead
    of to an individual end user. It is used to authenticate calls to a
    Google API.

    To create a service account, specify the ``project_id`` and
    ``account_id`` for the account. The ``account_id`` is unique within
    the project, and used to generate the service account email address
    and a stable ``unique_id``.

    All other methods can identify accounts using the format
    ``projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}``. Using ``-`` as
    a wildcard for the ``PROJECT_ID`` will infer the project from the
    account. The ``ACCOUNT`` value can be the ``email`` address or the
    ``unique_id`` of the service account.

    This class defines the same methods as the primary client, so the
    primary client can load the underlying transport implementation
    and call it.

    It sends protocol buffers over the wire using gRPC (which is built on
    top of HTTP/2); the ``grpcio`` package must be installed.
    """

    _grpc_channel: aio.Channel
    _stubs: Dict[str, Callable] = {}

    @classmethod
    def create_channel(cls,
                       host: str = 'iam.googleapis.com',
                       credentials: credentials.Credentials = None,
                       credentials_file: Optional[str] = None,
                       scopes: Optional[Sequence[str]] = None,
                       quota_project_id: Optional[str] = None,
                       **kwargs) -> aio.Channel:
        """Create and return a gRPC AsyncIO channel object.
        Args:
            host (Optional[str]): The host for the channel to use.
            credentials (Optional[~.Credentials]): The
                authorization credentials to attach to requests. These
                credentials identify this application to the service. If
                none are specified, the client will attempt to ascertain
                the credentials from the environment.
            credentials_file (Optional[str]): A file with credentials that can
                be loaded with :func:`google.auth.load_credentials_from_file`.
                This argument is ignored if ``channel`` is provided.
            scopes (Optional[Sequence[str]]): A optional list of scopes needed for this
                service. These are only used when credentials are not specified and
                are passed to :func:`google.auth.default`.
            quota_project_id (Optional[str]): An optional project to use for billing
                and quota.
            kwargs (Optional[dict]): Keyword arguments, which are passed to the
                channel creation.
        Returns:
            aio.Channel: A gRPC AsyncIO channel object.
        """
        scopes = scopes or cls.AUTH_SCOPES
        return grpc_helpers_async.create_channel(
            host,
            credentials=credentials,
            credentials_file=credentials_file,
            scopes=scopes,
            quota_project_id=quota_project_id,
            **kwargs
        )

    def __init__(self, *,
            host: str = 'iam.googleapis.com',
            credentials: credentials.Credentials = None,
            credentials_file: Optional[str] = None,
            scopes: Optional[Sequence[str]] = None,
            channel: aio.Channel = None,
            api_mtls_endpoint: str = None,
            client_cert_source: Callable[[], Tuple[bytes, bytes]] = None,
            ssl_channel_credentials: grpc.ChannelCredentials = None,
            client_cert_source_for_mtls: Callable[[], Tuple[bytes, bytes]] = None,
            quota_project_id=None,
            client_info: gapic_v1.client_info.ClientInfo = DEFAULT_CLIENT_INFO,
            ) -> None:
        """Instantiate the transport.

        Args:
            host (Optional[str]): The hostname to connect to.
            credentials (Optional[google.auth.credentials.Credentials]): The
                authorization credentials to attach to requests. These
                credentials identify the application to the service; if none
                are specified, the client will attempt to ascertain the
                credentials from the environment.
                This argument is ignored if ``channel`` is provided.
            credentials_file (Optional[str]): A file with credentials that can
                be loaded with :func:`google.auth.load_credentials_from_file`.
                This argument is ignored if ``channel`` is provided.
            scopes (Optional[Sequence[str]]): A optional list of scopes needed for this
                service. These are only used when credentials are not specified and
                are passed to :func:`google.auth.default`.
            channel (Optional[aio.Channel]): A ``Channel`` instance through
                which to make calls.
            api_mtls_endpoint (Optional[str]): Deprecated. The mutual TLS endpoint.
                If provided, it overrides the ``host`` argument and tries to create
                a mutual TLS channel with client SSL credentials from
                ``client_cert_source`` or applicatin default SSL credentials.
            client_cert_source (Optional[Callable[[], Tuple[bytes, bytes]]]):
                Deprecated. A callback to provide client SSL certificate bytes and
                private key bytes, both in PEM format. It is ignored if
                ``api_mtls_endpoint`` is None.
            ssl_channel_credentials (grpc.ChannelCredentials): SSL credentials
                for grpc channel. It is ignored if ``channel`` is provided.
            client_cert_source_for_mtls (Optional[Callable[[], Tuple[bytes, bytes]]]):
                A callback to provide client certificate bytes and private key bytes,
                both in PEM format. It is used to configure mutual TLS channel. It is
                ignored if ``channel`` or ``ssl_channel_credentials`` is provided.
            quota_project_id (Optional[str]): An optional project to use for billing
                and quota.
            client_info (google.api_core.gapic_v1.client_info.ClientInfo):
                The client info used to send a user-agent string along with
                API requests. If ``None``, then default info will be used.
                Generally, you only need to set this if you're developing
                your own client library.

        Raises:
            google.auth.exceptions.MutualTlsChannelError: If mutual TLS transport
              creation failed for any reason.
          google.api_core.exceptions.DuplicateCredentialArgs: If both ``credentials``
              and ``credentials_file`` are passed.
        """
        self._grpc_channel = None
        self._ssl_channel_credentials = ssl_channel_credentials
        self._stubs: Dict[str, Callable] = {}

        if api_mtls_endpoint:
            warnings.warn("api_mtls_endpoint is deprecated", DeprecationWarning)
        if client_cert_source:
            warnings.warn("client_cert_source is deprecated", DeprecationWarning)

        if channel:
            # Ignore credentials if a channel was passed.
            credentials = False
            # If a channel was explicitly provided, set it.
            self._grpc_channel = channel
            self._ssl_channel_credentials = None

        else:
            if api_mtls_endpoint:
                host = api_mtls_endpoint

                # Create SSL credentials with client_cert_source or application
                # default SSL credentials.
                if client_cert_source:
                    cert, key = client_cert_source()
                    self._ssl_channel_credentials = grpc.ssl_channel_credentials(
                        certificate_chain=cert, private_key=key
                    )
                else:
                    self._ssl_channel_credentials = SslCredentials().ssl_credentials

            else:
                if client_cert_source_for_mtls and not ssl_channel_credentials:
                    cert, key = client_cert_source_for_mtls()
                    self._ssl_channel_credentials = grpc.ssl_channel_credentials(
                        certificate_chain=cert, private_key=key
                    )

        # The base transport sets the host, credentials and scopes
        super().__init__(
            host=host,
            credentials=credentials,
            credentials_file=credentials_file,
            scopes=scopes,
            quota_project_id=quota_project_id,
            client_info=client_info,
        )

        if not self._grpc_channel:
            self._grpc_channel = type(self).create_channel(
                self._host,
                credentials=self._credentials,
                credentials_file=credentials_file,
                scopes=self._scopes,
                ssl_credentials=self._ssl_channel_credentials,
                quota_project_id=quota_project_id,
                options=[
                    ("grpc.max_send_message_length", -1),
                    ("grpc.max_receive_message_length", -1),
                ],
            )

        # Wrap messages. This must be done after self._grpc_channel exists
        self._prep_wrapped_messages(client_info)

    @property
    def grpc_channel(self) -> aio.Channel:
        """Create the channel designed to connect to this service.

        This property caches on the instance; repeated calls return
        the same channel.
        """
        # Return the channel from cache.
        return self._grpc_channel

    @property
    def list_service_accounts(self) -> Callable[
            [iam.ListServiceAccountsRequest],
            Awaitable[iam.ListServiceAccountsResponse]]:
        r"""Return a callable for the list service accounts method over gRPC.

        Lists [ServiceAccounts][google.iam.admin.v1.ServiceAccount] for
        a project.

        Returns:
            Callable[[~.ListServiceAccountsRequest],
                    Awaitable[~.ListServiceAccountsResponse]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'list_service_accounts' not in self._stubs:
            self._stubs['list_service_accounts'] = self.grpc_channel.unary_unary(
                '/google.iam.admin.v1.IAM/ListServiceAccounts',
                request_serializer=iam.ListServiceAccountsRequest.serialize,
                response_deserializer=iam.ListServiceAccountsResponse.deserialize,
            )
        return self._stubs['list_service_accounts']

    @property
    def get_service_account(self) -> Callable[
            [iam.GetServiceAccountRequest],
            Awaitable[iam.ServiceAccount]]:
        r"""Return a callable for the get service account method over gRPC.

        Gets a [ServiceAccount][google.iam.admin.v1.ServiceAccount].

        Returns:
            Callable[[~.GetServiceAccountRequest],
                    Awaitable[~.ServiceAccount]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'get_service_account' not in self._stubs:
            self._stubs['get_service_account'] = self.grpc_channel.unary_unary(
                '/google.iam.admin.v1.IAM/GetServiceAccount',
                request_serializer=iam.GetServiceAccountRequest.serialize,
                response_deserializer=iam.ServiceAccount.deserialize,
            )
        return self._stubs['get_service_account']

    @property
    def create_service_account(self) -> Callable[
            [iam.CreateServiceAccountRequest],
            Awaitable[iam.ServiceAccount]]:
        r"""Return a callable for the create service account method over gRPC.

        Creates a [ServiceAccount][google.iam.admin.v1.ServiceAccount]
        and returns it.

        Returns:
            Callable[[~.CreateServiceAccountRequest],
                    Awaitable[~.ServiceAccount]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'create_service_account' not in self._stubs:
            self._stubs['create_service_account'] = self.grpc_channel.unary_unary(
                '/google.iam.admin.v1.IAM/CreateServiceAccount',
                request_serializer=iam.CreateServiceAccountRequest.serialize,
                response_deserializer=iam.ServiceAccount.deserialize,
            )
        return self._stubs['create_service_account']

    @property
    def update_service_account(self) -> Callable[
            [iam.ServiceAccount],
            Awaitable[iam.ServiceAccount]]:
        r"""Return a callable for the update service account method over gRPC.

        Updates a [ServiceAccount][google.iam.admin.v1.ServiceAccount].

        Currently, only the following fields are updatable:
        ``display_name`` and ``description``.

        Returns:
            Callable[[~.ServiceAccount],
                    Awaitable[~.ServiceAccount]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'update_service_account' not in self._stubs:
            self._stubs['update_service_account'] = self.grpc_channel.unary_unary(
                '/google.iam.admin.v1.IAM/UpdateServiceAccount',
                request_serializer=iam.ServiceAccount.serialize,
                response_deserializer=iam.ServiceAccount.deserialize,
            )
        return self._stubs['update_service_account']

    @property
    def delete_service_account(self) -> Callable[
            [iam.DeleteServiceAccountRequest],
            Awaitable[empty.Empty]]:
        r"""Return a callable for the delete service account method over gRPC.

        Deletes a [ServiceAccount][google.iam.admin.v1.ServiceAccount].

        Returns:
            Callable[[~.DeleteServiceAccountRequest],
                    Awaitable[~.Empty]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'delete_service_account' not in self._stubs:
            self._stubs['delete_service_account'] = self.grpc_channel.unary_unary(
                '/google.iam.admin.v1.IAM/DeleteServiceAccount',
                request_serializer=iam.DeleteServiceAccountRequest.serialize,
                response_deserializer=empty.Empty.FromString,
            )
        return self._stubs['delete_service_account']

    @property
    def list_service_account_keys(self) -> Callable[
            [iam.ListServiceAccountKeysRequest],
            Awaitable[iam.ListServiceAccountKeysResponse]]:
        r"""Return a callable for the list service account keys method over gRPC.

        Lists
        [ServiceAccountKeys][google.iam.admin.v1.ServiceAccountKey].

        Returns:
            Callable[[~.ListServiceAccountKeysRequest],
                    Awaitable[~.ListServiceAccountKeysResponse]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'list_service_account_keys' not in self._stubs:
            self._stubs['list_service_account_keys'] = self.grpc_channel.unary_unary(
                '/google.iam.admin.v1.IAM/ListServiceAccountKeys',
                request_serializer=iam.ListServiceAccountKeysRequest.serialize,
                response_deserializer=iam.ListServiceAccountKeysResponse.deserialize,
            )
        return self._stubs['list_service_account_keys']

    @property
    def get_service_account_key(self) -> Callable[
            [iam.GetServiceAccountKeyRequest],
            Awaitable[iam.ServiceAccountKey]]:
        r"""Return a callable for the get service account key method over gRPC.

        Gets the
        [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey] by
        key id.

        Returns:
            Callable[[~.GetServiceAccountKeyRequest],
                    Awaitable[~.ServiceAccountKey]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'get_service_account_key' not in self._stubs:
            self._stubs['get_service_account_key'] = self.grpc_channel.unary_unary(
                '/google.iam.admin.v1.IAM/GetServiceAccountKey',
                request_serializer=iam.GetServiceAccountKeyRequest.serialize,
                response_deserializer=iam.ServiceAccountKey.deserialize,
            )
        return self._stubs['get_service_account_key']

    @property
    def create_service_account_key(self) -> Callable[
            [iam.CreateServiceAccountKeyRequest],
            Awaitable[iam.ServiceAccountKey]]:
        r"""Return a callable for the create service account key method over gRPC.

        Creates a
        [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey] and
        returns it.

        Returns:
            Callable[[~.CreateServiceAccountKeyRequest],
                    Awaitable[~.ServiceAccountKey]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'create_service_account_key' not in self._stubs:
            self._stubs['create_service_account_key'] = self.grpc_channel.unary_unary(
                '/google.iam.admin.v1.IAM/CreateServiceAccountKey',
                request_serializer=iam.CreateServiceAccountKeyRequest.serialize,
                response_deserializer=iam.ServiceAccountKey.deserialize,
            )
        return self._stubs['create_service_account_key']

    @property
    def delete_service_account_key(self) -> Callable[
            [iam.DeleteServiceAccountKeyRequest],
            Awaitable[empty.Empty]]:
        r"""Return a callable for the delete service account key method over gRPC.

        Deletes a
        [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey].

        Returns:
            Callable[[~.DeleteServiceAccountKeyRequest],
                    Awaitable[~.Empty]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'delete_service_account_key' not in self._stubs:
            self._stubs['delete_service_account_key'] = self.grpc_channel.unary_unary(
                '/google.iam.admin.v1.IAM/DeleteServiceAccountKey',
                request_serializer=iam.DeleteServiceAccountKeyRequest.serialize,
                response_deserializer=empty.Empty.FromString,
            )
        return self._stubs['delete_service_account_key']

    @property
    def sign_blob(self) -> Callable[
            [iam.SignBlobRequest],
            Awaitable[iam.SignBlobResponse]]:
        r"""Return a callable for the sign blob method over gRPC.

        Signs a blob using a service account's system-managed
        private key.

        Returns:
            Callable[[~.SignBlobRequest],
                    Awaitable[~.SignBlobResponse]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'sign_blob' not in self._stubs:
            self._stubs['sign_blob'] = self.grpc_channel.unary_unary(
                '/google.iam.admin.v1.IAM/SignBlob',
                request_serializer=iam.SignBlobRequest.serialize,
                response_deserializer=iam.SignBlobResponse.deserialize,
            )
        return self._stubs['sign_blob']

    @property
    def sign_jwt(self) -> Callable[
            [iam.SignJwtRequest],
            Awaitable[iam.SignJwtResponse]]:
        r"""Return a callable for the sign jwt method over gRPC.

        Signs a JWT using a service account's system-managed private
        key.

        If no expiry time (``exp``) is provided in the
        ``SignJwtRequest``, IAM sets an an expiry time of one hour by
        default. If you request an expiry time of more than one hour,
        the request will fail.

        Returns:
            Callable[[~.SignJwtRequest],
                    Awaitable[~.SignJwtResponse]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'sign_jwt' not in self._stubs:
            self._stubs['sign_jwt'] = self.grpc_channel.unary_unary(
                '/google.iam.admin.v1.IAM/SignJwt',
                request_serializer=iam.SignJwtRequest.serialize,
                response_deserializer=iam.SignJwtResponse.deserialize,
            )
        return self._stubs['sign_jwt']

    @property
    def get_iam_policy(self) -> Callable[
            [iam_policy.GetIamPolicyRequest],
            Awaitable[policy.Policy]]:
        r"""Return a callable for the get iam policy method over gRPC.

        Returns the Cloud IAM access control policy for a
        [ServiceAccount][google.iam.admin.v1.ServiceAccount].

        Note: Service accounts are both `resources and
        identities </iam/docs/service-accounts#service_account_permissions>`__.
        This method treats the service account as a resource. It returns
        the Cloud IAM policy that reflects what members have access to
        the service account.

        This method does not return what resources the service account
        has access to. To see if a service account has access to a
        resource, call the ``getIamPolicy`` method on the target
        resource. For example, to view grants for a project, call the
        `projects.getIamPolicy </resource-manager/reference/rest/v1/projects/getIamPolicy>`__
        method.

        Returns:
            Callable[[~.GetIamPolicyRequest],
                    Awaitable[~.Policy]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'get_iam_policy' not in self._stubs:
            self._stubs['get_iam_policy'] = self.grpc_channel.unary_unary(
                '/google.iam.admin.v1.IAM/GetIamPolicy',
                request_serializer=iam_policy.GetIamPolicyRequest.SerializeToString,
                response_deserializer=policy.Policy.FromString,
            )
        return self._stubs['get_iam_policy']

    @property
    def set_iam_policy(self) -> Callable[
            [iam_policy.SetIamPolicyRequest],
            Awaitable[policy.Policy]]:
        r"""Return a callable for the set iam policy method over gRPC.

        Sets the Cloud IAM access control policy for a
        [ServiceAccount][google.iam.admin.v1.ServiceAccount].

        Note: Service accounts are both `resources and
        identities </iam/docs/service-accounts#service_account_permissions>`__.
        This method treats the service account as a resource. Use it to
        grant members access to the service account, such as when they
        need to impersonate it.

        This method does not grant the service account access to other
        resources, such as projects. To grant a service account access
        to resources, include the service account in the Cloud IAM
        policy for the desired resource, then call the appropriate
        ``setIamPolicy`` method on the target resource. For example, to
        grant a service account access to a project, call the
        `projects.setIamPolicy </resource-manager/reference/rest/v1/projects/setIamPolicy>`__
        method.

        Returns:
            Callable[[~.SetIamPolicyRequest],
                    Awaitable[~.Policy]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'set_iam_policy' not in self._stubs:
            self._stubs['set_iam_policy'] = self.grpc_channel.unary_unary(
                '/google.iam.admin.v1.IAM/SetIamPolicy',
                request_serializer=iam_policy.SetIamPolicyRequest.SerializeToString,
                response_deserializer=policy.Policy.FromString,
            )
        return self._stubs['set_iam_policy']

    @property
    def test_iam_permissions(self) -> Callable[
            [iam_policy.TestIamPermissionsRequest],
            Awaitable[iam_policy.TestIamPermissionsResponse]]:
        r"""Return a callable for the test iam permissions method over gRPC.

        Tests the specified permissions against the IAM access control
        policy for a
        [ServiceAccount][google.iam.admin.v1.ServiceAccount].

        Returns:
            Callable[[~.TestIamPermissionsRequest],
                    Awaitable[~.TestIamPermissionsResponse]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'test_iam_permissions' not in self._stubs:
            self._stubs['test_iam_permissions'] = self.grpc_channel.unary_unary(
                '/google.iam.admin.v1.IAM/TestIamPermissions',
                request_serializer=iam_policy.TestIamPermissionsRequest.SerializeToString,
                response_deserializer=iam_policy.TestIamPermissionsResponse.FromString,
            )
        return self._stubs['test_iam_permissions']

    @property
    def query_grantable_roles(self) -> Callable[
            [iam.QueryGrantableRolesRequest],
            Awaitable[iam.QueryGrantableRolesResponse]]:
        r"""Return a callable for the query grantable roles method over gRPC.

        Queries roles that can be granted on a particular
        resource. A role is grantable if it can be used as the
        role in a binding for a policy for that resource.

        Returns:
            Callable[[~.QueryGrantableRolesRequest],
                    Awaitable[~.QueryGrantableRolesResponse]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'query_grantable_roles' not in self._stubs:
            self._stubs['query_grantable_roles'] = self.grpc_channel.unary_unary(
                '/google.iam.admin.v1.IAM/QueryGrantableRoles',
                request_serializer=iam.QueryGrantableRolesRequest.serialize,
                response_deserializer=iam.QueryGrantableRolesResponse.deserialize,
            )
        return self._stubs['query_grantable_roles']

    @property
    def list_roles(self) -> Callable[
            [iam.ListRolesRequest],
            Awaitable[iam.ListRolesResponse]]:
        r"""Return a callable for the list roles method over gRPC.

        Lists the Roles defined on a resource.

        Returns:
            Callable[[~.ListRolesRequest],
                    Awaitable[~.ListRolesResponse]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'list_roles' not in self._stubs:
            self._stubs['list_roles'] = self.grpc_channel.unary_unary(
                '/google.iam.admin.v1.IAM/ListRoles',
                request_serializer=iam.ListRolesRequest.serialize,
                response_deserializer=iam.ListRolesResponse.deserialize,
            )
        return self._stubs['list_roles']

    @property
    def get_role(self) -> Callable[
            [iam.GetRoleRequest],
            Awaitable[iam.Role]]:
        r"""Return a callable for the get role method over gRPC.

        Gets a Role definition.

        Returns:
            Callable[[~.GetRoleRequest],
                    Awaitable[~.Role]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'get_role' not in self._stubs:
            self._stubs['get_role'] = self.grpc_channel.unary_unary(
                '/google.iam.admin.v1.IAM/GetRole',
                request_serializer=iam.GetRoleRequest.serialize,
                response_deserializer=iam.Role.deserialize,
            )
        return self._stubs['get_role']

    @property
    def create_role(self) -> Callable[
            [iam.CreateRoleRequest],
            Awaitable[iam.Role]]:
        r"""Return a callable for the create role method over gRPC.

        Creates a new Role.

        Returns:
            Callable[[~.CreateRoleRequest],
                    Awaitable[~.Role]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'create_role' not in self._stubs:
            self._stubs['create_role'] = self.grpc_channel.unary_unary(
                '/google.iam.admin.v1.IAM/CreateRole',
                request_serializer=iam.CreateRoleRequest.serialize,
                response_deserializer=iam.Role.deserialize,
            )
        return self._stubs['create_role']

    @property
    def update_role(self) -> Callable[
            [iam.UpdateRoleRequest],
            Awaitable[iam.Role]]:
        r"""Return a callable for the update role method over gRPC.

        Updates a Role definition.

        Returns:
            Callable[[~.UpdateRoleRequest],
                    Awaitable[~.Role]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'update_role' not in self._stubs:
            self._stubs['update_role'] = self.grpc_channel.unary_unary(
                '/google.iam.admin.v1.IAM/UpdateRole',
                request_serializer=iam.UpdateRoleRequest.serialize,
                response_deserializer=iam.Role.deserialize,
            )
        return self._stubs['update_role']

    @property
    def delete_role(self) -> Callable[
            [iam.DeleteRoleRequest],
            Awaitable[iam.Role]]:
        r"""Return a callable for the delete role method over gRPC.

        Soft deletes a role. The role is suspended and cannot be used to
        create new IAM Policy Bindings. The Role will not be included in
        ``ListRoles()`` unless ``show_deleted`` is set in the
        ``ListRolesRequest``. The Role contains the deleted boolean set.
        Existing Bindings remains, but are inactive. The Role can be
        undeleted within 7 days. After 7 days the Role is deleted and
        all Bindings associated with the role are removed.

        Returns:
            Callable[[~.DeleteRoleRequest],
                    Awaitable[~.Role]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'delete_role' not in self._stubs:
            self._stubs['delete_role'] = self.grpc_channel.unary_unary(
                '/google.iam.admin.v1.IAM/DeleteRole',
                request_serializer=iam.DeleteRoleRequest.serialize,
                response_deserializer=iam.Role.deserialize,
            )
        return self._stubs['delete_role']

    @property
    def undelete_role(self) -> Callable[
            [iam.UndeleteRoleRequest],
            Awaitable[iam.Role]]:
        r"""Return a callable for the undelete role method over gRPC.

        Undelete a Role, bringing it back in its previous
        state.

        Returns:
            Callable[[~.UndeleteRoleRequest],
                    Awaitable[~.Role]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'undelete_role' not in self._stubs:
            self._stubs['undelete_role'] = self.grpc_channel.unary_unary(
                '/google.iam.admin.v1.IAM/UndeleteRole',
                request_serializer=iam.UndeleteRoleRequest.serialize,
                response_deserializer=iam.Role.deserialize,
            )
        return self._stubs['undelete_role']

    @property
    def query_testable_permissions(self) -> Callable[
            [iam.QueryTestablePermissionsRequest],
            Awaitable[iam.QueryTestablePermissionsResponse]]:
        r"""Return a callable for the query testable permissions method over gRPC.

        Lists the permissions testable on a resource.
        A permission is testable if it can be tested for an
        identity on a resource.

        Returns:
            Callable[[~.QueryTestablePermissionsRequest],
                    Awaitable[~.QueryTestablePermissionsResponse]]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'query_testable_permissions' not in self._stubs:
            self._stubs['query_testable_permissions'] = self.grpc_channel.unary_unary(
                '/google.iam.admin.v1.IAM/QueryTestablePermissions',
                request_serializer=iam.QueryTestablePermissionsRequest.serialize,
                response_deserializer=iam.QueryTestablePermissionsResponse.deserialize,
            )
        return self._stubs['query_testable_permissions']


__all__ = (
    'IAMGrpcAsyncIOTransport',
)
