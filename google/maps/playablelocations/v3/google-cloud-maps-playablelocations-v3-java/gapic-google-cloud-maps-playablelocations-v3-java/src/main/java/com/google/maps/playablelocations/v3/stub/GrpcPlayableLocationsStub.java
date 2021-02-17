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

package com.google.maps.playablelocations.v3.stub;

import com.google.api.gax.core.BackgroundResource;
import com.google.api.gax.core.BackgroundResourceAggregation;
import com.google.api.gax.grpc.GrpcCallSettings;
import com.google.api.gax.grpc.GrpcStubCallableFactory;
import com.google.api.gax.rpc.ClientContext;
import com.google.api.gax.rpc.UnaryCallable;
import com.google.longrunning.stub.GrpcOperationsStub;
import com.google.maps.playablelocations.v3.LogImpressionsRequest;
import com.google.maps.playablelocations.v3.LogImpressionsResponse;
import com.google.maps.playablelocations.v3.LogPlayerReportsRequest;
import com.google.maps.playablelocations.v3.LogPlayerReportsResponse;
import com.google.maps.playablelocations.v3.SamplePlayableLocationsRequest;
import com.google.maps.playablelocations.v3.SamplePlayableLocationsResponse;
import io.grpc.MethodDescriptor;
import io.grpc.protobuf.ProtoUtils;
import java.io.IOException;
import java.util.concurrent.TimeUnit;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * gRPC stub implementation for the PlayableLocations service API.
 *
 * <p>This class is for advanced usage and reflects the underlying API directly.
 */
@Generated("by gapic-generator-java")
public class GrpcPlayableLocationsStub extends PlayableLocationsStub {
  private static final MethodDescriptor<
          SamplePlayableLocationsRequest, SamplePlayableLocationsResponse>
      samplePlayableLocationsMethodDescriptor =
          MethodDescriptor
              .<SamplePlayableLocationsRequest, SamplePlayableLocationsResponse>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(
                  "google.maps.playablelocations.v3.PlayableLocations/SamplePlayableLocations")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(SamplePlayableLocationsRequest.getDefaultInstance()))
              .setResponseMarshaller(
                  ProtoUtils.marshaller(SamplePlayableLocationsResponse.getDefaultInstance()))
              .build();

  private static final MethodDescriptor<LogPlayerReportsRequest, LogPlayerReportsResponse>
      logPlayerReportsMethodDescriptor =
          MethodDescriptor.<LogPlayerReportsRequest, LogPlayerReportsResponse>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(
                  "google.maps.playablelocations.v3.PlayableLocations/LogPlayerReports")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(LogPlayerReportsRequest.getDefaultInstance()))
              .setResponseMarshaller(
                  ProtoUtils.marshaller(LogPlayerReportsResponse.getDefaultInstance()))
              .build();

  private static final MethodDescriptor<LogImpressionsRequest, LogImpressionsResponse>
      logImpressionsMethodDescriptor =
          MethodDescriptor.<LogImpressionsRequest, LogImpressionsResponse>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(
                  "google.maps.playablelocations.v3.PlayableLocations/LogImpressions")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(LogImpressionsRequest.getDefaultInstance()))
              .setResponseMarshaller(
                  ProtoUtils.marshaller(LogImpressionsResponse.getDefaultInstance()))
              .build();

  private final UnaryCallable<SamplePlayableLocationsRequest, SamplePlayableLocationsResponse>
      samplePlayableLocationsCallable;
  private final UnaryCallable<LogPlayerReportsRequest, LogPlayerReportsResponse>
      logPlayerReportsCallable;
  private final UnaryCallable<LogImpressionsRequest, LogImpressionsResponse> logImpressionsCallable;

  private final BackgroundResource backgroundResources;
  private final GrpcOperationsStub operationsStub;
  private final GrpcStubCallableFactory callableFactory;

  public static final GrpcPlayableLocationsStub create(PlayableLocationsStubSettings settings)
      throws IOException {
    return new GrpcPlayableLocationsStub(settings, ClientContext.create(settings));
  }

  public static final GrpcPlayableLocationsStub create(ClientContext clientContext)
      throws IOException {
    return new GrpcPlayableLocationsStub(
        PlayableLocationsStubSettings.newBuilder().build(), clientContext);
  }

  public static final GrpcPlayableLocationsStub create(
      ClientContext clientContext, GrpcStubCallableFactory callableFactory) throws IOException {
    return new GrpcPlayableLocationsStub(
        PlayableLocationsStubSettings.newBuilder().build(), clientContext, callableFactory);
  }

  /**
   * Constructs an instance of GrpcPlayableLocationsStub, using the given settings. This is
   * protected so that it is easy to make a subclass, but otherwise, the static factory methods
   * should be preferred.
   */
  protected GrpcPlayableLocationsStub(
      PlayableLocationsStubSettings settings, ClientContext clientContext) throws IOException {
    this(settings, clientContext, new GrpcPlayableLocationsCallableFactory());
  }

  /**
   * Constructs an instance of GrpcPlayableLocationsStub, using the given settings. This is
   * protected so that it is easy to make a subclass, but otherwise, the static factory methods
   * should be preferred.
   */
  protected GrpcPlayableLocationsStub(
      PlayableLocationsStubSettings settings,
      ClientContext clientContext,
      GrpcStubCallableFactory callableFactory)
      throws IOException {
    this.callableFactory = callableFactory;
    this.operationsStub = GrpcOperationsStub.create(clientContext, callableFactory);

    GrpcCallSettings<SamplePlayableLocationsRequest, SamplePlayableLocationsResponse>
        samplePlayableLocationsTransportSettings =
            GrpcCallSettings
                .<SamplePlayableLocationsRequest, SamplePlayableLocationsResponse>newBuilder()
                .setMethodDescriptor(samplePlayableLocationsMethodDescriptor)
                .build();
    GrpcCallSettings<LogPlayerReportsRequest, LogPlayerReportsResponse>
        logPlayerReportsTransportSettings =
            GrpcCallSettings.<LogPlayerReportsRequest, LogPlayerReportsResponse>newBuilder()
                .setMethodDescriptor(logPlayerReportsMethodDescriptor)
                .build();
    GrpcCallSettings<LogImpressionsRequest, LogImpressionsResponse>
        logImpressionsTransportSettings =
            GrpcCallSettings.<LogImpressionsRequest, LogImpressionsResponse>newBuilder()
                .setMethodDescriptor(logImpressionsMethodDescriptor)
                .build();

    this.samplePlayableLocationsCallable =
        callableFactory.createUnaryCallable(
            samplePlayableLocationsTransportSettings,
            settings.samplePlayableLocationsSettings(),
            clientContext);
    this.logPlayerReportsCallable =
        callableFactory.createUnaryCallable(
            logPlayerReportsTransportSettings, settings.logPlayerReportsSettings(), clientContext);
    this.logImpressionsCallable =
        callableFactory.createUnaryCallable(
            logImpressionsTransportSettings, settings.logImpressionsSettings(), clientContext);

    this.backgroundResources =
        new BackgroundResourceAggregation(clientContext.getBackgroundResources());
  }

  public GrpcOperationsStub getOperationsStub() {
    return operationsStub;
  }

  @Override
  public UnaryCallable<SamplePlayableLocationsRequest, SamplePlayableLocationsResponse>
      samplePlayableLocationsCallable() {
    return samplePlayableLocationsCallable;
  }

  @Override
  public UnaryCallable<LogPlayerReportsRequest, LogPlayerReportsResponse>
      logPlayerReportsCallable() {
    return logPlayerReportsCallable;
  }

  @Override
  public UnaryCallable<LogImpressionsRequest, LogImpressionsResponse> logImpressionsCallable() {
    return logImpressionsCallable;
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
