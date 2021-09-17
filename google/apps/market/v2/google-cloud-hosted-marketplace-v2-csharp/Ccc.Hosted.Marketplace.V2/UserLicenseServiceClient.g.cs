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
    /// <summary>Settings for <see cref="UserLicenseServiceClient"/> instances.</summary>
    public sealed partial class UserLicenseServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="UserLicenseServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="UserLicenseServiceSettings"/>.</returns>
        public static UserLicenseServiceSettings GetDefault() => new UserLicenseServiceSettings();

        /// <summary>Constructs a new <see cref="UserLicenseServiceSettings"/> object with default settings.</summary>
        public UserLicenseServiceSettings()
        {
        }

        private UserLicenseServiceSettings(UserLicenseServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetSettings = existing.GetSettings;
            OnCopy(existing);
        }

        partial void OnCopy(UserLicenseServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UserLicenseServiceClient.Get</c> and <c>UserLicenseServiceClient.GetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.Unknown)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="UserLicenseServiceSettings"/> object.</returns>
        public UserLicenseServiceSettings Clone() => new UserLicenseServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="UserLicenseServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class UserLicenseServiceClientBuilder : gaxgrpc::ClientBuilderBase<UserLicenseServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public UserLicenseServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public UserLicenseServiceClientBuilder()
        {
            UseJwtAccessWithScopes = UserLicenseServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref UserLicenseServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<UserLicenseServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override UserLicenseServiceClient Build()
        {
            UserLicenseServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<UserLicenseServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<UserLicenseServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private UserLicenseServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return UserLicenseServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<UserLicenseServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return UserLicenseServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => UserLicenseServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => UserLicenseServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => UserLicenseServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>UserLicenseService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// </remarks>
    public abstract partial class UserLicenseServiceClient
    {
        /// <summary>
        /// The default endpoint for the UserLicenseService service, which is a host of "appsmarket.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "appsmarket.googleapis.com:443";

        /// <summary>The default UserLicenseService scopes.</summary>
        /// <remarks>
        /// The default UserLicenseService scopes are:
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
        /// Asynchronously creates a <see cref="UserLicenseServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="UserLicenseServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="UserLicenseServiceClient"/>.</returns>
        public static stt::Task<UserLicenseServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new UserLicenseServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="UserLicenseServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="UserLicenseServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <returns>The created <see cref="UserLicenseServiceClient"/>.</returns>
        public static UserLicenseServiceClient Create() => new UserLicenseServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="UserLicenseServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="UserLicenseServiceSettings"/>.</param>
        /// <returns>The created <see cref="UserLicenseServiceClient"/>.</returns>
        internal static UserLicenseServiceClient Create(grpccore::CallInvoker callInvoker, UserLicenseServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            UserLicenseService.UserLicenseServiceClient grpcClient = new UserLicenseService.UserLicenseServiceClient(callInvoker);
            return new UserLicenseServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC UserLicenseService client</summary>
        public virtual UserLicenseService.UserLicenseServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Get the user's licensing status for their permission to use a given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserLicense Get(UserLicenseGetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get the user's licensing status for their permission to use a given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserLicense> GetAsync(UserLicenseGetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get the user's licensing status for their permission to use a given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserLicense> GetAsync(UserLicenseGetRequest request, st::CancellationToken cancellationToken) =>
            GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>UserLicenseService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// </remarks>
    public sealed partial class UserLicenseServiceClientImpl : UserLicenseServiceClient
    {
        private readonly gaxgrpc::ApiCall<UserLicenseGetRequest, UserLicense> _callGet;

        /// <summary>
        /// Constructs a client wrapper for the UserLicenseService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="UserLicenseServiceSettings"/> used within this client.</param>
        public UserLicenseServiceClientImpl(UserLicenseService.UserLicenseServiceClient grpcClient, UserLicenseServiceSettings settings)
        {
            GrpcClient = grpcClient;
            UserLicenseServiceSettings effectiveSettings = settings ?? UserLicenseServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGet = clientHelper.BuildApiCall<UserLicenseGetRequest, UserLicense>(grpcClient.GetAsync, grpcClient.Get, effectiveSettings.GetSettings).WithGoogleRequestParam("application_id", request => request.ApplicationId).WithGoogleRequestParam("user_id", request => request.UserId);
            Modify_ApiCall(ref _callGet);
            Modify_GetApiCall(ref _callGet);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetApiCall(ref gaxgrpc::ApiCall<UserLicenseGetRequest, UserLicense> call);

        partial void OnConstruction(UserLicenseService.UserLicenseServiceClient grpcClient, UserLicenseServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC UserLicenseService client</summary>
        public override UserLicenseService.UserLicenseServiceClient GrpcClient { get; }

        partial void Modify_UserLicenseGetRequest(ref UserLicenseGetRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Get the user's licensing status for their permission to use a given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UserLicense Get(UserLicenseGetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UserLicenseGetRequest(ref request, ref callSettings);
            return _callGet.Sync(request, callSettings);
        }

        /// <summary>
        /// Get the user's licensing status for their permission to use a given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UserLicense> GetAsync(UserLicenseGetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UserLicenseGetRequest(ref request, ref callSettings);
            return _callGet.Async(request, callSettings);
        }
    }
}
