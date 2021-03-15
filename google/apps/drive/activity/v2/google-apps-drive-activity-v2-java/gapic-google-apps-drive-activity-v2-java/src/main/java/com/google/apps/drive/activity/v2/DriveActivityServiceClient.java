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

package com.google.apps.drive.activity.v2;

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
import com.google.apps.drive.activity.v2.stub.DriveActivityServiceStub;
import com.google.apps.drive.activity.v2.stub.DriveActivityServiceStubSettings;
import com.google.common.util.concurrent.MoreExecutors;
import java.io.IOException;
import java.util.List;
import java.util.concurrent.TimeUnit;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * Service Description: Service for querying activity on Drive items. Activity is user or system
 * action on Drive items that happened in the past. A Drive item can be a file or folder, or a Team
 * Drive.
 *
 * <p>This class provides the ability to make remote calls to the backing service through method
 * calls that map to API methods. Sample code to get started:
 *
 * <pre>{@code
 * try (DriveActivityServiceClient driveActivityServiceClient =
 *     DriveActivityServiceClient.create()) {
 *   QueryDriveActivityRequest request =
 *       QueryDriveActivityRequest.newBuilder()
 *           .setConsolidationStrategy(ConsolidationStrategy.newBuilder().build())
 *           .setPageSize(883849137)
 *           .setPageToken("pageToken873572522")
 *           .setFilter("filter-1274492040")
 *           .build();
 *   for (DriveActivity element :
 *       driveActivityServiceClient.queryDriveActivity(request).iterateAll()) {
 *     // doThingsWith(element);
 *   }
 * }
 * }</pre>
 *
 * <p>Note: close() needs to be called on the DriveActivityServiceClient object to clean up
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
 * <p>This class can be customized by passing in a custom instance of DriveActivityServiceSettings
 * to create(). For example:
 *
 * <p>To customize credentials:
 *
 * <pre>{@code
 * DriveActivityServiceSettings driveActivityServiceSettings =
 *     DriveActivityServiceSettings.newBuilder()
 *         .setCredentialsProvider(FixedCredentialsProvider.create(myCredentials))
 *         .build();
 * DriveActivityServiceClient driveActivityServiceClient =
 *     DriveActivityServiceClient.create(driveActivityServiceSettings);
 * }</pre>
 *
 * <p>To customize the endpoint:
 *
 * <pre>{@code
 * DriveActivityServiceSettings driveActivityServiceSettings =
 *     DriveActivityServiceSettings.newBuilder().setEndpoint(myEndpoint).build();
 * DriveActivityServiceClient driveActivityServiceClient =
 *     DriveActivityServiceClient.create(driveActivityServiceSettings);
 * }</pre>
 *
 * <p>Please refer to the GitHub repository's samples for more quickstart code snippets.
 */
@Generated("by gapic-generator-java")
public class DriveActivityServiceClient implements BackgroundResource {
  private final DriveActivityServiceSettings settings;
  private final DriveActivityServiceStub stub;

  /** Constructs an instance of DriveActivityServiceClient with default settings. */
  public static final DriveActivityServiceClient create() throws IOException {
    return create(DriveActivityServiceSettings.newBuilder().build());
  }

  /**
   * Constructs an instance of DriveActivityServiceClient, using the given settings. The channels
   * are created based on the settings passed in, or defaults for any settings that are not set.
   */
  public static final DriveActivityServiceClient create(DriveActivityServiceSettings settings)
      throws IOException {
    return new DriveActivityServiceClient(settings);
  }

  /**
   * Constructs an instance of DriveActivityServiceClient, using the given stub for making calls.
   * This is for advanced usage - prefer using create(DriveActivityServiceSettings).
   */
  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public static final DriveActivityServiceClient create(DriveActivityServiceStub stub) {
    return new DriveActivityServiceClient(stub);
  }

  /**
   * Constructs an instance of DriveActivityServiceClient, using the given settings. This is
   * protected so that it is easy to make a subclass, but otherwise, the static factory methods
   * should be preferred.
   */
  protected DriveActivityServiceClient(DriveActivityServiceSettings settings) throws IOException {
    this.settings = settings;
    this.stub = ((DriveActivityServiceStubSettings) settings.getStubSettings()).createStub();
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  protected DriveActivityServiceClient(DriveActivityServiceStub stub) {
    this.settings = null;
    this.stub = stub;
  }

  public final DriveActivityServiceSettings getSettings() {
    return settings;
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public DriveActivityServiceStub getStub() {
    return stub;
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Query past activity in Google Drive.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (DriveActivityServiceClient driveActivityServiceClient =
   *     DriveActivityServiceClient.create()) {
   *   QueryDriveActivityRequest request =
   *       QueryDriveActivityRequest.newBuilder()
   *           .setConsolidationStrategy(ConsolidationStrategy.newBuilder().build())
   *           .setPageSize(883849137)
   *           .setPageToken("pageToken873572522")
   *           .setFilter("filter-1274492040")
   *           .build();
   *   for (DriveActivity element :
   *       driveActivityServiceClient.queryDriveActivity(request).iterateAll()) {
   *     // doThingsWith(element);
   *   }
   * }
   * }</pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final QueryDriveActivityPagedResponse queryDriveActivity(
      QueryDriveActivityRequest request) {
    return queryDriveActivityPagedCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Query past activity in Google Drive.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (DriveActivityServiceClient driveActivityServiceClient =
   *     DriveActivityServiceClient.create()) {
   *   QueryDriveActivityRequest request =
   *       QueryDriveActivityRequest.newBuilder()
   *           .setConsolidationStrategy(ConsolidationStrategy.newBuilder().build())
   *           .setPageSize(883849137)
   *           .setPageToken("pageToken873572522")
   *           .setFilter("filter-1274492040")
   *           .build();
   *   ApiFuture<DriveActivity> future =
   *       driveActivityServiceClient.queryDriveActivityPagedCallable().futureCall(request);
   *   // Do something.
   *   for (DriveActivity element : future.get().iterateAll()) {
   *     // doThingsWith(element);
   *   }
   * }
   * }</pre>
   */
  public final UnaryCallable<QueryDriveActivityRequest, QueryDriveActivityPagedResponse>
      queryDriveActivityPagedCallable() {
    return stub.queryDriveActivityPagedCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Query past activity in Google Drive.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (DriveActivityServiceClient driveActivityServiceClient =
   *     DriveActivityServiceClient.create()) {
   *   QueryDriveActivityRequest request =
   *       QueryDriveActivityRequest.newBuilder()
   *           .setConsolidationStrategy(ConsolidationStrategy.newBuilder().build())
   *           .setPageSize(883849137)
   *           .setPageToken("pageToken873572522")
   *           .setFilter("filter-1274492040")
   *           .build();
   *   while (true) {
   *     QueryDriveActivityResponse response =
   *         driveActivityServiceClient.queryDriveActivityCallable().call(request);
   *     for (DriveActivity element : response.getResponsesList()) {
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
  public final UnaryCallable<QueryDriveActivityRequest, QueryDriveActivityResponse>
      queryDriveActivityCallable() {
    return stub.queryDriveActivityCallable();
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

  public static class QueryDriveActivityPagedResponse
      extends AbstractPagedListResponse<
          QueryDriveActivityRequest,
          QueryDriveActivityResponse,
          DriveActivity,
          QueryDriveActivityPage,
          QueryDriveActivityFixedSizeCollection> {

    public static ApiFuture<QueryDriveActivityPagedResponse> createAsync(
        PageContext<QueryDriveActivityRequest, QueryDriveActivityResponse, DriveActivity> context,
        ApiFuture<QueryDriveActivityResponse> futureResponse) {
      ApiFuture<QueryDriveActivityPage> futurePage =
          QueryDriveActivityPage.createEmptyPage().createPageAsync(context, futureResponse);
      return ApiFutures.transform(
          futurePage,
          new ApiFunction<QueryDriveActivityPage, QueryDriveActivityPagedResponse>() {
            @Override
            public QueryDriveActivityPagedResponse apply(QueryDriveActivityPage input) {
              return new QueryDriveActivityPagedResponse(input);
            }
          },
          MoreExecutors.directExecutor());
    }

    private QueryDriveActivityPagedResponse(QueryDriveActivityPage page) {
      super(page, QueryDriveActivityFixedSizeCollection.createEmptyCollection());
    }
  }

  public static class QueryDriveActivityPage
      extends AbstractPage<
          QueryDriveActivityRequest,
          QueryDriveActivityResponse,
          DriveActivity,
          QueryDriveActivityPage> {

    private QueryDriveActivityPage(
        PageContext<QueryDriveActivityRequest, QueryDriveActivityResponse, DriveActivity> context,
        QueryDriveActivityResponse response) {
      super(context, response);
    }

    private static QueryDriveActivityPage createEmptyPage() {
      return new QueryDriveActivityPage(null, null);
    }

    @Override
    protected QueryDriveActivityPage createPage(
        PageContext<QueryDriveActivityRequest, QueryDriveActivityResponse, DriveActivity> context,
        QueryDriveActivityResponse response) {
      return new QueryDriveActivityPage(context, response);
    }

    @Override
    public ApiFuture<QueryDriveActivityPage> createPageAsync(
        PageContext<QueryDriveActivityRequest, QueryDriveActivityResponse, DriveActivity> context,
        ApiFuture<QueryDriveActivityResponse> futureResponse) {
      return super.createPageAsync(context, futureResponse);
    }
  }

  public static class QueryDriveActivityFixedSizeCollection
      extends AbstractFixedSizeCollection<
          QueryDriveActivityRequest,
          QueryDriveActivityResponse,
          DriveActivity,
          QueryDriveActivityPage,
          QueryDriveActivityFixedSizeCollection> {

    private QueryDriveActivityFixedSizeCollection(
        List<QueryDriveActivityPage> pages, int collectionSize) {
      super(pages, collectionSize);
    }

    private static QueryDriveActivityFixedSizeCollection createEmptyCollection() {
      return new QueryDriveActivityFixedSizeCollection(null, 0);
    }

    @Override
    protected QueryDriveActivityFixedSizeCollection createCollection(
        List<QueryDriveActivityPage> pages, int collectionSize) {
      return new QueryDriveActivityFixedSizeCollection(pages, collectionSize);
    }
  }
}
