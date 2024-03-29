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
    module Dataproc
      module V1
        # Describes an autoscaling policy for Dataproc cluster autoscaler.
        # @!attribute [rw] id
        #   @return [::String]
        #     Required. The policy id.
        #
        #     The id must contain only letters (a-z, A-Z), numbers (0-9),
        #     underscores (_), and hyphens (-). Cannot begin or end with underscore
        #     or hyphen. Must consist of between 3 and 50 characters.
        # @!attribute [r] name
        #   @return [::String]
        #     Output only. The "resource name" of the autoscaling policy, as described
        #     in https://cloud.google.com/apis/design/resource_names.
        #
        #     * For `projects.regions.autoscalingPolicies`, the resource name of the
        #       policy has the following format:
        #       `projects/{project_id}/regions/{region}/autoscalingPolicies/{policy_id}`
        #
        #     * For `projects.locations.autoscalingPolicies`, the resource name of the
        #       policy has the following format:
        #       `projects/{project_id}/locations/{location}/autoscalingPolicies/{policy_id}`
        # @!attribute [rw] basic_algorithm
        #   @return [::Google::Cloud::Dataproc::V1::BasicAutoscalingAlgorithm]
        # @!attribute [rw] worker_config
        #   @return [::Google::Cloud::Dataproc::V1::InstanceGroupAutoscalingPolicyConfig]
        #     Required. Describes how the autoscaler will operate for primary workers.
        # @!attribute [rw] secondary_worker_config
        #   @return [::Google::Cloud::Dataproc::V1::InstanceGroupAutoscalingPolicyConfig]
        #     Optional. Describes how the autoscaler will operate for secondary workers.
        # @!attribute [rw] labels
        #   @return [::Google::Protobuf::Map{::String => ::String}]
        #     Optional. The labels to associate with this autoscaling policy.
        #     Label **keys** must contain 1 to 63 characters, and must conform to
        #     [RFC 1035](https://www.ietf.org/rfc/rfc1035.txt).
        #     Label **values** may be empty, but, if present, must contain 1 to 63
        #     characters, and must conform to [RFC
        #     1035](https://www.ietf.org/rfc/rfc1035.txt). No more than 32 labels can be
        #     associated with an autoscaling policy.
        class AutoscalingPolicy
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods

          # @!attribute [rw] key
          #   @return [::String]
          # @!attribute [rw] value
          #   @return [::String]
          class LabelsEntry
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end
        end

        # Basic algorithm for autoscaling.
        # @!attribute [rw] yarn_config
        #   @return [::Google::Cloud::Dataproc::V1::BasicYarnAutoscalingConfig]
        #     Required. YARN autoscaling configuration.
        # @!attribute [rw] cooldown_period
        #   @return [::Google::Protobuf::Duration]
        #     Optional. Duration between scaling events. A scaling period starts after
        #     the update operation from the previous event has completed.
        #
        #     Bounds: [2m, 1d]. Default: 2m.
        class BasicAutoscalingAlgorithm
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Basic autoscaling configurations for YARN.
        # @!attribute [rw] graceful_decommission_timeout
        #   @return [::Google::Protobuf::Duration]
        #     Required. Timeout for YARN graceful decommissioning of Node Managers.
        #     Specifies the duration to wait for jobs to complete before forcefully
        #     removing workers (and potentially interrupting jobs). Only applicable to
        #     downscaling operations.
        #
        #     Bounds: [0s, 1d].
        # @!attribute [rw] scale_up_factor
        #   @return [::Float]
        #     Required. Fraction of average YARN pending memory in the last cooldown period
        #     for which to add workers. A scale-up factor of 1.0 will result in scaling
        #     up so that there is no pending memory remaining after the update (more
        #     aggressive scaling). A scale-up factor closer to 0 will result in a smaller
        #     magnitude of scaling up (less aggressive scaling).
        #     See [How autoscaling
        #     works](https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/autoscaling#how_autoscaling_works)
        #     for more information.
        #
        #     Bounds: [0.0, 1.0].
        # @!attribute [rw] scale_down_factor
        #   @return [::Float]
        #     Required. Fraction of average YARN pending memory in the last cooldown period
        #     for which to remove workers. A scale-down factor of 1 will result in
        #     scaling down so that there is no available memory remaining after the
        #     update (more aggressive scaling). A scale-down factor of 0 disables
        #     removing workers, which can be beneficial for autoscaling a single job.
        #     See [How autoscaling
        #     works](https://cloud.google.com/dataproc/docs/concepts/configuring-clusters/autoscaling#how_autoscaling_works)
        #     for more information.
        #
        #     Bounds: [0.0, 1.0].
        # @!attribute [rw] scale_up_min_worker_fraction
        #   @return [::Float]
        #     Optional. Minimum scale-up threshold as a fraction of total cluster size
        #     before scaling occurs. For example, in a 20-worker cluster, a threshold of
        #     0.1 means the autoscaler must recommend at least a 2-worker scale-up for
        #     the cluster to scale. A threshold of 0 means the autoscaler will scale up
        #     on any recommended change.
        #
        #     Bounds: [0.0, 1.0]. Default: 0.0.
        # @!attribute [rw] scale_down_min_worker_fraction
        #   @return [::Float]
        #     Optional. Minimum scale-down threshold as a fraction of total cluster size
        #     before scaling occurs. For example, in a 20-worker cluster, a threshold of
        #     0.1 means the autoscaler must recommend at least a 2 worker scale-down for
        #     the cluster to scale. A threshold of 0 means the autoscaler will scale down
        #     on any recommended change.
        #
        #     Bounds: [0.0, 1.0]. Default: 0.0.
        class BasicYarnAutoscalingConfig
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Configuration for the size bounds of an instance group, including its
        # proportional size to other groups.
        # @!attribute [rw] min_instances
        #   @return [::Integer]
        #     Optional. Minimum number of instances for this group.
        #
        #     Primary workers - Bounds: [2, max_instances]. Default: 2.
        #     Secondary workers - Bounds: [0, max_instances]. Default: 0.
        # @!attribute [rw] max_instances
        #   @return [::Integer]
        #     Required. Maximum number of instances for this group. Required for primary
        #     workers. Note that by default, clusters will not use secondary workers.
        #     Required for secondary workers if the minimum secondary instances is set.
        #
        #     Primary workers - Bounds: [min_instances, ).
        #     Secondary workers - Bounds: [min_instances, ). Default: 0.
        # @!attribute [rw] weight
        #   @return [::Integer]
        #     Optional. Weight for the instance group, which is used to determine the
        #     fraction of total workers in the cluster from this instance group.
        #     For example, if primary workers have weight 2, and secondary workers have
        #     weight 1, the cluster will have approximately 2 primary workers for each
        #     secondary worker.
        #
        #     The cluster may not reach the specified balance if constrained
        #     by min/max bounds or other autoscaling settings. For example, if
        #     `max_instances` for secondary workers is 0, then only primary workers will
        #     be added. The cluster can also be out of balance when created.
        #
        #     If weight is not set on any instance group, the cluster will default to
        #     equal weight for all groups: the cluster will attempt to maintain an equal
        #     number of workers in each group within the configured size bounds for each
        #     group. If weight is set for one group only, the cluster will default to
        #     zero weight on the unset group. For example if weight is set only on
        #     primary workers, the cluster will use primary workers only and no
        #     secondary workers.
        class InstanceGroupAutoscalingPolicyConfig
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # A request to create an autoscaling policy.
        # @!attribute [rw] parent
        #   @return [::String]
        #     Required. The "resource name" of the region or location, as described
        #     in https://cloud.google.com/apis/design/resource_names.
        #
        #     * For `projects.regions.autoscalingPolicies.create`, the resource name
        #       of the region has the following format:
        #       `projects/{project_id}/regions/{region}`
        #
        #     * For `projects.locations.autoscalingPolicies.create`, the resource name
        #       of the location has the following format:
        #       `projects/{project_id}/locations/{location}`
        # @!attribute [rw] policy
        #   @return [::Google::Cloud::Dataproc::V1::AutoscalingPolicy]
        #     Required. The autoscaling policy to create.
        class CreateAutoscalingPolicyRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # A request to fetch an autoscaling policy.
        # @!attribute [rw] name
        #   @return [::String]
        #     Required. The "resource name" of the autoscaling policy, as described
        #     in https://cloud.google.com/apis/design/resource_names.
        #
        #     * For `projects.regions.autoscalingPolicies.get`, the resource name
        #       of the policy has the following format:
        #       `projects/{project_id}/regions/{region}/autoscalingPolicies/{policy_id}`
        #
        #     * For `projects.locations.autoscalingPolicies.get`, the resource name
        #       of the policy has the following format:
        #       `projects/{project_id}/locations/{location}/autoscalingPolicies/{policy_id}`
        class GetAutoscalingPolicyRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # A request to update an autoscaling policy.
        # @!attribute [rw] policy
        #   @return [::Google::Cloud::Dataproc::V1::AutoscalingPolicy]
        #     Required. The updated autoscaling policy.
        class UpdateAutoscalingPolicyRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # A request to delete an autoscaling policy.
        #
        # Autoscaling policies in use by one or more clusters will not be deleted.
        # @!attribute [rw] name
        #   @return [::String]
        #     Required. The "resource name" of the autoscaling policy, as described
        #     in https://cloud.google.com/apis/design/resource_names.
        #
        #     * For `projects.regions.autoscalingPolicies.delete`, the resource name
        #       of the policy has the following format:
        #       `projects/{project_id}/regions/{region}/autoscalingPolicies/{policy_id}`
        #
        #     * For `projects.locations.autoscalingPolicies.delete`, the resource name
        #       of the policy has the following format:
        #       `projects/{project_id}/locations/{location}/autoscalingPolicies/{policy_id}`
        class DeleteAutoscalingPolicyRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # A request to list autoscaling policies in a project.
        # @!attribute [rw] parent
        #   @return [::String]
        #     Required. The "resource name" of the region or location, as described
        #     in https://cloud.google.com/apis/design/resource_names.
        #
        #     * For `projects.regions.autoscalingPolicies.list`, the resource name
        #       of the region has the following format:
        #       `projects/{project_id}/regions/{region}`
        #
        #     * For `projects.locations.autoscalingPolicies.list`, the resource name
        #       of the location has the following format:
        #       `projects/{project_id}/locations/{location}`
        # @!attribute [rw] page_size
        #   @return [::Integer]
        #     Optional. The maximum number of results to return in each response.
        #     Must be less than or equal to 1000. Defaults to 100.
        # @!attribute [rw] page_token
        #   @return [::String]
        #     Optional. The page token, returned by a previous call, to request the
        #     next page of results.
        class ListAutoscalingPoliciesRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # A response to a request to list autoscaling policies in a project.
        # @!attribute [r] policies
        #   @return [::Array<::Google::Cloud::Dataproc::V1::AutoscalingPolicy>]
        #     Output only. Autoscaling policies list.
        # @!attribute [r] next_page_token
        #   @return [::String]
        #     Output only. This token is included in the response if there are more
        #     results to fetch.
        class ListAutoscalingPoliciesResponse
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end
      end
    end
  end
end
