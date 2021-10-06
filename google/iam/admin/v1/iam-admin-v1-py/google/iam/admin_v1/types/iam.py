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
import proto  # type: ignore

from google.protobuf import field_mask_pb2  # type: ignore
from google.protobuf import timestamp_pb2  # type: ignore
from google.type import expr_pb2  # type: ignore


__protobuf__ = proto.module(
    package='google.iam.admin.v1',
    manifest={
        'ServiceAccountKeyAlgorithm',
        'ServiceAccountPrivateKeyType',
        'ServiceAccountPublicKeyType',
        'ServiceAccountKeyOrigin',
        'RoleView',
        'ServiceAccount',
        'CreateServiceAccountRequest',
        'ListServiceAccountsRequest',
        'ListServiceAccountsResponse',
        'GetServiceAccountRequest',
        'DeleteServiceAccountRequest',
        'PatchServiceAccountRequest',
        'UndeleteServiceAccountRequest',
        'UndeleteServiceAccountResponse',
        'EnableServiceAccountRequest',
        'DisableServiceAccountRequest',
        'ListServiceAccountKeysRequest',
        'ListServiceAccountKeysResponse',
        'GetServiceAccountKeyRequest',
        'ServiceAccountKey',
        'CreateServiceAccountKeyRequest',
        'UploadServiceAccountKeyRequest',
        'DeleteServiceAccountKeyRequest',
        'SignBlobRequest',
        'SignBlobResponse',
        'SignJwtRequest',
        'SignJwtResponse',
        'Role',
        'QueryGrantableRolesRequest',
        'QueryGrantableRolesResponse',
        'ListRolesRequest',
        'ListRolesResponse',
        'GetRoleRequest',
        'CreateRoleRequest',
        'UpdateRoleRequest',
        'DeleteRoleRequest',
        'UndeleteRoleRequest',
        'Permission',
        'QueryTestablePermissionsRequest',
        'QueryTestablePermissionsResponse',
        'QueryAuditableServicesRequest',
        'QueryAuditableServicesResponse',
        'LintPolicyRequest',
        'LintResult',
        'LintPolicyResponse',
    },
)


class ServiceAccountKeyAlgorithm(proto.Enum):
    r"""Supported key algorithms."""
    KEY_ALG_UNSPECIFIED = 0
    KEY_ALG_RSA_1024 = 1
    KEY_ALG_RSA_2048 = 2


class ServiceAccountPrivateKeyType(proto.Enum):
    r"""Supported private key output formats."""
    TYPE_UNSPECIFIED = 0
    TYPE_PKCS12_FILE = 1
    TYPE_GOOGLE_CREDENTIALS_FILE = 2


class ServiceAccountPublicKeyType(proto.Enum):
    r"""Supported public key output formats."""
    TYPE_NONE = 0
    TYPE_X509_PEM_FILE = 1
    TYPE_RAW_PUBLIC_KEY = 2


class ServiceAccountKeyOrigin(proto.Enum):
    r"""Service Account Key Origin."""
    ORIGIN_UNSPECIFIED = 0
    USER_PROVIDED = 1
    GOOGLE_PROVIDED = 2


class RoleView(proto.Enum):
    r"""A view for Role objects."""
    BASIC = 0
    FULL = 1


class ServiceAccount(proto.Message):
    r"""An IAM service account.

    A service account is an account for an application or a virtual
    machine (VM) instance, not a person. You can use a service account
    to call Google APIs. To learn more, read the `overview of service
    accounts <https://cloud.google.com/iam/help/service-accounts/overview>`__.

    When you create a service account, you specify the project ID that
    owns the service account, as well as a name that must be unique
    within the project. IAM uses these values to create an email address
    that identifies the service account.

    Attributes:
        name (str):
            The resource name of the service account.

            Use one of the following formats:

            -  ``projects/{PROJECT_ID}/serviceAccounts/{EMAIL_ADDRESS}``
            -  ``projects/{PROJECT_ID}/serviceAccounts/{UNIQUE_ID}``

            As an alternative, you can use the ``-`` wildcard character
            instead of the project ID:

            -  ``projects/-/serviceAccounts/{EMAIL_ADDRESS}``
            -  ``projects/-/serviceAccounts/{UNIQUE_ID}``

            When possible, avoid using the ``-`` wildcard character,
            because it can cause response messages to contain misleading
            error codes. For example, if you try to get the service
            account ``projects/-/serviceAccounts/fake@example.com``,
            which does not exist, the response contains an HTTP
            ``403 Forbidden`` error instead of a ``404 Not Found``
            error.
        project_id (str):
            Output only. The ID of the project that owns
            the service account.
        unique_id (str):
            Output only. The unique, stable numeric ID
            for the service account.
            Each service account retains its unique ID even
            if you delete the service account. For example,
            if you delete a service account, then create a
            new service account with the same name, the new
            service account has a different unique ID than
            the deleted service account.
        email (str):
            Output only. The email address of the service
            account.
        display_name (str):
            Optional. A user-specified, human-readable
            name for the service account. The maximum length
            is 100 UTF-8 bytes.
        etag (bytes):
            Deprecated. Do not use.
        description (str):
            Optional. A user-specified, human-readable
            description of the service account. The maximum
            length is 256 UTF-8 bytes.
        oauth2_client_id (str):
            Output only. The OAuth 2.0 client ID for the
            service account.
        disabled (bool):
            Output only. Whether the service account is
            disabled.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    project_id = proto.Field(
        proto.STRING,
        number=2,
    )
    unique_id = proto.Field(
        proto.STRING,
        number=4,
    )
    email = proto.Field(
        proto.STRING,
        number=5,
    )
    display_name = proto.Field(
        proto.STRING,
        number=6,
    )
    etag = proto.Field(
        proto.BYTES,
        number=7,
    )
    description = proto.Field(
        proto.STRING,
        number=8,
    )
    oauth2_client_id = proto.Field(
        proto.STRING,
        number=9,
    )
    disabled = proto.Field(
        proto.BOOL,
        number=11,
    )


class CreateServiceAccountRequest(proto.Message):
    r"""The service account create request.

    Attributes:
        name (str):
            Required. The resource name of the project associated with
            the service accounts, such as ``projects/my-project-123``.
        account_id (str):
            Required. The account id that is used to generate the
            service account email address and a stable unique id. It is
            unique within a project, must be 6-30 characters long, and
            match the regular expression ``[a-z]([-a-z0-9]*[a-z0-9])``
            to comply with RFC1035.
        service_account (google.iam.admin_v1.types.ServiceAccount):
            The [ServiceAccount][google.iam.admin.v1.ServiceAccount]
            resource to create. Currently, only the following values are
            user assignable: ``display_name`` and ``description``.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    account_id = proto.Field(
        proto.STRING,
        number=2,
    )
    service_account = proto.Field(
        proto.MESSAGE,
        number=3,
        message='ServiceAccount',
    )


class ListServiceAccountsRequest(proto.Message):
    r"""The service account list request.

    Attributes:
        name (str):
            Required. The resource name of the project associated with
            the service accounts, such as ``projects/my-project-123``.
        page_size (int):
            Optional limit on the number of service accounts to include
            in the response. Further accounts can subsequently be
            obtained by including the
            [ListServiceAccountsResponse.next_page_token][google.iam.admin.v1.ListServiceAccountsResponse.next_page_token]
            in a subsequent request.

            The default is 20, and the maximum is 100.
        page_token (str):
            Optional pagination token returned in an earlier
            [ListServiceAccountsResponse.next_page_token][google.iam.admin.v1.ListServiceAccountsResponse.next_page_token].
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    page_size = proto.Field(
        proto.INT32,
        number=2,
    )
    page_token = proto.Field(
        proto.STRING,
        number=3,
    )


class ListServiceAccountsResponse(proto.Message):
    r"""The service account list response.

    Attributes:
        accounts (Sequence[google.iam.admin_v1.types.ServiceAccount]):
            The list of matching service accounts.
        next_page_token (str):
            To retrieve the next page of results, set
            [ListServiceAccountsRequest.page_token][google.iam.admin.v1.ListServiceAccountsRequest.page_token]
            to this value.
    """

    @property
    def raw_page(self):
        return self

    accounts = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message='ServiceAccount',
    )
    next_page_token = proto.Field(
        proto.STRING,
        number=2,
    )


class GetServiceAccountRequest(proto.Message):
    r"""The service account get request.

    Attributes:
        name (str):
            Required. The resource name of the service account in the
            following format:
            ``projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}``. Using
            ``-`` as a wildcard for the ``PROJECT_ID`` will infer the
            project from the account. The ``ACCOUNT`` value can be the
            ``email`` address or the ``unique_id`` of the service
            account.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )


class DeleteServiceAccountRequest(proto.Message):
    r"""The service account delete request.

    Attributes:
        name (str):
            Required. The resource name of the service account in the
            following format:
            ``projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}``. Using
            ``-`` as a wildcard for the ``PROJECT_ID`` will infer the
            project from the account. The ``ACCOUNT`` value can be the
            ``email`` address or the ``unique_id`` of the service
            account.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )


class PatchServiceAccountRequest(proto.Message):
    r"""The request for
    [PatchServiceAccount][google.iam.admin.v1.PatchServiceAccount].

    You can patch only the ``display_name`` and ``description`` fields.
    You must use the ``update_mask`` field to specify which of these
    fields you want to patch.

    Only the fields specified in the request are guaranteed to be
    returned in the response. Other fields may be empty in the response.

    Attributes:
        service_account (google.iam.admin_v1.types.ServiceAccount):

        update_mask (google.protobuf.field_mask_pb2.FieldMask):

    """

    service_account = proto.Field(
        proto.MESSAGE,
        number=1,
        message='ServiceAccount',
    )
    update_mask = proto.Field(
        proto.MESSAGE,
        number=2,
        message=field_mask_pb2.FieldMask,
    )


class UndeleteServiceAccountRequest(proto.Message):
    r"""The service account undelete request.

    Attributes:
        name (str):
            The resource name of the service account in the following
            format:
            ``projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT_UNIQUE_ID}``.
            Using ``-`` as a wildcard for the ``PROJECT_ID`` will infer
            the project from the account.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )


class UndeleteServiceAccountResponse(proto.Message):
    r"""

    Attributes:
        restored_account (google.iam.admin_v1.types.ServiceAccount):
            Metadata for the restored service account.
    """

    restored_account = proto.Field(
        proto.MESSAGE,
        number=1,
        message='ServiceAccount',
    )


class EnableServiceAccountRequest(proto.Message):
    r"""The service account enable request.

    Attributes:
        name (str):
            The resource name of the service account in the following
            format: ``projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}``.
            Using ``-`` as a wildcard for the ``PROJECT_ID`` will infer
            the project from the account. The ``ACCOUNT`` value can be
            the ``email`` address or the ``unique_id`` of the service
            account.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )


class DisableServiceAccountRequest(proto.Message):
    r"""The service account disable request.

    Attributes:
        name (str):
            The resource name of the service account in the following
            format: ``projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}``.
            Using ``-`` as a wildcard for the ``PROJECT_ID`` will infer
            the project from the account. The ``ACCOUNT`` value can be
            the ``email`` address or the ``unique_id`` of the service
            account.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )


class ListServiceAccountKeysRequest(proto.Message):
    r"""The service account keys list request.

    Attributes:
        name (str):
            Required. The resource name of the service account in the
            following format:
            ``projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}``.

            Using ``-`` as a wildcard for the ``PROJECT_ID``, will infer
            the project from the account. The ``ACCOUNT`` value can be
            the ``email`` address or the ``unique_id`` of the service
            account.
        key_types (Sequence[google.iam.admin_v1.types.ListServiceAccountKeysRequest.KeyType]):
            Filters the types of keys the user wants to
            include in the list response. Duplicate key
            types are not allowed. If no key type is
            provided, all keys are returned.
    """
    class KeyType(proto.Enum):
        r"""``KeyType`` filters to selectively retrieve certain varieties of
        keys.
        """
        KEY_TYPE_UNSPECIFIED = 0
        USER_MANAGED = 1
        SYSTEM_MANAGED = 2

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    key_types = proto.RepeatedField(
        proto.ENUM,
        number=2,
        enum=KeyType,
    )


class ListServiceAccountKeysResponse(proto.Message):
    r"""The service account keys list response.

    Attributes:
        keys (Sequence[google.iam.admin_v1.types.ServiceAccountKey]):
            The public keys for the service account.
    """

    keys = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message='ServiceAccountKey',
    )


class GetServiceAccountKeyRequest(proto.Message):
    r"""The service account key get by id request.

    Attributes:
        name (str):
            Required. The resource name of the service account key in
            the following format:
            ``projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}/keys/{key}``.

            Using ``-`` as a wildcard for the ``PROJECT_ID`` will infer
            the project from the account. The ``ACCOUNT`` value can be
            the ``email`` address or the ``unique_id`` of the service
            account.
        public_key_type (google.iam.admin_v1.types.ServiceAccountPublicKeyType):
            The output format of the public key requested. X509_PEM is
            the default output format.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    public_key_type = proto.Field(
        proto.ENUM,
        number=2,
        enum='ServiceAccountPublicKeyType',
    )


class ServiceAccountKey(proto.Message):
    r"""Represents a service account key.
    A service account has two sets of key-pairs: user-managed, and
    system-managed.

    User-managed key-pairs can be created and deleted by users.
    Users are responsible for rotating these keys periodically to
    ensure security of their service accounts.  Users retain the
    private key of these key-pairs, and Google retains ONLY the
    public key.

    System-managed keys are automatically rotated by Google, and are
    used for signing for a maximum of two weeks. The rotation
    process is probabilistic, and usage of the new key will
    gradually ramp up and down over the key's lifetime.

    If you cache the public key set for a service account, we
    recommend that you update the cache every 15 minutes. User-
    managed keys can be added and removed at any time, so it is
    important to update the cache frequently. For Google-managed
    keys, Google will publish a key at least 6 hours before it is
    first used for signing and will keep publishing it for at least
    6 hours after it was last used for signing.

    Public keys for all service accounts are also published at the
    OAuth2 Service Account API.

    Attributes:
        name (str):
            The resource name of the service account key in the
            following format
            ``projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}/keys/{key}``.
        private_key_type (google.iam.admin_v1.types.ServiceAccountPrivateKeyType):
            The output format for the private key. Only provided in
            ``CreateServiceAccountKey`` responses, not in
            ``GetServiceAccountKey`` or ``ListServiceAccountKey``
            responses.

            Google never exposes system-managed private keys, and never
            retains user-managed private keys.
        key_algorithm (google.iam.admin_v1.types.ServiceAccountKeyAlgorithm):
            Specifies the algorithm (and possibly key
            size) for the key.
        private_key_data (bytes):
            The private key data. Only provided in
            ``CreateServiceAccountKey`` responses. Make sure to keep the
            private key data secure because it allows for the assertion
            of the service account identity. When base64 decoded, the
            private key data can be used to authenticate with Google API
            client libraries and with gcloud auth
            activate-service-account.
        public_key_data (bytes):
            The public key data. Only provided in
            ``GetServiceAccountKey`` responses.
        valid_after_time (google.protobuf.timestamp_pb2.Timestamp):
            The key can be used after this timestamp.
        valid_before_time (google.protobuf.timestamp_pb2.Timestamp):
            The key can be used before this timestamp.
            For system-managed key pairs, this timestamp is
            the end time for the private key signing
            operation. The public key could still be used
            for verification for a few hours after this
            time.
        key_origin (google.iam.admin_v1.types.ServiceAccountKeyOrigin):
            The key origin.
        key_type (google.iam.admin_v1.types.ListServiceAccountKeysRequest.KeyType):
            The key type.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    private_key_type = proto.Field(
        proto.ENUM,
        number=2,
        enum='ServiceAccountPrivateKeyType',
    )
    key_algorithm = proto.Field(
        proto.ENUM,
        number=8,
        enum='ServiceAccountKeyAlgorithm',
    )
    private_key_data = proto.Field(
        proto.BYTES,
        number=3,
    )
    public_key_data = proto.Field(
        proto.BYTES,
        number=7,
    )
    valid_after_time = proto.Field(
        proto.MESSAGE,
        number=4,
        message=timestamp_pb2.Timestamp,
    )
    valid_before_time = proto.Field(
        proto.MESSAGE,
        number=5,
        message=timestamp_pb2.Timestamp,
    )
    key_origin = proto.Field(
        proto.ENUM,
        number=9,
        enum='ServiceAccountKeyOrigin',
    )
    key_type = proto.Field(
        proto.ENUM,
        number=10,
        enum='ListServiceAccountKeysRequest.KeyType',
    )


class CreateServiceAccountKeyRequest(proto.Message):
    r"""The service account key create request.

    Attributes:
        name (str):
            Required. The resource name of the service account in the
            following format:
            ``projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}``. Using
            ``-`` as a wildcard for the ``PROJECT_ID`` will infer the
            project from the account. The ``ACCOUNT`` value can be the
            ``email`` address or the ``unique_id`` of the service
            account.
        private_key_type (google.iam.admin_v1.types.ServiceAccountPrivateKeyType):
            The output format of the private key. The default value is
            ``TYPE_GOOGLE_CREDENTIALS_FILE``, which is the Google
            Credentials File format.
        key_algorithm (google.iam.admin_v1.types.ServiceAccountKeyAlgorithm):
            Which type of key and algorithm to use for
            the key. The default is currently a 2K RSA key.
            However this may change in the future.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    private_key_type = proto.Field(
        proto.ENUM,
        number=2,
        enum='ServiceAccountPrivateKeyType',
    )
    key_algorithm = proto.Field(
        proto.ENUM,
        number=3,
        enum='ServiceAccountKeyAlgorithm',
    )


class UploadServiceAccountKeyRequest(proto.Message):
    r"""The service account key upload request.

    Attributes:
        name (str):
            The resource name of the service account in the following
            format: ``projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}``.
            Using ``-`` as a wildcard for the ``PROJECT_ID`` will infer
            the project from the account. The ``ACCOUNT`` value can be
            the ``email`` address or the ``unique_id`` of the service
            account.
        public_key_data (bytes):
            A field that allows clients to upload their own public key.
            If set, use this public key data to create a service account
            key for given service account. Please note, the expected
            format for this field is X509_PEM.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    public_key_data = proto.Field(
        proto.BYTES,
        number=2,
    )


class DeleteServiceAccountKeyRequest(proto.Message):
    r"""The service account key delete request.

    Attributes:
        name (str):
            Required. The resource name of the service account key in
            the following format:
            ``projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}/keys/{key}``.
            Using ``-`` as a wildcard for the ``PROJECT_ID`` will infer
            the project from the account. The ``ACCOUNT`` value can be
            the ``email`` address or the ``unique_id`` of the service
            account.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )


class SignBlobRequest(proto.Message):
    r"""Deprecated. `Migrate to Service Account Credentials
    API <https://cloud.google.com/iam/help/credentials/migrate-api>`__.

    The service account sign blob request.

    Attributes:
        name (str):
            Required. Deprecated. `Migrate to Service Account
            Credentials
            API <https://cloud.google.com/iam/help/credentials/migrate-api>`__.

            The resource name of the service account in the following
            format: ``projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}``.
            Using ``-`` as a wildcard for the ``PROJECT_ID`` will infer
            the project from the account. The ``ACCOUNT`` value can be
            the ``email`` address or the ``unique_id`` of the service
            account.
        bytes_to_sign (bytes):
            Required. Deprecated. `Migrate to Service Account
            Credentials
            API <https://cloud.google.com/iam/help/credentials/migrate-api>`__.

            The bytes to sign.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    bytes_to_sign = proto.Field(
        proto.BYTES,
        number=2,
    )


class SignBlobResponse(proto.Message):
    r"""Deprecated. `Migrate to Service Account Credentials
    API <https://cloud.google.com/iam/help/credentials/migrate-api>`__.

    The service account sign blob response.

    Attributes:
        key_id (str):
            Deprecated. `Migrate to Service Account Credentials
            API <https://cloud.google.com/iam/help/credentials/migrate-api>`__.

            The id of the key used to sign the blob.
        signature (bytes):
            Deprecated. `Migrate to Service Account Credentials
            API <https://cloud.google.com/iam/help/credentials/migrate-api>`__.

            The signed blob.
    """

    key_id = proto.Field(
        proto.STRING,
        number=1,
    )
    signature = proto.Field(
        proto.BYTES,
        number=2,
    )


class SignJwtRequest(proto.Message):
    r"""Deprecated. `Migrate to Service Account Credentials
    API <https://cloud.google.com/iam/help/credentials/migrate-api>`__.

    The service account sign JWT request.

    Attributes:
        name (str):
            Required. Deprecated. `Migrate to Service Account
            Credentials
            API <https://cloud.google.com/iam/help/credentials/migrate-api>`__.

            The resource name of the service account in the following
            format: ``projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}``.
            Using ``-`` as a wildcard for the ``PROJECT_ID`` will infer
            the project from the account. The ``ACCOUNT`` value can be
            the ``email`` address or the ``unique_id`` of the service
            account.
        payload (str):
            Required. Deprecated. `Migrate to Service Account
            Credentials
            API <https://cloud.google.com/iam/help/credentials/migrate-api>`__.

            The JWT payload to sign. Must be a serialized JSON object
            that contains a JWT Claims Set. For example:
            ``{"sub": "user@example.com", "iat": 313435}``

            If the JWT Claims Set contains an expiration time (``exp``)
            claim, it must be an integer timestamp that is not in the
            past and no more than 1 hour in the future.

            If the JWT Claims Set does not contain an expiration time
            (``exp``) claim, this claim is added automatically, with a
            timestamp that is 1 hour in the future.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    payload = proto.Field(
        proto.STRING,
        number=2,
    )


class SignJwtResponse(proto.Message):
    r"""Deprecated. `Migrate to Service Account Credentials
    API <https://cloud.google.com/iam/help/credentials/migrate-api>`__.

    The service account sign JWT response.

    Attributes:
        key_id (str):
            Deprecated. `Migrate to Service Account Credentials
            API <https://cloud.google.com/iam/help/credentials/migrate-api>`__.

            The id of the key used to sign the JWT.
        signed_jwt (str):
            Deprecated. `Migrate to Service Account Credentials
            API <https://cloud.google.com/iam/help/credentials/migrate-api>`__.

            The signed JWT.
    """

    key_id = proto.Field(
        proto.STRING,
        number=1,
    )
    signed_jwt = proto.Field(
        proto.STRING,
        number=2,
    )


class Role(proto.Message):
    r"""A role in the Identity and Access Management API.

    Attributes:
        name (str):
            The name of the role.

            When Role is used in CreateRole, the role name must not be
            set.

            When Role is used in output and other input such as
            UpdateRole, the role name is the complete path, e.g.,
            roles/logging.viewer for predefined roles and
            organizations/{ORGANIZATION_ID}/roles/logging.viewer for
            custom roles.
        title (str):
            Optional. A human-readable title for the
            role.  Typically this is limited to 100 UTF-8
            bytes.
        description (str):
            Optional. A human-readable description for
            the role.
        included_permissions (Sequence[str]):
            The names of the permissions this role grants
            when bound in an IAM policy.
        stage (google.iam.admin_v1.types.Role.RoleLaunchStage):
            The current launch stage of the role. If the ``ALPHA``
            launch stage has been selected for a role, the ``stage``
            field will not be included in the returned definition for
            the role.
        etag (bytes):
            Used to perform a consistent read-modify-
            rite.
        deleted (bool):
            The current deleted state of the role. This
            field is read only. It will be ignored in calls
            to CreateRole and UpdateRole.
    """
    class RoleLaunchStage(proto.Enum):
        r"""A stage representing a role's lifecycle phase."""
        ALPHA = 0
        BETA = 1
        GA = 2
        DEPRECATED = 4
        DISABLED = 5
        EAP = 6

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    title = proto.Field(
        proto.STRING,
        number=2,
    )
    description = proto.Field(
        proto.STRING,
        number=3,
    )
    included_permissions = proto.RepeatedField(
        proto.STRING,
        number=7,
    )
    stage = proto.Field(
        proto.ENUM,
        number=8,
        enum=RoleLaunchStage,
    )
    etag = proto.Field(
        proto.BYTES,
        number=9,
    )
    deleted = proto.Field(
        proto.BOOL,
        number=11,
    )


class QueryGrantableRolesRequest(proto.Message):
    r"""The grantable role query request.

    Attributes:
        full_resource_name (str):
            Required. The full resource name to query from the list of
            grantable roles.

            The name follows the Google Cloud Platform resource format.
            For example, a Cloud Platform project with id ``my-project``
            will be named
            ``//cloudresourcemanager.googleapis.com/projects/my-project``.
        view (google.iam.admin_v1.types.RoleView):

        page_size (int):
            Optional limit on the number of roles to
            include in the response.
            The default is 300, and the maximum is 1,000.
        page_token (str):
            Optional pagination token returned in an
            earlier QueryGrantableRolesResponse.
    """

    full_resource_name = proto.Field(
        proto.STRING,
        number=1,
    )
    view = proto.Field(
        proto.ENUM,
        number=2,
        enum='RoleView',
    )
    page_size = proto.Field(
        proto.INT32,
        number=3,
    )
    page_token = proto.Field(
        proto.STRING,
        number=4,
    )


class QueryGrantableRolesResponse(proto.Message):
    r"""The grantable role query response.

    Attributes:
        roles (Sequence[google.iam.admin_v1.types.Role]):
            The list of matching roles.
        next_page_token (str):
            To retrieve the next page of results, set
            ``QueryGrantableRolesRequest.page_token`` to this value.
    """

    @property
    def raw_page(self):
        return self

    roles = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message='Role',
    )
    next_page_token = proto.Field(
        proto.STRING,
        number=2,
    )


class ListRolesRequest(proto.Message):
    r"""The request to get all roles defined under a resource.

    Attributes:
        parent (str):
            The ``parent`` parameter's value depends on the target
            resource for the request, namely
            ```roles`` </iam/reference/rest/v1/roles>`__,
            ```projects`` </iam/reference/rest/v1/projects.roles>`__, or
            ```organizations`` </iam/reference/rest/v1/organizations.roles>`__.
            Each resource type's ``parent`` value format is described
            below:

            -  ```roles.list()`` </iam/reference/rest/v1/roles/list>`__:
               An empty string. This method doesn't require a resource;
               it simply returns all `predefined
               roles </iam/docs/understanding-roles#predefined_roles>`__
               in Cloud IAM. Example request URL:
               ``https://iam.googleapis.com/v1/roles``

            -  ```projects.roles.list()`` </iam/reference/rest/v1/projects.roles/list>`__:
               ``projects/{PROJECT_ID}``. This method lists all
               project-level `custom
               roles </iam/docs/understanding-custom-roles>`__. Example
               request URL:
               ``https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles``

            -  ```organizations.roles.list()`` </iam/reference/rest/v1/organizations.roles/list>`__:
               ``organizations/{ORGANIZATION_ID}``. This method lists
               all organization-level `custom
               roles </iam/docs/understanding-custom-roles>`__. Example
               request URL:
               ``https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles``

            Note: Wildcard (*) values are invalid; you must specify a
            complete project ID or organization ID.
        page_size (int):
            Optional limit on the number of roles to
            include in the response.
            The default is 300, and the maximum is 1,000.
        page_token (str):
            Optional pagination token returned in an
            earlier ListRolesResponse.
        view (google.iam.admin_v1.types.RoleView):
            Optional view for the returned Role objects. When ``FULL``
            is specified, the ``includedPermissions`` field is returned,
            which includes a list of all permissions in the role. The
            default value is ``BASIC``, which does not return the
            ``includedPermissions`` field.
        show_deleted (bool):
            Include Roles that have been deleted.
    """

    parent = proto.Field(
        proto.STRING,
        number=1,
    )
    page_size = proto.Field(
        proto.INT32,
        number=2,
    )
    page_token = proto.Field(
        proto.STRING,
        number=3,
    )
    view = proto.Field(
        proto.ENUM,
        number=4,
        enum='RoleView',
    )
    show_deleted = proto.Field(
        proto.BOOL,
        number=6,
    )


class ListRolesResponse(proto.Message):
    r"""The response containing the roles defined under a resource.

    Attributes:
        roles (Sequence[google.iam.admin_v1.types.Role]):
            The Roles defined on this resource.
        next_page_token (str):
            To retrieve the next page of results, set
            ``ListRolesRequest.page_token`` to this value.
    """

    @property
    def raw_page(self):
        return self

    roles = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message='Role',
    )
    next_page_token = proto.Field(
        proto.STRING,
        number=2,
    )


class GetRoleRequest(proto.Message):
    r"""The request to get the definition of an existing role.

    Attributes:
        name (str):
            The ``name`` parameter's value depends on the target
            resource for the request, namely
            ```roles`` </iam/reference/rest/v1/roles>`__,
            ```projects`` </iam/reference/rest/v1/projects.roles>`__, or
            ```organizations`` </iam/reference/rest/v1/organizations.roles>`__.
            Each resource type's ``name`` value format is described
            below:

            -  ```roles.get()`` </iam/reference/rest/v1/roles/get>`__:
               ``roles/{ROLE_NAME}``. This method returns results from
               all `predefined
               roles </iam/docs/understanding-roles#predefined_roles>`__
               in Cloud IAM. Example request URL:
               ``https://iam.googleapis.com/v1/roles/{ROLE_NAME}``

            -  ```projects.roles.get()`` </iam/reference/rest/v1/projects.roles/get>`__:
               ``projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}``. This
               method returns only `custom
               roles </iam/docs/understanding-custom-roles>`__ that have
               been created at the project level. Example request URL:
               ``https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}``

            -  ```organizations.roles.get()`` </iam/reference/rest/v1/organizations.roles/get>`__:
               ``organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}``.
               This method returns only `custom
               roles </iam/docs/understanding-custom-roles>`__ that have
               been created at the organization level. Example request
               URL:
               ``https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}``

            Note: Wildcard (*) values are invalid; you must specify a
            complete project ID or organization ID.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )


class CreateRoleRequest(proto.Message):
    r"""The request to create a new role.

    Attributes:
        parent (str):
            The ``parent`` parameter's value depends on the target
            resource for the request, namely
            ```projects`` </iam/reference/rest/v1/projects.roles>`__ or
            ```organizations`` </iam/reference/rest/v1/organizations.roles>`__.
            Each resource type's ``parent`` value format is described
            below:

            -  ```projects.roles.create()`` </iam/reference/rest/v1/projects.roles/create>`__:
               ``projects/{PROJECT_ID}``. This method creates
               project-level `custom
               roles </iam/docs/understanding-custom-roles>`__. Example
               request URL:
               ``https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles``

            -  ```organizations.roles.create()`` </iam/reference/rest/v1/organizations.roles/create>`__:
               ``organizations/{ORGANIZATION_ID}``. This method creates
               organization-level `custom
               roles </iam/docs/understanding-custom-roles>`__. Example
               request URL:
               ``https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles``

            Note: Wildcard (*) values are invalid; you must specify a
            complete project ID or organization ID.
        role_id (str):
            The role ID to use for this role.

            A role ID may contain alphanumeric characters, underscores
            (``_``), and periods (``.``). It must contain a minimum of 3
            characters and a maximum of 64 characters.
        role (google.iam.admin_v1.types.Role):
            The Role resource to create.
    """

    parent = proto.Field(
        proto.STRING,
        number=1,
    )
    role_id = proto.Field(
        proto.STRING,
        number=2,
    )
    role = proto.Field(
        proto.MESSAGE,
        number=3,
        message='Role',
    )


class UpdateRoleRequest(proto.Message):
    r"""The request to update a role.

    Attributes:
        name (str):
            The ``name`` parameter's value depends on the target
            resource for the request, namely
            ```projects`` </iam/reference/rest/v1/projects.roles>`__ or
            ```organizations`` </iam/reference/rest/v1/organizations.roles>`__.
            Each resource type's ``name`` value format is described
            below:

            -  ```projects.roles.patch()`` </iam/reference/rest/v1/projects.roles/patch>`__:
               ``projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}``. This
               method updates only `custom
               roles </iam/docs/understanding-custom-roles>`__ that have
               been created at the project level. Example request URL:
               ``https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}``

            -  ```organizations.roles.patch()`` </iam/reference/rest/v1/organizations.roles/patch>`__:
               ``organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}``.
               This method updates only `custom
               roles </iam/docs/understanding-custom-roles>`__ that have
               been created at the organization level. Example request
               URL:
               ``https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}``

            Note: Wildcard (*) values are invalid; you must specify a
            complete project ID or organization ID.
        role (google.iam.admin_v1.types.Role):
            The updated role.
        update_mask (google.protobuf.field_mask_pb2.FieldMask):
            A mask describing which fields in the Role
            have changed.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    role = proto.Field(
        proto.MESSAGE,
        number=2,
        message='Role',
    )
    update_mask = proto.Field(
        proto.MESSAGE,
        number=3,
        message=field_mask_pb2.FieldMask,
    )


class DeleteRoleRequest(proto.Message):
    r"""The request to delete an existing role.

    Attributes:
        name (str):
            The ``name`` parameter's value depends on the target
            resource for the request, namely
            ```projects`` </iam/reference/rest/v1/projects.roles>`__ or
            ```organizations`` </iam/reference/rest/v1/organizations.roles>`__.
            Each resource type's ``name`` value format is described
            below:

            -  ```projects.roles.delete()`` </iam/reference/rest/v1/projects.roles/delete>`__:
               ``projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}``. This
               method deletes only `custom
               roles </iam/docs/understanding-custom-roles>`__ that have
               been created at the project level. Example request URL:
               ``https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}``

            -  ```organizations.roles.delete()`` </iam/reference/rest/v1/organizations.roles/delete>`__:
               ``organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}``.
               This method deletes only `custom
               roles </iam/docs/understanding-custom-roles>`__ that have
               been created at the organization level. Example request
               URL:
               ``https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}``

            Note: Wildcard (*) values are invalid; you must specify a
            complete project ID or organization ID.
        etag (bytes):
            Used to perform a consistent read-modify-
            rite.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    etag = proto.Field(
        proto.BYTES,
        number=2,
    )


class UndeleteRoleRequest(proto.Message):
    r"""The request to undelete an existing role.

    Attributes:
        name (str):
            The ``name`` parameter's value depends on the target
            resource for the request, namely
            ```projects`` </iam/reference/rest/v1/projects.roles>`__ or
            ```organizations`` </iam/reference/rest/v1/organizations.roles>`__.
            Each resource type's ``name`` value format is described
            below:

            -  ```projects.roles.undelete()`` </iam/reference/rest/v1/projects.roles/undelete>`__:
               ``projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}``. This
               method undeletes only `custom
               roles </iam/docs/understanding-custom-roles>`__ that have
               been created at the project level. Example request URL:
               ``https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}``

            -  ```organizations.roles.undelete()`` </iam/reference/rest/v1/organizations.roles/undelete>`__:
               ``organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}``.
               This method undeletes only `custom
               roles </iam/docs/understanding-custom-roles>`__ that have
               been created at the organization level. Example request
               URL:
               ``https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}``

            Note: Wildcard (*) values are invalid; you must specify a
            complete project ID or organization ID.
        etag (bytes):
            Used to perform a consistent read-modify-
            rite.
    """

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    etag = proto.Field(
        proto.BYTES,
        number=2,
    )


class Permission(proto.Message):
    r"""A permission which can be included by a role.

    Attributes:
        name (str):
            The name of this Permission.
        title (str):
            The title of this Permission.
        description (str):
            A brief description of what this Permission
            is used for. This permission can ONLY be used in
            predefined roles.
        only_in_predefined_roles (bool):

        stage (google.iam.admin_v1.types.Permission.PermissionLaunchStage):
            The current launch stage of the permission.
        custom_roles_support_level (google.iam.admin_v1.types.Permission.CustomRolesSupportLevel):
            The current custom role support level.
        api_disabled (bool):
            The service API associated with the
            permission is not enabled.
        primary_permission (str):
            The preferred name for this permission. If present, then
            this permission is an alias of, and equivalent to, the
            listed primary_permission.
    """
    class PermissionLaunchStage(proto.Enum):
        r"""A stage representing a permission's lifecycle phase."""
        ALPHA = 0
        BETA = 1
        GA = 2
        DEPRECATED = 3

    class CustomRolesSupportLevel(proto.Enum):
        r"""The state of the permission with regards to custom roles."""
        SUPPORTED = 0
        TESTING = 1
        NOT_SUPPORTED = 2

    name = proto.Field(
        proto.STRING,
        number=1,
    )
    title = proto.Field(
        proto.STRING,
        number=2,
    )
    description = proto.Field(
        proto.STRING,
        number=3,
    )
    only_in_predefined_roles = proto.Field(
        proto.BOOL,
        number=4,
    )
    stage = proto.Field(
        proto.ENUM,
        number=5,
        enum=PermissionLaunchStage,
    )
    custom_roles_support_level = proto.Field(
        proto.ENUM,
        number=6,
        enum=CustomRolesSupportLevel,
    )
    api_disabled = proto.Field(
        proto.BOOL,
        number=7,
    )
    primary_permission = proto.Field(
        proto.STRING,
        number=8,
    )


class QueryTestablePermissionsRequest(proto.Message):
    r"""A request to get permissions which can be tested on a
    resource.

    Attributes:
        full_resource_name (str):
            Required. The full resource name to query from the list of
            testable permissions.

            The name follows the Google Cloud Platform resource format.
            For example, a Cloud Platform project with id ``my-project``
            will be named
            ``//cloudresourcemanager.googleapis.com/projects/my-project``.
        page_size (int):
            Optional limit on the number of permissions
            to include in the response.
            The default is 100, and the maximum is 1,000.
        page_token (str):
            Optional pagination token returned in an
            earlier QueryTestablePermissionsRequest.
    """

    full_resource_name = proto.Field(
        proto.STRING,
        number=1,
    )
    page_size = proto.Field(
        proto.INT32,
        number=2,
    )
    page_token = proto.Field(
        proto.STRING,
        number=3,
    )


class QueryTestablePermissionsResponse(proto.Message):
    r"""The response containing permissions which can be tested on a
    resource.

    Attributes:
        permissions (Sequence[google.iam.admin_v1.types.Permission]):
            The Permissions testable on the requested
            resource.
        next_page_token (str):
            To retrieve the next page of results, set
            ``QueryTestableRolesRequest.page_token`` to this value.
    """

    @property
    def raw_page(self):
        return self

    permissions = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message='Permission',
    )
    next_page_token = proto.Field(
        proto.STRING,
        number=2,
    )


class QueryAuditableServicesRequest(proto.Message):
    r"""A request to get the list of auditable services for a
    resource.

    Attributes:
        full_resource_name (str):
            Required. The full resource name to query from the list of
            auditable services.

            The name follows the Google Cloud Platform resource format.
            For example, a Cloud Platform project with id ``my-project``
            will be named
            ``//cloudresourcemanager.googleapis.com/projects/my-project``.
    """

    full_resource_name = proto.Field(
        proto.STRING,
        number=1,
    )


class QueryAuditableServicesResponse(proto.Message):
    r"""A response containing a list of auditable services for a
    resource.

    Attributes:
        services (Sequence[google.iam.admin_v1.types.QueryAuditableServicesResponse.AuditableService]):
            The auditable services for a resource.
    """

    class AuditableService(proto.Message):
        r"""Contains information about an auditable service.

        Attributes:
            name (str):
                Public name of the service.
                For example, the service name for Cloud IAM is
                'iam.googleapis.com'.
        """

        name = proto.Field(
            proto.STRING,
            number=1,
        )

    services = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message=AuditableService,
    )


class LintPolicyRequest(proto.Message):
    r"""The request to lint a Cloud IAM policy object.

    Attributes:
        full_resource_name (str):
            The full resource name of the policy this lint request is
            about.

            The name follows the Google Cloud Platform (GCP) resource
            format. For example, a GCP project with ID ``my-project``
            will be named
            ``//cloudresourcemanager.googleapis.com/projects/my-project``.

            The resource name is not used to read the policy instance
            from the Cloud IAM database. The candidate policy for lint
            has to be provided in the same request object.
        condition (google.type.expr_pb2.Expr):
            [google.iam.v1.Binding.condition]
            [google.iam.v1.Binding.condition] object to be linted.
    """

    full_resource_name = proto.Field(
        proto.STRING,
        number=1,
    )
    condition = proto.Field(
        proto.MESSAGE,
        number=5,
        oneof='lint_object',
        message=expr_pb2.Expr,
    )


class LintResult(proto.Message):
    r"""Structured response of a single validation unit.

    Attributes:
        level (google.iam.admin_v1.types.LintResult.Level):
            The validation unit level.
        validation_unit_name (str):
            The validation unit name, for instance
            "lintValidationUnits/ConditionComplexityCheck".
        severity (google.iam.admin_v1.types.LintResult.Severity):
            The validation unit severity.
        field_name (str):
            The name of the field for which this lint result is about.

            For nested messages ``field_name`` consists of names of the
            embedded fields separated by period character. The top-level
            qualifier is the input object to lint in the request. For
            example, the ``field_name`` value ``condition.expression``
            identifies a lint result for the ``expression`` field of the
            provided condition.
        location_offset (int):
            0-based character position of problematic construct within
            the object identified by ``field_name``. Currently, this is
            populated only for condition expression.
        debug_message (str):
            Human readable debug message associated with
            the issue.
    """
    class Level(proto.Enum):
        r"""Possible Level values of a validation unit corresponding to
        its domain of discourse.
        """
        LEVEL_UNSPECIFIED = 0
        CONDITION = 3

    class Severity(proto.Enum):
        r"""Possible Severity values of an issued result."""
        SEVERITY_UNSPECIFIED = 0
        ERROR = 1
        WARNING = 2
        NOTICE = 3
        INFO = 4
        DEPRECATED = 5

    level = proto.Field(
        proto.ENUM,
        number=1,
        enum=Level,
    )
    validation_unit_name = proto.Field(
        proto.STRING,
        number=2,
    )
    severity = proto.Field(
        proto.ENUM,
        number=3,
        enum=Severity,
    )
    field_name = proto.Field(
        proto.STRING,
        number=5,
    )
    location_offset = proto.Field(
        proto.INT32,
        number=6,
    )
    debug_message = proto.Field(
        proto.STRING,
        number=7,
    )


class LintPolicyResponse(proto.Message):
    r"""The response of a lint operation. An empty response indicates
    the operation was able to fully execute and no lint issue was
    found.

    Attributes:
        lint_results (Sequence[google.iam.admin_v1.types.LintResult]):
            List of lint results sorted by ``severity`` in descending
            order.
    """

    lint_results = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message='LintResult',
    )


__all__ = tuple(sorted(__protobuf__.manifest))
