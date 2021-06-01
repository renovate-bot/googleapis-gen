<?php
// GENERATED CODE -- DO NOT EDIT!

// Original file comments:
// Copyright 2021 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
namespace Google\Cloud\Iam\Admin\V1;

/**
 * Creates and manages Identity and Access Management (IAM) resources.
 *
 * You can use this service to work with all of the following resources:
 *
 * * **Service accounts**, which identify an application or a virtual machine
 *   (VM) instance rather than a person
 * * **Service account keys**, which service accounts use to authenticate with
 *   Google APIs
 * * **IAM policies for service accounts**, which specify the roles that a
 *   member has for the service account
 * * **IAM custom roles**, which help you limit the number of permissions that
 *   you grant to members
 *
 * In addition, you can use this service to complete the following tasks, among
 * others:
 *
 * * Test whether a service account can use specific permissions
 * * Check which roles you can grant for a specific resource
 * * Lint, or validate, condition expressions in an IAM policy
 */
class IAMGrpcClient extends \Grpc\BaseStub {

    /**
     * @param string $hostname hostname
     * @param array $opts channel options
     * @param \Grpc\Channel $channel (optional) re-use channel object
     */
    public function __construct($hostname, $opts, $channel = null) {
        parent::__construct($hostname, $opts, $channel);
    }

    /**
     * Lists every [ServiceAccount][google.iam.admin.v1.ServiceAccount] that belongs to a specific project.
     * @param \Google\Cloud\Iam\Admin\V1\ListServiceAccountsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListServiceAccounts(\Google\Cloud\Iam\Admin\V1\ListServiceAccountsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.iam.admin.v1.IAM/ListServiceAccounts',
        $argument,
        ['\Google\Cloud\Iam\Admin\V1\ListServiceAccountsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
     * @param \Google\Cloud\Iam\Admin\V1\GetServiceAccountRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetServiceAccount(\Google\Cloud\Iam\Admin\V1\GetServiceAccountRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.iam.admin.v1.IAM/GetServiceAccount',
        $argument,
        ['\Google\Cloud\Iam\Admin\V1\ServiceAccount', 'decode'],
        $metadata, $options);
    }

    /**
     * Creates a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
     * @param \Google\Cloud\Iam\Admin\V1\CreateServiceAccountRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateServiceAccount(\Google\Cloud\Iam\Admin\V1\CreateServiceAccountRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.iam.admin.v1.IAM/CreateServiceAccount',
        $argument,
        ['\Google\Cloud\Iam\Admin\V1\ServiceAccount', 'decode'],
        $metadata, $options);
    }

    /**
     * **Note:** We are in the process of deprecating this method. Use
     * [PatchServiceAccount][google.iam.admin.v1.IAM.PatchServiceAccount] instead.
     *
     * Updates a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
     *
     * You can update only the `display_name` and `description` fields.
     * @param \Google\Cloud\Iam\Admin\V1\ServiceAccount $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateServiceAccount(\Google\Cloud\Iam\Admin\V1\ServiceAccount $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.iam.admin.v1.IAM/UpdateServiceAccount',
        $argument,
        ['\Google\Cloud\Iam\Admin\V1\ServiceAccount', 'decode'],
        $metadata, $options);
    }

    /**
     * Patches a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
     * @param \Google\Cloud\Iam\Admin\V1\PatchServiceAccountRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function PatchServiceAccount(\Google\Cloud\Iam\Admin\V1\PatchServiceAccountRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.iam.admin.v1.IAM/PatchServiceAccount',
        $argument,
        ['\Google\Cloud\Iam\Admin\V1\ServiceAccount', 'decode'],
        $metadata, $options);
    }

    /**
     * Deletes a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
     *
     * **Warning:** After you delete a service account, you might not be able to
     * undelete it. If you know that you need to re-enable the service account in
     * the future, use [DisableServiceAccount][google.iam.admin.v1.IAM.DisableServiceAccount] instead.
     *
     * If you delete a service account, IAM permanently removes the service
     * account 30 days later. Google Cloud cannot recover the service account
     * after it is permanently removed, even if you file a support request.
     *
     * To help avoid unplanned outages, we recommend that you disable the service
     * account before you delete it. Use [DisableServiceAccount][google.iam.admin.v1.IAM.DisableServiceAccount] to disable the
     * service account, then wait at least 24 hours and watch for unintended
     * consequences. If there are no unintended consequences, you can delete the
     * service account.
     * @param \Google\Cloud\Iam\Admin\V1\DeleteServiceAccountRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeleteServiceAccount(\Google\Cloud\Iam\Admin\V1\DeleteServiceAccountRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.iam.admin.v1.IAM/DeleteServiceAccount',
        $argument,
        ['\Google\Protobuf\GPBEmpty', 'decode'],
        $metadata, $options);
    }

    /**
     * Restores a deleted [ServiceAccount][google.iam.admin.v1.ServiceAccount].
     *
     * **Important:** It is not always possible to restore a deleted service
     * account. Use this method only as a last resort.
     *
     * After you delete a service account, IAM permanently removes the service
     * account 30 days later. There is no way to restore a deleted service account
     * that has been permanently removed.
     * @param \Google\Cloud\Iam\Admin\V1\UndeleteServiceAccountRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UndeleteServiceAccount(\Google\Cloud\Iam\Admin\V1\UndeleteServiceAccountRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.iam.admin.v1.IAM/UndeleteServiceAccount',
        $argument,
        ['\Google\Cloud\Iam\Admin\V1\UndeleteServiceAccountResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Enables a [ServiceAccount][google.iam.admin.v1.ServiceAccount] that was disabled by
     * [DisableServiceAccount][google.iam.admin.v1.IAM.DisableServiceAccount].
     *
     * If the service account is already enabled, then this method has no effect.
     *
     * If the service account was disabled by other means—for example, if Google
     * disabled the service account because it was compromised—you cannot use this
     * method to enable the service account.
     * @param \Google\Cloud\Iam\Admin\V1\EnableServiceAccountRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function EnableServiceAccount(\Google\Cloud\Iam\Admin\V1\EnableServiceAccountRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.iam.admin.v1.IAM/EnableServiceAccount',
        $argument,
        ['\Google\Protobuf\GPBEmpty', 'decode'],
        $metadata, $options);
    }

    /**
     * Disables a [ServiceAccount][google.iam.admin.v1.ServiceAccount] immediately.
     *
     * If an application uses the service account to authenticate, that
     * application can no longer call Google APIs or access Google Cloud
     * resources. Existing access tokens for the service account are rejected, and
     * requests for new access tokens will fail.
     *
     * To re-enable the service account, use [EnableServiceAccount][google.iam.admin.v1.IAM.EnableServiceAccount]. After you
     * re-enable the service account, its existing access tokens will be accepted,
     * and you can request new access tokens.
     *
     * To help avoid unplanned outages, we recommend that you disable the service
     * account before you delete it. Use this method to disable the service
     * account, then wait at least 24 hours and watch for unintended consequences.
     * If there are no unintended consequences, you can delete the service account
     * with [DeleteServiceAccount][google.iam.admin.v1.IAM.DeleteServiceAccount].
     * @param \Google\Cloud\Iam\Admin\V1\DisableServiceAccountRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DisableServiceAccount(\Google\Cloud\Iam\Admin\V1\DisableServiceAccountRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.iam.admin.v1.IAM/DisableServiceAccount',
        $argument,
        ['\Google\Protobuf\GPBEmpty', 'decode'],
        $metadata, $options);
    }

    /**
     * Lists every [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey] for a service account.
     * @param \Google\Cloud\Iam\Admin\V1\ListServiceAccountKeysRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListServiceAccountKeys(\Google\Cloud\Iam\Admin\V1\ListServiceAccountKeysRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.iam.admin.v1.IAM/ListServiceAccountKeys',
        $argument,
        ['\Google\Cloud\Iam\Admin\V1\ListServiceAccountKeysResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey].
     * @param \Google\Cloud\Iam\Admin\V1\GetServiceAccountKeyRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetServiceAccountKey(\Google\Cloud\Iam\Admin\V1\GetServiceAccountKeyRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.iam.admin.v1.IAM/GetServiceAccountKey',
        $argument,
        ['\Google\Cloud\Iam\Admin\V1\ServiceAccountKey', 'decode'],
        $metadata, $options);
    }

    /**
     * Creates a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey].
     * @param \Google\Cloud\Iam\Admin\V1\CreateServiceAccountKeyRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateServiceAccountKey(\Google\Cloud\Iam\Admin\V1\CreateServiceAccountKeyRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.iam.admin.v1.IAM/CreateServiceAccountKey',
        $argument,
        ['\Google\Cloud\Iam\Admin\V1\ServiceAccountKey', 'decode'],
        $metadata, $options);
    }

    /**
     * Creates a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey], using a public key that you provide.
     * @param \Google\Cloud\Iam\Admin\V1\UploadServiceAccountKeyRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UploadServiceAccountKey(\Google\Cloud\Iam\Admin\V1\UploadServiceAccountKeyRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.iam.admin.v1.IAM/UploadServiceAccountKey',
        $argument,
        ['\Google\Cloud\Iam\Admin\V1\ServiceAccountKey', 'decode'],
        $metadata, $options);
    }

    /**
     * Deletes a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey]. Deleting a service account key does not
     * revoke short-lived credentials that have been issued based on the service
     * account key.
     * @param \Google\Cloud\Iam\Admin\V1\DeleteServiceAccountKeyRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeleteServiceAccountKey(\Google\Cloud\Iam\Admin\V1\DeleteServiceAccountKeyRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.iam.admin.v1.IAM/DeleteServiceAccountKey',
        $argument,
        ['\Google\Protobuf\GPBEmpty', 'decode'],
        $metadata, $options);
    }

    /**
     * **Note:** This method is deprecated. Use the
     * [`signBlob`](https://cloud.google.com/iam/help/rest-credentials/v1/projects.serviceAccounts/signBlob)
     * method in the IAM Service Account Credentials API instead. If you currently
     * use this method, see the [migration
     * guide](https://cloud.google.com/iam/help/credentials/migrate-api) for
     * instructions.
     *
     * Signs a blob using the system-managed private key for a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
     * @param \Google\Cloud\Iam\Admin\V1\SignBlobRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function SignBlob(\Google\Cloud\Iam\Admin\V1\SignBlobRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.iam.admin.v1.IAM/SignBlob',
        $argument,
        ['\Google\Cloud\Iam\Admin\V1\SignBlobResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * **Note:** This method is deprecated. Use the
     * [`signJwt`](https://cloud.google.com/iam/help/rest-credentials/v1/projects.serviceAccounts/signJwt)
     * method in the IAM Service Account Credentials API instead. If you currently
     * use this method, see the [migration
     * guide](https://cloud.google.com/iam/help/credentials/migrate-api) for
     * instructions.
     *
     * Signs a JSON Web Token (JWT) using the system-managed private key for a
     * [ServiceAccount][google.iam.admin.v1.ServiceAccount].
     * @param \Google\Cloud\Iam\Admin\V1\SignJwtRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function SignJwt(\Google\Cloud\Iam\Admin\V1\SignJwtRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.iam.admin.v1.IAM/SignJwt',
        $argument,
        ['\Google\Cloud\Iam\Admin\V1\SignJwtResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets the IAM policy that is attached to a [ServiceAccount][google.iam.admin.v1.ServiceAccount]. This IAM
     * policy specifies which members have access to the service account.
     *
     * This method does not tell you whether the service account has been granted
     * any roles on other resources. To check whether a service account has role
     * grants on a resource, use the `getIamPolicy` method for that resource. For
     * example, to view the role grants for a project, call the Resource Manager
     * API's
     * [`projects.getIamPolicy`](https://cloud.google.com/resource-manager/reference/rest/v1/projects/getIamPolicy)
     * method.
     * @param \Google\Cloud\Iam\V1\GetIamPolicyRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetIamPolicy(\Google\Cloud\Iam\V1\GetIamPolicyRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.iam.admin.v1.IAM/GetIamPolicy',
        $argument,
        ['\Google\Cloud\Iam\V1\Policy', 'decode'],
        $metadata, $options);
    }

    /**
     * Sets the IAM policy that is attached to a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
     *
     * Use this method to grant or revoke access to the service account. For
     * example, you could grant a member the ability to impersonate the service
     * account.
     *
     * This method does not enable the service account to access other resources.
     * To grant roles to a service account on a resource, follow these steps:
     *
     * 1. Call the resource's `getIamPolicy` method to get its current IAM policy.
     * 2. Edit the policy so that it binds the service account to an IAM role for
     * the resource.
     * 3. Call the resource's `setIamPolicy` method to update its IAM policy.
     *
     * For detailed instructions, see
     * [Granting roles to a service account for specific
     * resources](https://cloud.google.com/iam/help/service-accounts/granting-access-to-service-accounts).
     * @param \Google\Cloud\Iam\V1\SetIamPolicyRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function SetIamPolicy(\Google\Cloud\Iam\V1\SetIamPolicyRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.iam.admin.v1.IAM/SetIamPolicy',
        $argument,
        ['\Google\Cloud\Iam\V1\Policy', 'decode'],
        $metadata, $options);
    }

    /**
     * Tests whether the caller has the specified permissions on a
     * [ServiceAccount][google.iam.admin.v1.ServiceAccount].
     * @param \Google\Cloud\Iam\V1\TestIamPermissionsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function TestIamPermissions(\Google\Cloud\Iam\V1\TestIamPermissionsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.iam.admin.v1.IAM/TestIamPermissions',
        $argument,
        ['\Google\Cloud\Iam\V1\TestIamPermissionsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Lists roles that can be granted on a Google Cloud resource. A role is
     * grantable if the IAM policy for the resource can contain bindings to the
     * role.
     * @param \Google\Cloud\Iam\Admin\V1\QueryGrantableRolesRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function QueryGrantableRoles(\Google\Cloud\Iam\Admin\V1\QueryGrantableRolesRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.iam.admin.v1.IAM/QueryGrantableRoles',
        $argument,
        ['\Google\Cloud\Iam\Admin\V1\QueryGrantableRolesResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Lists every predefined [Role][google.iam.admin.v1.Role] that IAM supports, or every custom role
     * that is defined for an organization or project.
     * @param \Google\Cloud\Iam\Admin\V1\ListRolesRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function ListRoles(\Google\Cloud\Iam\Admin\V1\ListRolesRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.iam.admin.v1.IAM/ListRoles',
        $argument,
        ['\Google\Cloud\Iam\Admin\V1\ListRolesResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Gets the definition of a [Role][google.iam.admin.v1.Role].
     * @param \Google\Cloud\Iam\Admin\V1\GetRoleRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function GetRole(\Google\Cloud\Iam\Admin\V1\GetRoleRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.iam.admin.v1.IAM/GetRole',
        $argument,
        ['\Google\Cloud\Iam\Admin\V1\Role', 'decode'],
        $metadata, $options);
    }

    /**
     * Creates a new custom [Role][google.iam.admin.v1.Role].
     * @param \Google\Cloud\Iam\Admin\V1\CreateRoleRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function CreateRole(\Google\Cloud\Iam\Admin\V1\CreateRoleRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.iam.admin.v1.IAM/CreateRole',
        $argument,
        ['\Google\Cloud\Iam\Admin\V1\Role', 'decode'],
        $metadata, $options);
    }

    /**
     * Updates the definition of a custom [Role][google.iam.admin.v1.Role].
     * @param \Google\Cloud\Iam\Admin\V1\UpdateRoleRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UpdateRole(\Google\Cloud\Iam\Admin\V1\UpdateRoleRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.iam.admin.v1.IAM/UpdateRole',
        $argument,
        ['\Google\Cloud\Iam\Admin\V1\Role', 'decode'],
        $metadata, $options);
    }

    /**
     * Deletes a custom [Role][google.iam.admin.v1.Role].
     *
     * When you delete a custom role, the following changes occur immediately:
     *
     * * You cannot bind a member to the custom role in an IAM
     * [Policy][google.iam.v1.Policy].
     * * Existing bindings to the custom role are not changed, but they have no
     * effect.
     * * By default, the response from [ListRoles][google.iam.admin.v1.IAM.ListRoles] does not include the custom
     * role.
     *
     * You have 7 days to undelete the custom role. After 7 days, the following
     * changes occur:
     *
     * * The custom role is permanently deleted and cannot be recovered.
     * * If an IAM policy contains a binding to the custom role, the binding is
     * permanently removed.
     * @param \Google\Cloud\Iam\Admin\V1\DeleteRoleRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function DeleteRole(\Google\Cloud\Iam\Admin\V1\DeleteRoleRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.iam.admin.v1.IAM/DeleteRole',
        $argument,
        ['\Google\Cloud\Iam\Admin\V1\Role', 'decode'],
        $metadata, $options);
    }

    /**
     * Undeletes a custom [Role][google.iam.admin.v1.Role].
     * @param \Google\Cloud\Iam\Admin\V1\UndeleteRoleRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function UndeleteRole(\Google\Cloud\Iam\Admin\V1\UndeleteRoleRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.iam.admin.v1.IAM/UndeleteRole',
        $argument,
        ['\Google\Cloud\Iam\Admin\V1\Role', 'decode'],
        $metadata, $options);
    }

    /**
     * Lists every permission that you can test on a resource. A permission is
     * testable if you can check whether a member has that permission on the
     * resource.
     * @param \Google\Cloud\Iam\Admin\V1\QueryTestablePermissionsRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function QueryTestablePermissions(\Google\Cloud\Iam\Admin\V1\QueryTestablePermissionsRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.iam.admin.v1.IAM/QueryTestablePermissions',
        $argument,
        ['\Google\Cloud\Iam\Admin\V1\QueryTestablePermissionsResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Returns a list of services that allow you to opt into audit logs that are
     * not generated by default.
     *
     * To learn more about audit logs, see the [Logging
     * documentation](https://cloud.google.com/logging/docs/audit).
     * @param \Google\Cloud\Iam\Admin\V1\QueryAuditableServicesRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function QueryAuditableServices(\Google\Cloud\Iam\Admin\V1\QueryAuditableServicesRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.iam.admin.v1.IAM/QueryAuditableServices',
        $argument,
        ['\Google\Cloud\Iam\Admin\V1\QueryAuditableServicesResponse', 'decode'],
        $metadata, $options);
    }

    /**
     * Lints, or validates, an IAM policy. Currently checks the
     * [google.iam.v1.Binding.condition][google.iam.v1.Binding.condition] field, which contains a condition
     * expression for a role binding.
     *
     * Successful calls to this method always return an HTTP `200 OK` status code,
     * even if the linter detects an issue in the IAM policy.
     * @param \Google\Cloud\Iam\Admin\V1\LintPolicyRequest $argument input argument
     * @param array $metadata metadata
     * @param array $options call options
     * @return \Grpc\UnaryCall
     */
    public function LintPolicy(\Google\Cloud\Iam\Admin\V1\LintPolicyRequest $argument,
      $metadata = [], $options = []) {
        return $this->_simpleRequest('/google.iam.admin.v1.IAM/LintPolicy',
        $argument,
        ['\Google\Cloud\Iam\Admin\V1\LintPolicyResponse', 'decode'],
        $metadata, $options);
    }

}
