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
import com.google.maps.routes.v1.FallbackInfo;
import com.google.maps.routes.v1.Route;
import com.google.maps.routes.v1.RouteMatrixDestination;
import com.google.maps.routes.v1.RouteMatrixElement;
import com.google.maps.routes.v1.RouteMatrixElementCondition;
import com.google.maps.routes.v1.RouteMatrixOrigin;
import com.google.maps.routes.v1.RouteTravelAdvisory;
import com.google.maps.routes.v1.RouteTravelMode;
import com.google.maps.routes.v1.RoutingPreference;
import com.google.maps.routes.v1.Waypoint;
import com.google.protobuf.AbstractMessage;
import com.google.protobuf.Duration;
import com.google.protobuf.Timestamp;
import com.google.rpc.Status;
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
public class RoutesPreferredClientTest {
  private static MockServiceHelper mockServiceHelper;
  private RoutesPreferredClient client;
  private LocalChannelProvider channelProvider;
  private static MockRoutesPreferred mockRoutesPreferred;

  @BeforeClass
  public static void startStaticServer() {
    mockRoutesPreferred = new MockRoutesPreferred();
    mockServiceHelper =
        new MockServiceHelper(
            UUID.randomUUID().toString(), Arrays.<MockGrpcService>asList(mockRoutesPreferred));
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
  public void computeRoutesTest() throws Exception {
    ComputeRoutesResponse expectedResponse =
        ComputeRoutesResponse.newBuilder()
            .addAllRoutes(new ArrayList<Route>())
            .setFallbackInfo(FallbackInfo.newBuilder().build())
            .build();
    mockRoutesPreferred.addResponse(expectedResponse);

    Waypoint origin = Waypoint.newBuilder().build();
    Waypoint destination = Waypoint.newBuilder().build();

    ComputeRoutesResponse actualResponse = client.computeRoutes(origin, destination);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockRoutesPreferred.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    ComputeRoutesRequest actualRequest = ((ComputeRoutesRequest) actualRequests.get(0));

    Assert.assertEquals(origin, actualRequest.getOrigin());
    Assert.assertEquals(destination, actualRequest.getDestination());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void computeRoutesExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockRoutesPreferred.addException(exception);

    try {
      Waypoint origin = Waypoint.newBuilder().build();
      Waypoint destination = Waypoint.newBuilder().build();
      client.computeRoutes(origin, destination);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void computeRouteMatrixTest() throws Exception {
    RouteMatrixElement expectedResponse =
        RouteMatrixElement.newBuilder()
            .setOriginIndex(2078721657)
            .setDestinationIndex(-1296954015)
            .setStatus(Status.newBuilder().build())
            .setCondition(RouteMatrixElementCondition.forNumber(0))
            .setDistanceMeters(1958857108)
            .setDuration(Duration.newBuilder().build())
            .setStaticDuration(Duration.newBuilder().build())
            .setTravelAdvisory(RouteTravelAdvisory.newBuilder().build())
            .setFallbackInfo(FallbackInfo.newBuilder().build())
            .build();
    mockRoutesPreferred.addResponse(expectedResponse);
    ComputeRouteMatrixRequest request =
        ComputeRouteMatrixRequest.newBuilder()
            .addAllOrigins(new ArrayList<RouteMatrixOrigin>())
            .addAllDestinations(new ArrayList<RouteMatrixDestination>())
            .setTravelMode(RouteTravelMode.forNumber(0))
            .setRoutingPreference(RoutingPreference.forNumber(0))
            .setDepartureTime(Timestamp.newBuilder().build())
            .build();

    MockStreamObserver<RouteMatrixElement> responseObserver = new MockStreamObserver<>();

    ServerStreamingCallable<ComputeRouteMatrixRequest, RouteMatrixElement> callable =
        client.computeRouteMatrixCallable();
    callable.serverStreamingCall(request, responseObserver);

    List<RouteMatrixElement> actualResponses = responseObserver.future().get();
    Assert.assertEquals(1, actualResponses.size());
    Assert.assertEquals(expectedResponse, actualResponses.get(0));
  }

  @Test
  public void computeRouteMatrixExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockRoutesPreferred.addException(exception);
    ComputeRouteMatrixRequest request =
        ComputeRouteMatrixRequest.newBuilder()
            .addAllOrigins(new ArrayList<RouteMatrixOrigin>())
            .addAllDestinations(new ArrayList<RouteMatrixDestination>())
            .setTravelMode(RouteTravelMode.forNumber(0))
            .setRoutingPreference(RoutingPreference.forNumber(0))
            .setDepartureTime(Timestamp.newBuilder().build())
            .build();

    MockStreamObserver<RouteMatrixElement> responseObserver = new MockStreamObserver<>();

    ServerStreamingCallable<ComputeRouteMatrixRequest, RouteMatrixElement> callable =
        client.computeRouteMatrixCallable();
    callable.serverStreamingCall(request, responseObserver);

    try {
      List<RouteMatrixElement> actualResponses = responseObserver.future().get();
      Assert.fail("No exception thrown");
    } catch (ExecutionException e) {
      Assert.assertTrue(e.getCause() instanceof InvalidArgumentException);
      InvalidArgumentException apiException = ((InvalidArgumentException) e.getCause());
      Assert.assertEquals(StatusCode.Code.INVALID_ARGUMENT, apiException.getStatusCode().getCode());
    }
  }
}
