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

package com.google.chromeos.uidetection.v1;

import com.google.api.gax.core.NoCredentialsProvider;
import com.google.api.gax.grpc.GaxGrpcProperties;
import com.google.api.gax.grpc.testing.LocalChannelProvider;
import com.google.api.gax.grpc.testing.MockGrpcService;
import com.google.api.gax.grpc.testing.MockServiceHelper;
import com.google.api.gax.rpc.ApiClientHeaderProvider;
import com.google.api.gax.rpc.InvalidArgumentException;
import com.google.protobuf.AbstractMessage;
import com.google.protobuf.ByteString;
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
public class UiDetectionServiceClientTest {
  private static MockServiceHelper mockServiceHelper;
  private static MockUiDetectionService mockUiDetectionService;
  private LocalChannelProvider channelProvider;
  private UiDetectionServiceClient client;

  @BeforeClass
  public static void startStaticServer() {
    mockUiDetectionService = new MockUiDetectionService();
    mockServiceHelper =
        new MockServiceHelper(
            UUID.randomUUID().toString(), Arrays.<MockGrpcService>asList(mockUiDetectionService));
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
    UiDetectionServiceSettings settings =
        UiDetectionServiceSettings.newBuilder()
            .setTransportChannelProvider(channelProvider)
            .setCredentialsProvider(NoCredentialsProvider.create())
            .build();
    client = UiDetectionServiceClient.create(settings);
  }

  @After
  public void tearDown() throws Exception {
    client.close();
  }

  @Test
  public void executeDetectionTest() throws Exception {
    UiDetectionResponse expectedResponse =
        UiDetectionResponse.newBuilder().addAllBoundingBoxes(new ArrayList<BoundingBox>()).build();
    mockUiDetectionService.addResponse(expectedResponse);

    UiDetectionRequest request =
        UiDetectionRequest.newBuilder()
            .setImagePng(ByteString.EMPTY)
            .setRequest(DetectionRequest.newBuilder().build())
            .build();

    UiDetectionResponse actualResponse = client.executeDetection(request);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockUiDetectionService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    UiDetectionRequest actualRequest = ((UiDetectionRequest) actualRequests.get(0));

    Assert.assertEquals(request.getImagePng(), actualRequest.getImagePng());
    Assert.assertEquals(request.getRequest(), actualRequest.getRequest());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void executeDetectionExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockUiDetectionService.addException(exception);

    try {
      UiDetectionRequest request =
          UiDetectionRequest.newBuilder()
              .setImagePng(ByteString.EMPTY)
              .setRequest(DetectionRequest.newBuilder().build())
              .build();
      client.executeDetection(request);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }
}
