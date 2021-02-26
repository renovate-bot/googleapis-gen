package com.google.ccc.hosted.marketplace.v2;

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
    comments = "Source: google/apps/market/v2/services.proto")
public final class UserLicenseServiceGrpc {

  private UserLicenseServiceGrpc() {}

  public static final String SERVICE_NAME = "ccc.hosted.marketplace.v2.UserLicenseService";

  // Static method descriptors that strictly reflect the proto.
  private static volatile io.grpc.MethodDescriptor<com.google.ccc.hosted.marketplace.v2.UserLicenseGetRequest,
      com.google.ccc.hosted.marketplace.v2.UserLicense> getGetMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "Get",
      requestType = com.google.ccc.hosted.marketplace.v2.UserLicenseGetRequest.class,
      responseType = com.google.ccc.hosted.marketplace.v2.UserLicense.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.ccc.hosted.marketplace.v2.UserLicenseGetRequest,
      com.google.ccc.hosted.marketplace.v2.UserLicense> getGetMethod() {
    io.grpc.MethodDescriptor<com.google.ccc.hosted.marketplace.v2.UserLicenseGetRequest, com.google.ccc.hosted.marketplace.v2.UserLicense> getGetMethod;
    if ((getGetMethod = UserLicenseServiceGrpc.getGetMethod) == null) {
      synchronized (UserLicenseServiceGrpc.class) {
        if ((getGetMethod = UserLicenseServiceGrpc.getGetMethod) == null) {
          UserLicenseServiceGrpc.getGetMethod = getGetMethod =
              io.grpc.MethodDescriptor.<com.google.ccc.hosted.marketplace.v2.UserLicenseGetRequest, com.google.ccc.hosted.marketplace.v2.UserLicense>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "Get"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.ccc.hosted.marketplace.v2.UserLicenseGetRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.ccc.hosted.marketplace.v2.UserLicense.getDefaultInstance()))
              .setSchemaDescriptor(new UserLicenseServiceMethodDescriptorSupplier("Get"))
              .build();
        }
      }
    }
    return getGetMethod;
  }

  /**
   * Creates a new async stub that supports all call types for the service
   */
  public static UserLicenseServiceStub newStub(io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<UserLicenseServiceStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<UserLicenseServiceStub>() {
        @java.lang.Override
        public UserLicenseServiceStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new UserLicenseServiceStub(channel, callOptions);
        }
      };
    return UserLicenseServiceStub.newStub(factory, channel);
  }

  /**
   * Creates a new blocking-style stub that supports unary and streaming output calls on the service
   */
  public static UserLicenseServiceBlockingStub newBlockingStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<UserLicenseServiceBlockingStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<UserLicenseServiceBlockingStub>() {
        @java.lang.Override
        public UserLicenseServiceBlockingStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new UserLicenseServiceBlockingStub(channel, callOptions);
        }
      };
    return UserLicenseServiceBlockingStub.newStub(factory, channel);
  }

  /**
   * Creates a new ListenableFuture-style stub that supports unary calls on the service
   */
  public static UserLicenseServiceFutureStub newFutureStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<UserLicenseServiceFutureStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<UserLicenseServiceFutureStub>() {
        @java.lang.Override
        public UserLicenseServiceFutureStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new UserLicenseServiceFutureStub(channel, callOptions);
        }
      };
    return UserLicenseServiceFutureStub.newStub(factory, channel);
  }

  /**
   */
  public static abstract class UserLicenseServiceImplBase implements io.grpc.BindableService {

    /**
     * <pre>
     * Get the user's licensing status for their permission to use a given app.
     * </pre>
     */
    public void get(com.google.ccc.hosted.marketplace.v2.UserLicenseGetRequest request,
        io.grpc.stub.StreamObserver<com.google.ccc.hosted.marketplace.v2.UserLicense> responseObserver) {
      asyncUnimplementedUnaryCall(getGetMethod(), responseObserver);
    }

    @java.lang.Override public final io.grpc.ServerServiceDefinition bindService() {
      return io.grpc.ServerServiceDefinition.builder(getServiceDescriptor())
          .addMethod(
            getGetMethod(),
            asyncUnaryCall(
              new MethodHandlers<
                com.google.ccc.hosted.marketplace.v2.UserLicenseGetRequest,
                com.google.ccc.hosted.marketplace.v2.UserLicense>(
                  this, METHODID_GET)))
          .build();
    }
  }

  /**
   */
  public static final class UserLicenseServiceStub extends io.grpc.stub.AbstractAsyncStub<UserLicenseServiceStub> {
    private UserLicenseServiceStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected UserLicenseServiceStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new UserLicenseServiceStub(channel, callOptions);
    }

    /**
     * <pre>
     * Get the user's licensing status for their permission to use a given app.
     * </pre>
     */
    public void get(com.google.ccc.hosted.marketplace.v2.UserLicenseGetRequest request,
        io.grpc.stub.StreamObserver<com.google.ccc.hosted.marketplace.v2.UserLicense> responseObserver) {
      asyncUnaryCall(
          getChannel().newCall(getGetMethod(), getCallOptions()), request, responseObserver);
    }
  }

  /**
   */
  public static final class UserLicenseServiceBlockingStub extends io.grpc.stub.AbstractBlockingStub<UserLicenseServiceBlockingStub> {
    private UserLicenseServiceBlockingStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected UserLicenseServiceBlockingStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new UserLicenseServiceBlockingStub(channel, callOptions);
    }

    /**
     * <pre>
     * Get the user's licensing status for their permission to use a given app.
     * </pre>
     */
    public com.google.ccc.hosted.marketplace.v2.UserLicense get(com.google.ccc.hosted.marketplace.v2.UserLicenseGetRequest request) {
      return blockingUnaryCall(
          getChannel(), getGetMethod(), getCallOptions(), request);
    }
  }

  /**
   */
  public static final class UserLicenseServiceFutureStub extends io.grpc.stub.AbstractFutureStub<UserLicenseServiceFutureStub> {
    private UserLicenseServiceFutureStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected UserLicenseServiceFutureStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new UserLicenseServiceFutureStub(channel, callOptions);
    }

    /**
     * <pre>
     * Get the user's licensing status for their permission to use a given app.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.ccc.hosted.marketplace.v2.UserLicense> get(
        com.google.ccc.hosted.marketplace.v2.UserLicenseGetRequest request) {
      return futureUnaryCall(
          getChannel().newCall(getGetMethod(), getCallOptions()), request);
    }
  }

  private static final int METHODID_GET = 0;

  private static final class MethodHandlers<Req, Resp> implements
      io.grpc.stub.ServerCalls.UnaryMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ServerStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ClientStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.BidiStreamingMethod<Req, Resp> {
    private final UserLicenseServiceImplBase serviceImpl;
    private final int methodId;

    MethodHandlers(UserLicenseServiceImplBase serviceImpl, int methodId) {
      this.serviceImpl = serviceImpl;
      this.methodId = methodId;
    }

    @java.lang.Override
    @java.lang.SuppressWarnings("unchecked")
    public void invoke(Req request, io.grpc.stub.StreamObserver<Resp> responseObserver) {
      switch (methodId) {
        case METHODID_GET:
          serviceImpl.get((com.google.ccc.hosted.marketplace.v2.UserLicenseGetRequest) request,
              (io.grpc.stub.StreamObserver<com.google.ccc.hosted.marketplace.v2.UserLicense>) responseObserver);
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

  private static abstract class UserLicenseServiceBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoFileDescriptorSupplier, io.grpc.protobuf.ProtoServiceDescriptorSupplier {
    UserLicenseServiceBaseDescriptorSupplier() {}

    @java.lang.Override
    public com.google.protobuf.Descriptors.FileDescriptor getFileDescriptor() {
      return com.google.ccc.hosted.marketplace.v2.ServiceProto.getDescriptor();
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.ServiceDescriptor getServiceDescriptor() {
      return getFileDescriptor().findServiceByName("UserLicenseService");
    }
  }

  private static final class UserLicenseServiceFileDescriptorSupplier
      extends UserLicenseServiceBaseDescriptorSupplier {
    UserLicenseServiceFileDescriptorSupplier() {}
  }

  private static final class UserLicenseServiceMethodDescriptorSupplier
      extends UserLicenseServiceBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoMethodDescriptorSupplier {
    private final String methodName;

    UserLicenseServiceMethodDescriptorSupplier(String methodName) {
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
      synchronized (UserLicenseServiceGrpc.class) {
        result = serviceDescriptor;
        if (result == null) {
          serviceDescriptor = result = io.grpc.ServiceDescriptor.newBuilder(SERVICE_NAME)
              .setSchemaDescriptor(new UserLicenseServiceFileDescriptorSupplier())
              .addMethod(getGetMethod())
              .build();
        }
      }
    }
    return result;
  }
}
