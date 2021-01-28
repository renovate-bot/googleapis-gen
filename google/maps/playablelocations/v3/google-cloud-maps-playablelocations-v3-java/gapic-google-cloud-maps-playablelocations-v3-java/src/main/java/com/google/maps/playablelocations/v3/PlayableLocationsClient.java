/*
 * Copyright 2020 Google LLC
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     https://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
package com.google.maps.playablelocations.v3;

import com.google.api.core.BetaApi;
import com.google.api.gax.core.BackgroundResource;
import com.google.api.gax.rpc.UnaryCallable;
import com.google.maps.playablelocations.v3.stub.PlayableLocationsStub;
import com.google.maps.playablelocations.v3.stub.PlayableLocationsStubSettings;
import java.io.IOException;
import java.util.concurrent.TimeUnit;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND SERVICE
/**
 * Service Description: The Playable Locations API for v3.
 *
 * <p>This class provides the ability to make remote calls to the backing service through method
 * calls that map to API methods. Sample code to get started:
 *
 * <pre>
 * <code>
 * try (PlayableLocationsClient playableLocationsClient = PlayableLocationsClient.create()) {
 *   AreaFilter areaFilter = AreaFilter.newBuilder().build();
 *   List&lt;Criterion&gt; criteria = new ArrayList&lt;&gt;();
 *   SamplePlayableLocationsRequest request = SamplePlayableLocationsRequest.newBuilder()
 *     .setAreaFilter(areaFilter)
 *     .addAllCriteria(criteria)
 *     .build();
 *   SamplePlayableLocationsResponse response = playableLocationsClient.samplePlayableLocations(request);
 * }
 * </code>
 * </pre>
 *
 * <p>Note: close() needs to be called on the playableLocationsClient object to clean up resources
 * such as threads. In the example above, try-with-resources is used, which automatically calls
 * close().
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
 * <p>This class can be customized by passing in a custom instance of PlayableLocationsSettings to
 * create(). For example:
 *
 * <p>To customize credentials:
 *
 * <pre>
 * <code>
 * PlayableLocationsSettings playableLocationsSettings =
 *     PlayableLocationsSettings.newBuilder()
 *         .setCredentialsProvider(FixedCredentialsProvider.create(myCredentials))
 *         .build();
 * PlayableLocationsClient playableLocationsClient =
 *     PlayableLocationsClient.create(playableLocationsSettings);
 * </code>
 * </pre>
 *
 * To customize the endpoint:
 *
 * <pre>
 * <code>
 * PlayableLocationsSettings playableLocationsSettings =
 *     PlayableLocationsSettings.newBuilder().setEndpoint(myEndpoint).build();
 * PlayableLocationsClient playableLocationsClient =
 *     PlayableLocationsClient.create(playableLocationsSettings);
 * </code>
 * </pre>
 */
@Generated("by gapic-generator")
@BetaApi
public class PlayableLocationsClient implements BackgroundResource {
  private final PlayableLocationsSettings settings;
  private final PlayableLocationsStub stub;

  /** Constructs an instance of PlayableLocationsClient with default settings. */
  public static final PlayableLocationsClient create() throws IOException {
    return create(PlayableLocationsSettings.newBuilder().build());
  }

  /**
   * Constructs an instance of PlayableLocationsClient, using the given settings. The channels are
   * created based on the settings passed in, or defaults for any settings that are not set.
   */
  public static final PlayableLocationsClient create(PlayableLocationsSettings settings)
      throws IOException {
    return new PlayableLocationsClient(settings);
  }

  /**
   * Constructs an instance of PlayableLocationsClient, using the given stub for making calls. This
   * is for advanced usage - prefer to use PlayableLocationsSettings}.
   */
  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public static final PlayableLocationsClient create(PlayableLocationsStub stub) {
    return new PlayableLocationsClient(stub);
  }

  /**
   * Constructs an instance of PlayableLocationsClient, using the given settings. This is protected
   * so that it is easy to make a subclass, but otherwise, the static factory methods should be
   * preferred.
   */
  protected PlayableLocationsClient(PlayableLocationsSettings settings) throws IOException {
    this.settings = settings;
    this.stub = ((PlayableLocationsStubSettings) settings.getStubSettings()).createStub();
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  protected PlayableLocationsClient(PlayableLocationsStub stub) {
    this.settings = null;
    this.stub = stub;
  }

  public final PlayableLocationsSettings getSettings() {
    return settings;
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public PlayableLocationsStub getStub() {
    return stub;
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Returns a set of playable locations that lie within a specified area, that satisfy optional
   * filter criteria.
   *
   * <p>Note: Identical `SamplePlayableLocations` requests can return different results as the state
   * of the world changes over time.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (PlayableLocationsClient playableLocationsClient = PlayableLocationsClient.create()) {
   *   AreaFilter areaFilter = AreaFilter.newBuilder().build();
   *   List&lt;Criterion&gt; criteria = new ArrayList&lt;&gt;();
   *   SamplePlayableLocationsRequest request = SamplePlayableLocationsRequest.newBuilder()
   *     .setAreaFilter(areaFilter)
   *     .addAllCriteria(criteria)
   *     .build();
   *   SamplePlayableLocationsResponse response = playableLocationsClient.samplePlayableLocations(request);
   * }
   * </code></pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final SamplePlayableLocationsResponse samplePlayableLocations(
      SamplePlayableLocationsRequest request) {
    return samplePlayableLocationsCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Returns a set of playable locations that lie within a specified area, that satisfy optional
   * filter criteria.
   *
   * <p>Note: Identical `SamplePlayableLocations` requests can return different results as the state
   * of the world changes over time.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (PlayableLocationsClient playableLocationsClient = PlayableLocationsClient.create()) {
   *   AreaFilter areaFilter = AreaFilter.newBuilder().build();
   *   List&lt;Criterion&gt; criteria = new ArrayList&lt;&gt;();
   *   SamplePlayableLocationsRequest request = SamplePlayableLocationsRequest.newBuilder()
   *     .setAreaFilter(areaFilter)
   *     .addAllCriteria(criteria)
   *     .build();
   *   ApiFuture&lt;SamplePlayableLocationsResponse&gt; future = playableLocationsClient.samplePlayableLocationsCallable().futureCall(request);
   *   // Do something
   *   SamplePlayableLocationsResponse response = future.get();
   * }
   * </code></pre>
   */
  public final UnaryCallable<SamplePlayableLocationsRequest, SamplePlayableLocationsResponse>
      samplePlayableLocationsCallable() {
    return stub.samplePlayableLocationsCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Logs bad playable location reports submitted by players.
   *
   * <p>Reports are not partially saved; either all reports are saved and this request succeeds, or
   * no reports are saved, and this request fails.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (PlayableLocationsClient playableLocationsClient = PlayableLocationsClient.create()) {
   *   List&lt;PlayerReport&gt; playerReports = new ArrayList&lt;&gt;();
   *   String requestId = "";
   *   ClientInfo clientInfo = ClientInfo.newBuilder().build();
   *   LogPlayerReportsRequest request = LogPlayerReportsRequest.newBuilder()
   *     .addAllPlayerReports(playerReports)
   *     .setRequestId(requestId)
   *     .setClientInfo(clientInfo)
   *     .build();
   *   LogPlayerReportsResponse response = playableLocationsClient.logPlayerReports(request);
   * }
   * </code></pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final LogPlayerReportsResponse logPlayerReports(LogPlayerReportsRequest request) {
    return logPlayerReportsCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Logs bad playable location reports submitted by players.
   *
   * <p>Reports are not partially saved; either all reports are saved and this request succeeds, or
   * no reports are saved, and this request fails.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (PlayableLocationsClient playableLocationsClient = PlayableLocationsClient.create()) {
   *   List&lt;PlayerReport&gt; playerReports = new ArrayList&lt;&gt;();
   *   String requestId = "";
   *   ClientInfo clientInfo = ClientInfo.newBuilder().build();
   *   LogPlayerReportsRequest request = LogPlayerReportsRequest.newBuilder()
   *     .addAllPlayerReports(playerReports)
   *     .setRequestId(requestId)
   *     .setClientInfo(clientInfo)
   *     .build();
   *   ApiFuture&lt;LogPlayerReportsResponse&gt; future = playableLocationsClient.logPlayerReportsCallable().futureCall(request);
   *   // Do something
   *   LogPlayerReportsResponse response = future.get();
   * }
   * </code></pre>
   */
  public final UnaryCallable<LogPlayerReportsRequest, LogPlayerReportsResponse>
      logPlayerReportsCallable() {
    return stub.logPlayerReportsCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Logs new events when playable locations are displayed, and when they are interacted with.
   *
   * <p>Impressions are not partially saved; either all impressions are saved and this request
   * succeeds, or no impressions are saved, and this request fails.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (PlayableLocationsClient playableLocationsClient = PlayableLocationsClient.create()) {
   *   List&lt;Impression&gt; impressions = new ArrayList&lt;&gt;();
   *   String requestId = "";
   *   ClientInfo clientInfo = ClientInfo.newBuilder().build();
   *   LogImpressionsRequest request = LogImpressionsRequest.newBuilder()
   *     .addAllImpressions(impressions)
   *     .setRequestId(requestId)
   *     .setClientInfo(clientInfo)
   *     .build();
   *   LogImpressionsResponse response = playableLocationsClient.logImpressions(request);
   * }
   * </code></pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final LogImpressionsResponse logImpressions(LogImpressionsRequest request) {
    return logImpressionsCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD
  /**
   * Logs new events when playable locations are displayed, and when they are interacted with.
   *
   * <p>Impressions are not partially saved; either all impressions are saved and this request
   * succeeds, or no impressions are saved, and this request fails.
   *
   * <p>Sample code:
   *
   * <pre><code>
   * try (PlayableLocationsClient playableLocationsClient = PlayableLocationsClient.create()) {
   *   List&lt;Impression&gt; impressions = new ArrayList&lt;&gt;();
   *   String requestId = "";
   *   ClientInfo clientInfo = ClientInfo.newBuilder().build();
   *   LogImpressionsRequest request = LogImpressionsRequest.newBuilder()
   *     .addAllImpressions(impressions)
   *     .setRequestId(requestId)
   *     .setClientInfo(clientInfo)
   *     .build();
   *   ApiFuture&lt;LogImpressionsResponse&gt; future = playableLocationsClient.logImpressionsCallable().futureCall(request);
   *   // Do something
   *   LogImpressionsResponse response = future.get();
   * }
   * </code></pre>
   */
  public final UnaryCallable<LogImpressionsRequest, LogImpressionsResponse>
      logImpressionsCallable() {
    return stub.logImpressionsCallable();
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
