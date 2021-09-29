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

namespace Google.Cloud.Vision.V1P1Beta1
{
    /// <summary>Settings for <see cref="ImageAnnotatorClient"/> instances.</summary>
    public sealed partial class ImageAnnotatorSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ImageAnnotatorSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ImageAnnotatorSettings"/>.</returns>
        public static ImageAnnotatorSettings GetDefault() => new ImageAnnotatorSettings();

        /// <summary>Constructs a new <see cref="ImageAnnotatorSettings"/> object with default settings.</summary>
        public ImageAnnotatorSettings()
        {
        }

        private ImageAnnotatorSettings(ImageAnnotatorSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            BatchAnnotateImagesSettings = existing.BatchAnnotateImagesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ImageAnnotatorSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ImageAnnotatorClient.BatchAnnotateImages</c> and <c>ImageAnnotatorClient.BatchAnnotateImagesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchAnnotateImagesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ImageAnnotatorSettings"/> object.</returns>
        public ImageAnnotatorSettings Clone() => new ImageAnnotatorSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ImageAnnotatorClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class ImageAnnotatorClientBuilder : gaxgrpc::ClientBuilderBase<ImageAnnotatorClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ImageAnnotatorSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ImageAnnotatorClientBuilder()
        {
            UseJwtAccessWithScopes = ImageAnnotatorClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref ImageAnnotatorClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ImageAnnotatorClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ImageAnnotatorClient Build()
        {
            ImageAnnotatorClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ImageAnnotatorClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ImageAnnotatorClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ImageAnnotatorClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ImageAnnotatorClient.Create(callInvoker, Settings);
        }

        private async stt::Task<ImageAnnotatorClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ImageAnnotatorClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => ImageAnnotatorClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => ImageAnnotatorClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ImageAnnotatorClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>ImageAnnotator client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service that performs Google Cloud Vision API detection tasks over client
    /// images, such as face, landmark, logo, label, and text detection. The
    /// ImageAnnotator service returns detected entities from the images.
    /// </remarks>
    public abstract partial class ImageAnnotatorClient
    {
        /// <summary>
        /// The default endpoint for the ImageAnnotator service, which is a host of "vision.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "vision.googleapis.com:443";

        /// <summary>The default ImageAnnotator scopes.</summary>
        /// <remarks>
        /// The default ImageAnnotator scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-vision</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/cloud-vision",
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
        /// Asynchronously creates a <see cref="ImageAnnotatorClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ImageAnnotatorClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ImageAnnotatorClient"/>.</returns>
        public static stt::Task<ImageAnnotatorClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ImageAnnotatorClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ImageAnnotatorClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ImageAnnotatorClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ImageAnnotatorClient"/>.</returns>
        public static ImageAnnotatorClient Create() => new ImageAnnotatorClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ImageAnnotatorClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ImageAnnotatorSettings"/>.</param>
        /// <returns>The created <see cref="ImageAnnotatorClient"/>.</returns>
        internal static ImageAnnotatorClient Create(grpccore::CallInvoker callInvoker, ImageAnnotatorSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ImageAnnotator.ImageAnnotatorClient grpcClient = new ImageAnnotator.ImageAnnotatorClient(callInvoker);
            return new ImageAnnotatorClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC ImageAnnotator client</summary>
        public virtual ImageAnnotator.ImageAnnotatorClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Run image detection and annotation for a batch of images.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchAnnotateImagesResponse BatchAnnotateImages(BatchAnnotateImagesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Run image detection and annotation for a batch of images.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchAnnotateImagesResponse> BatchAnnotateImagesAsync(BatchAnnotateImagesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Run image detection and annotation for a batch of images.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchAnnotateImagesResponse> BatchAnnotateImagesAsync(BatchAnnotateImagesRequest request, st::CancellationToken cancellationToken) =>
            BatchAnnotateImagesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Run image detection and annotation for a batch of images.
        /// </summary>
        /// <param name="requests">
        /// Required. Individual image annotation requests for this batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchAnnotateImagesResponse BatchAnnotateImages(scg::IEnumerable<AnnotateImageRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchAnnotateImages(new BatchAnnotateImagesRequest
            {
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Run image detection and annotation for a batch of images.
        /// </summary>
        /// <param name="requests">
        /// Required. Individual image annotation requests for this batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchAnnotateImagesResponse> BatchAnnotateImagesAsync(scg::IEnumerable<AnnotateImageRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchAnnotateImagesAsync(new BatchAnnotateImagesRequest
            {
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Run image detection and annotation for a batch of images.
        /// </summary>
        /// <param name="requests">
        /// Required. Individual image annotation requests for this batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchAnnotateImagesResponse> BatchAnnotateImagesAsync(scg::IEnumerable<AnnotateImageRequest> requests, st::CancellationToken cancellationToken) =>
            BatchAnnotateImagesAsync(requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ImageAnnotator client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service that performs Google Cloud Vision API detection tasks over client
    /// images, such as face, landmark, logo, label, and text detection. The
    /// ImageAnnotator service returns detected entities from the images.
    /// </remarks>
    public sealed partial class ImageAnnotatorClientImpl : ImageAnnotatorClient
    {
        private readonly gaxgrpc::ApiCall<BatchAnnotateImagesRequest, BatchAnnotateImagesResponse> _callBatchAnnotateImages;

        /// <summary>
        /// Constructs a client wrapper for the ImageAnnotator service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ImageAnnotatorSettings"/> used within this client.</param>
        public ImageAnnotatorClientImpl(ImageAnnotator.ImageAnnotatorClient grpcClient, ImageAnnotatorSettings settings)
        {
            GrpcClient = grpcClient;
            ImageAnnotatorSettings effectiveSettings = settings ?? ImageAnnotatorSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callBatchAnnotateImages = clientHelper.BuildApiCall<BatchAnnotateImagesRequest, BatchAnnotateImagesResponse>(grpcClient.BatchAnnotateImagesAsync, grpcClient.BatchAnnotateImages, effectiveSettings.BatchAnnotateImagesSettings);
            Modify_ApiCall(ref _callBatchAnnotateImages);
            Modify_BatchAnnotateImagesApiCall(ref _callBatchAnnotateImages);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_BatchAnnotateImagesApiCall(ref gaxgrpc::ApiCall<BatchAnnotateImagesRequest, BatchAnnotateImagesResponse> call);

        partial void OnConstruction(ImageAnnotator.ImageAnnotatorClient grpcClient, ImageAnnotatorSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ImageAnnotator client</summary>
        public override ImageAnnotator.ImageAnnotatorClient GrpcClient { get; }

        partial void Modify_BatchAnnotateImagesRequest(ref BatchAnnotateImagesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Run image detection and annotation for a batch of images.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchAnnotateImagesResponse BatchAnnotateImages(BatchAnnotateImagesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchAnnotateImagesRequest(ref request, ref callSettings);
            return _callBatchAnnotateImages.Sync(request, callSettings);
        }

        /// <summary>
        /// Run image detection and annotation for a batch of images.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchAnnotateImagesResponse> BatchAnnotateImagesAsync(BatchAnnotateImagesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchAnnotateImagesRequest(ref request, ref callSettings);
            return _callBatchAnnotateImages.Async(request, callSettings);
        }
    }
}
