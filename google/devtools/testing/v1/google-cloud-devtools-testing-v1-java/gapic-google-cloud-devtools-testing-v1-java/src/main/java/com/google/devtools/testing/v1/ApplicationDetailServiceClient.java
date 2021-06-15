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
import com.google.devtools.testing.v1.stub.ApplicationDetailServiceStub;
import com.google.devtools.testing.v1.stub.ApplicationDetailServiceStubSettings;
import java.io.IOException;
import java.util.concurrent.TimeUnit;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * Service Description: A service which parses input applications and returns details that can be
 * useful in the context of testing.
 *
 * <p>This class provides the ability to make remote calls to the backing service through method
 * calls that map to API methods. Sample code to get started:
 *
 * <pre>{@code
 * try (ApplicationDetailServiceClient applicationDetailServiceClient =
 *     ApplicationDetailServiceClient.create()) {
 *   GetApkDetailsRequest request =
 *       GetApkDetailsRequest.newBuilder().setLocation(FileReference.newBuilder().build()).build();
 *   GetApkDetailsResponse response = applicationDetailServiceClient.getApkDetails(request);
 * }
 * }</pre>
 *
 * <p>Note: close() needs to be called on the ApplicationDetailServiceClient object to clean up
 * resources such as threads. In the example above, try-with-resources is used, which automatically
 * calls close().
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
 * ApplicationDetailServiceSettings to create(). For example:
 *
 * <p>To customize credentials:
 *
 * <pre>{@code
 * ApplicationDetailServiceSettings applicationDetailServiceSettings =
 *     ApplicationDetailServiceSettings.newBuilder()
 *         .setCredentialsProvider(FixedCredentialsProvider.create(myCredentials))
 *         .build();
 * ApplicationDetailServiceClient applicationDetailServiceClient =
 *     ApplicationDetailServiceClient.create(applicationDetailServiceSettings);
 * }</pre>
 *
 * <p>To customize the endpoint:
 *
 * <pre>{@code
 * ApplicationDetailServiceSettings applicationDetailServiceSettings =
 *     ApplicationDetailServiceSettings.newBuilder().setEndpoint(myEndpoint).build();
 * ApplicationDetailServiceClient applicationDetailServiceClient =
 *     ApplicationDetailServiceClient.create(applicationDetailServiceSettings);
 * }</pre>
 *
 * <p>Please refer to the GitHub repository's samples for more quickstart code snippets.
 */
@Generated("by gapic-generator-java")
public class ApplicationDetailServiceClient implements BackgroundResource {
  private final ApplicationDetailServiceSettings settings;
  private final ApplicationDetailServiceStub stub;

  /** Constructs an instance of ApplicationDetailServiceClient with default settings. */
  public static final ApplicationDetailServiceClient create() throws IOException {
    return create(ApplicationDetailServiceSettings.newBuilder().build());
  }

  /**
   * Constructs an instance of ApplicationDetailServiceClient, using the given settings. The
   * channels are created based on the settings passed in, or defaults for any settings that are not
   * set.
   */
  public static final ApplicationDetailServiceClient create(
      ApplicationDetailServiceSettings settings) throws IOException {
    return new ApplicationDetailServiceClient(settings);
  }

  /**
   * Constructs an instance of ApplicationDetailServiceClient, using the given stub for making
   * calls. This is for advanced usage - prefer using create(ApplicationDetailServiceSettings).
   */
  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public static final ApplicationDetailServiceClient create(ApplicationDetailServiceStub stub) {
    return new ApplicationDetailServiceClient(stub);
  }

  /**
   * Constructs an instance of ApplicationDetailServiceClient, using the given settings. This is
   * protected so that it is easy to make a subclass, but otherwise, the static factory methods
   * should be preferred.
   */
  protected ApplicationDetailServiceClient(ApplicationDetailServiceSettings settings)
      throws IOException {
    this.settings = settings;
    this.stub = ((ApplicationDetailServiceStubSettings) settings.getStubSettings()).createStub();
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  protected ApplicationDetailServiceClient(ApplicationDetailServiceStub stub) {
    this.settings = null;
    this.stub = stub;
  }

  public final ApplicationDetailServiceSettings getSettings() {
    return settings;
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public ApplicationDetailServiceStub getStub() {
    return stub;
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets the details of an Android application APK.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (ApplicationDetailServiceClient applicationDetailServiceClient =
   *     ApplicationDetailServiceClient.create()) {
   *   GetApkDetailsRequest request =
   *       GetApkDetailsRequest.newBuilder().setLocation(FileReference.newBuilder().build()).build();
   *   GetApkDetailsResponse response = applicationDetailServiceClient.getApkDetails(request);
   * }
   * }</pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final GetApkDetailsResponse getApkDetails(GetApkDetailsRequest request) {
    return getApkDetailsCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets the details of an Android application APK.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (ApplicationDetailServiceClient applicationDetailServiceClient =
   *     ApplicationDetailServiceClient.create()) {
   *   GetApkDetailsRequest request =
   *       GetApkDetailsRequest.newBuilder().setLocation(FileReference.newBuilder().build()).build();
   *   ApiFuture<GetApkDetailsResponse> future =
   *       applicationDetailServiceClient.getApkDetailsCallable().futureCall(request);
   *   // Do something.
   *   GetApkDetailsResponse response = future.get();
   * }
   * }</pre>
   */
  public final UnaryCallable<GetApkDetailsRequest, GetApkDetailsResponse> getApkDetailsCallable() {
    return stub.getApkDetailsCallable();
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
