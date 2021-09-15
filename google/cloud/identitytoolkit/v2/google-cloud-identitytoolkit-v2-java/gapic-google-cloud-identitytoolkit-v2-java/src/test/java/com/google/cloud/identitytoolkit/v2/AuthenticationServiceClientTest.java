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
public class AuthenticationServiceClientTest {
  private static MockAuthenticationService mockAuthenticationService;
  private static MockServiceHelper mockServiceHelper;
  private LocalChannelProvider channelProvider;
  private AuthenticationServiceClient client;

  @BeforeClass
  public static void startStaticServer() {
    mockAuthenticationService = new MockAuthenticationService();
    mockServiceHelper =
        new MockServiceHelper(
            UUID.randomUUID().toString(),
            Arrays.<MockGrpcService>asList(mockAuthenticationService));
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
    AuthenticationServiceSettings settings =
        AuthenticationServiceSettings.newBuilder()
            .setTransportChannelProvider(channelProvider)
            .setCredentialsProvider(NoCredentialsProvider.create())
            .build();
    client = AuthenticationServiceClient.create(settings);
  }

  @After
  public void tearDown() throws Exception {
    client.close();
  }

  @Test
  public void finalizeMfaSignInTest() throws Exception {
    FinalizeMfaSignInResponse expectedResponse =
        FinalizeMfaSignInResponse.newBuilder()
            .setIdToken("idToken1642509726")
            .setRefreshToken("refreshToken-56506402")
            .build();
    mockAuthenticationService.addResponse(expectedResponse);

    FinalizeMfaSignInRequest request =
        FinalizeMfaSignInRequest.newBuilder()
            .setMfaPendingCredential("mfaPendingCredential1875551302")
            .setTenantId("tenantId-1306693787")
            .build();

    FinalizeMfaSignInResponse actualResponse = client.finalizeMfaSignIn(request);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockAuthenticationService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    FinalizeMfaSignInRequest actualRequest = ((FinalizeMfaSignInRequest) actualRequests.get(0));

    Assert.assertEquals(request.getMfaPendingCredential(), actualRequest.getMfaPendingCredential());
    Assert.assertEquals(
        request.getPhoneVerificationInfo(), actualRequest.getPhoneVerificationInfo());
    Assert.assertEquals(request.getTenantId(), actualRequest.getTenantId());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void finalizeMfaSignInExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockAuthenticationService.addException(exception);

    try {
      FinalizeMfaSignInRequest request =
          FinalizeMfaSignInRequest.newBuilder()
              .setMfaPendingCredential("mfaPendingCredential1875551302")
              .setTenantId("tenantId-1306693787")
              .build();
      client.finalizeMfaSignIn(request);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void startMfaSignInTest() throws Exception {
    StartMfaSignInResponse expectedResponse = StartMfaSignInResponse.newBuilder().build();
    mockAuthenticationService.addResponse(expectedResponse);

    StartMfaSignInRequest request =
        StartMfaSignInRequest.newBuilder()
            .setMfaPendingCredential("mfaPendingCredential1875551302")
            .setMfaEnrollmentId("mfaEnrollmentId-1545987769")
            .setTenantId("tenantId-1306693787")
            .build();

    StartMfaSignInResponse actualResponse = client.startMfaSignIn(request);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockAuthenticationService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    StartMfaSignInRequest actualRequest = ((StartMfaSignInRequest) actualRequests.get(0));

    Assert.assertEquals(request.getMfaPendingCredential(), actualRequest.getMfaPendingCredential());
    Assert.assertEquals(request.getMfaEnrollmentId(), actualRequest.getMfaEnrollmentId());
    Assert.assertEquals(request.getPhoneSignInInfo(), actualRequest.getPhoneSignInInfo());
    Assert.assertEquals(request.getTenantId(), actualRequest.getTenantId());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void startMfaSignInExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockAuthenticationService.addException(exception);

    try {
      StartMfaSignInRequest request =
          StartMfaSignInRequest.newBuilder()
              .setMfaPendingCredential("mfaPendingCredential1875551302")
              .setMfaEnrollmentId("mfaEnrollmentId-1545987769")
              .setTenantId("tenantId-1306693787")
              .build();
      client.startMfaSignIn(request);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }
}
