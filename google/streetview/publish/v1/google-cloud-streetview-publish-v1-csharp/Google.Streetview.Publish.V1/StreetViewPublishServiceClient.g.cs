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
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using linq = System.Linq;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Streetview.Publish.V1
{
    /// <summary>Settings for <see cref="StreetViewPublishServiceClient"/> instances.</summary>
    public sealed partial class StreetViewPublishServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="StreetViewPublishServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="StreetViewPublishServiceSettings"/>.</returns>
        public static StreetViewPublishServiceSettings GetDefault() => new StreetViewPublishServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="StreetViewPublishServiceSettings"/> object with default settings.
        /// </summary>
        public StreetViewPublishServiceSettings()
        {
        }

        private StreetViewPublishServiceSettings(StreetViewPublishServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            StartUploadSettings = existing.StartUploadSettings;
            CreatePhotoSettings = existing.CreatePhotoSettings;
            GetPhotoSettings = existing.GetPhotoSettings;
            BatchGetPhotosSettings = existing.BatchGetPhotosSettings;
            ListPhotosSettings = existing.ListPhotosSettings;
            UpdatePhotoSettings = existing.UpdatePhotoSettings;
            BatchUpdatePhotosSettings = existing.BatchUpdatePhotosSettings;
            DeletePhotoSettings = existing.DeletePhotoSettings;
            BatchDeletePhotosSettings = existing.BatchDeletePhotosSettings;
            OnCopy(existing);
        }

        partial void OnCopy(StreetViewPublishServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StreetViewPublishServiceClient.StartUpload</c> and <c>StreetViewPublishServiceClient.StartUploadAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StartUploadSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StreetViewPublishServiceClient.CreatePhoto</c> and <c>StreetViewPublishServiceClient.CreatePhotoAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreatePhotoSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StreetViewPublishServiceClient.GetPhoto</c> and <c>StreetViewPublishServiceClient.GetPhotoAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetPhotoSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StreetViewPublishServiceClient.BatchGetPhotos</c> and
        /// <c>StreetViewPublishServiceClient.BatchGetPhotosAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchGetPhotosSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StreetViewPublishServiceClient.ListPhotos</c> and <c>StreetViewPublishServiceClient.ListPhotosAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListPhotosSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StreetViewPublishServiceClient.UpdatePhoto</c> and <c>StreetViewPublishServiceClient.UpdatePhotoAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdatePhotoSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StreetViewPublishServiceClient.BatchUpdatePhotos</c> and
        /// <c>StreetViewPublishServiceClient.BatchUpdatePhotosAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchUpdatePhotosSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StreetViewPublishServiceClient.DeletePhoto</c> and <c>StreetViewPublishServiceClient.DeletePhotoAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeletePhotoSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StreetViewPublishServiceClient.BatchDeletePhotos</c> and
        /// <c>StreetViewPublishServiceClient.BatchDeletePhotosAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchDeletePhotosSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="StreetViewPublishServiceSettings"/> object.</returns>
        public StreetViewPublishServiceSettings Clone() => new StreetViewPublishServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="StreetViewPublishServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class StreetViewPublishServiceClientBuilder : gaxgrpc::ClientBuilderBase<StreetViewPublishServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public StreetViewPublishServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public StreetViewPublishServiceClientBuilder()
        {
            UseJwtAccessWithScopes = StreetViewPublishServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref StreetViewPublishServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<StreetViewPublishServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override StreetViewPublishServiceClient Build()
        {
            StreetViewPublishServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<StreetViewPublishServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<StreetViewPublishServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private StreetViewPublishServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return StreetViewPublishServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<StreetViewPublishServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return StreetViewPublishServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => StreetViewPublishServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => StreetViewPublishServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => StreetViewPublishServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>StreetViewPublishService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Publishes and connects user-contributed photos on Street View.
    /// </remarks>
    public abstract partial class StreetViewPublishServiceClient
    {
        /// <summary>
        /// The default endpoint for the StreetViewPublishService service, which is a host of
        /// "streetviewpublish.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "streetviewpublish.googleapis.com:443";

        /// <summary>The default StreetViewPublishService scopes.</summary>
        /// <remarks>
        /// The default StreetViewPublishService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/streetviewpublish</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/streetviewpublish",
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
        /// Asynchronously creates a <see cref="StreetViewPublishServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="StreetViewPublishServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="StreetViewPublishServiceClient"/>.</returns>
        public static stt::Task<StreetViewPublishServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new StreetViewPublishServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="StreetViewPublishServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="StreetViewPublishServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="StreetViewPublishServiceClient"/>.</returns>
        public static StreetViewPublishServiceClient Create() => new StreetViewPublishServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="StreetViewPublishServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="StreetViewPublishServiceSettings"/>.</param>
        /// <returns>The created <see cref="StreetViewPublishServiceClient"/>.</returns>
        internal static StreetViewPublishServiceClient Create(grpccore::CallInvoker callInvoker, StreetViewPublishServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            StreetViewPublishService.StreetViewPublishServiceClient grpcClient = new StreetViewPublishService.StreetViewPublishServiceClient(callInvoker);
            return new StreetViewPublishServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC StreetViewPublishService client</summary>
        public virtual StreetViewPublishService.StreetViewPublishServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an upload session to start uploading photo bytes. The method uses
        /// the upload URL of the returned
        /// [UploadRef][google.streetview.publish.v1.UploadRef] to upload the bytes for
        /// the [Photo][google.streetview.publish.v1.Photo].
        /// 
        /// In addition to the photo requirements shown in
        /// https://support.google.com/maps/answer/7012050?hl=en&amp;amp;ref_topic=6275604,
        /// the photo must meet the following requirements:
        /// 
        /// * Photo Sphere XMP metadata must be included in the photo medadata. See
        /// https://developers.google.com/streetview/spherical-metadata for the
        /// required fields.
        /// * The pixel size of the photo must meet the size requirements listed in
        /// https://support.google.com/maps/answer/7012050?hl=en&amp;amp;ref_topic=6275604, and
        /// the photo must be a full 360 horizontally.
        /// 
        /// After the upload completes, the method uses
        /// [UploadRef][google.streetview.publish.v1.UploadRef] with
        /// [CreatePhoto][google.streetview.publish.v1.StreetViewPublishService.CreatePhoto]
        /// to create the [Photo][google.streetview.publish.v1.Photo] object entry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UploadRef StartUpload(wkt::Empty request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an upload session to start uploading photo bytes. The method uses
        /// the upload URL of the returned
        /// [UploadRef][google.streetview.publish.v1.UploadRef] to upload the bytes for
        /// the [Photo][google.streetview.publish.v1.Photo].
        /// 
        /// In addition to the photo requirements shown in
        /// https://support.google.com/maps/answer/7012050?hl=en&amp;amp;ref_topic=6275604,
        /// the photo must meet the following requirements:
        /// 
        /// * Photo Sphere XMP metadata must be included in the photo medadata. See
        /// https://developers.google.com/streetview/spherical-metadata for the
        /// required fields.
        /// * The pixel size of the photo must meet the size requirements listed in
        /// https://support.google.com/maps/answer/7012050?hl=en&amp;amp;ref_topic=6275604, and
        /// the photo must be a full 360 horizontally.
        /// 
        /// After the upload completes, the method uses
        /// [UploadRef][google.streetview.publish.v1.UploadRef] with
        /// [CreatePhoto][google.streetview.publish.v1.StreetViewPublishService.CreatePhoto]
        /// to create the [Photo][google.streetview.publish.v1.Photo] object entry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UploadRef> StartUploadAsync(wkt::Empty request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an upload session to start uploading photo bytes. The method uses
        /// the upload URL of the returned
        /// [UploadRef][google.streetview.publish.v1.UploadRef] to upload the bytes for
        /// the [Photo][google.streetview.publish.v1.Photo].
        /// 
        /// In addition to the photo requirements shown in
        /// https://support.google.com/maps/answer/7012050?hl=en&amp;amp;ref_topic=6275604,
        /// the photo must meet the following requirements:
        /// 
        /// * Photo Sphere XMP metadata must be included in the photo medadata. See
        /// https://developers.google.com/streetview/spherical-metadata for the
        /// required fields.
        /// * The pixel size of the photo must meet the size requirements listed in
        /// https://support.google.com/maps/answer/7012050?hl=en&amp;amp;ref_topic=6275604, and
        /// the photo must be a full 360 horizontally.
        /// 
        /// After the upload completes, the method uses
        /// [UploadRef][google.streetview.publish.v1.UploadRef] with
        /// [CreatePhoto][google.streetview.publish.v1.StreetViewPublishService.CreatePhoto]
        /// to create the [Photo][google.streetview.publish.v1.Photo] object entry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UploadRef> StartUploadAsync(wkt::Empty request, st::CancellationToken cancellationToken) =>
            StartUploadAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// After the client finishes uploading the photo with the returned
        /// [UploadRef][google.streetview.publish.v1.UploadRef],
        /// [CreatePhoto][google.streetview.publish.v1.StreetViewPublishService.CreatePhoto]
        /// publishes the uploaded [Photo][google.streetview.publish.v1.Photo] to
        /// Street View on Google Maps.
        /// 
        /// Currently, the only way to set heading, pitch, and roll in CreatePhoto is
        /// through the [Photo Sphere XMP
        /// metadata](https://developers.google.com/streetview/spherical-metadata) in
        /// the photo bytes. CreatePhoto ignores the `pose.heading`, `pose.pitch`,
        /// `pose.roll`, `pose.altitude`, and `pose.level` fields in Pose.
        /// 
        /// This method returns the following error codes:
        /// 
        /// * [google.rpc.Code.INVALID_ARGUMENT][google.rpc.Code.INVALID_ARGUMENT] if
        /// the request is malformed or if the uploaded photo is not a 360 photo.
        /// * [google.rpc.Code.NOT_FOUND][google.rpc.Code.NOT_FOUND] if the upload
        /// reference does not exist.
        /// * [google.rpc.Code.RESOURCE_EXHAUSTED][google.rpc.Code.RESOURCE_EXHAUSTED]
        /// if the account has reached the storage limit.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Photo CreatePhoto(CreatePhotoRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// After the client finishes uploading the photo with the returned
        /// [UploadRef][google.streetview.publish.v1.UploadRef],
        /// [CreatePhoto][google.streetview.publish.v1.StreetViewPublishService.CreatePhoto]
        /// publishes the uploaded [Photo][google.streetview.publish.v1.Photo] to
        /// Street View on Google Maps.
        /// 
        /// Currently, the only way to set heading, pitch, and roll in CreatePhoto is
        /// through the [Photo Sphere XMP
        /// metadata](https://developers.google.com/streetview/spherical-metadata) in
        /// the photo bytes. CreatePhoto ignores the `pose.heading`, `pose.pitch`,
        /// `pose.roll`, `pose.altitude`, and `pose.level` fields in Pose.
        /// 
        /// This method returns the following error codes:
        /// 
        /// * [google.rpc.Code.INVALID_ARGUMENT][google.rpc.Code.INVALID_ARGUMENT] if
        /// the request is malformed or if the uploaded photo is not a 360 photo.
        /// * [google.rpc.Code.NOT_FOUND][google.rpc.Code.NOT_FOUND] if the upload
        /// reference does not exist.
        /// * [google.rpc.Code.RESOURCE_EXHAUSTED][google.rpc.Code.RESOURCE_EXHAUSTED]
        /// if the account has reached the storage limit.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Photo> CreatePhotoAsync(CreatePhotoRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// After the client finishes uploading the photo with the returned
        /// [UploadRef][google.streetview.publish.v1.UploadRef],
        /// [CreatePhoto][google.streetview.publish.v1.StreetViewPublishService.CreatePhoto]
        /// publishes the uploaded [Photo][google.streetview.publish.v1.Photo] to
        /// Street View on Google Maps.
        /// 
        /// Currently, the only way to set heading, pitch, and roll in CreatePhoto is
        /// through the [Photo Sphere XMP
        /// metadata](https://developers.google.com/streetview/spherical-metadata) in
        /// the photo bytes. CreatePhoto ignores the `pose.heading`, `pose.pitch`,
        /// `pose.roll`, `pose.altitude`, and `pose.level` fields in Pose.
        /// 
        /// This method returns the following error codes:
        /// 
        /// * [google.rpc.Code.INVALID_ARGUMENT][google.rpc.Code.INVALID_ARGUMENT] if
        /// the request is malformed or if the uploaded photo is not a 360 photo.
        /// * [google.rpc.Code.NOT_FOUND][google.rpc.Code.NOT_FOUND] if the upload
        /// reference does not exist.
        /// * [google.rpc.Code.RESOURCE_EXHAUSTED][google.rpc.Code.RESOURCE_EXHAUSTED]
        /// if the account has reached the storage limit.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Photo> CreatePhotoAsync(CreatePhotoRequest request, st::CancellationToken cancellationToken) =>
            CreatePhotoAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// After the client finishes uploading the photo with the returned
        /// [UploadRef][google.streetview.publish.v1.UploadRef],
        /// [CreatePhoto][google.streetview.publish.v1.StreetViewPublishService.CreatePhoto]
        /// publishes the uploaded [Photo][google.streetview.publish.v1.Photo] to
        /// Street View on Google Maps.
        /// 
        /// Currently, the only way to set heading, pitch, and roll in CreatePhoto is
        /// through the [Photo Sphere XMP
        /// metadata](https://developers.google.com/streetview/spherical-metadata) in
        /// the photo bytes. CreatePhoto ignores the `pose.heading`, `pose.pitch`,
        /// `pose.roll`, `pose.altitude`, and `pose.level` fields in Pose.
        /// 
        /// This method returns the following error codes:
        /// 
        /// * [google.rpc.Code.INVALID_ARGUMENT][google.rpc.Code.INVALID_ARGUMENT] if
        /// the request is malformed or if the uploaded photo is not a 360 photo.
        /// * [google.rpc.Code.NOT_FOUND][google.rpc.Code.NOT_FOUND] if the upload
        /// reference does not exist.
        /// * [google.rpc.Code.RESOURCE_EXHAUSTED][google.rpc.Code.RESOURCE_EXHAUSTED]
        /// if the account has reached the storage limit.
        /// </summary>
        /// <param name="photo">
        /// Required. Photo to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Photo CreatePhoto(Photo photo, gaxgrpc::CallSettings callSettings = null) =>
            CreatePhoto(new CreatePhotoRequest { Photo = photo, }, callSettings);

        /// <summary>
        /// After the client finishes uploading the photo with the returned
        /// [UploadRef][google.streetview.publish.v1.UploadRef],
        /// [CreatePhoto][google.streetview.publish.v1.StreetViewPublishService.CreatePhoto]
        /// publishes the uploaded [Photo][google.streetview.publish.v1.Photo] to
        /// Street View on Google Maps.
        /// 
        /// Currently, the only way to set heading, pitch, and roll in CreatePhoto is
        /// through the [Photo Sphere XMP
        /// metadata](https://developers.google.com/streetview/spherical-metadata) in
        /// the photo bytes. CreatePhoto ignores the `pose.heading`, `pose.pitch`,
        /// `pose.roll`, `pose.altitude`, and `pose.level` fields in Pose.
        /// 
        /// This method returns the following error codes:
        /// 
        /// * [google.rpc.Code.INVALID_ARGUMENT][google.rpc.Code.INVALID_ARGUMENT] if
        /// the request is malformed or if the uploaded photo is not a 360 photo.
        /// * [google.rpc.Code.NOT_FOUND][google.rpc.Code.NOT_FOUND] if the upload
        /// reference does not exist.
        /// * [google.rpc.Code.RESOURCE_EXHAUSTED][google.rpc.Code.RESOURCE_EXHAUSTED]
        /// if the account has reached the storage limit.
        /// </summary>
        /// <param name="photo">
        /// Required. Photo to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Photo> CreatePhotoAsync(Photo photo, gaxgrpc::CallSettings callSettings = null) =>
            CreatePhotoAsync(new CreatePhotoRequest { Photo = photo, }, callSettings);

        /// <summary>
        /// After the client finishes uploading the photo with the returned
        /// [UploadRef][google.streetview.publish.v1.UploadRef],
        /// [CreatePhoto][google.streetview.publish.v1.StreetViewPublishService.CreatePhoto]
        /// publishes the uploaded [Photo][google.streetview.publish.v1.Photo] to
        /// Street View on Google Maps.
        /// 
        /// Currently, the only way to set heading, pitch, and roll in CreatePhoto is
        /// through the [Photo Sphere XMP
        /// metadata](https://developers.google.com/streetview/spherical-metadata) in
        /// the photo bytes. CreatePhoto ignores the `pose.heading`, `pose.pitch`,
        /// `pose.roll`, `pose.altitude`, and `pose.level` fields in Pose.
        /// 
        /// This method returns the following error codes:
        /// 
        /// * [google.rpc.Code.INVALID_ARGUMENT][google.rpc.Code.INVALID_ARGUMENT] if
        /// the request is malformed or if the uploaded photo is not a 360 photo.
        /// * [google.rpc.Code.NOT_FOUND][google.rpc.Code.NOT_FOUND] if the upload
        /// reference does not exist.
        /// * [google.rpc.Code.RESOURCE_EXHAUSTED][google.rpc.Code.RESOURCE_EXHAUSTED]
        /// if the account has reached the storage limit.
        /// </summary>
        /// <param name="photo">
        /// Required. Photo to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Photo> CreatePhotoAsync(Photo photo, st::CancellationToken cancellationToken) =>
            CreatePhotoAsync(photo, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the metadata of the specified
        /// [Photo][google.streetview.publish.v1.Photo].
        /// 
        /// This method returns the following error codes:
        /// 
        /// * [google.rpc.Code.PERMISSION_DENIED][google.rpc.Code.PERMISSION_DENIED] if
        /// the requesting user did not create the requested
        /// [Photo][google.streetview.publish.v1.Photo].
        /// * [google.rpc.Code.NOT_FOUND][google.rpc.Code.NOT_FOUND] if the requested
        /// [Photo][google.streetview.publish.v1.Photo] does not exist.
        /// * [google.rpc.Code.UNAVAILABLE][google.rpc.Code.UNAVAILABLE] if the
        /// requested [Photo][google.streetview.publish.v1.Photo] is still being
        /// indexed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Photo GetPhoto(GetPhotoRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the metadata of the specified
        /// [Photo][google.streetview.publish.v1.Photo].
        /// 
        /// This method returns the following error codes:
        /// 
        /// * [google.rpc.Code.PERMISSION_DENIED][google.rpc.Code.PERMISSION_DENIED] if
        /// the requesting user did not create the requested
        /// [Photo][google.streetview.publish.v1.Photo].
        /// * [google.rpc.Code.NOT_FOUND][google.rpc.Code.NOT_FOUND] if the requested
        /// [Photo][google.streetview.publish.v1.Photo] does not exist.
        /// * [google.rpc.Code.UNAVAILABLE][google.rpc.Code.UNAVAILABLE] if the
        /// requested [Photo][google.streetview.publish.v1.Photo] is still being
        /// indexed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Photo> GetPhotoAsync(GetPhotoRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the metadata of the specified
        /// [Photo][google.streetview.publish.v1.Photo].
        /// 
        /// This method returns the following error codes:
        /// 
        /// * [google.rpc.Code.PERMISSION_DENIED][google.rpc.Code.PERMISSION_DENIED] if
        /// the requesting user did not create the requested
        /// [Photo][google.streetview.publish.v1.Photo].
        /// * [google.rpc.Code.NOT_FOUND][google.rpc.Code.NOT_FOUND] if the requested
        /// [Photo][google.streetview.publish.v1.Photo] does not exist.
        /// * [google.rpc.Code.UNAVAILABLE][google.rpc.Code.UNAVAILABLE] if the
        /// requested [Photo][google.streetview.publish.v1.Photo] is still being
        /// indexed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Photo> GetPhotoAsync(GetPhotoRequest request, st::CancellationToken cancellationToken) =>
            GetPhotoAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the metadata of the specified
        /// [Photo][google.streetview.publish.v1.Photo].
        /// 
        /// This method returns the following error codes:
        /// 
        /// * [google.rpc.Code.PERMISSION_DENIED][google.rpc.Code.PERMISSION_DENIED] if
        /// the requesting user did not create the requested
        /// [Photo][google.streetview.publish.v1.Photo].
        /// * [google.rpc.Code.NOT_FOUND][google.rpc.Code.NOT_FOUND] if the requested
        /// [Photo][google.streetview.publish.v1.Photo] does not exist.
        /// * [google.rpc.Code.UNAVAILABLE][google.rpc.Code.UNAVAILABLE] if the
        /// requested [Photo][google.streetview.publish.v1.Photo] is still being
        /// indexed.
        /// </summary>
        /// <param name="photoId">
        /// Required. ID of the [Photo][google.streetview.publish.v1.Photo].
        /// </param>
        /// <param name="view">
        /// Specifies if a download URL for the photo bytes should be returned in the
        /// [Photo][google.streetview.publish.v1.Photo] response.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Photo GetPhoto(string photoId, PhotoView view, gaxgrpc::CallSettings callSettings = null) =>
            GetPhoto(new GetPhotoRequest
            {
                PhotoId = photoId ?? "",
                View = view,
            }, callSettings);

        /// <summary>
        /// Gets the metadata of the specified
        /// [Photo][google.streetview.publish.v1.Photo].
        /// 
        /// This method returns the following error codes:
        /// 
        /// * [google.rpc.Code.PERMISSION_DENIED][google.rpc.Code.PERMISSION_DENIED] if
        /// the requesting user did not create the requested
        /// [Photo][google.streetview.publish.v1.Photo].
        /// * [google.rpc.Code.NOT_FOUND][google.rpc.Code.NOT_FOUND] if the requested
        /// [Photo][google.streetview.publish.v1.Photo] does not exist.
        /// * [google.rpc.Code.UNAVAILABLE][google.rpc.Code.UNAVAILABLE] if the
        /// requested [Photo][google.streetview.publish.v1.Photo] is still being
        /// indexed.
        /// </summary>
        /// <param name="photoId">
        /// Required. ID of the [Photo][google.streetview.publish.v1.Photo].
        /// </param>
        /// <param name="view">
        /// Specifies if a download URL for the photo bytes should be returned in the
        /// [Photo][google.streetview.publish.v1.Photo] response.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Photo> GetPhotoAsync(string photoId, PhotoView view, gaxgrpc::CallSettings callSettings = null) =>
            GetPhotoAsync(new GetPhotoRequest
            {
                PhotoId = photoId ?? "",
                View = view,
            }, callSettings);

        /// <summary>
        /// Gets the metadata of the specified
        /// [Photo][google.streetview.publish.v1.Photo].
        /// 
        /// This method returns the following error codes:
        /// 
        /// * [google.rpc.Code.PERMISSION_DENIED][google.rpc.Code.PERMISSION_DENIED] if
        /// the requesting user did not create the requested
        /// [Photo][google.streetview.publish.v1.Photo].
        /// * [google.rpc.Code.NOT_FOUND][google.rpc.Code.NOT_FOUND] if the requested
        /// [Photo][google.streetview.publish.v1.Photo] does not exist.
        /// * [google.rpc.Code.UNAVAILABLE][google.rpc.Code.UNAVAILABLE] if the
        /// requested [Photo][google.streetview.publish.v1.Photo] is still being
        /// indexed.
        /// </summary>
        /// <param name="photoId">
        /// Required. ID of the [Photo][google.streetview.publish.v1.Photo].
        /// </param>
        /// <param name="view">
        /// Specifies if a download URL for the photo bytes should be returned in the
        /// [Photo][google.streetview.publish.v1.Photo] response.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Photo> GetPhotoAsync(string photoId, PhotoView view, st::CancellationToken cancellationToken) =>
            GetPhotoAsync(photoId, view, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the metadata of the specified
        /// [Photo][google.streetview.publish.v1.Photo] batch.
        /// 
        /// Note that if
        /// [BatchGetPhotos][google.streetview.publish.v1.StreetViewPublishService.BatchGetPhotos]
        /// fails, either critical fields are missing or there is an authentication
        /// error. Even if
        /// [BatchGetPhotos][google.streetview.publish.v1.StreetViewPublishService.BatchGetPhotos]
        /// succeeds, individual photos in the batch may have failures.
        /// These failures are specified in each
        /// [PhotoResponse.status][google.streetview.publish.v1.PhotoResponse.status]
        /// in
        /// [BatchGetPhotosResponse.results][google.streetview.publish.v1.BatchGetPhotosResponse.results].
        /// See
        /// [GetPhoto][google.streetview.publish.v1.StreetViewPublishService.GetPhoto]
        /// for specific failures that can occur per photo.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchGetPhotosResponse BatchGetPhotos(BatchGetPhotosRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the metadata of the specified
        /// [Photo][google.streetview.publish.v1.Photo] batch.
        /// 
        /// Note that if
        /// [BatchGetPhotos][google.streetview.publish.v1.StreetViewPublishService.BatchGetPhotos]
        /// fails, either critical fields are missing or there is an authentication
        /// error. Even if
        /// [BatchGetPhotos][google.streetview.publish.v1.StreetViewPublishService.BatchGetPhotos]
        /// succeeds, individual photos in the batch may have failures.
        /// These failures are specified in each
        /// [PhotoResponse.status][google.streetview.publish.v1.PhotoResponse.status]
        /// in
        /// [BatchGetPhotosResponse.results][google.streetview.publish.v1.BatchGetPhotosResponse.results].
        /// See
        /// [GetPhoto][google.streetview.publish.v1.StreetViewPublishService.GetPhoto]
        /// for specific failures that can occur per photo.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchGetPhotosResponse> BatchGetPhotosAsync(BatchGetPhotosRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the metadata of the specified
        /// [Photo][google.streetview.publish.v1.Photo] batch.
        /// 
        /// Note that if
        /// [BatchGetPhotos][google.streetview.publish.v1.StreetViewPublishService.BatchGetPhotos]
        /// fails, either critical fields are missing or there is an authentication
        /// error. Even if
        /// [BatchGetPhotos][google.streetview.publish.v1.StreetViewPublishService.BatchGetPhotos]
        /// succeeds, individual photos in the batch may have failures.
        /// These failures are specified in each
        /// [PhotoResponse.status][google.streetview.publish.v1.PhotoResponse.status]
        /// in
        /// [BatchGetPhotosResponse.results][google.streetview.publish.v1.BatchGetPhotosResponse.results].
        /// See
        /// [GetPhoto][google.streetview.publish.v1.StreetViewPublishService.GetPhoto]
        /// for specific failures that can occur per photo.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchGetPhotosResponse> BatchGetPhotosAsync(BatchGetPhotosRequest request, st::CancellationToken cancellationToken) =>
            BatchGetPhotosAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the metadata of the specified
        /// [Photo][google.streetview.publish.v1.Photo] batch.
        /// 
        /// Note that if
        /// [BatchGetPhotos][google.streetview.publish.v1.StreetViewPublishService.BatchGetPhotos]
        /// fails, either critical fields are missing or there is an authentication
        /// error. Even if
        /// [BatchGetPhotos][google.streetview.publish.v1.StreetViewPublishService.BatchGetPhotos]
        /// succeeds, individual photos in the batch may have failures.
        /// These failures are specified in each
        /// [PhotoResponse.status][google.streetview.publish.v1.PhotoResponse.status]
        /// in
        /// [BatchGetPhotosResponse.results][google.streetview.publish.v1.BatchGetPhotosResponse.results].
        /// See
        /// [GetPhoto][google.streetview.publish.v1.StreetViewPublishService.GetPhoto]
        /// for specific failures that can occur per photo.
        /// </summary>
        /// <param name="photoIds">
        /// Required. IDs of the [Photos][google.streetview.publish.v1.Photo]. HTTP GET
        /// requests require the following syntax for the URL query parameter:
        /// `photoIds=&amp;lt;id1&amp;gt;&amp;amp;photoIds=&amp;lt;id2&amp;gt;&amp;amp;...`.
        /// </param>
        /// <param name="view">
        /// Specifies if a download URL for the photo bytes should be returned in the
        /// Photo response.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchGetPhotosResponse BatchGetPhotos(scg::IEnumerable<string> photoIds, PhotoView view, gaxgrpc::CallSettings callSettings = null) =>
            BatchGetPhotos(new BatchGetPhotosRequest
            {
                PhotoIds =
                {
                    photoIds ?? linq::Enumerable.Empty<string>(),
                },
                View = view,
            }, callSettings);

        /// <summary>
        /// Gets the metadata of the specified
        /// [Photo][google.streetview.publish.v1.Photo] batch.
        /// 
        /// Note that if
        /// [BatchGetPhotos][google.streetview.publish.v1.StreetViewPublishService.BatchGetPhotos]
        /// fails, either critical fields are missing or there is an authentication
        /// error. Even if
        /// [BatchGetPhotos][google.streetview.publish.v1.StreetViewPublishService.BatchGetPhotos]
        /// succeeds, individual photos in the batch may have failures.
        /// These failures are specified in each
        /// [PhotoResponse.status][google.streetview.publish.v1.PhotoResponse.status]
        /// in
        /// [BatchGetPhotosResponse.results][google.streetview.publish.v1.BatchGetPhotosResponse.results].
        /// See
        /// [GetPhoto][google.streetview.publish.v1.StreetViewPublishService.GetPhoto]
        /// for specific failures that can occur per photo.
        /// </summary>
        /// <param name="photoIds">
        /// Required. IDs of the [Photos][google.streetview.publish.v1.Photo]. HTTP GET
        /// requests require the following syntax for the URL query parameter:
        /// `photoIds=&amp;lt;id1&amp;gt;&amp;amp;photoIds=&amp;lt;id2&amp;gt;&amp;amp;...`.
        /// </param>
        /// <param name="view">
        /// Specifies if a download URL for the photo bytes should be returned in the
        /// Photo response.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchGetPhotosResponse> BatchGetPhotosAsync(scg::IEnumerable<string> photoIds, PhotoView view, gaxgrpc::CallSettings callSettings = null) =>
            BatchGetPhotosAsync(new BatchGetPhotosRequest
            {
                PhotoIds =
                {
                    photoIds ?? linq::Enumerable.Empty<string>(),
                },
                View = view,
            }, callSettings);

        /// <summary>
        /// Gets the metadata of the specified
        /// [Photo][google.streetview.publish.v1.Photo] batch.
        /// 
        /// Note that if
        /// [BatchGetPhotos][google.streetview.publish.v1.StreetViewPublishService.BatchGetPhotos]
        /// fails, either critical fields are missing or there is an authentication
        /// error. Even if
        /// [BatchGetPhotos][google.streetview.publish.v1.StreetViewPublishService.BatchGetPhotos]
        /// succeeds, individual photos in the batch may have failures.
        /// These failures are specified in each
        /// [PhotoResponse.status][google.streetview.publish.v1.PhotoResponse.status]
        /// in
        /// [BatchGetPhotosResponse.results][google.streetview.publish.v1.BatchGetPhotosResponse.results].
        /// See
        /// [GetPhoto][google.streetview.publish.v1.StreetViewPublishService.GetPhoto]
        /// for specific failures that can occur per photo.
        /// </summary>
        /// <param name="photoIds">
        /// Required. IDs of the [Photos][google.streetview.publish.v1.Photo]. HTTP GET
        /// requests require the following syntax for the URL query parameter:
        /// `photoIds=&amp;lt;id1&amp;gt;&amp;amp;photoIds=&amp;lt;id2&amp;gt;&amp;amp;...`.
        /// </param>
        /// <param name="view">
        /// Specifies if a download URL for the photo bytes should be returned in the
        /// Photo response.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchGetPhotosResponse> BatchGetPhotosAsync(scg::IEnumerable<string> photoIds, PhotoView view, st::CancellationToken cancellationToken) =>
            BatchGetPhotosAsync(photoIds, view, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all the [Photos][google.streetview.publish.v1.Photo] that belong to
        /// the user.
        /// 
        /// &amp;lt;aside class="note"&amp;gt;&amp;lt;b&amp;gt;Note:&amp;lt;/b&amp;gt; Recently created photos that are still
        /// being indexed are not returned in the response.&amp;lt;/aside&amp;gt;
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Photo"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPhotosResponse, Photo> ListPhotos(ListPhotosRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the [Photos][google.streetview.publish.v1.Photo] that belong to
        /// the user.
        /// 
        /// &amp;lt;aside class="note"&amp;gt;&amp;lt;b&amp;gt;Note:&amp;lt;/b&amp;gt; Recently created photos that are still
        /// being indexed are not returned in the response.&amp;lt;/aside&amp;gt;
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Photo"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPhotosResponse, Photo> ListPhotosAsync(ListPhotosRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all the [Photos][google.streetview.publish.v1.Photo] that belong to
        /// the user.
        /// 
        /// &amp;lt;aside class="note"&amp;gt;&amp;lt;b&amp;gt;Note:&amp;lt;/b&amp;gt; Recently created photos that are still
        /// being indexed are not returned in the response.&amp;lt;/aside&amp;gt;
        /// </summary>
        /// <param name="view">
        /// Specifies if a download URL for the photos bytes should be returned in the
        /// Photos response.
        /// </param>
        /// <param name="filter">
        /// The filter expression. For example: `placeId=ChIJj61dQgK6j4AR4GeTYWZsKWw`.
        /// 
        /// The only filter supported at the moment is `placeId`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Photo"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPhotosResponse, Photo> ListPhotos(PhotoView view, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListPhotos(new ListPhotosRequest
            {
                View = view,
                Filter = filter ?? "",
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all the [Photos][google.streetview.publish.v1.Photo] that belong to
        /// the user.
        /// 
        /// &amp;lt;aside class="note"&amp;gt;&amp;lt;b&amp;gt;Note:&amp;lt;/b&amp;gt; Recently created photos that are still
        /// being indexed are not returned in the response.&amp;lt;/aside&amp;gt;
        /// </summary>
        /// <param name="view">
        /// Specifies if a download URL for the photos bytes should be returned in the
        /// Photos response.
        /// </param>
        /// <param name="filter">
        /// The filter expression. For example: `placeId=ChIJj61dQgK6j4AR4GeTYWZsKWw`.
        /// 
        /// The only filter supported at the moment is `placeId`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Photo"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPhotosResponse, Photo> ListPhotosAsync(PhotoView view, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListPhotosAsync(new ListPhotosRequest
            {
                View = view,
                Filter = filter ?? "",
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Updates the metadata of a [Photo][google.streetview.publish.v1.Photo], such
        /// as pose, place association, connections, etc. Changing the pixels of a
        /// photo is not supported.
        /// 
        /// Only the fields specified in the
        /// [updateMask][google.streetview.publish.v1.UpdatePhotoRequest.update_mask]
        /// field are used. If `updateMask` is not present, the update applies to all
        /// fields.
        /// 
        /// This method returns the following error codes:
        /// 
        /// * [google.rpc.Code.PERMISSION_DENIED][google.rpc.Code.PERMISSION_DENIED] if
        /// the requesting user did not create the requested photo.
        /// * [google.rpc.Code.INVALID_ARGUMENT][google.rpc.Code.INVALID_ARGUMENT] if
        /// the request is malformed.
        /// * [google.rpc.Code.NOT_FOUND][google.rpc.Code.NOT_FOUND] if the requested
        /// photo does not exist.
        /// * [google.rpc.Code.UNAVAILABLE][google.rpc.Code.UNAVAILABLE] if the
        /// requested [Photo][google.streetview.publish.v1.Photo] is still being
        /// indexed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Photo UpdatePhoto(UpdatePhotoRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the metadata of a [Photo][google.streetview.publish.v1.Photo], such
        /// as pose, place association, connections, etc. Changing the pixels of a
        /// photo is not supported.
        /// 
        /// Only the fields specified in the
        /// [updateMask][google.streetview.publish.v1.UpdatePhotoRequest.update_mask]
        /// field are used. If `updateMask` is not present, the update applies to all
        /// fields.
        /// 
        /// This method returns the following error codes:
        /// 
        /// * [google.rpc.Code.PERMISSION_DENIED][google.rpc.Code.PERMISSION_DENIED] if
        /// the requesting user did not create the requested photo.
        /// * [google.rpc.Code.INVALID_ARGUMENT][google.rpc.Code.INVALID_ARGUMENT] if
        /// the request is malformed.
        /// * [google.rpc.Code.NOT_FOUND][google.rpc.Code.NOT_FOUND] if the requested
        /// photo does not exist.
        /// * [google.rpc.Code.UNAVAILABLE][google.rpc.Code.UNAVAILABLE] if the
        /// requested [Photo][google.streetview.publish.v1.Photo] is still being
        /// indexed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Photo> UpdatePhotoAsync(UpdatePhotoRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the metadata of a [Photo][google.streetview.publish.v1.Photo], such
        /// as pose, place association, connections, etc. Changing the pixels of a
        /// photo is not supported.
        /// 
        /// Only the fields specified in the
        /// [updateMask][google.streetview.publish.v1.UpdatePhotoRequest.update_mask]
        /// field are used. If `updateMask` is not present, the update applies to all
        /// fields.
        /// 
        /// This method returns the following error codes:
        /// 
        /// * [google.rpc.Code.PERMISSION_DENIED][google.rpc.Code.PERMISSION_DENIED] if
        /// the requesting user did not create the requested photo.
        /// * [google.rpc.Code.INVALID_ARGUMENT][google.rpc.Code.INVALID_ARGUMENT] if
        /// the request is malformed.
        /// * [google.rpc.Code.NOT_FOUND][google.rpc.Code.NOT_FOUND] if the requested
        /// photo does not exist.
        /// * [google.rpc.Code.UNAVAILABLE][google.rpc.Code.UNAVAILABLE] if the
        /// requested [Photo][google.streetview.publish.v1.Photo] is still being
        /// indexed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Photo> UpdatePhotoAsync(UpdatePhotoRequest request, st::CancellationToken cancellationToken) =>
            UpdatePhotoAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the metadata of a [Photo][google.streetview.publish.v1.Photo], such
        /// as pose, place association, connections, etc. Changing the pixels of a
        /// photo is not supported.
        /// 
        /// Only the fields specified in the
        /// [updateMask][google.streetview.publish.v1.UpdatePhotoRequest.update_mask]
        /// field are used. If `updateMask` is not present, the update applies to all
        /// fields.
        /// 
        /// This method returns the following error codes:
        /// 
        /// * [google.rpc.Code.PERMISSION_DENIED][google.rpc.Code.PERMISSION_DENIED] if
        /// the requesting user did not create the requested photo.
        /// * [google.rpc.Code.INVALID_ARGUMENT][google.rpc.Code.INVALID_ARGUMENT] if
        /// the request is malformed.
        /// * [google.rpc.Code.NOT_FOUND][google.rpc.Code.NOT_FOUND] if the requested
        /// photo does not exist.
        /// * [google.rpc.Code.UNAVAILABLE][google.rpc.Code.UNAVAILABLE] if the
        /// requested [Photo][google.streetview.publish.v1.Photo] is still being
        /// indexed.
        /// </summary>
        /// <param name="photo">
        /// Required. [Photo][google.streetview.publish.v1.Photo] object containing the
        /// new metadata.
        /// </param>
        /// <param name="updateMask">
        /// Mask that identifies fields on the photo metadata to update.
        /// If not present, the old [Photo][google.streetview.publish.v1.Photo]
        /// metadata is entirely replaced with the
        /// new [Photo][google.streetview.publish.v1.Photo] metadata in this request.
        /// The update fails if invalid fields are specified. Multiple fields can be
        /// specified in a comma-delimited list.
        /// 
        /// The following fields are valid:
        /// 
        /// * `pose.heading`
        /// * `pose.latLngPair`
        /// * `pose.pitch`
        /// * `pose.roll`
        /// * `pose.level`
        /// * `pose.altitude`
        /// * `connections`
        /// * `places`
        /// 
        /// 
        /// &amp;lt;aside class="note"&amp;gt;&amp;lt;b&amp;gt;Note:&amp;lt;/b&amp;gt;  When
        /// [updateMask][google.streetview.publish.v1.UpdatePhotoRequest.update_mask]
        /// contains repeated fields, the entire set of repeated values get replaced
        /// with the new contents. For example, if
        /// [updateMask][google.streetview.publish.v1.UpdatePhotoRequest.update_mask]
        /// contains `connections` and `UpdatePhotoRequest.photo.connections` is empty,
        /// all connections are removed.&amp;lt;/aside&amp;gt;
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Photo UpdatePhoto(Photo photo, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePhoto(new UpdatePhotoRequest
            {
                Photo = photo,
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the metadata of a [Photo][google.streetview.publish.v1.Photo], such
        /// as pose, place association, connections, etc. Changing the pixels of a
        /// photo is not supported.
        /// 
        /// Only the fields specified in the
        /// [updateMask][google.streetview.publish.v1.UpdatePhotoRequest.update_mask]
        /// field are used. If `updateMask` is not present, the update applies to all
        /// fields.
        /// 
        /// This method returns the following error codes:
        /// 
        /// * [google.rpc.Code.PERMISSION_DENIED][google.rpc.Code.PERMISSION_DENIED] if
        /// the requesting user did not create the requested photo.
        /// * [google.rpc.Code.INVALID_ARGUMENT][google.rpc.Code.INVALID_ARGUMENT] if
        /// the request is malformed.
        /// * [google.rpc.Code.NOT_FOUND][google.rpc.Code.NOT_FOUND] if the requested
        /// photo does not exist.
        /// * [google.rpc.Code.UNAVAILABLE][google.rpc.Code.UNAVAILABLE] if the
        /// requested [Photo][google.streetview.publish.v1.Photo] is still being
        /// indexed.
        /// </summary>
        /// <param name="photo">
        /// Required. [Photo][google.streetview.publish.v1.Photo] object containing the
        /// new metadata.
        /// </param>
        /// <param name="updateMask">
        /// Mask that identifies fields on the photo metadata to update.
        /// If not present, the old [Photo][google.streetview.publish.v1.Photo]
        /// metadata is entirely replaced with the
        /// new [Photo][google.streetview.publish.v1.Photo] metadata in this request.
        /// The update fails if invalid fields are specified. Multiple fields can be
        /// specified in a comma-delimited list.
        /// 
        /// The following fields are valid:
        /// 
        /// * `pose.heading`
        /// * `pose.latLngPair`
        /// * `pose.pitch`
        /// * `pose.roll`
        /// * `pose.level`
        /// * `pose.altitude`
        /// * `connections`
        /// * `places`
        /// 
        /// 
        /// &amp;lt;aside class="note"&amp;gt;&amp;lt;b&amp;gt;Note:&amp;lt;/b&amp;gt;  When
        /// [updateMask][google.streetview.publish.v1.UpdatePhotoRequest.update_mask]
        /// contains repeated fields, the entire set of repeated values get replaced
        /// with the new contents. For example, if
        /// [updateMask][google.streetview.publish.v1.UpdatePhotoRequest.update_mask]
        /// contains `connections` and `UpdatePhotoRequest.photo.connections` is empty,
        /// all connections are removed.&amp;lt;/aside&amp;gt;
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Photo> UpdatePhotoAsync(Photo photo, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePhotoAsync(new UpdatePhotoRequest
            {
                Photo = photo,
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the metadata of a [Photo][google.streetview.publish.v1.Photo], such
        /// as pose, place association, connections, etc. Changing the pixels of a
        /// photo is not supported.
        /// 
        /// Only the fields specified in the
        /// [updateMask][google.streetview.publish.v1.UpdatePhotoRequest.update_mask]
        /// field are used. If `updateMask` is not present, the update applies to all
        /// fields.
        /// 
        /// This method returns the following error codes:
        /// 
        /// * [google.rpc.Code.PERMISSION_DENIED][google.rpc.Code.PERMISSION_DENIED] if
        /// the requesting user did not create the requested photo.
        /// * [google.rpc.Code.INVALID_ARGUMENT][google.rpc.Code.INVALID_ARGUMENT] if
        /// the request is malformed.
        /// * [google.rpc.Code.NOT_FOUND][google.rpc.Code.NOT_FOUND] if the requested
        /// photo does not exist.
        /// * [google.rpc.Code.UNAVAILABLE][google.rpc.Code.UNAVAILABLE] if the
        /// requested [Photo][google.streetview.publish.v1.Photo] is still being
        /// indexed.
        /// </summary>
        /// <param name="photo">
        /// Required. [Photo][google.streetview.publish.v1.Photo] object containing the
        /// new metadata.
        /// </param>
        /// <param name="updateMask">
        /// Mask that identifies fields on the photo metadata to update.
        /// If not present, the old [Photo][google.streetview.publish.v1.Photo]
        /// metadata is entirely replaced with the
        /// new [Photo][google.streetview.publish.v1.Photo] metadata in this request.
        /// The update fails if invalid fields are specified. Multiple fields can be
        /// specified in a comma-delimited list.
        /// 
        /// The following fields are valid:
        /// 
        /// * `pose.heading`
        /// * `pose.latLngPair`
        /// * `pose.pitch`
        /// * `pose.roll`
        /// * `pose.level`
        /// * `pose.altitude`
        /// * `connections`
        /// * `places`
        /// 
        /// 
        /// &amp;lt;aside class="note"&amp;gt;&amp;lt;b&amp;gt;Note:&amp;lt;/b&amp;gt;  When
        /// [updateMask][google.streetview.publish.v1.UpdatePhotoRequest.update_mask]
        /// contains repeated fields, the entire set of repeated values get replaced
        /// with the new contents. For example, if
        /// [updateMask][google.streetview.publish.v1.UpdatePhotoRequest.update_mask]
        /// contains `connections` and `UpdatePhotoRequest.photo.connections` is empty,
        /// all connections are removed.&amp;lt;/aside&amp;gt;
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Photo> UpdatePhotoAsync(Photo photo, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdatePhotoAsync(photo, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the metadata of [Photos][google.streetview.publish.v1.Photo], such
        /// as pose, place association, connections, etc. Changing the pixels of photos
        /// is not supported.
        /// 
        /// Note that if
        /// [BatchUpdatePhotos][google.streetview.publish.v1.StreetViewPublishService.BatchUpdatePhotos]
        /// fails, either critical fields are missing or there is an authentication
        /// error. Even if
        /// [BatchUpdatePhotos][google.streetview.publish.v1.StreetViewPublishService.BatchUpdatePhotos]
        /// succeeds, individual photos in the batch may have failures.
        /// These failures are specified in each
        /// [PhotoResponse.status][google.streetview.publish.v1.PhotoResponse.status]
        /// in
        /// [BatchUpdatePhotosResponse.results][google.streetview.publish.v1.BatchUpdatePhotosResponse.results].
        /// See
        /// [UpdatePhoto][google.streetview.publish.v1.StreetViewPublishService.UpdatePhoto]
        /// for specific failures that can occur per photo.
        /// 
        /// Only the fields specified in
        /// [updateMask][google.streetview.publish.v1.UpdatePhotoRequest.update_mask]
        /// field are used. If `updateMask` is not present, the update applies to all
        /// fields.
        /// 
        /// The number of
        /// [UpdatePhotoRequest][google.streetview.publish.v1.UpdatePhotoRequest]
        /// messages in a
        /// [BatchUpdatePhotosRequest][google.streetview.publish.v1.BatchUpdatePhotosRequest]
        /// must not exceed 20.
        /// 
        /// &amp;lt;aside class="note"&amp;gt;&amp;lt;b&amp;gt;Note:&amp;lt;/b&amp;gt; To update
        /// [Pose.altitude][google.streetview.publish.v1.Pose.altitude],
        /// [Pose.latLngPair][google.streetview.publish.v1.Pose.lat_lng_pair] has to be
        /// filled as well. Otherwise, the request will fail.&amp;lt;/aside&amp;gt;
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdatePhotosResponse BatchUpdatePhotos(BatchUpdatePhotosRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the metadata of [Photos][google.streetview.publish.v1.Photo], such
        /// as pose, place association, connections, etc. Changing the pixels of photos
        /// is not supported.
        /// 
        /// Note that if
        /// [BatchUpdatePhotos][google.streetview.publish.v1.StreetViewPublishService.BatchUpdatePhotos]
        /// fails, either critical fields are missing or there is an authentication
        /// error. Even if
        /// [BatchUpdatePhotos][google.streetview.publish.v1.StreetViewPublishService.BatchUpdatePhotos]
        /// succeeds, individual photos in the batch may have failures.
        /// These failures are specified in each
        /// [PhotoResponse.status][google.streetview.publish.v1.PhotoResponse.status]
        /// in
        /// [BatchUpdatePhotosResponse.results][google.streetview.publish.v1.BatchUpdatePhotosResponse.results].
        /// See
        /// [UpdatePhoto][google.streetview.publish.v1.StreetViewPublishService.UpdatePhoto]
        /// for specific failures that can occur per photo.
        /// 
        /// Only the fields specified in
        /// [updateMask][google.streetview.publish.v1.UpdatePhotoRequest.update_mask]
        /// field are used. If `updateMask` is not present, the update applies to all
        /// fields.
        /// 
        /// The number of
        /// [UpdatePhotoRequest][google.streetview.publish.v1.UpdatePhotoRequest]
        /// messages in a
        /// [BatchUpdatePhotosRequest][google.streetview.publish.v1.BatchUpdatePhotosRequest]
        /// must not exceed 20.
        /// 
        /// &amp;lt;aside class="note"&amp;gt;&amp;lt;b&amp;gt;Note:&amp;lt;/b&amp;gt; To update
        /// [Pose.altitude][google.streetview.publish.v1.Pose.altitude],
        /// [Pose.latLngPair][google.streetview.publish.v1.Pose.lat_lng_pair] has to be
        /// filled as well. Otherwise, the request will fail.&amp;lt;/aside&amp;gt;
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdatePhotosResponse> BatchUpdatePhotosAsync(BatchUpdatePhotosRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the metadata of [Photos][google.streetview.publish.v1.Photo], such
        /// as pose, place association, connections, etc. Changing the pixels of photos
        /// is not supported.
        /// 
        /// Note that if
        /// [BatchUpdatePhotos][google.streetview.publish.v1.StreetViewPublishService.BatchUpdatePhotos]
        /// fails, either critical fields are missing or there is an authentication
        /// error. Even if
        /// [BatchUpdatePhotos][google.streetview.publish.v1.StreetViewPublishService.BatchUpdatePhotos]
        /// succeeds, individual photos in the batch may have failures.
        /// These failures are specified in each
        /// [PhotoResponse.status][google.streetview.publish.v1.PhotoResponse.status]
        /// in
        /// [BatchUpdatePhotosResponse.results][google.streetview.publish.v1.BatchUpdatePhotosResponse.results].
        /// See
        /// [UpdatePhoto][google.streetview.publish.v1.StreetViewPublishService.UpdatePhoto]
        /// for specific failures that can occur per photo.
        /// 
        /// Only the fields specified in
        /// [updateMask][google.streetview.publish.v1.UpdatePhotoRequest.update_mask]
        /// field are used. If `updateMask` is not present, the update applies to all
        /// fields.
        /// 
        /// The number of
        /// [UpdatePhotoRequest][google.streetview.publish.v1.UpdatePhotoRequest]
        /// messages in a
        /// [BatchUpdatePhotosRequest][google.streetview.publish.v1.BatchUpdatePhotosRequest]
        /// must not exceed 20.
        /// 
        /// &amp;lt;aside class="note"&amp;gt;&amp;lt;b&amp;gt;Note:&amp;lt;/b&amp;gt; To update
        /// [Pose.altitude][google.streetview.publish.v1.Pose.altitude],
        /// [Pose.latLngPair][google.streetview.publish.v1.Pose.lat_lng_pair] has to be
        /// filled as well. Otherwise, the request will fail.&amp;lt;/aside&amp;gt;
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdatePhotosResponse> BatchUpdatePhotosAsync(BatchUpdatePhotosRequest request, st::CancellationToken cancellationToken) =>
            BatchUpdatePhotosAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the metadata of [Photos][google.streetview.publish.v1.Photo], such
        /// as pose, place association, connections, etc. Changing the pixels of photos
        /// is not supported.
        /// 
        /// Note that if
        /// [BatchUpdatePhotos][google.streetview.publish.v1.StreetViewPublishService.BatchUpdatePhotos]
        /// fails, either critical fields are missing or there is an authentication
        /// error. Even if
        /// [BatchUpdatePhotos][google.streetview.publish.v1.StreetViewPublishService.BatchUpdatePhotos]
        /// succeeds, individual photos in the batch may have failures.
        /// These failures are specified in each
        /// [PhotoResponse.status][google.streetview.publish.v1.PhotoResponse.status]
        /// in
        /// [BatchUpdatePhotosResponse.results][google.streetview.publish.v1.BatchUpdatePhotosResponse.results].
        /// See
        /// [UpdatePhoto][google.streetview.publish.v1.StreetViewPublishService.UpdatePhoto]
        /// for specific failures that can occur per photo.
        /// 
        /// Only the fields specified in
        /// [updateMask][google.streetview.publish.v1.UpdatePhotoRequest.update_mask]
        /// field are used. If `updateMask` is not present, the update applies to all
        /// fields.
        /// 
        /// The number of
        /// [UpdatePhotoRequest][google.streetview.publish.v1.UpdatePhotoRequest]
        /// messages in a
        /// [BatchUpdatePhotosRequest][google.streetview.publish.v1.BatchUpdatePhotosRequest]
        /// must not exceed 20.
        /// 
        /// &amp;lt;aside class="note"&amp;gt;&amp;lt;b&amp;gt;Note:&amp;lt;/b&amp;gt; To update
        /// [Pose.altitude][google.streetview.publish.v1.Pose.altitude],
        /// [Pose.latLngPair][google.streetview.publish.v1.Pose.lat_lng_pair] has to be
        /// filled as well. Otherwise, the request will fail.&amp;lt;/aside&amp;gt;
        /// </summary>
        /// <param name="updatePhotoRequests">
        /// Required. List of
        /// [UpdatePhotoRequests][google.streetview.publish.v1.UpdatePhotoRequest].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdatePhotosResponse BatchUpdatePhotos(scg::IEnumerable<UpdatePhotoRequest> updatePhotoRequests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdatePhotos(new BatchUpdatePhotosRequest
            {
                UpdatePhotoRequests =
                {
                    updatePhotoRequests ?? linq::Enumerable.Empty<UpdatePhotoRequest>(),
                },
            }, callSettings);

        /// <summary>
        /// Updates the metadata of [Photos][google.streetview.publish.v1.Photo], such
        /// as pose, place association, connections, etc. Changing the pixels of photos
        /// is not supported.
        /// 
        /// Note that if
        /// [BatchUpdatePhotos][google.streetview.publish.v1.StreetViewPublishService.BatchUpdatePhotos]
        /// fails, either critical fields are missing or there is an authentication
        /// error. Even if
        /// [BatchUpdatePhotos][google.streetview.publish.v1.StreetViewPublishService.BatchUpdatePhotos]
        /// succeeds, individual photos in the batch may have failures.
        /// These failures are specified in each
        /// [PhotoResponse.status][google.streetview.publish.v1.PhotoResponse.status]
        /// in
        /// [BatchUpdatePhotosResponse.results][google.streetview.publish.v1.BatchUpdatePhotosResponse.results].
        /// See
        /// [UpdatePhoto][google.streetview.publish.v1.StreetViewPublishService.UpdatePhoto]
        /// for specific failures that can occur per photo.
        /// 
        /// Only the fields specified in
        /// [updateMask][google.streetview.publish.v1.UpdatePhotoRequest.update_mask]
        /// field are used. If `updateMask` is not present, the update applies to all
        /// fields.
        /// 
        /// The number of
        /// [UpdatePhotoRequest][google.streetview.publish.v1.UpdatePhotoRequest]
        /// messages in a
        /// [BatchUpdatePhotosRequest][google.streetview.publish.v1.BatchUpdatePhotosRequest]
        /// must not exceed 20.
        /// 
        /// &amp;lt;aside class="note"&amp;gt;&amp;lt;b&amp;gt;Note:&amp;lt;/b&amp;gt; To update
        /// [Pose.altitude][google.streetview.publish.v1.Pose.altitude],
        /// [Pose.latLngPair][google.streetview.publish.v1.Pose.lat_lng_pair] has to be
        /// filled as well. Otherwise, the request will fail.&amp;lt;/aside&amp;gt;
        /// </summary>
        /// <param name="updatePhotoRequests">
        /// Required. List of
        /// [UpdatePhotoRequests][google.streetview.publish.v1.UpdatePhotoRequest].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdatePhotosResponse> BatchUpdatePhotosAsync(scg::IEnumerable<UpdatePhotoRequest> updatePhotoRequests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdatePhotosAsync(new BatchUpdatePhotosRequest
            {
                UpdatePhotoRequests =
                {
                    updatePhotoRequests ?? linq::Enumerable.Empty<UpdatePhotoRequest>(),
                },
            }, callSettings);

        /// <summary>
        /// Updates the metadata of [Photos][google.streetview.publish.v1.Photo], such
        /// as pose, place association, connections, etc. Changing the pixels of photos
        /// is not supported.
        /// 
        /// Note that if
        /// [BatchUpdatePhotos][google.streetview.publish.v1.StreetViewPublishService.BatchUpdatePhotos]
        /// fails, either critical fields are missing or there is an authentication
        /// error. Even if
        /// [BatchUpdatePhotos][google.streetview.publish.v1.StreetViewPublishService.BatchUpdatePhotos]
        /// succeeds, individual photos in the batch may have failures.
        /// These failures are specified in each
        /// [PhotoResponse.status][google.streetview.publish.v1.PhotoResponse.status]
        /// in
        /// [BatchUpdatePhotosResponse.results][google.streetview.publish.v1.BatchUpdatePhotosResponse.results].
        /// See
        /// [UpdatePhoto][google.streetview.publish.v1.StreetViewPublishService.UpdatePhoto]
        /// for specific failures that can occur per photo.
        /// 
        /// Only the fields specified in
        /// [updateMask][google.streetview.publish.v1.UpdatePhotoRequest.update_mask]
        /// field are used. If `updateMask` is not present, the update applies to all
        /// fields.
        /// 
        /// The number of
        /// [UpdatePhotoRequest][google.streetview.publish.v1.UpdatePhotoRequest]
        /// messages in a
        /// [BatchUpdatePhotosRequest][google.streetview.publish.v1.BatchUpdatePhotosRequest]
        /// must not exceed 20.
        /// 
        /// &amp;lt;aside class="note"&amp;gt;&amp;lt;b&amp;gt;Note:&amp;lt;/b&amp;gt; To update
        /// [Pose.altitude][google.streetview.publish.v1.Pose.altitude],
        /// [Pose.latLngPair][google.streetview.publish.v1.Pose.lat_lng_pair] has to be
        /// filled as well. Otherwise, the request will fail.&amp;lt;/aside&amp;gt;
        /// </summary>
        /// <param name="updatePhotoRequests">
        /// Required. List of
        /// [UpdatePhotoRequests][google.streetview.publish.v1.UpdatePhotoRequest].
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdatePhotosResponse> BatchUpdatePhotosAsync(scg::IEnumerable<UpdatePhotoRequest> updatePhotoRequests, st::CancellationToken cancellationToken) =>
            BatchUpdatePhotosAsync(updatePhotoRequests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a [Photo][google.streetview.publish.v1.Photo] and its metadata.
        /// 
        /// This method returns the following error codes:
        /// 
        /// * [google.rpc.Code.PERMISSION_DENIED][google.rpc.Code.PERMISSION_DENIED] if
        /// the requesting user did not create the requested photo.
        /// * [google.rpc.Code.NOT_FOUND][google.rpc.Code.NOT_FOUND] if the photo ID
        /// does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeletePhoto(DeletePhotoRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a [Photo][google.streetview.publish.v1.Photo] and its metadata.
        /// 
        /// This method returns the following error codes:
        /// 
        /// * [google.rpc.Code.PERMISSION_DENIED][google.rpc.Code.PERMISSION_DENIED] if
        /// the requesting user did not create the requested photo.
        /// * [google.rpc.Code.NOT_FOUND][google.rpc.Code.NOT_FOUND] if the photo ID
        /// does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePhotoAsync(DeletePhotoRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a [Photo][google.streetview.publish.v1.Photo] and its metadata.
        /// 
        /// This method returns the following error codes:
        /// 
        /// * [google.rpc.Code.PERMISSION_DENIED][google.rpc.Code.PERMISSION_DENIED] if
        /// the requesting user did not create the requested photo.
        /// * [google.rpc.Code.NOT_FOUND][google.rpc.Code.NOT_FOUND] if the photo ID
        /// does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePhotoAsync(DeletePhotoRequest request, st::CancellationToken cancellationToken) =>
            DeletePhotoAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a [Photo][google.streetview.publish.v1.Photo] and its metadata.
        /// 
        /// This method returns the following error codes:
        /// 
        /// * [google.rpc.Code.PERMISSION_DENIED][google.rpc.Code.PERMISSION_DENIED] if
        /// the requesting user did not create the requested photo.
        /// * [google.rpc.Code.NOT_FOUND][google.rpc.Code.NOT_FOUND] if the photo ID
        /// does not exist.
        /// </summary>
        /// <param name="photoId">
        /// Required. ID of the [Photo][google.streetview.publish.v1.Photo].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeletePhoto(string photoId, gaxgrpc::CallSettings callSettings = null) =>
            DeletePhoto(new DeletePhotoRequest
            {
                PhotoId = photoId ?? "",
            }, callSettings);

        /// <summary>
        /// Deletes a [Photo][google.streetview.publish.v1.Photo] and its metadata.
        /// 
        /// This method returns the following error codes:
        /// 
        /// * [google.rpc.Code.PERMISSION_DENIED][google.rpc.Code.PERMISSION_DENIED] if
        /// the requesting user did not create the requested photo.
        /// * [google.rpc.Code.NOT_FOUND][google.rpc.Code.NOT_FOUND] if the photo ID
        /// does not exist.
        /// </summary>
        /// <param name="photoId">
        /// Required. ID of the [Photo][google.streetview.publish.v1.Photo].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePhotoAsync(string photoId, gaxgrpc::CallSettings callSettings = null) =>
            DeletePhotoAsync(new DeletePhotoRequest
            {
                PhotoId = photoId ?? "",
            }, callSettings);

        /// <summary>
        /// Deletes a [Photo][google.streetview.publish.v1.Photo] and its metadata.
        /// 
        /// This method returns the following error codes:
        /// 
        /// * [google.rpc.Code.PERMISSION_DENIED][google.rpc.Code.PERMISSION_DENIED] if
        /// the requesting user did not create the requested photo.
        /// * [google.rpc.Code.NOT_FOUND][google.rpc.Code.NOT_FOUND] if the photo ID
        /// does not exist.
        /// </summary>
        /// <param name="photoId">
        /// Required. ID of the [Photo][google.streetview.publish.v1.Photo].
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePhotoAsync(string photoId, st::CancellationToken cancellationToken) =>
            DeletePhotoAsync(photoId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a list of [Photos][google.streetview.publish.v1.Photo] and their
        /// metadata.
        /// 
        /// Note that if
        /// [BatchDeletePhotos][google.streetview.publish.v1.StreetViewPublishService.BatchDeletePhotos]
        /// fails, either critical fields are missing or there was an authentication
        /// error. Even if
        /// [BatchDeletePhotos][google.streetview.publish.v1.StreetViewPublishService.BatchDeletePhotos]
        /// succeeds, individual photos in the batch may have failures.
        /// These failures are specified in each
        /// [PhotoResponse.status][google.streetview.publish.v1.PhotoResponse.status]
        /// in
        /// [BatchDeletePhotosResponse.results][google.streetview.publish.v1.BatchDeletePhotosResponse.status].
        /// See
        /// [DeletePhoto][google.streetview.publish.v1.StreetViewPublishService.DeletePhoto]
        /// for specific failures that can occur per photo.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchDeletePhotosResponse BatchDeletePhotos(BatchDeletePhotosRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a list of [Photos][google.streetview.publish.v1.Photo] and their
        /// metadata.
        /// 
        /// Note that if
        /// [BatchDeletePhotos][google.streetview.publish.v1.StreetViewPublishService.BatchDeletePhotos]
        /// fails, either critical fields are missing or there was an authentication
        /// error. Even if
        /// [BatchDeletePhotos][google.streetview.publish.v1.StreetViewPublishService.BatchDeletePhotos]
        /// succeeds, individual photos in the batch may have failures.
        /// These failures are specified in each
        /// [PhotoResponse.status][google.streetview.publish.v1.PhotoResponse.status]
        /// in
        /// [BatchDeletePhotosResponse.results][google.streetview.publish.v1.BatchDeletePhotosResponse.status].
        /// See
        /// [DeletePhoto][google.streetview.publish.v1.StreetViewPublishService.DeletePhoto]
        /// for specific failures that can occur per photo.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeletePhotosResponse> BatchDeletePhotosAsync(BatchDeletePhotosRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a list of [Photos][google.streetview.publish.v1.Photo] and their
        /// metadata.
        /// 
        /// Note that if
        /// [BatchDeletePhotos][google.streetview.publish.v1.StreetViewPublishService.BatchDeletePhotos]
        /// fails, either critical fields are missing or there was an authentication
        /// error. Even if
        /// [BatchDeletePhotos][google.streetview.publish.v1.StreetViewPublishService.BatchDeletePhotos]
        /// succeeds, individual photos in the batch may have failures.
        /// These failures are specified in each
        /// [PhotoResponse.status][google.streetview.publish.v1.PhotoResponse.status]
        /// in
        /// [BatchDeletePhotosResponse.results][google.streetview.publish.v1.BatchDeletePhotosResponse.status].
        /// See
        /// [DeletePhoto][google.streetview.publish.v1.StreetViewPublishService.DeletePhoto]
        /// for specific failures that can occur per photo.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeletePhotosResponse> BatchDeletePhotosAsync(BatchDeletePhotosRequest request, st::CancellationToken cancellationToken) =>
            BatchDeletePhotosAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a list of [Photos][google.streetview.publish.v1.Photo] and their
        /// metadata.
        /// 
        /// Note that if
        /// [BatchDeletePhotos][google.streetview.publish.v1.StreetViewPublishService.BatchDeletePhotos]
        /// fails, either critical fields are missing or there was an authentication
        /// error. Even if
        /// [BatchDeletePhotos][google.streetview.publish.v1.StreetViewPublishService.BatchDeletePhotos]
        /// succeeds, individual photos in the batch may have failures.
        /// These failures are specified in each
        /// [PhotoResponse.status][google.streetview.publish.v1.PhotoResponse.status]
        /// in
        /// [BatchDeletePhotosResponse.results][google.streetview.publish.v1.BatchDeletePhotosResponse.status].
        /// See
        /// [DeletePhoto][google.streetview.publish.v1.StreetViewPublishService.DeletePhoto]
        /// for specific failures that can occur per photo.
        /// </summary>
        /// <param name="photoIds">
        /// Required. IDs of the [Photos][google.streetview.publish.v1.Photo]. HTTP
        /// GET requests require the following syntax for the URL query parameter:
        /// `photoIds=&amp;lt;id1&amp;gt;&amp;amp;photoIds=&amp;lt;id2&amp;gt;&amp;amp;...`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchDeletePhotosResponse BatchDeletePhotos(scg::IEnumerable<string> photoIds, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeletePhotos(new BatchDeletePhotosRequest
            {
                PhotoIds =
                {
                    photoIds ?? linq::Enumerable.Empty<string>(),
                },
            }, callSettings);

        /// <summary>
        /// Deletes a list of [Photos][google.streetview.publish.v1.Photo] and their
        /// metadata.
        /// 
        /// Note that if
        /// [BatchDeletePhotos][google.streetview.publish.v1.StreetViewPublishService.BatchDeletePhotos]
        /// fails, either critical fields are missing or there was an authentication
        /// error. Even if
        /// [BatchDeletePhotos][google.streetview.publish.v1.StreetViewPublishService.BatchDeletePhotos]
        /// succeeds, individual photos in the batch may have failures.
        /// These failures are specified in each
        /// [PhotoResponse.status][google.streetview.publish.v1.PhotoResponse.status]
        /// in
        /// [BatchDeletePhotosResponse.results][google.streetview.publish.v1.BatchDeletePhotosResponse.status].
        /// See
        /// [DeletePhoto][google.streetview.publish.v1.StreetViewPublishService.DeletePhoto]
        /// for specific failures that can occur per photo.
        /// </summary>
        /// <param name="photoIds">
        /// Required. IDs of the [Photos][google.streetview.publish.v1.Photo]. HTTP
        /// GET requests require the following syntax for the URL query parameter:
        /// `photoIds=&amp;lt;id1&amp;gt;&amp;amp;photoIds=&amp;lt;id2&amp;gt;&amp;amp;...`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeletePhotosResponse> BatchDeletePhotosAsync(scg::IEnumerable<string> photoIds, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeletePhotosAsync(new BatchDeletePhotosRequest
            {
                PhotoIds =
                {
                    photoIds ?? linq::Enumerable.Empty<string>(),
                },
            }, callSettings);

        /// <summary>
        /// Deletes a list of [Photos][google.streetview.publish.v1.Photo] and their
        /// metadata.
        /// 
        /// Note that if
        /// [BatchDeletePhotos][google.streetview.publish.v1.StreetViewPublishService.BatchDeletePhotos]
        /// fails, either critical fields are missing or there was an authentication
        /// error. Even if
        /// [BatchDeletePhotos][google.streetview.publish.v1.StreetViewPublishService.BatchDeletePhotos]
        /// succeeds, individual photos in the batch may have failures.
        /// These failures are specified in each
        /// [PhotoResponse.status][google.streetview.publish.v1.PhotoResponse.status]
        /// in
        /// [BatchDeletePhotosResponse.results][google.streetview.publish.v1.BatchDeletePhotosResponse.status].
        /// See
        /// [DeletePhoto][google.streetview.publish.v1.StreetViewPublishService.DeletePhoto]
        /// for specific failures that can occur per photo.
        /// </summary>
        /// <param name="photoIds">
        /// Required. IDs of the [Photos][google.streetview.publish.v1.Photo]. HTTP
        /// GET requests require the following syntax for the URL query parameter:
        /// `photoIds=&amp;lt;id1&amp;gt;&amp;amp;photoIds=&amp;lt;id2&amp;gt;&amp;amp;...`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeletePhotosResponse> BatchDeletePhotosAsync(scg::IEnumerable<string> photoIds, st::CancellationToken cancellationToken) =>
            BatchDeletePhotosAsync(photoIds, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>StreetViewPublishService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Publishes and connects user-contributed photos on Street View.
    /// </remarks>
    public sealed partial class StreetViewPublishServiceClientImpl : StreetViewPublishServiceClient
    {
        private readonly gaxgrpc::ApiCall<wkt::Empty, UploadRef> _callStartUpload;

        private readonly gaxgrpc::ApiCall<CreatePhotoRequest, Photo> _callCreatePhoto;

        private readonly gaxgrpc::ApiCall<GetPhotoRequest, Photo> _callGetPhoto;

        private readonly gaxgrpc::ApiCall<BatchGetPhotosRequest, BatchGetPhotosResponse> _callBatchGetPhotos;

        private readonly gaxgrpc::ApiCall<ListPhotosRequest, ListPhotosResponse> _callListPhotos;

        private readonly gaxgrpc::ApiCall<UpdatePhotoRequest, Photo> _callUpdatePhoto;

        private readonly gaxgrpc::ApiCall<BatchUpdatePhotosRequest, BatchUpdatePhotosResponse> _callBatchUpdatePhotos;

        private readonly gaxgrpc::ApiCall<DeletePhotoRequest, wkt::Empty> _callDeletePhoto;

        private readonly gaxgrpc::ApiCall<BatchDeletePhotosRequest, BatchDeletePhotosResponse> _callBatchDeletePhotos;

        /// <summary>
        /// Constructs a client wrapper for the StreetViewPublishService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="StreetViewPublishServiceSettings"/> used within this client.
        /// </param>
        public StreetViewPublishServiceClientImpl(StreetViewPublishService.StreetViewPublishServiceClient grpcClient, StreetViewPublishServiceSettings settings)
        {
            GrpcClient = grpcClient;
            StreetViewPublishServiceSettings effectiveSettings = settings ?? StreetViewPublishServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callStartUpload = clientHelper.BuildApiCall<wkt::Empty, UploadRef>(grpcClient.StartUploadAsync, grpcClient.StartUpload, effectiveSettings.StartUploadSettings);
            Modify_ApiCall(ref _callStartUpload);
            Modify_StartUploadApiCall(ref _callStartUpload);
            _callCreatePhoto = clientHelper.BuildApiCall<CreatePhotoRequest, Photo>(grpcClient.CreatePhotoAsync, grpcClient.CreatePhoto, effectiveSettings.CreatePhotoSettings);
            Modify_ApiCall(ref _callCreatePhoto);
            Modify_CreatePhotoApiCall(ref _callCreatePhoto);
            _callGetPhoto = clientHelper.BuildApiCall<GetPhotoRequest, Photo>(grpcClient.GetPhotoAsync, grpcClient.GetPhoto, effectiveSettings.GetPhotoSettings).WithGoogleRequestParam("photo_id", request => request.PhotoId);
            Modify_ApiCall(ref _callGetPhoto);
            Modify_GetPhotoApiCall(ref _callGetPhoto);
            _callBatchGetPhotos = clientHelper.BuildApiCall<BatchGetPhotosRequest, BatchGetPhotosResponse>(grpcClient.BatchGetPhotosAsync, grpcClient.BatchGetPhotos, effectiveSettings.BatchGetPhotosSettings);
            Modify_ApiCall(ref _callBatchGetPhotos);
            Modify_BatchGetPhotosApiCall(ref _callBatchGetPhotos);
            _callListPhotos = clientHelper.BuildApiCall<ListPhotosRequest, ListPhotosResponse>(grpcClient.ListPhotosAsync, grpcClient.ListPhotos, effectiveSettings.ListPhotosSettings);
            Modify_ApiCall(ref _callListPhotos);
            Modify_ListPhotosApiCall(ref _callListPhotos);
            _callUpdatePhoto = clientHelper.BuildApiCall<UpdatePhotoRequest, Photo>(grpcClient.UpdatePhotoAsync, grpcClient.UpdatePhoto, effectiveSettings.UpdatePhotoSettings).WithGoogleRequestParam("photo.photo_id.id", request => request.Photo?.PhotoId?.Id);
            Modify_ApiCall(ref _callUpdatePhoto);
            Modify_UpdatePhotoApiCall(ref _callUpdatePhoto);
            _callBatchUpdatePhotos = clientHelper.BuildApiCall<BatchUpdatePhotosRequest, BatchUpdatePhotosResponse>(grpcClient.BatchUpdatePhotosAsync, grpcClient.BatchUpdatePhotos, effectiveSettings.BatchUpdatePhotosSettings);
            Modify_ApiCall(ref _callBatchUpdatePhotos);
            Modify_BatchUpdatePhotosApiCall(ref _callBatchUpdatePhotos);
            _callDeletePhoto = clientHelper.BuildApiCall<DeletePhotoRequest, wkt::Empty>(grpcClient.DeletePhotoAsync, grpcClient.DeletePhoto, effectiveSettings.DeletePhotoSettings).WithGoogleRequestParam("photo_id", request => request.PhotoId);
            Modify_ApiCall(ref _callDeletePhoto);
            Modify_DeletePhotoApiCall(ref _callDeletePhoto);
            _callBatchDeletePhotos = clientHelper.BuildApiCall<BatchDeletePhotosRequest, BatchDeletePhotosResponse>(grpcClient.BatchDeletePhotosAsync, grpcClient.BatchDeletePhotos, effectiveSettings.BatchDeletePhotosSettings);
            Modify_ApiCall(ref _callBatchDeletePhotos);
            Modify_BatchDeletePhotosApiCall(ref _callBatchDeletePhotos);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_StartUploadApiCall(ref gaxgrpc::ApiCall<wkt::Empty, UploadRef> call);

        partial void Modify_CreatePhotoApiCall(ref gaxgrpc::ApiCall<CreatePhotoRequest, Photo> call);

        partial void Modify_GetPhotoApiCall(ref gaxgrpc::ApiCall<GetPhotoRequest, Photo> call);

        partial void Modify_BatchGetPhotosApiCall(ref gaxgrpc::ApiCall<BatchGetPhotosRequest, BatchGetPhotosResponse> call);

        partial void Modify_ListPhotosApiCall(ref gaxgrpc::ApiCall<ListPhotosRequest, ListPhotosResponse> call);

        partial void Modify_UpdatePhotoApiCall(ref gaxgrpc::ApiCall<UpdatePhotoRequest, Photo> call);

        partial void Modify_BatchUpdatePhotosApiCall(ref gaxgrpc::ApiCall<BatchUpdatePhotosRequest, BatchUpdatePhotosResponse> call);

        partial void Modify_DeletePhotoApiCall(ref gaxgrpc::ApiCall<DeletePhotoRequest, wkt::Empty> call);

        partial void Modify_BatchDeletePhotosApiCall(ref gaxgrpc::ApiCall<BatchDeletePhotosRequest, BatchDeletePhotosResponse> call);

        partial void OnConstruction(StreetViewPublishService.StreetViewPublishServiceClient grpcClient, StreetViewPublishServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC StreetViewPublishService client</summary>
        public override StreetViewPublishService.StreetViewPublishServiceClient GrpcClient { get; }

        partial void Modify_Empty(ref wkt::Empty request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreatePhotoRequest(ref CreatePhotoRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetPhotoRequest(ref GetPhotoRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchGetPhotosRequest(ref BatchGetPhotosRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPhotosRequest(ref ListPhotosRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdatePhotoRequest(ref UpdatePhotoRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchUpdatePhotosRequest(ref BatchUpdatePhotosRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeletePhotoRequest(ref DeletePhotoRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchDeletePhotosRequest(ref BatchDeletePhotosRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates an upload session to start uploading photo bytes. The method uses
        /// the upload URL of the returned
        /// [UploadRef][google.streetview.publish.v1.UploadRef] to upload the bytes for
        /// the [Photo][google.streetview.publish.v1.Photo].
        /// 
        /// In addition to the photo requirements shown in
        /// https://support.google.com/maps/answer/7012050?hl=en&amp;amp;ref_topic=6275604,
        /// the photo must meet the following requirements:
        /// 
        /// * Photo Sphere XMP metadata must be included in the photo medadata. See
        /// https://developers.google.com/streetview/spherical-metadata for the
        /// required fields.
        /// * The pixel size of the photo must meet the size requirements listed in
        /// https://support.google.com/maps/answer/7012050?hl=en&amp;amp;ref_topic=6275604, and
        /// the photo must be a full 360 horizontally.
        /// 
        /// After the upload completes, the method uses
        /// [UploadRef][google.streetview.publish.v1.UploadRef] with
        /// [CreatePhoto][google.streetview.publish.v1.StreetViewPublishService.CreatePhoto]
        /// to create the [Photo][google.streetview.publish.v1.Photo] object entry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UploadRef StartUpload(wkt::Empty request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_Empty(ref request, ref callSettings);
            return _callStartUpload.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates an upload session to start uploading photo bytes. The method uses
        /// the upload URL of the returned
        /// [UploadRef][google.streetview.publish.v1.UploadRef] to upload the bytes for
        /// the [Photo][google.streetview.publish.v1.Photo].
        /// 
        /// In addition to the photo requirements shown in
        /// https://support.google.com/maps/answer/7012050?hl=en&amp;amp;ref_topic=6275604,
        /// the photo must meet the following requirements:
        /// 
        /// * Photo Sphere XMP metadata must be included in the photo medadata. See
        /// https://developers.google.com/streetview/spherical-metadata for the
        /// required fields.
        /// * The pixel size of the photo must meet the size requirements listed in
        /// https://support.google.com/maps/answer/7012050?hl=en&amp;amp;ref_topic=6275604, and
        /// the photo must be a full 360 horizontally.
        /// 
        /// After the upload completes, the method uses
        /// [UploadRef][google.streetview.publish.v1.UploadRef] with
        /// [CreatePhoto][google.streetview.publish.v1.StreetViewPublishService.CreatePhoto]
        /// to create the [Photo][google.streetview.publish.v1.Photo] object entry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UploadRef> StartUploadAsync(wkt::Empty request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_Empty(ref request, ref callSettings);
            return _callStartUpload.Async(request, callSettings);
        }

        /// <summary>
        /// After the client finishes uploading the photo with the returned
        /// [UploadRef][google.streetview.publish.v1.UploadRef],
        /// [CreatePhoto][google.streetview.publish.v1.StreetViewPublishService.CreatePhoto]
        /// publishes the uploaded [Photo][google.streetview.publish.v1.Photo] to
        /// Street View on Google Maps.
        /// 
        /// Currently, the only way to set heading, pitch, and roll in CreatePhoto is
        /// through the [Photo Sphere XMP
        /// metadata](https://developers.google.com/streetview/spherical-metadata) in
        /// the photo bytes. CreatePhoto ignores the `pose.heading`, `pose.pitch`,
        /// `pose.roll`, `pose.altitude`, and `pose.level` fields in Pose.
        /// 
        /// This method returns the following error codes:
        /// 
        /// * [google.rpc.Code.INVALID_ARGUMENT][google.rpc.Code.INVALID_ARGUMENT] if
        /// the request is malformed or if the uploaded photo is not a 360 photo.
        /// * [google.rpc.Code.NOT_FOUND][google.rpc.Code.NOT_FOUND] if the upload
        /// reference does not exist.
        /// * [google.rpc.Code.RESOURCE_EXHAUSTED][google.rpc.Code.RESOURCE_EXHAUSTED]
        /// if the account has reached the storage limit.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Photo CreatePhoto(CreatePhotoRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePhotoRequest(ref request, ref callSettings);
            return _callCreatePhoto.Sync(request, callSettings);
        }

        /// <summary>
        /// After the client finishes uploading the photo with the returned
        /// [UploadRef][google.streetview.publish.v1.UploadRef],
        /// [CreatePhoto][google.streetview.publish.v1.StreetViewPublishService.CreatePhoto]
        /// publishes the uploaded [Photo][google.streetview.publish.v1.Photo] to
        /// Street View on Google Maps.
        /// 
        /// Currently, the only way to set heading, pitch, and roll in CreatePhoto is
        /// through the [Photo Sphere XMP
        /// metadata](https://developers.google.com/streetview/spherical-metadata) in
        /// the photo bytes. CreatePhoto ignores the `pose.heading`, `pose.pitch`,
        /// `pose.roll`, `pose.altitude`, and `pose.level` fields in Pose.
        /// 
        /// This method returns the following error codes:
        /// 
        /// * [google.rpc.Code.INVALID_ARGUMENT][google.rpc.Code.INVALID_ARGUMENT] if
        /// the request is malformed or if the uploaded photo is not a 360 photo.
        /// * [google.rpc.Code.NOT_FOUND][google.rpc.Code.NOT_FOUND] if the upload
        /// reference does not exist.
        /// * [google.rpc.Code.RESOURCE_EXHAUSTED][google.rpc.Code.RESOURCE_EXHAUSTED]
        /// if the account has reached the storage limit.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Photo> CreatePhotoAsync(CreatePhotoRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePhotoRequest(ref request, ref callSettings);
            return _callCreatePhoto.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the metadata of the specified
        /// [Photo][google.streetview.publish.v1.Photo].
        /// 
        /// This method returns the following error codes:
        /// 
        /// * [google.rpc.Code.PERMISSION_DENIED][google.rpc.Code.PERMISSION_DENIED] if
        /// the requesting user did not create the requested
        /// [Photo][google.streetview.publish.v1.Photo].
        /// * [google.rpc.Code.NOT_FOUND][google.rpc.Code.NOT_FOUND] if the requested
        /// [Photo][google.streetview.publish.v1.Photo] does not exist.
        /// * [google.rpc.Code.UNAVAILABLE][google.rpc.Code.UNAVAILABLE] if the
        /// requested [Photo][google.streetview.publish.v1.Photo] is still being
        /// indexed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Photo GetPhoto(GetPhotoRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPhotoRequest(ref request, ref callSettings);
            return _callGetPhoto.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the metadata of the specified
        /// [Photo][google.streetview.publish.v1.Photo].
        /// 
        /// This method returns the following error codes:
        /// 
        /// * [google.rpc.Code.PERMISSION_DENIED][google.rpc.Code.PERMISSION_DENIED] if
        /// the requesting user did not create the requested
        /// [Photo][google.streetview.publish.v1.Photo].
        /// * [google.rpc.Code.NOT_FOUND][google.rpc.Code.NOT_FOUND] if the requested
        /// [Photo][google.streetview.publish.v1.Photo] does not exist.
        /// * [google.rpc.Code.UNAVAILABLE][google.rpc.Code.UNAVAILABLE] if the
        /// requested [Photo][google.streetview.publish.v1.Photo] is still being
        /// indexed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Photo> GetPhotoAsync(GetPhotoRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPhotoRequest(ref request, ref callSettings);
            return _callGetPhoto.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the metadata of the specified
        /// [Photo][google.streetview.publish.v1.Photo] batch.
        /// 
        /// Note that if
        /// [BatchGetPhotos][google.streetview.publish.v1.StreetViewPublishService.BatchGetPhotos]
        /// fails, either critical fields are missing or there is an authentication
        /// error. Even if
        /// [BatchGetPhotos][google.streetview.publish.v1.StreetViewPublishService.BatchGetPhotos]
        /// succeeds, individual photos in the batch may have failures.
        /// These failures are specified in each
        /// [PhotoResponse.status][google.streetview.publish.v1.PhotoResponse.status]
        /// in
        /// [BatchGetPhotosResponse.results][google.streetview.publish.v1.BatchGetPhotosResponse.results].
        /// See
        /// [GetPhoto][google.streetview.publish.v1.StreetViewPublishService.GetPhoto]
        /// for specific failures that can occur per photo.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchGetPhotosResponse BatchGetPhotos(BatchGetPhotosRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchGetPhotosRequest(ref request, ref callSettings);
            return _callBatchGetPhotos.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the metadata of the specified
        /// [Photo][google.streetview.publish.v1.Photo] batch.
        /// 
        /// Note that if
        /// [BatchGetPhotos][google.streetview.publish.v1.StreetViewPublishService.BatchGetPhotos]
        /// fails, either critical fields are missing or there is an authentication
        /// error. Even if
        /// [BatchGetPhotos][google.streetview.publish.v1.StreetViewPublishService.BatchGetPhotos]
        /// succeeds, individual photos in the batch may have failures.
        /// These failures are specified in each
        /// [PhotoResponse.status][google.streetview.publish.v1.PhotoResponse.status]
        /// in
        /// [BatchGetPhotosResponse.results][google.streetview.publish.v1.BatchGetPhotosResponse.results].
        /// See
        /// [GetPhoto][google.streetview.publish.v1.StreetViewPublishService.GetPhoto]
        /// for specific failures that can occur per photo.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchGetPhotosResponse> BatchGetPhotosAsync(BatchGetPhotosRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchGetPhotosRequest(ref request, ref callSettings);
            return _callBatchGetPhotos.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all the [Photos][google.streetview.publish.v1.Photo] that belong to
        /// the user.
        /// 
        /// &amp;lt;aside class="note"&amp;gt;&amp;lt;b&amp;gt;Note:&amp;lt;/b&amp;gt; Recently created photos that are still
        /// being indexed are not returned in the response.&amp;lt;/aside&amp;gt;
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Photo"/> resources.</returns>
        public override gax::PagedEnumerable<ListPhotosResponse, Photo> ListPhotos(ListPhotosRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPhotosRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListPhotosRequest, ListPhotosResponse, Photo>(_callListPhotos, request, callSettings);
        }

        /// <summary>
        /// Lists all the [Photos][google.streetview.publish.v1.Photo] that belong to
        /// the user.
        /// 
        /// &amp;lt;aside class="note"&amp;gt;&amp;lt;b&amp;gt;Note:&amp;lt;/b&amp;gt; Recently created photos that are still
        /// being indexed are not returned in the response.&amp;lt;/aside&amp;gt;
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Photo"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListPhotosResponse, Photo> ListPhotosAsync(ListPhotosRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPhotosRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListPhotosRequest, ListPhotosResponse, Photo>(_callListPhotos, request, callSettings);
        }

        /// <summary>
        /// Updates the metadata of a [Photo][google.streetview.publish.v1.Photo], such
        /// as pose, place association, connections, etc. Changing the pixels of a
        /// photo is not supported.
        /// 
        /// Only the fields specified in the
        /// [updateMask][google.streetview.publish.v1.UpdatePhotoRequest.update_mask]
        /// field are used. If `updateMask` is not present, the update applies to all
        /// fields.
        /// 
        /// This method returns the following error codes:
        /// 
        /// * [google.rpc.Code.PERMISSION_DENIED][google.rpc.Code.PERMISSION_DENIED] if
        /// the requesting user did not create the requested photo.
        /// * [google.rpc.Code.INVALID_ARGUMENT][google.rpc.Code.INVALID_ARGUMENT] if
        /// the request is malformed.
        /// * [google.rpc.Code.NOT_FOUND][google.rpc.Code.NOT_FOUND] if the requested
        /// photo does not exist.
        /// * [google.rpc.Code.UNAVAILABLE][google.rpc.Code.UNAVAILABLE] if the
        /// requested [Photo][google.streetview.publish.v1.Photo] is still being
        /// indexed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Photo UpdatePhoto(UpdatePhotoRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePhotoRequest(ref request, ref callSettings);
            return _callUpdatePhoto.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the metadata of a [Photo][google.streetview.publish.v1.Photo], such
        /// as pose, place association, connections, etc. Changing the pixels of a
        /// photo is not supported.
        /// 
        /// Only the fields specified in the
        /// [updateMask][google.streetview.publish.v1.UpdatePhotoRequest.update_mask]
        /// field are used. If `updateMask` is not present, the update applies to all
        /// fields.
        /// 
        /// This method returns the following error codes:
        /// 
        /// * [google.rpc.Code.PERMISSION_DENIED][google.rpc.Code.PERMISSION_DENIED] if
        /// the requesting user did not create the requested photo.
        /// * [google.rpc.Code.INVALID_ARGUMENT][google.rpc.Code.INVALID_ARGUMENT] if
        /// the request is malformed.
        /// * [google.rpc.Code.NOT_FOUND][google.rpc.Code.NOT_FOUND] if the requested
        /// photo does not exist.
        /// * [google.rpc.Code.UNAVAILABLE][google.rpc.Code.UNAVAILABLE] if the
        /// requested [Photo][google.streetview.publish.v1.Photo] is still being
        /// indexed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Photo> UpdatePhotoAsync(UpdatePhotoRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePhotoRequest(ref request, ref callSettings);
            return _callUpdatePhoto.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the metadata of [Photos][google.streetview.publish.v1.Photo], such
        /// as pose, place association, connections, etc. Changing the pixels of photos
        /// is not supported.
        /// 
        /// Note that if
        /// [BatchUpdatePhotos][google.streetview.publish.v1.StreetViewPublishService.BatchUpdatePhotos]
        /// fails, either critical fields are missing or there is an authentication
        /// error. Even if
        /// [BatchUpdatePhotos][google.streetview.publish.v1.StreetViewPublishService.BatchUpdatePhotos]
        /// succeeds, individual photos in the batch may have failures.
        /// These failures are specified in each
        /// [PhotoResponse.status][google.streetview.publish.v1.PhotoResponse.status]
        /// in
        /// [BatchUpdatePhotosResponse.results][google.streetview.publish.v1.BatchUpdatePhotosResponse.results].
        /// See
        /// [UpdatePhoto][google.streetview.publish.v1.StreetViewPublishService.UpdatePhoto]
        /// for specific failures that can occur per photo.
        /// 
        /// Only the fields specified in
        /// [updateMask][google.streetview.publish.v1.UpdatePhotoRequest.update_mask]
        /// field are used. If `updateMask` is not present, the update applies to all
        /// fields.
        /// 
        /// The number of
        /// [UpdatePhotoRequest][google.streetview.publish.v1.UpdatePhotoRequest]
        /// messages in a
        /// [BatchUpdatePhotosRequest][google.streetview.publish.v1.BatchUpdatePhotosRequest]
        /// must not exceed 20.
        /// 
        /// &amp;lt;aside class="note"&amp;gt;&amp;lt;b&amp;gt;Note:&amp;lt;/b&amp;gt; To update
        /// [Pose.altitude][google.streetview.publish.v1.Pose.altitude],
        /// [Pose.latLngPair][google.streetview.publish.v1.Pose.lat_lng_pair] has to be
        /// filled as well. Otherwise, the request will fail.&amp;lt;/aside&amp;gt;
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchUpdatePhotosResponse BatchUpdatePhotos(BatchUpdatePhotosRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdatePhotosRequest(ref request, ref callSettings);
            return _callBatchUpdatePhotos.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the metadata of [Photos][google.streetview.publish.v1.Photo], such
        /// as pose, place association, connections, etc. Changing the pixels of photos
        /// is not supported.
        /// 
        /// Note that if
        /// [BatchUpdatePhotos][google.streetview.publish.v1.StreetViewPublishService.BatchUpdatePhotos]
        /// fails, either critical fields are missing or there is an authentication
        /// error. Even if
        /// [BatchUpdatePhotos][google.streetview.publish.v1.StreetViewPublishService.BatchUpdatePhotos]
        /// succeeds, individual photos in the batch may have failures.
        /// These failures are specified in each
        /// [PhotoResponse.status][google.streetview.publish.v1.PhotoResponse.status]
        /// in
        /// [BatchUpdatePhotosResponse.results][google.streetview.publish.v1.BatchUpdatePhotosResponse.results].
        /// See
        /// [UpdatePhoto][google.streetview.publish.v1.StreetViewPublishService.UpdatePhoto]
        /// for specific failures that can occur per photo.
        /// 
        /// Only the fields specified in
        /// [updateMask][google.streetview.publish.v1.UpdatePhotoRequest.update_mask]
        /// field are used. If `updateMask` is not present, the update applies to all
        /// fields.
        /// 
        /// The number of
        /// [UpdatePhotoRequest][google.streetview.publish.v1.UpdatePhotoRequest]
        /// messages in a
        /// [BatchUpdatePhotosRequest][google.streetview.publish.v1.BatchUpdatePhotosRequest]
        /// must not exceed 20.
        /// 
        /// &amp;lt;aside class="note"&amp;gt;&amp;lt;b&amp;gt;Note:&amp;lt;/b&amp;gt; To update
        /// [Pose.altitude][google.streetview.publish.v1.Pose.altitude],
        /// [Pose.latLngPair][google.streetview.publish.v1.Pose.lat_lng_pair] has to be
        /// filled as well. Otherwise, the request will fail.&amp;lt;/aside&amp;gt;
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchUpdatePhotosResponse> BatchUpdatePhotosAsync(BatchUpdatePhotosRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdatePhotosRequest(ref request, ref callSettings);
            return _callBatchUpdatePhotos.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a [Photo][google.streetview.publish.v1.Photo] and its metadata.
        /// 
        /// This method returns the following error codes:
        /// 
        /// * [google.rpc.Code.PERMISSION_DENIED][google.rpc.Code.PERMISSION_DENIED] if
        /// the requesting user did not create the requested photo.
        /// * [google.rpc.Code.NOT_FOUND][google.rpc.Code.NOT_FOUND] if the photo ID
        /// does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeletePhoto(DeletePhotoRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePhotoRequest(ref request, ref callSettings);
            _callDeletePhoto.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a [Photo][google.streetview.publish.v1.Photo] and its metadata.
        /// 
        /// This method returns the following error codes:
        /// 
        /// * [google.rpc.Code.PERMISSION_DENIED][google.rpc.Code.PERMISSION_DENIED] if
        /// the requesting user did not create the requested photo.
        /// * [google.rpc.Code.NOT_FOUND][google.rpc.Code.NOT_FOUND] if the photo ID
        /// does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeletePhotoAsync(DeletePhotoRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePhotoRequest(ref request, ref callSettings);
            return _callDeletePhoto.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a list of [Photos][google.streetview.publish.v1.Photo] and their
        /// metadata.
        /// 
        /// Note that if
        /// [BatchDeletePhotos][google.streetview.publish.v1.StreetViewPublishService.BatchDeletePhotos]
        /// fails, either critical fields are missing or there was an authentication
        /// error. Even if
        /// [BatchDeletePhotos][google.streetview.publish.v1.StreetViewPublishService.BatchDeletePhotos]
        /// succeeds, individual photos in the batch may have failures.
        /// These failures are specified in each
        /// [PhotoResponse.status][google.streetview.publish.v1.PhotoResponse.status]
        /// in
        /// [BatchDeletePhotosResponse.results][google.streetview.publish.v1.BatchDeletePhotosResponse.status].
        /// See
        /// [DeletePhoto][google.streetview.publish.v1.StreetViewPublishService.DeletePhoto]
        /// for specific failures that can occur per photo.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchDeletePhotosResponse BatchDeletePhotos(BatchDeletePhotosRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeletePhotosRequest(ref request, ref callSettings);
            return _callBatchDeletePhotos.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a list of [Photos][google.streetview.publish.v1.Photo] and their
        /// metadata.
        /// 
        /// Note that if
        /// [BatchDeletePhotos][google.streetview.publish.v1.StreetViewPublishService.BatchDeletePhotos]
        /// fails, either critical fields are missing or there was an authentication
        /// error. Even if
        /// [BatchDeletePhotos][google.streetview.publish.v1.StreetViewPublishService.BatchDeletePhotos]
        /// succeeds, individual photos in the batch may have failures.
        /// These failures are specified in each
        /// [PhotoResponse.status][google.streetview.publish.v1.PhotoResponse.status]
        /// in
        /// [BatchDeletePhotosResponse.results][google.streetview.publish.v1.BatchDeletePhotosResponse.status].
        /// See
        /// [DeletePhoto][google.streetview.publish.v1.StreetViewPublishService.DeletePhoto]
        /// for specific failures that can occur per photo.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchDeletePhotosResponse> BatchDeletePhotosAsync(BatchDeletePhotosRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeletePhotosRequest(ref request, ref callSettings);
            return _callBatchDeletePhotos.Async(request, callSettings);
        }
    }

    public partial class ListPhotosRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListPhotosResponse : gaxgrpc::IPageResponse<Photo>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Photo> GetEnumerator() => Photos.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
