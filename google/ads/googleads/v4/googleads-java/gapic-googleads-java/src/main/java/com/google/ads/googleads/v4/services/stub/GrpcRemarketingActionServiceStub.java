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

package com.google.ads.googleads.v4.services.stub;

import com.google.ads.googleads.v4.resources.RemarketingAction;
import com.google.ads.googleads.v4.services.GetRemarketingActionRequest;
import com.google.ads.googleads.v4.services.MutateRemarketingActionsRequest;
import com.google.ads.googleads.v4.services.MutateRemarketingActionsResponse;
import com.google.api.gax.core.BackgroundResource;
import com.google.api.gax.core.BackgroundResourceAggregation;
import com.google.api.gax.grpc.GrpcCallSettings;
import com.google.api.gax.grpc.GrpcStubCallableFactory;
import com.google.api.gax.rpc.ClientContext;
import com.google.api.gax.rpc.RequestParamsExtractor;
import com.google.api.gax.rpc.UnaryCallable;
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
 * gRPC stub implementation for the RemarketingActionService service API.
 *
 * <p>This class is for advanced usage and reflects the underlying API directly.
 */
@Generated("by gapic-generator-java")
public class GrpcRemarketingActionServiceStub extends RemarketingActionServiceStub {
  private static final MethodDescriptor<GetRemarketingActionRequest, RemarketingAction>
      getRemarketingActionMethodDescriptor =
          MethodDescriptor.<GetRemarketingActionRequest, RemarketingAction>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(
                  "google.ads.googleads.v4.services.RemarketingActionService/GetRemarketingAction")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(GetRemarketingActionRequest.getDefaultInstance()))
              .setResponseMarshaller(ProtoUtils.marshaller(RemarketingAction.getDefaultInstance()))
              .build();

  private static final MethodDescriptor<
          MutateRemarketingActionsRequest, MutateRemarketingActionsResponse>
      mutateRemarketingActionsMethodDescriptor =
          MethodDescriptor
              .<MutateRemarketingActionsRequest, MutateRemarketingActionsResponse>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(
                  "google.ads.googleads.v4.services.RemarketingActionService/MutateRemarketingActions")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(MutateRemarketingActionsRequest.getDefaultInstance()))
              .setResponseMarshaller(
                  ProtoUtils.marshaller(MutateRemarketingActionsResponse.getDefaultInstance()))
              .build();

  private final UnaryCallable<GetRemarketingActionRequest, RemarketingAction>
      getRemarketingActionCallable;
  private final UnaryCallable<MutateRemarketingActionsRequest, MutateRemarketingActionsResponse>
      mutateRemarketingActionsCallable;

  private final BackgroundResource backgroundResources;
  private final GrpcOperationsStub operationsStub;
  private final GrpcStubCallableFactory callableFactory;

  public static final GrpcRemarketingActionServiceStub create(
      RemarketingActionServiceStubSettings settings) throws IOException {
    return new GrpcRemarketingActionServiceStub(settings, ClientContext.create(settings));
  }

  public static final GrpcRemarketingActionServiceStub create(ClientContext clientContext)
      throws IOException {
    return new GrpcRemarketingActionServiceStub(
        RemarketingActionServiceStubSettings.newBuilder().build(), clientContext);
  }

  public static final GrpcRemarketingActionServiceStub create(
      ClientContext clientContext, GrpcStubCallableFactory callableFactory) throws IOException {
    return new GrpcRemarketingActionServiceStub(
        RemarketingActionServiceStubSettings.newBuilder().build(), clientContext, callableFactory);
  }

  /**
   * Constructs an instance of GrpcRemarketingActionServiceStub, using the given settings. This is
   * protected so that it is easy to make a subclass, but otherwise, the static factory methods
   * should be preferred.
   */
  protected GrpcRemarketingActionServiceStub(
      RemarketingActionServiceStubSettings settings, ClientContext clientContext)
      throws IOException {
    this(settings, clientContext, new GrpcRemarketingActionServiceCallableFactory());
  }

  /**
   * Constructs an instance of GrpcRemarketingActionServiceStub, using the given settings. This is
   * protected so that it is easy to make a subclass, but otherwise, the static factory methods
   * should be preferred.
   */
  protected GrpcRemarketingActionServiceStub(
      RemarketingActionServiceStubSettings settings,
      ClientContext clientContext,
      GrpcStubCallableFactory callableFactory)
      throws IOException {
    this.callableFactory = callableFactory;
    this.operationsStub = GrpcOperationsStub.create(clientContext, callableFactory);

    GrpcCallSettings<GetRemarketingActionRequest, RemarketingAction>
        getRemarketingActionTransportSettings =
            GrpcCallSettings.<GetRemarketingActionRequest, RemarketingAction>newBuilder()
                .setMethodDescriptor(getRemarketingActionMethodDescriptor)
                .setParamsExtractor(
                    new RequestParamsExtractor<GetRemarketingActionRequest>() {
                      @Override
                      public Map<String, String> extract(GetRemarketingActionRequest request) {
                        ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                        params.put("resource_name", String.valueOf(request.getResourceName()));
                        return params.build();
                      }
                    })
                .build();
    GrpcCallSettings<MutateRemarketingActionsRequest, MutateRemarketingActionsResponse>
        mutateRemarketingActionsTransportSettings =
            GrpcCallSettings
                .<MutateRemarketingActionsRequest, MutateRemarketingActionsResponse>newBuilder()
                .setMethodDescriptor(mutateRemarketingActionsMethodDescriptor)
                .setParamsExtractor(
                    new RequestParamsExtractor<MutateRemarketingActionsRequest>() {
                      @Override
                      public Map<String, String> extract(MutateRemarketingActionsRequest request) {
                        ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                        params.put("customer_id", String.valueOf(request.getCustomerId()));
                        return params.build();
                      }
                    })
                .build();

    this.getRemarketingActionCallable =
        callableFactory.createUnaryCallable(
            getRemarketingActionTransportSettings,
            settings.getRemarketingActionSettings(),
            clientContext);
    this.mutateRemarketingActionsCallable =
        callableFactory.createUnaryCallable(
            mutateRemarketingActionsTransportSettings,
            settings.mutateRemarketingActionsSettings(),
            clientContext);

    this.backgroundResources =
        new BackgroundResourceAggregation(clientContext.getBackgroundResources());
  }

  public GrpcOperationsStub getOperationsStub() {
    return operationsStub;
  }

  @Override
  public UnaryCallable<GetRemarketingActionRequest, RemarketingAction>
      getRemarketingActionCallable() {
    return getRemarketingActionCallable;
  }

  @Override
  public UnaryCallable<MutateRemarketingActionsRequest, MutateRemarketingActionsResponse>
      mutateRemarketingActionsCallable() {
    return mutateRemarketingActionsCallable;
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
