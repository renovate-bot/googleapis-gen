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
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.PubSubLite.V1
{
    /// <summary>Settings for <see cref="CursorServiceClient"/> instances.</summary>
    public sealed partial class CursorServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CursorServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CursorServiceSettings"/>.</returns>
        public static CursorServiceSettings GetDefault() => new CursorServiceSettings();

        /// <summary>Constructs a new <see cref="CursorServiceSettings"/> object with default settings.</summary>
        public CursorServiceSettings()
        {
        }

        private CursorServiceSettings(CursorServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            StreamingCommitCursorSettings = existing.StreamingCommitCursorSettings;
            StreamingCommitCursorStreamingSettings = existing.StreamingCommitCursorStreamingSettings;
            CommitCursorSettings = existing.CommitCursorSettings;
            ListPartitionCursorsSettings = existing.ListPartitionCursorsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CursorServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CursorServiceClient.StreamingCommitCursor</c> and <c>CursorServiceClient.StreamingCommitCursorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StreamingCommitCursorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::BidirectionalStreamingSettings"/> for calls to
        /// <c>CursorServiceClient.StreamingCommitCursor</c> and <c>CursorServiceClient.StreamingCommitCursorAsync</c>.
        /// </summary>
        /// <remarks>The default local send queue size is 100.</remarks>
        public gaxgrpc::BidirectionalStreamingSettings StreamingCommitCursorStreamingSettings { get; set; } = new gaxgrpc::BidirectionalStreamingSettings(100);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CursorServiceClient.CommitCursor</c> and <c>CursorServiceClient.CommitCursorAsync</c>.
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
        public gaxgrpc::CallSettings CommitCursorSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable, grpccore::StatusCode.Aborted, grpccore::StatusCode.Internal, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CursorServiceClient.ListPartitionCursors</c> and <c>CursorServiceClient.ListPartitionCursorsAsync</c>.
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
        public gaxgrpc::CallSettings ListPartitionCursorsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable, grpccore::StatusCode.Aborted, grpccore::StatusCode.Internal, grpccore::StatusCode.Unknown)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CursorServiceSettings"/> object.</returns>
        public CursorServiceSettings Clone() => new CursorServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CursorServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class CursorServiceClientBuilder : gaxgrpc::ClientBuilderBase<CursorServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CursorServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref CursorServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CursorServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CursorServiceClient Build()
        {
            CursorServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CursorServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CursorServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CursorServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CursorServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<CursorServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CursorServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => CursorServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => CursorServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CursorServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>CursorService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The service that a subscriber client application uses to manage committed
    /// cursors while receiving messsages. A cursor represents a subscriber's
    /// progress within a topic partition for a given subscription.
    /// </remarks>
    public abstract partial class CursorServiceClient
    {
        /// <summary>
        /// The default endpoint for the CursorService service, which is a host of "pubsublite.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "pubsublite.googleapis.com:443";

        /// <summary>The default CursorService scopes.</summary>
        /// <remarks>
        /// The default CursorService scopes are:
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
        /// Asynchronously creates a <see cref="CursorServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CursorServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CursorServiceClient"/>.</returns>
        public static stt::Task<CursorServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CursorServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CursorServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CursorServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CursorServiceClient"/>.</returns>
        public static CursorServiceClient Create() => new CursorServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CursorServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CursorServiceSettings"/>.</param>
        /// <returns>The created <see cref="CursorServiceClient"/>.</returns>
        internal static CursorServiceClient Create(grpccore::CallInvoker callInvoker, CursorServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CursorService.CursorServiceClient grpcClient = new CursorService.CursorServiceClient(callInvoker);
            return new CursorServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC CursorService client</summary>
        public virtual CursorService.CursorServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Bidirectional streaming methods for
        /// <see cref="StreamingCommitCursor(gaxgrpc::CallSettings,gaxgrpc::BidirectionalStreamingSettings)"/>.
        /// </summary>
        public abstract partial class StreamingCommitCursorStream : gaxgrpc::BidirectionalStreamingBase<StreamingCommitCursorRequest, StreamingCommitCursorResponse>
        {
        }

        /// <summary>
        /// Establishes a stream with the server for managing committed cursors.
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public virtual StreamingCommitCursorStream StreamingCommitCursor(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the committed cursor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CommitCursorResponse CommitCursor(CommitCursorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the committed cursor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CommitCursorResponse> CommitCursorAsync(CommitCursorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the committed cursor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CommitCursorResponse> CommitCursorAsync(CommitCursorRequest request, st::CancellationToken cancellationToken) =>
            CommitCursorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns all committed cursor information for a subscription.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PartitionCursor"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPartitionCursorsResponse, PartitionCursor> ListPartitionCursors(ListPartitionCursorsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns all committed cursor information for a subscription.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PartitionCursor"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPartitionCursorsResponse, PartitionCursor> ListPartitionCursorsAsync(ListPartitionCursorsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns all committed cursor information for a subscription.
        /// </summary>
        /// <param name="parent">
        /// Required. The subscription for which to retrieve cursors.
        /// Structured like
        /// `projects/{project_number}/locations/{location}/subscriptions/{subscription_id}`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PartitionCursor"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPartitionCursorsResponse, PartitionCursor> ListPartitionCursors(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListPartitionCursors(new ListPartitionCursorsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns all committed cursor information for a subscription.
        /// </summary>
        /// <param name="parent">
        /// Required. The subscription for which to retrieve cursors.
        /// Structured like
        /// `projects/{project_number}/locations/{location}/subscriptions/{subscription_id}`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PartitionCursor"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPartitionCursorsResponse, PartitionCursor> ListPartitionCursorsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListPartitionCursorsAsync(new ListPartitionCursorsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns all committed cursor information for a subscription.
        /// </summary>
        /// <param name="parent">
        /// Required. The subscription for which to retrieve cursors.
        /// Structured like
        /// `projects/{project_number}/locations/{location}/subscriptions/{subscription_id}`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PartitionCursor"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPartitionCursorsResponse, PartitionCursor> ListPartitionCursors(SubscriptionName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListPartitionCursors(new ListPartitionCursorsRequest
            {
                ParentAsSubscriptionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns all committed cursor information for a subscription.
        /// </summary>
        /// <param name="parent">
        /// Required. The subscription for which to retrieve cursors.
        /// Structured like
        /// `projects/{project_number}/locations/{location}/subscriptions/{subscription_id}`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PartitionCursor"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPartitionCursorsResponse, PartitionCursor> ListPartitionCursorsAsync(SubscriptionName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListPartitionCursorsAsync(new ListPartitionCursorsRequest
            {
                ParentAsSubscriptionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);
    }

    /// <summary>CursorService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The service that a subscriber client application uses to manage committed
    /// cursors while receiving messsages. A cursor represents a subscriber's
    /// progress within a topic partition for a given subscription.
    /// </remarks>
    public sealed partial class CursorServiceClientImpl : CursorServiceClient
    {
        private readonly gaxgrpc::ApiBidirectionalStreamingCall<StreamingCommitCursorRequest, StreamingCommitCursorResponse> _callStreamingCommitCursor;

        private readonly gaxgrpc::ApiCall<CommitCursorRequest, CommitCursorResponse> _callCommitCursor;

        private readonly gaxgrpc::ApiCall<ListPartitionCursorsRequest, ListPartitionCursorsResponse> _callListPartitionCursors;

        /// <summary>
        /// Constructs a client wrapper for the CursorService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CursorServiceSettings"/> used within this client.</param>
        public CursorServiceClientImpl(CursorService.CursorServiceClient grpcClient, CursorServiceSettings settings)
        {
            GrpcClient = grpcClient;
            CursorServiceSettings effectiveSettings = settings ?? CursorServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callStreamingCommitCursor = clientHelper.BuildApiCall<StreamingCommitCursorRequest, StreamingCommitCursorResponse>(grpcClient.StreamingCommitCursor, effectiveSettings.StreamingCommitCursorSettings, effectiveSettings.StreamingCommitCursorStreamingSettings);
            Modify_ApiCall(ref _callStreamingCommitCursor);
            Modify_StreamingCommitCursorApiCall(ref _callStreamingCommitCursor);
            _callCommitCursor = clientHelper.BuildApiCall<CommitCursorRequest, CommitCursorResponse>(grpcClient.CommitCursorAsync, grpcClient.CommitCursor, effectiveSettings.CommitCursorSettings);
            Modify_ApiCall(ref _callCommitCursor);
            Modify_CommitCursorApiCall(ref _callCommitCursor);
            _callListPartitionCursors = clientHelper.BuildApiCall<ListPartitionCursorsRequest, ListPartitionCursorsResponse>(grpcClient.ListPartitionCursorsAsync, grpcClient.ListPartitionCursors, effectiveSettings.ListPartitionCursorsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListPartitionCursors);
            Modify_ListPartitionCursorsApiCall(ref _callListPartitionCursors);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiBidirectionalStreamingCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_StreamingCommitCursorApiCall(ref gaxgrpc::ApiBidirectionalStreamingCall<StreamingCommitCursorRequest, StreamingCommitCursorResponse> call);

        partial void Modify_CommitCursorApiCall(ref gaxgrpc::ApiCall<CommitCursorRequest, CommitCursorResponse> call);

        partial void Modify_ListPartitionCursorsApiCall(ref gaxgrpc::ApiCall<ListPartitionCursorsRequest, ListPartitionCursorsResponse> call);

        partial void OnConstruction(CursorService.CursorServiceClient grpcClient, CursorServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CursorService client</summary>
        public override CursorService.CursorServiceClient GrpcClient { get; }

        partial void Modify_StreamingCommitCursorRequestCallSettings(ref gaxgrpc::CallSettings settings);

        partial void Modify_StreamingCommitCursorRequestRequest(ref StreamingCommitCursorRequest request);

        partial void Modify_CommitCursorRequest(ref CommitCursorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPartitionCursorsRequest(ref ListPartitionCursorsRequest request, ref gaxgrpc::CallSettings settings);

        internal sealed partial class StreamingCommitCursorStreamImpl : StreamingCommitCursorStream
        {
            /// <summary>Construct the bidirectional streaming method for <c>StreamingCommitCursor</c>.</summary>
            /// <param name="service">The service containing this streaming method.</param>
            /// <param name="call">The underlying gRPC duplex streaming call.</param>
            /// <param name="writeBuffer">
            /// The <see cref="gaxgrpc::BufferedClientStreamWriter{StreamingCommitCursorRequest}"/> instance associated
            /// with this streaming call.
            /// </param>
            public StreamingCommitCursorStreamImpl(CursorServiceClientImpl service, grpccore::AsyncDuplexStreamingCall<StreamingCommitCursorRequest, StreamingCommitCursorResponse> call, gaxgrpc::BufferedClientStreamWriter<StreamingCommitCursorRequest> writeBuffer)
            {
                _service = service;
                GrpcCall = call;
                _writeBuffer = writeBuffer;
            }

            private CursorServiceClientImpl _service;

            private gaxgrpc::BufferedClientStreamWriter<StreamingCommitCursorRequest> _writeBuffer;

            public override grpccore::AsyncDuplexStreamingCall<StreamingCommitCursorRequest, StreamingCommitCursorResponse> GrpcCall { get; }

            private StreamingCommitCursorRequest ModifyRequest(StreamingCommitCursorRequest request)
            {
                _service.Modify_StreamingCommitCursorRequestRequest(ref request);
                return request;
            }

            public override stt::Task TryWriteAsync(StreamingCommitCursorRequest message) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message));

            public override stt::Task WriteAsync(StreamingCommitCursorRequest message) =>
                _writeBuffer.WriteAsync(ModifyRequest(message));

            public override stt::Task TryWriteAsync(StreamingCommitCursorRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message), options);

            public override stt::Task WriteAsync(StreamingCommitCursorRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.WriteAsync(ModifyRequest(message), options);

            public override stt::Task TryWriteCompleteAsync() => _writeBuffer.TryWriteCompleteAsync();

            public override stt::Task WriteCompleteAsync() => _writeBuffer.WriteCompleteAsync();
        }

        /// <summary>
        /// Establishes a stream with the server for managing committed cursors.
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public override CursorServiceClient.StreamingCommitCursorStream StreamingCommitCursor(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null)
        {
            Modify_StreamingCommitCursorRequestCallSettings(ref callSettings);
            gaxgrpc::BidirectionalStreamingSettings effectiveStreamingSettings = streamingSettings ?? _callStreamingCommitCursor.StreamingSettings;
            grpccore::AsyncDuplexStreamingCall<StreamingCommitCursorRequest, StreamingCommitCursorResponse> call = _callStreamingCommitCursor.Call(callSettings);
            gaxgrpc::BufferedClientStreamWriter<StreamingCommitCursorRequest> writeBuffer = new gaxgrpc::BufferedClientStreamWriter<StreamingCommitCursorRequest>(call.RequestStream, effectiveStreamingSettings.BufferedClientWriterCapacity);
            return new StreamingCommitCursorStreamImpl(this, call, writeBuffer);
        }

        /// <summary>
        /// Updates the committed cursor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CommitCursorResponse CommitCursor(CommitCursorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CommitCursorRequest(ref request, ref callSettings);
            return _callCommitCursor.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the committed cursor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CommitCursorResponse> CommitCursorAsync(CommitCursorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CommitCursorRequest(ref request, ref callSettings);
            return _callCommitCursor.Async(request, callSettings);
        }

        /// <summary>
        /// Returns all committed cursor information for a subscription.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PartitionCursor"/> resources.</returns>
        public override gax::PagedEnumerable<ListPartitionCursorsResponse, PartitionCursor> ListPartitionCursors(ListPartitionCursorsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPartitionCursorsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListPartitionCursorsRequest, ListPartitionCursorsResponse, PartitionCursor>(_callListPartitionCursors, request, callSettings);
        }

        /// <summary>
        /// Returns all committed cursor information for a subscription.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PartitionCursor"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListPartitionCursorsResponse, PartitionCursor> ListPartitionCursorsAsync(ListPartitionCursorsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPartitionCursorsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListPartitionCursorsRequest, ListPartitionCursorsResponse, PartitionCursor>(_callListPartitionCursors, request, callSettings);
        }
    }

    public partial class ListPartitionCursorsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListPartitionCursorsResponse : gaxgrpc::IPageResponse<PartitionCursor>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<PartitionCursor> GetEnumerator() => PartitionCursors.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
