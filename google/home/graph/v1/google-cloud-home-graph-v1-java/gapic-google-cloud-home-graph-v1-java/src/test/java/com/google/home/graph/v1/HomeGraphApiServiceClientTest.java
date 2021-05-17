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

import com.google.api.gax.core.NoCredentialsProvider;
import com.google.api.gax.grpc.GaxGrpcProperties;
import com.google.api.gax.grpc.testing.LocalChannelProvider;
import com.google.api.gax.grpc.testing.MockGrpcService;
import com.google.api.gax.grpc.testing.MockServiceHelper;
import com.google.api.gax.rpc.ApiClientHeaderProvider;
import com.google.api.gax.rpc.InvalidArgumentException;
import com.google.protobuf.AbstractMessage;
import com.google.protobuf.Empty;
import io.grpc.StatusRuntimeException;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.UUID;
import javax.annotation.Generated;
import org.junit.After;
import org.junit.AfterClass;
import org.junit.Assert;
import org.junit.Before;
import org.junit.BeforeClass;
import org.junit.Test;

@Generated("by gapic-generator-java")
public class HomeGraphApiServiceClientTest {
  private static MockServiceHelper mockServiceHelper;
  private static MockHomeGraphApiService mockHomeGraphApiService;
  private HomeGraphApiServiceClient client;
  private LocalChannelProvider channelProvider;

  @BeforeClass
  public static void startStaticServer() {
    mockHomeGraphApiService = new MockHomeGraphApiService();
    mockServiceHelper =
        new MockServiceHelper(
            UUID.randomUUID().toString(), Arrays.<MockGrpcService>asList(mockHomeGraphApiService));
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
    HomeGraphApiServiceSettings settings =
        HomeGraphApiServiceSettings.newBuilder()
            .setTransportChannelProvider(channelProvider)
            .setCredentialsProvider(NoCredentialsProvider.create())
            .build();
    client = HomeGraphApiServiceClient.create(settings);
  }

  @After
  public void tearDown() throws Exception {
    client.close();
  }

  @Test
  public void requestSyncDevicesTest() throws Exception {
    HomeGraphApiServiceProto.RequestSyncDevicesResponse expectedResponse =
        HomeGraphApiServiceProto.RequestSyncDevicesResponse.newBuilder().build();
    mockHomeGraphApiService.addResponse(expectedResponse);

    String agentUserId = "agentUserId1708672427";

    HomeGraphApiServiceProto.RequestSyncDevicesResponse actualResponse =
        client.requestSyncDevices(agentUserId);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockHomeGraphApiService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    HomeGraphApiServiceProto.RequestSyncDevicesRequest actualRequest =
        ((HomeGraphApiServiceProto.RequestSyncDevicesRequest) actualRequests.get(0));

    Assert.assertEquals(agentUserId, actualRequest.getAgentUserId());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void requestSyncDevicesExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockHomeGraphApiService.addException(exception);

    try {
      String agentUserId = "agentUserId1708672427";
      client.requestSyncDevices(agentUserId);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void reportStateAndNotificationTest() throws Exception {
    HomeGraphApiServiceProto.ReportStateAndNotificationResponse expectedResponse =
        HomeGraphApiServiceProto.ReportStateAndNotificationResponse.newBuilder()
            .setRequestId("requestId693933066")
            .build();
    mockHomeGraphApiService.addResponse(expectedResponse);

    String requestId = "requestId693933066";
    String eventId = "eventId-1376502443";
    String agentUserId = "agentUserId1708672427";
    HomeGraphApiServiceProto.StateAndNotificationPayload payload =
        HomeGraphApiServiceProto.StateAndNotificationPayload.newBuilder().build();

    HomeGraphApiServiceProto.ReportStateAndNotificationResponse actualResponse =
        client.reportStateAndNotification(requestId, eventId, agentUserId, payload);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockHomeGraphApiService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    HomeGraphApiServiceProto.ReportStateAndNotificationRequest actualRequest =
        ((HomeGraphApiServiceProto.ReportStateAndNotificationRequest) actualRequests.get(0));

    Assert.assertEquals(requestId, actualRequest.getRequestId());
    Assert.assertEquals(eventId, actualRequest.getEventId());
    Assert.assertEquals(agentUserId, actualRequest.getAgentUserId());
    Assert.assertEquals(payload, actualRequest.getPayload());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void reportStateAndNotificationExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockHomeGraphApiService.addException(exception);

    try {
      String requestId = "requestId693933066";
      String eventId = "eventId-1376502443";
      String agentUserId = "agentUserId1708672427";
      HomeGraphApiServiceProto.StateAndNotificationPayload payload =
          HomeGraphApiServiceProto.StateAndNotificationPayload.newBuilder().build();
      client.reportStateAndNotification(requestId, eventId, agentUserId, payload);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void deleteAgentUserTest() throws Exception {
    Empty expectedResponse = Empty.newBuilder().build();
    mockHomeGraphApiService.addResponse(expectedResponse);

    String requestId = "requestId693933066";
    AgentUserPathName agentUserId = AgentUserPathName.of("[AGENT_USER_PATH]");

    client.deleteAgentUser(requestId, agentUserId);

    List<AbstractMessage> actualRequests = mockHomeGraphApiService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    HomeGraphApiServiceProto.DeleteAgentUserRequest actualRequest =
        ((HomeGraphApiServiceProto.DeleteAgentUserRequest) actualRequests.get(0));

    Assert.assertEquals(requestId, actualRequest.getRequestId());
    Assert.assertEquals(agentUserId.toString(), actualRequest.getAgentUserId());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void deleteAgentUserExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockHomeGraphApiService.addException(exception);

    try {
      String requestId = "requestId693933066";
      AgentUserPathName agentUserId = AgentUserPathName.of("[AGENT_USER_PATH]");
      client.deleteAgentUser(requestId, agentUserId);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void deleteAgentUserTest2() throws Exception {
    Empty expectedResponse = Empty.newBuilder().build();
    mockHomeGraphApiService.addResponse(expectedResponse);

    String requestId = "requestId693933066";
    String agentUserId = "agentUserId1708672427";

    client.deleteAgentUser(requestId, agentUserId);

    List<AbstractMessage> actualRequests = mockHomeGraphApiService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    HomeGraphApiServiceProto.DeleteAgentUserRequest actualRequest =
        ((HomeGraphApiServiceProto.DeleteAgentUserRequest) actualRequests.get(0));

    Assert.assertEquals(requestId, actualRequest.getRequestId());
    Assert.assertEquals(agentUserId, actualRequest.getAgentUserId());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void deleteAgentUserExceptionTest2() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockHomeGraphApiService.addException(exception);

    try {
      String requestId = "requestId693933066";
      String agentUserId = "agentUserId1708672427";
      client.deleteAgentUser(requestId, agentUserId);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void queryTest() throws Exception {
    HomeGraphApiServiceProto.QueryResponse expectedResponse =
        HomeGraphApiServiceProto.QueryResponse.newBuilder()
            .setRequestId("requestId693933066")
            .setPayload(HomeGraphApiServiceProto.QueryResponsePayload.newBuilder().build())
            .build();
    mockHomeGraphApiService.addResponse(expectedResponse);

    String requestId = "requestId693933066";
    String agentUserId = "agentUserId1708672427";
    List<HomeGraphApiServiceProto.QueryRequestInput> inputs = new ArrayList<>();

    HomeGraphApiServiceProto.QueryResponse actualResponse =
        client.query(requestId, agentUserId, inputs);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockHomeGraphApiService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    HomeGraphApiServiceProto.QueryRequest actualRequest =
        ((HomeGraphApiServiceProto.QueryRequest) actualRequests.get(0));

    Assert.assertEquals(requestId, actualRequest.getRequestId());
    Assert.assertEquals(agentUserId, actualRequest.getAgentUserId());
    Assert.assertEquals(inputs, actualRequest.getInputsList());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void queryExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockHomeGraphApiService.addException(exception);

    try {
      String requestId = "requestId693933066";
      String agentUserId = "agentUserId1708672427";
      List<HomeGraphApiServiceProto.QueryRequestInput> inputs = new ArrayList<>();
      client.query(requestId, agentUserId, inputs);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void syncTest() throws Exception {
    HomeGraphApiServiceProto.SyncResponse expectedResponse =
        HomeGraphApiServiceProto.SyncResponse.newBuilder()
            .setRequestId("requestId693933066")
            .setPayload(HomeGraphApiServiceProto.SyncResponsePayload.newBuilder().build())
            .build();
    mockHomeGraphApiService.addResponse(expectedResponse);

    String requestId = "requestId693933066";
    String agentUserId = "agentUserId1708672427";

    HomeGraphApiServiceProto.SyncResponse actualResponse = client.sync(requestId, agentUserId);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockHomeGraphApiService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    HomeGraphApiServiceProto.SyncRequest actualRequest =
        ((HomeGraphApiServiceProto.SyncRequest) actualRequests.get(0));

    Assert.assertEquals(requestId, actualRequest.getRequestId());
    Assert.assertEquals(agentUserId, actualRequest.getAgentUserId());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void syncExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockHomeGraphApiService.addException(exception);

    try {
      String requestId = "requestId693933066";
      String agentUserId = "agentUserId1708672427";
      client.sync(requestId, agentUserId);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }
}
