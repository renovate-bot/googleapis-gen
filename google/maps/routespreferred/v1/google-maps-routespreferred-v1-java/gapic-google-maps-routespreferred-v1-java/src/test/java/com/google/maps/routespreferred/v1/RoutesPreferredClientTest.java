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
package com.google.maps.routespreferred.v1;

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
import com.google.maps.routes.v1.ComputeRouteMatrixRequest;
import com.google.maps.routes.v1.ComputeRoutesRequest;
import com.google.maps.routes.v1.ComputeRoutesResponse;
import com.google.maps.routes.v1.RouteMatrixElement;
import com.google.maps.routes.v1.Waypoint;
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
public class RoutesPreferredClientTest {
  private static MockRoutesPreferred mockRoutesPreferred;
  private static MockServiceHelper serviceHelper;
  private RoutesPreferredClient client;
  private LocalChannelProvider channelProvider;

  @BeforeClass
  public static void startStaticServer() {
    mockRoutesPreferred = new MockRoutesPreferred();
    serviceHelper =
        new MockServiceHelper(
            UUID.randomUUID().toString(), Arrays.<MockGrpcService>asList(mockRoutesPreferred));
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
    RoutesPreferredSettings settings =
        RoutesPreferredSettings.newBuilder()
            .setTransportChannelProvider(channelProvider)
            .setCredentialsProvider(NoCredentialsProvider.create())
            .build();
    client = RoutesPreferredClient.create(settings);
  }

  @After
  public void tearDown() throws Exception {
    client.close();
  }

  @Test
  @SuppressWarnings("all")
  public void computeRoutesTest() {
    ComputeRoutesResponse expectedResponse = ComputeRoutesResponse.newBuilder().build();
    mockRoutesPreferred.addResponse(expectedResponse);

    Waypoint origin = Waypoint.newBuilder().build();
    Waypoint destination = Waypoint.newBuilder().build();
    ComputeRoutesRequest request =
        ComputeRoutesRequest.newBuilder().setOrigin(origin).setDestination(destination).build();

    ComputeRoutesResponse actualResponse = client.computeRoutes(request);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockRoutesPreferred.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    ComputeRoutesRequest actualRequest = (ComputeRoutesRequest) actualRequests.get(0);

    Assert.assertEquals(origin, actualRequest.getOrigin());
    Assert.assertEquals(destination, actualRequest.getDestination());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  @SuppressWarnings("all")
  public void computeRoutesExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(Status.INVALID_ARGUMENT);
    mockRoutesPreferred.addException(exception);

    try {
      Waypoint origin = Waypoint.newBuilder().build();
      Waypoint destination = Waypoint.newBuilder().build();
      ComputeRoutesRequest request =
          ComputeRoutesRequest.newBuilder().setOrigin(origin).setDestination(destination).build();

      client.computeRoutes(request);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception
    }
  }

  @Test
  @SuppressWarnings("all")
  public void computeRouteMatrixTest() throws Exception {
    int originIndex = 2078721657;
    int destinationIndex = 1296954015;
    int distanceMeters = 1958857108;
    RouteMatrixElement expectedResponse =
        RouteMatrixElement.newBuilder()
            .setOriginIndex(originIndex)
            .setDestinationIndex(destinationIndex)
            .setDistanceMeters(distanceMeters)
            .build();
    mockRoutesPreferred.addResponse(expectedResponse);
    ComputeRouteMatrixRequest request = ComputeRouteMatrixRequest.newBuilder().build();

    MockStreamObserver<RouteMatrixElement> responseObserver = new MockStreamObserver<>();

    ServerStreamingCallable<ComputeRouteMatrixRequest, RouteMatrixElement> callable =
        client.computeRouteMatrixCallable();
    callable.serverStreamingCall(request, responseObserver);

    List<RouteMatrixElement> actualResponses = responseObserver.future().get();
    Assert.assertEquals(1, actualResponses.size());
    Assert.assertEquals(expectedResponse, actualResponses.get(0));
  }

  @Test
  @SuppressWarnings("all")
  public void computeRouteMatrixExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(Status.INVALID_ARGUMENT);
    mockRoutesPreferred.addException(exception);
    ComputeRouteMatrixRequest request = ComputeRouteMatrixRequest.newBuilder().build();

    MockStreamObserver<RouteMatrixElement> responseObserver = new MockStreamObserver<>();

    ServerStreamingCallable<ComputeRouteMatrixRequest, RouteMatrixElement> callable =
        client.computeRouteMatrixCallable();
    callable.serverStreamingCall(request, responseObserver);

    try {
      List<RouteMatrixElement> actualResponses = responseObserver.future().get();
      Assert.fail("No exception thrown");
    } catch (ExecutionException e) {
      Assert.assertTrue(e.getCause() instanceof InvalidArgumentException);
      InvalidArgumentException apiException = (InvalidArgumentException) e.getCause();
      Assert.assertEquals(StatusCode.Code.INVALID_ARGUMENT, apiException.getStatusCode().getCode());
    }
  }
}
