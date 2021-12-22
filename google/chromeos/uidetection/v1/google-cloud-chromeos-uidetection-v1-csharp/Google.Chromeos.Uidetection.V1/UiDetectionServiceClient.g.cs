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

namespace Google.Chromeos.Uidetection.V1
{
    /// <summary>Settings for <see cref="UiDetectionServiceClient"/> instances.</summary>
    public sealed partial class UiDetectionServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="UiDetectionServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="UiDetectionServiceSettings"/>.</returns>
        public static UiDetectionServiceSettings GetDefault() => new UiDetectionServiceSettings();

        /// <summary>Constructs a new <see cref="UiDetectionServiceSettings"/> object with default settings.</summary>
        public UiDetectionServiceSettings()
        {
        }

        private UiDetectionServiceSettings(UiDetectionServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ExecuteDetectionSettings = existing.ExecuteDetectionSettings;
            OnCopy(existing);
        }

        partial void OnCopy(UiDetectionServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UiDetectionServiceClient.ExecuteDetection</c> and <c>UiDetectionServiceClient.ExecuteDetectionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ExecuteDetectionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="UiDetectionServiceSettings"/> object.</returns>
        public UiDetectionServiceSettings Clone() => new UiDetectionServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="UiDetectionServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class UiDetectionServiceClientBuilder : gaxgrpc::ClientBuilderBase<UiDetectionServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public UiDetectionServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public UiDetectionServiceClientBuilder()
        {
            UseJwtAccessWithScopes = UiDetectionServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref UiDetectionServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<UiDetectionServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override UiDetectionServiceClient Build()
        {
            UiDetectionServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<UiDetectionServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<UiDetectionServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private UiDetectionServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return UiDetectionServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<UiDetectionServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return UiDetectionServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => UiDetectionServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => UiDetectionServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => UiDetectionServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>UiDetectionService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides image-based UI detection service.
    /// </remarks>
    public abstract partial class UiDetectionServiceClient
    {
        /// <summary>
        /// The default endpoint for the UiDetectionService service, which is a host of
        /// "chromeosuidetection.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "chromeosuidetection.googleapis.com:443";

        /// <summary>The default UiDetectionService scopes.</summary>
        /// <remarks>The default UiDetectionService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

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
        /// Asynchronously creates a <see cref="UiDetectionServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="UiDetectionServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="UiDetectionServiceClient"/>.</returns>
        public static stt::Task<UiDetectionServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new UiDetectionServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="UiDetectionServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="UiDetectionServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <returns>The created <see cref="UiDetectionServiceClient"/>.</returns>
        public static UiDetectionServiceClient Create() => new UiDetectionServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="UiDetectionServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="UiDetectionServiceSettings"/>.</param>
        /// <returns>The created <see cref="UiDetectionServiceClient"/>.</returns>
        internal static UiDetectionServiceClient Create(grpccore::CallInvoker callInvoker, UiDetectionServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            UiDetectionService.UiDetectionServiceClient grpcClient = new UiDetectionService.UiDetectionServiceClient(callInvoker);
            return new UiDetectionServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC UiDetectionService client</summary>
        public virtual UiDetectionService.UiDetectionServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Runs the detection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UiDetectionResponse ExecuteDetection(UiDetectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Runs the detection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UiDetectionResponse> ExecuteDetectionAsync(UiDetectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Runs the detection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UiDetectionResponse> ExecuteDetectionAsync(UiDetectionRequest request, st::CancellationToken cancellationToken) =>
            ExecuteDetectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>UiDetectionService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides image-based UI detection service.
    /// </remarks>
    public sealed partial class UiDetectionServiceClientImpl : UiDetectionServiceClient
    {
        private readonly gaxgrpc::ApiCall<UiDetectionRequest, UiDetectionResponse> _callExecuteDetection;

        /// <summary>
        /// Constructs a client wrapper for the UiDetectionService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="UiDetectionServiceSettings"/> used within this client.</param>
        public UiDetectionServiceClientImpl(UiDetectionService.UiDetectionServiceClient grpcClient, UiDetectionServiceSettings settings)
        {
            GrpcClient = grpcClient;
            UiDetectionServiceSettings effectiveSettings = settings ?? UiDetectionServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callExecuteDetection = clientHelper.BuildApiCall<UiDetectionRequest, UiDetectionResponse>(grpcClient.ExecuteDetectionAsync, grpcClient.ExecuteDetection, effectiveSettings.ExecuteDetectionSettings);
            Modify_ApiCall(ref _callExecuteDetection);
            Modify_ExecuteDetectionApiCall(ref _callExecuteDetection);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ExecuteDetectionApiCall(ref gaxgrpc::ApiCall<UiDetectionRequest, UiDetectionResponse> call);

        partial void OnConstruction(UiDetectionService.UiDetectionServiceClient grpcClient, UiDetectionServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC UiDetectionService client</summary>
        public override UiDetectionService.UiDetectionServiceClient GrpcClient { get; }

        partial void Modify_UiDetectionRequest(ref UiDetectionRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Runs the detection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UiDetectionResponse ExecuteDetection(UiDetectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UiDetectionRequest(ref request, ref callSettings);
            return _callExecuteDetection.Sync(request, callSettings);
        }

        /// <summary>
        /// Runs the detection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UiDetectionResponse> ExecuteDetectionAsync(UiDetectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UiDetectionRequest(ref request, ref callSettings);
            return _callExecuteDetection.Async(request, callSettings);
        }
    }
}
