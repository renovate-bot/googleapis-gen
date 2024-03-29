// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/pubsublite/v1/subscriber.proto
// </auto-generated>
// Original file comments:
// Copyright 2021 Google LLC
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

namespace Google.Cloud.PubSubLite.V1 {
  /// <summary>
  /// The service that a subscriber client application uses to receive messages
  /// from subscriptions.
  /// </summary>
  public static partial class SubscriberService
  {
    static readonly string __ServiceName = "google.cloud.pubsublite.v1.SubscriberService";

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
    static readonly grpc::Marshaller<global::Google.Cloud.PubSubLite.V1.SubscribeRequest> __Marshaller_google_cloud_pubsublite_v1_SubscribeRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.PubSubLite.V1.SubscribeRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.PubSubLite.V1.SubscribeResponse> __Marshaller_google_cloud_pubsublite_v1_SubscribeResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.PubSubLite.V1.SubscribeResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.PubSubLite.V1.SubscribeRequest, global::Google.Cloud.PubSubLite.V1.SubscribeResponse> __Method_Subscribe = new grpc::Method<global::Google.Cloud.PubSubLite.V1.SubscribeRequest, global::Google.Cloud.PubSubLite.V1.SubscribeResponse>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "Subscribe",
        __Marshaller_google_cloud_pubsublite_v1_SubscribeRequest,
        __Marshaller_google_cloud_pubsublite_v1_SubscribeResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.PubSubLite.V1.SubscriberReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of SubscriberService</summary>
    [grpc::BindServiceMethod(typeof(SubscriberService), "BindService")]
    public abstract partial class SubscriberServiceBase
    {
      /// <summary>
      /// Establishes a stream with the server for receiving messages.
      /// </summary>
      /// <param name="requestStream">Used for reading requests from the client.</param>
      /// <param name="responseStream">Used for sending responses back to the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>A task indicating completion of the handler.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task Subscribe(grpc::IAsyncStreamReader<global::Google.Cloud.PubSubLite.V1.SubscribeRequest> requestStream, grpc::IServerStreamWriter<global::Google.Cloud.PubSubLite.V1.SubscribeResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for SubscriberService</summary>
    public partial class SubscriberServiceClient : grpc::ClientBase<SubscriberServiceClient>
    {
      /// <summary>Creates a new client for SubscriberService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public SubscriberServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for SubscriberService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public SubscriberServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected SubscriberServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected SubscriberServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Establishes a stream with the server for receiving messages.
      /// </summary>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncDuplexStreamingCall<global::Google.Cloud.PubSubLite.V1.SubscribeRequest, global::Google.Cloud.PubSubLite.V1.SubscribeResponse> Subscribe(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Subscribe(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Establishes a stream with the server for receiving messages.
      /// </summary>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncDuplexStreamingCall<global::Google.Cloud.PubSubLite.V1.SubscribeRequest, global::Google.Cloud.PubSubLite.V1.SubscribeResponse> Subscribe(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_Subscribe, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override SubscriberServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new SubscriberServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(SubscriberServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Subscribe, serviceImpl.Subscribe).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, SubscriberServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Subscribe, serviceImpl == null ? null : new grpc::DuplexStreamingServerMethod<global::Google.Cloud.PubSubLite.V1.SubscribeRequest, global::Google.Cloud.PubSubLite.V1.SubscribeResponse>(serviceImpl.Subscribe));
    }

  }
  /// <summary>
  /// The service that a subscriber client application uses to determine which
  /// partitions it should connect to.
  /// </summary>
  public static partial class PartitionAssignmentService
  {
    static readonly string __ServiceName = "google.cloud.pubsublite.v1.PartitionAssignmentService";

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
    static readonly grpc::Marshaller<global::Google.Cloud.PubSubLite.V1.PartitionAssignmentRequest> __Marshaller_google_cloud_pubsublite_v1_PartitionAssignmentRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.PubSubLite.V1.PartitionAssignmentRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Cloud.PubSubLite.V1.PartitionAssignment> __Marshaller_google_cloud_pubsublite_v1_PartitionAssignment = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.PubSubLite.V1.PartitionAssignment.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Cloud.PubSubLite.V1.PartitionAssignmentRequest, global::Google.Cloud.PubSubLite.V1.PartitionAssignment> __Method_AssignPartitions = new grpc::Method<global::Google.Cloud.PubSubLite.V1.PartitionAssignmentRequest, global::Google.Cloud.PubSubLite.V1.PartitionAssignment>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "AssignPartitions",
        __Marshaller_google_cloud_pubsublite_v1_PartitionAssignmentRequest,
        __Marshaller_google_cloud_pubsublite_v1_PartitionAssignment);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.PubSubLite.V1.SubscriberReflection.Descriptor.Services[1]; }
    }

    /// <summary>Base class for server-side implementations of PartitionAssignmentService</summary>
    [grpc::BindServiceMethod(typeof(PartitionAssignmentService), "BindService")]
    public abstract partial class PartitionAssignmentServiceBase
    {
      /// <summary>
      /// Assign partitions for this client to handle for the specified subscription.
      ///
      /// The client must send an InitialPartitionAssignmentRequest first.
      /// The server will then send at most one unacknowledged PartitionAssignment
      /// outstanding on the stream at a time.
      /// The client should send a PartitionAssignmentAck after updating the
      /// partitions it is connected to to reflect the new assignment.
      /// </summary>
      /// <param name="requestStream">Used for reading requests from the client.</param>
      /// <param name="responseStream">Used for sending responses back to the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>A task indicating completion of the handler.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task AssignPartitions(grpc::IAsyncStreamReader<global::Google.Cloud.PubSubLite.V1.PartitionAssignmentRequest> requestStream, grpc::IServerStreamWriter<global::Google.Cloud.PubSubLite.V1.PartitionAssignment> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for PartitionAssignmentService</summary>
    public partial class PartitionAssignmentServiceClient : grpc::ClientBase<PartitionAssignmentServiceClient>
    {
      /// <summary>Creates a new client for PartitionAssignmentService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public PartitionAssignmentServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for PartitionAssignmentService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public PartitionAssignmentServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected PartitionAssignmentServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected PartitionAssignmentServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Assign partitions for this client to handle for the specified subscription.
      ///
      /// The client must send an InitialPartitionAssignmentRequest first.
      /// The server will then send at most one unacknowledged PartitionAssignment
      /// outstanding on the stream at a time.
      /// The client should send a PartitionAssignmentAck after updating the
      /// partitions it is connected to to reflect the new assignment.
      /// </summary>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncDuplexStreamingCall<global::Google.Cloud.PubSubLite.V1.PartitionAssignmentRequest, global::Google.Cloud.PubSubLite.V1.PartitionAssignment> AssignPartitions(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AssignPartitions(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Assign partitions for this client to handle for the specified subscription.
      ///
      /// The client must send an InitialPartitionAssignmentRequest first.
      /// The server will then send at most one unacknowledged PartitionAssignment
      /// outstanding on the stream at a time.
      /// The client should send a PartitionAssignmentAck after updating the
      /// partitions it is connected to to reflect the new assignment.
      /// </summary>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncDuplexStreamingCall<global::Google.Cloud.PubSubLite.V1.PartitionAssignmentRequest, global::Google.Cloud.PubSubLite.V1.PartitionAssignment> AssignPartitions(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_AssignPartitions, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override PartitionAssignmentServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new PartitionAssignmentServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(PartitionAssignmentServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_AssignPartitions, serviceImpl.AssignPartitions).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, PartitionAssignmentServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_AssignPartitions, serviceImpl == null ? null : new grpc::DuplexStreamingServerMethod<global::Google.Cloud.PubSubLite.V1.PartitionAssignmentRequest, global::Google.Cloud.PubSubLite.V1.PartitionAssignment>(serviceImpl.AssignPartitions));
    }

  }
}
#endregion
