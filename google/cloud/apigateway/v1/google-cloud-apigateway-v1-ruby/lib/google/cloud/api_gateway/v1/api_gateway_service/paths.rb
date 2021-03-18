# frozen_string_literal: true

# Copyright 2021 Google LLC
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
    module APIGateway
      module V1
        module ApiGatewayService
          # Path helper methods for the ApiGatewayService API.
          module Paths
            ##
            # Create a fully-qualified Api resource string.
            #
            # The resource will be in the following format:
            #
            # `projects/{project}/locations/global/apis/{api}`
            #
            # @param project [String]
            # @param api [String]
            #
            # @return [::String]
            def api_path project:, api:
              raise ::ArgumentError, "project cannot contain /" if project.to_s.include? "/"

              "projects/#{project}/locations/global/apis/#{api}"
            end

            ##
            # Create a fully-qualified ApiConfig resource string.
            #
            # The resource will be in the following format:
            #
            # `projects/{project}/locations/global/apis/{api}/configs/{api_config}`
            #
            # @param project [String]
            # @param api [String]
            # @param api_config [String]
            #
            # @return [::String]
            def api_config_path project:, api:, api_config:
              raise ::ArgumentError, "project cannot contain /" if project.to_s.include? "/"
              raise ::ArgumentError, "api cannot contain /" if api.to_s.include? "/"

              "projects/#{project}/locations/global/apis/#{api}/configs/#{api_config}"
            end

            ##
            # Create a fully-qualified Gateway resource string.
            #
            # The resource will be in the following format:
            #
            # `projects/{project}/locations/{location}/gateways/{gateway}`
            #
            # @param project [String]
            # @param location [String]
            # @param gateway [String]
            #
            # @return [::String]
            def gateway_path project:, location:, gateway:
              raise ::ArgumentError, "project cannot contain /" if project.to_s.include? "/"
              raise ::ArgumentError, "location cannot contain /" if location.to_s.include? "/"

              "projects/#{project}/locations/#{location}/gateways/#{gateway}"
            end

            ##
            # Create a fully-qualified Location resource string.
            #
            # The resource will be in the following format:
            #
            # `projects/{project}/locations/{location}`
            #
            # @param project [String]
            # @param location [String]
            #
            # @return [::String]
            def location_path project:, location:
              raise ::ArgumentError, "project cannot contain /" if project.to_s.include? "/"

              "projects/#{project}/locations/#{location}"
            end

            ##
            # Create a fully-qualified ManagedService resource string.
            #
            # The resource will be in the following format:
            #
            # `services/{service}`
            #
            # @param service [String]
            #
            # @return [::String]
            def managed_service_path service:
              "services/#{service}"
            end

            ##
            # Create a fully-qualified Service resource string.
            #
            # The resource will be in the following format:
            #
            # `services/{service}/configs/{config}`
            #
            # @param service [String]
            # @param config [String]
            #
            # @return [::String]
            def service_path service:, config:
              raise ::ArgumentError, "service cannot contain /" if service.to_s.include? "/"

              "services/#{service}/configs/#{config}"
            end

            ##
            # Create a fully-qualified ServiceAccount resource string.
            #
            # The resource will be in the following format:
            #
            # `projects/{project}/serviceAccounts/{service_account}`
            #
            # @param project [String]
            # @param service_account [String]
            #
            # @return [::String]
            def service_account_path project:, service_account:
              raise ::ArgumentError, "project cannot contain /" if project.to_s.include? "/"

              "projects/#{project}/serviceAccounts/#{service_account}"
            end

            extend self
          end
        end
      end
    end
  end
end
