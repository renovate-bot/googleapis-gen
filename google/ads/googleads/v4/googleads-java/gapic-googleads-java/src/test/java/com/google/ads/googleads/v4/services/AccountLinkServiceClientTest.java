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

package com.google.ads.googleads.v4.services;

import com.google.ads.googleads.v4.resources.AccountLink;
import com.google.ads.googleads.v4.resources.AccountLinkName;
import com.google.api.gax.core.NoCredentialsProvider;
import com.google.api.gax.grpc.GaxGrpcProperties;
import com.google.api.gax.grpc.testing.LocalChannelProvider;
import com.google.api.gax.grpc.testing.MockGrpcService;
import com.google.api.gax.grpc.testing.MockServiceHelper;
import com.google.api.gax.rpc.ApiClientHeaderProvider;
import com.google.api.gax.rpc.InvalidArgumentException;
import com.google.protobuf.AbstractMessage;
import com.google.protobuf.Int64Value;
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
public class AccountLinkServiceClientTest {
  private static MockAccountLinkService mockAccountLinkService;
  private static MockServiceHelper mockServiceHelper;
  private AccountLinkServiceClient client;
  private LocalChannelProvider channelProvider;

  @BeforeClass
  public static void startStaticServer() {
    mockAccountLinkService = new MockAccountLinkService();
    mockServiceHelper =
        new MockServiceHelper(
            UUID.randomUUID().toString(), Arrays.<MockGrpcService>asList(mockAccountLinkService));
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
    AccountLinkServiceSettings settings =
        AccountLinkServiceSettings.newBuilder()
            .setTransportChannelProvider(channelProvider)
            .setCredentialsProvider(NoCredentialsProvider.create())
            .build();
    client = AccountLinkServiceClient.create(settings);
  }

  @After
  public void tearDown() throws Exception {
    client.close();
  }

  @Test
  public void getAccountLinkTest() throws Exception {
    AccountLink expectedResponse =
        AccountLink.newBuilder()
            .setResourceName(AccountLinkName.of("[CUSTOMER]", "[ACCOUNT_LINK]").toString())
            .setAccountLinkId(Int64Value.newBuilder().build())
            .build();
    mockAccountLinkService.addResponse(expectedResponse);

    AccountLinkName resourceName = AccountLinkName.of("[CUSTOMER]", "[ACCOUNT_LINK]");

    AccountLink actualResponse = client.getAccountLink(resourceName);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockAccountLinkService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    GetAccountLinkRequest actualRequest = ((GetAccountLinkRequest) actualRequests.get(0));

    Assert.assertEquals(resourceName.toString(), actualRequest.getResourceName());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void getAccountLinkExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockAccountLinkService.addException(exception);

    try {
      AccountLinkName resourceName = AccountLinkName.of("[CUSTOMER]", "[ACCOUNT_LINK]");
      client.getAccountLink(resourceName);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void getAccountLinkTest2() throws Exception {
    AccountLink expectedResponse =
        AccountLink.newBuilder()
            .setResourceName(AccountLinkName.of("[CUSTOMER]", "[ACCOUNT_LINK]").toString())
            .setAccountLinkId(Int64Value.newBuilder().build())
            .build();
    mockAccountLinkService.addResponse(expectedResponse);

    String resourceName = "resourceName-384566343";

    AccountLink actualResponse = client.getAccountLink(resourceName);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockAccountLinkService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    GetAccountLinkRequest actualRequest = ((GetAccountLinkRequest) actualRequests.get(0));

    Assert.assertEquals(resourceName, actualRequest.getResourceName());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void getAccountLinkExceptionTest2() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockAccountLinkService.addException(exception);

    try {
      String resourceName = "resourceName-384566343";
      client.getAccountLink(resourceName);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void mutateAccountLinkTest() throws Exception {
    MutateAccountLinkResponse expectedResponse =
        MutateAccountLinkResponse.newBuilder()
            .setResult(MutateAccountLinkResult.newBuilder().build())
            .build();
    mockAccountLinkService.addResponse(expectedResponse);

    String customerId = "customerId-1581184615";
    AccountLinkOperation operation = AccountLinkOperation.newBuilder().build();

    MutateAccountLinkResponse actualResponse = client.mutateAccountLink(customerId, operation);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockAccountLinkService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    MutateAccountLinkRequest actualRequest = ((MutateAccountLinkRequest) actualRequests.get(0));

    Assert.assertEquals(customerId, actualRequest.getCustomerId());
    Assert.assertEquals(operation, actualRequest.getOperation());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void mutateAccountLinkExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockAccountLinkService.addException(exception);

    try {
      String customerId = "customerId-1581184615";
      AccountLinkOperation operation = AccountLinkOperation.newBuilder().build();
      client.mutateAccountLink(customerId, operation);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }
}
