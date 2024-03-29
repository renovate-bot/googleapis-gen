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
  module Home
    module Enterprise
      module Sdm
        module V1
          # Request message for SmartDeviceManagementService.GetDevice
          # @!attribute [rw] name
          #   @return [::String]
          #     The name of the device requested. For example:
          #     "enterprises/XYZ/devices/123"
          class GetDeviceRequest
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # Request message for SmartDeviceManagementService.ListDevices
          # @!attribute [rw] parent
          #   @return [::String]
          #     The parent enterprise to list devices under. E.g. "enterprises/XYZ".
          # @!attribute [rw] page_size
          #   @return [::Integer]
          #     Optional requested page size. Server may return fewer devices than
          #     requested. If unspecified, server will pick an appropriate default.
          # @!attribute [rw] page_token
          #   @return [::String]
          #     Optional token of the page to retrieve.
          # @!attribute [rw] filter
          #   @return [::String]
          #     Optional filter to list devices.
          #
          #     Filters can match the exact parent (could be a structure or a room):
          #     'parent=enterprises/XYZ/structures/jkl'
          #     or filter by device custom name (substring match):
          #     'customName=wing'
          class ListDevicesRequest
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # Response message for SmartDeviceManagementService.ListDevices
          # @!attribute [rw] devices
          #   @return [::Array<::Google::Home::Enterprise::Sdm::V1::Device>]
          #     The list of devices.
          # @!attribute [rw] next_page_token
          #   @return [::String]
          #     The pagination token to retrieve the next page of results.
          class ListDevicesResponse
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # Request message for SmartDeviceManagementService.ExecuteDeviceCommand
          # @!attribute [rw] name
          #   @return [::String]
          #     The name of the device requested. For example:
          #     "enterprises/XYZ/devices/123"
          # @!attribute [rw] command
          #   @return [::String]
          #     The command name to execute, represented by the fully qualified protobuf
          #     message name.
          # @!attribute [rw] params
          #   @return [::Google::Protobuf::Struct]
          #     The command message to execute, represented as a Struct.
          class ExecuteDeviceCommandRequest
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # Response message for SmartDeviceManagementService.ExecuteDeviceCommand
          # @!attribute [rw] results
          #   @return [::Google::Protobuf::Struct]
          #     The results of executing the command.
          class ExecuteDeviceCommandResponse
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # Request message for SmartDeviceManagementService.GetStructure
          # @!attribute [rw] name
          #   @return [::String]
          #     The name of the structure requested. For example:
          #     "enterprises/XYZ/structures/ABC".
          class GetStructureRequest
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # Request message for SmartDeviceManagementService.ListStructures
          # @!attribute [rw] parent
          #   @return [::String]
          #     The parent enterprise to list structures under. E.g. "enterprises/XYZ".
          # @!attribute [rw] page_size
          #   @return [::Integer]
          #     Requested page size. Server may return fewer structures than requested.
          #     If unspecified, server will pick an appropriate default.
          # @!attribute [rw] page_token
          #   @return [::String]
          #     The token of the page to retrieve.
          # @!attribute [rw] filter
          #   @return [::String]
          #     Optional filter to list structures.
          class ListStructuresRequest
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # Response message for SmartDeviceManagementService.ListStructures
          # @!attribute [rw] structures
          #   @return [::Array<::Google::Home::Enterprise::Sdm::V1::Structure>]
          #     The list of structures.
          # @!attribute [rw] next_page_token
          #   @return [::String]
          #     The pagination token to retrieve the next page of results.
          #     If this field is omitted, there are no subsequent pages.
          class ListStructuresResponse
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # Request message for SmartDeviceManagementService.GetRoom
          # @!attribute [rw] name
          #   @return [::String]
          #     The name of the room requested. For example:
          #     "enterprises/XYZ/structures/ABC/rooms/123".
          class GetRoomRequest
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # Request message for SmartDeviceManagementService.ListRooms
          # @!attribute [rw] parent
          #   @return [::String]
          #     The parent resource name of the rooms requested. For example:
          #     "enterprises/XYZ/structures/ABC".
          # @!attribute [rw] page_size
          #   @return [::Integer]
          #     Requested page size. Server may return fewer rooms than requested.
          #     If unspecified, server will pick an appropriate default.
          # @!attribute [rw] page_token
          #   @return [::String]
          #     The token of the page to retrieve.
          class ListRoomsRequest
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # Response message for SmartDeviceManagementService.ListRooms
          # @!attribute [rw] rooms
          #   @return [::Array<::Google::Home::Enterprise::Sdm::V1::Room>]
          #     The list of rooms.
          # @!attribute [rw] next_page_token
          #   @return [::String]
          #     The pagination token to retrieve the next page of results.
          #     If this field is omitted, there are no subsequent pages.
          class ListRoomsResponse
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end
        end
      end
    end
  end
end
