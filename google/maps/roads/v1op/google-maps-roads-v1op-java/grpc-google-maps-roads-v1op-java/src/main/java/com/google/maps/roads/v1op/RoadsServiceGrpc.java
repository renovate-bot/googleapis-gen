package com.google.maps.roads.v1op;

import static io.grpc.MethodDescriptor.generateFullMethodName;
import static io.grpc.stub.ClientCalls.asyncBidiStreamingCall;
import static io.grpc.stub.ClientCalls.asyncClientStreamingCall;
import static io.grpc.stub.ClientCalls.asyncServerStreamingCall;
import static io.grpc.stub.ClientCalls.asyncUnaryCall;
import static io.grpc.stub.ClientCalls.blockingServerStreamingCall;
import static io.grpc.stub.ClientCalls.blockingUnaryCall;
import static io.grpc.stub.ClientCalls.futureUnaryCall;
import static io.grpc.stub.ServerCalls.asyncBidiStreamingCall;
import static io.grpc.stub.ServerCalls.asyncClientStreamingCall;
import static io.grpc.stub.ServerCalls.asyncServerStreamingCall;
import static io.grpc.stub.ServerCalls.asyncUnaryCall;
import static io.grpc.stub.ServerCalls.asyncUnimplementedStreamingCall;
import static io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall;

/**
 */
@javax.annotation.Generated(
    value = "by gRPC proto compiler",
    comments = "Source: google/maps/roads/v1op/roads.proto")
public final class RoadsServiceGrpc {

  private RoadsServiceGrpc() {}

  public static final String SERVICE_NAME = "google.maps.roads.v1op.RoadsService";

  // Static method descriptors that strictly reflect the proto.
  private static volatile io.grpc.MethodDescriptor<com.google.maps.roads.v1op.SnapToRoadsRequest,
      com.google.maps.roads.v1op.SnapToRoadsResponse> getSnapToRoadsMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "SnapToRoads",
      requestType = com.google.maps.roads.v1op.SnapToRoadsRequest.class,
      responseType = com.google.maps.roads.v1op.SnapToRoadsResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.maps.roads.v1op.SnapToRoadsRequest,
      com.google.maps.roads.v1op.SnapToRoadsResponse> getSnapToRoadsMethod() {
    io.grpc.MethodDescriptor<com.google.maps.roads.v1op.SnapToRoadsRequest, com.google.maps.roads.v1op.SnapToRoadsResponse> getSnapToRoadsMethod;
    if ((getSnapToRoadsMethod = RoadsServiceGrpc.getSnapToRoadsMethod) == null) {
      synchronized (RoadsServiceGrpc.class) {
        if ((getSnapToRoadsMethod = RoadsServiceGrpc.getSnapToRoadsMethod) == null) {
          RoadsServiceGrpc.getSnapToRoadsMethod = getSnapToRoadsMethod =
              io.grpc.MethodDescriptor.<com.google.maps.roads.v1op.SnapToRoadsRequest, com.google.maps.roads.v1op.SnapToRoadsResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "SnapToRoads"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.maps.roads.v1op.SnapToRoadsRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.maps.roads.v1op.SnapToRoadsResponse.getDefaultInstance()))
              .setSchemaDescriptor(new RoadsServiceMethodDescriptorSupplier("SnapToRoads"))
              .build();
        }
      }
    }
    return getSnapToRoadsMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.maps.roads.v1op.ListNearestRoadsRequest,
      com.google.maps.roads.v1op.ListNearestRoadsResponse> getListNearestRoadsMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "ListNearestRoads",
      requestType = com.google.maps.roads.v1op.ListNearestRoadsRequest.class,
      responseType = com.google.maps.roads.v1op.ListNearestRoadsResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.maps.roads.v1op.ListNearestRoadsRequest,
      com.google.maps.roads.v1op.ListNearestRoadsResponse> getListNearestRoadsMethod() {
    io.grpc.MethodDescriptor<com.google.maps.roads.v1op.ListNearestRoadsRequest, com.google.maps.roads.v1op.ListNearestRoadsResponse> getListNearestRoadsMethod;
    if ((getListNearestRoadsMethod = RoadsServiceGrpc.getListNearestRoadsMethod) == null) {
      synchronized (RoadsServiceGrpc.class) {
        if ((getListNearestRoadsMethod = RoadsServiceGrpc.getListNearestRoadsMethod) == null) {
          RoadsServiceGrpc.getListNearestRoadsMethod = getListNearestRoadsMethod =
              io.grpc.MethodDescriptor.<com.google.maps.roads.v1op.ListNearestRoadsRequest, com.google.maps.roads.v1op.ListNearestRoadsResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "ListNearestRoads"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.maps.roads.v1op.ListNearestRoadsRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.maps.roads.v1op.ListNearestRoadsResponse.getDefaultInstance()))
              .setSchemaDescriptor(new RoadsServiceMethodDescriptorSupplier("ListNearestRoads"))
              .build();
        }
      }
    }
    return getListNearestRoadsMethod;
  }

  /**
   * Creates a new async stub that supports all call types for the service
   */
  public static RoadsServiceStub newStub(io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<RoadsServiceStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<RoadsServiceStub>() {
        @java.lang.Override
        public RoadsServiceStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new RoadsServiceStub(channel, callOptions);
        }
      };
    return RoadsServiceStub.newStub(factory, channel);
  }

  /**
   * Creates a new blocking-style stub that supports unary and streaming output calls on the service
   */
  public static RoadsServiceBlockingStub newBlockingStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<RoadsServiceBlockingStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<RoadsServiceBlockingStub>() {
        @java.lang.Override
        public RoadsServiceBlockingStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new RoadsServiceBlockingStub(channel, callOptions);
        }
      };
    return RoadsServiceBlockingStub.newStub(factory, channel);
  }

  /**
   * Creates a new ListenableFuture-style stub that supports unary calls on the service
   */
  public static RoadsServiceFutureStub newFutureStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<RoadsServiceFutureStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<RoadsServiceFutureStub>() {
        @java.lang.Override
        public RoadsServiceFutureStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new RoadsServiceFutureStub(channel, callOptions);
        }
      };
    return RoadsServiceFutureStub.newStub(factory, channel);
  }

  /**
   */
  public static abstract class RoadsServiceImplBase implements io.grpc.BindableService {

    /**
     * <pre>
     * This method takes a sequence of latitude,longitude points and snaps them to
     * the most likely road segments. Optionally returns additional points giving
     * the full road geometry. Also returns a place ID for each snapped point.
     * </pre>
     */
    public void snapToRoads(com.google.maps.roads.v1op.SnapToRoadsRequest request,
        io.grpc.stub.StreamObserver<com.google.maps.roads.v1op.SnapToRoadsResponse> responseObserver) {
      asyncUnimplementedUnaryCall(getSnapToRoadsMethod(), responseObserver);
    }

    /**
     * <pre>
     * This method takes a list of latitude,longitude points and snaps them each
     * to their nearest road. Also returns a place ID for each snapped point.
     * </pre>
     */
    public void listNearestRoads(com.google.maps.roads.v1op.ListNearestRoadsRequest request,
        io.grpc.stub.StreamObserver<com.google.maps.roads.v1op.ListNearestRoadsResponse> responseObserver) {
      asyncUnimplementedUnaryCall(getListNearestRoadsMethod(), responseObserver);
    }

    @java.lang.Override public final io.grpc.ServerServiceDefinition bindService() {
      return io.grpc.ServerServiceDefinition.builder(getServiceDescriptor())
          .addMethod(
            getSnapToRoadsMethod(),
            asyncUnaryCall(
              new MethodHandlers<
                com.google.maps.roads.v1op.SnapToRoadsRequest,
                com.google.maps.roads.v1op.SnapToRoadsResponse>(
                  this, METHODID_SNAP_TO_ROADS)))
          .addMethod(
            getListNearestRoadsMethod(),
            asyncUnaryCall(
              new MethodHandlers<
                com.google.maps.roads.v1op.ListNearestRoadsRequest,
                com.google.maps.roads.v1op.ListNearestRoadsResponse>(
                  this, METHODID_LIST_NEAREST_ROADS)))
          .build();
    }
  }

  /**
   */
  public static final class RoadsServiceStub extends io.grpc.stub.AbstractAsyncStub<RoadsServiceStub> {
    private RoadsServiceStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected RoadsServiceStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new RoadsServiceStub(channel, callOptions);
    }

    /**
     * <pre>
     * This method takes a sequence of latitude,longitude points and snaps them to
     * the most likely road segments. Optionally returns additional points giving
     * the full road geometry. Also returns a place ID for each snapped point.
     * </pre>
     */
    public void snapToRoads(com.google.maps.roads.v1op.SnapToRoadsRequest request,
        io.grpc.stub.StreamObserver<com.google.maps.roads.v1op.SnapToRoadsResponse> responseObserver) {
      asyncUnaryCall(
          getChannel().newCall(getSnapToRoadsMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * This method takes a list of latitude,longitude points and snaps them each
     * to their nearest road. Also returns a place ID for each snapped point.
     * </pre>
     */
    public void listNearestRoads(com.google.maps.roads.v1op.ListNearestRoadsRequest request,
        io.grpc.stub.StreamObserver<com.google.maps.roads.v1op.ListNearestRoadsResponse> responseObserver) {
      asyncUnaryCall(
          getChannel().newCall(getListNearestRoadsMethod(), getCallOptions()), request, responseObserver);
    }
  }

  /**
   */
  public static final class RoadsServiceBlockingStub extends io.grpc.stub.AbstractBlockingStub<RoadsServiceBlockingStub> {
    private RoadsServiceBlockingStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected RoadsServiceBlockingStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new RoadsServiceBlockingStub(channel, callOptions);
    }

    /**
     * <pre>
     * This method takes a sequence of latitude,longitude points and snaps them to
     * the most likely road segments. Optionally returns additional points giving
     * the full road geometry. Also returns a place ID for each snapped point.
     * </pre>
     */
    public com.google.maps.roads.v1op.SnapToRoadsResponse snapToRoads(com.google.maps.roads.v1op.SnapToRoadsRequest request) {
      return blockingUnaryCall(
          getChannel(), getSnapToRoadsMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * This method takes a list of latitude,longitude points and snaps them each
     * to their nearest road. Also returns a place ID for each snapped point.
     * </pre>
     */
    public com.google.maps.roads.v1op.ListNearestRoadsResponse listNearestRoads(com.google.maps.roads.v1op.ListNearestRoadsRequest request) {
      return blockingUnaryCall(
          getChannel(), getListNearestRoadsMethod(), getCallOptions(), request);
    }
  }

  /**
   */
  public static final class RoadsServiceFutureStub extends io.grpc.stub.AbstractFutureStub<RoadsServiceFutureStub> {
    private RoadsServiceFutureStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected RoadsServiceFutureStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new RoadsServiceFutureStub(channel, callOptions);
    }

    /**
     * <pre>
     * This method takes a sequence of latitude,longitude points and snaps them to
     * the most likely road segments. Optionally returns additional points giving
     * the full road geometry. Also returns a place ID for each snapped point.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.maps.roads.v1op.SnapToRoadsResponse> snapToRoads(
        com.google.maps.roads.v1op.SnapToRoadsRequest request) {
      return futureUnaryCall(
          getChannel().newCall(getSnapToRoadsMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * This method takes a list of latitude,longitude points and snaps them each
     * to their nearest road. Also returns a place ID for each snapped point.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.maps.roads.v1op.ListNearestRoadsResponse> listNearestRoads(
        com.google.maps.roads.v1op.ListNearestRoadsRequest request) {
      return futureUnaryCall(
          getChannel().newCall(getListNearestRoadsMethod(), getCallOptions()), request);
    }
  }

  private static final int METHODID_SNAP_TO_ROADS = 0;
  private static final int METHODID_LIST_NEAREST_ROADS = 1;

  private static final class MethodHandlers<Req, Resp> implements
      io.grpc.stub.ServerCalls.UnaryMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ServerStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ClientStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.BidiStreamingMethod<Req, Resp> {
    private final RoadsServiceImplBase serviceImpl;
    private final int methodId;

    MethodHandlers(RoadsServiceImplBase serviceImpl, int methodId) {
      this.serviceImpl = serviceImpl;
      this.methodId = methodId;
    }

    @java.lang.Override
    @java.lang.SuppressWarnings("unchecked")
    public void invoke(Req request, io.grpc.stub.StreamObserver<Resp> responseObserver) {
      switch (methodId) {
        case METHODID_SNAP_TO_ROADS:
          serviceImpl.snapToRoads((com.google.maps.roads.v1op.SnapToRoadsRequest) request,
              (io.grpc.stub.StreamObserver<com.google.maps.roads.v1op.SnapToRoadsResponse>) responseObserver);
          break;
        case METHODID_LIST_NEAREST_ROADS:
          serviceImpl.listNearestRoads((com.google.maps.roads.v1op.ListNearestRoadsRequest) request,
              (io.grpc.stub.StreamObserver<com.google.maps.roads.v1op.ListNearestRoadsResponse>) responseObserver);
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

  private static abstract class RoadsServiceBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoFileDescriptorSupplier, io.grpc.protobuf.ProtoServiceDescriptorSupplier {
    RoadsServiceBaseDescriptorSupplier() {}

    @java.lang.Override
    public com.google.protobuf.Descriptors.FileDescriptor getFileDescriptor() {
      return com.google.maps.roads.v1op.RoadsProto.getDescriptor();
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.ServiceDescriptor getServiceDescriptor() {
      return getFileDescriptor().findServiceByName("RoadsService");
    }
  }

  private static final class RoadsServiceFileDescriptorSupplier
      extends RoadsServiceBaseDescriptorSupplier {
    RoadsServiceFileDescriptorSupplier() {}
  }

  private static final class RoadsServiceMethodDescriptorSupplier
      extends RoadsServiceBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoMethodDescriptorSupplier {
    private final String methodName;

    RoadsServiceMethodDescriptorSupplier(String methodName) {
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
      synchronized (RoadsServiceGrpc.class) {
        result = serviceDescriptor;
        if (result == null) {
          serviceDescriptor = result = io.grpc.ServiceDescriptor.newBuilder(SERVICE_NAME)
              .setSchemaDescriptor(new RoadsServiceFileDescriptorSupplier())
              .addMethod(getSnapToRoadsMethod())
              .addMethod(getListNearestRoadsMethod())
              .build();
        }
      }
    }
    return result;
  }
}
