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
    /// <summary>Settings for <see cref="PublisherServiceClient"/> instances.</summary>
    public sealed partial class PublisherServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="PublisherServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="PublisherServiceSettings"/>.</returns>
        public static PublisherServiceSettings GetDefault() => new PublisherServiceSettings();

        /// <summary>Constructs a new <see cref="PublisherServiceSettings"/> object with default settings.</summary>
        public PublisherServiceSettings()
        {
        }

        private PublisherServiceSettings(PublisherServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            PublishSettings = existing.PublishSettings;
            PublishStreamingSettings = existing.PublishStreamingSettings;
            OnCopy(existing);
        }

        partial void OnCopy(PublisherServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PublisherServiceClient.Publish</c> and <c>PublisherServiceClient.PublishAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PublishSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::BidirectionalStreamingSettings"/> for calls to <c>PublisherServiceClient.Publish</c> and
        /// <c>PublisherServiceClient.PublishAsync</c>.
        /// </summary>
        /// <remarks>The default local send queue size is 100.</remarks>
        public gaxgrpc::BidirectionalStreamingSettings PublishStreamingSettings { get; set; } = new gaxgrpc::BidirectionalStreamingSettings(100);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="PublisherServiceSettings"/> object.</returns>
        public PublisherServiceSettings Clone() => new PublisherServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="PublisherServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class PublisherServiceClientBuilder : gaxgrpc::ClientBuilderBase<PublisherServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public PublisherServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public PublisherServiceClientBuilder()
        {
            UseJwtAccessWithScopes = PublisherServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref PublisherServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<PublisherServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override PublisherServiceClient Build()
        {
            PublisherServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<PublisherServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<PublisherServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private PublisherServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return PublisherServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<PublisherServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return PublisherServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => PublisherServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => PublisherServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => PublisherServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>PublisherService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The service that a publisher client application uses to publish messages to
    /// topics. Published messages are retained by the service for the duration of
    /// the retention period configured for the respective topic, and are delivered
    /// to subscriber clients upon request (via the `SubscriberService`).
    /// </remarks>
    public abstract partial class PublisherServiceClient
    {
        /// <summary>
        /// The default endpoint for the PublisherService service, which is a host of "pubsublite.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "pubsublite.googleapis.com:443";

        /// <summary>The default PublisherService scopes.</summary>
        /// <remarks>
        /// The default PublisherService scopes are:
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
        /// Asynchronously creates a <see cref="PublisherServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="PublisherServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="PublisherServiceClient"/>.</returns>
        public static stt::Task<PublisherServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new PublisherServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="PublisherServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="PublisherServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="PublisherServiceClient"/>.</returns>
        public static PublisherServiceClient Create() => new PublisherServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="PublisherServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="PublisherServiceSettings"/>.</param>
        /// <returns>The created <see cref="PublisherServiceClient"/>.</returns>
        internal static PublisherServiceClient Create(grpccore::CallInvoker callInvoker, PublisherServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            PublisherService.PublisherServiceClient grpcClient = new PublisherService.PublisherServiceClient(callInvoker);
            return new PublisherServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC PublisherService client</summary>
        public virtual PublisherService.PublisherServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Bidirectional streaming methods for
        /// <see cref="Publish(gaxgrpc::CallSettings,gaxgrpc::BidirectionalStreamingSettings)"/>.
        /// </summary>
        public abstract partial class PublishStream : gaxgrpc::BidirectionalStreamingBase<PublishRequest, PublishResponse>
        {
        }

        /// <summary>
        /// Establishes a stream with the server for publishing messages. Once the
        /// stream is initialized, the client publishes messages by sending publish
        /// requests on the stream. The server responds with a PublishResponse for each
        /// PublishRequest sent by the client, in the same order that the requests
        /// were sent. Note that multiple PublishRequests can be in flight
        /// simultaneously, but they will be processed by the server in the order that
        /// they are sent by the client on a given stream.
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public virtual PublishStream Publish(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null) =>
            throw new sys::NotImplementedException();
    }

    /// <summary>PublisherService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The service that a publisher client application uses to publish messages to
    /// topics. Published messages are retained by the service for the duration of
    /// the retention period configured for the respective topic, and are delivered
    /// to subscriber clients upon request (via the `SubscriberService`).
    /// </remarks>
    public sealed partial class PublisherServiceClientImpl : PublisherServiceClient
    {
        private readonly gaxgrpc::ApiBidirectionalStreamingCall<PublishRequest, PublishResponse> _callPublish;

        /// <summary>
        /// Constructs a client wrapper for the PublisherService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="PublisherServiceSettings"/> used within this client.</param>
        public PublisherServiceClientImpl(PublisherService.PublisherServiceClient grpcClient, PublisherServiceSettings settings)
        {
            GrpcClient = grpcClient;
            PublisherServiceSettings effectiveSettings = settings ?? PublisherServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callPublish = clientHelper.BuildApiCall<PublishRequest, PublishResponse>(grpcClient.Publish, effectiveSettings.PublishSettings, effectiveSettings.PublishStreamingSettings);
            Modify_ApiCall(ref _callPublish);
            Modify_PublishApiCall(ref _callPublish);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiBidirectionalStreamingCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_PublishApiCall(ref gaxgrpc::ApiBidirectionalStreamingCall<PublishRequest, PublishResponse> call);

        partial void OnConstruction(PublisherService.PublisherServiceClient grpcClient, PublisherServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC PublisherService client</summary>
        public override PublisherService.PublisherServiceClient GrpcClient { get; }

        partial void Modify_PublishRequestCallSettings(ref gaxgrpc::CallSettings settings);

        partial void Modify_PublishRequestRequest(ref PublishRequest request);

        internal sealed partial class PublishStreamImpl : PublishStream
        {
            /// <summary>Construct the bidirectional streaming method for <c>Publish</c>.</summary>
            /// <param name="service">The service containing this streaming method.</param>
            /// <param name="call">The underlying gRPC duplex streaming call.</param>
            /// <param name="writeBuffer">
            /// The <see cref="gaxgrpc::BufferedClientStreamWriter{PublishRequest}"/> instance associated with this
            /// streaming call.
            /// </param>
            public PublishStreamImpl(PublisherServiceClientImpl service, grpccore::AsyncDuplexStreamingCall<PublishRequest, PublishResponse> call, gaxgrpc::BufferedClientStreamWriter<PublishRequest> writeBuffer)
            {
                _service = service;
                GrpcCall = call;
                _writeBuffer = writeBuffer;
            }

            private PublisherServiceClientImpl _service;

            private gaxgrpc::BufferedClientStreamWriter<PublishRequest> _writeBuffer;

            public override grpccore::AsyncDuplexStreamingCall<PublishRequest, PublishResponse> GrpcCall { get; }

            private PublishRequest ModifyRequest(PublishRequest request)
            {
                _service.Modify_PublishRequestRequest(ref request);
                return request;
            }

            public override stt::Task TryWriteAsync(PublishRequest message) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message));

            public override stt::Task WriteAsync(PublishRequest message) => _writeBuffer.WriteAsync(ModifyRequest(message));

            public override stt::Task TryWriteAsync(PublishRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message), options);

            public override stt::Task WriteAsync(PublishRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.WriteAsync(ModifyRequest(message), options);

            public override stt::Task TryWriteCompleteAsync() => _writeBuffer.TryWriteCompleteAsync();

            public override stt::Task WriteCompleteAsync() => _writeBuffer.WriteCompleteAsync();
        }

        /// <summary>
        /// Establishes a stream with the server for publishing messages. Once the
        /// stream is initialized, the client publishes messages by sending publish
        /// requests on the stream. The server responds with a PublishResponse for each
        /// PublishRequest sent by the client, in the same order that the requests
        /// were sent. Note that multiple PublishRequests can be in flight
        /// simultaneously, but they will be processed by the server in the order that
        /// they are sent by the client on a given stream.
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public override PublisherServiceClient.PublishStream Publish(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null)
        {
            Modify_PublishRequestCallSettings(ref callSettings);
            gaxgrpc::BidirectionalStreamingSettings effectiveStreamingSettings = streamingSettings ?? _callPublish.StreamingSettings;
            grpccore::AsyncDuplexStreamingCall<PublishRequest, PublishResponse> call = _callPublish.Call(callSettings);
            gaxgrpc::BufferedClientStreamWriter<PublishRequest> writeBuffer = new gaxgrpc::BufferedClientStreamWriter<PublishRequest>(call.RequestStream, effectiveStreamingSettings.BufferedClientWriterCapacity);
            return new PublishStreamImpl(this, call, writeBuffer);
        }
    }
}
