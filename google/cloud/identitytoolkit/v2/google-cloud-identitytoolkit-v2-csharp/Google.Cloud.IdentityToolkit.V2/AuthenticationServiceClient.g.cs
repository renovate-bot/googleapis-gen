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

namespace Google.Cloud.IdentityToolkit.V2
{
    /// <summary>Settings for <see cref="AuthenticationServiceClient"/> instances.</summary>
    public sealed partial class AuthenticationServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AuthenticationServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AuthenticationServiceSettings"/>.</returns>
        public static AuthenticationServiceSettings GetDefault() => new AuthenticationServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="AuthenticationServiceSettings"/> object with default settings.
        /// </summary>
        public AuthenticationServiceSettings()
        {
        }

        private AuthenticationServiceSettings(AuthenticationServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            FinalizeMfaSignInSettings = existing.FinalizeMfaSignInSettings;
            StartMfaSignInSettings = existing.StartMfaSignInSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AuthenticationServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AuthenticationServiceClient.FinalizeMfaSignIn</c> and
        /// <c>AuthenticationServiceClient.FinalizeMfaSignInAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings FinalizeMfaSignInSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AuthenticationServiceClient.StartMfaSignIn</c> and <c>AuthenticationServiceClient.StartMfaSignInAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StartMfaSignInSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AuthenticationServiceSettings"/> object.</returns>
        public AuthenticationServiceSettings Clone() => new AuthenticationServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AuthenticationServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class AuthenticationServiceClientBuilder : gaxgrpc::ClientBuilderBase<AuthenticationServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AuthenticationServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref AuthenticationServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AuthenticationServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AuthenticationServiceClient Build()
        {
            AuthenticationServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AuthenticationServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AuthenticationServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AuthenticationServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AuthenticationServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<AuthenticationServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AuthenticationServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => AuthenticationServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => AuthenticationServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AuthenticationServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>AuthenticationService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Authentication for Identity Toolkit
    /// </remarks>
    public abstract partial class AuthenticationServiceClient
    {
        /// <summary>
        /// The default endpoint for the AuthenticationService service, which is a host of
        /// "identitytoolkit.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "identitytoolkit.googleapis.com:443";

        /// <summary>The default AuthenticationService scopes.</summary>
        /// <remarks>
        /// The default AuthenticationService scopes are:
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
        /// Asynchronously creates a <see cref="AuthenticationServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="AuthenticationServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AuthenticationServiceClient"/>.</returns>
        public static stt::Task<AuthenticationServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AuthenticationServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AuthenticationServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="AuthenticationServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AuthenticationServiceClient"/>.</returns>
        public static AuthenticationServiceClient Create() => new AuthenticationServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AuthenticationServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AuthenticationServiceSettings"/>.</param>
        /// <returns>The created <see cref="AuthenticationServiceClient"/>.</returns>
        internal static AuthenticationServiceClient Create(grpccore::CallInvoker callInvoker, AuthenticationServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AuthenticationService.AuthenticationServiceClient grpcClient = new AuthenticationService.AuthenticationServiceClient(callInvoker);
            return new AuthenticationServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC AuthenticationService client</summary>
        public virtual AuthenticationService.AuthenticationServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Verifies the MFA challenge and performs sign-in
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FinalizeMfaSignInResponse FinalizeMfaSignIn(FinalizeMfaSignInRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Verifies the MFA challenge and performs sign-in
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FinalizeMfaSignInResponse> FinalizeMfaSignInAsync(FinalizeMfaSignInRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Verifies the MFA challenge and performs sign-in
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FinalizeMfaSignInResponse> FinalizeMfaSignInAsync(FinalizeMfaSignInRequest request, st::CancellationToken cancellationToken) =>
            FinalizeMfaSignInAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sends the MFA challenge
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StartMfaSignInResponse StartMfaSignIn(StartMfaSignInRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sends the MFA challenge
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StartMfaSignInResponse> StartMfaSignInAsync(StartMfaSignInRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sends the MFA challenge
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StartMfaSignInResponse> StartMfaSignInAsync(StartMfaSignInRequest request, st::CancellationToken cancellationToken) =>
            StartMfaSignInAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AuthenticationService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Authentication for Identity Toolkit
    /// </remarks>
    public sealed partial class AuthenticationServiceClientImpl : AuthenticationServiceClient
    {
        private readonly gaxgrpc::ApiCall<FinalizeMfaSignInRequest, FinalizeMfaSignInResponse> _callFinalizeMfaSignIn;

        private readonly gaxgrpc::ApiCall<StartMfaSignInRequest, StartMfaSignInResponse> _callStartMfaSignIn;

        /// <summary>
        /// Constructs a client wrapper for the AuthenticationService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AuthenticationServiceSettings"/> used within this client.</param>
        public AuthenticationServiceClientImpl(AuthenticationService.AuthenticationServiceClient grpcClient, AuthenticationServiceSettings settings)
        {
            GrpcClient = grpcClient;
            AuthenticationServiceSettings effectiveSettings = settings ?? AuthenticationServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callFinalizeMfaSignIn = clientHelper.BuildApiCall<FinalizeMfaSignInRequest, FinalizeMfaSignInResponse>(grpcClient.FinalizeMfaSignInAsync, grpcClient.FinalizeMfaSignIn, effectiveSettings.FinalizeMfaSignInSettings);
            Modify_ApiCall(ref _callFinalizeMfaSignIn);
            Modify_FinalizeMfaSignInApiCall(ref _callFinalizeMfaSignIn);
            _callStartMfaSignIn = clientHelper.BuildApiCall<StartMfaSignInRequest, StartMfaSignInResponse>(grpcClient.StartMfaSignInAsync, grpcClient.StartMfaSignIn, effectiveSettings.StartMfaSignInSettings);
            Modify_ApiCall(ref _callStartMfaSignIn);
            Modify_StartMfaSignInApiCall(ref _callStartMfaSignIn);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_FinalizeMfaSignInApiCall(ref gaxgrpc::ApiCall<FinalizeMfaSignInRequest, FinalizeMfaSignInResponse> call);

        partial void Modify_StartMfaSignInApiCall(ref gaxgrpc::ApiCall<StartMfaSignInRequest, StartMfaSignInResponse> call);

        partial void OnConstruction(AuthenticationService.AuthenticationServiceClient grpcClient, AuthenticationServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AuthenticationService client</summary>
        public override AuthenticationService.AuthenticationServiceClient GrpcClient { get; }

        partial void Modify_FinalizeMfaSignInRequest(ref FinalizeMfaSignInRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StartMfaSignInRequest(ref StartMfaSignInRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Verifies the MFA challenge and performs sign-in
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FinalizeMfaSignInResponse FinalizeMfaSignIn(FinalizeMfaSignInRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FinalizeMfaSignInRequest(ref request, ref callSettings);
            return _callFinalizeMfaSignIn.Sync(request, callSettings);
        }

        /// <summary>
        /// Verifies the MFA challenge and performs sign-in
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FinalizeMfaSignInResponse> FinalizeMfaSignInAsync(FinalizeMfaSignInRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FinalizeMfaSignInRequest(ref request, ref callSettings);
            return _callFinalizeMfaSignIn.Async(request, callSettings);
        }

        /// <summary>
        /// Sends the MFA challenge
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override StartMfaSignInResponse StartMfaSignIn(StartMfaSignInRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartMfaSignInRequest(ref request, ref callSettings);
            return _callStartMfaSignIn.Sync(request, callSettings);
        }

        /// <summary>
        /// Sends the MFA challenge
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<StartMfaSignInResponse> StartMfaSignInAsync(StartMfaSignInRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartMfaSignInRequest(ref request, ref callSettings);
            return _callStartMfaSignIn.Async(request, callSettings);
        }
    }
}
