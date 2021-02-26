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

package com.google.ccc.hosted.marketplace.v2.stub;

import com.google.api.gax.core.BackgroundResource;
import com.google.api.gax.core.BackgroundResourceAggregation;
import com.google.api.gax.grpc.GrpcCallSettings;
import com.google.api.gax.grpc.GrpcStubCallableFactory;
import com.google.api.gax.rpc.ClientContext;
import com.google.api.gax.rpc.RequestParamsExtractor;
import com.google.api.gax.rpc.UnaryCallable;
import com.google.ccc.hosted.marketplace.v2.CustomerLicense;
import com.google.ccc.hosted.marketplace.v2.CustomerLicenseGetRequest;
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
 * gRPC stub implementation for the CustomerLicenseService service API.
 *
 * <p>This class is for advanced usage and reflects the underlying API directly.
 */
@Generated("by gapic-generator-java")
public class GrpcCustomerLicenseServiceStub extends CustomerLicenseServiceStub {
  private static final MethodDescriptor<CustomerLicenseGetRequest, CustomerLicense>
      getMethodDescriptor =
          MethodDescriptor.<CustomerLicenseGetRequest, CustomerLicense>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName("ccc.hosted.marketplace.v2.CustomerLicenseService/Get")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(CustomerLicenseGetRequest.getDefaultInstance()))
              .setResponseMarshaller(ProtoUtils.marshaller(CustomerLicense.getDefaultInstance()))
              .build();

  private final UnaryCallable<CustomerLicenseGetRequest, CustomerLicense> getCallable;

  private final BackgroundResource backgroundResources;
  private final GrpcOperationsStub operationsStub;
  private final GrpcStubCallableFactory callableFactory;

  public static final GrpcCustomerLicenseServiceStub create(
      CustomerLicenseServiceStubSettings settings) throws IOException {
    return new GrpcCustomerLicenseServiceStub(settings, ClientContext.create(settings));
  }

  public static final GrpcCustomerLicenseServiceStub create(ClientContext clientContext)
      throws IOException {
    return new GrpcCustomerLicenseServiceStub(
        CustomerLicenseServiceStubSettings.newBuilder().build(), clientContext);
  }

  public static final GrpcCustomerLicenseServiceStub create(
      ClientContext clientContext, GrpcStubCallableFactory callableFactory) throws IOException {
    return new GrpcCustomerLicenseServiceStub(
        CustomerLicenseServiceStubSettings.newBuilder().build(), clientContext, callableFactory);
  }

  /**
   * Constructs an instance of GrpcCustomerLicenseServiceStub, using the given settings. This is
   * protected so that it is easy to make a subclass, but otherwise, the static factory methods
   * should be preferred.
   */
  protected GrpcCustomerLicenseServiceStub(
      CustomerLicenseServiceStubSettings settings, ClientContext clientContext) throws IOException {
    this(settings, clientContext, new GrpcCustomerLicenseServiceCallableFactory());
  }

  /**
   * Constructs an instance of GrpcCustomerLicenseServiceStub, using the given settings. This is
   * protected so that it is easy to make a subclass, but otherwise, the static factory methods
   * should be preferred.
   */
  protected GrpcCustomerLicenseServiceStub(
      CustomerLicenseServiceStubSettings settings,
      ClientContext clientContext,
      GrpcStubCallableFactory callableFactory)
      throws IOException {
    this.callableFactory = callableFactory;
    this.operationsStub = GrpcOperationsStub.create(clientContext, callableFactory);

    GrpcCallSettings<CustomerLicenseGetRequest, CustomerLicense> getTransportSettings =
        GrpcCallSettings.<CustomerLicenseGetRequest, CustomerLicense>newBuilder()
            .setMethodDescriptor(getMethodDescriptor)
            .setParamsExtractor(
                new RequestParamsExtractor<CustomerLicenseGetRequest>() {
                  @Override
                  public Map<String, String> extract(CustomerLicenseGetRequest request) {
                    ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                    params.put("application_id", String.valueOf(request.getApplicationId()));
                    params.put("customer_id", String.valueOf(request.getCustomerId()));
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
  public UnaryCallable<CustomerLicenseGetRequest, CustomerLicense> getCallable() {
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
