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

package com.google.maps.playablelocations.v3;

import com.google.api.gax.core.NoCredentialsProvider;
import com.google.api.gax.grpc.GaxGrpcProperties;
import com.google.api.gax.grpc.testing.LocalChannelProvider;
import com.google.api.gax.grpc.testing.MockGrpcService;
import com.google.api.gax.grpc.testing.MockServiceHelper;
import com.google.api.gax.rpc.ApiClientHeaderProvider;
import com.google.api.gax.rpc.InvalidArgumentException;
import com.google.maps.playablelocations.v3.sample.AreaFilter;
import com.google.maps.playablelocations.v3.sample.Criterion;
import com.google.maps.playablelocations.v3.sample.PlayableLocationList;
import com.google.maps.unity.ClientInfo;
import com.google.protobuf.AbstractMessage;
import com.google.protobuf.Duration;
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
public class PlayableLocationsClientTest {
  private static MockPlayableLocations mockPlayableLocations;
  private static MockServiceHelper mockServiceHelper;
  private LocalChannelProvider channelProvider;
  private PlayableLocationsClient client;

  @BeforeClass
  public static void startStaticServer() {
    mockPlayableLocations = new MockPlayableLocations();
    mockServiceHelper =
        new MockServiceHelper(
            UUID.randomUUID().toString(), Arrays.<MockGrpcService>asList(mockPlayableLocations));
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
    PlayableLocationsSettings settings =
        PlayableLocationsSettings.newBuilder()
            .setTransportChannelProvider(channelProvider)
            .setCredentialsProvider(NoCredentialsProvider.create())
            .build();
    client = PlayableLocationsClient.create(settings);
  }

  @After
  public void tearDown() throws Exception {
    client.close();
  }

  @Test
  public void samplePlayableLocationsTest() throws Exception {
    SamplePlayableLocationsResponse expectedResponse =
        SamplePlayableLocationsResponse.newBuilder()
            .putAllLocationsPerGameObjectType(new HashMap<Integer, PlayableLocationList>())
            .setTtl(Duration.newBuilder().build())
            .build();
    mockPlayableLocations.addResponse(expectedResponse);

    SamplePlayableLocationsRequest request =
        SamplePlayableLocationsRequest.newBuilder()
            .setAreaFilter(AreaFilter.newBuilder().build())
            .addAllCriteria(new ArrayList<Criterion>())
            .build();

    SamplePlayableLocationsResponse actualResponse = client.samplePlayableLocations(request);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockPlayableLocations.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    SamplePlayableLocationsRequest actualRequest =
        ((SamplePlayableLocationsRequest) actualRequests.get(0));

    Assert.assertEquals(request.getAreaFilter(), actualRequest.getAreaFilter());
    Assert.assertEquals(request.getCriteriaList(), actualRequest.getCriteriaList());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void samplePlayableLocationsExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockPlayableLocations.addException(exception);

    try {
      SamplePlayableLocationsRequest request =
          SamplePlayableLocationsRequest.newBuilder()
              .setAreaFilter(AreaFilter.newBuilder().build())
              .addAllCriteria(new ArrayList<Criterion>())
              .build();
      client.samplePlayableLocations(request);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void logPlayerReportsTest() throws Exception {
    LogPlayerReportsResponse expectedResponse = LogPlayerReportsResponse.newBuilder().build();
    mockPlayableLocations.addResponse(expectedResponse);

    LogPlayerReportsRequest request =
        LogPlayerReportsRequest.newBuilder()
            .addAllPlayerReports(new ArrayList<PlayerReport>())
            .setRequestId("requestId693933066")
            .setClientInfo(ClientInfo.newBuilder().build())
            .build();

    LogPlayerReportsResponse actualResponse = client.logPlayerReports(request);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockPlayableLocations.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    LogPlayerReportsRequest actualRequest = ((LogPlayerReportsRequest) actualRequests.get(0));

    Assert.assertEquals(request.getPlayerReportsList(), actualRequest.getPlayerReportsList());
    Assert.assertEquals(request.getRequestId(), actualRequest.getRequestId());
    Assert.assertEquals(request.getClientInfo(), actualRequest.getClientInfo());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void logPlayerReportsExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockPlayableLocations.addException(exception);

    try {
      LogPlayerReportsRequest request =
          LogPlayerReportsRequest.newBuilder()
              .addAllPlayerReports(new ArrayList<PlayerReport>())
              .setRequestId("requestId693933066")
              .setClientInfo(ClientInfo.newBuilder().build())
              .build();
      client.logPlayerReports(request);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void logImpressionsTest() throws Exception {
    LogImpressionsResponse expectedResponse = LogImpressionsResponse.newBuilder().build();
    mockPlayableLocations.addResponse(expectedResponse);

    LogImpressionsRequest request =
        LogImpressionsRequest.newBuilder()
            .addAllImpressions(new ArrayList<Impression>())
            .setRequestId("requestId693933066")
            .setClientInfo(ClientInfo.newBuilder().build())
            .build();

    LogImpressionsResponse actualResponse = client.logImpressions(request);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockPlayableLocations.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    LogImpressionsRequest actualRequest = ((LogImpressionsRequest) actualRequests.get(0));

    Assert.assertEquals(request.getImpressionsList(), actualRequest.getImpressionsList());
    Assert.assertEquals(request.getRequestId(), actualRequest.getRequestId());
    Assert.assertEquals(request.getClientInfo(), actualRequest.getClientInfo());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void logImpressionsExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockPlayableLocations.addException(exception);

    try {
      LogImpressionsRequest request =
          LogImpressionsRequest.newBuilder()
              .addAllImpressions(new ArrayList<Impression>())
              .setRequestId("requestId693933066")
              .setClientInfo(ClientInfo.newBuilder().build())
              .build();
      client.logImpressions(request);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }
}
