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

package com.google.maps.roads.v1op;

import com.google.api.gax.core.NoCredentialsProvider;
import com.google.api.gax.grpc.GaxGrpcProperties;
import com.google.api.gax.grpc.testing.LocalChannelProvider;
import com.google.api.gax.grpc.testing.MockGrpcService;
import com.google.api.gax.grpc.testing.MockServiceHelper;
import com.google.api.gax.rpc.ApiClientHeaderProvider;
import com.google.api.gax.rpc.InvalidArgumentException;
import com.google.protobuf.AbstractMessage;
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
public class RoadsServiceClientTest {
  private static MockServiceHelper mockServiceHelper;
  private static MockRoadsService mockRoadsService;
  private RoadsServiceClient client;
  private LocalChannelProvider channelProvider;

  @BeforeClass
  public static void startStaticServer() {
    mockRoadsService = new MockRoadsService();
    mockServiceHelper =
        new MockServiceHelper(
            UUID.randomUUID().toString(), Arrays.<MockGrpcService>asList(mockRoadsService));
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
  public void snapToRoadsTest() throws Exception {
    SnapToRoadsResponse expectedResponse =
        SnapToRoadsResponse.newBuilder()
            .addAllSnappedPoints(new ArrayList<SnappedPoint>())
            .setWarningMessage("warningMessage341991627")
            .build();
    mockRoadsService.addResponse(expectedResponse);

    String path = "path3433509";

    SnapToRoadsResponse actualResponse = client.snapToRoads(path);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockRoadsService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    SnapToRoadsRequest actualRequest = ((SnapToRoadsRequest) actualRequests.get(0));

    Assert.assertEquals(path, actualRequest.getPath());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void snapToRoadsExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockRoadsService.addException(exception);

    try {
      String path = "path3433509";
      client.snapToRoads(path);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void listNearestRoadsTest() throws Exception {
    ListNearestRoadsResponse expectedResponse =
        ListNearestRoadsResponse.newBuilder()
            .addAllSnappedPoints(new ArrayList<SnappedPoint>())
            .build();
    mockRoadsService.addResponse(expectedResponse);

    String points = "points-982754077";

    ListNearestRoadsResponse actualResponse = client.listNearestRoads(points);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockRoadsService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    ListNearestRoadsRequest actualRequest = ((ListNearestRoadsRequest) actualRequests.get(0));

    Assert.assertEquals(points, actualRequest.getPoints());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void listNearestRoadsExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockRoadsService.addException(exception);

    try {
      String points = "points-982754077";
      client.listNearestRoads(points);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }
}
