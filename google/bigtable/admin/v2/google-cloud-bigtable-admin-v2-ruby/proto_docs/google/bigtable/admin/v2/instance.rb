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
    module Bigtable
      module Admin
        module V2
          # A collection of Bigtable {::Google::Cloud::Bigtable::Admin::V2::Table Tables} and
          # the resources that serve them.
          # All tables in an instance are served from all
          # {::Google::Cloud::Bigtable::Admin::V2::Cluster Clusters} in the instance.
          # @!attribute [r] name
          #   @return [::String]
          #     The unique name of the instance. Values are of the form
          #     `projects/{project}/instances/[a-z][a-z0-9\\-]+[a-z0-9]`.
          # @!attribute [rw] display_name
          #   @return [::String]
          #     Required. The descriptive name for this instance as it appears in UIs.
          #     Can be changed at any time, but should be kept globally unique
          #     to avoid confusion.
          # @!attribute [rw] state
          #   @return [::Google::Cloud::Bigtable::Admin::V2::Instance::State]
          #     (`OutputOnly`)
          #     The current state of the instance.
          # @!attribute [rw] type
          #   @return [::Google::Cloud::Bigtable::Admin::V2::Instance::Type]
          #     The type of the instance. Defaults to `PRODUCTION`.
          # @!attribute [rw] labels
          #   @return [::Google::Protobuf::Map{::String => ::String}]
          #     Labels are a flexible and lightweight mechanism for organizing cloud
          #     resources into groups that reflect a customer's organizational needs and
          #     deployment strategies. They can be used to filter resources and aggregate
          #     metrics.
          #
          #     * Label keys must be between 1 and 63 characters long and must conform to
          #       the regular expression: `[\p{Ll}\p{Lo}][\p{Ll}\p{Lo}\p{N}_-]{0,62}`.
          #     * Label values must be between 0 and 63 characters long and must conform to
          #       the regular expression: `[\p{Ll}\p{Lo}\p{N}_-]{0,63}`.
          #     * No more than 64 labels can be associated with a given resource.
          #     * Keys and values must both be under 128 bytes.
          class Instance
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

            # Possible states of an instance.
            module State
              # The state of the instance could not be determined.
              STATE_NOT_KNOWN = 0

              # The instance has been successfully created and can serve requests
              # to its tables.
              READY = 1

              # The instance is currently being created, and may be destroyed
              # if the creation process encounters an error.
              CREATING = 2
            end

            # The type of the instance.
            module Type
              # The type of the instance is unspecified. If set when creating an
              # instance, a `PRODUCTION` instance will be created. If set when updating
              # an instance, the type will be left unchanged.
              TYPE_UNSPECIFIED = 0

              # An instance meant for production use. `serve_nodes` must be set
              # on the cluster.
              PRODUCTION = 1

              # The instance is meant for development and testing purposes only; it has
              # no performance or uptime guarantees and is not covered by SLA.
              # After a development instance is created, it can be upgraded by
              # updating the instance to type `PRODUCTION`. An instance created
              # as a production instance cannot be changed to a development instance.
              # When creating a development instance, `serve_nodes` on the cluster must
              # not be set.
              DEVELOPMENT = 2
            end
          end

          # A resizable group of nodes in a particular cloud location, capable
          # of serving all {::Google::Cloud::Bigtable::Admin::V2::Table Tables} in the parent
          # {::Google::Cloud::Bigtable::Admin::V2::Instance Instance}.
          # @!attribute [r] name
          #   @return [::String]
          #     The unique name of the cluster. Values are of the form
          #     `projects/{project}/instances/{instance}/clusters/[a-z][-a-z0-9]*`.
          # @!attribute [rw] location
          #   @return [::String]
          #     (`CreationOnly`)
          #     The location where this cluster's nodes and storage reside. For best
          #     performance, clients should be located as close as possible to this
          #     cluster. Currently only zones are supported, so values should be of the
          #     form `projects/{project}/locations/{zone}`.
          # @!attribute [r] state
          #   @return [::Google::Cloud::Bigtable::Admin::V2::Cluster::State]
          #     The current state of the cluster.
          # @!attribute [rw] serve_nodes
          #   @return [::Integer]
          #     Required. The number of nodes allocated to this cluster. More nodes enable
          #     higher throughput and more consistent performance.
          # @!attribute [rw] default_storage_type
          #   @return [::Google::Cloud::Bigtable::Admin::V2::StorageType]
          #     (`CreationOnly`)
          #     The type of storage used by this cluster to serve its
          #     parent instance's tables, unless explicitly overridden.
          # @!attribute [rw] encryption_config
          #   @return [::Google::Cloud::Bigtable::Admin::V2::Cluster::EncryptionConfig]
          #     Immutable. The encryption configuration for CMEK-protected clusters.
          class Cluster
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods

            # Cloud Key Management Service (Cloud KMS) settings for a CMEK-protected
            # cluster.
            # @!attribute [rw] kms_key_name
            #   @return [::String]
            #     Describes the Cloud KMS encryption key that will be used to protect the
            #     destination Bigtable cluster. The requirements for this key are:
            #      1) The Cloud Bigtable service account associated with the project that
            #      contains this cluster must be granted the
            #      `cloudkms.cryptoKeyEncrypterDecrypter` role on the CMEK key.
            #      2) Only regional keys can be used and the region of the CMEK key must
            #      match the region of the cluster.
            #     3) All clusters within an instance must use the same CMEK key.
            class EncryptionConfig
              include ::Google::Protobuf::MessageExts
              extend ::Google::Protobuf::MessageExts::ClassMethods
            end

            # Possible states of a cluster.
            module State
              # The state of the cluster could not be determined.
              STATE_NOT_KNOWN = 0

              # The cluster has been successfully created and is ready to serve requests.
              READY = 1

              # The cluster is currently being created, and may be destroyed
              # if the creation process encounters an error.
              # A cluster may not be able to serve requests while being created.
              CREATING = 2

              # The cluster is currently being resized, and may revert to its previous
              # node count if the process encounters an error.
              # A cluster is still capable of serving requests while being resized,
              # but may exhibit performance as if its number of allocated nodes is
              # between the starting and requested states.
              RESIZING = 3

              # The cluster has no backing nodes. The data (tables) still
              # exist, but no operations can be performed on the cluster.
              DISABLED = 4
            end
          end

          # A configuration object describing how Cloud Bigtable should treat traffic
          # from a particular end user application.
          # @!attribute [rw] name
          #   @return [::String]
          #     (`OutputOnly`)
          #     The unique name of the app profile. Values are of the form
          #     `projects/{project}/instances/{instance}/appProfiles/[_a-zA-Z0-9][-_.a-zA-Z0-9]*`.
          # @!attribute [rw] etag
          #   @return [::String]
          #     Strongly validated etag for optimistic concurrency control. Preserve the
          #     value returned from `GetAppProfile` when calling `UpdateAppProfile` to
          #     fail the request if there has been a modification in the mean time. The
          #     `update_mask` of the request need not include `etag` for this protection
          #     to apply.
          #     See [Wikipedia](https://en.wikipedia.org/wiki/HTTP_ETag) and
          #     [RFC 7232](https://tools.ietf.org/html/rfc7232#section-2.3) for more
          #     details.
          # @!attribute [rw] description
          #   @return [::String]
          #     Optional long form description of the use case for this AppProfile.
          # @!attribute [rw] multi_cluster_routing_use_any
          #   @return [::Google::Cloud::Bigtable::Admin::V2::AppProfile::MultiClusterRoutingUseAny]
          #     Use a multi-cluster routing policy.
          # @!attribute [rw] single_cluster_routing
          #   @return [::Google::Cloud::Bigtable::Admin::V2::AppProfile::SingleClusterRouting]
          #     Use a single-cluster routing policy.
          class AppProfile
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods

            # Read/write requests are routed to the nearest cluster in the instance, and
            # will fail over to the nearest cluster that is available in the event of
            # transient errors or delays. Clusters in a region are considered
            # equidistant. Choosing this option sacrifices read-your-writes consistency
            # to improve availability.
            class MultiClusterRoutingUseAny
              include ::Google::Protobuf::MessageExts
              extend ::Google::Protobuf::MessageExts::ClassMethods
            end

            # Unconditionally routes all read/write requests to a specific cluster.
            # This option preserves read-your-writes consistency but does not improve
            # availability.
            # @!attribute [rw] cluster_id
            #   @return [::String]
            #     The cluster to which read/write requests should be routed.
            # @!attribute [rw] allow_transactional_writes
            #   @return [::Boolean]
            #     Whether or not `CheckAndMutateRow` and `ReadModifyWriteRow` requests are
            #     allowed by this app profile. It is unsafe to send these requests to
            #     the same table/row/column in multiple clusters.
            class SingleClusterRouting
              include ::Google::Protobuf::MessageExts
              extend ::Google::Protobuf::MessageExts::ClassMethods
            end
          end
        end
      end
    end
  end
end
