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
    /// <summary>Settings for <see cref="AccountManagementServiceClient"/> instances.</summary>
    public sealed partial class AccountManagementServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AccountManagementServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AccountManagementServiceSettings"/>.</returns>
        public static AccountManagementServiceSettings GetDefault() => new AccountManagementServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="AccountManagementServiceSettings"/> object with default settings.
        /// </summary>
        public AccountManagementServiceSettings()
        {
        }

        private AccountManagementServiceSettings(AccountManagementServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            FinalizeMfaEnrollmentSettings = existing.FinalizeMfaEnrollmentSettings;
            StartMfaEnrollmentSettings = existing.StartMfaEnrollmentSettings;
            WithdrawMfaSettings = existing.WithdrawMfaSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AccountManagementServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccountManagementServiceClient.FinalizeMfaEnrollment</c> and
        /// <c>AccountManagementServiceClient.FinalizeMfaEnrollmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings FinalizeMfaEnrollmentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccountManagementServiceClient.StartMfaEnrollment</c> and
        /// <c>AccountManagementServiceClient.StartMfaEnrollmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StartMfaEnrollmentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccountManagementServiceClient.WithdrawMfa</c> and <c>AccountManagementServiceClient.WithdrawMfaAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings WithdrawMfaSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AccountManagementServiceSettings"/> object.</returns>
        public AccountManagementServiceSettings Clone() => new AccountManagementServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AccountManagementServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class AccountManagementServiceClientBuilder : gaxgrpc::ClientBuilderBase<AccountManagementServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AccountManagementServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref AccountManagementServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AccountManagementServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AccountManagementServiceClient Build()
        {
            AccountManagementServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AccountManagementServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AccountManagementServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AccountManagementServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AccountManagementServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<AccountManagementServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AccountManagementServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => AccountManagementServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => AccountManagementServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AccountManagementServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>AccountManagementService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Account management for Identity Toolkit
    /// </remarks>
    public abstract partial class AccountManagementServiceClient
    {
        /// <summary>
        /// The default endpoint for the AccountManagementService service, which is a host of
        /// "identitytoolkit.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "identitytoolkit.googleapis.com:443";

        /// <summary>The default AccountManagementService scopes.</summary>
        /// <remarks>
        /// The default AccountManagementService scopes are:
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
        /// Asynchronously creates a <see cref="AccountManagementServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="AccountManagementServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AccountManagementServiceClient"/>.</returns>
        public static stt::Task<AccountManagementServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AccountManagementServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AccountManagementServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="AccountManagementServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AccountManagementServiceClient"/>.</returns>
        public static AccountManagementServiceClient Create() => new AccountManagementServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AccountManagementServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AccountManagementServiceSettings"/>.</param>
        /// <returns>The created <see cref="AccountManagementServiceClient"/>.</returns>
        internal static AccountManagementServiceClient Create(grpccore::CallInvoker callInvoker, AccountManagementServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AccountManagementService.AccountManagementServiceClient grpcClient = new AccountManagementService.AccountManagementServiceClient(callInvoker);
            return new AccountManagementServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC AccountManagementService client</summary>
        public virtual AccountManagementService.AccountManagementServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Finishes enrolling a second factor for the user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FinalizeMfaEnrollmentResponse FinalizeMfaEnrollment(FinalizeMfaEnrollmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Finishes enrolling a second factor for the user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FinalizeMfaEnrollmentResponse> FinalizeMfaEnrollmentAsync(FinalizeMfaEnrollmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Finishes enrolling a second factor for the user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FinalizeMfaEnrollmentResponse> FinalizeMfaEnrollmentAsync(FinalizeMfaEnrollmentRequest request, st::CancellationToken cancellationToken) =>
            FinalizeMfaEnrollmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Step one of the MFA enrollment process. In SMS case, this sends an
        /// SMS verification code to the user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StartMfaEnrollmentResponse StartMfaEnrollment(StartMfaEnrollmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Step one of the MFA enrollment process. In SMS case, this sends an
        /// SMS verification code to the user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StartMfaEnrollmentResponse> StartMfaEnrollmentAsync(StartMfaEnrollmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Step one of the MFA enrollment process. In SMS case, this sends an
        /// SMS verification code to the user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StartMfaEnrollmentResponse> StartMfaEnrollmentAsync(StartMfaEnrollmentRequest request, st::CancellationToken cancellationToken) =>
            StartMfaEnrollmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Revokes one second factor from the enrolled second factors for an account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WithdrawMfaResponse WithdrawMfa(WithdrawMfaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Revokes one second factor from the enrolled second factors for an account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WithdrawMfaResponse> WithdrawMfaAsync(WithdrawMfaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Revokes one second factor from the enrolled second factors for an account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WithdrawMfaResponse> WithdrawMfaAsync(WithdrawMfaRequest request, st::CancellationToken cancellationToken) =>
            WithdrawMfaAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AccountManagementService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Account management for Identity Toolkit
    /// </remarks>
    public sealed partial class AccountManagementServiceClientImpl : AccountManagementServiceClient
    {
        private readonly gaxgrpc::ApiCall<FinalizeMfaEnrollmentRequest, FinalizeMfaEnrollmentResponse> _callFinalizeMfaEnrollment;

        private readonly gaxgrpc::ApiCall<StartMfaEnrollmentRequest, StartMfaEnrollmentResponse> _callStartMfaEnrollment;

        private readonly gaxgrpc::ApiCall<WithdrawMfaRequest, WithdrawMfaResponse> _callWithdrawMfa;

        /// <summary>
        /// Constructs a client wrapper for the AccountManagementService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="AccountManagementServiceSettings"/> used within this client.
        /// </param>
        public AccountManagementServiceClientImpl(AccountManagementService.AccountManagementServiceClient grpcClient, AccountManagementServiceSettings settings)
        {
            GrpcClient = grpcClient;
            AccountManagementServiceSettings effectiveSettings = settings ?? AccountManagementServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callFinalizeMfaEnrollment = clientHelper.BuildApiCall<FinalizeMfaEnrollmentRequest, FinalizeMfaEnrollmentResponse>(grpcClient.FinalizeMfaEnrollmentAsync, grpcClient.FinalizeMfaEnrollment, effectiveSettings.FinalizeMfaEnrollmentSettings);
            Modify_ApiCall(ref _callFinalizeMfaEnrollment);
            Modify_FinalizeMfaEnrollmentApiCall(ref _callFinalizeMfaEnrollment);
            _callStartMfaEnrollment = clientHelper.BuildApiCall<StartMfaEnrollmentRequest, StartMfaEnrollmentResponse>(grpcClient.StartMfaEnrollmentAsync, grpcClient.StartMfaEnrollment, effectiveSettings.StartMfaEnrollmentSettings);
            Modify_ApiCall(ref _callStartMfaEnrollment);
            Modify_StartMfaEnrollmentApiCall(ref _callStartMfaEnrollment);
            _callWithdrawMfa = clientHelper.BuildApiCall<WithdrawMfaRequest, WithdrawMfaResponse>(grpcClient.WithdrawMfaAsync, grpcClient.WithdrawMfa, effectiveSettings.WithdrawMfaSettings);
            Modify_ApiCall(ref _callWithdrawMfa);
            Modify_WithdrawMfaApiCall(ref _callWithdrawMfa);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_FinalizeMfaEnrollmentApiCall(ref gaxgrpc::ApiCall<FinalizeMfaEnrollmentRequest, FinalizeMfaEnrollmentResponse> call);

        partial void Modify_StartMfaEnrollmentApiCall(ref gaxgrpc::ApiCall<StartMfaEnrollmentRequest, StartMfaEnrollmentResponse> call);

        partial void Modify_WithdrawMfaApiCall(ref gaxgrpc::ApiCall<WithdrawMfaRequest, WithdrawMfaResponse> call);

        partial void OnConstruction(AccountManagementService.AccountManagementServiceClient grpcClient, AccountManagementServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AccountManagementService client</summary>
        public override AccountManagementService.AccountManagementServiceClient GrpcClient { get; }

        partial void Modify_FinalizeMfaEnrollmentRequest(ref FinalizeMfaEnrollmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StartMfaEnrollmentRequest(ref StartMfaEnrollmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_WithdrawMfaRequest(ref WithdrawMfaRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Finishes enrolling a second factor for the user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FinalizeMfaEnrollmentResponse FinalizeMfaEnrollment(FinalizeMfaEnrollmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FinalizeMfaEnrollmentRequest(ref request, ref callSettings);
            return _callFinalizeMfaEnrollment.Sync(request, callSettings);
        }

        /// <summary>
        /// Finishes enrolling a second factor for the user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FinalizeMfaEnrollmentResponse> FinalizeMfaEnrollmentAsync(FinalizeMfaEnrollmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FinalizeMfaEnrollmentRequest(ref request, ref callSettings);
            return _callFinalizeMfaEnrollment.Async(request, callSettings);
        }

        /// <summary>
        /// Step one of the MFA enrollment process. In SMS case, this sends an
        /// SMS verification code to the user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override StartMfaEnrollmentResponse StartMfaEnrollment(StartMfaEnrollmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartMfaEnrollmentRequest(ref request, ref callSettings);
            return _callStartMfaEnrollment.Sync(request, callSettings);
        }

        /// <summary>
        /// Step one of the MFA enrollment process. In SMS case, this sends an
        /// SMS verification code to the user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<StartMfaEnrollmentResponse> StartMfaEnrollmentAsync(StartMfaEnrollmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartMfaEnrollmentRequest(ref request, ref callSettings);
            return _callStartMfaEnrollment.Async(request, callSettings);
        }

        /// <summary>
        /// Revokes one second factor from the enrolled second factors for an account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override WithdrawMfaResponse WithdrawMfa(WithdrawMfaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_WithdrawMfaRequest(ref request, ref callSettings);
            return _callWithdrawMfa.Sync(request, callSettings);
        }

        /// <summary>
        /// Revokes one second factor from the enrolled second factors for an account.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<WithdrawMfaResponse> WithdrawMfaAsync(WithdrawMfaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_WithdrawMfaRequest(ref request, ref callSettings);
            return _callWithdrawMfa.Async(request, callSettings);
        }
    }
}
