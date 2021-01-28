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
import com.google.maps.unity.ClientInfo;
import com.google.protobuf.AbstractMessage;
import io.grpc.Status;
import io.grpc.StatusRuntimeException;
import java.io.IOException;
import java.util.ArrayList;
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
public class PlayableLocationsClientTest {
  private static MockPlayableLocations mockPlayableLocations;
  private static MockServiceHelper serviceHelper;
  private PlayableLocationsClient client;
  private LocalChannelProvider channelProvider;

  @BeforeClass
  public static void startStaticServer() {
    mockPlayableLocations = new MockPlayableLocations();
    serviceHelper =
        new MockServiceHelper(
            UUID.randomUUID().toString(), Arrays.<MockGrpcService>asList(mockPlayableLocations));
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
  @SuppressWarnings("all")
  public void samplePlayableLocationsTest() {
    SamplePlayableLocationsResponse expectedResponse =
        SamplePlayableLocationsResponse.newBuilder().build();
    mockPlayableLocations.addResponse(expectedResponse);

    AreaFilter areaFilter = AreaFilter.newBuilder().build();
    List<Criterion> criteria = new ArrayList<>();
    SamplePlayableLocationsRequest request =
        SamplePlayableLocationsRequest.newBuilder()
            .setAreaFilter(areaFilter)
            .addAllCriteria(criteria)
            .build();

    SamplePlayableLocationsResponse actualResponse = client.samplePlayableLocations(request);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockPlayableLocations.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    SamplePlayableLocationsRequest actualRequest =
        (SamplePlayableLocationsRequest) actualRequests.get(0);

    Assert.assertEquals(areaFilter, actualRequest.getAreaFilter());
    Assert.assertEquals(criteria, actualRequest.getCriteriaList());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  @SuppressWarnings("all")
  public void samplePlayableLocationsExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(Status.INVALID_ARGUMENT);
    mockPlayableLocations.addException(exception);

    try {
      AreaFilter areaFilter = AreaFilter.newBuilder().build();
      List<Criterion> criteria = new ArrayList<>();
      SamplePlayableLocationsRequest request =
          SamplePlayableLocationsRequest.newBuilder()
              .setAreaFilter(areaFilter)
              .addAllCriteria(criteria)
              .build();

      client.samplePlayableLocations(request);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception
    }
  }

  @Test
  @SuppressWarnings("all")
  public void logPlayerReportsTest() {
    LogPlayerReportsResponse expectedResponse = LogPlayerReportsResponse.newBuilder().build();
    mockPlayableLocations.addResponse(expectedResponse);

    List<PlayerReport> playerReports = new ArrayList<>();
    String requestId = "requestId37109963";
    ClientInfo clientInfo = ClientInfo.newBuilder().build();
    LogPlayerReportsRequest request =
        LogPlayerReportsRequest.newBuilder()
            .addAllPlayerReports(playerReports)
            .setRequestId(requestId)
            .setClientInfo(clientInfo)
            .build();

    LogPlayerReportsResponse actualResponse = client.logPlayerReports(request);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockPlayableLocations.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    LogPlayerReportsRequest actualRequest = (LogPlayerReportsRequest) actualRequests.get(0);

    Assert.assertEquals(playerReports, actualRequest.getPlayerReportsList());
    Assert.assertEquals(requestId, actualRequest.getRequestId());
    Assert.assertEquals(clientInfo, actualRequest.getClientInfo());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  @SuppressWarnings("all")
  public void logPlayerReportsExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(Status.INVALID_ARGUMENT);
    mockPlayableLocations.addException(exception);

    try {
      List<PlayerReport> playerReports = new ArrayList<>();
      String requestId = "requestId37109963";
      ClientInfo clientInfo = ClientInfo.newBuilder().build();
      LogPlayerReportsRequest request =
          LogPlayerReportsRequest.newBuilder()
              .addAllPlayerReports(playerReports)
              .setRequestId(requestId)
              .setClientInfo(clientInfo)
              .build();

      client.logPlayerReports(request);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception
    }
  }

  @Test
  @SuppressWarnings("all")
  public void logImpressionsTest() {
    LogImpressionsResponse expectedResponse = LogImpressionsResponse.newBuilder().build();
    mockPlayableLocations.addResponse(expectedResponse);

    List<Impression> impressions = new ArrayList<>();
    String requestId = "requestId37109963";
    ClientInfo clientInfo = ClientInfo.newBuilder().build();
    LogImpressionsRequest request =
        LogImpressionsRequest.newBuilder()
            .addAllImpressions(impressions)
            .setRequestId(requestId)
            .setClientInfo(clientInfo)
            .build();

    LogImpressionsResponse actualResponse = client.logImpressions(request);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockPlayableLocations.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    LogImpressionsRequest actualRequest = (LogImpressionsRequest) actualRequests.get(0);

    Assert.assertEquals(impressions, actualRequest.getImpressionsList());
    Assert.assertEquals(requestId, actualRequest.getRequestId());
    Assert.assertEquals(clientInfo, actualRequest.getClientInfo());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  @SuppressWarnings("all")
  public void logImpressionsExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(Status.INVALID_ARGUMENT);
    mockPlayableLocations.addException(exception);

    try {
      List<Impression> impressions = new ArrayList<>();
      String requestId = "requestId37109963";
      ClientInfo clientInfo = ClientInfo.newBuilder().build();
      LogImpressionsRequest request =
          LogImpressionsRequest.newBuilder()
              .addAllImpressions(impressions)
              .setRequestId(requestId)
              .setClientInfo(clientInfo)
              .build();

      client.logImpressions(request);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception
    }
  }
}
