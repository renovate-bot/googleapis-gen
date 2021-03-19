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
  module Cloud
    module Aiplatform
      module V1beta1
        # Identifies a concept with which DataItems may be annotated with.
        # @!attribute [rw] name
        #   @return [String]
        #     Output only. Resource name of the AnnotationSpec.
        # @!attribute [rw] display_name
        #   @return [String]
        #     Required. The user-defined name of the AnnotationSpec.
        #     The name can be up to 128 characters long and can be consist of any UTF-8
        #     characters.
        # @!attribute [rw] create_time
        #   @return [Google::Protobuf::Timestamp]
        #     Output only. Timestamp when this AnnotationSpec was created.
        # @!attribute [rw] update_time
        #   @return [Google::Protobuf::Timestamp]
        #     Output only. Timestamp when AnnotationSpec was last updated.
        # @!attribute [rw] etag
        #   @return [String]
        #     Optional. Used to perform consistent read-modify-write updates. If not set, a blind
        #     "overwrite" update happens.
        class AnnotationSpec; end
      end
    end
  end
end