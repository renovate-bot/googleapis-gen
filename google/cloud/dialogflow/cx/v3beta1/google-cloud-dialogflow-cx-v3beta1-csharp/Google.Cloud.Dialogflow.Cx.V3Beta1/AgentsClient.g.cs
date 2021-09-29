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
using gagr = Google.Api.Gax.ResourceNames;
using lro = Google.LongRunning;
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

namespace Google.Cloud.Dialogflow.Cx.V3Beta1
{
    /// <summary>Settings for <see cref="AgentsClient"/> instances.</summary>
    public sealed partial class AgentsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AgentsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AgentsSettings"/>.</returns>
        public static AgentsSettings GetDefault() => new AgentsSettings();

        /// <summary>Constructs a new <see cref="AgentsSettings"/> object with default settings.</summary>
        public AgentsSettings()
        {
        }

        private AgentsSettings(AgentsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListAgentsSettings = existing.ListAgentsSettings;
            GetAgentSettings = existing.GetAgentSettings;
            CreateAgentSettings = existing.CreateAgentSettings;
            UpdateAgentSettings = existing.UpdateAgentSettings;
            DeleteAgentSettings = existing.DeleteAgentSettings;
            ExportAgentSettings = existing.ExportAgentSettings;
            ExportAgentOperationsSettings = existing.ExportAgentOperationsSettings.Clone();
            RestoreAgentSettings = existing.RestoreAgentSettings;
            RestoreAgentOperationsSettings = existing.RestoreAgentOperationsSettings.Clone();
            ValidateAgentSettings = existing.ValidateAgentSettings;
            GetAgentValidationResultSettings = existing.GetAgentValidationResultSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AgentsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AgentsClient.ListAgents</c>
        /// and <c>AgentsClient.ListAgentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAgentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AgentsClient.GetAgent</c>
        /// and <c>AgentsClient.GetAgentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAgentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AgentsClient.CreateAgent</c>
        ///  and <c>AgentsClient.CreateAgentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateAgentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AgentsClient.UpdateAgent</c>
        ///  and <c>AgentsClient.UpdateAgentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateAgentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AgentsClient.DeleteAgent</c>
        ///  and <c>AgentsClient.DeleteAgentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteAgentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AgentsClient.ExportAgent</c>
        ///  and <c>AgentsClient.ExportAgentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ExportAgentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AgentsClient.ExportAgent</c> and
        /// <c>AgentsClient.ExportAgentAsync</c>.
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
        public lro::OperationsSettings ExportAgentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AgentsClient.RestoreAgent</c>
        ///  and <c>AgentsClient.RestoreAgentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RestoreAgentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AgentsClient.RestoreAgent</c> and
        /// <c>AgentsClient.RestoreAgentAsync</c>.
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
        public lro::OperationsSettings RestoreAgentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AgentsClient.ValidateAgent</c>
        ///  and <c>AgentsClient.ValidateAgentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ValidateAgentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentsClient.GetAgentValidationResult</c> and <c>AgentsClient.GetAgentValidationResultAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAgentValidationResultSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AgentsSettings"/> object.</returns>
        public AgentsSettings Clone() => new AgentsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AgentsClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class AgentsClientBuilder : gaxgrpc::ClientBuilderBase<AgentsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AgentsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AgentsClientBuilder()
        {
            UseJwtAccessWithScopes = AgentsClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref AgentsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AgentsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AgentsClient Build()
        {
            AgentsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AgentsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AgentsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AgentsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AgentsClient.Create(callInvoker, Settings);
        }

        private async stt::Task<AgentsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AgentsClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => AgentsClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => AgentsClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AgentsClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>Agents client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing [Agents][google.cloud.dialogflow.cx.v3beta1.Agent].
    /// </remarks>
    public abstract partial class AgentsClient
    {
        /// <summary>
        /// The default endpoint for the Agents service, which is a host of "dialogflow.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dialogflow.googleapis.com:443";

        /// <summary>The default Agents scopes.</summary>
        /// <remarks>
        /// The default Agents scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/dialogflow</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/dialogflow",
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
        /// Asynchronously creates a <see cref="AgentsClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="AgentsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AgentsClient"/>.</returns>
        public static stt::Task<AgentsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AgentsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AgentsClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="AgentsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AgentsClient"/>.</returns>
        public static AgentsClient Create() => new AgentsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AgentsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AgentsSettings"/>.</param>
        /// <returns>The created <see cref="AgentsClient"/>.</returns>
        internal static AgentsClient Create(grpccore::CallInvoker callInvoker, AgentsSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Agents.AgentsClient grpcClient = new Agents.AgentsClient(callInvoker);
            return new AgentsClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC Agents client</summary>
        public virtual Agents.AgentsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all agents in the specified location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Agent"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAgentsResponse, Agent> ListAgents(ListAgentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all agents in the specified location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Agent"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAgentsResponse, Agent> ListAgentsAsync(ListAgentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of all agents in the specified location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location to list all agents for.
        /// Format: `projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;`.
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
        /// <returns>A pageable sequence of <see cref="Agent"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAgentsResponse, Agent> ListAgents(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListAgents(new ListAgentsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns the list of all agents in the specified location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location to list all agents for.
        /// Format: `projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Agent"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAgentsResponse, Agent> ListAgentsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListAgentsAsync(new ListAgentsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns the list of all agents in the specified location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location to list all agents for.
        /// Format: `projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;`.
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
        /// <returns>A pageable sequence of <see cref="Agent"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAgentsResponse, Agent> ListAgents(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListAgents(new ListAgentsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns the list of all agents in the specified location.
        /// </summary>
        /// <param name="parent">
        /// Required. The location to list all agents for.
        /// Format: `projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Agent"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAgentsResponse, Agent> ListAgentsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListAgentsAsync(new ListAgentsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Retrieves the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Agent GetAgent(GetAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Agent> GetAgentAsync(GetAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Agent> GetAgentAsync(GetAgentRequest request, st::CancellationToken cancellationToken) =>
            GetAgentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified agent.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the agent.
        /// Format: `projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Agent GetAgent(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAgent(new GetAgentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified agent.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the agent.
        /// Format: `projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Agent> GetAgentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAgentAsync(new GetAgentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified agent.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the agent.
        /// Format: `projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Agent> GetAgentAsync(string name, st::CancellationToken cancellationToken) =>
            GetAgentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified agent.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the agent.
        /// Format: `projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Agent GetAgent(AgentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAgent(new GetAgentRequest
            {
                AgentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified agent.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the agent.
        /// Format: `projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Agent> GetAgentAsync(AgentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAgentAsync(new GetAgentRequest
            {
                AgentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified agent.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the agent.
        /// Format: `projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Agent> GetAgentAsync(AgentName name, st::CancellationToken cancellationToken) =>
            GetAgentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an agent in the specified location.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Agent CreateAgent(CreateAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an agent in the specified location.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Agent> CreateAgentAsync(CreateAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an agent in the specified location.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Agent> CreateAgentAsync(CreateAgentRequest request, st::CancellationToken cancellationToken) =>
            CreateAgentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an agent in the specified location.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The location to create a agent for.
        /// Format: `projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;`.
        /// </param>
        /// <param name="agent">
        /// Required. The agent to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Agent CreateAgent(string parent, Agent agent, gaxgrpc::CallSettings callSettings = null) =>
            CreateAgent(new CreateAgentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Agent = gax::GaxPreconditions.CheckNotNull(agent, nameof(agent)),
            }, callSettings);

        /// <summary>
        /// Creates an agent in the specified location.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The location to create a agent for.
        /// Format: `projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;`.
        /// </param>
        /// <param name="agent">
        /// Required. The agent to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Agent> CreateAgentAsync(string parent, Agent agent, gaxgrpc::CallSettings callSettings = null) =>
            CreateAgentAsync(new CreateAgentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Agent = gax::GaxPreconditions.CheckNotNull(agent, nameof(agent)),
            }, callSettings);

        /// <summary>
        /// Creates an agent in the specified location.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The location to create a agent for.
        /// Format: `projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;`.
        /// </param>
        /// <param name="agent">
        /// Required. The agent to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Agent> CreateAgentAsync(string parent, Agent agent, st::CancellationToken cancellationToken) =>
            CreateAgentAsync(parent, agent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an agent in the specified location.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The location to create a agent for.
        /// Format: `projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;`.
        /// </param>
        /// <param name="agent">
        /// Required. The agent to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Agent CreateAgent(gagr::LocationName parent, Agent agent, gaxgrpc::CallSettings callSettings = null) =>
            CreateAgent(new CreateAgentRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Agent = gax::GaxPreconditions.CheckNotNull(agent, nameof(agent)),
            }, callSettings);

        /// <summary>
        /// Creates an agent in the specified location.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The location to create a agent for.
        /// Format: `projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;`.
        /// </param>
        /// <param name="agent">
        /// Required. The agent to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Agent> CreateAgentAsync(gagr::LocationName parent, Agent agent, gaxgrpc::CallSettings callSettings = null) =>
            CreateAgentAsync(new CreateAgentRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Agent = gax::GaxPreconditions.CheckNotNull(agent, nameof(agent)),
            }, callSettings);

        /// <summary>
        /// Creates an agent in the specified location.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The location to create a agent for.
        /// Format: `projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;`.
        /// </param>
        /// <param name="agent">
        /// Required. The agent to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Agent> CreateAgentAsync(gagr::LocationName parent, Agent agent, st::CancellationToken cancellationToken) =>
            CreateAgentAsync(parent, agent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified agent.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Agent UpdateAgent(UpdateAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified agent.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Agent> UpdateAgentAsync(UpdateAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified agent.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Agent> UpdateAgentAsync(UpdateAgentRequest request, st::CancellationToken cancellationToken) =>
            UpdateAgentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified agent.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="agent">
        /// Required. The agent to update.
        /// </param>
        /// <param name="updateMask">
        /// The mask to control which fields get updated. If the mask is not present,
        /// all fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Agent UpdateAgent(Agent agent, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAgent(new UpdateAgentRequest
            {
                Agent = gax::GaxPreconditions.CheckNotNull(agent, nameof(agent)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the specified agent.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="agent">
        /// Required. The agent to update.
        /// </param>
        /// <param name="updateMask">
        /// The mask to control which fields get updated. If the mask is not present,
        /// all fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Agent> UpdateAgentAsync(Agent agent, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAgentAsync(new UpdateAgentRequest
            {
                Agent = gax::GaxPreconditions.CheckNotNull(agent, nameof(agent)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the specified agent.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="agent">
        /// Required. The agent to update.
        /// </param>
        /// <param name="updateMask">
        /// The mask to control which fields get updated. If the mask is not present,
        /// all fields will be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Agent> UpdateAgentAsync(Agent agent, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateAgentAsync(agent, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAgent(DeleteAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAgentAsync(DeleteAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAgentAsync(DeleteAgentRequest request, st::CancellationToken cancellationToken) =>
            DeleteAgentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified agent.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the agent to delete.
        /// Format: `projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAgent(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAgent(new DeleteAgentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified agent.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the agent to delete.
        /// Format: `projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAgentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAgentAsync(new DeleteAgentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified agent.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the agent to delete.
        /// Format: `projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAgentAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteAgentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified agent.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the agent to delete.
        /// Format: `projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAgent(AgentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAgent(new DeleteAgentRequest
            {
                AgentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified agent.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the agent to delete.
        /// Format: `projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAgentAsync(AgentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAgentAsync(new DeleteAgentRequest
            {
                AgentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified agent.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the agent to delete.
        /// Format: `projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent ID&amp;gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAgentAsync(AgentName name, st::CancellationToken cancellationToken) =>
            DeleteAgentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Exports the specified agent to a binary file.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: [ExportAgentResponse][google.cloud.dialogflow.cx.v3beta1.ExportAgentResponse]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportAgentResponse, wkt::Struct> ExportAgent(ExportAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports the specified agent to a binary file.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: [ExportAgentResponse][google.cloud.dialogflow.cx.v3beta1.ExportAgentResponse]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportAgentResponse, wkt::Struct>> ExportAgentAsync(ExportAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports the specified agent to a binary file.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: [ExportAgentResponse][google.cloud.dialogflow.cx.v3beta1.ExportAgentResponse]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportAgentResponse, wkt::Struct>> ExportAgentAsync(ExportAgentRequest request, st::CancellationToken cancellationToken) =>
            ExportAgentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ExportAgent</c>.</summary>
        public virtual lro::OperationsClient ExportAgentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ExportAgent</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ExportAgentResponse, wkt::Struct> PollOnceExportAgent(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportAgentResponse, wkt::Struct>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportAgentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ExportAgent</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ExportAgentResponse, wkt::Struct>> PollOnceExportAgentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportAgentResponse, wkt::Struct>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportAgentOperationsClient, callSettings);

        /// <summary>
        /// Restores the specified agent from a binary file.
        /// 
        /// Replaces the current agent with a new one. Note that all existing resources
        /// in agent (e.g. intents, entity types, flows) will be removed.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, wkt::Struct> RestoreAgent(RestoreAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Restores the specified agent from a binary file.
        /// 
        /// Replaces the current agent with a new one. Note that all existing resources
        /// in agent (e.g. intents, entity types, flows) will be removed.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> RestoreAgentAsync(RestoreAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Restores the specified agent from a binary file.
        /// 
        /// Replaces the current agent with a new one. Note that all existing resources
        /// in agent (e.g. intents, entity types, flows) will be removed.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> RestoreAgentAsync(RestoreAgentRequest request, st::CancellationToken cancellationToken) =>
            RestoreAgentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RestoreAgent</c>.</summary>
        public virtual lro::OperationsClient RestoreAgentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RestoreAgent</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, wkt::Struct> PollOnceRestoreAgent(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, wkt::Struct>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RestoreAgentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RestoreAgent</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> PollOnceRestoreAgentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, wkt::Struct>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RestoreAgentOperationsClient, callSettings);

        /// <summary>
        /// Validates the specified agent and creates or updates validation results.
        /// The agent in draft version is validated. Please call this API after the
        /// training is completed to get the complete validation results.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AgentValidationResult ValidateAgent(ValidateAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Validates the specified agent and creates or updates validation results.
        /// The agent in draft version is validated. Please call this API after the
        /// training is completed to get the complete validation results.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AgentValidationResult> ValidateAgentAsync(ValidateAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Validates the specified agent and creates or updates validation results.
        /// The agent in draft version is validated. Please call this API after the
        /// training is completed to get the complete validation results.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AgentValidationResult> ValidateAgentAsync(ValidateAgentRequest request, st::CancellationToken cancellationToken) =>
            ValidateAgentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the latest agent validation result. Agent validation is performed
        /// when ValidateAgent is called.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AgentValidationResult GetAgentValidationResult(GetAgentValidationResultRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the latest agent validation result. Agent validation is performed
        /// when ValidateAgent is called.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AgentValidationResult> GetAgentValidationResultAsync(GetAgentValidationResultRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the latest agent validation result. Agent validation is performed
        /// when ValidateAgent is called.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AgentValidationResult> GetAgentValidationResultAsync(GetAgentValidationResultRequest request, st::CancellationToken cancellationToken) =>
            GetAgentValidationResultAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the latest agent validation result. Agent validation is performed
        /// when ValidateAgent is called.
        /// </summary>
        /// <param name="name">
        /// Required. The agent name.
        /// Format: `projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent
        /// ID&amp;gt;/validationResult`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AgentValidationResult GetAgentValidationResult(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAgentValidationResult(new GetAgentValidationResultRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the latest agent validation result. Agent validation is performed
        /// when ValidateAgent is called.
        /// </summary>
        /// <param name="name">
        /// Required. The agent name.
        /// Format: `projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent
        /// ID&amp;gt;/validationResult`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AgentValidationResult> GetAgentValidationResultAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAgentValidationResultAsync(new GetAgentValidationResultRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the latest agent validation result. Agent validation is performed
        /// when ValidateAgent is called.
        /// </summary>
        /// <param name="name">
        /// Required. The agent name.
        /// Format: `projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent
        /// ID&amp;gt;/validationResult`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AgentValidationResult> GetAgentValidationResultAsync(string name, st::CancellationToken cancellationToken) =>
            GetAgentValidationResultAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the latest agent validation result. Agent validation is performed
        /// when ValidateAgent is called.
        /// </summary>
        /// <param name="name">
        /// Required. The agent name.
        /// Format: `projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent
        /// ID&amp;gt;/validationResult`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AgentValidationResult GetAgentValidationResult(AgentValidationResultName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAgentValidationResult(new GetAgentValidationResultRequest
            {
                AgentValidationResultName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the latest agent validation result. Agent validation is performed
        /// when ValidateAgent is called.
        /// </summary>
        /// <param name="name">
        /// Required. The agent name.
        /// Format: `projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent
        /// ID&amp;gt;/validationResult`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AgentValidationResult> GetAgentValidationResultAsync(AgentValidationResultName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAgentValidationResultAsync(new GetAgentValidationResultRequest
            {
                AgentValidationResultName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the latest agent validation result. Agent validation is performed
        /// when ValidateAgent is called.
        /// </summary>
        /// <param name="name">
        /// Required. The agent name.
        /// Format: `projects/&amp;lt;Project ID&amp;gt;/locations/&amp;lt;Location ID&amp;gt;/agents/&amp;lt;Agent
        /// ID&amp;gt;/validationResult`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AgentValidationResult> GetAgentValidationResultAsync(AgentValidationResultName name, st::CancellationToken cancellationToken) =>
            GetAgentValidationResultAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Agents client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing [Agents][google.cloud.dialogflow.cx.v3beta1.Agent].
    /// </remarks>
    public sealed partial class AgentsClientImpl : AgentsClient
    {
        private readonly gaxgrpc::ApiCall<ListAgentsRequest, ListAgentsResponse> _callListAgents;

        private readonly gaxgrpc::ApiCall<GetAgentRequest, Agent> _callGetAgent;

        private readonly gaxgrpc::ApiCall<CreateAgentRequest, Agent> _callCreateAgent;

        private readonly gaxgrpc::ApiCall<UpdateAgentRequest, Agent> _callUpdateAgent;

        private readonly gaxgrpc::ApiCall<DeleteAgentRequest, wkt::Empty> _callDeleteAgent;

        private readonly gaxgrpc::ApiCall<ExportAgentRequest, lro::Operation> _callExportAgent;

        private readonly gaxgrpc::ApiCall<RestoreAgentRequest, lro::Operation> _callRestoreAgent;

        private readonly gaxgrpc::ApiCall<ValidateAgentRequest, AgentValidationResult> _callValidateAgent;

        private readonly gaxgrpc::ApiCall<GetAgentValidationResultRequest, AgentValidationResult> _callGetAgentValidationResult;

        /// <summary>
        /// Constructs a client wrapper for the Agents service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AgentsSettings"/> used within this client.</param>
        public AgentsClientImpl(Agents.AgentsClient grpcClient, AgentsSettings settings)
        {
            GrpcClient = grpcClient;
            AgentsSettings effectiveSettings = settings ?? AgentsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            ExportAgentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ExportAgentOperationsSettings);
            RestoreAgentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RestoreAgentOperationsSettings);
            _callListAgents = clientHelper.BuildApiCall<ListAgentsRequest, ListAgentsResponse>(grpcClient.ListAgentsAsync, grpcClient.ListAgents, effectiveSettings.ListAgentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAgents);
            Modify_ListAgentsApiCall(ref _callListAgents);
            _callGetAgent = clientHelper.BuildApiCall<GetAgentRequest, Agent>(grpcClient.GetAgentAsync, grpcClient.GetAgent, effectiveSettings.GetAgentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAgent);
            Modify_GetAgentApiCall(ref _callGetAgent);
            _callCreateAgent = clientHelper.BuildApiCall<CreateAgentRequest, Agent>(grpcClient.CreateAgentAsync, grpcClient.CreateAgent, effectiveSettings.CreateAgentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateAgent);
            Modify_CreateAgentApiCall(ref _callCreateAgent);
            _callUpdateAgent = clientHelper.BuildApiCall<UpdateAgentRequest, Agent>(grpcClient.UpdateAgentAsync, grpcClient.UpdateAgent, effectiveSettings.UpdateAgentSettings).WithGoogleRequestParam("agent.name", request => request.Agent?.Name);
            Modify_ApiCall(ref _callUpdateAgent);
            Modify_UpdateAgentApiCall(ref _callUpdateAgent);
            _callDeleteAgent = clientHelper.BuildApiCall<DeleteAgentRequest, wkt::Empty>(grpcClient.DeleteAgentAsync, grpcClient.DeleteAgent, effectiveSettings.DeleteAgentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteAgent);
            Modify_DeleteAgentApiCall(ref _callDeleteAgent);
            _callExportAgent = clientHelper.BuildApiCall<ExportAgentRequest, lro::Operation>(grpcClient.ExportAgentAsync, grpcClient.ExportAgent, effectiveSettings.ExportAgentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callExportAgent);
            Modify_ExportAgentApiCall(ref _callExportAgent);
            _callRestoreAgent = clientHelper.BuildApiCall<RestoreAgentRequest, lro::Operation>(grpcClient.RestoreAgentAsync, grpcClient.RestoreAgent, effectiveSettings.RestoreAgentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRestoreAgent);
            Modify_RestoreAgentApiCall(ref _callRestoreAgent);
            _callValidateAgent = clientHelper.BuildApiCall<ValidateAgentRequest, AgentValidationResult>(grpcClient.ValidateAgentAsync, grpcClient.ValidateAgent, effectiveSettings.ValidateAgentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callValidateAgent);
            Modify_ValidateAgentApiCall(ref _callValidateAgent);
            _callGetAgentValidationResult = clientHelper.BuildApiCall<GetAgentValidationResultRequest, AgentValidationResult>(grpcClient.GetAgentValidationResultAsync, grpcClient.GetAgentValidationResult, effectiveSettings.GetAgentValidationResultSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAgentValidationResult);
            Modify_GetAgentValidationResultApiCall(ref _callGetAgentValidationResult);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListAgentsApiCall(ref gaxgrpc::ApiCall<ListAgentsRequest, ListAgentsResponse> call);

        partial void Modify_GetAgentApiCall(ref gaxgrpc::ApiCall<GetAgentRequest, Agent> call);

        partial void Modify_CreateAgentApiCall(ref gaxgrpc::ApiCall<CreateAgentRequest, Agent> call);

        partial void Modify_UpdateAgentApiCall(ref gaxgrpc::ApiCall<UpdateAgentRequest, Agent> call);

        partial void Modify_DeleteAgentApiCall(ref gaxgrpc::ApiCall<DeleteAgentRequest, wkt::Empty> call);

        partial void Modify_ExportAgentApiCall(ref gaxgrpc::ApiCall<ExportAgentRequest, lro::Operation> call);

        partial void Modify_RestoreAgentApiCall(ref gaxgrpc::ApiCall<RestoreAgentRequest, lro::Operation> call);

        partial void Modify_ValidateAgentApiCall(ref gaxgrpc::ApiCall<ValidateAgentRequest, AgentValidationResult> call);

        partial void Modify_GetAgentValidationResultApiCall(ref gaxgrpc::ApiCall<GetAgentValidationResultRequest, AgentValidationResult> call);

        partial void OnConstruction(Agents.AgentsClient grpcClient, AgentsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Agents client</summary>
        public override Agents.AgentsClient GrpcClient { get; }

        partial void Modify_ListAgentsRequest(ref ListAgentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAgentRequest(ref GetAgentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateAgentRequest(ref CreateAgentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateAgentRequest(ref UpdateAgentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteAgentRequest(ref DeleteAgentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ExportAgentRequest(ref ExportAgentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RestoreAgentRequest(ref RestoreAgentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ValidateAgentRequest(ref ValidateAgentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAgentValidationResultRequest(ref GetAgentValidationResultRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the list of all agents in the specified location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Agent"/> resources.</returns>
        public override gax::PagedEnumerable<ListAgentsResponse, Agent> ListAgents(ListAgentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAgentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAgentsRequest, ListAgentsResponse, Agent>(_callListAgents, request, callSettings);
        }

        /// <summary>
        /// Returns the list of all agents in the specified location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Agent"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAgentsResponse, Agent> ListAgentsAsync(ListAgentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAgentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAgentsRequest, ListAgentsResponse, Agent>(_callListAgents, request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Agent GetAgent(GetAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAgentRequest(ref request, ref callSettings);
            return _callGetAgent.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Agent> GetAgentAsync(GetAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAgentRequest(ref request, ref callSettings);
            return _callGetAgent.Async(request, callSettings);
        }

        /// <summary>
        /// Creates an agent in the specified location.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Agent CreateAgent(CreateAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAgentRequest(ref request, ref callSettings);
            return _callCreateAgent.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates an agent in the specified location.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Agent> CreateAgentAsync(CreateAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAgentRequest(ref request, ref callSettings);
            return _callCreateAgent.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the specified agent.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Agent UpdateAgent(UpdateAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAgentRequest(ref request, ref callSettings);
            return _callUpdateAgent.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the specified agent.
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Agent> UpdateAgentAsync(UpdateAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAgentRequest(ref request, ref callSettings);
            return _callUpdateAgent.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteAgent(DeleteAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAgentRequest(ref request, ref callSettings);
            _callDeleteAgent.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteAgentAsync(DeleteAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAgentRequest(ref request, ref callSettings);
            return _callDeleteAgent.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>ExportAgent</c>.</summary>
        public override lro::OperationsClient ExportAgentOperationsClient { get; }

        /// <summary>
        /// Exports the specified agent to a binary file.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: [ExportAgentResponse][google.cloud.dialogflow.cx.v3beta1.ExportAgentResponse]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ExportAgentResponse, wkt::Struct> ExportAgent(ExportAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportAgentRequest(ref request, ref callSettings);
            return new lro::Operation<ExportAgentResponse, wkt::Struct>(_callExportAgent.Sync(request, callSettings), ExportAgentOperationsClient);
        }

        /// <summary>
        /// Exports the specified agent to a binary file.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: [ExportAgentResponse][google.cloud.dialogflow.cx.v3beta1.ExportAgentResponse]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ExportAgentResponse, wkt::Struct>> ExportAgentAsync(ExportAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportAgentRequest(ref request, ref callSettings);
            return new lro::Operation<ExportAgentResponse, wkt::Struct>(await _callExportAgent.Async(request, callSettings).ConfigureAwait(false), ExportAgentOperationsClient);
        }

        /// <summary>The long-running operations client for <c>RestoreAgent</c>.</summary>
        public override lro::OperationsClient RestoreAgentOperationsClient { get; }

        /// <summary>
        /// Restores the specified agent from a binary file.
        /// 
        /// Replaces the current agent with a new one. Note that all existing resources
        /// in agent (e.g. intents, entity types, flows) will be removed.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, wkt::Struct> RestoreAgent(RestoreAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RestoreAgentRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, wkt::Struct>(_callRestoreAgent.Sync(request, callSettings), RestoreAgentOperationsClient);
        }

        /// <summary>
        /// Restores the specified agent from a binary file.
        /// 
        /// Replaces the current agent with a new one. Note that all existing resources
        /// in agent (e.g. intents, entity types, flows) will be removed.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/cx/docs/how/long-running-operation).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train a flow prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/cx/docs/concept/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> RestoreAgentAsync(RestoreAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RestoreAgentRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, wkt::Struct>(await _callRestoreAgent.Async(request, callSettings).ConfigureAwait(false), RestoreAgentOperationsClient);
        }

        /// <summary>
        /// Validates the specified agent and creates or updates validation results.
        /// The agent in draft version is validated. Please call this API after the
        /// training is completed to get the complete validation results.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AgentValidationResult ValidateAgent(ValidateAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ValidateAgentRequest(ref request, ref callSettings);
            return _callValidateAgent.Sync(request, callSettings);
        }

        /// <summary>
        /// Validates the specified agent and creates or updates validation results.
        /// The agent in draft version is validated. Please call this API after the
        /// training is completed to get the complete validation results.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AgentValidationResult> ValidateAgentAsync(ValidateAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ValidateAgentRequest(ref request, ref callSettings);
            return _callValidateAgent.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the latest agent validation result. Agent validation is performed
        /// when ValidateAgent is called.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AgentValidationResult GetAgentValidationResult(GetAgentValidationResultRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAgentValidationResultRequest(ref request, ref callSettings);
            return _callGetAgentValidationResult.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the latest agent validation result. Agent validation is performed
        /// when ValidateAgent is called.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AgentValidationResult> GetAgentValidationResultAsync(GetAgentValidationResultRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAgentValidationResultRequest(ref request, ref callSettings);
            return _callGetAgentValidationResult.Async(request, callSettings);
        }
    }

    public partial class ListAgentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAgentsResponse : gaxgrpc::IPageResponse<Agent>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Agent> GetEnumerator() => Agents.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class Agents
    {
        public partial class AgentsClient
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
