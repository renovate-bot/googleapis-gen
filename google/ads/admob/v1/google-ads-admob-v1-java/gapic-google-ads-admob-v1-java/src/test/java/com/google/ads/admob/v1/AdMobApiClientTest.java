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
package com.google.ads.admob.v1;

import static com.google.ads.admob.v1.AdMobApiClient.ListPublisherAccountsPagedResponse;

import com.google.ads.admob.v1.AdMobApiProto.GenerateMediationReportRequest;
import com.google.ads.admob.v1.AdMobApiProto.GenerateMediationReportResponse;
import com.google.ads.admob.v1.AdMobApiProto.GenerateNetworkReportRequest;
import com.google.ads.admob.v1.AdMobApiProto.GenerateNetworkReportResponse;
import com.google.ads.admob.v1.AdMobApiProto.GetPublisherAccountRequest;
import com.google.ads.admob.v1.AdMobApiProto.ListPublisherAccountsRequest;
import com.google.ads.admob.v1.AdMobApiProto.ListPublisherAccountsResponse;
import com.google.ads.admob.v1.AdMobResourcesProto.MediationReportSpec;
import com.google.ads.admob.v1.AdMobResourcesProto.NetworkReportSpec;
import com.google.ads.admob.v1.AdMobResourcesProto.PublisherAccount;
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
import io.grpc.Status;
import io.grpc.StatusRuntimeException;
import java.io.IOException;
import java.util.Arrays;
import java.util.List;
import java.util.UUID;
import java.util.concurrent.ExecutionException;
import org.junit.After;
import org.junit.AfterClass;
import org.junit.Assert;
import org.junit.Before;
import org.junit.BeforeClass;
import org.junit.Test;

@javax.annotation.Generated("by GAPIC")
public class AdMobApiClientTest {
  private static MockAdMobApi mockAdMobApi;
  private static MockServiceHelper serviceHelper;
  private AdMobApiClient client;
  private LocalChannelProvider channelProvider;

  @BeforeClass
  public static void startStaticServer() {
    mockAdMobApi = new MockAdMobApi();
    serviceHelper =
        new MockServiceHelper(
            UUID.randomUUID().toString(), Arrays.<MockGrpcService>asList(mockAdMobApi));
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
  @SuppressWarnings("all")
  public void getPublisherAccountTest() {
    String name2 = "name2-1052831874";
    String publisherId = "publisherId-1858159042";
    String reportingTimeZone = "reportingTimeZone1270653197";
    String currencyCode = "currencyCode1108728155";
    PublisherAccount expectedResponse =
        PublisherAccount.newBuilder()
            .setName(name2)
            .setPublisherId(publisherId)
            .setReportingTimeZone(reportingTimeZone)
            .setCurrencyCode(currencyCode)
            .build();
    mockAdMobApi.addResponse(expectedResponse);

    String formattedName = AdMobApiClient.formatAccountName("[ACCOUNT]");

    PublisherAccount actualResponse = client.getPublisherAccount(formattedName);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockAdMobApi.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    GetPublisherAccountRequest actualRequest = (GetPublisherAccountRequest) actualRequests.get(0);

    Assert.assertEquals(formattedName, actualRequest.getName());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  @SuppressWarnings("all")
  public void getPublisherAccountExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(Status.INVALID_ARGUMENT);
    mockAdMobApi.addException(exception);

    try {
      String formattedName = AdMobApiClient.formatAccountName("[ACCOUNT]");

      client.getPublisherAccount(formattedName);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception
    }
  }

  @Test
  @SuppressWarnings("all")
  public void listPublisherAccountsTest() {
    String nextPageToken = "";
    PublisherAccount accountElement = PublisherAccount.newBuilder().build();
    List<PublisherAccount> account = Arrays.asList(accountElement);
    ListPublisherAccountsResponse expectedResponse =
        ListPublisherAccountsResponse.newBuilder()
            .setNextPageToken(nextPageToken)
            .addAllAccount(account)
            .build();
    mockAdMobApi.addResponse(expectedResponse);

    ListPublisherAccountsRequest request = ListPublisherAccountsRequest.newBuilder().build();

    ListPublisherAccountsPagedResponse pagedListResponse = client.listPublisherAccounts(request);

    List<PublisherAccount> resources = Lists.newArrayList(pagedListResponse.iterateAll());
    Assert.assertEquals(1, resources.size());
    Assert.assertEquals(expectedResponse.getAccountList().get(0), resources.get(0));

    List<AbstractMessage> actualRequests = mockAdMobApi.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    ListPublisherAccountsRequest actualRequest =
        (ListPublisherAccountsRequest) actualRequests.get(0);

    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  @SuppressWarnings("all")
  public void listPublisherAccountsExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(Status.INVALID_ARGUMENT);
    mockAdMobApi.addException(exception);

    try {
      ListPublisherAccountsRequest request = ListPublisherAccountsRequest.newBuilder().build();

      client.listPublisherAccounts(request);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception
    }
  }

  @Test
  @SuppressWarnings("all")
  public void generateNetworkReportTest() throws Exception {
    GenerateNetworkReportResponse expectedResponse =
        GenerateNetworkReportResponse.newBuilder().build();
    mockAdMobApi.addResponse(expectedResponse);
    String formattedParent = AdMobApiClient.formatAccountName("[ACCOUNT]");
    NetworkReportSpec reportSpec = NetworkReportSpec.newBuilder().build();
    GenerateNetworkReportRequest request =
        GenerateNetworkReportRequest.newBuilder()
            .setParent(formattedParent)
            .setReportSpec(reportSpec)
            .build();

    MockStreamObserver<GenerateNetworkReportResponse> responseObserver = new MockStreamObserver<>();

    ServerStreamingCallable<GenerateNetworkReportRequest, GenerateNetworkReportResponse> callable =
        client.generateNetworkReportCallable();
    callable.serverStreamingCall(request, responseObserver);

    List<GenerateNetworkReportResponse> actualResponses = responseObserver.future().get();
    Assert.assertEquals(1, actualResponses.size());
    Assert.assertEquals(expectedResponse, actualResponses.get(0));
  }

  @Test
  @SuppressWarnings("all")
  public void generateNetworkReportExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(Status.INVALID_ARGUMENT);
    mockAdMobApi.addException(exception);
    String formattedParent = AdMobApiClient.formatAccountName("[ACCOUNT]");
    NetworkReportSpec reportSpec = NetworkReportSpec.newBuilder().build();
    GenerateNetworkReportRequest request =
        GenerateNetworkReportRequest.newBuilder()
            .setParent(formattedParent)
            .setReportSpec(reportSpec)
            .build();

    MockStreamObserver<GenerateNetworkReportResponse> responseObserver = new MockStreamObserver<>();

    ServerStreamingCallable<GenerateNetworkReportRequest, GenerateNetworkReportResponse> callable =
        client.generateNetworkReportCallable();
    callable.serverStreamingCall(request, responseObserver);

    try {
      List<GenerateNetworkReportResponse> actualResponses = responseObserver.future().get();
      Assert.fail("No exception thrown");
    } catch (ExecutionException e) {
      Assert.assertTrue(e.getCause() instanceof InvalidArgumentException);
      InvalidArgumentException apiException = (InvalidArgumentException) e.getCause();
      Assert.assertEquals(StatusCode.Code.INVALID_ARGUMENT, apiException.getStatusCode().getCode());
    }
  }

  @Test
  @SuppressWarnings("all")
  public void generateMediationReportTest() throws Exception {
    GenerateMediationReportResponse expectedResponse =
        GenerateMediationReportResponse.newBuilder().build();
    mockAdMobApi.addResponse(expectedResponse);
    String formattedParent = AdMobApiClient.formatAccountName("[ACCOUNT]");
    MediationReportSpec reportSpec = MediationReportSpec.newBuilder().build();
    GenerateMediationReportRequest request =
        GenerateMediationReportRequest.newBuilder()
            .setParent(formattedParent)
            .setReportSpec(reportSpec)
            .build();

    MockStreamObserver<GenerateMediationReportResponse> responseObserver =
        new MockStreamObserver<>();

    ServerStreamingCallable<GenerateMediationReportRequest, GenerateMediationReportResponse>
        callable = client.generateMediationReportCallable();
    callable.serverStreamingCall(request, responseObserver);

    List<GenerateMediationReportResponse> actualResponses = responseObserver.future().get();
    Assert.assertEquals(1, actualResponses.size());
    Assert.assertEquals(expectedResponse, actualResponses.get(0));
  }

  @Test
  @SuppressWarnings("all")
  public void generateMediationReportExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(Status.INVALID_ARGUMENT);
    mockAdMobApi.addException(exception);
    String formattedParent = AdMobApiClient.formatAccountName("[ACCOUNT]");
    MediationReportSpec reportSpec = MediationReportSpec.newBuilder().build();
    GenerateMediationReportRequest request =
        GenerateMediationReportRequest.newBuilder()
            .setParent(formattedParent)
            .setReportSpec(reportSpec)
            .build();

    MockStreamObserver<GenerateMediationReportResponse> responseObserver =
        new MockStreamObserver<>();

    ServerStreamingCallable<GenerateMediationReportRequest, GenerateMediationReportResponse>
        callable = client.generateMediationReportCallable();
    callable.serverStreamingCall(request, responseObserver);

    try {
      List<GenerateMediationReportResponse> actualResponses = responseObserver.future().get();
      Assert.fail("No exception thrown");
    } catch (ExecutionException e) {
      Assert.assertTrue(e.getCause() instanceof InvalidArgumentException);
      InvalidArgumentException apiException = (InvalidArgumentException) e.getCause();
      Assert.assertEquals(StatusCode.Code.INVALID_ARGUMENT, apiException.getStatusCode().getCode());
    }
  }
}
