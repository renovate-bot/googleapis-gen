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

package com.google.cloud.ondemandscanning.v1beta1;

import static com.google.cloud.ondemandscanning.v1beta1.ScannerServiceClient.ListVulnerabilitiesPagedResponse;

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
import io.grafeas.v1.Occurrence;
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
public class ScannerServiceClientTest {
  private static MockScannerService mockScannerService;
  private static MockServiceHelper mockServiceHelper;
  private LocalChannelProvider channelProvider;
  private ScannerServiceClient client;

  @BeforeClass
  public static void startStaticServer() {
    mockScannerService = new MockScannerService();
    mockServiceHelper =
        new MockServiceHelper(
            UUID.randomUUID().toString(), Arrays.<MockGrpcService>asList(mockScannerService));
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
    ScannerServiceSettings settings =
        ScannerServiceSettings.newBuilder()
            .setTransportChannelProvider(channelProvider)
            .setCredentialsProvider(NoCredentialsProvider.create())
            .build();
    client = ScannerServiceClient.create(settings);
  }

  @After
  public void tearDown() throws Exception {
    client.close();
  }

  @Test
  public void analyzePackagesTest() throws Exception {
    AnalyzePackagesResponse expectedResponse =
        AnalyzePackagesResponse.newBuilder().setScan("scan3524221").build();
    Operation resultOperation =
        Operation.newBuilder()
            .setName("analyzePackagesTest")
            .setDone(true)
            .setResponse(Any.pack(expectedResponse))
            .build();
    mockScannerService.addResponse(resultOperation);

    String parent = "parent-995424086";

    AnalyzePackagesResponse actualResponse = client.analyzePackagesAsync(parent).get();
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockScannerService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    AnalyzePackagesRequest actualRequest = ((AnalyzePackagesRequest) actualRequests.get(0));

    Assert.assertEquals(parent, actualRequest.getParent());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void analyzePackagesExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockScannerService.addException(exception);

    try {
      String parent = "parent-995424086";
      client.analyzePackagesAsync(parent).get();
      Assert.fail("No exception raised");
    } catch (ExecutionException e) {
      Assert.assertEquals(InvalidArgumentException.class, e.getCause().getClass());
      InvalidArgumentException apiException = ((InvalidArgumentException) e.getCause());
      Assert.assertEquals(StatusCode.Code.INVALID_ARGUMENT, apiException.getStatusCode().getCode());
    }
  }

  @Test
  public void listVulnerabilitiesTest() throws Exception {
    Occurrence responsesElement = Occurrence.newBuilder().build();
    ListVulnerabilitiesResponse expectedResponse =
        ListVulnerabilitiesResponse.newBuilder()
            .setNextPageToken("")
            .addAllOccurrences(Arrays.asList(responsesElement))
            .build();
    mockScannerService.addResponse(expectedResponse);

    String parent = "parent-995424086";

    ListVulnerabilitiesPagedResponse pagedListResponse = client.listVulnerabilities(parent);

    List<Occurrence> resources = Lists.newArrayList(pagedListResponse.iterateAll());

    Assert.assertEquals(1, resources.size());
    Assert.assertEquals(expectedResponse.getOccurrencesList().get(0), resources.get(0));

    List<AbstractMessage> actualRequests = mockScannerService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    ListVulnerabilitiesRequest actualRequest = ((ListVulnerabilitiesRequest) actualRequests.get(0));

    Assert.assertEquals(parent, actualRequest.getParent());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void listVulnerabilitiesExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockScannerService.addException(exception);

    try {
      String parent = "parent-995424086";
      client.listVulnerabilities(parent);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }
}
