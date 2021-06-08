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

package com.google.ads.admob.v1;

import static com.google.ads.admob.v1.AdMobApiClient.ListPublisherAccountsPagedResponse;

import com.google.api.gax.core.NoCredentialsProvider;
import com.google.api.gax.grpc.GaxGrpcProperties;
import com.google.api.gax.grpc.testing.LocalChannelProvider;
import com.google.api.gax.grpc.testing.MockGrpcService;
import com.google.api.gax.grpc.testing.MockServiceHelper;
import com.google.api.gax.grpc.testing.MockStreamObserver;
import com.google.api.gax.rpc.ApiClientHeaderProvider;
import com.google.api.gax.rpc.InvalidArgumentException;
import com.google.api.gax.rpc.ServerStreamingCallable;
import com.google.api.gax.rpc.StatusCode;
import com.google.common.collect.Lists;
import com.google.protobuf.AbstractMessage;
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
public class AdMobApiClientTest {
  private static MockAdMobApi mockAdMobApi;
  private static MockServiceHelper mockServiceHelper;
  private LocalChannelProvider channelProvider;
  private AdMobApiClient client;

  @BeforeClass
  public static void startStaticServer() {
    mockAdMobApi = new MockAdMobApi();
    mockServiceHelper =
        new MockServiceHelper(
            UUID.randomUUID().toString(), Arrays.<MockGrpcService>asList(mockAdMobApi));
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
    AdMobApiSettings settings =
        AdMobApiSettings.newBuilder()
            .setTransportChannelProvider(channelProvider)
            .setCredentialsProvider(NoCredentialsProvider.create())
            .build();
    client = AdMobApiClient.create(settings);
  }

  @After
  public void tearDown() throws Exception {
    client.close();
  }

  @Test
  public void getPublisherAccountTest() throws Exception {
    AdMobResourcesProto.PublisherAccount expectedResponse =
        AdMobResourcesProto.PublisherAccount.newBuilder()
            .setName(PublisherAccountName.of("[PUBLISHER]").toString())
            .setPublisherId("publisherId-614130633")
            .setReportingTimeZone("reportingTimeZone354539623")
            .setCurrencyCode("currencyCode1004773790")
            .build();
    mockAdMobApi.addResponse(expectedResponse);

    String name = "name3373707";

    AdMobResourcesProto.PublisherAccount actualResponse = client.getPublisherAccount(name);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockAdMobApi.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    AdMobApiProto.GetPublisherAccountRequest actualRequest =
        ((AdMobApiProto.GetPublisherAccountRequest) actualRequests.get(0));

    Assert.assertEquals(name, actualRequest.getName());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void getPublisherAccountExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockAdMobApi.addException(exception);

    try {
      String name = "name3373707";
      client.getPublisherAccount(name);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void listPublisherAccountsTest() throws Exception {
    AdMobResourcesProto.PublisherAccount responsesElement =
        AdMobResourcesProto.PublisherAccount.newBuilder().build();
    AdMobApiProto.ListPublisherAccountsResponse expectedResponse =
        AdMobApiProto.ListPublisherAccountsResponse.newBuilder()
            .setNextPageToken("")
            .addAllAccount(Arrays.asList(responsesElement))
            .build();
    mockAdMobApi.addResponse(expectedResponse);

    AdMobApiProto.ListPublisherAccountsRequest request =
        AdMobApiProto.ListPublisherAccountsRequest.newBuilder()
            .setPageSize(883849137)
            .setPageToken("pageToken873572522")
            .build();

    ListPublisherAccountsPagedResponse pagedListResponse = client.listPublisherAccounts(request);

    List<AdMobResourcesProto.PublisherAccount> resources =
        Lists.newArrayList(pagedListResponse.iterateAll());

    Assert.assertEquals(1, resources.size());
    Assert.assertEquals(expectedResponse.getAccountList().get(0), resources.get(0));

    List<AbstractMessage> actualRequests = mockAdMobApi.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    AdMobApiProto.ListPublisherAccountsRequest actualRequest =
        ((AdMobApiProto.ListPublisherAccountsRequest) actualRequests.get(0));

    Assert.assertEquals(request.getPageSize(), actualRequest.getPageSize());
    Assert.assertEquals(request.getPageToken(), actualRequest.getPageToken());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void listPublisherAccountsExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockAdMobApi.addException(exception);

    try {
      AdMobApiProto.ListPublisherAccountsRequest request =
          AdMobApiProto.ListPublisherAccountsRequest.newBuilder()
              .setPageSize(883849137)
              .setPageToken("pageToken873572522")
              .build();
      client.listPublisherAccounts(request);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void generateNetworkReportTest() throws Exception {
    AdMobApiProto.GenerateNetworkReportResponse expectedResponse =
        AdMobApiProto.GenerateNetworkReportResponse.newBuilder().build();
    mockAdMobApi.addResponse(expectedResponse);
    AdMobApiProto.GenerateNetworkReportRequest request =
        AdMobApiProto.GenerateNetworkReportRequest.newBuilder()
            .setParent("parent-995424086")
            .setReportSpec(AdMobResourcesProto.NetworkReportSpec.newBuilder().build())
            .build();

    MockStreamObserver<AdMobApiProto.GenerateNetworkReportResponse> responseObserver =
        new MockStreamObserver<>();

    ServerStreamingCallable<
            AdMobApiProto.GenerateNetworkReportRequest, AdMobApiProto.GenerateNetworkReportResponse>
        callable = client.generateNetworkReportCallable();
    callable.serverStreamingCall(request, responseObserver);

    List<AdMobApiProto.GenerateNetworkReportResponse> actualResponses =
        responseObserver.future().get();
    Assert.assertEquals(1, actualResponses.size());
    Assert.assertEquals(expectedResponse, actualResponses.get(0));
  }

  @Test
  public void generateNetworkReportExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockAdMobApi.addException(exception);
    AdMobApiProto.GenerateNetworkReportRequest request =
        AdMobApiProto.GenerateNetworkReportRequest.newBuilder()
            .setParent("parent-995424086")
            .setReportSpec(AdMobResourcesProto.NetworkReportSpec.newBuilder().build())
            .build();

    MockStreamObserver<AdMobApiProto.GenerateNetworkReportResponse> responseObserver =
        new MockStreamObserver<>();

    ServerStreamingCallable<
            AdMobApiProto.GenerateNetworkReportRequest, AdMobApiProto.GenerateNetworkReportResponse>
        callable = client.generateNetworkReportCallable();
    callable.serverStreamingCall(request, responseObserver);

    try {
      List<AdMobApiProto.GenerateNetworkReportResponse> actualResponses =
          responseObserver.future().get();
      Assert.fail("No exception thrown");
    } catch (ExecutionException e) {
      Assert.assertTrue(e.getCause() instanceof InvalidArgumentException);
      InvalidArgumentException apiException = ((InvalidArgumentException) e.getCause());
      Assert.assertEquals(StatusCode.Code.INVALID_ARGUMENT, apiException.getStatusCode().getCode());
    }
  }

  @Test
  public void generateMediationReportTest() throws Exception {
    AdMobApiProto.GenerateMediationReportResponse expectedResponse =
        AdMobApiProto.GenerateMediationReportResponse.newBuilder().build();
    mockAdMobApi.addResponse(expectedResponse);
    AdMobApiProto.GenerateMediationReportRequest request =
        AdMobApiProto.GenerateMediationReportRequest.newBuilder()
            .setParent("parent-995424086")
            .setReportSpec(AdMobResourcesProto.MediationReportSpec.newBuilder().build())
            .build();

    MockStreamObserver<AdMobApiProto.GenerateMediationReportResponse> responseObserver =
        new MockStreamObserver<>();

    ServerStreamingCallable<
            AdMobApiProto.GenerateMediationReportRequest,
            AdMobApiProto.GenerateMediationReportResponse>
        callable = client.generateMediationReportCallable();
    callable.serverStreamingCall(request, responseObserver);

    List<AdMobApiProto.GenerateMediationReportResponse> actualResponses =
        responseObserver.future().get();
    Assert.assertEquals(1, actualResponses.size());
    Assert.assertEquals(expectedResponse, actualResponses.get(0));
  }

  @Test
  public void generateMediationReportExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockAdMobApi.addException(exception);
    AdMobApiProto.GenerateMediationReportRequest request =
        AdMobApiProto.GenerateMediationReportRequest.newBuilder()
            .setParent("parent-995424086")
            .setReportSpec(AdMobResourcesProto.MediationReportSpec.newBuilder().build())
            .build();

    MockStreamObserver<AdMobApiProto.GenerateMediationReportResponse> responseObserver =
        new MockStreamObserver<>();

    ServerStreamingCallable<
            AdMobApiProto.GenerateMediationReportRequest,
            AdMobApiProto.GenerateMediationReportResponse>
        callable = client.generateMediationReportCallable();
    callable.serverStreamingCall(request, responseObserver);

    try {
      List<AdMobApiProto.GenerateMediationReportResponse> actualResponses =
          responseObserver.future().get();
      Assert.fail("No exception thrown");
    } catch (ExecutionException e) {
      Assert.assertTrue(e.getCause() instanceof InvalidArgumentException);
      InvalidArgumentException apiException = ((InvalidArgumentException) e.getCause());
      Assert.assertEquals(StatusCode.Code.INVALID_ARGUMENT, apiException.getStatusCode().getCode());
    }
  }
}
