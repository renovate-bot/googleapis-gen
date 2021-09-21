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
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Chromeos.Moblab.V1Beta1
{
    /// <summary>Settings for <see cref="BuildServiceClient"/> instances.</summary>
    public sealed partial class BuildServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="BuildServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="BuildServiceSettings"/>.</returns>
        public static BuildServiceSettings GetDefault() => new BuildServiceSettings();

        /// <summary>Constructs a new <see cref="BuildServiceSettings"/> object with default settings.</summary>
        public BuildServiceSettings()
        {
        }

        private BuildServiceSettings(BuildServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListBuildTargetsSettings = existing.ListBuildTargetsSettings;
            ListModelsSettings = existing.ListModelsSettings;
            ListBuildsSettings = existing.ListBuildsSettings;
            CheckBuildStageStatusSettings = existing.CheckBuildStageStatusSettings;
            StageBuildSettings = existing.StageBuildSettings;
            StageBuildOperationsSettings = existing.StageBuildOperationsSettings.Clone();
            FindMostStableBuildSettings = existing.FindMostStableBuildSettings;
            OnCopy(existing);
        }

        partial void OnCopy(BuildServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BuildServiceClient.ListBuildTargets</c> and <c>BuildServiceClient.ListBuildTargetsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListBuildTargetsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BuildServiceClient.ListModels</c> and <c>BuildServiceClient.ListModelsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListModelsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BuildServiceClient.ListBuilds</c> and <c>BuildServiceClient.ListBuildsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListBuildsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BuildServiceClient.CheckBuildStageStatus</c> and <c>BuildServiceClient.CheckBuildStageStatusAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CheckBuildStageStatusSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BuildServiceClient.StageBuild</c> and <c>BuildServiceClient.StageBuildAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StageBuildSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BuildServiceClient.StageBuild</c> and
        /// <c>BuildServiceClient.StageBuildAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings StageBuildOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BuildServiceClient.FindMostStableBuild</c> and <c>BuildServiceClient.FindMostStableBuildAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings FindMostStableBuildSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="BuildServiceSettings"/> object.</returns>
        public BuildServiceSettings Clone() => new BuildServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="BuildServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class BuildServiceClientBuilder : gaxgrpc::ClientBuilderBase<BuildServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public BuildServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public BuildServiceClientBuilder()
        {
            UseJwtAccessWithScopes = BuildServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref BuildServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<BuildServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override BuildServiceClient Build()
        {
            BuildServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<BuildServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<BuildServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private BuildServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return BuildServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<BuildServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return BuildServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => BuildServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => BuildServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => BuildServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>BuildService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Manages Chrome OS build services.
    /// </remarks>
    public abstract partial class BuildServiceClient
    {
        /// <summary>
        /// The default endpoint for the BuildService service, which is a host of "chromeosmoblab.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "chromeosmoblab.googleapis.com:443";

        /// <summary>The default BuildService scopes.</summary>
        /// <remarks>
        /// The default BuildService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/moblabapi</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/moblabapi",
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
        /// Asynchronously creates a <see cref="BuildServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="BuildServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="BuildServiceClient"/>.</returns>
        public static stt::Task<BuildServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new BuildServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="BuildServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="BuildServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="BuildServiceClient"/>.</returns>
        public static BuildServiceClient Create() => new BuildServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="BuildServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="BuildServiceSettings"/>.</param>
        /// <returns>The created <see cref="BuildServiceClient"/>.</returns>
        internal static BuildServiceClient Create(grpccore::CallInvoker callInvoker, BuildServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            BuildService.BuildServiceClient grpcClient = new BuildService.BuildServiceClient(callInvoker);
            return new BuildServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC BuildService client</summary>
        public virtual BuildService.BuildServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all build targets that a user has access to.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="BuildTarget"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBuildTargetsResponse, BuildTarget> ListBuildTargets(ListBuildTargetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all build targets that a user has access to.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="BuildTarget"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBuildTargetsResponse, BuildTarget> ListBuildTargetsAsync(ListBuildTargetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all models for the given build target.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Model"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListModelsResponse, Model> ListModels(ListModelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all models for the given build target.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Model"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListModelsResponse, Model> ListModelsAsync(ListModelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all models for the given build target.
        /// </summary>
        /// <param name="parent">
        /// Required. The full resource name of build target.
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
        /// <returns>A pageable sequence of <see cref="Model"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListModelsResponse, Model> ListModels(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListModels(new ListModelsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all models for the given build target.
        /// </summary>
        /// <param name="parent">
        /// Required. The full resource name of build target.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Model"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListModelsResponse, Model> ListModelsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListModelsAsync(new ListModelsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all models for the given build target.
        /// </summary>
        /// <param name="parent">
        /// Required. The full resource name of build target.
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
        /// <returns>A pageable sequence of <see cref="Model"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListModelsResponse, Model> ListModels(BuildTargetName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListModels(new ListModelsRequest
            {
                ParentAsBuildTargetName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all models for the given build target.
        /// </summary>
        /// <param name="parent">
        /// Required. The full resource name of build target.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Model"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListModelsResponse, Model> ListModelsAsync(BuildTargetName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListModelsAsync(new ListModelsRequest
            {
                ParentAsBuildTargetName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all builds for the given build target and model in descending order
        /// for the milestones and build versions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Build"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBuildsResponse, Build> ListBuilds(ListBuildsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all builds for the given build target and model in descending order
        /// for the milestones and build versions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Build"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBuildsResponse, Build> ListBuildsAsync(ListBuildsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all builds for the given build target and model in descending order
        /// for the milestones and build versions.
        /// </summary>
        /// <param name="parent">
        /// Required. The full resource name of the model. The model id is the same as
        /// the build target id for non-unified builds.
        /// For example,
        /// 'buildTargets/octopus/models/bobba'.
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
        /// <returns>A pageable sequence of <see cref="Build"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBuildsResponse, Build> ListBuilds(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListBuilds(new ListBuildsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all builds for the given build target and model in descending order
        /// for the milestones and build versions.
        /// </summary>
        /// <param name="parent">
        /// Required. The full resource name of the model. The model id is the same as
        /// the build target id for non-unified builds.
        /// For example,
        /// 'buildTargets/octopus/models/bobba'.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Build"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBuildsResponse, Build> ListBuildsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListBuildsAsync(new ListBuildsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all builds for the given build target and model in descending order
        /// for the milestones and build versions.
        /// </summary>
        /// <param name="parent">
        /// Required. The full resource name of the model. The model id is the same as
        /// the build target id for non-unified builds.
        /// For example,
        /// 'buildTargets/octopus/models/bobba'.
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
        /// <returns>A pageable sequence of <see cref="Build"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBuildsResponse, Build> ListBuilds(ModelName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListBuilds(new ListBuildsRequest
            {
                ParentAsModelName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all builds for the given build target and model in descending order
        /// for the milestones and build versions.
        /// </summary>
        /// <param name="parent">
        /// Required. The full resource name of the model. The model id is the same as
        /// the build target id for non-unified builds.
        /// For example,
        /// 'buildTargets/octopus/models/bobba'.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Build"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBuildsResponse, Build> ListBuildsAsync(ModelName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListBuildsAsync(new ListBuildsRequest
            {
                ParentAsModelName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Checks the stage status for a given build artifact in a partner Google
        /// Cloud Storage bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CheckBuildStageStatusResponse CheckBuildStageStatus(CheckBuildStageStatusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Checks the stage status for a given build artifact in a partner Google
        /// Cloud Storage bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckBuildStageStatusResponse> CheckBuildStageStatusAsync(CheckBuildStageStatusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Checks the stage status for a given build artifact in a partner Google
        /// Cloud Storage bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckBuildStageStatusResponse> CheckBuildStageStatusAsync(CheckBuildStageStatusRequest request, st::CancellationToken cancellationToken) =>
            CheckBuildStageStatusAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Checks the stage status for a given build artifact in a partner Google
        /// Cloud Storage bucket.
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the build artifact.
        /// For example,
        /// 'buildTargets/octopus/models/bobba/builds/12607.6.0/artifacts/chromeos-moblab-peng-staging'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CheckBuildStageStatusResponse CheckBuildStageStatus(string name, gaxgrpc::CallSettings callSettings = null) =>
            CheckBuildStageStatus(new CheckBuildStageStatusRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Checks the stage status for a given build artifact in a partner Google
        /// Cloud Storage bucket.
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the build artifact.
        /// For example,
        /// 'buildTargets/octopus/models/bobba/builds/12607.6.0/artifacts/chromeos-moblab-peng-staging'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckBuildStageStatusResponse> CheckBuildStageStatusAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            CheckBuildStageStatusAsync(new CheckBuildStageStatusRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Checks the stage status for a given build artifact in a partner Google
        /// Cloud Storage bucket.
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the build artifact.
        /// For example,
        /// 'buildTargets/octopus/models/bobba/builds/12607.6.0/artifacts/chromeos-moblab-peng-staging'.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckBuildStageStatusResponse> CheckBuildStageStatusAsync(string name, st::CancellationToken cancellationToken) =>
            CheckBuildStageStatusAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Checks the stage status for a given build artifact in a partner Google
        /// Cloud Storage bucket.
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the build artifact.
        /// For example,
        /// 'buildTargets/octopus/models/bobba/builds/12607.6.0/artifacts/chromeos-moblab-peng-staging'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CheckBuildStageStatusResponse CheckBuildStageStatus(BuildArtifactName name, gaxgrpc::CallSettings callSettings = null) =>
            CheckBuildStageStatus(new CheckBuildStageStatusRequest
            {
                BuildArtifactName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Checks the stage status for a given build artifact in a partner Google
        /// Cloud Storage bucket.
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the build artifact.
        /// For example,
        /// 'buildTargets/octopus/models/bobba/builds/12607.6.0/artifacts/chromeos-moblab-peng-staging'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckBuildStageStatusResponse> CheckBuildStageStatusAsync(BuildArtifactName name, gaxgrpc::CallSettings callSettings = null) =>
            CheckBuildStageStatusAsync(new CheckBuildStageStatusRequest
            {
                BuildArtifactName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Checks the stage status for a given build artifact in a partner Google
        /// Cloud Storage bucket.
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the build artifact.
        /// For example,
        /// 'buildTargets/octopus/models/bobba/builds/12607.6.0/artifacts/chromeos-moblab-peng-staging'.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckBuildStageStatusResponse> CheckBuildStageStatusAsync(BuildArtifactName name, st::CancellationToken cancellationToken) =>
            CheckBuildStageStatusAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Stages a given build artifact from a internal Google Cloud Storage bucket
        /// to a partner Google Cloud Storage bucket. If any of objects has already
        /// been copied, it will overwrite the previous objects. Operation &amp;lt;response:
        /// [StageBuildResponse][google.chromeos.moblab.v1beta1.StageBuildResponse],
        /// metadata: [StageBuildMetadata][google.chromeos.moblab.v1beta1.StageBuildMetadata]&amp;gt;
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<StageBuildResponse, StageBuildMetadata> StageBuild(StageBuildRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Stages a given build artifact from a internal Google Cloud Storage bucket
        /// to a partner Google Cloud Storage bucket. If any of objects has already
        /// been copied, it will overwrite the previous objects. Operation &amp;lt;response:
        /// [StageBuildResponse][google.chromeos.moblab.v1beta1.StageBuildResponse],
        /// metadata: [StageBuildMetadata][google.chromeos.moblab.v1beta1.StageBuildMetadata]&amp;gt;
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<StageBuildResponse, StageBuildMetadata>> StageBuildAsync(StageBuildRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Stages a given build artifact from a internal Google Cloud Storage bucket
        /// to a partner Google Cloud Storage bucket. If any of objects has already
        /// been copied, it will overwrite the previous objects. Operation &amp;lt;response:
        /// [StageBuildResponse][google.chromeos.moblab.v1beta1.StageBuildResponse],
        /// metadata: [StageBuildMetadata][google.chromeos.moblab.v1beta1.StageBuildMetadata]&amp;gt;
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<StageBuildResponse, StageBuildMetadata>> StageBuildAsync(StageBuildRequest request, st::CancellationToken cancellationToken) =>
            StageBuildAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>StageBuild</c>.</summary>
        public virtual lro::OperationsClient StageBuildOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>StageBuild</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<StageBuildResponse, StageBuildMetadata> PollOnceStageBuild(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<StageBuildResponse, StageBuildMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StageBuildOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>StageBuild</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<StageBuildResponse, StageBuildMetadata>> PollOnceStageBuildAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<StageBuildResponse, StageBuildMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StageBuildOperationsClient, callSettings);

        /// <summary>
        /// Stages a given build artifact from a internal Google Cloud Storage bucket
        /// to a partner Google Cloud Storage bucket. If any of objects has already
        /// been copied, it will overwrite the previous objects. Operation &amp;lt;response:
        /// [StageBuildResponse][google.chromeos.moblab.v1beta1.StageBuildResponse],
        /// metadata: [StageBuildMetadata][google.chromeos.moblab.v1beta1.StageBuildMetadata]&amp;gt;
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the build artifact.
        /// For example,
        /// 'buildTargets/octopus/models/bobba/builds/12607.6.0/artifacts/chromeos-moblab-peng-staging'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<StageBuildResponse, StageBuildMetadata> StageBuild(string name, gaxgrpc::CallSettings callSettings = null) =>
            StageBuild(new StageBuildRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Stages a given build artifact from a internal Google Cloud Storage bucket
        /// to a partner Google Cloud Storage bucket. If any of objects has already
        /// been copied, it will overwrite the previous objects. Operation &amp;lt;response:
        /// [StageBuildResponse][google.chromeos.moblab.v1beta1.StageBuildResponse],
        /// metadata: [StageBuildMetadata][google.chromeos.moblab.v1beta1.StageBuildMetadata]&amp;gt;
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the build artifact.
        /// For example,
        /// 'buildTargets/octopus/models/bobba/builds/12607.6.0/artifacts/chromeos-moblab-peng-staging'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<StageBuildResponse, StageBuildMetadata>> StageBuildAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            StageBuildAsync(new StageBuildRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Stages a given build artifact from a internal Google Cloud Storage bucket
        /// to a partner Google Cloud Storage bucket. If any of objects has already
        /// been copied, it will overwrite the previous objects. Operation &amp;lt;response:
        /// [StageBuildResponse][google.chromeos.moblab.v1beta1.StageBuildResponse],
        /// metadata: [StageBuildMetadata][google.chromeos.moblab.v1beta1.StageBuildMetadata]&amp;gt;
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the build artifact.
        /// For example,
        /// 'buildTargets/octopus/models/bobba/builds/12607.6.0/artifacts/chromeos-moblab-peng-staging'.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<StageBuildResponse, StageBuildMetadata>> StageBuildAsync(string name, st::CancellationToken cancellationToken) =>
            StageBuildAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Stages a given build artifact from a internal Google Cloud Storage bucket
        /// to a partner Google Cloud Storage bucket. If any of objects has already
        /// been copied, it will overwrite the previous objects. Operation &amp;lt;response:
        /// [StageBuildResponse][google.chromeos.moblab.v1beta1.StageBuildResponse],
        /// metadata: [StageBuildMetadata][google.chromeos.moblab.v1beta1.StageBuildMetadata]&amp;gt;
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the build artifact.
        /// For example,
        /// 'buildTargets/octopus/models/bobba/builds/12607.6.0/artifacts/chromeos-moblab-peng-staging'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<StageBuildResponse, StageBuildMetadata> StageBuild(BuildArtifactName name, gaxgrpc::CallSettings callSettings = null) =>
            StageBuild(new StageBuildRequest
            {
                BuildArtifactName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Stages a given build artifact from a internal Google Cloud Storage bucket
        /// to a partner Google Cloud Storage bucket. If any of objects has already
        /// been copied, it will overwrite the previous objects. Operation &amp;lt;response:
        /// [StageBuildResponse][google.chromeos.moblab.v1beta1.StageBuildResponse],
        /// metadata: [StageBuildMetadata][google.chromeos.moblab.v1beta1.StageBuildMetadata]&amp;gt;
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the build artifact.
        /// For example,
        /// 'buildTargets/octopus/models/bobba/builds/12607.6.0/artifacts/chromeos-moblab-peng-staging'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<StageBuildResponse, StageBuildMetadata>> StageBuildAsync(BuildArtifactName name, gaxgrpc::CallSettings callSettings = null) =>
            StageBuildAsync(new StageBuildRequest
            {
                BuildArtifactName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Stages a given build artifact from a internal Google Cloud Storage bucket
        /// to a partner Google Cloud Storage bucket. If any of objects has already
        /// been copied, it will overwrite the previous objects. Operation &amp;lt;response:
        /// [StageBuildResponse][google.chromeos.moblab.v1beta1.StageBuildResponse],
        /// metadata: [StageBuildMetadata][google.chromeos.moblab.v1beta1.StageBuildMetadata]&amp;gt;
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the build artifact.
        /// For example,
        /// 'buildTargets/octopus/models/bobba/builds/12607.6.0/artifacts/chromeos-moblab-peng-staging'.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<StageBuildResponse, StageBuildMetadata>> StageBuildAsync(BuildArtifactName name, st::CancellationToken cancellationToken) =>
            StageBuildAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Finds the most stable build for the given build target. The definition of
        /// the most stable build is determined by evaluating the following rules in
        /// order until one is true. If none are true, then there is no stable build
        /// and it will return an empty response.
        /// 
        /// Evaluation rules:
        /// 1. Stable channel build with label “Live”
        /// 2. Beta channel build with label “Live”
        /// 3. Dev channel build with label “Live”
        /// 4. Most recent stable channel build with build status Pass
        /// 5. Most recent beta channel build with build status Pass
        /// 6. Most recent dev channel build with build status Pass
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FindMostStableBuildResponse FindMostStableBuild(FindMostStableBuildRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Finds the most stable build for the given build target. The definition of
        /// the most stable build is determined by evaluating the following rules in
        /// order until one is true. If none are true, then there is no stable build
        /// and it will return an empty response.
        /// 
        /// Evaluation rules:
        /// 1. Stable channel build with label “Live”
        /// 2. Beta channel build with label “Live”
        /// 3. Dev channel build with label “Live”
        /// 4. Most recent stable channel build with build status Pass
        /// 5. Most recent beta channel build with build status Pass
        /// 6. Most recent dev channel build with build status Pass
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FindMostStableBuildResponse> FindMostStableBuildAsync(FindMostStableBuildRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Finds the most stable build for the given build target. The definition of
        /// the most stable build is determined by evaluating the following rules in
        /// order until one is true. If none are true, then there is no stable build
        /// and it will return an empty response.
        /// 
        /// Evaluation rules:
        /// 1. Stable channel build with label “Live”
        /// 2. Beta channel build with label “Live”
        /// 3. Dev channel build with label “Live”
        /// 4. Most recent stable channel build with build status Pass
        /// 5. Most recent beta channel build with build status Pass
        /// 6. Most recent dev channel build with build status Pass
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FindMostStableBuildResponse> FindMostStableBuildAsync(FindMostStableBuildRequest request, st::CancellationToken cancellationToken) =>
            FindMostStableBuildAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Finds the most stable build for the given build target. The definition of
        /// the most stable build is determined by evaluating the following rules in
        /// order until one is true. If none are true, then there is no stable build
        /// and it will return an empty response.
        /// 
        /// Evaluation rules:
        /// 1. Stable channel build with label “Live”
        /// 2. Beta channel build with label “Live”
        /// 3. Dev channel build with label “Live”
        /// 4. Most recent stable channel build with build status Pass
        /// 5. Most recent beta channel build with build status Pass
        /// 6. Most recent dev channel build with build status Pass
        /// </summary>
        /// <param name="buildTarget">
        /// Required. The full resource name of the build target.
        /// For example,
        /// 'buildTargets/octopus'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FindMostStableBuildResponse FindMostStableBuild(string buildTarget, gaxgrpc::CallSettings callSettings = null) =>
            FindMostStableBuild(new FindMostStableBuildRequest
            {
                BuildTarget = gax::GaxPreconditions.CheckNotNullOrEmpty(buildTarget, nameof(buildTarget)),
            }, callSettings);

        /// <summary>
        /// Finds the most stable build for the given build target. The definition of
        /// the most stable build is determined by evaluating the following rules in
        /// order until one is true. If none are true, then there is no stable build
        /// and it will return an empty response.
        /// 
        /// Evaluation rules:
        /// 1. Stable channel build with label “Live”
        /// 2. Beta channel build with label “Live”
        /// 3. Dev channel build with label “Live”
        /// 4. Most recent stable channel build with build status Pass
        /// 5. Most recent beta channel build with build status Pass
        /// 6. Most recent dev channel build with build status Pass
        /// </summary>
        /// <param name="buildTarget">
        /// Required. The full resource name of the build target.
        /// For example,
        /// 'buildTargets/octopus'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FindMostStableBuildResponse> FindMostStableBuildAsync(string buildTarget, gaxgrpc::CallSettings callSettings = null) =>
            FindMostStableBuildAsync(new FindMostStableBuildRequest
            {
                BuildTarget = gax::GaxPreconditions.CheckNotNullOrEmpty(buildTarget, nameof(buildTarget)),
            }, callSettings);

        /// <summary>
        /// Finds the most stable build for the given build target. The definition of
        /// the most stable build is determined by evaluating the following rules in
        /// order until one is true. If none are true, then there is no stable build
        /// and it will return an empty response.
        /// 
        /// Evaluation rules:
        /// 1. Stable channel build with label “Live”
        /// 2. Beta channel build with label “Live”
        /// 3. Dev channel build with label “Live”
        /// 4. Most recent stable channel build with build status Pass
        /// 5. Most recent beta channel build with build status Pass
        /// 6. Most recent dev channel build with build status Pass
        /// </summary>
        /// <param name="buildTarget">
        /// Required. The full resource name of the build target.
        /// For example,
        /// 'buildTargets/octopus'.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FindMostStableBuildResponse> FindMostStableBuildAsync(string buildTarget, st::CancellationToken cancellationToken) =>
            FindMostStableBuildAsync(buildTarget, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Finds the most stable build for the given build target. The definition of
        /// the most stable build is determined by evaluating the following rules in
        /// order until one is true. If none are true, then there is no stable build
        /// and it will return an empty response.
        /// 
        /// Evaluation rules:
        /// 1. Stable channel build with label “Live”
        /// 2. Beta channel build with label “Live”
        /// 3. Dev channel build with label “Live”
        /// 4. Most recent stable channel build with build status Pass
        /// 5. Most recent beta channel build with build status Pass
        /// 6. Most recent dev channel build with build status Pass
        /// </summary>
        /// <param name="buildTarget">
        /// Required. The full resource name of the build target.
        /// For example,
        /// 'buildTargets/octopus'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FindMostStableBuildResponse FindMostStableBuild(BuildTargetName buildTarget, gaxgrpc::CallSettings callSettings = null) =>
            FindMostStableBuild(new FindMostStableBuildRequest
            {
                BuildTargetAsBuildTargetName = gax::GaxPreconditions.CheckNotNull(buildTarget, nameof(buildTarget)),
            }, callSettings);

        /// <summary>
        /// Finds the most stable build for the given build target. The definition of
        /// the most stable build is determined by evaluating the following rules in
        /// order until one is true. If none are true, then there is no stable build
        /// and it will return an empty response.
        /// 
        /// Evaluation rules:
        /// 1. Stable channel build with label “Live”
        /// 2. Beta channel build with label “Live”
        /// 3. Dev channel build with label “Live”
        /// 4. Most recent stable channel build with build status Pass
        /// 5. Most recent beta channel build with build status Pass
        /// 6. Most recent dev channel build with build status Pass
        /// </summary>
        /// <param name="buildTarget">
        /// Required. The full resource name of the build target.
        /// For example,
        /// 'buildTargets/octopus'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FindMostStableBuildResponse> FindMostStableBuildAsync(BuildTargetName buildTarget, gaxgrpc::CallSettings callSettings = null) =>
            FindMostStableBuildAsync(new FindMostStableBuildRequest
            {
                BuildTargetAsBuildTargetName = gax::GaxPreconditions.CheckNotNull(buildTarget, nameof(buildTarget)),
            }, callSettings);

        /// <summary>
        /// Finds the most stable build for the given build target. The definition of
        /// the most stable build is determined by evaluating the following rules in
        /// order until one is true. If none are true, then there is no stable build
        /// and it will return an empty response.
        /// 
        /// Evaluation rules:
        /// 1. Stable channel build with label “Live”
        /// 2. Beta channel build with label “Live”
        /// 3. Dev channel build with label “Live”
        /// 4. Most recent stable channel build with build status Pass
        /// 5. Most recent beta channel build with build status Pass
        /// 6. Most recent dev channel build with build status Pass
        /// </summary>
        /// <param name="buildTarget">
        /// Required. The full resource name of the build target.
        /// For example,
        /// 'buildTargets/octopus'.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FindMostStableBuildResponse> FindMostStableBuildAsync(BuildTargetName buildTarget, st::CancellationToken cancellationToken) =>
            FindMostStableBuildAsync(buildTarget, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>BuildService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Manages Chrome OS build services.
    /// </remarks>
    public sealed partial class BuildServiceClientImpl : BuildServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListBuildTargetsRequest, ListBuildTargetsResponse> _callListBuildTargets;

        private readonly gaxgrpc::ApiCall<ListModelsRequest, ListModelsResponse> _callListModels;

        private readonly gaxgrpc::ApiCall<ListBuildsRequest, ListBuildsResponse> _callListBuilds;

        private readonly gaxgrpc::ApiCall<CheckBuildStageStatusRequest, CheckBuildStageStatusResponse> _callCheckBuildStageStatus;

        private readonly gaxgrpc::ApiCall<StageBuildRequest, lro::Operation> _callStageBuild;

        private readonly gaxgrpc::ApiCall<FindMostStableBuildRequest, FindMostStableBuildResponse> _callFindMostStableBuild;

        /// <summary>
        /// Constructs a client wrapper for the BuildService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="BuildServiceSettings"/> used within this client.</param>
        public BuildServiceClientImpl(BuildService.BuildServiceClient grpcClient, BuildServiceSettings settings)
        {
            GrpcClient = grpcClient;
            BuildServiceSettings effectiveSettings = settings ?? BuildServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            StageBuildOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.StageBuildOperationsSettings);
            _callListBuildTargets = clientHelper.BuildApiCall<ListBuildTargetsRequest, ListBuildTargetsResponse>(grpcClient.ListBuildTargetsAsync, grpcClient.ListBuildTargets, effectiveSettings.ListBuildTargetsSettings);
            Modify_ApiCall(ref _callListBuildTargets);
            Modify_ListBuildTargetsApiCall(ref _callListBuildTargets);
            _callListModels = clientHelper.BuildApiCall<ListModelsRequest, ListModelsResponse>(grpcClient.ListModelsAsync, grpcClient.ListModels, effectiveSettings.ListModelsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListModels);
            Modify_ListModelsApiCall(ref _callListModels);
            _callListBuilds = clientHelper.BuildApiCall<ListBuildsRequest, ListBuildsResponse>(grpcClient.ListBuildsAsync, grpcClient.ListBuilds, effectiveSettings.ListBuildsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListBuilds);
            Modify_ListBuildsApiCall(ref _callListBuilds);
            _callCheckBuildStageStatus = clientHelper.BuildApiCall<CheckBuildStageStatusRequest, CheckBuildStageStatusResponse>(grpcClient.CheckBuildStageStatusAsync, grpcClient.CheckBuildStageStatus, effectiveSettings.CheckBuildStageStatusSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callCheckBuildStageStatus);
            Modify_CheckBuildStageStatusApiCall(ref _callCheckBuildStageStatus);
            _callStageBuild = clientHelper.BuildApiCall<StageBuildRequest, lro::Operation>(grpcClient.StageBuildAsync, grpcClient.StageBuild, effectiveSettings.StageBuildSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callStageBuild);
            Modify_StageBuildApiCall(ref _callStageBuild);
            _callFindMostStableBuild = clientHelper.BuildApiCall<FindMostStableBuildRequest, FindMostStableBuildResponse>(grpcClient.FindMostStableBuildAsync, grpcClient.FindMostStableBuild, effectiveSettings.FindMostStableBuildSettings).WithGoogleRequestParam("build_target", request => request.BuildTarget);
            Modify_ApiCall(ref _callFindMostStableBuild);
            Modify_FindMostStableBuildApiCall(ref _callFindMostStableBuild);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListBuildTargetsApiCall(ref gaxgrpc::ApiCall<ListBuildTargetsRequest, ListBuildTargetsResponse> call);

        partial void Modify_ListModelsApiCall(ref gaxgrpc::ApiCall<ListModelsRequest, ListModelsResponse> call);

        partial void Modify_ListBuildsApiCall(ref gaxgrpc::ApiCall<ListBuildsRequest, ListBuildsResponse> call);

        partial void Modify_CheckBuildStageStatusApiCall(ref gaxgrpc::ApiCall<CheckBuildStageStatusRequest, CheckBuildStageStatusResponse> call);

        partial void Modify_StageBuildApiCall(ref gaxgrpc::ApiCall<StageBuildRequest, lro::Operation> call);

        partial void Modify_FindMostStableBuildApiCall(ref gaxgrpc::ApiCall<FindMostStableBuildRequest, FindMostStableBuildResponse> call);

        partial void OnConstruction(BuildService.BuildServiceClient grpcClient, BuildServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC BuildService client</summary>
        public override BuildService.BuildServiceClient GrpcClient { get; }

        partial void Modify_ListBuildTargetsRequest(ref ListBuildTargetsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListModelsRequest(ref ListModelsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListBuildsRequest(ref ListBuildsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CheckBuildStageStatusRequest(ref CheckBuildStageStatusRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StageBuildRequest(ref StageBuildRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_FindMostStableBuildRequest(ref FindMostStableBuildRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists all build targets that a user has access to.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="BuildTarget"/> resources.</returns>
        public override gax::PagedEnumerable<ListBuildTargetsResponse, BuildTarget> ListBuildTargets(ListBuildTargetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBuildTargetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListBuildTargetsRequest, ListBuildTargetsResponse, BuildTarget>(_callListBuildTargets, request, callSettings);
        }

        /// <summary>
        /// Lists all build targets that a user has access to.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="BuildTarget"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListBuildTargetsResponse, BuildTarget> ListBuildTargetsAsync(ListBuildTargetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBuildTargetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListBuildTargetsRequest, ListBuildTargetsResponse, BuildTarget>(_callListBuildTargets, request, callSettings);
        }

        /// <summary>
        /// Lists all models for the given build target.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Model"/> resources.</returns>
        public override gax::PagedEnumerable<ListModelsResponse, Model> ListModels(ListModelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListModelsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListModelsRequest, ListModelsResponse, Model>(_callListModels, request, callSettings);
        }

        /// <summary>
        /// Lists all models for the given build target.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Model"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListModelsResponse, Model> ListModelsAsync(ListModelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListModelsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListModelsRequest, ListModelsResponse, Model>(_callListModels, request, callSettings);
        }

        /// <summary>
        /// Lists all builds for the given build target and model in descending order
        /// for the milestones and build versions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Build"/> resources.</returns>
        public override gax::PagedEnumerable<ListBuildsResponse, Build> ListBuilds(ListBuildsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBuildsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListBuildsRequest, ListBuildsResponse, Build>(_callListBuilds, request, callSettings);
        }

        /// <summary>
        /// Lists all builds for the given build target and model in descending order
        /// for the milestones and build versions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Build"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListBuildsResponse, Build> ListBuildsAsync(ListBuildsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBuildsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListBuildsRequest, ListBuildsResponse, Build>(_callListBuilds, request, callSettings);
        }

        /// <summary>
        /// Checks the stage status for a given build artifact in a partner Google
        /// Cloud Storage bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CheckBuildStageStatusResponse CheckBuildStageStatus(CheckBuildStageStatusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CheckBuildStageStatusRequest(ref request, ref callSettings);
            return _callCheckBuildStageStatus.Sync(request, callSettings);
        }

        /// <summary>
        /// Checks the stage status for a given build artifact in a partner Google
        /// Cloud Storage bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CheckBuildStageStatusResponse> CheckBuildStageStatusAsync(CheckBuildStageStatusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CheckBuildStageStatusRequest(ref request, ref callSettings);
            return _callCheckBuildStageStatus.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>StageBuild</c>.</summary>
        public override lro::OperationsClient StageBuildOperationsClient { get; }

        /// <summary>
        /// Stages a given build artifact from a internal Google Cloud Storage bucket
        /// to a partner Google Cloud Storage bucket. If any of objects has already
        /// been copied, it will overwrite the previous objects. Operation &amp;lt;response:
        /// [StageBuildResponse][google.chromeos.moblab.v1beta1.StageBuildResponse],
        /// metadata: [StageBuildMetadata][google.chromeos.moblab.v1beta1.StageBuildMetadata]&amp;gt;
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<StageBuildResponse, StageBuildMetadata> StageBuild(StageBuildRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StageBuildRequest(ref request, ref callSettings);
            return new lro::Operation<StageBuildResponse, StageBuildMetadata>(_callStageBuild.Sync(request, callSettings), StageBuildOperationsClient);
        }

        /// <summary>
        /// Stages a given build artifact from a internal Google Cloud Storage bucket
        /// to a partner Google Cloud Storage bucket. If any of objects has already
        /// been copied, it will overwrite the previous objects. Operation &amp;lt;response:
        /// [StageBuildResponse][google.chromeos.moblab.v1beta1.StageBuildResponse],
        /// metadata: [StageBuildMetadata][google.chromeos.moblab.v1beta1.StageBuildMetadata]&amp;gt;
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<StageBuildResponse, StageBuildMetadata>> StageBuildAsync(StageBuildRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StageBuildRequest(ref request, ref callSettings);
            return new lro::Operation<StageBuildResponse, StageBuildMetadata>(await _callStageBuild.Async(request, callSettings).ConfigureAwait(false), StageBuildOperationsClient);
        }

        /// <summary>
        /// Finds the most stable build for the given build target. The definition of
        /// the most stable build is determined by evaluating the following rules in
        /// order until one is true. If none are true, then there is no stable build
        /// and it will return an empty response.
        /// 
        /// Evaluation rules:
        /// 1. Stable channel build with label “Live”
        /// 2. Beta channel build with label “Live”
        /// 3. Dev channel build with label “Live”
        /// 4. Most recent stable channel build with build status Pass
        /// 5. Most recent beta channel build with build status Pass
        /// 6. Most recent dev channel build with build status Pass
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FindMostStableBuildResponse FindMostStableBuild(FindMostStableBuildRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FindMostStableBuildRequest(ref request, ref callSettings);
            return _callFindMostStableBuild.Sync(request, callSettings);
        }

        /// <summary>
        /// Finds the most stable build for the given build target. The definition of
        /// the most stable build is determined by evaluating the following rules in
        /// order until one is true. If none are true, then there is no stable build
        /// and it will return an empty response.
        /// 
        /// Evaluation rules:
        /// 1. Stable channel build with label “Live”
        /// 2. Beta channel build with label “Live”
        /// 3. Dev channel build with label “Live”
        /// 4. Most recent stable channel build with build status Pass
        /// 5. Most recent beta channel build with build status Pass
        /// 6. Most recent dev channel build with build status Pass
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FindMostStableBuildResponse> FindMostStableBuildAsync(FindMostStableBuildRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FindMostStableBuildRequest(ref request, ref callSettings);
            return _callFindMostStableBuild.Async(request, callSettings);
        }
    }

    public partial class ListBuildTargetsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListModelsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListBuildsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListBuildTargetsResponse : gaxgrpc::IPageResponse<BuildTarget>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<BuildTarget> GetEnumerator() => BuildTargets.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListModelsResponse : gaxgrpc::IPageResponse<Model>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Model> GetEnumerator() => Models.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListBuildsResponse : gaxgrpc::IPageResponse<Build>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Build> GetEnumerator() => Builds.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class BuildService
    {
        public partial class BuildServiceClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClient() =>
                new lro::Operations.OperationsClient(CallInvoker);
        }
    }
}
