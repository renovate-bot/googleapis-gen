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
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Example.Library.V1
{
    /// <summary>Settings for <see cref="LibraryServiceClient"/> instances.</summary>
    public sealed partial class LibraryServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="LibraryServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="LibraryServiceSettings"/>.</returns>
        public static LibraryServiceSettings GetDefault() => new LibraryServiceSettings();

        /// <summary>Constructs a new <see cref="LibraryServiceSettings"/> object with default settings.</summary>
        public LibraryServiceSettings()
        {
        }

        private LibraryServiceSettings(LibraryServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateShelfSettings = existing.CreateShelfSettings;
            GetShelfSettings = existing.GetShelfSettings;
            ListShelvesSettings = existing.ListShelvesSettings;
            DeleteShelfSettings = existing.DeleteShelfSettings;
            MergeShelvesSettings = existing.MergeShelvesSettings;
            CreateBookSettings = existing.CreateBookSettings;
            GetBookSettings = existing.GetBookSettings;
            ListBooksSettings = existing.ListBooksSettings;
            DeleteBookSettings = existing.DeleteBookSettings;
            UpdateBookSettings = existing.UpdateBookSettings;
            MoveBookSettings = existing.MoveBookSettings;
            OnCopy(existing);
        }

        partial void OnCopy(LibraryServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LibraryServiceClient.CreateShelf</c> and <c>LibraryServiceClient.CreateShelfAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateShelfSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes()));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LibraryServiceClient.GetShelf</c> and <c>LibraryServiceClient.GetShelfAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetShelfSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LibraryServiceClient.ListShelves</c> and <c>LibraryServiceClient.ListShelvesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListShelvesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LibraryServiceClient.DeleteShelf</c> and <c>LibraryServiceClient.DeleteShelfAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteShelfSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LibraryServiceClient.MergeShelves</c> and <c>LibraryServiceClient.MergeShelvesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MergeShelvesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes()));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LibraryServiceClient.CreateBook</c> and <c>LibraryServiceClient.CreateBookAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateBookSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes()));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LibraryServiceClient.GetBook</c> and <c>LibraryServiceClient.GetBookAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetBookSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LibraryServiceClient.ListBooks</c> and <c>LibraryServiceClient.ListBooksAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListBooksSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LibraryServiceClient.DeleteBook</c> and <c>LibraryServiceClient.DeleteBookAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteBookSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LibraryServiceClient.UpdateBook</c> and <c>LibraryServiceClient.UpdateBookAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateBookSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LibraryServiceClient.MoveBook</c> and <c>LibraryServiceClient.MoveBookAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MoveBookSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes()));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="LibraryServiceSettings"/> object.</returns>
        public LibraryServiceSettings Clone() => new LibraryServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="LibraryServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class LibraryServiceClientBuilder : gaxgrpc::ClientBuilderBase<LibraryServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public LibraryServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public LibraryServiceClientBuilder()
        {
            UseJwtAccessWithScopes = LibraryServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref LibraryServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<LibraryServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override LibraryServiceClient Build()
        {
            LibraryServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<LibraryServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<LibraryServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private LibraryServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return LibraryServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<LibraryServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return LibraryServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => LibraryServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => LibraryServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => LibraryServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>LibraryService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// This API represents a simple digital library. It lets you manage Shelf
    /// resources and Book resources in the library. It defines the following
    /// resource model:
    /// 
    /// - The API has a collection of [Shelf][google.example.library.v1.Shelf]
    /// resources, named `shelves/*`
    /// 
    /// - Each Shelf has a collection of [Book][google.example.library.v1.Book]
    /// resources, named `shelves/*/books/*`
    /// </remarks>
    public abstract partial class LibraryServiceClient
    {
        /// <summary>
        /// The default endpoint for the LibraryService service, which is a host of "library-example.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "library-example.googleapis.com:443";

        /// <summary>The default LibraryService scopes.</summary>
        /// <remarks>The default LibraryService scopes are:<list type="bullet"></list></remarks>
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
        /// Asynchronously creates a <see cref="LibraryServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="LibraryServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="LibraryServiceClient"/>.</returns>
        public static stt::Task<LibraryServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new LibraryServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="LibraryServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="LibraryServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="LibraryServiceClient"/>.</returns>
        public static LibraryServiceClient Create() => new LibraryServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="LibraryServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="LibraryServiceSettings"/>.</param>
        /// <returns>The created <see cref="LibraryServiceClient"/>.</returns>
        internal static LibraryServiceClient Create(grpccore::CallInvoker callInvoker, LibraryServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            LibraryService.LibraryServiceClient grpcClient = new LibraryService.LibraryServiceClient(callInvoker);
            return new LibraryServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC LibraryService client</summary>
        public virtual LibraryService.LibraryServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a shelf, and returns the new Shelf.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Shelf CreateShelf(CreateShelfRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a shelf, and returns the new Shelf.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Shelf> CreateShelfAsync(CreateShelfRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a shelf, and returns the new Shelf.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Shelf> CreateShelfAsync(CreateShelfRequest request, st::CancellationToken cancellationToken) =>
            CreateShelfAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a shelf, and returns the new Shelf.
        /// </summary>
        /// <param name="shelf">
        /// The shelf to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Shelf CreateShelf(Shelf shelf, gaxgrpc::CallSettings callSettings = null) =>
            CreateShelf(new CreateShelfRequest
            {
                Shelf = gax::GaxPreconditions.CheckNotNull(shelf, nameof(shelf)),
            }, callSettings);

        /// <summary>
        /// Creates a shelf, and returns the new Shelf.
        /// </summary>
        /// <param name="shelf">
        /// The shelf to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Shelf> CreateShelfAsync(Shelf shelf, gaxgrpc::CallSettings callSettings = null) =>
            CreateShelfAsync(new CreateShelfRequest
            {
                Shelf = gax::GaxPreconditions.CheckNotNull(shelf, nameof(shelf)),
            }, callSettings);

        /// <summary>
        /// Creates a shelf, and returns the new Shelf.
        /// </summary>
        /// <param name="shelf">
        /// The shelf to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Shelf> CreateShelfAsync(Shelf shelf, st::CancellationToken cancellationToken) =>
            CreateShelfAsync(shelf, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a shelf. Returns NOT_FOUND if the shelf does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Shelf GetShelf(GetShelfRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a shelf. Returns NOT_FOUND if the shelf does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Shelf> GetShelfAsync(GetShelfRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a shelf. Returns NOT_FOUND if the shelf does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Shelf> GetShelfAsync(GetShelfRequest request, st::CancellationToken cancellationToken) =>
            GetShelfAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a shelf. Returns NOT_FOUND if the shelf does not exist.
        /// </summary>
        /// <param name="name">
        /// The name of the shelf to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Shelf GetShelf(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetShelf(new GetShelfRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a shelf. Returns NOT_FOUND if the shelf does not exist.
        /// </summary>
        /// <param name="name">
        /// The name of the shelf to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Shelf> GetShelfAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetShelfAsync(new GetShelfRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a shelf. Returns NOT_FOUND if the shelf does not exist.
        /// </summary>
        /// <param name="name">
        /// The name of the shelf to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Shelf> GetShelfAsync(string name, st::CancellationToken cancellationToken) =>
            GetShelfAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a shelf. Returns NOT_FOUND if the shelf does not exist.
        /// </summary>
        /// <param name="name">
        /// The name of the shelf to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Shelf GetShelf(ShelfName name, gaxgrpc::CallSettings callSettings = null) =>
            GetShelf(new GetShelfRequest
            {
                ShelfName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a shelf. Returns NOT_FOUND if the shelf does not exist.
        /// </summary>
        /// <param name="name">
        /// The name of the shelf to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Shelf> GetShelfAsync(ShelfName name, gaxgrpc::CallSettings callSettings = null) =>
            GetShelfAsync(new GetShelfRequest
            {
                ShelfName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a shelf. Returns NOT_FOUND if the shelf does not exist.
        /// </summary>
        /// <param name="name">
        /// The name of the shelf to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Shelf> GetShelfAsync(ShelfName name, st::CancellationToken cancellationToken) =>
            GetShelfAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists shelves. The order is unspecified but deterministic. Newly created
        /// shelves will not necessarily be added to the end of this list.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Shelf"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListShelvesResponse, Shelf> ListShelves(ListShelvesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists shelves. The order is unspecified but deterministic. Newly created
        /// shelves will not necessarily be added to the end of this list.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Shelf"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListShelvesResponse, Shelf> ListShelvesAsync(ListShelvesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a shelf. Returns NOT_FOUND if the shelf does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteShelf(DeleteShelfRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a shelf. Returns NOT_FOUND if the shelf does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteShelfAsync(DeleteShelfRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a shelf. Returns NOT_FOUND if the shelf does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteShelfAsync(DeleteShelfRequest request, st::CancellationToken cancellationToken) =>
            DeleteShelfAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a shelf. Returns NOT_FOUND if the shelf does not exist.
        /// </summary>
        /// <param name="name">
        /// The name of the shelf to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteShelf(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteShelf(new DeleteShelfRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a shelf. Returns NOT_FOUND if the shelf does not exist.
        /// </summary>
        /// <param name="name">
        /// The name of the shelf to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteShelfAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteShelfAsync(new DeleteShelfRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a shelf. Returns NOT_FOUND if the shelf does not exist.
        /// </summary>
        /// <param name="name">
        /// The name of the shelf to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteShelfAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteShelfAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a shelf. Returns NOT_FOUND if the shelf does not exist.
        /// </summary>
        /// <param name="name">
        /// The name of the shelf to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteShelf(ShelfName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteShelf(new DeleteShelfRequest
            {
                ShelfName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a shelf. Returns NOT_FOUND if the shelf does not exist.
        /// </summary>
        /// <param name="name">
        /// The name of the shelf to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteShelfAsync(ShelfName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteShelfAsync(new DeleteShelfRequest
            {
                ShelfName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a shelf. Returns NOT_FOUND if the shelf does not exist.
        /// </summary>
        /// <param name="name">
        /// The name of the shelf to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteShelfAsync(ShelfName name, st::CancellationToken cancellationToken) =>
            DeleteShelfAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Merges two shelves by adding all books from the shelf named
        /// `other_shelf_name` to shelf `name`, and deletes
        /// `other_shelf_name`. Returns the updated shelf.
        /// The book ids of the moved books may not be the same as the original books.
        /// 
        /// Returns NOT_FOUND if either shelf does not exist.
        /// This call is a no-op if the specified shelves are the same.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Shelf MergeShelves(MergeShelvesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Merges two shelves by adding all books from the shelf named
        /// `other_shelf_name` to shelf `name`, and deletes
        /// `other_shelf_name`. Returns the updated shelf.
        /// The book ids of the moved books may not be the same as the original books.
        /// 
        /// Returns NOT_FOUND if either shelf does not exist.
        /// This call is a no-op if the specified shelves are the same.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Shelf> MergeShelvesAsync(MergeShelvesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Merges two shelves by adding all books from the shelf named
        /// `other_shelf_name` to shelf `name`, and deletes
        /// `other_shelf_name`. Returns the updated shelf.
        /// The book ids of the moved books may not be the same as the original books.
        /// 
        /// Returns NOT_FOUND if either shelf does not exist.
        /// This call is a no-op if the specified shelves are the same.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Shelf> MergeShelvesAsync(MergeShelvesRequest request, st::CancellationToken cancellationToken) =>
            MergeShelvesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Merges two shelves by adding all books from the shelf named
        /// `other_shelf_name` to shelf `name`, and deletes
        /// `other_shelf_name`. Returns the updated shelf.
        /// The book ids of the moved books may not be the same as the original books.
        /// 
        /// Returns NOT_FOUND if either shelf does not exist.
        /// This call is a no-op if the specified shelves are the same.
        /// </summary>
        /// <param name="name">
        /// The name of the shelf we're adding books to.
        /// </param>
        /// <param name="otherShelf">
        /// The name of the shelf we're removing books from and deleting.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Shelf MergeShelves(string name, string otherShelf, gaxgrpc::CallSettings callSettings = null) =>
            MergeShelves(new MergeShelvesRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                OtherShelf = gax::GaxPreconditions.CheckNotNullOrEmpty(otherShelf, nameof(otherShelf)),
            }, callSettings);

        /// <summary>
        /// Merges two shelves by adding all books from the shelf named
        /// `other_shelf_name` to shelf `name`, and deletes
        /// `other_shelf_name`. Returns the updated shelf.
        /// The book ids of the moved books may not be the same as the original books.
        /// 
        /// Returns NOT_FOUND if either shelf does not exist.
        /// This call is a no-op if the specified shelves are the same.
        /// </summary>
        /// <param name="name">
        /// The name of the shelf we're adding books to.
        /// </param>
        /// <param name="otherShelf">
        /// The name of the shelf we're removing books from and deleting.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Shelf> MergeShelvesAsync(string name, string otherShelf, gaxgrpc::CallSettings callSettings = null) =>
            MergeShelvesAsync(new MergeShelvesRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                OtherShelf = gax::GaxPreconditions.CheckNotNullOrEmpty(otherShelf, nameof(otherShelf)),
            }, callSettings);

        /// <summary>
        /// Merges two shelves by adding all books from the shelf named
        /// `other_shelf_name` to shelf `name`, and deletes
        /// `other_shelf_name`. Returns the updated shelf.
        /// The book ids of the moved books may not be the same as the original books.
        /// 
        /// Returns NOT_FOUND if either shelf does not exist.
        /// This call is a no-op if the specified shelves are the same.
        /// </summary>
        /// <param name="name">
        /// The name of the shelf we're adding books to.
        /// </param>
        /// <param name="otherShelf">
        /// The name of the shelf we're removing books from and deleting.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Shelf> MergeShelvesAsync(string name, string otherShelf, st::CancellationToken cancellationToken) =>
            MergeShelvesAsync(name, otherShelf, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Merges two shelves by adding all books from the shelf named
        /// `other_shelf_name` to shelf `name`, and deletes
        /// `other_shelf_name`. Returns the updated shelf.
        /// The book ids of the moved books may not be the same as the original books.
        /// 
        /// Returns NOT_FOUND if either shelf does not exist.
        /// This call is a no-op if the specified shelves are the same.
        /// </summary>
        /// <param name="name">
        /// The name of the shelf we're adding books to.
        /// </param>
        /// <param name="otherShelf">
        /// The name of the shelf we're removing books from and deleting.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Shelf MergeShelves(ShelfName name, ShelfName otherShelf, gaxgrpc::CallSettings callSettings = null) =>
            MergeShelves(new MergeShelvesRequest
            {
                ShelfName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                OtherShelfAsShelfName = gax::GaxPreconditions.CheckNotNull(otherShelf, nameof(otherShelf)),
            }, callSettings);

        /// <summary>
        /// Merges two shelves by adding all books from the shelf named
        /// `other_shelf_name` to shelf `name`, and deletes
        /// `other_shelf_name`. Returns the updated shelf.
        /// The book ids of the moved books may not be the same as the original books.
        /// 
        /// Returns NOT_FOUND if either shelf does not exist.
        /// This call is a no-op if the specified shelves are the same.
        /// </summary>
        /// <param name="name">
        /// The name of the shelf we're adding books to.
        /// </param>
        /// <param name="otherShelf">
        /// The name of the shelf we're removing books from and deleting.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Shelf> MergeShelvesAsync(ShelfName name, ShelfName otherShelf, gaxgrpc::CallSettings callSettings = null) =>
            MergeShelvesAsync(new MergeShelvesRequest
            {
                ShelfName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                OtherShelfAsShelfName = gax::GaxPreconditions.CheckNotNull(otherShelf, nameof(otherShelf)),
            }, callSettings);

        /// <summary>
        /// Merges two shelves by adding all books from the shelf named
        /// `other_shelf_name` to shelf `name`, and deletes
        /// `other_shelf_name`. Returns the updated shelf.
        /// The book ids of the moved books may not be the same as the original books.
        /// 
        /// Returns NOT_FOUND if either shelf does not exist.
        /// This call is a no-op if the specified shelves are the same.
        /// </summary>
        /// <param name="name">
        /// The name of the shelf we're adding books to.
        /// </param>
        /// <param name="otherShelf">
        /// The name of the shelf we're removing books from and deleting.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Shelf> MergeShelvesAsync(ShelfName name, ShelfName otherShelf, st::CancellationToken cancellationToken) =>
            MergeShelvesAsync(name, otherShelf, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a book, and returns the new Book.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Book CreateBook(CreateBookRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a book, and returns the new Book.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Book> CreateBookAsync(CreateBookRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a book, and returns the new Book.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Book> CreateBookAsync(CreateBookRequest request, st::CancellationToken cancellationToken) =>
            CreateBookAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a book, and returns the new Book.
        /// </summary>
        /// <param name="parent">
        /// The name of the shelf in which the book is created.
        /// </param>
        /// <param name="book">
        /// The book to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Book CreateBook(string parent, Book book, gaxgrpc::CallSettings callSettings = null) =>
            CreateBook(new CreateBookRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Book = gax::GaxPreconditions.CheckNotNull(book, nameof(book)),
            }, callSettings);

        /// <summary>
        /// Creates a book, and returns the new Book.
        /// </summary>
        /// <param name="parent">
        /// The name of the shelf in which the book is created.
        /// </param>
        /// <param name="book">
        /// The book to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Book> CreateBookAsync(string parent, Book book, gaxgrpc::CallSettings callSettings = null) =>
            CreateBookAsync(new CreateBookRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Book = gax::GaxPreconditions.CheckNotNull(book, nameof(book)),
            }, callSettings);

        /// <summary>
        /// Creates a book, and returns the new Book.
        /// </summary>
        /// <param name="parent">
        /// The name of the shelf in which the book is created.
        /// </param>
        /// <param name="book">
        /// The book to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Book> CreateBookAsync(string parent, Book book, st::CancellationToken cancellationToken) =>
            CreateBookAsync(parent, book, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a book, and returns the new Book.
        /// </summary>
        /// <param name="parent">
        /// The name of the shelf in which the book is created.
        /// </param>
        /// <param name="book">
        /// The book to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Book CreateBook(ShelfName parent, Book book, gaxgrpc::CallSettings callSettings = null) =>
            CreateBook(new CreateBookRequest
            {
                ParentAsShelfName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Book = gax::GaxPreconditions.CheckNotNull(book, nameof(book)),
            }, callSettings);

        /// <summary>
        /// Creates a book, and returns the new Book.
        /// </summary>
        /// <param name="parent">
        /// The name of the shelf in which the book is created.
        /// </param>
        /// <param name="book">
        /// The book to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Book> CreateBookAsync(ShelfName parent, Book book, gaxgrpc::CallSettings callSettings = null) =>
            CreateBookAsync(new CreateBookRequest
            {
                ParentAsShelfName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Book = gax::GaxPreconditions.CheckNotNull(book, nameof(book)),
            }, callSettings);

        /// <summary>
        /// Creates a book, and returns the new Book.
        /// </summary>
        /// <param name="parent">
        /// The name of the shelf in which the book is created.
        /// </param>
        /// <param name="book">
        /// The book to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Book> CreateBookAsync(ShelfName parent, Book book, st::CancellationToken cancellationToken) =>
            CreateBookAsync(parent, book, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a book. Returns NOT_FOUND if the book does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Book GetBook(GetBookRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a book. Returns NOT_FOUND if the book does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Book> GetBookAsync(GetBookRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a book. Returns NOT_FOUND if the book does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Book> GetBookAsync(GetBookRequest request, st::CancellationToken cancellationToken) =>
            GetBookAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a book. Returns NOT_FOUND if the book does not exist.
        /// </summary>
        /// <param name="name">
        /// The name of the book to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Book GetBook(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBook(new GetBookRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a book. Returns NOT_FOUND if the book does not exist.
        /// </summary>
        /// <param name="name">
        /// The name of the book to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Book> GetBookAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBookAsync(new GetBookRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a book. Returns NOT_FOUND if the book does not exist.
        /// </summary>
        /// <param name="name">
        /// The name of the book to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Book> GetBookAsync(string name, st::CancellationToken cancellationToken) =>
            GetBookAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a book. Returns NOT_FOUND if the book does not exist.
        /// </summary>
        /// <param name="name">
        /// The name of the book to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Book GetBook(BookName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBook(new GetBookRequest
            {
                BookName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a book. Returns NOT_FOUND if the book does not exist.
        /// </summary>
        /// <param name="name">
        /// The name of the book to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Book> GetBookAsync(BookName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBookAsync(new GetBookRequest
            {
                BookName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a book. Returns NOT_FOUND if the book does not exist.
        /// </summary>
        /// <param name="name">
        /// The name of the book to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Book> GetBookAsync(BookName name, st::CancellationToken cancellationToken) =>
            GetBookAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists books in a shelf. The order is unspecified but deterministic. Newly
        /// created books will not necessarily be added to the end of this list.
        /// Returns NOT_FOUND if the shelf does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Book"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBooksResponse, Book> ListBooks(ListBooksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists books in a shelf. The order is unspecified but deterministic. Newly
        /// created books will not necessarily be added to the end of this list.
        /// Returns NOT_FOUND if the shelf does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Book"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBooksResponse, Book> ListBooksAsync(ListBooksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists books in a shelf. The order is unspecified but deterministic. Newly
        /// created books will not necessarily be added to the end of this list.
        /// Returns NOT_FOUND if the shelf does not exist.
        /// </summary>
        /// <param name="parent">
        /// The name of the shelf whose books we'd like to list.
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
        /// <returns>A pageable sequence of <see cref="Book"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBooksResponse, Book> ListBooks(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListBooks(new ListBooksRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists books in a shelf. The order is unspecified but deterministic. Newly
        /// created books will not necessarily be added to the end of this list.
        /// Returns NOT_FOUND if the shelf does not exist.
        /// </summary>
        /// <param name="parent">
        /// The name of the shelf whose books we'd like to list.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Book"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBooksResponse, Book> ListBooksAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListBooksAsync(new ListBooksRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists books in a shelf. The order is unspecified but deterministic. Newly
        /// created books will not necessarily be added to the end of this list.
        /// Returns NOT_FOUND if the shelf does not exist.
        /// </summary>
        /// <param name="parent">
        /// The name of the shelf whose books we'd like to list.
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
        /// <returns>A pageable sequence of <see cref="Book"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBooksResponse, Book> ListBooks(ShelfName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListBooks(new ListBooksRequest
            {
                ParentAsShelfName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists books in a shelf. The order is unspecified but deterministic. Newly
        /// created books will not necessarily be added to the end of this list.
        /// Returns NOT_FOUND if the shelf does not exist.
        /// </summary>
        /// <param name="parent">
        /// The name of the shelf whose books we'd like to list.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Book"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBooksResponse, Book> ListBooksAsync(ShelfName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListBooksAsync(new ListBooksRequest
            {
                ParentAsShelfName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Deletes a book. Returns NOT_FOUND if the book does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteBook(DeleteBookRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a book. Returns NOT_FOUND if the book does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteBookAsync(DeleteBookRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a book. Returns NOT_FOUND if the book does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteBookAsync(DeleteBookRequest request, st::CancellationToken cancellationToken) =>
            DeleteBookAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a book. Returns NOT_FOUND if the book does not exist.
        /// </summary>
        /// <param name="name">
        /// The name of the book to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteBook(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBook(new DeleteBookRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a book. Returns NOT_FOUND if the book does not exist.
        /// </summary>
        /// <param name="name">
        /// The name of the book to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteBookAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBookAsync(new DeleteBookRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a book. Returns NOT_FOUND if the book does not exist.
        /// </summary>
        /// <param name="name">
        /// The name of the book to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteBookAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteBookAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a book. Returns NOT_FOUND if the book does not exist.
        /// </summary>
        /// <param name="name">
        /// The name of the book to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteBook(BookName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBook(new DeleteBookRequest
            {
                BookName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a book. Returns NOT_FOUND if the book does not exist.
        /// </summary>
        /// <param name="name">
        /// The name of the book to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteBookAsync(BookName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBookAsync(new DeleteBookRequest
            {
                BookName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a book. Returns NOT_FOUND if the book does not exist.
        /// </summary>
        /// <param name="name">
        /// The name of the book to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteBookAsync(BookName name, st::CancellationToken cancellationToken) =>
            DeleteBookAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a book. Returns INVALID_ARGUMENT if the name of the book
        /// is non-empty and does not equal the existing name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Book UpdateBook(UpdateBookRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a book. Returns INVALID_ARGUMENT if the name of the book
        /// is non-empty and does not equal the existing name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Book> UpdateBookAsync(UpdateBookRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a book. Returns INVALID_ARGUMENT if the name of the book
        /// is non-empty and does not equal the existing name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Book> UpdateBookAsync(UpdateBookRequest request, st::CancellationToken cancellationToken) =>
            UpdateBookAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a book. Returns INVALID_ARGUMENT if the name of the book
        /// is non-empty and does not equal the existing name.
        /// </summary>
        /// <param name="book">
        /// The name of the book to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Book UpdateBook(Book book, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateBook(new UpdateBookRequest
            {
                Book = gax::GaxPreconditions.CheckNotNull(book, nameof(book)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a book. Returns INVALID_ARGUMENT if the name of the book
        /// is non-empty and does not equal the existing name.
        /// </summary>
        /// <param name="book">
        /// The name of the book to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Book> UpdateBookAsync(Book book, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateBookAsync(new UpdateBookRequest
            {
                Book = gax::GaxPreconditions.CheckNotNull(book, nameof(book)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a book. Returns INVALID_ARGUMENT if the name of the book
        /// is non-empty and does not equal the existing name.
        /// </summary>
        /// <param name="book">
        /// The name of the book to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Book> UpdateBookAsync(Book book, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateBookAsync(book, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Moves a book to another shelf, and returns the new book. The book
        /// id of the new book may not be the same as the original book.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Book MoveBook(MoveBookRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Moves a book to another shelf, and returns the new book. The book
        /// id of the new book may not be the same as the original book.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Book> MoveBookAsync(MoveBookRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Moves a book to another shelf, and returns the new book. The book
        /// id of the new book may not be the same as the original book.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Book> MoveBookAsync(MoveBookRequest request, st::CancellationToken cancellationToken) =>
            MoveBookAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Moves a book to another shelf, and returns the new book. The book
        /// id of the new book may not be the same as the original book.
        /// </summary>
        /// <param name="name">
        /// The name of the book to move.
        /// </param>
        /// <param name="otherShelfName">
        /// The name of the destination shelf.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Book MoveBook(string name, string otherShelfName, gaxgrpc::CallSettings callSettings = null) =>
            MoveBook(new MoveBookRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                OtherShelfName = gax::GaxPreconditions.CheckNotNullOrEmpty(otherShelfName, nameof(otherShelfName)),
            }, callSettings);

        /// <summary>
        /// Moves a book to another shelf, and returns the new book. The book
        /// id of the new book may not be the same as the original book.
        /// </summary>
        /// <param name="name">
        /// The name of the book to move.
        /// </param>
        /// <param name="otherShelfName">
        /// The name of the destination shelf.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Book> MoveBookAsync(string name, string otherShelfName, gaxgrpc::CallSettings callSettings = null) =>
            MoveBookAsync(new MoveBookRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                OtherShelfName = gax::GaxPreconditions.CheckNotNullOrEmpty(otherShelfName, nameof(otherShelfName)),
            }, callSettings);

        /// <summary>
        /// Moves a book to another shelf, and returns the new book. The book
        /// id of the new book may not be the same as the original book.
        /// </summary>
        /// <param name="name">
        /// The name of the book to move.
        /// </param>
        /// <param name="otherShelfName">
        /// The name of the destination shelf.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Book> MoveBookAsync(string name, string otherShelfName, st::CancellationToken cancellationToken) =>
            MoveBookAsync(name, otherShelfName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Moves a book to another shelf, and returns the new book. The book
        /// id of the new book may not be the same as the original book.
        /// </summary>
        /// <param name="name">
        /// The name of the book to move.
        /// </param>
        /// <param name="otherShelfName">
        /// The name of the destination shelf.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Book MoveBook(BookName name, ShelfName otherShelfName, gaxgrpc::CallSettings callSettings = null) =>
            MoveBook(new MoveBookRequest
            {
                BookName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                OtherShelfNameAsShelfName = gax::GaxPreconditions.CheckNotNull(otherShelfName, nameof(otherShelfName)),
            }, callSettings);

        /// <summary>
        /// Moves a book to another shelf, and returns the new book. The book
        /// id of the new book may not be the same as the original book.
        /// </summary>
        /// <param name="name">
        /// The name of the book to move.
        /// </param>
        /// <param name="otherShelfName">
        /// The name of the destination shelf.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Book> MoveBookAsync(BookName name, ShelfName otherShelfName, gaxgrpc::CallSettings callSettings = null) =>
            MoveBookAsync(new MoveBookRequest
            {
                BookName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                OtherShelfNameAsShelfName = gax::GaxPreconditions.CheckNotNull(otherShelfName, nameof(otherShelfName)),
            }, callSettings);

        /// <summary>
        /// Moves a book to another shelf, and returns the new book. The book
        /// id of the new book may not be the same as the original book.
        /// </summary>
        /// <param name="name">
        /// The name of the book to move.
        /// </param>
        /// <param name="otherShelfName">
        /// The name of the destination shelf.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Book> MoveBookAsync(BookName name, ShelfName otherShelfName, st::CancellationToken cancellationToken) =>
            MoveBookAsync(name, otherShelfName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>LibraryService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// This API represents a simple digital library. It lets you manage Shelf
    /// resources and Book resources in the library. It defines the following
    /// resource model:
    /// 
    /// - The API has a collection of [Shelf][google.example.library.v1.Shelf]
    /// resources, named `shelves/*`
    /// 
    /// - Each Shelf has a collection of [Book][google.example.library.v1.Book]
    /// resources, named `shelves/*/books/*`
    /// </remarks>
    public sealed partial class LibraryServiceClientImpl : LibraryServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateShelfRequest, Shelf> _callCreateShelf;

        private readonly gaxgrpc::ApiCall<GetShelfRequest, Shelf> _callGetShelf;

        private readonly gaxgrpc::ApiCall<ListShelvesRequest, ListShelvesResponse> _callListShelves;

        private readonly gaxgrpc::ApiCall<DeleteShelfRequest, wkt::Empty> _callDeleteShelf;

        private readonly gaxgrpc::ApiCall<MergeShelvesRequest, Shelf> _callMergeShelves;

        private readonly gaxgrpc::ApiCall<CreateBookRequest, Book> _callCreateBook;

        private readonly gaxgrpc::ApiCall<GetBookRequest, Book> _callGetBook;

        private readonly gaxgrpc::ApiCall<ListBooksRequest, ListBooksResponse> _callListBooks;

        private readonly gaxgrpc::ApiCall<DeleteBookRequest, wkt::Empty> _callDeleteBook;

        private readonly gaxgrpc::ApiCall<UpdateBookRequest, Book> _callUpdateBook;

        private readonly gaxgrpc::ApiCall<MoveBookRequest, Book> _callMoveBook;

        /// <summary>
        /// Constructs a client wrapper for the LibraryService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="LibraryServiceSettings"/> used within this client.</param>
        public LibraryServiceClientImpl(LibraryService.LibraryServiceClient grpcClient, LibraryServiceSettings settings)
        {
            GrpcClient = grpcClient;
            LibraryServiceSettings effectiveSettings = settings ?? LibraryServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callCreateShelf = clientHelper.BuildApiCall<CreateShelfRequest, Shelf>(grpcClient.CreateShelfAsync, grpcClient.CreateShelf, effectiveSettings.CreateShelfSettings);
            Modify_ApiCall(ref _callCreateShelf);
            Modify_CreateShelfApiCall(ref _callCreateShelf);
            _callGetShelf = clientHelper.BuildApiCall<GetShelfRequest, Shelf>(grpcClient.GetShelfAsync, grpcClient.GetShelf, effectiveSettings.GetShelfSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetShelf);
            Modify_GetShelfApiCall(ref _callGetShelf);
            _callListShelves = clientHelper.BuildApiCall<ListShelvesRequest, ListShelvesResponse>(grpcClient.ListShelvesAsync, grpcClient.ListShelves, effectiveSettings.ListShelvesSettings);
            Modify_ApiCall(ref _callListShelves);
            Modify_ListShelvesApiCall(ref _callListShelves);
            _callDeleteShelf = clientHelper.BuildApiCall<DeleteShelfRequest, wkt::Empty>(grpcClient.DeleteShelfAsync, grpcClient.DeleteShelf, effectiveSettings.DeleteShelfSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteShelf);
            Modify_DeleteShelfApiCall(ref _callDeleteShelf);
            _callMergeShelves = clientHelper.BuildApiCall<MergeShelvesRequest, Shelf>(grpcClient.MergeShelvesAsync, grpcClient.MergeShelves, effectiveSettings.MergeShelvesSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callMergeShelves);
            Modify_MergeShelvesApiCall(ref _callMergeShelves);
            _callCreateBook = clientHelper.BuildApiCall<CreateBookRequest, Book>(grpcClient.CreateBookAsync, grpcClient.CreateBook, effectiveSettings.CreateBookSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateBook);
            Modify_CreateBookApiCall(ref _callCreateBook);
            _callGetBook = clientHelper.BuildApiCall<GetBookRequest, Book>(grpcClient.GetBookAsync, grpcClient.GetBook, effectiveSettings.GetBookSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetBook);
            Modify_GetBookApiCall(ref _callGetBook);
            _callListBooks = clientHelper.BuildApiCall<ListBooksRequest, ListBooksResponse>(grpcClient.ListBooksAsync, grpcClient.ListBooks, effectiveSettings.ListBooksSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListBooks);
            Modify_ListBooksApiCall(ref _callListBooks);
            _callDeleteBook = clientHelper.BuildApiCall<DeleteBookRequest, wkt::Empty>(grpcClient.DeleteBookAsync, grpcClient.DeleteBook, effectiveSettings.DeleteBookSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteBook);
            Modify_DeleteBookApiCall(ref _callDeleteBook);
            _callUpdateBook = clientHelper.BuildApiCall<UpdateBookRequest, Book>(grpcClient.UpdateBookAsync, grpcClient.UpdateBook, effectiveSettings.UpdateBookSettings).WithGoogleRequestParam("book.name", request => request.Book?.Name);
            Modify_ApiCall(ref _callUpdateBook);
            Modify_UpdateBookApiCall(ref _callUpdateBook);
            _callMoveBook = clientHelper.BuildApiCall<MoveBookRequest, Book>(grpcClient.MoveBookAsync, grpcClient.MoveBook, effectiveSettings.MoveBookSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callMoveBook);
            Modify_MoveBookApiCall(ref _callMoveBook);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateShelfApiCall(ref gaxgrpc::ApiCall<CreateShelfRequest, Shelf> call);

        partial void Modify_GetShelfApiCall(ref gaxgrpc::ApiCall<GetShelfRequest, Shelf> call);

        partial void Modify_ListShelvesApiCall(ref gaxgrpc::ApiCall<ListShelvesRequest, ListShelvesResponse> call);

        partial void Modify_DeleteShelfApiCall(ref gaxgrpc::ApiCall<DeleteShelfRequest, wkt::Empty> call);

        partial void Modify_MergeShelvesApiCall(ref gaxgrpc::ApiCall<MergeShelvesRequest, Shelf> call);

        partial void Modify_CreateBookApiCall(ref gaxgrpc::ApiCall<CreateBookRequest, Book> call);

        partial void Modify_GetBookApiCall(ref gaxgrpc::ApiCall<GetBookRequest, Book> call);

        partial void Modify_ListBooksApiCall(ref gaxgrpc::ApiCall<ListBooksRequest, ListBooksResponse> call);

        partial void Modify_DeleteBookApiCall(ref gaxgrpc::ApiCall<DeleteBookRequest, wkt::Empty> call);

        partial void Modify_UpdateBookApiCall(ref gaxgrpc::ApiCall<UpdateBookRequest, Book> call);

        partial void Modify_MoveBookApiCall(ref gaxgrpc::ApiCall<MoveBookRequest, Book> call);

        partial void OnConstruction(LibraryService.LibraryServiceClient grpcClient, LibraryServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC LibraryService client</summary>
        public override LibraryService.LibraryServiceClient GrpcClient { get; }

        partial void Modify_CreateShelfRequest(ref CreateShelfRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetShelfRequest(ref GetShelfRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListShelvesRequest(ref ListShelvesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteShelfRequest(ref DeleteShelfRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MergeShelvesRequest(ref MergeShelvesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateBookRequest(ref CreateBookRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetBookRequest(ref GetBookRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListBooksRequest(ref ListBooksRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteBookRequest(ref DeleteBookRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateBookRequest(ref UpdateBookRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MoveBookRequest(ref MoveBookRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a shelf, and returns the new Shelf.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Shelf CreateShelf(CreateShelfRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateShelfRequest(ref request, ref callSettings);
            return _callCreateShelf.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a shelf, and returns the new Shelf.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Shelf> CreateShelfAsync(CreateShelfRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateShelfRequest(ref request, ref callSettings);
            return _callCreateShelf.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a shelf. Returns NOT_FOUND if the shelf does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Shelf GetShelf(GetShelfRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetShelfRequest(ref request, ref callSettings);
            return _callGetShelf.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a shelf. Returns NOT_FOUND if the shelf does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Shelf> GetShelfAsync(GetShelfRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetShelfRequest(ref request, ref callSettings);
            return _callGetShelf.Async(request, callSettings);
        }

        /// <summary>
        /// Lists shelves. The order is unspecified but deterministic. Newly created
        /// shelves will not necessarily be added to the end of this list.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Shelf"/> resources.</returns>
        public override gax::PagedEnumerable<ListShelvesResponse, Shelf> ListShelves(ListShelvesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListShelvesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListShelvesRequest, ListShelvesResponse, Shelf>(_callListShelves, request, callSettings);
        }

        /// <summary>
        /// Lists shelves. The order is unspecified but deterministic. Newly created
        /// shelves will not necessarily be added to the end of this list.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Shelf"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListShelvesResponse, Shelf> ListShelvesAsync(ListShelvesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListShelvesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListShelvesRequest, ListShelvesResponse, Shelf>(_callListShelves, request, callSettings);
        }

        /// <summary>
        /// Deletes a shelf. Returns NOT_FOUND if the shelf does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteShelf(DeleteShelfRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteShelfRequest(ref request, ref callSettings);
            _callDeleteShelf.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a shelf. Returns NOT_FOUND if the shelf does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteShelfAsync(DeleteShelfRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteShelfRequest(ref request, ref callSettings);
            return _callDeleteShelf.Async(request, callSettings);
        }

        /// <summary>
        /// Merges two shelves by adding all books from the shelf named
        /// `other_shelf_name` to shelf `name`, and deletes
        /// `other_shelf_name`. Returns the updated shelf.
        /// The book ids of the moved books may not be the same as the original books.
        /// 
        /// Returns NOT_FOUND if either shelf does not exist.
        /// This call is a no-op if the specified shelves are the same.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Shelf MergeShelves(MergeShelvesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MergeShelvesRequest(ref request, ref callSettings);
            return _callMergeShelves.Sync(request, callSettings);
        }

        /// <summary>
        /// Merges two shelves by adding all books from the shelf named
        /// `other_shelf_name` to shelf `name`, and deletes
        /// `other_shelf_name`. Returns the updated shelf.
        /// The book ids of the moved books may not be the same as the original books.
        /// 
        /// Returns NOT_FOUND if either shelf does not exist.
        /// This call is a no-op if the specified shelves are the same.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Shelf> MergeShelvesAsync(MergeShelvesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MergeShelvesRequest(ref request, ref callSettings);
            return _callMergeShelves.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a book, and returns the new Book.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Book CreateBook(CreateBookRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBookRequest(ref request, ref callSettings);
            return _callCreateBook.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a book, and returns the new Book.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Book> CreateBookAsync(CreateBookRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBookRequest(ref request, ref callSettings);
            return _callCreateBook.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a book. Returns NOT_FOUND if the book does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Book GetBook(GetBookRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBookRequest(ref request, ref callSettings);
            return _callGetBook.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a book. Returns NOT_FOUND if the book does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Book> GetBookAsync(GetBookRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBookRequest(ref request, ref callSettings);
            return _callGetBook.Async(request, callSettings);
        }

        /// <summary>
        /// Lists books in a shelf. The order is unspecified but deterministic. Newly
        /// created books will not necessarily be added to the end of this list.
        /// Returns NOT_FOUND if the shelf does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Book"/> resources.</returns>
        public override gax::PagedEnumerable<ListBooksResponse, Book> ListBooks(ListBooksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBooksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListBooksRequest, ListBooksResponse, Book>(_callListBooks, request, callSettings);
        }

        /// <summary>
        /// Lists books in a shelf. The order is unspecified but deterministic. Newly
        /// created books will not necessarily be added to the end of this list.
        /// Returns NOT_FOUND if the shelf does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Book"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListBooksResponse, Book> ListBooksAsync(ListBooksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBooksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListBooksRequest, ListBooksResponse, Book>(_callListBooks, request, callSettings);
        }

        /// <summary>
        /// Deletes a book. Returns NOT_FOUND if the book does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteBook(DeleteBookRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBookRequest(ref request, ref callSettings);
            _callDeleteBook.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a book. Returns NOT_FOUND if the book does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteBookAsync(DeleteBookRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBookRequest(ref request, ref callSettings);
            return _callDeleteBook.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a book. Returns INVALID_ARGUMENT if the name of the book
        /// is non-empty and does not equal the existing name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Book UpdateBook(UpdateBookRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBookRequest(ref request, ref callSettings);
            return _callUpdateBook.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a book. Returns INVALID_ARGUMENT if the name of the book
        /// is non-empty and does not equal the existing name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Book> UpdateBookAsync(UpdateBookRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBookRequest(ref request, ref callSettings);
            return _callUpdateBook.Async(request, callSettings);
        }

        /// <summary>
        /// Moves a book to another shelf, and returns the new book. The book
        /// id of the new book may not be the same as the original book.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Book MoveBook(MoveBookRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MoveBookRequest(ref request, ref callSettings);
            return _callMoveBook.Sync(request, callSettings);
        }

        /// <summary>
        /// Moves a book to another shelf, and returns the new book. The book
        /// id of the new book may not be the same as the original book.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Book> MoveBookAsync(MoveBookRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MoveBookRequest(ref request, ref callSettings);
            return _callMoveBook.Async(request, callSettings);
        }
    }

    public partial class ListShelvesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListBooksRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListShelvesResponse : gaxgrpc::IPageResponse<Shelf>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Shelf> GetEnumerator() => Shelves.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListBooksResponse : gaxgrpc::IPageResponse<Book>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Book> GetEnumerator() => Books.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
