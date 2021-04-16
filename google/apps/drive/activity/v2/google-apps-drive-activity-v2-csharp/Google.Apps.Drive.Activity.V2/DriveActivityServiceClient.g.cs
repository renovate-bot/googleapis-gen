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
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Apps.Drive.Activity.V2
{
    /// <summary>Settings for <see cref="DriveActivityServiceClient"/> instances.</summary>
    public sealed partial class DriveActivityServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DriveActivityServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DriveActivityServiceSettings"/>.</returns>
        public static DriveActivityServiceSettings GetDefault() => new DriveActivityServiceSettings();

        /// <summary>Constructs a new <see cref="DriveActivityServiceSettings"/> object with default settings.</summary>
        public DriveActivityServiceSettings()
        {
        }

        private DriveActivityServiceSettings(DriveActivityServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            QueryDriveActivitySettings = existing.QueryDriveActivitySettings;
            OnCopy(existing);
        }

        partial void OnCopy(DriveActivityServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DriveActivityServiceClient.QueryDriveActivity</c> and
        /// <c>DriveActivityServiceClient.QueryDriveActivityAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings QueryDriveActivitySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DriveActivityServiceSettings"/> object.</returns>
        public DriveActivityServiceSettings Clone() => new DriveActivityServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DriveActivityServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class DriveActivityServiceClientBuilder : gaxgrpc::ClientBuilderBase<DriveActivityServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DriveActivityServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref DriveActivityServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DriveActivityServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DriveActivityServiceClient Build()
        {
            DriveActivityServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DriveActivityServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DriveActivityServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DriveActivityServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DriveActivityServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<DriveActivityServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DriveActivityServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => DriveActivityServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => DriveActivityServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DriveActivityServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>DriveActivityService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for querying activity on Drive items. Activity is user
    /// or system action on Drive items that happened in the past. A Drive item can
    /// be a file or folder, or a Team Drive.
    /// </remarks>
    public abstract partial class DriveActivityServiceClient
    {
        /// <summary>
        /// The default endpoint for the DriveActivityService service, which is a host of "driveactivity.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "driveactivity.googleapis.com:443";

        /// <summary>The default DriveActivityService scopes.</summary>
        /// <remarks>
        /// The default DriveActivityService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/drive.activity</description></item>
        /// <item><description>https://www.googleapis.com/auth/drive.activity.readonly</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/drive.activity",
            "https://www.googleapis.com/auth/drive.activity.readonly",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="DriveActivityServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="DriveActivityServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DriveActivityServiceClient"/>.</returns>
        public static stt::Task<DriveActivityServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DriveActivityServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DriveActivityServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="DriveActivityServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DriveActivityServiceClient"/>.</returns>
        public static DriveActivityServiceClient Create() => new DriveActivityServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DriveActivityServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DriveActivityServiceSettings"/>.</param>
        /// <returns>The created <see cref="DriveActivityServiceClient"/>.</returns>
        internal static DriveActivityServiceClient Create(grpccore::CallInvoker callInvoker, DriveActivityServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DriveActivityService.DriveActivityServiceClient grpcClient = new DriveActivityService.DriveActivityServiceClient(callInvoker);
            return new DriveActivityServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC DriveActivityService client</summary>
        public virtual DriveActivityService.DriveActivityServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Query past activity in Google Drive.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DriveActivity"/> resources.</returns>
        public virtual gax::PagedEnumerable<QueryDriveActivityResponse, DriveActivity> QueryDriveActivity(QueryDriveActivityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Query past activity in Google Drive.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DriveActivity"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<QueryDriveActivityResponse, DriveActivity> QueryDriveActivityAsync(QueryDriveActivityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();
    }

    /// <summary>DriveActivityService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for querying activity on Drive items. Activity is user
    /// or system action on Drive items that happened in the past. A Drive item can
    /// be a file or folder, or a Team Drive.
    /// </remarks>
    public sealed partial class DriveActivityServiceClientImpl : DriveActivityServiceClient
    {
        private readonly gaxgrpc::ApiCall<QueryDriveActivityRequest, QueryDriveActivityResponse> _callQueryDriveActivity;

        /// <summary>
        /// Constructs a client wrapper for the DriveActivityService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DriveActivityServiceSettings"/> used within this client.</param>
        public DriveActivityServiceClientImpl(DriveActivityService.DriveActivityServiceClient grpcClient, DriveActivityServiceSettings settings)
        {
            GrpcClient = grpcClient;
            DriveActivityServiceSettings effectiveSettings = settings ?? DriveActivityServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callQueryDriveActivity = clientHelper.BuildApiCall<QueryDriveActivityRequest, QueryDriveActivityResponse>(grpcClient.QueryDriveActivityAsync, grpcClient.QueryDriveActivity, effectiveSettings.QueryDriveActivitySettings);
            Modify_ApiCall(ref _callQueryDriveActivity);
            Modify_QueryDriveActivityApiCall(ref _callQueryDriveActivity);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_QueryDriveActivityApiCall(ref gaxgrpc::ApiCall<QueryDriveActivityRequest, QueryDriveActivityResponse> call);

        partial void OnConstruction(DriveActivityService.DriveActivityServiceClient grpcClient, DriveActivityServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DriveActivityService client</summary>
        public override DriveActivityService.DriveActivityServiceClient GrpcClient { get; }

        partial void Modify_QueryDriveActivityRequest(ref QueryDriveActivityRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Query past activity in Google Drive.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DriveActivity"/> resources.</returns>
        public override gax::PagedEnumerable<QueryDriveActivityResponse, DriveActivity> QueryDriveActivity(QueryDriveActivityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryDriveActivityRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<QueryDriveActivityRequest, QueryDriveActivityResponse, DriveActivity>(_callQueryDriveActivity, request, callSettings);
        }

        /// <summary>
        /// Query past activity in Google Drive.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DriveActivity"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<QueryDriveActivityResponse, DriveActivity> QueryDriveActivityAsync(QueryDriveActivityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryDriveActivityRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<QueryDriveActivityRequest, QueryDriveActivityResponse, DriveActivity>(_callQueryDriveActivity, request, callSettings);
        }
    }

    public partial class QueryDriveActivityRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class QueryDriveActivityResponse : gaxgrpc::IPageResponse<DriveActivity>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DriveActivity> GetEnumerator() => Activities.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
