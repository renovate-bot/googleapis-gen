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

package com.google.ccc.hosted.marketplace.v2;

import com.google.api.core.BetaApi;
import com.google.api.gax.core.BackgroundResource;
import com.google.api.gax.rpc.UnaryCallable;
import com.google.ccc.hosted.marketplace.v2.stub.LicenseNotificationServiceStub;
import com.google.ccc.hosted.marketplace.v2.stub.LicenseNotificationServiceStubSettings;
import java.io.IOException;
import java.util.concurrent.TimeUnit;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * This class provides the ability to make remote calls to the backing service through method calls
 * that map to API methods. Sample code to get started:
 *
 * <pre>{@code
 * try (LicenseNotificationServiceClient licenseNotificationServiceClient =
 *     LicenseNotificationServiceClient.create()) {
 *   LicenseNotificationListRequest request =
 *       LicenseNotificationListRequest.newBuilder()
 *           .setApplicationId("applicationId-1011352949")
 *           .setMaxResults(1128457243)
 *           .setStartToken("startToken-1583451465")
 *           .setTimestamp(55126294)
 *           .build();
 *   LicenseNotificationList response = licenseNotificationServiceClient.list(request);
 * }
 * }</pre>
 *
 * <p>Note: close() needs to be called on the LicenseNotificationServiceClient object to clean up
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
 * LicenseNotificationServiceSettings to create(). For example:
 *
 * <p>To customize credentials:
 *
 * <pre>{@code
 * LicenseNotificationServiceSettings licenseNotificationServiceSettings =
 *     LicenseNotificationServiceSettings.newBuilder()
 *         .setCredentialsProvider(FixedCredentialsProvider.create(myCredentials))
 *         .build();
 * LicenseNotificationServiceClient licenseNotificationServiceClient =
 *     LicenseNotificationServiceClient.create(licenseNotificationServiceSettings);
 * }</pre>
 *
 * <p>To customize the endpoint:
 *
 * <pre>{@code
 * LicenseNotificationServiceSettings licenseNotificationServiceSettings =
 *     LicenseNotificationServiceSettings.newBuilder().setEndpoint(myEndpoint).build();
 * LicenseNotificationServiceClient licenseNotificationServiceClient =
 *     LicenseNotificationServiceClient.create(licenseNotificationServiceSettings);
 * }</pre>
 *
 * <p>Please refer to the GitHub repository's samples for more quickstart code snippets.
 */
@Generated("by gapic-generator-java")
public class LicenseNotificationServiceClient implements BackgroundResource {
  private final LicenseNotificationServiceSettings settings;
  private final LicenseNotificationServiceStub stub;

  /** Constructs an instance of LicenseNotificationServiceClient with default settings. */
  public static final LicenseNotificationServiceClient create() throws IOException {
    return create(LicenseNotificationServiceSettings.newBuilder().build());
  }

  /**
   * Constructs an instance of LicenseNotificationServiceClient, using the given settings. The
   * channels are created based on the settings passed in, or defaults for any settings that are not
   * set.
   */
  public static final LicenseNotificationServiceClient create(
      LicenseNotificationServiceSettings settings) throws IOException {
    return new LicenseNotificationServiceClient(settings);
  }

  /**
   * Constructs an instance of LicenseNotificationServiceClient, using the given stub for making
   * calls. This is for advanced usage - prefer using create(LicenseNotificationServiceSettings).
   */
  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public static final LicenseNotificationServiceClient create(LicenseNotificationServiceStub stub) {
    return new LicenseNotificationServiceClient(stub);
  }

  /**
   * Constructs an instance of LicenseNotificationServiceClient, using the given settings. This is
   * protected so that it is easy to make a subclass, but otherwise, the static factory methods
   * should be preferred.
   */
  protected LicenseNotificationServiceClient(LicenseNotificationServiceSettings settings)
      throws IOException {
    this.settings = settings;
    this.stub = ((LicenseNotificationServiceStubSettings) settings.getStubSettings()).createStub();
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  protected LicenseNotificationServiceClient(LicenseNotificationServiceStub stub) {
    this.settings = null;
    this.stub = stub;
  }

  public final LicenseNotificationServiceSettings getSettings() {
    return settings;
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public LicenseNotificationServiceStub getStub() {
    return stub;
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Get a list of licensing notifications with regards to a given app.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (LicenseNotificationServiceClient licenseNotificationServiceClient =
   *     LicenseNotificationServiceClient.create()) {
   *   LicenseNotificationListRequest request =
   *       LicenseNotificationListRequest.newBuilder()
   *           .setApplicationId("applicationId-1011352949")
   *           .setMaxResults(1128457243)
   *           .setStartToken("startToken-1583451465")
   *           .setTimestamp(55126294)
   *           .build();
   *   LicenseNotificationList response = licenseNotificationServiceClient.list(request);
   * }
   * }</pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final LicenseNotificationList list(LicenseNotificationListRequest request) {
    return listCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Get a list of licensing notifications with regards to a given app.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (LicenseNotificationServiceClient licenseNotificationServiceClient =
   *     LicenseNotificationServiceClient.create()) {
   *   LicenseNotificationListRequest request =
   *       LicenseNotificationListRequest.newBuilder()
   *           .setApplicationId("applicationId-1011352949")
   *           .setMaxResults(1128457243)
   *           .setStartToken("startToken-1583451465")
   *           .setTimestamp(55126294)
   *           .build();
   *   ApiFuture<LicenseNotificationList> future =
   *       licenseNotificationServiceClient.listCallable().futureCall(request);
   *   // Do something.
   *   LicenseNotificationList response = future.get();
   * }
   * }</pre>
   */
  public final UnaryCallable<LicenseNotificationListRequest, LicenseNotificationList>
      listCallable() {
    return stub.listCallable();
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
