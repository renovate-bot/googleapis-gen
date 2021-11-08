package com.google.devtools.testing.v1;

import static io.grpc.MethodDescriptor.generateFullMethodName;

/**
 * <pre>
 * Service for discovering environments supported by the TestExecutionService.
 * Over time the TestService may add or remove devices or configuration options
 * (e.g., when new devices and APIs are released).  Clients should check here
 * periodically to discover what options are supported.
 * It defines the following resource model:
 * - The API a collection of [TestEnvironmentCatalog]
 *   [google.devtools.test.v1.TestEnvironmentCatalog] resources, named
 *   `testEnvironmentCatalog/&#42;`
 * - Each TestEnvironmentCatalog resource describes a set of supported
 *   environments.
 * - An [AndroidDeviceCatalog][google.devtools.test.v1.AndroidDeviceCatalog]
 *   describes supported Android devices. It contains lists of supported
 *   [AndroidModels][google.devtools.test.v1.AndroidModel] and
 *   [AndroidVersions][google.devtools.test.v1.AndroidVersion] along with a
 *   [AndroidRuntimeConfiguration][google.devtools.test.v1.AndroidRuntimeConfiguration].
 *   Each AndroidModel contains a list of Versions it supports. All
 *   models support all locales and orientations described by the
 *   AndroidRuntimeConfiguration
 * - An [IosDeviceCatalog][google.devtools.test.v1.IosDeviceCatalog]
 *   describes supported iOS devices. It contains lists of supported
 *   [IosModels][google.devtools.test.v1.IosModel] and
 *   [IosVersions][google.devtools.test.v1.IosVersion] along with a
 *   [IosRuntimeConfiguration][google.devtools.test.v1.IosRuntimeConfiguration].
 *   Each IosModel contains a list of Versions it supports. All
 *   models support all locales and orientations described by the
 *   IosRuntimeConfiguration.
 * </pre>
 */
@javax.annotation.Generated(
    value = "by gRPC proto compiler",
    comments = "Source: google/devtools/testing/v1/test_environment_discovery.proto")
@io.grpc.stub.annotations.GrpcGenerated
public final class TestEnvironmentDiscoveryServiceGrpc {

  private TestEnvironmentDiscoveryServiceGrpc() {}

  public static final String SERVICE_NAME = "google.devtools.testing.v1.TestEnvironmentDiscoveryService";

  // Static method descriptors that strictly reflect the proto.
  private static volatile io.grpc.MethodDescriptor<com.google.devtools.testing.v1.GetTestEnvironmentCatalogRequest,
      com.google.devtools.testing.v1.TestEnvironmentCatalog> getGetTestEnvironmentCatalogMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "GetTestEnvironmentCatalog",
      requestType = com.google.devtools.testing.v1.GetTestEnvironmentCatalogRequest.class,
      responseType = com.google.devtools.testing.v1.TestEnvironmentCatalog.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.devtools.testing.v1.GetTestEnvironmentCatalogRequest,
      com.google.devtools.testing.v1.TestEnvironmentCatalog> getGetTestEnvironmentCatalogMethod() {
    io.grpc.MethodDescriptor<com.google.devtools.testing.v1.GetTestEnvironmentCatalogRequest, com.google.devtools.testing.v1.TestEnvironmentCatalog> getGetTestEnvironmentCatalogMethod;
    if ((getGetTestEnvironmentCatalogMethod = TestEnvironmentDiscoveryServiceGrpc.getGetTestEnvironmentCatalogMethod) == null) {
      synchronized (TestEnvironmentDiscoveryServiceGrpc.class) {
        if ((getGetTestEnvironmentCatalogMethod = TestEnvironmentDiscoveryServiceGrpc.getGetTestEnvironmentCatalogMethod) == null) {
          TestEnvironmentDiscoveryServiceGrpc.getGetTestEnvironmentCatalogMethod = getGetTestEnvironmentCatalogMethod =
              io.grpc.MethodDescriptor.<com.google.devtools.testing.v1.GetTestEnvironmentCatalogRequest, com.google.devtools.testing.v1.TestEnvironmentCatalog>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "GetTestEnvironmentCatalog"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.devtools.testing.v1.GetTestEnvironmentCatalogRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.devtools.testing.v1.TestEnvironmentCatalog.getDefaultInstance()))
              .setSchemaDescriptor(new TestEnvironmentDiscoveryServiceMethodDescriptorSupplier("GetTestEnvironmentCatalog"))
              .build();
        }
      }
    }
    return getGetTestEnvironmentCatalogMethod;
  }

  /**
   * Creates a new async stub that supports all call types for the service
   */
  public static TestEnvironmentDiscoveryServiceStub newStub(io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<TestEnvironmentDiscoveryServiceStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<TestEnvironmentDiscoveryServiceStub>() {
        @java.lang.Override
        public TestEnvironmentDiscoveryServiceStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new TestEnvironmentDiscoveryServiceStub(channel, callOptions);
        }
      };
    return TestEnvironmentDiscoveryServiceStub.newStub(factory, channel);
  }

  /**
   * Creates a new blocking-style stub that supports unary and streaming output calls on the service
   */
  public static TestEnvironmentDiscoveryServiceBlockingStub newBlockingStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<TestEnvironmentDiscoveryServiceBlockingStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<TestEnvironmentDiscoveryServiceBlockingStub>() {
        @java.lang.Override
        public TestEnvironmentDiscoveryServiceBlockingStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new TestEnvironmentDiscoveryServiceBlockingStub(channel, callOptions);
        }
      };
    return TestEnvironmentDiscoveryServiceBlockingStub.newStub(factory, channel);
  }

  /**
   * Creates a new ListenableFuture-style stub that supports unary calls on the service
   */
  public static TestEnvironmentDiscoveryServiceFutureStub newFutureStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<TestEnvironmentDiscoveryServiceFutureStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<TestEnvironmentDiscoveryServiceFutureStub>() {
        @java.lang.Override
        public TestEnvironmentDiscoveryServiceFutureStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new TestEnvironmentDiscoveryServiceFutureStub(channel, callOptions);
        }
      };
    return TestEnvironmentDiscoveryServiceFutureStub.newStub(factory, channel);
  }

  /**
   * <pre>
   * Service for discovering environments supported by the TestExecutionService.
   * Over time the TestService may add or remove devices or configuration options
   * (e.g., when new devices and APIs are released).  Clients should check here
   * periodically to discover what options are supported.
   * It defines the following resource model:
   * - The API a collection of [TestEnvironmentCatalog]
   *   [google.devtools.test.v1.TestEnvironmentCatalog] resources, named
   *   `testEnvironmentCatalog/&#42;`
   * - Each TestEnvironmentCatalog resource describes a set of supported
   *   environments.
   * - An [AndroidDeviceCatalog][google.devtools.test.v1.AndroidDeviceCatalog]
   *   describes supported Android devices. It contains lists of supported
   *   [AndroidModels][google.devtools.test.v1.AndroidModel] and
   *   [AndroidVersions][google.devtools.test.v1.AndroidVersion] along with a
   *   [AndroidRuntimeConfiguration][google.devtools.test.v1.AndroidRuntimeConfiguration].
   *   Each AndroidModel contains a list of Versions it supports. All
   *   models support all locales and orientations described by the
   *   AndroidRuntimeConfiguration
   * - An [IosDeviceCatalog][google.devtools.test.v1.IosDeviceCatalog]
   *   describes supported iOS devices. It contains lists of supported
   *   [IosModels][google.devtools.test.v1.IosModel] and
   *   [IosVersions][google.devtools.test.v1.IosVersion] along with a
   *   [IosRuntimeConfiguration][google.devtools.test.v1.IosRuntimeConfiguration].
   *   Each IosModel contains a list of Versions it supports. All
   *   models support all locales and orientations described by the
   *   IosRuntimeConfiguration.
   * </pre>
   */
  public static abstract class TestEnvironmentDiscoveryServiceImplBase implements io.grpc.BindableService {

    /**
     * <pre>
     * Gets the catalog of supported test environments.
     * May return any of the following canonical error codes:
     * - INVALID_ARGUMENT - if the request is malformed
     * - NOT_FOUND - if the environment type does not exist
     * - INTERNAL - if an internal error occurred
     * </pre>
     */
    public void getTestEnvironmentCatalog(com.google.devtools.testing.v1.GetTestEnvironmentCatalogRequest request,
        io.grpc.stub.StreamObserver<com.google.devtools.testing.v1.TestEnvironmentCatalog> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getGetTestEnvironmentCatalogMethod(), responseObserver);
    }

    @java.lang.Override public final io.grpc.ServerServiceDefinition bindService() {
      return io.grpc.ServerServiceDefinition.builder(getServiceDescriptor())
          .addMethod(
            getGetTestEnvironmentCatalogMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.devtools.testing.v1.GetTestEnvironmentCatalogRequest,
                com.google.devtools.testing.v1.TestEnvironmentCatalog>(
                  this, METHODID_GET_TEST_ENVIRONMENT_CATALOG)))
          .build();
    }
  }

  /**
   * <pre>
   * Service for discovering environments supported by the TestExecutionService.
   * Over time the TestService may add or remove devices or configuration options
   * (e.g., when new devices and APIs are released).  Clients should check here
   * periodically to discover what options are supported.
   * It defines the following resource model:
   * - The API a collection of [TestEnvironmentCatalog]
   *   [google.devtools.test.v1.TestEnvironmentCatalog] resources, named
   *   `testEnvironmentCatalog/&#42;`
   * - Each TestEnvironmentCatalog resource describes a set of supported
   *   environments.
   * - An [AndroidDeviceCatalog][google.devtools.test.v1.AndroidDeviceCatalog]
   *   describes supported Android devices. It contains lists of supported
   *   [AndroidModels][google.devtools.test.v1.AndroidModel] and
   *   [AndroidVersions][google.devtools.test.v1.AndroidVersion] along with a
   *   [AndroidRuntimeConfiguration][google.devtools.test.v1.AndroidRuntimeConfiguration].
   *   Each AndroidModel contains a list of Versions it supports. All
   *   models support all locales and orientations described by the
   *   AndroidRuntimeConfiguration
   * - An [IosDeviceCatalog][google.devtools.test.v1.IosDeviceCatalog]
   *   describes supported iOS devices. It contains lists of supported
   *   [IosModels][google.devtools.test.v1.IosModel] and
   *   [IosVersions][google.devtools.test.v1.IosVersion] along with a
   *   [IosRuntimeConfiguration][google.devtools.test.v1.IosRuntimeConfiguration].
   *   Each IosModel contains a list of Versions it supports. All
   *   models support all locales and orientations described by the
   *   IosRuntimeConfiguration.
   * </pre>
   */
  public static final class TestEnvironmentDiscoveryServiceStub extends io.grpc.stub.AbstractAsyncStub<TestEnvironmentDiscoveryServiceStub> {
    private TestEnvironmentDiscoveryServiceStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected TestEnvironmentDiscoveryServiceStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new TestEnvironmentDiscoveryServiceStub(channel, callOptions);
    }

    /**
     * <pre>
     * Gets the catalog of supported test environments.
     * May return any of the following canonical error codes:
     * - INVALID_ARGUMENT - if the request is malformed
     * - NOT_FOUND - if the environment type does not exist
     * - INTERNAL - if an internal error occurred
     * </pre>
     */
    public void getTestEnvironmentCatalog(com.google.devtools.testing.v1.GetTestEnvironmentCatalogRequest request,
        io.grpc.stub.StreamObserver<com.google.devtools.testing.v1.TestEnvironmentCatalog> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getGetTestEnvironmentCatalogMethod(), getCallOptions()), request, responseObserver);
    }
  }

  /**
   * <pre>
   * Service for discovering environments supported by the TestExecutionService.
   * Over time the TestService may add or remove devices or configuration options
   * (e.g., when new devices and APIs are released).  Clients should check here
   * periodically to discover what options are supported.
   * It defines the following resource model:
   * - The API a collection of [TestEnvironmentCatalog]
   *   [google.devtools.test.v1.TestEnvironmentCatalog] resources, named
   *   `testEnvironmentCatalog/&#42;`
   * - Each TestEnvironmentCatalog resource describes a set of supported
   *   environments.
   * - An [AndroidDeviceCatalog][google.devtools.test.v1.AndroidDeviceCatalog]
   *   describes supported Android devices. It contains lists of supported
   *   [AndroidModels][google.devtools.test.v1.AndroidModel] and
   *   [AndroidVersions][google.devtools.test.v1.AndroidVersion] along with a
   *   [AndroidRuntimeConfiguration][google.devtools.test.v1.AndroidRuntimeConfiguration].
   *   Each AndroidModel contains a list of Versions it supports. All
   *   models support all locales and orientations described by the
   *   AndroidRuntimeConfiguration
   * - An [IosDeviceCatalog][google.devtools.test.v1.IosDeviceCatalog]
   *   describes supported iOS devices. It contains lists of supported
   *   [IosModels][google.devtools.test.v1.IosModel] and
   *   [IosVersions][google.devtools.test.v1.IosVersion] along with a
   *   [IosRuntimeConfiguration][google.devtools.test.v1.IosRuntimeConfiguration].
   *   Each IosModel contains a list of Versions it supports. All
   *   models support all locales and orientations described by the
   *   IosRuntimeConfiguration.
   * </pre>
   */
  public static final class TestEnvironmentDiscoveryServiceBlockingStub extends io.grpc.stub.AbstractBlockingStub<TestEnvironmentDiscoveryServiceBlockingStub> {
    private TestEnvironmentDiscoveryServiceBlockingStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected TestEnvironmentDiscoveryServiceBlockingStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new TestEnvironmentDiscoveryServiceBlockingStub(channel, callOptions);
    }

    /**
     * <pre>
     * Gets the catalog of supported test environments.
     * May return any of the following canonical error codes:
     * - INVALID_ARGUMENT - if the request is malformed
     * - NOT_FOUND - if the environment type does not exist
     * - INTERNAL - if an internal error occurred
     * </pre>
     */
    public com.google.devtools.testing.v1.TestEnvironmentCatalog getTestEnvironmentCatalog(com.google.devtools.testing.v1.GetTestEnvironmentCatalogRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getGetTestEnvironmentCatalogMethod(), getCallOptions(), request);
    }
  }

  /**
   * <pre>
   * Service for discovering environments supported by the TestExecutionService.
   * Over time the TestService may add or remove devices or configuration options
   * (e.g., when new devices and APIs are released).  Clients should check here
   * periodically to discover what options are supported.
   * It defines the following resource model:
   * - The API a collection of [TestEnvironmentCatalog]
   *   [google.devtools.test.v1.TestEnvironmentCatalog] resources, named
   *   `testEnvironmentCatalog/&#42;`
   * - Each TestEnvironmentCatalog resource describes a set of supported
   *   environments.
   * - An [AndroidDeviceCatalog][google.devtools.test.v1.AndroidDeviceCatalog]
   *   describes supported Android devices. It contains lists of supported
   *   [AndroidModels][google.devtools.test.v1.AndroidModel] and
   *   [AndroidVersions][google.devtools.test.v1.AndroidVersion] along with a
   *   [AndroidRuntimeConfiguration][google.devtools.test.v1.AndroidRuntimeConfiguration].
   *   Each AndroidModel contains a list of Versions it supports. All
   *   models support all locales and orientations described by the
   *   AndroidRuntimeConfiguration
   * - An [IosDeviceCatalog][google.devtools.test.v1.IosDeviceCatalog]
   *   describes supported iOS devices. It contains lists of supported
   *   [IosModels][google.devtools.test.v1.IosModel] and
   *   [IosVersions][google.devtools.test.v1.IosVersion] along with a
   *   [IosRuntimeConfiguration][google.devtools.test.v1.IosRuntimeConfiguration].
   *   Each IosModel contains a list of Versions it supports. All
   *   models support all locales and orientations described by the
   *   IosRuntimeConfiguration.
   * </pre>
   */
  public static final class TestEnvironmentDiscoveryServiceFutureStub extends io.grpc.stub.AbstractFutureStub<TestEnvironmentDiscoveryServiceFutureStub> {
    private TestEnvironmentDiscoveryServiceFutureStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected TestEnvironmentDiscoveryServiceFutureStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new TestEnvironmentDiscoveryServiceFutureStub(channel, callOptions);
    }

    /**
     * <pre>
     * Gets the catalog of supported test environments.
     * May return any of the following canonical error codes:
     * - INVALID_ARGUMENT - if the request is malformed
     * - NOT_FOUND - if the environment type does not exist
     * - INTERNAL - if an internal error occurred
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.devtools.testing.v1.TestEnvironmentCatalog> getTestEnvironmentCatalog(
        com.google.devtools.testing.v1.GetTestEnvironmentCatalogRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getGetTestEnvironmentCatalogMethod(), getCallOptions()), request);
    }
  }

  private static final int METHODID_GET_TEST_ENVIRONMENT_CATALOG = 0;

  private static final class MethodHandlers<Req, Resp> implements
      io.grpc.stub.ServerCalls.UnaryMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ServerStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ClientStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.BidiStreamingMethod<Req, Resp> {
    private final TestEnvironmentDiscoveryServiceImplBase serviceImpl;
    private final int methodId;

    MethodHandlers(TestEnvironmentDiscoveryServiceImplBase serviceImpl, int methodId) {
      this.serviceImpl = serviceImpl;
      this.methodId = methodId;
    }

    @java.lang.Override
    @java.lang.SuppressWarnings("unchecked")
    public void invoke(Req request, io.grpc.stub.StreamObserver<Resp> responseObserver) {
      switch (methodId) {
        case METHODID_GET_TEST_ENVIRONMENT_CATALOG:
          serviceImpl.getTestEnvironmentCatalog((com.google.devtools.testing.v1.GetTestEnvironmentCatalogRequest) request,
              (io.grpc.stub.StreamObserver<com.google.devtools.testing.v1.TestEnvironmentCatalog>) responseObserver);
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

  private static abstract class TestEnvironmentDiscoveryServiceBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoFileDescriptorSupplier, io.grpc.protobuf.ProtoServiceDescriptorSupplier {
    TestEnvironmentDiscoveryServiceBaseDescriptorSupplier() {}

    @java.lang.Override
    public com.google.protobuf.Descriptors.FileDescriptor getFileDescriptor() {
      return com.google.devtools.testing.v1.TestEnvironmentDiscoveryProto.getDescriptor();
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.ServiceDescriptor getServiceDescriptor() {
      return getFileDescriptor().findServiceByName("TestEnvironmentDiscoveryService");
    }
  }

  private static final class TestEnvironmentDiscoveryServiceFileDescriptorSupplier
      extends TestEnvironmentDiscoveryServiceBaseDescriptorSupplier {
    TestEnvironmentDiscoveryServiceFileDescriptorSupplier() {}
  }

  private static final class TestEnvironmentDiscoveryServiceMethodDescriptorSupplier
      extends TestEnvironmentDiscoveryServiceBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoMethodDescriptorSupplier {
    private final String methodName;

    TestEnvironmentDiscoveryServiceMethodDescriptorSupplier(String methodName) {
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
      synchronized (TestEnvironmentDiscoveryServiceGrpc.class) {
        result = serviceDescriptor;
        if (result == null) {
          serviceDescriptor = result = io.grpc.ServiceDescriptor.newBuilder(SERVICE_NAME)
              .setSchemaDescriptor(new TestEnvironmentDiscoveryServiceFileDescriptorSupplier())
              .addMethod(getGetTestEnvironmentCatalogMethod())
              .build();
        }
      }
    }
    return result;
  }
}
