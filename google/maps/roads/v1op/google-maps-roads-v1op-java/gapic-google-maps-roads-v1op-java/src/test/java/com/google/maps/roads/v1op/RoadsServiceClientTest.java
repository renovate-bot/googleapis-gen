/*
 * Copyright 2020 Google LLC
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     https://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
package com.google.maps.roads.v1op;

import com.google.api.gax.core.NoCredentialsProvider;
import com.google.api.gax.grpc.GaxGrpcProperties;
import com.google.api.gax.grpc.testing.LocalChannelProvider;
import com.google.api.gax.grpc.testing.MockGrpcService;
import com.google.api.gax.grpc.testing.MockServiceHelper;
import com.google.api.gax.rpc.ApiClientHeaderProvider;
import com.google.api.gax.rpc.InvalidArgumentException;
import com.google.protobuf.AbstractMessage;
import io.grpc.Status;
import io.grpc.StatusRuntimeException;
import java.io.IOException;
import java.util.Arrays;
import java.util.List;
import java.util.UUID;
import org.junit.After;
import org.junit.AfterClass;
import org.junit.Assert;
import org.junit.Before;
import org.junit.BeforeClass;
import org.junit.Test;

@javax.annotation.Generated("by GAPIC")
public class RoadsServiceClientTest {
  private static MockRoadsService mockRoadsService;
  private static MockServiceHelper serviceHelper;
  private RoadsServiceClient client;
  private LocalChannelProvider channelProvider;

  @BeforeClass
  public static void startStaticServer() {
    mockRoadsService = new MockRoadsService();
    serviceHelper =
        new MockServiceHelper(
            UUID.randomUUID().toString(), Arrays.<MockGrpcService>asList(mockRoadsService));
    serviceHelper.start();
  }

  @AfterClass
  public static void stopServer() {
    serviceHelper.stop();
  }

  @Before
  public void setUp() throws IOException {
    serviceHelper.reset();
    channelProvider = serviceHelper.createChannelProvider();
    RoadsServiceSettings settings =
        RoadsServiceSettings.newBuilder()
            .setTransportChannelProvider(channelProvider)
            .setCredentialsProvider(NoCredentialsProvider.create())
            .build();
    client = RoadsServiceClient.create(settings);
  }

  @After
  public void tearDown() throws Exception {
    client.close();
  }

  @Test
  @SuppressWarnings("all")
  public void snapToRoadsTest() {
    String warningMessage = "warningMessage1427438180";
    SnapToRoadsResponse expectedResponse =
        SnapToRoadsResponse.newBuilder().setWarningMessage(warningMessage).build();
    mockRoadsService.addResponse(expectedResponse);

    String path = "path3433509";
    SnapToRoadsRequest request = SnapToRoadsRequest.newBuilder().setPath(path).build();

    SnapToRoadsResponse actualResponse = client.snapToRoads(request);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockRoadsService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    SnapToRoadsRequest actualRequest = (SnapToRoadsRequest) actualRequests.get(0);

    Assert.assertEquals(path, actualRequest.getPath());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  @SuppressWarnings("all")
  public void snapToRoadsExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(Status.INVALID_ARGUMENT);
    mockRoadsService.addException(exception);

    try {
      String path = "path3433509";
      SnapToRoadsRequest request = SnapToRoadsRequest.newBuilder().setPath(path).build();

      client.snapToRoads(request);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception
    }
  }

  @Test
  @SuppressWarnings("all")
  public void listNearestRoadsTest() {
    ListNearestRoadsResponse expectedResponse = ListNearestRoadsResponse.newBuilder().build();
    mockRoadsService.addResponse(expectedResponse);

    String points = "points-982754077";
    ListNearestRoadsRequest request =
        ListNearestRoadsRequest.newBuilder().setPoints(points).build();

    ListNearestRoadsResponse actualResponse = client.listNearestRoads(request);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockRoadsService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    ListNearestRoadsRequest actualRequest = (ListNearestRoadsRequest) actualRequests.get(0);

    Assert.assertEquals(points, actualRequest.getPoints());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  @SuppressWarnings("all")
  public void listNearestRoadsExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(Status.INVALID_ARGUMENT);
    mockRoadsService.addException(exception);

    try {
      String points = "points-982754077";
      ListNearestRoadsRequest request =
          ListNearestRoadsRequest.newBuilder().setPoints(points).build();

      client.listNearestRoads(request);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception
    }
  }
}
