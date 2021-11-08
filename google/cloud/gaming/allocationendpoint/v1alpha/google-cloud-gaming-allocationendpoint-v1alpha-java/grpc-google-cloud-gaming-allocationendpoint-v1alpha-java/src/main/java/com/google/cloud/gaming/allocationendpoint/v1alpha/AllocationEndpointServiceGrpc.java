package com.google.cloud.gaming.allocationendpoint.v1alpha;

import static io.grpc.MethodDescriptor.generateFullMethodName;

/**
 */
@javax.annotation.Generated(
    value = "by gRPC proto compiler",
    comments = "Source: google/cloud/gaming/allocationendpoint/v1alpha/allocation_endpoint.proto")
@io.grpc.stub.annotations.GrpcGenerated
public final class AllocationEndpointServiceGrpc {

  private AllocationEndpointServiceGrpc() {}

  public static final String SERVICE_NAME = "google.cloud.gaming.allocationendpoint.v1alpha.AllocationEndpointService";

  // Static method descriptors that strictly reflect the proto.
  private static volatile io.grpc.MethodDescriptor<com.google.cloud.gaming.allocationendpoint.v1alpha.AllocationRequest,
      com.google.cloud.gaming.allocationendpoint.v1alpha.AllocationResponse> getAllocateMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "Allocate",
      requestType = com.google.cloud.gaming.allocationendpoint.v1alpha.AllocationRequest.class,
      responseType = com.google.cloud.gaming.allocationendpoint.v1alpha.AllocationResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.cloud.gaming.allocationendpoint.v1alpha.AllocationRequest,
      com.google.cloud.gaming.allocationendpoint.v1alpha.AllocationResponse> getAllocateMethod() {
    io.grpc.MethodDescriptor<com.google.cloud.gaming.allocationendpoint.v1alpha.AllocationRequest, com.google.cloud.gaming.allocationendpoint.v1alpha.AllocationResponse> getAllocateMethod;
    if ((getAllocateMethod = AllocationEndpointServiceGrpc.getAllocateMethod) == null) {
      synchronized (AllocationEndpointServiceGrpc.class) {
        if ((getAllocateMethod = AllocationEndpointServiceGrpc.getAllocateMethod) == null) {
          AllocationEndpointServiceGrpc.getAllocateMethod = getAllocateMethod =
              io.grpc.MethodDescriptor.<com.google.cloud.gaming.allocationendpoint.v1alpha.AllocationRequest, com.google.cloud.gaming.allocationendpoint.v1alpha.AllocationResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "Allocate"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.gaming.allocationendpoint.v1alpha.AllocationRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.gaming.allocationendpoint.v1alpha.AllocationResponse.getDefaultInstance()))
              .setSchemaDescriptor(new AllocationEndpointServiceMethodDescriptorSupplier("Allocate"))
              .build();
        }
      }
    }
    return getAllocateMethod;
  }

  /**
   * Creates a new async stub that supports all call types for the service
   */
  public static AllocationEndpointServiceStub newStub(io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<AllocationEndpointServiceStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<AllocationEndpointServiceStub>() {
        @java.lang.Override
        public AllocationEndpointServiceStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new AllocationEndpointServiceStub(channel, callOptions);
        }
      };
    return AllocationEndpointServiceStub.newStub(factory, channel);
  }

  /**
   * Creates a new blocking-style stub that supports unary and streaming output calls on the service
   */
  public static AllocationEndpointServiceBlockingStub newBlockingStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<AllocationEndpointServiceBlockingStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<AllocationEndpointServiceBlockingStub>() {
        @java.lang.Override
        public AllocationEndpointServiceBlockingStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new AllocationEndpointServiceBlockingStub(channel, callOptions);
        }
      };
    return AllocationEndpointServiceBlockingStub.newStub(factory, channel);
  }

  /**
   * Creates a new ListenableFuture-style stub that supports unary calls on the service
   */
  public static AllocationEndpointServiceFutureStub newFutureStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<AllocationEndpointServiceFutureStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<AllocationEndpointServiceFutureStub>() {
        @java.lang.Override
        public AllocationEndpointServiceFutureStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new AllocationEndpointServiceFutureStub(channel, callOptions);
        }
      };
    return AllocationEndpointServiceFutureStub.newStub(factory, channel);
  }

  /**
   */
  public static abstract class AllocationEndpointServiceImplBase implements io.grpc.BindableService {

    /**
     * <pre>
     * Proxy allocation service to the Game Server Clusters.
     * </pre>
     */
    public void allocate(com.google.cloud.gaming.allocationendpoint.v1alpha.AllocationRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.gaming.allocationendpoint.v1alpha.AllocationResponse> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getAllocateMethod(), responseObserver);
    }

    @java.lang.Override public final io.grpc.ServerServiceDefinition bindService() {
      return io.grpc.ServerServiceDefinition.builder(getServiceDescriptor())
          .addMethod(
            getAllocateMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.cloud.gaming.allocationendpoint.v1alpha.AllocationRequest,
                com.google.cloud.gaming.allocationendpoint.v1alpha.AllocationResponse>(
                  this, METHODID_ALLOCATE)))
          .build();
    }
  }

  /**
   */
  public static final class AllocationEndpointServiceStub extends io.grpc.stub.AbstractAsyncStub<AllocationEndpointServiceStub> {
    private AllocationEndpointServiceStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected AllocationEndpointServiceStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new AllocationEndpointServiceStub(channel, callOptions);
    }

    /**
     * <pre>
     * Proxy allocation service to the Game Server Clusters.
     * </pre>
     */
    public void allocate(com.google.cloud.gaming.allocationendpoint.v1alpha.AllocationRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.gaming.allocationendpoint.v1alpha.AllocationResponse> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getAllocateMethod(), getCallOptions()), request, responseObserver);
    }
  }

  /**
   */
  public static final class AllocationEndpointServiceBlockingStub extends io.grpc.stub.AbstractBlockingStub<AllocationEndpointServiceBlockingStub> {
    private AllocationEndpointServiceBlockingStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected AllocationEndpointServiceBlockingStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new AllocationEndpointServiceBlockingStub(channel, callOptions);
    }

    /**
     * <pre>
     * Proxy allocation service to the Game Server Clusters.
     * </pre>
     */
    public com.google.cloud.gaming.allocationendpoint.v1alpha.AllocationResponse allocate(com.google.cloud.gaming.allocationendpoint.v1alpha.AllocationRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getAllocateMethod(), getCallOptions(), request);
    }
  }

  /**
   */
  public static final class AllocationEndpointServiceFutureStub extends io.grpc.stub.AbstractFutureStub<AllocationEndpointServiceFutureStub> {
    private AllocationEndpointServiceFutureStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected AllocationEndpointServiceFutureStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new AllocationEndpointServiceFutureStub(channel, callOptions);
    }

    /**
     * <pre>
     * Proxy allocation service to the Game Server Clusters.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.cloud.gaming.allocationendpoint.v1alpha.AllocationResponse> allocate(
        com.google.cloud.gaming.allocationendpoint.v1alpha.AllocationRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getAllocateMethod(), getCallOptions()), request);
    }
  }

  private static final int METHODID_ALLOCATE = 0;

  private static final class MethodHandlers<Req, Resp> implements
      io.grpc.stub.ServerCalls.UnaryMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ServerStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ClientStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.BidiStreamingMethod<Req, Resp> {
    private final AllocationEndpointServiceImplBase serviceImpl;
    private final int methodId;

    MethodHandlers(AllocationEndpointServiceImplBase serviceImpl, int methodId) {
      this.serviceImpl = serviceImpl;
      this.methodId = methodId;
    }

    @java.lang.Override
    @java.lang.SuppressWarnings("unchecked")
    public void invoke(Req request, io.grpc.stub.StreamObserver<Resp> responseObserver) {
      switch (methodId) {
        case METHODID_ALLOCATE:
          serviceImpl.allocate((com.google.cloud.gaming.allocationendpoint.v1alpha.AllocationRequest) request,
              (io.grpc.stub.StreamObserver<com.google.cloud.gaming.allocationendpoint.v1alpha.AllocationResponse>) responseObserver);
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

  private static abstract class AllocationEndpointServiceBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoFileDescriptorSupplier, io.grpc.protobuf.ProtoServiceDescriptorSupplier {
    AllocationEndpointServiceBaseDescriptorSupplier() {}

    @java.lang.Override
    public com.google.protobuf.Descriptors.FileDescriptor getFileDescriptor() {
      return com.google.cloud.gaming.allocationendpoint.v1alpha.AllocationEndpointProto.getDescriptor();
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.ServiceDescriptor getServiceDescriptor() {
      return getFileDescriptor().findServiceByName("AllocationEndpointService");
    }
  }

  private static final class AllocationEndpointServiceFileDescriptorSupplier
      extends AllocationEndpointServiceBaseDescriptorSupplier {
    AllocationEndpointServiceFileDescriptorSupplier() {}
  }

  private static final class AllocationEndpointServiceMethodDescriptorSupplier
      extends AllocationEndpointServiceBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoMethodDescriptorSupplier {
    private final String methodName;

    AllocationEndpointServiceMethodDescriptorSupplier(String methodName) {
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
      synchronized (AllocationEndpointServiceGrpc.class) {
        result = serviceDescriptor;
        if (result == null) {
          serviceDescriptor = result = io.grpc.ServiceDescriptor.newBuilder(SERVICE_NAME)
              .setSchemaDescriptor(new AllocationEndpointServiceFileDescriptorSupplier())
              .addMethod(getAllocateMethod())
              .build();
        }
      }
    }
    return result;
  }
}
