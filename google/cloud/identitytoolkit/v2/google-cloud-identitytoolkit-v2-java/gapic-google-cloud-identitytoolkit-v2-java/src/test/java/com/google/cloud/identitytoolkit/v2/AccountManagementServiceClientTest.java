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

package com.google.cloud.identitytoolkit.v2;

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
public class AccountManagementServiceClientTest {
  private static MockAccountManagementService mockAccountManagementService;
  private static MockServiceHelper mockServiceHelper;
  private LocalChannelProvider channelProvider;
  private AccountManagementServiceClient client;

  @BeforeClass
  public static void startStaticServer() {
    mockAccountManagementService = new MockAccountManagementService();
    mockServiceHelper =
        new MockServiceHelper(
            UUID.randomUUID().toString(),
            Arrays.<MockGrpcService>asList(mockAccountManagementService));
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
    AccountManagementServiceSettings settings =
        AccountManagementServiceSettings.newBuilder()
            .setTransportChannelProvider(channelProvider)
            .setCredentialsProvider(NoCredentialsProvider.create())
            .build();
    client = AccountManagementServiceClient.create(settings);
  }

  @After
  public void tearDown() throws Exception {
    client.close();
  }

  @Test
  public void finalizeMfaEnrollmentTest() throws Exception {
    FinalizeMfaEnrollmentResponse expectedResponse =
        FinalizeMfaEnrollmentResponse.newBuilder()
            .setIdToken("idToken1642509726")
            .setRefreshToken("refreshToken-56506402")
            .build();
    mockAccountManagementService.addResponse(expectedResponse);

    FinalizeMfaEnrollmentRequest request =
        FinalizeMfaEnrollmentRequest.newBuilder()
            .setIdToken("idToken1642509726")
            .setDisplayName("displayName1714148973")
            .setTenantId("tenantId-1306693787")
            .build();

    FinalizeMfaEnrollmentResponse actualResponse = client.finalizeMfaEnrollment(request);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockAccountManagementService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    FinalizeMfaEnrollmentRequest actualRequest =
        ((FinalizeMfaEnrollmentRequest) actualRequests.get(0));

    Assert.assertEquals(request.getIdToken(), actualRequest.getIdToken());
    Assert.assertEquals(request.getDisplayName(), actualRequest.getDisplayName());
    Assert.assertEquals(
        request.getPhoneVerificationInfo(), actualRequest.getPhoneVerificationInfo());
    Assert.assertEquals(request.getTenantId(), actualRequest.getTenantId());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void finalizeMfaEnrollmentExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockAccountManagementService.addException(exception);

    try {
      FinalizeMfaEnrollmentRequest request =
          FinalizeMfaEnrollmentRequest.newBuilder()
              .setIdToken("idToken1642509726")
              .setDisplayName("displayName1714148973")
              .setTenantId("tenantId-1306693787")
              .build();
      client.finalizeMfaEnrollment(request);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void startMfaEnrollmentTest() throws Exception {
    StartMfaEnrollmentResponse expectedResponse = StartMfaEnrollmentResponse.newBuilder().build();
    mockAccountManagementService.addResponse(expectedResponse);

    StartMfaEnrollmentRequest request =
        StartMfaEnrollmentRequest.newBuilder()
            .setIdToken("idToken1642509726")
            .setTenantId("tenantId-1306693787")
            .build();

    StartMfaEnrollmentResponse actualResponse = client.startMfaEnrollment(request);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockAccountManagementService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    StartMfaEnrollmentRequest actualRequest = ((StartMfaEnrollmentRequest) actualRequests.get(0));

    Assert.assertEquals(request.getIdToken(), actualRequest.getIdToken());
    Assert.assertEquals(request.getPhoneEnrollmentInfo(), actualRequest.getPhoneEnrollmentInfo());
    Assert.assertEquals(request.getTenantId(), actualRequest.getTenantId());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void startMfaEnrollmentExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockAccountManagementService.addException(exception);

    try {
      StartMfaEnrollmentRequest request =
          StartMfaEnrollmentRequest.newBuilder()
              .setIdToken("idToken1642509726")
              .setTenantId("tenantId-1306693787")
              .build();
      client.startMfaEnrollment(request);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void withdrawMfaTest() throws Exception {
    WithdrawMfaResponse expectedResponse =
        WithdrawMfaResponse.newBuilder()
            .setIdToken("idToken1642509726")
            .setRefreshToken("refreshToken-56506402")
            .build();
    mockAccountManagementService.addResponse(expectedResponse);

    WithdrawMfaRequest request =
        WithdrawMfaRequest.newBuilder()
            .setIdToken("idToken1642509726")
            .setMfaEnrollmentId("mfaEnrollmentId-1545987769")
            .setTenantId("tenantId-1306693787")
            .build();

    WithdrawMfaResponse actualResponse = client.withdrawMfa(request);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockAccountManagementService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    WithdrawMfaRequest actualRequest = ((WithdrawMfaRequest) actualRequests.get(0));

    Assert.assertEquals(request.getIdToken(), actualRequest.getIdToken());
    Assert.assertEquals(request.getMfaEnrollmentId(), actualRequest.getMfaEnrollmentId());
    Assert.assertEquals(request.getTenantId(), actualRequest.getTenantId());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void withdrawMfaExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockAccountManagementService.addException(exception);

    try {
      WithdrawMfaRequest request =
          WithdrawMfaRequest.newBuilder()
              .setIdToken("idToken1642509726")
              .setMfaEnrollmentId("mfaEnrollmentId-1545987769")
              .setTenantId("tenantId-1306693787")
              .build();
      client.withdrawMfa(request);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }
}
