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

namespace Google.Home.Enterprise.Sdm.V1
{
    /// <summary>Settings for <see cref="SmartDeviceManagementServiceClient"/> instances.</summary>
    public sealed partial class SmartDeviceManagementServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="SmartDeviceManagementServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="SmartDeviceManagementServiceSettings"/>.</returns>
        public static SmartDeviceManagementServiceSettings GetDefault() => new SmartDeviceManagementServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="SmartDeviceManagementServiceSettings"/> object with default settings.
        /// </summary>
        public SmartDeviceManagementServiceSettings()
        {
        }

        private SmartDeviceManagementServiceSettings(SmartDeviceManagementServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetDeviceSettings = existing.GetDeviceSettings;
            ListDevicesSettings = existing.ListDevicesSettings;
            ExecuteDeviceCommandSettings = existing.ExecuteDeviceCommandSettings;
            GetStructureSettings = existing.GetStructureSettings;
            ListStructuresSettings = existing.ListStructuresSettings;
            GetRoomSettings = existing.GetRoomSettings;
            ListRoomsSettings = existing.ListRoomsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(SmartDeviceManagementServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SmartDeviceManagementServiceClient.GetDevice</c> and <c>SmartDeviceManagementServiceClient.GetDeviceAsync</c>
        /// .
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
        public gaxgrpc::CallSettings GetDeviceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SmartDeviceManagementServiceClient.ListDevices</c> and
        /// <c>SmartDeviceManagementServiceClient.ListDevicesAsync</c>.
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
        public gaxgrpc::CallSettings ListDevicesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SmartDeviceManagementServiceClient.ExecuteDeviceCommand</c> and
        /// <c>SmartDeviceManagementServiceClient.ExecuteDeviceCommandAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ExecuteDeviceCommandSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SmartDeviceManagementServiceClient.GetStructure</c> and
        /// <c>SmartDeviceManagementServiceClient.GetStructureAsync</c>.
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
        public gaxgrpc::CallSettings GetStructureSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SmartDeviceManagementServiceClient.ListStructures</c> and
        /// <c>SmartDeviceManagementServiceClient.ListStructuresAsync</c>.
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
        public gaxgrpc::CallSettings ListStructuresSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SmartDeviceManagementServiceClient.GetRoom</c> and <c>SmartDeviceManagementServiceClient.GetRoomAsync</c>
        /// .
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
        public gaxgrpc::CallSettings GetRoomSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SmartDeviceManagementServiceClient.ListRooms</c> and <c>SmartDeviceManagementServiceClient.ListRoomsAsync</c>
        /// .
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
        public gaxgrpc::CallSettings ListRoomsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="SmartDeviceManagementServiceSettings"/> object.</returns>
        public SmartDeviceManagementServiceSettings Clone() => new SmartDeviceManagementServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SmartDeviceManagementServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class SmartDeviceManagementServiceClientBuilder : gaxgrpc::ClientBuilderBase<SmartDeviceManagementServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public SmartDeviceManagementServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public SmartDeviceManagementServiceClientBuilder()
        {
            UseJwtAccessWithScopes = SmartDeviceManagementServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref SmartDeviceManagementServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<SmartDeviceManagementServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override SmartDeviceManagementServiceClient Build()
        {
            SmartDeviceManagementServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<SmartDeviceManagementServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<SmartDeviceManagementServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private SmartDeviceManagementServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SmartDeviceManagementServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<SmartDeviceManagementServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SmartDeviceManagementServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => SmartDeviceManagementServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => SmartDeviceManagementServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => SmartDeviceManagementServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>SmartDeviceManagementService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// A service that allows API consumers to provision and manage Google
    /// Home structures and devices for enterprise use cases.
    /// </remarks>
    public abstract partial class SmartDeviceManagementServiceClient
    {
        /// <summary>
        /// The default endpoint for the SmartDeviceManagementService service, which is a host of
        /// "smartdevicemanagement.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "smartdevicemanagement.googleapis.com:443";

        /// <summary>The default SmartDeviceManagementService scopes.</summary>
        /// <remarks>
        /// The default SmartDeviceManagementService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/sdm.service</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/sdm.service",
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
        /// Asynchronously creates a <see cref="SmartDeviceManagementServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="SmartDeviceManagementServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="SmartDeviceManagementServiceClient"/>.</returns>
        public static stt::Task<SmartDeviceManagementServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new SmartDeviceManagementServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="SmartDeviceManagementServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="SmartDeviceManagementServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="SmartDeviceManagementServiceClient"/>.</returns>
        public static SmartDeviceManagementServiceClient Create() => new SmartDeviceManagementServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="SmartDeviceManagementServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="SmartDeviceManagementServiceSettings"/>.</param>
        /// <returns>The created <see cref="SmartDeviceManagementServiceClient"/>.</returns>
        internal static SmartDeviceManagementServiceClient Create(grpccore::CallInvoker callInvoker, SmartDeviceManagementServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            SmartDeviceManagementService.SmartDeviceManagementServiceClient grpcClient = new SmartDeviceManagementService.SmartDeviceManagementServiceClient(callInvoker);
            return new SmartDeviceManagementServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC SmartDeviceManagementService client</summary>
        public virtual SmartDeviceManagementService.SmartDeviceManagementServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a device managed by the enterprise.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Device GetDevice(GetDeviceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a device managed by the enterprise.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Device> GetDeviceAsync(GetDeviceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a device managed by the enterprise.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Device> GetDeviceAsync(GetDeviceRequest request, st::CancellationToken cancellationToken) =>
            GetDeviceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists devices managed by the enterprise.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Device"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDevicesResponse, Device> ListDevices(ListDevicesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists devices managed by the enterprise.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Device"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDevicesResponse, Device> ListDevicesAsync(ListDevicesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Executes a command to device managed by the enterprise.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ExecuteDeviceCommandResponse ExecuteDeviceCommand(ExecuteDeviceCommandRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Executes a command to device managed by the enterprise.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExecuteDeviceCommandResponse> ExecuteDeviceCommandAsync(ExecuteDeviceCommandRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Executes a command to device managed by the enterprise.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExecuteDeviceCommandResponse> ExecuteDeviceCommandAsync(ExecuteDeviceCommandRequest request, st::CancellationToken cancellationToken) =>
            ExecuteDeviceCommandAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a structure managed by the enterprise.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Structure GetStructure(GetStructureRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a structure managed by the enterprise.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Structure> GetStructureAsync(GetStructureRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a structure managed by the enterprise.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Structure> GetStructureAsync(GetStructureRequest request, st::CancellationToken cancellationToken) =>
            GetStructureAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists structures managed by the enterprise.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Structure"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListStructuresResponse, Structure> ListStructures(ListStructuresRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists structures managed by the enterprise.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Structure"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListStructuresResponse, Structure> ListStructuresAsync(ListStructuresRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a room managed by the enterprise.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Room GetRoom(GetRoomRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a room managed by the enterprise.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Room> GetRoomAsync(GetRoomRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a room managed by the enterprise.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Room> GetRoomAsync(GetRoomRequest request, st::CancellationToken cancellationToken) =>
            GetRoomAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists rooms managed by the enterprise.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Room"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRoomsResponse, Room> ListRooms(ListRoomsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists rooms managed by the enterprise.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Room"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRoomsResponse, Room> ListRoomsAsync(ListRoomsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();
    }

    /// <summary>SmartDeviceManagementService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// A service that allows API consumers to provision and manage Google
    /// Home structures and devices for enterprise use cases.
    /// </remarks>
    public sealed partial class SmartDeviceManagementServiceClientImpl : SmartDeviceManagementServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetDeviceRequest, Device> _callGetDevice;

        private readonly gaxgrpc::ApiCall<ListDevicesRequest, ListDevicesResponse> _callListDevices;

        private readonly gaxgrpc::ApiCall<ExecuteDeviceCommandRequest, ExecuteDeviceCommandResponse> _callExecuteDeviceCommand;

        private readonly gaxgrpc::ApiCall<GetStructureRequest, Structure> _callGetStructure;

        private readonly gaxgrpc::ApiCall<ListStructuresRequest, ListStructuresResponse> _callListStructures;

        private readonly gaxgrpc::ApiCall<GetRoomRequest, Room> _callGetRoom;

        private readonly gaxgrpc::ApiCall<ListRoomsRequest, ListRoomsResponse> _callListRooms;

        /// <summary>
        /// Constructs a client wrapper for the SmartDeviceManagementService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="SmartDeviceManagementServiceSettings"/> used within this client.
        /// </param>
        public SmartDeviceManagementServiceClientImpl(SmartDeviceManagementService.SmartDeviceManagementServiceClient grpcClient, SmartDeviceManagementServiceSettings settings)
        {
            GrpcClient = grpcClient;
            SmartDeviceManagementServiceSettings effectiveSettings = settings ?? SmartDeviceManagementServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetDevice = clientHelper.BuildApiCall<GetDeviceRequest, Device>(grpcClient.GetDeviceAsync, grpcClient.GetDevice, effectiveSettings.GetDeviceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDevice);
            Modify_GetDeviceApiCall(ref _callGetDevice);
            _callListDevices = clientHelper.BuildApiCall<ListDevicesRequest, ListDevicesResponse>(grpcClient.ListDevicesAsync, grpcClient.ListDevices, effectiveSettings.ListDevicesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDevices);
            Modify_ListDevicesApiCall(ref _callListDevices);
            _callExecuteDeviceCommand = clientHelper.BuildApiCall<ExecuteDeviceCommandRequest, ExecuteDeviceCommandResponse>(grpcClient.ExecuteDeviceCommandAsync, grpcClient.ExecuteDeviceCommand, effectiveSettings.ExecuteDeviceCommandSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callExecuteDeviceCommand);
            Modify_ExecuteDeviceCommandApiCall(ref _callExecuteDeviceCommand);
            _callGetStructure = clientHelper.BuildApiCall<GetStructureRequest, Structure>(grpcClient.GetStructureAsync, grpcClient.GetStructure, effectiveSettings.GetStructureSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetStructure);
            Modify_GetStructureApiCall(ref _callGetStructure);
            _callListStructures = clientHelper.BuildApiCall<ListStructuresRequest, ListStructuresResponse>(grpcClient.ListStructuresAsync, grpcClient.ListStructures, effectiveSettings.ListStructuresSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListStructures);
            Modify_ListStructuresApiCall(ref _callListStructures);
            _callGetRoom = clientHelper.BuildApiCall<GetRoomRequest, Room>(grpcClient.GetRoomAsync, grpcClient.GetRoom, effectiveSettings.GetRoomSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetRoom);
            Modify_GetRoomApiCall(ref _callGetRoom);
            _callListRooms = clientHelper.BuildApiCall<ListRoomsRequest, ListRoomsResponse>(grpcClient.ListRoomsAsync, grpcClient.ListRooms, effectiveSettings.ListRoomsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListRooms);
            Modify_ListRoomsApiCall(ref _callListRooms);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetDeviceApiCall(ref gaxgrpc::ApiCall<GetDeviceRequest, Device> call);

        partial void Modify_ListDevicesApiCall(ref gaxgrpc::ApiCall<ListDevicesRequest, ListDevicesResponse> call);

        partial void Modify_ExecuteDeviceCommandApiCall(ref gaxgrpc::ApiCall<ExecuteDeviceCommandRequest, ExecuteDeviceCommandResponse> call);

        partial void Modify_GetStructureApiCall(ref gaxgrpc::ApiCall<GetStructureRequest, Structure> call);

        partial void Modify_ListStructuresApiCall(ref gaxgrpc::ApiCall<ListStructuresRequest, ListStructuresResponse> call);

        partial void Modify_GetRoomApiCall(ref gaxgrpc::ApiCall<GetRoomRequest, Room> call);

        partial void Modify_ListRoomsApiCall(ref gaxgrpc::ApiCall<ListRoomsRequest, ListRoomsResponse> call);

        partial void OnConstruction(SmartDeviceManagementService.SmartDeviceManagementServiceClient grpcClient, SmartDeviceManagementServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC SmartDeviceManagementService client</summary>
        public override SmartDeviceManagementService.SmartDeviceManagementServiceClient GrpcClient { get; }

        partial void Modify_GetDeviceRequest(ref GetDeviceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDevicesRequest(ref ListDevicesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ExecuteDeviceCommandRequest(ref ExecuteDeviceCommandRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetStructureRequest(ref GetStructureRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListStructuresRequest(ref ListStructuresRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetRoomRequest(ref GetRoomRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListRoomsRequest(ref ListRoomsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Gets a device managed by the enterprise.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Device GetDevice(GetDeviceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDeviceRequest(ref request, ref callSettings);
            return _callGetDevice.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a device managed by the enterprise.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Device> GetDeviceAsync(GetDeviceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDeviceRequest(ref request, ref callSettings);
            return _callGetDevice.Async(request, callSettings);
        }

        /// <summary>
        /// Lists devices managed by the enterprise.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Device"/> resources.</returns>
        public override gax::PagedEnumerable<ListDevicesResponse, Device> ListDevices(ListDevicesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDevicesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDevicesRequest, ListDevicesResponse, Device>(_callListDevices, request, callSettings);
        }

        /// <summary>
        /// Lists devices managed by the enterprise.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Device"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDevicesResponse, Device> ListDevicesAsync(ListDevicesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDevicesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDevicesRequest, ListDevicesResponse, Device>(_callListDevices, request, callSettings);
        }

        /// <summary>
        /// Executes a command to device managed by the enterprise.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ExecuteDeviceCommandResponse ExecuteDeviceCommand(ExecuteDeviceCommandRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExecuteDeviceCommandRequest(ref request, ref callSettings);
            return _callExecuteDeviceCommand.Sync(request, callSettings);
        }

        /// <summary>
        /// Executes a command to device managed by the enterprise.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ExecuteDeviceCommandResponse> ExecuteDeviceCommandAsync(ExecuteDeviceCommandRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExecuteDeviceCommandRequest(ref request, ref callSettings);
            return _callExecuteDeviceCommand.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a structure managed by the enterprise.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Structure GetStructure(GetStructureRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetStructureRequest(ref request, ref callSettings);
            return _callGetStructure.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a structure managed by the enterprise.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Structure> GetStructureAsync(GetStructureRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetStructureRequest(ref request, ref callSettings);
            return _callGetStructure.Async(request, callSettings);
        }

        /// <summary>
        /// Lists structures managed by the enterprise.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Structure"/> resources.</returns>
        public override gax::PagedEnumerable<ListStructuresResponse, Structure> ListStructures(ListStructuresRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListStructuresRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListStructuresRequest, ListStructuresResponse, Structure>(_callListStructures, request, callSettings);
        }

        /// <summary>
        /// Lists structures managed by the enterprise.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Structure"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListStructuresResponse, Structure> ListStructuresAsync(ListStructuresRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListStructuresRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListStructuresRequest, ListStructuresResponse, Structure>(_callListStructures, request, callSettings);
        }

        /// <summary>
        /// Gets a room managed by the enterprise.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Room GetRoom(GetRoomRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRoomRequest(ref request, ref callSettings);
            return _callGetRoom.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a room managed by the enterprise.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Room> GetRoomAsync(GetRoomRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRoomRequest(ref request, ref callSettings);
            return _callGetRoom.Async(request, callSettings);
        }

        /// <summary>
        /// Lists rooms managed by the enterprise.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Room"/> resources.</returns>
        public override gax::PagedEnumerable<ListRoomsResponse, Room> ListRooms(ListRoomsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRoomsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListRoomsRequest, ListRoomsResponse, Room>(_callListRooms, request, callSettings);
        }

        /// <summary>
        /// Lists rooms managed by the enterprise.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Room"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListRoomsResponse, Room> ListRoomsAsync(ListRoomsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRoomsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListRoomsRequest, ListRoomsResponse, Room>(_callListRooms, request, callSettings);
        }
    }

    public partial class ListDevicesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListStructuresRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListRoomsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDevicesResponse : gaxgrpc::IPageResponse<Device>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Device> GetEnumerator() => Devices.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListStructuresResponse : gaxgrpc::IPageResponse<Structure>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Structure> GetEnumerator() => Structures.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListRoomsResponse : gaxgrpc::IPageResponse<Room>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Room> GetEnumerator() => Rooms.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
