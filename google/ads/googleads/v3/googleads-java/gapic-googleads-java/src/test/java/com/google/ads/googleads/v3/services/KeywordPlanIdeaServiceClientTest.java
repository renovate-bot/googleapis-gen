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

import com.google.api.gax.core.NoCredentialsProvider;
import com.google.api.gax.grpc.GaxGrpcProperties;
import com.google.api.gax.grpc.testing.LocalChannelProvider;
import com.google.api.gax.grpc.testing.MockGrpcService;
import com.google.api.gax.grpc.testing.MockServiceHelper;
import com.google.api.gax.rpc.ApiClientHeaderProvider;
import com.google.api.gax.rpc.InvalidArgumentException;
import com.google.protobuf.AbstractMessage;
import com.google.protobuf.StringValue;
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
public class KeywordPlanIdeaServiceClientTest {
  private static MockServiceHelper mockServiceHelper;
  private KeywordPlanIdeaServiceClient client;
  private static MockKeywordPlanIdeaService mockKeywordPlanIdeaService;
  private LocalChannelProvider channelProvider;

  @BeforeClass
  public static void startStaticServer() {
    mockKeywordPlanIdeaService = new MockKeywordPlanIdeaService();
    mockServiceHelper =
        new MockServiceHelper(
            UUID.randomUUID().toString(),
            Arrays.<MockGrpcService>asList(mockKeywordPlanIdeaService));
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
    KeywordPlanIdeaServiceSettings settings =
        KeywordPlanIdeaServiceSettings.newBuilder()
            .setTransportChannelProvider(channelProvider)
            .setCredentialsProvider(NoCredentialsProvider.create())
            .build();
    client = KeywordPlanIdeaServiceClient.create(settings);
  }

  @After
  public void tearDown() throws Exception {
    client.close();
  }

  @Test
  public void generateKeywordIdeasTest() throws Exception {
    GenerateKeywordIdeaResponse expectedResponse =
        GenerateKeywordIdeaResponse.newBuilder()
            .addAllResults(new ArrayList<GenerateKeywordIdeaResult>())
            .build();
    mockKeywordPlanIdeaService.addResponse(expectedResponse);

    GenerateKeywordIdeasRequest request =
        GenerateKeywordIdeasRequest.newBuilder()
            .setCustomerId("customerId-1581184615")
            .setLanguage(StringValue.newBuilder().build())
            .addAllGeoTargetConstants(new ArrayList<StringValue>())
            .build();

    GenerateKeywordIdeaResponse actualResponse = client.generateKeywordIdeas(request);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockKeywordPlanIdeaService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    GenerateKeywordIdeasRequest actualRequest =
        ((GenerateKeywordIdeasRequest) actualRequests.get(0));

    Assert.assertEquals(request.getCustomerId(), actualRequest.getCustomerId());
    Assert.assertEquals(request.getLanguage(), actualRequest.getLanguage());
    Assert.assertEquals(
        request.getGeoTargetConstantsList(), actualRequest.getGeoTargetConstantsList());
    Assert.assertEquals(request.getKeywordPlanNetwork(), actualRequest.getKeywordPlanNetwork());
    Assert.assertEquals(request.getKeywordAndUrlSeed(), actualRequest.getKeywordAndUrlSeed());
    Assert.assertEquals(request.getKeywordSeed(), actualRequest.getKeywordSeed());
    Assert.assertEquals(request.getUrlSeed(), actualRequest.getUrlSeed());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void generateKeywordIdeasExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockKeywordPlanIdeaService.addException(exception);

    try {
      GenerateKeywordIdeasRequest request =
          GenerateKeywordIdeasRequest.newBuilder()
              .setCustomerId("customerId-1581184615")
              .setLanguage(StringValue.newBuilder().build())
              .addAllGeoTargetConstants(new ArrayList<StringValue>())
              .build();
      client.generateKeywordIdeas(request);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }
}
