# frozen_string_literal: true

# Copyright 2022 Google LLC
#
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
#
#     https://www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.

# Auto-generated by gapic-generator-ruby. DO NOT EDIT!


module Google
  module Cloud
    module AppEngine
      module V1
        # A Service resource is a logical component of an application that can share
        # state and communicate in a secure fashion with other services.
        # For example, an application that handles customer requests might
        # include separate services to handle tasks such as backend data
        # analysis or API requests from mobile devices. Each service has a
        # collection of versions that define a specific set of code used to
        # implement the functionality of that service.
        # @!attribute [rw] name
        #   @return [::String]
        #     Full path to the Service resource in the API.
        #     Example: `apps/myapp/services/default`.
        # @!attribute [rw] id
        #   @return [::String]
        #     Relative name of the service within the application.
        #     Example: `default`.
        # @!attribute [rw] split
        #   @return [::Google::Cloud::AppEngine::V1::TrafficSplit]
        #     Mapping that defines fractional HTTP traffic diversion to
        #     different versions within the service.
        # @!attribute [rw] network_settings
        #   @return [::Google::Cloud::AppEngine::V1::NetworkSettings]
        #     Ingress settings for this service. Will apply to all versions.
        class Service
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Traffic routing configuration for versions within a single service. Traffic
        # splits define how traffic directed to the service is assigned to versions.
        # @!attribute [rw] shard_by
        #   @return [::Google::Cloud::AppEngine::V1::TrafficSplit::ShardBy]
        #     Mechanism used to determine which version a request is sent to.
        #     The traffic selection algorithm will
        #     be stable for either type until allocations are changed.
        # @!attribute [rw] allocations
        #   @return [::Google::Protobuf::Map{::String => ::Float}]
        #     Mapping from version IDs within the service to fractional
        #     (0.000, 1] allocations of traffic for that version. Each version can
        #     be specified only once, but some versions in the service may not
        #     have any traffic allocation. Services that have traffic allocated
        #     cannot be deleted until either the service is deleted or
        #     their traffic allocation is removed. Allocations must sum to 1.
        #     Up to two decimal place precision is supported for IP-based splits and
        #     up to three decimal places is supported for cookie-based splits.
        class TrafficSplit
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods

          # @!attribute [rw] key
          #   @return [::String]
          # @!attribute [rw] value
          #   @return [::Float]
          class AllocationsEntry
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # Available sharding mechanisms.
          module ShardBy
            # Diversion method unspecified.
            UNSPECIFIED = 0

            # Diversion based on a specially named cookie, "GOOGAPPUID." The cookie
            # must be set by the application itself or no diversion will occur.
            COOKIE = 1

            # Diversion based on applying the modulus operation to a fingerprint
            # of the IP address.
            IP = 2

            # Diversion based on weighted random assignment. An incoming request is
            # randomly routed to a version in the traffic split, with probability
            # proportional to the version's traffic share.
            RANDOM = 3
          end
        end
      end
    end
  end
end
