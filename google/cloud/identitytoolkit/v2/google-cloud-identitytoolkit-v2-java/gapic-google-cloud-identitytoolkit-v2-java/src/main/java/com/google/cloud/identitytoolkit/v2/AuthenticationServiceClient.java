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

package com.google.cloud.identitytoolkit.v2;

import com.google.api.core.BetaApi;
import com.google.api.gax.core.BackgroundResource;
import com.google.api.gax.rpc.UnaryCallable;
import com.google.cloud.identitytoolkit.v2.stub.AuthenticationServiceStub;
import com.google.cloud.identitytoolkit.v2.stub.AuthenticationServiceStubSettings;
import java.io.IOException;
import java.util.concurrent.TimeUnit;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * Service Description: Authentication for Identity Toolkit
 *
 * <p>This class provides the ability to make remote calls to the backing service through method
 * calls that map to API methods. Sample code to get started:
 *
 * <pre>{@code
 * try (AuthenticationServiceClient authenticationServiceClient =
 *     AuthenticationServiceClient.create()) {
 *   FinalizeMfaSignInRequest request =
 *       FinalizeMfaSignInRequest.newBuilder()
 *           .setMfaPendingCredential("mfaPendingCredential1875551302")
 *           .setTenantId("tenantId-1306693787")
 *           .build();
 *   FinalizeMfaSignInResponse response = authenticationServiceClient.finalizeMfaSignIn(request);
 * }
 * }</pre>
 *
 * <p>Note: close() needs to be called on the AuthenticationServiceClient object to clean up
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
 * <p>This class can be customized by passing in a custom instance of AuthenticationServiceSettings
 * to create(). For example:
 *
 * <p>To customize credentials:
 *
 * <pre>{@code
 * AuthenticationServiceSettings authenticationServiceSettings =
 *     AuthenticationServiceSettings.newBuilder()
 *         .setCredentialsProvider(FixedCredentialsProvider.create(myCredentials))
 *         .build();
 * AuthenticationServiceClient authenticationServiceClient =
 *     AuthenticationServiceClient.create(authenticationServiceSettings);
 * }</pre>
 *
 * <p>To customize the endpoint:
 *
 * <pre>{@code
 * AuthenticationServiceSettings authenticationServiceSettings =
 *     AuthenticationServiceSettings.newBuilder().setEndpoint(myEndpoint).build();
 * AuthenticationServiceClient authenticationServiceClient =
 *     AuthenticationServiceClient.create(authenticationServiceSettings);
 * }</pre>
 *
 * <p>Please refer to the GitHub repository's samples for more quickstart code snippets.
 */
@Generated("by gapic-generator-java")
public class AuthenticationServiceClient implements BackgroundResource {
  private final AuthenticationServiceSettings settings;
  private final AuthenticationServiceStub stub;

  /** Constructs an instance of AuthenticationServiceClient with default settings. */
  public static final AuthenticationServiceClient create() throws IOException {
    return create(AuthenticationServiceSettings.newBuilder().build());
  }

  /**
   * Constructs an instance of AuthenticationServiceClient, using the given settings. The channels
   * are created based on the settings passed in, or defaults for any settings that are not set.
   */
  public static final AuthenticationServiceClient create(AuthenticationServiceSettings settings)
      throws IOException {
    return new AuthenticationServiceClient(settings);
  }

  /**
   * Constructs an instance of AuthenticationServiceClient, using the given stub for making calls.
   * This is for advanced usage - prefer using create(AuthenticationServiceSettings).
   */
  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public static final AuthenticationServiceClient create(AuthenticationServiceStub stub) {
    return new AuthenticationServiceClient(stub);
  }

  /**
   * Constructs an instance of AuthenticationServiceClient, using the given settings. This is
   * protected so that it is easy to make a subclass, but otherwise, the static factory methods
   * should be preferred.
   */
  protected AuthenticationServiceClient(AuthenticationServiceSettings settings) throws IOException {
    this.settings = settings;
    this.stub = ((AuthenticationServiceStubSettings) settings.getStubSettings()).createStub();
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  protected AuthenticationServiceClient(AuthenticationServiceStub stub) {
    this.settings = null;
    this.stub = stub;
  }

  public final AuthenticationServiceSettings getSettings() {
    return settings;
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public AuthenticationServiceStub getStub() {
    return stub;
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Verifies the MFA challenge and performs sign-in
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (AuthenticationServiceClient authenticationServiceClient =
   *     AuthenticationServiceClient.create()) {
   *   FinalizeMfaSignInRequest request =
   *       FinalizeMfaSignInRequest.newBuilder()
   *           .setMfaPendingCredential("mfaPendingCredential1875551302")
   *           .setTenantId("tenantId-1306693787")
   *           .build();
   *   FinalizeMfaSignInResponse response = authenticationServiceClient.finalizeMfaSignIn(request);
   * }
   * }</pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final FinalizeMfaSignInResponse finalizeMfaSignIn(FinalizeMfaSignInRequest request) {
    return finalizeMfaSignInCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Verifies the MFA challenge and performs sign-in
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (AuthenticationServiceClient authenticationServiceClient =
   *     AuthenticationServiceClient.create()) {
   *   FinalizeMfaSignInRequest request =
   *       FinalizeMfaSignInRequest.newBuilder()
   *           .setMfaPendingCredential("mfaPendingCredential1875551302")
   *           .setTenantId("tenantId-1306693787")
   *           .build();
   *   ApiFuture<FinalizeMfaSignInResponse> future =
   *       authenticationServiceClient.finalizeMfaSignInCallable().futureCall(request);
   *   // Do something.
   *   FinalizeMfaSignInResponse response = future.get();
   * }
   * }</pre>
   */
  public final UnaryCallable<FinalizeMfaSignInRequest, FinalizeMfaSignInResponse>
      finalizeMfaSignInCallable() {
    return stub.finalizeMfaSignInCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Sends the MFA challenge
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (AuthenticationServiceClient authenticationServiceClient =
   *     AuthenticationServiceClient.create()) {
   *   StartMfaSignInRequest request =
   *       StartMfaSignInRequest.newBuilder()
   *           .setMfaPendingCredential("mfaPendingCredential1875551302")
   *           .setMfaEnrollmentId("mfaEnrollmentId-1545987769")
   *           .setTenantId("tenantId-1306693787")
   *           .build();
   *   StartMfaSignInResponse response = authenticationServiceClient.startMfaSignIn(request);
   * }
   * }</pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final StartMfaSignInResponse startMfaSignIn(StartMfaSignInRequest request) {
    return startMfaSignInCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Sends the MFA challenge
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (AuthenticationServiceClient authenticationServiceClient =
   *     AuthenticationServiceClient.create()) {
   *   StartMfaSignInRequest request =
   *       StartMfaSignInRequest.newBuilder()
   *           .setMfaPendingCredential("mfaPendingCredential1875551302")
   *           .setMfaEnrollmentId("mfaEnrollmentId-1545987769")
   *           .setTenantId("tenantId-1306693787")
   *           .build();
   *   ApiFuture<StartMfaSignInResponse> future =
   *       authenticationServiceClient.startMfaSignInCallable().futureCall(request);
   *   // Do something.
   *   StartMfaSignInResponse response = future.get();
   * }
   * }</pre>
   */
  public final UnaryCallable<StartMfaSignInRequest, StartMfaSignInResponse>
      startMfaSignInCallable() {
    return stub.startMfaSignInCallable();
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
