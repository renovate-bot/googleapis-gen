package com.google.chromeos.moblab.v1beta1;

import static io.grpc.MethodDescriptor.generateFullMethodName;

/**
 * <pre>
 * Manages Chrome OS build services.
 * </pre>
 */
@javax.annotation.Generated(
    value = "by gRPC proto compiler",
    comments = "Source: google/chromeos/moblab/v1beta1/build_service.proto")
@io.grpc.stub.annotations.GrpcGenerated
public final class BuildServiceGrpc {

  private BuildServiceGrpc() {}

  public static final String SERVICE_NAME = "google.chromeos.moblab.v1beta1.BuildService";

  // Static method descriptors that strictly reflect the proto.
  private static volatile io.grpc.MethodDescriptor<com.google.chromeos.moblab.v1beta1.ListBuildTargetsRequest,
      com.google.chromeos.moblab.v1beta1.ListBuildTargetsResponse> getListBuildTargetsMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "ListBuildTargets",
      requestType = com.google.chromeos.moblab.v1beta1.ListBuildTargetsRequest.class,
      responseType = com.google.chromeos.moblab.v1beta1.ListBuildTargetsResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.chromeos.moblab.v1beta1.ListBuildTargetsRequest,
      com.google.chromeos.moblab.v1beta1.ListBuildTargetsResponse> getListBuildTargetsMethod() {
    io.grpc.MethodDescriptor<com.google.chromeos.moblab.v1beta1.ListBuildTargetsRequest, com.google.chromeos.moblab.v1beta1.ListBuildTargetsResponse> getListBuildTargetsMethod;
    if ((getListBuildTargetsMethod = BuildServiceGrpc.getListBuildTargetsMethod) == null) {
      synchronized (BuildServiceGrpc.class) {
        if ((getListBuildTargetsMethod = BuildServiceGrpc.getListBuildTargetsMethod) == null) {
          BuildServiceGrpc.getListBuildTargetsMethod = getListBuildTargetsMethod =
              io.grpc.MethodDescriptor.<com.google.chromeos.moblab.v1beta1.ListBuildTargetsRequest, com.google.chromeos.moblab.v1beta1.ListBuildTargetsResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "ListBuildTargets"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.chromeos.moblab.v1beta1.ListBuildTargetsRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.chromeos.moblab.v1beta1.ListBuildTargetsResponse.getDefaultInstance()))
              .setSchemaDescriptor(new BuildServiceMethodDescriptorSupplier("ListBuildTargets"))
              .build();
        }
      }
    }
    return getListBuildTargetsMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.chromeos.moblab.v1beta1.ListModelsRequest,
      com.google.chromeos.moblab.v1beta1.ListModelsResponse> getListModelsMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "ListModels",
      requestType = com.google.chromeos.moblab.v1beta1.ListModelsRequest.class,
      responseType = com.google.chromeos.moblab.v1beta1.ListModelsResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.chromeos.moblab.v1beta1.ListModelsRequest,
      com.google.chromeos.moblab.v1beta1.ListModelsResponse> getListModelsMethod() {
    io.grpc.MethodDescriptor<com.google.chromeos.moblab.v1beta1.ListModelsRequest, com.google.chromeos.moblab.v1beta1.ListModelsResponse> getListModelsMethod;
    if ((getListModelsMethod = BuildServiceGrpc.getListModelsMethod) == null) {
      synchronized (BuildServiceGrpc.class) {
        if ((getListModelsMethod = BuildServiceGrpc.getListModelsMethod) == null) {
          BuildServiceGrpc.getListModelsMethod = getListModelsMethod =
              io.grpc.MethodDescriptor.<com.google.chromeos.moblab.v1beta1.ListModelsRequest, com.google.chromeos.moblab.v1beta1.ListModelsResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "ListModels"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.chromeos.moblab.v1beta1.ListModelsRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.chromeos.moblab.v1beta1.ListModelsResponse.getDefaultInstance()))
              .setSchemaDescriptor(new BuildServiceMethodDescriptorSupplier("ListModels"))
              .build();
        }
      }
    }
    return getListModelsMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.chromeos.moblab.v1beta1.ListBuildsRequest,
      com.google.chromeos.moblab.v1beta1.ListBuildsResponse> getListBuildsMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "ListBuilds",
      requestType = com.google.chromeos.moblab.v1beta1.ListBuildsRequest.class,
      responseType = com.google.chromeos.moblab.v1beta1.ListBuildsResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.chromeos.moblab.v1beta1.ListBuildsRequest,
      com.google.chromeos.moblab.v1beta1.ListBuildsResponse> getListBuildsMethod() {
    io.grpc.MethodDescriptor<com.google.chromeos.moblab.v1beta1.ListBuildsRequest, com.google.chromeos.moblab.v1beta1.ListBuildsResponse> getListBuildsMethod;
    if ((getListBuildsMethod = BuildServiceGrpc.getListBuildsMethod) == null) {
      synchronized (BuildServiceGrpc.class) {
        if ((getListBuildsMethod = BuildServiceGrpc.getListBuildsMethod) == null) {
          BuildServiceGrpc.getListBuildsMethod = getListBuildsMethod =
              io.grpc.MethodDescriptor.<com.google.chromeos.moblab.v1beta1.ListBuildsRequest, com.google.chromeos.moblab.v1beta1.ListBuildsResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "ListBuilds"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.chromeos.moblab.v1beta1.ListBuildsRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.chromeos.moblab.v1beta1.ListBuildsResponse.getDefaultInstance()))
              .setSchemaDescriptor(new BuildServiceMethodDescriptorSupplier("ListBuilds"))
              .build();
        }
      }
    }
    return getListBuildsMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.chromeos.moblab.v1beta1.CheckBuildStageStatusRequest,
      com.google.chromeos.moblab.v1beta1.CheckBuildStageStatusResponse> getCheckBuildStageStatusMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "CheckBuildStageStatus",
      requestType = com.google.chromeos.moblab.v1beta1.CheckBuildStageStatusRequest.class,
      responseType = com.google.chromeos.moblab.v1beta1.CheckBuildStageStatusResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.chromeos.moblab.v1beta1.CheckBuildStageStatusRequest,
      com.google.chromeos.moblab.v1beta1.CheckBuildStageStatusResponse> getCheckBuildStageStatusMethod() {
    io.grpc.MethodDescriptor<com.google.chromeos.moblab.v1beta1.CheckBuildStageStatusRequest, com.google.chromeos.moblab.v1beta1.CheckBuildStageStatusResponse> getCheckBuildStageStatusMethod;
    if ((getCheckBuildStageStatusMethod = BuildServiceGrpc.getCheckBuildStageStatusMethod) == null) {
      synchronized (BuildServiceGrpc.class) {
        if ((getCheckBuildStageStatusMethod = BuildServiceGrpc.getCheckBuildStageStatusMethod) == null) {
          BuildServiceGrpc.getCheckBuildStageStatusMethod = getCheckBuildStageStatusMethod =
              io.grpc.MethodDescriptor.<com.google.chromeos.moblab.v1beta1.CheckBuildStageStatusRequest, com.google.chromeos.moblab.v1beta1.CheckBuildStageStatusResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "CheckBuildStageStatus"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.chromeos.moblab.v1beta1.CheckBuildStageStatusRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.chromeos.moblab.v1beta1.CheckBuildStageStatusResponse.getDefaultInstance()))
              .setSchemaDescriptor(new BuildServiceMethodDescriptorSupplier("CheckBuildStageStatus"))
              .build();
        }
      }
    }
    return getCheckBuildStageStatusMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.chromeos.moblab.v1beta1.StageBuildRequest,
      com.google.longrunning.Operation> getStageBuildMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "StageBuild",
      requestType = com.google.chromeos.moblab.v1beta1.StageBuildRequest.class,
      responseType = com.google.longrunning.Operation.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.chromeos.moblab.v1beta1.StageBuildRequest,
      com.google.longrunning.Operation> getStageBuildMethod() {
    io.grpc.MethodDescriptor<com.google.chromeos.moblab.v1beta1.StageBuildRequest, com.google.longrunning.Operation> getStageBuildMethod;
    if ((getStageBuildMethod = BuildServiceGrpc.getStageBuildMethod) == null) {
      synchronized (BuildServiceGrpc.class) {
        if ((getStageBuildMethod = BuildServiceGrpc.getStageBuildMethod) == null) {
          BuildServiceGrpc.getStageBuildMethod = getStageBuildMethod =
              io.grpc.MethodDescriptor.<com.google.chromeos.moblab.v1beta1.StageBuildRequest, com.google.longrunning.Operation>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "StageBuild"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.chromeos.moblab.v1beta1.StageBuildRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.longrunning.Operation.getDefaultInstance()))
              .setSchemaDescriptor(new BuildServiceMethodDescriptorSupplier("StageBuild"))
              .build();
        }
      }
    }
    return getStageBuildMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.chromeos.moblab.v1beta1.FindMostStableBuildRequest,
      com.google.chromeos.moblab.v1beta1.FindMostStableBuildResponse> getFindMostStableBuildMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "FindMostStableBuild",
      requestType = com.google.chromeos.moblab.v1beta1.FindMostStableBuildRequest.class,
      responseType = com.google.chromeos.moblab.v1beta1.FindMostStableBuildResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.chromeos.moblab.v1beta1.FindMostStableBuildRequest,
      com.google.chromeos.moblab.v1beta1.FindMostStableBuildResponse> getFindMostStableBuildMethod() {
    io.grpc.MethodDescriptor<com.google.chromeos.moblab.v1beta1.FindMostStableBuildRequest, com.google.chromeos.moblab.v1beta1.FindMostStableBuildResponse> getFindMostStableBuildMethod;
    if ((getFindMostStableBuildMethod = BuildServiceGrpc.getFindMostStableBuildMethod) == null) {
      synchronized (BuildServiceGrpc.class) {
        if ((getFindMostStableBuildMethod = BuildServiceGrpc.getFindMostStableBuildMethod) == null) {
          BuildServiceGrpc.getFindMostStableBuildMethod = getFindMostStableBuildMethod =
              io.grpc.MethodDescriptor.<com.google.chromeos.moblab.v1beta1.FindMostStableBuildRequest, com.google.chromeos.moblab.v1beta1.FindMostStableBuildResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "FindMostStableBuild"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.chromeos.moblab.v1beta1.FindMostStableBuildRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.chromeos.moblab.v1beta1.FindMostStableBuildResponse.getDefaultInstance()))
              .setSchemaDescriptor(new BuildServiceMethodDescriptorSupplier("FindMostStableBuild"))
              .build();
        }
      }
    }
    return getFindMostStableBuildMethod;
  }

  /**
   * Creates a new async stub that supports all call types for the service
   */
  public static BuildServiceStub newStub(io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<BuildServiceStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<BuildServiceStub>() {
        @java.lang.Override
        public BuildServiceStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new BuildServiceStub(channel, callOptions);
        }
      };
    return BuildServiceStub.newStub(factory, channel);
  }

  /**
   * Creates a new blocking-style stub that supports unary and streaming output calls on the service
   */
  public static BuildServiceBlockingStub newBlockingStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<BuildServiceBlockingStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<BuildServiceBlockingStub>() {
        @java.lang.Override
        public BuildServiceBlockingStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new BuildServiceBlockingStub(channel, callOptions);
        }
      };
    return BuildServiceBlockingStub.newStub(factory, channel);
  }

  /**
   * Creates a new ListenableFuture-style stub that supports unary calls on the service
   */
  public static BuildServiceFutureStub newFutureStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<BuildServiceFutureStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<BuildServiceFutureStub>() {
        @java.lang.Override
        public BuildServiceFutureStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new BuildServiceFutureStub(channel, callOptions);
        }
      };
    return BuildServiceFutureStub.newStub(factory, channel);
  }

  /**
   * <pre>
   * Manages Chrome OS build services.
   * </pre>
   */
  public static abstract class BuildServiceImplBase implements io.grpc.BindableService {

    /**
     * <pre>
     * Lists all build targets that a user has access to.
     * </pre>
     */
    public void listBuildTargets(com.google.chromeos.moblab.v1beta1.ListBuildTargetsRequest request,
        io.grpc.stub.StreamObserver<com.google.chromeos.moblab.v1beta1.ListBuildTargetsResponse> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getListBuildTargetsMethod(), responseObserver);
    }

    /**
     * <pre>
     * Lists all models for the given build target.
     * </pre>
     */
    public void listModels(com.google.chromeos.moblab.v1beta1.ListModelsRequest request,
        io.grpc.stub.StreamObserver<com.google.chromeos.moblab.v1beta1.ListModelsResponse> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getListModelsMethod(), responseObserver);
    }

    /**
     * <pre>
     * Lists all builds for the given build target and model in descending order
     * for the milestones and build versions.
     * </pre>
     */
    public void listBuilds(com.google.chromeos.moblab.v1beta1.ListBuildsRequest request,
        io.grpc.stub.StreamObserver<com.google.chromeos.moblab.v1beta1.ListBuildsResponse> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getListBuildsMethod(), responseObserver);
    }

    /**
     * <pre>
     * Checks the stage status for a given build artifact in a partner Google
     * Cloud Storage bucket.
     * </pre>
     */
    public void checkBuildStageStatus(com.google.chromeos.moblab.v1beta1.CheckBuildStageStatusRequest request,
        io.grpc.stub.StreamObserver<com.google.chromeos.moblab.v1beta1.CheckBuildStageStatusResponse> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getCheckBuildStageStatusMethod(), responseObserver);
    }

    /**
     * <pre>
     * Stages a given build artifact from a internal Google Cloud Storage bucket
     * to a partner Google Cloud Storage bucket. If any of objects has already
     * been copied, it will overwrite the previous objects. Operation &lt;response:
     * [StageBuildResponse][google.chromeos.moblab.v1beta1.StageBuildResponse],
     *            metadata: [StageBuildMetadata][google.chromeos.moblab.v1beta1.StageBuildMetadata]&gt;
     * </pre>
     */
    public void stageBuild(com.google.chromeos.moblab.v1beta1.StageBuildRequest request,
        io.grpc.stub.StreamObserver<com.google.longrunning.Operation> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getStageBuildMethod(), responseObserver);
    }

    /**
     * <pre>
     * Finds the most stable build for the given build target. The definition of
     * the most stable build is determined by evaluating the following rules in
     * order until one is true. If none are true, then there is no stable build
     * and it will return an empty response.
     * Evaluation rules:
     *   1. Stable channel build with label “Live”
     *   2. Beta channel build with label “Live”
     *   3. Dev channel build with label “Live”
     *   4. Most recent stable channel build with build status Pass
     *   5. Most recent beta channel build with build status Pass
     *   6. Most recent dev channel build with build status Pass
     * </pre>
     */
    public void findMostStableBuild(com.google.chromeos.moblab.v1beta1.FindMostStableBuildRequest request,
        io.grpc.stub.StreamObserver<com.google.chromeos.moblab.v1beta1.FindMostStableBuildResponse> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getFindMostStableBuildMethod(), responseObserver);
    }

    @java.lang.Override public final io.grpc.ServerServiceDefinition bindService() {
      return io.grpc.ServerServiceDefinition.builder(getServiceDescriptor())
          .addMethod(
            getListBuildTargetsMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.chromeos.moblab.v1beta1.ListBuildTargetsRequest,
                com.google.chromeos.moblab.v1beta1.ListBuildTargetsResponse>(
                  this, METHODID_LIST_BUILD_TARGETS)))
          .addMethod(
            getListModelsMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.chromeos.moblab.v1beta1.ListModelsRequest,
                com.google.chromeos.moblab.v1beta1.ListModelsResponse>(
                  this, METHODID_LIST_MODELS)))
          .addMethod(
            getListBuildsMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.chromeos.moblab.v1beta1.ListBuildsRequest,
                com.google.chromeos.moblab.v1beta1.ListBuildsResponse>(
                  this, METHODID_LIST_BUILDS)))
          .addMethod(
            getCheckBuildStageStatusMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.chromeos.moblab.v1beta1.CheckBuildStageStatusRequest,
                com.google.chromeos.moblab.v1beta1.CheckBuildStageStatusResponse>(
                  this, METHODID_CHECK_BUILD_STAGE_STATUS)))
          .addMethod(
            getStageBuildMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.chromeos.moblab.v1beta1.StageBuildRequest,
                com.google.longrunning.Operation>(
                  this, METHODID_STAGE_BUILD)))
          .addMethod(
            getFindMostStableBuildMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.chromeos.moblab.v1beta1.FindMostStableBuildRequest,
                com.google.chromeos.moblab.v1beta1.FindMostStableBuildResponse>(
                  this, METHODID_FIND_MOST_STABLE_BUILD)))
          .build();
    }
  }

  /**
   * <pre>
   * Manages Chrome OS build services.
   * </pre>
   */
  public static final class BuildServiceStub extends io.grpc.stub.AbstractAsyncStub<BuildServiceStub> {
    private BuildServiceStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected BuildServiceStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new BuildServiceStub(channel, callOptions);
    }

    /**
     * <pre>
     * Lists all build targets that a user has access to.
     * </pre>
     */
    public void listBuildTargets(com.google.chromeos.moblab.v1beta1.ListBuildTargetsRequest request,
        io.grpc.stub.StreamObserver<com.google.chromeos.moblab.v1beta1.ListBuildTargetsResponse> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getListBuildTargetsMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Lists all models for the given build target.
     * </pre>
     */
    public void listModels(com.google.chromeos.moblab.v1beta1.ListModelsRequest request,
        io.grpc.stub.StreamObserver<com.google.chromeos.moblab.v1beta1.ListModelsResponse> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getListModelsMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Lists all builds for the given build target and model in descending order
     * for the milestones and build versions.
     * </pre>
     */
    public void listBuilds(com.google.chromeos.moblab.v1beta1.ListBuildsRequest request,
        io.grpc.stub.StreamObserver<com.google.chromeos.moblab.v1beta1.ListBuildsResponse> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getListBuildsMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Checks the stage status for a given build artifact in a partner Google
     * Cloud Storage bucket.
     * </pre>
     */
    public void checkBuildStageStatus(com.google.chromeos.moblab.v1beta1.CheckBuildStageStatusRequest request,
        io.grpc.stub.StreamObserver<com.google.chromeos.moblab.v1beta1.CheckBuildStageStatusResponse> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getCheckBuildStageStatusMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Stages a given build artifact from a internal Google Cloud Storage bucket
     * to a partner Google Cloud Storage bucket. If any of objects has already
     * been copied, it will overwrite the previous objects. Operation &lt;response:
     * [StageBuildResponse][google.chromeos.moblab.v1beta1.StageBuildResponse],
     *            metadata: [StageBuildMetadata][google.chromeos.moblab.v1beta1.StageBuildMetadata]&gt;
     * </pre>
     */
    public void stageBuild(com.google.chromeos.moblab.v1beta1.StageBuildRequest request,
        io.grpc.stub.StreamObserver<com.google.longrunning.Operation> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getStageBuildMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Finds the most stable build for the given build target. The definition of
     * the most stable build is determined by evaluating the following rules in
     * order until one is true. If none are true, then there is no stable build
     * and it will return an empty response.
     * Evaluation rules:
     *   1. Stable channel build with label “Live”
     *   2. Beta channel build with label “Live”
     *   3. Dev channel build with label “Live”
     *   4. Most recent stable channel build with build status Pass
     *   5. Most recent beta channel build with build status Pass
     *   6. Most recent dev channel build with build status Pass
     * </pre>
     */
    public void findMostStableBuild(com.google.chromeos.moblab.v1beta1.FindMostStableBuildRequest request,
        io.grpc.stub.StreamObserver<com.google.chromeos.moblab.v1beta1.FindMostStableBuildResponse> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getFindMostStableBuildMethod(), getCallOptions()), request, responseObserver);
    }
  }

  /**
   * <pre>
   * Manages Chrome OS build services.
   * </pre>
   */
  public static final class BuildServiceBlockingStub extends io.grpc.stub.AbstractBlockingStub<BuildServiceBlockingStub> {
    private BuildServiceBlockingStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected BuildServiceBlockingStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new BuildServiceBlockingStub(channel, callOptions);
    }

    /**
     * <pre>
     * Lists all build targets that a user has access to.
     * </pre>
     */
    public com.google.chromeos.moblab.v1beta1.ListBuildTargetsResponse listBuildTargets(com.google.chromeos.moblab.v1beta1.ListBuildTargetsRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getListBuildTargetsMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Lists all models for the given build target.
     * </pre>
     */
    public com.google.chromeos.moblab.v1beta1.ListModelsResponse listModels(com.google.chromeos.moblab.v1beta1.ListModelsRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getListModelsMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Lists all builds for the given build target and model in descending order
     * for the milestones and build versions.
     * </pre>
     */
    public com.google.chromeos.moblab.v1beta1.ListBuildsResponse listBuilds(com.google.chromeos.moblab.v1beta1.ListBuildsRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getListBuildsMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Checks the stage status for a given build artifact in a partner Google
     * Cloud Storage bucket.
     * </pre>
     */
    public com.google.chromeos.moblab.v1beta1.CheckBuildStageStatusResponse checkBuildStageStatus(com.google.chromeos.moblab.v1beta1.CheckBuildStageStatusRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getCheckBuildStageStatusMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Stages a given build artifact from a internal Google Cloud Storage bucket
     * to a partner Google Cloud Storage bucket. If any of objects has already
     * been copied, it will overwrite the previous objects. Operation &lt;response:
     * [StageBuildResponse][google.chromeos.moblab.v1beta1.StageBuildResponse],
     *            metadata: [StageBuildMetadata][google.chromeos.moblab.v1beta1.StageBuildMetadata]&gt;
     * </pre>
     */
    public com.google.longrunning.Operation stageBuild(com.google.chromeos.moblab.v1beta1.StageBuildRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getStageBuildMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Finds the most stable build for the given build target. The definition of
     * the most stable build is determined by evaluating the following rules in
     * order until one is true. If none are true, then there is no stable build
     * and it will return an empty response.
     * Evaluation rules:
     *   1. Stable channel build with label “Live”
     *   2. Beta channel build with label “Live”
     *   3. Dev channel build with label “Live”
     *   4. Most recent stable channel build with build status Pass
     *   5. Most recent beta channel build with build status Pass
     *   6. Most recent dev channel build with build status Pass
     * </pre>
     */
    public com.google.chromeos.moblab.v1beta1.FindMostStableBuildResponse findMostStableBuild(com.google.chromeos.moblab.v1beta1.FindMostStableBuildRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getFindMostStableBuildMethod(), getCallOptions(), request);
    }
  }

  /**
   * <pre>
   * Manages Chrome OS build services.
   * </pre>
   */
  public static final class BuildServiceFutureStub extends io.grpc.stub.AbstractFutureStub<BuildServiceFutureStub> {
    private BuildServiceFutureStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected BuildServiceFutureStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new BuildServiceFutureStub(channel, callOptions);
    }

    /**
     * <pre>
     * Lists all build targets that a user has access to.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.chromeos.moblab.v1beta1.ListBuildTargetsResponse> listBuildTargets(
        com.google.chromeos.moblab.v1beta1.ListBuildTargetsRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getListBuildTargetsMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Lists all models for the given build target.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.chromeos.moblab.v1beta1.ListModelsResponse> listModels(
        com.google.chromeos.moblab.v1beta1.ListModelsRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getListModelsMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Lists all builds for the given build target and model in descending order
     * for the milestones and build versions.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.chromeos.moblab.v1beta1.ListBuildsResponse> listBuilds(
        com.google.chromeos.moblab.v1beta1.ListBuildsRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getListBuildsMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Checks the stage status for a given build artifact in a partner Google
     * Cloud Storage bucket.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.chromeos.moblab.v1beta1.CheckBuildStageStatusResponse> checkBuildStageStatus(
        com.google.chromeos.moblab.v1beta1.CheckBuildStageStatusRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getCheckBuildStageStatusMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Stages a given build artifact from a internal Google Cloud Storage bucket
     * to a partner Google Cloud Storage bucket. If any of objects has already
     * been copied, it will overwrite the previous objects. Operation &lt;response:
     * [StageBuildResponse][google.chromeos.moblab.v1beta1.StageBuildResponse],
     *            metadata: [StageBuildMetadata][google.chromeos.moblab.v1beta1.StageBuildMetadata]&gt;
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.longrunning.Operation> stageBuild(
        com.google.chromeos.moblab.v1beta1.StageBuildRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getStageBuildMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Finds the most stable build for the given build target. The definition of
     * the most stable build is determined by evaluating the following rules in
     * order until one is true. If none are true, then there is no stable build
     * and it will return an empty response.
     * Evaluation rules:
     *   1. Stable channel build with label “Live”
     *   2. Beta channel build with label “Live”
     *   3. Dev channel build with label “Live”
     *   4. Most recent stable channel build with build status Pass
     *   5. Most recent beta channel build with build status Pass
     *   6. Most recent dev channel build with build status Pass
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.chromeos.moblab.v1beta1.FindMostStableBuildResponse> findMostStableBuild(
        com.google.chromeos.moblab.v1beta1.FindMostStableBuildRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getFindMostStableBuildMethod(), getCallOptions()), request);
    }
  }

  private static final int METHODID_LIST_BUILD_TARGETS = 0;
  private static final int METHODID_LIST_MODELS = 1;
  private static final int METHODID_LIST_BUILDS = 2;
  private static final int METHODID_CHECK_BUILD_STAGE_STATUS = 3;
  private static final int METHODID_STAGE_BUILD = 4;
  private static final int METHODID_FIND_MOST_STABLE_BUILD = 5;

  private static final class MethodHandlers<Req, Resp> implements
      io.grpc.stub.ServerCalls.UnaryMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ServerStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ClientStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.BidiStreamingMethod<Req, Resp> {
    private final BuildServiceImplBase serviceImpl;
    private final int methodId;

    MethodHandlers(BuildServiceImplBase serviceImpl, int methodId) {
      this.serviceImpl = serviceImpl;
      this.methodId = methodId;
    }

    @java.lang.Override
    @java.lang.SuppressWarnings("unchecked")
    public void invoke(Req request, io.grpc.stub.StreamObserver<Resp> responseObserver) {
      switch (methodId) {
        case METHODID_LIST_BUILD_TARGETS:
          serviceImpl.listBuildTargets((com.google.chromeos.moblab.v1beta1.ListBuildTargetsRequest) request,
              (io.grpc.stub.StreamObserver<com.google.chromeos.moblab.v1beta1.ListBuildTargetsResponse>) responseObserver);
          break;
        case METHODID_LIST_MODELS:
          serviceImpl.listModels((com.google.chromeos.moblab.v1beta1.ListModelsRequest) request,
              (io.grpc.stub.StreamObserver<com.google.chromeos.moblab.v1beta1.ListModelsResponse>) responseObserver);
          break;
        case METHODID_LIST_BUILDS:
          serviceImpl.listBuilds((com.google.chromeos.moblab.v1beta1.ListBuildsRequest) request,
              (io.grpc.stub.StreamObserver<com.google.chromeos.moblab.v1beta1.ListBuildsResponse>) responseObserver);
          break;
        case METHODID_CHECK_BUILD_STAGE_STATUS:
          serviceImpl.checkBuildStageStatus((com.google.chromeos.moblab.v1beta1.CheckBuildStageStatusRequest) request,
              (io.grpc.stub.StreamObserver<com.google.chromeos.moblab.v1beta1.CheckBuildStageStatusResponse>) responseObserver);
          break;
        case METHODID_STAGE_BUILD:
          serviceImpl.stageBuild((com.google.chromeos.moblab.v1beta1.StageBuildRequest) request,
              (io.grpc.stub.StreamObserver<com.google.longrunning.Operation>) responseObserver);
          break;
        case METHODID_FIND_MOST_STABLE_BUILD:
          serviceImpl.findMostStableBuild((com.google.chromeos.moblab.v1beta1.FindMostStableBuildRequest) request,
              (io.grpc.stub.StreamObserver<com.google.chromeos.moblab.v1beta1.FindMostStableBuildResponse>) responseObserver);
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

  private static abstract class BuildServiceBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoFileDescriptorSupplier, io.grpc.protobuf.ProtoServiceDescriptorSupplier {
    BuildServiceBaseDescriptorSupplier() {}

    @java.lang.Override
    public com.google.protobuf.Descriptors.FileDescriptor getFileDescriptor() {
      return com.google.chromeos.moblab.v1beta1.BuildServiceProto.getDescriptor();
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.ServiceDescriptor getServiceDescriptor() {
      return getFileDescriptor().findServiceByName("BuildService");
    }
  }

  private static final class BuildServiceFileDescriptorSupplier
      extends BuildServiceBaseDescriptorSupplier {
    BuildServiceFileDescriptorSupplier() {}
  }

  private static final class BuildServiceMethodDescriptorSupplier
      extends BuildServiceBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoMethodDescriptorSupplier {
    private final String methodName;

    BuildServiceMethodDescriptorSupplier(String methodName) {
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
      synchronized (BuildServiceGrpc.class) {
        result = serviceDescriptor;
        if (result == null) {
          serviceDescriptor = result = io.grpc.ServiceDescriptor.newBuilder(SERVICE_NAME)
              .setSchemaDescriptor(new BuildServiceFileDescriptorSupplier())
              .addMethod(getListBuildTargetsMethod())
              .addMethod(getListModelsMethod())
              .addMethod(getListBuildsMethod())
              .addMethod(getCheckBuildStageStatusMethod())
              .addMethod(getStageBuildMethod())
              .addMethod(getFindMostStableBuildMethod())
              .build();
        }
      }
    }
    return result;
  }
}
