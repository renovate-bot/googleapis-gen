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

package com.google.devtools.testing.v1.stub;

import com.google.api.gax.core.BackgroundResource;
import com.google.api.gax.core.BackgroundResourceAggregation;
import com.google.api.gax.grpc.GrpcCallSettings;
import com.google.api.gax.grpc.GrpcStubCallableFactory;
import com.google.api.gax.rpc.ClientContext;
import com.google.api.gax.rpc.RequestParamsExtractor;
import com.google.api.gax.rpc.UnaryCallable;
import com.google.common.collect.ImmutableMap;
import com.google.devtools.testing.v1.GetTestEnvironmentCatalogRequest;
import com.google.devtools.testing.v1.TestEnvironmentCatalog;
import com.google.longrunning.stub.GrpcOperationsStub;
import io.grpc.MethodDescriptor;
import io.grpc.protobuf.ProtoUtils;
import java.io.IOException;
import java.util.Map;
import java.util.concurrent.TimeUnit;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * gRPC stub implementation for the TestEnvironmentDiscoveryService service API.
 *
 * <p>This class is for advanced usage and reflects the underlying API directly.
 */
@Generated("by gapic-generator-java")
public class GrpcTestEnvironmentDiscoveryServiceStub extends TestEnvironmentDiscoveryServiceStub {
  private static final MethodDescriptor<GetTestEnvironmentCatalogRequest, TestEnvironmentCatalog>
      getTestEnvironmentCatalogMethodDescriptor =
          MethodDescriptor.<GetTestEnvironmentCatalogRequest, TestEnvironmentCatalog>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(
                  "google.devtools.testing.v1.TestEnvironmentDiscoveryService/GetTestEnvironmentCatalog")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(GetTestEnvironmentCatalogRequest.getDefaultInstance()))
              .setResponseMarshaller(
                  ProtoUtils.marshaller(TestEnvironmentCatalog.getDefaultInstance()))
              .build();

  private final UnaryCallable<GetTestEnvironmentCatalogRequest, TestEnvironmentCatalog>
      getTestEnvironmentCatalogCallable;

  private final BackgroundResource backgroundResources;
  private final GrpcOperationsStub operationsStub;
  private final GrpcStubCallableFactory callableFactory;

  public static final GrpcTestEnvironmentDiscoveryServiceStub create(
      TestEnvironmentDiscoveryServiceStubSettings settings) throws IOException {
    return new GrpcTestEnvironmentDiscoveryServiceStub(settings, ClientContext.create(settings));
  }

  public static final GrpcTestEnvironmentDiscoveryServiceStub create(ClientContext clientContext)
      throws IOException {
    return new GrpcTestEnvironmentDiscoveryServiceStub(
        TestEnvironmentDiscoveryServiceStubSettings.newBuilder().build(), clientContext);
  }

  public static final GrpcTestEnvironmentDiscoveryServiceStub create(
      ClientContext clientContext, GrpcStubCallableFactory callableFactory) throws IOException {
    return new GrpcTestEnvironmentDiscoveryServiceStub(
        TestEnvironmentDiscoveryServiceStubSettings.newBuilder().build(),
        clientContext,
        callableFactory);
  }

  /**
   * Constructs an instance of GrpcTestEnvironmentDiscoveryServiceStub, using the given settings.
   * This is protected so that it is easy to make a subclass, but otherwise, the static factory
   * methods should be preferred.
   */
  protected GrpcTestEnvironmentDiscoveryServiceStub(
      TestEnvironmentDiscoveryServiceStubSettings settings, ClientContext clientContext)
      throws IOException {
    this(settings, clientContext, new GrpcTestEnvironmentDiscoveryServiceCallableFactory());
  }

  /**
   * Constructs an instance of GrpcTestEnvironmentDiscoveryServiceStub, using the given settings.
   * This is protected so that it is easy to make a subclass, but otherwise, the static factory
   * methods should be preferred.
   */
  protected GrpcTestEnvironmentDiscoveryServiceStub(
      TestEnvironmentDiscoveryServiceStubSettings settings,
      ClientContext clientContext,
      GrpcStubCallableFactory callableFactory)
      throws IOException {
    this.callableFactory = callableFactory;
    this.operationsStub = GrpcOperationsStub.create(clientContext, callableFactory);

    GrpcCallSettings<GetTestEnvironmentCatalogRequest, TestEnvironmentCatalog>
        getTestEnvironmentCatalogTransportSettings =
            GrpcCallSettings.<GetTestEnvironmentCatalogRequest, TestEnvironmentCatalog>newBuilder()
                .setMethodDescriptor(getTestEnvironmentCatalogMethodDescriptor)
                .setParamsExtractor(
                    new RequestParamsExtractor<GetTestEnvironmentCatalogRequest>() {
                      @Override
                      public Map<String, String> extract(GetTestEnvironmentCatalogRequest request) {
                        ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                        params.put(
                            "environment_type", String.valueOf(request.getEnvironmentType()));
                        return params.build();
                      }
                    })
                .build();

    this.getTestEnvironmentCatalogCallable =
        callableFactory.createUnaryCallable(
            getTestEnvironmentCatalogTransportSettings,
            settings.getTestEnvironmentCatalogSettings(),
            clientContext);

    this.backgroundResources =
        new BackgroundResourceAggregation(clientContext.getBackgroundResources());
  }

  public GrpcOperationsStub getOperationsStub() {
    return operationsStub;
  }

  @Override
  public UnaryCallable<GetTestEnvironmentCatalogRequest, TestEnvironmentCatalog>
      getTestEnvironmentCatalogCallable() {
    return getTestEnvironmentCatalogCallable;
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
