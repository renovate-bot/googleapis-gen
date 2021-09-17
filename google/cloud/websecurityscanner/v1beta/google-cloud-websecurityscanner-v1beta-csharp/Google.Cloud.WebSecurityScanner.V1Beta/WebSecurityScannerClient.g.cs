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

namespace Google.Cloud.WebSecurityScanner.V1Beta
{
    /// <summary>Settings for <see cref="WebSecurityScannerClient"/> instances.</summary>
    public sealed partial class WebSecurityScannerSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="WebSecurityScannerSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="WebSecurityScannerSettings"/>.</returns>
        public static WebSecurityScannerSettings GetDefault() => new WebSecurityScannerSettings();

        /// <summary>Constructs a new <see cref="WebSecurityScannerSettings"/> object with default settings.</summary>
        public WebSecurityScannerSettings()
        {
        }

        private WebSecurityScannerSettings(WebSecurityScannerSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateScanConfigSettings = existing.CreateScanConfigSettings;
            DeleteScanConfigSettings = existing.DeleteScanConfigSettings;
            GetScanConfigSettings = existing.GetScanConfigSettings;
            ListScanConfigsSettings = existing.ListScanConfigsSettings;
            UpdateScanConfigSettings = existing.UpdateScanConfigSettings;
            StartScanRunSettings = existing.StartScanRunSettings;
            GetScanRunSettings = existing.GetScanRunSettings;
            ListScanRunsSettings = existing.ListScanRunsSettings;
            StopScanRunSettings = existing.StopScanRunSettings;
            ListCrawledUrlsSettings = existing.ListCrawledUrlsSettings;
            GetFindingSettings = existing.GetFindingSettings;
            ListFindingsSettings = existing.ListFindingsSettings;
            ListFindingTypeStatsSettings = existing.ListFindingTypeStatsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(WebSecurityScannerSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WebSecurityScannerClient.CreateScanConfig</c> and <c>WebSecurityScannerClient.CreateScanConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateScanConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WebSecurityScannerClient.DeleteScanConfig</c> and <c>WebSecurityScannerClient.DeleteScanConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteScanConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WebSecurityScannerClient.GetScanConfig</c> and <c>WebSecurityScannerClient.GetScanConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetScanConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WebSecurityScannerClient.ListScanConfigs</c> and <c>WebSecurityScannerClient.ListScanConfigsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListScanConfigsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WebSecurityScannerClient.UpdateScanConfig</c> and <c>WebSecurityScannerClient.UpdateScanConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateScanConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WebSecurityScannerClient.StartScanRun</c> and <c>WebSecurityScannerClient.StartScanRunAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StartScanRunSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WebSecurityScannerClient.GetScanRun</c> and <c>WebSecurityScannerClient.GetScanRunAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetScanRunSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WebSecurityScannerClient.ListScanRuns</c> and <c>WebSecurityScannerClient.ListScanRunsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListScanRunsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WebSecurityScannerClient.StopScanRun</c> and <c>WebSecurityScannerClient.StopScanRunAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StopScanRunSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WebSecurityScannerClient.ListCrawledUrls</c> and <c>WebSecurityScannerClient.ListCrawledUrlsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListCrawledUrlsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WebSecurityScannerClient.GetFinding</c> and <c>WebSecurityScannerClient.GetFindingAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetFindingSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WebSecurityScannerClient.ListFindings</c> and <c>WebSecurityScannerClient.ListFindingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListFindingsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WebSecurityScannerClient.ListFindingTypeStats</c> and
        /// <c>WebSecurityScannerClient.ListFindingTypeStatsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListFindingTypeStatsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="WebSecurityScannerSettings"/> object.</returns>
        public WebSecurityScannerSettings Clone() => new WebSecurityScannerSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="WebSecurityScannerClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class WebSecurityScannerClientBuilder : gaxgrpc::ClientBuilderBase<WebSecurityScannerClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public WebSecurityScannerSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public WebSecurityScannerClientBuilder()
        {
            UseJwtAccessWithScopes = WebSecurityScannerClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref WebSecurityScannerClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<WebSecurityScannerClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override WebSecurityScannerClient Build()
        {
            WebSecurityScannerClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<WebSecurityScannerClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<WebSecurityScannerClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private WebSecurityScannerClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return WebSecurityScannerClient.Create(callInvoker, Settings);
        }

        private async stt::Task<WebSecurityScannerClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return WebSecurityScannerClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => WebSecurityScannerClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => WebSecurityScannerClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => WebSecurityScannerClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>WebSecurityScanner client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Cloud Web Security Scanner Service identifies security vulnerabilities in web
    /// applications hosted on Google Cloud Platform. It crawls your application, and
    /// attempts to exercise as many user inputs and event handlers as possible.
    /// </remarks>
    public abstract partial class WebSecurityScannerClient
    {
        /// <summary>
        /// The default endpoint for the WebSecurityScanner service, which is a host of
        /// "websecurityscanner.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "websecurityscanner.googleapis.com:443";

        /// <summary>The default WebSecurityScanner scopes.</summary>
        /// <remarks>
        /// The default WebSecurityScanner scopes are:
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
        /// Asynchronously creates a <see cref="WebSecurityScannerClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="WebSecurityScannerClientBuilder"/>
        /// .
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="WebSecurityScannerClient"/>.</returns>
        public static stt::Task<WebSecurityScannerClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new WebSecurityScannerClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="WebSecurityScannerClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="WebSecurityScannerClientBuilder"/>
        /// .
        /// </summary>
        /// <returns>The created <see cref="WebSecurityScannerClient"/>.</returns>
        public static WebSecurityScannerClient Create() => new WebSecurityScannerClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="WebSecurityScannerClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="WebSecurityScannerSettings"/>.</param>
        /// <returns>The created <see cref="WebSecurityScannerClient"/>.</returns>
        internal static WebSecurityScannerClient Create(grpccore::CallInvoker callInvoker, WebSecurityScannerSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            WebSecurityScanner.WebSecurityScannerClient grpcClient = new WebSecurityScanner.WebSecurityScannerClient(callInvoker);
            return new WebSecurityScannerClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC WebSecurityScanner client</summary>
        public virtual WebSecurityScanner.WebSecurityScannerClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new ScanConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ScanConfig CreateScanConfig(CreateScanConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new ScanConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ScanConfig> CreateScanConfigAsync(CreateScanConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new ScanConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ScanConfig> CreateScanConfigAsync(CreateScanConfigRequest request, st::CancellationToken cancellationToken) =>
            CreateScanConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new ScanConfig.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name where the scan is created, which should be a
        /// project resource name in the format 'projects/{projectId}'.
        /// </param>
        /// <param name="scanConfig">
        /// Required. The ScanConfig to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ScanConfig CreateScanConfig(string parent, ScanConfig scanConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateScanConfig(new CreateScanConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ScanConfig = gax::GaxPreconditions.CheckNotNull(scanConfig, nameof(scanConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new ScanConfig.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name where the scan is created, which should be a
        /// project resource name in the format 'projects/{projectId}'.
        /// </param>
        /// <param name="scanConfig">
        /// Required. The ScanConfig to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ScanConfig> CreateScanConfigAsync(string parent, ScanConfig scanConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateScanConfigAsync(new CreateScanConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ScanConfig = gax::GaxPreconditions.CheckNotNull(scanConfig, nameof(scanConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new ScanConfig.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name where the scan is created, which should be a
        /// project resource name in the format 'projects/{projectId}'.
        /// </param>
        /// <param name="scanConfig">
        /// Required. The ScanConfig to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ScanConfig> CreateScanConfigAsync(string parent, ScanConfig scanConfig, st::CancellationToken cancellationToken) =>
            CreateScanConfigAsync(parent, scanConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new ScanConfig.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name where the scan is created, which should be a
        /// project resource name in the format 'projects/{projectId}'.
        /// </param>
        /// <param name="scanConfig">
        /// Required. The ScanConfig to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ScanConfig CreateScanConfig(gagr::ProjectName parent, ScanConfig scanConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateScanConfig(new CreateScanConfigRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ScanConfig = gax::GaxPreconditions.CheckNotNull(scanConfig, nameof(scanConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new ScanConfig.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name where the scan is created, which should be a
        /// project resource name in the format 'projects/{projectId}'.
        /// </param>
        /// <param name="scanConfig">
        /// Required. The ScanConfig to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ScanConfig> CreateScanConfigAsync(gagr::ProjectName parent, ScanConfig scanConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateScanConfigAsync(new CreateScanConfigRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ScanConfig = gax::GaxPreconditions.CheckNotNull(scanConfig, nameof(scanConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new ScanConfig.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name where the scan is created, which should be a
        /// project resource name in the format 'projects/{projectId}'.
        /// </param>
        /// <param name="scanConfig">
        /// Required. The ScanConfig to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ScanConfig> CreateScanConfigAsync(gagr::ProjectName parent, ScanConfig scanConfig, st::CancellationToken cancellationToken) =>
            CreateScanConfigAsync(parent, scanConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an existing ScanConfig and its child resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteScanConfig(DeleteScanConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an existing ScanConfig and its child resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteScanConfigAsync(DeleteScanConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an existing ScanConfig and its child resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteScanConfigAsync(DeleteScanConfigRequest request, st::CancellationToken cancellationToken) =>
            DeleteScanConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an existing ScanConfig and its child resources.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ScanConfig to be deleted. The name follows the
        /// format of 'projects/{projectId}/scanConfigs/{scanConfigId}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteScanConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteScanConfig(new DeleteScanConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an existing ScanConfig and its child resources.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ScanConfig to be deleted. The name follows the
        /// format of 'projects/{projectId}/scanConfigs/{scanConfigId}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteScanConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteScanConfigAsync(new DeleteScanConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an existing ScanConfig and its child resources.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ScanConfig to be deleted. The name follows the
        /// format of 'projects/{projectId}/scanConfigs/{scanConfigId}'.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteScanConfigAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteScanConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an existing ScanConfig and its child resources.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ScanConfig to be deleted. The name follows the
        /// format of 'projects/{projectId}/scanConfigs/{scanConfigId}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteScanConfig(ScanConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteScanConfig(new DeleteScanConfigRequest
            {
                ScanConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an existing ScanConfig and its child resources.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ScanConfig to be deleted. The name follows the
        /// format of 'projects/{projectId}/scanConfigs/{scanConfigId}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteScanConfigAsync(ScanConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteScanConfigAsync(new DeleteScanConfigRequest
            {
                ScanConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an existing ScanConfig and its child resources.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ScanConfig to be deleted. The name follows the
        /// format of 'projects/{projectId}/scanConfigs/{scanConfigId}'.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteScanConfigAsync(ScanConfigName name, st::CancellationToken cancellationToken) =>
            DeleteScanConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a ScanConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ScanConfig GetScanConfig(GetScanConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a ScanConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ScanConfig> GetScanConfigAsync(GetScanConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a ScanConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ScanConfig> GetScanConfigAsync(GetScanConfigRequest request, st::CancellationToken cancellationToken) =>
            GetScanConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a ScanConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ScanConfig to be returned. The name follows the
        /// format of 'projects/{projectId}/scanConfigs/{scanConfigId}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ScanConfig GetScanConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetScanConfig(new GetScanConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a ScanConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ScanConfig to be returned. The name follows the
        /// format of 'projects/{projectId}/scanConfigs/{scanConfigId}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ScanConfig> GetScanConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetScanConfigAsync(new GetScanConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a ScanConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ScanConfig to be returned. The name follows the
        /// format of 'projects/{projectId}/scanConfigs/{scanConfigId}'.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ScanConfig> GetScanConfigAsync(string name, st::CancellationToken cancellationToken) =>
            GetScanConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a ScanConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ScanConfig to be returned. The name follows the
        /// format of 'projects/{projectId}/scanConfigs/{scanConfigId}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ScanConfig GetScanConfig(ScanConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetScanConfig(new GetScanConfigRequest
            {
                ScanConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a ScanConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ScanConfig to be returned. The name follows the
        /// format of 'projects/{projectId}/scanConfigs/{scanConfigId}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ScanConfig> GetScanConfigAsync(ScanConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetScanConfigAsync(new GetScanConfigRequest
            {
                ScanConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a ScanConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ScanConfig to be returned. The name follows the
        /// format of 'projects/{projectId}/scanConfigs/{scanConfigId}'.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ScanConfig> GetScanConfigAsync(ScanConfigName name, st::CancellationToken cancellationToken) =>
            GetScanConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists ScanConfigs under a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ScanConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListScanConfigsResponse, ScanConfig> ListScanConfigs(ListScanConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ScanConfigs under a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ScanConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListScanConfigsResponse, ScanConfig> ListScanConfigsAsync(ListScanConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ScanConfigs under a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, which should be a project resource name in the
        /// format 'projects/{projectId}'.
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
        /// <returns>A pageable sequence of <see cref="ScanConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListScanConfigsResponse, ScanConfig> ListScanConfigs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListScanConfigs(new ListScanConfigsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists ScanConfigs under a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, which should be a project resource name in the
        /// format 'projects/{projectId}'.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ScanConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListScanConfigsResponse, ScanConfig> ListScanConfigsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListScanConfigsAsync(new ListScanConfigsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists ScanConfigs under a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, which should be a project resource name in the
        /// format 'projects/{projectId}'.
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
        /// <returns>A pageable sequence of <see cref="ScanConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListScanConfigsResponse, ScanConfig> ListScanConfigs(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListScanConfigs(new ListScanConfigsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists ScanConfigs under a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, which should be a project resource name in the
        /// format 'projects/{projectId}'.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ScanConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListScanConfigsResponse, ScanConfig> ListScanConfigsAsync(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListScanConfigsAsync(new ListScanConfigsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Updates a ScanConfig. This method support partial update of a ScanConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ScanConfig UpdateScanConfig(UpdateScanConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a ScanConfig. This method support partial update of a ScanConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ScanConfig> UpdateScanConfigAsync(UpdateScanConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a ScanConfig. This method support partial update of a ScanConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ScanConfig> UpdateScanConfigAsync(UpdateScanConfigRequest request, st::CancellationToken cancellationToken) =>
            UpdateScanConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a ScanConfig. This method support partial update of a ScanConfig.
        /// </summary>
        /// <param name="scanConfig">
        /// Required. The ScanConfig to be updated. The name field must be set to identify the
        /// resource to be updated. The values of fields not covered by the mask
        /// will be ignored.
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask applies to the resource. For the `FieldMask` definition,
        /// see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ScanConfig UpdateScanConfig(ScanConfig scanConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateScanConfig(new UpdateScanConfigRequest
            {
                ScanConfig = gax::GaxPreconditions.CheckNotNull(scanConfig, nameof(scanConfig)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a ScanConfig. This method support partial update of a ScanConfig.
        /// </summary>
        /// <param name="scanConfig">
        /// Required. The ScanConfig to be updated. The name field must be set to identify the
        /// resource to be updated. The values of fields not covered by the mask
        /// will be ignored.
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask applies to the resource. For the `FieldMask` definition,
        /// see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ScanConfig> UpdateScanConfigAsync(ScanConfig scanConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateScanConfigAsync(new UpdateScanConfigRequest
            {
                ScanConfig = gax::GaxPreconditions.CheckNotNull(scanConfig, nameof(scanConfig)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a ScanConfig. This method support partial update of a ScanConfig.
        /// </summary>
        /// <param name="scanConfig">
        /// Required. The ScanConfig to be updated. The name field must be set to identify the
        /// resource to be updated. The values of fields not covered by the mask
        /// will be ignored.
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask applies to the resource. For the `FieldMask` definition,
        /// see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ScanConfig> UpdateScanConfigAsync(ScanConfig scanConfig, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateScanConfigAsync(scanConfig, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Start a ScanRun according to the given ScanConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ScanRun StartScanRun(StartScanRunRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Start a ScanRun according to the given ScanConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ScanRun> StartScanRunAsync(StartScanRunRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Start a ScanRun according to the given ScanConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ScanRun> StartScanRunAsync(StartScanRunRequest request, st::CancellationToken cancellationToken) =>
            StartScanRunAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Start a ScanRun according to the given ScanConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ScanConfig to be used. The name follows the
        /// format of 'projects/{projectId}/scanConfigs/{scanConfigId}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ScanRun StartScanRun(string name, gaxgrpc::CallSettings callSettings = null) =>
            StartScanRun(new StartScanRunRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Start a ScanRun according to the given ScanConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ScanConfig to be used. The name follows the
        /// format of 'projects/{projectId}/scanConfigs/{scanConfigId}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ScanRun> StartScanRunAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            StartScanRunAsync(new StartScanRunRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Start a ScanRun according to the given ScanConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ScanConfig to be used. The name follows the
        /// format of 'projects/{projectId}/scanConfigs/{scanConfigId}'.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ScanRun> StartScanRunAsync(string name, st::CancellationToken cancellationToken) =>
            StartScanRunAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Start a ScanRun according to the given ScanConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ScanConfig to be used. The name follows the
        /// format of 'projects/{projectId}/scanConfigs/{scanConfigId}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ScanRun StartScanRun(ScanConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            StartScanRun(new StartScanRunRequest
            {
                ScanConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Start a ScanRun according to the given ScanConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ScanConfig to be used. The name follows the
        /// format of 'projects/{projectId}/scanConfigs/{scanConfigId}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ScanRun> StartScanRunAsync(ScanConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            StartScanRunAsync(new StartScanRunRequest
            {
                ScanConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Start a ScanRun according to the given ScanConfig.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ScanConfig to be used. The name follows the
        /// format of 'projects/{projectId}/scanConfigs/{scanConfigId}'.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ScanRun> StartScanRunAsync(ScanConfigName name, st::CancellationToken cancellationToken) =>
            StartScanRunAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a ScanRun.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ScanRun GetScanRun(GetScanRunRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a ScanRun.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ScanRun> GetScanRunAsync(GetScanRunRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a ScanRun.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ScanRun> GetScanRunAsync(GetScanRunRequest request, st::CancellationToken cancellationToken) =>
            GetScanRunAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a ScanRun.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ScanRun to be returned. The name follows the
        /// format of
        /// 'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ScanRun GetScanRun(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetScanRun(new GetScanRunRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a ScanRun.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ScanRun to be returned. The name follows the
        /// format of
        /// 'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ScanRun> GetScanRunAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetScanRunAsync(new GetScanRunRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a ScanRun.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ScanRun to be returned. The name follows the
        /// format of
        /// 'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}'.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ScanRun> GetScanRunAsync(string name, st::CancellationToken cancellationToken) =>
            GetScanRunAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a ScanRun.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ScanRun to be returned. The name follows the
        /// format of
        /// 'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ScanRun GetScanRun(ScanRunName name, gaxgrpc::CallSettings callSettings = null) =>
            GetScanRun(new GetScanRunRequest
            {
                ScanRunName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a ScanRun.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ScanRun to be returned. The name follows the
        /// format of
        /// 'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ScanRun> GetScanRunAsync(ScanRunName name, gaxgrpc::CallSettings callSettings = null) =>
            GetScanRunAsync(new GetScanRunRequest
            {
                ScanRunName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a ScanRun.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ScanRun to be returned. The name follows the
        /// format of
        /// 'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}'.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ScanRun> GetScanRunAsync(ScanRunName name, st::CancellationToken cancellationToken) =>
            GetScanRunAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists ScanRuns under a given ScanConfig, in descending order of ScanRun
        /// stop time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ScanRun"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListScanRunsResponse, ScanRun> ListScanRuns(ListScanRunsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ScanRuns under a given ScanConfig, in descending order of ScanRun
        /// stop time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ScanRun"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListScanRunsResponse, ScanRun> ListScanRunsAsync(ListScanRunsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ScanRuns under a given ScanConfig, in descending order of ScanRun
        /// stop time.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, which should be a scan resource name in the
        /// format 'projects/{projectId}/scanConfigs/{scanConfigId}'.
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
        /// <returns>A pageable sequence of <see cref="ScanRun"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListScanRunsResponse, ScanRun> ListScanRuns(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListScanRuns(new ListScanRunsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists ScanRuns under a given ScanConfig, in descending order of ScanRun
        /// stop time.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, which should be a scan resource name in the
        /// format 'projects/{projectId}/scanConfigs/{scanConfigId}'.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ScanRun"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListScanRunsResponse, ScanRun> ListScanRunsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListScanRunsAsync(new ListScanRunsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists ScanRuns under a given ScanConfig, in descending order of ScanRun
        /// stop time.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, which should be a scan resource name in the
        /// format 'projects/{projectId}/scanConfigs/{scanConfigId}'.
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
        /// <returns>A pageable sequence of <see cref="ScanRun"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListScanRunsResponse, ScanRun> ListScanRuns(ScanConfigName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListScanRuns(new ListScanRunsRequest
            {
                ParentAsScanConfigName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists ScanRuns under a given ScanConfig, in descending order of ScanRun
        /// stop time.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, which should be a scan resource name in the
        /// format 'projects/{projectId}/scanConfigs/{scanConfigId}'.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ScanRun"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListScanRunsResponse, ScanRun> ListScanRunsAsync(ScanConfigName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListScanRunsAsync(new ListScanRunsRequest
            {
                ParentAsScanConfigName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Stops a ScanRun. The stopped ScanRun is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ScanRun StopScanRun(StopScanRunRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Stops a ScanRun. The stopped ScanRun is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ScanRun> StopScanRunAsync(StopScanRunRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Stops a ScanRun. The stopped ScanRun is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ScanRun> StopScanRunAsync(StopScanRunRequest request, st::CancellationToken cancellationToken) =>
            StopScanRunAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Stops a ScanRun. The stopped ScanRun is returned.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ScanRun to be stopped. The name follows the
        /// format of
        /// 'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ScanRun StopScanRun(string name, gaxgrpc::CallSettings callSettings = null) =>
            StopScanRun(new StopScanRunRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Stops a ScanRun. The stopped ScanRun is returned.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ScanRun to be stopped. The name follows the
        /// format of
        /// 'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ScanRun> StopScanRunAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            StopScanRunAsync(new StopScanRunRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Stops a ScanRun. The stopped ScanRun is returned.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ScanRun to be stopped. The name follows the
        /// format of
        /// 'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}'.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ScanRun> StopScanRunAsync(string name, st::CancellationToken cancellationToken) =>
            StopScanRunAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Stops a ScanRun. The stopped ScanRun is returned.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ScanRun to be stopped. The name follows the
        /// format of
        /// 'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ScanRun StopScanRun(ScanRunName name, gaxgrpc::CallSettings callSettings = null) =>
            StopScanRun(new StopScanRunRequest
            {
                ScanRunName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Stops a ScanRun. The stopped ScanRun is returned.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ScanRun to be stopped. The name follows the
        /// format of
        /// 'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ScanRun> StopScanRunAsync(ScanRunName name, gaxgrpc::CallSettings callSettings = null) =>
            StopScanRunAsync(new StopScanRunRequest
            {
                ScanRunName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Stops a ScanRun. The stopped ScanRun is returned.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ScanRun to be stopped. The name follows the
        /// format of
        /// 'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}'.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ScanRun> StopScanRunAsync(ScanRunName name, st::CancellationToken cancellationToken) =>
            StopScanRunAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List CrawledUrls under a given ScanRun.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CrawledUrl"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCrawledUrlsResponse, CrawledUrl> ListCrawledUrls(ListCrawledUrlsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List CrawledUrls under a given ScanRun.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CrawledUrl"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCrawledUrlsResponse, CrawledUrl> ListCrawledUrlsAsync(ListCrawledUrlsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List CrawledUrls under a given ScanRun.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, which should be a scan run resource name in the
        /// format
        /// 'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}'.
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
        /// <returns>A pageable sequence of <see cref="CrawledUrl"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCrawledUrlsResponse, CrawledUrl> ListCrawledUrls(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListCrawledUrls(new ListCrawledUrlsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List CrawledUrls under a given ScanRun.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, which should be a scan run resource name in the
        /// format
        /// 'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}'.
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
        /// <returns>A pageable asynchronous sequence of <see cref="CrawledUrl"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCrawledUrlsResponse, CrawledUrl> ListCrawledUrlsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListCrawledUrlsAsync(new ListCrawledUrlsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List CrawledUrls under a given ScanRun.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, which should be a scan run resource name in the
        /// format
        /// 'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}'.
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
        /// <returns>A pageable sequence of <see cref="CrawledUrl"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCrawledUrlsResponse, CrawledUrl> ListCrawledUrls(ScanRunName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListCrawledUrls(new ListCrawledUrlsRequest
            {
                ParentAsScanRunName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List CrawledUrls under a given ScanRun.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, which should be a scan run resource name in the
        /// format
        /// 'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}'.
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
        /// <returns>A pageable asynchronous sequence of <see cref="CrawledUrl"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCrawledUrlsResponse, CrawledUrl> ListCrawledUrlsAsync(ScanRunName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListCrawledUrlsAsync(new ListCrawledUrlsRequest
            {
                ParentAsScanRunName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Gets a Finding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Finding GetFinding(GetFindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a Finding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Finding> GetFindingAsync(GetFindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a Finding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Finding> GetFindingAsync(GetFindingRequest request, st::CancellationToken cancellationToken) =>
            GetFindingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a Finding.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Finding to be returned. The name follows the
        /// format of
        /// 'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}/findings/{findingId}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Finding GetFinding(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFinding(new GetFindingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Finding.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Finding to be returned. The name follows the
        /// format of
        /// 'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}/findings/{findingId}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Finding> GetFindingAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFindingAsync(new GetFindingRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Finding.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Finding to be returned. The name follows the
        /// format of
        /// 'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}/findings/{findingId}'.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Finding> GetFindingAsync(string name, st::CancellationToken cancellationToken) =>
            GetFindingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a Finding.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Finding to be returned. The name follows the
        /// format of
        /// 'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}/findings/{findingId}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Finding GetFinding(FindingName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFinding(new GetFindingRequest
            {
                FindingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Finding.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Finding to be returned. The name follows the
        /// format of
        /// 'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}/findings/{findingId}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Finding> GetFindingAsync(FindingName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFindingAsync(new GetFindingRequest
            {
                FindingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Finding.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Finding to be returned. The name follows the
        /// format of
        /// 'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}/findings/{findingId}'.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Finding> GetFindingAsync(FindingName name, st::CancellationToken cancellationToken) =>
            GetFindingAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List Findings under a given ScanRun.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Finding"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFindingsResponse, Finding> ListFindings(ListFindingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List Findings under a given ScanRun.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Finding"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFindingsResponse, Finding> ListFindingsAsync(ListFindingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List Findings under a given ScanRun.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, which should be a scan run resource name in the
        /// format
        /// 'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}'.
        /// </param>
        /// <param name="filter">
        /// Required. The filter expression. The expression must be in the format: &amp;lt;field&amp;gt;
        /// &amp;lt;operator&amp;gt; &amp;lt;value&amp;gt;.
        /// Supported field: 'finding_type'.
        /// Supported operator: '='.
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
        /// <returns>A pageable sequence of <see cref="Finding"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFindingsResponse, Finding> ListFindings(string parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListFindings(new ListFindingsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List Findings under a given ScanRun.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, which should be a scan run resource name in the
        /// format
        /// 'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}'.
        /// </param>
        /// <param name="filter">
        /// Required. The filter expression. The expression must be in the format: &amp;lt;field&amp;gt;
        /// &amp;lt;operator&amp;gt; &amp;lt;value&amp;gt;.
        /// Supported field: 'finding_type'.
        /// Supported operator: '='.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Finding"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFindingsResponse, Finding> ListFindingsAsync(string parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListFindingsAsync(new ListFindingsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List Findings under a given ScanRun.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, which should be a scan run resource name in the
        /// format
        /// 'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}'.
        /// </param>
        /// <param name="filter">
        /// Required. The filter expression. The expression must be in the format: &amp;lt;field&amp;gt;
        /// &amp;lt;operator&amp;gt; &amp;lt;value&amp;gt;.
        /// Supported field: 'finding_type'.
        /// Supported operator: '='.
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
        /// <returns>A pageable sequence of <see cref="Finding"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFindingsResponse, Finding> ListFindings(ScanRunName parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListFindings(new ListFindingsRequest
            {
                ParentAsScanRunName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List Findings under a given ScanRun.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, which should be a scan run resource name in the
        /// format
        /// 'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}'.
        /// </param>
        /// <param name="filter">
        /// Required. The filter expression. The expression must be in the format: &amp;lt;field&amp;gt;
        /// &amp;lt;operator&amp;gt; &amp;lt;value&amp;gt;.
        /// Supported field: 'finding_type'.
        /// Supported operator: '='.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Finding"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFindingsResponse, Finding> ListFindingsAsync(ScanRunName parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListFindingsAsync(new ListFindingsRequest
            {
                ParentAsScanRunName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List all FindingTypeStats under a given ScanRun.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListFindingTypeStatsResponse ListFindingTypeStats(ListFindingTypeStatsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List all FindingTypeStats under a given ScanRun.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListFindingTypeStatsResponse> ListFindingTypeStatsAsync(ListFindingTypeStatsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List all FindingTypeStats under a given ScanRun.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListFindingTypeStatsResponse> ListFindingTypeStatsAsync(ListFindingTypeStatsRequest request, st::CancellationToken cancellationToken) =>
            ListFindingTypeStatsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List all FindingTypeStats under a given ScanRun.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, which should be a scan run resource name in the
        /// format
        /// 'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListFindingTypeStatsResponse ListFindingTypeStats(string parent, gaxgrpc::CallSettings callSettings = null) =>
            ListFindingTypeStats(new ListFindingTypeStatsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// List all FindingTypeStats under a given ScanRun.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, which should be a scan run resource name in the
        /// format
        /// 'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListFindingTypeStatsResponse> ListFindingTypeStatsAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            ListFindingTypeStatsAsync(new ListFindingTypeStatsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// List all FindingTypeStats under a given ScanRun.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, which should be a scan run resource name in the
        /// format
        /// 'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}'.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListFindingTypeStatsResponse> ListFindingTypeStatsAsync(string parent, st::CancellationToken cancellationToken) =>
            ListFindingTypeStatsAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List all FindingTypeStats under a given ScanRun.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, which should be a scan run resource name in the
        /// format
        /// 'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListFindingTypeStatsResponse ListFindingTypeStats(ScanRunName parent, gaxgrpc::CallSettings callSettings = null) =>
            ListFindingTypeStats(new ListFindingTypeStatsRequest
            {
                ParentAsScanRunName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// List all FindingTypeStats under a given ScanRun.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, which should be a scan run resource name in the
        /// format
        /// 'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListFindingTypeStatsResponse> ListFindingTypeStatsAsync(ScanRunName parent, gaxgrpc::CallSettings callSettings = null) =>
            ListFindingTypeStatsAsync(new ListFindingTypeStatsRequest
            {
                ParentAsScanRunName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// List all FindingTypeStats under a given ScanRun.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name, which should be a scan run resource name in the
        /// format
        /// 'projects/{projectId}/scanConfigs/{scanConfigId}/scanRuns/{scanRunId}'.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListFindingTypeStatsResponse> ListFindingTypeStatsAsync(ScanRunName parent, st::CancellationToken cancellationToken) =>
            ListFindingTypeStatsAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>WebSecurityScanner client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Cloud Web Security Scanner Service identifies security vulnerabilities in web
    /// applications hosted on Google Cloud Platform. It crawls your application, and
    /// attempts to exercise as many user inputs and event handlers as possible.
    /// </remarks>
    public sealed partial class WebSecurityScannerClientImpl : WebSecurityScannerClient
    {
        private readonly gaxgrpc::ApiCall<CreateScanConfigRequest, ScanConfig> _callCreateScanConfig;

        private readonly gaxgrpc::ApiCall<DeleteScanConfigRequest, wkt::Empty> _callDeleteScanConfig;

        private readonly gaxgrpc::ApiCall<GetScanConfigRequest, ScanConfig> _callGetScanConfig;

        private readonly gaxgrpc::ApiCall<ListScanConfigsRequest, ListScanConfigsResponse> _callListScanConfigs;

        private readonly gaxgrpc::ApiCall<UpdateScanConfigRequest, ScanConfig> _callUpdateScanConfig;

        private readonly gaxgrpc::ApiCall<StartScanRunRequest, ScanRun> _callStartScanRun;

        private readonly gaxgrpc::ApiCall<GetScanRunRequest, ScanRun> _callGetScanRun;

        private readonly gaxgrpc::ApiCall<ListScanRunsRequest, ListScanRunsResponse> _callListScanRuns;

        private readonly gaxgrpc::ApiCall<StopScanRunRequest, ScanRun> _callStopScanRun;

        private readonly gaxgrpc::ApiCall<ListCrawledUrlsRequest, ListCrawledUrlsResponse> _callListCrawledUrls;

        private readonly gaxgrpc::ApiCall<GetFindingRequest, Finding> _callGetFinding;

        private readonly gaxgrpc::ApiCall<ListFindingsRequest, ListFindingsResponse> _callListFindings;

        private readonly gaxgrpc::ApiCall<ListFindingTypeStatsRequest, ListFindingTypeStatsResponse> _callListFindingTypeStats;

        /// <summary>
        /// Constructs a client wrapper for the WebSecurityScanner service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="WebSecurityScannerSettings"/> used within this client.</param>
        public WebSecurityScannerClientImpl(WebSecurityScanner.WebSecurityScannerClient grpcClient, WebSecurityScannerSettings settings)
        {
            GrpcClient = grpcClient;
            WebSecurityScannerSettings effectiveSettings = settings ?? WebSecurityScannerSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callCreateScanConfig = clientHelper.BuildApiCall<CreateScanConfigRequest, ScanConfig>(grpcClient.CreateScanConfigAsync, grpcClient.CreateScanConfig, effectiveSettings.CreateScanConfigSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateScanConfig);
            Modify_CreateScanConfigApiCall(ref _callCreateScanConfig);
            _callDeleteScanConfig = clientHelper.BuildApiCall<DeleteScanConfigRequest, wkt::Empty>(grpcClient.DeleteScanConfigAsync, grpcClient.DeleteScanConfig, effectiveSettings.DeleteScanConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteScanConfig);
            Modify_DeleteScanConfigApiCall(ref _callDeleteScanConfig);
            _callGetScanConfig = clientHelper.BuildApiCall<GetScanConfigRequest, ScanConfig>(grpcClient.GetScanConfigAsync, grpcClient.GetScanConfig, effectiveSettings.GetScanConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetScanConfig);
            Modify_GetScanConfigApiCall(ref _callGetScanConfig);
            _callListScanConfigs = clientHelper.BuildApiCall<ListScanConfigsRequest, ListScanConfigsResponse>(grpcClient.ListScanConfigsAsync, grpcClient.ListScanConfigs, effectiveSettings.ListScanConfigsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListScanConfigs);
            Modify_ListScanConfigsApiCall(ref _callListScanConfigs);
            _callUpdateScanConfig = clientHelper.BuildApiCall<UpdateScanConfigRequest, ScanConfig>(grpcClient.UpdateScanConfigAsync, grpcClient.UpdateScanConfig, effectiveSettings.UpdateScanConfigSettings).WithGoogleRequestParam("scan_config.name", request => request.ScanConfig?.Name);
            Modify_ApiCall(ref _callUpdateScanConfig);
            Modify_UpdateScanConfigApiCall(ref _callUpdateScanConfig);
            _callStartScanRun = clientHelper.BuildApiCall<StartScanRunRequest, ScanRun>(grpcClient.StartScanRunAsync, grpcClient.StartScanRun, effectiveSettings.StartScanRunSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callStartScanRun);
            Modify_StartScanRunApiCall(ref _callStartScanRun);
            _callGetScanRun = clientHelper.BuildApiCall<GetScanRunRequest, ScanRun>(grpcClient.GetScanRunAsync, grpcClient.GetScanRun, effectiveSettings.GetScanRunSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetScanRun);
            Modify_GetScanRunApiCall(ref _callGetScanRun);
            _callListScanRuns = clientHelper.BuildApiCall<ListScanRunsRequest, ListScanRunsResponse>(grpcClient.ListScanRunsAsync, grpcClient.ListScanRuns, effectiveSettings.ListScanRunsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListScanRuns);
            Modify_ListScanRunsApiCall(ref _callListScanRuns);
            _callStopScanRun = clientHelper.BuildApiCall<StopScanRunRequest, ScanRun>(grpcClient.StopScanRunAsync, grpcClient.StopScanRun, effectiveSettings.StopScanRunSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callStopScanRun);
            Modify_StopScanRunApiCall(ref _callStopScanRun);
            _callListCrawledUrls = clientHelper.BuildApiCall<ListCrawledUrlsRequest, ListCrawledUrlsResponse>(grpcClient.ListCrawledUrlsAsync, grpcClient.ListCrawledUrls, effectiveSettings.ListCrawledUrlsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListCrawledUrls);
            Modify_ListCrawledUrlsApiCall(ref _callListCrawledUrls);
            _callGetFinding = clientHelper.BuildApiCall<GetFindingRequest, Finding>(grpcClient.GetFindingAsync, grpcClient.GetFinding, effectiveSettings.GetFindingSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetFinding);
            Modify_GetFindingApiCall(ref _callGetFinding);
            _callListFindings = clientHelper.BuildApiCall<ListFindingsRequest, ListFindingsResponse>(grpcClient.ListFindingsAsync, grpcClient.ListFindings, effectiveSettings.ListFindingsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListFindings);
            Modify_ListFindingsApiCall(ref _callListFindings);
            _callListFindingTypeStats = clientHelper.BuildApiCall<ListFindingTypeStatsRequest, ListFindingTypeStatsResponse>(grpcClient.ListFindingTypeStatsAsync, grpcClient.ListFindingTypeStats, effectiveSettings.ListFindingTypeStatsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListFindingTypeStats);
            Modify_ListFindingTypeStatsApiCall(ref _callListFindingTypeStats);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateScanConfigApiCall(ref gaxgrpc::ApiCall<CreateScanConfigRequest, ScanConfig> call);

        partial void Modify_DeleteScanConfigApiCall(ref gaxgrpc::ApiCall<DeleteScanConfigRequest, wkt::Empty> call);

        partial void Modify_GetScanConfigApiCall(ref gaxgrpc::ApiCall<GetScanConfigRequest, ScanConfig> call);

        partial void Modify_ListScanConfigsApiCall(ref gaxgrpc::ApiCall<ListScanConfigsRequest, ListScanConfigsResponse> call);

        partial void Modify_UpdateScanConfigApiCall(ref gaxgrpc::ApiCall<UpdateScanConfigRequest, ScanConfig> call);

        partial void Modify_StartScanRunApiCall(ref gaxgrpc::ApiCall<StartScanRunRequest, ScanRun> call);

        partial void Modify_GetScanRunApiCall(ref gaxgrpc::ApiCall<GetScanRunRequest, ScanRun> call);

        partial void Modify_ListScanRunsApiCall(ref gaxgrpc::ApiCall<ListScanRunsRequest, ListScanRunsResponse> call);

        partial void Modify_StopScanRunApiCall(ref gaxgrpc::ApiCall<StopScanRunRequest, ScanRun> call);

        partial void Modify_ListCrawledUrlsApiCall(ref gaxgrpc::ApiCall<ListCrawledUrlsRequest, ListCrawledUrlsResponse> call);

        partial void Modify_GetFindingApiCall(ref gaxgrpc::ApiCall<GetFindingRequest, Finding> call);

        partial void Modify_ListFindingsApiCall(ref gaxgrpc::ApiCall<ListFindingsRequest, ListFindingsResponse> call);

        partial void Modify_ListFindingTypeStatsApiCall(ref gaxgrpc::ApiCall<ListFindingTypeStatsRequest, ListFindingTypeStatsResponse> call);

        partial void OnConstruction(WebSecurityScanner.WebSecurityScannerClient grpcClient, WebSecurityScannerSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC WebSecurityScanner client</summary>
        public override WebSecurityScanner.WebSecurityScannerClient GrpcClient { get; }

        partial void Modify_CreateScanConfigRequest(ref CreateScanConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteScanConfigRequest(ref DeleteScanConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetScanConfigRequest(ref GetScanConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListScanConfigsRequest(ref ListScanConfigsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateScanConfigRequest(ref UpdateScanConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StartScanRunRequest(ref StartScanRunRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetScanRunRequest(ref GetScanRunRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListScanRunsRequest(ref ListScanRunsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StopScanRunRequest(ref StopScanRunRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListCrawledUrlsRequest(ref ListCrawledUrlsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetFindingRequest(ref GetFindingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListFindingsRequest(ref ListFindingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListFindingTypeStatsRequest(ref ListFindingTypeStatsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a new ScanConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ScanConfig CreateScanConfig(CreateScanConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateScanConfigRequest(ref request, ref callSettings);
            return _callCreateScanConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new ScanConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ScanConfig> CreateScanConfigAsync(CreateScanConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateScanConfigRequest(ref request, ref callSettings);
            return _callCreateScanConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes an existing ScanConfig and its child resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteScanConfig(DeleteScanConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteScanConfigRequest(ref request, ref callSettings);
            _callDeleteScanConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes an existing ScanConfig and its child resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteScanConfigAsync(DeleteScanConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteScanConfigRequest(ref request, ref callSettings);
            return _callDeleteScanConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a ScanConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ScanConfig GetScanConfig(GetScanConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetScanConfigRequest(ref request, ref callSettings);
            return _callGetScanConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a ScanConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ScanConfig> GetScanConfigAsync(GetScanConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetScanConfigRequest(ref request, ref callSettings);
            return _callGetScanConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Lists ScanConfigs under a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ScanConfig"/> resources.</returns>
        public override gax::PagedEnumerable<ListScanConfigsResponse, ScanConfig> ListScanConfigs(ListScanConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListScanConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListScanConfigsRequest, ListScanConfigsResponse, ScanConfig>(_callListScanConfigs, request, callSettings);
        }

        /// <summary>
        /// Lists ScanConfigs under a given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ScanConfig"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListScanConfigsResponse, ScanConfig> ListScanConfigsAsync(ListScanConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListScanConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListScanConfigsRequest, ListScanConfigsResponse, ScanConfig>(_callListScanConfigs, request, callSettings);
        }

        /// <summary>
        /// Updates a ScanConfig. This method support partial update of a ScanConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ScanConfig UpdateScanConfig(UpdateScanConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateScanConfigRequest(ref request, ref callSettings);
            return _callUpdateScanConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a ScanConfig. This method support partial update of a ScanConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ScanConfig> UpdateScanConfigAsync(UpdateScanConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateScanConfigRequest(ref request, ref callSettings);
            return _callUpdateScanConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Start a ScanRun according to the given ScanConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ScanRun StartScanRun(StartScanRunRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartScanRunRequest(ref request, ref callSettings);
            return _callStartScanRun.Sync(request, callSettings);
        }

        /// <summary>
        /// Start a ScanRun according to the given ScanConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ScanRun> StartScanRunAsync(StartScanRunRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartScanRunRequest(ref request, ref callSettings);
            return _callStartScanRun.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a ScanRun.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ScanRun GetScanRun(GetScanRunRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetScanRunRequest(ref request, ref callSettings);
            return _callGetScanRun.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a ScanRun.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ScanRun> GetScanRunAsync(GetScanRunRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetScanRunRequest(ref request, ref callSettings);
            return _callGetScanRun.Async(request, callSettings);
        }

        /// <summary>
        /// Lists ScanRuns under a given ScanConfig, in descending order of ScanRun
        /// stop time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ScanRun"/> resources.</returns>
        public override gax::PagedEnumerable<ListScanRunsResponse, ScanRun> ListScanRuns(ListScanRunsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListScanRunsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListScanRunsRequest, ListScanRunsResponse, ScanRun>(_callListScanRuns, request, callSettings);
        }

        /// <summary>
        /// Lists ScanRuns under a given ScanConfig, in descending order of ScanRun
        /// stop time.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ScanRun"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListScanRunsResponse, ScanRun> ListScanRunsAsync(ListScanRunsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListScanRunsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListScanRunsRequest, ListScanRunsResponse, ScanRun>(_callListScanRuns, request, callSettings);
        }

        /// <summary>
        /// Stops a ScanRun. The stopped ScanRun is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ScanRun StopScanRun(StopScanRunRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StopScanRunRequest(ref request, ref callSettings);
            return _callStopScanRun.Sync(request, callSettings);
        }

        /// <summary>
        /// Stops a ScanRun. The stopped ScanRun is returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ScanRun> StopScanRunAsync(StopScanRunRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StopScanRunRequest(ref request, ref callSettings);
            return _callStopScanRun.Async(request, callSettings);
        }

        /// <summary>
        /// List CrawledUrls under a given ScanRun.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CrawledUrl"/> resources.</returns>
        public override gax::PagedEnumerable<ListCrawledUrlsResponse, CrawledUrl> ListCrawledUrls(ListCrawledUrlsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCrawledUrlsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCrawledUrlsRequest, ListCrawledUrlsResponse, CrawledUrl>(_callListCrawledUrls, request, callSettings);
        }

        /// <summary>
        /// List CrawledUrls under a given ScanRun.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CrawledUrl"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListCrawledUrlsResponse, CrawledUrl> ListCrawledUrlsAsync(ListCrawledUrlsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCrawledUrlsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCrawledUrlsRequest, ListCrawledUrlsResponse, CrawledUrl>(_callListCrawledUrls, request, callSettings);
        }

        /// <summary>
        /// Gets a Finding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Finding GetFinding(GetFindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFindingRequest(ref request, ref callSettings);
            return _callGetFinding.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a Finding.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Finding> GetFindingAsync(GetFindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFindingRequest(ref request, ref callSettings);
            return _callGetFinding.Async(request, callSettings);
        }

        /// <summary>
        /// List Findings under a given ScanRun.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Finding"/> resources.</returns>
        public override gax::PagedEnumerable<ListFindingsResponse, Finding> ListFindings(ListFindingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFindingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListFindingsRequest, ListFindingsResponse, Finding>(_callListFindings, request, callSettings);
        }

        /// <summary>
        /// List Findings under a given ScanRun.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Finding"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListFindingsResponse, Finding> ListFindingsAsync(ListFindingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFindingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListFindingsRequest, ListFindingsResponse, Finding>(_callListFindings, request, callSettings);
        }

        /// <summary>
        /// List all FindingTypeStats under a given ScanRun.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ListFindingTypeStatsResponse ListFindingTypeStats(ListFindingTypeStatsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFindingTypeStatsRequest(ref request, ref callSettings);
            return _callListFindingTypeStats.Sync(request, callSettings);
        }

        /// <summary>
        /// List all FindingTypeStats under a given ScanRun.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ListFindingTypeStatsResponse> ListFindingTypeStatsAsync(ListFindingTypeStatsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFindingTypeStatsRequest(ref request, ref callSettings);
            return _callListFindingTypeStats.Async(request, callSettings);
        }
    }

    public partial class ListScanConfigsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListScanRunsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCrawledUrlsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListFindingsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListScanConfigsResponse : gaxgrpc::IPageResponse<ScanConfig>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ScanConfig> GetEnumerator() => ScanConfigs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListScanRunsResponse : gaxgrpc::IPageResponse<ScanRun>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ScanRun> GetEnumerator() => ScanRuns.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListCrawledUrlsResponse : gaxgrpc::IPageResponse<CrawledUrl>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<CrawledUrl> GetEnumerator() => CrawledUrls.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListFindingsResponse : gaxgrpc::IPageResponse<Finding>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Finding> GetEnumerator() => Findings.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
