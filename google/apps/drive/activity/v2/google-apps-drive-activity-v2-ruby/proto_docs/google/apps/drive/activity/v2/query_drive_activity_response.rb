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
  module Apps
    module Drive
      module Activity
        module V2
          # Response message for querying Drive activity.
          # @!attribute [rw] activities
          #   @return [::Array<::Google::Apps::Drive::Activity::V2::DriveActivity>]
          #     List of activity requested.
          # @!attribute [rw] next_page_token
          #   @return [::String]
          #     Token to retrieve the next page of results, or
          #     empty if there are no more results in the list.
          class QueryDriveActivityResponse
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # A single Drive activity comprising one or more Actions by one or more
          # Actors on one or more Targets. Some Action groupings occur spontaneously,
          # such as moving an item into a shared folder triggering a permission change.
          # Other groupings of related Actions, such as multiple Actors editing one item
          # or moving multiple files into a new folder, are controlled by the selection
          # of a ConsolidationStrategy in the QueryDriveActivityRequest.
          # @!attribute [rw] primary_action_detail
          #   @return [::Google::Apps::Drive::Activity::V2::ActionDetail]
          #     Key information about the primary action for this activity. This is either
          #     representative, or the most important, of all actions in the activity,
          #     according to the ConsolidationStrategy in the request.
          # @!attribute [rw] actors
          #   @return [::Array<::Google::Apps::Drive::Activity::V2::Actor>]
          #     All actor(s) responsible for the activity.
          # @!attribute [rw] actions
          #   @return [::Array<::Google::Apps::Drive::Activity::V2::Action>]
          #     Details on all actions in this activity.
          # @!attribute [rw] targets
          #   @return [::Array<::Google::Apps::Drive::Activity::V2::Target>]
          #     All Google Drive objects this activity is about (e.g. file, folder, drive).
          #     This represents the state of the target immediately after the actions
          #     occurred.
          # @!attribute [rw] timestamp
          #   @return [::Google::Protobuf::Timestamp]
          #     The activity occurred at this specific time.
          # @!attribute [rw] time_range
          #   @return [::Google::Apps::Drive::Activity::V2::TimeRange]
          #     The activity occurred over this time range.
          class DriveActivity
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end
        end
      end
    end
  end
end
