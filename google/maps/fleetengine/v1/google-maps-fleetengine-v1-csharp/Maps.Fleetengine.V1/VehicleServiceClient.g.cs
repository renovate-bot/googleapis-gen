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

namespace Maps.Fleetengine.V1
{
    /// <summary>Settings for <see cref="VehicleServiceClient"/> instances.</summary>
    public sealed partial class VehicleServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="VehicleServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="VehicleServiceSettings"/>.</returns>
        public static VehicleServiceSettings GetDefault() => new VehicleServiceSettings();

        /// <summary>Constructs a new <see cref="VehicleServiceSettings"/> object with default settings.</summary>
        public VehicleServiceSettings()
        {
        }

        private VehicleServiceSettings(VehicleServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateVehicleSettings = existing.CreateVehicleSettings;
            GetVehicleSettings = existing.GetVehicleSettings;
            UpdateVehicleSettings = existing.UpdateVehicleSettings;
            UpdateVehicleLocationSettings = existing.UpdateVehicleLocationSettings;
            UpdateVehicleAttributesSettings = existing.UpdateVehicleAttributesSettings;
            ListVehiclesSettings = existing.ListVehiclesSettings;
            SearchVehiclesSettings = existing.SearchVehiclesSettings;
            SearchFuzzedVehiclesSettings = existing.SearchFuzzedVehiclesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(VehicleServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VehicleServiceClient.CreateVehicle</c> and <c>VehicleServiceClient.CreateVehicleAsync</c>.
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
        public gaxgrpc::CallSettings CreateVehicleSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VehicleServiceClient.GetVehicle</c> and <c>VehicleServiceClient.GetVehicleAsync</c>.
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
        public gaxgrpc::CallSettings GetVehicleSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VehicleServiceClient.UpdateVehicle</c> and <c>VehicleServiceClient.UpdateVehicleAsync</c>.
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
        public gaxgrpc::CallSettings UpdateVehicleSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VehicleServiceClient.UpdateVehicleLocation</c> and <c>VehicleServiceClient.UpdateVehicleLocationAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateVehicleLocationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VehicleServiceClient.UpdateVehicleAttributes</c> and <c>VehicleServiceClient.UpdateVehicleAttributesAsync</c>
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
        public gaxgrpc::CallSettings UpdateVehicleAttributesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VehicleServiceClient.ListVehicles</c> and <c>VehicleServiceClient.ListVehiclesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListVehiclesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VehicleServiceClient.SearchVehicles</c> and <c>VehicleServiceClient.SearchVehiclesAsync</c>.
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
        public gaxgrpc::CallSettings SearchVehiclesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VehicleServiceClient.SearchFuzzedVehicles</c> and <c>VehicleServiceClient.SearchFuzzedVehiclesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SearchFuzzedVehiclesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="VehicleServiceSettings"/> object.</returns>
        public VehicleServiceSettings Clone() => new VehicleServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="VehicleServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class VehicleServiceClientBuilder : gaxgrpc::ClientBuilderBase<VehicleServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public VehicleServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public VehicleServiceClientBuilder()
        {
            UseJwtAccessWithScopes = VehicleServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref VehicleServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<VehicleServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override VehicleServiceClient Build()
        {
            VehicleServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<VehicleServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<VehicleServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private VehicleServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return VehicleServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<VehicleServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return VehicleServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => VehicleServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => VehicleServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => VehicleServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>VehicleService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Vehicle management service.
    /// </remarks>
    public abstract partial class VehicleServiceClient
    {
        /// <summary>
        /// The default endpoint for the VehicleService service, which is a host of "fleetengine.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "fleetengine.googleapis.com:443";

        /// <summary>The default VehicleService scopes.</summary>
        /// <remarks>The default VehicleService scopes are:<list type="bullet"></list></remarks>
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
        /// Asynchronously creates a <see cref="VehicleServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="VehicleServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="VehicleServiceClient"/>.</returns>
        public static stt::Task<VehicleServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new VehicleServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="VehicleServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="VehicleServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="VehicleServiceClient"/>.</returns>
        public static VehicleServiceClient Create() => new VehicleServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="VehicleServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="VehicleServiceSettings"/>.</param>
        /// <returns>The created <see cref="VehicleServiceClient"/>.</returns>
        internal static VehicleServiceClient Create(grpccore::CallInvoker callInvoker, VehicleServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            VehicleService.VehicleServiceClient grpcClient = new VehicleService.VehicleServiceClient(callInvoker);
            return new VehicleServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC VehicleService client</summary>
        public virtual VehicleService.VehicleServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// CreateVehicle instantiates a new vehicle associated with a rideshare
        /// provider in the Fleet Engine. Vehicles must have a unique vehicle ID.
        /// 
        /// The following Vehicle fields are required when creating a Vehicle:
        /// 
        /// * vehicleState
        /// * supportedTripTypes
        /// * maximumCapacity
        /// * vehicleType
        /// 
        /// The following Vehicle fields are ignored when creating a Vehicle:
        /// 
        /// * name
        /// * currentTrips
        /// * availableCapacity
        /// * current_route_segment
        /// * current_route_segment_version
        /// * waypoint
        /// * waypoints_version
        /// * remaining_distance_meters
        /// * eta_to_next_waypoint
        /// * navigation_status
        /// 
        /// All other fields are optional and used if provided.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Vehicle CreateVehicle(CreateVehicleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// CreateVehicle instantiates a new vehicle associated with a rideshare
        /// provider in the Fleet Engine. Vehicles must have a unique vehicle ID.
        /// 
        /// The following Vehicle fields are required when creating a Vehicle:
        /// 
        /// * vehicleState
        /// * supportedTripTypes
        /// * maximumCapacity
        /// * vehicleType
        /// 
        /// The following Vehicle fields are ignored when creating a Vehicle:
        /// 
        /// * name
        /// * currentTrips
        /// * availableCapacity
        /// * current_route_segment
        /// * current_route_segment_version
        /// * waypoint
        /// * waypoints_version
        /// * remaining_distance_meters
        /// * eta_to_next_waypoint
        /// * navigation_status
        /// 
        /// All other fields are optional and used if provided.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Vehicle> CreateVehicleAsync(CreateVehicleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// CreateVehicle instantiates a new vehicle associated with a rideshare
        /// provider in the Fleet Engine. Vehicles must have a unique vehicle ID.
        /// 
        /// The following Vehicle fields are required when creating a Vehicle:
        /// 
        /// * vehicleState
        /// * supportedTripTypes
        /// * maximumCapacity
        /// * vehicleType
        /// 
        /// The following Vehicle fields are ignored when creating a Vehicle:
        /// 
        /// * name
        /// * currentTrips
        /// * availableCapacity
        /// * current_route_segment
        /// * current_route_segment_version
        /// * waypoint
        /// * waypoints_version
        /// * remaining_distance_meters
        /// * eta_to_next_waypoint
        /// * navigation_status
        /// 
        /// All other fields are optional and used if provided.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Vehicle> CreateVehicleAsync(CreateVehicleRequest request, st::CancellationToken cancellationToken) =>
            CreateVehicleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// GetVehicle returns a vehicle from the Fleet Engine.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Vehicle GetVehicle(GetVehicleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// GetVehicle returns a vehicle from the Fleet Engine.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Vehicle> GetVehicleAsync(GetVehicleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// GetVehicle returns a vehicle from the Fleet Engine.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Vehicle> GetVehicleAsync(GetVehicleRequest request, st::CancellationToken cancellationToken) =>
            GetVehicleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// UpdateVehicle writes updated vehicle data to the Fleet Engine.
        /// 
        /// When updating a Vehicle, the following fields cannot be updated since they
        /// are managed by the Fleet Engine:
        /// 
        /// * currentTrips
        /// * availableCapacity
        /// * current_route_segment_version
        /// * waypoints_version
        /// 
        /// The vehicle name also cannot be updated.
        /// 
        /// The waypoints field can be updated, but must contain all the waypoints
        /// currently on the vehicle, and no other waypoints.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Vehicle UpdateVehicle(UpdateVehicleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// UpdateVehicle writes updated vehicle data to the Fleet Engine.
        /// 
        /// When updating a Vehicle, the following fields cannot be updated since they
        /// are managed by the Fleet Engine:
        /// 
        /// * currentTrips
        /// * availableCapacity
        /// * current_route_segment_version
        /// * waypoints_version
        /// 
        /// The vehicle name also cannot be updated.
        /// 
        /// The waypoints field can be updated, but must contain all the waypoints
        /// currently on the vehicle, and no other waypoints.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Vehicle> UpdateVehicleAsync(UpdateVehicleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// UpdateVehicle writes updated vehicle data to the Fleet Engine.
        /// 
        /// When updating a Vehicle, the following fields cannot be updated since they
        /// are managed by the Fleet Engine:
        /// 
        /// * currentTrips
        /// * availableCapacity
        /// * current_route_segment_version
        /// * waypoints_version
        /// 
        /// The vehicle name also cannot be updated.
        /// 
        /// The waypoints field can be updated, but must contain all the waypoints
        /// currently on the vehicle, and no other waypoints.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Vehicle> UpdateVehicleAsync(UpdateVehicleRequest request, st::CancellationToken cancellationToken) =>
            UpdateVehicleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// UpdateVehicleLocation updates the location of the vehicle.
        /// This method is deprecated. Use UpdateVehicle method instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        [sys::ObsoleteAttribute]
#pragma warning disable CS0612
        public virtual VehicleLocation UpdateVehicleLocation(UpdateVehicleLocationRequest request, gaxgrpc::CallSettings callSettings = null) =>
#pragma warning restore CS0612
            throw new sys::NotImplementedException();

        /// <summary>
        /// UpdateVehicleLocation updates the location of the vehicle.
        /// This method is deprecated. Use UpdateVehicle method instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
#pragma warning disable CS0612
        public virtual stt::Task<VehicleLocation> UpdateVehicleLocationAsync(UpdateVehicleLocationRequest request, gaxgrpc::CallSettings callSettings = null) =>
#pragma warning restore CS0612
            throw new sys::NotImplementedException();

        /// <summary>
        /// UpdateVehicleLocation updates the location of the vehicle.
        /// This method is deprecated. Use UpdateVehicle method instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
#pragma warning disable CS0612
        public virtual stt::Task<VehicleLocation> UpdateVehicleLocationAsync(UpdateVehicleLocationRequest request, st::CancellationToken cancellationToken) =>
#pragma warning restore CS0612
            UpdateVehicleLocationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// UpdateVehicleAttributes partially updates a vehicle's attributes.
        /// Only the attributes mentioned in the request will be updated, other
        /// attributes will NOT be altered. Note: this is different in UpdateVehicle,
        /// where the whole `attributes` field will be replaced by the one in
        /// UpdateVehicleRequest, attributes not in the request would be removed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UpdateVehicleAttributesResponse UpdateVehicleAttributes(UpdateVehicleAttributesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// UpdateVehicleAttributes partially updates a vehicle's attributes.
        /// Only the attributes mentioned in the request will be updated, other
        /// attributes will NOT be altered. Note: this is different in UpdateVehicle,
        /// where the whole `attributes` field will be replaced by the one in
        /// UpdateVehicleRequest, attributes not in the request would be removed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UpdateVehicleAttributesResponse> UpdateVehicleAttributesAsync(UpdateVehicleAttributesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// UpdateVehicleAttributes partially updates a vehicle's attributes.
        /// Only the attributes mentioned in the request will be updated, other
        /// attributes will NOT be altered. Note: this is different in UpdateVehicle,
        /// where the whole `attributes` field will be replaced by the one in
        /// UpdateVehicleRequest, attributes not in the request would be removed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UpdateVehicleAttributesResponse> UpdateVehicleAttributesAsync(UpdateVehicleAttributesRequest request, st::CancellationToken cancellationToken) =>
            UpdateVehicleAttributesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// ListVehicles returns a paginated list of vehicles associated with
        /// a provider that match the request options.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Vehicle"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListVehiclesResponse, Vehicle> ListVehicles(ListVehiclesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// ListVehicles returns a paginated list of vehicles associated with
        /// a provider that match the request options.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Vehicle"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListVehiclesResponse, Vehicle> ListVehiclesAsync(ListVehiclesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// SearchVehicles returns a list of vehicles that match the request options.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SearchVehiclesResponse SearchVehicles(SearchVehiclesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// SearchVehicles returns a list of vehicles that match the request options.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchVehiclesResponse> SearchVehiclesAsync(SearchVehiclesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// SearchVehicles returns a list of vehicles that match the request options.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchVehiclesResponse> SearchVehiclesAsync(SearchVehiclesRequest request, st::CancellationToken cancellationToken) =>
            SearchVehiclesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// SearchFuzzedVehicles returns a list of vehicles that match the request
        /// options with their locations fuzzed.
        /// Request does not support 'order_by' field.
        /// Vehicle matches in response will be in order of distance from pickup point.
        /// Vehicle matches in response will only have 'vehicle' and 'trip_type' field
        /// set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SearchVehiclesResponse SearchFuzzedVehicles(SearchVehiclesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// SearchFuzzedVehicles returns a list of vehicles that match the request
        /// options with their locations fuzzed.
        /// Request does not support 'order_by' field.
        /// Vehicle matches in response will be in order of distance from pickup point.
        /// Vehicle matches in response will only have 'vehicle' and 'trip_type' field
        /// set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchVehiclesResponse> SearchFuzzedVehiclesAsync(SearchVehiclesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// SearchFuzzedVehicles returns a list of vehicles that match the request
        /// options with their locations fuzzed.
        /// Request does not support 'order_by' field.
        /// Vehicle matches in response will be in order of distance from pickup point.
        /// Vehicle matches in response will only have 'vehicle' and 'trip_type' field
        /// set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SearchVehiclesResponse> SearchFuzzedVehiclesAsync(SearchVehiclesRequest request, st::CancellationToken cancellationToken) =>
            SearchFuzzedVehiclesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>VehicleService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Vehicle management service.
    /// </remarks>
    public sealed partial class VehicleServiceClientImpl : VehicleServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateVehicleRequest, Vehicle> _callCreateVehicle;

        private readonly gaxgrpc::ApiCall<GetVehicleRequest, Vehicle> _callGetVehicle;

        private readonly gaxgrpc::ApiCall<UpdateVehicleRequest, Vehicle> _callUpdateVehicle;

#pragma warning disable CS0612
        private readonly gaxgrpc::ApiCall<UpdateVehicleLocationRequest, VehicleLocation> _callUpdateVehicleLocation;
#pragma warning restore CS0612

        private readonly gaxgrpc::ApiCall<UpdateVehicleAttributesRequest, UpdateVehicleAttributesResponse> _callUpdateVehicleAttributes;

        private readonly gaxgrpc::ApiCall<ListVehiclesRequest, ListVehiclesResponse> _callListVehicles;

        private readonly gaxgrpc::ApiCall<SearchVehiclesRequest, SearchVehiclesResponse> _callSearchVehicles;

        private readonly gaxgrpc::ApiCall<SearchVehiclesRequest, SearchVehiclesResponse> _callSearchFuzzedVehicles;

        /// <summary>
        /// Constructs a client wrapper for the VehicleService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="VehicleServiceSettings"/> used within this client.</param>
        public VehicleServiceClientImpl(VehicleService.VehicleServiceClient grpcClient, VehicleServiceSettings settings)
        {
            GrpcClient = grpcClient;
            VehicleServiceSettings effectiveSettings = settings ?? VehicleServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callCreateVehicle = clientHelper.BuildApiCall<CreateVehicleRequest, Vehicle>(grpcClient.CreateVehicleAsync, grpcClient.CreateVehicle, effectiveSettings.CreateVehicleSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateVehicle);
            Modify_CreateVehicleApiCall(ref _callCreateVehicle);
            _callGetVehicle = clientHelper.BuildApiCall<GetVehicleRequest, Vehicle>(grpcClient.GetVehicleAsync, grpcClient.GetVehicle, effectiveSettings.GetVehicleSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetVehicle);
            Modify_GetVehicleApiCall(ref _callGetVehicle);
            _callUpdateVehicle = clientHelper.BuildApiCall<UpdateVehicleRequest, Vehicle>(grpcClient.UpdateVehicleAsync, grpcClient.UpdateVehicle, effectiveSettings.UpdateVehicleSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUpdateVehicle);
            Modify_UpdateVehicleApiCall(ref _callUpdateVehicle);
#pragma warning disable CS0612
            _callUpdateVehicleLocation = clientHelper.BuildApiCall<UpdateVehicleLocationRequest, VehicleLocation>(grpcClient.UpdateVehicleLocationAsync, grpcClient.UpdateVehicleLocation, effectiveSettings.UpdateVehicleLocationSettings).WithGoogleRequestParam("name", request => request.Name);
#pragma warning restore CS0612
            Modify_ApiCall(ref _callUpdateVehicleLocation);
            Modify_UpdateVehicleLocationApiCall(ref _callUpdateVehicleLocation);
            _callUpdateVehicleAttributes = clientHelper.BuildApiCall<UpdateVehicleAttributesRequest, UpdateVehicleAttributesResponse>(grpcClient.UpdateVehicleAttributesAsync, grpcClient.UpdateVehicleAttributes, effectiveSettings.UpdateVehicleAttributesSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUpdateVehicleAttributes);
            Modify_UpdateVehicleAttributesApiCall(ref _callUpdateVehicleAttributes);
            _callListVehicles = clientHelper.BuildApiCall<ListVehiclesRequest, ListVehiclesResponse>(grpcClient.ListVehiclesAsync, grpcClient.ListVehicles, effectiveSettings.ListVehiclesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListVehicles);
            Modify_ListVehiclesApiCall(ref _callListVehicles);
            _callSearchVehicles = clientHelper.BuildApiCall<SearchVehiclesRequest, SearchVehiclesResponse>(grpcClient.SearchVehiclesAsync, grpcClient.SearchVehicles, effectiveSettings.SearchVehiclesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callSearchVehicles);
            Modify_SearchVehiclesApiCall(ref _callSearchVehicles);
            _callSearchFuzzedVehicles = clientHelper.BuildApiCall<SearchVehiclesRequest, SearchVehiclesResponse>(grpcClient.SearchFuzzedVehiclesAsync, grpcClient.SearchFuzzedVehicles, effectiveSettings.SearchFuzzedVehiclesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callSearchFuzzedVehicles);
            Modify_SearchFuzzedVehiclesApiCall(ref _callSearchFuzzedVehicles);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateVehicleApiCall(ref gaxgrpc::ApiCall<CreateVehicleRequest, Vehicle> call);

        partial void Modify_GetVehicleApiCall(ref gaxgrpc::ApiCall<GetVehicleRequest, Vehicle> call);

        partial void Modify_UpdateVehicleApiCall(ref gaxgrpc::ApiCall<UpdateVehicleRequest, Vehicle> call);

#pragma warning disable CS0612
        partial void Modify_UpdateVehicleLocationApiCall(ref gaxgrpc::ApiCall<UpdateVehicleLocationRequest, VehicleLocation> call);
#pragma warning restore CS0612

        partial void Modify_UpdateVehicleAttributesApiCall(ref gaxgrpc::ApiCall<UpdateVehicleAttributesRequest, UpdateVehicleAttributesResponse> call);

        partial void Modify_ListVehiclesApiCall(ref gaxgrpc::ApiCall<ListVehiclesRequest, ListVehiclesResponse> call);

        partial void Modify_SearchVehiclesApiCall(ref gaxgrpc::ApiCall<SearchVehiclesRequest, SearchVehiclesResponse> call);

        partial void Modify_SearchFuzzedVehiclesApiCall(ref gaxgrpc::ApiCall<SearchVehiclesRequest, SearchVehiclesResponse> call);

        partial void OnConstruction(VehicleService.VehicleServiceClient grpcClient, VehicleServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC VehicleService client</summary>
        public override VehicleService.VehicleServiceClient GrpcClient { get; }

        partial void Modify_CreateVehicleRequest(ref CreateVehicleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetVehicleRequest(ref GetVehicleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateVehicleRequest(ref UpdateVehicleRequest request, ref gaxgrpc::CallSettings settings);

#pragma warning disable CS0612
        partial void Modify_UpdateVehicleLocationRequest(ref UpdateVehicleLocationRequest request, ref gaxgrpc::CallSettings settings);
#pragma warning restore CS0612

        partial void Modify_UpdateVehicleAttributesRequest(ref UpdateVehicleAttributesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListVehiclesRequest(ref ListVehiclesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SearchVehiclesRequest(ref SearchVehiclesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// CreateVehicle instantiates a new vehicle associated with a rideshare
        /// provider in the Fleet Engine. Vehicles must have a unique vehicle ID.
        /// 
        /// The following Vehicle fields are required when creating a Vehicle:
        /// 
        /// * vehicleState
        /// * supportedTripTypes
        /// * maximumCapacity
        /// * vehicleType
        /// 
        /// The following Vehicle fields are ignored when creating a Vehicle:
        /// 
        /// * name
        /// * currentTrips
        /// * availableCapacity
        /// * current_route_segment
        /// * current_route_segment_version
        /// * waypoint
        /// * waypoints_version
        /// * remaining_distance_meters
        /// * eta_to_next_waypoint
        /// * navigation_status
        /// 
        /// All other fields are optional and used if provided.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Vehicle CreateVehicle(CreateVehicleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateVehicleRequest(ref request, ref callSettings);
            return _callCreateVehicle.Sync(request, callSettings);
        }

        /// <summary>
        /// CreateVehicle instantiates a new vehicle associated with a rideshare
        /// provider in the Fleet Engine. Vehicles must have a unique vehicle ID.
        /// 
        /// The following Vehicle fields are required when creating a Vehicle:
        /// 
        /// * vehicleState
        /// * supportedTripTypes
        /// * maximumCapacity
        /// * vehicleType
        /// 
        /// The following Vehicle fields are ignored when creating a Vehicle:
        /// 
        /// * name
        /// * currentTrips
        /// * availableCapacity
        /// * current_route_segment
        /// * current_route_segment_version
        /// * waypoint
        /// * waypoints_version
        /// * remaining_distance_meters
        /// * eta_to_next_waypoint
        /// * navigation_status
        /// 
        /// All other fields are optional and used if provided.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Vehicle> CreateVehicleAsync(CreateVehicleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateVehicleRequest(ref request, ref callSettings);
            return _callCreateVehicle.Async(request, callSettings);
        }

        /// <summary>
        /// GetVehicle returns a vehicle from the Fleet Engine.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Vehicle GetVehicle(GetVehicleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetVehicleRequest(ref request, ref callSettings);
            return _callGetVehicle.Sync(request, callSettings);
        }

        /// <summary>
        /// GetVehicle returns a vehicle from the Fleet Engine.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Vehicle> GetVehicleAsync(GetVehicleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetVehicleRequest(ref request, ref callSettings);
            return _callGetVehicle.Async(request, callSettings);
        }

        /// <summary>
        /// UpdateVehicle writes updated vehicle data to the Fleet Engine.
        /// 
        /// When updating a Vehicle, the following fields cannot be updated since they
        /// are managed by the Fleet Engine:
        /// 
        /// * currentTrips
        /// * availableCapacity
        /// * current_route_segment_version
        /// * waypoints_version
        /// 
        /// The vehicle name also cannot be updated.
        /// 
        /// The waypoints field can be updated, but must contain all the waypoints
        /// currently on the vehicle, and no other waypoints.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Vehicle UpdateVehicle(UpdateVehicleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateVehicleRequest(ref request, ref callSettings);
            return _callUpdateVehicle.Sync(request, callSettings);
        }

        /// <summary>
        /// UpdateVehicle writes updated vehicle data to the Fleet Engine.
        /// 
        /// When updating a Vehicle, the following fields cannot be updated since they
        /// are managed by the Fleet Engine:
        /// 
        /// * currentTrips
        /// * availableCapacity
        /// * current_route_segment_version
        /// * waypoints_version
        /// 
        /// The vehicle name also cannot be updated.
        /// 
        /// The waypoints field can be updated, but must contain all the waypoints
        /// currently on the vehicle, and no other waypoints.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Vehicle> UpdateVehicleAsync(UpdateVehicleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateVehicleRequest(ref request, ref callSettings);
            return _callUpdateVehicle.Async(request, callSettings);
        }

        /// <summary>
        /// UpdateVehicleLocation updates the location of the vehicle.
        /// This method is deprecated. Use UpdateVehicle method instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        [sys::ObsoleteAttribute]
#pragma warning disable CS0612
        public override VehicleLocation UpdateVehicleLocation(UpdateVehicleLocationRequest request, gaxgrpc::CallSettings callSettings = null)
#pragma warning restore CS0612
        {
            Modify_UpdateVehicleLocationRequest(ref request, ref callSettings);
            return _callUpdateVehicleLocation.Sync(request, callSettings);
        }

        /// <summary>
        /// UpdateVehicleLocation updates the location of the vehicle.
        /// This method is deprecated. Use UpdateVehicle method instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
#pragma warning disable CS0612
        public override stt::Task<VehicleLocation> UpdateVehicleLocationAsync(UpdateVehicleLocationRequest request, gaxgrpc::CallSettings callSettings = null)
#pragma warning restore CS0612
        {
            Modify_UpdateVehicleLocationRequest(ref request, ref callSettings);
            return _callUpdateVehicleLocation.Async(request, callSettings);
        }

        /// <summary>
        /// UpdateVehicleAttributes partially updates a vehicle's attributes.
        /// Only the attributes mentioned in the request will be updated, other
        /// attributes will NOT be altered. Note: this is different in UpdateVehicle,
        /// where the whole `attributes` field will be replaced by the one in
        /// UpdateVehicleRequest, attributes not in the request would be removed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UpdateVehicleAttributesResponse UpdateVehicleAttributes(UpdateVehicleAttributesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateVehicleAttributesRequest(ref request, ref callSettings);
            return _callUpdateVehicleAttributes.Sync(request, callSettings);
        }

        /// <summary>
        /// UpdateVehicleAttributes partially updates a vehicle's attributes.
        /// Only the attributes mentioned in the request will be updated, other
        /// attributes will NOT be altered. Note: this is different in UpdateVehicle,
        /// where the whole `attributes` field will be replaced by the one in
        /// UpdateVehicleRequest, attributes not in the request would be removed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UpdateVehicleAttributesResponse> UpdateVehicleAttributesAsync(UpdateVehicleAttributesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateVehicleAttributesRequest(ref request, ref callSettings);
            return _callUpdateVehicleAttributes.Async(request, callSettings);
        }

        /// <summary>
        /// ListVehicles returns a paginated list of vehicles associated with
        /// a provider that match the request options.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Vehicle"/> resources.</returns>
        public override gax::PagedEnumerable<ListVehiclesResponse, Vehicle> ListVehicles(ListVehiclesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListVehiclesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListVehiclesRequest, ListVehiclesResponse, Vehicle>(_callListVehicles, request, callSettings);
        }

        /// <summary>
        /// ListVehicles returns a paginated list of vehicles associated with
        /// a provider that match the request options.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Vehicle"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListVehiclesResponse, Vehicle> ListVehiclesAsync(ListVehiclesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListVehiclesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListVehiclesRequest, ListVehiclesResponse, Vehicle>(_callListVehicles, request, callSettings);
        }

        /// <summary>
        /// SearchVehicles returns a list of vehicles that match the request options.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SearchVehiclesResponse SearchVehicles(SearchVehiclesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchVehiclesRequest(ref request, ref callSettings);
            return _callSearchVehicles.Sync(request, callSettings);
        }

        /// <summary>
        /// SearchVehicles returns a list of vehicles that match the request options.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SearchVehiclesResponse> SearchVehiclesAsync(SearchVehiclesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchVehiclesRequest(ref request, ref callSettings);
            return _callSearchVehicles.Async(request, callSettings);
        }

        /// <summary>
        /// SearchFuzzedVehicles returns a list of vehicles that match the request
        /// options with their locations fuzzed.
        /// Request does not support 'order_by' field.
        /// Vehicle matches in response will be in order of distance from pickup point.
        /// Vehicle matches in response will only have 'vehicle' and 'trip_type' field
        /// set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SearchVehiclesResponse SearchFuzzedVehicles(SearchVehiclesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchVehiclesRequest(ref request, ref callSettings);
            return _callSearchFuzzedVehicles.Sync(request, callSettings);
        }

        /// <summary>
        /// SearchFuzzedVehicles returns a list of vehicles that match the request
        /// options with their locations fuzzed.
        /// Request does not support 'order_by' field.
        /// Vehicle matches in response will be in order of distance from pickup point.
        /// Vehicle matches in response will only have 'vehicle' and 'trip_type' field
        /// set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SearchVehiclesResponse> SearchFuzzedVehiclesAsync(SearchVehiclesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchVehiclesRequest(ref request, ref callSettings);
            return _callSearchFuzzedVehicles.Async(request, callSettings);
        }
    }

    public partial class ListVehiclesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListVehiclesResponse : gaxgrpc::IPageResponse<Vehicle>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Vehicle> GetEnumerator() => Vehicles.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
