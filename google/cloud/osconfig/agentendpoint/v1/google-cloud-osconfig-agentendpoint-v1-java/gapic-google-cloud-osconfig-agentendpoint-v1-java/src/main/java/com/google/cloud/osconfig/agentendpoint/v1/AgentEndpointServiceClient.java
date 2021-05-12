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

package com.google.cloud.osconfig.agentendpoint.v1;

import com.google.api.core.BetaApi;
import com.google.api.gax.core.BackgroundResource;
import com.google.api.gax.rpc.ServerStreamingCallable;
import com.google.api.gax.rpc.UnaryCallable;
import com.google.cloud.osconfig.agentendpoint.v1.stub.AgentEndpointServiceStub;
import com.google.cloud.osconfig.agentendpoint.v1.stub.AgentEndpointServiceStubSettings;
import java.io.IOException;
import java.util.List;
import java.util.concurrent.TimeUnit;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * Service Description: OS Config agent endpoint API.
 *
 * <p>This class provides the ability to make remote calls to the backing service through method
 * calls that map to API methods. Sample code to get started:
 *
 * <pre>{@code
 * try (AgentEndpointServiceClient agentEndpointServiceClient =
 *     AgentEndpointServiceClient.create()) {
 *   String instanceIdToken = "instanceIdToken55138121";
 *   StartNextTaskResponse response = agentEndpointServiceClient.startNextTask(instanceIdToken);
 * }
 * }</pre>
 *
 * <p>Note: close() needs to be called on the AgentEndpointServiceClient object to clean up
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
 * <p>This class can be customized by passing in a custom instance of AgentEndpointServiceSettings
 * to create(). For example:
 *
 * <p>To customize credentials:
 *
 * <pre>{@code
 * AgentEndpointServiceSettings agentEndpointServiceSettings =
 *     AgentEndpointServiceSettings.newBuilder()
 *         .setCredentialsProvider(FixedCredentialsProvider.create(myCredentials))
 *         .build();
 * AgentEndpointServiceClient agentEndpointServiceClient =
 *     AgentEndpointServiceClient.create(agentEndpointServiceSettings);
 * }</pre>
 *
 * <p>To customize the endpoint:
 *
 * <pre>{@code
 * AgentEndpointServiceSettings agentEndpointServiceSettings =
 *     AgentEndpointServiceSettings.newBuilder().setEndpoint(myEndpoint).build();
 * AgentEndpointServiceClient agentEndpointServiceClient =
 *     AgentEndpointServiceClient.create(agentEndpointServiceSettings);
 * }</pre>
 *
 * <p>Please refer to the GitHub repository's samples for more quickstart code snippets.
 */
@Generated("by gapic-generator-java")
public class AgentEndpointServiceClient implements BackgroundResource {
  private final AgentEndpointServiceSettings settings;
  private final AgentEndpointServiceStub stub;

  /** Constructs an instance of AgentEndpointServiceClient with default settings. */
  public static final AgentEndpointServiceClient create() throws IOException {
    return create(AgentEndpointServiceSettings.newBuilder().build());
  }

  /**
   * Constructs an instance of AgentEndpointServiceClient, using the given settings. The channels
   * are created based on the settings passed in, or defaults for any settings that are not set.
   */
  public static final AgentEndpointServiceClient create(AgentEndpointServiceSettings settings)
      throws IOException {
    return new AgentEndpointServiceClient(settings);
  }

  /**
   * Constructs an instance of AgentEndpointServiceClient, using the given stub for making calls.
   * This is for advanced usage - prefer using create(AgentEndpointServiceSettings).
   */
  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public static final AgentEndpointServiceClient create(AgentEndpointServiceStub stub) {
    return new AgentEndpointServiceClient(stub);
  }

  /**
   * Constructs an instance of AgentEndpointServiceClient, using the given settings. This is
   * protected so that it is easy to make a subclass, but otherwise, the static factory methods
   * should be preferred.
   */
  protected AgentEndpointServiceClient(AgentEndpointServiceSettings settings) throws IOException {
    this.settings = settings;
    this.stub = ((AgentEndpointServiceStubSettings) settings.getStubSettings()).createStub();
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  protected AgentEndpointServiceClient(AgentEndpointServiceStub stub) {
    this.settings = null;
    this.stub = stub;
  }

  public final AgentEndpointServiceSettings getSettings() {
    return settings;
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public AgentEndpointServiceStub getStub() {
    return stub;
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Stream established by client to receive Task notifications.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (AgentEndpointServiceClient agentEndpointServiceClient =
   *     AgentEndpointServiceClient.create()) {
   *   ReceiveTaskNotificationRequest request =
   *       ReceiveTaskNotificationRequest.newBuilder()
   *           .setInstanceIdToken("instanceIdToken55138121")
   *           .setAgentVersion("agentVersion1928000019")
   *           .build();
   *   ServerStream<ReceiveTaskNotificationResponse> stream =
   *       agentEndpointServiceClient.receiveTaskNotificationCallable().call(request);
   *   for (ReceiveTaskNotificationResponse response : stream) {
   *     // Do something when a response is received.
   *   }
   * }
   * }</pre>
   */
  public final ServerStreamingCallable<
          ReceiveTaskNotificationRequest, ReceiveTaskNotificationResponse>
      receiveTaskNotificationCallable() {
    return stub.receiveTaskNotificationCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Signals the start of a task execution and returns the task info.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (AgentEndpointServiceClient agentEndpointServiceClient =
   *     AgentEndpointServiceClient.create()) {
   *   String instanceIdToken = "instanceIdToken55138121";
   *   StartNextTaskResponse response = agentEndpointServiceClient.startNextTask(instanceIdToken);
   * }
   * }</pre>
   *
   * @param instanceIdToken Required. This is the Compute Engine instance identity token described
   *     in https://cloud.google.com/compute/docs/instances/verifying-instance-identity where the
   *     audience is 'osconfig.googleapis.com' and the format is 'full'.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final StartNextTaskResponse startNextTask(String instanceIdToken) {
    StartNextTaskRequest request =
        StartNextTaskRequest.newBuilder().setInstanceIdToken(instanceIdToken).build();
    return startNextTask(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Signals the start of a task execution and returns the task info.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (AgentEndpointServiceClient agentEndpointServiceClient =
   *     AgentEndpointServiceClient.create()) {
   *   StartNextTaskRequest request =
   *       StartNextTaskRequest.newBuilder().setInstanceIdToken("instanceIdToken55138121").build();
   *   StartNextTaskResponse response = agentEndpointServiceClient.startNextTask(request);
   * }
   * }</pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final StartNextTaskResponse startNextTask(StartNextTaskRequest request) {
    return startNextTaskCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Signals the start of a task execution and returns the task info.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (AgentEndpointServiceClient agentEndpointServiceClient =
   *     AgentEndpointServiceClient.create()) {
   *   StartNextTaskRequest request =
   *       StartNextTaskRequest.newBuilder().setInstanceIdToken("instanceIdToken55138121").build();
   *   ApiFuture<StartNextTaskResponse> future =
   *       agentEndpointServiceClient.startNextTaskCallable().futureCall(request);
   *   // Do something.
   *   StartNextTaskResponse response = future.get();
   * }
   * }</pre>
   */
  public final UnaryCallable<StartNextTaskRequest, StartNextTaskResponse> startNextTaskCallable() {
    return stub.startNextTaskCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Signals an intermediary progress checkpoint in task execution.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (AgentEndpointServiceClient agentEndpointServiceClient =
   *     AgentEndpointServiceClient.create()) {
   *   String instanceIdToken = "instanceIdToken55138121";
   *   String taskId = "taskId-880873088";
   *   TaskType taskType = TaskType.forNumber(0);
   *   ReportTaskProgressResponse response =
   *       agentEndpointServiceClient.reportTaskProgress(instanceIdToken, taskId, taskType);
   * }
   * }</pre>
   *
   * @param instanceIdToken Required. This is the Compute Engine instance identity token described
   *     in https://cloud.google.com/compute/docs/instances/verifying-instance-identity where the
   *     audience is 'osconfig.googleapis.com' and the format is 'full'.
   * @param taskId Required. Unique identifier of the task this applies to.
   * @param taskType Required. The type of task to report progress on.
   *     <p>Progress must include the appropriate message based on this enum as specified below:
   *     APPLY_PATCHES = ApplyPatchesTaskProgress EXEC_STEP = Progress not supported for this type.
   *     APPLY_CONFIG_TASK = ApplyConfigTaskProgress
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ReportTaskProgressResponse reportTaskProgress(
      String instanceIdToken, String taskId, TaskType taskType) {
    ReportTaskProgressRequest request =
        ReportTaskProgressRequest.newBuilder()
            .setInstanceIdToken(instanceIdToken)
            .setTaskId(taskId)
            .setTaskType(taskType)
            .build();
    return reportTaskProgress(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Signals an intermediary progress checkpoint in task execution.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (AgentEndpointServiceClient agentEndpointServiceClient =
   *     AgentEndpointServiceClient.create()) {
   *   ReportTaskProgressRequest request =
   *       ReportTaskProgressRequest.newBuilder()
   *           .setInstanceIdToken("instanceIdToken55138121")
   *           .setTaskId("taskId-880873088")
   *           .setTaskType(TaskType.forNumber(0))
   *           .build();
   *   ReportTaskProgressResponse response = agentEndpointServiceClient.reportTaskProgress(request);
   * }
   * }</pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ReportTaskProgressResponse reportTaskProgress(ReportTaskProgressRequest request) {
    return reportTaskProgressCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Signals an intermediary progress checkpoint in task execution.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (AgentEndpointServiceClient agentEndpointServiceClient =
   *     AgentEndpointServiceClient.create()) {
   *   ReportTaskProgressRequest request =
   *       ReportTaskProgressRequest.newBuilder()
   *           .setInstanceIdToken("instanceIdToken55138121")
   *           .setTaskId("taskId-880873088")
   *           .setTaskType(TaskType.forNumber(0))
   *           .build();
   *   ApiFuture<ReportTaskProgressResponse> future =
   *       agentEndpointServiceClient.reportTaskProgressCallable().futureCall(request);
   *   // Do something.
   *   ReportTaskProgressResponse response = future.get();
   * }
   * }</pre>
   */
  public final UnaryCallable<ReportTaskProgressRequest, ReportTaskProgressResponse>
      reportTaskProgressCallable() {
    return stub.reportTaskProgressCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Signals that the task execution is complete and optionally returns the next task.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (AgentEndpointServiceClient agentEndpointServiceClient =
   *     AgentEndpointServiceClient.create()) {
   *   String instanceIdToken = "instanceIdToken55138121";
   *   String taskId = "taskId-880873088";
   *   TaskType taskType = TaskType.forNumber(0);
   *   String errorMessage = "errorMessage1203236063";
   *   ReportTaskCompleteResponse response =
   *       agentEndpointServiceClient.reportTaskComplete(
   *           instanceIdToken, taskId, taskType, errorMessage);
   * }
   * }</pre>
   *
   * @param instanceIdToken Required. This is the Compute Engine instance identity token described
   *     in https://cloud.google.com/compute/docs/instances/verifying-instance-identity where the
   *     audience is 'osconfig.googleapis.com' and the format is 'full'.
   * @param taskId Required. Unique identifier of the task this applies to.
   * @param taskType Required. The type of task to report completed.
   *     <p>Output must include the appropriate message based on this enum as specified below:
   *     APPLY_PATCHES = ApplyPatchesTaskOutput EXEC_STEP = ExecStepTaskOutput APPLY_CONFIG_TASK =
   *     ApplyConfigTaskOutput
   * @param errorMessage Descriptive error message if the task execution ended in error.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ReportTaskCompleteResponse reportTaskComplete(
      String instanceIdToken, String taskId, TaskType taskType, String errorMessage) {
    ReportTaskCompleteRequest request =
        ReportTaskCompleteRequest.newBuilder()
            .setInstanceIdToken(instanceIdToken)
            .setTaskId(taskId)
            .setTaskType(taskType)
            .setErrorMessage(errorMessage)
            .build();
    return reportTaskComplete(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Signals that the task execution is complete and optionally returns the next task.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (AgentEndpointServiceClient agentEndpointServiceClient =
   *     AgentEndpointServiceClient.create()) {
   *   ReportTaskCompleteRequest request =
   *       ReportTaskCompleteRequest.newBuilder()
   *           .setInstanceIdToken("instanceIdToken55138121")
   *           .setTaskId("taskId-880873088")
   *           .setTaskType(TaskType.forNumber(0))
   *           .setErrorMessage("errorMessage1203236063")
   *           .build();
   *   ReportTaskCompleteResponse response = agentEndpointServiceClient.reportTaskComplete(request);
   * }
   * }</pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ReportTaskCompleteResponse reportTaskComplete(ReportTaskCompleteRequest request) {
    return reportTaskCompleteCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Signals that the task execution is complete and optionally returns the next task.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (AgentEndpointServiceClient agentEndpointServiceClient =
   *     AgentEndpointServiceClient.create()) {
   *   ReportTaskCompleteRequest request =
   *       ReportTaskCompleteRequest.newBuilder()
   *           .setInstanceIdToken("instanceIdToken55138121")
   *           .setTaskId("taskId-880873088")
   *           .setTaskType(TaskType.forNumber(0))
   *           .setErrorMessage("errorMessage1203236063")
   *           .build();
   *   ApiFuture<ReportTaskCompleteResponse> future =
   *       agentEndpointServiceClient.reportTaskCompleteCallable().futureCall(request);
   *   // Do something.
   *   ReportTaskCompleteResponse response = future.get();
   * }
   * }</pre>
   */
  public final UnaryCallable<ReportTaskCompleteRequest, ReportTaskCompleteResponse>
      reportTaskCompleteCallable() {
    return stub.reportTaskCompleteCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Registers the agent running on the VM.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (AgentEndpointServiceClient agentEndpointServiceClient =
   *     AgentEndpointServiceClient.create()) {
   *   String instanceIdToken = "instanceIdToken55138121";
   *   String agentVersion = "agentVersion1928000019";
   *   List<String> supportedCapabilities = new ArrayList<>();
   *   RegisterAgentResponse response =
   *       agentEndpointServiceClient.registerAgent(
   *           instanceIdToken, agentVersion, supportedCapabilities);
   * }
   * }</pre>
   *
   * @param instanceIdToken Required. This is the Compute Engine instance identity token described
   *     in https://cloud.google.com/compute/docs/instances/verifying-instance-identity where the
   *     audience is 'osconfig.googleapis.com' and the format is 'full'.
   * @param agentVersion Required. The version of the agent.
   * @param supportedCapabilities Required. The capabilities supported by the agent. Supported
   *     values are: PATCH_GA GUEST_POLICY_BETA CONFIG_V1
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final RegisterAgentResponse registerAgent(
      String instanceIdToken, String agentVersion, List<String> supportedCapabilities) {
    RegisterAgentRequest request =
        RegisterAgentRequest.newBuilder()
            .setInstanceIdToken(instanceIdToken)
            .setAgentVersion(agentVersion)
            .addAllSupportedCapabilities(supportedCapabilities)
            .build();
    return registerAgent(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Registers the agent running on the VM.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (AgentEndpointServiceClient agentEndpointServiceClient =
   *     AgentEndpointServiceClient.create()) {
   *   RegisterAgentRequest request =
   *       RegisterAgentRequest.newBuilder()
   *           .setInstanceIdToken("instanceIdToken55138121")
   *           .setAgentVersion("agentVersion1928000019")
   *           .addAllSupportedCapabilities(new ArrayList<String>())
   *           .build();
   *   RegisterAgentResponse response = agentEndpointServiceClient.registerAgent(request);
   * }
   * }</pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final RegisterAgentResponse registerAgent(RegisterAgentRequest request) {
    return registerAgentCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Registers the agent running on the VM.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (AgentEndpointServiceClient agentEndpointServiceClient =
   *     AgentEndpointServiceClient.create()) {
   *   RegisterAgentRequest request =
   *       RegisterAgentRequest.newBuilder()
   *           .setInstanceIdToken("instanceIdToken55138121")
   *           .setAgentVersion("agentVersion1928000019")
   *           .addAllSupportedCapabilities(new ArrayList<String>())
   *           .build();
   *   ApiFuture<RegisterAgentResponse> future =
   *       agentEndpointServiceClient.registerAgentCallable().futureCall(request);
   *   // Do something.
   *   RegisterAgentResponse response = future.get();
   * }
   * }</pre>
   */
  public final UnaryCallable<RegisterAgentRequest, RegisterAgentResponse> registerAgentCallable() {
    return stub.registerAgentCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Reports the VMs current inventory.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (AgentEndpointServiceClient agentEndpointServiceClient =
   *     AgentEndpointServiceClient.create()) {
   *   String instanceIdToken = "instanceIdToken55138121";
   *   String inventoryChecksum = "inventoryChecksum1316273599";
   *   Inventory inventory = Inventory.newBuilder().build();
   *   ReportInventoryResponse response =
   *       agentEndpointServiceClient.reportInventory(instanceIdToken, inventoryChecksum, inventory);
   * }
   * }</pre>
   *
   * @param instanceIdToken Required. This is the Compute Engine instance identity token described
   *     in https://cloud.google.com/compute/docs/instances/verifying-instance-identity where the
   *     audience is 'osconfig.googleapis.com' and the format is 'full'.
   * @param inventoryChecksum Required. This is a client created checksum that should be generated
   *     based on the contents of the reported inventory. This will be used by the service to
   *     determine if it has the latest version of inventory.
   * @param inventory Optional. This is the details of the inventory. Should only be provided if the
   *     inventory has changed since the last report, or if instructed by the service to provide
   *     full inventory.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ReportInventoryResponse reportInventory(
      String instanceIdToken, String inventoryChecksum, Inventory inventory) {
    ReportInventoryRequest request =
        ReportInventoryRequest.newBuilder()
            .setInstanceIdToken(instanceIdToken)
            .setInventoryChecksum(inventoryChecksum)
            .setInventory(inventory)
            .build();
    return reportInventory(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Reports the VMs current inventory.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (AgentEndpointServiceClient agentEndpointServiceClient =
   *     AgentEndpointServiceClient.create()) {
   *   ReportInventoryRequest request =
   *       ReportInventoryRequest.newBuilder()
   *           .setInstanceIdToken("instanceIdToken55138121")
   *           .setInventoryChecksum("inventoryChecksum1316273599")
   *           .setInventory(Inventory.newBuilder().build())
   *           .build();
   *   ReportInventoryResponse response = agentEndpointServiceClient.reportInventory(request);
   * }
   * }</pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final ReportInventoryResponse reportInventory(ReportInventoryRequest request) {
    return reportInventoryCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Reports the VMs current inventory.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (AgentEndpointServiceClient agentEndpointServiceClient =
   *     AgentEndpointServiceClient.create()) {
   *   ReportInventoryRequest request =
   *       ReportInventoryRequest.newBuilder()
   *           .setInstanceIdToken("instanceIdToken55138121")
   *           .setInventoryChecksum("inventoryChecksum1316273599")
   *           .setInventory(Inventory.newBuilder().build())
   *           .build();
   *   ApiFuture<ReportInventoryResponse> future =
   *       agentEndpointServiceClient.reportInventoryCallable().futureCall(request);
   *   // Do something.
   *   ReportInventoryResponse response = future.get();
   * }
   * }</pre>
   */
  public final UnaryCallable<ReportInventoryRequest, ReportInventoryResponse>
      reportInventoryCallable() {
    return stub.reportInventoryCallable();
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
