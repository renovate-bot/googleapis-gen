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
        # Resource that represents a build for the given build target, model, milestone
        # and build version.
        # NEXT_TAG: 4
        # @!attribute [rw] name
        #   @return [String]
        #     The resource name of the build.
        #     Format: buildTargets/{build_target}/models/{model}/builds/{build}
        #     Example: buildTargets/octopus/models/bobba/builds/1234.0.0
        # @!attribute [rw] milestone
        #   @return [String]
        #     The milestone that owns the build.
        #     Format: milestones/{milestone}
        # @!attribute [rw] build_version
        #   @return [String]
        #     The build version of the build, e.g. 1234.0.0.
        class Build; end

        # Resource that represents a build artifact stored in Google Cloud Storage for
        # the given build target, model, build version and bucket. NEXT_TAG: 6
        # @!attribute [rw] name
        #   @return [String]
        #     The resource name of the build artifact.
        #     Format:
        #     buildTargets/{build_target}/models/{model}/builds/{build}/artifacts/{artifact}
        #     Example:
        #     buildTargets/octopus/models/bobba/builds/1234.0.0/artifacts/chromeos-moblab-peng-staging
        # @!attribute [rw] build
        #   @return [String]
        #     The build metadata of the build artifact.
        # @!attribute [rw] bucket
        #   @return [String]
        #     The bucket that stores the build artifact.
        # @!attribute [rw] path
        #   @return [String]
        #     The path of the build artifact in the bucket.
        # @!attribute [rw] object_count
        #   @return [Integer]
        #     The number of objects in the build artifact folder. The object number can
        #     be used to calculated the stage progress by comparing the source build
        #     artifact with the destination build artifact.
        class BuildArtifact; end
      end
    end
  end
end