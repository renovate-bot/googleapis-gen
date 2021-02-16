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

package com.google.maps.roads.v1op;

import com.google.api.core.BetaApi;
import com.google.api.gax.core.BackgroundResource;
import com.google.api.gax.rpc.UnaryCallable;
import com.google.maps.roads.v1op.stub.RoadsServiceStub;
import com.google.maps.roads.v1op.stub.RoadsServiceStubSettings;
import java.io.IOException;
import java.util.concurrent.TimeUnit;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * This class provides the ability to make remote calls to the backing service through method calls
 * that map to API methods. Sample code to get started:
 *
 * <pre>{@code
 * try (RoadsServiceClient roadsServiceClient = RoadsServiceClient.create()) {
 *   String path = "path3433509";
 *   SnapToRoadsResponse response = roadsServiceClient.snapToRoads(path);
 * }
 * }</pre>
 *
 * <p>Note: close() needs to be called on the RoadsServiceClient object to clean up resources such
 * as threads. In the example above, try-with-resources is used, which automatically calls close().
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
 * <p>This class can be customized by passing in a custom instance of RoadsServiceSettings to
 * create(). For example:
 *
 * <p>To customize credentials:
 *
 * <pre>{@code
 * RoadsServiceSettings roadsServiceSettings =
 *     RoadsServiceSettings.newBuilder()
 *         .setCredentialsProvider(FixedCredentialsProvider.create(myCredentials))
 *         .build();
 * RoadsServiceClient roadsServiceClient = RoadsServiceClient.create(roadsServiceSettings);
 * }</pre>
 *
 * <p>To customize the endpoint:
 *
 * <pre>{@code
 * RoadsServiceSettings roadsServiceSettings =
 *     RoadsServiceSettings.newBuilder().setEndpoint(myEndpoint).build();
 * RoadsServiceClient roadsServiceClient = RoadsServiceClient.create(roadsServiceSettings);
 * }</pre>
 *
 * <p>Please refer to the GitHub repository's samples for more quickstart code snippets.
 */
@Generated("by gapic-generator-java")
public class RoadsServiceClient implements BackgroundResource {
  private final RoadsServiceSettings settings;
  private final RoadsServiceStub stub;

  /** Constructs an instance of RoadsServiceClient with default settings. */
  public static final RoadsServiceClient create() throws IOException {
    return create(RoadsServiceSettings.newBuilder().build());
  }

  /**
   * Constructs an instance of RoadsServiceClient, using the given settings. The channels are
   * created based on the settings passed in, or defaults for any settings that are not set.
   */
  public static final RoadsServiceClient create(RoadsServiceSettings settings) throws IOException {
    return new RoadsServiceClient(settings);
  }

  /**
   * Constructs an instance of RoadsServiceClient, using the given stub for making calls. This is
   * for advanced usage - prefer using create(RoadsServiceSettings).
   */
  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public static final RoadsServiceClient create(RoadsServiceStub stub) {
    return new RoadsServiceClient(stub);
  }

  /**
   * Constructs an instance of RoadsServiceClient, using the given settings. This is protected so
   * that it is easy to make a subclass, but otherwise, the static factory methods should be
   * preferred.
   */
  protected RoadsServiceClient(RoadsServiceSettings settings) throws IOException {
    this.settings = settings;
    this.stub = ((RoadsServiceStubSettings) settings.getStubSettings()).createStub();
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  protected RoadsServiceClient(RoadsServiceStub stub) {
    this.settings = null;
    this.stub = stub;
  }

  public final RoadsServiceSettings getSettings() {
    return settings;
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public RoadsServiceStub getStub() {
    return stub;
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * This method takes a sequence of latitude,longitude points and snaps them to the most likely
   * road segments. Optionally returns additional points giving the full road geometry. Also returns
   * a place ID for each snapped point.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (RoadsServiceClient roadsServiceClient = RoadsServiceClient.create()) {
   *   String path = "path3433509";
   *   SnapToRoadsResponse response = roadsServiceClient.snapToRoads(path);
   * }
   * }</pre>
   *
   * @param path The path to be snapped as a series of lat, lng points. Specified as a string of the
   *     format: lat,lng|lat,lng|...
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final SnapToRoadsResponse snapToRoads(String path) {
    SnapToRoadsRequest request = SnapToRoadsRequest.newBuilder().setPath(path).build();
    return snapToRoads(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * This method takes a sequence of latitude,longitude points and snaps them to the most likely
   * road segments. Optionally returns additional points giving the full road geometry. Also returns
   * a place ID for each snapped point.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (RoadsServiceClient roadsServiceClient = RoadsServiceClient.create()) {
   *   SnapToRoadsRequest request =
   *       SnapToRoadsRequest.newBuilder()
   *           .setPath("path3433509")
   *           .setInterpolate(true)
   *           .setAssetId("assetId-704776149")
   *           .build();
   *   SnapToRoadsResponse response = roadsServiceClient.snapToRoads(request);
   * }
   * }</pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final SnapToRoadsResponse snapToRoads(SnapToRoadsRequest request) {
    return snapToRoadsCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * This method takes a sequence of latitude,longitude points and snaps them to the most likely
   * road segments. Optionally returns additional points giving the full road geometry. Also returns
   * a place ID for each snapped point.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (RoadsServiceClient roadsServiceClient = RoadsServiceClient.create()) {
   *   SnapToRoadsRequest request =
   *       SnapToRoadsRequest.newBuilder()
   *           .setPath("path3433509")
   *           .setInterpolate(true)
   *           .setAssetId("assetId-704776149")
   *           .build();
   *   ApiFuture<SnapToRoadsResponse> future =
   *       roadsServiceClient.snapToRoadsCallable().futureCall(request);
   *   // Do something.
   *   SnapToRoadsResponse response = future.get();
   * }
   * }</pre>
   */
  public final UnaryCallable<SnapToRoadsRequest, SnapToRoadsResponse> snapToRoadsCallable() {
    return stub.snapToRoadsCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * This method takes a list of latitude,longitude points and snaps them each to their nearest
   * road. Also returns a place ID for each snapped point.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (RoadsServiceClient roadsServiceClient = RoadsServiceClient.create()) {
   *   String points = "points-982754077";
   *   ListNearestRoadsResponse response = roadsServiceClient.listNearestRoads(points);
   * }
   * }</pre>
   *
   * @param points The points to be snapped as a series of lat, lng points. Specified as a string of
   *     the format: lat,lng|lat,lng|...
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ListNearestRoadsResponse listNearestRoads(String points) {
    ListNearestRoadsRequest request =
        ListNearestRoadsRequest.newBuilder().setPoints(points).build();
    return listNearestRoads(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * This method takes a list of latitude,longitude points and snaps them each to their nearest
   * road. Also returns a place ID for each snapped point.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (RoadsServiceClient roadsServiceClient = RoadsServiceClient.create()) {
   *   ListNearestRoadsRequest request =
   *       ListNearestRoadsRequest.newBuilder().setPoints("points-982754077").build();
   *   ListNearestRoadsResponse response = roadsServiceClient.listNearestRoads(request);
   * }
   * }</pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ListNearestRoadsResponse listNearestRoads(ListNearestRoadsRequest request) {
    return listNearestRoadsCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * This method takes a list of latitude,longitude points and snaps them each to their nearest
   * road. Also returns a place ID for each snapped point.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (RoadsServiceClient roadsServiceClient = RoadsServiceClient.create()) {
   *   ListNearestRoadsRequest request =
   *       ListNearestRoadsRequest.newBuilder().setPoints("points-982754077").build();
   *   ApiFuture<ListNearestRoadsResponse> future =
   *       roadsServiceClient.listNearestRoadsCallable().futureCall(request);
   *   // Do something.
   *   ListNearestRoadsResponse response = future.get();
   * }
   * }</pre>
   */
  public final UnaryCallable<ListNearestRoadsRequest, ListNearestRoadsResponse>
      listNearestRoadsCallable() {
    return stub.listNearestRoadsCallable();
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
