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
import com.google.protobuf.Any;
import com.google.protobuf.FieldMask;
import com.google.protobuf.Timestamp;
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
public class QuestionServiceClientTest {
  private static MockQuestionService mockQuestionService;
  private static MockServiceHelper mockServiceHelper;
  private QuestionServiceClient client;
  private LocalChannelProvider channelProvider;

  @BeforeClass
  public static void startStaticServer() {
    mockQuestionService = new MockQuestionService();
    mockServiceHelper =
        new MockServiceHelper(
            UUID.randomUUID().toString(), Arrays.<MockGrpcService>asList(mockQuestionService));
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
    QuestionServiceSettings settings =
        QuestionServiceSettings.newBuilder()
            .setTransportChannelProvider(channelProvider)
            .setCredentialsProvider(NoCredentialsProvider.create())
            .build();
    client = QuestionServiceClient.create(settings);
  }

  @After
  public void tearDown() throws Exception {
    client.close();
  }

  @Test
  public void getQuestionTest() throws Exception {
    Question expectedResponse =
        Question.newBuilder()
            .setName(QuestionName.of("[PROJECT]", "[LOCATION]", "[QUESTION]").toString())
            .addAllScopes(new ArrayList<String>())
            .setQuery("query107944136")
            .addAllDataSourceAnnotations(new ArrayList<String>())
            .setInterpretError(InterpretError.newBuilder().build())
            .addAllInterpretations(new ArrayList<Interpretation>())
            .setCreateTime(Timestamp.newBuilder().build())
            .setUserEmail("userEmail315299473")
            .setDebugFlags(DebugFlags.newBuilder().build())
            .setDebugInfo(Any.newBuilder().build())
            .build();
    mockQuestionService.addResponse(expectedResponse);

    QuestionName name = QuestionName.of("[PROJECT]", "[LOCATION]", "[QUESTION]");

    Question actualResponse = client.getQuestion(name);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockQuestionService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    GetQuestionRequest actualRequest = ((GetQuestionRequest) actualRequests.get(0));

    Assert.assertEquals(name.toString(), actualRequest.getName());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void getQuestionExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockQuestionService.addException(exception);

    try {
      QuestionName name = QuestionName.of("[PROJECT]", "[LOCATION]", "[QUESTION]");
      client.getQuestion(name);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void getQuestionTest2() throws Exception {
    Question expectedResponse =
        Question.newBuilder()
            .setName(QuestionName.of("[PROJECT]", "[LOCATION]", "[QUESTION]").toString())
            .addAllScopes(new ArrayList<String>())
            .setQuery("query107944136")
            .addAllDataSourceAnnotations(new ArrayList<String>())
            .setInterpretError(InterpretError.newBuilder().build())
            .addAllInterpretations(new ArrayList<Interpretation>())
            .setCreateTime(Timestamp.newBuilder().build())
            .setUserEmail("userEmail315299473")
            .setDebugFlags(DebugFlags.newBuilder().build())
            .setDebugInfo(Any.newBuilder().build())
            .build();
    mockQuestionService.addResponse(expectedResponse);

    String name = "name3373707";

    Question actualResponse = client.getQuestion(name);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockQuestionService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    GetQuestionRequest actualRequest = ((GetQuestionRequest) actualRequests.get(0));

    Assert.assertEquals(name, actualRequest.getName());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void getQuestionExceptionTest2() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockQuestionService.addException(exception);

    try {
      String name = "name3373707";
      client.getQuestion(name);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void createQuestionTest() throws Exception {
    Question expectedResponse =
        Question.newBuilder()
            .setName(QuestionName.of("[PROJECT]", "[LOCATION]", "[QUESTION]").toString())
            .addAllScopes(new ArrayList<String>())
            .setQuery("query107944136")
            .addAllDataSourceAnnotations(new ArrayList<String>())
            .setInterpretError(InterpretError.newBuilder().build())
            .addAllInterpretations(new ArrayList<Interpretation>())
            .setCreateTime(Timestamp.newBuilder().build())
            .setUserEmail("userEmail315299473")
            .setDebugFlags(DebugFlags.newBuilder().build())
            .setDebugInfo(Any.newBuilder().build())
            .build();
    mockQuestionService.addResponse(expectedResponse);

    LocationName parent = LocationName.of("[PROJECT]", "[LOCATION]");
    Question question = Question.newBuilder().build();

    Question actualResponse = client.createQuestion(parent, question);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockQuestionService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    CreateQuestionRequest actualRequest = ((CreateQuestionRequest) actualRequests.get(0));

    Assert.assertEquals(parent.toString(), actualRequest.getParent());
    Assert.assertEquals(question, actualRequest.getQuestion());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void createQuestionExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockQuestionService.addException(exception);

    try {
      LocationName parent = LocationName.of("[PROJECT]", "[LOCATION]");
      Question question = Question.newBuilder().build();
      client.createQuestion(parent, question);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void createQuestionTest2() throws Exception {
    Question expectedResponse =
        Question.newBuilder()
            .setName(QuestionName.of("[PROJECT]", "[LOCATION]", "[QUESTION]").toString())
            .addAllScopes(new ArrayList<String>())
            .setQuery("query107944136")
            .addAllDataSourceAnnotations(new ArrayList<String>())
            .setInterpretError(InterpretError.newBuilder().build())
            .addAllInterpretations(new ArrayList<Interpretation>())
            .setCreateTime(Timestamp.newBuilder().build())
            .setUserEmail("userEmail315299473")
            .setDebugFlags(DebugFlags.newBuilder().build())
            .setDebugInfo(Any.newBuilder().build())
            .build();
    mockQuestionService.addResponse(expectedResponse);

    String parent = "parent-995424086";
    Question question = Question.newBuilder().build();

    Question actualResponse = client.createQuestion(parent, question);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockQuestionService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    CreateQuestionRequest actualRequest = ((CreateQuestionRequest) actualRequests.get(0));

    Assert.assertEquals(parent, actualRequest.getParent());
    Assert.assertEquals(question, actualRequest.getQuestion());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void createQuestionExceptionTest2() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockQuestionService.addException(exception);

    try {
      String parent = "parent-995424086";
      Question question = Question.newBuilder().build();
      client.createQuestion(parent, question);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void executeQuestionTest() throws Exception {
    Question expectedResponse =
        Question.newBuilder()
            .setName(QuestionName.of("[PROJECT]", "[LOCATION]", "[QUESTION]").toString())
            .addAllScopes(new ArrayList<String>())
            .setQuery("query107944136")
            .addAllDataSourceAnnotations(new ArrayList<String>())
            .setInterpretError(InterpretError.newBuilder().build())
            .addAllInterpretations(new ArrayList<Interpretation>())
            .setCreateTime(Timestamp.newBuilder().build())
            .setUserEmail("userEmail315299473")
            .setDebugFlags(DebugFlags.newBuilder().build())
            .setDebugInfo(Any.newBuilder().build())
            .build();
    mockQuestionService.addResponse(expectedResponse);

    String name = "name3373707";
    int interpretationIndex = -1924823077;

    Question actualResponse = client.executeQuestion(name, interpretationIndex);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockQuestionService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    ExecuteQuestionRequest actualRequest = ((ExecuteQuestionRequest) actualRequests.get(0));

    Assert.assertEquals(name, actualRequest.getName());
    Assert.assertEquals(interpretationIndex, actualRequest.getInterpretationIndex());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void executeQuestionExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockQuestionService.addException(exception);

    try {
      String name = "name3373707";
      int interpretationIndex = -1924823077;
      client.executeQuestion(name, interpretationIndex);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void getUserFeedbackTest() throws Exception {
    UserFeedback expectedResponse =
        UserFeedback.newBuilder()
            .setName(UserFeedbackName.of("[PROJECT]", "[LOCATION]", "[QUESTION]").toString())
            .setFreeFormFeedback("freeFormFeedback-1509261067")
            .build();
    mockQuestionService.addResponse(expectedResponse);

    UserFeedbackName name = UserFeedbackName.of("[PROJECT]", "[LOCATION]", "[QUESTION]");

    UserFeedback actualResponse = client.getUserFeedback(name);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockQuestionService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    GetUserFeedbackRequest actualRequest = ((GetUserFeedbackRequest) actualRequests.get(0));

    Assert.assertEquals(name.toString(), actualRequest.getName());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void getUserFeedbackExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockQuestionService.addException(exception);

    try {
      UserFeedbackName name = UserFeedbackName.of("[PROJECT]", "[LOCATION]", "[QUESTION]");
      client.getUserFeedback(name);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void getUserFeedbackTest2() throws Exception {
    UserFeedback expectedResponse =
        UserFeedback.newBuilder()
            .setName(UserFeedbackName.of("[PROJECT]", "[LOCATION]", "[QUESTION]").toString())
            .setFreeFormFeedback("freeFormFeedback-1509261067")
            .build();
    mockQuestionService.addResponse(expectedResponse);

    String name = "name3373707";

    UserFeedback actualResponse = client.getUserFeedback(name);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockQuestionService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    GetUserFeedbackRequest actualRequest = ((GetUserFeedbackRequest) actualRequests.get(0));

    Assert.assertEquals(name, actualRequest.getName());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void getUserFeedbackExceptionTest2() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockQuestionService.addException(exception);

    try {
      String name = "name3373707";
      client.getUserFeedback(name);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }

  @Test
  public void updateUserFeedbackTest() throws Exception {
    UserFeedback expectedResponse =
        UserFeedback.newBuilder()
            .setName(UserFeedbackName.of("[PROJECT]", "[LOCATION]", "[QUESTION]").toString())
            .setFreeFormFeedback("freeFormFeedback-1509261067")
            .build();
    mockQuestionService.addResponse(expectedResponse);

    UserFeedback userFeedback = UserFeedback.newBuilder().build();
    FieldMask updateMask = FieldMask.newBuilder().build();

    UserFeedback actualResponse = client.updateUserFeedback(userFeedback, updateMask);
    Assert.assertEquals(expectedResponse, actualResponse);

    List<AbstractMessage> actualRequests = mockQuestionService.getRequests();
    Assert.assertEquals(1, actualRequests.size());
    UpdateUserFeedbackRequest actualRequest = ((UpdateUserFeedbackRequest) actualRequests.get(0));

    Assert.assertEquals(userFeedback, actualRequest.getUserFeedback());
    Assert.assertEquals(updateMask, actualRequest.getUpdateMask());
    Assert.assertTrue(
        channelProvider.isHeaderSent(
            ApiClientHeaderProvider.getDefaultApiClientHeaderKey(),
            GaxGrpcProperties.getDefaultApiClientHeaderPattern()));
  }

  @Test
  public void updateUserFeedbackExceptionTest() throws Exception {
    StatusRuntimeException exception = new StatusRuntimeException(io.grpc.Status.INVALID_ARGUMENT);
    mockQuestionService.addException(exception);

    try {
      UserFeedback userFeedback = UserFeedback.newBuilder().build();
      FieldMask updateMask = FieldMask.newBuilder().build();
      client.updateUserFeedback(userFeedback, updateMask);
      Assert.fail("No exception raised");
    } catch (InvalidArgumentException e) {
      // Expected exception.
    }
  }
}
