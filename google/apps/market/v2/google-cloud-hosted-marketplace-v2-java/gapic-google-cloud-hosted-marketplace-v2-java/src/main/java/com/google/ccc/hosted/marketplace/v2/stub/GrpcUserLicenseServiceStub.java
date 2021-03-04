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

package com.google.ccc.hosted.marketplace.v2.stub;

import com.google.api.gax.core.BackgroundResource;
import com.google.api.gax.core.BackgroundResourceAggregation;
import com.google.api.gax.grpc.GrpcCallSettings;
import com.google.api.gax.grpc.GrpcStubCallableFactory;
import com.google.api.gax.rpc.ClientContext;
import com.google.api.gax.rpc.RequestParamsExtractor;
import com.google.api.gax.rpc.UnaryCallable;
import com.google.ccc.hosted.marketplace.v2.UserLicense;
import com.google.ccc.hosted.marketplace.v2.UserLicenseGetRequest;
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
 * gRPC stub implementation for the UserLicenseService service API.
 *
 * <p>This class is for advanced usage and reflects the underlying API directly.
 */
@Generated("by gapic-generator-java")
public class GrpcUserLicenseServiceStub extends UserLicenseServiceStub {
  private static final MethodDescriptor<UserLicenseGetRequest, UserLicense> getMethodDescriptor =
      MethodDescriptor.<UserLicenseGetRequest, UserLicense>newBuilder()
          .setType(MethodDescriptor.MethodType.UNARY)
          .setFullMethodName("ccc.hosted.marketplace.v2.UserLicenseService/Get")
          .setRequestMarshaller(ProtoUtils.marshaller(UserLicenseGetRequest.getDefaultInstance()))
          .setResponseMarshaller(ProtoUtils.marshaller(UserLicense.getDefaultInstance()))
          .build();

  private final UnaryCallable<UserLicenseGetRequest, UserLicense> getCallable;

  private final BackgroundResource backgroundResources;
  private final GrpcOperationsStub operationsStub;
  private final GrpcStubCallableFactory callableFactory;

  public static final GrpcUserLicenseServiceStub create(UserLicenseServiceStubSettings settings)
      throws IOException {
    return new GrpcUserLicenseServiceStub(settings, ClientContext.create(settings));
  }

  public static final GrpcUserLicenseServiceStub create(ClientContext clientContext)
      throws IOException {
    return new GrpcUserLicenseServiceStub(
        UserLicenseServiceStubSettings.newBuilder().build(), clientContext);
  }

  public static final GrpcUserLicenseServiceStub create(
      ClientContext clientContext, GrpcStubCallableFactory callableFactory) throws IOException {
    return new GrpcUserLicenseServiceStub(
        UserLicenseServiceStubSettings.newBuilder().build(), clientContext, callableFactory);
  }

  /**
   * Constructs an instance of GrpcUserLicenseServiceStub, using the given settings. This is
   * protected so that it is easy to make a subclass, but otherwise, the static factory methods
   * should be preferred.
   */
  protected GrpcUserLicenseServiceStub(
      UserLicenseServiceStubSettings settings, ClientContext clientContext) throws IOException {
    this(settings, clientContext, new GrpcUserLicenseServiceCallableFactory());
  }

  /**
   * Constructs an instance of GrpcUserLicenseServiceStub, using the given settings. This is
   * protected so that it is easy to make a subclass, but otherwise, the static factory methods
   * should be preferred.
   */
  protected GrpcUserLicenseServiceStub(
      UserLicenseServiceStubSettings settings,
      ClientContext clientContext,
      GrpcStubCallableFactory callableFactory)
      throws IOException {
    this.callableFactory = callableFactory;
    this.operationsStub = GrpcOperationsStub.create(clientContext, callableFactory);

    GrpcCallSettings<UserLicenseGetRequest, UserLicense> getTransportSettings =
        GrpcCallSettings.<UserLicenseGetRequest, UserLicense>newBuilder()
            .setMethodDescriptor(getMethodDescriptor)
            .setParamsExtractor(
                new RequestParamsExtractor<UserLicenseGetRequest>() {
                  @Override
                  public Map<String, String> extract(UserLicenseGetRequest request) {
                    ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                    params.put("application_id", String.valueOf(request.getApplicationId()));
                    params.put("user_id", String.valueOf(request.getUserId()));
                    return params.build();
                  }
                })
            .build();

    this.getCallable =
        callableFactory.createUnaryCallable(
            getTransportSettings, settings.getSettings(), clientContext);

    this.backgroundResources =
        new BackgroundResourceAggregation(clientContext.getBackgroundResources());
  }

  public GrpcOperationsStub getOperationsStub() {
    return operationsStub;
  }

  @Override
  public UnaryCallable<UserLicenseGetRequest, UserLicense> getCallable() {
    return getCallable;
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
