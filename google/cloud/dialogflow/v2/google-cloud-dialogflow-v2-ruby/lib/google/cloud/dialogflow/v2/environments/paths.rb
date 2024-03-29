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
      module V2
        module Environments
          # Path helper methods for the Environments API.
          module Paths
            ##
            # Create a fully-qualified Agent resource string.
            #
            # @overload agent_path(project:)
            #   The resource will be in the following format:
            #
            #   `projects/{project}/agent`
            #
            #   @param project [String]
            #
            # @overload agent_path(project:, location:)
            #   The resource will be in the following format:
            #
            #   `projects/{project}/locations/{location}/agent`
            #
            #   @param project [String]
            #   @param location [String]
            #
            # @return [::String]
            def agent_path **args
              resources = {
                "project" => (proc do |project:|
                  "projects/#{project}/agent"
                end),
                "location:project" => (proc do |project:, location:|
                  raise ::ArgumentError, "project cannot contain /" if project.to_s.include? "/"

                  "projects/#{project}/locations/#{location}/agent"
                end)
              }

              resource = resources[args.keys.sort.join(":")]
              raise ::ArgumentError, "no resource found for values #{args.keys}" if resource.nil?
              resource.call(**args)
            end

            ##
            # Create a fully-qualified Environment resource string.
            #
            # @overload environment_path(project:, environment:)
            #   The resource will be in the following format:
            #
            #   `projects/{project}/agent/environments/{environment}`
            #
            #   @param project [String]
            #   @param environment [String]
            #
            # @overload environment_path(project:, location:, environment:)
            #   The resource will be in the following format:
            #
            #   `projects/{project}/locations/{location}/agent/environments/{environment}`
            #
            #   @param project [String]
            #   @param location [String]
            #   @param environment [String]
            #
            # @return [::String]
            def environment_path **args
              resources = {
                "environment:project" => (proc do |project:, environment:|
                  raise ::ArgumentError, "project cannot contain /" if project.to_s.include? "/"

                  "projects/#{project}/agent/environments/#{environment}"
                end),
                "environment:location:project" => (proc do |project:, location:, environment:|
                  raise ::ArgumentError, "project cannot contain /" if project.to_s.include? "/"
                  raise ::ArgumentError, "location cannot contain /" if location.to_s.include? "/"

                  "projects/#{project}/locations/#{location}/agent/environments/#{environment}"
                end)
              }

              resource = resources[args.keys.sort.join(":")]
              raise ::ArgumentError, "no resource found for values #{args.keys}" if resource.nil?
              resource.call(**args)
            end

            ##
            # Create a fully-qualified Fulfillment resource string.
            #
            # @overload fulfillment_path(project:)
            #   The resource will be in the following format:
            #
            #   `projects/{project}/agent/fulfillment`
            #
            #   @param project [String]
            #
            # @overload fulfillment_path(project:, location:)
            #   The resource will be in the following format:
            #
            #   `projects/{project}/locations/{location}/agent/fulfillment`
            #
            #   @param project [String]
            #   @param location [String]
            #
            # @return [::String]
            def fulfillment_path **args
              resources = {
                "project" => (proc do |project:|
                  "projects/#{project}/agent/fulfillment"
                end),
                "location:project" => (proc do |project:, location:|
                  raise ::ArgumentError, "project cannot contain /" if project.to_s.include? "/"

                  "projects/#{project}/locations/#{location}/agent/fulfillment"
                end)
              }

              resource = resources[args.keys.sort.join(":")]
              raise ::ArgumentError, "no resource found for values #{args.keys}" if resource.nil?
              resource.call(**args)
            end

            ##
            # Create a fully-qualified Version resource string.
            #
            # @overload version_path(project:, version:)
            #   The resource will be in the following format:
            #
            #   `projects/{project}/agent/versions/{version}`
            #
            #   @param project [String]
            #   @param version [String]
            #
            # @overload version_path(project:, location:, version:)
            #   The resource will be in the following format:
            #
            #   `projects/{project}/locations/{location}/agent/versions/{version}`
            #
            #   @param project [String]
            #   @param location [String]
            #   @param version [String]
            #
            # @return [::String]
            def version_path **args
              resources = {
                "project:version" => (proc do |project:, version:|
                  raise ::ArgumentError, "project cannot contain /" if project.to_s.include? "/"

                  "projects/#{project}/agent/versions/#{version}"
                end),
                "location:project:version" => (proc do |project:, location:, version:|
                  raise ::ArgumentError, "project cannot contain /" if project.to_s.include? "/"
                  raise ::ArgumentError, "location cannot contain /" if location.to_s.include? "/"

                  "projects/#{project}/locations/#{location}/agent/versions/#{version}"
                end)
              }

              resource = resources[args.keys.sort.join(":")]
              raise ::ArgumentError, "no resource found for values #{args.keys}" if resource.nil?
              resource.call(**args)
            end

            extend self
          end
        end
      end
    end
  end
end
