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

package com.google.ads.googleads.v3.services;

import com.google.ads.googleads.v3.resources.CurrencyConstant;
import com.google.ads.googleads.v3.resources.CurrencyConstantName;
import com.google.ads.googleads.v3.services.stub.CurrencyConstantServiceStub;
import com.google.ads.googleads.v3.services.stub.CurrencyConstantServiceStubSettings;
import com.google.api.core.BetaApi;
import com.google.api.gax.core.BackgroundResource;
import com.google.api.gax.rpc.UnaryCallable;
import java.io.IOException;
import java.util.concurrent.TimeUnit;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * Service Description: Service to fetch currency constants.
 *
 * <p>This class provides the ability to make remote calls to the backing service through method
 * calls that map to API methods. Sample code to get started:
 *
 * <pre>{@code
 * try (CurrencyConstantServiceClient currencyConstantServiceClient =
 *     CurrencyConstantServiceClient.create()) {
 *   CurrencyConstantName resourceName = CurrencyConstantName.of("[CURRENCY_CONSTANT]");
 *   CurrencyConstant response = currencyConstantServiceClient.getCurrencyConstant(resourceName);
 * }
 * }</pre>
 *
 * <p>Note: close() needs to be called on the CurrencyConstantServiceClient object to clean up
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
 * <p>This class can be customized by passing in a custom instance of
 * CurrencyConstantServiceSettings to create(). For example:
 *
 * <p>To customize credentials:
 *
 * <pre>{@code
 * CurrencyConstantServiceSettings currencyConstantServiceSettings =
 *     CurrencyConstantServiceSettings.newBuilder()
 *         .setCredentialsProvider(FixedCredentialsProvider.create(myCredentials))
 *         .build();
 * CurrencyConstantServiceClient currencyConstantServiceClient =
 *     CurrencyConstantServiceClient.create(currencyConstantServiceSettings);
 * }</pre>
 *
 * <p>To customize the endpoint:
 *
 * <pre>{@code
 * CurrencyConstantServiceSettings currencyConstantServiceSettings =
 *     CurrencyConstantServiceSettings.newBuilder().setEndpoint(myEndpoint).build();
 * CurrencyConstantServiceClient currencyConstantServiceClient =
 *     CurrencyConstantServiceClient.create(currencyConstantServiceSettings);
 * }</pre>
 *
 * <p>Please refer to the GitHub repository's samples for more quickstart code snippets.
 */
@Generated("by gapic-generator-java")
public class CurrencyConstantServiceClient implements BackgroundResource {
  private final CurrencyConstantServiceSettings settings;
  private final CurrencyConstantServiceStub stub;

  /** Constructs an instance of CurrencyConstantServiceClient with default settings. */
  public static final CurrencyConstantServiceClient create() throws IOException {
    return create(CurrencyConstantServiceSettings.newBuilder().build());
  }

  /**
   * Constructs an instance of CurrencyConstantServiceClient, using the given settings. The channels
   * are created based on the settings passed in, or defaults for any settings that are not set.
   */
  public static final CurrencyConstantServiceClient create(CurrencyConstantServiceSettings settings)
      throws IOException {
    return new CurrencyConstantServiceClient(settings);
  }

  /**
   * Constructs an instance of CurrencyConstantServiceClient, using the given stub for making calls.
   * This is for advanced usage - prefer using create(CurrencyConstantServiceSettings).
   */
  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public static final CurrencyConstantServiceClient create(CurrencyConstantServiceStub stub) {
    return new CurrencyConstantServiceClient(stub);
  }

  /**
   * Constructs an instance of CurrencyConstantServiceClient, using the given settings. This is
   * protected so that it is easy to make a subclass, but otherwise, the static factory methods
   * should be preferred.
   */
  protected CurrencyConstantServiceClient(CurrencyConstantServiceSettings settings)
      throws IOException {
    this.settings = settings;
    this.stub = ((CurrencyConstantServiceStubSettings) settings.getStubSettings()).createStub();
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  protected CurrencyConstantServiceClient(CurrencyConstantServiceStub stub) {
    this.settings = null;
    this.stub = stub;
  }

  public final CurrencyConstantServiceSettings getSettings() {
    return settings;
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public CurrencyConstantServiceStub getStub() {
    return stub;
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Returns the requested currency constant.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (CurrencyConstantServiceClient currencyConstantServiceClient =
   *     CurrencyConstantServiceClient.create()) {
   *   CurrencyConstantName resourceName = CurrencyConstantName.of("[CURRENCY_CONSTANT]");
   *   CurrencyConstant response = currencyConstantServiceClient.getCurrencyConstant(resourceName);
   * }
   * }</pre>
   *
   * @param resourceName Required. Resource name of the currency constant to fetch.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final CurrencyConstant getCurrencyConstant(CurrencyConstantName resourceName) {
    GetCurrencyConstantRequest request =
        GetCurrencyConstantRequest.newBuilder()
            .setResourceName(resourceName == null ? null : resourceName.toString())
            .build();
    return getCurrencyConstant(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Returns the requested currency constant.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (CurrencyConstantServiceClient currencyConstantServiceClient =
   *     CurrencyConstantServiceClient.create()) {
   *   String resourceName = CurrencyConstantName.of("[CURRENCY_CONSTANT]").toString();
   *   CurrencyConstant response = currencyConstantServiceClient.getCurrencyConstant(resourceName);
   * }
   * }</pre>
   *
   * @param resourceName Required. Resource name of the currency constant to fetch.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final CurrencyConstant getCurrencyConstant(String resourceName) {
    GetCurrencyConstantRequest request =
        GetCurrencyConstantRequest.newBuilder().setResourceName(resourceName).build();
    return getCurrencyConstant(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Returns the requested currency constant.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (CurrencyConstantServiceClient currencyConstantServiceClient =
   *     CurrencyConstantServiceClient.create()) {
   *   GetCurrencyConstantRequest request =
   *       GetCurrencyConstantRequest.newBuilder()
   *           .setResourceName(CurrencyConstantName.of("[CURRENCY_CONSTANT]").toString())
   *           .build();
   *   CurrencyConstant response = currencyConstantServiceClient.getCurrencyConstant(request);
   * }
   * }</pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final CurrencyConstant getCurrencyConstant(GetCurrencyConstantRequest request) {
    return getCurrencyConstantCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Returns the requested currency constant.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (CurrencyConstantServiceClient currencyConstantServiceClient =
   *     CurrencyConstantServiceClient.create()) {
   *   GetCurrencyConstantRequest request =
   *       GetCurrencyConstantRequest.newBuilder()
   *           .setResourceName(CurrencyConstantName.of("[CURRENCY_CONSTANT]").toString())
   *           .build();
   *   ApiFuture<CurrencyConstant> future =
   *       currencyConstantServiceClient.getCurrencyConstantCallable().futureCall(request);
   *   // Do something.
   *   CurrencyConstant response = future.get();
   * }
   * }</pre>
   */
  public final UnaryCallable<GetCurrencyConstantRequest, CurrencyConstant>
      getCurrencyConstantCallable() {
    return stub.getCurrencyConstantCallable();
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
