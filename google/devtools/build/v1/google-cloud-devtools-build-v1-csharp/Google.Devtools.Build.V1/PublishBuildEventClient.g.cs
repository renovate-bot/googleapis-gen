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
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Devtools.Build.V1
{
    /// <summary>Settings for <see cref="PublishBuildEventClient"/> instances.</summary>
    public sealed partial class PublishBuildEventSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="PublishBuildEventSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="PublishBuildEventSettings"/>.</returns>
        public static PublishBuildEventSettings GetDefault() => new PublishBuildEventSettings();

        /// <summary>Constructs a new <see cref="PublishBuildEventSettings"/> object with default settings.</summary>
        public PublishBuildEventSettings()
        {
        }

        private PublishBuildEventSettings(PublishBuildEventSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            PublishLifecycleEventSettings = existing.PublishLifecycleEventSettings;
            PublishBuildToolEventStreamSettings = existing.PublishBuildToolEventStreamSettings;
            PublishBuildToolEventStreamStreamingSettings = existing.PublishBuildToolEventStreamStreamingSettings;
            OnCopy(existing);
        }

        partial void OnCopy(PublishBuildEventSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PublishBuildEventClient.PublishLifecycleEvent</c> and
        /// <c>PublishBuildEventClient.PublishLifecycleEventAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PublishLifecycleEventSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PublishBuildEventClient.PublishBuildToolEventStream</c> and
        /// <c>PublishBuildEventClient.PublishBuildToolEventStreamAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PublishBuildToolEventStreamSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::BidirectionalStreamingSettings"/> for calls to
        /// <c>PublishBuildEventClient.PublishBuildToolEventStream</c> and
        /// <c>PublishBuildEventClient.PublishBuildToolEventStreamAsync</c>.
        /// </summary>
        /// <remarks>The default local send queue size is 100.</remarks>
        public gaxgrpc::BidirectionalStreamingSettings PublishBuildToolEventStreamStreamingSettings { get; set; } = new gaxgrpc::BidirectionalStreamingSettings(100);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="PublishBuildEventSettings"/> object.</returns>
        public PublishBuildEventSettings Clone() => new PublishBuildEventSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="PublishBuildEventClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class PublishBuildEventClientBuilder : gaxgrpc::ClientBuilderBase<PublishBuildEventClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public PublishBuildEventSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public PublishBuildEventClientBuilder()
        {
            UseJwtAccessWithScopes = PublishBuildEventClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref PublishBuildEventClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<PublishBuildEventClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override PublishBuildEventClient Build()
        {
            PublishBuildEventClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<PublishBuildEventClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<PublishBuildEventClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private PublishBuildEventClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return PublishBuildEventClient.Create(callInvoker, Settings);
        }

        private async stt::Task<PublishBuildEventClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return PublishBuildEventClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => PublishBuildEventClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => PublishBuildEventClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => PublishBuildEventClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>PublishBuildEvent client wrapper, for convenient use.</summary>
    /// <remarks>
    /// A service for publishing BuildEvents. BuildEvents are generated by Build
    /// Systems to record actions taken during a Build. Events occur in streams,
    /// are identified by a StreamId, and ordered by sequence number in a stream.
    /// 
    /// A Build may contain several streams of BuildEvents, depending on the systems
    /// that are involved in the Build. Some BuildEvents are used to declare the
    /// beginning and end of major portions of a Build; these are called
    /// LifecycleEvents, and are used (for example) to indicate the beginning or end
    /// of a Build, and the beginning or end of an Invocation attempt (there can be
    /// more than 1 Invocation in a Build if, for example, a failure occurs somewhere
    /// and it needs to be retried).
    /// 
    /// Other, build-tool events represent actions taken by the Build tool, such as
    /// target objects produced via compilation, tests run, et cetera. There could be
    /// more than one build tool stream for an invocation attempt of a build.
    /// </remarks>
    public abstract partial class PublishBuildEventClient
    {
        /// <summary>
        /// The default endpoint for the PublishBuildEvent service, which is a host of
        /// "buildeventservice.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "buildeventservice.googleapis.com:443";

        /// <summary>The default PublishBuildEvent scopes.</summary>
        /// <remarks>
        /// The default PublishBuildEvent scopes are:
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
        /// Asynchronously creates a <see cref="PublishBuildEventClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="PublishBuildEventClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="PublishBuildEventClient"/>.</returns>
        public static stt::Task<PublishBuildEventClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new PublishBuildEventClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="PublishBuildEventClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="PublishBuildEventClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="PublishBuildEventClient"/>.</returns>
        public static PublishBuildEventClient Create() => new PublishBuildEventClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="PublishBuildEventClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="PublishBuildEventSettings"/>.</param>
        /// <returns>The created <see cref="PublishBuildEventClient"/>.</returns>
        internal static PublishBuildEventClient Create(grpccore::CallInvoker callInvoker, PublishBuildEventSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            PublishBuildEvent.PublishBuildEventClient grpcClient = new PublishBuildEvent.PublishBuildEventClient(callInvoker);
            return new PublishBuildEventClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC PublishBuildEvent client</summary>
        public virtual PublishBuildEvent.PublishBuildEventClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Publish a build event stating the new state of a build (typically from the
        /// build queue). The BuildEnqueued event must be publishd before all other
        /// events for the same build ID.
        /// 
        /// The backend will persist the event and deliver it to registered frontend
        /// jobs immediately without batching.
        /// 
        /// The commit status of the request is reported by the RPC's util_status()
        /// function. The error code is the canoncial error code defined in
        /// //util/task/codes.proto.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void PublishLifecycleEvent(PublishLifecycleEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Publish a build event stating the new state of a build (typically from the
        /// build queue). The BuildEnqueued event must be publishd before all other
        /// events for the same build ID.
        /// 
        /// The backend will persist the event and deliver it to registered frontend
        /// jobs immediately without batching.
        /// 
        /// The commit status of the request is reported by the RPC's util_status()
        /// function. The error code is the canoncial error code defined in
        /// //util/task/codes.proto.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task PublishLifecycleEventAsync(PublishLifecycleEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Publish a build event stating the new state of a build (typically from the
        /// build queue). The BuildEnqueued event must be publishd before all other
        /// events for the same build ID.
        /// 
        /// The backend will persist the event and deliver it to registered frontend
        /// jobs immediately without batching.
        /// 
        /// The commit status of the request is reported by the RPC's util_status()
        /// function. The error code is the canoncial error code defined in
        /// //util/task/codes.proto.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task PublishLifecycleEventAsync(PublishLifecycleEventRequest request, st::CancellationToken cancellationToken) =>
            PublishLifecycleEventAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Bidirectional streaming methods for
        /// <see cref="PublishBuildToolEventStream(gaxgrpc::CallSettings,gaxgrpc::BidirectionalStreamingSettings)"/>.
        /// </summary>
        public abstract partial class PublishBuildToolEventStreamStream : gaxgrpc::BidirectionalStreamingBase<PublishBuildToolEventStreamRequest, PublishBuildToolEventStreamResponse>
        {
        }

        /// <summary>
        /// Publish build tool events belonging to the same stream to a backend job
        /// using bidirectional streaming.
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public virtual PublishBuildToolEventStreamStream PublishBuildToolEventStream(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null) =>
            throw new sys::NotImplementedException();
    }

    /// <summary>PublishBuildEvent client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// A service for publishing BuildEvents. BuildEvents are generated by Build
    /// Systems to record actions taken during a Build. Events occur in streams,
    /// are identified by a StreamId, and ordered by sequence number in a stream.
    /// 
    /// A Build may contain several streams of BuildEvents, depending on the systems
    /// that are involved in the Build. Some BuildEvents are used to declare the
    /// beginning and end of major portions of a Build; these are called
    /// LifecycleEvents, and are used (for example) to indicate the beginning or end
    /// of a Build, and the beginning or end of an Invocation attempt (there can be
    /// more than 1 Invocation in a Build if, for example, a failure occurs somewhere
    /// and it needs to be retried).
    /// 
    /// Other, build-tool events represent actions taken by the Build tool, such as
    /// target objects produced via compilation, tests run, et cetera. There could be
    /// more than one build tool stream for an invocation attempt of a build.
    /// </remarks>
    public sealed partial class PublishBuildEventClientImpl : PublishBuildEventClient
    {
        private readonly gaxgrpc::ApiCall<PublishLifecycleEventRequest, wkt::Empty> _callPublishLifecycleEvent;

        private readonly gaxgrpc::ApiBidirectionalStreamingCall<PublishBuildToolEventStreamRequest, PublishBuildToolEventStreamResponse> _callPublishBuildToolEventStream;

        /// <summary>
        /// Constructs a client wrapper for the PublishBuildEvent service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="PublishBuildEventSettings"/> used within this client.</param>
        public PublishBuildEventClientImpl(PublishBuildEvent.PublishBuildEventClient grpcClient, PublishBuildEventSettings settings)
        {
            GrpcClient = grpcClient;
            PublishBuildEventSettings effectiveSettings = settings ?? PublishBuildEventSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callPublishLifecycleEvent = clientHelper.BuildApiCall<PublishLifecycleEventRequest, wkt::Empty>(grpcClient.PublishLifecycleEventAsync, grpcClient.PublishLifecycleEvent, effectiveSettings.PublishLifecycleEventSettings).WithGoogleRequestParam("project_id", request => request.ProjectId);
            Modify_ApiCall(ref _callPublishLifecycleEvent);
            Modify_PublishLifecycleEventApiCall(ref _callPublishLifecycleEvent);
            _callPublishBuildToolEventStream = clientHelper.BuildApiCall<PublishBuildToolEventStreamRequest, PublishBuildToolEventStreamResponse>(grpcClient.PublishBuildToolEventStream, effectiveSettings.PublishBuildToolEventStreamSettings, effectiveSettings.PublishBuildToolEventStreamStreamingSettings);
            Modify_ApiCall(ref _callPublishBuildToolEventStream);
            Modify_PublishBuildToolEventStreamApiCall(ref _callPublishBuildToolEventStream);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiBidirectionalStreamingCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_PublishLifecycleEventApiCall(ref gaxgrpc::ApiCall<PublishLifecycleEventRequest, wkt::Empty> call);

        partial void Modify_PublishBuildToolEventStreamApiCall(ref gaxgrpc::ApiBidirectionalStreamingCall<PublishBuildToolEventStreamRequest, PublishBuildToolEventStreamResponse> call);

        partial void OnConstruction(PublishBuildEvent.PublishBuildEventClient grpcClient, PublishBuildEventSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC PublishBuildEvent client</summary>
        public override PublishBuildEvent.PublishBuildEventClient GrpcClient { get; }

        partial void Modify_PublishLifecycleEventRequest(ref PublishLifecycleEventRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PublishBuildToolEventStreamRequestCallSettings(ref gaxgrpc::CallSettings settings);

        partial void Modify_PublishBuildToolEventStreamRequestRequest(ref PublishBuildToolEventStreamRequest request);

        /// <summary>
        /// Publish a build event stating the new state of a build (typically from the
        /// build queue). The BuildEnqueued event must be publishd before all other
        /// events for the same build ID.
        /// 
        /// The backend will persist the event and deliver it to registered frontend
        /// jobs immediately without batching.
        /// 
        /// The commit status of the request is reported by the RPC's util_status()
        /// function. The error code is the canoncial error code defined in
        /// //util/task/codes.proto.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void PublishLifecycleEvent(PublishLifecycleEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PublishLifecycleEventRequest(ref request, ref callSettings);
            _callPublishLifecycleEvent.Sync(request, callSettings);
        }

        /// <summary>
        /// Publish a build event stating the new state of a build (typically from the
        /// build queue). The BuildEnqueued event must be publishd before all other
        /// events for the same build ID.
        /// 
        /// The backend will persist the event and deliver it to registered frontend
        /// jobs immediately without batching.
        /// 
        /// The commit status of the request is reported by the RPC's util_status()
        /// function. The error code is the canoncial error code defined in
        /// //util/task/codes.proto.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task PublishLifecycleEventAsync(PublishLifecycleEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PublishLifecycleEventRequest(ref request, ref callSettings);
            return _callPublishLifecycleEvent.Async(request, callSettings);
        }

        internal sealed partial class PublishBuildToolEventStreamStreamImpl : PublishBuildToolEventStreamStream
        {
            /// <summary>Construct the bidirectional streaming method for <c>PublishBuildToolEventStream</c>.</summary>
            /// <param name="service">The service containing this streaming method.</param>
            /// <param name="call">The underlying gRPC duplex streaming call.</param>
            /// <param name="writeBuffer">
            /// The <see cref="gaxgrpc::BufferedClientStreamWriter{PublishBuildToolEventStreamRequest}"/> instance
            /// associated with this streaming call.
            /// </param>
            public PublishBuildToolEventStreamStreamImpl(PublishBuildEventClientImpl service, grpccore::AsyncDuplexStreamingCall<PublishBuildToolEventStreamRequest, PublishBuildToolEventStreamResponse> call, gaxgrpc::BufferedClientStreamWriter<PublishBuildToolEventStreamRequest> writeBuffer)
            {
                _service = service;
                GrpcCall = call;
                _writeBuffer = writeBuffer;
            }

            private PublishBuildEventClientImpl _service;

            private gaxgrpc::BufferedClientStreamWriter<PublishBuildToolEventStreamRequest> _writeBuffer;

            public override grpccore::AsyncDuplexStreamingCall<PublishBuildToolEventStreamRequest, PublishBuildToolEventStreamResponse> GrpcCall { get; }

            private PublishBuildToolEventStreamRequest ModifyRequest(PublishBuildToolEventStreamRequest request)
            {
                _service.Modify_PublishBuildToolEventStreamRequestRequest(ref request);
                return request;
            }

            public override stt::Task TryWriteAsync(PublishBuildToolEventStreamRequest message) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message));

            public override stt::Task WriteAsync(PublishBuildToolEventStreamRequest message) =>
                _writeBuffer.WriteAsync(ModifyRequest(message));

            public override stt::Task TryWriteAsync(PublishBuildToolEventStreamRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message), options);

            public override stt::Task WriteAsync(PublishBuildToolEventStreamRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.WriteAsync(ModifyRequest(message), options);

            public override stt::Task TryWriteCompleteAsync() => _writeBuffer.TryWriteCompleteAsync();

            public override stt::Task WriteCompleteAsync() => _writeBuffer.WriteCompleteAsync();
        }

        /// <summary>
        /// Publish build tool events belonging to the same stream to a backend job
        /// using bidirectional streaming.
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public override PublishBuildEventClient.PublishBuildToolEventStreamStream PublishBuildToolEventStream(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null)
        {
            Modify_PublishBuildToolEventStreamRequestCallSettings(ref callSettings);
            gaxgrpc::BidirectionalStreamingSettings effectiveStreamingSettings = streamingSettings ?? _callPublishBuildToolEventStream.StreamingSettings;
            grpccore::AsyncDuplexStreamingCall<PublishBuildToolEventStreamRequest, PublishBuildToolEventStreamResponse> call = _callPublishBuildToolEventStream.Call(callSettings);
            gaxgrpc::BufferedClientStreamWriter<PublishBuildToolEventStreamRequest> writeBuffer = new gaxgrpc::BufferedClientStreamWriter<PublishBuildToolEventStreamRequest>(call.RequestStream, effectiveStreamingSettings.BufferedClientWriterCapacity);
            return new PublishBuildToolEventStreamStreamImpl(this, call, writeBuffer);
        }
    }
}
