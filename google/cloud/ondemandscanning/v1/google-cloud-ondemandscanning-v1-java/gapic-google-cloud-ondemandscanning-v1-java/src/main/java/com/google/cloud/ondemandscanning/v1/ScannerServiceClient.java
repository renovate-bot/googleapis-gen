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

package com.google.cloud.ondemandscanning.v1;

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
import com.google.cloud.ondemandscanning.v1.stub.ScannerServiceStub;
import com.google.cloud.ondemandscanning.v1.stub.ScannerServiceStubSettings;
import com.google.common.util.concurrent.MoreExecutors;
import com.google.longrunning.Operation;
import com.google.longrunning.OperationsClient;
import io.grafeas.v1.Occurrence;
import java.io.IOException;
import java.util.List;
import java.util.concurrent.TimeUnit;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * Service Description: The Scanner service of the On-Demand Scanning API.
 *
 * <p>This service provides a way to find vulnerabilities for the packages in some container image.
 * A user provides a a list of packages to `AnalyzePackages` and receives a list of vulnerabilities
 * in return. The `AnalyzePackages` method is asynchronous, implementing Long-running Operations to
 * track progress.
 *
 * <p>This class provides the ability to make remote calls to the backing service through method
 * calls that map to API methods. Sample code to get started:
 *
 * <pre>{@code
 * try (ScannerServiceClient scannerServiceClient = ScannerServiceClient.create()) {
 *   String parent = "parent-995424086";
 *   AnalyzePackagesResponse response = scannerServiceClient.analyzePackagesAsync(parent).get();
 * }
 * }</pre>
 *
 * <p>Note: close() needs to be called on the ScannerServiceClient object to clean up resources such
 * as threads. In the example above, try-with-resources is used, which automatically calls close().
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
 * <p>This class can be customized by passing in a custom instance of ScannerServiceSettings to
 * create(). For example:
 *
 * <p>To customize credentials:
 *
 * <pre>{@code
 * ScannerServiceSettings scannerServiceSettings =
 *     ScannerServiceSettings.newBuilder()
 *         .setCredentialsProvider(FixedCredentialsProvider.create(myCredentials))
 *         .build();
 * ScannerServiceClient scannerServiceClient = ScannerServiceClient.create(scannerServiceSettings);
 * }</pre>
 *
 * <p>To customize the endpoint:
 *
 * <pre>{@code
 * ScannerServiceSettings scannerServiceSettings =
 *     ScannerServiceSettings.newBuilder().setEndpoint(myEndpoint).build();
 * ScannerServiceClient scannerServiceClient = ScannerServiceClient.create(scannerServiceSettings);
 * }</pre>
 *
 * <p>Please refer to the GitHub repository's samples for more quickstart code snippets.
 */
@Generated("by gapic-generator-java")
public class ScannerServiceClient implements BackgroundResource {
  private final ScannerServiceSettings settings;
  private final ScannerServiceStub stub;
  private final OperationsClient operationsClient;

  /** Constructs an instance of ScannerServiceClient with default settings. */
  public static final ScannerServiceClient create() throws IOException {
    return create(ScannerServiceSettings.newBuilder().build());
  }

  /**
   * Constructs an instance of ScannerServiceClient, using the given settings. The channels are
   * created based on the settings passed in, or defaults for any settings that are not set.
   */
  public static final ScannerServiceClient create(ScannerServiceSettings settings)
      throws IOException {
    return new ScannerServiceClient(settings);
  }

  /**
   * Constructs an instance of ScannerServiceClient, using the given stub for making calls. This is
   * for advanced usage - prefer using create(ScannerServiceSettings).
   */
  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public static final ScannerServiceClient create(ScannerServiceStub stub) {
    return new ScannerServiceClient(stub);
  }

  /**
   * Constructs an instance of ScannerServiceClient, using the given settings. This is protected so
   * that it is easy to make a subclass, but otherwise, the static factory methods should be
   * preferred.
   */
  protected ScannerServiceClient(ScannerServiceSettings settings) throws IOException {
    this.settings = settings;
    this.stub = ((ScannerServiceStubSettings) settings.getStubSettings()).createStub();
    this.operationsClient = OperationsClient.create(this.stub.getOperationsStub());
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  protected ScannerServiceClient(ScannerServiceStub stub) {
    this.settings = null;
    this.stub = stub;
    this.operationsClient = OperationsClient.create(this.stub.getOperationsStub());
  }

  public final ScannerServiceSettings getSettings() {
    return settings;
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public ScannerServiceStub getStub() {
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
   * Initiates an analysis of the provided packages.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (ScannerServiceClient scannerServiceClient = ScannerServiceClient.create()) {
   *   String parent = "parent-995424086";
   *   AnalyzePackagesResponse response = scannerServiceClient.analyzePackagesAsync(parent).get();
   * }
   * }</pre>
   *
   * @param parent Required. The parent of the resource for which analysis is requested. Format:
   *     projects/[project_name]/locations/[location]
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<AnalyzePackagesResponse, AnalyzePackagesMetadata>
      analyzePackagesAsync(String parent) {
    AnalyzePackagesRequest request = AnalyzePackagesRequest.newBuilder().setParent(parent).build();
    return analyzePackagesAsync(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Initiates an analysis of the provided packages.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (ScannerServiceClient scannerServiceClient = ScannerServiceClient.create()) {
   *   AnalyzePackagesRequest request =
   *       AnalyzePackagesRequest.newBuilder()
   *           .setParent("parent-995424086")
   *           .setResourceUri("resourceUri1234527870")
   *           .addAllPackages(new ArrayList<Package.PackageData>())
   *           .build();
   *   AnalyzePackagesResponse response = scannerServiceClient.analyzePackagesAsync(request).get();
   * }
   * }</pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<AnalyzePackagesResponse, AnalyzePackagesMetadata>
      analyzePackagesAsync(AnalyzePackagesRequest request) {
    return analyzePackagesOperationCallable().futureCall(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Initiates an analysis of the provided packages.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (ScannerServiceClient scannerServiceClient = ScannerServiceClient.create()) {
   *   AnalyzePackagesRequest request =
   *       AnalyzePackagesRequest.newBuilder()
   *           .setParent("parent-995424086")
   *           .setResourceUri("resourceUri1234527870")
   *           .addAllPackages(new ArrayList<Package.PackageData>())
   *           .build();
   *   OperationFuture<AnalyzePackagesResponse, AnalyzePackagesMetadata> future =
   *       scannerServiceClient.analyzePackagesOperationCallable().futureCall(request);
   *   // Do something.
   *   AnalyzePackagesResponse response = future.get();
   * }
   * }</pre>
   */
  public final OperationCallable<
          AnalyzePackagesRequest, AnalyzePackagesResponse, AnalyzePackagesMetadata>
      analyzePackagesOperationCallable() {
    return stub.analyzePackagesOperationCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Initiates an analysis of the provided packages.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (ScannerServiceClient scannerServiceClient = ScannerServiceClient.create()) {
   *   AnalyzePackagesRequest request =
   *       AnalyzePackagesRequest.newBuilder()
   *           .setParent("parent-995424086")
   *           .setResourceUri("resourceUri1234527870")
   *           .addAllPackages(new ArrayList<Package.PackageData>())
   *           .build();
   *   ApiFuture<Operation> future =
   *       scannerServiceClient.analyzePackagesCallable().futureCall(request);
   *   // Do something.
   *   Operation response = future.get();
   * }
   * }</pre>
   */
  public final UnaryCallable<AnalyzePackagesRequest, Operation> analyzePackagesCallable() {
    return stub.analyzePackagesCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists vulnerabilities resulting from a successfully completed scan.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (ScannerServiceClient scannerServiceClient = ScannerServiceClient.create()) {
   *   String parent = "parent-995424086";
   *   for (Occurrence element : scannerServiceClient.listVulnerabilities(parent).iterateAll()) {
   *     // doThingsWith(element);
   *   }
   * }
   * }</pre>
   *
   * @param parent Required. The parent of the collection of Vulnerabilities being requested.
   *     Format: projects/[project_name]/locations/[location]/scans/[scan_id]
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ListVulnerabilitiesPagedResponse listVulnerabilities(String parent) {
    ListVulnerabilitiesRequest request =
        ListVulnerabilitiesRequest.newBuilder().setParent(parent).build();
    return listVulnerabilities(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists vulnerabilities resulting from a successfully completed scan.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (ScannerServiceClient scannerServiceClient = ScannerServiceClient.create()) {
   *   ListVulnerabilitiesRequest request =
   *       ListVulnerabilitiesRequest.newBuilder()
   *           .setParent("parent-995424086")
   *           .setPageSize(883849137)
   *           .setPageToken("pageToken873572522")
   *           .build();
   *   for (Occurrence element : scannerServiceClient.listVulnerabilities(request).iterateAll()) {
   *     // doThingsWith(element);
   *   }
   * }
   * }</pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ListVulnerabilitiesPagedResponse listVulnerabilities(
      ListVulnerabilitiesRequest request) {
    return listVulnerabilitiesPagedCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists vulnerabilities resulting from a successfully completed scan.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (ScannerServiceClient scannerServiceClient = ScannerServiceClient.create()) {
   *   ListVulnerabilitiesRequest request =
   *       ListVulnerabilitiesRequest.newBuilder()
   *           .setParent("parent-995424086")
   *           .setPageSize(883849137)
   *           .setPageToken("pageToken873572522")
   *           .build();
   *   ApiFuture<Occurrence> future =
   *       scannerServiceClient.listVulnerabilitiesPagedCallable().futureCall(request);
   *   // Do something.
   *   for (Occurrence element : future.get().iterateAll()) {
   *     // doThingsWith(element);
   *   }
   * }
   * }</pre>
   */
  public final UnaryCallable<ListVulnerabilitiesRequest, ListVulnerabilitiesPagedResponse>
      listVulnerabilitiesPagedCallable() {
    return stub.listVulnerabilitiesPagedCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists vulnerabilities resulting from a successfully completed scan.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (ScannerServiceClient scannerServiceClient = ScannerServiceClient.create()) {
   *   ListVulnerabilitiesRequest request =
   *       ListVulnerabilitiesRequest.newBuilder()
   *           .setParent("parent-995424086")
   *           .setPageSize(883849137)
   *           .setPageToken("pageToken873572522")
   *           .build();
   *   while (true) {
   *     ListVulnerabilitiesResponse response =
   *         scannerServiceClient.listVulnerabilitiesCallable().call(request);
   *     for (Occurrence element : response.getResponsesList()) {
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
  public final UnaryCallable<ListVulnerabilitiesRequest, ListVulnerabilitiesResponse>
      listVulnerabilitiesCallable() {
    return stub.listVulnerabilitiesCallable();
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

  public static class ListVulnerabilitiesPagedResponse
      extends AbstractPagedListResponse<
          ListVulnerabilitiesRequest, ListVulnerabilitiesResponse, Occurrence,
          ListVulnerabilitiesPage, ListVulnerabilitiesFixedSizeCollection> {

    public static ApiFuture<ListVulnerabilitiesPagedResponse> createAsync(
        PageContext<ListVulnerabilitiesRequest, ListVulnerabilitiesResponse, Occurrence> context,
        ApiFuture<ListVulnerabilitiesResponse> futureResponse) {
      ApiFuture<ListVulnerabilitiesPage> futurePage =
          ListVulnerabilitiesPage.createEmptyPage().createPageAsync(context, futureResponse);
      return ApiFutures.transform(
          futurePage,
          new ApiFunction<ListVulnerabilitiesPage, ListVulnerabilitiesPagedResponse>() {
            @Override
            public ListVulnerabilitiesPagedResponse apply(ListVulnerabilitiesPage input) {
              return new ListVulnerabilitiesPagedResponse(input);
            }
          },
          MoreExecutors.directExecutor());
    }

    private ListVulnerabilitiesPagedResponse(ListVulnerabilitiesPage page) {
      super(page, ListVulnerabilitiesFixedSizeCollection.createEmptyCollection());
    }
  }

  public static class ListVulnerabilitiesPage
      extends AbstractPage<
          ListVulnerabilitiesRequest, ListVulnerabilitiesResponse, Occurrence,
          ListVulnerabilitiesPage> {

    private ListVulnerabilitiesPage(
        PageContext<ListVulnerabilitiesRequest, ListVulnerabilitiesResponse, Occurrence> context,
        ListVulnerabilitiesResponse response) {
      super(context, response);
    }

    private static ListVulnerabilitiesPage createEmptyPage() {
      return new ListVulnerabilitiesPage(null, null);
    }

    @Override
    protected ListVulnerabilitiesPage createPage(
        PageContext<ListVulnerabilitiesRequest, ListVulnerabilitiesResponse, Occurrence> context,
        ListVulnerabilitiesResponse response) {
      return new ListVulnerabilitiesPage(context, response);
    }

    @Override
    public ApiFuture<ListVulnerabilitiesPage> createPageAsync(
        PageContext<ListVulnerabilitiesRequest, ListVulnerabilitiesResponse, Occurrence> context,
        ApiFuture<ListVulnerabilitiesResponse> futureResponse) {
      return super.createPageAsync(context, futureResponse);
    }
  }

  public static class ListVulnerabilitiesFixedSizeCollection
      extends AbstractFixedSizeCollection<
          ListVulnerabilitiesRequest, ListVulnerabilitiesResponse, Occurrence,
          ListVulnerabilitiesPage, ListVulnerabilitiesFixedSizeCollection> {

    private ListVulnerabilitiesFixedSizeCollection(
        List<ListVulnerabilitiesPage> pages, int collectionSize) {
      super(pages, collectionSize);
    }

    private static ListVulnerabilitiesFixedSizeCollection createEmptyCollection() {
      return new ListVulnerabilitiesFixedSizeCollection(null, 0);
    }

    @Override
    protected ListVulnerabilitiesFixedSizeCollection createCollection(
        List<ListVulnerabilitiesPage> pages, int collectionSize) {
      return new ListVulnerabilitiesFixedSizeCollection(pages, collectionSize);
    }
  }
}
