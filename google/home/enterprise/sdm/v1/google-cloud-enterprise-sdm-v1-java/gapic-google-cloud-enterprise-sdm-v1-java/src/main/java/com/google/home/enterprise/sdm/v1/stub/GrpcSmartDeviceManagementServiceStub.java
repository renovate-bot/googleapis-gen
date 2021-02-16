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

package com.google.home.enterprise.sdm.v1.stub;

import static com.google.home.enterprise.sdm.v1.SmartDeviceManagementServiceClient.ListDevicesPagedResponse;
import static com.google.home.enterprise.sdm.v1.SmartDeviceManagementServiceClient.ListRoomsPagedResponse;
import static com.google.home.enterprise.sdm.v1.SmartDeviceManagementServiceClient.ListStructuresPagedResponse;

import com.google.api.gax.core.BackgroundResource;
import com.google.api.gax.core.BackgroundResourceAggregation;
import com.google.api.gax.grpc.GrpcCallSettings;
import com.google.api.gax.grpc.GrpcStubCallableFactory;
import com.google.api.gax.rpc.ClientContext;
import com.google.api.gax.rpc.RequestParamsExtractor;
import com.google.api.gax.rpc.UnaryCallable;
import com.google.common.collect.ImmutableMap;
import com.google.home.enterprise.sdm.v1.Device;
import com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandRequest;
import com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandResponse;
import com.google.home.enterprise.sdm.v1.GetDeviceRequest;
import com.google.home.enterprise.sdm.v1.GetRoomRequest;
import com.google.home.enterprise.sdm.v1.GetStructureRequest;
import com.google.home.enterprise.sdm.v1.ListDevicesRequest;
import com.google.home.enterprise.sdm.v1.ListDevicesResponse;
import com.google.home.enterprise.sdm.v1.ListRoomsRequest;
import com.google.home.enterprise.sdm.v1.ListRoomsResponse;
import com.google.home.enterprise.sdm.v1.ListStructuresRequest;
import com.google.home.enterprise.sdm.v1.ListStructuresResponse;
import com.google.home.enterprise.sdm.v1.Room;
import com.google.home.enterprise.sdm.v1.Structure;
import com.google.longrunning.stub.GrpcOperationsStub;
import io.grpc.MethodDescriptor;
import io.grpc.protobuf.ProtoUtils;
import java.io.IOException;
import java.util.Map;
import java.util.concurrent.TimeUnit;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * gRPC stub implementation for the SmartDeviceManagementService service API.
 *
 * <p>This class is for advanced usage and reflects the underlying API directly.
 */
@Generated("by gapic-generator-java")
public class GrpcSmartDeviceManagementServiceStub extends SmartDeviceManagementServiceStub {
  private static final MethodDescriptor<GetDeviceRequest, Device> getDeviceMethodDescriptor =
      MethodDescriptor.<GetDeviceRequest, Device>newBuilder()
          .setType(MethodDescriptor.MethodType.UNARY)
          .setFullMethodName("google.home.enterprise.sdm.v1.SmartDeviceManagementService/GetDevice")
          .setRequestMarshaller(ProtoUtils.marshaller(GetDeviceRequest.getDefaultInstance()))
          .setResponseMarshaller(ProtoUtils.marshaller(Device.getDefaultInstance()))
          .build();

  private static final MethodDescriptor<ListDevicesRequest, ListDevicesResponse>
      listDevicesMethodDescriptor =
          MethodDescriptor.<ListDevicesRequest, ListDevicesResponse>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(
                  "google.home.enterprise.sdm.v1.SmartDeviceManagementService/ListDevices")
              .setRequestMarshaller(ProtoUtils.marshaller(ListDevicesRequest.getDefaultInstance()))
              .setResponseMarshaller(
                  ProtoUtils.marshaller(ListDevicesResponse.getDefaultInstance()))
              .build();

  private static final MethodDescriptor<ExecuteDeviceCommandRequest, ExecuteDeviceCommandResponse>
      executeDeviceCommandMethodDescriptor =
          MethodDescriptor.<ExecuteDeviceCommandRequest, ExecuteDeviceCommandResponse>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(
                  "google.home.enterprise.sdm.v1.SmartDeviceManagementService/ExecuteDeviceCommand")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(ExecuteDeviceCommandRequest.getDefaultInstance()))
              .setResponseMarshaller(
                  ProtoUtils.marshaller(ExecuteDeviceCommandResponse.getDefaultInstance()))
              .build();

  private static final MethodDescriptor<GetStructureRequest, Structure>
      getStructureMethodDescriptor =
          MethodDescriptor.<GetStructureRequest, Structure>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(
                  "google.home.enterprise.sdm.v1.SmartDeviceManagementService/GetStructure")
              .setRequestMarshaller(ProtoUtils.marshaller(GetStructureRequest.getDefaultInstance()))
              .setResponseMarshaller(ProtoUtils.marshaller(Structure.getDefaultInstance()))
              .build();

  private static final MethodDescriptor<ListStructuresRequest, ListStructuresResponse>
      listStructuresMethodDescriptor =
          MethodDescriptor.<ListStructuresRequest, ListStructuresResponse>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(
                  "google.home.enterprise.sdm.v1.SmartDeviceManagementService/ListStructures")
              .setRequestMarshaller(
                  ProtoUtils.marshaller(ListStructuresRequest.getDefaultInstance()))
              .setResponseMarshaller(
                  ProtoUtils.marshaller(ListStructuresResponse.getDefaultInstance()))
              .build();

  private static final MethodDescriptor<GetRoomRequest, Room> getRoomMethodDescriptor =
      MethodDescriptor.<GetRoomRequest, Room>newBuilder()
          .setType(MethodDescriptor.MethodType.UNARY)
          .setFullMethodName("google.home.enterprise.sdm.v1.SmartDeviceManagementService/GetRoom")
          .setRequestMarshaller(ProtoUtils.marshaller(GetRoomRequest.getDefaultInstance()))
          .setResponseMarshaller(ProtoUtils.marshaller(Room.getDefaultInstance()))
          .build();

  private static final MethodDescriptor<ListRoomsRequest, ListRoomsResponse>
      listRoomsMethodDescriptor =
          MethodDescriptor.<ListRoomsRequest, ListRoomsResponse>newBuilder()
              .setType(MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(
                  "google.home.enterprise.sdm.v1.SmartDeviceManagementService/ListRooms")
              .setRequestMarshaller(ProtoUtils.marshaller(ListRoomsRequest.getDefaultInstance()))
              .setResponseMarshaller(ProtoUtils.marshaller(ListRoomsResponse.getDefaultInstance()))
              .build();

  private final UnaryCallable<GetDeviceRequest, Device> getDeviceCallable;
  private final UnaryCallable<ListDevicesRequest, ListDevicesResponse> listDevicesCallable;
  private final UnaryCallable<ListDevicesRequest, ListDevicesPagedResponse>
      listDevicesPagedCallable;
  private final UnaryCallable<ExecuteDeviceCommandRequest, ExecuteDeviceCommandResponse>
      executeDeviceCommandCallable;
  private final UnaryCallable<GetStructureRequest, Structure> getStructureCallable;
  private final UnaryCallable<ListStructuresRequest, ListStructuresResponse> listStructuresCallable;
  private final UnaryCallable<ListStructuresRequest, ListStructuresPagedResponse>
      listStructuresPagedCallable;
  private final UnaryCallable<GetRoomRequest, Room> getRoomCallable;
  private final UnaryCallable<ListRoomsRequest, ListRoomsResponse> listRoomsCallable;
  private final UnaryCallable<ListRoomsRequest, ListRoomsPagedResponse> listRoomsPagedCallable;

  private final BackgroundResource backgroundResources;
  private final GrpcOperationsStub operationsStub;
  private final GrpcStubCallableFactory callableFactory;

  public static final GrpcSmartDeviceManagementServiceStub create(
      SmartDeviceManagementServiceStubSettings settings) throws IOException {
    return new GrpcSmartDeviceManagementServiceStub(settings, ClientContext.create(settings));
  }

  public static final GrpcSmartDeviceManagementServiceStub create(ClientContext clientContext)
      throws IOException {
    return new GrpcSmartDeviceManagementServiceStub(
        SmartDeviceManagementServiceStubSettings.newBuilder().build(), clientContext);
  }

  public static final GrpcSmartDeviceManagementServiceStub create(
      ClientContext clientContext, GrpcStubCallableFactory callableFactory) throws IOException {
    return new GrpcSmartDeviceManagementServiceStub(
        SmartDeviceManagementServiceStubSettings.newBuilder().build(),
        clientContext,
        callableFactory);
  }

  /**
   * Constructs an instance of GrpcSmartDeviceManagementServiceStub, using the given settings. This
   * is protected so that it is easy to make a subclass, but otherwise, the static factory methods
   * should be preferred.
   */
  protected GrpcSmartDeviceManagementServiceStub(
      SmartDeviceManagementServiceStubSettings settings, ClientContext clientContext)
      throws IOException {
    this(settings, clientContext, new GrpcSmartDeviceManagementServiceCallableFactory());
  }

  /**
   * Constructs an instance of GrpcSmartDeviceManagementServiceStub, using the given settings. This
   * is protected so that it is easy to make a subclass, but otherwise, the static factory methods
   * should be preferred.
   */
  protected GrpcSmartDeviceManagementServiceStub(
      SmartDeviceManagementServiceStubSettings settings,
      ClientContext clientContext,
      GrpcStubCallableFactory callableFactory)
      throws IOException {
    this.callableFactory = callableFactory;
    this.operationsStub = GrpcOperationsStub.create(clientContext, callableFactory);

    GrpcCallSettings<GetDeviceRequest, Device> getDeviceTransportSettings =
        GrpcCallSettings.<GetDeviceRequest, Device>newBuilder()
            .setMethodDescriptor(getDeviceMethodDescriptor)
            .setParamsExtractor(
                new RequestParamsExtractor<GetDeviceRequest>() {
                  @Override
                  public Map<String, String> extract(GetDeviceRequest request) {
                    ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                    params.put("name", String.valueOf(request.getName()));
                    return params.build();
                  }
                })
            .build();
    GrpcCallSettings<ListDevicesRequest, ListDevicesResponse> listDevicesTransportSettings =
        GrpcCallSettings.<ListDevicesRequest, ListDevicesResponse>newBuilder()
            .setMethodDescriptor(listDevicesMethodDescriptor)
            .setParamsExtractor(
                new RequestParamsExtractor<ListDevicesRequest>() {
                  @Override
                  public Map<String, String> extract(ListDevicesRequest request) {
                    ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                    params.put("parent", String.valueOf(request.getParent()));
                    return params.build();
                  }
                })
            .build();
    GrpcCallSettings<ExecuteDeviceCommandRequest, ExecuteDeviceCommandResponse>
        executeDeviceCommandTransportSettings =
            GrpcCallSettings.<ExecuteDeviceCommandRequest, ExecuteDeviceCommandResponse>newBuilder()
                .setMethodDescriptor(executeDeviceCommandMethodDescriptor)
                .setParamsExtractor(
                    new RequestParamsExtractor<ExecuteDeviceCommandRequest>() {
                      @Override
                      public Map<String, String> extract(ExecuteDeviceCommandRequest request) {
                        ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                        params.put("name", String.valueOf(request.getName()));
                        return params.build();
                      }
                    })
                .build();
    GrpcCallSettings<GetStructureRequest, Structure> getStructureTransportSettings =
        GrpcCallSettings.<GetStructureRequest, Structure>newBuilder()
            .setMethodDescriptor(getStructureMethodDescriptor)
            .setParamsExtractor(
                new RequestParamsExtractor<GetStructureRequest>() {
                  @Override
                  public Map<String, String> extract(GetStructureRequest request) {
                    ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                    params.put("name", String.valueOf(request.getName()));
                    return params.build();
                  }
                })
            .build();
    GrpcCallSettings<ListStructuresRequest, ListStructuresResponse>
        listStructuresTransportSettings =
            GrpcCallSettings.<ListStructuresRequest, ListStructuresResponse>newBuilder()
                .setMethodDescriptor(listStructuresMethodDescriptor)
                .setParamsExtractor(
                    new RequestParamsExtractor<ListStructuresRequest>() {
                      @Override
                      public Map<String, String> extract(ListStructuresRequest request) {
                        ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                        params.put("parent", String.valueOf(request.getParent()));
                        return params.build();
                      }
                    })
                .build();
    GrpcCallSettings<GetRoomRequest, Room> getRoomTransportSettings =
        GrpcCallSettings.<GetRoomRequest, Room>newBuilder()
            .setMethodDescriptor(getRoomMethodDescriptor)
            .setParamsExtractor(
                new RequestParamsExtractor<GetRoomRequest>() {
                  @Override
                  public Map<String, String> extract(GetRoomRequest request) {
                    ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                    params.put("name", String.valueOf(request.getName()));
                    return params.build();
                  }
                })
            .build();
    GrpcCallSettings<ListRoomsRequest, ListRoomsResponse> listRoomsTransportSettings =
        GrpcCallSettings.<ListRoomsRequest, ListRoomsResponse>newBuilder()
            .setMethodDescriptor(listRoomsMethodDescriptor)
            .setParamsExtractor(
                new RequestParamsExtractor<ListRoomsRequest>() {
                  @Override
                  public Map<String, String> extract(ListRoomsRequest request) {
                    ImmutableMap.Builder<String, String> params = ImmutableMap.builder();
                    params.put("parent", String.valueOf(request.getParent()));
                    return params.build();
                  }
                })
            .build();

    this.getDeviceCallable =
        callableFactory.createUnaryCallable(
            getDeviceTransportSettings, settings.getDeviceSettings(), clientContext);
    this.listDevicesCallable =
        callableFactory.createUnaryCallable(
            listDevicesTransportSettings, settings.listDevicesSettings(), clientContext);
    this.listDevicesPagedCallable =
        callableFactory.createPagedCallable(
            listDevicesTransportSettings, settings.listDevicesSettings(), clientContext);
    this.executeDeviceCommandCallable =
        callableFactory.createUnaryCallable(
            executeDeviceCommandTransportSettings,
            settings.executeDeviceCommandSettings(),
            clientContext);
    this.getStructureCallable =
        callableFactory.createUnaryCallable(
            getStructureTransportSettings, settings.getStructureSettings(), clientContext);
    this.listStructuresCallable =
        callableFactory.createUnaryCallable(
            listStructuresTransportSettings, settings.listStructuresSettings(), clientContext);
    this.listStructuresPagedCallable =
        callableFactory.createPagedCallable(
            listStructuresTransportSettings, settings.listStructuresSettings(), clientContext);
    this.getRoomCallable =
        callableFactory.createUnaryCallable(
            getRoomTransportSettings, settings.getRoomSettings(), clientContext);
    this.listRoomsCallable =
        callableFactory.createUnaryCallable(
            listRoomsTransportSettings, settings.listRoomsSettings(), clientContext);
    this.listRoomsPagedCallable =
        callableFactory.createPagedCallable(
            listRoomsTransportSettings, settings.listRoomsSettings(), clientContext);

    this.backgroundResources =
        new BackgroundResourceAggregation(clientContext.getBackgroundResources());
  }

  public GrpcOperationsStub getOperationsStub() {
    return operationsStub;
  }

  @Override
  public UnaryCallable<GetDeviceRequest, Device> getDeviceCallable() {
    return getDeviceCallable;
  }

  @Override
  public UnaryCallable<ListDevicesRequest, ListDevicesResponse> listDevicesCallable() {
    return listDevicesCallable;
  }

  @Override
  public UnaryCallable<ListDevicesRequest, ListDevicesPagedResponse> listDevicesPagedCallable() {
    return listDevicesPagedCallable;
  }

  @Override
  public UnaryCallable<ExecuteDeviceCommandRequest, ExecuteDeviceCommandResponse>
      executeDeviceCommandCallable() {
    return executeDeviceCommandCallable;
  }

  @Override
  public UnaryCallable<GetStructureRequest, Structure> getStructureCallable() {
    return getStructureCallable;
  }

  @Override
  public UnaryCallable<ListStructuresRequest, ListStructuresResponse> listStructuresCallable() {
    return listStructuresCallable;
  }

  @Override
  public UnaryCallable<ListStructuresRequest, ListStructuresPagedResponse>
      listStructuresPagedCallable() {
    return listStructuresPagedCallable;
  }

  @Override
  public UnaryCallable<GetRoomRequest, Room> getRoomCallable() {
    return getRoomCallable;
  }

  @Override
  public UnaryCallable<ListRoomsRequest, ListRoomsResponse> listRoomsCallable() {
    return listRoomsCallable;
  }

  @Override
  public UnaryCallable<ListRoomsRequest, ListRoomsPagedResponse> listRoomsPagedCallable() {
    return listRoomsPagedCallable;
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
