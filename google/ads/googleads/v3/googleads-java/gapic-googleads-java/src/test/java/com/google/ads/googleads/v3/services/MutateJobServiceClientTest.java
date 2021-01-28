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

import static com.google.ads.googleads.v3.services.MutateJobServiceClient.ListMutateJobResultsPagedResponse;

import com.google.ads.googleads.v3.resources.MutateJob;
import com.google.ads.googleads.v3.resources.MutateJobName;
import com.google.api.gax.core.NoCredentialsProvider;
import com.google.api.gax.grpc.GaxGrpcProperties;
import com.google.api.gax.grpc.testing.LocalChannelProvider;
import com.google.api.gax.grpc.testing.MockGrpcService;
import com.google.api.gax.grpc.testing.MockServiceHelper;
import com.google.api.gax.rpc.ApiClientHeaderProvider;
import com.google.api.gax.rpc.InvalidArgumentException;
import com.google.api.gax.rpc.StatusCode;
import com.google.common.collect.Lists;
import com.google.longrunning.Operation;
import com.google.protobuf.AbstractMessage;
import com.google.protobuf.Any;
import com.google.protobuf.Empty;
import com.google.protobuf.Int64Value;
import com.google.protobuf.StringValue;
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
public class MutateJobServiceClientTest {
  private static MockServiceHelper mockServiceHelper;
  private static MockMutateJobService mockMutateJobService;
  private MutateJobServiceClient client;
  private LocalChannelProvider channelProvider;

  @BeforeClass
  public static void startStaticServer() {
    mockMutateJobService = new MockMutateJobService();
    mockServiceHelper =
        new MockServiceHelper(
            UUID.randomUUID().toString(), Arrays.<MockGrpcService>asList(mockMutateJobService));
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
    MutateJobServiceSettings settings =
        MutateJobServiceSettings.newBuilder()
            .setTransportChannelProvider(channelProvider)
            .setCredentialsProvider(NoCredentialsProvider.create())
            .build();
    client = MutateJobServiceClient.create(settings);
  }

  @After
  public void tearDown() throws Exception {
    client.close();
  }

  @Test
  public void createMutateJobTest() throws Exception {
    CreateMutateJobResponse expectedResponse =
        CreateMutateJobResponse.newBuilder().setResourceName("resourceName-384566343").build();
    mockMutateJobService.addResponse(expectedResponse);

    String customerId = "customerId-1581184615";

    CreateMutateJobResponse actualResponse = client.createMutateJob(customerId);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockMutateJobService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    CreateMutateJobRequest actualRequest = ((CreateMutateJobRequest) actualRequests.get(0));

    Assert.assertEquals(customerId, actualRequest.getCustomerId());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void createMutateJobExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockMutateJobService.addException(exception);

    try {
      String customerId = "customerId-1581184615";
      client.createMutateJob(customerId);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void getMutateJobTest() throws Exception {
    MutateJob expectedResponse =
        MutateJob.newBuilder()
            .setResourceName(MutateJobName.of("[CUSTOMER]", "[MUTATE_JOB]").toString())
            .setId(Int64Value.newBuilder().build())
            .setNextAddSequenceToken(StringValue.newBuilder().build())
            .setMetadata(MutateJob.MutateJobMetadata.newBuilder().build())
            .setLongRunningOperation(StringValue.newBuilder().build())
            .build();
    mockMutateJobService.addResponse(expectedResponse);

    MutateJobName resourceName = MutateJobName.of("[CUSTOMER]", "[MUTATE_JOB]");

    MutateJob actualResponse = client.getMutateJob(resourceName);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockMutateJobService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    GetMutateJobRequest actualRequest = ((GetMutateJobRequest) actualRequests.get(0));

    Assert.assertEquals(resourceName.toString(), actualRequest.getResourceName());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void getMutateJobExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockMutateJobService.addException(exception);

    try {
      MutateJobName resourceName = MutateJobName.of("[CUSTOMER]", "[MUTATE_JOB]");
      client.getMutateJob(resourceName);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void getMutateJobTest2() throws Exception {
    MutateJob expectedResponse =
        MutateJob.newBuilder()
            .setResourceName(MutateJobName.of("[CUSTOMER]", "[MUTATE_JOB]").toString())
            .setId(Int64Value.newBuilder().build())
            .setNextAddSequenceToken(StringValue.newBuilder().build())
            .setMetadata(MutateJob.MutateJobMetadata.newBuilder().build())
            .setLongRunningOperation(StringValue.newBuilder().build())
            .build();
    mockMutateJobService.addResponse(expectedResponse);

    String resourceName = "resourceName-384566343";

    MutateJob actualResponse = client.getMutateJob(resourceName);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockMutateJobService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    GetMutateJobRequest actualRequest = ((GetMutateJobRequest) actualRequests.get(0));

    Assert.assertEquals(resourceName, actualRequest.getResourceName());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void getMutateJobExceptionTest2() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockMutateJobService.addException(exception);

    try {
      String resourceName = "resourceName-384566343";
      client.getMutateJob(resourceName);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void listMutateJobResultsTest() throws Exception {
    MutateJobResult responsesElement = MutateJobResult.newBuilder().build();
    ListMutateJobResultsResponse expectedResponse =
        ListMutateJobResultsResponse.newBuilder()
            .setNextPageToken("")
            .addAllResults(Arrays.asList(responsesElement))
            .build();
    mockMutateJobService.addResponse(expectedResponse);

    MutateJobName resourceName = MutateJobName.of("[CUSTOMER]", "[MUTATE_JOB]");

    ListMutateJobResultsPagedResponse pagedListResponse = client.listMutateJobResults(resourceName);

    List<MutateJobResult> resources = Lists.newArrayList(pagedListResponse.iterateAll());

    Assert.assertEquals(1, resources.size());
    Assert.assertEquals(expectedResponse.getResultsList().get(0), resources.get(0));

    List<AbstractMessage> actualRequests = mockMutateJobService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    ListMutateJobResultsRequest actualRequest =
        ((ListMutateJobResultsRequest) actualRequests.get(0));

    Assert.assertEquals(resourceName.toString(), actualRequest.getResourceName());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void listMutateJobResultsExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockMutateJobService.addException(exception);

    try {
      MutateJobName resourceName = MutateJobName.of("[CUSTOMER]", "[MUTATE_JOB]");
      client.listMutateJobResults(resourceName);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void listMutateJobResultsTest2() throws Exception {
    MutateJobResult responsesElement = MutateJobResult.newBuilder().build();
    ListMutateJobResultsResponse expectedResponse =
        ListMutateJobResultsResponse.newBuilder()
            .setNextPageToken("")
            .addAllResults(Arrays.asList(responsesElement))
            .build();
    mockMutateJobService.addResponse(expectedResponse);

    String resourceName = "resourceName-384566343";

    ListMutateJobResultsPagedResponse pagedListResponse = client.listMutateJobResults(resourceName);

    List<MutateJobResult> resources = Lists.newArrayList(pagedListResponse.iterateAll());

    Assert.assertEquals(1, resources.size());
    Assert.assertEquals(expectedResponse.getResultsList().get(0), resources.get(0));

    List<AbstractMessage> actualRequests = mockMutateJobService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    ListMutateJobResultsRequest actualRequest =
        ((ListMutateJobResultsRequest) actualRequests.get(0));

    Assert.assertEquals(resourceName, actualRequest.getResourceName());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void listMutateJobResultsExceptionTest2() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockMutateJobService.addException(exception);

    try {
      String resourceName = "resourceName-384566343";
      client.listMutateJobResults(resourceName);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void runMutateJobTest() throws Exception {
    Empty expectedResponse = Empty.newBuilder().build();
    Operation resultOperation =
        Operation.newBuilder()
            .setName("runMutateJobTest")
            .setDone(true)
            .setResponse(Any.pack(expectedResponse))
            .build();
    mockMutateJobService.addResponse(resultOperation);

    MutateJobName resourceName = MutateJobName.of("[CUSTOMER]", "[MUTATE_JOB]");

    client.runMutateJobAsync(resourceName).get();

    List<AbstractMessage> actualRequests = mockMutateJobService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    RunMutateJobRequest actualRequest = ((RunMutateJobRequest) actualRequests.get(0));

    Assert.assertEquals(resourceName.toString(), actualRequest.getResourceName());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void runMutateJobExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockMutateJobService.addException(exception);

    try {
      MutateJobName resourceName = MutateJobName.of("[CUSTOMER]", "[MUTATE_JOB]");
      client.runMutateJobAsync(resourceName).get();
      Assert.fail("No exception raised");
    } catch (ExecutionException e) {
      Assert.assertEquals(InvalidArgumentException.class, e.getCause().getClass());
      InvalidArgumentException apiException = ((InvalidArgumentException) e.getCause());
      Assert.assertEquals(StatusCode.Code.INVALID_ARGUMENT, apiException.getStatusCode().getCode());
    }
  }

  @Test
  public void runMutateJobTest2() throws Exception {
    Empty expectedResponse = Empty.newBuilder().build();
    Operation resultOperation =
        Operation.newBuilder()
            .setName("runMutateJobTest")
            .setDone(true)
            .setResponse(Any.pack(expectedResponse))
            .build();
    mockMutateJobService.addResponse(resultOperation);

    String resourceName = "resourceName-384566343";

    client.runMutateJobAsync(resourceName).get();

    List<AbstractMessage> actualRequests = mockMutateJobService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    RunMutateJobRequest actualRequest = ((RunMutateJobRequest) actualRequests.get(0));

    Assert.assertEquals(resourceName, actualRequest.getResourceName());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void runMutateJobExceptionTest2() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockMutateJobService.addException(exception);

    try {
      String resourceName = "resourceName-384566343";
      client.runMutateJobAsync(resourceName).get();
      Assert.fail("No exception raised");
    } catch (ExecutionException e) {
      Assert.assertEquals(InvalidArgumentException.class, e.getCause().getClass());
      InvalidArgumentException apiException = ((InvalidArgumentException) e.getCause());
      Assert.assertEquals(StatusCode.Code.INVALID_ARGUMENT, apiException.getStatusCode().getCode());
    }
  }

  @Test
  public void addMutateJobOperationsTest() throws Exception {
    AddMutateJobOperationsResponse expectedResponse =
        AddMutateJobOperationsResponse.newBuilder()
            .setTotalOperations(1685086151)
            .setNextSequenceToken("nextSequenceToken586107525")
            .build();
    mockMutateJobService.addResponse(expectedResponse);

    MutateJobName resourceName = MutateJobName.of("[CUSTOMER]", "[MUTATE_JOB]");
    List<MutateOperation> mutateOperations = new ArrayList<>();

    AddMutateJobOperationsResponse actualResponse =
        client.addMutateJobOperations(resourceName, mutateOperations);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockMutateJobService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    AddMutateJobOperationsRequest actualRequest =
        ((AddMutateJobOperationsRequest) actualRequests.get(0));

    Assert.assertEquals(resourceName.toString(), actualRequest.getResourceName());
    Assert.assertEquals(mutateOperations, actualRequest.getMutateOperationsList());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void addMutateJobOperationsExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockMutateJobService.addException(exception);

    try {
      MutateJobName resourceName = MutateJobName.of("[CUSTOMER]", "[MUTATE_JOB]");
      List<MutateOperation> mutateOperations = new ArrayList<>();
      client.addMutateJobOperations(resourceName, mutateOperations);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void addMutateJobOperationsTest2() throws Exception {
    AddMutateJobOperationsResponse expectedResponse =
        AddMutateJobOperationsResponse.newBuilder()
            .setTotalOperations(1685086151)
            .setNextSequenceToken("nextSequenceToken586107525")
            .build();
    mockMutateJobService.addResponse(expectedResponse);

    String resourceName = "resourceName-384566343";
    List<MutateOperation> mutateOperations = new ArrayList<>();

    AddMutateJobOperationsResponse actualResponse =
        client.addMutateJobOperations(resourceName, mutateOperations);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockMutateJobService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    AddMutateJobOperationsRequest actualRequest =
        ((AddMutateJobOperationsRequest) actualRequests.get(0));

    Assert.assertEquals(resourceName, actualRequest.getResourceName());
    Assert.assertEquals(mutateOperations, actualRequest.getMutateOperationsList());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void addMutateJobOperationsExceptionTest2() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockMutateJobService.addException(exception);

    try {
      String resourceName = "resourceName-384566343";
      List<MutateOperation> mutateOperations = new ArrayList<>();
      client.addMutateJobOperations(resourceName, mutateOperations);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void addMutateJobOperationsTest3() throws Exception {
    AddMutateJobOperationsResponse expectedResponse =
        AddMutateJobOperationsResponse.newBuilder()
            .setTotalOperations(1685086151)
            .setNextSequenceToken("nextSequenceToken586107525")
            .build();
    mockMutateJobService.addResponse(expectedResponse);

    MutateJobName resourceName = MutateJobName.of("[CUSTOMER]", "[MUTATE_JOB]");
    String sequenceToken = "sequenceToken-731053384";
    List<MutateOperation> mutateOperations = new ArrayList<>();

    AddMutateJobOperationsResponse actualResponse =
        client.addMutateJobOperations(resourceName, sequenceToken, mutateOperations);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockMutateJobService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    AddMutateJobOperationsRequest actualRequest =
        ((AddMutateJobOperationsRequest) actualRequests.get(0));

    Assert.assertEquals(resourceName.toString(), actualRequest.getResourceName());
    Assert.assertEquals(sequenceToken, actualRequest.getSequenceToken());
    Assert.assertEquals(mutateOperations, actualRequest.getMutateOperationsList());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void addMutateJobOperationsExceptionTest3() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockMutateJobService.addException(exception);

    try {
      MutateJobName resourceName = MutateJobName.of("[CUSTOMER]", "[MUTATE_JOB]");
      String sequenceToken = "sequenceToken-731053384";
      List<MutateOperation> mutateOperations = new ArrayList<>();
      client.addMutateJobOperations(resourceName, sequenceToken, mutateOperations);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void addMutateJobOperationsTest4() throws Exception {
    AddMutateJobOperationsResponse expectedResponse =
        AddMutateJobOperationsResponse.newBuilder()
            .setTotalOperations(1685086151)
            .setNextSequenceToken("nextSequenceToken586107525")
            .build();
    mockMutateJobService.addResponse(expectedResponse);

    String resourceName = "resourceName-384566343";
    String sequenceToken = "sequenceToken-731053384";
    List<MutateOperation> mutateOperations = new ArrayList<>();

    AddMutateJobOperationsResponse actualResponse =
        client.addMutateJobOperations(resourceName, sequenceToken, mutateOperations);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockMutateJobService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    AddMutateJobOperationsRequest actualRequest =
        ((AddMutateJobOperationsRequest) actualRequests.get(0));

    Assert.assertEquals(resourceName, actualRequest.getResourceName());
    Assert.assertEquals(sequenceToken, actualRequest.getSequenceToken());
    Assert.assertEquals(mutateOperations, actualRequest.getMutateOperationsList());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void addMutateJobOperationsExceptionTest4() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockMutateJobService.addException(exception);

    try {
      String resourceName = "resourceName-384566343";
      String sequenceToken = "sequenceToken-731053384";
      List<MutateOperation> mutateOperations = new ArrayList<>();
      client.addMutateJobOperations(resourceName, sequenceToken, mutateOperations);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }
}
