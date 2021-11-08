package com.google.cloud.bigquery.v2;

import static io.grpc.MethodDescriptor.generateFullMethodName;

/**
 */
@javax.annotation.Generated(
    value = "by gRPC proto compiler",
    comments = "Source: google/cloud/bigquery/v2/model.proto")
@io.grpc.stub.annotations.GrpcGenerated
public final class ModelServiceGrpc {

  private ModelServiceGrpc() {}

  public static final String SERVICE_NAME = "google.cloud.bigquery.v2.ModelService";

  // Static method descriptors that strictly reflect the proto.
  private static volatile io.grpc.MethodDescriptor<com.google.cloud.bigquery.v2.ModelProto.GetModelRequest,
      com.google.cloud.bigquery.v2.ModelProto.Model> getGetModelMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "GetModel",
      requestType = com.google.cloud.bigquery.v2.ModelProto.GetModelRequest.class,
      responseType = com.google.cloud.bigquery.v2.ModelProto.Model.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.cloud.bigquery.v2.ModelProto.GetModelRequest,
      com.google.cloud.bigquery.v2.ModelProto.Model> getGetModelMethod() {
    io.grpc.MethodDescriptor<com.google.cloud.bigquery.v2.ModelProto.GetModelRequest, com.google.cloud.bigquery.v2.ModelProto.Model> getGetModelMethod;
    if ((getGetModelMethod = ModelServiceGrpc.getGetModelMethod) == null) {
      synchronized (ModelServiceGrpc.class) {
        if ((getGetModelMethod = ModelServiceGrpc.getGetModelMethod) == null) {
          ModelServiceGrpc.getGetModelMethod = getGetModelMethod =
              io.grpc.MethodDescriptor.<com.google.cloud.bigquery.v2.ModelProto.GetModelRequest, com.google.cloud.bigquery.v2.ModelProto.Model>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "GetModel"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.bigquery.v2.ModelProto.GetModelRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.bigquery.v2.ModelProto.Model.getDefaultInstance()))
              .setSchemaDescriptor(new ModelServiceMethodDescriptorSupplier("GetModel"))
              .build();
        }
      }
    }
    return getGetModelMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.cloud.bigquery.v2.ModelProto.ListModelsRequest,
      com.google.cloud.bigquery.v2.ModelProto.ListModelsResponse> getListModelsMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "ListModels",
      requestType = com.google.cloud.bigquery.v2.ModelProto.ListModelsRequest.class,
      responseType = com.google.cloud.bigquery.v2.ModelProto.ListModelsResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.cloud.bigquery.v2.ModelProto.ListModelsRequest,
      com.google.cloud.bigquery.v2.ModelProto.ListModelsResponse> getListModelsMethod() {
    io.grpc.MethodDescriptor<com.google.cloud.bigquery.v2.ModelProto.ListModelsRequest, com.google.cloud.bigquery.v2.ModelProto.ListModelsResponse> getListModelsMethod;
    if ((getListModelsMethod = ModelServiceGrpc.getListModelsMethod) == null) {
      synchronized (ModelServiceGrpc.class) {
        if ((getListModelsMethod = ModelServiceGrpc.getListModelsMethod) == null) {
          ModelServiceGrpc.getListModelsMethod = getListModelsMethod =
              io.grpc.MethodDescriptor.<com.google.cloud.bigquery.v2.ModelProto.ListModelsRequest, com.google.cloud.bigquery.v2.ModelProto.ListModelsResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "ListModels"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.bigquery.v2.ModelProto.ListModelsRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.bigquery.v2.ModelProto.ListModelsResponse.getDefaultInstance()))
              .setSchemaDescriptor(new ModelServiceMethodDescriptorSupplier("ListModels"))
              .build();
        }
      }
    }
    return getListModelsMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.cloud.bigquery.v2.ModelProto.PatchModelRequest,
      com.google.cloud.bigquery.v2.ModelProto.Model> getPatchModelMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "PatchModel",
      requestType = com.google.cloud.bigquery.v2.ModelProto.PatchModelRequest.class,
      responseType = com.google.cloud.bigquery.v2.ModelProto.Model.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.cloud.bigquery.v2.ModelProto.PatchModelRequest,
      com.google.cloud.bigquery.v2.ModelProto.Model> getPatchModelMethod() {
    io.grpc.MethodDescriptor<com.google.cloud.bigquery.v2.ModelProto.PatchModelRequest, com.google.cloud.bigquery.v2.ModelProto.Model> getPatchModelMethod;
    if ((getPatchModelMethod = ModelServiceGrpc.getPatchModelMethod) == null) {
      synchronized (ModelServiceGrpc.class) {
        if ((getPatchModelMethod = ModelServiceGrpc.getPatchModelMethod) == null) {
          ModelServiceGrpc.getPatchModelMethod = getPatchModelMethod =
              io.grpc.MethodDescriptor.<com.google.cloud.bigquery.v2.ModelProto.PatchModelRequest, com.google.cloud.bigquery.v2.ModelProto.Model>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "PatchModel"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.bigquery.v2.ModelProto.PatchModelRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.bigquery.v2.ModelProto.Model.getDefaultInstance()))
              .setSchemaDescriptor(new ModelServiceMethodDescriptorSupplier("PatchModel"))
              .build();
        }
      }
    }
    return getPatchModelMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.cloud.bigquery.v2.ModelProto.DeleteModelRequest,
      com.google.protobuf.Empty> getDeleteModelMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "DeleteModel",
      requestType = com.google.cloud.bigquery.v2.ModelProto.DeleteModelRequest.class,
      responseType = com.google.protobuf.Empty.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.cloud.bigquery.v2.ModelProto.DeleteModelRequest,
      com.google.protobuf.Empty> getDeleteModelMethod() {
    io.grpc.MethodDescriptor<com.google.cloud.bigquery.v2.ModelProto.DeleteModelRequest, com.google.protobuf.Empty> getDeleteModelMethod;
    if ((getDeleteModelMethod = ModelServiceGrpc.getDeleteModelMethod) == null) {
      synchronized (ModelServiceGrpc.class) {
        if ((getDeleteModelMethod = ModelServiceGrpc.getDeleteModelMethod) == null) {
          ModelServiceGrpc.getDeleteModelMethod = getDeleteModelMethod =
              io.grpc.MethodDescriptor.<com.google.cloud.bigquery.v2.ModelProto.DeleteModelRequest, com.google.protobuf.Empty>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "DeleteModel"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.bigquery.v2.ModelProto.DeleteModelRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.protobuf.Empty.getDefaultInstance()))
              .setSchemaDescriptor(new ModelServiceMethodDescriptorSupplier("DeleteModel"))
              .build();
        }
      }
    }
    return getDeleteModelMethod;
  }

  /**
   * Creates a new async stub that supports all call types for the service
   */
  public static ModelServiceStub newStub(io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<ModelServiceStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<ModelServiceStub>() {
        @java.lang.Override
        public ModelServiceStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new ModelServiceStub(channel, callOptions);
        }
      };
    return ModelServiceStub.newStub(factory, channel);
  }

  /**
   * Creates a new blocking-style stub that supports unary and streaming output calls on the service
   */
  public static ModelServiceBlockingStub newBlockingStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<ModelServiceBlockingStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<ModelServiceBlockingStub>() {
        @java.lang.Override
        public ModelServiceBlockingStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new ModelServiceBlockingStub(channel, callOptions);
        }
      };
    return ModelServiceBlockingStub.newStub(factory, channel);
  }

  /**
   * Creates a new ListenableFuture-style stub that supports unary calls on the service
   */
  public static ModelServiceFutureStub newFutureStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<ModelServiceFutureStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<ModelServiceFutureStub>() {
        @java.lang.Override
        public ModelServiceFutureStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new ModelServiceFutureStub(channel, callOptions);
        }
      };
    return ModelServiceFutureStub.newStub(factory, channel);
  }

  /**
   */
  public static abstract class ModelServiceImplBase implements io.grpc.BindableService {

    /**
     * <pre>
     * Gets the specified model resource by model ID.
     * </pre>
     */
    public void getModel(com.google.cloud.bigquery.v2.ModelProto.GetModelRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.bigquery.v2.ModelProto.Model> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getGetModelMethod(), responseObserver);
    }

    /**
     * <pre>
     * Lists all models in the specified dataset. Requires the READER dataset
     * role. After retrieving the list of models, you can get information about a
     * particular model by calling the models.get method.
     * </pre>
     */
    public void listModels(com.google.cloud.bigquery.v2.ModelProto.ListModelsRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.bigquery.v2.ModelProto.ListModelsResponse> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getListModelsMethod(), responseObserver);
    }

    /**
     * <pre>
     * Patch specific fields in the specified model.
     * </pre>
     */
    public void patchModel(com.google.cloud.bigquery.v2.ModelProto.PatchModelRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.bigquery.v2.ModelProto.Model> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getPatchModelMethod(), responseObserver);
    }

    /**
     * <pre>
     * Deletes the model specified by modelId from the dataset.
     * </pre>
     */
    public void deleteModel(com.google.cloud.bigquery.v2.ModelProto.DeleteModelRequest request,
        io.grpc.stub.StreamObserver<com.google.protobuf.Empty> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getDeleteModelMethod(), responseObserver);
    }

    @java.lang.Override public final io.grpc.ServerServiceDefinition bindService() {
      return io.grpc.ServerServiceDefinition.builder(getServiceDescriptor())
          .addMethod(
            getGetModelMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.cloud.bigquery.v2.ModelProto.GetModelRequest,
                com.google.cloud.bigquery.v2.ModelProto.Model>(
                  this, METHODID_GET_MODEL)))
          .addMethod(
            getListModelsMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.cloud.bigquery.v2.ModelProto.ListModelsRequest,
                com.google.cloud.bigquery.v2.ModelProto.ListModelsResponse>(
                  this, METHODID_LIST_MODELS)))
          .addMethod(
            getPatchModelMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.cloud.bigquery.v2.ModelProto.PatchModelRequest,
                com.google.cloud.bigquery.v2.ModelProto.Model>(
                  this, METHODID_PATCH_MODEL)))
          .addMethod(
            getDeleteModelMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.cloud.bigquery.v2.ModelProto.DeleteModelRequest,
                com.google.protobuf.Empty>(
                  this, METHODID_DELETE_MODEL)))
          .build();
    }
  }

  /**
   */
  public static final class ModelServiceStub extends io.grpc.stub.AbstractAsyncStub<ModelServiceStub> {
    private ModelServiceStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected ModelServiceStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new ModelServiceStub(channel, callOptions);
    }

    /**
     * <pre>
     * Gets the specified model resource by model ID.
     * </pre>
     */
    public void getModel(com.google.cloud.bigquery.v2.ModelProto.GetModelRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.bigquery.v2.ModelProto.Model> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getGetModelMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Lists all models in the specified dataset. Requires the READER dataset
     * role. After retrieving the list of models, you can get information about a
     * particular model by calling the models.get method.
     * </pre>
     */
    public void listModels(com.google.cloud.bigquery.v2.ModelProto.ListModelsRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.bigquery.v2.ModelProto.ListModelsResponse> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getListModelsMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Patch specific fields in the specified model.
     * </pre>
     */
    public void patchModel(com.google.cloud.bigquery.v2.ModelProto.PatchModelRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.bigquery.v2.ModelProto.Model> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getPatchModelMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Deletes the model specified by modelId from the dataset.
     * </pre>
     */
    public void deleteModel(com.google.cloud.bigquery.v2.ModelProto.DeleteModelRequest request,
        io.grpc.stub.StreamObserver<com.google.protobuf.Empty> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getDeleteModelMethod(), getCallOptions()), request, responseObserver);
    }
  }

  /**
   */
  public static final class ModelServiceBlockingStub extends io.grpc.stub.AbstractBlockingStub<ModelServiceBlockingStub> {
    private ModelServiceBlockingStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected ModelServiceBlockingStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new ModelServiceBlockingStub(channel, callOptions);
    }

    /**
     * <pre>
     * Gets the specified model resource by model ID.
     * </pre>
     */
    public com.google.cloud.bigquery.v2.ModelProto.Model getModel(com.google.cloud.bigquery.v2.ModelProto.GetModelRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getGetModelMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Lists all models in the specified dataset. Requires the READER dataset
     * role. After retrieving the list of models, you can get information about a
     * particular model by calling the models.get method.
     * </pre>
     */
    public com.google.cloud.bigquery.v2.ModelProto.ListModelsResponse listModels(com.google.cloud.bigquery.v2.ModelProto.ListModelsRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getListModelsMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Patch specific fields in the specified model.
     * </pre>
     */
    public com.google.cloud.bigquery.v2.ModelProto.Model patchModel(com.google.cloud.bigquery.v2.ModelProto.PatchModelRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getPatchModelMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Deletes the model specified by modelId from the dataset.
     * </pre>
     */
    public com.google.protobuf.Empty deleteModel(com.google.cloud.bigquery.v2.ModelProto.DeleteModelRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getDeleteModelMethod(), getCallOptions(), request);
    }
  }

  /**
   */
  public static final class ModelServiceFutureStub extends io.grpc.stub.AbstractFutureStub<ModelServiceFutureStub> {
    private ModelServiceFutureStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected ModelServiceFutureStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new ModelServiceFutureStub(channel, callOptions);
    }

    /**
     * <pre>
     * Gets the specified model resource by model ID.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.cloud.bigquery.v2.ModelProto.Model> getModel(
        com.google.cloud.bigquery.v2.ModelProto.GetModelRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getGetModelMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Lists all models in the specified dataset. Requires the READER dataset
     * role. After retrieving the list of models, you can get information about a
     * particular model by calling the models.get method.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.cloud.bigquery.v2.ModelProto.ListModelsResponse> listModels(
        com.google.cloud.bigquery.v2.ModelProto.ListModelsRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getListModelsMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Patch specific fields in the specified model.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.cloud.bigquery.v2.ModelProto.Model> patchModel(
        com.google.cloud.bigquery.v2.ModelProto.PatchModelRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getPatchModelMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Deletes the model specified by modelId from the dataset.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.protobuf.Empty> deleteModel(
        com.google.cloud.bigquery.v2.ModelProto.DeleteModelRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getDeleteModelMethod(), getCallOptions()), request);
    }
  }

  private static final int METHODID_GET_MODEL = 0;
  private static final int METHODID_LIST_MODELS = 1;
  private static final int METHODID_PATCH_MODEL = 2;
  private static final int METHODID_DELETE_MODEL = 3;

  private static final class MethodHandlers<Req, Resp> implements
      io.grpc.stub.ServerCalls.UnaryMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ServerStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ClientStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.BidiStreamingMethod<Req, Resp> {
    private final ModelServiceImplBase serviceImpl;
    private final int methodId;

    MethodHandlers(ModelServiceImplBase serviceImpl, int methodId) {
      this.serviceImpl = serviceImpl;
      this.methodId = methodId;
    }

    @java.lang.Override
    @java.lang.SuppressWarnings("unchecked")
    public void invoke(Req request, io.grpc.stub.StreamObserver<Resp> responseObserver) {
      switch (methodId) {
        case METHODID_GET_MODEL:
          serviceImpl.getModel((com.google.cloud.bigquery.v2.ModelProto.GetModelRequest) request,
              (io.grpc.stub.StreamObserver<com.google.cloud.bigquery.v2.ModelProto.Model>) responseObserver);
          break;
        case METHODID_LIST_MODELS:
          serviceImpl.listModels((com.google.cloud.bigquery.v2.ModelProto.ListModelsRequest) request,
              (io.grpc.stub.StreamObserver<com.google.cloud.bigquery.v2.ModelProto.ListModelsResponse>) responseObserver);
          break;
        case METHODID_PATCH_MODEL:
          serviceImpl.patchModel((com.google.cloud.bigquery.v2.ModelProto.PatchModelRequest) request,
              (io.grpc.stub.StreamObserver<com.google.cloud.bigquery.v2.ModelProto.Model>) responseObserver);
          break;
        case METHODID_DELETE_MODEL:
          serviceImpl.deleteModel((com.google.cloud.bigquery.v2.ModelProto.DeleteModelRequest) request,
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

  private static abstract class ModelServiceBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoFileDescriptorSupplier, io.grpc.protobuf.ProtoServiceDescriptorSupplier {
    ModelServiceBaseDescriptorSupplier() {}

    @java.lang.Override
    public com.google.protobuf.Descriptors.FileDescriptor getFileDescriptor() {
      return com.google.cloud.bigquery.v2.ModelProto.getDescriptor();
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.ServiceDescriptor getServiceDescriptor() {
      return getFileDescriptor().findServiceByName("ModelService");
    }
  }

  private static final class ModelServiceFileDescriptorSupplier
      extends ModelServiceBaseDescriptorSupplier {
    ModelServiceFileDescriptorSupplier() {}
  }

  private static final class ModelServiceMethodDescriptorSupplier
      extends ModelServiceBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoMethodDescriptorSupplier {
    private final String methodName;

    ModelServiceMethodDescriptorSupplier(String methodName) {
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
      synchronized (ModelServiceGrpc.class) {
        result = serviceDescriptor;
        if (result == null) {
          serviceDescriptor = result = io.grpc.ServiceDescriptor.newBuilder(SERVICE_NAME)
              .setSchemaDescriptor(new ModelServiceFileDescriptorSupplier())
              .addMethod(getGetModelMethod())
              .addMethod(getListModelsMethod())
              .addMethod(getPatchModelMethod())
              .addMethod(getDeleteModelMethod())
              .build();
        }
      }
    }
    return result;
  }
}
