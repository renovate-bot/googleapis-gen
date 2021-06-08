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

package com.google.cloud.devtools.build.v1;

import com.google.api.gax.core.NoCredentialsProvider;
import com.google.api.gax.grpc.GaxGrpcProperties;
import com.google.api.gax.grpc.testing.LocalChannelProvider;
import com.google.api.gax.grpc.testing.MockGrpcService;
import com.google.api.gax.grpc.testing.MockServiceHelper;
import com.google.api.gax.grpc.testing.MockStreamObserver;
import com.google.api.gax.rpc.ApiClientHeaderProvider;
import com.google.api.gax.rpc.ApiStreamObserver;
import com.google.api.gax.rpc.BidiStreamingCallable;
import com.google.api.gax.rpc.InvalidArgumentException;
import com.google.api.gax.rpc.StatusCode;
import com.google.devtools.build.v1.OrderedBuildEvent;
import com.google.devtools.build.v1.PublishBuildToolEventStreamRequest;
import com.google.devtools.build.v1.PublishBuildToolEventStreamResponse;
import com.google.devtools.build.v1.PublishLifecycleEventRequest;
import com.google.devtools.build.v1.StreamId;
import com.google.protobuf.AbstractMessage;
import com.google.protobuf.Duration;
import com.google.protobuf.Empty;
import io.grpc.StatusRuntimeException;
import java.io.IOException;
import java.util.ArrayList;
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
public class PublishBuildEventClientTest {
  private static MockPublishBuildEvent mockPublishBuildEvent;
  private static MockServiceHelper mockServiceHelper;
  private LocalChannelProvider channelProvider;
  private PublishBuildEventClient client;

  @BeforeClass
  public static void startStaticServer() {
    mockPublishBuildEvent = new MockPublishBuildEvent();
    mockServiceHelper =
        new MockServiceHelper(
            UUID.randomUUID().toString(), Arrays.<MockGrpcService>asList(mockPublishBuildEvent));
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
    PublishBuildEventSettings settings =
        PublishBuildEventSettings.newBuilder()
            .setTransportChannelProvider(channelProvider)
            .setCredentialsProvider(NoCredentialsProvider.create())
            .build();
    client = PublishBuildEventClient.create(settings);
  }

  @After
  public void tearDown() throws Exception {
    client.close();
  }

  @Test
  public void publishLifecycleEventTest() throws Exception {
    Empty expectedResponse = Empty.newBuilder().build();
    mockPublishBuildEvent.addResponse(expectedResponse);

    PublishLifecycleEventRequest request =
        PublishLifecycleEventRequest.newBuilder()
            .setBuildEvent(OrderedBuildEvent.newBuilder().build())
            .setStreamTimeout(Duration.newBuilder().build())
            .addAllNotificationKeywords(new ArrayList<String>())
            .setProjectId("projectId-894832108")
            .build();

    client.publishLifecycleEvent(request);

    List<AbstractMessage> actualRequests = mockPublishBuildEvent.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    PublishLifecycleEventRequest actualRequest =
        ((PublishLifecycleEventRequest) actualRequests.get(0));

    Assert.assertEquals(request.getServiceLevel(), actualRequest.getServiceLevel());
    Assert.assertEquals(request.getBuildEvent(), actualRequest.getBuildEvent());
    Assert.assertEquals(request.getStreamTimeout(), actualRequest.getStreamTimeout());
    Assert.assertEquals(
        request.getNotificationKeywordsList(), actualRequest.getNotificationKeywordsList());
    Assert.assertEquals(request.getProjectId(), actualRequest.getProjectId());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void publishLifecycleEventExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockPublishBuildEvent.addException(exception);

    try {
      PublishLifecycleEventRequest request =
          PublishLifecycleEventRequest.newBuilder()
              .setBuildEvent(OrderedBuildEvent.newBuilder().build())
              .setStreamTimeout(Duration.newBuilder().build())
              .addAllNotificationKeywords(new ArrayList<String>())
              .setProjectId("projectId-894832108")
              .build();
      client.publishLifecycleEvent(request);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void publishBuildToolEventStreamTest() throws Exception {
    PublishBuildToolEventStreamResponse expectedResponse =
        PublishBuildToolEventStreamResponse.newBuilder()
            .setStreamId(StreamId.newBuilder().build())
            .setSequenceNumber(-1309190777)
            .build();
    mockPublishBuildEvent.addResponse(expectedResponse);
    PublishBuildToolEventStreamRequest request =
        PublishBuildToolEventStreamRequest.newBuilder()
            .setOrderedBuildEvent(OrderedBuildEvent.newBuilder().build())
            .addAllNotificationKeywords(new ArrayList<String>())
            .setProjectId("projectId-894832108")
            .build();

    MockStreamObserver<PublishBuildToolEventStreamResponse> responseObserver =
        new MockStreamObserver<>();

    BidiStreamingCallable<PublishBuildToolEventStreamRequest, PublishBuildToolEventStreamResponse>
        callable = client.publishBuildToolEventStreamCallable();
    ApiStreamObserver<PublishBuildToolEventStreamRequest> requestObserver =
        callable.bidiStreamingCall(responseObserver);

    requestObserver.onNext(request);
    requestObserver.onCompleted();

    List<PublishBuildToolEventStreamResponse> actualResponses = responseObserver.future().get();
    Assert.assertEquals(1, actualResponses.size());
    Assert.assertEquals(expectedResponse, actualResponses.get(0));
  }

  @Test
  public void publishBuildToolEventStreamExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockPublishBuildEvent.addException(exception);
    PublishBuildToolEventStreamRequest request =
        PublishBuildToolEventStreamRequest.newBuilder()
            .setOrderedBuildEvent(OrderedBuildEvent.newBuilder().build())
            .addAllNotificationKeywords(new ArrayList<String>())
            .setProjectId("projectId-894832108")
            .build();

    MockStreamObserver<PublishBuildToolEventStreamResponse> responseObserver =
        new MockStreamObserver<>();

    BidiStreamingCallable<PublishBuildToolEventStreamRequest, PublishBuildToolEventStreamResponse>
        callable = client.publishBuildToolEventStreamCallable();
    ApiStreamObserver<PublishBuildToolEventStreamRequest> requestObserver =
        callable.bidiStreamingCall(responseObserver);

    requestObserver.onNext(request);

    try {
      List<PublishBuildToolEventStreamResponse> actualResponses = responseObserver.future().get();
      Assert.fail("No exception thrown");
    } catch (ExecutionException e) {
      Assert.assertTrue(e.getCause() instanceof InvalidArgumentException);
      InvalidArgumentException apiException = ((InvalidArgumentException) e.getCause());
      Assert.assertEquals(StatusCode.Code.INVALID_ARGUMENT, apiException.getStatusCode().getCode());
    }
  }
}
