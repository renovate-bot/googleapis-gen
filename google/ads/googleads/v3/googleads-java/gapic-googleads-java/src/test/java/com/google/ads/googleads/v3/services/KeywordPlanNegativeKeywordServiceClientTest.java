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

import com.google.ads.googleads.v3.resources.KeywordPlanNegativeKeyword;
import com.google.ads.googleads.v3.resources.KeywordPlanNegativeKeywordName;
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
public class KeywordPlanNegativeKeywordServiceClientTest {
  private static MockServiceHelper mockServiceHelper;
  private static MockKeywordPlanNegativeKeywordService mockKeywordPlanNegativeKeywordService;
  private KeywordPlanNegativeKeywordServiceClient client;
  private LocalChannelProvider channelProvider;

  @BeforeClass
  public static void startStaticServer() {
    mockKeywordPlanNegativeKeywordService = new MockKeywordPlanNegativeKeywordService();
    mockServiceHelper =
        new MockServiceHelper(
            UUID.randomUUID().toString(),
            Arrays.<MockGrpcService>asList(mockKeywordPlanNegativeKeywordService));
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
    KeywordPlanNegativeKeywordServiceSettings settings =
        KeywordPlanNegativeKeywordServiceSettings.newBuilder()
            .setTransportChannelProvider(channelProvider)
            .setCredentialsProvider(NoCredentialsProvider.create())
            .build();
    client = KeywordPlanNegativeKeywordServiceClient.create(settings);
  }

  @After
  public void tearDown() throws Exception {
    client.close();
  }

  @Test
  public void getKeywordPlanNegativeKeywordTest() throws Exception {
    KeywordPlanNegativeKeyword expectedResponse =
        KeywordPlanNegativeKeyword.newBuilder()
            .setResourceName(
                KeywordPlanNegativeKeywordName.of("[CUSTOMER]", "[KEYWORD_PLAN_NEGATIVE_KEYWORD]")
                    .toString())
            .setKeywordPlanCampaign(StringValue.newBuilder().build())
            .setId(Int64Value.newBuilder().build())
            .setText(StringValue.newBuilder().build())
            .build();
    mockKeywordPlanNegativeKeywordService.addResponse(expectedResponse);

    KeywordPlanNegativeKeywordName resourceName =
        KeywordPlanNegativeKeywordName.of("[CUSTOMER]", "[KEYWORD_PLAN_NEGATIVE_KEYWORD]");

    KeywordPlanNegativeKeyword actualResponse = client.getKeywordPlanNegativeKeyword(resourceName);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockKeywordPlanNegativeKeywordService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    GetKeywordPlanNegativeKeywordRequest actualRequest =
        ((GetKeywordPlanNegativeKeywordRequest) actualRequests.get(0));

    Assert.assertEquals(resourceName.toString(), actualRequest.getResourceName());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void getKeywordPlanNegativeKeywordExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockKeywordPlanNegativeKeywordService.addException(exception);

    try {
      KeywordPlanNegativeKeywordName resourceName =
          KeywordPlanNegativeKeywordName.of("[CUSTOMER]", "[KEYWORD_PLAN_NEGATIVE_KEYWORD]");
      client.getKeywordPlanNegativeKeyword(resourceName);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void getKeywordPlanNegativeKeywordTest2() throws Exception {
    KeywordPlanNegativeKeyword expectedResponse =
        KeywordPlanNegativeKeyword.newBuilder()
            .setResourceName(
                KeywordPlanNegativeKeywordName.of("[CUSTOMER]", "[KEYWORD_PLAN_NEGATIVE_KEYWORD]")
                    .toString())
            .setKeywordPlanCampaign(StringValue.newBuilder().build())
            .setId(Int64Value.newBuilder().build())
            .setText(StringValue.newBuilder().build())
            .build();
    mockKeywordPlanNegativeKeywordService.addResponse(expectedResponse);

    String resourceName = "resourceName-384566343";

    KeywordPlanNegativeKeyword actualResponse = client.getKeywordPlanNegativeKeyword(resourceName);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockKeywordPlanNegativeKeywordService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    GetKeywordPlanNegativeKeywordRequest actualRequest =
        ((GetKeywordPlanNegativeKeywordRequest) actualRequests.get(0));

    Assert.assertEquals(resourceName, actualRequest.getResourceName());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void getKeywordPlanNegativeKeywordExceptionTest2() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockKeywordPlanNegativeKeywordService.addException(exception);

    try {
      String resourceName = "resourceName-384566343";
      client.getKeywordPlanNegativeKeyword(resourceName);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void mutateKeywordPlanNegativeKeywordsTest() throws Exception {
    MutateKeywordPlanNegativeKeywordsResponse expectedResponse =
        MutateKeywordPlanNegativeKeywordsResponse.newBuilder()
            .setPartialFailureError(Status.newBuilder().build())
            .addAllResults(new ArrayList<MutateKeywordPlanNegativeKeywordResult>())
            .build();
    mockKeywordPlanNegativeKeywordService.addResponse(expectedResponse);

    String customerId = "customerId-1581184615";
    List<KeywordPlanNegativeKeywordOperation> operations = new ArrayList<>();

    MutateKeywordPlanNegativeKeywordsResponse actualResponse =
        client.mutateKeywordPlanNegativeKeywords(customerId, operations);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockKeywordPlanNegativeKeywordService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    MutateKeywordPlanNegativeKeywordsRequest actualRequest =
        ((MutateKeywordPlanNegativeKeywordsRequest) actualRequests.get(0));

    Assert.assertEquals(customerId, actualRequest.getCustomerId());
    Assert.assertEquals(operations, actualRequest.getOperationsList());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void mutateKeywordPlanNegativeKeywordsExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockKeywordPlanNegativeKeywordService.addException(exception);

    try {
      String customerId = "customerId-1581184615";
      List<KeywordPlanNegativeKeywordOperation> operations = new ArrayList<>();
      client.mutateKeywordPlanNegativeKeywords(customerId, operations);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }
}
