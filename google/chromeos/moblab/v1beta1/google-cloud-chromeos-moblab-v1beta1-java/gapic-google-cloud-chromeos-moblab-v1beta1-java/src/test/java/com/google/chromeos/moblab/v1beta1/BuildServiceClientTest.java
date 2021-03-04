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

package com.google.chromeos.moblab.v1beta1;

import static com.google.chromeos.moblab.v1beta1.BuildServiceClient.ListBuildsPagedResponse;

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
import io.grpc.StatusRuntimeException;
import java.io.IOException;
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
public class BuildServiceClientTest {
  private static MockServiceHelper mockServiceHelper;
  private static MockBuildService mockBuildService;
  private BuildServiceClient client;
  private LocalChannelProvider channelProvider;

  @BeforeClass
  public static void startStaticServer() {
    mockBuildService = new MockBuildService();
    mockServiceHelper =
        new MockServiceHelper(
            UUID.randomUUID().toString(), Arrays.<MockGrpcService>asList(mockBuildService));
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
    BuildServiceSettings settings =
        BuildServiceSettings.newBuilder()
            .setTransportChannelProvider(channelProvider)
            .setCredentialsProvider(NoCredentialsProvider.create())
            .build();
    client = BuildServiceClient.create(settings);
  }

  @After
  public void tearDown() throws Exception {
    client.close();
  }

  @Test
  public void listBuildsTest() throws Exception {
    Build responsesElement = Build.newBuilder().build();
    ListBuildsResponse expectedResponse =
        ListBuildsResponse.newBuilder()
            .setNextPageToken("")
            .addAllBuilds(Arrays.asList(responsesElement))
            .build();
    mockBuildService.addResponse(expectedResponse);

    ModelName parent = ModelName.of("[BUILD_TARGET]", "[MODEL]");

    ListBuildsPagedResponse pagedListResponse = client.listBuilds(parent);

    List<Build> resources = Lists.newArrayList(pagedListResponse.iterateAll());

    Assert.assertEquals(1, resources.size());
    Assert.assertEquals(expectedResponse.getBuildsList().get(0), resources.get(0));

    List<AbstractMessage> actualRequests = mockBuildService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    ListBuildsRequest actualRequest = ((ListBuildsRequest) actualRequests.get(0));

    Assert.assertEquals(parent.toString(), actualRequest.getParent());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void listBuildsExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockBuildService.addException(exception);

    try {
      ModelName parent = ModelName.of("[BUILD_TARGET]", "[MODEL]");
      client.listBuilds(parent);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void listBuildsTest2() throws Exception {
    Build responsesElement = Build.newBuilder().build();
    ListBuildsResponse expectedResponse =
        ListBuildsResponse.newBuilder()
            .setNextPageToken("")
            .addAllBuilds(Arrays.asList(responsesElement))
            .build();
    mockBuildService.addResponse(expectedResponse);

    String parent = "parent-995424086";

    ListBuildsPagedResponse pagedListResponse = client.listBuilds(parent);

    List<Build> resources = Lists.newArrayList(pagedListResponse.iterateAll());

    Assert.assertEquals(1, resources.size());
    Assert.assertEquals(expectedResponse.getBuildsList().get(0), resources.get(0));

    List<AbstractMessage> actualRequests = mockBuildService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    ListBuildsRequest actualRequest = ((ListBuildsRequest) actualRequests.get(0));

    Assert.assertEquals(parent, actualRequest.getParent());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void listBuildsExceptionTest2() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockBuildService.addException(exception);

    try {
      String parent = "parent-995424086";
      client.listBuilds(parent);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void checkBuildStageStatusTest() throws Exception {
    CheckBuildStageStatusResponse expectedResponse =
        CheckBuildStageStatusResponse.newBuilder()
            .setIsBuildStaged(true)
            .setStagedBuildArtifact(BuildArtifact.newBuilder().build())
            .setSourceBuildArtifact(BuildArtifact.newBuilder().build())
            .build();
    mockBuildService.addResponse(expectedResponse);

    BuildArtifactName name =
        BuildArtifactName.of("[BUILD_TARGET]", "[MODEL]", "[BUILD]", "[ARTIFACT]");

    CheckBuildStageStatusResponse actualResponse = client.checkBuildStageStatus(name);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockBuildService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    CheckBuildStageStatusRequest actualRequest =
        ((CheckBuildStageStatusRequest) actualRequests.get(0));

    Assert.assertEquals(name.toString(), actualRequest.getName());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void checkBuildStageStatusExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockBuildService.addException(exception);

    try {
      BuildArtifactName name =
          BuildArtifactName.of("[BUILD_TARGET]", "[MODEL]", "[BUILD]", "[ARTIFACT]");
      client.checkBuildStageStatus(name);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void checkBuildStageStatusTest2() throws Exception {
    CheckBuildStageStatusResponse expectedResponse =
        CheckBuildStageStatusResponse.newBuilder()
            .setIsBuildStaged(true)
            .setStagedBuildArtifact(BuildArtifact.newBuilder().build())
            .setSourceBuildArtifact(BuildArtifact.newBuilder().build())
            .build();
    mockBuildService.addResponse(expectedResponse);

    String name = "name3373707";

    CheckBuildStageStatusResponse actualResponse = client.checkBuildStageStatus(name);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockBuildService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    CheckBuildStageStatusRequest actualRequest =
        ((CheckBuildStageStatusRequest) actualRequests.get(0));

    Assert.assertEquals(name, actualRequest.getName());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void checkBuildStageStatusExceptionTest2() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockBuildService.addException(exception);

    try {
      String name = "name3373707";
      client.checkBuildStageStatus(name);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void stageBuildTest() throws Exception {
    StageBuildResponse expectedResponse =
        StageBuildResponse.newBuilder()
            .setStagedBuildArtifact(BuildArtifact.newBuilder().build())
            .build();
    Operation resultOperation =
        Operation.newBuilder()
            .setName("stageBuildTest")
            .setDone(true)
            .setResponse(Any.pack(expectedResponse))
            .build();
    mockBuildService.addResponse(resultOperation);

    BuildArtifactName name =
        BuildArtifactName.of("[BUILD_TARGET]", "[MODEL]", "[BUILD]", "[ARTIFACT]");

    StageBuildResponse actualResponse = client.stageBuildAsync(name).get();
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockBuildService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    StageBuildRequest actualRequest = ((StageBuildRequest) actualRequests.get(0));

    Assert.assertEquals(name.toString(), actualRequest.getName());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void stageBuildExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockBuildService.addException(exception);

    try {
      BuildArtifactName name =
          BuildArtifactName.of("[BUILD_TARGET]", "[MODEL]", "[BUILD]", "[ARTIFACT]");
      client.stageBuildAsync(name).get();
      Assert.fail("No exception raised");
    } catch (ExecutionException e) {
      Assert.assertEquals(InvalidArgumentException.class, e.getCause().getClass());
      InvalidArgumentException apiException = ((InvalidArgumentException) e.getCause());
      Assert.assertEquals(StatusCode.Code.INVALID_ARGUMENT, apiException.getStatusCode().getCode());
    }
  }

  @Test
  public void stageBuildTest2() throws Exception {
    StageBuildResponse expectedResponse =
        StageBuildResponse.newBuilder()
            .setStagedBuildArtifact(BuildArtifact.newBuilder().build())
            .build();
    Operation resultOperation =
        Operation.newBuilder()
            .setName("stageBuildTest")
            .setDone(true)
            .setResponse(Any.pack(expectedResponse))
            .build();
    mockBuildService.addResponse(resultOperation);

    String name = "name3373707";

    StageBuildResponse actualResponse = client.stageBuildAsync(name).get();
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockBuildService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    StageBuildRequest actualRequest = ((StageBuildRequest) actualRequests.get(0));

    Assert.assertEquals(name, actualRequest.getName());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void stageBuildExceptionTest2() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockBuildService.addException(exception);

    try {
      String name = "name3373707";
      client.stageBuildAsync(name).get();
      Assert.fail("No exception raised");
    } catch (ExecutionException e) {
      Assert.assertEquals(InvalidArgumentException.class, e.getCause().getClass());
      InvalidArgumentException apiException = ((InvalidArgumentException) e.getCause());
      Assert.assertEquals(StatusCode.Code.INVALID_ARGUMENT, apiException.getStatusCode().getCode());
    }
  }
}
