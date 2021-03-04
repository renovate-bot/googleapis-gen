package com.google.cloud.dialogflow.v2;

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
 * Service for managing [ConversationProfiles][google.cloud.dialogflow.v2.ConversationProfile].
 * </pre>
 */
@javax.annotation.Generated(
    value = "by gRPC proto compiler",
    comments = "Source: google/cloud/dialogflow/v2/conversation_profile.proto")
public final class ConversationProfilesGrpc {

  private ConversationProfilesGrpc() {}

  public static final String SERVICE_NAME = "google.cloud.dialogflow.v2.ConversationProfiles";

  // Static method descriptors that strictly reflect the proto.
  private static volatile io.grpc.MethodDescriptor<com.google.cloud.dialogflow.v2.ListConversationProfilesRequest,
      com.google.cloud.dialogflow.v2.ListConversationProfilesResponse> getListConversationProfilesMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "ListConversationProfiles",
      requestType = com.google.cloud.dialogflow.v2.ListConversationProfilesRequest.class,
      responseType = com.google.cloud.dialogflow.v2.ListConversationProfilesResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.cloud.dialogflow.v2.ListConversationProfilesRequest,
      com.google.cloud.dialogflow.v2.ListConversationProfilesResponse> getListConversationProfilesMethod() {
    io.grpc.MethodDescriptor<com.google.cloud.dialogflow.v2.ListConversationProfilesRequest, com.google.cloud.dialogflow.v2.ListConversationProfilesResponse> getListConversationProfilesMethod;
    if ((getListConversationProfilesMethod = ConversationProfilesGrpc.getListConversationProfilesMethod) == null) {
      synchronized (ConversationProfilesGrpc.class) {
        if ((getListConversationProfilesMethod = ConversationProfilesGrpc.getListConversationProfilesMethod) == null) {
          ConversationProfilesGrpc.getListConversationProfilesMethod = getListConversationProfilesMethod =
              io.grpc.MethodDescriptor.<com.google.cloud.dialogflow.v2.ListConversationProfilesRequest, com.google.cloud.dialogflow.v2.ListConversationProfilesResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "ListConversationProfiles"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.dialogflow.v2.ListConversationProfilesRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.dialogflow.v2.ListConversationProfilesResponse.getDefaultInstance()))
              .setSchemaDescriptor(new ConversationProfilesMethodDescriptorSupplier("ListConversationProfiles"))
              .build();
        }
      }
    }
    return getListConversationProfilesMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.cloud.dialogflow.v2.GetConversationProfileRequest,
      com.google.cloud.dialogflow.v2.ConversationProfile> getGetConversationProfileMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "GetConversationProfile",
      requestType = com.google.cloud.dialogflow.v2.GetConversationProfileRequest.class,
      responseType = com.google.cloud.dialogflow.v2.ConversationProfile.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.cloud.dialogflow.v2.GetConversationProfileRequest,
      com.google.cloud.dialogflow.v2.ConversationProfile> getGetConversationProfileMethod() {
    io.grpc.MethodDescriptor<com.google.cloud.dialogflow.v2.GetConversationProfileRequest, com.google.cloud.dialogflow.v2.ConversationProfile> getGetConversationProfileMethod;
    if ((getGetConversationProfileMethod = ConversationProfilesGrpc.getGetConversationProfileMethod) == null) {
      synchronized (ConversationProfilesGrpc.class) {
        if ((getGetConversationProfileMethod = ConversationProfilesGrpc.getGetConversationProfileMethod) == null) {
          ConversationProfilesGrpc.getGetConversationProfileMethod = getGetConversationProfileMethod =
              io.grpc.MethodDescriptor.<com.google.cloud.dialogflow.v2.GetConversationProfileRequest, com.google.cloud.dialogflow.v2.ConversationProfile>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "GetConversationProfile"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.dialogflow.v2.GetConversationProfileRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.dialogflow.v2.ConversationProfile.getDefaultInstance()))
              .setSchemaDescriptor(new ConversationProfilesMethodDescriptorSupplier("GetConversationProfile"))
              .build();
        }
      }
    }
    return getGetConversationProfileMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.cloud.dialogflow.v2.CreateConversationProfileRequest,
      com.google.cloud.dialogflow.v2.ConversationProfile> getCreateConversationProfileMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "CreateConversationProfile",
      requestType = com.google.cloud.dialogflow.v2.CreateConversationProfileRequest.class,
      responseType = com.google.cloud.dialogflow.v2.ConversationProfile.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.cloud.dialogflow.v2.CreateConversationProfileRequest,
      com.google.cloud.dialogflow.v2.ConversationProfile> getCreateConversationProfileMethod() {
    io.grpc.MethodDescriptor<com.google.cloud.dialogflow.v2.CreateConversationProfileRequest, com.google.cloud.dialogflow.v2.ConversationProfile> getCreateConversationProfileMethod;
    if ((getCreateConversationProfileMethod = ConversationProfilesGrpc.getCreateConversationProfileMethod) == null) {
      synchronized (ConversationProfilesGrpc.class) {
        if ((getCreateConversationProfileMethod = ConversationProfilesGrpc.getCreateConversationProfileMethod) == null) {
          ConversationProfilesGrpc.getCreateConversationProfileMethod = getCreateConversationProfileMethod =
              io.grpc.MethodDescriptor.<com.google.cloud.dialogflow.v2.CreateConversationProfileRequest, com.google.cloud.dialogflow.v2.ConversationProfile>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "CreateConversationProfile"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.dialogflow.v2.CreateConversationProfileRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.dialogflow.v2.ConversationProfile.getDefaultInstance()))
              .setSchemaDescriptor(new ConversationProfilesMethodDescriptorSupplier("CreateConversationProfile"))
              .build();
        }
      }
    }
    return getCreateConversationProfileMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.cloud.dialogflow.v2.UpdateConversationProfileRequest,
      com.google.cloud.dialogflow.v2.ConversationProfile> getUpdateConversationProfileMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "UpdateConversationProfile",
      requestType = com.google.cloud.dialogflow.v2.UpdateConversationProfileRequest.class,
      responseType = com.google.cloud.dialogflow.v2.ConversationProfile.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.cloud.dialogflow.v2.UpdateConversationProfileRequest,
      com.google.cloud.dialogflow.v2.ConversationProfile> getUpdateConversationProfileMethod() {
    io.grpc.MethodDescriptor<com.google.cloud.dialogflow.v2.UpdateConversationProfileRequest, com.google.cloud.dialogflow.v2.ConversationProfile> getUpdateConversationProfileMethod;
    if ((getUpdateConversationProfileMethod = ConversationProfilesGrpc.getUpdateConversationProfileMethod) == null) {
      synchronized (ConversationProfilesGrpc.class) {
        if ((getUpdateConversationProfileMethod = ConversationProfilesGrpc.getUpdateConversationProfileMethod) == null) {
          ConversationProfilesGrpc.getUpdateConversationProfileMethod = getUpdateConversationProfileMethod =
              io.grpc.MethodDescriptor.<com.google.cloud.dialogflow.v2.UpdateConversationProfileRequest, com.google.cloud.dialogflow.v2.ConversationProfile>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "UpdateConversationProfile"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.dialogflow.v2.UpdateConversationProfileRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.dialogflow.v2.ConversationProfile.getDefaultInstance()))
              .setSchemaDescriptor(new ConversationProfilesMethodDescriptorSupplier("UpdateConversationProfile"))
              .build();
        }
      }
    }
    return getUpdateConversationProfileMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.cloud.dialogflow.v2.DeleteConversationProfileRequest,
      com.google.protobuf.Empty> getDeleteConversationProfileMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "DeleteConversationProfile",
      requestType = com.google.cloud.dialogflow.v2.DeleteConversationProfileRequest.class,
      responseType = com.google.protobuf.Empty.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.cloud.dialogflow.v2.DeleteConversationProfileRequest,
      com.google.protobuf.Empty> getDeleteConversationProfileMethod() {
    io.grpc.MethodDescriptor<com.google.cloud.dialogflow.v2.DeleteConversationProfileRequest, com.google.protobuf.Empty> getDeleteConversationProfileMethod;
    if ((getDeleteConversationProfileMethod = ConversationProfilesGrpc.getDeleteConversationProfileMethod) == null) {
      synchronized (ConversationProfilesGrpc.class) {
        if ((getDeleteConversationProfileMethod = ConversationProfilesGrpc.getDeleteConversationProfileMethod) == null) {
          ConversationProfilesGrpc.getDeleteConversationProfileMethod = getDeleteConversationProfileMethod =
              io.grpc.MethodDescriptor.<com.google.cloud.dialogflow.v2.DeleteConversationProfileRequest, com.google.protobuf.Empty>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "DeleteConversationProfile"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.dialogflow.v2.DeleteConversationProfileRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.protobuf.Empty.getDefaultInstance()))
              .setSchemaDescriptor(new ConversationProfilesMethodDescriptorSupplier("DeleteConversationProfile"))
              .build();
        }
      }
    }
    return getDeleteConversationProfileMethod;
  }

  /**
   * Creates a new async stub that supports all call types for the service
   */
  public static ConversationProfilesStub newStub(io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<ConversationProfilesStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<ConversationProfilesStub>() {
        @java.lang.Override
        public ConversationProfilesStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new ConversationProfilesStub(channel, callOptions);
        }
      };
    return ConversationProfilesStub.newStub(factory, channel);
  }

  /**
   * Creates a new blocking-style stub that supports unary and streaming output calls on the service
   */
  public static ConversationProfilesBlockingStub newBlockingStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<ConversationProfilesBlockingStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<ConversationProfilesBlockingStub>() {
        @java.lang.Override
        public ConversationProfilesBlockingStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new ConversationProfilesBlockingStub(channel, callOptions);
        }
      };
    return ConversationProfilesBlockingStub.newStub(factory, channel);
  }

  /**
   * Creates a new ListenableFuture-style stub that supports unary calls on the service
   */
  public static ConversationProfilesFutureStub newFutureStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<ConversationProfilesFutureStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<ConversationProfilesFutureStub>() {
        @java.lang.Override
        public ConversationProfilesFutureStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new ConversationProfilesFutureStub(channel, callOptions);
        }
      };
    return ConversationProfilesFutureStub.newStub(factory, channel);
  }

  /**
   * <pre>
   * Service for managing [ConversationProfiles][google.cloud.dialogflow.v2.ConversationProfile].
   * </pre>
   */
  public static abstract class ConversationProfilesImplBase implements io.grpc.BindableService {

    /**
     * <pre>
     * Returns the list of all conversation profiles in the specified project.
     * </pre>
     */
    public void listConversationProfiles(com.google.cloud.dialogflow.v2.ListConversationProfilesRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.dialogflow.v2.ListConversationProfilesResponse> responseObserver) {
      asyncUnimplementedUnaryCall(getListConversationProfilesMethod(), responseObserver);
    }

    /**
     * <pre>
     * Retrieves the specified conversation profile.
     * </pre>
     */
    public void getConversationProfile(com.google.cloud.dialogflow.v2.GetConversationProfileRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.dialogflow.v2.ConversationProfile> responseObserver) {
      asyncUnimplementedUnaryCall(getGetConversationProfileMethod(), responseObserver);
    }

    /**
     * <pre>
     * Creates a conversation profile in the specified project.
     * [ConversationProfile.CreateTime][] and [ConversationProfile.UpdateTime][]
     * aren't populated in the response. You can retrieve them via
     * [GetConversationProfile][google.cloud.dialogflow.v2.ConversationProfiles.GetConversationProfile] API.
     * </pre>
     */
    public void createConversationProfile(com.google.cloud.dialogflow.v2.CreateConversationProfileRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.dialogflow.v2.ConversationProfile> responseObserver) {
      asyncUnimplementedUnaryCall(getCreateConversationProfileMethod(), responseObserver);
    }

    /**
     * <pre>
     * Updates the specified conversation profile.
     * [ConversationProfile.CreateTime][] and [ConversationProfile.UpdateTime][]
     * aren't populated in the response. You can retrieve them via
     * [GetConversationProfile][google.cloud.dialogflow.v2.ConversationProfiles.GetConversationProfile] API.
     * </pre>
     */
    public void updateConversationProfile(com.google.cloud.dialogflow.v2.UpdateConversationProfileRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.dialogflow.v2.ConversationProfile> responseObserver) {
      asyncUnimplementedUnaryCall(getUpdateConversationProfileMethod(), responseObserver);
    }

    /**
     * <pre>
     * Deletes the specified conversation profile.
     * </pre>
     */
    public void deleteConversationProfile(com.google.cloud.dialogflow.v2.DeleteConversationProfileRequest request,
        io.grpc.stub.StreamObserver<com.google.protobuf.Empty> responseObserver) {
      asyncUnimplementedUnaryCall(getDeleteConversationProfileMethod(), responseObserver);
    }

    @java.lang.Override public final io.grpc.ServerServiceDefinition bindService() {
      return io.grpc.ServerServiceDefinition.builder(getServiceDescriptor())
          .addMethod(
            getListConversationProfilesMethod(),
            asyncUnaryCall(
              new MethodHandlers<
                com.google.cloud.dialogflow.v2.ListConversationProfilesRequest,
                com.google.cloud.dialogflow.v2.ListConversationProfilesResponse>(
                  this, METHODID_LIST_CONVERSATION_PROFILES)))
          .addMethod(
            getGetConversationProfileMethod(),
            asyncUnaryCall(
              new MethodHandlers<
                com.google.cloud.dialogflow.v2.GetConversationProfileRequest,
                com.google.cloud.dialogflow.v2.ConversationProfile>(
                  this, METHODID_GET_CONVERSATION_PROFILE)))
          .addMethod(
            getCreateConversationProfileMethod(),
            asyncUnaryCall(
              new MethodHandlers<
                com.google.cloud.dialogflow.v2.CreateConversationProfileRequest,
                com.google.cloud.dialogflow.v2.ConversationProfile>(
                  this, METHODID_CREATE_CONVERSATION_PROFILE)))
          .addMethod(
            getUpdateConversationProfileMethod(),
            asyncUnaryCall(
              new MethodHandlers<
                com.google.cloud.dialogflow.v2.UpdateConversationProfileRequest,
                com.google.cloud.dialogflow.v2.ConversationProfile>(
                  this, METHODID_UPDATE_CONVERSATION_PROFILE)))
          .addMethod(
            getDeleteConversationProfileMethod(),
            asyncUnaryCall(
              new MethodHandlers<
                com.google.cloud.dialogflow.v2.DeleteConversationProfileRequest,
                com.google.protobuf.Empty>(
                  this, METHODID_DELETE_CONVERSATION_PROFILE)))
          .build();
    }
  }

  /**
   * <pre>
   * Service for managing [ConversationProfiles][google.cloud.dialogflow.v2.ConversationProfile].
   * </pre>
   */
  public static final class ConversationProfilesStub extends io.grpc.stub.AbstractAsyncStub<ConversationProfilesStub> {
    private ConversationProfilesStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected ConversationProfilesStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new ConversationProfilesStub(channel, callOptions);
    }

    /**
     * <pre>
     * Returns the list of all conversation profiles in the specified project.
     * </pre>
     */
    public void listConversationProfiles(com.google.cloud.dialogflow.v2.ListConversationProfilesRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.dialogflow.v2.ListConversationProfilesResponse> responseObserver) {
      asyncUnaryCall(
          getChannel().newCall(getListConversationProfilesMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Retrieves the specified conversation profile.
     * </pre>
     */
    public void getConversationProfile(com.google.cloud.dialogflow.v2.GetConversationProfileRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.dialogflow.v2.ConversationProfile> responseObserver) {
      asyncUnaryCall(
          getChannel().newCall(getGetConversationProfileMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Creates a conversation profile in the specified project.
     * [ConversationProfile.CreateTime][] and [ConversationProfile.UpdateTime][]
     * aren't populated in the response. You can retrieve them via
     * [GetConversationProfile][google.cloud.dialogflow.v2.ConversationProfiles.GetConversationProfile] API.
     * </pre>
     */
    public void createConversationProfile(com.google.cloud.dialogflow.v2.CreateConversationProfileRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.dialogflow.v2.ConversationProfile> responseObserver) {
      asyncUnaryCall(
          getChannel().newCall(getCreateConversationProfileMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Updates the specified conversation profile.
     * [ConversationProfile.CreateTime][] and [ConversationProfile.UpdateTime][]
     * aren't populated in the response. You can retrieve them via
     * [GetConversationProfile][google.cloud.dialogflow.v2.ConversationProfiles.GetConversationProfile] API.
     * </pre>
     */
    public void updateConversationProfile(com.google.cloud.dialogflow.v2.UpdateConversationProfileRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.dialogflow.v2.ConversationProfile> responseObserver) {
      asyncUnaryCall(
          getChannel().newCall(getUpdateConversationProfileMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Deletes the specified conversation profile.
     * </pre>
     */
    public void deleteConversationProfile(com.google.cloud.dialogflow.v2.DeleteConversationProfileRequest request,
        io.grpc.stub.StreamObserver<com.google.protobuf.Empty> responseObserver) {
      asyncUnaryCall(
          getChannel().newCall(getDeleteConversationProfileMethod(), getCallOptions()), request, responseObserver);
    }
  }

  /**
   * <pre>
   * Service for managing [ConversationProfiles][google.cloud.dialogflow.v2.ConversationProfile].
   * </pre>
   */
  public static final class ConversationProfilesBlockingStub extends io.grpc.stub.AbstractBlockingStub<ConversationProfilesBlockingStub> {
    private ConversationProfilesBlockingStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected ConversationProfilesBlockingStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new ConversationProfilesBlockingStub(channel, callOptions);
    }

    /**
     * <pre>
     * Returns the list of all conversation profiles in the specified project.
     * </pre>
     */
    public com.google.cloud.dialogflow.v2.ListConversationProfilesResponse listConversationProfiles(com.google.cloud.dialogflow.v2.ListConversationProfilesRequest request) {
      return blockingUnaryCall(
          getChannel(), getListConversationProfilesMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Retrieves the specified conversation profile.
     * </pre>
     */
    public com.google.cloud.dialogflow.v2.ConversationProfile getConversationProfile(com.google.cloud.dialogflow.v2.GetConversationProfileRequest request) {
      return blockingUnaryCall(
          getChannel(), getGetConversationProfileMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Creates a conversation profile in the specified project.
     * [ConversationProfile.CreateTime][] and [ConversationProfile.UpdateTime][]
     * aren't populated in the response. You can retrieve them via
     * [GetConversationProfile][google.cloud.dialogflow.v2.ConversationProfiles.GetConversationProfile] API.
     * </pre>
     */
    public com.google.cloud.dialogflow.v2.ConversationProfile createConversationProfile(com.google.cloud.dialogflow.v2.CreateConversationProfileRequest request) {
      return blockingUnaryCall(
          getChannel(), getCreateConversationProfileMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Updates the specified conversation profile.
     * [ConversationProfile.CreateTime][] and [ConversationProfile.UpdateTime][]
     * aren't populated in the response. You can retrieve them via
     * [GetConversationProfile][google.cloud.dialogflow.v2.ConversationProfiles.GetConversationProfile] API.
     * </pre>
     */
    public com.google.cloud.dialogflow.v2.ConversationProfile updateConversationProfile(com.google.cloud.dialogflow.v2.UpdateConversationProfileRequest request) {
      return blockingUnaryCall(
          getChannel(), getUpdateConversationProfileMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Deletes the specified conversation profile.
     * </pre>
     */
    public com.google.protobuf.Empty deleteConversationProfile(com.google.cloud.dialogflow.v2.DeleteConversationProfileRequest request) {
      return blockingUnaryCall(
          getChannel(), getDeleteConversationProfileMethod(), getCallOptions(), request);
    }
  }

  /**
   * <pre>
   * Service for managing [ConversationProfiles][google.cloud.dialogflow.v2.ConversationProfile].
   * </pre>
   */
  public static final class ConversationProfilesFutureStub extends io.grpc.stub.AbstractFutureStub<ConversationProfilesFutureStub> {
    private ConversationProfilesFutureStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected ConversationProfilesFutureStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new ConversationProfilesFutureStub(channel, callOptions);
    }

    /**
     * <pre>
     * Returns the list of all conversation profiles in the specified project.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.cloud.dialogflow.v2.ListConversationProfilesResponse> listConversationProfiles(
        com.google.cloud.dialogflow.v2.ListConversationProfilesRequest request) {
      return futureUnaryCall(
          getChannel().newCall(getListConversationProfilesMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Retrieves the specified conversation profile.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.cloud.dialogflow.v2.ConversationProfile> getConversationProfile(
        com.google.cloud.dialogflow.v2.GetConversationProfileRequest request) {
      return futureUnaryCall(
          getChannel().newCall(getGetConversationProfileMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Creates a conversation profile in the specified project.
     * [ConversationProfile.CreateTime][] and [ConversationProfile.UpdateTime][]
     * aren't populated in the response. You can retrieve them via
     * [GetConversationProfile][google.cloud.dialogflow.v2.ConversationProfiles.GetConversationProfile] API.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.cloud.dialogflow.v2.ConversationProfile> createConversationProfile(
        com.google.cloud.dialogflow.v2.CreateConversationProfileRequest request) {
      return futureUnaryCall(
          getChannel().newCall(getCreateConversationProfileMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Updates the specified conversation profile.
     * [ConversationProfile.CreateTime][] and [ConversationProfile.UpdateTime][]
     * aren't populated in the response. You can retrieve them via
     * [GetConversationProfile][google.cloud.dialogflow.v2.ConversationProfiles.GetConversationProfile] API.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.cloud.dialogflow.v2.ConversationProfile> updateConversationProfile(
        com.google.cloud.dialogflow.v2.UpdateConversationProfileRequest request) {
      return futureUnaryCall(
          getChannel().newCall(getUpdateConversationProfileMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Deletes the specified conversation profile.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.protobuf.Empty> deleteConversationProfile(
        com.google.cloud.dialogflow.v2.DeleteConversationProfileRequest request) {
      return futureUnaryCall(
          getChannel().newCall(getDeleteConversationProfileMethod(), getCallOptions()), request);
    }
  }

  private static final int METHODID_LIST_CONVERSATION_PROFILES = 0;
  private static final int METHODID_GET_CONVERSATION_PROFILE = 1;
  private static final int METHODID_CREATE_CONVERSATION_PROFILE = 2;
  private static final int METHODID_UPDATE_CONVERSATION_PROFILE = 3;
  private static final int METHODID_DELETE_CONVERSATION_PROFILE = 4;

  private static final class MethodHandlers<Req, Resp> implements
      io.grpc.stub.ServerCalls.UnaryMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ServerStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ClientStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.BidiStreamingMethod<Req, Resp> {
    private final ConversationProfilesImplBase serviceImpl;
    private final int methodId;

    MethodHandlers(ConversationProfilesImplBase serviceImpl, int methodId) {
      this.serviceImpl = serviceImpl;
      this.methodId = methodId;
    }

    @java.lang.Override
    @java.lang.SuppressWarnings("unchecked")
    public void invoke(Req request, io.grpc.stub.StreamObserver<Resp> responseObserver) {
      switch (methodId) {
        case METHODID_LIST_CONVERSATION_PROFILES:
          serviceImpl.listConversationProfiles((com.google.cloud.dialogflow.v2.ListConversationProfilesRequest) request,
              (io.grpc.stub.StreamObserver<com.google.cloud.dialogflow.v2.ListConversationProfilesResponse>) responseObserver);
          break;
        case METHODID_GET_CONVERSATION_PROFILE:
          serviceImpl.getConversationProfile((com.google.cloud.dialogflow.v2.GetConversationProfileRequest) request,
              (io.grpc.stub.StreamObserver<com.google.cloud.dialogflow.v2.ConversationProfile>) responseObserver);
          break;
        case METHODID_CREATE_CONVERSATION_PROFILE:
          serviceImpl.createConversationProfile((com.google.cloud.dialogflow.v2.CreateConversationProfileRequest) request,
              (io.grpc.stub.StreamObserver<com.google.cloud.dialogflow.v2.ConversationProfile>) responseObserver);
          break;
        case METHODID_UPDATE_CONVERSATION_PROFILE:
          serviceImpl.updateConversationProfile((com.google.cloud.dialogflow.v2.UpdateConversationProfileRequest) request,
              (io.grpc.stub.StreamObserver<com.google.cloud.dialogflow.v2.ConversationProfile>) responseObserver);
          break;
        case METHODID_DELETE_CONVERSATION_PROFILE:
          serviceImpl.deleteConversationProfile((com.google.cloud.dialogflow.v2.DeleteConversationProfileRequest) request,
              (io.grpc.stub.StreamObserver<com.google.protobuf.Empty>) responseObserver);
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

  private static abstract class ConversationProfilesBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoFileDescriptorSupplier, io.grpc.protobuf.ProtoServiceDescriptorSupplier {
    ConversationProfilesBaseDescriptorSupplier() {}

    @java.lang.Override
    public com.google.protobuf.Descriptors.FileDescriptor getFileDescriptor() {
      return com.google.cloud.dialogflow.v2.ConversationProfileProto.getDescriptor();
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.ServiceDescriptor getServiceDescriptor() {
      return getFileDescriptor().findServiceByName("ConversationProfiles");
    }
  }

  private static final class ConversationProfilesFileDescriptorSupplier
      extends ConversationProfilesBaseDescriptorSupplier {
    ConversationProfilesFileDescriptorSupplier() {}
  }

  private static final class ConversationProfilesMethodDescriptorSupplier
      extends ConversationProfilesBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoMethodDescriptorSupplier {
    private final String methodName;

    ConversationProfilesMethodDescriptorSupplier(String methodName) {
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
      synchronized (ConversationProfilesGrpc.class) {
        result = serviceDescriptor;
        if (result == null) {
          serviceDescriptor = result = io.grpc.ServiceDescriptor.newBuilder(SERVICE_NAME)
              .setSchemaDescriptor(new ConversationProfilesFileDescriptorSupplier())
              .addMethod(getListConversationProfilesMethod())
              .addMethod(getGetConversationProfileMethod())
              .addMethod(getCreateConversationProfileMethod())
              .addMethod(getUpdateConversationProfileMethod())
              .addMethod(getDeleteConversationProfileMethod())
              .build();
        }
      }
    }
    return result;
  }
}
