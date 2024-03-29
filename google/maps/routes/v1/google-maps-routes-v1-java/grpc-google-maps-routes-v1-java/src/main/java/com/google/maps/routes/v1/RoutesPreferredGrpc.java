package com.google.maps.routes.v1;

import static io.grpc.MethodDescriptor.generateFullMethodName;

/**
 * <pre>
 * The Routes Preferred API.
 * </pre>
 */
@javax.annotation.Generated(
    value = "by gRPC proto compiler",
    comments = "Source: google/maps/routes/v1/route_service.proto")
@io.grpc.stub.annotations.GrpcGenerated
public final class RoutesPreferredGrpc {

  private RoutesPreferredGrpc() {}

  public static final String SERVICE_NAME = "google.maps.routes.v1.RoutesPreferred";

  // Static method descriptors that strictly reflect the proto.
  private static volatile io.grpc.MethodDescriptor<com.google.maps.routes.v1.ComputeRoutesRequest,
      com.google.maps.routes.v1.ComputeRoutesResponse> getComputeRoutesMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "ComputeRoutes",
      requestType = com.google.maps.routes.v1.ComputeRoutesRequest.class,
      responseType = com.google.maps.routes.v1.ComputeRoutesResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.maps.routes.v1.ComputeRoutesRequest,
      com.google.maps.routes.v1.ComputeRoutesResponse> getComputeRoutesMethod() {
    io.grpc.MethodDescriptor<com.google.maps.routes.v1.ComputeRoutesRequest, com.google.maps.routes.v1.ComputeRoutesResponse> getComputeRoutesMethod;
    if ((getComputeRoutesMethod = RoutesPreferredGrpc.getComputeRoutesMethod) == null) {
      synchronized (RoutesPreferredGrpc.class) {
        if ((getComputeRoutesMethod = RoutesPreferredGrpc.getComputeRoutesMethod) == null) {
          RoutesPreferredGrpc.getComputeRoutesMethod = getComputeRoutesMethod =
              io.grpc.MethodDescriptor.<com.google.maps.routes.v1.ComputeRoutesRequest, com.google.maps.routes.v1.ComputeRoutesResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "ComputeRoutes"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.maps.routes.v1.ComputeRoutesRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.maps.routes.v1.ComputeRoutesResponse.getDefaultInstance()))
              .setSchemaDescriptor(new RoutesPreferredMethodDescriptorSupplier("ComputeRoutes"))
              .build();
        }
      }
    }
    return getComputeRoutesMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.maps.routes.v1.ComputeRouteMatrixRequest,
      com.google.maps.routes.v1.RouteMatrixElement> getComputeRouteMatrixMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "ComputeRouteMatrix",
      requestType = com.google.maps.routes.v1.ComputeRouteMatrixRequest.class,
      responseType = com.google.maps.routes.v1.RouteMatrixElement.class,
      methodType = io.grpc.MethodDescriptor.MethodType.SERVER_STREAMING)
  public static io.grpc.MethodDescriptor<com.google.maps.routes.v1.ComputeRouteMatrixRequest,
      com.google.maps.routes.v1.RouteMatrixElement> getComputeRouteMatrixMethod() {
    io.grpc.MethodDescriptor<com.google.maps.routes.v1.ComputeRouteMatrixRequest, com.google.maps.routes.v1.RouteMatrixElement> getComputeRouteMatrixMethod;
    if ((getComputeRouteMatrixMethod = RoutesPreferredGrpc.getComputeRouteMatrixMethod) == null) {
      synchronized (RoutesPreferredGrpc.class) {
        if ((getComputeRouteMatrixMethod = RoutesPreferredGrpc.getComputeRouteMatrixMethod) == null) {
          RoutesPreferredGrpc.getComputeRouteMatrixMethod = getComputeRouteMatrixMethod =
              io.grpc.MethodDescriptor.<com.google.maps.routes.v1.ComputeRouteMatrixRequest, com.google.maps.routes.v1.RouteMatrixElement>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.SERVER_STREAMING)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "ComputeRouteMatrix"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.maps.routes.v1.ComputeRouteMatrixRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.maps.routes.v1.RouteMatrixElement.getDefaultInstance()))
              .setSchemaDescriptor(new RoutesPreferredMethodDescriptorSupplier("ComputeRouteMatrix"))
              .build();
        }
      }
    }
    return getComputeRouteMatrixMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.maps.routes.v1.ComputeCustomRoutesRequest,
      com.google.maps.routes.v1.ComputeCustomRoutesResponse> getComputeCustomRoutesMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "ComputeCustomRoutes",
      requestType = com.google.maps.routes.v1.ComputeCustomRoutesRequest.class,
      responseType = com.google.maps.routes.v1.ComputeCustomRoutesResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.maps.routes.v1.ComputeCustomRoutesRequest,
      com.google.maps.routes.v1.ComputeCustomRoutesResponse> getComputeCustomRoutesMethod() {
    io.grpc.MethodDescriptor<com.google.maps.routes.v1.ComputeCustomRoutesRequest, com.google.maps.routes.v1.ComputeCustomRoutesResponse> getComputeCustomRoutesMethod;
    if ((getComputeCustomRoutesMethod = RoutesPreferredGrpc.getComputeCustomRoutesMethod) == null) {
      synchronized (RoutesPreferredGrpc.class) {
        if ((getComputeCustomRoutesMethod = RoutesPreferredGrpc.getComputeCustomRoutesMethod) == null) {
          RoutesPreferredGrpc.getComputeCustomRoutesMethod = getComputeCustomRoutesMethod =
              io.grpc.MethodDescriptor.<com.google.maps.routes.v1.ComputeCustomRoutesRequest, com.google.maps.routes.v1.ComputeCustomRoutesResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "ComputeCustomRoutes"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.maps.routes.v1.ComputeCustomRoutesRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.maps.routes.v1.ComputeCustomRoutesResponse.getDefaultInstance()))
              .setSchemaDescriptor(new RoutesPreferredMethodDescriptorSupplier("ComputeCustomRoutes"))
              .build();
        }
      }
    }
    return getComputeCustomRoutesMethod;
  }

  /**
   * Creates a new async stub that supports all call types for the service
   */
  public static RoutesPreferredStub newStub(io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<RoutesPreferredStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<RoutesPreferredStub>() {
        @java.lang.Override
        public RoutesPreferredStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new RoutesPreferredStub(channel, callOptions);
        }
      };
    return RoutesPreferredStub.newStub(factory, channel);
  }

  /**
   * Creates a new blocking-style stub that supports unary and streaming output calls on the service
   */
  public static RoutesPreferredBlockingStub newBlockingStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<RoutesPreferredBlockingStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<RoutesPreferredBlockingStub>() {
        @java.lang.Override
        public RoutesPreferredBlockingStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new RoutesPreferredBlockingStub(channel, callOptions);
        }
      };
    return RoutesPreferredBlockingStub.newStub(factory, channel);
  }

  /**
   * Creates a new ListenableFuture-style stub that supports unary calls on the service
   */
  public static RoutesPreferredFutureStub newFutureStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<RoutesPreferredFutureStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<RoutesPreferredFutureStub>() {
        @java.lang.Override
        public RoutesPreferredFutureStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new RoutesPreferredFutureStub(channel, callOptions);
        }
      };
    return RoutesPreferredFutureStub.newStub(factory, channel);
  }

  /**
   * <pre>
   * The Routes Preferred API.
   * </pre>
   */
  public static abstract class RoutesPreferredImplBase implements io.grpc.BindableService {

    /**
     * <pre>
     * Returns the primary route along with optional alternate routes, given a set
     * of terminal and intermediate waypoints.
     * **NOTE:** This method requires that you specify a response field mask in
     * the input. You can provide the response field mask by using URL parameter
     * `$fields` or `fields`, or by using an HTTP/gRPC header `X-Goog-FieldMask`
     * (see the [available URL parameters and
     * headers](https://cloud.google.com/apis/docs/system-parameters). The value
     * is a comma separated list of field paths. See detailed documentation about
     * [how to construct the field
     * paths](https://github.com/protocolbuffers/protobuf/blob/master/src/google/protobuf/field_mask.proto).
     * For example, in this method:
     * * Field mask of all available fields (for manual inspection):
     *   `X-Goog-FieldMask: *`
     * * Field mask of Route-level duration, distance, and polyline (an example
     * production setup):
     *   `X-Goog-FieldMask:
     *   routes.duration,routes.distanceMeters,routes.polyline.encodedPolyline`
     * Google discourage the use of the wildcard (`*`) response field mask, or
     * specifying the field mask at the top level (`routes`), because:
     * * Selecting only the fields that you need helps our server save computation
     * cycles, allowing us to return the result to you with a lower latency.
     * * Selecting only the fields that you need
     * in your production job ensures stable latency performance. We might add
     * more response fields in the future, and those new fields might require
     * extra computation time. If you select all fields, or if you select all
     * fields at the top level, then you might experience performance degradation
     * because any new field we add will be automatically included in the
     * response.
     * * Selecting only the fields that you need results in a smaller response
     * size, and thus higher network throughput.
     * </pre>
     */
    public void computeRoutes(com.google.maps.routes.v1.ComputeRoutesRequest request,
        io.grpc.stub.StreamObserver<com.google.maps.routes.v1.ComputeRoutesResponse> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getComputeRoutesMethod(), responseObserver);
    }

    /**
     * <pre>
     * Takes in a list of origins and destinations and returns a stream containing
     * route information for each combination of origin and destination.
     * **NOTE:** This method requires that you specify a response field mask in
     * the input. You can provide the response field mask by using the URL
     * parameter `$fields` or `fields`, or by using the HTTP/gRPC header
     * `X-Goog-FieldMask` (see the [available URL parameters and
     * headers](https://cloud.google.com/apis/docs/system-parameters). The value
     * is a comma separated list of field paths. See this detailed documentation
     * about [how to construct the field
     * paths](https://github.com/protocolbuffers/protobuf/blob/master/src/google/protobuf/field_mask.proto).
     * For example, in this method:
     * * Field mask of all available fields (for manual inspection):
     *   `X-Goog-FieldMask: *`
     * * Field mask of route durations, distances, element status, condition, and
     *   element indices (an example production setup):
     *   `X-Goog-FieldMask:
     *   originIndex,destinationIndex,status,condition,distanceMeters,duration`
     * It is critical that you include `status` in your field mask as otherwise
     * all messages will appear to be OK. Google discourages the use of the
     * wildcard (`*`) response field mask, because:
     * * Selecting only the fields that you need helps our server save computation
     * cycles, allowing us to return the result to you with a lower latency.
     * * Selecting only the fields that you need in your production job ensures
     * stable latency performance. We might add more response fields in the
     * future, and those new fields might require extra computation time. If you
     * select all fields, or if you select all fields at the top level, then you
     * might experience performance degradation because any new field we add will
     * be automatically included in the response.
     * * Selecting only the fields that you need results in a smaller response
     * size, and thus higher network throughput.
     * </pre>
     */
    public void computeRouteMatrix(com.google.maps.routes.v1.ComputeRouteMatrixRequest request,
        io.grpc.stub.StreamObserver<com.google.maps.routes.v1.RouteMatrixElement> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getComputeRouteMatrixMethod(), responseObserver);
    }

    /**
     * <pre>
     * Given a set of terminal and intermediate waypoints, and a route objective,
     * computes the best route for the route objective. Also returns fastest route
     * and shortest route as reference routes.
     * **NOTE:** This method requires that you specify a response field mask in
     * the input. You can provide the response field mask by using the URL
     * parameter `$fields` or `fields`, or by using the HTTP/gRPC header
     * `X-Goog-FieldMask` (see the [available URL parameters and
     * headers](https://cloud.google.com/apis/docs/system-parameters). The value
     * is a comma separated list of field paths. See this detailed documentation
     * about [how to construct the field
     * paths](https://github.com/protocolbuffers/protobuf/blob/master/src/google/protobuf/field_mask.proto).
     * For example, in this method:
     * * Field mask of all available fields (for manual inspection):
     *   `X-Goog-FieldMask: *`
     * * Field mask of route distances, durations, token and toll info:
     *   `X-Goog-FieldMask:
     *   routes.route.distanceMeters,routes.route.duration,routes.token,routes.route.travelAdvisory.tollInfo`
     * Google discourages the use of the wildcard (`*`) response field mask, or
     * specifying the field mask at the top level (`routes`), because:
     * * Selecting only the fields that you need helps our server save computation
     * cycles, allowing us to return the result to you with a lower latency.
     * * Selecting only the fields that you need in your production job ensures
     * stable latency performance. We might add more response fields in the
     * future, and those new fields might require extra computation time. If you
     * select all fields, or if you select all fields at the top level, then you
     * might experience performance degradation because any new field we add will
     * be automatically included in the response.
     * * Selecting only the fields that you need results in a smaller response
     * size, and thus higher network throughput.
     * </pre>
     */
    public void computeCustomRoutes(com.google.maps.routes.v1.ComputeCustomRoutesRequest request,
        io.grpc.stub.StreamObserver<com.google.maps.routes.v1.ComputeCustomRoutesResponse> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getComputeCustomRoutesMethod(), responseObserver);
    }

    @java.lang.Override public final io.grpc.ServerServiceDefinition bindService() {
      return io.grpc.ServerServiceDefinition.builder(getServiceDescriptor())
          .addMethod(
            getComputeRoutesMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.maps.routes.v1.ComputeRoutesRequest,
                com.google.maps.routes.v1.ComputeRoutesResponse>(
                  this, METHODID_COMPUTE_ROUTES)))
          .addMethod(
            getComputeRouteMatrixMethod(),
            io.grpc.stub.ServerCalls.asyncServerStreamingCall(
              new MethodHandlers<
                com.google.maps.routes.v1.ComputeRouteMatrixRequest,
                com.google.maps.routes.v1.RouteMatrixElement>(
                  this, METHODID_COMPUTE_ROUTE_MATRIX)))
          .addMethod(
            getComputeCustomRoutesMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.maps.routes.v1.ComputeCustomRoutesRequest,
                com.google.maps.routes.v1.ComputeCustomRoutesResponse>(
                  this, METHODID_COMPUTE_CUSTOM_ROUTES)))
          .build();
    }
  }

  /**
   * <pre>
   * The Routes Preferred API.
   * </pre>
   */
  public static final class RoutesPreferredStub extends io.grpc.stub.AbstractAsyncStub<RoutesPreferredStub> {
    private RoutesPreferredStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected RoutesPreferredStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new RoutesPreferredStub(channel, callOptions);
    }

    /**
     * <pre>
     * Returns the primary route along with optional alternate routes, given a set
     * of terminal and intermediate waypoints.
     * **NOTE:** This method requires that you specify a response field mask in
     * the input. You can provide the response field mask by using URL parameter
     * `$fields` or `fields`, or by using an HTTP/gRPC header `X-Goog-FieldMask`
     * (see the [available URL parameters and
     * headers](https://cloud.google.com/apis/docs/system-parameters). The value
     * is a comma separated list of field paths. See detailed documentation about
     * [how to construct the field
     * paths](https://github.com/protocolbuffers/protobuf/blob/master/src/google/protobuf/field_mask.proto).
     * For example, in this method:
     * * Field mask of all available fields (for manual inspection):
     *   `X-Goog-FieldMask: *`
     * * Field mask of Route-level duration, distance, and polyline (an example
     * production setup):
     *   `X-Goog-FieldMask:
     *   routes.duration,routes.distanceMeters,routes.polyline.encodedPolyline`
     * Google discourage the use of the wildcard (`*`) response field mask, or
     * specifying the field mask at the top level (`routes`), because:
     * * Selecting only the fields that you need helps our server save computation
     * cycles, allowing us to return the result to you with a lower latency.
     * * Selecting only the fields that you need
     * in your production job ensures stable latency performance. We might add
     * more response fields in the future, and those new fields might require
     * extra computation time. If you select all fields, or if you select all
     * fields at the top level, then you might experience performance degradation
     * because any new field we add will be automatically included in the
     * response.
     * * Selecting only the fields that you need results in a smaller response
     * size, and thus higher network throughput.
     * </pre>
     */
    public void computeRoutes(com.google.maps.routes.v1.ComputeRoutesRequest request,
        io.grpc.stub.StreamObserver<com.google.maps.routes.v1.ComputeRoutesResponse> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getComputeRoutesMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Takes in a list of origins and destinations and returns a stream containing
     * route information for each combination of origin and destination.
     * **NOTE:** This method requires that you specify a response field mask in
     * the input. You can provide the response field mask by using the URL
     * parameter `$fields` or `fields`, or by using the HTTP/gRPC header
     * `X-Goog-FieldMask` (see the [available URL parameters and
     * headers](https://cloud.google.com/apis/docs/system-parameters). The value
     * is a comma separated list of field paths. See this detailed documentation
     * about [how to construct the field
     * paths](https://github.com/protocolbuffers/protobuf/blob/master/src/google/protobuf/field_mask.proto).
     * For example, in this method:
     * * Field mask of all available fields (for manual inspection):
     *   `X-Goog-FieldMask: *`
     * * Field mask of route durations, distances, element status, condition, and
     *   element indices (an example production setup):
     *   `X-Goog-FieldMask:
     *   originIndex,destinationIndex,status,condition,distanceMeters,duration`
     * It is critical that you include `status` in your field mask as otherwise
     * all messages will appear to be OK. Google discourages the use of the
     * wildcard (`*`) response field mask, because:
     * * Selecting only the fields that you need helps our server save computation
     * cycles, allowing us to return the result to you with a lower latency.
     * * Selecting only the fields that you need in your production job ensures
     * stable latency performance. We might add more response fields in the
     * future, and those new fields might require extra computation time. If you
     * select all fields, or if you select all fields at the top level, then you
     * might experience performance degradation because any new field we add will
     * be automatically included in the response.
     * * Selecting only the fields that you need results in a smaller response
     * size, and thus higher network throughput.
     * </pre>
     */
    public void computeRouteMatrix(com.google.maps.routes.v1.ComputeRouteMatrixRequest request,
        io.grpc.stub.StreamObserver<com.google.maps.routes.v1.RouteMatrixElement> responseObserver) {
      io.grpc.stub.ClientCalls.asyncServerStreamingCall(
          getChannel().newCall(getComputeRouteMatrixMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Given a set of terminal and intermediate waypoints, and a route objective,
     * computes the best route for the route objective. Also returns fastest route
     * and shortest route as reference routes.
     * **NOTE:** This method requires that you specify a response field mask in
     * the input. You can provide the response field mask by using the URL
     * parameter `$fields` or `fields`, or by using the HTTP/gRPC header
     * `X-Goog-FieldMask` (see the [available URL parameters and
     * headers](https://cloud.google.com/apis/docs/system-parameters). The value
     * is a comma separated list of field paths. See this detailed documentation
     * about [how to construct the field
     * paths](https://github.com/protocolbuffers/protobuf/blob/master/src/google/protobuf/field_mask.proto).
     * For example, in this method:
     * * Field mask of all available fields (for manual inspection):
     *   `X-Goog-FieldMask: *`
     * * Field mask of route distances, durations, token and toll info:
     *   `X-Goog-FieldMask:
     *   routes.route.distanceMeters,routes.route.duration,routes.token,routes.route.travelAdvisory.tollInfo`
     * Google discourages the use of the wildcard (`*`) response field mask, or
     * specifying the field mask at the top level (`routes`), because:
     * * Selecting only the fields that you need helps our server save computation
     * cycles, allowing us to return the result to you with a lower latency.
     * * Selecting only the fields that you need in your production job ensures
     * stable latency performance. We might add more response fields in the
     * future, and those new fields might require extra computation time. If you
     * select all fields, or if you select all fields at the top level, then you
     * might experience performance degradation because any new field we add will
     * be automatically included in the response.
     * * Selecting only the fields that you need results in a smaller response
     * size, and thus higher network throughput.
     * </pre>
     */
    public void computeCustomRoutes(com.google.maps.routes.v1.ComputeCustomRoutesRequest request,
        io.grpc.stub.StreamObserver<com.google.maps.routes.v1.ComputeCustomRoutesResponse> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getComputeCustomRoutesMethod(), getCallOptions()), request, responseObserver);
    }
  }

  /**
   * <pre>
   * The Routes Preferred API.
   * </pre>
   */
  public static final class RoutesPreferredBlockingStub extends io.grpc.stub.AbstractBlockingStub<RoutesPreferredBlockingStub> {
    private RoutesPreferredBlockingStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected RoutesPreferredBlockingStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new RoutesPreferredBlockingStub(channel, callOptions);
    }

    /**
     * <pre>
     * Returns the primary route along with optional alternate routes, given a set
     * of terminal and intermediate waypoints.
     * **NOTE:** This method requires that you specify a response field mask in
     * the input. You can provide the response field mask by using URL parameter
     * `$fields` or `fields`, or by using an HTTP/gRPC header `X-Goog-FieldMask`
     * (see the [available URL parameters and
     * headers](https://cloud.google.com/apis/docs/system-parameters). The value
     * is a comma separated list of field paths. See detailed documentation about
     * [how to construct the field
     * paths](https://github.com/protocolbuffers/protobuf/blob/master/src/google/protobuf/field_mask.proto).
     * For example, in this method:
     * * Field mask of all available fields (for manual inspection):
     *   `X-Goog-FieldMask: *`
     * * Field mask of Route-level duration, distance, and polyline (an example
     * production setup):
     *   `X-Goog-FieldMask:
     *   routes.duration,routes.distanceMeters,routes.polyline.encodedPolyline`
     * Google discourage the use of the wildcard (`*`) response field mask, or
     * specifying the field mask at the top level (`routes`), because:
     * * Selecting only the fields that you need helps our server save computation
     * cycles, allowing us to return the result to you with a lower latency.
     * * Selecting only the fields that you need
     * in your production job ensures stable latency performance. We might add
     * more response fields in the future, and those new fields might require
     * extra computation time. If you select all fields, or if you select all
     * fields at the top level, then you might experience performance degradation
     * because any new field we add will be automatically included in the
     * response.
     * * Selecting only the fields that you need results in a smaller response
     * size, and thus higher network throughput.
     * </pre>
     */
    public com.google.maps.routes.v1.ComputeRoutesResponse computeRoutes(com.google.maps.routes.v1.ComputeRoutesRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getComputeRoutesMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Takes in a list of origins and destinations and returns a stream containing
     * route information for each combination of origin and destination.
     * **NOTE:** This method requires that you specify a response field mask in
     * the input. You can provide the response field mask by using the URL
     * parameter `$fields` or `fields`, or by using the HTTP/gRPC header
     * `X-Goog-FieldMask` (see the [available URL parameters and
     * headers](https://cloud.google.com/apis/docs/system-parameters). The value
     * is a comma separated list of field paths. See this detailed documentation
     * about [how to construct the field
     * paths](https://github.com/protocolbuffers/protobuf/blob/master/src/google/protobuf/field_mask.proto).
     * For example, in this method:
     * * Field mask of all available fields (for manual inspection):
     *   `X-Goog-FieldMask: *`
     * * Field mask of route durations, distances, element status, condition, and
     *   element indices (an example production setup):
     *   `X-Goog-FieldMask:
     *   originIndex,destinationIndex,status,condition,distanceMeters,duration`
     * It is critical that you include `status` in your field mask as otherwise
     * all messages will appear to be OK. Google discourages the use of the
     * wildcard (`*`) response field mask, because:
     * * Selecting only the fields that you need helps our server save computation
     * cycles, allowing us to return the result to you with a lower latency.
     * * Selecting only the fields that you need in your production job ensures
     * stable latency performance. We might add more response fields in the
     * future, and those new fields might require extra computation time. If you
     * select all fields, or if you select all fields at the top level, then you
     * might experience performance degradation because any new field we add will
     * be automatically included in the response.
     * * Selecting only the fields that you need results in a smaller response
     * size, and thus higher network throughput.
     * </pre>
     */
    public java.util.Iterator<com.google.maps.routes.v1.RouteMatrixElement> computeRouteMatrix(
        com.google.maps.routes.v1.ComputeRouteMatrixRequest request) {
      return io.grpc.stub.ClientCalls.blockingServerStreamingCall(
          getChannel(), getComputeRouteMatrixMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Given a set of terminal and intermediate waypoints, and a route objective,
     * computes the best route for the route objective. Also returns fastest route
     * and shortest route as reference routes.
     * **NOTE:** This method requires that you specify a response field mask in
     * the input. You can provide the response field mask by using the URL
     * parameter `$fields` or `fields`, or by using the HTTP/gRPC header
     * `X-Goog-FieldMask` (see the [available URL parameters and
     * headers](https://cloud.google.com/apis/docs/system-parameters). The value
     * is a comma separated list of field paths. See this detailed documentation
     * about [how to construct the field
     * paths](https://github.com/protocolbuffers/protobuf/blob/master/src/google/protobuf/field_mask.proto).
     * For example, in this method:
     * * Field mask of all available fields (for manual inspection):
     *   `X-Goog-FieldMask: *`
     * * Field mask of route distances, durations, token and toll info:
     *   `X-Goog-FieldMask:
     *   routes.route.distanceMeters,routes.route.duration,routes.token,routes.route.travelAdvisory.tollInfo`
     * Google discourages the use of the wildcard (`*`) response field mask, or
     * specifying the field mask at the top level (`routes`), because:
     * * Selecting only the fields that you need helps our server save computation
     * cycles, allowing us to return the result to you with a lower latency.
     * * Selecting only the fields that you need in your production job ensures
     * stable latency performance. We might add more response fields in the
     * future, and those new fields might require extra computation time. If you
     * select all fields, or if you select all fields at the top level, then you
     * might experience performance degradation because any new field we add will
     * be automatically included in the response.
     * * Selecting only the fields that you need results in a smaller response
     * size, and thus higher network throughput.
     * </pre>
     */
    public com.google.maps.routes.v1.ComputeCustomRoutesResponse computeCustomRoutes(com.google.maps.routes.v1.ComputeCustomRoutesRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getComputeCustomRoutesMethod(), getCallOptions(), request);
    }
  }

  /**
   * <pre>
   * The Routes Preferred API.
   * </pre>
   */
  public static final class RoutesPreferredFutureStub extends io.grpc.stub.AbstractFutureStub<RoutesPreferredFutureStub> {
    private RoutesPreferredFutureStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected RoutesPreferredFutureStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new RoutesPreferredFutureStub(channel, callOptions);
    }

    /**
     * <pre>
     * Returns the primary route along with optional alternate routes, given a set
     * of terminal and intermediate waypoints.
     * **NOTE:** This method requires that you specify a response field mask in
     * the input. You can provide the response field mask by using URL parameter
     * `$fields` or `fields`, or by using an HTTP/gRPC header `X-Goog-FieldMask`
     * (see the [available URL parameters and
     * headers](https://cloud.google.com/apis/docs/system-parameters). The value
     * is a comma separated list of field paths. See detailed documentation about
     * [how to construct the field
     * paths](https://github.com/protocolbuffers/protobuf/blob/master/src/google/protobuf/field_mask.proto).
     * For example, in this method:
     * * Field mask of all available fields (for manual inspection):
     *   `X-Goog-FieldMask: *`
     * * Field mask of Route-level duration, distance, and polyline (an example
     * production setup):
     *   `X-Goog-FieldMask:
     *   routes.duration,routes.distanceMeters,routes.polyline.encodedPolyline`
     * Google discourage the use of the wildcard (`*`) response field mask, or
     * specifying the field mask at the top level (`routes`), because:
     * * Selecting only the fields that you need helps our server save computation
     * cycles, allowing us to return the result to you with a lower latency.
     * * Selecting only the fields that you need
     * in your production job ensures stable latency performance. We might add
     * more response fields in the future, and those new fields might require
     * extra computation time. If you select all fields, or if you select all
     * fields at the top level, then you might experience performance degradation
     * because any new field we add will be automatically included in the
     * response.
     * * Selecting only the fields that you need results in a smaller response
     * size, and thus higher network throughput.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.maps.routes.v1.ComputeRoutesResponse> computeRoutes(
        com.google.maps.routes.v1.ComputeRoutesRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getComputeRoutesMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Given a set of terminal and intermediate waypoints, and a route objective,
     * computes the best route for the route objective. Also returns fastest route
     * and shortest route as reference routes.
     * **NOTE:** This method requires that you specify a response field mask in
     * the input. You can provide the response field mask by using the URL
     * parameter `$fields` or `fields`, or by using the HTTP/gRPC header
     * `X-Goog-FieldMask` (see the [available URL parameters and
     * headers](https://cloud.google.com/apis/docs/system-parameters). The value
     * is a comma separated list of field paths. See this detailed documentation
     * about [how to construct the field
     * paths](https://github.com/protocolbuffers/protobuf/blob/master/src/google/protobuf/field_mask.proto).
     * For example, in this method:
     * * Field mask of all available fields (for manual inspection):
     *   `X-Goog-FieldMask: *`
     * * Field mask of route distances, durations, token and toll info:
     *   `X-Goog-FieldMask:
     *   routes.route.distanceMeters,routes.route.duration,routes.token,routes.route.travelAdvisory.tollInfo`
     * Google discourages the use of the wildcard (`*`) response field mask, or
     * specifying the field mask at the top level (`routes`), because:
     * * Selecting only the fields that you need helps our server save computation
     * cycles, allowing us to return the result to you with a lower latency.
     * * Selecting only the fields that you need in your production job ensures
     * stable latency performance. We might add more response fields in the
     * future, and those new fields might require extra computation time. If you
     * select all fields, or if you select all fields at the top level, then you
     * might experience performance degradation because any new field we add will
     * be automatically included in the response.
     * * Selecting only the fields that you need results in a smaller response
     * size, and thus higher network throughput.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.maps.routes.v1.ComputeCustomRoutesResponse> computeCustomRoutes(
        com.google.maps.routes.v1.ComputeCustomRoutesRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getComputeCustomRoutesMethod(), getCallOptions()), request);
    }
  }

  private static final int METHODID_COMPUTE_ROUTES = 0;
  private static final int METHODID_COMPUTE_ROUTE_MATRIX = 1;
  private static final int METHODID_COMPUTE_CUSTOM_ROUTES = 2;

  private static final class MethodHandlers<Req, Resp> implements
      io.grpc.stub.ServerCalls.UnaryMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ServerStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ClientStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.BidiStreamingMethod<Req, Resp> {
    private final RoutesPreferredImplBase serviceImpl;
    private final int methodId;

    MethodHandlers(RoutesPreferredImplBase serviceImpl, int methodId) {
      this.serviceImpl = serviceImpl;
      this.methodId = methodId;
    }

    @java.lang.Override
    @java.lang.SuppressWarnings("unchecked")
    public void invoke(Req request, io.grpc.stub.StreamObserver<Resp> responseObserver) {
      switch (methodId) {
        case METHODID_COMPUTE_ROUTES:
          serviceImpl.computeRoutes((com.google.maps.routes.v1.ComputeRoutesRequest) request,
              (io.grpc.stub.StreamObserver<com.google.maps.routes.v1.ComputeRoutesResponse>) responseObserver);
          break;
        case METHODID_COMPUTE_ROUTE_MATRIX:
          serviceImpl.computeRouteMatrix((com.google.maps.routes.v1.ComputeRouteMatrixRequest) request,
              (io.grpc.stub.StreamObserver<com.google.maps.routes.v1.RouteMatrixElement>) responseObserver);
          break;
        case METHODID_COMPUTE_CUSTOM_ROUTES:
          serviceImpl.computeCustomRoutes((com.google.maps.routes.v1.ComputeCustomRoutesRequest) request,
              (io.grpc.stub.StreamObserver<com.google.maps.routes.v1.ComputeCustomRoutesResponse>) responseObserver);
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

  private static abstract class RoutesPreferredBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoFileDescriptorSupplier, io.grpc.protobuf.ProtoServiceDescriptorSupplier {
    RoutesPreferredBaseDescriptorSupplier() {}

    @java.lang.Override
    public com.google.protobuf.Descriptors.FileDescriptor getFileDescriptor() {
      return com.google.maps.routes.v1.RoutesServiceProto.getDescriptor();
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.ServiceDescriptor getServiceDescriptor() {
      return getFileDescriptor().findServiceByName("RoutesPreferred");
    }
  }

  private static final class RoutesPreferredFileDescriptorSupplier
      extends RoutesPreferredBaseDescriptorSupplier {
    RoutesPreferredFileDescriptorSupplier() {}
  }

  private static final class RoutesPreferredMethodDescriptorSupplier
      extends RoutesPreferredBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoMethodDescriptorSupplier {
    private final String methodName;

    RoutesPreferredMethodDescriptorSupplier(String methodName) {
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
      synchronized (RoutesPreferredGrpc.class) {
        result = serviceDescriptor;
        if (result == null) {
          serviceDescriptor = result = io.grpc.ServiceDescriptor.newBuilder(SERVICE_NAME)
              .setSchemaDescriptor(new RoutesPreferredFileDescriptorSupplier())
              .addMethod(getComputeRoutesMethod())
              .addMethod(getComputeRouteMatrixMethod())
              .addMethod(getComputeCustomRoutesMethod())
              .build();
        }
      }
    }
    return result;
  }
}
