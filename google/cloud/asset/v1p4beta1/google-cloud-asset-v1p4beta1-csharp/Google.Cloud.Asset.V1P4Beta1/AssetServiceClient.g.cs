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
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Asset.V1P4Beta1
{
    /// <summary>Settings for <see cref="AssetServiceClient"/> instances.</summary>
    public sealed partial class AssetServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AssetServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AssetServiceSettings"/>.</returns>
        public static AssetServiceSettings GetDefault() => new AssetServiceSettings();

        /// <summary>Constructs a new <see cref="AssetServiceSettings"/> object with default settings.</summary>
        public AssetServiceSettings()
        {
        }

        private AssetServiceSettings(AssetServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            AnalyzeIamPolicySettings = existing.AnalyzeIamPolicySettings;
            ExportIamPolicyAnalysisSettings = existing.ExportIamPolicyAnalysisSettings;
            ExportIamPolicyAnalysisOperationsSettings = existing.ExportIamPolicyAnalysisOperationsSettings.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(AssetServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AssetServiceClient.AnalyzeIamPolicy</c> and <c>AssetServiceClient.AnalyzeIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AnalyzeIamPolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AssetServiceClient.ExportIamPolicyAnalysis</c> and <c>AssetServiceClient.ExportIamPolicyAnalysisAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ExportIamPolicyAnalysisSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AssetServiceClient.ExportIamPolicyAnalysis</c> and
        /// <c>AssetServiceClient.ExportIamPolicyAnalysisAsync</c>.
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
        public lro::OperationsSettings ExportIamPolicyAnalysisOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AssetServiceSettings"/> object.</returns>
        public AssetServiceSettings Clone() => new AssetServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AssetServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class AssetServiceClientBuilder : gaxgrpc::ClientBuilderBase<AssetServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AssetServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AssetServiceClientBuilder()
        {
            UseJwtAccessWithScopes = AssetServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref AssetServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AssetServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AssetServiceClient Build()
        {
            AssetServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AssetServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AssetServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AssetServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AssetServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<AssetServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AssetServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => AssetServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => AssetServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AssetServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>AssetService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Asset service definition.
    /// </remarks>
    public abstract partial class AssetServiceClient
    {
        /// <summary>
        /// The default endpoint for the AssetService service, which is a host of "cloudasset.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "cloudasset.googleapis.com:443";

        /// <summary>The default AssetService scopes.</summary>
        /// <remarks>
        /// The default AssetService scopes are:
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
        /// Asynchronously creates a <see cref="AssetServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AssetServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AssetServiceClient"/>.</returns>
        public static stt::Task<AssetServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AssetServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AssetServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AssetServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AssetServiceClient"/>.</returns>
        public static AssetServiceClient Create() => new AssetServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AssetServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AssetServiceSettings"/>.</param>
        /// <returns>The created <see cref="AssetServiceClient"/>.</returns>
        internal static AssetServiceClient Create(grpccore::CallInvoker callInvoker, AssetServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AssetService.AssetServiceClient grpcClient = new AssetService.AssetServiceClient(callInvoker);
            return new AssetServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC AssetService client</summary>
        public virtual AssetService.AssetServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Analyzes IAM policies based on the specified request. Returns
        /// a list of [IamPolicyAnalysisResult][google.cloud.asset.v1p4beta1.IamPolicyAnalysisResult] matching the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnalyzeIamPolicyResponse AnalyzeIamPolicy(AnalyzeIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Analyzes IAM policies based on the specified request. Returns
        /// a list of [IamPolicyAnalysisResult][google.cloud.asset.v1p4beta1.IamPolicyAnalysisResult] matching the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzeIamPolicyResponse> AnalyzeIamPolicyAsync(AnalyzeIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Analyzes IAM policies based on the specified request. Returns
        /// a list of [IamPolicyAnalysisResult][google.cloud.asset.v1p4beta1.IamPolicyAnalysisResult] matching the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzeIamPolicyResponse> AnalyzeIamPolicyAsync(AnalyzeIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            AnalyzeIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Exports IAM policy analysis based on the specified request. This API
        /// implements the [google.longrunning.Operation][google.longrunning.Operation] API allowing you to keep
        /// track of the export. The metadata contains the request to help callers to
        /// map responses to requests.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportIamPolicyAnalysisResponse, ExportIamPolicyAnalysisRequest> ExportIamPolicyAnalysis(ExportIamPolicyAnalysisRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports IAM policy analysis based on the specified request. This API
        /// implements the [google.longrunning.Operation][google.longrunning.Operation] API allowing you to keep
        /// track of the export. The metadata contains the request to help callers to
        /// map responses to requests.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportIamPolicyAnalysisResponse, ExportIamPolicyAnalysisRequest>> ExportIamPolicyAnalysisAsync(ExportIamPolicyAnalysisRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports IAM policy analysis based on the specified request. This API
        /// implements the [google.longrunning.Operation][google.longrunning.Operation] API allowing you to keep
        /// track of the export. The metadata contains the request to help callers to
        /// map responses to requests.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportIamPolicyAnalysisResponse, ExportIamPolicyAnalysisRequest>> ExportIamPolicyAnalysisAsync(ExportIamPolicyAnalysisRequest request, st::CancellationToken cancellationToken) =>
            ExportIamPolicyAnalysisAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ExportIamPolicyAnalysis</c>.</summary>
        public virtual lro::OperationsClient ExportIamPolicyAnalysisOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ExportIamPolicyAnalysis</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ExportIamPolicyAnalysisResponse, ExportIamPolicyAnalysisRequest> PollOnceExportIamPolicyAnalysis(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportIamPolicyAnalysisResponse, ExportIamPolicyAnalysisRequest>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportIamPolicyAnalysisOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ExportIamPolicyAnalysis</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ExportIamPolicyAnalysisResponse, ExportIamPolicyAnalysisRequest>> PollOnceExportIamPolicyAnalysisAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportIamPolicyAnalysisResponse, ExportIamPolicyAnalysisRequest>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportIamPolicyAnalysisOperationsClient, callSettings);
    }

    /// <summary>AssetService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Asset service definition.
    /// </remarks>
    public sealed partial class AssetServiceClientImpl : AssetServiceClient
    {
        private readonly gaxgrpc::ApiCall<AnalyzeIamPolicyRequest, AnalyzeIamPolicyResponse> _callAnalyzeIamPolicy;

        private readonly gaxgrpc::ApiCall<ExportIamPolicyAnalysisRequest, lro::Operation> _callExportIamPolicyAnalysis;

        /// <summary>
        /// Constructs a client wrapper for the AssetService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AssetServiceSettings"/> used within this client.</param>
        public AssetServiceClientImpl(AssetService.AssetServiceClient grpcClient, AssetServiceSettings settings)
        {
            GrpcClient = grpcClient;
            AssetServiceSettings effectiveSettings = settings ?? AssetServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            ExportIamPolicyAnalysisOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ExportIamPolicyAnalysisOperationsSettings);
            _callAnalyzeIamPolicy = clientHelper.BuildApiCall<AnalyzeIamPolicyRequest, AnalyzeIamPolicyResponse>(grpcClient.AnalyzeIamPolicyAsync, grpcClient.AnalyzeIamPolicy, effectiveSettings.AnalyzeIamPolicySettings).WithGoogleRequestParam("analysis_query.parent", request => request.AnalysisQuery?.Parent);
            Modify_ApiCall(ref _callAnalyzeIamPolicy);
            Modify_AnalyzeIamPolicyApiCall(ref _callAnalyzeIamPolicy);
            _callExportIamPolicyAnalysis = clientHelper.BuildApiCall<ExportIamPolicyAnalysisRequest, lro::Operation>(grpcClient.ExportIamPolicyAnalysisAsync, grpcClient.ExportIamPolicyAnalysis, effectiveSettings.ExportIamPolicyAnalysisSettings).WithGoogleRequestParam("analysis_query.parent", request => request.AnalysisQuery?.Parent);
            Modify_ApiCall(ref _callExportIamPolicyAnalysis);
            Modify_ExportIamPolicyAnalysisApiCall(ref _callExportIamPolicyAnalysis);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_AnalyzeIamPolicyApiCall(ref gaxgrpc::ApiCall<AnalyzeIamPolicyRequest, AnalyzeIamPolicyResponse> call);

        partial void Modify_ExportIamPolicyAnalysisApiCall(ref gaxgrpc::ApiCall<ExportIamPolicyAnalysisRequest, lro::Operation> call);

        partial void OnConstruction(AssetService.AssetServiceClient grpcClient, AssetServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AssetService client</summary>
        public override AssetService.AssetServiceClient GrpcClient { get; }

        partial void Modify_AnalyzeIamPolicyRequest(ref AnalyzeIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ExportIamPolicyAnalysisRequest(ref ExportIamPolicyAnalysisRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Analyzes IAM policies based on the specified request. Returns
        /// a list of [IamPolicyAnalysisResult][google.cloud.asset.v1p4beta1.IamPolicyAnalysisResult] matching the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AnalyzeIamPolicyResponse AnalyzeIamPolicy(AnalyzeIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AnalyzeIamPolicyRequest(ref request, ref callSettings);
            return _callAnalyzeIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Analyzes IAM policies based on the specified request. Returns
        /// a list of [IamPolicyAnalysisResult][google.cloud.asset.v1p4beta1.IamPolicyAnalysisResult] matching the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AnalyzeIamPolicyResponse> AnalyzeIamPolicyAsync(AnalyzeIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AnalyzeIamPolicyRequest(ref request, ref callSettings);
            return _callAnalyzeIamPolicy.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>ExportIamPolicyAnalysis</c>.</summary>
        public override lro::OperationsClient ExportIamPolicyAnalysisOperationsClient { get; }

        /// <summary>
        /// Exports IAM policy analysis based on the specified request. This API
        /// implements the [google.longrunning.Operation][google.longrunning.Operation] API allowing you to keep
        /// track of the export. The metadata contains the request to help callers to
        /// map responses to requests.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ExportIamPolicyAnalysisResponse, ExportIamPolicyAnalysisRequest> ExportIamPolicyAnalysis(ExportIamPolicyAnalysisRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportIamPolicyAnalysisRequest(ref request, ref callSettings);
            return new lro::Operation<ExportIamPolicyAnalysisResponse, ExportIamPolicyAnalysisRequest>(_callExportIamPolicyAnalysis.Sync(request, callSettings), ExportIamPolicyAnalysisOperationsClient);
        }

        /// <summary>
        /// Exports IAM policy analysis based on the specified request. This API
        /// implements the [google.longrunning.Operation][google.longrunning.Operation] API allowing you to keep
        /// track of the export. The metadata contains the request to help callers to
        /// map responses to requests.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ExportIamPolicyAnalysisResponse, ExportIamPolicyAnalysisRequest>> ExportIamPolicyAnalysisAsync(ExportIamPolicyAnalysisRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportIamPolicyAnalysisRequest(ref request, ref callSettings);
            return new lro::Operation<ExportIamPolicyAnalysisResponse, ExportIamPolicyAnalysisRequest>(await _callExportIamPolicyAnalysis.Async(request, callSettings).ConfigureAwait(false), ExportIamPolicyAnalysisOperationsClient);
        }
    }

    public static partial class AssetService
    {
        public partial class AssetServiceClient
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
