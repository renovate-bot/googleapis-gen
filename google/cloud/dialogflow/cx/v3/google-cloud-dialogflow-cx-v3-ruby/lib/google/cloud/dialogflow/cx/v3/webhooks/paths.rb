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
    module Dialogflow
      module CX
        module V3
          module Webhooks
            # Path helper methods for the Webhooks API.
            module Paths
              ##
              # Create a fully-qualified Agent resource string.
              #
              # The resource will be in the following format:
              #
              # `projects/{project}/locations/{location}/agents/{agent}`
              #
              # @param project [String]
              # @param location [String]
              # @param agent [String]
              #
              # @return [::String]
              def agent_path project:, location:, agent:
                raise ::ArgumentError, "project cannot contain /" if project.to_s.include? "/"
                raise ::ArgumentError, "location cannot contain /" if location.to_s.include? "/"

                "projects/#{project}/locations/#{location}/agents/#{agent}"
              end

              ##
              # Create a fully-qualified Service resource string.
              #
              # The resource will be in the following format:
              #
              # `projects/{project}/locations/{location}/namespaces/{namespace}/services/{service}`
              #
              # @param project [String]
              # @param location [String]
              # @param namespace [String]
              # @param service [String]
              #
              # @return [::String]
              def service_path project:, location:, namespace:, service:
                raise ::ArgumentError, "project cannot contain /" if project.to_s.include? "/"
                raise ::ArgumentError, "location cannot contain /" if location.to_s.include? "/"
                raise ::ArgumentError, "namespace cannot contain /" if namespace.to_s.include? "/"

                "projects/#{project}/locations/#{location}/namespaces/#{namespace}/services/#{service}"
              end

              ##
              # Create a fully-qualified Webhook resource string.
              #
              # The resource will be in the following format:
              #
              # `projects/{project}/locations/{location}/agents/{agent}/webhooks/{webhook}`
              #
              # @param project [String]
              # @param location [String]
              # @param agent [String]
              # @param webhook [String]
              #
              # @return [::String]
              def webhook_path project:, location:, agent:, webhook:
                raise ::ArgumentError, "project cannot contain /" if project.to_s.include? "/"
                raise ::ArgumentError, "location cannot contain /" if location.to_s.include? "/"
                raise ::ArgumentError, "agent cannot contain /" if agent.to_s.include? "/"

                "projects/#{project}/locations/#{location}/agents/#{agent}/webhooks/#{webhook}"
              end

              extend self
            end
          end
        end
      end
    end
  end
end
