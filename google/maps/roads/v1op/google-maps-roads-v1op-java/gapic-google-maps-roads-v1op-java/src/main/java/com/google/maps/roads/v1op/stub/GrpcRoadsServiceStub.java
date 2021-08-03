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

package com.google.maps.roads.v1op.stub;

import com.google.api.gax.core.BackgroundResource;
import com.google.api.gax.core.BackgroundResourceAggregation;
import com.google.api.gax.grpc.GrpcCallSettings;
import com.google.api.gax.grpc.GrpcStubCallableFactory;
import com.google.api.gax.rpc.ClientContext;
import com.google.api.gax.rpc.UnaryCallable;
import com.google.longrunning.stub.GrpcOperationsStub;
import com.google.maps.roads.v1op.ListNearestRoadsRequest;
import com.google.maps.roads.v1op.ListNearestRoadsResponse;
import com.google.maps.roads.v1op.SnapToRoadsRequest;
import com.google.maps.roads.v1op.SnapToRoadsResponse;
import io.grpc.MethodDescriptor;
import io.grpc.protobuf.ProtoUtils;
import java.io.IOException;
import java.util.concurrent.TimeUnit;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * gRPC stub implementation for the RoadsService service API.
 *
 * <p>This class is for advanced usage and reflects the underlying API directly.
 */
@Generated("by gapic-generator-java")
public class GrpcRoadsServiceStub extends RoadsServiceStub {
  private static final MethodDescriptor<SnapToRoadsRequest, SnapToRoadsResponse>
      snapToRoadsMethodDescriptor =
          MethodDescriptor.<SnapToRoadsRequest, SnapToRoadsResponse>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName("google.maps.roads.v1op.RoadsService/SnapToRoads")
              .setRequestMarshaller(ProtoUtils.marshaller(SnapToRoadsRequest.getDefaultInstance()))
              .setResponseMarshaller(
                  ProtoUtils.marshaller(SnapToRoadsResponse.getDefaultInstance()))
              .build();

  private static final MethodDescriptor<ListNearestRoadsRequest, ListNearestRoadsResponse>
      listNearestRoadsMethodDescriptor =
          MethodDescriptor.<ListNearestRoadsRequest, ListNearestRoadsResponse>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName("google.maps.roads.v1op.RoadsService/ListNearestRoads")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(ListNearestRoadsRequest.getDefaultInstance()))
              .setResponseMarshaller(
                  ProtoUtils.marshaller(ListNearestRoadsResponse.getDefaultInstance()))
              .build();

  private final UnaryCallable<SnapToRoadsRequest, SnapToRoadsResponse> snapToRoadsCallable;
  private final UnaryCallable<ListNearestRoadsRequest, ListNearestRoadsResponse>
      listNearestRoadsCallable;

  private final BackgroundResource backgroundResources;
  private final GrpcOperationsStub operationsStub;
  private final GrpcStubCallableFactory callableFactory;

  public static final GrpcRoadsServiceStub create(RoadsServiceStubSettings settings)
      throws IOException {
    return new GrpcRoadsServiceStub(settings, ClientContext.create(settings));
  }

  public static final GrpcRoadsServiceStub create(ClientContext clientContext) throws IOException {
    return new GrpcRoadsServiceStub(RoadsServiceStubSettings.newBuilder().build(), clientContext);
  }

  public static final GrpcRoadsServiceStub create(
      ClientContext clientContext, GrpcStubCallableFactory callableFactory) throws IOException {
    return new GrpcRoadsServiceStub(
        RoadsServiceStubSettings.newBuilder().build(), clientContext, callableFactory);
  }

  /**
   * Constructs an instance of GrpcRoadsServiceStub, using the given settings. This is protected so
   * that it is easy to make a subclass, but otherwise, the static factory methods should be
   * preferred.
   */
  protected GrpcRoadsServiceStub(RoadsServiceStubSettings settings, ClientContext clientContext)
      throws IOException {
    this(settings, clientContext, new GrpcRoadsServiceCallableFactory());
  }

  /**
   * Constructs an instance of GrpcRoadsServiceStub, using the given settings. This is protected so
   * that it is easy to make a subclass, but otherwise, the static factory methods should be
   * preferred.
   */
  protected GrpcRoadsServiceStub(
      RoadsServiceStubSettings settings,
      ClientContext clientContext,
      GrpcStubCallableFactory callableFactory)
      throws IOException {
    this.callableFactory = callableFactory;
    this.operationsStub = GrpcOperationsStub.create(clientContext, callableFactory);

    GrpcCallSettings<SnapToRoadsRequest, SnapToRoadsResponse> snapToRoadsTransportSettings =
        GrpcCallSettings.<SnapToRoadsRequest, SnapToRoadsResponse>newBuilder()
            .setMethodDescriptor(snapToRoadsMethodDescriptor)
            .build();
    GrpcCallSettings<ListNearestRoadsRequest, ListNearestRoadsResponse>
        listNearestRoadsTransportSettings =
            GrpcCallSettings.<ListNearestRoadsRequest, ListNearestRoadsResponse>newBuilder()
                .setMethodDescriptor(listNearestRoadsMethodDescriptor)
                .build();

    this.snapToRoadsCallable =
        callableFactory.createUnaryCallable(
            snapToRoadsTransportSettings, settings.snapToRoadsSettings(), clientContext);
    this.listNearestRoadsCallable =
        callableFactory.createUnaryCallable(
            listNearestRoadsTransportSettings, settings.listNearestRoadsSettings(), clientContext);

    this.backgroundResources =
        new BackgroundResourceAggregation(clientContext.getBackgroundResources());
  }

  public GrpcOperationsStub getOperationsStub() {
    return operationsStub;
  }

  @Override
  public UnaryCallable<SnapToRoadsRequest, SnapToRoadsResponse> snapToRoadsCallable() {
    return snapToRoadsCallable;
  }

  @Override
  public UnaryCallable<ListNearestRoadsRequest, ListNearestRoadsResponse>
      listNearestRoadsCallable() {
    return listNearestRoadsCallable;
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
