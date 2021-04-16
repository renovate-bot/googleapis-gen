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

namespace Google.Cloud.VideoIntelligence.V1P3Beta1
{
    /// <summary>Settings for <see cref="StreamingVideoIntelligenceServiceClient"/> instances.</summary>
    public sealed partial class StreamingVideoIntelligenceServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="StreamingVideoIntelligenceServiceSettings"/>.
        /// </summary>
        /// <returns>A new instance of the default <see cref="StreamingVideoIntelligenceServiceSettings"/>.</returns>
        public static StreamingVideoIntelligenceServiceSettings GetDefault() =>
            new StreamingVideoIntelligenceServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="StreamingVideoIntelligenceServiceSettings"/> object with default settings.
        /// </summary>
        public StreamingVideoIntelligenceServiceSettings()
        {
        }

        private StreamingVideoIntelligenceServiceSettings(StreamingVideoIntelligenceServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            StreamingAnnotateVideoSettings = existing.StreamingAnnotateVideoSettings;
            StreamingAnnotateVideoStreamingSettings = existing.StreamingAnnotateVideoStreamingSettings;
            OnCopy(existing);
        }

        partial void OnCopy(StreamingVideoIntelligenceServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StreamingVideoIntelligenceServiceClient.StreamingAnnotateVideo</c> and
        /// <c>StreamingVideoIntelligenceServiceClient.StreamingAnnotateVideoAsync</c>.
        /// </summary>
        /// <remarks>Timeout: 10800 seconds.</remarks>
        public gaxgrpc::CallSettings StreamingAnnotateVideoSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10800000)));

        /// <summary>
        /// <see cref="gaxgrpc::BidirectionalStreamingSettings"/> for calls to
        /// <c>StreamingVideoIntelligenceServiceClient.StreamingAnnotateVideo</c> and
        /// <c>StreamingVideoIntelligenceServiceClient.StreamingAnnotateVideoAsync</c>.
        /// </summary>
        /// <remarks>The default local send queue size is 100.</remarks>
        public gaxgrpc::BidirectionalStreamingSettings StreamingAnnotateVideoStreamingSettings { get; set; } = new gaxgrpc::BidirectionalStreamingSettings(100);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="StreamingVideoIntelligenceServiceSettings"/> object.</returns>
        public StreamingVideoIntelligenceServiceSettings Clone() => new StreamingVideoIntelligenceServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="StreamingVideoIntelligenceServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class StreamingVideoIntelligenceServiceClientBuilder : gaxgrpc::ClientBuilderBase<StreamingVideoIntelligenceServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public StreamingVideoIntelligenceServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref StreamingVideoIntelligenceServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<StreamingVideoIntelligenceServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override StreamingVideoIntelligenceServiceClient Build()
        {
            StreamingVideoIntelligenceServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<StreamingVideoIntelligenceServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<StreamingVideoIntelligenceServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private StreamingVideoIntelligenceServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return StreamingVideoIntelligenceServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<StreamingVideoIntelligenceServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return StreamingVideoIntelligenceServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => StreamingVideoIntelligenceServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() =>
            StreamingVideoIntelligenceServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => StreamingVideoIntelligenceServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>StreamingVideoIntelligenceService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service that implements streaming Video Intelligence API.
    /// </remarks>
    public abstract partial class StreamingVideoIntelligenceServiceClient
    {
        /// <summary>
        /// The default endpoint for the StreamingVideoIntelligenceService service, which is a host of
        /// "videointelligence.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "videointelligence.googleapis.com:443";

        /// <summary>The default StreamingVideoIntelligenceService scopes.</summary>
        /// <remarks>
        /// The default StreamingVideoIntelligenceService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="StreamingVideoIntelligenceServiceClient"/> using the default
        /// credentials, endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="StreamingVideoIntelligenceServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="StreamingVideoIntelligenceServiceClient"/>.</returns>
        public static stt::Task<StreamingVideoIntelligenceServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new StreamingVideoIntelligenceServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="StreamingVideoIntelligenceServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="StreamingVideoIntelligenceServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="StreamingVideoIntelligenceServiceClient"/>.</returns>
        public static StreamingVideoIntelligenceServiceClient Create() =>
            new StreamingVideoIntelligenceServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="StreamingVideoIntelligenceServiceClient"/> which uses the specified call invoker for
        /// remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="StreamingVideoIntelligenceServiceSettings"/>.</param>
        /// <returns>The created <see cref="StreamingVideoIntelligenceServiceClient"/>.</returns>
        internal static StreamingVideoIntelligenceServiceClient Create(grpccore::CallInvoker callInvoker, StreamingVideoIntelligenceServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            StreamingVideoIntelligenceService.StreamingVideoIntelligenceServiceClient grpcClient = new StreamingVideoIntelligenceService.StreamingVideoIntelligenceServiceClient(callInvoker);
            return new StreamingVideoIntelligenceServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC StreamingVideoIntelligenceService client</summary>
        public virtual StreamingVideoIntelligenceService.StreamingVideoIntelligenceServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Bidirectional streaming methods for
        /// <see cref="StreamingAnnotateVideo(gaxgrpc::CallSettings,gaxgrpc::BidirectionalStreamingSettings)"/>.
        /// </summary>
        public abstract partial class StreamingAnnotateVideoStream : gaxgrpc::BidirectionalStreamingBase<StreamingAnnotateVideoRequest, StreamingAnnotateVideoResponse>
        {
        }

        /// <summary>
        /// Performs video annotation with bidirectional streaming: emitting results
        /// while sending video/audio bytes.
        /// This method is only available via the gRPC API (not REST).
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public virtual StreamingAnnotateVideoStream StreamingAnnotateVideo(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null) =>
            throw new sys::NotImplementedException();
    }

    /// <summary>StreamingVideoIntelligenceService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service that implements streaming Video Intelligence API.
    /// </remarks>
    public sealed partial class StreamingVideoIntelligenceServiceClientImpl : StreamingVideoIntelligenceServiceClient
    {
        private readonly gaxgrpc::ApiBidirectionalStreamingCall<StreamingAnnotateVideoRequest, StreamingAnnotateVideoResponse> _callStreamingAnnotateVideo;

        /// <summary>
        /// Constructs a client wrapper for the StreamingVideoIntelligenceService service, with the specified gRPC
        /// client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="StreamingVideoIntelligenceServiceSettings"/> used within this client.
        /// </param>
        public StreamingVideoIntelligenceServiceClientImpl(StreamingVideoIntelligenceService.StreamingVideoIntelligenceServiceClient grpcClient, StreamingVideoIntelligenceServiceSettings settings)
        {
            GrpcClient = grpcClient;
            StreamingVideoIntelligenceServiceSettings effectiveSettings = settings ?? StreamingVideoIntelligenceServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callStreamingAnnotateVideo = clientHelper.BuildApiCall<StreamingAnnotateVideoRequest, StreamingAnnotateVideoResponse>(grpcClient.StreamingAnnotateVideo, effectiveSettings.StreamingAnnotateVideoSettings, effectiveSettings.StreamingAnnotateVideoStreamingSettings);
            Modify_ApiCall(ref _callStreamingAnnotateVideo);
            Modify_StreamingAnnotateVideoApiCall(ref _callStreamingAnnotateVideo);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiBidirectionalStreamingCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_StreamingAnnotateVideoApiCall(ref gaxgrpc::ApiBidirectionalStreamingCall<StreamingAnnotateVideoRequest, StreamingAnnotateVideoResponse> call);

        partial void OnConstruction(StreamingVideoIntelligenceService.StreamingVideoIntelligenceServiceClient grpcClient, StreamingVideoIntelligenceServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC StreamingVideoIntelligenceService client</summary>
        public override StreamingVideoIntelligenceService.StreamingVideoIntelligenceServiceClient GrpcClient { get; }

        partial void Modify_StreamingAnnotateVideoRequestCallSettings(ref gaxgrpc::CallSettings settings);

        partial void Modify_StreamingAnnotateVideoRequestRequest(ref StreamingAnnotateVideoRequest request);

        internal sealed partial class StreamingAnnotateVideoStreamImpl : StreamingAnnotateVideoStream
        {
            /// <summary>Construct the bidirectional streaming method for <c>StreamingAnnotateVideo</c>.</summary>
            /// <param name="service">The service containing this streaming method.</param>
            /// <param name="call">The underlying gRPC duplex streaming call.</param>
            /// <param name="writeBuffer">
            /// The <see cref="gaxgrpc::BufferedClientStreamWriter{StreamingAnnotateVideoRequest}"/> instance associated
            /// with this streaming call.
            /// </param>
            public StreamingAnnotateVideoStreamImpl(StreamingVideoIntelligenceServiceClientImpl service, grpccore::AsyncDuplexStreamingCall<StreamingAnnotateVideoRequest, StreamingAnnotateVideoResponse> call, gaxgrpc::BufferedClientStreamWriter<StreamingAnnotateVideoRequest> writeBuffer)
            {
                _service = service;
                GrpcCall = call;
                _writeBuffer = writeBuffer;
            }

            private StreamingVideoIntelligenceServiceClientImpl _service;

            private gaxgrpc::BufferedClientStreamWriter<StreamingAnnotateVideoRequest> _writeBuffer;

            public override grpccore::AsyncDuplexStreamingCall<StreamingAnnotateVideoRequest, StreamingAnnotateVideoResponse> GrpcCall { get; }

            private StreamingAnnotateVideoRequest ModifyRequest(StreamingAnnotateVideoRequest request)
            {
                _service.Modify_StreamingAnnotateVideoRequestRequest(ref request);
                return request;
            }

            public override stt::Task TryWriteAsync(StreamingAnnotateVideoRequest message) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message));

            public override stt::Task WriteAsync(StreamingAnnotateVideoRequest message) =>
                _writeBuffer.WriteAsync(ModifyRequest(message));

            public override stt::Task TryWriteAsync(StreamingAnnotateVideoRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message), options);

            public override stt::Task WriteAsync(StreamingAnnotateVideoRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.WriteAsync(ModifyRequest(message), options);

            public override stt::Task TryWriteCompleteAsync() => _writeBuffer.TryWriteCompleteAsync();

            public override stt::Task WriteCompleteAsync() => _writeBuffer.WriteCompleteAsync();
        }

        /// <summary>
        /// Performs video annotation with bidirectional streaming: emitting results
        /// while sending video/audio bytes.
        /// This method is only available via the gRPC API (not REST).
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public override StreamingVideoIntelligenceServiceClient.StreamingAnnotateVideoStream StreamingAnnotateVideo(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null)
        {
            Modify_StreamingAnnotateVideoRequestCallSettings(ref callSettings);
            gaxgrpc::BidirectionalStreamingSettings effectiveStreamingSettings = streamingSettings ?? _callStreamingAnnotateVideo.StreamingSettings;
            grpccore::AsyncDuplexStreamingCall<StreamingAnnotateVideoRequest, StreamingAnnotateVideoResponse> call = _callStreamingAnnotateVideo.Call(callSettings);
            gaxgrpc::BufferedClientStreamWriter<StreamingAnnotateVideoRequest> writeBuffer = new gaxgrpc::BufferedClientStreamWriter<StreamingAnnotateVideoRequest>(call.RequestStream, effectiveStreamingSettings.BufferedClientWriterCapacity);
            return new StreamingAnnotateVideoStreamImpl(this, call, writeBuffer);
        }
    }
}
