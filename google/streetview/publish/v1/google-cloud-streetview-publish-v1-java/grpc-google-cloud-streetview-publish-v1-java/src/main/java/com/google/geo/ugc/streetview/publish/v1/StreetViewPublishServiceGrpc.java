package com.google.geo.ugc.streetview.publish.v1;

import static io.grpc.MethodDescriptor.generateFullMethodName;

/**
 * <pre>
 * Publishes and connects user-contributed photos on Street View.
 * </pre>
 */
@javax.annotation.Generated(
    value = "by gRPC proto compiler",
    comments = "Source: google/streetview/publish/v1/streetview_publish.proto")
@io.grpc.stub.annotations.GrpcGenerated
public final class StreetViewPublishServiceGrpc {

  private StreetViewPublishServiceGrpc() {}

  public static final String SERVICE_NAME = "google.streetview.publish.v1.StreetViewPublishService";

  // Static method descriptors that strictly reflect the proto.
  private static volatile io.grpc.MethodDescriptor<com.google.protobuf.Empty,
      com.google.geo.ugc.streetview.publish.v1.StreetViewPublishResources.UploadRef> getStartUploadMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "StartUpload",
      requestType = com.google.protobuf.Empty.class,
      responseType = com.google.geo.ugc.streetview.publish.v1.StreetViewPublishResources.UploadRef.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.protobuf.Empty,
      com.google.geo.ugc.streetview.publish.v1.StreetViewPublishResources.UploadRef> getStartUploadMethod() {
    io.grpc.MethodDescriptor<com.google.protobuf.Empty, com.google.geo.ugc.streetview.publish.v1.StreetViewPublishResources.UploadRef> getStartUploadMethod;
    if ((getStartUploadMethod = StreetViewPublishServiceGrpc.getStartUploadMethod) == null) {
      synchronized (StreetViewPublishServiceGrpc.class) {
        if ((getStartUploadMethod = StreetViewPublishServiceGrpc.getStartUploadMethod) == null) {
          StreetViewPublishServiceGrpc.getStartUploadMethod = getStartUploadMethod =
              io.grpc.MethodDescriptor.<com.google.protobuf.Empty, com.google.geo.ugc.streetview.publish.v1.StreetViewPublishResources.UploadRef>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "StartUpload"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.protobuf.Empty.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.geo.ugc.streetview.publish.v1.StreetViewPublishResources.UploadRef.getDefaultInstance()))
              .setSchemaDescriptor(new StreetViewPublishServiceMethodDescriptorSupplier("StartUpload"))
              .build();
        }
      }
    }
    return getStartUploadMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.CreatePhotoRequest,
      com.google.geo.ugc.streetview.publish.v1.StreetViewPublishResources.Photo> getCreatePhotoMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "CreatePhoto",
      requestType = com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.CreatePhotoRequest.class,
      responseType = com.google.geo.ugc.streetview.publish.v1.StreetViewPublishResources.Photo.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.CreatePhotoRequest,
      com.google.geo.ugc.streetview.publish.v1.StreetViewPublishResources.Photo> getCreatePhotoMethod() {
    io.grpc.MethodDescriptor<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.CreatePhotoRequest, com.google.geo.ugc.streetview.publish.v1.StreetViewPublishResources.Photo> getCreatePhotoMethod;
    if ((getCreatePhotoMethod = StreetViewPublishServiceGrpc.getCreatePhotoMethod) == null) {
      synchronized (StreetViewPublishServiceGrpc.class) {
        if ((getCreatePhotoMethod = StreetViewPublishServiceGrpc.getCreatePhotoMethod) == null) {
          StreetViewPublishServiceGrpc.getCreatePhotoMethod = getCreatePhotoMethod =
              io.grpc.MethodDescriptor.<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.CreatePhotoRequest, com.google.geo.ugc.streetview.publish.v1.StreetViewPublishResources.Photo>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "CreatePhoto"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.CreatePhotoRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.geo.ugc.streetview.publish.v1.StreetViewPublishResources.Photo.getDefaultInstance()))
              .setSchemaDescriptor(new StreetViewPublishServiceMethodDescriptorSupplier("CreatePhoto"))
              .build();
        }
      }
    }
    return getCreatePhotoMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.GetPhotoRequest,
      com.google.geo.ugc.streetview.publish.v1.StreetViewPublishResources.Photo> getGetPhotoMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "GetPhoto",
      requestType = com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.GetPhotoRequest.class,
      responseType = com.google.geo.ugc.streetview.publish.v1.StreetViewPublishResources.Photo.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.GetPhotoRequest,
      com.google.geo.ugc.streetview.publish.v1.StreetViewPublishResources.Photo> getGetPhotoMethod() {
    io.grpc.MethodDescriptor<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.GetPhotoRequest, com.google.geo.ugc.streetview.publish.v1.StreetViewPublishResources.Photo> getGetPhotoMethod;
    if ((getGetPhotoMethod = StreetViewPublishServiceGrpc.getGetPhotoMethod) == null) {
      synchronized (StreetViewPublishServiceGrpc.class) {
        if ((getGetPhotoMethod = StreetViewPublishServiceGrpc.getGetPhotoMethod) == null) {
          StreetViewPublishServiceGrpc.getGetPhotoMethod = getGetPhotoMethod =
              io.grpc.MethodDescriptor.<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.GetPhotoRequest, com.google.geo.ugc.streetview.publish.v1.StreetViewPublishResources.Photo>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "GetPhoto"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.GetPhotoRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.geo.ugc.streetview.publish.v1.StreetViewPublishResources.Photo.getDefaultInstance()))
              .setSchemaDescriptor(new StreetViewPublishServiceMethodDescriptorSupplier("GetPhoto"))
              .build();
        }
      }
    }
    return getGetPhotoMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchGetPhotosRequest,
      com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchGetPhotosResponse> getBatchGetPhotosMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "BatchGetPhotos",
      requestType = com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchGetPhotosRequest.class,
      responseType = com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchGetPhotosResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchGetPhotosRequest,
      com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchGetPhotosResponse> getBatchGetPhotosMethod() {
    io.grpc.MethodDescriptor<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchGetPhotosRequest, com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchGetPhotosResponse> getBatchGetPhotosMethod;
    if ((getBatchGetPhotosMethod = StreetViewPublishServiceGrpc.getBatchGetPhotosMethod) == null) {
      synchronized (StreetViewPublishServiceGrpc.class) {
        if ((getBatchGetPhotosMethod = StreetViewPublishServiceGrpc.getBatchGetPhotosMethod) == null) {
          StreetViewPublishServiceGrpc.getBatchGetPhotosMethod = getBatchGetPhotosMethod =
              io.grpc.MethodDescriptor.<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchGetPhotosRequest, com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchGetPhotosResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "BatchGetPhotos"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchGetPhotosRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchGetPhotosResponse.getDefaultInstance()))
              .setSchemaDescriptor(new StreetViewPublishServiceMethodDescriptorSupplier("BatchGetPhotos"))
              .build();
        }
      }
    }
    return getBatchGetPhotosMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.ListPhotosRequest,
      com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.ListPhotosResponse> getListPhotosMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "ListPhotos",
      requestType = com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.ListPhotosRequest.class,
      responseType = com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.ListPhotosResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.ListPhotosRequest,
      com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.ListPhotosResponse> getListPhotosMethod() {
    io.grpc.MethodDescriptor<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.ListPhotosRequest, com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.ListPhotosResponse> getListPhotosMethod;
    if ((getListPhotosMethod = StreetViewPublishServiceGrpc.getListPhotosMethod) == null) {
      synchronized (StreetViewPublishServiceGrpc.class) {
        if ((getListPhotosMethod = StreetViewPublishServiceGrpc.getListPhotosMethod) == null) {
          StreetViewPublishServiceGrpc.getListPhotosMethod = getListPhotosMethod =
              io.grpc.MethodDescriptor.<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.ListPhotosRequest, com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.ListPhotosResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "ListPhotos"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.ListPhotosRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.ListPhotosResponse.getDefaultInstance()))
              .setSchemaDescriptor(new StreetViewPublishServiceMethodDescriptorSupplier("ListPhotos"))
              .build();
        }
      }
    }
    return getListPhotosMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.UpdatePhotoRequest,
      com.google.geo.ugc.streetview.publish.v1.StreetViewPublishResources.Photo> getUpdatePhotoMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "UpdatePhoto",
      requestType = com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.UpdatePhotoRequest.class,
      responseType = com.google.geo.ugc.streetview.publish.v1.StreetViewPublishResources.Photo.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.UpdatePhotoRequest,
      com.google.geo.ugc.streetview.publish.v1.StreetViewPublishResources.Photo> getUpdatePhotoMethod() {
    io.grpc.MethodDescriptor<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.UpdatePhotoRequest, com.google.geo.ugc.streetview.publish.v1.StreetViewPublishResources.Photo> getUpdatePhotoMethod;
    if ((getUpdatePhotoMethod = StreetViewPublishServiceGrpc.getUpdatePhotoMethod) == null) {
      synchronized (StreetViewPublishServiceGrpc.class) {
        if ((getUpdatePhotoMethod = StreetViewPublishServiceGrpc.getUpdatePhotoMethod) == null) {
          StreetViewPublishServiceGrpc.getUpdatePhotoMethod = getUpdatePhotoMethod =
              io.grpc.MethodDescriptor.<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.UpdatePhotoRequest, com.google.geo.ugc.streetview.publish.v1.StreetViewPublishResources.Photo>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "UpdatePhoto"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.UpdatePhotoRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.geo.ugc.streetview.publish.v1.StreetViewPublishResources.Photo.getDefaultInstance()))
              .setSchemaDescriptor(new StreetViewPublishServiceMethodDescriptorSupplier("UpdatePhoto"))
              .build();
        }
      }
    }
    return getUpdatePhotoMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchUpdatePhotosRequest,
      com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchUpdatePhotosResponse> getBatchUpdatePhotosMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "BatchUpdatePhotos",
      requestType = com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchUpdatePhotosRequest.class,
      responseType = com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchUpdatePhotosResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchUpdatePhotosRequest,
      com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchUpdatePhotosResponse> getBatchUpdatePhotosMethod() {
    io.grpc.MethodDescriptor<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchUpdatePhotosRequest, com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchUpdatePhotosResponse> getBatchUpdatePhotosMethod;
    if ((getBatchUpdatePhotosMethod = StreetViewPublishServiceGrpc.getBatchUpdatePhotosMethod) == null) {
      synchronized (StreetViewPublishServiceGrpc.class) {
        if ((getBatchUpdatePhotosMethod = StreetViewPublishServiceGrpc.getBatchUpdatePhotosMethod) == null) {
          StreetViewPublishServiceGrpc.getBatchUpdatePhotosMethod = getBatchUpdatePhotosMethod =
              io.grpc.MethodDescriptor.<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchUpdatePhotosRequest, com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchUpdatePhotosResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "BatchUpdatePhotos"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchUpdatePhotosRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchUpdatePhotosResponse.getDefaultInstance()))
              .setSchemaDescriptor(new StreetViewPublishServiceMethodDescriptorSupplier("BatchUpdatePhotos"))
              .build();
        }
      }
    }
    return getBatchUpdatePhotosMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.DeletePhotoRequest,
      com.google.protobuf.Empty> getDeletePhotoMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "DeletePhoto",
      requestType = com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.DeletePhotoRequest.class,
      responseType = com.google.protobuf.Empty.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.DeletePhotoRequest,
      com.google.protobuf.Empty> getDeletePhotoMethod() {
    io.grpc.MethodDescriptor<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.DeletePhotoRequest, com.google.protobuf.Empty> getDeletePhotoMethod;
    if ((getDeletePhotoMethod = StreetViewPublishServiceGrpc.getDeletePhotoMethod) == null) {
      synchronized (StreetViewPublishServiceGrpc.class) {
        if ((getDeletePhotoMethod = StreetViewPublishServiceGrpc.getDeletePhotoMethod) == null) {
          StreetViewPublishServiceGrpc.getDeletePhotoMethod = getDeletePhotoMethod =
              io.grpc.MethodDescriptor.<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.DeletePhotoRequest, com.google.protobuf.Empty>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "DeletePhoto"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.DeletePhotoRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.protobuf.Empty.getDefaultInstance()))
              .setSchemaDescriptor(new StreetViewPublishServiceMethodDescriptorSupplier("DeletePhoto"))
              .build();
        }
      }
    }
    return getDeletePhotoMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchDeletePhotosRequest,
      com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchDeletePhotosResponse> getBatchDeletePhotosMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "BatchDeletePhotos",
      requestType = com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchDeletePhotosRequest.class,
      responseType = com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchDeletePhotosResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchDeletePhotosRequest,
      com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchDeletePhotosResponse> getBatchDeletePhotosMethod() {
    io.grpc.MethodDescriptor<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchDeletePhotosRequest, com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchDeletePhotosResponse> getBatchDeletePhotosMethod;
    if ((getBatchDeletePhotosMethod = StreetViewPublishServiceGrpc.getBatchDeletePhotosMethod) == null) {
      synchronized (StreetViewPublishServiceGrpc.class) {
        if ((getBatchDeletePhotosMethod = StreetViewPublishServiceGrpc.getBatchDeletePhotosMethod) == null) {
          StreetViewPublishServiceGrpc.getBatchDeletePhotosMethod = getBatchDeletePhotosMethod =
              io.grpc.MethodDescriptor.<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchDeletePhotosRequest, com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchDeletePhotosResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "BatchDeletePhotos"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchDeletePhotosRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchDeletePhotosResponse.getDefaultInstance()))
              .setSchemaDescriptor(new StreetViewPublishServiceMethodDescriptorSupplier("BatchDeletePhotos"))
              .build();
        }
      }
    }
    return getBatchDeletePhotosMethod;
  }

  /**
   * Creates a new async stub that supports all call types for the service
   */
  public static StreetViewPublishServiceStub newStub(io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<StreetViewPublishServiceStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<StreetViewPublishServiceStub>() {
        @java.lang.Override
        public StreetViewPublishServiceStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new StreetViewPublishServiceStub(channel, callOptions);
        }
      };
    return StreetViewPublishServiceStub.newStub(factory, channel);
  }

  /**
   * Creates a new blocking-style stub that supports unary and streaming output calls on the service
   */
  public static StreetViewPublishServiceBlockingStub newBlockingStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<StreetViewPublishServiceBlockingStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<StreetViewPublishServiceBlockingStub>() {
        @java.lang.Override
        public StreetViewPublishServiceBlockingStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new StreetViewPublishServiceBlockingStub(channel, callOptions);
        }
      };
    return StreetViewPublishServiceBlockingStub.newStub(factory, channel);
  }

  /**
   * Creates a new ListenableFuture-style stub that supports unary calls on the service
   */
  public static StreetViewPublishServiceFutureStub newFutureStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<StreetViewPublishServiceFutureStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<StreetViewPublishServiceFutureStub>() {
        @java.lang.Override
        public StreetViewPublishServiceFutureStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new StreetViewPublishServiceFutureStub(channel, callOptions);
        }
      };
    return StreetViewPublishServiceFutureStub.newStub(factory, channel);
  }

  /**
   * <pre>
   * Publishes and connects user-contributed photos on Street View.
   * </pre>
   */
  public static abstract class StreetViewPublishServiceImplBase implements io.grpc.BindableService {

    /**
     * <pre>
     * Creates an upload session to start uploading photo bytes.  The method uses
     * the upload URL of the returned
     * [UploadRef][google.streetview.publish.v1.UploadRef] to upload the bytes for
     * the [Photo][google.streetview.publish.v1.Photo].
     * In addition to the photo requirements shown in
     * https://support.google.com/maps/answer/7012050?ref_topic=6275604,
     * the photo must meet the following requirements:
     * * Photo Sphere XMP metadata must be included in the photo metadata. See
     * https://developers.google.com/streetview/spherical-metadata for the
     * required fields.
     * * The pixel size of the photo must meet the size requirements listed in
     * https://support.google.com/maps/answer/7012050?ref_topic=6275604, and
     * the photo must be a full 360 horizontally.
     * After the upload completes, the method uses
     * [UploadRef][google.streetview.publish.v1.UploadRef] with
     * [CreatePhoto][google.streetview.publish.v1.StreetViewPublishService.CreatePhoto]
     * to create the [Photo][google.streetview.publish.v1.Photo] object entry.
     * </pre>
     */
    public void startUpload(com.google.protobuf.Empty request,
        io.grpc.stub.StreamObserver<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishResources.UploadRef> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getStartUploadMethod(), responseObserver);
    }

    /**
     * <pre>
     * After the client finishes uploading the photo with the returned
     * [UploadRef][google.streetview.publish.v1.UploadRef],
     * [CreatePhoto][google.streetview.publish.v1.StreetViewPublishService.CreatePhoto]
     * publishes the uploaded [Photo][google.streetview.publish.v1.Photo] to
     * Street View on Google Maps.
     * Currently, the only way to set heading, pitch, and roll in CreatePhoto is
     * through the [Photo Sphere XMP
     * metadata](https://developers.google.com/streetview/spherical-metadata) in
     * the photo bytes. CreatePhoto ignores the  `pose.heading`, `pose.pitch`,
     * `pose.roll`, `pose.altitude`, and `pose.level` fields in Pose.
     * This method returns the following error codes:
     * * [google.rpc.Code.INVALID_ARGUMENT][google.rpc.Code.INVALID_ARGUMENT] if the request is malformed or if
     * the uploaded photo is not a 360 photo.
     * * [google.rpc.Code.NOT_FOUND][google.rpc.Code.NOT_FOUND] if the upload reference does not exist.
     * * [google.rpc.Code.RESOURCE_EXHAUSTED][google.rpc.Code.RESOURCE_EXHAUSTED] if the account has reached the
     * storage limit.
     * </pre>
     */
    public void createPhoto(com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.CreatePhotoRequest request,
        io.grpc.stub.StreamObserver<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishResources.Photo> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getCreatePhotoMethod(), responseObserver);
    }

    /**
     * <pre>
     * Gets the metadata of the specified
     * [Photo][google.streetview.publish.v1.Photo].
     * This method returns the following error codes:
     * * [google.rpc.Code.PERMISSION_DENIED][google.rpc.Code.PERMISSION_DENIED] if the requesting user did not
     * create the requested [Photo][google.streetview.publish.v1.Photo].
     * * [google.rpc.Code.NOT_FOUND][google.rpc.Code.NOT_FOUND] if the requested
     * [Photo][google.streetview.publish.v1.Photo] does not exist.
     * * [google.rpc.Code.UNAVAILABLE][google.rpc.Code.UNAVAILABLE] if the requested
     * [Photo][google.streetview.publish.v1.Photo] is still being indexed.
     * </pre>
     */
    public void getPhoto(com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.GetPhotoRequest request,
        io.grpc.stub.StreamObserver<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishResources.Photo> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getGetPhotoMethod(), responseObserver);
    }

    /**
     * <pre>
     * Gets the metadata of the specified
     * [Photo][google.streetview.publish.v1.Photo] batch.
     * Note that if
     * [BatchGetPhotos][google.streetview.publish.v1.StreetViewPublishService.BatchGetPhotos]
     * fails, either critical fields are missing or there is an authentication
     * error. Even if
     * [BatchGetPhotos][google.streetview.publish.v1.StreetViewPublishService.BatchGetPhotos]
     * succeeds, individual photos in the batch may have failures.
     * These failures are specified in each
     * [PhotoResponse.status][google.streetview.publish.v1.PhotoResponse.status]
     * in
     * [BatchGetPhotosResponse.results][google.streetview.publish.v1.BatchGetPhotosResponse.results].
     * See
     * [GetPhoto][google.streetview.publish.v1.StreetViewPublishService.GetPhoto]
     * for specific failures that can occur per photo.
     * </pre>
     */
    public void batchGetPhotos(com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchGetPhotosRequest request,
        io.grpc.stub.StreamObserver<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchGetPhotosResponse> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getBatchGetPhotosMethod(), responseObserver);
    }

    /**
     * <pre>
     * Lists all the [Photos][google.streetview.publish.v1.Photo] that belong to
     * the user.
     * &gt; Note: Recently created photos that are still
     * being indexed are not returned in the response.
     * </pre>
     */
    public void listPhotos(com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.ListPhotosRequest request,
        io.grpc.stub.StreamObserver<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.ListPhotosResponse> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getListPhotosMethod(), responseObserver);
    }

    /**
     * <pre>
     * Updates the metadata of a [Photo][google.streetview.publish.v1.Photo], such
     * as pose, place association, connections, etc. Changing the pixels of a
     * photo is not supported.
     * Only the fields specified in the
     * [updateMask][google.streetview.publish.v1.UpdatePhotoRequest.update_mask]
     * field are used. If `updateMask` is not present, the update applies to all
     * fields.
     * This method returns the following error codes:
     * * [google.rpc.Code.PERMISSION_DENIED][google.rpc.Code.PERMISSION_DENIED] if the requesting user did not
     * create the requested photo.
     * * [google.rpc.Code.INVALID_ARGUMENT][google.rpc.Code.INVALID_ARGUMENT] if the request is malformed.
     * * [google.rpc.Code.NOT_FOUND][google.rpc.Code.NOT_FOUND] if the requested photo does not exist.
     * * [google.rpc.Code.UNAVAILABLE][google.rpc.Code.UNAVAILABLE] if the requested
     * [Photo][google.streetview.publish.v1.Photo] is still being indexed.
     * </pre>
     */
    public void updatePhoto(com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.UpdatePhotoRequest request,
        io.grpc.stub.StreamObserver<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishResources.Photo> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getUpdatePhotoMethod(), responseObserver);
    }

    /**
     * <pre>
     * Updates the metadata of [Photos][google.streetview.publish.v1.Photo], such
     * as pose, place association, connections, etc. Changing the pixels of photos
     * is not supported.
     * Note that if
     * [BatchUpdatePhotos][google.streetview.publish.v1.StreetViewPublishService.BatchUpdatePhotos]
     * fails, either critical fields are missing or there is an authentication
     * error. Even if
     * [BatchUpdatePhotos][google.streetview.publish.v1.StreetViewPublishService.BatchUpdatePhotos]
     * succeeds, individual photos in the batch may have failures.
     * These failures are specified in each
     * [PhotoResponse.status][google.streetview.publish.v1.PhotoResponse.status]
     * in
     * [BatchUpdatePhotosResponse.results][google.streetview.publish.v1.BatchUpdatePhotosResponse.results].
     * See
     * [UpdatePhoto][google.streetview.publish.v1.StreetViewPublishService.UpdatePhoto]
     * for specific failures that can occur per photo.
     * Only the fields specified in
     * [updateMask][google.streetview.publish.v1.UpdatePhotoRequest.update_mask]
     * field are used. If `updateMask` is not present, the update applies to all
     * fields.
     * The number of
     * [UpdatePhotoRequest][google.streetview.publish.v1.UpdatePhotoRequest]
     * messages in a
     * [BatchUpdatePhotosRequest][google.streetview.publish.v1.BatchUpdatePhotosRequest]
     * must not exceed 20.
     * &gt; Note: To update
     * [Pose.altitude][google.streetview.publish.v1.Pose.altitude],
     * [Pose.latLngPair][google.streetview.publish.v1.Pose.lat_lng_pair] has to be
     * filled as well. Otherwise, the request will fail.
     * </pre>
     */
    public void batchUpdatePhotos(com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchUpdatePhotosRequest request,
        io.grpc.stub.StreamObserver<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchUpdatePhotosResponse> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getBatchUpdatePhotosMethod(), responseObserver);
    }

    /**
     * <pre>
     * Deletes a [Photo][google.streetview.publish.v1.Photo] and its metadata.
     * This method returns the following error codes:
     * * [google.rpc.Code.PERMISSION_DENIED][google.rpc.Code.PERMISSION_DENIED] if the requesting user did not
     * create the requested photo.
     * * [google.rpc.Code.NOT_FOUND][google.rpc.Code.NOT_FOUND] if the photo ID does not exist.
     * </pre>
     */
    public void deletePhoto(com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.DeletePhotoRequest request,
        io.grpc.stub.StreamObserver<com.google.protobuf.Empty> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getDeletePhotoMethod(), responseObserver);
    }

    /**
     * <pre>
     * Deletes a list of [Photos][google.streetview.publish.v1.Photo] and their
     * metadata.
     * Note that if
     * [BatchDeletePhotos][google.streetview.publish.v1.StreetViewPublishService.BatchDeletePhotos]
     * fails, either critical fields are missing or there is an authentication
     * error. Even if
     * [BatchDeletePhotos][google.streetview.publish.v1.StreetViewPublishService.BatchDeletePhotos]
     * succeeds, individual photos in the batch may have failures.
     * These failures are specified in each
     * [PhotoResponse.status][google.streetview.publish.v1.PhotoResponse.status]
     * in
     * [BatchDeletePhotosResponse.results][google.streetview.publish.v1.BatchDeletePhotosResponse.status].
     * See
     * [DeletePhoto][google.streetview.publish.v1.StreetViewPublishService.DeletePhoto]
     * for specific failures that can occur per photo.
     * </pre>
     */
    public void batchDeletePhotos(com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchDeletePhotosRequest request,
        io.grpc.stub.StreamObserver<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchDeletePhotosResponse> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getBatchDeletePhotosMethod(), responseObserver);
    }

    @java.lang.Override public final io.grpc.ServerServiceDefinition bindService() {
      return io.grpc.ServerServiceDefinition.builder(getServiceDescriptor())
          .addMethod(
            getStartUploadMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.protobuf.Empty,
                com.google.geo.ugc.streetview.publish.v1.StreetViewPublishResources.UploadRef>(
                  this, METHODID_START_UPLOAD)))
          .addMethod(
            getCreatePhotoMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.CreatePhotoRequest,
                com.google.geo.ugc.streetview.publish.v1.StreetViewPublishResources.Photo>(
                  this, METHODID_CREATE_PHOTO)))
          .addMethod(
            getGetPhotoMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.GetPhotoRequest,
                com.google.geo.ugc.streetview.publish.v1.StreetViewPublishResources.Photo>(
                  this, METHODID_GET_PHOTO)))
          .addMethod(
            getBatchGetPhotosMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchGetPhotosRequest,
                com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchGetPhotosResponse>(
                  this, METHODID_BATCH_GET_PHOTOS)))
          .addMethod(
            getListPhotosMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.ListPhotosRequest,
                com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.ListPhotosResponse>(
                  this, METHODID_LIST_PHOTOS)))
          .addMethod(
            getUpdatePhotoMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.UpdatePhotoRequest,
                com.google.geo.ugc.streetview.publish.v1.StreetViewPublishResources.Photo>(
                  this, METHODID_UPDATE_PHOTO)))
          .addMethod(
            getBatchUpdatePhotosMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchUpdatePhotosRequest,
                com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchUpdatePhotosResponse>(
                  this, METHODID_BATCH_UPDATE_PHOTOS)))
          .addMethod(
            getDeletePhotoMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.DeletePhotoRequest,
                com.google.protobuf.Empty>(
                  this, METHODID_DELETE_PHOTO)))
          .addMethod(
            getBatchDeletePhotosMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchDeletePhotosRequest,
                com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchDeletePhotosResponse>(
                  this, METHODID_BATCH_DELETE_PHOTOS)))
          .build();
    }
  }

  /**
   * <pre>
   * Publishes and connects user-contributed photos on Street View.
   * </pre>
   */
  public static final class StreetViewPublishServiceStub extends io.grpc.stub.AbstractAsyncStub<StreetViewPublishServiceStub> {
    private StreetViewPublishServiceStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected StreetViewPublishServiceStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new StreetViewPublishServiceStub(channel, callOptions);
    }

    /**
     * <pre>
     * Creates an upload session to start uploading photo bytes.  The method uses
     * the upload URL of the returned
     * [UploadRef][google.streetview.publish.v1.UploadRef] to upload the bytes for
     * the [Photo][google.streetview.publish.v1.Photo].
     * In addition to the photo requirements shown in
     * https://support.google.com/maps/answer/7012050?ref_topic=6275604,
     * the photo must meet the following requirements:
     * * Photo Sphere XMP metadata must be included in the photo metadata. See
     * https://developers.google.com/streetview/spherical-metadata for the
     * required fields.
     * * The pixel size of the photo must meet the size requirements listed in
     * https://support.google.com/maps/answer/7012050?ref_topic=6275604, and
     * the photo must be a full 360 horizontally.
     * After the upload completes, the method uses
     * [UploadRef][google.streetview.publish.v1.UploadRef] with
     * [CreatePhoto][google.streetview.publish.v1.StreetViewPublishService.CreatePhoto]
     * to create the [Photo][google.streetview.publish.v1.Photo] object entry.
     * </pre>
     */
    public void startUpload(com.google.protobuf.Empty request,
        io.grpc.stub.StreamObserver<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishResources.UploadRef> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getStartUploadMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * After the client finishes uploading the photo with the returned
     * [UploadRef][google.streetview.publish.v1.UploadRef],
     * [CreatePhoto][google.streetview.publish.v1.StreetViewPublishService.CreatePhoto]
     * publishes the uploaded [Photo][google.streetview.publish.v1.Photo] to
     * Street View on Google Maps.
     * Currently, the only way to set heading, pitch, and roll in CreatePhoto is
     * through the [Photo Sphere XMP
     * metadata](https://developers.google.com/streetview/spherical-metadata) in
     * the photo bytes. CreatePhoto ignores the  `pose.heading`, `pose.pitch`,
     * `pose.roll`, `pose.altitude`, and `pose.level` fields in Pose.
     * This method returns the following error codes:
     * * [google.rpc.Code.INVALID_ARGUMENT][google.rpc.Code.INVALID_ARGUMENT] if the request is malformed or if
     * the uploaded photo is not a 360 photo.
     * * [google.rpc.Code.NOT_FOUND][google.rpc.Code.NOT_FOUND] if the upload reference does not exist.
     * * [google.rpc.Code.RESOURCE_EXHAUSTED][google.rpc.Code.RESOURCE_EXHAUSTED] if the account has reached the
     * storage limit.
     * </pre>
     */
    public void createPhoto(com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.CreatePhotoRequest request,
        io.grpc.stub.StreamObserver<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishResources.Photo> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getCreatePhotoMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Gets the metadata of the specified
     * [Photo][google.streetview.publish.v1.Photo].
     * This method returns the following error codes:
     * * [google.rpc.Code.PERMISSION_DENIED][google.rpc.Code.PERMISSION_DENIED] if the requesting user did not
     * create the requested [Photo][google.streetview.publish.v1.Photo].
     * * [google.rpc.Code.NOT_FOUND][google.rpc.Code.NOT_FOUND] if the requested
     * [Photo][google.streetview.publish.v1.Photo] does not exist.
     * * [google.rpc.Code.UNAVAILABLE][google.rpc.Code.UNAVAILABLE] if the requested
     * [Photo][google.streetview.publish.v1.Photo] is still being indexed.
     * </pre>
     */
    public void getPhoto(com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.GetPhotoRequest request,
        io.grpc.stub.StreamObserver<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishResources.Photo> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getGetPhotoMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Gets the metadata of the specified
     * [Photo][google.streetview.publish.v1.Photo] batch.
     * Note that if
     * [BatchGetPhotos][google.streetview.publish.v1.StreetViewPublishService.BatchGetPhotos]
     * fails, either critical fields are missing or there is an authentication
     * error. Even if
     * [BatchGetPhotos][google.streetview.publish.v1.StreetViewPublishService.BatchGetPhotos]
     * succeeds, individual photos in the batch may have failures.
     * These failures are specified in each
     * [PhotoResponse.status][google.streetview.publish.v1.PhotoResponse.status]
     * in
     * [BatchGetPhotosResponse.results][google.streetview.publish.v1.BatchGetPhotosResponse.results].
     * See
     * [GetPhoto][google.streetview.publish.v1.StreetViewPublishService.GetPhoto]
     * for specific failures that can occur per photo.
     * </pre>
     */
    public void batchGetPhotos(com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchGetPhotosRequest request,
        io.grpc.stub.StreamObserver<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchGetPhotosResponse> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getBatchGetPhotosMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Lists all the [Photos][google.streetview.publish.v1.Photo] that belong to
     * the user.
     * &gt; Note: Recently created photos that are still
     * being indexed are not returned in the response.
     * </pre>
     */
    public void listPhotos(com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.ListPhotosRequest request,
        io.grpc.stub.StreamObserver<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.ListPhotosResponse> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getListPhotosMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Updates the metadata of a [Photo][google.streetview.publish.v1.Photo], such
     * as pose, place association, connections, etc. Changing the pixels of a
     * photo is not supported.
     * Only the fields specified in the
     * [updateMask][google.streetview.publish.v1.UpdatePhotoRequest.update_mask]
     * field are used. If `updateMask` is not present, the update applies to all
     * fields.
     * This method returns the following error codes:
     * * [google.rpc.Code.PERMISSION_DENIED][google.rpc.Code.PERMISSION_DENIED] if the requesting user did not
     * create the requested photo.
     * * [google.rpc.Code.INVALID_ARGUMENT][google.rpc.Code.INVALID_ARGUMENT] if the request is malformed.
     * * [google.rpc.Code.NOT_FOUND][google.rpc.Code.NOT_FOUND] if the requested photo does not exist.
     * * [google.rpc.Code.UNAVAILABLE][google.rpc.Code.UNAVAILABLE] if the requested
     * [Photo][google.streetview.publish.v1.Photo] is still being indexed.
     * </pre>
     */
    public void updatePhoto(com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.UpdatePhotoRequest request,
        io.grpc.stub.StreamObserver<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishResources.Photo> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getUpdatePhotoMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Updates the metadata of [Photos][google.streetview.publish.v1.Photo], such
     * as pose, place association, connections, etc. Changing the pixels of photos
     * is not supported.
     * Note that if
     * [BatchUpdatePhotos][google.streetview.publish.v1.StreetViewPublishService.BatchUpdatePhotos]
     * fails, either critical fields are missing or there is an authentication
     * error. Even if
     * [BatchUpdatePhotos][google.streetview.publish.v1.StreetViewPublishService.BatchUpdatePhotos]
     * succeeds, individual photos in the batch may have failures.
     * These failures are specified in each
     * [PhotoResponse.status][google.streetview.publish.v1.PhotoResponse.status]
     * in
     * [BatchUpdatePhotosResponse.results][google.streetview.publish.v1.BatchUpdatePhotosResponse.results].
     * See
     * [UpdatePhoto][google.streetview.publish.v1.StreetViewPublishService.UpdatePhoto]
     * for specific failures that can occur per photo.
     * Only the fields specified in
     * [updateMask][google.streetview.publish.v1.UpdatePhotoRequest.update_mask]
     * field are used. If `updateMask` is not present, the update applies to all
     * fields.
     * The number of
     * [UpdatePhotoRequest][google.streetview.publish.v1.UpdatePhotoRequest]
     * messages in a
     * [BatchUpdatePhotosRequest][google.streetview.publish.v1.BatchUpdatePhotosRequest]
     * must not exceed 20.
     * &gt; Note: To update
     * [Pose.altitude][google.streetview.publish.v1.Pose.altitude],
     * [Pose.latLngPair][google.streetview.publish.v1.Pose.lat_lng_pair] has to be
     * filled as well. Otherwise, the request will fail.
     * </pre>
     */
    public void batchUpdatePhotos(com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchUpdatePhotosRequest request,
        io.grpc.stub.StreamObserver<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchUpdatePhotosResponse> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getBatchUpdatePhotosMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Deletes a [Photo][google.streetview.publish.v1.Photo] and its metadata.
     * This method returns the following error codes:
     * * [google.rpc.Code.PERMISSION_DENIED][google.rpc.Code.PERMISSION_DENIED] if the requesting user did not
     * create the requested photo.
     * * [google.rpc.Code.NOT_FOUND][google.rpc.Code.NOT_FOUND] if the photo ID does not exist.
     * </pre>
     */
    public void deletePhoto(com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.DeletePhotoRequest request,
        io.grpc.stub.StreamObserver<com.google.protobuf.Empty> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getDeletePhotoMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Deletes a list of [Photos][google.streetview.publish.v1.Photo] and their
     * metadata.
     * Note that if
     * [BatchDeletePhotos][google.streetview.publish.v1.StreetViewPublishService.BatchDeletePhotos]
     * fails, either critical fields are missing or there is an authentication
     * error. Even if
     * [BatchDeletePhotos][google.streetview.publish.v1.StreetViewPublishService.BatchDeletePhotos]
     * succeeds, individual photos in the batch may have failures.
     * These failures are specified in each
     * [PhotoResponse.status][google.streetview.publish.v1.PhotoResponse.status]
     * in
     * [BatchDeletePhotosResponse.results][google.streetview.publish.v1.BatchDeletePhotosResponse.status].
     * See
     * [DeletePhoto][google.streetview.publish.v1.StreetViewPublishService.DeletePhoto]
     * for specific failures that can occur per photo.
     * </pre>
     */
    public void batchDeletePhotos(com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchDeletePhotosRequest request,
        io.grpc.stub.StreamObserver<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchDeletePhotosResponse> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getBatchDeletePhotosMethod(), getCallOptions()), request, responseObserver);
    }
  }

  /**
   * <pre>
   * Publishes and connects user-contributed photos on Street View.
   * </pre>
   */
  public static final class StreetViewPublishServiceBlockingStub extends io.grpc.stub.AbstractBlockingStub<StreetViewPublishServiceBlockingStub> {
    private StreetViewPublishServiceBlockingStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected StreetViewPublishServiceBlockingStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new StreetViewPublishServiceBlockingStub(channel, callOptions);
    }

    /**
     * <pre>
     * Creates an upload session to start uploading photo bytes.  The method uses
     * the upload URL of the returned
     * [UploadRef][google.streetview.publish.v1.UploadRef] to upload the bytes for
     * the [Photo][google.streetview.publish.v1.Photo].
     * In addition to the photo requirements shown in
     * https://support.google.com/maps/answer/7012050?ref_topic=6275604,
     * the photo must meet the following requirements:
     * * Photo Sphere XMP metadata must be included in the photo metadata. See
     * https://developers.google.com/streetview/spherical-metadata for the
     * required fields.
     * * The pixel size of the photo must meet the size requirements listed in
     * https://support.google.com/maps/answer/7012050?ref_topic=6275604, and
     * the photo must be a full 360 horizontally.
     * After the upload completes, the method uses
     * [UploadRef][google.streetview.publish.v1.UploadRef] with
     * [CreatePhoto][google.streetview.publish.v1.StreetViewPublishService.CreatePhoto]
     * to create the [Photo][google.streetview.publish.v1.Photo] object entry.
     * </pre>
     */
    public com.google.geo.ugc.streetview.publish.v1.StreetViewPublishResources.UploadRef startUpload(com.google.protobuf.Empty request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getStartUploadMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * After the client finishes uploading the photo with the returned
     * [UploadRef][google.streetview.publish.v1.UploadRef],
     * [CreatePhoto][google.streetview.publish.v1.StreetViewPublishService.CreatePhoto]
     * publishes the uploaded [Photo][google.streetview.publish.v1.Photo] to
     * Street View on Google Maps.
     * Currently, the only way to set heading, pitch, and roll in CreatePhoto is
     * through the [Photo Sphere XMP
     * metadata](https://developers.google.com/streetview/spherical-metadata) in
     * the photo bytes. CreatePhoto ignores the  `pose.heading`, `pose.pitch`,
     * `pose.roll`, `pose.altitude`, and `pose.level` fields in Pose.
     * This method returns the following error codes:
     * * [google.rpc.Code.INVALID_ARGUMENT][google.rpc.Code.INVALID_ARGUMENT] if the request is malformed or if
     * the uploaded photo is not a 360 photo.
     * * [google.rpc.Code.NOT_FOUND][google.rpc.Code.NOT_FOUND] if the upload reference does not exist.
     * * [google.rpc.Code.RESOURCE_EXHAUSTED][google.rpc.Code.RESOURCE_EXHAUSTED] if the account has reached the
     * storage limit.
     * </pre>
     */
    public com.google.geo.ugc.streetview.publish.v1.StreetViewPublishResources.Photo createPhoto(com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.CreatePhotoRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getCreatePhotoMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Gets the metadata of the specified
     * [Photo][google.streetview.publish.v1.Photo].
     * This method returns the following error codes:
     * * [google.rpc.Code.PERMISSION_DENIED][google.rpc.Code.PERMISSION_DENIED] if the requesting user did not
     * create the requested [Photo][google.streetview.publish.v1.Photo].
     * * [google.rpc.Code.NOT_FOUND][google.rpc.Code.NOT_FOUND] if the requested
     * [Photo][google.streetview.publish.v1.Photo] does not exist.
     * * [google.rpc.Code.UNAVAILABLE][google.rpc.Code.UNAVAILABLE] if the requested
     * [Photo][google.streetview.publish.v1.Photo] is still being indexed.
     * </pre>
     */
    public com.google.geo.ugc.streetview.publish.v1.StreetViewPublishResources.Photo getPhoto(com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.GetPhotoRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getGetPhotoMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Gets the metadata of the specified
     * [Photo][google.streetview.publish.v1.Photo] batch.
     * Note that if
     * [BatchGetPhotos][google.streetview.publish.v1.StreetViewPublishService.BatchGetPhotos]
     * fails, either critical fields are missing or there is an authentication
     * error. Even if
     * [BatchGetPhotos][google.streetview.publish.v1.StreetViewPublishService.BatchGetPhotos]
     * succeeds, individual photos in the batch may have failures.
     * These failures are specified in each
     * [PhotoResponse.status][google.streetview.publish.v1.PhotoResponse.status]
     * in
     * [BatchGetPhotosResponse.results][google.streetview.publish.v1.BatchGetPhotosResponse.results].
     * See
     * [GetPhoto][google.streetview.publish.v1.StreetViewPublishService.GetPhoto]
     * for specific failures that can occur per photo.
     * </pre>
     */
    public com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchGetPhotosResponse batchGetPhotos(com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchGetPhotosRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getBatchGetPhotosMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Lists all the [Photos][google.streetview.publish.v1.Photo] that belong to
     * the user.
     * &gt; Note: Recently created photos that are still
     * being indexed are not returned in the response.
     * </pre>
     */
    public com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.ListPhotosResponse listPhotos(com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.ListPhotosRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getListPhotosMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Updates the metadata of a [Photo][google.streetview.publish.v1.Photo], such
     * as pose, place association, connections, etc. Changing the pixels of a
     * photo is not supported.
     * Only the fields specified in the
     * [updateMask][google.streetview.publish.v1.UpdatePhotoRequest.update_mask]
     * field are used. If `updateMask` is not present, the update applies to all
     * fields.
     * This method returns the following error codes:
     * * [google.rpc.Code.PERMISSION_DENIED][google.rpc.Code.PERMISSION_DENIED] if the requesting user did not
     * create the requested photo.
     * * [google.rpc.Code.INVALID_ARGUMENT][google.rpc.Code.INVALID_ARGUMENT] if the request is malformed.
     * * [google.rpc.Code.NOT_FOUND][google.rpc.Code.NOT_FOUND] if the requested photo does not exist.
     * * [google.rpc.Code.UNAVAILABLE][google.rpc.Code.UNAVAILABLE] if the requested
     * [Photo][google.streetview.publish.v1.Photo] is still being indexed.
     * </pre>
     */
    public com.google.geo.ugc.streetview.publish.v1.StreetViewPublishResources.Photo updatePhoto(com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.UpdatePhotoRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getUpdatePhotoMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Updates the metadata of [Photos][google.streetview.publish.v1.Photo], such
     * as pose, place association, connections, etc. Changing the pixels of photos
     * is not supported.
     * Note that if
     * [BatchUpdatePhotos][google.streetview.publish.v1.StreetViewPublishService.BatchUpdatePhotos]
     * fails, either critical fields are missing or there is an authentication
     * error. Even if
     * [BatchUpdatePhotos][google.streetview.publish.v1.StreetViewPublishService.BatchUpdatePhotos]
     * succeeds, individual photos in the batch may have failures.
     * These failures are specified in each
     * [PhotoResponse.status][google.streetview.publish.v1.PhotoResponse.status]
     * in
     * [BatchUpdatePhotosResponse.results][google.streetview.publish.v1.BatchUpdatePhotosResponse.results].
     * See
     * [UpdatePhoto][google.streetview.publish.v1.StreetViewPublishService.UpdatePhoto]
     * for specific failures that can occur per photo.
     * Only the fields specified in
     * [updateMask][google.streetview.publish.v1.UpdatePhotoRequest.update_mask]
     * field are used. If `updateMask` is not present, the update applies to all
     * fields.
     * The number of
     * [UpdatePhotoRequest][google.streetview.publish.v1.UpdatePhotoRequest]
     * messages in a
     * [BatchUpdatePhotosRequest][google.streetview.publish.v1.BatchUpdatePhotosRequest]
     * must not exceed 20.
     * &gt; Note: To update
     * [Pose.altitude][google.streetview.publish.v1.Pose.altitude],
     * [Pose.latLngPair][google.streetview.publish.v1.Pose.lat_lng_pair] has to be
     * filled as well. Otherwise, the request will fail.
     * </pre>
     */
    public com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchUpdatePhotosResponse batchUpdatePhotos(com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchUpdatePhotosRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getBatchUpdatePhotosMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Deletes a [Photo][google.streetview.publish.v1.Photo] and its metadata.
     * This method returns the following error codes:
     * * [google.rpc.Code.PERMISSION_DENIED][google.rpc.Code.PERMISSION_DENIED] if the requesting user did not
     * create the requested photo.
     * * [google.rpc.Code.NOT_FOUND][google.rpc.Code.NOT_FOUND] if the photo ID does not exist.
     * </pre>
     */
    public com.google.protobuf.Empty deletePhoto(com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.DeletePhotoRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getDeletePhotoMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Deletes a list of [Photos][google.streetview.publish.v1.Photo] and their
     * metadata.
     * Note that if
     * [BatchDeletePhotos][google.streetview.publish.v1.StreetViewPublishService.BatchDeletePhotos]
     * fails, either critical fields are missing or there is an authentication
     * error. Even if
     * [BatchDeletePhotos][google.streetview.publish.v1.StreetViewPublishService.BatchDeletePhotos]
     * succeeds, individual photos in the batch may have failures.
     * These failures are specified in each
     * [PhotoResponse.status][google.streetview.publish.v1.PhotoResponse.status]
     * in
     * [BatchDeletePhotosResponse.results][google.streetview.publish.v1.BatchDeletePhotosResponse.status].
     * See
     * [DeletePhoto][google.streetview.publish.v1.StreetViewPublishService.DeletePhoto]
     * for specific failures that can occur per photo.
     * </pre>
     */
    public com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchDeletePhotosResponse batchDeletePhotos(com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchDeletePhotosRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getBatchDeletePhotosMethod(), getCallOptions(), request);
    }
  }

  /**
   * <pre>
   * Publishes and connects user-contributed photos on Street View.
   * </pre>
   */
  public static final class StreetViewPublishServiceFutureStub extends io.grpc.stub.AbstractFutureStub<StreetViewPublishServiceFutureStub> {
    private StreetViewPublishServiceFutureStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected StreetViewPublishServiceFutureStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new StreetViewPublishServiceFutureStub(channel, callOptions);
    }

    /**
     * <pre>
     * Creates an upload session to start uploading photo bytes.  The method uses
     * the upload URL of the returned
     * [UploadRef][google.streetview.publish.v1.UploadRef] to upload the bytes for
     * the [Photo][google.streetview.publish.v1.Photo].
     * In addition to the photo requirements shown in
     * https://support.google.com/maps/answer/7012050?ref_topic=6275604,
     * the photo must meet the following requirements:
     * * Photo Sphere XMP metadata must be included in the photo metadata. See
     * https://developers.google.com/streetview/spherical-metadata for the
     * required fields.
     * * The pixel size of the photo must meet the size requirements listed in
     * https://support.google.com/maps/answer/7012050?ref_topic=6275604, and
     * the photo must be a full 360 horizontally.
     * After the upload completes, the method uses
     * [UploadRef][google.streetview.publish.v1.UploadRef] with
     * [CreatePhoto][google.streetview.publish.v1.StreetViewPublishService.CreatePhoto]
     * to create the [Photo][google.streetview.publish.v1.Photo] object entry.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishResources.UploadRef> startUpload(
        com.google.protobuf.Empty request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getStartUploadMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * After the client finishes uploading the photo with the returned
     * [UploadRef][google.streetview.publish.v1.UploadRef],
     * [CreatePhoto][google.streetview.publish.v1.StreetViewPublishService.CreatePhoto]
     * publishes the uploaded [Photo][google.streetview.publish.v1.Photo] to
     * Street View on Google Maps.
     * Currently, the only way to set heading, pitch, and roll in CreatePhoto is
     * through the [Photo Sphere XMP
     * metadata](https://developers.google.com/streetview/spherical-metadata) in
     * the photo bytes. CreatePhoto ignores the  `pose.heading`, `pose.pitch`,
     * `pose.roll`, `pose.altitude`, and `pose.level` fields in Pose.
     * This method returns the following error codes:
     * * [google.rpc.Code.INVALID_ARGUMENT][google.rpc.Code.INVALID_ARGUMENT] if the request is malformed or if
     * the uploaded photo is not a 360 photo.
     * * [google.rpc.Code.NOT_FOUND][google.rpc.Code.NOT_FOUND] if the upload reference does not exist.
     * * [google.rpc.Code.RESOURCE_EXHAUSTED][google.rpc.Code.RESOURCE_EXHAUSTED] if the account has reached the
     * storage limit.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishResources.Photo> createPhoto(
        com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.CreatePhotoRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getCreatePhotoMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Gets the metadata of the specified
     * [Photo][google.streetview.publish.v1.Photo].
     * This method returns the following error codes:
     * * [google.rpc.Code.PERMISSION_DENIED][google.rpc.Code.PERMISSION_DENIED] if the requesting user did not
     * create the requested [Photo][google.streetview.publish.v1.Photo].
     * * [google.rpc.Code.NOT_FOUND][google.rpc.Code.NOT_FOUND] if the requested
     * [Photo][google.streetview.publish.v1.Photo] does not exist.
     * * [google.rpc.Code.UNAVAILABLE][google.rpc.Code.UNAVAILABLE] if the requested
     * [Photo][google.streetview.publish.v1.Photo] is still being indexed.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishResources.Photo> getPhoto(
        com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.GetPhotoRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getGetPhotoMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Gets the metadata of the specified
     * [Photo][google.streetview.publish.v1.Photo] batch.
     * Note that if
     * [BatchGetPhotos][google.streetview.publish.v1.StreetViewPublishService.BatchGetPhotos]
     * fails, either critical fields are missing or there is an authentication
     * error. Even if
     * [BatchGetPhotos][google.streetview.publish.v1.StreetViewPublishService.BatchGetPhotos]
     * succeeds, individual photos in the batch may have failures.
     * These failures are specified in each
     * [PhotoResponse.status][google.streetview.publish.v1.PhotoResponse.status]
     * in
     * [BatchGetPhotosResponse.results][google.streetview.publish.v1.BatchGetPhotosResponse.results].
     * See
     * [GetPhoto][google.streetview.publish.v1.StreetViewPublishService.GetPhoto]
     * for specific failures that can occur per photo.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchGetPhotosResponse> batchGetPhotos(
        com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchGetPhotosRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getBatchGetPhotosMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Lists all the [Photos][google.streetview.publish.v1.Photo] that belong to
     * the user.
     * &gt; Note: Recently created photos that are still
     * being indexed are not returned in the response.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.ListPhotosResponse> listPhotos(
        com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.ListPhotosRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getListPhotosMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Updates the metadata of a [Photo][google.streetview.publish.v1.Photo], such
     * as pose, place association, connections, etc. Changing the pixels of a
     * photo is not supported.
     * Only the fields specified in the
     * [updateMask][google.streetview.publish.v1.UpdatePhotoRequest.update_mask]
     * field are used. If `updateMask` is not present, the update applies to all
     * fields.
     * This method returns the following error codes:
     * * [google.rpc.Code.PERMISSION_DENIED][google.rpc.Code.PERMISSION_DENIED] if the requesting user did not
     * create the requested photo.
     * * [google.rpc.Code.INVALID_ARGUMENT][google.rpc.Code.INVALID_ARGUMENT] if the request is malformed.
     * * [google.rpc.Code.NOT_FOUND][google.rpc.Code.NOT_FOUND] if the requested photo does not exist.
     * * [google.rpc.Code.UNAVAILABLE][google.rpc.Code.UNAVAILABLE] if the requested
     * [Photo][google.streetview.publish.v1.Photo] is still being indexed.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishResources.Photo> updatePhoto(
        com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.UpdatePhotoRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getUpdatePhotoMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Updates the metadata of [Photos][google.streetview.publish.v1.Photo], such
     * as pose, place association, connections, etc. Changing the pixels of photos
     * is not supported.
     * Note that if
     * [BatchUpdatePhotos][google.streetview.publish.v1.StreetViewPublishService.BatchUpdatePhotos]
     * fails, either critical fields are missing or there is an authentication
     * error. Even if
     * [BatchUpdatePhotos][google.streetview.publish.v1.StreetViewPublishService.BatchUpdatePhotos]
     * succeeds, individual photos in the batch may have failures.
     * These failures are specified in each
     * [PhotoResponse.status][google.streetview.publish.v1.PhotoResponse.status]
     * in
     * [BatchUpdatePhotosResponse.results][google.streetview.publish.v1.BatchUpdatePhotosResponse.results].
     * See
     * [UpdatePhoto][google.streetview.publish.v1.StreetViewPublishService.UpdatePhoto]
     * for specific failures that can occur per photo.
     * Only the fields specified in
     * [updateMask][google.streetview.publish.v1.UpdatePhotoRequest.update_mask]
     * field are used. If `updateMask` is not present, the update applies to all
     * fields.
     * The number of
     * [UpdatePhotoRequest][google.streetview.publish.v1.UpdatePhotoRequest]
     * messages in a
     * [BatchUpdatePhotosRequest][google.streetview.publish.v1.BatchUpdatePhotosRequest]
     * must not exceed 20.
     * &gt; Note: To update
     * [Pose.altitude][google.streetview.publish.v1.Pose.altitude],
     * [Pose.latLngPair][google.streetview.publish.v1.Pose.lat_lng_pair] has to be
     * filled as well. Otherwise, the request will fail.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchUpdatePhotosResponse> batchUpdatePhotos(
        com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchUpdatePhotosRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getBatchUpdatePhotosMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Deletes a [Photo][google.streetview.publish.v1.Photo] and its metadata.
     * This method returns the following error codes:
     * * [google.rpc.Code.PERMISSION_DENIED][google.rpc.Code.PERMISSION_DENIED] if the requesting user did not
     * create the requested photo.
     * * [google.rpc.Code.NOT_FOUND][google.rpc.Code.NOT_FOUND] if the photo ID does not exist.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.protobuf.Empty> deletePhoto(
        com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.DeletePhotoRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getDeletePhotoMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Deletes a list of [Photos][google.streetview.publish.v1.Photo] and their
     * metadata.
     * Note that if
     * [BatchDeletePhotos][google.streetview.publish.v1.StreetViewPublishService.BatchDeletePhotos]
     * fails, either critical fields are missing or there is an authentication
     * error. Even if
     * [BatchDeletePhotos][google.streetview.publish.v1.StreetViewPublishService.BatchDeletePhotos]
     * succeeds, individual photos in the batch may have failures.
     * These failures are specified in each
     * [PhotoResponse.status][google.streetview.publish.v1.PhotoResponse.status]
     * in
     * [BatchDeletePhotosResponse.results][google.streetview.publish.v1.BatchDeletePhotosResponse.status].
     * See
     * [DeletePhoto][google.streetview.publish.v1.StreetViewPublishService.DeletePhoto]
     * for specific failures that can occur per photo.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchDeletePhotosResponse> batchDeletePhotos(
        com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchDeletePhotosRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getBatchDeletePhotosMethod(), getCallOptions()), request);
    }
  }

  private static final int METHODID_START_UPLOAD = 0;
  private static final int METHODID_CREATE_PHOTO = 1;
  private static final int METHODID_GET_PHOTO = 2;
  private static final int METHODID_BATCH_GET_PHOTOS = 3;
  private static final int METHODID_LIST_PHOTOS = 4;
  private static final int METHODID_UPDATE_PHOTO = 5;
  private static final int METHODID_BATCH_UPDATE_PHOTOS = 6;
  private static final int METHODID_DELETE_PHOTO = 7;
  private static final int METHODID_BATCH_DELETE_PHOTOS = 8;

  private static final class MethodHandlers<Req, Resp> implements
      io.grpc.stub.ServerCalls.UnaryMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ServerStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ClientStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.BidiStreamingMethod<Req, Resp> {
    private final StreetViewPublishServiceImplBase serviceImpl;
    private final int methodId;

    MethodHandlers(StreetViewPublishServiceImplBase serviceImpl, int methodId) {
      this.serviceImpl = serviceImpl;
      this.methodId = methodId;
    }

    @java.lang.Override
    @java.lang.SuppressWarnings("unchecked")
    public void invoke(Req request, io.grpc.stub.StreamObserver<Resp> responseObserver) {
      switch (methodId) {
        case METHODID_START_UPLOAD:
          serviceImpl.startUpload((com.google.protobuf.Empty) request,
              (io.grpc.stub.StreamObserver<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishResources.UploadRef>) responseObserver);
          break;
        case METHODID_CREATE_PHOTO:
          serviceImpl.createPhoto((com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.CreatePhotoRequest) request,
              (io.grpc.stub.StreamObserver<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishResources.Photo>) responseObserver);
          break;
        case METHODID_GET_PHOTO:
          serviceImpl.getPhoto((com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.GetPhotoRequest) request,
              (io.grpc.stub.StreamObserver<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishResources.Photo>) responseObserver);
          break;
        case METHODID_BATCH_GET_PHOTOS:
          serviceImpl.batchGetPhotos((com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchGetPhotosRequest) request,
              (io.grpc.stub.StreamObserver<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchGetPhotosResponse>) responseObserver);
          break;
        case METHODID_LIST_PHOTOS:
          serviceImpl.listPhotos((com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.ListPhotosRequest) request,
              (io.grpc.stub.StreamObserver<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.ListPhotosResponse>) responseObserver);
          break;
        case METHODID_UPDATE_PHOTO:
          serviceImpl.updatePhoto((com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.UpdatePhotoRequest) request,
              (io.grpc.stub.StreamObserver<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishResources.Photo>) responseObserver);
          break;
        case METHODID_BATCH_UPDATE_PHOTOS:
          serviceImpl.batchUpdatePhotos((com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchUpdatePhotosRequest) request,
              (io.grpc.stub.StreamObserver<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchUpdatePhotosResponse>) responseObserver);
          break;
        case METHODID_DELETE_PHOTO:
          serviceImpl.deletePhoto((com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.DeletePhotoRequest) request,
              (io.grpc.stub.StreamObserver<com.google.protobuf.Empty>) responseObserver);
          break;
        case METHODID_BATCH_DELETE_PHOTOS:
          serviceImpl.batchDeletePhotos((com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchDeletePhotosRequest) request,
              (io.grpc.stub.StreamObserver<com.google.geo.ugc.streetview.publish.v1.StreetViewPublishRpcMessages.BatchDeletePhotosResponse>) responseObserver);
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

  private static abstract class StreetViewPublishServiceBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoFileDescriptorSupplier, io.grpc.protobuf.ProtoServiceDescriptorSupplier {
    StreetViewPublishServiceBaseDescriptorSupplier() {}

    @java.lang.Override
    public com.google.protobuf.Descriptors.FileDescriptor getFileDescriptor() {
      return com.google.geo.ugc.streetview.publish.v1.StreetViewPublish.getDescriptor();
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.ServiceDescriptor getServiceDescriptor() {
      return getFileDescriptor().findServiceByName("StreetViewPublishService");
    }
  }

  private static final class StreetViewPublishServiceFileDescriptorSupplier
      extends StreetViewPublishServiceBaseDescriptorSupplier {
    StreetViewPublishServiceFileDescriptorSupplier() {}
  }

  private static final class StreetViewPublishServiceMethodDescriptorSupplier
      extends StreetViewPublishServiceBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoMethodDescriptorSupplier {
    private final String methodName;

    StreetViewPublishServiceMethodDescriptorSupplier(String methodName) {
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
      synchronized (StreetViewPublishServiceGrpc.class) {
        result = serviceDescriptor;
        if (result == null) {
          serviceDescriptor = result = io.grpc.ServiceDescriptor.newBuilder(SERVICE_NAME)
              .setSchemaDescriptor(new StreetViewPublishServiceFileDescriptorSupplier())
              .addMethod(getStartUploadMethod())
              .addMethod(getCreatePhotoMethod())
              .addMethod(getGetPhotoMethod())
              .addMethod(getBatchGetPhotosMethod())
              .addMethod(getListPhotosMethod())
              .addMethod(getUpdatePhotoMethod())
              .addMethod(getBatchUpdatePhotosMethod())
              .addMethod(getDeletePhotoMethod())
              .addMethod(getBatchDeletePhotosMethod())
              .build();
        }
      }
    }
    return result;
  }
}
