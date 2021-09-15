package com.google.cloud.identitytoolkit.v2;

import static io.grpc.MethodDescriptor.generateFullMethodName;

/**
 * <pre>
 * Account management for Identity Toolkit
 * </pre>
 */
@javax.annotation.Generated(
    value = "by gRPC proto compiler",
    comments = "Source: google/cloud/identitytoolkit/v2/account_management_service.proto")
public final class AccountManagementServiceGrpc {

  private AccountManagementServiceGrpc() {}

  public static final String SERVICE_NAME = "google.cloud.identitytoolkit.v2.AccountManagementService";

  // Static method descriptors that strictly reflect the proto.
  private static volatile io.grpc.MethodDescriptor<com.google.cloud.identitytoolkit.v2.FinalizeMfaEnrollmentRequest,
      com.google.cloud.identitytoolkit.v2.FinalizeMfaEnrollmentResponse> getFinalizeMfaEnrollmentMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "FinalizeMfaEnrollment",
      requestType = com.google.cloud.identitytoolkit.v2.FinalizeMfaEnrollmentRequest.class,
      responseType = com.google.cloud.identitytoolkit.v2.FinalizeMfaEnrollmentResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.cloud.identitytoolkit.v2.FinalizeMfaEnrollmentRequest,
      com.google.cloud.identitytoolkit.v2.FinalizeMfaEnrollmentResponse> getFinalizeMfaEnrollmentMethod() {
    io.grpc.MethodDescriptor<com.google.cloud.identitytoolkit.v2.FinalizeMfaEnrollmentRequest, com.google.cloud.identitytoolkit.v2.FinalizeMfaEnrollmentResponse> getFinalizeMfaEnrollmentMethod;
    if ((getFinalizeMfaEnrollmentMethod = AccountManagementServiceGrpc.getFinalizeMfaEnrollmentMethod) == null) {
      synchronized (AccountManagementServiceGrpc.class) {
        if ((getFinalizeMfaEnrollmentMethod = AccountManagementServiceGrpc.getFinalizeMfaEnrollmentMethod) == null) {
          AccountManagementServiceGrpc.getFinalizeMfaEnrollmentMethod = getFinalizeMfaEnrollmentMethod =
              io.grpc.MethodDescriptor.<com.google.cloud.identitytoolkit.v2.FinalizeMfaEnrollmentRequest, com.google.cloud.identitytoolkit.v2.FinalizeMfaEnrollmentResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "FinalizeMfaEnrollment"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.identitytoolkit.v2.FinalizeMfaEnrollmentRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.identitytoolkit.v2.FinalizeMfaEnrollmentResponse.getDefaultInstance()))
              .setSchemaDescriptor(new AccountManagementServiceMethodDescriptorSupplier("FinalizeMfaEnrollment"))
              .build();
        }
      }
    }
    return getFinalizeMfaEnrollmentMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentRequest,
      com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentResponse> getStartMfaEnrollmentMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "StartMfaEnrollment",
      requestType = com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentRequest.class,
      responseType = com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentRequest,
      com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentResponse> getStartMfaEnrollmentMethod() {
    io.grpc.MethodDescriptor<com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentRequest, com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentResponse> getStartMfaEnrollmentMethod;
    if ((getStartMfaEnrollmentMethod = AccountManagementServiceGrpc.getStartMfaEnrollmentMethod) == null) {
      synchronized (AccountManagementServiceGrpc.class) {
        if ((getStartMfaEnrollmentMethod = AccountManagementServiceGrpc.getStartMfaEnrollmentMethod) == null) {
          AccountManagementServiceGrpc.getStartMfaEnrollmentMethod = getStartMfaEnrollmentMethod =
              io.grpc.MethodDescriptor.<com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentRequest, com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "StartMfaEnrollment"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentResponse.getDefaultInstance()))
              .setSchemaDescriptor(new AccountManagementServiceMethodDescriptorSupplier("StartMfaEnrollment"))
              .build();
        }
      }
    }
    return getStartMfaEnrollmentMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.cloud.identitytoolkit.v2.WithdrawMfaRequest,
      com.google.cloud.identitytoolkit.v2.WithdrawMfaResponse> getWithdrawMfaMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "WithdrawMfa",
      requestType = com.google.cloud.identitytoolkit.v2.WithdrawMfaRequest.class,
      responseType = com.google.cloud.identitytoolkit.v2.WithdrawMfaResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.cloud.identitytoolkit.v2.WithdrawMfaRequest,
      com.google.cloud.identitytoolkit.v2.WithdrawMfaResponse> getWithdrawMfaMethod() {
    io.grpc.MethodDescriptor<com.google.cloud.identitytoolkit.v2.WithdrawMfaRequest, com.google.cloud.identitytoolkit.v2.WithdrawMfaResponse> getWithdrawMfaMethod;
    if ((getWithdrawMfaMethod = AccountManagementServiceGrpc.getWithdrawMfaMethod) == null) {
      synchronized (AccountManagementServiceGrpc.class) {
        if ((getWithdrawMfaMethod = AccountManagementServiceGrpc.getWithdrawMfaMethod) == null) {
          AccountManagementServiceGrpc.getWithdrawMfaMethod = getWithdrawMfaMethod =
              io.grpc.MethodDescriptor.<com.google.cloud.identitytoolkit.v2.WithdrawMfaRequest, com.google.cloud.identitytoolkit.v2.WithdrawMfaResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "WithdrawMfa"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.identitytoolkit.v2.WithdrawMfaRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.identitytoolkit.v2.WithdrawMfaResponse.getDefaultInstance()))
              .setSchemaDescriptor(new AccountManagementServiceMethodDescriptorSupplier("WithdrawMfa"))
              .build();
        }
      }
    }
    return getWithdrawMfaMethod;
  }

  /**
   * Creates a new async stub that supports all call types for the service
   */
  public static AccountManagementServiceStub newStub(io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<AccountManagementServiceStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<AccountManagementServiceStub>() {
        @java.lang.Override
        public AccountManagementServiceStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new AccountManagementServiceStub(channel, callOptions);
        }
      };
    return AccountManagementServiceStub.newStub(factory, channel);
  }

  /**
   * Creates a new blocking-style stub that supports unary and streaming output calls on the service
   */
  public static AccountManagementServiceBlockingStub newBlockingStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<AccountManagementServiceBlockingStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<AccountManagementServiceBlockingStub>() {
        @java.lang.Override
        public AccountManagementServiceBlockingStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new AccountManagementServiceBlockingStub(channel, callOptions);
        }
      };
    return AccountManagementServiceBlockingStub.newStub(factory, channel);
  }

  /**
   * Creates a new ListenableFuture-style stub that supports unary calls on the service
   */
  public static AccountManagementServiceFutureStub newFutureStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<AccountManagementServiceFutureStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<AccountManagementServiceFutureStub>() {
        @java.lang.Override
        public AccountManagementServiceFutureStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new AccountManagementServiceFutureStub(channel, callOptions);
        }
      };
    return AccountManagementServiceFutureStub.newStub(factory, channel);
  }

  /**
   * <pre>
   * Account management for Identity Toolkit
   * </pre>
   */
  public static abstract class AccountManagementServiceImplBase implements io.grpc.BindableService {

    /**
     * <pre>
     * Finishes enrolling a second factor for the user.
     * </pre>
     */
    public void finalizeMfaEnrollment(com.google.cloud.identitytoolkit.v2.FinalizeMfaEnrollmentRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.identitytoolkit.v2.FinalizeMfaEnrollmentResponse> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getFinalizeMfaEnrollmentMethod(), responseObserver);
    }

    /**
     * <pre>
     * Step one of the MFA enrollment process. In SMS case, this sends an
     * SMS verification code to the user.
     * </pre>
     */
    public void startMfaEnrollment(com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentResponse> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getStartMfaEnrollmentMethod(), responseObserver);
    }

    /**
     * <pre>
     * Revokes one second factor from the enrolled second factors for an account.
     * </pre>
     */
    public void withdrawMfa(com.google.cloud.identitytoolkit.v2.WithdrawMfaRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.identitytoolkit.v2.WithdrawMfaResponse> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getWithdrawMfaMethod(), responseObserver);
    }

    @java.lang.Override public final io.grpc.ServerServiceDefinition bindService() {
      return io.grpc.ServerServiceDefinition.builder(getServiceDescriptor())
          .addMethod(
            getFinalizeMfaEnrollmentMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.cloud.identitytoolkit.v2.FinalizeMfaEnrollmentRequest,
                com.google.cloud.identitytoolkit.v2.FinalizeMfaEnrollmentResponse>(
                  this, METHODID_FINALIZE_MFA_ENROLLMENT)))
          .addMethod(
            getStartMfaEnrollmentMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentRequest,
                com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentResponse>(
                  this, METHODID_START_MFA_ENROLLMENT)))
          .addMethod(
            getWithdrawMfaMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.cloud.identitytoolkit.v2.WithdrawMfaRequest,
                com.google.cloud.identitytoolkit.v2.WithdrawMfaResponse>(
                  this, METHODID_WITHDRAW_MFA)))
          .build();
    }
  }

  /**
   * <pre>
   * Account management for Identity Toolkit
   * </pre>
   */
  public static final class AccountManagementServiceStub extends io.grpc.stub.AbstractAsyncStub<AccountManagementServiceStub> {
    private AccountManagementServiceStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected AccountManagementServiceStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new AccountManagementServiceStub(channel, callOptions);
    }

    /**
     * <pre>
     * Finishes enrolling a second factor for the user.
     * </pre>
     */
    public void finalizeMfaEnrollment(com.google.cloud.identitytoolkit.v2.FinalizeMfaEnrollmentRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.identitytoolkit.v2.FinalizeMfaEnrollmentResponse> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getFinalizeMfaEnrollmentMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Step one of the MFA enrollment process. In SMS case, this sends an
     * SMS verification code to the user.
     * </pre>
     */
    public void startMfaEnrollment(com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentResponse> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getStartMfaEnrollmentMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Revokes one second factor from the enrolled second factors for an account.
     * </pre>
     */
    public void withdrawMfa(com.google.cloud.identitytoolkit.v2.WithdrawMfaRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.identitytoolkit.v2.WithdrawMfaResponse> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getWithdrawMfaMethod(), getCallOptions()), request, responseObserver);
    }
  }

  /**
   * <pre>
   * Account management for Identity Toolkit
   * </pre>
   */
  public static final class AccountManagementServiceBlockingStub extends io.grpc.stub.AbstractBlockingStub<AccountManagementServiceBlockingStub> {
    private AccountManagementServiceBlockingStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected AccountManagementServiceBlockingStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new AccountManagementServiceBlockingStub(channel, callOptions);
    }

    /**
     * <pre>
     * Finishes enrolling a second factor for the user.
     * </pre>
     */
    public com.google.cloud.identitytoolkit.v2.FinalizeMfaEnrollmentResponse finalizeMfaEnrollment(com.google.cloud.identitytoolkit.v2.FinalizeMfaEnrollmentRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getFinalizeMfaEnrollmentMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Step one of the MFA enrollment process. In SMS case, this sends an
     * SMS verification code to the user.
     * </pre>
     */
    public com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentResponse startMfaEnrollment(com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getStartMfaEnrollmentMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Revokes one second factor from the enrolled second factors for an account.
     * </pre>
     */
    public com.google.cloud.identitytoolkit.v2.WithdrawMfaResponse withdrawMfa(com.google.cloud.identitytoolkit.v2.WithdrawMfaRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getWithdrawMfaMethod(), getCallOptions(), request);
    }
  }

  /**
   * <pre>
   * Account management for Identity Toolkit
   * </pre>
   */
  public static final class AccountManagementServiceFutureStub extends io.grpc.stub.AbstractFutureStub<AccountManagementServiceFutureStub> {
    private AccountManagementServiceFutureStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected AccountManagementServiceFutureStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new AccountManagementServiceFutureStub(channel, callOptions);
    }

    /**
     * <pre>
     * Finishes enrolling a second factor for the user.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.cloud.identitytoolkit.v2.FinalizeMfaEnrollmentResponse> finalizeMfaEnrollment(
        com.google.cloud.identitytoolkit.v2.FinalizeMfaEnrollmentRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getFinalizeMfaEnrollmentMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Step one of the MFA enrollment process. In SMS case, this sends an
     * SMS verification code to the user.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentResponse> startMfaEnrollment(
        com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getStartMfaEnrollmentMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Revokes one second factor from the enrolled second factors for an account.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.cloud.identitytoolkit.v2.WithdrawMfaResponse> withdrawMfa(
        com.google.cloud.identitytoolkit.v2.WithdrawMfaRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getWithdrawMfaMethod(), getCallOptions()), request);
    }
  }

  private static final int METHODID_FINALIZE_MFA_ENROLLMENT = 0;
  private static final int METHODID_START_MFA_ENROLLMENT = 1;
  private static final int METHODID_WITHDRAW_MFA = 2;

  private static final class MethodHandlers<Req, Resp> implements
      io.grpc.stub.ServerCalls.UnaryMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ServerStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ClientStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.BidiStreamingMethod<Req, Resp> {
    private final AccountManagementServiceImplBase serviceImpl;
    private final int methodId;

    MethodHandlers(AccountManagementServiceImplBase serviceImpl, int methodId) {
      this.serviceImpl = serviceImpl;
      this.methodId = methodId;
    }

    @java.lang.Override
    @java.lang.SuppressWarnings("unchecked")
    public void invoke(Req request, io.grpc.stub.StreamObserver<Resp> responseObserver) {
      switch (methodId) {
        case METHODID_FINALIZE_MFA_ENROLLMENT:
          serviceImpl.finalizeMfaEnrollment((com.google.cloud.identitytoolkit.v2.FinalizeMfaEnrollmentRequest) request,
              (io.grpc.stub.StreamObserver<com.google.cloud.identitytoolkit.v2.FinalizeMfaEnrollmentResponse>) responseObserver);
          break;
        case METHODID_START_MFA_ENROLLMENT:
          serviceImpl.startMfaEnrollment((com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentRequest) request,
              (io.grpc.stub.StreamObserver<com.google.cloud.identitytoolkit.v2.StartMfaEnrollmentResponse>) responseObserver);
          break;
        case METHODID_WITHDRAW_MFA:
          serviceImpl.withdrawMfa((com.google.cloud.identitytoolkit.v2.WithdrawMfaRequest) request,
              (io.grpc.stub.StreamObserver<com.google.cloud.identitytoolkit.v2.WithdrawMfaResponse>) responseObserver);
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

  private static abstract class AccountManagementServiceBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoFileDescriptorSupplier, io.grpc.protobuf.ProtoServiceDescriptorSupplier {
    AccountManagementServiceBaseDescriptorSupplier() {}

    @java.lang.Override
    public com.google.protobuf.Descriptors.FileDescriptor getFileDescriptor() {
      return com.google.cloud.identitytoolkit.v2.AccountManagementServiceOuterClass.getDescriptor();
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.ServiceDescriptor getServiceDescriptor() {
      return getFileDescriptor().findServiceByName("AccountManagementService");
    }
  }

  private static final class AccountManagementServiceFileDescriptorSupplier
      extends AccountManagementServiceBaseDescriptorSupplier {
    AccountManagementServiceFileDescriptorSupplier() {}
  }

  private static final class AccountManagementServiceMethodDescriptorSupplier
      extends AccountManagementServiceBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoMethodDescriptorSupplier {
    private final String methodName;

    AccountManagementServiceMethodDescriptorSupplier(String methodName) {
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
      synchronized (AccountManagementServiceGrpc.class) {
        result = serviceDescriptor;
        if (result == null) {
          serviceDescriptor = result = io.grpc.ServiceDescriptor.newBuilder(SERVICE_NAME)
              .setSchemaDescriptor(new AccountManagementServiceFileDescriptorSupplier())
              .addMethod(getFinalizeMfaEnrollmentMethod())
              .addMethod(getStartMfaEnrollmentMethod())
              .addMethod(getWithdrawMfaMethod())
              .build();
        }
      }
    }
    return result;
  }
}
