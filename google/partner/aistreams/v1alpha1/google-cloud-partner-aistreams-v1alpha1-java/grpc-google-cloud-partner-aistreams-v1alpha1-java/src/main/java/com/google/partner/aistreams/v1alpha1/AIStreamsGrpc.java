package com.google.partner.aistreams.v1alpha1;

import static io.grpc.MethodDescriptor.generateFullMethodName;

/**
 * <pre>
 * AIStreams service.
 * </pre>
 */
@javax.annotation.Generated(
    value = "by gRPC proto compiler",
    comments = "Source: google/partner/aistreams/v1alpha1/aistreams.proto")
@io.grpc.stub.annotations.GrpcGenerated
public final class AIStreamsGrpc {

  private AIStreamsGrpc() {}

  public static final String SERVICE_NAME = "google.partner.aistreams.v1alpha1.AIStreams";

  // Static method descriptors that strictly reflect the proto.
  private static volatile io.grpc.MethodDescriptor<com.google.partner.aistreams.v1alpha1.ListClustersRequest,
      com.google.partner.aistreams.v1alpha1.ListClustersResponse> getListClustersMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "ListClusters",
      requestType = com.google.partner.aistreams.v1alpha1.ListClustersRequest.class,
      responseType = com.google.partner.aistreams.v1alpha1.ListClustersResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.partner.aistreams.v1alpha1.ListClustersRequest,
      com.google.partner.aistreams.v1alpha1.ListClustersResponse> getListClustersMethod() {
    io.grpc.MethodDescriptor<com.google.partner.aistreams.v1alpha1.ListClustersRequest, com.google.partner.aistreams.v1alpha1.ListClustersResponse> getListClustersMethod;
    if ((getListClustersMethod = AIStreamsGrpc.getListClustersMethod) == null) {
      synchronized (AIStreamsGrpc.class) {
        if ((getListClustersMethod = AIStreamsGrpc.getListClustersMethod) == null) {
          AIStreamsGrpc.getListClustersMethod = getListClustersMethod =
              io.grpc.MethodDescriptor.<com.google.partner.aistreams.v1alpha1.ListClustersRequest, com.google.partner.aistreams.v1alpha1.ListClustersResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "ListClusters"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.partner.aistreams.v1alpha1.ListClustersRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.partner.aistreams.v1alpha1.ListClustersResponse.getDefaultInstance()))
              .setSchemaDescriptor(new AIStreamsMethodDescriptorSupplier("ListClusters"))
              .build();
        }
      }
    }
    return getListClustersMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.partner.aistreams.v1alpha1.GetClusterRequest,
      com.google.partner.aistreams.v1alpha1.Cluster> getGetClusterMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "GetCluster",
      requestType = com.google.partner.aistreams.v1alpha1.GetClusterRequest.class,
      responseType = com.google.partner.aistreams.v1alpha1.Cluster.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.partner.aistreams.v1alpha1.GetClusterRequest,
      com.google.partner.aistreams.v1alpha1.Cluster> getGetClusterMethod() {
    io.grpc.MethodDescriptor<com.google.partner.aistreams.v1alpha1.GetClusterRequest, com.google.partner.aistreams.v1alpha1.Cluster> getGetClusterMethod;
    if ((getGetClusterMethod = AIStreamsGrpc.getGetClusterMethod) == null) {
      synchronized (AIStreamsGrpc.class) {
        if ((getGetClusterMethod = AIStreamsGrpc.getGetClusterMethod) == null) {
          AIStreamsGrpc.getGetClusterMethod = getGetClusterMethod =
              io.grpc.MethodDescriptor.<com.google.partner.aistreams.v1alpha1.GetClusterRequest, com.google.partner.aistreams.v1alpha1.Cluster>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "GetCluster"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.partner.aistreams.v1alpha1.GetClusterRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.partner.aistreams.v1alpha1.Cluster.getDefaultInstance()))
              .setSchemaDescriptor(new AIStreamsMethodDescriptorSupplier("GetCluster"))
              .build();
        }
      }
    }
    return getGetClusterMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.partner.aistreams.v1alpha1.CreateClusterRequest,
      com.google.longrunning.Operation> getCreateClusterMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "CreateCluster",
      requestType = com.google.partner.aistreams.v1alpha1.CreateClusterRequest.class,
      responseType = com.google.longrunning.Operation.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.partner.aistreams.v1alpha1.CreateClusterRequest,
      com.google.longrunning.Operation> getCreateClusterMethod() {
    io.grpc.MethodDescriptor<com.google.partner.aistreams.v1alpha1.CreateClusterRequest, com.google.longrunning.Operation> getCreateClusterMethod;
    if ((getCreateClusterMethod = AIStreamsGrpc.getCreateClusterMethod) == null) {
      synchronized (AIStreamsGrpc.class) {
        if ((getCreateClusterMethod = AIStreamsGrpc.getCreateClusterMethod) == null) {
          AIStreamsGrpc.getCreateClusterMethod = getCreateClusterMethod =
              io.grpc.MethodDescriptor.<com.google.partner.aistreams.v1alpha1.CreateClusterRequest, com.google.longrunning.Operation>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "CreateCluster"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.partner.aistreams.v1alpha1.CreateClusterRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.longrunning.Operation.getDefaultInstance()))
              .setSchemaDescriptor(new AIStreamsMethodDescriptorSupplier("CreateCluster"))
              .build();
        }
      }
    }
    return getCreateClusterMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.partner.aistreams.v1alpha1.UpdateClusterRequest,
      com.google.longrunning.Operation> getUpdateClusterMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "UpdateCluster",
      requestType = com.google.partner.aistreams.v1alpha1.UpdateClusterRequest.class,
      responseType = com.google.longrunning.Operation.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.partner.aistreams.v1alpha1.UpdateClusterRequest,
      com.google.longrunning.Operation> getUpdateClusterMethod() {
    io.grpc.MethodDescriptor<com.google.partner.aistreams.v1alpha1.UpdateClusterRequest, com.google.longrunning.Operation> getUpdateClusterMethod;
    if ((getUpdateClusterMethod = AIStreamsGrpc.getUpdateClusterMethod) == null) {
      synchronized (AIStreamsGrpc.class) {
        if ((getUpdateClusterMethod = AIStreamsGrpc.getUpdateClusterMethod) == null) {
          AIStreamsGrpc.getUpdateClusterMethod = getUpdateClusterMethod =
              io.grpc.MethodDescriptor.<com.google.partner.aistreams.v1alpha1.UpdateClusterRequest, com.google.longrunning.Operation>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "UpdateCluster"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.partner.aistreams.v1alpha1.UpdateClusterRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.longrunning.Operation.getDefaultInstance()))
              .setSchemaDescriptor(new AIStreamsMethodDescriptorSupplier("UpdateCluster"))
              .build();
        }
      }
    }
    return getUpdateClusterMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.partner.aistreams.v1alpha1.DeleteClusterRequest,
      com.google.longrunning.Operation> getDeleteClusterMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "DeleteCluster",
      requestType = com.google.partner.aistreams.v1alpha1.DeleteClusterRequest.class,
      responseType = com.google.longrunning.Operation.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.partner.aistreams.v1alpha1.DeleteClusterRequest,
      com.google.longrunning.Operation> getDeleteClusterMethod() {
    io.grpc.MethodDescriptor<com.google.partner.aistreams.v1alpha1.DeleteClusterRequest, com.google.longrunning.Operation> getDeleteClusterMethod;
    if ((getDeleteClusterMethod = AIStreamsGrpc.getDeleteClusterMethod) == null) {
      synchronized (AIStreamsGrpc.class) {
        if ((getDeleteClusterMethod = AIStreamsGrpc.getDeleteClusterMethod) == null) {
          AIStreamsGrpc.getDeleteClusterMethod = getDeleteClusterMethod =
              io.grpc.MethodDescriptor.<com.google.partner.aistreams.v1alpha1.DeleteClusterRequest, com.google.longrunning.Operation>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "DeleteCluster"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.partner.aistreams.v1alpha1.DeleteClusterRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.longrunning.Operation.getDefaultInstance()))
              .setSchemaDescriptor(new AIStreamsMethodDescriptorSupplier("DeleteCluster"))
              .build();
        }
      }
    }
    return getDeleteClusterMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.partner.aistreams.v1alpha1.ListStreamsRequest,
      com.google.partner.aistreams.v1alpha1.ListStreamsResponse> getListStreamsMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "ListStreams",
      requestType = com.google.partner.aistreams.v1alpha1.ListStreamsRequest.class,
      responseType = com.google.partner.aistreams.v1alpha1.ListStreamsResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.partner.aistreams.v1alpha1.ListStreamsRequest,
      com.google.partner.aistreams.v1alpha1.ListStreamsResponse> getListStreamsMethod() {
    io.grpc.MethodDescriptor<com.google.partner.aistreams.v1alpha1.ListStreamsRequest, com.google.partner.aistreams.v1alpha1.ListStreamsResponse> getListStreamsMethod;
    if ((getListStreamsMethod = AIStreamsGrpc.getListStreamsMethod) == null) {
      synchronized (AIStreamsGrpc.class) {
        if ((getListStreamsMethod = AIStreamsGrpc.getListStreamsMethod) == null) {
          AIStreamsGrpc.getListStreamsMethod = getListStreamsMethod =
              io.grpc.MethodDescriptor.<com.google.partner.aistreams.v1alpha1.ListStreamsRequest, com.google.partner.aistreams.v1alpha1.ListStreamsResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "ListStreams"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.partner.aistreams.v1alpha1.ListStreamsRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.partner.aistreams.v1alpha1.ListStreamsResponse.getDefaultInstance()))
              .setSchemaDescriptor(new AIStreamsMethodDescriptorSupplier("ListStreams"))
              .build();
        }
      }
    }
    return getListStreamsMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.partner.aistreams.v1alpha1.GetStreamRequest,
      com.google.partner.aistreams.v1alpha1.Stream> getGetStreamMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "GetStream",
      requestType = com.google.partner.aistreams.v1alpha1.GetStreamRequest.class,
      responseType = com.google.partner.aistreams.v1alpha1.Stream.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.partner.aistreams.v1alpha1.GetStreamRequest,
      com.google.partner.aistreams.v1alpha1.Stream> getGetStreamMethod() {
    io.grpc.MethodDescriptor<com.google.partner.aistreams.v1alpha1.GetStreamRequest, com.google.partner.aistreams.v1alpha1.Stream> getGetStreamMethod;
    if ((getGetStreamMethod = AIStreamsGrpc.getGetStreamMethod) == null) {
      synchronized (AIStreamsGrpc.class) {
        if ((getGetStreamMethod = AIStreamsGrpc.getGetStreamMethod) == null) {
          AIStreamsGrpc.getGetStreamMethod = getGetStreamMethod =
              io.grpc.MethodDescriptor.<com.google.partner.aistreams.v1alpha1.GetStreamRequest, com.google.partner.aistreams.v1alpha1.Stream>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "GetStream"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.partner.aistreams.v1alpha1.GetStreamRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.partner.aistreams.v1alpha1.Stream.getDefaultInstance()))
              .setSchemaDescriptor(new AIStreamsMethodDescriptorSupplier("GetStream"))
              .build();
        }
      }
    }
    return getGetStreamMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.partner.aistreams.v1alpha1.CreateStreamRequest,
      com.google.longrunning.Operation> getCreateStreamMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "CreateStream",
      requestType = com.google.partner.aistreams.v1alpha1.CreateStreamRequest.class,
      responseType = com.google.longrunning.Operation.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.partner.aistreams.v1alpha1.CreateStreamRequest,
      com.google.longrunning.Operation> getCreateStreamMethod() {
    io.grpc.MethodDescriptor<com.google.partner.aistreams.v1alpha1.CreateStreamRequest, com.google.longrunning.Operation> getCreateStreamMethod;
    if ((getCreateStreamMethod = AIStreamsGrpc.getCreateStreamMethod) == null) {
      synchronized (AIStreamsGrpc.class) {
        if ((getCreateStreamMethod = AIStreamsGrpc.getCreateStreamMethod) == null) {
          AIStreamsGrpc.getCreateStreamMethod = getCreateStreamMethod =
              io.grpc.MethodDescriptor.<com.google.partner.aistreams.v1alpha1.CreateStreamRequest, com.google.longrunning.Operation>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "CreateStream"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.partner.aistreams.v1alpha1.CreateStreamRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.longrunning.Operation.getDefaultInstance()))
              .setSchemaDescriptor(new AIStreamsMethodDescriptorSupplier("CreateStream"))
              .build();
        }
      }
    }
    return getCreateStreamMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.partner.aistreams.v1alpha1.UpdateStreamRequest,
      com.google.longrunning.Operation> getUpdateStreamMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "UpdateStream",
      requestType = com.google.partner.aistreams.v1alpha1.UpdateStreamRequest.class,
      responseType = com.google.longrunning.Operation.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.partner.aistreams.v1alpha1.UpdateStreamRequest,
      com.google.longrunning.Operation> getUpdateStreamMethod() {
    io.grpc.MethodDescriptor<com.google.partner.aistreams.v1alpha1.UpdateStreamRequest, com.google.longrunning.Operation> getUpdateStreamMethod;
    if ((getUpdateStreamMethod = AIStreamsGrpc.getUpdateStreamMethod) == null) {
      synchronized (AIStreamsGrpc.class) {
        if ((getUpdateStreamMethod = AIStreamsGrpc.getUpdateStreamMethod) == null) {
          AIStreamsGrpc.getUpdateStreamMethod = getUpdateStreamMethod =
              io.grpc.MethodDescriptor.<com.google.partner.aistreams.v1alpha1.UpdateStreamRequest, com.google.longrunning.Operation>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "UpdateStream"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.partner.aistreams.v1alpha1.UpdateStreamRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.longrunning.Operation.getDefaultInstance()))
              .setSchemaDescriptor(new AIStreamsMethodDescriptorSupplier("UpdateStream"))
              .build();
        }
      }
    }
    return getUpdateStreamMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.partner.aistreams.v1alpha1.DeleteStreamRequest,
      com.google.longrunning.Operation> getDeleteStreamMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "DeleteStream",
      requestType = com.google.partner.aistreams.v1alpha1.DeleteStreamRequest.class,
      responseType = com.google.longrunning.Operation.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.partner.aistreams.v1alpha1.DeleteStreamRequest,
      com.google.longrunning.Operation> getDeleteStreamMethod() {
    io.grpc.MethodDescriptor<com.google.partner.aistreams.v1alpha1.DeleteStreamRequest, com.google.longrunning.Operation> getDeleteStreamMethod;
    if ((getDeleteStreamMethod = AIStreamsGrpc.getDeleteStreamMethod) == null) {
      synchronized (AIStreamsGrpc.class) {
        if ((getDeleteStreamMethod = AIStreamsGrpc.getDeleteStreamMethod) == null) {
          AIStreamsGrpc.getDeleteStreamMethod = getDeleteStreamMethod =
              io.grpc.MethodDescriptor.<com.google.partner.aistreams.v1alpha1.DeleteStreamRequest, com.google.longrunning.Operation>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "DeleteStream"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.partner.aistreams.v1alpha1.DeleteStreamRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.longrunning.Operation.getDefaultInstance()))
              .setSchemaDescriptor(new AIStreamsMethodDescriptorSupplier("DeleteStream"))
              .build();
        }
      }
    }
    return getDeleteStreamMethod;
  }

  /**
   * Creates a new async stub that supports all call types for the service
   */
  public static AIStreamsStub newStub(io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<AIStreamsStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<AIStreamsStub>() {
        @java.lang.Override
        public AIStreamsStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new AIStreamsStub(channel, callOptions);
        }
      };
    return AIStreamsStub.newStub(factory, channel);
  }

  /**
   * Creates a new blocking-style stub that supports unary and streaming output calls on the service
   */
  public static AIStreamsBlockingStub newBlockingStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<AIStreamsBlockingStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<AIStreamsBlockingStub>() {
        @java.lang.Override
        public AIStreamsBlockingStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new AIStreamsBlockingStub(channel, callOptions);
        }
      };
    return AIStreamsBlockingStub.newStub(factory, channel);
  }

  /**
   * Creates a new ListenableFuture-style stub that supports unary calls on the service
   */
  public static AIStreamsFutureStub newFutureStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<AIStreamsFutureStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<AIStreamsFutureStub>() {
        @java.lang.Override
        public AIStreamsFutureStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new AIStreamsFutureStub(channel, callOptions);
        }
      };
    return AIStreamsFutureStub.newStub(factory, channel);
  }

  /**
   * <pre>
   * AIStreams service.
   * </pre>
   */
  public static abstract class AIStreamsImplBase implements io.grpc.BindableService {

    /**
     * <pre>
     * Lists Clusters in a given project and location.
     * </pre>
     */
    public void listClusters(com.google.partner.aistreams.v1alpha1.ListClustersRequest request,
        io.grpc.stub.StreamObserver<com.google.partner.aistreams.v1alpha1.ListClustersResponse> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getListClustersMethod(), responseObserver);
    }

    /**
     * <pre>
     * Gets details of a single Cluster.
     * </pre>
     */
    public void getCluster(com.google.partner.aistreams.v1alpha1.GetClusterRequest request,
        io.grpc.stub.StreamObserver<com.google.partner.aistreams.v1alpha1.Cluster> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getGetClusterMethod(), responseObserver);
    }

    /**
     * <pre>
     * Creates a new Cluster in a given project and location.
     * </pre>
     */
    public void createCluster(com.google.partner.aistreams.v1alpha1.CreateClusterRequest request,
        io.grpc.stub.StreamObserver<com.google.longrunning.Operation> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getCreateClusterMethod(), responseObserver);
    }

    /**
     * <pre>
     * Updates the parameters of a single Cluster.
     * </pre>
     */
    public void updateCluster(com.google.partner.aistreams.v1alpha1.UpdateClusterRequest request,
        io.grpc.stub.StreamObserver<com.google.longrunning.Operation> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getUpdateClusterMethod(), responseObserver);
    }

    /**
     * <pre>
     * Deletes a single Cluster.
     * </pre>
     */
    public void deleteCluster(com.google.partner.aistreams.v1alpha1.DeleteClusterRequest request,
        io.grpc.stub.StreamObserver<com.google.longrunning.Operation> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getDeleteClusterMethod(), responseObserver);
    }

    /**
     * <pre>
     * Lists Streams in a given project, location and cluster.
     * </pre>
     */
    public void listStreams(com.google.partner.aistreams.v1alpha1.ListStreamsRequest request,
        io.grpc.stub.StreamObserver<com.google.partner.aistreams.v1alpha1.ListStreamsResponse> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getListStreamsMethod(), responseObserver);
    }

    /**
     * <pre>
     * Gets details of a single Stream.
     * </pre>
     */
    public void getStream(com.google.partner.aistreams.v1alpha1.GetStreamRequest request,
        io.grpc.stub.StreamObserver<com.google.partner.aistreams.v1alpha1.Stream> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getGetStreamMethod(), responseObserver);
    }

    /**
     * <pre>
     * Creates a new Stream in a given project and location.
     * </pre>
     */
    public void createStream(com.google.partner.aistreams.v1alpha1.CreateStreamRequest request,
        io.grpc.stub.StreamObserver<com.google.longrunning.Operation> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getCreateStreamMethod(), responseObserver);
    }

    /**
     * <pre>
     * Updates the parameters of a single Stream.
     * </pre>
     */
    public void updateStream(com.google.partner.aistreams.v1alpha1.UpdateStreamRequest request,
        io.grpc.stub.StreamObserver<com.google.longrunning.Operation> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getUpdateStreamMethod(), responseObserver);
    }

    /**
     * <pre>
     * Deletes a single Stream.
     * </pre>
     */
    public void deleteStream(com.google.partner.aistreams.v1alpha1.DeleteStreamRequest request,
        io.grpc.stub.StreamObserver<com.google.longrunning.Operation> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getDeleteStreamMethod(), responseObserver);
    }

    @java.lang.Override public final io.grpc.ServerServiceDefinition bindService() {
      return io.grpc.ServerServiceDefinition.builder(getServiceDescriptor())
          .addMethod(
            getListClustersMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.partner.aistreams.v1alpha1.ListClustersRequest,
                com.google.partner.aistreams.v1alpha1.ListClustersResponse>(
                  this, METHODID_LIST_CLUSTERS)))
          .addMethod(
            getGetClusterMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.partner.aistreams.v1alpha1.GetClusterRequest,
                com.google.partner.aistreams.v1alpha1.Cluster>(
                  this, METHODID_GET_CLUSTER)))
          .addMethod(
            getCreateClusterMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.partner.aistreams.v1alpha1.CreateClusterRequest,
                com.google.longrunning.Operation>(
                  this, METHODID_CREATE_CLUSTER)))
          .addMethod(
            getUpdateClusterMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.partner.aistreams.v1alpha1.UpdateClusterRequest,
                com.google.longrunning.Operation>(
                  this, METHODID_UPDATE_CLUSTER)))
          .addMethod(
            getDeleteClusterMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.partner.aistreams.v1alpha1.DeleteClusterRequest,
                com.google.longrunning.Operation>(
                  this, METHODID_DELETE_CLUSTER)))
          .addMethod(
            getListStreamsMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.partner.aistreams.v1alpha1.ListStreamsRequest,
                com.google.partner.aistreams.v1alpha1.ListStreamsResponse>(
                  this, METHODID_LIST_STREAMS)))
          .addMethod(
            getGetStreamMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.partner.aistreams.v1alpha1.GetStreamRequest,
                com.google.partner.aistreams.v1alpha1.Stream>(
                  this, METHODID_GET_STREAM)))
          .addMethod(
            getCreateStreamMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.partner.aistreams.v1alpha1.CreateStreamRequest,
                com.google.longrunning.Operation>(
                  this, METHODID_CREATE_STREAM)))
          .addMethod(
            getUpdateStreamMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.partner.aistreams.v1alpha1.UpdateStreamRequest,
                com.google.longrunning.Operation>(
                  this, METHODID_UPDATE_STREAM)))
          .addMethod(
            getDeleteStreamMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.partner.aistreams.v1alpha1.DeleteStreamRequest,
                com.google.longrunning.Operation>(
                  this, METHODID_DELETE_STREAM)))
          .build();
    }
  }

  /**
   * <pre>
   * AIStreams service.
   * </pre>
   */
  public static final class AIStreamsStub extends io.grpc.stub.AbstractAsyncStub<AIStreamsStub> {
    private AIStreamsStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected AIStreamsStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new AIStreamsStub(channel, callOptions);
    }

    /**
     * <pre>
     * Lists Clusters in a given project and location.
     * </pre>
     */
    public void listClusters(com.google.partner.aistreams.v1alpha1.ListClustersRequest request,
        io.grpc.stub.StreamObserver<com.google.partner.aistreams.v1alpha1.ListClustersResponse> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getListClustersMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Gets details of a single Cluster.
     * </pre>
     */
    public void getCluster(com.google.partner.aistreams.v1alpha1.GetClusterRequest request,
        io.grpc.stub.StreamObserver<com.google.partner.aistreams.v1alpha1.Cluster> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getGetClusterMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Creates a new Cluster in a given project and location.
     * </pre>
     */
    public void createCluster(com.google.partner.aistreams.v1alpha1.CreateClusterRequest request,
        io.grpc.stub.StreamObserver<com.google.longrunning.Operation> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getCreateClusterMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Updates the parameters of a single Cluster.
     * </pre>
     */
    public void updateCluster(com.google.partner.aistreams.v1alpha1.UpdateClusterRequest request,
        io.grpc.stub.StreamObserver<com.google.longrunning.Operation> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getUpdateClusterMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Deletes a single Cluster.
     * </pre>
     */
    public void deleteCluster(com.google.partner.aistreams.v1alpha1.DeleteClusterRequest request,
        io.grpc.stub.StreamObserver<com.google.longrunning.Operation> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getDeleteClusterMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Lists Streams in a given project, location and cluster.
     * </pre>
     */
    public void listStreams(com.google.partner.aistreams.v1alpha1.ListStreamsRequest request,
        io.grpc.stub.StreamObserver<com.google.partner.aistreams.v1alpha1.ListStreamsResponse> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getListStreamsMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Gets details of a single Stream.
     * </pre>
     */
    public void getStream(com.google.partner.aistreams.v1alpha1.GetStreamRequest request,
        io.grpc.stub.StreamObserver<com.google.partner.aistreams.v1alpha1.Stream> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getGetStreamMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Creates a new Stream in a given project and location.
     * </pre>
     */
    public void createStream(com.google.partner.aistreams.v1alpha1.CreateStreamRequest request,
        io.grpc.stub.StreamObserver<com.google.longrunning.Operation> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getCreateStreamMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Updates the parameters of a single Stream.
     * </pre>
     */
    public void updateStream(com.google.partner.aistreams.v1alpha1.UpdateStreamRequest request,
        io.grpc.stub.StreamObserver<com.google.longrunning.Operation> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getUpdateStreamMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Deletes a single Stream.
     * </pre>
     */
    public void deleteStream(com.google.partner.aistreams.v1alpha1.DeleteStreamRequest request,
        io.grpc.stub.StreamObserver<com.google.longrunning.Operation> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getDeleteStreamMethod(), getCallOptions()), request, responseObserver);
    }
  }

  /**
   * <pre>
   * AIStreams service.
   * </pre>
   */
  public static final class AIStreamsBlockingStub extends io.grpc.stub.AbstractBlockingStub<AIStreamsBlockingStub> {
    private AIStreamsBlockingStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected AIStreamsBlockingStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new AIStreamsBlockingStub(channel, callOptions);
    }

    /**
     * <pre>
     * Lists Clusters in a given project and location.
     * </pre>
     */
    public com.google.partner.aistreams.v1alpha1.ListClustersResponse listClusters(com.google.partner.aistreams.v1alpha1.ListClustersRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getListClustersMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Gets details of a single Cluster.
     * </pre>
     */
    public com.google.partner.aistreams.v1alpha1.Cluster getCluster(com.google.partner.aistreams.v1alpha1.GetClusterRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getGetClusterMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Creates a new Cluster in a given project and location.
     * </pre>
     */
    public com.google.longrunning.Operation createCluster(com.google.partner.aistreams.v1alpha1.CreateClusterRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getCreateClusterMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Updates the parameters of a single Cluster.
     * </pre>
     */
    public com.google.longrunning.Operation updateCluster(com.google.partner.aistreams.v1alpha1.UpdateClusterRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getUpdateClusterMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Deletes a single Cluster.
     * </pre>
     */
    public com.google.longrunning.Operation deleteCluster(com.google.partner.aistreams.v1alpha1.DeleteClusterRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getDeleteClusterMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Lists Streams in a given project, location and cluster.
     * </pre>
     */
    public com.google.partner.aistreams.v1alpha1.ListStreamsResponse listStreams(com.google.partner.aistreams.v1alpha1.ListStreamsRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getListStreamsMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Gets details of a single Stream.
     * </pre>
     */
    public com.google.partner.aistreams.v1alpha1.Stream getStream(com.google.partner.aistreams.v1alpha1.GetStreamRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getGetStreamMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Creates a new Stream in a given project and location.
     * </pre>
     */
    public com.google.longrunning.Operation createStream(com.google.partner.aistreams.v1alpha1.CreateStreamRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getCreateStreamMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Updates the parameters of a single Stream.
     * </pre>
     */
    public com.google.longrunning.Operation updateStream(com.google.partner.aistreams.v1alpha1.UpdateStreamRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getUpdateStreamMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Deletes a single Stream.
     * </pre>
     */
    public com.google.longrunning.Operation deleteStream(com.google.partner.aistreams.v1alpha1.DeleteStreamRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getDeleteStreamMethod(), getCallOptions(), request);
    }
  }

  /**
   * <pre>
   * AIStreams service.
   * </pre>
   */
  public static final class AIStreamsFutureStub extends io.grpc.stub.AbstractFutureStub<AIStreamsFutureStub> {
    private AIStreamsFutureStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected AIStreamsFutureStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new AIStreamsFutureStub(channel, callOptions);
    }

    /**
     * <pre>
     * Lists Clusters in a given project and location.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.partner.aistreams.v1alpha1.ListClustersResponse> listClusters(
        com.google.partner.aistreams.v1alpha1.ListClustersRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getListClustersMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Gets details of a single Cluster.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.partner.aistreams.v1alpha1.Cluster> getCluster(
        com.google.partner.aistreams.v1alpha1.GetClusterRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getGetClusterMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Creates a new Cluster in a given project and location.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.longrunning.Operation> createCluster(
        com.google.partner.aistreams.v1alpha1.CreateClusterRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getCreateClusterMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Updates the parameters of a single Cluster.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.longrunning.Operation> updateCluster(
        com.google.partner.aistreams.v1alpha1.UpdateClusterRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getUpdateClusterMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Deletes a single Cluster.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.longrunning.Operation> deleteCluster(
        com.google.partner.aistreams.v1alpha1.DeleteClusterRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getDeleteClusterMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Lists Streams in a given project, location and cluster.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.partner.aistreams.v1alpha1.ListStreamsResponse> listStreams(
        com.google.partner.aistreams.v1alpha1.ListStreamsRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getListStreamsMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Gets details of a single Stream.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.partner.aistreams.v1alpha1.Stream> getStream(
        com.google.partner.aistreams.v1alpha1.GetStreamRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getGetStreamMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Creates a new Stream in a given project and location.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.longrunning.Operation> createStream(
        com.google.partner.aistreams.v1alpha1.CreateStreamRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getCreateStreamMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Updates the parameters of a single Stream.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.longrunning.Operation> updateStream(
        com.google.partner.aistreams.v1alpha1.UpdateStreamRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getUpdateStreamMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Deletes a single Stream.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.longrunning.Operation> deleteStream(
        com.google.partner.aistreams.v1alpha1.DeleteStreamRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getDeleteStreamMethod(), getCallOptions()), request);
    }
  }

  private static final int METHODID_LIST_CLUSTERS = 0;
  private static final int METHODID_GET_CLUSTER = 1;
  private static final int METHODID_CREATE_CLUSTER = 2;
  private static final int METHODID_UPDATE_CLUSTER = 3;
  private static final int METHODID_DELETE_CLUSTER = 4;
  private static final int METHODID_LIST_STREAMS = 5;
  private static final int METHODID_GET_STREAM = 6;
  private static final int METHODID_CREATE_STREAM = 7;
  private static final int METHODID_UPDATE_STREAM = 8;
  private static final int METHODID_DELETE_STREAM = 9;

  private static final class MethodHandlers<Req, Resp> implements
      io.grpc.stub.ServerCalls.UnaryMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ServerStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ClientStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.BidiStreamingMethod<Req, Resp> {
    private final AIStreamsImplBase serviceImpl;
    private final int methodId;

    MethodHandlers(AIStreamsImplBase serviceImpl, int methodId) {
      this.serviceImpl = serviceImpl;
      this.methodId = methodId;
    }

    @java.lang.Override
    @java.lang.SuppressWarnings("unchecked")
    public void invoke(Req request, io.grpc.stub.StreamObserver<Resp> responseObserver) {
      switch (methodId) {
        case METHODID_LIST_CLUSTERS:
          serviceImpl.listClusters((com.google.partner.aistreams.v1alpha1.ListClustersRequest) request,
              (io.grpc.stub.StreamObserver<com.google.partner.aistreams.v1alpha1.ListClustersResponse>) responseObserver);
          break;
        case METHODID_GET_CLUSTER:
          serviceImpl.getCluster((com.google.partner.aistreams.v1alpha1.GetClusterRequest) request,
              (io.grpc.stub.StreamObserver<com.google.partner.aistreams.v1alpha1.Cluster>) responseObserver);
          break;
        case METHODID_CREATE_CLUSTER:
          serviceImpl.createCluster((com.google.partner.aistreams.v1alpha1.CreateClusterRequest) request,
              (io.grpc.stub.StreamObserver<com.google.longrunning.Operation>) responseObserver);
          break;
        case METHODID_UPDATE_CLUSTER:
          serviceImpl.updateCluster((com.google.partner.aistreams.v1alpha1.UpdateClusterRequest) request,
              (io.grpc.stub.StreamObserver<com.google.longrunning.Operation>) responseObserver);
          break;
        case METHODID_DELETE_CLUSTER:
          serviceImpl.deleteCluster((com.google.partner.aistreams.v1alpha1.DeleteClusterRequest) request,
              (io.grpc.stub.StreamObserver<com.google.longrunning.Operation>) responseObserver);
          break;
        case METHODID_LIST_STREAMS:
          serviceImpl.listStreams((com.google.partner.aistreams.v1alpha1.ListStreamsRequest) request,
              (io.grpc.stub.StreamObserver<com.google.partner.aistreams.v1alpha1.ListStreamsResponse>) responseObserver);
          break;
        case METHODID_GET_STREAM:
          serviceImpl.getStream((com.google.partner.aistreams.v1alpha1.GetStreamRequest) request,
              (io.grpc.stub.StreamObserver<com.google.partner.aistreams.v1alpha1.Stream>) responseObserver);
          break;
        case METHODID_CREATE_STREAM:
          serviceImpl.createStream((com.google.partner.aistreams.v1alpha1.CreateStreamRequest) request,
              (io.grpc.stub.StreamObserver<com.google.longrunning.Operation>) responseObserver);
          break;
        case METHODID_UPDATE_STREAM:
          serviceImpl.updateStream((com.google.partner.aistreams.v1alpha1.UpdateStreamRequest) request,
              (io.grpc.stub.StreamObserver<com.google.longrunning.Operation>) responseObserver);
          break;
        case METHODID_DELETE_STREAM:
          serviceImpl.deleteStream((com.google.partner.aistreams.v1alpha1.DeleteStreamRequest) request,
              (io.grpc.stub.StreamObserver<com.google.longrunning.Operation>) responseObserver);
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

  private static abstract class AIStreamsBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoFileDescriptorSupplier, io.grpc.protobuf.ProtoServiceDescriptorSupplier {
    AIStreamsBaseDescriptorSupplier() {}

    @java.lang.Override
    public com.google.protobuf.Descriptors.FileDescriptor getFileDescriptor() {
      return com.google.partner.aistreams.v1alpha1.AIStreamsProto.getDescriptor();
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.ServiceDescriptor getServiceDescriptor() {
      return getFileDescriptor().findServiceByName("AIStreams");
    }
  }

  private static final class AIStreamsFileDescriptorSupplier
      extends AIStreamsBaseDescriptorSupplier {
    AIStreamsFileDescriptorSupplier() {}
  }

  private static final class AIStreamsMethodDescriptorSupplier
      extends AIStreamsBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoMethodDescriptorSupplier {
    private final String methodName;

    AIStreamsMethodDescriptorSupplier(String methodName) {
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
      synchronized (AIStreamsGrpc.class) {
        result = serviceDescriptor;
        if (result == null) {
          serviceDescriptor = result = io.grpc.ServiceDescriptor.newBuilder(SERVICE_NAME)
              .setSchemaDescriptor(new AIStreamsFileDescriptorSupplier())
              .addMethod(getListClustersMethod())
              .addMethod(getGetClusterMethod())
              .addMethod(getCreateClusterMethod())
              .addMethod(getUpdateClusterMethod())
              .addMethod(getDeleteClusterMethod())
              .addMethod(getListStreamsMethod())
              .addMethod(getGetStreamMethod())
              .addMethod(getCreateStreamMethod())
              .addMethod(getUpdateStreamMethod())
              .addMethod(getDeleteStreamMethod())
              .build();
        }
      }
    }
    return result;
  }
}
