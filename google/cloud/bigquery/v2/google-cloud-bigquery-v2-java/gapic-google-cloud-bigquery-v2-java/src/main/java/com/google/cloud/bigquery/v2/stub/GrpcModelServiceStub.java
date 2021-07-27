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

package com.google.cloud.bigquery.v2.stub;

import com.google.api.gax.core.BackgroundResource;
import com.google.api.gax.core.BackgroundResourceAggregation;
import com.google.api.gax.grpc.GrpcCallSettings;
import com.google.api.gax.grpc.GrpcStubCallableFactory;
import com.google.api.gax.rpc.ClientContext;
import com.google.api.gax.rpc.RequestParamsExtractor;
import com.google.api.gax.rpc.UnaryCallable;
import com.google.cloud.bigquery.v2.ModelProto;
import com.google.common.collect.ImmutableMap;
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
 * gRPC stub implementation for the ModelService service API.
 *
 * <p>This class is for advanced usage and reflects the underlying API directly.
 */
@Generated("by gapic-generator-java")
public class GrpcModelServiceStub extends ModelServiceStub {
  private static final MethodDescriptor<ModelProto.GetModelRequest, ModelProto.Model>
      getModelMethodDescriptor =
          MethodDescriptor.<ModelProto.GetModelRequest, ModelProto.Model>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName("google.cloud.bigquery.v2.ModelService/GetModel")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(ModelProto.GetModelRequest.getDefaultInstance()))
              .setResponseMarshaller(ProtoUtils.marshaller(ModelProto.Model.getDefaultInstance()))
              .build();

  private static final MethodDescriptor<ModelProto.ListModelsRequest, ModelProto.ListModelsResponse>
      listModelsMethodDescriptor =
          MethodDescriptor.<ModelProto.ListModelsRequest, ModelProto.ListModelsResponse>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName("google.cloud.bigquery.v2.ModelService/ListModels")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(ModelProto.ListModelsRequest.getDefaultInstance()))
              .setResponseMarshaller(
                  ProtoUtils.marshaller(ModelProto.ListModelsResponse.getDefaultInstance()))
              .build();

  private static final MethodDescriptor<ModelProto.PatchModelRequest, ModelProto.Model>
      patchModelMethodDescriptor =
          MethodDescriptor.<ModelProto.PatchModelRequest, ModelProto.Model>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName("google.cloud.bigquery.v2.ModelService/PatchModel")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(ModelProto.PatchModelRequest.getDefaultInstance()))
              .setResponseMarshaller(ProtoUtils.marshaller(ModelProto.Model.getDefaultInstance()))
              .build();

  private static final MethodDescriptor<ModelProto.DeleteModelRequest, Empty>
      deleteModelMethodDescriptor =
          MethodDescriptor.<ModelProto.DeleteModelRequest, Empty>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName("google.cloud.bigquery.v2.ModelService/DeleteModel")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(ModelProto.DeleteModelRequest.getDefaultInstance()))
              .setResponseMarshaller(ProtoUtils.marshaller(Empty.getDefaultInstance()))
              .build();

  private final UnaryCallable<ModelProto.GetModelRequest, ModelProto.Model> getModelCallable;
  private final UnaryCallable<ModelProto.ListModelsRequest, ModelProto.ListModelsResponse>
      listModelsCallable;
  private final UnaryCallable<ModelProto.PatchModelRequest, ModelProto.Model> patchModelCallable;
  private final UnaryCallable<ModelProto.DeleteModelRequest, Empty> deleteModelCallable;

  private final BackgroundResource backgroundResources;
  private final GrpcOperationsStub operationsStub;
  private final GrpcStubCallableFactory callableFactory;

  public static final GrpcModelServiceStub create(ModelServiceStubSettings settings)
      throws IOException {
    return new GrpcModelServiceStub(settings, ClientContext.create(settings));
  }

  public static final GrpcModelServiceStub create(ClientContext clientContext) throws IOException {
    return new GrpcModelServiceStub(ModelServiceStubSettings.newBuilder().build(), clientContext);
  }

  public static final GrpcModelServiceStub create(
      ClientContext clientContext, GrpcStubCallableFactory callableFactory) throws IOException {
    return new GrpcModelServiceStub(
        ModelServiceStubSettings.newBuilder().build(), clientContext, callableFactory);
  }

  /**
   * Constructs an instance of GrpcModelServiceStub, using the given settings. This is protected so
   * that it is easy to make a subclass, but otherwise, the static factory methods should be
   * preferred.
   */
  protected GrpcModelServiceStub(ModelServiceStubSettings settings, ClientContext clientContext)
      throws IOException {
    this(settings, clientContext, new GrpcModelServiceCallableFactory());
  }

  /**
   * Constructs an instance of GrpcModelServiceStub, using the given settings. This is protected so
   * that it is easy to make a subclass, but otherwise, the static factory methods should be
   * preferred.
   */
  protected GrpcModelServiceStub(
      ModelServiceStubSettings settings,
      ClientContext clientContext,
      GrpcStubCallableFactory callableFactory)
      throws IOException {
    this.callableFactory = callableFactory;
    this.operationsStub = GrpcOperationsStub.create(clientContext, callableFactory);

    GrpcCallSettings<ModelProto.GetModelRequest, ModelProto.Model> getModelTransportSettings =
        GrpcCallSettings.<ModelProto.GetModelRequest, ModelProto.Model>newBuilder()
            .setMethodDescriptor(getModelMethodDescriptor)
            .setParamsExtractor(
                new RequestParamsExtractor<ModelProto.GetModelRequest>() {
                  @Override
                  public Map<String, String> extract(ModelProto.GetModelRequest request) {
                    ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                    params.put("dataset_id", String.valueOf(request.getDatasetId()));
                    params.put("model_id", String.valueOf(request.getModelId()));
                    params.put("project_id", String.valueOf(request.getProjectId()));
                    return params.build();
                  }
                })
            .build();
    GrpcCallSettings<ModelProto.ListModelsRequest, ModelProto.ListModelsResponse>
        listModelsTransportSettings =
            GrpcCallSettings
                .<ModelProto.ListModelsRequest, ModelProto.ListModelsResponse>newBuilder()
                .setMethodDescriptor(listModelsMethodDescriptor)
                .setParamsExtractor(
                    new RequestParamsExtractor<ModelProto.ListModelsRequest>() {
                      @Override
                      public Map<String, String> extract(ModelProto.ListModelsRequest request) {
                        ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                        params.put("dataset_id", String.valueOf(request.getDatasetId()));
                        params.put("project_id", String.valueOf(request.getProjectId()));
                        return params.build();
                      }
                    })
                .build();
    GrpcCallSettings<ModelProto.PatchModelRequest, ModelProto.Model> patchModelTransportSettings =
        GrpcCallSettings.<ModelProto.PatchModelRequest, ModelProto.Model>newBuilder()
            .setMethodDescriptor(patchModelMethodDescriptor)
            .setParamsExtractor(
                new RequestParamsExtractor<ModelProto.PatchModelRequest>() {
                  @Override
                  public Map<String, String> extract(ModelProto.PatchModelRequest request) {
                    ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                    params.put("dataset_id", String.valueOf(request.getDatasetId()));
                    params.put("model_id", String.valueOf(request.getModelId()));
                    params.put("project_id", String.valueOf(request.getProjectId()));
                    return params.build();
                  }
                })
            .build();
    GrpcCallSettings<ModelProto.DeleteModelRequest, Empty> deleteModelTransportSettings =
        GrpcCallSettings.<ModelProto.DeleteModelRequest, Empty>newBuilder()
            .setMethodDescriptor(deleteModelMethodDescriptor)
            .setParamsExtractor(
                new RequestParamsExtractor<ModelProto.DeleteModelRequest>() {
                  @Override
                  public Map<String, String> extract(ModelProto.DeleteModelRequest request) {
                    ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                    params.put("dataset_id", String.valueOf(request.getDatasetId()));
                    params.put("model_id", String.valueOf(request.getModelId()));
                    params.put("project_id", String.valueOf(request.getProjectId()));
                    return params.build();
                  }
                })
            .build();

    this.getModelCallable =
        callableFactory.createUnaryCallable(
            getModelTransportSettings, settings.getModelSettings(), clientContext);
    this.listModelsCallable =
        callableFactory.createUnaryCallable(
            listModelsTransportSettings, settings.listModelsSettings(), clientContext);
    this.patchModelCallable =
        callableFactory.createUnaryCallable(
            patchModelTransportSettings, settings.patchModelSettings(), clientContext);
    this.deleteModelCallable =
        callableFactory.createUnaryCallable(
            deleteModelTransportSettings, settings.deleteModelSettings(), clientContext);

    this.backgroundResources =
        new BackgroundResourceAggregation(clientContext.getBackgroundResources());
  }

  public GrpcOperationsStub getOperationsStub() {
    return operationsStub;
  }

  @Override
  public UnaryCallable<ModelProto.GetModelRequest, ModelProto.Model> getModelCallable() {
    return getModelCallable;
  }

  @Override
  public UnaryCallable<ModelProto.ListModelsRequest, ModelProto.ListModelsResponse>
      listModelsCallable() {
    return listModelsCallable;
  }

  @Override
  public UnaryCallable<ModelProto.PatchModelRequest, ModelProto.Model> patchModelCallable() {
    return patchModelCallable;
  }

  @Override
  public UnaryCallable<ModelProto.DeleteModelRequest, Empty> deleteModelCallable() {
    return deleteModelCallable;
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
