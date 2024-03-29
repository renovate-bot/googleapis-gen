// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/asset/v1p4beta1/asset_service.proto
// </auto-generated>
// Original file comments:
// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Cloud.Asset.V1P4Beta1 {
  /// <summary>
  /// Asset service definition.
  /// </summary>
  public static partial class AssetService
  {
    static readonly string __ServiceName = "google.cloud.asset.v1p4beta1.AssetService";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Asset.V1P4Beta1.AnalyzeIamPolicyRequest> __Marshaller_google_cloud_asset_v1p4beta1_AnalyzeIamPolicyRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Asset.V1P4Beta1.AnalyzeIamPolicyRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Asset.V1P4Beta1.AnalyzeIamPolicyResponse> __Marshaller_google_cloud_asset_v1p4beta1_AnalyzeIamPolicyResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Asset.V1P4Beta1.AnalyzeIamPolicyResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.Asset.V1P4Beta1.ExportIamPolicyAnalysisRequest> __Marshaller_google_cloud_asset_v1p4beta1_ExportIamPolicyAnalysisRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Asset.V1P4Beta1.ExportIamPolicyAnalysisRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.LongRunning.Operation> __Marshaller_google_longrunning_Operation = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.LongRunning.Operation.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.Asset.V1P4Beta1.AnalyzeIamPolicyRequest, global::Google.Cloud.Asset.V1P4Beta1.AnalyzeIamPolicyResponse> __Method_AnalyzeIamPolicy = new grpc::Method<global::Google.Cloud.Asset.V1P4Beta1.AnalyzeIamPolicyRequest, global::Google.Cloud.Asset.V1P4Beta1.AnalyzeIamPolicyResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AnalyzeIamPolicy",
        __Marshaller_google_cloud_asset_v1p4beta1_AnalyzeIamPolicyRequest,
        __Marshaller_google_cloud_asset_v1p4beta1_AnalyzeIamPolicyResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.Asset.V1P4Beta1.ExportIamPolicyAnalysisRequest, global::Google.LongRunning.Operation> __Method_ExportIamPolicyAnalysis = new grpc::Method<global::Google.Cloud.Asset.V1P4Beta1.ExportIamPolicyAnalysisRequest, global::Google.LongRunning.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ExportIamPolicyAnalysis",
        __Marshaller_google_cloud_asset_v1p4beta1_ExportIamPolicyAnalysisRequest,
        __Marshaller_google_longrunning_Operation);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.Asset.V1P4Beta1.AssetServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of AssetService</summary>
    [grpc::BindServiceMethod(typeof(AssetService), "BindService")]
    public abstract partial class AssetServiceBase
    {
      /// <summary>
      /// Analyzes IAM policies based on the specified request. Returns
      /// a list of [IamPolicyAnalysisResult][google.cloud.asset.v1p4beta1.IamPolicyAnalysisResult] matching the request.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Asset.V1P4Beta1.AnalyzeIamPolicyResponse> AnalyzeIamPolicy(global::Google.Cloud.Asset.V1P4Beta1.AnalyzeIamPolicyRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Exports IAM policy analysis based on the specified request. This API
      /// implements the [google.longrunning.Operation][google.longrunning.Operation] API allowing you to keep
      /// track of the export. The metadata contains the request to help callers to
      /// map responses to requests.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.LongRunning.Operation> ExportIamPolicyAnalysis(global::Google.Cloud.Asset.V1P4Beta1.ExportIamPolicyAnalysisRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for AssetService</summary>
    public partial class AssetServiceClient : grpc::ClientBase<AssetServiceClient>
    {
      /// <summary>Creates a new client for AssetService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public AssetServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for AssetService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public AssetServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected AssetServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected AssetServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Analyzes IAM policies based on the specified request. Returns
      /// a list of [IamPolicyAnalysisResult][google.cloud.asset.v1p4beta1.IamPolicyAnalysisResult] matching the request.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Asset.V1P4Beta1.AnalyzeIamPolicyResponse AnalyzeIamPolicy(global::Google.Cloud.Asset.V1P4Beta1.AnalyzeIamPolicyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AnalyzeIamPolicy(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Analyzes IAM policies based on the specified request. Returns
      /// a list of [IamPolicyAnalysisResult][google.cloud.asset.v1p4beta1.IamPolicyAnalysisResult] matching the request.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Cloud.Asset.V1P4Beta1.AnalyzeIamPolicyResponse AnalyzeIamPolicy(global::Google.Cloud.Asset.V1P4Beta1.AnalyzeIamPolicyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AnalyzeIamPolicy, null, options, request);
      }
      /// <summary>
      /// Analyzes IAM policies based on the specified request. Returns
      /// a list of [IamPolicyAnalysisResult][google.cloud.asset.v1p4beta1.IamPolicyAnalysisResult] matching the request.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Asset.V1P4Beta1.AnalyzeIamPolicyResponse> AnalyzeIamPolicyAsync(global::Google.Cloud.Asset.V1P4Beta1.AnalyzeIamPolicyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AnalyzeIamPolicyAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Analyzes IAM policies based on the specified request. Returns
      /// a list of [IamPolicyAnalysisResult][google.cloud.asset.v1p4beta1.IamPolicyAnalysisResult] matching the request.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Asset.V1P4Beta1.AnalyzeIamPolicyResponse> AnalyzeIamPolicyAsync(global::Google.Cloud.Asset.V1P4Beta1.AnalyzeIamPolicyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AnalyzeIamPolicy, null, options, request);
      }
      /// <summary>
      /// Exports IAM policy analysis based on the specified request. This API
      /// implements the [google.longrunning.Operation][google.longrunning.Operation] API allowing you to keep
      /// track of the export. The metadata contains the request to help callers to
      /// map responses to requests.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.LongRunning.Operation ExportIamPolicyAnalysis(global::Google.Cloud.Asset.V1P4Beta1.ExportIamPolicyAnalysisRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ExportIamPolicyAnalysis(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Exports IAM policy analysis based on the specified request. This API
      /// implements the [google.longrunning.Operation][google.longrunning.Operation] API allowing you to keep
      /// track of the export. The metadata contains the request to help callers to
      /// map responses to requests.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.LongRunning.Operation ExportIamPolicyAnalysis(global::Google.Cloud.Asset.V1P4Beta1.ExportIamPolicyAnalysisRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ExportIamPolicyAnalysis, null, options, request);
      }
      /// <summary>
      /// Exports IAM policy analysis based on the specified request. This API
      /// implements the [google.longrunning.Operation][google.longrunning.Operation] API allowing you to keep
      /// track of the export. The metadata contains the request to help callers to
      /// map responses to requests.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> ExportIamPolicyAnalysisAsync(global::Google.Cloud.Asset.V1P4Beta1.ExportIamPolicyAnalysisRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ExportIamPolicyAnalysisAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Exports IAM policy analysis based on the specified request. This API
      /// implements the [google.longrunning.Operation][google.longrunning.Operation] API allowing you to keep
      /// track of the export. The metadata contains the request to help callers to
      /// map responses to requests.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> ExportIamPolicyAnalysisAsync(global::Google.Cloud.Asset.V1P4Beta1.ExportIamPolicyAnalysisRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ExportIamPolicyAnalysis, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override AssetServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new AssetServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(AssetServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_AnalyzeIamPolicy, serviceImpl.AnalyzeIamPolicy)
          .AddMethod(__Method_ExportIamPolicyAnalysis, serviceImpl.ExportIamPolicyAnalysis).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, AssetServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_AnalyzeIamPolicy, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Asset.V1P4Beta1.AnalyzeIamPolicyRequest, global::Google.Cloud.Asset.V1P4Beta1.AnalyzeIamPolicyResponse>(serviceImpl.AnalyzeIamPolicy));
      serviceBinder.AddMethod(__Method_ExportIamPolicyAnalysis, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Asset.V1P4Beta1.ExportIamPolicyAnalysisRequest, global::Google.LongRunning.Operation>(serviceImpl.ExportIamPolicyAnalysis));
    }

  }
}
#endregion
