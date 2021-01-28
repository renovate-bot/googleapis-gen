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

package com.google.chromeos.moblab.v1beta1.stub;

import static com.google.chromeos.moblab.v1beta1.BuildServiceClient.ListBuildsPagedResponse;

import com.google.api.core.BetaApi;
import com.google.api.gax.core.BackgroundResource;
import com.google.api.gax.core.BackgroundResourceAggregation;
import com.google.api.gax.grpc.GrpcCallSettings;
import com.google.api.gax.grpc.GrpcStubCallableFactory;
import com.google.api.gax.rpc.ClientContext;
import com.google.api.gax.rpc.OperationCallable;
import com.google.api.gax.rpc.RequestParamsExtractor;
import com.google.api.gax.rpc.UnaryCallable;
import com.google.chromeos.moblab.v1beta1.CheckBuildStageStatusRequest;
import com.google.chromeos.moblab.v1beta1.CheckBuildStageStatusResponse;
import com.google.chromeos.moblab.v1beta1.ListBuildsRequest;
import com.google.chromeos.moblab.v1beta1.ListBuildsResponse;
import com.google.chromeos.moblab.v1beta1.StageBuildMetadata;
import com.google.chromeos.moblab.v1beta1.StageBuildRequest;
import com.google.chromeos.moblab.v1beta1.StageBuildResponse;
import com.google.common.collect.ImmutableMap;
import com.google.longrunning.Operation;
import com.google.longrunning.stub.GrpcOperationsStub;
import io.grpc.MethodDescriptor;
import io.grpc.protobuf.ProtoUtils;
import java.io.IOException;
import java.util.Map;
import java.util.concurrent.TimeUnit;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * gRPC stub implementation for the BuildService service API.
 *
 * <p>This class is for advanced usage and reflects the underlying API directly.
 */
@BetaApi
@Generated("by gapic-generator-java")
public class GrpcBuildServiceStub extends BuildServiceStub {
  private static final MethodDescriptor<ListBuildsRequest, ListBuildsResponse>
      listBuildsMethodDescriptor =
          MethodDescriptor.<ListBuildsRequest, ListBuildsResponse>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName("google.chromeos.moblab.v1beta1.BuildService/ListBuilds")
              .setRequestMarshaller(ProtoUtils.marshaller(ListBuildsRequest.getDefaultInstance()))
              .setResponseMarshaller(ProtoUtils.marshaller(ListBuildsResponse.getDefaultInstance()))
              .build();

  private static final MethodDescriptor<CheckBuildStageStatusRequest, CheckBuildStageStatusResponse>
      checkBuildStageStatusMethodDescriptor =
          MethodDescriptor.<CheckBuildStageStatusRequest, CheckBuildStageStatusResponse>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(
                  "google.chromeos.moblab.v1beta1.BuildService/CheckBuildStageStatus")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(CheckBuildStageStatusRequest.getDefaultInstance()))
              .setResponseMarshaller(
                  ProtoUtils.marshaller(CheckBuildStageStatusResponse.getDefaultInstance()))
              .build();

  private static final MethodDescriptor<StageBuildRequest, Operation> stageBuildMethodDescriptor =
      MethodDescriptor.<StageBuildRequest, Operation>newBuilder()
          .setType(MethodDescriptor.MethodType.UNARY)
          .setFullMethodName("google.chromeos.moblab.v1beta1.BuildService/StageBuild")
          .setRequestMarshaller(ProtoUtils.marshaller(StageBuildRequest.getDefaultInstance()))
          .setResponseMarshaller(ProtoUtils.marshaller(Operation.getDefaultInstance()))
          .build();

  private final UnaryCallable<ListBuildsRequest, ListBuildsResponse> listBuildsCallable;
  private final UnaryCallable<ListBuildsRequest, ListBuildsPagedResponse> listBuildsPagedCallable;
  private final UnaryCallable<CheckBuildStageStatusRequest, CheckBuildStageStatusResponse>
      checkBuildStageStatusCallable;
  private final UnaryCallable<StageBuildRequest, Operation> stageBuildCallable;
  private final OperationCallable<StageBuildRequest, StageBuildResponse, StageBuildMetadata>
      stageBuildOperationCallable;

  private final BackgroundResource backgroundResources;
  private final GrpcOperationsStub operationsStub;
  private final GrpcStubCallableFactory callableFactory;

  public static final GrpcBuildServiceStub create(BuildServiceStubSettings settings)
      throws IOException {
    return new GrpcBuildServiceStub(settings, ClientContext.create(settings));
  }

  public static final GrpcBuildServiceStub create(ClientContext clientContext) throws IOException {
    return new GrpcBuildServiceStub(BuildServiceStubSettings.newBuilder().build(), clientContext);
  }

  public static final GrpcBuildServiceStub create(
      ClientContext clientContext, GrpcStubCallableFactory callableFactory) throws IOException {
    return new GrpcBuildServiceStub(
        BuildServiceStubSettings.newBuilder().build(), clientContext, callableFactory);
  }

  /**
   * Constructs an instance of GrpcBuildServiceStub, using the given settings. This is protected so
   * that it is easy to make a subclass, but otherwise, the static factory methods should be
   * preferred.
   */
  protected GrpcBuildServiceStub(BuildServiceStubSettings settings, ClientContext clientContext)
      throws IOException {
    this(settings, clientContext, new GrpcBuildServiceCallableFactory());
  }

  /**
   * Constructs an instance of GrpcBuildServiceStub, using the given settings. This is protected so
   * that it is easy to make a subclass, but otherwise, the static factory methods should be
   * preferred.
   */
  protected GrpcBuildServiceStub(
      BuildServiceStubSettings settings,
      ClientContext clientContext,
      GrpcStubCallableFactory callableFactory)
      throws IOException {
    this.callableFactory = callableFactory;
    this.operationsStub = GrpcOperationsStub.create(clientContext, callableFactory);

    GrpcCallSettings<ListBuildsRequest, ListBuildsResponse> listBuildsTransportSettings =
        GrpcCallSettings.<ListBuildsRequest, ListBuildsResponse>newBuilder()
            .setMethodDescriptor(listBuildsMethodDescriptor)
            .setParamsExtractor(
                new RequestParamsExtractor<ListBuildsRequest>() {
                  @Override
                  public Map<String, String> extract(ListBuildsRequest request) {
                    ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                    params.put("parent", String.valueOf(request.getParent()));
                    return params.build();
                  }
                })
            .build();
    GrpcCallSettings<CheckBuildStageStatusRequest, CheckBuildStageStatusResponse>
        checkBuildStageStatusTransportSettings =
            GrpcCallSettings
                .<CheckBuildStageStatusRequest, CheckBuildStageStatusResponse>newBuilder()
                .setMethodDescriptor(checkBuildStageStatusMethodDescriptor)
                .setParamsExtractor(
                    new RequestParamsExtractor<CheckBuildStageStatusRequest>() {
                      @Override
                      public Map<String, String> extract(CheckBuildStageStatusRequest request) {
                        ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                        params.put("name", String.valueOf(request.getName()));
                        return params.build();
                      }
                    })
                .build();
    GrpcCallSettings<StageBuildRequest, Operation> stageBuildTransportSettings =
        GrpcCallSettings.<StageBuildRequest, Operation>newBuilder()
            .setMethodDescriptor(stageBuildMethodDescriptor)
            .setParamsExtractor(
                new RequestParamsExtractor<StageBuildRequest>() {
                  @Override
                  public Map<String, String> extract(StageBuildRequest request) {
                    ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                    params.put("name", String.valueOf(request.getName()));
                    return params.build();
                  }
                })
            .build();

    this.listBuildsCallable =
        callableFactory.createUnaryCallable(
            listBuildsTransportSettings, settings.listBuildsSettings(), clientContext);
    this.listBuildsPagedCallable =
        callableFactory.createPagedCallable(
            listBuildsTransportSettings, settings.listBuildsSettings(), clientContext);
    this.checkBuildStageStatusCallable =
        callableFactory.createUnaryCallable(
            checkBuildStageStatusTransportSettings,
            settings.checkBuildStageStatusSettings(),
            clientContext);
    this.stageBuildCallable =
        callableFactory.createUnaryCallable(
            stageBuildTransportSettings, settings.stageBuildSettings(), clientContext);
    this.stageBuildOperationCallable =
        callableFactory.createOperationCallable(
            stageBuildTransportSettings,
            settings.stageBuildOperationSettings(),
            clientContext,
            operationsStub);

    this.backgroundResources =
        new BackgroundResourceAggregation(clientContext.getBackgroundResources());
  }

  public GrpcOperationsStub getOperationsStub() {
    return operationsStub;
  }

  public UnaryCallable<ListBuildsRequest, ListBuildsResponse> listBuildsCallable() {
    return listBuildsCallable;
  }

  public UnaryCallable<ListBuildsRequest, ListBuildsPagedResponse> listBuildsPagedCallable() {
    return listBuildsPagedCallable;
  }

  public UnaryCallable<CheckBuildStageStatusRequest, CheckBuildStageStatusResponse>
      checkBuildStageStatusCallable() {
    return checkBuildStageStatusCallable;
  }

  public UnaryCallable<StageBuildRequest, Operation> stageBuildCallable() {
    return stageBuildCallable;
  }

  public OperationCallable<StageBuildRequest, StageBuildResponse, StageBuildMetadata>
      stageBuildOperationCallable() {
    return stageBuildOperationCallable;
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
