/*
 * Copyright 2021 Google LLC
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

package com.google.ads.admob.v1;

import com.google.ads.admob.v1.stub.AdMobApiStub;
import com.google.ads.admob.v1.stub.AdMobApiStubSettings;
import com.google.api.core.ApiFuture;
import com.google.api.core.ApiFutures;
import com.google.api.core.BetaApi;
import com.google.api.gax.core.BackgroundResource;
import com.google.api.gax.paging.AbstractFixedSizeCollection;
import com.google.api.gax.paging.AbstractPage;
import com.google.api.gax.paging.AbstractPagedListResponse;
import com.google.api.gax.rpc.PageContext;
import com.google.api.gax.rpc.ServerStreamingCallable;
import com.google.api.gax.rpc.UnaryCallable;
import com.google.common.util.concurrent.MoreExecutors;
import java.io.IOException;
import java.util.List;
import java.util.concurrent.TimeUnit;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * Service Description: The AdMob API allows AdMob publishers programmatically get information about
 * their AdMob account.
 *
 * <p>This class provides the ability to make remote calls to the backing service through method
 * calls that map to API methods. Sample code to get started:
 *
 * <pre>{@code
 * try (AdMobApiClient adMobApiClient = AdMobApiClient.create()) {
 *   String name = "name3373707";
 *   AdMobResourcesProto.PublisherAccount response = adMobApiClient.getPublisherAccount(name);
 * }
 * }</pre>
 *
 * <p>Note: close() needs to be called on the AdMobApiClient object to clean up resources such as
 * threads. In the example above, try-with-resources is used, which automatically calls close().
 *
 * <p>The surface of this class includes several types of Java methods for each of the API's
 * methods:
 *
 * <ol>
 *   <li> A "flattened" method. With this type of method, the fields of the request type have been
 *       converted into function parameters. It may be the case that not all fields are available as
 *       parameters, and not every API method will have a flattened method entry point.
 *   <li> A "request object" method. This type of method only takes one parameter, a request object,
 *       which must be constructed before the call. Not every API method will have a request object
 *       method.
 *   <li> A "callable" method. This type of method takes no parameters and returns an immutable API
 *       callable object, which can be used to initiate calls to the service.
 * </ol>
 *
 * <p>See the individual methods for example code.
 *
 * <p>Many parameters require resource names to be formatted in a particular way. To assist with
 * these names, this class includes a format method for each type of name, and additionally a parse
 * method to extract the individual identifiers contained within names that are returned.
 *
 * <p>This class can be customized by passing in a custom instance of AdMobApiSettings to create().
 * For example:
 *
 * <p>To customize credentials:
 *
 * <pre>{@code
 * AdMobApiSettings adMobApiSettings =
 *     AdMobApiSettings.newBuilder()
 *         .setCredentialsProvider(FixedCredentialsProvider.create(myCredentials))
 *         .build();
 * AdMobApiClient adMobApiClient = AdMobApiClient.create(adMobApiSettings);
 * }</pre>
 *
 * <p>To customize the endpoint:
 *
 * <pre>{@code
 * AdMobApiSettings adMobApiSettings =
 *     AdMobApiSettings.newBuilder().setEndpoint(myEndpoint).build();
 * AdMobApiClient adMobApiClient = AdMobApiClient.create(adMobApiSettings);
 * }</pre>
 *
 * <p>Please refer to the GitHub repository's samples for more quickstart code snippets.
 */
@Generated("by gapic-generator-java")
public class AdMobApiClient implements BackgroundResource {
  private final AdMobApiSettings settings;
  private final AdMobApiStub stub;

  /** Constructs an instance of AdMobApiClient with default settings. */
  public static final AdMobApiClient create() throws IOException {
    return create(AdMobApiSettings.newBuilder().build());
  }

  /**
   * Constructs an instance of AdMobApiClient, using the given settings. The channels are created
   * based on the settings passed in, or defaults for any settings that are not set.
   */
  public static final AdMobApiClient create(AdMobApiSettings settings) throws IOException {
    return new AdMobApiClient(settings);
  }

  /**
   * Constructs an instance of AdMobApiClient, using the given stub for making calls. This is for
   * advanced usage - prefer using create(AdMobApiSettings).
   */
  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public static final AdMobApiClient create(AdMobApiStub stub) {
    return new AdMobApiClient(stub);
  }

  /**
   * Constructs an instance of AdMobApiClient, using the given settings. This is protected so that
   * it is easy to make a subclass, but otherwise, the static factory methods should be preferred.
   */
  protected AdMobApiClient(AdMobApiSettings settings) throws IOException {
    this.settings = settings;
    this.stub = ((AdMobApiStubSettings) settings.getStubSettings()).createStub();
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  protected AdMobApiClient(AdMobApiStub stub) {
    this.settings = null;
    this.stub = stub;
  }

  public final AdMobApiSettings getSettings() {
    return settings;
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public AdMobApiStub getStub() {
    return stub;
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets information about the specified AdMob publisher account.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (AdMobApiClient adMobApiClient = AdMobApiClient.create()) {
   *   String name = "name3373707";
   *   AdMobResourcesProto.PublisherAccount response = adMobApiClient.getPublisherAccount(name);
   * }
   * }</pre>
   *
   * @param name Resource name of the publisher account to retrieve. Example:
   *     accounts/pub-9876543210987654
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final AdMobResourcesProto.PublisherAccount getPublisherAccount(String name) {
    AdMobApiProto.GetPublisherAccountRequest request =
        AdMobApiProto.GetPublisherAccountRequest.newBuilder().setName(name).build();
    return getPublisherAccount(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets information about the specified AdMob publisher account.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (AdMobApiClient adMobApiClient = AdMobApiClient.create()) {
   *   AdMobApiProto.GetPublisherAccountRequest request =
   *       AdMobApiProto.GetPublisherAccountRequest.newBuilder().setName("name3373707").build();
   *   AdMobResourcesProto.PublisherAccount response = adMobApiClient.getPublisherAccount(request);
   * }
   * }</pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final AdMobResourcesProto.PublisherAccount getPublisherAccount(
      AdMobApiProto.GetPublisherAccountRequest request) {
    return getPublisherAccountCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets information about the specified AdMob publisher account.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (AdMobApiClient adMobApiClient = AdMobApiClient.create()) {
   *   AdMobApiProto.GetPublisherAccountRequest request =
   *       AdMobApiProto.GetPublisherAccountRequest.newBuilder().setName("name3373707").build();
   *   ApiFuture<AdMobResourcesProto.PublisherAccount> future =
   *       adMobApiClient.getPublisherAccountCallable().futureCall(request);
   *   // Do something.
   *   AdMobResourcesProto.PublisherAccount response = future.get();
   * }
   * }</pre>
   */
  public final UnaryCallable<
          AdMobApiProto.GetPublisherAccountRequest, AdMobResourcesProto.PublisherAccount>
      getPublisherAccountCallable() {
    return stub.getPublisherAccountCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists the AdMob publisher account accessible with the client credential. Currently, all
   * credentials have access to at most one AdMob account.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (AdMobApiClient adMobApiClient = AdMobApiClient.create()) {
   *   AdMobApiProto.ListPublisherAccountsRequest request =
   *       AdMobApiProto.ListPublisherAccountsRequest.newBuilder()
   *           .setPageSize(883849137)
   *           .setPageToken("pageToken873572522")
   *           .build();
   *   for (AdMobResourcesProto.PublisherAccount element :
   *       adMobApiClient.listPublisherAccounts(request).iterateAll()) {
   *     // doThingsWith(element);
   *   }
   * }
   * }</pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ListPublisherAccountsPagedResponse listPublisherAccounts(
      AdMobApiProto.ListPublisherAccountsRequest request) {
    return listPublisherAccountsPagedCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists the AdMob publisher account accessible with the client credential. Currently, all
   * credentials have access to at most one AdMob account.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (AdMobApiClient adMobApiClient = AdMobApiClient.create()) {
   *   AdMobApiProto.ListPublisherAccountsRequest request =
   *       AdMobApiProto.ListPublisherAccountsRequest.newBuilder()
   *           .setPageSize(883849137)
   *           .setPageToken("pageToken873572522")
   *           .build();
   *   ApiFuture<AdMobResourcesProto.PublisherAccount> future =
   *       adMobApiClient.listPublisherAccountsPagedCallable().futureCall(request);
   *   // Do something.
   *   for (AdMobResourcesProto.PublisherAccount element : future.get().iterateAll()) {
   *     // doThingsWith(element);
   *   }
   * }
   * }</pre>
   */
  public final UnaryCallable<
          AdMobApiProto.ListPublisherAccountsRequest, ListPublisherAccountsPagedResponse>
      listPublisherAccountsPagedCallable() {
    return stub.listPublisherAccountsPagedCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists the AdMob publisher account accessible with the client credential. Currently, all
   * credentials have access to at most one AdMob account.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (AdMobApiClient adMobApiClient = AdMobApiClient.create()) {
   *   AdMobApiProto.ListPublisherAccountsRequest request =
   *       AdMobApiProto.ListPublisherAccountsRequest.newBuilder()
   *           .setPageSize(883849137)
   *           .setPageToken("pageToken873572522")
   *           .build();
   *   while (true) {
   *     AdMobApiProto.ListPublisherAccountsResponse response =
   *         adMobApiClient.listPublisherAccountsCallable().call(request);
   *     for (AdMobResourcesProto.PublisherAccount element : response.getResponsesList()) {
   *       // doThingsWith(element);
   *     }
   *     String nextPageToken = response.getNextPageToken();
   *     if (!Strings.isNullOrEmpty(nextPageToken)) {
   *       request = request.toBuilder().setPageToken(nextPageToken).build();
   *     } else {
   *       break;
   *     }
   *   }
   * }
   * }</pre>
   */
  public final UnaryCallable<
          AdMobApiProto.ListPublisherAccountsRequest, AdMobApiProto.ListPublisherAccountsResponse>
      listPublisherAccountsCallable() {
    return stub.listPublisherAccountsCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Generates an AdMob Network report based on the provided report specification.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (AdMobApiClient adMobApiClient = AdMobApiClient.create()) {
   *   AdMobApiProto.GenerateNetworkReportRequest request =
   *       AdMobApiProto.GenerateNetworkReportRequest.newBuilder()
   *           .setParent("parent-995424086")
   *           .setReportSpec(AdMobResourcesProto.NetworkReportSpec.newBuilder().build())
   *           .build();
   *   ServerStream<AdMobApiProto.GenerateNetworkReportResponse> stream =
   *       adMobApiClient.generateNetworkReportCallable().call(request);
   *   for (AdMobApiProto.GenerateNetworkReportResponse response : stream) {
   *     // Do something when a response is received.
   *   }
   * }
   * }</pre>
   */
  public final ServerStreamingCallable<
          AdMobApiProto.GenerateNetworkReportRequest, AdMobApiProto.GenerateNetworkReportResponse>
      generateNetworkReportCallable() {
    return stub.generateNetworkReportCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Generates an AdMob Mediation report based on the provided report specification.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (AdMobApiClient adMobApiClient = AdMobApiClient.create()) {
   *   AdMobApiProto.GenerateMediationReportRequest request =
   *       AdMobApiProto.GenerateMediationReportRequest.newBuilder()
   *           .setParent("parent-995424086")
   *           .setReportSpec(AdMobResourcesProto.MediationReportSpec.newBuilder().build())
   *           .build();
   *   ServerStream<AdMobApiProto.GenerateMediationReportResponse> stream =
   *       adMobApiClient.generateMediationReportCallable().call(request);
   *   for (AdMobApiProto.GenerateMediationReportResponse response : stream) {
   *     // Do something when a response is received.
   *   }
   * }
   * }</pre>
   */
  public final ServerStreamingCallable<
          AdMobApiProto.GenerateMediationReportRequest,
          AdMobApiProto.GenerateMediationReportResponse>
      generateMediationReportCallable() {
    return stub.generateMediationReportCallable();
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

  public static class ListPublisherAccountsPagedResponse
      extends AbstractPagedListResponse<
          AdMobApiProto.ListPublisherAccountsRequest, AdMobApiProto.ListPublisherAccountsResponse,
          AdMobResourcesProto.PublisherAccount, ListPublisherAccountsPage,
          ListPublisherAccountsFixedSizeCollection> {

    public static ApiFuture<ListPublisherAccountsPagedResponse> createAsync(
        PageContext<
                AdMobApiProto.ListPublisherAccountsRequest,
                AdMobApiProto.ListPublisherAccountsResponse, AdMobResourcesProto.PublisherAccount>
            context,
        ApiFuture<AdMobApiProto.ListPublisherAccountsResponse> futureResponse) {
      ApiFuture<ListPublisherAccountsPage> futurePage =
          ListPublisherAccountsPage.createEmptyPage().createPageAsync(context, futureResponse);
      return ApiFutures.transform(
          futurePage,
          input -> new ListPublisherAccountsPagedResponse(input),
          MoreExecutors.directExecutor());
    }

    private ListPublisherAccountsPagedResponse(ListPublisherAccountsPage page) {
      super(page, ListPublisherAccountsFixedSizeCollection.createEmptyCollection());
    }
  }

  public static class ListPublisherAccountsPage
      extends AbstractPage<
          AdMobApiProto.ListPublisherAccountsRequest, AdMobApiProto.ListPublisherAccountsResponse,
          AdMobResourcesProto.PublisherAccount, ListPublisherAccountsPage> {

    private ListPublisherAccountsPage(
        PageContext<
                AdMobApiProto.ListPublisherAccountsRequest,
                AdMobApiProto.ListPublisherAccountsResponse, AdMobResourcesProto.PublisherAccount>
            context,
        AdMobApiProto.ListPublisherAccountsResponse response) {
      super(context, response);
    }

    private static ListPublisherAccountsPage createEmptyPage() {
      return new ListPublisherAccountsPage(null, null);
    }

    @Override
    protected ListPublisherAccountsPage createPage(
        PageContext<
                AdMobApiProto.ListPublisherAccountsRequest,
                AdMobApiProto.ListPublisherAccountsResponse, AdMobResourcesProto.PublisherAccount>
            context,
        AdMobApiProto.ListPublisherAccountsResponse response) {
      return new ListPublisherAccountsPage(context, response);
    }

    @Override
    public ApiFuture<ListPublisherAccountsPage> createPageAsync(
        PageContext<
                AdMobApiProto.ListPublisherAccountsRequest,
                AdMobApiProto.ListPublisherAccountsResponse, AdMobResourcesProto.PublisherAccount>
            context,
        ApiFuture<AdMobApiProto.ListPublisherAccountsResponse> futureResponse) {
      return super.createPageAsync(context, futureResponse);
    }
  }

  public static class ListPublisherAccountsFixedSizeCollection
      extends AbstractFixedSizeCollection<
          AdMobApiProto.ListPublisherAccountsRequest, AdMobApiProto.ListPublisherAccountsResponse,
          AdMobResourcesProto.PublisherAccount, ListPublisherAccountsPage,
          ListPublisherAccountsFixedSizeCollection> {

    private ListPublisherAccountsFixedSizeCollection(
        List<ListPublisherAccountsPage> pages, int collectionSize) {
      super(pages, collectionSize);
    }

    private static ListPublisherAccountsFixedSizeCollection createEmptyCollection() {
      return new ListPublisherAccountsFixedSizeCollection(null, 0);
    }

    @Override
    protected ListPublisherAccountsFixedSizeCollection createCollection(
        List<ListPublisherAccountsPage> pages, int collectionSize) {
      return new ListPublisherAccountsFixedSizeCollection(pages, collectionSize);
    }
  }
}
