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

package com.google.ads.googleads.v3.services;

import com.google.ads.googleads.v3.resources.KeywordPlanKeyword;
import com.google.ads.googleads.v3.resources.KeywordPlanKeywordName;
import com.google.api.gax.core.NoCredentialsProvider;
import com.google.api.gax.grpc.GaxGrpcProperties;
import com.google.api.gax.grpc.testing.LocalChannelProvider;
import com.google.api.gax.grpc.testing.MockGrpcService;
import com.google.api.gax.grpc.testing.MockServiceHelper;
import com.google.api.gax.rpc.ApiClientHeaderProvider;
import com.google.api.gax.rpc.InvalidArgumentException;
import com.google.protobuf.AbstractMessage;
import com.google.protobuf.Int64Value;
import com.google.protobuf.StringValue;
import com.google.rpc.Status;
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
public class KeywordPlanKeywordServiceClientTest {
  private static MockServiceHelper mockServiceHelper;
  private KeywordPlanKeywordServiceClient client;
  private static MockKeywordPlanKeywordService mockKeywordPlanKeywordService;
  private LocalChannelProvider channelProvider;

  @BeforeClass
  public static void startStaticServer() {
    mockKeywordPlanKeywordService = new MockKeywordPlanKeywordService();
    mockServiceHelper =
        new MockServiceHelper(
            UUID.randomUUID().toString(),
            Arrays.<MockGrpcService>asList(mockKeywordPlanKeywordService));
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
    KeywordPlanKeywordServiceSettings settings =
        KeywordPlanKeywordServiceSettings.newBuilder()
            .setTransportChannelProvider(channelProvider)
            .setCredentialsProvider(NoCredentialsProvider.create())
            .build();
    client = KeywordPlanKeywordServiceClient.create(settings);
  }

  @After
  public void tearDown() throws Exception {
    client.close();
  }

  @Test
  public void getKeywordPlanKeywordTest() throws Exception {
    KeywordPlanKeyword expectedResponse =
        KeywordPlanKeyword.newBuilder()
            .setResourceName(
                KeywordPlanKeywordName.of("[CUSTOMER]", "[KEYWORD_PLAN_KEYWORD]").toString())
            .setKeywordPlanAdGroup(StringValue.newBuilder().build())
            .setId(Int64Value.newBuilder().build())
            .setText(StringValue.newBuilder().build())
            .setCpcBidMicros(Int64Value.newBuilder().build())
            .build();
    mockKeywordPlanKeywordService.addResponse(expectedResponse);

    KeywordPlanKeywordName resourceName =
        KeywordPlanKeywordName.of("[CUSTOMER]", "[KEYWORD_PLAN_KEYWORD]");

    KeywordPlanKeyword actualResponse = client.getKeywordPlanKeyword(resourceName);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockKeywordPlanKeywordService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    GetKeywordPlanKeywordRequest actualRequest =
        ((GetKeywordPlanKeywordRequest) actualRequests.get(0));

    Assert.assertEquals(resourceName.toString(), actualRequest.getResourceName());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void getKeywordPlanKeywordExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockKeywordPlanKeywordService.addException(exception);

    try {
      KeywordPlanKeywordName resourceName =
          KeywordPlanKeywordName.of("[CUSTOMER]", "[KEYWORD_PLAN_KEYWORD]");
      client.getKeywordPlanKeyword(resourceName);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void getKeywordPlanKeywordTest2() throws Exception {
    KeywordPlanKeyword expectedResponse =
        KeywordPlanKeyword.newBuilder()
            .setResourceName(
                KeywordPlanKeywordName.of("[CUSTOMER]", "[KEYWORD_PLAN_KEYWORD]").toString())
            .setKeywordPlanAdGroup(StringValue.newBuilder().build())
            .setId(Int64Value.newBuilder().build())
            .setText(StringValue.newBuilder().build())
            .setCpcBidMicros(Int64Value.newBuilder().build())
            .build();
    mockKeywordPlanKeywordService.addResponse(expectedResponse);

    String resourceName = "resourceName-384566343";

    KeywordPlanKeyword actualResponse = client.getKeywordPlanKeyword(resourceName);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockKeywordPlanKeywordService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    GetKeywordPlanKeywordRequest actualRequest =
        ((GetKeywordPlanKeywordRequest) actualRequests.get(0));

    Assert.assertEquals(resourceName, actualRequest.getResourceName());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void getKeywordPlanKeywordExceptionTest2() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockKeywordPlanKeywordService.addException(exception);

    try {
      String resourceName = "resourceName-384566343";
      client.getKeywordPlanKeyword(resourceName);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void mutateKeywordPlanKeywordsTest() throws Exception {
    MutateKeywordPlanKeywordsResponse expectedResponse =
        MutateKeywordPlanKeywordsResponse.newBuilder()
            .setPartialFailureError(Status.newBuilder().build())
            .addAllResults(new ArrayList<MutateKeywordPlanKeywordResult>())
            .build();
    mockKeywordPlanKeywordService.addResponse(expectedResponse);

    String customerId = "customerId-1581184615";
    List<KeywordPlanKeywordOperation> operations = new ArrayList<>();

    MutateKeywordPlanKeywordsResponse actualResponse =
        client.mutateKeywordPlanKeywords(customerId, operations);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockKeywordPlanKeywordService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    MutateKeywordPlanKeywordsRequest actualRequest =
        ((MutateKeywordPlanKeywordsRequest) actualRequests.get(0));

    Assert.assertEquals(customerId, actualRequest.getCustomerId());
    Assert.assertEquals(operations, actualRequest.getOperationsList());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void mutateKeywordPlanKeywordsExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockKeywordPlanKeywordService.addException(exception);

    try {
      String customerId = "customerId-1581184615";
      List<KeywordPlanKeywordOperation> operations = new ArrayList<>();
      client.mutateKeywordPlanKeywords(customerId, operations);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }
}
