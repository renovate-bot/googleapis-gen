package com.google.cloud.dataqna.v1alpha;

import static io.grpc.MethodDescriptor.generateFullMethodName;
import static io.grpc.stub.ClientCalls.asyncBidiStreamingCall;
import static io.grpc.stub.ClientCalls.asyncClientStreamingCall;
import static io.grpc.stub.ClientCalls.asyncServerStreamingCall;
import static io.grpc.stub.ClientCalls.asyncUnaryCall;
import static io.grpc.stub.ClientCalls.blockingServerStreamingCall;
import static io.grpc.stub.ClientCalls.blockingUnaryCall;
import static io.grpc.stub.ClientCalls.futureUnaryCall;
import static io.grpc.stub.ServerCalls.asyncBidiStreamingCall;
import static io.grpc.stub.ServerCalls.asyncClientStreamingCall;
import static io.grpc.stub.ServerCalls.asyncServerStreamingCall;
import static io.grpc.stub.ServerCalls.asyncUnaryCall;
import static io.grpc.stub.ServerCalls.asyncUnimplementedStreamingCall;
import static io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall;

/**
 * <pre>
 * This stateless API provides automatic suggestions for natural language
 * queries for the data sources in the provided project and location.
 * The service provides a resourceless operation `suggestQueries` that can be
 * called to get a list of suggestions for a given incomplete query and scope
 * (or list of scopes) under which the query is to be interpreted.
 * There are two types of suggestions, ENTITY for single entity suggestions
 * and TEMPLATE for full sentences. By default, both types are returned.
 * Example Request:
 * ```
 * GetSuggestions({
 *   parent: "locations/us/projects/my-project"
 *   scopes:
 *   "//bigquery.googleapis.com/projects/my-project/datasets/my-dataset/tables/my-table"
 *   query: "top it"
 * })
 * ```
 * The service will retrieve information based on the given scope(s) and give
 * suggestions based on that (e.g. "top item" for "top it" if "item" is a known
 * dimension for the provided scope).
 * ```
 * suggestions {
 *   suggestion_info {
 *     annotated_suggestion {
 *       text_formatted: "top item by sum of usd_revenue_net"
 *       markups {
 *         type: DIMENSION
 *         start_char_index: 4
 *         length: 4
 *       }
 *       markups {
 *         type: METRIC
 *         start_char_index: 19
 *         length: 15
 *       }
 *     }
 *     query_matches {
 *       start_char_index: 0
 *       length: 6
 *     }
 *   }
 *   suggestion_type: TEMPLATE
 *   ranking_score: 0.9
 * }
 * suggestions {
 *   suggestion_info {
 *     annotated_suggestion {
 *       text_formatted: "item"
 *       markups {
 *         type: DIMENSION
 *         start_char_index: 4
 *         length: 2
 *       }
 *     }
 *     query_matches {
 *       start_char_index: 0
 *       length: 6
 *     }
 *   }
 *   suggestion_type: ENTITY
 *   ranking_score: 0.8
 * }
 * ```
 * </pre>
 */
@javax.annotation.Generated(
    value = "by gRPC proto compiler",
    comments = "Source: google/cloud/dataqna/v1alpha/auto_suggestion_service.proto")
public final class AutoSuggestionServiceGrpc {

  private AutoSuggestionServiceGrpc() {}

  public static final String SERVICE_NAME = "google.cloud.dataqna.v1alpha.AutoSuggestionService";

  // Static method descriptors that strictly reflect the proto.
  private static volatile io.grpc.MethodDescriptor<com.google.cloud.dataqna.v1alpha.SuggestQueriesRequest,
      com.google.cloud.dataqna.v1alpha.SuggestQueriesResponse> getSuggestQueriesMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "SuggestQueries",
      requestType = com.google.cloud.dataqna.v1alpha.SuggestQueriesRequest.class,
      responseType = com.google.cloud.dataqna.v1alpha.SuggestQueriesResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.cloud.dataqna.v1alpha.SuggestQueriesRequest,
      com.google.cloud.dataqna.v1alpha.SuggestQueriesResponse> getSuggestQueriesMethod() {
    io.grpc.MethodDescriptor<com.google.cloud.dataqna.v1alpha.SuggestQueriesRequest, com.google.cloud.dataqna.v1alpha.SuggestQueriesResponse> getSuggestQueriesMethod;
    if ((getSuggestQueriesMethod = AutoSuggestionServiceGrpc.getSuggestQueriesMethod) == null) {
      synchronized (AutoSuggestionServiceGrpc.class) {
        if ((getSuggestQueriesMethod = AutoSuggestionServiceGrpc.getSuggestQueriesMethod) == null) {
          AutoSuggestionServiceGrpc.getSuggestQueriesMethod = getSuggestQueriesMethod =
              io.grpc.MethodDescriptor.<com.google.cloud.dataqna.v1alpha.SuggestQueriesRequest, com.google.cloud.dataqna.v1alpha.SuggestQueriesResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "SuggestQueries"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.dataqna.v1alpha.SuggestQueriesRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.cloud.dataqna.v1alpha.SuggestQueriesResponse.getDefaultInstance()))
              .setSchemaDescriptor(new AutoSuggestionServiceMethodDescriptorSupplier("SuggestQueries"))
              .build();
        }
      }
    }
    return getSuggestQueriesMethod;
  }

  /**
   * Creates a new async stub that supports all call types for the service
   */
  public static AutoSuggestionServiceStub newStub(io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<AutoSuggestionServiceStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<AutoSuggestionServiceStub>() {
        @java.lang.Override
        public AutoSuggestionServiceStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new AutoSuggestionServiceStub(channel, callOptions);
        }
      };
    return AutoSuggestionServiceStub.newStub(factory, channel);
  }

  /**
   * Creates a new blocking-style stub that supports unary and streaming output calls on the service
   */
  public static AutoSuggestionServiceBlockingStub newBlockingStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<AutoSuggestionServiceBlockingStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<AutoSuggestionServiceBlockingStub>() {
        @java.lang.Override
        public AutoSuggestionServiceBlockingStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new AutoSuggestionServiceBlockingStub(channel, callOptions);
        }
      };
    return AutoSuggestionServiceBlockingStub.newStub(factory, channel);
  }

  /**
   * Creates a new ListenableFuture-style stub that supports unary calls on the service
   */
  public static AutoSuggestionServiceFutureStub newFutureStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<AutoSuggestionServiceFutureStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<AutoSuggestionServiceFutureStub>() {
        @java.lang.Override
        public AutoSuggestionServiceFutureStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new AutoSuggestionServiceFutureStub(channel, callOptions);
        }
      };
    return AutoSuggestionServiceFutureStub.newStub(factory, channel);
  }

  /**
   * <pre>
   * This stateless API provides automatic suggestions for natural language
   * queries for the data sources in the provided project and location.
   * The service provides a resourceless operation `suggestQueries` that can be
   * called to get a list of suggestions for a given incomplete query and scope
   * (or list of scopes) under which the query is to be interpreted.
   * There are two types of suggestions, ENTITY for single entity suggestions
   * and TEMPLATE for full sentences. By default, both types are returned.
   * Example Request:
   * ```
   * GetSuggestions({
   *   parent: "locations/us/projects/my-project"
   *   scopes:
   *   "//bigquery.googleapis.com/projects/my-project/datasets/my-dataset/tables/my-table"
   *   query: "top it"
   * })
   * ```
   * The service will retrieve information based on the given scope(s) and give
   * suggestions based on that (e.g. "top item" for "top it" if "item" is a known
   * dimension for the provided scope).
   * ```
   * suggestions {
   *   suggestion_info {
   *     annotated_suggestion {
   *       text_formatted: "top item by sum of usd_revenue_net"
   *       markups {
   *         type: DIMENSION
   *         start_char_index: 4
   *         length: 4
   *       }
   *       markups {
   *         type: METRIC
   *         start_char_index: 19
   *         length: 15
   *       }
   *     }
   *     query_matches {
   *       start_char_index: 0
   *       length: 6
   *     }
   *   }
   *   suggestion_type: TEMPLATE
   *   ranking_score: 0.9
   * }
   * suggestions {
   *   suggestion_info {
   *     annotated_suggestion {
   *       text_formatted: "item"
   *       markups {
   *         type: DIMENSION
   *         start_char_index: 4
   *         length: 2
   *       }
   *     }
   *     query_matches {
   *       start_char_index: 0
   *       length: 6
   *     }
   *   }
   *   suggestion_type: ENTITY
   *   ranking_score: 0.8
   * }
   * ```
   * </pre>
   */
  public static abstract class AutoSuggestionServiceImplBase implements io.grpc.BindableService {

    /**
     * <pre>
     * Gets a list of suggestions based on a prefix string.
     * AutoSuggestion tolerance should be less than 1 second.
     * </pre>
     */
    public void suggestQueries(com.google.cloud.dataqna.v1alpha.SuggestQueriesRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.dataqna.v1alpha.SuggestQueriesResponse> responseObserver) {
      asyncUnimplementedUnaryCall(getSuggestQueriesMethod(), responseObserver);
    }

    @java.lang.Override public final io.grpc.ServerServiceDefinition bindService() {
      return io.grpc.ServerServiceDefinition.builder(getServiceDescriptor())
          .addMethod(
            getSuggestQueriesMethod(),
            asyncUnaryCall(
              new MethodHandlers<
                com.google.cloud.dataqna.v1alpha.SuggestQueriesRequest,
                com.google.cloud.dataqna.v1alpha.SuggestQueriesResponse>(
                  this, METHODID_SUGGEST_QUERIES)))
          .build();
    }
  }

  /**
   * <pre>
   * This stateless API provides automatic suggestions for natural language
   * queries for the data sources in the provided project and location.
   * The service provides a resourceless operation `suggestQueries` that can be
   * called to get a list of suggestions for a given incomplete query and scope
   * (or list of scopes) under which the query is to be interpreted.
   * There are two types of suggestions, ENTITY for single entity suggestions
   * and TEMPLATE for full sentences. By default, both types are returned.
   * Example Request:
   * ```
   * GetSuggestions({
   *   parent: "locations/us/projects/my-project"
   *   scopes:
   *   "//bigquery.googleapis.com/projects/my-project/datasets/my-dataset/tables/my-table"
   *   query: "top it"
   * })
   * ```
   * The service will retrieve information based on the given scope(s) and give
   * suggestions based on that (e.g. "top item" for "top it" if "item" is a known
   * dimension for the provided scope).
   * ```
   * suggestions {
   *   suggestion_info {
   *     annotated_suggestion {
   *       text_formatted: "top item by sum of usd_revenue_net"
   *       markups {
   *         type: DIMENSION
   *         start_char_index: 4
   *         length: 4
   *       }
   *       markups {
   *         type: METRIC
   *         start_char_index: 19
   *         length: 15
   *       }
   *     }
   *     query_matches {
   *       start_char_index: 0
   *       length: 6
   *     }
   *   }
   *   suggestion_type: TEMPLATE
   *   ranking_score: 0.9
   * }
   * suggestions {
   *   suggestion_info {
   *     annotated_suggestion {
   *       text_formatted: "item"
   *       markups {
   *         type: DIMENSION
   *         start_char_index: 4
   *         length: 2
   *       }
   *     }
   *     query_matches {
   *       start_char_index: 0
   *       length: 6
   *     }
   *   }
   *   suggestion_type: ENTITY
   *   ranking_score: 0.8
   * }
   * ```
   * </pre>
   */
  public static final class AutoSuggestionServiceStub extends io.grpc.stub.AbstractAsyncStub<AutoSuggestionServiceStub> {
    private AutoSuggestionServiceStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected AutoSuggestionServiceStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new AutoSuggestionServiceStub(channel, callOptions);
    }

    /**
     * <pre>
     * Gets a list of suggestions based on a prefix string.
     * AutoSuggestion tolerance should be less than 1 second.
     * </pre>
     */
    public void suggestQueries(com.google.cloud.dataqna.v1alpha.SuggestQueriesRequest request,
        io.grpc.stub.StreamObserver<com.google.cloud.dataqna.v1alpha.SuggestQueriesResponse> responseObserver) {
      asyncUnaryCall(
          getChannel().newCall(getSuggestQueriesMethod(), getCallOptions()), request, responseObserver);
    }
  }

  /**
   * <pre>
   * This stateless API provides automatic suggestions for natural language
   * queries for the data sources in the provided project and location.
   * The service provides a resourceless operation `suggestQueries` that can be
   * called to get a list of suggestions for a given incomplete query and scope
   * (or list of scopes) under which the query is to be interpreted.
   * There are two types of suggestions, ENTITY for single entity suggestions
   * and TEMPLATE for full sentences. By default, both types are returned.
   * Example Request:
   * ```
   * GetSuggestions({
   *   parent: "locations/us/projects/my-project"
   *   scopes:
   *   "//bigquery.googleapis.com/projects/my-project/datasets/my-dataset/tables/my-table"
   *   query: "top it"
   * })
   * ```
   * The service will retrieve information based on the given scope(s) and give
   * suggestions based on that (e.g. "top item" for "top it" if "item" is a known
   * dimension for the provided scope).
   * ```
   * suggestions {
   *   suggestion_info {
   *     annotated_suggestion {
   *       text_formatted: "top item by sum of usd_revenue_net"
   *       markups {
   *         type: DIMENSION
   *         start_char_index: 4
   *         length: 4
   *       }
   *       markups {
   *         type: METRIC
   *         start_char_index: 19
   *         length: 15
   *       }
   *     }
   *     query_matches {
   *       start_char_index: 0
   *       length: 6
   *     }
   *   }
   *   suggestion_type: TEMPLATE
   *   ranking_score: 0.9
   * }
   * suggestions {
   *   suggestion_info {
   *     annotated_suggestion {
   *       text_formatted: "item"
   *       markups {
   *         type: DIMENSION
   *         start_char_index: 4
   *         length: 2
   *       }
   *     }
   *     query_matches {
   *       start_char_index: 0
   *       length: 6
   *     }
   *   }
   *   suggestion_type: ENTITY
   *   ranking_score: 0.8
   * }
   * ```
   * </pre>
   */
  public static final class AutoSuggestionServiceBlockingStub extends io.grpc.stub.AbstractBlockingStub<AutoSuggestionServiceBlockingStub> {
    private AutoSuggestionServiceBlockingStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected AutoSuggestionServiceBlockingStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new AutoSuggestionServiceBlockingStub(channel, callOptions);
    }

    /**
     * <pre>
     * Gets a list of suggestions based on a prefix string.
     * AutoSuggestion tolerance should be less than 1 second.
     * </pre>
     */
    public com.google.cloud.dataqna.v1alpha.SuggestQueriesResponse suggestQueries(com.google.cloud.dataqna.v1alpha.SuggestQueriesRequest request) {
      return blockingUnaryCall(
          getChannel(), getSuggestQueriesMethod(), getCallOptions(), request);
    }
  }

  /**
   * <pre>
   * This stateless API provides automatic suggestions for natural language
   * queries for the data sources in the provided project and location.
   * The service provides a resourceless operation `suggestQueries` that can be
   * called to get a list of suggestions for a given incomplete query and scope
   * (or list of scopes) under which the query is to be interpreted.
   * There are two types of suggestions, ENTITY for single entity suggestions
   * and TEMPLATE for full sentences. By default, both types are returned.
   * Example Request:
   * ```
   * GetSuggestions({
   *   parent: "locations/us/projects/my-project"
   *   scopes:
   *   "//bigquery.googleapis.com/projects/my-project/datasets/my-dataset/tables/my-table"
   *   query: "top it"
   * })
   * ```
   * The service will retrieve information based on the given scope(s) and give
   * suggestions based on that (e.g. "top item" for "top it" if "item" is a known
   * dimension for the provided scope).
   * ```
   * suggestions {
   *   suggestion_info {
   *     annotated_suggestion {
   *       text_formatted: "top item by sum of usd_revenue_net"
   *       markups {
   *         type: DIMENSION
   *         start_char_index: 4
   *         length: 4
   *       }
   *       markups {
   *         type: METRIC
   *         start_char_index: 19
   *         length: 15
   *       }
   *     }
   *     query_matches {
   *       start_char_index: 0
   *       length: 6
   *     }
   *   }
   *   suggestion_type: TEMPLATE
   *   ranking_score: 0.9
   * }
   * suggestions {
   *   suggestion_info {
   *     annotated_suggestion {
   *       text_formatted: "item"
   *       markups {
   *         type: DIMENSION
   *         start_char_index: 4
   *         length: 2
   *       }
   *     }
   *     query_matches {
   *       start_char_index: 0
   *       length: 6
   *     }
   *   }
   *   suggestion_type: ENTITY
   *   ranking_score: 0.8
   * }
   * ```
   * </pre>
   */
  public static final class AutoSuggestionServiceFutureStub extends io.grpc.stub.AbstractFutureStub<AutoSuggestionServiceFutureStub> {
    private AutoSuggestionServiceFutureStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected AutoSuggestionServiceFutureStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new AutoSuggestionServiceFutureStub(channel, callOptions);
    }

    /**
     * <pre>
     * Gets a list of suggestions based on a prefix string.
     * AutoSuggestion tolerance should be less than 1 second.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.cloud.dataqna.v1alpha.SuggestQueriesResponse> suggestQueries(
        com.google.cloud.dataqna.v1alpha.SuggestQueriesRequest request) {
      return futureUnaryCall(
          getChannel().newCall(getSuggestQueriesMethod(), getCallOptions()), request);
    }
  }

  private static final int METHODID_SUGGEST_QUERIES = 0;

  private static final class MethodHandlers<Req, Resp> implements
      io.grpc.stub.ServerCalls.UnaryMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ServerStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ClientStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.BidiStreamingMethod<Req, Resp> {
    private final AutoSuggestionServiceImplBase serviceImpl;
    private final int methodId;

    MethodHandlers(AutoSuggestionServiceImplBase serviceImpl, int methodId) {
      this.serviceImpl = serviceImpl;
      this.methodId = methodId;
    }

    @java.lang.Override
    @java.lang.SuppressWarnings("unchecked")
    public void invoke(Req request, io.grpc.stub.StreamObserver<Resp> responseObserver) {
      switch (methodId) {
        case METHODID_SUGGEST_QUERIES:
          serviceImpl.suggestQueries((com.google.cloud.dataqna.v1alpha.SuggestQueriesRequest) request,
              (io.grpc.stub.StreamObserver<com.google.cloud.dataqna.v1alpha.SuggestQueriesResponse>) responseObserver);
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

  private static abstract class AutoSuggestionServiceBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoFileDescriptorSupplier, io.grpc.protobuf.ProtoServiceDescriptorSupplier {
    AutoSuggestionServiceBaseDescriptorSupplier() {}

    @java.lang.Override
    public com.google.protobuf.Descriptors.FileDescriptor getFileDescriptor() {
      return com.google.cloud.dataqna.v1alpha.AutoSuggestionServiceProto.getDescriptor();
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.ServiceDescriptor getServiceDescriptor() {
      return getFileDescriptor().findServiceByName("AutoSuggestionService");
    }
  }

  private static final class AutoSuggestionServiceFileDescriptorSupplier
      extends AutoSuggestionServiceBaseDescriptorSupplier {
    AutoSuggestionServiceFileDescriptorSupplier() {}
  }

  private static final class AutoSuggestionServiceMethodDescriptorSupplier
      extends AutoSuggestionServiceBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoMethodDescriptorSupplier {
    private final String methodName;

    AutoSuggestionServiceMethodDescriptorSupplier(String methodName) {
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
      synchronized (AutoSuggestionServiceGrpc.class) {
        result = serviceDescriptor;
        if (result == null) {
          serviceDescriptor = result = io.grpc.ServiceDescriptor.newBuilder(SERVICE_NAME)
              .setSchemaDescriptor(new AutoSuggestionServiceFileDescriptorSupplier())
              .addMethod(getSuggestQueriesMethod())
              .build();
        }
      }
    }
    return result;
  }
}
