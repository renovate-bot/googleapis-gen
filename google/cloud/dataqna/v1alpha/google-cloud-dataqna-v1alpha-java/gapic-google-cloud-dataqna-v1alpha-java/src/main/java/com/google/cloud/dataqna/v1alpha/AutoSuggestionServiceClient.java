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

package com.google.cloud.dataqna.v1alpha;

import com.google.api.core.BetaApi;
import com.google.api.gax.core.BackgroundResource;
import com.google.api.gax.rpc.UnaryCallable;
import com.google.cloud.dataqna.v1alpha.stub.AutoSuggestionServiceStub;
import com.google.cloud.dataqna.v1alpha.stub.AutoSuggestionServiceStubSettings;
import java.io.IOException;
import java.util.concurrent.TimeUnit;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * Service Description: This stateless API provides automatic suggestions for natural language
 * queries for the data sources in the provided project and location.
 *
 * <p>The service provides a resourceless operation `suggestQueries` that can be called to get a
 * list of suggestions for a given incomplete query and scope (or list of scopes) under which the
 * query is to be interpreted.
 *
 * <p>There are two types of suggestions, ENTITY for single entity suggestions and TEMPLATE for full
 * sentences. By default, both types are returned.
 *
 * <p>Example Request: ``` GetSuggestions({ parent: "locations/us/projects/my-project" scopes:
 * "//bigquery.googleapis.com/projects/my-project/datasets/my-dataset/tables/my-table" query: "top
 * it" }) ```
 *
 * <p>The service will retrieve information based on the given scope(s) and give suggestions based
 * on that (e.g. "top item" for "top it" if "item" is a known dimension for the provided scope). ```
 * suggestions { suggestion_info { annotated_suggestion { text_formatted: "top item by sum of
 * usd_revenue_net" markups { type: DIMENSION start_char_index: 4 length: 4 } markups { type: METRIC
 * start_char_index: 19 length: 15 } } query_matches { start_char_index: 0 length: 6 } }
 * suggestion_type: TEMPLATE ranking_score: 0.9 } suggestions { suggestion_info {
 * annotated_suggestion { text_formatted: "item" markups { type: DIMENSION start_char_index: 4
 * length: 2 } } query_matches { start_char_index: 0 length: 6 } } suggestion_type: ENTITY
 * ranking_score: 0.8 } ```
 *
 * <p>This class provides the ability to make remote calls to the backing service through method
 * calls that map to API methods. Sample code to get started:
 *
 * <pre>{@code
 * try (AutoSuggestionServiceClient autoSuggestionServiceClient =
 *     AutoSuggestionServiceClient.create()) {
 *   SuggestQueriesRequest request =
 *       SuggestQueriesRequest.newBuilder()
 *           .setParent(LocationName.of("[PROJECT]", "[LOCATION]").toString())
 *           .addAllScopes(new ArrayList<String>())
 *           .setQuery("query107944136")
 *           .addAllSuggestionTypes(new ArrayList<SuggestionType>())
 *           .build();
 *   SuggestQueriesResponse response = autoSuggestionServiceClient.suggestQueries(request);
 * }
 * }</pre>
 *
 * <p>Note: close() needs to be called on the AutoSuggestionServiceClient object to clean up
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
 * <p>This class can be customized by passing in a custom instance of AutoSuggestionServiceSettings
 * to create(). For example:
 *
 * <p>To customize credentials:
 *
 * <pre>{@code
 * AutoSuggestionServiceSettings autoSuggestionServiceSettings =
 *     AutoSuggestionServiceSettings.newBuilder()
 *         .setCredentialsProvider(FixedCredentialsProvider.create(myCredentials))
 *         .build();
 * AutoSuggestionServiceClient autoSuggestionServiceClient =
 *     AutoSuggestionServiceClient.create(autoSuggestionServiceSettings);
 * }</pre>
 *
 * <p>To customize the endpoint:
 *
 * <pre>{@code
 * AutoSuggestionServiceSettings autoSuggestionServiceSettings =
 *     AutoSuggestionServiceSettings.newBuilder().setEndpoint(myEndpoint).build();
 * AutoSuggestionServiceClient autoSuggestionServiceClient =
 *     AutoSuggestionServiceClient.create(autoSuggestionServiceSettings);
 * }</pre>
 *
 * <p>Please refer to the GitHub repository's samples for more quickstart code snippets.
 */
@BetaApi
@Generated("by gapic-generator-java")
public class AutoSuggestionServiceClient implements BackgroundResource {
  private final AutoSuggestionServiceSettings settings;
  private final AutoSuggestionServiceStub stub;

  /** Constructs an instance of AutoSuggestionServiceClient with default settings. */
  public static final AutoSuggestionServiceClient create() throws IOException {
    return create(AutoSuggestionServiceSettings.newBuilder().build());
  }

  /**
   * Constructs an instance of AutoSuggestionServiceClient, using the given settings. The channels
   * are created based on the settings passed in, or defaults for any settings that are not set.
   */
  public static final AutoSuggestionServiceClient create(AutoSuggestionServiceSettings settings)
      throws IOException {
    return new AutoSuggestionServiceClient(settings);
  }

  /**
   * Constructs an instance of AutoSuggestionServiceClient, using the given stub for making calls.
   * This is for advanced usage - prefer using create(AutoSuggestionServiceSettings).
   */
  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public static final AutoSuggestionServiceClient create(AutoSuggestionServiceStub stub) {
    return new AutoSuggestionServiceClient(stub);
  }

  /**
   * Constructs an instance of AutoSuggestionServiceClient, using the given settings. This is
   * protected so that it is easy to make a subclass, but otherwise, the static factory methods
   * should be preferred.
   */
  protected AutoSuggestionServiceClient(AutoSuggestionServiceSettings settings) throws IOException {
    this.settings = settings;
    this.stub = ((AutoSuggestionServiceStubSettings) settings.getStubSettings()).createStub();
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  protected AutoSuggestionServiceClient(AutoSuggestionServiceStub stub) {
    this.settings = null;
    this.stub = stub;
  }

  public final AutoSuggestionServiceSettings getSettings() {
    return settings;
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public AutoSuggestionServiceStub getStub() {
    return stub;
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets a list of suggestions based on a prefix string. AutoSuggestion tolerance should be less
   * than 1 second.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (AutoSuggestionServiceClient autoSuggestionServiceClient =
   *     AutoSuggestionServiceClient.create()) {
   *   SuggestQueriesRequest request =
   *       SuggestQueriesRequest.newBuilder()
   *           .setParent(LocationName.of("[PROJECT]", "[LOCATION]").toString())
   *           .addAllScopes(new ArrayList<String>())
   *           .setQuery("query107944136")
   *           .addAllSuggestionTypes(new ArrayList<SuggestionType>())
   *           .build();
   *   SuggestQueriesResponse response = autoSuggestionServiceClient.suggestQueries(request);
   * }
   * }</pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final SuggestQueriesResponse suggestQueries(SuggestQueriesRequest request) {
    return suggestQueriesCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets a list of suggestions based on a prefix string. AutoSuggestion tolerance should be less
   * than 1 second.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (AutoSuggestionServiceClient autoSuggestionServiceClient =
   *     AutoSuggestionServiceClient.create()) {
   *   SuggestQueriesRequest request =
   *       SuggestQueriesRequest.newBuilder()
   *           .setParent(LocationName.of("[PROJECT]", "[LOCATION]").toString())
   *           .addAllScopes(new ArrayList<String>())
   *           .setQuery("query107944136")
   *           .addAllSuggestionTypes(new ArrayList<SuggestionType>())
   *           .build();
   *   ApiFuture<SuggestQueriesResponse> future =
   *       autoSuggestionServiceClient.suggestQueriesCallable().futureCall(request);
   *   // Do something.
   *   SuggestQueriesResponse response = future.get();
   * }
   * }</pre>
   */
  public final UnaryCallable<SuggestQueriesRequest, SuggestQueriesResponse>
      suggestQueriesCallable() {
    return stub.suggestQueriesCallable();
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
}
