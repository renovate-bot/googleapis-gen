package com.google.example.library.v1;

import static io.grpc.MethodDescriptor.generateFullMethodName;

/**
 * <pre>
 * This API represents a simple digital library. It lets you manage Shelf
 * resources and Book resources in the library. It defines the following
 * resource model:
 * - The API has a collection of [Shelf][google.example.library.v1.Shelf]
 *   resources, named `shelves/&#42;`
 * - Each Shelf has a collection of [Book][google.example.library.v1.Book]
 *   resources, named `shelves/&#42;&#47;books/&#42;`
 * </pre>
 */
@javax.annotation.Generated(
    value = "by gRPC proto compiler",
    comments = "Source: google/example/library/v1/library.proto")
@io.grpc.stub.annotations.GrpcGenerated
public final class LibraryServiceGrpc {

  private LibraryServiceGrpc() {}

  public static final String SERVICE_NAME = "google.example.library.v1.LibraryService";

  // Static method descriptors that strictly reflect the proto.
  private static volatile io.grpc.MethodDescriptor<com.google.example.library.v1.CreateShelfRequest,
      com.google.example.library.v1.Shelf> getCreateShelfMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "CreateShelf",
      requestType = com.google.example.library.v1.CreateShelfRequest.class,
      responseType = com.google.example.library.v1.Shelf.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.example.library.v1.CreateShelfRequest,
      com.google.example.library.v1.Shelf> getCreateShelfMethod() {
    io.grpc.MethodDescriptor<com.google.example.library.v1.CreateShelfRequest, com.google.example.library.v1.Shelf> getCreateShelfMethod;
    if ((getCreateShelfMethod = LibraryServiceGrpc.getCreateShelfMethod) == null) {
      synchronized (LibraryServiceGrpc.class) {
        if ((getCreateShelfMethod = LibraryServiceGrpc.getCreateShelfMethod) == null) {
          LibraryServiceGrpc.getCreateShelfMethod = getCreateShelfMethod =
              io.grpc.MethodDescriptor.<com.google.example.library.v1.CreateShelfRequest, com.google.example.library.v1.Shelf>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "CreateShelf"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.example.library.v1.CreateShelfRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.example.library.v1.Shelf.getDefaultInstance()))
              .setSchemaDescriptor(new LibraryServiceMethodDescriptorSupplier("CreateShelf"))
              .build();
        }
      }
    }
    return getCreateShelfMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.example.library.v1.GetShelfRequest,
      com.google.example.library.v1.Shelf> getGetShelfMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "GetShelf",
      requestType = com.google.example.library.v1.GetShelfRequest.class,
      responseType = com.google.example.library.v1.Shelf.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.example.library.v1.GetShelfRequest,
      com.google.example.library.v1.Shelf> getGetShelfMethod() {
    io.grpc.MethodDescriptor<com.google.example.library.v1.GetShelfRequest, com.google.example.library.v1.Shelf> getGetShelfMethod;
    if ((getGetShelfMethod = LibraryServiceGrpc.getGetShelfMethod) == null) {
      synchronized (LibraryServiceGrpc.class) {
        if ((getGetShelfMethod = LibraryServiceGrpc.getGetShelfMethod) == null) {
          LibraryServiceGrpc.getGetShelfMethod = getGetShelfMethod =
              io.grpc.MethodDescriptor.<com.google.example.library.v1.GetShelfRequest, com.google.example.library.v1.Shelf>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "GetShelf"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.example.library.v1.GetShelfRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.example.library.v1.Shelf.getDefaultInstance()))
              .setSchemaDescriptor(new LibraryServiceMethodDescriptorSupplier("GetShelf"))
              .build();
        }
      }
    }
    return getGetShelfMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.example.library.v1.ListShelvesRequest,
      com.google.example.library.v1.ListShelvesResponse> getListShelvesMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "ListShelves",
      requestType = com.google.example.library.v1.ListShelvesRequest.class,
      responseType = com.google.example.library.v1.ListShelvesResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.example.library.v1.ListShelvesRequest,
      com.google.example.library.v1.ListShelvesResponse> getListShelvesMethod() {
    io.grpc.MethodDescriptor<com.google.example.library.v1.ListShelvesRequest, com.google.example.library.v1.ListShelvesResponse> getListShelvesMethod;
    if ((getListShelvesMethod = LibraryServiceGrpc.getListShelvesMethod) == null) {
      synchronized (LibraryServiceGrpc.class) {
        if ((getListShelvesMethod = LibraryServiceGrpc.getListShelvesMethod) == null) {
          LibraryServiceGrpc.getListShelvesMethod = getListShelvesMethod =
              io.grpc.MethodDescriptor.<com.google.example.library.v1.ListShelvesRequest, com.google.example.library.v1.ListShelvesResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "ListShelves"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.example.library.v1.ListShelvesRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.example.library.v1.ListShelvesResponse.getDefaultInstance()))
              .setSchemaDescriptor(new LibraryServiceMethodDescriptorSupplier("ListShelves"))
              .build();
        }
      }
    }
    return getListShelvesMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.example.library.v1.DeleteShelfRequest,
      com.google.protobuf.Empty> getDeleteShelfMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "DeleteShelf",
      requestType = com.google.example.library.v1.DeleteShelfRequest.class,
      responseType = com.google.protobuf.Empty.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.example.library.v1.DeleteShelfRequest,
      com.google.protobuf.Empty> getDeleteShelfMethod() {
    io.grpc.MethodDescriptor<com.google.example.library.v1.DeleteShelfRequest, com.google.protobuf.Empty> getDeleteShelfMethod;
    if ((getDeleteShelfMethod = LibraryServiceGrpc.getDeleteShelfMethod) == null) {
      synchronized (LibraryServiceGrpc.class) {
        if ((getDeleteShelfMethod = LibraryServiceGrpc.getDeleteShelfMethod) == null) {
          LibraryServiceGrpc.getDeleteShelfMethod = getDeleteShelfMethod =
              io.grpc.MethodDescriptor.<com.google.example.library.v1.DeleteShelfRequest, com.google.protobuf.Empty>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "DeleteShelf"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.example.library.v1.DeleteShelfRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.protobuf.Empty.getDefaultInstance()))
              .setSchemaDescriptor(new LibraryServiceMethodDescriptorSupplier("DeleteShelf"))
              .build();
        }
      }
    }
    return getDeleteShelfMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.example.library.v1.MergeShelvesRequest,
      com.google.example.library.v1.Shelf> getMergeShelvesMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "MergeShelves",
      requestType = com.google.example.library.v1.MergeShelvesRequest.class,
      responseType = com.google.example.library.v1.Shelf.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.example.library.v1.MergeShelvesRequest,
      com.google.example.library.v1.Shelf> getMergeShelvesMethod() {
    io.grpc.MethodDescriptor<com.google.example.library.v1.MergeShelvesRequest, com.google.example.library.v1.Shelf> getMergeShelvesMethod;
    if ((getMergeShelvesMethod = LibraryServiceGrpc.getMergeShelvesMethod) == null) {
      synchronized (LibraryServiceGrpc.class) {
        if ((getMergeShelvesMethod = LibraryServiceGrpc.getMergeShelvesMethod) == null) {
          LibraryServiceGrpc.getMergeShelvesMethod = getMergeShelvesMethod =
              io.grpc.MethodDescriptor.<com.google.example.library.v1.MergeShelvesRequest, com.google.example.library.v1.Shelf>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "MergeShelves"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.example.library.v1.MergeShelvesRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.example.library.v1.Shelf.getDefaultInstance()))
              .setSchemaDescriptor(new LibraryServiceMethodDescriptorSupplier("MergeShelves"))
              .build();
        }
      }
    }
    return getMergeShelvesMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.example.library.v1.CreateBookRequest,
      com.google.example.library.v1.Book> getCreateBookMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "CreateBook",
      requestType = com.google.example.library.v1.CreateBookRequest.class,
      responseType = com.google.example.library.v1.Book.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.example.library.v1.CreateBookRequest,
      com.google.example.library.v1.Book> getCreateBookMethod() {
    io.grpc.MethodDescriptor<com.google.example.library.v1.CreateBookRequest, com.google.example.library.v1.Book> getCreateBookMethod;
    if ((getCreateBookMethod = LibraryServiceGrpc.getCreateBookMethod) == null) {
      synchronized (LibraryServiceGrpc.class) {
        if ((getCreateBookMethod = LibraryServiceGrpc.getCreateBookMethod) == null) {
          LibraryServiceGrpc.getCreateBookMethod = getCreateBookMethod =
              io.grpc.MethodDescriptor.<com.google.example.library.v1.CreateBookRequest, com.google.example.library.v1.Book>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "CreateBook"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.example.library.v1.CreateBookRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.example.library.v1.Book.getDefaultInstance()))
              .setSchemaDescriptor(new LibraryServiceMethodDescriptorSupplier("CreateBook"))
              .build();
        }
      }
    }
    return getCreateBookMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.example.library.v1.GetBookRequest,
      com.google.example.library.v1.Book> getGetBookMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "GetBook",
      requestType = com.google.example.library.v1.GetBookRequest.class,
      responseType = com.google.example.library.v1.Book.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.example.library.v1.GetBookRequest,
      com.google.example.library.v1.Book> getGetBookMethod() {
    io.grpc.MethodDescriptor<com.google.example.library.v1.GetBookRequest, com.google.example.library.v1.Book> getGetBookMethod;
    if ((getGetBookMethod = LibraryServiceGrpc.getGetBookMethod) == null) {
      synchronized (LibraryServiceGrpc.class) {
        if ((getGetBookMethod = LibraryServiceGrpc.getGetBookMethod) == null) {
          LibraryServiceGrpc.getGetBookMethod = getGetBookMethod =
              io.grpc.MethodDescriptor.<com.google.example.library.v1.GetBookRequest, com.google.example.library.v1.Book>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "GetBook"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.example.library.v1.GetBookRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.example.library.v1.Book.getDefaultInstance()))
              .setSchemaDescriptor(new LibraryServiceMethodDescriptorSupplier("GetBook"))
              .build();
        }
      }
    }
    return getGetBookMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.example.library.v1.ListBooksRequest,
      com.google.example.library.v1.ListBooksResponse> getListBooksMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "ListBooks",
      requestType = com.google.example.library.v1.ListBooksRequest.class,
      responseType = com.google.example.library.v1.ListBooksResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.example.library.v1.ListBooksRequest,
      com.google.example.library.v1.ListBooksResponse> getListBooksMethod() {
    io.grpc.MethodDescriptor<com.google.example.library.v1.ListBooksRequest, com.google.example.library.v1.ListBooksResponse> getListBooksMethod;
    if ((getListBooksMethod = LibraryServiceGrpc.getListBooksMethod) == null) {
      synchronized (LibraryServiceGrpc.class) {
        if ((getListBooksMethod = LibraryServiceGrpc.getListBooksMethod) == null) {
          LibraryServiceGrpc.getListBooksMethod = getListBooksMethod =
              io.grpc.MethodDescriptor.<com.google.example.library.v1.ListBooksRequest, com.google.example.library.v1.ListBooksResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "ListBooks"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.example.library.v1.ListBooksRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.example.library.v1.ListBooksResponse.getDefaultInstance()))
              .setSchemaDescriptor(new LibraryServiceMethodDescriptorSupplier("ListBooks"))
              .build();
        }
      }
    }
    return getListBooksMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.example.library.v1.DeleteBookRequest,
      com.google.protobuf.Empty> getDeleteBookMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "DeleteBook",
      requestType = com.google.example.library.v1.DeleteBookRequest.class,
      responseType = com.google.protobuf.Empty.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.example.library.v1.DeleteBookRequest,
      com.google.protobuf.Empty> getDeleteBookMethod() {
    io.grpc.MethodDescriptor<com.google.example.library.v1.DeleteBookRequest, com.google.protobuf.Empty> getDeleteBookMethod;
    if ((getDeleteBookMethod = LibraryServiceGrpc.getDeleteBookMethod) == null) {
      synchronized (LibraryServiceGrpc.class) {
        if ((getDeleteBookMethod = LibraryServiceGrpc.getDeleteBookMethod) == null) {
          LibraryServiceGrpc.getDeleteBookMethod = getDeleteBookMethod =
              io.grpc.MethodDescriptor.<com.google.example.library.v1.DeleteBookRequest, com.google.protobuf.Empty>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "DeleteBook"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.example.library.v1.DeleteBookRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.protobuf.Empty.getDefaultInstance()))
              .setSchemaDescriptor(new LibraryServiceMethodDescriptorSupplier("DeleteBook"))
              .build();
        }
      }
    }
    return getDeleteBookMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.example.library.v1.UpdateBookRequest,
      com.google.example.library.v1.Book> getUpdateBookMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "UpdateBook",
      requestType = com.google.example.library.v1.UpdateBookRequest.class,
      responseType = com.google.example.library.v1.Book.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.example.library.v1.UpdateBookRequest,
      com.google.example.library.v1.Book> getUpdateBookMethod() {
    io.grpc.MethodDescriptor<com.google.example.library.v1.UpdateBookRequest, com.google.example.library.v1.Book> getUpdateBookMethod;
    if ((getUpdateBookMethod = LibraryServiceGrpc.getUpdateBookMethod) == null) {
      synchronized (LibraryServiceGrpc.class) {
        if ((getUpdateBookMethod = LibraryServiceGrpc.getUpdateBookMethod) == null) {
          LibraryServiceGrpc.getUpdateBookMethod = getUpdateBookMethod =
              io.grpc.MethodDescriptor.<com.google.example.library.v1.UpdateBookRequest, com.google.example.library.v1.Book>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "UpdateBook"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.example.library.v1.UpdateBookRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.example.library.v1.Book.getDefaultInstance()))
              .setSchemaDescriptor(new LibraryServiceMethodDescriptorSupplier("UpdateBook"))
              .build();
        }
      }
    }
    return getUpdateBookMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.example.library.v1.MoveBookRequest,
      com.google.example.library.v1.Book> getMoveBookMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "MoveBook",
      requestType = com.google.example.library.v1.MoveBookRequest.class,
      responseType = com.google.example.library.v1.Book.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.example.library.v1.MoveBookRequest,
      com.google.example.library.v1.Book> getMoveBookMethod() {
    io.grpc.MethodDescriptor<com.google.example.library.v1.MoveBookRequest, com.google.example.library.v1.Book> getMoveBookMethod;
    if ((getMoveBookMethod = LibraryServiceGrpc.getMoveBookMethod) == null) {
      synchronized (LibraryServiceGrpc.class) {
        if ((getMoveBookMethod = LibraryServiceGrpc.getMoveBookMethod) == null) {
          LibraryServiceGrpc.getMoveBookMethod = getMoveBookMethod =
              io.grpc.MethodDescriptor.<com.google.example.library.v1.MoveBookRequest, com.google.example.library.v1.Book>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "MoveBook"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.example.library.v1.MoveBookRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.example.library.v1.Book.getDefaultInstance()))
              .setSchemaDescriptor(new LibraryServiceMethodDescriptorSupplier("MoveBook"))
              .build();
        }
      }
    }
    return getMoveBookMethod;
  }

  /**
   * Creates a new async stub that supports all call types for the service
   */
  public static LibraryServiceStub newStub(io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<LibraryServiceStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<LibraryServiceStub>() {
        @java.lang.Override
        public LibraryServiceStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new LibraryServiceStub(channel, callOptions);
        }
      };
    return LibraryServiceStub.newStub(factory, channel);
  }

  /**
   * Creates a new blocking-style stub that supports unary and streaming output calls on the service
   */
  public static LibraryServiceBlockingStub newBlockingStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<LibraryServiceBlockingStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<LibraryServiceBlockingStub>() {
        @java.lang.Override
        public LibraryServiceBlockingStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new LibraryServiceBlockingStub(channel, callOptions);
        }
      };
    return LibraryServiceBlockingStub.newStub(factory, channel);
  }

  /**
   * Creates a new ListenableFuture-style stub that supports unary calls on the service
   */
  public static LibraryServiceFutureStub newFutureStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<LibraryServiceFutureStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<LibraryServiceFutureStub>() {
        @java.lang.Override
        public LibraryServiceFutureStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new LibraryServiceFutureStub(channel, callOptions);
        }
      };
    return LibraryServiceFutureStub.newStub(factory, channel);
  }

  /**
   * <pre>
   * This API represents a simple digital library. It lets you manage Shelf
   * resources and Book resources in the library. It defines the following
   * resource model:
   * - The API has a collection of [Shelf][google.example.library.v1.Shelf]
   *   resources, named `shelves/&#42;`
   * - Each Shelf has a collection of [Book][google.example.library.v1.Book]
   *   resources, named `shelves/&#42;&#47;books/&#42;`
   * </pre>
   */
  public static abstract class LibraryServiceImplBase implements io.grpc.BindableService {

    /**
     * <pre>
     * Creates a shelf, and returns the new Shelf.
     * </pre>
     */
    public void createShelf(com.google.example.library.v1.CreateShelfRequest request,
        io.grpc.stub.StreamObserver<com.google.example.library.v1.Shelf> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getCreateShelfMethod(), responseObserver);
    }

    /**
     * <pre>
     * Gets a shelf. Returns NOT_FOUND if the shelf does not exist.
     * </pre>
     */
    public void getShelf(com.google.example.library.v1.GetShelfRequest request,
        io.grpc.stub.StreamObserver<com.google.example.library.v1.Shelf> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getGetShelfMethod(), responseObserver);
    }

    /**
     * <pre>
     * Lists shelves. The order is unspecified but deterministic. Newly created
     * shelves will not necessarily be added to the end of this list.
     * </pre>
     */
    public void listShelves(com.google.example.library.v1.ListShelvesRequest request,
        io.grpc.stub.StreamObserver<com.google.example.library.v1.ListShelvesResponse> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getListShelvesMethod(), responseObserver);
    }

    /**
     * <pre>
     * Deletes a shelf. Returns NOT_FOUND if the shelf does not exist.
     * </pre>
     */
    public void deleteShelf(com.google.example.library.v1.DeleteShelfRequest request,
        io.grpc.stub.StreamObserver<com.google.protobuf.Empty> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getDeleteShelfMethod(), responseObserver);
    }

    /**
     * <pre>
     * Merges two shelves by adding all books from the shelf named
     * `other_shelf_name` to shelf `name`, and deletes
     * `other_shelf_name`. Returns the updated shelf.
     * The book ids of the moved books may not be the same as the original books.
     * Returns NOT_FOUND if either shelf does not exist.
     * This call is a no-op if the specified shelves are the same.
     * </pre>
     */
    public void mergeShelves(com.google.example.library.v1.MergeShelvesRequest request,
        io.grpc.stub.StreamObserver<com.google.example.library.v1.Shelf> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getMergeShelvesMethod(), responseObserver);
    }

    /**
     * <pre>
     * Creates a book, and returns the new Book.
     * </pre>
     */
    public void createBook(com.google.example.library.v1.CreateBookRequest request,
        io.grpc.stub.StreamObserver<com.google.example.library.v1.Book> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getCreateBookMethod(), responseObserver);
    }

    /**
     * <pre>
     * Gets a book. Returns NOT_FOUND if the book does not exist.
     * </pre>
     */
    public void getBook(com.google.example.library.v1.GetBookRequest request,
        io.grpc.stub.StreamObserver<com.google.example.library.v1.Book> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getGetBookMethod(), responseObserver);
    }

    /**
     * <pre>
     * Lists books in a shelf. The order is unspecified but deterministic. Newly
     * created books will not necessarily be added to the end of this list.
     * Returns NOT_FOUND if the shelf does not exist.
     * </pre>
     */
    public void listBooks(com.google.example.library.v1.ListBooksRequest request,
        io.grpc.stub.StreamObserver<com.google.example.library.v1.ListBooksResponse> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getListBooksMethod(), responseObserver);
    }

    /**
     * <pre>
     * Deletes a book. Returns NOT_FOUND if the book does not exist.
     * </pre>
     */
    public void deleteBook(com.google.example.library.v1.DeleteBookRequest request,
        io.grpc.stub.StreamObserver<com.google.protobuf.Empty> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getDeleteBookMethod(), responseObserver);
    }

    /**
     * <pre>
     * Updates a book. Returns INVALID_ARGUMENT if the name of the book
     * is non-empty and does not equal the existing name.
     * </pre>
     */
    public void updateBook(com.google.example.library.v1.UpdateBookRequest request,
        io.grpc.stub.StreamObserver<com.google.example.library.v1.Book> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getUpdateBookMethod(), responseObserver);
    }

    /**
     * <pre>
     * Moves a book to another shelf, and returns the new book. The book
     * id of the new book may not be the same as the original book.
     * </pre>
     */
    public void moveBook(com.google.example.library.v1.MoveBookRequest request,
        io.grpc.stub.StreamObserver<com.google.example.library.v1.Book> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getMoveBookMethod(), responseObserver);
    }

    @java.lang.Override public final io.grpc.ServerServiceDefinition bindService() {
      return io.grpc.ServerServiceDefinition.builder(getServiceDescriptor())
          .addMethod(
            getCreateShelfMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.example.library.v1.CreateShelfRequest,
                com.google.example.library.v1.Shelf>(
                  this, METHODID_CREATE_SHELF)))
          .addMethod(
            getGetShelfMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.example.library.v1.GetShelfRequest,
                com.google.example.library.v1.Shelf>(
                  this, METHODID_GET_SHELF)))
          .addMethod(
            getListShelvesMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.example.library.v1.ListShelvesRequest,
                com.google.example.library.v1.ListShelvesResponse>(
                  this, METHODID_LIST_SHELVES)))
          .addMethod(
            getDeleteShelfMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.example.library.v1.DeleteShelfRequest,
                com.google.protobuf.Empty>(
                  this, METHODID_DELETE_SHELF)))
          .addMethod(
            getMergeShelvesMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.example.library.v1.MergeShelvesRequest,
                com.google.example.library.v1.Shelf>(
                  this, METHODID_MERGE_SHELVES)))
          .addMethod(
            getCreateBookMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.example.library.v1.CreateBookRequest,
                com.google.example.library.v1.Book>(
                  this, METHODID_CREATE_BOOK)))
          .addMethod(
            getGetBookMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.example.library.v1.GetBookRequest,
                com.google.example.library.v1.Book>(
                  this, METHODID_GET_BOOK)))
          .addMethod(
            getListBooksMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.example.library.v1.ListBooksRequest,
                com.google.example.library.v1.ListBooksResponse>(
                  this, METHODID_LIST_BOOKS)))
          .addMethod(
            getDeleteBookMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.example.library.v1.DeleteBookRequest,
                com.google.protobuf.Empty>(
                  this, METHODID_DELETE_BOOK)))
          .addMethod(
            getUpdateBookMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.example.library.v1.UpdateBookRequest,
                com.google.example.library.v1.Book>(
                  this, METHODID_UPDATE_BOOK)))
          .addMethod(
            getMoveBookMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.example.library.v1.MoveBookRequest,
                com.google.example.library.v1.Book>(
                  this, METHODID_MOVE_BOOK)))
          .build();
    }
  }

  /**
   * <pre>
   * This API represents a simple digital library. It lets you manage Shelf
   * resources and Book resources in the library. It defines the following
   * resource model:
   * - The API has a collection of [Shelf][google.example.library.v1.Shelf]
   *   resources, named `shelves/&#42;`
   * - Each Shelf has a collection of [Book][google.example.library.v1.Book]
   *   resources, named `shelves/&#42;&#47;books/&#42;`
   * </pre>
   */
  public static final class LibraryServiceStub extends io.grpc.stub.AbstractAsyncStub<LibraryServiceStub> {
    private LibraryServiceStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected LibraryServiceStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new LibraryServiceStub(channel, callOptions);
    }

    /**
     * <pre>
     * Creates a shelf, and returns the new Shelf.
     * </pre>
     */
    public void createShelf(com.google.example.library.v1.CreateShelfRequest request,
        io.grpc.stub.StreamObserver<com.google.example.library.v1.Shelf> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getCreateShelfMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Gets a shelf. Returns NOT_FOUND if the shelf does not exist.
     * </pre>
     */
    public void getShelf(com.google.example.library.v1.GetShelfRequest request,
        io.grpc.stub.StreamObserver<com.google.example.library.v1.Shelf> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getGetShelfMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Lists shelves. The order is unspecified but deterministic. Newly created
     * shelves will not necessarily be added to the end of this list.
     * </pre>
     */
    public void listShelves(com.google.example.library.v1.ListShelvesRequest request,
        io.grpc.stub.StreamObserver<com.google.example.library.v1.ListShelvesResponse> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getListShelvesMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Deletes a shelf. Returns NOT_FOUND if the shelf does not exist.
     * </pre>
     */
    public void deleteShelf(com.google.example.library.v1.DeleteShelfRequest request,
        io.grpc.stub.StreamObserver<com.google.protobuf.Empty> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getDeleteShelfMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Merges two shelves by adding all books from the shelf named
     * `other_shelf_name` to shelf `name`, and deletes
     * `other_shelf_name`. Returns the updated shelf.
     * The book ids of the moved books may not be the same as the original books.
     * Returns NOT_FOUND if either shelf does not exist.
     * This call is a no-op if the specified shelves are the same.
     * </pre>
     */
    public void mergeShelves(com.google.example.library.v1.MergeShelvesRequest request,
        io.grpc.stub.StreamObserver<com.google.example.library.v1.Shelf> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getMergeShelvesMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Creates a book, and returns the new Book.
     * </pre>
     */
    public void createBook(com.google.example.library.v1.CreateBookRequest request,
        io.grpc.stub.StreamObserver<com.google.example.library.v1.Book> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getCreateBookMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Gets a book. Returns NOT_FOUND if the book does not exist.
     * </pre>
     */
    public void getBook(com.google.example.library.v1.GetBookRequest request,
        io.grpc.stub.StreamObserver<com.google.example.library.v1.Book> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getGetBookMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Lists books in a shelf. The order is unspecified but deterministic. Newly
     * created books will not necessarily be added to the end of this list.
     * Returns NOT_FOUND if the shelf does not exist.
     * </pre>
     */
    public void listBooks(com.google.example.library.v1.ListBooksRequest request,
        io.grpc.stub.StreamObserver<com.google.example.library.v1.ListBooksResponse> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getListBooksMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Deletes a book. Returns NOT_FOUND if the book does not exist.
     * </pre>
     */
    public void deleteBook(com.google.example.library.v1.DeleteBookRequest request,
        io.grpc.stub.StreamObserver<com.google.protobuf.Empty> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getDeleteBookMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Updates a book. Returns INVALID_ARGUMENT if the name of the book
     * is non-empty and does not equal the existing name.
     * </pre>
     */
    public void updateBook(com.google.example.library.v1.UpdateBookRequest request,
        io.grpc.stub.StreamObserver<com.google.example.library.v1.Book> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getUpdateBookMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Moves a book to another shelf, and returns the new book. The book
     * id of the new book may not be the same as the original book.
     * </pre>
     */
    public void moveBook(com.google.example.library.v1.MoveBookRequest request,
        io.grpc.stub.StreamObserver<com.google.example.library.v1.Book> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getMoveBookMethod(), getCallOptions()), request, responseObserver);
    }
  }

  /**
   * <pre>
   * This API represents a simple digital library. It lets you manage Shelf
   * resources and Book resources in the library. It defines the following
   * resource model:
   * - The API has a collection of [Shelf][google.example.library.v1.Shelf]
   *   resources, named `shelves/&#42;`
   * - Each Shelf has a collection of [Book][google.example.library.v1.Book]
   *   resources, named `shelves/&#42;&#47;books/&#42;`
   * </pre>
   */
  public static final class LibraryServiceBlockingStub extends io.grpc.stub.AbstractBlockingStub<LibraryServiceBlockingStub> {
    private LibraryServiceBlockingStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected LibraryServiceBlockingStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new LibraryServiceBlockingStub(channel, callOptions);
    }

    /**
     * <pre>
     * Creates a shelf, and returns the new Shelf.
     * </pre>
     */
    public com.google.example.library.v1.Shelf createShelf(com.google.example.library.v1.CreateShelfRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getCreateShelfMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Gets a shelf. Returns NOT_FOUND if the shelf does not exist.
     * </pre>
     */
    public com.google.example.library.v1.Shelf getShelf(com.google.example.library.v1.GetShelfRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getGetShelfMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Lists shelves. The order is unspecified but deterministic. Newly created
     * shelves will not necessarily be added to the end of this list.
     * </pre>
     */
    public com.google.example.library.v1.ListShelvesResponse listShelves(com.google.example.library.v1.ListShelvesRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getListShelvesMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Deletes a shelf. Returns NOT_FOUND if the shelf does not exist.
     * </pre>
     */
    public com.google.protobuf.Empty deleteShelf(com.google.example.library.v1.DeleteShelfRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getDeleteShelfMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Merges two shelves by adding all books from the shelf named
     * `other_shelf_name` to shelf `name`, and deletes
     * `other_shelf_name`. Returns the updated shelf.
     * The book ids of the moved books may not be the same as the original books.
     * Returns NOT_FOUND if either shelf does not exist.
     * This call is a no-op if the specified shelves are the same.
     * </pre>
     */
    public com.google.example.library.v1.Shelf mergeShelves(com.google.example.library.v1.MergeShelvesRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getMergeShelvesMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Creates a book, and returns the new Book.
     * </pre>
     */
    public com.google.example.library.v1.Book createBook(com.google.example.library.v1.CreateBookRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getCreateBookMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Gets a book. Returns NOT_FOUND if the book does not exist.
     * </pre>
     */
    public com.google.example.library.v1.Book getBook(com.google.example.library.v1.GetBookRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getGetBookMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Lists books in a shelf. The order is unspecified but deterministic. Newly
     * created books will not necessarily be added to the end of this list.
     * Returns NOT_FOUND if the shelf does not exist.
     * </pre>
     */
    public com.google.example.library.v1.ListBooksResponse listBooks(com.google.example.library.v1.ListBooksRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getListBooksMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Deletes a book. Returns NOT_FOUND if the book does not exist.
     * </pre>
     */
    public com.google.protobuf.Empty deleteBook(com.google.example.library.v1.DeleteBookRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getDeleteBookMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Updates a book. Returns INVALID_ARGUMENT if the name of the book
     * is non-empty and does not equal the existing name.
     * </pre>
     */
    public com.google.example.library.v1.Book updateBook(com.google.example.library.v1.UpdateBookRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getUpdateBookMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Moves a book to another shelf, and returns the new book. The book
     * id of the new book may not be the same as the original book.
     * </pre>
     */
    public com.google.example.library.v1.Book moveBook(com.google.example.library.v1.MoveBookRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getMoveBookMethod(), getCallOptions(), request);
    }
  }

  /**
   * <pre>
   * This API represents a simple digital library. It lets you manage Shelf
   * resources and Book resources in the library. It defines the following
   * resource model:
   * - The API has a collection of [Shelf][google.example.library.v1.Shelf]
   *   resources, named `shelves/&#42;`
   * - Each Shelf has a collection of [Book][google.example.library.v1.Book]
   *   resources, named `shelves/&#42;&#47;books/&#42;`
   * </pre>
   */
  public static final class LibraryServiceFutureStub extends io.grpc.stub.AbstractFutureStub<LibraryServiceFutureStub> {
    private LibraryServiceFutureStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected LibraryServiceFutureStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new LibraryServiceFutureStub(channel, callOptions);
    }

    /**
     * <pre>
     * Creates a shelf, and returns the new Shelf.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.example.library.v1.Shelf> createShelf(
        com.google.example.library.v1.CreateShelfRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getCreateShelfMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Gets a shelf. Returns NOT_FOUND if the shelf does not exist.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.example.library.v1.Shelf> getShelf(
        com.google.example.library.v1.GetShelfRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getGetShelfMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Lists shelves. The order is unspecified but deterministic. Newly created
     * shelves will not necessarily be added to the end of this list.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.example.library.v1.ListShelvesResponse> listShelves(
        com.google.example.library.v1.ListShelvesRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getListShelvesMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Deletes a shelf. Returns NOT_FOUND if the shelf does not exist.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.protobuf.Empty> deleteShelf(
        com.google.example.library.v1.DeleteShelfRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getDeleteShelfMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Merges two shelves by adding all books from the shelf named
     * `other_shelf_name` to shelf `name`, and deletes
     * `other_shelf_name`. Returns the updated shelf.
     * The book ids of the moved books may not be the same as the original books.
     * Returns NOT_FOUND if either shelf does not exist.
     * This call is a no-op if the specified shelves are the same.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.example.library.v1.Shelf> mergeShelves(
        com.google.example.library.v1.MergeShelvesRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getMergeShelvesMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Creates a book, and returns the new Book.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.example.library.v1.Book> createBook(
        com.google.example.library.v1.CreateBookRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getCreateBookMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Gets a book. Returns NOT_FOUND if the book does not exist.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.example.library.v1.Book> getBook(
        com.google.example.library.v1.GetBookRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getGetBookMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Lists books in a shelf. The order is unspecified but deterministic. Newly
     * created books will not necessarily be added to the end of this list.
     * Returns NOT_FOUND if the shelf does not exist.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.example.library.v1.ListBooksResponse> listBooks(
        com.google.example.library.v1.ListBooksRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getListBooksMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Deletes a book. Returns NOT_FOUND if the book does not exist.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.protobuf.Empty> deleteBook(
        com.google.example.library.v1.DeleteBookRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getDeleteBookMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Updates a book. Returns INVALID_ARGUMENT if the name of the book
     * is non-empty and does not equal the existing name.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.example.library.v1.Book> updateBook(
        com.google.example.library.v1.UpdateBookRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getUpdateBookMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Moves a book to another shelf, and returns the new book. The book
     * id of the new book may not be the same as the original book.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.example.library.v1.Book> moveBook(
        com.google.example.library.v1.MoveBookRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getMoveBookMethod(), getCallOptions()), request);
    }
  }

  private static final int METHODID_CREATE_SHELF = 0;
  private static final int METHODID_GET_SHELF = 1;
  private static final int METHODID_LIST_SHELVES = 2;
  private static final int METHODID_DELETE_SHELF = 3;
  private static final int METHODID_MERGE_SHELVES = 4;
  private static final int METHODID_CREATE_BOOK = 5;
  private static final int METHODID_GET_BOOK = 6;
  private static final int METHODID_LIST_BOOKS = 7;
  private static final int METHODID_DELETE_BOOK = 8;
  private static final int METHODID_UPDATE_BOOK = 9;
  private static final int METHODID_MOVE_BOOK = 10;

  private static final class MethodHandlers<Req, Resp> implements
      io.grpc.stub.ServerCalls.UnaryMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ServerStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ClientStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.BidiStreamingMethod<Req, Resp> {
    private final LibraryServiceImplBase serviceImpl;
    private final int methodId;

    MethodHandlers(LibraryServiceImplBase serviceImpl, int methodId) {
      this.serviceImpl = serviceImpl;
      this.methodId = methodId;
    }

    @java.lang.Override
    @java.lang.SuppressWarnings("unchecked")
    public void invoke(Req request, io.grpc.stub.StreamObserver<Resp> responseObserver) {
      switch (methodId) {
        case METHODID_CREATE_SHELF:
          serviceImpl.createShelf((com.google.example.library.v1.CreateShelfRequest) request,
              (io.grpc.stub.StreamObserver<com.google.example.library.v1.Shelf>) responseObserver);
          break;
        case METHODID_GET_SHELF:
          serviceImpl.getShelf((com.google.example.library.v1.GetShelfRequest) request,
              (io.grpc.stub.StreamObserver<com.google.example.library.v1.Shelf>) responseObserver);
          break;
        case METHODID_LIST_SHELVES:
          serviceImpl.listShelves((com.google.example.library.v1.ListShelvesRequest) request,
              (io.grpc.stub.StreamObserver<com.google.example.library.v1.ListShelvesResponse>) responseObserver);
          break;
        case METHODID_DELETE_SHELF:
          serviceImpl.deleteShelf((com.google.example.library.v1.DeleteShelfRequest) request,
              (io.grpc.stub.StreamObserver<com.google.protobuf.Empty>) responseObserver);
          break;
        case METHODID_MERGE_SHELVES:
          serviceImpl.mergeShelves((com.google.example.library.v1.MergeShelvesRequest) request,
              (io.grpc.stub.StreamObserver<com.google.example.library.v1.Shelf>) responseObserver);
          break;
        case METHODID_CREATE_BOOK:
          serviceImpl.createBook((com.google.example.library.v1.CreateBookRequest) request,
              (io.grpc.stub.StreamObserver<com.google.example.library.v1.Book>) responseObserver);
          break;
        case METHODID_GET_BOOK:
          serviceImpl.getBook((com.google.example.library.v1.GetBookRequest) request,
              (io.grpc.stub.StreamObserver<com.google.example.library.v1.Book>) responseObserver);
          break;
        case METHODID_LIST_BOOKS:
          serviceImpl.listBooks((com.google.example.library.v1.ListBooksRequest) request,
              (io.grpc.stub.StreamObserver<com.google.example.library.v1.ListBooksResponse>) responseObserver);
          break;
        case METHODID_DELETE_BOOK:
          serviceImpl.deleteBook((com.google.example.library.v1.DeleteBookRequest) request,
              (io.grpc.stub.StreamObserver<com.google.protobuf.Empty>) responseObserver);
          break;
        case METHODID_UPDATE_BOOK:
          serviceImpl.updateBook((com.google.example.library.v1.UpdateBookRequest) request,
              (io.grpc.stub.StreamObserver<com.google.example.library.v1.Book>) responseObserver);
          break;
        case METHODID_MOVE_BOOK:
          serviceImpl.moveBook((com.google.example.library.v1.MoveBookRequest) request,
              (io.grpc.stub.StreamObserver<com.google.example.library.v1.Book>) responseObserver);
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

  private static abstract class LibraryServiceBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoFileDescriptorSupplier, io.grpc.protobuf.ProtoServiceDescriptorSupplier {
    LibraryServiceBaseDescriptorSupplier() {}

    @java.lang.Override
    public com.google.protobuf.Descriptors.FileDescriptor getFileDescriptor() {
      return com.google.example.library.v1.LibraryProto.getDescriptor();
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.ServiceDescriptor getServiceDescriptor() {
      return getFileDescriptor().findServiceByName("LibraryService");
    }
  }

  private static final class LibraryServiceFileDescriptorSupplier
      extends LibraryServiceBaseDescriptorSupplier {
    LibraryServiceFileDescriptorSupplier() {}
  }

  private static final class LibraryServiceMethodDescriptorSupplier
      extends LibraryServiceBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoMethodDescriptorSupplier {
    private final String methodName;

    LibraryServiceMethodDescriptorSupplier(String methodName) {
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
      synchronized (LibraryServiceGrpc.class) {
        result = serviceDescriptor;
        if (result == null) {
          serviceDescriptor = result = io.grpc.ServiceDescriptor.newBuilder(SERVICE_NAME)
              .setSchemaDescriptor(new LibraryServiceFileDescriptorSupplier())
              .addMethod(getCreateShelfMethod())
              .addMethod(getGetShelfMethod())
              .addMethod(getListShelvesMethod())
              .addMethod(getDeleteShelfMethod())
              .addMethod(getMergeShelvesMethod())
              .addMethod(getCreateBookMethod())
              .addMethod(getGetBookMethod())
              .addMethod(getListBooksMethod())
              .addMethod(getDeleteBookMethod())
              .addMethod(getUpdateBookMethod())
              .addMethod(getMoveBookMethod())
              .build();
        }
      }
    }
    return result;
  }
}
