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
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Monitoring.Dashboard.V1
{
    /// <summary>Settings for <see cref="DashboardsServiceClient"/> instances.</summary>
    public sealed partial class DashboardsServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DashboardsServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DashboardsServiceSettings"/>.</returns>
        public static DashboardsServiceSettings GetDefault() => new DashboardsServiceSettings();

        /// <summary>Constructs a new <see cref="DashboardsServiceSettings"/> object with default settings.</summary>
        public DashboardsServiceSettings()
        {
        }

        private DashboardsServiceSettings(DashboardsServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateDashboardSettings = existing.CreateDashboardSettings;
            ListDashboardsSettings = existing.ListDashboardsSettings;
            GetDashboardSettings = existing.GetDashboardSettings;
            DeleteDashboardSettings = existing.DeleteDashboardSettings;
            UpdateDashboardSettings = existing.UpdateDashboardSettings;
            OnCopy(existing);
        }

        partial void OnCopy(DashboardsServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DashboardsServiceClient.CreateDashboard</c> and <c>DashboardsServiceClient.CreateDashboardAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateDashboardSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DashboardsServiceClient.ListDashboards</c> and <c>DashboardsServiceClient.ListDashboardsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDashboardsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DashboardsServiceClient.GetDashboard</c> and <c>DashboardsServiceClient.GetDashboardAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDashboardSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DashboardsServiceClient.DeleteDashboard</c> and <c>DashboardsServiceClient.DeleteDashboardAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteDashboardSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DashboardsServiceClient.UpdateDashboard</c> and <c>DashboardsServiceClient.UpdateDashboardAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateDashboardSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DashboardsServiceSettings"/> object.</returns>
        public DashboardsServiceSettings Clone() => new DashboardsServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DashboardsServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class DashboardsServiceClientBuilder : gaxgrpc::ClientBuilderBase<DashboardsServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DashboardsServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref DashboardsServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DashboardsServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DashboardsServiceClient Build()
        {
            DashboardsServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DashboardsServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DashboardsServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DashboardsServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DashboardsServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<DashboardsServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DashboardsServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => DashboardsServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => DashboardsServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DashboardsServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>DashboardsService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Manages Stackdriver dashboards. A dashboard is an arrangement of data display
    /// widgets in a specific layout.
    /// </remarks>
    public abstract partial class DashboardsServiceClient
    {
        /// <summary>
        /// The default endpoint for the DashboardsService service, which is a host of "monitoring.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "monitoring.googleapis.com:443";

        /// <summary>The default DashboardsService scopes.</summary>
        /// <remarks>
        /// The default DashboardsService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/monitoring</description></item>
        /// <item><description>https://www.googleapis.com/auth/monitoring.read</description></item>
        /// <item><description>https://www.googleapis.com/auth/monitoring.write</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/monitoring",
            "https://www.googleapis.com/auth/monitoring.read",
            "https://www.googleapis.com/auth/monitoring.write",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="DashboardsServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DashboardsServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DashboardsServiceClient"/>.</returns>
        public static stt::Task<DashboardsServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DashboardsServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DashboardsServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DashboardsServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DashboardsServiceClient"/>.</returns>
        public static DashboardsServiceClient Create() => new DashboardsServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DashboardsServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DashboardsServiceSettings"/>.</param>
        /// <returns>The created <see cref="DashboardsServiceClient"/>.</returns>
        internal static DashboardsServiceClient Create(grpccore::CallInvoker callInvoker, DashboardsServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DashboardsService.DashboardsServiceClient grpcClient = new DashboardsService.DashboardsServiceClient(callInvoker);
            return new DashboardsServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC DashboardsService client</summary>
        public virtual DashboardsService.DashboardsServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new custom dashboard. For examples on how you can use this API to create dashboards, see [Managing dashboards by API](/monitoring/dashboards/api-dashboard).
        /// This method requires the `monitoring.dashboards.create` permission on the specified project. For more information about permissions, see [Cloud Identity and Access Management](/iam).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Dashboard CreateDashboard(CreateDashboardRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new custom dashboard. For examples on how you can use this API to create dashboards, see [Managing dashboards by API](/monitoring/dashboards/api-dashboard).
        /// This method requires the `monitoring.dashboards.create` permission on the specified project. For more information about permissions, see [Cloud Identity and Access Management](/iam).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dashboard> CreateDashboardAsync(CreateDashboardRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new custom dashboard. For examples on how you can use this API to create dashboards, see [Managing dashboards by API](/monitoring/dashboards/api-dashboard).
        /// This method requires the `monitoring.dashboards.create` permission on the specified project. For more information about permissions, see [Cloud Identity and Access Management](/iam).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dashboard> CreateDashboardAsync(CreateDashboardRequest request, st::CancellationToken cancellationToken) =>
            CreateDashboardAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the existing dashboards.
        /// 
        /// This method requires the `monitoring.dashboards.list` permission
        /// on the specified project. For more information, see
        /// [Cloud Identity and Access Management](https://cloud.google.com/iam).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Dashboard"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDashboardsResponse, Dashboard> ListDashboards(ListDashboardsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the existing dashboards.
        /// 
        /// This method requires the `monitoring.dashboards.list` permission
        /// on the specified project. For more information, see
        /// [Cloud Identity and Access Management](https://cloud.google.com/iam).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Dashboard"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDashboardsResponse, Dashboard> ListDashboardsAsync(ListDashboardsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches a specific dashboard.
        /// 
        /// This method requires the `monitoring.dashboards.get` permission
        /// on the specified dashboard. For more information, see
        /// [Cloud Identity and Access Management](https://cloud.google.com/iam).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Dashboard GetDashboard(GetDashboardRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches a specific dashboard.
        /// 
        /// This method requires the `monitoring.dashboards.get` permission
        /// on the specified dashboard. For more information, see
        /// [Cloud Identity and Access Management](https://cloud.google.com/iam).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dashboard> GetDashboardAsync(GetDashboardRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches a specific dashboard.
        /// 
        /// This method requires the `monitoring.dashboards.get` permission
        /// on the specified dashboard. For more information, see
        /// [Cloud Identity and Access Management](https://cloud.google.com/iam).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dashboard> GetDashboardAsync(GetDashboardRequest request, st::CancellationToken cancellationToken) =>
            GetDashboardAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an existing custom dashboard.
        /// 
        /// This method requires the `monitoring.dashboards.delete` permission
        /// on the specified dashboard. For more information, see
        /// [Cloud Identity and Access Management](https://cloud.google.com/iam).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDashboard(DeleteDashboardRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an existing custom dashboard.
        /// 
        /// This method requires the `monitoring.dashboards.delete` permission
        /// on the specified dashboard. For more information, see
        /// [Cloud Identity and Access Management](https://cloud.google.com/iam).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDashboardAsync(DeleteDashboardRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an existing custom dashboard.
        /// 
        /// This method requires the `monitoring.dashboards.delete` permission
        /// on the specified dashboard. For more information, see
        /// [Cloud Identity and Access Management](https://cloud.google.com/iam).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDashboardAsync(DeleteDashboardRequest request, st::CancellationToken cancellationToken) =>
            DeleteDashboardAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Replaces an existing custom dashboard with a new definition.
        /// 
        /// This method requires the `monitoring.dashboards.update` permission
        /// on the specified dashboard. For more information, see
        /// [Cloud Identity and Access Management](https://cloud.google.com/iam).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Dashboard UpdateDashboard(UpdateDashboardRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Replaces an existing custom dashboard with a new definition.
        /// 
        /// This method requires the `monitoring.dashboards.update` permission
        /// on the specified dashboard. For more information, see
        /// [Cloud Identity and Access Management](https://cloud.google.com/iam).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dashboard> UpdateDashboardAsync(UpdateDashboardRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Replaces an existing custom dashboard with a new definition.
        /// 
        /// This method requires the `monitoring.dashboards.update` permission
        /// on the specified dashboard. For more information, see
        /// [Cloud Identity and Access Management](https://cloud.google.com/iam).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dashboard> UpdateDashboardAsync(UpdateDashboardRequest request, st::CancellationToken cancellationToken) =>
            UpdateDashboardAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>DashboardsService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Manages Stackdriver dashboards. A dashboard is an arrangement of data display
    /// widgets in a specific layout.
    /// </remarks>
    public sealed partial class DashboardsServiceClientImpl : DashboardsServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateDashboardRequest, Dashboard> _callCreateDashboard;

        private readonly gaxgrpc::ApiCall<ListDashboardsRequest, ListDashboardsResponse> _callListDashboards;

        private readonly gaxgrpc::ApiCall<GetDashboardRequest, Dashboard> _callGetDashboard;

        private readonly gaxgrpc::ApiCall<DeleteDashboardRequest, wkt::Empty> _callDeleteDashboard;

        private readonly gaxgrpc::ApiCall<UpdateDashboardRequest, Dashboard> _callUpdateDashboard;

        /// <summary>
        /// Constructs a client wrapper for the DashboardsService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DashboardsServiceSettings"/> used within this client.</param>
        public DashboardsServiceClientImpl(DashboardsService.DashboardsServiceClient grpcClient, DashboardsServiceSettings settings)
        {
            GrpcClient = grpcClient;
            DashboardsServiceSettings effectiveSettings = settings ?? DashboardsServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callCreateDashboard = clientHelper.BuildApiCall<CreateDashboardRequest, Dashboard>(grpcClient.CreateDashboardAsync, grpcClient.CreateDashboard, effectiveSettings.CreateDashboardSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateDashboard);
            Modify_CreateDashboardApiCall(ref _callCreateDashboard);
            _callListDashboards = clientHelper.BuildApiCall<ListDashboardsRequest, ListDashboardsResponse>(grpcClient.ListDashboardsAsync, grpcClient.ListDashboards, effectiveSettings.ListDashboardsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDashboards);
            Modify_ListDashboardsApiCall(ref _callListDashboards);
            _callGetDashboard = clientHelper.BuildApiCall<GetDashboardRequest, Dashboard>(grpcClient.GetDashboardAsync, grpcClient.GetDashboard, effectiveSettings.GetDashboardSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDashboard);
            Modify_GetDashboardApiCall(ref _callGetDashboard);
            _callDeleteDashboard = clientHelper.BuildApiCall<DeleteDashboardRequest, wkt::Empty>(grpcClient.DeleteDashboardAsync, grpcClient.DeleteDashboard, effectiveSettings.DeleteDashboardSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteDashboard);
            Modify_DeleteDashboardApiCall(ref _callDeleteDashboard);
            _callUpdateDashboard = clientHelper.BuildApiCall<UpdateDashboardRequest, Dashboard>(grpcClient.UpdateDashboardAsync, grpcClient.UpdateDashboard, effectiveSettings.UpdateDashboardSettings).WithGoogleRequestParam("dashboard.name", request => request.Dashboard?.Name);
            Modify_ApiCall(ref _callUpdateDashboard);
            Modify_UpdateDashboardApiCall(ref _callUpdateDashboard);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateDashboardApiCall(ref gaxgrpc::ApiCall<CreateDashboardRequest, Dashboard> call);

        partial void Modify_ListDashboardsApiCall(ref gaxgrpc::ApiCall<ListDashboardsRequest, ListDashboardsResponse> call);

        partial void Modify_GetDashboardApiCall(ref gaxgrpc::ApiCall<GetDashboardRequest, Dashboard> call);

        partial void Modify_DeleteDashboardApiCall(ref gaxgrpc::ApiCall<DeleteDashboardRequest, wkt::Empty> call);

        partial void Modify_UpdateDashboardApiCall(ref gaxgrpc::ApiCall<UpdateDashboardRequest, Dashboard> call);

        partial void OnConstruction(DashboardsService.DashboardsServiceClient grpcClient, DashboardsServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DashboardsService client</summary>
        public override DashboardsService.DashboardsServiceClient GrpcClient { get; }

        partial void Modify_CreateDashboardRequest(ref CreateDashboardRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDashboardsRequest(ref ListDashboardsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDashboardRequest(ref GetDashboardRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteDashboardRequest(ref DeleteDashboardRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDashboardRequest(ref UpdateDashboardRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a new custom dashboard. For examples on how you can use this API to create dashboards, see [Managing dashboards by API](/monitoring/dashboards/api-dashboard).
        /// This method requires the `monitoring.dashboards.create` permission on the specified project. For more information about permissions, see [Cloud Identity and Access Management](/iam).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Dashboard CreateDashboard(CreateDashboardRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDashboardRequest(ref request, ref callSettings);
            return _callCreateDashboard.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new custom dashboard. For examples on how you can use this API to create dashboards, see [Managing dashboards by API](/monitoring/dashboards/api-dashboard).
        /// This method requires the `monitoring.dashboards.create` permission on the specified project. For more information about permissions, see [Cloud Identity and Access Management](/iam).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Dashboard> CreateDashboardAsync(CreateDashboardRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDashboardRequest(ref request, ref callSettings);
            return _callCreateDashboard.Async(request, callSettings);
        }

        /// <summary>
        /// Lists the existing dashboards.
        /// 
        /// This method requires the `monitoring.dashboards.list` permission
        /// on the specified project. For more information, see
        /// [Cloud Identity and Access Management](https://cloud.google.com/iam).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Dashboard"/> resources.</returns>
        public override gax::PagedEnumerable<ListDashboardsResponse, Dashboard> ListDashboards(ListDashboardsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDashboardsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDashboardsRequest, ListDashboardsResponse, Dashboard>(_callListDashboards, request, callSettings);
        }

        /// <summary>
        /// Lists the existing dashboards.
        /// 
        /// This method requires the `monitoring.dashboards.list` permission
        /// on the specified project. For more information, see
        /// [Cloud Identity and Access Management](https://cloud.google.com/iam).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Dashboard"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDashboardsResponse, Dashboard> ListDashboardsAsync(ListDashboardsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDashboardsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDashboardsRequest, ListDashboardsResponse, Dashboard>(_callListDashboards, request, callSettings);
        }

        /// <summary>
        /// Fetches a specific dashboard.
        /// 
        /// This method requires the `monitoring.dashboards.get` permission
        /// on the specified dashboard. For more information, see
        /// [Cloud Identity and Access Management](https://cloud.google.com/iam).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Dashboard GetDashboard(GetDashboardRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDashboardRequest(ref request, ref callSettings);
            return _callGetDashboard.Sync(request, callSettings);
        }

        /// <summary>
        /// Fetches a specific dashboard.
        /// 
        /// This method requires the `monitoring.dashboards.get` permission
        /// on the specified dashboard. For more information, see
        /// [Cloud Identity and Access Management](https://cloud.google.com/iam).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Dashboard> GetDashboardAsync(GetDashboardRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDashboardRequest(ref request, ref callSettings);
            return _callGetDashboard.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes an existing custom dashboard.
        /// 
        /// This method requires the `monitoring.dashboards.delete` permission
        /// on the specified dashboard. For more information, see
        /// [Cloud Identity and Access Management](https://cloud.google.com/iam).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteDashboard(DeleteDashboardRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDashboardRequest(ref request, ref callSettings);
            _callDeleteDashboard.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes an existing custom dashboard.
        /// 
        /// This method requires the `monitoring.dashboards.delete` permission
        /// on the specified dashboard. For more information, see
        /// [Cloud Identity and Access Management](https://cloud.google.com/iam).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteDashboardAsync(DeleteDashboardRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDashboardRequest(ref request, ref callSettings);
            return _callDeleteDashboard.Async(request, callSettings);
        }

        /// <summary>
        /// Replaces an existing custom dashboard with a new definition.
        /// 
        /// This method requires the `monitoring.dashboards.update` permission
        /// on the specified dashboard. For more information, see
        /// [Cloud Identity and Access Management](https://cloud.google.com/iam).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Dashboard UpdateDashboard(UpdateDashboardRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDashboardRequest(ref request, ref callSettings);
            return _callUpdateDashboard.Sync(request, callSettings);
        }

        /// <summary>
        /// Replaces an existing custom dashboard with a new definition.
        /// 
        /// This method requires the `monitoring.dashboards.update` permission
        /// on the specified dashboard. For more information, see
        /// [Cloud Identity and Access Management](https://cloud.google.com/iam).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Dashboard> UpdateDashboardAsync(UpdateDashboardRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDashboardRequest(ref request, ref callSettings);
            return _callUpdateDashboard.Async(request, callSettings);
        }
    }

    public partial class ListDashboardsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDashboardsResponse : gaxgrpc::IPageResponse<Dashboard>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Dashboard> GetEnumerator() => Dashboards.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
