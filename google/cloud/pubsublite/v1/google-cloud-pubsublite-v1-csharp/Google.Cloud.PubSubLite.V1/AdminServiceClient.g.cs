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

namespace Google.Cloud.PubSubLite.V1
{
    /// <summary>Settings for <see cref="AdminServiceClient"/> instances.</summary>
    public sealed partial class AdminServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AdminServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AdminServiceSettings"/>.</returns>
        public static AdminServiceSettings GetDefault() => new AdminServiceSettings();

        /// <summary>Constructs a new <see cref="AdminServiceSettings"/> object with default settings.</summary>
        public AdminServiceSettings()
        {
        }

        private AdminServiceSettings(AdminServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateTopicSettings = existing.CreateTopicSettings;
            GetTopicSettings = existing.GetTopicSettings;
            GetTopicPartitionsSettings = existing.GetTopicPartitionsSettings;
            ListTopicsSettings = existing.ListTopicsSettings;
            UpdateTopicSettings = existing.UpdateTopicSettings;
            DeleteTopicSettings = existing.DeleteTopicSettings;
            ListTopicSubscriptionsSettings = existing.ListTopicSubscriptionsSettings;
            CreateSubscriptionSettings = existing.CreateSubscriptionSettings;
            GetSubscriptionSettings = existing.GetSubscriptionSettings;
            ListSubscriptionsSettings = existing.ListSubscriptionsSettings;
            UpdateSubscriptionSettings = existing.UpdateSubscriptionSettings;
            DeleteSubscriptionSettings = existing.DeleteSubscriptionSettings;
            SeekSubscriptionSettings = existing.SeekSubscriptionSettings;
            SeekSubscriptionOperationsSettings = existing.SeekSubscriptionOperationsSettings.Clone();
            CreateReservationSettings = existing.CreateReservationSettings;
            GetReservationSettings = existing.GetReservationSettings;
            ListReservationsSettings = existing.ListReservationsSettings;
            UpdateReservationSettings = existing.UpdateReservationSettings;
            DeleteReservationSettings = existing.DeleteReservationSettings;
            ListReservationTopicsSettings = existing.ListReservationTopicsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AdminServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdminServiceClient.CreateTopic</c> and <c>AdminServiceClient.CreateTopicAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateTopicSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable, grpccore::StatusCode.Aborted, grpccore::StatusCode.Internal, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AdminServiceClient.GetTopic</c>
        ///  and <c>AdminServiceClient.GetTopicAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetTopicSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable, grpccore::StatusCode.Aborted, grpccore::StatusCode.Internal, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdminServiceClient.GetTopicPartitions</c> and <c>AdminServiceClient.GetTopicPartitionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetTopicPartitionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable, grpccore::StatusCode.Aborted, grpccore::StatusCode.Internal, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdminServiceClient.ListTopics</c> and <c>AdminServiceClient.ListTopicsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListTopicsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable, grpccore::StatusCode.Aborted, grpccore::StatusCode.Internal, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdminServiceClient.UpdateTopic</c> and <c>AdminServiceClient.UpdateTopicAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateTopicSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable, grpccore::StatusCode.Aborted, grpccore::StatusCode.Internal, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdminServiceClient.DeleteTopic</c> and <c>AdminServiceClient.DeleteTopicAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteTopicSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable, grpccore::StatusCode.Aborted, grpccore::StatusCode.Internal, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdminServiceClient.ListTopicSubscriptions</c> and <c>AdminServiceClient.ListTopicSubscriptionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListTopicSubscriptionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable, grpccore::StatusCode.Aborted, grpccore::StatusCode.Internal, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdminServiceClient.CreateSubscription</c> and <c>AdminServiceClient.CreateSubscriptionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateSubscriptionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable, grpccore::StatusCode.Aborted, grpccore::StatusCode.Internal, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdminServiceClient.GetSubscription</c> and <c>AdminServiceClient.GetSubscriptionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSubscriptionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable, grpccore::StatusCode.Aborted, grpccore::StatusCode.Internal, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdminServiceClient.ListSubscriptions</c> and <c>AdminServiceClient.ListSubscriptionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSubscriptionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable, grpccore::StatusCode.Aborted, grpccore::StatusCode.Internal, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdminServiceClient.UpdateSubscription</c> and <c>AdminServiceClient.UpdateSubscriptionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSubscriptionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable, grpccore::StatusCode.Aborted, grpccore::StatusCode.Internal, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdminServiceClient.DeleteSubscription</c> and <c>AdminServiceClient.DeleteSubscriptionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSubscriptionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable, grpccore::StatusCode.Aborted, grpccore::StatusCode.Internal, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdminServiceClient.SeekSubscription</c> and <c>AdminServiceClient.SeekSubscriptionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SeekSubscriptionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable, grpccore::StatusCode.Aborted, grpccore::StatusCode.Internal, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AdminServiceClient.SeekSubscription</c> and
        /// <c>AdminServiceClient.SeekSubscriptionAsync</c>.
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
        public lro::OperationsSettings SeekSubscriptionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdminServiceClient.CreateReservation</c> and <c>AdminServiceClient.CreateReservationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateReservationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable, grpccore::StatusCode.Aborted, grpccore::StatusCode.Internal, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdminServiceClient.GetReservation</c> and <c>AdminServiceClient.GetReservationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetReservationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable, grpccore::StatusCode.Aborted, grpccore::StatusCode.Internal, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdminServiceClient.ListReservations</c> and <c>AdminServiceClient.ListReservationsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListReservationsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable, grpccore::StatusCode.Aborted, grpccore::StatusCode.Internal, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdminServiceClient.UpdateReservation</c> and <c>AdminServiceClient.UpdateReservationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateReservationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable, grpccore::StatusCode.Aborted, grpccore::StatusCode.Internal, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdminServiceClient.DeleteReservation</c> and <c>AdminServiceClient.DeleteReservationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteReservationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable, grpccore::StatusCode.Aborted, grpccore::StatusCode.Internal, grpccore::StatusCode.Unknown)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdminServiceClient.ListReservationTopics</c> and <c>AdminServiceClient.ListReservationTopicsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListReservationTopicsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable, grpccore::StatusCode.Aborted, grpccore::StatusCode.Internal, grpccore::StatusCode.Unknown)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AdminServiceSettings"/> object.</returns>
        public AdminServiceSettings Clone() => new AdminServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AdminServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class AdminServiceClientBuilder : gaxgrpc::ClientBuilderBase<AdminServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AdminServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref AdminServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AdminServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AdminServiceClient Build()
        {
            AdminServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AdminServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AdminServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AdminServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AdminServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<AdminServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AdminServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => AdminServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => AdminServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AdminServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>AdminService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The service that a client application uses to manage topics and
    /// subscriptions, such creating, listing, and deleting topics and subscriptions.
    /// </remarks>
    public abstract partial class AdminServiceClient
    {
        /// <summary>
        /// The default endpoint for the AdminService service, which is a host of "pubsublite.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "pubsublite.googleapis.com:443";

        /// <summary>The default AdminService scopes.</summary>
        /// <remarks>
        /// The default AdminService scopes are:
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
        /// Asynchronously creates a <see cref="AdminServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AdminServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AdminServiceClient"/>.</returns>
        public static stt::Task<AdminServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AdminServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AdminServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AdminServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AdminServiceClient"/>.</returns>
        public static AdminServiceClient Create() => new AdminServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AdminServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AdminServiceSettings"/>.</param>
        /// <returns>The created <see cref="AdminServiceClient"/>.</returns>
        internal static AdminServiceClient Create(grpccore::CallInvoker callInvoker, AdminServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AdminService.AdminServiceClient grpcClient = new AdminService.AdminServiceClient(callInvoker);
            return new AdminServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC AdminService client</summary>
        public virtual AdminService.AdminServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new topic.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Topic CreateTopic(CreateTopicRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new topic.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Topic> CreateTopicAsync(CreateTopicRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new topic.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Topic> CreateTopicAsync(CreateTopicRequest request, st::CancellationToken cancellationToken) =>
            CreateTopicAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new topic.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location in which to create the topic.
        /// Structured like `projects/{project_number}/locations/{location}`.
        /// </param>
        /// <param name="topic">
        /// Required. Configuration of the topic to create. Its `name` field is ignored.
        /// </param>
        /// <param name="topicId">
        /// Required. The ID to use for the topic, which will become the final component of
        /// the topic's name.
        /// 
        /// This value is structured like: `my-topic-name`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Topic CreateTopic(string parent, Topic topic, string topicId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTopic(new CreateTopicRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Topic = gax::GaxPreconditions.CheckNotNull(topic, nameof(topic)),
                TopicId = gax::GaxPreconditions.CheckNotNullOrEmpty(topicId, nameof(topicId)),
            }, callSettings);

        /// <summary>
        /// Creates a new topic.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location in which to create the topic.
        /// Structured like `projects/{project_number}/locations/{location}`.
        /// </param>
        /// <param name="topic">
        /// Required. Configuration of the topic to create. Its `name` field is ignored.
        /// </param>
        /// <param name="topicId">
        /// Required. The ID to use for the topic, which will become the final component of
        /// the topic's name.
        /// 
        /// This value is structured like: `my-topic-name`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Topic> CreateTopicAsync(string parent, Topic topic, string topicId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTopicAsync(new CreateTopicRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Topic = gax::GaxPreconditions.CheckNotNull(topic, nameof(topic)),
                TopicId = gax::GaxPreconditions.CheckNotNullOrEmpty(topicId, nameof(topicId)),
            }, callSettings);

        /// <summary>
        /// Creates a new topic.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location in which to create the topic.
        /// Structured like `projects/{project_number}/locations/{location}`.
        /// </param>
        /// <param name="topic">
        /// Required. Configuration of the topic to create. Its `name` field is ignored.
        /// </param>
        /// <param name="topicId">
        /// Required. The ID to use for the topic, which will become the final component of
        /// the topic's name.
        /// 
        /// This value is structured like: `my-topic-name`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Topic> CreateTopicAsync(string parent, Topic topic, string topicId, st::CancellationToken cancellationToken) =>
            CreateTopicAsync(parent, topic, topicId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new topic.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location in which to create the topic.
        /// Structured like `projects/{project_number}/locations/{location}`.
        /// </param>
        /// <param name="topic">
        /// Required. Configuration of the topic to create. Its `name` field is ignored.
        /// </param>
        /// <param name="topicId">
        /// Required. The ID to use for the topic, which will become the final component of
        /// the topic's name.
        /// 
        /// This value is structured like: `my-topic-name`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Topic CreateTopic(gagr::LocationName parent, Topic topic, string topicId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTopic(new CreateTopicRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Topic = gax::GaxPreconditions.CheckNotNull(topic, nameof(topic)),
                TopicId = gax::GaxPreconditions.CheckNotNullOrEmpty(topicId, nameof(topicId)),
            }, callSettings);

        /// <summary>
        /// Creates a new topic.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location in which to create the topic.
        /// Structured like `projects/{project_number}/locations/{location}`.
        /// </param>
        /// <param name="topic">
        /// Required. Configuration of the topic to create. Its `name` field is ignored.
        /// </param>
        /// <param name="topicId">
        /// Required. The ID to use for the topic, which will become the final component of
        /// the topic's name.
        /// 
        /// This value is structured like: `my-topic-name`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Topic> CreateTopicAsync(gagr::LocationName parent, Topic topic, string topicId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTopicAsync(new CreateTopicRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Topic = gax::GaxPreconditions.CheckNotNull(topic, nameof(topic)),
                TopicId = gax::GaxPreconditions.CheckNotNullOrEmpty(topicId, nameof(topicId)),
            }, callSettings);

        /// <summary>
        /// Creates a new topic.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location in which to create the topic.
        /// Structured like `projects/{project_number}/locations/{location}`.
        /// </param>
        /// <param name="topic">
        /// Required. Configuration of the topic to create. Its `name` field is ignored.
        /// </param>
        /// <param name="topicId">
        /// Required. The ID to use for the topic, which will become the final component of
        /// the topic's name.
        /// 
        /// This value is structured like: `my-topic-name`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Topic> CreateTopicAsync(gagr::LocationName parent, Topic topic, string topicId, st::CancellationToken cancellationToken) =>
            CreateTopicAsync(parent, topic, topicId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the topic configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Topic GetTopic(GetTopicRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the topic configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Topic> GetTopicAsync(GetTopicRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the topic configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Topic> GetTopicAsync(GetTopicRequest request, st::CancellationToken cancellationToken) =>
            GetTopicAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the topic configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the topic whose configuration to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Topic GetTopic(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTopic(new GetTopicRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the topic configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the topic whose configuration to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Topic> GetTopicAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTopicAsync(new GetTopicRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the topic configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the topic whose configuration to return.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Topic> GetTopicAsync(string name, st::CancellationToken cancellationToken) =>
            GetTopicAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the topic configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the topic whose configuration to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Topic GetTopic(TopicName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTopic(new GetTopicRequest
            {
                TopicName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the topic configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the topic whose configuration to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Topic> GetTopicAsync(TopicName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTopicAsync(new GetTopicRequest
            {
                TopicName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the topic configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the topic whose configuration to return.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Topic> GetTopicAsync(TopicName name, st::CancellationToken cancellationToken) =>
            GetTopicAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the partition information for the requested topic.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TopicPartitions GetTopicPartitions(GetTopicPartitionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the partition information for the requested topic.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TopicPartitions> GetTopicPartitionsAsync(GetTopicPartitionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the partition information for the requested topic.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TopicPartitions> GetTopicPartitionsAsync(GetTopicPartitionsRequest request, st::CancellationToken cancellationToken) =>
            GetTopicPartitionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the partition information for the requested topic.
        /// </summary>
        /// <param name="name">
        /// Required. The topic whose partition information to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TopicPartitions GetTopicPartitions(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTopicPartitions(new GetTopicPartitionsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the partition information for the requested topic.
        /// </summary>
        /// <param name="name">
        /// Required. The topic whose partition information to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TopicPartitions> GetTopicPartitionsAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTopicPartitionsAsync(new GetTopicPartitionsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the partition information for the requested topic.
        /// </summary>
        /// <param name="name">
        /// Required. The topic whose partition information to return.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TopicPartitions> GetTopicPartitionsAsync(string name, st::CancellationToken cancellationToken) =>
            GetTopicPartitionsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the partition information for the requested topic.
        /// </summary>
        /// <param name="name">
        /// Required. The topic whose partition information to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TopicPartitions GetTopicPartitions(TopicName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTopicPartitions(new GetTopicPartitionsRequest
            {
                TopicName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the partition information for the requested topic.
        /// </summary>
        /// <param name="name">
        /// Required. The topic whose partition information to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TopicPartitions> GetTopicPartitionsAsync(TopicName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTopicPartitionsAsync(new GetTopicPartitionsRequest
            {
                TopicName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the partition information for the requested topic.
        /// </summary>
        /// <param name="name">
        /// Required. The topic whose partition information to return.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TopicPartitions> GetTopicPartitionsAsync(TopicName name, st::CancellationToken cancellationToken) =>
            GetTopicPartitionsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the list of topics for the given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Topic"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTopicsResponse, Topic> ListTopics(ListTopicsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of topics for the given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Topic"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTopicsResponse, Topic> ListTopicsAsync(ListTopicsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of topics for the given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent whose topics are to be listed.
        /// Structured like `projects/{project_number}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="Topic"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTopicsResponse, Topic> ListTopics(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListTopics(new ListTopicsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns the list of topics for the given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent whose topics are to be listed.
        /// Structured like `projects/{project_number}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Topic"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTopicsResponse, Topic> ListTopicsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListTopicsAsync(new ListTopicsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns the list of topics for the given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent whose topics are to be listed.
        /// Structured like `projects/{project_number}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="Topic"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTopicsResponse, Topic> ListTopics(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListTopics(new ListTopicsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns the list of topics for the given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent whose topics are to be listed.
        /// Structured like `projects/{project_number}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Topic"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTopicsResponse, Topic> ListTopicsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListTopicsAsync(new ListTopicsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Updates properties of the specified topic.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Topic UpdateTopic(UpdateTopicRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates properties of the specified topic.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Topic> UpdateTopicAsync(UpdateTopicRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates properties of the specified topic.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Topic> UpdateTopicAsync(UpdateTopicRequest request, st::CancellationToken cancellationToken) =>
            UpdateTopicAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates properties of the specified topic.
        /// </summary>
        /// <param name="topic">
        /// Required. The topic to update. Its `name` field must be populated.
        /// </param>
        /// <param name="updateMask">
        /// Required. A mask specifying the topic fields to change.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Topic UpdateTopic(Topic topic, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTopic(new UpdateTopicRequest
            {
                Topic = gax::GaxPreconditions.CheckNotNull(topic, nameof(topic)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates properties of the specified topic.
        /// </summary>
        /// <param name="topic">
        /// Required. The topic to update. Its `name` field must be populated.
        /// </param>
        /// <param name="updateMask">
        /// Required. A mask specifying the topic fields to change.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Topic> UpdateTopicAsync(Topic topic, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTopicAsync(new UpdateTopicRequest
            {
                Topic = gax::GaxPreconditions.CheckNotNull(topic, nameof(topic)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates properties of the specified topic.
        /// </summary>
        /// <param name="topic">
        /// Required. The topic to update. Its `name` field must be populated.
        /// </param>
        /// <param name="updateMask">
        /// Required. A mask specifying the topic fields to change.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Topic> UpdateTopicAsync(Topic topic, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateTopicAsync(topic, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified topic.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTopic(DeleteTopicRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified topic.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTopicAsync(DeleteTopicRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified topic.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTopicAsync(DeleteTopicRequest request, st::CancellationToken cancellationToken) =>
            DeleteTopicAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified topic.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the topic to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTopic(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTopic(new DeleteTopicRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified topic.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the topic to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTopicAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTopicAsync(new DeleteTopicRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified topic.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the topic to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTopicAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteTopicAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified topic.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the topic to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTopic(TopicName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTopic(new DeleteTopicRequest
            {
                TopicName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified topic.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the topic to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTopicAsync(TopicName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTopicAsync(new DeleteTopicRequest
            {
                TopicName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified topic.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the topic to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTopicAsync(TopicName name, st::CancellationToken cancellationToken) =>
            DeleteTopicAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the subscriptions attached to the specified topic.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTopicSubscriptionsResponse, string> ListTopicSubscriptions(ListTopicSubscriptionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the subscriptions attached to the specified topic.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTopicSubscriptionsResponse, string> ListTopicSubscriptionsAsync(ListTopicSubscriptionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the subscriptions attached to the specified topic.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the topic whose subscriptions to list.
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
        /// <returns>A pageable sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTopicSubscriptionsResponse, string> ListTopicSubscriptions(string name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListTopicSubscriptions(new ListTopicSubscriptionsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists the subscriptions attached to the specified topic.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the topic whose subscriptions to list.
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
        /// <returns>A pageable asynchronous sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTopicSubscriptionsResponse, string> ListTopicSubscriptionsAsync(string name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListTopicSubscriptionsAsync(new ListTopicSubscriptionsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists the subscriptions attached to the specified topic.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the topic whose subscriptions to list.
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
        /// <returns>A pageable sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTopicSubscriptionsResponse, string> ListTopicSubscriptions(TopicName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListTopicSubscriptions(new ListTopicSubscriptionsRequest
            {
                TopicName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists the subscriptions attached to the specified topic.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the topic whose subscriptions to list.
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
        /// <returns>A pageable asynchronous sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTopicSubscriptionsResponse, string> ListTopicSubscriptionsAsync(TopicName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListTopicSubscriptionsAsync(new ListTopicSubscriptionsRequest
            {
                TopicName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Creates a new subscription.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Subscription CreateSubscription(CreateSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new subscription.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Subscription> CreateSubscriptionAsync(CreateSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new subscription.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Subscription> CreateSubscriptionAsync(CreateSubscriptionRequest request, st::CancellationToken cancellationToken) =>
            CreateSubscriptionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new subscription.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location in which to create the subscription.
        /// Structured like `projects/{project_number}/locations/{location}`.
        /// </param>
        /// <param name="subscription">
        /// Required. Configuration of the subscription to create. Its `name` field is ignored.
        /// </param>
        /// <param name="subscriptionId">
        /// Required. The ID to use for the subscription, which will become the final component
        /// of the subscription's name.
        /// 
        /// This value is structured like: `my-sub-name`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Subscription CreateSubscription(string parent, Subscription subscription, string subscriptionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSubscription(new CreateSubscriptionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Subscription = gax::GaxPreconditions.CheckNotNull(subscription, nameof(subscription)),
                SubscriptionId = gax::GaxPreconditions.CheckNotNullOrEmpty(subscriptionId, nameof(subscriptionId)),
            }, callSettings);

        /// <summary>
        /// Creates a new subscription.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location in which to create the subscription.
        /// Structured like `projects/{project_number}/locations/{location}`.
        /// </param>
        /// <param name="subscription">
        /// Required. Configuration of the subscription to create. Its `name` field is ignored.
        /// </param>
        /// <param name="subscriptionId">
        /// Required. The ID to use for the subscription, which will become the final component
        /// of the subscription's name.
        /// 
        /// This value is structured like: `my-sub-name`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Subscription> CreateSubscriptionAsync(string parent, Subscription subscription, string subscriptionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSubscriptionAsync(new CreateSubscriptionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Subscription = gax::GaxPreconditions.CheckNotNull(subscription, nameof(subscription)),
                SubscriptionId = gax::GaxPreconditions.CheckNotNullOrEmpty(subscriptionId, nameof(subscriptionId)),
            }, callSettings);

        /// <summary>
        /// Creates a new subscription.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location in which to create the subscription.
        /// Structured like `projects/{project_number}/locations/{location}`.
        /// </param>
        /// <param name="subscription">
        /// Required. Configuration of the subscription to create. Its `name` field is ignored.
        /// </param>
        /// <param name="subscriptionId">
        /// Required. The ID to use for the subscription, which will become the final component
        /// of the subscription's name.
        /// 
        /// This value is structured like: `my-sub-name`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Subscription> CreateSubscriptionAsync(string parent, Subscription subscription, string subscriptionId, st::CancellationToken cancellationToken) =>
            CreateSubscriptionAsync(parent, subscription, subscriptionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new subscription.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location in which to create the subscription.
        /// Structured like `projects/{project_number}/locations/{location}`.
        /// </param>
        /// <param name="subscription">
        /// Required. Configuration of the subscription to create. Its `name` field is ignored.
        /// </param>
        /// <param name="subscriptionId">
        /// Required. The ID to use for the subscription, which will become the final component
        /// of the subscription's name.
        /// 
        /// This value is structured like: `my-sub-name`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Subscription CreateSubscription(gagr::LocationName parent, Subscription subscription, string subscriptionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSubscription(new CreateSubscriptionRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Subscription = gax::GaxPreconditions.CheckNotNull(subscription, nameof(subscription)),
                SubscriptionId = gax::GaxPreconditions.CheckNotNullOrEmpty(subscriptionId, nameof(subscriptionId)),
            }, callSettings);

        /// <summary>
        /// Creates a new subscription.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location in which to create the subscription.
        /// Structured like `projects/{project_number}/locations/{location}`.
        /// </param>
        /// <param name="subscription">
        /// Required. Configuration of the subscription to create. Its `name` field is ignored.
        /// </param>
        /// <param name="subscriptionId">
        /// Required. The ID to use for the subscription, which will become the final component
        /// of the subscription's name.
        /// 
        /// This value is structured like: `my-sub-name`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Subscription> CreateSubscriptionAsync(gagr::LocationName parent, Subscription subscription, string subscriptionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSubscriptionAsync(new CreateSubscriptionRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Subscription = gax::GaxPreconditions.CheckNotNull(subscription, nameof(subscription)),
                SubscriptionId = gax::GaxPreconditions.CheckNotNullOrEmpty(subscriptionId, nameof(subscriptionId)),
            }, callSettings);

        /// <summary>
        /// Creates a new subscription.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location in which to create the subscription.
        /// Structured like `projects/{project_number}/locations/{location}`.
        /// </param>
        /// <param name="subscription">
        /// Required. Configuration of the subscription to create. Its `name` field is ignored.
        /// </param>
        /// <param name="subscriptionId">
        /// Required. The ID to use for the subscription, which will become the final component
        /// of the subscription's name.
        /// 
        /// This value is structured like: `my-sub-name`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Subscription> CreateSubscriptionAsync(gagr::LocationName parent, Subscription subscription, string subscriptionId, st::CancellationToken cancellationToken) =>
            CreateSubscriptionAsync(parent, subscription, subscriptionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the subscription configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Subscription GetSubscription(GetSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the subscription configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Subscription> GetSubscriptionAsync(GetSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the subscription configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Subscription> GetSubscriptionAsync(GetSubscriptionRequest request, st::CancellationToken cancellationToken) =>
            GetSubscriptionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the subscription configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the subscription whose configuration to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Subscription GetSubscription(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSubscription(new GetSubscriptionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the subscription configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the subscription whose configuration to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Subscription> GetSubscriptionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSubscriptionAsync(new GetSubscriptionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the subscription configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the subscription whose configuration to return.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Subscription> GetSubscriptionAsync(string name, st::CancellationToken cancellationToken) =>
            GetSubscriptionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the subscription configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the subscription whose configuration to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Subscription GetSubscription(SubscriptionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSubscription(new GetSubscriptionRequest
            {
                SubscriptionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the subscription configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the subscription whose configuration to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Subscription> GetSubscriptionAsync(SubscriptionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSubscriptionAsync(new GetSubscriptionRequest
            {
                SubscriptionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the subscription configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the subscription whose configuration to return.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Subscription> GetSubscriptionAsync(SubscriptionName name, st::CancellationToken cancellationToken) =>
            GetSubscriptionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the list of subscriptions for the given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Subscription"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSubscriptionsResponse, Subscription> ListSubscriptions(ListSubscriptionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of subscriptions for the given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Subscription"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSubscriptionsResponse, Subscription> ListSubscriptionsAsync(ListSubscriptionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of subscriptions for the given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent whose subscriptions are to be listed.
        /// Structured like `projects/{project_number}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="Subscription"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSubscriptionsResponse, Subscription> ListSubscriptions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListSubscriptions(new ListSubscriptionsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns the list of subscriptions for the given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent whose subscriptions are to be listed.
        /// Structured like `projects/{project_number}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Subscription"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSubscriptionsResponse, Subscription> ListSubscriptionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListSubscriptionsAsync(new ListSubscriptionsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns the list of subscriptions for the given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent whose subscriptions are to be listed.
        /// Structured like `projects/{project_number}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="Subscription"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSubscriptionsResponse, Subscription> ListSubscriptions(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListSubscriptions(new ListSubscriptionsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns the list of subscriptions for the given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent whose subscriptions are to be listed.
        /// Structured like `projects/{project_number}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Subscription"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSubscriptionsResponse, Subscription> ListSubscriptionsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListSubscriptionsAsync(new ListSubscriptionsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Updates properties of the specified subscription.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Subscription UpdateSubscription(UpdateSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates properties of the specified subscription.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Subscription> UpdateSubscriptionAsync(UpdateSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates properties of the specified subscription.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Subscription> UpdateSubscriptionAsync(UpdateSubscriptionRequest request, st::CancellationToken cancellationToken) =>
            UpdateSubscriptionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates properties of the specified subscription.
        /// </summary>
        /// <param name="subscription">
        /// Required. The subscription to update. Its `name` field must be populated.
        /// Topic field must not be populated.
        /// </param>
        /// <param name="updateMask">
        /// Required. A mask specifying the subscription fields to change.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Subscription UpdateSubscription(Subscription subscription, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSubscription(new UpdateSubscriptionRequest
            {
                Subscription = gax::GaxPreconditions.CheckNotNull(subscription, nameof(subscription)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates properties of the specified subscription.
        /// </summary>
        /// <param name="subscription">
        /// Required. The subscription to update. Its `name` field must be populated.
        /// Topic field must not be populated.
        /// </param>
        /// <param name="updateMask">
        /// Required. A mask specifying the subscription fields to change.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Subscription> UpdateSubscriptionAsync(Subscription subscription, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSubscriptionAsync(new UpdateSubscriptionRequest
            {
                Subscription = gax::GaxPreconditions.CheckNotNull(subscription, nameof(subscription)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates properties of the specified subscription.
        /// </summary>
        /// <param name="subscription">
        /// Required. The subscription to update. Its `name` field must be populated.
        /// Topic field must not be populated.
        /// </param>
        /// <param name="updateMask">
        /// Required. A mask specifying the subscription fields to change.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Subscription> UpdateSubscriptionAsync(Subscription subscription, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateSubscriptionAsync(subscription, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified subscription.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSubscription(DeleteSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified subscription.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSubscriptionAsync(DeleteSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified subscription.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSubscriptionAsync(DeleteSubscriptionRequest request, st::CancellationToken cancellationToken) =>
            DeleteSubscriptionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified subscription.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the subscription to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSubscription(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSubscription(new DeleteSubscriptionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified subscription.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the subscription to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSubscriptionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSubscriptionAsync(new DeleteSubscriptionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified subscription.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the subscription to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSubscriptionAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteSubscriptionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified subscription.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the subscription to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSubscription(SubscriptionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSubscription(new DeleteSubscriptionRequest
            {
                SubscriptionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified subscription.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the subscription to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSubscriptionAsync(SubscriptionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSubscriptionAsync(new DeleteSubscriptionRequest
            {
                SubscriptionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified subscription.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the subscription to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSubscriptionAsync(SubscriptionName name, st::CancellationToken cancellationToken) =>
            DeleteSubscriptionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Performs an out-of-band seek for a subscription to a specified target,
        /// which may be timestamps or named positions within the message backlog.
        /// Seek translates these targets to cursors for each partition and
        /// orchestrates subscribers to start consuming messages from these seek
        /// cursors.
        /// 
        /// If an operation is returned, the seek has been registered and subscribers
        /// will eventually receive messages from the seek cursors (i.e. eventual
        /// consistency), as long as they are using a minimum supported client library
        /// version and not a system that tracks cursors independently of Pub/Sub Lite
        /// (e.g. Apache Beam, Dataflow, Spark). The seek operation will fail for
        /// unsupported clients.
        /// 
        /// If clients would like to know when subscribers react to the seek (or not),
        /// they can poll the operation. The seek operation will succeed and complete
        /// once subscribers are ready to receive messages from the seek cursors for
        /// all partitions of the topic. This means that the seek operation will not
        /// complete until all subscribers come online.
        /// 
        /// If the previous seek operation has not yet completed, it will be aborted
        /// and the new invocation of seek will supersede it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<SeekSubscriptionResponse, OperationMetadata> SeekSubscription(SeekSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Performs an out-of-band seek for a subscription to a specified target,
        /// which may be timestamps or named positions within the message backlog.
        /// Seek translates these targets to cursors for each partition and
        /// orchestrates subscribers to start consuming messages from these seek
        /// cursors.
        /// 
        /// If an operation is returned, the seek has been registered and subscribers
        /// will eventually receive messages from the seek cursors (i.e. eventual
        /// consistency), as long as they are using a minimum supported client library
        /// version and not a system that tracks cursors independently of Pub/Sub Lite
        /// (e.g. Apache Beam, Dataflow, Spark). The seek operation will fail for
        /// unsupported clients.
        /// 
        /// If clients would like to know when subscribers react to the seek (or not),
        /// they can poll the operation. The seek operation will succeed and complete
        /// once subscribers are ready to receive messages from the seek cursors for
        /// all partitions of the topic. This means that the seek operation will not
        /// complete until all subscribers come online.
        /// 
        /// If the previous seek operation has not yet completed, it will be aborted
        /// and the new invocation of seek will supersede it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SeekSubscriptionResponse, OperationMetadata>> SeekSubscriptionAsync(SeekSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Performs an out-of-band seek for a subscription to a specified target,
        /// which may be timestamps or named positions within the message backlog.
        /// Seek translates these targets to cursors for each partition and
        /// orchestrates subscribers to start consuming messages from these seek
        /// cursors.
        /// 
        /// If an operation is returned, the seek has been registered and subscribers
        /// will eventually receive messages from the seek cursors (i.e. eventual
        /// consistency), as long as they are using a minimum supported client library
        /// version and not a system that tracks cursors independently of Pub/Sub Lite
        /// (e.g. Apache Beam, Dataflow, Spark). The seek operation will fail for
        /// unsupported clients.
        /// 
        /// If clients would like to know when subscribers react to the seek (or not),
        /// they can poll the operation. The seek operation will succeed and complete
        /// once subscribers are ready to receive messages from the seek cursors for
        /// all partitions of the topic. This means that the seek operation will not
        /// complete until all subscribers come online.
        /// 
        /// If the previous seek operation has not yet completed, it will be aborted
        /// and the new invocation of seek will supersede it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SeekSubscriptionResponse, OperationMetadata>> SeekSubscriptionAsync(SeekSubscriptionRequest request, st::CancellationToken cancellationToken) =>
            SeekSubscriptionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>SeekSubscription</c>.</summary>
        public virtual lro::OperationsClient SeekSubscriptionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>SeekSubscription</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<SeekSubscriptionResponse, OperationMetadata> PollOnceSeekSubscription(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<SeekSubscriptionResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SeekSubscriptionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SeekSubscription</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<SeekSubscriptionResponse, OperationMetadata>> PollOnceSeekSubscriptionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<SeekSubscriptionResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SeekSubscriptionOperationsClient, callSettings);

        /// <summary>
        /// Creates a new reservation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Reservation CreateReservation(CreateReservationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new reservation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Reservation> CreateReservationAsync(CreateReservationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new reservation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Reservation> CreateReservationAsync(CreateReservationRequest request, st::CancellationToken cancellationToken) =>
            CreateReservationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new reservation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location in which to create the reservation.
        /// Structured like `projects/{project_number}/locations/{location}`.
        /// </param>
        /// <param name="reservation">
        /// Required. Configuration of the reservation to create. Its `name` field is ignored.
        /// </param>
        /// <param name="reservationId">
        /// Required. The ID to use for the reservation, which will become the final component of
        /// the reservation's name.
        /// 
        /// This value is structured like: `my-reservation-name`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Reservation CreateReservation(string parent, Reservation reservation, string reservationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateReservation(new CreateReservationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Reservation = gax::GaxPreconditions.CheckNotNull(reservation, nameof(reservation)),
                ReservationId = gax::GaxPreconditions.CheckNotNullOrEmpty(reservationId, nameof(reservationId)),
            }, callSettings);

        /// <summary>
        /// Creates a new reservation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location in which to create the reservation.
        /// Structured like `projects/{project_number}/locations/{location}`.
        /// </param>
        /// <param name="reservation">
        /// Required. Configuration of the reservation to create. Its `name` field is ignored.
        /// </param>
        /// <param name="reservationId">
        /// Required. The ID to use for the reservation, which will become the final component of
        /// the reservation's name.
        /// 
        /// This value is structured like: `my-reservation-name`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Reservation> CreateReservationAsync(string parent, Reservation reservation, string reservationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateReservationAsync(new CreateReservationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Reservation = gax::GaxPreconditions.CheckNotNull(reservation, nameof(reservation)),
                ReservationId = gax::GaxPreconditions.CheckNotNullOrEmpty(reservationId, nameof(reservationId)),
            }, callSettings);

        /// <summary>
        /// Creates a new reservation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location in which to create the reservation.
        /// Structured like `projects/{project_number}/locations/{location}`.
        /// </param>
        /// <param name="reservation">
        /// Required. Configuration of the reservation to create. Its `name` field is ignored.
        /// </param>
        /// <param name="reservationId">
        /// Required. The ID to use for the reservation, which will become the final component of
        /// the reservation's name.
        /// 
        /// This value is structured like: `my-reservation-name`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Reservation> CreateReservationAsync(string parent, Reservation reservation, string reservationId, st::CancellationToken cancellationToken) =>
            CreateReservationAsync(parent, reservation, reservationId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new reservation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location in which to create the reservation.
        /// Structured like `projects/{project_number}/locations/{location}`.
        /// </param>
        /// <param name="reservation">
        /// Required. Configuration of the reservation to create. Its `name` field is ignored.
        /// </param>
        /// <param name="reservationId">
        /// Required. The ID to use for the reservation, which will become the final component of
        /// the reservation's name.
        /// 
        /// This value is structured like: `my-reservation-name`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Reservation CreateReservation(gagr::LocationName parent, Reservation reservation, string reservationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateReservation(new CreateReservationRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Reservation = gax::GaxPreconditions.CheckNotNull(reservation, nameof(reservation)),
                ReservationId = gax::GaxPreconditions.CheckNotNullOrEmpty(reservationId, nameof(reservationId)),
            }, callSettings);

        /// <summary>
        /// Creates a new reservation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location in which to create the reservation.
        /// Structured like `projects/{project_number}/locations/{location}`.
        /// </param>
        /// <param name="reservation">
        /// Required. Configuration of the reservation to create. Its `name` field is ignored.
        /// </param>
        /// <param name="reservationId">
        /// Required. The ID to use for the reservation, which will become the final component of
        /// the reservation's name.
        /// 
        /// This value is structured like: `my-reservation-name`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Reservation> CreateReservationAsync(gagr::LocationName parent, Reservation reservation, string reservationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateReservationAsync(new CreateReservationRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Reservation = gax::GaxPreconditions.CheckNotNull(reservation, nameof(reservation)),
                ReservationId = gax::GaxPreconditions.CheckNotNullOrEmpty(reservationId, nameof(reservationId)),
            }, callSettings);

        /// <summary>
        /// Creates a new reservation.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location in which to create the reservation.
        /// Structured like `projects/{project_number}/locations/{location}`.
        /// </param>
        /// <param name="reservation">
        /// Required. Configuration of the reservation to create. Its `name` field is ignored.
        /// </param>
        /// <param name="reservationId">
        /// Required. The ID to use for the reservation, which will become the final component of
        /// the reservation's name.
        /// 
        /// This value is structured like: `my-reservation-name`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Reservation> CreateReservationAsync(gagr::LocationName parent, Reservation reservation, string reservationId, st::CancellationToken cancellationToken) =>
            CreateReservationAsync(parent, reservation, reservationId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the reservation configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Reservation GetReservation(GetReservationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the reservation configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Reservation> GetReservationAsync(GetReservationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the reservation configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Reservation> GetReservationAsync(GetReservationRequest request, st::CancellationToken cancellationToken) =>
            GetReservationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the reservation configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the reservation whose configuration to return.
        /// Structured like:
        /// projects/{project_number}/locations/{location}/reservations/{reservation_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Reservation GetReservation(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetReservation(new GetReservationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the reservation configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the reservation whose configuration to return.
        /// Structured like:
        /// projects/{project_number}/locations/{location}/reservations/{reservation_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Reservation> GetReservationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetReservationAsync(new GetReservationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the reservation configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the reservation whose configuration to return.
        /// Structured like:
        /// projects/{project_number}/locations/{location}/reservations/{reservation_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Reservation> GetReservationAsync(string name, st::CancellationToken cancellationToken) =>
            GetReservationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the reservation configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the reservation whose configuration to return.
        /// Structured like:
        /// projects/{project_number}/locations/{location}/reservations/{reservation_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Reservation GetReservation(ReservationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetReservation(new GetReservationRequest
            {
                ReservationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the reservation configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the reservation whose configuration to return.
        /// Structured like:
        /// projects/{project_number}/locations/{location}/reservations/{reservation_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Reservation> GetReservationAsync(ReservationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetReservationAsync(new GetReservationRequest
            {
                ReservationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the reservation configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the reservation whose configuration to return.
        /// Structured like:
        /// projects/{project_number}/locations/{location}/reservations/{reservation_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Reservation> GetReservationAsync(ReservationName name, st::CancellationToken cancellationToken) =>
            GetReservationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the list of reservations for the given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Reservation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReservationsResponse, Reservation> ListReservations(ListReservationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of reservations for the given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Reservation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReservationsResponse, Reservation> ListReservationsAsync(ListReservationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of reservations for the given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent whose reservations are to be listed.
        /// Structured like `projects/{project_number}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="Reservation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReservationsResponse, Reservation> ListReservations(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListReservations(new ListReservationsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns the list of reservations for the given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent whose reservations are to be listed.
        /// Structured like `projects/{project_number}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Reservation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReservationsResponse, Reservation> ListReservationsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListReservationsAsync(new ListReservationsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns the list of reservations for the given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent whose reservations are to be listed.
        /// Structured like `projects/{project_number}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="Reservation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReservationsResponse, Reservation> ListReservations(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListReservations(new ListReservationsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns the list of reservations for the given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent whose reservations are to be listed.
        /// Structured like `projects/{project_number}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Reservation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReservationsResponse, Reservation> ListReservationsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListReservationsAsync(new ListReservationsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Updates properties of the specified reservation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Reservation UpdateReservation(UpdateReservationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates properties of the specified reservation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Reservation> UpdateReservationAsync(UpdateReservationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates properties of the specified reservation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Reservation> UpdateReservationAsync(UpdateReservationRequest request, st::CancellationToken cancellationToken) =>
            UpdateReservationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates properties of the specified reservation.
        /// </summary>
        /// <param name="reservation">
        /// Required. The reservation to update. Its `name` field must be populated.
        /// </param>
        /// <param name="updateMask">
        /// Required. A mask specifying the reservation fields to change.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Reservation UpdateReservation(Reservation reservation, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateReservation(new UpdateReservationRequest
            {
                Reservation = gax::GaxPreconditions.CheckNotNull(reservation, nameof(reservation)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates properties of the specified reservation.
        /// </summary>
        /// <param name="reservation">
        /// Required. The reservation to update. Its `name` field must be populated.
        /// </param>
        /// <param name="updateMask">
        /// Required. A mask specifying the reservation fields to change.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Reservation> UpdateReservationAsync(Reservation reservation, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateReservationAsync(new UpdateReservationRequest
            {
                Reservation = gax::GaxPreconditions.CheckNotNull(reservation, nameof(reservation)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates properties of the specified reservation.
        /// </summary>
        /// <param name="reservation">
        /// Required. The reservation to update. Its `name` field must be populated.
        /// </param>
        /// <param name="updateMask">
        /// Required. A mask specifying the reservation fields to change.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Reservation> UpdateReservationAsync(Reservation reservation, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateReservationAsync(reservation, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified reservation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteReservation(DeleteReservationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified reservation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteReservationAsync(DeleteReservationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified reservation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteReservationAsync(DeleteReservationRequest request, st::CancellationToken cancellationToken) =>
            DeleteReservationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified reservation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the reservation to delete.
        /// Structured like:
        /// projects/{project_number}/locations/{location}/reservations/{reservation_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteReservation(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteReservation(new DeleteReservationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified reservation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the reservation to delete.
        /// Structured like:
        /// projects/{project_number}/locations/{location}/reservations/{reservation_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteReservationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteReservationAsync(new DeleteReservationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified reservation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the reservation to delete.
        /// Structured like:
        /// projects/{project_number}/locations/{location}/reservations/{reservation_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteReservationAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteReservationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified reservation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the reservation to delete.
        /// Structured like:
        /// projects/{project_number}/locations/{location}/reservations/{reservation_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteReservation(ReservationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteReservation(new DeleteReservationRequest
            {
                ReservationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified reservation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the reservation to delete.
        /// Structured like:
        /// projects/{project_number}/locations/{location}/reservations/{reservation_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteReservationAsync(ReservationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteReservationAsync(new DeleteReservationRequest
            {
                ReservationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified reservation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the reservation to delete.
        /// Structured like:
        /// projects/{project_number}/locations/{location}/reservations/{reservation_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteReservationAsync(ReservationName name, st::CancellationToken cancellationToken) =>
            DeleteReservationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the topics attached to the specified reservation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReservationTopicsResponse, string> ListReservationTopics(ListReservationTopicsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the topics attached to the specified reservation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReservationTopicsResponse, string> ListReservationTopicsAsync(ListReservationTopicsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the topics attached to the specified reservation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the reservation whose topics to list.
        /// Structured like:
        /// projects/{project_number}/locations/{location}/reservations/{reservation_id}
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
        /// <returns>A pageable sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReservationTopicsResponse, string> ListReservationTopics(string name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListReservationTopics(new ListReservationTopicsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists the topics attached to the specified reservation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the reservation whose topics to list.
        /// Structured like:
        /// projects/{project_number}/locations/{location}/reservations/{reservation_id}
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
        /// <returns>A pageable asynchronous sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReservationTopicsResponse, string> ListReservationTopicsAsync(string name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListReservationTopicsAsync(new ListReservationTopicsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists the topics attached to the specified reservation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the reservation whose topics to list.
        /// Structured like:
        /// projects/{project_number}/locations/{location}/reservations/{reservation_id}
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
        /// <returns>A pageable sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReservationTopicsResponse, string> ListReservationTopics(ReservationName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListReservationTopics(new ListReservationTopicsRequest
            {
                ReservationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists the topics attached to the specified reservation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the reservation whose topics to list.
        /// Structured like:
        /// projects/{project_number}/locations/{location}/reservations/{reservation_id}
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
        /// <returns>A pageable asynchronous sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReservationTopicsResponse, string> ListReservationTopicsAsync(ReservationName name, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListReservationTopicsAsync(new ListReservationTopicsRequest
            {
                ReservationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);
    }

    /// <summary>AdminService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The service that a client application uses to manage topics and
    /// subscriptions, such creating, listing, and deleting topics and subscriptions.
    /// </remarks>
    public sealed partial class AdminServiceClientImpl : AdminServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateTopicRequest, Topic> _callCreateTopic;

        private readonly gaxgrpc::ApiCall<GetTopicRequest, Topic> _callGetTopic;

        private readonly gaxgrpc::ApiCall<GetTopicPartitionsRequest, TopicPartitions> _callGetTopicPartitions;

        private readonly gaxgrpc::ApiCall<ListTopicsRequest, ListTopicsResponse> _callListTopics;

        private readonly gaxgrpc::ApiCall<UpdateTopicRequest, Topic> _callUpdateTopic;

        private readonly gaxgrpc::ApiCall<DeleteTopicRequest, wkt::Empty> _callDeleteTopic;

        private readonly gaxgrpc::ApiCall<ListTopicSubscriptionsRequest, ListTopicSubscriptionsResponse> _callListTopicSubscriptions;

        private readonly gaxgrpc::ApiCall<CreateSubscriptionRequest, Subscription> _callCreateSubscription;

        private readonly gaxgrpc::ApiCall<GetSubscriptionRequest, Subscription> _callGetSubscription;

        private readonly gaxgrpc::ApiCall<ListSubscriptionsRequest, ListSubscriptionsResponse> _callListSubscriptions;

        private readonly gaxgrpc::ApiCall<UpdateSubscriptionRequest, Subscription> _callUpdateSubscription;

        private readonly gaxgrpc::ApiCall<DeleteSubscriptionRequest, wkt::Empty> _callDeleteSubscription;

        private readonly gaxgrpc::ApiCall<SeekSubscriptionRequest, lro::Operation> _callSeekSubscription;

        private readonly gaxgrpc::ApiCall<CreateReservationRequest, Reservation> _callCreateReservation;

        private readonly gaxgrpc::ApiCall<GetReservationRequest, Reservation> _callGetReservation;

        private readonly gaxgrpc::ApiCall<ListReservationsRequest, ListReservationsResponse> _callListReservations;

        private readonly gaxgrpc::ApiCall<UpdateReservationRequest, Reservation> _callUpdateReservation;

        private readonly gaxgrpc::ApiCall<DeleteReservationRequest, wkt::Empty> _callDeleteReservation;

        private readonly gaxgrpc::ApiCall<ListReservationTopicsRequest, ListReservationTopicsResponse> _callListReservationTopics;

        /// <summary>
        /// Constructs a client wrapper for the AdminService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AdminServiceSettings"/> used within this client.</param>
        public AdminServiceClientImpl(AdminService.AdminServiceClient grpcClient, AdminServiceSettings settings)
        {
            GrpcClient = grpcClient;
            AdminServiceSettings effectiveSettings = settings ?? AdminServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            SeekSubscriptionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.SeekSubscriptionOperationsSettings);
            _callCreateTopic = clientHelper.BuildApiCall<CreateTopicRequest, Topic>(grpcClient.CreateTopicAsync, grpcClient.CreateTopic, effectiveSettings.CreateTopicSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateTopic);
            Modify_CreateTopicApiCall(ref _callCreateTopic);
            _callGetTopic = clientHelper.BuildApiCall<GetTopicRequest, Topic>(grpcClient.GetTopicAsync, grpcClient.GetTopic, effectiveSettings.GetTopicSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetTopic);
            Modify_GetTopicApiCall(ref _callGetTopic);
            _callGetTopicPartitions = clientHelper.BuildApiCall<GetTopicPartitionsRequest, TopicPartitions>(grpcClient.GetTopicPartitionsAsync, grpcClient.GetTopicPartitions, effectiveSettings.GetTopicPartitionsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetTopicPartitions);
            Modify_GetTopicPartitionsApiCall(ref _callGetTopicPartitions);
            _callListTopics = clientHelper.BuildApiCall<ListTopicsRequest, ListTopicsResponse>(grpcClient.ListTopicsAsync, grpcClient.ListTopics, effectiveSettings.ListTopicsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListTopics);
            Modify_ListTopicsApiCall(ref _callListTopics);
            _callUpdateTopic = clientHelper.BuildApiCall<UpdateTopicRequest, Topic>(grpcClient.UpdateTopicAsync, grpcClient.UpdateTopic, effectiveSettings.UpdateTopicSettings).WithGoogleRequestParam("topic.name", request => request.Topic?.Name);
            Modify_ApiCall(ref _callUpdateTopic);
            Modify_UpdateTopicApiCall(ref _callUpdateTopic);
            _callDeleteTopic = clientHelper.BuildApiCall<DeleteTopicRequest, wkt::Empty>(grpcClient.DeleteTopicAsync, grpcClient.DeleteTopic, effectiveSettings.DeleteTopicSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteTopic);
            Modify_DeleteTopicApiCall(ref _callDeleteTopic);
            _callListTopicSubscriptions = clientHelper.BuildApiCall<ListTopicSubscriptionsRequest, ListTopicSubscriptionsResponse>(grpcClient.ListTopicSubscriptionsAsync, grpcClient.ListTopicSubscriptions, effectiveSettings.ListTopicSubscriptionsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callListTopicSubscriptions);
            Modify_ListTopicSubscriptionsApiCall(ref _callListTopicSubscriptions);
            _callCreateSubscription = clientHelper.BuildApiCall<CreateSubscriptionRequest, Subscription>(grpcClient.CreateSubscriptionAsync, grpcClient.CreateSubscription, effectiveSettings.CreateSubscriptionSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateSubscription);
            Modify_CreateSubscriptionApiCall(ref _callCreateSubscription);
            _callGetSubscription = clientHelper.BuildApiCall<GetSubscriptionRequest, Subscription>(grpcClient.GetSubscriptionAsync, grpcClient.GetSubscription, effectiveSettings.GetSubscriptionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSubscription);
            Modify_GetSubscriptionApiCall(ref _callGetSubscription);
            _callListSubscriptions = clientHelper.BuildApiCall<ListSubscriptionsRequest, ListSubscriptionsResponse>(grpcClient.ListSubscriptionsAsync, grpcClient.ListSubscriptions, effectiveSettings.ListSubscriptionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSubscriptions);
            Modify_ListSubscriptionsApiCall(ref _callListSubscriptions);
            _callUpdateSubscription = clientHelper.BuildApiCall<UpdateSubscriptionRequest, Subscription>(grpcClient.UpdateSubscriptionAsync, grpcClient.UpdateSubscription, effectiveSettings.UpdateSubscriptionSettings).WithGoogleRequestParam("subscription.name", request => request.Subscription?.Name);
            Modify_ApiCall(ref _callUpdateSubscription);
            Modify_UpdateSubscriptionApiCall(ref _callUpdateSubscription);
            _callDeleteSubscription = clientHelper.BuildApiCall<DeleteSubscriptionRequest, wkt::Empty>(grpcClient.DeleteSubscriptionAsync, grpcClient.DeleteSubscription, effectiveSettings.DeleteSubscriptionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteSubscription);
            Modify_DeleteSubscriptionApiCall(ref _callDeleteSubscription);
            _callSeekSubscription = clientHelper.BuildApiCall<SeekSubscriptionRequest, lro::Operation>(grpcClient.SeekSubscriptionAsync, grpcClient.SeekSubscription, effectiveSettings.SeekSubscriptionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callSeekSubscription);
            Modify_SeekSubscriptionApiCall(ref _callSeekSubscription);
            _callCreateReservation = clientHelper.BuildApiCall<CreateReservationRequest, Reservation>(grpcClient.CreateReservationAsync, grpcClient.CreateReservation, effectiveSettings.CreateReservationSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateReservation);
            Modify_CreateReservationApiCall(ref _callCreateReservation);
            _callGetReservation = clientHelper.BuildApiCall<GetReservationRequest, Reservation>(grpcClient.GetReservationAsync, grpcClient.GetReservation, effectiveSettings.GetReservationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetReservation);
            Modify_GetReservationApiCall(ref _callGetReservation);
            _callListReservations = clientHelper.BuildApiCall<ListReservationsRequest, ListReservationsResponse>(grpcClient.ListReservationsAsync, grpcClient.ListReservations, effectiveSettings.ListReservationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListReservations);
            Modify_ListReservationsApiCall(ref _callListReservations);
            _callUpdateReservation = clientHelper.BuildApiCall<UpdateReservationRequest, Reservation>(grpcClient.UpdateReservationAsync, grpcClient.UpdateReservation, effectiveSettings.UpdateReservationSettings).WithGoogleRequestParam("reservation.name", request => request.Reservation?.Name);
            Modify_ApiCall(ref _callUpdateReservation);
            Modify_UpdateReservationApiCall(ref _callUpdateReservation);
            _callDeleteReservation = clientHelper.BuildApiCall<DeleteReservationRequest, wkt::Empty>(grpcClient.DeleteReservationAsync, grpcClient.DeleteReservation, effectiveSettings.DeleteReservationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteReservation);
            Modify_DeleteReservationApiCall(ref _callDeleteReservation);
            _callListReservationTopics = clientHelper.BuildApiCall<ListReservationTopicsRequest, ListReservationTopicsResponse>(grpcClient.ListReservationTopicsAsync, grpcClient.ListReservationTopics, effectiveSettings.ListReservationTopicsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callListReservationTopics);
            Modify_ListReservationTopicsApiCall(ref _callListReservationTopics);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateTopicApiCall(ref gaxgrpc::ApiCall<CreateTopicRequest, Topic> call);

        partial void Modify_GetTopicApiCall(ref gaxgrpc::ApiCall<GetTopicRequest, Topic> call);

        partial void Modify_GetTopicPartitionsApiCall(ref gaxgrpc::ApiCall<GetTopicPartitionsRequest, TopicPartitions> call);

        partial void Modify_ListTopicsApiCall(ref gaxgrpc::ApiCall<ListTopicsRequest, ListTopicsResponse> call);

        partial void Modify_UpdateTopicApiCall(ref gaxgrpc::ApiCall<UpdateTopicRequest, Topic> call);

        partial void Modify_DeleteTopicApiCall(ref gaxgrpc::ApiCall<DeleteTopicRequest, wkt::Empty> call);

        partial void Modify_ListTopicSubscriptionsApiCall(ref gaxgrpc::ApiCall<ListTopicSubscriptionsRequest, ListTopicSubscriptionsResponse> call);

        partial void Modify_CreateSubscriptionApiCall(ref gaxgrpc::ApiCall<CreateSubscriptionRequest, Subscription> call);

        partial void Modify_GetSubscriptionApiCall(ref gaxgrpc::ApiCall<GetSubscriptionRequest, Subscription> call);

        partial void Modify_ListSubscriptionsApiCall(ref gaxgrpc::ApiCall<ListSubscriptionsRequest, ListSubscriptionsResponse> call);

        partial void Modify_UpdateSubscriptionApiCall(ref gaxgrpc::ApiCall<UpdateSubscriptionRequest, Subscription> call);

        partial void Modify_DeleteSubscriptionApiCall(ref gaxgrpc::ApiCall<DeleteSubscriptionRequest, wkt::Empty> call);

        partial void Modify_SeekSubscriptionApiCall(ref gaxgrpc::ApiCall<SeekSubscriptionRequest, lro::Operation> call);

        partial void Modify_CreateReservationApiCall(ref gaxgrpc::ApiCall<CreateReservationRequest, Reservation> call);

        partial void Modify_GetReservationApiCall(ref gaxgrpc::ApiCall<GetReservationRequest, Reservation> call);

        partial void Modify_ListReservationsApiCall(ref gaxgrpc::ApiCall<ListReservationsRequest, ListReservationsResponse> call);

        partial void Modify_UpdateReservationApiCall(ref gaxgrpc::ApiCall<UpdateReservationRequest, Reservation> call);

        partial void Modify_DeleteReservationApiCall(ref gaxgrpc::ApiCall<DeleteReservationRequest, wkt::Empty> call);

        partial void Modify_ListReservationTopicsApiCall(ref gaxgrpc::ApiCall<ListReservationTopicsRequest, ListReservationTopicsResponse> call);

        partial void OnConstruction(AdminService.AdminServiceClient grpcClient, AdminServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AdminService client</summary>
        public override AdminService.AdminServiceClient GrpcClient { get; }

        partial void Modify_CreateTopicRequest(ref CreateTopicRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetTopicRequest(ref GetTopicRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetTopicPartitionsRequest(ref GetTopicPartitionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTopicsRequest(ref ListTopicsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateTopicRequest(ref UpdateTopicRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteTopicRequest(ref DeleteTopicRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTopicSubscriptionsRequest(ref ListTopicSubscriptionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateSubscriptionRequest(ref CreateSubscriptionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSubscriptionRequest(ref GetSubscriptionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSubscriptionsRequest(ref ListSubscriptionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateSubscriptionRequest(ref UpdateSubscriptionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteSubscriptionRequest(ref DeleteSubscriptionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SeekSubscriptionRequest(ref SeekSubscriptionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateReservationRequest(ref CreateReservationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetReservationRequest(ref GetReservationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListReservationsRequest(ref ListReservationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateReservationRequest(ref UpdateReservationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteReservationRequest(ref DeleteReservationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListReservationTopicsRequest(ref ListReservationTopicsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a new topic.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Topic CreateTopic(CreateTopicRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTopicRequest(ref request, ref callSettings);
            return _callCreateTopic.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new topic.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Topic> CreateTopicAsync(CreateTopicRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTopicRequest(ref request, ref callSettings);
            return _callCreateTopic.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the topic configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Topic GetTopic(GetTopicRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTopicRequest(ref request, ref callSettings);
            return _callGetTopic.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the topic configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Topic> GetTopicAsync(GetTopicRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTopicRequest(ref request, ref callSettings);
            return _callGetTopic.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the partition information for the requested topic.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TopicPartitions GetTopicPartitions(GetTopicPartitionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTopicPartitionsRequest(ref request, ref callSettings);
            return _callGetTopicPartitions.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the partition information for the requested topic.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TopicPartitions> GetTopicPartitionsAsync(GetTopicPartitionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTopicPartitionsRequest(ref request, ref callSettings);
            return _callGetTopicPartitions.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the list of topics for the given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Topic"/> resources.</returns>
        public override gax::PagedEnumerable<ListTopicsResponse, Topic> ListTopics(ListTopicsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTopicsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTopicsRequest, ListTopicsResponse, Topic>(_callListTopics, request, callSettings);
        }

        /// <summary>
        /// Returns the list of topics for the given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Topic"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTopicsResponse, Topic> ListTopicsAsync(ListTopicsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTopicsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTopicsRequest, ListTopicsResponse, Topic>(_callListTopics, request, callSettings);
        }

        /// <summary>
        /// Updates properties of the specified topic.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Topic UpdateTopic(UpdateTopicRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTopicRequest(ref request, ref callSettings);
            return _callUpdateTopic.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates properties of the specified topic.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Topic> UpdateTopicAsync(UpdateTopicRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTopicRequest(ref request, ref callSettings);
            return _callUpdateTopic.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified topic.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteTopic(DeleteTopicRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTopicRequest(ref request, ref callSettings);
            _callDeleteTopic.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified topic.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteTopicAsync(DeleteTopicRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTopicRequest(ref request, ref callSettings);
            return _callDeleteTopic.Async(request, callSettings);
        }

        /// <summary>
        /// Lists the subscriptions attached to the specified topic.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="string"/> resources.</returns>
        public override gax::PagedEnumerable<ListTopicSubscriptionsResponse, string> ListTopicSubscriptions(ListTopicSubscriptionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTopicSubscriptionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTopicSubscriptionsRequest, ListTopicSubscriptionsResponse, string>(_callListTopicSubscriptions, request, callSettings);
        }

        /// <summary>
        /// Lists the subscriptions attached to the specified topic.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="string"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTopicSubscriptionsResponse, string> ListTopicSubscriptionsAsync(ListTopicSubscriptionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTopicSubscriptionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTopicSubscriptionsRequest, ListTopicSubscriptionsResponse, string>(_callListTopicSubscriptions, request, callSettings);
        }

        /// <summary>
        /// Creates a new subscription.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Subscription CreateSubscription(CreateSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSubscriptionRequest(ref request, ref callSettings);
            return _callCreateSubscription.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new subscription.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Subscription> CreateSubscriptionAsync(CreateSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSubscriptionRequest(ref request, ref callSettings);
            return _callCreateSubscription.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the subscription configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Subscription GetSubscription(GetSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSubscriptionRequest(ref request, ref callSettings);
            return _callGetSubscription.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the subscription configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Subscription> GetSubscriptionAsync(GetSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSubscriptionRequest(ref request, ref callSettings);
            return _callGetSubscription.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the list of subscriptions for the given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Subscription"/> resources.</returns>
        public override gax::PagedEnumerable<ListSubscriptionsResponse, Subscription> ListSubscriptions(ListSubscriptionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSubscriptionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSubscriptionsRequest, ListSubscriptionsResponse, Subscription>(_callListSubscriptions, request, callSettings);
        }

        /// <summary>
        /// Returns the list of subscriptions for the given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Subscription"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSubscriptionsResponse, Subscription> ListSubscriptionsAsync(ListSubscriptionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSubscriptionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSubscriptionsRequest, ListSubscriptionsResponse, Subscription>(_callListSubscriptions, request, callSettings);
        }

        /// <summary>
        /// Updates properties of the specified subscription.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Subscription UpdateSubscription(UpdateSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSubscriptionRequest(ref request, ref callSettings);
            return _callUpdateSubscription.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates properties of the specified subscription.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Subscription> UpdateSubscriptionAsync(UpdateSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSubscriptionRequest(ref request, ref callSettings);
            return _callUpdateSubscription.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified subscription.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteSubscription(DeleteSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSubscriptionRequest(ref request, ref callSettings);
            _callDeleteSubscription.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified subscription.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteSubscriptionAsync(DeleteSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSubscriptionRequest(ref request, ref callSettings);
            return _callDeleteSubscription.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>SeekSubscription</c>.</summary>
        public override lro::OperationsClient SeekSubscriptionOperationsClient { get; }

        /// <summary>
        /// Performs an out-of-band seek for a subscription to a specified target,
        /// which may be timestamps or named positions within the message backlog.
        /// Seek translates these targets to cursors for each partition and
        /// orchestrates subscribers to start consuming messages from these seek
        /// cursors.
        /// 
        /// If an operation is returned, the seek has been registered and subscribers
        /// will eventually receive messages from the seek cursors (i.e. eventual
        /// consistency), as long as they are using a minimum supported client library
        /// version and not a system that tracks cursors independently of Pub/Sub Lite
        /// (e.g. Apache Beam, Dataflow, Spark). The seek operation will fail for
        /// unsupported clients.
        /// 
        /// If clients would like to know when subscribers react to the seek (or not),
        /// they can poll the operation. The seek operation will succeed and complete
        /// once subscribers are ready to receive messages from the seek cursors for
        /// all partitions of the topic. This means that the seek operation will not
        /// complete until all subscribers come online.
        /// 
        /// If the previous seek operation has not yet completed, it will be aborted
        /// and the new invocation of seek will supersede it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<SeekSubscriptionResponse, OperationMetadata> SeekSubscription(SeekSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SeekSubscriptionRequest(ref request, ref callSettings);
            return new lro::Operation<SeekSubscriptionResponse, OperationMetadata>(_callSeekSubscription.Sync(request, callSettings), SeekSubscriptionOperationsClient);
        }

        /// <summary>
        /// Performs an out-of-band seek for a subscription to a specified target,
        /// which may be timestamps or named positions within the message backlog.
        /// Seek translates these targets to cursors for each partition and
        /// orchestrates subscribers to start consuming messages from these seek
        /// cursors.
        /// 
        /// If an operation is returned, the seek has been registered and subscribers
        /// will eventually receive messages from the seek cursors (i.e. eventual
        /// consistency), as long as they are using a minimum supported client library
        /// version and not a system that tracks cursors independently of Pub/Sub Lite
        /// (e.g. Apache Beam, Dataflow, Spark). The seek operation will fail for
        /// unsupported clients.
        /// 
        /// If clients would like to know when subscribers react to the seek (or not),
        /// they can poll the operation. The seek operation will succeed and complete
        /// once subscribers are ready to receive messages from the seek cursors for
        /// all partitions of the topic. This means that the seek operation will not
        /// complete until all subscribers come online.
        /// 
        /// If the previous seek operation has not yet completed, it will be aborted
        /// and the new invocation of seek will supersede it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<SeekSubscriptionResponse, OperationMetadata>> SeekSubscriptionAsync(SeekSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SeekSubscriptionRequest(ref request, ref callSettings);
            return new lro::Operation<SeekSubscriptionResponse, OperationMetadata>(await _callSeekSubscription.Async(request, callSettings).ConfigureAwait(false), SeekSubscriptionOperationsClient);
        }

        /// <summary>
        /// Creates a new reservation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Reservation CreateReservation(CreateReservationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateReservationRequest(ref request, ref callSettings);
            return _callCreateReservation.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new reservation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Reservation> CreateReservationAsync(CreateReservationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateReservationRequest(ref request, ref callSettings);
            return _callCreateReservation.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the reservation configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Reservation GetReservation(GetReservationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetReservationRequest(ref request, ref callSettings);
            return _callGetReservation.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the reservation configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Reservation> GetReservationAsync(GetReservationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetReservationRequest(ref request, ref callSettings);
            return _callGetReservation.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the list of reservations for the given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Reservation"/> resources.</returns>
        public override gax::PagedEnumerable<ListReservationsResponse, Reservation> ListReservations(ListReservationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListReservationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListReservationsRequest, ListReservationsResponse, Reservation>(_callListReservations, request, callSettings);
        }

        /// <summary>
        /// Returns the list of reservations for the given project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Reservation"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListReservationsResponse, Reservation> ListReservationsAsync(ListReservationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListReservationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListReservationsRequest, ListReservationsResponse, Reservation>(_callListReservations, request, callSettings);
        }

        /// <summary>
        /// Updates properties of the specified reservation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Reservation UpdateReservation(UpdateReservationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateReservationRequest(ref request, ref callSettings);
            return _callUpdateReservation.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates properties of the specified reservation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Reservation> UpdateReservationAsync(UpdateReservationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateReservationRequest(ref request, ref callSettings);
            return _callUpdateReservation.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified reservation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteReservation(DeleteReservationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteReservationRequest(ref request, ref callSettings);
            _callDeleteReservation.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified reservation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteReservationAsync(DeleteReservationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteReservationRequest(ref request, ref callSettings);
            return _callDeleteReservation.Async(request, callSettings);
        }

        /// <summary>
        /// Lists the topics attached to the specified reservation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="string"/> resources.</returns>
        public override gax::PagedEnumerable<ListReservationTopicsResponse, string> ListReservationTopics(ListReservationTopicsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListReservationTopicsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListReservationTopicsRequest, ListReservationTopicsResponse, string>(_callListReservationTopics, request, callSettings);
        }

        /// <summary>
        /// Lists the topics attached to the specified reservation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="string"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListReservationTopicsResponse, string> ListReservationTopicsAsync(ListReservationTopicsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListReservationTopicsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListReservationTopicsRequest, ListReservationTopicsResponse, string>(_callListReservationTopics, request, callSettings);
        }
    }

    public partial class ListTopicsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTopicSubscriptionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSubscriptionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListReservationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListReservationTopicsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTopicsResponse : gaxgrpc::IPageResponse<Topic>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Topic> GetEnumerator() => Topics.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListTopicSubscriptionsResponse : gaxgrpc::IPageResponse<string>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<string> GetEnumerator() => Subscriptions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListSubscriptionsResponse : gaxgrpc::IPageResponse<Subscription>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Subscription> GetEnumerator() => Subscriptions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListReservationsResponse : gaxgrpc::IPageResponse<Reservation>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Reservation> GetEnumerator() => Reservations.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListReservationTopicsResponse : gaxgrpc::IPageResponse<string>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<string> GetEnumerator() => Topics.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class AdminService
    {
        public partial class AdminServiceClient
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
