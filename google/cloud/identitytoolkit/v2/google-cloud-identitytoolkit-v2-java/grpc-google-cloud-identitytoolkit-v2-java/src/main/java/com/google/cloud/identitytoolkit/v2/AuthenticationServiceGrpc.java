package com.google.cloud.identitytoolkit.v2;

import static io.grpc.MethodDescriptor.generateFullMethodName;

/**
 * <pre>
 * Authentication for Identity Toolkit
 * </pre>
 */
@javax.annotation.Generated(
    value = "by gRPC proto compiler",
    comments = "Source: google/cloud/identitytoolkit/v2/authentication_service.proto")
public final class AuthenticationServiceGrpc {

  private AuthenticationServiceGrpc() {}

  public static final String SERVICE_NAME = "google.cloud.identitytoolkit.v2.AuthenticationService";

  // Static method descriptors that strictly reflect the proto.
  private static volatile io.grpc.MethodDescriptor<com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInRequest,
      com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInResponse> getFinalizeMfaSignInMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "FinalizeMfaSignIn",
      requestType = com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInRequest.class,
      responseType = com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInRequest,
      com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInResponse> getFinalizeMfaSignInMethod() {
    io.grpc.MethodDescriptor<com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInRequest, com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInResponse> getFinalizeMfaSignInMethod;
    if ((getFinalizeMfaSignInMethod = AuthenticationServiceGrpc.getFinalizeMfaSignInMethod) == null) {
      synchronized (AuthenticationServiceGrpc.class) {
        if ((getFinalizeMfaSignInMethod = AuthenticationServiceGrpc.getFinalizeMfaSignInMethod) == null) {
          AuthenticationServiceGrpc.getFinalizeMfaSignInMethod = getFinalizeMfaSignInMethod =
              io.grpc.MethodDescriptor.<com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInRequest, com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "FinalizeMfaSignIn"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInResponse.getDefaultInstance()))
              .setSchemaDescriptor(new AuthenticationServiceMethodDescriptorSupplier("FinalizeMfaSignIn"))
              .build();
        }
      }
    }
    return getFinalizeMfaSignInMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.cloud.identitytoolkit.v2.StartMfaSignInRequest,
      com.google.cloud.identitytoolkit.v2.StartMfaSignInResponse> getStartMfaSignInMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "StartMfaSignIn",
      requestType = com.google.cloud.identitytoolkit.v2.StartMfaSignInRequest.class,
      responseType = com.google.cloud.identitytoolkit.v2.StartMfaSignInResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.cloud.identitytoolkit.v2.StartMfaSignInRequest,
      com.google.cloud.identitytoolkit.v2.StartMfaSignInResponse> getStartMfaSignInMethod() {
    io.grpc.MethodDescriptor<com.google.cloud.identitytoolkit.v2.StartMfaSignInRequest, com.google.cloud.identitytoolkit.v2.StartMfaSignInResponse> getStartMfaSignInMethod;
    if ((getStartMfaSignInMethod = AuthenticationServiceGrpc.getStartMfaSignInMethod) == null) {
      synchronized (AuthenticationServiceGrpc.class) {
        if ((getStartMfaSignInMethod = AuthenticationServiceGrpc.getStartMfaSignInMethod) == null) {
          AuthenticationServiceGrpc.getStartMfaSignInMethod = getStartMfaSignInMethod =
              io.grpc.MethodDescriptor.<com.google.cloud.identitytoolkit.v2.StartMfaSignInRequest, com.google.cloud.identitytoolkit.v2.StartMfaSignInResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "StartMfaSignIn"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.identitytoolkit.v2.StartMfaSignInRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.identitytoolkit.v2.StartMfaSignInResponse.getDefaultInstance()))
              .setSchemaDescriptor(new AuthenticationServiceMethodDescriptorSupplier("StartMfaSignIn"))
              .build();
        }
      }
    }
    return getStartMfaSignInMethod;
  }

  /**
   * Creates a new async stub that supports all call types for the service
   */
  public static AuthenticationServiceStub newStub(io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<AuthenticationServiceStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<AuthenticationServiceStub>() {
        @java.lang.Override
        public AuthenticationServiceStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new AuthenticationServiceStub(channel, callOptions);
        }
      };
    return AuthenticationServiceStub.newStub(factory, channel);
  }

  /**
   * Creates a new blocking-style stub that supports unary and streaming output calls on the service
   */
  public static AuthenticationServiceBlockingStub newBlockingStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<AuthenticationServiceBlockingStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<AuthenticationServiceBlockingStub>() {
        @java.lang.Override
        public AuthenticationServiceBlockingStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new AuthenticationServiceBlockingStub(channel, callOptions);
        }
      };
    return AuthenticationServiceBlockingStub.newStub(factory, channel);
  }

  /**
   * Creates a new ListenableFuture-style stub that supports unary calls on the service
   */
  public static AuthenticationServiceFutureStub newFutureStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<AuthenticationServiceFutureStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<AuthenticationServiceFutureStub>() {
        @java.lang.Override
        public AuthenticationServiceFutureStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new AuthenticationServiceFutureStub(channel, callOptions);
        }
      };
    return AuthenticationServiceFutureStub.newStub(factory, channel);
  }

  /**
   * <pre>
   * Authentication for Identity Toolkit
   * </pre>
   */
  public static abstract class AuthenticationServiceImplBase implements io.grpc.BindableService {

    /**
     * <pre>
     * Verifies the MFA challenge and performs sign-in
     * </pre>
     */
    public void finalizeMfaSignIn(com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInResponse> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getFinalizeMfaSignInMethod(), responseObserver);
    }

    /**
     * <pre>
     * Sends the MFA challenge
     * </pre>
     */
    public void startMfaSignIn(com.google.cloud.identitytoolkit.v2.StartMfaSignInRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.identitytoolkit.v2.StartMfaSignInResponse> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getStartMfaSignInMethod(), responseObserver);
    }

    @java.lang.Override public final io.grpc.ServerServiceDefinition bindService() {
      return io.grpc.ServerServiceDefinition.builder(getServiceDescriptor())
          .addMethod(
            getFinalizeMfaSignInMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInRequest,
                com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInResponse>(
                  this, METHODID_FINALIZE_MFA_SIGN_IN)))
          .addMethod(
            getStartMfaSignInMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.cloud.identitytoolkit.v2.StartMfaSignInRequest,
                com.google.cloud.identitytoolkit.v2.StartMfaSignInResponse>(
                  this, METHODID_START_MFA_SIGN_IN)))
          .build();
    }
  }

  /**
   * <pre>
   * Authentication for Identity Toolkit
   * </pre>
   */
  public static final class AuthenticationServiceStub extends io.grpc.stub.AbstractAsyncStub<AuthenticationServiceStub> {
    private AuthenticationServiceStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected AuthenticationServiceStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new AuthenticationServiceStub(channel, callOptions);
    }

    /**
     * <pre>
     * Verifies the MFA challenge and performs sign-in
     * </pre>
     */
    public void finalizeMfaSignIn(com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInResponse> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getFinalizeMfaSignInMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Sends the MFA challenge
     * </pre>
     */
    public void startMfaSignIn(com.google.cloud.identitytoolkit.v2.StartMfaSignInRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.identitytoolkit.v2.StartMfaSignInResponse> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getStartMfaSignInMethod(), getCallOptions()), request, responseObserver);
    }
  }

  /**
   * <pre>
   * Authentication for Identity Toolkit
   * </pre>
   */
  public static final class AuthenticationServiceBlockingStub extends io.grpc.stub.AbstractBlockingStub<AuthenticationServiceBlockingStub> {
    private AuthenticationServiceBlockingStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected AuthenticationServiceBlockingStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new AuthenticationServiceBlockingStub(channel, callOptions);
    }

    /**
     * <pre>
     * Verifies the MFA challenge and performs sign-in
     * </pre>
     */
    public com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInResponse finalizeMfaSignIn(com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getFinalizeMfaSignInMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Sends the MFA challenge
     * </pre>
     */
    public com.google.cloud.identitytoolkit.v2.StartMfaSignInResponse startMfaSignIn(com.google.cloud.identitytoolkit.v2.StartMfaSignInRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getStartMfaSignInMethod(), getCallOptions(), request);
    }
  }

  /**
   * <pre>
   * Authentication for Identity Toolkit
   * </pre>
   */
  public static final class AuthenticationServiceFutureStub extends io.grpc.stub.AbstractFutureStub<AuthenticationServiceFutureStub> {
    private AuthenticationServiceFutureStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected AuthenticationServiceFutureStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new AuthenticationServiceFutureStub(channel, callOptions);
    }

    /**
     * <pre>
     * Verifies the MFA challenge and performs sign-in
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInResponse> finalizeMfaSignIn(
        com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getFinalizeMfaSignInMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Sends the MFA challenge
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.cloud.identitytoolkit.v2.StartMfaSignInResponse> startMfaSignIn(
        com.google.cloud.identitytoolkit.v2.StartMfaSignInRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getStartMfaSignInMethod(), getCallOptions()), request);
    }
  }

  private static final int METHODID_FINALIZE_MFA_SIGN_IN = 0;
  private static final int METHODID_START_MFA_SIGN_IN = 1;

  private static final class MethodHandlers<Req, Resp> implements
      io.grpc.stub.ServerCalls.UnaryMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ServerStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ClientStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.BidiStreamingMethod<Req, Resp> {
    private final AuthenticationServiceImplBase serviceImpl;
    private final int methodId;

    MethodHandlers(AuthenticationServiceImplBase serviceImpl, int methodId) {
      this.serviceImpl = serviceImpl;
      this.methodId = methodId;
    }

    @java.lang.Override
    @java.lang.SuppressWarnings("unchecked")
    public void invoke(Req request, io.grpc.stub.StreamObserver<Resp> responseObserver) {
      switch (methodId) {
        case METHODID_FINALIZE_MFA_SIGN_IN:
          serviceImpl.finalizeMfaSignIn((com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInRequest) request,
              (io.grpc.stub.StreamObserver<com.google.cloud.identitytoolkit.v2.FinalizeMfaSignInResponse>) responseObserver);
          break;
        case METHODID_START_MFA_SIGN_IN:
          serviceImpl.startMfaSignIn((com.google.cloud.identitytoolkit.v2.StartMfaSignInRequest) request,
              (io.grpc.stub.StreamObserver<com.google.cloud.identitytoolkit.v2.StartMfaSignInResponse>) responseObserver);
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

  private static abstract class AuthenticationServiceBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoFileDescriptorSupplier, io.grpc.protobuf.ProtoServiceDescriptorSupplier {
    AuthenticationServiceBaseDescriptorSupplier() {}

    @java.lang.Override
    public com.google.protobuf.Descriptors.FileDescriptor getFileDescriptor() {
      return com.google.cloud.identitytoolkit.v2.AuthenticationServiceOuterClass.getDescriptor();
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.ServiceDescriptor getServiceDescriptor() {
      return getFileDescriptor().findServiceByName("AuthenticationService");
    }
  }

  private static final class AuthenticationServiceFileDescriptorSupplier
      extends AuthenticationServiceBaseDescriptorSupplier {
    AuthenticationServiceFileDescriptorSupplier() {}
  }

  private static final class AuthenticationServiceMethodDescriptorSupplier
      extends AuthenticationServiceBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoMethodDescriptorSupplier {
    private final String methodName;

    AuthenticationServiceMethodDescriptorSupplier(String methodName) {
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
      synchronized (AuthenticationServiceGrpc.class) {
        result = serviceDescriptor;
        if (result == null) {
          serviceDescriptor = result = io.grpc.ServiceDescriptor.newBuilder(SERVICE_NAME)
              .setSchemaDescriptor(new AuthenticationServiceFileDescriptorSupplier())
              .addMethod(getFinalizeMfaSignInMethod())
              .addMethod(getStartMfaSignInMethod())
              .build();
        }
      }
    }
    return result;
  }
}
