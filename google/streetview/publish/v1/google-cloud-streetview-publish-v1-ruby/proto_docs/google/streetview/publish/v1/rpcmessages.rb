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
  module Streetview
    module Publish
      module V1
        # Request to create a {::Google::Streetview::Publish::V1::Photo Photo}.
        # @!attribute [rw] photo
        #   @return [::Google::Streetview::Publish::V1::Photo]
        #     Required. Photo to create.
        class CreatePhotoRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Request to get a {::Google::Streetview::Publish::V1::Photo Photo}.
        #
        # By default
        #
        # * does not return the download URL for the photo bytes.
        #
        # Parameters:
        #
        # * `view` controls if the download URL for the photo bytes is returned.
        # @!attribute [rw] photo_id
        #   @return [::String]
        #     Required. ID of the {::Google::Streetview::Publish::V1::Photo Photo}.
        # @!attribute [rw] view
        #   @return [::Google::Streetview::Publish::V1::PhotoView]
        #     Required. Specifies if a download URL for the photo bytes should be returned in the
        #     {::Google::Streetview::Publish::V1::Photo Photo} response.
        # @!attribute [rw] language_code
        #   @return [::String]
        #     The BCP-47 language code, such as "en-US" or "sr-Latn". For more
        #     information, see
        #     http://www.unicode.org/reports/tr35/#Unicode_locale_identifier.
        #     If language_code is unspecified, the user's language preference for Google
        #     services is used.
        class GetPhotoRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Request to get one or more {::Google::Streetview::Publish::V1::Photo Photos}.
        # By default
        #
        # * does not return the download URL for the photo bytes.
        #
        # Parameters:
        #
        # * `view` controls if the download URL for the photo bytes is returned.
        # @!attribute [rw] photo_ids
        #   @return [::Array<::String>]
        #     Required. IDs of the {::Google::Streetview::Publish::V1::Photo Photos}. For HTTP
        #     GET requests, the URL query parameter should be
        #     `photoIds=<id1>&photoIds=<id2>&...`.
        # @!attribute [rw] view
        #   @return [::Google::Streetview::Publish::V1::PhotoView]
        #     Required. Specifies if a download URL for the photo bytes should be returned in the
        #     Photo response.
        # @!attribute [rw] language_code
        #   @return [::String]
        #     Optional. The BCP-47 language code, such as "en-US" or "sr-Latn". For more
        #     information, see
        #     http://www.unicode.org/reports/tr35/#Unicode_locale_identifier.
        #     If language_code is unspecified, the user's language preference for Google
        #     services is used.
        class BatchGetPhotosRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Response to batch get of {::Google::Streetview::Publish::V1::Photo Photos}.
        # @!attribute [rw] results
        #   @return [::Array<::Google::Streetview::Publish::V1::PhotoResponse>]
        #     List of results for each individual
        #     {::Google::Streetview::Publish::V1::Photo Photo} requested, in the same order as
        #     the requests in
        #     {::Google::Streetview::Publish::V1::StreetViewPublishService::Client#batch_get_photos BatchGetPhotos}.
        class BatchGetPhotosResponse
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Response payload for a single
        # {::Google::Streetview::Publish::V1::Photo Photo}
        # in batch operations including
        # {::Google::Streetview::Publish::V1::StreetViewPublishService::Client#batch_get_photos BatchGetPhotos}
        # and
        # {::Google::Streetview::Publish::V1::StreetViewPublishService::Client#batch_update_photos BatchUpdatePhotos}.
        # @!attribute [rw] status
        #   @return [::Google::Rpc::Status]
        #     The status for the operation to get or update a single photo in the batch
        #     request.
        # @!attribute [rw] photo
        #   @return [::Google::Streetview::Publish::V1::Photo]
        #     The {::Google::Streetview::Publish::V1::Photo Photo} resource, if the request
        #     was successful.
        class PhotoResponse
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Request to list all photos that belong to the user sending the request.
        #
        # By default
        #
        # * does not return the download URL for the photo bytes.
        #
        # Parameters:
        #
        # * `view` controls if the download URL for the photo bytes is returned.
        # * `pageSize` determines the maximum number of photos to return.
        # * `pageToken` is the next page token value returned from a previous
        # {::Google::Streetview::Publish::V1::StreetViewPublishService::Client#list_photos ListPhotos}
        #     request, if any.
        # * `filter` allows filtering by a given parameter. 'placeId' is the only
        # parameter supported at the moment.
        # @!attribute [rw] view
        #   @return [::Google::Streetview::Publish::V1::PhotoView]
        #     Required. Specifies if a download URL for the photos bytes should be returned in the
        #     Photos response.
        # @!attribute [rw] page_size
        #   @return [::Integer]
        #     Optional. The maximum number of photos to return.
        #     `pageSize` must be non-negative. If `pageSize` is zero or is not provided,
        #     the default page size of 100 is used.
        #     The number of photos returned in the response may be less than `pageSize`
        #     if the number of photos that belong to the user is less than `pageSize`.
        # @!attribute [rw] page_token
        #   @return [::String]
        #     Optional. The
        #     {::Google::Streetview::Publish::V1::ListPhotosResponse#next_page_token nextPageToken}
        #     value returned from a previous
        #     {::Google::Streetview::Publish::V1::StreetViewPublishService::Client#list_photos ListPhotos}
        #     request, if any.
        # @!attribute [rw] filter
        #   @return [::String]
        #     Optional. The filter expression. For example: `placeId=ChIJj61dQgK6j4AR4GeTYWZsKWw`.
        #
        #     The filters supported at the moment are: `placeId`.
        # @!attribute [rw] language_code
        #   @return [::String]
        #     Optional. The BCP-47 language code, such as "en-US" or "sr-Latn". For more
        #     information, see
        #     http://www.unicode.org/reports/tr35/#Unicode_locale_identifier.
        #     If language_code is unspecified, the user's language preference for Google
        #     services is used.
        class ListPhotosRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Response to list all photos that belong to a user.
        # @!attribute [rw] photos
        #   @return [::Array<::Google::Streetview::Publish::V1::Photo>]
        #     List of photos. The
        #     {::Google::Streetview::Publish::V1::ListPhotosRequest#page_size pageSize} field
        #     in the request determines the number of items returned.
        # @!attribute [rw] next_page_token
        #   @return [::String]
        #     Token to retrieve the next page of results, or empty if there are no more
        #     results in the list.
        class ListPhotosResponse
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Request to update the metadata of a
        # {::Google::Streetview::Publish::V1::Photo Photo}. Updating the pixels of a photo
        # is not supported.
        # @!attribute [rw] photo
        #   @return [::Google::Streetview::Publish::V1::Photo]
        #     Required. {::Google::Streetview::Publish::V1::Photo Photo} object containing the
        #     new metadata.
        # @!attribute [rw] update_mask
        #   @return [::Google::Protobuf::FieldMask]
        #     Required. Mask that identifies fields on the photo metadata to update.
        #     If not present, the old {::Google::Streetview::Publish::V1::Photo Photo}
        #     metadata is entirely replaced with the
        #     new {::Google::Streetview::Publish::V1::Photo Photo} metadata in this request.
        #     The update fails if invalid fields are specified. Multiple fields can be
        #     specified in a comma-delimited list.
        #
        #     The following fields are valid:
        #
        #     * `pose.heading`
        #     * `pose.latLngPair`
        #     * `pose.pitch`
        #     * `pose.roll`
        #     * `pose.level`
        #     * `pose.altitude`
        #     * `connections`
        #     * `places`
        #
        #
        #     > Note: When
        #     {::Google::Streetview::Publish::V1::UpdatePhotoRequest#update_mask updateMask}
        #     contains repeated fields, the entire set of repeated values get replaced
        #     with the new contents. For example, if
        #     {::Google::Streetview::Publish::V1::UpdatePhotoRequest#update_mask updateMask}
        #     contains `connections` and `UpdatePhotoRequest.photo.connections` is empty,
        #     all connections are removed.
        class UpdatePhotoRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Request to update the metadata of photos.
        # Updating the pixels of photos is not supported.
        # @!attribute [rw] update_photo_requests
        #   @return [::Array<::Google::Streetview::Publish::V1::UpdatePhotoRequest>]
        #     Required. List of
        #     {::Google::Streetview::Publish::V1::UpdatePhotoRequest UpdatePhotoRequests}.
        class BatchUpdatePhotosRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Response to batch update of metadata of one or more
        # {::Google::Streetview::Publish::V1::Photo Photos}.
        # @!attribute [rw] results
        #   @return [::Array<::Google::Streetview::Publish::V1::PhotoResponse>]
        #     List of results for each individual
        #     {::Google::Streetview::Publish::V1::Photo Photo} updated, in the same order as
        #     the request.
        class BatchUpdatePhotosResponse
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Request to delete a {::Google::Streetview::Publish::V1::Photo Photo}.
        # @!attribute [rw] photo_id
        #   @return [::String]
        #     Required. ID of the {::Google::Streetview::Publish::V1::Photo Photo}.
        class DeletePhotoRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Request to delete multiple {::Google::Streetview::Publish::V1::Photo Photos}.
        # @!attribute [rw] photo_ids
        #   @return [::Array<::String>]
        #     Required. IDs of the {::Google::Streetview::Publish::V1::Photo Photos}. HTTP
        #     GET requests require the following syntax for the URL query parameter:
        #     `photoIds=<id1>&photoIds=<id2>&...`.
        class BatchDeletePhotosRequest
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Response to batch delete of one or more
        # {::Google::Streetview::Publish::V1::Photo Photos}.
        # @!attribute [rw] status
        #   @return [::Array<::Google::Rpc::Status>]
        #     The status for the operation to delete a single
        #     {::Google::Streetview::Publish::V1::Photo Photo} in the batch request.
        class BatchDeletePhotosResponse
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end

        # Specifies which view of the {::Google::Streetview::Publish::V1::Photo Photo}
        # to include in the response.
        module PhotoView
          # Server responses do not include the download URL for the photo bytes.
          # The default value.
          BASIC = 0

          # Server responses include the download URL for the photo bytes.
          INCLUDE_DOWNLOAD_URL = 1
        end
      end
    end
  end
end
