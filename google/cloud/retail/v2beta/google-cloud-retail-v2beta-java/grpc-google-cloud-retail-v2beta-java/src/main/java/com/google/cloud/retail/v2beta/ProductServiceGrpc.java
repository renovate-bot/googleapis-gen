package com.google.cloud.retail.v2beta;

import static io.grpc.MethodDescriptor.generateFullMethodName;

/**
 * <pre>
 * Service for ingesting [Product][google.cloud.retail.v2beta.Product]
 * information of the customer's website.
 * </pre>
 */
@javax.annotation.Generated(
    value = "by gRPC proto compiler",
    comments = "Source: google/cloud/retail/v2beta/product_service.proto")
@io.grpc.stub.annotations.GrpcGenerated
public final class ProductServiceGrpc {

  private ProductServiceGrpc() {}

  public static final String SERVICE_NAME = "google.cloud.retail.v2beta.ProductService";

  // Static method descriptors that strictly reflect the proto.
  private static volatile io.grpc.MethodDescriptor<com.google.cloud.retail.v2beta.CreateProductRequest,
      com.google.cloud.retail.v2beta.Product> getCreateProductMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "CreateProduct",
      requestType = com.google.cloud.retail.v2beta.CreateProductRequest.class,
      responseType = com.google.cloud.retail.v2beta.Product.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.cloud.retail.v2beta.CreateProductRequest,
      com.google.cloud.retail.v2beta.Product> getCreateProductMethod() {
    io.grpc.MethodDescriptor<com.google.cloud.retail.v2beta.CreateProductRequest, com.google.cloud.retail.v2beta.Product> getCreateProductMethod;
    if ((getCreateProductMethod = ProductServiceGrpc.getCreateProductMethod) == null) {
      synchronized (ProductServiceGrpc.class) {
        if ((getCreateProductMethod = ProductServiceGrpc.getCreateProductMethod) == null) {
          ProductServiceGrpc.getCreateProductMethod = getCreateProductMethod =
              io.grpc.MethodDescriptor.<com.google.cloud.retail.v2beta.CreateProductRequest, com.google.cloud.retail.v2beta.Product>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "CreateProduct"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.retail.v2beta.CreateProductRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.retail.v2beta.Product.getDefaultInstance()))
              .setSchemaDescriptor(new ProductServiceMethodDescriptorSupplier("CreateProduct"))
              .build();
        }
      }
    }
    return getCreateProductMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.cloud.retail.v2beta.GetProductRequest,
      com.google.cloud.retail.v2beta.Product> getGetProductMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "GetProduct",
      requestType = com.google.cloud.retail.v2beta.GetProductRequest.class,
      responseType = com.google.cloud.retail.v2beta.Product.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.cloud.retail.v2beta.GetProductRequest,
      com.google.cloud.retail.v2beta.Product> getGetProductMethod() {
    io.grpc.MethodDescriptor<com.google.cloud.retail.v2beta.GetProductRequest, com.google.cloud.retail.v2beta.Product> getGetProductMethod;
    if ((getGetProductMethod = ProductServiceGrpc.getGetProductMethod) == null) {
      synchronized (ProductServiceGrpc.class) {
        if ((getGetProductMethod = ProductServiceGrpc.getGetProductMethod) == null) {
          ProductServiceGrpc.getGetProductMethod = getGetProductMethod =
              io.grpc.MethodDescriptor.<com.google.cloud.retail.v2beta.GetProductRequest, com.google.cloud.retail.v2beta.Product>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "GetProduct"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.retail.v2beta.GetProductRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.retail.v2beta.Product.getDefaultInstance()))
              .setSchemaDescriptor(new ProductServiceMethodDescriptorSupplier("GetProduct"))
              .build();
        }
      }
    }
    return getGetProductMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.cloud.retail.v2beta.ListProductsRequest,
      com.google.cloud.retail.v2beta.ListProductsResponse> getListProductsMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "ListProducts",
      requestType = com.google.cloud.retail.v2beta.ListProductsRequest.class,
      responseType = com.google.cloud.retail.v2beta.ListProductsResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.cloud.retail.v2beta.ListProductsRequest,
      com.google.cloud.retail.v2beta.ListProductsResponse> getListProductsMethod() {
    io.grpc.MethodDescriptor<com.google.cloud.retail.v2beta.ListProductsRequest, com.google.cloud.retail.v2beta.ListProductsResponse> getListProductsMethod;
    if ((getListProductsMethod = ProductServiceGrpc.getListProductsMethod) == null) {
      synchronized (ProductServiceGrpc.class) {
        if ((getListProductsMethod = ProductServiceGrpc.getListProductsMethod) == null) {
          ProductServiceGrpc.getListProductsMethod = getListProductsMethod =
              io.grpc.MethodDescriptor.<com.google.cloud.retail.v2beta.ListProductsRequest, com.google.cloud.retail.v2beta.ListProductsResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "ListProducts"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.retail.v2beta.ListProductsRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.retail.v2beta.ListProductsResponse.getDefaultInstance()))
              .setSchemaDescriptor(new ProductServiceMethodDescriptorSupplier("ListProducts"))
              .build();
        }
      }
    }
    return getListProductsMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.cloud.retail.v2beta.UpdateProductRequest,
      com.google.cloud.retail.v2beta.Product> getUpdateProductMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "UpdateProduct",
      requestType = com.google.cloud.retail.v2beta.UpdateProductRequest.class,
      responseType = com.google.cloud.retail.v2beta.Product.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.cloud.retail.v2beta.UpdateProductRequest,
      com.google.cloud.retail.v2beta.Product> getUpdateProductMethod() {
    io.grpc.MethodDescriptor<com.google.cloud.retail.v2beta.UpdateProductRequest, com.google.cloud.retail.v2beta.Product> getUpdateProductMethod;
    if ((getUpdateProductMethod = ProductServiceGrpc.getUpdateProductMethod) == null) {
      synchronized (ProductServiceGrpc.class) {
        if ((getUpdateProductMethod = ProductServiceGrpc.getUpdateProductMethod) == null) {
          ProductServiceGrpc.getUpdateProductMethod = getUpdateProductMethod =
              io.grpc.MethodDescriptor.<com.google.cloud.retail.v2beta.UpdateProductRequest, com.google.cloud.retail.v2beta.Product>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "UpdateProduct"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.retail.v2beta.UpdateProductRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.retail.v2beta.Product.getDefaultInstance()))
              .setSchemaDescriptor(new ProductServiceMethodDescriptorSupplier("UpdateProduct"))
              .build();
        }
      }
    }
    return getUpdateProductMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.cloud.retail.v2beta.DeleteProductRequest,
      com.google.protobuf.Empty> getDeleteProductMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "DeleteProduct",
      requestType = com.google.cloud.retail.v2beta.DeleteProductRequest.class,
      responseType = com.google.protobuf.Empty.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.cloud.retail.v2beta.DeleteProductRequest,
      com.google.protobuf.Empty> getDeleteProductMethod() {
    io.grpc.MethodDescriptor<com.google.cloud.retail.v2beta.DeleteProductRequest, com.google.protobuf.Empty> getDeleteProductMethod;
    if ((getDeleteProductMethod = ProductServiceGrpc.getDeleteProductMethod) == null) {
      synchronized (ProductServiceGrpc.class) {
        if ((getDeleteProductMethod = ProductServiceGrpc.getDeleteProductMethod) == null) {
          ProductServiceGrpc.getDeleteProductMethod = getDeleteProductMethod =
              io.grpc.MethodDescriptor.<com.google.cloud.retail.v2beta.DeleteProductRequest, com.google.protobuf.Empty>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "DeleteProduct"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.retail.v2beta.DeleteProductRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.protobuf.Empty.getDefaultInstance()))
              .setSchemaDescriptor(new ProductServiceMethodDescriptorSupplier("DeleteProduct"))
              .build();
        }
      }
    }
    return getDeleteProductMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.cloud.retail.v2beta.ImportProductsRequest,
      com.google.longrunning.Operation> getImportProductsMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "ImportProducts",
      requestType = com.google.cloud.retail.v2beta.ImportProductsRequest.class,
      responseType = com.google.longrunning.Operation.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.cloud.retail.v2beta.ImportProductsRequest,
      com.google.longrunning.Operation> getImportProductsMethod() {
    io.grpc.MethodDescriptor<com.google.cloud.retail.v2beta.ImportProductsRequest, com.google.longrunning.Operation> getImportProductsMethod;
    if ((getImportProductsMethod = ProductServiceGrpc.getImportProductsMethod) == null) {
      synchronized (ProductServiceGrpc.class) {
        if ((getImportProductsMethod = ProductServiceGrpc.getImportProductsMethod) == null) {
          ProductServiceGrpc.getImportProductsMethod = getImportProductsMethod =
              io.grpc.MethodDescriptor.<com.google.cloud.retail.v2beta.ImportProductsRequest, com.google.longrunning.Operation>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "ImportProducts"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.retail.v2beta.ImportProductsRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.longrunning.Operation.getDefaultInstance()))
              .setSchemaDescriptor(new ProductServiceMethodDescriptorSupplier("ImportProducts"))
              .build();
        }
      }
    }
    return getImportProductsMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.cloud.retail.v2beta.SetInventoryRequest,
      com.google.longrunning.Operation> getSetInventoryMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "SetInventory",
      requestType = com.google.cloud.retail.v2beta.SetInventoryRequest.class,
      responseType = com.google.longrunning.Operation.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.cloud.retail.v2beta.SetInventoryRequest,
      com.google.longrunning.Operation> getSetInventoryMethod() {
    io.grpc.MethodDescriptor<com.google.cloud.retail.v2beta.SetInventoryRequest, com.google.longrunning.Operation> getSetInventoryMethod;
    if ((getSetInventoryMethod = ProductServiceGrpc.getSetInventoryMethod) == null) {
      synchronized (ProductServiceGrpc.class) {
        if ((getSetInventoryMethod = ProductServiceGrpc.getSetInventoryMethod) == null) {
          ProductServiceGrpc.getSetInventoryMethod = getSetInventoryMethod =
              io.grpc.MethodDescriptor.<com.google.cloud.retail.v2beta.SetInventoryRequest, com.google.longrunning.Operation>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "SetInventory"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.retail.v2beta.SetInventoryRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.longrunning.Operation.getDefaultInstance()))
              .setSchemaDescriptor(new ProductServiceMethodDescriptorSupplier("SetInventory"))
              .build();
        }
      }
    }
    return getSetInventoryMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.cloud.retail.v2beta.AddFulfillmentPlacesRequest,
      com.google.longrunning.Operation> getAddFulfillmentPlacesMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "AddFulfillmentPlaces",
      requestType = com.google.cloud.retail.v2beta.AddFulfillmentPlacesRequest.class,
      responseType = com.google.longrunning.Operation.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.cloud.retail.v2beta.AddFulfillmentPlacesRequest,
      com.google.longrunning.Operation> getAddFulfillmentPlacesMethod() {
    io.grpc.MethodDescriptor<com.google.cloud.retail.v2beta.AddFulfillmentPlacesRequest, com.google.longrunning.Operation> getAddFulfillmentPlacesMethod;
    if ((getAddFulfillmentPlacesMethod = ProductServiceGrpc.getAddFulfillmentPlacesMethod) == null) {
      synchronized (ProductServiceGrpc.class) {
        if ((getAddFulfillmentPlacesMethod = ProductServiceGrpc.getAddFulfillmentPlacesMethod) == null) {
          ProductServiceGrpc.getAddFulfillmentPlacesMethod = getAddFulfillmentPlacesMethod =
              io.grpc.MethodDescriptor.<com.google.cloud.retail.v2beta.AddFulfillmentPlacesRequest, com.google.longrunning.Operation>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "AddFulfillmentPlaces"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.retail.v2beta.AddFulfillmentPlacesRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.longrunning.Operation.getDefaultInstance()))
              .setSchemaDescriptor(new ProductServiceMethodDescriptorSupplier("AddFulfillmentPlaces"))
              .build();
        }
      }
    }
    return getAddFulfillmentPlacesMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.cloud.retail.v2beta.RemoveFulfillmentPlacesRequest,
      com.google.longrunning.Operation> getRemoveFulfillmentPlacesMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "RemoveFulfillmentPlaces",
      requestType = com.google.cloud.retail.v2beta.RemoveFulfillmentPlacesRequest.class,
      responseType = com.google.longrunning.Operation.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.cloud.retail.v2beta.RemoveFulfillmentPlacesRequest,
      com.google.longrunning.Operation> getRemoveFulfillmentPlacesMethod() {
    io.grpc.MethodDescriptor<com.google.cloud.retail.v2beta.RemoveFulfillmentPlacesRequest, com.google.longrunning.Operation> getRemoveFulfillmentPlacesMethod;
    if ((getRemoveFulfillmentPlacesMethod = ProductServiceGrpc.getRemoveFulfillmentPlacesMethod) == null) {
      synchronized (ProductServiceGrpc.class) {
        if ((getRemoveFulfillmentPlacesMethod = ProductServiceGrpc.getRemoveFulfillmentPlacesMethod) == null) {
          ProductServiceGrpc.getRemoveFulfillmentPlacesMethod = getRemoveFulfillmentPlacesMethod =
              io.grpc.MethodDescriptor.<com.google.cloud.retail.v2beta.RemoveFulfillmentPlacesRequest, com.google.longrunning.Operation>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "RemoveFulfillmentPlaces"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.retail.v2beta.RemoveFulfillmentPlacesRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.longrunning.Operation.getDefaultInstance()))
              .setSchemaDescriptor(new ProductServiceMethodDescriptorSupplier("RemoveFulfillmentPlaces"))
              .build();
        }
      }
    }
    return getRemoveFulfillmentPlacesMethod;
  }

  /**
   * Creates a new async stub that supports all call types for the service
   */
  public static ProductServiceStub newStub(io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<ProductServiceStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<ProductServiceStub>() {
        @java.lang.Override
        public ProductServiceStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new ProductServiceStub(channel, callOptions);
        }
      };
    return ProductServiceStub.newStub(factory, channel);
  }

  /**
   * Creates a new blocking-style stub that supports unary and streaming output calls on the service
   */
  public static ProductServiceBlockingStub newBlockingStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<ProductServiceBlockingStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<ProductServiceBlockingStub>() {
        @java.lang.Override
        public ProductServiceBlockingStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new ProductServiceBlockingStub(channel, callOptions);
        }
      };
    return ProductServiceBlockingStub.newStub(factory, channel);
  }

  /**
   * Creates a new ListenableFuture-style stub that supports unary calls on the service
   */
  public static ProductServiceFutureStub newFutureStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<ProductServiceFutureStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<ProductServiceFutureStub>() {
        @java.lang.Override
        public ProductServiceFutureStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new ProductServiceFutureStub(channel, callOptions);
        }
      };
    return ProductServiceFutureStub.newStub(factory, channel);
  }

  /**
   * <pre>
   * Service for ingesting [Product][google.cloud.retail.v2beta.Product]
   * information of the customer's website.
   * </pre>
   */
  public static abstract class ProductServiceImplBase implements io.grpc.BindableService {

    /**
     * <pre>
     * Creates a [Product][google.cloud.retail.v2beta.Product].
     * </pre>
     */
    public void createProduct(com.google.cloud.retail.v2beta.CreateProductRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.retail.v2beta.Product> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getCreateProductMethod(), responseObserver);
    }

    /**
     * <pre>
     * Gets a [Product][google.cloud.retail.v2beta.Product].
     * </pre>
     */
    public void getProduct(com.google.cloud.retail.v2beta.GetProductRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.retail.v2beta.Product> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getGetProductMethod(), responseObserver);
    }

    /**
     * <pre>
     * Gets a list of [Product][google.cloud.retail.v2beta.Product]s.
     * </pre>
     */
    public void listProducts(com.google.cloud.retail.v2beta.ListProductsRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.retail.v2beta.ListProductsResponse> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getListProductsMethod(), responseObserver);
    }

    /**
     * <pre>
     * Updates a [Product][google.cloud.retail.v2beta.Product].
     * </pre>
     */
    public void updateProduct(com.google.cloud.retail.v2beta.UpdateProductRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.retail.v2beta.Product> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getUpdateProductMethod(), responseObserver);
    }

    /**
     * <pre>
     * Deletes a [Product][google.cloud.retail.v2beta.Product].
     * </pre>
     */
    public void deleteProduct(com.google.cloud.retail.v2beta.DeleteProductRequest request,
        io.grpc.stub.StreamObserver<com.google.protobuf.Empty> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getDeleteProductMethod(), responseObserver);
    }

    /**
     * <pre>
     * Bulk import of multiple [Product][google.cloud.retail.v2beta.Product]s.
     * Request processing may be synchronous. No partial updating is supported.
     * Non-existing items are created.
     * Note that it is possible for a subset of the
     * [Product][google.cloud.retail.v2beta.Product]s to be successfully updated.
     * </pre>
     */
    public void importProducts(com.google.cloud.retail.v2beta.ImportProductsRequest request,
        io.grpc.stub.StreamObserver<com.google.longrunning.Operation> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getImportProductsMethod(), responseObserver);
    }

    /**
     * <pre>
     * Updates inventory information for a
     * [Product][google.cloud.retail.v2beta.Product] while respecting the last
     * update timestamps of each inventory field.
     * This process is asynchronous and does not require the
     * [Product][google.cloud.retail.v2beta.Product] to exist before updating
     * fulfillment information. If the request is valid, the update will be
     * enqueued and processed downstream. As a consequence, when a response is
     * returned, updates are not immediately manifested in the
     * [Product][google.cloud.retail.v2beta.Product] queried by
     * [GetProduct][google.cloud.retail.v2beta.ProductService.GetProduct] or
     * [ListProducts][google.cloud.retail.v2beta.ProductService.ListProducts].
     * When inventory is updated with
     * [CreateProduct][google.cloud.retail.v2beta.ProductService.CreateProduct]
     * and
     * [UpdateProduct][google.cloud.retail.v2beta.ProductService.UpdateProduct],
     * the specified inventory field value(s) will overwrite any existing value(s)
     * while ignoring the last update time for this field. Furthermore, the last
     * update time for the specified inventory fields will be overwritten to the
     * time of the
     * [CreateProduct][google.cloud.retail.v2beta.ProductService.CreateProduct] or
     * [UpdateProduct][google.cloud.retail.v2beta.ProductService.UpdateProduct]
     * request.
     * If no inventory fields are set in
     * [CreateProductRequest.product][google.cloud.retail.v2beta.CreateProductRequest.product],
     * then any pre-existing inventory information for this product will be used.
     * If no inventory fields are set in [UpdateProductRequest.set_mask][],
     * then any existing inventory information will be preserved.
     * Pre-existing inventory information can only be updated with
     * [SetInventory][google.cloud.retail.v2beta.ProductService.SetInventory],
     * [AddFulfillmentPlaces][google.cloud.retail.v2beta.ProductService.AddFulfillmentPlaces],
     * and
     * [RemoveFulfillmentPlaces][google.cloud.retail.v2beta.ProductService.RemoveFulfillmentPlaces].
     * This feature is only available for users who have Retail Search enabled.
     * Please submit a form [here](https://cloud.google.com/contact) to contact
     * cloud sales if you are interested in using Retail Search.
     * </pre>
     */
    public void setInventory(com.google.cloud.retail.v2beta.SetInventoryRequest request,
        io.grpc.stub.StreamObserver<com.google.longrunning.Operation> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getSetInventoryMethod(), responseObserver);
    }

    /**
     * <pre>
     * Incrementally adds place IDs to
     * [Product.fulfillment_info.place_ids][google.cloud.retail.v2beta.FulfillmentInfo.place_ids].
     * This process is asynchronous and does not require the
     * [Product][google.cloud.retail.v2beta.Product] to exist before updating
     * fulfillment information. If the request is valid, the update will be
     * enqueued and processed downstream. As a consequence, when a response is
     * returned, the added place IDs are not immediately manifested in the
     * [Product][google.cloud.retail.v2beta.Product] queried by
     * [GetProduct][google.cloud.retail.v2beta.ProductService.GetProduct] or
     * [ListProducts][google.cloud.retail.v2beta.ProductService.ListProducts].
     * This feature is only available for users who have Retail Search enabled.
     * Please submit a form [here](https://cloud.google.com/contact) to contact
     * cloud sales if you are interested in using Retail Search.
     * </pre>
     */
    public void addFulfillmentPlaces(com.google.cloud.retail.v2beta.AddFulfillmentPlacesRequest request,
        io.grpc.stub.StreamObserver<com.google.longrunning.Operation> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getAddFulfillmentPlacesMethod(), responseObserver);
    }

    /**
     * <pre>
     * Incrementally removes place IDs from a
     * [Product.fulfillment_info.place_ids][google.cloud.retail.v2beta.FulfillmentInfo.place_ids].
     * This process is asynchronous and does not require the
     * [Product][google.cloud.retail.v2beta.Product] to exist before updating
     * fulfillment information. If the request is valid, the update will be
     * enqueued and processed downstream. As a consequence, when a response is
     * returned, the removed place IDs are not immediately manifested in the
     * [Product][google.cloud.retail.v2beta.Product] queried by
     * [GetProduct][google.cloud.retail.v2beta.ProductService.GetProduct] or
     * [ListProducts][google.cloud.retail.v2beta.ProductService.ListProducts].
     * This feature is only available for users who have Retail Search enabled.
     * Please submit a form [here](https://cloud.google.com/contact) to contact
     * cloud sales if you are interested in using Retail Search.
     * </pre>
     */
    public void removeFulfillmentPlaces(com.google.cloud.retail.v2beta.RemoveFulfillmentPlacesRequest request,
        io.grpc.stub.StreamObserver<com.google.longrunning.Operation> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getRemoveFulfillmentPlacesMethod(), responseObserver);
    }

    @java.lang.Override public final io.grpc.ServerServiceDefinition bindService() {
      return io.grpc.ServerServiceDefinition.builder(getServiceDescriptor())
          .addMethod(
            getCreateProductMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.cloud.retail.v2beta.CreateProductRequest,
                com.google.cloud.retail.v2beta.Product>(
                  this, METHODID_CREATE_PRODUCT)))
          .addMethod(
            getGetProductMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.cloud.retail.v2beta.GetProductRequest,
                com.google.cloud.retail.v2beta.Product>(
                  this, METHODID_GET_PRODUCT)))
          .addMethod(
            getListProductsMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.cloud.retail.v2beta.ListProductsRequest,
                com.google.cloud.retail.v2beta.ListProductsResponse>(
                  this, METHODID_LIST_PRODUCTS)))
          .addMethod(
            getUpdateProductMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.cloud.retail.v2beta.UpdateProductRequest,
                com.google.cloud.retail.v2beta.Product>(
                  this, METHODID_UPDATE_PRODUCT)))
          .addMethod(
            getDeleteProductMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.cloud.retail.v2beta.DeleteProductRequest,
                com.google.protobuf.Empty>(
                  this, METHODID_DELETE_PRODUCT)))
          .addMethod(
            getImportProductsMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.cloud.retail.v2beta.ImportProductsRequest,
                com.google.longrunning.Operation>(
                  this, METHODID_IMPORT_PRODUCTS)))
          .addMethod(
            getSetInventoryMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.cloud.retail.v2beta.SetInventoryRequest,
                com.google.longrunning.Operation>(
                  this, METHODID_SET_INVENTORY)))
          .addMethod(
            getAddFulfillmentPlacesMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.cloud.retail.v2beta.AddFulfillmentPlacesRequest,
                com.google.longrunning.Operation>(
                  this, METHODID_ADD_FULFILLMENT_PLACES)))
          .addMethod(
            getRemoveFulfillmentPlacesMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.cloud.retail.v2beta.RemoveFulfillmentPlacesRequest,
                com.google.longrunning.Operation>(
                  this, METHODID_REMOVE_FULFILLMENT_PLACES)))
          .build();
    }
  }

  /**
   * <pre>
   * Service for ingesting [Product][google.cloud.retail.v2beta.Product]
   * information of the customer's website.
   * </pre>
   */
  public static final class ProductServiceStub extends io.grpc.stub.AbstractAsyncStub<ProductServiceStub> {
    private ProductServiceStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected ProductServiceStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new ProductServiceStub(channel, callOptions);
    }

    /**
     * <pre>
     * Creates a [Product][google.cloud.retail.v2beta.Product].
     * </pre>
     */
    public void createProduct(com.google.cloud.retail.v2beta.CreateProductRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.retail.v2beta.Product> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getCreateProductMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Gets a [Product][google.cloud.retail.v2beta.Product].
     * </pre>
     */
    public void getProduct(com.google.cloud.retail.v2beta.GetProductRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.retail.v2beta.Product> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getGetProductMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Gets a list of [Product][google.cloud.retail.v2beta.Product]s.
     * </pre>
     */
    public void listProducts(com.google.cloud.retail.v2beta.ListProductsRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.retail.v2beta.ListProductsResponse> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getListProductsMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Updates a [Product][google.cloud.retail.v2beta.Product].
     * </pre>
     */
    public void updateProduct(com.google.cloud.retail.v2beta.UpdateProductRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.retail.v2beta.Product> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getUpdateProductMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Deletes a [Product][google.cloud.retail.v2beta.Product].
     * </pre>
     */
    public void deleteProduct(com.google.cloud.retail.v2beta.DeleteProductRequest request,
        io.grpc.stub.StreamObserver<com.google.protobuf.Empty> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getDeleteProductMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Bulk import of multiple [Product][google.cloud.retail.v2beta.Product]s.
     * Request processing may be synchronous. No partial updating is supported.
     * Non-existing items are created.
     * Note that it is possible for a subset of the
     * [Product][google.cloud.retail.v2beta.Product]s to be successfully updated.
     * </pre>
     */
    public void importProducts(com.google.cloud.retail.v2beta.ImportProductsRequest request,
        io.grpc.stub.StreamObserver<com.google.longrunning.Operation> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getImportProductsMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Updates inventory information for a
     * [Product][google.cloud.retail.v2beta.Product] while respecting the last
     * update timestamps of each inventory field.
     * This process is asynchronous and does not require the
     * [Product][google.cloud.retail.v2beta.Product] to exist before updating
     * fulfillment information. If the request is valid, the update will be
     * enqueued and processed downstream. As a consequence, when a response is
     * returned, updates are not immediately manifested in the
     * [Product][google.cloud.retail.v2beta.Product] queried by
     * [GetProduct][google.cloud.retail.v2beta.ProductService.GetProduct] or
     * [ListProducts][google.cloud.retail.v2beta.ProductService.ListProducts].
     * When inventory is updated with
     * [CreateProduct][google.cloud.retail.v2beta.ProductService.CreateProduct]
     * and
     * [UpdateProduct][google.cloud.retail.v2beta.ProductService.UpdateProduct],
     * the specified inventory field value(s) will overwrite any existing value(s)
     * while ignoring the last update time for this field. Furthermore, the last
     * update time for the specified inventory fields will be overwritten to the
     * time of the
     * [CreateProduct][google.cloud.retail.v2beta.ProductService.CreateProduct] or
     * [UpdateProduct][google.cloud.retail.v2beta.ProductService.UpdateProduct]
     * request.
     * If no inventory fields are set in
     * [CreateProductRequest.product][google.cloud.retail.v2beta.CreateProductRequest.product],
     * then any pre-existing inventory information for this product will be used.
     * If no inventory fields are set in [UpdateProductRequest.set_mask][],
     * then any existing inventory information will be preserved.
     * Pre-existing inventory information can only be updated with
     * [SetInventory][google.cloud.retail.v2beta.ProductService.SetInventory],
     * [AddFulfillmentPlaces][google.cloud.retail.v2beta.ProductService.AddFulfillmentPlaces],
     * and
     * [RemoveFulfillmentPlaces][google.cloud.retail.v2beta.ProductService.RemoveFulfillmentPlaces].
     * This feature is only available for users who have Retail Search enabled.
     * Please submit a form [here](https://cloud.google.com/contact) to contact
     * cloud sales if you are interested in using Retail Search.
     * </pre>
     */
    public void setInventory(com.google.cloud.retail.v2beta.SetInventoryRequest request,
        io.grpc.stub.StreamObserver<com.google.longrunning.Operation> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getSetInventoryMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Incrementally adds place IDs to
     * [Product.fulfillment_info.place_ids][google.cloud.retail.v2beta.FulfillmentInfo.place_ids].
     * This process is asynchronous and does not require the
     * [Product][google.cloud.retail.v2beta.Product] to exist before updating
     * fulfillment information. If the request is valid, the update will be
     * enqueued and processed downstream. As a consequence, when a response is
     * returned, the added place IDs are not immediately manifested in the
     * [Product][google.cloud.retail.v2beta.Product] queried by
     * [GetProduct][google.cloud.retail.v2beta.ProductService.GetProduct] or
     * [ListProducts][google.cloud.retail.v2beta.ProductService.ListProducts].
     * This feature is only available for users who have Retail Search enabled.
     * Please submit a form [here](https://cloud.google.com/contact) to contact
     * cloud sales if you are interested in using Retail Search.
     * </pre>
     */
    public void addFulfillmentPlaces(com.google.cloud.retail.v2beta.AddFulfillmentPlacesRequest request,
        io.grpc.stub.StreamObserver<com.google.longrunning.Operation> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getAddFulfillmentPlacesMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Incrementally removes place IDs from a
     * [Product.fulfillment_info.place_ids][google.cloud.retail.v2beta.FulfillmentInfo.place_ids].
     * This process is asynchronous and does not require the
     * [Product][google.cloud.retail.v2beta.Product] to exist before updating
     * fulfillment information. If the request is valid, the update will be
     * enqueued and processed downstream. As a consequence, when a response is
     * returned, the removed place IDs are not immediately manifested in the
     * [Product][google.cloud.retail.v2beta.Product] queried by
     * [GetProduct][google.cloud.retail.v2beta.ProductService.GetProduct] or
     * [ListProducts][google.cloud.retail.v2beta.ProductService.ListProducts].
     * This feature is only available for users who have Retail Search enabled.
     * Please submit a form [here](https://cloud.google.com/contact) to contact
     * cloud sales if you are interested in using Retail Search.
     * </pre>
     */
    public void removeFulfillmentPlaces(com.google.cloud.retail.v2beta.RemoveFulfillmentPlacesRequest request,
        io.grpc.stub.StreamObserver<com.google.longrunning.Operation> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getRemoveFulfillmentPlacesMethod(), getCallOptions()), request, responseObserver);
    }
  }

  /**
   * <pre>
   * Service for ingesting [Product][google.cloud.retail.v2beta.Product]
   * information of the customer's website.
   * </pre>
   */
  public static final class ProductServiceBlockingStub extends io.grpc.stub.AbstractBlockingStub<ProductServiceBlockingStub> {
    private ProductServiceBlockingStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected ProductServiceBlockingStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new ProductServiceBlockingStub(channel, callOptions);
    }

    /**
     * <pre>
     * Creates a [Product][google.cloud.retail.v2beta.Product].
     * </pre>
     */
    public com.google.cloud.retail.v2beta.Product createProduct(com.google.cloud.retail.v2beta.CreateProductRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getCreateProductMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Gets a [Product][google.cloud.retail.v2beta.Product].
     * </pre>
     */
    public com.google.cloud.retail.v2beta.Product getProduct(com.google.cloud.retail.v2beta.GetProductRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getGetProductMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Gets a list of [Product][google.cloud.retail.v2beta.Product]s.
     * </pre>
     */
    public com.google.cloud.retail.v2beta.ListProductsResponse listProducts(com.google.cloud.retail.v2beta.ListProductsRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getListProductsMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Updates a [Product][google.cloud.retail.v2beta.Product].
     * </pre>
     */
    public com.google.cloud.retail.v2beta.Product updateProduct(com.google.cloud.retail.v2beta.UpdateProductRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getUpdateProductMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Deletes a [Product][google.cloud.retail.v2beta.Product].
     * </pre>
     */
    public com.google.protobuf.Empty deleteProduct(com.google.cloud.retail.v2beta.DeleteProductRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getDeleteProductMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Bulk import of multiple [Product][google.cloud.retail.v2beta.Product]s.
     * Request processing may be synchronous. No partial updating is supported.
     * Non-existing items are created.
     * Note that it is possible for a subset of the
     * [Product][google.cloud.retail.v2beta.Product]s to be successfully updated.
     * </pre>
     */
    public com.google.longrunning.Operation importProducts(com.google.cloud.retail.v2beta.ImportProductsRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getImportProductsMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Updates inventory information for a
     * [Product][google.cloud.retail.v2beta.Product] while respecting the last
     * update timestamps of each inventory field.
     * This process is asynchronous and does not require the
     * [Product][google.cloud.retail.v2beta.Product] to exist before updating
     * fulfillment information. If the request is valid, the update will be
     * enqueued and processed downstream. As a consequence, when a response is
     * returned, updates are not immediately manifested in the
     * [Product][google.cloud.retail.v2beta.Product] queried by
     * [GetProduct][google.cloud.retail.v2beta.ProductService.GetProduct] or
     * [ListProducts][google.cloud.retail.v2beta.ProductService.ListProducts].
     * When inventory is updated with
     * [CreateProduct][google.cloud.retail.v2beta.ProductService.CreateProduct]
     * and
     * [UpdateProduct][google.cloud.retail.v2beta.ProductService.UpdateProduct],
     * the specified inventory field value(s) will overwrite any existing value(s)
     * while ignoring the last update time for this field. Furthermore, the last
     * update time for the specified inventory fields will be overwritten to the
     * time of the
     * [CreateProduct][google.cloud.retail.v2beta.ProductService.CreateProduct] or
     * [UpdateProduct][google.cloud.retail.v2beta.ProductService.UpdateProduct]
     * request.
     * If no inventory fields are set in
     * [CreateProductRequest.product][google.cloud.retail.v2beta.CreateProductRequest.product],
     * then any pre-existing inventory information for this product will be used.
     * If no inventory fields are set in [UpdateProductRequest.set_mask][],
     * then any existing inventory information will be preserved.
     * Pre-existing inventory information can only be updated with
     * [SetInventory][google.cloud.retail.v2beta.ProductService.SetInventory],
     * [AddFulfillmentPlaces][google.cloud.retail.v2beta.ProductService.AddFulfillmentPlaces],
     * and
     * [RemoveFulfillmentPlaces][google.cloud.retail.v2beta.ProductService.RemoveFulfillmentPlaces].
     * This feature is only available for users who have Retail Search enabled.
     * Please submit a form [here](https://cloud.google.com/contact) to contact
     * cloud sales if you are interested in using Retail Search.
     * </pre>
     */
    public com.google.longrunning.Operation setInventory(com.google.cloud.retail.v2beta.SetInventoryRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getSetInventoryMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Incrementally adds place IDs to
     * [Product.fulfillment_info.place_ids][google.cloud.retail.v2beta.FulfillmentInfo.place_ids].
     * This process is asynchronous and does not require the
     * [Product][google.cloud.retail.v2beta.Product] to exist before updating
     * fulfillment information. If the request is valid, the update will be
     * enqueued and processed downstream. As a consequence, when a response is
     * returned, the added place IDs are not immediately manifested in the
     * [Product][google.cloud.retail.v2beta.Product] queried by
     * [GetProduct][google.cloud.retail.v2beta.ProductService.GetProduct] or
     * [ListProducts][google.cloud.retail.v2beta.ProductService.ListProducts].
     * This feature is only available for users who have Retail Search enabled.
     * Please submit a form [here](https://cloud.google.com/contact) to contact
     * cloud sales if you are interested in using Retail Search.
     * </pre>
     */
    public com.google.longrunning.Operation addFulfillmentPlaces(com.google.cloud.retail.v2beta.AddFulfillmentPlacesRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getAddFulfillmentPlacesMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Incrementally removes place IDs from a
     * [Product.fulfillment_info.place_ids][google.cloud.retail.v2beta.FulfillmentInfo.place_ids].
     * This process is asynchronous and does not require the
     * [Product][google.cloud.retail.v2beta.Product] to exist before updating
     * fulfillment information. If the request is valid, the update will be
     * enqueued and processed downstream. As a consequence, when a response is
     * returned, the removed place IDs are not immediately manifested in the
     * [Product][google.cloud.retail.v2beta.Product] queried by
     * [GetProduct][google.cloud.retail.v2beta.ProductService.GetProduct] or
     * [ListProducts][google.cloud.retail.v2beta.ProductService.ListProducts].
     * This feature is only available for users who have Retail Search enabled.
     * Please submit a form [here](https://cloud.google.com/contact) to contact
     * cloud sales if you are interested in using Retail Search.
     * </pre>
     */
    public com.google.longrunning.Operation removeFulfillmentPlaces(com.google.cloud.retail.v2beta.RemoveFulfillmentPlacesRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getRemoveFulfillmentPlacesMethod(), getCallOptions(), request);
    }
  }

  /**
   * <pre>
   * Service for ingesting [Product][google.cloud.retail.v2beta.Product]
   * information of the customer's website.
   * </pre>
   */
  public static final class ProductServiceFutureStub extends io.grpc.stub.AbstractFutureStub<ProductServiceFutureStub> {
    private ProductServiceFutureStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected ProductServiceFutureStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new ProductServiceFutureStub(channel, callOptions);
    }

    /**
     * <pre>
     * Creates a [Product][google.cloud.retail.v2beta.Product].
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.cloud.retail.v2beta.Product> createProduct(
        com.google.cloud.retail.v2beta.CreateProductRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getCreateProductMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Gets a [Product][google.cloud.retail.v2beta.Product].
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.cloud.retail.v2beta.Product> getProduct(
        com.google.cloud.retail.v2beta.GetProductRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getGetProductMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Gets a list of [Product][google.cloud.retail.v2beta.Product]s.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.cloud.retail.v2beta.ListProductsResponse> listProducts(
        com.google.cloud.retail.v2beta.ListProductsRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getListProductsMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Updates a [Product][google.cloud.retail.v2beta.Product].
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.cloud.retail.v2beta.Product> updateProduct(
        com.google.cloud.retail.v2beta.UpdateProductRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getUpdateProductMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Deletes a [Product][google.cloud.retail.v2beta.Product].
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.protobuf.Empty> deleteProduct(
        com.google.cloud.retail.v2beta.DeleteProductRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getDeleteProductMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Bulk import of multiple [Product][google.cloud.retail.v2beta.Product]s.
     * Request processing may be synchronous. No partial updating is supported.
     * Non-existing items are created.
     * Note that it is possible for a subset of the
     * [Product][google.cloud.retail.v2beta.Product]s to be successfully updated.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.longrunning.Operation> importProducts(
        com.google.cloud.retail.v2beta.ImportProductsRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getImportProductsMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Updates inventory information for a
     * [Product][google.cloud.retail.v2beta.Product] while respecting the last
     * update timestamps of each inventory field.
     * This process is asynchronous and does not require the
     * [Product][google.cloud.retail.v2beta.Product] to exist before updating
     * fulfillment information. If the request is valid, the update will be
     * enqueued and processed downstream. As a consequence, when a response is
     * returned, updates are not immediately manifested in the
     * [Product][google.cloud.retail.v2beta.Product] queried by
     * [GetProduct][google.cloud.retail.v2beta.ProductService.GetProduct] or
     * [ListProducts][google.cloud.retail.v2beta.ProductService.ListProducts].
     * When inventory is updated with
     * [CreateProduct][google.cloud.retail.v2beta.ProductService.CreateProduct]
     * and
     * [UpdateProduct][google.cloud.retail.v2beta.ProductService.UpdateProduct],
     * the specified inventory field value(s) will overwrite any existing value(s)
     * while ignoring the last update time for this field. Furthermore, the last
     * update time for the specified inventory fields will be overwritten to the
     * time of the
     * [CreateProduct][google.cloud.retail.v2beta.ProductService.CreateProduct] or
     * [UpdateProduct][google.cloud.retail.v2beta.ProductService.UpdateProduct]
     * request.
     * If no inventory fields are set in
     * [CreateProductRequest.product][google.cloud.retail.v2beta.CreateProductRequest.product],
     * then any pre-existing inventory information for this product will be used.
     * If no inventory fields are set in [UpdateProductRequest.set_mask][],
     * then any existing inventory information will be preserved.
     * Pre-existing inventory information can only be updated with
     * [SetInventory][google.cloud.retail.v2beta.ProductService.SetInventory],
     * [AddFulfillmentPlaces][google.cloud.retail.v2beta.ProductService.AddFulfillmentPlaces],
     * and
     * [RemoveFulfillmentPlaces][google.cloud.retail.v2beta.ProductService.RemoveFulfillmentPlaces].
     * This feature is only available for users who have Retail Search enabled.
     * Please submit a form [here](https://cloud.google.com/contact) to contact
     * cloud sales if you are interested in using Retail Search.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.longrunning.Operation> setInventory(
        com.google.cloud.retail.v2beta.SetInventoryRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getSetInventoryMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Incrementally adds place IDs to
     * [Product.fulfillment_info.place_ids][google.cloud.retail.v2beta.FulfillmentInfo.place_ids].
     * This process is asynchronous and does not require the
     * [Product][google.cloud.retail.v2beta.Product] to exist before updating
     * fulfillment information. If the request is valid, the update will be
     * enqueued and processed downstream. As a consequence, when a response is
     * returned, the added place IDs are not immediately manifested in the
     * [Product][google.cloud.retail.v2beta.Product] queried by
     * [GetProduct][google.cloud.retail.v2beta.ProductService.GetProduct] or
     * [ListProducts][google.cloud.retail.v2beta.ProductService.ListProducts].
     * This feature is only available for users who have Retail Search enabled.
     * Please submit a form [here](https://cloud.google.com/contact) to contact
     * cloud sales if you are interested in using Retail Search.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.longrunning.Operation> addFulfillmentPlaces(
        com.google.cloud.retail.v2beta.AddFulfillmentPlacesRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getAddFulfillmentPlacesMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Incrementally removes place IDs from a
     * [Product.fulfillment_info.place_ids][google.cloud.retail.v2beta.FulfillmentInfo.place_ids].
     * This process is asynchronous and does not require the
     * [Product][google.cloud.retail.v2beta.Product] to exist before updating
     * fulfillment information. If the request is valid, the update will be
     * enqueued and processed downstream. As a consequence, when a response is
     * returned, the removed place IDs are not immediately manifested in the
     * [Product][google.cloud.retail.v2beta.Product] queried by
     * [GetProduct][google.cloud.retail.v2beta.ProductService.GetProduct] or
     * [ListProducts][google.cloud.retail.v2beta.ProductService.ListProducts].
     * This feature is only available for users who have Retail Search enabled.
     * Please submit a form [here](https://cloud.google.com/contact) to contact
     * cloud sales if you are interested in using Retail Search.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.longrunning.Operation> removeFulfillmentPlaces(
        com.google.cloud.retail.v2beta.RemoveFulfillmentPlacesRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getRemoveFulfillmentPlacesMethod(), getCallOptions()), request);
    }
  }

  private static final int METHODID_CREATE_PRODUCT = 0;
  private static final int METHODID_GET_PRODUCT = 1;
  private static final int METHODID_LIST_PRODUCTS = 2;
  private static final int METHODID_UPDATE_PRODUCT = 3;
  private static final int METHODID_DELETE_PRODUCT = 4;
  private static final int METHODID_IMPORT_PRODUCTS = 5;
  private static final int METHODID_SET_INVENTORY = 6;
  private static final int METHODID_ADD_FULFILLMENT_PLACES = 7;
  private static final int METHODID_REMOVE_FULFILLMENT_PLACES = 8;

  private static final class MethodHandlers<Req, Resp> implements
      io.grpc.stub.ServerCalls.UnaryMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ServerStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ClientStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.BidiStreamingMethod<Req, Resp> {
    private final ProductServiceImplBase serviceImpl;
    private final int methodId;

    MethodHandlers(ProductServiceImplBase serviceImpl, int methodId) {
      this.serviceImpl = serviceImpl;
      this.methodId = methodId;
    }

    @java.lang.Override
    @java.lang.SuppressWarnings("unchecked")
    public void invoke(Req request, io.grpc.stub.StreamObserver<Resp> responseObserver) {
      switch (methodId) {
        case METHODID_CREATE_PRODUCT:
          serviceImpl.createProduct((com.google.cloud.retail.v2beta.CreateProductRequest) request,
              (io.grpc.stub.StreamObserver<com.google.cloud.retail.v2beta.Product>) responseObserver);
          break;
        case METHODID_GET_PRODUCT:
          serviceImpl.getProduct((com.google.cloud.retail.v2beta.GetProductRequest) request,
              (io.grpc.stub.StreamObserver<com.google.cloud.retail.v2beta.Product>) responseObserver);
          break;
        case METHODID_LIST_PRODUCTS:
          serviceImpl.listProducts((com.google.cloud.retail.v2beta.ListProductsRequest) request,
              (io.grpc.stub.StreamObserver<com.google.cloud.retail.v2beta.ListProductsResponse>) responseObserver);
          break;
        case METHODID_UPDATE_PRODUCT:
          serviceImpl.updateProduct((com.google.cloud.retail.v2beta.UpdateProductRequest) request,
              (io.grpc.stub.StreamObserver<com.google.cloud.retail.v2beta.Product>) responseObserver);
          break;
        case METHODID_DELETE_PRODUCT:
          serviceImpl.deleteProduct((com.google.cloud.retail.v2beta.DeleteProductRequest) request,
              (io.grpc.stub.StreamObserver<com.google.protobuf.Empty>) responseObserver);
          break;
        case METHODID_IMPORT_PRODUCTS:
          serviceImpl.importProducts((com.google.cloud.retail.v2beta.ImportProductsRequest) request,
              (io.grpc.stub.StreamObserver<com.google.longrunning.Operation>) responseObserver);
          break;
        case METHODID_SET_INVENTORY:
          serviceImpl.setInventory((com.google.cloud.retail.v2beta.SetInventoryRequest) request,
              (io.grpc.stub.StreamObserver<com.google.longrunning.Operation>) responseObserver);
          break;
        case METHODID_ADD_FULFILLMENT_PLACES:
          serviceImpl.addFulfillmentPlaces((com.google.cloud.retail.v2beta.AddFulfillmentPlacesRequest) request,
              (io.grpc.stub.StreamObserver<com.google.longrunning.Operation>) responseObserver);
          break;
        case METHODID_REMOVE_FULFILLMENT_PLACES:
          serviceImpl.removeFulfillmentPlaces((com.google.cloud.retail.v2beta.RemoveFulfillmentPlacesRequest) request,
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

  private static abstract class ProductServiceBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoFileDescriptorSupplier, io.grpc.protobuf.ProtoServiceDescriptorSupplier {
    ProductServiceBaseDescriptorSupplier() {}

    @java.lang.Override
    public com.google.protobuf.Descriptors.FileDescriptor getFileDescriptor() {
      return com.google.cloud.retail.v2beta.ProductServiceProto.getDescriptor();
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.ServiceDescriptor getServiceDescriptor() {
      return getFileDescriptor().findServiceByName("ProductService");
    }
  }

  private static final class ProductServiceFileDescriptorSupplier
      extends ProductServiceBaseDescriptorSupplier {
    ProductServiceFileDescriptorSupplier() {}
  }

  private static final class ProductServiceMethodDescriptorSupplier
      extends ProductServiceBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoMethodDescriptorSupplier {
    private final String methodName;

    ProductServiceMethodDescriptorSupplier(String methodName) {
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
      synchronized (ProductServiceGrpc.class) {
        result = serviceDescriptor;
        if (result == null) {
          serviceDescriptor = result = io.grpc.ServiceDescriptor.newBuilder(SERVICE_NAME)
              .setSchemaDescriptor(new ProductServiceFileDescriptorSupplier())
              .addMethod(getCreateProductMethod())
              .addMethod(getGetProductMethod())
              .addMethod(getListProductsMethod())
              .addMethod(getUpdateProductMethod())
              .addMethod(getDeleteProductMethod())
              .addMethod(getImportProductsMethod())
              .addMethod(getSetInventoryMethod())
              .addMethod(getAddFulfillmentPlacesMethod())
              .addMethod(getRemoveFulfillmentPlacesMethod())
              .build();
        }
      }
    }
    return result;
  }
}
