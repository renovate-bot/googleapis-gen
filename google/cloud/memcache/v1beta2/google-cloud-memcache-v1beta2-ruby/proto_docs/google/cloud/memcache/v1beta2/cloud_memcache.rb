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
    module Memcache
      module V1beta2
        # A Memorystore for Memcached instance
        # @!attribute [rw] name
        #   @return [::String]
        #     Required. Unique name of the resource in this scope including project and
        #     location using the form:
        #         `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        #
        #     Note: Memcached instances are managed and addressed at the regional level
        #     so `location_id` here refers to a Google Cloud region; however, users may
        #     choose which zones Memcached nodes should be provisioned in within an
        #     instance. Refer to {::Google::Cloud::Memcache::V1beta2::Instance#zones zones} field for more details.
        # @!attribute [rw] display_name
        #   @return [::String]
        #     User provided name for the instance, which is only used for display
        #     purposes. Cannot be more than 80 characters.
        # @!attribute [rw] labels
        #   @return [::Google::Protobuf::Map{::String => ::String}]
        #     Resource labels to represent user-provided metadata.
        #     Refer to cloud documentation on labels for more details.
        #     https://cloud.google.com/compute/docs/labeling-resources
        # @!attribute [rw] authorized_network
        #   @return [::String]
        #     The full name of the Google Compute Engine
        #     [network](https://cloud.google.com/vpc/docs/vpc) to which the
        #     instance is connected. If left unspecified, the `default` network
        #     will be used.
        # @!attribute [rw] zones
        #   @return [::Array<::String>]
        #     Zones in which Memcached nodes should be provisioned.
        #     Memcached nodes will be equally distributed across these zones. If not
        #     provided, the service will by default create nodes in all zones in the
        #     region for the instance.
        # @!attribute [rw] node_count
        #   @return [::Integer]
        #     Required. Number of nodes in the Memcached instance.
        # @!attribute [rw] node_config
        #   @return [::Google::Cloud::Memcache::V1beta2::Instance::NodeConfig]
        #     Required. Configuration for Memcached nodes.
        # @!attribute [rw] memcache_version
        #   @return [::Google::Cloud::Memcache::V1beta2::MemcacheVersion]
        #     The major version of Memcached software.
        #     If not provided, latest supported version will be used. Currently the
        #     latest supported major version is `MEMCACHE_1_5`.
        #     The minor version will be automatically determined by our system based on
        #     the latest supported minor version.
        # @!attribute [rw] parameters
        #   @return [::Google::Cloud::Memcache::V1beta2::MemcacheParameters]
        #     Optional: User defined parameters to apply to the memcached process
        #     on each node.
        # @!attribute [r] memcache_nodes
        #   @return [::Array<::Google::Cloud::Memcache::V1beta2::Instance::Node>]
        #     Output only. List of Memcached nodes.
        #     Refer to {::Google::Cloud::Memcache::V1beta2::Instance::Node Node} message for more details.
        # @!attribute [r] create_time
        #   @return [::Google::Protobuf::Timestamp]
        #     Output only. The time the instance was created.
        # @!attribute [r] update_time
        #   @return [::Google::Protobuf::Timestamp]
        #     Output only. The time the instance was updated.
        # @!attribute [r] state
        #   @return [::Google::Cloud::Memcache::V1beta2::Instance::State]
        #     Output only. The state of this Memcached instance.
        # @!attribute [r] memcache_full_version
        #   @return [::String]
        #     Output only. The full version of memcached server running on this instance.
        #     System automatically determines the full memcached version for an instance
        #     based on the input MemcacheVersion.
        #     The full version format will be "memcached-1.5.16".
        # @!attribute [rw] instance_messages
        #   @return [::Array<::Google::Cloud::Memcache::V1beta2::Instance::InstanceMessage>]
        #     List of messages that describe the current state of the Memcached instance.
        # @!attribute [r] discovery_endpoint
        #   @return [::String]
        #     Output only. Endpoint for the Discovery API.
        # @!attribute [r] update_available
        #   @return [::Boolean]
        #     Output only. Returns true if there is an update waiting to be applied
        class Instance
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods

          # Configuration for a Memcached Node.
          # @!attribute [rw] cpu_count
          #   @return [::Integer]
          #     Required. Number of cpus per Memcached node.
          # @!attribute [rw] memory_size_mb
          #   @return [::Integer]
          #     Required. Memory size in MiB for each Memcached node.
          class NodeConfig
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # @!attribute [r] node_id
          #   @return [::String]
          #     Output only. Identifier of the Memcached node. The node id does not
          #     include project or location like the Memcached instance name.
          # @!attribute [r] zone
          #   @return [::String]
          #     Output only. Location (GCP Zone) for the Memcached node.
          # @!attribute [r] state
          #   @return [::Google::Cloud::Memcache::V1beta2::Instance::Node::State]
          #     Output only. Current state of the Memcached node.
          # @!attribute [r] host
          #   @return [::String]
          #     Output only. Hostname or IP address of the Memcached node used by the
          #     clients to connect to the Memcached server on this node.
          # @!attribute [r] port
          #   @return [::Integer]
          #     Output only. The port number of the Memcached server on this node.
          # @!attribute [rw] parameters
          #   @return [::Google::Cloud::Memcache::V1beta2::MemcacheParameters]
          #     User defined parameters currently applied to the node.
          # @!attribute [r] update_available
          #   @return [::Boolean]
          #     Output only. Returns true if there is an update waiting to be applied
          class Node
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods

            # Different states of a Memcached node.
            module State
              # Node state is not set.
              STATE_UNSPECIFIED = 0

              # Node is being created.
              CREATING = 1

              # Node has been created and ready to be used.
              READY = 2

              # Node is being deleted.
              DELETING = 3

              # Node is being updated.
              UPDATING = 4
            end
          end

          # @!attribute [rw] code
          #   @return [::Google::Cloud::Memcache::V1beta2::Instance::InstanceMessage::Code]
          #     A code that correspond to one type of user-facing message.
          # @!attribute [rw] message
          #   @return [::String]
          #     Message on memcached instance which will be exposed to users.
          class InstanceMessage
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods

            module Code
              # Message Code not set.
              CODE_UNSPECIFIED = 0

              # Memcached nodes are distributed unevenly.
              ZONE_DISTRIBUTION_UNBALANCED = 1
            end
          end

          # @!attribute [rw] key
          #   @return [::String]
          # @!attribute [rw] value
          #   @return [::String]
          class LabelsEntry
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # Different states of a Memcached instance.
          module State
            # State not set.
            STATE_UNSPECIFIED = 0

            # Memcached instance is being created.
            CREATING = 1

            # Memcached instance has been created and ready to be used.
            READY = 2

            # Memcached instance is being deleted.
            DELETING = 4

            # Memcached instance is going through maintenance, e.g. data plane rollout.
            PERFORMING_MAINTENANCE = 5
          end
        end

        # Request for {::Google::Cloud::Memcache::V1beta2::CloudMemcache::Client#list_instances ListInstances}.
        # @!attribute [rw] parent
        #   @return [::String]
        #     Required. The resource name of the instance location using the form:
        #         `projects/{project_id}/locations/{location_id}`
        #     where `location_id` refers to a GCP region
        # @!attribute [rw] page_size
        #   @return [::Integer]
        #     The maximum number of items to return.
        #
        #     If not specified, a default value of 1000 will be used by the service.
        #     Regardless of the `page_size` value, the response may include a partial
        #     list and a caller should only rely on response's
        #     {::Google::Cloud::Memcache::V1beta2::ListInstancesResponse#next_page_token `next_page_token`}
        #     to determine if there are more instances left to be queried.
        # @!attribute [rw] page_token
        #   @return [::String]
        #     The `next_page_token` value returned from a previous List request, if any.
        # @!attribute [rw] filter
        #   @return [::String]
        #     List filter. For example, exclude all Memcached instances with name as
        #     my-instance by specifying `"name != my-instance"`.
        # @!attribute [rw] order_by
        #   @return [::String]
        #     Sort results. Supported values are "name", "name desc" or "" (unsorted).
        class ListInstancesRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Response for {::Google::Cloud::Memcache::V1beta2::CloudMemcache::Client#list_instances ListInstances}.
        # @!attribute [rw] resources
        #   @return [::Array<::Google::Cloud::Memcache::V1beta2::Instance>]
        #     A list of Memcached instances in the project in the specified location,
        #     or across all locations.
        #
        #     If the `location_id` in the parent field of the request is "-", all regions
        #     available to the project are queried, and the results aggregated.
        # @!attribute [rw] next_page_token
        #   @return [::String]
        #     Token to retrieve the next page of results, or empty if there are no more
        #     results in the list.
        # @!attribute [rw] unreachable
        #   @return [::Array<::String>]
        #     Locations that could not be reached.
        class ListInstancesResponse
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Request for {::Google::Cloud::Memcache::V1beta2::CloudMemcache::Client#get_instance GetInstance}.
        # @!attribute [rw] name
        #   @return [::String]
        #     Required. Memcached instance resource name in the format:
        #         `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        #     where `location_id` refers to a GCP region
        class GetInstanceRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Request for {::Google::Cloud::Memcache::V1beta2::CloudMemcache::Client#create_instance CreateInstance}.
        # @!attribute [rw] parent
        #   @return [::String]
        #     Required. The resource name of the instance location using the form:
        #         `projects/{project_id}/locations/{location_id}`
        #     where `location_id` refers to a GCP region
        # @!attribute [rw] instance_id
        #   @return [::String]
        #     Required. The logical name of the Memcached instance in the user
        #     project with the following restrictions:
        #
        #     * Must contain only lowercase letters, numbers, and hyphens.
        #     * Must start with a letter.
        #     * Must be between 1-40 characters.
        #     * Must end with a number or a letter.
        #     * Must be unique within the user project / location.
        #
        #     If any of the above are not met, the API raises an invalid argument error.
        # @!attribute [rw] resource
        #   @return [::Google::Cloud::Memcache::V1beta2::Instance]
        #     Required. A Memcached [Instance] resource
        class CreateInstanceRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Request for {::Google::Cloud::Memcache::V1beta2::CloudMemcache::Client#update_instance UpdateInstance}.
        # @!attribute [rw] update_mask
        #   @return [::Google::Protobuf::FieldMask]
        #     Required. Mask of fields to update.
        #      *  `displayName`
        # @!attribute [rw] resource
        #   @return [::Google::Cloud::Memcache::V1beta2::Instance]
        #     Required. A Memcached [Instance] resource.
        #     Only fields specified in update_mask are updated.
        class UpdateInstanceRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Request for {::Google::Cloud::Memcache::V1beta2::CloudMemcache::Client#delete_instance DeleteInstance}.
        # @!attribute [rw] name
        #   @return [::String]
        #     Required. Memcached instance resource name in the format:
        #         `projects/{project_id}/locations/{location_id}/instances/{instance_id}`
        #     where `location_id` refers to a GCP region
        class DeleteInstanceRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Request for {::Google::Cloud::Memcache::V1beta2::CloudMemcache::Client#apply_parameters ApplyParameters}.
        # @!attribute [rw] name
        #   @return [::String]
        #     Required. Resource name of the Memcached instance for which parameter group updates
        #     should be applied.
        # @!attribute [rw] node_ids
        #   @return [::Array<::String>]
        #     Nodes to which the instance-level parameter group is applied.
        # @!attribute [rw] apply_all
        #   @return [::Boolean]
        #     Whether to apply instance-level parameter group to all nodes. If set to
        #     true, users are restricted from specifying individual nodes, and
        #     `ApplyParameters` updates all nodes within the instance.
        class ApplyParametersRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Request for {::Google::Cloud::Memcache::V1beta2::CloudMemcache::Client#update_parameters UpdateParameters}.
        # @!attribute [rw] name
        #   @return [::String]
        #     Required. Resource name of the Memcached instance for which the parameters should be
        #     updated.
        # @!attribute [rw] update_mask
        #   @return [::Google::Protobuf::FieldMask]
        #     Required. Mask of fields to update.
        # @!attribute [rw] parameters
        #   @return [::Google::Cloud::Memcache::V1beta2::MemcacheParameters]
        #     The parameters to apply to the instance.
        class UpdateParametersRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Request for {::Google::Cloud::Memcache::V1beta2::CloudMemcache::Client#apply_software_update ApplySoftwareUpdate}.
        # @!attribute [rw] instance
        #   @return [::String]
        #     Required. Resource name of the Memcached instance for which software update should be
        #     applied.
        # @!attribute [rw] node_ids
        #   @return [::Array<::String>]
        #     Nodes to which we should apply the update to. Note all the selected nodes
        #     are updated in parallel.
        # @!attribute [rw] apply_all
        #   @return [::Boolean]
        #     Whether to apply the update to all nodes. If set to
        #     true, will explicitly restrict users from specifying any nodes, and apply
        #     software update to all nodes (where applicable) within the instance.
        class ApplySoftwareUpdateRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # The unique ID associated with this set of parameters. Users
        # can use this id to determine if the parameters associated with the instance
        # differ from the parameters associated with the nodes. A discrepancy between
        # parameter ids can inform users that they may need to take action to apply
        # parameters on nodes.
        # @!attribute [r] id
        #   @return [::String]
        #     Output only.
        # @!attribute [rw] params
        #   @return [::Google::Protobuf::Map{::String => ::String}]
        #     User defined set of parameters to use in the memcached process.
        class MemcacheParameters
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods

          # @!attribute [rw] key
          #   @return [::String]
          # @!attribute [rw] value
          #   @return [::String]
          class ParamsEntry
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end
        end

        # Represents the metadata of a long-running operation.
        # @!attribute [r] create_time
        #   @return [::Google::Protobuf::Timestamp]
        #     Output only. Time when the operation was created.
        # @!attribute [r] end_time
        #   @return [::Google::Protobuf::Timestamp]
        #     Output only. Time when the operation finished running.
        # @!attribute [r] target
        #   @return [::String]
        #     Output only. Server-defined resource path for the target of the operation.
        # @!attribute [r] verb
        #   @return [::String]
        #     Output only. Name of the verb executed by the operation.
        # @!attribute [r] status_detail
        #   @return [::String]
        #     Output only. Human-readable status of the operation, if any.
        # @!attribute [r] cancel_requested
        #   @return [::Boolean]
        #     Output only. Identifies whether the user has requested cancellation
        #     of the operation. Operations that have successfully been cancelled
        #     have [Operation.error][] value with a {::Google::Rpc::Status#code google.rpc.Status.code} of 1,
        #     corresponding to `Code.CANCELLED`.
        # @!attribute [r] api_version
        #   @return [::String]
        #     Output only. API version used to start the operation.
        class OperationMetadata
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Metadata for the given [google.cloud.location.Location][google.cloud.location.Location].
        # @!attribute [r] available_zones
        #   @return [::Google::Protobuf::Map{::String => ::Google::Cloud::Memcache::V1beta2::ZoneMetadata}]
        #     Output only. The set of available zones in the location. The map is keyed
        #     by the lowercase ID of each zone, as defined by GCE. These keys can be
        #     specified in the `zones` field when creating a Memcached instance.
        class LocationMetadata
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods

          # @!attribute [rw] key
          #   @return [::String]
          # @!attribute [rw] value
          #   @return [::Google::Cloud::Memcache::V1beta2::ZoneMetadata]
          class AvailableZonesEntry
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end
        end

        class ZoneMetadata
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Memcached versions supported by our service.
        module MemcacheVersion
          MEMCACHE_VERSION_UNSPECIFIED = 0

          # Memcached 1.5 version.
          MEMCACHE_1_5 = 1
        end
      end
    end
  end
end
