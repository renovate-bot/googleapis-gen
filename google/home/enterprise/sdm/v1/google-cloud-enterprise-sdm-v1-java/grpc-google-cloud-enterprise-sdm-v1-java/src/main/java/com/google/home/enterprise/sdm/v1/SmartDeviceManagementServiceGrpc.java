package com.google.home.enterprise.sdm.v1;

import static io.grpc.MethodDescriptor.generateFullMethodName;

/**
 * <pre>
 * A service that allows API consumers to provision and manage Google
 * Home structures and devices for enterprise use cases.
 * </pre>
 */
@javax.annotation.Generated(
    value = "by gRPC proto compiler",
    comments = "Source: google/home/enterprise/sdm/v1/smart_device_management_service.proto")
@io.grpc.stub.annotations.GrpcGenerated
public final class SmartDeviceManagementServiceGrpc {

  private SmartDeviceManagementServiceGrpc() {}

  public static final String SERVICE_NAME = "google.home.enterprise.sdm.v1.SmartDeviceManagementService";

  // Static method descriptors that strictly reflect the proto.
  private static volatile io.grpc.MethodDescriptor<com.google.home.enterprise.sdm.v1.GetDeviceRequest,
      com.google.home.enterprise.sdm.v1.Device> getGetDeviceMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "GetDevice",
      requestType = com.google.home.enterprise.sdm.v1.GetDeviceRequest.class,
      responseType = com.google.home.enterprise.sdm.v1.Device.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.home.enterprise.sdm.v1.GetDeviceRequest,
      com.google.home.enterprise.sdm.v1.Device> getGetDeviceMethod() {
    io.grpc.MethodDescriptor<com.google.home.enterprise.sdm.v1.GetDeviceRequest, com.google.home.enterprise.sdm.v1.Device> getGetDeviceMethod;
    if ((getGetDeviceMethod = SmartDeviceManagementServiceGrpc.getGetDeviceMethod) == null) {
      synchronized (SmartDeviceManagementServiceGrpc.class) {
        if ((getGetDeviceMethod = SmartDeviceManagementServiceGrpc.getGetDeviceMethod) == null) {
          SmartDeviceManagementServiceGrpc.getGetDeviceMethod = getGetDeviceMethod =
              io.grpc.MethodDescriptor.<com.google.home.enterprise.sdm.v1.GetDeviceRequest, com.google.home.enterprise.sdm.v1.Device>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "GetDevice"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.home.enterprise.sdm.v1.GetDeviceRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.home.enterprise.sdm.v1.Device.getDefaultInstance()))
              .setSchemaDescriptor(new SmartDeviceManagementServiceMethodDescriptorSupplier("GetDevice"))
              .build();
        }
      }
    }
    return getGetDeviceMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.home.enterprise.sdm.v1.ListDevicesRequest,
      com.google.home.enterprise.sdm.v1.ListDevicesResponse> getListDevicesMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "ListDevices",
      requestType = com.google.home.enterprise.sdm.v1.ListDevicesRequest.class,
      responseType = com.google.home.enterprise.sdm.v1.ListDevicesResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.home.enterprise.sdm.v1.ListDevicesRequest,
      com.google.home.enterprise.sdm.v1.ListDevicesResponse> getListDevicesMethod() {
    io.grpc.MethodDescriptor<com.google.home.enterprise.sdm.v1.ListDevicesRequest, com.google.home.enterprise.sdm.v1.ListDevicesResponse> getListDevicesMethod;
    if ((getListDevicesMethod = SmartDeviceManagementServiceGrpc.getListDevicesMethod) == null) {
      synchronized (SmartDeviceManagementServiceGrpc.class) {
        if ((getListDevicesMethod = SmartDeviceManagementServiceGrpc.getListDevicesMethod) == null) {
          SmartDeviceManagementServiceGrpc.getListDevicesMethod = getListDevicesMethod =
              io.grpc.MethodDescriptor.<com.google.home.enterprise.sdm.v1.ListDevicesRequest, com.google.home.enterprise.sdm.v1.ListDevicesResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "ListDevices"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.home.enterprise.sdm.v1.ListDevicesRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.home.enterprise.sdm.v1.ListDevicesResponse.getDefaultInstance()))
              .setSchemaDescriptor(new SmartDeviceManagementServiceMethodDescriptorSupplier("ListDevices"))
              .build();
        }
      }
    }
    return getListDevicesMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandRequest,
      com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandResponse> getExecuteDeviceCommandMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "ExecuteDeviceCommand",
      requestType = com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandRequest.class,
      responseType = com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandRequest,
      com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandResponse> getExecuteDeviceCommandMethod() {
    io.grpc.MethodDescriptor<com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandRequest, com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandResponse> getExecuteDeviceCommandMethod;
    if ((getExecuteDeviceCommandMethod = SmartDeviceManagementServiceGrpc.getExecuteDeviceCommandMethod) == null) {
      synchronized (SmartDeviceManagementServiceGrpc.class) {
        if ((getExecuteDeviceCommandMethod = SmartDeviceManagementServiceGrpc.getExecuteDeviceCommandMethod) == null) {
          SmartDeviceManagementServiceGrpc.getExecuteDeviceCommandMethod = getExecuteDeviceCommandMethod =
              io.grpc.MethodDescriptor.<com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandRequest, com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "ExecuteDeviceCommand"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandResponse.getDefaultInstance()))
              .setSchemaDescriptor(new SmartDeviceManagementServiceMethodDescriptorSupplier("ExecuteDeviceCommand"))
              .build();
        }
      }
    }
    return getExecuteDeviceCommandMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.home.enterprise.sdm.v1.GetStructureRequest,
      com.google.home.enterprise.sdm.v1.Structure> getGetStructureMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "GetStructure",
      requestType = com.google.home.enterprise.sdm.v1.GetStructureRequest.class,
      responseType = com.google.home.enterprise.sdm.v1.Structure.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.home.enterprise.sdm.v1.GetStructureRequest,
      com.google.home.enterprise.sdm.v1.Structure> getGetStructureMethod() {
    io.grpc.MethodDescriptor<com.google.home.enterprise.sdm.v1.GetStructureRequest, com.google.home.enterprise.sdm.v1.Structure> getGetStructureMethod;
    if ((getGetStructureMethod = SmartDeviceManagementServiceGrpc.getGetStructureMethod) == null) {
      synchronized (SmartDeviceManagementServiceGrpc.class) {
        if ((getGetStructureMethod = SmartDeviceManagementServiceGrpc.getGetStructureMethod) == null) {
          SmartDeviceManagementServiceGrpc.getGetStructureMethod = getGetStructureMethod =
              io.grpc.MethodDescriptor.<com.google.home.enterprise.sdm.v1.GetStructureRequest, com.google.home.enterprise.sdm.v1.Structure>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "GetStructure"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.home.enterprise.sdm.v1.GetStructureRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.home.enterprise.sdm.v1.Structure.getDefaultInstance()))
              .setSchemaDescriptor(new SmartDeviceManagementServiceMethodDescriptorSupplier("GetStructure"))
              .build();
        }
      }
    }
    return getGetStructureMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.home.enterprise.sdm.v1.ListStructuresRequest,
      com.google.home.enterprise.sdm.v1.ListStructuresResponse> getListStructuresMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "ListStructures",
      requestType = com.google.home.enterprise.sdm.v1.ListStructuresRequest.class,
      responseType = com.google.home.enterprise.sdm.v1.ListStructuresResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.home.enterprise.sdm.v1.ListStructuresRequest,
      com.google.home.enterprise.sdm.v1.ListStructuresResponse> getListStructuresMethod() {
    io.grpc.MethodDescriptor<com.google.home.enterprise.sdm.v1.ListStructuresRequest, com.google.home.enterprise.sdm.v1.ListStructuresResponse> getListStructuresMethod;
    if ((getListStructuresMethod = SmartDeviceManagementServiceGrpc.getListStructuresMethod) == null) {
      synchronized (SmartDeviceManagementServiceGrpc.class) {
        if ((getListStructuresMethod = SmartDeviceManagementServiceGrpc.getListStructuresMethod) == null) {
          SmartDeviceManagementServiceGrpc.getListStructuresMethod = getListStructuresMethod =
              io.grpc.MethodDescriptor.<com.google.home.enterprise.sdm.v1.ListStructuresRequest, com.google.home.enterprise.sdm.v1.ListStructuresResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "ListStructures"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.home.enterprise.sdm.v1.ListStructuresRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.home.enterprise.sdm.v1.ListStructuresResponse.getDefaultInstance()))
              .setSchemaDescriptor(new SmartDeviceManagementServiceMethodDescriptorSupplier("ListStructures"))
              .build();
        }
      }
    }
    return getListStructuresMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.home.enterprise.sdm.v1.GetRoomRequest,
      com.google.home.enterprise.sdm.v1.Room> getGetRoomMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "GetRoom",
      requestType = com.google.home.enterprise.sdm.v1.GetRoomRequest.class,
      responseType = com.google.home.enterprise.sdm.v1.Room.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.home.enterprise.sdm.v1.GetRoomRequest,
      com.google.home.enterprise.sdm.v1.Room> getGetRoomMethod() {
    io.grpc.MethodDescriptor<com.google.home.enterprise.sdm.v1.GetRoomRequest, com.google.home.enterprise.sdm.v1.Room> getGetRoomMethod;
    if ((getGetRoomMethod = SmartDeviceManagementServiceGrpc.getGetRoomMethod) == null) {
      synchronized (SmartDeviceManagementServiceGrpc.class) {
        if ((getGetRoomMethod = SmartDeviceManagementServiceGrpc.getGetRoomMethod) == null) {
          SmartDeviceManagementServiceGrpc.getGetRoomMethod = getGetRoomMethod =
              io.grpc.MethodDescriptor.<com.google.home.enterprise.sdm.v1.GetRoomRequest, com.google.home.enterprise.sdm.v1.Room>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "GetRoom"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.home.enterprise.sdm.v1.GetRoomRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.home.enterprise.sdm.v1.Room.getDefaultInstance()))
              .setSchemaDescriptor(new SmartDeviceManagementServiceMethodDescriptorSupplier("GetRoom"))
              .build();
        }
      }
    }
    return getGetRoomMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.home.enterprise.sdm.v1.ListRoomsRequest,
      com.google.home.enterprise.sdm.v1.ListRoomsResponse> getListRoomsMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "ListRooms",
      requestType = com.google.home.enterprise.sdm.v1.ListRoomsRequest.class,
      responseType = com.google.home.enterprise.sdm.v1.ListRoomsResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.home.enterprise.sdm.v1.ListRoomsRequest,
      com.google.home.enterprise.sdm.v1.ListRoomsResponse> getListRoomsMethod() {
    io.grpc.MethodDescriptor<com.google.home.enterprise.sdm.v1.ListRoomsRequest, com.google.home.enterprise.sdm.v1.ListRoomsResponse> getListRoomsMethod;
    if ((getListRoomsMethod = SmartDeviceManagementServiceGrpc.getListRoomsMethod) == null) {
      synchronized (SmartDeviceManagementServiceGrpc.class) {
        if ((getListRoomsMethod = SmartDeviceManagementServiceGrpc.getListRoomsMethod) == null) {
          SmartDeviceManagementServiceGrpc.getListRoomsMethod = getListRoomsMethod =
              io.grpc.MethodDescriptor.<com.google.home.enterprise.sdm.v1.ListRoomsRequest, com.google.home.enterprise.sdm.v1.ListRoomsResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "ListRooms"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.home.enterprise.sdm.v1.ListRoomsRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.home.enterprise.sdm.v1.ListRoomsResponse.getDefaultInstance()))
              .setSchemaDescriptor(new SmartDeviceManagementServiceMethodDescriptorSupplier("ListRooms"))
              .build();
        }
      }
    }
    return getListRoomsMethod;
  }

  /**
   * Creates a new async stub that supports all call types for the service
   */
  public static SmartDeviceManagementServiceStub newStub(io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<SmartDeviceManagementServiceStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<SmartDeviceManagementServiceStub>() {
        @java.lang.Override
        public SmartDeviceManagementServiceStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new SmartDeviceManagementServiceStub(channel, callOptions);
        }
      };
    return SmartDeviceManagementServiceStub.newStub(factory, channel);
  }

  /**
   * Creates a new blocking-style stub that supports unary and streaming output calls on the service
   */
  public static SmartDeviceManagementServiceBlockingStub newBlockingStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<SmartDeviceManagementServiceBlockingStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<SmartDeviceManagementServiceBlockingStub>() {
        @java.lang.Override
        public SmartDeviceManagementServiceBlockingStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new SmartDeviceManagementServiceBlockingStub(channel, callOptions);
        }
      };
    return SmartDeviceManagementServiceBlockingStub.newStub(factory, channel);
  }

  /**
   * Creates a new ListenableFuture-style stub that supports unary calls on the service
   */
  public static SmartDeviceManagementServiceFutureStub newFutureStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<SmartDeviceManagementServiceFutureStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<SmartDeviceManagementServiceFutureStub>() {
        @java.lang.Override
        public SmartDeviceManagementServiceFutureStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new SmartDeviceManagementServiceFutureStub(channel, callOptions);
        }
      };
    return SmartDeviceManagementServiceFutureStub.newStub(factory, channel);
  }

  /**
   * <pre>
   * A service that allows API consumers to provision and manage Google
   * Home structures and devices for enterprise use cases.
   * </pre>
   */
  public static abstract class SmartDeviceManagementServiceImplBase implements io.grpc.BindableService {

    /**
     * <pre>
     * Gets a device managed by the enterprise.
     * </pre>
     */
    public void getDevice(com.google.home.enterprise.sdm.v1.GetDeviceRequest request,
        io.grpc.stub.StreamObserver<com.google.home.enterprise.sdm.v1.Device> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getGetDeviceMethod(), responseObserver);
    }

    /**
     * <pre>
     * Lists devices managed by the enterprise.
     * </pre>
     */
    public void listDevices(com.google.home.enterprise.sdm.v1.ListDevicesRequest request,
        io.grpc.stub.StreamObserver<com.google.home.enterprise.sdm.v1.ListDevicesResponse> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getListDevicesMethod(), responseObserver);
    }

    /**
     * <pre>
     * Executes a command to device managed by the enterprise.
     * </pre>
     */
    public void executeDeviceCommand(com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandRequest request,
        io.grpc.stub.StreamObserver<com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandResponse> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getExecuteDeviceCommandMethod(), responseObserver);
    }

    /**
     * <pre>
     * Gets a structure managed by the enterprise.
     * </pre>
     */
    public void getStructure(com.google.home.enterprise.sdm.v1.GetStructureRequest request,
        io.grpc.stub.StreamObserver<com.google.home.enterprise.sdm.v1.Structure> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getGetStructureMethod(), responseObserver);
    }

    /**
     * <pre>
     * Lists structures managed by the enterprise.
     * </pre>
     */
    public void listStructures(com.google.home.enterprise.sdm.v1.ListStructuresRequest request,
        io.grpc.stub.StreamObserver<com.google.home.enterprise.sdm.v1.ListStructuresResponse> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getListStructuresMethod(), responseObserver);
    }

    /**
     * <pre>
     * Gets a room managed by the enterprise.
     * </pre>
     */
    public void getRoom(com.google.home.enterprise.sdm.v1.GetRoomRequest request,
        io.grpc.stub.StreamObserver<com.google.home.enterprise.sdm.v1.Room> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getGetRoomMethod(), responseObserver);
    }

    /**
     * <pre>
     * Lists rooms managed by the enterprise.
     * </pre>
     */
    public void listRooms(com.google.home.enterprise.sdm.v1.ListRoomsRequest request,
        io.grpc.stub.StreamObserver<com.google.home.enterprise.sdm.v1.ListRoomsResponse> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getListRoomsMethod(), responseObserver);
    }

    @java.lang.Override public final io.grpc.ServerServiceDefinition bindService() {
      return io.grpc.ServerServiceDefinition.builder(getServiceDescriptor())
          .addMethod(
            getGetDeviceMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.home.enterprise.sdm.v1.GetDeviceRequest,
                com.google.home.enterprise.sdm.v1.Device>(
                  this, METHODID_GET_DEVICE)))
          .addMethod(
            getListDevicesMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.home.enterprise.sdm.v1.ListDevicesRequest,
                com.google.home.enterprise.sdm.v1.ListDevicesResponse>(
                  this, METHODID_LIST_DEVICES)))
          .addMethod(
            getExecuteDeviceCommandMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandRequest,
                com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandResponse>(
                  this, METHODID_EXECUTE_DEVICE_COMMAND)))
          .addMethod(
            getGetStructureMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.home.enterprise.sdm.v1.GetStructureRequest,
                com.google.home.enterprise.sdm.v1.Structure>(
                  this, METHODID_GET_STRUCTURE)))
          .addMethod(
            getListStructuresMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.home.enterprise.sdm.v1.ListStructuresRequest,
                com.google.home.enterprise.sdm.v1.ListStructuresResponse>(
                  this, METHODID_LIST_STRUCTURES)))
          .addMethod(
            getGetRoomMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.home.enterprise.sdm.v1.GetRoomRequest,
                com.google.home.enterprise.sdm.v1.Room>(
                  this, METHODID_GET_ROOM)))
          .addMethod(
            getListRoomsMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.home.enterprise.sdm.v1.ListRoomsRequest,
                com.google.home.enterprise.sdm.v1.ListRoomsResponse>(
                  this, METHODID_LIST_ROOMS)))
          .build();
    }
  }

  /**
   * <pre>
   * A service that allows API consumers to provision and manage Google
   * Home structures and devices for enterprise use cases.
   * </pre>
   */
  public static final class SmartDeviceManagementServiceStub extends io.grpc.stub.AbstractAsyncStub<SmartDeviceManagementServiceStub> {
    private SmartDeviceManagementServiceStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected SmartDeviceManagementServiceStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new SmartDeviceManagementServiceStub(channel, callOptions);
    }

    /**
     * <pre>
     * Gets a device managed by the enterprise.
     * </pre>
     */
    public void getDevice(com.google.home.enterprise.sdm.v1.GetDeviceRequest request,
        io.grpc.stub.StreamObserver<com.google.home.enterprise.sdm.v1.Device> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getGetDeviceMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Lists devices managed by the enterprise.
     * </pre>
     */
    public void listDevices(com.google.home.enterprise.sdm.v1.ListDevicesRequest request,
        io.grpc.stub.StreamObserver<com.google.home.enterprise.sdm.v1.ListDevicesResponse> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getListDevicesMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Executes a command to device managed by the enterprise.
     * </pre>
     */
    public void executeDeviceCommand(com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandRequest request,
        io.grpc.stub.StreamObserver<com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandResponse> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getExecuteDeviceCommandMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Gets a structure managed by the enterprise.
     * </pre>
     */
    public void getStructure(com.google.home.enterprise.sdm.v1.GetStructureRequest request,
        io.grpc.stub.StreamObserver<com.google.home.enterprise.sdm.v1.Structure> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getGetStructureMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Lists structures managed by the enterprise.
     * </pre>
     */
    public void listStructures(com.google.home.enterprise.sdm.v1.ListStructuresRequest request,
        io.grpc.stub.StreamObserver<com.google.home.enterprise.sdm.v1.ListStructuresResponse> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getListStructuresMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Gets a room managed by the enterprise.
     * </pre>
     */
    public void getRoom(com.google.home.enterprise.sdm.v1.GetRoomRequest request,
        io.grpc.stub.StreamObserver<com.google.home.enterprise.sdm.v1.Room> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getGetRoomMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Lists rooms managed by the enterprise.
     * </pre>
     */
    public void listRooms(com.google.home.enterprise.sdm.v1.ListRoomsRequest request,
        io.grpc.stub.StreamObserver<com.google.home.enterprise.sdm.v1.ListRoomsResponse> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getListRoomsMethod(), getCallOptions()), request, responseObserver);
    }
  }

  /**
   * <pre>
   * A service that allows API consumers to provision and manage Google
   * Home structures and devices for enterprise use cases.
   * </pre>
   */
  public static final class SmartDeviceManagementServiceBlockingStub extends io.grpc.stub.AbstractBlockingStub<SmartDeviceManagementServiceBlockingStub> {
    private SmartDeviceManagementServiceBlockingStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected SmartDeviceManagementServiceBlockingStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new SmartDeviceManagementServiceBlockingStub(channel, callOptions);
    }

    /**
     * <pre>
     * Gets a device managed by the enterprise.
     * </pre>
     */
    public com.google.home.enterprise.sdm.v1.Device getDevice(com.google.home.enterprise.sdm.v1.GetDeviceRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getGetDeviceMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Lists devices managed by the enterprise.
     * </pre>
     */
    public com.google.home.enterprise.sdm.v1.ListDevicesResponse listDevices(com.google.home.enterprise.sdm.v1.ListDevicesRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getListDevicesMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Executes a command to device managed by the enterprise.
     * </pre>
     */
    public com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandResponse executeDeviceCommand(com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getExecuteDeviceCommandMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Gets a structure managed by the enterprise.
     * </pre>
     */
    public com.google.home.enterprise.sdm.v1.Structure getStructure(com.google.home.enterprise.sdm.v1.GetStructureRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getGetStructureMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Lists structures managed by the enterprise.
     * </pre>
     */
    public com.google.home.enterprise.sdm.v1.ListStructuresResponse listStructures(com.google.home.enterprise.sdm.v1.ListStructuresRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getListStructuresMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Gets a room managed by the enterprise.
     * </pre>
     */
    public com.google.home.enterprise.sdm.v1.Room getRoom(com.google.home.enterprise.sdm.v1.GetRoomRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getGetRoomMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Lists rooms managed by the enterprise.
     * </pre>
     */
    public com.google.home.enterprise.sdm.v1.ListRoomsResponse listRooms(com.google.home.enterprise.sdm.v1.ListRoomsRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getListRoomsMethod(), getCallOptions(), request);
    }
  }

  /**
   * <pre>
   * A service that allows API consumers to provision and manage Google
   * Home structures and devices for enterprise use cases.
   * </pre>
   */
  public static final class SmartDeviceManagementServiceFutureStub extends io.grpc.stub.AbstractFutureStub<SmartDeviceManagementServiceFutureStub> {
    private SmartDeviceManagementServiceFutureStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected SmartDeviceManagementServiceFutureStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new SmartDeviceManagementServiceFutureStub(channel, callOptions);
    }

    /**
     * <pre>
     * Gets a device managed by the enterprise.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.home.enterprise.sdm.v1.Device> getDevice(
        com.google.home.enterprise.sdm.v1.GetDeviceRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getGetDeviceMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Lists devices managed by the enterprise.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.home.enterprise.sdm.v1.ListDevicesResponse> listDevices(
        com.google.home.enterprise.sdm.v1.ListDevicesRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getListDevicesMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Executes a command to device managed by the enterprise.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandResponse> executeDeviceCommand(
        com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getExecuteDeviceCommandMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Gets a structure managed by the enterprise.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.home.enterprise.sdm.v1.Structure> getStructure(
        com.google.home.enterprise.sdm.v1.GetStructureRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getGetStructureMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Lists structures managed by the enterprise.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.home.enterprise.sdm.v1.ListStructuresResponse> listStructures(
        com.google.home.enterprise.sdm.v1.ListStructuresRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getListStructuresMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Gets a room managed by the enterprise.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.home.enterprise.sdm.v1.Room> getRoom(
        com.google.home.enterprise.sdm.v1.GetRoomRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getGetRoomMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Lists rooms managed by the enterprise.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.home.enterprise.sdm.v1.ListRoomsResponse> listRooms(
        com.google.home.enterprise.sdm.v1.ListRoomsRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getListRoomsMethod(), getCallOptions()), request);
    }
  }

  private static final int METHODID_GET_DEVICE = 0;
  private static final int METHODID_LIST_DEVICES = 1;
  private static final int METHODID_EXECUTE_DEVICE_COMMAND = 2;
  private static final int METHODID_GET_STRUCTURE = 3;
  private static final int METHODID_LIST_STRUCTURES = 4;
  private static final int METHODID_GET_ROOM = 5;
  private static final int METHODID_LIST_ROOMS = 6;

  private static final class MethodHandlers<Req, Resp> implements
      io.grpc.stub.ServerCalls.UnaryMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ServerStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ClientStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.BidiStreamingMethod<Req, Resp> {
    private final SmartDeviceManagementServiceImplBase serviceImpl;
    private final int methodId;

    MethodHandlers(SmartDeviceManagementServiceImplBase serviceImpl, int methodId) {
      this.serviceImpl = serviceImpl;
      this.methodId = methodId;
    }

    @java.lang.Override
    @java.lang.SuppressWarnings("unchecked")
    public void invoke(Req request, io.grpc.stub.StreamObserver<Resp> responseObserver) {
      switch (methodId) {
        case METHODID_GET_DEVICE:
          serviceImpl.getDevice((com.google.home.enterprise.sdm.v1.GetDeviceRequest) request,
              (io.grpc.stub.StreamObserver<com.google.home.enterprise.sdm.v1.Device>) responseObserver);
          break;
        case METHODID_LIST_DEVICES:
          serviceImpl.listDevices((com.google.home.enterprise.sdm.v1.ListDevicesRequest) request,
              (io.grpc.stub.StreamObserver<com.google.home.enterprise.sdm.v1.ListDevicesResponse>) responseObserver);
          break;
        case METHODID_EXECUTE_DEVICE_COMMAND:
          serviceImpl.executeDeviceCommand((com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandRequest) request,
              (io.grpc.stub.StreamObserver<com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandResponse>) responseObserver);
          break;
        case METHODID_GET_STRUCTURE:
          serviceImpl.getStructure((com.google.home.enterprise.sdm.v1.GetStructureRequest) request,
              (io.grpc.stub.StreamObserver<com.google.home.enterprise.sdm.v1.Structure>) responseObserver);
          break;
        case METHODID_LIST_STRUCTURES:
          serviceImpl.listStructures((com.google.home.enterprise.sdm.v1.ListStructuresRequest) request,
              (io.grpc.stub.StreamObserver<com.google.home.enterprise.sdm.v1.ListStructuresResponse>) responseObserver);
          break;
        case METHODID_GET_ROOM:
          serviceImpl.getRoom((com.google.home.enterprise.sdm.v1.GetRoomRequest) request,
              (io.grpc.stub.StreamObserver<com.google.home.enterprise.sdm.v1.Room>) responseObserver);
          break;
        case METHODID_LIST_ROOMS:
          serviceImpl.listRooms((com.google.home.enterprise.sdm.v1.ListRoomsRequest) request,
              (io.grpc.stub.StreamObserver<com.google.home.enterprise.sdm.v1.ListRoomsResponse>) responseObserver);
          break;
        default:
          throw new AssertionError();
      }
    }

    @java.lang.Override
    @java.lang.SuppressWarnings("unchecked")
    public io.grpc.stub.StreamObserver<Req> invoke(
        io.grpc.stub.StreamObserver<Resp> responseObserver) {
      switch (methodId) {
        default:
          throw new AssertionError();
      }
    }
  }

  private static abstract class SmartDeviceManagementServiceBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoFileDescriptorSupplier, io.grpc.protobuf.ProtoServiceDescriptorSupplier {
    SmartDeviceManagementServiceBaseDescriptorSupplier() {}

    @java.lang.Override
    public com.google.protobuf.Descriptors.FileDescriptor getFileDescriptor() {
      return com.google.home.enterprise.sdm.v1.SmartDeviceManagementServiceOuterClass.getDescriptor();
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.ServiceDescriptor getServiceDescriptor() {
      return getFileDescriptor().findServiceByName("SmartDeviceManagementService");
    }
  }

  private static final class SmartDeviceManagementServiceFileDescriptorSupplier
      extends SmartDeviceManagementServiceBaseDescriptorSupplier {
    SmartDeviceManagementServiceFileDescriptorSupplier() {}
  }

  private static final class SmartDeviceManagementServiceMethodDescriptorSupplier
      extends SmartDeviceManagementServiceBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoMethodDescriptorSupplier {
    private final String methodName;

    SmartDeviceManagementServiceMethodDescriptorSupplier(String methodName) {
      this.methodName = methodName;
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.MethodDescriptor getMethodDescriptor() {
      return getServiceDescriptor().findMethodByName(methodName);
    }
  }

  private static volatile io.grpc.ServiceDescriptor serviceDescriptor;

  public static io.grpc.ServiceDescriptor getServiceDescriptor() {
    io.grpc.ServiceDescriptor result = serviceDescriptor;
    if (result == null) {
      synchronized (SmartDeviceManagementServiceGrpc.class) {
        result = serviceDescriptor;
        if (result == null) {
          serviceDescriptor = result = io.grpc.ServiceDescriptor.newBuilder(SERVICE_NAME)
              .setSchemaDescriptor(new SmartDeviceManagementServiceFileDescriptorSupplier())
              .addMethod(getGetDeviceMethod())
              .addMethod(getListDevicesMethod())
              .addMethod(getExecuteDeviceCommandMethod())
              .addMethod(getGetStructureMethod())
              .addMethod(getListStructuresMethod())
              .addMethod(getGetRoomMethod())
              .addMethod(getListRoomsMethod())
              .build();
        }
      }
    }
    return result;
  }
}
