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
    module Monitoring
      module V3
        module GroupService
          # Path helper methods for the GroupService API.
          module Paths
            ##
            # Create a fully-qualified Folder resource string.
            #
            # The resource will be in the following format:
            #
            # `folders/{folder}`
            #
            # @param folder [String]
            #
            # @return [::String]
            def folder_path folder:
              "folders/#{folder}"
            end

            ##
            # Create a fully-qualified Group resource string.
            #
            # @overload group_path(project:, group:)
            #   The resource will be in the following format:
            #
            #   `projects/{project}/groups/{group}`
            #
            #   @param project [String]
            #   @param group [String]
            #
            # @overload group_path(organization:, group:)
            #   The resource will be in the following format:
            #
            #   `organizations/{organization}/groups/{group}`
            #
            #   @param organization [String]
            #   @param group [String]
            #
            # @overload group_path(folder:, group:)
            #   The resource will be in the following format:
            #
            #   `folders/{folder}/groups/{group}`
            #
            #   @param folder [String]
            #   @param group [String]
            #
            # @return [::String]
            def group_path **args
              resources = {
                "group:project" => (proc do |project:, group:|
                  raise ::ArgumentError, "project cannot contain /" if project.to_s.include? "/"

                  "projects/#{project}/groups/#{group}"
                end),
                "group:organization" => (proc do |organization:, group:|
                  raise ::ArgumentError, "organization cannot contain /" if organization.to_s.include? "/"

                  "organizations/#{organization}/groups/#{group}"
                end),
                "folder:group" => (proc do |folder:, group:|
                  raise ::ArgumentError, "folder cannot contain /" if folder.to_s.include? "/"

                  "folders/#{folder}/groups/#{group}"
                end)
              }

              resource = resources[args.keys.sort.join(":")]
              raise ::ArgumentError, "no resource found for values #{args.keys}" if resource.nil?
              resource.call(**args)
            end

            ##
            # Create a fully-qualified Organization resource string.
            #
            # The resource will be in the following format:
            #
            # `organizations/{organization}`
            #
            # @param organization [String]
            #
            # @return [::String]
            def organization_path organization:
              "organizations/#{organization}"
            end

            ##
            # Create a fully-qualified Project resource string.
            #
            # The resource will be in the following format:
            #
            # `projects/{project}`
            #
            # @param project [String]
            #
            # @return [::String]
            def project_path project:
              "projects/#{project}"
            end

            ##
            # Create a fully-qualified Workspace resource string.
            #
            # @overload workspace_path(project:)
            #   The resource will be in the following format:
            #
            #   `projects/{project}`
            #
            #   @param project [String]
            #
            # @overload workspace_path(workspace:)
            #   The resource will be in the following format:
            #
            #   `workspaces/{workspace}`
            #
            #   @param workspace [String]
            #
            # @return [::String]
            def workspace_path **args
              resources = {
                "project" => (proc do |project:|
                  "projects/#{project}"
                end),
                "workspace" => (proc do |workspace:|
                  "workspaces/#{workspace}"
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
