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
        # A NetworkSettings resource is a container for ingress settings for a version
        # or service.
        # @!attribute [rw] ingress_traffic_allowed
        #   @return [::Google::Cloud::AppEngine::V1::NetworkSettings::IngressTrafficAllowed]
        #     The ingress settings for version or service.
        class NetworkSettings
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods

          # If unspecified, INGRESS_TRAFFIC_ALLOWED_ALL will be used.
          module IngressTrafficAllowed
            # Unspecified
            INGRESS_TRAFFIC_ALLOWED_UNSPECIFIED = 0

            # Allow HTTP traffic from public and private sources.
            INGRESS_TRAFFIC_ALLOWED_ALL = 1

            # Allow HTTP traffic from only private VPC sources.
            INGRESS_TRAFFIC_ALLOWED_INTERNAL_ONLY = 2

            # Allow HTTP traffic from private VPC sources and through load balancers.
            INGRESS_TRAFFIC_ALLOWED_INTERNAL_AND_LB = 3
          end
        end
      end
    end
  end
end
