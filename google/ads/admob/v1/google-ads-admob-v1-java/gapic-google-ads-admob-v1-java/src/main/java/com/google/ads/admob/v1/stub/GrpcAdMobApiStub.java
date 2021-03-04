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

package com.google.ads.admob.v1.stub;

import static com.google.ads.admob.v1.AdMobApiClient.ListPublisherAccountsPagedResponse;

import com.google.ads.admob.v1.AdMobApiProto;
import com.google.ads.admob.v1.AdMobResourcesProto;
import com.google.api.gax.core.BackgroundResource;
import com.google.api.gax.core.BackgroundResourceAggregation;
import com.google.api.gax.grpc.GrpcCallSettings;
import com.google.api.gax.grpc.GrpcStubCallableFactory;
import com.google.api.gax.rpc.ClientContext;
import com.google.api.gax.rpc.RequestParamsExtractor;
import com.google.api.gax.rpc.ServerStreamingCallable;
import com.google.api.gax.rpc.UnaryCallable;
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
 * gRPC stub implementation for the AdMobApi service API.
 *
 * <p>This class is for advanced usage and reflects the underlying API directly.
 */
@Generated("by gapic-generator-java")
public class GrpcAdMobApiStub extends AdMobApiStub {
  private static final MethodDescriptor<
          AdMobApiProto.GetPublisherAccountRequest, AdMobResourcesProto.PublisherAccount>
      getPublisherAccountMethodDescriptor =
          MethodDescriptor
              .<AdMobApiProto.GetPublisherAccountRequest, AdMobResourcesProto.PublisherAccount>
                  newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName("google.ads.admob.v1.AdMobApi/GetPublisherAccount")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(
                      AdMobApiProto.GetPublisherAccountRequest.getDefaultInstance()))
              .setResponseMarshaller(
                  ProtoUtils.marshaller(AdMobResourcesProto.PublisherAccount.getDefaultInstance()))
              .build();

  private static final MethodDescriptor<
          AdMobApiProto.ListPublisherAccountsRequest, AdMobApiProto.ListPublisherAccountsResponse>
      listPublisherAccountsMethodDescriptor =
          MethodDescriptor
              .<AdMobApiProto.ListPublisherAccountsRequest,
                  AdMobApiProto.ListPublisherAccountsResponse>
                  newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName("google.ads.admob.v1.AdMobApi/ListPublisherAccounts")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(
                      AdMobApiProto.ListPublisherAccountsRequest.getDefaultInstance()))
              .setResponseMarshaller(
                  ProtoUtils.marshaller(
                      AdMobApiProto.ListPublisherAccountsResponse.getDefaultInstance()))
              .build();

  private static final MethodDescriptor<
          AdMobApiProto.GenerateNetworkReportRequest, AdMobApiProto.GenerateNetworkReportResponse>
      generateNetworkReportMethodDescriptor =
          MethodDescriptor
              .<AdMobApiProto.GenerateNetworkReportRequest,
                  AdMobApiProto.GenerateNetworkReportResponse>
                  newBuilder()
              .setType(MethodDescriptor.MethodType.SERVER_STREAMING)
              .setFullMethodName("google.ads.admob.v1.AdMobApi/GenerateNetworkReport")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(
                      AdMobApiProto.GenerateNetworkReportRequest.getDefaultInstance()))
              .setResponseMarshaller(
                  ProtoUtils.marshaller(
                      AdMobApiProto.GenerateNetworkReportResponse.getDefaultInstance()))
              .build();

  private static final MethodDescriptor<
          AdMobApiProto.GenerateMediationReportRequest,
          AdMobApiProto.GenerateMediationReportResponse>
      generateMediationReportMethodDescriptor =
          MethodDescriptor
              .<AdMobApiProto.GenerateMediationReportRequest,
                  AdMobApiProto.GenerateMediationReportResponse>
                  newBuilder()
              .setType(MethodDescriptor.MethodType.SERVER_STREAMING)
              .setFullMethodName("google.ads.admob.v1.AdMobApi/GenerateMediationReport")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(
                      AdMobApiProto.GenerateMediationReportRequest.getDefaultInstance()))
              .setResponseMarshaller(
                  ProtoUtils.marshaller(
                      AdMobApiProto.GenerateMediationReportResponse.getDefaultInstance()))
              .build();

  private final UnaryCallable<
          AdMobApiProto.GetPublisherAccountRequest, AdMobResourcesProto.PublisherAccount>
      getPublisherAccountCallable;
  private final UnaryCallable<
          AdMobApiProto.ListPublisherAccountsRequest, AdMobApiProto.ListPublisherAccountsResponse>
      listPublisherAccountsCallable;
  private final UnaryCallable<
          AdMobApiProto.ListPublisherAccountsRequest, ListPublisherAccountsPagedResponse>
      listPublisherAccountsPagedCallable;
  private final ServerStreamingCallable<
          AdMobApiProto.GenerateNetworkReportRequest, AdMobApiProto.GenerateNetworkReportResponse>
      generateNetworkReportCallable;
  private final ServerStreamingCallable<
          AdMobApiProto.GenerateMediationReportRequest,
          AdMobApiProto.GenerateMediationReportResponse>
      generateMediationReportCallable;

  private final BackgroundResource backgroundResources;
  private final GrpcOperationsStub operationsStub;
  private final GrpcStubCallableFactory callableFactory;

  public static final GrpcAdMobApiStub create(AdMobApiStubSettings settings) throws IOException {
    return new GrpcAdMobApiStub(settings, ClientContext.create(settings));
  }

  public static final GrpcAdMobApiStub create(ClientContext clientContext) throws IOException {
    return new GrpcAdMobApiStub(AdMobApiStubSettings.newBuilder().build(), clientContext);
  }

  public static final GrpcAdMobApiStub create(
      ClientContext clientContext, GrpcStubCallableFactory callableFactory) throws IOException {
    return new GrpcAdMobApiStub(
        AdMobApiStubSettings.newBuilder().build(), clientContext, callableFactory);
  }

  /**
   * Constructs an instance of GrpcAdMobApiStub, using the given settings. This is protected so that
   * it is easy to make a subclass, but otherwise, the static factory methods should be preferred.
   */
  protected GrpcAdMobApiStub(AdMobApiStubSettings settings, ClientContext clientContext)
      throws IOException {
    this(settings, clientContext, new GrpcAdMobApiCallableFactory());
  }

  /**
   * Constructs an instance of GrpcAdMobApiStub, using the given settings. This is protected so that
   * it is easy to make a subclass, but otherwise, the static factory methods should be preferred.
   */
  protected GrpcAdMobApiStub(
      AdMobApiStubSettings settings,
      ClientContext clientContext,
      GrpcStubCallableFactory callableFactory)
      throws IOException {
    this.callableFactory = callableFactory;
    this.operationsStub = GrpcOperationsStub.create(clientContext, callableFactory);

    GrpcCallSettings<AdMobApiProto.GetPublisherAccountRequest, AdMobResourcesProto.PublisherAccount>
        getPublisherAccountTransportSettings =
            GrpcCallSettings
                .<AdMobApiProto.GetPublisherAccountRequest, AdMobResourcesProto.PublisherAccount>
                    newBuilder()
                .setMethodDescriptor(getPublisherAccountMethodDescriptor)
                .setParamsExtractor(
                    new RequestParamsExtractor<AdMobApiProto.GetPublisherAccountRequest>() {
                      @Override
                      public Map<String, String> extract(
                          AdMobApiProto.GetPublisherAccountRequest request) {
                        ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                        params.put("name", String.valueOf(request.getName()));
                        return params.build();
                      }
                    })
                .build();
    GrpcCallSettings<
            AdMobApiProto.ListPublisherAccountsRequest, AdMobApiProto.ListPublisherAccountsResponse>
        listPublisherAccountsTransportSettings =
            GrpcCallSettings
                .<AdMobApiProto.ListPublisherAccountsRequest,
                    AdMobApiProto.ListPublisherAccountsResponse>
                    newBuilder()
                .setMethodDescriptor(listPublisherAccountsMethodDescriptor)
                .build();
    GrpcCallSettings<
            AdMobApiProto.GenerateNetworkReportRequest, AdMobApiProto.GenerateNetworkReportResponse>
        generateNetworkReportTransportSettings =
            GrpcCallSettings
                .<AdMobApiProto.GenerateNetworkReportRequest,
                    AdMobApiProto.GenerateNetworkReportResponse>
                    newBuilder()
                .setMethodDescriptor(generateNetworkReportMethodDescriptor)
                .setParamsExtractor(
                    new RequestParamsExtractor<AdMobApiProto.GenerateNetworkReportRequest>() {
                      @Override
                      public Map<String, String> extract(
                          AdMobApiProto.GenerateNetworkReportRequest request) {
                        ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                        params.put("parent", String.valueOf(request.getParent()));
                        return params.build();
                      }
                    })
                .build();
    GrpcCallSettings<
            AdMobApiProto.GenerateMediationReportRequest,
            AdMobApiProto.GenerateMediationReportResponse>
        generateMediationReportTransportSettings =
            GrpcCallSettings
                .<AdMobApiProto.GenerateMediationReportRequest,
                    AdMobApiProto.GenerateMediationReportResponse>
                    newBuilder()
                .setMethodDescriptor(generateMediationReportMethodDescriptor)
                .setParamsExtractor(
                    new RequestParamsExtractor<AdMobApiProto.GenerateMediationReportRequest>() {
                      @Override
                      public Map<String, String> extract(
                          AdMobApiProto.GenerateMediationReportRequest request) {
                        ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                        params.put("parent", String.valueOf(request.getParent()));
                        return params.build();
                      }
                    })
                .build();

    this.getPublisherAccountCallable =
        callableFactory.createUnaryCallable(
            getPublisherAccountTransportSettings,
            settings.getPublisherAccountSettings(),
            clientContext);
    this.listPublisherAccountsCallable =
        callableFactory.createUnaryCallable(
            listPublisherAccountsTransportSettings,
            settings.listPublisherAccountsSettings(),
            clientContext);
    this.listPublisherAccountsPagedCallable =
        callableFactory.createPagedCallable(
            listPublisherAccountsTransportSettings,
            settings.listPublisherAccountsSettings(),
            clientContext);
    this.generateNetworkReportCallable =
        callableFactory.createServerStreamingCallable(
            generateNetworkReportTransportSettings,
            settings.generateNetworkReportSettings(),
            clientContext);
    this.generateMediationReportCallable =
        callableFactory.createServerStreamingCallable(
            generateMediationReportTransportSettings,
            settings.generateMediationReportSettings(),
            clientContext);

    this.backgroundResources =
        new BackgroundResourceAggregation(clientContext.getBackgroundResources());
  }

  public GrpcOperationsStub getOperationsStub() {
    return operationsStub;
  }

  @Override
  public UnaryCallable<
          AdMobApiProto.GetPublisherAccountRequest, AdMobResourcesProto.PublisherAccount>
      getPublisherAccountCallable() {
    return getPublisherAccountCallable;
  }

  @Override
  public UnaryCallable<
          AdMobApiProto.ListPublisherAccountsRequest, AdMobApiProto.ListPublisherAccountsResponse>
      listPublisherAccountsCallable() {
    return listPublisherAccountsCallable;
  }

  @Override
  public UnaryCallable<
          AdMobApiProto.ListPublisherAccountsRequest, ListPublisherAccountsPagedResponse>
      listPublisherAccountsPagedCallable() {
    return listPublisherAccountsPagedCallable;
  }

  @Override
  public ServerStreamingCallable<
          AdMobApiProto.GenerateNetworkReportRequest, AdMobApiProto.GenerateNetworkReportResponse>
      generateNetworkReportCallable() {
    return generateNetworkReportCallable;
  }

  @Override
  public ServerStreamingCallable<
          AdMobApiProto.GenerateMediationReportRequest,
          AdMobApiProto.GenerateMediationReportResponse>
      generateMediationReportCallable() {
    return generateMediationReportCallable;
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
