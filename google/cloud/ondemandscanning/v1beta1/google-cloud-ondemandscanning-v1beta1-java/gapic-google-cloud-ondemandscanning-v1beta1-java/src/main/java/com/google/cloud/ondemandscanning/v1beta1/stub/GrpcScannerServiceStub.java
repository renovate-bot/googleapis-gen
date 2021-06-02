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

package com.google.cloud.ondemandscanning.v1beta1.stub;

import static com.google.cloud.ondemandscanning.v1beta1.ScannerServiceClient.ListVulnerabilitiesPagedResponse;

import com.google.api.core.BetaApi;
import com.google.api.gax.core.BackgroundResource;
import com.google.api.gax.core.BackgroundResourceAggregation;
import com.google.api.gax.grpc.GrpcCallSettings;
import com.google.api.gax.grpc.GrpcStubCallableFactory;
import com.google.api.gax.rpc.ClientContext;
import com.google.api.gax.rpc.OperationCallable;
import com.google.api.gax.rpc.RequestParamsExtractor;
import com.google.api.gax.rpc.UnaryCallable;
import com.google.cloud.ondemandscanning.v1beta1.AnalyzePackagesMetadata;
import com.google.cloud.ondemandscanning.v1beta1.AnalyzePackagesRequest;
import com.google.cloud.ondemandscanning.v1beta1.AnalyzePackagesResponse;
import com.google.cloud.ondemandscanning.v1beta1.ListVulnerabilitiesRequest;
import com.google.cloud.ondemandscanning.v1beta1.ListVulnerabilitiesResponse;
import com.google.common.collect.ImmutableMap;
import com.google.longrunning.Operation;
import com.google.longrunning.stub.GrpcOperationsStub;
import io.grpc.MethodDescriptor;
import io.grpc.protobuf.ProtoUtils;
import java.io.IOException;
import java.util.Map;
import java.util.concurrent.TimeUnit;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * gRPC stub implementation for the ScannerService service API.
 *
 * <p>This class is for advanced usage and reflects the underlying API directly.
 */
@BetaApi
@Generated("by gapic-generator-java")
public class GrpcScannerServiceStub extends ScannerServiceStub {
  private static final MethodDescriptor<AnalyzePackagesRequest, Operation>
      analyzePackagesMethodDescriptor =
          MethodDescriptor.<AnalyzePackagesRequest, Operation>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(
                  "google.cloud.ondemandscanning.v1beta1.ScannerService/AnalyzePackages")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(AnalyzePackagesRequest.getDefaultInstance()))
              .setResponseMarshaller(ProtoUtils.marshaller(Operation.getDefaultInstance()))
              .build();

  private static final MethodDescriptor<ListVulnerabilitiesRequest, ListVulnerabilitiesResponse>
      listVulnerabilitiesMethodDescriptor =
          MethodDescriptor.<ListVulnerabilitiesRequest, ListVulnerabilitiesResponse>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(
                  "google.cloud.ondemandscanning.v1beta1.ScannerService/ListVulnerabilities")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(ListVulnerabilitiesRequest.getDefaultInstance()))
              .setResponseMarshaller(
                  ProtoUtils.marshaller(ListVulnerabilitiesResponse.getDefaultInstance()))
              .build();

  private final UnaryCallable<AnalyzePackagesRequest, Operation> analyzePackagesCallable;
  private final OperationCallable<
          AnalyzePackagesRequest, AnalyzePackagesResponse, AnalyzePackagesMetadata>
      analyzePackagesOperationCallable;
  private final UnaryCallable<ListVulnerabilitiesRequest, ListVulnerabilitiesResponse>
      listVulnerabilitiesCallable;
  private final UnaryCallable<ListVulnerabilitiesRequest, ListVulnerabilitiesPagedResponse>
      listVulnerabilitiesPagedCallable;

  private final BackgroundResource backgroundResources;
  private final GrpcOperationsStub operationsStub;
  private final GrpcStubCallableFactory callableFactory;

  public static final GrpcScannerServiceStub create(ScannerServiceStubSettings settings)
      throws IOException {
    return new GrpcScannerServiceStub(settings, ClientContext.create(settings));
  }

  public static final GrpcScannerServiceStub create(ClientContext clientContext)
      throws IOException {
    return new GrpcScannerServiceStub(
        ScannerServiceStubSettings.newBuilder().build(), clientContext);
  }

  public static final GrpcScannerServiceStub create(
      ClientContext clientContext, GrpcStubCallableFactory callableFactory) throws IOException {
    return new GrpcScannerServiceStub(
        ScannerServiceStubSettings.newBuilder().build(), clientContext, callableFactory);
  }

  /**
   * Constructs an instance of GrpcScannerServiceStub, using the given settings. This is protected
   * so that it is easy to make a subclass, but otherwise, the static factory methods should be
   * preferred.
   */
  protected GrpcScannerServiceStub(ScannerServiceStubSettings settings, ClientContext clientContext)
      throws IOException {
    this(settings, clientContext, new GrpcScannerServiceCallableFactory());
  }

  /**
   * Constructs an instance of GrpcScannerServiceStub, using the given settings. This is protected
   * so that it is easy to make a subclass, but otherwise, the static factory methods should be
   * preferred.
   */
  protected GrpcScannerServiceStub(
      ScannerServiceStubSettings settings,
      ClientContext clientContext,
      GrpcStubCallableFactory callableFactory)
      throws IOException {
    this.callableFactory = callableFactory;
    this.operationsStub = GrpcOperationsStub.create(clientContext, callableFactory);

    GrpcCallSettings<AnalyzePackagesRequest, Operation> analyzePackagesTransportSettings =
        GrpcCallSettings.<AnalyzePackagesRequest, Operation>newBuilder()
            .setMethodDescriptor(analyzePackagesMethodDescriptor)
            .setParamsExtractor(
                new RequestParamsExtractor<AnalyzePackagesRequest>() {
                  @Override
                  public Map<String, String> extract(AnalyzePackagesRequest request) {
                    ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                    params.put("parent", String.valueOf(request.getParent()));
                    return params.build();
                  }
                })
            .build();
    GrpcCallSettings<ListVulnerabilitiesRequest, ListVulnerabilitiesResponse>
        listVulnerabilitiesTransportSettings =
            GrpcCallSettings.<ListVulnerabilitiesRequest, ListVulnerabilitiesResponse>newBuilder()
                .setMethodDescriptor(listVulnerabilitiesMethodDescriptor)
                .setParamsExtractor(
                    new RequestParamsExtractor<ListVulnerabilitiesRequest>() {
                      @Override
                      public Map<String, String> extract(ListVulnerabilitiesRequest request) {
                        ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                        params.put("parent", String.valueOf(request.getParent()));
                        return params.build();
                      }
                    })
                .build();

    this.analyzePackagesCallable =
        callableFactory.createUnaryCallable(
            analyzePackagesTransportSettings, settings.analyzePackagesSettings(), clientContext);
    this.analyzePackagesOperationCallable =
        callableFactory.createOperationCallable(
            analyzePackagesTransportSettings,
            settings.analyzePackagesOperationSettings(),
            clientContext,
            operationsStub);
    this.listVulnerabilitiesCallable =
        callableFactory.createUnaryCallable(
            listVulnerabilitiesTransportSettings,
            settings.listVulnerabilitiesSettings(),
            clientContext);
    this.listVulnerabilitiesPagedCallable =
        callableFactory.createPagedCallable(
            listVulnerabilitiesTransportSettings,
            settings.listVulnerabilitiesSettings(),
            clientContext);

    this.backgroundResources =
        new BackgroundResourceAggregation(clientContext.getBackgroundResources());
  }

  public GrpcOperationsStub getOperationsStub() {
    return operationsStub;
  }

  @Override
  public UnaryCallable<AnalyzePackagesRequest, Operation> analyzePackagesCallable() {
    return analyzePackagesCallable;
  }

  @Override
  public OperationCallable<AnalyzePackagesRequest, AnalyzePackagesResponse, AnalyzePackagesMetadata>
      analyzePackagesOperationCallable() {
    return analyzePackagesOperationCallable;
  }

  @Override
  public UnaryCallable<ListVulnerabilitiesRequest, ListVulnerabilitiesResponse>
      listVulnerabilitiesCallable() {
    return listVulnerabilitiesCallable;
  }

  @Override
  public UnaryCallable<ListVulnerabilitiesRequest, ListVulnerabilitiesPagedResponse>
      listVulnerabilitiesPagedCallable() {
    return listVulnerabilitiesPagedCallable;
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
