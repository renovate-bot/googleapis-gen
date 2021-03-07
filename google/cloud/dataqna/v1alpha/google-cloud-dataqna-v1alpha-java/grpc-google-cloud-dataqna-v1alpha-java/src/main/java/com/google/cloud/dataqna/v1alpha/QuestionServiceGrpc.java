package com.google.cloud.dataqna.v1alpha;

import static io.grpc.MethodDescriptor.generateFullMethodName;

/**
 * <pre>
 * Service to interpret natural language queries.
 * The service allows to create `Question` resources that are interpreted and
 * are filled with one or more interpretations if the question could be
 * interpreted. Once a `Question` resource is created and has at least one
 * interpretation, an interpretation can be chosen for execution, which
 * triggers a query to the backend (for BigQuery, it will create a job).
 * Upon successful execution of that interpretation, backend specific
 * information will be returned so that the client can retrieve the results
 * from the backend.
 * The `Question` resources are named `projects/&#42;&#47;locations/&#42;&#47;questions/&#42;`.
 * The `Question` resource has a singletion sub-resource `UserFeedback` named
 * `projects/&#42;&#47;locations/&#42;&#47;questions/&#42;&#47;userFeedback`, which allows access to
 * user feedback.
 * </pre>
 */
@javax.annotation.Generated(
    value = "by gRPC proto compiler",
    comments = "Source: google/cloud/dataqna/v1alpha/question_service.proto")
public final class QuestionServiceGrpc {

  private QuestionServiceGrpc() {}

  public static final String SERVICE_NAME = "google.cloud.dataqna.v1alpha.QuestionService";

  // Static method descriptors that strictly reflect the proto.
  private static volatile io.grpc.MethodDescriptor<com.google.cloud.dataqna.v1alpha.GetQuestionRequest,
      com.google.cloud.dataqna.v1alpha.Question> getGetQuestionMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "GetQuestion",
      requestType = com.google.cloud.dataqna.v1alpha.GetQuestionRequest.class,
      responseType = com.google.cloud.dataqna.v1alpha.Question.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.cloud.dataqna.v1alpha.GetQuestionRequest,
      com.google.cloud.dataqna.v1alpha.Question> getGetQuestionMethod() {
    io.grpc.MethodDescriptor<com.google.cloud.dataqna.v1alpha.GetQuestionRequest, com.google.cloud.dataqna.v1alpha.Question> getGetQuestionMethod;
    if ((getGetQuestionMethod = QuestionServiceGrpc.getGetQuestionMethod) == null) {
      synchronized (QuestionServiceGrpc.class) {
        if ((getGetQuestionMethod = QuestionServiceGrpc.getGetQuestionMethod) == null) {
          QuestionServiceGrpc.getGetQuestionMethod = getGetQuestionMethod =
              io.grpc.MethodDescriptor.<com.google.cloud.dataqna.v1alpha.GetQuestionRequest, com.google.cloud.dataqna.v1alpha.Question>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "GetQuestion"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.dataqna.v1alpha.GetQuestionRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.dataqna.v1alpha.Question.getDefaultInstance()))
              .setSchemaDescriptor(new QuestionServiceMethodDescriptorSupplier("GetQuestion"))
              .build();
        }
      }
    }
    return getGetQuestionMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.cloud.dataqna.v1alpha.CreateQuestionRequest,
      com.google.cloud.dataqna.v1alpha.Question> getCreateQuestionMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "CreateQuestion",
      requestType = com.google.cloud.dataqna.v1alpha.CreateQuestionRequest.class,
      responseType = com.google.cloud.dataqna.v1alpha.Question.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.cloud.dataqna.v1alpha.CreateQuestionRequest,
      com.google.cloud.dataqna.v1alpha.Question> getCreateQuestionMethod() {
    io.grpc.MethodDescriptor<com.google.cloud.dataqna.v1alpha.CreateQuestionRequest, com.google.cloud.dataqna.v1alpha.Question> getCreateQuestionMethod;
    if ((getCreateQuestionMethod = QuestionServiceGrpc.getCreateQuestionMethod) == null) {
      synchronized (QuestionServiceGrpc.class) {
        if ((getCreateQuestionMethod = QuestionServiceGrpc.getCreateQuestionMethod) == null) {
          QuestionServiceGrpc.getCreateQuestionMethod = getCreateQuestionMethod =
              io.grpc.MethodDescriptor.<com.google.cloud.dataqna.v1alpha.CreateQuestionRequest, com.google.cloud.dataqna.v1alpha.Question>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "CreateQuestion"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.dataqna.v1alpha.CreateQuestionRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.dataqna.v1alpha.Question.getDefaultInstance()))
              .setSchemaDescriptor(new QuestionServiceMethodDescriptorSupplier("CreateQuestion"))
              .build();
        }
      }
    }
    return getCreateQuestionMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.cloud.dataqna.v1alpha.ExecuteQuestionRequest,
      com.google.cloud.dataqna.v1alpha.Question> getExecuteQuestionMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "ExecuteQuestion",
      requestType = com.google.cloud.dataqna.v1alpha.ExecuteQuestionRequest.class,
      responseType = com.google.cloud.dataqna.v1alpha.Question.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.cloud.dataqna.v1alpha.ExecuteQuestionRequest,
      com.google.cloud.dataqna.v1alpha.Question> getExecuteQuestionMethod() {
    io.grpc.MethodDescriptor<com.google.cloud.dataqna.v1alpha.ExecuteQuestionRequest, com.google.cloud.dataqna.v1alpha.Question> getExecuteQuestionMethod;
    if ((getExecuteQuestionMethod = QuestionServiceGrpc.getExecuteQuestionMethod) == null) {
      synchronized (QuestionServiceGrpc.class) {
        if ((getExecuteQuestionMethod = QuestionServiceGrpc.getExecuteQuestionMethod) == null) {
          QuestionServiceGrpc.getExecuteQuestionMethod = getExecuteQuestionMethod =
              io.grpc.MethodDescriptor.<com.google.cloud.dataqna.v1alpha.ExecuteQuestionRequest, com.google.cloud.dataqna.v1alpha.Question>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "ExecuteQuestion"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.dataqna.v1alpha.ExecuteQuestionRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.dataqna.v1alpha.Question.getDefaultInstance()))
              .setSchemaDescriptor(new QuestionServiceMethodDescriptorSupplier("ExecuteQuestion"))
              .build();
        }
      }
    }
    return getExecuteQuestionMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.cloud.dataqna.v1alpha.GetUserFeedbackRequest,
      com.google.cloud.dataqna.v1alpha.UserFeedback> getGetUserFeedbackMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "GetUserFeedback",
      requestType = com.google.cloud.dataqna.v1alpha.GetUserFeedbackRequest.class,
      responseType = com.google.cloud.dataqna.v1alpha.UserFeedback.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.cloud.dataqna.v1alpha.GetUserFeedbackRequest,
      com.google.cloud.dataqna.v1alpha.UserFeedback> getGetUserFeedbackMethod() {
    io.grpc.MethodDescriptor<com.google.cloud.dataqna.v1alpha.GetUserFeedbackRequest, com.google.cloud.dataqna.v1alpha.UserFeedback> getGetUserFeedbackMethod;
    if ((getGetUserFeedbackMethod = QuestionServiceGrpc.getGetUserFeedbackMethod) == null) {
      synchronized (QuestionServiceGrpc.class) {
        if ((getGetUserFeedbackMethod = QuestionServiceGrpc.getGetUserFeedbackMethod) == null) {
          QuestionServiceGrpc.getGetUserFeedbackMethod = getGetUserFeedbackMethod =
              io.grpc.MethodDescriptor.<com.google.cloud.dataqna.v1alpha.GetUserFeedbackRequest, com.google.cloud.dataqna.v1alpha.UserFeedback>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "GetUserFeedback"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.dataqna.v1alpha.GetUserFeedbackRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.dataqna.v1alpha.UserFeedback.getDefaultInstance()))
              .setSchemaDescriptor(new QuestionServiceMethodDescriptorSupplier("GetUserFeedback"))
              .build();
        }
      }
    }
    return getGetUserFeedbackMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.cloud.dataqna.v1alpha.UpdateUserFeedbackRequest,
      com.google.cloud.dataqna.v1alpha.UserFeedback> getUpdateUserFeedbackMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "UpdateUserFeedback",
      requestType = com.google.cloud.dataqna.v1alpha.UpdateUserFeedbackRequest.class,
      responseType = com.google.cloud.dataqna.v1alpha.UserFeedback.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.cloud.dataqna.v1alpha.UpdateUserFeedbackRequest,
      com.google.cloud.dataqna.v1alpha.UserFeedback> getUpdateUserFeedbackMethod() {
    io.grpc.MethodDescriptor<com.google.cloud.dataqna.v1alpha.UpdateUserFeedbackRequest, com.google.cloud.dataqna.v1alpha.UserFeedback> getUpdateUserFeedbackMethod;
    if ((getUpdateUserFeedbackMethod = QuestionServiceGrpc.getUpdateUserFeedbackMethod) == null) {
      synchronized (QuestionServiceGrpc.class) {
        if ((getUpdateUserFeedbackMethod = QuestionServiceGrpc.getUpdateUserFeedbackMethod) == null) {
          QuestionServiceGrpc.getUpdateUserFeedbackMethod = getUpdateUserFeedbackMethod =
              io.grpc.MethodDescriptor.<com.google.cloud.dataqna.v1alpha.UpdateUserFeedbackRequest, com.google.cloud.dataqna.v1alpha.UserFeedback>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "UpdateUserFeedback"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.dataqna.v1alpha.UpdateUserFeedbackRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.dataqna.v1alpha.UserFeedback.getDefaultInstance()))
              .setSchemaDescriptor(new QuestionServiceMethodDescriptorSupplier("UpdateUserFeedback"))
              .build();
        }
      }
    }
    return getUpdateUserFeedbackMethod;
  }

  /**
   * Creates a new async stub that supports all call types for the service
   */
  public static QuestionServiceStub newStub(io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<QuestionServiceStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<QuestionServiceStub>() {
        @java.lang.Override
        public QuestionServiceStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new QuestionServiceStub(channel, callOptions);
        }
      };
    return QuestionServiceStub.newStub(factory, channel);
  }

  /**
   * Creates a new blocking-style stub that supports unary and streaming output calls on the service
   */
  public static QuestionServiceBlockingStub newBlockingStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<QuestionServiceBlockingStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<QuestionServiceBlockingStub>() {
        @java.lang.Override
        public QuestionServiceBlockingStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new QuestionServiceBlockingStub(channel, callOptions);
        }
      };
    return QuestionServiceBlockingStub.newStub(factory, channel);
  }

  /**
   * Creates a new ListenableFuture-style stub that supports unary calls on the service
   */
  public static QuestionServiceFutureStub newFutureStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<QuestionServiceFutureStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<QuestionServiceFutureStub>() {
        @java.lang.Override
        public QuestionServiceFutureStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new QuestionServiceFutureStub(channel, callOptions);
        }
      };
    return QuestionServiceFutureStub.newStub(factory, channel);
  }

  /**
   * <pre>
   * Service to interpret natural language queries.
   * The service allows to create `Question` resources that are interpreted and
   * are filled with one or more interpretations if the question could be
   * interpreted. Once a `Question` resource is created and has at least one
   * interpretation, an interpretation can be chosen for execution, which
   * triggers a query to the backend (for BigQuery, it will create a job).
   * Upon successful execution of that interpretation, backend specific
   * information will be returned so that the client can retrieve the results
   * from the backend.
   * The `Question` resources are named `projects/&#42;&#47;locations/&#42;&#47;questions/&#42;`.
   * The `Question` resource has a singletion sub-resource `UserFeedback` named
   * `projects/&#42;&#47;locations/&#42;&#47;questions/&#42;&#47;userFeedback`, which allows access to
   * user feedback.
   * </pre>
   */
  public static abstract class QuestionServiceImplBase implements io.grpc.BindableService {

    /**
     * <pre>
     * Gets a previously created question.
     * </pre>
     */
    public void getQuestion(com.google.cloud.dataqna.v1alpha.GetQuestionRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.dataqna.v1alpha.Question> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getGetQuestionMethod(), responseObserver);
    }

    /**
     * <pre>
     * Creates a question.
     * </pre>
     */
    public void createQuestion(com.google.cloud.dataqna.v1alpha.CreateQuestionRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.dataqna.v1alpha.Question> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getCreateQuestionMethod(), responseObserver);
    }

    /**
     * <pre>
     * Executes an interpretation.
     * </pre>
     */
    public void executeQuestion(com.google.cloud.dataqna.v1alpha.ExecuteQuestionRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.dataqna.v1alpha.Question> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getExecuteQuestionMethod(), responseObserver);
    }

    /**
     * <pre>
     * Gets previously created user feedback.
     * </pre>
     */
    public void getUserFeedback(com.google.cloud.dataqna.v1alpha.GetUserFeedbackRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.dataqna.v1alpha.UserFeedback> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getGetUserFeedbackMethod(), responseObserver);
    }

    /**
     * <pre>
     * Updates user feedback. This creates user feedback if there was none before
     * (upsert).
     * </pre>
     */
    public void updateUserFeedback(com.google.cloud.dataqna.v1alpha.UpdateUserFeedbackRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.dataqna.v1alpha.UserFeedback> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getUpdateUserFeedbackMethod(), responseObserver);
    }

    @java.lang.Override public final io.grpc.ServerServiceDefinition bindService() {
      return io.grpc.ServerServiceDefinition.builder(getServiceDescriptor())
          .addMethod(
            getGetQuestionMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.cloud.dataqna.v1alpha.GetQuestionRequest,
                com.google.cloud.dataqna.v1alpha.Question>(
                  this, METHODID_GET_QUESTION)))
          .addMethod(
            getCreateQuestionMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.cloud.dataqna.v1alpha.CreateQuestionRequest,
                com.google.cloud.dataqna.v1alpha.Question>(
                  this, METHODID_CREATE_QUESTION)))
          .addMethod(
            getExecuteQuestionMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.cloud.dataqna.v1alpha.ExecuteQuestionRequest,
                com.google.cloud.dataqna.v1alpha.Question>(
                  this, METHODID_EXECUTE_QUESTION)))
          .addMethod(
            getGetUserFeedbackMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.cloud.dataqna.v1alpha.GetUserFeedbackRequest,
                com.google.cloud.dataqna.v1alpha.UserFeedback>(
                  this, METHODID_GET_USER_FEEDBACK)))
          .addMethod(
            getUpdateUserFeedbackMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.cloud.dataqna.v1alpha.UpdateUserFeedbackRequest,
                com.google.cloud.dataqna.v1alpha.UserFeedback>(
                  this, METHODID_UPDATE_USER_FEEDBACK)))
          .build();
    }
  }

  /**
   * <pre>
   * Service to interpret natural language queries.
   * The service allows to create `Question` resources that are interpreted and
   * are filled with one or more interpretations if the question could be
   * interpreted. Once a `Question` resource is created and has at least one
   * interpretation, an interpretation can be chosen for execution, which
   * triggers a query to the backend (for BigQuery, it will create a job).
   * Upon successful execution of that interpretation, backend specific
   * information will be returned so that the client can retrieve the results
   * from the backend.
   * The `Question` resources are named `projects/&#42;&#47;locations/&#42;&#47;questions/&#42;`.
   * The `Question` resource has a singletion sub-resource `UserFeedback` named
   * `projects/&#42;&#47;locations/&#42;&#47;questions/&#42;&#47;userFeedback`, which allows access to
   * user feedback.
   * </pre>
   */
  public static final class QuestionServiceStub extends io.grpc.stub.AbstractAsyncStub<QuestionServiceStub> {
    private QuestionServiceStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected QuestionServiceStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new QuestionServiceStub(channel, callOptions);
    }

    /**
     * <pre>
     * Gets a previously created question.
     * </pre>
     */
    public void getQuestion(com.google.cloud.dataqna.v1alpha.GetQuestionRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.dataqna.v1alpha.Question> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getGetQuestionMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Creates a question.
     * </pre>
     */
    public void createQuestion(com.google.cloud.dataqna.v1alpha.CreateQuestionRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.dataqna.v1alpha.Question> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getCreateQuestionMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Executes an interpretation.
     * </pre>
     */
    public void executeQuestion(com.google.cloud.dataqna.v1alpha.ExecuteQuestionRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.dataqna.v1alpha.Question> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getExecuteQuestionMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Gets previously created user feedback.
     * </pre>
     */
    public void getUserFeedback(com.google.cloud.dataqna.v1alpha.GetUserFeedbackRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.dataqna.v1alpha.UserFeedback> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getGetUserFeedbackMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Updates user feedback. This creates user feedback if there was none before
     * (upsert).
     * </pre>
     */
    public void updateUserFeedback(com.google.cloud.dataqna.v1alpha.UpdateUserFeedbackRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.dataqna.v1alpha.UserFeedback> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getUpdateUserFeedbackMethod(), getCallOptions()), request, responseObserver);
    }
  }

  /**
   * <pre>
   * Service to interpret natural language queries.
   * The service allows to create `Question` resources that are interpreted and
   * are filled with one or more interpretations if the question could be
   * interpreted. Once a `Question` resource is created and has at least one
   * interpretation, an interpretation can be chosen for execution, which
   * triggers a query to the backend (for BigQuery, it will create a job).
   * Upon successful execution of that interpretation, backend specific
   * information will be returned so that the client can retrieve the results
   * from the backend.
   * The `Question` resources are named `projects/&#42;&#47;locations/&#42;&#47;questions/&#42;`.
   * The `Question` resource has a singletion sub-resource `UserFeedback` named
   * `projects/&#42;&#47;locations/&#42;&#47;questions/&#42;&#47;userFeedback`, which allows access to
   * user feedback.
   * </pre>
   */
  public static final class QuestionServiceBlockingStub extends io.grpc.stub.AbstractBlockingStub<QuestionServiceBlockingStub> {
    private QuestionServiceBlockingStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected QuestionServiceBlockingStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new QuestionServiceBlockingStub(channel, callOptions);
    }

    /**
     * <pre>
     * Gets a previously created question.
     * </pre>
     */
    public com.google.cloud.dataqna.v1alpha.Question getQuestion(com.google.cloud.dataqna.v1alpha.GetQuestionRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getGetQuestionMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Creates a question.
     * </pre>
     */
    public com.google.cloud.dataqna.v1alpha.Question createQuestion(com.google.cloud.dataqna.v1alpha.CreateQuestionRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getCreateQuestionMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Executes an interpretation.
     * </pre>
     */
    public com.google.cloud.dataqna.v1alpha.Question executeQuestion(com.google.cloud.dataqna.v1alpha.ExecuteQuestionRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getExecuteQuestionMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Gets previously created user feedback.
     * </pre>
     */
    public com.google.cloud.dataqna.v1alpha.UserFeedback getUserFeedback(com.google.cloud.dataqna.v1alpha.GetUserFeedbackRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getGetUserFeedbackMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Updates user feedback. This creates user feedback if there was none before
     * (upsert).
     * </pre>
     */
    public com.google.cloud.dataqna.v1alpha.UserFeedback updateUserFeedback(com.google.cloud.dataqna.v1alpha.UpdateUserFeedbackRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getUpdateUserFeedbackMethod(), getCallOptions(), request);
    }
  }

  /**
   * <pre>
   * Service to interpret natural language queries.
   * The service allows to create `Question` resources that are interpreted and
   * are filled with one or more interpretations if the question could be
   * interpreted. Once a `Question` resource is created and has at least one
   * interpretation, an interpretation can be chosen for execution, which
   * triggers a query to the backend (for BigQuery, it will create a job).
   * Upon successful execution of that interpretation, backend specific
   * information will be returned so that the client can retrieve the results
   * from the backend.
   * The `Question` resources are named `projects/&#42;&#47;locations/&#42;&#47;questions/&#42;`.
   * The `Question` resource has a singletion sub-resource `UserFeedback` named
   * `projects/&#42;&#47;locations/&#42;&#47;questions/&#42;&#47;userFeedback`, which allows access to
   * user feedback.
   * </pre>
   */
  public static final class QuestionServiceFutureStub extends io.grpc.stub.AbstractFutureStub<QuestionServiceFutureStub> {
    private QuestionServiceFutureStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected QuestionServiceFutureStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new QuestionServiceFutureStub(channel, callOptions);
    }

    /**
     * <pre>
     * Gets a previously created question.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.cloud.dataqna.v1alpha.Question> getQuestion(
        com.google.cloud.dataqna.v1alpha.GetQuestionRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getGetQuestionMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Creates a question.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.cloud.dataqna.v1alpha.Question> createQuestion(
        com.google.cloud.dataqna.v1alpha.CreateQuestionRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getCreateQuestionMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Executes an interpretation.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.cloud.dataqna.v1alpha.Question> executeQuestion(
        com.google.cloud.dataqna.v1alpha.ExecuteQuestionRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getExecuteQuestionMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Gets previously created user feedback.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.cloud.dataqna.v1alpha.UserFeedback> getUserFeedback(
        com.google.cloud.dataqna.v1alpha.GetUserFeedbackRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getGetUserFeedbackMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Updates user feedback. This creates user feedback if there was none before
     * (upsert).
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.cloud.dataqna.v1alpha.UserFeedback> updateUserFeedback(
        com.google.cloud.dataqna.v1alpha.UpdateUserFeedbackRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getUpdateUserFeedbackMethod(), getCallOptions()), request);
    }
  }

  private static final int METHODID_GET_QUESTION = 0;
  private static final int METHODID_CREATE_QUESTION = 1;
  private static final int METHODID_EXECUTE_QUESTION = 2;
  private static final int METHODID_GET_USER_FEEDBACK = 3;
  private static final int METHODID_UPDATE_USER_FEEDBACK = 4;

  private static final class MethodHandlers<Req, Resp> implements
      io.grpc.stub.ServerCalls.UnaryMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ServerStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ClientStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.BidiStreamingMethod<Req, Resp> {
    private final QuestionServiceImplBase serviceImpl;
    private final int methodId;

    MethodHandlers(QuestionServiceImplBase serviceImpl, int methodId) {
      this.serviceImpl = serviceImpl;
      this.methodId = methodId;
    }

    @java.lang.Override
    @java.lang.SuppressWarnings("unchecked")
    public void invoke(Req request, io.grpc.stub.StreamObserver<Resp> responseObserver) {
      switch (methodId) {
        case METHODID_GET_QUESTION:
          serviceImpl.getQuestion((com.google.cloud.dataqna.v1alpha.GetQuestionRequest) request,
              (io.grpc.stub.StreamObserver<com.google.cloud.dataqna.v1alpha.Question>) responseObserver);
          break;
        case METHODID_CREATE_QUESTION:
          serviceImpl.createQuestion((com.google.cloud.dataqna.v1alpha.CreateQuestionRequest) request,
              (io.grpc.stub.StreamObserver<com.google.cloud.dataqna.v1alpha.Question>) responseObserver);
          break;
        case METHODID_EXECUTE_QUESTION:
          serviceImpl.executeQuestion((com.google.cloud.dataqna.v1alpha.ExecuteQuestionRequest) request,
              (io.grpc.stub.StreamObserver<com.google.cloud.dataqna.v1alpha.Question>) responseObserver);
          break;
        case METHODID_GET_USER_FEEDBACK:
          serviceImpl.getUserFeedback((com.google.cloud.dataqna.v1alpha.GetUserFeedbackRequest) request,
              (io.grpc.stub.StreamObserver<com.google.cloud.dataqna.v1alpha.UserFeedback>) responseObserver);
          break;
        case METHODID_UPDATE_USER_FEEDBACK:
          serviceImpl.updateUserFeedback((com.google.cloud.dataqna.v1alpha.UpdateUserFeedbackRequest) request,
              (io.grpc.stub.StreamObserver<com.google.cloud.dataqna.v1alpha.UserFeedback>) responseObserver);
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

  private static abstract class QuestionServiceBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoFileDescriptorSupplier, io.grpc.protobuf.ProtoServiceDescriptorSupplier {
    QuestionServiceBaseDescriptorSupplier() {}

    @java.lang.Override
    public com.google.protobuf.Descriptors.FileDescriptor getFileDescriptor() {
      return com.google.cloud.dataqna.v1alpha.QuestionServiceProto.getDescriptor();
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.ServiceDescriptor getServiceDescriptor() {
      return getFileDescriptor().findServiceByName("QuestionService");
    }
  }

  private static final class QuestionServiceFileDescriptorSupplier
      extends QuestionServiceBaseDescriptorSupplier {
    QuestionServiceFileDescriptorSupplier() {}
  }

  private static final class QuestionServiceMethodDescriptorSupplier
      extends QuestionServiceBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoMethodDescriptorSupplier {
    private final String methodName;

    QuestionServiceMethodDescriptorSupplier(String methodName) {
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
      synchronized (QuestionServiceGrpc.class) {
        result = serviceDescriptor;
        if (result == null) {
          serviceDescriptor = result = io.grpc.ServiceDescriptor.newBuilder(SERVICE_NAME)
              .setSchemaDescriptor(new QuestionServiceFileDescriptorSupplier())
              .addMethod(getGetQuestionMethod())
              .addMethod(getCreateQuestionMethod())
              .addMethod(getExecuteQuestionMethod())
              .addMethod(getGetUserFeedbackMethod())
              .addMethod(getUpdateUserFeedbackMethod())
              .build();
        }
      }
    }
    return result;
  }
}
