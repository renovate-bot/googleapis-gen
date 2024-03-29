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
          # A landing page view with metrics aggregated at the unexpanded final URL
          # level.
          # @!attribute [r] resource_name
          #   @return [::String]
          #     Output only. The resource name of the landing page view.
          #     Landing page view resource names have the form:
          #
          #     `customers/{customer_id}/landingPageViews/{unexpanded_final_url_fingerprint}`
          # @!attribute [r] unexpanded_final_url
          #   @return [::String]
          #     Output only. The advertiser-specified final URL.
          class LandingPageView
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end
        end
      end
    end
  end
end
