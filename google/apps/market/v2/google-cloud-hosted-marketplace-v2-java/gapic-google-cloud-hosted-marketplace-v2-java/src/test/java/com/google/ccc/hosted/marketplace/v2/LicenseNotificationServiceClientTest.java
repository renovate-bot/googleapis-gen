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
public class LicenseNotificationServiceClientTest {
  private static MockLicenseNotificationService mockLicenseNotificationService;
  private static MockServiceHelper mockServiceHelper;
  private LocalChannelProvider channelProvider;
  private LicenseNotificationServiceClient client;

  @BeforeClass
  public static void startStaticServer() {
    mockLicenseNotificationService = new MockLicenseNotificationService();
    mockServiceHelper =
        new MockServiceHelper(
            UUID.randomUUID().toString(),
            Arrays.<MockGrpcService>asList(mockLicenseNotificationService));
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
    LicenseNotificationServiceSettings settings =
        LicenseNotificationServiceSettings.newBuilder()
            .setTransportChannelProvider(channelProvider)
            .setCredentialsProvider(NoCredentialsProvider.create())
            .build();
    client = LicenseNotificationServiceClient.create(settings);
  }

  @After
  public void tearDown() throws Exception {
    client.close();
  }

  @Test
  public void listTest() throws Exception {
    LicenseNotificationList expectedResponse =
        LicenseNotificationList.newBuilder()
            .setKind("kind3292052")
            .addAllNotifications(new ArrayList<LicenseNotification>())
            .setNextPageToken("nextPageToken-1386094857")
            .build();
    mockLicenseNotificationService.addResponse(expectedResponse);

    LicenseNotificationListRequest request =
        LicenseNotificationListRequest.newBuilder()
            .setApplicationId("applicationId-1011352949")
            .setMaxResults(1128457243)
            .setStartToken("startToken-1583451465")
            .setTimestamp(55126294)
            .build();

    LicenseNotificationList actualResponse = client.list(request);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockLicenseNotificationService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    LicenseNotificationListRequest actualRequest =
        ((LicenseNotificationListRequest) actualRequests.get(0));

    Assert.assertEquals(request.getApplicationId(), actualRequest.getApplicationId());
    Assert.assertEquals(request.getMaxResults(), actualRequest.getMaxResults());
    Assert.assertEquals(request.getStartToken(), actualRequest.getStartToken());
    Assert.assertEquals(request.getTimestamp(), actualRequest.getTimestamp());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void listExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockLicenseNotificationService.addException(exception);

    try {
      LicenseNotificationListRequest request =
          LicenseNotificationListRequest.newBuilder()
              .setApplicationId("applicationId-1011352949")
              .setMaxResults(1128457243)
              .setStartToken("startToken-1583451465")
              .setTimestamp(55126294)
              .build();
      client.list(request);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }
}
