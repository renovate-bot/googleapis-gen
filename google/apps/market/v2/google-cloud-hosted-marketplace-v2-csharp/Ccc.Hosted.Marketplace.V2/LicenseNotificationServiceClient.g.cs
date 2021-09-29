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
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Ccc.Hosted.Marketplace.V2
{
    /// <summary>Settings for <see cref="LicenseNotificationServiceClient"/> instances.</summary>
    public sealed partial class LicenseNotificationServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="LicenseNotificationServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="LicenseNotificationServiceSettings"/>.</returns>
        public static LicenseNotificationServiceSettings GetDefault() => new LicenseNotificationServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="LicenseNotificationServiceSettings"/> object with default settings.
        /// </summary>
        public LicenseNotificationServiceSettings()
        {
        }

        private LicenseNotificationServiceSettings(LicenseNotificationServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListSettings = existing.ListSettings;
            OnCopy(existing);
        }

        partial void OnCopy(LicenseNotificationServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LicenseNotificationServiceClient.List</c> and <c>LicenseNotificationServiceClient.ListAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.Unknown"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="LicenseNotificationServiceSettings"/> object.</returns>
        public LicenseNotificationServiceSettings Clone() => new LicenseNotificationServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="LicenseNotificationServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class LicenseNotificationServiceClientBuilder : gaxgrpc::ClientBuilderBase<LicenseNotificationServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public LicenseNotificationServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public LicenseNotificationServiceClientBuilder()
        {
            UseJwtAccessWithScopes = LicenseNotificationServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref LicenseNotificationServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<LicenseNotificationServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override LicenseNotificationServiceClient Build()
        {
            LicenseNotificationServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<LicenseNotificationServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<LicenseNotificationServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private LicenseNotificationServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return LicenseNotificationServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<LicenseNotificationServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return LicenseNotificationServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => LicenseNotificationServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => LicenseNotificationServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => LicenseNotificationServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>LicenseNotificationService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// </remarks>
    public abstract partial class LicenseNotificationServiceClient
    {
        /// <summary>
        /// The default endpoint for the LicenseNotificationService service, which is a host of
        /// "appsmarket.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "appsmarket.googleapis.com:443";

        /// <summary>The default LicenseNotificationService scopes.</summary>
        /// <remarks>
        /// The default LicenseNotificationService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/appsmarketplace.license</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/appsmarketplace.license",
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
        /// Asynchronously creates a <see cref="LicenseNotificationServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="LicenseNotificationServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="LicenseNotificationServiceClient"/>.</returns>
        public static stt::Task<LicenseNotificationServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new LicenseNotificationServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="LicenseNotificationServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="LicenseNotificationServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="LicenseNotificationServiceClient"/>.</returns>
        public static LicenseNotificationServiceClient Create() => new LicenseNotificationServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="LicenseNotificationServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="LicenseNotificationServiceSettings"/>.</param>
        /// <returns>The created <see cref="LicenseNotificationServiceClient"/>.</returns>
        internal static LicenseNotificationServiceClient Create(grpccore::CallInvoker callInvoker, LicenseNotificationServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            LicenseNotificationService.LicenseNotificationServiceClient grpcClient = new LicenseNotificationService.LicenseNotificationServiceClient(callInvoker);
            return new LicenseNotificationServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC LicenseNotificationService client</summary>
        public virtual LicenseNotificationService.LicenseNotificationServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Get a list of licensing notifications with regards to a given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LicenseNotificationList List(LicenseNotificationListRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a list of licensing notifications with regards to a given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LicenseNotificationList> ListAsync(LicenseNotificationListRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a list of licensing notifications with regards to a given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LicenseNotificationList> ListAsync(LicenseNotificationListRequest request, st::CancellationToken cancellationToken) =>
            ListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>LicenseNotificationService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// </remarks>
    public sealed partial class LicenseNotificationServiceClientImpl : LicenseNotificationServiceClient
    {
        private readonly gaxgrpc::ApiCall<LicenseNotificationListRequest, LicenseNotificationList> _callList;

        /// <summary>
        /// Constructs a client wrapper for the LicenseNotificationService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="LicenseNotificationServiceSettings"/> used within this client.
        /// </param>
        public LicenseNotificationServiceClientImpl(LicenseNotificationService.LicenseNotificationServiceClient grpcClient, LicenseNotificationServiceSettings settings)
        {
            GrpcClient = grpcClient;
            LicenseNotificationServiceSettings effectiveSettings = settings ?? LicenseNotificationServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callList = clientHelper.BuildApiCall<LicenseNotificationListRequest, LicenseNotificationList>(grpcClient.ListAsync, grpcClient.List, effectiveSettings.ListSettings).WithGoogleRequestParam("application_id", request => request.ApplicationId);
            Modify_ApiCall(ref _callList);
            Modify_ListApiCall(ref _callList);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListApiCall(ref gaxgrpc::ApiCall<LicenseNotificationListRequest, LicenseNotificationList> call);

        partial void OnConstruction(LicenseNotificationService.LicenseNotificationServiceClient grpcClient, LicenseNotificationServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC LicenseNotificationService client</summary>
        public override LicenseNotificationService.LicenseNotificationServiceClient GrpcClient { get; }

        partial void Modify_LicenseNotificationListRequest(ref LicenseNotificationListRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Get a list of licensing notifications with regards to a given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LicenseNotificationList List(LicenseNotificationListRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LicenseNotificationListRequest(ref request, ref callSettings);
            return _callList.Sync(request, callSettings);
        }

        /// <summary>
        /// Get a list of licensing notifications with regards to a given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LicenseNotificationList> ListAsync(LicenseNotificationListRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LicenseNotificationListRequest(ref request, ref callSettings);
            return _callList.Async(request, callSettings);
        }
    }
}
