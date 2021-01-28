/*
 * Copyright 2020 Google LLC
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     https://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
package com.google.ads.admob.v1.stub;

import static com.google.ads.admob.v1.AdMobApiClient.ListPublisherAccountsPagedResponse;

import com.google.ads.admob.v1.AdMobApiProto.GenerateMediationReportRequest;
import com.google.ads.admob.v1.AdMobApiProto.GenerateMediationReportResponse;
import com.google.ads.admob.v1.AdMobApiProto.GenerateNetworkReportRequest;
import com.google.ads.admob.v1.AdMobApiProto.GenerateNetworkReportResponse;
import com.google.ads.admob.v1.AdMobApiProto.GetPublisherAccountRequest;
import com.google.ads.admob.v1.AdMobApiProto.ListPublisherAccountsRequest;
import com.google.ads.admob.v1.AdMobApiProto.ListPublisherAccountsResponse;
import com.google.ads.admob.v1.AdMobResourcesProto.PublisherAccount;
import com.google.api.core.BetaApi;
import com.google.api.gax.core.BackgroundResource;
import com.google.api.gax.core.BackgroundResourceAggregation;
import com.google.api.gax.grpc.GrpcCallSettings;
import com.google.api.gax.grpc.GrpcStubCallableFactory;
import com.google.api.gax.rpc.ClientContext;
import com.google.api.gax.rpc.RequestParamsExtractor;
import com.google.api.gax.rpc.ServerStreamingCallable;
import com.google.api.gax.rpc.UnaryCallable;
import com.google.common.collect.ImmutableMap;
import io.grpc.MethodDescriptor;
import io.grpc.protobuf.ProtoUtils;
import java.io.IOException;
import java.util.Map;
import java.util.concurrent.TimeUnit;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS
/**
 * gRPC stub implementation for AdMob API.
 *
 * <p>This class is for advanced usage and reflects the underlying API directly.
 */
@Generated("by gapic-generator")
@BetaApi("A restructuring of stub classes is planned, so this may break in the future")
public class GrpcAdMobApiStub extends AdMobApiStub {

  private static final MethodDescriptor<GetPublisherAccountRequest, PublisherAccount>
      getPublisherAccountMethodDescriptor =
          MethodDescriptor.<GetPublisherAccountRequest, PublisherAccount>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName("google.ads.admob.v1.AdMobApi/GetPublisherAccount")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(GetPublisherAccountRequest.getDefaultInstance()))
              .setResponseMarshaller(ProtoUtils.marshaller(PublisherAccount.getDefaultInstance()))
              .build();
  private static final MethodDescriptor<ListPublisherAccountsRequest, ListPublisherAccountsResponse>
      listPublisherAccountsMethodDescriptor =
          MethodDescriptor.<ListPublisherAccountsRequest, ListPublisherAccountsResponse>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName("google.ads.admob.v1.AdMobApi/ListPublisherAccounts")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(ListPublisherAccountsRequest.getDefaultInstance()))
              .setResponseMarshaller(
                  ProtoUtils.marshaller(ListPublisherAccountsResponse.getDefaultInstance()))
              .build();
  private static final MethodDescriptor<GenerateNetworkReportRequest, GenerateNetworkReportResponse>
      generateNetworkReportMethodDescriptor =
          MethodDescriptor.<GenerateNetworkReportRequest, GenerateNetworkReportResponse>newBuilder()
              .setType(MethodDescriptor.MethodType.SERVER_STREAMING)
              .setFullMethodName("google.ads.admob.v1.AdMobApi/GenerateNetworkReport")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(GenerateNetworkReportRequest.getDefaultInstance()))
              .setResponseMarshaller(
                  ProtoUtils.marshaller(GenerateNetworkReportResponse.getDefaultInstance()))
              .build();
  private static final MethodDescriptor<
          GenerateMediationReportRequest, GenerateMediationReportResponse>
      generateMediationReportMethodDescriptor =
          MethodDescriptor
              .<GenerateMediationReportRequest, GenerateMediationReportResponse>newBuilder()
              .setType(MethodDescriptor.MethodType.SERVER_STREAMING)
              .setFullMethodName("google.ads.admob.v1.AdMobApi/GenerateMediationReport")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(GenerateMediationReportRequest.getDefaultInstance()))
              .setResponseMarshaller(
                  ProtoUtils.marshaller(GenerateMediationReportResponse.getDefaultInstance()))
              .build();

  private final BackgroundResource backgroundResources;

  private final UnaryCallable<GetPublisherAccountRequest, PublisherAccount>
      getPublisherAccountCallable;
  private final UnaryCallable<ListPublisherAccountsRequest, ListPublisherAccountsResponse>
      listPublisherAccountsCallable;
  private final UnaryCallable<ListPublisherAccountsRequest, ListPublisherAccountsPagedResponse>
      listPublisherAccountsPagedCallable;
  private final ServerStreamingCallable<GenerateNetworkReportRequest, GenerateNetworkReportResponse>
      generateNetworkReportCallable;
  private final ServerStreamingCallable<
          GenerateMediationReportRequest, GenerateMediationReportResponse>
      generateMediationReportCallable;

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

    GrpcCallSettings<GetPublisherAccountRequest, PublisherAccount>
        getPublisherAccountTransportSettings =
            GrpcCallSettings.<GetPublisherAccountRequest, PublisherAccount>newBuilder()
                .setMethodDescriptor(getPublisherAccountMethodDescriptor)
                .setParamsExtractor(
                    new RequestParamsExtractor<GetPublisherAccountRequest>() {
                      @Override
                      public Map<String, String> extract(GetPublisherAccountRequest request) {
                        ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                        params.put("name", String.valueOf(request.getName()));
                        return params.build();
                      }
                    })
                .build();
    GrpcCallSettings<ListPublisherAccountsRequest, ListPublisherAccountsResponse>
        listPublisherAccountsTransportSettings =
            GrpcCallSettings
                .<ListPublisherAccountsRequest, ListPublisherAccountsResponse>newBuilder()
                .setMethodDescriptor(listPublisherAccountsMethodDescriptor)
                .build();
    GrpcCallSettings<GenerateNetworkReportRequest, GenerateNetworkReportResponse>
        generateNetworkReportTransportSettings =
            GrpcCallSettings
                .<GenerateNetworkReportRequest, GenerateNetworkReportResponse>newBuilder()
                .setMethodDescriptor(generateNetworkReportMethodDescriptor)
                .setParamsExtractor(
                    new RequestParamsExtractor<GenerateNetworkReportRequest>() {
                      @Override
                      public Map<String, String> extract(GenerateNetworkReportRequest request) {
                        ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                        params.put("parent", String.valueOf(request.getParent()));
                        return params.build();
                      }
                    })
                .build();
    GrpcCallSettings<GenerateMediationReportRequest, GenerateMediationReportResponse>
        generateMediationReportTransportSettings =
            GrpcCallSettings
                .<GenerateMediationReportRequest, GenerateMediationReportResponse>newBuilder()
                .setMethodDescriptor(generateMediationReportMethodDescriptor)
                .setParamsExtractor(
                    new RequestParamsExtractor<GenerateMediationReportRequest>() {
                      @Override
                      public Map<String, String> extract(GenerateMediationReportRequest request) {
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

    backgroundResources = new BackgroundResourceAggregation(clientContext.getBackgroundResources());
  }

  public UnaryCallable<GetPublisherAccountRequest, PublisherAccount> getPublisherAccountCallable() {
    return getPublisherAccountCallable;
  }

  public UnaryCallable<ListPublisherAccountsRequest, ListPublisherAccountsPagedResponse>
      listPublisherAccountsPagedCallable() {
    return listPublisherAccountsPagedCallable;
  }

  public UnaryCallable<ListPublisherAccountsRequest, ListPublisherAccountsResponse>
      listPublisherAccountsCallable() {
    return listPublisherAccountsCallable;
  }

  public ServerStreamingCallable<GenerateNetworkReportRequest, GenerateNetworkReportResponse>
      generateNetworkReportCallable() {
    return generateNetworkReportCallable;
  }

  public ServerStreamingCallable<GenerateMediationReportRequest, GenerateMediationReportResponse>
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
