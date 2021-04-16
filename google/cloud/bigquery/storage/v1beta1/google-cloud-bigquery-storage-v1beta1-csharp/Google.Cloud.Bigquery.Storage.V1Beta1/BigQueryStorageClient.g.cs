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
using gagr = Google.Api.Gax.ResourceNames;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Bigquery.Storage.V1Beta1
{
    /// <summary>Settings for <see cref="BigQueryStorageClient"/> instances.</summary>
    public sealed partial class BigQueryStorageSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="BigQueryStorageSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="BigQueryStorageSettings"/>.</returns>
        public static BigQueryStorageSettings GetDefault() => new BigQueryStorageSettings();

        /// <summary>Constructs a new <see cref="BigQueryStorageSettings"/> object with default settings.</summary>
        public BigQueryStorageSettings()
        {
        }

        private BigQueryStorageSettings(BigQueryStorageSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateReadSessionSettings = existing.CreateReadSessionSettings;
            ReadRowsSettings = existing.ReadRowsSettings;
            BatchCreateReadSessionStreamsSettings = existing.BatchCreateReadSessionStreamsSettings;
            FinalizeStreamSettings = existing.FinalizeStreamSettings;
            SplitReadStreamSettings = existing.SplitReadStreamSettings;
            OnCopy(existing);
        }

        partial void OnCopy(BigQueryStorageSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigQueryStorageClient.CreateReadSession</c> and <c>BigQueryStorageClient.CreateReadSessionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateReadSessionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigQueryStorageClient.ReadRows</c> and <c>BigQueryStorageClient.ReadRowsAsync</c>.
        /// </summary>
        /// <remarks>Timeout: 86400 seconds.</remarks>
        public gaxgrpc::CallSettings ReadRowsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(86400000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigQueryStorageClient.BatchCreateReadSessionStreams</c> and
        /// <c>BigQueryStorageClient.BatchCreateReadSessionStreamsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchCreateReadSessionStreamsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigQueryStorageClient.FinalizeStream</c> and <c>BigQueryStorageClient.FinalizeStreamAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings FinalizeStreamSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigQueryStorageClient.SplitReadStream</c> and <c>BigQueryStorageClient.SplitReadStreamAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SplitReadStreamSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="BigQueryStorageSettings"/> object.</returns>
        public BigQueryStorageSettings Clone() => new BigQueryStorageSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="BigQueryStorageClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class BigQueryStorageClientBuilder : gaxgrpc::ClientBuilderBase<BigQueryStorageClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public BigQueryStorageSettings Settings { get; set; }

        partial void InterceptBuild(ref BigQueryStorageClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<BigQueryStorageClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override BigQueryStorageClient Build()
        {
            BigQueryStorageClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<BigQueryStorageClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<BigQueryStorageClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private BigQueryStorageClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return BigQueryStorageClient.Create(callInvoker, Settings);
        }

        private async stt::Task<BigQueryStorageClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return BigQueryStorageClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => BigQueryStorageClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => BigQueryStorageClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => BigQueryStorageClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>BigQueryStorage client wrapper, for convenient use.</summary>
    /// <remarks>
    /// BigQuery storage API.
    /// 
    /// The BigQuery storage API can be used to read data stored in BigQuery.
    /// </remarks>
    public abstract partial class BigQueryStorageClient
    {
        /// <summary>
        /// The default endpoint for the BigQueryStorage service, which is a host of "bigquerystorage.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "bigquerystorage.googleapis.com:443";

        /// <summary>The default BigQueryStorage scopes.</summary>
        /// <remarks>
        /// The default BigQueryStorage scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/bigquery</description></item>
        /// <item><description>https://www.googleapis.com/auth/bigquery.readonly</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/bigquery",
            "https://www.googleapis.com/auth/bigquery.readonly",
            "https://www.googleapis.com/auth/cloud-platform",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="BigQueryStorageClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="BigQueryStorageClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="BigQueryStorageClient"/>.</returns>
        public static stt::Task<BigQueryStorageClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new BigQueryStorageClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="BigQueryStorageClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="BigQueryStorageClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="BigQueryStorageClient"/>.</returns>
        public static BigQueryStorageClient Create() => new BigQueryStorageClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="BigQueryStorageClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="BigQueryStorageSettings"/>.</param>
        /// <returns>The created <see cref="BigQueryStorageClient"/>.</returns>
        internal static BigQueryStorageClient Create(grpccore::CallInvoker callInvoker, BigQueryStorageSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            BigQueryStorage.BigQueryStorageClient grpcClient = new BigQueryStorage.BigQueryStorageClient(callInvoker);
            return new BigQueryStorageClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC BigQueryStorage client</summary>
        public virtual BigQueryStorage.BigQueryStorageClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new read session. A read session divides the contents of a
        /// BigQuery table into one or more streams, which can then be used to read
        /// data from the table. The read session also specifies properties of the
        /// data to be read, such as a list of columns or a push-down filter describing
        /// the rows to be returned.
        /// 
        /// A particular row can be read by at most one stream. When the caller has
        /// reached the end of each stream in the session, then all the data in the
        /// table has been read.
        /// 
        /// Read sessions automatically expire 24 hours after they are created and do
        /// not require manual clean-up by the caller.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReadSession CreateReadSession(CreateReadSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new read session. A read session divides the contents of a
        /// BigQuery table into one or more streams, which can then be used to read
        /// data from the table. The read session also specifies properties of the
        /// data to be read, such as a list of columns or a push-down filter describing
        /// the rows to be returned.
        /// 
        /// A particular row can be read by at most one stream. When the caller has
        /// reached the end of each stream in the session, then all the data in the
        /// table has been read.
        /// 
        /// Read sessions automatically expire 24 hours after they are created and do
        /// not require manual clean-up by the caller.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadSession> CreateReadSessionAsync(CreateReadSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new read session. A read session divides the contents of a
        /// BigQuery table into one or more streams, which can then be used to read
        /// data from the table. The read session also specifies properties of the
        /// data to be read, such as a list of columns or a push-down filter describing
        /// the rows to be returned.
        /// 
        /// A particular row can be read by at most one stream. When the caller has
        /// reached the end of each stream in the session, then all the data in the
        /// table has been read.
        /// 
        /// Read sessions automatically expire 24 hours after they are created and do
        /// not require manual clean-up by the caller.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadSession> CreateReadSessionAsync(CreateReadSessionRequest request, st::CancellationToken cancellationToken) =>
            CreateReadSessionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new read session. A read session divides the contents of a
        /// BigQuery table into one or more streams, which can then be used to read
        /// data from the table. The read session also specifies properties of the
        /// data to be read, such as a list of columns or a push-down filter describing
        /// the rows to be returned.
        /// 
        /// A particular row can be read by at most one stream. When the caller has
        /// reached the end of each stream in the session, then all the data in the
        /// table has been read.
        /// 
        /// Read sessions automatically expire 24 hours after they are created and do
        /// not require manual clean-up by the caller.
        /// </summary>
        /// <param name="tableReference">
        /// Required. Reference to the table to read.
        /// </param>
        /// <param name="parent">
        /// Required. String of the form `projects/{project_id}` indicating the
        /// project this ReadSession is associated with. This is the project that will
        /// be billed for usage.
        /// </param>
        /// <param name="requestedStreams">
        /// Initial number of streams. If unset or 0, we will
        /// provide a value of streams so as to produce reasonable throughput. Must be
        /// non-negative. The number of streams may be lower than the requested number,
        /// depending on the amount parallelism that is reasonable for the table and
        /// the maximum amount of parallelism allowed by the system.
        /// 
        /// Streams must be read starting from offset 0.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReadSession CreateReadSession(TableReference tableReference, string parent, int requestedStreams, gaxgrpc::CallSettings callSettings = null) =>
            CreateReadSession(new CreateReadSessionRequest
            {
                TableReference = gax::GaxPreconditions.CheckNotNull(tableReference, nameof(tableReference)),
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                RequestedStreams = requestedStreams,
            }, callSettings);

        /// <summary>
        /// Creates a new read session. A read session divides the contents of a
        /// BigQuery table into one or more streams, which can then be used to read
        /// data from the table. The read session also specifies properties of the
        /// data to be read, such as a list of columns or a push-down filter describing
        /// the rows to be returned.
        /// 
        /// A particular row can be read by at most one stream. When the caller has
        /// reached the end of each stream in the session, then all the data in the
        /// table has been read.
        /// 
        /// Read sessions automatically expire 24 hours after they are created and do
        /// not require manual clean-up by the caller.
        /// </summary>
        /// <param name="tableReference">
        /// Required. Reference to the table to read.
        /// </param>
        /// <param name="parent">
        /// Required. String of the form `projects/{project_id}` indicating the
        /// project this ReadSession is associated with. This is the project that will
        /// be billed for usage.
        /// </param>
        /// <param name="requestedStreams">
        /// Initial number of streams. If unset or 0, we will
        /// provide a value of streams so as to produce reasonable throughput. Must be
        /// non-negative. The number of streams may be lower than the requested number,
        /// depending on the amount parallelism that is reasonable for the table and
        /// the maximum amount of parallelism allowed by the system.
        /// 
        /// Streams must be read starting from offset 0.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadSession> CreateReadSessionAsync(TableReference tableReference, string parent, int requestedStreams, gaxgrpc::CallSettings callSettings = null) =>
            CreateReadSessionAsync(new CreateReadSessionRequest
            {
                TableReference = gax::GaxPreconditions.CheckNotNull(tableReference, nameof(tableReference)),
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                RequestedStreams = requestedStreams,
            }, callSettings);

        /// <summary>
        /// Creates a new read session. A read session divides the contents of a
        /// BigQuery table into one or more streams, which can then be used to read
        /// data from the table. The read session also specifies properties of the
        /// data to be read, such as a list of columns or a push-down filter describing
        /// the rows to be returned.
        /// 
        /// A particular row can be read by at most one stream. When the caller has
        /// reached the end of each stream in the session, then all the data in the
        /// table has been read.
        /// 
        /// Read sessions automatically expire 24 hours after they are created and do
        /// not require manual clean-up by the caller.
        /// </summary>
        /// <param name="tableReference">
        /// Required. Reference to the table to read.
        /// </param>
        /// <param name="parent">
        /// Required. String of the form `projects/{project_id}` indicating the
        /// project this ReadSession is associated with. This is the project that will
        /// be billed for usage.
        /// </param>
        /// <param name="requestedStreams">
        /// Initial number of streams. If unset or 0, we will
        /// provide a value of streams so as to produce reasonable throughput. Must be
        /// non-negative. The number of streams may be lower than the requested number,
        /// depending on the amount parallelism that is reasonable for the table and
        /// the maximum amount of parallelism allowed by the system.
        /// 
        /// Streams must be read starting from offset 0.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadSession> CreateReadSessionAsync(TableReference tableReference, string parent, int requestedStreams, st::CancellationToken cancellationToken) =>
            CreateReadSessionAsync(tableReference, parent, requestedStreams, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new read session. A read session divides the contents of a
        /// BigQuery table into one or more streams, which can then be used to read
        /// data from the table. The read session also specifies properties of the
        /// data to be read, such as a list of columns or a push-down filter describing
        /// the rows to be returned.
        /// 
        /// A particular row can be read by at most one stream. When the caller has
        /// reached the end of each stream in the session, then all the data in the
        /// table has been read.
        /// 
        /// Read sessions automatically expire 24 hours after they are created and do
        /// not require manual clean-up by the caller.
        /// </summary>
        /// <param name="tableReference">
        /// Required. Reference to the table to read.
        /// </param>
        /// <param name="parent">
        /// Required. String of the form `projects/{project_id}` indicating the
        /// project this ReadSession is associated with. This is the project that will
        /// be billed for usage.
        /// </param>
        /// <param name="requestedStreams">
        /// Initial number of streams. If unset or 0, we will
        /// provide a value of streams so as to produce reasonable throughput. Must be
        /// non-negative. The number of streams may be lower than the requested number,
        /// depending on the amount parallelism that is reasonable for the table and
        /// the maximum amount of parallelism allowed by the system.
        /// 
        /// Streams must be read starting from offset 0.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReadSession CreateReadSession(TableReference tableReference, gagr::ProjectName parent, int requestedStreams, gaxgrpc::CallSettings callSettings = null) =>
            CreateReadSession(new CreateReadSessionRequest
            {
                TableReference = gax::GaxPreconditions.CheckNotNull(tableReference, nameof(tableReference)),
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                RequestedStreams = requestedStreams,
            }, callSettings);

        /// <summary>
        /// Creates a new read session. A read session divides the contents of a
        /// BigQuery table into one or more streams, which can then be used to read
        /// data from the table. The read session also specifies properties of the
        /// data to be read, such as a list of columns or a push-down filter describing
        /// the rows to be returned.
        /// 
        /// A particular row can be read by at most one stream. When the caller has
        /// reached the end of each stream in the session, then all the data in the
        /// table has been read.
        /// 
        /// Read sessions automatically expire 24 hours after they are created and do
        /// not require manual clean-up by the caller.
        /// </summary>
        /// <param name="tableReference">
        /// Required. Reference to the table to read.
        /// </param>
        /// <param name="parent">
        /// Required. String of the form `projects/{project_id}` indicating the
        /// project this ReadSession is associated with. This is the project that will
        /// be billed for usage.
        /// </param>
        /// <param name="requestedStreams">
        /// Initial number of streams. If unset or 0, we will
        /// provide a value of streams so as to produce reasonable throughput. Must be
        /// non-negative. The number of streams may be lower than the requested number,
        /// depending on the amount parallelism that is reasonable for the table and
        /// the maximum amount of parallelism allowed by the system.
        /// 
        /// Streams must be read starting from offset 0.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadSession> CreateReadSessionAsync(TableReference tableReference, gagr::ProjectName parent, int requestedStreams, gaxgrpc::CallSettings callSettings = null) =>
            CreateReadSessionAsync(new CreateReadSessionRequest
            {
                TableReference = gax::GaxPreconditions.CheckNotNull(tableReference, nameof(tableReference)),
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                RequestedStreams = requestedStreams,
            }, callSettings);

        /// <summary>
        /// Creates a new read session. A read session divides the contents of a
        /// BigQuery table into one or more streams, which can then be used to read
        /// data from the table. The read session also specifies properties of the
        /// data to be read, such as a list of columns or a push-down filter describing
        /// the rows to be returned.
        /// 
        /// A particular row can be read by at most one stream. When the caller has
        /// reached the end of each stream in the session, then all the data in the
        /// table has been read.
        /// 
        /// Read sessions automatically expire 24 hours after they are created and do
        /// not require manual clean-up by the caller.
        /// </summary>
        /// <param name="tableReference">
        /// Required. Reference to the table to read.
        /// </param>
        /// <param name="parent">
        /// Required. String of the form `projects/{project_id}` indicating the
        /// project this ReadSession is associated with. This is the project that will
        /// be billed for usage.
        /// </param>
        /// <param name="requestedStreams">
        /// Initial number of streams. If unset or 0, we will
        /// provide a value of streams so as to produce reasonable throughput. Must be
        /// non-negative. The number of streams may be lower than the requested number,
        /// depending on the amount parallelism that is reasonable for the table and
        /// the maximum amount of parallelism allowed by the system.
        /// 
        /// Streams must be read starting from offset 0.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadSession> CreateReadSessionAsync(TableReference tableReference, gagr::ProjectName parent, int requestedStreams, st::CancellationToken cancellationToken) =>
            CreateReadSessionAsync(tableReference, parent, requestedStreams, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Server streaming methods for <see cref="ReadRows(ReadRowsRequest,gaxgrpc::CallSettings)"/>.
        /// </summary>
        public abstract partial class ReadRowsStream : gaxgrpc::ServerStreamingBase<ReadRowsResponse>
        {
        }

        /// <summary>
        /// Reads rows from the table in the format prescribed by the read session.
        /// Each response contains one or more table rows, up to a maximum of 10 MiB
        /// per response; read requests which attempt to read individual rows larger
        /// than this will fail.
        /// 
        /// Each request also returns a set of stream statistics reflecting the
        /// estimated total number of rows in the read stream. This number is computed
        /// based on the total table size and the number of active streams in the read
        /// session, and may change as other streams continue to read data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual ReadRowsStream ReadRows(ReadRowsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reads rows from the table in the format prescribed by the read session.
        /// Each response contains one or more table rows, up to a maximum of 10 MiB
        /// per response; read requests which attempt to read individual rows larger
        /// than this will fail.
        /// 
        /// Each request also returns a set of stream statistics reflecting the
        /// estimated total number of rows in the read stream. This number is computed
        /// based on the total table size and the number of active streams in the read
        /// session, and may change as other streams continue to read data.
        /// </summary>
        /// <param name="readPosition">
        /// Required. Identifier of the position in the stream to start reading from.
        /// The offset requested must be less than the last row read from ReadRows.
        /// Requesting a larger offset is undefined.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual ReadRowsStream ReadRows(StreamPosition readPosition, gaxgrpc::CallSettings callSettings = null) =>
            ReadRows(new ReadRowsRequest
            {
                ReadPosition = gax::GaxPreconditions.CheckNotNull(readPosition, nameof(readPosition)),
            }, callSettings);

        /// <summary>
        /// Creates additional streams for a ReadSession. This API can be used to
        /// dynamically adjust the parallelism of a batch processing task upwards by
        /// adding additional workers.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateReadSessionStreamsResponse BatchCreateReadSessionStreams(BatchCreateReadSessionStreamsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates additional streams for a ReadSession. This API can be used to
        /// dynamically adjust the parallelism of a batch processing task upwards by
        /// adding additional workers.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateReadSessionStreamsResponse> BatchCreateReadSessionStreamsAsync(BatchCreateReadSessionStreamsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates additional streams for a ReadSession. This API can be used to
        /// dynamically adjust the parallelism of a batch processing task upwards by
        /// adding additional workers.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateReadSessionStreamsResponse> BatchCreateReadSessionStreamsAsync(BatchCreateReadSessionStreamsRequest request, st::CancellationToken cancellationToken) =>
            BatchCreateReadSessionStreamsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates additional streams for a ReadSession. This API can be used to
        /// dynamically adjust the parallelism of a batch processing task upwards by
        /// adding additional workers.
        /// </summary>
        /// <param name="session">
        /// Required. Must be a non-expired session obtained from a call to
        /// CreateReadSession. Only the name field needs to be set.
        /// </param>
        /// <param name="requestedStreams">
        /// Required. Number of new streams requested. Must be positive.
        /// Number of added streams may be less than this, see CreateReadSessionRequest
        /// for more information.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateReadSessionStreamsResponse BatchCreateReadSessionStreams(ReadSession session, int requestedStreams, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateReadSessionStreams(new BatchCreateReadSessionStreamsRequest
            {
                Session = gax::GaxPreconditions.CheckNotNull(session, nameof(session)),
                RequestedStreams = requestedStreams,
            }, callSettings);

        /// <summary>
        /// Creates additional streams for a ReadSession. This API can be used to
        /// dynamically adjust the parallelism of a batch processing task upwards by
        /// adding additional workers.
        /// </summary>
        /// <param name="session">
        /// Required. Must be a non-expired session obtained from a call to
        /// CreateReadSession. Only the name field needs to be set.
        /// </param>
        /// <param name="requestedStreams">
        /// Required. Number of new streams requested. Must be positive.
        /// Number of added streams may be less than this, see CreateReadSessionRequest
        /// for more information.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateReadSessionStreamsResponse> BatchCreateReadSessionStreamsAsync(ReadSession session, int requestedStreams, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateReadSessionStreamsAsync(new BatchCreateReadSessionStreamsRequest
            {
                Session = gax::GaxPreconditions.CheckNotNull(session, nameof(session)),
                RequestedStreams = requestedStreams,
            }, callSettings);

        /// <summary>
        /// Creates additional streams for a ReadSession. This API can be used to
        /// dynamically adjust the parallelism of a batch processing task upwards by
        /// adding additional workers.
        /// </summary>
        /// <param name="session">
        /// Required. Must be a non-expired session obtained from a call to
        /// CreateReadSession. Only the name field needs to be set.
        /// </param>
        /// <param name="requestedStreams">
        /// Required. Number of new streams requested. Must be positive.
        /// Number of added streams may be less than this, see CreateReadSessionRequest
        /// for more information.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateReadSessionStreamsResponse> BatchCreateReadSessionStreamsAsync(ReadSession session, int requestedStreams, st::CancellationToken cancellationToken) =>
            BatchCreateReadSessionStreamsAsync(session, requestedStreams, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Triggers the graceful termination of a single stream in a ReadSession. This
        /// API can be used to dynamically adjust the parallelism of a batch processing
        /// task downwards without losing data.
        /// 
        /// This API does not delete the stream -- it remains visible in the
        /// ReadSession, and any data processed by the stream is not released to other
        /// streams. However, no additional data will be assigned to the stream once
        /// this call completes. Callers must continue reading data on the stream until
        /// the end of the stream is reached so that data which has already been
        /// assigned to the stream will be processed.
        /// 
        /// This method will return an error if there are no other live streams
        /// in the Session, or if SplitReadStream() has been called on the given
        /// Stream.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void FinalizeStream(FinalizeStreamRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Triggers the graceful termination of a single stream in a ReadSession. This
        /// API can be used to dynamically adjust the parallelism of a batch processing
        /// task downwards without losing data.
        /// 
        /// This API does not delete the stream -- it remains visible in the
        /// ReadSession, and any data processed by the stream is not released to other
        /// streams. However, no additional data will be assigned to the stream once
        /// this call completes. Callers must continue reading data on the stream until
        /// the end of the stream is reached so that data which has already been
        /// assigned to the stream will be processed.
        /// 
        /// This method will return an error if there are no other live streams
        /// in the Session, or if SplitReadStream() has been called on the given
        /// Stream.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task FinalizeStreamAsync(FinalizeStreamRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Triggers the graceful termination of a single stream in a ReadSession. This
        /// API can be used to dynamically adjust the parallelism of a batch processing
        /// task downwards without losing data.
        /// 
        /// This API does not delete the stream -- it remains visible in the
        /// ReadSession, and any data processed by the stream is not released to other
        /// streams. However, no additional data will be assigned to the stream once
        /// this call completes. Callers must continue reading data on the stream until
        /// the end of the stream is reached so that data which has already been
        /// assigned to the stream will be processed.
        /// 
        /// This method will return an error if there are no other live streams
        /// in the Session, or if SplitReadStream() has been called on the given
        /// Stream.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task FinalizeStreamAsync(FinalizeStreamRequest request, st::CancellationToken cancellationToken) =>
            FinalizeStreamAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Triggers the graceful termination of a single stream in a ReadSession. This
        /// API can be used to dynamically adjust the parallelism of a batch processing
        /// task downwards without losing data.
        /// 
        /// This API does not delete the stream -- it remains visible in the
        /// ReadSession, and any data processed by the stream is not released to other
        /// streams. However, no additional data will be assigned to the stream once
        /// this call completes. Callers must continue reading data on the stream until
        /// the end of the stream is reached so that data which has already been
        /// assigned to the stream will be processed.
        /// 
        /// This method will return an error if there are no other live streams
        /// in the Session, or if SplitReadStream() has been called on the given
        /// Stream.
        /// </summary>
        /// <param name="stream">
        /// Required. Stream to finalize.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void FinalizeStream(Stream stream, gaxgrpc::CallSettings callSettings = null) =>
            FinalizeStream(new FinalizeStreamRequest
            {
                Stream = gax::GaxPreconditions.CheckNotNull(stream, nameof(stream)),
            }, callSettings);

        /// <summary>
        /// Triggers the graceful termination of a single stream in a ReadSession. This
        /// API can be used to dynamically adjust the parallelism of a batch processing
        /// task downwards without losing data.
        /// 
        /// This API does not delete the stream -- it remains visible in the
        /// ReadSession, and any data processed by the stream is not released to other
        /// streams. However, no additional data will be assigned to the stream once
        /// this call completes. Callers must continue reading data on the stream until
        /// the end of the stream is reached so that data which has already been
        /// assigned to the stream will be processed.
        /// 
        /// This method will return an error if there are no other live streams
        /// in the Session, or if SplitReadStream() has been called on the given
        /// Stream.
        /// </summary>
        /// <param name="stream">
        /// Required. Stream to finalize.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task FinalizeStreamAsync(Stream stream, gaxgrpc::CallSettings callSettings = null) =>
            FinalizeStreamAsync(new FinalizeStreamRequest
            {
                Stream = gax::GaxPreconditions.CheckNotNull(stream, nameof(stream)),
            }, callSettings);

        /// <summary>
        /// Triggers the graceful termination of a single stream in a ReadSession. This
        /// API can be used to dynamically adjust the parallelism of a batch processing
        /// task downwards without losing data.
        /// 
        /// This API does not delete the stream -- it remains visible in the
        /// ReadSession, and any data processed by the stream is not released to other
        /// streams. However, no additional data will be assigned to the stream once
        /// this call completes. Callers must continue reading data on the stream until
        /// the end of the stream is reached so that data which has already been
        /// assigned to the stream will be processed.
        /// 
        /// This method will return an error if there are no other live streams
        /// in the Session, or if SplitReadStream() has been called on the given
        /// Stream.
        /// </summary>
        /// <param name="stream">
        /// Required. Stream to finalize.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task FinalizeStreamAsync(Stream stream, st::CancellationToken cancellationToken) =>
            FinalizeStreamAsync(stream, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Splits a given read stream into two Streams. These streams are referred to
        /// as the primary and the residual of the split. The original stream can still
        /// be read from in the same manner as before. Both of the returned streams can
        /// also be read from, and the total rows return by both child streams will be
        /// the same as the rows read from the original stream.
        /// 
        /// Moreover, the two child streams will be allocated back to back in the
        /// original Stream. Concretely, it is guaranteed that for streams Original,
        /// Primary, and Residual, that Original[0-j] = Primary[0-j] and
        /// Original[j-n] = Residual[0-m] once the streams have been read to
        /// completion.
        /// 
        /// This method is guaranteed to be idempotent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SplitReadStreamResponse SplitReadStream(SplitReadStreamRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Splits a given read stream into two Streams. These streams are referred to
        /// as the primary and the residual of the split. The original stream can still
        /// be read from in the same manner as before. Both of the returned streams can
        /// also be read from, and the total rows return by both child streams will be
        /// the same as the rows read from the original stream.
        /// 
        /// Moreover, the two child streams will be allocated back to back in the
        /// original Stream. Concretely, it is guaranteed that for streams Original,
        /// Primary, and Residual, that Original[0-j] = Primary[0-j] and
        /// Original[j-n] = Residual[0-m] once the streams have been read to
        /// completion.
        /// 
        /// This method is guaranteed to be idempotent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SplitReadStreamResponse> SplitReadStreamAsync(SplitReadStreamRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Splits a given read stream into two Streams. These streams are referred to
        /// as the primary and the residual of the split. The original stream can still
        /// be read from in the same manner as before. Both of the returned streams can
        /// also be read from, and the total rows return by both child streams will be
        /// the same as the rows read from the original stream.
        /// 
        /// Moreover, the two child streams will be allocated back to back in the
        /// original Stream. Concretely, it is guaranteed that for streams Original,
        /// Primary, and Residual, that Original[0-j] = Primary[0-j] and
        /// Original[j-n] = Residual[0-m] once the streams have been read to
        /// completion.
        /// 
        /// This method is guaranteed to be idempotent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SplitReadStreamResponse> SplitReadStreamAsync(SplitReadStreamRequest request, st::CancellationToken cancellationToken) =>
            SplitReadStreamAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Splits a given read stream into two Streams. These streams are referred to
        /// as the primary and the residual of the split. The original stream can still
        /// be read from in the same manner as before. Both of the returned streams can
        /// also be read from, and the total rows return by both child streams will be
        /// the same as the rows read from the original stream.
        /// 
        /// Moreover, the two child streams will be allocated back to back in the
        /// original Stream. Concretely, it is guaranteed that for streams Original,
        /// Primary, and Residual, that Original[0-j] = Primary[0-j] and
        /// Original[j-n] = Residual[0-m] once the streams have been read to
        /// completion.
        /// 
        /// This method is guaranteed to be idempotent.
        /// </summary>
        /// <param name="originalStream">
        /// Required. Stream to split.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SplitReadStreamResponse SplitReadStream(Stream originalStream, gaxgrpc::CallSettings callSettings = null) =>
            SplitReadStream(new SplitReadStreamRequest
            {
                OriginalStream = gax::GaxPreconditions.CheckNotNull(originalStream, nameof(originalStream)),
            }, callSettings);

        /// <summary>
        /// Splits a given read stream into two Streams. These streams are referred to
        /// as the primary and the residual of the split. The original stream can still
        /// be read from in the same manner as before. Both of the returned streams can
        /// also be read from, and the total rows return by both child streams will be
        /// the same as the rows read from the original stream.
        /// 
        /// Moreover, the two child streams will be allocated back to back in the
        /// original Stream. Concretely, it is guaranteed that for streams Original,
        /// Primary, and Residual, that Original[0-j] = Primary[0-j] and
        /// Original[j-n] = Residual[0-m] once the streams have been read to
        /// completion.
        /// 
        /// This method is guaranteed to be idempotent.
        /// </summary>
        /// <param name="originalStream">
        /// Required. Stream to split.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SplitReadStreamResponse> SplitReadStreamAsync(Stream originalStream, gaxgrpc::CallSettings callSettings = null) =>
            SplitReadStreamAsync(new SplitReadStreamRequest
            {
                OriginalStream = gax::GaxPreconditions.CheckNotNull(originalStream, nameof(originalStream)),
            }, callSettings);

        /// <summary>
        /// Splits a given read stream into two Streams. These streams are referred to
        /// as the primary and the residual of the split. The original stream can still
        /// be read from in the same manner as before. Both of the returned streams can
        /// also be read from, and the total rows return by both child streams will be
        /// the same as the rows read from the original stream.
        /// 
        /// Moreover, the two child streams will be allocated back to back in the
        /// original Stream. Concretely, it is guaranteed that for streams Original,
        /// Primary, and Residual, that Original[0-j] = Primary[0-j] and
        /// Original[j-n] = Residual[0-m] once the streams have been read to
        /// completion.
        /// 
        /// This method is guaranteed to be idempotent.
        /// </summary>
        /// <param name="originalStream">
        /// Required. Stream to split.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SplitReadStreamResponse> SplitReadStreamAsync(Stream originalStream, st::CancellationToken cancellationToken) =>
            SplitReadStreamAsync(originalStream, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>BigQueryStorage client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// BigQuery storage API.
    /// 
    /// The BigQuery storage API can be used to read data stored in BigQuery.
    /// </remarks>
    public sealed partial class BigQueryStorageClientImpl : BigQueryStorageClient
    {
        private readonly gaxgrpc::ApiCall<CreateReadSessionRequest, ReadSession> _callCreateReadSession;

        private readonly gaxgrpc::ApiServerStreamingCall<ReadRowsRequest, ReadRowsResponse> _callReadRows;

        private readonly gaxgrpc::ApiCall<BatchCreateReadSessionStreamsRequest, BatchCreateReadSessionStreamsResponse> _callBatchCreateReadSessionStreams;

        private readonly gaxgrpc::ApiCall<FinalizeStreamRequest, wkt::Empty> _callFinalizeStream;

        private readonly gaxgrpc::ApiCall<SplitReadStreamRequest, SplitReadStreamResponse> _callSplitReadStream;

        /// <summary>
        /// Constructs a client wrapper for the BigQueryStorage service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="BigQueryStorageSettings"/> used within this client.</param>
        public BigQueryStorageClientImpl(BigQueryStorage.BigQueryStorageClient grpcClient, BigQueryStorageSettings settings)
        {
            GrpcClient = grpcClient;
            BigQueryStorageSettings effectiveSettings = settings ?? BigQueryStorageSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callCreateReadSession = clientHelper.BuildApiCall<CreateReadSessionRequest, ReadSession>(grpcClient.CreateReadSessionAsync, grpcClient.CreateReadSession, effectiveSettings.CreateReadSessionSettings).WithGoogleRequestParam("table_reference.project_id", request => request.TableReference?.ProjectId);
            Modify_ApiCall(ref _callCreateReadSession);
            Modify_CreateReadSessionApiCall(ref _callCreateReadSession);
            _callReadRows = clientHelper.BuildApiCall<ReadRowsRequest, ReadRowsResponse>(grpcClient.ReadRows, effectiveSettings.ReadRowsSettings);
            Modify_ApiCall(ref _callReadRows);
            Modify_ReadRowsApiCall(ref _callReadRows);
            _callBatchCreateReadSessionStreams = clientHelper.BuildApiCall<BatchCreateReadSessionStreamsRequest, BatchCreateReadSessionStreamsResponse>(grpcClient.BatchCreateReadSessionStreamsAsync, grpcClient.BatchCreateReadSessionStreams, effectiveSettings.BatchCreateReadSessionStreamsSettings).WithGoogleRequestParam("session.name", request => request.Session?.Name);
            Modify_ApiCall(ref _callBatchCreateReadSessionStreams);
            Modify_BatchCreateReadSessionStreamsApiCall(ref _callBatchCreateReadSessionStreams);
            _callFinalizeStream = clientHelper.BuildApiCall<FinalizeStreamRequest, wkt::Empty>(grpcClient.FinalizeStreamAsync, grpcClient.FinalizeStream, effectiveSettings.FinalizeStreamSettings).WithGoogleRequestParam("stream.name", request => request.Stream?.Name);
            Modify_ApiCall(ref _callFinalizeStream);
            Modify_FinalizeStreamApiCall(ref _callFinalizeStream);
            _callSplitReadStream = clientHelper.BuildApiCall<SplitReadStreamRequest, SplitReadStreamResponse>(grpcClient.SplitReadStreamAsync, grpcClient.SplitReadStream, effectiveSettings.SplitReadStreamSettings).WithGoogleRequestParam("original_stream.name", request => request.OriginalStream?.Name);
            Modify_ApiCall(ref _callSplitReadStream);
            Modify_SplitReadStreamApiCall(ref _callSplitReadStream);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiServerStreamingCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateReadSessionApiCall(ref gaxgrpc::ApiCall<CreateReadSessionRequest, ReadSession> call);

        partial void Modify_ReadRowsApiCall(ref gaxgrpc::ApiServerStreamingCall<ReadRowsRequest, ReadRowsResponse> call);

        partial void Modify_BatchCreateReadSessionStreamsApiCall(ref gaxgrpc::ApiCall<BatchCreateReadSessionStreamsRequest, BatchCreateReadSessionStreamsResponse> call);

        partial void Modify_FinalizeStreamApiCall(ref gaxgrpc::ApiCall<FinalizeStreamRequest, wkt::Empty> call);

        partial void Modify_SplitReadStreamApiCall(ref gaxgrpc::ApiCall<SplitReadStreamRequest, SplitReadStreamResponse> call);

        partial void OnConstruction(BigQueryStorage.BigQueryStorageClient grpcClient, BigQueryStorageSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC BigQueryStorage client</summary>
        public override BigQueryStorage.BigQueryStorageClient GrpcClient { get; }

        partial void Modify_CreateReadSessionRequest(ref CreateReadSessionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ReadRowsRequest(ref ReadRowsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchCreateReadSessionStreamsRequest(ref BatchCreateReadSessionStreamsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_FinalizeStreamRequest(ref FinalizeStreamRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SplitReadStreamRequest(ref SplitReadStreamRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a new read session. A read session divides the contents of a
        /// BigQuery table into one or more streams, which can then be used to read
        /// data from the table. The read session also specifies properties of the
        /// data to be read, such as a list of columns or a push-down filter describing
        /// the rows to be returned.
        /// 
        /// A particular row can be read by at most one stream. When the caller has
        /// reached the end of each stream in the session, then all the data in the
        /// table has been read.
        /// 
        /// Read sessions automatically expire 24 hours after they are created and do
        /// not require manual clean-up by the caller.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ReadSession CreateReadSession(CreateReadSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateReadSessionRequest(ref request, ref callSettings);
            return _callCreateReadSession.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new read session. A read session divides the contents of a
        /// BigQuery table into one or more streams, which can then be used to read
        /// data from the table. The read session also specifies properties of the
        /// data to be read, such as a list of columns or a push-down filter describing
        /// the rows to be returned.
        /// 
        /// A particular row can be read by at most one stream. When the caller has
        /// reached the end of each stream in the session, then all the data in the
        /// table has been read.
        /// 
        /// Read sessions automatically expire 24 hours after they are created and do
        /// not require manual clean-up by the caller.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ReadSession> CreateReadSessionAsync(CreateReadSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateReadSessionRequest(ref request, ref callSettings);
            return _callCreateReadSession.Async(request, callSettings);
        }

        internal sealed partial class ReadRowsStreamImpl : ReadRowsStream
        {
            /// <summary>Construct the server streaming method for <c>ReadRows</c>.</summary>
            /// <param name="call">The underlying gRPC server streaming call.</param>
            public ReadRowsStreamImpl(grpccore::AsyncServerStreamingCall<ReadRowsResponse> call) => GrpcCall = call;

            public override grpccore::AsyncServerStreamingCall<ReadRowsResponse> GrpcCall { get; }
        }

        /// <summary>
        /// Reads rows from the table in the format prescribed by the read session.
        /// Each response contains one or more table rows, up to a maximum of 10 MiB
        /// per response; read requests which attempt to read individual rows larger
        /// than this will fail.
        /// 
        /// Each request also returns a set of stream statistics reflecting the
        /// estimated total number of rows in the read stream. This number is computed
        /// based on the total table size and the number of active streams in the read
        /// session, and may change as other streams continue to read data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public override BigQueryStorageClient.ReadRowsStream ReadRows(ReadRowsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReadRowsRequest(ref request, ref callSettings);
            return new ReadRowsStreamImpl(_callReadRows.Call(request, callSettings));
        }

        /// <summary>
        /// Creates additional streams for a ReadSession. This API can be used to
        /// dynamically adjust the parallelism of a batch processing task upwards by
        /// adding additional workers.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchCreateReadSessionStreamsResponse BatchCreateReadSessionStreams(BatchCreateReadSessionStreamsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateReadSessionStreamsRequest(ref request, ref callSettings);
            return _callBatchCreateReadSessionStreams.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates additional streams for a ReadSession. This API can be used to
        /// dynamically adjust the parallelism of a batch processing task upwards by
        /// adding additional workers.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchCreateReadSessionStreamsResponse> BatchCreateReadSessionStreamsAsync(BatchCreateReadSessionStreamsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateReadSessionStreamsRequest(ref request, ref callSettings);
            return _callBatchCreateReadSessionStreams.Async(request, callSettings);
        }

        /// <summary>
        /// Triggers the graceful termination of a single stream in a ReadSession. This
        /// API can be used to dynamically adjust the parallelism of a batch processing
        /// task downwards without losing data.
        /// 
        /// This API does not delete the stream -- it remains visible in the
        /// ReadSession, and any data processed by the stream is not released to other
        /// streams. However, no additional data will be assigned to the stream once
        /// this call completes. Callers must continue reading data on the stream until
        /// the end of the stream is reached so that data which has already been
        /// assigned to the stream will be processed.
        /// 
        /// This method will return an error if there are no other live streams
        /// in the Session, or if SplitReadStream() has been called on the given
        /// Stream.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void FinalizeStream(FinalizeStreamRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FinalizeStreamRequest(ref request, ref callSettings);
            _callFinalizeStream.Sync(request, callSettings);
        }

        /// <summary>
        /// Triggers the graceful termination of a single stream in a ReadSession. This
        /// API can be used to dynamically adjust the parallelism of a batch processing
        /// task downwards without losing data.
        /// 
        /// This API does not delete the stream -- it remains visible in the
        /// ReadSession, and any data processed by the stream is not released to other
        /// streams. However, no additional data will be assigned to the stream once
        /// this call completes. Callers must continue reading data on the stream until
        /// the end of the stream is reached so that data which has already been
        /// assigned to the stream will be processed.
        /// 
        /// This method will return an error if there are no other live streams
        /// in the Session, or if SplitReadStream() has been called on the given
        /// Stream.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task FinalizeStreamAsync(FinalizeStreamRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FinalizeStreamRequest(ref request, ref callSettings);
            return _callFinalizeStream.Async(request, callSettings);
        }

        /// <summary>
        /// Splits a given read stream into two Streams. These streams are referred to
        /// as the primary and the residual of the split. The original stream can still
        /// be read from in the same manner as before. Both of the returned streams can
        /// also be read from, and the total rows return by both child streams will be
        /// the same as the rows read from the original stream.
        /// 
        /// Moreover, the two child streams will be allocated back to back in the
        /// original Stream. Concretely, it is guaranteed that for streams Original,
        /// Primary, and Residual, that Original[0-j] = Primary[0-j] and
        /// Original[j-n] = Residual[0-m] once the streams have been read to
        /// completion.
        /// 
        /// This method is guaranteed to be idempotent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SplitReadStreamResponse SplitReadStream(SplitReadStreamRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SplitReadStreamRequest(ref request, ref callSettings);
            return _callSplitReadStream.Sync(request, callSettings);
        }

        /// <summary>
        /// Splits a given read stream into two Streams. These streams are referred to
        /// as the primary and the residual of the split. The original stream can still
        /// be read from in the same manner as before. Both of the returned streams can
        /// also be read from, and the total rows return by both child streams will be
        /// the same as the rows read from the original stream.
        /// 
        /// Moreover, the two child streams will be allocated back to back in the
        /// original Stream. Concretely, it is guaranteed that for streams Original,
        /// Primary, and Residual, that Original[0-j] = Primary[0-j] and
        /// Original[j-n] = Residual[0-m] once the streams have been read to
        /// completion.
        /// 
        /// This method is guaranteed to be idempotent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SplitReadStreamResponse> SplitReadStreamAsync(SplitReadStreamRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SplitReadStreamRequest(ref request, ref callSettings);
            return _callSplitReadStream.Async(request, callSettings);
        }
    }
}
