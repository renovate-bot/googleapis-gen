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

import com.google.api.gax.core.NoCredentialsProvider;
import com.google.api.gax.grpc.GaxGrpcProperties;
import com.google.api.gax.grpc.testing.LocalChannelProvider;
import com.google.api.gax.grpc.testing.MockGrpcService;
import com.google.api.gax.grpc.testing.MockServiceHelper;
import com.google.api.gax.rpc.ApiClientHeaderProvider;
import com.google.api.gax.rpc.InvalidArgumentException;
import com.google.protobuf.AbstractMessage;
import com.google.protobuf.Timestamp;
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
public class TestExecutionServiceClientTest {
  private static MockServiceHelper mockServiceHelper;
  private static MockTestExecutionService mockTestExecutionService;
  private LocalChannelProvider channelProvider;
  private TestExecutionServiceClient client;

  @BeforeClass
  public static void startStaticServer() {
    mockTestExecutionService = new MockTestExecutionService();
    mockServiceHelper =
        new MockServiceHelper(
            UUID.randomUUID().toString(), Arrays.<MockGrpcService>asList(mockTestExecutionService));
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
    TestExecutionServiceSettings settings =
        TestExecutionServiceSettings.newBuilder()
            .setTransportChannelProvider(channelProvider)
            .setCredentialsProvider(NoCredentialsProvider.create())
            .build();
    client = TestExecutionServiceClient.create(settings);
  }

  @After
  public void tearDown() throws Exception {
    client.close();
  }

  @Test
  public void createTestMatrixTest() throws Exception {
    TestMatrix expectedResponse =
        TestMatrix.newBuilder()
            .setTestMatrixId("testMatrixId1025157998")
            .setProjectId("projectId-894832108")
            .setClientInfo(ClientInfo.newBuilder().build())
            .setTestSpecification(TestSpecification.newBuilder().build())
            .setEnvironmentMatrix(EnvironmentMatrix.newBuilder().build())
            .addAllTestExecutions(new ArrayList<TestExecution>())
            .setResultStorage(ResultStorage.newBuilder().build())
            .setState(TestState.forNumber(0))
            .setTimestamp(Timestamp.newBuilder().build())
            .setInvalidMatrixDetails(InvalidMatrixDetails.forNumber(0))
            .setFlakyTestAttempts(-671238755)
            .setOutcomeSummary(OutcomeSummary.forNumber(0))
            .setFailFast(true)
            .build();
    mockTestExecutionService.addResponse(expectedResponse);

    CreateTestMatrixRequest request =
        CreateTestMatrixRequest.newBuilder()
            .setProjectId("projectId-894832108")
            .setTestMatrix(TestMatrix.newBuilder().build())
            .setRequestId("requestId693933066")
            .build();

    TestMatrix actualResponse = client.createTestMatrix(request);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockTestExecutionService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    CreateTestMatrixRequest actualRequest = ((CreateTestMatrixRequest) actualRequests.get(0));

    Assert.assertEquals(request.getProjectId(), actualRequest.getProjectId());
    Assert.assertEquals(request.getTestMatrix(), actualRequest.getTestMatrix());
    Assert.assertEquals(request.getRequestId(), actualRequest.getRequestId());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void createTestMatrixExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockTestExecutionService.addException(exception);

    try {
      CreateTestMatrixRequest request =
          CreateTestMatrixRequest.newBuilder()
              .setProjectId("projectId-894832108")
              .setTestMatrix(TestMatrix.newBuilder().build())
              .setRequestId("requestId693933066")
              .build();
      client.createTestMatrix(request);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void getTestMatrixTest() throws Exception {
    TestMatrix expectedResponse =
        TestMatrix.newBuilder()
            .setTestMatrixId("testMatrixId1025157998")
            .setProjectId("projectId-894832108")
            .setClientInfo(ClientInfo.newBuilder().build())
            .setTestSpecification(TestSpecification.newBuilder().build())
            .setEnvironmentMatrix(EnvironmentMatrix.newBuilder().build())
            .addAllTestExecutions(new ArrayList<TestExecution>())
            .setResultStorage(ResultStorage.newBuilder().build())
            .setState(TestState.forNumber(0))
            .setTimestamp(Timestamp.newBuilder().build())
            .setInvalidMatrixDetails(InvalidMatrixDetails.forNumber(0))
            .setFlakyTestAttempts(-671238755)
            .setOutcomeSummary(OutcomeSummary.forNumber(0))
            .setFailFast(true)
            .build();
    mockTestExecutionService.addResponse(expectedResponse);

    GetTestMatrixRequest request =
        GetTestMatrixRequest.newBuilder()
            .setProjectId("projectId-894832108")
            .setTestMatrixId("testMatrixId1025157998")
            .build();

    TestMatrix actualResponse = client.getTestMatrix(request);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockTestExecutionService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    GetTestMatrixRequest actualRequest = ((GetTestMatrixRequest) actualRequests.get(0));

    Assert.assertEquals(request.getProjectId(), actualRequest.getProjectId());
    Assert.assertEquals(request.getTestMatrixId(), actualRequest.getTestMatrixId());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void getTestMatrixExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockTestExecutionService.addException(exception);

    try {
      GetTestMatrixRequest request =
          GetTestMatrixRequest.newBuilder()
              .setProjectId("projectId-894832108")
              .setTestMatrixId("testMatrixId1025157998")
              .build();
      client.getTestMatrix(request);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void cancelTestMatrixTest() throws Exception {
    CancelTestMatrixResponse expectedResponse =
        CancelTestMatrixResponse.newBuilder().setTestState(TestState.forNumber(0)).build();
    mockTestExecutionService.addResponse(expectedResponse);

    CancelTestMatrixRequest request =
        CancelTestMatrixRequest.newBuilder()
            .setProjectId("projectId-894832108")
            .setTestMatrixId("testMatrixId1025157998")
            .build();

    CancelTestMatrixResponse actualResponse = client.cancelTestMatrix(request);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockTestExecutionService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    CancelTestMatrixRequest actualRequest = ((CancelTestMatrixRequest) actualRequests.get(0));

    Assert.assertEquals(request.getProjectId(), actualRequest.getProjectId());
    Assert.assertEquals(request.getTestMatrixId(), actualRequest.getTestMatrixId());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void cancelTestMatrixExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockTestExecutionService.addException(exception);

    try {
      CancelTestMatrixRequest request =
          CancelTestMatrixRequest.newBuilder()
              .setProjectId("projectId-894832108")
              .setTestMatrixId("testMatrixId1025157998")
              .build();
      client.cancelTestMatrix(request);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }
}
