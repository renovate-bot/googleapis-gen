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
      module V9
        module Services
          # Request message for {::Google::Ads::GoogleAds::V9::Services::GeoTargetConstantService::Client#get_geo_target_constant GeoTargetConstantService.GetGeoTargetConstant}.
          # @!attribute [rw] resource_name
          #   @return [::String]
          #     Required. The resource name of the geo target constant to fetch.
          class GetGeoTargetConstantRequest
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # Request message for
          # {::Google::Ads::GoogleAds::V9::Services::GeoTargetConstantService::Client#suggest_geo_target_constants GeoTargetConstantService.SuggestGeoTargetConstants}.
          # @!attribute [rw] locale
          #   @return [::String]
          #     If possible, returned geo targets are translated using this locale. If not,
          #     en is used by default. This is also used as a hint for returned geo
          #     targets.
          # @!attribute [rw] country_code
          #   @return [::String]
          #     Returned geo targets are restricted to this country code.
          # @!attribute [rw] location_names
          #   @return [::Google::Ads::GoogleAds::V9::Services::SuggestGeoTargetConstantsRequest::LocationNames]
          #     The location names to search by. At most 25 names can be set.
          # @!attribute [rw] geo_targets
          #   @return [::Google::Ads::GoogleAds::V9::Services::SuggestGeoTargetConstantsRequest::GeoTargets]
          #     The geo target constant resource names to filter by.
          class SuggestGeoTargetConstantsRequest
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods

            # A list of location names.
            # @!attribute [rw] names
            #   @return [::Array<::String>]
            #     A list of location names.
            class LocationNames
              include ::Google::Protobuf::MessageExts
              extend ::Google::Protobuf::MessageExts::ClassMethods
            end

            # A list of geo target constant resource names.
            # @!attribute [rw] geo_target_constants
            #   @return [::Array<::String>]
            #     A list of geo target constant resource names.
            class GeoTargets
              include ::Google::Protobuf::MessageExts
              extend ::Google::Protobuf::MessageExts::ClassMethods
            end
          end

          # Response message for {::Google::Ads::GoogleAds::V9::Services::GeoTargetConstantService::Client#suggest_geo_target_constants GeoTargetConstantService.SuggestGeoTargetConstants}.
          # @!attribute [rw] geo_target_constant_suggestions
          #   @return [::Array<::Google::Ads::GoogleAds::V9::Services::GeoTargetConstantSuggestion>]
          #     Geo target constant suggestions.
          class SuggestGeoTargetConstantsResponse
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # A geo target constant suggestion.
          # @!attribute [rw] locale
          #   @return [::String]
          #     The language this GeoTargetConstantSuggestion is currently translated to.
          #     It affects the name of geo target fields. For example, if locale=en, then
          #     name=Spain. If locale=es, then name=España. The default locale will be
          #     returned if no translation exists for the locale in the request.
          # @!attribute [rw] reach
          #   @return [::Integer]
          #     Approximate user population that will be targeted, rounded to the
          #     nearest 100.
          # @!attribute [rw] search_term
          #   @return [::String]
          #     If the request searched by location name, this is the location name that
          #     matched the geo target.
          # @!attribute [rw] geo_target_constant
          #   @return [::Google::Ads::GoogleAds::V9::Resources::GeoTargetConstant]
          #     The GeoTargetConstant result.
          # @!attribute [rw] geo_target_constant_parents
          #   @return [::Array<::Google::Ads::GoogleAds::V9::Resources::GeoTargetConstant>]
          #     The list of parents of the geo target constant.
          class GeoTargetConstantSuggestion
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end
        end
      end
    end
  end
end
