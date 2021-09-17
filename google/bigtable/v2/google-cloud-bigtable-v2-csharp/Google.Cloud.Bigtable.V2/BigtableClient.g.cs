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
using linq = System.Linq;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Bigtable.V2
{
    /// <summary>Settings for <see cref="BigtableClient"/> instances.</summary>
    public sealed partial class BigtableSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="BigtableSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="BigtableSettings"/>.</returns>
        public static BigtableSettings GetDefault() => new BigtableSettings();

        /// <summary>Constructs a new <see cref="BigtableSettings"/> object with default settings.</summary>
        public BigtableSettings()
        {
        }

        private BigtableSettings(BigtableSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ReadRowsSettings = existing.ReadRowsSettings;
            SampleRowKeysSettings = existing.SampleRowKeysSettings;
            MutateRowSettings = existing.MutateRowSettings;
            MutateRowsSettings = existing.MutateRowsSettings;
            CheckAndMutateRowSettings = existing.CheckAndMutateRowSettings;
            ReadModifyWriteRowSettings = existing.ReadModifyWriteRowSettings;
            OnCopy(existing);
        }

        partial void OnCopy(BigtableSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>BigtableClient.ReadRows</c>
        /// and <c>BigtableClient.ReadRowsAsync</c>.
        /// </summary>
        /// <remarks>Timeout: 43200 seconds.</remarks>
        public gaxgrpc::CallSettings ReadRowsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(43200000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableClient.SampleRowKeys</c> and <c>BigtableClient.SampleRowKeysAsync</c>.
        /// </summary>
        /// <remarks>Timeout: 60 seconds.</remarks>
        public gaxgrpc::CallSettings SampleRowKeysSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>BigtableClient.MutateRow</c>
        ///  and <c>BigtableClient.MutateRowAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 10 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MutateRowSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(10), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>BigtableClient.MutateRows</c>
        ///  and <c>BigtableClient.MutateRowsAsync</c>.
        /// </summary>
        /// <remarks>Timeout: 600 seconds.</remarks>
        public gaxgrpc::CallSettings MutateRowsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableClient.CheckAndMutateRow</c> and <c>BigtableClient.CheckAndMutateRowAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 10 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 20 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CheckAndMutateRowSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(20000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(10), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes()));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BigtableClient.ReadModifyWriteRow</c> and <c>BigtableClient.ReadModifyWriteRowAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 10 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 2</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 20 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ReadModifyWriteRowSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(20000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(10), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 2, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes()));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="BigtableSettings"/> object.</returns>
        public BigtableSettings Clone() => new BigtableSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="BigtableClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class BigtableClientBuilder : gaxgrpc::ClientBuilderBase<BigtableClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public BigtableSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public BigtableClientBuilder()
        {
            UseJwtAccessWithScopes = BigtableClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref BigtableClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<BigtableClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override BigtableClient Build()
        {
            BigtableClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<BigtableClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<BigtableClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private BigtableClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return BigtableClient.Create(callInvoker, Settings);
        }

        private async stt::Task<BigtableClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return BigtableClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => BigtableClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => BigtableClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => BigtableClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>Bigtable client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for reading from and writing to existing Bigtable tables.
    /// </remarks>
    public abstract partial class BigtableClient
    {
        /// <summary>
        /// The default endpoint for the Bigtable service, which is a host of "bigtable.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "bigtable.googleapis.com:443";

        /// <summary>The default Bigtable scopes.</summary>
        /// <remarks>
        /// The default Bigtable scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/bigtable.data</description></item>
        /// <item><description>https://www.googleapis.com/auth/bigtable.data.readonly</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-bigtable.data</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-bigtable.data.readonly</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform.read-only</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/bigtable.data",
            "https://www.googleapis.com/auth/bigtable.data.readonly",
            "https://www.googleapis.com/auth/cloud-bigtable.data",
            "https://www.googleapis.com/auth/cloud-bigtable.data.readonly",
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/cloud-platform.read-only",
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
        /// Asynchronously creates a <see cref="BigtableClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="BigtableClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="BigtableClient"/>.</returns>
        public static stt::Task<BigtableClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new BigtableClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="BigtableClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="BigtableClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="BigtableClient"/>.</returns>
        public static BigtableClient Create() => new BigtableClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="BigtableClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="BigtableSettings"/>.</param>
        /// <returns>The created <see cref="BigtableClient"/>.</returns>
        internal static BigtableClient Create(grpccore::CallInvoker callInvoker, BigtableSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Bigtable.BigtableClient grpcClient = new Bigtable.BigtableClient(callInvoker);
            return new BigtableClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC Bigtable client</summary>
        public virtual Bigtable.BigtableClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Server streaming methods for <see cref="ReadRows(ReadRowsRequest,gaxgrpc::CallSettings)"/>.
        /// </summary>
        public abstract partial class ReadRowsStream : gaxgrpc::ServerStreamingBase<ReadRowsResponse>
        {
        }

        /// <summary>
        /// Streams back the contents of all requested rows in key order, optionally
        /// applying the same Reader filter to each. Depending on their size,
        /// rows and cells may be broken up across multiple responses, but
        /// atomicity of each row will still be preserved. See the
        /// ReadRowsResponse documentation for details.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual ReadRowsStream ReadRows(ReadRowsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Streams back the contents of all requested rows in key order, optionally
        /// applying the same Reader filter to each. Depending on their size,
        /// rows and cells may be broken up across multiple responses, but
        /// atomicity of each row will still be preserved. See the
        /// ReadRowsResponse documentation for details.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table from which to read.
        /// Values are of the form
        /// `projects/&amp;lt;project&amp;gt;/instances/&amp;lt;instance&amp;gt;/tables/&amp;lt;table&amp;gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual ReadRowsStream ReadRows(string tableName, gaxgrpc::CallSettings callSettings = null) =>
            ReadRows(new ReadRowsRequest
            {
                TableName = gax::GaxPreconditions.CheckNotNullOrEmpty(tableName, nameof(tableName)),
            }, callSettings);

        /// <summary>
        /// Streams back the contents of all requested rows in key order, optionally
        /// applying the same Reader filter to each. Depending on their size,
        /// rows and cells may be broken up across multiple responses, but
        /// atomicity of each row will still be preserved. See the
        /// ReadRowsResponse documentation for details.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table from which to read.
        /// Values are of the form
        /// `projects/&amp;lt;project&amp;gt;/instances/&amp;lt;instance&amp;gt;/tables/&amp;lt;table&amp;gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual ReadRowsStream ReadRows(TableName tableName, gaxgrpc::CallSettings callSettings = null) =>
            ReadRows(new ReadRowsRequest
            {
                TableNameAsTableName = gax::GaxPreconditions.CheckNotNull(tableName, nameof(tableName)),
            }, callSettings);

        /// <summary>
        /// Streams back the contents of all requested rows in key order, optionally
        /// applying the same Reader filter to each. Depending on their size,
        /// rows and cells may be broken up across multiple responses, but
        /// atomicity of each row will still be preserved. See the
        /// ReadRowsResponse documentation for details.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table from which to read.
        /// Values are of the form
        /// `projects/&amp;lt;project&amp;gt;/instances/&amp;lt;instance&amp;gt;/tables/&amp;lt;table&amp;gt;`.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual ReadRowsStream ReadRows(string tableName, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            ReadRows(new ReadRowsRequest
            {
                TableName = gax::GaxPreconditions.CheckNotNullOrEmpty(tableName, nameof(tableName)),
                AppProfileId = appProfileId ?? "",
            }, callSettings);

        /// <summary>
        /// Streams back the contents of all requested rows in key order, optionally
        /// applying the same Reader filter to each. Depending on their size,
        /// rows and cells may be broken up across multiple responses, but
        /// atomicity of each row will still be preserved. See the
        /// ReadRowsResponse documentation for details.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table from which to read.
        /// Values are of the form
        /// `projects/&amp;lt;project&amp;gt;/instances/&amp;lt;instance&amp;gt;/tables/&amp;lt;table&amp;gt;`.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual ReadRowsStream ReadRows(TableName tableName, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            ReadRows(new ReadRowsRequest
            {
                TableNameAsTableName = gax::GaxPreconditions.CheckNotNull(tableName, nameof(tableName)),
                AppProfileId = appProfileId ?? "",
            }, callSettings);

        /// <summary>
        /// Server streaming methods for <see cref="SampleRowKeys(SampleRowKeysRequest,gaxgrpc::CallSettings)"/>.
        /// </summary>
        public abstract partial class SampleRowKeysStream : gaxgrpc::ServerStreamingBase<SampleRowKeysResponse>
        {
        }

        /// <summary>
        /// Returns a sample of row keys in the table. The returned row keys will
        /// delimit contiguous sections of the table of approximately equal size,
        /// which can be used to break up the data for distributed tasks like
        /// mapreduces.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual SampleRowKeysStream SampleRowKeys(SampleRowKeysRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a sample of row keys in the table. The returned row keys will
        /// delimit contiguous sections of the table of approximately equal size,
        /// which can be used to break up the data for distributed tasks like
        /// mapreduces.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table from which to sample row keys.
        /// Values are of the form
        /// `projects/&amp;lt;project&amp;gt;/instances/&amp;lt;instance&amp;gt;/tables/&amp;lt;table&amp;gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual SampleRowKeysStream SampleRowKeys(string tableName, gaxgrpc::CallSettings callSettings = null) =>
            SampleRowKeys(new SampleRowKeysRequest
            {
                TableName = gax::GaxPreconditions.CheckNotNullOrEmpty(tableName, nameof(tableName)),
            }, callSettings);

        /// <summary>
        /// Returns a sample of row keys in the table. The returned row keys will
        /// delimit contiguous sections of the table of approximately equal size,
        /// which can be used to break up the data for distributed tasks like
        /// mapreduces.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table from which to sample row keys.
        /// Values are of the form
        /// `projects/&amp;lt;project&amp;gt;/instances/&amp;lt;instance&amp;gt;/tables/&amp;lt;table&amp;gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual SampleRowKeysStream SampleRowKeys(TableName tableName, gaxgrpc::CallSettings callSettings = null) =>
            SampleRowKeys(new SampleRowKeysRequest
            {
                TableNameAsTableName = gax::GaxPreconditions.CheckNotNull(tableName, nameof(tableName)),
            }, callSettings);

        /// <summary>
        /// Returns a sample of row keys in the table. The returned row keys will
        /// delimit contiguous sections of the table of approximately equal size,
        /// which can be used to break up the data for distributed tasks like
        /// mapreduces.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table from which to sample row keys.
        /// Values are of the form
        /// `projects/&amp;lt;project&amp;gt;/instances/&amp;lt;instance&amp;gt;/tables/&amp;lt;table&amp;gt;`.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual SampleRowKeysStream SampleRowKeys(string tableName, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            SampleRowKeys(new SampleRowKeysRequest
            {
                TableName = gax::GaxPreconditions.CheckNotNullOrEmpty(tableName, nameof(tableName)),
                AppProfileId = appProfileId ?? "",
            }, callSettings);

        /// <summary>
        /// Returns a sample of row keys in the table. The returned row keys will
        /// delimit contiguous sections of the table of approximately equal size,
        /// which can be used to break up the data for distributed tasks like
        /// mapreduces.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table from which to sample row keys.
        /// Values are of the form
        /// `projects/&amp;lt;project&amp;gt;/instances/&amp;lt;instance&amp;gt;/tables/&amp;lt;table&amp;gt;`.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual SampleRowKeysStream SampleRowKeys(TableName tableName, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            SampleRowKeys(new SampleRowKeysRequest
            {
                TableNameAsTableName = gax::GaxPreconditions.CheckNotNull(tableName, nameof(tableName)),
                AppProfileId = appProfileId ?? "",
            }, callSettings);

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by `mutation`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateRowResponse MutateRow(MutateRowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by `mutation`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateRowResponse> MutateRowAsync(MutateRowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by `mutation`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateRowResponse> MutateRowAsync(MutateRowRequest request, st::CancellationToken cancellationToken) =>
            MutateRowAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by `mutation`.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table to which the mutation should be applied.
        /// Values are of the form
        /// `projects/&amp;lt;project&amp;gt;/instances/&amp;lt;instance&amp;gt;/tables/&amp;lt;table&amp;gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the mutation should be applied.
        /// </param>
        /// <param name="mutations">
        /// Required. Changes to be atomically applied to the specified row. Entries are applied
        /// in order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry and at most 100000.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateRowResponse MutateRow(string tableName, proto::ByteString rowKey, scg::IEnumerable<Mutation> mutations, gaxgrpc::CallSettings callSettings = null) =>
            MutateRow(new MutateRowRequest
            {
                TableName = gax::GaxPreconditions.CheckNotNullOrEmpty(tableName, nameof(tableName)),
                RowKey = gax::GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                Mutations =
                {
                    gax::GaxPreconditions.CheckNotNull(mutations, nameof(mutations)),
                },
            }, callSettings);

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by `mutation`.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table to which the mutation should be applied.
        /// Values are of the form
        /// `projects/&amp;lt;project&amp;gt;/instances/&amp;lt;instance&amp;gt;/tables/&amp;lt;table&amp;gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the mutation should be applied.
        /// </param>
        /// <param name="mutations">
        /// Required. Changes to be atomically applied to the specified row. Entries are applied
        /// in order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry and at most 100000.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateRowResponse> MutateRowAsync(string tableName, proto::ByteString rowKey, scg::IEnumerable<Mutation> mutations, gaxgrpc::CallSettings callSettings = null) =>
            MutateRowAsync(new MutateRowRequest
            {
                TableName = gax::GaxPreconditions.CheckNotNullOrEmpty(tableName, nameof(tableName)),
                RowKey = gax::GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                Mutations =
                {
                    gax::GaxPreconditions.CheckNotNull(mutations, nameof(mutations)),
                },
            }, callSettings);

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by `mutation`.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table to which the mutation should be applied.
        /// Values are of the form
        /// `projects/&amp;lt;project&amp;gt;/instances/&amp;lt;instance&amp;gt;/tables/&amp;lt;table&amp;gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the mutation should be applied.
        /// </param>
        /// <param name="mutations">
        /// Required. Changes to be atomically applied to the specified row. Entries are applied
        /// in order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry and at most 100000.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateRowResponse> MutateRowAsync(string tableName, proto::ByteString rowKey, scg::IEnumerable<Mutation> mutations, st::CancellationToken cancellationToken) =>
            MutateRowAsync(tableName, rowKey, mutations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by `mutation`.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table to which the mutation should be applied.
        /// Values are of the form
        /// `projects/&amp;lt;project&amp;gt;/instances/&amp;lt;instance&amp;gt;/tables/&amp;lt;table&amp;gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the mutation should be applied.
        /// </param>
        /// <param name="mutations">
        /// Required. Changes to be atomically applied to the specified row. Entries are applied
        /// in order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry and at most 100000.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateRowResponse MutateRow(TableName tableName, proto::ByteString rowKey, scg::IEnumerable<Mutation> mutations, gaxgrpc::CallSettings callSettings = null) =>
            MutateRow(new MutateRowRequest
            {
                TableNameAsTableName = gax::GaxPreconditions.CheckNotNull(tableName, nameof(tableName)),
                RowKey = gax::GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                Mutations =
                {
                    gax::GaxPreconditions.CheckNotNull(mutations, nameof(mutations)),
                },
            }, callSettings);

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by `mutation`.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table to which the mutation should be applied.
        /// Values are of the form
        /// `projects/&amp;lt;project&amp;gt;/instances/&amp;lt;instance&amp;gt;/tables/&amp;lt;table&amp;gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the mutation should be applied.
        /// </param>
        /// <param name="mutations">
        /// Required. Changes to be atomically applied to the specified row. Entries are applied
        /// in order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry and at most 100000.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateRowResponse> MutateRowAsync(TableName tableName, proto::ByteString rowKey, scg::IEnumerable<Mutation> mutations, gaxgrpc::CallSettings callSettings = null) =>
            MutateRowAsync(new MutateRowRequest
            {
                TableNameAsTableName = gax::GaxPreconditions.CheckNotNull(tableName, nameof(tableName)),
                RowKey = gax::GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                Mutations =
                {
                    gax::GaxPreconditions.CheckNotNull(mutations, nameof(mutations)),
                },
            }, callSettings);

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by `mutation`.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table to which the mutation should be applied.
        /// Values are of the form
        /// `projects/&amp;lt;project&amp;gt;/instances/&amp;lt;instance&amp;gt;/tables/&amp;lt;table&amp;gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the mutation should be applied.
        /// </param>
        /// <param name="mutations">
        /// Required. Changes to be atomically applied to the specified row. Entries are applied
        /// in order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry and at most 100000.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateRowResponse> MutateRowAsync(TableName tableName, proto::ByteString rowKey, scg::IEnumerable<Mutation> mutations, st::CancellationToken cancellationToken) =>
            MutateRowAsync(tableName, rowKey, mutations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by `mutation`.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table to which the mutation should be applied.
        /// Values are of the form
        /// `projects/&amp;lt;project&amp;gt;/instances/&amp;lt;instance&amp;gt;/tables/&amp;lt;table&amp;gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the mutation should be applied.
        /// </param>
        /// <param name="mutations">
        /// Required. Changes to be atomically applied to the specified row. Entries are applied
        /// in order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry and at most 100000.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateRowResponse MutateRow(string tableName, proto::ByteString rowKey, scg::IEnumerable<Mutation> mutations, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            MutateRow(new MutateRowRequest
            {
                TableName = gax::GaxPreconditions.CheckNotNullOrEmpty(tableName, nameof(tableName)),
                AppProfileId = appProfileId ?? "",
                RowKey = gax::GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                Mutations =
                {
                    gax::GaxPreconditions.CheckNotNull(mutations, nameof(mutations)),
                },
            }, callSettings);

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by `mutation`.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table to which the mutation should be applied.
        /// Values are of the form
        /// `projects/&amp;lt;project&amp;gt;/instances/&amp;lt;instance&amp;gt;/tables/&amp;lt;table&amp;gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the mutation should be applied.
        /// </param>
        /// <param name="mutations">
        /// Required. Changes to be atomically applied to the specified row. Entries are applied
        /// in order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry and at most 100000.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateRowResponse> MutateRowAsync(string tableName, proto::ByteString rowKey, scg::IEnumerable<Mutation> mutations, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            MutateRowAsync(new MutateRowRequest
            {
                TableName = gax::GaxPreconditions.CheckNotNullOrEmpty(tableName, nameof(tableName)),
                AppProfileId = appProfileId ?? "",
                RowKey = gax::GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                Mutations =
                {
                    gax::GaxPreconditions.CheckNotNull(mutations, nameof(mutations)),
                },
            }, callSettings);

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by `mutation`.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table to which the mutation should be applied.
        /// Values are of the form
        /// `projects/&amp;lt;project&amp;gt;/instances/&amp;lt;instance&amp;gt;/tables/&amp;lt;table&amp;gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the mutation should be applied.
        /// </param>
        /// <param name="mutations">
        /// Required. Changes to be atomically applied to the specified row. Entries are applied
        /// in order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry and at most 100000.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateRowResponse> MutateRowAsync(string tableName, proto::ByteString rowKey, scg::IEnumerable<Mutation> mutations, string appProfileId, st::CancellationToken cancellationToken) =>
            MutateRowAsync(tableName, rowKey, mutations, appProfileId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by `mutation`.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table to which the mutation should be applied.
        /// Values are of the form
        /// `projects/&amp;lt;project&amp;gt;/instances/&amp;lt;instance&amp;gt;/tables/&amp;lt;table&amp;gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the mutation should be applied.
        /// </param>
        /// <param name="mutations">
        /// Required. Changes to be atomically applied to the specified row. Entries are applied
        /// in order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry and at most 100000.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateRowResponse MutateRow(TableName tableName, proto::ByteString rowKey, scg::IEnumerable<Mutation> mutations, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            MutateRow(new MutateRowRequest
            {
                TableNameAsTableName = gax::GaxPreconditions.CheckNotNull(tableName, nameof(tableName)),
                AppProfileId = appProfileId ?? "",
                RowKey = gax::GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                Mutations =
                {
                    gax::GaxPreconditions.CheckNotNull(mutations, nameof(mutations)),
                },
            }, callSettings);

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by `mutation`.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table to which the mutation should be applied.
        /// Values are of the form
        /// `projects/&amp;lt;project&amp;gt;/instances/&amp;lt;instance&amp;gt;/tables/&amp;lt;table&amp;gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the mutation should be applied.
        /// </param>
        /// <param name="mutations">
        /// Required. Changes to be atomically applied to the specified row. Entries are applied
        /// in order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry and at most 100000.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateRowResponse> MutateRowAsync(TableName tableName, proto::ByteString rowKey, scg::IEnumerable<Mutation> mutations, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            MutateRowAsync(new MutateRowRequest
            {
                TableNameAsTableName = gax::GaxPreconditions.CheckNotNull(tableName, nameof(tableName)),
                AppProfileId = appProfileId ?? "",
                RowKey = gax::GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                Mutations =
                {
                    gax::GaxPreconditions.CheckNotNull(mutations, nameof(mutations)),
                },
            }, callSettings);

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by `mutation`.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table to which the mutation should be applied.
        /// Values are of the form
        /// `projects/&amp;lt;project&amp;gt;/instances/&amp;lt;instance&amp;gt;/tables/&amp;lt;table&amp;gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the mutation should be applied.
        /// </param>
        /// <param name="mutations">
        /// Required. Changes to be atomically applied to the specified row. Entries are applied
        /// in order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry and at most 100000.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateRowResponse> MutateRowAsync(TableName tableName, proto::ByteString rowKey, scg::IEnumerable<Mutation> mutations, string appProfileId, st::CancellationToken cancellationToken) =>
            MutateRowAsync(tableName, rowKey, mutations, appProfileId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Server streaming methods for <see cref="MutateRows(MutateRowsRequest,gaxgrpc::CallSettings)"/>.
        /// </summary>
        public abstract partial class MutateRowsStream : gaxgrpc::ServerStreamingBase<MutateRowsResponse>
        {
        }

        /// <summary>
        /// Mutates multiple rows in a batch. Each individual row is mutated
        /// atomically as in MutateRow, but the entire batch is not executed
        /// atomically.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual MutateRowsStream MutateRows(MutateRowsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Mutates multiple rows in a batch. Each individual row is mutated
        /// atomically as in MutateRow, but the entire batch is not executed
        /// atomically.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table to which the mutations should be applied.
        /// </param>
        /// <param name="entries">
        /// Required. The row keys and corresponding mutations to be applied in bulk.
        /// Each entry is applied as an atomic mutation, but the entries may be
        /// applied in arbitrary order (even between entries for the same row).
        /// At least one entry must be specified, and in total the entries can
        /// contain at most 100000 mutations.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual MutateRowsStream MutateRows(string tableName, scg::IEnumerable<MutateRowsRequest.Types.Entry> entries, gaxgrpc::CallSettings callSettings = null) =>
            MutateRows(new MutateRowsRequest
            {
                TableName = gax::GaxPreconditions.CheckNotNullOrEmpty(tableName, nameof(tableName)),
                Entries =
                {
                    gax::GaxPreconditions.CheckNotNull(entries, nameof(entries)),
                },
            }, callSettings);

        /// <summary>
        /// Mutates multiple rows in a batch. Each individual row is mutated
        /// atomically as in MutateRow, but the entire batch is not executed
        /// atomically.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table to which the mutations should be applied.
        /// </param>
        /// <param name="entries">
        /// Required. The row keys and corresponding mutations to be applied in bulk.
        /// Each entry is applied as an atomic mutation, but the entries may be
        /// applied in arbitrary order (even between entries for the same row).
        /// At least one entry must be specified, and in total the entries can
        /// contain at most 100000 mutations.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual MutateRowsStream MutateRows(TableName tableName, scg::IEnumerable<MutateRowsRequest.Types.Entry> entries, gaxgrpc::CallSettings callSettings = null) =>
            MutateRows(new MutateRowsRequest
            {
                TableNameAsTableName = gax::GaxPreconditions.CheckNotNull(tableName, nameof(tableName)),
                Entries =
                {
                    gax::GaxPreconditions.CheckNotNull(entries, nameof(entries)),
                },
            }, callSettings);

        /// <summary>
        /// Mutates multiple rows in a batch. Each individual row is mutated
        /// atomically as in MutateRow, but the entire batch is not executed
        /// atomically.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table to which the mutations should be applied.
        /// </param>
        /// <param name="entries">
        /// Required. The row keys and corresponding mutations to be applied in bulk.
        /// Each entry is applied as an atomic mutation, but the entries may be
        /// applied in arbitrary order (even between entries for the same row).
        /// At least one entry must be specified, and in total the entries can
        /// contain at most 100000 mutations.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual MutateRowsStream MutateRows(string tableName, scg::IEnumerable<MutateRowsRequest.Types.Entry> entries, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            MutateRows(new MutateRowsRequest
            {
                TableName = gax::GaxPreconditions.CheckNotNullOrEmpty(tableName, nameof(tableName)),
                AppProfileId = appProfileId ?? "",
                Entries =
                {
                    gax::GaxPreconditions.CheckNotNull(entries, nameof(entries)),
                },
            }, callSettings);

        /// <summary>
        /// Mutates multiple rows in a batch. Each individual row is mutated
        /// atomically as in MutateRow, but the entire batch is not executed
        /// atomically.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table to which the mutations should be applied.
        /// </param>
        /// <param name="entries">
        /// Required. The row keys and corresponding mutations to be applied in bulk.
        /// Each entry is applied as an atomic mutation, but the entries may be
        /// applied in arbitrary order (even between entries for the same row).
        /// At least one entry must be specified, and in total the entries can
        /// contain at most 100000 mutations.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual MutateRowsStream MutateRows(TableName tableName, scg::IEnumerable<MutateRowsRequest.Types.Entry> entries, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            MutateRows(new MutateRowsRequest
            {
                TableNameAsTableName = gax::GaxPreconditions.CheckNotNull(tableName, nameof(tableName)),
                AppProfileId = appProfileId ?? "",
                Entries =
                {
                    gax::GaxPreconditions.CheckNotNull(entries, nameof(entries)),
                },
            }, callSettings);

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CheckAndMutateRowResponse CheckAndMutateRow(CheckAndMutateRowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckAndMutateRowResponse> CheckAndMutateRowAsync(CheckAndMutateRowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckAndMutateRowResponse> CheckAndMutateRowAsync(CheckAndMutateRowRequest request, st::CancellationToken cancellationToken) =>
            CheckAndMutateRowAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table to which the conditional mutation should be
        /// applied.
        /// Values are of the form
        /// `projects/&amp;lt;project&amp;gt;/instances/&amp;lt;instance&amp;gt;/tables/&amp;lt;table&amp;gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the conditional mutation should be applied.
        /// </param>
        /// <param name="predicateFilter">
        /// The filter to be applied to the contents of the specified row. Depending
        /// on whether or not any results are yielded, either `true_mutations` or
        /// `false_mutations` will be executed. If unset, checks that the row contains
        /// any values at all.
        /// </param>
        /// <param name="trueMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// yields at least one cell when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `false_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="falseMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// does not yield any cells when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `true_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CheckAndMutateRowResponse CheckAndMutateRow(string tableName, proto::ByteString rowKey, RowFilter predicateFilter, scg::IEnumerable<Mutation> trueMutations, scg::IEnumerable<Mutation> falseMutations, gaxgrpc::CallSettings callSettings = null) =>
            CheckAndMutateRow(new CheckAndMutateRowRequest
            {
                TableName = gax::GaxPreconditions.CheckNotNullOrEmpty(tableName, nameof(tableName)),
                RowKey = gax::GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                PredicateFilter = predicateFilter,
                TrueMutations =
                {
                    trueMutations ?? linq::Enumerable.Empty<Mutation>(),
                },
                FalseMutations =
                {
                    falseMutations ?? linq::Enumerable.Empty<Mutation>(),
                },
            }, callSettings);

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table to which the conditional mutation should be
        /// applied.
        /// Values are of the form
        /// `projects/&amp;lt;project&amp;gt;/instances/&amp;lt;instance&amp;gt;/tables/&amp;lt;table&amp;gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the conditional mutation should be applied.
        /// </param>
        /// <param name="predicateFilter">
        /// The filter to be applied to the contents of the specified row. Depending
        /// on whether or not any results are yielded, either `true_mutations` or
        /// `false_mutations` will be executed. If unset, checks that the row contains
        /// any values at all.
        /// </param>
        /// <param name="trueMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// yields at least one cell when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `false_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="falseMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// does not yield any cells when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `true_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckAndMutateRowResponse> CheckAndMutateRowAsync(string tableName, proto::ByteString rowKey, RowFilter predicateFilter, scg::IEnumerable<Mutation> trueMutations, scg::IEnumerable<Mutation> falseMutations, gaxgrpc::CallSettings callSettings = null) =>
            CheckAndMutateRowAsync(new CheckAndMutateRowRequest
            {
                TableName = gax::GaxPreconditions.CheckNotNullOrEmpty(tableName, nameof(tableName)),
                RowKey = gax::GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                PredicateFilter = predicateFilter,
                TrueMutations =
                {
                    trueMutations ?? linq::Enumerable.Empty<Mutation>(),
                },
                FalseMutations =
                {
                    falseMutations ?? linq::Enumerable.Empty<Mutation>(),
                },
            }, callSettings);

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table to which the conditional mutation should be
        /// applied.
        /// Values are of the form
        /// `projects/&amp;lt;project&amp;gt;/instances/&amp;lt;instance&amp;gt;/tables/&amp;lt;table&amp;gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the conditional mutation should be applied.
        /// </param>
        /// <param name="predicateFilter">
        /// The filter to be applied to the contents of the specified row. Depending
        /// on whether or not any results are yielded, either `true_mutations` or
        /// `false_mutations` will be executed. If unset, checks that the row contains
        /// any values at all.
        /// </param>
        /// <param name="trueMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// yields at least one cell when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `false_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="falseMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// does not yield any cells when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `true_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckAndMutateRowResponse> CheckAndMutateRowAsync(string tableName, proto::ByteString rowKey, RowFilter predicateFilter, scg::IEnumerable<Mutation> trueMutations, scg::IEnumerable<Mutation> falseMutations, st::CancellationToken cancellationToken) =>
            CheckAndMutateRowAsync(tableName, rowKey, predicateFilter, trueMutations, falseMutations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table to which the conditional mutation should be
        /// applied.
        /// Values are of the form
        /// `projects/&amp;lt;project&amp;gt;/instances/&amp;lt;instance&amp;gt;/tables/&amp;lt;table&amp;gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the conditional mutation should be applied.
        /// </param>
        /// <param name="predicateFilter">
        /// The filter to be applied to the contents of the specified row. Depending
        /// on whether or not any results are yielded, either `true_mutations` or
        /// `false_mutations` will be executed. If unset, checks that the row contains
        /// any values at all.
        /// </param>
        /// <param name="trueMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// yields at least one cell when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `false_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="falseMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// does not yield any cells when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `true_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CheckAndMutateRowResponse CheckAndMutateRow(TableName tableName, proto::ByteString rowKey, RowFilter predicateFilter, scg::IEnumerable<Mutation> trueMutations, scg::IEnumerable<Mutation> falseMutations, gaxgrpc::CallSettings callSettings = null) =>
            CheckAndMutateRow(new CheckAndMutateRowRequest
            {
                TableNameAsTableName = gax::GaxPreconditions.CheckNotNull(tableName, nameof(tableName)),
                RowKey = gax::GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                PredicateFilter = predicateFilter,
                TrueMutations =
                {
                    trueMutations ?? linq::Enumerable.Empty<Mutation>(),
                },
                FalseMutations =
                {
                    falseMutations ?? linq::Enumerable.Empty<Mutation>(),
                },
            }, callSettings);

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table to which the conditional mutation should be
        /// applied.
        /// Values are of the form
        /// `projects/&amp;lt;project&amp;gt;/instances/&amp;lt;instance&amp;gt;/tables/&amp;lt;table&amp;gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the conditional mutation should be applied.
        /// </param>
        /// <param name="predicateFilter">
        /// The filter to be applied to the contents of the specified row. Depending
        /// on whether or not any results are yielded, either `true_mutations` or
        /// `false_mutations` will be executed. If unset, checks that the row contains
        /// any values at all.
        /// </param>
        /// <param name="trueMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// yields at least one cell when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `false_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="falseMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// does not yield any cells when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `true_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckAndMutateRowResponse> CheckAndMutateRowAsync(TableName tableName, proto::ByteString rowKey, RowFilter predicateFilter, scg::IEnumerable<Mutation> trueMutations, scg::IEnumerable<Mutation> falseMutations, gaxgrpc::CallSettings callSettings = null) =>
            CheckAndMutateRowAsync(new CheckAndMutateRowRequest
            {
                TableNameAsTableName = gax::GaxPreconditions.CheckNotNull(tableName, nameof(tableName)),
                RowKey = gax::GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                PredicateFilter = predicateFilter,
                TrueMutations =
                {
                    trueMutations ?? linq::Enumerable.Empty<Mutation>(),
                },
                FalseMutations =
                {
                    falseMutations ?? linq::Enumerable.Empty<Mutation>(),
                },
            }, callSettings);

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table to which the conditional mutation should be
        /// applied.
        /// Values are of the form
        /// `projects/&amp;lt;project&amp;gt;/instances/&amp;lt;instance&amp;gt;/tables/&amp;lt;table&amp;gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the conditional mutation should be applied.
        /// </param>
        /// <param name="predicateFilter">
        /// The filter to be applied to the contents of the specified row. Depending
        /// on whether or not any results are yielded, either `true_mutations` or
        /// `false_mutations` will be executed. If unset, checks that the row contains
        /// any values at all.
        /// </param>
        /// <param name="trueMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// yields at least one cell when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `false_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="falseMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// does not yield any cells when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `true_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckAndMutateRowResponse> CheckAndMutateRowAsync(TableName tableName, proto::ByteString rowKey, RowFilter predicateFilter, scg::IEnumerable<Mutation> trueMutations, scg::IEnumerable<Mutation> falseMutations, st::CancellationToken cancellationToken) =>
            CheckAndMutateRowAsync(tableName, rowKey, predicateFilter, trueMutations, falseMutations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table to which the conditional mutation should be
        /// applied.
        /// Values are of the form
        /// `projects/&amp;lt;project&amp;gt;/instances/&amp;lt;instance&amp;gt;/tables/&amp;lt;table&amp;gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the conditional mutation should be applied.
        /// </param>
        /// <param name="predicateFilter">
        /// The filter to be applied to the contents of the specified row. Depending
        /// on whether or not any results are yielded, either `true_mutations` or
        /// `false_mutations` will be executed. If unset, checks that the row contains
        /// any values at all.
        /// </param>
        /// <param name="trueMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// yields at least one cell when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `false_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="falseMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// does not yield any cells when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `true_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CheckAndMutateRowResponse CheckAndMutateRow(string tableName, proto::ByteString rowKey, RowFilter predicateFilter, scg::IEnumerable<Mutation> trueMutations, scg::IEnumerable<Mutation> falseMutations, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            CheckAndMutateRow(new CheckAndMutateRowRequest
            {
                TableName = gax::GaxPreconditions.CheckNotNullOrEmpty(tableName, nameof(tableName)),
                AppProfileId = appProfileId ?? "",
                RowKey = gax::GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                PredicateFilter = predicateFilter,
                TrueMutations =
                {
                    trueMutations ?? linq::Enumerable.Empty<Mutation>(),
                },
                FalseMutations =
                {
                    falseMutations ?? linq::Enumerable.Empty<Mutation>(),
                },
            }, callSettings);

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table to which the conditional mutation should be
        /// applied.
        /// Values are of the form
        /// `projects/&amp;lt;project&amp;gt;/instances/&amp;lt;instance&amp;gt;/tables/&amp;lt;table&amp;gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the conditional mutation should be applied.
        /// </param>
        /// <param name="predicateFilter">
        /// The filter to be applied to the contents of the specified row. Depending
        /// on whether or not any results are yielded, either `true_mutations` or
        /// `false_mutations` will be executed. If unset, checks that the row contains
        /// any values at all.
        /// </param>
        /// <param name="trueMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// yields at least one cell when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `false_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="falseMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// does not yield any cells when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `true_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckAndMutateRowResponse> CheckAndMutateRowAsync(string tableName, proto::ByteString rowKey, RowFilter predicateFilter, scg::IEnumerable<Mutation> trueMutations, scg::IEnumerable<Mutation> falseMutations, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            CheckAndMutateRowAsync(new CheckAndMutateRowRequest
            {
                TableName = gax::GaxPreconditions.CheckNotNullOrEmpty(tableName, nameof(tableName)),
                AppProfileId = appProfileId ?? "",
                RowKey = gax::GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                PredicateFilter = predicateFilter,
                TrueMutations =
                {
                    trueMutations ?? linq::Enumerable.Empty<Mutation>(),
                },
                FalseMutations =
                {
                    falseMutations ?? linq::Enumerable.Empty<Mutation>(),
                },
            }, callSettings);

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table to which the conditional mutation should be
        /// applied.
        /// Values are of the form
        /// `projects/&amp;lt;project&amp;gt;/instances/&amp;lt;instance&amp;gt;/tables/&amp;lt;table&amp;gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the conditional mutation should be applied.
        /// </param>
        /// <param name="predicateFilter">
        /// The filter to be applied to the contents of the specified row. Depending
        /// on whether or not any results are yielded, either `true_mutations` or
        /// `false_mutations` will be executed. If unset, checks that the row contains
        /// any values at all.
        /// </param>
        /// <param name="trueMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// yields at least one cell when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `false_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="falseMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// does not yield any cells when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `true_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckAndMutateRowResponse> CheckAndMutateRowAsync(string tableName, proto::ByteString rowKey, RowFilter predicateFilter, scg::IEnumerable<Mutation> trueMutations, scg::IEnumerable<Mutation> falseMutations, string appProfileId, st::CancellationToken cancellationToken) =>
            CheckAndMutateRowAsync(tableName, rowKey, predicateFilter, trueMutations, falseMutations, appProfileId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table to which the conditional mutation should be
        /// applied.
        /// Values are of the form
        /// `projects/&amp;lt;project&amp;gt;/instances/&amp;lt;instance&amp;gt;/tables/&amp;lt;table&amp;gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the conditional mutation should be applied.
        /// </param>
        /// <param name="predicateFilter">
        /// The filter to be applied to the contents of the specified row. Depending
        /// on whether or not any results are yielded, either `true_mutations` or
        /// `false_mutations` will be executed. If unset, checks that the row contains
        /// any values at all.
        /// </param>
        /// <param name="trueMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// yields at least one cell when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `false_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="falseMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// does not yield any cells when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `true_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CheckAndMutateRowResponse CheckAndMutateRow(TableName tableName, proto::ByteString rowKey, RowFilter predicateFilter, scg::IEnumerable<Mutation> trueMutations, scg::IEnumerable<Mutation> falseMutations, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            CheckAndMutateRow(new CheckAndMutateRowRequest
            {
                TableNameAsTableName = gax::GaxPreconditions.CheckNotNull(tableName, nameof(tableName)),
                AppProfileId = appProfileId ?? "",
                RowKey = gax::GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                PredicateFilter = predicateFilter,
                TrueMutations =
                {
                    trueMutations ?? linq::Enumerable.Empty<Mutation>(),
                },
                FalseMutations =
                {
                    falseMutations ?? linq::Enumerable.Empty<Mutation>(),
                },
            }, callSettings);

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table to which the conditional mutation should be
        /// applied.
        /// Values are of the form
        /// `projects/&amp;lt;project&amp;gt;/instances/&amp;lt;instance&amp;gt;/tables/&amp;lt;table&amp;gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the conditional mutation should be applied.
        /// </param>
        /// <param name="predicateFilter">
        /// The filter to be applied to the contents of the specified row. Depending
        /// on whether or not any results are yielded, either `true_mutations` or
        /// `false_mutations` will be executed. If unset, checks that the row contains
        /// any values at all.
        /// </param>
        /// <param name="trueMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// yields at least one cell when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `false_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="falseMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// does not yield any cells when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `true_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckAndMutateRowResponse> CheckAndMutateRowAsync(TableName tableName, proto::ByteString rowKey, RowFilter predicateFilter, scg::IEnumerable<Mutation> trueMutations, scg::IEnumerable<Mutation> falseMutations, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            CheckAndMutateRowAsync(new CheckAndMutateRowRequest
            {
                TableNameAsTableName = gax::GaxPreconditions.CheckNotNull(tableName, nameof(tableName)),
                AppProfileId = appProfileId ?? "",
                RowKey = gax::GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                PredicateFilter = predicateFilter,
                TrueMutations =
                {
                    trueMutations ?? linq::Enumerable.Empty<Mutation>(),
                },
                FalseMutations =
                {
                    falseMutations ?? linq::Enumerable.Empty<Mutation>(),
                },
            }, callSettings);

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table to which the conditional mutation should be
        /// applied.
        /// Values are of the form
        /// `projects/&amp;lt;project&amp;gt;/instances/&amp;lt;instance&amp;gt;/tables/&amp;lt;table&amp;gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the conditional mutation should be applied.
        /// </param>
        /// <param name="predicateFilter">
        /// The filter to be applied to the contents of the specified row. Depending
        /// on whether or not any results are yielded, either `true_mutations` or
        /// `false_mutations` will be executed. If unset, checks that the row contains
        /// any values at all.
        /// </param>
        /// <param name="trueMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// yields at least one cell when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `false_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="falseMutations">
        /// Changes to be atomically applied to the specified row if `predicate_filter`
        /// does not yield any cells when applied to `row_key`. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if `true_mutations` is empty, and at most
        /// 100000.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckAndMutateRowResponse> CheckAndMutateRowAsync(TableName tableName, proto::ByteString rowKey, RowFilter predicateFilter, scg::IEnumerable<Mutation> trueMutations, scg::IEnumerable<Mutation> falseMutations, string appProfileId, st::CancellationToken cancellationToken) =>
            CheckAndMutateRowAsync(tableName, rowKey, predicateFilter, trueMutations, falseMutations, appProfileId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Modifies a row atomically on the server. The method reads the latest
        /// existing timestamp and value from the specified columns and writes a new
        /// entry based on pre-defined read/modify/write rules. The new value for the
        /// timestamp is the greater of the existing timestamp or the current server
        /// time. The method returns the new contents of all modified cells.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReadModifyWriteRowResponse ReadModifyWriteRow(ReadModifyWriteRowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Modifies a row atomically on the server. The method reads the latest
        /// existing timestamp and value from the specified columns and writes a new
        /// entry based on pre-defined read/modify/write rules. The new value for the
        /// timestamp is the greater of the existing timestamp or the current server
        /// time. The method returns the new contents of all modified cells.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadModifyWriteRowResponse> ReadModifyWriteRowAsync(ReadModifyWriteRowRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Modifies a row atomically on the server. The method reads the latest
        /// existing timestamp and value from the specified columns and writes a new
        /// entry based on pre-defined read/modify/write rules. The new value for the
        /// timestamp is the greater of the existing timestamp or the current server
        /// time. The method returns the new contents of all modified cells.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadModifyWriteRowResponse> ReadModifyWriteRowAsync(ReadModifyWriteRowRequest request, st::CancellationToken cancellationToken) =>
            ReadModifyWriteRowAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Modifies a row atomically on the server. The method reads the latest
        /// existing timestamp and value from the specified columns and writes a new
        /// entry based on pre-defined read/modify/write rules. The new value for the
        /// timestamp is the greater of the existing timestamp or the current server
        /// time. The method returns the new contents of all modified cells.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table to which the read/modify/write rules should be
        /// applied.
        /// Values are of the form
        /// `projects/&amp;lt;project&amp;gt;/instances/&amp;lt;instance&amp;gt;/tables/&amp;lt;table&amp;gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the read/modify/write rules should be applied.
        /// </param>
        /// <param name="rules">
        /// Required. Rules specifying how the specified row's contents are to be transformed
        /// into writes. Entries are applied in order, meaning that earlier rules will
        /// affect the results of later ones.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReadModifyWriteRowResponse ReadModifyWriteRow(string tableName, proto::ByteString rowKey, scg::IEnumerable<ReadModifyWriteRule> rules, gaxgrpc::CallSettings callSettings = null) =>
            ReadModifyWriteRow(new ReadModifyWriteRowRequest
            {
                TableName = gax::GaxPreconditions.CheckNotNullOrEmpty(tableName, nameof(tableName)),
                RowKey = gax::GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                Rules =
                {
                    gax::GaxPreconditions.CheckNotNull(rules, nameof(rules)),
                },
            }, callSettings);

        /// <summary>
        /// Modifies a row atomically on the server. The method reads the latest
        /// existing timestamp and value from the specified columns and writes a new
        /// entry based on pre-defined read/modify/write rules. The new value for the
        /// timestamp is the greater of the existing timestamp or the current server
        /// time. The method returns the new contents of all modified cells.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table to which the read/modify/write rules should be
        /// applied.
        /// Values are of the form
        /// `projects/&amp;lt;project&amp;gt;/instances/&amp;lt;instance&amp;gt;/tables/&amp;lt;table&amp;gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the read/modify/write rules should be applied.
        /// </param>
        /// <param name="rules">
        /// Required. Rules specifying how the specified row's contents are to be transformed
        /// into writes. Entries are applied in order, meaning that earlier rules will
        /// affect the results of later ones.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadModifyWriteRowResponse> ReadModifyWriteRowAsync(string tableName, proto::ByteString rowKey, scg::IEnumerable<ReadModifyWriteRule> rules, gaxgrpc::CallSettings callSettings = null) =>
            ReadModifyWriteRowAsync(new ReadModifyWriteRowRequest
            {
                TableName = gax::GaxPreconditions.CheckNotNullOrEmpty(tableName, nameof(tableName)),
                RowKey = gax::GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                Rules =
                {
                    gax::GaxPreconditions.CheckNotNull(rules, nameof(rules)),
                },
            }, callSettings);

        /// <summary>
        /// Modifies a row atomically on the server. The method reads the latest
        /// existing timestamp and value from the specified columns and writes a new
        /// entry based on pre-defined read/modify/write rules. The new value for the
        /// timestamp is the greater of the existing timestamp or the current server
        /// time. The method returns the new contents of all modified cells.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table to which the read/modify/write rules should be
        /// applied.
        /// Values are of the form
        /// `projects/&amp;lt;project&amp;gt;/instances/&amp;lt;instance&amp;gt;/tables/&amp;lt;table&amp;gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the read/modify/write rules should be applied.
        /// </param>
        /// <param name="rules">
        /// Required. Rules specifying how the specified row's contents are to be transformed
        /// into writes. Entries are applied in order, meaning that earlier rules will
        /// affect the results of later ones.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadModifyWriteRowResponse> ReadModifyWriteRowAsync(string tableName, proto::ByteString rowKey, scg::IEnumerable<ReadModifyWriteRule> rules, st::CancellationToken cancellationToken) =>
            ReadModifyWriteRowAsync(tableName, rowKey, rules, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Modifies a row atomically on the server. The method reads the latest
        /// existing timestamp and value from the specified columns and writes a new
        /// entry based on pre-defined read/modify/write rules. The new value for the
        /// timestamp is the greater of the existing timestamp or the current server
        /// time. The method returns the new contents of all modified cells.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table to which the read/modify/write rules should be
        /// applied.
        /// Values are of the form
        /// `projects/&amp;lt;project&amp;gt;/instances/&amp;lt;instance&amp;gt;/tables/&amp;lt;table&amp;gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the read/modify/write rules should be applied.
        /// </param>
        /// <param name="rules">
        /// Required. Rules specifying how the specified row's contents are to be transformed
        /// into writes. Entries are applied in order, meaning that earlier rules will
        /// affect the results of later ones.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReadModifyWriteRowResponse ReadModifyWriteRow(TableName tableName, proto::ByteString rowKey, scg::IEnumerable<ReadModifyWriteRule> rules, gaxgrpc::CallSettings callSettings = null) =>
            ReadModifyWriteRow(new ReadModifyWriteRowRequest
            {
                TableNameAsTableName = gax::GaxPreconditions.CheckNotNull(tableName, nameof(tableName)),
                RowKey = gax::GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                Rules =
                {
                    gax::GaxPreconditions.CheckNotNull(rules, nameof(rules)),
                },
            }, callSettings);

        /// <summary>
        /// Modifies a row atomically on the server. The method reads the latest
        /// existing timestamp and value from the specified columns and writes a new
        /// entry based on pre-defined read/modify/write rules. The new value for the
        /// timestamp is the greater of the existing timestamp or the current server
        /// time. The method returns the new contents of all modified cells.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table to which the read/modify/write rules should be
        /// applied.
        /// Values are of the form
        /// `projects/&amp;lt;project&amp;gt;/instances/&amp;lt;instance&amp;gt;/tables/&amp;lt;table&amp;gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the read/modify/write rules should be applied.
        /// </param>
        /// <param name="rules">
        /// Required. Rules specifying how the specified row's contents are to be transformed
        /// into writes. Entries are applied in order, meaning that earlier rules will
        /// affect the results of later ones.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadModifyWriteRowResponse> ReadModifyWriteRowAsync(TableName tableName, proto::ByteString rowKey, scg::IEnumerable<ReadModifyWriteRule> rules, gaxgrpc::CallSettings callSettings = null) =>
            ReadModifyWriteRowAsync(new ReadModifyWriteRowRequest
            {
                TableNameAsTableName = gax::GaxPreconditions.CheckNotNull(tableName, nameof(tableName)),
                RowKey = gax::GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                Rules =
                {
                    gax::GaxPreconditions.CheckNotNull(rules, nameof(rules)),
                },
            }, callSettings);

        /// <summary>
        /// Modifies a row atomically on the server. The method reads the latest
        /// existing timestamp and value from the specified columns and writes a new
        /// entry based on pre-defined read/modify/write rules. The new value for the
        /// timestamp is the greater of the existing timestamp or the current server
        /// time. The method returns the new contents of all modified cells.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table to which the read/modify/write rules should be
        /// applied.
        /// Values are of the form
        /// `projects/&amp;lt;project&amp;gt;/instances/&amp;lt;instance&amp;gt;/tables/&amp;lt;table&amp;gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the read/modify/write rules should be applied.
        /// </param>
        /// <param name="rules">
        /// Required. Rules specifying how the specified row's contents are to be transformed
        /// into writes. Entries are applied in order, meaning that earlier rules will
        /// affect the results of later ones.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadModifyWriteRowResponse> ReadModifyWriteRowAsync(TableName tableName, proto::ByteString rowKey, scg::IEnumerable<ReadModifyWriteRule> rules, st::CancellationToken cancellationToken) =>
            ReadModifyWriteRowAsync(tableName, rowKey, rules, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Modifies a row atomically on the server. The method reads the latest
        /// existing timestamp and value from the specified columns and writes a new
        /// entry based on pre-defined read/modify/write rules. The new value for the
        /// timestamp is the greater of the existing timestamp or the current server
        /// time. The method returns the new contents of all modified cells.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table to which the read/modify/write rules should be
        /// applied.
        /// Values are of the form
        /// `projects/&amp;lt;project&amp;gt;/instances/&amp;lt;instance&amp;gt;/tables/&amp;lt;table&amp;gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the read/modify/write rules should be applied.
        /// </param>
        /// <param name="rules">
        /// Required. Rules specifying how the specified row's contents are to be transformed
        /// into writes. Entries are applied in order, meaning that earlier rules will
        /// affect the results of later ones.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReadModifyWriteRowResponse ReadModifyWriteRow(string tableName, proto::ByteString rowKey, scg::IEnumerable<ReadModifyWriteRule> rules, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            ReadModifyWriteRow(new ReadModifyWriteRowRequest
            {
                TableName = gax::GaxPreconditions.CheckNotNullOrEmpty(tableName, nameof(tableName)),
                AppProfileId = appProfileId ?? "",
                RowKey = gax::GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                Rules =
                {
                    gax::GaxPreconditions.CheckNotNull(rules, nameof(rules)),
                },
            }, callSettings);

        /// <summary>
        /// Modifies a row atomically on the server. The method reads the latest
        /// existing timestamp and value from the specified columns and writes a new
        /// entry based on pre-defined read/modify/write rules. The new value for the
        /// timestamp is the greater of the existing timestamp or the current server
        /// time. The method returns the new contents of all modified cells.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table to which the read/modify/write rules should be
        /// applied.
        /// Values are of the form
        /// `projects/&amp;lt;project&amp;gt;/instances/&amp;lt;instance&amp;gt;/tables/&amp;lt;table&amp;gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the read/modify/write rules should be applied.
        /// </param>
        /// <param name="rules">
        /// Required. Rules specifying how the specified row's contents are to be transformed
        /// into writes. Entries are applied in order, meaning that earlier rules will
        /// affect the results of later ones.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadModifyWriteRowResponse> ReadModifyWriteRowAsync(string tableName, proto::ByteString rowKey, scg::IEnumerable<ReadModifyWriteRule> rules, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            ReadModifyWriteRowAsync(new ReadModifyWriteRowRequest
            {
                TableName = gax::GaxPreconditions.CheckNotNullOrEmpty(tableName, nameof(tableName)),
                AppProfileId = appProfileId ?? "",
                RowKey = gax::GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                Rules =
                {
                    gax::GaxPreconditions.CheckNotNull(rules, nameof(rules)),
                },
            }, callSettings);

        /// <summary>
        /// Modifies a row atomically on the server. The method reads the latest
        /// existing timestamp and value from the specified columns and writes a new
        /// entry based on pre-defined read/modify/write rules. The new value for the
        /// timestamp is the greater of the existing timestamp or the current server
        /// time. The method returns the new contents of all modified cells.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table to which the read/modify/write rules should be
        /// applied.
        /// Values are of the form
        /// `projects/&amp;lt;project&amp;gt;/instances/&amp;lt;instance&amp;gt;/tables/&amp;lt;table&amp;gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the read/modify/write rules should be applied.
        /// </param>
        /// <param name="rules">
        /// Required. Rules specifying how the specified row's contents are to be transformed
        /// into writes. Entries are applied in order, meaning that earlier rules will
        /// affect the results of later ones.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadModifyWriteRowResponse> ReadModifyWriteRowAsync(string tableName, proto::ByteString rowKey, scg::IEnumerable<ReadModifyWriteRule> rules, string appProfileId, st::CancellationToken cancellationToken) =>
            ReadModifyWriteRowAsync(tableName, rowKey, rules, appProfileId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Modifies a row atomically on the server. The method reads the latest
        /// existing timestamp and value from the specified columns and writes a new
        /// entry based on pre-defined read/modify/write rules. The new value for the
        /// timestamp is the greater of the existing timestamp or the current server
        /// time. The method returns the new contents of all modified cells.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table to which the read/modify/write rules should be
        /// applied.
        /// Values are of the form
        /// `projects/&amp;lt;project&amp;gt;/instances/&amp;lt;instance&amp;gt;/tables/&amp;lt;table&amp;gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the read/modify/write rules should be applied.
        /// </param>
        /// <param name="rules">
        /// Required. Rules specifying how the specified row's contents are to be transformed
        /// into writes. Entries are applied in order, meaning that earlier rules will
        /// affect the results of later ones.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReadModifyWriteRowResponse ReadModifyWriteRow(TableName tableName, proto::ByteString rowKey, scg::IEnumerable<ReadModifyWriteRule> rules, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            ReadModifyWriteRow(new ReadModifyWriteRowRequest
            {
                TableNameAsTableName = gax::GaxPreconditions.CheckNotNull(tableName, nameof(tableName)),
                AppProfileId = appProfileId ?? "",
                RowKey = gax::GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                Rules =
                {
                    gax::GaxPreconditions.CheckNotNull(rules, nameof(rules)),
                },
            }, callSettings);

        /// <summary>
        /// Modifies a row atomically on the server. The method reads the latest
        /// existing timestamp and value from the specified columns and writes a new
        /// entry based on pre-defined read/modify/write rules. The new value for the
        /// timestamp is the greater of the existing timestamp or the current server
        /// time. The method returns the new contents of all modified cells.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table to which the read/modify/write rules should be
        /// applied.
        /// Values are of the form
        /// `projects/&amp;lt;project&amp;gt;/instances/&amp;lt;instance&amp;gt;/tables/&amp;lt;table&amp;gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the read/modify/write rules should be applied.
        /// </param>
        /// <param name="rules">
        /// Required. Rules specifying how the specified row's contents are to be transformed
        /// into writes. Entries are applied in order, meaning that earlier rules will
        /// affect the results of later ones.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadModifyWriteRowResponse> ReadModifyWriteRowAsync(TableName tableName, proto::ByteString rowKey, scg::IEnumerable<ReadModifyWriteRule> rules, string appProfileId, gaxgrpc::CallSettings callSettings = null) =>
            ReadModifyWriteRowAsync(new ReadModifyWriteRowRequest
            {
                TableNameAsTableName = gax::GaxPreconditions.CheckNotNull(tableName, nameof(tableName)),
                AppProfileId = appProfileId ?? "",
                RowKey = gax::GaxPreconditions.CheckNotNull(rowKey, nameof(rowKey)),
                Rules =
                {
                    gax::GaxPreconditions.CheckNotNull(rules, nameof(rules)),
                },
            }, callSettings);

        /// <summary>
        /// Modifies a row atomically on the server. The method reads the latest
        /// existing timestamp and value from the specified columns and writes a new
        /// entry based on pre-defined read/modify/write rules. The new value for the
        /// timestamp is the greater of the existing timestamp or the current server
        /// time. The method returns the new contents of all modified cells.
        /// </summary>
        /// <param name="tableName">
        /// Required. The unique name of the table to which the read/modify/write rules should be
        /// applied.
        /// Values are of the form
        /// `projects/&amp;lt;project&amp;gt;/instances/&amp;lt;instance&amp;gt;/tables/&amp;lt;table&amp;gt;`.
        /// </param>
        /// <param name="rowKey">
        /// Required. The key of the row to which the read/modify/write rules should be applied.
        /// </param>
        /// <param name="rules">
        /// Required. Rules specifying how the specified row's contents are to be transformed
        /// into writes. Entries are applied in order, meaning that earlier rules will
        /// affect the results of later ones.
        /// </param>
        /// <param name="appProfileId">
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReadModifyWriteRowResponse> ReadModifyWriteRowAsync(TableName tableName, proto::ByteString rowKey, scg::IEnumerable<ReadModifyWriteRule> rules, string appProfileId, st::CancellationToken cancellationToken) =>
            ReadModifyWriteRowAsync(tableName, rowKey, rules, appProfileId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Bigtable client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for reading from and writing to existing Bigtable tables.
    /// </remarks>
    public sealed partial class BigtableClientImpl : BigtableClient
    {
        private readonly gaxgrpc::ApiServerStreamingCall<ReadRowsRequest, ReadRowsResponse> _callReadRows;

        private readonly gaxgrpc::ApiServerStreamingCall<SampleRowKeysRequest, SampleRowKeysResponse> _callSampleRowKeys;

        private readonly gaxgrpc::ApiCall<MutateRowRequest, MutateRowResponse> _callMutateRow;

        private readonly gaxgrpc::ApiServerStreamingCall<MutateRowsRequest, MutateRowsResponse> _callMutateRows;

        private readonly gaxgrpc::ApiCall<CheckAndMutateRowRequest, CheckAndMutateRowResponse> _callCheckAndMutateRow;

        private readonly gaxgrpc::ApiCall<ReadModifyWriteRowRequest, ReadModifyWriteRowResponse> _callReadModifyWriteRow;

        /// <summary>
        /// Constructs a client wrapper for the Bigtable service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="BigtableSettings"/> used within this client.</param>
        public BigtableClientImpl(Bigtable.BigtableClient grpcClient, BigtableSettings settings)
        {
            GrpcClient = grpcClient;
            BigtableSettings effectiveSettings = settings ?? BigtableSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callReadRows = clientHelper.BuildApiCall<ReadRowsRequest, ReadRowsResponse>(grpcClient.ReadRows, effectiveSettings.ReadRowsSettings).WithGoogleRequestParam("table_name", request => request.TableName);
            Modify_ApiCall(ref _callReadRows);
            Modify_ReadRowsApiCall(ref _callReadRows);
            _callSampleRowKeys = clientHelper.BuildApiCall<SampleRowKeysRequest, SampleRowKeysResponse>(grpcClient.SampleRowKeys, effectiveSettings.SampleRowKeysSettings).WithGoogleRequestParam("table_name", request => request.TableName);
            Modify_ApiCall(ref _callSampleRowKeys);
            Modify_SampleRowKeysApiCall(ref _callSampleRowKeys);
            _callMutateRow = clientHelper.BuildApiCall<MutateRowRequest, MutateRowResponse>(grpcClient.MutateRowAsync, grpcClient.MutateRow, effectiveSettings.MutateRowSettings).WithGoogleRequestParam("table_name", request => request.TableName);
            Modify_ApiCall(ref _callMutateRow);
            Modify_MutateRowApiCall(ref _callMutateRow);
            _callMutateRows = clientHelper.BuildApiCall<MutateRowsRequest, MutateRowsResponse>(grpcClient.MutateRows, effectiveSettings.MutateRowsSettings).WithGoogleRequestParam("table_name", request => request.TableName);
            Modify_ApiCall(ref _callMutateRows);
            Modify_MutateRowsApiCall(ref _callMutateRows);
            _callCheckAndMutateRow = clientHelper.BuildApiCall<CheckAndMutateRowRequest, CheckAndMutateRowResponse>(grpcClient.CheckAndMutateRowAsync, grpcClient.CheckAndMutateRow, effectiveSettings.CheckAndMutateRowSettings).WithGoogleRequestParam("table_name", request => request.TableName);
            Modify_ApiCall(ref _callCheckAndMutateRow);
            Modify_CheckAndMutateRowApiCall(ref _callCheckAndMutateRow);
            _callReadModifyWriteRow = clientHelper.BuildApiCall<ReadModifyWriteRowRequest, ReadModifyWriteRowResponse>(grpcClient.ReadModifyWriteRowAsync, grpcClient.ReadModifyWriteRow, effectiveSettings.ReadModifyWriteRowSettings).WithGoogleRequestParam("table_name", request => request.TableName);
            Modify_ApiCall(ref _callReadModifyWriteRow);
            Modify_ReadModifyWriteRowApiCall(ref _callReadModifyWriteRow);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiServerStreamingCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ReadRowsApiCall(ref gaxgrpc::ApiServerStreamingCall<ReadRowsRequest, ReadRowsResponse> call);

        partial void Modify_SampleRowKeysApiCall(ref gaxgrpc::ApiServerStreamingCall<SampleRowKeysRequest, SampleRowKeysResponse> call);

        partial void Modify_MutateRowApiCall(ref gaxgrpc::ApiCall<MutateRowRequest, MutateRowResponse> call);

        partial void Modify_MutateRowsApiCall(ref gaxgrpc::ApiServerStreamingCall<MutateRowsRequest, MutateRowsResponse> call);

        partial void Modify_CheckAndMutateRowApiCall(ref gaxgrpc::ApiCall<CheckAndMutateRowRequest, CheckAndMutateRowResponse> call);

        partial void Modify_ReadModifyWriteRowApiCall(ref gaxgrpc::ApiCall<ReadModifyWriteRowRequest, ReadModifyWriteRowResponse> call);

        partial void OnConstruction(Bigtable.BigtableClient grpcClient, BigtableSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Bigtable client</summary>
        public override Bigtable.BigtableClient GrpcClient { get; }

        partial void Modify_ReadRowsRequest(ref ReadRowsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SampleRowKeysRequest(ref SampleRowKeysRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MutateRowRequest(ref MutateRowRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MutateRowsRequest(ref MutateRowsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CheckAndMutateRowRequest(ref CheckAndMutateRowRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ReadModifyWriteRowRequest(ref ReadModifyWriteRowRequest request, ref gaxgrpc::CallSettings settings);

        internal sealed partial class ReadRowsStreamImpl : ReadRowsStream
        {
            /// <summary>Construct the server streaming method for <c>ReadRows</c>.</summary>
            /// <param name="call">The underlying gRPC server streaming call.</param>
            public ReadRowsStreamImpl(grpccore::AsyncServerStreamingCall<ReadRowsResponse> call) => GrpcCall = call;

            public override grpccore::AsyncServerStreamingCall<ReadRowsResponse> GrpcCall { get; }
        }

        /// <summary>
        /// Streams back the contents of all requested rows in key order, optionally
        /// applying the same Reader filter to each. Depending on their size,
        /// rows and cells may be broken up across multiple responses, but
        /// atomicity of each row will still be preserved. See the
        /// ReadRowsResponse documentation for details.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public override BigtableClient.ReadRowsStream ReadRows(ReadRowsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReadRowsRequest(ref request, ref callSettings);
            return new ReadRowsStreamImpl(_callReadRows.Call(request, callSettings));
        }

        internal sealed partial class SampleRowKeysStreamImpl : SampleRowKeysStream
        {
            /// <summary>Construct the server streaming method for <c>SampleRowKeys</c>.</summary>
            /// <param name="call">The underlying gRPC server streaming call.</param>
            public SampleRowKeysStreamImpl(grpccore::AsyncServerStreamingCall<SampleRowKeysResponse> call) => GrpcCall = call;

            public override grpccore::AsyncServerStreamingCall<SampleRowKeysResponse> GrpcCall { get; }
        }

        /// <summary>
        /// Returns a sample of row keys in the table. The returned row keys will
        /// delimit contiguous sections of the table of approximately equal size,
        /// which can be used to break up the data for distributed tasks like
        /// mapreduces.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public override BigtableClient.SampleRowKeysStream SampleRowKeys(SampleRowKeysRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SampleRowKeysRequest(ref request, ref callSettings);
            return new SampleRowKeysStreamImpl(_callSampleRowKeys.Call(request, callSettings));
        }

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by `mutation`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateRowResponse MutateRow(MutateRowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateRowRequest(ref request, ref callSettings);
            return _callMutateRow.Sync(request, callSettings);
        }

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by `mutation`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateRowResponse> MutateRowAsync(MutateRowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateRowRequest(ref request, ref callSettings);
            return _callMutateRow.Async(request, callSettings);
        }

        internal sealed partial class MutateRowsStreamImpl : MutateRowsStream
        {
            /// <summary>Construct the server streaming method for <c>MutateRows</c>.</summary>
            /// <param name="call">The underlying gRPC server streaming call.</param>
            public MutateRowsStreamImpl(grpccore::AsyncServerStreamingCall<MutateRowsResponse> call) => GrpcCall = call;

            public override grpccore::AsyncServerStreamingCall<MutateRowsResponse> GrpcCall { get; }
        }

        /// <summary>
        /// Mutates multiple rows in a batch. Each individual row is mutated
        /// atomically as in MutateRow, but the entire batch is not executed
        /// atomically.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public override BigtableClient.MutateRowsStream MutateRows(MutateRowsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateRowsRequest(ref request, ref callSettings);
            return new MutateRowsStreamImpl(_callMutateRows.Call(request, callSettings));
        }

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CheckAndMutateRowResponse CheckAndMutateRow(CheckAndMutateRowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CheckAndMutateRowRequest(ref request, ref callSettings);
            return _callCheckAndMutateRow.Sync(request, callSettings);
        }

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CheckAndMutateRowResponse> CheckAndMutateRowAsync(CheckAndMutateRowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CheckAndMutateRowRequest(ref request, ref callSettings);
            return _callCheckAndMutateRow.Async(request, callSettings);
        }

        /// <summary>
        /// Modifies a row atomically on the server. The method reads the latest
        /// existing timestamp and value from the specified columns and writes a new
        /// entry based on pre-defined read/modify/write rules. The new value for the
        /// timestamp is the greater of the existing timestamp or the current server
        /// time. The method returns the new contents of all modified cells.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ReadModifyWriteRowResponse ReadModifyWriteRow(ReadModifyWriteRowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReadModifyWriteRowRequest(ref request, ref callSettings);
            return _callReadModifyWriteRow.Sync(request, callSettings);
        }

        /// <summary>
        /// Modifies a row atomically on the server. The method reads the latest
        /// existing timestamp and value from the specified columns and writes a new
        /// entry based on pre-defined read/modify/write rules. The new value for the
        /// timestamp is the greater of the existing timestamp or the current server
        /// time. The method returns the new contents of all modified cells.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ReadModifyWriteRowResponse> ReadModifyWriteRowAsync(ReadModifyWriteRowRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReadModifyWriteRowRequest(ref request, ref callSettings);
            return _callReadModifyWriteRow.Async(request, callSettings);
        }
    }
}
