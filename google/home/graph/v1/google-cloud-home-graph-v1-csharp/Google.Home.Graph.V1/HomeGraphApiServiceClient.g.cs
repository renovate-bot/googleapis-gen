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
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Home.Graph.V1
{
    /// <summary>Settings for <see cref="HomeGraphApiServiceClient"/> instances.</summary>
    public sealed partial class HomeGraphApiServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="HomeGraphApiServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="HomeGraphApiServiceSettings"/>.</returns>
        public static HomeGraphApiServiceSettings GetDefault() => new HomeGraphApiServiceSettings();

        /// <summary>Constructs a new <see cref="HomeGraphApiServiceSettings"/> object with default settings.</summary>
        public HomeGraphApiServiceSettings()
        {
        }

        private HomeGraphApiServiceSettings(HomeGraphApiServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            RequestSyncDevicesSettings = existing.RequestSyncDevicesSettings;
            ReportStateAndNotificationSettings = existing.ReportStateAndNotificationSettings;
            DeleteAgentUserSettings = existing.DeleteAgentUserSettings;
            QuerySettings = existing.QuerySettings;
            SyncSettings = existing.SyncSettings;
            OnCopy(existing);
        }

        partial void OnCopy(HomeGraphApiServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>HomeGraphApiServiceClient.RequestSyncDevices</c> and <c>HomeGraphApiServiceClient.RequestSyncDevicesAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RequestSyncDevicesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>HomeGraphApiServiceClient.ReportStateAndNotification</c> and
        /// <c>HomeGraphApiServiceClient.ReportStateAndNotificationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ReportStateAndNotificationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>HomeGraphApiServiceClient.DeleteAgentUser</c> and <c>HomeGraphApiServiceClient.DeleteAgentUserAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteAgentUserSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>HomeGraphApiServiceClient.Query</c> and <c>HomeGraphApiServiceClient.QueryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings QuerySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>HomeGraphApiServiceClient.Sync</c> and <c>HomeGraphApiServiceClient.SyncAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 10 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SyncSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(10000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="HomeGraphApiServiceSettings"/> object.</returns>
        public HomeGraphApiServiceSettings Clone() => new HomeGraphApiServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="HomeGraphApiServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class HomeGraphApiServiceClientBuilder : gaxgrpc::ClientBuilderBase<HomeGraphApiServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public HomeGraphApiServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref HomeGraphApiServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<HomeGraphApiServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override HomeGraphApiServiceClient Build()
        {
            HomeGraphApiServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<HomeGraphApiServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<HomeGraphApiServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private HomeGraphApiServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return HomeGraphApiServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<HomeGraphApiServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return HomeGraphApiServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => HomeGraphApiServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => HomeGraphApiServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => HomeGraphApiServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>HomeGraphApiService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Google Home Graph API service. The Home Graph service provides support for
    /// accessing first-party and third-party devices stored in Google's Home Graph.
    /// The Home Graph database provides contextual data about the relationships
    /// between devices and the home.
    /// 
    /// For more details, see the [Home Graph developer
    /// guide](https://developers.google.com/assistant/smarthome/concepts/homegraph).
    /// </remarks>
    public abstract partial class HomeGraphApiServiceClient
    {
        /// <summary>
        /// The default endpoint for the HomeGraphApiService service, which is a host of "homegraph.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "homegraph.googleapis.com:443";

        /// <summary>The default HomeGraphApiService scopes.</summary>
        /// <remarks>The default HomeGraphApiService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="HomeGraphApiServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="HomeGraphApiServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="HomeGraphApiServiceClient"/>.</returns>
        public static stt::Task<HomeGraphApiServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new HomeGraphApiServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="HomeGraphApiServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="HomeGraphApiServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="HomeGraphApiServiceClient"/>.</returns>
        public static HomeGraphApiServiceClient Create() => new HomeGraphApiServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="HomeGraphApiServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="HomeGraphApiServiceSettings"/>.</param>
        /// <returns>The created <see cref="HomeGraphApiServiceClient"/>.</returns>
        internal static HomeGraphApiServiceClient Create(grpccore::CallInvoker callInvoker, HomeGraphApiServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            HomeGraphApiService.HomeGraphApiServiceClient grpcClient = new HomeGraphApiService.HomeGraphApiServiceClient(callInvoker);
            return new HomeGraphApiServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC HomeGraphApiService client</summary>
        public virtual HomeGraphApiService.HomeGraphApiServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Requests Google to send an `action.devices.SYNC`
        /// [intent](https://developers.google.com/assistant/smarthome/reference/intent/sync)
        /// to your smart home Action to update device metadata for the given user.
        /// 
        /// 
        /// The third-party user's identity is passed via the `agent_user_id`
        /// (see
        /// [RequestSyncDevicesRequest][google.home.graph.v1.RequestSyncDevicesRequest]).
        /// This request must be authorized using service account credentials from your
        /// Actions console project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RequestSyncDevicesResponse RequestSyncDevices(RequestSyncDevicesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Requests Google to send an `action.devices.SYNC`
        /// [intent](https://developers.google.com/assistant/smarthome/reference/intent/sync)
        /// to your smart home Action to update device metadata for the given user.
        /// 
        /// 
        /// The third-party user's identity is passed via the `agent_user_id`
        /// (see
        /// [RequestSyncDevicesRequest][google.home.graph.v1.RequestSyncDevicesRequest]).
        /// This request must be authorized using service account credentials from your
        /// Actions console project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RequestSyncDevicesResponse> RequestSyncDevicesAsync(RequestSyncDevicesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Requests Google to send an `action.devices.SYNC`
        /// [intent](https://developers.google.com/assistant/smarthome/reference/intent/sync)
        /// to your smart home Action to update device metadata for the given user.
        /// 
        /// 
        /// The third-party user's identity is passed via the `agent_user_id`
        /// (see
        /// [RequestSyncDevicesRequest][google.home.graph.v1.RequestSyncDevicesRequest]).
        /// This request must be authorized using service account credentials from your
        /// Actions console project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RequestSyncDevicesResponse> RequestSyncDevicesAsync(RequestSyncDevicesRequest request, st::CancellationToken cancellationToken) =>
            RequestSyncDevicesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Requests Google to send an `action.devices.SYNC`
        /// [intent](https://developers.google.com/assistant/smarthome/reference/intent/sync)
        /// to your smart home Action to update device metadata for the given user.
        /// 
        /// 
        /// The third-party user's identity is passed via the `agent_user_id`
        /// (see
        /// [RequestSyncDevicesRequest][google.home.graph.v1.RequestSyncDevicesRequest]).
        /// This request must be authorized using service account credentials from your
        /// Actions console project.
        /// </summary>
        /// <param name="agentUserId">
        /// Required. Third-party user ID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RequestSyncDevicesResponse RequestSyncDevices(string agentUserId, gaxgrpc::CallSettings callSettings = null) =>
            RequestSyncDevices(new RequestSyncDevicesRequest
            {
                AgentUserId = gax::GaxPreconditions.CheckNotNullOrEmpty(agentUserId, nameof(agentUserId)),
            }, callSettings);

        /// <summary>
        /// Requests Google to send an `action.devices.SYNC`
        /// [intent](https://developers.google.com/assistant/smarthome/reference/intent/sync)
        /// to your smart home Action to update device metadata for the given user.
        /// 
        /// 
        /// The third-party user's identity is passed via the `agent_user_id`
        /// (see
        /// [RequestSyncDevicesRequest][google.home.graph.v1.RequestSyncDevicesRequest]).
        /// This request must be authorized using service account credentials from your
        /// Actions console project.
        /// </summary>
        /// <param name="agentUserId">
        /// Required. Third-party user ID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RequestSyncDevicesResponse> RequestSyncDevicesAsync(string agentUserId, gaxgrpc::CallSettings callSettings = null) =>
            RequestSyncDevicesAsync(new RequestSyncDevicesRequest
            {
                AgentUserId = gax::GaxPreconditions.CheckNotNullOrEmpty(agentUserId, nameof(agentUserId)),
            }, callSettings);

        /// <summary>
        /// Requests Google to send an `action.devices.SYNC`
        /// [intent](https://developers.google.com/assistant/smarthome/reference/intent/sync)
        /// to your smart home Action to update device metadata for the given user.
        /// 
        /// 
        /// The third-party user's identity is passed via the `agent_user_id`
        /// (see
        /// [RequestSyncDevicesRequest][google.home.graph.v1.RequestSyncDevicesRequest]).
        /// This request must be authorized using service account credentials from your
        /// Actions console project.
        /// </summary>
        /// <param name="agentUserId">
        /// Required. Third-party user ID.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RequestSyncDevicesResponse> RequestSyncDevicesAsync(string agentUserId, st::CancellationToken cancellationToken) =>
            RequestSyncDevicesAsync(agentUserId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Reports device state and optionally sends device notifications.
        /// Called by your smart home Action when the state of a third-party device
        /// changes or you need to send a notification about the device.
        /// See [Implement Report
        /// State](https://developers.google.com/assistant/smarthome/develop/report-state)
        /// for more information.
        /// 
        /// This method updates the device state according to its declared
        /// [traits](https://developers.google.com/assistant/smarthome/concepts/devices-traits).
        /// Publishing a new state value outside of these traits will result in an
        /// `INVALID_ARGUMENT` error response.
        /// 
        /// The third-party user's identity is passed in via the `agent_user_id`
        /// (see
        /// [ReportStateAndNotificationRequest][google.home.graph.v1.ReportStateAndNotificationRequest]).
        /// This request must be authorized using service account credentials from your
        /// Actions console project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReportStateAndNotificationResponse ReportStateAndNotification(ReportStateAndNotificationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reports device state and optionally sends device notifications.
        /// Called by your smart home Action when the state of a third-party device
        /// changes or you need to send a notification about the device.
        /// See [Implement Report
        /// State](https://developers.google.com/assistant/smarthome/develop/report-state)
        /// for more information.
        /// 
        /// This method updates the device state according to its declared
        /// [traits](https://developers.google.com/assistant/smarthome/concepts/devices-traits).
        /// Publishing a new state value outside of these traits will result in an
        /// `INVALID_ARGUMENT` error response.
        /// 
        /// The third-party user's identity is passed in via the `agent_user_id`
        /// (see
        /// [ReportStateAndNotificationRequest][google.home.graph.v1.ReportStateAndNotificationRequest]).
        /// This request must be authorized using service account credentials from your
        /// Actions console project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportStateAndNotificationResponse> ReportStateAndNotificationAsync(ReportStateAndNotificationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reports device state and optionally sends device notifications.
        /// Called by your smart home Action when the state of a third-party device
        /// changes or you need to send a notification about the device.
        /// See [Implement Report
        /// State](https://developers.google.com/assistant/smarthome/develop/report-state)
        /// for more information.
        /// 
        /// This method updates the device state according to its declared
        /// [traits](https://developers.google.com/assistant/smarthome/concepts/devices-traits).
        /// Publishing a new state value outside of these traits will result in an
        /// `INVALID_ARGUMENT` error response.
        /// 
        /// The third-party user's identity is passed in via the `agent_user_id`
        /// (see
        /// [ReportStateAndNotificationRequest][google.home.graph.v1.ReportStateAndNotificationRequest]).
        /// This request must be authorized using service account credentials from your
        /// Actions console project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportStateAndNotificationResponse> ReportStateAndNotificationAsync(ReportStateAndNotificationRequest request, st::CancellationToken cancellationToken) =>
            ReportStateAndNotificationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Reports device state and optionally sends device notifications.
        /// Called by your smart home Action when the state of a third-party device
        /// changes or you need to send a notification about the device.
        /// See [Implement Report
        /// State](https://developers.google.com/assistant/smarthome/develop/report-state)
        /// for more information.
        /// 
        /// This method updates the device state according to its declared
        /// [traits](https://developers.google.com/assistant/smarthome/concepts/devices-traits).
        /// Publishing a new state value outside of these traits will result in an
        /// `INVALID_ARGUMENT` error response.
        /// 
        /// The third-party user's identity is passed in via the `agent_user_id`
        /// (see
        /// [ReportStateAndNotificationRequest][google.home.graph.v1.ReportStateAndNotificationRequest]).
        /// This request must be authorized using service account credentials from your
        /// Actions console project.
        /// </summary>
        /// <param name="requestId">
        /// Request ID used for debugging.
        /// </param>
        /// <param name="eventId">
        /// Unique identifier per event (for example, a doorbell press).
        /// </param>
        /// <param name="agentUserId">
        /// Required. Third-party user ID.
        /// </param>
        /// <param name="payload">
        /// Required. State of devices to update and notification metadata for devices.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReportStateAndNotificationResponse ReportStateAndNotification(string requestId, string eventId, string agentUserId, StateAndNotificationPayload payload, gaxgrpc::CallSettings callSettings = null) =>
            ReportStateAndNotification(new ReportStateAndNotificationRequest
            {
                RequestId = requestId ?? "",
                EventId = eventId ?? "",
                AgentUserId = gax::GaxPreconditions.CheckNotNullOrEmpty(agentUserId, nameof(agentUserId)),
                Payload = gax::GaxPreconditions.CheckNotNull(payload, nameof(payload)),
            }, callSettings);

        /// <summary>
        /// Reports device state and optionally sends device notifications.
        /// Called by your smart home Action when the state of a third-party device
        /// changes or you need to send a notification about the device.
        /// See [Implement Report
        /// State](https://developers.google.com/assistant/smarthome/develop/report-state)
        /// for more information.
        /// 
        /// This method updates the device state according to its declared
        /// [traits](https://developers.google.com/assistant/smarthome/concepts/devices-traits).
        /// Publishing a new state value outside of these traits will result in an
        /// `INVALID_ARGUMENT` error response.
        /// 
        /// The third-party user's identity is passed in via the `agent_user_id`
        /// (see
        /// [ReportStateAndNotificationRequest][google.home.graph.v1.ReportStateAndNotificationRequest]).
        /// This request must be authorized using service account credentials from your
        /// Actions console project.
        /// </summary>
        /// <param name="requestId">
        /// Request ID used for debugging.
        /// </param>
        /// <param name="eventId">
        /// Unique identifier per event (for example, a doorbell press).
        /// </param>
        /// <param name="agentUserId">
        /// Required. Third-party user ID.
        /// </param>
        /// <param name="payload">
        /// Required. State of devices to update and notification metadata for devices.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportStateAndNotificationResponse> ReportStateAndNotificationAsync(string requestId, string eventId, string agentUserId, StateAndNotificationPayload payload, gaxgrpc::CallSettings callSettings = null) =>
            ReportStateAndNotificationAsync(new ReportStateAndNotificationRequest
            {
                RequestId = requestId ?? "",
                EventId = eventId ?? "",
                AgentUserId = gax::GaxPreconditions.CheckNotNullOrEmpty(agentUserId, nameof(agentUserId)),
                Payload = gax::GaxPreconditions.CheckNotNull(payload, nameof(payload)),
            }, callSettings);

        /// <summary>
        /// Reports device state and optionally sends device notifications.
        /// Called by your smart home Action when the state of a third-party device
        /// changes or you need to send a notification about the device.
        /// See [Implement Report
        /// State](https://developers.google.com/assistant/smarthome/develop/report-state)
        /// for more information.
        /// 
        /// This method updates the device state according to its declared
        /// [traits](https://developers.google.com/assistant/smarthome/concepts/devices-traits).
        /// Publishing a new state value outside of these traits will result in an
        /// `INVALID_ARGUMENT` error response.
        /// 
        /// The third-party user's identity is passed in via the `agent_user_id`
        /// (see
        /// [ReportStateAndNotificationRequest][google.home.graph.v1.ReportStateAndNotificationRequest]).
        /// This request must be authorized using service account credentials from your
        /// Actions console project.
        /// </summary>
        /// <param name="requestId">
        /// Request ID used for debugging.
        /// </param>
        /// <param name="eventId">
        /// Unique identifier per event (for example, a doorbell press).
        /// </param>
        /// <param name="agentUserId">
        /// Required. Third-party user ID.
        /// </param>
        /// <param name="payload">
        /// Required. State of devices to update and notification metadata for devices.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportStateAndNotificationResponse> ReportStateAndNotificationAsync(string requestId, string eventId, string agentUserId, StateAndNotificationPayload payload, st::CancellationToken cancellationToken) =>
            ReportStateAndNotificationAsync(requestId, eventId, agentUserId, payload, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Unlinks the given third-party user from your smart home Action.
        /// All data related to this user will be deleted.
        /// 
        /// For more details on how users link their accounts, see
        /// [fulfillment and
        /// authentication](https://developers.google.com/assistant/smarthome/concepts/fulfillment-authentication).
        /// 
        /// The third-party user's identity is passed in via the `agent_user_id`
        /// (see
        /// [DeleteAgentUserRequest][google.home.graph.v1.DeleteAgentUserRequest]).
        /// This request must be authorized using service account credentials from your
        /// Actions console project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAgentUser(DeleteAgentUserRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Unlinks the given third-party user from your smart home Action.
        /// All data related to this user will be deleted.
        /// 
        /// For more details on how users link their accounts, see
        /// [fulfillment and
        /// authentication](https://developers.google.com/assistant/smarthome/concepts/fulfillment-authentication).
        /// 
        /// The third-party user's identity is passed in via the `agent_user_id`
        /// (see
        /// [DeleteAgentUserRequest][google.home.graph.v1.DeleteAgentUserRequest]).
        /// This request must be authorized using service account credentials from your
        /// Actions console project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAgentUserAsync(DeleteAgentUserRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Unlinks the given third-party user from your smart home Action.
        /// All data related to this user will be deleted.
        /// 
        /// For more details on how users link their accounts, see
        /// [fulfillment and
        /// authentication](https://developers.google.com/assistant/smarthome/concepts/fulfillment-authentication).
        /// 
        /// The third-party user's identity is passed in via the `agent_user_id`
        /// (see
        /// [DeleteAgentUserRequest][google.home.graph.v1.DeleteAgentUserRequest]).
        /// This request must be authorized using service account credentials from your
        /// Actions console project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAgentUserAsync(DeleteAgentUserRequest request, st::CancellationToken cancellationToken) =>
            DeleteAgentUserAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Unlinks the given third-party user from your smart home Action.
        /// All data related to this user will be deleted.
        /// 
        /// For more details on how users link their accounts, see
        /// [fulfillment and
        /// authentication](https://developers.google.com/assistant/smarthome/concepts/fulfillment-authentication).
        /// 
        /// The third-party user's identity is passed in via the `agent_user_id`
        /// (see
        /// [DeleteAgentUserRequest][google.home.graph.v1.DeleteAgentUserRequest]).
        /// This request must be authorized using service account credentials from your
        /// Actions console project.
        /// </summary>
        /// <param name="requestId">
        /// Request ID used for debugging.
        /// </param>
        /// <param name="agentUserId">
        /// Required. Third-party user ID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAgentUser(string requestId, string agentUserId, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAgentUser(new DeleteAgentUserRequest
            {
                RequestId = requestId ?? "",
                AgentUserId = gax::GaxPreconditions.CheckNotNullOrEmpty(agentUserId, nameof(agentUserId)),
            }, callSettings);

        /// <summary>
        /// Unlinks the given third-party user from your smart home Action.
        /// All data related to this user will be deleted.
        /// 
        /// For more details on how users link their accounts, see
        /// [fulfillment and
        /// authentication](https://developers.google.com/assistant/smarthome/concepts/fulfillment-authentication).
        /// 
        /// The third-party user's identity is passed in via the `agent_user_id`
        /// (see
        /// [DeleteAgentUserRequest][google.home.graph.v1.DeleteAgentUserRequest]).
        /// This request must be authorized using service account credentials from your
        /// Actions console project.
        /// </summary>
        /// <param name="requestId">
        /// Request ID used for debugging.
        /// </param>
        /// <param name="agentUserId">
        /// Required. Third-party user ID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAgentUserAsync(string requestId, string agentUserId, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAgentUserAsync(new DeleteAgentUserRequest
            {
                RequestId = requestId ?? "",
                AgentUserId = gax::GaxPreconditions.CheckNotNullOrEmpty(agentUserId, nameof(agentUserId)),
            }, callSettings);

        /// <summary>
        /// Unlinks the given third-party user from your smart home Action.
        /// All data related to this user will be deleted.
        /// 
        /// For more details on how users link their accounts, see
        /// [fulfillment and
        /// authentication](https://developers.google.com/assistant/smarthome/concepts/fulfillment-authentication).
        /// 
        /// The third-party user's identity is passed in via the `agent_user_id`
        /// (see
        /// [DeleteAgentUserRequest][google.home.graph.v1.DeleteAgentUserRequest]).
        /// This request must be authorized using service account credentials from your
        /// Actions console project.
        /// </summary>
        /// <param name="requestId">
        /// Request ID used for debugging.
        /// </param>
        /// <param name="agentUserId">
        /// Required. Third-party user ID.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAgentUserAsync(string requestId, string agentUserId, st::CancellationToken cancellationToken) =>
            DeleteAgentUserAsync(requestId, agentUserId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Unlinks the given third-party user from your smart home Action.
        /// All data related to this user will be deleted.
        /// 
        /// For more details on how users link their accounts, see
        /// [fulfillment and
        /// authentication](https://developers.google.com/assistant/smarthome/concepts/fulfillment-authentication).
        /// 
        /// The third-party user's identity is passed in via the `agent_user_id`
        /// (see
        /// [DeleteAgentUserRequest][google.home.graph.v1.DeleteAgentUserRequest]).
        /// This request must be authorized using service account credentials from your
        /// Actions console project.
        /// </summary>
        /// <param name="requestId">
        /// Request ID used for debugging.
        /// </param>
        /// <param name="agentUserId">
        /// Required. Third-party user ID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAgentUser(string requestId, AgentUserPathName agentUserId, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAgentUser(new DeleteAgentUserRequest
            {
                RequestId = requestId ?? "",
                AgentUserIdAsAgentUserPathName = gax::GaxPreconditions.CheckNotNull(agentUserId, nameof(agentUserId)),
            }, callSettings);

        /// <summary>
        /// Unlinks the given third-party user from your smart home Action.
        /// All data related to this user will be deleted.
        /// 
        /// For more details on how users link their accounts, see
        /// [fulfillment and
        /// authentication](https://developers.google.com/assistant/smarthome/concepts/fulfillment-authentication).
        /// 
        /// The third-party user's identity is passed in via the `agent_user_id`
        /// (see
        /// [DeleteAgentUserRequest][google.home.graph.v1.DeleteAgentUserRequest]).
        /// This request must be authorized using service account credentials from your
        /// Actions console project.
        /// </summary>
        /// <param name="requestId">
        /// Request ID used for debugging.
        /// </param>
        /// <param name="agentUserId">
        /// Required. Third-party user ID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAgentUserAsync(string requestId, AgentUserPathName agentUserId, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAgentUserAsync(new DeleteAgentUserRequest
            {
                RequestId = requestId ?? "",
                AgentUserIdAsAgentUserPathName = gax::GaxPreconditions.CheckNotNull(agentUserId, nameof(agentUserId)),
            }, callSettings);

        /// <summary>
        /// Unlinks the given third-party user from your smart home Action.
        /// All data related to this user will be deleted.
        /// 
        /// For more details on how users link their accounts, see
        /// [fulfillment and
        /// authentication](https://developers.google.com/assistant/smarthome/concepts/fulfillment-authentication).
        /// 
        /// The third-party user's identity is passed in via the `agent_user_id`
        /// (see
        /// [DeleteAgentUserRequest][google.home.graph.v1.DeleteAgentUserRequest]).
        /// This request must be authorized using service account credentials from your
        /// Actions console project.
        /// </summary>
        /// <param name="requestId">
        /// Request ID used for debugging.
        /// </param>
        /// <param name="agentUserId">
        /// Required. Third-party user ID.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAgentUserAsync(string requestId, AgentUserPathName agentUserId, st::CancellationToken cancellationToken) =>
            DeleteAgentUserAsync(requestId, agentUserId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the current states in Home Graph for the given set of the third-party
        /// user's devices.
        /// 
        /// The third-party user's identity is passed in via the `agent_user_id`
        /// (see [QueryRequest][google.home.graph.v1.QueryRequest]).
        /// This request must be authorized using service account credentials from your
        /// Actions console project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QueryResponse Query(QueryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the current states in Home Graph for the given set of the third-party
        /// user's devices.
        /// 
        /// The third-party user's identity is passed in via the `agent_user_id`
        /// (see [QueryRequest][google.home.graph.v1.QueryRequest]).
        /// This request must be authorized using service account credentials from your
        /// Actions console project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QueryResponse> QueryAsync(QueryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the current states in Home Graph for the given set of the third-party
        /// user's devices.
        /// 
        /// The third-party user's identity is passed in via the `agent_user_id`
        /// (see [QueryRequest][google.home.graph.v1.QueryRequest]).
        /// This request must be authorized using service account credentials from your
        /// Actions console project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QueryResponse> QueryAsync(QueryRequest request, st::CancellationToken cancellationToken) =>
            QueryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the current states in Home Graph for the given set of the third-party
        /// user's devices.
        /// 
        /// The third-party user's identity is passed in via the `agent_user_id`
        /// (see [QueryRequest][google.home.graph.v1.QueryRequest]).
        /// This request must be authorized using service account credentials from your
        /// Actions console project.
        /// </summary>
        /// <param name="requestId">
        /// Request ID used for debugging.
        /// </param>
        /// <param name="agentUserId">
        /// Required. Third-party user ID.
        /// </param>
        /// <param name="inputs">
        /// Required. Inputs containing third-party device IDs for which to
        /// get the device states.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QueryResponse Query(string requestId, string agentUserId, scg::IEnumerable<QueryRequestInput> inputs, gaxgrpc::CallSettings callSettings = null) =>
            Query(new QueryRequest
            {
                RequestId = requestId ?? "",
                AgentUserId = gax::GaxPreconditions.CheckNotNullOrEmpty(agentUserId, nameof(agentUserId)),
                Inputs =
                {
                    gax::GaxPreconditions.CheckNotNull(inputs, nameof(inputs)),
                },
            }, callSettings);

        /// <summary>
        /// Gets the current states in Home Graph for the given set of the third-party
        /// user's devices.
        /// 
        /// The third-party user's identity is passed in via the `agent_user_id`
        /// (see [QueryRequest][google.home.graph.v1.QueryRequest]).
        /// This request must be authorized using service account credentials from your
        /// Actions console project.
        /// </summary>
        /// <param name="requestId">
        /// Request ID used for debugging.
        /// </param>
        /// <param name="agentUserId">
        /// Required. Third-party user ID.
        /// </param>
        /// <param name="inputs">
        /// Required. Inputs containing third-party device IDs for which to
        /// get the device states.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QueryResponse> QueryAsync(string requestId, string agentUserId, scg::IEnumerable<QueryRequestInput> inputs, gaxgrpc::CallSettings callSettings = null) =>
            QueryAsync(new QueryRequest
            {
                RequestId = requestId ?? "",
                AgentUserId = gax::GaxPreconditions.CheckNotNullOrEmpty(agentUserId, nameof(agentUserId)),
                Inputs =
                {
                    gax::GaxPreconditions.CheckNotNull(inputs, nameof(inputs)),
                },
            }, callSettings);

        /// <summary>
        /// Gets the current states in Home Graph for the given set of the third-party
        /// user's devices.
        /// 
        /// The third-party user's identity is passed in via the `agent_user_id`
        /// (see [QueryRequest][google.home.graph.v1.QueryRequest]).
        /// This request must be authorized using service account credentials from your
        /// Actions console project.
        /// </summary>
        /// <param name="requestId">
        /// Request ID used for debugging.
        /// </param>
        /// <param name="agentUserId">
        /// Required. Third-party user ID.
        /// </param>
        /// <param name="inputs">
        /// Required. Inputs containing third-party device IDs for which to
        /// get the device states.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QueryResponse> QueryAsync(string requestId, string agentUserId, scg::IEnumerable<QueryRequestInput> inputs, st::CancellationToken cancellationToken) =>
            QueryAsync(requestId, agentUserId, inputs, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets all the devices associated with the given third-party user.
        /// 
        /// The third-party user's identity is passed in via the `agent_user_id`
        /// (see [SyncRequest][google.home.graph.v1.SyncRequest]).
        /// This request must be authorized using service account credentials from your
        /// Actions console project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SyncResponse Sync(SyncRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets all the devices associated with the given third-party user.
        /// 
        /// The third-party user's identity is passed in via the `agent_user_id`
        /// (see [SyncRequest][google.home.graph.v1.SyncRequest]).
        /// This request must be authorized using service account credentials from your
        /// Actions console project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SyncResponse> SyncAsync(SyncRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets all the devices associated with the given third-party user.
        /// 
        /// The third-party user's identity is passed in via the `agent_user_id`
        /// (see [SyncRequest][google.home.graph.v1.SyncRequest]).
        /// This request must be authorized using service account credentials from your
        /// Actions console project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SyncResponse> SyncAsync(SyncRequest request, st::CancellationToken cancellationToken) =>
            SyncAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets all the devices associated with the given third-party user.
        /// 
        /// The third-party user's identity is passed in via the `agent_user_id`
        /// (see [SyncRequest][google.home.graph.v1.SyncRequest]).
        /// This request must be authorized using service account credentials from your
        /// Actions console project.
        /// </summary>
        /// <param name="requestId">
        /// Request ID used for debugging.
        /// </param>
        /// <param name="agentUserId">
        /// Required. Third-party user ID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SyncResponse Sync(string requestId, string agentUserId, gaxgrpc::CallSettings callSettings = null) =>
            Sync(new SyncRequest
            {
                RequestId = requestId ?? "",
                AgentUserId = gax::GaxPreconditions.CheckNotNullOrEmpty(agentUserId, nameof(agentUserId)),
            }, callSettings);

        /// <summary>
        /// Gets all the devices associated with the given third-party user.
        /// 
        /// The third-party user's identity is passed in via the `agent_user_id`
        /// (see [SyncRequest][google.home.graph.v1.SyncRequest]).
        /// This request must be authorized using service account credentials from your
        /// Actions console project.
        /// </summary>
        /// <param name="requestId">
        /// Request ID used for debugging.
        /// </param>
        /// <param name="agentUserId">
        /// Required. Third-party user ID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SyncResponse> SyncAsync(string requestId, string agentUserId, gaxgrpc::CallSettings callSettings = null) =>
            SyncAsync(new SyncRequest
            {
                RequestId = requestId ?? "",
                AgentUserId = gax::GaxPreconditions.CheckNotNullOrEmpty(agentUserId, nameof(agentUserId)),
            }, callSettings);

        /// <summary>
        /// Gets all the devices associated with the given third-party user.
        /// 
        /// The third-party user's identity is passed in via the `agent_user_id`
        /// (see [SyncRequest][google.home.graph.v1.SyncRequest]).
        /// This request must be authorized using service account credentials from your
        /// Actions console project.
        /// </summary>
        /// <param name="requestId">
        /// Request ID used for debugging.
        /// </param>
        /// <param name="agentUserId">
        /// Required. Third-party user ID.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SyncResponse> SyncAsync(string requestId, string agentUserId, st::CancellationToken cancellationToken) =>
            SyncAsync(requestId, agentUserId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>HomeGraphApiService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Google Home Graph API service. The Home Graph service provides support for
    /// accessing first-party and third-party devices stored in Google's Home Graph.
    /// The Home Graph database provides contextual data about the relationships
    /// between devices and the home.
    /// 
    /// For more details, see the [Home Graph developer
    /// guide](https://developers.google.com/assistant/smarthome/concepts/homegraph).
    /// </remarks>
    public sealed partial class HomeGraphApiServiceClientImpl : HomeGraphApiServiceClient
    {
        private readonly gaxgrpc::ApiCall<RequestSyncDevicesRequest, RequestSyncDevicesResponse> _callRequestSyncDevices;

        private readonly gaxgrpc::ApiCall<ReportStateAndNotificationRequest, ReportStateAndNotificationResponse> _callReportStateAndNotification;

        private readonly gaxgrpc::ApiCall<DeleteAgentUserRequest, wkt::Empty> _callDeleteAgentUser;

        private readonly gaxgrpc::ApiCall<QueryRequest, QueryResponse> _callQuery;

        private readonly gaxgrpc::ApiCall<SyncRequest, SyncResponse> _callSync;

        /// <summary>
        /// Constructs a client wrapper for the HomeGraphApiService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="HomeGraphApiServiceSettings"/> used within this client.</param>
        public HomeGraphApiServiceClientImpl(HomeGraphApiService.HomeGraphApiServiceClient grpcClient, HomeGraphApiServiceSettings settings)
        {
            GrpcClient = grpcClient;
            HomeGraphApiServiceSettings effectiveSettings = settings ?? HomeGraphApiServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callRequestSyncDevices = clientHelper.BuildApiCall<RequestSyncDevicesRequest, RequestSyncDevicesResponse>(grpcClient.RequestSyncDevicesAsync, grpcClient.RequestSyncDevices, effectiveSettings.RequestSyncDevicesSettings);
            Modify_ApiCall(ref _callRequestSyncDevices);
            Modify_RequestSyncDevicesApiCall(ref _callRequestSyncDevices);
            _callReportStateAndNotification = clientHelper.BuildApiCall<ReportStateAndNotificationRequest, ReportStateAndNotificationResponse>(grpcClient.ReportStateAndNotificationAsync, grpcClient.ReportStateAndNotification, effectiveSettings.ReportStateAndNotificationSettings);
            Modify_ApiCall(ref _callReportStateAndNotification);
            Modify_ReportStateAndNotificationApiCall(ref _callReportStateAndNotification);
            _callDeleteAgentUser = clientHelper.BuildApiCall<DeleteAgentUserRequest, wkt::Empty>(grpcClient.DeleteAgentUserAsync, grpcClient.DeleteAgentUser, effectiveSettings.DeleteAgentUserSettings).WithGoogleRequestParam("agent_user_id", request => request.AgentUserId);
            Modify_ApiCall(ref _callDeleteAgentUser);
            Modify_DeleteAgentUserApiCall(ref _callDeleteAgentUser);
            _callQuery = clientHelper.BuildApiCall<QueryRequest, QueryResponse>(grpcClient.QueryAsync, grpcClient.Query, effectiveSettings.QuerySettings);
            Modify_ApiCall(ref _callQuery);
            Modify_QueryApiCall(ref _callQuery);
            _callSync = clientHelper.BuildApiCall<SyncRequest, SyncResponse>(grpcClient.SyncAsync, grpcClient.Sync, effectiveSettings.SyncSettings);
            Modify_ApiCall(ref _callSync);
            Modify_SyncApiCall(ref _callSync);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_RequestSyncDevicesApiCall(ref gaxgrpc::ApiCall<RequestSyncDevicesRequest, RequestSyncDevicesResponse> call);

        partial void Modify_ReportStateAndNotificationApiCall(ref gaxgrpc::ApiCall<ReportStateAndNotificationRequest, ReportStateAndNotificationResponse> call);

        partial void Modify_DeleteAgentUserApiCall(ref gaxgrpc::ApiCall<DeleteAgentUserRequest, wkt::Empty> call);

        partial void Modify_QueryApiCall(ref gaxgrpc::ApiCall<QueryRequest, QueryResponse> call);

        partial void Modify_SyncApiCall(ref gaxgrpc::ApiCall<SyncRequest, SyncResponse> call);

        partial void OnConstruction(HomeGraphApiService.HomeGraphApiServiceClient grpcClient, HomeGraphApiServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC HomeGraphApiService client</summary>
        public override HomeGraphApiService.HomeGraphApiServiceClient GrpcClient { get; }

        partial void Modify_RequestSyncDevicesRequest(ref RequestSyncDevicesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ReportStateAndNotificationRequest(ref ReportStateAndNotificationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteAgentUserRequest(ref DeleteAgentUserRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_QueryRequest(ref QueryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SyncRequest(ref SyncRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Requests Google to send an `action.devices.SYNC`
        /// [intent](https://developers.google.com/assistant/smarthome/reference/intent/sync)
        /// to your smart home Action to update device metadata for the given user.
        /// 
        /// 
        /// The third-party user's identity is passed via the `agent_user_id`
        /// (see
        /// [RequestSyncDevicesRequest][google.home.graph.v1.RequestSyncDevicesRequest]).
        /// This request must be authorized using service account credentials from your
        /// Actions console project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RequestSyncDevicesResponse RequestSyncDevices(RequestSyncDevicesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RequestSyncDevicesRequest(ref request, ref callSettings);
            return _callRequestSyncDevices.Sync(request, callSettings);
        }

        /// <summary>
        /// Requests Google to send an `action.devices.SYNC`
        /// [intent](https://developers.google.com/assistant/smarthome/reference/intent/sync)
        /// to your smart home Action to update device metadata for the given user.
        /// 
        /// 
        /// The third-party user's identity is passed via the `agent_user_id`
        /// (see
        /// [RequestSyncDevicesRequest][google.home.graph.v1.RequestSyncDevicesRequest]).
        /// This request must be authorized using service account credentials from your
        /// Actions console project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RequestSyncDevicesResponse> RequestSyncDevicesAsync(RequestSyncDevicesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RequestSyncDevicesRequest(ref request, ref callSettings);
            return _callRequestSyncDevices.Async(request, callSettings);
        }

        /// <summary>
        /// Reports device state and optionally sends device notifications.
        /// Called by your smart home Action when the state of a third-party device
        /// changes or you need to send a notification about the device.
        /// See [Implement Report
        /// State](https://developers.google.com/assistant/smarthome/develop/report-state)
        /// for more information.
        /// 
        /// This method updates the device state according to its declared
        /// [traits](https://developers.google.com/assistant/smarthome/concepts/devices-traits).
        /// Publishing a new state value outside of these traits will result in an
        /// `INVALID_ARGUMENT` error response.
        /// 
        /// The third-party user's identity is passed in via the `agent_user_id`
        /// (see
        /// [ReportStateAndNotificationRequest][google.home.graph.v1.ReportStateAndNotificationRequest]).
        /// This request must be authorized using service account credentials from your
        /// Actions console project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ReportStateAndNotificationResponse ReportStateAndNotification(ReportStateAndNotificationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReportStateAndNotificationRequest(ref request, ref callSettings);
            return _callReportStateAndNotification.Sync(request, callSettings);
        }

        /// <summary>
        /// Reports device state and optionally sends device notifications.
        /// Called by your smart home Action when the state of a third-party device
        /// changes or you need to send a notification about the device.
        /// See [Implement Report
        /// State](https://developers.google.com/assistant/smarthome/develop/report-state)
        /// for more information.
        /// 
        /// This method updates the device state according to its declared
        /// [traits](https://developers.google.com/assistant/smarthome/concepts/devices-traits).
        /// Publishing a new state value outside of these traits will result in an
        /// `INVALID_ARGUMENT` error response.
        /// 
        /// The third-party user's identity is passed in via the `agent_user_id`
        /// (see
        /// [ReportStateAndNotificationRequest][google.home.graph.v1.ReportStateAndNotificationRequest]).
        /// This request must be authorized using service account credentials from your
        /// Actions console project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ReportStateAndNotificationResponse> ReportStateAndNotificationAsync(ReportStateAndNotificationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReportStateAndNotificationRequest(ref request, ref callSettings);
            return _callReportStateAndNotification.Async(request, callSettings);
        }

        /// <summary>
        /// Unlinks the given third-party user from your smart home Action.
        /// All data related to this user will be deleted.
        /// 
        /// For more details on how users link their accounts, see
        /// [fulfillment and
        /// authentication](https://developers.google.com/assistant/smarthome/concepts/fulfillment-authentication).
        /// 
        /// The third-party user's identity is passed in via the `agent_user_id`
        /// (see
        /// [DeleteAgentUserRequest][google.home.graph.v1.DeleteAgentUserRequest]).
        /// This request must be authorized using service account credentials from your
        /// Actions console project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteAgentUser(DeleteAgentUserRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAgentUserRequest(ref request, ref callSettings);
            _callDeleteAgentUser.Sync(request, callSettings);
        }

        /// <summary>
        /// Unlinks the given third-party user from your smart home Action.
        /// All data related to this user will be deleted.
        /// 
        /// For more details on how users link their accounts, see
        /// [fulfillment and
        /// authentication](https://developers.google.com/assistant/smarthome/concepts/fulfillment-authentication).
        /// 
        /// The third-party user's identity is passed in via the `agent_user_id`
        /// (see
        /// [DeleteAgentUserRequest][google.home.graph.v1.DeleteAgentUserRequest]).
        /// This request must be authorized using service account credentials from your
        /// Actions console project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteAgentUserAsync(DeleteAgentUserRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAgentUserRequest(ref request, ref callSettings);
            return _callDeleteAgentUser.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the current states in Home Graph for the given set of the third-party
        /// user's devices.
        /// 
        /// The third-party user's identity is passed in via the `agent_user_id`
        /// (see [QueryRequest][google.home.graph.v1.QueryRequest]).
        /// This request must be authorized using service account credentials from your
        /// Actions console project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override QueryResponse Query(QueryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryRequest(ref request, ref callSettings);
            return _callQuery.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the current states in Home Graph for the given set of the third-party
        /// user's devices.
        /// 
        /// The third-party user's identity is passed in via the `agent_user_id`
        /// (see [QueryRequest][google.home.graph.v1.QueryRequest]).
        /// This request must be authorized using service account credentials from your
        /// Actions console project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<QueryResponse> QueryAsync(QueryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryRequest(ref request, ref callSettings);
            return _callQuery.Async(request, callSettings);
        }

        /// <summary>
        /// Gets all the devices associated with the given third-party user.
        /// 
        /// The third-party user's identity is passed in via the `agent_user_id`
        /// (see [SyncRequest][google.home.graph.v1.SyncRequest]).
        /// This request must be authorized using service account credentials from your
        /// Actions console project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SyncResponse Sync(SyncRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SyncRequest(ref request, ref callSettings);
            return _callSync.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets all the devices associated with the given third-party user.
        /// 
        /// The third-party user's identity is passed in via the `agent_user_id`
        /// (see [SyncRequest][google.home.graph.v1.SyncRequest]).
        /// This request must be authorized using service account credentials from your
        /// Actions console project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SyncResponse> SyncAsync(SyncRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SyncRequest(ref request, ref callSettings);
            return _callSync.Async(request, callSettings);
        }
    }
}
