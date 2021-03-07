package com.google.ccc.hosted.marketplace.v2;

import static io.grpc.MethodDescriptor.generateFullMethodName;

/**
 */
@javax.annotation.Generated(
    value = "by gRPC proto compiler",
    comments = "Source: google/apps/market/v2/services.proto")
public final class CustomerLicenseServiceGrpc {

  private CustomerLicenseServiceGrpc() {}

  public static final String SERVICE_NAME = "ccc.hosted.marketplace.v2.CustomerLicenseService";

  // Static method descriptors that strictly reflect the proto.
  private static volatile io.grpc.MethodDescriptor<com.google.ccc.hosted.marketplace.v2.CustomerLicenseGetRequest,
      com.google.ccc.hosted.marketplace.v2.CustomerLicense> getGetMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "Get",
      requestType = com.google.ccc.hosted.marketplace.v2.CustomerLicenseGetRequest.class,
      responseType = com.google.ccc.hosted.marketplace.v2.CustomerLicense.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.ccc.hosted.marketplace.v2.CustomerLicenseGetRequest,
      com.google.ccc.hosted.marketplace.v2.CustomerLicense> getGetMethod() {
    io.grpc.MethodDescriptor<com.google.ccc.hosted.marketplace.v2.CustomerLicenseGetRequest, com.google.ccc.hosted.marketplace.v2.CustomerLicense> getGetMethod;
    if ((getGetMethod = CustomerLicenseServiceGrpc.getGetMethod) == null) {
      synchronized (CustomerLicenseServiceGrpc.class) {
        if ((getGetMethod = CustomerLicenseServiceGrpc.getGetMethod) == null) {
          CustomerLicenseServiceGrpc.getGetMethod = getGetMethod =
              io.grpc.MethodDescriptor.<com.google.ccc.hosted.marketplace.v2.CustomerLicenseGetRequest, com.google.ccc.hosted.marketplace.v2.CustomerLicense>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "Get"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.ccc.hosted.marketplace.v2.CustomerLicenseGetRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.ccc.hosted.marketplace.v2.CustomerLicense.getDefaultInstance()))
              .setSchemaDescriptor(new CustomerLicenseServiceMethodDescriptorSupplier("Get"))
              .build();
        }
      }
    }
    return getGetMethod;
  }

  /**
   * Creates a new async stub that supports all call types for the service
   */
  public static CustomerLicenseServiceStub newStub(io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<CustomerLicenseServiceStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<CustomerLicenseServiceStub>() {
        @java.lang.Override
        public CustomerLicenseServiceStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new CustomerLicenseServiceStub(channel, callOptions);
        }
      };
    return CustomerLicenseServiceStub.newStub(factory, channel);
  }

  /**
   * Creates a new blocking-style stub that supports unary and streaming output calls on the service
   */
  public static CustomerLicenseServiceBlockingStub newBlockingStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<CustomerLicenseServiceBlockingStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<CustomerLicenseServiceBlockingStub>() {
        @java.lang.Override
        public CustomerLicenseServiceBlockingStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new CustomerLicenseServiceBlockingStub(channel, callOptions);
        }
      };
    return CustomerLicenseServiceBlockingStub.newStub(factory, channel);
  }

  /**
   * Creates a new ListenableFuture-style stub that supports unary calls on the service
   */
  public static CustomerLicenseServiceFutureStub newFutureStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<CustomerLicenseServiceFutureStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<CustomerLicenseServiceFutureStub>() {
        @java.lang.Override
        public CustomerLicenseServiceFutureStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new CustomerLicenseServiceFutureStub(channel, callOptions);
        }
      };
    return CustomerLicenseServiceFutureStub.newStub(factory, channel);
  }

  /**
   */
  public static abstract class CustomerLicenseServiceImplBase implements io.grpc.BindableService {

    /**
     * <pre>
     * Get the status of a license for a customer to determine if they have access
     * for a given app.
     * </pre>
     */
    public void get(com.google.ccc.hosted.marketplace.v2.CustomerLicenseGetRequest request,
        io.grpc.stub.StreamObserver<com.google.ccc.hosted.marketplace.v2.CustomerLicense> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getGetMethod(), responseObserver);
    }

    @java.lang.Override public final io.grpc.ServerServiceDefinition bindService() {
      return io.grpc.ServerServiceDefinition.builder(getServiceDescriptor())
          .addMethod(
            getGetMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.ccc.hosted.marketplace.v2.CustomerLicenseGetRequest,
                com.google.ccc.hosted.marketplace.v2.CustomerLicense>(
                  this, METHODID_GET)))
          .build();
    }
  }

  /**
   */
  public static final class CustomerLicenseServiceStub extends io.grpc.stub.AbstractAsyncStub<CustomerLicenseServiceStub> {
    private CustomerLicenseServiceStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected CustomerLicenseServiceStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new CustomerLicenseServiceStub(channel, callOptions);
    }

    /**
     * <pre>
     * Get the status of a license for a customer to determine if they have access
     * for a given app.
     * </pre>
     */
    public void get(com.google.ccc.hosted.marketplace.v2.CustomerLicenseGetRequest request,
        io.grpc.stub.StreamObserver<com.google.ccc.hosted.marketplace.v2.CustomerLicense> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getGetMethod(), getCallOptions()), request, responseObserver);
    }
  }

  /**
   */
  public static final class CustomerLicenseServiceBlockingStub extends io.grpc.stub.AbstractBlockingStub<CustomerLicenseServiceBlockingStub> {
    private CustomerLicenseServiceBlockingStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected CustomerLicenseServiceBlockingStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new CustomerLicenseServiceBlockingStub(channel, callOptions);
    }

    /**
     * <pre>
     * Get the status of a license for a customer to determine if they have access
     * for a given app.
     * </pre>
     */
    public com.google.ccc.hosted.marketplace.v2.CustomerLicense get(com.google.ccc.hosted.marketplace.v2.CustomerLicenseGetRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getGetMethod(), getCallOptions(), request);
    }
  }

  /**
   */
  public static final class CustomerLicenseServiceFutureStub extends io.grpc.stub.AbstractFutureStub<CustomerLicenseServiceFutureStub> {
    private CustomerLicenseServiceFutureStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected CustomerLicenseServiceFutureStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new CustomerLicenseServiceFutureStub(channel, callOptions);
    }

    /**
     * <pre>
     * Get the status of a license for a customer to determine if they have access
     * for a given app.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.ccc.hosted.marketplace.v2.CustomerLicense> get(
        com.google.ccc.hosted.marketplace.v2.CustomerLicenseGetRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getGetMethod(), getCallOptions()), request);
    }
  }

  private static final int METHODID_GET = 0;

  private static final class MethodHandlers<Req, Resp> implements
      io.grpc.stub.ServerCalls.UnaryMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ServerStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ClientStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.BidiStreamingMethod<Req, Resp> {
    private final CustomerLicenseServiceImplBase serviceImpl;
    private final int methodId;

    MethodHandlers(CustomerLicenseServiceImplBase serviceImpl, int methodId) {
      this.serviceImpl = serviceImpl;
      this.methodId = methodId;
    }

    @java.lang.Override
    @java.lang.SuppressWarnings("unchecked")
    public void invoke(Req request, io.grpc.stub.StreamObserver<Resp> responseObserver) {
      switch (methodId) {
        case METHODID_GET:
          serviceImpl.get((com.google.ccc.hosted.marketplace.v2.CustomerLicenseGetRequest) request,
              (io.grpc.stub.StreamObserver<com.google.ccc.hosted.marketplace.v2.CustomerLicense>) responseObserver);
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

  private static abstract class CustomerLicenseServiceBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoFileDescriptorSupplier, io.grpc.protobuf.ProtoServiceDescriptorSupplier {
    CustomerLicenseServiceBaseDescriptorSupplier() {}

    @java.lang.Override
    public com.google.protobuf.Descriptors.FileDescriptor getFileDescriptor() {
      return com.google.ccc.hosted.marketplace.v2.ServiceProto.getDescriptor();
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.ServiceDescriptor getServiceDescriptor() {
      return getFileDescriptor().findServiceByName("CustomerLicenseService");
    }
  }

  private static final class CustomerLicenseServiceFileDescriptorSupplier
      extends CustomerLicenseServiceBaseDescriptorSupplier {
    CustomerLicenseServiceFileDescriptorSupplier() {}
  }

  private static final class CustomerLicenseServiceMethodDescriptorSupplier
      extends CustomerLicenseServiceBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoMethodDescriptorSupplier {
    private final String methodName;

    CustomerLicenseServiceMethodDescriptorSupplier(String methodName) {
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
      synchronized (CustomerLicenseServiceGrpc.class) {
        result = serviceDescriptor;
        if (result == null) {
          serviceDescriptor = result = io.grpc.ServiceDescriptor.newBuilder(SERVICE_NAME)
              .setSchemaDescriptor(new CustomerLicenseServiceFileDescriptorSupplier())
              .addMethod(getGetMethod())
              .build();
        }
      }
    }
    return result;
  }
}
