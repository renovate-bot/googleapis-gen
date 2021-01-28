# Copyright 2020 Google LLC
#
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
#
#     https://www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.

module Google
  module Iam
    module Admin
      module V1
        # A service account in the Identity and Access Management API.
        #
        # To create a service account, specify the `project_id` and the `account_id`
        # for the account.  The `account_id` is unique within the project, and is used
        # to generate the service account email address and a stable
        # `unique_id`.
        #
        # If the account already exists, the account's resource name is returned
        # in the format of projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}. The caller
        # can use the name in other methods to access the account.
        #
        # All other methods can identify the service account using the format
        # `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`.
        # Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        # the account. The `ACCOUNT` value can be the `email` address or the
        # `unique_id` of the service account.
        # @!attribute [rw] name
        #   @return [String]
        #     The resource name of the service account in the following format:
        #     `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`.
        #
        #     Requests using `-` as a wildcard for the `PROJECT_ID` will infer the
        #     project from the `account` and the `ACCOUNT` value can be the `email`
        #     address or the `unique_id` of the service account.
        #
        #     In responses the resource name will always be in the format
        #     `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`.
        # @!attribute [rw] project_id
        #   @return [String]
        #     @OutputOnly The id of the project that owns the service account.
        # @!attribute [rw] unique_id
        #   @return [String]
        #     @OutputOnly The unique and stable id of the service account.
        # @!attribute [rw] email
        #   @return [String]
        #     @OutputOnly The email address of the service account.
        # @!attribute [rw] display_name
        #   @return [String]
        #     Optional. A user-specified name for the service account.
        #     Must be less than or equal to 100 UTF-8 bytes.
        # @!attribute [rw] etag
        #   @return [String]
        #     Optional. Note: `etag` is an inoperable legacy field that is only returned
        #     for backwards compatibility.
        # @!attribute [rw] oauth2_client_id
        #   @return [String]
        #     @OutputOnly. The OAuth2 client id for the service account.
        #     This is used in conjunction with the OAuth2 clientconfig API to make
        #     three legged OAuth2 (3LO) flows to access the data of Google users.
        class ServiceAccount; end

        # The service account create request.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The resource name of the project associated with the service
        #     accounts, such as `projects/my-project-123`.
        # @!attribute [rw] account_id
        #   @return [String]
        #     Required. The account id that is used to generate the service account
        #     email address and a stable unique id. It is unique within a project,
        #     must be 6-30 characters long, and match the regular expression
        #     `[a-z](https://cloud.google.com[-a-z0-9]*[a-z0-9])` to comply with RFC1035.
        # @!attribute [rw] service_account
        #   @return [Google::Iam::Admin::V1::ServiceAccount]
        #     The {Google::Iam::Admin::V1::ServiceAccount ServiceAccount} resource to
        #     create. Currently, only the following values are user assignable:
        #     `display_name` and `description`.
        class CreateServiceAccountRequest; end

        # The service account list request.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The resource name of the project associated with the service
        #     accounts, such as `projects/my-project-123`.
        # @!attribute [rw] page_size
        #   @return [Integer]
        #     Optional limit on the number of service accounts to include in the
        #     response. Further accounts can subsequently be obtained by including the
        #     {Google::Iam::Admin::V1::ListServiceAccountsResponse#next_page_token ListServiceAccountsResponse#next_page_token}
        #     in a subsequent request.
        # @!attribute [rw] page_token
        #   @return [String]
        #     Optional pagination token returned in an earlier
        #     {Google::Iam::Admin::V1::ListServiceAccountsResponse#next_page_token ListServiceAccountsResponse#next_page_token}.
        class ListServiceAccountsRequest; end

        # The service account list response.
        # @!attribute [rw] accounts
        #   @return [Array<Google::Iam::Admin::V1::ServiceAccount>]
        #     The list of matching service accounts.
        # @!attribute [rw] next_page_token
        #   @return [String]
        #     To retrieve the next page of results, set
        #     {Google::Iam::Admin::V1::ListServiceAccountsRequest#page_token ListServiceAccountsRequest#page_token}
        #     to this value.
        class ListServiceAccountsResponse; end

        # The service account get request.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The resource name of the service account in the following format:
        #     `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`.
        #     Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        #     the account. The `ACCOUNT` value can be the `email` address or the
        #     `unique_id` of the service account.
        class GetServiceAccountRequest; end

        # The service account delete request.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The resource name of the service account in the following format:
        #     `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`.
        #     Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        #     the account. The `ACCOUNT` value can be the `email` address or the
        #     `unique_id` of the service account.
        class DeleteServiceAccountRequest; end

        # The service account keys list request.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The resource name of the service account in the following format:
        #     `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`.
        #
        #     Using `-` as a wildcard for the `PROJECT_ID`, will infer the project from
        #     the account. The `ACCOUNT` value can be the `email` address or the
        #     `unique_id` of the service account.
        # @!attribute [rw] key_types
        #   @return [Array<Google::Iam::Admin::V1::ListServiceAccountKeysRequest::KeyType>]
        #     Filters the types of keys the user wants to include in the list
        #     response. Duplicate key types are not allowed. If no key type
        #     is provided, all keys are returned.
        class ListServiceAccountKeysRequest
          # `KeyType` filters to selectively retrieve certain varieties
          # of keys.
          module KeyType
            # Unspecified key type. The presence of this in the
            # message will immediately result in an error.
            KEY_TYPE_UNSPECIFIED = 0

            # User-managed keys (managed and rotated by the user).
            USER_MANAGED = 1

            # System-managed keys (managed and rotated by Google).
            SYSTEM_MANAGED = 2
          end
        end

        # The service account keys list response.
        # @!attribute [rw] keys
        #   @return [Array<Google::Iam::Admin::V1::ServiceAccountKey>]
        #     The public keys for the service account.
        class ListServiceAccountKeysResponse; end

        # The service account key get by id request.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The resource name of the service account key in the following format:
        #     `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}/keys/{key}`.
        #
        #     Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        #     the account. The `ACCOUNT` value can be the `email` address or the
        #     `unique_id` of the service account.
        # @!attribute [rw] public_key_type
        #   @return [Google::Iam::Admin::V1::ServiceAccountPublicKeyType]
        #     The output format of the public key requested.
        #     X509_PEM is the default output format.
        class GetServiceAccountKeyRequest; end

        # Represents a service account key.
        #
        # A service account has two sets of key-pairs: user-managed, and
        # system-managed.
        #
        # User-managed key-pairs can be created and deleted by users.  Users are
        # responsible for rotating these keys periodically to ensure security of
        # their service accounts.  Users retain the private key of these key-pairs,
        # and Google retains ONLY the public key.
        #
        # System-managed keys are automatically rotated by Google, and are used for
        # signing for a maximum of two weeks. The rotation process is probabilistic,
        # and usage of the new key will gradually ramp up and down over the key's
        # lifetime. We recommend caching the public key set for a service account for
        # no more than 24 hours to ensure you have access to the latest keys.
        #
        # Public keys for all service accounts are also published at the OAuth2
        # Service Account API.
        # @!attribute [rw] name
        #   @return [String]
        #     The resource name of the service account key in the following format
        #     `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}/keys/{key}`.
        # @!attribute [rw] private_key_type
        #   @return [Google::Iam::Admin::V1::ServiceAccountPrivateKeyType]
        #     The output format for the private key.
        #     Only provided in `CreateServiceAccountKey` responses, not
        #     in `GetServiceAccountKey` or `ListServiceAccountKey` responses.
        #
        #     Google never exposes system-managed private keys, and never retains
        #     user-managed private keys.
        # @!attribute [rw] key_algorithm
        #   @return [Google::Iam::Admin::V1::ServiceAccountKeyAlgorithm]
        #     Specifies the algorithm (and possibly key size) for the key.
        # @!attribute [rw] private_key_data
        #   @return [String]
        #     The private key data. Only provided in `CreateServiceAccountKey`
        #     responses. Make sure to keep the private key data secure because it
        #     allows for the assertion of the service account identity.
        #     When base64 decoded, the private key data can be used to authenticate with
        #     Google API client libraries and with
        #     <a href="/sdk/gcloud/reference/auth/activate-service-account">gcloud
        #     auth activate-service-account</a>.
        # @!attribute [rw] public_key_data
        #   @return [String]
        #     The public key data. Only provided in `GetServiceAccountKey` responses.
        # @!attribute [rw] valid_after_time
        #   @return [Google::Protobuf::Timestamp]
        #     The key can be used after this timestamp.
        # @!attribute [rw] valid_before_time
        #   @return [Google::Protobuf::Timestamp]
        #     The key can be used before this timestamp.
        #     For system-managed key pairs, this timestamp is the end time for the
        #     private key signing operation. The public key could still be used
        #     for verification for a few hours after this time.
        class ServiceAccountKey; end

        # The service account key create request.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The resource name of the service account in the following format:
        #     `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`.
        #     Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        #     the account. The `ACCOUNT` value can be the `email` address or the
        #     `unique_id` of the service account.
        # @!attribute [rw] private_key_type
        #   @return [Google::Iam::Admin::V1::ServiceAccountPrivateKeyType]
        #     The output format of the private key. The default value is
        #     `TYPE_GOOGLE_CREDENTIALS_FILE`, which is the Google Credentials File
        #     format.
        # @!attribute [rw] key_algorithm
        #   @return [Google::Iam::Admin::V1::ServiceAccountKeyAlgorithm]
        #     Which type of key and algorithm to use for the key.
        #     The default is currently a 2K RSA key.  However this may change in the
        #     future.
        class CreateServiceAccountKeyRequest; end

        # The service account key delete request.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The resource name of the service account key in the following format:
        #     `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}/keys/{key}`.
        #     Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        #     the account. The `ACCOUNT` value can be the `email` address or the
        #     `unique_id` of the service account.
        class DeleteServiceAccountKeyRequest; end

        # The service account sign blob request.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The resource name of the service account in the following format:
        #     `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`.
        #     Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        #     the account. The `ACCOUNT` value can be the `email` address or the
        #     `unique_id` of the service account.
        # @!attribute [rw] bytes_to_sign
        #   @return [String]
        #     Required. The bytes to sign.
        class SignBlobRequest; end

        # The service account sign blob response.
        # @!attribute [rw] key_id
        #   @return [String]
        #     The id of the key used to sign the blob.
        # @!attribute [rw] signature
        #   @return [String]
        #     The signed blob.
        class SignBlobResponse; end

        # The service account sign JWT request.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The resource name of the service account in the following format:
        #     `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`.
        #     Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
        #     the account. The `ACCOUNT` value can be the `email` address or the
        #     `unique_id` of the service account.
        # @!attribute [rw] payload
        #   @return [String]
        #     Required. The JWT payload to sign, a JSON JWT Claim set.
        class SignJwtRequest; end

        # The service account sign JWT response.
        # @!attribute [rw] key_id
        #   @return [String]
        #     The id of the key used to sign the JWT.
        # @!attribute [rw] signed_jwt
        #   @return [String]
        #     The signed JWT.
        class SignJwtResponse; end

        # A role in the Identity and Access Management API.
        # @!attribute [rw] name
        #   @return [String]
        #     The name of the role.
        #
        #     When Role is used in CreateRole, the role name must not be set.
        #
        #     When Role is used in output and other input such as UpdateRole, the role
        #     name is the complete path, e.g., roles/logging.viewer for predefined roles
        #     and organizations/{ORGANIZATION_ID}/roles/logging.viewer for custom roles.
        # @!attribute [rw] title
        #   @return [String]
        #     Optional. A human-readable title for the role.  Typically this
        #     is limited to 100 UTF-8 bytes.
        # @!attribute [rw] description
        #   @return [String]
        #     Optional. A human-readable description for the role.
        # @!attribute [rw] included_permissions
        #   @return [Array<String>]
        #     The names of the permissions this role grants when bound in an IAM policy.
        # @!attribute [rw] stage
        #   @return [Google::Iam::Admin::V1::Role::RoleLaunchStage]
        #     The current launch stage of the role. If the `ALPHA` launch stage has been
        #     selected for a role, the `stage` field will not be included in the
        #     returned definition for the role.
        # @!attribute [rw] etag
        #   @return [String]
        #     Used to perform a consistent read-modify-write.
        # @!attribute [rw] deleted
        #   @return [true, false]
        #     The current deleted state of the role. This field is read only.
        #     It will be ignored in calls to CreateRole and UpdateRole.
        class Role
          # A stage representing a role's lifecycle phase.
          module RoleLaunchStage
            # The user has indicated this role is currently in an Alpha phase. If this
            # launch stage is selected, the `stage` field will not be included when
            # requesting the definition for a given role.
            ALPHA = 0

            # The user has indicated this role is currently in a Beta phase.
            BETA = 1

            # The user has indicated this role is generally available.
            GA = 2

            # The user has indicated this role is being deprecated.
            DEPRECATED = 4

            # This role is disabled and will not contribute permissions to any members
            # it is granted to in policies.
            DISABLED = 5

            # The user has indicated this role is currently in an EAP phase.
            EAP = 6
          end
        end

        # The grantable role query request.
        # @!attribute [rw] full_resource_name
        #   @return [String]
        #     Required. The full resource name to query from the list of grantable roles.
        #
        #     The name follows the Google Cloud Platform resource format.
        #     For example, a Cloud Platform project with id `my-project` will be named
        #     `//cloudresourcemanager.googleapis.com/projects/my-project`.
        # @!attribute [rw] view
        #   @return [Google::Iam::Admin::V1::RoleView]
        # @!attribute [rw] page_size
        #   @return [Integer]
        #     Optional limit on the number of roles to include in the response.
        # @!attribute [rw] page_token
        #   @return [String]
        #     Optional pagination token returned in an earlier
        #     QueryGrantableRolesResponse.
        class QueryGrantableRolesRequest; end

        # The grantable role query response.
        # @!attribute [rw] roles
        #   @return [Array<Google::Iam::Admin::V1::Role>]
        #     The list of matching roles.
        # @!attribute [rw] next_page_token
        #   @return [String]
        #     To retrieve the next page of results, set
        #     `QueryGrantableRolesRequest.page_token` to this value.
        class QueryGrantableRolesResponse; end

        # The request to get all roles defined under a resource.
        # @!attribute [rw] parent
        #   @return [String]
        #     The `parent` parameter's value depends on the target resource for the
        #     request, namely
        #     [`roles`](https://cloud.google.com/iam/reference/rest/v1/roles),
        #     [`projects`](https://cloud.google.com/iam/reference/rest/v1/projects.roles), or
        #     [`organizations`](https://cloud.google.com/iam/reference/rest/v1/organizations.roles). Each
        #     resource type's `parent` value format is described below:
        #
        #     * [`roles.list()`](https://cloud.google.com/iam/reference/rest/v1/roles/list): An empty string.
        #       This method doesn't require a resource; it simply returns all
        #       [predefined roles](https://cloud.google.com/iam/docs/understanding-roles#predefined_roles) in
        #       Cloud IAM. Example request URL:
        #       `https://iam.googleapis.com/v1/roles`
        #
        #     * [`projects.roles.list()`](https://cloud.google.com/iam/reference/rest/v1/projects.roles/list):
        #       `projects/{PROJECT_ID}`. This method lists all project-level
        #       [custom roles](https://cloud.google.com/iam/docs/understanding-custom-roles).
        #       Example request URL:
        #       `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles`
        #
        #     * [`organizations.roles.list()`](https://cloud.google.com/iam/reference/rest/v1/organizations.roles/list):
        #       `organizations/{ORGANIZATION_ID}`. This method lists all
        #       organization-level [custom roles](https://cloud.google.com/iam/docs/understanding-custom-roles).
        #       Example request URL:
        #       `https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles`
        #
        #     Note: Wildcard (*) values are invalid; you must specify a complete project
        #     ID or organization ID.
        # @!attribute [rw] page_size
        #   @return [Integer]
        #     Optional limit on the number of roles to include in the response.
        # @!attribute [rw] page_token
        #   @return [String]
        #     Optional pagination token returned in an earlier ListRolesResponse.
        # @!attribute [rw] view
        #   @return [Google::Iam::Admin::V1::RoleView]
        #     Optional view for the returned Role objects. When `FULL` is specified,
        #     the `includedPermissions` field is returned, which includes a list of all
        #     permissions in the role. The default value is `BASIC`, which does not
        #     return the `includedPermissions` field.
        # @!attribute [rw] show_deleted
        #   @return [true, false]
        #     Include Roles that have been deleted.
        class ListRolesRequest; end

        # The response containing the roles defined under a resource.
        # @!attribute [rw] roles
        #   @return [Array<Google::Iam::Admin::V1::Role>]
        #     The Roles defined on this resource.
        # @!attribute [rw] next_page_token
        #   @return [String]
        #     To retrieve the next page of results, set
        #     `ListRolesRequest.page_token` to this value.
        class ListRolesResponse; end

        # The request to get the definition of an existing role.
        # @!attribute [rw] name
        #   @return [String]
        #     The `name` parameter's value depends on the target resource for the
        #     request, namely
        #     [`roles`](https://cloud.google.com/iam/reference/rest/v1/roles),
        #     [`projects`](https://cloud.google.com/iam/reference/rest/v1/projects.roles), or
        #     [`organizations`](https://cloud.google.com/iam/reference/rest/v1/organizations.roles). Each
        #     resource type's `name` value format is described below:
        #
        #     * [`roles.get()`](https://cloud.google.com/iam/reference/rest/v1/roles/get): `roles/{ROLE_NAME}`.
        #       This method returns results from all
        #       [predefined roles](https://cloud.google.com/iam/docs/understanding-roles#predefined_roles) in
        #       Cloud IAM. Example request URL:
        #       `https://iam.googleapis.com/v1/roles/{ROLE_NAME}`
        #
        #     * [`projects.roles.get()`](https://cloud.google.com/iam/reference/rest/v1/projects.roles/get):
        #       `projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`. This method returns only
        #       [custom roles](https://cloud.google.com/iam/docs/understanding-custom-roles) that have been
        #       created at the project level. Example request URL:
        #       `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`
        #
        #     * [`organizations.roles.get()`](https://cloud.google.com/iam/reference/rest/v1/organizations.roles/get):
        #       `organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`. This method
        #       returns only [custom roles](https://cloud.google.com/iam/docs/understanding-custom-roles) that
        #       have been created at the organization level. Example request URL:
        #       `https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`
        #
        #     Note: Wildcard (*) values are invalid; you must specify a complete project
        #     ID or organization ID.
        class GetRoleRequest; end

        # The request to create a new role.
        # @!attribute [rw] parent
        #   @return [String]
        #     The `parent` parameter's value depends on the target resource for the
        #     request, namely
        #     [`projects`](https://cloud.google.com/iam/reference/rest/v1/projects.roles) or
        #     [`organizations`](https://cloud.google.com/iam/reference/rest/v1/organizations.roles). Each
        #     resource type's `parent` value format is described below:
        #
        #     * [`projects.roles.create()`](https://cloud.google.com/iam/reference/rest/v1/projects.roles/create):
        #       `projects/{PROJECT_ID}`. This method creates project-level
        #       [custom roles](https://cloud.google.com/iam/docs/understanding-custom-roles).
        #       Example request URL:
        #       `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles`
        #
        #     * [`organizations.roles.create()`](https://cloud.google.com/iam/reference/rest/v1/organizations.roles/create):
        #       `organizations/{ORGANIZATION_ID}`. This method creates organization-level
        #       [custom roles](https://cloud.google.com/iam/docs/understanding-custom-roles). Example request
        #       URL:
        #       `https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles`
        #
        #     Note: Wildcard (*) values are invalid; you must specify a complete project
        #     ID or organization ID.
        # @!attribute [rw] role_id
        #   @return [String]
        #     The role ID to use for this role.
        # @!attribute [rw] role
        #   @return [Google::Iam::Admin::V1::Role]
        #     The Role resource to create.
        class CreateRoleRequest; end

        # The request to update a role.
        # @!attribute [rw] name
        #   @return [String]
        #     The `name` parameter's value depends on the target resource for the
        #     request, namely
        #     [`projects`](https://cloud.google.com/iam/reference/rest/v1/projects.roles) or
        #     [`organizations`](https://cloud.google.com/iam/reference/rest/v1/organizations.roles). Each
        #     resource type's `name` value format is described below:
        #
        #     * [`projects.roles.patch()`](https://cloud.google.com/iam/reference/rest/v1/projects.roles/patch):
        #       `projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`. This method updates only
        #       [custom roles](https://cloud.google.com/iam/docs/understanding-custom-roles) that have been
        #       created at the project level. Example request URL:
        #       `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`
        #
        #     * [`organizations.roles.patch()`](https://cloud.google.com/iam/reference/rest/v1/organizations.roles/patch):
        #       `organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`. This method
        #       updates only [custom roles](https://cloud.google.com/iam/docs/understanding-custom-roles) that
        #       have been created at the organization level. Example request URL:
        #       `https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`
        #
        #     Note: Wildcard (*) values are invalid; you must specify a complete project
        #     ID or organization ID.
        # @!attribute [rw] role
        #   @return [Google::Iam::Admin::V1::Role]
        #     The updated role.
        # @!attribute [rw] update_mask
        #   @return [Google::Protobuf::FieldMask]
        #     A mask describing which fields in the Role have changed.
        class UpdateRoleRequest; end

        # The request to delete an existing role.
        # @!attribute [rw] name
        #   @return [String]
        #     The `name` parameter's value depends on the target resource for the
        #     request, namely
        #     [`projects`](https://cloud.google.com/iam/reference/rest/v1/projects.roles) or
        #     [`organizations`](https://cloud.google.com/iam/reference/rest/v1/organizations.roles). Each
        #     resource type's `name` value format is described below:
        #
        #     * [`projects.roles.delete()`](https://cloud.google.com/iam/reference/rest/v1/projects.roles/delete):
        #       `projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`. This method deletes only
        #       [custom roles](https://cloud.google.com/iam/docs/understanding-custom-roles) that have been
        #       created at the project level. Example request URL:
        #       `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`
        #
        #     * [`organizations.roles.delete()`](https://cloud.google.com/iam/reference/rest/v1/organizations.roles/delete):
        #       `organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`. This method
        #       deletes only [custom roles](https://cloud.google.com/iam/docs/understanding-custom-roles) that
        #       have been created at the organization level. Example request URL:
        #       `https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`
        #
        #     Note: Wildcard (*) values are invalid; you must specify a complete project
        #     ID or organization ID.
        # @!attribute [rw] etag
        #   @return [String]
        #     Used to perform a consistent read-modify-write.
        class DeleteRoleRequest; end

        # The request to undelete an existing role.
        # @!attribute [rw] name
        #   @return [String]
        #     The `name` parameter's value depends on the target resource for the
        #     request, namely
        #     [`projects`](https://cloud.google.com/iam/reference/rest/v1/projects.roles) or
        #     [`organizations`](https://cloud.google.com/iam/reference/rest/v1/organizations.roles). Each
        #     resource type's `name` value format is described below:
        #
        #     * [`projects.roles.undelete()`](https://cloud.google.com/iam/reference/rest/v1/projects.roles/undelete):
        #       `projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`. This method undeletes
        #       only [custom roles](https://cloud.google.com/iam/docs/understanding-custom-roles) that have been
        #       created at the project level. Example request URL:
        #       `https://iam.googleapis.com/v1/projects/{PROJECT_ID}/roles/{CUSTOM_ROLE_ID}`
        #
        #     * [`organizations.roles.undelete()`](https://cloud.google.com/iam/reference/rest/v1/organizations.roles/undelete):
        #       `organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`. This method
        #       undeletes only [custom roles](https://cloud.google.com/iam/docs/understanding-custom-roles) that
        #       have been created at the organization level. Example request URL:
        #       `https://iam.googleapis.com/v1/organizations/{ORGANIZATION_ID}/roles/{CUSTOM_ROLE_ID}`
        #
        #     Note: Wildcard (*) values are invalid; you must specify a complete project
        #     ID or organization ID.
        # @!attribute [rw] etag
        #   @return [String]
        #     Used to perform a consistent read-modify-write.
        class UndeleteRoleRequest; end

        # A permission which can be included by a role.
        # @!attribute [rw] name
        #   @return [String]
        #     The name of this Permission.
        # @!attribute [rw] title
        #   @return [String]
        #     The title of this Permission.
        # @!attribute [rw] description
        #   @return [String]
        #     A brief description of what this Permission is used for.
        #     This permission can ONLY be used in predefined roles.
        # @!attribute [rw] only_in_predefined_roles
        #   @return [true, false]
        #     This permission can ONLY be used in predefined roles.
        # @!attribute [rw] stage
        #   @return [Google::Iam::Admin::V1::Permission::PermissionLaunchStage]
        #     The current launch stage of the permission.
        # @!attribute [rw] custom_roles_support_level
        #   @return [Google::Iam::Admin::V1::Permission::CustomRolesSupportLevel]
        #     The current custom role support level.
        class Permission
          # The state of the permission with regards to custom roles.
          module CustomRolesSupportLevel
            # Permission is fully supported for custom role use.
            SUPPORTED = 0

            # Permission is being tested to check custom role compatibility.
            TESTING = 1

            # Permission is not supported for custom role use.
            NOT_SUPPORTED = 2
          end

          # A stage representing a permission's lifecycle phase.
          module PermissionLaunchStage
            # The permission is currently in an alpha phase.
            ALPHA = 0

            # The permission is currently in a beta phase.
            BETA = 1

            # The permission is generally available.
            GA = 2

            # The permission is being deprecated.
            DEPRECATED = 3
          end
        end

        # A request to get permissions which can be tested on a resource.
        # @!attribute [rw] full_resource_name
        #   @return [String]
        #     Required. The full resource name to query from the list of testable
        #     permissions.
        #
        #     The name follows the Google Cloud Platform resource format.
        #     For example, a Cloud Platform project with id `my-project` will be named
        #     `//cloudresourcemanager.googleapis.com/projects/my-project`.
        # @!attribute [rw] page_size
        #   @return [Integer]
        #     Optional limit on the number of permissions to include in the response.
        # @!attribute [rw] page_token
        #   @return [String]
        #     Optional pagination token returned in an earlier
        #     QueryTestablePermissionsRequest.
        class QueryTestablePermissionsRequest; end

        # The response containing permissions which can be tested on a resource.
        # @!attribute [rw] permissions
        #   @return [Array<Google::Iam::Admin::V1::Permission>]
        #     The Permissions testable on the requested resource.
        # @!attribute [rw] next_page_token
        #   @return [String]
        #     To retrieve the next page of results, set
        #     `QueryTestableRolesRequest.page_token` to this value.
        class QueryTestablePermissionsResponse; end

        # A view for Role objects.
        module RoleView
          # Omits the `included_permissions` field.
          # This is the default value.
          BASIC = 0

          # Returns all fields.
          FULL = 1
        end

        # Supported key algorithms.
        module ServiceAccountKeyAlgorithm
          # An unspecified key algorithm.
          KEY_ALG_UNSPECIFIED = 0

          # 1k RSA Key.
          KEY_ALG_RSA_1024 = 1

          # 2k RSA Key.
          KEY_ALG_RSA_2048 = 2
        end

        # Supported private key output formats.
        module ServiceAccountPrivateKeyType
          # Unspecified. Equivalent to `TYPE_GOOGLE_CREDENTIALS_FILE`.
          TYPE_UNSPECIFIED = 0

          # PKCS12 format.
          # The password for the PKCS12 file is `notasecret`.
          # For more information, see https://tools.ietf.org/html/rfc7292.
          TYPE_PKCS12_FILE = 1

          # Google Credentials File format.
          TYPE_GOOGLE_CREDENTIALS_FILE = 2
        end

        # Supported public key output formats.
        module ServiceAccountPublicKeyType
          # Unspecified. Returns nothing here.
          TYPE_NONE = 0

          # X509 PEM format.
          TYPE_X509_PEM_FILE = 1

          # Raw public key.
          TYPE_RAW_PUBLIC_KEY = 2
        end
      end
    end
  end
end