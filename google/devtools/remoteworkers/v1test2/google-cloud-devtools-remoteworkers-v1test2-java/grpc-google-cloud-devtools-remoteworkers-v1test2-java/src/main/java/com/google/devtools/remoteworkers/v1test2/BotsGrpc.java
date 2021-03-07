package com.google.devtools.remoteworkers.v1test2;

import static io.grpc.MethodDescriptor.generateFullMethodName;

/**
 * <pre>
 * Design doc: https://goo.gl/oojM5H
 * Loosely speaking, the Bots interface monitors a collection of workers (think
 * of them as "computers" for a moment). This collection is known as a "farm,"
 * and its purpose is to perform work on behalf of a client.
 * Each worker runs a small program known as a "bot" that allows it to be
 * controlled by the server. This interface contains only methods that are
 * called by the bots themselves; admin functionality is out of scope for this
 * interface.
 * More precisely, we use the term "worker" to refer to the physical "thing"
 * running the bot. We use the term "worker," and not "machine" or "computer,"
 * since a worker may consist of more than one machine - e.g., a computer with
 * multiple attached devices, or even a cluster of computers, with only one of
 * them running the bot. Conversely, a single machine may host several bots, in
 * which case each bot has a "worker" corresponding to the slice of the machine
 * being managed by that bot.
 * The main resource in the Bots interface is not, surprisingly, a Bot - it is a
 * BotSession, which represents a period of time in which a bot is in continuous
 * contact with the server (see the BotSession message for more information).
 * The parent of a bot session can be thought of as an instance of a farm. That
 * is, one endpoint may be able to manage many farms for many users. For
 * example, for a farm managed through GCP, the parent resource will typically
 * take the form "projects/{project_id}". This is referred to below as "the farm
 * resource."
 * </pre>
 */
@javax.annotation.Generated(
    value = "by gRPC proto compiler",
    comments = "Source: google/devtools/remoteworkers/v1test2/bots.proto")
public final class BotsGrpc {

  private BotsGrpc() {}

  public static final String SERVICE_NAME = "google.devtools.remoteworkers.v1test2.Bots";

  // Static method descriptors that strictly reflect the proto.
  private static volatile io.grpc.MethodDescriptor<com.google.devtools.remoteworkers.v1test2.CreateBotSessionRequest,
      com.google.devtools.remoteworkers.v1test2.BotSession> getCreateBotSessionMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "CreateBotSession",
      requestType = com.google.devtools.remoteworkers.v1test2.CreateBotSessionRequest.class,
      responseType = com.google.devtools.remoteworkers.v1test2.BotSession.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.devtools.remoteworkers.v1test2.CreateBotSessionRequest,
      com.google.devtools.remoteworkers.v1test2.BotSession> getCreateBotSessionMethod() {
    io.grpc.MethodDescriptor<com.google.devtools.remoteworkers.v1test2.CreateBotSessionRequest, com.google.devtools.remoteworkers.v1test2.BotSession> getCreateBotSessionMethod;
    if ((getCreateBotSessionMethod = BotsGrpc.getCreateBotSessionMethod) == null) {
      synchronized (BotsGrpc.class) {
        if ((getCreateBotSessionMethod = BotsGrpc.getCreateBotSessionMethod) == null) {
          BotsGrpc.getCreateBotSessionMethod = getCreateBotSessionMethod =
              io.grpc.MethodDescriptor.<com.google.devtools.remoteworkers.v1test2.CreateBotSessionRequest, com.google.devtools.remoteworkers.v1test2.BotSession>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "CreateBotSession"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.devtools.remoteworkers.v1test2.CreateBotSessionRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.devtools.remoteworkers.v1test2.BotSession.getDefaultInstance()))
              .setSchemaDescriptor(new BotsMethodDescriptorSupplier("CreateBotSession"))
              .build();
        }
      }
    }
    return getCreateBotSessionMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.devtools.remoteworkers.v1test2.UpdateBotSessionRequest,
      com.google.devtools.remoteworkers.v1test2.BotSession> getUpdateBotSessionMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "UpdateBotSession",
      requestType = com.google.devtools.remoteworkers.v1test2.UpdateBotSessionRequest.class,
      responseType = com.google.devtools.remoteworkers.v1test2.BotSession.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.devtools.remoteworkers.v1test2.UpdateBotSessionRequest,
      com.google.devtools.remoteworkers.v1test2.BotSession> getUpdateBotSessionMethod() {
    io.grpc.MethodDescriptor<com.google.devtools.remoteworkers.v1test2.UpdateBotSessionRequest, com.google.devtools.remoteworkers.v1test2.BotSession> getUpdateBotSessionMethod;
    if ((getUpdateBotSessionMethod = BotsGrpc.getUpdateBotSessionMethod) == null) {
      synchronized (BotsGrpc.class) {
        if ((getUpdateBotSessionMethod = BotsGrpc.getUpdateBotSessionMethod) == null) {
          BotsGrpc.getUpdateBotSessionMethod = getUpdateBotSessionMethod =
              io.grpc.MethodDescriptor.<com.google.devtools.remoteworkers.v1test2.UpdateBotSessionRequest, com.google.devtools.remoteworkers.v1test2.BotSession>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "UpdateBotSession"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.devtools.remoteworkers.v1test2.UpdateBotSessionRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.devtools.remoteworkers.v1test2.BotSession.getDefaultInstance()))
              .setSchemaDescriptor(new BotsMethodDescriptorSupplier("UpdateBotSession"))
              .build();
        }
      }
    }
    return getUpdateBotSessionMethod;
  }

  /**
   * Creates a new async stub that supports all call types for the service
   */
  public static BotsStub newStub(io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<BotsStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<BotsStub>() {
        @java.lang.Override
        public BotsStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new BotsStub(channel, callOptions);
        }
      };
    return BotsStub.newStub(factory, channel);
  }

  /**
   * Creates a new blocking-style stub that supports unary and streaming output calls on the service
   */
  public static BotsBlockingStub newBlockingStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<BotsBlockingStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<BotsBlockingStub>() {
        @java.lang.Override
        public BotsBlockingStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new BotsBlockingStub(channel, callOptions);
        }
      };
    return BotsBlockingStub.newStub(factory, channel);
  }

  /**
   * Creates a new ListenableFuture-style stub that supports unary calls on the service
   */
  public static BotsFutureStub newFutureStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<BotsFutureStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<BotsFutureStub>() {
        @java.lang.Override
        public BotsFutureStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new BotsFutureStub(channel, callOptions);
        }
      };
    return BotsFutureStub.newStub(factory, channel);
  }

  /**
   * <pre>
   * Design doc: https://goo.gl/oojM5H
   * Loosely speaking, the Bots interface monitors a collection of workers (think
   * of them as "computers" for a moment). This collection is known as a "farm,"
   * and its purpose is to perform work on behalf of a client.
   * Each worker runs a small program known as a "bot" that allows it to be
   * controlled by the server. This interface contains only methods that are
   * called by the bots themselves; admin functionality is out of scope for this
   * interface.
   * More precisely, we use the term "worker" to refer to the physical "thing"
   * running the bot. We use the term "worker," and not "machine" or "computer,"
   * since a worker may consist of more than one machine - e.g., a computer with
   * multiple attached devices, or even a cluster of computers, with only one of
   * them running the bot. Conversely, a single machine may host several bots, in
   * which case each bot has a "worker" corresponding to the slice of the machine
   * being managed by that bot.
   * The main resource in the Bots interface is not, surprisingly, a Bot - it is a
   * BotSession, which represents a period of time in which a bot is in continuous
   * contact with the server (see the BotSession message for more information).
   * The parent of a bot session can be thought of as an instance of a farm. That
   * is, one endpoint may be able to manage many farms for many users. For
   * example, for a farm managed through GCP, the parent resource will typically
   * take the form "projects/{project_id}". This is referred to below as "the farm
   * resource."
   * </pre>
   */
  public static abstract class BotsImplBase implements io.grpc.BindableService {

    /**
     * <pre>
     * CreateBotSession is called when the bot first joins the farm, and
     * establishes a session ID to ensure that multiple machines do not register
     * using the same name accidentally.
     * </pre>
     */
    public void createBotSession(com.google.devtools.remoteworkers.v1test2.CreateBotSessionRequest request,
        io.grpc.stub.StreamObserver<com.google.devtools.remoteworkers.v1test2.BotSession> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getCreateBotSessionMethod(), responseObserver);
    }

    /**
     * <pre>
     * UpdateBotSession must be called periodically by the bot (on a schedule
     * determined by the server) to let the server know about its status, and to
     * pick up new lease requests from the server.
     * </pre>
     */
    public void updateBotSession(com.google.devtools.remoteworkers.v1test2.UpdateBotSessionRequest request,
        io.grpc.stub.StreamObserver<com.google.devtools.remoteworkers.v1test2.BotSession> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getUpdateBotSessionMethod(), responseObserver);
    }

    @java.lang.Override public final io.grpc.ServerServiceDefinition bindService() {
      return io.grpc.ServerServiceDefinition.builder(getServiceDescriptor())
          .addMethod(
            getCreateBotSessionMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.devtools.remoteworkers.v1test2.CreateBotSessionRequest,
                com.google.devtools.remoteworkers.v1test2.BotSession>(
                  this, METHODID_CREATE_BOT_SESSION)))
          .addMethod(
            getUpdateBotSessionMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.devtools.remoteworkers.v1test2.UpdateBotSessionRequest,
                com.google.devtools.remoteworkers.v1test2.BotSession>(
                  this, METHODID_UPDATE_BOT_SESSION)))
          .build();
    }
  }

  /**
   * <pre>
   * Design doc: https://goo.gl/oojM5H
   * Loosely speaking, the Bots interface monitors a collection of workers (think
   * of them as "computers" for a moment). This collection is known as a "farm,"
   * and its purpose is to perform work on behalf of a client.
   * Each worker runs a small program known as a "bot" that allows it to be
   * controlled by the server. This interface contains only methods that are
   * called by the bots themselves; admin functionality is out of scope for this
   * interface.
   * More precisely, we use the term "worker" to refer to the physical "thing"
   * running the bot. We use the term "worker," and not "machine" or "computer,"
   * since a worker may consist of more than one machine - e.g., a computer with
   * multiple attached devices, or even a cluster of computers, with only one of
   * them running the bot. Conversely, a single machine may host several bots, in
   * which case each bot has a "worker" corresponding to the slice of the machine
   * being managed by that bot.
   * The main resource in the Bots interface is not, surprisingly, a Bot - it is a
   * BotSession, which represents a period of time in which a bot is in continuous
   * contact with the server (see the BotSession message for more information).
   * The parent of a bot session can be thought of as an instance of a farm. That
   * is, one endpoint may be able to manage many farms for many users. For
   * example, for a farm managed through GCP, the parent resource will typically
   * take the form "projects/{project_id}". This is referred to below as "the farm
   * resource."
   * </pre>
   */
  public static final class BotsStub extends io.grpc.stub.AbstractAsyncStub<BotsStub> {
    private BotsStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected BotsStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new BotsStub(channel, callOptions);
    }

    /**
     * <pre>
     * CreateBotSession is called when the bot first joins the farm, and
     * establishes a session ID to ensure that multiple machines do not register
     * using the same name accidentally.
     * </pre>
     */
    public void createBotSession(com.google.devtools.remoteworkers.v1test2.CreateBotSessionRequest request,
        io.grpc.stub.StreamObserver<com.google.devtools.remoteworkers.v1test2.BotSession> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getCreateBotSessionMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * UpdateBotSession must be called periodically by the bot (on a schedule
     * determined by the server) to let the server know about its status, and to
     * pick up new lease requests from the server.
     * </pre>
     */
    public void updateBotSession(com.google.devtools.remoteworkers.v1test2.UpdateBotSessionRequest request,
        io.grpc.stub.StreamObserver<com.google.devtools.remoteworkers.v1test2.BotSession> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getUpdateBotSessionMethod(), getCallOptions()), request, responseObserver);
    }
  }

  /**
   * <pre>
   * Design doc: https://goo.gl/oojM5H
   * Loosely speaking, the Bots interface monitors a collection of workers (think
   * of them as "computers" for a moment). This collection is known as a "farm,"
   * and its purpose is to perform work on behalf of a client.
   * Each worker runs a small program known as a "bot" that allows it to be
   * controlled by the server. This interface contains only methods that are
   * called by the bots themselves; admin functionality is out of scope for this
   * interface.
   * More precisely, we use the term "worker" to refer to the physical "thing"
   * running the bot. We use the term "worker," and not "machine" or "computer,"
   * since a worker may consist of more than one machine - e.g., a computer with
   * multiple attached devices, or even a cluster of computers, with only one of
   * them running the bot. Conversely, a single machine may host several bots, in
   * which case each bot has a "worker" corresponding to the slice of the machine
   * being managed by that bot.
   * The main resource in the Bots interface is not, surprisingly, a Bot - it is a
   * BotSession, which represents a period of time in which a bot is in continuous
   * contact with the server (see the BotSession message for more information).
   * The parent of a bot session can be thought of as an instance of a farm. That
   * is, one endpoint may be able to manage many farms for many users. For
   * example, for a farm managed through GCP, the parent resource will typically
   * take the form "projects/{project_id}". This is referred to below as "the farm
   * resource."
   * </pre>
   */
  public static final class BotsBlockingStub extends io.grpc.stub.AbstractBlockingStub<BotsBlockingStub> {
    private BotsBlockingStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected BotsBlockingStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new BotsBlockingStub(channel, callOptions);
    }

    /**
     * <pre>
     * CreateBotSession is called when the bot first joins the farm, and
     * establishes a session ID to ensure that multiple machines do not register
     * using the same name accidentally.
     * </pre>
     */
    public com.google.devtools.remoteworkers.v1test2.BotSession createBotSession(com.google.devtools.remoteworkers.v1test2.CreateBotSessionRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getCreateBotSessionMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * UpdateBotSession must be called periodically by the bot (on a schedule
     * determined by the server) to let the server know about its status, and to
     * pick up new lease requests from the server.
     * </pre>
     */
    public com.google.devtools.remoteworkers.v1test2.BotSession updateBotSession(com.google.devtools.remoteworkers.v1test2.UpdateBotSessionRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getUpdateBotSessionMethod(), getCallOptions(), request);
    }
  }

  /**
   * <pre>
   * Design doc: https://goo.gl/oojM5H
   * Loosely speaking, the Bots interface monitors a collection of workers (think
   * of them as "computers" for a moment). This collection is known as a "farm,"
   * and its purpose is to perform work on behalf of a client.
   * Each worker runs a small program known as a "bot" that allows it to be
   * controlled by the server. This interface contains only methods that are
   * called by the bots themselves; admin functionality is out of scope for this
   * interface.
   * More precisely, we use the term "worker" to refer to the physical "thing"
   * running the bot. We use the term "worker," and not "machine" or "computer,"
   * since a worker may consist of more than one machine - e.g., a computer with
   * multiple attached devices, or even a cluster of computers, with only one of
   * them running the bot. Conversely, a single machine may host several bots, in
   * which case each bot has a "worker" corresponding to the slice of the machine
   * being managed by that bot.
   * The main resource in the Bots interface is not, surprisingly, a Bot - it is a
   * BotSession, which represents a period of time in which a bot is in continuous
   * contact with the server (see the BotSession message for more information).
   * The parent of a bot session can be thought of as an instance of a farm. That
   * is, one endpoint may be able to manage many farms for many users. For
   * example, for a farm managed through GCP, the parent resource will typically
   * take the form "projects/{project_id}". This is referred to below as "the farm
   * resource."
   * </pre>
   */
  public static final class BotsFutureStub extends io.grpc.stub.AbstractFutureStub<BotsFutureStub> {
    private BotsFutureStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected BotsFutureStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new BotsFutureStub(channel, callOptions);
    }

    /**
     * <pre>
     * CreateBotSession is called when the bot first joins the farm, and
     * establishes a session ID to ensure that multiple machines do not register
     * using the same name accidentally.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.devtools.remoteworkers.v1test2.BotSession> createBotSession(
        com.google.devtools.remoteworkers.v1test2.CreateBotSessionRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getCreateBotSessionMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * UpdateBotSession must be called periodically by the bot (on a schedule
     * determined by the server) to let the server know about its status, and to
     * pick up new lease requests from the server.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.devtools.remoteworkers.v1test2.BotSession> updateBotSession(
        com.google.devtools.remoteworkers.v1test2.UpdateBotSessionRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getUpdateBotSessionMethod(), getCallOptions()), request);
    }
  }

  private static final int METHODID_CREATE_BOT_SESSION = 0;
  private static final int METHODID_UPDATE_BOT_SESSION = 1;

  private static final class MethodHandlers<Req, Resp> implements
      io.grpc.stub.ServerCalls.UnaryMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ServerStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ClientStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.BidiStreamingMethod<Req, Resp> {
    private final BotsImplBase serviceImpl;
    private final int methodId;

    MethodHandlers(BotsImplBase serviceImpl, int methodId) {
      this.serviceImpl = serviceImpl;
      this.methodId = methodId;
    }

    @java.lang.Override
    @java.lang.SuppressWarnings("unchecked")
    public void invoke(Req request, io.grpc.stub.StreamObserver<Resp> responseObserver) {
      switch (methodId) {
        case METHODID_CREATE_BOT_SESSION:
          serviceImpl.createBotSession((com.google.devtools.remoteworkers.v1test2.CreateBotSessionRequest) request,
              (io.grpc.stub.StreamObserver<com.google.devtools.remoteworkers.v1test2.BotSession>) responseObserver);
          break;
        case METHODID_UPDATE_BOT_SESSION:
          serviceImpl.updateBotSession((com.google.devtools.remoteworkers.v1test2.UpdateBotSessionRequest) request,
              (io.grpc.stub.StreamObserver<com.google.devtools.remoteworkers.v1test2.BotSession>) responseObserver);
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

  private static abstract class BotsBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoFileDescriptorSupplier, io.grpc.protobuf.ProtoServiceDescriptorSupplier {
    BotsBaseDescriptorSupplier() {}

    @java.lang.Override
    public com.google.protobuf.Descriptors.FileDescriptor getFileDescriptor() {
      return com.google.devtools.remoteworkers.v1test2.RemoteWorkersBots.getDescriptor();
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.ServiceDescriptor getServiceDescriptor() {
      return getFileDescriptor().findServiceByName("Bots");
    }
  }

  private static final class BotsFileDescriptorSupplier
      extends BotsBaseDescriptorSupplier {
    BotsFileDescriptorSupplier() {}
  }

  private static final class BotsMethodDescriptorSupplier
      extends BotsBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoMethodDescriptorSupplier {
    private final String methodName;

    BotsMethodDescriptorSupplier(String methodName) {
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
      synchronized (BotsGrpc.class) {
        result = serviceDescriptor;
        if (result == null) {
          serviceDescriptor = result = io.grpc.ServiceDescriptor.newBuilder(SERVICE_NAME)
              .setSchemaDescriptor(new BotsFileDescriptorSupplier())
              .addMethod(getCreateBotSessionMethod())
              .addMethod(getUpdateBotSessionMethod())
              .build();
        }
      }
    }
    return result;
  }
}
