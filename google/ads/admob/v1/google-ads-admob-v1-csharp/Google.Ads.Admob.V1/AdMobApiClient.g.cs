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

namespace Google.Ads.Admob.V1
{
    /// <summary>Settings for <see cref="AdMobApiClient"/> instances.</summary>
    public sealed partial class AdMobApiSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AdMobApiSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AdMobApiSettings"/>.</returns>
        public static AdMobApiSettings GetDefault() => new AdMobApiSettings();

        /// <summary>Constructs a new <see cref="AdMobApiSettings"/> object with default settings.</summary>
        public AdMobApiSettings()
        {
        }

        private AdMobApiSettings(AdMobApiSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetPublisherAccountSettings = existing.GetPublisherAccountSettings;
            ListPublisherAccountsSettings = existing.ListPublisherAccountsSettings;
            GenerateNetworkReportSettings = existing.GenerateNetworkReportSettings;
            GenerateMediationReportSettings = existing.GenerateMediationReportSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AdMobApiSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdMobApiClient.GetPublisherAccount</c> and <c>AdMobApiClient.GetPublisherAccountAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetPublisherAccountSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdMobApiClient.ListPublisherAccounts</c> and <c>AdMobApiClient.ListPublisherAccountsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListPublisherAccountsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdMobApiClient.GenerateNetworkReport</c> and <c>AdMobApiClient.GenerateNetworkReportAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GenerateNetworkReportSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdMobApiClient.GenerateMediationReport</c> and <c>AdMobApiClient.GenerateMediationReportAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GenerateMediationReportSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AdMobApiSettings"/> object.</returns>
        public AdMobApiSettings Clone() => new AdMobApiSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AdMobApiClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class AdMobApiClientBuilder : gaxgrpc::ClientBuilderBase<AdMobApiClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AdMobApiSettings Settings { get; set; }

        partial void InterceptBuild(ref AdMobApiClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AdMobApiClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AdMobApiClient Build()
        {
            AdMobApiClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AdMobApiClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AdMobApiClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AdMobApiClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AdMobApiClient.Create(callInvoker, Settings);
        }

        private async stt::Task<AdMobApiClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AdMobApiClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => AdMobApiClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => AdMobApiClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AdMobApiClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>AdMobApi client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The AdMob API allows AdMob publishers programmatically get information about
    /// their AdMob account.
    /// </remarks>
    public abstract partial class AdMobApiClient
    {
        /// <summary>
        /// The default endpoint for the AdMobApi service, which is a host of "admob.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admob.googleapis.com:443";

        /// <summary>The default AdMobApi scopes.</summary>
        /// <remarks>
        /// The default AdMobApi scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/admob.report</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/admob.report",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="AdMobApiClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="AdMobApiClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AdMobApiClient"/>.</returns>
        public static stt::Task<AdMobApiClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AdMobApiClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AdMobApiClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="AdMobApiClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AdMobApiClient"/>.</returns>
        public static AdMobApiClient Create() => new AdMobApiClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AdMobApiClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AdMobApiSettings"/>.</param>
        /// <returns>The created <see cref="AdMobApiClient"/>.</returns>
        internal static AdMobApiClient Create(grpccore::CallInvoker callInvoker, AdMobApiSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AdMobApi.AdMobApiClient grpcClient = new AdMobApi.AdMobApiClient(callInvoker);
            return new AdMobApiClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC AdMobApi client</summary>
        public virtual AdMobApi.AdMobApiClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about the specified AdMob publisher account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PublisherAccount GetPublisherAccount(GetPublisherAccountRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about the specified AdMob publisher account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PublisherAccount> GetPublisherAccountAsync(GetPublisherAccountRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about the specified AdMob publisher account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PublisherAccount> GetPublisherAccountAsync(GetPublisherAccountRequest request, st::CancellationToken cancellationToken) =>
            GetPublisherAccountAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about the specified AdMob publisher account.
        /// </summary>
        /// <param name="name">
        /// Resource name of the publisher account to retrieve.
        /// Example: accounts/pub-9876543210987654
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PublisherAccount GetPublisherAccount(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPublisherAccount(new GetPublisherAccountRequest { Name = name ?? "", }, callSettings);

        /// <summary>
        /// Gets information about the specified AdMob publisher account.
        /// </summary>
        /// <param name="name">
        /// Resource name of the publisher account to retrieve.
        /// Example: accounts/pub-9876543210987654
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PublisherAccount> GetPublisherAccountAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPublisherAccountAsync(new GetPublisherAccountRequest { Name = name ?? "", }, callSettings);

        /// <summary>
        /// Gets information about the specified AdMob publisher account.
        /// </summary>
        /// <param name="name">
        /// Resource name of the publisher account to retrieve.
        /// Example: accounts/pub-9876543210987654
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PublisherAccount> GetPublisherAccountAsync(string name, st::CancellationToken cancellationToken) =>
            GetPublisherAccountAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the AdMob publisher account accessible with the client credential.
        /// Currently, all credentials have access to at most one AdMob account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PublisherAccount"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPublisherAccountsResponse, PublisherAccount> ListPublisherAccounts(ListPublisherAccountsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the AdMob publisher account accessible with the client credential.
        /// Currently, all credentials have access to at most one AdMob account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PublisherAccount"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPublisherAccountsResponse, PublisherAccount> ListPublisherAccountsAsync(ListPublisherAccountsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Server streaming methods for
        /// <see cref="GenerateNetworkReport(GenerateNetworkReportRequest,gaxgrpc::CallSettings)"/>.
        /// </summary>
        public abstract partial class GenerateNetworkReportStream : gaxgrpc::ServerStreamingBase<GenerateNetworkReportResponse>
        {
        }

        /// <summary>
        /// Generates an AdMob Network report based on the provided report
        /// specification.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual GenerateNetworkReportStream GenerateNetworkReport(GenerateNetworkReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Server streaming methods for
        /// <see cref="GenerateMediationReport(GenerateMediationReportRequest,gaxgrpc::CallSettings)"/>.
        /// </summary>
        public abstract partial class GenerateMediationReportStream : gaxgrpc::ServerStreamingBase<GenerateMediationReportResponse>
        {
        }

        /// <summary>
        /// Generates an AdMob Mediation report based on the provided report
        /// specification.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual GenerateMediationReportStream GenerateMediationReport(GenerateMediationReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();
    }

    /// <summary>AdMobApi client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The AdMob API allows AdMob publishers programmatically get information about
    /// their AdMob account.
    /// </remarks>
    public sealed partial class AdMobApiClientImpl : AdMobApiClient
    {
        private readonly gaxgrpc::ApiCall<GetPublisherAccountRequest, PublisherAccount> _callGetPublisherAccount;

        private readonly gaxgrpc::ApiCall<ListPublisherAccountsRequest, ListPublisherAccountsResponse> _callListPublisherAccounts;

        private readonly gaxgrpc::ApiServerStreamingCall<GenerateNetworkReportRequest, GenerateNetworkReportResponse> _callGenerateNetworkReport;

        private readonly gaxgrpc::ApiServerStreamingCall<GenerateMediationReportRequest, GenerateMediationReportResponse> _callGenerateMediationReport;

        /// <summary>
        /// Constructs a client wrapper for the AdMobApi service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AdMobApiSettings"/> used within this client.</param>
        public AdMobApiClientImpl(AdMobApi.AdMobApiClient grpcClient, AdMobApiSettings settings)
        {
            GrpcClient = grpcClient;
            AdMobApiSettings effectiveSettings = settings ?? AdMobApiSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetPublisherAccount = clientHelper.BuildApiCall<GetPublisherAccountRequest, PublisherAccount>(grpcClient.GetPublisherAccountAsync, grpcClient.GetPublisherAccount, effectiveSettings.GetPublisherAccountSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetPublisherAccount);
            Modify_GetPublisherAccountApiCall(ref _callGetPublisherAccount);
            _callListPublisherAccounts = clientHelper.BuildApiCall<ListPublisherAccountsRequest, ListPublisherAccountsResponse>(grpcClient.ListPublisherAccountsAsync, grpcClient.ListPublisherAccounts, effectiveSettings.ListPublisherAccountsSettings);
            Modify_ApiCall(ref _callListPublisherAccounts);
            Modify_ListPublisherAccountsApiCall(ref _callListPublisherAccounts);
            _callGenerateNetworkReport = clientHelper.BuildApiCall<GenerateNetworkReportRequest, GenerateNetworkReportResponse>(grpcClient.GenerateNetworkReport, effectiveSettings.GenerateNetworkReportSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callGenerateNetworkReport);
            Modify_GenerateNetworkReportApiCall(ref _callGenerateNetworkReport);
            _callGenerateMediationReport = clientHelper.BuildApiCall<GenerateMediationReportRequest, GenerateMediationReportResponse>(grpcClient.GenerateMediationReport, effectiveSettings.GenerateMediationReportSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callGenerateMediationReport);
            Modify_GenerateMediationReportApiCall(ref _callGenerateMediationReport);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiServerStreamingCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetPublisherAccountApiCall(ref gaxgrpc::ApiCall<GetPublisherAccountRequest, PublisherAccount> call);

        partial void Modify_ListPublisherAccountsApiCall(ref gaxgrpc::ApiCall<ListPublisherAccountsRequest, ListPublisherAccountsResponse> call);

        partial void Modify_GenerateNetworkReportApiCall(ref gaxgrpc::ApiServerStreamingCall<GenerateNetworkReportRequest, GenerateNetworkReportResponse> call);

        partial void Modify_GenerateMediationReportApiCall(ref gaxgrpc::ApiServerStreamingCall<GenerateMediationReportRequest, GenerateMediationReportResponse> call);

        partial void OnConstruction(AdMobApi.AdMobApiClient grpcClient, AdMobApiSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AdMobApi client</summary>
        public override AdMobApi.AdMobApiClient GrpcClient { get; }

        partial void Modify_GetPublisherAccountRequest(ref GetPublisherAccountRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPublisherAccountsRequest(ref ListPublisherAccountsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateNetworkReportRequest(ref GenerateNetworkReportRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateMediationReportRequest(ref GenerateMediationReportRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Gets information about the specified AdMob publisher account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PublisherAccount GetPublisherAccount(GetPublisherAccountRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPublisherAccountRequest(ref request, ref callSettings);
            return _callGetPublisherAccount.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets information about the specified AdMob publisher account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PublisherAccount> GetPublisherAccountAsync(GetPublisherAccountRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPublisherAccountRequest(ref request, ref callSettings);
            return _callGetPublisherAccount.Async(request, callSettings);
        }

        /// <summary>
        /// Lists the AdMob publisher account accessible with the client credential.
        /// Currently, all credentials have access to at most one AdMob account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PublisherAccount"/> resources.</returns>
        public override gax::PagedEnumerable<ListPublisherAccountsResponse, PublisherAccount> ListPublisherAccounts(ListPublisherAccountsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPublisherAccountsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListPublisherAccountsRequest, ListPublisherAccountsResponse, PublisherAccount>(_callListPublisherAccounts, request, callSettings);
        }

        /// <summary>
        /// Lists the AdMob publisher account accessible with the client credential.
        /// Currently, all credentials have access to at most one AdMob account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PublisherAccount"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListPublisherAccountsResponse, PublisherAccount> ListPublisherAccountsAsync(ListPublisherAccountsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPublisherAccountsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListPublisherAccountsRequest, ListPublisherAccountsResponse, PublisherAccount>(_callListPublisherAccounts, request, callSettings);
        }

        internal sealed partial class GenerateNetworkReportStreamImpl : GenerateNetworkReportStream
        {
            /// <summary>Construct the server streaming method for <c>GenerateNetworkReport</c>.</summary>
            /// <param name="call">The underlying gRPC server streaming call.</param>
            public GenerateNetworkReportStreamImpl(grpccore::AsyncServerStreamingCall<GenerateNetworkReportResponse> call) => GrpcCall = call;

            public override grpccore::AsyncServerStreamingCall<GenerateNetworkReportResponse> GrpcCall { get; }
        }

        /// <summary>
        /// Generates an AdMob Network report based on the provided report
        /// specification.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public override AdMobApiClient.GenerateNetworkReportStream GenerateNetworkReport(GenerateNetworkReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateNetworkReportRequest(ref request, ref callSettings);
            return new GenerateNetworkReportStreamImpl(_callGenerateNetworkReport.Call(request, callSettings));
        }

        internal sealed partial class GenerateMediationReportStreamImpl : GenerateMediationReportStream
        {
            /// <summary>Construct the server streaming method for <c>GenerateMediationReport</c>.</summary>
            /// <param name="call">The underlying gRPC server streaming call.</param>
            public GenerateMediationReportStreamImpl(grpccore::AsyncServerStreamingCall<GenerateMediationReportResponse> call) => GrpcCall = call;

            public override grpccore::AsyncServerStreamingCall<GenerateMediationReportResponse> GrpcCall { get; }
        }

        /// <summary>
        /// Generates an AdMob Mediation report based on the provided report
        /// specification.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public override AdMobApiClient.GenerateMediationReportStream GenerateMediationReport(GenerateMediationReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateMediationReportRequest(ref request, ref callSettings);
            return new GenerateMediationReportStreamImpl(_callGenerateMediationReport.Call(request, callSettings));
        }
    }

    public partial class ListPublisherAccountsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListPublisherAccountsResponse : gaxgrpc::IPageResponse<PublisherAccount>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<PublisherAccount> GetEnumerator() => Account.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
