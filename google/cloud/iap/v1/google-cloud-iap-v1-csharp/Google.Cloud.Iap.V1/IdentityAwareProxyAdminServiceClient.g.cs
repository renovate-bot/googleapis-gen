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
using gciv = Google.Cloud.Iam.V1;
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Iap.V1
{
    /// <summary>Settings for <see cref="IdentityAwareProxyAdminServiceClient"/> instances.</summary>
    public sealed partial class IdentityAwareProxyAdminServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="IdentityAwareProxyAdminServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="IdentityAwareProxyAdminServiceSettings"/>.</returns>
        public static IdentityAwareProxyAdminServiceSettings GetDefault() => new IdentityAwareProxyAdminServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="IdentityAwareProxyAdminServiceSettings"/> object with default settings.
        /// </summary>
        public IdentityAwareProxyAdminServiceSettings()
        {
        }

        private IdentityAwareProxyAdminServiceSettings(IdentityAwareProxyAdminServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            SetIamPolicySettings = existing.SetIamPolicySettings;
            GetIamPolicySettings = existing.GetIamPolicySettings;
            TestIamPermissionsSettings = existing.TestIamPermissionsSettings;
            GetIapSettingsSettings = existing.GetIapSettingsSettings;
            UpdateIapSettingsSettings = existing.UpdateIapSettingsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(IdentityAwareProxyAdminServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IdentityAwareProxyAdminServiceClient.SetIamPolicy</c> and
        /// <c>IdentityAwareProxyAdminServiceClient.SetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IdentityAwareProxyAdminServiceClient.GetIamPolicy</c> and
        /// <c>IdentityAwareProxyAdminServiceClient.GetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IdentityAwareProxyAdminServiceClient.TestIamPermissions</c> and
        /// <c>IdentityAwareProxyAdminServiceClient.TestIamPermissionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings TestIamPermissionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IdentityAwareProxyAdminServiceClient.GetIapSettings</c> and
        /// <c>IdentityAwareProxyAdminServiceClient.GetIapSettingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetIapSettingsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IdentityAwareProxyAdminServiceClient.UpdateIapSettings</c> and
        /// <c>IdentityAwareProxyAdminServiceClient.UpdateIapSettingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateIapSettingsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="IdentityAwareProxyAdminServiceSettings"/> object.</returns>
        public IdentityAwareProxyAdminServiceSettings Clone() => new IdentityAwareProxyAdminServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="IdentityAwareProxyAdminServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class IdentityAwareProxyAdminServiceClientBuilder : gaxgrpc::ClientBuilderBase<IdentityAwareProxyAdminServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public IdentityAwareProxyAdminServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public IdentityAwareProxyAdminServiceClientBuilder()
        {
            UseJwtAccessWithScopes = IdentityAwareProxyAdminServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref IdentityAwareProxyAdminServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<IdentityAwareProxyAdminServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override IdentityAwareProxyAdminServiceClient Build()
        {
            IdentityAwareProxyAdminServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<IdentityAwareProxyAdminServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<IdentityAwareProxyAdminServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private IdentityAwareProxyAdminServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return IdentityAwareProxyAdminServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<IdentityAwareProxyAdminServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return IdentityAwareProxyAdminServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => IdentityAwareProxyAdminServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() =>
            IdentityAwareProxyAdminServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => IdentityAwareProxyAdminServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>IdentityAwareProxyAdminService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// APIs for Identity-Aware Proxy Admin configurations.
    /// </remarks>
    public abstract partial class IdentityAwareProxyAdminServiceClient
    {
        /// <summary>
        /// The default endpoint for the IdentityAwareProxyAdminService service, which is a host of "iap.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "iap.googleapis.com:443";

        /// <summary>The default IdentityAwareProxyAdminService scopes.</summary>
        /// <remarks>
        /// The default IdentityAwareProxyAdminService scopes are:
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
        /// Asynchronously creates a <see cref="IdentityAwareProxyAdminServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="IdentityAwareProxyAdminServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="IdentityAwareProxyAdminServiceClient"/>.</returns>
        public static stt::Task<IdentityAwareProxyAdminServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new IdentityAwareProxyAdminServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="IdentityAwareProxyAdminServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="IdentityAwareProxyAdminServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="IdentityAwareProxyAdminServiceClient"/>.</returns>
        public static IdentityAwareProxyAdminServiceClient Create() =>
            new IdentityAwareProxyAdminServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="IdentityAwareProxyAdminServiceClient"/> which uses the specified call invoker for
        /// remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="IdentityAwareProxyAdminServiceSettings"/>.</param>
        /// <returns>The created <see cref="IdentityAwareProxyAdminServiceClient"/>.</returns>
        internal static IdentityAwareProxyAdminServiceClient Create(grpccore::CallInvoker callInvoker, IdentityAwareProxyAdminServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient grpcClient = new IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient(callInvoker);
            return new IdentityAwareProxyAdminServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC IdentityAwareProxyAdminService client</summary>
        public virtual IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the access control policy for an Identity-Aware Proxy protected
        /// resource. Replaces any existing policy.
        /// More information about managing access via IAP can be found at:
        /// https://cloud.google.com/iap/docs/managing-access#managing_access_via_the_api
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the access control policy for an Identity-Aware Proxy protected
        /// resource. Replaces any existing policy.
        /// More information about managing access via IAP can be found at:
        /// https://cloud.google.com/iap/docs/managing-access#managing_access_via_the_api
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the access control policy for an Identity-Aware Proxy protected
        /// resource. Replaces any existing policy.
        /// More information about managing access via IAP can be found at:
        /// https://cloud.google.com/iap/docs/managing-access#managing_access_via_the_api
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for an Identity-Aware Proxy protected
        /// resource.
        /// More information about managing access via IAP can be found at:
        /// https://cloud.google.com/iap/docs/managing-access#managing_access_via_the_api
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the access control policy for an Identity-Aware Proxy protected
        /// resource.
        /// More information about managing access via IAP can be found at:
        /// https://cloud.google.com/iap/docs/managing-access#managing_access_via_the_api
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the access control policy for an Identity-Aware Proxy protected
        /// resource.
        /// More information about managing access via IAP can be found at:
        /// https://cloud.google.com/iap/docs/managing-access#managing_access_via_the_api
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns permissions that a caller has on the Identity-Aware Proxy protected
        /// resource.
        /// More information about managing access via IAP can be found at:
        /// https://cloud.google.com/iap/docs/managing-access#managing_access_via_the_api
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::TestIamPermissionsResponse TestIamPermissions(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns permissions that a caller has on the Identity-Aware Proxy protected
        /// resource.
        /// More information about managing access via IAP can be found at:
        /// https://cloud.google.com/iap/docs/managing-access#managing_access_via_the_api
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns permissions that a caller has on the Identity-Aware Proxy protected
        /// resource.
        /// More information about managing access via IAP can be found at:
        /// https://cloud.google.com/iap/docs/managing-access#managing_access_via_the_api
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the IAP settings on a particular IAP protected resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IapSettings GetIapSettings(GetIapSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the IAP settings on a particular IAP protected resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IapSettings> GetIapSettingsAsync(GetIapSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the IAP settings on a particular IAP protected resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IapSettings> GetIapSettingsAsync(GetIapSettingsRequest request, st::CancellationToken cancellationToken) =>
            GetIapSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the IAP settings on a particular IAP protected resource. It
        /// replaces all fields unless the `update_mask` is set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IapSettings UpdateIapSettings(UpdateIapSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the IAP settings on a particular IAP protected resource. It
        /// replaces all fields unless the `update_mask` is set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IapSettings> UpdateIapSettingsAsync(UpdateIapSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the IAP settings on a particular IAP protected resource. It
        /// replaces all fields unless the `update_mask` is set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IapSettings> UpdateIapSettingsAsync(UpdateIapSettingsRequest request, st::CancellationToken cancellationToken) =>
            UpdateIapSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>IdentityAwareProxyAdminService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// APIs for Identity-Aware Proxy Admin configurations.
    /// </remarks>
    public sealed partial class IdentityAwareProxyAdminServiceClientImpl : IdentityAwareProxyAdminServiceClient
    {
        private readonly gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> _callSetIamPolicy;

        private readonly gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> _callGetIamPolicy;

        private readonly gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> _callTestIamPermissions;

        private readonly gaxgrpc::ApiCall<GetIapSettingsRequest, IapSettings> _callGetIapSettings;

        private readonly gaxgrpc::ApiCall<UpdateIapSettingsRequest, IapSettings> _callUpdateIapSettings;

        /// <summary>
        /// Constructs a client wrapper for the IdentityAwareProxyAdminService service, with the specified gRPC client
        /// and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="IdentityAwareProxyAdminServiceSettings"/> used within this client.
        /// </param>
        public IdentityAwareProxyAdminServiceClientImpl(IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient grpcClient, IdentityAwareProxyAdminServiceSettings settings)
        {
            GrpcClient = grpcClient;
            IdentityAwareProxyAdminServiceSettings effectiveSettings = settings ?? IdentityAwareProxyAdminServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callSetIamPolicy = clientHelper.BuildApiCall<gciv::SetIamPolicyRequest, gciv::Policy>(grpcClient.SetIamPolicyAsync, grpcClient.SetIamPolicy, effectiveSettings.SetIamPolicySettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callSetIamPolicy);
            Modify_SetIamPolicyApiCall(ref _callSetIamPolicy);
            _callGetIamPolicy = clientHelper.BuildApiCall<gciv::GetIamPolicyRequest, gciv::Policy>(grpcClient.GetIamPolicyAsync, grpcClient.GetIamPolicy, effectiveSettings.GetIamPolicySettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callGetIamPolicy);
            Modify_GetIamPolicyApiCall(ref _callGetIamPolicy);
            _callTestIamPermissions = clientHelper.BuildApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse>(grpcClient.TestIamPermissionsAsync, grpcClient.TestIamPermissions, effectiveSettings.TestIamPermissionsSettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callTestIamPermissions);
            Modify_TestIamPermissionsApiCall(ref _callTestIamPermissions);
            _callGetIapSettings = clientHelper.BuildApiCall<GetIapSettingsRequest, IapSettings>(grpcClient.GetIapSettingsAsync, grpcClient.GetIapSettings, effectiveSettings.GetIapSettingsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetIapSettings);
            Modify_GetIapSettingsApiCall(ref _callGetIapSettings);
            _callUpdateIapSettings = clientHelper.BuildApiCall<UpdateIapSettingsRequest, IapSettings>(grpcClient.UpdateIapSettingsAsync, grpcClient.UpdateIapSettings, effectiveSettings.UpdateIapSettingsSettings).WithGoogleRequestParam("iap_settings.name", request => request.IapSettings?.Name);
            Modify_ApiCall(ref _callUpdateIapSettings);
            Modify_UpdateIapSettingsApiCall(ref _callUpdateIapSettings);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_SetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_GetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_TestIamPermissionsApiCall(ref gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> call);

        partial void Modify_GetIapSettingsApiCall(ref gaxgrpc::ApiCall<GetIapSettingsRequest, IapSettings> call);

        partial void Modify_UpdateIapSettingsApiCall(ref gaxgrpc::ApiCall<UpdateIapSettingsRequest, IapSettings> call);

        partial void OnConstruction(IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient grpcClient, IdentityAwareProxyAdminServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC IdentityAwareProxyAdminService client</summary>
        public override IdentityAwareProxyAdminService.IdentityAwareProxyAdminServiceClient GrpcClient { get; }

        partial void Modify_SetIamPolicyRequest(ref gciv::SetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetIamPolicyRequest(ref gciv::GetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_TestIamPermissionsRequest(ref gciv::TestIamPermissionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetIapSettingsRequest(ref GetIapSettingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateIapSettingsRequest(ref UpdateIapSettingsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Sets the access control policy for an Identity-Aware Proxy protected
        /// resource. Replaces any existing policy.
        /// More information about managing access via IAP can be found at:
        /// https://cloud.google.com/iap/docs/managing-access#managing_access_via_the_api
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::Policy SetIamPolicy(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets the access control policy for an Identity-Aware Proxy protected
        /// resource. Replaces any existing policy.
        /// More information about managing access via IAP can be found at:
        /// https://cloud.google.com/iap/docs/managing-access#managing_access_via_the_api
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the access control policy for an Identity-Aware Proxy protected
        /// resource.
        /// More information about managing access via IAP can be found at:
        /// https://cloud.google.com/iap/docs/managing-access#managing_access_via_the_api
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::Policy GetIamPolicy(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the access control policy for an Identity-Aware Proxy protected
        /// resource.
        /// More information about managing access via IAP can be found at:
        /// https://cloud.google.com/iap/docs/managing-access#managing_access_via_the_api
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Returns permissions that a caller has on the Identity-Aware Proxy protected
        /// resource.
        /// More information about managing access via IAP can be found at:
        /// https://cloud.google.com/iap/docs/managing-access#managing_access_via_the_api
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::TestIamPermissionsResponse TestIamPermissions(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns permissions that a caller has on the Identity-Aware Proxy protected
        /// resource.
        /// More information about managing access via IAP can be found at:
        /// https://cloud.google.com/iap/docs/managing-access#managing_access_via_the_api
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the IAP settings on a particular IAP protected resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override IapSettings GetIapSettings(GetIapSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIapSettingsRequest(ref request, ref callSettings);
            return _callGetIapSettings.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the IAP settings on a particular IAP protected resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<IapSettings> GetIapSettingsAsync(GetIapSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIapSettingsRequest(ref request, ref callSettings);
            return _callGetIapSettings.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the IAP settings on a particular IAP protected resource. It
        /// replaces all fields unless the `update_mask` is set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override IapSettings UpdateIapSettings(UpdateIapSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateIapSettingsRequest(ref request, ref callSettings);
            return _callUpdateIapSettings.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the IAP settings on a particular IAP protected resource. It
        /// replaces all fields unless the `update_mask` is set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<IapSettings> UpdateIapSettingsAsync(UpdateIapSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateIapSettingsRequest(ref request, ref callSettings);
            return _callUpdateIapSettings.Async(request, callSettings);
        }
    }
}
