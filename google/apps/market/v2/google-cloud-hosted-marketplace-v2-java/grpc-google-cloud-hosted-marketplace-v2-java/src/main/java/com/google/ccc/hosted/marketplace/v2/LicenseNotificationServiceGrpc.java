package com.google.ccc.hosted.marketplace.v2;

import static io.grpc.MethodDescriptor.generateFullMethodName;

/**
 */
@javax.annotation.Generated(
    value = "by gRPC proto compiler",
    comments = "Source: google/apps/market/v2/services.proto")
@io.grpc.stub.annotations.GrpcGenerated
public final class LicenseNotificationServiceGrpc {

  private LicenseNotificationServiceGrpc() {}

  public static final String SERVICE_NAME = "ccc.hosted.marketplace.v2.LicenseNotificationService";

  // Static method descriptors that strictly reflect the proto.
  private static volatile io.grpc.MethodDescriptor<com.google.ccc.hosted.marketplace.v2.LicenseNotificationListRequest,
      com.google.ccc.hosted.marketplace.v2.LicenseNotificationList> getListMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "List",
      requestType = com.google.ccc.hosted.marketplace.v2.LicenseNotificationListRequest.class,
      responseType = com.google.ccc.hosted.marketplace.v2.LicenseNotificationList.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.ccc.hosted.marketplace.v2.LicenseNotificationListRequest,
      com.google.ccc.hosted.marketplace.v2.LicenseNotificationList> getListMethod() {
    io.grpc.MethodDescriptor<com.google.ccc.hosted.marketplace.v2.LicenseNotificationListRequest, com.google.ccc.hosted.marketplace.v2.LicenseNotificationList> getListMethod;
    if ((getListMethod = LicenseNotificationServiceGrpc.getListMethod) == null) {
      synchronized (LicenseNotificationServiceGrpc.class) {
        if ((getListMethod = LicenseNotificationServiceGrpc.getListMethod) == null) {
          LicenseNotificationServiceGrpc.getListMethod = getListMethod =
              io.grpc.MethodDescriptor.<com.google.ccc.hosted.marketplace.v2.LicenseNotificationListRequest, com.google.ccc.hosted.marketplace.v2.LicenseNotificationList>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "List"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.ccc.hosted.marketplace.v2.LicenseNotificationListRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.ccc.hosted.marketplace.v2.LicenseNotificationList.getDefaultInstance()))
              .setSchemaDescriptor(new LicenseNotificationServiceMethodDescriptorSupplier("List"))
              .build();
        }
      }
    }
    return getListMethod;
  }

  /**
   * Creates a new async stub that supports all call types for the service
   */
  public static LicenseNotificationServiceStub newStub(io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<LicenseNotificationServiceStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<LicenseNotificationServiceStub>() {
        @java.lang.Override
        public LicenseNotificationServiceStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new LicenseNotificationServiceStub(channel, callOptions);
        }
      };
    return LicenseNotificationServiceStub.newStub(factory, channel);
  }

  /**
   * Creates a new blocking-style stub that supports unary and streaming output calls on the service
   */
  public static LicenseNotificationServiceBlockingStub newBlockingStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<LicenseNotificationServiceBlockingStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<LicenseNotificationServiceBlockingStub>() {
        @java.lang.Override
        public LicenseNotificationServiceBlockingStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new LicenseNotificationServiceBlockingStub(channel, callOptions);
        }
      };
    return LicenseNotificationServiceBlockingStub.newStub(factory, channel);
  }

  /**
   * Creates a new ListenableFuture-style stub that supports unary calls on the service
   */
  public static LicenseNotificationServiceFutureStub newFutureStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<LicenseNotificationServiceFutureStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<LicenseNotificationServiceFutureStub>() {
        @java.lang.Override
        public LicenseNotificationServiceFutureStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new LicenseNotificationServiceFutureStub(channel, callOptions);
        }
      };
    return LicenseNotificationServiceFutureStub.newStub(factory, channel);
  }

  /**
   */
  public static abstract class LicenseNotificationServiceImplBase implements io.grpc.BindableService {

    /**
     * <pre>
     * Get a list of licensing notifications with regards to a given app.
     * </pre>
     */
    public void list(com.google.ccc.hosted.marketplace.v2.LicenseNotificationListRequest request,
        io.grpc.stub.StreamObserver<com.google.ccc.hosted.marketplace.v2.LicenseNotificationList> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getListMethod(), responseObserver);
    }

    @java.lang.Override public final io.grpc.ServerServiceDefinition bindService() {
      return io.grpc.ServerServiceDefinition.builder(getServiceDescriptor())
          .addMethod(
            getListMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.ccc.hosted.marketplace.v2.LicenseNotificationListRequest,
                com.google.ccc.hosted.marketplace.v2.LicenseNotificationList>(
                  this, METHODID_LIST)))
          .build();
    }
  }

  /**
   */
  public static final class LicenseNotificationServiceStub extends io.grpc.stub.AbstractAsyncStub<LicenseNotificationServiceStub> {
    private LicenseNotificationServiceStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected LicenseNotificationServiceStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new LicenseNotificationServiceStub(channel, callOptions);
    }

    /**
     * <pre>
     * Get a list of licensing notifications with regards to a given app.
     * </pre>
     */
    public void list(com.google.ccc.hosted.marketplace.v2.LicenseNotificationListRequest request,
        io.grpc.stub.StreamObserver<com.google.ccc.hosted.marketplace.v2.LicenseNotificationList> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getListMethod(), getCallOptions()), request, responseObserver);
    }
  }

  /**
   */
  public static final class LicenseNotificationServiceBlockingStub extends io.grpc.stub.AbstractBlockingStub<LicenseNotificationServiceBlockingStub> {
    private LicenseNotificationServiceBlockingStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected LicenseNotificationServiceBlockingStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new LicenseNotificationServiceBlockingStub(channel, callOptions);
    }

    /**
     * <pre>
     * Get a list of licensing notifications with regards to a given app.
     * </pre>
     */
    public com.google.ccc.hosted.marketplace.v2.LicenseNotificationList list(com.google.ccc.hosted.marketplace.v2.LicenseNotificationListRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getListMethod(), getCallOptions(), request);
    }
  }

  /**
   */
  public static final class LicenseNotificationServiceFutureStub extends io.grpc.stub.AbstractFutureStub<LicenseNotificationServiceFutureStub> {
    private LicenseNotificationServiceFutureStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected LicenseNotificationServiceFutureStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new LicenseNotificationServiceFutureStub(channel, callOptions);
    }

    /**
     * <pre>
     * Get a list of licensing notifications with regards to a given app.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.ccc.hosted.marketplace.v2.LicenseNotificationList> list(
        com.google.ccc.hosted.marketplace.v2.LicenseNotificationListRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getListMethod(), getCallOptions()), request);
    }
  }

  private static final int METHODID_LIST = 0;

  private static final class MethodHandlers<Req, Resp> implements
      io.grpc.stub.ServerCalls.UnaryMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ServerStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ClientStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.BidiStreamingMethod<Req, Resp> {
    private final LicenseNotificationServiceImplBase serviceImpl;
    private final int methodId;

    MethodHandlers(LicenseNotificationServiceImplBase serviceImpl, int methodId) {
      this.serviceImpl = serviceImpl;
      this.methodId = methodId;
    }

    @java.lang.Override
    @java.lang.SuppressWarnings("unchecked")
    public void invoke(Req request, io.grpc.stub.StreamObserver<Resp> responseObserver) {
      switch (methodId) {
        case METHODID_LIST:
          serviceImpl.list((com.google.ccc.hosted.marketplace.v2.LicenseNotificationListRequest) request,
              (io.grpc.stub.StreamObserver<com.google.ccc.hosted.marketplace.v2.LicenseNotificationList>) responseObserver);
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

  private static abstract class LicenseNotificationServiceBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoFileDescriptorSupplier, io.grpc.protobuf.ProtoServiceDescriptorSupplier {
    LicenseNotificationServiceBaseDescriptorSupplier() {}

    @java.lang.Override
    public com.google.protobuf.Descriptors.FileDescriptor getFileDescriptor() {
      return com.google.ccc.hosted.marketplace.v2.ServiceProto.getDescriptor();
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.ServiceDescriptor getServiceDescriptor() {
      return getFileDescriptor().findServiceByName("LicenseNotificationService");
    }
  }

  private static final class LicenseNotificationServiceFileDescriptorSupplier
      extends LicenseNotificationServiceBaseDescriptorSupplier {
    LicenseNotificationServiceFileDescriptorSupplier() {}
  }

  private static final class LicenseNotificationServiceMethodDescriptorSupplier
      extends LicenseNotificationServiceBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoMethodDescriptorSupplier {
    private final String methodName;

    LicenseNotificationServiceMethodDescriptorSupplier(String methodName) {
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
      synchronized (LicenseNotificationServiceGrpc.class) {
        result = serviceDescriptor;
        if (result == null) {
          serviceDescriptor = result = io.grpc.ServiceDescriptor.newBuilder(SERVICE_NAME)
              .setSchemaDescriptor(new LicenseNotificationServiceFileDescriptorSupplier())
              .addMethod(getListMethod())
              .build();
        }
      }
    }
    return result;
  }
}
