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

package com.google.partner.aistreams.v1alpha1.stub;

import static com.google.partner.aistreams.v1alpha1.AIStreamsClient.ListClustersPagedResponse;
import static com.google.partner.aistreams.v1alpha1.AIStreamsClient.ListStreamsPagedResponse;

import com.google.api.core.BetaApi;
import com.google.api.gax.core.BackgroundResource;
import com.google.api.gax.core.BackgroundResourceAggregation;
import com.google.api.gax.grpc.GrpcCallSettings;
import com.google.api.gax.grpc.GrpcStubCallableFactory;
import com.google.api.gax.rpc.ClientContext;
import com.google.api.gax.rpc.OperationCallable;
import com.google.api.gax.rpc.UnaryCallable;
import com.google.common.collect.ImmutableMap;
import com.google.longrunning.Operation;
import com.google.longrunning.stub.GrpcOperationsStub;
import com.google.partner.aistreams.v1alpha1.Cluster;
import com.google.partner.aistreams.v1alpha1.CreateClusterRequest;
import com.google.partner.aistreams.v1alpha1.CreateStreamRequest;
import com.google.partner.aistreams.v1alpha1.DeleteClusterRequest;
import com.google.partner.aistreams.v1alpha1.DeleteStreamRequest;
import com.google.partner.aistreams.v1alpha1.GetClusterRequest;
import com.google.partner.aistreams.v1alpha1.GetStreamRequest;
import com.google.partner.aistreams.v1alpha1.ListClustersRequest;
import com.google.partner.aistreams.v1alpha1.ListClustersResponse;
import com.google.partner.aistreams.v1alpha1.ListStreamsRequest;
import com.google.partner.aistreams.v1alpha1.ListStreamsResponse;
import com.google.partner.aistreams.v1alpha1.OperationMetadata;
import com.google.partner.aistreams.v1alpha1.Stream;
import com.google.partner.aistreams.v1alpha1.UpdateClusterRequest;
import com.google.partner.aistreams.v1alpha1.UpdateStreamRequest;
import com.google.protobuf.Empty;
import io.grpc.MethodDescriptor;
import io.grpc.protobuf.ProtoUtils;
import java.io.IOException;
import java.util.Map;
import java.util.concurrent.TimeUnit;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * gRPC stub implementation for the AIStreams service API.
 *
 * <p>This class is for advanced usage and reflects the underlying API directly.
 */
@BetaApi
@Generated("by gapic-generator-java")
public class GrpcAIStreamsStub extends AIStreamsStub {
  private static final MethodDescriptor<ListClustersRequest, ListClustersResponse>
      listClustersMethodDescriptor =
          MethodDescriptor.<ListClustersRequest, ListClustersResponse>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName("google.partner.aistreams.v1alpha1.AIStreams/ListClusters")
              .setRequestMarshaller(ProtoUtils.marshaller(ListClustersRequest.getDefaultInstance()))
              .setResponseMarshaller(
                  ProtoUtils.marshaller(ListClustersResponse.getDefaultInstance()))
              .build();

  private static final MethodDescriptor<GetClusterRequest, Cluster> getClusterMethodDescriptor =
      MethodDescriptor.<GetClusterRequest, Cluster>newBuilder()
          .setType(MethodDescriptor.MethodType.UNARY)
          .setFullMethodName("google.partner.aistreams.v1alpha1.AIStreams/GetCluster")
          .setRequestMarshaller(ProtoUtils.marshaller(GetClusterRequest.getDefaultInstance()))
          .setResponseMarshaller(ProtoUtils.marshaller(Cluster.getDefaultInstance()))
          .build();

  private static final MethodDescriptor<CreateClusterRequest, Operation>
      createClusterMethodDescriptor =
          MethodDescriptor.<CreateClusterRequest, Operation>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName("google.partner.aistreams.v1alpha1.AIStreams/CreateCluster")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(CreateClusterRequest.getDefaultInstance()))
              .setResponseMarshaller(ProtoUtils.marshaller(Operation.getDefaultInstance()))
              .build();

  private static final MethodDescriptor<UpdateClusterRequest, Operation>
      updateClusterMethodDescriptor =
          MethodDescriptor.<UpdateClusterRequest, Operation>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName("google.partner.aistreams.v1alpha1.AIStreams/UpdateCluster")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(UpdateClusterRequest.getDefaultInstance()))
              .setResponseMarshaller(ProtoUtils.marshaller(Operation.getDefaultInstance()))
              .build();

  private static final MethodDescriptor<DeleteClusterRequest, Operation>
      deleteClusterMethodDescriptor =
          MethodDescriptor.<DeleteClusterRequest, Operation>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName("google.partner.aistreams.v1alpha1.AIStreams/DeleteCluster")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(DeleteClusterRequest.getDefaultInstance()))
              .setResponseMarshaller(ProtoUtils.marshaller(Operation.getDefaultInstance()))
              .build();

  private static final MethodDescriptor<ListStreamsRequest, ListStreamsResponse>
      listStreamsMethodDescriptor =
          MethodDescriptor.<ListStreamsRequest, ListStreamsResponse>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName("google.partner.aistreams.v1alpha1.AIStreams/ListStreams")
              .setRequestMarshaller(ProtoUtils.marshaller(ListStreamsRequest.getDefaultInstance()))
              .setResponseMarshaller(
                  ProtoUtils.marshaller(ListStreamsResponse.getDefaultInstance()))
              .build();

  private static final MethodDescriptor<GetStreamRequest, Stream> getStreamMethodDescriptor =
      MethodDescriptor.<GetStreamRequest, Stream>newBuilder()
          .setType(MethodDescriptor.MethodType.UNARY)
          .setFullMethodName("google.partner.aistreams.v1alpha1.AIStreams/GetStream")
          .setRequestMarshaller(ProtoUtils.marshaller(GetStreamRequest.getDefaultInstance()))
          .setResponseMarshaller(ProtoUtils.marshaller(Stream.getDefaultInstance()))
          .build();

  private static final MethodDescriptor<CreateStreamRequest, Operation>
      createStreamMethodDescriptor =
          MethodDescriptor.<CreateStreamRequest, Operation>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName("google.partner.aistreams.v1alpha1.AIStreams/CreateStream")
              .setRequestMarshaller(ProtoUtils.marshaller(CreateStreamRequest.getDefaultInstance()))
              .setResponseMarshaller(ProtoUtils.marshaller(Operation.getDefaultInstance()))
              .build();

  private static final MethodDescriptor<UpdateStreamRequest, Operation>
      updateStreamMethodDescriptor =
          MethodDescriptor.<UpdateStreamRequest, Operation>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName("google.partner.aistreams.v1alpha1.AIStreams/UpdateStream")
              .setRequestMarshaller(ProtoUtils.marshaller(UpdateStreamRequest.getDefaultInstance()))
              .setResponseMarshaller(ProtoUtils.marshaller(Operation.getDefaultInstance()))
              .build();

  private static final MethodDescriptor<DeleteStreamRequest, Operation>
      deleteStreamMethodDescriptor =
          MethodDescriptor.<DeleteStreamRequest, Operation>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName("google.partner.aistreams.v1alpha1.AIStreams/DeleteStream")
              .setRequestMarshaller(ProtoUtils.marshaller(DeleteStreamRequest.getDefaultInstance()))
              .setResponseMarshaller(ProtoUtils.marshaller(Operation.getDefaultInstance()))
              .build();

  private final UnaryCallable<ListClustersRequest, ListClustersResponse> listClustersCallable;
  private final UnaryCallable<ListClustersRequest, ListClustersPagedResponse>
      listClustersPagedCallable;
  private final UnaryCallable<GetClusterRequest, Cluster> getClusterCallable;
  private final UnaryCallable<CreateClusterRequest, Operation> createClusterCallable;
  private final OperationCallable<CreateClusterRequest, Cluster, OperationMetadata>
      createClusterOperationCallable;
  private final UnaryCallable<UpdateClusterRequest, Operation> updateClusterCallable;
  private final OperationCallable<UpdateClusterRequest, Cluster, OperationMetadata>
      updateClusterOperationCallable;
  private final UnaryCallable<DeleteClusterRequest, Operation> deleteClusterCallable;
  private final OperationCallable<DeleteClusterRequest, Empty, OperationMetadata>
      deleteClusterOperationCallable;
  private final UnaryCallable<ListStreamsRequest, ListStreamsResponse> listStreamsCallable;
  private final UnaryCallable<ListStreamsRequest, ListStreamsPagedResponse>
      listStreamsPagedCallable;
  private final UnaryCallable<GetStreamRequest, Stream> getStreamCallable;
  private final UnaryCallable<CreateStreamRequest, Operation> createStreamCallable;
  private final OperationCallable<CreateStreamRequest, Stream, OperationMetadata>
      createStreamOperationCallable;
  private final UnaryCallable<UpdateStreamRequest, Operation> updateStreamCallable;
  private final OperationCallable<UpdateStreamRequest, Stream, OperationMetadata>
      updateStreamOperationCallable;
  private final UnaryCallable<DeleteStreamRequest, Operation> deleteStreamCallable;
  private final OperationCallable<DeleteStreamRequest, Empty, OperationMetadata>
      deleteStreamOperationCallable;

  private final BackgroundResource backgroundResources;
  private final GrpcOperationsStub operationsStub;
  private final GrpcStubCallableFactory callableFactory;

  public static final GrpcAIStreamsStub create(AIStreamsStubSettings settings) throws IOException {
    return new GrpcAIStreamsStub(settings, ClientContext.create(settings));
  }

  public static final GrpcAIStreamsStub create(ClientContext clientContext) throws IOException {
    return new GrpcAIStreamsStub(AIStreamsStubSettings.newBuilder().build(), clientContext);
  }

  public static final GrpcAIStreamsStub create(
      ClientContext clientContext, GrpcStubCallableFactory callableFactory) throws IOException {
    return new GrpcAIStreamsStub(
        AIStreamsStubSettings.newBuilder().build(), clientContext, callableFactory);
  }

  /**
   * Constructs an instance of GrpcAIStreamsStub, using the given settings. This is protected so
   * that it is easy to make a subclass, but otherwise, the static factory methods should be
   * preferred.
   */
  protected GrpcAIStreamsStub(AIStreamsStubSettings settings, ClientContext clientContext)
      throws IOException {
    this(settings, clientContext, new GrpcAIStreamsCallableFactory());
  }

  /**
   * Constructs an instance of GrpcAIStreamsStub, using the given settings. This is protected so
   * that it is easy to make a subclass, but otherwise, the static factory methods should be
   * preferred.
   */
  protected GrpcAIStreamsStub(
      AIStreamsStubSettings settings,
      ClientContext clientContext,
      GrpcStubCallableFactory callableFactory)
      throws IOException {
    this.callableFactory = callableFactory;
    this.operationsStub = GrpcOperationsStub.create(clientContext, callableFactory);

    GrpcCallSettings<ListClustersRequest, ListClustersResponse> listClustersTransportSettings =
        GrpcCallSettings.<ListClustersRequest, ListClustersResponse>newBuilder()
            .setMethodDescriptor(listClustersMethodDescriptor)
            .setParamsExtractor(
                request -> {
                  ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                  params.put("parent", String.valueOf(request.getParent()));
                  return params.build();
                })
            .build();
    GrpcCallSettings<GetClusterRequest, Cluster> getClusterTransportSettings =
        GrpcCallSettings.<GetClusterRequest, Cluster>newBuilder()
            .setMethodDescriptor(getClusterMethodDescriptor)
            .setParamsExtractor(
                request -> {
                  ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                  params.put("name", String.valueOf(request.getName()));
                  return params.build();
                })
            .build();
    GrpcCallSettings<CreateClusterRequest, Operation> createClusterTransportSettings =
        GrpcCallSettings.<CreateClusterRequest, Operation>newBuilder()
            .setMethodDescriptor(createClusterMethodDescriptor)
            .setParamsExtractor(
                request -> {
                  ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                  params.put("parent", String.valueOf(request.getParent()));
                  return params.build();
                })
            .build();
    GrpcCallSettings<UpdateClusterRequest, Operation> updateClusterTransportSettings =
        GrpcCallSettings.<UpdateClusterRequest, Operation>newBuilder()
            .setMethodDescriptor(updateClusterMethodDescriptor)
            .setParamsExtractor(
                request -> {
                  ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                  params.put("cluster.name", String.valueOf(request.getCluster().getName()));
                  return params.build();
                })
            .build();
    GrpcCallSettings<DeleteClusterRequest, Operation> deleteClusterTransportSettings =
        GrpcCallSettings.<DeleteClusterRequest, Operation>newBuilder()
            .setMethodDescriptor(deleteClusterMethodDescriptor)
            .setParamsExtractor(
                request -> {
                  ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                  params.put("name", String.valueOf(request.getName()));
                  return params.build();
                })
            .build();
    GrpcCallSettings<ListStreamsRequest, ListStreamsResponse> listStreamsTransportSettings =
        GrpcCallSettings.<ListStreamsRequest, ListStreamsResponse>newBuilder()
            .setMethodDescriptor(listStreamsMethodDescriptor)
            .setParamsExtractor(
                request -> {
                  ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                  params.put("parent", String.valueOf(request.getParent()));
                  return params.build();
                })
            .build();
    GrpcCallSettings<GetStreamRequest, Stream> getStreamTransportSettings =
        GrpcCallSettings.<GetStreamRequest, Stream>newBuilder()
            .setMethodDescriptor(getStreamMethodDescriptor)
            .setParamsExtractor(
                request -> {
                  ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                  params.put("name", String.valueOf(request.getName()));
                  return params.build();
                })
            .build();
    GrpcCallSettings<CreateStreamRequest, Operation> createStreamTransportSettings =
        GrpcCallSettings.<CreateStreamRequest, Operation>newBuilder()
            .setMethodDescriptor(createStreamMethodDescriptor)
            .setParamsExtractor(
                request -> {
                  ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                  params.put("parent", String.valueOf(request.getParent()));
                  return params.build();
                })
            .build();
    GrpcCallSettings<UpdateStreamRequest, Operation> updateStreamTransportSettings =
        GrpcCallSettings.<UpdateStreamRequest, Operation>newBuilder()
            .setMethodDescriptor(updateStreamMethodDescriptor)
            .setParamsExtractor(
                request -> {
                  ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                  params.put("stream.name", String.valueOf(request.getStream().getName()));
                  return params.build();
                })
            .build();
    GrpcCallSettings<DeleteStreamRequest, Operation> deleteStreamTransportSettings =
        GrpcCallSettings.<DeleteStreamRequest, Operation>newBuilder()
            .setMethodDescriptor(deleteStreamMethodDescriptor)
            .setParamsExtractor(
                request -> {
                  ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                  params.put("name", String.valueOf(request.getName()));
                  return params.build();
                })
            .build();

    this.listClustersCallable =
        callableFactory.createUnaryCallable(
            listClustersTransportSettings, settings.listClustersSettings(), clientContext);
    this.listClustersPagedCallable =
        callableFactory.createPagedCallable(
            listClustersTransportSettings, settings.listClustersSettings(), clientContext);
    this.getClusterCallable =
        callableFactory.createUnaryCallable(
            getClusterTransportSettings, settings.getClusterSettings(), clientContext);
    this.createClusterCallable =
        callableFactory.createUnaryCallable(
            createClusterTransportSettings, settings.createClusterSettings(), clientContext);
    this.createClusterOperationCallable =
        callableFactory.createOperationCallable(
            createClusterTransportSettings,
            settings.createClusterOperationSettings(),
            clientContext,
            operationsStub);
    this.updateClusterCallable =
        callableFactory.createUnaryCallable(
            updateClusterTransportSettings, settings.updateClusterSettings(), clientContext);
    this.updateClusterOperationCallable =
        callableFactory.createOperationCallable(
            updateClusterTransportSettings,
            settings.updateClusterOperationSettings(),
            clientContext,
            operationsStub);
    this.deleteClusterCallable =
        callableFactory.createUnaryCallable(
            deleteClusterTransportSettings, settings.deleteClusterSettings(), clientContext);
    this.deleteClusterOperationCallable =
        callableFactory.createOperationCallable(
            deleteClusterTransportSettings,
            settings.deleteClusterOperationSettings(),
            clientContext,
            operationsStub);
    this.listStreamsCallable =
        callableFactory.createUnaryCallable(
            listStreamsTransportSettings, settings.listStreamsSettings(), clientContext);
    this.listStreamsPagedCallable =
        callableFactory.createPagedCallable(
            listStreamsTransportSettings, settings.listStreamsSettings(), clientContext);
    this.getStreamCallable =
        callableFactory.createUnaryCallable(
            getStreamTransportSettings, settings.getStreamSettings(), clientContext);
    this.createStreamCallable =
        callableFactory.createUnaryCallable(
            createStreamTransportSettings, settings.createStreamSettings(), clientContext);
    this.createStreamOperationCallable =
        callableFactory.createOperationCallable(
            createStreamTransportSettings,
            settings.createStreamOperationSettings(),
            clientContext,
            operationsStub);
    this.updateStreamCallable =
        callableFactory.createUnaryCallable(
            updateStreamTransportSettings, settings.updateStreamSettings(), clientContext);
    this.updateStreamOperationCallable =
        callableFactory.createOperationCallable(
            updateStreamTransportSettings,
            settings.updateStreamOperationSettings(),
            clientContext,
            operationsStub);
    this.deleteStreamCallable =
        callableFactory.createUnaryCallable(
            deleteStreamTransportSettings, settings.deleteStreamSettings(), clientContext);
    this.deleteStreamOperationCallable =
        callableFactory.createOperationCallable(
            deleteStreamTransportSettings,
            settings.deleteStreamOperationSettings(),
            clientContext,
            operationsStub);

    this.backgroundResources =
        new BackgroundResourceAggregation(clientContext.getBackgroundResources());
  }

  public GrpcOperationsStub getOperationsStub() {
    return operationsStub;
  }

  @Override
  public UnaryCallable<ListClustersRequest, ListClustersResponse> listClustersCallable() {
    return listClustersCallable;
  }

  @Override
  public UnaryCallable<ListClustersRequest, ListClustersPagedResponse> listClustersPagedCallable() {
    return listClustersPagedCallable;
  }

  @Override
  public UnaryCallable<GetClusterRequest, Cluster> getClusterCallable() {
    return getClusterCallable;
  }

  @Override
  public UnaryCallable<CreateClusterRequest, Operation> createClusterCallable() {
    return createClusterCallable;
  }

  @Override
  public OperationCallable<CreateClusterRequest, Cluster, OperationMetadata>
      createClusterOperationCallable() {
    return createClusterOperationCallable;
  }

  @Override
  public UnaryCallable<UpdateClusterRequest, Operation> updateClusterCallable() {
    return updateClusterCallable;
  }

  @Override
  public OperationCallable<UpdateClusterRequest, Cluster, OperationMetadata>
      updateClusterOperationCallable() {
    return updateClusterOperationCallable;
  }

  @Override
  public UnaryCallable<DeleteClusterRequest, Operation> deleteClusterCallable() {
    return deleteClusterCallable;
  }

  @Override
  public OperationCallable<DeleteClusterRequest, Empty, OperationMetadata>
      deleteClusterOperationCallable() {
    return deleteClusterOperationCallable;
  }

  @Override
  public UnaryCallable<ListStreamsRequest, ListStreamsResponse> listStreamsCallable() {
    return listStreamsCallable;
  }

  @Override
  public UnaryCallable<ListStreamsRequest, ListStreamsPagedResponse> listStreamsPagedCallable() {
    return listStreamsPagedCallable;
  }

  @Override
  public UnaryCallable<GetStreamRequest, Stream> getStreamCallable() {
    return getStreamCallable;
  }

  @Override
  public UnaryCallable<CreateStreamRequest, Operation> createStreamCallable() {
    return createStreamCallable;
  }

  @Override
  public OperationCallable<CreateStreamRequest, Stream, OperationMetadata>
      createStreamOperationCallable() {
    return createStreamOperationCallable;
  }

  @Override
  public UnaryCallable<UpdateStreamRequest, Operation> updateStreamCallable() {
    return updateStreamCallable;
  }

  @Override
  public OperationCallable<UpdateStreamRequest, Stream, OperationMetadata>
      updateStreamOperationCallable() {
    return updateStreamOperationCallable;
  }

  @Override
  public UnaryCallable<DeleteStreamRequest, Operation> deleteStreamCallable() {
    return deleteStreamCallable;
  }

  @Override
  public OperationCallable<DeleteStreamRequest, Empty, OperationMetadata>
      deleteStreamOperationCallable() {
    return deleteStreamOperationCallable;
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
