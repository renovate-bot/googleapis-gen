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

using gagr = Google.Api.Gax.ResourceNames;
using gcpv = Google.Cloud.PubSubLite.V1;

namespace Google.Cloud.PubSubLite.V1
{
    public partial class CreateTopicRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetTopicRequest
    {
        /// <summary>
        /// <see cref="gcpv::TopicName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcpv::TopicName TopicName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcpv::TopicName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetTopicPartitionsRequest
    {
        /// <summary>
        /// <see cref="gcpv::TopicName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcpv::TopicName TopicName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcpv::TopicName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListTopicsRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteTopicRequest
    {
        /// <summary>
        /// <see cref="gcpv::TopicName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcpv::TopicName TopicName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcpv::TopicName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListTopicSubscriptionsRequest
    {
        /// <summary>
        /// <see cref="gcpv::TopicName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcpv::TopicName TopicName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcpv::TopicName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateSubscriptionRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetSubscriptionRequest
    {
        /// <summary>
        /// <see cref="gcpv::SubscriptionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcpv::SubscriptionName SubscriptionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcpv::SubscriptionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListSubscriptionsRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteSubscriptionRequest
    {
        /// <summary>
        /// <see cref="gcpv::SubscriptionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcpv::SubscriptionName SubscriptionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcpv::SubscriptionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateReservationRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetReservationRequest
    {
        /// <summary>
        /// <see cref="gcpv::ReservationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcpv::ReservationName ReservationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcpv::ReservationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListReservationsRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteReservationRequest
    {
        /// <summary>
        /// <see cref="gcpv::ReservationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcpv::ReservationName ReservationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcpv::ReservationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListReservationTopicsRequest
    {
        /// <summary>
        /// <see cref="gcpv::ReservationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcpv::ReservationName ReservationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcpv::ReservationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
