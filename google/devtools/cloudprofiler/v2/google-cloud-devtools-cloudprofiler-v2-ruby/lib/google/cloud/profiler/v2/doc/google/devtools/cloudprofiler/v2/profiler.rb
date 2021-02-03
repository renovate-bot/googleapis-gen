# Copyright 2020 Google LLC
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

module Google
  module Devtools
    module Cloudprofiler
      module V2
        # CreateProfileRequest describes a profile resource online creation request.
        # The deployment field must be populated. The profile_type specifies the list
        # of profile types supported by the agent. The creation call will hang until a
        # profile of one of these types needs to be collected.
        # @!attribute [rw] parent
        #   @return [String]
        #     Parent project to create the profile in.
        # @!attribute [rw] deployment
        #   @return [Google::Devtools::Cloudprofiler::V2::Deployment]
        #     Deployment details.
        # @!attribute [rw] profile_type
        #   @return [Array<Google::Devtools::Cloudprofiler::V2::ProfileType>]
        #     One or more profile types that the agent is capable of providing.
        class CreateProfileRequest; end

        # CreateOfflineProfileRequest describes a profile resource offline creation
        # request. Profile field must be set.
        # @!attribute [rw] parent
        #   @return [String]
        #     Parent project to create the profile in.
        # @!attribute [rw] profile
        #   @return [Google::Devtools::Cloudprofiler::V2::Profile]
        #     Contents of the profile to create.
        class CreateOfflineProfileRequest; end

        # UpdateProfileRequest contains the profile to update.
        # @!attribute [rw] profile
        #   @return [Google::Devtools::Cloudprofiler::V2::Profile]
        #     Profile to update
        # @!attribute [rw] update_mask
        #   @return [Google::Protobuf::FieldMask]
        #     Field mask used to specify the fields to be overwritten. Currently only
        #     profile_bytes and labels fields are supported by UpdateProfile, so only
        #     those fields can be specified in the mask. When no mask is provided, all
        #     fields are overwritten.
        class UpdateProfileRequest; end

        # Profile resource.
        # @!attribute [rw] name
        #   @return [String]
        #     Output only. Opaque, server-assigned, unique ID for this profile.
        # @!attribute [rw] profile_type
        #   @return [Google::Devtools::Cloudprofiler::V2::ProfileType]
        #     Type of profile.
        #     For offline mode, this must be specified when creating the profile. For
        #     online mode it is assigned and returned by the server.
        # @!attribute [rw] deployment
        #   @return [Google::Devtools::Cloudprofiler::V2::Deployment]
        #     Deployment this profile corresponds to.
        # @!attribute [rw] duration
        #   @return [Google::Protobuf::Duration]
        #     Duration of the profiling session.
        #     Input (for the offline mode) or output (for the online mode).
        #     The field represents requested profiling duration. It may slightly differ
        #     from the effective profiling duration, which is recorded in the profile
        #     data, in case the profiling can't be stopped immediately (e.g. in case
        #     stopping the profiling is handled asynchronously).
        # @!attribute [rw] profile_bytes
        #   @return [String]
        #     Input only. Profile bytes, as a gzip compressed serialized proto, the
        #     format is https://github.com/google/pprof/blob/master/proto/profile.proto.
        # @!attribute [rw] labels
        #   @return [Hash{String => String}]
        #     Input only. Labels associated to this specific profile. These labels will
        #     get merged with the deployment labels for the final data set.  See
        #     documentation on deployment labels for validation rules and limits.
        class Profile; end

        # Deployment contains the deployment identification information.
        # @!attribute [rw] project_id
        #   @return [String]
        #     Project ID is the ID of a cloud project.
        #     Validation regex: `^[a-z][-a-z0-9:.]{4,61}[a-z0-9]$`.
        # @!attribute [rw] target
        #   @return [String]
        #     Target is the service name used to group related deployments:
        #     * Service name for GAE Flex / Standard.
        #     * Cluster and container name for GKE.
        #     * User-specified string for direct GCE profiling (e.g. Java).
        #     * Job name for Dataflow.
        #       Validation regex: `^[a-z](https://cloud.google.com[-a-z0-9_.]{0,253}[a-z0-9])?$`.
        # @!attribute [rw] labels
        #   @return [Hash{String => String}]
        #     Labels identify the deployment within the user universe and same target.
        #     Validation regex for label names: `^[a-z0-9](https://cloud.google.com[a-z0-9-]{0,61}[a-z0-9])?$`.
        #     Value for an individual label must be <= 512 bytes, the total
        #     size of all label names and values must be <= 1024 bytes.
        #
        #     Label named "language" can be used to record the programming language of
        #     the profiled deployment. The standard choices for the value include "java",
        #     "go", "python", "ruby", "nodejs", "php", "dotnet".
        #
        #     For deployments running on Google Cloud Platform, "zone" or "region" label
        #     should be present describing the deployment location. An example of a zone
        #     is "us-central1-a", an example of a region is "us-central1" or
        #     "us-central".
        class Deployment; end

        # ProfileType is type of profiling data.
        # NOTE: the enumeration member names are used (in lowercase) as unique string
        # identifiers of profile types, so they must not be renamed.
        module ProfileType
          # Unspecified profile type.
          PROFILE_TYPE_UNSPECIFIED = 0

          # Thread CPU time sampling.
          CPU = 1

          # Wallclock time sampling. More expensive as stops all threads.
          WALL = 2

          # In-use heap profile. Represents a snapshot of the allocations that are
          # live at the time of the profiling.
          HEAP = 3

          # Single-shot collection of all thread stacks.
          THREADS = 4

          # Synchronization contention profile.
          CONTENTION = 5

          # Peak heap profile.
          PEAK_HEAP = 6

          # Heap allocation profile. It represents the aggregation of all allocations
          # made over the duration of the profile. All allocations are included,
          # including those that might have been freed by the end of the profiling
          # interval. The profile is in particular useful for garbage collecting
          # languages to understand which parts of the code create most of the garbage
          # collection pressure to see if those can be optimized.
          HEAP_ALLOC = 7
        end
      end
    end
  end
end