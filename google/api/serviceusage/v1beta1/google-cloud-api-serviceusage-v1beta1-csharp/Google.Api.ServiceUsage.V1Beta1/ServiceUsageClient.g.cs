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
using lro = Google.LongRunning;
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

namespace Google.Api.ServiceUsage.V1Beta1
{
    /// <summary>Settings for <see cref="ServiceUsageClient"/> instances.</summary>
    public sealed partial class ServiceUsageSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ServiceUsageSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ServiceUsageSettings"/>.</returns>
        public static ServiceUsageSettings GetDefault() => new ServiceUsageSettings();

        /// <summary>Constructs a new <see cref="ServiceUsageSettings"/> object with default settings.</summary>
        public ServiceUsageSettings()
        {
        }

        private ServiceUsageSettings(ServiceUsageSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            EnableServiceSettings = existing.EnableServiceSettings;
            EnableServiceOperationsSettings = existing.EnableServiceOperationsSettings.Clone();
            DisableServiceSettings = existing.DisableServiceSettings;
            DisableServiceOperationsSettings = existing.DisableServiceOperationsSettings.Clone();
            GetServiceSettings = existing.GetServiceSettings;
            ListServicesSettings = existing.ListServicesSettings;
            BatchEnableServicesSettings = existing.BatchEnableServicesSettings;
            BatchEnableServicesOperationsSettings = existing.BatchEnableServicesOperationsSettings.Clone();
            ListConsumerQuotaMetricsSettings = existing.ListConsumerQuotaMetricsSettings;
            GetConsumerQuotaMetricSettings = existing.GetConsumerQuotaMetricSettings;
            GetConsumerQuotaLimitSettings = existing.GetConsumerQuotaLimitSettings;
            CreateAdminOverrideSettings = existing.CreateAdminOverrideSettings;
            CreateAdminOverrideOperationsSettings = existing.CreateAdminOverrideOperationsSettings.Clone();
            UpdateAdminOverrideSettings = existing.UpdateAdminOverrideSettings;
            UpdateAdminOverrideOperationsSettings = existing.UpdateAdminOverrideOperationsSettings.Clone();
            DeleteAdminOverrideSettings = existing.DeleteAdminOverrideSettings;
            DeleteAdminOverrideOperationsSettings = existing.DeleteAdminOverrideOperationsSettings.Clone();
            ListAdminOverridesSettings = existing.ListAdminOverridesSettings;
            ImportAdminOverridesSettings = existing.ImportAdminOverridesSettings;
            ImportAdminOverridesOperationsSettings = existing.ImportAdminOverridesOperationsSettings.Clone();
            CreateConsumerOverrideSettings = existing.CreateConsumerOverrideSettings;
            CreateConsumerOverrideOperationsSettings = existing.CreateConsumerOverrideOperationsSettings.Clone();
            UpdateConsumerOverrideSettings = existing.UpdateConsumerOverrideSettings;
            UpdateConsumerOverrideOperationsSettings = existing.UpdateConsumerOverrideOperationsSettings.Clone();
            DeleteConsumerOverrideSettings = existing.DeleteConsumerOverrideSettings;
            DeleteConsumerOverrideOperationsSettings = existing.DeleteConsumerOverrideOperationsSettings.Clone();
            ListConsumerOverridesSettings = existing.ListConsumerOverridesSettings;
            ImportConsumerOverridesSettings = existing.ImportConsumerOverridesSettings;
            ImportConsumerOverridesOperationsSettings = existing.ImportConsumerOverridesOperationsSettings.Clone();
            GenerateServiceIdentitySettings = existing.GenerateServiceIdentitySettings;
            GenerateServiceIdentityOperationsSettings = existing.GenerateServiceIdentityOperationsSettings.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(ServiceUsageSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceUsageClient.EnableService</c> and <c>ServiceUsageClient.EnableServiceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings EnableServiceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ServiceUsageClient.EnableService</c> and
        /// <c>ServiceUsageClient.EnableServiceAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings EnableServiceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceUsageClient.DisableService</c> and <c>ServiceUsageClient.DisableServiceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DisableServiceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ServiceUsageClient.DisableService</c> and
        /// <c>ServiceUsageClient.DisableServiceAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings DisableServiceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceUsageClient.GetService</c> and <c>ServiceUsageClient.GetServiceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetServiceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceUsageClient.ListServices</c> and <c>ServiceUsageClient.ListServicesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListServicesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceUsageClient.BatchEnableServices</c> and <c>ServiceUsageClient.BatchEnableServicesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchEnableServicesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ServiceUsageClient.BatchEnableServices</c> and
        /// <c>ServiceUsageClient.BatchEnableServicesAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings BatchEnableServicesOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceUsageClient.ListConsumerQuotaMetrics</c> and <c>ServiceUsageClient.ListConsumerQuotaMetricsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListConsumerQuotaMetricsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceUsageClient.GetConsumerQuotaMetric</c> and <c>ServiceUsageClient.GetConsumerQuotaMetricAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetConsumerQuotaMetricSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceUsageClient.GetConsumerQuotaLimit</c> and <c>ServiceUsageClient.GetConsumerQuotaLimitAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetConsumerQuotaLimitSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceUsageClient.CreateAdminOverride</c> and <c>ServiceUsageClient.CreateAdminOverrideAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateAdminOverrideSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ServiceUsageClient.CreateAdminOverride</c> and
        /// <c>ServiceUsageClient.CreateAdminOverrideAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings CreateAdminOverrideOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceUsageClient.UpdateAdminOverride</c> and <c>ServiceUsageClient.UpdateAdminOverrideAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateAdminOverrideSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ServiceUsageClient.UpdateAdminOverride</c> and
        /// <c>ServiceUsageClient.UpdateAdminOverrideAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings UpdateAdminOverrideOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceUsageClient.DeleteAdminOverride</c> and <c>ServiceUsageClient.DeleteAdminOverrideAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteAdminOverrideSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ServiceUsageClient.DeleteAdminOverride</c> and
        /// <c>ServiceUsageClient.DeleteAdminOverrideAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings DeleteAdminOverrideOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceUsageClient.ListAdminOverrides</c> and <c>ServiceUsageClient.ListAdminOverridesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAdminOverridesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceUsageClient.ImportAdminOverrides</c> and <c>ServiceUsageClient.ImportAdminOverridesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ImportAdminOverridesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ServiceUsageClient.ImportAdminOverrides</c> and
        /// <c>ServiceUsageClient.ImportAdminOverridesAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings ImportAdminOverridesOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceUsageClient.CreateConsumerOverride</c> and <c>ServiceUsageClient.CreateConsumerOverrideAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateConsumerOverrideSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ServiceUsageClient.CreateConsumerOverride</c> and
        /// <c>ServiceUsageClient.CreateConsumerOverrideAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings CreateConsumerOverrideOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceUsageClient.UpdateConsumerOverride</c> and <c>ServiceUsageClient.UpdateConsumerOverrideAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateConsumerOverrideSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ServiceUsageClient.UpdateConsumerOverride</c> and
        /// <c>ServiceUsageClient.UpdateConsumerOverrideAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings UpdateConsumerOverrideOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceUsageClient.DeleteConsumerOverride</c> and <c>ServiceUsageClient.DeleteConsumerOverrideAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteConsumerOverrideSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ServiceUsageClient.DeleteConsumerOverride</c> and
        /// <c>ServiceUsageClient.DeleteConsumerOverrideAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings DeleteConsumerOverrideOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceUsageClient.ListConsumerOverrides</c> and <c>ServiceUsageClient.ListConsumerOverridesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListConsumerOverridesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceUsageClient.ImportConsumerOverrides</c> and <c>ServiceUsageClient.ImportConsumerOverridesAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ImportConsumerOverridesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ServiceUsageClient.ImportConsumerOverrides</c> and
        /// <c>ServiceUsageClient.ImportConsumerOverridesAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings ImportConsumerOverridesOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ServiceUsageClient.GenerateServiceIdentity</c> and <c>ServiceUsageClient.GenerateServiceIdentityAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GenerateServiceIdentitySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ServiceUsageClient.GenerateServiceIdentity</c> and
        /// <c>ServiceUsageClient.GenerateServiceIdentityAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings GenerateServiceIdentityOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ServiceUsageSettings"/> object.</returns>
        public ServiceUsageSettings Clone() => new ServiceUsageSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ServiceUsageClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class ServiceUsageClientBuilder : gaxgrpc::ClientBuilderBase<ServiceUsageClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ServiceUsageSettings Settings { get; set; }

        partial void InterceptBuild(ref ServiceUsageClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ServiceUsageClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ServiceUsageClient Build()
        {
            ServiceUsageClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ServiceUsageClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ServiceUsageClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ServiceUsageClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ServiceUsageClient.Create(callInvoker, Settings);
        }

        private async stt::Task<ServiceUsageClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ServiceUsageClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => ServiceUsageClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => ServiceUsageClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ServiceUsageClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>ServiceUsage client wrapper, for convenient use.</summary>
    /// <remarks>
    /// [Service Usage API](/service-usage/docs/overview)
    /// </remarks>
    public abstract partial class ServiceUsageClient
    {
        /// <summary>
        /// The default endpoint for the ServiceUsage service, which is a host of "serviceusage.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "serviceusage.googleapis.com:443";

        /// <summary>The default ServiceUsage scopes.</summary>
        /// <remarks>
        /// The default ServiceUsage scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="ServiceUsageClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ServiceUsageClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ServiceUsageClient"/>.</returns>
        public static stt::Task<ServiceUsageClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ServiceUsageClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ServiceUsageClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ServiceUsageClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ServiceUsageClient"/>.</returns>
        public static ServiceUsageClient Create() => new ServiceUsageClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ServiceUsageClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ServiceUsageSettings"/>.</param>
        /// <returns>The created <see cref="ServiceUsageClient"/>.</returns>
        internal static ServiceUsageClient Create(grpccore::CallInvoker callInvoker, ServiceUsageSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ServiceUsage.ServiceUsageClient grpcClient = new ServiceUsage.ServiceUsageClient(callInvoker);
            return new ServiceUsageClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC ServiceUsage client</summary>
        public virtual ServiceUsage.ServiceUsageClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Enables a service so that it can be used with a project.
        /// 
        /// Operation response type: `google.protobuf.Empty`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> EnableService(EnableServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Enables a service so that it can be used with a project.
        /// 
        /// Operation response type: `google.protobuf.Empty`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> EnableServiceAsync(EnableServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Enables a service so that it can be used with a project.
        /// 
        /// Operation response type: `google.protobuf.Empty`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> EnableServiceAsync(EnableServiceRequest request, st::CancellationToken cancellationToken) =>
            EnableServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>EnableService</c>.</summary>
        public virtual lro::OperationsClient EnableServiceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>EnableService</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceEnableService(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), EnableServiceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>EnableService</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceEnableServiceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), EnableServiceOperationsClient, callSettings);

        /// <summary>
        /// Disables a service so that it can no longer be used with a project.
        /// This prevents unintended usage that may cause unexpected billing
        /// charges or security leaks.
        /// 
        /// It is not valid to call the disable method on a service that is not
        /// currently enabled. Callers will receive a `FAILED_PRECONDITION` status if
        /// the target service is not currently enabled.
        /// 
        /// Operation response type: `google.protobuf.Empty`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DisableService(DisableServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Disables a service so that it can no longer be used with a project.
        /// This prevents unintended usage that may cause unexpected billing
        /// charges or security leaks.
        /// 
        /// It is not valid to call the disable method on a service that is not
        /// currently enabled. Callers will receive a `FAILED_PRECONDITION` status if
        /// the target service is not currently enabled.
        /// 
        /// Operation response type: `google.protobuf.Empty`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DisableServiceAsync(DisableServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Disables a service so that it can no longer be used with a project.
        /// This prevents unintended usage that may cause unexpected billing
        /// charges or security leaks.
        /// 
        /// It is not valid to call the disable method on a service that is not
        /// currently enabled. Callers will receive a `FAILED_PRECONDITION` status if
        /// the target service is not currently enabled.
        /// 
        /// Operation response type: `google.protobuf.Empty`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DisableServiceAsync(DisableServiceRequest request, st::CancellationToken cancellationToken) =>
            DisableServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DisableService</c>.</summary>
        public virtual lro::OperationsClient DisableServiceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DisableService</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDisableService(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DisableServiceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DisableService</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDisableServiceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DisableServiceOperationsClient, callSettings);

        /// <summary>
        /// Returns the service configuration and enabled state for a given service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Service GetService(GetServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the service configuration and enabled state for a given service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> GetServiceAsync(GetServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the service configuration and enabled state for a given service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> GetServiceAsync(GetServiceRequest request, st::CancellationToken cancellationToken) =>
            GetServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all services available to the specified project, and the current
        /// state of those services with respect to the project. The list includes
        /// all public services, all services for which the calling user has the
        /// `servicemanagement.services.bind` permission, and all services that have
        /// already been enabled on the project. The list can be filtered to
        /// only include services in a specific state, for example to only include
        /// services enabled on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Service"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServicesResponse, Service> ListServices(ListServicesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all services available to the specified project, and the current
        /// state of those services with respect to the project. The list includes
        /// all public services, all services for which the calling user has the
        /// `servicemanagement.services.bind` permission, and all services that have
        /// already been enabled on the project. The list can be filtered to
        /// only include services in a specific state, for example to only include
        /// services enabled on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Service"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServicesResponse, Service> ListServicesAsync(ListServicesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Enables multiple services on a project. The operation is atomic: if
        /// enabling any service fails, then the entire batch fails, and no state
        /// changes occur.
        /// 
        /// Operation response type: `google.protobuf.Empty`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> BatchEnableServices(BatchEnableServicesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Enables multiple services on a project. The operation is atomic: if
        /// enabling any service fails, then the entire batch fails, and no state
        /// changes occur.
        /// 
        /// Operation response type: `google.protobuf.Empty`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> BatchEnableServicesAsync(BatchEnableServicesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Enables multiple services on a project. The operation is atomic: if
        /// enabling any service fails, then the entire batch fails, and no state
        /// changes occur.
        /// 
        /// Operation response type: `google.protobuf.Empty`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> BatchEnableServicesAsync(BatchEnableServicesRequest request, st::CancellationToken cancellationToken) =>
            BatchEnableServicesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>BatchEnableServices</c>.</summary>
        public virtual lro::OperationsClient BatchEnableServicesOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>BatchEnableServices</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceBatchEnableServices(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchEnableServicesOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BatchEnableServices</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceBatchEnableServicesAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchEnableServicesOperationsClient, callSettings);

        /// <summary>
        /// Retrieves a summary of all quota information visible to the service
        /// consumer, organized by service metric. Each metric includes information
        /// about all of its defined limits. Each limit includes the limit
        /// configuration (quota unit, preciseness, default value), the current
        /// effective limit value, and all of the overrides applied to the limit.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ConsumerQuotaMetric"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConsumerQuotaMetricsResponse, ConsumerQuotaMetric> ListConsumerQuotaMetrics(ListConsumerQuotaMetricsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a summary of all quota information visible to the service
        /// consumer, organized by service metric. Each metric includes information
        /// about all of its defined limits. Each limit includes the limit
        /// configuration (quota unit, preciseness, default value), the current
        /// effective limit value, and all of the overrides applied to the limit.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ConsumerQuotaMetric"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConsumerQuotaMetricsResponse, ConsumerQuotaMetric> ListConsumerQuotaMetricsAsync(ListConsumerQuotaMetricsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a summary of quota information for a specific quota metric
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConsumerQuotaMetric GetConsumerQuotaMetric(GetConsumerQuotaMetricRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a summary of quota information for a specific quota metric
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConsumerQuotaMetric> GetConsumerQuotaMetricAsync(GetConsumerQuotaMetricRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a summary of quota information for a specific quota metric
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConsumerQuotaMetric> GetConsumerQuotaMetricAsync(GetConsumerQuotaMetricRequest request, st::CancellationToken cancellationToken) =>
            GetConsumerQuotaMetricAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a summary of quota information for a specific quota limit.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConsumerQuotaLimit GetConsumerQuotaLimit(GetConsumerQuotaLimitRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a summary of quota information for a specific quota limit.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConsumerQuotaLimit> GetConsumerQuotaLimitAsync(GetConsumerQuotaLimitRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a summary of quota information for a specific quota limit.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConsumerQuotaLimit> GetConsumerQuotaLimitAsync(GetConsumerQuotaLimitRequest request, st::CancellationToken cancellationToken) =>
            GetConsumerQuotaLimitAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an admin override.
        /// An admin override is applied by an administrator of a parent folder or
        /// parent organization of the consumer receiving the override. An admin
        /// override is intended to limit the amount of quota the consumer can use out
        /// of the total quota pool allocated to all children of the folder or
        /// organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<QuotaOverride, OperationMetadata> CreateAdminOverride(CreateAdminOverrideRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an admin override.
        /// An admin override is applied by an administrator of a parent folder or
        /// parent organization of the consumer receiving the override. An admin
        /// override is intended to limit the amount of quota the consumer can use out
        /// of the total quota pool allocated to all children of the folder or
        /// organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<QuotaOverride, OperationMetadata>> CreateAdminOverrideAsync(CreateAdminOverrideRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an admin override.
        /// An admin override is applied by an administrator of a parent folder or
        /// parent organization of the consumer receiving the override. An admin
        /// override is intended to limit the amount of quota the consumer can use out
        /// of the total quota pool allocated to all children of the folder or
        /// organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<QuotaOverride, OperationMetadata>> CreateAdminOverrideAsync(CreateAdminOverrideRequest request, st::CancellationToken cancellationToken) =>
            CreateAdminOverrideAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateAdminOverride</c>.</summary>
        public virtual lro::OperationsClient CreateAdminOverrideOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateAdminOverride</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<QuotaOverride, OperationMetadata> PollOnceCreateAdminOverride(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<QuotaOverride, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateAdminOverrideOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateAdminOverride</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<QuotaOverride, OperationMetadata>> PollOnceCreateAdminOverrideAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<QuotaOverride, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateAdminOverrideOperationsClient, callSettings);

        /// <summary>
        /// Updates an admin override.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<QuotaOverride, OperationMetadata> UpdateAdminOverride(UpdateAdminOverrideRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an admin override.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<QuotaOverride, OperationMetadata>> UpdateAdminOverrideAsync(UpdateAdminOverrideRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an admin override.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<QuotaOverride, OperationMetadata>> UpdateAdminOverrideAsync(UpdateAdminOverrideRequest request, st::CancellationToken cancellationToken) =>
            UpdateAdminOverrideAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateAdminOverride</c>.</summary>
        public virtual lro::OperationsClient UpdateAdminOverrideOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateAdminOverride</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<QuotaOverride, OperationMetadata> PollOnceUpdateAdminOverride(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<QuotaOverride, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateAdminOverrideOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateAdminOverride</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<QuotaOverride, OperationMetadata>> PollOnceUpdateAdminOverrideAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<QuotaOverride, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateAdminOverrideOperationsClient, callSettings);

        /// <summary>
        /// Deletes an admin override.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteAdminOverride(DeleteAdminOverrideRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an admin override.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAdminOverrideAsync(DeleteAdminOverrideRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an admin override.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAdminOverrideAsync(DeleteAdminOverrideRequest request, st::CancellationToken cancellationToken) =>
            DeleteAdminOverrideAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteAdminOverride</c>.</summary>
        public virtual lro::OperationsClient DeleteAdminOverrideOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteAdminOverride</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteAdminOverride(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteAdminOverrideOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteAdminOverride</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteAdminOverrideAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteAdminOverrideOperationsClient, callSettings);

        /// <summary>
        /// Lists all admin overrides on this limit.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="QuotaOverride"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAdminOverridesResponse, QuotaOverride> ListAdminOverrides(ListAdminOverridesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all admin overrides on this limit.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="QuotaOverride"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAdminOverridesResponse, QuotaOverride> ListAdminOverridesAsync(ListAdminOverridesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates or updates multiple admin overrides atomically, all on the
        /// same consumer, but on many different metrics or limits.
        /// The name field in the quota override message should not be set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportAdminOverridesResponse, ImportAdminOverridesMetadata> ImportAdminOverrides(ImportAdminOverridesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates or updates multiple admin overrides atomically, all on the
        /// same consumer, but on many different metrics or limits.
        /// The name field in the quota override message should not be set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportAdminOverridesResponse, ImportAdminOverridesMetadata>> ImportAdminOverridesAsync(ImportAdminOverridesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates or updates multiple admin overrides atomically, all on the
        /// same consumer, but on many different metrics or limits.
        /// The name field in the quota override message should not be set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportAdminOverridesResponse, ImportAdminOverridesMetadata>> ImportAdminOverridesAsync(ImportAdminOverridesRequest request, st::CancellationToken cancellationToken) =>
            ImportAdminOverridesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ImportAdminOverrides</c>.</summary>
        public virtual lro::OperationsClient ImportAdminOverridesOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ImportAdminOverrides</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ImportAdminOverridesResponse, ImportAdminOverridesMetadata> PollOnceImportAdminOverrides(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportAdminOverridesResponse, ImportAdminOverridesMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportAdminOverridesOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ImportAdminOverrides</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ImportAdminOverridesResponse, ImportAdminOverridesMetadata>> PollOnceImportAdminOverridesAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportAdminOverridesResponse, ImportAdminOverridesMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportAdminOverridesOperationsClient, callSettings);

        /// <summary>
        /// Creates a consumer override.
        /// A consumer override is applied to the consumer on its own authority to
        /// limit its own quota usage. Consumer overrides cannot be used to grant more
        /// quota than would be allowed by admin overrides, producer overrides, or the
        /// default limit of the service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<QuotaOverride, OperationMetadata> CreateConsumerOverride(CreateConsumerOverrideRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a consumer override.
        /// A consumer override is applied to the consumer on its own authority to
        /// limit its own quota usage. Consumer overrides cannot be used to grant more
        /// quota than would be allowed by admin overrides, producer overrides, or the
        /// default limit of the service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<QuotaOverride, OperationMetadata>> CreateConsumerOverrideAsync(CreateConsumerOverrideRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a consumer override.
        /// A consumer override is applied to the consumer on its own authority to
        /// limit its own quota usage. Consumer overrides cannot be used to grant more
        /// quota than would be allowed by admin overrides, producer overrides, or the
        /// default limit of the service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<QuotaOverride, OperationMetadata>> CreateConsumerOverrideAsync(CreateConsumerOverrideRequest request, st::CancellationToken cancellationToken) =>
            CreateConsumerOverrideAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateConsumerOverride</c>.</summary>
        public virtual lro::OperationsClient CreateConsumerOverrideOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateConsumerOverride</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<QuotaOverride, OperationMetadata> PollOnceCreateConsumerOverride(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<QuotaOverride, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateConsumerOverrideOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateConsumerOverride</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<QuotaOverride, OperationMetadata>> PollOnceCreateConsumerOverrideAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<QuotaOverride, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateConsumerOverrideOperationsClient, callSettings);

        /// <summary>
        /// Updates a consumer override.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<QuotaOverride, OperationMetadata> UpdateConsumerOverride(UpdateConsumerOverrideRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a consumer override.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<QuotaOverride, OperationMetadata>> UpdateConsumerOverrideAsync(UpdateConsumerOverrideRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a consumer override.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<QuotaOverride, OperationMetadata>> UpdateConsumerOverrideAsync(UpdateConsumerOverrideRequest request, st::CancellationToken cancellationToken) =>
            UpdateConsumerOverrideAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateConsumerOverride</c>.</summary>
        public virtual lro::OperationsClient UpdateConsumerOverrideOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateConsumerOverride</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<QuotaOverride, OperationMetadata> PollOnceUpdateConsumerOverride(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<QuotaOverride, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateConsumerOverrideOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateConsumerOverride</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<QuotaOverride, OperationMetadata>> PollOnceUpdateConsumerOverrideAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<QuotaOverride, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateConsumerOverrideOperationsClient, callSettings);

        /// <summary>
        /// Deletes a consumer override.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteConsumerOverride(DeleteConsumerOverrideRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a consumer override.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConsumerOverrideAsync(DeleteConsumerOverrideRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a consumer override.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConsumerOverrideAsync(DeleteConsumerOverrideRequest request, st::CancellationToken cancellationToken) =>
            DeleteConsumerOverrideAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteConsumerOverride</c>.</summary>
        public virtual lro::OperationsClient DeleteConsumerOverrideOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteConsumerOverride</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteConsumerOverride(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteConsumerOverrideOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteConsumerOverride</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteConsumerOverrideAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteConsumerOverrideOperationsClient, callSettings);

        /// <summary>
        /// Lists all consumer overrides on this limit.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="QuotaOverride"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConsumerOverridesResponse, QuotaOverride> ListConsumerOverrides(ListConsumerOverridesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all consumer overrides on this limit.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="QuotaOverride"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConsumerOverridesResponse, QuotaOverride> ListConsumerOverridesAsync(ListConsumerOverridesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates or updates multiple consumer overrides atomically, all on the
        /// same consumer, but on many different metrics or limits.
        /// The name field in the quota override message should not be set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportConsumerOverridesResponse, ImportConsumerOverridesMetadata> ImportConsumerOverrides(ImportConsumerOverridesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates or updates multiple consumer overrides atomically, all on the
        /// same consumer, but on many different metrics or limits.
        /// The name field in the quota override message should not be set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportConsumerOverridesResponse, ImportConsumerOverridesMetadata>> ImportConsumerOverridesAsync(ImportConsumerOverridesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates or updates multiple consumer overrides atomically, all on the
        /// same consumer, but on many different metrics or limits.
        /// The name field in the quota override message should not be set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportConsumerOverridesResponse, ImportConsumerOverridesMetadata>> ImportConsumerOverridesAsync(ImportConsumerOverridesRequest request, st::CancellationToken cancellationToken) =>
            ImportConsumerOverridesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ImportConsumerOverrides</c>.</summary>
        public virtual lro::OperationsClient ImportConsumerOverridesOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ImportConsumerOverrides</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ImportConsumerOverridesResponse, ImportConsumerOverridesMetadata> PollOnceImportConsumerOverrides(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportConsumerOverridesResponse, ImportConsumerOverridesMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportConsumerOverridesOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ImportConsumerOverrides</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ImportConsumerOverridesResponse, ImportConsumerOverridesMetadata>> PollOnceImportConsumerOverridesAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportConsumerOverridesResponse, ImportConsumerOverridesMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportConsumerOverridesOperationsClient, callSettings);

        /// <summary>
        /// Generates service identity for service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ServiceIdentity, wkt::Empty> GenerateServiceIdentity(GenerateServiceIdentityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates service identity for service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServiceIdentity, wkt::Empty>> GenerateServiceIdentityAsync(GenerateServiceIdentityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates service identity for service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ServiceIdentity, wkt::Empty>> GenerateServiceIdentityAsync(GenerateServiceIdentityRequest request, st::CancellationToken cancellationToken) =>
            GenerateServiceIdentityAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>GenerateServiceIdentity</c>.</summary>
        public virtual lro::OperationsClient GenerateServiceIdentityOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>GenerateServiceIdentity</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ServiceIdentity, wkt::Empty> PollOnceGenerateServiceIdentity(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ServiceIdentity, wkt::Empty>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), GenerateServiceIdentityOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>GenerateServiceIdentity</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ServiceIdentity, wkt::Empty>> PollOnceGenerateServiceIdentityAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ServiceIdentity, wkt::Empty>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), GenerateServiceIdentityOperationsClient, callSettings);
    }

    /// <summary>ServiceUsage client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// [Service Usage API](/service-usage/docs/overview)
    /// </remarks>
    public sealed partial class ServiceUsageClientImpl : ServiceUsageClient
    {
        private readonly gaxgrpc::ApiCall<EnableServiceRequest, lro::Operation> _callEnableService;

        private readonly gaxgrpc::ApiCall<DisableServiceRequest, lro::Operation> _callDisableService;

        private readonly gaxgrpc::ApiCall<GetServiceRequest, Service> _callGetService;

        private readonly gaxgrpc::ApiCall<ListServicesRequest, ListServicesResponse> _callListServices;

        private readonly gaxgrpc::ApiCall<BatchEnableServicesRequest, lro::Operation> _callBatchEnableServices;

        private readonly gaxgrpc::ApiCall<ListConsumerQuotaMetricsRequest, ListConsumerQuotaMetricsResponse> _callListConsumerQuotaMetrics;

        private readonly gaxgrpc::ApiCall<GetConsumerQuotaMetricRequest, ConsumerQuotaMetric> _callGetConsumerQuotaMetric;

        private readonly gaxgrpc::ApiCall<GetConsumerQuotaLimitRequest, ConsumerQuotaLimit> _callGetConsumerQuotaLimit;

        private readonly gaxgrpc::ApiCall<CreateAdminOverrideRequest, lro::Operation> _callCreateAdminOverride;

        private readonly gaxgrpc::ApiCall<UpdateAdminOverrideRequest, lro::Operation> _callUpdateAdminOverride;

        private readonly gaxgrpc::ApiCall<DeleteAdminOverrideRequest, lro::Operation> _callDeleteAdminOverride;

        private readonly gaxgrpc::ApiCall<ListAdminOverridesRequest, ListAdminOverridesResponse> _callListAdminOverrides;

        private readonly gaxgrpc::ApiCall<ImportAdminOverridesRequest, lro::Operation> _callImportAdminOverrides;

        private readonly gaxgrpc::ApiCall<CreateConsumerOverrideRequest, lro::Operation> _callCreateConsumerOverride;

        private readonly gaxgrpc::ApiCall<UpdateConsumerOverrideRequest, lro::Operation> _callUpdateConsumerOverride;

        private readonly gaxgrpc::ApiCall<DeleteConsumerOverrideRequest, lro::Operation> _callDeleteConsumerOverride;

        private readonly gaxgrpc::ApiCall<ListConsumerOverridesRequest, ListConsumerOverridesResponse> _callListConsumerOverrides;

        private readonly gaxgrpc::ApiCall<ImportConsumerOverridesRequest, lro::Operation> _callImportConsumerOverrides;

        private readonly gaxgrpc::ApiCall<GenerateServiceIdentityRequest, lro::Operation> _callGenerateServiceIdentity;

        /// <summary>
        /// Constructs a client wrapper for the ServiceUsage service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ServiceUsageSettings"/> used within this client.</param>
        public ServiceUsageClientImpl(ServiceUsage.ServiceUsageClient grpcClient, ServiceUsageSettings settings)
        {
            GrpcClient = grpcClient;
            ServiceUsageSettings effectiveSettings = settings ?? ServiceUsageSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            EnableServiceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.EnableServiceOperationsSettings);
            DisableServiceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DisableServiceOperationsSettings);
            BatchEnableServicesOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.BatchEnableServicesOperationsSettings);
            CreateAdminOverrideOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateAdminOverrideOperationsSettings);
            UpdateAdminOverrideOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateAdminOverrideOperationsSettings);
            DeleteAdminOverrideOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteAdminOverrideOperationsSettings);
            ImportAdminOverridesOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ImportAdminOverridesOperationsSettings);
            CreateConsumerOverrideOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateConsumerOverrideOperationsSettings);
            UpdateConsumerOverrideOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateConsumerOverrideOperationsSettings);
            DeleteConsumerOverrideOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteConsumerOverrideOperationsSettings);
            ImportConsumerOverridesOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ImportConsumerOverridesOperationsSettings);
            GenerateServiceIdentityOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.GenerateServiceIdentityOperationsSettings);
            _callEnableService = clientHelper.BuildApiCall<EnableServiceRequest, lro::Operation>(grpcClient.EnableServiceAsync, grpcClient.EnableService, effectiveSettings.EnableServiceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callEnableService);
            Modify_EnableServiceApiCall(ref _callEnableService);
            _callDisableService = clientHelper.BuildApiCall<DisableServiceRequest, lro::Operation>(grpcClient.DisableServiceAsync, grpcClient.DisableService, effectiveSettings.DisableServiceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDisableService);
            Modify_DisableServiceApiCall(ref _callDisableService);
            _callGetService = clientHelper.BuildApiCall<GetServiceRequest, Service>(grpcClient.GetServiceAsync, grpcClient.GetService, effectiveSettings.GetServiceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetService);
            Modify_GetServiceApiCall(ref _callGetService);
            _callListServices = clientHelper.BuildApiCall<ListServicesRequest, ListServicesResponse>(grpcClient.ListServicesAsync, grpcClient.ListServices, effectiveSettings.ListServicesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListServices);
            Modify_ListServicesApiCall(ref _callListServices);
            _callBatchEnableServices = clientHelper.BuildApiCall<BatchEnableServicesRequest, lro::Operation>(grpcClient.BatchEnableServicesAsync, grpcClient.BatchEnableServices, effectiveSettings.BatchEnableServicesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchEnableServices);
            Modify_BatchEnableServicesApiCall(ref _callBatchEnableServices);
            _callListConsumerQuotaMetrics = clientHelper.BuildApiCall<ListConsumerQuotaMetricsRequest, ListConsumerQuotaMetricsResponse>(grpcClient.ListConsumerQuotaMetricsAsync, grpcClient.ListConsumerQuotaMetrics, effectiveSettings.ListConsumerQuotaMetricsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListConsumerQuotaMetrics);
            Modify_ListConsumerQuotaMetricsApiCall(ref _callListConsumerQuotaMetrics);
            _callGetConsumerQuotaMetric = clientHelper.BuildApiCall<GetConsumerQuotaMetricRequest, ConsumerQuotaMetric>(grpcClient.GetConsumerQuotaMetricAsync, grpcClient.GetConsumerQuotaMetric, effectiveSettings.GetConsumerQuotaMetricSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetConsumerQuotaMetric);
            Modify_GetConsumerQuotaMetricApiCall(ref _callGetConsumerQuotaMetric);
            _callGetConsumerQuotaLimit = clientHelper.BuildApiCall<GetConsumerQuotaLimitRequest, ConsumerQuotaLimit>(grpcClient.GetConsumerQuotaLimitAsync, grpcClient.GetConsumerQuotaLimit, effectiveSettings.GetConsumerQuotaLimitSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetConsumerQuotaLimit);
            Modify_GetConsumerQuotaLimitApiCall(ref _callGetConsumerQuotaLimit);
            _callCreateAdminOverride = clientHelper.BuildApiCall<CreateAdminOverrideRequest, lro::Operation>(grpcClient.CreateAdminOverrideAsync, grpcClient.CreateAdminOverride, effectiveSettings.CreateAdminOverrideSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateAdminOverride);
            Modify_CreateAdminOverrideApiCall(ref _callCreateAdminOverride);
            _callUpdateAdminOverride = clientHelper.BuildApiCall<UpdateAdminOverrideRequest, lro::Operation>(grpcClient.UpdateAdminOverrideAsync, grpcClient.UpdateAdminOverride, effectiveSettings.UpdateAdminOverrideSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUpdateAdminOverride);
            Modify_UpdateAdminOverrideApiCall(ref _callUpdateAdminOverride);
            _callDeleteAdminOverride = clientHelper.BuildApiCall<DeleteAdminOverrideRequest, lro::Operation>(grpcClient.DeleteAdminOverrideAsync, grpcClient.DeleteAdminOverride, effectiveSettings.DeleteAdminOverrideSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteAdminOverride);
            Modify_DeleteAdminOverrideApiCall(ref _callDeleteAdminOverride);
            _callListAdminOverrides = clientHelper.BuildApiCall<ListAdminOverridesRequest, ListAdminOverridesResponse>(grpcClient.ListAdminOverridesAsync, grpcClient.ListAdminOverrides, effectiveSettings.ListAdminOverridesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAdminOverrides);
            Modify_ListAdminOverridesApiCall(ref _callListAdminOverrides);
            _callImportAdminOverrides = clientHelper.BuildApiCall<ImportAdminOverridesRequest, lro::Operation>(grpcClient.ImportAdminOverridesAsync, grpcClient.ImportAdminOverrides, effectiveSettings.ImportAdminOverridesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callImportAdminOverrides);
            Modify_ImportAdminOverridesApiCall(ref _callImportAdminOverrides);
            _callCreateConsumerOverride = clientHelper.BuildApiCall<CreateConsumerOverrideRequest, lro::Operation>(grpcClient.CreateConsumerOverrideAsync, grpcClient.CreateConsumerOverride, effectiveSettings.CreateConsumerOverrideSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateConsumerOverride);
            Modify_CreateConsumerOverrideApiCall(ref _callCreateConsumerOverride);
            _callUpdateConsumerOverride = clientHelper.BuildApiCall<UpdateConsumerOverrideRequest, lro::Operation>(grpcClient.UpdateConsumerOverrideAsync, grpcClient.UpdateConsumerOverride, effectiveSettings.UpdateConsumerOverrideSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUpdateConsumerOverride);
            Modify_UpdateConsumerOverrideApiCall(ref _callUpdateConsumerOverride);
            _callDeleteConsumerOverride = clientHelper.BuildApiCall<DeleteConsumerOverrideRequest, lro::Operation>(grpcClient.DeleteConsumerOverrideAsync, grpcClient.DeleteConsumerOverride, effectiveSettings.DeleteConsumerOverrideSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteConsumerOverride);
            Modify_DeleteConsumerOverrideApiCall(ref _callDeleteConsumerOverride);
            _callListConsumerOverrides = clientHelper.BuildApiCall<ListConsumerOverridesRequest, ListConsumerOverridesResponse>(grpcClient.ListConsumerOverridesAsync, grpcClient.ListConsumerOverrides, effectiveSettings.ListConsumerOverridesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListConsumerOverrides);
            Modify_ListConsumerOverridesApiCall(ref _callListConsumerOverrides);
            _callImportConsumerOverrides = clientHelper.BuildApiCall<ImportConsumerOverridesRequest, lro::Operation>(grpcClient.ImportConsumerOverridesAsync, grpcClient.ImportConsumerOverrides, effectiveSettings.ImportConsumerOverridesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callImportConsumerOverrides);
            Modify_ImportConsumerOverridesApiCall(ref _callImportConsumerOverrides);
            _callGenerateServiceIdentity = clientHelper.BuildApiCall<GenerateServiceIdentityRequest, lro::Operation>(grpcClient.GenerateServiceIdentityAsync, grpcClient.GenerateServiceIdentity, effectiveSettings.GenerateServiceIdentitySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callGenerateServiceIdentity);
            Modify_GenerateServiceIdentityApiCall(ref _callGenerateServiceIdentity);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_EnableServiceApiCall(ref gaxgrpc::ApiCall<EnableServiceRequest, lro::Operation> call);

        partial void Modify_DisableServiceApiCall(ref gaxgrpc::ApiCall<DisableServiceRequest, lro::Operation> call);

        partial void Modify_GetServiceApiCall(ref gaxgrpc::ApiCall<GetServiceRequest, Service> call);

        partial void Modify_ListServicesApiCall(ref gaxgrpc::ApiCall<ListServicesRequest, ListServicesResponse> call);

        partial void Modify_BatchEnableServicesApiCall(ref gaxgrpc::ApiCall<BatchEnableServicesRequest, lro::Operation> call);

        partial void Modify_ListConsumerQuotaMetricsApiCall(ref gaxgrpc::ApiCall<ListConsumerQuotaMetricsRequest, ListConsumerQuotaMetricsResponse> call);

        partial void Modify_GetConsumerQuotaMetricApiCall(ref gaxgrpc::ApiCall<GetConsumerQuotaMetricRequest, ConsumerQuotaMetric> call);

        partial void Modify_GetConsumerQuotaLimitApiCall(ref gaxgrpc::ApiCall<GetConsumerQuotaLimitRequest, ConsumerQuotaLimit> call);

        partial void Modify_CreateAdminOverrideApiCall(ref gaxgrpc::ApiCall<CreateAdminOverrideRequest, lro::Operation> call);

        partial void Modify_UpdateAdminOverrideApiCall(ref gaxgrpc::ApiCall<UpdateAdminOverrideRequest, lro::Operation> call);

        partial void Modify_DeleteAdminOverrideApiCall(ref gaxgrpc::ApiCall<DeleteAdminOverrideRequest, lro::Operation> call);

        partial void Modify_ListAdminOverridesApiCall(ref gaxgrpc::ApiCall<ListAdminOverridesRequest, ListAdminOverridesResponse> call);

        partial void Modify_ImportAdminOverridesApiCall(ref gaxgrpc::ApiCall<ImportAdminOverridesRequest, lro::Operation> call);

        partial void Modify_CreateConsumerOverrideApiCall(ref gaxgrpc::ApiCall<CreateConsumerOverrideRequest, lro::Operation> call);

        partial void Modify_UpdateConsumerOverrideApiCall(ref gaxgrpc::ApiCall<UpdateConsumerOverrideRequest, lro::Operation> call);

        partial void Modify_DeleteConsumerOverrideApiCall(ref gaxgrpc::ApiCall<DeleteConsumerOverrideRequest, lro::Operation> call);

        partial void Modify_ListConsumerOverridesApiCall(ref gaxgrpc::ApiCall<ListConsumerOverridesRequest, ListConsumerOverridesResponse> call);

        partial void Modify_ImportConsumerOverridesApiCall(ref gaxgrpc::ApiCall<ImportConsumerOverridesRequest, lro::Operation> call);

        partial void Modify_GenerateServiceIdentityApiCall(ref gaxgrpc::ApiCall<GenerateServiceIdentityRequest, lro::Operation> call);

        partial void OnConstruction(ServiceUsage.ServiceUsageClient grpcClient, ServiceUsageSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ServiceUsage client</summary>
        public override ServiceUsage.ServiceUsageClient GrpcClient { get; }

        partial void Modify_EnableServiceRequest(ref EnableServiceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DisableServiceRequest(ref DisableServiceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetServiceRequest(ref GetServiceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListServicesRequest(ref ListServicesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchEnableServicesRequest(ref BatchEnableServicesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListConsumerQuotaMetricsRequest(ref ListConsumerQuotaMetricsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetConsumerQuotaMetricRequest(ref GetConsumerQuotaMetricRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetConsumerQuotaLimitRequest(ref GetConsumerQuotaLimitRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateAdminOverrideRequest(ref CreateAdminOverrideRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateAdminOverrideRequest(ref UpdateAdminOverrideRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteAdminOverrideRequest(ref DeleteAdminOverrideRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAdminOverridesRequest(ref ListAdminOverridesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ImportAdminOverridesRequest(ref ImportAdminOverridesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateConsumerOverrideRequest(ref CreateConsumerOverrideRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateConsumerOverrideRequest(ref UpdateConsumerOverrideRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteConsumerOverrideRequest(ref DeleteConsumerOverrideRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListConsumerOverridesRequest(ref ListConsumerOverridesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ImportConsumerOverridesRequest(ref ImportConsumerOverridesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateServiceIdentityRequest(ref GenerateServiceIdentityRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>EnableService</c>.</summary>
        public override lro::OperationsClient EnableServiceOperationsClient { get; }

        /// <summary>
        /// Enables a service so that it can be used with a project.
        /// 
        /// Operation response type: `google.protobuf.Empty`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> EnableService(EnableServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EnableServiceRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callEnableService.Sync(request, callSettings), EnableServiceOperationsClient);
        }

        /// <summary>
        /// Enables a service so that it can be used with a project.
        /// 
        /// Operation response type: `google.protobuf.Empty`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> EnableServiceAsync(EnableServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EnableServiceRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callEnableService.Async(request, callSettings).ConfigureAwait(false), EnableServiceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DisableService</c>.</summary>
        public override lro::OperationsClient DisableServiceOperationsClient { get; }

        /// <summary>
        /// Disables a service so that it can no longer be used with a project.
        /// This prevents unintended usage that may cause unexpected billing
        /// charges or security leaks.
        /// 
        /// It is not valid to call the disable method on a service that is not
        /// currently enabled. Callers will receive a `FAILED_PRECONDITION` status if
        /// the target service is not currently enabled.
        /// 
        /// Operation response type: `google.protobuf.Empty`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DisableService(DisableServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DisableServiceRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDisableService.Sync(request, callSettings), DisableServiceOperationsClient);
        }

        /// <summary>
        /// Disables a service so that it can no longer be used with a project.
        /// This prevents unintended usage that may cause unexpected billing
        /// charges or security leaks.
        /// 
        /// It is not valid to call the disable method on a service that is not
        /// currently enabled. Callers will receive a `FAILED_PRECONDITION` status if
        /// the target service is not currently enabled.
        /// 
        /// Operation response type: `google.protobuf.Empty`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DisableServiceAsync(DisableServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DisableServiceRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDisableService.Async(request, callSettings).ConfigureAwait(false), DisableServiceOperationsClient);
        }

        /// <summary>
        /// Returns the service configuration and enabled state for a given service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Service GetService(GetServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetServiceRequest(ref request, ref callSettings);
            return _callGetService.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the service configuration and enabled state for a given service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Service> GetServiceAsync(GetServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetServiceRequest(ref request, ref callSettings);
            return _callGetService.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all services available to the specified project, and the current
        /// state of those services with respect to the project. The list includes
        /// all public services, all services for which the calling user has the
        /// `servicemanagement.services.bind` permission, and all services that have
        /// already been enabled on the project. The list can be filtered to
        /// only include services in a specific state, for example to only include
        /// services enabled on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Service"/> resources.</returns>
        public override gax::PagedEnumerable<ListServicesResponse, Service> ListServices(ListServicesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListServicesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListServicesRequest, ListServicesResponse, Service>(_callListServices, request, callSettings);
        }

        /// <summary>
        /// Lists all services available to the specified project, and the current
        /// state of those services with respect to the project. The list includes
        /// all public services, all services for which the calling user has the
        /// `servicemanagement.services.bind` permission, and all services that have
        /// already been enabled on the project. The list can be filtered to
        /// only include services in a specific state, for example to only include
        /// services enabled on the project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Service"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListServicesResponse, Service> ListServicesAsync(ListServicesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListServicesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListServicesRequest, ListServicesResponse, Service>(_callListServices, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>BatchEnableServices</c>.</summary>
        public override lro::OperationsClient BatchEnableServicesOperationsClient { get; }

        /// <summary>
        /// Enables multiple services on a project. The operation is atomic: if
        /// enabling any service fails, then the entire batch fails, and no state
        /// changes occur.
        /// 
        /// Operation response type: `google.protobuf.Empty`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> BatchEnableServices(BatchEnableServicesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchEnableServicesRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callBatchEnableServices.Sync(request, callSettings), BatchEnableServicesOperationsClient);
        }

        /// <summary>
        /// Enables multiple services on a project. The operation is atomic: if
        /// enabling any service fails, then the entire batch fails, and no state
        /// changes occur.
        /// 
        /// Operation response type: `google.protobuf.Empty`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> BatchEnableServicesAsync(BatchEnableServicesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchEnableServicesRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callBatchEnableServices.Async(request, callSettings).ConfigureAwait(false), BatchEnableServicesOperationsClient);
        }

        /// <summary>
        /// Retrieves a summary of all quota information visible to the service
        /// consumer, organized by service metric. Each metric includes information
        /// about all of its defined limits. Each limit includes the limit
        /// configuration (quota unit, preciseness, default value), the current
        /// effective limit value, and all of the overrides applied to the limit.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ConsumerQuotaMetric"/> resources.</returns>
        public override gax::PagedEnumerable<ListConsumerQuotaMetricsResponse, ConsumerQuotaMetric> ListConsumerQuotaMetrics(ListConsumerQuotaMetricsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListConsumerQuotaMetricsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListConsumerQuotaMetricsRequest, ListConsumerQuotaMetricsResponse, ConsumerQuotaMetric>(_callListConsumerQuotaMetrics, request, callSettings);
        }

        /// <summary>
        /// Retrieves a summary of all quota information visible to the service
        /// consumer, organized by service metric. Each metric includes information
        /// about all of its defined limits. Each limit includes the limit
        /// configuration (quota unit, preciseness, default value), the current
        /// effective limit value, and all of the overrides applied to the limit.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ConsumerQuotaMetric"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListConsumerQuotaMetricsResponse, ConsumerQuotaMetric> ListConsumerQuotaMetricsAsync(ListConsumerQuotaMetricsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListConsumerQuotaMetricsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListConsumerQuotaMetricsRequest, ListConsumerQuotaMetricsResponse, ConsumerQuotaMetric>(_callListConsumerQuotaMetrics, request, callSettings);
        }

        /// <summary>
        /// Retrieves a summary of quota information for a specific quota metric
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ConsumerQuotaMetric GetConsumerQuotaMetric(GetConsumerQuotaMetricRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConsumerQuotaMetricRequest(ref request, ref callSettings);
            return _callGetConsumerQuotaMetric.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a summary of quota information for a specific quota metric
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ConsumerQuotaMetric> GetConsumerQuotaMetricAsync(GetConsumerQuotaMetricRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConsumerQuotaMetricRequest(ref request, ref callSettings);
            return _callGetConsumerQuotaMetric.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves a summary of quota information for a specific quota limit.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ConsumerQuotaLimit GetConsumerQuotaLimit(GetConsumerQuotaLimitRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConsumerQuotaLimitRequest(ref request, ref callSettings);
            return _callGetConsumerQuotaLimit.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a summary of quota information for a specific quota limit.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ConsumerQuotaLimit> GetConsumerQuotaLimitAsync(GetConsumerQuotaLimitRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConsumerQuotaLimitRequest(ref request, ref callSettings);
            return _callGetConsumerQuotaLimit.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateAdminOverride</c>.</summary>
        public override lro::OperationsClient CreateAdminOverrideOperationsClient { get; }

        /// <summary>
        /// Creates an admin override.
        /// An admin override is applied by an administrator of a parent folder or
        /// parent organization of the consumer receiving the override. An admin
        /// override is intended to limit the amount of quota the consumer can use out
        /// of the total quota pool allocated to all children of the folder or
        /// organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<QuotaOverride, OperationMetadata> CreateAdminOverride(CreateAdminOverrideRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAdminOverrideRequest(ref request, ref callSettings);
            return new lro::Operation<QuotaOverride, OperationMetadata>(_callCreateAdminOverride.Sync(request, callSettings), CreateAdminOverrideOperationsClient);
        }

        /// <summary>
        /// Creates an admin override.
        /// An admin override is applied by an administrator of a parent folder or
        /// parent organization of the consumer receiving the override. An admin
        /// override is intended to limit the amount of quota the consumer can use out
        /// of the total quota pool allocated to all children of the folder or
        /// organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<QuotaOverride, OperationMetadata>> CreateAdminOverrideAsync(CreateAdminOverrideRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAdminOverrideRequest(ref request, ref callSettings);
            return new lro::Operation<QuotaOverride, OperationMetadata>(await _callCreateAdminOverride.Async(request, callSettings).ConfigureAwait(false), CreateAdminOverrideOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateAdminOverride</c>.</summary>
        public override lro::OperationsClient UpdateAdminOverrideOperationsClient { get; }

        /// <summary>
        /// Updates an admin override.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<QuotaOverride, OperationMetadata> UpdateAdminOverride(UpdateAdminOverrideRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAdminOverrideRequest(ref request, ref callSettings);
            return new lro::Operation<QuotaOverride, OperationMetadata>(_callUpdateAdminOverride.Sync(request, callSettings), UpdateAdminOverrideOperationsClient);
        }

        /// <summary>
        /// Updates an admin override.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<QuotaOverride, OperationMetadata>> UpdateAdminOverrideAsync(UpdateAdminOverrideRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAdminOverrideRequest(ref request, ref callSettings);
            return new lro::Operation<QuotaOverride, OperationMetadata>(await _callUpdateAdminOverride.Async(request, callSettings).ConfigureAwait(false), UpdateAdminOverrideOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteAdminOverride</c>.</summary>
        public override lro::OperationsClient DeleteAdminOverrideOperationsClient { get; }

        /// <summary>
        /// Deletes an admin override.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteAdminOverride(DeleteAdminOverrideRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAdminOverrideRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteAdminOverride.Sync(request, callSettings), DeleteAdminOverrideOperationsClient);
        }

        /// <summary>
        /// Deletes an admin override.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAdminOverrideAsync(DeleteAdminOverrideRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAdminOverrideRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteAdminOverride.Async(request, callSettings).ConfigureAwait(false), DeleteAdminOverrideOperationsClient);
        }

        /// <summary>
        /// Lists all admin overrides on this limit.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="QuotaOverride"/> resources.</returns>
        public override gax::PagedEnumerable<ListAdminOverridesResponse, QuotaOverride> ListAdminOverrides(ListAdminOverridesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAdminOverridesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAdminOverridesRequest, ListAdminOverridesResponse, QuotaOverride>(_callListAdminOverrides, request, callSettings);
        }

        /// <summary>
        /// Lists all admin overrides on this limit.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="QuotaOverride"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAdminOverridesResponse, QuotaOverride> ListAdminOverridesAsync(ListAdminOverridesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAdminOverridesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAdminOverridesRequest, ListAdminOverridesResponse, QuotaOverride>(_callListAdminOverrides, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>ImportAdminOverrides</c>.</summary>
        public override lro::OperationsClient ImportAdminOverridesOperationsClient { get; }

        /// <summary>
        /// Creates or updates multiple admin overrides atomically, all on the
        /// same consumer, but on many different metrics or limits.
        /// The name field in the quota override message should not be set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ImportAdminOverridesResponse, ImportAdminOverridesMetadata> ImportAdminOverrides(ImportAdminOverridesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportAdminOverridesRequest(ref request, ref callSettings);
            return new lro::Operation<ImportAdminOverridesResponse, ImportAdminOverridesMetadata>(_callImportAdminOverrides.Sync(request, callSettings), ImportAdminOverridesOperationsClient);
        }

        /// <summary>
        /// Creates or updates multiple admin overrides atomically, all on the
        /// same consumer, but on many different metrics or limits.
        /// The name field in the quota override message should not be set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ImportAdminOverridesResponse, ImportAdminOverridesMetadata>> ImportAdminOverridesAsync(ImportAdminOverridesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportAdminOverridesRequest(ref request, ref callSettings);
            return new lro::Operation<ImportAdminOverridesResponse, ImportAdminOverridesMetadata>(await _callImportAdminOverrides.Async(request, callSettings).ConfigureAwait(false), ImportAdminOverridesOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CreateConsumerOverride</c>.</summary>
        public override lro::OperationsClient CreateConsumerOverrideOperationsClient { get; }

        /// <summary>
        /// Creates a consumer override.
        /// A consumer override is applied to the consumer on its own authority to
        /// limit its own quota usage. Consumer overrides cannot be used to grant more
        /// quota than would be allowed by admin overrides, producer overrides, or the
        /// default limit of the service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<QuotaOverride, OperationMetadata> CreateConsumerOverride(CreateConsumerOverrideRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateConsumerOverrideRequest(ref request, ref callSettings);
            return new lro::Operation<QuotaOverride, OperationMetadata>(_callCreateConsumerOverride.Sync(request, callSettings), CreateConsumerOverrideOperationsClient);
        }

        /// <summary>
        /// Creates a consumer override.
        /// A consumer override is applied to the consumer on its own authority to
        /// limit its own quota usage. Consumer overrides cannot be used to grant more
        /// quota than would be allowed by admin overrides, producer overrides, or the
        /// default limit of the service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<QuotaOverride, OperationMetadata>> CreateConsumerOverrideAsync(CreateConsumerOverrideRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateConsumerOverrideRequest(ref request, ref callSettings);
            return new lro::Operation<QuotaOverride, OperationMetadata>(await _callCreateConsumerOverride.Async(request, callSettings).ConfigureAwait(false), CreateConsumerOverrideOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateConsumerOverride</c>.</summary>
        public override lro::OperationsClient UpdateConsumerOverrideOperationsClient { get; }

        /// <summary>
        /// Updates a consumer override.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<QuotaOverride, OperationMetadata> UpdateConsumerOverride(UpdateConsumerOverrideRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateConsumerOverrideRequest(ref request, ref callSettings);
            return new lro::Operation<QuotaOverride, OperationMetadata>(_callUpdateConsumerOverride.Sync(request, callSettings), UpdateConsumerOverrideOperationsClient);
        }

        /// <summary>
        /// Updates a consumer override.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<QuotaOverride, OperationMetadata>> UpdateConsumerOverrideAsync(UpdateConsumerOverrideRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateConsumerOverrideRequest(ref request, ref callSettings);
            return new lro::Operation<QuotaOverride, OperationMetadata>(await _callUpdateConsumerOverride.Async(request, callSettings).ConfigureAwait(false), UpdateConsumerOverrideOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteConsumerOverride</c>.</summary>
        public override lro::OperationsClient DeleteConsumerOverrideOperationsClient { get; }

        /// <summary>
        /// Deletes a consumer override.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteConsumerOverride(DeleteConsumerOverrideRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteConsumerOverrideRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteConsumerOverride.Sync(request, callSettings), DeleteConsumerOverrideOperationsClient);
        }

        /// <summary>
        /// Deletes a consumer override.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConsumerOverrideAsync(DeleteConsumerOverrideRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteConsumerOverrideRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteConsumerOverride.Async(request, callSettings).ConfigureAwait(false), DeleteConsumerOverrideOperationsClient);
        }

        /// <summary>
        /// Lists all consumer overrides on this limit.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="QuotaOverride"/> resources.</returns>
        public override gax::PagedEnumerable<ListConsumerOverridesResponse, QuotaOverride> ListConsumerOverrides(ListConsumerOverridesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListConsumerOverridesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListConsumerOverridesRequest, ListConsumerOverridesResponse, QuotaOverride>(_callListConsumerOverrides, request, callSettings);
        }

        /// <summary>
        /// Lists all consumer overrides on this limit.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="QuotaOverride"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListConsumerOverridesResponse, QuotaOverride> ListConsumerOverridesAsync(ListConsumerOverridesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListConsumerOverridesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListConsumerOverridesRequest, ListConsumerOverridesResponse, QuotaOverride>(_callListConsumerOverrides, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>ImportConsumerOverrides</c>.</summary>
        public override lro::OperationsClient ImportConsumerOverridesOperationsClient { get; }

        /// <summary>
        /// Creates or updates multiple consumer overrides atomically, all on the
        /// same consumer, but on many different metrics or limits.
        /// The name field in the quota override message should not be set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ImportConsumerOverridesResponse, ImportConsumerOverridesMetadata> ImportConsumerOverrides(ImportConsumerOverridesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportConsumerOverridesRequest(ref request, ref callSettings);
            return new lro::Operation<ImportConsumerOverridesResponse, ImportConsumerOverridesMetadata>(_callImportConsumerOverrides.Sync(request, callSettings), ImportConsumerOverridesOperationsClient);
        }

        /// <summary>
        /// Creates or updates multiple consumer overrides atomically, all on the
        /// same consumer, but on many different metrics or limits.
        /// The name field in the quota override message should not be set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ImportConsumerOverridesResponse, ImportConsumerOverridesMetadata>> ImportConsumerOverridesAsync(ImportConsumerOverridesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportConsumerOverridesRequest(ref request, ref callSettings);
            return new lro::Operation<ImportConsumerOverridesResponse, ImportConsumerOverridesMetadata>(await _callImportConsumerOverrides.Async(request, callSettings).ConfigureAwait(false), ImportConsumerOverridesOperationsClient);
        }

        /// <summary>The long-running operations client for <c>GenerateServiceIdentity</c>.</summary>
        public override lro::OperationsClient GenerateServiceIdentityOperationsClient { get; }

        /// <summary>
        /// Generates service identity for service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ServiceIdentity, wkt::Empty> GenerateServiceIdentity(GenerateServiceIdentityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateServiceIdentityRequest(ref request, ref callSettings);
            return new lro::Operation<ServiceIdentity, wkt::Empty>(_callGenerateServiceIdentity.Sync(request, callSettings), GenerateServiceIdentityOperationsClient);
        }

        /// <summary>
        /// Generates service identity for service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ServiceIdentity, wkt::Empty>> GenerateServiceIdentityAsync(GenerateServiceIdentityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateServiceIdentityRequest(ref request, ref callSettings);
            return new lro::Operation<ServiceIdentity, wkt::Empty>(await _callGenerateServiceIdentity.Async(request, callSettings).ConfigureAwait(false), GenerateServiceIdentityOperationsClient);
        }
    }

    public partial class ListServicesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListConsumerQuotaMetricsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAdminOverridesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListConsumerOverridesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListServicesResponse : gaxgrpc::IPageResponse<Service>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Service> GetEnumerator() => Services.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListConsumerQuotaMetricsResponse : gaxgrpc::IPageResponse<ConsumerQuotaMetric>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ConsumerQuotaMetric> GetEnumerator() => Metrics.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListAdminOverridesResponse : gaxgrpc::IPageResponse<QuotaOverride>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<QuotaOverride> GetEnumerator() => Overrides.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListConsumerOverridesResponse : gaxgrpc::IPageResponse<QuotaOverride>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<QuotaOverride> GetEnumerator() => Overrides.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class ServiceUsage
    {
        public partial class ServiceUsageClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClient() =>
                new lro::Operations.OperationsClient(CallInvoker);
        }
    }
}
