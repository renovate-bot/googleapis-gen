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
      module V7
        module Services
          # Request message for {::Google::Ads::GoogleAds::V7::Services::UserDataService::Client#upload_user_data UserDataService.UploadUserData}
          # @!attribute [rw] customer_id
          #   @return [::String]
          #     Required. The ID of the customer for which to update the user data.
          # @!attribute [rw] operations
          #   @return [::Array<::Google::Ads::GoogleAds::V7::Services::UserDataOperation>]
          #     Required. The list of operations to be done.
          # @!attribute [rw] customer_match_user_list_metadata
          #   @return [::Google::Ads::GoogleAds::V7::Common::CustomerMatchUserListMetadata]
          #     Metadata for data updates to a Customer Match user list.
          class UploadUserDataRequest
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # Operation to be made for the UploadUserDataRequest.
          # @!attribute [rw] create
          #   @return [::Google::Ads::GoogleAds::V7::Common::UserData]
          #     The list of user data to be appended to the user list.
          # @!attribute [rw] remove
          #   @return [::Google::Ads::GoogleAds::V7::Common::UserData]
          #     The list of user data to be removed from the user list.
          class UserDataOperation
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # Response message for {::Google::Ads::GoogleAds::V7::Services::UserDataService::Client#upload_user_data UserDataService.UploadUserData}
          # @!attribute [rw] upload_date_time
          #   @return [::String]
          #     The date time at which the request was received by API, formatted as
          #     "yyyy-mm-dd hh:mm:ss+|-hh:mm", e.g. "2019-01-01 12:32:45-08:00".
          # @!attribute [rw] received_operations_count
          #   @return [::Integer]
          #     Number of upload data operations received by API.
          class UploadUserDataResponse
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end
        end
      end
    end
  end
end
