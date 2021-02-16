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

package com.google.cloud.dataqna.v1alpha.stub;

import com.google.api.core.BetaApi;
import com.google.api.gax.core.BackgroundResource;
import com.google.api.gax.core.BackgroundResourceAggregation;
import com.google.api.gax.grpc.GrpcCallSettings;
import com.google.api.gax.grpc.GrpcStubCallableFactory;
import com.google.api.gax.rpc.ClientContext;
import com.google.api.gax.rpc.RequestParamsExtractor;
import com.google.api.gax.rpc.UnaryCallable;
import com.google.cloud.dataqna.v1alpha.CreateQuestionRequest;
import com.google.cloud.dataqna.v1alpha.ExecuteQuestionRequest;
import com.google.cloud.dataqna.v1alpha.GetQuestionRequest;
import com.google.cloud.dataqna.v1alpha.GetUserFeedbackRequest;
import com.google.cloud.dataqna.v1alpha.Question;
import com.google.cloud.dataqna.v1alpha.UpdateUserFeedbackRequest;
import com.google.cloud.dataqna.v1alpha.UserFeedback;
import com.google.common.collect.ImmutableMap;
import com.google.longrunning.stub.GrpcOperationsStub;
import io.grpc.MethodDescriptor;
import io.grpc.protobuf.ProtoUtils;
import java.io.IOException;
import java.util.Map;
import java.util.concurrent.TimeUnit;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * gRPC stub implementation for the QuestionService service API.
 *
 * <p>This class is for advanced usage and reflects the underlying API directly.
 */
@BetaApi
@Generated("by gapic-generator-java")
public class GrpcQuestionServiceStub extends QuestionServiceStub {
  private static final MethodDescriptor<GetQuestionRequest, Question> getQuestionMethodDescriptor =
      MethodDescriptor.<GetQuestionRequest, Question>newBuilder()
          .setType(MethodDescriptor.MethodType.UNARY)
          .setFullMethodName("google.cloud.dataqna.v1alpha.QuestionService/GetQuestion")
          .setRequestMarshaller(ProtoUtils.marshaller(GetQuestionRequest.getDefaultInstance()))
          .setResponseMarshaller(ProtoUtils.marshaller(Question.getDefaultInstance()))
          .build();

  private static final MethodDescriptor<CreateQuestionRequest, Question>
      createQuestionMethodDescriptor =
          MethodDescriptor.<CreateQuestionRequest, Question>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName("google.cloud.dataqna.v1alpha.QuestionService/CreateQuestion")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(CreateQuestionRequest.getDefaultInstance()))
              .setResponseMarshaller(ProtoUtils.marshaller(Question.getDefaultInstance()))
              .build();

  private static final MethodDescriptor<ExecuteQuestionRequest, Question>
      executeQuestionMethodDescriptor =
          MethodDescriptor.<ExecuteQuestionRequest, Question>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName("google.cloud.dataqna.v1alpha.QuestionService/ExecuteQuestion")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(ExecuteQuestionRequest.getDefaultInstance()))
              .setResponseMarshaller(ProtoUtils.marshaller(Question.getDefaultInstance()))
              .build();

  private static final MethodDescriptor<GetUserFeedbackRequest, UserFeedback>
      getUserFeedbackMethodDescriptor =
          MethodDescriptor.<GetUserFeedbackRequest, UserFeedback>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName("google.cloud.dataqna.v1alpha.QuestionService/GetUserFeedback")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(GetUserFeedbackRequest.getDefaultInstance()))
              .setResponseMarshaller(ProtoUtils.marshaller(UserFeedback.getDefaultInstance()))
              .build();

  private static final MethodDescriptor<UpdateUserFeedbackRequest, UserFeedback>
      updateUserFeedbackMethodDescriptor =
          MethodDescriptor.<UpdateUserFeedbackRequest, UserFeedback>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName("google.cloud.dataqna.v1alpha.QuestionService/UpdateUserFeedback")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(UpdateUserFeedbackRequest.getDefaultInstance()))
              .setResponseMarshaller(ProtoUtils.marshaller(UserFeedback.getDefaultInstance()))
              .build();

  private final UnaryCallable<GetQuestionRequest, Question> getQuestionCallable;
  private final UnaryCallable<CreateQuestionRequest, Question> createQuestionCallable;
  private final UnaryCallable<ExecuteQuestionRequest, Question> executeQuestionCallable;
  private final UnaryCallable<GetUserFeedbackRequest, UserFeedback> getUserFeedbackCallable;
  private final UnaryCallable<UpdateUserFeedbackRequest, UserFeedback> updateUserFeedbackCallable;

  private final BackgroundResource backgroundResources;
  private final GrpcOperationsStub operationsStub;
  private final GrpcStubCallableFactory callableFactory;

  public static final GrpcQuestionServiceStub create(QuestionServiceStubSettings settings)
      throws IOException {
    return new GrpcQuestionServiceStub(settings, ClientContext.create(settings));
  }

  public static final GrpcQuestionServiceStub create(ClientContext clientContext)
      throws IOException {
    return new GrpcQuestionServiceStub(
        QuestionServiceStubSettings.newBuilder().build(), clientContext);
  }

  public static final GrpcQuestionServiceStub create(
      ClientContext clientContext, GrpcStubCallableFactory callableFactory) throws IOException {
    return new GrpcQuestionServiceStub(
        QuestionServiceStubSettings.newBuilder().build(), clientContext, callableFactory);
  }

  /**
   * Constructs an instance of GrpcQuestionServiceStub, using the given settings. This is protected
   * so that it is easy to make a subclass, but otherwise, the static factory methods should be
   * preferred.
   */
  protected GrpcQuestionServiceStub(
      QuestionServiceStubSettings settings, ClientContext clientContext) throws IOException {
    this(settings, clientContext, new GrpcQuestionServiceCallableFactory());
  }

  /**
   * Constructs an instance of GrpcQuestionServiceStub, using the given settings. This is protected
   * so that it is easy to make a subclass, but otherwise, the static factory methods should be
   * preferred.
   */
  protected GrpcQuestionServiceStub(
      QuestionServiceStubSettings settings,
      ClientContext clientContext,
      GrpcStubCallableFactory callableFactory)
      throws IOException {
    this.callableFactory = callableFactory;
    this.operationsStub = GrpcOperationsStub.create(clientContext, callableFactory);

    GrpcCallSettings<GetQuestionRequest, Question> getQuestionTransportSettings =
        GrpcCallSettings.<GetQuestionRequest, Question>newBuilder()
            .setMethodDescriptor(getQuestionMethodDescriptor)
            .setParamsExtractor(
                new RequestParamsExtractor<GetQuestionRequest>() {
                  @Override
                  public Map<String, String> extract(GetQuestionRequest request) {
                    ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                    params.put("name", String.valueOf(request.getName()));
                    return params.build();
                  }
                })
            .build();
    GrpcCallSettings<CreateQuestionRequest, Question> createQuestionTransportSettings =
        GrpcCallSettings.<CreateQuestionRequest, Question>newBuilder()
            .setMethodDescriptor(createQuestionMethodDescriptor)
            .setParamsExtractor(
                new RequestParamsExtractor<CreateQuestionRequest>() {
                  @Override
                  public Map<String, String> extract(CreateQuestionRequest request) {
                    ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                    params.put("parent", String.valueOf(request.getParent()));
                    return params.build();
                  }
                })
            .build();
    GrpcCallSettings<ExecuteQuestionRequest, Question> executeQuestionTransportSettings =
        GrpcCallSettings.<ExecuteQuestionRequest, Question>newBuilder()
            .setMethodDescriptor(executeQuestionMethodDescriptor)
            .setParamsExtractor(
                new RequestParamsExtractor<ExecuteQuestionRequest>() {
                  @Override
                  public Map<String, String> extract(ExecuteQuestionRequest request) {
                    ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                    params.put("name", String.valueOf(request.getName()));
                    return params.build();
                  }
                })
            .build();
    GrpcCallSettings<GetUserFeedbackRequest, UserFeedback> getUserFeedbackTransportSettings =
        GrpcCallSettings.<GetUserFeedbackRequest, UserFeedback>newBuilder()
            .setMethodDescriptor(getUserFeedbackMethodDescriptor)
            .setParamsExtractor(
                new RequestParamsExtractor<GetUserFeedbackRequest>() {
                  @Override
                  public Map<String, String> extract(GetUserFeedbackRequest request) {
                    ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                    params.put("name", String.valueOf(request.getName()));
                    return params.build();
                  }
                })
            .build();
    GrpcCallSettings<UpdateUserFeedbackRequest, UserFeedback> updateUserFeedbackTransportSettings =
        GrpcCallSettings.<UpdateUserFeedbackRequest, UserFeedback>newBuilder()
            .setMethodDescriptor(updateUserFeedbackMethodDescriptor)
            .setParamsExtractor(
                new RequestParamsExtractor<UpdateUserFeedbackRequest>() {
                  @Override
                  public Map<String, String> extract(UpdateUserFeedbackRequest request) {
                    ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                    params.put(
                        "user_feedback.name", String.valueOf(request.getUserFeedback().getName()));
                    return params.build();
                  }
                })
            .build();

    this.getQuestionCallable =
        callableFactory.createUnaryCallable(
            getQuestionTransportSettings, settings.getQuestionSettings(), clientContext);
    this.createQuestionCallable =
        callableFactory.createUnaryCallable(
            createQuestionTransportSettings, settings.createQuestionSettings(), clientContext);
    this.executeQuestionCallable =
        callableFactory.createUnaryCallable(
            executeQuestionTransportSettings, settings.executeQuestionSettings(), clientContext);
    this.getUserFeedbackCallable =
        callableFactory.createUnaryCallable(
            getUserFeedbackTransportSettings, settings.getUserFeedbackSettings(), clientContext);
    this.updateUserFeedbackCallable =
        callableFactory.createUnaryCallable(
            updateUserFeedbackTransportSettings,
            settings.updateUserFeedbackSettings(),
            clientContext);

    this.backgroundResources =
        new BackgroundResourceAggregation(clientContext.getBackgroundResources());
  }

  public GrpcOperationsStub getOperationsStub() {
    return operationsStub;
  }

  @Override
  public UnaryCallable<GetQuestionRequest, Question> getQuestionCallable() {
    return getQuestionCallable;
  }

  @Override
  public UnaryCallable<CreateQuestionRequest, Question> createQuestionCallable() {
    return createQuestionCallable;
  }

  @Override
  public UnaryCallable<ExecuteQuestionRequest, Question> executeQuestionCallable() {
    return executeQuestionCallable;
  }

  @Override
  public UnaryCallable<GetUserFeedbackRequest, UserFeedback> getUserFeedbackCallable() {
    return getUserFeedbackCallable;
  }

  @Override
  public UnaryCallable<UpdateUserFeedbackRequest, UserFeedback> updateUserFeedbackCallable() {
    return updateUserFeedbackCallable;
  }

  @Override
  public final void close() {
    shutdown();
  }

  @Override
  public void shutdown() {
    backgroundResources.shutdown();
  }

  @Override
  public boolean isShutdown() {
    return backgroundResources.isShutdown();
  }

  @Override
  public boolean isTerminated() {
    return backgroundResources.isTerminated();
  }

  @Override
  public void shutdownNow() {
    backgroundResources.shutdownNow();
  }

  @Override
  public boolean awaitTermination(long duration, TimeUnit unit) throws InterruptedException {
    return backgroundResources.awaitTermination(duration, unit);
  }
}
