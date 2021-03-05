# frozen_string_literal: true

# Copyright 2021 Google LLC
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
          # Information about the target of activity.
          # @!attribute [rw] drive_item
          #   @return [::Google::Apps::Drive::Activity::V2::DriveItem]
          #     The target is a Drive item.
          # @!attribute [rw] drive
          #   @return [::Google::Apps::Drive::Activity::V2::Drive]
          #     The target is a shared drive.
          # @!attribute [rw] file_comment
          #   @return [::Google::Apps::Drive::Activity::V2::FileComment]
          #     The target is a comment on a Drive file.
          # @!attribute [rw] team_drive
          #   @return [::Google::Apps::Drive::Activity::V2::TeamDrive]
          #     This field is deprecated; please use the `drive` field instead.
          class Target
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # A lightweight reference to the target of activity.
          # @!attribute [rw] drive_item
          #   @return [::Google::Apps::Drive::Activity::V2::DriveItemReference]
          #     The target is a Drive item.
          # @!attribute [rw] drive
          #   @return [::Google::Apps::Drive::Activity::V2::DriveReference]
          #     The target is a shared drive.
          # @!attribute [rw] team_drive
          #   @return [::Google::Apps::Drive::Activity::V2::TeamDriveReference]
          #     This field is deprecated; please use the `drive` field instead.
          class TargetReference
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # A comment on a file.
          # @!attribute [rw] legacy_comment_id
          #   @return [::String]
          #     The comment in the discussion thread. This identifier is an opaque string
          #     compatible with the Drive API; see
          #     https://developers.google.com/drive/v3/reference/comments/get
          # @!attribute [rw] legacy_discussion_id
          #   @return [::String]
          #     The discussion thread to which the comment was added. This identifier is an
          #     opaque string compatible with the Drive API and references the first
          #     comment in a discussion; see
          #     https://developers.google.com/drive/v3/reference/comments/get
          # @!attribute [rw] link_to_discussion
          #   @return [::String]
          #     The link to the discussion thread containing this comment, for example,
          #     `https://docs.google.com/DOCUMENT_ID/edit?disco=THREAD_ID`.
          # @!attribute [rw] parent
          #   @return [::Google::Apps::Drive::Activity::V2::DriveItem]
          #     The Drive item containing this comment.
          class FileComment
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # A Drive item, such as a file or folder.
          # @!attribute [rw] name
          #   @return [::String]
          #     The target Drive item. The format is `items/ITEM_ID`.
          # @!attribute [rw] title
          #   @return [::String]
          #     The title of the Drive item.
          # @!attribute [rw] file
          #   @return [::Google::Apps::Drive::Activity::V2::DriveItem::File]
          #     This field is deprecated; please use the `driveFile` field instead.
          # @!attribute [rw] folder
          #   @return [::Google::Apps::Drive::Activity::V2::DriveItem::Folder]
          #     This field is deprecated; please use the `driveFolder` field instead.
          # @!attribute [rw] drive_file
          #   @return [::Google::Apps::Drive::Activity::V2::DriveItem::DriveFile]
          #     The Drive item is a file.
          # @!attribute [rw] drive_folder
          #   @return [::Google::Apps::Drive::Activity::V2::DriveItem::DriveFolder]
          #     The Drive item is a folder. Includes information about the type of
          #     folder.
          # @!attribute [rw] mime_type
          #   @return [::String]
          #     The MIME type of the Drive item.  See
          #     https://developers.google.com/drive/v3/web/mime-types.
          # @!attribute [rw] owner
          #   @return [::Google::Apps::Drive::Activity::V2::Owner]
          #     Information about the owner of this Drive item.
          class DriveItem
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods

            # This item is deprecated; please see `DriveFile` instead.
            class File
              include ::Google::Protobuf::MessageExts
              extend ::Google::Protobuf::MessageExts::ClassMethods
            end

            # This item is deprecated; please see `DriveFolder` instead.
            # @!attribute [rw] type
            #   @return [::Google::Apps::Drive::Activity::V2::DriveItem::Folder::Type]
            #     This field is deprecated; please see `DriveFolder.type` instead.
            class Folder
              include ::Google::Protobuf::MessageExts
              extend ::Google::Protobuf::MessageExts::ClassMethods

              # This item is deprecated; please see `DriveFolder.Type` instead.
              module Type
                # This item is deprecated; please see `DriveFolder.Type` instead.
                TYPE_UNSPECIFIED = 0

                # This item is deprecated; please see `DriveFolder.Type` instead.
                MY_DRIVE_ROOT = 1

                # This item is deprecated; please see `DriveFolder.Type` instead.
                TEAM_DRIVE_ROOT = 2

                # This item is deprecated; please see `DriveFolder.Type` instead.
                STANDARD_FOLDER = 3
              end
            end

            # A Drive item which is a file.
            class DriveFile
              include ::Google::Protobuf::MessageExts
              extend ::Google::Protobuf::MessageExts::ClassMethods
            end

            # A Drive item which is a folder.
            # @!attribute [rw] type
            #   @return [::Google::Apps::Drive::Activity::V2::DriveItem::DriveFolder::Type]
            #     The type of Drive folder.
            class DriveFolder
              include ::Google::Protobuf::MessageExts
              extend ::Google::Protobuf::MessageExts::ClassMethods

              # The type of a Drive folder.
              module Type
                # The folder type is unknown.
                TYPE_UNSPECIFIED = 0

                # The folder is the root of a user's MyDrive.
                MY_DRIVE_ROOT = 1

                # The folder is the root of a shared drive.
                SHARED_DRIVE_ROOT = 2

                # The folder is a standard, non-root, folder.
                STANDARD_FOLDER = 3
              end
            end
          end

          # Information about the owner of a Drive item.
          # @!attribute [rw] user
          #   @return [::Google::Apps::Drive::Activity::V2::User]
          #     The user that owns the Drive item.
          # @!attribute [rw] drive
          #   @return [::Google::Apps::Drive::Activity::V2::DriveReference]
          #     The drive that owns the item.
          # @!attribute [rw] team_drive
          #   @return [::Google::Apps::Drive::Activity::V2::TeamDriveReference]
          #     This field is deprecated; please use the `drive` field instead.
          # @!attribute [rw] domain
          #   @return [::Google::Apps::Drive::Activity::V2::Domain]
          #     The domain of the Drive item owner.
          class Owner
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # This item is deprecated; please see `Drive` instead.
          # @!attribute [rw] name
          #   @return [::String]
          #     This field is deprecated; please see `Drive.name` instead.
          # @!attribute [rw] title
          #   @return [::String]
          #     This field is deprecated; please see `Drive.title` instead.
          # @!attribute [rw] root
          #   @return [::Google::Apps::Drive::Activity::V2::DriveItem]
          #     This field is deprecated; please see `Drive.root` instead.
          class TeamDrive
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # Information about a shared drive.
          # @!attribute [rw] name
          #   @return [::String]
          #     The resource name of the shared drive. The format is
          #     `COLLECTION_ID/DRIVE_ID`. Clients should not assume a specific collection
          #     ID for this resource name.
          # @!attribute [rw] title
          #   @return [::String]
          #     The title of the shared drive.
          # @!attribute [rw] root
          #   @return [::Google::Apps::Drive::Activity::V2::DriveItem]
          #     The root of this shared drive.
          class Drive
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # A lightweight reference to a Drive item, such as a file or folder.
          # @!attribute [rw] name
          #   @return [::String]
          #     The target Drive item. The format is `items/ITEM_ID`.
          # @!attribute [rw] title
          #   @return [::String]
          #     The title of the Drive item.
          # @!attribute [rw] file
          #   @return [::Google::Apps::Drive::Activity::V2::DriveItem::File]
          #     This field is deprecated; please use the `driveFile` field instead.
          # @!attribute [rw] folder
          #   @return [::Google::Apps::Drive::Activity::V2::DriveItem::Folder]
          #     This field is deprecated; please use the `driveFolder` field instead.
          # @!attribute [rw] drive_file
          #   @return [::Google::Apps::Drive::Activity::V2::DriveItem::DriveFile]
          #     The Drive item is a file.
          # @!attribute [rw] drive_folder
          #   @return [::Google::Apps::Drive::Activity::V2::DriveItem::DriveFolder]
          #     The Drive item is a folder. Includes information about the type of
          #     folder.
          class DriveItemReference
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # This item is deprecated; please see `DriveReference` instead.
          # @!attribute [rw] name
          #   @return [::String]
          #     This field is deprecated; please see `DriveReference.name` instead.
          # @!attribute [rw] title
          #   @return [::String]
          #     This field is deprecated; please see `DriveReference.title` instead.
          class TeamDriveReference
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # A lightweight reference to a shared drive.
          # @!attribute [rw] name
          #   @return [::String]
          #     The resource name of the shared drive. The format is
          #     `COLLECTION_ID/DRIVE_ID`. Clients should not assume a specific collection
          #     ID for this resource name.
          # @!attribute [rw] title
          #   @return [::String]
          #     The title of the shared drive.
          class DriveReference
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end
        end
      end
    end
  end
end
