package com.google.chromeos.uidetection.v1;

import static io.grpc.MethodDescriptor.generateFullMethodName;

/**
 * <pre>
 * Provides image-based UI detection service.
 * </pre>
 */
@javax.annotation.Generated(
    value = "by gRPC proto compiler",
    comments = "Source: google/chromeos/uidetection/v1/ui_detection.proto")
@io.grpc.stub.annotations.GrpcGenerated
public final class UiDetectionServiceGrpc {

  private UiDetectionServiceGrpc() {}

  public static final String SERVICE_NAME = "google.chromeos.uidetection.v1.UiDetectionService";

  // Static method descriptors that strictly reflect the proto.
  private static volatile io.grpc.MethodDescriptor<com.google.chromeos.uidetection.v1.UiDetectionRequest,
      com.google.chromeos.uidetection.v1.UiDetectionResponse> getExecuteDetectionMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "ExecuteDetection",
      requestType = com.google.chromeos.uidetection.v1.UiDetectionRequest.class,
      responseType = com.google.chromeos.uidetection.v1.UiDetectionResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.chromeos.uidetection.v1.UiDetectionRequest,
      com.google.chromeos.uidetection.v1.UiDetectionResponse> getExecuteDetectionMethod() {
    io.grpc.MethodDescriptor<com.google.chromeos.uidetection.v1.UiDetectionRequest, com.google.chromeos.uidetection.v1.UiDetectionResponse> getExecuteDetectionMethod;
    if ((getExecuteDetectionMethod = UiDetectionServiceGrpc.getExecuteDetectionMethod) == null) {
      synchronized (UiDetectionServiceGrpc.class) {
        if ((getExecuteDetectionMethod = UiDetectionServiceGrpc.getExecuteDetectionMethod) == null) {
          UiDetectionServiceGrpc.getExecuteDetectionMethod = getExecuteDetectionMethod =
              io.grpc.MethodDescriptor.<com.google.chromeos.uidetection.v1.UiDetectionRequest, com.google.chromeos.uidetection.v1.UiDetectionResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "ExecuteDetection"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.chromeos.uidetection.v1.UiDetectionRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.chromeos.uidetection.v1.UiDetectionResponse.getDefaultInstance()))
              .setSchemaDescriptor(new UiDetectionServiceMethodDescriptorSupplier("ExecuteDetection"))
              .build();
        }
      }
    }
    return getExecuteDetectionMethod;
  }

  /**
   * Creates a new async stub that supports all call types for the service
   */
  public static UiDetectionServiceStub newStub(io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<UiDetectionServiceStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<UiDetectionServiceStub>() {
        @java.lang.Override
        public UiDetectionServiceStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new UiDetectionServiceStub(channel, callOptions);
        }
      };
    return UiDetectionServiceStub.newStub(factory, channel);
  }

  /**
   * Creates a new blocking-style stub that supports unary and streaming output calls on the service
   */
  public static UiDetectionServiceBlockingStub newBlockingStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<UiDetectionServiceBlockingStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<UiDetectionServiceBlockingStub>() {
        @java.lang.Override
        public UiDetectionServiceBlockingStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new UiDetectionServiceBlockingStub(channel, callOptions);
        }
      };
    return UiDetectionServiceBlockingStub.newStub(factory, channel);
  }

  /**
   * Creates a new ListenableFuture-style stub that supports unary calls on the service
   */
  public static UiDetectionServiceFutureStub newFutureStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<UiDetectionServiceFutureStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<UiDetectionServiceFutureStub>() {
        @java.lang.Override
        public UiDetectionServiceFutureStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new UiDetectionServiceFutureStub(channel, callOptions);
        }
      };
    return UiDetectionServiceFutureStub.newStub(factory, channel);
  }

  /**
   * <pre>
   * Provides image-based UI detection service.
   * </pre>
   */
  public static abstract class UiDetectionServiceImplBase implements io.grpc.BindableService {

    /**
     * <pre>
     * Runs the detection.
     * </pre>
     */
    public void executeDetection(com.google.chromeos.uidetection.v1.UiDetectionRequest request,
        io.grpc.stub.StreamObserver<com.google.chromeos.uidetection.v1.UiDetectionResponse> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getExecuteDetectionMethod(), responseObserver);
    }

    @java.lang.Override public final io.grpc.ServerServiceDefinition bindService() {
      return io.grpc.ServerServiceDefinition.builder(getServiceDescriptor())
          .addMethod(
            getExecuteDetectionMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.chromeos.uidetection.v1.UiDetectionRequest,
                com.google.chromeos.uidetection.v1.UiDetectionResponse>(
                  this, METHODID_EXECUTE_DETECTION)))
          .build();
    }
  }

  /**
   * <pre>
   * Provides image-based UI detection service.
   * </pre>
   */
  public static final class UiDetectionServiceStub extends io.grpc.stub.AbstractAsyncStub<UiDetectionServiceStub> {
    private UiDetectionServiceStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected UiDetectionServiceStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new UiDetectionServiceStub(channel, callOptions);
    }

    /**
     * <pre>
     * Runs the detection.
     * </pre>
     */
    public void executeDetection(com.google.chromeos.uidetection.v1.UiDetectionRequest request,
        io.grpc.stub.StreamObserver<com.google.chromeos.uidetection.v1.UiDetectionResponse> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getExecuteDetectionMethod(), getCallOptions()), request, responseObserver);
    }
  }

  /**
   * <pre>
   * Provides image-based UI detection service.
   * </pre>
   */
  public static final class UiDetectionServiceBlockingStub extends io.grpc.stub.AbstractBlockingStub<UiDetectionServiceBlockingStub> {
    private UiDetectionServiceBlockingStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected UiDetectionServiceBlockingStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new UiDetectionServiceBlockingStub(channel, callOptions);
    }

    /**
     * <pre>
     * Runs the detection.
     * </pre>
     */
    public com.google.chromeos.uidetection.v1.UiDetectionResponse executeDetection(com.google.chromeos.uidetection.v1.UiDetectionRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getExecuteDetectionMethod(), getCallOptions(), request);
    }
  }

  /**
   * <pre>
   * Provides image-based UI detection service.
   * </pre>
   */
  public static final class UiDetectionServiceFutureStub extends io.grpc.stub.AbstractFutureStub<UiDetectionServiceFutureStub> {
    private UiDetectionServiceFutureStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected UiDetectionServiceFutureStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new UiDetectionServiceFutureStub(channel, callOptions);
    }

    /**
     * <pre>
     * Runs the detection.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.chromeos.uidetection.v1.UiDetectionResponse> executeDetection(
        com.google.chromeos.uidetection.v1.UiDetectionRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getExecuteDetectionMethod(), getCallOptions()), request);
    }
  }

  private static final int METHODID_EXECUTE_DETECTION = 0;

  private static final class MethodHandlers<Req, Resp> implements
      io.grpc.stub.ServerCalls.UnaryMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ServerStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ClientStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.BidiStreamingMethod<Req, Resp> {
    private final UiDetectionServiceImplBase serviceImpl;
    private final int methodId;

    MethodHandlers(UiDetectionServiceImplBase serviceImpl, int methodId) {
      this.serviceImpl = serviceImpl;
      this.methodId = methodId;
    }

    @java.lang.Override
    @java.lang.SuppressWarnings("unchecked")
    public void invoke(Req request, io.grpc.stub.StreamObserver<Resp> responseObserver) {
      switch (methodId) {
        case METHODID_EXECUTE_DETECTION:
          serviceImpl.executeDetection((com.google.chromeos.uidetection.v1.UiDetectionRequest) request,
              (io.grpc.stub.StreamObserver<com.google.chromeos.uidetection.v1.UiDetectionResponse>) responseObserver);
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

  private static abstract class UiDetectionServiceBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoFileDescriptorSupplier, io.grpc.protobuf.ProtoServiceDescriptorSupplier {
    UiDetectionServiceBaseDescriptorSupplier() {}

    @java.lang.Override
    public com.google.protobuf.Descriptors.FileDescriptor getFileDescriptor() {
      return com.google.chromeos.uidetection.v1.UiDetectionProto.getDescriptor();
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.ServiceDescriptor getServiceDescriptor() {
      return getFileDescriptor().findServiceByName("UiDetectionService");
    }
  }

  private static final class UiDetectionServiceFileDescriptorSupplier
      extends UiDetectionServiceBaseDescriptorSupplier {
    UiDetectionServiceFileDescriptorSupplier() {}
  }

  private static final class UiDetectionServiceMethodDescriptorSupplier
      extends UiDetectionServiceBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoMethodDescriptorSupplier {
    private final String methodName;

    UiDetectionServiceMethodDescriptorSupplier(String methodName) {
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
      synchronized (UiDetectionServiceGrpc.class) {
        result = serviceDescriptor;
        if (result == null) {
          serviceDescriptor = result = io.grpc.ServiceDescriptor.newBuilder(SERVICE_NAME)
              .setSchemaDescriptor(new UiDetectionServiceFileDescriptorSupplier())
              .addMethod(getExecuteDetectionMethod())
              .build();
        }
      }
    }
    return result;
  }
}
