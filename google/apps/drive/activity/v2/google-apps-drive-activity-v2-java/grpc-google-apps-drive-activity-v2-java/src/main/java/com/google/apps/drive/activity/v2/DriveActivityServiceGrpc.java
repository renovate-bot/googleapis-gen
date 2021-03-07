package com.google.apps.drive.activity.v2;

import static io.grpc.MethodDescriptor.generateFullMethodName;

/**
 * <pre>
 * Service for querying activity on Drive items. Activity is user
 * or system action on Drive items that happened in the past. A Drive item can
 * be a file or folder, or a Team Drive.
 * </pre>
 */
@javax.annotation.Generated(
    value = "by gRPC proto compiler",
    comments = "Source: google/apps/drive/activity/v2/drive_activity_service.proto")
public final class DriveActivityServiceGrpc {

  private DriveActivityServiceGrpc() {}

  public static final String SERVICE_NAME = "google.apps.drive.activity.v2.DriveActivityService";

  // Static method descriptors that strictly reflect the proto.
  private static volatile io.grpc.MethodDescriptor<com.google.apps.drive.activity.v2.QueryDriveActivityRequest,
      com.google.apps.drive.activity.v2.QueryDriveActivityResponse> getQueryDriveActivityMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "QueryDriveActivity",
      requestType = com.google.apps.drive.activity.v2.QueryDriveActivityRequest.class,
      responseType = com.google.apps.drive.activity.v2.QueryDriveActivityResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.apps.drive.activity.v2.QueryDriveActivityRequest,
      com.google.apps.drive.activity.v2.QueryDriveActivityResponse> getQueryDriveActivityMethod() {
    io.grpc.MethodDescriptor<com.google.apps.drive.activity.v2.QueryDriveActivityRequest, com.google.apps.drive.activity.v2.QueryDriveActivityResponse> getQueryDriveActivityMethod;
    if ((getQueryDriveActivityMethod = DriveActivityServiceGrpc.getQueryDriveActivityMethod) == null) {
      synchronized (DriveActivityServiceGrpc.class) {
        if ((getQueryDriveActivityMethod = DriveActivityServiceGrpc.getQueryDriveActivityMethod) == null) {
          DriveActivityServiceGrpc.getQueryDriveActivityMethod = getQueryDriveActivityMethod =
              io.grpc.MethodDescriptor.<com.google.apps.drive.activity.v2.QueryDriveActivityRequest, com.google.apps.drive.activity.v2.QueryDriveActivityResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "QueryDriveActivity"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.apps.drive.activity.v2.QueryDriveActivityRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.apps.drive.activity.v2.QueryDriveActivityResponse.getDefaultInstance()))
              .setSchemaDescriptor(new DriveActivityServiceMethodDescriptorSupplier("QueryDriveActivity"))
              .build();
        }
      }
    }
    return getQueryDriveActivityMethod;
  }

  /**
   * Creates a new async stub that supports all call types for the service
   */
  public static DriveActivityServiceStub newStub(io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<DriveActivityServiceStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<DriveActivityServiceStub>() {
        @java.lang.Override
        public DriveActivityServiceStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new DriveActivityServiceStub(channel, callOptions);
        }
      };
    return DriveActivityServiceStub.newStub(factory, channel);
  }

  /**
   * Creates a new blocking-style stub that supports unary and streaming output calls on the service
   */
  public static DriveActivityServiceBlockingStub newBlockingStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<DriveActivityServiceBlockingStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<DriveActivityServiceBlockingStub>() {
        @java.lang.Override
        public DriveActivityServiceBlockingStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new DriveActivityServiceBlockingStub(channel, callOptions);
        }
      };
    return DriveActivityServiceBlockingStub.newStub(factory, channel);
  }

  /**
   * Creates a new ListenableFuture-style stub that supports unary calls on the service
   */
  public static DriveActivityServiceFutureStub newFutureStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<DriveActivityServiceFutureStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<DriveActivityServiceFutureStub>() {
        @java.lang.Override
        public DriveActivityServiceFutureStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new DriveActivityServiceFutureStub(channel, callOptions);
        }
      };
    return DriveActivityServiceFutureStub.newStub(factory, channel);
  }

  /**
   * <pre>
   * Service for querying activity on Drive items. Activity is user
   * or system action on Drive items that happened in the past. A Drive item can
   * be a file or folder, or a Team Drive.
   * </pre>
   */
  public static abstract class DriveActivityServiceImplBase implements io.grpc.BindableService {

    /**
     * <pre>
     * Query past activity in Google Drive.
     * </pre>
     */
    public void queryDriveActivity(com.google.apps.drive.activity.v2.QueryDriveActivityRequest request,
        io.grpc.stub.StreamObserver<com.google.apps.drive.activity.v2.QueryDriveActivityResponse> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getQueryDriveActivityMethod(), responseObserver);
    }

    @java.lang.Override public final io.grpc.ServerServiceDefinition bindService() {
      return io.grpc.ServerServiceDefinition.builder(getServiceDescriptor())
          .addMethod(
            getQueryDriveActivityMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.apps.drive.activity.v2.QueryDriveActivityRequest,
                com.google.apps.drive.activity.v2.QueryDriveActivityResponse>(
                  this, METHODID_QUERY_DRIVE_ACTIVITY)))
          .build();
    }
  }

  /**
   * <pre>
   * Service for querying activity on Drive items. Activity is user
   * or system action on Drive items that happened in the past. A Drive item can
   * be a file or folder, or a Team Drive.
   * </pre>
   */
  public static final class DriveActivityServiceStub extends io.grpc.stub.AbstractAsyncStub<DriveActivityServiceStub> {
    private DriveActivityServiceStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected DriveActivityServiceStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new DriveActivityServiceStub(channel, callOptions);
    }

    /**
     * <pre>
     * Query past activity in Google Drive.
     * </pre>
     */
    public void queryDriveActivity(com.google.apps.drive.activity.v2.QueryDriveActivityRequest request,
        io.grpc.stub.StreamObserver<com.google.apps.drive.activity.v2.QueryDriveActivityResponse> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getQueryDriveActivityMethod(), getCallOptions()), request, responseObserver);
    }
  }

  /**
   * <pre>
   * Service for querying activity on Drive items. Activity is user
   * or system action on Drive items that happened in the past. A Drive item can
   * be a file or folder, or a Team Drive.
   * </pre>
   */
  public static final class DriveActivityServiceBlockingStub extends io.grpc.stub.AbstractBlockingStub<DriveActivityServiceBlockingStub> {
    private DriveActivityServiceBlockingStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected DriveActivityServiceBlockingStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new DriveActivityServiceBlockingStub(channel, callOptions);
    }

    /**
     * <pre>
     * Query past activity in Google Drive.
     * </pre>
     */
    public com.google.apps.drive.activity.v2.QueryDriveActivityResponse queryDriveActivity(com.google.apps.drive.activity.v2.QueryDriveActivityRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getQueryDriveActivityMethod(), getCallOptions(), request);
    }
  }

  /**
   * <pre>
   * Service for querying activity on Drive items. Activity is user
   * or system action on Drive items that happened in the past. A Drive item can
   * be a file or folder, or a Team Drive.
   * </pre>
   */
  public static final class DriveActivityServiceFutureStub extends io.grpc.stub.AbstractFutureStub<DriveActivityServiceFutureStub> {
    private DriveActivityServiceFutureStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected DriveActivityServiceFutureStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new DriveActivityServiceFutureStub(channel, callOptions);
    }

    /**
     * <pre>
     * Query past activity in Google Drive.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.apps.drive.activity.v2.QueryDriveActivityResponse> queryDriveActivity(
        com.google.apps.drive.activity.v2.QueryDriveActivityRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getQueryDriveActivityMethod(), getCallOptions()), request);
    }
  }

  private static final int METHODID_QUERY_DRIVE_ACTIVITY = 0;

  private static final class MethodHandlers<Req, Resp> implements
      io.grpc.stub.ServerCalls.UnaryMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ServerStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ClientStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.BidiStreamingMethod<Req, Resp> {
    private final DriveActivityServiceImplBase serviceImpl;
    private final int methodId;

    MethodHandlers(DriveActivityServiceImplBase serviceImpl, int methodId) {
      this.serviceImpl = serviceImpl;
      this.methodId = methodId;
    }

    @java.lang.Override
    @java.lang.SuppressWarnings("unchecked")
    public void invoke(Req request, io.grpc.stub.StreamObserver<Resp> responseObserver) {
      switch (methodId) {
        case METHODID_QUERY_DRIVE_ACTIVITY:
          serviceImpl.queryDriveActivity((com.google.apps.drive.activity.v2.QueryDriveActivityRequest) request,
              (io.grpc.stub.StreamObserver<com.google.apps.drive.activity.v2.QueryDriveActivityResponse>) responseObserver);
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

  private static abstract class DriveActivityServiceBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoFileDescriptorSupplier, io.grpc.protobuf.ProtoServiceDescriptorSupplier {
    DriveActivityServiceBaseDescriptorSupplier() {}

    @java.lang.Override
    public com.google.protobuf.Descriptors.FileDescriptor getFileDescriptor() {
      return com.google.apps.drive.activity.v2.DriveActivityServiceProto.getDescriptor();
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.ServiceDescriptor getServiceDescriptor() {
      return getFileDescriptor().findServiceByName("DriveActivityService");
    }
  }

  private static final class DriveActivityServiceFileDescriptorSupplier
      extends DriveActivityServiceBaseDescriptorSupplier {
    DriveActivityServiceFileDescriptorSupplier() {}
  }

  private static final class DriveActivityServiceMethodDescriptorSupplier
      extends DriveActivityServiceBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoMethodDescriptorSupplier {
    private final String methodName;

    DriveActivityServiceMethodDescriptorSupplier(String methodName) {
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
      synchronized (DriveActivityServiceGrpc.class) {
        result = serviceDescriptor;
        if (result == null) {
          serviceDescriptor = result = io.grpc.ServiceDescriptor.newBuilder(SERVICE_NAME)
              .setSchemaDescriptor(new DriveActivityServiceFileDescriptorSupplier())
              .addMethod(getQueryDriveActivityMethod())
              .build();
        }
      }
    }
    return result;
  }
}
