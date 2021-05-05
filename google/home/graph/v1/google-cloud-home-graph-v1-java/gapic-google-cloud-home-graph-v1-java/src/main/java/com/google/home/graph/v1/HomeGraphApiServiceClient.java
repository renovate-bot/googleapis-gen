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

package com.google.home.graph.v1;

import com.google.api.core.BetaApi;
import com.google.api.gax.core.BackgroundResource;
import com.google.api.gax.rpc.UnaryCallable;
import com.google.home.graph.v1.stub.HomeGraphApiServiceStub;
import com.google.home.graph.v1.stub.HomeGraphApiServiceStubSettings;
import com.google.protobuf.Empty;
import java.io.IOException;
import java.util.List;
import java.util.concurrent.TimeUnit;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * Service Description: Google Home Graph API service. The Home Graph service provides support for
 * accessing first-party and third-party devices stored in Google's Home Graph. The Home Graph
 * database provides contextual data about the relationships between devices and the home.
 *
 * <p>For more details, see the [Home Graph developer
 * guide](https://developers.google.com/assistant/smarthome/concepts/homegraph).
 *
 * <p>This class provides the ability to make remote calls to the backing service through method
 * calls that map to API methods. Sample code to get started:
 *
 * <pre>{@code
 * try (HomeGraphApiServiceClient homeGraphApiServiceClient = HomeGraphApiServiceClient.create()) {
 *   String agentUserId = "agentUserId1708672427";
 *   HomeGraphApiServiceProto.RequestSyncDevicesResponse response =
 *       homeGraphApiServiceClient.requestSyncDevices(agentUserId);
 * }
 * }</pre>
 *
 * <p>Note: close() needs to be called on the HomeGraphApiServiceClient object to clean up resources
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
 * <p>This class can be customized by passing in a custom instance of HomeGraphApiServiceSettings to
 * create(). For example:
 *
 * <p>To customize credentials:
 *
 * <pre>{@code
 * HomeGraphApiServiceSettings homeGraphApiServiceSettings =
 *     HomeGraphApiServiceSettings.newBuilder()
 *         .setCredentialsProvider(FixedCredentialsProvider.create(myCredentials))
 *         .build();
 * HomeGraphApiServiceClient homeGraphApiServiceClient =
 *     HomeGraphApiServiceClient.create(homeGraphApiServiceSettings);
 * }</pre>
 *
 * <p>To customize the endpoint:
 *
 * <pre>{@code
 * HomeGraphApiServiceSettings homeGraphApiServiceSettings =
 *     HomeGraphApiServiceSettings.newBuilder().setEndpoint(myEndpoint).build();
 * HomeGraphApiServiceClient homeGraphApiServiceClient =
 *     HomeGraphApiServiceClient.create(homeGraphApiServiceSettings);
 * }</pre>
 *
 * <p>Please refer to the GitHub repository's samples for more quickstart code snippets.
 */
@Generated("by gapic-generator-java")
public class HomeGraphApiServiceClient implements BackgroundResource {
  private final HomeGraphApiServiceSettings settings;
  private final HomeGraphApiServiceStub stub;

  /** Constructs an instance of HomeGraphApiServiceClient with default settings. */
  public static final HomeGraphApiServiceClient create() throws IOException {
    return create(HomeGraphApiServiceSettings.newBuilder().build());
  }

  /**
   * Constructs an instance of HomeGraphApiServiceClient, using the given settings. The channels are
   * created based on the settings passed in, or defaults for any settings that are not set.
   */
  public static final HomeGraphApiServiceClient create(HomeGraphApiServiceSettings settings)
      throws IOException {
    return new HomeGraphApiServiceClient(settings);
  }

  /**
   * Constructs an instance of HomeGraphApiServiceClient, using the given stub for making calls.
   * This is for advanced usage - prefer using create(HomeGraphApiServiceSettings).
   */
  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public static final HomeGraphApiServiceClient create(HomeGraphApiServiceStub stub) {
    return new HomeGraphApiServiceClient(stub);
  }

  /**
   * Constructs an instance of HomeGraphApiServiceClient, using the given settings. This is
   * protected so that it is easy to make a subclass, but otherwise, the static factory methods
   * should be preferred.
   */
  protected HomeGraphApiServiceClient(HomeGraphApiServiceSettings settings) throws IOException {
    this.settings = settings;
    this.stub = ((HomeGraphApiServiceStubSettings) settings.getStubSettings()).createStub();
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  protected HomeGraphApiServiceClient(HomeGraphApiServiceStub stub) {
    this.settings = null;
    this.stub = stub;
  }

  public final HomeGraphApiServiceSettings getSettings() {
    return settings;
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public HomeGraphApiServiceStub getStub() {
    return stub;
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Requests Google to send an `action.devices.SYNC`
   * [intent](https://developers.google.com/assistant/smarthome/reference/intent/sync) to your smart
   * home Action to update device metadata for the given user.
   *
   * <p>The third-party user's identity is passed via the `agent_user_id` (see
   * [RequestSyncDevicesRequest][google.home.graph.v1.RequestSyncDevicesRequest]). This request must
   * be authorized using service account credentials from your Actions console project.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (HomeGraphApiServiceClient homeGraphApiServiceClient = HomeGraphApiServiceClient.create()) {
   *   String agentUserId = "agentUserId1708672427";
   *   HomeGraphApiServiceProto.RequestSyncDevicesResponse response =
   *       homeGraphApiServiceClient.requestSyncDevices(agentUserId);
   * }
   * }</pre>
   *
   * @param agentUserId Required. Third-party user ID.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final HomeGraphApiServiceProto.RequestSyncDevicesResponse requestSyncDevices(
      String agentUserId) {
    HomeGraphApiServiceProto.RequestSyncDevicesRequest request =
        HomeGraphApiServiceProto.RequestSyncDevicesRequest.newBuilder()
            .setAgentUserId(agentUserId)
            .build();
    return requestSyncDevices(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Requests Google to send an `action.devices.SYNC`
   * [intent](https://developers.google.com/assistant/smarthome/reference/intent/sync) to your smart
   * home Action to update device metadata for the given user.
   *
   * <p>The third-party user's identity is passed via the `agent_user_id` (see
   * [RequestSyncDevicesRequest][google.home.graph.v1.RequestSyncDevicesRequest]). This request must
   * be authorized using service account credentials from your Actions console project.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (HomeGraphApiServiceClient homeGraphApiServiceClient = HomeGraphApiServiceClient.create()) {
   *   HomeGraphApiServiceProto.RequestSyncDevicesRequest request =
   *       HomeGraphApiServiceProto.RequestSyncDevicesRequest.newBuilder()
   *           .setAgentUserId("agentUserId1708672427")
   *           .setAsync(true)
   *           .build();
   *   HomeGraphApiServiceProto.RequestSyncDevicesResponse response =
   *       homeGraphApiServiceClient.requestSyncDevices(request);
   * }
   * }</pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final HomeGraphApiServiceProto.RequestSyncDevicesResponse requestSyncDevices(
      HomeGraphApiServiceProto.RequestSyncDevicesRequest request) {
    return requestSyncDevicesCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Requests Google to send an `action.devices.SYNC`
   * [intent](https://developers.google.com/assistant/smarthome/reference/intent/sync) to your smart
   * home Action to update device metadata for the given user.
   *
   * <p>The third-party user's identity is passed via the `agent_user_id` (see
   * [RequestSyncDevicesRequest][google.home.graph.v1.RequestSyncDevicesRequest]). This request must
   * be authorized using service account credentials from your Actions console project.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (HomeGraphApiServiceClient homeGraphApiServiceClient = HomeGraphApiServiceClient.create()) {
   *   HomeGraphApiServiceProto.RequestSyncDevicesRequest request =
   *       HomeGraphApiServiceProto.RequestSyncDevicesRequest.newBuilder()
   *           .setAgentUserId("agentUserId1708672427")
   *           .setAsync(true)
   *           .build();
   *   ApiFuture<HomeGraphApiServiceProto.RequestSyncDevicesResponse> future =
   *       homeGraphApiServiceClient.requestSyncDevicesCallable().futureCall(request);
   *   // Do something.
   *   HomeGraphApiServiceProto.RequestSyncDevicesResponse response = future.get();
   * }
   * }</pre>
   */
  public final UnaryCallable<
          HomeGraphApiServiceProto.RequestSyncDevicesRequest,
          HomeGraphApiServiceProto.RequestSyncDevicesResponse>
      requestSyncDevicesCallable() {
    return stub.requestSyncDevicesCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Reports device state and optionally sends device notifications. Called by your smart home
   * Action when the state of a third-party device changes or you need to send a notification about
   * the device. See [Implement Report
   * State](https://developers.google.com/assistant/smarthome/develop/report-state) for more
   * information.
   *
   * <p>This method updates the device state according to its declared
   * [traits](https://developers.google.com/assistant/smarthome/concepts/devices-traits). Publishing
   * a new state value outside of these traits will result in an `INVALID_ARGUMENT` error response.
   *
   * <p>The third-party user's identity is passed in via the `agent_user_id` (see
   * [ReportStateAndNotificationRequest][google.home.graph.v1.ReportStateAndNotificationRequest]).
   * This request must be authorized using service account credentials from your Actions console
   * project.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (HomeGraphApiServiceClient homeGraphApiServiceClient = HomeGraphApiServiceClient.create()) {
   *   String requestId = "requestId693933066";
   *   String eventId = "eventId-1376502443";
   *   String agentUserId = "agentUserId1708672427";
   *   HomeGraphApiServiceProto.StateAndNotificationPayload payload =
   *       HomeGraphApiServiceProto.StateAndNotificationPayload.newBuilder().build();
   *   HomeGraphApiServiceProto.ReportStateAndNotificationResponse response =
   *       homeGraphApiServiceClient.reportStateAndNotification(
   *           requestId, eventId, agentUserId, payload);
   * }
   * }</pre>
   *
   * @param requestId Request ID used for debugging.
   * @param eventId Unique identifier per event (for example, a doorbell press).
   * @param agentUserId Required. Third-party user ID.
   * @param payload Required. State of devices to update and notification metadata for devices.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final HomeGraphApiServiceProto.ReportStateAndNotificationResponse
      reportStateAndNotification(
          String requestId,
          String eventId,
          String agentUserId,
          HomeGraphApiServiceProto.StateAndNotificationPayload payload) {
    HomeGraphApiServiceProto.ReportStateAndNotificationRequest request =
        HomeGraphApiServiceProto.ReportStateAndNotificationRequest.newBuilder()
            .setRequestId(requestId)
            .setEventId(eventId)
            .setAgentUserId(agentUserId)
            .setPayload(payload)
            .build();
    return reportStateAndNotification(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Reports device state and optionally sends device notifications. Called by your smart home
   * Action when the state of a third-party device changes or you need to send a notification about
   * the device. See [Implement Report
   * State](https://developers.google.com/assistant/smarthome/develop/report-state) for more
   * information.
   *
   * <p>This method updates the device state according to its declared
   * [traits](https://developers.google.com/assistant/smarthome/concepts/devices-traits). Publishing
   * a new state value outside of these traits will result in an `INVALID_ARGUMENT` error response.
   *
   * <p>The third-party user's identity is passed in via the `agent_user_id` (see
   * [ReportStateAndNotificationRequest][google.home.graph.v1.ReportStateAndNotificationRequest]).
   * This request must be authorized using service account credentials from your Actions console
   * project.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (HomeGraphApiServiceClient homeGraphApiServiceClient = HomeGraphApiServiceClient.create()) {
   *   HomeGraphApiServiceProto.ReportStateAndNotificationRequest request =
   *       HomeGraphApiServiceProto.ReportStateAndNotificationRequest.newBuilder()
   *           .setRequestId("requestId693933066")
   *           .setEventId("eventId-1376502443")
   *           .setAgentUserId("agentUserId1708672427")
   *           .setFollowUpToken("followUpToken628008749")
   *           .build();
   *   HomeGraphApiServiceProto.ReportStateAndNotificationResponse response =
   *       homeGraphApiServiceClient.reportStateAndNotification(request);
   * }
   * }</pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final HomeGraphApiServiceProto.ReportStateAndNotificationResponse
      reportStateAndNotification(
          HomeGraphApiServiceProto.ReportStateAndNotificationRequest request) {
    return reportStateAndNotificationCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Reports device state and optionally sends device notifications. Called by your smart home
   * Action when the state of a third-party device changes or you need to send a notification about
   * the device. See [Implement Report
   * State](https://developers.google.com/assistant/smarthome/develop/report-state) for more
   * information.
   *
   * <p>This method updates the device state according to its declared
   * [traits](https://developers.google.com/assistant/smarthome/concepts/devices-traits). Publishing
   * a new state value outside of these traits will result in an `INVALID_ARGUMENT` error response.
   *
   * <p>The third-party user's identity is passed in via the `agent_user_id` (see
   * [ReportStateAndNotificationRequest][google.home.graph.v1.ReportStateAndNotificationRequest]).
   * This request must be authorized using service account credentials from your Actions console
   * project.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (HomeGraphApiServiceClient homeGraphApiServiceClient = HomeGraphApiServiceClient.create()) {
   *   HomeGraphApiServiceProto.ReportStateAndNotificationRequest request =
   *       HomeGraphApiServiceProto.ReportStateAndNotificationRequest.newBuilder()
   *           .setRequestId("requestId693933066")
   *           .setEventId("eventId-1376502443")
   *           .setAgentUserId("agentUserId1708672427")
   *           .setFollowUpToken("followUpToken628008749")
   *           .build();
   *   ApiFuture<HomeGraphApiServiceProto.ReportStateAndNotificationResponse> future =
   *       homeGraphApiServiceClient.reportStateAndNotificationCallable().futureCall(request);
   *   // Do something.
   *   HomeGraphApiServiceProto.ReportStateAndNotificationResponse response = future.get();
   * }
   * }</pre>
   */
  public final UnaryCallable<
          HomeGraphApiServiceProto.ReportStateAndNotificationRequest,
          HomeGraphApiServiceProto.ReportStateAndNotificationResponse>
      reportStateAndNotificationCallable() {
    return stub.reportStateAndNotificationCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Unlinks the given third-party user from your smart home Action. All data related to this user
   * will be deleted.
   *
   * <p>For more details on how users link their accounts, see [fulfillment and
   * authentication](https://developers.google.com/assistant/smarthome/concepts/fulfillment-authentication).
   *
   * <p>The third-party user's identity is passed in via the `agent_user_id` (see
   * [DeleteAgentUserRequest][google.home.graph.v1.DeleteAgentUserRequest]). This request must be
   * authorized using service account credentials from your Actions console project.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (HomeGraphApiServiceClient homeGraphApiServiceClient = HomeGraphApiServiceClient.create()) {
   *   String requestId = "requestId693933066";
   *   AgentUserPathName agentUserId = AgentUserPathName.of("[AGENT_USER_PATH]");
   *   homeGraphApiServiceClient.deleteAgentUser(requestId, agentUserId);
   * }
   * }</pre>
   *
   * @param requestId Request ID used for debugging.
   * @param agentUserId Required. Third-party user ID.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final void deleteAgentUser(String requestId, AgentUserPathName agentUserId) {
    HomeGraphApiServiceProto.DeleteAgentUserRequest request =
        HomeGraphApiServiceProto.DeleteAgentUserRequest.newBuilder()
            .setRequestId(requestId)
            .setAgentUserId(agentUserId == null ? null : agentUserId.toString())
            .build();
    deleteAgentUser(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Unlinks the given third-party user from your smart home Action. All data related to this user
   * will be deleted.
   *
   * <p>For more details on how users link their accounts, see [fulfillment and
   * authentication](https://developers.google.com/assistant/smarthome/concepts/fulfillment-authentication).
   *
   * <p>The third-party user's identity is passed in via the `agent_user_id` (see
   * [DeleteAgentUserRequest][google.home.graph.v1.DeleteAgentUserRequest]). This request must be
   * authorized using service account credentials from your Actions console project.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (HomeGraphApiServiceClient homeGraphApiServiceClient = HomeGraphApiServiceClient.create()) {
   *   String requestId = "requestId693933066";
   *   String agentUserId = AgentUserPathName.of("[AGENT_USER_PATH]").toString();
   *   homeGraphApiServiceClient.deleteAgentUser(requestId, agentUserId);
   * }
   * }</pre>
   *
   * @param requestId Request ID used for debugging.
   * @param agentUserId Required. Third-party user ID.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final void deleteAgentUser(String requestId, String agentUserId) {
    HomeGraphApiServiceProto.DeleteAgentUserRequest request =
        HomeGraphApiServiceProto.DeleteAgentUserRequest.newBuilder()
            .setRequestId(requestId)
            .setAgentUserId(agentUserId)
            .build();
    deleteAgentUser(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Unlinks the given third-party user from your smart home Action. All data related to this user
   * will be deleted.
   *
   * <p>For more details on how users link their accounts, see [fulfillment and
   * authentication](https://developers.google.com/assistant/smarthome/concepts/fulfillment-authentication).
   *
   * <p>The third-party user's identity is passed in via the `agent_user_id` (see
   * [DeleteAgentUserRequest][google.home.graph.v1.DeleteAgentUserRequest]). This request must be
   * authorized using service account credentials from your Actions console project.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (HomeGraphApiServiceClient homeGraphApiServiceClient = HomeGraphApiServiceClient.create()) {
   *   HomeGraphApiServiceProto.DeleteAgentUserRequest request =
   *       HomeGraphApiServiceProto.DeleteAgentUserRequest.newBuilder()
   *           .setRequestId("requestId693933066")
   *           .setAgentUserId(AgentUserPathName.of("[AGENT_USER_PATH]").toString())
   *           .build();
   *   homeGraphApiServiceClient.deleteAgentUser(request);
   * }
   * }</pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final void deleteAgentUser(HomeGraphApiServiceProto.DeleteAgentUserRequest request) {
    deleteAgentUserCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Unlinks the given third-party user from your smart home Action. All data related to this user
   * will be deleted.
   *
   * <p>For more details on how users link their accounts, see [fulfillment and
   * authentication](https://developers.google.com/assistant/smarthome/concepts/fulfillment-authentication).
   *
   * <p>The third-party user's identity is passed in via the `agent_user_id` (see
   * [DeleteAgentUserRequest][google.home.graph.v1.DeleteAgentUserRequest]). This request must be
   * authorized using service account credentials from your Actions console project.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (HomeGraphApiServiceClient homeGraphApiServiceClient = HomeGraphApiServiceClient.create()) {
   *   HomeGraphApiServiceProto.DeleteAgentUserRequest request =
   *       HomeGraphApiServiceProto.DeleteAgentUserRequest.newBuilder()
   *           .setRequestId("requestId693933066")
   *           .setAgentUserId(AgentUserPathName.of("[AGENT_USER_PATH]").toString())
   *           .build();
   *   ApiFuture<Empty> future =
   *       homeGraphApiServiceClient.deleteAgentUserCallable().futureCall(request);
   *   // Do something.
   *   future.get();
   * }
   * }</pre>
   */
  public final UnaryCallable<HomeGraphApiServiceProto.DeleteAgentUserRequest, Empty>
      deleteAgentUserCallable() {
    return stub.deleteAgentUserCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets the current states in Home Graph for the given set of the third-party user's devices.
   *
   * <p>The third-party user's identity is passed in via the `agent_user_id` (see
   * [QueryRequest][google.home.graph.v1.QueryRequest]). This request must be authorized using
   * service account credentials from your Actions console project.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (HomeGraphApiServiceClient homeGraphApiServiceClient = HomeGraphApiServiceClient.create()) {
   *   String requestId = "requestId693933066";
   *   String agentUserId = "agentUserId1708672427";
   *   List<HomeGraphApiServiceProto.QueryRequestInput> inputs = new ArrayList<>();
   *   HomeGraphApiServiceProto.QueryResponse response =
   *       homeGraphApiServiceClient.query(requestId, agentUserId, inputs);
   * }
   * }</pre>
   *
   * @param requestId Request ID used for debugging.
   * @param agentUserId Required. Third-party user ID.
   * @param inputs Required. Inputs containing third-party device IDs for which to get the device
   *     states.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final HomeGraphApiServiceProto.QueryResponse query(
      String requestId,
      String agentUserId,
      List<HomeGraphApiServiceProto.QueryRequestInput> inputs) {
    HomeGraphApiServiceProto.QueryRequest request =
        HomeGraphApiServiceProto.QueryRequest.newBuilder()
            .setRequestId(requestId)
            .setAgentUserId(agentUserId)
            .addAllInputs(inputs)
            .build();
    return query(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets the current states in Home Graph for the given set of the third-party user's devices.
   *
   * <p>The third-party user's identity is passed in via the `agent_user_id` (see
   * [QueryRequest][google.home.graph.v1.QueryRequest]). This request must be authorized using
   * service account credentials from your Actions console project.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (HomeGraphApiServiceClient homeGraphApiServiceClient = HomeGraphApiServiceClient.create()) {
   *   HomeGraphApiServiceProto.QueryRequest request =
   *       HomeGraphApiServiceProto.QueryRequest.newBuilder()
   *           .setRequestId("requestId693933066")
   *           .setAgentUserId("agentUserId1708672427")
   *           .addAllInputs(new ArrayList<HomeGraphApiServiceProto.QueryRequestInput>())
   *           .build();
   *   HomeGraphApiServiceProto.QueryResponse response = homeGraphApiServiceClient.query(request);
   * }
   * }</pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final HomeGraphApiServiceProto.QueryResponse query(
      HomeGraphApiServiceProto.QueryRequest request) {
    return queryCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets the current states in Home Graph for the given set of the third-party user's devices.
   *
   * <p>The third-party user's identity is passed in via the `agent_user_id` (see
   * [QueryRequest][google.home.graph.v1.QueryRequest]). This request must be authorized using
   * service account credentials from your Actions console project.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (HomeGraphApiServiceClient homeGraphApiServiceClient = HomeGraphApiServiceClient.create()) {
   *   HomeGraphApiServiceProto.QueryRequest request =
   *       HomeGraphApiServiceProto.QueryRequest.newBuilder()
   *           .setRequestId("requestId693933066")
   *           .setAgentUserId("agentUserId1708672427")
   *           .addAllInputs(new ArrayList<HomeGraphApiServiceProto.QueryRequestInput>())
   *           .build();
   *   ApiFuture<HomeGraphApiServiceProto.QueryResponse> future =
   *       homeGraphApiServiceClient.queryCallable().futureCall(request);
   *   // Do something.
   *   HomeGraphApiServiceProto.QueryResponse response = future.get();
   * }
   * }</pre>
   */
  public final UnaryCallable<
          HomeGraphApiServiceProto.QueryRequest, HomeGraphApiServiceProto.QueryResponse>
      queryCallable() {
    return stub.queryCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets all the devices associated with the given third-party user.
   *
   * <p>The third-party user's identity is passed in via the `agent_user_id` (see
   * [SyncRequest][google.home.graph.v1.SyncRequest]). This request must be authorized using service
   * account credentials from your Actions console project.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (HomeGraphApiServiceClient homeGraphApiServiceClient = HomeGraphApiServiceClient.create()) {
   *   String requestId = "requestId693933066";
   *   String agentUserId = "agentUserId1708672427";
   *   HomeGraphApiServiceProto.SyncResponse response =
   *       homeGraphApiServiceClient.sync(requestId, agentUserId);
   * }
   * }</pre>
   *
   * @param requestId Request ID used for debugging.
   * @param agentUserId Required. Third-party user ID.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final HomeGraphApiServiceProto.SyncResponse sync(String requestId, String agentUserId) {
    HomeGraphApiServiceProto.SyncRequest request =
        HomeGraphApiServiceProto.SyncRequest.newBuilder()
            .setRequestId(requestId)
            .setAgentUserId(agentUserId)
            .build();
    return sync(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets all the devices associated with the given third-party user.
   *
   * <p>The third-party user's identity is passed in via the `agent_user_id` (see
   * [SyncRequest][google.home.graph.v1.SyncRequest]). This request must be authorized using service
   * account credentials from your Actions console project.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (HomeGraphApiServiceClient homeGraphApiServiceClient = HomeGraphApiServiceClient.create()) {
   *   HomeGraphApiServiceProto.SyncRequest request =
   *       HomeGraphApiServiceProto.SyncRequest.newBuilder()
   *           .setRequestId("requestId693933066")
   *           .setAgentUserId("agentUserId1708672427")
   *           .build();
   *   HomeGraphApiServiceProto.SyncResponse response = homeGraphApiServiceClient.sync(request);
   * }
   * }</pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final HomeGraphApiServiceProto.SyncResponse sync(
      HomeGraphApiServiceProto.SyncRequest request) {
    return syncCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets all the devices associated with the given third-party user.
   *
   * <p>The third-party user's identity is passed in via the `agent_user_id` (see
   * [SyncRequest][google.home.graph.v1.SyncRequest]). This request must be authorized using service
   * account credentials from your Actions console project.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (HomeGraphApiServiceClient homeGraphApiServiceClient = HomeGraphApiServiceClient.create()) {
   *   HomeGraphApiServiceProto.SyncRequest request =
   *       HomeGraphApiServiceProto.SyncRequest.newBuilder()
   *           .setRequestId("requestId693933066")
   *           .setAgentUserId("agentUserId1708672427")
   *           .build();
   *   ApiFuture<HomeGraphApiServiceProto.SyncResponse> future =
   *       homeGraphApiServiceClient.syncCallable().futureCall(request);
   *   // Do something.
   *   HomeGraphApiServiceProto.SyncResponse response = future.get();
   * }
   * }</pre>
   */
  public final UnaryCallable<
          HomeGraphApiServiceProto.SyncRequest, HomeGraphApiServiceProto.SyncResponse>
      syncCallable() {
    return stub.syncCallable();
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
