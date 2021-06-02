package com.google.cloud.ondemandscanning.v1;

import static io.grpc.MethodDescriptor.generateFullMethodName;

/**
 * <pre>
 * The Scanner service of the On-Demand Scanning API.
 * This service provides a way to find vulnerabilities for the packages in some
 * container image. A user provides a a list of packages to `AnalyzePackages`
 * and receives a list of vulnerabilities in return. The `AnalyzePackages`
 * method is asynchronous, implementing Long-running Operations to track
 * progress.
 * </pre>
 */
@javax.annotation.Generated(
    value = "by gRPC proto compiler",
    comments = "Source: google/cloud/ondemandscanning/v1/scanner_service.proto")
public final class ScannerServiceGrpc {

  private ScannerServiceGrpc() {}

  public static final String SERVICE_NAME = "google.cloud.ondemandscanning.v1.ScannerService";

  // Static method descriptors that strictly reflect the proto.
  private static volatile io.grpc.MethodDescriptor<com.google.cloud.ondemandscanning.v1.AnalyzePackagesRequest,
      com.google.longrunning.Operation> getAnalyzePackagesMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "AnalyzePackages",
      requestType = com.google.cloud.ondemandscanning.v1.AnalyzePackagesRequest.class,
      responseType = com.google.longrunning.Operation.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.cloud.ondemandscanning.v1.AnalyzePackagesRequest,
      com.google.longrunning.Operation> getAnalyzePackagesMethod() {
    io.grpc.MethodDescriptor<com.google.cloud.ondemandscanning.v1.AnalyzePackagesRequest, com.google.longrunning.Operation> getAnalyzePackagesMethod;
    if ((getAnalyzePackagesMethod = ScannerServiceGrpc.getAnalyzePackagesMethod) == null) {
      synchronized (ScannerServiceGrpc.class) {
        if ((getAnalyzePackagesMethod = ScannerServiceGrpc.getAnalyzePackagesMethod) == null) {
          ScannerServiceGrpc.getAnalyzePackagesMethod = getAnalyzePackagesMethod =
              io.grpc.MethodDescriptor.<com.google.cloud.ondemandscanning.v1.AnalyzePackagesRequest, com.google.longrunning.Operation>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "AnalyzePackages"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.ondemandscanning.v1.AnalyzePackagesRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.longrunning.Operation.getDefaultInstance()))
              .setSchemaDescriptor(new ScannerServiceMethodDescriptorSupplier("AnalyzePackages"))
              .build();
        }
      }
    }
    return getAnalyzePackagesMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.cloud.ondemandscanning.v1.ListVulnerabilitiesRequest,
      com.google.cloud.ondemandscanning.v1.ListVulnerabilitiesResponse> getListVulnerabilitiesMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "ListVulnerabilities",
      requestType = com.google.cloud.ondemandscanning.v1.ListVulnerabilitiesRequest.class,
      responseType = com.google.cloud.ondemandscanning.v1.ListVulnerabilitiesResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.cloud.ondemandscanning.v1.ListVulnerabilitiesRequest,
      com.google.cloud.ondemandscanning.v1.ListVulnerabilitiesResponse> getListVulnerabilitiesMethod() {
    io.grpc.MethodDescriptor<com.google.cloud.ondemandscanning.v1.ListVulnerabilitiesRequest, com.google.cloud.ondemandscanning.v1.ListVulnerabilitiesResponse> getListVulnerabilitiesMethod;
    if ((getListVulnerabilitiesMethod = ScannerServiceGrpc.getListVulnerabilitiesMethod) == null) {
      synchronized (ScannerServiceGrpc.class) {
        if ((getListVulnerabilitiesMethod = ScannerServiceGrpc.getListVulnerabilitiesMethod) == null) {
          ScannerServiceGrpc.getListVulnerabilitiesMethod = getListVulnerabilitiesMethod =
              io.grpc.MethodDescriptor.<com.google.cloud.ondemandscanning.v1.ListVulnerabilitiesRequest, com.google.cloud.ondemandscanning.v1.ListVulnerabilitiesResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "ListVulnerabilities"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.ondemandscanning.v1.ListVulnerabilitiesRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.ondemandscanning.v1.ListVulnerabilitiesResponse.getDefaultInstance()))
              .setSchemaDescriptor(new ScannerServiceMethodDescriptorSupplier("ListVulnerabilities"))
              .build();
        }
      }
    }
    return getListVulnerabilitiesMethod;
  }

  /**
   * Creates a new async stub that supports all call types for the service
   */
  public static ScannerServiceStub newStub(io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<ScannerServiceStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<ScannerServiceStub>() {
        @java.lang.Override
        public ScannerServiceStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new ScannerServiceStub(channel, callOptions);
        }
      };
    return ScannerServiceStub.newStub(factory, channel);
  }

  /**
   * Creates a new blocking-style stub that supports unary and streaming output calls on the service
   */
  public static ScannerServiceBlockingStub newBlockingStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<ScannerServiceBlockingStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<ScannerServiceBlockingStub>() {
        @java.lang.Override
        public ScannerServiceBlockingStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new ScannerServiceBlockingStub(channel, callOptions);
        }
      };
    return ScannerServiceBlockingStub.newStub(factory, channel);
  }

  /**
   * Creates a new ListenableFuture-style stub that supports unary calls on the service
   */
  public static ScannerServiceFutureStub newFutureStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<ScannerServiceFutureStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<ScannerServiceFutureStub>() {
        @java.lang.Override
        public ScannerServiceFutureStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new ScannerServiceFutureStub(channel, callOptions);
        }
      };
    return ScannerServiceFutureStub.newStub(factory, channel);
  }

  /**
   * <pre>
   * The Scanner service of the On-Demand Scanning API.
   * This service provides a way to find vulnerabilities for the packages in some
   * container image. A user provides a a list of packages to `AnalyzePackages`
   * and receives a list of vulnerabilities in return. The `AnalyzePackages`
   * method is asynchronous, implementing Long-running Operations to track
   * progress.
   * </pre>
   */
  public static abstract class ScannerServiceImplBase implements io.grpc.BindableService {

    /**
     * <pre>
     * Initiates an analysis of the provided packages.
     * </pre>
     */
    public void analyzePackages(com.google.cloud.ondemandscanning.v1.AnalyzePackagesRequest request,
        io.grpc.stub.StreamObserver<com.google.longrunning.Operation> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getAnalyzePackagesMethod(), responseObserver);
    }

    /**
     * <pre>
     * Lists vulnerabilities resulting from a successfully completed scan.
     * </pre>
     */
    public void listVulnerabilities(com.google.cloud.ondemandscanning.v1.ListVulnerabilitiesRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.ondemandscanning.v1.ListVulnerabilitiesResponse> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getListVulnerabilitiesMethod(), responseObserver);
    }

    @java.lang.Override public final io.grpc.ServerServiceDefinition bindService() {
      return io.grpc.ServerServiceDefinition.builder(getServiceDescriptor())
          .addMethod(
            getAnalyzePackagesMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.cloud.ondemandscanning.v1.AnalyzePackagesRequest,
                com.google.longrunning.Operation>(
                  this, METHODID_ANALYZE_PACKAGES)))
          .addMethod(
            getListVulnerabilitiesMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.cloud.ondemandscanning.v1.ListVulnerabilitiesRequest,
                com.google.cloud.ondemandscanning.v1.ListVulnerabilitiesResponse>(
                  this, METHODID_LIST_VULNERABILITIES)))
          .build();
    }
  }

  /**
   * <pre>
   * The Scanner service of the On-Demand Scanning API.
   * This service provides a way to find vulnerabilities for the packages in some
   * container image. A user provides a a list of packages to `AnalyzePackages`
   * and receives a list of vulnerabilities in return. The `AnalyzePackages`
   * method is asynchronous, implementing Long-running Operations to track
   * progress.
   * </pre>
   */
  public static final class ScannerServiceStub extends io.grpc.stub.AbstractAsyncStub<ScannerServiceStub> {
    private ScannerServiceStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected ScannerServiceStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new ScannerServiceStub(channel, callOptions);
    }

    /**
     * <pre>
     * Initiates an analysis of the provided packages.
     * </pre>
     */
    public void analyzePackages(com.google.cloud.ondemandscanning.v1.AnalyzePackagesRequest request,
        io.grpc.stub.StreamObserver<com.google.longrunning.Operation> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getAnalyzePackagesMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Lists vulnerabilities resulting from a successfully completed scan.
     * </pre>
     */
    public void listVulnerabilities(com.google.cloud.ondemandscanning.v1.ListVulnerabilitiesRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.ondemandscanning.v1.ListVulnerabilitiesResponse> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getListVulnerabilitiesMethod(), getCallOptions()), request, responseObserver);
    }
  }

  /**
   * <pre>
   * The Scanner service of the On-Demand Scanning API.
   * This service provides a way to find vulnerabilities for the packages in some
   * container image. A user provides a a list of packages to `AnalyzePackages`
   * and receives a list of vulnerabilities in return. The `AnalyzePackages`
   * method is asynchronous, implementing Long-running Operations to track
   * progress.
   * </pre>
   */
  public static final class ScannerServiceBlockingStub extends io.grpc.stub.AbstractBlockingStub<ScannerServiceBlockingStub> {
    private ScannerServiceBlockingStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected ScannerServiceBlockingStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new ScannerServiceBlockingStub(channel, callOptions);
    }

    /**
     * <pre>
     * Initiates an analysis of the provided packages.
     * </pre>
     */
    public com.google.longrunning.Operation analyzePackages(com.google.cloud.ondemandscanning.v1.AnalyzePackagesRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getAnalyzePackagesMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Lists vulnerabilities resulting from a successfully completed scan.
     * </pre>
     */
    public com.google.cloud.ondemandscanning.v1.ListVulnerabilitiesResponse listVulnerabilities(com.google.cloud.ondemandscanning.v1.ListVulnerabilitiesRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getListVulnerabilitiesMethod(), getCallOptions(), request);
    }
  }

  /**
   * <pre>
   * The Scanner service of the On-Demand Scanning API.
   * This service provides a way to find vulnerabilities for the packages in some
   * container image. A user provides a a list of packages to `AnalyzePackages`
   * and receives a list of vulnerabilities in return. The `AnalyzePackages`
   * method is asynchronous, implementing Long-running Operations to track
   * progress.
   * </pre>
   */
  public static final class ScannerServiceFutureStub extends io.grpc.stub.AbstractFutureStub<ScannerServiceFutureStub> {
    private ScannerServiceFutureStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected ScannerServiceFutureStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new ScannerServiceFutureStub(channel, callOptions);
    }

    /**
     * <pre>
     * Initiates an analysis of the provided packages.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.longrunning.Operation> analyzePackages(
        com.google.cloud.ondemandscanning.v1.AnalyzePackagesRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getAnalyzePackagesMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Lists vulnerabilities resulting from a successfully completed scan.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.cloud.ondemandscanning.v1.ListVulnerabilitiesResponse> listVulnerabilities(
        com.google.cloud.ondemandscanning.v1.ListVulnerabilitiesRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getListVulnerabilitiesMethod(), getCallOptions()), request);
    }
  }

  private static final int METHODID_ANALYZE_PACKAGES = 0;
  private static final int METHODID_LIST_VULNERABILITIES = 1;

  private static final class MethodHandlers<Req, Resp> implements
      io.grpc.stub.ServerCalls.UnaryMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ServerStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ClientStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.BidiStreamingMethod<Req, Resp> {
    private final ScannerServiceImplBase serviceImpl;
    private final int methodId;

    MethodHandlers(ScannerServiceImplBase serviceImpl, int methodId) {
      this.serviceImpl = serviceImpl;
      this.methodId = methodId;
    }

    @java.lang.Override
    @java.lang.SuppressWarnings("unchecked")
    public void invoke(Req request, io.grpc.stub.StreamObserver<Resp> responseObserver) {
      switch (methodId) {
        case METHODID_ANALYZE_PACKAGES:
          serviceImpl.analyzePackages((com.google.cloud.ondemandscanning.v1.AnalyzePackagesRequest) request,
              (io.grpc.stub.StreamObserver<com.google.longrunning.Operation>) responseObserver);
          break;
        case METHODID_LIST_VULNERABILITIES:
          serviceImpl.listVulnerabilities((com.google.cloud.ondemandscanning.v1.ListVulnerabilitiesRequest) request,
              (io.grpc.stub.StreamObserver<com.google.cloud.ondemandscanning.v1.ListVulnerabilitiesResponse>) responseObserver);
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

  private static abstract class ScannerServiceBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoFileDescriptorSupplier, io.grpc.protobuf.ProtoServiceDescriptorSupplier {
    ScannerServiceBaseDescriptorSupplier() {}

    @java.lang.Override
    public com.google.protobuf.Descriptors.FileDescriptor getFileDescriptor() {
      return com.google.cloud.ondemandscanning.v1.ScannerServiceProto.getDescriptor();
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.ServiceDescriptor getServiceDescriptor() {
      return getFileDescriptor().findServiceByName("ScannerService");
    }
  }

  private static final class ScannerServiceFileDescriptorSupplier
      extends ScannerServiceBaseDescriptorSupplier {
    ScannerServiceFileDescriptorSupplier() {}
  }

  private static final class ScannerServiceMethodDescriptorSupplier
      extends ScannerServiceBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoMethodDescriptorSupplier {
    private final String methodName;

    ScannerServiceMethodDescriptorSupplier(String methodName) {
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
      synchronized (ScannerServiceGrpc.class) {
        result = serviceDescriptor;
        if (result == null) {
          serviceDescriptor = result = io.grpc.ServiceDescriptor.newBuilder(SERVICE_NAME)
              .setSchemaDescriptor(new ScannerServiceFileDescriptorSupplier())
              .addMethod(getAnalyzePackagesMethod())
              .addMethod(getListVulnerabilitiesMethod())
              .build();
        }
      }
    }
    return result;
  }
}
