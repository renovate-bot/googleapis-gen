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

package com.google.cloud.devtools.build.v1.stub;

import com.google.api.gax.core.BackgroundResource;
import com.google.api.gax.core.BackgroundResourceAggregation;
import com.google.api.gax.grpc.GrpcCallSettings;
import com.google.api.gax.grpc.GrpcStubCallableFactory;
import com.google.api.gax.rpc.BidiStreamingCallable;
import com.google.api.gax.rpc.ClientContext;
import com.google.api.gax.rpc.RequestParamsExtractor;
import com.google.api.gax.rpc.UnaryCallable;
import com.google.common.collect.ImmutableMap;
import com.google.devtools.build.v1.PublishBuildToolEventStreamRequest;
import com.google.devtools.build.v1.PublishBuildToolEventStreamResponse;
import com.google.devtools.build.v1.PublishLifecycleEventRequest;
import com.google.longrunning.stub.GrpcOperationsStub;
import com.google.protobuf.Empty;
import io.grpc.MethodDescriptor;
import io.grpc.protobuf.ProtoUtils;
import java.io.IOException;
import java.util.Map;
import java.util.concurrent.TimeUnit;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * gRPC stub implementation for the PublishBuildEvent service API.
 *
 * <p>This class is for advanced usage and reflects the underlying API directly.
 */
@Generated("by gapic-generator-java")
public class GrpcPublishBuildEventStub extends PublishBuildEventStub {
  private static final MethodDescriptor<PublishLifecycleEventRequest, Empty>
      publishLifecycleEventMethodDescriptor =
          MethodDescriptor.<PublishLifecycleEventRequest, Empty>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName("google.devtools.build.v1.PublishBuildEvent/PublishLifecycleEvent")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(PublishLifecycleEventRequest.getDefaultInstance()))
              .setResponseMarshaller(ProtoUtils.marshaller(Empty.getDefaultInstance()))
              .build();

  private static final MethodDescriptor<
          PublishBuildToolEventStreamRequest, PublishBuildToolEventStreamResponse>
      publishBuildToolEventStreamMethodDescriptor =
          MethodDescriptor
              .<PublishBuildToolEventStreamRequest, PublishBuildToolEventStreamResponse>newBuilder()
              .setType(MethodDescriptor.MethodType.BIDI_STREAMING)
              .setFullMethodName(
                  "google.devtools.build.v1.PublishBuildEvent/PublishBuildToolEventStream")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(PublishBuildToolEventStreamRequest.getDefaultInstance()))
              .setResponseMarshaller(
                  ProtoUtils.marshaller(PublishBuildToolEventStreamResponse.getDefaultInstance()))
              .build();

  private final UnaryCallable<PublishLifecycleEventRequest, Empty> publishLifecycleEventCallable;
  private final BidiStreamingCallable<
          PublishBuildToolEventStreamRequest, PublishBuildToolEventStreamResponse>
      publishBuildToolEventStreamCallable;

  private final BackgroundResource backgroundResources;
  private final GrpcOperationsStub operationsStub;
  private final GrpcStubCallableFactory callableFactory;

  public static final GrpcPublishBuildEventStub create(PublishBuildEventStubSettings settings)
      throws IOException {
    return new GrpcPublishBuildEventStub(settings, ClientContext.create(settings));
  }

  public static final GrpcPublishBuildEventStub create(ClientContext clientContext)
      throws IOException {
    return new GrpcPublishBuildEventStub(
        PublishBuildEventStubSettings.newBuilder().build(), clientContext);
  }

  public static final GrpcPublishBuildEventStub create(
      ClientContext clientContext, GrpcStubCallableFactory callableFactory) throws IOException {
    return new GrpcPublishBuildEventStub(
        PublishBuildEventStubSettings.newBuilder().build(), clientContext, callableFactory);
  }

  /**
   * Constructs an instance of GrpcPublishBuildEventStub, using the given settings. This is
   * protected so that it is easy to make a subclass, but otherwise, the static factory methods
   * should be preferred.
   */
  protected GrpcPublishBuildEventStub(
      PublishBuildEventStubSettings settings, ClientContext clientContext) throws IOException {
    this(settings, clientContext, new GrpcPublishBuildEventCallableFactory());
  }

  /**
   * Constructs an instance of GrpcPublishBuildEventStub, using the given settings. This is
   * protected so that it is easy to make a subclass, but otherwise, the static factory methods
   * should be preferred.
   */
  protected GrpcPublishBuildEventStub(
      PublishBuildEventStubSettings settings,
      ClientContext clientContext,
      GrpcStubCallableFactory callableFactory)
      throws IOException {
    this.callableFactory = callableFactory;
    this.operationsStub = GrpcOperationsStub.create(clientContext, callableFactory);

    GrpcCallSettings<PublishLifecycleEventRequest, Empty> publishLifecycleEventTransportSettings =
        GrpcCallSettings.<PublishLifecycleEventRequest, Empty>newBuilder()
            .setMethodDescriptor(publishLifecycleEventMethodDescriptor)
            .setParamsExtractor(
                new RequestParamsExtractor<PublishLifecycleEventRequest>() {
                  @Override
                  public Map<String, String> extract(PublishLifecycleEventRequest request) {
                    ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                    params.put("project_id", String.valueOf(request.getProjectId()));
                    return params.build();
                  }
                })
            .build();
    GrpcCallSettings<PublishBuildToolEventStreamRequest, PublishBuildToolEventStreamResponse>
        publishBuildToolEventStreamTransportSettings =
            GrpcCallSettings
                .<PublishBuildToolEventStreamRequest, PublishBuildToolEventStreamResponse>
                    newBuilder()
                .setMethodDescriptor(publishBuildToolEventStreamMethodDescriptor)
                .setParamsExtractor(
                    new RequestParamsExtractor<PublishBuildToolEventStreamRequest>() {
                      @Override
                      public Map<String, String> extract(
                          PublishBuildToolEventStreamRequest request) {
                        ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                        params.put("project_id", String.valueOf(request.getProjectId()));
                        return params.build();
                      }
                    })
                .build();

    this.publishLifecycleEventCallable =
        callableFactory.createUnaryCallable(
            publishLifecycleEventTransportSettings,
            settings.publishLifecycleEventSettings(),
            clientContext);
    this.publishBuildToolEventStreamCallable =
        callableFactory.createBidiStreamingCallable(
            publishBuildToolEventStreamTransportSettings,
            settings.publishBuildToolEventStreamSettings(),
            clientContext);

    this.backgroundResources =
        new BackgroundResourceAggregation(clientContext.getBackgroundResources());
  }

  public GrpcOperationsStub getOperationsStub() {
    return operationsStub;
  }

  @Override
  public UnaryCallable<PublishLifecycleEventRequest, Empty> publishLifecycleEventCallable() {
    return publishLifecycleEventCallable;
  }

  @Override
  public BidiStreamingCallable<
          PublishBuildToolEventStreamRequest, PublishBuildToolEventStreamResponse>
      publishBuildToolEventStreamCallable() {
    return publishBuildToolEventStreamCallable;
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
