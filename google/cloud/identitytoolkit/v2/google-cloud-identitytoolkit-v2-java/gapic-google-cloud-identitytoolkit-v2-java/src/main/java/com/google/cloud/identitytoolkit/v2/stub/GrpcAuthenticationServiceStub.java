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
import com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInRequest;
import com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInResponse;
import com.google.cloud.identitytoolkit.v2.StartMfaSignInRequest;
import com.google.cloud.identitytoolkit.v2.StartMfaSignInResponse;
import com.google.longrunning.stub.GrpcOperationsStub;
import io.grpc.MethodDescriptor;
import io.grpc.protobuf.ProtoUtils;
import java.io.IOException;
import java.util.concurrent.TimeUnit;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * gRPC stub implementation for the AuthenticationService service API.
 *
 * <p>This class is for advanced usage and reflects the underlying API directly.
 */
@Generated("by gapic-generator-java")
public class GrpcAuthenticationServiceStub extends AuthenticationServiceStub {
  private static final MethodDescriptor<FinalizeMfaSignInRequest, FinalizeMfaSignInResponse>
      finalizeMfaSignInMethodDescriptor =
          MethodDescriptor.<FinalizeMfaSignInRequest, FinalizeMfaSignInResponse>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(
                  "google.cloud.identitytoolkit.v2.AuthenticationService/FinalizeMfaSignIn")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(FinalizeMfaSignInRequest.getDefaultInstance()))
              .setResponseMarshaller(
                  ProtoUtils.marshaller(FinalizeMfaSignInResponse.getDefaultInstance()))
              .build();

  private static final MethodDescriptor<StartMfaSignInRequest, StartMfaSignInResponse>
      startMfaSignInMethodDescriptor =
          MethodDescriptor.<StartMfaSignInRequest, StartMfaSignInResponse>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(
                  "google.cloud.identitytoolkit.v2.AuthenticationService/StartMfaSignIn")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(StartMfaSignInRequest.getDefaultInstance()))
              .setResponseMarshaller(
                  ProtoUtils.marshaller(StartMfaSignInResponse.getDefaultInstance()))
              .build();

  private final UnaryCallable<FinalizeMfaSignInRequest, FinalizeMfaSignInResponse>
      finalizeMfaSignInCallable;
  private final UnaryCallable<StartMfaSignInRequest, StartMfaSignInResponse> startMfaSignInCallable;

  private final BackgroundResource backgroundResources;
  private final GrpcOperationsStub operationsStub;
  private final GrpcStubCallableFactory callableFactory;

  public static final GrpcAuthenticationServiceStub create(
      AuthenticationServiceStubSettings settings) throws IOException {
    return new GrpcAuthenticationServiceStub(settings, ClientContext.create(settings));
  }

  public static final GrpcAuthenticationServiceStub create(ClientContext clientContext)
      throws IOException {
    return new GrpcAuthenticationServiceStub(
        AuthenticationServiceStubSettings.newBuilder().build(), clientContext);
  }

  public static final GrpcAuthenticationServiceStub create(
      ClientContext clientContext, GrpcStubCallableFactory callableFactory) throws IOException {
    return new GrpcAuthenticationServiceStub(
        AuthenticationServiceStubSettings.newBuilder().build(), clientContext, callableFactory);
  }

  /**
   * Constructs an instance of GrpcAuthenticationServiceStub, using the given settings. This is
   * protected so that it is easy to make a subclass, but otherwise, the static factory methods
   * should be preferred.
   */
  protected GrpcAuthenticationServiceStub(
      AuthenticationServiceStubSettings settings, ClientContext clientContext) throws IOException {
    this(settings, clientContext, new GrpcAuthenticationServiceCallableFactory());
  }

  /**
   * Constructs an instance of GrpcAuthenticationServiceStub, using the given settings. This is
   * protected so that it is easy to make a subclass, but otherwise, the static factory methods
   * should be preferred.
   */
  protected GrpcAuthenticationServiceStub(
      AuthenticationServiceStubSettings settings,
      ClientContext clientContext,
      GrpcStubCallableFactory callableFactory)
      throws IOException {
    this.callableFactory = callableFactory;
    this.operationsStub = GrpcOperationsStub.create(clientContext, callableFactory);

    GrpcCallSettings<FinalizeMfaSignInRequest, FinalizeMfaSignInResponse>
        finalizeMfaSignInTransportSettings =
            GrpcCallSettings.<FinalizeMfaSignInRequest, FinalizeMfaSignInResponse>newBuilder()
                .setMethodDescriptor(finalizeMfaSignInMethodDescriptor)
                .build();
    GrpcCallSettings<StartMfaSignInRequest, StartMfaSignInResponse>
        startMfaSignInTransportSettings =
            GrpcCallSettings.<StartMfaSignInRequest, StartMfaSignInResponse>newBuilder()
                .setMethodDescriptor(startMfaSignInMethodDescriptor)
                .build();

    this.finalizeMfaSignInCallable =
        callableFactory.createUnaryCallable(
            finalizeMfaSignInTransportSettings,
            settings.finalizeMfaSignInSettings(),
            clientContext);
    this.startMfaSignInCallable =
        callableFactory.createUnaryCallable(
            startMfaSignInTransportSettings, settings.startMfaSignInSettings(), clientContext);

    this.backgroundResources =
        new BackgroundResourceAggregation(clientContext.getBackgroundResources());
  }

  public GrpcOperationsStub getOperationsStub() {
    return operationsStub;
  }

  @Override
  public UnaryCallable<FinalizeMfaSignInRequest, FinalizeMfaSignInResponse>
      finalizeMfaSignInCallable() {
    return finalizeMfaSignInCallable;
  }

  @Override
  public UnaryCallable<StartMfaSignInRequest, StartMfaSignInResponse> startMfaSignInCallable() {
    return startMfaSignInCallable;
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
