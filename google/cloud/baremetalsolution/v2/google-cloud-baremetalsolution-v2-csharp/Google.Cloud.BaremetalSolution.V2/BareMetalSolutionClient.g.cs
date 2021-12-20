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

namespace Google.Cloud.BaremetalSolution.V2
{
    /// <summary>Settings for <see cref="BareMetalSolutionClient"/> instances.</summary>
    public sealed partial class BareMetalSolutionSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="BareMetalSolutionSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="BareMetalSolutionSettings"/>.</returns>
        public static BareMetalSolutionSettings GetDefault() => new BareMetalSolutionSettings();

        /// <summary>Constructs a new <see cref="BareMetalSolutionSettings"/> object with default settings.</summary>
        public BareMetalSolutionSettings()
        {
        }

        private BareMetalSolutionSettings(BareMetalSolutionSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListInstancesSettings = existing.ListInstancesSettings;
            GetInstanceSettings = existing.GetInstanceSettings;
            ResetInstanceSettings = existing.ResetInstanceSettings;
            ResetInstanceOperationsSettings = existing.ResetInstanceOperationsSettings.Clone();
            ListVolumesSettings = existing.ListVolumesSettings;
            GetVolumeSettings = existing.GetVolumeSettings;
            UpdateVolumeSettings = existing.UpdateVolumeSettings;
            UpdateVolumeOperationsSettings = existing.UpdateVolumeOperationsSettings.Clone();
            ListNetworksSettings = existing.ListNetworksSettings;
            GetNetworkSettings = existing.GetNetworkSettings;
            ListSnapshotSchedulePoliciesSettings = existing.ListSnapshotSchedulePoliciesSettings;
            GetSnapshotSchedulePolicySettings = existing.GetSnapshotSchedulePolicySettings;
            CreateSnapshotSchedulePolicySettings = existing.CreateSnapshotSchedulePolicySettings;
            UpdateSnapshotSchedulePolicySettings = existing.UpdateSnapshotSchedulePolicySettings;
            DeleteSnapshotSchedulePolicySettings = existing.DeleteSnapshotSchedulePolicySettings;
            CreateVolumeSnapshotSettings = existing.CreateVolumeSnapshotSettings;
            RestoreVolumeSnapshotSettings = existing.RestoreVolumeSnapshotSettings;
            RestoreVolumeSnapshotOperationsSettings = existing.RestoreVolumeSnapshotOperationsSettings.Clone();
            DeleteVolumeSnapshotSettings = existing.DeleteVolumeSnapshotSettings;
            GetVolumeSnapshotSettings = existing.GetVolumeSnapshotSettings;
            ListVolumeSnapshotsSettings = existing.ListVolumeSnapshotsSettings;
            GetLunSettings = existing.GetLunSettings;
            ListLunsSettings = existing.ListLunsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(BareMetalSolutionSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.ListInstances</c> and <c>BareMetalSolutionClient.ListInstancesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListInstancesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.GetInstance</c> and <c>BareMetalSolutionClient.GetInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.ResetInstance</c> and <c>BareMetalSolutionClient.ResetInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ResetInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BareMetalSolutionClient.ResetInstance</c> and
        /// <c>BareMetalSolutionClient.ResetInstanceAsync</c>.
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
        public lro::OperationsSettings ResetInstanceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.ListVolumes</c> and <c>BareMetalSolutionClient.ListVolumesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListVolumesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.GetVolume</c> and <c>BareMetalSolutionClient.GetVolumeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetVolumeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.UpdateVolume</c> and <c>BareMetalSolutionClient.UpdateVolumeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateVolumeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BareMetalSolutionClient.UpdateVolume</c> and
        /// <c>BareMetalSolutionClient.UpdateVolumeAsync</c>.
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
        public lro::OperationsSettings UpdateVolumeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.ListNetworks</c> and <c>BareMetalSolutionClient.ListNetworksAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListNetworksSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.GetNetwork</c> and <c>BareMetalSolutionClient.GetNetworkAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetNetworkSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.ListSnapshotSchedulePolicies</c> and
        /// <c>BareMetalSolutionClient.ListSnapshotSchedulePoliciesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSnapshotSchedulePoliciesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.GetSnapshotSchedulePolicy</c> and
        /// <c>BareMetalSolutionClient.GetSnapshotSchedulePolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSnapshotSchedulePolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.CreateSnapshotSchedulePolicy</c> and
        /// <c>BareMetalSolutionClient.CreateSnapshotSchedulePolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateSnapshotSchedulePolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.UpdateSnapshotSchedulePolicy</c> and
        /// <c>BareMetalSolutionClient.UpdateSnapshotSchedulePolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSnapshotSchedulePolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.DeleteSnapshotSchedulePolicy</c> and
        /// <c>BareMetalSolutionClient.DeleteSnapshotSchedulePolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSnapshotSchedulePolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.CreateVolumeSnapshot</c> and <c>BareMetalSolutionClient.CreateVolumeSnapshotAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateVolumeSnapshotSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.RestoreVolumeSnapshot</c> and
        /// <c>BareMetalSolutionClient.RestoreVolumeSnapshotAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RestoreVolumeSnapshotSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BareMetalSolutionClient.RestoreVolumeSnapshot</c> and
        /// <c>BareMetalSolutionClient.RestoreVolumeSnapshotAsync</c>.
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
        public lro::OperationsSettings RestoreVolumeSnapshotOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.DeleteVolumeSnapshot</c> and <c>BareMetalSolutionClient.DeleteVolumeSnapshotAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteVolumeSnapshotSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.GetVolumeSnapshot</c> and <c>BareMetalSolutionClient.GetVolumeSnapshotAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetVolumeSnapshotSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.ListVolumeSnapshots</c> and <c>BareMetalSolutionClient.ListVolumeSnapshotsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListVolumeSnapshotsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.GetLun</c> and <c>BareMetalSolutionClient.GetLunAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetLunSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BareMetalSolutionClient.ListLuns</c> and <c>BareMetalSolutionClient.ListLunsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListLunsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="BareMetalSolutionSettings"/> object.</returns>
        public BareMetalSolutionSettings Clone() => new BareMetalSolutionSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="BareMetalSolutionClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class BareMetalSolutionClientBuilder : gaxgrpc::ClientBuilderBase<BareMetalSolutionClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public BareMetalSolutionSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public BareMetalSolutionClientBuilder()
        {
            UseJwtAccessWithScopes = BareMetalSolutionClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref BareMetalSolutionClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<BareMetalSolutionClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override BareMetalSolutionClient Build()
        {
            BareMetalSolutionClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<BareMetalSolutionClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<BareMetalSolutionClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private BareMetalSolutionClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return BareMetalSolutionClient.Create(callInvoker, Settings);
        }

        private async stt::Task<BareMetalSolutionClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return BareMetalSolutionClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => BareMetalSolutionClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => BareMetalSolutionClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => BareMetalSolutionClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>BareMetalSolution client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Performs management operations on Bare Metal Solution servers.
    /// 
    /// The `baremetalsolution.googleapis.com` service provides management
    /// capabilities for Bare Metal Solution servers. To access the API methods, you
    /// must assign Bare Metal Solution IAM roles containing the desired permissions
    /// to your staff in your Google Cloud project. You must also enable the Bare
    /// Metal Solution API. Once enabled, the methods act
    /// upon specific servers in your Bare Metal Solution environment.
    /// </remarks>
    public abstract partial class BareMetalSolutionClient
    {
        /// <summary>
        /// The default endpoint for the BareMetalSolution service, which is a host of
        /// "baremetalsolution.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "baremetalsolution.googleapis.com:443";

        /// <summary>The default BareMetalSolution scopes.</summary>
        /// <remarks>
        /// The default BareMetalSolution scopes are:
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
        /// Asynchronously creates a <see cref="BareMetalSolutionClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="BareMetalSolutionClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="BareMetalSolutionClient"/>.</returns>
        public static stt::Task<BareMetalSolutionClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new BareMetalSolutionClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="BareMetalSolutionClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="BareMetalSolutionClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="BareMetalSolutionClient"/>.</returns>
        public static BareMetalSolutionClient Create() => new BareMetalSolutionClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="BareMetalSolutionClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="BareMetalSolutionSettings"/>.</param>
        /// <returns>The created <see cref="BareMetalSolutionClient"/>.</returns>
        internal static BareMetalSolutionClient Create(grpccore::CallInvoker callInvoker, BareMetalSolutionSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            BareMetalSolution.BareMetalSolutionClient grpcClient = new BareMetalSolution.BareMetalSolutionClient(callInvoker);
            return new BareMetalSolutionClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC BareMetalSolution client</summary>
        public virtual BareMetalSolution.BareMetalSolutionClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// List servers in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Instance"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInstancesResponse, Instance> ListInstances(ListInstancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List servers in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Instance"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInstancesResponse, Instance> ListInstancesAsync(ListInstancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List servers in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListInstancesRequest.
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
        /// <returns>A pageable sequence of <see cref="Instance"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInstancesResponse, Instance> ListInstances(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListInstances(new ListInstancesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List servers in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListInstancesRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Instance"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInstancesResponse, Instance> ListInstancesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListInstancesAsync(new ListInstancesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List servers in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListInstancesRequest.
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
        /// <returns>A pageable sequence of <see cref="Instance"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInstancesResponse, Instance> ListInstances(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListInstances(new ListInstancesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List servers in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListInstancesRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Instance"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInstancesResponse, Instance> ListInstancesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListInstancesAsync(new ListInstancesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Get details about a single server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Instance GetInstance(GetInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get details about a single server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(GetInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get details about a single server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(GetInstanceRequest request, st::CancellationToken cancellationToken) =>
            GetInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get details about a single server.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Instance GetInstance(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstance(new GetInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details about a single server.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstanceAsync(new GetInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details about a single server.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(string name, st::CancellationToken cancellationToken) =>
            GetInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get details about a single server.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Instance GetInstance(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstance(new GetInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details about a single server.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstanceAsync(new GetInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details about a single server.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(InstanceName name, st::CancellationToken cancellationToken) =>
            GetInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Perform an ungraceful, hard reset on a server. Equivalent to shutting the
        /// power off and then turning it back on.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ResetInstanceResponse, OperationMetadata> ResetInstance(ResetInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Perform an ungraceful, hard reset on a server. Equivalent to shutting the
        /// power off and then turning it back on.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ResetInstanceResponse, OperationMetadata>> ResetInstanceAsync(ResetInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Perform an ungraceful, hard reset on a server. Equivalent to shutting the
        /// power off and then turning it back on.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ResetInstanceResponse, OperationMetadata>> ResetInstanceAsync(ResetInstanceRequest request, st::CancellationToken cancellationToken) =>
            ResetInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ResetInstance</c>.</summary>
        public virtual lro::OperationsClient ResetInstanceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ResetInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ResetInstanceResponse, OperationMetadata> PollOnceResetInstance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ResetInstanceResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ResetInstanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ResetInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ResetInstanceResponse, OperationMetadata>> PollOnceResetInstanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ResetInstanceResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ResetInstanceOperationsClient, callSettings);

        /// <summary>
        /// Perform an ungraceful, hard reset on a server. Equivalent to shutting the
        /// power off and then turning it back on.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ResetInstanceResponse, OperationMetadata> ResetInstance(string name, gaxgrpc::CallSettings callSettings = null) =>
            ResetInstance(new ResetInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Perform an ungraceful, hard reset on a server. Equivalent to shutting the
        /// power off and then turning it back on.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ResetInstanceResponse, OperationMetadata>> ResetInstanceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            ResetInstanceAsync(new ResetInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Perform an ungraceful, hard reset on a server. Equivalent to shutting the
        /// power off and then turning it back on.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ResetInstanceResponse, OperationMetadata>> ResetInstanceAsync(string name, st::CancellationToken cancellationToken) =>
            ResetInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Perform an ungraceful, hard reset on a server. Equivalent to shutting the
        /// power off and then turning it back on.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ResetInstanceResponse, OperationMetadata> ResetInstance(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            ResetInstance(new ResetInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Perform an ungraceful, hard reset on a server. Equivalent to shutting the
        /// power off and then turning it back on.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ResetInstanceResponse, OperationMetadata>> ResetInstanceAsync(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            ResetInstanceAsync(new ResetInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Perform an ungraceful, hard reset on a server. Equivalent to shutting the
        /// power off and then turning it back on.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ResetInstanceResponse, OperationMetadata>> ResetInstanceAsync(InstanceName name, st::CancellationToken cancellationToken) =>
            ResetInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List storage volumes in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Volume"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListVolumesResponse, Volume> ListVolumes(ListVolumesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List storage volumes in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Volume"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListVolumesResponse, Volume> ListVolumesAsync(ListVolumesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List storage volumes in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListVolumesRequest.
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
        /// <returns>A pageable sequence of <see cref="Volume"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListVolumesResponse, Volume> ListVolumes(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListVolumes(new ListVolumesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List storage volumes in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListVolumesRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Volume"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListVolumesResponse, Volume> ListVolumesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListVolumesAsync(new ListVolumesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List storage volumes in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListVolumesRequest.
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
        /// <returns>A pageable sequence of <see cref="Volume"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListVolumesResponse, Volume> ListVolumes(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListVolumes(new ListVolumesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List storage volumes in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListVolumesRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Volume"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListVolumesResponse, Volume> ListVolumesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListVolumesAsync(new ListVolumesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Get details of a single storage volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Volume GetVolume(GetVolumeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get details of a single storage volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Volume> GetVolumeAsync(GetVolumeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get details of a single storage volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Volume> GetVolumeAsync(GetVolumeRequest request, st::CancellationToken cancellationToken) =>
            GetVolumeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get details of a single storage volume.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Volume GetVolume(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetVolume(new GetVolumeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details of a single storage volume.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Volume> GetVolumeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetVolumeAsync(new GetVolumeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details of a single storage volume.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Volume> GetVolumeAsync(string name, st::CancellationToken cancellationToken) =>
            GetVolumeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get details of a single storage volume.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Volume GetVolume(VolumeName name, gaxgrpc::CallSettings callSettings = null) =>
            GetVolume(new GetVolumeRequest
            {
                VolumeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details of a single storage volume.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Volume> GetVolumeAsync(VolumeName name, gaxgrpc::CallSettings callSettings = null) =>
            GetVolumeAsync(new GetVolumeRequest
            {
                VolumeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details of a single storage volume.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Volume> GetVolumeAsync(VolumeName name, st::CancellationToken cancellationToken) =>
            GetVolumeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update details of a single storage volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Volume, OperationMetadata> UpdateVolume(UpdateVolumeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update details of a single storage volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Volume, OperationMetadata>> UpdateVolumeAsync(UpdateVolumeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update details of a single storage volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Volume, OperationMetadata>> UpdateVolumeAsync(UpdateVolumeRequest request, st::CancellationToken cancellationToken) =>
            UpdateVolumeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateVolume</c>.</summary>
        public virtual lro::OperationsClient UpdateVolumeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateVolume</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Volume, OperationMetadata> PollOnceUpdateVolume(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Volume, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateVolumeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateVolume</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Volume, OperationMetadata>> PollOnceUpdateVolumeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Volume, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateVolumeOperationsClient, callSettings);

        /// <summary>
        /// Update details of a single storage volume.
        /// </summary>
        /// <param name="volume">
        /// Required. The volume to update.
        /// 
        /// The `name` field is used to identify the volume to update.
        /// Format: projects/{project}/locations/{location}/volumes/{volume}
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to update.
        /// The only currently supported fields are:
        /// `snapshot_auto_delete_behavior`
        /// `snapshot_schedule_policy_name`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Volume, OperationMetadata> UpdateVolume(Volume volume, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateVolume(new UpdateVolumeRequest
            {
                Volume = gax::GaxPreconditions.CheckNotNull(volume, nameof(volume)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update details of a single storage volume.
        /// </summary>
        /// <param name="volume">
        /// Required. The volume to update.
        /// 
        /// The `name` field is used to identify the volume to update.
        /// Format: projects/{project}/locations/{location}/volumes/{volume}
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to update.
        /// The only currently supported fields are:
        /// `snapshot_auto_delete_behavior`
        /// `snapshot_schedule_policy_name`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Volume, OperationMetadata>> UpdateVolumeAsync(Volume volume, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateVolumeAsync(new UpdateVolumeRequest
            {
                Volume = gax::GaxPreconditions.CheckNotNull(volume, nameof(volume)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update details of a single storage volume.
        /// </summary>
        /// <param name="volume">
        /// Required. The volume to update.
        /// 
        /// The `name` field is used to identify the volume to update.
        /// Format: projects/{project}/locations/{location}/volumes/{volume}
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to update.
        /// The only currently supported fields are:
        /// `snapshot_auto_delete_behavior`
        /// `snapshot_schedule_policy_name`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Volume, OperationMetadata>> UpdateVolumeAsync(Volume volume, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateVolumeAsync(volume, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List network in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Network"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNetworksResponse, Network> ListNetworks(ListNetworksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List network in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Network"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNetworksResponse, Network> ListNetworksAsync(ListNetworksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List network in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListNetworksRequest.
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
        /// <returns>A pageable sequence of <see cref="Network"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNetworksResponse, Network> ListNetworks(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListNetworks(new ListNetworksRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List network in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListNetworksRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Network"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNetworksResponse, Network> ListNetworksAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListNetworksAsync(new ListNetworksRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List network in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListNetworksRequest.
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
        /// <returns>A pageable sequence of <see cref="Network"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNetworksResponse, Network> ListNetworks(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListNetworks(new ListNetworksRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List network in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListNetworksRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Network"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNetworksResponse, Network> ListNetworksAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListNetworksAsync(new ListNetworksRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Get details of a single network.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Network GetNetwork(GetNetworkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get details of a single network.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Network> GetNetworkAsync(GetNetworkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get details of a single network.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Network> GetNetworkAsync(GetNetworkRequest request, st::CancellationToken cancellationToken) =>
            GetNetworkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get details of a single network.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Network GetNetwork(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetNetwork(new GetNetworkRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details of a single network.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Network> GetNetworkAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetNetworkAsync(new GetNetworkRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details of a single network.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Network> GetNetworkAsync(string name, st::CancellationToken cancellationToken) =>
            GetNetworkAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get details of a single network.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Network GetNetwork(NetworkName name, gaxgrpc::CallSettings callSettings = null) =>
            GetNetwork(new GetNetworkRequest
            {
                NetworkName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details of a single network.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Network> GetNetworkAsync(NetworkName name, gaxgrpc::CallSettings callSettings = null) =>
            GetNetworkAsync(new GetNetworkRequest
            {
                NetworkName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details of a single network.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Network> GetNetworkAsync(NetworkName name, st::CancellationToken cancellationToken) =>
            GetNetworkAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List snapshot schedule policies in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SnapshotSchedulePolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSnapshotSchedulePoliciesResponse, SnapshotSchedulePolicy> ListSnapshotSchedulePolicies(ListSnapshotSchedulePoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List snapshot schedule policies in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SnapshotSchedulePolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSnapshotSchedulePoliciesResponse, SnapshotSchedulePolicy> ListSnapshotSchedulePoliciesAsync(ListSnapshotSchedulePoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List snapshot schedule policies in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent project containing the Snapshot Schedule Policies.
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
        /// <returns>A pageable sequence of <see cref="SnapshotSchedulePolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSnapshotSchedulePoliciesResponse, SnapshotSchedulePolicy> ListSnapshotSchedulePolicies(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListSnapshotSchedulePolicies(new ListSnapshotSchedulePoliciesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List snapshot schedule policies in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent project containing the Snapshot Schedule Policies.
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
        /// <returns>A pageable asynchronous sequence of <see cref="SnapshotSchedulePolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSnapshotSchedulePoliciesResponse, SnapshotSchedulePolicy> ListSnapshotSchedulePoliciesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListSnapshotSchedulePoliciesAsync(new ListSnapshotSchedulePoliciesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List snapshot schedule policies in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent project containing the Snapshot Schedule Policies.
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
        /// <returns>A pageable sequence of <see cref="SnapshotSchedulePolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSnapshotSchedulePoliciesResponse, SnapshotSchedulePolicy> ListSnapshotSchedulePolicies(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListSnapshotSchedulePolicies(new ListSnapshotSchedulePoliciesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List snapshot schedule policies in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent project containing the Snapshot Schedule Policies.
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
        /// <returns>A pageable asynchronous sequence of <see cref="SnapshotSchedulePolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSnapshotSchedulePoliciesResponse, SnapshotSchedulePolicy> ListSnapshotSchedulePoliciesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListSnapshotSchedulePoliciesAsync(new ListSnapshotSchedulePoliciesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Get details of a single snapshot schedule policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SnapshotSchedulePolicy GetSnapshotSchedulePolicy(GetSnapshotSchedulePolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get details of a single snapshot schedule policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SnapshotSchedulePolicy> GetSnapshotSchedulePolicyAsync(GetSnapshotSchedulePolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get details of a single snapshot schedule policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SnapshotSchedulePolicy> GetSnapshotSchedulePolicyAsync(GetSnapshotSchedulePolicyRequest request, st::CancellationToken cancellationToken) =>
            GetSnapshotSchedulePolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get details of a single snapshot schedule policy.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SnapshotSchedulePolicy GetSnapshotSchedulePolicy(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSnapshotSchedulePolicy(new GetSnapshotSchedulePolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details of a single snapshot schedule policy.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SnapshotSchedulePolicy> GetSnapshotSchedulePolicyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSnapshotSchedulePolicyAsync(new GetSnapshotSchedulePolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details of a single snapshot schedule policy.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SnapshotSchedulePolicy> GetSnapshotSchedulePolicyAsync(string name, st::CancellationToken cancellationToken) =>
            GetSnapshotSchedulePolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get details of a single snapshot schedule policy.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SnapshotSchedulePolicy GetSnapshotSchedulePolicy(SnapshotSchedulePolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSnapshotSchedulePolicy(new GetSnapshotSchedulePolicyRequest
            {
                SnapshotSchedulePolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details of a single snapshot schedule policy.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SnapshotSchedulePolicy> GetSnapshotSchedulePolicyAsync(SnapshotSchedulePolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSnapshotSchedulePolicyAsync(new GetSnapshotSchedulePolicyRequest
            {
                SnapshotSchedulePolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details of a single snapshot schedule policy.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SnapshotSchedulePolicy> GetSnapshotSchedulePolicyAsync(SnapshotSchedulePolicyName name, st::CancellationToken cancellationToken) =>
            GetSnapshotSchedulePolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a snapshot schedule policy in the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SnapshotSchedulePolicy CreateSnapshotSchedulePolicy(CreateSnapshotSchedulePolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a snapshot schedule policy in the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SnapshotSchedulePolicy> CreateSnapshotSchedulePolicyAsync(CreateSnapshotSchedulePolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a snapshot schedule policy in the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SnapshotSchedulePolicy> CreateSnapshotSchedulePolicyAsync(CreateSnapshotSchedulePolicyRequest request, st::CancellationToken cancellationToken) =>
            CreateSnapshotSchedulePolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a snapshot schedule policy in the specified project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent project and location containing the SnapshotSchedulePolicy.
        /// </param>
        /// <param name="snapshotSchedulePolicy">
        /// Required. The SnapshotSchedulePolicy to create.
        /// </param>
        /// <param name="snapshotSchedulePolicyId">
        /// Required. Snapshot policy ID
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SnapshotSchedulePolicy CreateSnapshotSchedulePolicy(string parent, SnapshotSchedulePolicy snapshotSchedulePolicy, string snapshotSchedulePolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSnapshotSchedulePolicy(new CreateSnapshotSchedulePolicyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SnapshotSchedulePolicy = gax::GaxPreconditions.CheckNotNull(snapshotSchedulePolicy, nameof(snapshotSchedulePolicy)),
                SnapshotSchedulePolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(snapshotSchedulePolicyId, nameof(snapshotSchedulePolicyId)),
            }, callSettings);

        /// <summary>
        /// Create a snapshot schedule policy in the specified project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent project and location containing the SnapshotSchedulePolicy.
        /// </param>
        /// <param name="snapshotSchedulePolicy">
        /// Required. The SnapshotSchedulePolicy to create.
        /// </param>
        /// <param name="snapshotSchedulePolicyId">
        /// Required. Snapshot policy ID
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SnapshotSchedulePolicy> CreateSnapshotSchedulePolicyAsync(string parent, SnapshotSchedulePolicy snapshotSchedulePolicy, string snapshotSchedulePolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSnapshotSchedulePolicyAsync(new CreateSnapshotSchedulePolicyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SnapshotSchedulePolicy = gax::GaxPreconditions.CheckNotNull(snapshotSchedulePolicy, nameof(snapshotSchedulePolicy)),
                SnapshotSchedulePolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(snapshotSchedulePolicyId, nameof(snapshotSchedulePolicyId)),
            }, callSettings);

        /// <summary>
        /// Create a snapshot schedule policy in the specified project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent project and location containing the SnapshotSchedulePolicy.
        /// </param>
        /// <param name="snapshotSchedulePolicy">
        /// Required. The SnapshotSchedulePolicy to create.
        /// </param>
        /// <param name="snapshotSchedulePolicyId">
        /// Required. Snapshot policy ID
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SnapshotSchedulePolicy> CreateSnapshotSchedulePolicyAsync(string parent, SnapshotSchedulePolicy snapshotSchedulePolicy, string snapshotSchedulePolicyId, st::CancellationToken cancellationToken) =>
            CreateSnapshotSchedulePolicyAsync(parent, snapshotSchedulePolicy, snapshotSchedulePolicyId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a snapshot schedule policy in the specified project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent project and location containing the SnapshotSchedulePolicy.
        /// </param>
        /// <param name="snapshotSchedulePolicy">
        /// Required. The SnapshotSchedulePolicy to create.
        /// </param>
        /// <param name="snapshotSchedulePolicyId">
        /// Required. Snapshot policy ID
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SnapshotSchedulePolicy CreateSnapshotSchedulePolicy(gagr::LocationName parent, SnapshotSchedulePolicy snapshotSchedulePolicy, string snapshotSchedulePolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSnapshotSchedulePolicy(new CreateSnapshotSchedulePolicyRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SnapshotSchedulePolicy = gax::GaxPreconditions.CheckNotNull(snapshotSchedulePolicy, nameof(snapshotSchedulePolicy)),
                SnapshotSchedulePolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(snapshotSchedulePolicyId, nameof(snapshotSchedulePolicyId)),
            }, callSettings);

        /// <summary>
        /// Create a snapshot schedule policy in the specified project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent project and location containing the SnapshotSchedulePolicy.
        /// </param>
        /// <param name="snapshotSchedulePolicy">
        /// Required. The SnapshotSchedulePolicy to create.
        /// </param>
        /// <param name="snapshotSchedulePolicyId">
        /// Required. Snapshot policy ID
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SnapshotSchedulePolicy> CreateSnapshotSchedulePolicyAsync(gagr::LocationName parent, SnapshotSchedulePolicy snapshotSchedulePolicy, string snapshotSchedulePolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSnapshotSchedulePolicyAsync(new CreateSnapshotSchedulePolicyRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SnapshotSchedulePolicy = gax::GaxPreconditions.CheckNotNull(snapshotSchedulePolicy, nameof(snapshotSchedulePolicy)),
                SnapshotSchedulePolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(snapshotSchedulePolicyId, nameof(snapshotSchedulePolicyId)),
            }, callSettings);

        /// <summary>
        /// Create a snapshot schedule policy in the specified project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent project and location containing the SnapshotSchedulePolicy.
        /// </param>
        /// <param name="snapshotSchedulePolicy">
        /// Required. The SnapshotSchedulePolicy to create.
        /// </param>
        /// <param name="snapshotSchedulePolicyId">
        /// Required. Snapshot policy ID
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SnapshotSchedulePolicy> CreateSnapshotSchedulePolicyAsync(gagr::LocationName parent, SnapshotSchedulePolicy snapshotSchedulePolicy, string snapshotSchedulePolicyId, st::CancellationToken cancellationToken) =>
            CreateSnapshotSchedulePolicyAsync(parent, snapshotSchedulePolicy, snapshotSchedulePolicyId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a snapshot schedule policy in the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SnapshotSchedulePolicy UpdateSnapshotSchedulePolicy(UpdateSnapshotSchedulePolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a snapshot schedule policy in the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SnapshotSchedulePolicy> UpdateSnapshotSchedulePolicyAsync(UpdateSnapshotSchedulePolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a snapshot schedule policy in the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SnapshotSchedulePolicy> UpdateSnapshotSchedulePolicyAsync(UpdateSnapshotSchedulePolicyRequest request, st::CancellationToken cancellationToken) =>
            UpdateSnapshotSchedulePolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a snapshot schedule policy in the specified project.
        /// </summary>
        /// <param name="snapshotSchedulePolicy">
        /// Required. The snapshot schedule policy to update.
        /// 
        /// The `name` field is used to identify the snapshot schedule policy to
        /// update. Format:
        /// projects/{project}/locations/global/snapshotSchedulePolicies/{policy}
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SnapshotSchedulePolicy UpdateSnapshotSchedulePolicy(SnapshotSchedulePolicy snapshotSchedulePolicy, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSnapshotSchedulePolicy(new UpdateSnapshotSchedulePolicyRequest
            {
                SnapshotSchedulePolicy = gax::GaxPreconditions.CheckNotNull(snapshotSchedulePolicy, nameof(snapshotSchedulePolicy)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Update a snapshot schedule policy in the specified project.
        /// </summary>
        /// <param name="snapshotSchedulePolicy">
        /// Required. The snapshot schedule policy to update.
        /// 
        /// The `name` field is used to identify the snapshot schedule policy to
        /// update. Format:
        /// projects/{project}/locations/global/snapshotSchedulePolicies/{policy}
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SnapshotSchedulePolicy> UpdateSnapshotSchedulePolicyAsync(SnapshotSchedulePolicy snapshotSchedulePolicy, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSnapshotSchedulePolicyAsync(new UpdateSnapshotSchedulePolicyRequest
            {
                SnapshotSchedulePolicy = gax::GaxPreconditions.CheckNotNull(snapshotSchedulePolicy, nameof(snapshotSchedulePolicy)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Update a snapshot schedule policy in the specified project.
        /// </summary>
        /// <param name="snapshotSchedulePolicy">
        /// Required. The snapshot schedule policy to update.
        /// 
        /// The `name` field is used to identify the snapshot schedule policy to
        /// update. Format:
        /// projects/{project}/locations/global/snapshotSchedulePolicies/{policy}
        /// </param>
        /// <param name="updateMask">
        /// Required. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SnapshotSchedulePolicy> UpdateSnapshotSchedulePolicyAsync(SnapshotSchedulePolicy snapshotSchedulePolicy, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateSnapshotSchedulePolicyAsync(snapshotSchedulePolicy, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a named snapshot schedule policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSnapshotSchedulePolicy(DeleteSnapshotSchedulePolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a named snapshot schedule policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSnapshotSchedulePolicyAsync(DeleteSnapshotSchedulePolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a named snapshot schedule policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSnapshotSchedulePolicyAsync(DeleteSnapshotSchedulePolicyRequest request, st::CancellationToken cancellationToken) =>
            DeleteSnapshotSchedulePolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a named snapshot schedule policy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the snapshot schedule policy to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSnapshotSchedulePolicy(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSnapshotSchedulePolicy(new DeleteSnapshotSchedulePolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a named snapshot schedule policy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the snapshot schedule policy to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSnapshotSchedulePolicyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSnapshotSchedulePolicyAsync(new DeleteSnapshotSchedulePolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a named snapshot schedule policy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the snapshot schedule policy to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSnapshotSchedulePolicyAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteSnapshotSchedulePolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a named snapshot schedule policy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the snapshot schedule policy to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSnapshotSchedulePolicy(SnapshotSchedulePolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSnapshotSchedulePolicy(new DeleteSnapshotSchedulePolicyRequest
            {
                SnapshotSchedulePolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a named snapshot schedule policy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the snapshot schedule policy to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSnapshotSchedulePolicyAsync(SnapshotSchedulePolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSnapshotSchedulePolicyAsync(new DeleteSnapshotSchedulePolicyRequest
            {
                SnapshotSchedulePolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a named snapshot schedule policy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the snapshot schedule policy to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSnapshotSchedulePolicyAsync(SnapshotSchedulePolicyName name, st::CancellationToken cancellationToken) =>
            DeleteSnapshotSchedulePolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a storage volume snapshot in a containing volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual VolumeSnapshot CreateVolumeSnapshot(CreateVolumeSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a storage volume snapshot in a containing volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VolumeSnapshot> CreateVolumeSnapshotAsync(CreateVolumeSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a storage volume snapshot in a containing volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VolumeSnapshot> CreateVolumeSnapshotAsync(CreateVolumeSnapshotRequest request, st::CancellationToken cancellationToken) =>
            CreateVolumeSnapshotAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a storage volume snapshot in a containing volume.
        /// </summary>
        /// <param name="parent">
        /// Required. The volume to snapshot.
        /// </param>
        /// <param name="volumeSnapshot">
        /// Required. The volume snapshot to create. Only the description field may be specified.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual VolumeSnapshot CreateVolumeSnapshot(string parent, VolumeSnapshot volumeSnapshot, gaxgrpc::CallSettings callSettings = null) =>
            CreateVolumeSnapshot(new CreateVolumeSnapshotRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                VolumeSnapshot = gax::GaxPreconditions.CheckNotNull(volumeSnapshot, nameof(volumeSnapshot)),
            }, callSettings);

        /// <summary>
        /// Create a storage volume snapshot in a containing volume.
        /// </summary>
        /// <param name="parent">
        /// Required. The volume to snapshot.
        /// </param>
        /// <param name="volumeSnapshot">
        /// Required. The volume snapshot to create. Only the description field may be specified.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VolumeSnapshot> CreateVolumeSnapshotAsync(string parent, VolumeSnapshot volumeSnapshot, gaxgrpc::CallSettings callSettings = null) =>
            CreateVolumeSnapshotAsync(new CreateVolumeSnapshotRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                VolumeSnapshot = gax::GaxPreconditions.CheckNotNull(volumeSnapshot, nameof(volumeSnapshot)),
            }, callSettings);

        /// <summary>
        /// Create a storage volume snapshot in a containing volume.
        /// </summary>
        /// <param name="parent">
        /// Required. The volume to snapshot.
        /// </param>
        /// <param name="volumeSnapshot">
        /// Required. The volume snapshot to create. Only the description field may be specified.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VolumeSnapshot> CreateVolumeSnapshotAsync(string parent, VolumeSnapshot volumeSnapshot, st::CancellationToken cancellationToken) =>
            CreateVolumeSnapshotAsync(parent, volumeSnapshot, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a storage volume snapshot in a containing volume.
        /// </summary>
        /// <param name="parent">
        /// Required. The volume to snapshot.
        /// </param>
        /// <param name="volumeSnapshot">
        /// Required. The volume snapshot to create. Only the description field may be specified.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual VolumeSnapshot CreateVolumeSnapshot(VolumeName parent, VolumeSnapshot volumeSnapshot, gaxgrpc::CallSettings callSettings = null) =>
            CreateVolumeSnapshot(new CreateVolumeSnapshotRequest
            {
                ParentAsVolumeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                VolumeSnapshot = gax::GaxPreconditions.CheckNotNull(volumeSnapshot, nameof(volumeSnapshot)),
            }, callSettings);

        /// <summary>
        /// Create a storage volume snapshot in a containing volume.
        /// </summary>
        /// <param name="parent">
        /// Required. The volume to snapshot.
        /// </param>
        /// <param name="volumeSnapshot">
        /// Required. The volume snapshot to create. Only the description field may be specified.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VolumeSnapshot> CreateVolumeSnapshotAsync(VolumeName parent, VolumeSnapshot volumeSnapshot, gaxgrpc::CallSettings callSettings = null) =>
            CreateVolumeSnapshotAsync(new CreateVolumeSnapshotRequest
            {
                ParentAsVolumeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                VolumeSnapshot = gax::GaxPreconditions.CheckNotNull(volumeSnapshot, nameof(volumeSnapshot)),
            }, callSettings);

        /// <summary>
        /// Create a storage volume snapshot in a containing volume.
        /// </summary>
        /// <param name="parent">
        /// Required. The volume to snapshot.
        /// </param>
        /// <param name="volumeSnapshot">
        /// Required. The volume snapshot to create. Only the description field may be specified.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VolumeSnapshot> CreateVolumeSnapshotAsync(VolumeName parent, VolumeSnapshot volumeSnapshot, st::CancellationToken cancellationToken) =>
            CreateVolumeSnapshotAsync(parent, volumeSnapshot, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Restore a storage volume snapshot to its containing volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<VolumeSnapshot, OperationMetadata> RestoreVolumeSnapshot(RestoreVolumeSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Restore a storage volume snapshot to its containing volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<VolumeSnapshot, OperationMetadata>> RestoreVolumeSnapshotAsync(RestoreVolumeSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Restore a storage volume snapshot to its containing volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<VolumeSnapshot, OperationMetadata>> RestoreVolumeSnapshotAsync(RestoreVolumeSnapshotRequest request, st::CancellationToken cancellationToken) =>
            RestoreVolumeSnapshotAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RestoreVolumeSnapshot</c>.</summary>
        public virtual lro::OperationsClient RestoreVolumeSnapshotOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RestoreVolumeSnapshot</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<VolumeSnapshot, OperationMetadata> PollOnceRestoreVolumeSnapshot(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<VolumeSnapshot, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RestoreVolumeSnapshotOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RestoreVolumeSnapshot</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<VolumeSnapshot, OperationMetadata>> PollOnceRestoreVolumeSnapshotAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<VolumeSnapshot, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RestoreVolumeSnapshotOperationsClient, callSettings);

        /// <summary>
        /// Restore a storage volume snapshot to its containing volume.
        /// </summary>
        /// <param name="volumeSnapshot">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<VolumeSnapshot, OperationMetadata> RestoreVolumeSnapshot(string volumeSnapshot, gaxgrpc::CallSettings callSettings = null) =>
            RestoreVolumeSnapshot(new RestoreVolumeSnapshotRequest
            {
                VolumeSnapshot = gax::GaxPreconditions.CheckNotNullOrEmpty(volumeSnapshot, nameof(volumeSnapshot)),
            }, callSettings);

        /// <summary>
        /// Restore a storage volume snapshot to its containing volume.
        /// </summary>
        /// <param name="volumeSnapshot">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<VolumeSnapshot, OperationMetadata>> RestoreVolumeSnapshotAsync(string volumeSnapshot, gaxgrpc::CallSettings callSettings = null) =>
            RestoreVolumeSnapshotAsync(new RestoreVolumeSnapshotRequest
            {
                VolumeSnapshot = gax::GaxPreconditions.CheckNotNullOrEmpty(volumeSnapshot, nameof(volumeSnapshot)),
            }, callSettings);

        /// <summary>
        /// Restore a storage volume snapshot to its containing volume.
        /// </summary>
        /// <param name="volumeSnapshot">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<VolumeSnapshot, OperationMetadata>> RestoreVolumeSnapshotAsync(string volumeSnapshot, st::CancellationToken cancellationToken) =>
            RestoreVolumeSnapshotAsync(volumeSnapshot, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Restore a storage volume snapshot to its containing volume.
        /// </summary>
        /// <param name="volumeSnapshot">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<VolumeSnapshot, OperationMetadata> RestoreVolumeSnapshot(VolumeSnapshotName volumeSnapshot, gaxgrpc::CallSettings callSettings = null) =>
            RestoreVolumeSnapshot(new RestoreVolumeSnapshotRequest
            {
                VolumeSnapshotAsVolumeSnapshotName = gax::GaxPreconditions.CheckNotNull(volumeSnapshot, nameof(volumeSnapshot)),
            }, callSettings);

        /// <summary>
        /// Restore a storage volume snapshot to its containing volume.
        /// </summary>
        /// <param name="volumeSnapshot">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<VolumeSnapshot, OperationMetadata>> RestoreVolumeSnapshotAsync(VolumeSnapshotName volumeSnapshot, gaxgrpc::CallSettings callSettings = null) =>
            RestoreVolumeSnapshotAsync(new RestoreVolumeSnapshotRequest
            {
                VolumeSnapshotAsVolumeSnapshotName = gax::GaxPreconditions.CheckNotNull(volumeSnapshot, nameof(volumeSnapshot)),
            }, callSettings);

        /// <summary>
        /// Restore a storage volume snapshot to its containing volume.
        /// </summary>
        /// <param name="volumeSnapshot">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<VolumeSnapshot, OperationMetadata>> RestoreVolumeSnapshotAsync(VolumeSnapshotName volumeSnapshot, st::CancellationToken cancellationToken) =>
            RestoreVolumeSnapshotAsync(volumeSnapshot, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a storage volume snapshot for a given volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteVolumeSnapshot(DeleteVolumeSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a storage volume snapshot for a given volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteVolumeSnapshotAsync(DeleteVolumeSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a storage volume snapshot for a given volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteVolumeSnapshotAsync(DeleteVolumeSnapshotRequest request, st::CancellationToken cancellationToken) =>
            DeleteVolumeSnapshotAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a storage volume snapshot for a given volume.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the snapshot to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteVolumeSnapshot(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteVolumeSnapshot(new DeleteVolumeSnapshotRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a storage volume snapshot for a given volume.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the snapshot to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteVolumeSnapshotAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteVolumeSnapshotAsync(new DeleteVolumeSnapshotRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a storage volume snapshot for a given volume.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the snapshot to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteVolumeSnapshotAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteVolumeSnapshotAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a storage volume snapshot for a given volume.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the snapshot to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteVolumeSnapshot(VolumeSnapshotName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteVolumeSnapshot(new DeleteVolumeSnapshotRequest
            {
                VolumeSnapshotName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a storage volume snapshot for a given volume.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the snapshot to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteVolumeSnapshotAsync(VolumeSnapshotName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteVolumeSnapshotAsync(new DeleteVolumeSnapshotRequest
            {
                VolumeSnapshotName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a storage volume snapshot for a given volume.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the snapshot to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteVolumeSnapshotAsync(VolumeSnapshotName name, st::CancellationToken cancellationToken) =>
            DeleteVolumeSnapshotAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get details of a single storage volume snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual VolumeSnapshot GetVolumeSnapshot(GetVolumeSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get details of a single storage volume snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VolumeSnapshot> GetVolumeSnapshotAsync(GetVolumeSnapshotRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get details of a single storage volume snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VolumeSnapshot> GetVolumeSnapshotAsync(GetVolumeSnapshotRequest request, st::CancellationToken cancellationToken) =>
            GetVolumeSnapshotAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get details of a single storage volume snapshot.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual VolumeSnapshot GetVolumeSnapshot(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetVolumeSnapshot(new GetVolumeSnapshotRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details of a single storage volume snapshot.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VolumeSnapshot> GetVolumeSnapshotAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetVolumeSnapshotAsync(new GetVolumeSnapshotRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details of a single storage volume snapshot.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VolumeSnapshot> GetVolumeSnapshotAsync(string name, st::CancellationToken cancellationToken) =>
            GetVolumeSnapshotAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get details of a single storage volume snapshot.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual VolumeSnapshot GetVolumeSnapshot(VolumeSnapshotName name, gaxgrpc::CallSettings callSettings = null) =>
            GetVolumeSnapshot(new GetVolumeSnapshotRequest
            {
                VolumeSnapshotName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details of a single storage volume snapshot.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VolumeSnapshot> GetVolumeSnapshotAsync(VolumeSnapshotName name, gaxgrpc::CallSettings callSettings = null) =>
            GetVolumeSnapshotAsync(new GetVolumeSnapshotRequest
            {
                VolumeSnapshotName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details of a single storage volume snapshot.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VolumeSnapshot> GetVolumeSnapshotAsync(VolumeSnapshotName name, st::CancellationToken cancellationToken) =>
            GetVolumeSnapshotAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List storage volume snapshots for given storage volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="VolumeSnapshot"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListVolumeSnapshotsResponse, VolumeSnapshot> ListVolumeSnapshots(ListVolumeSnapshotsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List storage volume snapshots for given storage volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="VolumeSnapshot"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListVolumeSnapshotsResponse, VolumeSnapshot> ListVolumeSnapshotsAsync(ListVolumeSnapshotsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List storage volume snapshots for given storage volume.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListVolumesRequest.
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
        /// <returns>A pageable sequence of <see cref="VolumeSnapshot"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListVolumeSnapshotsResponse, VolumeSnapshot> ListVolumeSnapshots(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListVolumeSnapshots(new ListVolumeSnapshotsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List storage volume snapshots for given storage volume.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListVolumesRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="VolumeSnapshot"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListVolumeSnapshotsResponse, VolumeSnapshot> ListVolumeSnapshotsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListVolumeSnapshotsAsync(new ListVolumeSnapshotsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List storage volume snapshots for given storage volume.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListVolumesRequest.
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
        /// <returns>A pageable sequence of <see cref="VolumeSnapshot"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListVolumeSnapshotsResponse, VolumeSnapshot> ListVolumeSnapshots(VolumeName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListVolumeSnapshots(new ListVolumeSnapshotsRequest
            {
                ParentAsVolumeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List storage volume snapshots for given storage volume.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListVolumesRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="VolumeSnapshot"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListVolumeSnapshotsResponse, VolumeSnapshot> ListVolumeSnapshotsAsync(VolumeName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListVolumeSnapshotsAsync(new ListVolumeSnapshotsRequest
            {
                ParentAsVolumeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Get details of a single storage logical unit number(LUN).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Lun GetLun(GetLunRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get details of a single storage logical unit number(LUN).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Lun> GetLunAsync(GetLunRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get details of a single storage logical unit number(LUN).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Lun> GetLunAsync(GetLunRequest request, st::CancellationToken cancellationToken) =>
            GetLunAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get details of a single storage logical unit number(LUN).
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Lun GetLun(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetLun(new GetLunRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details of a single storage logical unit number(LUN).
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Lun> GetLunAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetLunAsync(new GetLunRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details of a single storage logical unit number(LUN).
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Lun> GetLunAsync(string name, st::CancellationToken cancellationToken) =>
            GetLunAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get details of a single storage logical unit number(LUN).
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Lun GetLun(LunName name, gaxgrpc::CallSettings callSettings = null) =>
            GetLun(new GetLunRequest
            {
                LunName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details of a single storage logical unit number(LUN).
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Lun> GetLunAsync(LunName name, gaxgrpc::CallSettings callSettings = null) =>
            GetLunAsync(new GetLunRequest
            {
                LunName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get details of a single storage logical unit number(LUN).
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Lun> GetLunAsync(LunName name, st::CancellationToken cancellationToken) =>
            GetLunAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List storage volume luns for given storage volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Lun"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLunsResponse, Lun> ListLuns(ListLunsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List storage volume luns for given storage volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Lun"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLunsResponse, Lun> ListLunsAsync(ListLunsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List storage volume luns for given storage volume.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListLunsRequest.
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
        /// <returns>A pageable sequence of <see cref="Lun"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLunsResponse, Lun> ListLuns(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListLuns(new ListLunsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List storage volume luns for given storage volume.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListLunsRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Lun"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLunsResponse, Lun> ListLunsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListLunsAsync(new ListLunsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List storage volume luns for given storage volume.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListLunsRequest.
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
        /// <returns>A pageable sequence of <see cref="Lun"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLunsResponse, Lun> ListLuns(VolumeName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListLuns(new ListLunsRequest
            {
                ParentAsVolumeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// List storage volume luns for given storage volume.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListLunsRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Lun"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLunsResponse, Lun> ListLunsAsync(VolumeName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListLunsAsync(new ListLunsRequest
            {
                ParentAsVolumeName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);
    }

    /// <summary>BareMetalSolution client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Performs management operations on Bare Metal Solution servers.
    /// 
    /// The `baremetalsolution.googleapis.com` service provides management
    /// capabilities for Bare Metal Solution servers. To access the API methods, you
    /// must assign Bare Metal Solution IAM roles containing the desired permissions
    /// to your staff in your Google Cloud project. You must also enable the Bare
    /// Metal Solution API. Once enabled, the methods act
    /// upon specific servers in your Bare Metal Solution environment.
    /// </remarks>
    public sealed partial class BareMetalSolutionClientImpl : BareMetalSolutionClient
    {
        private readonly gaxgrpc::ApiCall<ListInstancesRequest, ListInstancesResponse> _callListInstances;

        private readonly gaxgrpc::ApiCall<GetInstanceRequest, Instance> _callGetInstance;

        private readonly gaxgrpc::ApiCall<ResetInstanceRequest, lro::Operation> _callResetInstance;

        private readonly gaxgrpc::ApiCall<ListVolumesRequest, ListVolumesResponse> _callListVolumes;

        private readonly gaxgrpc::ApiCall<GetVolumeRequest, Volume> _callGetVolume;

        private readonly gaxgrpc::ApiCall<UpdateVolumeRequest, lro::Operation> _callUpdateVolume;

        private readonly gaxgrpc::ApiCall<ListNetworksRequest, ListNetworksResponse> _callListNetworks;

        private readonly gaxgrpc::ApiCall<GetNetworkRequest, Network> _callGetNetwork;

        private readonly gaxgrpc::ApiCall<ListSnapshotSchedulePoliciesRequest, ListSnapshotSchedulePoliciesResponse> _callListSnapshotSchedulePolicies;

        private readonly gaxgrpc::ApiCall<GetSnapshotSchedulePolicyRequest, SnapshotSchedulePolicy> _callGetSnapshotSchedulePolicy;

        private readonly gaxgrpc::ApiCall<CreateSnapshotSchedulePolicyRequest, SnapshotSchedulePolicy> _callCreateSnapshotSchedulePolicy;

        private readonly gaxgrpc::ApiCall<UpdateSnapshotSchedulePolicyRequest, SnapshotSchedulePolicy> _callUpdateSnapshotSchedulePolicy;

        private readonly gaxgrpc::ApiCall<DeleteSnapshotSchedulePolicyRequest, wkt::Empty> _callDeleteSnapshotSchedulePolicy;

        private readonly gaxgrpc::ApiCall<CreateVolumeSnapshotRequest, VolumeSnapshot> _callCreateVolumeSnapshot;

        private readonly gaxgrpc::ApiCall<RestoreVolumeSnapshotRequest, lro::Operation> _callRestoreVolumeSnapshot;

        private readonly gaxgrpc::ApiCall<DeleteVolumeSnapshotRequest, wkt::Empty> _callDeleteVolumeSnapshot;

        private readonly gaxgrpc::ApiCall<GetVolumeSnapshotRequest, VolumeSnapshot> _callGetVolumeSnapshot;

        private readonly gaxgrpc::ApiCall<ListVolumeSnapshotsRequest, ListVolumeSnapshotsResponse> _callListVolumeSnapshots;

        private readonly gaxgrpc::ApiCall<GetLunRequest, Lun> _callGetLun;

        private readonly gaxgrpc::ApiCall<ListLunsRequest, ListLunsResponse> _callListLuns;

        /// <summary>
        /// Constructs a client wrapper for the BareMetalSolution service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="BareMetalSolutionSettings"/> used within this client.</param>
        public BareMetalSolutionClientImpl(BareMetalSolution.BareMetalSolutionClient grpcClient, BareMetalSolutionSettings settings)
        {
            GrpcClient = grpcClient;
            BareMetalSolutionSettings effectiveSettings = settings ?? BareMetalSolutionSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            ResetInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ResetInstanceOperationsSettings);
            UpdateVolumeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateVolumeOperationsSettings);
            RestoreVolumeSnapshotOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RestoreVolumeSnapshotOperationsSettings);
            _callListInstances = clientHelper.BuildApiCall<ListInstancesRequest, ListInstancesResponse>(grpcClient.ListInstancesAsync, grpcClient.ListInstances, effectiveSettings.ListInstancesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListInstances);
            Modify_ListInstancesApiCall(ref _callListInstances);
            _callGetInstance = clientHelper.BuildApiCall<GetInstanceRequest, Instance>(grpcClient.GetInstanceAsync, grpcClient.GetInstance, effectiveSettings.GetInstanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetInstance);
            Modify_GetInstanceApiCall(ref _callGetInstance);
            _callResetInstance = clientHelper.BuildApiCall<ResetInstanceRequest, lro::Operation>(grpcClient.ResetInstanceAsync, grpcClient.ResetInstance, effectiveSettings.ResetInstanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callResetInstance);
            Modify_ResetInstanceApiCall(ref _callResetInstance);
            _callListVolumes = clientHelper.BuildApiCall<ListVolumesRequest, ListVolumesResponse>(grpcClient.ListVolumesAsync, grpcClient.ListVolumes, effectiveSettings.ListVolumesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListVolumes);
            Modify_ListVolumesApiCall(ref _callListVolumes);
            _callGetVolume = clientHelper.BuildApiCall<GetVolumeRequest, Volume>(grpcClient.GetVolumeAsync, grpcClient.GetVolume, effectiveSettings.GetVolumeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetVolume);
            Modify_GetVolumeApiCall(ref _callGetVolume);
            _callUpdateVolume = clientHelper.BuildApiCall<UpdateVolumeRequest, lro::Operation>(grpcClient.UpdateVolumeAsync, grpcClient.UpdateVolume, effectiveSettings.UpdateVolumeSettings).WithGoogleRequestParam("volume.name", request => request.Volume?.Name);
            Modify_ApiCall(ref _callUpdateVolume);
            Modify_UpdateVolumeApiCall(ref _callUpdateVolume);
            _callListNetworks = clientHelper.BuildApiCall<ListNetworksRequest, ListNetworksResponse>(grpcClient.ListNetworksAsync, grpcClient.ListNetworks, effectiveSettings.ListNetworksSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListNetworks);
            Modify_ListNetworksApiCall(ref _callListNetworks);
            _callGetNetwork = clientHelper.BuildApiCall<GetNetworkRequest, Network>(grpcClient.GetNetworkAsync, grpcClient.GetNetwork, effectiveSettings.GetNetworkSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetNetwork);
            Modify_GetNetworkApiCall(ref _callGetNetwork);
            _callListSnapshotSchedulePolicies = clientHelper.BuildApiCall<ListSnapshotSchedulePoliciesRequest, ListSnapshotSchedulePoliciesResponse>(grpcClient.ListSnapshotSchedulePoliciesAsync, grpcClient.ListSnapshotSchedulePolicies, effectiveSettings.ListSnapshotSchedulePoliciesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSnapshotSchedulePolicies);
            Modify_ListSnapshotSchedulePoliciesApiCall(ref _callListSnapshotSchedulePolicies);
            _callGetSnapshotSchedulePolicy = clientHelper.BuildApiCall<GetSnapshotSchedulePolicyRequest, SnapshotSchedulePolicy>(grpcClient.GetSnapshotSchedulePolicyAsync, grpcClient.GetSnapshotSchedulePolicy, effectiveSettings.GetSnapshotSchedulePolicySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSnapshotSchedulePolicy);
            Modify_GetSnapshotSchedulePolicyApiCall(ref _callGetSnapshotSchedulePolicy);
            _callCreateSnapshotSchedulePolicy = clientHelper.BuildApiCall<CreateSnapshotSchedulePolicyRequest, SnapshotSchedulePolicy>(grpcClient.CreateSnapshotSchedulePolicyAsync, grpcClient.CreateSnapshotSchedulePolicy, effectiveSettings.CreateSnapshotSchedulePolicySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateSnapshotSchedulePolicy);
            Modify_CreateSnapshotSchedulePolicyApiCall(ref _callCreateSnapshotSchedulePolicy);
            _callUpdateSnapshotSchedulePolicy = clientHelper.BuildApiCall<UpdateSnapshotSchedulePolicyRequest, SnapshotSchedulePolicy>(grpcClient.UpdateSnapshotSchedulePolicyAsync, grpcClient.UpdateSnapshotSchedulePolicy, effectiveSettings.UpdateSnapshotSchedulePolicySettings).WithGoogleRequestParam("snapshot_schedule_policy.name", request => request.SnapshotSchedulePolicy?.Name);
            Modify_ApiCall(ref _callUpdateSnapshotSchedulePolicy);
            Modify_UpdateSnapshotSchedulePolicyApiCall(ref _callUpdateSnapshotSchedulePolicy);
            _callDeleteSnapshotSchedulePolicy = clientHelper.BuildApiCall<DeleteSnapshotSchedulePolicyRequest, wkt::Empty>(grpcClient.DeleteSnapshotSchedulePolicyAsync, grpcClient.DeleteSnapshotSchedulePolicy, effectiveSettings.DeleteSnapshotSchedulePolicySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteSnapshotSchedulePolicy);
            Modify_DeleteSnapshotSchedulePolicyApiCall(ref _callDeleteSnapshotSchedulePolicy);
            _callCreateVolumeSnapshot = clientHelper.BuildApiCall<CreateVolumeSnapshotRequest, VolumeSnapshot>(grpcClient.CreateVolumeSnapshotAsync, grpcClient.CreateVolumeSnapshot, effectiveSettings.CreateVolumeSnapshotSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateVolumeSnapshot);
            Modify_CreateVolumeSnapshotApiCall(ref _callCreateVolumeSnapshot);
            _callRestoreVolumeSnapshot = clientHelper.BuildApiCall<RestoreVolumeSnapshotRequest, lro::Operation>(grpcClient.RestoreVolumeSnapshotAsync, grpcClient.RestoreVolumeSnapshot, effectiveSettings.RestoreVolumeSnapshotSettings).WithGoogleRequestParam("volume_snapshot", request => request.VolumeSnapshot);
            Modify_ApiCall(ref _callRestoreVolumeSnapshot);
            Modify_RestoreVolumeSnapshotApiCall(ref _callRestoreVolumeSnapshot);
            _callDeleteVolumeSnapshot = clientHelper.BuildApiCall<DeleteVolumeSnapshotRequest, wkt::Empty>(grpcClient.DeleteVolumeSnapshotAsync, grpcClient.DeleteVolumeSnapshot, effectiveSettings.DeleteVolumeSnapshotSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteVolumeSnapshot);
            Modify_DeleteVolumeSnapshotApiCall(ref _callDeleteVolumeSnapshot);
            _callGetVolumeSnapshot = clientHelper.BuildApiCall<GetVolumeSnapshotRequest, VolumeSnapshot>(grpcClient.GetVolumeSnapshotAsync, grpcClient.GetVolumeSnapshot, effectiveSettings.GetVolumeSnapshotSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetVolumeSnapshot);
            Modify_GetVolumeSnapshotApiCall(ref _callGetVolumeSnapshot);
            _callListVolumeSnapshots = clientHelper.BuildApiCall<ListVolumeSnapshotsRequest, ListVolumeSnapshotsResponse>(grpcClient.ListVolumeSnapshotsAsync, grpcClient.ListVolumeSnapshots, effectiveSettings.ListVolumeSnapshotsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListVolumeSnapshots);
            Modify_ListVolumeSnapshotsApiCall(ref _callListVolumeSnapshots);
            _callGetLun = clientHelper.BuildApiCall<GetLunRequest, Lun>(grpcClient.GetLunAsync, grpcClient.GetLun, effectiveSettings.GetLunSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetLun);
            Modify_GetLunApiCall(ref _callGetLun);
            _callListLuns = clientHelper.BuildApiCall<ListLunsRequest, ListLunsResponse>(grpcClient.ListLunsAsync, grpcClient.ListLuns, effectiveSettings.ListLunsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListLuns);
            Modify_ListLunsApiCall(ref _callListLuns);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListInstancesApiCall(ref gaxgrpc::ApiCall<ListInstancesRequest, ListInstancesResponse> call);

        partial void Modify_GetInstanceApiCall(ref gaxgrpc::ApiCall<GetInstanceRequest, Instance> call);

        partial void Modify_ResetInstanceApiCall(ref gaxgrpc::ApiCall<ResetInstanceRequest, lro::Operation> call);

        partial void Modify_ListVolumesApiCall(ref gaxgrpc::ApiCall<ListVolumesRequest, ListVolumesResponse> call);

        partial void Modify_GetVolumeApiCall(ref gaxgrpc::ApiCall<GetVolumeRequest, Volume> call);

        partial void Modify_UpdateVolumeApiCall(ref gaxgrpc::ApiCall<UpdateVolumeRequest, lro::Operation> call);

        partial void Modify_ListNetworksApiCall(ref gaxgrpc::ApiCall<ListNetworksRequest, ListNetworksResponse> call);

        partial void Modify_GetNetworkApiCall(ref gaxgrpc::ApiCall<GetNetworkRequest, Network> call);

        partial void Modify_ListSnapshotSchedulePoliciesApiCall(ref gaxgrpc::ApiCall<ListSnapshotSchedulePoliciesRequest, ListSnapshotSchedulePoliciesResponse> call);

        partial void Modify_GetSnapshotSchedulePolicyApiCall(ref gaxgrpc::ApiCall<GetSnapshotSchedulePolicyRequest, SnapshotSchedulePolicy> call);

        partial void Modify_CreateSnapshotSchedulePolicyApiCall(ref gaxgrpc::ApiCall<CreateSnapshotSchedulePolicyRequest, SnapshotSchedulePolicy> call);

        partial void Modify_UpdateSnapshotSchedulePolicyApiCall(ref gaxgrpc::ApiCall<UpdateSnapshotSchedulePolicyRequest, SnapshotSchedulePolicy> call);

        partial void Modify_DeleteSnapshotSchedulePolicyApiCall(ref gaxgrpc::ApiCall<DeleteSnapshotSchedulePolicyRequest, wkt::Empty> call);

        partial void Modify_CreateVolumeSnapshotApiCall(ref gaxgrpc::ApiCall<CreateVolumeSnapshotRequest, VolumeSnapshot> call);

        partial void Modify_RestoreVolumeSnapshotApiCall(ref gaxgrpc::ApiCall<RestoreVolumeSnapshotRequest, lro::Operation> call);

        partial void Modify_DeleteVolumeSnapshotApiCall(ref gaxgrpc::ApiCall<DeleteVolumeSnapshotRequest, wkt::Empty> call);

        partial void Modify_GetVolumeSnapshotApiCall(ref gaxgrpc::ApiCall<GetVolumeSnapshotRequest, VolumeSnapshot> call);

        partial void Modify_ListVolumeSnapshotsApiCall(ref gaxgrpc::ApiCall<ListVolumeSnapshotsRequest, ListVolumeSnapshotsResponse> call);

        partial void Modify_GetLunApiCall(ref gaxgrpc::ApiCall<GetLunRequest, Lun> call);

        partial void Modify_ListLunsApiCall(ref gaxgrpc::ApiCall<ListLunsRequest, ListLunsResponse> call);

        partial void OnConstruction(BareMetalSolution.BareMetalSolutionClient grpcClient, BareMetalSolutionSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC BareMetalSolution client</summary>
        public override BareMetalSolution.BareMetalSolutionClient GrpcClient { get; }

        partial void Modify_ListInstancesRequest(ref ListInstancesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetInstanceRequest(ref GetInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ResetInstanceRequest(ref ResetInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListVolumesRequest(ref ListVolumesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetVolumeRequest(ref GetVolumeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateVolumeRequest(ref UpdateVolumeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListNetworksRequest(ref ListNetworksRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetNetworkRequest(ref GetNetworkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSnapshotSchedulePoliciesRequest(ref ListSnapshotSchedulePoliciesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSnapshotSchedulePolicyRequest(ref GetSnapshotSchedulePolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateSnapshotSchedulePolicyRequest(ref CreateSnapshotSchedulePolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateSnapshotSchedulePolicyRequest(ref UpdateSnapshotSchedulePolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteSnapshotSchedulePolicyRequest(ref DeleteSnapshotSchedulePolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateVolumeSnapshotRequest(ref CreateVolumeSnapshotRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RestoreVolumeSnapshotRequest(ref RestoreVolumeSnapshotRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteVolumeSnapshotRequest(ref DeleteVolumeSnapshotRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetVolumeSnapshotRequest(ref GetVolumeSnapshotRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListVolumeSnapshotsRequest(ref ListVolumeSnapshotsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetLunRequest(ref GetLunRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListLunsRequest(ref ListLunsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// List servers in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Instance"/> resources.</returns>
        public override gax::PagedEnumerable<ListInstancesResponse, Instance> ListInstances(ListInstancesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInstancesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListInstancesRequest, ListInstancesResponse, Instance>(_callListInstances, request, callSettings);
        }

        /// <summary>
        /// List servers in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Instance"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListInstancesResponse, Instance> ListInstancesAsync(ListInstancesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInstancesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListInstancesRequest, ListInstancesResponse, Instance>(_callListInstances, request, callSettings);
        }

        /// <summary>
        /// Get details about a single server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Instance GetInstance(GetInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInstanceRequest(ref request, ref callSettings);
            return _callGetInstance.Sync(request, callSettings);
        }

        /// <summary>
        /// Get details about a single server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Instance> GetInstanceAsync(GetInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInstanceRequest(ref request, ref callSettings);
            return _callGetInstance.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>ResetInstance</c>.</summary>
        public override lro::OperationsClient ResetInstanceOperationsClient { get; }

        /// <summary>
        /// Perform an ungraceful, hard reset on a server. Equivalent to shutting the
        /// power off and then turning it back on.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ResetInstanceResponse, OperationMetadata> ResetInstance(ResetInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResetInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<ResetInstanceResponse, OperationMetadata>(_callResetInstance.Sync(request, callSettings), ResetInstanceOperationsClient);
        }

        /// <summary>
        /// Perform an ungraceful, hard reset on a server. Equivalent to shutting the
        /// power off and then turning it back on.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ResetInstanceResponse, OperationMetadata>> ResetInstanceAsync(ResetInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResetInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<ResetInstanceResponse, OperationMetadata>(await _callResetInstance.Async(request, callSettings).ConfigureAwait(false), ResetInstanceOperationsClient);
        }

        /// <summary>
        /// List storage volumes in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Volume"/> resources.</returns>
        public override gax::PagedEnumerable<ListVolumesResponse, Volume> ListVolumes(ListVolumesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListVolumesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListVolumesRequest, ListVolumesResponse, Volume>(_callListVolumes, request, callSettings);
        }

        /// <summary>
        /// List storage volumes in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Volume"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListVolumesResponse, Volume> ListVolumesAsync(ListVolumesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListVolumesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListVolumesRequest, ListVolumesResponse, Volume>(_callListVolumes, request, callSettings);
        }

        /// <summary>
        /// Get details of a single storage volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Volume GetVolume(GetVolumeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetVolumeRequest(ref request, ref callSettings);
            return _callGetVolume.Sync(request, callSettings);
        }

        /// <summary>
        /// Get details of a single storage volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Volume> GetVolumeAsync(GetVolumeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetVolumeRequest(ref request, ref callSettings);
            return _callGetVolume.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateVolume</c>.</summary>
        public override lro::OperationsClient UpdateVolumeOperationsClient { get; }

        /// <summary>
        /// Update details of a single storage volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Volume, OperationMetadata> UpdateVolume(UpdateVolumeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateVolumeRequest(ref request, ref callSettings);
            return new lro::Operation<Volume, OperationMetadata>(_callUpdateVolume.Sync(request, callSettings), UpdateVolumeOperationsClient);
        }

        /// <summary>
        /// Update details of a single storage volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Volume, OperationMetadata>> UpdateVolumeAsync(UpdateVolumeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateVolumeRequest(ref request, ref callSettings);
            return new lro::Operation<Volume, OperationMetadata>(await _callUpdateVolume.Async(request, callSettings).ConfigureAwait(false), UpdateVolumeOperationsClient);
        }

        /// <summary>
        /// List network in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Network"/> resources.</returns>
        public override gax::PagedEnumerable<ListNetworksResponse, Network> ListNetworks(ListNetworksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNetworksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListNetworksRequest, ListNetworksResponse, Network>(_callListNetworks, request, callSettings);
        }

        /// <summary>
        /// List network in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Network"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListNetworksResponse, Network> ListNetworksAsync(ListNetworksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNetworksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListNetworksRequest, ListNetworksResponse, Network>(_callListNetworks, request, callSettings);
        }

        /// <summary>
        /// Get details of a single network.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Network GetNetwork(GetNetworkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNetworkRequest(ref request, ref callSettings);
            return _callGetNetwork.Sync(request, callSettings);
        }

        /// <summary>
        /// Get details of a single network.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Network> GetNetworkAsync(GetNetworkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNetworkRequest(ref request, ref callSettings);
            return _callGetNetwork.Async(request, callSettings);
        }

        /// <summary>
        /// List snapshot schedule policies in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SnapshotSchedulePolicy"/> resources.</returns>
        public override gax::PagedEnumerable<ListSnapshotSchedulePoliciesResponse, SnapshotSchedulePolicy> ListSnapshotSchedulePolicies(ListSnapshotSchedulePoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSnapshotSchedulePoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSnapshotSchedulePoliciesRequest, ListSnapshotSchedulePoliciesResponse, SnapshotSchedulePolicy>(_callListSnapshotSchedulePolicies, request, callSettings);
        }

        /// <summary>
        /// List snapshot schedule policies in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SnapshotSchedulePolicy"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSnapshotSchedulePoliciesResponse, SnapshotSchedulePolicy> ListSnapshotSchedulePoliciesAsync(ListSnapshotSchedulePoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSnapshotSchedulePoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSnapshotSchedulePoliciesRequest, ListSnapshotSchedulePoliciesResponse, SnapshotSchedulePolicy>(_callListSnapshotSchedulePolicies, request, callSettings);
        }

        /// <summary>
        /// Get details of a single snapshot schedule policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SnapshotSchedulePolicy GetSnapshotSchedulePolicy(GetSnapshotSchedulePolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSnapshotSchedulePolicyRequest(ref request, ref callSettings);
            return _callGetSnapshotSchedulePolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Get details of a single snapshot schedule policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SnapshotSchedulePolicy> GetSnapshotSchedulePolicyAsync(GetSnapshotSchedulePolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSnapshotSchedulePolicyRequest(ref request, ref callSettings);
            return _callGetSnapshotSchedulePolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Create a snapshot schedule policy in the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SnapshotSchedulePolicy CreateSnapshotSchedulePolicy(CreateSnapshotSchedulePolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSnapshotSchedulePolicyRequest(ref request, ref callSettings);
            return _callCreateSnapshotSchedulePolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Create a snapshot schedule policy in the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SnapshotSchedulePolicy> CreateSnapshotSchedulePolicyAsync(CreateSnapshotSchedulePolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSnapshotSchedulePolicyRequest(ref request, ref callSettings);
            return _callCreateSnapshotSchedulePolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Update a snapshot schedule policy in the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SnapshotSchedulePolicy UpdateSnapshotSchedulePolicy(UpdateSnapshotSchedulePolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSnapshotSchedulePolicyRequest(ref request, ref callSettings);
            return _callUpdateSnapshotSchedulePolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Update a snapshot schedule policy in the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SnapshotSchedulePolicy> UpdateSnapshotSchedulePolicyAsync(UpdateSnapshotSchedulePolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSnapshotSchedulePolicyRequest(ref request, ref callSettings);
            return _callUpdateSnapshotSchedulePolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Delete a named snapshot schedule policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteSnapshotSchedulePolicy(DeleteSnapshotSchedulePolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSnapshotSchedulePolicyRequest(ref request, ref callSettings);
            _callDeleteSnapshotSchedulePolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Delete a named snapshot schedule policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteSnapshotSchedulePolicyAsync(DeleteSnapshotSchedulePolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSnapshotSchedulePolicyRequest(ref request, ref callSettings);
            return _callDeleteSnapshotSchedulePolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Create a storage volume snapshot in a containing volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override VolumeSnapshot CreateVolumeSnapshot(CreateVolumeSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateVolumeSnapshotRequest(ref request, ref callSettings);
            return _callCreateVolumeSnapshot.Sync(request, callSettings);
        }

        /// <summary>
        /// Create a storage volume snapshot in a containing volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<VolumeSnapshot> CreateVolumeSnapshotAsync(CreateVolumeSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateVolumeSnapshotRequest(ref request, ref callSettings);
            return _callCreateVolumeSnapshot.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>RestoreVolumeSnapshot</c>.</summary>
        public override lro::OperationsClient RestoreVolumeSnapshotOperationsClient { get; }

        /// <summary>
        /// Restore a storage volume snapshot to its containing volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<VolumeSnapshot, OperationMetadata> RestoreVolumeSnapshot(RestoreVolumeSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RestoreVolumeSnapshotRequest(ref request, ref callSettings);
            return new lro::Operation<VolumeSnapshot, OperationMetadata>(_callRestoreVolumeSnapshot.Sync(request, callSettings), RestoreVolumeSnapshotOperationsClient);
        }

        /// <summary>
        /// Restore a storage volume snapshot to its containing volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<VolumeSnapshot, OperationMetadata>> RestoreVolumeSnapshotAsync(RestoreVolumeSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RestoreVolumeSnapshotRequest(ref request, ref callSettings);
            return new lro::Operation<VolumeSnapshot, OperationMetadata>(await _callRestoreVolumeSnapshot.Async(request, callSettings).ConfigureAwait(false), RestoreVolumeSnapshotOperationsClient);
        }

        /// <summary>
        /// Deletes a storage volume snapshot for a given volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteVolumeSnapshot(DeleteVolumeSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteVolumeSnapshotRequest(ref request, ref callSettings);
            _callDeleteVolumeSnapshot.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a storage volume snapshot for a given volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteVolumeSnapshotAsync(DeleteVolumeSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteVolumeSnapshotRequest(ref request, ref callSettings);
            return _callDeleteVolumeSnapshot.Async(request, callSettings);
        }

        /// <summary>
        /// Get details of a single storage volume snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override VolumeSnapshot GetVolumeSnapshot(GetVolumeSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetVolumeSnapshotRequest(ref request, ref callSettings);
            return _callGetVolumeSnapshot.Sync(request, callSettings);
        }

        /// <summary>
        /// Get details of a single storage volume snapshot.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<VolumeSnapshot> GetVolumeSnapshotAsync(GetVolumeSnapshotRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetVolumeSnapshotRequest(ref request, ref callSettings);
            return _callGetVolumeSnapshot.Async(request, callSettings);
        }

        /// <summary>
        /// List storage volume snapshots for given storage volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="VolumeSnapshot"/> resources.</returns>
        public override gax::PagedEnumerable<ListVolumeSnapshotsResponse, VolumeSnapshot> ListVolumeSnapshots(ListVolumeSnapshotsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListVolumeSnapshotsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListVolumeSnapshotsRequest, ListVolumeSnapshotsResponse, VolumeSnapshot>(_callListVolumeSnapshots, request, callSettings);
        }

        /// <summary>
        /// List storage volume snapshots for given storage volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="VolumeSnapshot"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListVolumeSnapshotsResponse, VolumeSnapshot> ListVolumeSnapshotsAsync(ListVolumeSnapshotsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListVolumeSnapshotsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListVolumeSnapshotsRequest, ListVolumeSnapshotsResponse, VolumeSnapshot>(_callListVolumeSnapshots, request, callSettings);
        }

        /// <summary>
        /// Get details of a single storage logical unit number(LUN).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Lun GetLun(GetLunRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetLunRequest(ref request, ref callSettings);
            return _callGetLun.Sync(request, callSettings);
        }

        /// <summary>
        /// Get details of a single storage logical unit number(LUN).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Lun> GetLunAsync(GetLunRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetLunRequest(ref request, ref callSettings);
            return _callGetLun.Async(request, callSettings);
        }

        /// <summary>
        /// List storage volume luns for given storage volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Lun"/> resources.</returns>
        public override gax::PagedEnumerable<ListLunsResponse, Lun> ListLuns(ListLunsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListLunsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListLunsRequest, ListLunsResponse, Lun>(_callListLuns, request, callSettings);
        }

        /// <summary>
        /// List storage volume luns for given storage volume.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Lun"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListLunsResponse, Lun> ListLunsAsync(ListLunsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListLunsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListLunsRequest, ListLunsResponse, Lun>(_callListLuns, request, callSettings);
        }
    }

    public partial class ListInstancesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListVolumesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListNetworksRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSnapshotSchedulePoliciesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListVolumeSnapshotsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListLunsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListInstancesResponse : gaxgrpc::IPageResponse<Instance>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Instance> GetEnumerator() => Instances.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListVolumesResponse : gaxgrpc::IPageResponse<Volume>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Volume> GetEnumerator() => Volumes.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListNetworksResponse : gaxgrpc::IPageResponse<Network>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Network> GetEnumerator() => Networks.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListSnapshotSchedulePoliciesResponse : gaxgrpc::IPageResponse<SnapshotSchedulePolicy>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<SnapshotSchedulePolicy> GetEnumerator() => SnapshotSchedulePolicies.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListVolumeSnapshotsResponse : gaxgrpc::IPageResponse<VolumeSnapshot>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<VolumeSnapshot> GetEnumerator() => VolumeSnapshots.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListLunsResponse : gaxgrpc::IPageResponse<Lun>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Lun> GetEnumerator() => Luns.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class BareMetalSolution
    {
        public partial class BareMetalSolutionClient
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
