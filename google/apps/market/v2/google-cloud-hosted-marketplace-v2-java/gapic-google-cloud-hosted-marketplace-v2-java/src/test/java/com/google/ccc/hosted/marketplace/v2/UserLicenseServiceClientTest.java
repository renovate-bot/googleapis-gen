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

package com.google.ccc.hosted.marketplace.v2;

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
public class UserLicenseServiceClientTest {
  private static MockServiceHelper mockServiceHelper;
  private static MockUserLicenseService mockUserLicenseService;
  private LocalChannelProvider channelProvider;
  private UserLicenseServiceClient client;

  @BeforeClass
  public static void startStaticServer() {
    mockUserLicenseService = new MockUserLicenseService();
    mockServiceHelper =
        new MockServiceHelper(
            UUID.randomUUID().toString(), Arrays.<MockGrpcService>asList(mockUserLicenseService));
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
    UserLicenseServiceSettings settings =
        UserLicenseServiceSettings.newBuilder()
            .setTransportChannelProvider(channelProvider)
            .setCredentialsProvider(NoCredentialsProvider.create())
            .build();
    client = UserLicenseServiceClient.create(settings);
  }

  @After
  public void tearDown() throws Exception {
    client.close();
  }

  @Test
  public void getTest() throws Exception {
    UserLicense expectedResponse =
        UserLicense.newBuilder()
            .setKind("kind3292052")
            .setEnabled(true)
            .setState("state109757585")
            .setEditionId("editionId-1856927879")
            .setCustomerId("customerId-1581184615")
            .setApplicationId("applicationId-1011352949")
            .setId("id3355")
            .setUserId("userId-836030906")
            .build();
    mockUserLicenseService.addResponse(expectedResponse);

    UserLicenseGetRequest request =
        UserLicenseGetRequest.newBuilder()
            .setApplicationId("applicationId-1011352949")
            .setUserId("userId-836030906")
            .build();

    UserLicense actualResponse = client.get(request);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockUserLicenseService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    UserLicenseGetRequest actualRequest = ((UserLicenseGetRequest) actualRequests.get(0));

    Assert.assertEquals(request.getApplicationId(), actualRequest.getApplicationId());
    Assert.assertEquals(request.getUserId(), actualRequest.getUserId());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void getExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockUserLicenseService.addException(exception);

    try {
      UserLicenseGetRequest request =
          UserLicenseGetRequest.newBuilder()
              .setApplicationId("applicationId-1011352949")
              .setUserId("userId-836030906")
              .build();
      client.get(request);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }
}
