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
import com.google.devtools.testing.v1.CancelTestMatrixRequest;
import com.google.devtools.testing.v1.CancelTestMatrixResponse;
import com.google.devtools.testing.v1.CreateTestMatrixRequest;
import com.google.devtools.testing.v1.GetTestMatrixRequest;
import com.google.devtools.testing.v1.TestMatrix;
import com.google.longrunning.stub.GrpcOperationsStub;
import io.grpc.MethodDescriptor;
import io.grpc.protobuf.ProtoUtils;
import java.io.IOException;
import java.util.Map;
import java.util.concurrent.TimeUnit;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * gRPC stub implementation for the TestExecutionService service API.
 *
 * <p>This class is for advanced usage and reflects the underlying API directly.
 */
@Generated("by gapic-generator-java")
public class GrpcTestExecutionServiceStub extends TestExecutionServiceStub {
  private static final MethodDescriptor<CreateTestMatrixRequest, TestMatrix>
      createTestMatrixMethodDescriptor =
          MethodDescriptor.<CreateTestMatrixRequest, TestMatrix>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName("google.devtools.testing.v1.TestExecutionService/CreateTestMatrix")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(CreateTestMatrixRequest.getDefaultInstance()))
              .setResponseMarshaller(ProtoUtils.marshaller(TestMatrix.getDefaultInstance()))
              .build();

  private static final MethodDescriptor<GetTestMatrixRequest, TestMatrix>
      getTestMatrixMethodDescriptor =
          MethodDescriptor.<GetTestMatrixRequest, TestMatrix>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName("google.devtools.testing.v1.TestExecutionService/GetTestMatrix")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(GetTestMatrixRequest.getDefaultInstance()))
              .setResponseMarshaller(ProtoUtils.marshaller(TestMatrix.getDefaultInstance()))
              .build();

  private static final MethodDescriptor<CancelTestMatrixRequest, CancelTestMatrixResponse>
      cancelTestMatrixMethodDescriptor =
          MethodDescriptor.<CancelTestMatrixRequest, CancelTestMatrixResponse>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName("google.devtools.testing.v1.TestExecutionService/CancelTestMatrix")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(CancelTestMatrixRequest.getDefaultInstance()))
              .setResponseMarshaller(
                  ProtoUtils.marshaller(CancelTestMatrixResponse.getDefaultInstance()))
              .build();

  private final UnaryCallable<CreateTestMatrixRequest, TestMatrix> createTestMatrixCallable;
  private final UnaryCallable<GetTestMatrixRequest, TestMatrix> getTestMatrixCallable;
  private final UnaryCallable<CancelTestMatrixRequest, CancelTestMatrixResponse>
      cancelTestMatrixCallable;

  private final BackgroundResource backgroundResources;
  private final GrpcOperationsStub operationsStub;
  private final GrpcStubCallableFactory callableFactory;

  public static final GrpcTestExecutionServiceStub create(TestExecutionServiceStubSettings settings)
      throws IOException {
    return new GrpcTestExecutionServiceStub(settings, ClientContext.create(settings));
  }

  public static final GrpcTestExecutionServiceStub create(ClientContext clientContext)
      throws IOException {
    return new GrpcTestExecutionServiceStub(
        TestExecutionServiceStubSettings.newBuilder().build(), clientContext);
  }

  public static final GrpcTestExecutionServiceStub create(
      ClientContext clientContext, GrpcStubCallableFactory callableFactory) throws IOException {
    return new GrpcTestExecutionServiceStub(
        TestExecutionServiceStubSettings.newBuilder().build(), clientContext, callableFactory);
  }

  /**
   * Constructs an instance of GrpcTestExecutionServiceStub, using the given settings. This is
   * protected so that it is easy to make a subclass, but otherwise, the static factory methods
   * should be preferred.
   */
  protected GrpcTestExecutionServiceStub(
      TestExecutionServiceStubSettings settings, ClientContext clientContext) throws IOException {
    this(settings, clientContext, new GrpcTestExecutionServiceCallableFactory());
  }

  /**
   * Constructs an instance of GrpcTestExecutionServiceStub, using the given settings. This is
   * protected so that it is easy to make a subclass, but otherwise, the static factory methods
   * should be preferred.
   */
  protected GrpcTestExecutionServiceStub(
      TestExecutionServiceStubSettings settings,
      ClientContext clientContext,
      GrpcStubCallableFactory callableFactory)
      throws IOException {
    this.callableFactory = callableFactory;
    this.operationsStub = GrpcOperationsStub.create(clientContext, callableFactory);

    GrpcCallSettings<CreateTestMatrixRequest, TestMatrix> createTestMatrixTransportSettings =
        GrpcCallSettings.<CreateTestMatrixRequest, TestMatrix>newBuilder()
            .setMethodDescriptor(createTestMatrixMethodDescriptor)
            .setParamsExtractor(
                new RequestParamsExtractor<CreateTestMatrixRequest>() {
                  @Override
                  public Map<String, String> extract(CreateTestMatrixRequest request) {
                    ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                    params.put("project_id", String.valueOf(request.getProjectId()));
                    return params.build();
                  }
                })
            .build();
    GrpcCallSettings<GetTestMatrixRequest, TestMatrix> getTestMatrixTransportSettings =
        GrpcCallSettings.<GetTestMatrixRequest, TestMatrix>newBuilder()
            .setMethodDescriptor(getTestMatrixMethodDescriptor)
            .setParamsExtractor(
                new RequestParamsExtractor<GetTestMatrixRequest>() {
                  @Override
                  public Map<String, String> extract(GetTestMatrixRequest request) {
                    ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                    params.put("project_id", String.valueOf(request.getProjectId()));
                    params.put("test_matrix_id", String.valueOf(request.getTestMatrixId()));
                    return params.build();
                  }
                })
            .build();
    GrpcCallSettings<CancelTestMatrixRequest, CancelTestMatrixResponse>
        cancelTestMatrixTransportSettings =
            GrpcCallSettings.<CancelTestMatrixRequest, CancelTestMatrixResponse>newBuilder()
                .setMethodDescriptor(cancelTestMatrixMethodDescriptor)
                .setParamsExtractor(
                    new RequestParamsExtractor<CancelTestMatrixRequest>() {
                      @Override
                      public Map<String, String> extract(CancelTestMatrixRequest request) {
                        ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                        params.put("project_id", String.valueOf(request.getProjectId()));
                        params.put("test_matrix_id", String.valueOf(request.getTestMatrixId()));
                        return params.build();
                      }
                    })
                .build();

    this.createTestMatrixCallable =
        callableFactory.createUnaryCallable(
            createTestMatrixTransportSettings, settings.createTestMatrixSettings(), clientContext);
    this.getTestMatrixCallable =
        callableFactory.createUnaryCallable(
            getTestMatrixTransportSettings, settings.getTestMatrixSettings(), clientContext);
    this.cancelTestMatrixCallable =
        callableFactory.createUnaryCallable(
            cancelTestMatrixTransportSettings, settings.cancelTestMatrixSettings(), clientContext);

    this.backgroundResources =
        new BackgroundResourceAggregation(clientContext.getBackgroundResources());
  }

  public GrpcOperationsStub getOperationsStub() {
    return operationsStub;
  }

  @Override
  public UnaryCallable<CreateTestMatrixRequest, TestMatrix> createTestMatrixCallable() {
    return createTestMatrixCallable;
  }

  @Override
  public UnaryCallable<GetTestMatrixRequest, TestMatrix> getTestMatrixCallable() {
    return getTestMatrixCallable;
  }

  @Override
  public UnaryCallable<CancelTestMatrixRequest, CancelTestMatrixResponse>
      cancelTestMatrixCallable() {
    return cancelTestMatrixCallable;
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
