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

package com.google.geo.ugc.streetview.publish.v1;

import static com.google.geo.ugc.streetview.publish.v1.StreetViewPublishServiceClient.ListPhotosPagedResponse;

import com.google.api.gax.core.NoCredentialsProvider;
import com.google.api.gax.grpc.GaxGrpcProperties;
import com.google.api.gax.grpc.testing.LocalChannelProvider;
import com.google.api.gax.grpc.testing.MockGrpcService;
import com.google.api.gax.grpc.testing.MockServiceHelper;
import com.google.api.gax.rpc.ApiClientHeaderProvider;
import com.google.api.gax.rpc.InvalidArgumentException;
import com.google.common.collect.Lists;
import com.google.protobuf.AbstractMessage;
import com.google.protobuf.Empty;
import com.google.protobuf.FieldMask;
import com.google.protobuf.Timestamp;
import com.google.rpc.Status;
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
public class StreetViewPublishServiceClientTest {
  private static MockStreetViewPublishService mockStreetViewPublishService;
  private static MockServiceHelper mockServiceHelper;
  private StreetViewPublishServiceClient client;
  private LocalChannelProvider channelProvider;

  @BeforeClass
  public static void startStaticServer() {
    mockStreetViewPublishService = new MockStreetViewPublishService();
    mockServiceHelper =
        new MockServiceHelper(
            UUID.randomUUID().toString(),
            Arrays.<MockGrpcService>asList(mockStreetViewPublishService));
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
    StreetViewPublishServiceSettings settings =
        StreetViewPublishServiceSettings.newBuilder()
            .setTransportChannelProvider(channelProvider)
            .setCredentialsProvider(NoCredentialsProvider.create())
            .build();
    client = StreetViewPublishServiceClient.create(settings);
  }

  @After
  public void tearDown() throws Exception {
    client.close();
  }

  @Test
  public void startUploadTest() throws Exception {
    StreetViewPublishResources.UploadRef expectedResponse =
        StreetViewPublishResources.UploadRef.newBuilder()
            .setUploadUrl("uploadUrl1239085998")
            .build();
    mockStreetViewPublishService.addResponse(expectedResponse);

    Empty request = Empty.newBuilder().build();

    StreetViewPublishResources.UploadRef actualResponse = client.startUpload(request);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockStreetViewPublishService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    Empty actualRequest = ((Empty) actualRequests.get(0));

    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void startUploadExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockStreetViewPublishService.addException(exception);

    try {
      Empty request = Empty.newBuilder().build();
      client.startUpload(request);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void createPhotoTest() throws Exception {
    StreetViewPublishResources.Photo expectedResponse =
        StreetViewPublishResources.Photo.newBuilder()
            .setPhotoId(StreetViewPublishResources.PhotoId.newBuilder().build())
            .setUploadReference(StreetViewPublishResources.UploadRef.newBuilder().build())
            .setDownloadUrl("downloadUrl-1211148345")
            .setThumbnailUrl("thumbnailUrl-356760349")
            .setShareLink("shareLink-1582273415")
            .setPose(StreetViewPublishResources.Pose.newBuilder().build())
            .addAllConnections(new ArrayList<StreetViewPublishResources.Connection>())
            .setCaptureTime(Timestamp.newBuilder().build())
            .addAllPlaces(new ArrayList<StreetViewPublishResources.Place>())
            .setViewCount(-1534353675)
            .build();
    mockStreetViewPublishService.addResponse(expectedResponse);

    StreetViewPublishResources.Photo photo = StreetViewPublishResources.Photo.newBuilder().build();

    StreetViewPublishResources.Photo actualResponse = client.createPhoto(photo);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockStreetViewPublishService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    StreetViewPublishRpcMessages.CreatePhotoRequest actualRequest =
        ((StreetViewPublishRpcMessages.CreatePhotoRequest) actualRequests.get(0));

    Assert.assertEquals(photo, actualRequest.getPhoto());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void createPhotoExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockStreetViewPublishService.addException(exception);

    try {
      StreetViewPublishResources.Photo photo =
          StreetViewPublishResources.Photo.newBuilder().build();
      client.createPhoto(photo);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void getPhotoTest() throws Exception {
    StreetViewPublishResources.Photo expectedResponse =
        StreetViewPublishResources.Photo.newBuilder()
            .setPhotoId(StreetViewPublishResources.PhotoId.newBuilder().build())
            .setUploadReference(StreetViewPublishResources.UploadRef.newBuilder().build())
            .setDownloadUrl("downloadUrl-1211148345")
            .setThumbnailUrl("thumbnailUrl-356760349")
            .setShareLink("shareLink-1582273415")
            .setPose(StreetViewPublishResources.Pose.newBuilder().build())
            .addAllConnections(new ArrayList<StreetViewPublishResources.Connection>())
            .setCaptureTime(Timestamp.newBuilder().build())
            .addAllPlaces(new ArrayList<StreetViewPublishResources.Place>())
            .setViewCount(-1534353675)
            .build();
    mockStreetViewPublishService.addResponse(expectedResponse);

    String photoId = "photoId-595295507";
    StreetViewPublishRpcMessages.PhotoView view =
        StreetViewPublishRpcMessages.PhotoView.forNumber(0);

    StreetViewPublishResources.Photo actualResponse = client.getPhoto(photoId, view);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockStreetViewPublishService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    StreetViewPublishRpcMessages.GetPhotoRequest actualRequest =
        ((StreetViewPublishRpcMessages.GetPhotoRequest) actualRequests.get(0));

    Assert.assertEquals(photoId, actualRequest.getPhotoId());
    Assert.assertEquals(view, actualRequest.getView());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void getPhotoExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockStreetViewPublishService.addException(exception);

    try {
      String photoId = "photoId-595295507";
      StreetViewPublishRpcMessages.PhotoView view =
          StreetViewPublishRpcMessages.PhotoView.forNumber(0);
      client.getPhoto(photoId, view);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void batchGetPhotosTest() throws Exception {
    StreetViewPublishRpcMessages.BatchGetPhotosResponse expectedResponse =
        StreetViewPublishRpcMessages.BatchGetPhotosResponse.newBuilder()
            .addAllResults(new ArrayList<StreetViewPublishRpcMessages.PhotoResponse>())
            .build();
    mockStreetViewPublishService.addResponse(expectedResponse);

    List<String> photoIds = new ArrayList<>();
    StreetViewPublishRpcMessages.PhotoView view =
        StreetViewPublishRpcMessages.PhotoView.forNumber(0);

    StreetViewPublishRpcMessages.BatchGetPhotosResponse actualResponse =
        client.batchGetPhotos(photoIds, view);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockStreetViewPublishService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    StreetViewPublishRpcMessages.BatchGetPhotosRequest actualRequest =
        ((StreetViewPublishRpcMessages.BatchGetPhotosRequest) actualRequests.get(0));

    Assert.assertEquals(photoIds, actualRequest.getPhotoIdsList());
    Assert.assertEquals(view, actualRequest.getView());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void batchGetPhotosExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockStreetViewPublishService.addException(exception);

    try {
      List<String> photoIds = new ArrayList<>();
      StreetViewPublishRpcMessages.PhotoView view =
          StreetViewPublishRpcMessages.PhotoView.forNumber(0);
      client.batchGetPhotos(photoIds, view);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void listPhotosTest() throws Exception {
    StreetViewPublishResources.Photo responsesElement =
        StreetViewPublishResources.Photo.newBuilder().build();
    StreetViewPublishRpcMessages.ListPhotosResponse expectedResponse =
        StreetViewPublishRpcMessages.ListPhotosResponse.newBuilder()
            .setNextPageToken("")
            .addAllPhotos(Arrays.asList(responsesElement))
            .build();
    mockStreetViewPublishService.addResponse(expectedResponse);

    StreetViewPublishRpcMessages.PhotoView view =
        StreetViewPublishRpcMessages.PhotoView.forNumber(0);
    String filter = "filter-1274492040";

    ListPhotosPagedResponse pagedListResponse = client.listPhotos(view, filter);

    List<StreetViewPublishResources.Photo> resources =
        Lists.newArrayList(pagedListResponse.iterateAll());

    Assert.assertEquals(1, resources.size());
    Assert.assertEquals(expectedResponse.getPhotosList().get(0), resources.get(0));

    List<AbstractMessage> actualRequests = mockStreetViewPublishService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    StreetViewPublishRpcMessages.ListPhotosRequest actualRequest =
        ((StreetViewPublishRpcMessages.ListPhotosRequest) actualRequests.get(0));

    Assert.assertEquals(view, actualRequest.getView());
    Assert.assertEquals(filter, actualRequest.getFilter());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void listPhotosExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockStreetViewPublishService.addException(exception);

    try {
      StreetViewPublishRpcMessages.PhotoView view =
          StreetViewPublishRpcMessages.PhotoView.forNumber(0);
      String filter = "filter-1274492040";
      client.listPhotos(view, filter);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void updatePhotoTest() throws Exception {
    StreetViewPublishResources.Photo expectedResponse =
        StreetViewPublishResources.Photo.newBuilder()
            .setPhotoId(StreetViewPublishResources.PhotoId.newBuilder().build())
            .setUploadReference(StreetViewPublishResources.UploadRef.newBuilder().build())
            .setDownloadUrl("downloadUrl-1211148345")
            .setThumbnailUrl("thumbnailUrl-356760349")
            .setShareLink("shareLink-1582273415")
            .setPose(StreetViewPublishResources.Pose.newBuilder().build())
            .addAllConnections(new ArrayList<StreetViewPublishResources.Connection>())
            .setCaptureTime(Timestamp.newBuilder().build())
            .addAllPlaces(new ArrayList<StreetViewPublishResources.Place>())
            .setViewCount(-1534353675)
            .build();
    mockStreetViewPublishService.addResponse(expectedResponse);

    StreetViewPublishResources.Photo photo = StreetViewPublishResources.Photo.newBuilder().build();
    FieldMask updateMask = FieldMask.newBuilder().build();

    StreetViewPublishResources.Photo actualResponse = client.updatePhoto(photo, updateMask);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockStreetViewPublishService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    StreetViewPublishRpcMessages.UpdatePhotoRequest actualRequest =
        ((StreetViewPublishRpcMessages.UpdatePhotoRequest) actualRequests.get(0));

    Assert.assertEquals(photo, actualRequest.getPhoto());
    Assert.assertEquals(updateMask, actualRequest.getUpdateMask());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void updatePhotoExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockStreetViewPublishService.addException(exception);

    try {
      StreetViewPublishResources.Photo photo =
          StreetViewPublishResources.Photo.newBuilder().build();
      FieldMask updateMask = FieldMask.newBuilder().build();
      client.updatePhoto(photo, updateMask);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void batchUpdatePhotosTest() throws Exception {
    StreetViewPublishRpcMessages.BatchUpdatePhotosResponse expectedResponse =
        StreetViewPublishRpcMessages.BatchUpdatePhotosResponse.newBuilder()
            .addAllResults(new ArrayList<StreetViewPublishRpcMessages.PhotoResponse>())
            .build();
    mockStreetViewPublishService.addResponse(expectedResponse);

    List<StreetViewPublishRpcMessages.UpdatePhotoRequest> updatePhotoRequests = new ArrayList<>();

    StreetViewPublishRpcMessages.BatchUpdatePhotosResponse actualResponse =
        client.batchUpdatePhotos(updatePhotoRequests);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockStreetViewPublishService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    StreetViewPublishRpcMessages.BatchUpdatePhotosRequest actualRequest =
        ((StreetViewPublishRpcMessages.BatchUpdatePhotosRequest) actualRequests.get(0));

    Assert.assertEquals(updatePhotoRequests, actualRequest.getUpdatePhotoRequestsList());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void batchUpdatePhotosExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockStreetViewPublishService.addException(exception);

    try {
      List<StreetViewPublishRpcMessages.UpdatePhotoRequest> updatePhotoRequests = new ArrayList<>();
      client.batchUpdatePhotos(updatePhotoRequests);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void deletePhotoTest() throws Exception {
    Empty expectedResponse = Empty.newBuilder().build();
    mockStreetViewPublishService.addResponse(expectedResponse);

    String photoId = "photoId-595295507";

    client.deletePhoto(photoId);

    List<AbstractMessage> actualRequests = mockStreetViewPublishService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    StreetViewPublishRpcMessages.DeletePhotoRequest actualRequest =
        ((StreetViewPublishRpcMessages.DeletePhotoRequest) actualRequests.get(0));

    Assert.assertEquals(photoId, actualRequest.getPhotoId());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void deletePhotoExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockStreetViewPublishService.addException(exception);

    try {
      String photoId = "photoId-595295507";
      client.deletePhoto(photoId);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void batchDeletePhotosTest() throws Exception {
    StreetViewPublishRpcMessages.BatchDeletePhotosResponse expectedResponse =
        StreetViewPublishRpcMessages.BatchDeletePhotosResponse.newBuilder()
            .addAllStatus(new ArrayList<Status>())
            .build();
    mockStreetViewPublishService.addResponse(expectedResponse);

    List<String> photoIds = new ArrayList<>();

    StreetViewPublishRpcMessages.BatchDeletePhotosResponse actualResponse =
        client.batchDeletePhotos(photoIds);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockStreetViewPublishService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    StreetViewPublishRpcMessages.BatchDeletePhotosRequest actualRequest =
        ((StreetViewPublishRpcMessages.BatchDeletePhotosRequest) actualRequests.get(0));

    Assert.assertEquals(photoIds, actualRequest.getPhotoIdsList());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void batchDeletePhotosExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockStreetViewPublishService.addException(exception);

    try {
      List<String> photoIds = new ArrayList<>();
      client.batchDeletePhotos(photoIds);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }
}
