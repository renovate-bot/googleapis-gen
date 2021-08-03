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

package com.google.geo.ugc.streetview.publish.v1.stub;

import static com.google.geo.ugc.streetview.publish.v1.StreetViewPublishServiceClient.ListPhotosPagedResponse;

import com.google.api.gax.core.BackgroundResource;
import com.google.api.gax.core.BackgroundResourceAggregation;
import com.google.api.gax.grpc.GrpcCallSettings;
import com.google.api.gax.grpc.GrpcStubCallableFactory;
import com.google.api.gax.rpc.ClientContext;
import com.google.api.gax.rpc.RequestParamsExtractor;
import com.google.api.gax.rpc.UnaryCallable;
import com.google.common.collect.ImmutableMap;
import com.google.geo.ugc.streetview.publish.v1.StreetViewPublishResources;
import com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages;
import com.google.longrunning.stub.GrpcOperationsStub;
import com.google.protobuf.Empty;
import io.grpc.MethodDescriptor;
import io.grpc.protobuf.ProtoUtils;
import java.io.IOException;
import java.util.Map;
import java.util.concurrent.TimeUnit;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * gRPC stub implementation for the StreetViewPublishService service API.
 *
 * <p>This class is for advanced usage and reflects the underlying API directly.
 */
@Generated("by gapic-generator-java")
public class GrpcStreetViewPublishServiceStub extends StreetViewPublishServiceStub {
  private static final MethodDescriptor<Empty, StreetViewPublishResources.UploadRef>
      startUploadMethodDescriptor =
          MethodDescriptor.<Empty, StreetViewPublishResources.UploadRef>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(
                  "google.streetview.publish.v1.StreetViewPublishService/StartUpload")
              .setRequestMarshaller(ProtoUtils.marshaller(Empty.getDefaultInstance()))
              .setResponseMarshaller(
                  ProtoUtils.marshaller(StreetViewPublishResources.UploadRef.getDefaultInstance()))
              .build();

  private static final MethodDescriptor<
          StreetViewPublishRpcMessages.CreatePhotoRequest, StreetViewPublishResources.Photo>
      createPhotoMethodDescriptor =
          MethodDescriptor
              .<StreetViewPublishRpcMessages.CreatePhotoRequest, StreetViewPublishResources.Photo>
                  newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(
                  "google.streetview.publish.v1.StreetViewPublishService/CreatePhoto")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(
                      StreetViewPublishRpcMessages.CreatePhotoRequest.getDefaultInstance()))
              .setResponseMarshaller(
                  ProtoUtils.marshaller(StreetViewPublishResources.Photo.getDefaultInstance()))
              .build();

  private static final MethodDescriptor<
          StreetViewPublishRpcMessages.GetPhotoRequest, StreetViewPublishResources.Photo>
      getPhotoMethodDescriptor =
          MethodDescriptor
              .<StreetViewPublishRpcMessages.GetPhotoRequest, StreetViewPublishResources.Photo>
                  newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName("google.streetview.publish.v1.StreetViewPublishService/GetPhoto")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(
                      StreetViewPublishRpcMessages.GetPhotoRequest.getDefaultInstance()))
              .setResponseMarshaller(
                  ProtoUtils.marshaller(StreetViewPublishResources.Photo.getDefaultInstance()))
              .build();

  private static final MethodDescriptor<
          StreetViewPublishRpcMessages.BatchGetPhotosRequest,
          StreetViewPublishRpcMessages.BatchGetPhotosResponse>
      batchGetPhotosMethodDescriptor =
          MethodDescriptor
              .<StreetViewPublishRpcMessages.BatchGetPhotosRequest,
                  StreetViewPublishRpcMessages.BatchGetPhotosResponse>
                  newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(
                  "google.streetview.publish.v1.StreetViewPublishService/BatchGetPhotos")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(
                      StreetViewPublishRpcMessages.BatchGetPhotosRequest.getDefaultInstance()))
              .setResponseMarshaller(
                  ProtoUtils.marshaller(
                      StreetViewPublishRpcMessages.BatchGetPhotosResponse.getDefaultInstance()))
              .build();

  private static final MethodDescriptor<
          StreetViewPublishRpcMessages.ListPhotosRequest,
          StreetViewPublishRpcMessages.ListPhotosResponse>
      listPhotosMethodDescriptor =
          MethodDescriptor
              .<StreetViewPublishRpcMessages.ListPhotosRequest,
                  StreetViewPublishRpcMessages.ListPhotosResponse>
                  newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName("google.streetview.publish.v1.StreetViewPublishService/ListPhotos")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(
                      StreetViewPublishRpcMessages.ListPhotosRequest.getDefaultInstance()))
              .setResponseMarshaller(
                  ProtoUtils.marshaller(
                      StreetViewPublishRpcMessages.ListPhotosResponse.getDefaultInstance()))
              .build();

  private static final MethodDescriptor<
          StreetViewPublishRpcMessages.UpdatePhotoRequest, StreetViewPublishResources.Photo>
      updatePhotoMethodDescriptor =
          MethodDescriptor
              .<StreetViewPublishRpcMessages.UpdatePhotoRequest, StreetViewPublishResources.Photo>
                  newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(
                  "google.streetview.publish.v1.StreetViewPublishService/UpdatePhoto")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(
                      StreetViewPublishRpcMessages.UpdatePhotoRequest.getDefaultInstance()))
              .setResponseMarshaller(
                  ProtoUtils.marshaller(StreetViewPublishResources.Photo.getDefaultInstance()))
              .build();

  private static final MethodDescriptor<
          StreetViewPublishRpcMessages.BatchUpdatePhotosRequest,
          StreetViewPublishRpcMessages.BatchUpdatePhotosResponse>
      batchUpdatePhotosMethodDescriptor =
          MethodDescriptor
              .<StreetViewPublishRpcMessages.BatchUpdatePhotosRequest,
                  StreetViewPublishRpcMessages.BatchUpdatePhotosResponse>
                  newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(
                  "google.streetview.publish.v1.StreetViewPublishService/BatchUpdatePhotos")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(
                      StreetViewPublishRpcMessages.BatchUpdatePhotosRequest.getDefaultInstance()))
              .setResponseMarshaller(
                  ProtoUtils.marshaller(
                      StreetViewPublishRpcMessages.BatchUpdatePhotosResponse.getDefaultInstance()))
              .build();

  private static final MethodDescriptor<StreetViewPublishRpcMessages.DeletePhotoRequest, Empty>
      deletePhotoMethodDescriptor =
          MethodDescriptor.<StreetViewPublishRpcMessages.DeletePhotoRequest, Empty>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(
                  "google.streetview.publish.v1.StreetViewPublishService/DeletePhoto")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(
                      StreetViewPublishRpcMessages.DeletePhotoRequest.getDefaultInstance()))
              .setResponseMarshaller(ProtoUtils.marshaller(Empty.getDefaultInstance()))
              .build();

  private static final MethodDescriptor<
          StreetViewPublishRpcMessages.BatchDeletePhotosRequest,
          StreetViewPublishRpcMessages.BatchDeletePhotosResponse>
      batchDeletePhotosMethodDescriptor =
          MethodDescriptor
              .<StreetViewPublishRpcMessages.BatchDeletePhotosRequest,
                  StreetViewPublishRpcMessages.BatchDeletePhotosResponse>
                  newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(
                  "google.streetview.publish.v1.StreetViewPublishService/BatchDeletePhotos")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(
                      StreetViewPublishRpcMessages.BatchDeletePhotosRequest.getDefaultInstance()))
              .setResponseMarshaller(
                  ProtoUtils.marshaller(
                      StreetViewPublishRpcMessages.BatchDeletePhotosResponse.getDefaultInstance()))
              .build();

  private final UnaryCallable<Empty, StreetViewPublishResources.UploadRef> startUploadCallable;
  private final UnaryCallable<
          StreetViewPublishRpcMessages.CreatePhotoRequest, StreetViewPublishResources.Photo>
      createPhotoCallable;
  private final UnaryCallable<
          StreetViewPublishRpcMessages.GetPhotoRequest, StreetViewPublishResources.Photo>
      getPhotoCallable;
  private final UnaryCallable<
          StreetViewPublishRpcMessages.BatchGetPhotosRequest,
          StreetViewPublishRpcMessages.BatchGetPhotosResponse>
      batchGetPhotosCallable;
  private final UnaryCallable<
          StreetViewPublishRpcMessages.ListPhotosRequest,
          StreetViewPublishRpcMessages.ListPhotosResponse>
      listPhotosCallable;
  private final UnaryCallable<
          StreetViewPublishRpcMessages.ListPhotosRequest, ListPhotosPagedResponse>
      listPhotosPagedCallable;
  private final UnaryCallable<
          StreetViewPublishRpcMessages.UpdatePhotoRequest, StreetViewPublishResources.Photo>
      updatePhotoCallable;
  private final UnaryCallable<
          StreetViewPublishRpcMessages.BatchUpdatePhotosRequest,
          StreetViewPublishRpcMessages.BatchUpdatePhotosResponse>
      batchUpdatePhotosCallable;
  private final UnaryCallable<StreetViewPublishRpcMessages.DeletePhotoRequest, Empty>
      deletePhotoCallable;
  private final UnaryCallable<
          StreetViewPublishRpcMessages.BatchDeletePhotosRequest,
          StreetViewPublishRpcMessages.BatchDeletePhotosResponse>
      batchDeletePhotosCallable;

  private final BackgroundResource backgroundResources;
  private final GrpcOperationsStub operationsStub;
  private final GrpcStubCallableFactory callableFactory;

  public static final GrpcStreetViewPublishServiceStub create(
      StreetViewPublishServiceStubSettings settings) throws IOException {
    return new GrpcStreetViewPublishServiceStub(settings, ClientContext.create(settings));
  }

  public static final GrpcStreetViewPublishServiceStub create(ClientContext clientContext)
      throws IOException {
    return new GrpcStreetViewPublishServiceStub(
        StreetViewPublishServiceStubSettings.newBuilder().build(), clientContext);
  }

  public static final GrpcStreetViewPublishServiceStub create(
      ClientContext clientContext, GrpcStubCallableFactory callableFactory) throws IOException {
    return new GrpcStreetViewPublishServiceStub(
        StreetViewPublishServiceStubSettings.newBuilder().build(), clientContext, callableFactory);
  }

  /**
   * Constructs an instance of GrpcStreetViewPublishServiceStub, using the given settings. This is
   * protected so that it is easy to make a subclass, but otherwise, the static factory methods
   * should be preferred.
   */
  protected GrpcStreetViewPublishServiceStub(
      StreetViewPublishServiceStubSettings settings, ClientContext clientContext)
      throws IOException {
    this(settings, clientContext, new GrpcStreetViewPublishServiceCallableFactory());
  }

  /**
   * Constructs an instance of GrpcStreetViewPublishServiceStub, using the given settings. This is
   * protected so that it is easy to make a subclass, but otherwise, the static factory methods
   * should be preferred.
   */
  protected GrpcStreetViewPublishServiceStub(
      StreetViewPublishServiceStubSettings settings,
      ClientContext clientContext,
      GrpcStubCallableFactory callableFactory)
      throws IOException {
    this.callableFactory = callableFactory;
    this.operationsStub = GrpcOperationsStub.create(clientContext, callableFactory);

    GrpcCallSettings<Empty, StreetViewPublishResources.UploadRef> startUploadTransportSettings =
        GrpcCallSettings.<Empty, StreetViewPublishResources.UploadRef>newBuilder()
            .setMethodDescriptor(startUploadMethodDescriptor)
            .build();
    GrpcCallSettings<
            StreetViewPublishRpcMessages.CreatePhotoRequest, StreetViewPublishResources.Photo>
        createPhotoTransportSettings =
            GrpcCallSettings
                .<StreetViewPublishRpcMessages.CreatePhotoRequest, StreetViewPublishResources.Photo>
                    newBuilder()
                .setMethodDescriptor(createPhotoMethodDescriptor)
                .build();
    GrpcCallSettings<StreetViewPublishRpcMessages.GetPhotoRequest, StreetViewPublishResources.Photo>
        getPhotoTransportSettings =
            GrpcCallSettings
                .<StreetViewPublishRpcMessages.GetPhotoRequest, StreetViewPublishResources.Photo>
                    newBuilder()
                .setMethodDescriptor(getPhotoMethodDescriptor)
                .setParamsExtractor(
                    new RequestParamsExtractor<StreetViewPublishRpcMessages.GetPhotoRequest>() {
                      @Override
                      public Map<String, String> extract(
                          StreetViewPublishRpcMessages.GetPhotoRequest request) {
                        ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                        params.put("photo_id", String.valueOf(request.getPhotoId()));
                        return params.build();
                      }
                    })
                .build();
    GrpcCallSettings<
            StreetViewPublishRpcMessages.BatchGetPhotosRequest,
            StreetViewPublishRpcMessages.BatchGetPhotosResponse>
        batchGetPhotosTransportSettings =
            GrpcCallSettings
                .<StreetViewPublishRpcMessages.BatchGetPhotosRequest,
                    StreetViewPublishRpcMessages.BatchGetPhotosResponse>
                    newBuilder()
                .setMethodDescriptor(batchGetPhotosMethodDescriptor)
                .build();
    GrpcCallSettings<
            StreetViewPublishRpcMessages.ListPhotosRequest,
            StreetViewPublishRpcMessages.ListPhotosResponse>
        listPhotosTransportSettings =
            GrpcCallSettings
                .<StreetViewPublishRpcMessages.ListPhotosRequest,
                    StreetViewPublishRpcMessages.ListPhotosResponse>
                    newBuilder()
                .setMethodDescriptor(listPhotosMethodDescriptor)
                .build();
    GrpcCallSettings<
            StreetViewPublishRpcMessages.UpdatePhotoRequest, StreetViewPublishResources.Photo>
        updatePhotoTransportSettings =
            GrpcCallSettings
                .<StreetViewPublishRpcMessages.UpdatePhotoRequest, StreetViewPublishResources.Photo>
                    newBuilder()
                .setMethodDescriptor(updatePhotoMethodDescriptor)
                .setParamsExtractor(
                    new RequestParamsExtractor<StreetViewPublishRpcMessages.UpdatePhotoRequest>() {
                      @Override
                      public Map<String, String> extract(
                          StreetViewPublishRpcMessages.UpdatePhotoRequest request) {
                        ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                        params.put(
                            "photo.photo_id.id",
                            String.valueOf(request.getPhoto().getPhotoId().getId()));
                        return params.build();
                      }
                    })
                .build();
    GrpcCallSettings<
            StreetViewPublishRpcMessages.BatchUpdatePhotosRequest,
            StreetViewPublishRpcMessages.BatchUpdatePhotosResponse>
        batchUpdatePhotosTransportSettings =
            GrpcCallSettings
                .<StreetViewPublishRpcMessages.BatchUpdatePhotosRequest,
                    StreetViewPublishRpcMessages.BatchUpdatePhotosResponse>
                    newBuilder()
                .setMethodDescriptor(batchUpdatePhotosMethodDescriptor)
                .build();
    GrpcCallSettings<StreetViewPublishRpcMessages.DeletePhotoRequest, Empty>
        deletePhotoTransportSettings =
            GrpcCallSettings.<StreetViewPublishRpcMessages.DeletePhotoRequest, Empty>newBuilder()
                .setMethodDescriptor(deletePhotoMethodDescriptor)
                .setParamsExtractor(
                    new RequestParamsExtractor<StreetViewPublishRpcMessages.DeletePhotoRequest>() {
                      @Override
                      public Map<String, String> extract(
                          StreetViewPublishRpcMessages.DeletePhotoRequest request) {
                        ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                        params.put("photo_id", String.valueOf(request.getPhotoId()));
                        return params.build();
                      }
                    })
                .build();
    GrpcCallSettings<
            StreetViewPublishRpcMessages.BatchDeletePhotosRequest,
            StreetViewPublishRpcMessages.BatchDeletePhotosResponse>
        batchDeletePhotosTransportSettings =
            GrpcCallSettings
                .<StreetViewPublishRpcMessages.BatchDeletePhotosRequest,
                    StreetViewPublishRpcMessages.BatchDeletePhotosResponse>
                    newBuilder()
                .setMethodDescriptor(batchDeletePhotosMethodDescriptor)
                .build();

    this.startUploadCallable =
        callableFactory.createUnaryCallable(
            startUploadTransportSettings, settings.startUploadSettings(), clientContext);
    this.createPhotoCallable =
        callableFactory.createUnaryCallable(
            createPhotoTransportSettings, settings.createPhotoSettings(), clientContext);
    this.getPhotoCallable =
        callableFactory.createUnaryCallable(
            getPhotoTransportSettings, settings.getPhotoSettings(), clientContext);
    this.batchGetPhotosCallable =
        callableFactory.createUnaryCallable(
            batchGetPhotosTransportSettings, settings.batchGetPhotosSettings(), clientContext);
    this.listPhotosCallable =
        callableFactory.createUnaryCallable(
            listPhotosTransportSettings, settings.listPhotosSettings(), clientContext);
    this.listPhotosPagedCallable =
        callableFactory.createPagedCallable(
            listPhotosTransportSettings, settings.listPhotosSettings(), clientContext);
    this.updatePhotoCallable =
        callableFactory.createUnaryCallable(
            updatePhotoTransportSettings, settings.updatePhotoSettings(), clientContext);
    this.batchUpdatePhotosCallable =
        callableFactory.createUnaryCallable(
            batchUpdatePhotosTransportSettings,
            settings.batchUpdatePhotosSettings(),
            clientContext);
    this.deletePhotoCallable =
        callableFactory.createUnaryCallable(
            deletePhotoTransportSettings, settings.deletePhotoSettings(), clientContext);
    this.batchDeletePhotosCallable =
        callableFactory.createUnaryCallable(
            batchDeletePhotosTransportSettings,
            settings.batchDeletePhotosSettings(),
            clientContext);

    this.backgroundResources =
        new BackgroundResourceAggregation(clientContext.getBackgroundResources());
  }

  public GrpcOperationsStub getOperationsStub() {
    return operationsStub;
  }

  @Override
  public UnaryCallable<Empty, StreetViewPublishResources.UploadRef> startUploadCallable() {
    return startUploadCallable;
  }

  @Override
  public UnaryCallable<
          StreetViewPublishRpcMessages.CreatePhotoRequest, StreetViewPublishResources.Photo>
      createPhotoCallable() {
    return createPhotoCallable;
  }

  @Override
  public UnaryCallable<
          StreetViewPublishRpcMessages.GetPhotoRequest, StreetViewPublishResources.Photo>
      getPhotoCallable() {
    return getPhotoCallable;
  }

  @Override
  public UnaryCallable<
          StreetViewPublishRpcMessages.BatchGetPhotosRequest,
          StreetViewPublishRpcMessages.BatchGetPhotosResponse>
      batchGetPhotosCallable() {
    return batchGetPhotosCallable;
  }

  @Override
  public UnaryCallable<
          StreetViewPublishRpcMessages.ListPhotosRequest,
          StreetViewPublishRpcMessages.ListPhotosResponse>
      listPhotosCallable() {
    return listPhotosCallable;
  }

  @Override
  public UnaryCallable<StreetViewPublishRpcMessages.ListPhotosRequest, ListPhotosPagedResponse>
      listPhotosPagedCallable() {
    return listPhotosPagedCallable;
  }

  @Override
  public UnaryCallable<
          StreetViewPublishRpcMessages.UpdatePhotoRequest, StreetViewPublishResources.Photo>
      updatePhotoCallable() {
    return updatePhotoCallable;
  }

  @Override
  public UnaryCallable<
          StreetViewPublishRpcMessages.BatchUpdatePhotosRequest,
          StreetViewPublishRpcMessages.BatchUpdatePhotosResponse>
      batchUpdatePhotosCallable() {
    return batchUpdatePhotosCallable;
  }

  @Override
  public UnaryCallable<StreetViewPublishRpcMessages.DeletePhotoRequest, Empty>
      deletePhotoCallable() {
    return deletePhotoCallable;
  }

  @Override
  public UnaryCallable<
          StreetViewPublishRpcMessages.BatchDeletePhotosRequest,
          StreetViewPublishRpcMessages.BatchDeletePhotosResponse>
      batchDeletePhotosCallable() {
    return batchDeletePhotosCallable;
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
