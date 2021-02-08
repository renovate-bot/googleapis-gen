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

package com.google.cloud.dataqna.v1alpha;

import com.google.api.core.BetaApi;
import com.google.api.gax.core.BackgroundResource;
import com.google.api.gax.rpc.UnaryCallable;
import com.google.cloud.dataqna.v1alpha.stub.QuestionServiceStub;
import com.google.cloud.dataqna.v1alpha.stub.QuestionServiceStubSettings;
import com.google.protobuf.FieldMask;
import java.io.IOException;
import java.util.concurrent.TimeUnit;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * Service Description: Service to interpret natural language queries. The service allows to create
 * `Question` resources that are interpreted and are filled with one or more interpretations if the
 * question could be interpreted. Once a `Question` resource is created and has at least one
 * interpretation, an interpretation can be chosen for execution, which triggers a query to the
 * backend (for BigQuery, it will create a job). Upon successful execution of that interpretation,
 * backend specific information will be returned so that the client can retrieve the results from
 * the backend.
 *
 * <p>The `Question` resources are named `projects/&#42;/locations/&#42;/questions/&#42;`.
 *
 * <p>The `Question` resource has a singletion sub-resource `UserFeedback` named
 * `projects/&#42;/locations/&#42;/questions/&#42;/userFeedback`, which allows access to user
 * feedback.
 *
 * <p>This class provides the ability to make remote calls to the backing service through method
 * calls that map to API methods. Sample code to get started:
 *
 * <pre>{@code
 * try (QuestionServiceClient questionServiceClient = QuestionServiceClient.create()) {
 *   QuestionName name = QuestionName.of("[PROJECT]", "[LOCATION]", "[QUESTION]");
 *   Question response = questionServiceClient.getQuestion(name);
 * }
 * }</pre>
 *
 * <p>Note: close() needs to be called on the QuestionServiceClient object to clean up resources
 * such as threads. In the example above, try-with-resources is used, which automatically calls
 * close().
 *
 * <p>The surface of this class includes several types of Java methods for each of the API's
 * methods:
 *
 * <ol>
 *   <li>A "flattened" method. With this type of method, the fields of the request type have been
 *       converted into function parameters. It may be the case that not all fields are available as
 *       parameters, and not every API method will have a flattened method entry point.
 *   <li>A "request object" method. This type of method only takes one parameter, a request object,
 *       which must be constructed before the call. Not every API method will have a request object
 *       method.
 *   <li>A "callable" method. This type of method takes no parameters and returns an immutable API
 *       callable object, which can be used to initiate calls to the service.
 * </ol>
 *
 * <p>See the individual methods for example code.
 *
 * <p>Many parameters require resource names to be formatted in a particular way. To assist with
 * these names, this class includes a format method for each type of name, and additionally a parse
 * method to extract the individual identifiers contained within names that are returned.
 *
 * <p>This class can be customized by passing in a custom instance of QuestionServiceSettings to
 * create(). For example:
 *
 * <p>To customize credentials:
 *
 * <pre>{@code
 * QuestionServiceSettings questionServiceSettings =
 *     QuestionServiceSettings.newBuilder()
 *         .setCredentialsProvider(FixedCredentialsProvider.create(myCredentials))
 *         .build();
 * QuestionServiceClient questionServiceClient =
 *     QuestionServiceClient.create(questionServiceSettings);
 * }</pre>
 *
 * <p>To customize the endpoint:
 *
 * <pre>{@code
 * QuestionServiceSettings questionServiceSettings =
 *     QuestionServiceSettings.newBuilder().setEndpoint(myEndpoint).build();
 * QuestionServiceClient questionServiceClient =
 *     QuestionServiceClient.create(questionServiceSettings);
 * }</pre>
 *
 * <p>Please refer to the GitHub repository's samples for more quickstart code snippets.
 */
@BetaApi
@Generated("by gapic-generator-java")
public class QuestionServiceClient implements BackgroundResource {
  private final QuestionServiceSettings settings;
  private final QuestionServiceStub stub;

  /** Constructs an instance of QuestionServiceClient with default settings. */
  public static final QuestionServiceClient create() throws IOException {
    return create(QuestionServiceSettings.newBuilder().build());
  }

  /**
   * Constructs an instance of QuestionServiceClient, using the given settings. The channels are
   * created based on the settings passed in, or defaults for any settings that are not set.
   */
  public static final QuestionServiceClient create(QuestionServiceSettings settings)
      throws IOException {
    return new QuestionServiceClient(settings);
  }

  /**
   * Constructs an instance of QuestionServiceClient, using the given stub for making calls. This is
   * for advanced usage - prefer using create(QuestionServiceSettings).
   */
  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public static final QuestionServiceClient create(QuestionServiceStub stub) {
    return new QuestionServiceClient(stub);
  }

  /**
   * Constructs an instance of QuestionServiceClient, using the given settings. This is protected so
   * that it is easy to make a subclass, but otherwise, the static factory methods should be
   * preferred.
   */
  protected QuestionServiceClient(QuestionServiceSettings settings) throws IOException {
    this.settings = settings;
    this.stub = ((QuestionServiceStubSettings) settings.getStubSettings()).createStub();
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  protected QuestionServiceClient(QuestionServiceStub stub) {
    this.settings = null;
    this.stub = stub;
  }

  public final QuestionServiceSettings getSettings() {
    return settings;
  }

  @BetaApi("A restructuring of stub classes is planned, so this may break in the future")
  public QuestionServiceStub getStub() {
    return stub;
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets a previously created question.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (QuestionServiceClient questionServiceClient = QuestionServiceClient.create()) {
   *   QuestionName name = QuestionName.of("[PROJECT]", "[LOCATION]", "[QUESTION]");
   *   Question response = questionServiceClient.getQuestion(name);
   * }
   * }</pre>
   *
   * @param name Required. The unique identifier for the question. Example:
   *     `projects/foo/locations/bar/questions/1234`
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final Question getQuestion(QuestionName name) {
    GetQuestionRequest request =
        GetQuestionRequest.newBuilder().setName(name == null ? null : name.toString()).build();
    return getQuestion(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets a previously created question.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (QuestionServiceClient questionServiceClient = QuestionServiceClient.create()) {
   *   String name = QuestionName.of("[PROJECT]", "[LOCATION]", "[QUESTION]").toString();
   *   Question response = questionServiceClient.getQuestion(name);
   * }
   * }</pre>
   *
   * @param name Required. The unique identifier for the question. Example:
   *     `projects/foo/locations/bar/questions/1234`
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final Question getQuestion(String name) {
    GetQuestionRequest request = GetQuestionRequest.newBuilder().setName(name).build();
    return getQuestion(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets a previously created question.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (QuestionServiceClient questionServiceClient = QuestionServiceClient.create()) {
   *   GetQuestionRequest request =
   *       GetQuestionRequest.newBuilder()
   *           .setName(QuestionName.of("[PROJECT]", "[LOCATION]", "[QUESTION]").toString())
   *           .setReadMask(FieldMask.newBuilder().build())
   *           .build();
   *   Question response = questionServiceClient.getQuestion(request);
   * }
   * }</pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final Question getQuestion(GetQuestionRequest request) {
    return getQuestionCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets a previously created question.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (QuestionServiceClient questionServiceClient = QuestionServiceClient.create()) {
   *   GetQuestionRequest request =
   *       GetQuestionRequest.newBuilder()
   *           .setName(QuestionName.of("[PROJECT]", "[LOCATION]", "[QUESTION]").toString())
   *           .setReadMask(FieldMask.newBuilder().build())
   *           .build();
   *   ApiFuture<Question> future = questionServiceClient.getQuestionCallable().futureCall(request);
   *   // Do something.
   *   Question response = future.get();
   * }
   * }</pre>
   */
  public final UnaryCallable<GetQuestionRequest, Question> getQuestionCallable() {
    return stub.getQuestionCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a question.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (QuestionServiceClient questionServiceClient = QuestionServiceClient.create()) {
   *   LocationName parent = LocationName.of("[PROJECT]", "[LOCATION]");
   *   Question question = Question.newBuilder().build();
   *   Question response = questionServiceClient.createQuestion(parent, question);
   * }
   * }</pre>
   *
   * @param parent Required. The name of the project this data source reference belongs to. Example:
   *     `projects/foo/locations/bar`
   * @param question Required. The question to create.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final Question createQuestion(LocationName parent, Question question) {
    CreateQuestionRequest request =
        CreateQuestionRequest.newBuilder()
            .setParent(parent == null ? null : parent.toString())
            .setQuestion(question)
            .build();
    return createQuestion(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a question.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (QuestionServiceClient questionServiceClient = QuestionServiceClient.create()) {
   *   String parent = LocationName.of("[PROJECT]", "[LOCATION]").toString();
   *   Question question = Question.newBuilder().build();
   *   Question response = questionServiceClient.createQuestion(parent, question);
   * }
   * }</pre>
   *
   * @param parent Required. The name of the project this data source reference belongs to. Example:
   *     `projects/foo/locations/bar`
   * @param question Required. The question to create.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final Question createQuestion(String parent, Question question) {
    CreateQuestionRequest request =
        CreateQuestionRequest.newBuilder().setParent(parent).setQuestion(question).build();
    return createQuestion(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a question.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (QuestionServiceClient questionServiceClient = QuestionServiceClient.create()) {
   *   CreateQuestionRequest request =
   *       CreateQuestionRequest.newBuilder()
   *           .setParent(LocationName.of("[PROJECT]", "[LOCATION]").toString())
   *           .setQuestion(Question.newBuilder().build())
   *           .build();
   *   Question response = questionServiceClient.createQuestion(request);
   * }
   * }</pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final Question createQuestion(CreateQuestionRequest request) {
    return createQuestionCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Creates a question.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (QuestionServiceClient questionServiceClient = QuestionServiceClient.create()) {
   *   CreateQuestionRequest request =
   *       CreateQuestionRequest.newBuilder()
   *           .setParent(LocationName.of("[PROJECT]", "[LOCATION]").toString())
   *           .setQuestion(Question.newBuilder().build())
   *           .build();
   *   ApiFuture<Question> future =
   *       questionServiceClient.createQuestionCallable().futureCall(request);
   *   // Do something.
   *   Question response = future.get();
   * }
   * }</pre>
   */
  public final UnaryCallable<CreateQuestionRequest, Question> createQuestionCallable() {
    return stub.createQuestionCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Executes an interpretation.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (QuestionServiceClient questionServiceClient = QuestionServiceClient.create()) {
   *   String name = "name3373707";
   *   int interpretationIndex = -1924823077;
   *   Question response = questionServiceClient.executeQuestion(name, interpretationIndex);
   * }
   * }</pre>
   *
   * @param name Required. The unique identifier for the question. Example:
   *     `projects/foo/locations/bar/questions/1234`
   * @param interpretationIndex Required. Index of the interpretation to execute.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final Question executeQuestion(String name, int interpretationIndex) {
    ExecuteQuestionRequest request =
        ExecuteQuestionRequest.newBuilder()
            .setName(name)
            .setInterpretationIndex(interpretationIndex)
            .build();
    return executeQuestion(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Executes an interpretation.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (QuestionServiceClient questionServiceClient = QuestionServiceClient.create()) {
   *   ExecuteQuestionRequest request =
   *       ExecuteQuestionRequest.newBuilder()
   *           .setName("name3373707")
   *           .setInterpretationIndex(-1924823077)
   *           .build();
   *   Question response = questionServiceClient.executeQuestion(request);
   * }
   * }</pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final Question executeQuestion(ExecuteQuestionRequest request) {
    return executeQuestionCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Executes an interpretation.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (QuestionServiceClient questionServiceClient = QuestionServiceClient.create()) {
   *   ExecuteQuestionRequest request =
   *       ExecuteQuestionRequest.newBuilder()
   *           .setName("name3373707")
   *           .setInterpretationIndex(-1924823077)
   *           .build();
   *   ApiFuture<Question> future =
   *       questionServiceClient.executeQuestionCallable().futureCall(request);
   *   // Do something.
   *   Question response = future.get();
   * }
   * }</pre>
   */
  public final UnaryCallable<ExecuteQuestionRequest, Question> executeQuestionCallable() {
    return stub.executeQuestionCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets previously created user feedback.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (QuestionServiceClient questionServiceClient = QuestionServiceClient.create()) {
   *   UserFeedbackName name = UserFeedbackName.of("[PROJECT]", "[LOCATION]", "[QUESTION]");
   *   UserFeedback response = questionServiceClient.getUserFeedback(name);
   * }
   * }</pre>
   *
   * @param name Required. The unique identifier for the user feedback. User feedback is a singleton
   *     resource on a Question. Example: `projects/foo/locations/bar/questions/1234/userFeedback`
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final UserFeedback getUserFeedback(UserFeedbackName name) {
    GetUserFeedbackRequest request =
        GetUserFeedbackRequest.newBuilder().setName(name == null ? null : name.toString()).build();
    return getUserFeedback(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets previously created user feedback.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (QuestionServiceClient questionServiceClient = QuestionServiceClient.create()) {
   *   String name = UserFeedbackName.of("[PROJECT]", "[LOCATION]", "[QUESTION]").toString();
   *   UserFeedback response = questionServiceClient.getUserFeedback(name);
   * }
   * }</pre>
   *
   * @param name Required. The unique identifier for the user feedback. User feedback is a singleton
   *     resource on a Question. Example: `projects/foo/locations/bar/questions/1234/userFeedback`
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final UserFeedback getUserFeedback(String name) {
    GetUserFeedbackRequest request = GetUserFeedbackRequest.newBuilder().setName(name).build();
    return getUserFeedback(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets previously created user feedback.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (QuestionServiceClient questionServiceClient = QuestionServiceClient.create()) {
   *   GetUserFeedbackRequest request =
   *       GetUserFeedbackRequest.newBuilder()
   *           .setName(UserFeedbackName.of("[PROJECT]", "[LOCATION]", "[QUESTION]").toString())
   *           .build();
   *   UserFeedback response = questionServiceClient.getUserFeedback(request);
   * }
   * }</pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final UserFeedback getUserFeedback(GetUserFeedbackRequest request) {
    return getUserFeedbackCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Gets previously created user feedback.
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (QuestionServiceClient questionServiceClient = QuestionServiceClient.create()) {
   *   GetUserFeedbackRequest request =
   *       GetUserFeedbackRequest.newBuilder()
   *           .setName(UserFeedbackName.of("[PROJECT]", "[LOCATION]", "[QUESTION]").toString())
   *           .build();
   *   ApiFuture<UserFeedback> future =
   *       questionServiceClient.getUserFeedbackCallable().futureCall(request);
   *   // Do something.
   *   UserFeedback response = future.get();
   * }
   * }</pre>
   */
  public final UnaryCallable<GetUserFeedbackRequest, UserFeedback> getUserFeedbackCallable() {
    return stub.getUserFeedbackCallable();
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Updates user feedback. This creates user feedback if there was none before (upsert).
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (QuestionServiceClient questionServiceClient = QuestionServiceClient.create()) {
   *   UserFeedback userFeedback = UserFeedback.newBuilder().build();
   *   FieldMask updateMask = FieldMask.newBuilder().build();
   *   UserFeedback response = questionServiceClient.updateUserFeedback(userFeedback, updateMask);
   * }
   * }</pre>
   *
   * @param userFeedback Required. The user feedback to update. This can be called even if there is
   *     no user feedback so far. The feedback's name field is used to identify the user feedback
   *     (and the corresponding question) to update.
   * @param updateMask The list of fields to be updated.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final UserFeedback updateUserFeedback(UserFeedback userFeedback, FieldMask updateMask) {
    UpdateUserFeedbackRequest request =
        UpdateUserFeedbackRequest.newBuilder()
            .setUserFeedback(userFeedback)
            .setUpdateMask(updateMask)
            .build();
    return updateUserFeedback(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Updates user feedback. This creates user feedback if there was none before (upsert).
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (QuestionServiceClient questionServiceClient = QuestionServiceClient.create()) {
   *   UpdateUserFeedbackRequest request =
   *       UpdateUserFeedbackRequest.newBuilder()
   *           .setUserFeedback(UserFeedback.newBuilder().build())
   *           .setUpdateMask(FieldMask.newBuilder().build())
   *           .build();
   *   UserFeedback response = questionServiceClient.updateUserFeedback(request);
   * }
   * }</pre>
   *
   * @param request The request object containing all of the parameters for the API call.
   * @throws com.google.api.gax.rpc.ApiException if the remote call fails
   */
  public final UserFeedback updateUserFeedback(UpdateUserFeedbackRequest request) {
    return updateUserFeedbackCallable().call(request);
  }

  // AUTO-GENERATED DOCUMENTATION AND METHOD.
  /**
   * Updates user feedback. This creates user feedback if there was none before (upsert).
   *
   * <p>Sample code:
   *
   * <pre>{@code
   * try (QuestionServiceClient questionServiceClient = QuestionServiceClient.create()) {
   *   UpdateUserFeedbackRequest request =
   *       UpdateUserFeedbackRequest.newBuilder()
   *           .setUserFeedback(UserFeedback.newBuilder().build())
   *           .setUpdateMask(FieldMask.newBuilder().build())
   *           .build();
   *   ApiFuture<UserFeedback> future =
   *       questionServiceClient.updateUserFeedbackCallable().futureCall(request);
   *   // Do something.
   *   UserFeedback response = future.get();
   * }
   * }</pre>
   */
  public final UnaryCallable<UpdateUserFeedbackRequest, UserFeedback> updateUserFeedbackCallable() {
    return stub.updateUserFeedbackCallable();
  }

  @Override
  public final void close() {
    stub.close();
  }

  @Override
  public void shutdown() {
    stub.shutdown();
  }

  @Override
  public boolean isShutdown() {
    return stub.isShutdown();
  }

  @Override
  public boolean isTerminated() {
    return stub.isTerminated();
  }

  @Override
  public void shutdownNow() {
    stub.shutdownNow();
  }

  @Override
  public boolean awaitTermination(long duration, TimeUnit unit) throws InterruptedException {
    return stub.awaitTermination(duration, unit);
  }
}
