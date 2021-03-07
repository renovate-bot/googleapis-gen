package com.google.ads.admob.v1;

import static io.grpc.MethodDescriptor.generateFullMethodName;

/**
 * <pre>
 * The AdMob API allows AdMob publishers programmatically get information about
 * their AdMob account.
 * </pre>
 */
@javax.annotation.Generated(
    value = "by gRPC proto compiler",
    comments = "Source: google/ads/admob/v1/admob_api.proto")
public final class AdMobApiGrpc {

  private AdMobApiGrpc() {}

  public static final String SERVICE_NAME = "google.ads.admob.v1.AdMobApi";

  // Static method descriptors that strictly reflect the proto.
  private static volatile io.grpc.MethodDescriptor<com.google.ads.admob.v1.AdMobApiProto.GetPublisherAccountRequest,
      com.google.ads.admob.v1.AdMobResourcesProto.PublisherAccount> getGetPublisherAccountMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "GetPublisherAccount",
      requestType = com.google.ads.admob.v1.AdMobApiProto.GetPublisherAccountRequest.class,
      responseType = com.google.ads.admob.v1.AdMobResourcesProto.PublisherAccount.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.ads.admob.v1.AdMobApiProto.GetPublisherAccountRequest,
      com.google.ads.admob.v1.AdMobResourcesProto.PublisherAccount> getGetPublisherAccountMethod() {
    io.grpc.MethodDescriptor<com.google.ads.admob.v1.AdMobApiProto.GetPublisherAccountRequest, com.google.ads.admob.v1.AdMobResourcesProto.PublisherAccount> getGetPublisherAccountMethod;
    if ((getGetPublisherAccountMethod = AdMobApiGrpc.getGetPublisherAccountMethod) == null) {
      synchronized (AdMobApiGrpc.class) {
        if ((getGetPublisherAccountMethod = AdMobApiGrpc.getGetPublisherAccountMethod) == null) {
          AdMobApiGrpc.getGetPublisherAccountMethod = getGetPublisherAccountMethod =
              io.grpc.MethodDescriptor.<com.google.ads.admob.v1.AdMobApiProto.GetPublisherAccountRequest, com.google.ads.admob.v1.AdMobResourcesProto.PublisherAccount>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "GetPublisherAccount"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.ads.admob.v1.AdMobApiProto.GetPublisherAccountRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.ads.admob.v1.AdMobResourcesProto.PublisherAccount.getDefaultInstance()))
              .setSchemaDescriptor(new AdMobApiMethodDescriptorSupplier("GetPublisherAccount"))
              .build();
        }
      }
    }
    return getGetPublisherAccountMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.ads.admob.v1.AdMobApiProto.ListPublisherAccountsRequest,
      com.google.ads.admob.v1.AdMobApiProto.ListPublisherAccountsResponse> getListPublisherAccountsMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "ListPublisherAccounts",
      requestType = com.google.ads.admob.v1.AdMobApiProto.ListPublisherAccountsRequest.class,
      responseType = com.google.ads.admob.v1.AdMobApiProto.ListPublisherAccountsResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.ads.admob.v1.AdMobApiProto.ListPublisherAccountsRequest,
      com.google.ads.admob.v1.AdMobApiProto.ListPublisherAccountsResponse> getListPublisherAccountsMethod() {
    io.grpc.MethodDescriptor<com.google.ads.admob.v1.AdMobApiProto.ListPublisherAccountsRequest, com.google.ads.admob.v1.AdMobApiProto.ListPublisherAccountsResponse> getListPublisherAccountsMethod;
    if ((getListPublisherAccountsMethod = AdMobApiGrpc.getListPublisherAccountsMethod) == null) {
      synchronized (AdMobApiGrpc.class) {
        if ((getListPublisherAccountsMethod = AdMobApiGrpc.getListPublisherAccountsMethod) == null) {
          AdMobApiGrpc.getListPublisherAccountsMethod = getListPublisherAccountsMethod =
              io.grpc.MethodDescriptor.<com.google.ads.admob.v1.AdMobApiProto.ListPublisherAccountsRequest, com.google.ads.admob.v1.AdMobApiProto.ListPublisherAccountsResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "ListPublisherAccounts"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.ads.admob.v1.AdMobApiProto.ListPublisherAccountsRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.ads.admob.v1.AdMobApiProto.ListPublisherAccountsResponse.getDefaultInstance()))
              .setSchemaDescriptor(new AdMobApiMethodDescriptorSupplier("ListPublisherAccounts"))
              .build();
        }
      }
    }
    return getListPublisherAccountsMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.ads.admob.v1.AdMobApiProto.GenerateNetworkReportRequest,
      com.google.ads.admob.v1.AdMobApiProto.GenerateNetworkReportResponse> getGenerateNetworkReportMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "GenerateNetworkReport",
      requestType = com.google.ads.admob.v1.AdMobApiProto.GenerateNetworkReportRequest.class,
      responseType = com.google.ads.admob.v1.AdMobApiProto.GenerateNetworkReportResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.SERVER_STREAMING)
  public static io.grpc.MethodDescriptor<com.google.ads.admob.v1.AdMobApiProto.GenerateNetworkReportRequest,
      com.google.ads.admob.v1.AdMobApiProto.GenerateNetworkReportResponse> getGenerateNetworkReportMethod() {
    io.grpc.MethodDescriptor<com.google.ads.admob.v1.AdMobApiProto.GenerateNetworkReportRequest, com.google.ads.admob.v1.AdMobApiProto.GenerateNetworkReportResponse> getGenerateNetworkReportMethod;
    if ((getGenerateNetworkReportMethod = AdMobApiGrpc.getGenerateNetworkReportMethod) == null) {
      synchronized (AdMobApiGrpc.class) {
        if ((getGenerateNetworkReportMethod = AdMobApiGrpc.getGenerateNetworkReportMethod) == null) {
          AdMobApiGrpc.getGenerateNetworkReportMethod = getGenerateNetworkReportMethod =
              io.grpc.MethodDescriptor.<com.google.ads.admob.v1.AdMobApiProto.GenerateNetworkReportRequest, com.google.ads.admob.v1.AdMobApiProto.GenerateNetworkReportResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.SERVER_STREAMING)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "GenerateNetworkReport"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.ads.admob.v1.AdMobApiProto.GenerateNetworkReportRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.ads.admob.v1.AdMobApiProto.GenerateNetworkReportResponse.getDefaultInstance()))
              .setSchemaDescriptor(new AdMobApiMethodDescriptorSupplier("GenerateNetworkReport"))
              .build();
        }
      }
    }
    return getGenerateNetworkReportMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.ads.admob.v1.AdMobApiProto.GenerateMediationReportRequest,
      com.google.ads.admob.v1.AdMobApiProto.GenerateMediationReportResponse> getGenerateMediationReportMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "GenerateMediationReport",
      requestType = com.google.ads.admob.v1.AdMobApiProto.GenerateMediationReportRequest.class,
      responseType = com.google.ads.admob.v1.AdMobApiProto.GenerateMediationReportResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.SERVER_STREAMING)
  public static io.grpc.MethodDescriptor<com.google.ads.admob.v1.AdMobApiProto.GenerateMediationReportRequest,
      com.google.ads.admob.v1.AdMobApiProto.GenerateMediationReportResponse> getGenerateMediationReportMethod() {
    io.grpc.MethodDescriptor<com.google.ads.admob.v1.AdMobApiProto.GenerateMediationReportRequest, com.google.ads.admob.v1.AdMobApiProto.GenerateMediationReportResponse> getGenerateMediationReportMethod;
    if ((getGenerateMediationReportMethod = AdMobApiGrpc.getGenerateMediationReportMethod) == null) {
      synchronized (AdMobApiGrpc.class) {
        if ((getGenerateMediationReportMethod = AdMobApiGrpc.getGenerateMediationReportMethod) == null) {
          AdMobApiGrpc.getGenerateMediationReportMethod = getGenerateMediationReportMethod =
              io.grpc.MethodDescriptor.<com.google.ads.admob.v1.AdMobApiProto.GenerateMediationReportRequest, com.google.ads.admob.v1.AdMobApiProto.GenerateMediationReportResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.SERVER_STREAMING)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "GenerateMediationReport"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.ads.admob.v1.AdMobApiProto.GenerateMediationReportRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.ads.admob.v1.AdMobApiProto.GenerateMediationReportResponse.getDefaultInstance()))
              .setSchemaDescriptor(new AdMobApiMethodDescriptorSupplier("GenerateMediationReport"))
              .build();
        }
      }
    }
    return getGenerateMediationReportMethod;
  }

  /**
   * Creates a new async stub that supports all call types for the service
   */
  public static AdMobApiStub newStub(io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<AdMobApiStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<AdMobApiStub>() {
        @java.lang.Override
        public AdMobApiStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new AdMobApiStub(channel, callOptions);
        }
      };
    return AdMobApiStub.newStub(factory, channel);
  }

  /**
   * Creates a new blocking-style stub that supports unary and streaming output calls on the service
   */
  public static AdMobApiBlockingStub newBlockingStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<AdMobApiBlockingStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<AdMobApiBlockingStub>() {
        @java.lang.Override
        public AdMobApiBlockingStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new AdMobApiBlockingStub(channel, callOptions);
        }
      };
    return AdMobApiBlockingStub.newStub(factory, channel);
  }

  /**
   * Creates a new ListenableFuture-style stub that supports unary calls on the service
   */
  public static AdMobApiFutureStub newFutureStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<AdMobApiFutureStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<AdMobApiFutureStub>() {
        @java.lang.Override
        public AdMobApiFutureStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new AdMobApiFutureStub(channel, callOptions);
        }
      };
    return AdMobApiFutureStub.newStub(factory, channel);
  }

  /**
   * <pre>
   * The AdMob API allows AdMob publishers programmatically get information about
   * their AdMob account.
   * </pre>
   */
  public static abstract class AdMobApiImplBase implements io.grpc.BindableService {

    /**
     * <pre>
     * Gets information about the specified AdMob publisher account.
     * </pre>
     */
    public void getPublisherAccount(com.google.ads.admob.v1.AdMobApiProto.GetPublisherAccountRequest request,
        io.grpc.stub.StreamObserver<com.google.ads.admob.v1.AdMobResourcesProto.PublisherAccount> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getGetPublisherAccountMethod(), responseObserver);
    }

    /**
     * <pre>
     * Lists the AdMob publisher account accessible with the client credential.
     * Currently, all credentials have access to at most one AdMob account.
     * </pre>
     */
    public void listPublisherAccounts(com.google.ads.admob.v1.AdMobApiProto.ListPublisherAccountsRequest request,
        io.grpc.stub.StreamObserver<com.google.ads.admob.v1.AdMobApiProto.ListPublisherAccountsResponse> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getListPublisherAccountsMethod(), responseObserver);
    }

    /**
     * <pre>
     * Generates an AdMob Network report based on the provided report
     * specification.
     * </pre>
     */
    public void generateNetworkReport(com.google.ads.admob.v1.AdMobApiProto.GenerateNetworkReportRequest request,
        io.grpc.stub.StreamObserver<com.google.ads.admob.v1.AdMobApiProto.GenerateNetworkReportResponse> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getGenerateNetworkReportMethod(), responseObserver);
    }

    /**
     * <pre>
     * Generates an AdMob Mediation report based on the provided report
     * specification.
     * </pre>
     */
    public void generateMediationReport(com.google.ads.admob.v1.AdMobApiProto.GenerateMediationReportRequest request,
        io.grpc.stub.StreamObserver<com.google.ads.admob.v1.AdMobApiProto.GenerateMediationReportResponse> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getGenerateMediationReportMethod(), responseObserver);
    }

    @java.lang.Override public final io.grpc.ServerServiceDefinition bindService() {
      return io.grpc.ServerServiceDefinition.builder(getServiceDescriptor())
          .addMethod(
            getGetPublisherAccountMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.ads.admob.v1.AdMobApiProto.GetPublisherAccountRequest,
                com.google.ads.admob.v1.AdMobResourcesProto.PublisherAccount>(
                  this, METHODID_GET_PUBLISHER_ACCOUNT)))
          .addMethod(
            getListPublisherAccountsMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.ads.admob.v1.AdMobApiProto.ListPublisherAccountsRequest,
                com.google.ads.admob.v1.AdMobApiProto.ListPublisherAccountsResponse>(
                  this, METHODID_LIST_PUBLISHER_ACCOUNTS)))
          .addMethod(
            getGenerateNetworkReportMethod(),
            io.grpc.stub.ServerCalls.asyncServerStreamingCall(
              new MethodHandlers<
                com.google.ads.admob.v1.AdMobApiProto.GenerateNetworkReportRequest,
                com.google.ads.admob.v1.AdMobApiProto.GenerateNetworkReportResponse>(
                  this, METHODID_GENERATE_NETWORK_REPORT)))
          .addMethod(
            getGenerateMediationReportMethod(),
            io.grpc.stub.ServerCalls.asyncServerStreamingCall(
              new MethodHandlers<
                com.google.ads.admob.v1.AdMobApiProto.GenerateMediationReportRequest,
                com.google.ads.admob.v1.AdMobApiProto.GenerateMediationReportResponse>(
                  this, METHODID_GENERATE_MEDIATION_REPORT)))
          .build();
    }
  }

  /**
   * <pre>
   * The AdMob API allows AdMob publishers programmatically get information about
   * their AdMob account.
   * </pre>
   */
  public static final class AdMobApiStub extends io.grpc.stub.AbstractAsyncStub<AdMobApiStub> {
    private AdMobApiStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected AdMobApiStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new AdMobApiStub(channel, callOptions);
    }

    /**
     * <pre>
     * Gets information about the specified AdMob publisher account.
     * </pre>
     */
    public void getPublisherAccount(com.google.ads.admob.v1.AdMobApiProto.GetPublisherAccountRequest request,
        io.grpc.stub.StreamObserver<com.google.ads.admob.v1.AdMobResourcesProto.PublisherAccount> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getGetPublisherAccountMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Lists the AdMob publisher account accessible with the client credential.
     * Currently, all credentials have access to at most one AdMob account.
     * </pre>
     */
    public void listPublisherAccounts(com.google.ads.admob.v1.AdMobApiProto.ListPublisherAccountsRequest request,
        io.grpc.stub.StreamObserver<com.google.ads.admob.v1.AdMobApiProto.ListPublisherAccountsResponse> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getListPublisherAccountsMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Generates an AdMob Network report based on the provided report
     * specification.
     * </pre>
     */
    public void generateNetworkReport(com.google.ads.admob.v1.AdMobApiProto.GenerateNetworkReportRequest request,
        io.grpc.stub.StreamObserver<com.google.ads.admob.v1.AdMobApiProto.GenerateNetworkReportResponse> responseObserver) {
      io.grpc.stub.ClientCalls.asyncServerStreamingCall(
          getChannel().newCall(getGenerateNetworkReportMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Generates an AdMob Mediation report based on the provided report
     * specification.
     * </pre>
     */
    public void generateMediationReport(com.google.ads.admob.v1.AdMobApiProto.GenerateMediationReportRequest request,
        io.grpc.stub.StreamObserver<com.google.ads.admob.v1.AdMobApiProto.GenerateMediationReportResponse> responseObserver) {
      io.grpc.stub.ClientCalls.asyncServerStreamingCall(
          getChannel().newCall(getGenerateMediationReportMethod(), getCallOptions()), request, responseObserver);
    }
  }

  /**
   * <pre>
   * The AdMob API allows AdMob publishers programmatically get information about
   * their AdMob account.
   * </pre>
   */
  public static final class AdMobApiBlockingStub extends io.grpc.stub.AbstractBlockingStub<AdMobApiBlockingStub> {
    private AdMobApiBlockingStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected AdMobApiBlockingStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new AdMobApiBlockingStub(channel, callOptions);
    }

    /**
     * <pre>
     * Gets information about the specified AdMob publisher account.
     * </pre>
     */
    public com.google.ads.admob.v1.AdMobResourcesProto.PublisherAccount getPublisherAccount(com.google.ads.admob.v1.AdMobApiProto.GetPublisherAccountRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getGetPublisherAccountMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Lists the AdMob publisher account accessible with the client credential.
     * Currently, all credentials have access to at most one AdMob account.
     * </pre>
     */
    public com.google.ads.admob.v1.AdMobApiProto.ListPublisherAccountsResponse listPublisherAccounts(com.google.ads.admob.v1.AdMobApiProto.ListPublisherAccountsRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getListPublisherAccountsMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Generates an AdMob Network report based on the provided report
     * specification.
     * </pre>
     */
    public java.util.Iterator<com.google.ads.admob.v1.AdMobApiProto.GenerateNetworkReportResponse> generateNetworkReport(
        com.google.ads.admob.v1.AdMobApiProto.GenerateNetworkReportRequest request) {
      return io.grpc.stub.ClientCalls.blockingServerStreamingCall(
          getChannel(), getGenerateNetworkReportMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Generates an AdMob Mediation report based on the provided report
     * specification.
     * </pre>
     */
    public java.util.Iterator<com.google.ads.admob.v1.AdMobApiProto.GenerateMediationReportResponse> generateMediationReport(
        com.google.ads.admob.v1.AdMobApiProto.GenerateMediationReportRequest request) {
      return io.grpc.stub.ClientCalls.blockingServerStreamingCall(
          getChannel(), getGenerateMediationReportMethod(), getCallOptions(), request);
    }
  }

  /**
   * <pre>
   * The AdMob API allows AdMob publishers programmatically get information about
   * their AdMob account.
   * </pre>
   */
  public static final class AdMobApiFutureStub extends io.grpc.stub.AbstractFutureStub<AdMobApiFutureStub> {
    private AdMobApiFutureStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected AdMobApiFutureStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new AdMobApiFutureStub(channel, callOptions);
    }

    /**
     * <pre>
     * Gets information about the specified AdMob publisher account.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.ads.admob.v1.AdMobResourcesProto.PublisherAccount> getPublisherAccount(
        com.google.ads.admob.v1.AdMobApiProto.GetPublisherAccountRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getGetPublisherAccountMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Lists the AdMob publisher account accessible with the client credential.
     * Currently, all credentials have access to at most one AdMob account.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.ads.admob.v1.AdMobApiProto.ListPublisherAccountsResponse> listPublisherAccounts(
        com.google.ads.admob.v1.AdMobApiProto.ListPublisherAccountsRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getListPublisherAccountsMethod(), getCallOptions()), request);
    }
  }

  private static final int METHODID_GET_PUBLISHER_ACCOUNT = 0;
  private static final int METHODID_LIST_PUBLISHER_ACCOUNTS = 1;
  private static final int METHODID_GENERATE_NETWORK_REPORT = 2;
  private static final int METHODID_GENERATE_MEDIATION_REPORT = 3;

  private static final class MethodHandlers<Req, Resp> implements
      io.grpc.stub.ServerCalls.UnaryMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ServerStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ClientStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.BidiStreamingMethod<Req, Resp> {
    private final AdMobApiImplBase serviceImpl;
    private final int methodId;

    MethodHandlers(AdMobApiImplBase serviceImpl, int methodId) {
      this.serviceImpl = serviceImpl;
      this.methodId = methodId;
    }

    @java.lang.Override
    @java.lang.SuppressWarnings("unchecked")
    public void invoke(Req request, io.grpc.stub.StreamObserver<Resp> responseObserver) {
      switch (methodId) {
        case METHODID_GET_PUBLISHER_ACCOUNT:
          serviceImpl.getPublisherAccount((com.google.ads.admob.v1.AdMobApiProto.GetPublisherAccountRequest) request,
              (io.grpc.stub.StreamObserver<com.google.ads.admob.v1.AdMobResourcesProto.PublisherAccount>) responseObserver);
          break;
        case METHODID_LIST_PUBLISHER_ACCOUNTS:
          serviceImpl.listPublisherAccounts((com.google.ads.admob.v1.AdMobApiProto.ListPublisherAccountsRequest) request,
              (io.grpc.stub.StreamObserver<com.google.ads.admob.v1.AdMobApiProto.ListPublisherAccountsResponse>) responseObserver);
          break;
        case METHODID_GENERATE_NETWORK_REPORT:
          serviceImpl.generateNetworkReport((com.google.ads.admob.v1.AdMobApiProto.GenerateNetworkReportRequest) request,
              (io.grpc.stub.StreamObserver<com.google.ads.admob.v1.AdMobApiProto.GenerateNetworkReportResponse>) responseObserver);
          break;
        case METHODID_GENERATE_MEDIATION_REPORT:
          serviceImpl.generateMediationReport((com.google.ads.admob.v1.AdMobApiProto.GenerateMediationReportRequest) request,
              (io.grpc.stub.StreamObserver<com.google.ads.admob.v1.AdMobApiProto.GenerateMediationReportResponse>) responseObserver);
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

  private static abstract class AdMobApiBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoFileDescriptorSupplier, io.grpc.protobuf.ProtoServiceDescriptorSupplier {
    AdMobApiBaseDescriptorSupplier() {}

    @java.lang.Override
    public com.google.protobuf.Descriptors.FileDescriptor getFileDescriptor() {
      return com.google.ads.admob.v1.AdMobApiProto.getDescriptor();
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.ServiceDescriptor getServiceDescriptor() {
      return getFileDescriptor().findServiceByName("AdMobApi");
    }
  }

  private static final class AdMobApiFileDescriptorSupplier
      extends AdMobApiBaseDescriptorSupplier {
    AdMobApiFileDescriptorSupplier() {}
  }

  private static final class AdMobApiMethodDescriptorSupplier
      extends AdMobApiBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoMethodDescriptorSupplier {
    private final String methodName;

    AdMobApiMethodDescriptorSupplier(String methodName) {
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
      synchronized (AdMobApiGrpc.class) {
        result = serviceDescriptor;
        if (result == null) {
          serviceDescriptor = result = io.grpc.ServiceDescriptor.newBuilder(SERVICE_NAME)
              .setSchemaDescriptor(new AdMobApiFileDescriptorSupplier())
              .addMethod(getGetPublisherAccountMethod())
              .addMethod(getListPublisherAccountsMethod())
              .addMethod(getGenerateNetworkReportMethod())
              .addMethod(getGenerateMediationReportMethod())
              .build();
        }
      }
    }
    return result;
  }
}
