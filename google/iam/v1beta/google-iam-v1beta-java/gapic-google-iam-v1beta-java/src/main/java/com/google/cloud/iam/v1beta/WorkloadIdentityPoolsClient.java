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

package com.google.cloud.iam.v1beta;

import com.google.api.core.ApiFunction;
import com.google.api.core.ApiFuture;
import com.google.api.core.ApiFutures;
import com.google.api.core.BetaApi;
import com.google.api.gax.core.BackgroundResource;
import com.google.api.gax.longrunning.OperationFuture;
import com.google.api.gax.paging.AbstractFixedSizeCollection;
import com.google.api.gax.paging.AbstractPage;
import com.google.api.gax.paging.AbstractPagedListResponse;
import com.google.api.gax.rpc.OperationCallable;
import com.google.api.gax.rpc.PageContext;
import com.google.api.gax.rpc.UnaryCallable;
import com.google.cloud.iam.v1beta.stub.WorkloadIdentityPoolsStub;
import com.google.cloud.iam.v1beta.stub.WorkloadIdentityPoolsStubSettings;
import com.google.common.util.concurrent.MoreExecutors;
import com.google.iam.v1beta.CreateWorkloadIdentityPoolProviderRequest;
import com.google.iam.v1beta.CreateWorkloadIdentityPoolRequest;
import com.google.iam.v1beta.DeleteWorkloadIdentityPoolProviderRequest;
import com.google.iam.v1beta.DeleteWorkloadIdentityPoolRequest;
import com.google.iam.v1beta.GetWorkloadIdentityPoolProviderRequest;
import com.google.iam.v1beta.GetWorkloadIdentityPoolRequest;
import com.google.iam.v1beta.ListWorkloadIdentityPoolProvidersRequest;
import com.google.iam.v1beta.ListWorkloadIdentityPoolProvidersResponse;
import com.google.iam.v1beta.ListWorkloadIdentityPoolsRequest;
import com.google.iam.v1beta.ListWorkloadIdentityPoolsResponse;
import com.google.iam.v1beta.ProjectName;
import com.google.iam.v1beta.UndeleteWorkloadIdentityPoolProviderRequest;
import com.google.iam.v1beta.UndeleteWorkloadIdentityPoolRequest;
import com.google.iam.v1beta.UpdateWorkloadIdentityPoolProviderRequest;
import com.google.iam.v1beta.UpdateWorkloadIdentityPoolRequest;
import com.google.iam.v1beta.WorkloadIdentityPool;
import com.google.iam.v1beta.WorkloadIdentityPoolName;
import com.google.iam.v1beta.WorkloadIdentityPoolOperationMetadata;
import com.google.iam.v1beta.WorkloadIdentityPoolProvider;
import com.google.iam.v1beta.WorkloadIdentityPoolProviderName;
import com.google.iam.v1beta.WorkloadIdentityPoolProviderOperationMetadata;
import com.google.longrunning.Operation;
import com.google.longrunning.OperationsClient;
import com.google.protobuf.FieldMask;
import java.io.IOException;
import java.util.List;
import java.util.concurrent.TimeUnit;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * Service Description: Manages WorkloadIdentityPools.
 *
 * <p>This class provides the ability to make remote calls to the backing service through method
 * calls that map to API methods. Sample code to get started:
 *
 * <p>Note: close() needs to be called on the WorkloadIdentityPoolsClient object to clean up
 * resources such as threads. In the example above, try-with-resources is used, which automatically
 * calls close().
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
 * <p>This class can be customized by passing in a custom instance of WorkloadIdentityPoolsSettings
 * to create(). For example:
 *
 * <p>To customize credentials:
 *
 * <pre>{@code
 * WorkloadIdentityPoolsSettings workloadIdentityPoolsSettings =
 *     WorkloadIdentityPoolsSettings.newBuilder()
 *         .setCredentialsProvider(FixedCredentialsProvider.create(myCredentials))
 *         .build();
 * WorkloadIdentityPoolsClient workloadIdentityPoolsClient =
 *     WorkloadIdentityPoolsClient.create(workloadIdentityPoolsSettings);
 * }</pre>
 *
 * <p>To customize the endpoint:
 *
 * <pre>{@code
 * WorkloadIdentityPoolsSettings workloadIdentityPoolsSettings =
 *     WorkloadIdentityPoolsSettings.newBuilder().setEndpoint(myEndpoint).build();
 * WorkloadIdentityPoolsClient workloadIdentityPoolsClient =
 *     WorkloadIdentityPoolsClient.create(workloadIdentityPoolsSettings);
 * }</pre>
 *
 * <p>Please refer to the GitHub repository's samples for more quickstart code snippets.
 */
@BetaApi
@Generated("by gapic-generator-java")
public class WorkloadIdentityPoolsClient implements BackgroundResource {
  private final WorkloadIdentityPoolsSettings settings;
  private final WorkloadIdentityPoolsStub stub;
  private final OperationsClient operationsClient;

  /** Constructs an instance of WorkloadIdentityPoolsClient with default settings. */
  public static final WorkloadIdentityPoolsClient create() throws IOException {
    return create(WorkloadIdentityPoolsSettings.newBuilder().build());
  }

  /**
   * Constructs an instance of WorkloadIdentityPoolsClient, using the given settings. The channels
   * are created based on the settings passed in, or defaults for any settings that are not set.
   */
  public static final WorkloadIdentityPoolsClient create(WorkloadIdentityPoolsSettings settings)
      throws IOException {
    return new WorkloadIdentityPoolsClient(settings);
  }

  /**
   * Constructs an instance of WorkloadIdentityPoolsClient, using the given stub for making calls.
   * This is for advanced usage - prefer using create(WorkloadIdentityPoolsSettings).
   */
  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public static final WorkloadIdentityPoolsClient create(WorkloadIdentityPoolsStub stub) {
    return new WorkloadIdentityPoolsClient(stub);
  }

  /**
   * Constructs an instance of WorkloadIdentityPoolsClient, using the given settings. This is
   * protected so that it is easy to make a subclass, but otherwise, the static factory methods
   * should be preferred.
   */
  protected WorkloadIdentityPoolsClient(WorkloadIdentityPoolsSettings settings) throws IOException {
    this.settings = settings;
    this.stub = ((WorkloadIdentityPoolsStubSettings) settings.getStubSettings()).createStub();
    this.operationsClient = OperationsClient.create(this.stub.getOperationsStub());
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  protected WorkloadIdentityPoolsClient(WorkloadIdentityPoolsStub stub) {
    this.settings = null;
    this.stub = stub;
    this.operationsClient = OperationsClient.create(this.stub.getOperationsStub());
  }

  public final WorkloadIdentityPoolsSettings getSettings() {
    return settings;
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public WorkloadIdentityPoolsStub getStub() {
    return stub;
  }

  /**
   * Returns the OperationsClient that can be used to query the status of a long-running operation
   * returned by another API method call.
   */
  public final OperationsClient getOperationsClient() {
    return operationsClient;
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists all non-deleted [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool]s in a
   * project. If `show_deleted` is set to `true`, then deleted pools are also listed.
   *
   * @param parent Required. The parent resource to list pools for.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ListWorkloadIdentityPoolsPagedResponse listWorkloadIdentityPools(
      ProjectName parent) {
    ListWorkloadIdentityPoolsRequest request =
        ListWorkloadIdentityPoolsRequest.newBuilder()
            .setParent(parent == null ? null : parent.toString())
            .build();
    return listWorkloadIdentityPools(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists all non-deleted [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool]s in a
   * project. If `show_deleted` is set to `true`, then deleted pools are also listed.
   *
   * @param parent Required. The parent resource to list pools for.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ListWorkloadIdentityPoolsPagedResponse listWorkloadIdentityPools(String parent) {
    ListWorkloadIdentityPoolsRequest request =
        ListWorkloadIdentityPoolsRequest.newBuilder().setParent(parent).build();
    return listWorkloadIdentityPools(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists all non-deleted [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool]s in a
   * project. If `show_deleted` is set to `true`, then deleted pools are also listed.
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ListWorkloadIdentityPoolsPagedResponse listWorkloadIdentityPools(
      ListWorkloadIdentityPoolsRequest request) {
    return listWorkloadIdentityPoolsPagedCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists all non-deleted [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool]s in a
   * project. If `show_deleted` is set to `true`, then deleted pools are also listed.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<
          ListWorkloadIdentityPoolsRequest, ListWorkloadIdentityPoolsPagedResponse>
      listWorkloadIdentityPoolsPagedCallable() {
    return stub.listWorkloadIdentityPoolsPagedCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists all non-deleted [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool]s in a
   * project. If `show_deleted` is set to `true`, then deleted pools are also listed.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<ListWorkloadIdentityPoolsRequest, ListWorkloadIdentityPoolsResponse>
      listWorkloadIdentityPoolsCallable() {
    return stub.listWorkloadIdentityPoolsCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets an individual [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
   *
   * @param name Required. The name of the pool to retrieve.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final WorkloadIdentityPool getWorkloadIdentityPool(WorkloadIdentityPoolName name) {
    GetWorkloadIdentityPoolRequest request =
        GetWorkloadIdentityPoolRequest.newBuilder()
            .setName(name == null ? null : name.toString())
            .build();
    return getWorkloadIdentityPool(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets an individual [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
   *
   * @param name Required. The name of the pool to retrieve.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final WorkloadIdentityPool getWorkloadIdentityPool(String name) {
    GetWorkloadIdentityPoolRequest request =
        GetWorkloadIdentityPoolRequest.newBuilder().setName(name).build();
    return getWorkloadIdentityPool(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets an individual [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final WorkloadIdentityPool getWorkloadIdentityPool(
      GetWorkloadIdentityPoolRequest request) {
    return getWorkloadIdentityPoolCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets an individual [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
   *
   * <p>Sample code:
   */
  public final UnaryCallable<GetWorkloadIdentityPoolRequest, WorkloadIdentityPool>
      getWorkloadIdentityPoolCallable() {
    return stub.getWorkloadIdentityPoolCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a new [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
   *
   * <p>You cannot reuse the name of a deleted pool until 30 days after deletion.
   *
   * @param parent Required. The parent resource to create the pool in. The only supported location
   *     is `global`.
   * @param workloadIdentityPool Required. The pool to create.
   * @param workloadIdentityPoolId Required. The ID to use for the pool, which becomes the final
   *     component of the resource name. This value should be 4-32 characters, and may contain the
   *     characters [a-z0-9-]. The prefix `gcp-` is reserved for use by Google, and may not be
   *     specified.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata>
      createWorkloadIdentityPoolAsync(
          ProjectName parent,
          WorkloadIdentityPool workloadIdentityPool,
          String workloadIdentityPoolId) {
    CreateWorkloadIdentityPoolRequest request =
        CreateWorkloadIdentityPoolRequest.newBuilder()
            .setParent(parent == null ? null : parent.toString())
            .setWorkloadIdentityPool(workloadIdentityPool)
            .setWorkloadIdentityPoolId(workloadIdentityPoolId)
            .build();
    return createWorkloadIdentityPoolAsync(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a new [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
   *
   * <p>You cannot reuse the name of a deleted pool until 30 days after deletion.
   *
   * @param parent Required. The parent resource to create the pool in. The only supported location
   *     is `global`.
   * @param workloadIdentityPool Required. The pool to create.
   * @param workloadIdentityPoolId Required. The ID to use for the pool, which becomes the final
   *     component of the resource name. This value should be 4-32 characters, and may contain the
   *     characters [a-z0-9-]. The prefix `gcp-` is reserved for use by Google, and may not be
   *     specified.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata>
      createWorkloadIdentityPoolAsync(
          String parent, WorkloadIdentityPool workloadIdentityPool, String workloadIdentityPoolId) {
    CreateWorkloadIdentityPoolRequest request =
        CreateWorkloadIdentityPoolRequest.newBuilder()
            .setParent(parent)
            .setWorkloadIdentityPool(workloadIdentityPool)
            .setWorkloadIdentityPoolId(workloadIdentityPoolId)
            .build();
    return createWorkloadIdentityPoolAsync(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a new [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
   *
   * <p>You cannot reuse the name of a deleted pool until 30 days after deletion.
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata>
      createWorkloadIdentityPoolAsync(CreateWorkloadIdentityPoolRequest request) {
    return createWorkloadIdentityPoolOperationCallable().futureCall(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a new [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
   *
   * <p>You cannot reuse the name of a deleted pool until 30 days after deletion.
   *
   * <p>Sample code:
   */
  public final OperationCallable<
          CreateWorkloadIdentityPoolRequest,
          WorkloadIdentityPool,
          WorkloadIdentityPoolOperationMetadata>
      createWorkloadIdentityPoolOperationCallable() {
    return stub.createWorkloadIdentityPoolOperationCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a new [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
   *
   * <p>You cannot reuse the name of a deleted pool until 30 days after deletion.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<CreateWorkloadIdentityPoolRequest, Operation>
      createWorkloadIdentityPoolCallable() {
    return stub.createWorkloadIdentityPoolCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Updates an existing [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
   *
   * @param workloadIdentityPool Required. The pool to update. The `name` field is used to identify
   *     the pool.
   * @param updateMask Required. The list of fields update.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata>
      updateWorkloadIdentityPoolAsync(
          WorkloadIdentityPool workloadIdentityPool, FieldMask updateMask) {
    UpdateWorkloadIdentityPoolRequest request =
        UpdateWorkloadIdentityPoolRequest.newBuilder()
            .setWorkloadIdentityPool(workloadIdentityPool)
            .setUpdateMask(updateMask)
            .build();
    return updateWorkloadIdentityPoolAsync(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Updates an existing [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata>
      updateWorkloadIdentityPoolAsync(UpdateWorkloadIdentityPoolRequest request) {
    return updateWorkloadIdentityPoolOperationCallable().futureCall(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Updates an existing [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
   *
   * <p>Sample code:
   */
  public final OperationCallable<
          UpdateWorkloadIdentityPoolRequest,
          WorkloadIdentityPool,
          WorkloadIdentityPoolOperationMetadata>
      updateWorkloadIdentityPoolOperationCallable() {
    return stub.updateWorkloadIdentityPoolOperationCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Updates an existing [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
   *
   * <p>Sample code:
   */
  public final UnaryCallable<UpdateWorkloadIdentityPoolRequest, Operation>
      updateWorkloadIdentityPoolCallable() {
    return stub.updateWorkloadIdentityPoolCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Deletes a [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
   *
   * <p>You cannot use a deleted pool to exchange external credentials for Google Cloud credentials.
   * However, deletion does not revoke credentials that have already been issued. Credentials issued
   * for a deleted pool do not grant access to resources. If the pool is undeleted, and the
   * credentials are not expired, they grant access again. You can undelete a pool for 30 days.
   * After 30 days, deletion is permanent. You cannot update deleted pools. However, you can view
   * and list them.
   *
   * @param name Required. The name of the pool to delete.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata>
      deleteWorkloadIdentityPoolAsync(WorkloadIdentityPoolName name) {
    DeleteWorkloadIdentityPoolRequest request =
        DeleteWorkloadIdentityPoolRequest.newBuilder()
            .setName(name == null ? null : name.toString())
            .build();
    return deleteWorkloadIdentityPoolAsync(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Deletes a [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
   *
   * <p>You cannot use a deleted pool to exchange external credentials for Google Cloud credentials.
   * However, deletion does not revoke credentials that have already been issued. Credentials issued
   * for a deleted pool do not grant access to resources. If the pool is undeleted, and the
   * credentials are not expired, they grant access again. You can undelete a pool for 30 days.
   * After 30 days, deletion is permanent. You cannot update deleted pools. However, you can view
   * and list them.
   *
   * @param name Required. The name of the pool to delete.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata>
      deleteWorkloadIdentityPoolAsync(String name) {
    DeleteWorkloadIdentityPoolRequest request =
        DeleteWorkloadIdentityPoolRequest.newBuilder().setName(name).build();
    return deleteWorkloadIdentityPoolAsync(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Deletes a [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
   *
   * <p>You cannot use a deleted pool to exchange external credentials for Google Cloud credentials.
   * However, deletion does not revoke credentials that have already been issued. Credentials issued
   * for a deleted pool do not grant access to resources. If the pool is undeleted, and the
   * credentials are not expired, they grant access again. You can undelete a pool for 30 days.
   * After 30 days, deletion is permanent. You cannot update deleted pools. However, you can view
   * and list them.
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata>
      deleteWorkloadIdentityPoolAsync(DeleteWorkloadIdentityPoolRequest request) {
    return deleteWorkloadIdentityPoolOperationCallable().futureCall(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Deletes a [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
   *
   * <p>You cannot use a deleted pool to exchange external credentials for Google Cloud credentials.
   * However, deletion does not revoke credentials that have already been issued. Credentials issued
   * for a deleted pool do not grant access to resources. If the pool is undeleted, and the
   * credentials are not expired, they grant access again. You can undelete a pool for 30 days.
   * After 30 days, deletion is permanent. You cannot update deleted pools. However, you can view
   * and list them.
   *
   * <p>Sample code:
   */
  public final OperationCallable<
          DeleteWorkloadIdentityPoolRequest,
          WorkloadIdentityPool,
          WorkloadIdentityPoolOperationMetadata>
      deleteWorkloadIdentityPoolOperationCallable() {
    return stub.deleteWorkloadIdentityPoolOperationCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Deletes a [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
   *
   * <p>You cannot use a deleted pool to exchange external credentials for Google Cloud credentials.
   * However, deletion does not revoke credentials that have already been issued. Credentials issued
   * for a deleted pool do not grant access to resources. If the pool is undeleted, and the
   * credentials are not expired, they grant access again. You can undelete a pool for 30 days.
   * After 30 days, deletion is permanent. You cannot update deleted pools. However, you can view
   * and list them.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<DeleteWorkloadIdentityPoolRequest, Operation>
      deleteWorkloadIdentityPoolCallable() {
    return stub.deleteWorkloadIdentityPoolCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Undeletes a [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool], as long as it was
   * deleted fewer than 30 days ago.
   *
   * @param name Required. The name of the pool to undelete.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata>
      undeleteWorkloadIdentityPoolAsync(WorkloadIdentityPoolName name) {
    UndeleteWorkloadIdentityPoolRequest request =
        UndeleteWorkloadIdentityPoolRequest.newBuilder()
            .setName(name == null ? null : name.toString())
            .build();
    return undeleteWorkloadIdentityPoolAsync(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Undeletes a [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool], as long as it was
   * deleted fewer than 30 days ago.
   *
   * @param name Required. The name of the pool to undelete.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata>
      undeleteWorkloadIdentityPoolAsync(String name) {
    UndeleteWorkloadIdentityPoolRequest request =
        UndeleteWorkloadIdentityPoolRequest.newBuilder().setName(name).build();
    return undeleteWorkloadIdentityPoolAsync(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Undeletes a [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool], as long as it was
   * deleted fewer than 30 days ago.
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<WorkloadIdentityPool, WorkloadIdentityPoolOperationMetadata>
      undeleteWorkloadIdentityPoolAsync(UndeleteWorkloadIdentityPoolRequest request) {
    return undeleteWorkloadIdentityPoolOperationCallable().futureCall(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Undeletes a [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool], as long as it was
   * deleted fewer than 30 days ago.
   *
   * <p>Sample code:
   */
  public final OperationCallable<
          UndeleteWorkloadIdentityPoolRequest,
          WorkloadIdentityPool,
          WorkloadIdentityPoolOperationMetadata>
      undeleteWorkloadIdentityPoolOperationCallable() {
    return stub.undeleteWorkloadIdentityPoolOperationCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Undeletes a [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool], as long as it was
   * deleted fewer than 30 days ago.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<UndeleteWorkloadIdentityPoolRequest, Operation>
      undeleteWorkloadIdentityPoolCallable() {
    return stub.undeleteWorkloadIdentityPoolCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists all non-deleted
   * [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityPoolProvider]s in a
   * [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool]. If `show_deleted` is set to
   * `true`, then deleted providers are also listed.
   *
   * @param parent Required. The pool to list providers for.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ListWorkloadIdentityPoolProvidersPagedResponse listWorkloadIdentityPoolProviders(
      WorkloadIdentityPoolName parent) {
    ListWorkloadIdentityPoolProvidersRequest request =
        ListWorkloadIdentityPoolProvidersRequest.newBuilder()
            .setParent(parent == null ? null : parent.toString())
            .build();
    return listWorkloadIdentityPoolProviders(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists all non-deleted
   * [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityPoolProvider]s in a
   * [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool]. If `show_deleted` is set to
   * `true`, then deleted providers are also listed.
   *
   * @param parent Required. The pool to list providers for.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ListWorkloadIdentityPoolProvidersPagedResponse listWorkloadIdentityPoolProviders(
      String parent) {
    ListWorkloadIdentityPoolProvidersRequest request =
        ListWorkloadIdentityPoolProvidersRequest.newBuilder().setParent(parent).build();
    return listWorkloadIdentityPoolProviders(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists all non-deleted
   * [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityPoolProvider]s in a
   * [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool]. If `show_deleted` is set to
   * `true`, then deleted providers are also listed.
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ListWorkloadIdentityPoolProvidersPagedResponse listWorkloadIdentityPoolProviders(
      ListWorkloadIdentityPoolProvidersRequest request) {
    return listWorkloadIdentityPoolProvidersPagedCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists all non-deleted
   * [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityPoolProvider]s in a
   * [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool]. If `show_deleted` is set to
   * `true`, then deleted providers are also listed.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<
          ListWorkloadIdentityPoolProvidersRequest, ListWorkloadIdentityPoolProvidersPagedResponse>
      listWorkloadIdentityPoolProvidersPagedCallable() {
    return stub.listWorkloadIdentityPoolProvidersPagedCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists all non-deleted
   * [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityPoolProvider]s in a
   * [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool]. If `show_deleted` is set to
   * `true`, then deleted providers are also listed.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<
          ListWorkloadIdentityPoolProvidersRequest, ListWorkloadIdentityPoolProvidersResponse>
      listWorkloadIdentityPoolProvidersCallable() {
    return stub.listWorkloadIdentityPoolProvidersCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets an individual
   * [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityPoolProvider].
   *
   * @param name Required. The name of the provider to retrieve.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final WorkloadIdentityPoolProvider getWorkloadIdentityPoolProvider(
      WorkloadIdentityPoolProviderName name) {
    GetWorkloadIdentityPoolProviderRequest request =
        GetWorkloadIdentityPoolProviderRequest.newBuilder()
            .setName(name == null ? null : name.toString())
            .build();
    return getWorkloadIdentityPoolProvider(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets an individual
   * [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityPoolProvider].
   *
   * @param name Required. The name of the provider to retrieve.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final WorkloadIdentityPoolProvider getWorkloadIdentityPoolProvider(String name) {
    GetWorkloadIdentityPoolProviderRequest request =
        GetWorkloadIdentityPoolProviderRequest.newBuilder().setName(name).build();
    return getWorkloadIdentityPoolProvider(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets an individual
   * [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityPoolProvider].
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final WorkloadIdentityPoolProvider getWorkloadIdentityPoolProvider(
      GetWorkloadIdentityPoolProviderRequest request) {
    return getWorkloadIdentityPoolProviderCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets an individual
   * [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityPoolProvider].
   *
   * <p>Sample code:
   */
  public final UnaryCallable<GetWorkloadIdentityPoolProviderRequest, WorkloadIdentityPoolProvider>
      getWorkloadIdentityPoolProviderCallable() {
    return stub.getWorkloadIdentityPoolProviderCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a new [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider] in a
   * [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
   *
   * <p>You cannot reuse the name of a deleted provider until 30 days after deletion.
   *
   * @param parent Required. The pool to create this provider in.
   * @param workloadIdentityPoolProvider Required. The provider to create.
   * @param workloadIdentityPoolProviderId Required. The ID for the provider, which becomes the
   *     final component of the resource name. This value must be 4-32 characters, and may contain
   *     the characters [a-z0-9-]. The prefix `gcp-` is reserved for use by Google, and may not be
   *     specified.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<
          WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata>
      createWorkloadIdentityPoolProviderAsync(
          WorkloadIdentityPoolName parent,
          WorkloadIdentityPoolProvider workloadIdentityPoolProvider,
          String workloadIdentityPoolProviderId) {
    CreateWorkloadIdentityPoolProviderRequest request =
        CreateWorkloadIdentityPoolProviderRequest.newBuilder()
            .setParent(parent == null ? null : parent.toString())
            .setWorkloadIdentityPoolProvider(workloadIdentityPoolProvider)
            .setWorkloadIdentityPoolProviderId(workloadIdentityPoolProviderId)
            .build();
    return createWorkloadIdentityPoolProviderAsync(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a new [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider] in a
   * [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
   *
   * <p>You cannot reuse the name of a deleted provider until 30 days after deletion.
   *
   * @param parent Required. The pool to create this provider in.
   * @param workloadIdentityPoolProvider Required. The provider to create.
   * @param workloadIdentityPoolProviderId Required. The ID for the provider, which becomes the
   *     final component of the resource name. This value must be 4-32 characters, and may contain
   *     the characters [a-z0-9-]. The prefix `gcp-` is reserved for use by Google, and may not be
   *     specified.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<
          WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata>
      createWorkloadIdentityPoolProviderAsync(
          String parent,
          WorkloadIdentityPoolProvider workloadIdentityPoolProvider,
          String workloadIdentityPoolProviderId) {
    CreateWorkloadIdentityPoolProviderRequest request =
        CreateWorkloadIdentityPoolProviderRequest.newBuilder()
            .setParent(parent)
            .setWorkloadIdentityPoolProvider(workloadIdentityPoolProvider)
            .setWorkloadIdentityPoolProviderId(workloadIdentityPoolProviderId)
            .build();
    return createWorkloadIdentityPoolProviderAsync(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a new [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider] in a
   * [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
   *
   * <p>You cannot reuse the name of a deleted provider until 30 days after deletion.
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<
          WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata>
      createWorkloadIdentityPoolProviderAsync(CreateWorkloadIdentityPoolProviderRequest request) {
    return createWorkloadIdentityPoolProviderOperationCallable().futureCall(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a new [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider] in a
   * [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
   *
   * <p>You cannot reuse the name of a deleted provider until 30 days after deletion.
   *
   * <p>Sample code:
   */
  public final OperationCallable<
          CreateWorkloadIdentityPoolProviderRequest,
          WorkloadIdentityPoolProvider,
          WorkloadIdentityPoolProviderOperationMetadata>
      createWorkloadIdentityPoolProviderOperationCallable() {
    return stub.createWorkloadIdentityPoolProviderOperationCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a new [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider] in a
   * [WorkloadIdentityPool][google.iam.v1beta.WorkloadIdentityPool].
   *
   * <p>You cannot reuse the name of a deleted provider until 30 days after deletion.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<CreateWorkloadIdentityPoolProviderRequest, Operation>
      createWorkloadIdentityPoolProviderCallable() {
    return stub.createWorkloadIdentityPoolProviderCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Updates an existing [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider].
   *
   * @param workloadIdentityPoolProvider Required. The provider to update.
   * @param updateMask Required. The list of fields to update.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<
          WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata>
      updateWorkloadIdentityPoolProviderAsync(
          WorkloadIdentityPoolProvider workloadIdentityPoolProvider, FieldMask updateMask) {
    UpdateWorkloadIdentityPoolProviderRequest request =
        UpdateWorkloadIdentityPoolProviderRequest.newBuilder()
            .setWorkloadIdentityPoolProvider(workloadIdentityPoolProvider)
            .setUpdateMask(updateMask)
            .build();
    return updateWorkloadIdentityPoolProviderAsync(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Updates an existing [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider].
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<
          WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata>
      updateWorkloadIdentityPoolProviderAsync(UpdateWorkloadIdentityPoolProviderRequest request) {
    return updateWorkloadIdentityPoolProviderOperationCallable().futureCall(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Updates an existing [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider].
   *
   * <p>Sample code:
   */
  public final OperationCallable<
          UpdateWorkloadIdentityPoolProviderRequest,
          WorkloadIdentityPoolProvider,
          WorkloadIdentityPoolProviderOperationMetadata>
      updateWorkloadIdentityPoolProviderOperationCallable() {
    return stub.updateWorkloadIdentityPoolProviderOperationCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Updates an existing [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider].
   *
   * <p>Sample code:
   */
  public final UnaryCallable<UpdateWorkloadIdentityPoolProviderRequest, Operation>
      updateWorkloadIdentityPoolProviderCallable() {
    return stub.updateWorkloadIdentityPoolProviderCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Deletes a [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider]. Deleting
   * a provider does not revoke credentials that have already been issued; they continue to grant
   * access. You can undelete a provider for 30 days. After 30 days, deletion is permanent. You
   * cannot update deleted providers. However, you can view and list them.
   *
   * @param name Required. The name of the provider to delete.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<
          WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata>
      deleteWorkloadIdentityPoolProviderAsync(WorkloadIdentityPoolProviderName name) {
    DeleteWorkloadIdentityPoolProviderRequest request =
        DeleteWorkloadIdentityPoolProviderRequest.newBuilder()
            .setName(name == null ? null : name.toString())
            .build();
    return deleteWorkloadIdentityPoolProviderAsync(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Deletes a [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider]. Deleting
   * a provider does not revoke credentials that have already been issued; they continue to grant
   * access. You can undelete a provider for 30 days. After 30 days, deletion is permanent. You
   * cannot update deleted providers. However, you can view and list them.
   *
   * @param name Required. The name of the provider to delete.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<
          WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata>
      deleteWorkloadIdentityPoolProviderAsync(String name) {
    DeleteWorkloadIdentityPoolProviderRequest request =
        DeleteWorkloadIdentityPoolProviderRequest.newBuilder().setName(name).build();
    return deleteWorkloadIdentityPoolProviderAsync(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Deletes a [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider]. Deleting
   * a provider does not revoke credentials that have already been issued; they continue to grant
   * access. You can undelete a provider for 30 days. After 30 days, deletion is permanent. You
   * cannot update deleted providers. However, you can view and list them.
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<
          WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata>
      deleteWorkloadIdentityPoolProviderAsync(DeleteWorkloadIdentityPoolProviderRequest request) {
    return deleteWorkloadIdentityPoolProviderOperationCallable().futureCall(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Deletes a [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider]. Deleting
   * a provider does not revoke credentials that have already been issued; they continue to grant
   * access. You can undelete a provider for 30 days. After 30 days, deletion is permanent. You
   * cannot update deleted providers. However, you can view and list them.
   *
   * <p>Sample code:
   */
  public final OperationCallable<
          DeleteWorkloadIdentityPoolProviderRequest,
          WorkloadIdentityPoolProvider,
          WorkloadIdentityPoolProviderOperationMetadata>
      deleteWorkloadIdentityPoolProviderOperationCallable() {
    return stub.deleteWorkloadIdentityPoolProviderOperationCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Deletes a [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider]. Deleting
   * a provider does not revoke credentials that have already been issued; they continue to grant
   * access. You can undelete a provider for 30 days. After 30 days, deletion is permanent. You
   * cannot update deleted providers. However, you can view and list them.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<DeleteWorkloadIdentityPoolProviderRequest, Operation>
      deleteWorkloadIdentityPoolProviderCallable() {
    return stub.deleteWorkloadIdentityPoolProviderCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Undeletes a [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider], as long
   * as it was deleted fewer than 30 days ago.
   *
   * @param name Required. The name of the provider to undelete.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<
          WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata>
      undeleteWorkloadIdentityPoolProviderAsync(WorkloadIdentityPoolProviderName name) {
    UndeleteWorkloadIdentityPoolProviderRequest request =
        UndeleteWorkloadIdentityPoolProviderRequest.newBuilder()
            .setName(name == null ? null : name.toString())
            .build();
    return undeleteWorkloadIdentityPoolProviderAsync(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Undeletes a [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider], as long
   * as it was deleted fewer than 30 days ago.
   *
   * @param name Required. The name of the provider to undelete.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<
          WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata>
      undeleteWorkloadIdentityPoolProviderAsync(String name) {
    UndeleteWorkloadIdentityPoolProviderRequest request =
        UndeleteWorkloadIdentityPoolProviderRequest.newBuilder().setName(name).build();
    return undeleteWorkloadIdentityPoolProviderAsync(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Undeletes a [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider], as long
   * as it was deleted fewer than 30 days ago.
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<
          WorkloadIdentityPoolProvider, WorkloadIdentityPoolProviderOperationMetadata>
      undeleteWorkloadIdentityPoolProviderAsync(
          UndeleteWorkloadIdentityPoolProviderRequest request) {
    return undeleteWorkloadIdentityPoolProviderOperationCallable().futureCall(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Undeletes a [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider], as long
   * as it was deleted fewer than 30 days ago.
   *
   * <p>Sample code:
   */
  public final OperationCallable<
          UndeleteWorkloadIdentityPoolProviderRequest,
          WorkloadIdentityPoolProvider,
          WorkloadIdentityPoolProviderOperationMetadata>
      undeleteWorkloadIdentityPoolProviderOperationCallable() {
    return stub.undeleteWorkloadIdentityPoolProviderOperationCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Undeletes a [WorkloadIdentityPoolProvider][google.iam.v1beta.WorkloadIdentityProvider], as long
   * as it was deleted fewer than 30 days ago.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<UndeleteWorkloadIdentityPoolProviderRequest, Operation>
      undeleteWorkloadIdentityPoolProviderCallable() {
    return stub.undeleteWorkloadIdentityPoolProviderCallable();
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

  public static class ListWorkloadIdentityPoolsPagedResponse
      extends AbstractPagedListResponse<
          ListWorkloadIdentityPoolsRequest,
          ListWorkloadIdentityPoolsResponse,
          WorkloadIdentityPool,
          ListWorkloadIdentityPoolsPage,
          ListWorkloadIdentityPoolsFixedSizeCollection> {

    public static ApiFuture<ListWorkloadIdentityPoolsPagedResponse> createAsync(
        PageContext<
                ListWorkloadIdentityPoolsRequest,
                ListWorkloadIdentityPoolsResponse,
                WorkloadIdentityPool>
            context,
        ApiFuture<ListWorkloadIdentityPoolsResponse> futureResponse) {
      ApiFuture<ListWorkloadIdentityPoolsPage> futurePage =
          ListWorkloadIdentityPoolsPage.createEmptyPage().createPageAsync(context, futureResponse);
      return ApiFutures.transform(
          futurePage,
          new ApiFunction<ListWorkloadIdentityPoolsPage, ListWorkloadIdentityPoolsPagedResponse>() {
            @Override
            public ListWorkloadIdentityPoolsPagedResponse apply(
                ListWorkloadIdentityPoolsPage input) {
              return new ListWorkloadIdentityPoolsPagedResponse(input);
            }
          },
          MoreExecutors.directExecutor());
    }

    private ListWorkloadIdentityPoolsPagedResponse(ListWorkloadIdentityPoolsPage page) {
      super(page, ListWorkloadIdentityPoolsFixedSizeCollection.createEmptyCollection());
    }
  }

  public static class ListWorkloadIdentityPoolsPage
      extends AbstractPage<
          ListWorkloadIdentityPoolsRequest,
          ListWorkloadIdentityPoolsResponse,
          WorkloadIdentityPool,
          ListWorkloadIdentityPoolsPage> {

    private ListWorkloadIdentityPoolsPage(
        PageContext<
                ListWorkloadIdentityPoolsRequest,
                ListWorkloadIdentityPoolsResponse,
                WorkloadIdentityPool>
            context,
        ListWorkloadIdentityPoolsResponse response) {
      super(context, response);
    }

    private static ListWorkloadIdentityPoolsPage createEmptyPage() {
      return new ListWorkloadIdentityPoolsPage(null, null);
    }

    @Override
    protected ListWorkloadIdentityPoolsPage createPage(
        PageContext<
                ListWorkloadIdentityPoolsRequest,
                ListWorkloadIdentityPoolsResponse,
                WorkloadIdentityPool>
            context,
        ListWorkloadIdentityPoolsResponse response) {
      return new ListWorkloadIdentityPoolsPage(context, response);
    }

    @Override
    public ApiFuture<ListWorkloadIdentityPoolsPage> createPageAsync(
        PageContext<
                ListWorkloadIdentityPoolsRequest,
                ListWorkloadIdentityPoolsResponse,
                WorkloadIdentityPool>
            context,
        ApiFuture<ListWorkloadIdentityPoolsResponse> futureResponse) {
      return super.createPageAsync(context, futureResponse);
    }
  }

  public static class ListWorkloadIdentityPoolsFixedSizeCollection
      extends AbstractFixedSizeCollection<
          ListWorkloadIdentityPoolsRequest,
          ListWorkloadIdentityPoolsResponse,
          WorkloadIdentityPool,
          ListWorkloadIdentityPoolsPage,
          ListWorkloadIdentityPoolsFixedSizeCollection> {

    private ListWorkloadIdentityPoolsFixedSizeCollection(
        List<ListWorkloadIdentityPoolsPage> pages, int collectionSize) {
      super(pages, collectionSize);
    }

    private static ListWorkloadIdentityPoolsFixedSizeCollection createEmptyCollection() {
      return new ListWorkloadIdentityPoolsFixedSizeCollection(null, 0);
    }

    @Override
    protected ListWorkloadIdentityPoolsFixedSizeCollection createCollection(
        List<ListWorkloadIdentityPoolsPage> pages, int collectionSize) {
      return new ListWorkloadIdentityPoolsFixedSizeCollection(pages, collectionSize);
    }
  }

  public static class ListWorkloadIdentityPoolProvidersPagedResponse
      extends AbstractPagedListResponse<
          ListWorkloadIdentityPoolProvidersRequest,
          ListWorkloadIdentityPoolProvidersResponse,
          WorkloadIdentityPoolProvider,
          ListWorkloadIdentityPoolProvidersPage,
          ListWorkloadIdentityPoolProvidersFixedSizeCollection> {

    public static ApiFuture<ListWorkloadIdentityPoolProvidersPagedResponse> createAsync(
        PageContext<
                ListWorkloadIdentityPoolProvidersRequest,
                ListWorkloadIdentityPoolProvidersResponse,
                WorkloadIdentityPoolProvider>
            context,
        ApiFuture<ListWorkloadIdentityPoolProvidersResponse> futureResponse) {
      ApiFuture<ListWorkloadIdentityPoolProvidersPage> futurePage =
          ListWorkloadIdentityPoolProvidersPage.createEmptyPage()
              .createPageAsync(context, futureResponse);
      return ApiFutures.transform(
          futurePage,
          new ApiFunction<
              ListWorkloadIdentityPoolProvidersPage,
              ListWorkloadIdentityPoolProvidersPagedResponse>() {
            @Override
            public ListWorkloadIdentityPoolProvidersPagedResponse apply(
                ListWorkloadIdentityPoolProvidersPage input) {
              return new ListWorkloadIdentityPoolProvidersPagedResponse(input);
            }
          },
          MoreExecutors.directExecutor());
    }

    private ListWorkloadIdentityPoolProvidersPagedResponse(
        ListWorkloadIdentityPoolProvidersPage page) {
      super(page, ListWorkloadIdentityPoolProvidersFixedSizeCollection.createEmptyCollection());
    }
  }

  public static class ListWorkloadIdentityPoolProvidersPage
      extends AbstractPage<
          ListWorkloadIdentityPoolProvidersRequest,
          ListWorkloadIdentityPoolProvidersResponse,
          WorkloadIdentityPoolProvider,
          ListWorkloadIdentityPoolProvidersPage> {

    private ListWorkloadIdentityPoolProvidersPage(
        PageContext<
                ListWorkloadIdentityPoolProvidersRequest,
                ListWorkloadIdentityPoolProvidersResponse,
                WorkloadIdentityPoolProvider>
            context,
        ListWorkloadIdentityPoolProvidersResponse response) {
      super(context, response);
    }

    private static ListWorkloadIdentityPoolProvidersPage createEmptyPage() {
      return new ListWorkloadIdentityPoolProvidersPage(null, null);
    }

    @Override
    protected ListWorkloadIdentityPoolProvidersPage createPage(
        PageContext<
                ListWorkloadIdentityPoolProvidersRequest,
                ListWorkloadIdentityPoolProvidersResponse,
                WorkloadIdentityPoolProvider>
            context,
        ListWorkloadIdentityPoolProvidersResponse response) {
      return new ListWorkloadIdentityPoolProvidersPage(context, response);
    }

    @Override
    public ApiFuture<ListWorkloadIdentityPoolProvidersPage> createPageAsync(
        PageContext<
                ListWorkloadIdentityPoolProvidersRequest,
                ListWorkloadIdentityPoolProvidersResponse,
                WorkloadIdentityPoolProvider>
            context,
        ApiFuture<ListWorkloadIdentityPoolProvidersResponse> futureResponse) {
      return super.createPageAsync(context, futureResponse);
    }
  }

  public static class ListWorkloadIdentityPoolProvidersFixedSizeCollection
      extends AbstractFixedSizeCollection<
          ListWorkloadIdentityPoolProvidersRequest,
          ListWorkloadIdentityPoolProvidersResponse,
          WorkloadIdentityPoolProvider,
          ListWorkloadIdentityPoolProvidersPage,
          ListWorkloadIdentityPoolProvidersFixedSizeCollection> {

    private ListWorkloadIdentityPoolProvidersFixedSizeCollection(
        List<ListWorkloadIdentityPoolProvidersPage> pages, int collectionSize) {
      super(pages, collectionSize);
    }

    private static ListWorkloadIdentityPoolProvidersFixedSizeCollection createEmptyCollection() {
      return new ListWorkloadIdentityPoolProvidersFixedSizeCollection(null, 0);
    }

    @Override
    protected ListWorkloadIdentityPoolProvidersFixedSizeCollection createCollection(
        List<ListWorkloadIdentityPoolProvidersPage> pages, int collectionSize) {
      return new ListWorkloadIdentityPoolProvidersFixedSizeCollection(pages, collectionSize);
    }
  }
}
