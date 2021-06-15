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

package com.google.devtools.testing.v1;

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
public class TestEnvironmentDiscoveryServiceClientTest {
  private static MockServiceHelper mockServiceHelper;
  private static MockTestEnvironmentDiscoveryService mockTestEnvironmentDiscoveryService;
  private LocalChannelProvider channelProvider;
  private TestEnvironmentDiscoveryServiceClient client;

  @BeforeClass
  public static void startStaticServer() {
    mockTestEnvironmentDiscoveryService = new MockTestEnvironmentDiscoveryService();
    mockServiceHelper =
        new MockServiceHelper(
            UUID.randomUUID().toString(),
            Arrays.<MockGrpcService>asList(mockTestEnvironmentDiscoveryService));
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
    TestEnvironmentDiscoveryServiceSettings settings =
        TestEnvironmentDiscoveryServiceSettings.newBuilder()
            .setTransportChannelProvider(channelProvider)
            .setCredentialsProvider(NoCredentialsProvider.create())
            .build();
    client = TestEnvironmentDiscoveryServiceClient.create(settings);
  }

  @After
  public void tearDown() throws Exception {
    client.close();
  }

  @Test
  public void getTestEnvironmentCatalogTest() throws Exception {
    TestEnvironmentCatalog expectedResponse = TestEnvironmentCatalog.newBuilder().build();
    mockTestEnvironmentDiscoveryService.addResponse(expectedResponse);

    GetTestEnvironmentCatalogRequest request =
        GetTestEnvironmentCatalogRequest.newBuilder().setProjectId("projectId-894832108").build();

    TestEnvironmentCatalog actualResponse = client.getTestEnvironmentCatalog(request);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockTestEnvironmentDiscoveryService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    GetTestEnvironmentCatalogRequest actualRequest =
        ((GetTestEnvironmentCatalogRequest) actualRequests.get(0));

    Assert.assertEquals(request.getEnvironmentType(), actualRequest.getEnvironmentType());
    Assert.assertEquals(request.getProjectId(), actualRequest.getProjectId());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void getTestEnvironmentCatalogExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockTestEnvironmentDiscoveryService.addException(exception);

    try {
      GetTestEnvironmentCatalogRequest request =
          GetTestEnvironmentCatalogRequest.newBuilder().setProjectId("projectId-894832108").build();
      client.getTestEnvironmentCatalog(request);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }
}
