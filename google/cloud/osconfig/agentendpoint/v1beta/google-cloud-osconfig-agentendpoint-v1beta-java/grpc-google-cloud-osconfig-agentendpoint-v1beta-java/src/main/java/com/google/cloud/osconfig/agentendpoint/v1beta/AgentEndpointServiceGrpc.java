package com.google.cloud.osconfig.agentendpoint.v1beta;

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
 * OS Config agent endpoint API.
 * </pre>
 */
@javax.annotation.Generated(
    value = "by gRPC proto compiler",
    comments = "Source: google/cloud/osconfig/agentendpoint/v1beta/agentendpoint.proto")
public final class AgentEndpointServiceGrpc {

  private AgentEndpointServiceGrpc() {}

  public static final String SERVICE_NAME = "google.cloud.osconfig.agentendpoint.v1beta.AgentEndpointService";

  // Static method descriptors that strictly reflect the proto.
  private static volatile io.grpc.MethodDescriptor<com.google.cloud.osconfig.agentendpoint.v1beta.ReceiveTaskNotificationRequest,
      com.google.cloud.osconfig.agentendpoint.v1beta.ReceiveTaskNotificationResponse> getReceiveTaskNotificationMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "ReceiveTaskNotification",
      requestType = com.google.cloud.osconfig.agentendpoint.v1beta.ReceiveTaskNotificationRequest.class,
      responseType = com.google.cloud.osconfig.agentendpoint.v1beta.ReceiveTaskNotificationResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.SERVER_STREAMING)
  public static io.grpc.MethodDescriptor<com.google.cloud.osconfig.agentendpoint.v1beta.ReceiveTaskNotificationRequest,
      com.google.cloud.osconfig.agentendpoint.v1beta.ReceiveTaskNotificationResponse> getReceiveTaskNotificationMethod() {
    io.grpc.MethodDescriptor<com.google.cloud.osconfig.agentendpoint.v1beta.ReceiveTaskNotificationRequest, com.google.cloud.osconfig.agentendpoint.v1beta.ReceiveTaskNotificationResponse> getReceiveTaskNotificationMethod;
    if ((getReceiveTaskNotificationMethod = AgentEndpointServiceGrpc.getReceiveTaskNotificationMethod) == null) {
      synchronized (AgentEndpointServiceGrpc.class) {
        if ((getReceiveTaskNotificationMethod = AgentEndpointServiceGrpc.getReceiveTaskNotificationMethod) == null) {
          AgentEndpointServiceGrpc.getReceiveTaskNotificationMethod = getReceiveTaskNotificationMethod =
              io.grpc.MethodDescriptor.<com.google.cloud.osconfig.agentendpoint.v1beta.ReceiveTaskNotificationRequest, com.google.cloud.osconfig.agentendpoint.v1beta.ReceiveTaskNotificationResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.SERVER_STREAMING)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "ReceiveTaskNotification"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.osconfig.agentendpoint.v1beta.ReceiveTaskNotificationRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.osconfig.agentendpoint.v1beta.ReceiveTaskNotificationResponse.getDefaultInstance()))
              .setSchemaDescriptor(new AgentEndpointServiceMethodDescriptorSupplier("ReceiveTaskNotification"))
              .build();
        }
      }
    }
    return getReceiveTaskNotificationMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.cloud.osconfig.agentendpoint.v1beta.StartNextTaskRequest,
      com.google.cloud.osconfig.agentendpoint.v1beta.StartNextTaskResponse> getStartNextTaskMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "StartNextTask",
      requestType = com.google.cloud.osconfig.agentendpoint.v1beta.StartNextTaskRequest.class,
      responseType = com.google.cloud.osconfig.agentendpoint.v1beta.StartNextTaskResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.cloud.osconfig.agentendpoint.v1beta.StartNextTaskRequest,
      com.google.cloud.osconfig.agentendpoint.v1beta.StartNextTaskResponse> getStartNextTaskMethod() {
    io.grpc.MethodDescriptor<com.google.cloud.osconfig.agentendpoint.v1beta.StartNextTaskRequest, com.google.cloud.osconfig.agentendpoint.v1beta.StartNextTaskResponse> getStartNextTaskMethod;
    if ((getStartNextTaskMethod = AgentEndpointServiceGrpc.getStartNextTaskMethod) == null) {
      synchronized (AgentEndpointServiceGrpc.class) {
        if ((getStartNextTaskMethod = AgentEndpointServiceGrpc.getStartNextTaskMethod) == null) {
          AgentEndpointServiceGrpc.getStartNextTaskMethod = getStartNextTaskMethod =
              io.grpc.MethodDescriptor.<com.google.cloud.osconfig.agentendpoint.v1beta.StartNextTaskRequest, com.google.cloud.osconfig.agentendpoint.v1beta.StartNextTaskResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "StartNextTask"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.osconfig.agentendpoint.v1beta.StartNextTaskRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.osconfig.agentendpoint.v1beta.StartNextTaskResponse.getDefaultInstance()))
              .setSchemaDescriptor(new AgentEndpointServiceMethodDescriptorSupplier("StartNextTask"))
              .build();
        }
      }
    }
    return getStartNextTaskMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.cloud.osconfig.agentendpoint.v1beta.ReportTaskProgressRequest,
      com.google.cloud.osconfig.agentendpoint.v1beta.ReportTaskProgressResponse> getReportTaskProgressMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "ReportTaskProgress",
      requestType = com.google.cloud.osconfig.agentendpoint.v1beta.ReportTaskProgressRequest.class,
      responseType = com.google.cloud.osconfig.agentendpoint.v1beta.ReportTaskProgressResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.cloud.osconfig.agentendpoint.v1beta.ReportTaskProgressRequest,
      com.google.cloud.osconfig.agentendpoint.v1beta.ReportTaskProgressResponse> getReportTaskProgressMethod() {
    io.grpc.MethodDescriptor<com.google.cloud.osconfig.agentendpoint.v1beta.ReportTaskProgressRequest, com.google.cloud.osconfig.agentendpoint.v1beta.ReportTaskProgressResponse> getReportTaskProgressMethod;
    if ((getReportTaskProgressMethod = AgentEndpointServiceGrpc.getReportTaskProgressMethod) == null) {
      synchronized (AgentEndpointServiceGrpc.class) {
        if ((getReportTaskProgressMethod = AgentEndpointServiceGrpc.getReportTaskProgressMethod) == null) {
          AgentEndpointServiceGrpc.getReportTaskProgressMethod = getReportTaskProgressMethod =
              io.grpc.MethodDescriptor.<com.google.cloud.osconfig.agentendpoint.v1beta.ReportTaskProgressRequest, com.google.cloud.osconfig.agentendpoint.v1beta.ReportTaskProgressResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "ReportTaskProgress"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.osconfig.agentendpoint.v1beta.ReportTaskProgressRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.osconfig.agentendpoint.v1beta.ReportTaskProgressResponse.getDefaultInstance()))
              .setSchemaDescriptor(new AgentEndpointServiceMethodDescriptorSupplier("ReportTaskProgress"))
              .build();
        }
      }
    }
    return getReportTaskProgressMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.cloud.osconfig.agentendpoint.v1beta.ReportTaskCompleteRequest,
      com.google.cloud.osconfig.agentendpoint.v1beta.ReportTaskCompleteResponse> getReportTaskCompleteMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "ReportTaskComplete",
      requestType = com.google.cloud.osconfig.agentendpoint.v1beta.ReportTaskCompleteRequest.class,
      responseType = com.google.cloud.osconfig.agentendpoint.v1beta.ReportTaskCompleteResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.cloud.osconfig.agentendpoint.v1beta.ReportTaskCompleteRequest,
      com.google.cloud.osconfig.agentendpoint.v1beta.ReportTaskCompleteResponse> getReportTaskCompleteMethod() {
    io.grpc.MethodDescriptor<com.google.cloud.osconfig.agentendpoint.v1beta.ReportTaskCompleteRequest, com.google.cloud.osconfig.agentendpoint.v1beta.ReportTaskCompleteResponse> getReportTaskCompleteMethod;
    if ((getReportTaskCompleteMethod = AgentEndpointServiceGrpc.getReportTaskCompleteMethod) == null) {
      synchronized (AgentEndpointServiceGrpc.class) {
        if ((getReportTaskCompleteMethod = AgentEndpointServiceGrpc.getReportTaskCompleteMethod) == null) {
          AgentEndpointServiceGrpc.getReportTaskCompleteMethod = getReportTaskCompleteMethod =
              io.grpc.MethodDescriptor.<com.google.cloud.osconfig.agentendpoint.v1beta.ReportTaskCompleteRequest, com.google.cloud.osconfig.agentendpoint.v1beta.ReportTaskCompleteResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "ReportTaskComplete"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.osconfig.agentendpoint.v1beta.ReportTaskCompleteRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.osconfig.agentendpoint.v1beta.ReportTaskCompleteResponse.getDefaultInstance()))
              .setSchemaDescriptor(new AgentEndpointServiceMethodDescriptorSupplier("ReportTaskComplete"))
              .build();
        }
      }
    }
    return getReportTaskCompleteMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.cloud.osconfig.agentendpoint.v1beta.GuestPolicies.LookupEffectiveGuestPolicyRequest,
      com.google.cloud.osconfig.agentendpoint.v1beta.GuestPolicies.EffectiveGuestPolicy> getLookupEffectiveGuestPolicyMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "LookupEffectiveGuestPolicy",
      requestType = com.google.cloud.osconfig.agentendpoint.v1beta.GuestPolicies.LookupEffectiveGuestPolicyRequest.class,
      responseType = com.google.cloud.osconfig.agentendpoint.v1beta.GuestPolicies.EffectiveGuestPolicy.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.cloud.osconfig.agentendpoint.v1beta.GuestPolicies.LookupEffectiveGuestPolicyRequest,
      com.google.cloud.osconfig.agentendpoint.v1beta.GuestPolicies.EffectiveGuestPolicy> getLookupEffectiveGuestPolicyMethod() {
    io.grpc.MethodDescriptor<com.google.cloud.osconfig.agentendpoint.v1beta.GuestPolicies.LookupEffectiveGuestPolicyRequest, com.google.cloud.osconfig.agentendpoint.v1beta.GuestPolicies.EffectiveGuestPolicy> getLookupEffectiveGuestPolicyMethod;
    if ((getLookupEffectiveGuestPolicyMethod = AgentEndpointServiceGrpc.getLookupEffectiveGuestPolicyMethod) == null) {
      synchronized (AgentEndpointServiceGrpc.class) {
        if ((getLookupEffectiveGuestPolicyMethod = AgentEndpointServiceGrpc.getLookupEffectiveGuestPolicyMethod) == null) {
          AgentEndpointServiceGrpc.getLookupEffectiveGuestPolicyMethod = getLookupEffectiveGuestPolicyMethod =
              io.grpc.MethodDescriptor.<com.google.cloud.osconfig.agentendpoint.v1beta.GuestPolicies.LookupEffectiveGuestPolicyRequest, com.google.cloud.osconfig.agentendpoint.v1beta.GuestPolicies.EffectiveGuestPolicy>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "LookupEffectiveGuestPolicy"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.osconfig.agentendpoint.v1beta.GuestPolicies.LookupEffectiveGuestPolicyRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.osconfig.agentendpoint.v1beta.GuestPolicies.EffectiveGuestPolicy.getDefaultInstance()))
              .setSchemaDescriptor(new AgentEndpointServiceMethodDescriptorSupplier("LookupEffectiveGuestPolicy"))
              .build();
        }
      }
    }
    return getLookupEffectiveGuestPolicyMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.cloud.osconfig.agentendpoint.v1beta.RegisterAgentRequest,
      com.google.cloud.osconfig.agentendpoint.v1beta.RegisterAgentResponse> getRegisterAgentMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "RegisterAgent",
      requestType = com.google.cloud.osconfig.agentendpoint.v1beta.RegisterAgentRequest.class,
      responseType = com.google.cloud.osconfig.agentendpoint.v1beta.RegisterAgentResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.cloud.osconfig.agentendpoint.v1beta.RegisterAgentRequest,
      com.google.cloud.osconfig.agentendpoint.v1beta.RegisterAgentResponse> getRegisterAgentMethod() {
    io.grpc.MethodDescriptor<com.google.cloud.osconfig.agentendpoint.v1beta.RegisterAgentRequest, com.google.cloud.osconfig.agentendpoint.v1beta.RegisterAgentResponse> getRegisterAgentMethod;
    if ((getRegisterAgentMethod = AgentEndpointServiceGrpc.getRegisterAgentMethod) == null) {
      synchronized (AgentEndpointServiceGrpc.class) {
        if ((getRegisterAgentMethod = AgentEndpointServiceGrpc.getRegisterAgentMethod) == null) {
          AgentEndpointServiceGrpc.getRegisterAgentMethod = getRegisterAgentMethod =
              io.grpc.MethodDescriptor.<com.google.cloud.osconfig.agentendpoint.v1beta.RegisterAgentRequest, com.google.cloud.osconfig.agentendpoint.v1beta.RegisterAgentResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "RegisterAgent"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.osconfig.agentendpoint.v1beta.RegisterAgentRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.osconfig.agentendpoint.v1beta.RegisterAgentResponse.getDefaultInstance()))
              .setSchemaDescriptor(new AgentEndpointServiceMethodDescriptorSupplier("RegisterAgent"))
              .build();
        }
      }
    }
    return getRegisterAgentMethod;
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
    public void receiveTaskNotification(com.google.cloud.osconfig.agentendpoint.v1beta.ReceiveTaskNotificationRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.osconfig.agentendpoint.v1beta.ReceiveTaskNotificationResponse> responseObserver) {
      asyncUnimplementedUnaryCall(getReceiveTaskNotificationMethod(), responseObserver);
    }

    /**
     * <pre>
     * Signals the start of a task execution and returns the task info.
     * </pre>
     */
    public void startNextTask(com.google.cloud.osconfig.agentendpoint.v1beta.StartNextTaskRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.osconfig.agentendpoint.v1beta.StartNextTaskResponse> responseObserver) {
      asyncUnimplementedUnaryCall(getStartNextTaskMethod(), responseObserver);
    }

    /**
     * <pre>
     * Signals an intermediary progress checkpoint in task execution.
     * </pre>
     */
    public void reportTaskProgress(com.google.cloud.osconfig.agentendpoint.v1beta.ReportTaskProgressRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.osconfig.agentendpoint.v1beta.ReportTaskProgressResponse> responseObserver) {
      asyncUnimplementedUnaryCall(getReportTaskProgressMethod(), responseObserver);
    }

    /**
     * <pre>
     * Signals that the task execution is complete and optionally returns the next
     * task.
     * </pre>
     */
    public void reportTaskComplete(com.google.cloud.osconfig.agentendpoint.v1beta.ReportTaskCompleteRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.osconfig.agentendpoint.v1beta.ReportTaskCompleteResponse> responseObserver) {
      asyncUnimplementedUnaryCall(getReportTaskCompleteMethod(), responseObserver);
    }

    /**
     * <pre>
     * Lookup the effective guest policy that applies to a VM instance. This
     * lookup merges all policies that are assigned to the instance ancestry.
     * </pre>
     */
    public void lookupEffectiveGuestPolicy(com.google.cloud.osconfig.agentendpoint.v1beta.GuestPolicies.LookupEffectiveGuestPolicyRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.osconfig.agentendpoint.v1beta.GuestPolicies.EffectiveGuestPolicy> responseObserver) {
      asyncUnimplementedUnaryCall(getLookupEffectiveGuestPolicyMethod(), responseObserver);
    }

    /**
     * <pre>
     * Registers the agent running on the VM.
     * </pre>
     */
    public void registerAgent(com.google.cloud.osconfig.agentendpoint.v1beta.RegisterAgentRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.osconfig.agentendpoint.v1beta.RegisterAgentResponse> responseObserver) {
      asyncUnimplementedUnaryCall(getRegisterAgentMethod(), responseObserver);
    }

    @java.lang.Override public final io.grpc.ServerServiceDefinition bindService() {
      return io.grpc.ServerServiceDefinition.builder(getServiceDescriptor())
          .addMethod(
            getReceiveTaskNotificationMethod(),
            asyncServerStreamingCall(
              new MethodHandlers<
                com.google.cloud.osconfig.agentendpoint.v1beta.ReceiveTaskNotificationRequest,
                com.google.cloud.osconfig.agentendpoint.v1beta.ReceiveTaskNotificationResponse>(
                  this, METHODID_RECEIVE_TASK_NOTIFICATION)))
          .addMethod(
            getStartNextTaskMethod(),
            asyncUnaryCall(
              new MethodHandlers<
                com.google.cloud.osconfig.agentendpoint.v1beta.StartNextTaskRequest,
                com.google.cloud.osconfig.agentendpoint.v1beta.StartNextTaskResponse>(
                  this, METHODID_START_NEXT_TASK)))
          .addMethod(
            getReportTaskProgressMethod(),
            asyncUnaryCall(
              new MethodHandlers<
                com.google.cloud.osconfig.agentendpoint.v1beta.ReportTaskProgressRequest,
                com.google.cloud.osconfig.agentendpoint.v1beta.ReportTaskProgressResponse>(
                  this, METHODID_REPORT_TASK_PROGRESS)))
          .addMethod(
            getReportTaskCompleteMethod(),
            asyncUnaryCall(
              new MethodHandlers<
                com.google.cloud.osconfig.agentendpoint.v1beta.ReportTaskCompleteRequest,
                com.google.cloud.osconfig.agentendpoint.v1beta.ReportTaskCompleteResponse>(
                  this, METHODID_REPORT_TASK_COMPLETE)))
          .addMethod(
            getLookupEffectiveGuestPolicyMethod(),
            asyncUnaryCall(
              new MethodHandlers<
                com.google.cloud.osconfig.agentendpoint.v1beta.GuestPolicies.LookupEffectiveGuestPolicyRequest,
                com.google.cloud.osconfig.agentendpoint.v1beta.GuestPolicies.EffectiveGuestPolicy>(
                  this, METHODID_LOOKUP_EFFECTIVE_GUEST_POLICY)))
          .addMethod(
            getRegisterAgentMethod(),
            asyncUnaryCall(
              new MethodHandlers<
                com.google.cloud.osconfig.agentendpoint.v1beta.RegisterAgentRequest,
                com.google.cloud.osconfig.agentendpoint.v1beta.RegisterAgentResponse>(
                  this, METHODID_REGISTER_AGENT)))
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
    public void receiveTaskNotification(com.google.cloud.osconfig.agentendpoint.v1beta.ReceiveTaskNotificationRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.osconfig.agentendpoint.v1beta.ReceiveTaskNotificationResponse> responseObserver) {
      asyncServerStreamingCall(
          getChannel().newCall(getReceiveTaskNotificationMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Signals the start of a task execution and returns the task info.
     * </pre>
     */
    public void startNextTask(com.google.cloud.osconfig.agentendpoint.v1beta.StartNextTaskRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.osconfig.agentendpoint.v1beta.StartNextTaskResponse> responseObserver) {
      asyncUnaryCall(
          getChannel().newCall(getStartNextTaskMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Signals an intermediary progress checkpoint in task execution.
     * </pre>
     */
    public void reportTaskProgress(com.google.cloud.osconfig.agentendpoint.v1beta.ReportTaskProgressRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.osconfig.agentendpoint.v1beta.ReportTaskProgressResponse> responseObserver) {
      asyncUnaryCall(
          getChannel().newCall(getReportTaskProgressMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Signals that the task execution is complete and optionally returns the next
     * task.
     * </pre>
     */
    public void reportTaskComplete(com.google.cloud.osconfig.agentendpoint.v1beta.ReportTaskCompleteRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.osconfig.agentendpoint.v1beta.ReportTaskCompleteResponse> responseObserver) {
      asyncUnaryCall(
          getChannel().newCall(getReportTaskCompleteMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Lookup the effective guest policy that applies to a VM instance. This
     * lookup merges all policies that are assigned to the instance ancestry.
     * </pre>
     */
    public void lookupEffectiveGuestPolicy(com.google.cloud.osconfig.agentendpoint.v1beta.GuestPolicies.LookupEffectiveGuestPolicyRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.osconfig.agentendpoint.v1beta.GuestPolicies.EffectiveGuestPolicy> responseObserver) {
      asyncUnaryCall(
          getChannel().newCall(getLookupEffectiveGuestPolicyMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Registers the agent running on the VM.
     * </pre>
     */
    public void registerAgent(com.google.cloud.osconfig.agentendpoint.v1beta.RegisterAgentRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.osconfig.agentendpoint.v1beta.RegisterAgentResponse> responseObserver) {
      asyncUnaryCall(
          getChannel().newCall(getRegisterAgentMethod(), getCallOptions()), request, responseObserver);
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
    public java.util.Iterator<com.google.cloud.osconfig.agentendpoint.v1beta.ReceiveTaskNotificationResponse> receiveTaskNotification(
        com.google.cloud.osconfig.agentendpoint.v1beta.ReceiveTaskNotificationRequest request) {
      return blockingServerStreamingCall(
          getChannel(), getReceiveTaskNotificationMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Signals the start of a task execution and returns the task info.
     * </pre>
     */
    public com.google.cloud.osconfig.agentendpoint.v1beta.StartNextTaskResponse startNextTask(com.google.cloud.osconfig.agentendpoint.v1beta.StartNextTaskRequest request) {
      return blockingUnaryCall(
          getChannel(), getStartNextTaskMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Signals an intermediary progress checkpoint in task execution.
     * </pre>
     */
    public com.google.cloud.osconfig.agentendpoint.v1beta.ReportTaskProgressResponse reportTaskProgress(com.google.cloud.osconfig.agentendpoint.v1beta.ReportTaskProgressRequest request) {
      return blockingUnaryCall(
          getChannel(), getReportTaskProgressMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Signals that the task execution is complete and optionally returns the next
     * task.
     * </pre>
     */
    public com.google.cloud.osconfig.agentendpoint.v1beta.ReportTaskCompleteResponse reportTaskComplete(com.google.cloud.osconfig.agentendpoint.v1beta.ReportTaskCompleteRequest request) {
      return blockingUnaryCall(
          getChannel(), getReportTaskCompleteMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Lookup the effective guest policy that applies to a VM instance. This
     * lookup merges all policies that are assigned to the instance ancestry.
     * </pre>
     */
    public com.google.cloud.osconfig.agentendpoint.v1beta.GuestPolicies.EffectiveGuestPolicy lookupEffectiveGuestPolicy(com.google.cloud.osconfig.agentendpoint.v1beta.GuestPolicies.LookupEffectiveGuestPolicyRequest request) {
      return blockingUnaryCall(
          getChannel(), getLookupEffectiveGuestPolicyMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Registers the agent running on the VM.
     * </pre>
     */
    public com.google.cloud.osconfig.agentendpoint.v1beta.RegisterAgentResponse registerAgent(com.google.cloud.osconfig.agentendpoint.v1beta.RegisterAgentRequest request) {
      return blockingUnaryCall(
          getChannel(), getRegisterAgentMethod(), getCallOptions(), request);
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
    public com.google.common.util.concurrent.ListenableFuture<com.google.cloud.osconfig.agentendpoint.v1beta.StartNextTaskResponse> startNextTask(
        com.google.cloud.osconfig.agentendpoint.v1beta.StartNextTaskRequest request) {
      return futureUnaryCall(
          getChannel().newCall(getStartNextTaskMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Signals an intermediary progress checkpoint in task execution.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.cloud.osconfig.agentendpoint.v1beta.ReportTaskProgressResponse> reportTaskProgress(
        com.google.cloud.osconfig.agentendpoint.v1beta.ReportTaskProgressRequest request) {
      return futureUnaryCall(
          getChannel().newCall(getReportTaskProgressMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Signals that the task execution is complete and optionally returns the next
     * task.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.cloud.osconfig.agentendpoint.v1beta.ReportTaskCompleteResponse> reportTaskComplete(
        com.google.cloud.osconfig.agentendpoint.v1beta.ReportTaskCompleteRequest request) {
      return futureUnaryCall(
          getChannel().newCall(getReportTaskCompleteMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Lookup the effective guest policy that applies to a VM instance. This
     * lookup merges all policies that are assigned to the instance ancestry.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.cloud.osconfig.agentendpoint.v1beta.GuestPolicies.EffectiveGuestPolicy> lookupEffectiveGuestPolicy(
        com.google.cloud.osconfig.agentendpoint.v1beta.GuestPolicies.LookupEffectiveGuestPolicyRequest request) {
      return futureUnaryCall(
          getChannel().newCall(getLookupEffectiveGuestPolicyMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Registers the agent running on the VM.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.cloud.osconfig.agentendpoint.v1beta.RegisterAgentResponse> registerAgent(
        com.google.cloud.osconfig.agentendpoint.v1beta.RegisterAgentRequest request) {
      return futureUnaryCall(
          getChannel().newCall(getRegisterAgentMethod(), getCallOptions()), request);
    }
  }

  private static final int METHODID_RECEIVE_TASK_NOTIFICATION = 0;
  private static final int METHODID_START_NEXT_TASK = 1;
  private static final int METHODID_REPORT_TASK_PROGRESS = 2;
  private static final int METHODID_REPORT_TASK_COMPLETE = 3;
  private static final int METHODID_LOOKUP_EFFECTIVE_GUEST_POLICY = 4;
  private static final int METHODID_REGISTER_AGENT = 5;

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
          serviceImpl.receiveTaskNotification((com.google.cloud.osconfig.agentendpoint.v1beta.ReceiveTaskNotificationRequest) request,
              (io.grpc.stub.StreamObserver<com.google.cloud.osconfig.agentendpoint.v1beta.ReceiveTaskNotificationResponse>) responseObserver);
          break;
        case METHODID_START_NEXT_TASK:
          serviceImpl.startNextTask((com.google.cloud.osconfig.agentendpoint.v1beta.StartNextTaskRequest) request,
              (io.grpc.stub.StreamObserver<com.google.cloud.osconfig.agentendpoint.v1beta.StartNextTaskResponse>) responseObserver);
          break;
        case METHODID_REPORT_TASK_PROGRESS:
          serviceImpl.reportTaskProgress((com.google.cloud.osconfig.agentendpoint.v1beta.ReportTaskProgressRequest) request,
              (io.grpc.stub.StreamObserver<com.google.cloud.osconfig.agentendpoint.v1beta.ReportTaskProgressResponse>) responseObserver);
          break;
        case METHODID_REPORT_TASK_COMPLETE:
          serviceImpl.reportTaskComplete((com.google.cloud.osconfig.agentendpoint.v1beta.ReportTaskCompleteRequest) request,
              (io.grpc.stub.StreamObserver<com.google.cloud.osconfig.agentendpoint.v1beta.ReportTaskCompleteResponse>) responseObserver);
          break;
        case METHODID_LOOKUP_EFFECTIVE_GUEST_POLICY:
          serviceImpl.lookupEffectiveGuestPolicy((com.google.cloud.osconfig.agentendpoint.v1beta.GuestPolicies.LookupEffectiveGuestPolicyRequest) request,
              (io.grpc.stub.StreamObserver<com.google.cloud.osconfig.agentendpoint.v1beta.GuestPolicies.EffectiveGuestPolicy>) responseObserver);
          break;
        case METHODID_REGISTER_AGENT:
          serviceImpl.registerAgent((com.google.cloud.osconfig.agentendpoint.v1beta.RegisterAgentRequest) request,
              (io.grpc.stub.StreamObserver<com.google.cloud.osconfig.agentendpoint.v1beta.RegisterAgentResponse>) responseObserver);
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
      return com.google.cloud.osconfig.agentendpoint.v1beta.AgentEndpointProto.getDescriptor();
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
              .addMethod(getLookupEffectiveGuestPolicyMethod())
              .addMethod(getRegisterAgentMethod())
              .build();
        }
      }
    }
    return result;
  }
}
