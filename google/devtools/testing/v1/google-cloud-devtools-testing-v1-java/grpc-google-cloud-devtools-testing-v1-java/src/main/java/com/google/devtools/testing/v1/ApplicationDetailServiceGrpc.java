package com.google.devtools.testing.v1;

import static io.grpc.MethodDescriptor.generateFullMethodName;

/**
 * <pre>
 * A service which parses input applications and returns details that can be
 * useful in the context of testing.
 * </pre>
 */
@javax.annotation.Generated(
    value = "by gRPC proto compiler",
    comments = "Source: google/devtools/testing/v1/application_details.proto")
@io.grpc.stub.annotations.GrpcGenerated
public final class ApplicationDetailServiceGrpc {

  private ApplicationDetailServiceGrpc() {}

  public static final String SERVICE_NAME = "google.devtools.testing.v1.ApplicationDetailService";

  // Static method descriptors that strictly reflect the proto.
  private static volatile io.grpc.MethodDescriptor<com.google.devtools.testing.v1.GetApkDetailsRequest,
      com.google.devtools.testing.v1.GetApkDetailsResponse> getGetApkDetailsMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "GetApkDetails",
      requestType = com.google.devtools.testing.v1.GetApkDetailsRequest.class,
      responseType = com.google.devtools.testing.v1.GetApkDetailsResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.devtools.testing.v1.GetApkDetailsRequest,
      com.google.devtools.testing.v1.GetApkDetailsResponse> getGetApkDetailsMethod() {
    io.grpc.MethodDescriptor<com.google.devtools.testing.v1.GetApkDetailsRequest, com.google.devtools.testing.v1.GetApkDetailsResponse> getGetApkDetailsMethod;
    if ((getGetApkDetailsMethod = ApplicationDetailServiceGrpc.getGetApkDetailsMethod) == null) {
      synchronized (ApplicationDetailServiceGrpc.class) {
        if ((getGetApkDetailsMethod = ApplicationDetailServiceGrpc.getGetApkDetailsMethod) == null) {
          ApplicationDetailServiceGrpc.getGetApkDetailsMethod = getGetApkDetailsMethod =
              io.grpc.MethodDescriptor.<com.google.devtools.testing.v1.GetApkDetailsRequest, com.google.devtools.testing.v1.GetApkDetailsResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "GetApkDetails"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.devtools.testing.v1.GetApkDetailsRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.devtools.testing.v1.GetApkDetailsResponse.getDefaultInstance()))
              .setSchemaDescriptor(new ApplicationDetailServiceMethodDescriptorSupplier("GetApkDetails"))
              .build();
        }
      }
    }
    return getGetApkDetailsMethod;
  }

  /**
   * Creates a new async stub that supports all call types for the service
   */
  public static ApplicationDetailServiceStub newStub(io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<ApplicationDetailServiceStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<ApplicationDetailServiceStub>() {
        @java.lang.Override
        public ApplicationDetailServiceStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new ApplicationDetailServiceStub(channel, callOptions);
        }
      };
    return ApplicationDetailServiceStub.newStub(factory, channel);
  }

  /**
   * Creates a new blocking-style stub that supports unary and streaming output calls on the service
   */
  public static ApplicationDetailServiceBlockingStub newBlockingStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<ApplicationDetailServiceBlockingStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<ApplicationDetailServiceBlockingStub>() {
        @java.lang.Override
        public ApplicationDetailServiceBlockingStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new ApplicationDetailServiceBlockingStub(channel, callOptions);
        }
      };
    return ApplicationDetailServiceBlockingStub.newStub(factory, channel);
  }

  /**
   * Creates a new ListenableFuture-style stub that supports unary calls on the service
   */
  public static ApplicationDetailServiceFutureStub newFutureStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<ApplicationDetailServiceFutureStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<ApplicationDetailServiceFutureStub>() {
        @java.lang.Override
        public ApplicationDetailServiceFutureStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new ApplicationDetailServiceFutureStub(channel, callOptions);
        }
      };
    return ApplicationDetailServiceFutureStub.newStub(factory, channel);
  }

  /**
   * <pre>
   * A service which parses input applications and returns details that can be
   * useful in the context of testing.
   * </pre>
   */
  public static abstract class ApplicationDetailServiceImplBase implements io.grpc.BindableService {

    /**
     * <pre>
     * Gets the details of an Android application APK.
     * </pre>
     */
    public void getApkDetails(com.google.devtools.testing.v1.GetApkDetailsRequest request,
        io.grpc.stub.StreamObserver<com.google.devtools.testing.v1.GetApkDetailsResponse> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getGetApkDetailsMethod(), responseObserver);
    }

    @java.lang.Override public final io.grpc.ServerServiceDefinition bindService() {
      return io.grpc.ServerServiceDefinition.builder(getServiceDescriptor())
          .addMethod(
            getGetApkDetailsMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.devtools.testing.v1.GetApkDetailsRequest,
                com.google.devtools.testing.v1.GetApkDetailsResponse>(
                  this, METHODID_GET_APK_DETAILS)))
          .build();
    }
  }

  /**
   * <pre>
   * A service which parses input applications and returns details that can be
   * useful in the context of testing.
   * </pre>
   */
  public static final class ApplicationDetailServiceStub extends io.grpc.stub.AbstractAsyncStub<ApplicationDetailServiceStub> {
    private ApplicationDetailServiceStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected ApplicationDetailServiceStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new ApplicationDetailServiceStub(channel, callOptions);
    }

    /**
     * <pre>
     * Gets the details of an Android application APK.
     * </pre>
     */
    public void getApkDetails(com.google.devtools.testing.v1.GetApkDetailsRequest request,
        io.grpc.stub.StreamObserver<com.google.devtools.testing.v1.GetApkDetailsResponse> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getGetApkDetailsMethod(), getCallOptions()), request, responseObserver);
    }
  }

  /**
   * <pre>
   * A service which parses input applications and returns details that can be
   * useful in the context of testing.
   * </pre>
   */
  public static final class ApplicationDetailServiceBlockingStub extends io.grpc.stub.AbstractBlockingStub<ApplicationDetailServiceBlockingStub> {
    private ApplicationDetailServiceBlockingStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected ApplicationDetailServiceBlockingStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new ApplicationDetailServiceBlockingStub(channel, callOptions);
    }

    /**
     * <pre>
     * Gets the details of an Android application APK.
     * </pre>
     */
    public com.google.devtools.testing.v1.GetApkDetailsResponse getApkDetails(com.google.devtools.testing.v1.GetApkDetailsRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getGetApkDetailsMethod(), getCallOptions(), request);
    }
  }

  /**
   * <pre>
   * A service which parses input applications and returns details that can be
   * useful in the context of testing.
   * </pre>
   */
  public static final class ApplicationDetailServiceFutureStub extends io.grpc.stub.AbstractFutureStub<ApplicationDetailServiceFutureStub> {
    private ApplicationDetailServiceFutureStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected ApplicationDetailServiceFutureStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new ApplicationDetailServiceFutureStub(channel, callOptions);
    }

    /**
     * <pre>
     * Gets the details of an Android application APK.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.devtools.testing.v1.GetApkDetailsResponse> getApkDetails(
        com.google.devtools.testing.v1.GetApkDetailsRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getGetApkDetailsMethod(), getCallOptions()), request);
    }
  }

  private static final int METHODID_GET_APK_DETAILS = 0;

  private static final class MethodHandlers<Req, Resp> implements
      io.grpc.stub.ServerCalls.UnaryMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ServerStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ClientStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.BidiStreamingMethod<Req, Resp> {
    private final ApplicationDetailServiceImplBase serviceImpl;
    private final int methodId;

    MethodHandlers(ApplicationDetailServiceImplBase serviceImpl, int methodId) {
      this.serviceImpl = serviceImpl;
      this.methodId = methodId;
    }

    @java.lang.Override
    @java.lang.SuppressWarnings("unchecked")
    public void invoke(Req request, io.grpc.stub.StreamObserver<Resp> responseObserver) {
      switch (methodId) {
        case METHODID_GET_APK_DETAILS:
          serviceImpl.getApkDetails((com.google.devtools.testing.v1.GetApkDetailsRequest) request,
              (io.grpc.stub.StreamObserver<com.google.devtools.testing.v1.GetApkDetailsResponse>) responseObserver);
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

  private static abstract class ApplicationDetailServiceBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoFileDescriptorSupplier, io.grpc.protobuf.ProtoServiceDescriptorSupplier {
    ApplicationDetailServiceBaseDescriptorSupplier() {}

    @java.lang.Override
    public com.google.protobuf.Descriptors.FileDescriptor getFileDescriptor() {
      return com.google.devtools.testing.v1.ApplicationDetailProto.getDescriptor();
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.ServiceDescriptor getServiceDescriptor() {
      return getFileDescriptor().findServiceByName("ApplicationDetailService");
    }
  }

  private static final class ApplicationDetailServiceFileDescriptorSupplier
      extends ApplicationDetailServiceBaseDescriptorSupplier {
    ApplicationDetailServiceFileDescriptorSupplier() {}
  }

  private static final class ApplicationDetailServiceMethodDescriptorSupplier
      extends ApplicationDetailServiceBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoMethodDescriptorSupplier {
    private final String methodName;

    ApplicationDetailServiceMethodDescriptorSupplier(String methodName) {
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
      synchronized (ApplicationDetailServiceGrpc.class) {
        result = serviceDescriptor;
        if (result == null) {
          serviceDescriptor = result = io.grpc.ServiceDescriptor.newBuilder(SERVICE_NAME)
              .setSchemaDescriptor(new ApplicationDetailServiceFileDescriptorSupplier())
              .addMethod(getGetApkDetailsMethod())
              .build();
        }
      }
    }
    return result;
  }
}
