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
      module V1
        # A piece of data in a Dataset. Could be an image, a video, a document or plain
        # text.
        # @!attribute [rw] name
        #   @return [String]
        #     Output only. The resource name of the DataItem.
        # @!attribute [rw] create_time
        #   @return [Google::Protobuf::Timestamp]
        #     Output only. Timestamp when this DataItem was created.
        # @!attribute [rw] update_time
        #   @return [Google::Protobuf::Timestamp]
        #     Output only. Timestamp when this DataItem was last updated.
        # @!attribute [rw] labels
        #   @return [Hash{String => String}]
        #     Optional. The labels with user-defined metadata to organize your DataItems.
        #
        #     Label keys and values can be no longer than 64 characters
        #     (Unicode codepoints), can only contain lowercase letters, numeric
        #     characters, underscores and dashes. International characters are allowed.
        #     No more than 64 user labels can be associated with one DataItem(System
        #     labels are excluded).
        #
        #     See https://goo.gl/xmQnxf for more information and examples of labels.
        #     System reserved label keys are prefixed with "aiplatform.googleapis.com/"
        #     and are immutable.
        # @!attribute [rw] payload
        #   @return [Google::Protobuf::Value]
        #     Required. The data that the DataItem represents (for example, an image or a text
        #     snippet). The schema of the payload is stored in the parent Dataset's
        #     {Google::Cloud::Aiplatform::V1::Dataset#metadata_schema_uri metadata schema's} dataItemSchemaUri field.
        # @!attribute [rw] etag
        #   @return [String]
        #     Optional. Used to perform consistent read-modify-write updates. If not set, a blind
        #     "overwrite" update happens.
        class DataItem; end
      end
    end
  end
end