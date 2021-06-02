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

package com.google.cloud.dataqna.v1alpha;

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
public class AutoSuggestionServiceClientTest {
  private static MockAutoSuggestionService mockAutoSuggestionService;
  private static MockServiceHelper mockServiceHelper;
  private AutoSuggestionServiceClient client;
  private LocalChannelProvider channelProvider;

  @BeforeClass
  public static void startStaticServer() {
    mockAutoSuggestionService = new MockAutoSuggestionService();
    mockServiceHelper =
        new MockServiceHelper(
            UUID.randomUUID().toString(),
            Arrays.<MockGrpcService>asList(mockAutoSuggestionService));
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
    AutoSuggestionServiceSettings settings =
        AutoSuggestionServiceSettings.newBuilder()
            .setTransportChannelProvider(channelProvider)
            .setCredentialsProvider(NoCredentialsProvider.create())
            .build();
    client = AutoSuggestionServiceClient.create(settings);
  }

  @After
  public void tearDown() throws Exception {
    client.close();
  }

  @Test
  public void suggestQueriesTest() throws Exception {
    SuggestQueriesResponse expectedResponse =
        SuggestQueriesResponse.newBuilder().addAllSuggestions(new ArrayList<Suggestion>()).build();
    mockAutoSuggestionService.addResponse(expectedResponse);

    SuggestQueriesRequest request =
        SuggestQueriesRequest.newBuilder()
            .setParent(LocationName.of("[PROJECT]", "[LOCATION]").toString())
            .addAllScopes(new ArrayList<String>())
            .setQuery("query107944136")
            .addAllSuggestionTypes(new ArrayList<SuggestionType>())
            .build();

    SuggestQueriesResponse actualResponse = client.suggestQueries(request);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockAutoSuggestionService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    SuggestQueriesRequest actualRequest = ((SuggestQueriesRequest) actualRequests.get(0));

    Assert.assertEquals(request.getParent(), actualRequest.getParent());
    Assert.assertEquals(request.getScopesList(), actualRequest.getScopesList());
    Assert.assertEquals(request.getQuery(), actualRequest.getQuery());
    Assert.assertEquals(request.getSuggestionTypesList(), actualRequest.getSuggestionTypesList());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void suggestQueriesExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockAutoSuggestionService.addException(exception);

    try {
      SuggestQueriesRequest request =
          SuggestQueriesRequest.newBuilder()
              .setParent(LocationName.of("[PROJECT]", "[LOCATION]").toString())
              .addAllScopes(new ArrayList<String>())
              .setQuery("query107944136")
              .addAllSuggestionTypes(new ArrayList<SuggestionType>())
              .build();
      client.suggestQueries(request);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }
}
