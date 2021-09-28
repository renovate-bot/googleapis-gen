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

namespace Google.Cloud.Gaming.Allocationendpoint.V1Alpha
{
    /// <summary>Settings for <see cref="AllocationEndpointServiceClient"/> instances.</summary>
    public sealed partial class AllocationEndpointServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AllocationEndpointServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AllocationEndpointServiceSettings"/>.</returns>
        public static AllocationEndpointServiceSettings GetDefault() => new AllocationEndpointServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="AllocationEndpointServiceSettings"/> object with default settings.
        /// </summary>
        public AllocationEndpointServiceSettings()
        {
        }

        private AllocationEndpointServiceSettings(AllocationEndpointServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            AllocateSettings = existing.AllocateSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AllocationEndpointServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AllocationEndpointServiceClient.Allocate</c> and <c>AllocationEndpointServiceClient.AllocateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AllocateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AllocationEndpointServiceSettings"/> object.</returns>
        public AllocationEndpointServiceSettings Clone() => new AllocationEndpointServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AllocationEndpointServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class AllocationEndpointServiceClientBuilder : gaxgrpc::ClientBuilderBase<AllocationEndpointServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AllocationEndpointServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AllocationEndpointServiceClientBuilder()
        {
            UseJwtAccessWithScopes = AllocationEndpointServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref AllocationEndpointServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AllocationEndpointServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AllocationEndpointServiceClient Build()
        {
            AllocationEndpointServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AllocationEndpointServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AllocationEndpointServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AllocationEndpointServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AllocationEndpointServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<AllocationEndpointServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AllocationEndpointServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => AllocationEndpointServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => AllocationEndpointServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AllocationEndpointServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>AllocationEndpointService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// </remarks>
    public abstract partial class AllocationEndpointServiceClient
    {
        /// <summary>
        /// The default endpoint for the AllocationEndpointService service, which is a host of "example.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "example.com:443";

        /// <summary>The default AllocationEndpointService scopes.</summary>
        /// <remarks>The default AllocationEndpointService scopes are:<list type="bullet"></list></remarks>
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
        /// Asynchronously creates a <see cref="AllocationEndpointServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="AllocationEndpointServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AllocationEndpointServiceClient"/>.</returns>
        public static stt::Task<AllocationEndpointServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AllocationEndpointServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AllocationEndpointServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="AllocationEndpointServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AllocationEndpointServiceClient"/>.</returns>
        public static AllocationEndpointServiceClient Create() => new AllocationEndpointServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AllocationEndpointServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AllocationEndpointServiceSettings"/>.</param>
        /// <returns>The created <see cref="AllocationEndpointServiceClient"/>.</returns>
        internal static AllocationEndpointServiceClient Create(grpccore::CallInvoker callInvoker, AllocationEndpointServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AllocationEndpointService.AllocationEndpointServiceClient grpcClient = new AllocationEndpointService.AllocationEndpointServiceClient(callInvoker);
            return new AllocationEndpointServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC AllocationEndpointService client</summary>
        public virtual AllocationEndpointService.AllocationEndpointServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Proxy allocation service to the Game Server Clusters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AllocationResponse Allocate(AllocationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Proxy allocation service to the Game Server Clusters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AllocationResponse> AllocateAsync(AllocationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Proxy allocation service to the Game Server Clusters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AllocationResponse> AllocateAsync(AllocationRequest request, st::CancellationToken cancellationToken) =>
            AllocateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AllocationEndpointService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// </remarks>
    public sealed partial class AllocationEndpointServiceClientImpl : AllocationEndpointServiceClient
    {
        private readonly gaxgrpc::ApiCall<AllocationRequest, AllocationResponse> _callAllocate;

        /// <summary>
        /// Constructs a client wrapper for the AllocationEndpointService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="AllocationEndpointServiceSettings"/> used within this client.
        /// </param>
        public AllocationEndpointServiceClientImpl(AllocationEndpointService.AllocationEndpointServiceClient grpcClient, AllocationEndpointServiceSettings settings)
        {
            GrpcClient = grpcClient;
            AllocationEndpointServiceSettings effectiveSettings = settings ?? AllocationEndpointServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callAllocate = clientHelper.BuildApiCall<AllocationRequest, AllocationResponse>(grpcClient.AllocateAsync, grpcClient.Allocate, effectiveSettings.AllocateSettings);
            Modify_ApiCall(ref _callAllocate);
            Modify_AllocateApiCall(ref _callAllocate);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_AllocateApiCall(ref gaxgrpc::ApiCall<AllocationRequest, AllocationResponse> call);

        partial void OnConstruction(AllocationEndpointService.AllocationEndpointServiceClient grpcClient, AllocationEndpointServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AllocationEndpointService client</summary>
        public override AllocationEndpointService.AllocationEndpointServiceClient GrpcClient { get; }

        partial void Modify_AllocationRequest(ref AllocationRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Proxy allocation service to the Game Server Clusters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AllocationResponse Allocate(AllocationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AllocationRequest(ref request, ref callSettings);
            return _callAllocate.Sync(request, callSettings);
        }

        /// <summary>
        /// Proxy allocation service to the Game Server Clusters.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AllocationResponse> AllocateAsync(AllocationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AllocationRequest(ref request, ref callSettings);
            return _callAllocate.Async(request, callSettings);
        }
    }
}
