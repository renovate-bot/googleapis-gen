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

package com.google.cloud.osconfig.agentendpoint.v1beta.stub;

import com.google.api.core.BetaApi;
import com.google.api.gax.core.BackgroundResource;
import com.google.api.gax.core.BackgroundResourceAggregation;
import com.google.api.gax.grpc.GrpcCallSettings;
import com.google.api.gax.grpc.GrpcStubCallableFactory;
import com.google.api.gax.rpc.ClientContext;
import com.google.api.gax.rpc.ServerStreamingCallable;
import com.google.api.gax.rpc.UnaryCallable;
import com.google.cloud.osconfig.agentendpoint.v1beta.GuestPolicies;
import com.google.cloud.osconfig.agentendpoint.v1beta.ReceiveTaskNotificationRequest;
import com.google.cloud.osconfig.agentendpoint.v1beta.ReceiveTaskNotificationResponse;
import com.google.cloud.osconfig.agentendpoint.v1beta.RegisterAgentRequest;
import com.google.cloud.osconfig.agentendpoint.v1beta.RegisterAgentResponse;
import com.google.cloud.osconfig.agentendpoint.v1beta.ReportTaskCompleteRequest;
import com.google.cloud.osconfig.agentendpoint.v1beta.ReportTaskCompleteResponse;
import com.google.cloud.osconfig.agentendpoint.v1beta.ReportTaskProgressRequest;
import com.google.cloud.osconfig.agentendpoint.v1beta.ReportTaskProgressResponse;
import com.google.cloud.osconfig.agentendpoint.v1beta.StartNextTaskRequest;
import com.google.cloud.osconfig.agentendpoint.v1beta.StartNextTaskResponse;
import com.google.longrunning.stub.GrpcOperationsStub;
import io.grpc.MethodDescriptor;
import io.grpc.protobuf.ProtoUtils;
import java.io.IOException;
import java.util.concurrent.TimeUnit;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * gRPC stub implementation for the AgentEndpointService service API.
 *
 * <p>This class is for advanced usage and reflects the underlying API directly.
 */
@BetaApi
@Generated("by gapic-generator-java")
public class GrpcAgentEndpointServiceStub extends AgentEndpointServiceStub {
  private static final MethodDescriptor<
          ReceiveTaskNotificationRequest, ReceiveTaskNotificationResponse>
      receiveTaskNotificationMethodDescriptor =
          MethodDescriptor
              .<ReceiveTaskNotificationRequest, ReceiveTaskNotificationResponse>newBuilder()
              .setType(MethodDescriptor.MethodType.SERVER_STREAMING)
              .setFullMethodName(
                  "google.cloud.osconfig.agentendpoint.v1beta.AgentEndpointService/ReceiveTaskNotification")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(ReceiveTaskNotificationRequest.getDefaultInstance()))
              .setResponseMarshaller(
                  ProtoUtils.marshaller(ReceiveTaskNotificationResponse.getDefaultInstance()))
              .build();

  private static final MethodDescriptor<StartNextTaskRequest, StartNextTaskResponse>
      startNextTaskMethodDescriptor =
          MethodDescriptor.<StartNextTaskRequest, StartNextTaskResponse>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(
                  "google.cloud.osconfig.agentendpoint.v1beta.AgentEndpointService/StartNextTask")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(StartNextTaskRequest.getDefaultInstance()))
              .setResponseMarshaller(
                  ProtoUtils.marshaller(StartNextTaskResponse.getDefaultInstance()))
              .build();

  private static final MethodDescriptor<ReportTaskProgressRequest, ReportTaskProgressResponse>
      reportTaskProgressMethodDescriptor =
          MethodDescriptor.<ReportTaskProgressRequest, ReportTaskProgressResponse>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(
                  "google.cloud.osconfig.agentendpoint.v1beta.AgentEndpointService/ReportTaskProgress")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(ReportTaskProgressRequest.getDefaultInstance()))
              .setResponseMarshaller(
                  ProtoUtils.marshaller(ReportTaskProgressResponse.getDefaultInstance()))
              .build();

  private static final MethodDescriptor<ReportTaskCompleteRequest, ReportTaskCompleteResponse>
      reportTaskCompleteMethodDescriptor =
          MethodDescriptor.<ReportTaskCompleteRequest, ReportTaskCompleteResponse>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(
                  "google.cloud.osconfig.agentendpoint.v1beta.AgentEndpointService/ReportTaskComplete")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(ReportTaskCompleteRequest.getDefaultInstance()))
              .setResponseMarshaller(
                  ProtoUtils.marshaller(ReportTaskCompleteResponse.getDefaultInstance()))
              .build();

  private static final MethodDescriptor<
          GuestPolicies.LookupEffectiveGuestPolicyRequest, GuestPolicies.EffectiveGuestPolicy>
      lookupEffectiveGuestPolicyMethodDescriptor =
          MethodDescriptor
              .<GuestPolicies.LookupEffectiveGuestPolicyRequest, GuestPolicies.EffectiveGuestPolicy>
                  newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(
                  "google.cloud.osconfig.agentendpoint.v1beta.AgentEndpointService/LookupEffectiveGuestPolicy")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(
                      GuestPolicies.LookupEffectiveGuestPolicyRequest.getDefaultInstance()))
              .setResponseMarshaller(
                  ProtoUtils.marshaller(GuestPolicies.EffectiveGuestPolicy.getDefaultInstance()))
              .build();

  private static final MethodDescriptor<RegisterAgentRequest, RegisterAgentResponse>
      registerAgentMethodDescriptor =
          MethodDescriptor.<RegisterAgentRequest, RegisterAgentResponse>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(
                  "google.cloud.osconfig.agentendpoint.v1beta.AgentEndpointService/RegisterAgent")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(RegisterAgentRequest.getDefaultInstance()))
              .setResponseMarshaller(
                  ProtoUtils.marshaller(RegisterAgentResponse.getDefaultInstance()))
              .build();

  private final ServerStreamingCallable<
          ReceiveTaskNotificationRequest, ReceiveTaskNotificationResponse>
      receiveTaskNotificationCallable;
  private final UnaryCallable<StartNextTaskRequest, StartNextTaskResponse> startNextTaskCallable;
  private final UnaryCallable<ReportTaskProgressRequest, ReportTaskProgressResponse>
      reportTaskProgressCallable;
  private final UnaryCallable<ReportTaskCompleteRequest, ReportTaskCompleteResponse>
      reportTaskCompleteCallable;
  private final UnaryCallable<
          GuestPolicies.LookupEffectiveGuestPolicyRequest, GuestPolicies.EffectiveGuestPolicy>
      lookupEffectiveGuestPolicyCallable;
  private final UnaryCallable<RegisterAgentRequest, RegisterAgentResponse> registerAgentCallable;

  private final BackgroundResource backgroundResources;
  private final GrpcOperationsStub operationsStub;
  private final GrpcStubCallableFactory callableFactory;

  public static final GrpcAgentEndpointServiceStub create(AgentEndpointServiceStubSettings settings)
      throws IOException {
    return new GrpcAgentEndpointServiceStub(settings, ClientContext.create(settings));
  }

  public static final GrpcAgentEndpointServiceStub create(ClientContext clientContext)
      throws IOException {
    return new GrpcAgentEndpointServiceStub(
        AgentEndpointServiceStubSettings.newBuilder().build(), clientContext);
  }

  public static final GrpcAgentEndpointServiceStub create(
      ClientContext clientContext, GrpcStubCallableFactory callableFactory) throws IOException {
    return new GrpcAgentEndpointServiceStub(
        AgentEndpointServiceStubSettings.newBuilder().build(), clientContext, callableFactory);
  }

  /**
   * Constructs an instance of GrpcAgentEndpointServiceStub, using the given settings. This is
   * protected so that it is easy to make a subclass, but otherwise, the static factory methods
   * should be preferred.
   */
  protected GrpcAgentEndpointServiceStub(
      AgentEndpointServiceStubSettings settings, ClientContext clientContext) throws IOException {
    this(settings, clientContext, new GrpcAgentEndpointServiceCallableFactory());
  }

  /**
   * Constructs an instance of GrpcAgentEndpointServiceStub, using the given settings. This is
   * protected so that it is easy to make a subclass, but otherwise, the static factory methods
   * should be preferred.
   */
  protected GrpcAgentEndpointServiceStub(
      AgentEndpointServiceStubSettings settings,
      ClientContext clientContext,
      GrpcStubCallableFactory callableFactory)
      throws IOException {
    this.callableFactory = callableFactory;
    this.operationsStub = GrpcOperationsStub.create(clientContext, callableFactory);

    GrpcCallSettings<ReceiveTaskNotificationRequest, ReceiveTaskNotificationResponse>
        receiveTaskNotificationTransportSettings =
            GrpcCallSettings
                .<ReceiveTaskNotificationRequest, ReceiveTaskNotificationResponse>newBuilder()
                .setMethodDescriptor(receiveTaskNotificationMethodDescriptor)
                .build();
    GrpcCallSettings<StartNextTaskRequest, StartNextTaskResponse> startNextTaskTransportSettings =
        GrpcCallSettings.<StartNextTaskRequest, StartNextTaskResponse>newBuilder()
            .setMethodDescriptor(startNextTaskMethodDescriptor)
            .build();
    GrpcCallSettings<ReportTaskProgressRequest, ReportTaskProgressResponse>
        reportTaskProgressTransportSettings =
            GrpcCallSettings.<ReportTaskProgressRequest, ReportTaskProgressResponse>newBuilder()
                .setMethodDescriptor(reportTaskProgressMethodDescriptor)
                .build();
    GrpcCallSettings<ReportTaskCompleteRequest, ReportTaskCompleteResponse>
        reportTaskCompleteTransportSettings =
            GrpcCallSettings.<ReportTaskCompleteRequest, ReportTaskCompleteResponse>newBuilder()
                .setMethodDescriptor(reportTaskCompleteMethodDescriptor)
                .build();
    GrpcCallSettings<
            GuestPolicies.LookupEffectiveGuestPolicyRequest, GuestPolicies.EffectiveGuestPolicy>
        lookupEffectiveGuestPolicyTransportSettings =
            GrpcCallSettings
                .<GuestPolicies.LookupEffectiveGuestPolicyRequest,
                    GuestPolicies.EffectiveGuestPolicy>
                    newBuilder()
                .setMethodDescriptor(lookupEffectiveGuestPolicyMethodDescriptor)
                .build();
    GrpcCallSettings<RegisterAgentRequest, RegisterAgentResponse> registerAgentTransportSettings =
        GrpcCallSettings.<RegisterAgentRequest, RegisterAgentResponse>newBuilder()
            .setMethodDescriptor(registerAgentMethodDescriptor)
            .build();

    this.receiveTaskNotificationCallable =
        callableFactory.createServerStreamingCallable(
            receiveTaskNotificationTransportSettings,
            settings.receiveTaskNotificationSettings(),
            clientContext);
    this.startNextTaskCallable =
        callableFactory.createUnaryCallable(
            startNextTaskTransportSettings, settings.startNextTaskSettings(), clientContext);
    this.reportTaskProgressCallable =
        callableFactory.createUnaryCallable(
            reportTaskProgressTransportSettings,
            settings.reportTaskProgressSettings(),
            clientContext);
    this.reportTaskCompleteCallable =
        callableFactory.createUnaryCallable(
            reportTaskCompleteTransportSettings,
            settings.reportTaskCompleteSettings(),
            clientContext);
    this.lookupEffectiveGuestPolicyCallable =
        callableFactory.createUnaryCallable(
            lookupEffectiveGuestPolicyTransportSettings,
            settings.lookupEffectiveGuestPolicySettings(),
            clientContext);
    this.registerAgentCallable =
        callableFactory.createUnaryCallable(
            registerAgentTransportSettings, settings.registerAgentSettings(), clientContext);

    this.backgroundResources =
        new BackgroundResourceAggregation(clientContext.getBackgroundResources());
  }

  public GrpcOperationsStub getOperationsStub() {
    return operationsStub;
  }

  @Override
  public ServerStreamingCallable<ReceiveTaskNotificationRequest, ReceiveTaskNotificationResponse>
      receiveTaskNotificationCallable() {
    return receiveTaskNotificationCallable;
  }

  @Override
  public UnaryCallable<StartNextTaskRequest, StartNextTaskResponse> startNextTaskCallable() {
    return startNextTaskCallable;
  }

  @Override
  public UnaryCallable<ReportTaskProgressRequest, ReportTaskProgressResponse>
      reportTaskProgressCallable() {
    return reportTaskProgressCallable;
  }

  @Override
  public UnaryCallable<ReportTaskCompleteRequest, ReportTaskCompleteResponse>
      reportTaskCompleteCallable() {
    return reportTaskCompleteCallable;
  }

  @Override
  public UnaryCallable<
          GuestPolicies.LookupEffectiveGuestPolicyRequest, GuestPolicies.EffectiveGuestPolicy>
      lookupEffectiveGuestPolicyCallable() {
    return lookupEffectiveGuestPolicyCallable;
  }

  @Override
  public UnaryCallable<RegisterAgentRequest, RegisterAgentResponse> registerAgentCallable() {
    return registerAgentCallable;
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
