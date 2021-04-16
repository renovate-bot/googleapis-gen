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
    /// <summary>Settings for <see cref="TopicStatsServiceClient"/> instances.</summary>
    public sealed partial class TopicStatsServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="TopicStatsServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="TopicStatsServiceSettings"/>.</returns>
        public static TopicStatsServiceSettings GetDefault() => new TopicStatsServiceSettings();

        /// <summary>Constructs a new <see cref="TopicStatsServiceSettings"/> object with default settings.</summary>
        public TopicStatsServiceSettings()
        {
        }

        private TopicStatsServiceSettings(TopicStatsServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ComputeMessageStatsSettings = existing.ComputeMessageStatsSettings;
            ComputeHeadCursorSettings = existing.ComputeHeadCursorSettings;
            OnCopy(existing);
        }

        partial void OnCopy(TopicStatsServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TopicStatsServiceClient.ComputeMessageStats</c> and <c>TopicStatsServiceClient.ComputeMessageStatsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ComputeMessageStatsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable, grpccore::StatusCode.Aborted, grpccore::StatusCode.Internal, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TopicStatsServiceClient.ComputeHeadCursor</c> and <c>TopicStatsServiceClient.ComputeHeadCursorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ComputeHeadCursorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="TopicStatsServiceSettings"/> object.</returns>
        public TopicStatsServiceSettings Clone() => new TopicStatsServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="TopicStatsServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class TopicStatsServiceClientBuilder : gaxgrpc::ClientBuilderBase<TopicStatsServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public TopicStatsServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref TopicStatsServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<TopicStatsServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override TopicStatsServiceClient Build()
        {
            TopicStatsServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<TopicStatsServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<TopicStatsServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private TopicStatsServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return TopicStatsServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<TopicStatsServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return TopicStatsServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => TopicStatsServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => TopicStatsServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => TopicStatsServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>TopicStatsService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// This service allows users to get stats about messages in their topic.
    /// </remarks>
    public abstract partial class TopicStatsServiceClient
    {
        /// <summary>
        /// The default endpoint for the TopicStatsService service, which is a host of "pubsublite.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "pubsublite.googleapis.com:443";

        /// <summary>The default TopicStatsService scopes.</summary>
        /// <remarks>
        /// The default TopicStatsService scopes are:
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
        /// Asynchronously creates a <see cref="TopicStatsServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="TopicStatsServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="TopicStatsServiceClient"/>.</returns>
        public static stt::Task<TopicStatsServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new TopicStatsServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="TopicStatsServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="TopicStatsServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="TopicStatsServiceClient"/>.</returns>
        public static TopicStatsServiceClient Create() => new TopicStatsServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="TopicStatsServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="TopicStatsServiceSettings"/>.</param>
        /// <returns>The created <see cref="TopicStatsServiceClient"/>.</returns>
        internal static TopicStatsServiceClient Create(grpccore::CallInvoker callInvoker, TopicStatsServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            TopicStatsService.TopicStatsServiceClient grpcClient = new TopicStatsService.TopicStatsServiceClient(callInvoker);
            return new TopicStatsServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC TopicStatsService client</summary>
        public virtual TopicStatsService.TopicStatsServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Compute statistics about a range of messages in a given topic and
        /// partition.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ComputeMessageStatsResponse ComputeMessageStats(ComputeMessageStatsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Compute statistics about a range of messages in a given topic and
        /// partition.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ComputeMessageStatsResponse> ComputeMessageStatsAsync(ComputeMessageStatsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Compute statistics about a range of messages in a given topic and
        /// partition.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ComputeMessageStatsResponse> ComputeMessageStatsAsync(ComputeMessageStatsRequest request, st::CancellationToken cancellationToken) =>
            ComputeMessageStatsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Compute the head cursor for the partition.
        /// The head cursor's offset is guaranteed to be less than or equal to all
        /// messages which have not yet been acknowledged as published, and
        /// greater than the offset of any message whose publish has already
        /// been acknowledged. It is zero if there have never been messages in the
        /// partition.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ComputeHeadCursorResponse ComputeHeadCursor(ComputeHeadCursorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Compute the head cursor for the partition.
        /// The head cursor's offset is guaranteed to be less than or equal to all
        /// messages which have not yet been acknowledged as published, and
        /// greater than the offset of any message whose publish has already
        /// been acknowledged. It is zero if there have never been messages in the
        /// partition.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ComputeHeadCursorResponse> ComputeHeadCursorAsync(ComputeHeadCursorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Compute the head cursor for the partition.
        /// The head cursor's offset is guaranteed to be less than or equal to all
        /// messages which have not yet been acknowledged as published, and
        /// greater than the offset of any message whose publish has already
        /// been acknowledged. It is zero if there have never been messages in the
        /// partition.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ComputeHeadCursorResponse> ComputeHeadCursorAsync(ComputeHeadCursorRequest request, st::CancellationToken cancellationToken) =>
            ComputeHeadCursorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>TopicStatsService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// This service allows users to get stats about messages in their topic.
    /// </remarks>
    public sealed partial class TopicStatsServiceClientImpl : TopicStatsServiceClient
    {
        private readonly gaxgrpc::ApiCall<ComputeMessageStatsRequest, ComputeMessageStatsResponse> _callComputeMessageStats;

        private readonly gaxgrpc::ApiCall<ComputeHeadCursorRequest, ComputeHeadCursorResponse> _callComputeHeadCursor;

        /// <summary>
        /// Constructs a client wrapper for the TopicStatsService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="TopicStatsServiceSettings"/> used within this client.</param>
        public TopicStatsServiceClientImpl(TopicStatsService.TopicStatsServiceClient grpcClient, TopicStatsServiceSettings settings)
        {
            GrpcClient = grpcClient;
            TopicStatsServiceSettings effectiveSettings = settings ?? TopicStatsServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callComputeMessageStats = clientHelper.BuildApiCall<ComputeMessageStatsRequest, ComputeMessageStatsResponse>(grpcClient.ComputeMessageStatsAsync, grpcClient.ComputeMessageStats, effectiveSettings.ComputeMessageStatsSettings).WithGoogleRequestParam("topic", request => request.Topic);
            Modify_ApiCall(ref _callComputeMessageStats);
            Modify_ComputeMessageStatsApiCall(ref _callComputeMessageStats);
            _callComputeHeadCursor = clientHelper.BuildApiCall<ComputeHeadCursorRequest, ComputeHeadCursorResponse>(grpcClient.ComputeHeadCursorAsync, grpcClient.ComputeHeadCursor, effectiveSettings.ComputeHeadCursorSettings).WithGoogleRequestParam("topic", request => request.Topic);
            Modify_ApiCall(ref _callComputeHeadCursor);
            Modify_ComputeHeadCursorApiCall(ref _callComputeHeadCursor);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ComputeMessageStatsApiCall(ref gaxgrpc::ApiCall<ComputeMessageStatsRequest, ComputeMessageStatsResponse> call);

        partial void Modify_ComputeHeadCursorApiCall(ref gaxgrpc::ApiCall<ComputeHeadCursorRequest, ComputeHeadCursorResponse> call);

        partial void OnConstruction(TopicStatsService.TopicStatsServiceClient grpcClient, TopicStatsServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC TopicStatsService client</summary>
        public override TopicStatsService.TopicStatsServiceClient GrpcClient { get; }

        partial void Modify_ComputeMessageStatsRequest(ref ComputeMessageStatsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ComputeHeadCursorRequest(ref ComputeHeadCursorRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Compute statistics about a range of messages in a given topic and
        /// partition.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ComputeMessageStatsResponse ComputeMessageStats(ComputeMessageStatsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ComputeMessageStatsRequest(ref request, ref callSettings);
            return _callComputeMessageStats.Sync(request, callSettings);
        }

        /// <summary>
        /// Compute statistics about a range of messages in a given topic and
        /// partition.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ComputeMessageStatsResponse> ComputeMessageStatsAsync(ComputeMessageStatsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ComputeMessageStatsRequest(ref request, ref callSettings);
            return _callComputeMessageStats.Async(request, callSettings);
        }

        /// <summary>
        /// Compute the head cursor for the partition.
        /// The head cursor's offset is guaranteed to be less than or equal to all
        /// messages which have not yet been acknowledged as published, and
        /// greater than the offset of any message whose publish has already
        /// been acknowledged. It is zero if there have never been messages in the
        /// partition.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ComputeHeadCursorResponse ComputeHeadCursor(ComputeHeadCursorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ComputeHeadCursorRequest(ref request, ref callSettings);
            return _callComputeHeadCursor.Sync(request, callSettings);
        }

        /// <summary>
        /// Compute the head cursor for the partition.
        /// The head cursor's offset is guaranteed to be less than or equal to all
        /// messages which have not yet been acknowledged as published, and
        /// greater than the offset of any message whose publish has already
        /// been acknowledged. It is zero if there have never been messages in the
        /// partition.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ComputeHeadCursorResponse> ComputeHeadCursorAsync(ComputeHeadCursorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ComputeHeadCursorRequest(ref request, ref callSettings);
            return _callComputeHeadCursor.Async(request, callSettings);
        }
    }
}
