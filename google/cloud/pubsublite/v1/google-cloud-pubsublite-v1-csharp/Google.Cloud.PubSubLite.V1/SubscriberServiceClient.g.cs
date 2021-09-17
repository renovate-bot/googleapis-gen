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
    /// <summary>Settings for <see cref="SubscriberServiceClient"/> instances.</summary>
    public sealed partial class SubscriberServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="SubscriberServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="SubscriberServiceSettings"/>.</returns>
        public static SubscriberServiceSettings GetDefault() => new SubscriberServiceSettings();

        /// <summary>Constructs a new <see cref="SubscriberServiceSettings"/> object with default settings.</summary>
        public SubscriberServiceSettings()
        {
        }

        private SubscriberServiceSettings(SubscriberServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            SubscribeSettings = existing.SubscribeSettings;
            SubscribeStreamingSettings = existing.SubscribeStreamingSettings;
            OnCopy(existing);
        }

        partial void OnCopy(SubscriberServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SubscriberServiceClient.Subscribe</c> and <c>SubscriberServiceClient.SubscribeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SubscribeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::BidirectionalStreamingSettings"/> for calls to <c>SubscriberServiceClient.Subscribe</c>
        /// and <c>SubscriberServiceClient.SubscribeAsync</c>.
        /// </summary>
        /// <remarks>The default local send queue size is 100.</remarks>
        public gaxgrpc::BidirectionalStreamingSettings SubscribeStreamingSettings { get; set; } = new gaxgrpc::BidirectionalStreamingSettings(100);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="SubscriberServiceSettings"/> object.</returns>
        public SubscriberServiceSettings Clone() => new SubscriberServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SubscriberServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class SubscriberServiceClientBuilder : gaxgrpc::ClientBuilderBase<SubscriberServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public SubscriberServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public SubscriberServiceClientBuilder()
        {
            UseJwtAccessWithScopes = SubscriberServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref SubscriberServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<SubscriberServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override SubscriberServiceClient Build()
        {
            SubscriberServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<SubscriberServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<SubscriberServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private SubscriberServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SubscriberServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<SubscriberServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SubscriberServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => SubscriberServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => SubscriberServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => SubscriberServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>SubscriberService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The service that a subscriber client application uses to receive messages
    /// from subscriptions.
    /// </remarks>
    public abstract partial class SubscriberServiceClient
    {
        /// <summary>
        /// The default endpoint for the SubscriberService service, which is a host of "pubsublite.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "pubsublite.googleapis.com:443";

        /// <summary>The default SubscriberService scopes.</summary>
        /// <remarks>
        /// The default SubscriberService scopes are:
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
        /// Asynchronously creates a <see cref="SubscriberServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="SubscriberServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="SubscriberServiceClient"/>.</returns>
        public static stt::Task<SubscriberServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new SubscriberServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="SubscriberServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="SubscriberServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="SubscriberServiceClient"/>.</returns>
        public static SubscriberServiceClient Create() => new SubscriberServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="SubscriberServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="SubscriberServiceSettings"/>.</param>
        /// <returns>The created <see cref="SubscriberServiceClient"/>.</returns>
        internal static SubscriberServiceClient Create(grpccore::CallInvoker callInvoker, SubscriberServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            SubscriberService.SubscriberServiceClient grpcClient = new SubscriberService.SubscriberServiceClient(callInvoker);
            return new SubscriberServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC SubscriberService client</summary>
        public virtual SubscriberService.SubscriberServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Bidirectional streaming methods for
        /// <see cref="Subscribe(gaxgrpc::CallSettings,gaxgrpc::BidirectionalStreamingSettings)"/>.
        /// </summary>
        public abstract partial class SubscribeStream : gaxgrpc::BidirectionalStreamingBase<SubscribeRequest, SubscribeResponse>
        {
        }

        /// <summary>
        /// Establishes a stream with the server for receiving messages.
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public virtual SubscribeStream Subscribe(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null) =>
            throw new sys::NotImplementedException();
    }

    /// <summary>SubscriberService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The service that a subscriber client application uses to receive messages
    /// from subscriptions.
    /// </remarks>
    public sealed partial class SubscriberServiceClientImpl : SubscriberServiceClient
    {
        private readonly gaxgrpc::ApiBidirectionalStreamingCall<SubscribeRequest, SubscribeResponse> _callSubscribe;

        /// <summary>
        /// Constructs a client wrapper for the SubscriberService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="SubscriberServiceSettings"/> used within this client.</param>
        public SubscriberServiceClientImpl(SubscriberService.SubscriberServiceClient grpcClient, SubscriberServiceSettings settings)
        {
            GrpcClient = grpcClient;
            SubscriberServiceSettings effectiveSettings = settings ?? SubscriberServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callSubscribe = clientHelper.BuildApiCall<SubscribeRequest, SubscribeResponse>(grpcClient.Subscribe, effectiveSettings.SubscribeSettings, effectiveSettings.SubscribeStreamingSettings);
            Modify_ApiCall(ref _callSubscribe);
            Modify_SubscribeApiCall(ref _callSubscribe);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiBidirectionalStreamingCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_SubscribeApiCall(ref gaxgrpc::ApiBidirectionalStreamingCall<SubscribeRequest, SubscribeResponse> call);

        partial void OnConstruction(SubscriberService.SubscriberServiceClient grpcClient, SubscriberServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC SubscriberService client</summary>
        public override SubscriberService.SubscriberServiceClient GrpcClient { get; }

        partial void Modify_SubscribeRequestCallSettings(ref gaxgrpc::CallSettings settings);

        partial void Modify_SubscribeRequestRequest(ref SubscribeRequest request);

        internal sealed partial class SubscribeStreamImpl : SubscribeStream
        {
            /// <summary>Construct the bidirectional streaming method for <c>Subscribe</c>.</summary>
            /// <param name="service">The service containing this streaming method.</param>
            /// <param name="call">The underlying gRPC duplex streaming call.</param>
            /// <param name="writeBuffer">
            /// The <see cref="gaxgrpc::BufferedClientStreamWriter{SubscribeRequest}"/> instance associated with this
            /// streaming call.
            /// </param>
            public SubscribeStreamImpl(SubscriberServiceClientImpl service, grpccore::AsyncDuplexStreamingCall<SubscribeRequest, SubscribeResponse> call, gaxgrpc::BufferedClientStreamWriter<SubscribeRequest> writeBuffer)
            {
                _service = service;
                GrpcCall = call;
                _writeBuffer = writeBuffer;
            }

            private SubscriberServiceClientImpl _service;

            private gaxgrpc::BufferedClientStreamWriter<SubscribeRequest> _writeBuffer;

            public override grpccore::AsyncDuplexStreamingCall<SubscribeRequest, SubscribeResponse> GrpcCall { get; }

            private SubscribeRequest ModifyRequest(SubscribeRequest request)
            {
                _service.Modify_SubscribeRequestRequest(ref request);
                return request;
            }

            public override stt::Task TryWriteAsync(SubscribeRequest message) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message));

            public override stt::Task WriteAsync(SubscribeRequest message) => _writeBuffer.WriteAsync(ModifyRequest(message));

            public override stt::Task TryWriteAsync(SubscribeRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message), options);

            public override stt::Task WriteAsync(SubscribeRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.WriteAsync(ModifyRequest(message), options);

            public override stt::Task TryWriteCompleteAsync() => _writeBuffer.TryWriteCompleteAsync();

            public override stt::Task WriteCompleteAsync() => _writeBuffer.WriteCompleteAsync();
        }

        /// <summary>
        /// Establishes a stream with the server for receiving messages.
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public override SubscriberServiceClient.SubscribeStream Subscribe(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null)
        {
            Modify_SubscribeRequestCallSettings(ref callSettings);
            gaxgrpc::BidirectionalStreamingSettings effectiveStreamingSettings = streamingSettings ?? _callSubscribe.StreamingSettings;
            grpccore::AsyncDuplexStreamingCall<SubscribeRequest, SubscribeResponse> call = _callSubscribe.Call(callSettings);
            gaxgrpc::BufferedClientStreamWriter<SubscribeRequest> writeBuffer = new gaxgrpc::BufferedClientStreamWriter<SubscribeRequest>(call.RequestStream, effectiveStreamingSettings.BufferedClientWriterCapacity);
            return new SubscribeStreamImpl(this, call, writeBuffer);
        }
    }
}
