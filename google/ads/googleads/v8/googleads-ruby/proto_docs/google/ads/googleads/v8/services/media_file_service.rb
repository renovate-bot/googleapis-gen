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
        module Services
          # Request message for {::Google::Ads::GoogleAds::V8::Services::MediaFileService::Client#get_media_file MediaFileService.GetMediaFile}
          # @!attribute [rw] resource_name
          #   @return [::String]
          #     Required. The resource name of the media file to fetch.
          class GetMediaFileRequest
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # Request message for {::Google::Ads::GoogleAds::V8::Services::MediaFileService::Client#mutate_media_files MediaFileService.MutateMediaFiles}
          # @!attribute [rw] customer_id
          #   @return [::String]
          #     Required. The ID of the customer whose media files are being modified.
          # @!attribute [rw] operations
          #   @return [::Array<::Google::Ads::GoogleAds::V8::Services::MediaFileOperation>]
          #     Required. The list of operations to perform on individual media file.
          # @!attribute [rw] partial_failure
          #   @return [::Boolean]
          #     If true, successful operations will be carried out and invalid
          #     operations will return errors. If false, all operations will be carried
          #     out in one transaction if and only if they are all valid.
          #     Default is false.
          # @!attribute [rw] validate_only
          #   @return [::Boolean]
          #     If true, the request is validated but not executed. Only errors are
          #     returned, not results.
          # @!attribute [rw] response_content_type
          #   @return [::Google::Ads::GoogleAds::V8::Enums::ResponseContentTypeEnum::ResponseContentType]
          #     The response content type setting. Determines whether the mutable resource
          #     or just the resource name should be returned post mutation.
          class MutateMediaFilesRequest
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # A single operation to create media file.
          # @!attribute [rw] create
          #   @return [::Google::Ads::GoogleAds::V8::Resources::MediaFile]
          #     Create operation: No resource name is expected for the new media file.
          class MediaFileOperation
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # Response message for a media file mutate.
          # @!attribute [rw] partial_failure_error
          #   @return [::Google::Rpc::Status]
          #     Errors that pertain to operation failures in the partial failure mode.
          #     Returned only when partial_failure = true and all errors occur inside the
          #     operations. If any errors occur outside the operations (e.g. auth errors),
          #     we return an RPC level error.
          # @!attribute [rw] results
          #   @return [::Array<::Google::Ads::GoogleAds::V8::Services::MutateMediaFileResult>]
          #     All results for the mutate.
          class MutateMediaFilesResponse
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end

          # The result for the media file mutate.
          # @!attribute [rw] resource_name
          #   @return [::String]
          #     The resource name returned for successful operations.
          # @!attribute [rw] media_file
          #   @return [::Google::Ads::GoogleAds::V8::Resources::MediaFile]
          #     The mutated media file with only mutable fields after mutate. The field
          #     will only be returned when response_content_type is set to
          #     "MUTABLE_RESOURCE".
          class MutateMediaFileResult
            include ::Google::Protobuf::MessageExts
            extend ::Google::Protobuf::MessageExts::ClassMethods
          end
        end
      end
    end
  end
end
