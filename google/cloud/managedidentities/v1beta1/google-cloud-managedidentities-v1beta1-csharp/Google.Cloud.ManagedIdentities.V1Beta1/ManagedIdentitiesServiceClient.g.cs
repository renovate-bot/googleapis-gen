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
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.ManagedIdentities.V1Beta1
{
    /// <summary>Settings for <see cref="ManagedIdentitiesServiceClient"/> instances.</summary>
    public sealed partial class ManagedIdentitiesServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ManagedIdentitiesServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ManagedIdentitiesServiceSettings"/>.</returns>
        public static ManagedIdentitiesServiceSettings GetDefault() => new ManagedIdentitiesServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="ManagedIdentitiesServiceSettings"/> object with default settings.
        /// </summary>
        public ManagedIdentitiesServiceSettings()
        {
        }

        private ManagedIdentitiesServiceSettings(ManagedIdentitiesServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateMicrosoftAdDomainSettings = existing.CreateMicrosoftAdDomainSettings;
            CreateMicrosoftAdDomainOperationsSettings = existing.CreateMicrosoftAdDomainOperationsSettings.Clone();
            ResetAdminPasswordSettings = existing.ResetAdminPasswordSettings;
            ListDomainsSettings = existing.ListDomainsSettings;
            GetDomainSettings = existing.GetDomainSettings;
            UpdateDomainSettings = existing.UpdateDomainSettings;
            UpdateDomainOperationsSettings = existing.UpdateDomainOperationsSettings.Clone();
            DeleteDomainSettings = existing.DeleteDomainSettings;
            DeleteDomainOperationsSettings = existing.DeleteDomainOperationsSettings.Clone();
            AttachTrustSettings = existing.AttachTrustSettings;
            AttachTrustOperationsSettings = existing.AttachTrustOperationsSettings.Clone();
            ReconfigureTrustSettings = existing.ReconfigureTrustSettings;
            ReconfigureTrustOperationsSettings = existing.ReconfigureTrustOperationsSettings.Clone();
            DetachTrustSettings = existing.DetachTrustSettings;
            DetachTrustOperationsSettings = existing.DetachTrustOperationsSettings.Clone();
            ValidateTrustSettings = existing.ValidateTrustSettings;
            ValidateTrustOperationsSettings = existing.ValidateTrustOperationsSettings.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(ManagedIdentitiesServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ManagedIdentitiesServiceClient.CreateMicrosoftAdDomain</c> and
        /// <c>ManagedIdentitiesServiceClient.CreateMicrosoftAdDomainAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateMicrosoftAdDomainSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>ManagedIdentitiesServiceClient.CreateMicrosoftAdDomain</c>
        /// and <c>ManagedIdentitiesServiceClient.CreateMicrosoftAdDomainAsync</c>.
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
        public lro::OperationsSettings CreateMicrosoftAdDomainOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ManagedIdentitiesServiceClient.ResetAdminPassword</c> and
        /// <c>ManagedIdentitiesServiceClient.ResetAdminPasswordAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ResetAdminPasswordSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ManagedIdentitiesServiceClient.ListDomains</c> and <c>ManagedIdentitiesServiceClient.ListDomainsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDomainsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ManagedIdentitiesServiceClient.GetDomain</c> and <c>ManagedIdentitiesServiceClient.GetDomainAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDomainSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ManagedIdentitiesServiceClient.UpdateDomain</c> and <c>ManagedIdentitiesServiceClient.UpdateDomainAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateDomainSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>ManagedIdentitiesServiceClient.UpdateDomain</c> and
        /// <c>ManagedIdentitiesServiceClient.UpdateDomainAsync</c>.
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
        public lro::OperationsSettings UpdateDomainOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ManagedIdentitiesServiceClient.DeleteDomain</c> and <c>ManagedIdentitiesServiceClient.DeleteDomainAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteDomainSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>ManagedIdentitiesServiceClient.DeleteDomain</c> and
        /// <c>ManagedIdentitiesServiceClient.DeleteDomainAsync</c>.
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
        public lro::OperationsSettings DeleteDomainOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ManagedIdentitiesServiceClient.AttachTrust</c> and <c>ManagedIdentitiesServiceClient.AttachTrustAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AttachTrustSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>ManagedIdentitiesServiceClient.AttachTrust</c> and
        /// <c>ManagedIdentitiesServiceClient.AttachTrustAsync</c>.
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
        public lro::OperationsSettings AttachTrustOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ManagedIdentitiesServiceClient.ReconfigureTrust</c> and
        /// <c>ManagedIdentitiesServiceClient.ReconfigureTrustAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ReconfigureTrustSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>ManagedIdentitiesServiceClient.ReconfigureTrust</c> and
        /// <c>ManagedIdentitiesServiceClient.ReconfigureTrustAsync</c>.
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
        public lro::OperationsSettings ReconfigureTrustOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ManagedIdentitiesServiceClient.DetachTrust</c> and <c>ManagedIdentitiesServiceClient.DetachTrustAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DetachTrustSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>ManagedIdentitiesServiceClient.DetachTrust</c> and
        /// <c>ManagedIdentitiesServiceClient.DetachTrustAsync</c>.
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
        public lro::OperationsSettings DetachTrustOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ManagedIdentitiesServiceClient.ValidateTrust</c> and <c>ManagedIdentitiesServiceClient.ValidateTrustAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ValidateTrustSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>ManagedIdentitiesServiceClient.ValidateTrust</c> and
        /// <c>ManagedIdentitiesServiceClient.ValidateTrustAsync</c>.
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
        public lro::OperationsSettings ValidateTrustOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ManagedIdentitiesServiceSettings"/> object.</returns>
        public ManagedIdentitiesServiceSettings Clone() => new ManagedIdentitiesServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ManagedIdentitiesServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class ManagedIdentitiesServiceClientBuilder : gaxgrpc::ClientBuilderBase<ManagedIdentitiesServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ManagedIdentitiesServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ManagedIdentitiesServiceClientBuilder()
        {
            UseJwtAccessWithScopes = ManagedIdentitiesServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref ManagedIdentitiesServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ManagedIdentitiesServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ManagedIdentitiesServiceClient Build()
        {
            ManagedIdentitiesServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ManagedIdentitiesServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ManagedIdentitiesServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ManagedIdentitiesServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ManagedIdentitiesServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<ManagedIdentitiesServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ManagedIdentitiesServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => ManagedIdentitiesServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => ManagedIdentitiesServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ManagedIdentitiesServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>ManagedIdentitiesService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// </remarks>
    public abstract partial class ManagedIdentitiesServiceClient
    {
        /// <summary>
        /// The default endpoint for the ManagedIdentitiesService service, which is a host of
        /// "managedidentities.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "managedidentities.googleapis.com:443";

        /// <summary>The default ManagedIdentitiesService scopes.</summary>
        /// <remarks>
        /// The default ManagedIdentitiesService scopes are:
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
        /// Asynchronously creates a <see cref="ManagedIdentitiesServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="ManagedIdentitiesServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ManagedIdentitiesServiceClient"/>.</returns>
        public static stt::Task<ManagedIdentitiesServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ManagedIdentitiesServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ManagedIdentitiesServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="ManagedIdentitiesServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ManagedIdentitiesServiceClient"/>.</returns>
        public static ManagedIdentitiesServiceClient Create() => new ManagedIdentitiesServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ManagedIdentitiesServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ManagedIdentitiesServiceSettings"/>.</param>
        /// <returns>The created <see cref="ManagedIdentitiesServiceClient"/>.</returns>
        internal static ManagedIdentitiesServiceClient Create(grpccore::CallInvoker callInvoker, ManagedIdentitiesServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ManagedIdentitiesService.ManagedIdentitiesServiceClient grpcClient = new ManagedIdentitiesService.ManagedIdentitiesServiceClient(callInvoker);
            return new ManagedIdentitiesServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC ManagedIdentitiesService client</summary>
        public virtual ManagedIdentitiesService.ManagedIdentitiesServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Microsoft AD domain.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Domain, OpMetadata> CreateMicrosoftAdDomain(CreateMicrosoftAdDomainRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Microsoft AD domain.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Domain, OpMetadata>> CreateMicrosoftAdDomainAsync(CreateMicrosoftAdDomainRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Microsoft AD domain.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Domain, OpMetadata>> CreateMicrosoftAdDomainAsync(CreateMicrosoftAdDomainRequest request, st::CancellationToken cancellationToken) =>
            CreateMicrosoftAdDomainAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateMicrosoftAdDomain</c>.</summary>
        public virtual lro::OperationsClient CreateMicrosoftAdDomainOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateMicrosoftAdDomain</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Domain, OpMetadata> PollOnceCreateMicrosoftAdDomain(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Domain, OpMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateMicrosoftAdDomainOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateMicrosoftAdDomain</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Domain, OpMetadata>> PollOnceCreateMicrosoftAdDomainAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Domain, OpMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateMicrosoftAdDomainOperationsClient, callSettings);

        /// <summary>
        /// Resets a domain's administrator password.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ResetAdminPasswordResponse ResetAdminPassword(ResetAdminPasswordRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resets a domain's administrator password.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResetAdminPasswordResponse> ResetAdminPasswordAsync(ResetAdminPasswordRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resets a domain's administrator password.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResetAdminPasswordResponse> ResetAdminPasswordAsync(ResetAdminPasswordRequest request, st::CancellationToken cancellationToken) =>
            ResetAdminPasswordAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists domains in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Domain"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDomainsResponse, Domain> ListDomains(ListDomainsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists domains in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Domain"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDomainsResponse, Domain> ListDomainsAsync(ListDomainsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about a domain.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Domain GetDomain(GetDomainRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about a domain.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Domain> GetDomainAsync(GetDomainRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about a domain.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Domain> GetDomainAsync(GetDomainRequest request, st::CancellationToken cancellationToken) =>
            GetDomainAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the metadata and configuration of a domain.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Domain, OpMetadata> UpdateDomain(UpdateDomainRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the metadata and configuration of a domain.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Domain, OpMetadata>> UpdateDomainAsync(UpdateDomainRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the metadata and configuration of a domain.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Domain, OpMetadata>> UpdateDomainAsync(UpdateDomainRequest request, st::CancellationToken cancellationToken) =>
            UpdateDomainAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateDomain</c>.</summary>
        public virtual lro::OperationsClient UpdateDomainOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateDomain</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Domain, OpMetadata> PollOnceUpdateDomain(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Domain, OpMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateDomainOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateDomain</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Domain, OpMetadata>> PollOnceUpdateDomainAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Domain, OpMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateDomainOperationsClient, callSettings);

        /// <summary>
        /// Deletes a domain.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OpMetadata> DeleteDomain(DeleteDomainRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a domain.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OpMetadata>> DeleteDomainAsync(DeleteDomainRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a domain.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OpMetadata>> DeleteDomainAsync(DeleteDomainRequest request, st::CancellationToken cancellationToken) =>
            DeleteDomainAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteDomain</c>.</summary>
        public virtual lro::OperationsClient DeleteDomainOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteDomain</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OpMetadata> PollOnceDeleteDomain(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OpMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteDomainOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteDomain</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OpMetadata>> PollOnceDeleteDomainAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OpMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteDomainOperationsClient, callSettings);

        /// <summary>
        /// Adds an AD trust to a domain.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Domain, OpMetadata> AttachTrust(AttachTrustRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds an AD trust to a domain.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Domain, OpMetadata>> AttachTrustAsync(AttachTrustRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds an AD trust to a domain.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Domain, OpMetadata>> AttachTrustAsync(AttachTrustRequest request, st::CancellationToken cancellationToken) =>
            AttachTrustAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>AttachTrust</c>.</summary>
        public virtual lro::OperationsClient AttachTrustOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>AttachTrust</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Domain, OpMetadata> PollOnceAttachTrust(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Domain, OpMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), AttachTrustOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>AttachTrust</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Domain, OpMetadata>> PollOnceAttachTrustAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Domain, OpMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), AttachTrustOperationsClient, callSettings);

        /// <summary>
        /// Updates the DNS conditional forwarder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Domain, OpMetadata> ReconfigureTrust(ReconfigureTrustRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the DNS conditional forwarder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Domain, OpMetadata>> ReconfigureTrustAsync(ReconfigureTrustRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the DNS conditional forwarder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Domain, OpMetadata>> ReconfigureTrustAsync(ReconfigureTrustRequest request, st::CancellationToken cancellationToken) =>
            ReconfigureTrustAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ReconfigureTrust</c>.</summary>
        public virtual lro::OperationsClient ReconfigureTrustOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ReconfigureTrust</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Domain, OpMetadata> PollOnceReconfigureTrust(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Domain, OpMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ReconfigureTrustOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ReconfigureTrust</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Domain, OpMetadata>> PollOnceReconfigureTrustAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Domain, OpMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ReconfigureTrustOperationsClient, callSettings);

        /// <summary>
        /// Removes an AD trust.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Domain, OpMetadata> DetachTrust(DetachTrustRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes an AD trust.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Domain, OpMetadata>> DetachTrustAsync(DetachTrustRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes an AD trust.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Domain, OpMetadata>> DetachTrustAsync(DetachTrustRequest request, st::CancellationToken cancellationToken) =>
            DetachTrustAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DetachTrust</c>.</summary>
        public virtual lro::OperationsClient DetachTrustOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DetachTrust</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Domain, OpMetadata> PollOnceDetachTrust(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Domain, OpMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DetachTrustOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DetachTrust</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Domain, OpMetadata>> PollOnceDetachTrustAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Domain, OpMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DetachTrustOperationsClient, callSettings);

        /// <summary>
        /// Validates a trust state, that the target domain is reachable, and that the
        /// target domain is able to accept incoming trust requests.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Domain, OpMetadata> ValidateTrust(ValidateTrustRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Validates a trust state, that the target domain is reachable, and that the
        /// target domain is able to accept incoming trust requests.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Domain, OpMetadata>> ValidateTrustAsync(ValidateTrustRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Validates a trust state, that the target domain is reachable, and that the
        /// target domain is able to accept incoming trust requests.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Domain, OpMetadata>> ValidateTrustAsync(ValidateTrustRequest request, st::CancellationToken cancellationToken) =>
            ValidateTrustAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ValidateTrust</c>.</summary>
        public virtual lro::OperationsClient ValidateTrustOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ValidateTrust</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Domain, OpMetadata> PollOnceValidateTrust(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Domain, OpMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ValidateTrustOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ValidateTrust</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Domain, OpMetadata>> PollOnceValidateTrustAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Domain, OpMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ValidateTrustOperationsClient, callSettings);
    }

    /// <summary>ManagedIdentitiesService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// </remarks>
    public sealed partial class ManagedIdentitiesServiceClientImpl : ManagedIdentitiesServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateMicrosoftAdDomainRequest, lro::Operation> _callCreateMicrosoftAdDomain;

        private readonly gaxgrpc::ApiCall<ResetAdminPasswordRequest, ResetAdminPasswordResponse> _callResetAdminPassword;

        private readonly gaxgrpc::ApiCall<ListDomainsRequest, ListDomainsResponse> _callListDomains;

        private readonly gaxgrpc::ApiCall<GetDomainRequest, Domain> _callGetDomain;

        private readonly gaxgrpc::ApiCall<UpdateDomainRequest, lro::Operation> _callUpdateDomain;

        private readonly gaxgrpc::ApiCall<DeleteDomainRequest, lro::Operation> _callDeleteDomain;

        private readonly gaxgrpc::ApiCall<AttachTrustRequest, lro::Operation> _callAttachTrust;

        private readonly gaxgrpc::ApiCall<ReconfigureTrustRequest, lro::Operation> _callReconfigureTrust;

        private readonly gaxgrpc::ApiCall<DetachTrustRequest, lro::Operation> _callDetachTrust;

        private readonly gaxgrpc::ApiCall<ValidateTrustRequest, lro::Operation> _callValidateTrust;

        /// <summary>
        /// Constructs a client wrapper for the ManagedIdentitiesService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="ManagedIdentitiesServiceSettings"/> used within this client.
        /// </param>
        public ManagedIdentitiesServiceClientImpl(ManagedIdentitiesService.ManagedIdentitiesServiceClient grpcClient, ManagedIdentitiesServiceSettings settings)
        {
            GrpcClient = grpcClient;
            ManagedIdentitiesServiceSettings effectiveSettings = settings ?? ManagedIdentitiesServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            CreateMicrosoftAdDomainOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateMicrosoftAdDomainOperationsSettings);
            UpdateDomainOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateDomainOperationsSettings);
            DeleteDomainOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteDomainOperationsSettings);
            AttachTrustOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.AttachTrustOperationsSettings);
            ReconfigureTrustOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ReconfigureTrustOperationsSettings);
            DetachTrustOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DetachTrustOperationsSettings);
            ValidateTrustOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ValidateTrustOperationsSettings);
            _callCreateMicrosoftAdDomain = clientHelper.BuildApiCall<CreateMicrosoftAdDomainRequest, lro::Operation>(grpcClient.CreateMicrosoftAdDomainAsync, grpcClient.CreateMicrosoftAdDomain, effectiveSettings.CreateMicrosoftAdDomainSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateMicrosoftAdDomain);
            Modify_CreateMicrosoftAdDomainApiCall(ref _callCreateMicrosoftAdDomain);
            _callResetAdminPassword = clientHelper.BuildApiCall<ResetAdminPasswordRequest, ResetAdminPasswordResponse>(grpcClient.ResetAdminPasswordAsync, grpcClient.ResetAdminPassword, effectiveSettings.ResetAdminPasswordSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callResetAdminPassword);
            Modify_ResetAdminPasswordApiCall(ref _callResetAdminPassword);
            _callListDomains = clientHelper.BuildApiCall<ListDomainsRequest, ListDomainsResponse>(grpcClient.ListDomainsAsync, grpcClient.ListDomains, effectiveSettings.ListDomainsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDomains);
            Modify_ListDomainsApiCall(ref _callListDomains);
            _callGetDomain = clientHelper.BuildApiCall<GetDomainRequest, Domain>(grpcClient.GetDomainAsync, grpcClient.GetDomain, effectiveSettings.GetDomainSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDomain);
            Modify_GetDomainApiCall(ref _callGetDomain);
            _callUpdateDomain = clientHelper.BuildApiCall<UpdateDomainRequest, lro::Operation>(grpcClient.UpdateDomainAsync, grpcClient.UpdateDomain, effectiveSettings.UpdateDomainSettings).WithGoogleRequestParam("domain.name", request => request.Domain?.Name);
            Modify_ApiCall(ref _callUpdateDomain);
            Modify_UpdateDomainApiCall(ref _callUpdateDomain);
            _callDeleteDomain = clientHelper.BuildApiCall<DeleteDomainRequest, lro::Operation>(grpcClient.DeleteDomainAsync, grpcClient.DeleteDomain, effectiveSettings.DeleteDomainSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteDomain);
            Modify_DeleteDomainApiCall(ref _callDeleteDomain);
            _callAttachTrust = clientHelper.BuildApiCall<AttachTrustRequest, lro::Operation>(grpcClient.AttachTrustAsync, grpcClient.AttachTrust, effectiveSettings.AttachTrustSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callAttachTrust);
            Modify_AttachTrustApiCall(ref _callAttachTrust);
            _callReconfigureTrust = clientHelper.BuildApiCall<ReconfigureTrustRequest, lro::Operation>(grpcClient.ReconfigureTrustAsync, grpcClient.ReconfigureTrust, effectiveSettings.ReconfigureTrustSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callReconfigureTrust);
            Modify_ReconfigureTrustApiCall(ref _callReconfigureTrust);
            _callDetachTrust = clientHelper.BuildApiCall<DetachTrustRequest, lro::Operation>(grpcClient.DetachTrustAsync, grpcClient.DetachTrust, effectiveSettings.DetachTrustSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDetachTrust);
            Modify_DetachTrustApiCall(ref _callDetachTrust);
            _callValidateTrust = clientHelper.BuildApiCall<ValidateTrustRequest, lro::Operation>(grpcClient.ValidateTrustAsync, grpcClient.ValidateTrust, effectiveSettings.ValidateTrustSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callValidateTrust);
            Modify_ValidateTrustApiCall(ref _callValidateTrust);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateMicrosoftAdDomainApiCall(ref gaxgrpc::ApiCall<CreateMicrosoftAdDomainRequest, lro::Operation> call);

        partial void Modify_ResetAdminPasswordApiCall(ref gaxgrpc::ApiCall<ResetAdminPasswordRequest, ResetAdminPasswordResponse> call);

        partial void Modify_ListDomainsApiCall(ref gaxgrpc::ApiCall<ListDomainsRequest, ListDomainsResponse> call);

        partial void Modify_GetDomainApiCall(ref gaxgrpc::ApiCall<GetDomainRequest, Domain> call);

        partial void Modify_UpdateDomainApiCall(ref gaxgrpc::ApiCall<UpdateDomainRequest, lro::Operation> call);

        partial void Modify_DeleteDomainApiCall(ref gaxgrpc::ApiCall<DeleteDomainRequest, lro::Operation> call);

        partial void Modify_AttachTrustApiCall(ref gaxgrpc::ApiCall<AttachTrustRequest, lro::Operation> call);

        partial void Modify_ReconfigureTrustApiCall(ref gaxgrpc::ApiCall<ReconfigureTrustRequest, lro::Operation> call);

        partial void Modify_DetachTrustApiCall(ref gaxgrpc::ApiCall<DetachTrustRequest, lro::Operation> call);

        partial void Modify_ValidateTrustApiCall(ref gaxgrpc::ApiCall<ValidateTrustRequest, lro::Operation> call);

        partial void OnConstruction(ManagedIdentitiesService.ManagedIdentitiesServiceClient grpcClient, ManagedIdentitiesServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ManagedIdentitiesService client</summary>
        public override ManagedIdentitiesService.ManagedIdentitiesServiceClient GrpcClient { get; }

        partial void Modify_CreateMicrosoftAdDomainRequest(ref CreateMicrosoftAdDomainRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ResetAdminPasswordRequest(ref ResetAdminPasswordRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDomainsRequest(ref ListDomainsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDomainRequest(ref GetDomainRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDomainRequest(ref UpdateDomainRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteDomainRequest(ref DeleteDomainRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AttachTrustRequest(ref AttachTrustRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ReconfigureTrustRequest(ref ReconfigureTrustRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DetachTrustRequest(ref DetachTrustRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ValidateTrustRequest(ref ValidateTrustRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateMicrosoftAdDomain</c>.</summary>
        public override lro::OperationsClient CreateMicrosoftAdDomainOperationsClient { get; }

        /// <summary>
        /// Creates a Microsoft AD domain.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Domain, OpMetadata> CreateMicrosoftAdDomain(CreateMicrosoftAdDomainRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMicrosoftAdDomainRequest(ref request, ref callSettings);
            return new lro::Operation<Domain, OpMetadata>(_callCreateMicrosoftAdDomain.Sync(request, callSettings), CreateMicrosoftAdDomainOperationsClient);
        }

        /// <summary>
        /// Creates a Microsoft AD domain.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Domain, OpMetadata>> CreateMicrosoftAdDomainAsync(CreateMicrosoftAdDomainRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMicrosoftAdDomainRequest(ref request, ref callSettings);
            return new lro::Operation<Domain, OpMetadata>(await _callCreateMicrosoftAdDomain.Async(request, callSettings).ConfigureAwait(false), CreateMicrosoftAdDomainOperationsClient);
        }

        /// <summary>
        /// Resets a domain's administrator password.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ResetAdminPasswordResponse ResetAdminPassword(ResetAdminPasswordRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResetAdminPasswordRequest(ref request, ref callSettings);
            return _callResetAdminPassword.Sync(request, callSettings);
        }

        /// <summary>
        /// Resets a domain's administrator password.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ResetAdminPasswordResponse> ResetAdminPasswordAsync(ResetAdminPasswordRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResetAdminPasswordRequest(ref request, ref callSettings);
            return _callResetAdminPassword.Async(request, callSettings);
        }

        /// <summary>
        /// Lists domains in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Domain"/> resources.</returns>
        public override gax::PagedEnumerable<ListDomainsResponse, Domain> ListDomains(ListDomainsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDomainsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDomainsRequest, ListDomainsResponse, Domain>(_callListDomains, request, callSettings);
        }

        /// <summary>
        /// Lists domains in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Domain"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDomainsResponse, Domain> ListDomainsAsync(ListDomainsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDomainsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDomainsRequest, ListDomainsResponse, Domain>(_callListDomains, request, callSettings);
        }

        /// <summary>
        /// Gets information about a domain.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Domain GetDomain(GetDomainRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDomainRequest(ref request, ref callSettings);
            return _callGetDomain.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets information about a domain.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Domain> GetDomainAsync(GetDomainRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDomainRequest(ref request, ref callSettings);
            return _callGetDomain.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateDomain</c>.</summary>
        public override lro::OperationsClient UpdateDomainOperationsClient { get; }

        /// <summary>
        /// Updates the metadata and configuration of a domain.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Domain, OpMetadata> UpdateDomain(UpdateDomainRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDomainRequest(ref request, ref callSettings);
            return new lro::Operation<Domain, OpMetadata>(_callUpdateDomain.Sync(request, callSettings), UpdateDomainOperationsClient);
        }

        /// <summary>
        /// Updates the metadata and configuration of a domain.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Domain, OpMetadata>> UpdateDomainAsync(UpdateDomainRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDomainRequest(ref request, ref callSettings);
            return new lro::Operation<Domain, OpMetadata>(await _callUpdateDomain.Async(request, callSettings).ConfigureAwait(false), UpdateDomainOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteDomain</c>.</summary>
        public override lro::OperationsClient DeleteDomainOperationsClient { get; }

        /// <summary>
        /// Deletes a domain.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OpMetadata> DeleteDomain(DeleteDomainRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDomainRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OpMetadata>(_callDeleteDomain.Sync(request, callSettings), DeleteDomainOperationsClient);
        }

        /// <summary>
        /// Deletes a domain.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OpMetadata>> DeleteDomainAsync(DeleteDomainRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDomainRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OpMetadata>(await _callDeleteDomain.Async(request, callSettings).ConfigureAwait(false), DeleteDomainOperationsClient);
        }

        /// <summary>The long-running operations client for <c>AttachTrust</c>.</summary>
        public override lro::OperationsClient AttachTrustOperationsClient { get; }

        /// <summary>
        /// Adds an AD trust to a domain.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Domain, OpMetadata> AttachTrust(AttachTrustRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AttachTrustRequest(ref request, ref callSettings);
            return new lro::Operation<Domain, OpMetadata>(_callAttachTrust.Sync(request, callSettings), AttachTrustOperationsClient);
        }

        /// <summary>
        /// Adds an AD trust to a domain.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Domain, OpMetadata>> AttachTrustAsync(AttachTrustRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AttachTrustRequest(ref request, ref callSettings);
            return new lro::Operation<Domain, OpMetadata>(await _callAttachTrust.Async(request, callSettings).ConfigureAwait(false), AttachTrustOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ReconfigureTrust</c>.</summary>
        public override lro::OperationsClient ReconfigureTrustOperationsClient { get; }

        /// <summary>
        /// Updates the DNS conditional forwarder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Domain, OpMetadata> ReconfigureTrust(ReconfigureTrustRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReconfigureTrustRequest(ref request, ref callSettings);
            return new lro::Operation<Domain, OpMetadata>(_callReconfigureTrust.Sync(request, callSettings), ReconfigureTrustOperationsClient);
        }

        /// <summary>
        /// Updates the DNS conditional forwarder.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Domain, OpMetadata>> ReconfigureTrustAsync(ReconfigureTrustRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReconfigureTrustRequest(ref request, ref callSettings);
            return new lro::Operation<Domain, OpMetadata>(await _callReconfigureTrust.Async(request, callSettings).ConfigureAwait(false), ReconfigureTrustOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DetachTrust</c>.</summary>
        public override lro::OperationsClient DetachTrustOperationsClient { get; }

        /// <summary>
        /// Removes an AD trust.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Domain, OpMetadata> DetachTrust(DetachTrustRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DetachTrustRequest(ref request, ref callSettings);
            return new lro::Operation<Domain, OpMetadata>(_callDetachTrust.Sync(request, callSettings), DetachTrustOperationsClient);
        }

        /// <summary>
        /// Removes an AD trust.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Domain, OpMetadata>> DetachTrustAsync(DetachTrustRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DetachTrustRequest(ref request, ref callSettings);
            return new lro::Operation<Domain, OpMetadata>(await _callDetachTrust.Async(request, callSettings).ConfigureAwait(false), DetachTrustOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ValidateTrust</c>.</summary>
        public override lro::OperationsClient ValidateTrustOperationsClient { get; }

        /// <summary>
        /// Validates a trust state, that the target domain is reachable, and that the
        /// target domain is able to accept incoming trust requests.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Domain, OpMetadata> ValidateTrust(ValidateTrustRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ValidateTrustRequest(ref request, ref callSettings);
            return new lro::Operation<Domain, OpMetadata>(_callValidateTrust.Sync(request, callSettings), ValidateTrustOperationsClient);
        }

        /// <summary>
        /// Validates a trust state, that the target domain is reachable, and that the
        /// target domain is able to accept incoming trust requests.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Domain, OpMetadata>> ValidateTrustAsync(ValidateTrustRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ValidateTrustRequest(ref request, ref callSettings);
            return new lro::Operation<Domain, OpMetadata>(await _callValidateTrust.Async(request, callSettings).ConfigureAwait(false), ValidateTrustOperationsClient);
        }
    }

    public partial class ListDomainsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDomainsResponse : gaxgrpc::IPageResponse<Domain>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Domain> GetEnumerator() => Domains.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class ManagedIdentitiesService
    {
        public partial class ManagedIdentitiesServiceClient
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
