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

package com.google.cloud.osconfig.agentendpoint.v1beta;

import com.google.api.gax.core.NoCredentialsProvider;
import com.google.api.gax.grpc.GaxGrpcProperties;
import com.google.api.gax.grpc.testing.LocalChannelProvider;
import com.google.api.gax.grpc.testing.MockGrpcService;
import com.google.api.gax.grpc.testing.MockServiceHelper;
import com.google.api.gax.grpc.testing.MockStreamObserver;
import com.google.api.gax.rpc.ApiClientHeaderProvider;
import com.google.api.gax.rpc.InvalidArgumentException;
import com.google.api.gax.rpc.ServerStreamingCallable;
import com.google.api.gax.rpc.StatusCode;
import com.google.protobuf.AbstractMessage;
import io.grpc.StatusRuntimeException;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.UUID;
import java.util.concurrent.ExecutionException;
import javax.annotation.Generated;
import org.junit.After;
import org.junit.AfterClass;
import org.junit.Assert;
import org.junit.Before;
import org.junit.BeforeClass;
import org.junit.Test;

@Generated("by gapic-generator-java")
public class AgentEndpointServiceClientTest {
  private static MockAgentEndpointService mockAgentEndpointService;
  private static MockServiceHelper mockServiceHelper;
  private AgentEndpointServiceClient client;
  private LocalChannelProvider channelProvider;

  @BeforeClass
  public static void startStaticServer() {
    mockAgentEndpointService = new MockAgentEndpointService();
    mockServiceHelper =
        new MockServiceHelper(
            UUID.randomUUID().toString(), Arrays.<MockGrpcService>asList(mockAgentEndpointService));
    mockServiceHelper.start();
  }

  @AfterClass
  public static void stopServer() {
    mockServiceHelper.stop();
  }

  @Before
  public void setUp() throws IOException {
    mockServiceHelper.reset();
    channelProvider = mockServiceHelper.createChannelProvider();
    AgentEndpointServiceSettings settings =
        AgentEndpointServiceSettings.newBuilder()
            .setTransportChannelProvider(channelProvider)
            .setCredentialsProvider(NoCredentialsProvider.create())
            .build();
    client = AgentEndpointServiceClient.create(settings);
  }

  @After
  public void tearDown() throws Exception {
    client.close();
  }

  @Test
  public void receiveTaskNotificationTest() throws Exception {
    ReceiveTaskNotificationResponse expectedResponse =
        ReceiveTaskNotificationResponse.newBuilder().build();
    mockAgentEndpointService.addResponse(expectedResponse);
    ReceiveTaskNotificationRequest request =
        ReceiveTaskNotificationRequest.newBuilder()
            .setInstanceIdToken("instanceIdToken55138121")
            .setAgentVersion("agentVersion1928000019")
            .build();

    MockStreamObserver<ReceiveTaskNotificationResponse> responseObserver =
        new MockStreamObserver<>();

    ServerStreamingCallable<ReceiveTaskNotificationRequest, ReceiveTaskNotificationResponse>
        callable = client.receiveTaskNotificationCallable();
    callable.serverStreamingCall(request, responseObserver);

    List<ReceiveTaskNotificationResponse> actualResponses = responseObserver.future().get();
    Assert.assertEquals(1, actualResponses.size());
    Assert.assertEquals(expectedResponse, actualResponses.get(0));
  }

  @Test
  public void receiveTaskNotificationExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockAgentEndpointService.addException(exception);
    ReceiveTaskNotificationRequest request =
        ReceiveTaskNotificationRequest.newBuilder()
            .setInstanceIdToken("instanceIdToken55138121")
            .setAgentVersion("agentVersion1928000019")
            .build();

    MockStreamObserver<ReceiveTaskNotificationResponse> responseObserver =
        new MockStreamObserver<>();

    ServerStreamingCallable<ReceiveTaskNotificationRequest, ReceiveTaskNotificationResponse>
        callable = client.receiveTaskNotificationCallable();
    callable.serverStreamingCall(request, responseObserver);

    try {
      List<ReceiveTaskNotificationResponse> actualResponses = responseObserver.future().get();
      Assert.fail("No exception thrown");
    } catch (ExecutionException e) {
      Assert.assertTrue(e.getCause() instanceof InvalidArgumentException);
      InvalidArgumentException apiException = ((InvalidArgumentException) e.getCause());
      Assert.assertEquals(StatusCode.Code.INVALID_ARGUMENT, apiException.getStatusCode().getCode());
    }
  }

  @Test
  public void startNextTaskTest() throws Exception {
    StartNextTaskResponse expectedResponse =
        StartNextTaskResponse.newBuilder().setTask(Task.newBuilder().build()).build();
    mockAgentEndpointService.addResponse(expectedResponse);

    String instanceIdToken = "instanceIdToken55138121";

    StartNextTaskResponse actualResponse = client.startNextTask(instanceIdToken);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockAgentEndpointService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    StartNextTaskRequest actualRequest = ((StartNextTaskRequest) actualRequests.get(0));

    Assert.assertEquals(instanceIdToken, actualRequest.getInstanceIdToken());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void startNextTaskExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockAgentEndpointService.addException(exception);

    try {
      String instanceIdToken = "instanceIdToken55138121";
      client.startNextTask(instanceIdToken);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void reportTaskProgressTest() throws Exception {
    ReportTaskProgressResponse expectedResponse =
        ReportTaskProgressResponse.newBuilder()
            .setTaskDirective(TaskDirective.forNumber(0))
            .build();
    mockAgentEndpointService.addResponse(expectedResponse);

    String instanceIdToken = "instanceIdToken55138121";
    String taskId = "taskId-880873088";
    TaskType taskType = TaskType.forNumber(0);

    ReportTaskProgressResponse actualResponse =
        client.reportTaskProgress(instanceIdToken, taskId, taskType);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockAgentEndpointService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    ReportTaskProgressRequest actualRequest = ((ReportTaskProgressRequest) actualRequests.get(0));

    Assert.assertEquals(instanceIdToken, actualRequest.getInstanceIdToken());
    Assert.assertEquals(taskId, actualRequest.getTaskId());
    Assert.assertEquals(taskType, actualRequest.getTaskType());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void reportTaskProgressExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockAgentEndpointService.addException(exception);

    try {
      String instanceIdToken = "instanceIdToken55138121";
      String taskId = "taskId-880873088";
      TaskType taskType = TaskType.forNumber(0);
      client.reportTaskProgress(instanceIdToken, taskId, taskType);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void reportTaskCompleteTest() throws Exception {
    ReportTaskCompleteResponse expectedResponse = ReportTaskCompleteResponse.newBuilder().build();
    mockAgentEndpointService.addResponse(expectedResponse);

    String instanceIdToken = "instanceIdToken55138121";
    String taskId = "taskId-880873088";
    TaskType taskType = TaskType.forNumber(0);
    String errorMessage = "errorMessage1203236063";

    ReportTaskCompleteResponse actualResponse =
        client.reportTaskComplete(instanceIdToken, taskId, taskType, errorMessage);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockAgentEndpointService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    ReportTaskCompleteRequest actualRequest = ((ReportTaskCompleteRequest) actualRequests.get(0));

    Assert.assertEquals(instanceIdToken, actualRequest.getInstanceIdToken());
    Assert.assertEquals(taskId, actualRequest.getTaskId());
    Assert.assertEquals(taskType, actualRequest.getTaskType());
    Assert.assertEquals(errorMessage, actualRequest.getErrorMessage());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void reportTaskCompleteExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockAgentEndpointService.addException(exception);

    try {
      String instanceIdToken = "instanceIdToken55138121";
      String taskId = "taskId-880873088";
      TaskType taskType = TaskType.forNumber(0);
      String errorMessage = "errorMessage1203236063";
      client.reportTaskComplete(instanceIdToken, taskId, taskType, errorMessage);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void lookupEffectiveGuestPolicyTest() throws Exception {
    GuestPolicies.EffectiveGuestPolicy expectedResponse =
        GuestPolicies.EffectiveGuestPolicy.newBuilder().build();
    mockAgentEndpointService.addResponse(expectedResponse);

    String instanceIdToken = "instanceIdToken55138121";
    String osShortName = "osShortName1253394339";
    String osVersion = "osVersion1812004436";
    String osArchitecture = "osArchitecture1339954519";

    GuestPolicies.EffectiveGuestPolicy actualResponse =
        client.lookupEffectiveGuestPolicy(instanceIdToken, osShortName, osVersion, osArchitecture);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockAgentEndpointService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    GuestPolicies.LookupEffectiveGuestPolicyRequest actualRequest =
        ((GuestPolicies.LookupEffectiveGuestPolicyRequest) actualRequests.get(0));

    Assert.assertEquals(instanceIdToken, actualRequest.getInstanceIdToken());
    Assert.assertEquals(osShortName, actualRequest.getOsShortName());
    Assert.assertEquals(osVersion, actualRequest.getOsVersion());
    Assert.assertEquals(osArchitecture, actualRequest.getOsArchitecture());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void lookupEffectiveGuestPolicyExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockAgentEndpointService.addException(exception);

    try {
      String instanceIdToken = "instanceIdToken55138121";
      String osShortName = "osShortName1253394339";
      String osVersion = "osVersion1812004436";
      String osArchitecture = "osArchitecture1339954519";
      client.lookupEffectiveGuestPolicy(instanceIdToken, osShortName, osVersion, osArchitecture);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void registerAgentTest() throws Exception {
    RegisterAgentResponse expectedResponse = RegisterAgentResponse.newBuilder().build();
    mockAgentEndpointService.addResponse(expectedResponse);

    String instanceIdToken = "instanceIdToken55138121";
    String agentVersion = "agentVersion1928000019";
    List<String> supportedCapabilities = new ArrayList<>();

    RegisterAgentResponse actualResponse =
        client.registerAgent(instanceIdToken, agentVersion, supportedCapabilities);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockAgentEndpointService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    RegisterAgentRequest actualRequest = ((RegisterAgentRequest) actualRequests.get(0));

    Assert.assertEquals(instanceIdToken, actualRequest.getInstanceIdToken());
    Assert.assertEquals(agentVersion, actualRequest.getAgentVersion());
    Assert.assertEquals(supportedCapabilities, actualRequest.getSupportedCapabilitiesList());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void registerAgentExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockAgentEndpointService.addException(exception);

    try {
      String instanceIdToken = "instanceIdToken55138121";
      String agentVersion = "agentVersion1928000019";
      List<String> supportedCapabilities = new ArrayList<>();
      client.registerAgent(instanceIdToken, agentVersion, supportedCapabilities);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }
}
