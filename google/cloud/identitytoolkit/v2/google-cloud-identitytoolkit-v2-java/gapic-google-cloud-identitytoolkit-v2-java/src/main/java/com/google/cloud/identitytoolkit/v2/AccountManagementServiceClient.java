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
import com.google.cloud.identitytoolkit.v2.stub.AccountManagementServiceStub;
import com.google.cloud.identitytoolkit.v2.stub.AccountManagementServiceStubSettings;
import java.io.IOException;
import java.util.concurrent.TimeUnit;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * Service Description: Account management for Identity Toolkit
 *
 * <p>This class provides the ability to make remote calls to the backing service through method
 * calls that map to API methods. Sample code to get started:
 *
 * <pre>{@code
 * try (AccountManagementServiceClient accountManagementServiceClient =
 *     AccountManagementServiceClient.create()) {
 *   FinalizeMfaEnrollmentRequest request =
 *       FinalizeMfaEnrollmentRequest.newBuilder()
 *           .setIdToken("idToken1642509726")
 *           .setDisplayName("displayName1714148973")
 *           .setTenantId("tenantId-1306693787")
 *           .build();
 *   FinalizeMfaEnrollmentResponse response =
 *       accountManagementServiceClient.finalizeMfaEnrollment(request);
 * }
 * }</pre>
 *
 * <p>Note: close() needs to be called on the AccountManagementServiceClient object to clean up
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
 * AccountManagementServiceSettings to create(). For example:
 *
 * <p>To customize credentials:
 *
 * <pre>{@code
 * AccountManagementServiceSettings accountManagementServiceSettings =
 *     AccountManagementServiceSettings.newBuilder()
 *         .setCredentialsProvider(FixedCredentialsProvider.create(myCredentials))
 *         .build();
 * AccountManagementServiceClient accountManagementServiceClient =
 *     AccountManagementServiceClient.create(accountManagementServiceSettings);
 * }</pre>
 *
 * <p>To customize the endpoint:
 *
 * <pre>{@code
 * AccountManagementServiceSettings accountManagementServiceSettings =
 *     AccountManagementServiceSettings.newBuilder().setEndpoint(myEndpoint).build();
 * AccountManagementServiceClient accountManagementServiceClient =
 *     AccountManagementServiceClient.create(accountManagementServiceSettings);
 * }</pre>
 *
 * <p>Please refer to the GitHub repository's samples for more quickstart code snippets.
 */
@Generated("by gapic-generator-java")
public class AccountManagementServiceClient implements BackgroundResource {
  private final AccountManagementServiceSettings settings;
  private final AccountManagementServiceStub stub;

  /** Constructs an instance of AccountManagementServiceClient with default settings. */
  public static final AccountManagementServiceClient create() throws IOException {
    return create(AccountManagementServiceSettings.newBuilder().build());
  }

  /**
   * Constructs an instance of AccountManagementServiceClient, using the given settings. The
   * channels are created based on the settings passed in, or defaults for any settings that are not
   * set.
   */
  public static final AccountManagementServiceClient create(
      AccountManagementServiceSettings settings) throws IOException {
    return new AccountManagementServiceClient(settings);
  }

  /**
   * Constructs an instance of AccountManagementServiceClient, using the given stub for making
   * calls. This is for advanced usage - prefer using create(AccountManagementServiceSettings).
   */
  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public static final AccountManagementServiceClient create(AccountManagementServiceStub stub) {
    return new AccountManagementServiceClient(stub);
  }

  /**
   * Constructs an instance of AccountManagementServiceClient, using the given settings. This is
   * protected so that it is easy to make a subclass, but otherwise, the static factory methods
   * should be preferred.
   */
  protected AccountManagementServiceClient(AccountManagementServiceSettings settings)
      throws IOException {
    this.settings = settings;
    this.stub = ((AccountManagementServiceStubSettings) settings.getStubSettings()).createStub();
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  protected AccountManagementServiceClient(AccountManagementServiceStub stub) {
    this.settings = null;
    this.stub = stub;
  }

  public final AccountManagementServiceSettings getSettings() {
    return settings;
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public AccountManagementServiceStub getStub() {
    return stub;
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Finishes enrolling a second factor for the user.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (AccountManagementServiceClient accountManagementServiceClient =
   *     AccountManagementServiceClient.create()) {
   *   FinalizeMfaEnrollmentRequest request =
   *       FinalizeMfaEnrollmentRequest.newBuilder()
   *           .setIdToken("idToken1642509726")
   *           .setDisplayName("displayName1714148973")
   *           .setTenantId("tenantId-1306693787")
   *           .build();
   *   FinalizeMfaEnrollmentResponse response =
   *       accountManagementServiceClient.finalizeMfaEnrollment(request);
   * }
   * }</pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final FinalizeMfaEnrollmentResponse finalizeMfaEnrollment(
      FinalizeMfaEnrollmentRequest request) {
    return finalizeMfaEnrollmentCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Finishes enrolling a second factor for the user.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (AccountManagementServiceClient accountManagementServiceClient =
   *     AccountManagementServiceClient.create()) {
   *   FinalizeMfaEnrollmentRequest request =
   *       FinalizeMfaEnrollmentRequest.newBuilder()
   *           .setIdToken("idToken1642509726")
   *           .setDisplayName("displayName1714148973")
   *           .setTenantId("tenantId-1306693787")
   *           .build();
   *   ApiFuture<FinalizeMfaEnrollmentResponse> future =
   *       accountManagementServiceClient.finalizeMfaEnrollmentCallable().futureCall(request);
   *   // Do something.
   *   FinalizeMfaEnrollmentResponse response = future.get();
   * }
   * }</pre>
   */
  public final UnaryCallable<FinalizeMfaEnrollmentRequest, FinalizeMfaEnrollmentResponse>
      finalizeMfaEnrollmentCallable() {
    return stub.finalizeMfaEnrollmentCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Step one of the MFA enrollment process. In SMS case, this sends an SMS verification code to the
   * user.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (AccountManagementServiceClient accountManagementServiceClient =
   *     AccountManagementServiceClient.create()) {
   *   StartMfaEnrollmentRequest request =
   *       StartMfaEnrollmentRequest.newBuilder()
   *           .setIdToken("idToken1642509726")
   *           .setTenantId("tenantId-1306693787")
   *           .build();
   *   StartMfaEnrollmentResponse response =
   *       accountManagementServiceClient.startMfaEnrollment(request);
   * }
   * }</pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final StartMfaEnrollmentResponse startMfaEnrollment(StartMfaEnrollmentRequest request) {
    return startMfaEnrollmentCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Step one of the MFA enrollment process. In SMS case, this sends an SMS verification code to the
   * user.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (AccountManagementServiceClient accountManagementServiceClient =
   *     AccountManagementServiceClient.create()) {
   *   StartMfaEnrollmentRequest request =
   *       StartMfaEnrollmentRequest.newBuilder()
   *           .setIdToken("idToken1642509726")
   *           .setTenantId("tenantId-1306693787")
   *           .build();
   *   ApiFuture<StartMfaEnrollmentResponse> future =
   *       accountManagementServiceClient.startMfaEnrollmentCallable().futureCall(request);
   *   // Do something.
   *   StartMfaEnrollmentResponse response = future.get();
   * }
   * }</pre>
   */
  public final UnaryCallable<StartMfaEnrollmentRequest, StartMfaEnrollmentResponse>
      startMfaEnrollmentCallable() {
    return stub.startMfaEnrollmentCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Revokes one second factor from the enrolled second factors for an account.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (AccountManagementServiceClient accountManagementServiceClient =
   *     AccountManagementServiceClient.create()) {
   *   WithdrawMfaRequest request =
   *       WithdrawMfaRequest.newBuilder()
   *           .setIdToken("idToken1642509726")
   *           .setMfaEnrollmentId("mfaEnrollmentId-1545987769")
   *           .setTenantId("tenantId-1306693787")
   *           .build();
   *   WithdrawMfaResponse response = accountManagementServiceClient.withdrawMfa(request);
   * }
   * }</pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final WithdrawMfaResponse withdrawMfa(WithdrawMfaRequest request) {
    return withdrawMfaCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Revokes one second factor from the enrolled second factors for an account.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (AccountManagementServiceClient accountManagementServiceClient =
   *     AccountManagementServiceClient.create()) {
   *   WithdrawMfaRequest request =
   *       WithdrawMfaRequest.newBuilder()
   *           .setIdToken("idToken1642509726")
   *           .setMfaEnrollmentId("mfaEnrollmentId-1545987769")
   *           .setTenantId("tenantId-1306693787")
   *           .build();
   *   ApiFuture<WithdrawMfaResponse> future =
   *       accountManagementServiceClient.withdrawMfaCallable().futureCall(request);
   *   // Do something.
   *   WithdrawMfaResponse response = future.get();
   * }
   * }</pre>
   */
  public final UnaryCallable<WithdrawMfaRequest, WithdrawMfaResponse> withdrawMfaCallable() {
    return stub.withdrawMfaCallable();
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
