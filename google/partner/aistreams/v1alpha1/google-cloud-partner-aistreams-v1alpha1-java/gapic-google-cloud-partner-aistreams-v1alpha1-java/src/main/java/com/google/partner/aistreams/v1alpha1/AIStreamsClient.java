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

package com.google.partner.aistreams.v1alpha1;

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
import com.google.common.util.concurrent.MoreExecutors;
import com.google.longrunning.Operation;
import com.google.longrunning.OperationsClient;
import com.google.partner.aistreams.v1alpha1.stub.AIStreamsStub;
import com.google.partner.aistreams.v1alpha1.stub.AIStreamsStubSettings;
import com.google.protobuf.Empty;
import com.google.protobuf.FieldMask;
import java.io.IOException;
import java.util.List;
import java.util.concurrent.TimeUnit;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * Service Description: AIStreams service.
 *
 * <p>This class provides the ability to make remote calls to the backing service through method
 * calls that map to API methods. Sample code to get started:
 *
 * <p>Note: close() needs to be called on the AIStreamsClient object to clean up resources such as
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
 * <p>This class can be customized by passing in a custom instance of AIStreamsSettings to create().
 * For example:
 *
 * <p>To customize credentials:
 *
 * <pre>{@code
 * AIStreamsSettings aIStreamsSettings =
 *     AIStreamsSettings.newBuilder()
 *         .setCredentialsProvider(FixedCredentialsProvider.create(myCredentials))
 *         .build();
 * AIStreamsClient aIStreamsClient = AIStreamsClient.create(aIStreamsSettings);
 * }</pre>
 *
 * <p>To customize the endpoint:
 *
 * <pre>{@code
 * AIStreamsSettings aIStreamsSettings =
 *     AIStreamsSettings.newBuilder().setEndpoint(myEndpoint).build();
 * AIStreamsClient aIStreamsClient = AIStreamsClient.create(aIStreamsSettings);
 * }</pre>
 *
 * <p>Please refer to the GitHub repository's samples for more quickstart code snippets.
 */
@BetaApi
@Generated("by gapic-generator-java")
public class AIStreamsClient implements BackgroundResource {
  private final AIStreamsSettings settings;
  private final AIStreamsStub stub;
  private final OperationsClient operationsClient;

  /** Constructs an instance of AIStreamsClient with default settings. */
  public static final AIStreamsClient create() throws IOException {
    return create(AIStreamsSettings.newBuilder().build());
  }

  /**
   * Constructs an instance of AIStreamsClient, using the given settings. The channels are created
   * based on the settings passed in, or defaults for any settings that are not set.
   */
  public static final AIStreamsClient create(AIStreamsSettings settings) throws IOException {
    return new AIStreamsClient(settings);
  }

  /**
   * Constructs an instance of AIStreamsClient, using the given stub for making calls. This is for
   * advanced usage - prefer using create(AIStreamsSettings).
   */
  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public static final AIStreamsClient create(AIStreamsStub stub) {
    return new AIStreamsClient(stub);
  }

  /**
   * Constructs an instance of AIStreamsClient, using the given settings. This is protected so that
   * it is easy to make a subclass, but otherwise, the static factory methods should be preferred.
   */
  protected AIStreamsClient(AIStreamsSettings settings) throws IOException {
    this.settings = settings;
    this.stub = ((AIStreamsStubSettings) settings.getStubSettings()).createStub();
    this.operationsClient = OperationsClient.create(this.stub.getOperationsStub());
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  protected AIStreamsClient(AIStreamsStub stub) {
    this.settings = null;
    this.stub = stub;
    this.operationsClient = OperationsClient.create(this.stub.getOperationsStub());
  }

  public final AIStreamsSettings getSettings() {
    return settings;
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public AIStreamsStub getStub() {
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
   * Lists Clusters in a given project and location.
   *
   * @param parent Required. The parent that owns the collection of Clusters.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ListClustersPagedResponse listClusters(LocationName parent) {
    ListClustersRequest request =
        ListClustersRequest.newBuilder()
            .setParent(parent == null ? null : parent.toString())
            .build();
    return listClusters(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists Clusters in a given project and location.
   *
   * @param parent Required. The parent that owns the collection of Clusters.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ListClustersPagedResponse listClusters(String parent) {
    ListClustersRequest request = ListClustersRequest.newBuilder().setParent(parent).build();
    return listClusters(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists Clusters in a given project and location.
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ListClustersPagedResponse listClusters(ListClustersRequest request) {
    return listClustersPagedCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists Clusters in a given project and location.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<ListClustersRequest, ListClustersPagedResponse>
      listClustersPagedCallable() {
    return stub.listClustersPagedCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists Clusters in a given project and location.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<ListClustersRequest, ListClustersResponse> listClustersCallable() {
    return stub.listClustersCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets details of a single Cluster.
   *
   * @param name Required. The name of the Cluster resource to get.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final Cluster getCluster(ClusterName name) {
    GetClusterRequest request =
        GetClusterRequest.newBuilder().setName(name == null ? null : name.toString()).build();
    return getCluster(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets details of a single Cluster.
   *
   * @param name Required. The name of the Cluster resource to get.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final Cluster getCluster(String name) {
    GetClusterRequest request = GetClusterRequest.newBuilder().setName(name).build();
    return getCluster(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets details of a single Cluster.
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final Cluster getCluster(GetClusterRequest request) {
    return getClusterCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets details of a single Cluster.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<GetClusterRequest, Cluster> getClusterCallable() {
    return stub.getClusterCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a new Cluster in a given project and location.
   *
   * @param parent Required. The parent that owns the collection of Clusters.
   * @param cluster Required. The cluster resource to create.
   * @param clusterId Required. The cluster identifier.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<Cluster, OperationMetadata> createClusterAsync(
      LocationName parent, Cluster cluster, String clusterId) {
    CreateClusterRequest request =
        CreateClusterRequest.newBuilder()
            .setParent(parent == null ? null : parent.toString())
            .setCluster(cluster)
            .setClusterId(clusterId)
            .build();
    return createClusterAsync(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a new Cluster in a given project and location.
   *
   * @param parent Required. The parent that owns the collection of Clusters.
   * @param cluster Required. The cluster resource to create.
   * @param clusterId Required. The cluster identifier.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<Cluster, OperationMetadata> createClusterAsync(
      String parent, Cluster cluster, String clusterId) {
    CreateClusterRequest request =
        CreateClusterRequest.newBuilder()
            .setParent(parent)
            .setCluster(cluster)
            .setClusterId(clusterId)
            .build();
    return createClusterAsync(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a new Cluster in a given project and location.
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<Cluster, OperationMetadata> createClusterAsync(
      CreateClusterRequest request) {
    return createClusterOperationCallable().futureCall(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a new Cluster in a given project and location.
   *
   * <p>Sample code:
   */
  public final OperationCallable<CreateClusterRequest, Cluster, OperationMetadata>
      createClusterOperationCallable() {
    return stub.createClusterOperationCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a new Cluster in a given project and location.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<CreateClusterRequest, Operation> createClusterCallable() {
    return stub.createClusterCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Updates the parameters of a single Cluster.
   *
   * @param cluster Required. The Cluster resource to update.
   * @param updateMask Required. Field mask is used to specify the fields to be overwritten in the
   *     Cluster resource by the update. The fields specified in the update_mask are relative to the
   *     resource, not the full request. A field will be overwritten if it is in the mask. If the
   *     user does not provide a mask then all fields will be overwritten.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<Cluster, OperationMetadata> updateClusterAsync(
      Cluster cluster, FieldMask updateMask) {
    UpdateClusterRequest request =
        UpdateClusterRequest.newBuilder().setCluster(cluster).setUpdateMask(updateMask).build();
    return updateClusterAsync(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Updates the parameters of a single Cluster.
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<Cluster, OperationMetadata> updateClusterAsync(
      UpdateClusterRequest request) {
    return updateClusterOperationCallable().futureCall(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Updates the parameters of a single Cluster.
   *
   * <p>Sample code:
   */
  public final OperationCallable<UpdateClusterRequest, Cluster, OperationMetadata>
      updateClusterOperationCallable() {
    return stub.updateClusterOperationCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Updates the parameters of a single Cluster.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<UpdateClusterRequest, Operation> updateClusterCallable() {
    return stub.updateClusterCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Deletes a single Cluster.
   *
   * @param name Required. The name of cluster to delete.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<Empty, OperationMetadata> deleteClusterAsync(ClusterName name) {
    DeleteClusterRequest request =
        DeleteClusterRequest.newBuilder().setName(name == null ? null : name.toString()).build();
    return deleteClusterAsync(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Deletes a single Cluster.
   *
   * @param name Required. The name of cluster to delete.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<Empty, OperationMetadata> deleteClusterAsync(String name) {
    DeleteClusterRequest request = DeleteClusterRequest.newBuilder().setName(name).build();
    return deleteClusterAsync(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Deletes a single Cluster.
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<Empty, OperationMetadata> deleteClusterAsync(
      DeleteClusterRequest request) {
    return deleteClusterOperationCallable().futureCall(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Deletes a single Cluster.
   *
   * <p>Sample code:
   */
  public final OperationCallable<DeleteClusterRequest, Empty, OperationMetadata>
      deleteClusterOperationCallable() {
    return stub.deleteClusterOperationCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Deletes a single Cluster.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<DeleteClusterRequest, Operation> deleteClusterCallable() {
    return stub.deleteClusterCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists Streams in a given project, location and cluster.
   *
   * @param parent Required. The parent that owns the collection of the Streams.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ListStreamsPagedResponse listStreams(ClusterName parent) {
    ListStreamsRequest request =
        ListStreamsRequest.newBuilder()
            .setParent(parent == null ? null : parent.toString())
            .build();
    return listStreams(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists Streams in a given project, location and cluster.
   *
   * @param parent Required. The parent that owns the collection of the Streams.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ListStreamsPagedResponse listStreams(String parent) {
    ListStreamsRequest request = ListStreamsRequest.newBuilder().setParent(parent).build();
    return listStreams(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists Streams in a given project, location and cluster.
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ListStreamsPagedResponse listStreams(ListStreamsRequest request) {
    return listStreamsPagedCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists Streams in a given project, location and cluster.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<ListStreamsRequest, ListStreamsPagedResponse>
      listStreamsPagedCallable() {
    return stub.listStreamsPagedCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists Streams in a given project, location and cluster.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<ListStreamsRequest, ListStreamsResponse> listStreamsCallable() {
    return stub.listStreamsCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets details of a single Stream.
   *
   * @param name Required. The name of the stream.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final Stream getStream(StreamName name) {
    GetStreamRequest request =
        GetStreamRequest.newBuilder().setName(name == null ? null : name.toString()).build();
    return getStream(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets details of a single Stream.
   *
   * @param name Required. The name of the stream.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final Stream getStream(String name) {
    GetStreamRequest request = GetStreamRequest.newBuilder().setName(name).build();
    return getStream(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets details of a single Stream.
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final Stream getStream(GetStreamRequest request) {
    return getStreamCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets details of a single Stream.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<GetStreamRequest, Stream> getStreamCallable() {
    return stub.getStreamCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a new Stream in a given project and location.
   *
   * @param parent Required. The parent that owns the collection of streams.
   * @param stream Required. The stream to create.
   * @param streamId Required. The stream identifier.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<Stream, OperationMetadata> createStreamAsync(
      ClusterName parent, Stream stream, String streamId) {
    CreateStreamRequest request =
        CreateStreamRequest.newBuilder()
            .setParent(parent == null ? null : parent.toString())
            .setStream(stream)
            .setStreamId(streamId)
            .build();
    return createStreamAsync(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a new Stream in a given project and location.
   *
   * @param parent Required. The parent that owns the collection of streams.
   * @param stream Required. The stream to create.
   * @param streamId Required. The stream identifier.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<Stream, OperationMetadata> createStreamAsync(
      String parent, Stream stream, String streamId) {
    CreateStreamRequest request =
        CreateStreamRequest.newBuilder()
            .setParent(parent)
            .setStream(stream)
            .setStreamId(streamId)
            .build();
    return createStreamAsync(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a new Stream in a given project and location.
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<Stream, OperationMetadata> createStreamAsync(
      CreateStreamRequest request) {
    return createStreamOperationCallable().futureCall(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a new Stream in a given project and location.
   *
   * <p>Sample code:
   */
  public final OperationCallable<CreateStreamRequest, Stream, OperationMetadata>
      createStreamOperationCallable() {
    return stub.createStreamOperationCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a new Stream in a given project and location.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<CreateStreamRequest, Operation> createStreamCallable() {
    return stub.createStreamCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Updates the parameters of a single Stream.
   *
   * @param stream Required. The stream resource to update.
   * @param updateMask Required. Field mask is used to specify the fields to be overwritten in the
   *     Stream resource by the update. The fields specified in the update_mask are relative to the
   *     resource, not the full request. A field will be overwritten if it is in the mask. If the
   *     user does not provide a mask then all fields will be overwritten.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<Stream, OperationMetadata> updateStreamAsync(
      Stream stream, FieldMask updateMask) {
    UpdateStreamRequest request =
        UpdateStreamRequest.newBuilder().setStream(stream).setUpdateMask(updateMask).build();
    return updateStreamAsync(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Updates the parameters of a single Stream.
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<Stream, OperationMetadata> updateStreamAsync(
      UpdateStreamRequest request) {
    return updateStreamOperationCallable().futureCall(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Updates the parameters of a single Stream.
   *
   * <p>Sample code:
   */
  public final OperationCallable<UpdateStreamRequest, Stream, OperationMetadata>
      updateStreamOperationCallable() {
    return stub.updateStreamOperationCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Updates the parameters of a single Stream.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<UpdateStreamRequest, Operation> updateStreamCallable() {
    return stub.updateStreamCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Deletes a single Stream.
   *
   * @param name Required. The name of the stream.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<Empty, OperationMetadata> deleteStreamAsync(StreamName name) {
    DeleteStreamRequest request =
        DeleteStreamRequest.newBuilder().setName(name == null ? null : name.toString()).build();
    return deleteStreamAsync(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Deletes a single Stream.
   *
   * @param name Required. The name of the stream.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<Empty, OperationMetadata> deleteStreamAsync(String name) {
    DeleteStreamRequest request = DeleteStreamRequest.newBuilder().setName(name).build();
    return deleteStreamAsync(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Deletes a single Stream.
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<Empty, OperationMetadata> deleteStreamAsync(
      DeleteStreamRequest request) {
    return deleteStreamOperationCallable().futureCall(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Deletes a single Stream.
   *
   * <p>Sample code:
   */
  public final OperationCallable<DeleteStreamRequest, Empty, OperationMetadata>
      deleteStreamOperationCallable() {
    return stub.deleteStreamOperationCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Deletes a single Stream.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<DeleteStreamRequest, Operation> deleteStreamCallable() {
    return stub.deleteStreamCallable();
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

  public static class ListClustersPagedResponse
      extends AbstractPagedListResponse<
          ListClustersRequest,
          ListClustersResponse,
          Cluster,
          ListClustersPage,
          ListClustersFixedSizeCollection> {

    public static ApiFuture<ListClustersPagedResponse> createAsync(
        PageContext<ListClustersRequest, ListClustersResponse, Cluster> context,
        ApiFuture<ListClustersResponse> futureResponse) {
      ApiFuture<ListClustersPage> futurePage =
          ListClustersPage.createEmptyPage().createPageAsync(context, futureResponse);
      return ApiFutures.transform(
          futurePage,
          new ApiFunction<ListClustersPage, ListClustersPagedResponse>() {
            @Override
            public ListClustersPagedResponse apply(ListClustersPage input) {
              return new ListClustersPagedResponse(input);
            }
          },
          MoreExecutors.directExecutor());
    }

    private ListClustersPagedResponse(ListClustersPage page) {
      super(page, ListClustersFixedSizeCollection.createEmptyCollection());
    }
  }

  public static class ListClustersPage
      extends AbstractPage<ListClustersRequest, ListClustersResponse, Cluster, ListClustersPage> {

    private ListClustersPage(
        PageContext<ListClustersRequest, ListClustersResponse, Cluster> context,
        ListClustersResponse response) {
      super(context, response);
    }

    private static ListClustersPage createEmptyPage() {
      return new ListClustersPage(null, null);
    }

    @Override
    protected ListClustersPage createPage(
        PageContext<ListClustersRequest, ListClustersResponse, Cluster> context,
        ListClustersResponse response) {
      return new ListClustersPage(context, response);
    }

    @Override
    public ApiFuture<ListClustersPage> createPageAsync(
        PageContext<ListClustersRequest, ListClustersResponse, Cluster> context,
        ApiFuture<ListClustersResponse> futureResponse) {
      return super.createPageAsync(context, futureResponse);
    }
  }

  public static class ListClustersFixedSizeCollection
      extends AbstractFixedSizeCollection<
          ListClustersRequest,
          ListClustersResponse,
          Cluster,
          ListClustersPage,
          ListClustersFixedSizeCollection> {

    private ListClustersFixedSizeCollection(List<ListClustersPage> pages, int collectionSize) {
      super(pages, collectionSize);
    }

    private static ListClustersFixedSizeCollection createEmptyCollection() {
      return new ListClustersFixedSizeCollection(null, 0);
    }

    @Override
    protected ListClustersFixedSizeCollection createCollection(
        List<ListClustersPage> pages, int collectionSize) {
      return new ListClustersFixedSizeCollection(pages, collectionSize);
    }
  }

  public static class ListStreamsPagedResponse
      extends AbstractPagedListResponse<
          ListStreamsRequest,
          ListStreamsResponse,
          Stream,
          ListStreamsPage,
          ListStreamsFixedSizeCollection> {

    public static ApiFuture<ListStreamsPagedResponse> createAsync(
        PageContext<ListStreamsRequest, ListStreamsResponse, Stream> context,
        ApiFuture<ListStreamsResponse> futureResponse) {
      ApiFuture<ListStreamsPage> futurePage =
          ListStreamsPage.createEmptyPage().createPageAsync(context, futureResponse);
      return ApiFutures.transform(
          futurePage,
          new ApiFunction<ListStreamsPage, ListStreamsPagedResponse>() {
            @Override
            public ListStreamsPagedResponse apply(ListStreamsPage input) {
              return new ListStreamsPagedResponse(input);
            }
          },
          MoreExecutors.directExecutor());
    }

    private ListStreamsPagedResponse(ListStreamsPage page) {
      super(page, ListStreamsFixedSizeCollection.createEmptyCollection());
    }
  }

  public static class ListStreamsPage
      extends AbstractPage<ListStreamsRequest, ListStreamsResponse, Stream, ListStreamsPage> {

    private ListStreamsPage(
        PageContext<ListStreamsRequest, ListStreamsResponse, Stream> context,
        ListStreamsResponse response) {
      super(context, response);
    }

    private static ListStreamsPage createEmptyPage() {
      return new ListStreamsPage(null, null);
    }

    @Override
    protected ListStreamsPage createPage(
        PageContext<ListStreamsRequest, ListStreamsResponse, Stream> context,
        ListStreamsResponse response) {
      return new ListStreamsPage(context, response);
    }

    @Override
    public ApiFuture<ListStreamsPage> createPageAsync(
        PageContext<ListStreamsRequest, ListStreamsResponse, Stream> context,
        ApiFuture<ListStreamsResponse> futureResponse) {
      return super.createPageAsync(context, futureResponse);
    }
  }

  public static class ListStreamsFixedSizeCollection
      extends AbstractFixedSizeCollection<
          ListStreamsRequest,
          ListStreamsResponse,
          Stream,
          ListStreamsPage,
          ListStreamsFixedSizeCollection> {

    private ListStreamsFixedSizeCollection(List<ListStreamsPage> pages, int collectionSize) {
      super(pages, collectionSize);
    }

    private static ListStreamsFixedSizeCollection createEmptyCollection() {
      return new ListStreamsFixedSizeCollection(null, 0);
    }

    @Override
    protected ListStreamsFixedSizeCollection createCollection(
        List<ListStreamsPage> pages, int collectionSize) {
      return new ListStreamsFixedSizeCollection(pages, collectionSize);
    }
  }
}
