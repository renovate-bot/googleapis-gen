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

namespace Google.Cloud.Dataflow.V1Beta3
{
    /// <summary>Settings for <see cref="TemplatesServiceClient"/> instances.</summary>
    public sealed partial class TemplatesServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="TemplatesServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="TemplatesServiceSettings"/>.</returns>
        public static TemplatesServiceSettings GetDefault() => new TemplatesServiceSettings();

        /// <summary>Constructs a new <see cref="TemplatesServiceSettings"/> object with default settings.</summary>
        public TemplatesServiceSettings()
        {
        }

        private TemplatesServiceSettings(TemplatesServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateJobFromTemplateSettings = existing.CreateJobFromTemplateSettings;
            LaunchTemplateSettings = existing.LaunchTemplateSettings;
            GetTemplateSettings = existing.GetTemplateSettings;
            OnCopy(existing);
        }

        partial void OnCopy(TemplatesServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TemplatesServiceClient.CreateJobFromTemplate</c> and <c>TemplatesServiceClient.CreateJobFromTemplateAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateJobFromTemplateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TemplatesServiceClient.LaunchTemplate</c> and <c>TemplatesServiceClient.LaunchTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings LaunchTemplateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TemplatesServiceClient.GetTemplate</c> and <c>TemplatesServiceClient.GetTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetTemplateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="TemplatesServiceSettings"/> object.</returns>
        public TemplatesServiceSettings Clone() => new TemplatesServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="TemplatesServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class TemplatesServiceClientBuilder : gaxgrpc::ClientBuilderBase<TemplatesServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public TemplatesServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public TemplatesServiceClientBuilder()
        {
            UseJwtAccessWithScopes = TemplatesServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref TemplatesServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<TemplatesServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override TemplatesServiceClient Build()
        {
            TemplatesServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<TemplatesServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<TemplatesServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private TemplatesServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return TemplatesServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<TemplatesServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return TemplatesServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => TemplatesServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => TemplatesServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => TemplatesServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>TemplatesService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides a method to create Cloud Dataflow jobs from templates.
    /// </remarks>
    public abstract partial class TemplatesServiceClient
    {
        /// <summary>
        /// The default endpoint for the TemplatesService service, which is a host of "dataflow.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dataflow.googleapis.com:443";

        /// <summary>The default TemplatesService scopes.</summary>
        /// <remarks>
        /// The default TemplatesService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/compute</description></item>
        /// <item><description>https://www.googleapis.com/auth/compute.readonly</description></item>
        /// <item><description>https://www.googleapis.com/auth/userinfo.email</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/compute",
            "https://www.googleapis.com/auth/compute.readonly",
            "https://www.googleapis.com/auth/userinfo.email",
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
        /// Asynchronously creates a <see cref="TemplatesServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="TemplatesServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="TemplatesServiceClient"/>.</returns>
        public static stt::Task<TemplatesServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new TemplatesServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="TemplatesServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="TemplatesServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="TemplatesServiceClient"/>.</returns>
        public static TemplatesServiceClient Create() => new TemplatesServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="TemplatesServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="TemplatesServiceSettings"/>.</param>
        /// <returns>The created <see cref="TemplatesServiceClient"/>.</returns>
        internal static TemplatesServiceClient Create(grpccore::CallInvoker callInvoker, TemplatesServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            TemplatesService.TemplatesServiceClient grpcClient = new TemplatesService.TemplatesServiceClient(callInvoker);
            return new TemplatesServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC TemplatesService client</summary>
        public virtual TemplatesService.TemplatesServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Cloud Dataflow job from a template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Job CreateJobFromTemplate(CreateJobFromTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Cloud Dataflow job from a template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> CreateJobFromTemplateAsync(CreateJobFromTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Cloud Dataflow job from a template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Job> CreateJobFromTemplateAsync(CreateJobFromTemplateRequest request, st::CancellationToken cancellationToken) =>
            CreateJobFromTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Launch a template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LaunchTemplateResponse LaunchTemplate(LaunchTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Launch a template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LaunchTemplateResponse> LaunchTemplateAsync(LaunchTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Launch a template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LaunchTemplateResponse> LaunchTemplateAsync(LaunchTemplateRequest request, st::CancellationToken cancellationToken) =>
            LaunchTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get the template associated with a template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GetTemplateResponse GetTemplate(GetTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get the template associated with a template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GetTemplateResponse> GetTemplateAsync(GetTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get the template associated with a template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GetTemplateResponse> GetTemplateAsync(GetTemplateRequest request, st::CancellationToken cancellationToken) =>
            GetTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>TemplatesService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides a method to create Cloud Dataflow jobs from templates.
    /// </remarks>
    public sealed partial class TemplatesServiceClientImpl : TemplatesServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateJobFromTemplateRequest, Job> _callCreateJobFromTemplate;

        private readonly gaxgrpc::ApiCall<LaunchTemplateRequest, LaunchTemplateResponse> _callLaunchTemplate;

        private readonly gaxgrpc::ApiCall<GetTemplateRequest, GetTemplateResponse> _callGetTemplate;

        /// <summary>
        /// Constructs a client wrapper for the TemplatesService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="TemplatesServiceSettings"/> used within this client.</param>
        public TemplatesServiceClientImpl(TemplatesService.TemplatesServiceClient grpcClient, TemplatesServiceSettings settings)
        {
            GrpcClient = grpcClient;
            TemplatesServiceSettings effectiveSettings = settings ?? TemplatesServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callCreateJobFromTemplate = clientHelper.BuildApiCall<CreateJobFromTemplateRequest, Job>(grpcClient.CreateJobFromTemplateAsync, grpcClient.CreateJobFromTemplate, effectiveSettings.CreateJobFromTemplateSettings);
            Modify_ApiCall(ref _callCreateJobFromTemplate);
            Modify_CreateJobFromTemplateApiCall(ref _callCreateJobFromTemplate);
            _callLaunchTemplate = clientHelper.BuildApiCall<LaunchTemplateRequest, LaunchTemplateResponse>(grpcClient.LaunchTemplateAsync, grpcClient.LaunchTemplate, effectiveSettings.LaunchTemplateSettings);
            Modify_ApiCall(ref _callLaunchTemplate);
            Modify_LaunchTemplateApiCall(ref _callLaunchTemplate);
            _callGetTemplate = clientHelper.BuildApiCall<GetTemplateRequest, GetTemplateResponse>(grpcClient.GetTemplateAsync, grpcClient.GetTemplate, effectiveSettings.GetTemplateSettings);
            Modify_ApiCall(ref _callGetTemplate);
            Modify_GetTemplateApiCall(ref _callGetTemplate);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateJobFromTemplateApiCall(ref gaxgrpc::ApiCall<CreateJobFromTemplateRequest, Job> call);

        partial void Modify_LaunchTemplateApiCall(ref gaxgrpc::ApiCall<LaunchTemplateRequest, LaunchTemplateResponse> call);

        partial void Modify_GetTemplateApiCall(ref gaxgrpc::ApiCall<GetTemplateRequest, GetTemplateResponse> call);

        partial void OnConstruction(TemplatesService.TemplatesServiceClient grpcClient, TemplatesServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC TemplatesService client</summary>
        public override TemplatesService.TemplatesServiceClient GrpcClient { get; }

        partial void Modify_CreateJobFromTemplateRequest(ref CreateJobFromTemplateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_LaunchTemplateRequest(ref LaunchTemplateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetTemplateRequest(ref GetTemplateRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a Cloud Dataflow job from a template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Job CreateJobFromTemplate(CreateJobFromTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateJobFromTemplateRequest(ref request, ref callSettings);
            return _callCreateJobFromTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a Cloud Dataflow job from a template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Job> CreateJobFromTemplateAsync(CreateJobFromTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateJobFromTemplateRequest(ref request, ref callSettings);
            return _callCreateJobFromTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Launch a template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LaunchTemplateResponse LaunchTemplate(LaunchTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LaunchTemplateRequest(ref request, ref callSettings);
            return _callLaunchTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Launch a template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LaunchTemplateResponse> LaunchTemplateAsync(LaunchTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LaunchTemplateRequest(ref request, ref callSettings);
            return _callLaunchTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Get the template associated with a template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GetTemplateResponse GetTemplate(GetTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTemplateRequest(ref request, ref callSettings);
            return _callGetTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Get the template associated with a template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GetTemplateResponse> GetTemplateAsync(GetTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTemplateRequest(ref request, ref callSettings);
            return _callGetTemplate.Async(request, callSettings);
        }
    }
}
