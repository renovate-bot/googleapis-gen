package com.google.iam.admin.v1;

import static io.grpc.MethodDescriptor.generateFullMethodName;

/**
 * <pre>
 * Creates and manages service account objects.
 * Service account is an account that belongs to your project instead
 * of to an individual end user. It is used to authenticate calls
 * to a Google API.
 * To create a service account, specify the `project_id` and `account_id`
 * for the account.  The `account_id` is unique within the project, and used
 * to generate the service account email address and a stable
 * `unique_id`.
 * All other methods can identify accounts using the format
 * `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`.
 * Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
 * the account. The `ACCOUNT` value can be the `email` address or the
 * `unique_id` of the service account.
 * </pre>
 */
@javax.annotation.Generated(
    value = "by gRPC proto compiler",
    comments = "Source: google/iam/admin/v1/iam.proto")
public final class IAMGrpc {

  private IAMGrpc() {}

  public static final String SERVICE_NAME = "google.iam.admin.v1.IAM";

  // Static method descriptors that strictly reflect the proto.
  private static volatile io.grpc.MethodDescriptor<com.google.iam.admin.v1.ListServiceAccountsRequest,
      com.google.iam.admin.v1.ListServiceAccountsResponse> getListServiceAccountsMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "ListServiceAccounts",
      requestType = com.google.iam.admin.v1.ListServiceAccountsRequest.class,
      responseType = com.google.iam.admin.v1.ListServiceAccountsResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.iam.admin.v1.ListServiceAccountsRequest,
      com.google.iam.admin.v1.ListServiceAccountsResponse> getListServiceAccountsMethod() {
    io.grpc.MethodDescriptor<com.google.iam.admin.v1.ListServiceAccountsRequest, com.google.iam.admin.v1.ListServiceAccountsResponse> getListServiceAccountsMethod;
    if ((getListServiceAccountsMethod = IAMGrpc.getListServiceAccountsMethod) == null) {
      synchronized (IAMGrpc.class) {
        if ((getListServiceAccountsMethod = IAMGrpc.getListServiceAccountsMethod) == null) {
          IAMGrpc.getListServiceAccountsMethod = getListServiceAccountsMethod =
              io.grpc.MethodDescriptor.<com.google.iam.admin.v1.ListServiceAccountsRequest, com.google.iam.admin.v1.ListServiceAccountsResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "ListServiceAccounts"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.iam.admin.v1.ListServiceAccountsRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.iam.admin.v1.ListServiceAccountsResponse.getDefaultInstance()))
              .setSchemaDescriptor(new IAMMethodDescriptorSupplier("ListServiceAccounts"))
              .build();
        }
      }
    }
    return getListServiceAccountsMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.iam.admin.v1.GetServiceAccountRequest,
      com.google.iam.admin.v1.ServiceAccount> getGetServiceAccountMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "GetServiceAccount",
      requestType = com.google.iam.admin.v1.GetServiceAccountRequest.class,
      responseType = com.google.iam.admin.v1.ServiceAccount.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.iam.admin.v1.GetServiceAccountRequest,
      com.google.iam.admin.v1.ServiceAccount> getGetServiceAccountMethod() {
    io.grpc.MethodDescriptor<com.google.iam.admin.v1.GetServiceAccountRequest, com.google.iam.admin.v1.ServiceAccount> getGetServiceAccountMethod;
    if ((getGetServiceAccountMethod = IAMGrpc.getGetServiceAccountMethod) == null) {
      synchronized (IAMGrpc.class) {
        if ((getGetServiceAccountMethod = IAMGrpc.getGetServiceAccountMethod) == null) {
          IAMGrpc.getGetServiceAccountMethod = getGetServiceAccountMethod =
              io.grpc.MethodDescriptor.<com.google.iam.admin.v1.GetServiceAccountRequest, com.google.iam.admin.v1.ServiceAccount>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "GetServiceAccount"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.iam.admin.v1.GetServiceAccountRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.iam.admin.v1.ServiceAccount.getDefaultInstance()))
              .setSchemaDescriptor(new IAMMethodDescriptorSupplier("GetServiceAccount"))
              .build();
        }
      }
    }
    return getGetServiceAccountMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.iam.admin.v1.CreateServiceAccountRequest,
      com.google.iam.admin.v1.ServiceAccount> getCreateServiceAccountMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "CreateServiceAccount",
      requestType = com.google.iam.admin.v1.CreateServiceAccountRequest.class,
      responseType = com.google.iam.admin.v1.ServiceAccount.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.iam.admin.v1.CreateServiceAccountRequest,
      com.google.iam.admin.v1.ServiceAccount> getCreateServiceAccountMethod() {
    io.grpc.MethodDescriptor<com.google.iam.admin.v1.CreateServiceAccountRequest, com.google.iam.admin.v1.ServiceAccount> getCreateServiceAccountMethod;
    if ((getCreateServiceAccountMethod = IAMGrpc.getCreateServiceAccountMethod) == null) {
      synchronized (IAMGrpc.class) {
        if ((getCreateServiceAccountMethod = IAMGrpc.getCreateServiceAccountMethod) == null) {
          IAMGrpc.getCreateServiceAccountMethod = getCreateServiceAccountMethod =
              io.grpc.MethodDescriptor.<com.google.iam.admin.v1.CreateServiceAccountRequest, com.google.iam.admin.v1.ServiceAccount>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "CreateServiceAccount"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.iam.admin.v1.CreateServiceAccountRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.iam.admin.v1.ServiceAccount.getDefaultInstance()))
              .setSchemaDescriptor(new IAMMethodDescriptorSupplier("CreateServiceAccount"))
              .build();
        }
      }
    }
    return getCreateServiceAccountMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.iam.admin.v1.ServiceAccount,
      com.google.iam.admin.v1.ServiceAccount> getUpdateServiceAccountMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "UpdateServiceAccount",
      requestType = com.google.iam.admin.v1.ServiceAccount.class,
      responseType = com.google.iam.admin.v1.ServiceAccount.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.iam.admin.v1.ServiceAccount,
      com.google.iam.admin.v1.ServiceAccount> getUpdateServiceAccountMethod() {
    io.grpc.MethodDescriptor<com.google.iam.admin.v1.ServiceAccount, com.google.iam.admin.v1.ServiceAccount> getUpdateServiceAccountMethod;
    if ((getUpdateServiceAccountMethod = IAMGrpc.getUpdateServiceAccountMethod) == null) {
      synchronized (IAMGrpc.class) {
        if ((getUpdateServiceAccountMethod = IAMGrpc.getUpdateServiceAccountMethod) == null) {
          IAMGrpc.getUpdateServiceAccountMethod = getUpdateServiceAccountMethod =
              io.grpc.MethodDescriptor.<com.google.iam.admin.v1.ServiceAccount, com.google.iam.admin.v1.ServiceAccount>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "UpdateServiceAccount"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.iam.admin.v1.ServiceAccount.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.iam.admin.v1.ServiceAccount.getDefaultInstance()))
              .setSchemaDescriptor(new IAMMethodDescriptorSupplier("UpdateServiceAccount"))
              .build();
        }
      }
    }
    return getUpdateServiceAccountMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.iam.admin.v1.DeleteServiceAccountRequest,
      com.google.protobuf.Empty> getDeleteServiceAccountMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "DeleteServiceAccount",
      requestType = com.google.iam.admin.v1.DeleteServiceAccountRequest.class,
      responseType = com.google.protobuf.Empty.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.iam.admin.v1.DeleteServiceAccountRequest,
      com.google.protobuf.Empty> getDeleteServiceAccountMethod() {
    io.grpc.MethodDescriptor<com.google.iam.admin.v1.DeleteServiceAccountRequest, com.google.protobuf.Empty> getDeleteServiceAccountMethod;
    if ((getDeleteServiceAccountMethod = IAMGrpc.getDeleteServiceAccountMethod) == null) {
      synchronized (IAMGrpc.class) {
        if ((getDeleteServiceAccountMethod = IAMGrpc.getDeleteServiceAccountMethod) == null) {
          IAMGrpc.getDeleteServiceAccountMethod = getDeleteServiceAccountMethod =
              io.grpc.MethodDescriptor.<com.google.iam.admin.v1.DeleteServiceAccountRequest, com.google.protobuf.Empty>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "DeleteServiceAccount"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.iam.admin.v1.DeleteServiceAccountRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.protobuf.Empty.getDefaultInstance()))
              .setSchemaDescriptor(new IAMMethodDescriptorSupplier("DeleteServiceAccount"))
              .build();
        }
      }
    }
    return getDeleteServiceAccountMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.iam.admin.v1.ListServiceAccountKeysRequest,
      com.google.iam.admin.v1.ListServiceAccountKeysResponse> getListServiceAccountKeysMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "ListServiceAccountKeys",
      requestType = com.google.iam.admin.v1.ListServiceAccountKeysRequest.class,
      responseType = com.google.iam.admin.v1.ListServiceAccountKeysResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.iam.admin.v1.ListServiceAccountKeysRequest,
      com.google.iam.admin.v1.ListServiceAccountKeysResponse> getListServiceAccountKeysMethod() {
    io.grpc.MethodDescriptor<com.google.iam.admin.v1.ListServiceAccountKeysRequest, com.google.iam.admin.v1.ListServiceAccountKeysResponse> getListServiceAccountKeysMethod;
    if ((getListServiceAccountKeysMethod = IAMGrpc.getListServiceAccountKeysMethod) == null) {
      synchronized (IAMGrpc.class) {
        if ((getListServiceAccountKeysMethod = IAMGrpc.getListServiceAccountKeysMethod) == null) {
          IAMGrpc.getListServiceAccountKeysMethod = getListServiceAccountKeysMethod =
              io.grpc.MethodDescriptor.<com.google.iam.admin.v1.ListServiceAccountKeysRequest, com.google.iam.admin.v1.ListServiceAccountKeysResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "ListServiceAccountKeys"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.iam.admin.v1.ListServiceAccountKeysRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.iam.admin.v1.ListServiceAccountKeysResponse.getDefaultInstance()))
              .setSchemaDescriptor(new IAMMethodDescriptorSupplier("ListServiceAccountKeys"))
              .build();
        }
      }
    }
    return getListServiceAccountKeysMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.iam.admin.v1.GetServiceAccountKeyRequest,
      com.google.iam.admin.v1.ServiceAccountKey> getGetServiceAccountKeyMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "GetServiceAccountKey",
      requestType = com.google.iam.admin.v1.GetServiceAccountKeyRequest.class,
      responseType = com.google.iam.admin.v1.ServiceAccountKey.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.iam.admin.v1.GetServiceAccountKeyRequest,
      com.google.iam.admin.v1.ServiceAccountKey> getGetServiceAccountKeyMethod() {
    io.grpc.MethodDescriptor<com.google.iam.admin.v1.GetServiceAccountKeyRequest, com.google.iam.admin.v1.ServiceAccountKey> getGetServiceAccountKeyMethod;
    if ((getGetServiceAccountKeyMethod = IAMGrpc.getGetServiceAccountKeyMethod) == null) {
      synchronized (IAMGrpc.class) {
        if ((getGetServiceAccountKeyMethod = IAMGrpc.getGetServiceAccountKeyMethod) == null) {
          IAMGrpc.getGetServiceAccountKeyMethod = getGetServiceAccountKeyMethod =
              io.grpc.MethodDescriptor.<com.google.iam.admin.v1.GetServiceAccountKeyRequest, com.google.iam.admin.v1.ServiceAccountKey>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "GetServiceAccountKey"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.iam.admin.v1.GetServiceAccountKeyRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.iam.admin.v1.ServiceAccountKey.getDefaultInstance()))
              .setSchemaDescriptor(new IAMMethodDescriptorSupplier("GetServiceAccountKey"))
              .build();
        }
      }
    }
    return getGetServiceAccountKeyMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.iam.admin.v1.CreateServiceAccountKeyRequest,
      com.google.iam.admin.v1.ServiceAccountKey> getCreateServiceAccountKeyMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "CreateServiceAccountKey",
      requestType = com.google.iam.admin.v1.CreateServiceAccountKeyRequest.class,
      responseType = com.google.iam.admin.v1.ServiceAccountKey.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.iam.admin.v1.CreateServiceAccountKeyRequest,
      com.google.iam.admin.v1.ServiceAccountKey> getCreateServiceAccountKeyMethod() {
    io.grpc.MethodDescriptor<com.google.iam.admin.v1.CreateServiceAccountKeyRequest, com.google.iam.admin.v1.ServiceAccountKey> getCreateServiceAccountKeyMethod;
    if ((getCreateServiceAccountKeyMethod = IAMGrpc.getCreateServiceAccountKeyMethod) == null) {
      synchronized (IAMGrpc.class) {
        if ((getCreateServiceAccountKeyMethod = IAMGrpc.getCreateServiceAccountKeyMethod) == null) {
          IAMGrpc.getCreateServiceAccountKeyMethod = getCreateServiceAccountKeyMethod =
              io.grpc.MethodDescriptor.<com.google.iam.admin.v1.CreateServiceAccountKeyRequest, com.google.iam.admin.v1.ServiceAccountKey>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "CreateServiceAccountKey"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.iam.admin.v1.CreateServiceAccountKeyRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.iam.admin.v1.ServiceAccountKey.getDefaultInstance()))
              .setSchemaDescriptor(new IAMMethodDescriptorSupplier("CreateServiceAccountKey"))
              .build();
        }
      }
    }
    return getCreateServiceAccountKeyMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.iam.admin.v1.DeleteServiceAccountKeyRequest,
      com.google.protobuf.Empty> getDeleteServiceAccountKeyMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "DeleteServiceAccountKey",
      requestType = com.google.iam.admin.v1.DeleteServiceAccountKeyRequest.class,
      responseType = com.google.protobuf.Empty.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.iam.admin.v1.DeleteServiceAccountKeyRequest,
      com.google.protobuf.Empty> getDeleteServiceAccountKeyMethod() {
    io.grpc.MethodDescriptor<com.google.iam.admin.v1.DeleteServiceAccountKeyRequest, com.google.protobuf.Empty> getDeleteServiceAccountKeyMethod;
    if ((getDeleteServiceAccountKeyMethod = IAMGrpc.getDeleteServiceAccountKeyMethod) == null) {
      synchronized (IAMGrpc.class) {
        if ((getDeleteServiceAccountKeyMethod = IAMGrpc.getDeleteServiceAccountKeyMethod) == null) {
          IAMGrpc.getDeleteServiceAccountKeyMethod = getDeleteServiceAccountKeyMethod =
              io.grpc.MethodDescriptor.<com.google.iam.admin.v1.DeleteServiceAccountKeyRequest, com.google.protobuf.Empty>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "DeleteServiceAccountKey"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.iam.admin.v1.DeleteServiceAccountKeyRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.protobuf.Empty.getDefaultInstance()))
              .setSchemaDescriptor(new IAMMethodDescriptorSupplier("DeleteServiceAccountKey"))
              .build();
        }
      }
    }
    return getDeleteServiceAccountKeyMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.iam.admin.v1.SignBlobRequest,
      com.google.iam.admin.v1.SignBlobResponse> getSignBlobMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "SignBlob",
      requestType = com.google.iam.admin.v1.SignBlobRequest.class,
      responseType = com.google.iam.admin.v1.SignBlobResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.iam.admin.v1.SignBlobRequest,
      com.google.iam.admin.v1.SignBlobResponse> getSignBlobMethod() {
    io.grpc.MethodDescriptor<com.google.iam.admin.v1.SignBlobRequest, com.google.iam.admin.v1.SignBlobResponse> getSignBlobMethod;
    if ((getSignBlobMethod = IAMGrpc.getSignBlobMethod) == null) {
      synchronized (IAMGrpc.class) {
        if ((getSignBlobMethod = IAMGrpc.getSignBlobMethod) == null) {
          IAMGrpc.getSignBlobMethod = getSignBlobMethod =
              io.grpc.MethodDescriptor.<com.google.iam.admin.v1.SignBlobRequest, com.google.iam.admin.v1.SignBlobResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "SignBlob"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.iam.admin.v1.SignBlobRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.iam.admin.v1.SignBlobResponse.getDefaultInstance()))
              .setSchemaDescriptor(new IAMMethodDescriptorSupplier("SignBlob"))
              .build();
        }
      }
    }
    return getSignBlobMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.iam.admin.v1.SignJwtRequest,
      com.google.iam.admin.v1.SignJwtResponse> getSignJwtMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "SignJwt",
      requestType = com.google.iam.admin.v1.SignJwtRequest.class,
      responseType = com.google.iam.admin.v1.SignJwtResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.iam.admin.v1.SignJwtRequest,
      com.google.iam.admin.v1.SignJwtResponse> getSignJwtMethod() {
    io.grpc.MethodDescriptor<com.google.iam.admin.v1.SignJwtRequest, com.google.iam.admin.v1.SignJwtResponse> getSignJwtMethod;
    if ((getSignJwtMethod = IAMGrpc.getSignJwtMethod) == null) {
      synchronized (IAMGrpc.class) {
        if ((getSignJwtMethod = IAMGrpc.getSignJwtMethod) == null) {
          IAMGrpc.getSignJwtMethod = getSignJwtMethod =
              io.grpc.MethodDescriptor.<com.google.iam.admin.v1.SignJwtRequest, com.google.iam.admin.v1.SignJwtResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "SignJwt"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.iam.admin.v1.SignJwtRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.iam.admin.v1.SignJwtResponse.getDefaultInstance()))
              .setSchemaDescriptor(new IAMMethodDescriptorSupplier("SignJwt"))
              .build();
        }
      }
    }
    return getSignJwtMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.iam.v1.GetIamPolicyRequest,
      com.google.iam.v1.Policy> getGetIamPolicyMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "GetIamPolicy",
      requestType = com.google.iam.v1.GetIamPolicyRequest.class,
      responseType = com.google.iam.v1.Policy.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.iam.v1.GetIamPolicyRequest,
      com.google.iam.v1.Policy> getGetIamPolicyMethod() {
    io.grpc.MethodDescriptor<com.google.iam.v1.GetIamPolicyRequest, com.google.iam.v1.Policy> getGetIamPolicyMethod;
    if ((getGetIamPolicyMethod = IAMGrpc.getGetIamPolicyMethod) == null) {
      synchronized (IAMGrpc.class) {
        if ((getGetIamPolicyMethod = IAMGrpc.getGetIamPolicyMethod) == null) {
          IAMGrpc.getGetIamPolicyMethod = getGetIamPolicyMethod =
              io.grpc.MethodDescriptor.<com.google.iam.v1.GetIamPolicyRequest, com.google.iam.v1.Policy>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "GetIamPolicy"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.iam.v1.GetIamPolicyRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.iam.v1.Policy.getDefaultInstance()))
              .setSchemaDescriptor(new IAMMethodDescriptorSupplier("GetIamPolicy"))
              .build();
        }
      }
    }
    return getGetIamPolicyMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.iam.v1.SetIamPolicyRequest,
      com.google.iam.v1.Policy> getSetIamPolicyMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "SetIamPolicy",
      requestType = com.google.iam.v1.SetIamPolicyRequest.class,
      responseType = com.google.iam.v1.Policy.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.iam.v1.SetIamPolicyRequest,
      com.google.iam.v1.Policy> getSetIamPolicyMethod() {
    io.grpc.MethodDescriptor<com.google.iam.v1.SetIamPolicyRequest, com.google.iam.v1.Policy> getSetIamPolicyMethod;
    if ((getSetIamPolicyMethod = IAMGrpc.getSetIamPolicyMethod) == null) {
      synchronized (IAMGrpc.class) {
        if ((getSetIamPolicyMethod = IAMGrpc.getSetIamPolicyMethod) == null) {
          IAMGrpc.getSetIamPolicyMethod = getSetIamPolicyMethod =
              io.grpc.MethodDescriptor.<com.google.iam.v1.SetIamPolicyRequest, com.google.iam.v1.Policy>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "SetIamPolicy"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.iam.v1.SetIamPolicyRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.iam.v1.Policy.getDefaultInstance()))
              .setSchemaDescriptor(new IAMMethodDescriptorSupplier("SetIamPolicy"))
              .build();
        }
      }
    }
    return getSetIamPolicyMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.iam.v1.TestIamPermissionsRequest,
      com.google.iam.v1.TestIamPermissionsResponse> getTestIamPermissionsMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "TestIamPermissions",
      requestType = com.google.iam.v1.TestIamPermissionsRequest.class,
      responseType = com.google.iam.v1.TestIamPermissionsResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.iam.v1.TestIamPermissionsRequest,
      com.google.iam.v1.TestIamPermissionsResponse> getTestIamPermissionsMethod() {
    io.grpc.MethodDescriptor<com.google.iam.v1.TestIamPermissionsRequest, com.google.iam.v1.TestIamPermissionsResponse> getTestIamPermissionsMethod;
    if ((getTestIamPermissionsMethod = IAMGrpc.getTestIamPermissionsMethod) == null) {
      synchronized (IAMGrpc.class) {
        if ((getTestIamPermissionsMethod = IAMGrpc.getTestIamPermissionsMethod) == null) {
          IAMGrpc.getTestIamPermissionsMethod = getTestIamPermissionsMethod =
              io.grpc.MethodDescriptor.<com.google.iam.v1.TestIamPermissionsRequest, com.google.iam.v1.TestIamPermissionsResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "TestIamPermissions"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.iam.v1.TestIamPermissionsRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.iam.v1.TestIamPermissionsResponse.getDefaultInstance()))
              .setSchemaDescriptor(new IAMMethodDescriptorSupplier("TestIamPermissions"))
              .build();
        }
      }
    }
    return getTestIamPermissionsMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.iam.admin.v1.QueryGrantableRolesRequest,
      com.google.iam.admin.v1.QueryGrantableRolesResponse> getQueryGrantableRolesMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "QueryGrantableRoles",
      requestType = com.google.iam.admin.v1.QueryGrantableRolesRequest.class,
      responseType = com.google.iam.admin.v1.QueryGrantableRolesResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.iam.admin.v1.QueryGrantableRolesRequest,
      com.google.iam.admin.v1.QueryGrantableRolesResponse> getQueryGrantableRolesMethod() {
    io.grpc.MethodDescriptor<com.google.iam.admin.v1.QueryGrantableRolesRequest, com.google.iam.admin.v1.QueryGrantableRolesResponse> getQueryGrantableRolesMethod;
    if ((getQueryGrantableRolesMethod = IAMGrpc.getQueryGrantableRolesMethod) == null) {
      synchronized (IAMGrpc.class) {
        if ((getQueryGrantableRolesMethod = IAMGrpc.getQueryGrantableRolesMethod) == null) {
          IAMGrpc.getQueryGrantableRolesMethod = getQueryGrantableRolesMethod =
              io.grpc.MethodDescriptor.<com.google.iam.admin.v1.QueryGrantableRolesRequest, com.google.iam.admin.v1.QueryGrantableRolesResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "QueryGrantableRoles"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.iam.admin.v1.QueryGrantableRolesRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.iam.admin.v1.QueryGrantableRolesResponse.getDefaultInstance()))
              .setSchemaDescriptor(new IAMMethodDescriptorSupplier("QueryGrantableRoles"))
              .build();
        }
      }
    }
    return getQueryGrantableRolesMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.iam.admin.v1.ListRolesRequest,
      com.google.iam.admin.v1.ListRolesResponse> getListRolesMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "ListRoles",
      requestType = com.google.iam.admin.v1.ListRolesRequest.class,
      responseType = com.google.iam.admin.v1.ListRolesResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.iam.admin.v1.ListRolesRequest,
      com.google.iam.admin.v1.ListRolesResponse> getListRolesMethod() {
    io.grpc.MethodDescriptor<com.google.iam.admin.v1.ListRolesRequest, com.google.iam.admin.v1.ListRolesResponse> getListRolesMethod;
    if ((getListRolesMethod = IAMGrpc.getListRolesMethod) == null) {
      synchronized (IAMGrpc.class) {
        if ((getListRolesMethod = IAMGrpc.getListRolesMethod) == null) {
          IAMGrpc.getListRolesMethod = getListRolesMethod =
              io.grpc.MethodDescriptor.<com.google.iam.admin.v1.ListRolesRequest, com.google.iam.admin.v1.ListRolesResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "ListRoles"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.iam.admin.v1.ListRolesRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.iam.admin.v1.ListRolesResponse.getDefaultInstance()))
              .setSchemaDescriptor(new IAMMethodDescriptorSupplier("ListRoles"))
              .build();
        }
      }
    }
    return getListRolesMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.iam.admin.v1.GetRoleRequest,
      com.google.iam.admin.v1.Role> getGetRoleMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "GetRole",
      requestType = com.google.iam.admin.v1.GetRoleRequest.class,
      responseType = com.google.iam.admin.v1.Role.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.iam.admin.v1.GetRoleRequest,
      com.google.iam.admin.v1.Role> getGetRoleMethod() {
    io.grpc.MethodDescriptor<com.google.iam.admin.v1.GetRoleRequest, com.google.iam.admin.v1.Role> getGetRoleMethod;
    if ((getGetRoleMethod = IAMGrpc.getGetRoleMethod) == null) {
      synchronized (IAMGrpc.class) {
        if ((getGetRoleMethod = IAMGrpc.getGetRoleMethod) == null) {
          IAMGrpc.getGetRoleMethod = getGetRoleMethod =
              io.grpc.MethodDescriptor.<com.google.iam.admin.v1.GetRoleRequest, com.google.iam.admin.v1.Role>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "GetRole"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.iam.admin.v1.GetRoleRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.iam.admin.v1.Role.getDefaultInstance()))
              .setSchemaDescriptor(new IAMMethodDescriptorSupplier("GetRole"))
              .build();
        }
      }
    }
    return getGetRoleMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.iam.admin.v1.CreateRoleRequest,
      com.google.iam.admin.v1.Role> getCreateRoleMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "CreateRole",
      requestType = com.google.iam.admin.v1.CreateRoleRequest.class,
      responseType = com.google.iam.admin.v1.Role.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.iam.admin.v1.CreateRoleRequest,
      com.google.iam.admin.v1.Role> getCreateRoleMethod() {
    io.grpc.MethodDescriptor<com.google.iam.admin.v1.CreateRoleRequest, com.google.iam.admin.v1.Role> getCreateRoleMethod;
    if ((getCreateRoleMethod = IAMGrpc.getCreateRoleMethod) == null) {
      synchronized (IAMGrpc.class) {
        if ((getCreateRoleMethod = IAMGrpc.getCreateRoleMethod) == null) {
          IAMGrpc.getCreateRoleMethod = getCreateRoleMethod =
              io.grpc.MethodDescriptor.<com.google.iam.admin.v1.CreateRoleRequest, com.google.iam.admin.v1.Role>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "CreateRole"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.iam.admin.v1.CreateRoleRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.iam.admin.v1.Role.getDefaultInstance()))
              .setSchemaDescriptor(new IAMMethodDescriptorSupplier("CreateRole"))
              .build();
        }
      }
    }
    return getCreateRoleMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.iam.admin.v1.UpdateRoleRequest,
      com.google.iam.admin.v1.Role> getUpdateRoleMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "UpdateRole",
      requestType = com.google.iam.admin.v1.UpdateRoleRequest.class,
      responseType = com.google.iam.admin.v1.Role.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.iam.admin.v1.UpdateRoleRequest,
      com.google.iam.admin.v1.Role> getUpdateRoleMethod() {
    io.grpc.MethodDescriptor<com.google.iam.admin.v1.UpdateRoleRequest, com.google.iam.admin.v1.Role> getUpdateRoleMethod;
    if ((getUpdateRoleMethod = IAMGrpc.getUpdateRoleMethod) == null) {
      synchronized (IAMGrpc.class) {
        if ((getUpdateRoleMethod = IAMGrpc.getUpdateRoleMethod) == null) {
          IAMGrpc.getUpdateRoleMethod = getUpdateRoleMethod =
              io.grpc.MethodDescriptor.<com.google.iam.admin.v1.UpdateRoleRequest, com.google.iam.admin.v1.Role>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "UpdateRole"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.iam.admin.v1.UpdateRoleRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.iam.admin.v1.Role.getDefaultInstance()))
              .setSchemaDescriptor(new IAMMethodDescriptorSupplier("UpdateRole"))
              .build();
        }
      }
    }
    return getUpdateRoleMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.iam.admin.v1.DeleteRoleRequest,
      com.google.iam.admin.v1.Role> getDeleteRoleMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "DeleteRole",
      requestType = com.google.iam.admin.v1.DeleteRoleRequest.class,
      responseType = com.google.iam.admin.v1.Role.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.iam.admin.v1.DeleteRoleRequest,
      com.google.iam.admin.v1.Role> getDeleteRoleMethod() {
    io.grpc.MethodDescriptor<com.google.iam.admin.v1.DeleteRoleRequest, com.google.iam.admin.v1.Role> getDeleteRoleMethod;
    if ((getDeleteRoleMethod = IAMGrpc.getDeleteRoleMethod) == null) {
      synchronized (IAMGrpc.class) {
        if ((getDeleteRoleMethod = IAMGrpc.getDeleteRoleMethod) == null) {
          IAMGrpc.getDeleteRoleMethod = getDeleteRoleMethod =
              io.grpc.MethodDescriptor.<com.google.iam.admin.v1.DeleteRoleRequest, com.google.iam.admin.v1.Role>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "DeleteRole"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.iam.admin.v1.DeleteRoleRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.iam.admin.v1.Role.getDefaultInstance()))
              .setSchemaDescriptor(new IAMMethodDescriptorSupplier("DeleteRole"))
              .build();
        }
      }
    }
    return getDeleteRoleMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.iam.admin.v1.UndeleteRoleRequest,
      com.google.iam.admin.v1.Role> getUndeleteRoleMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "UndeleteRole",
      requestType = com.google.iam.admin.v1.UndeleteRoleRequest.class,
      responseType = com.google.iam.admin.v1.Role.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.iam.admin.v1.UndeleteRoleRequest,
      com.google.iam.admin.v1.Role> getUndeleteRoleMethod() {
    io.grpc.MethodDescriptor<com.google.iam.admin.v1.UndeleteRoleRequest, com.google.iam.admin.v1.Role> getUndeleteRoleMethod;
    if ((getUndeleteRoleMethod = IAMGrpc.getUndeleteRoleMethod) == null) {
      synchronized (IAMGrpc.class) {
        if ((getUndeleteRoleMethod = IAMGrpc.getUndeleteRoleMethod) == null) {
          IAMGrpc.getUndeleteRoleMethod = getUndeleteRoleMethod =
              io.grpc.MethodDescriptor.<com.google.iam.admin.v1.UndeleteRoleRequest, com.google.iam.admin.v1.Role>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "UndeleteRole"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.iam.admin.v1.UndeleteRoleRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.iam.admin.v1.Role.getDefaultInstance()))
              .setSchemaDescriptor(new IAMMethodDescriptorSupplier("UndeleteRole"))
              .build();
        }
      }
    }
    return getUndeleteRoleMethod;
  }

  private static volatile io.grpc.MethodDescriptor<com.google.iam.admin.v1.QueryTestablePermissionsRequest,
      com.google.iam.admin.v1.QueryTestablePermissionsResponse> getQueryTestablePermissionsMethod;

  @io.grpc.stub.annotations.RpcMethod(
      fullMethodName = SERVICE_NAME + '/' + "QueryTestablePermissions",
      requestType = com.google.iam.admin.v1.QueryTestablePermissionsRequest.class,
      responseType = com.google.iam.admin.v1.QueryTestablePermissionsResponse.class,
      methodType = io.grpc.MethodDescriptor.MethodType.UNARY)
  public static io.grpc.MethodDescriptor<com.google.iam.admin.v1.QueryTestablePermissionsRequest,
      com.google.iam.admin.v1.QueryTestablePermissionsResponse> getQueryTestablePermissionsMethod() {
    io.grpc.MethodDescriptor<com.google.iam.admin.v1.QueryTestablePermissionsRequest, com.google.iam.admin.v1.QueryTestablePermissionsResponse> getQueryTestablePermissionsMethod;
    if ((getQueryTestablePermissionsMethod = IAMGrpc.getQueryTestablePermissionsMethod) == null) {
      synchronized (IAMGrpc.class) {
        if ((getQueryTestablePermissionsMethod = IAMGrpc.getQueryTestablePermissionsMethod) == null) {
          IAMGrpc.getQueryTestablePermissionsMethod = getQueryTestablePermissionsMethod =
              io.grpc.MethodDescriptor.<com.google.iam.admin.v1.QueryTestablePermissionsRequest, com.google.iam.admin.v1.QueryTestablePermissionsResponse>newBuilder()
              .setType(io.grpc.MethodDescriptor.MethodType.UNARY)
              .setFullMethodName(generateFullMethodName(SERVICE_NAME, "QueryTestablePermissions"))
              .setSampledToLocalTracing(true)
              .setRequestMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.iam.admin.v1.QueryTestablePermissionsRequest.getDefaultInstance()))
              .setResponseMarshaller(io.grpc.protobuf.ProtoUtils.marshaller(
                  com.google.iam.admin.v1.QueryTestablePermissionsResponse.getDefaultInstance()))
              .setSchemaDescriptor(new IAMMethodDescriptorSupplier("QueryTestablePermissions"))
              .build();
        }
      }
    }
    return getQueryTestablePermissionsMethod;
  }

  /**
   * Creates a new async stub that supports all call types for the service
   */
  public static IAMStub newStub(io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<IAMStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<IAMStub>() {
        @java.lang.Override
        public IAMStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new IAMStub(channel, callOptions);
        }
      };
    return IAMStub.newStub(factory, channel);
  }

  /**
   * Creates a new blocking-style stub that supports unary and streaming output calls on the service
   */
  public static IAMBlockingStub newBlockingStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<IAMBlockingStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<IAMBlockingStub>() {
        @java.lang.Override
        public IAMBlockingStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new IAMBlockingStub(channel, callOptions);
        }
      };
    return IAMBlockingStub.newStub(factory, channel);
  }

  /**
   * Creates a new ListenableFuture-style stub that supports unary calls on the service
   */
  public static IAMFutureStub newFutureStub(
      io.grpc.Channel channel) {
    io.grpc.stub.AbstractStub.StubFactory<IAMFutureStub> factory =
      new io.grpc.stub.AbstractStub.StubFactory<IAMFutureStub>() {
        @java.lang.Override
        public IAMFutureStub newStub(io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
          return new IAMFutureStub(channel, callOptions);
        }
      };
    return IAMFutureStub.newStub(factory, channel);
  }

  /**
   * <pre>
   * Creates and manages service account objects.
   * Service account is an account that belongs to your project instead
   * of to an individual end user. It is used to authenticate calls
   * to a Google API.
   * To create a service account, specify the `project_id` and `account_id`
   * for the account.  The `account_id` is unique within the project, and used
   * to generate the service account email address and a stable
   * `unique_id`.
   * All other methods can identify accounts using the format
   * `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`.
   * Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
   * the account. The `ACCOUNT` value can be the `email` address or the
   * `unique_id` of the service account.
   * </pre>
   */
  public static abstract class IAMImplBase implements io.grpc.BindableService {

    /**
     * <pre>
     * Lists [ServiceAccounts][google.iam.admin.v1.ServiceAccount] for a project.
     * </pre>
     */
    public void listServiceAccounts(com.google.iam.admin.v1.ListServiceAccountsRequest request,
        io.grpc.stub.StreamObserver<com.google.iam.admin.v1.ListServiceAccountsResponse> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getListServiceAccountsMethod(), responseObserver);
    }

    /**
     * <pre>
     * Gets a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
     * </pre>
     */
    public void getServiceAccount(com.google.iam.admin.v1.GetServiceAccountRequest request,
        io.grpc.stub.StreamObserver<com.google.iam.admin.v1.ServiceAccount> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getGetServiceAccountMethod(), responseObserver);
    }

    /**
     * <pre>
     * Creates a [ServiceAccount][google.iam.admin.v1.ServiceAccount]
     * and returns it.
     * </pre>
     */
    public void createServiceAccount(com.google.iam.admin.v1.CreateServiceAccountRequest request,
        io.grpc.stub.StreamObserver<com.google.iam.admin.v1.ServiceAccount> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getCreateServiceAccountMethod(), responseObserver);
    }

    /**
     * <pre>
     * Updates a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
     * Currently, only the following fields are updatable:
     * `display_name` and `description`.
     * </pre>
     */
    public void updateServiceAccount(com.google.iam.admin.v1.ServiceAccount request,
        io.grpc.stub.StreamObserver<com.google.iam.admin.v1.ServiceAccount> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getUpdateServiceAccountMethod(), responseObserver);
    }

    /**
     * <pre>
     * Deletes a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
     * </pre>
     */
    public void deleteServiceAccount(com.google.iam.admin.v1.DeleteServiceAccountRequest request,
        io.grpc.stub.StreamObserver<com.google.protobuf.Empty> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getDeleteServiceAccountMethod(), responseObserver);
    }

    /**
     * <pre>
     * Lists [ServiceAccountKeys][google.iam.admin.v1.ServiceAccountKey].
     * </pre>
     */
    public void listServiceAccountKeys(com.google.iam.admin.v1.ListServiceAccountKeysRequest request,
        io.grpc.stub.StreamObserver<com.google.iam.admin.v1.ListServiceAccountKeysResponse> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getListServiceAccountKeysMethod(), responseObserver);
    }

    /**
     * <pre>
     * Gets the [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey]
     * by key id.
     * </pre>
     */
    public void getServiceAccountKey(com.google.iam.admin.v1.GetServiceAccountKeyRequest request,
        io.grpc.stub.StreamObserver<com.google.iam.admin.v1.ServiceAccountKey> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getGetServiceAccountKeyMethod(), responseObserver);
    }

    /**
     * <pre>
     * Creates a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey]
     * and returns it.
     * </pre>
     */
    public void createServiceAccountKey(com.google.iam.admin.v1.CreateServiceAccountKeyRequest request,
        io.grpc.stub.StreamObserver<com.google.iam.admin.v1.ServiceAccountKey> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getCreateServiceAccountKeyMethod(), responseObserver);
    }

    /**
     * <pre>
     * Deletes a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey].
     * </pre>
     */
    public void deleteServiceAccountKey(com.google.iam.admin.v1.DeleteServiceAccountKeyRequest request,
        io.grpc.stub.StreamObserver<com.google.protobuf.Empty> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getDeleteServiceAccountKeyMethod(), responseObserver);
    }

    /**
     * <pre>
     * Signs a blob using a service account's system-managed private key.
     * </pre>
     */
    public void signBlob(com.google.iam.admin.v1.SignBlobRequest request,
        io.grpc.stub.StreamObserver<com.google.iam.admin.v1.SignBlobResponse> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getSignBlobMethod(), responseObserver);
    }

    /**
     * <pre>
     * Signs a JWT using a service account's system-managed private key.
     * If no expiry time (`exp`) is provided in the `SignJwtRequest`, IAM sets an
     * an expiry time of one hour by default. If you request an expiry time of
     * more than one hour, the request will fail.
     * </pre>
     */
    public void signJwt(com.google.iam.admin.v1.SignJwtRequest request,
        io.grpc.stub.StreamObserver<com.google.iam.admin.v1.SignJwtResponse> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getSignJwtMethod(), responseObserver);
    }

    /**
     * <pre>
     * Returns the Cloud IAM access control policy for a
     * [ServiceAccount][google.iam.admin.v1.ServiceAccount].
     * Note: Service accounts are both
     * [resources and
     * identities](/iam/docs/service-accounts#service_account_permissions). This
     * method treats the service account as a resource. It returns the Cloud IAM
     * policy that reflects what members have access to the service account.
     * This method does not return what resources the service account has access
     * to. To see if a service account has access to a resource, call the
     * `getIamPolicy` method on the target resource. For example, to view grants
     * for a project, call the
     * [projects.getIamPolicy](/resource-manager/reference/rest/v1/projects/getIamPolicy)
     * method.
     * </pre>
     */
    public void getIamPolicy(com.google.iam.v1.GetIamPolicyRequest request,
        io.grpc.stub.StreamObserver<com.google.iam.v1.Policy> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getGetIamPolicyMethod(), responseObserver);
    }

    /**
     * <pre>
     * Sets the Cloud IAM access control policy for a
     * [ServiceAccount][google.iam.admin.v1.ServiceAccount].
     * Note: Service accounts are both
     * [resources and
     * identities](/iam/docs/service-accounts#service_account_permissions). This
     * method treats the service account as a resource. Use it to grant members
     * access to the service account, such as when they need to impersonate it.
     * This method does not grant the service account access to other resources,
     * such as projects. To grant a service account access to resources, include
     * the service account in the Cloud IAM policy for the desired resource, then
     * call the appropriate `setIamPolicy` method on the target resource. For
     * example, to grant a service account access to a project, call the
     * [projects.setIamPolicy](/resource-manager/reference/rest/v1/projects/setIamPolicy)
     * method.
     * </pre>
     */
    public void setIamPolicy(com.google.iam.v1.SetIamPolicyRequest request,
        io.grpc.stub.StreamObserver<com.google.iam.v1.Policy> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getSetIamPolicyMethod(), responseObserver);
    }

    /**
     * <pre>
     * Tests the specified permissions against the IAM access control policy
     * for a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
     * </pre>
     */
    public void testIamPermissions(com.google.iam.v1.TestIamPermissionsRequest request,
        io.grpc.stub.StreamObserver<com.google.iam.v1.TestIamPermissionsResponse> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getTestIamPermissionsMethod(), responseObserver);
    }

    /**
     * <pre>
     * Queries roles that can be granted on a particular resource.
     * A role is grantable if it can be used as the role in a binding for a policy
     * for that resource.
     * </pre>
     */
    public void queryGrantableRoles(com.google.iam.admin.v1.QueryGrantableRolesRequest request,
        io.grpc.stub.StreamObserver<com.google.iam.admin.v1.QueryGrantableRolesResponse> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getQueryGrantableRolesMethod(), responseObserver);
    }

    /**
     * <pre>
     * Lists the Roles defined on a resource.
     * </pre>
     */
    public void listRoles(com.google.iam.admin.v1.ListRolesRequest request,
        io.grpc.stub.StreamObserver<com.google.iam.admin.v1.ListRolesResponse> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getListRolesMethod(), responseObserver);
    }

    /**
     * <pre>
     * Gets a Role definition.
     * </pre>
     */
    public void getRole(com.google.iam.admin.v1.GetRoleRequest request,
        io.grpc.stub.StreamObserver<com.google.iam.admin.v1.Role> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getGetRoleMethod(), responseObserver);
    }

    /**
     * <pre>
     * Creates a new Role.
     * </pre>
     */
    public void createRole(com.google.iam.admin.v1.CreateRoleRequest request,
        io.grpc.stub.StreamObserver<com.google.iam.admin.v1.Role> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getCreateRoleMethod(), responseObserver);
    }

    /**
     * <pre>
     * Updates a Role definition.
     * </pre>
     */
    public void updateRole(com.google.iam.admin.v1.UpdateRoleRequest request,
        io.grpc.stub.StreamObserver<com.google.iam.admin.v1.Role> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getUpdateRoleMethod(), responseObserver);
    }

    /**
     * <pre>
     * Soft deletes a role. The role is suspended and cannot be used to create new
     * IAM Policy Bindings.
     * The Role will not be included in `ListRoles()` unless `show_deleted` is set
     * in the `ListRolesRequest`. The Role contains the deleted boolean set.
     * Existing Bindings remains, but are inactive. The Role can be undeleted
     * within 7 days. After 7 days the Role is deleted and all Bindings associated
     * with the role are removed.
     * </pre>
     */
    public void deleteRole(com.google.iam.admin.v1.DeleteRoleRequest request,
        io.grpc.stub.StreamObserver<com.google.iam.admin.v1.Role> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getDeleteRoleMethod(), responseObserver);
    }

    /**
     * <pre>
     * Undelete a Role, bringing it back in its previous state.
     * </pre>
     */
    public void undeleteRole(com.google.iam.admin.v1.UndeleteRoleRequest request,
        io.grpc.stub.StreamObserver<com.google.iam.admin.v1.Role> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getUndeleteRoleMethod(), responseObserver);
    }

    /**
     * <pre>
     * Lists the permissions testable on a resource.
     * A permission is testable if it can be tested for an identity on a resource.
     * </pre>
     */
    public void queryTestablePermissions(com.google.iam.admin.v1.QueryTestablePermissionsRequest request,
        io.grpc.stub.StreamObserver<com.google.iam.admin.v1.QueryTestablePermissionsResponse> responseObserver) {
      io.grpc.stub.ServerCalls.asyncUnimplementedUnaryCall(getQueryTestablePermissionsMethod(), responseObserver);
    }

    @java.lang.Override public final io.grpc.ServerServiceDefinition bindService() {
      return io.grpc.ServerServiceDefinition.builder(getServiceDescriptor())
          .addMethod(
            getListServiceAccountsMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.iam.admin.v1.ListServiceAccountsRequest,
                com.google.iam.admin.v1.ListServiceAccountsResponse>(
                  this, METHODID_LIST_SERVICE_ACCOUNTS)))
          .addMethod(
            getGetServiceAccountMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.iam.admin.v1.GetServiceAccountRequest,
                com.google.iam.admin.v1.ServiceAccount>(
                  this, METHODID_GET_SERVICE_ACCOUNT)))
          .addMethod(
            getCreateServiceAccountMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.iam.admin.v1.CreateServiceAccountRequest,
                com.google.iam.admin.v1.ServiceAccount>(
                  this, METHODID_CREATE_SERVICE_ACCOUNT)))
          .addMethod(
            getUpdateServiceAccountMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.iam.admin.v1.ServiceAccount,
                com.google.iam.admin.v1.ServiceAccount>(
                  this, METHODID_UPDATE_SERVICE_ACCOUNT)))
          .addMethod(
            getDeleteServiceAccountMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.iam.admin.v1.DeleteServiceAccountRequest,
                com.google.protobuf.Empty>(
                  this, METHODID_DELETE_SERVICE_ACCOUNT)))
          .addMethod(
            getListServiceAccountKeysMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.iam.admin.v1.ListServiceAccountKeysRequest,
                com.google.iam.admin.v1.ListServiceAccountKeysResponse>(
                  this, METHODID_LIST_SERVICE_ACCOUNT_KEYS)))
          .addMethod(
            getGetServiceAccountKeyMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.iam.admin.v1.GetServiceAccountKeyRequest,
                com.google.iam.admin.v1.ServiceAccountKey>(
                  this, METHODID_GET_SERVICE_ACCOUNT_KEY)))
          .addMethod(
            getCreateServiceAccountKeyMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.iam.admin.v1.CreateServiceAccountKeyRequest,
                com.google.iam.admin.v1.ServiceAccountKey>(
                  this, METHODID_CREATE_SERVICE_ACCOUNT_KEY)))
          .addMethod(
            getDeleteServiceAccountKeyMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.iam.admin.v1.DeleteServiceAccountKeyRequest,
                com.google.protobuf.Empty>(
                  this, METHODID_DELETE_SERVICE_ACCOUNT_KEY)))
          .addMethod(
            getSignBlobMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.iam.admin.v1.SignBlobRequest,
                com.google.iam.admin.v1.SignBlobResponse>(
                  this, METHODID_SIGN_BLOB)))
          .addMethod(
            getSignJwtMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.iam.admin.v1.SignJwtRequest,
                com.google.iam.admin.v1.SignJwtResponse>(
                  this, METHODID_SIGN_JWT)))
          .addMethod(
            getGetIamPolicyMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.iam.v1.GetIamPolicyRequest,
                com.google.iam.v1.Policy>(
                  this, METHODID_GET_IAM_POLICY)))
          .addMethod(
            getSetIamPolicyMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.iam.v1.SetIamPolicyRequest,
                com.google.iam.v1.Policy>(
                  this, METHODID_SET_IAM_POLICY)))
          .addMethod(
            getTestIamPermissionsMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.iam.v1.TestIamPermissionsRequest,
                com.google.iam.v1.TestIamPermissionsResponse>(
                  this, METHODID_TEST_IAM_PERMISSIONS)))
          .addMethod(
            getQueryGrantableRolesMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.iam.admin.v1.QueryGrantableRolesRequest,
                com.google.iam.admin.v1.QueryGrantableRolesResponse>(
                  this, METHODID_QUERY_GRANTABLE_ROLES)))
          .addMethod(
            getListRolesMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.iam.admin.v1.ListRolesRequest,
                com.google.iam.admin.v1.ListRolesResponse>(
                  this, METHODID_LIST_ROLES)))
          .addMethod(
            getGetRoleMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.iam.admin.v1.GetRoleRequest,
                com.google.iam.admin.v1.Role>(
                  this, METHODID_GET_ROLE)))
          .addMethod(
            getCreateRoleMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.iam.admin.v1.CreateRoleRequest,
                com.google.iam.admin.v1.Role>(
                  this, METHODID_CREATE_ROLE)))
          .addMethod(
            getUpdateRoleMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.iam.admin.v1.UpdateRoleRequest,
                com.google.iam.admin.v1.Role>(
                  this, METHODID_UPDATE_ROLE)))
          .addMethod(
            getDeleteRoleMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.iam.admin.v1.DeleteRoleRequest,
                com.google.iam.admin.v1.Role>(
                  this, METHODID_DELETE_ROLE)))
          .addMethod(
            getUndeleteRoleMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.iam.admin.v1.UndeleteRoleRequest,
                com.google.iam.admin.v1.Role>(
                  this, METHODID_UNDELETE_ROLE)))
          .addMethod(
            getQueryTestablePermissionsMethod(),
            io.grpc.stub.ServerCalls.asyncUnaryCall(
              new MethodHandlers<
                com.google.iam.admin.v1.QueryTestablePermissionsRequest,
                com.google.iam.admin.v1.QueryTestablePermissionsResponse>(
                  this, METHODID_QUERY_TESTABLE_PERMISSIONS)))
          .build();
    }
  }

  /**
   * <pre>
   * Creates and manages service account objects.
   * Service account is an account that belongs to your project instead
   * of to an individual end user. It is used to authenticate calls
   * to a Google API.
   * To create a service account, specify the `project_id` and `account_id`
   * for the account.  The `account_id` is unique within the project, and used
   * to generate the service account email address and a stable
   * `unique_id`.
   * All other methods can identify accounts using the format
   * `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`.
   * Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
   * the account. The `ACCOUNT` value can be the `email` address or the
   * `unique_id` of the service account.
   * </pre>
   */
  public static final class IAMStub extends io.grpc.stub.AbstractAsyncStub<IAMStub> {
    private IAMStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected IAMStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new IAMStub(channel, callOptions);
    }

    /**
     * <pre>
     * Lists [ServiceAccounts][google.iam.admin.v1.ServiceAccount] for a project.
     * </pre>
     */
    public void listServiceAccounts(com.google.iam.admin.v1.ListServiceAccountsRequest request,
        io.grpc.stub.StreamObserver<com.google.iam.admin.v1.ListServiceAccountsResponse> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getListServiceAccountsMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Gets a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
     * </pre>
     */
    public void getServiceAccount(com.google.iam.admin.v1.GetServiceAccountRequest request,
        io.grpc.stub.StreamObserver<com.google.iam.admin.v1.ServiceAccount> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getGetServiceAccountMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Creates a [ServiceAccount][google.iam.admin.v1.ServiceAccount]
     * and returns it.
     * </pre>
     */
    public void createServiceAccount(com.google.iam.admin.v1.CreateServiceAccountRequest request,
        io.grpc.stub.StreamObserver<com.google.iam.admin.v1.ServiceAccount> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getCreateServiceAccountMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Updates a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
     * Currently, only the following fields are updatable:
     * `display_name` and `description`.
     * </pre>
     */
    public void updateServiceAccount(com.google.iam.admin.v1.ServiceAccount request,
        io.grpc.stub.StreamObserver<com.google.iam.admin.v1.ServiceAccount> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getUpdateServiceAccountMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Deletes a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
     * </pre>
     */
    public void deleteServiceAccount(com.google.iam.admin.v1.DeleteServiceAccountRequest request,
        io.grpc.stub.StreamObserver<com.google.protobuf.Empty> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getDeleteServiceAccountMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Lists [ServiceAccountKeys][google.iam.admin.v1.ServiceAccountKey].
     * </pre>
     */
    public void listServiceAccountKeys(com.google.iam.admin.v1.ListServiceAccountKeysRequest request,
        io.grpc.stub.StreamObserver<com.google.iam.admin.v1.ListServiceAccountKeysResponse> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getListServiceAccountKeysMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Gets the [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey]
     * by key id.
     * </pre>
     */
    public void getServiceAccountKey(com.google.iam.admin.v1.GetServiceAccountKeyRequest request,
        io.grpc.stub.StreamObserver<com.google.iam.admin.v1.ServiceAccountKey> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getGetServiceAccountKeyMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Creates a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey]
     * and returns it.
     * </pre>
     */
    public void createServiceAccountKey(com.google.iam.admin.v1.CreateServiceAccountKeyRequest request,
        io.grpc.stub.StreamObserver<com.google.iam.admin.v1.ServiceAccountKey> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getCreateServiceAccountKeyMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Deletes a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey].
     * </pre>
     */
    public void deleteServiceAccountKey(com.google.iam.admin.v1.DeleteServiceAccountKeyRequest request,
        io.grpc.stub.StreamObserver<com.google.protobuf.Empty> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getDeleteServiceAccountKeyMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Signs a blob using a service account's system-managed private key.
     * </pre>
     */
    public void signBlob(com.google.iam.admin.v1.SignBlobRequest request,
        io.grpc.stub.StreamObserver<com.google.iam.admin.v1.SignBlobResponse> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getSignBlobMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Signs a JWT using a service account's system-managed private key.
     * If no expiry time (`exp`) is provided in the `SignJwtRequest`, IAM sets an
     * an expiry time of one hour by default. If you request an expiry time of
     * more than one hour, the request will fail.
     * </pre>
     */
    public void signJwt(com.google.iam.admin.v1.SignJwtRequest request,
        io.grpc.stub.StreamObserver<com.google.iam.admin.v1.SignJwtResponse> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getSignJwtMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Returns the Cloud IAM access control policy for a
     * [ServiceAccount][google.iam.admin.v1.ServiceAccount].
     * Note: Service accounts are both
     * [resources and
     * identities](/iam/docs/service-accounts#service_account_permissions). This
     * method treats the service account as a resource. It returns the Cloud IAM
     * policy that reflects what members have access to the service account.
     * This method does not return what resources the service account has access
     * to. To see if a service account has access to a resource, call the
     * `getIamPolicy` method on the target resource. For example, to view grants
     * for a project, call the
     * [projects.getIamPolicy](/resource-manager/reference/rest/v1/projects/getIamPolicy)
     * method.
     * </pre>
     */
    public void getIamPolicy(com.google.iam.v1.GetIamPolicyRequest request,
        io.grpc.stub.StreamObserver<com.google.iam.v1.Policy> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getGetIamPolicyMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Sets the Cloud IAM access control policy for a
     * [ServiceAccount][google.iam.admin.v1.ServiceAccount].
     * Note: Service accounts are both
     * [resources and
     * identities](/iam/docs/service-accounts#service_account_permissions). This
     * method treats the service account as a resource. Use it to grant members
     * access to the service account, such as when they need to impersonate it.
     * This method does not grant the service account access to other resources,
     * such as projects. To grant a service account access to resources, include
     * the service account in the Cloud IAM policy for the desired resource, then
     * call the appropriate `setIamPolicy` method on the target resource. For
     * example, to grant a service account access to a project, call the
     * [projects.setIamPolicy](/resource-manager/reference/rest/v1/projects/setIamPolicy)
     * method.
     * </pre>
     */
    public void setIamPolicy(com.google.iam.v1.SetIamPolicyRequest request,
        io.grpc.stub.StreamObserver<com.google.iam.v1.Policy> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getSetIamPolicyMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Tests the specified permissions against the IAM access control policy
     * for a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
     * </pre>
     */
    public void testIamPermissions(com.google.iam.v1.TestIamPermissionsRequest request,
        io.grpc.stub.StreamObserver<com.google.iam.v1.TestIamPermissionsResponse> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getTestIamPermissionsMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Queries roles that can be granted on a particular resource.
     * A role is grantable if it can be used as the role in a binding for a policy
     * for that resource.
     * </pre>
     */
    public void queryGrantableRoles(com.google.iam.admin.v1.QueryGrantableRolesRequest request,
        io.grpc.stub.StreamObserver<com.google.iam.admin.v1.QueryGrantableRolesResponse> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getQueryGrantableRolesMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Lists the Roles defined on a resource.
     * </pre>
     */
    public void listRoles(com.google.iam.admin.v1.ListRolesRequest request,
        io.grpc.stub.StreamObserver<com.google.iam.admin.v1.ListRolesResponse> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getListRolesMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Gets a Role definition.
     * </pre>
     */
    public void getRole(com.google.iam.admin.v1.GetRoleRequest request,
        io.grpc.stub.StreamObserver<com.google.iam.admin.v1.Role> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getGetRoleMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Creates a new Role.
     * </pre>
     */
    public void createRole(com.google.iam.admin.v1.CreateRoleRequest request,
        io.grpc.stub.StreamObserver<com.google.iam.admin.v1.Role> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getCreateRoleMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Updates a Role definition.
     * </pre>
     */
    public void updateRole(com.google.iam.admin.v1.UpdateRoleRequest request,
        io.grpc.stub.StreamObserver<com.google.iam.admin.v1.Role> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getUpdateRoleMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Soft deletes a role. The role is suspended and cannot be used to create new
     * IAM Policy Bindings.
     * The Role will not be included in `ListRoles()` unless `show_deleted` is set
     * in the `ListRolesRequest`. The Role contains the deleted boolean set.
     * Existing Bindings remains, but are inactive. The Role can be undeleted
     * within 7 days. After 7 days the Role is deleted and all Bindings associated
     * with the role are removed.
     * </pre>
     */
    public void deleteRole(com.google.iam.admin.v1.DeleteRoleRequest request,
        io.grpc.stub.StreamObserver<com.google.iam.admin.v1.Role> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getDeleteRoleMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Undelete a Role, bringing it back in its previous state.
     * </pre>
     */
    public void undeleteRole(com.google.iam.admin.v1.UndeleteRoleRequest request,
        io.grpc.stub.StreamObserver<com.google.iam.admin.v1.Role> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getUndeleteRoleMethod(), getCallOptions()), request, responseObserver);
    }

    /**
     * <pre>
     * Lists the permissions testable on a resource.
     * A permission is testable if it can be tested for an identity on a resource.
     * </pre>
     */
    public void queryTestablePermissions(com.google.iam.admin.v1.QueryTestablePermissionsRequest request,
        io.grpc.stub.StreamObserver<com.google.iam.admin.v1.QueryTestablePermissionsResponse> responseObserver) {
      io.grpc.stub.ClientCalls.asyncUnaryCall(
          getChannel().newCall(getQueryTestablePermissionsMethod(), getCallOptions()), request, responseObserver);
    }
  }

  /**
   * <pre>
   * Creates and manages service account objects.
   * Service account is an account that belongs to your project instead
   * of to an individual end user. It is used to authenticate calls
   * to a Google API.
   * To create a service account, specify the `project_id` and `account_id`
   * for the account.  The `account_id` is unique within the project, and used
   * to generate the service account email address and a stable
   * `unique_id`.
   * All other methods can identify accounts using the format
   * `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`.
   * Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
   * the account. The `ACCOUNT` value can be the `email` address or the
   * `unique_id` of the service account.
   * </pre>
   */
  public static final class IAMBlockingStub extends io.grpc.stub.AbstractBlockingStub<IAMBlockingStub> {
    private IAMBlockingStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected IAMBlockingStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new IAMBlockingStub(channel, callOptions);
    }

    /**
     * <pre>
     * Lists [ServiceAccounts][google.iam.admin.v1.ServiceAccount] for a project.
     * </pre>
     */
    public com.google.iam.admin.v1.ListServiceAccountsResponse listServiceAccounts(com.google.iam.admin.v1.ListServiceAccountsRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getListServiceAccountsMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Gets a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
     * </pre>
     */
    public com.google.iam.admin.v1.ServiceAccount getServiceAccount(com.google.iam.admin.v1.GetServiceAccountRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getGetServiceAccountMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Creates a [ServiceAccount][google.iam.admin.v1.ServiceAccount]
     * and returns it.
     * </pre>
     */
    public com.google.iam.admin.v1.ServiceAccount createServiceAccount(com.google.iam.admin.v1.CreateServiceAccountRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getCreateServiceAccountMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Updates a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
     * Currently, only the following fields are updatable:
     * `display_name` and `description`.
     * </pre>
     */
    public com.google.iam.admin.v1.ServiceAccount updateServiceAccount(com.google.iam.admin.v1.ServiceAccount request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getUpdateServiceAccountMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Deletes a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
     * </pre>
     */
    public com.google.protobuf.Empty deleteServiceAccount(com.google.iam.admin.v1.DeleteServiceAccountRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getDeleteServiceAccountMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Lists [ServiceAccountKeys][google.iam.admin.v1.ServiceAccountKey].
     * </pre>
     */
    public com.google.iam.admin.v1.ListServiceAccountKeysResponse listServiceAccountKeys(com.google.iam.admin.v1.ListServiceAccountKeysRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getListServiceAccountKeysMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Gets the [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey]
     * by key id.
     * </pre>
     */
    public com.google.iam.admin.v1.ServiceAccountKey getServiceAccountKey(com.google.iam.admin.v1.GetServiceAccountKeyRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getGetServiceAccountKeyMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Creates a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey]
     * and returns it.
     * </pre>
     */
    public com.google.iam.admin.v1.ServiceAccountKey createServiceAccountKey(com.google.iam.admin.v1.CreateServiceAccountKeyRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getCreateServiceAccountKeyMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Deletes a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey].
     * </pre>
     */
    public com.google.protobuf.Empty deleteServiceAccountKey(com.google.iam.admin.v1.DeleteServiceAccountKeyRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getDeleteServiceAccountKeyMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Signs a blob using a service account's system-managed private key.
     * </pre>
     */
    public com.google.iam.admin.v1.SignBlobResponse signBlob(com.google.iam.admin.v1.SignBlobRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getSignBlobMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Signs a JWT using a service account's system-managed private key.
     * If no expiry time (`exp`) is provided in the `SignJwtRequest`, IAM sets an
     * an expiry time of one hour by default. If you request an expiry time of
     * more than one hour, the request will fail.
     * </pre>
     */
    public com.google.iam.admin.v1.SignJwtResponse signJwt(com.google.iam.admin.v1.SignJwtRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getSignJwtMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Returns the Cloud IAM access control policy for a
     * [ServiceAccount][google.iam.admin.v1.ServiceAccount].
     * Note: Service accounts are both
     * [resources and
     * identities](/iam/docs/service-accounts#service_account_permissions). This
     * method treats the service account as a resource. It returns the Cloud IAM
     * policy that reflects what members have access to the service account.
     * This method does not return what resources the service account has access
     * to. To see if a service account has access to a resource, call the
     * `getIamPolicy` method on the target resource. For example, to view grants
     * for a project, call the
     * [projects.getIamPolicy](/resource-manager/reference/rest/v1/projects/getIamPolicy)
     * method.
     * </pre>
     */
    public com.google.iam.v1.Policy getIamPolicy(com.google.iam.v1.GetIamPolicyRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getGetIamPolicyMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Sets the Cloud IAM access control policy for a
     * [ServiceAccount][google.iam.admin.v1.ServiceAccount].
     * Note: Service accounts are both
     * [resources and
     * identities](/iam/docs/service-accounts#service_account_permissions). This
     * method treats the service account as a resource. Use it to grant members
     * access to the service account, such as when they need to impersonate it.
     * This method does not grant the service account access to other resources,
     * such as projects. To grant a service account access to resources, include
     * the service account in the Cloud IAM policy for the desired resource, then
     * call the appropriate `setIamPolicy` method on the target resource. For
     * example, to grant a service account access to a project, call the
     * [projects.setIamPolicy](/resource-manager/reference/rest/v1/projects/setIamPolicy)
     * method.
     * </pre>
     */
    public com.google.iam.v1.Policy setIamPolicy(com.google.iam.v1.SetIamPolicyRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getSetIamPolicyMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Tests the specified permissions against the IAM access control policy
     * for a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
     * </pre>
     */
    public com.google.iam.v1.TestIamPermissionsResponse testIamPermissions(com.google.iam.v1.TestIamPermissionsRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getTestIamPermissionsMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Queries roles that can be granted on a particular resource.
     * A role is grantable if it can be used as the role in a binding for a policy
     * for that resource.
     * </pre>
     */
    public com.google.iam.admin.v1.QueryGrantableRolesResponse queryGrantableRoles(com.google.iam.admin.v1.QueryGrantableRolesRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getQueryGrantableRolesMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Lists the Roles defined on a resource.
     * </pre>
     */
    public com.google.iam.admin.v1.ListRolesResponse listRoles(com.google.iam.admin.v1.ListRolesRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getListRolesMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Gets a Role definition.
     * </pre>
     */
    public com.google.iam.admin.v1.Role getRole(com.google.iam.admin.v1.GetRoleRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getGetRoleMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Creates a new Role.
     * </pre>
     */
    public com.google.iam.admin.v1.Role createRole(com.google.iam.admin.v1.CreateRoleRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getCreateRoleMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Updates a Role definition.
     * </pre>
     */
    public com.google.iam.admin.v1.Role updateRole(com.google.iam.admin.v1.UpdateRoleRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getUpdateRoleMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Soft deletes a role. The role is suspended and cannot be used to create new
     * IAM Policy Bindings.
     * The Role will not be included in `ListRoles()` unless `show_deleted` is set
     * in the `ListRolesRequest`. The Role contains the deleted boolean set.
     * Existing Bindings remains, but are inactive. The Role can be undeleted
     * within 7 days. After 7 days the Role is deleted and all Bindings associated
     * with the role are removed.
     * </pre>
     */
    public com.google.iam.admin.v1.Role deleteRole(com.google.iam.admin.v1.DeleteRoleRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getDeleteRoleMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Undelete a Role, bringing it back in its previous state.
     * </pre>
     */
    public com.google.iam.admin.v1.Role undeleteRole(com.google.iam.admin.v1.UndeleteRoleRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getUndeleteRoleMethod(), getCallOptions(), request);
    }

    /**
     * <pre>
     * Lists the permissions testable on a resource.
     * A permission is testable if it can be tested for an identity on a resource.
     * </pre>
     */
    public com.google.iam.admin.v1.QueryTestablePermissionsResponse queryTestablePermissions(com.google.iam.admin.v1.QueryTestablePermissionsRequest request) {
      return io.grpc.stub.ClientCalls.blockingUnaryCall(
          getChannel(), getQueryTestablePermissionsMethod(), getCallOptions(), request);
    }
  }

  /**
   * <pre>
   * Creates and manages service account objects.
   * Service account is an account that belongs to your project instead
   * of to an individual end user. It is used to authenticate calls
   * to a Google API.
   * To create a service account, specify the `project_id` and `account_id`
   * for the account.  The `account_id` is unique within the project, and used
   * to generate the service account email address and a stable
   * `unique_id`.
   * All other methods can identify accounts using the format
   * `projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}`.
   * Using `-` as a wildcard for the `PROJECT_ID` will infer the project from
   * the account. The `ACCOUNT` value can be the `email` address or the
   * `unique_id` of the service account.
   * </pre>
   */
  public static final class IAMFutureStub extends io.grpc.stub.AbstractFutureStub<IAMFutureStub> {
    private IAMFutureStub(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      super(channel, callOptions);
    }

    @java.lang.Override
    protected IAMFutureStub build(
        io.grpc.Channel channel, io.grpc.CallOptions callOptions) {
      return new IAMFutureStub(channel, callOptions);
    }

    /**
     * <pre>
     * Lists [ServiceAccounts][google.iam.admin.v1.ServiceAccount] for a project.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.iam.admin.v1.ListServiceAccountsResponse> listServiceAccounts(
        com.google.iam.admin.v1.ListServiceAccountsRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getListServiceAccountsMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Gets a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.iam.admin.v1.ServiceAccount> getServiceAccount(
        com.google.iam.admin.v1.GetServiceAccountRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getGetServiceAccountMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Creates a [ServiceAccount][google.iam.admin.v1.ServiceAccount]
     * and returns it.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.iam.admin.v1.ServiceAccount> createServiceAccount(
        com.google.iam.admin.v1.CreateServiceAccountRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getCreateServiceAccountMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Updates a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
     * Currently, only the following fields are updatable:
     * `display_name` and `description`.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.iam.admin.v1.ServiceAccount> updateServiceAccount(
        com.google.iam.admin.v1.ServiceAccount request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getUpdateServiceAccountMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Deletes a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.protobuf.Empty> deleteServiceAccount(
        com.google.iam.admin.v1.DeleteServiceAccountRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getDeleteServiceAccountMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Lists [ServiceAccountKeys][google.iam.admin.v1.ServiceAccountKey].
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.iam.admin.v1.ListServiceAccountKeysResponse> listServiceAccountKeys(
        com.google.iam.admin.v1.ListServiceAccountKeysRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getListServiceAccountKeysMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Gets the [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey]
     * by key id.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.iam.admin.v1.ServiceAccountKey> getServiceAccountKey(
        com.google.iam.admin.v1.GetServiceAccountKeyRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getGetServiceAccountKeyMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Creates a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey]
     * and returns it.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.iam.admin.v1.ServiceAccountKey> createServiceAccountKey(
        com.google.iam.admin.v1.CreateServiceAccountKeyRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getCreateServiceAccountKeyMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Deletes a [ServiceAccountKey][google.iam.admin.v1.ServiceAccountKey].
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.protobuf.Empty> deleteServiceAccountKey(
        com.google.iam.admin.v1.DeleteServiceAccountKeyRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getDeleteServiceAccountKeyMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Signs a blob using a service account's system-managed private key.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.iam.admin.v1.SignBlobResponse> signBlob(
        com.google.iam.admin.v1.SignBlobRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getSignBlobMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Signs a JWT using a service account's system-managed private key.
     * If no expiry time (`exp`) is provided in the `SignJwtRequest`, IAM sets an
     * an expiry time of one hour by default. If you request an expiry time of
     * more than one hour, the request will fail.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.iam.admin.v1.SignJwtResponse> signJwt(
        com.google.iam.admin.v1.SignJwtRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getSignJwtMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Returns the Cloud IAM access control policy for a
     * [ServiceAccount][google.iam.admin.v1.ServiceAccount].
     * Note: Service accounts are both
     * [resources and
     * identities](/iam/docs/service-accounts#service_account_permissions). This
     * method treats the service account as a resource. It returns the Cloud IAM
     * policy that reflects what members have access to the service account.
     * This method does not return what resources the service account has access
     * to. To see if a service account has access to a resource, call the
     * `getIamPolicy` method on the target resource. For example, to view grants
     * for a project, call the
     * [projects.getIamPolicy](/resource-manager/reference/rest/v1/projects/getIamPolicy)
     * method.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.iam.v1.Policy> getIamPolicy(
        com.google.iam.v1.GetIamPolicyRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getGetIamPolicyMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Sets the Cloud IAM access control policy for a
     * [ServiceAccount][google.iam.admin.v1.ServiceAccount].
     * Note: Service accounts are both
     * [resources and
     * identities](/iam/docs/service-accounts#service_account_permissions). This
     * method treats the service account as a resource. Use it to grant members
     * access to the service account, such as when they need to impersonate it.
     * This method does not grant the service account access to other resources,
     * such as projects. To grant a service account access to resources, include
     * the service account in the Cloud IAM policy for the desired resource, then
     * call the appropriate `setIamPolicy` method on the target resource. For
     * example, to grant a service account access to a project, call the
     * [projects.setIamPolicy](/resource-manager/reference/rest/v1/projects/setIamPolicy)
     * method.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.iam.v1.Policy> setIamPolicy(
        com.google.iam.v1.SetIamPolicyRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getSetIamPolicyMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Tests the specified permissions against the IAM access control policy
     * for a [ServiceAccount][google.iam.admin.v1.ServiceAccount].
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.iam.v1.TestIamPermissionsResponse> testIamPermissions(
        com.google.iam.v1.TestIamPermissionsRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getTestIamPermissionsMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Queries roles that can be granted on a particular resource.
     * A role is grantable if it can be used as the role in a binding for a policy
     * for that resource.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.iam.admin.v1.QueryGrantableRolesResponse> queryGrantableRoles(
        com.google.iam.admin.v1.QueryGrantableRolesRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getQueryGrantableRolesMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Lists the Roles defined on a resource.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.iam.admin.v1.ListRolesResponse> listRoles(
        com.google.iam.admin.v1.ListRolesRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getListRolesMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Gets a Role definition.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.iam.admin.v1.Role> getRole(
        com.google.iam.admin.v1.GetRoleRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getGetRoleMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Creates a new Role.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.iam.admin.v1.Role> createRole(
        com.google.iam.admin.v1.CreateRoleRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getCreateRoleMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Updates a Role definition.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.iam.admin.v1.Role> updateRole(
        com.google.iam.admin.v1.UpdateRoleRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getUpdateRoleMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Soft deletes a role. The role is suspended and cannot be used to create new
     * IAM Policy Bindings.
     * The Role will not be included in `ListRoles()` unless `show_deleted` is set
     * in the `ListRolesRequest`. The Role contains the deleted boolean set.
     * Existing Bindings remains, but are inactive. The Role can be undeleted
     * within 7 days. After 7 days the Role is deleted and all Bindings associated
     * with the role are removed.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.iam.admin.v1.Role> deleteRole(
        com.google.iam.admin.v1.DeleteRoleRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getDeleteRoleMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Undelete a Role, bringing it back in its previous state.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.iam.admin.v1.Role> undeleteRole(
        com.google.iam.admin.v1.UndeleteRoleRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getUndeleteRoleMethod(), getCallOptions()), request);
    }

    /**
     * <pre>
     * Lists the permissions testable on a resource.
     * A permission is testable if it can be tested for an identity on a resource.
     * </pre>
     */
    public com.google.common.util.concurrent.ListenableFuture<com.google.iam.admin.v1.QueryTestablePermissionsResponse> queryTestablePermissions(
        com.google.iam.admin.v1.QueryTestablePermissionsRequest request) {
      return io.grpc.stub.ClientCalls.futureUnaryCall(
          getChannel().newCall(getQueryTestablePermissionsMethod(), getCallOptions()), request);
    }
  }

  private static final int METHODID_LIST_SERVICE_ACCOUNTS = 0;
  private static final int METHODID_GET_SERVICE_ACCOUNT = 1;
  private static final int METHODID_CREATE_SERVICE_ACCOUNT = 2;
  private static final int METHODID_UPDATE_SERVICE_ACCOUNT = 3;
  private static final int METHODID_DELETE_SERVICE_ACCOUNT = 4;
  private static final int METHODID_LIST_SERVICE_ACCOUNT_KEYS = 5;
  private static final int METHODID_GET_SERVICE_ACCOUNT_KEY = 6;
  private static final int METHODID_CREATE_SERVICE_ACCOUNT_KEY = 7;
  private static final int METHODID_DELETE_SERVICE_ACCOUNT_KEY = 8;
  private static final int METHODID_SIGN_BLOB = 9;
  private static final int METHODID_SIGN_JWT = 10;
  private static final int METHODID_GET_IAM_POLICY = 11;
  private static final int METHODID_SET_IAM_POLICY = 12;
  private static final int METHODID_TEST_IAM_PERMISSIONS = 13;
  private static final int METHODID_QUERY_GRANTABLE_ROLES = 14;
  private static final int METHODID_LIST_ROLES = 15;
  private static final int METHODID_GET_ROLE = 16;
  private static final int METHODID_CREATE_ROLE = 17;
  private static final int METHODID_UPDATE_ROLE = 18;
  private static final int METHODID_DELETE_ROLE = 19;
  private static final int METHODID_UNDELETE_ROLE = 20;
  private static final int METHODID_QUERY_TESTABLE_PERMISSIONS = 21;

  private static final class MethodHandlers<Req, Resp> implements
      io.grpc.stub.ServerCalls.UnaryMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ServerStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.ClientStreamingMethod<Req, Resp>,
      io.grpc.stub.ServerCalls.BidiStreamingMethod<Req, Resp> {
    private final IAMImplBase serviceImpl;
    private final int methodId;

    MethodHandlers(IAMImplBase serviceImpl, int methodId) {
      this.serviceImpl = serviceImpl;
      this.methodId = methodId;
    }

    @java.lang.Override
    @java.lang.SuppressWarnings("unchecked")
    public void invoke(Req request, io.grpc.stub.StreamObserver<Resp> responseObserver) {
      switch (methodId) {
        case METHODID_LIST_SERVICE_ACCOUNTS:
          serviceImpl.listServiceAccounts((com.google.iam.admin.v1.ListServiceAccountsRequest) request,
              (io.grpc.stub.StreamObserver<com.google.iam.admin.v1.ListServiceAccountsResponse>) responseObserver);
          break;
        case METHODID_GET_SERVICE_ACCOUNT:
          serviceImpl.getServiceAccount((com.google.iam.admin.v1.GetServiceAccountRequest) request,
              (io.grpc.stub.StreamObserver<com.google.iam.admin.v1.ServiceAccount>) responseObserver);
          break;
        case METHODID_CREATE_SERVICE_ACCOUNT:
          serviceImpl.createServiceAccount((com.google.iam.admin.v1.CreateServiceAccountRequest) request,
              (io.grpc.stub.StreamObserver<com.google.iam.admin.v1.ServiceAccount>) responseObserver);
          break;
        case METHODID_UPDATE_SERVICE_ACCOUNT:
          serviceImpl.updateServiceAccount((com.google.iam.admin.v1.ServiceAccount) request,
              (io.grpc.stub.StreamObserver<com.google.iam.admin.v1.ServiceAccount>) responseObserver);
          break;
        case METHODID_DELETE_SERVICE_ACCOUNT:
          serviceImpl.deleteServiceAccount((com.google.iam.admin.v1.DeleteServiceAccountRequest) request,
              (io.grpc.stub.StreamObserver<com.google.protobuf.Empty>) responseObserver);
          break;
        case METHODID_LIST_SERVICE_ACCOUNT_KEYS:
          serviceImpl.listServiceAccountKeys((com.google.iam.admin.v1.ListServiceAccountKeysRequest) request,
              (io.grpc.stub.StreamObserver<com.google.iam.admin.v1.ListServiceAccountKeysResponse>) responseObserver);
          break;
        case METHODID_GET_SERVICE_ACCOUNT_KEY:
          serviceImpl.getServiceAccountKey((com.google.iam.admin.v1.GetServiceAccountKeyRequest) request,
              (io.grpc.stub.StreamObserver<com.google.iam.admin.v1.ServiceAccountKey>) responseObserver);
          break;
        case METHODID_CREATE_SERVICE_ACCOUNT_KEY:
          serviceImpl.createServiceAccountKey((com.google.iam.admin.v1.CreateServiceAccountKeyRequest) request,
              (io.grpc.stub.StreamObserver<com.google.iam.admin.v1.ServiceAccountKey>) responseObserver);
          break;
        case METHODID_DELETE_SERVICE_ACCOUNT_KEY:
          serviceImpl.deleteServiceAccountKey((com.google.iam.admin.v1.DeleteServiceAccountKeyRequest) request,
              (io.grpc.stub.StreamObserver<com.google.protobuf.Empty>) responseObserver);
          break;
        case METHODID_SIGN_BLOB:
          serviceImpl.signBlob((com.google.iam.admin.v1.SignBlobRequest) request,
              (io.grpc.stub.StreamObserver<com.google.iam.admin.v1.SignBlobResponse>) responseObserver);
          break;
        case METHODID_SIGN_JWT:
          serviceImpl.signJwt((com.google.iam.admin.v1.SignJwtRequest) request,
              (io.grpc.stub.StreamObserver<com.google.iam.admin.v1.SignJwtResponse>) responseObserver);
          break;
        case METHODID_GET_IAM_POLICY:
          serviceImpl.getIamPolicy((com.google.iam.v1.GetIamPolicyRequest) request,
              (io.grpc.stub.StreamObserver<com.google.iam.v1.Policy>) responseObserver);
          break;
        case METHODID_SET_IAM_POLICY:
          serviceImpl.setIamPolicy((com.google.iam.v1.SetIamPolicyRequest) request,
              (io.grpc.stub.StreamObserver<com.google.iam.v1.Policy>) responseObserver);
          break;
        case METHODID_TEST_IAM_PERMISSIONS:
          serviceImpl.testIamPermissions((com.google.iam.v1.TestIamPermissionsRequest) request,
              (io.grpc.stub.StreamObserver<com.google.iam.v1.TestIamPermissionsResponse>) responseObserver);
          break;
        case METHODID_QUERY_GRANTABLE_ROLES:
          serviceImpl.queryGrantableRoles((com.google.iam.admin.v1.QueryGrantableRolesRequest) request,
              (io.grpc.stub.StreamObserver<com.google.iam.admin.v1.QueryGrantableRolesResponse>) responseObserver);
          break;
        case METHODID_LIST_ROLES:
          serviceImpl.listRoles((com.google.iam.admin.v1.ListRolesRequest) request,
              (io.grpc.stub.StreamObserver<com.google.iam.admin.v1.ListRolesResponse>) responseObserver);
          break;
        case METHODID_GET_ROLE:
          serviceImpl.getRole((com.google.iam.admin.v1.GetRoleRequest) request,
              (io.grpc.stub.StreamObserver<com.google.iam.admin.v1.Role>) responseObserver);
          break;
        case METHODID_CREATE_ROLE:
          serviceImpl.createRole((com.google.iam.admin.v1.CreateRoleRequest) request,
              (io.grpc.stub.StreamObserver<com.google.iam.admin.v1.Role>) responseObserver);
          break;
        case METHODID_UPDATE_ROLE:
          serviceImpl.updateRole((com.google.iam.admin.v1.UpdateRoleRequest) request,
              (io.grpc.stub.StreamObserver<com.google.iam.admin.v1.Role>) responseObserver);
          break;
        case METHODID_DELETE_ROLE:
          serviceImpl.deleteRole((com.google.iam.admin.v1.DeleteRoleRequest) request,
              (io.grpc.stub.StreamObserver<com.google.iam.admin.v1.Role>) responseObserver);
          break;
        case METHODID_UNDELETE_ROLE:
          serviceImpl.undeleteRole((com.google.iam.admin.v1.UndeleteRoleRequest) request,
              (io.grpc.stub.StreamObserver<com.google.iam.admin.v1.Role>) responseObserver);
          break;
        case METHODID_QUERY_TESTABLE_PERMISSIONS:
          serviceImpl.queryTestablePermissions((com.google.iam.admin.v1.QueryTestablePermissionsRequest) request,
              (io.grpc.stub.StreamObserver<com.google.iam.admin.v1.QueryTestablePermissionsResponse>) responseObserver);
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

  private static abstract class IAMBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoFileDescriptorSupplier, io.grpc.protobuf.ProtoServiceDescriptorSupplier {
    IAMBaseDescriptorSupplier() {}

    @java.lang.Override
    public com.google.protobuf.Descriptors.FileDescriptor getFileDescriptor() {
      return com.google.iam.admin.v1.IamProto.getDescriptor();
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.ServiceDescriptor getServiceDescriptor() {
      return getFileDescriptor().findServiceByName("IAM");
    }
  }

  private static final class IAMFileDescriptorSupplier
      extends IAMBaseDescriptorSupplier {
    IAMFileDescriptorSupplier() {}
  }

  private static final class IAMMethodDescriptorSupplier
      extends IAMBaseDescriptorSupplier
      implements io.grpc.protobuf.ProtoMethodDescriptorSupplier {
    private final String methodName;

    IAMMethodDescriptorSupplier(String methodName) {
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
      synchronized (IAMGrpc.class) {
        result = serviceDescriptor;
        if (result == null) {
          serviceDescriptor = result = io.grpc.ServiceDescriptor.newBuilder(SERVICE_NAME)
              .setSchemaDescriptor(new IAMFileDescriptorSupplier())
              .addMethod(getListServiceAccountsMethod())
              .addMethod(getGetServiceAccountMethod())
              .addMethod(getCreateServiceAccountMethod())
              .addMethod(getUpdateServiceAccountMethod())
              .addMethod(getDeleteServiceAccountMethod())
              .addMethod(getListServiceAccountKeysMethod())
              .addMethod(getGetServiceAccountKeyMethod())
              .addMethod(getCreateServiceAccountKeyMethod())
              .addMethod(getDeleteServiceAccountKeyMethod())
              .addMethod(getSignBlobMethod())
              .addMethod(getSignJwtMethod())
              .addMethod(getGetIamPolicyMethod())
              .addMethod(getSetIamPolicyMethod())
              .addMethod(getTestIamPermissionsMethod())
              .addMethod(getQueryGrantableRolesMethod())
              .addMethod(getListRolesMethod())
              .addMethod(getGetRoleMethod())
              .addMethod(getCreateRoleMethod())
              .addMethod(getUpdateRoleMethod())
              .addMethod(getDeleteRoleMethod())
              .addMethod(getUndeleteRoleMethod())
              .addMethod(getQueryTestablePermissionsMethod())
              .build();
        }
      }
    }
    return result;
  }
}
