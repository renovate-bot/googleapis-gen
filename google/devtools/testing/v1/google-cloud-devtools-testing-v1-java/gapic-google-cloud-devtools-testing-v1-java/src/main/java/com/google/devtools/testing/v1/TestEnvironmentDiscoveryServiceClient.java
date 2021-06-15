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

package com.google.devtools.testing.v1;

import com.google.api.core.BetaApi;
import com.google.api.gax.core.BackgroundResource;
import com.google.api.gax.rpc.UnaryCallable;
import com.google.devtools.testing.v1.stub.TestEnvironmentDiscoveryServiceStub;
import com.google.devtools.testing.v1.stub.TestEnvironmentDiscoveryServiceStubSettings;
import java.io.IOException;
import java.util.concurrent.TimeUnit;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * Service Description: Service for discovering environments supported by the TestExecutionService.
 *
 * <p>Over time the TestService may add or remove devices or configuration options (e.g., when new
 * devices and APIs are released). Clients should check here periodically to discover what options
 * are supported.
 *
 * <p>It defines the following resource model:
 *
 * <p>- The API a collection of [TestEnvironmentCatalog]
 * [google.devtools.test.v1.TestEnvironmentCatalog] resources, named `testEnvironmentCatalog/&#42;`
 *
 * <p>- Each TestEnvironmentCatalog resource describes a set of supported environments.
 *
 * <p>- An [AndroidDeviceCatalog][google.devtools.test.v1.AndroidDeviceCatalog] describes supported
 * Android devices. It contains lists of supported
 * [AndroidModels][google.devtools.test.v1.AndroidModel] and
 * [AndroidVersions][google.devtools.test.v1.AndroidVersion] along with a
 * [AndroidRuntimeConfiguration][google.devtools.test.v1.AndroidRuntimeConfiguration]. Each
 * AndroidModel contains a list of Versions it supports. All models support all locales and
 * orientations described by the AndroidRuntimeConfiguration
 *
 * <p>- An [IosDeviceCatalog][google.devtools.test.v1.IosDeviceCatalog] describes supported iOS
 * devices. It contains lists of supported [IosModels][google.devtools.test.v1.IosModel] and
 * [IosVersions][google.devtools.test.v1.IosVersion] along with a
 * [IosRuntimeConfiguration][google.devtools.test.v1.IosRuntimeConfiguration]. Each IosModel
 * contains a list of Versions it supports. All models support all locales and orientations
 * described by the IosRuntimeConfiguration.
 *
 * <p>This class provides the ability to make remote calls to the backing service through method
 * calls that map to API methods. Sample code to get started:
 *
 * <pre>{@code
 * try (TestEnvironmentDiscoveryServiceClient testEnvironmentDiscoveryServiceClient =
 *     TestEnvironmentDiscoveryServiceClient.create()) {
 *   GetTestEnvironmentCatalogRequest request =
 *       GetTestEnvironmentCatalogRequest.newBuilder().setProjectId("projectId-894832108").build();
 *   TestEnvironmentCatalog response =
 *       testEnvironmentDiscoveryServiceClient.getTestEnvironmentCatalog(request);
 * }
 * }</pre>
 *
 * <p>Note: close() needs to be called on the TestEnvironmentDiscoveryServiceClient object to clean
 * up resources such as threads. In the example above, try-with-resources is used, which
 * automatically calls close().
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
 * <p>This class can be customized by passing in a custom instance of
 * TestEnvironmentDiscoveryServiceSettings to create(). For example:
 *
 * <p>To customize credentials:
 *
 * <pre>{@code
 * TestEnvironmentDiscoveryServiceSettings testEnvironmentDiscoveryServiceSettings =
 *     TestEnvironmentDiscoveryServiceSettings.newBuilder()
 *         .setCredentialsProvider(FixedCredentialsProvider.create(myCredentials))
 *         .build();
 * TestEnvironmentDiscoveryServiceClient testEnvironmentDiscoveryServiceClient =
 *     TestEnvironmentDiscoveryServiceClient.create(testEnvironmentDiscoveryServiceSettings);
 * }</pre>
 *
 * <p>To customize the endpoint:
 *
 * <pre>{@code
 * TestEnvironmentDiscoveryServiceSettings testEnvironmentDiscoveryServiceSettings =
 *     TestEnvironmentDiscoveryServiceSettings.newBuilder().setEndpoint(myEndpoint).build();
 * TestEnvironmentDiscoveryServiceClient testEnvironmentDiscoveryServiceClient =
 *     TestEnvironmentDiscoveryServiceClient.create(testEnvironmentDiscoveryServiceSettings);
 * }</pre>
 *
 * <p>Please refer to the GitHub repository's samples for more quickstart code snippets.
 */
@Generated("by gapic-generator-java")
public class TestEnvironmentDiscoveryServiceClient implements BackgroundResource {
  private final TestEnvironmentDiscoveryServiceSettings settings;
  private final TestEnvironmentDiscoveryServiceStub stub;

  /** Constructs an instance of TestEnvironmentDiscoveryServiceClient with default settings. */
  public static final TestEnvironmentDiscoveryServiceClient create() throws IOException {
    return create(TestEnvironmentDiscoveryServiceSettings.newBuilder().build());
  }

  /**
   * Constructs an instance of TestEnvironmentDiscoveryServiceClient, using the given settings. The
   * channels are created based on the settings passed in, or defaults for any settings that are not
   * set.
   */
  public static final TestEnvironmentDiscoveryServiceClient create(
      TestEnvironmentDiscoveryServiceSettings settings) throws IOException {
    return new TestEnvironmentDiscoveryServiceClient(settings);
  }

  /**
   * Constructs an instance of TestEnvironmentDiscoveryServiceClient, using the given stub for
   * making calls. This is for advanced usage - prefer using
   * create(TestEnvironmentDiscoveryServiceSettings).
   */
  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public static final TestEnvironmentDiscoveryServiceClient create(
      TestEnvironmentDiscoveryServiceStub stub) {
    return new TestEnvironmentDiscoveryServiceClient(stub);
  }

  /**
   * Constructs an instance of TestEnvironmentDiscoveryServiceClient, using the given settings. This
   * is protected so that it is easy to make a subclass, but otherwise, the static factory methods
   * should be preferred.
   */
  protected TestEnvironmentDiscoveryServiceClient(TestEnvironmentDiscoveryServiceSettings settings)
      throws IOException {
    this.settings = settings;
    this.stub =
        ((TestEnvironmentDiscoveryServiceStubSettings) settings.getStubSettings()).createStub();
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  protected TestEnvironmentDiscoveryServiceClient(TestEnvironmentDiscoveryServiceStub stub) {
    this.settings = null;
    this.stub = stub;
  }

  public final TestEnvironmentDiscoveryServiceSettings getSettings() {
    return settings;
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public TestEnvironmentDiscoveryServiceStub getStub() {
    return stub;
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets the catalog of supported test environments.
   *
   * <p>May return any of the following canonical error codes:
   *
   * <p>- INVALID_ARGUMENT - if the request is malformed - NOT_FOUND - if the environment type does
   * not exist - INTERNAL - if an internal error occurred
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (TestEnvironmentDiscoveryServiceClient testEnvironmentDiscoveryServiceClient =
   *     TestEnvironmentDiscoveryServiceClient.create()) {
   *   GetTestEnvironmentCatalogRequest request =
   *       GetTestEnvironmentCatalogRequest.newBuilder().setProjectId("projectId-894832108").build();
   *   TestEnvironmentCatalog response =
   *       testEnvironmentDiscoveryServiceClient.getTestEnvironmentCatalog(request);
   * }
   * }</pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final TestEnvironmentCatalog getTestEnvironmentCatalog(
      GetTestEnvironmentCatalogRequest request) {
    return getTestEnvironmentCatalogCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets the catalog of supported test environments.
   *
   * <p>May return any of the following canonical error codes:
   *
   * <p>- INVALID_ARGUMENT - if the request is malformed - NOT_FOUND - if the environment type does
   * not exist - INTERNAL - if an internal error occurred
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (TestEnvironmentDiscoveryServiceClient testEnvironmentDiscoveryServiceClient =
   *     TestEnvironmentDiscoveryServiceClient.create()) {
   *   GetTestEnvironmentCatalogRequest request =
   *       GetTestEnvironmentCatalogRequest.newBuilder().setProjectId("projectId-894832108").build();
   *   ApiFuture<TestEnvironmentCatalog> future =
   *       testEnvironmentDiscoveryServiceClient
   *           .getTestEnvironmentCatalogCallable()
   *           .futureCall(request);
   *   // Do something.
   *   TestEnvironmentCatalog response = future.get();
   * }
   * }</pre>
   */
  public final UnaryCallable<GetTestEnvironmentCatalogRequest, TestEnvironmentCatalog>
      getTestEnvironmentCatalogCallable() {
    return stub.getTestEnvironmentCatalogCallable();
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
