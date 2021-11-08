package com.google.maps.playablelocations.v3;

import static io.grpc.MethodDescriptor.generateFullMethodName;

/**
 * <pre>
 * The Playable Locations API for v3.
 * </pre>
 */
@javax.annotation.Generated(
    value = "by gRPC proto compiler",
    comments = "Source: google/maps/playablelocations/v3/playablelocations.proto")
@io.grpc.stub.annotations.GrpcGenerated
public final class PlayableLocationsGrpc {

  private PlayableLocationsGrpc() {}

  public static final String SERVICE_NAME = "google.maps.playablelocations.v3.PlayableLocations";

  // Static method descriptors that strictly reflect the proto.
  private static volatile io.grpc.MethodDescriptor<com.google.maps.playablelocations.v3.SamplePlayableLocationsRequest,
      com.google.maps.playablelocations.v3.SamplePlayableLocationsResponse> getSamplePlayableLocationsMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "SamplePlayableLocations",
      requestType = com.google.maps.playablelocations.v3.SamplePlayableLocationsRequest.class,
      responseType = com.google.maps.playablelocations.v3.SamplePlayableLocationsResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.maps.playablelocations.v3.SamplePlayableLocationsRequest,
      com.google.maps.playablelocations.v3.SamplePlayableLocationsResponse> getSamplePlayableLocationsMethod() {
    io.grpc.MethodDescriptor<com.google.maps.playablelocations.v3.SamplePlayableLocationsRequest, com.google.maps.playablelocations.v3.SamplePlayableLocationsResponse> getSamplePlayableLocationsMethod;
    if ((getSamplePlayableLocationsMethod = PlayableLocationsGrpc.getSamplePlayableLocationsMethod) == null) {
      synchronized (PlayableLocationsGrpc.class) {
        if ((getSamplePlayableLocationsMethod = PlayableLocationsGrpc.getSamplePlayableLocationsMethod) == null) {
          PlayableLocationsGrpc.getSamplePlayableLocationsMethod = getSamplePlayableLocationsMethod =
              io.grpc.MethodDescriptor.<com.google.maps.playablelocations.v3.SamplePlayableLocationsRequest, com.google.maps.playablelocations.v3.SamplePlayableLocationsResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "SamplePlayableLocations"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.maps.playablelocations.v3.SamplePlayableLocationsRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.maps.playablelocations.v3.SamplePlayableLocationsResponse.getDefaultInstance()))
              .setSchemaDescriptor(new PlayableLocationsMethodDescriptorSupplier("SamplePlayableLocations"))
              .build();
        }
      }
    }
    return getSamplePlayableLocationsMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.maps.playablelocations.v3.LogPlayerReportsRequest,
      com.google.maps.playablelocations.v3.LogPlayerReportsResponse> getLogPlayerReportsMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "LogPlayerReports",
      requestType = com.google.maps.playablelocations.v3.LogPlayerReportsRequest.class,
      responseType = com.google.maps.playablelocations.v3.LogPlayerReportsResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.maps.playablelocations.v3.LogPlayerReportsRequest,
      com.google.maps.playablelocations.v3.LogPlayerReportsResponse> getLogPlayerReportsMethod() {
    io.grpc.MethodDescriptor<com.google.maps.playablelocations.v3.LogPlayerReportsRequest, com.google.maps.playablelocations.v3.LogPlayerReportsResponse> getLogPlayerReportsMethod;
    if ((getLogPlayerReportsMethod = PlayableLocationsGrpc.getLogPlayerReportsMethod) == null) {
      synchronized (PlayableLocationsGrpc.class) {
        if ((getLogPlayerReportsMethod = PlayableLocationsGrpc.getLogPlayerReportsMethod) == null) {
          PlayableLocationsGrpc.getLogPlayerReportsMethod = getLogPlayerReportsMethod =
              io.grpc.MethodDescriptor.<com.google.maps.playablelocations.v3.LogPlayerReportsRequest, com.google.maps.playablelocations.v3.LogPlayerReportsResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "LogPlayerReports"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.maps.playablelocations.v3.LogPlayerReportsRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.maps.playablelocations.v3.LogPlayerReportsResponse.getDefaultInstance()))
              .setSchemaDescriptor(new PlayableLocationsMethodDescriptorSupplier("LogPlayerReports"))
              .build();
        }
      }
    }
    return getLogPlayerReportsMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.maps.playablelocations.v3.LogImpressionsRequest,
      com.google.maps.playablelocations.v3.LogImpressionsResponse> getLogImpressionsMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "LogImpressions",
      requestType = com.google.maps.playablelocations.v3.LogImpressionsRequest.class,
      responseType = com.google.maps.playablelocations.v3.LogImpressionsResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.maps.playablelocations.v3.LogImpressionsRequest,
      com.google.maps.playablelocations.v3.LogImpressionsResponse> getLogImpressionsMethod() {
    io.grpc.MethodDescriptor<com.google.maps.playablelocations.v3.LogImpressionsRequest, com.google.maps.playablelocations.v3.LogImpressionsResponse> getLogImpressionsMethod;
    if ((getLogImpressionsMethod = PlayableLocationsGrpc.getLogImpressionsMethod) == null) {
      synchronized (PlayableLocationsGrpc.class) {
        if ((getLogImpressionsMethod = PlayableLocationsGrpc.getLogImpressionsMethod) == null) {
          PlayableLocationsGrpc.getLogImpressionsMethod = getLogImpressionsMethod =
              io.grpc.MethodDescriptor.<com.google.maps.playablelocations.v3.LogImpressionsRequest, com.google.maps.playablelocations.v3.LogImpressionsResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "LogImpressions"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.maps.playablelocations.v3.LogImpressionsRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.maps.playablelocations.v3.LogImpressionsResponse.getDefaultInstance()))
              .setSchemaDescriptor(new PlayableLocationsMethodDescriptorSupplier("LogImpressions"))
              .build();
        }
      }
    }
    return getLogImpressionsMethod;
  }

  /**
   * Creates a new async stub that supports all call types for the service
   */
  public static PlayableLocationsStub newStub(io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<PlayableLocationsStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<PlayableLocationsStub>() {
        @java.lang.Override
        public PlayableLocationsStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new PlayableLocationsStub(channel, callOptions);
        }
      };
    return PlayableLocationsStub.newStub(factory, channel);
  }

  /**
   * Creates a new blocking-style stub that supports unary and streaming output calls on the service
   */
  public static PlayableLocationsBlockingStub newBlockingStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<PlayableLocationsBlockingStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<PlayableLocationsBlockingStub>() {
        @java.lang.Override
        public PlayableLocationsBlockingStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new PlayableLocationsBlockingStub(channel, callOptions);
        }
      };
    return PlayableLocationsBlockingStub.newStub(factory, channel);
  }

  /**
   * Creates a new ListenableFuture-style stub that supports unary calls on the service
   */
  public static PlayableLocationsFutureStub newFutureStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<PlayableLocationsFutureStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<PlayableLocationsFutureStub>() {
        @java.lang.Override
        public PlayableLocationsFutureStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new PlayableLocationsFutureStub(channel, callOptions);
        }
      };
    return PlayableLocationsFutureStub.newStub(factory, channel);
  }

  /**
   * <pre>
   * The Playable Locations API for v3.
   * </pre>
   */
  public static abstract class PlayableLocationsImplBase implements io.grpc.BindableService {

    /**
     * <pre>
     * Returns a set of playable locations that lie within a specified area,
     * that satisfy optional filter criteria.
     * Note: Identical `SamplePlayableLocations` requests can return different
     * results as the state of the world changes over time.
     * </pre>
     */
    public void samplePlayableLocations(com.google.maps.playablelocations.v3.SamplePlayableLocationsRequest request,
        io.grpc.stub.StreamObserver<com.google.maps.playablelocations.v3.SamplePlayableLocationsResponse> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getSamplePlayableLocationsMethod(), responseObserver);
    }

    /**
     * <pre>
     * Logs bad playable location reports submitted by players.
     * Reports are not partially saved; either all reports are saved and this
     * request succeeds, or no reports are saved, and this request fails.
     * </pre>
     */
    public void logPlayerReports(com.google.maps.playablelocations.v3.LogPlayerReportsRequest request,
        io.grpc.stub.StreamObserver<com.google.maps.playablelocations.v3.LogPlayerReportsResponse> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getLogPlayerReportsMethod(), responseObserver);
    }

    /**
     * <pre>
     * Logs new events when playable locations are displayed, and when they are
     * interacted with.
     * Impressions are not partially saved; either all impressions are saved and
     * this request succeeds, or no impressions are saved, and this request fails.
     * </pre>
     */
    public void logImpressions(com.google.maps.playablelocations.v3.LogImpressionsRequest request,
        io.grpc.stub.StreamObserver<com.google.maps.playablelocations.v3.LogImpressionsResponse> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getLogImpressionsMethod(), responseObserver);
    }

    @java.lang.Override public final io.grpc.ServerServiceDefinition bindService() {
      return io.grpc.ServerServiceDefinition.builder(getServiceDescriptor())
          .addMethod(
            getSamplePlayableLocationsMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.maps.playablelocations.v3.SamplePlayableLocationsRequest,
                com.google.maps.playablelocations.v3.SamplePlayableLocationsResponse>(
                  this, METHODID_SAMPLE_PLAYABLE_LOCATIONS)))
          .addMethod(
            getLogPlayerReportsMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.maps.playablelocations.v3.LogPlayerReportsRequest,
                com.google.maps.playablelocations.v3.LogPlayerReportsResponse>(
                  this, METHODID_LOG_PLAYER_REPORTS)))
          .addMethod(
            getLogImpressionsMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.maps.playablelocations.v3.LogImpressionsRequest,
                com.google.maps.playablelocations.v3.LogImpressionsResponse>(
                  this, METHODID_LOG_IMPRESSIONS)))
          .build();
    }
  }

  /**
   * <pre>
   * The Playable Locations API for v3.
   * </pre>
   */
  public static final class PlayableLocationsStub extends io.grpc.stub.AbstractAsyncStub<PlayableLocationsStub> {
    private PlayableLocationsStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected PlayableLocationsStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new PlayableLocationsStub(channel, callOptions);
    }

    /**
     * <pre>
     * Returns a set of playable locations that lie within a specified area,
     * that satisfy optional filter criteria.
     * Note: Identical `SamplePlayableLocations` requests can return different
     * results as the state of the world changes over time.
     * </pre>
     */
    public void samplePlayableLocations(com.google.maps.playablelocations.v3.SamplePlayableLocationsRequest request,
        io.grpc.stub.StreamObserver<com.google.maps.playablelocations.v3.SamplePlayableLocationsResponse> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getSamplePlayableLocationsMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Logs bad playable location reports submitted by players.
     * Reports are not partially saved; either all reports are saved and this
     * request succeeds, or no reports are saved, and this request fails.
     * </pre>
     */
    public void logPlayerReports(com.google.maps.playablelocations.v3.LogPlayerReportsRequest request,
        io.grpc.stub.StreamObserver<com.google.maps.playablelocations.v3.LogPlayerReportsResponse> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getLogPlayerReportsMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Logs new events when playable locations are displayed, and when they are
     * interacted with.
     * Impressions are not partially saved; either all impressions are saved and
     * this request succeeds, or no impressions are saved, and this request fails.
     * </pre>
     */
    public void logImpressions(com.google.maps.playablelocations.v3.LogImpressionsRequest request,
        io.grpc.stub.StreamObserver<com.google.maps.playablelocations.v3.LogImpressionsResponse> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getLogImpressionsMethod(), getCallOptions()), request, responseObserver);
    }
  }

  /**
   * <pre>
   * The Playable Locations API for v3.
   * </pre>
   */
  public static final class PlayableLocationsBlockingStub extends io.grpc.stub.AbstractBlockingStub<PlayableLocationsBlockingStub> {
    private PlayableLocationsBlockingStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected PlayableLocationsBlockingStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new PlayableLocationsBlockingStub(channel, callOptions);
    }

    /**
     * <pre>
     * Returns a set of playable locations that lie within a specified area,
     * that satisfy optional filter criteria.
     * Note: Identical `SamplePlayableLocations` requests can return different
     * results as the state of the world changes over time.
     * </pre>
     */
    public com.google.maps.playablelocations.v3.SamplePlayableLocationsResponse samplePlayableLocations(com.google.maps.playablelocations.v3.SamplePlayableLocationsRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getSamplePlayableLocationsMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Logs bad playable location reports submitted by players.
     * Reports are not partially saved; either all reports are saved and this
     * request succeeds, or no reports are saved, and this request fails.
     * </pre>
     */
    public com.google.maps.playablelocations.v3.LogPlayerReportsResponse logPlayerReports(com.google.maps.playablelocations.v3.LogPlayerReportsRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getLogPlayerReportsMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Logs new events when playable locations are displayed, and when they are
     * interacted with.
     * Impressions are not partially saved; either all impressions are saved and
     * this request succeeds, or no impressions are saved, and this request fails.
     * </pre>
     */
    public com.google.maps.playablelocations.v3.LogImpressionsResponse logImpressions(com.google.maps.playablelocations.v3.LogImpressionsRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getLogImpressionsMethod(), getCallOptions(), request);
    }
  }

  /**
   * <pre>
   * The Playable Locations API for v3.
   * </pre>
   */
  public static final class PlayableLocationsFutureStub extends io.grpc.stub.AbstractFutureStub<PlayableLocationsFutureStub> {
    private PlayableLocationsFutureStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected PlayableLocationsFutureStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new PlayableLocationsFutureStub(channel, callOptions);
    }

    /**
     * <pre>
     * Returns a set of playable locations that lie within a specified area,
     * that satisfy optional filter criteria.
     * Note: Identical `SamplePlayableLocations` requests can return different
     * results as the state of the world changes over time.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.maps.playablelocations.v3.SamplePlayableLocationsResponse> samplePlayableLocations(
        com.google.maps.playablelocations.v3.SamplePlayableLocationsRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getSamplePlayableLocationsMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Logs bad playable location reports submitted by players.
     * Reports are not partially saved; either all reports are saved and this
     * request succeeds, or no reports are saved, and this request fails.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.maps.playablelocations.v3.LogPlayerReportsResponse> logPlayerReports(
        com.google.maps.playablelocations.v3.LogPlayerReportsRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getLogPlayerReportsMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Logs new events when playable locations are displayed, and when they are
     * interacted with.
     * Impressions are not partially saved; either all impressions are saved and
     * this request succeeds, or no impressions are saved, and this request fails.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.maps.playablelocations.v3.LogImpressionsResponse> logImpressions(
        com.google.maps.playablelocations.v3.LogImpressionsRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getLogImpressionsMethod(), getCallOptions()), request);
    }
  }

  private static final int METHODID_SAMPLE_PLAYABLE_LOCATIONS = 0;
  private static final int METHODID_LOG_PLAYER_REPORTS = 1;
  private static final int METHODID_LOG_IMPRESSIONS = 2;

  private static final class MethodHandlers<Req, Resp> implements
      io.grpc.stub.ServerCalls.UnaryMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ServerStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ClientStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.BidiStreamingMethod<Req, Resp> {
    private final PlayableLocationsImplBase serviceImpl;
    private final int methodId;

    MethodHandlers(PlayableLocationsImplBase serviceImpl, int methodId) {
      this.serviceImpl = serviceImpl;
      this.methodId = methodId;
    }

    @java.lang.Override
    @java.lang.SuppressWarnings("unchecked")
    public void invoke(Req request, io.grpc.stub.StreamObserver<Resp> responseObserver) {
      switch (methodId) {
        case METHODID_SAMPLE_PLAYABLE_LOCATIONS:
          serviceImpl.samplePlayableLocations((com.google.maps.playablelocations.v3.SamplePlayableLocationsRequest) request,
              (io.grpc.stub.StreamObserver<com.google.maps.playablelocations.v3.SamplePlayableLocationsResponse>) responseObserver);
          break;
        case METHODID_LOG_PLAYER_REPORTS:
          serviceImpl.logPlayerReports((com.google.maps.playablelocations.v3.LogPlayerReportsRequest) request,
              (io.grpc.stub.StreamObserver<com.google.maps.playablelocations.v3.LogPlayerReportsResponse>) responseObserver);
          break;
        case METHODID_LOG_IMPRESSIONS:
          serviceImpl.logImpressions((com.google.maps.playablelocations.v3.LogImpressionsRequest) request,
              (io.grpc.stub.StreamObserver<com.google.maps.playablelocations.v3.LogImpressionsResponse>) responseObserver);
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

  private static abstract class PlayableLocationsBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoFileDescriptorSupplier, io.grpc.protobuf.ProtoServiceDescriptorSupplier {
    PlayableLocationsBaseDescriptorSupplier() {}

    @java.lang.Override
    public com.google.protobuf.Descriptors.FileDescriptor getFileDescriptor() {
      return com.google.maps.playablelocations.v3.PlayableLocationsProto.getDescriptor();
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.ServiceDescriptor getServiceDescriptor() {
      return getFileDescriptor().findServiceByName("PlayableLocations");
    }
  }

  private static final class PlayableLocationsFileDescriptorSupplier
      extends PlayableLocationsBaseDescriptorSupplier {
    PlayableLocationsFileDescriptorSupplier() {}
  }

  private static final class PlayableLocationsMethodDescriptorSupplier
      extends PlayableLocationsBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoMethodDescriptorSupplier {
    private final String methodName;

    PlayableLocationsMethodDescriptorSupplier(String methodName) {
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
      synchronized (PlayableLocationsGrpc.class) {
        result = serviceDescriptor;
        if (result == null) {
          serviceDescriptor = result = io.grpc.ServiceDescriptor.newBuilder(SERVICE_NAME)
              .setSchemaDescriptor(new PlayableLocationsFileDescriptorSupplier())
              .addMethod(getSamplePlayableLocationsMethod())
              .addMethod(getLogPlayerReportsMethod())
              .addMethod(getLogImpressionsMethod())
              .build();
        }
      }
    }
    return result;
  }
}
