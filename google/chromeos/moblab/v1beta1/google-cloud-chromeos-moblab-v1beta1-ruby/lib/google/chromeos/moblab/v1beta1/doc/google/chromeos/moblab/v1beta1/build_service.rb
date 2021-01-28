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
  module Chromeos
    module Moblab
      module V1beta1
        # Request message for listing builds.
        # NEXT_TAG: 7
        # @!attribute [rw] parent
        #   @return [String]
        #     Required. The full resource name of the model. The model id is the same as
        #     the build target id for non-unified builds.
        #     For example,
        #     'buildTargets/octopus/models/bobba'.
        # @!attribute [rw] page_size
        #   @return [Integer]
        #     Optional. The number of builds to return in a page.
        # @!attribute [rw] page_token
        #   @return [String]
        #     Optional. A page token, received from a previous `ListBuilds` call. Provide this to
        #     retrieve the subsequent page.
        # @!attribute [rw] filter
        #   @return [String]
        #     Optional. Filter that specifies value constraints of fields. For example, the
        #     filter can be set as "filter='milestone=milestones/80'" to only select
        #     builds in milestone 80.
        # @!attribute [rw] read_mask
        #   @return [Google::Protobuf::FieldMask]
        #     Optional. Read mask that specifies which Build fields to return. If empty, all Build
        #     fields will be returned.
        #     Valid fields: name, milestone, build_version.
        #     For example, if the read_mask is set as "read_mask='milestone'", the
        #     ListBuilds will return a list of Builds object with only the milestone
        #     field.
        # @!attribute [rw] group_by
        #   @return [Google::Protobuf::FieldMask]
        #     Optional. The operation that groups by all the Build fields specified in the read
        #     mask. The group_by field should be the same as the read_mask field in
        #     convention of SQL.
        class ListBuildsRequest; end

        # Response message for listing builds.
        # NEXT_TAG: 4
        # @!attribute [rw] builds
        #   @return [Array<Google::Chromeos::Moblab::V1beta1::Build>]
        #     The list of builds.
        # @!attribute [rw] next_page_token
        #   @return [String]
        #     Token to retrieve the next page of builds. If this field is omitted, there
        #     are no subsequent pages.
        # @!attribute [rw] total_size
        #   @return [Integer]
        #     Total number of builds.
        class ListBuildsResponse; end

        # Request message for checking if the build artifact is staged.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The full resource name of the build artifact.
        #     For example,
        #     'buildTargets/octopus/models/bobba/builds/12607.6.0/artifacts/chromeos-moblab-peng-staging'.
        class CheckBuildStageStatusRequest; end

        # Response message for checking the stage status of a build artifact.
        # NEXT_TAG: 4
        # @!attribute [rw] is_build_staged
        #   @return [true, false]
        #     The status to represent if the build is staged or not.
        # @!attribute [rw] staged_build_artifact
        #   @return [Google::Chromeos::Moblab::V1beta1::BuildArtifact]
        #     The staged build artifact in the destination bucket.
        # @!attribute [rw] source_build_artifact
        #   @return [Google::Chromeos::Moblab::V1beta1::BuildArtifact]
        #     The source build artifact in the source bucket.
        class CheckBuildStageStatusResponse; end

        # Request message for staging a build artifact.
        # @!attribute [rw] name
        #   @return [String]
        #     Required. The full resource name of the build artifact.
        #     For example,
        #     'buildTargets/octopus/models/bobba/builds/12607.6.0/artifacts/chromeos-moblab-peng-staging'.
        class StageBuildRequest; end

        # Response message for staging a build artifact.
        # @!attribute [rw] staged_build_artifact
        #   @return [Google::Chromeos::Moblab::V1beta1::BuildArtifact]
        #     The staged build in the destination bucket.
        class StageBuildResponse; end

        # Metadata message for staging a build artifact.
        # NEXT_TAG: 4
        # @!attribute [rw] progress_percent
        #   @return [Float]
        #     Approximate percentage of progress, e.g. "50" means 50%.
        # @!attribute [rw] start_time
        #   @return [Google::Protobuf::Timestamp]
        #     Build stage start time.
        # @!attribute [rw] end_time
        #   @return [Google::Protobuf::Timestamp]
        #     Build stage end time.
        class StageBuildMetadata; end
      end
    end
  end
end