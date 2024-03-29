package com.google.cloud.retail.v2alpha;

import static io.grpc.MethodDescriptor.generateFullMethodName;

/**
 * <pre>
 * Service for managing catalog configuration.
 * </pre>
 */
@javax.annotation.Generated(
    value = "by gRPC proto compiler",
    comments = "Source: google/cloud/retail/v2alpha/catalog_service.proto")
@io.grpc.stub.annotations.GrpcGenerated
public final class CatalogServiceGrpc {

  private CatalogServiceGrpc() {}

  public static final String SERVICE_NAME = "google.cloud.retail.v2alpha.CatalogService";

  // Static method descriptors that strictly reflect the proto.
  private static volatile io.grpc.MethodDescriptor<com.google.cloud.retail.v2alpha.ListCatalogsRequest,
      com.google.cloud.retail.v2alpha.ListCatalogsResponse> getListCatalogsMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "ListCatalogs",
      requestType = com.google.cloud.retail.v2alpha.ListCatalogsRequest.class,
      responseType = com.google.cloud.retail.v2alpha.ListCatalogsResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.cloud.retail.v2alpha.ListCatalogsRequest,
      com.google.cloud.retail.v2alpha.ListCatalogsResponse> getListCatalogsMethod() {
    io.grpc.MethodDescriptor<com.google.cloud.retail.v2alpha.ListCatalogsRequest, com.google.cloud.retail.v2alpha.ListCatalogsResponse> getListCatalogsMethod;
    if ((getListCatalogsMethod = CatalogServiceGrpc.getListCatalogsMethod) == null) {
      synchronized (CatalogServiceGrpc.class) {
        if ((getListCatalogsMethod = CatalogServiceGrpc.getListCatalogsMethod) == null) {
          CatalogServiceGrpc.getListCatalogsMethod = getListCatalogsMethod =
              io.grpc.MethodDescriptor.<com.google.cloud.retail.v2alpha.ListCatalogsRequest, com.google.cloud.retail.v2alpha.ListCatalogsResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "ListCatalogs"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.retail.v2alpha.ListCatalogsRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.retail.v2alpha.ListCatalogsResponse.getDefaultInstance()))
              .setSchemaDescriptor(new CatalogServiceMethodDescriptorSupplier("ListCatalogs"))
              .build();
        }
      }
    }
    return getListCatalogsMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.cloud.retail.v2alpha.UpdateCatalogRequest,
      com.google.cloud.retail.v2alpha.Catalog> getUpdateCatalogMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "UpdateCatalog",
      requestType = com.google.cloud.retail.v2alpha.UpdateCatalogRequest.class,
      responseType = com.google.cloud.retail.v2alpha.Catalog.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.cloud.retail.v2alpha.UpdateCatalogRequest,
      com.google.cloud.retail.v2alpha.Catalog> getUpdateCatalogMethod() {
    io.grpc.MethodDescriptor<com.google.cloud.retail.v2alpha.UpdateCatalogRequest, com.google.cloud.retail.v2alpha.Catalog> getUpdateCatalogMethod;
    if ((getUpdateCatalogMethod = CatalogServiceGrpc.getUpdateCatalogMethod) == null) {
      synchronized (CatalogServiceGrpc.class) {
        if ((getUpdateCatalogMethod = CatalogServiceGrpc.getUpdateCatalogMethod) == null) {
          CatalogServiceGrpc.getUpdateCatalogMethod = getUpdateCatalogMethod =
              io.grpc.MethodDescriptor.<com.google.cloud.retail.v2alpha.UpdateCatalogRequest, com.google.cloud.retail.v2alpha.Catalog>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "UpdateCatalog"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.retail.v2alpha.UpdateCatalogRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.retail.v2alpha.Catalog.getDefaultInstance()))
              .setSchemaDescriptor(new CatalogServiceMethodDescriptorSupplier("UpdateCatalog"))
              .build();
        }
      }
    }
    return getUpdateCatalogMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.cloud.retail.v2alpha.SetDefaultBranchRequest,
      com.google.protobuf.Empty> getSetDefaultBranchMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "SetDefaultBranch",
      requestType = com.google.cloud.retail.v2alpha.SetDefaultBranchRequest.class,
      responseType = com.google.protobuf.Empty.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.cloud.retail.v2alpha.SetDefaultBranchRequest,
      com.google.protobuf.Empty> getSetDefaultBranchMethod() {
    io.grpc.MethodDescriptor<com.google.cloud.retail.v2alpha.SetDefaultBranchRequest, com.google.protobuf.Empty> getSetDefaultBranchMethod;
    if ((getSetDefaultBranchMethod = CatalogServiceGrpc.getSetDefaultBranchMethod) == null) {
      synchronized (CatalogServiceGrpc.class) {
        if ((getSetDefaultBranchMethod = CatalogServiceGrpc.getSetDefaultBranchMethod) == null) {
          CatalogServiceGrpc.getSetDefaultBranchMethod = getSetDefaultBranchMethod =
              io.grpc.MethodDescriptor.<com.google.cloud.retail.v2alpha.SetDefaultBranchRequest, com.google.protobuf.Empty>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "SetDefaultBranch"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.retail.v2alpha.SetDefaultBranchRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.protobuf.Empty.getDefaultInstance()))
              .setSchemaDescriptor(new CatalogServiceMethodDescriptorSupplier("SetDefaultBranch"))
              .build();
        }
      }
    }
    return getSetDefaultBranchMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.cloud.retail.v2alpha.GetDefaultBranchRequest,
      com.google.cloud.retail.v2alpha.GetDefaultBranchResponse> getGetDefaultBranchMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "GetDefaultBranch",
      requestType = com.google.cloud.retail.v2alpha.GetDefaultBranchRequest.class,
      responseType = com.google.cloud.retail.v2alpha.GetDefaultBranchResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.cloud.retail.v2alpha.GetDefaultBranchRequest,
      com.google.cloud.retail.v2alpha.GetDefaultBranchResponse> getGetDefaultBranchMethod() {
    io.grpc.MethodDescriptor<com.google.cloud.retail.v2alpha.GetDefaultBranchRequest, com.google.cloud.retail.v2alpha.GetDefaultBranchResponse> getGetDefaultBranchMethod;
    if ((getGetDefaultBranchMethod = CatalogServiceGrpc.getGetDefaultBranchMethod) == null) {
      synchronized (CatalogServiceGrpc.class) {
        if ((getGetDefaultBranchMethod = CatalogServiceGrpc.getGetDefaultBranchMethod) == null) {
          CatalogServiceGrpc.getGetDefaultBranchMethod = getGetDefaultBranchMethod =
              io.grpc.MethodDescriptor.<com.google.cloud.retail.v2alpha.GetDefaultBranchRequest, com.google.cloud.retail.v2alpha.GetDefaultBranchResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "GetDefaultBranch"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.retail.v2alpha.GetDefaultBranchRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.retail.v2alpha.GetDefaultBranchResponse.getDefaultInstance()))
              .setSchemaDescriptor(new CatalogServiceMethodDescriptorSupplier("GetDefaultBranch"))
              .build();
        }
      }
    }
    return getGetDefaultBranchMethod;
  }

  /**
   * Creates a new async stub that supports all call types for the service
   */
  public static CatalogServiceStub newStub(io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<CatalogServiceStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<CatalogServiceStub>() {
        @java.lang.Override
        public CatalogServiceStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new CatalogServiceStub(channel, callOptions);
        }
      };
    return CatalogServiceStub.newStub(factory, channel);
  }

  /**
   * Creates a new blocking-style stub that supports unary and streaming output calls on the service
   */
  public static CatalogServiceBlockingStub newBlockingStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<CatalogServiceBlockingStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<CatalogServiceBlockingStub>() {
        @java.lang.Override
        public CatalogServiceBlockingStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new CatalogServiceBlockingStub(channel, callOptions);
        }
      };
    return CatalogServiceBlockingStub.newStub(factory, channel);
  }

  /**
   * Creates a new ListenableFuture-style stub that supports unary calls on the service
   */
  public static CatalogServiceFutureStub newFutureStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<CatalogServiceFutureStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<CatalogServiceFutureStub>() {
        @java.lang.Override
        public CatalogServiceFutureStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new CatalogServiceFutureStub(channel, callOptions);
        }
      };
    return CatalogServiceFutureStub.newStub(factory, channel);
  }

  /**
   * <pre>
   * Service for managing catalog configuration.
   * </pre>
   */
  public static abstract class CatalogServiceImplBase implements io.grpc.BindableService {

    /**
     * <pre>
     * Lists all the [Catalog][google.cloud.retail.v2alpha.Catalog]s associated
     * with the project.
     * </pre>
     */
    public void listCatalogs(com.google.cloud.retail.v2alpha.ListCatalogsRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.retail.v2alpha.ListCatalogsResponse> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getListCatalogsMethod(), responseObserver);
    }

    /**
     * <pre>
     * Updates the [Catalog][google.cloud.retail.v2alpha.Catalog]s.
     * </pre>
     */
    public void updateCatalog(com.google.cloud.retail.v2alpha.UpdateCatalogRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.retail.v2alpha.Catalog> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getUpdateCatalogMethod(), responseObserver);
    }

    /**
     * <pre>
     * Set a specified branch id as default branch. API methods such as
     * [SearchService.Search][google.cloud.retail.v2alpha.SearchService.Search],
     * [ProductService.GetProduct][google.cloud.retail.v2alpha.ProductService.GetProduct],
     * [ProductService.ListProducts][google.cloud.retail.v2alpha.ProductService.ListProducts]
     * will treat requests using "default_branch" to the actual branch id set as
     * default.
     * For example, if `projects/&#42;&#47;locations/&#42;&#47;catalogs/&#42;&#47;branches/1` is set as
     * default, setting
     * [SearchRequest.branch][google.cloud.retail.v2alpha.SearchRequest.branch] to
     * `projects/&#42;&#47;locations/&#42;&#47;catalogs/&#42;&#47;branches/default_branch` is equivalent
     * to setting
     * [SearchRequest.branch][google.cloud.retail.v2alpha.SearchRequest.branch] to
     * `projects/&#42;&#47;locations/&#42;&#47;catalogs/&#42;&#47;branches/1`.
     * Using multiple branches can be useful when developers would like
     * to have a staging branch to test and verify for future usage. When it
     * becomes ready, developers switch on the staging branch using this API while
     * keeping using `projects/&#42;&#47;locations/&#42;&#47;catalogs/&#42;&#47;branches/default_branch`
     * as [SearchRequest.branch][google.cloud.retail.v2alpha.SearchRequest.branch]
     * to route the traffic to this staging branch.
     * CAUTION: If you have live predict/search traffic, switching the default
     * branch could potentially cause outages if the ID space of the new branch is
     * very different from the old one.
     * More specifically:
     * * PredictionService will only return product IDs from branch {newBranch}.
     * * SearchService will only return product IDs from branch {newBranch}
     *   (if branch is not explicitly set).
     * * UserEventService will only join events with products from branch
     *   {newBranch}.
     * This feature is only available for users who have Retail Search enabled.
     * Please submit a form [here](https://cloud.google.com/contact) to contact
     * cloud sales if you are interested in using Retail Search.
     * </pre>
     */
    public void setDefaultBranch(com.google.cloud.retail.v2alpha.SetDefaultBranchRequest request,
        io.grpc.stub.StreamObserver<com.google.protobuf.Empty> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getSetDefaultBranchMethod(), responseObserver);
    }

    /**
     * <pre>
     * Get which branch is currently default branch set by
     * [CatalogService.SetDefaultBranch][google.cloud.retail.v2alpha.CatalogService.SetDefaultBranch]
     * method under a specified parent catalog.
     * This feature is only available for users who have Retail Search enabled.
     * Please submit a form [here](https://cloud.google.com/contact) to contact
     * cloud sales if you are interested in using Retail Search.
     * </pre>
     */
    public void getDefaultBranch(com.google.cloud.retail.v2alpha.GetDefaultBranchRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.retail.v2alpha.GetDefaultBranchResponse> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getGetDefaultBranchMethod(), responseObserver);
    }

    @java.lang.Override public final io.grpc.ServerServiceDefinition bindService() {
      return io.grpc.ServerServiceDefinition.builder(getServiceDescriptor())
          .addMethod(
            getListCatalogsMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.cloud.retail.v2alpha.ListCatalogsRequest,
                com.google.cloud.retail.v2alpha.ListCatalogsResponse>(
                  this, METHODID_LIST_CATALOGS)))
          .addMethod(
            getUpdateCatalogMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.cloud.retail.v2alpha.UpdateCatalogRequest,
                com.google.cloud.retail.v2alpha.Catalog>(
                  this, METHODID_UPDATE_CATALOG)))
          .addMethod(
            getSetDefaultBranchMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.cloud.retail.v2alpha.SetDefaultBranchRequest,
                com.google.protobuf.Empty>(
                  this, METHODID_SET_DEFAULT_BRANCH)))
          .addMethod(
            getGetDefaultBranchMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.cloud.retail.v2alpha.GetDefaultBranchRequest,
                com.google.cloud.retail.v2alpha.GetDefaultBranchResponse>(
                  this, METHODID_GET_DEFAULT_BRANCH)))
          .build();
    }
  }

  /**
   * <pre>
   * Service for managing catalog configuration.
   * </pre>
   */
  public static final class CatalogServiceStub extends io.grpc.stub.AbstractAsyncStub<CatalogServiceStub> {
    private CatalogServiceStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected CatalogServiceStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new CatalogServiceStub(channel, callOptions);
    }

    /**
     * <pre>
     * Lists all the [Catalog][google.cloud.retail.v2alpha.Catalog]s associated
     * with the project.
     * </pre>
     */
    public void listCatalogs(com.google.cloud.retail.v2alpha.ListCatalogsRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.retail.v2alpha.ListCatalogsResponse> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getListCatalogsMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Updates the [Catalog][google.cloud.retail.v2alpha.Catalog]s.
     * </pre>
     */
    public void updateCatalog(com.google.cloud.retail.v2alpha.UpdateCatalogRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.retail.v2alpha.Catalog> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getUpdateCatalogMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Set a specified branch id as default branch. API methods such as
     * [SearchService.Search][google.cloud.retail.v2alpha.SearchService.Search],
     * [ProductService.GetProduct][google.cloud.retail.v2alpha.ProductService.GetProduct],
     * [ProductService.ListProducts][google.cloud.retail.v2alpha.ProductService.ListProducts]
     * will treat requests using "default_branch" to the actual branch id set as
     * default.
     * For example, if `projects/&#42;&#47;locations/&#42;&#47;catalogs/&#42;&#47;branches/1` is set as
     * default, setting
     * [SearchRequest.branch][google.cloud.retail.v2alpha.SearchRequest.branch] to
     * `projects/&#42;&#47;locations/&#42;&#47;catalogs/&#42;&#47;branches/default_branch` is equivalent
     * to setting
     * [SearchRequest.branch][google.cloud.retail.v2alpha.SearchRequest.branch] to
     * `projects/&#42;&#47;locations/&#42;&#47;catalogs/&#42;&#47;branches/1`.
     * Using multiple branches can be useful when developers would like
     * to have a staging branch to test and verify for future usage. When it
     * becomes ready, developers switch on the staging branch using this API while
     * keeping using `projects/&#42;&#47;locations/&#42;&#47;catalogs/&#42;&#47;branches/default_branch`
     * as [SearchRequest.branch][google.cloud.retail.v2alpha.SearchRequest.branch]
     * to route the traffic to this staging branch.
     * CAUTION: If you have live predict/search traffic, switching the default
     * branch could potentially cause outages if the ID space of the new branch is
     * very different from the old one.
     * More specifically:
     * * PredictionService will only return product IDs from branch {newBranch}.
     * * SearchService will only return product IDs from branch {newBranch}
     *   (if branch is not explicitly set).
     * * UserEventService will only join events with products from branch
     *   {newBranch}.
     * This feature is only available for users who have Retail Search enabled.
     * Please submit a form [here](https://cloud.google.com/contact) to contact
     * cloud sales if you are interested in using Retail Search.
     * </pre>
     */
    public void setDefaultBranch(com.google.cloud.retail.v2alpha.SetDefaultBranchRequest request,
        io.grpc.stub.StreamObserver<com.google.protobuf.Empty> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getSetDefaultBranchMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Get which branch is currently default branch set by
     * [CatalogService.SetDefaultBranch][google.cloud.retail.v2alpha.CatalogService.SetDefaultBranch]
     * method under a specified parent catalog.
     * This feature is only available for users who have Retail Search enabled.
     * Please submit a form [here](https://cloud.google.com/contact) to contact
     * cloud sales if you are interested in using Retail Search.
     * </pre>
     */
    public void getDefaultBranch(com.google.cloud.retail.v2alpha.GetDefaultBranchRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.retail.v2alpha.GetDefaultBranchResponse> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getGetDefaultBranchMethod(), getCallOptions()), request, responseObserver);
    }
  }

  /**
   * <pre>
   * Service for managing catalog configuration.
   * </pre>
   */
  public static final class CatalogServiceBlockingStub extends io.grpc.stub.AbstractBlockingStub<CatalogServiceBlockingStub> {
    private CatalogServiceBlockingStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected CatalogServiceBlockingStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new CatalogServiceBlockingStub(channel, callOptions);
    }

    /**
     * <pre>
     * Lists all the [Catalog][google.cloud.retail.v2alpha.Catalog]s associated
     * with the project.
     * </pre>
     */
    public com.google.cloud.retail.v2alpha.ListCatalogsResponse listCatalogs(com.google.cloud.retail.v2alpha.ListCatalogsRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getListCatalogsMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Updates the [Catalog][google.cloud.retail.v2alpha.Catalog]s.
     * </pre>
     */
    public com.google.cloud.retail.v2alpha.Catalog updateCatalog(com.google.cloud.retail.v2alpha.UpdateCatalogRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getUpdateCatalogMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Set a specified branch id as default branch. API methods such as
     * [SearchService.Search][google.cloud.retail.v2alpha.SearchService.Search],
     * [ProductService.GetProduct][google.cloud.retail.v2alpha.ProductService.GetProduct],
     * [ProductService.ListProducts][google.cloud.retail.v2alpha.ProductService.ListProducts]
     * will treat requests using "default_branch" to the actual branch id set as
     * default.
     * For example, if `projects/&#42;&#47;locations/&#42;&#47;catalogs/&#42;&#47;branches/1` is set as
     * default, setting
     * [SearchRequest.branch][google.cloud.retail.v2alpha.SearchRequest.branch] to
     * `projects/&#42;&#47;locations/&#42;&#47;catalogs/&#42;&#47;branches/default_branch` is equivalent
     * to setting
     * [SearchRequest.branch][google.cloud.retail.v2alpha.SearchRequest.branch] to
     * `projects/&#42;&#47;locations/&#42;&#47;catalogs/&#42;&#47;branches/1`.
     * Using multiple branches can be useful when developers would like
     * to have a staging branch to test and verify for future usage. When it
     * becomes ready, developers switch on the staging branch using this API while
     * keeping using `projects/&#42;&#47;locations/&#42;&#47;catalogs/&#42;&#47;branches/default_branch`
     * as [SearchRequest.branch][google.cloud.retail.v2alpha.SearchRequest.branch]
     * to route the traffic to this staging branch.
     * CAUTION: If you have live predict/search traffic, switching the default
     * branch could potentially cause outages if the ID space of the new branch is
     * very different from the old one.
     * More specifically:
     * * PredictionService will only return product IDs from branch {newBranch}.
     * * SearchService will only return product IDs from branch {newBranch}
     *   (if branch is not explicitly set).
     * * UserEventService will only join events with products from branch
     *   {newBranch}.
     * This feature is only available for users who have Retail Search enabled.
     * Please submit a form [here](https://cloud.google.com/contact) to contact
     * cloud sales if you are interested in using Retail Search.
     * </pre>
     */
    public com.google.protobuf.Empty setDefaultBranch(com.google.cloud.retail.v2alpha.SetDefaultBranchRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getSetDefaultBranchMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Get which branch is currently default branch set by
     * [CatalogService.SetDefaultBranch][google.cloud.retail.v2alpha.CatalogService.SetDefaultBranch]
     * method under a specified parent catalog.
     * This feature is only available for users who have Retail Search enabled.
     * Please submit a form [here](https://cloud.google.com/contact) to contact
     * cloud sales if you are interested in using Retail Search.
     * </pre>
     */
    public com.google.cloud.retail.v2alpha.GetDefaultBranchResponse getDefaultBranch(com.google.cloud.retail.v2alpha.GetDefaultBranchRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getGetDefaultBranchMethod(), getCallOptions(), request);
    }
  }

  /**
   * <pre>
   * Service for managing catalog configuration.
   * </pre>
   */
  public static final class CatalogServiceFutureStub extends io.grpc.stub.AbstractFutureStub<CatalogServiceFutureStub> {
    private CatalogServiceFutureStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected CatalogServiceFutureStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new CatalogServiceFutureStub(channel, callOptions);
    }

    /**
     * <pre>
     * Lists all the [Catalog][google.cloud.retail.v2alpha.Catalog]s associated
     * with the project.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.cloud.retail.v2alpha.ListCatalogsResponse> listCatalogs(
        com.google.cloud.retail.v2alpha.ListCatalogsRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getListCatalogsMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Updates the [Catalog][google.cloud.retail.v2alpha.Catalog]s.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.cloud.retail.v2alpha.Catalog> updateCatalog(
        com.google.cloud.retail.v2alpha.UpdateCatalogRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getUpdateCatalogMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Set a specified branch id as default branch. API methods such as
     * [SearchService.Search][google.cloud.retail.v2alpha.SearchService.Search],
     * [ProductService.GetProduct][google.cloud.retail.v2alpha.ProductService.GetProduct],
     * [ProductService.ListProducts][google.cloud.retail.v2alpha.ProductService.ListProducts]
     * will treat requests using "default_branch" to the actual branch id set as
     * default.
     * For example, if `projects/&#42;&#47;locations/&#42;&#47;catalogs/&#42;&#47;branches/1` is set as
     * default, setting
     * [SearchRequest.branch][google.cloud.retail.v2alpha.SearchRequest.branch] to
     * `projects/&#42;&#47;locations/&#42;&#47;catalogs/&#42;&#47;branches/default_branch` is equivalent
     * to setting
     * [SearchRequest.branch][google.cloud.retail.v2alpha.SearchRequest.branch] to
     * `projects/&#42;&#47;locations/&#42;&#47;catalogs/&#42;&#47;branches/1`.
     * Using multiple branches can be useful when developers would like
     * to have a staging branch to test and verify for future usage. When it
     * becomes ready, developers switch on the staging branch using this API while
     * keeping using `projects/&#42;&#47;locations/&#42;&#47;catalogs/&#42;&#47;branches/default_branch`
     * as [SearchRequest.branch][google.cloud.retail.v2alpha.SearchRequest.branch]
     * to route the traffic to this staging branch.
     * CAUTION: If you have live predict/search traffic, switching the default
     * branch could potentially cause outages if the ID space of the new branch is
     * very different from the old one.
     * More specifically:
     * * PredictionService will only return product IDs from branch {newBranch}.
     * * SearchService will only return product IDs from branch {newBranch}
     *   (if branch is not explicitly set).
     * * UserEventService will only join events with products from branch
     *   {newBranch}.
     * This feature is only available for users who have Retail Search enabled.
     * Please submit a form [here](https://cloud.google.com/contact) to contact
     * cloud sales if you are interested in using Retail Search.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.protobuf.Empty> setDefaultBranch(
        com.google.cloud.retail.v2alpha.SetDefaultBranchRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getSetDefaultBranchMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Get which branch is currently default branch set by
     * [CatalogService.SetDefaultBranch][google.cloud.retail.v2alpha.CatalogService.SetDefaultBranch]
     * method under a specified parent catalog.
     * This feature is only available for users who have Retail Search enabled.
     * Please submit a form [here](https://cloud.google.com/contact) to contact
     * cloud sales if you are interested in using Retail Search.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.cloud.retail.v2alpha.GetDefaultBranchResponse> getDefaultBranch(
        com.google.cloud.retail.v2alpha.GetDefaultBranchRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getGetDefaultBranchMethod(), getCallOptions()), request);
    }
  }

  private static final int METHODID_LIST_CATALOGS = 0;
  private static final int METHODID_UPDATE_CATALOG = 1;
  private static final int METHODID_SET_DEFAULT_BRANCH = 2;
  private static final int METHODID_GET_DEFAULT_BRANCH = 3;

  private static final class MethodHandlers<Req, Resp> implements
      io.grpc.stub.ServerCalls.UnaryMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ServerStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ClientStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.BidiStreamingMethod<Req, Resp> {
    private final CatalogServiceImplBase serviceImpl;
    private final int methodId;

    MethodHandlers(CatalogServiceImplBase serviceImpl, int methodId) {
      this.serviceImpl = serviceImpl;
      this.methodId = methodId;
    }

    @java.lang.Override
    @java.lang.SuppressWarnings("unchecked")
    public void invoke(Req request, io.grpc.stub.StreamObserver<Resp> responseObserver) {
      switch (methodId) {
        case METHODID_LIST_CATALOGS:
          serviceImpl.listCatalogs((com.google.cloud.retail.v2alpha.ListCatalogsRequest) request,
              (io.grpc.stub.StreamObserver<com.google.cloud.retail.v2alpha.ListCatalogsResponse>) responseObserver);
          break;
        case METHODID_UPDATE_CATALOG:
          serviceImpl.updateCatalog((com.google.cloud.retail.v2alpha.UpdateCatalogRequest) request,
              (io.grpc.stub.StreamObserver<com.google.cloud.retail.v2alpha.Catalog>) responseObserver);
          break;
        case METHODID_SET_DEFAULT_BRANCH:
          serviceImpl.setDefaultBranch((com.google.cloud.retail.v2alpha.SetDefaultBranchRequest) request,
              (io.grpc.stub.StreamObserver<com.google.protobuf.Empty>) responseObserver);
          break;
        case METHODID_GET_DEFAULT_BRANCH:
          serviceImpl.getDefaultBranch((com.google.cloud.retail.v2alpha.GetDefaultBranchRequest) request,
              (io.grpc.stub.StreamObserver<com.google.cloud.retail.v2alpha.GetDefaultBranchResponse>) responseObserver);
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

  private static abstract class CatalogServiceBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoFileDescriptorSupplier, io.grpc.protobuf.ProtoServiceDescriptorSupplier {
    CatalogServiceBaseDescriptorSupplier() {}

    @java.lang.Override
    public com.google.protobuf.Descriptors.FileDescriptor getFileDescriptor() {
      return com.google.cloud.retail.v2alpha.CatalogServiceProto.getDescriptor();
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.ServiceDescriptor getServiceDescriptor() {
      return getFileDescriptor().findServiceByName("CatalogService");
    }
  }

  private static final class CatalogServiceFileDescriptorSupplier
      extends CatalogServiceBaseDescriptorSupplier {
    CatalogServiceFileDescriptorSupplier() {}
  }

  private static final class CatalogServiceMethodDescriptorSupplier
      extends CatalogServiceBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoMethodDescriptorSupplier {
    private final String methodName;

    CatalogServiceMethodDescriptorSupplier(String methodName) {
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
      synchronized (CatalogServiceGrpc.class) {
        result = serviceDescriptor;
        if (result == null) {
          serviceDescriptor = result = io.grpc.ServiceDescriptor.newBuilder(SERVICE_NAME)
              .setSchemaDescriptor(new CatalogServiceFileDescriptorSupplier())
              .addMethod(getListCatalogsMethod())
              .addMethod(getUpdateCatalogMethod())
              .addMethod(getSetDefaultBranchMethod())
              .addMethod(getGetDefaultBranchMethod())
              .build();
        }
      }
    }
    return result;
  }
}
