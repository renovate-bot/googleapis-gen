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
    module SecurityCenter
      module Settings
        module V1beta1
          module SecurityCenterSettingsService
            # Path helper methods for the SecurityCenterSettingsService API.
            module Paths
              ##
              # Create a fully-qualified ComponentSettings resource string.
              #
              # @overload component_settings_path(organization:, component:)
              #   The resource will be in the following format:
              #
              #   `organizations/{organization}/components/{component}/settings`
              #
              #   @param organization [String]
              #   @param component [String]
              #
              # @overload component_settings_path(folder:, component:)
              #   The resource will be in the following format:
              #
              #   `folders/{folder}/components/{component}/settings`
              #
              #   @param folder [String]
              #   @param component [String]
              #
              # @overload component_settings_path(project:, component:)
              #   The resource will be in the following format:
              #
              #   `projects/{project}/components/{component}/settings`
              #
              #   @param project [String]
              #   @param component [String]
              #
              # @overload component_settings_path(project:, location:, cluster:, component:)
              #   The resource will be in the following format:
              #
              #   `projects/{project}/locations/{location}/clusters/{cluster}/components/{component}/settings`
              #
              #   @param project [String]
              #   @param location [String]
              #   @param cluster [String]
              #   @param component [String]
              #
              # @overload component_settings_path(project:, region:, cluster:, component:)
              #   The resource will be in the following format:
              #
              #   `projects/{project}/regions/{region}/clusters/{cluster}/components/{component}/settings`
              #
              #   @param project [String]
              #   @param region [String]
              #   @param cluster [String]
              #   @param component [String]
              #
              # @overload component_settings_path(project:, zone:, cluster:, component:)
              #   The resource will be in the following format:
              #
              #   `projects/{project}/zones/{zone}/clusters/{cluster}/components/{component}/settings`
              #
              #   @param project [String]
              #   @param zone [String]
              #   @param cluster [String]
              #   @param component [String]
              #
              # @return [::String]
              def component_settings_path **args
                resources = {
                  "component:organization" => (proc do |organization:, component:|
                    raise ::ArgumentError, "organization cannot contain /" if organization.to_s.include? "/"

                    "organizations/#{organization}/components/#{component}/settings"
                  end),
                  "component:folder" => (proc do |folder:, component:|
                    raise ::ArgumentError, "folder cannot contain /" if folder.to_s.include? "/"

                    "folders/#{folder}/components/#{component}/settings"
                  end),
                  "component:project" => (proc do |project:, component:|
                    raise ::ArgumentError, "project cannot contain /" if project.to_s.include? "/"

                    "projects/#{project}/components/#{component}/settings"
                  end),
                  "cluster:component:location:project" => (proc do |project:, location:, cluster:, component:|
                    raise ::ArgumentError, "project cannot contain /" if project.to_s.include? "/"
                    raise ::ArgumentError, "location cannot contain /" if location.to_s.include? "/"
                    raise ::ArgumentError, "cluster cannot contain /" if cluster.to_s.include? "/"

                    "projects/#{project}/locations/#{location}/clusters/#{cluster}/components/#{component}/settings"
                  end),
                  "cluster:component:project:region" => (proc do |project:, region:, cluster:, component:|
                    raise ::ArgumentError, "project cannot contain /" if project.to_s.include? "/"
                    raise ::ArgumentError, "region cannot contain /" if region.to_s.include? "/"
                    raise ::ArgumentError, "cluster cannot contain /" if cluster.to_s.include? "/"

                    "projects/#{project}/regions/#{region}/clusters/#{cluster}/components/#{component}/settings"
                  end),
                  "cluster:component:project:zone" => (proc do |project:, zone:, cluster:, component:|
                    raise ::ArgumentError, "project cannot contain /" if project.to_s.include? "/"
                    raise ::ArgumentError, "zone cannot contain /" if zone.to_s.include? "/"
                    raise ::ArgumentError, "cluster cannot contain /" if cluster.to_s.include? "/"

                    "projects/#{project}/zones/#{zone}/clusters/#{cluster}/components/#{component}/settings"
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
              # Create a fully-qualified ServiceAccount resource string.
              #
              # The resource will be in the following format:
              #
              # `organizations/{organization}/serviceAccount`
              #
              # @param organization [String]
              #
              # @return [::String]
              def service_account_path organization:
                "organizations/#{organization}/serviceAccount"
              end

              ##
              # Create a fully-qualified Settings resource string.
              #
              # @overload settings_path(organization:)
              #   The resource will be in the following format:
              #
              #   `organizations/{organization}/settings`
              #
              #   @param organization [String]
              #
              # @overload settings_path(folder:)
              #   The resource will be in the following format:
              #
              #   `folders/{folder}/settings`
              #
              #   @param folder [String]
              #
              # @overload settings_path(project:)
              #   The resource will be in the following format:
              #
              #   `projects/{project}/settings`
              #
              #   @param project [String]
              #
              # @overload settings_path(project:, location:, cluster:)
              #   The resource will be in the following format:
              #
              #   `projects/{project}/locations/{location}/clusters/{cluster}/settings`
              #
              #   @param project [String]
              #   @param location [String]
              #   @param cluster [String]
              #
              # @overload settings_path(project:, region:, cluster:)
              #   The resource will be in the following format:
              #
              #   `projects/{project}/regions/{region}/clusters/{cluster}/settings`
              #
              #   @param project [String]
              #   @param region [String]
              #   @param cluster [String]
              #
              # @overload settings_path(project:, zone:, cluster:)
              #   The resource will be in the following format:
              #
              #   `projects/{project}/zones/{zone}/clusters/{cluster}/settings`
              #
              #   @param project [String]
              #   @param zone [String]
              #   @param cluster [String]
              #
              # @return [::String]
              def settings_path **args
                resources = {
                  "organization" => (proc do |organization:|
                    "organizations/#{organization}/settings"
                  end),
                  "folder" => (proc do |folder:|
                    "folders/#{folder}/settings"
                  end),
                  "project" => (proc do |project:|
                    "projects/#{project}/settings"
                  end),
                  "cluster:location:project" => (proc do |project:, location:, cluster:|
                    raise ::ArgumentError, "project cannot contain /" if project.to_s.include? "/"
                    raise ::ArgumentError, "location cannot contain /" if location.to_s.include? "/"

                    "projects/#{project}/locations/#{location}/clusters/#{cluster}/settings"
                  end),
                  "cluster:project:region" => (proc do |project:, region:, cluster:|
                    raise ::ArgumentError, "project cannot contain /" if project.to_s.include? "/"
                    raise ::ArgumentError, "region cannot contain /" if region.to_s.include? "/"

                    "projects/#{project}/regions/#{region}/clusters/#{cluster}/settings"
                  end),
                  "cluster:project:zone" => (proc do |project:, zone:, cluster:|
                    raise ::ArgumentError, "project cannot contain /" if project.to_s.include? "/"
                    raise ::ArgumentError, "zone cannot contain /" if zone.to_s.include? "/"

                    "projects/#{project}/zones/#{zone}/clusters/#{cluster}/settings"
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
end
