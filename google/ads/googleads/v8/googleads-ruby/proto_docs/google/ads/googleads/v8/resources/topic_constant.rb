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
  module Ads
    module GoogleAds
      module V8
        module Resources
          # Use topics to target or exclude placements in the Google Display Network
          # based on the category into which the placement falls (for example,
          # "Pets & Animals/Pets/Dogs").
          # @!attribute [r] resource_name
          #   @return [::String]
          #     Output only. The resource name of the topic constant.
          #     topic constant resource names have the form:
          #
          #     `topicConstants/{topic_id}`
          # @!attribute [r] id
          #   @return [::Integer]
          #     Output only. The ID of the topic.
          # @!attribute [r] topic_constant_parent
          #   @return [::String]
          #     Output only. Resource name of parent of the topic constant.
          # @!attribute [r] path
          #   @return [::Array<::String>]
          #     Output only. The category to target or exclude. Each subsequent element in the array
          #     describes a more specific sub-category. For example,
          #     \\{"Pets & Animals", "Pets", "Dogs"} represents the
          #     "Pets & Animals/Pets/Dogs" category. List of available topic categories at
          #     https://developers.google.com/adwords/api/docs/appendix/verticals
          class TopicConstant
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end
        end
      end
    end
  end
end
