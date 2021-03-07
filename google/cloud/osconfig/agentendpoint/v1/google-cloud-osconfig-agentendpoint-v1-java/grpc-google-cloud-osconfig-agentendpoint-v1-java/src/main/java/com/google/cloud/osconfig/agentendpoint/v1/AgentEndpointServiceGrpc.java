package com.google.cloud.osconfig.agentendpoint.v1;

import static io.grpc.MethodDescriptor.generateFullMethodName;

/**
 * <pre>
 * OS Config agent endpoint API.
 * </pre>
 */
@javax.annotation.Generated(
    value = "by gRPC proto compiler",
    comments = "Source: google/cloud/osconfig/agentendpoint/v1/agentendpoint.proto")
public final class AgentEndpointServiceGrpc {

  private AgentEndpointServiceGrpc() {}

  public static final String SERVICE_NAME = "google.cloud.osconfig.agentendpoint.v1.AgentEndpointService";

  // Static method descriptors that strictly reflect the proto.
  private static volatile io.grpc.MethodDescriptor<com.google.cloud.osconfig.agentendpoint.v1.ReceiveTaskNotificationRequest,
      com.google.cloud.osconfig.agentendpoint.v1.ReceiveTaskNotificationResponse> getReceiveTaskNotificationMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "ReceiveTaskNotification",
      requestType = com.google.cloud.osconfig.agentendpoint.v1.ReceiveTaskNotificationRequest.class,
      responseType = com.google.cloud.osconfig.agentendpoint.v1.ReceiveTaskNotificationResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.SERVER_STREAMING)
  public static io.grpc.MethodDescriptor<com.google.cloud.osconfig.agentendpoint.v1.ReceiveTaskNotificationRequest,
      com.google.cloud.osconfig.agentendpoint.v1.ReceiveTaskNotificationResponse> getReceiveTaskNotificationMethod() {
    io.grpc.MethodDescriptor<com.google.cloud.osconfig.agentendpoint.v1.ReceiveTaskNotificationRequest, com.google.cloud.osconfig.agentendpoint.v1.ReceiveTaskNotificationResponse> getReceiveTaskNotificationMethod;
    if ((getReceiveTaskNotificationMethod = AgentEndpointServiceGrpc.getReceiveTaskNotificationMethod) == null) {
      synchronized (AgentEndpointServiceGrpc.class) {
        if ((getReceiveTaskNotificationMethod = AgentEndpointServiceGrpc.getReceiveTaskNotificationMethod) == null) {
          AgentEndpointServiceGrpc.getReceiveTaskNotificationMethod = getReceiveTaskNotificationMethod =
              io.grpc.MethodDescriptor.<com.google.cloud.osconfig.agentendpoint.v1.ReceiveTaskNotificationRequest, com.google.cloud.osconfig.agentendpoint.v1.ReceiveTaskNotificationResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.SERVER_STREAMING)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "ReceiveTaskNotification"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.osconfig.agentendpoint.v1.ReceiveTaskNotificationRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.osconfig.agentendpoint.v1.ReceiveTaskNotificationResponse.getDefaultInstance()))
              .setSchemaDescriptor(new AgentEndpointServiceMethodDescriptorSupplier("ReceiveTaskNotification"))
              .build();
        }
      }
    }
    return getReceiveTaskNotificationMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.cloud.osconfig.agentendpoint.v1.StartNextTaskRequest,
      com.google.cloud.osconfig.agentendpoint.v1.StartNextTaskResponse> getStartNextTaskMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "StartNextTask",
      requestType = com.google.cloud.osconfig.agentendpoint.v1.StartNextTaskRequest.class,
      responseType = com.google.cloud.osconfig.agentendpoint.v1.StartNextTaskResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.cloud.osconfig.agentendpoint.v1.StartNextTaskRequest,
      com.google.cloud.osconfig.agentendpoint.v1.StartNextTaskResponse> getStartNextTaskMethod() {
    io.grpc.MethodDescriptor<com.google.cloud.osconfig.agentendpoint.v1.StartNextTaskRequest, com.google.cloud.osconfig.agentendpoint.v1.StartNextTaskResponse> getStartNextTaskMethod;
    if ((getStartNextTaskMethod = AgentEndpointServiceGrpc.getStartNextTaskMethod) == null) {
      synchronized (AgentEndpointServiceGrpc.class) {
        if ((getStartNextTaskMethod = AgentEndpointServiceGrpc.getStartNextTaskMethod) == null) {
          AgentEndpointServiceGrpc.getStartNextTaskMethod = getStartNextTaskMethod =
              io.grpc.MethodDescriptor.<com.google.cloud.osconfig.agentendpoint.v1.StartNextTaskRequest, com.google.cloud.osconfig.agentendpoint.v1.StartNextTaskResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "StartNextTask"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.osconfig.agentendpoint.v1.StartNextTaskRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.osconfig.agentendpoint.v1.StartNextTaskResponse.getDefaultInstance()))
              .setSchemaDescriptor(new AgentEndpointServiceMethodDescriptorSupplier("StartNextTask"))
              .build();
        }
      }
    }
    return getStartNextTaskMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.cloud.osconfig.agentendpoint.v1.ReportTaskProgressRequest,
      com.google.cloud.osconfig.agentendpoint.v1.ReportTaskProgressResponse> getReportTaskProgressMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "ReportTaskProgress",
      requestType = com.google.cloud.osconfig.agentendpoint.v1.ReportTaskProgressRequest.class,
      responseType = com.google.cloud.osconfig.agentendpoint.v1.ReportTaskProgressResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.cloud.osconfig.agentendpoint.v1.ReportTaskProgressRequest,
      com.google.cloud.osconfig.agentendpoint.v1.ReportTaskProgressResponse> getReportTaskProgressMethod() {
    io.grpc.MethodDescriptor<com.google.cloud.osconfig.agentendpoint.v1.ReportTaskProgressRequest, com.google.cloud.osconfig.agentendpoint.v1.ReportTaskProgressResponse> getReportTaskProgressMethod;
    if ((getReportTaskProgressMethod = AgentEndpointServiceGrpc.getReportTaskProgressMethod) == null) {
      synchronized (AgentEndpointServiceGrpc.class) {
        if ((getReportTaskProgressMethod = AgentEndpointServiceGrpc.getReportTaskProgressMethod) == null) {
          AgentEndpointServiceGrpc.getReportTaskProgressMethod = getReportTaskProgressMethod =
              io.grpc.MethodDescriptor.<com.google.cloud.osconfig.agentendpoint.v1.ReportTaskProgressRequest, com.google.cloud.osconfig.agentendpoint.v1.ReportTaskProgressResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "ReportTaskProgress"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.osconfig.agentendpoint.v1.ReportTaskProgressRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.osconfig.agentendpoint.v1.ReportTaskProgressResponse.getDefaultInstance()))
              .setSchemaDescriptor(new AgentEndpointServiceMethodDescriptorSupplier("ReportTaskProgress"))
              .build();
        }
      }
    }
    return getReportTaskProgressMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.cloud.osconfig.agentendpoint.v1.ReportTaskCompleteRequest,
      com.google.cloud.osconfig.agentendpoint.v1.ReportTaskCompleteResponse> getReportTaskCompleteMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "ReportTaskComplete",
      requestType = com.google.cloud.osconfig.agentendpoint.v1.ReportTaskCompleteRequest.class,
      responseType = com.google.cloud.osconfig.agentendpoint.v1.ReportTaskCompleteResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.cloud.osconfig.agentendpoint.v1.ReportTaskCompleteRequest,
      com.google.cloud.osconfig.agentendpoint.v1.ReportTaskCompleteResponse> getReportTaskCompleteMethod() {
    io.grpc.MethodDescriptor<com.google.cloud.osconfig.agentendpoint.v1.ReportTaskCompleteRequest, com.google.cloud.osconfig.agentendpoint.v1.ReportTaskCompleteResponse> getReportTaskCompleteMethod;
    if ((getReportTaskCompleteMethod = AgentEndpointServiceGrpc.getReportTaskCompleteMethod) == null) {
      synchronized (AgentEndpointServiceGrpc.class) {
        if ((getReportTaskCompleteMethod = AgentEndpointServiceGrpc.getReportTaskCompleteMethod) == null) {
          AgentEndpointServiceGrpc.getReportTaskCompleteMethod = getReportTaskCompleteMethod =
              io.grpc.MethodDescriptor.<com.google.cloud.osconfig.agentendpoint.v1.ReportTaskCompleteRequest, com.google.cloud.osconfig.agentendpoint.v1.ReportTaskCompleteResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "ReportTaskComplete"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.osconfig.agentendpoint.v1.ReportTaskCompleteRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.osconfig.agentendpoint.v1.ReportTaskCompleteResponse.getDefaultInstance()))
              .setSchemaDescriptor(new AgentEndpointServiceMethodDescriptorSupplier("ReportTaskComplete"))
              .build();
        }
      }
    }
    return getReportTaskCompleteMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.cloud.osconfig.agentendpoint.v1.RegisterAgentRequest,
      com.google.cloud.osconfig.agentendpoint.v1.RegisterAgentResponse> getRegisterAgentMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "RegisterAgent",
      requestType = com.google.cloud.osconfig.agentendpoint.v1.RegisterAgentRequest.class,
      responseType = com.google.cloud.osconfig.agentendpoint.v1.RegisterAgentResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.cloud.osconfig.agentendpoint.v1.RegisterAgentRequest,
      com.google.cloud.osconfig.agentendpoint.v1.RegisterAgentResponse> getRegisterAgentMethod() {
    io.grpc.MethodDescriptor<com.google.cloud.osconfig.agentendpoint.v1.RegisterAgentRequest, com.google.cloud.osconfig.agentendpoint.v1.RegisterAgentResponse> getRegisterAgentMethod;
    if ((getRegisterAgentMethod = AgentEndpointServiceGrpc.getRegisterAgentMethod) == null) {
      synchronized (AgentEndpointServiceGrpc.class) {
        if ((getRegisterAgentMethod = AgentEndpointServiceGrpc.getRegisterAgentMethod) == null) {
          AgentEndpointServiceGrpc.getRegisterAgentMethod = getRegisterAgentMethod =
              io.grpc.MethodDescriptor.<com.google.cloud.osconfig.agentendpoint.v1.RegisterAgentRequest, com.google.cloud.osconfig.agentendpoint.v1.RegisterAgentResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "RegisterAgent"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.osconfig.agentendpoint.v1.RegisterAgentRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.osconfig.agentendpoint.v1.RegisterAgentResponse.getDefaultInstance()))
              .setSchemaDescriptor(new AgentEndpointServiceMethodDescriptorSupplier("RegisterAgent"))
              .build();
        }
      }
    }
    return getRegisterAgentMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.cloud.osconfig.agentendpoint.v1.ReportInventoryRequest,
      com.google.cloud.osconfig.agentendpoint.v1.ReportInventoryResponse> getReportInventoryMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "ReportInventory",
      requestType = com.google.cloud.osconfig.agentendpoint.v1.ReportInventoryRequest.class,
      responseType = com.google.cloud.osconfig.agentendpoint.v1.ReportInventoryResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.cloud.osconfig.agentendpoint.v1.ReportInventoryRequest,
      com.google.cloud.osconfig.agentendpoint.v1.ReportInventoryResponse> getReportInventoryMethod() {
    io.grpc.MethodDescriptor<com.google.cloud.osconfig.agentendpoint.v1.ReportInventoryRequest, com.google.cloud.osconfig.agentendpoint.v1.ReportInventoryResponse> getReportInventoryMethod;
    if ((getReportInventoryMethod = AgentEndpointServiceGrpc.getReportInventoryMethod) == null) {
      synchronized (AgentEndpointServiceGrpc.class) {
        if ((getReportInventoryMethod = AgentEndpointServiceGrpc.getReportInventoryMethod) == null) {
          AgentEndpointServiceGrpc.getReportInventoryMethod = getReportInventoryMethod =
              io.grpc.MethodDescriptor.<com.google.cloud.osconfig.agentendpoint.v1.ReportInventoryRequest, com.google.cloud.osconfig.agentendpoint.v1.ReportInventoryResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "ReportInventory"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.osconfig.agentendpoint.v1.ReportInventoryRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.osconfig.agentendpoint.v1.ReportInventoryResponse.getDefaultInstance()))
              .setSchemaDescriptor(new AgentEndpointServiceMethodDescriptorSupplier("ReportInventory"))
              .build();
        }
      }
    }
    return getReportInventoryMethod;
  }

  /**
   * Creates a new async stub that supports all call types for the service
   */
  public static AgentEndpointServiceStub newStub(io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<AgentEndpointServiceStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<AgentEndpointServiceStub>() {
        @java.lang.Override
        public AgentEndpointServiceStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new AgentEndpointServiceStub(channel, callOptions);
        }
      };
    return AgentEndpointServiceStub.newStub(factory, channel);
  }

  /**
   * Creates a new blocking-style stub that supports unary and streaming output calls on the service
   */
  public static AgentEndpointServiceBlockingStub newBlockingStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<AgentEndpointServiceBlockingStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<AgentEndpointServiceBlockingStub>() {
        @java.lang.Override
        public AgentEndpointServiceBlockingStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new AgentEndpointServiceBlockingStub(channel, callOptions);
        }
      };
    return AgentEndpointServiceBlockingStub.newStub(factory, channel);
  }

  /**
   * Creates a new ListenableFuture-style stub that supports unary calls on the service
   */
  public static AgentEndpointServiceFutureStub newFutureStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<AgentEndpointServiceFutureStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<AgentEndpointServiceFutureStub>() {
        @java.lang.Override
        public AgentEndpointServiceFutureStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new AgentEndpointServiceFutureStub(channel, callOptions);
        }
      };
    return AgentEndpointServiceFutureStub.newStub(factory, channel);
  }

  /**
   * <pre>
   * OS Config agent endpoint API.
   * </pre>
   */
  public static abstract class AgentEndpointServiceImplBase implements io.grpc.BindableService {

    /**
     * <pre>
     * Stream established by client to receive Task notifications.
     * </pre>
     */
    public void receiveTaskNotification(com.google.cloud.osconfig.agentendpoint.v1.ReceiveTaskNotificationRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.osconfig.agentendpoint.v1.ReceiveTaskNotificationResponse> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getReceiveTaskNotificationMethod(), responseObserver);
    }

    /**
     * <pre>
     * Signals the start of a task execution and returns the task info.
     * </pre>
     */
    public void startNextTask(com.google.cloud.osconfig.agentendpoint.v1.StartNextTaskRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.osconfig.agentendpoint.v1.StartNextTaskResponse> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getStartNextTaskMethod(), responseObserver);
    }

    /**
     * <pre>
     * Signals an intermediary progress checkpoint in task execution.
     * </pre>
     */
    public void reportTaskProgress(com.google.cloud.osconfig.agentendpoint.v1.ReportTaskProgressRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.osconfig.agentendpoint.v1.ReportTaskProgressResponse> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getReportTaskProgressMethod(), responseObserver);
    }

    /**
     * <pre>
     * Signals that the task execution is complete and optionally returns the next
     * task.
     * </pre>
     */
    public void reportTaskComplete(com.google.cloud.osconfig.agentendpoint.v1.ReportTaskCompleteRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.osconfig.agentendpoint.v1.ReportTaskCompleteResponse> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getReportTaskCompleteMethod(), responseObserver);
    }

    /**
     * <pre>
     * Registers the agent running on the VM.
     * </pre>
     */
    public void registerAgent(com.google.cloud.osconfig.agentendpoint.v1.RegisterAgentRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.osconfig.agentendpoint.v1.RegisterAgentResponse> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getRegisterAgentMethod(), responseObserver);
    }

    /**
     * <pre>
     * Reports the VMs current inventory.
     * </pre>
     */
    public void reportInventory(com.google.cloud.osconfig.agentendpoint.v1.ReportInventoryRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.osconfig.agentendpoint.v1.ReportInventoryResponse> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getReportInventoryMethod(), responseObserver);
    }

    @java.lang.Override public final io.grpc.ServerServiceDefinition bindService() {
      return io.grpc.ServerServiceDefinition.builder(getServiceDescriptor())
          .addMethod(
            getReceiveTaskNotificationMethod(),
            io.grpc.stub.ServerCalls.asyncServerStreamingCall(
              new MethodHandlers<
                com.google.cloud.osconfig.agentendpoint.v1.ReceiveTaskNotificationRequest,
                com.google.cloud.osconfig.agentendpoint.v1.ReceiveTaskNotificationResponse>(
                  this, METHODID_RECEIVE_TASK_NOTIFICATION)))
          .addMethod(
            getStartNextTaskMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.cloud.osconfig.agentendpoint.v1.StartNextTaskRequest,
                com.google.cloud.osconfig.agentendpoint.v1.StartNextTaskResponse>(
                  this, METHODID_START_NEXT_TASK)))
          .addMethod(
            getReportTaskProgressMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.cloud.osconfig.agentendpoint.v1.ReportTaskProgressRequest,
                com.google.cloud.osconfig.agentendpoint.v1.ReportTaskProgressResponse>(
                  this, METHODID_REPORT_TASK_PROGRESS)))
          .addMethod(
            getReportTaskCompleteMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.cloud.osconfig.agentendpoint.v1.ReportTaskCompleteRequest,
                com.google.cloud.osconfig.agentendpoint.v1.ReportTaskCompleteResponse>(
                  this, METHODID_REPORT_TASK_COMPLETE)))
          .addMethod(
            getRegisterAgentMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.cloud.osconfig.agentendpoint.v1.RegisterAgentRequest,
                com.google.cloud.osconfig.agentendpoint.v1.RegisterAgentResponse>(
                  this, METHODID_REGISTER_AGENT)))
          .addMethod(
            getReportInventoryMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.cloud.osconfig.agentendpoint.v1.ReportInventoryRequest,
                com.google.cloud.osconfig.agentendpoint.v1.ReportInventoryResponse>(
                  this, METHODID_REPORT_INVENTORY)))
          .build();
    }
  }

  /**
   * <pre>
   * OS Config agent endpoint API.
   * </pre>
   */
  public static final class AgentEndpointServiceStub extends io.grpc.stub.AbstractAsyncStub<AgentEndpointServiceStub> {
    private AgentEndpointServiceStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected AgentEndpointServiceStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new AgentEndpointServiceStub(channel, callOptions);
    }

    /**
     * <pre>
     * Stream established by client to receive Task notifications.
     * </pre>
     */
    public void receiveTaskNotification(com.google.cloud.osconfig.agentendpoint.v1.ReceiveTaskNotificationRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.osconfig.agentendpoint.v1.ReceiveTaskNotificationResponse> responseObserver) {
      io.grpc.stub.ClientCalls.asyncServerStreamingCall(
          getChannel().newCall(getReceiveTaskNotificationMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Signals the start of a task execution and returns the task info.
     * </pre>
     */
    public void startNextTask(com.google.cloud.osconfig.agentendpoint.v1.StartNextTaskRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.osconfig.agentendpoint.v1.StartNextTaskResponse> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getStartNextTaskMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Signals an intermediary progress checkpoint in task execution.
     * </pre>
     */
    public void reportTaskProgress(com.google.cloud.osconfig.agentendpoint.v1.ReportTaskProgressRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.osconfig.agentendpoint.v1.ReportTaskProgressResponse> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getReportTaskProgressMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Signals that the task execution is complete and optionally returns the next
     * task.
     * </pre>
     */
    public void reportTaskComplete(com.google.cloud.osconfig.agentendpoint.v1.ReportTaskCompleteRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.osconfig.agentendpoint.v1.ReportTaskCompleteResponse> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getReportTaskCompleteMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Registers the agent running on the VM.
     * </pre>
     */
    public void registerAgent(com.google.cloud.osconfig.agentendpoint.v1.RegisterAgentRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.osconfig.agentendpoint.v1.RegisterAgentResponse> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getRegisterAgentMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Reports the VMs current inventory.
     * </pre>
     */
    public void reportInventory(com.google.cloud.osconfig.agentendpoint.v1.ReportInventoryRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.osconfig.agentendpoint.v1.ReportInventoryResponse> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getReportInventoryMethod(), getCallOptions()), request, responseObserver);
    }
  }

  /**
   * <pre>
   * OS Config agent endpoint API.
   * </pre>
   */
  public static final class AgentEndpointServiceBlockingStub extends io.grpc.stub.AbstractBlockingStub<AgentEndpointServiceBlockingStub> {
    private AgentEndpointServiceBlockingStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected AgentEndpointServiceBlockingStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new AgentEndpointServiceBlockingStub(channel, callOptions);
    }

    /**
     * <pre>
     * Stream established by client to receive Task notifications.
     * </pre>
     */
    public java.util.Iterator<com.google.cloud.osconfig.agentendpoint.v1.ReceiveTaskNotificationResponse> receiveTaskNotification(
        com.google.cloud.osconfig.agentendpoint.v1.ReceiveTaskNotificationRequest request) {
      return io.grpc.stub.ClientCalls.blockingServerStreamingCall(
          getChannel(), getReceiveTaskNotificationMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Signals the start of a task execution and returns the task info.
     * </pre>
     */
    public com.google.cloud.osconfig.agentendpoint.v1.StartNextTaskResponse startNextTask(com.google.cloud.osconfig.agentendpoint.v1.StartNextTaskRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getStartNextTaskMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Signals an intermediary progress checkpoint in task execution.
     * </pre>
     */
    public com.google.cloud.osconfig.agentendpoint.v1.ReportTaskProgressResponse reportTaskProgress(com.google.cloud.osconfig.agentendpoint.v1.ReportTaskProgressRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getReportTaskProgressMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Signals that the task execution is complete and optionally returns the next
     * task.
     * </pre>
     */
    public com.google.cloud.osconfig.agentendpoint.v1.ReportTaskCompleteResponse reportTaskComplete(com.google.cloud.osconfig.agentendpoint.v1.ReportTaskCompleteRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getReportTaskCompleteMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Registers the agent running on the VM.
     * </pre>
     */
    public com.google.cloud.osconfig.agentendpoint.v1.RegisterAgentResponse registerAgent(com.google.cloud.osconfig.agentendpoint.v1.RegisterAgentRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getRegisterAgentMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Reports the VMs current inventory.
     * </pre>
     */
    public com.google.cloud.osconfig.agentendpoint.v1.ReportInventoryResponse reportInventory(com.google.cloud.osconfig.agentendpoint.v1.ReportInventoryRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getReportInventoryMethod(), getCallOptions(), request);
    }
  }

  /**
   * <pre>
   * OS Config agent endpoint API.
   * </pre>
   */
  public static final class AgentEndpointServiceFutureStub extends io.grpc.stub.AbstractFutureStub<AgentEndpointServiceFutureStub> {
    private AgentEndpointServiceFutureStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected AgentEndpointServiceFutureStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new AgentEndpointServiceFutureStub(channel, callOptions);
    }

    /**
     * <pre>
     * Signals the start of a task execution and returns the task info.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.cloud.osconfig.agentendpoint.v1.StartNextTaskResponse> startNextTask(
        com.google.cloud.osconfig.agentendpoint.v1.StartNextTaskRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getStartNextTaskMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Signals an intermediary progress checkpoint in task execution.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.cloud.osconfig.agentendpoint.v1.ReportTaskProgressResponse> reportTaskProgress(
        com.google.cloud.osconfig.agentendpoint.v1.ReportTaskProgressRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getReportTaskProgressMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Signals that the task execution is complete and optionally returns the next
     * task.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.cloud.osconfig.agentendpoint.v1.ReportTaskCompleteResponse> reportTaskComplete(
        com.google.cloud.osconfig.agentendpoint.v1.ReportTaskCompleteRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getReportTaskCompleteMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Registers the agent running on the VM.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.cloud.osconfig.agentendpoint.v1.RegisterAgentResponse> registerAgent(
        com.google.cloud.osconfig.agentendpoint.v1.RegisterAgentRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getRegisterAgentMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Reports the VMs current inventory.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.cloud.osconfig.agentendpoint.v1.ReportInventoryResponse> reportInventory(
        com.google.cloud.osconfig.agentendpoint.v1.ReportInventoryRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getReportInventoryMethod(), getCallOptions()), request);
    }
  }

  private static final int METHODID_RECEIVE_TASK_NOTIFICATION = 0;
  private static final int METHODID_START_NEXT_TASK = 1;
  private static final int METHODID_REPORT_TASK_PROGRESS = 2;
  private static final int METHODID_REPORT_TASK_COMPLETE = 3;
  private static final int METHODID_REGISTER_AGENT = 4;
  private static final int METHODID_REPORT_INVENTORY = 5;

  private static final class MethodHandlers<Req, Resp> implements
      io.grpc.stub.ServerCalls.UnaryMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ServerStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ClientStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.BidiStreamingMethod<Req, Resp> {
    private final AgentEndpointServiceImplBase serviceImpl;
    private final int methodId;

    MethodHandlers(AgentEndpointServiceImplBase serviceImpl, int methodId) {
      this.serviceImpl = serviceImpl;
      this.methodId = methodId;
    }

    @java.lang.Override
    @java.lang.SuppressWarnings("unchecked")
    public void invoke(Req request, io.grpc.stub.StreamObserver<Resp> responseObserver) {
      switch (methodId) {
        case METHODID_RECEIVE_TASK_NOTIFICATION:
          serviceImpl.receiveTaskNotification((com.google.cloud.osconfig.agentendpoint.v1.ReceiveTaskNotificationRequest) request,
              (io.grpc.stub.StreamObserver<com.google.cloud.osconfig.agentendpoint.v1.ReceiveTaskNotificationResponse>) responseObserver);
          break;
        case METHODID_START_NEXT_TASK:
          serviceImpl.startNextTask((com.google.cloud.osconfig.agentendpoint.v1.StartNextTaskRequest) request,
              (io.grpc.stub.StreamObserver<com.google.cloud.osconfig.agentendpoint.v1.StartNextTaskResponse>) responseObserver);
          break;
        case METHODID_REPORT_TASK_PROGRESS:
          serviceImpl.reportTaskProgress((com.google.cloud.osconfig.agentendpoint.v1.ReportTaskProgressRequest) request,
              (io.grpc.stub.StreamObserver<com.google.cloud.osconfig.agentendpoint.v1.ReportTaskProgressResponse>) responseObserver);
          break;
        case METHODID_REPORT_TASK_COMPLETE:
          serviceImpl.reportTaskComplete((com.google.cloud.osconfig.agentendpoint.v1.ReportTaskCompleteRequest) request,
              (io.grpc.stub.StreamObserver<com.google.cloud.osconfig.agentendpoint.v1.ReportTaskCompleteResponse>) responseObserver);
          break;
        case METHODID_REGISTER_AGENT:
          serviceImpl.registerAgent((com.google.cloud.osconfig.agentendpoint.v1.RegisterAgentRequest) request,
              (io.grpc.stub.StreamObserver<com.google.cloud.osconfig.agentendpoint.v1.RegisterAgentResponse>) responseObserver);
          break;
        case METHODID_REPORT_INVENTORY:
          serviceImpl.reportInventory((com.google.cloud.osconfig.agentendpoint.v1.ReportInventoryRequest) request,
              (io.grpc.stub.StreamObserver<com.google.cloud.osconfig.agentendpoint.v1.ReportInventoryResponse>) responseObserver);
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

  private static abstract class AgentEndpointServiceBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoFileDescriptorSupplier, io.grpc.protobuf.ProtoServiceDescriptorSupplier {
    AgentEndpointServiceBaseDescriptorSupplier() {}

    @java.lang.Override
    public com.google.protobuf.Descriptors.FileDescriptor getFileDescriptor() {
      return com.google.cloud.osconfig.agentendpoint.v1.AgentEndpointProto.getDescriptor();
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.ServiceDescriptor getServiceDescriptor() {
      return getFileDescriptor().findServiceByName("AgentEndpointService");
    }
  }

  private static final class AgentEndpointServiceFileDescriptorSupplier
      extends AgentEndpointServiceBaseDescriptorSupplier {
    AgentEndpointServiceFileDescriptorSupplier() {}
  }

  private static final class AgentEndpointServiceMethodDescriptorSupplier
      extends AgentEndpointServiceBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoMethodDescriptorSupplier {
    private final String methodName;

    AgentEndpointServiceMethodDescriptorSupplier(String methodName) {
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
      synchronized (AgentEndpointServiceGrpc.class) {
        result = serviceDescriptor;
        if (result == null) {
          serviceDescriptor = result = io.grpc.ServiceDescriptor.newBuilder(SERVICE_NAME)
              .setSchemaDescriptor(new AgentEndpointServiceFileDescriptorSupplier())
              .addMethod(getReceiveTaskNotificationMethod())
              .addMethod(getStartNextTaskMethod())
              .addMethod(getReportTaskProgressMethod())
              .addMethod(getReportTaskCompleteMethod())
              .addMethod(getRegisterAgentMethod())
              .addMethod(getReportInventoryMethod())
              .build();
        }
      }
    }
    return result;
  }
}
