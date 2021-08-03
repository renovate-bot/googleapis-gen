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

package com.google.home.graph.v1.stub;

import com.google.api.gax.core.BackgroundResource;
import com.google.api.gax.core.BackgroundResourceAggregation;
import com.google.api.gax.grpc.GrpcCallSettings;
import com.google.api.gax.grpc.GrpcStubCallableFactory;
import com.google.api.gax.rpc.ClientContext;
import com.google.api.gax.rpc.RequestParamsExtractor;
import com.google.api.gax.rpc.UnaryCallable;
import com.google.common.collect.ImmutableMap;
import com.google.home.graph.v1.HomeGraphApiServiceProto;
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
 * gRPC stub implementation for the HomeGraphApiService service API.
 *
 * <p>This class is for advanced usage and reflects the underlying API directly.
 */
@Generated("by gapic-generator-java")
public class GrpcHomeGraphApiServiceStub extends HomeGraphApiServiceStub {
  private static final MethodDescriptor<
          HomeGraphApiServiceProto.RequestSyncDevicesRequest,
          HomeGraphApiServiceProto.RequestSyncDevicesResponse>
      requestSyncDevicesMethodDescriptor =
          MethodDescriptor
              .<HomeGraphApiServiceProto.RequestSyncDevicesRequest,
                  HomeGraphApiServiceProto.RequestSyncDevicesResponse>
                  newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName("google.home.graph.v1.HomeGraphApiService/RequestSyncDevices")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(
                      HomeGraphApiServiceProto.RequestSyncDevicesRequest.getDefaultInstance()))
              .setResponseMarshaller(
                  ProtoUtils.marshaller(
                      HomeGraphApiServiceProto.RequestSyncDevicesResponse.getDefaultInstance()))
              .build();

  private static final MethodDescriptor<
          HomeGraphApiServiceProto.ReportStateAndNotificationRequest,
          HomeGraphApiServiceProto.ReportStateAndNotificationResponse>
      reportStateAndNotificationMethodDescriptor =
          MethodDescriptor
              .<HomeGraphApiServiceProto.ReportStateAndNotificationRequest,
                  HomeGraphApiServiceProto.ReportStateAndNotificationResponse>
                  newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(
                  "google.home.graph.v1.HomeGraphApiService/ReportStateAndNotification")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(
                      HomeGraphApiServiceProto.ReportStateAndNotificationRequest
                          .getDefaultInstance()))
              .setResponseMarshaller(
                  ProtoUtils.marshaller(
                      HomeGraphApiServiceProto.ReportStateAndNotificationResponse
                          .getDefaultInstance()))
              .build();

  private static final MethodDescriptor<HomeGraphApiServiceProto.DeleteAgentUserRequest, Empty>
      deleteAgentUserMethodDescriptor =
          MethodDescriptor.<HomeGraphApiServiceProto.DeleteAgentUserRequest, Empty>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName("google.home.graph.v1.HomeGraphApiService/DeleteAgentUser")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(
                      HomeGraphApiServiceProto.DeleteAgentUserRequest.getDefaultInstance()))
              .setResponseMarshaller(ProtoUtils.marshaller(Empty.getDefaultInstance()))
              .build();

  private static final MethodDescriptor<
          HomeGraphApiServiceProto.QueryRequest, HomeGraphApiServiceProto.QueryResponse>
      queryMethodDescriptor =
          MethodDescriptor
              .<HomeGraphApiServiceProto.QueryRequest, HomeGraphApiServiceProto.QueryResponse>
                  newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName("google.home.graph.v1.HomeGraphApiService/Query")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(HomeGraphApiServiceProto.QueryRequest.getDefaultInstance()))
              .setResponseMarshaller(
                  ProtoUtils.marshaller(
                      HomeGraphApiServiceProto.QueryResponse.getDefaultInstance()))
              .build();

  private static final MethodDescriptor<
          HomeGraphApiServiceProto.SyncRequest, HomeGraphApiServiceProto.SyncResponse>
      syncMethodDescriptor =
          MethodDescriptor
              .<HomeGraphApiServiceProto.SyncRequest, HomeGraphApiServiceProto.SyncResponse>
                  newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName("google.home.graph.v1.HomeGraphApiService/Sync")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(HomeGraphApiServiceProto.SyncRequest.getDefaultInstance()))
              .setResponseMarshaller(
                  ProtoUtils.marshaller(HomeGraphApiServiceProto.SyncResponse.getDefaultInstance()))
              .build();

  private final UnaryCallable<
          HomeGraphApiServiceProto.RequestSyncDevicesRequest,
          HomeGraphApiServiceProto.RequestSyncDevicesResponse>
      requestSyncDevicesCallable;
  private final UnaryCallable<
          HomeGraphApiServiceProto.ReportStateAndNotificationRequest,
          HomeGraphApiServiceProto.ReportStateAndNotificationResponse>
      reportStateAndNotificationCallable;
  private final UnaryCallable<HomeGraphApiServiceProto.DeleteAgentUserRequest, Empty>
      deleteAgentUserCallable;
  private final UnaryCallable<
          HomeGraphApiServiceProto.QueryRequest, HomeGraphApiServiceProto.QueryResponse>
      queryCallable;
  private final UnaryCallable<
          HomeGraphApiServiceProto.SyncRequest, HomeGraphApiServiceProto.SyncResponse>
      syncCallable;

  private final BackgroundResource backgroundResources;
  private final GrpcOperationsStub operationsStub;
  private final GrpcStubCallableFactory callableFactory;

  public static final GrpcHomeGraphApiServiceStub create(HomeGraphApiServiceStubSettings settings)
      throws IOException {
    return new GrpcHomeGraphApiServiceStub(settings, ClientContext.create(settings));
  }

  public static final GrpcHomeGraphApiServiceStub create(ClientContext clientContext)
      throws IOException {
    return new GrpcHomeGraphApiServiceStub(
        HomeGraphApiServiceStubSettings.newBuilder().build(), clientContext);
  }

  public static final GrpcHomeGraphApiServiceStub create(
      ClientContext clientContext, GrpcStubCallableFactory callableFactory) throws IOException {
    return new GrpcHomeGraphApiServiceStub(
        HomeGraphApiServiceStubSettings.newBuilder().build(), clientContext, callableFactory);
  }

  /**
   * Constructs an instance of GrpcHomeGraphApiServiceStub, using the given settings. This is
   * protected so that it is easy to make a subclass, but otherwise, the static factory methods
   * should be preferred.
   */
  protected GrpcHomeGraphApiServiceStub(
      HomeGraphApiServiceStubSettings settings, ClientContext clientContext) throws IOException {
    this(settings, clientContext, new GrpcHomeGraphApiServiceCallableFactory());
  }

  /**
   * Constructs an instance of GrpcHomeGraphApiServiceStub, using the given settings. This is
   * protected so that it is easy to make a subclass, but otherwise, the static factory methods
   * should be preferred.
   */
  protected GrpcHomeGraphApiServiceStub(
      HomeGraphApiServiceStubSettings settings,
      ClientContext clientContext,
      GrpcStubCallableFactory callableFactory)
      throws IOException {
    this.callableFactory = callableFactory;
    this.operationsStub = GrpcOperationsStub.create(clientContext, callableFactory);

    GrpcCallSettings<
            HomeGraphApiServiceProto.RequestSyncDevicesRequest,
            HomeGraphApiServiceProto.RequestSyncDevicesResponse>
        requestSyncDevicesTransportSettings =
            GrpcCallSettings
                .<HomeGraphApiServiceProto.RequestSyncDevicesRequest,
                    HomeGraphApiServiceProto.RequestSyncDevicesResponse>
                    newBuilder()
                .setMethodDescriptor(requestSyncDevicesMethodDescriptor)
                .build();
    GrpcCallSettings<
            HomeGraphApiServiceProto.ReportStateAndNotificationRequest,
            HomeGraphApiServiceProto.ReportStateAndNotificationResponse>
        reportStateAndNotificationTransportSettings =
            GrpcCallSettings
                .<HomeGraphApiServiceProto.ReportStateAndNotificationRequest,
                    HomeGraphApiServiceProto.ReportStateAndNotificationResponse>
                    newBuilder()
                .setMethodDescriptor(reportStateAndNotificationMethodDescriptor)
                .build();
    GrpcCallSettings<HomeGraphApiServiceProto.DeleteAgentUserRequest, Empty>
        deleteAgentUserTransportSettings =
            GrpcCallSettings.<HomeGraphApiServiceProto.DeleteAgentUserRequest, Empty>newBuilder()
                .setMethodDescriptor(deleteAgentUserMethodDescriptor)
                .setParamsExtractor(
                    new RequestParamsExtractor<HomeGraphApiServiceProto.DeleteAgentUserRequest>() {
                      @Override
                      public Map<String, String> extract(
                          HomeGraphApiServiceProto.DeleteAgentUserRequest request) {
                        ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                        params.put("agent_user_id", String.valueOf(request.getAgentUserId()));
                        return params.build();
                      }
                    })
                .build();
    GrpcCallSettings<HomeGraphApiServiceProto.QueryRequest, HomeGraphApiServiceProto.QueryResponse>
        queryTransportSettings =
            GrpcCallSettings
                .<HomeGraphApiServiceProto.QueryRequest, HomeGraphApiServiceProto.QueryResponse>
                    newBuilder()
                .setMethodDescriptor(queryMethodDescriptor)
                .build();
    GrpcCallSettings<HomeGraphApiServiceProto.SyncRequest, HomeGraphApiServiceProto.SyncResponse>
        syncTransportSettings =
            GrpcCallSettings
                .<HomeGraphApiServiceProto.SyncRequest, HomeGraphApiServiceProto.SyncResponse>
                    newBuilder()
                .setMethodDescriptor(syncMethodDescriptor)
                .build();

    this.requestSyncDevicesCallable =
        callableFactory.createUnaryCallable(
            requestSyncDevicesTransportSettings,
            settings.requestSyncDevicesSettings(),
            clientContext);
    this.reportStateAndNotificationCallable =
        callableFactory.createUnaryCallable(
            reportStateAndNotificationTransportSettings,
            settings.reportStateAndNotificationSettings(),
            clientContext);
    this.deleteAgentUserCallable =
        callableFactory.createUnaryCallable(
            deleteAgentUserTransportSettings, settings.deleteAgentUserSettings(), clientContext);
    this.queryCallable =
        callableFactory.createUnaryCallable(
            queryTransportSettings, settings.querySettings(), clientContext);
    this.syncCallable =
        callableFactory.createUnaryCallable(
            syncTransportSettings, settings.syncSettings(), clientContext);

    this.backgroundResources =
        new BackgroundResourceAggregation(clientContext.getBackgroundResources());
  }

  public GrpcOperationsStub getOperationsStub() {
    return operationsStub;
  }

  @Override
  public UnaryCallable<
          HomeGraphApiServiceProto.RequestSyncDevicesRequest,
          HomeGraphApiServiceProto.RequestSyncDevicesResponse>
      requestSyncDevicesCallable() {
    return requestSyncDevicesCallable;
  }

  @Override
  public UnaryCallable<
          HomeGraphApiServiceProto.ReportStateAndNotificationRequest,
          HomeGraphApiServiceProto.ReportStateAndNotificationResponse>
      reportStateAndNotificationCallable() {
    return reportStateAndNotificationCallable;
  }

  @Override
  public UnaryCallable<HomeGraphApiServiceProto.DeleteAgentUserRequest, Empty>
      deleteAgentUserCallable() {
    return deleteAgentUserCallable;
  }

  @Override
  public UnaryCallable<
          HomeGraphApiServiceProto.QueryRequest, HomeGraphApiServiceProto.QueryResponse>
      queryCallable() {
    return queryCallable;
  }

  @Override
  public UnaryCallable<HomeGraphApiServiceProto.SyncRequest, HomeGraphApiServiceProto.SyncResponse>
      syncCallable() {
    return syncCallable;
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
