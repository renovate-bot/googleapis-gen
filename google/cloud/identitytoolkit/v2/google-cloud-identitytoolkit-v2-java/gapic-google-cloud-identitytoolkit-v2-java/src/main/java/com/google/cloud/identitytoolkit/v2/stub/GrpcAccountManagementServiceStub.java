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

package com.google.cloud.identitytoolkit.v2.stub;

import com.google.api.gax.core.BackgroundResource;
import com.google.api.gax.core.BackgroundResourceAggregation;
import com.google.api.gax.grpc.GrpcCallSettings;
import com.google.api.gax.grpc.GrpcStubCallableFactory;
import com.google.api.gax.rpc.ClientContext;
import com.google.api.gax.rpc.UnaryCallable;
import com.google.cloud.identitytoolkit.v2.FinalizeMfaEnrollmentRequest;
import com.google.cloud.identitytoolkit.v2.FinalizeMfaEnrollmentResponse;
import com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentRequest;
import com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentResponse;
import com.google.cloud.identitytoolkit.v2.WithdrawMfaRequest;
import com.google.cloud.identitytoolkit.v2.WithdrawMfaResponse;
import com.google.longrunning.stub.GrpcOperationsStub;
import io.grpc.MethodDescriptor;
import io.grpc.protobuf.ProtoUtils;
import java.io.IOException;
import java.util.concurrent.TimeUnit;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * gRPC stub implementation for the AccountManagementService service API.
 *
 * <p>This class is for advanced usage and reflects the underlying API directly.
 */
@Generated("by gapic-generator-java")
public class GrpcAccountManagementServiceStub extends AccountManagementServiceStub {
  private static final MethodDescriptor<FinalizeMfaEnrollmentRequest, FinalizeMfaEnrollmentResponse>
      finalizeMfaEnrollmentMethodDescriptor =
          MethodDescriptor.<FinalizeMfaEnrollmentRequest, FinalizeMfaEnrollmentResponse>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(
                  "google.cloud.identitytoolkit.v2.AccountManagementService/FinalizeMfaEnrollment")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(FinalizeMfaEnrollmentRequest.getDefaultInstance()))
              .setResponseMarshaller(
                  ProtoUtils.marshaller(FinalizeMfaEnrollmentResponse.getDefaultInstance()))
              .build();

  private static final MethodDescriptor<StartMfaEnrollmentRequest, StartMfaEnrollmentResponse>
      startMfaEnrollmentMethodDescriptor =
          MethodDescriptor.<StartMfaEnrollmentRequest, StartMfaEnrollmentResponse>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(
                  "google.cloud.identitytoolkit.v2.AccountManagementService/StartMfaEnrollment")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(StartMfaEnrollmentRequest.getDefaultInstance()))
              .setResponseMarshaller(
                  ProtoUtils.marshaller(StartMfaEnrollmentResponse.getDefaultInstance()))
              .build();

  private static final MethodDescriptor<WithdrawMfaRequest, WithdrawMfaResponse>
      withdrawMfaMethodDescriptor =
          MethodDescriptor.<WithdrawMfaRequest, WithdrawMfaResponse>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(
                  "google.cloud.identitytoolkit.v2.AccountManagementService/WithdrawMfa")
              .setRequestMarshaller(ProtoUtils.marshaller(WithdrawMfaRequest.getDefaultInstance()))
              .setResponseMarshaller(
                  ProtoUtils.marshaller(WithdrawMfaResponse.getDefaultInstance()))
              .build();

  private final UnaryCallable<FinalizeMfaEnrollmentRequest, FinalizeMfaEnrollmentResponse>
      finalizeMfaEnrollmentCallable;
  private final UnaryCallable<StartMfaEnrollmentRequest, StartMfaEnrollmentResponse>
      startMfaEnrollmentCallable;
  private final UnaryCallable<WithdrawMfaRequest, WithdrawMfaResponse> withdrawMfaCallable;

  private final BackgroundResource backgroundResources;
  private final GrpcOperationsStub operationsStub;
  private final GrpcStubCallableFactory callableFactory;

  public static final GrpcAccountManagementServiceStub create(
      AccountManagementServiceStubSettings settings) throws IOException {
    return new GrpcAccountManagementServiceStub(settings, ClientContext.create(settings));
  }

  public static final GrpcAccountManagementServiceStub create(ClientContext clientContext)
      throws IOException {
    return new GrpcAccountManagementServiceStub(
        AccountManagementServiceStubSettings.newBuilder().build(), clientContext);
  }

  public static final GrpcAccountManagementServiceStub create(
      ClientContext clientContext, GrpcStubCallableFactory callableFactory) throws IOException {
    return new GrpcAccountManagementServiceStub(
        AccountManagementServiceStubSettings.newBuilder().build(), clientContext, callableFactory);
  }

  /**
   * Constructs an instance of GrpcAccountManagementServiceStub, using the given settings. This is
   * protected so that it is easy to make a subclass, but otherwise, the static factory methods
   * should be preferred.
   */
  protected GrpcAccountManagementServiceStub(
      AccountManagementServiceStubSettings settings, ClientContext clientContext)
      throws IOException {
    this(settings, clientContext, new GrpcAccountManagementServiceCallableFactory());
  }

  /**
   * Constructs an instance of GrpcAccountManagementServiceStub, using the given settings. This is
   * protected so that it is easy to make a subclass, but otherwise, the static factory methods
   * should be preferred.
   */
  protected GrpcAccountManagementServiceStub(
      AccountManagementServiceStubSettings settings,
      ClientContext clientContext,
      GrpcStubCallableFactory callableFactory)
      throws IOException {
    this.callableFactory = callableFactory;
    this.operationsStub = GrpcOperationsStub.create(clientContext, callableFactory);

    GrpcCallSettings<FinalizeMfaEnrollmentRequest, FinalizeMfaEnrollmentResponse>
        finalizeMfaEnrollmentTransportSettings =
            GrpcCallSettings
                .<FinalizeMfaEnrollmentRequest, FinalizeMfaEnrollmentResponse>newBuilder()
                .setMethodDescriptor(finalizeMfaEnrollmentMethodDescriptor)
                .build();
    GrpcCallSettings<StartMfaEnrollmentRequest, StartMfaEnrollmentResponse>
        startMfaEnrollmentTransportSettings =
            GrpcCallSettings.<StartMfaEnrollmentRequest, StartMfaEnrollmentResponse>newBuilder()
                .setMethodDescriptor(startMfaEnrollmentMethodDescriptor)
                .build();
    GrpcCallSettings<WithdrawMfaRequest, WithdrawMfaResponse> withdrawMfaTransportSettings =
        GrpcCallSettings.<WithdrawMfaRequest, WithdrawMfaResponse>newBuilder()
            .setMethodDescriptor(withdrawMfaMethodDescriptor)
            .build();

    this.finalizeMfaEnrollmentCallable =
        callableFactory.createUnaryCallable(
            finalizeMfaEnrollmentTransportSettings,
            settings.finalizeMfaEnrollmentSettings(),
            clientContext);
    this.startMfaEnrollmentCallable =
        callableFactory.createUnaryCallable(
            startMfaEnrollmentTransportSettings,
            settings.startMfaEnrollmentSettings(),
            clientContext);
    this.withdrawMfaCallable =
        callableFactory.createUnaryCallable(
            withdrawMfaTransportSettings, settings.withdrawMfaSettings(), clientContext);

    this.backgroundResources =
        new BackgroundResourceAggregation(clientContext.getBackgroundResources());
  }

  public GrpcOperationsStub getOperationsStub() {
    return operationsStub;
  }

  @Override
  public UnaryCallable<FinalizeMfaEnrollmentRequest, FinalizeMfaEnrollmentResponse>
      finalizeMfaEnrollmentCallable() {
    return finalizeMfaEnrollmentCallable;
  }

  @Override
  public UnaryCallable<StartMfaEnrollmentRequest, StartMfaEnrollmentResponse>
      startMfaEnrollmentCallable() {
    return startMfaEnrollmentCallable;
  }

  @Override
  public UnaryCallable<WithdrawMfaRequest, WithdrawMfaResponse> withdrawMfaCallable() {
    return withdrawMfaCallable;
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
