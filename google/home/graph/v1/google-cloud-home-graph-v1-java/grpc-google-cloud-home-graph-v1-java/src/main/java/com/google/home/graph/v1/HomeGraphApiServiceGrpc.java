package com.google.home.graph.v1;

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
 * <pre>
 * Google Home Graph API service. The Home Graph service provides support for
 * accessing first-party and third-party devices stored in Google's Home Graph.
 * The Home Graph database provides contextual data about the relationships
 * between devices and the home.
 * For more details, see the [Home Graph developer
 * guide](https://developers.google.com/assistant/smarthome/concepts/homegraph).
 * </pre>
 */
@javax.annotation.Generated(
    value = "by gRPC proto compiler",
    comments = "Source: google/home/graph/v1/homegraph.proto")
public final class HomeGraphApiServiceGrpc {

  private HomeGraphApiServiceGrpc() {}

  public static final String SERVICE_NAME = "google.home.graph.v1.HomeGraphApiService";

  // Static method descriptors that strictly reflect the proto.
  private static volatile io.grpc.MethodDescriptor<com.google.home.graph.v1.HomeGraphApiServiceProto.RequestSyncDevicesRequest,
      com.google.home.graph.v1.HomeGraphApiServiceProto.RequestSyncDevicesResponse> getRequestSyncDevicesMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "RequestSyncDevices",
      requestType = com.google.home.graph.v1.HomeGraphApiServiceProto.RequestSyncDevicesRequest.class,
      responseType = com.google.home.graph.v1.HomeGraphApiServiceProto.RequestSyncDevicesResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.home.graph.v1.HomeGraphApiServiceProto.RequestSyncDevicesRequest,
      com.google.home.graph.v1.HomeGraphApiServiceProto.RequestSyncDevicesResponse> getRequestSyncDevicesMethod() {
    io.grpc.MethodDescriptor<com.google.home.graph.v1.HomeGraphApiServiceProto.RequestSyncDevicesRequest, com.google.home.graph.v1.HomeGraphApiServiceProto.RequestSyncDevicesResponse> getRequestSyncDevicesMethod;
    if ((getRequestSyncDevicesMethod = HomeGraphApiServiceGrpc.getRequestSyncDevicesMethod) == null) {
      synchronized (HomeGraphApiServiceGrpc.class) {
        if ((getRequestSyncDevicesMethod = HomeGraphApiServiceGrpc.getRequestSyncDevicesMethod) == null) {
          HomeGraphApiServiceGrpc.getRequestSyncDevicesMethod = getRequestSyncDevicesMethod =
              io.grpc.MethodDescriptor.<com.google.home.graph.v1.HomeGraphApiServiceProto.RequestSyncDevicesRequest, com.google.home.graph.v1.HomeGraphApiServiceProto.RequestSyncDevicesResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "RequestSyncDevices"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.home.graph.v1.HomeGraphApiServiceProto.RequestSyncDevicesRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.home.graph.v1.HomeGraphApiServiceProto.RequestSyncDevicesResponse.getDefaultInstance()))
              .setSchemaDescriptor(new HomeGraphApiServiceMethodDescriptorSupplier("RequestSyncDevices"))
              .build();
        }
      }
    }
    return getRequestSyncDevicesMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.home.graph.v1.HomeGraphApiServiceProto.ReportStateAndNotificationRequest,
      com.google.home.graph.v1.HomeGraphApiServiceProto.ReportStateAndNotificationResponse> getReportStateAndNotificationMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "ReportStateAndNotification",
      requestType = com.google.home.graph.v1.HomeGraphApiServiceProto.ReportStateAndNotificationRequest.class,
      responseType = com.google.home.graph.v1.HomeGraphApiServiceProto.ReportStateAndNotificationResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.home.graph.v1.HomeGraphApiServiceProto.ReportStateAndNotificationRequest,
      com.google.home.graph.v1.HomeGraphApiServiceProto.ReportStateAndNotificationResponse> getReportStateAndNotificationMethod() {
    io.grpc.MethodDescriptor<com.google.home.graph.v1.HomeGraphApiServiceProto.ReportStateAndNotificationRequest, com.google.home.graph.v1.HomeGraphApiServiceProto.ReportStateAndNotificationResponse> getReportStateAndNotificationMethod;
    if ((getReportStateAndNotificationMethod = HomeGraphApiServiceGrpc.getReportStateAndNotificationMethod) == null) {
      synchronized (HomeGraphApiServiceGrpc.class) {
        if ((getReportStateAndNotificationMethod = HomeGraphApiServiceGrpc.getReportStateAndNotificationMethod) == null) {
          HomeGraphApiServiceGrpc.getReportStateAndNotificationMethod = getReportStateAndNotificationMethod =
              io.grpc.MethodDescriptor.<com.google.home.graph.v1.HomeGraphApiServiceProto.ReportStateAndNotificationRequest, com.google.home.graph.v1.HomeGraphApiServiceProto.ReportStateAndNotificationResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "ReportStateAndNotification"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.home.graph.v1.HomeGraphApiServiceProto.ReportStateAndNotificationRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.home.graph.v1.HomeGraphApiServiceProto.ReportStateAndNotificationResponse.getDefaultInstance()))
              .setSchemaDescriptor(new HomeGraphApiServiceMethodDescriptorSupplier("ReportStateAndNotification"))
              .build();
        }
      }
    }
    return getReportStateAndNotificationMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.home.graph.v1.HomeGraphApiServiceProto.DeleteAgentUserRequest,
      com.google.protobuf.Empty> getDeleteAgentUserMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "DeleteAgentUser",
      requestType = com.google.home.graph.v1.HomeGraphApiServiceProto.DeleteAgentUserRequest.class,
      responseType = com.google.protobuf.Empty.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.home.graph.v1.HomeGraphApiServiceProto.DeleteAgentUserRequest,
      com.google.protobuf.Empty> getDeleteAgentUserMethod() {
    io.grpc.MethodDescriptor<com.google.home.graph.v1.HomeGraphApiServiceProto.DeleteAgentUserRequest, com.google.protobuf.Empty> getDeleteAgentUserMethod;
    if ((getDeleteAgentUserMethod = HomeGraphApiServiceGrpc.getDeleteAgentUserMethod) == null) {
      synchronized (HomeGraphApiServiceGrpc.class) {
        if ((getDeleteAgentUserMethod = HomeGraphApiServiceGrpc.getDeleteAgentUserMethod) == null) {
          HomeGraphApiServiceGrpc.getDeleteAgentUserMethod = getDeleteAgentUserMethod =
              io.grpc.MethodDescriptor.<com.google.home.graph.v1.HomeGraphApiServiceProto.DeleteAgentUserRequest, com.google.protobuf.Empty>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "DeleteAgentUser"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.home.graph.v1.HomeGraphApiServiceProto.DeleteAgentUserRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.protobuf.Empty.getDefaultInstance()))
              .setSchemaDescriptor(new HomeGraphApiServiceMethodDescriptorSupplier("DeleteAgentUser"))
              .build();
        }
      }
    }
    return getDeleteAgentUserMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.home.graph.v1.HomeGraphApiServiceProto.QueryRequest,
      com.google.home.graph.v1.HomeGraphApiServiceProto.QueryResponse> getQueryMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "Query",
      requestType = com.google.home.graph.v1.HomeGraphApiServiceProto.QueryRequest.class,
      responseType = com.google.home.graph.v1.HomeGraphApiServiceProto.QueryResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.home.graph.v1.HomeGraphApiServiceProto.QueryRequest,
      com.google.home.graph.v1.HomeGraphApiServiceProto.QueryResponse> getQueryMethod() {
    io.grpc.MethodDescriptor<com.google.home.graph.v1.HomeGraphApiServiceProto.QueryRequest, com.google.home.graph.v1.HomeGraphApiServiceProto.QueryResponse> getQueryMethod;
    if ((getQueryMethod = HomeGraphApiServiceGrpc.getQueryMethod) == null) {
      synchronized (HomeGraphApiServiceGrpc.class) {
        if ((getQueryMethod = HomeGraphApiServiceGrpc.getQueryMethod) == null) {
          HomeGraphApiServiceGrpc.getQueryMethod = getQueryMethod =
              io.grpc.MethodDescriptor.<com.google.home.graph.v1.HomeGraphApiServiceProto.QueryRequest, com.google.home.graph.v1.HomeGraphApiServiceProto.QueryResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "Query"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.home.graph.v1.HomeGraphApiServiceProto.QueryRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.home.graph.v1.HomeGraphApiServiceProto.QueryResponse.getDefaultInstance()))
              .setSchemaDescriptor(new HomeGraphApiServiceMethodDescriptorSupplier("Query"))
              .build();
        }
      }
    }
    return getQueryMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.home.graph.v1.HomeGraphApiServiceProto.SyncRequest,
      com.google.home.graph.v1.HomeGraphApiServiceProto.SyncResponse> getSyncMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "Sync",
      requestType = com.google.home.graph.v1.HomeGraphApiServiceProto.SyncRequest.class,
      responseType = com.google.home.graph.v1.HomeGraphApiServiceProto.SyncResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.home.graph.v1.HomeGraphApiServiceProto.SyncRequest,
      com.google.home.graph.v1.HomeGraphApiServiceProto.SyncResponse> getSyncMethod() {
    io.grpc.MethodDescriptor<com.google.home.graph.v1.HomeGraphApiServiceProto.SyncRequest, com.google.home.graph.v1.HomeGraphApiServiceProto.SyncResponse> getSyncMethod;
    if ((getSyncMethod = HomeGraphApiServiceGrpc.getSyncMethod) == null) {
      synchronized (HomeGraphApiServiceGrpc.class) {
        if ((getSyncMethod = HomeGraphApiServiceGrpc.getSyncMethod) == null) {
          HomeGraphApiServiceGrpc.getSyncMethod = getSyncMethod =
              io.grpc.MethodDescriptor.<com.google.home.graph.v1.HomeGraphApiServiceProto.SyncRequest, com.google.home.graph.v1.HomeGraphApiServiceProto.SyncResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "Sync"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.home.graph.v1.HomeGraphApiServiceProto.SyncRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.home.graph.v1.HomeGraphApiServiceProto.SyncResponse.getDefaultInstance()))
              .setSchemaDescriptor(new HomeGraphApiServiceMethodDescriptorSupplier("Sync"))
              .build();
        }
      }
    }
    return getSyncMethod;
  }

  /**
   * Creates a new async stub that supports all call types for the service
   */
  public static HomeGraphApiServiceStub newStub(io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<HomeGraphApiServiceStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<HomeGraphApiServiceStub>() {
        @java.lang.Override
        public HomeGraphApiServiceStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new HomeGraphApiServiceStub(channel, callOptions);
        }
      };
    return HomeGraphApiServiceStub.newStub(factory, channel);
  }

  /**
   * Creates a new blocking-style stub that supports unary and streaming output calls on the service
   */
  public static HomeGraphApiServiceBlockingStub newBlockingStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<HomeGraphApiServiceBlockingStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<HomeGraphApiServiceBlockingStub>() {
        @java.lang.Override
        public HomeGraphApiServiceBlockingStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new HomeGraphApiServiceBlockingStub(channel, callOptions);
        }
      };
    return HomeGraphApiServiceBlockingStub.newStub(factory, channel);
  }

  /**
   * Creates a new ListenableFuture-style stub that supports unary calls on the service
   */
  public static HomeGraphApiServiceFutureStub newFutureStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<HomeGraphApiServiceFutureStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<HomeGraphApiServiceFutureStub>() {
        @java.lang.Override
        public HomeGraphApiServiceFutureStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new HomeGraphApiServiceFutureStub(channel, callOptions);
        }
      };
    return HomeGraphApiServiceFutureStub.newStub(factory, channel);
  }

  /**
   * <pre>
   * Google Home Graph API service. The Home Graph service provides support for
   * accessing first-party and third-party devices stored in Google's Home Graph.
   * The Home Graph database provides contextual data about the relationships
   * between devices and the home.
   * For more details, see the [Home Graph developer
   * guide](https://developers.google.com/assistant/smarthome/concepts/homegraph).
   * </pre>
   */
  public static abstract class HomeGraphApiServiceImplBase implements io.grpc.BindableService {

    /**
     * <pre>
     * Requests Google to send an `action.devices.SYNC`
     * [intent](https://developers.google.com/assistant/smarthome/reference/intent/sync)
     * to your smart home Action to update device metadata for the given user.
     * The third-party user's identity is passed via the `agent_user_id`
     * (see
     * [RequestSyncDevicesRequest][google.home.graph.v1.RequestSyncDevicesRequest]).
     * This request must be authorized using service account credentials from your
     * Actions console project.
     * </pre>
     */
    public void requestSyncDevices(com.google.home.graph.v1.HomeGraphApiServiceProto.RequestSyncDevicesRequest request,
        io.grpc.stub.StreamObserver<com.google.home.graph.v1.HomeGraphApiServiceProto.RequestSyncDevicesResponse> responseObserver) {
      asyncUnimplementedUnaryCall(getRequestSyncDevicesMethod(), responseObserver);
    }

    /**
     * <pre>
     * Reports device state and optionally sends device notifications.
     * Called by your smart home Action when the state of a third-party device
     * changes or you need to send a notification about the device.
     * See [Implement Report
     * State](https://developers.google.com/assistant/smarthome/develop/report-state)
     * for more information.
     * This method updates the device state according to its declared
     * [traits](https://developers.google.com/assistant/smarthome/concepts/devices-traits).
     * Publishing a new state value outside of these traits will result in an
     * `INVALID_ARGUMENT` error response.
     * The third-party user's identity is passed in via the `agent_user_id`
     * (see
     * [ReportStateAndNotificationRequest][google.home.graph.v1.ReportStateAndNotificationRequest]).
     * This request must be authorized using service account credentials from your
     * Actions console project.
     * </pre>
     */
    public void reportStateAndNotification(com.google.home.graph.v1.HomeGraphApiServiceProto.ReportStateAndNotificationRequest request,
        io.grpc.stub.StreamObserver<com.google.home.graph.v1.HomeGraphApiServiceProto.ReportStateAndNotificationResponse> responseObserver) {
      asyncUnimplementedUnaryCall(getReportStateAndNotificationMethod(), responseObserver);
    }

    /**
     * <pre>
     * Unlinks the given third-party user from your smart home Action.
     * All data related to this user will be deleted.
     * For more details on how users link their accounts, see
     * [fulfillment and
     * authentication](https://developers.google.com/assistant/smarthome/concepts/fulfillment-authentication).
     * The third-party user's identity is passed in via the `agent_user_id`
     * (see
     * [DeleteAgentUserRequest][google.home.graph.v1.DeleteAgentUserRequest]).
     * This request must be authorized using service account credentials from your
     * Actions console project.
     * </pre>
     */
    public void deleteAgentUser(com.google.home.graph.v1.HomeGraphApiServiceProto.DeleteAgentUserRequest request,
        io.grpc.stub.StreamObserver<com.google.protobuf.Empty> responseObserver) {
      asyncUnimplementedUnaryCall(getDeleteAgentUserMethod(), responseObserver);
    }

    /**
     * <pre>
     * Gets the current states in Home Graph for the given set of the third-party
     * user's devices.
     * The third-party user's identity is passed in via the `agent_user_id`
     * (see [QueryRequest][google.home.graph.v1.QueryRequest]).
     * This request must be authorized using service account credentials from your
     * Actions console project.
     * </pre>
     */
    public void query(com.google.home.graph.v1.HomeGraphApiServiceProto.QueryRequest request,
        io.grpc.stub.StreamObserver<com.google.home.graph.v1.HomeGraphApiServiceProto.QueryResponse> responseObserver) {
      asyncUnimplementedUnaryCall(getQueryMethod(), responseObserver);
    }

    /**
     * <pre>
     * Gets all the devices associated with the given third-party user.
     * The third-party user's identity is passed in via the `agent_user_id`
     * (see [SyncRequest][google.home.graph.v1.SyncRequest]).
     * This request must be authorized using service account credentials from your
     * Actions console project.
     * </pre>
     */
    public void sync(com.google.home.graph.v1.HomeGraphApiServiceProto.SyncRequest request,
        io.grpc.stub.StreamObserver<com.google.home.graph.v1.HomeGraphApiServiceProto.SyncResponse> responseObserver) {
      asyncUnimplementedUnaryCall(getSyncMethod(), responseObserver);
    }

    @java.lang.Override public final io.grpc.ServerServiceDefinition bindService() {
      return io.grpc.ServerServiceDefinition.builder(getServiceDescriptor())
          .addMethod(
            getRequestSyncDevicesMethod(),
            asyncUnaryCall(
              new MethodHandlers<
                com.google.home.graph.v1.HomeGraphApiServiceProto.RequestSyncDevicesRequest,
                com.google.home.graph.v1.HomeGraphApiServiceProto.RequestSyncDevicesResponse>(
                  this, METHODID_REQUEST_SYNC_DEVICES)))
          .addMethod(
            getReportStateAndNotificationMethod(),
            asyncUnaryCall(
              new MethodHandlers<
                com.google.home.graph.v1.HomeGraphApiServiceProto.ReportStateAndNotificationRequest,
                com.google.home.graph.v1.HomeGraphApiServiceProto.ReportStateAndNotificationResponse>(
                  this, METHODID_REPORT_STATE_AND_NOTIFICATION)))
          .addMethod(
            getDeleteAgentUserMethod(),
            asyncUnaryCall(
              new MethodHandlers<
                com.google.home.graph.v1.HomeGraphApiServiceProto.DeleteAgentUserRequest,
                com.google.protobuf.Empty>(
                  this, METHODID_DELETE_AGENT_USER)))
          .addMethod(
            getQueryMethod(),
            asyncUnaryCall(
              new MethodHandlers<
                com.google.home.graph.v1.HomeGraphApiServiceProto.QueryRequest,
                com.google.home.graph.v1.HomeGraphApiServiceProto.QueryResponse>(
                  this, METHODID_QUERY)))
          .addMethod(
            getSyncMethod(),
            asyncUnaryCall(
              new MethodHandlers<
                com.google.home.graph.v1.HomeGraphApiServiceProto.SyncRequest,
                com.google.home.graph.v1.HomeGraphApiServiceProto.SyncResponse>(
                  this, METHODID_SYNC)))
          .build();
    }
  }

  /**
   * <pre>
   * Google Home Graph API service. The Home Graph service provides support for
   * accessing first-party and third-party devices stored in Google's Home Graph.
   * The Home Graph database provides contextual data about the relationships
   * between devices and the home.
   * For more details, see the [Home Graph developer
   * guide](https://developers.google.com/assistant/smarthome/concepts/homegraph).
   * </pre>
   */
  public static final class HomeGraphApiServiceStub extends io.grpc.stub.AbstractAsyncStub<HomeGraphApiServiceStub> {
    private HomeGraphApiServiceStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected HomeGraphApiServiceStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new HomeGraphApiServiceStub(channel, callOptions);
    }

    /**
     * <pre>
     * Requests Google to send an `action.devices.SYNC`
     * [intent](https://developers.google.com/assistant/smarthome/reference/intent/sync)
     * to your smart home Action to update device metadata for the given user.
     * The third-party user's identity is passed via the `agent_user_id`
     * (see
     * [RequestSyncDevicesRequest][google.home.graph.v1.RequestSyncDevicesRequest]).
     * This request must be authorized using service account credentials from your
     * Actions console project.
     * </pre>
     */
    public void requestSyncDevices(com.google.home.graph.v1.HomeGraphApiServiceProto.RequestSyncDevicesRequest request,
        io.grpc.stub.StreamObserver<com.google.home.graph.v1.HomeGraphApiServiceProto.RequestSyncDevicesResponse> responseObserver) {
      asyncUnaryCall(
          getChannel().newCall(getRequestSyncDevicesMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Reports device state and optionally sends device notifications.
     * Called by your smart home Action when the state of a third-party device
     * changes or you need to send a notification about the device.
     * See [Implement Report
     * State](https://developers.google.com/assistant/smarthome/develop/report-state)
     * for more information.
     * This method updates the device state according to its declared
     * [traits](https://developers.google.com/assistant/smarthome/concepts/devices-traits).
     * Publishing a new state value outside of these traits will result in an
     * `INVALID_ARGUMENT` error response.
     * The third-party user's identity is passed in via the `agent_user_id`
     * (see
     * [ReportStateAndNotificationRequest][google.home.graph.v1.ReportStateAndNotificationRequest]).
     * This request must be authorized using service account credentials from your
     * Actions console project.
     * </pre>
     */
    public void reportStateAndNotification(com.google.home.graph.v1.HomeGraphApiServiceProto.ReportStateAndNotificationRequest request,
        io.grpc.stub.StreamObserver<com.google.home.graph.v1.HomeGraphApiServiceProto.ReportStateAndNotificationResponse> responseObserver) {
      asyncUnaryCall(
          getChannel().newCall(getReportStateAndNotificationMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Unlinks the given third-party user from your smart home Action.
     * All data related to this user will be deleted.
     * For more details on how users link their accounts, see
     * [fulfillment and
     * authentication](https://developers.google.com/assistant/smarthome/concepts/fulfillment-authentication).
     * The third-party user's identity is passed in via the `agent_user_id`
     * (see
     * [DeleteAgentUserRequest][google.home.graph.v1.DeleteAgentUserRequest]).
     * This request must be authorized using service account credentials from your
     * Actions console project.
     * </pre>
     */
    public void deleteAgentUser(com.google.home.graph.v1.HomeGraphApiServiceProto.DeleteAgentUserRequest request,
        io.grpc.stub.StreamObserver<com.google.protobuf.Empty> responseObserver) {
      asyncUnaryCall(
          getChannel().newCall(getDeleteAgentUserMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Gets the current states in Home Graph for the given set of the third-party
     * user's devices.
     * The third-party user's identity is passed in via the `agent_user_id`
     * (see [QueryRequest][google.home.graph.v1.QueryRequest]).
     * This request must be authorized using service account credentials from your
     * Actions console project.
     * </pre>
     */
    public void query(com.google.home.graph.v1.HomeGraphApiServiceProto.QueryRequest request,
        io.grpc.stub.StreamObserver<com.google.home.graph.v1.HomeGraphApiServiceProto.QueryResponse> responseObserver) {
      asyncUnaryCall(
          getChannel().newCall(getQueryMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Gets all the devices associated with the given third-party user.
     * The third-party user's identity is passed in via the `agent_user_id`
     * (see [SyncRequest][google.home.graph.v1.SyncRequest]).
     * This request must be authorized using service account credentials from your
     * Actions console project.
     * </pre>
     */
    public void sync(com.google.home.graph.v1.HomeGraphApiServiceProto.SyncRequest request,
        io.grpc.stub.StreamObserver<com.google.home.graph.v1.HomeGraphApiServiceProto.SyncResponse> responseObserver) {
      asyncUnaryCall(
          getChannel().newCall(getSyncMethod(), getCallOptions()), request, responseObserver);
    }
  }

  /**
   * <pre>
   * Google Home Graph API service. The Home Graph service provides support for
   * accessing first-party and third-party devices stored in Google's Home Graph.
   * The Home Graph database provides contextual data about the relationships
   * between devices and the home.
   * For more details, see the [Home Graph developer
   * guide](https://developers.google.com/assistant/smarthome/concepts/homegraph).
   * </pre>
   */
  public static final class HomeGraphApiServiceBlockingStub extends io.grpc.stub.AbstractBlockingStub<HomeGraphApiServiceBlockingStub> {
    private HomeGraphApiServiceBlockingStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected HomeGraphApiServiceBlockingStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new HomeGraphApiServiceBlockingStub(channel, callOptions);
    }

    /**
     * <pre>
     * Requests Google to send an `action.devices.SYNC`
     * [intent](https://developers.google.com/assistant/smarthome/reference/intent/sync)
     * to your smart home Action to update device metadata for the given user.
     * The third-party user's identity is passed via the `agent_user_id`
     * (see
     * [RequestSyncDevicesRequest][google.home.graph.v1.RequestSyncDevicesRequest]).
     * This request must be authorized using service account credentials from your
     * Actions console project.
     * </pre>
     */
    public com.google.home.graph.v1.HomeGraphApiServiceProto.RequestSyncDevicesResponse requestSyncDevices(com.google.home.graph.v1.HomeGraphApiServiceProto.RequestSyncDevicesRequest request) {
      return blockingUnaryCall(
          getChannel(), getRequestSyncDevicesMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Reports device state and optionally sends device notifications.
     * Called by your smart home Action when the state of a third-party device
     * changes or you need to send a notification about the device.
     * See [Implement Report
     * State](https://developers.google.com/assistant/smarthome/develop/report-state)
     * for more information.
     * This method updates the device state according to its declared
     * [traits](https://developers.google.com/assistant/smarthome/concepts/devices-traits).
     * Publishing a new state value outside of these traits will result in an
     * `INVALID_ARGUMENT` error response.
     * The third-party user's identity is passed in via the `agent_user_id`
     * (see
     * [ReportStateAndNotificationRequest][google.home.graph.v1.ReportStateAndNotificationRequest]).
     * This request must be authorized using service account credentials from your
     * Actions console project.
     * </pre>
     */
    public com.google.home.graph.v1.HomeGraphApiServiceProto.ReportStateAndNotificationResponse reportStateAndNotification(com.google.home.graph.v1.HomeGraphApiServiceProto.ReportStateAndNotificationRequest request) {
      return blockingUnaryCall(
          getChannel(), getReportStateAndNotificationMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Unlinks the given third-party user from your smart home Action.
     * All data related to this user will be deleted.
     * For more details on how users link their accounts, see
     * [fulfillment and
     * authentication](https://developers.google.com/assistant/smarthome/concepts/fulfillment-authentication).
     * The third-party user's identity is passed in via the `agent_user_id`
     * (see
     * [DeleteAgentUserRequest][google.home.graph.v1.DeleteAgentUserRequest]).
     * This request must be authorized using service account credentials from your
     * Actions console project.
     * </pre>
     */
    public com.google.protobuf.Empty deleteAgentUser(com.google.home.graph.v1.HomeGraphApiServiceProto.DeleteAgentUserRequest request) {
      return blockingUnaryCall(
          getChannel(), getDeleteAgentUserMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Gets the current states in Home Graph for the given set of the third-party
     * user's devices.
     * The third-party user's identity is passed in via the `agent_user_id`
     * (see [QueryRequest][google.home.graph.v1.QueryRequest]).
     * This request must be authorized using service account credentials from your
     * Actions console project.
     * </pre>
     */
    public com.google.home.graph.v1.HomeGraphApiServiceProto.QueryResponse query(com.google.home.graph.v1.HomeGraphApiServiceProto.QueryRequest request) {
      return blockingUnaryCall(
          getChannel(), getQueryMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Gets all the devices associated with the given third-party user.
     * The third-party user's identity is passed in via the `agent_user_id`
     * (see [SyncRequest][google.home.graph.v1.SyncRequest]).
     * This request must be authorized using service account credentials from your
     * Actions console project.
     * </pre>
     */
    public com.google.home.graph.v1.HomeGraphApiServiceProto.SyncResponse sync(com.google.home.graph.v1.HomeGraphApiServiceProto.SyncRequest request) {
      return blockingUnaryCall(
          getChannel(), getSyncMethod(), getCallOptions(), request);
    }
  }

  /**
   * <pre>
   * Google Home Graph API service. The Home Graph service provides support for
   * accessing first-party and third-party devices stored in Google's Home Graph.
   * The Home Graph database provides contextual data about the relationships
   * between devices and the home.
   * For more details, see the [Home Graph developer
   * guide](https://developers.google.com/assistant/smarthome/concepts/homegraph).
   * </pre>
   */
  public static final class HomeGraphApiServiceFutureStub extends io.grpc.stub.AbstractFutureStub<HomeGraphApiServiceFutureStub> {
    private HomeGraphApiServiceFutureStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected HomeGraphApiServiceFutureStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new HomeGraphApiServiceFutureStub(channel, callOptions);
    }

    /**
     * <pre>
     * Requests Google to send an `action.devices.SYNC`
     * [intent](https://developers.google.com/assistant/smarthome/reference/intent/sync)
     * to your smart home Action to update device metadata for the given user.
     * The third-party user's identity is passed via the `agent_user_id`
     * (see
     * [RequestSyncDevicesRequest][google.home.graph.v1.RequestSyncDevicesRequest]).
     * This request must be authorized using service account credentials from your
     * Actions console project.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.home.graph.v1.HomeGraphApiServiceProto.RequestSyncDevicesResponse> requestSyncDevices(
        com.google.home.graph.v1.HomeGraphApiServiceProto.RequestSyncDevicesRequest request) {
      return futureUnaryCall(
          getChannel().newCall(getRequestSyncDevicesMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Reports device state and optionally sends device notifications.
     * Called by your smart home Action when the state of a third-party device
     * changes or you need to send a notification about the device.
     * See [Implement Report
     * State](https://developers.google.com/assistant/smarthome/develop/report-state)
     * for more information.
     * This method updates the device state according to its declared
     * [traits](https://developers.google.com/assistant/smarthome/concepts/devices-traits).
     * Publishing a new state value outside of these traits will result in an
     * `INVALID_ARGUMENT` error response.
     * The third-party user's identity is passed in via the `agent_user_id`
     * (see
     * [ReportStateAndNotificationRequest][google.home.graph.v1.ReportStateAndNotificationRequest]).
     * This request must be authorized using service account credentials from your
     * Actions console project.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.home.graph.v1.HomeGraphApiServiceProto.ReportStateAndNotificationResponse> reportStateAndNotification(
        com.google.home.graph.v1.HomeGraphApiServiceProto.ReportStateAndNotificationRequest request) {
      return futureUnaryCall(
          getChannel().newCall(getReportStateAndNotificationMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Unlinks the given third-party user from your smart home Action.
     * All data related to this user will be deleted.
     * For more details on how users link their accounts, see
     * [fulfillment and
     * authentication](https://developers.google.com/assistant/smarthome/concepts/fulfillment-authentication).
     * The third-party user's identity is passed in via the `agent_user_id`
     * (see
     * [DeleteAgentUserRequest][google.home.graph.v1.DeleteAgentUserRequest]).
     * This request must be authorized using service account credentials from your
     * Actions console project.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.protobuf.Empty> deleteAgentUser(
        com.google.home.graph.v1.HomeGraphApiServiceProto.DeleteAgentUserRequest request) {
      return futureUnaryCall(
          getChannel().newCall(getDeleteAgentUserMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Gets the current states in Home Graph for the given set of the third-party
     * user's devices.
     * The third-party user's identity is passed in via the `agent_user_id`
     * (see [QueryRequest][google.home.graph.v1.QueryRequest]).
     * This request must be authorized using service account credentials from your
     * Actions console project.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.home.graph.v1.HomeGraphApiServiceProto.QueryResponse> query(
        com.google.home.graph.v1.HomeGraphApiServiceProto.QueryRequest request) {
      return futureUnaryCall(
          getChannel().newCall(getQueryMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Gets all the devices associated with the given third-party user.
     * The third-party user's identity is passed in via the `agent_user_id`
     * (see [SyncRequest][google.home.graph.v1.SyncRequest]).
     * This request must be authorized using service account credentials from your
     * Actions console project.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.home.graph.v1.HomeGraphApiServiceProto.SyncResponse> sync(
        com.google.home.graph.v1.HomeGraphApiServiceProto.SyncRequest request) {
      return futureUnaryCall(
          getChannel().newCall(getSyncMethod(), getCallOptions()), request);
    }
  }

  private static final int METHODID_REQUEST_SYNC_DEVICES = 0;
  private static final int METHODID_REPORT_STATE_AND_NOTIFICATION = 1;
  private static final int METHODID_DELETE_AGENT_USER = 2;
  private static final int METHODID_QUERY = 3;
  private static final int METHODID_SYNC = 4;

  private static final class MethodHandlers<Req, Resp> implements
      io.grpc.stub.ServerCalls.UnaryMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ServerStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ClientStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.BidiStreamingMethod<Req, Resp> {
    private final HomeGraphApiServiceImplBase serviceImpl;
    private final int methodId;

    MethodHandlers(HomeGraphApiServiceImplBase serviceImpl, int methodId) {
      this.serviceImpl = serviceImpl;
      this.methodId = methodId;
    }

    @java.lang.Override
    @java.lang.SuppressWarnings("unchecked")
    public void invoke(Req request, io.grpc.stub.StreamObserver<Resp> responseObserver) {
      switch (methodId) {
        case METHODID_REQUEST_SYNC_DEVICES:
          serviceImpl.requestSyncDevices((com.google.home.graph.v1.HomeGraphApiServiceProto.RequestSyncDevicesRequest) request,
              (io.grpc.stub.StreamObserver<com.google.home.graph.v1.HomeGraphApiServiceProto.RequestSyncDevicesResponse>) responseObserver);
          break;
        case METHODID_REPORT_STATE_AND_NOTIFICATION:
          serviceImpl.reportStateAndNotification((com.google.home.graph.v1.HomeGraphApiServiceProto.ReportStateAndNotificationRequest) request,
              (io.grpc.stub.StreamObserver<com.google.home.graph.v1.HomeGraphApiServiceProto.ReportStateAndNotificationResponse>) responseObserver);
          break;
        case METHODID_DELETE_AGENT_USER:
          serviceImpl.deleteAgentUser((com.google.home.graph.v1.HomeGraphApiServiceProto.DeleteAgentUserRequest) request,
              (io.grpc.stub.StreamObserver<com.google.protobuf.Empty>) responseObserver);
          break;
        case METHODID_QUERY:
          serviceImpl.query((com.google.home.graph.v1.HomeGraphApiServiceProto.QueryRequest) request,
              (io.grpc.stub.StreamObserver<com.google.home.graph.v1.HomeGraphApiServiceProto.QueryResponse>) responseObserver);
          break;
        case METHODID_SYNC:
          serviceImpl.sync((com.google.home.graph.v1.HomeGraphApiServiceProto.SyncRequest) request,
              (io.grpc.stub.StreamObserver<com.google.home.graph.v1.HomeGraphApiServiceProto.SyncResponse>) responseObserver);
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

  private static abstract class HomeGraphApiServiceBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoFileDescriptorSupplier, io.grpc.protobuf.ProtoServiceDescriptorSupplier {
    HomeGraphApiServiceBaseDescriptorSupplier() {}

    @java.lang.Override
    public com.google.protobuf.Descriptors.FileDescriptor getFileDescriptor() {
      return com.google.home.graph.v1.HomeGraphApiServiceProto.getDescriptor();
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.ServiceDescriptor getServiceDescriptor() {
      return getFileDescriptor().findServiceByName("HomeGraphApiService");
    }
  }

  private static final class HomeGraphApiServiceFileDescriptorSupplier
      extends HomeGraphApiServiceBaseDescriptorSupplier {
    HomeGraphApiServiceFileDescriptorSupplier() {}
  }

  private static final class HomeGraphApiServiceMethodDescriptorSupplier
      extends HomeGraphApiServiceBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoMethodDescriptorSupplier {
    private final String methodName;

    HomeGraphApiServiceMethodDescriptorSupplier(String methodName) {
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
      synchronized (HomeGraphApiServiceGrpc.class) {
        result = serviceDescriptor;
        if (result == null) {
          serviceDescriptor = result = io.grpc.ServiceDescriptor.newBuilder(SERVICE_NAME)
              .setSchemaDescriptor(new HomeGraphApiServiceFileDescriptorSupplier())
              .addMethod(getRequestSyncDevicesMethod())
              .addMethod(getReportStateAndNotificationMethod())
              .addMethod(getDeleteAgentUserMethod())
              .addMethod(getQueryMethod())
              .addMethod(getSyncMethod())
              .build();
        }
      }
    }
    return result;
  }
}
