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

package com.google.cloud.gaming.allocationendpoint.v1alpha;

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
public class AllocationEndpointServiceClientTest {
  private static MockAllocationEndpointService mockAllocationEndpointService;
  private static MockServiceHelper mockServiceHelper;
  private LocalChannelProvider channelProvider;
  private AllocationEndpointServiceClient client;

  @BeforeClass
  public static void startStaticServer() {
    mockAllocationEndpointService = new MockAllocationEndpointService();
    mockServiceHelper =
        new MockServiceHelper(
            UUID.randomUUID().toString(),
            Arrays.<MockGrpcService>asList(mockAllocationEndpointService));
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
    AllocationEndpointServiceSettings settings =
        AllocationEndpointServiceSettings.newBuilder()
            .setTransportChannelProvider(channelProvider)
            .setCredentialsProvider(NoCredentialsProvider.create())
            .build();
    client = AllocationEndpointServiceClient.create(settings);
  }

  @After
  public void tearDown() throws Exception {
    client.close();
  }

  @Test
  public void allocateTest() throws Exception {
    AllocationResponse expectedResponse =
        AllocationResponse.newBuilder()
            .setGameServerName("gameServerName1320756736")
            .addAllPorts(new ArrayList<AllocationResponse.GameServerStatusPort>())
            .setAddress("address-1147692044")
            .setNodeName("nodeName1122880429")
            .setGameServerClusterName("gameServerClusterName-525342064")
            .setDeploymentName("deploymentName1588248304")
            .build();
    mockAllocationEndpointService.addResponse(expectedResponse);

    AllocationRequest request =
        AllocationRequest.newBuilder()
            .setRealm("realm108386959")
            .setDefaultGameServerDeployment("defaultGameServerDeployment-1315595685")
            .addAllGameServerSelectors(new ArrayList<GameServerSelector>())
            .setMetadata(MetaPatch.newBuilder().build())
            .build();

    AllocationResponse actualResponse = client.allocate(request);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockAllocationEndpointService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    AllocationRequest actualRequest = ((AllocationRequest) actualRequests.get(0));

    Assert.assertEquals(request.getRealm(), actualRequest.getRealm());
    Assert.assertEquals(
        request.getDefaultGameServerDeployment(), actualRequest.getDefaultGameServerDeployment());
    Assert.assertEquals(
        request.getGameServerSelectorsList(), actualRequest.getGameServerSelectorsList());
    Assert.assertEquals(request.getMetadata(), actualRequest.getMetadata());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void allocateExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockAllocationEndpointService.addException(exception);

    try {
      AllocationRequest request =
          AllocationRequest.newBuilder()
              .setRealm("realm108386959")
              .setDefaultGameServerDeployment("defaultGameServerDeployment-1315595685")
              .addAllGameServerSelectors(new ArrayList<GameServerSelector>())
              .setMetadata(MetaPatch.newBuilder().build())
              .build();
      client.allocate(request);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }
}
