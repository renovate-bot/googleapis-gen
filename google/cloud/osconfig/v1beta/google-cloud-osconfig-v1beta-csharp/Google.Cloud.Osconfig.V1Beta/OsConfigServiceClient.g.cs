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

namespace Google.Cloud.Osconfig.V1Beta
{
    /// <summary>Settings for <see cref="OsConfigServiceClient"/> instances.</summary>
    public sealed partial class OsConfigServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="OsConfigServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="OsConfigServiceSettings"/>.</returns>
        public static OsConfigServiceSettings GetDefault() => new OsConfigServiceSettings();

        /// <summary>Constructs a new <see cref="OsConfigServiceSettings"/> object with default settings.</summary>
        public OsConfigServiceSettings()
        {
        }

        private OsConfigServiceSettings(OsConfigServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ExecutePatchJobSettings = existing.ExecutePatchJobSettings;
            GetPatchJobSettings = existing.GetPatchJobSettings;
            CancelPatchJobSettings = existing.CancelPatchJobSettings;
            ListPatchJobsSettings = existing.ListPatchJobsSettings;
            ListPatchJobInstanceDetailsSettings = existing.ListPatchJobInstanceDetailsSettings;
            CreatePatchDeploymentSettings = existing.CreatePatchDeploymentSettings;
            GetPatchDeploymentSettings = existing.GetPatchDeploymentSettings;
            ListPatchDeploymentsSettings = existing.ListPatchDeploymentsSettings;
            DeletePatchDeploymentSettings = existing.DeletePatchDeploymentSettings;
            CreateGuestPolicySettings = existing.CreateGuestPolicySettings;
            GetGuestPolicySettings = existing.GetGuestPolicySettings;
            ListGuestPoliciesSettings = existing.ListGuestPoliciesSettings;
            UpdateGuestPolicySettings = existing.UpdateGuestPolicySettings;
            DeleteGuestPolicySettings = existing.DeleteGuestPolicySettings;
            LookupEffectiveGuestPolicySettings = existing.LookupEffectiveGuestPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(OsConfigServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OsConfigServiceClient.ExecutePatchJob</c> and <c>OsConfigServiceClient.ExecutePatchJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ExecutePatchJobSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OsConfigServiceClient.GetPatchJob</c> and <c>OsConfigServiceClient.GetPatchJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetPatchJobSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OsConfigServiceClient.CancelPatchJob</c> and <c>OsConfigServiceClient.CancelPatchJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CancelPatchJobSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OsConfigServiceClient.ListPatchJobs</c> and <c>OsConfigServiceClient.ListPatchJobsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListPatchJobsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OsConfigServiceClient.ListPatchJobInstanceDetails</c> and
        /// <c>OsConfigServiceClient.ListPatchJobInstanceDetailsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListPatchJobInstanceDetailsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OsConfigServiceClient.CreatePatchDeployment</c> and <c>OsConfigServiceClient.CreatePatchDeploymentAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreatePatchDeploymentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OsConfigServiceClient.GetPatchDeployment</c> and <c>OsConfigServiceClient.GetPatchDeploymentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetPatchDeploymentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OsConfigServiceClient.ListPatchDeployments</c> and <c>OsConfigServiceClient.ListPatchDeploymentsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListPatchDeploymentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OsConfigServiceClient.DeletePatchDeployment</c> and <c>OsConfigServiceClient.DeletePatchDeploymentAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeletePatchDeploymentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OsConfigServiceClient.CreateGuestPolicy</c> and <c>OsConfigServiceClient.CreateGuestPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateGuestPolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OsConfigServiceClient.GetGuestPolicy</c> and <c>OsConfigServiceClient.GetGuestPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetGuestPolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OsConfigServiceClient.ListGuestPolicies</c> and <c>OsConfigServiceClient.ListGuestPoliciesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListGuestPoliciesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OsConfigServiceClient.UpdateGuestPolicy</c> and <c>OsConfigServiceClient.UpdateGuestPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateGuestPolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OsConfigServiceClient.DeleteGuestPolicy</c> and <c>OsConfigServiceClient.DeleteGuestPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteGuestPolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OsConfigServiceClient.LookupEffectiveGuestPolicy</c> and
        /// <c>OsConfigServiceClient.LookupEffectiveGuestPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings LookupEffectiveGuestPolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="OsConfigServiceSettings"/> object.</returns>
        public OsConfigServiceSettings Clone() => new OsConfigServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="OsConfigServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class OsConfigServiceClientBuilder : gaxgrpc::ClientBuilderBase<OsConfigServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public OsConfigServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref OsConfigServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<OsConfigServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override OsConfigServiceClient Build()
        {
            OsConfigServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<OsConfigServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<OsConfigServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private OsConfigServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return OsConfigServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<OsConfigServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return OsConfigServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => OsConfigServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => OsConfigServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => OsConfigServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>OsConfigService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// OS Config API
    /// 
    /// The OS Config service is a server-side component that you can use to
    /// manage package installations and patch jobs for virtual machine instances.
    /// </remarks>
    public abstract partial class OsConfigServiceClient
    {
        /// <summary>
        /// The default endpoint for the OsConfigService service, which is a host of "osconfig.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "osconfig.googleapis.com:443";

        /// <summary>The default OsConfigService scopes.</summary>
        /// <remarks>
        /// The default OsConfigService scopes are:
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
        /// Asynchronously creates a <see cref="OsConfigServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="OsConfigServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="OsConfigServiceClient"/>.</returns>
        public static stt::Task<OsConfigServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new OsConfigServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="OsConfigServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="OsConfigServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="OsConfigServiceClient"/>.</returns>
        public static OsConfigServiceClient Create() => new OsConfigServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="OsConfigServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="OsConfigServiceSettings"/>.</param>
        /// <returns>The created <see cref="OsConfigServiceClient"/>.</returns>
        internal static OsConfigServiceClient Create(grpccore::CallInvoker callInvoker, OsConfigServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            OsConfigService.OsConfigServiceClient grpcClient = new OsConfigService.OsConfigServiceClient(callInvoker);
            return new OsConfigServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC OsConfigService client</summary>
        public virtual OsConfigService.OsConfigServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Patch VM instances by creating and running a patch job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PatchJob ExecutePatchJob(ExecutePatchJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Patch VM instances by creating and running a patch job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PatchJob> ExecutePatchJobAsync(ExecutePatchJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Patch VM instances by creating and running a patch job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PatchJob> ExecutePatchJobAsync(ExecutePatchJobRequest request, st::CancellationToken cancellationToken) =>
            ExecutePatchJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get the patch job. This can be used to track the progress of an
        /// ongoing patch job or review the details of completed jobs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PatchJob GetPatchJob(GetPatchJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get the patch job. This can be used to track the progress of an
        /// ongoing patch job or review the details of completed jobs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PatchJob> GetPatchJobAsync(GetPatchJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get the patch job. This can be used to track the progress of an
        /// ongoing patch job or review the details of completed jobs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PatchJob> GetPatchJobAsync(GetPatchJobRequest request, st::CancellationToken cancellationToken) =>
            GetPatchJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Cancel a patch job. The patch job must be active. Canceled patch jobs
        /// cannot be restarted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PatchJob CancelPatchJob(CancelPatchJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Cancel a patch job. The patch job must be active. Canceled patch jobs
        /// cannot be restarted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PatchJob> CancelPatchJobAsync(CancelPatchJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Cancel a patch job. The patch job must be active. Canceled patch jobs
        /// cannot be restarted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PatchJob> CancelPatchJobAsync(CancelPatchJobRequest request, st::CancellationToken cancellationToken) =>
            CancelPatchJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a list of patch jobs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PatchJob"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPatchJobsResponse, PatchJob> ListPatchJobs(ListPatchJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a list of patch jobs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PatchJob"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPatchJobsResponse, PatchJob> ListPatchJobsAsync(ListPatchJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a list of instance details for a given patch job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PatchJobInstanceDetails"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPatchJobInstanceDetailsResponse, PatchJobInstanceDetails> ListPatchJobInstanceDetails(ListPatchJobInstanceDetailsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a list of instance details for a given patch job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PatchJobInstanceDetails"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPatchJobInstanceDetailsResponse, PatchJobInstanceDetails> ListPatchJobInstanceDetailsAsync(ListPatchJobInstanceDetailsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a list of instance details for a given patch job.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent for the instances are in the form of `projects/*/patchJobs/*`.
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
        /// <returns>A pageable sequence of <see cref="PatchJobInstanceDetails"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPatchJobInstanceDetailsResponse, PatchJobInstanceDetails> ListPatchJobInstanceDetails(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListPatchJobInstanceDetails(new ListPatchJobInstanceDetailsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Get a list of instance details for a given patch job.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent for the instances are in the form of `projects/*/patchJobs/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="PatchJobInstanceDetails"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPatchJobInstanceDetailsResponse, PatchJobInstanceDetails> ListPatchJobInstanceDetailsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListPatchJobInstanceDetailsAsync(new ListPatchJobInstanceDetailsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Create an OS Config patch deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PatchDeployment CreatePatchDeployment(CreatePatchDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create an OS Config patch deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PatchDeployment> CreatePatchDeploymentAsync(CreatePatchDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create an OS Config patch deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PatchDeployment> CreatePatchDeploymentAsync(CreatePatchDeploymentRequest request, st::CancellationToken cancellationToken) =>
            CreatePatchDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get an OS Config patch deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PatchDeployment GetPatchDeployment(GetPatchDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get an OS Config patch deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PatchDeployment> GetPatchDeploymentAsync(GetPatchDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get an OS Config patch deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PatchDeployment> GetPatchDeploymentAsync(GetPatchDeploymentRequest request, st::CancellationToken cancellationToken) =>
            GetPatchDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a page of OS Config patch deployments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PatchDeployment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPatchDeploymentsResponse, PatchDeployment> ListPatchDeployments(ListPatchDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a page of OS Config patch deployments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PatchDeployment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPatchDeploymentsResponse, PatchDeployment> ListPatchDeploymentsAsync(ListPatchDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete an OS Config patch deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeletePatchDeployment(DeletePatchDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete an OS Config patch deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePatchDeploymentAsync(DeletePatchDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete an OS Config patch deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePatchDeploymentAsync(DeletePatchDeploymentRequest request, st::CancellationToken cancellationToken) =>
            DeletePatchDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create an OS Config guest policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GuestPolicy CreateGuestPolicy(CreateGuestPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create an OS Config guest policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GuestPolicy> CreateGuestPolicyAsync(CreateGuestPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create an OS Config guest policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GuestPolicy> CreateGuestPolicyAsync(CreateGuestPolicyRequest request, st::CancellationToken cancellationToken) =>
            CreateGuestPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create an OS Config guest policy.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent using one of the following forms:
        /// `projects/{project_number}`.
        /// </param>
        /// <param name="guestPolicy">
        /// Required. The GuestPolicy to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GuestPolicy CreateGuestPolicy(string parent, GuestPolicy guestPolicy, gaxgrpc::CallSettings callSettings = null) =>
            CreateGuestPolicy(new CreateGuestPolicyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                GuestPolicy = gax::GaxPreconditions.CheckNotNull(guestPolicy, nameof(guestPolicy)),
            }, callSettings);

        /// <summary>
        /// Create an OS Config guest policy.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent using one of the following forms:
        /// `projects/{project_number}`.
        /// </param>
        /// <param name="guestPolicy">
        /// Required. The GuestPolicy to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GuestPolicy> CreateGuestPolicyAsync(string parent, GuestPolicy guestPolicy, gaxgrpc::CallSettings callSettings = null) =>
            CreateGuestPolicyAsync(new CreateGuestPolicyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                GuestPolicy = gax::GaxPreconditions.CheckNotNull(guestPolicy, nameof(guestPolicy)),
            }, callSettings);

        /// <summary>
        /// Create an OS Config guest policy.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent using one of the following forms:
        /// `projects/{project_number}`.
        /// </param>
        /// <param name="guestPolicy">
        /// Required. The GuestPolicy to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GuestPolicy> CreateGuestPolicyAsync(string parent, GuestPolicy guestPolicy, st::CancellationToken cancellationToken) =>
            CreateGuestPolicyAsync(parent, guestPolicy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create an OS Config guest policy.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent using one of the following forms:
        /// `projects/{project_number}`.
        /// </param>
        /// <param name="guestPolicy">
        /// Required. The GuestPolicy to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GuestPolicy CreateGuestPolicy(gagr::ProjectName parent, GuestPolicy guestPolicy, gaxgrpc::CallSettings callSettings = null) =>
            CreateGuestPolicy(new CreateGuestPolicyRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                GuestPolicy = gax::GaxPreconditions.CheckNotNull(guestPolicy, nameof(guestPolicy)),
            }, callSettings);

        /// <summary>
        /// Create an OS Config guest policy.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent using one of the following forms:
        /// `projects/{project_number}`.
        /// </param>
        /// <param name="guestPolicy">
        /// Required. The GuestPolicy to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GuestPolicy> CreateGuestPolicyAsync(gagr::ProjectName parent, GuestPolicy guestPolicy, gaxgrpc::CallSettings callSettings = null) =>
            CreateGuestPolicyAsync(new CreateGuestPolicyRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                GuestPolicy = gax::GaxPreconditions.CheckNotNull(guestPolicy, nameof(guestPolicy)),
            }, callSettings);

        /// <summary>
        /// Create an OS Config guest policy.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent using one of the following forms:
        /// `projects/{project_number}`.
        /// </param>
        /// <param name="guestPolicy">
        /// Required. The GuestPolicy to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GuestPolicy> CreateGuestPolicyAsync(gagr::ProjectName parent, GuestPolicy guestPolicy, st::CancellationToken cancellationToken) =>
            CreateGuestPolicyAsync(parent, guestPolicy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get an OS Config guest policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GuestPolicy GetGuestPolicy(GetGuestPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get an OS Config guest policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GuestPolicy> GetGuestPolicyAsync(GetGuestPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get an OS Config guest policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GuestPolicy> GetGuestPolicyAsync(GetGuestPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetGuestPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get an OS Config guest policy.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the guest policy using one of the following forms:
        /// `projects/{project_number}/guestPolicies/{guest_policy_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GuestPolicy GetGuestPolicy(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGuestPolicy(new GetGuestPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get an OS Config guest policy.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the guest policy using one of the following forms:
        /// `projects/{project_number}/guestPolicies/{guest_policy_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GuestPolicy> GetGuestPolicyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGuestPolicyAsync(new GetGuestPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get an OS Config guest policy.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the guest policy using one of the following forms:
        /// `projects/{project_number}/guestPolicies/{guest_policy_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GuestPolicy> GetGuestPolicyAsync(string name, st::CancellationToken cancellationToken) =>
            GetGuestPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get an OS Config guest policy.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the guest policy using one of the following forms:
        /// `projects/{project_number}/guestPolicies/{guest_policy_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GuestPolicy GetGuestPolicy(GuestPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGuestPolicy(new GetGuestPolicyRequest
            {
                GuestPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get an OS Config guest policy.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the guest policy using one of the following forms:
        /// `projects/{project_number}/guestPolicies/{guest_policy_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GuestPolicy> GetGuestPolicyAsync(GuestPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGuestPolicyAsync(new GetGuestPolicyRequest
            {
                GuestPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get an OS Config guest policy.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the guest policy using one of the following forms:
        /// `projects/{project_number}/guestPolicies/{guest_policy_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GuestPolicy> GetGuestPolicyAsync(GuestPolicyName name, st::CancellationToken cancellationToken) =>
            GetGuestPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a page of OS Config guest policies.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="GuestPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGuestPoliciesResponse, GuestPolicy> ListGuestPolicies(ListGuestPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a page of OS Config guest policies.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="GuestPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGuestPoliciesResponse, GuestPolicy> ListGuestPoliciesAsync(ListGuestPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a page of OS Config guest policies.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent using one of the following forms:
        /// `projects/{project_number}`.
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
        /// <returns>A pageable sequence of <see cref="GuestPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGuestPoliciesResponse, GuestPolicy> ListGuestPolicies(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListGuestPolicies(new ListGuestPoliciesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Get a page of OS Config guest policies.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent using one of the following forms:
        /// `projects/{project_number}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="GuestPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGuestPoliciesResponse, GuestPolicy> ListGuestPoliciesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListGuestPoliciesAsync(new ListGuestPoliciesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Get a page of OS Config guest policies.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent using one of the following forms:
        /// `projects/{project_number}`.
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
        /// <returns>A pageable sequence of <see cref="GuestPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGuestPoliciesResponse, GuestPolicy> ListGuestPolicies(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListGuestPolicies(new ListGuestPoliciesRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Get a page of OS Config guest policies.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent using one of the following forms:
        /// `projects/{project_number}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="GuestPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGuestPoliciesResponse, GuestPolicy> ListGuestPoliciesAsync(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListGuestPoliciesAsync(new ListGuestPoliciesRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Update an OS Config guest policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GuestPolicy UpdateGuestPolicy(UpdateGuestPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update an OS Config guest policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GuestPolicy> UpdateGuestPolicyAsync(UpdateGuestPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update an OS Config guest policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GuestPolicy> UpdateGuestPolicyAsync(UpdateGuestPolicyRequest request, st::CancellationToken cancellationToken) =>
            UpdateGuestPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update an OS Config guest policy.
        /// </summary>
        /// <param name="guestPolicy">
        /// Required. The updated GuestPolicy.
        /// </param>
        /// <param name="updateMask">
        /// Field mask that controls which fields of the guest policy should be
        /// updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GuestPolicy UpdateGuestPolicy(GuestPolicy guestPolicy, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateGuestPolicy(new UpdateGuestPolicyRequest
            {
                GuestPolicy = gax::GaxPreconditions.CheckNotNull(guestPolicy, nameof(guestPolicy)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update an OS Config guest policy.
        /// </summary>
        /// <param name="guestPolicy">
        /// Required. The updated GuestPolicy.
        /// </param>
        /// <param name="updateMask">
        /// Field mask that controls which fields of the guest policy should be
        /// updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GuestPolicy> UpdateGuestPolicyAsync(GuestPolicy guestPolicy, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateGuestPolicyAsync(new UpdateGuestPolicyRequest
            {
                GuestPolicy = gax::GaxPreconditions.CheckNotNull(guestPolicy, nameof(guestPolicy)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update an OS Config guest policy.
        /// </summary>
        /// <param name="guestPolicy">
        /// Required. The updated GuestPolicy.
        /// </param>
        /// <param name="updateMask">
        /// Field mask that controls which fields of the guest policy should be
        /// updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GuestPolicy> UpdateGuestPolicyAsync(GuestPolicy guestPolicy, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateGuestPolicyAsync(guestPolicy, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete an OS Config guest policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteGuestPolicy(DeleteGuestPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete an OS Config guest policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteGuestPolicyAsync(DeleteGuestPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete an OS Config guest policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteGuestPolicyAsync(DeleteGuestPolicyRequest request, st::CancellationToken cancellationToken) =>
            DeleteGuestPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete an OS Config guest policy.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the guest policy  using one of the following forms:
        /// `projects/{project_number}/guestPolicies/{guest_policy_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteGuestPolicy(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGuestPolicy(new DeleteGuestPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete an OS Config guest policy.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the guest policy  using one of the following forms:
        /// `projects/{project_number}/guestPolicies/{guest_policy_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteGuestPolicyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGuestPolicyAsync(new DeleteGuestPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete an OS Config guest policy.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the guest policy  using one of the following forms:
        /// `projects/{project_number}/guestPolicies/{guest_policy_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteGuestPolicyAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteGuestPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete an OS Config guest policy.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the guest policy  using one of the following forms:
        /// `projects/{project_number}/guestPolicies/{guest_policy_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteGuestPolicy(GuestPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGuestPolicy(new DeleteGuestPolicyRequest
            {
                GuestPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete an OS Config guest policy.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the guest policy  using one of the following forms:
        /// `projects/{project_number}/guestPolicies/{guest_policy_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteGuestPolicyAsync(GuestPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteGuestPolicyAsync(new DeleteGuestPolicyRequest
            {
                GuestPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete an OS Config guest policy.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the guest policy  using one of the following forms:
        /// `projects/{project_number}/guestPolicies/{guest_policy_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteGuestPolicyAsync(GuestPolicyName name, st::CancellationToken cancellationToken) =>
            DeleteGuestPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lookup the effective guest policy that applies to a VM instance. This
        /// lookup merges all policies that are assigned to the instance ancestry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EffectiveGuestPolicy LookupEffectiveGuestPolicy(LookupEffectiveGuestPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lookup the effective guest policy that applies to a VM instance. This
        /// lookup merges all policies that are assigned to the instance ancestry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EffectiveGuestPolicy> LookupEffectiveGuestPolicyAsync(LookupEffectiveGuestPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lookup the effective guest policy that applies to a VM instance. This
        /// lookup merges all policies that are assigned to the instance ancestry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EffectiveGuestPolicy> LookupEffectiveGuestPolicyAsync(LookupEffectiveGuestPolicyRequest request, st::CancellationToken cancellationToken) =>
            LookupEffectiveGuestPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>OsConfigService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// OS Config API
    /// 
    /// The OS Config service is a server-side component that you can use to
    /// manage package installations and patch jobs for virtual machine instances.
    /// </remarks>
    public sealed partial class OsConfigServiceClientImpl : OsConfigServiceClient
    {
        private readonly gaxgrpc::ApiCall<ExecutePatchJobRequest, PatchJob> _callExecutePatchJob;

        private readonly gaxgrpc::ApiCall<GetPatchJobRequest, PatchJob> _callGetPatchJob;

        private readonly gaxgrpc::ApiCall<CancelPatchJobRequest, PatchJob> _callCancelPatchJob;

        private readonly gaxgrpc::ApiCall<ListPatchJobsRequest, ListPatchJobsResponse> _callListPatchJobs;

        private readonly gaxgrpc::ApiCall<ListPatchJobInstanceDetailsRequest, ListPatchJobInstanceDetailsResponse> _callListPatchJobInstanceDetails;

        private readonly gaxgrpc::ApiCall<CreatePatchDeploymentRequest, PatchDeployment> _callCreatePatchDeployment;

        private readonly gaxgrpc::ApiCall<GetPatchDeploymentRequest, PatchDeployment> _callGetPatchDeployment;

        private readonly gaxgrpc::ApiCall<ListPatchDeploymentsRequest, ListPatchDeploymentsResponse> _callListPatchDeployments;

        private readonly gaxgrpc::ApiCall<DeletePatchDeploymentRequest, wkt::Empty> _callDeletePatchDeployment;

        private readonly gaxgrpc::ApiCall<CreateGuestPolicyRequest, GuestPolicy> _callCreateGuestPolicy;

        private readonly gaxgrpc::ApiCall<GetGuestPolicyRequest, GuestPolicy> _callGetGuestPolicy;

        private readonly gaxgrpc::ApiCall<ListGuestPoliciesRequest, ListGuestPoliciesResponse> _callListGuestPolicies;

        private readonly gaxgrpc::ApiCall<UpdateGuestPolicyRequest, GuestPolicy> _callUpdateGuestPolicy;

        private readonly gaxgrpc::ApiCall<DeleteGuestPolicyRequest, wkt::Empty> _callDeleteGuestPolicy;

        private readonly gaxgrpc::ApiCall<LookupEffectiveGuestPolicyRequest, EffectiveGuestPolicy> _callLookupEffectiveGuestPolicy;

        /// <summary>
        /// Constructs a client wrapper for the OsConfigService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="OsConfigServiceSettings"/> used within this client.</param>
        public OsConfigServiceClientImpl(OsConfigService.OsConfigServiceClient grpcClient, OsConfigServiceSettings settings)
        {
            GrpcClient = grpcClient;
            OsConfigServiceSettings effectiveSettings = settings ?? OsConfigServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callExecutePatchJob = clientHelper.BuildApiCall<ExecutePatchJobRequest, PatchJob>(grpcClient.ExecutePatchJobAsync, grpcClient.ExecutePatchJob, effectiveSettings.ExecutePatchJobSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callExecutePatchJob);
            Modify_ExecutePatchJobApiCall(ref _callExecutePatchJob);
            _callGetPatchJob = clientHelper.BuildApiCall<GetPatchJobRequest, PatchJob>(grpcClient.GetPatchJobAsync, grpcClient.GetPatchJob, effectiveSettings.GetPatchJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetPatchJob);
            Modify_GetPatchJobApiCall(ref _callGetPatchJob);
            _callCancelPatchJob = clientHelper.BuildApiCall<CancelPatchJobRequest, PatchJob>(grpcClient.CancelPatchJobAsync, grpcClient.CancelPatchJob, effectiveSettings.CancelPatchJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callCancelPatchJob);
            Modify_CancelPatchJobApiCall(ref _callCancelPatchJob);
            _callListPatchJobs = clientHelper.BuildApiCall<ListPatchJobsRequest, ListPatchJobsResponse>(grpcClient.ListPatchJobsAsync, grpcClient.ListPatchJobs, effectiveSettings.ListPatchJobsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListPatchJobs);
            Modify_ListPatchJobsApiCall(ref _callListPatchJobs);
            _callListPatchJobInstanceDetails = clientHelper.BuildApiCall<ListPatchJobInstanceDetailsRequest, ListPatchJobInstanceDetailsResponse>(grpcClient.ListPatchJobInstanceDetailsAsync, grpcClient.ListPatchJobInstanceDetails, effectiveSettings.ListPatchJobInstanceDetailsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListPatchJobInstanceDetails);
            Modify_ListPatchJobInstanceDetailsApiCall(ref _callListPatchJobInstanceDetails);
            _callCreatePatchDeployment = clientHelper.BuildApiCall<CreatePatchDeploymentRequest, PatchDeployment>(grpcClient.CreatePatchDeploymentAsync, grpcClient.CreatePatchDeployment, effectiveSettings.CreatePatchDeploymentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreatePatchDeployment);
            Modify_CreatePatchDeploymentApiCall(ref _callCreatePatchDeployment);
            _callGetPatchDeployment = clientHelper.BuildApiCall<GetPatchDeploymentRequest, PatchDeployment>(grpcClient.GetPatchDeploymentAsync, grpcClient.GetPatchDeployment, effectiveSettings.GetPatchDeploymentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetPatchDeployment);
            Modify_GetPatchDeploymentApiCall(ref _callGetPatchDeployment);
            _callListPatchDeployments = clientHelper.BuildApiCall<ListPatchDeploymentsRequest, ListPatchDeploymentsResponse>(grpcClient.ListPatchDeploymentsAsync, grpcClient.ListPatchDeployments, effectiveSettings.ListPatchDeploymentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListPatchDeployments);
            Modify_ListPatchDeploymentsApiCall(ref _callListPatchDeployments);
            _callDeletePatchDeployment = clientHelper.BuildApiCall<DeletePatchDeploymentRequest, wkt::Empty>(grpcClient.DeletePatchDeploymentAsync, grpcClient.DeletePatchDeployment, effectiveSettings.DeletePatchDeploymentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeletePatchDeployment);
            Modify_DeletePatchDeploymentApiCall(ref _callDeletePatchDeployment);
            _callCreateGuestPolicy = clientHelper.BuildApiCall<CreateGuestPolicyRequest, GuestPolicy>(grpcClient.CreateGuestPolicyAsync, grpcClient.CreateGuestPolicy, effectiveSettings.CreateGuestPolicySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateGuestPolicy);
            Modify_CreateGuestPolicyApiCall(ref _callCreateGuestPolicy);
            _callGetGuestPolicy = clientHelper.BuildApiCall<GetGuestPolicyRequest, GuestPolicy>(grpcClient.GetGuestPolicyAsync, grpcClient.GetGuestPolicy, effectiveSettings.GetGuestPolicySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetGuestPolicy);
            Modify_GetGuestPolicyApiCall(ref _callGetGuestPolicy);
            _callListGuestPolicies = clientHelper.BuildApiCall<ListGuestPoliciesRequest, ListGuestPoliciesResponse>(grpcClient.ListGuestPoliciesAsync, grpcClient.ListGuestPolicies, effectiveSettings.ListGuestPoliciesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListGuestPolicies);
            Modify_ListGuestPoliciesApiCall(ref _callListGuestPolicies);
            _callUpdateGuestPolicy = clientHelper.BuildApiCall<UpdateGuestPolicyRequest, GuestPolicy>(grpcClient.UpdateGuestPolicyAsync, grpcClient.UpdateGuestPolicy, effectiveSettings.UpdateGuestPolicySettings).WithGoogleRequestParam("guest_policy.name", request => request.GuestPolicy?.Name);
            Modify_ApiCall(ref _callUpdateGuestPolicy);
            Modify_UpdateGuestPolicyApiCall(ref _callUpdateGuestPolicy);
            _callDeleteGuestPolicy = clientHelper.BuildApiCall<DeleteGuestPolicyRequest, wkt::Empty>(grpcClient.DeleteGuestPolicyAsync, grpcClient.DeleteGuestPolicy, effectiveSettings.DeleteGuestPolicySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteGuestPolicy);
            Modify_DeleteGuestPolicyApiCall(ref _callDeleteGuestPolicy);
            _callLookupEffectiveGuestPolicy = clientHelper.BuildApiCall<LookupEffectiveGuestPolicyRequest, EffectiveGuestPolicy>(grpcClient.LookupEffectiveGuestPolicyAsync, grpcClient.LookupEffectiveGuestPolicy, effectiveSettings.LookupEffectiveGuestPolicySettings).WithGoogleRequestParam("instance", request => request.Instance);
            Modify_ApiCall(ref _callLookupEffectiveGuestPolicy);
            Modify_LookupEffectiveGuestPolicyApiCall(ref _callLookupEffectiveGuestPolicy);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ExecutePatchJobApiCall(ref gaxgrpc::ApiCall<ExecutePatchJobRequest, PatchJob> call);

        partial void Modify_GetPatchJobApiCall(ref gaxgrpc::ApiCall<GetPatchJobRequest, PatchJob> call);

        partial void Modify_CancelPatchJobApiCall(ref gaxgrpc::ApiCall<CancelPatchJobRequest, PatchJob> call);

        partial void Modify_ListPatchJobsApiCall(ref gaxgrpc::ApiCall<ListPatchJobsRequest, ListPatchJobsResponse> call);

        partial void Modify_ListPatchJobInstanceDetailsApiCall(ref gaxgrpc::ApiCall<ListPatchJobInstanceDetailsRequest, ListPatchJobInstanceDetailsResponse> call);

        partial void Modify_CreatePatchDeploymentApiCall(ref gaxgrpc::ApiCall<CreatePatchDeploymentRequest, PatchDeployment> call);

        partial void Modify_GetPatchDeploymentApiCall(ref gaxgrpc::ApiCall<GetPatchDeploymentRequest, PatchDeployment> call);

        partial void Modify_ListPatchDeploymentsApiCall(ref gaxgrpc::ApiCall<ListPatchDeploymentsRequest, ListPatchDeploymentsResponse> call);

        partial void Modify_DeletePatchDeploymentApiCall(ref gaxgrpc::ApiCall<DeletePatchDeploymentRequest, wkt::Empty> call);

        partial void Modify_CreateGuestPolicyApiCall(ref gaxgrpc::ApiCall<CreateGuestPolicyRequest, GuestPolicy> call);

        partial void Modify_GetGuestPolicyApiCall(ref gaxgrpc::ApiCall<GetGuestPolicyRequest, GuestPolicy> call);

        partial void Modify_ListGuestPoliciesApiCall(ref gaxgrpc::ApiCall<ListGuestPoliciesRequest, ListGuestPoliciesResponse> call);

        partial void Modify_UpdateGuestPolicyApiCall(ref gaxgrpc::ApiCall<UpdateGuestPolicyRequest, GuestPolicy> call);

        partial void Modify_DeleteGuestPolicyApiCall(ref gaxgrpc::ApiCall<DeleteGuestPolicyRequest, wkt::Empty> call);

        partial void Modify_LookupEffectiveGuestPolicyApiCall(ref gaxgrpc::ApiCall<LookupEffectiveGuestPolicyRequest, EffectiveGuestPolicy> call);

        partial void OnConstruction(OsConfigService.OsConfigServiceClient grpcClient, OsConfigServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC OsConfigService client</summary>
        public override OsConfigService.OsConfigServiceClient GrpcClient { get; }

        partial void Modify_ExecutePatchJobRequest(ref ExecutePatchJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetPatchJobRequest(ref GetPatchJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CancelPatchJobRequest(ref CancelPatchJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPatchJobsRequest(ref ListPatchJobsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPatchJobInstanceDetailsRequest(ref ListPatchJobInstanceDetailsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreatePatchDeploymentRequest(ref CreatePatchDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetPatchDeploymentRequest(ref GetPatchDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPatchDeploymentsRequest(ref ListPatchDeploymentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeletePatchDeploymentRequest(ref DeletePatchDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateGuestPolicyRequest(ref CreateGuestPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetGuestPolicyRequest(ref GetGuestPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListGuestPoliciesRequest(ref ListGuestPoliciesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateGuestPolicyRequest(ref UpdateGuestPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteGuestPolicyRequest(ref DeleteGuestPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_LookupEffectiveGuestPolicyRequest(ref LookupEffectiveGuestPolicyRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Patch VM instances by creating and running a patch job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PatchJob ExecutePatchJob(ExecutePatchJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExecutePatchJobRequest(ref request, ref callSettings);
            return _callExecutePatchJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Patch VM instances by creating and running a patch job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PatchJob> ExecutePatchJobAsync(ExecutePatchJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExecutePatchJobRequest(ref request, ref callSettings);
            return _callExecutePatchJob.Async(request, callSettings);
        }

        /// <summary>
        /// Get the patch job. This can be used to track the progress of an
        /// ongoing patch job or review the details of completed jobs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PatchJob GetPatchJob(GetPatchJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPatchJobRequest(ref request, ref callSettings);
            return _callGetPatchJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Get the patch job. This can be used to track the progress of an
        /// ongoing patch job or review the details of completed jobs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PatchJob> GetPatchJobAsync(GetPatchJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPatchJobRequest(ref request, ref callSettings);
            return _callGetPatchJob.Async(request, callSettings);
        }

        /// <summary>
        /// Cancel a patch job. The patch job must be active. Canceled patch jobs
        /// cannot be restarted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PatchJob CancelPatchJob(CancelPatchJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelPatchJobRequest(ref request, ref callSettings);
            return _callCancelPatchJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Cancel a patch job. The patch job must be active. Canceled patch jobs
        /// cannot be restarted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PatchJob> CancelPatchJobAsync(CancelPatchJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelPatchJobRequest(ref request, ref callSettings);
            return _callCancelPatchJob.Async(request, callSettings);
        }

        /// <summary>
        /// Get a list of patch jobs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PatchJob"/> resources.</returns>
        public override gax::PagedEnumerable<ListPatchJobsResponse, PatchJob> ListPatchJobs(ListPatchJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPatchJobsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListPatchJobsRequest, ListPatchJobsResponse, PatchJob>(_callListPatchJobs, request, callSettings);
        }

        /// <summary>
        /// Get a list of patch jobs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PatchJob"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListPatchJobsResponse, PatchJob> ListPatchJobsAsync(ListPatchJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPatchJobsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListPatchJobsRequest, ListPatchJobsResponse, PatchJob>(_callListPatchJobs, request, callSettings);
        }

        /// <summary>
        /// Get a list of instance details for a given patch job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PatchJobInstanceDetails"/> resources.</returns>
        public override gax::PagedEnumerable<ListPatchJobInstanceDetailsResponse, PatchJobInstanceDetails> ListPatchJobInstanceDetails(ListPatchJobInstanceDetailsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPatchJobInstanceDetailsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListPatchJobInstanceDetailsRequest, ListPatchJobInstanceDetailsResponse, PatchJobInstanceDetails>(_callListPatchJobInstanceDetails, request, callSettings);
        }

        /// <summary>
        /// Get a list of instance details for a given patch job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PatchJobInstanceDetails"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListPatchJobInstanceDetailsResponse, PatchJobInstanceDetails> ListPatchJobInstanceDetailsAsync(ListPatchJobInstanceDetailsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPatchJobInstanceDetailsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListPatchJobInstanceDetailsRequest, ListPatchJobInstanceDetailsResponse, PatchJobInstanceDetails>(_callListPatchJobInstanceDetails, request, callSettings);
        }

        /// <summary>
        /// Create an OS Config patch deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PatchDeployment CreatePatchDeployment(CreatePatchDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePatchDeploymentRequest(ref request, ref callSettings);
            return _callCreatePatchDeployment.Sync(request, callSettings);
        }

        /// <summary>
        /// Create an OS Config patch deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PatchDeployment> CreatePatchDeploymentAsync(CreatePatchDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePatchDeploymentRequest(ref request, ref callSettings);
            return _callCreatePatchDeployment.Async(request, callSettings);
        }

        /// <summary>
        /// Get an OS Config patch deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PatchDeployment GetPatchDeployment(GetPatchDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPatchDeploymentRequest(ref request, ref callSettings);
            return _callGetPatchDeployment.Sync(request, callSettings);
        }

        /// <summary>
        /// Get an OS Config patch deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PatchDeployment> GetPatchDeploymentAsync(GetPatchDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPatchDeploymentRequest(ref request, ref callSettings);
            return _callGetPatchDeployment.Async(request, callSettings);
        }

        /// <summary>
        /// Get a page of OS Config patch deployments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PatchDeployment"/> resources.</returns>
        public override gax::PagedEnumerable<ListPatchDeploymentsResponse, PatchDeployment> ListPatchDeployments(ListPatchDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPatchDeploymentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListPatchDeploymentsRequest, ListPatchDeploymentsResponse, PatchDeployment>(_callListPatchDeployments, request, callSettings);
        }

        /// <summary>
        /// Get a page of OS Config patch deployments.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PatchDeployment"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListPatchDeploymentsResponse, PatchDeployment> ListPatchDeploymentsAsync(ListPatchDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPatchDeploymentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListPatchDeploymentsRequest, ListPatchDeploymentsResponse, PatchDeployment>(_callListPatchDeployments, request, callSettings);
        }

        /// <summary>
        /// Delete an OS Config patch deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeletePatchDeployment(DeletePatchDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePatchDeploymentRequest(ref request, ref callSettings);
            _callDeletePatchDeployment.Sync(request, callSettings);
        }

        /// <summary>
        /// Delete an OS Config patch deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeletePatchDeploymentAsync(DeletePatchDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePatchDeploymentRequest(ref request, ref callSettings);
            return _callDeletePatchDeployment.Async(request, callSettings);
        }

        /// <summary>
        /// Create an OS Config guest policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GuestPolicy CreateGuestPolicy(CreateGuestPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateGuestPolicyRequest(ref request, ref callSettings);
            return _callCreateGuestPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Create an OS Config guest policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GuestPolicy> CreateGuestPolicyAsync(CreateGuestPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateGuestPolicyRequest(ref request, ref callSettings);
            return _callCreateGuestPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Get an OS Config guest policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GuestPolicy GetGuestPolicy(GetGuestPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGuestPolicyRequest(ref request, ref callSettings);
            return _callGetGuestPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Get an OS Config guest policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GuestPolicy> GetGuestPolicyAsync(GetGuestPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGuestPolicyRequest(ref request, ref callSettings);
            return _callGetGuestPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Get a page of OS Config guest policies.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="GuestPolicy"/> resources.</returns>
        public override gax::PagedEnumerable<ListGuestPoliciesResponse, GuestPolicy> ListGuestPolicies(ListGuestPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGuestPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListGuestPoliciesRequest, ListGuestPoliciesResponse, GuestPolicy>(_callListGuestPolicies, request, callSettings);
        }

        /// <summary>
        /// Get a page of OS Config guest policies.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="GuestPolicy"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListGuestPoliciesResponse, GuestPolicy> ListGuestPoliciesAsync(ListGuestPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGuestPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListGuestPoliciesRequest, ListGuestPoliciesResponse, GuestPolicy>(_callListGuestPolicies, request, callSettings);
        }

        /// <summary>
        /// Update an OS Config guest policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GuestPolicy UpdateGuestPolicy(UpdateGuestPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateGuestPolicyRequest(ref request, ref callSettings);
            return _callUpdateGuestPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Update an OS Config guest policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GuestPolicy> UpdateGuestPolicyAsync(UpdateGuestPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateGuestPolicyRequest(ref request, ref callSettings);
            return _callUpdateGuestPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Delete an OS Config guest policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteGuestPolicy(DeleteGuestPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteGuestPolicyRequest(ref request, ref callSettings);
            _callDeleteGuestPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Delete an OS Config guest policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteGuestPolicyAsync(DeleteGuestPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteGuestPolicyRequest(ref request, ref callSettings);
            return _callDeleteGuestPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Lookup the effective guest policy that applies to a VM instance. This
        /// lookup merges all policies that are assigned to the instance ancestry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override EffectiveGuestPolicy LookupEffectiveGuestPolicy(LookupEffectiveGuestPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LookupEffectiveGuestPolicyRequest(ref request, ref callSettings);
            return _callLookupEffectiveGuestPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Lookup the effective guest policy that applies to a VM instance. This
        /// lookup merges all policies that are assigned to the instance ancestry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<EffectiveGuestPolicy> LookupEffectiveGuestPolicyAsync(LookupEffectiveGuestPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LookupEffectiveGuestPolicyRequest(ref request, ref callSettings);
            return _callLookupEffectiveGuestPolicy.Async(request, callSettings);
        }
    }

    public partial class ListPatchJobsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListPatchJobInstanceDetailsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListPatchDeploymentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListGuestPoliciesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListPatchJobsResponse : gaxgrpc::IPageResponse<PatchJob>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<PatchJob> GetEnumerator() => PatchJobs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListPatchJobInstanceDetailsResponse : gaxgrpc::IPageResponse<PatchJobInstanceDetails>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<PatchJobInstanceDetails> GetEnumerator() => PatchJobInstanceDetails.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListPatchDeploymentsResponse : gaxgrpc::IPageResponse<PatchDeployment>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<PatchDeployment> GetEnumerator() => PatchDeployments.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListGuestPoliciesResponse : gaxgrpc::IPageResponse<GuestPolicy>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<GuestPolicy> GetEnumerator() => GuestPolicies.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
