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

package com.google.cloud.devtools.remoteworkers.v1test2.stub;

import com.google.api.gax.core.BackgroundResource;
import com.google.api.gax.core.BackgroundResourceAggregation;
import com.google.api.gax.grpc.GrpcCallSettings;
import com.google.api.gax.grpc.GrpcStubCallableFactory;
import com.google.api.gax.rpc.ClientContext;
import com.google.api.gax.rpc.RequestParamsExtractor;
import com.google.api.gax.rpc.UnaryCallable;
import com.google.common.collect.ImmutableMap;
import com.google.devtools.remoteworkers.v1test2.BotSession;
import com.google.devtools.remoteworkers.v1test2.CreateBotSessionRequest;
import com.google.devtools.remoteworkers.v1test2.UpdateBotSessionRequest;
import com.google.longrunning.stub.GrpcOperationsStub;
import io.grpc.MethodDescriptor;
import io.grpc.protobuf.ProtoUtils;
import java.io.IOException;
import java.util.Map;
import java.util.concurrent.TimeUnit;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * gRPC stub implementation for the Bots service API.
 *
 * <p>This class is for advanced usage and reflects the underlying API directly.
 */
@Generated("by gapic-generator-java")
public class GrpcBotsStub extends BotsStub {
  private static final MethodDescriptor<CreateBotSessionRequest, BotSession>
      createBotSessionMethodDescriptor =
          MethodDescriptor.<CreateBotSessionRequest, BotSession>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName("google.devtools.remoteworkers.v1test2.Bots/CreateBotSession")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(CreateBotSessionRequest.getDefaultInstance()))
              .setResponseMarshaller(ProtoUtils.marshaller(BotSession.getDefaultInstance()))
              .build();

  private static final MethodDescriptor<UpdateBotSessionRequest, BotSession>
      updateBotSessionMethodDescriptor =
          MethodDescriptor.<UpdateBotSessionRequest, BotSession>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName("google.devtools.remoteworkers.v1test2.Bots/UpdateBotSession")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(UpdateBotSessionRequest.getDefaultInstance()))
              .setResponseMarshaller(ProtoUtils.marshaller(BotSession.getDefaultInstance()))
              .build();

  private final UnaryCallable<CreateBotSessionRequest, BotSession> createBotSessionCallable;
  private final UnaryCallable<UpdateBotSessionRequest, BotSession> updateBotSessionCallable;

  private final BackgroundResource backgroundResources;
  private final GrpcOperationsStub operationsStub;
  private final GrpcStubCallableFactory callableFactory;

  public static final GrpcBotsStub create(BotsStubSettings settings) throws IOException {
    return new GrpcBotsStub(settings, ClientContext.create(settings));
  }

  public static final GrpcBotsStub create(ClientContext clientContext) throws IOException {
    return new GrpcBotsStub(BotsStubSettings.newBuilder().build(), clientContext);
  }

  public static final GrpcBotsStub create(
      ClientContext clientContext, GrpcStubCallableFactory callableFactory) throws IOException {
    return new GrpcBotsStub(BotsStubSettings.newBuilder().build(), clientContext, callableFactory);
  }

  /**
   * Constructs an instance of GrpcBotsStub, using the given settings. This is protected so that it
   * is easy to make a subclass, but otherwise, the static factory methods should be preferred.
   */
  protected GrpcBotsStub(BotsStubSettings settings, ClientContext clientContext)
      throws IOException {
    this(settings, clientContext, new GrpcBotsCallableFactory());
  }

  /**
   * Constructs an instance of GrpcBotsStub, using the given settings. This is protected so that it
   * is easy to make a subclass, but otherwise, the static factory methods should be preferred.
   */
  protected GrpcBotsStub(
      BotsStubSettings settings,
      ClientContext clientContext,
      GrpcStubCallableFactory callableFactory)
      throws IOException {
    this.callableFactory = callableFactory;
    this.operationsStub = GrpcOperationsStub.create(clientContext, callableFactory);

    GrpcCallSettings<CreateBotSessionRequest, BotSession> createBotSessionTransportSettings =
        GrpcCallSettings.<CreateBotSessionRequest, BotSession>newBuilder()
            .setMethodDescriptor(createBotSessionMethodDescriptor)
            .setParamsExtractor(
                new RequestParamsExtractor<CreateBotSessionRequest>() {
                  @Override
                  public Map<String, String> extract(CreateBotSessionRequest request) {
                    ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                    params.put("parent", String.valueOf(request.getParent()));
                    return params.build();
                  }
                })
            .build();
    GrpcCallSettings<UpdateBotSessionRequest, BotSession> updateBotSessionTransportSettings =
        GrpcCallSettings.<UpdateBotSessionRequest, BotSession>newBuilder()
            .setMethodDescriptor(updateBotSessionMethodDescriptor)
            .setParamsExtractor(
                new RequestParamsExtractor<UpdateBotSessionRequest>() {
                  @Override
                  public Map<String, String> extract(UpdateBotSessionRequest request) {
                    ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                    params.put("name", String.valueOf(request.getName()));
                    return params.build();
                  }
                })
            .build();

    this.createBotSessionCallable =
        callableFactory.createUnaryCallable(
            createBotSessionTransportSettings, settings.createBotSessionSettings(), clientContext);
    this.updateBotSessionCallable =
        callableFactory.createUnaryCallable(
            updateBotSessionTransportSettings, settings.updateBotSessionSettings(), clientContext);

    this.backgroundResources =
        new BackgroundResourceAggregation(clientContext.getBackgroundResources());
  }

  public GrpcOperationsStub getOperationsStub() {
    return operationsStub;
  }

  @Override
  public UnaryCallable<CreateBotSessionRequest, BotSession> createBotSessionCallable() {
    return createBotSessionCallable;
  }

  @Override
  public UnaryCallable<UpdateBotSessionRequest, BotSession> updateBotSessionCallable() {
    return updateBotSessionCallable;
  }

  @Override
  public final void close() {
    try {
      backgroundResources.close();
    } catch (RuntimeException e) {
      throw e;
    } catch (Exception e) {
      throw new IllegalStateException("Failed to close resource", e);
    }
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
