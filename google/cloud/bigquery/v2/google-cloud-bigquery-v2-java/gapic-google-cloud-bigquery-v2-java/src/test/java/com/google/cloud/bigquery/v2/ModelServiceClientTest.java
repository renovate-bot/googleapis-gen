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

package com.google.cloud.bigquery.v2;

import com.google.api.gax.core.NoCredentialsProvider;
import com.google.api.gax.grpc.GaxGrpcProperties;
import com.google.api.gax.grpc.testing.LocalChannelProvider;
import com.google.api.gax.grpc.testing.MockGrpcService;
import com.google.api.gax.grpc.testing.MockServiceHelper;
import com.google.api.gax.rpc.ApiClientHeaderProvider;
import com.google.api.gax.rpc.InvalidArgumentException;
import com.google.protobuf.AbstractMessage;
import com.google.protobuf.Empty;
import com.google.protobuf.UInt32Value;
import io.grpc.StatusRuntimeException;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.HashMap;
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
public class ModelServiceClientTest {
  private static MockModelService mockModelService;
  private static MockServiceHelper mockServiceHelper;
  private LocalChannelProvider channelProvider;
  private ModelServiceClient client;

  @BeforeClass
  public static void startStaticServer() {
    mockModelService = new MockModelService();
    mockServiceHelper =
        new MockServiceHelper(
            UUID.randomUUID().toString(), Arrays.<MockGrpcService>asList(mockModelService));
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
    ModelServiceSettings settings =
        ModelServiceSettings.newBuilder()
            .setTransportChannelProvider(channelProvider)
            .setCredentialsProvider(NoCredentialsProvider.create())
            .build();
    client = ModelServiceClient.create(settings);
  }

  @After
  public void tearDown() throws Exception {
    client.close();
  }

  @Test
  public void getModelTest() throws Exception {
    ModelProto.Model expectedResponse =
        ModelProto.Model.newBuilder()
            .setEtag("etag3123477")
            .setModelReference(ModelReferenceProto.ModelReference.newBuilder().build())
            .setCreationTime(1932333101)
            .setLastModifiedTime(-671513446)
            .setDescription("description-1724546052")
            .setFriendlyName("friendlyName461933014")
            .putAllLabels(new HashMap<String, String>())
            .setExpirationTime(767170141)
            .setLocation("location1901043637")
            .setEncryptionConfiguration(
                EncryptionConfigProto.EncryptionConfiguration.newBuilder().build())
            .addAllTrainingRuns(new ArrayList<ModelProto.Model.TrainingRun>())
            .addAllFeatureColumns(new ArrayList<StandardSqlProto.StandardSqlField>())
            .addAllLabelColumns(new ArrayList<StandardSqlProto.StandardSqlField>())
            .build();
    mockModelService.addResponse(expectedResponse);

    String projectId = "projectId-894832108";
    String datasetId = "datasetId-345342029";
    String modelId = "modelId1226956324";

    ModelProto.Model actualResponse = client.getModel(projectId, datasetId, modelId);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockModelService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    ModelProto.GetModelRequest actualRequest = ((ModelProto.GetModelRequest) actualRequests.get(0));

    Assert.assertEquals(projectId, actualRequest.getProjectId());
    Assert.assertEquals(datasetId, actualRequest.getDatasetId());
    Assert.assertEquals(modelId, actualRequest.getModelId());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void getModelExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockModelService.addException(exception);

    try {
      String projectId = "projectId-894832108";
      String datasetId = "datasetId-345342029";
      String modelId = "modelId1226956324";
      client.getModel(projectId, datasetId, modelId);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void listModelsTest() throws Exception {
    ModelProto.ListModelsResponse expectedResponse =
        ModelProto.ListModelsResponse.newBuilder()
            .addAllModels(new ArrayList<ModelProto.Model>())
            .setNextPageToken("nextPageToken-1386094857")
            .build();
    mockModelService.addResponse(expectedResponse);

    String projectId = "projectId-894832108";
    String datasetId = "datasetId-345342029";
    UInt32Value maxResults = UInt32Value.newBuilder().build();

    ModelProto.ListModelsResponse actualResponse =
        client.listModels(projectId, datasetId, maxResults);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockModelService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    ModelProto.ListModelsRequest actualRequest =
        ((ModelProto.ListModelsRequest) actualRequests.get(0));

    Assert.assertEquals(projectId, actualRequest.getProjectId());
    Assert.assertEquals(datasetId, actualRequest.getDatasetId());
    Assert.assertEquals(maxResults, actualRequest.getMaxResults());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void listModelsExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockModelService.addException(exception);

    try {
      String projectId = "projectId-894832108";
      String datasetId = "datasetId-345342029";
      UInt32Value maxResults = UInt32Value.newBuilder().build();
      client.listModels(projectId, datasetId, maxResults);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void patchModelTest() throws Exception {
    ModelProto.Model expectedResponse =
        ModelProto.Model.newBuilder()
            .setEtag("etag3123477")
            .setModelReference(ModelReferenceProto.ModelReference.newBuilder().build())
            .setCreationTime(1932333101)
            .setLastModifiedTime(-671513446)
            .setDescription("description-1724546052")
            .setFriendlyName("friendlyName461933014")
            .putAllLabels(new HashMap<String, String>())
            .setExpirationTime(767170141)
            .setLocation("location1901043637")
            .setEncryptionConfiguration(
                EncryptionConfigProto.EncryptionConfiguration.newBuilder().build())
            .addAllTrainingRuns(new ArrayList<ModelProto.Model.TrainingRun>())
            .addAllFeatureColumns(new ArrayList<StandardSqlProto.StandardSqlField>())
            .addAllLabelColumns(new ArrayList<StandardSqlProto.StandardSqlField>())
            .build();
    mockModelService.addResponse(expectedResponse);

    String projectId = "projectId-894832108";
    String datasetId = "datasetId-345342029";
    String modelId = "modelId1226956324";
    ModelProto.Model model = ModelProto.Model.newBuilder().build();

    ModelProto.Model actualResponse = client.patchModel(projectId, datasetId, modelId, model);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockModelService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    ModelProto.PatchModelRequest actualRequest =
        ((ModelProto.PatchModelRequest) actualRequests.get(0));

    Assert.assertEquals(projectId, actualRequest.getProjectId());
    Assert.assertEquals(datasetId, actualRequest.getDatasetId());
    Assert.assertEquals(modelId, actualRequest.getModelId());
    Assert.assertEquals(model, actualRequest.getModel());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void patchModelExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockModelService.addException(exception);

    try {
      String projectId = "projectId-894832108";
      String datasetId = "datasetId-345342029";
      String modelId = "modelId1226956324";
      ModelProto.Model model = ModelProto.Model.newBuilder().build();
      client.patchModel(projectId, datasetId, modelId, model);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void deleteModelTest() throws Exception {
    Empty expectedResponse = Empty.newBuilder().build();
    mockModelService.addResponse(expectedResponse);

    String projectId = "projectId-894832108";
    String datasetId = "datasetId-345342029";
    String modelId = "modelId1226956324";

    client.deleteModel(projectId, datasetId, modelId);

    List<AbstractMessage> actualRequests = mockModelService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    ModelProto.DeleteModelRequest actualRequest =
        ((ModelProto.DeleteModelRequest) actualRequests.get(0));

    Assert.assertEquals(projectId, actualRequest.getProjectId());
    Assert.assertEquals(datasetId, actualRequest.getDatasetId());
    Assert.assertEquals(modelId, actualRequest.getModelId());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void deleteModelExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockModelService.addException(exception);

    try {
      String projectId = "projectId-894832108";
      String datasetId = "datasetId-345342029";
      String modelId = "modelId1226956324";
      client.deleteModel(projectId, datasetId, modelId);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }
}
