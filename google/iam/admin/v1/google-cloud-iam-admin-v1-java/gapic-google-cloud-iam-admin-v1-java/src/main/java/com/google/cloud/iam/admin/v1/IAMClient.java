/*
 * Copyright 2020 Google LLC
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      https://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

package com.google.cloud.iam.admin.v1;

import com.google.api.core.ApiFunction;
import com.google.api.core.ApiFuture;
import com.google.api.core.ApiFutures;
import com.google.api.core.BetaApi;
import com.google.api.gax.core.BackgroundResource;
import com.google.api.gax.paging.AbstractFixedSizeCollection;
import com.google.api.gax.paging.AbstractPage;
import com.google.api.gax.paging.AbstractPagedListResponse;
import com.google.api.gax.rpc.PageContext;
import com.google.api.gax.rpc.UnaryCallable;
import com.google.api.resourcenames.ResourceName;
import com.google.cloud.iam.admin.v1.stub.IAMStub;
import com.google.cloud.iam.admin.v1.stub.IAMStubSettings;
import com.google.common.util.concurrent.MoreExecutors;
import com.google.iam.admin.v1.CreateRoleRequest;
import com.google.iam.admin.v1.CreateServiceAccountKeyRequest;
import com.google.iam.admin.v1.CreateServiceAccountRequest;
import com.google.iam.admin.v1.DeleteRoleRequest;
import com.google.iam.admin.v1.DeleteServiceAccountKeyRequest;
import com.google.iam.admin.v1.DeleteServiceAccountRequest;
import com.google.iam.admin.v1.GetRoleRequest;
import com.google.iam.admin.v1.GetServiceAccountKeyRequest;
import com.google.iam.admin.v1.GetServiceAccountRequest;
import com.google.iam.admin.v1.KeyName;
import com.google.iam.admin.v1.ListRolesRequest;
import com.google.iam.admin.v1.ListRolesResponse;
import com.google.iam.admin.v1.ListServiceAccountKeysRequest;
import com.google.iam.admin.v1.ListServiceAccountKeysResponse;
import com.google.iam.admin.v1.ListServiceAccountsRequest;
import com.google.iam.admin.v1.ListServiceAccountsResponse;
import com.google.iam.admin.v1.Permission;
import com.google.iam.admin.v1.ProjectName;
import com.google.iam.admin.v1.QueryGrantableRolesRequest;
import com.google.iam.admin.v1.QueryGrantableRolesResponse;
import com.google.iam.admin.v1.QueryTestablePermissionsRequest;
import com.google.iam.admin.v1.QueryTestablePermissionsResponse;
import com.google.iam.admin.v1.Role;
import com.google.iam.admin.v1.ServiceAccount;
import com.google.iam.admin.v1.ServiceAccountKey;
import com.google.iam.admin.v1.ServiceAccountKeyAlgorithm;
import com.google.iam.admin.v1.ServiceAccountName;
import com.google.iam.admin.v1.ServiceAccountPrivateKeyType;
import com.google.iam.admin.v1.ServiceAccountPublicKeyType;
import com.google.iam.admin.v1.SignBlobRequest;
import com.google.iam.admin.v1.SignBlobResponse;
import com.google.iam.admin.v1.SignJwtRequest;
import com.google.iam.admin.v1.SignJwtResponse;
import com.google.iam.admin.v1.UndeleteRoleRequest;
import com.google.iam.admin.v1.UpdateRoleRequest;
import com.google.iam.v1.GetIamPolicyRequest;
import com.google.iam.v1.Policy;
import com.google.iam.v1.SetIamPolicyRequest;
import com.google.iam.v1.TestIamPermissionsRequest;
import com.google.iam.v1.TestIamPermissionsResponse;
import com.google.protobuf.ByteString;
import com.google.protobuf.Empty;
import java.io.IOException;
import java.util.List;
import java.util.concurrent.TimeUnit;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * Service Description: Creates and manages service account objects.
 *
 * <p>Service account is an account that belongs to your project instead of to an individual end
 * user. It is used to authenticate calls to a Google API.
 *
 * <p>To create a service account, specify the `project_id` and `account_id` for the account. The
 * `account_id` is unique within the project, and used to generate the service account email address
 * and a stable `unique_id`.
 *
 * <p>All other methods can identify accounts using the format
 * `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`. Using `-` as a wildcard for the `PROJECT_ID`
 * will infer the project from the account. The `ACCOUNT` value can be the `email` address or the
 * `unique_id` of the service account.
 *
 * <p>This class provides the ability to make remote calls to the backing service through method
 * calls that map to API methods. Sample code to get started:
 *
 * <p>Note: close() needs to be called on the IAMClient object to clean up resources such as
 * threads. In the example above, try-with-resources is used, which automatically calls close().
 *
 * <p>The surface of this class includes several types of Java methods for each of the API's
 * methods:
 *
 * <ol>
 *   <li>A "flattened" method. With this type of method, the fields of the request type have been
 *       converted into function parameters. It may be the case that not all fields are available as
 *       parameters, and not every API method will have a flattened method entry point.
 *   <li>A "request object" method. This type of method only takes one parameter, a request object,
 *       which must be constructed before the call. Not every API method will have a request object
 *       method.
 *   <li>A "callable" method. This type of method takes no parameters and returns an immutable API
 *       callable object, which can be used to initiate calls to the service.
 * </ol>
 *
 * <p>See the individual methods for example code.
 *
 * <p>Many parameters require resource names to be formatted in a particular way. To assist with
 * these names, this class includes a format method for each type of name, and additionally a parse
 * method to extract the individual identifiers contained within names that are returned.
 *
 * <p>This class can be customized by passing in a custom instance of IAMSettings to create(). For
 * example:
 *
 * <p>To customize credentials:
 *
 * <pre>{@code
 * IAMSettings iAMSettings =
 *     IAMSettings.newBuilder()
 *         .setCredentialsProvider(FixedCredentialsProvider.create(myCredentials))
 *         .build();
 * IAMClient iAMClient = IAMClient.create(iAMSettings);
 * }</pre>
 *
 * <p>To customize the endpoint:
 *
 * <pre>{@code
 * IAMSettings iAMSettings = IAMSettings.newBuilder().setEndpoint(myEndpoint).build();
 * IAMClient iAMClient = IAMClient.create(iAMSettings);
 * }</pre>
 *
 * <p>Please refer to the GitHub repository's samples for more quickstart code snippets.
 */
@Generated("by gapic-generator-java")
public class IAMClient implements BackgroundResource {
  private final IAMSettings settings;
  private final IAMStub stub;

  /** Constructs an instance of IAMClient with default settings. */
  public static final IAMClient create() throws IOException {
    return create(IAMSettings.newBuilder().build());
  }

  /**
   * Constructs an instance of IAMClient, using the given settings. The channels are created based
   * on the settings passed in, or defaults for any settings that are not set.
   */
  public static final IAMClient create(IAMSettings settings) throws IOException {
    return new IAMClient(settings);
  }

  /**
   * Constructs an instance of IAMClient, using the given stub for making calls. This is for
   * advanced usage - prefer using create(IAMSettings).
   */
  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public static final IAMClient create(IAMStub stub) {
    return new IAMClient(stub);
  }

  /**
   * Constructs an instance of IAMClient, using the given settings. This is protected so that it is
   * easy to make a subclass, but otherwise, the static factory methods should be preferred.
   */
  protected IAMClient(IAMSettings settings) throws IOException {
    this.settings = settings;
    this.stub = ((IAMStubSettings) settings.getStubSettings()).createStub();
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  protected IAMClient(IAMStub stub) {
    this.settings = null;
    this.stub = stub;
  }

  public final IAMSettings getSettings() {
    return settings;
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public IAMStub getStub() {
    return stub;
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists [ServiceAccounts][google.iam.admin.v1.ServiceAccount] for a project.
   *
   * @param name Required. The resource name of the project associated with the service accounts,
   *     such as `projects/my-project-123`.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ListServiceAccountsPagedResponse listServiceAccounts(ProjectName name) {
    ListServiceAccountsRequest request =
        ListServiceAccountsRequest.newBuilder()
            .setName(name == null ? null : name.toString())
            .build();
    return listServiceAccounts(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists [ServiceAccounts][google.iam.admin.v1.ServiceAccount] for a project.
   *
   * @param name Required. The resource name of the project associated with the service accounts,
   *     such as `projects/my-project-123`.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ListServiceAccountsPagedResponse listServiceAccounts(String name) {
    ListServiceAccountsRequest request =
        ListServiceAccountsRequest.newBuilder().setName(name).build();
    return listServiceAccounts(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists [ServiceAccounts][google.iam.admin.v1.ServiceAccount] for a project.
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ListServiceAccountsPagedResponse listServiceAccounts(
      ListServiceAccountsRequest request) {
    return listServiceAccountsPagedCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists [ServiceAccounts][google.iam.admin.v1.ServiceAccount] for a project.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<ListServiceAccountsRequest, ListServiceAccountsPagedResponse>
      listServiceAccountsPagedCallable() {
    return stub.listServiceAccountsPagedCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists [ServiceAccounts][google.iam.admin.v1.ServiceAccount] for a project.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<ListServiceAccountsRequest, ListServiceAccountsResponse>
      listServiceAccountsCallable() {
    return stub.listServiceAccountsCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
   *
   * @param name Required. The resource name of the service account in the following format:
   *     `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`. Using `-` as a wildcard for the
   *     `PROJECT_ID` will infer the project from the account. The `ACCOUNT` value can be the
   *     `email` address or the `unique_id` of the service account.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ServiceAccount getServiceAccount(ServiceAccountName name) {
    GetServiceAccountRequest request =
        GetServiceAccountRequest.newBuilder()
            .setName(name == null ? null : name.toString())
            .build();
    return getServiceAccount(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
   *
   * @param name Required. The resource name of the service account in the following format:
   *     `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`. Using `-` as a wildcard for the
   *     `PROJECT_ID` will infer the project from the account. The `ACCOUNT` value can be the
   *     `email` address or the `unique_id` of the service account.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ServiceAccount getServiceAccount(String name) {
    GetServiceAccountRequest request = GetServiceAccountRequest.newBuilder().setName(name).build();
    return getServiceAccount(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ServiceAccount getServiceAccount(GetServiceAccountRequest request) {
    return getServiceAccountCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
   *
   * <p>Sample code:
   */
  public final UnaryCallable<GetServiceAccountRequest, ServiceAccount> getServiceAccountCallable() {
    return stub.getServiceAccountCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a [ServiceAccount][google.iam.admin.v1.ServiceAccount] and returns it.
   *
   * @param name Required. The resource name of the project associated with the service accounts,
   *     such as `projects/my-project-123`.
   * @param accountId Required. The account id that is used to generate the service account email
   *     address and a stable unique id. It is unique within a project, must be 6-30 characters
   *     long, and match the regular expression `[a-z]([-a-z0-9]&#42;[a-z0-9])` to comply with
   *     RFC1035.
   * @param serviceAccount The [ServiceAccount][google.iam.admin.v1.ServiceAccount] resource to
   *     create. Currently, only the following values are user assignable: `display_name` and
   *     `description`.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ServiceAccount createServiceAccount(
      ProjectName name, String accountId, ServiceAccount serviceAccount) {
    CreateServiceAccountRequest request =
        CreateServiceAccountRequest.newBuilder()
            .setName(name == null ? null : name.toString())
            .setAccountId(accountId)
            .setServiceAccount(serviceAccount)
            .build();
    return createServiceAccount(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a [ServiceAccount][google.iam.admin.v1.ServiceAccount] and returns it.
   *
   * @param name Required. The resource name of the project associated with the service accounts,
   *     such as `projects/my-project-123`.
   * @param accountId Required. The account id that is used to generate the service account email
   *     address and a stable unique id. It is unique within a project, must be 6-30 characters
   *     long, and match the regular expression `[a-z]([-a-z0-9]&#42;[a-z0-9])` to comply with
   *     RFC1035.
   * @param serviceAccount The [ServiceAccount][google.iam.admin.v1.ServiceAccount] resource to
   *     create. Currently, only the following values are user assignable: `display_name` and
   *     `description`.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ServiceAccount createServiceAccount(
      String name, String accountId, ServiceAccount serviceAccount) {
    CreateServiceAccountRequest request =
        CreateServiceAccountRequest.newBuilder()
            .setName(name)
            .setAccountId(accountId)
            .setServiceAccount(serviceAccount)
            .build();
    return createServiceAccount(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a [ServiceAccount][google.iam.admin.v1.ServiceAccount] and returns it.
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ServiceAccount createServiceAccount(CreateServiceAccountRequest request) {
    return createServiceAccountCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a [ServiceAccount][google.iam.admin.v1.ServiceAccount] and returns it.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<CreateServiceAccountRequest, ServiceAccount>
      createServiceAccountCallable() {
    return stub.createServiceAccountCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Updates a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
   *
   * <p>Currently, only the following fields are updatable: `display_name` and `description`.
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ServiceAccount updateServiceAccount(ServiceAccount request) {
    return updateServiceAccountCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Updates a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
   *
   * <p>Currently, only the following fields are updatable: `display_name` and `description`.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<ServiceAccount, ServiceAccount> updateServiceAccountCallable() {
    return stub.updateServiceAccountCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Deletes a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
   *
   * @param name Required. The resource name of the service account in the following format:
   *     `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`. Using `-` as a wildcard for the
   *     `PROJECT_ID` will infer the project from the account. The `ACCOUNT` value can be the
   *     `email` address or the `unique_id` of the service account.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final void deleteServiceAccount(ServiceAccountName name) {
    DeleteServiceAccountRequest request =
        DeleteServiceAccountRequest.newBuilder()
            .setName(name == null ? null : name.toString())
            .build();
    deleteServiceAccount(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Deletes a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
   *
   * @param name Required. The resource name of the service account in the following format:
   *     `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`. Using `-` as a wildcard for the
   *     `PROJECT_ID` will infer the project from the account. The `ACCOUNT` value can be the
   *     `email` address or the `unique_id` of the service account.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final void deleteServiceAccount(String name) {
    DeleteServiceAccountRequest request =
        DeleteServiceAccountRequest.newBuilder().setName(name).build();
    deleteServiceAccount(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Deletes a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final void deleteServiceAccount(DeleteServiceAccountRequest request) {
    deleteServiceAccountCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Deletes a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
   *
   * <p>Sample code:
   */
  public final UnaryCallable<DeleteServiceAccountRequest, Empty> deleteServiceAccountCallable() {
    return stub.deleteServiceAccountCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists [ServiceAccountKeys][google.iam.admin.v1.ServiceAccountKey].
   *
   * @param name Required. The resource name of the service account in the following format:
   *     `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`.
   *     <p>Using `-` as a wildcard for the `PROJECT_ID`, will infer the project from the account.
   *     The `ACCOUNT` value can be the `email` address or the `unique_id` of the service account.
   * @param keyTypes Filters the types of keys the user wants to include in the list response.
   *     Duplicate key types are not allowed. If no key type is provided, all keys are returned.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ListServiceAccountKeysResponse listServiceAccountKeys(
      ServiceAccountName name, List<ListServiceAccountKeysRequest.KeyType> keyTypes) {
    ListServiceAccountKeysRequest request =
        ListServiceAccountKeysRequest.newBuilder()
            .setName(name == null ? null : name.toString())
            .addAllKeyTypes(keyTypes)
            .build();
    return listServiceAccountKeys(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists [ServiceAccountKeys][google.iam.admin.v1.ServiceAccountKey].
   *
   * @param name Required. The resource name of the service account in the following format:
   *     `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`.
   *     <p>Using `-` as a wildcard for the `PROJECT_ID`, will infer the project from the account.
   *     The `ACCOUNT` value can be the `email` address or the `unique_id` of the service account.
   * @param keyTypes Filters the types of keys the user wants to include in the list response.
   *     Duplicate key types are not allowed. If no key type is provided, all keys are returned.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ListServiceAccountKeysResponse listServiceAccountKeys(
      String name, List<ListServiceAccountKeysRequest.KeyType> keyTypes) {
    ListServiceAccountKeysRequest request =
        ListServiceAccountKeysRequest.newBuilder().setName(name).addAllKeyTypes(keyTypes).build();
    return listServiceAccountKeys(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists [ServiceAccountKeys][google.iam.admin.v1.ServiceAccountKey].
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ListServiceAccountKeysResponse listServiceAccountKeys(
      ListServiceAccountKeysRequest request) {
    return listServiceAccountKeysCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists [ServiceAccountKeys][google.iam.admin.v1.ServiceAccountKey].
   *
   * <p>Sample code:
   */
  public final UnaryCallable<ListServiceAccountKeysRequest, ListServiceAccountKeysResponse>
      listServiceAccountKeysCallable() {
    return stub.listServiceAccountKeysCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets the [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey] by key id.
   *
   * @param name Required. The resource name of the service account key in the following format:
   *     `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}/keys/{key}`.
   *     <p>Using `-` as a wildcard for the `PROJECT_ID` will infer the project from the account.
   *     The `ACCOUNT` value can be the `email` address or the `unique_id` of the service account.
   * @param publicKeyType The output format of the public key requested. X509_PEM is the default
   *     output format.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ServiceAccountKey getServiceAccountKey(
      KeyName name, ServiceAccountPublicKeyType publicKeyType) {
    GetServiceAccountKeyRequest request =
        GetServiceAccountKeyRequest.newBuilder()
            .setName(name == null ? null : name.toString())
            .setPublicKeyType(publicKeyType)
            .build();
    return getServiceAccountKey(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets the [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey] by key id.
   *
   * @param name Required. The resource name of the service account key in the following format:
   *     `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}/keys/{key}`.
   *     <p>Using `-` as a wildcard for the `PROJECT_ID` will infer the project from the account.
   *     The `ACCOUNT` value can be the `email` address or the `unique_id` of the service account.
   * @param publicKeyType The output format of the public key requested. X509_PEM is the default
   *     output format.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ServiceAccountKey getServiceAccountKey(
      String name, ServiceAccountPublicKeyType publicKeyType) {
    GetServiceAccountKeyRequest request =
        GetServiceAccountKeyRequest.newBuilder()
            .setName(name)
            .setPublicKeyType(publicKeyType)
            .build();
    return getServiceAccountKey(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets the [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey] by key id.
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ServiceAccountKey getServiceAccountKey(GetServiceAccountKeyRequest request) {
    return getServiceAccountKeyCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets the [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey] by key id.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<GetServiceAccountKeyRequest, ServiceAccountKey>
      getServiceAccountKeyCallable() {
    return stub.getServiceAccountKeyCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey] and returns it.
   *
   * @param name Required. The resource name of the service account in the following format:
   *     `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`. Using `-` as a wildcard for the
   *     `PROJECT_ID` will infer the project from the account. The `ACCOUNT` value can be the
   *     `email` address or the `unique_id` of the service account.
   * @param privateKeyType The output format of the private key. The default value is
   *     `TYPE_GOOGLE_CREDENTIALS_FILE`, which is the Google Credentials File format.
   * @param keyAlgorithm Which type of key and algorithm to use for the key. The default is
   *     currently a 2K RSA key. However this may change in the future.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ServiceAccountKey createServiceAccountKey(
      ServiceAccountName name,
      ServiceAccountPrivateKeyType privateKeyType,
      ServiceAccountKeyAlgorithm keyAlgorithm) {
    CreateServiceAccountKeyRequest request =
        CreateServiceAccountKeyRequest.newBuilder()
            .setName(name == null ? null : name.toString())
            .setPrivateKeyType(privateKeyType)
            .setKeyAlgorithm(keyAlgorithm)
            .build();
    return createServiceAccountKey(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey] and returns it.
   *
   * @param name Required. The resource name of the service account in the following format:
   *     `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`. Using `-` as a wildcard for the
   *     `PROJECT_ID` will infer the project from the account. The `ACCOUNT` value can be the
   *     `email` address or the `unique_id` of the service account.
   * @param privateKeyType The output format of the private key. The default value is
   *     `TYPE_GOOGLE_CREDENTIALS_FILE`, which is the Google Credentials File format.
   * @param keyAlgorithm Which type of key and algorithm to use for the key. The default is
   *     currently a 2K RSA key. However this may change in the future.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ServiceAccountKey createServiceAccountKey(
      String name,
      ServiceAccountPrivateKeyType privateKeyType,
      ServiceAccountKeyAlgorithm keyAlgorithm) {
    CreateServiceAccountKeyRequest request =
        CreateServiceAccountKeyRequest.newBuilder()
            .setName(name)
            .setPrivateKeyType(privateKeyType)
            .setKeyAlgorithm(keyAlgorithm)
            .build();
    return createServiceAccountKey(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey] and returns it.
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ServiceAccountKey createServiceAccountKey(CreateServiceAccountKeyRequest request) {
    return createServiceAccountKeyCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey] and returns it.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<CreateServiceAccountKeyRequest, ServiceAccountKey>
      createServiceAccountKeyCallable() {
    return stub.createServiceAccountKeyCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Deletes a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey].
   *
   * @param name Required. The resource name of the service account key in the following format:
   *     `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}/keys/{key}`. Using `-` as a wildcard for
   *     the `PROJECT_ID` will infer the project from the account. The `ACCOUNT` value can be the
   *     `email` address or the `unique_id` of the service account.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final void deleteServiceAccountKey(KeyName name) {
    DeleteServiceAccountKeyRequest request =
        DeleteServiceAccountKeyRequest.newBuilder()
            .setName(name == null ? null : name.toString())
            .build();
    deleteServiceAccountKey(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Deletes a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey].
   *
   * @param name Required. The resource name of the service account key in the following format:
   *     `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}/keys/{key}`. Using `-` as a wildcard for
   *     the `PROJECT_ID` will infer the project from the account. The `ACCOUNT` value can be the
   *     `email` address or the `unique_id` of the service account.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final void deleteServiceAccountKey(String name) {
    DeleteServiceAccountKeyRequest request =
        DeleteServiceAccountKeyRequest.newBuilder().setName(name).build();
    deleteServiceAccountKey(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Deletes a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey].
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final void deleteServiceAccountKey(DeleteServiceAccountKeyRequest request) {
    deleteServiceAccountKeyCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Deletes a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey].
   *
   * <p>Sample code:
   */
  public final UnaryCallable<DeleteServiceAccountKeyRequest, Empty>
      deleteServiceAccountKeyCallable() {
    return stub.deleteServiceAccountKeyCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Signs a blob using a service account's system-managed private key.
   *
   * @param name Required. The resource name of the service account in the following format:
   *     `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`. Using `-` as a wildcard for the
   *     `PROJECT_ID` will infer the project from the account. The `ACCOUNT` value can be the
   *     `email` address or the `unique_id` of the service account.
   * @param bytesToSign Required. The bytes to sign.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final SignBlobResponse signBlob(ServiceAccountName name, ByteString bytesToSign) {
    SignBlobRequest request =
        SignBlobRequest.newBuilder()
            .setName(name == null ? null : name.toString())
            .setBytesToSign(bytesToSign)
            .build();
    return signBlob(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Signs a blob using a service account's system-managed private key.
   *
   * @param name Required. The resource name of the service account in the following format:
   *     `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`. Using `-` as a wildcard for the
   *     `PROJECT_ID` will infer the project from the account. The `ACCOUNT` value can be the
   *     `email` address or the `unique_id` of the service account.
   * @param bytesToSign Required. The bytes to sign.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final SignBlobResponse signBlob(String name, ByteString bytesToSign) {
    SignBlobRequest request =
        SignBlobRequest.newBuilder().setName(name).setBytesToSign(bytesToSign).build();
    return signBlob(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Signs a blob using a service account's system-managed private key.
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final SignBlobResponse signBlob(SignBlobRequest request) {
    return signBlobCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Signs a blob using a service account's system-managed private key.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<SignBlobRequest, SignBlobResponse> signBlobCallable() {
    return stub.signBlobCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Signs a JWT using a service account's system-managed private key.
   *
   * <p>If no expiry time (`exp`) is provided in the `SignJwtRequest`, IAM sets an an expiry time of
   * one hour by default. If you request an expiry time of more than one hour, the request will
   * fail.
   *
   * @param name Required. The resource name of the service account in the following format:
   *     `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`. Using `-` as a wildcard for the
   *     `PROJECT_ID` will infer the project from the account. The `ACCOUNT` value can be the
   *     `email` address or the `unique_id` of the service account.
   * @param payload Required. The JWT payload to sign, a JSON JWT Claim set.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final SignJwtResponse signJwt(ServiceAccountName name, String payload) {
    SignJwtRequest request =
        SignJwtRequest.newBuilder()
            .setName(name == null ? null : name.toString())
            .setPayload(payload)
            .build();
    return signJwt(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Signs a JWT using a service account's system-managed private key.
   *
   * <p>If no expiry time (`exp`) is provided in the `SignJwtRequest`, IAM sets an an expiry time of
   * one hour by default. If you request an expiry time of more than one hour, the request will
   * fail.
   *
   * @param name Required. The resource name of the service account in the following format:
   *     `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`. Using `-` as a wildcard for the
   *     `PROJECT_ID` will infer the project from the account. The `ACCOUNT` value can be the
   *     `email` address or the `unique_id` of the service account.
   * @param payload Required. The JWT payload to sign, a JSON JWT Claim set.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final SignJwtResponse signJwt(String name, String payload) {
    SignJwtRequest request = SignJwtRequest.newBuilder().setName(name).setPayload(payload).build();
    return signJwt(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Signs a JWT using a service account's system-managed private key.
   *
   * <p>If no expiry time (`exp`) is provided in the `SignJwtRequest`, IAM sets an an expiry time of
   * one hour by default. If you request an expiry time of more than one hour, the request will
   * fail.
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final SignJwtResponse signJwt(SignJwtRequest request) {
    return signJwtCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Signs a JWT using a service account's system-managed private key.
   *
   * <p>If no expiry time (`exp`) is provided in the `SignJwtRequest`, IAM sets an an expiry time of
   * one hour by default. If you request an expiry time of more than one hour, the request will
   * fail.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<SignJwtRequest, SignJwtResponse> signJwtCallable() {
    return stub.signJwtCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Returns the Cloud IAM access control policy for a
   * [ServiceAccount][google.iam.admin.v1.ServiceAccount].
   *
   * <p>Note: Service accounts are both [resources and
   * identities](/iam/docs/service-accounts#service_account_permissions). This method treats the
   * service account as a resource. It returns the Cloud IAM policy that reflects what members have
   * access to the service account.
   *
   * <p>This method does not return what resources the service account has access to. To see if a
   * service account has access to a resource, call the `getIamPolicy` method on the target
   * resource. For example, to view grants for a project, call the
   * [projects.getIamPolicy](/resource-manager/reference/rest/v1/projects/getIamPolicy) method.
   *
   * @param resource REQUIRED: The resource for which the policy is being requested. See the
   *     operation documentation for the appropriate value for this field.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final Policy getIamPolicy(ResourceName resource) {
    GetIamPolicyRequest request =
        GetIamPolicyRequest.newBuilder()
            .setResource(resource == null ? null : resource.toString())
            .build();
    return getIamPolicy(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Returns the Cloud IAM access control policy for a
   * [ServiceAccount][google.iam.admin.v1.ServiceAccount].
   *
   * <p>Note: Service accounts are both [resources and
   * identities](/iam/docs/service-accounts#service_account_permissions). This method treats the
   * service account as a resource. It returns the Cloud IAM policy that reflects what members have
   * access to the service account.
   *
   * <p>This method does not return what resources the service account has access to. To see if a
   * service account has access to a resource, call the `getIamPolicy` method on the target
   * resource. For example, to view grants for a project, call the
   * [projects.getIamPolicy](/resource-manager/reference/rest/v1/projects/getIamPolicy) method.
   *
   * @param resource REQUIRED: The resource for which the policy is being requested. See the
   *     operation documentation for the appropriate value for this field.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final Policy getIamPolicy(String resource) {
    GetIamPolicyRequest request = GetIamPolicyRequest.newBuilder().setResource(resource).build();
    return getIamPolicy(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Returns the Cloud IAM access control policy for a
   * [ServiceAccount][google.iam.admin.v1.ServiceAccount].
   *
   * <p>Note: Service accounts are both [resources and
   * identities](/iam/docs/service-accounts#service_account_permissions). This method treats the
   * service account as a resource. It returns the Cloud IAM policy that reflects what members have
   * access to the service account.
   *
   * <p>This method does not return what resources the service account has access to. To see if a
   * service account has access to a resource, call the `getIamPolicy` method on the target
   * resource. For example, to view grants for a project, call the
   * [projects.getIamPolicy](/resource-manager/reference/rest/v1/projects/getIamPolicy) method.
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final Policy getIamPolicy(GetIamPolicyRequest request) {
    return getIamPolicyCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Returns the Cloud IAM access control policy for a
   * [ServiceAccount][google.iam.admin.v1.ServiceAccount].
   *
   * <p>Note: Service accounts are both [resources and
   * identities](/iam/docs/service-accounts#service_account_permissions). This method treats the
   * service account as a resource. It returns the Cloud IAM policy that reflects what members have
   * access to the service account.
   *
   * <p>This method does not return what resources the service account has access to. To see if a
   * service account has access to a resource, call the `getIamPolicy` method on the target
   * resource. For example, to view grants for a project, call the
   * [projects.getIamPolicy](/resource-manager/reference/rest/v1/projects/getIamPolicy) method.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<GetIamPolicyRequest, Policy> getIamPolicyCallable() {
    return stub.getIamPolicyCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Sets the Cloud IAM access control policy for a
   * [ServiceAccount][google.iam.admin.v1.ServiceAccount].
   *
   * <p>Note: Service accounts are both [resources and
   * identities](/iam/docs/service-accounts#service_account_permissions). This method treats the
   * service account as a resource. Use it to grant members access to the service account, such as
   * when they need to impersonate it.
   *
   * <p>This method does not grant the service account access to other resources, such as projects.
   * To grant a service account access to resources, include the service account in the Cloud IAM
   * policy for the desired resource, then call the appropriate `setIamPolicy` method on the target
   * resource. For example, to grant a service account access to a project, call the
   * [projects.setIamPolicy](/resource-manager/reference/rest/v1/projects/setIamPolicy) method.
   *
   * @param resource REQUIRED: The resource for which the policy is being specified. See the
   *     operation documentation for the appropriate value for this field.
   * @param policy REQUIRED: The complete policy to be applied to the `resource`. The size of the
   *     policy is limited to a few 10s of KB. An empty policy is a valid policy but certain Cloud
   *     Platform services (such as Projects) might reject them.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final Policy setIamPolicy(ResourceName resource, Policy policy) {
    SetIamPolicyRequest request =
        SetIamPolicyRequest.newBuilder()
            .setResource(resource == null ? null : resource.toString())
            .setPolicy(policy)
            .build();
    return setIamPolicy(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Sets the Cloud IAM access control policy for a
   * [ServiceAccount][google.iam.admin.v1.ServiceAccount].
   *
   * <p>Note: Service accounts are both [resources and
   * identities](/iam/docs/service-accounts#service_account_permissions). This method treats the
   * service account as a resource. Use it to grant members access to the service account, such as
   * when they need to impersonate it.
   *
   * <p>This method does not grant the service account access to other resources, such as projects.
   * To grant a service account access to resources, include the service account in the Cloud IAM
   * policy for the desired resource, then call the appropriate `setIamPolicy` method on the target
   * resource. For example, to grant a service account access to a project, call the
   * [projects.setIamPolicy](/resource-manager/reference/rest/v1/projects/setIamPolicy) method.
   *
   * @param resource REQUIRED: The resource for which the policy is being specified. See the
   *     operation documentation for the appropriate value for this field.
   * @param policy REQUIRED: The complete policy to be applied to the `resource`. The size of the
   *     policy is limited to a few 10s of KB. An empty policy is a valid policy but certain Cloud
   *     Platform services (such as Projects) might reject them.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final Policy setIamPolicy(String resource, Policy policy) {
    SetIamPolicyRequest request =
        SetIamPolicyRequest.newBuilder().setResource(resource).setPolicy(policy).build();
    return setIamPolicy(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Sets the Cloud IAM access control policy for a
   * [ServiceAccount][google.iam.admin.v1.ServiceAccount].
   *
   * <p>Note: Service accounts are both [resources and
   * identities](/iam/docs/service-accounts#service_account_permissions). This method treats the
   * service account as a resource. Use it to grant members access to the service account, such as
   * when they need to impersonate it.
   *
   * <p>This method does not grant the service account access to other resources, such as projects.
   * To grant a service account access to resources, include the service account in the Cloud IAM
   * policy for the desired resource, then call the appropriate `setIamPolicy` method on the target
   * resource. For example, to grant a service account access to a project, call the
   * [projects.setIamPolicy](/resource-manager/reference/rest/v1/projects/setIamPolicy) method.
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final Policy setIamPolicy(SetIamPolicyRequest request) {
    return setIamPolicyCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Sets the Cloud IAM access control policy for a
   * [ServiceAccount][google.iam.admin.v1.ServiceAccount].
   *
   * <p>Note: Service accounts are both [resources and
   * identities](/iam/docs/service-accounts#service_account_permissions). This method treats the
   * service account as a resource. Use it to grant members access to the service account, such as
   * when they need to impersonate it.
   *
   * <p>This method does not grant the service account access to other resources, such as projects.
   * To grant a service account access to resources, include the service account in the Cloud IAM
   * policy for the desired resource, then call the appropriate `setIamPolicy` method on the target
   * resource. For example, to grant a service account access to a project, call the
   * [projects.setIamPolicy](/resource-manager/reference/rest/v1/projects/setIamPolicy) method.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<SetIamPolicyRequest, Policy> setIamPolicyCallable() {
    return stub.setIamPolicyCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Tests the specified permissions against the IAM access control policy for a
   * [ServiceAccount][google.iam.admin.v1.ServiceAccount].
   *
   * @param resource REQUIRED: The resource for which the policy detail is being requested. See the
   *     operation documentation for the appropriate value for this field.
   * @param permissions The set of permissions to check for the `resource`. Permissions with
   *     wildcards (such as '&#42;' or 'storage.&#42;') are not allowed. For more information see
   *     [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final TestIamPermissionsResponse testIamPermissions(
      ResourceName resource, List<String> permissions) {
    TestIamPermissionsRequest request =
        TestIamPermissionsRequest.newBuilder()
            .setResource(resource == null ? null : resource.toString())
            .addAllPermissions(permissions)
            .build();
    return testIamPermissions(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Tests the specified permissions against the IAM access control policy for a
   * [ServiceAccount][google.iam.admin.v1.ServiceAccount].
   *
   * @param resource REQUIRED: The resource for which the policy detail is being requested. See the
   *     operation documentation for the appropriate value for this field.
   * @param permissions The set of permissions to check for the `resource`. Permissions with
   *     wildcards (such as '&#42;' or 'storage.&#42;') are not allowed. For more information see
   *     [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final TestIamPermissionsResponse testIamPermissions(
      String resource, List<String> permissions) {
    TestIamPermissionsRequest request =
        TestIamPermissionsRequest.newBuilder()
            .setResource(resource)
            .addAllPermissions(permissions)
            .build();
    return testIamPermissions(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Tests the specified permissions against the IAM access control policy for a
   * [ServiceAccount][google.iam.admin.v1.ServiceAccount].
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final TestIamPermissionsResponse testIamPermissions(TestIamPermissionsRequest request) {
    return testIamPermissionsCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Tests the specified permissions against the IAM access control policy for a
   * [ServiceAccount][google.iam.admin.v1.ServiceAccount].
   *
   * <p>Sample code:
   */
  public final UnaryCallable<TestIamPermissionsRequest, TestIamPermissionsResponse>
      testIamPermissionsCallable() {
    return stub.testIamPermissionsCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Queries roles that can be granted on a particular resource. A role is grantable if it can be
   * used as the role in a binding for a policy for that resource.
   *
   * @param fullResourceName Required. The full resource name to query from the list of grantable
   *     roles.
   *     <p>The name follows the Google Cloud Platform resource format. For example, a Cloud
   *     Platform project with id `my-project` will be named
   *     `//cloudresourcemanager.googleapis.com/projects/my-project`.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final QueryGrantableRolesPagedResponse queryGrantableRoles(String fullResourceName) {
    QueryGrantableRolesRequest request =
        QueryGrantableRolesRequest.newBuilder().setFullResourceName(fullResourceName).build();
    return queryGrantableRoles(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Queries roles that can be granted on a particular resource. A role is grantable if it can be
   * used as the role in a binding for a policy for that resource.
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final QueryGrantableRolesPagedResponse queryGrantableRoles(
      QueryGrantableRolesRequest request) {
    return queryGrantableRolesPagedCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Queries roles that can be granted on a particular resource. A role is grantable if it can be
   * used as the role in a binding for a policy for that resource.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<QueryGrantableRolesRequest, QueryGrantableRolesPagedResponse>
      queryGrantableRolesPagedCallable() {
    return stub.queryGrantableRolesPagedCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Queries roles that can be granted on a particular resource. A role is grantable if it can be
   * used as the role in a binding for a policy for that resource.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<QueryGrantableRolesRequest, QueryGrantableRolesResponse>
      queryGrantableRolesCallable() {
    return stub.queryGrantableRolesCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists the Roles defined on a resource.
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ListRolesPagedResponse listRoles(ListRolesRequest request) {
    return listRolesPagedCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists the Roles defined on a resource.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<ListRolesRequest, ListRolesPagedResponse> listRolesPagedCallable() {
    return stub.listRolesPagedCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists the Roles defined on a resource.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<ListRolesRequest, ListRolesResponse> listRolesCallable() {
    return stub.listRolesCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets a Role definition.
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final Role getRole(GetRoleRequest request) {
    return getRoleCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets a Role definition.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<GetRoleRequest, Role> getRoleCallable() {
    return stub.getRoleCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a new Role.
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final Role createRole(CreateRoleRequest request) {
    return createRoleCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a new Role.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<CreateRoleRequest, Role> createRoleCallable() {
    return stub.createRoleCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Updates a Role definition.
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final Role updateRole(UpdateRoleRequest request) {
    return updateRoleCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Updates a Role definition.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<UpdateRoleRequest, Role> updateRoleCallable() {
    return stub.updateRoleCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Soft deletes a role. The role is suspended and cannot be used to create new IAM Policy
   * Bindings. The Role will not be included in `ListRoles()` unless `show_deleted` is set in the
   * `ListRolesRequest`. The Role contains the deleted boolean set. Existing Bindings remains, but
   * are inactive. The Role can be undeleted within 7 days. After 7 days the Role is deleted and all
   * Bindings associated with the role are removed.
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final Role deleteRole(DeleteRoleRequest request) {
    return deleteRoleCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Soft deletes a role. The role is suspended and cannot be used to create new IAM Policy
   * Bindings. The Role will not be included in `ListRoles()` unless `show_deleted` is set in the
   * `ListRolesRequest`. The Role contains the deleted boolean set. Existing Bindings remains, but
   * are inactive. The Role can be undeleted within 7 days. After 7 days the Role is deleted and all
   * Bindings associated with the role are removed.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<DeleteRoleRequest, Role> deleteRoleCallable() {
    return stub.deleteRoleCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Undelete a Role, bringing it back in its previous state.
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final Role undeleteRole(UndeleteRoleRequest request) {
    return undeleteRoleCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Undelete a Role, bringing it back in its previous state.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<UndeleteRoleRequest, Role> undeleteRoleCallable() {
    return stub.undeleteRoleCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists the permissions testable on a resource. A permission is testable if it can be tested for
   * an identity on a resource.
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final QueryTestablePermissionsPagedResponse queryTestablePermissions(
      QueryTestablePermissionsRequest request) {
    return queryTestablePermissionsPagedCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists the permissions testable on a resource. A permission is testable if it can be tested for
   * an identity on a resource.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<QueryTestablePermissionsRequest, QueryTestablePermissionsPagedResponse>
      queryTestablePermissionsPagedCallable() {
    return stub.queryTestablePermissionsPagedCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists the permissions testable on a resource. A permission is testable if it can be tested for
   * an identity on a resource.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<QueryTestablePermissionsRequest, QueryTestablePermissionsResponse>
      queryTestablePermissionsCallable() {
    return stub.queryTestablePermissionsCallable();
  }

  @Override
  public final void close() {
    stub.close();
  }

  @Override
  public void shutdown() {
    stub.shutdown();
  }

  @Override
  public boolean isShutdown() {
    return stub.isShutdown();
  }

  @Override
  public boolean isTerminated() {
    return stub.isTerminated();
  }

  @Override
  public void shutdownNow() {
    stub.shutdownNow();
  }

  @Override
  public boolean awaitTermination(long duration, TimeUnit unit) throws InterruptedException {
    return stub.awaitTermination(duration, unit);
  }

  public static class ListServiceAccountsPagedResponse
      extends AbstractPagedListResponse<
          ListServiceAccountsRequest,
          ListServiceAccountsResponse,
          ServiceAccount,
          ListServiceAccountsPage,
          ListServiceAccountsFixedSizeCollection> {

    public static ApiFuture<ListServiceAccountsPagedResponse> createAsync(
        PageContext<ListServiceAccountsRequest, ListServiceAccountsResponse, ServiceAccount>
            context,
        ApiFuture<ListServiceAccountsResponse> futureResponse) {
      ApiFuture<ListServiceAccountsPage> futurePage =
          ListServiceAccountsPage.createEmptyPage().createPageAsync(context, futureResponse);
      return ApiFutures.transform(
          futurePage,
          new ApiFunction<ListServiceAccountsPage, ListServiceAccountsPagedResponse>() {
            @Override
            public ListServiceAccountsPagedResponse apply(ListServiceAccountsPage input) {
              return new ListServiceAccountsPagedResponse(input);
            }
          },
          MoreExecutors.directExecutor());
    }

    private ListServiceAccountsPagedResponse(ListServiceAccountsPage page) {
      super(page, ListServiceAccountsFixedSizeCollection.createEmptyCollection());
    }
  }

  public static class ListServiceAccountsPage
      extends AbstractPage<
          ListServiceAccountsRequest,
          ListServiceAccountsResponse,
          ServiceAccount,
          ListServiceAccountsPage> {

    private ListServiceAccountsPage(
        PageContext<ListServiceAccountsRequest, ListServiceAccountsResponse, ServiceAccount>
            context,
        ListServiceAccountsResponse response) {
      super(context, response);
    }

    private static ListServiceAccountsPage createEmptyPage() {
      return new ListServiceAccountsPage(null, null);
    }

    @Override
    protected ListServiceAccountsPage createPage(
        PageContext<ListServiceAccountsRequest, ListServiceAccountsResponse, ServiceAccount>
            context,
        ListServiceAccountsResponse response) {
      return new ListServiceAccountsPage(context, response);
    }

    @Override
    public ApiFuture<ListServiceAccountsPage> createPageAsync(
        PageContext<ListServiceAccountsRequest, ListServiceAccountsResponse, ServiceAccount>
            context,
        ApiFuture<ListServiceAccountsResponse> futureResponse) {
      return super.createPageAsync(context, futureResponse);
    }
  }

  public static class ListServiceAccountsFixedSizeCollection
      extends AbstractFixedSizeCollection<
          ListServiceAccountsRequest,
          ListServiceAccountsResponse,
          ServiceAccount,
          ListServiceAccountsPage,
          ListServiceAccountsFixedSizeCollection> {

    private ListServiceAccountsFixedSizeCollection(
        List<ListServiceAccountsPage> pages, int collectionSize) {
      super(pages, collectionSize);
    }

    private static ListServiceAccountsFixedSizeCollection createEmptyCollection() {
      return new ListServiceAccountsFixedSizeCollection(null, 0);
    }

    @Override
    protected ListServiceAccountsFixedSizeCollection createCollection(
        List<ListServiceAccountsPage> pages, int collectionSize) {
      return new ListServiceAccountsFixedSizeCollection(pages, collectionSize);
    }
  }

  public static class QueryGrantableRolesPagedResponse
      extends AbstractPagedListResponse<
          QueryGrantableRolesRequest,
          QueryGrantableRolesResponse,
          Role,
          QueryGrantableRolesPage,
          QueryGrantableRolesFixedSizeCollection> {

    public static ApiFuture<QueryGrantableRolesPagedResponse> createAsync(
        PageContext<QueryGrantableRolesRequest, QueryGrantableRolesResponse, Role> context,
        ApiFuture<QueryGrantableRolesResponse> futureResponse) {
      ApiFuture<QueryGrantableRolesPage> futurePage =
          QueryGrantableRolesPage.createEmptyPage().createPageAsync(context, futureResponse);
      return ApiFutures.transform(
          futurePage,
          new ApiFunction<QueryGrantableRolesPage, QueryGrantableRolesPagedResponse>() {
            @Override
            public QueryGrantableRolesPagedResponse apply(QueryGrantableRolesPage input) {
              return new QueryGrantableRolesPagedResponse(input);
            }
          },
          MoreExecutors.directExecutor());
    }

    private QueryGrantableRolesPagedResponse(QueryGrantableRolesPage page) {
      super(page, QueryGrantableRolesFixedSizeCollection.createEmptyCollection());
    }
  }

  public static class QueryGrantableRolesPage
      extends AbstractPage<
          QueryGrantableRolesRequest, QueryGrantableRolesResponse, Role, QueryGrantableRolesPage> {

    private QueryGrantableRolesPage(
        PageContext<QueryGrantableRolesRequest, QueryGrantableRolesResponse, Role> context,
        QueryGrantableRolesResponse response) {
      super(context, response);
    }

    private static QueryGrantableRolesPage createEmptyPage() {
      return new QueryGrantableRolesPage(null, null);
    }

    @Override
    protected QueryGrantableRolesPage createPage(
        PageContext<QueryGrantableRolesRequest, QueryGrantableRolesResponse, Role> context,
        QueryGrantableRolesResponse response) {
      return new QueryGrantableRolesPage(context, response);
    }

    @Override
    public ApiFuture<QueryGrantableRolesPage> createPageAsync(
        PageContext<QueryGrantableRolesRequest, QueryGrantableRolesResponse, Role> context,
        ApiFuture<QueryGrantableRolesResponse> futureResponse) {
      return super.createPageAsync(context, futureResponse);
    }
  }

  public static class QueryGrantableRolesFixedSizeCollection
      extends AbstractFixedSizeCollection<
          QueryGrantableRolesRequest,
          QueryGrantableRolesResponse,
          Role,
          QueryGrantableRolesPage,
          QueryGrantableRolesFixedSizeCollection> {

    private QueryGrantableRolesFixedSizeCollection(
        List<QueryGrantableRolesPage> pages, int collectionSize) {
      super(pages, collectionSize);
    }

    private static QueryGrantableRolesFixedSizeCollection createEmptyCollection() {
      return new QueryGrantableRolesFixedSizeCollection(null, 0);
    }

    @Override
    protected QueryGrantableRolesFixedSizeCollection createCollection(
        List<QueryGrantableRolesPage> pages, int collectionSize) {
      return new QueryGrantableRolesFixedSizeCollection(pages, collectionSize);
    }
  }

  public static class ListRolesPagedResponse
      extends AbstractPagedListResponse<
          ListRolesRequest, ListRolesResponse, Role, ListRolesPage, ListRolesFixedSizeCollection> {

    public static ApiFuture<ListRolesPagedResponse> createAsync(
        PageContext<ListRolesRequest, ListRolesResponse, Role> context,
        ApiFuture<ListRolesResponse> futureResponse) {
      ApiFuture<ListRolesPage> futurePage =
          ListRolesPage.createEmptyPage().createPageAsync(context, futureResponse);
      return ApiFutures.transform(
          futurePage,
          new ApiFunction<ListRolesPage, ListRolesPagedResponse>() {
            @Override
            public ListRolesPagedResponse apply(ListRolesPage input) {
              return new ListRolesPagedResponse(input);
            }
          },
          MoreExecutors.directExecutor());
    }

    private ListRolesPagedResponse(ListRolesPage page) {
      super(page, ListRolesFixedSizeCollection.createEmptyCollection());
    }
  }

  public static class ListRolesPage
      extends AbstractPage<ListRolesRequest, ListRolesResponse, Role, ListRolesPage> {

    private ListRolesPage(
        PageContext<ListRolesRequest, ListRolesResponse, Role> context,
        ListRolesResponse response) {
      super(context, response);
    }

    private static ListRolesPage createEmptyPage() {
      return new ListRolesPage(null, null);
    }

    @Override
    protected ListRolesPage createPage(
        PageContext<ListRolesRequest, ListRolesResponse, Role> context,
        ListRolesResponse response) {
      return new ListRolesPage(context, response);
    }

    @Override
    public ApiFuture<ListRolesPage> createPageAsync(
        PageContext<ListRolesRequest, ListRolesResponse, Role> context,
        ApiFuture<ListRolesResponse> futureResponse) {
      return super.createPageAsync(context, futureResponse);
    }
  }

  public static class ListRolesFixedSizeCollection
      extends AbstractFixedSizeCollection<
          ListRolesRequest, ListRolesResponse, Role, ListRolesPage, ListRolesFixedSizeCollection> {

    private ListRolesFixedSizeCollection(List<ListRolesPage> pages, int collectionSize) {
      super(pages, collectionSize);
    }

    private static ListRolesFixedSizeCollection createEmptyCollection() {
      return new ListRolesFixedSizeCollection(null, 0);
    }

    @Override
    protected ListRolesFixedSizeCollection createCollection(
        List<ListRolesPage> pages, int collectionSize) {
      return new ListRolesFixedSizeCollection(pages, collectionSize);
    }
  }

  public static class QueryTestablePermissionsPagedResponse
      extends AbstractPagedListResponse<
          QueryTestablePermissionsRequest,
          QueryTestablePermissionsResponse,
          Permission,
          QueryTestablePermissionsPage,
          QueryTestablePermissionsFixedSizeCollection> {

    public static ApiFuture<QueryTestablePermissionsPagedResponse> createAsync(
        PageContext<QueryTestablePermissionsRequest, QueryTestablePermissionsResponse, Permission>
            context,
        ApiFuture<QueryTestablePermissionsResponse> futureResponse) {
      ApiFuture<QueryTestablePermissionsPage> futurePage =
          QueryTestablePermissionsPage.createEmptyPage().createPageAsync(context, futureResponse);
      return ApiFutures.transform(
          futurePage,
          new ApiFunction<QueryTestablePermissionsPage, QueryTestablePermissionsPagedResponse>() {
            @Override
            public QueryTestablePermissionsPagedResponse apply(QueryTestablePermissionsPage input) {
              return new QueryTestablePermissionsPagedResponse(input);
            }
          },
          MoreExecutors.directExecutor());
    }

    private QueryTestablePermissionsPagedResponse(QueryTestablePermissionsPage page) {
      super(page, QueryTestablePermissionsFixedSizeCollection.createEmptyCollection());
    }
  }

  public static class QueryTestablePermissionsPage
      extends AbstractPage<
          QueryTestablePermissionsRequest,
          QueryTestablePermissionsResponse,
          Permission,
          QueryTestablePermissionsPage> {

    private QueryTestablePermissionsPage(
        PageContext<QueryTestablePermissionsRequest, QueryTestablePermissionsResponse, Permission>
            context,
        QueryTestablePermissionsResponse response) {
      super(context, response);
    }

    private static QueryTestablePermissionsPage createEmptyPage() {
      return new QueryTestablePermissionsPage(null, null);
    }

    @Override
    protected QueryTestablePermissionsPage createPage(
        PageContext<QueryTestablePermissionsRequest, QueryTestablePermissionsResponse, Permission>
            context,
        QueryTestablePermissionsResponse response) {
      return new QueryTestablePermissionsPage(context, response);
    }

    @Override
    public ApiFuture<QueryTestablePermissionsPage> createPageAsync(
        PageContext<QueryTestablePermissionsRequest, QueryTestablePermissionsResponse, Permission>
            context,
        ApiFuture<QueryTestablePermissionsResponse> futureResponse) {
      return super.createPageAsync(context, futureResponse);
    }
  }

  public static class QueryTestablePermissionsFixedSizeCollection
      extends AbstractFixedSizeCollection<
          QueryTestablePermissionsRequest,
          QueryTestablePermissionsResponse,
          Permission,
          QueryTestablePermissionsPage,
          QueryTestablePermissionsFixedSizeCollection> {

    private QueryTestablePermissionsFixedSizeCollection(
        List<QueryTestablePermissionsPage> pages, int collectionSize) {
      super(pages, collectionSize);
    }

    private static QueryTestablePermissionsFixedSizeCollection createEmptyCollection() {
      return new QueryTestablePermissionsFixedSizeCollection(null, 0);
    }

    @Override
    protected QueryTestablePermissionsFixedSizeCollection createCollection(
        List<QueryTestablePermissionsPage> pages, int collectionSize) {
      return new QueryTestablePermissionsFixedSizeCollection(pages, collectionSize);
    }
  }
}
