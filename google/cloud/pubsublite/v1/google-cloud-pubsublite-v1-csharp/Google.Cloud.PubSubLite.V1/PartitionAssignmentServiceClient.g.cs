// Copyright 2021 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gaxgrpccore = Google.Api.Gax.Grpc.GrpcCore;
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.PubSubLite.V1
{
    /// <summary>Settings for <see cref="PartitionAssignmentServiceClient"/> instances.</summary>
    public sealed partial class PartitionAssignmentServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="PartitionAssignmentServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="PartitionAssignmentServiceSettings"/>.</returns>
        public static PartitionAssignmentServiceSettings GetDefault() => new PartitionAssignmentServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="PartitionAssignmentServiceSettings"/> object with default settings.
        /// </summary>
        public PartitionAssignmentServiceSettings()
        {
        }

        private PartitionAssignmentServiceSettings(PartitionAssignmentServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            AssignPartitionsSettings = existing.AssignPartitionsSettings;
            AssignPartitionsStreamingSettings = existing.AssignPartitionsStreamingSettings;
            OnCopy(existing);
        }

        partial void OnCopy(PartitionAssignmentServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PartitionAssignmentServiceClient.AssignPartitions</c> and
        /// <c>PartitionAssignmentServiceClient.AssignPartitionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AssignPartitionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::BidirectionalStreamingSettings"/> for calls to
        /// <c>PartitionAssignmentServiceClient.AssignPartitions</c> and
        /// <c>PartitionAssignmentServiceClient.AssignPartitionsAsync</c>.
        /// </summary>
        /// <remarks>The default local send queue size is 100.</remarks>
        public gaxgrpc::BidirectionalStreamingSettings AssignPartitionsStreamingSettings { get; set; } = new gaxgrpc::BidirectionalStreamingSettings(100);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="PartitionAssignmentServiceSettings"/> object.</returns>
        public PartitionAssignmentServiceSettings Clone() => new PartitionAssignmentServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="PartitionAssignmentServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class PartitionAssignmentServiceClientBuilder : gaxgrpc::ClientBuilderBase<PartitionAssignmentServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public PartitionAssignmentServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public PartitionAssignmentServiceClientBuilder()
        {
            UseJwtAccessWithScopes = PartitionAssignmentServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref PartitionAssignmentServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<PartitionAssignmentServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override PartitionAssignmentServiceClient Build()
        {
            PartitionAssignmentServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<PartitionAssignmentServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<PartitionAssignmentServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private PartitionAssignmentServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return PartitionAssignmentServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<PartitionAssignmentServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return PartitionAssignmentServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => PartitionAssignmentServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => PartitionAssignmentServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => PartitionAssignmentServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>PartitionAssignmentService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The service that a subscriber client application uses to determine which
    /// partitions it should connect to.
    /// </remarks>
    public abstract partial class PartitionAssignmentServiceClient
    {
        /// <summary>
        /// The default endpoint for the PartitionAssignmentService service, which is a host of
        /// "pubsublite.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "pubsublite.googleapis.com:443";

        /// <summary>The default PartitionAssignmentService scopes.</summary>
        /// <remarks>
        /// The default PartitionAssignmentService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes, UseJwtAccessWithScopes);

        internal static bool UseJwtAccessWithScopes
        {
            get
            {
                bool useJwtAccessWithScopes = true;
                MaybeUseJwtAccessWithScopes(ref useJwtAccessWithScopes);
                return useJwtAccessWithScopes;
            }
        }

        static partial void MaybeUseJwtAccessWithScopes(ref bool useJwtAccessWithScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="PartitionAssignmentServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="PartitionAssignmentServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="PartitionAssignmentServiceClient"/>.</returns>
        public static stt::Task<PartitionAssignmentServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new PartitionAssignmentServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="PartitionAssignmentServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="PartitionAssignmentServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="PartitionAssignmentServiceClient"/>.</returns>
        public static PartitionAssignmentServiceClient Create() => new PartitionAssignmentServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="PartitionAssignmentServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="PartitionAssignmentServiceSettings"/>.</param>
        /// <returns>The created <see cref="PartitionAssignmentServiceClient"/>.</returns>
        internal static PartitionAssignmentServiceClient Create(grpccore::CallInvoker callInvoker, PartitionAssignmentServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            PartitionAssignmentService.PartitionAssignmentServiceClient grpcClient = new PartitionAssignmentService.PartitionAssignmentServiceClient(callInvoker);
            return new PartitionAssignmentServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/>. Channels which weren't automatically created are not
        /// affected.
        /// </summary>
        /// <remarks>
        /// After calling this method, further calls to <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/> will create new channels, which could in turn be shut down
        /// by another call to this method.
        /// </remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => ChannelPool.ShutdownChannelsAsync();

        /// <summary>The underlying gRPC PartitionAssignmentService client</summary>
        public virtual PartitionAssignmentService.PartitionAssignmentServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Bidirectional streaming methods for
        /// <see cref="AssignPartitions(gaxgrpc::CallSettings,gaxgrpc::BidirectionalStreamingSettings)"/>.
        /// </summary>
        public abstract partial class AssignPartitionsStream : gaxgrpc::BidirectionalStreamingBase<PartitionAssignmentRequest, PartitionAssignment>
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
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public virtual AssignPartitionsStream AssignPartitions(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null) =>
            throw new sys::NotImplementedException();
    }

    /// <summary>PartitionAssignmentService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The service that a subscriber client application uses to determine which
    /// partitions it should connect to.
    /// </remarks>
    public sealed partial class PartitionAssignmentServiceClientImpl : PartitionAssignmentServiceClient
    {
        private readonly gaxgrpc::ApiBidirectionalStreamingCall<PartitionAssignmentRequest, PartitionAssignment> _callAssignPartitions;

        /// <summary>
        /// Constructs a client wrapper for the PartitionAssignmentService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="PartitionAssignmentServiceSettings"/> used within this client.
        /// </param>
        public PartitionAssignmentServiceClientImpl(PartitionAssignmentService.PartitionAssignmentServiceClient grpcClient, PartitionAssignmentServiceSettings settings)
        {
            GrpcClient = grpcClient;
            PartitionAssignmentServiceSettings effectiveSettings = settings ?? PartitionAssignmentServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callAssignPartitions = clientHelper.BuildApiCall<PartitionAssignmentRequest, PartitionAssignment>(grpcClient.AssignPartitions, effectiveSettings.AssignPartitionsSettings, effectiveSettings.AssignPartitionsStreamingSettings);
            Modify_ApiCall(ref _callAssignPartitions);
            Modify_AssignPartitionsApiCall(ref _callAssignPartitions);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiBidirectionalStreamingCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_AssignPartitionsApiCall(ref gaxgrpc::ApiBidirectionalStreamingCall<PartitionAssignmentRequest, PartitionAssignment> call);

        partial void OnConstruction(PartitionAssignmentService.PartitionAssignmentServiceClient grpcClient, PartitionAssignmentServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC PartitionAssignmentService client</summary>
        public override PartitionAssignmentService.PartitionAssignmentServiceClient GrpcClient { get; }

        partial void Modify_PartitionAssignmentRequestCallSettings(ref gaxgrpc::CallSettings settings);

        partial void Modify_PartitionAssignmentRequestRequest(ref PartitionAssignmentRequest request);

        internal sealed partial class AssignPartitionsStreamImpl : AssignPartitionsStream
        {
            /// <summary>Construct the bidirectional streaming method for <c>AssignPartitions</c>.</summary>
            /// <param name="service">The service containing this streaming method.</param>
            /// <param name="call">The underlying gRPC duplex streaming call.</param>
            /// <param name="writeBuffer">
            /// The <see cref="gaxgrpc::BufferedClientStreamWriter{PartitionAssignmentRequest}"/> instance associated
            /// with this streaming call.
            /// </param>
            public AssignPartitionsStreamImpl(PartitionAssignmentServiceClientImpl service, grpccore::AsyncDuplexStreamingCall<PartitionAssignmentRequest, PartitionAssignment> call, gaxgrpc::BufferedClientStreamWriter<PartitionAssignmentRequest> writeBuffer)
            {
                _service = service;
                GrpcCall = call;
                _writeBuffer = writeBuffer;
            }

            private PartitionAssignmentServiceClientImpl _service;

            private gaxgrpc::BufferedClientStreamWriter<PartitionAssignmentRequest> _writeBuffer;

            public override grpccore::AsyncDuplexStreamingCall<PartitionAssignmentRequest, PartitionAssignment> GrpcCall { get; }

            private PartitionAssignmentRequest ModifyRequest(PartitionAssignmentRequest request)
            {
                _service.Modify_PartitionAssignmentRequestRequest(ref request);
                return request;
            }

            public override stt::Task TryWriteAsync(PartitionAssignmentRequest message) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message));

            public override stt::Task WriteAsync(PartitionAssignmentRequest message) =>
                _writeBuffer.WriteAsync(ModifyRequest(message));

            public override stt::Task TryWriteAsync(PartitionAssignmentRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message), options);

            public override stt::Task WriteAsync(PartitionAssignmentRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.WriteAsync(ModifyRequest(message), options);

            public override stt::Task TryWriteCompleteAsync() => _writeBuffer.TryWriteCompleteAsync();

            public override stt::Task WriteCompleteAsync() => _writeBuffer.WriteCompleteAsync();
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
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public override PartitionAssignmentServiceClient.AssignPartitionsStream AssignPartitions(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null)
        {
            Modify_PartitionAssignmentRequestCallSettings(ref callSettings);
            gaxgrpc::BidirectionalStreamingSettings effectiveStreamingSettings = streamingSettings ?? _callAssignPartitions.StreamingSettings;
            grpccore::AsyncDuplexStreamingCall<PartitionAssignmentRequest, PartitionAssignment> call = _callAssignPartitions.Call(callSettings);
            gaxgrpc::BufferedClientStreamWriter<PartitionAssignmentRequest> writeBuffer = new gaxgrpc::BufferedClientStreamWriter<PartitionAssignmentRequest>(call.RequestStream, effectiveStreamingSettings.BufferedClientWriterCapacity);
            return new AssignPartitionsStreamImpl(this, call, writeBuffer);
        }
    }
}
