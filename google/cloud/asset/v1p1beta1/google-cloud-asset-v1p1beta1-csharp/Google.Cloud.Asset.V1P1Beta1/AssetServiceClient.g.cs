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
using linq = System.Linq;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Asset.V1P1Beta1
{
    /// <summary>Settings for <see cref="AssetServiceClient"/> instances.</summary>
    public sealed partial class AssetServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AssetServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AssetServiceSettings"/>.</returns>
        public static AssetServiceSettings GetDefault() => new AssetServiceSettings();

        /// <summary>Constructs a new <see cref="AssetServiceSettings"/> object with default settings.</summary>
        public AssetServiceSettings()
        {
        }

        private AssetServiceSettings(AssetServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            SearchAllResourcesSettings = existing.SearchAllResourcesSettings;
            SearchAllIamPoliciesSettings = existing.SearchAllIamPoliciesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AssetServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AssetServiceClient.SearchAllResources</c> and <c>AssetServiceClient.SearchAllResourcesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 15 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SearchAllResourcesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(15000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AssetServiceClient.SearchAllIamPolicies</c> and <c>AssetServiceClient.SearchAllIamPoliciesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 15 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SearchAllIamPoliciesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(15000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AssetServiceSettings"/> object.</returns>
        public AssetServiceSettings Clone() => new AssetServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AssetServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class AssetServiceClientBuilder : gaxgrpc::ClientBuilderBase<AssetServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AssetServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AssetServiceClientBuilder()
        {
            UseJwtAccessWithScopes = AssetServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref AssetServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AssetServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AssetServiceClient Build()
        {
            AssetServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AssetServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AssetServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AssetServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AssetServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<AssetServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AssetServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => AssetServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => AssetServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AssetServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>AssetService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Asset service definition.
    /// </remarks>
    public abstract partial class AssetServiceClient
    {
        /// <summary>
        /// The default endpoint for the AssetService service, which is a host of "cloudasset.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "cloudasset.googleapis.com:443";

        /// <summary>The default AssetService scopes.</summary>
        /// <remarks>
        /// The default AssetService scopes are:
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
        /// Asynchronously creates a <see cref="AssetServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AssetServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AssetServiceClient"/>.</returns>
        public static stt::Task<AssetServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AssetServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AssetServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AssetServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AssetServiceClient"/>.</returns>
        public static AssetServiceClient Create() => new AssetServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AssetServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AssetServiceSettings"/>.</param>
        /// <returns>The created <see cref="AssetServiceClient"/>.</returns>
        internal static AssetServiceClient Create(grpccore::CallInvoker callInvoker, AssetServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AssetService.AssetServiceClient grpcClient = new AssetService.AssetServiceClient(callInvoker);
            return new AssetServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC AssetService client</summary>
        public virtual AssetService.AssetServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Searches all the resources under a given accessible CRM scope
        /// (project/folder/organization). This RPC gives callers
        /// especially admins the ability to search all the resources under a scope,
        /// even if they don't have .get permission of all the resources. Callers
        /// should have cloud.assets.SearchAllResources permission on the requested
        /// scope, otherwise it will be rejected.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="StandardResourceMetadata"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchAllResourcesResponse, StandardResourceMetadata> SearchAllResources(SearchAllResourcesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Searches all the resources under a given accessible CRM scope
        /// (project/folder/organization). This RPC gives callers
        /// especially admins the ability to search all the resources under a scope,
        /// even if they don't have .get permission of all the resources. Callers
        /// should have cloud.assets.SearchAllResources permission on the requested
        /// scope, otherwise it will be rejected.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="StandardResourceMetadata"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchAllResourcesResponse, StandardResourceMetadata> SearchAllResourcesAsync(SearchAllResourcesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Searches all the resources under a given accessible CRM scope
        /// (project/folder/organization). This RPC gives callers
        /// especially admins the ability to search all the resources under a scope,
        /// even if they don't have .get permission of all the resources. Callers
        /// should have cloud.assets.SearchAllResources permission on the requested
        /// scope, otherwise it will be rejected.
        /// </summary>
        /// <param name="scope">
        /// Required. The relative name of an asset. The search is limited to the resources
        /// within the `scope`. The allowed value must be:
        /// * Organization number (such as "organizations/123")
        /// * Folder number(such as "folders/1234")
        /// * Project number (such as "projects/12345")
        /// * Project id (such as "projects/abc")
        /// </param>
        /// <param name="query">
        /// Optional. The query statement.
        /// </param>
        /// <param name="assetTypes">
        /// Optional. A list of asset types that this request searches for. If empty, it will
        /// search all the supported asset types.
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
        /// <returns>A pageable sequence of <see cref="StandardResourceMetadata"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchAllResourcesResponse, StandardResourceMetadata> SearchAllResources(string scope, string query, scg::IEnumerable<string> assetTypes, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            SearchAllResources(new SearchAllResourcesRequest
            {
                Scope = gax::GaxPreconditions.CheckNotNullOrEmpty(scope, nameof(scope)),
                Query = query ?? "",
                AssetTypes =
                {
                    assetTypes ?? linq::Enumerable.Empty<string>(),
                },
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Searches all the resources under a given accessible CRM scope
        /// (project/folder/organization). This RPC gives callers
        /// especially admins the ability to search all the resources under a scope,
        /// even if they don't have .get permission of all the resources. Callers
        /// should have cloud.assets.SearchAllResources permission on the requested
        /// scope, otherwise it will be rejected.
        /// </summary>
        /// <param name="scope">
        /// Required. The relative name of an asset. The search is limited to the resources
        /// within the `scope`. The allowed value must be:
        /// * Organization number (such as "organizations/123")
        /// * Folder number(such as "folders/1234")
        /// * Project number (such as "projects/12345")
        /// * Project id (such as "projects/abc")
        /// </param>
        /// <param name="query">
        /// Optional. The query statement.
        /// </param>
        /// <param name="assetTypes">
        /// Optional. A list of asset types that this request searches for. If empty, it will
        /// search all the supported asset types.
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
        /// <returns>A pageable asynchronous sequence of <see cref="StandardResourceMetadata"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchAllResourcesResponse, StandardResourceMetadata> SearchAllResourcesAsync(string scope, string query, scg::IEnumerable<string> assetTypes, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            SearchAllResourcesAsync(new SearchAllResourcesRequest
            {
                Scope = gax::GaxPreconditions.CheckNotNullOrEmpty(scope, nameof(scope)),
                Query = query ?? "",
                AssetTypes =
                {
                    assetTypes ?? linq::Enumerable.Empty<string>(),
                },
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Searches all the IAM policies under a given accessible CRM scope
        /// (project/folder/organization). This RPC gives callers
        /// especially admins the ability to search all the IAM policies under a scope,
        /// even if they don't have .getIamPolicy permission of all the IAM policies.
        /// Callers should have cloud.assets.SearchAllIamPolicies permission on the
        /// requested scope, otherwise it will be rejected.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="IamPolicySearchResult"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchAllIamPoliciesResponse, IamPolicySearchResult> SearchAllIamPolicies(SearchAllIamPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Searches all the IAM policies under a given accessible CRM scope
        /// (project/folder/organization). This RPC gives callers
        /// especially admins the ability to search all the IAM policies under a scope,
        /// even if they don't have .getIamPolicy permission of all the IAM policies.
        /// Callers should have cloud.assets.SearchAllIamPolicies permission on the
        /// requested scope, otherwise it will be rejected.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="IamPolicySearchResult"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchAllIamPoliciesResponse, IamPolicySearchResult> SearchAllIamPoliciesAsync(SearchAllIamPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Searches all the IAM policies under a given accessible CRM scope
        /// (project/folder/organization). This RPC gives callers
        /// especially admins the ability to search all the IAM policies under a scope,
        /// even if they don't have .getIamPolicy permission of all the IAM policies.
        /// Callers should have cloud.assets.SearchAllIamPolicies permission on the
        /// requested scope, otherwise it will be rejected.
        /// </summary>
        /// <param name="scope">
        /// Required. The relative name of an asset. The search is limited to the resources
        /// within the `scope`. The allowed value must be:
        /// * Organization number (such as "organizations/123")
        /// * Folder number(such as "folders/1234")
        /// * Project number (such as "projects/12345")
        /// * Project id (such as "projects/abc")
        /// </param>
        /// <param name="query">
        /// Optional. The query statement.
        /// Examples:
        /// * "policy:myuser@mydomain.com"
        /// * "policy:(myuser@mydomain.com viewer)"
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
        /// <returns>A pageable sequence of <see cref="IamPolicySearchResult"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchAllIamPoliciesResponse, IamPolicySearchResult> SearchAllIamPolicies(string scope, string query, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            SearchAllIamPolicies(new SearchAllIamPoliciesRequest
            {
                Scope = gax::GaxPreconditions.CheckNotNullOrEmpty(scope, nameof(scope)),
                Query = query ?? "",
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Searches all the IAM policies under a given accessible CRM scope
        /// (project/folder/organization). This RPC gives callers
        /// especially admins the ability to search all the IAM policies under a scope,
        /// even if they don't have .getIamPolicy permission of all the IAM policies.
        /// Callers should have cloud.assets.SearchAllIamPolicies permission on the
        /// requested scope, otherwise it will be rejected.
        /// </summary>
        /// <param name="scope">
        /// Required. The relative name of an asset. The search is limited to the resources
        /// within the `scope`. The allowed value must be:
        /// * Organization number (such as "organizations/123")
        /// * Folder number(such as "folders/1234")
        /// * Project number (such as "projects/12345")
        /// * Project id (such as "projects/abc")
        /// </param>
        /// <param name="query">
        /// Optional. The query statement.
        /// Examples:
        /// * "policy:myuser@mydomain.com"
        /// * "policy:(myuser@mydomain.com viewer)"
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
        /// <returns>A pageable asynchronous sequence of <see cref="IamPolicySearchResult"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchAllIamPoliciesResponse, IamPolicySearchResult> SearchAllIamPoliciesAsync(string scope, string query, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            SearchAllIamPoliciesAsync(new SearchAllIamPoliciesRequest
            {
                Scope = gax::GaxPreconditions.CheckNotNullOrEmpty(scope, nameof(scope)),
                Query = query ?? "",
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);
    }

    /// <summary>AssetService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Asset service definition.
    /// </remarks>
    public sealed partial class AssetServiceClientImpl : AssetServiceClient
    {
        private readonly gaxgrpc::ApiCall<SearchAllResourcesRequest, SearchAllResourcesResponse> _callSearchAllResources;

        private readonly gaxgrpc::ApiCall<SearchAllIamPoliciesRequest, SearchAllIamPoliciesResponse> _callSearchAllIamPolicies;

        /// <summary>
        /// Constructs a client wrapper for the AssetService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AssetServiceSettings"/> used within this client.</param>
        public AssetServiceClientImpl(AssetService.AssetServiceClient grpcClient, AssetServiceSettings settings)
        {
            GrpcClient = grpcClient;
            AssetServiceSettings effectiveSettings = settings ?? AssetServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callSearchAllResources = clientHelper.BuildApiCall<SearchAllResourcesRequest, SearchAllResourcesResponse>(grpcClient.SearchAllResourcesAsync, grpcClient.SearchAllResources, effectiveSettings.SearchAllResourcesSettings).WithGoogleRequestParam("scope", request => request.Scope);
            Modify_ApiCall(ref _callSearchAllResources);
            Modify_SearchAllResourcesApiCall(ref _callSearchAllResources);
            _callSearchAllIamPolicies = clientHelper.BuildApiCall<SearchAllIamPoliciesRequest, SearchAllIamPoliciesResponse>(grpcClient.SearchAllIamPoliciesAsync, grpcClient.SearchAllIamPolicies, effectiveSettings.SearchAllIamPoliciesSettings).WithGoogleRequestParam("scope", request => request.Scope);
            Modify_ApiCall(ref _callSearchAllIamPolicies);
            Modify_SearchAllIamPoliciesApiCall(ref _callSearchAllIamPolicies);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_SearchAllResourcesApiCall(ref gaxgrpc::ApiCall<SearchAllResourcesRequest, SearchAllResourcesResponse> call);

        partial void Modify_SearchAllIamPoliciesApiCall(ref gaxgrpc::ApiCall<SearchAllIamPoliciesRequest, SearchAllIamPoliciesResponse> call);

        partial void OnConstruction(AssetService.AssetServiceClient grpcClient, AssetServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AssetService client</summary>
        public override AssetService.AssetServiceClient GrpcClient { get; }

        partial void Modify_SearchAllResourcesRequest(ref SearchAllResourcesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SearchAllIamPoliciesRequest(ref SearchAllIamPoliciesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Searches all the resources under a given accessible CRM scope
        /// (project/folder/organization). This RPC gives callers
        /// especially admins the ability to search all the resources under a scope,
        /// even if they don't have .get permission of all the resources. Callers
        /// should have cloud.assets.SearchAllResources permission on the requested
        /// scope, otherwise it will be rejected.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="StandardResourceMetadata"/> resources.</returns>
        public override gax::PagedEnumerable<SearchAllResourcesResponse, StandardResourceMetadata> SearchAllResources(SearchAllResourcesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchAllResourcesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchAllResourcesRequest, SearchAllResourcesResponse, StandardResourceMetadata>(_callSearchAllResources, request, callSettings);
        }

        /// <summary>
        /// Searches all the resources under a given accessible CRM scope
        /// (project/folder/organization). This RPC gives callers
        /// especially admins the ability to search all the resources under a scope,
        /// even if they don't have .get permission of all the resources. Callers
        /// should have cloud.assets.SearchAllResources permission on the requested
        /// scope, otherwise it will be rejected.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="StandardResourceMetadata"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<SearchAllResourcesResponse, StandardResourceMetadata> SearchAllResourcesAsync(SearchAllResourcesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchAllResourcesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchAllResourcesRequest, SearchAllResourcesResponse, StandardResourceMetadata>(_callSearchAllResources, request, callSettings);
        }

        /// <summary>
        /// Searches all the IAM policies under a given accessible CRM scope
        /// (project/folder/organization). This RPC gives callers
        /// especially admins the ability to search all the IAM policies under a scope,
        /// even if they don't have .getIamPolicy permission of all the IAM policies.
        /// Callers should have cloud.assets.SearchAllIamPolicies permission on the
        /// requested scope, otherwise it will be rejected.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="IamPolicySearchResult"/> resources.</returns>
        public override gax::PagedEnumerable<SearchAllIamPoliciesResponse, IamPolicySearchResult> SearchAllIamPolicies(SearchAllIamPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchAllIamPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchAllIamPoliciesRequest, SearchAllIamPoliciesResponse, IamPolicySearchResult>(_callSearchAllIamPolicies, request, callSettings);
        }

        /// <summary>
        /// Searches all the IAM policies under a given accessible CRM scope
        /// (project/folder/organization). This RPC gives callers
        /// especially admins the ability to search all the IAM policies under a scope,
        /// even if they don't have .getIamPolicy permission of all the IAM policies.
        /// Callers should have cloud.assets.SearchAllIamPolicies permission on the
        /// requested scope, otherwise it will be rejected.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="IamPolicySearchResult"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<SearchAllIamPoliciesResponse, IamPolicySearchResult> SearchAllIamPoliciesAsync(SearchAllIamPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchAllIamPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchAllIamPoliciesRequest, SearchAllIamPoliciesResponse, IamPolicySearchResult>(_callSearchAllIamPolicies, request, callSettings);
        }
    }

    public partial class SearchAllResourcesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class SearchAllIamPoliciesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class SearchAllResourcesResponse : gaxgrpc::IPageResponse<StandardResourceMetadata>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<StandardResourceMetadata> GetEnumerator() => Results.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class SearchAllIamPoliciesResponse : gaxgrpc::IPageResponse<IamPolicySearchResult>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<IamPolicySearchResult> GetEnumerator() => Results.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
