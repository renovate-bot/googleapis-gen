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
    module AssuredWorkloads
      module V1
        module AssuredWorkloadsService
          # Path helper methods for the AssuredWorkloadsService API.
          module Paths
            ##
            # Create a fully-qualified Location resource string.
            #
            # The resource will be in the following format:
            #
            # `organizations/{organization}/locations/{location}`
            #
            # @param organization [String]
            # @param location [String]
            #
            # @return [::String]
            def location_path organization:, location:
              raise ::ArgumentError, "organization cannot contain /" if organization.to_s.include? "/"

              "organizations/#{organization}/locations/#{location}"
            end

            ##
            # Create a fully-qualified Workload resource string.
            #
            # The resource will be in the following format:
            #
            # `organizations/{organization}/locations/{location}/workloads/{workload}`
            #
            # @param organization [String]
            # @param location [String]
            # @param workload [String]
            #
            # @return [::String]
            def workload_path organization:, location:, workload:
              raise ::ArgumentError, "organization cannot contain /" if organization.to_s.include? "/"
              raise ::ArgumentError, "location cannot contain /" if location.to_s.include? "/"

              "organizations/#{organization}/locations/#{location}/workloads/#{workload}"
            end

            extend self
          end
        end
      end
    end
  end
end
