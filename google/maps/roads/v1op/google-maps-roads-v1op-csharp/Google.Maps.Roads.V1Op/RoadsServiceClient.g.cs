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

namespace Google.Maps.Roads.V1Op
{
    /// <summary>Settings for <see cref="RoadsServiceClient"/> instances.</summary>
    public sealed partial class RoadsServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="RoadsServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="RoadsServiceSettings"/>.</returns>
        public static RoadsServiceSettings GetDefault() => new RoadsServiceSettings();

        /// <summary>Constructs a new <see cref="RoadsServiceSettings"/> object with default settings.</summary>
        public RoadsServiceSettings()
        {
        }

        private RoadsServiceSettings(RoadsServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            SnapToRoadsSettings = existing.SnapToRoadsSettings;
            ListNearestRoadsSettings = existing.ListNearestRoadsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(RoadsServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RoadsServiceClient.SnapToRoads</c> and <c>RoadsServiceClient.SnapToRoadsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SnapToRoadsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RoadsServiceClient.ListNearestRoads</c> and <c>RoadsServiceClient.ListNearestRoadsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListNearestRoadsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="RoadsServiceSettings"/> object.</returns>
        public RoadsServiceSettings Clone() => new RoadsServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="RoadsServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class RoadsServiceClientBuilder : gaxgrpc::ClientBuilderBase<RoadsServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public RoadsServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public RoadsServiceClientBuilder()
        {
            UseJwtAccessWithScopes = RoadsServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref RoadsServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<RoadsServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override RoadsServiceClient Build()
        {
            RoadsServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<RoadsServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<RoadsServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private RoadsServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return RoadsServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<RoadsServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return RoadsServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => RoadsServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => RoadsServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => RoadsServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>RoadsService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// </remarks>
    public abstract partial class RoadsServiceClient
    {
        /// <summary>
        /// The default endpoint for the RoadsService service, which is a host of "roads.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "roads.googleapis.com:443";

        /// <summary>The default RoadsService scopes.</summary>
        /// <remarks>The default RoadsService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

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
        /// Asynchronously creates a <see cref="RoadsServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="RoadsServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="RoadsServiceClient"/>.</returns>
        public static stt::Task<RoadsServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new RoadsServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="RoadsServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="RoadsServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="RoadsServiceClient"/>.</returns>
        public static RoadsServiceClient Create() => new RoadsServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="RoadsServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="RoadsServiceSettings"/>.</param>
        /// <returns>The created <see cref="RoadsServiceClient"/>.</returns>
        internal static RoadsServiceClient Create(grpccore::CallInvoker callInvoker, RoadsServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            RoadsService.RoadsServiceClient grpcClient = new RoadsService.RoadsServiceClient(callInvoker);
            return new RoadsServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC RoadsService client</summary>
        public virtual RoadsService.RoadsServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// This method takes a sequence of latitude,longitude points and snaps them to
        /// the most likely road segments. Optionally returns additional points giving
        /// the full road geometry. Also returns a place ID for each snapped point.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SnapToRoadsResponse SnapToRoads(SnapToRoadsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// This method takes a sequence of latitude,longitude points and snaps them to
        /// the most likely road segments. Optionally returns additional points giving
        /// the full road geometry. Also returns a place ID for each snapped point.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SnapToRoadsResponse> SnapToRoadsAsync(SnapToRoadsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// This method takes a sequence of latitude,longitude points and snaps them to
        /// the most likely road segments. Optionally returns additional points giving
        /// the full road geometry. Also returns a place ID for each snapped point.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SnapToRoadsResponse> SnapToRoadsAsync(SnapToRoadsRequest request, st::CancellationToken cancellationToken) =>
            SnapToRoadsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// This method takes a sequence of latitude,longitude points and snaps them to
        /// the most likely road segments. Optionally returns additional points giving
        /// the full road geometry. Also returns a place ID for each snapped point.
        /// </summary>
        /// <param name="path">
        /// The path to be snapped as a series of lat, lng points. Specified as
        /// a string of the format: lat,lng|lat,lng|...
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SnapToRoadsResponse SnapToRoads(string path, gaxgrpc::CallSettings callSettings = null) =>
            SnapToRoads(new SnapToRoadsRequest { Path = path ?? "", }, callSettings);

        /// <summary>
        /// This method takes a sequence of latitude,longitude points and snaps them to
        /// the most likely road segments. Optionally returns additional points giving
        /// the full road geometry. Also returns a place ID for each snapped point.
        /// </summary>
        /// <param name="path">
        /// The path to be snapped as a series of lat, lng points. Specified as
        /// a string of the format: lat,lng|lat,lng|...
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SnapToRoadsResponse> SnapToRoadsAsync(string path, gaxgrpc::CallSettings callSettings = null) =>
            SnapToRoadsAsync(new SnapToRoadsRequest { Path = path ?? "", }, callSettings);

        /// <summary>
        /// This method takes a sequence of latitude,longitude points and snaps them to
        /// the most likely road segments. Optionally returns additional points giving
        /// the full road geometry. Also returns a place ID for each snapped point.
        /// </summary>
        /// <param name="path">
        /// The path to be snapped as a series of lat, lng points. Specified as
        /// a string of the format: lat,lng|lat,lng|...
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SnapToRoadsResponse> SnapToRoadsAsync(string path, st::CancellationToken cancellationToken) =>
            SnapToRoadsAsync(path, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// This method takes a list of latitude,longitude points and snaps them each
        /// to their nearest road. Also returns a place ID for each snapped point.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListNearestRoadsResponse ListNearestRoads(ListNearestRoadsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// This method takes a list of latitude,longitude points and snaps them each
        /// to their nearest road. Also returns a place ID for each snapped point.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListNearestRoadsResponse> ListNearestRoadsAsync(ListNearestRoadsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// This method takes a list of latitude,longitude points and snaps them each
        /// to their nearest road. Also returns a place ID for each snapped point.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListNearestRoadsResponse> ListNearestRoadsAsync(ListNearestRoadsRequest request, st::CancellationToken cancellationToken) =>
            ListNearestRoadsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// This method takes a list of latitude,longitude points and snaps them each
        /// to their nearest road. Also returns a place ID for each snapped point.
        /// </summary>
        /// <param name="points">
        /// The points to be snapped as a series of lat, lng points. Specified as
        /// a string of the format: lat,lng|lat,lng|...
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListNearestRoadsResponse ListNearestRoads(string points, gaxgrpc::CallSettings callSettings = null) =>
            ListNearestRoads(new ListNearestRoadsRequest { Points = points ?? "", }, callSettings);

        /// <summary>
        /// This method takes a list of latitude,longitude points and snaps them each
        /// to their nearest road. Also returns a place ID for each snapped point.
        /// </summary>
        /// <param name="points">
        /// The points to be snapped as a series of lat, lng points. Specified as
        /// a string of the format: lat,lng|lat,lng|...
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListNearestRoadsResponse> ListNearestRoadsAsync(string points, gaxgrpc::CallSettings callSettings = null) =>
            ListNearestRoadsAsync(new ListNearestRoadsRequest { Points = points ?? "", }, callSettings);

        /// <summary>
        /// This method takes a list of latitude,longitude points and snaps them each
        /// to their nearest road. Also returns a place ID for each snapped point.
        /// </summary>
        /// <param name="points">
        /// The points to be snapped as a series of lat, lng points. Specified as
        /// a string of the format: lat,lng|lat,lng|...
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListNearestRoadsResponse> ListNearestRoadsAsync(string points, st::CancellationToken cancellationToken) =>
            ListNearestRoadsAsync(points, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>RoadsService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// </remarks>
    public sealed partial class RoadsServiceClientImpl : RoadsServiceClient
    {
        private readonly gaxgrpc::ApiCall<SnapToRoadsRequest, SnapToRoadsResponse> _callSnapToRoads;

        private readonly gaxgrpc::ApiCall<ListNearestRoadsRequest, ListNearestRoadsResponse> _callListNearestRoads;

        /// <summary>
        /// Constructs a client wrapper for the RoadsService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="RoadsServiceSettings"/> used within this client.</param>
        public RoadsServiceClientImpl(RoadsService.RoadsServiceClient grpcClient, RoadsServiceSettings settings)
        {
            GrpcClient = grpcClient;
            RoadsServiceSettings effectiveSettings = settings ?? RoadsServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callSnapToRoads = clientHelper.BuildApiCall<SnapToRoadsRequest, SnapToRoadsResponse>(grpcClient.SnapToRoadsAsync, grpcClient.SnapToRoads, effectiveSettings.SnapToRoadsSettings);
            Modify_ApiCall(ref _callSnapToRoads);
            Modify_SnapToRoadsApiCall(ref _callSnapToRoads);
            _callListNearestRoads = clientHelper.BuildApiCall<ListNearestRoadsRequest, ListNearestRoadsResponse>(grpcClient.ListNearestRoadsAsync, grpcClient.ListNearestRoads, effectiveSettings.ListNearestRoadsSettings);
            Modify_ApiCall(ref _callListNearestRoads);
            Modify_ListNearestRoadsApiCall(ref _callListNearestRoads);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_SnapToRoadsApiCall(ref gaxgrpc::ApiCall<SnapToRoadsRequest, SnapToRoadsResponse> call);

        partial void Modify_ListNearestRoadsApiCall(ref gaxgrpc::ApiCall<ListNearestRoadsRequest, ListNearestRoadsResponse> call);

        partial void OnConstruction(RoadsService.RoadsServiceClient grpcClient, RoadsServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC RoadsService client</summary>
        public override RoadsService.RoadsServiceClient GrpcClient { get; }

        partial void Modify_SnapToRoadsRequest(ref SnapToRoadsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListNearestRoadsRequest(ref ListNearestRoadsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// This method takes a sequence of latitude,longitude points and snaps them to
        /// the most likely road segments. Optionally returns additional points giving
        /// the full road geometry. Also returns a place ID for each snapped point.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SnapToRoadsResponse SnapToRoads(SnapToRoadsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SnapToRoadsRequest(ref request, ref callSettings);
            return _callSnapToRoads.Sync(request, callSettings);
        }

        /// <summary>
        /// This method takes a sequence of latitude,longitude points and snaps them to
        /// the most likely road segments. Optionally returns additional points giving
        /// the full road geometry. Also returns a place ID for each snapped point.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SnapToRoadsResponse> SnapToRoadsAsync(SnapToRoadsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SnapToRoadsRequest(ref request, ref callSettings);
            return _callSnapToRoads.Async(request, callSettings);
        }

        /// <summary>
        /// This method takes a list of latitude,longitude points and snaps them each
        /// to their nearest road. Also returns a place ID for each snapped point.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ListNearestRoadsResponse ListNearestRoads(ListNearestRoadsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNearestRoadsRequest(ref request, ref callSettings);
            return _callListNearestRoads.Sync(request, callSettings);
        }

        /// <summary>
        /// This method takes a list of latitude,longitude points and snaps them each
        /// to their nearest road. Also returns a place ID for each snapped point.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ListNearestRoadsResponse> ListNearestRoadsAsync(ListNearestRoadsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNearestRoadsRequest(ref request, ref callSettings);
            return _callListNearestRoads.Async(request, callSettings);
        }
    }
}
