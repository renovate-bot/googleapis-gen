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

package com.google.cloud.networkservices.v1beta1;

import com.google.api.core.ApiFuture;
import com.google.api.core.ApiFutures;
import com.google.api.core.BetaApi;
import com.google.api.gax.core.BackgroundResource;
import com.google.api.gax.longrunning.OperationFuture;
import com.google.api.gax.paging.AbstractFixedSizeCollection;
import com.google.api.gax.paging.AbstractPage;
import com.google.api.gax.paging.AbstractPagedListResponse;
import com.google.api.gax.rpc.OperationCallable;
import com.google.api.gax.rpc.PageContext;
import com.google.api.gax.rpc.UnaryCallable;
import com.google.cloud.networkservices.v1beta1.stub.NetworkServicesStub;
import com.google.cloud.networkservices.v1beta1.stub.NetworkServicesStubSettings;
import com.google.common.util.concurrent.MoreExecutors;
import com.google.longrunning.Operation;
import com.google.longrunning.OperationsClient;
import com.google.protobuf.Empty;
import com.google.protobuf.FieldMask;
import java.io.IOException;
import java.util.List;
import java.util.concurrent.TimeUnit;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * This class provides the ability to make remote calls to the backing service through method calls
 * that map to API methods. Sample code to get started:
 *
 * <pre>{@code
 * try (NetworkServicesClient networkServicesClient = NetworkServicesClient.create()) {
 *   EndpointPolicyName name =
 *       EndpointPolicyName.of("[PROJECT]", "[LOCATION]", "[ENDPOINT_POLICY]");
 *   EndpointPolicy response = networkServicesClient.getEndpointPolicy(name);
 * }
 * }</pre>
 *
 * <p>Note: close() needs to be called on the NetworkServicesClient object to clean up resources
 * such as threads. In the example above, try-with-resources is used, which automatically calls
 * close().
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
 * <p>This class can be customized by passing in a custom instance of NetworkServicesSettings to
 * create(). For example:
 *
 * <p>To customize credentials:
 *
 * <pre>{@code
 * NetworkServicesSettings networkServicesSettings =
 *     NetworkServicesSettings.newBuilder()
 *         .setCredentialsProvider(FixedCredentialsProvider.create(myCredentials))
 *         .build();
 * NetworkServicesClient networkServicesClient =
 *     NetworkServicesClient.create(networkServicesSettings);
 * }</pre>
 *
 * <p>To customize the endpoint:
 *
 * <pre>{@code
 * NetworkServicesSettings networkServicesSettings =
 *     NetworkServicesSettings.newBuilder().setEndpoint(myEndpoint).build();
 * NetworkServicesClient networkServicesClient =
 *     NetworkServicesClient.create(networkServicesSettings);
 * }</pre>
 *
 * <p>Please refer to the GitHub repository's samples for more quickstart code snippets.
 */
@BetaApi
@Generated("by gapic-generator-java")
public class NetworkServicesClient implements BackgroundResource {
  private final NetworkServicesSettings settings;
  private final NetworkServicesStub stub;
  private final OperationsClient operationsClient;

  /** Constructs an instance of NetworkServicesClient with default settings. */
  public static final NetworkServicesClient create() throws IOException {
    return create(NetworkServicesSettings.newBuilder().build());
  }

  /**
   * Constructs an instance of NetworkServicesClient, using the given settings. The channels are
   * created based on the settings passed in, or defaults for any settings that are not set.
   */
  public static final NetworkServicesClient create(NetworkServicesSettings settings)
      throws IOException {
    return new NetworkServicesClient(settings);
  }

  /**
   * Constructs an instance of NetworkServicesClient, using the given stub for making calls. This is
   * for advanced usage - prefer using create(NetworkServicesSettings).
   */
  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public static final NetworkServicesClient create(NetworkServicesStub stub) {
    return new NetworkServicesClient(stub);
  }

  /**
   * Constructs an instance of NetworkServicesClient, using the given settings. This is protected so
   * that it is easy to make a subclass, but otherwise, the static factory methods should be
   * preferred.
   */
  protected NetworkServicesClient(NetworkServicesSettings settings) throws IOException {
    this.settings = settings;
    this.stub = ((NetworkServicesStubSettings) settings.getStubSettings()).createStub();
    this.operationsClient = OperationsClient.create(this.stub.getOperationsStub());
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  protected NetworkServicesClient(NetworkServicesStub stub) {
    this.settings = null;
    this.stub = stub;
    this.operationsClient = OperationsClient.create(this.stub.getOperationsStub());
  }

  public final NetworkServicesSettings getSettings() {
    return settings;
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public NetworkServicesStub getStub() {
    return stub;
  }

  /**
   * Returns the OperationsClient that can be used to query the status of a long-running operation
   * returned by another API method call.
   */
  public final OperationsClient getOperationsClient() {
    return operationsClient;
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists EndpointPolicies in a given project and location.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (NetworkServicesClient networkServicesClient = NetworkServicesClient.create()) {
   *   LocationName parent = LocationName.of("[PROJECT]", "[LOCATION]");
   *   for (EndpointPolicy element :
   *       networkServicesClient.listEndpointPolicies(parent).iterateAll()) {
   *     // doThingsWith(element);
   *   }
   * }
   * }</pre>
   *
   * @param parent Required. The project and location from which the EndpointPolicies should be
   *     listed, specified in the format `projects/&#42;/locations/global`.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ListEndpointPoliciesPagedResponse listEndpointPolicies(LocationName parent) {
    ListEndpointPoliciesRequest request =
        ListEndpointPoliciesRequest.newBuilder()
            .setParent(parent == null ? null : parent.toString())
            .build();
    return listEndpointPolicies(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists EndpointPolicies in a given project and location.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (NetworkServicesClient networkServicesClient = NetworkServicesClient.create()) {
   *   String parent = LocationName.of("[PROJECT]", "[LOCATION]").toString();
   *   for (EndpointPolicy element :
   *       networkServicesClient.listEndpointPolicies(parent).iterateAll()) {
   *     // doThingsWith(element);
   *   }
   * }
   * }</pre>
   *
   * @param parent Required. The project and location from which the EndpointPolicies should be
   *     listed, specified in the format `projects/&#42;/locations/global`.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ListEndpointPoliciesPagedResponse listEndpointPolicies(String parent) {
    ListEndpointPoliciesRequest request =
        ListEndpointPoliciesRequest.newBuilder().setParent(parent).build();
    return listEndpointPolicies(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists EndpointPolicies in a given project and location.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (NetworkServicesClient networkServicesClient = NetworkServicesClient.create()) {
   *   ListEndpointPoliciesRequest request =
   *       ListEndpointPoliciesRequest.newBuilder()
   *           .setParent(LocationName.of("[PROJECT]", "[LOCATION]").toString())
   *           .setPageSize(883849137)
   *           .setPageToken("pageToken873572522")
   *           .build();
   *   for (EndpointPolicy element :
   *       networkServicesClient.listEndpointPolicies(request).iterateAll()) {
   *     // doThingsWith(element);
   *   }
   * }
   * }</pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ListEndpointPoliciesPagedResponse listEndpointPolicies(
      ListEndpointPoliciesRequest request) {
    return listEndpointPoliciesPagedCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists EndpointPolicies in a given project and location.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (NetworkServicesClient networkServicesClient = NetworkServicesClient.create()) {
   *   ListEndpointPoliciesRequest request =
   *       ListEndpointPoliciesRequest.newBuilder()
   *           .setParent(LocationName.of("[PROJECT]", "[LOCATION]").toString())
   *           .setPageSize(883849137)
   *           .setPageToken("pageToken873572522")
   *           .build();
   *   ApiFuture<EndpointPolicy> future =
   *       networkServicesClient.listEndpointPoliciesPagedCallable().futureCall(request);
   *   // Do something.
   *   for (EndpointPolicy element : future.get().iterateAll()) {
   *     // doThingsWith(element);
   *   }
   * }
   * }</pre>
   */
  public final UnaryCallable<ListEndpointPoliciesRequest, ListEndpointPoliciesPagedResponse>
      listEndpointPoliciesPagedCallable() {
    return stub.listEndpointPoliciesPagedCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Lists EndpointPolicies in a given project and location.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (NetworkServicesClient networkServicesClient = NetworkServicesClient.create()) {
   *   ListEndpointPoliciesRequest request =
   *       ListEndpointPoliciesRequest.newBuilder()
   *           .setParent(LocationName.of("[PROJECT]", "[LOCATION]").toString())
   *           .setPageSize(883849137)
   *           .setPageToken("pageToken873572522")
   *           .build();
   *   while (true) {
   *     ListEndpointPoliciesResponse response =
   *         networkServicesClient.listEndpointPoliciesCallable().call(request);
   *     for (EndpointPolicy element : response.getResponsesList()) {
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
  public final UnaryCallable<ListEndpointPoliciesRequest, ListEndpointPoliciesResponse>
      listEndpointPoliciesCallable() {
    return stub.listEndpointPoliciesCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets details of a single EndpointPolicy.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (NetworkServicesClient networkServicesClient = NetworkServicesClient.create()) {
   *   EndpointPolicyName name =
   *       EndpointPolicyName.of("[PROJECT]", "[LOCATION]", "[ENDPOINT_POLICY]");
   *   EndpointPolicy response = networkServicesClient.getEndpointPolicy(name);
   * }
   * }</pre>
   *
   * @param name Required. A name of the EndpointPolicy to get. Must be in the format
   *     `projects/&#42;/locations/global/endpointPolicies/&#42;`.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final EndpointPolicy getEndpointPolicy(EndpointPolicyName name) {
    GetEndpointPolicyRequest request =
        GetEndpointPolicyRequest.newBuilder()
            .setName(name == null ? null : name.toString())
            .build();
    return getEndpointPolicy(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets details of a single EndpointPolicy.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (NetworkServicesClient networkServicesClient = NetworkServicesClient.create()) {
   *   String name =
   *       EndpointPolicyName.of("[PROJECT]", "[LOCATION]", "[ENDPOINT_POLICY]").toString();
   *   EndpointPolicy response = networkServicesClient.getEndpointPolicy(name);
   * }
   * }</pre>
   *
   * @param name Required. A name of the EndpointPolicy to get. Must be in the format
   *     `projects/&#42;/locations/global/endpointPolicies/&#42;`.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final EndpointPolicy getEndpointPolicy(String name) {
    GetEndpointPolicyRequest request = GetEndpointPolicyRequest.newBuilder().setName(name).build();
    return getEndpointPolicy(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets details of a single EndpointPolicy.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (NetworkServicesClient networkServicesClient = NetworkServicesClient.create()) {
   *   GetEndpointPolicyRequest request =
   *       GetEndpointPolicyRequest.newBuilder()
   *           .setName(
   *               EndpointPolicyName.of("[PROJECT]", "[LOCATION]", "[ENDPOINT_POLICY]").toString())
   *           .build();
   *   EndpointPolicy response = networkServicesClient.getEndpointPolicy(request);
   * }
   * }</pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final EndpointPolicy getEndpointPolicy(GetEndpointPolicyRequest request) {
    return getEndpointPolicyCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets details of a single EndpointPolicy.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (NetworkServicesClient networkServicesClient = NetworkServicesClient.create()) {
   *   GetEndpointPolicyRequest request =
   *       GetEndpointPolicyRequest.newBuilder()
   *           .setName(
   *               EndpointPolicyName.of("[PROJECT]", "[LOCATION]", "[ENDPOINT_POLICY]").toString())
   *           .build();
   *   ApiFuture<EndpointPolicy> future =
   *       networkServicesClient.getEndpointPolicyCallable().futureCall(request);
   *   // Do something.
   *   EndpointPolicy response = future.get();
   * }
   * }</pre>
   */
  public final UnaryCallable<GetEndpointPolicyRequest, EndpointPolicy> getEndpointPolicyCallable() {
    return stub.getEndpointPolicyCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a new EndpointPolicy in a given project and location.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (NetworkServicesClient networkServicesClient = NetworkServicesClient.create()) {
   *   LocationName parent = LocationName.of("[PROJECT]", "[LOCATION]");
   *   EndpointPolicy endpointPolicy = EndpointPolicy.newBuilder().build();
   *   String endpointPolicyId = "endpointPolicyId-509458782";
   *   EndpointPolicy response =
   *       networkServicesClient
   *           .createEndpointPolicyAsync(parent, endpointPolicy, endpointPolicyId)
   *           .get();
   * }
   * }</pre>
   *
   * @param parent Required. The parent resource of the EndpointPolicy. Must be in the format
   *     `projects/&#42;/locations/global`.
   * @param endpointPolicy Required. EndpointPolicy resource to be created.
   * @param endpointPolicyId Required. Short name of the EndpointPolicy resource to be created. E.g.
   *     "CustomECS".
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<EndpointPolicy, OperationMetadata> createEndpointPolicyAsync(
      LocationName parent, EndpointPolicy endpointPolicy, String endpointPolicyId) {
    CreateEndpointPolicyRequest request =
        CreateEndpointPolicyRequest.newBuilder()
            .setParent(parent == null ? null : parent.toString())
            .setEndpointPolicy(endpointPolicy)
            .setEndpointPolicyId(endpointPolicyId)
            .build();
    return createEndpointPolicyAsync(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a new EndpointPolicy in a given project and location.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (NetworkServicesClient networkServicesClient = NetworkServicesClient.create()) {
   *   String parent = LocationName.of("[PROJECT]", "[LOCATION]").toString();
   *   EndpointPolicy endpointPolicy = EndpointPolicy.newBuilder().build();
   *   String endpointPolicyId = "endpointPolicyId-509458782";
   *   EndpointPolicy response =
   *       networkServicesClient
   *           .createEndpointPolicyAsync(parent, endpointPolicy, endpointPolicyId)
   *           .get();
   * }
   * }</pre>
   *
   * @param parent Required. The parent resource of the EndpointPolicy. Must be in the format
   *     `projects/&#42;/locations/global`.
   * @param endpointPolicy Required. EndpointPolicy resource to be created.
   * @param endpointPolicyId Required. Short name of the EndpointPolicy resource to be created. E.g.
   *     "CustomECS".
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<EndpointPolicy, OperationMetadata> createEndpointPolicyAsync(
      String parent, EndpointPolicy endpointPolicy, String endpointPolicyId) {
    CreateEndpointPolicyRequest request =
        CreateEndpointPolicyRequest.newBuilder()
            .setParent(parent)
            .setEndpointPolicy(endpointPolicy)
            .setEndpointPolicyId(endpointPolicyId)
            .build();
    return createEndpointPolicyAsync(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a new EndpointPolicy in a given project and location.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (NetworkServicesClient networkServicesClient = NetworkServicesClient.create()) {
   *   CreateEndpointPolicyRequest request =
   *       CreateEndpointPolicyRequest.newBuilder()
   *           .setParent(LocationName.of("[PROJECT]", "[LOCATION]").toString())
   *           .setEndpointPolicyId("endpointPolicyId-509458782")
   *           .setEndpointPolicy(EndpointPolicy.newBuilder().build())
   *           .build();
   *   EndpointPolicy response = networkServicesClient.createEndpointPolicyAsync(request).get();
   * }
   * }</pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<EndpointPolicy, OperationMetadata> createEndpointPolicyAsync(
      CreateEndpointPolicyRequest request) {
    return createEndpointPolicyOperationCallable().futureCall(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a new EndpointPolicy in a given project and location.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (NetworkServicesClient networkServicesClient = NetworkServicesClient.create()) {
   *   CreateEndpointPolicyRequest request =
   *       CreateEndpointPolicyRequest.newBuilder()
   *           .setParent(LocationName.of("[PROJECT]", "[LOCATION]").toString())
   *           .setEndpointPolicyId("endpointPolicyId-509458782")
   *           .setEndpointPolicy(EndpointPolicy.newBuilder().build())
   *           .build();
   *   OperationFuture<EndpointPolicy, OperationMetadata> future =
   *       networkServicesClient.createEndpointPolicyOperationCallable().futureCall(request);
   *   // Do something.
   *   EndpointPolicy response = future.get();
   * }
   * }</pre>
   */
  public final OperationCallable<CreateEndpointPolicyRequest, EndpointPolicy, OperationMetadata>
      createEndpointPolicyOperationCallable() {
    return stub.createEndpointPolicyOperationCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a new EndpointPolicy in a given project and location.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (NetworkServicesClient networkServicesClient = NetworkServicesClient.create()) {
   *   CreateEndpointPolicyRequest request =
   *       CreateEndpointPolicyRequest.newBuilder()
   *           .setParent(LocationName.of("[PROJECT]", "[LOCATION]").toString())
   *           .setEndpointPolicyId("endpointPolicyId-509458782")
   *           .setEndpointPolicy(EndpointPolicy.newBuilder().build())
   *           .build();
   *   ApiFuture<Operation> future =
   *       networkServicesClient.createEndpointPolicyCallable().futureCall(request);
   *   // Do something.
   *   Operation response = future.get();
   * }
   * }</pre>
   */
  public final UnaryCallable<CreateEndpointPolicyRequest, Operation>
      createEndpointPolicyCallable() {
    return stub.createEndpointPolicyCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Updates the parameters of a single EndpointPolicy.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (NetworkServicesClient networkServicesClient = NetworkServicesClient.create()) {
   *   EndpointPolicy endpointPolicy = EndpointPolicy.newBuilder().build();
   *   FieldMask updateMask = FieldMask.newBuilder().build();
   *   EndpointPolicy response =
   *       networkServicesClient.updateEndpointPolicyAsync(endpointPolicy, updateMask).get();
   * }
   * }</pre>
   *
   * @param endpointPolicy Required. Updated EndpointPolicy resource.
   * @param updateMask Optional. Field mask is used to specify the fields to be overwritten in the
   *     EndpointPolicy resource by the update. The fields specified in the update_mask are relative
   *     to the resource, not the full request. A field will be overwritten if it is in the mask. If
   *     the user does not provide a mask then all fields will be overwritten.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<EndpointPolicy, OperationMetadata> updateEndpointPolicyAsync(
      EndpointPolicy endpointPolicy, FieldMask updateMask) {
    UpdateEndpointPolicyRequest request =
        UpdateEndpointPolicyRequest.newBuilder()
            .setEndpointPolicy(endpointPolicy)
            .setUpdateMask(updateMask)
            .build();
    return updateEndpointPolicyAsync(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Updates the parameters of a single EndpointPolicy.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (NetworkServicesClient networkServicesClient = NetworkServicesClient.create()) {
   *   UpdateEndpointPolicyRequest request =
   *       UpdateEndpointPolicyRequest.newBuilder()
   *           .setUpdateMask(FieldMask.newBuilder().build())
   *           .setEndpointPolicy(EndpointPolicy.newBuilder().build())
   *           .build();
   *   EndpointPolicy response = networkServicesClient.updateEndpointPolicyAsync(request).get();
   * }
   * }</pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<EndpointPolicy, OperationMetadata> updateEndpointPolicyAsync(
      UpdateEndpointPolicyRequest request) {
    return updateEndpointPolicyOperationCallable().futureCall(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Updates the parameters of a single EndpointPolicy.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (NetworkServicesClient networkServicesClient = NetworkServicesClient.create()) {
   *   UpdateEndpointPolicyRequest request =
   *       UpdateEndpointPolicyRequest.newBuilder()
   *           .setUpdateMask(FieldMask.newBuilder().build())
   *           .setEndpointPolicy(EndpointPolicy.newBuilder().build())
   *           .build();
   *   OperationFuture<EndpointPolicy, OperationMetadata> future =
   *       networkServicesClient.updateEndpointPolicyOperationCallable().futureCall(request);
   *   // Do something.
   *   EndpointPolicy response = future.get();
   * }
   * }</pre>
   */
  public final OperationCallable<UpdateEndpointPolicyRequest, EndpointPolicy, OperationMetadata>
      updateEndpointPolicyOperationCallable() {
    return stub.updateEndpointPolicyOperationCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Updates the parameters of a single EndpointPolicy.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (NetworkServicesClient networkServicesClient = NetworkServicesClient.create()) {
   *   UpdateEndpointPolicyRequest request =
   *       UpdateEndpointPolicyRequest.newBuilder()
   *           .setUpdateMask(FieldMask.newBuilder().build())
   *           .setEndpointPolicy(EndpointPolicy.newBuilder().build())
   *           .build();
   *   ApiFuture<Operation> future =
   *       networkServicesClient.updateEndpointPolicyCallable().futureCall(request);
   *   // Do something.
   *   Operation response = future.get();
   * }
   * }</pre>
   */
  public final UnaryCallable<UpdateEndpointPolicyRequest, Operation>
      updateEndpointPolicyCallable() {
    return stub.updateEndpointPolicyCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Deletes a single EndpointPolicy.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (NetworkServicesClient networkServicesClient = NetworkServicesClient.create()) {
   *   EndpointPolicyName name =
   *       EndpointPolicyName.of("[PROJECT]", "[LOCATION]", "[ENDPOINT_POLICY]");
   *   networkServicesClient.deleteEndpointPolicyAsync(name).get();
   * }
   * }</pre>
   *
   * @param name Required. A name of the EndpointPolicy to delete. Must be in the format
   *     `projects/&#42;/locations/global/endpointPolicies/&#42;`.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<Empty, OperationMetadata> deleteEndpointPolicyAsync(
      EndpointPolicyName name) {
    DeleteEndpointPolicyRequest request =
        DeleteEndpointPolicyRequest.newBuilder()
            .setName(name == null ? null : name.toString())
            .build();
    return deleteEndpointPolicyAsync(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Deletes a single EndpointPolicy.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (NetworkServicesClient networkServicesClient = NetworkServicesClient.create()) {
   *   String name =
   *       EndpointPolicyName.of("[PROJECT]", "[LOCATION]", "[ENDPOINT_POLICY]").toString();
   *   networkServicesClient.deleteEndpointPolicyAsync(name).get();
   * }
   * }</pre>
   *
   * @param name Required. A name of the EndpointPolicy to delete. Must be in the format
   *     `projects/&#42;/locations/global/endpointPolicies/&#42;`.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<Empty, OperationMetadata> deleteEndpointPolicyAsync(String name) {
    DeleteEndpointPolicyRequest request =
        DeleteEndpointPolicyRequest.newBuilder().setName(name).build();
    return deleteEndpointPolicyAsync(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Deletes a single EndpointPolicy.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (NetworkServicesClient networkServicesClient = NetworkServicesClient.create()) {
   *   DeleteEndpointPolicyRequest request =
   *       DeleteEndpointPolicyRequest.newBuilder()
   *           .setName(
   *               EndpointPolicyName.of("[PROJECT]", "[LOCATION]", "[ENDPOINT_POLICY]").toString())
   *           .build();
   *   networkServicesClient.deleteEndpointPolicyAsync(request).get();
   * }
   * }</pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final OperationFuture<Empty, OperationMetadata> deleteEndpointPolicyAsync(
      DeleteEndpointPolicyRequest request) {
    return deleteEndpointPolicyOperationCallable().futureCall(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Deletes a single EndpointPolicy.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (NetworkServicesClient networkServicesClient = NetworkServicesClient.create()) {
   *   DeleteEndpointPolicyRequest request =
   *       DeleteEndpointPolicyRequest.newBuilder()
   *           .setName(
   *               EndpointPolicyName.of("[PROJECT]", "[LOCATION]", "[ENDPOINT_POLICY]").toString())
   *           .build();
   *   OperationFuture<Empty, OperationMetadata> future =
   *       networkServicesClient.deleteEndpointPolicyOperationCallable().futureCall(request);
   *   // Do something.
   *   future.get();
   * }
   * }</pre>
   */
  public final OperationCallable<DeleteEndpointPolicyRequest, Empty, OperationMetadata>
      deleteEndpointPolicyOperationCallable() {
    return stub.deleteEndpointPolicyOperationCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Deletes a single EndpointPolicy.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (NetworkServicesClient networkServicesClient = NetworkServicesClient.create()) {
   *   DeleteEndpointPolicyRequest request =
   *       DeleteEndpointPolicyRequest.newBuilder()
   *           .setName(
   *               EndpointPolicyName.of("[PROJECT]", "[LOCATION]", "[ENDPOINT_POLICY]").toString())
   *           .build();
   *   ApiFuture<Operation> future =
   *       networkServicesClient.deleteEndpointPolicyCallable().futureCall(request);
   *   // Do something.
   *   future.get();
   * }
   * }</pre>
   */
  public final UnaryCallable<DeleteEndpointPolicyRequest, Operation>
      deleteEndpointPolicyCallable() {
    return stub.deleteEndpointPolicyCallable();
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

  public static class ListEndpointPoliciesPagedResponse
      extends AbstractPagedListResponse<
          ListEndpointPoliciesRequest, ListEndpointPoliciesResponse, EndpointPolicy,
          ListEndpointPoliciesPage, ListEndpointPoliciesFixedSizeCollection> {

    public static ApiFuture<ListEndpointPoliciesPagedResponse> createAsync(
        PageContext<ListEndpointPoliciesRequest, ListEndpointPoliciesResponse, EndpointPolicy>
            context,
        ApiFuture<ListEndpointPoliciesResponse> futureResponse) {
      ApiFuture<ListEndpointPoliciesPage> futurePage =
          ListEndpointPoliciesPage.createEmptyPage().createPageAsync(context, futureResponse);
      return ApiFutures.transform(
          futurePage,
          input -> new ListEndpointPoliciesPagedResponse(input),
          MoreExecutors.directExecutor());
    }

    private ListEndpointPoliciesPagedResponse(ListEndpointPoliciesPage page) {
      super(page, ListEndpointPoliciesFixedSizeCollection.createEmptyCollection());
    }
  }

  public static class ListEndpointPoliciesPage
      extends AbstractPage<
          ListEndpointPoliciesRequest, ListEndpointPoliciesResponse, EndpointPolicy,
          ListEndpointPoliciesPage> {

    private ListEndpointPoliciesPage(
        PageContext<ListEndpointPoliciesRequest, ListEndpointPoliciesResponse, EndpointPolicy>
            context,
        ListEndpointPoliciesResponse response) {
      super(context, response);
    }

    private static ListEndpointPoliciesPage createEmptyPage() {
      return new ListEndpointPoliciesPage(null, null);
    }

    @Override
    protected ListEndpointPoliciesPage createPage(
        PageContext<ListEndpointPoliciesRequest, ListEndpointPoliciesResponse, EndpointPolicy>
            context,
        ListEndpointPoliciesResponse response) {
      return new ListEndpointPoliciesPage(context, response);
    }

    @Override
    public ApiFuture<ListEndpointPoliciesPage> createPageAsync(
        PageContext<ListEndpointPoliciesRequest, ListEndpointPoliciesResponse, EndpointPolicy>
            context,
        ApiFuture<ListEndpointPoliciesResponse> futureResponse) {
      return super.createPageAsync(context, futureResponse);
    }
  }

  public static class ListEndpointPoliciesFixedSizeCollection
      extends AbstractFixedSizeCollection<
          ListEndpointPoliciesRequest, ListEndpointPoliciesResponse, EndpointPolicy,
          ListEndpointPoliciesPage, ListEndpointPoliciesFixedSizeCollection> {

    private ListEndpointPoliciesFixedSizeCollection(
        List<ListEndpointPoliciesPage> pages, int collectionSize) {
      super(pages, collectionSize);
    }

    private static ListEndpointPoliciesFixedSizeCollection createEmptyCollection() {
      return new ListEndpointPoliciesFixedSizeCollection(null, 0);
    }

    @Override
    protected ListEndpointPoliciesFixedSizeCollection createCollection(
        List<ListEndpointPoliciesPage> pages, int collectionSize) {
      return new ListEndpointPoliciesFixedSizeCollection(pages, collectionSize);
    }
  }
}
