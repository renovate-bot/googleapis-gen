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
from typing import Callable, Dict, Optional, Sequence, Tuple, Union

from google.api_core import grpc_helpers   # type: ignore
from google.api_core import gapic_v1       # type: ignore
import google.auth                         # type: ignore
from google.auth import credentials as ga_credentials  # type: ignore
from google.auth.transport.grpc import SslCredentials  # type: ignore

import grpc  # type: ignore

from google.cloud.sql_v1.types import cloud_sql_instances
from google.cloud.sql_v1.types import cloud_sql_resources
from .base import SqlInstancesServiceTransport, DEFAULT_CLIENT_INFO


class SqlInstancesServiceGrpcTransport(SqlInstancesServiceTransport):
    """gRPC backend transport for SqlInstancesService.

    Service to manage Cloud SQL instances.

    This class defines the same methods as the primary client, so the
    primary client can load the underlying transport implementation
    and call it.

    It sends protocol buffers over the wire using gRPC (which is built on
    top of HTTP/2); the ``grpcio`` package must be installed.
    """
    _stubs: Dict[str, Callable]

    def __init__(self, *,
            host: str = 'sqladmin.googleapis.com',
            credentials: ga_credentials.Credentials = None,
            credentials_file: str = None,
            scopes: Sequence[str] = None,
            channel: grpc.Channel = None,
            api_mtls_endpoint: str = None,
            client_cert_source: Callable[[], Tuple[bytes, bytes]] = None,
            ssl_channel_credentials: grpc.ChannelCredentials = None,
            client_cert_source_for_mtls: Callable[[], Tuple[bytes, bytes]] = None,
            quota_project_id: Optional[str] = None,
            client_info: gapic_v1.client_info.ClientInfo = DEFAULT_CLIENT_INFO,
            always_use_jwt_access: Optional[bool] = False,
            ) -> None:
        """Instantiate the transport.

        Args:
            host (Optional[str]):
                 The hostname to connect to.
            credentials (Optional[google.auth.credentials.Credentials]): The
                authorization credentials to attach to requests. These
                credentials identify the application to the service; if none
                are specified, the client will attempt to ascertain the
                credentials from the environment.
                This argument is ignored if ``channel`` is provided.
            credentials_file (Optional[str]): A file with credentials that can
                be loaded with :func:`google.auth.load_credentials_from_file`.
                This argument is ignored if ``channel`` is provided.
            scopes (Optional(Sequence[str])): A list of scopes. This argument is
                ignored if ``channel`` is provided.
            channel (Optional[grpc.Channel]): A ``Channel`` instance through
                which to make calls.
            api_mtls_endpoint (Optional[str]): Deprecated. The mutual TLS endpoint.
                If provided, it overrides the ``host`` argument and tries to create
                a mutual TLS channel with client SSL credentials from
                ``client_cert_source`` or application default SSL credentials.
            client_cert_source (Optional[Callable[[], Tuple[bytes, bytes]]]):
                Deprecated. A callback to provide client SSL certificate bytes and
                private key bytes, both in PEM format. It is ignored if
                ``api_mtls_endpoint`` is None.
            ssl_channel_credentials (grpc.ChannelCredentials): SSL credentials
                for the grpc channel. It is ignored if ``channel`` is provided.
            client_cert_source_for_mtls (Optional[Callable[[], Tuple[bytes, bytes]]]):
                A callback to provide client certificate bytes and private key bytes,
                both in PEM format. It is used to configure a mutual TLS channel. It is
                ignored if ``channel`` or ``ssl_channel_credentials`` is provided.
            quota_project_id (Optional[str]): An optional project to use for billing
                and quota.
            client_info (google.api_core.gapic_v1.client_info.ClientInfo):
                The client info used to send a user-agent string along with
                API requests. If ``None``, then default info will be used.
                Generally, you only need to set this if you're developing
                your own client library.
            always_use_jwt_access (Optional[bool]): Whether self signed JWT should
                be used for service account credentials.

        Raises:
          google.auth.exceptions.MutualTLSChannelError: If mutual TLS transport
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
            always_use_jwt_access=always_use_jwt_access,
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

    @classmethod
    def create_channel(cls,
                       host: str = 'sqladmin.googleapis.com',
                       credentials: ga_credentials.Credentials = None,
                       credentials_file: str = None,
                       scopes: Optional[Sequence[str]] = None,
                       quota_project_id: Optional[str] = None,
                       **kwargs) -> grpc.Channel:
        """Create and return a gRPC channel object.
        Args:
            host (Optional[str]): The host for the channel to use.
            credentials (Optional[~.Credentials]): The
                authorization credentials to attach to requests. These
                credentials identify this application to the service. If
                none are specified, the client will attempt to ascertain
                the credentials from the environment.
            credentials_file (Optional[str]): A file with credentials that can
                be loaded with :func:`google.auth.load_credentials_from_file`.
                This argument is mutually exclusive with credentials.
            scopes (Optional[Sequence[str]]): A optional list of scopes needed for this
                service. These are only used when credentials are not specified and
                are passed to :func:`google.auth.default`.
            quota_project_id (Optional[str]): An optional project to use for billing
                and quota.
            kwargs (Optional[dict]): Keyword arguments, which are passed to the
                channel creation.
        Returns:
            grpc.Channel: A gRPC channel object.

        Raises:
            google.api_core.exceptions.DuplicateCredentialArgs: If both ``credentials``
              and ``credentials_file`` are passed.
        """

        return grpc_helpers.create_channel(
            host,
            credentials=credentials,
            credentials_file=credentials_file,
            quota_project_id=quota_project_id,
            default_scopes=cls.AUTH_SCOPES,
            scopes=scopes,
            default_host=cls.DEFAULT_HOST,
            **kwargs
        )

    @property
    def grpc_channel(self) -> grpc.Channel:
        """Return the channel designed to connect to this service.
        """
        return self._grpc_channel

    @property
    def add_server_ca(self) -> Callable[
            [cloud_sql_instances.SqlInstancesAddServerCaRequest],
            cloud_sql_resources.Operation]:
        r"""Return a callable for the add server ca method over gRPC.

        Adds a new trusted Certificate Authority (CA) version
        for the specified instance. Required to prepare for a
        certificate rotation. If a CA version was previously
        added but never used in a certificate rotation, this
        operation replaces that version. There cannot be more
        than one CA version waiting to be rotated in.

        Returns:
            Callable[[~.SqlInstancesAddServerCaRequest],
                    ~.Operation]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'add_server_ca' not in self._stubs:
            self._stubs['add_server_ca'] = self.grpc_channel.unary_unary(
                '/google.cloud.sql.v1.SqlInstancesService/AddServerCa',
                request_serializer=cloud_sql_instances.SqlInstancesAddServerCaRequest.serialize,
                response_deserializer=cloud_sql_resources.Operation.deserialize,
            )
        return self._stubs['add_server_ca']

    @property
    def clone(self) -> Callable[
            [cloud_sql_instances.SqlInstancesCloneRequest],
            cloud_sql_resources.Operation]:
        r"""Return a callable for the clone method over gRPC.

        Creates a Cloud SQL instance as a clone of the source
        instance. Using this operation might cause your instance
        to restart.

        Returns:
            Callable[[~.SqlInstancesCloneRequest],
                    ~.Operation]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'clone' not in self._stubs:
            self._stubs['clone'] = self.grpc_channel.unary_unary(
                '/google.cloud.sql.v1.SqlInstancesService/Clone',
                request_serializer=cloud_sql_instances.SqlInstancesCloneRequest.serialize,
                response_deserializer=cloud_sql_resources.Operation.deserialize,
            )
        return self._stubs['clone']

    @property
    def delete(self) -> Callable[
            [cloud_sql_instances.SqlInstancesDeleteRequest],
            cloud_sql_resources.Operation]:
        r"""Return a callable for the delete method over gRPC.

        Deletes a Cloud SQL instance.

        Returns:
            Callable[[~.SqlInstancesDeleteRequest],
                    ~.Operation]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'delete' not in self._stubs:
            self._stubs['delete'] = self.grpc_channel.unary_unary(
                '/google.cloud.sql.v1.SqlInstancesService/Delete',
                request_serializer=cloud_sql_instances.SqlInstancesDeleteRequest.serialize,
                response_deserializer=cloud_sql_resources.Operation.deserialize,
            )
        return self._stubs['delete']

    @property
    def demote_master(self) -> Callable[
            [cloud_sql_instances.SqlInstancesDemoteMasterRequest],
            cloud_sql_resources.Operation]:
        r"""Return a callable for the demote master method over gRPC.

        Demotes the stand-alone instance to be a Cloud SQL
        read replica for an external database server.

        Returns:
            Callable[[~.SqlInstancesDemoteMasterRequest],
                    ~.Operation]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'demote_master' not in self._stubs:
            self._stubs['demote_master'] = self.grpc_channel.unary_unary(
                '/google.cloud.sql.v1.SqlInstancesService/DemoteMaster',
                request_serializer=cloud_sql_instances.SqlInstancesDemoteMasterRequest.serialize,
                response_deserializer=cloud_sql_resources.Operation.deserialize,
            )
        return self._stubs['demote_master']

    @property
    def export(self) -> Callable[
            [cloud_sql_instances.SqlInstancesExportRequest],
            cloud_sql_resources.Operation]:
        r"""Return a callable for the export method over gRPC.

        Exports data from a Cloud SQL instance to a Cloud
        Storage bucket as a SQL dump or CSV file.

        Returns:
            Callable[[~.SqlInstancesExportRequest],
                    ~.Operation]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'export' not in self._stubs:
            self._stubs['export'] = self.grpc_channel.unary_unary(
                '/google.cloud.sql.v1.SqlInstancesService/Export',
                request_serializer=cloud_sql_instances.SqlInstancesExportRequest.serialize,
                response_deserializer=cloud_sql_resources.Operation.deserialize,
            )
        return self._stubs['export']

    @property
    def failover(self) -> Callable[
            [cloud_sql_instances.SqlInstancesFailoverRequest],
            cloud_sql_resources.Operation]:
        r"""Return a callable for the failover method over gRPC.

        Initiates a manual failover of a high availability (HA) primary
        instance to a standby instance, which becomes the primary
        instance. Users are then rerouted to the new primary. For more
        information, see the `Overview of high
        availability <https://cloud.google.com/sql/docs/mysql/high-availability>`__
        page in the Cloud SQL documentation. If using Legacy HA (MySQL
        only), this causes the instance to failover to its failover
        replica instance.

        Returns:
            Callable[[~.SqlInstancesFailoverRequest],
                    ~.Operation]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'failover' not in self._stubs:
            self._stubs['failover'] = self.grpc_channel.unary_unary(
                '/google.cloud.sql.v1.SqlInstancesService/Failover',
                request_serializer=cloud_sql_instances.SqlInstancesFailoverRequest.serialize,
                response_deserializer=cloud_sql_resources.Operation.deserialize,
            )
        return self._stubs['failover']

    @property
    def get(self) -> Callable[
            [cloud_sql_instances.SqlInstancesGetRequest],
            cloud_sql_instances.DatabaseInstance]:
        r"""Return a callable for the get method over gRPC.

        Retrieves a resource containing information about a
        Cloud SQL instance.

        Returns:
            Callable[[~.SqlInstancesGetRequest],
                    ~.DatabaseInstance]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'get' not in self._stubs:
            self._stubs['get'] = self.grpc_channel.unary_unary(
                '/google.cloud.sql.v1.SqlInstancesService/Get',
                request_serializer=cloud_sql_instances.SqlInstancesGetRequest.serialize,
                response_deserializer=cloud_sql_instances.DatabaseInstance.deserialize,
            )
        return self._stubs['get']

    @property
    def import(self) -> Callable[
            [cloud_sql_instances.SqlInstancesImportRequest],
            cloud_sql_resources.Operation]:
        r"""Return a callable for the import method over gRPC.

        Imports data into a Cloud SQL instance from a SQL
        dump  or CSV file in Cloud Storage.

        Returns:
            Callable[[~.SqlInstancesImportRequest],
                    ~.Operation]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'import' not in self._stubs:
            self._stubs['import'] = self.grpc_channel.unary_unary(
                '/google.cloud.sql.v1.SqlInstancesService/Import',
                request_serializer=cloud_sql_instances.SqlInstancesImportRequest.serialize,
                response_deserializer=cloud_sql_resources.Operation.deserialize,
            )
        return self._stubs['import']

    @property
    def insert(self) -> Callable[
            [cloud_sql_instances.SqlInstancesInsertRequest],
            cloud_sql_resources.Operation]:
        r"""Return a callable for the insert method over gRPC.

        Creates a new Cloud SQL instance.

        Returns:
            Callable[[~.SqlInstancesInsertRequest],
                    ~.Operation]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'insert' not in self._stubs:
            self._stubs['insert'] = self.grpc_channel.unary_unary(
                '/google.cloud.sql.v1.SqlInstancesService/Insert',
                request_serializer=cloud_sql_instances.SqlInstancesInsertRequest.serialize,
                response_deserializer=cloud_sql_resources.Operation.deserialize,
            )
        return self._stubs['insert']

    @property
    def list(self) -> Callable[
            [cloud_sql_instances.SqlInstancesListRequest],
            cloud_sql_instances.InstancesListResponse]:
        r"""Return a callable for the list method over gRPC.

        Lists instances under a given project.

        Returns:
            Callable[[~.SqlInstancesListRequest],
                    ~.InstancesListResponse]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'list' not in self._stubs:
            self._stubs['list'] = self.grpc_channel.unary_unary(
                '/google.cloud.sql.v1.SqlInstancesService/List',
                request_serializer=cloud_sql_instances.SqlInstancesListRequest.serialize,
                response_deserializer=cloud_sql_instances.InstancesListResponse.deserialize,
            )
        return self._stubs['list']

    @property
    def list_server_cas(self) -> Callable[
            [cloud_sql_instances.SqlInstancesListServerCasRequest],
            cloud_sql_instances.InstancesListServerCasResponse]:
        r"""Return a callable for the list server cas method over gRPC.

        Lists all of the trusted Certificate Authorities
        (CAs) for the specified instance. There can be up to
        three CAs listed: the CA that was used to sign the
        certificate that is currently in use, a CA that has been
        added but not yet used to sign a certificate, and a CA
        used to sign a certificate that has previously rotated
        out.

        Returns:
            Callable[[~.SqlInstancesListServerCasRequest],
                    ~.InstancesListServerCasResponse]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'list_server_cas' not in self._stubs:
            self._stubs['list_server_cas'] = self.grpc_channel.unary_unary(
                '/google.cloud.sql.v1.SqlInstancesService/ListServerCas',
                request_serializer=cloud_sql_instances.SqlInstancesListServerCasRequest.serialize,
                response_deserializer=cloud_sql_instances.InstancesListServerCasResponse.deserialize,
            )
        return self._stubs['list_server_cas']

    @property
    def patch(self) -> Callable[
            [cloud_sql_instances.SqlInstancesPatchRequest],
            cloud_sql_resources.Operation]:
        r"""Return a callable for the patch method over gRPC.

        Updates settings of a Cloud SQL instance.
        This method supports patch semantics.

        Returns:
            Callable[[~.SqlInstancesPatchRequest],
                    ~.Operation]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'patch' not in self._stubs:
            self._stubs['patch'] = self.grpc_channel.unary_unary(
                '/google.cloud.sql.v1.SqlInstancesService/Patch',
                request_serializer=cloud_sql_instances.SqlInstancesPatchRequest.serialize,
                response_deserializer=cloud_sql_resources.Operation.deserialize,
            )
        return self._stubs['patch']

    @property
    def promote_replica(self) -> Callable[
            [cloud_sql_instances.SqlInstancesPromoteReplicaRequest],
            cloud_sql_resources.Operation]:
        r"""Return a callable for the promote replica method over gRPC.

        Promotes the read replica instance to be a stand-
        lone Cloud SQL instance. Using this operation might
        cause your instance to restart.

        Returns:
            Callable[[~.SqlInstancesPromoteReplicaRequest],
                    ~.Operation]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'promote_replica' not in self._stubs:
            self._stubs['promote_replica'] = self.grpc_channel.unary_unary(
                '/google.cloud.sql.v1.SqlInstancesService/PromoteReplica',
                request_serializer=cloud_sql_instances.SqlInstancesPromoteReplicaRequest.serialize,
                response_deserializer=cloud_sql_resources.Operation.deserialize,
            )
        return self._stubs['promote_replica']

    @property
    def reset_ssl_config(self) -> Callable[
            [cloud_sql_instances.SqlInstancesResetSslConfigRequest],
            cloud_sql_resources.Operation]:
        r"""Return a callable for the reset ssl config method over gRPC.

        Deletes all client certificates and generates a new
        server SSL certificate for the instance.

        Returns:
            Callable[[~.SqlInstancesResetSslConfigRequest],
                    ~.Operation]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'reset_ssl_config' not in self._stubs:
            self._stubs['reset_ssl_config'] = self.grpc_channel.unary_unary(
                '/google.cloud.sql.v1.SqlInstancesService/ResetSslConfig',
                request_serializer=cloud_sql_instances.SqlInstancesResetSslConfigRequest.serialize,
                response_deserializer=cloud_sql_resources.Operation.deserialize,
            )
        return self._stubs['reset_ssl_config']

    @property
    def restart(self) -> Callable[
            [cloud_sql_instances.SqlInstancesRestartRequest],
            cloud_sql_resources.Operation]:
        r"""Return a callable for the restart method over gRPC.

        Restarts a Cloud SQL instance.

        Returns:
            Callable[[~.SqlInstancesRestartRequest],
                    ~.Operation]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'restart' not in self._stubs:
            self._stubs['restart'] = self.grpc_channel.unary_unary(
                '/google.cloud.sql.v1.SqlInstancesService/Restart',
                request_serializer=cloud_sql_instances.SqlInstancesRestartRequest.serialize,
                response_deserializer=cloud_sql_resources.Operation.deserialize,
            )
        return self._stubs['restart']

    @property
    def restore_backup(self) -> Callable[
            [cloud_sql_instances.SqlInstancesRestoreBackupRequest],
            cloud_sql_resources.Operation]:
        r"""Return a callable for the restore backup method over gRPC.

        Restores a backup of a Cloud SQL instance. Using this
        operation might cause your instance to restart.

        Returns:
            Callable[[~.SqlInstancesRestoreBackupRequest],
                    ~.Operation]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'restore_backup' not in self._stubs:
            self._stubs['restore_backup'] = self.grpc_channel.unary_unary(
                '/google.cloud.sql.v1.SqlInstancesService/RestoreBackup',
                request_serializer=cloud_sql_instances.SqlInstancesRestoreBackupRequest.serialize,
                response_deserializer=cloud_sql_resources.Operation.deserialize,
            )
        return self._stubs['restore_backup']

    @property
    def rotate_server_ca(self) -> Callable[
            [cloud_sql_instances.SqlInstancesRotateServerCaRequest],
            cloud_sql_resources.Operation]:
        r"""Return a callable for the rotate server ca method over gRPC.

        Rotates the server certificate to one signed by the
        Certificate Authority (CA) version previously added with
        the addServerCA method.

        Returns:
            Callable[[~.SqlInstancesRotateServerCaRequest],
                    ~.Operation]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'rotate_server_ca' not in self._stubs:
            self._stubs['rotate_server_ca'] = self.grpc_channel.unary_unary(
                '/google.cloud.sql.v1.SqlInstancesService/RotateServerCa',
                request_serializer=cloud_sql_instances.SqlInstancesRotateServerCaRequest.serialize,
                response_deserializer=cloud_sql_resources.Operation.deserialize,
            )
        return self._stubs['rotate_server_ca']

    @property
    def start_replica(self) -> Callable[
            [cloud_sql_instances.SqlInstancesStartReplicaRequest],
            cloud_sql_resources.Operation]:
        r"""Return a callable for the start replica method over gRPC.

        Starts the replication in the read replica instance.

        Returns:
            Callable[[~.SqlInstancesStartReplicaRequest],
                    ~.Operation]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'start_replica' not in self._stubs:
            self._stubs['start_replica'] = self.grpc_channel.unary_unary(
                '/google.cloud.sql.v1.SqlInstancesService/StartReplica',
                request_serializer=cloud_sql_instances.SqlInstancesStartReplicaRequest.serialize,
                response_deserializer=cloud_sql_resources.Operation.deserialize,
            )
        return self._stubs['start_replica']

    @property
    def stop_replica(self) -> Callable[
            [cloud_sql_instances.SqlInstancesStopReplicaRequest],
            cloud_sql_resources.Operation]:
        r"""Return a callable for the stop replica method over gRPC.

        Stops the replication in the read replica instance.

        Returns:
            Callable[[~.SqlInstancesStopReplicaRequest],
                    ~.Operation]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'stop_replica' not in self._stubs:
            self._stubs['stop_replica'] = self.grpc_channel.unary_unary(
                '/google.cloud.sql.v1.SqlInstancesService/StopReplica',
                request_serializer=cloud_sql_instances.SqlInstancesStopReplicaRequest.serialize,
                response_deserializer=cloud_sql_resources.Operation.deserialize,
            )
        return self._stubs['stop_replica']

    @property
    def truncate_log(self) -> Callable[
            [cloud_sql_instances.SqlInstancesTruncateLogRequest],
            cloud_sql_resources.Operation]:
        r"""Return a callable for the truncate log method over gRPC.

        Truncate MySQL general and slow query log tables
        MySQL only.

        Returns:
            Callable[[~.SqlInstancesTruncateLogRequest],
                    ~.Operation]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'truncate_log' not in self._stubs:
            self._stubs['truncate_log'] = self.grpc_channel.unary_unary(
                '/google.cloud.sql.v1.SqlInstancesService/TruncateLog',
                request_serializer=cloud_sql_instances.SqlInstancesTruncateLogRequest.serialize,
                response_deserializer=cloud_sql_resources.Operation.deserialize,
            )
        return self._stubs['truncate_log']

    @property
    def update(self) -> Callable[
            [cloud_sql_instances.SqlInstancesUpdateRequest],
            cloud_sql_resources.Operation]:
        r"""Return a callable for the update method over gRPC.

        Updates settings of a Cloud SQL instance. Using this
        operation might cause your instance to restart.

        Returns:
            Callable[[~.SqlInstancesUpdateRequest],
                    ~.Operation]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'update' not in self._stubs:
            self._stubs['update'] = self.grpc_channel.unary_unary(
                '/google.cloud.sql.v1.SqlInstancesService/Update',
                request_serializer=cloud_sql_instances.SqlInstancesUpdateRequest.serialize,
                response_deserializer=cloud_sql_resources.Operation.deserialize,
            )
        return self._stubs['update']

    @property
    def create_ephemeral(self) -> Callable[
            [cloud_sql_instances.SqlInstancesCreateEphemeralCertRequest],
            cloud_sql_resources.SslCert]:
        r"""Return a callable for the create ephemeral method over gRPC.

        Generates a short-lived X509 certificate containing
        the provided public key and signed by a private key
        specific to the target instance. Users may use the
        certificate to authenticate as themselves when
        connecting to the database.

        Returns:
            Callable[[~.SqlInstancesCreateEphemeralCertRequest],
                    ~.SslCert]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'create_ephemeral' not in self._stubs:
            self._stubs['create_ephemeral'] = self.grpc_channel.unary_unary(
                '/google.cloud.sql.v1.SqlInstancesService/CreateEphemeral',
                request_serializer=cloud_sql_instances.SqlInstancesCreateEphemeralCertRequest.serialize,
                response_deserializer=cloud_sql_resources.SslCert.deserialize,
            )
        return self._stubs['create_ephemeral']

    @property
    def reschedule_maintenance(self) -> Callable[
            [cloud_sql_instances.SqlInstancesRescheduleMaintenanceRequest],
            cloud_sql_resources.Operation]:
        r"""Return a callable for the reschedule maintenance method over gRPC.

        Reschedules the maintenance on the given instance.

        Returns:
            Callable[[~.SqlInstancesRescheduleMaintenanceRequest],
                    ~.Operation]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'reschedule_maintenance' not in self._stubs:
            self._stubs['reschedule_maintenance'] = self.grpc_channel.unary_unary(
                '/google.cloud.sql.v1.SqlInstancesService/RescheduleMaintenance',
                request_serializer=cloud_sql_instances.SqlInstancesRescheduleMaintenanceRequest.serialize,
                response_deserializer=cloud_sql_resources.Operation.deserialize,
            )
        return self._stubs['reschedule_maintenance']

    @property
    def verify_external_sync_settings(self) -> Callable[
            [cloud_sql_instances.SqlInstancesVerifyExternalSyncSettingsRequest],
            cloud_sql_instances.SqlInstancesVerifyExternalSyncSettingsResponse]:
        r"""Return a callable for the verify external sync settings method over gRPC.

        Verify External primary instance external sync
        settings.

        Returns:
            Callable[[~.SqlInstancesVerifyExternalSyncSettingsRequest],
                    ~.SqlInstancesVerifyExternalSyncSettingsResponse]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'verify_external_sync_settings' not in self._stubs:
            self._stubs['verify_external_sync_settings'] = self.grpc_channel.unary_unary(
                '/google.cloud.sql.v1.SqlInstancesService/VerifyExternalSyncSettings',
                request_serializer=cloud_sql_instances.SqlInstancesVerifyExternalSyncSettingsRequest.serialize,
                response_deserializer=cloud_sql_instances.SqlInstancesVerifyExternalSyncSettingsResponse.deserialize,
            )
        return self._stubs['verify_external_sync_settings']

    @property
    def start_external_sync(self) -> Callable[
            [cloud_sql_instances.SqlInstancesStartExternalSyncRequest],
            cloud_sql_resources.Operation]:
        r"""Return a callable for the start external sync method over gRPC.

        Start External primary instance migration.

        Returns:
            Callable[[~.SqlInstancesStartExternalSyncRequest],
                    ~.Operation]:
                A function that, when called, will call the underlying RPC
                on the server.
        """
        # Generate a "stub function" on-the-fly which will actually make
        # the request.
        # gRPC handles serialization and deserialization, so we just need
        # to pass in the functions for each.
        if 'start_external_sync' not in self._stubs:
            self._stubs['start_external_sync'] = self.grpc_channel.unary_unary(
                '/google.cloud.sql.v1.SqlInstancesService/StartExternalSync',
                request_serializer=cloud_sql_instances.SqlInstancesStartExternalSyncRequest.serialize,
                response_deserializer=cloud_sql_resources.Operation.deserialize,
            )
        return self._stubs['start_external_sync']

    def close(self):
        self.grpc_channel.close()

__all__ = (
    'SqlInstancesServiceGrpcTransport',
)
