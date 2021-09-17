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

namespace Google.Maps.PlayableLocations.V3
{
    /// <summary>Settings for <see cref="PlayableLocationsClient"/> instances.</summary>
    public sealed partial class PlayableLocationsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="PlayableLocationsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="PlayableLocationsSettings"/>.</returns>
        public static PlayableLocationsSettings GetDefault() => new PlayableLocationsSettings();

        /// <summary>Constructs a new <see cref="PlayableLocationsSettings"/> object with default settings.</summary>
        public PlayableLocationsSettings()
        {
        }

        private PlayableLocationsSettings(PlayableLocationsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            SamplePlayableLocationsSettings = existing.SamplePlayableLocationsSettings;
            LogPlayerReportsSettings = existing.LogPlayerReportsSettings;
            LogImpressionsSettings = existing.LogImpressionsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(PlayableLocationsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PlayableLocationsClient.SamplePlayableLocations</c> and
        /// <c>PlayableLocationsClient.SamplePlayableLocationsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SamplePlayableLocationsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PlayableLocationsClient.LogPlayerReports</c> and <c>PlayableLocationsClient.LogPlayerReportsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings LogPlayerReportsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PlayableLocationsClient.LogImpressions</c> and <c>PlayableLocationsClient.LogImpressionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings LogImpressionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="PlayableLocationsSettings"/> object.</returns>
        public PlayableLocationsSettings Clone() => new PlayableLocationsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="PlayableLocationsClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class PlayableLocationsClientBuilder : gaxgrpc::ClientBuilderBase<PlayableLocationsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public PlayableLocationsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public PlayableLocationsClientBuilder()
        {
            UseJwtAccessWithScopes = PlayableLocationsClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref PlayableLocationsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<PlayableLocationsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override PlayableLocationsClient Build()
        {
            PlayableLocationsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<PlayableLocationsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<PlayableLocationsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private PlayableLocationsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return PlayableLocationsClient.Create(callInvoker, Settings);
        }

        private async stt::Task<PlayableLocationsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return PlayableLocationsClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => PlayableLocationsClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => PlayableLocationsClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => PlayableLocationsClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>PlayableLocations client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The Playable Locations API for v3.
    /// </remarks>
    public abstract partial class PlayableLocationsClient
    {
        /// <summary>
        /// The default endpoint for the PlayableLocations service, which is a host of
        /// "playablelocations.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "playablelocations.googleapis.com:443";

        /// <summary>The default PlayableLocations scopes.</summary>
        /// <remarks>The default PlayableLocations scopes are:<list type="bullet"></list></remarks>
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
        /// Asynchronously creates a <see cref="PlayableLocationsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="PlayableLocationsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="PlayableLocationsClient"/>.</returns>
        public static stt::Task<PlayableLocationsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new PlayableLocationsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="PlayableLocationsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="PlayableLocationsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="PlayableLocationsClient"/>.</returns>
        public static PlayableLocationsClient Create() => new PlayableLocationsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="PlayableLocationsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="PlayableLocationsSettings"/>.</param>
        /// <returns>The created <see cref="PlayableLocationsClient"/>.</returns>
        internal static PlayableLocationsClient Create(grpccore::CallInvoker callInvoker, PlayableLocationsSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            PlayableLocations.PlayableLocationsClient grpcClient = new PlayableLocations.PlayableLocationsClient(callInvoker);
            return new PlayableLocationsClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC PlayableLocations client</summary>
        public virtual PlayableLocations.PlayableLocationsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a set of playable locations that lie within a specified area,
        /// that satisfy optional filter criteria.
        /// 
        /// Note: Identical `SamplePlayableLocations` requests can return different
        /// results as the state of the world changes over time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SamplePlayableLocationsResponse SamplePlayableLocations(SamplePlayableLocationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a set of playable locations that lie within a specified area,
        /// that satisfy optional filter criteria.
        /// 
        /// Note: Identical `SamplePlayableLocations` requests can return different
        /// results as the state of the world changes over time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SamplePlayableLocationsResponse> SamplePlayableLocationsAsync(SamplePlayableLocationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a set of playable locations that lie within a specified area,
        /// that satisfy optional filter criteria.
        /// 
        /// Note: Identical `SamplePlayableLocations` requests can return different
        /// results as the state of the world changes over time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SamplePlayableLocationsResponse> SamplePlayableLocationsAsync(SamplePlayableLocationsRequest request, st::CancellationToken cancellationToken) =>
            SamplePlayableLocationsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Logs bad playable location reports submitted by players.
        /// 
        /// Reports are not partially saved; either all reports are saved and this
        /// request succeeds, or no reports are saved, and this request fails.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogPlayerReportsResponse LogPlayerReports(LogPlayerReportsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Logs bad playable location reports submitted by players.
        /// 
        /// Reports are not partially saved; either all reports are saved and this
        /// request succeeds, or no reports are saved, and this request fails.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogPlayerReportsResponse> LogPlayerReportsAsync(LogPlayerReportsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Logs bad playable location reports submitted by players.
        /// 
        /// Reports are not partially saved; either all reports are saved and this
        /// request succeeds, or no reports are saved, and this request fails.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogPlayerReportsResponse> LogPlayerReportsAsync(LogPlayerReportsRequest request, st::CancellationToken cancellationToken) =>
            LogPlayerReportsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Logs new events when playable locations are displayed, and when they are
        /// interacted with.
        /// 
        /// Impressions are not partially saved; either all impressions are saved and
        /// this request succeeds, or no impressions are saved, and this request fails.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogImpressionsResponse LogImpressions(LogImpressionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Logs new events when playable locations are displayed, and when they are
        /// interacted with.
        /// 
        /// Impressions are not partially saved; either all impressions are saved and
        /// this request succeeds, or no impressions are saved, and this request fails.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogImpressionsResponse> LogImpressionsAsync(LogImpressionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Logs new events when playable locations are displayed, and when they are
        /// interacted with.
        /// 
        /// Impressions are not partially saved; either all impressions are saved and
        /// this request succeeds, or no impressions are saved, and this request fails.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LogImpressionsResponse> LogImpressionsAsync(LogImpressionsRequest request, st::CancellationToken cancellationToken) =>
            LogImpressionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>PlayableLocations client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The Playable Locations API for v3.
    /// </remarks>
    public sealed partial class PlayableLocationsClientImpl : PlayableLocationsClient
    {
        private readonly gaxgrpc::ApiCall<SamplePlayableLocationsRequest, SamplePlayableLocationsResponse> _callSamplePlayableLocations;

        private readonly gaxgrpc::ApiCall<LogPlayerReportsRequest, LogPlayerReportsResponse> _callLogPlayerReports;

        private readonly gaxgrpc::ApiCall<LogImpressionsRequest, LogImpressionsResponse> _callLogImpressions;

        /// <summary>
        /// Constructs a client wrapper for the PlayableLocations service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="PlayableLocationsSettings"/> used within this client.</param>
        public PlayableLocationsClientImpl(PlayableLocations.PlayableLocationsClient grpcClient, PlayableLocationsSettings settings)
        {
            GrpcClient = grpcClient;
            PlayableLocationsSettings effectiveSettings = settings ?? PlayableLocationsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callSamplePlayableLocations = clientHelper.BuildApiCall<SamplePlayableLocationsRequest, SamplePlayableLocationsResponse>(grpcClient.SamplePlayableLocationsAsync, grpcClient.SamplePlayableLocations, effectiveSettings.SamplePlayableLocationsSettings);
            Modify_ApiCall(ref _callSamplePlayableLocations);
            Modify_SamplePlayableLocationsApiCall(ref _callSamplePlayableLocations);
            _callLogPlayerReports = clientHelper.BuildApiCall<LogPlayerReportsRequest, LogPlayerReportsResponse>(grpcClient.LogPlayerReportsAsync, grpcClient.LogPlayerReports, effectiveSettings.LogPlayerReportsSettings);
            Modify_ApiCall(ref _callLogPlayerReports);
            Modify_LogPlayerReportsApiCall(ref _callLogPlayerReports);
            _callLogImpressions = clientHelper.BuildApiCall<LogImpressionsRequest, LogImpressionsResponse>(grpcClient.LogImpressionsAsync, grpcClient.LogImpressions, effectiveSettings.LogImpressionsSettings);
            Modify_ApiCall(ref _callLogImpressions);
            Modify_LogImpressionsApiCall(ref _callLogImpressions);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_SamplePlayableLocationsApiCall(ref gaxgrpc::ApiCall<SamplePlayableLocationsRequest, SamplePlayableLocationsResponse> call);

        partial void Modify_LogPlayerReportsApiCall(ref gaxgrpc::ApiCall<LogPlayerReportsRequest, LogPlayerReportsResponse> call);

        partial void Modify_LogImpressionsApiCall(ref gaxgrpc::ApiCall<LogImpressionsRequest, LogImpressionsResponse> call);

        partial void OnConstruction(PlayableLocations.PlayableLocationsClient grpcClient, PlayableLocationsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC PlayableLocations client</summary>
        public override PlayableLocations.PlayableLocationsClient GrpcClient { get; }

        partial void Modify_SamplePlayableLocationsRequest(ref SamplePlayableLocationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_LogPlayerReportsRequest(ref LogPlayerReportsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_LogImpressionsRequest(ref LogImpressionsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns a set of playable locations that lie within a specified area,
        /// that satisfy optional filter criteria.
        /// 
        /// Note: Identical `SamplePlayableLocations` requests can return different
        /// results as the state of the world changes over time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SamplePlayableLocationsResponse SamplePlayableLocations(SamplePlayableLocationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SamplePlayableLocationsRequest(ref request, ref callSettings);
            return _callSamplePlayableLocations.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns a set of playable locations that lie within a specified area,
        /// that satisfy optional filter criteria.
        /// 
        /// Note: Identical `SamplePlayableLocations` requests can return different
        /// results as the state of the world changes over time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SamplePlayableLocationsResponse> SamplePlayableLocationsAsync(SamplePlayableLocationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SamplePlayableLocationsRequest(ref request, ref callSettings);
            return _callSamplePlayableLocations.Async(request, callSettings);
        }

        /// <summary>
        /// Logs bad playable location reports submitted by players.
        /// 
        /// Reports are not partially saved; either all reports are saved and this
        /// request succeeds, or no reports are saved, and this request fails.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LogPlayerReportsResponse LogPlayerReports(LogPlayerReportsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LogPlayerReportsRequest(ref request, ref callSettings);
            return _callLogPlayerReports.Sync(request, callSettings);
        }

        /// <summary>
        /// Logs bad playable location reports submitted by players.
        /// 
        /// Reports are not partially saved; either all reports are saved and this
        /// request succeeds, or no reports are saved, and this request fails.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LogPlayerReportsResponse> LogPlayerReportsAsync(LogPlayerReportsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LogPlayerReportsRequest(ref request, ref callSettings);
            return _callLogPlayerReports.Async(request, callSettings);
        }

        /// <summary>
        /// Logs new events when playable locations are displayed, and when they are
        /// interacted with.
        /// 
        /// Impressions are not partially saved; either all impressions are saved and
        /// this request succeeds, or no impressions are saved, and this request fails.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LogImpressionsResponse LogImpressions(LogImpressionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LogImpressionsRequest(ref request, ref callSettings);
            return _callLogImpressions.Sync(request, callSettings);
        }

        /// <summary>
        /// Logs new events when playable locations are displayed, and when they are
        /// interacted with.
        /// 
        /// Impressions are not partially saved; either all impressions are saved and
        /// this request succeeds, or no impressions are saved, and this request fails.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LogImpressionsResponse> LogImpressionsAsync(LogImpressionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LogImpressionsRequest(ref request, ref callSettings);
            return _callLogImpressions.Async(request, callSettings);
        }
    }
}
