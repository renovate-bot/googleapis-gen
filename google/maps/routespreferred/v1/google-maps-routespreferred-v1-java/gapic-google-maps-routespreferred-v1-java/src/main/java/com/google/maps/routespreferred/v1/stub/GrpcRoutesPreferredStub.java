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

package com.google.maps.routespreferred.v1.stub;

import com.google.api.gax.core.BackgroundResource;
import com.google.api.gax.core.BackgroundResourceAggregation;
import com.google.api.gax.grpc.GrpcCallSettings;
import com.google.api.gax.grpc.GrpcStubCallableFactory;
import com.google.api.gax.rpc.ClientContext;
import com.google.api.gax.rpc.ServerStreamingCallable;
import com.google.api.gax.rpc.UnaryCallable;
import com.google.longrunning.stub.GrpcOperationsStub;
import com.google.maps.routes.v1.ComputeCustomRoutesRequest;
import com.google.maps.routes.v1.ComputeCustomRoutesResponse;
import com.google.maps.routes.v1.ComputeRouteMatrixRequest;
import com.google.maps.routes.v1.ComputeRoutesRequest;
import com.google.maps.routes.v1.ComputeRoutesResponse;
import com.google.maps.routes.v1.RouteMatrixElement;
import io.grpc.MethodDescriptor;
import io.grpc.protobuf.ProtoUtils;
import java.io.IOException;
import java.util.concurrent.TimeUnit;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * gRPC stub implementation for the RoutesPreferred service API.
 *
 * <p>This class is for advanced usage and reflects the underlying API directly.
 */
@Generated("by gapic-generator-java")
public class GrpcRoutesPreferredStub extends RoutesPreferredStub {
  private static final MethodDescriptor<ComputeRoutesRequest, ComputeRoutesResponse>
      computeRoutesMethodDescriptor =
          MethodDescriptor.<ComputeRoutesRequest, ComputeRoutesResponse>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName("google.maps.routes.v1.RoutesPreferred/ComputeRoutes")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(ComputeRoutesRequest.getDefaultInstance()))
              .setResponseMarshaller(
                  ProtoUtils.marshaller(ComputeRoutesResponse.getDefaultInstance()))
              .build();

  private static final MethodDescriptor<ComputeRouteMatrixRequest, RouteMatrixElement>
      computeRouteMatrixMethodDescriptor =
          MethodDescriptor.<ComputeRouteMatrixRequest, RouteMatrixElement>newBuilder()
              .setType(MethodDescriptor.MethodType.SERVER_STREAMING)
              .setFullMethodName("google.maps.routes.v1.RoutesPreferred/ComputeRouteMatrix")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(ComputeRouteMatrixRequest.getDefaultInstance()))
              .setResponseMarshaller(ProtoUtils.marshaller(RouteMatrixElement.getDefaultInstance()))
              .build();

  private static final MethodDescriptor<ComputeCustomRoutesRequest, ComputeCustomRoutesResponse>
      computeCustomRoutesMethodDescriptor =
          MethodDescriptor.<ComputeCustomRoutesRequest, ComputeCustomRoutesResponse>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName("google.maps.routes.v1.RoutesPreferred/ComputeCustomRoutes")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(ComputeCustomRoutesRequest.getDefaultInstance()))
              .setResponseMarshaller(
                  ProtoUtils.marshaller(ComputeCustomRoutesResponse.getDefaultInstance()))
              .build();

  private final UnaryCallable<ComputeRoutesRequest, ComputeRoutesResponse> computeRoutesCallable;
  private final ServerStreamingCallable<ComputeRouteMatrixRequest, RouteMatrixElement>
      computeRouteMatrixCallable;
  private final UnaryCallable<ComputeCustomRoutesRequest, ComputeCustomRoutesResponse>
      computeCustomRoutesCallable;

  private final BackgroundResource backgroundResources;
  private final GrpcOperationsStub operationsStub;
  private final GrpcStubCallableFactory callableFactory;

  public static final GrpcRoutesPreferredStub create(RoutesPreferredStubSettings settings)
      throws IOException {
    return new GrpcRoutesPreferredStub(settings, ClientContext.create(settings));
  }

  public static final GrpcRoutesPreferredStub create(ClientContext clientContext)
      throws IOException {
    return new GrpcRoutesPreferredStub(
        RoutesPreferredStubSettings.newBuilder().build(), clientContext);
  }

  public static final GrpcRoutesPreferredStub create(
      ClientContext clientContext, GrpcStubCallableFactory callableFactory) throws IOException {
    return new GrpcRoutesPreferredStub(
        RoutesPreferredStubSettings.newBuilder().build(), clientContext, callableFactory);
  }

  /**
   * Constructs an instance of GrpcRoutesPreferredStub, using the given settings. This is protected
   * so that it is easy to make a subclass, but otherwise, the static factory methods should be
   * preferred.
   */
  protected GrpcRoutesPreferredStub(
      RoutesPreferredStubSettings settings, ClientContext clientContext) throws IOException {
    this(settings, clientContext, new GrpcRoutesPreferredCallableFactory());
  }

  /**
   * Constructs an instance of GrpcRoutesPreferredStub, using the given settings. This is protected
   * so that it is easy to make a subclass, but otherwise, the static factory methods should be
   * preferred.
   */
  protected GrpcRoutesPreferredStub(
      RoutesPreferredStubSettings settings,
      ClientContext clientContext,
      GrpcStubCallableFactory callableFactory)
      throws IOException {
    this.callableFactory = callableFactory;
    this.operationsStub = GrpcOperationsStub.create(clientContext, callableFactory);

    GrpcCallSettings<ComputeRoutesRequest, ComputeRoutesResponse> computeRoutesTransportSettings =
        GrpcCallSettings.<ComputeRoutesRequest, ComputeRoutesResponse>newBuilder()
            .setMethodDescriptor(computeRoutesMethodDescriptor)
            .build();
    GrpcCallSettings<ComputeRouteMatrixRequest, RouteMatrixElement>
        computeRouteMatrixTransportSettings =
            GrpcCallSettings.<ComputeRouteMatrixRequest, RouteMatrixElement>newBuilder()
                .setMethodDescriptor(computeRouteMatrixMethodDescriptor)
                .build();
    GrpcCallSettings<ComputeCustomRoutesRequest, ComputeCustomRoutesResponse>
        computeCustomRoutesTransportSettings =
            GrpcCallSettings.<ComputeCustomRoutesRequest, ComputeCustomRoutesResponse>newBuilder()
                .setMethodDescriptor(computeCustomRoutesMethodDescriptor)
                .build();

    this.computeRoutesCallable =
        callableFactory.createUnaryCallable(
            computeRoutesTransportSettings, settings.computeRoutesSettings(), clientContext);
    this.computeRouteMatrixCallable =
        callableFactory.createServerStreamingCallable(
            computeRouteMatrixTransportSettings,
            settings.computeRouteMatrixSettings(),
            clientContext);
    this.computeCustomRoutesCallable =
        callableFactory.createUnaryCallable(
            computeCustomRoutesTransportSettings,
            settings.computeCustomRoutesSettings(),
            clientContext);

    this.backgroundResources =
        new BackgroundResourceAggregation(clientContext.getBackgroundResources());
  }

  public GrpcOperationsStub getOperationsStub() {
    return operationsStub;
  }

  @Override
  public UnaryCallable<ComputeRoutesRequest, ComputeRoutesResponse> computeRoutesCallable() {
    return computeRoutesCallable;
  }

  @Override
  public ServerStreamingCallable<ComputeRouteMatrixRequest, RouteMatrixElement>
      computeRouteMatrixCallable() {
    return computeRouteMatrixCallable;
  }

  @Override
  public UnaryCallable<ComputeCustomRoutesRequest, ComputeCustomRoutesResponse>
      computeCustomRoutesCallable() {
    return computeCustomRoutesCallable;
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
