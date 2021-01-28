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

package com.google.cloud.managedidentities.v1beta1;

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
import com.google.cloud.managedidentities.v1beta1.stub.ManagedIdentitiesServiceStub;
import com.google.cloud.managedidentities.v1beta1.stub.ManagedIdentitiesServiceStubSettings;
import com.google.common.util.concurrent.MoreExecutors;
import com.google.longrunning.Operation;
import com.google.longrunning.OperationsClient;
import com.google.protobuf.Empty;
import java.io.IOException;
import java.util.List;
import java.util.concurrent.TimeUnit;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * This class provides the ability to make remote calls to the backing service through method calls
 * that map to API methods. Sample code to get started:
 *
 * <p>Note: close() needs to be called on the ManagedIdentitiesServiceClient object to clean up
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
 * <p>This class can be customized by passing in a custom instance of
 * ManagedIdentitiesServiceSettings to create(). For example:
 *
 * <p>To customize credentials:
 *
 * <pre>{@code
 * ManagedIdentitiesServiceSettings managedIdentitiesServiceSettings =
 *     ManagedIdentitiesServiceSettings.newBuilder()
 *         .setCredentialsProvider(FixedCredentialsProvider.create(myCredentials))
 *         .build();
 * ManagedIdentitiesServiceClient managedIdentitiesServiceClient =
 *     ManagedIdentitiesServiceClient.create(managedIdentitiesServiceSettings);
 * }</pre>
 *
 * <p>To customize the endpoint:
 *
 * <pre>{@code
 * ManagedIdentitiesServiceSettings managedIdentitiesServiceSettings =
 *     ManagedIdentitiesServiceSettings.newBuilder().setEndpoint(myEndpoint).build();
 * ManagedIdentitiesServiceClient managedIdentitiesServiceClient =
 *     ManagedIdentitiesServiceClient.create(managedIdentitiesServiceSettings);
 * }</pre>
 *
 * <p>Please refer to the GitHub repository's samples for more quickstart code snippets.
 */
@BetaApi
@Generated("by gapic-generator-java")
public class ManagedIdentitiesServiceClient implements BackgroundResource {
  private final ManagedIdentitiesServiceSettings settings;
  private final ManagedIdentitiesServiceStub stub;
  private final OperationsClient operationsClient;

  /** Constructs an instance of ManagedIdentitiesServiceClient with default settings. */
  public static final ManagedIdentitiesServiceClient create() throws IOException {
    return create(ManagedIdentitiesServiceSettings.newBuilder().build());
  }

  /**
   * Constructs an instance of ManagedIdentitiesServiceClient, using the given settings. The
   * channels are created based on the settings passed in, or defaults for any settings that are not
   * set.
   */
  public static final ManagedIdentitiesServiceClient create(
      ManagedIdentitiesServiceSettings settings) throws IOException {
    return new ManagedIdentitiesServiceClient(settings);
  }

  /**
   * Constructs an instance of ManagedIdentitiesServiceClient, using the given stub for making
   * calls. This is for advanced usage - prefer using create(ManagedIdentitiesServiceSettings).
   */
  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public static final ManagedIdentitiesServiceClient create(ManagedIdentitiesServiceStub stub) {
    return new ManagedIdentitiesServiceClient(stub);
  }

  /**
   * Constructs an instance of ManagedIdentitiesServiceClient, using the given settings. This is
   * protected so that it is easy to make a subclass, but otherwise, the static factory methods
   * should be preferred.
   */
  protected ManagedIdentitiesServiceClient(ManagedIdentitiesServiceSettings settings)
      throws IOException {
    this.settings = settings;
    this.stub = ((ManagedIdentitiesServiceStubSettings) settings.getStubSettings()).createStub();
    this.operationsClient = OperationsClient.create(this.stub.getOperationsStub());
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  protected ManagedIdentitiesServiceClient(ManagedIdentitiesServiceStub stub) {
    this.settings = null;
    this.stub = stub;
    this.operationsClient = OperationsClient.create(this.stub.getOperationsStub());
  }

  public final ManagedIdentitiesServiceSettings getSettings() {
    return settings;
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public ManagedIdentitiesServiceStub getStub() {
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
   * Creates a Microsoft AD domain.
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<Domain, OpMetadata> createMicrosoftAdDomainAsync(
      CreateMicrosoftAdDomainRequest request) {
    return createMicrosoftAdDomainOperationCallable().futureCall(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a Microsoft AD domain.
   *
   * <p>Sample code:
   */
  public final OperationCallable<CreateMicrosoftAdDomainRequest, Domain, OpMetadata>
      createMicrosoftAdDomainOperationCallable() {
    return stub.createMicrosoftAdDomainOperationCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a Microsoft AD domain.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<CreateMicrosoftAdDomainRequest, Operation>
      createMicrosoftAdDomainCallable() {
    return stub.createMicrosoftAdDomainCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Resets a domain's administrator password.
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ResetAdminPasswordResponse resetAdminPassword(ResetAdminPasswordRequest request) {
    return resetAdminPasswordCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Resets a domain's administrator password.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<ResetAdminPasswordRequest, ResetAdminPasswordResponse>
      resetAdminPasswordCallable() {
    return stub.resetAdminPasswordCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists domains in a project.
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ListDomainsPagedResponse listDomains(ListDomainsRequest request) {
    return listDomainsPagedCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists domains in a project.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<ListDomainsRequest, ListDomainsPagedResponse>
      listDomainsPagedCallable() {
    return stub.listDomainsPagedCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists domains in a project.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<ListDomainsRequest, ListDomainsResponse> listDomainsCallable() {
    return stub.listDomainsCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets information about a domain.
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final Domain getDomain(GetDomainRequest request) {
    return getDomainCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets information about a domain.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<GetDomainRequest, Domain> getDomainCallable() {
    return stub.getDomainCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Updates the metadata and configuration of a domain.
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<Domain, OpMetadata> updateDomainAsync(UpdateDomainRequest request) {
    return updateDomainOperationCallable().futureCall(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Updates the metadata and configuration of a domain.
   *
   * <p>Sample code:
   */
  public final OperationCallable<UpdateDomainRequest, Domain, OpMetadata>
      updateDomainOperationCallable() {
    return stub.updateDomainOperationCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Updates the metadata and configuration of a domain.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<UpdateDomainRequest, Operation> updateDomainCallable() {
    return stub.updateDomainCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Deletes a domain.
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<Empty, OpMetadata> deleteDomainAsync(DeleteDomainRequest request) {
    return deleteDomainOperationCallable().futureCall(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Deletes a domain.
   *
   * <p>Sample code:
   */
  public final OperationCallable<DeleteDomainRequest, Empty, OpMetadata>
      deleteDomainOperationCallable() {
    return stub.deleteDomainOperationCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Deletes a domain.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<DeleteDomainRequest, Operation> deleteDomainCallable() {
    return stub.deleteDomainCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Adds an AD trust to a domain.
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<Domain, OpMetadata> attachTrustAsync(AttachTrustRequest request) {
    return attachTrustOperationCallable().futureCall(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Adds an AD trust to a domain.
   *
   * <p>Sample code:
   */
  public final OperationCallable<AttachTrustRequest, Domain, OpMetadata>
      attachTrustOperationCallable() {
    return stub.attachTrustOperationCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Adds an AD trust to a domain.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<AttachTrustRequest, Operation> attachTrustCallable() {
    return stub.attachTrustCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Updates the DNS conditional forwarder.
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<Domain, OpMetadata> reconfigureTrustAsync(
      ReconfigureTrustRequest request) {
    return reconfigureTrustOperationCallable().futureCall(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Updates the DNS conditional forwarder.
   *
   * <p>Sample code:
   */
  public final OperationCallable<ReconfigureTrustRequest, Domain, OpMetadata>
      reconfigureTrustOperationCallable() {
    return stub.reconfigureTrustOperationCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Updates the DNS conditional forwarder.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<ReconfigureTrustRequest, Operation> reconfigureTrustCallable() {
    return stub.reconfigureTrustCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Removes an AD trust.
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<Domain, OpMetadata> detachTrustAsync(DetachTrustRequest request) {
    return detachTrustOperationCallable().futureCall(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Removes an AD trust.
   *
   * <p>Sample code:
   */
  public final OperationCallable<DetachTrustRequest, Domain, OpMetadata>
      detachTrustOperationCallable() {
    return stub.detachTrustOperationCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Removes an AD trust.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<DetachTrustRequest, Operation> detachTrustCallable() {
    return stub.detachTrustCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Validates a trust state, that the target domain is reachable, and that the target domain is
   * able to accept incoming trust requests.
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<Domain, OpMetadata> validateTrustAsync(
      ValidateTrustRequest request) {
    return validateTrustOperationCallable().futureCall(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Validates a trust state, that the target domain is reachable, and that the target domain is
   * able to accept incoming trust requests.
   *
   * <p>Sample code:
   */
  public final OperationCallable<ValidateTrustRequest, Domain, OpMetadata>
      validateTrustOperationCallable() {
    return stub.validateTrustOperationCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Validates a trust state, that the target domain is reachable, and that the target domain is
   * able to accept incoming trust requests.
   *
   * <p>Sample code:
   */
  public final UnaryCallable<ValidateTrustRequest, Operation> validateTrustCallable() {
    return stub.validateTrustCallable();
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

  public static class ListDomainsPagedResponse
      extends AbstractPagedListResponse<
          ListDomainsRequest,
          ListDomainsResponse,
          Domain,
          ListDomainsPage,
          ListDomainsFixedSizeCollection> {

    public static ApiFuture<ListDomainsPagedResponse> createAsync(
        PageContext<ListDomainsRequest, ListDomainsResponse, Domain> context,
        ApiFuture<ListDomainsResponse> futureResponse) {
      ApiFuture<ListDomainsPage> futurePage =
          ListDomainsPage.createEmptyPage().createPageAsync(context, futureResponse);
      return ApiFutures.transform(
          futurePage,
          new ApiFunction<ListDomainsPage, ListDomainsPagedResponse>() {
            @Override
            public ListDomainsPagedResponse apply(ListDomainsPage input) {
              return new ListDomainsPagedResponse(input);
            }
          },
          MoreExecutors.directExecutor());
    }

    private ListDomainsPagedResponse(ListDomainsPage page) {
      super(page, ListDomainsFixedSizeCollection.createEmptyCollection());
    }
  }

  public static class ListDomainsPage
      extends AbstractPage<ListDomainsRequest, ListDomainsResponse, Domain, ListDomainsPage> {

    private ListDomainsPage(
        PageContext<ListDomainsRequest, ListDomainsResponse, Domain> context,
        ListDomainsResponse response) {
      super(context, response);
    }

    private static ListDomainsPage createEmptyPage() {
      return new ListDomainsPage(null, null);
    }

    @Override
    protected ListDomainsPage createPage(
        PageContext<ListDomainsRequest, ListDomainsResponse, Domain> context,
        ListDomainsResponse response) {
      return new ListDomainsPage(context, response);
    }

    @Override
    public ApiFuture<ListDomainsPage> createPageAsync(
        PageContext<ListDomainsRequest, ListDomainsResponse, Domain> context,
        ApiFuture<ListDomainsResponse> futureResponse) {
      return super.createPageAsync(context, futureResponse);
    }
  }

  public static class ListDomainsFixedSizeCollection
      extends AbstractFixedSizeCollection<
          ListDomainsRequest,
          ListDomainsResponse,
          Domain,
          ListDomainsPage,
          ListDomainsFixedSizeCollection> {

    private ListDomainsFixedSizeCollection(List<ListDomainsPage> pages, int collectionSize) {
      super(pages, collectionSize);
    }

    private static ListDomainsFixedSizeCollection createEmptyCollection() {
      return new ListDomainsFixedSizeCollection(null, 0);
    }

    @Override
    protected ListDomainsFixedSizeCollection createCollection(
        List<ListDomainsPage> pages, int collectionSize) {
      return new ListDomainsFixedSizeCollection(pages, collectionSize);
    }
  }
}
