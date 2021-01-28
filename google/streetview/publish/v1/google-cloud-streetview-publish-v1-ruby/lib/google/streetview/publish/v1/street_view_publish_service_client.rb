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
#
# EDITING INSTRUCTIONS
# This file was generated from the file
# https://github.com/googleapis/googleapis/blob/master/google/streetview/publish/v1/streetview_publish.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"

require "google/streetview/publish/v1/streetview_publish_pb"
require "google/streetview/publish/v1/credentials"

module Google
  module Streetview
    module Publish
      module V1
        # Publishes and connects user-contributed photos on Street View.
        #
        # @!attribute [r] street_view_publish_service_stub
        #   @return [Google::Streetview::Publish::V1::StreetViewPublishService::Stub]
        class StreetViewPublishServiceClient
          attr_reader :street_view_publish_service_stub

          # The default address of the service.
          SERVICE_ADDRESS = "streetviewpublish.googleapis.com".freeze

          # The default port of the service.
          DEFAULT_SERVICE_PORT = 443

          # The default set of gRPC interceptors.
          GRPC_INTERCEPTORS = []

          DEFAULT_TIMEOUT = 30

          PAGE_DESCRIPTORS = {
            "list_photos" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "photos")
          }.freeze

          private_constant :PAGE_DESCRIPTORS

          # The scopes needed to make gRPC calls to all of the methods defined in
          # this service.
          ALL_SCOPES = [
            "https://www.googleapis.com/auth/streetviewpublish"
          ].freeze


          # @param credentials [Google::Auth::Credentials, String, Hash, GRPC::Core::Channel, GRPC::Core::ChannelCredentials, Proc]
          #   Provides the means for authenticating requests made by the client. This parameter can
          #   be many types.
          #   A `Google::Auth::Credentials` uses a the properties of its represented keyfile for
          #   authenticating requests made by this client.
          #   A `String` will be treated as the path to the keyfile to be used for the construction of
          #   credentials for this client.
          #   A `Hash` will be treated as the contents of a keyfile to be used for the construction of
          #   credentials for this client.
          #   A `GRPC::Core::Channel` will be used to make calls through.
          #   A `GRPC::Core::ChannelCredentials` for the setting up the RPC client. The channel credentials
          #   should already be composed with a `GRPC::Core::CallCredentials` object.
          #   A `Proc` will be used as an updater_proc for the Grpc channel. The proc transforms the
          #   metadata for requests, generally, to give OAuth credentials.
          # @param scopes [Array<String>]
          #   The OAuth scopes for this service. This parameter is ignored if
          #   an updater_proc is supplied.
          # @param client_config [Hash]
          #   A Hash for call options for each method. See
          #   Google::Gax#construct_settings for the structure of
          #   this data. Falls back to the default config if not specified
          #   or the specified config is missing data points.
          # @param timeout [Numeric]
          #   The default timeout, in seconds, for calls made through this client.
          # @param metadata [Hash]
          #   Default metadata to be sent with each request. This can be overridden on a per call basis.
          # @param exception_transformer [Proc]
          #   An optional proc that intercepts any exceptions raised during an API call to inject
          #   custom error handling.
          def initialize \
              credentials: nil,
              scopes: ALL_SCOPES,
              client_config: {},
              timeout: DEFAULT_TIMEOUT,
              metadata: nil,
              exception_transformer: nil,
              lib_name: nil,
              lib_version: ""
            # These require statements are intentionally placed here to initialize
            # the gRPC module only when it's required.
            # See https://github.com/googleapis/toolkit/issues/446
            require "google/gax/grpc"
            require "google/streetview/publish/v1/streetview_publish_services_pb"

            credentials ||= Google::Streetview::Publish::V1::Credentials.default

            if credentials.is_a?(String) || credentials.is_a?(Hash)
              updater_proc = Google::Streetview::Publish::V1::Credentials.new(credentials).updater_proc
            end
            if credentials.is_a?(GRPC::Core::Channel)
              channel = credentials
            end
            if credentials.is_a?(GRPC::Core::ChannelCredentials)
              chan_creds = credentials
            end
            if credentials.is_a?(Proc)
              updater_proc = credentials
            end
            if credentials.is_a?(Google::Auth::Credentials)
              updater_proc = credentials.updater_proc
            end

            package_version = Gem.loaded_specs['google-streetview-publish'].version.version

            google_api_client = "gl-ruby/#{RUBY_VERSION}"
            google_api_client << " #{lib_name}/#{lib_version}" if lib_name
            google_api_client << " gapic/#{package_version} gax/#{Google::Gax::VERSION}"
            google_api_client << " grpc/#{GRPC::VERSION}"
            google_api_client.freeze

            headers = { :"x-goog-api-client" => google_api_client }
            if credentials.respond_to?(:quota_project_id) && credentials.quota_project_id
              headers[:"x-goog-user-project"] = credentials.quota_project_id
            end
            headers.merge!(metadata) unless metadata.nil?
            client_config_file = Pathname.new(__dir__).join(
              "street_view_publish_service_client_config.json"
            )
            defaults = client_config_file.open do |f|
              Google::Gax.construct_settings(
                "google.streetview.publish.v1.StreetViewPublishService",
                JSON.parse(f.read),
                client_config,
                Google::Gax::Grpc::STATUS_CODE_NAMES,
                timeout,
                page_descriptors: PAGE_DESCRIPTORS,
                errors: Google::Gax::Grpc::API_ERRORS,
                metadata: headers
              )
            end

            # Allow overriding the service path/port in subclasses.
            service_path = self.class::SERVICE_ADDRESS
            port = self.class::DEFAULT_SERVICE_PORT
            interceptors = self.class::GRPC_INTERCEPTORS
            @street_view_publish_service_stub = Google::Gax::Grpc.create_stub(
              service_path,
              port,
              chan_creds: chan_creds,
              channel: channel,
              updater_proc: updater_proc,
              scopes: scopes,
              interceptors: interceptors,
              &Google::Streetview::Publish::V1::StreetViewPublishService::Stub.method(:new)
            )

            @start_upload = Google::Gax.create_api_call(
              @street_view_publish_service_stub.method(:start_upload),
              defaults["start_upload"],
              exception_transformer: exception_transformer
            )
            @create_photo = Google::Gax.create_api_call(
              @street_view_publish_service_stub.method(:create_photo),
              defaults["create_photo"],
              exception_transformer: exception_transformer
            )
            @get_photo = Google::Gax.create_api_call(
              @street_view_publish_service_stub.method(:get_photo),
              defaults["get_photo"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'photo_id' => request.photo_id}
              end
            )
            @batch_get_photos = Google::Gax.create_api_call(
              @street_view_publish_service_stub.method(:batch_get_photos),
              defaults["batch_get_photos"],
              exception_transformer: exception_transformer
            )
            @list_photos = Google::Gax.create_api_call(
              @street_view_publish_service_stub.method(:list_photos),
              defaults["list_photos"],
              exception_transformer: exception_transformer
            )
            @update_photo = Google::Gax.create_api_call(
              @street_view_publish_service_stub.method(:update_photo),
              defaults["update_photo"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'photo.photo_id.id' => request.photo.photo_id.id}
              end
            )
            @batch_update_photos = Google::Gax.create_api_call(
              @street_view_publish_service_stub.method(:batch_update_photos),
              defaults["batch_update_photos"],
              exception_transformer: exception_transformer
            )
            @delete_photo = Google::Gax.create_api_call(
              @street_view_publish_service_stub.method(:delete_photo),
              defaults["delete_photo"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'photo_id' => request.photo_id}
              end
            )
            @batch_delete_photos = Google::Gax.create_api_call(
              @street_view_publish_service_stub.method(:batch_delete_photos),
              defaults["batch_delete_photos"],
              exception_transformer: exception_transformer
            )
          end

          # Service calls

          # Creates an upload session to start uploading photo bytes. The method uses
          # the upload URL of the returned
          # {Google::Streetview::Publish::V1::UploadRef UploadRef} to upload the bytes for
          # the {Google::Streetview::Publish::V1::Photo Photo}.
          #
          # In addition to the photo requirements shown in
          # https://support.google.com/maps/answer/7012050?hl=en&ref_topic=6275604,
          # the photo must meet the following requirements:
          #
          # * Photo Sphere XMP metadata must be included in the photo medadata. See
          #   https://developers.google.com/streetview/spherical-metadata for the
          #   required fields.
          # * The pixel size of the photo must meet the size requirements listed in
          #   https://support.google.com/maps/answer/7012050?hl=en&ref_topic=6275604, and
          #   the photo must be a full 360 horizontally.
          #
          # After the upload completes, the method uses
          # {Google::Streetview::Publish::V1::UploadRef UploadRef} with
          # {Google::Streetview::Publish::V1::StreetViewPublishService::CreatePhoto CreatePhoto}
          # to create the {Google::Streetview::Publish::V1::Photo Photo} object entry.
          #
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Streetview::Publish::V1::UploadRef]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Streetview::Publish::V1::UploadRef]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/streetview/publish"
          #
          #   street_view_publish_client = Google::Streetview::Publish.new(version: :v1)
          #   response = street_view_publish_client.start_upload

          def start_upload options: nil, &block
            req = Google::Protobuf::Empty.new
            @start_upload.call(req, options, &block)
          end

          # After the client finishes uploading the photo with the returned
          # {Google::Streetview::Publish::V1::UploadRef UploadRef},
          # {Google::Streetview::Publish::V1::StreetViewPublishService::CreatePhoto CreatePhoto}
          # publishes the uploaded {Google::Streetview::Publish::V1::Photo Photo} to
          # Street View on Google Maps.
          #
          # Currently, the only way to set heading, pitch, and roll in CreatePhoto is
          # through the [Photo Sphere XMP
          # metadata](https://developers.google.com/streetview/spherical-metadata) in
          # the photo bytes. CreatePhoto ignores the `pose.heading`, `pose.pitch`,
          # `pose.roll`, `pose.altitude`, and `pose.level` fields in Pose.
          #
          # This method returns the following error codes:
          #
          # * {Google::Rpc::Code::INVALID_ARGUMENT} if
          #   the request is malformed or if the uploaded photo is not a 360 photo.
          # * {Google::Rpc::Code::NOT_FOUND} if the upload
          #   reference does not exist.
          # * {Google::Rpc::Code::RESOURCE_EXHAUSTED}
          #   if the account has reached the storage limit.
          #
          # @param photo [Google::Streetview::Publish::V1::Photo | Hash]
          #   Required. Photo to create.
          #   A hash of the same form as `Google::Streetview::Publish::V1::Photo`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Streetview::Publish::V1::Photo]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Streetview::Publish::V1::Photo]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/streetview/publish"
          #
          #   street_view_publish_client = Google::Streetview::Publish.new(version: :v1)
          #
          #   # TODO: Initialize `photo`:
          #   photo = {}
          #   response = street_view_publish_client.create_photo(photo)

          def create_photo \
              photo,
              options: nil,
              &block
            req = {
              photo: photo
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Streetview::Publish::V1::CreatePhotoRequest)
            @create_photo.call(req, options, &block)
          end

          # Gets the metadata of the specified
          # {Google::Streetview::Publish::V1::Photo Photo}.
          #
          # This method returns the following error codes:
          #
          # * {Google::Rpc::Code::PERMISSION_DENIED} if
          #   the requesting user did not create the requested
          #   {Google::Streetview::Publish::V1::Photo Photo}.
          # * {Google::Rpc::Code::NOT_FOUND} if the requested
          #   {Google::Streetview::Publish::V1::Photo Photo} does not exist.
          # * {Google::Rpc::Code::UNAVAILABLE} if the
          #   requested {Google::Streetview::Publish::V1::Photo Photo} is still being
          #   indexed.
          #
          # @param photo_id [String]
          #   Required. ID of the {Google::Streetview::Publish::V1::Photo Photo}.
          # @param view [Google::Streetview::Publish::V1::PhotoView]
          #   Specifies if a download URL for the photo bytes should be returned in the
          #   {Google::Streetview::Publish::V1::Photo Photo} response.
          # @param language_code [String]
          #   The BCP-47 language code, such as "en-US" or "sr-Latn". For more
          #   information, see
          #   http://www.unicode.org/reports/tr35/#Unicode_locale_identifier.
          #   If language_code is unspecified, the user's language preference for Google
          #   services is used.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Streetview::Publish::V1::Photo]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Streetview::Publish::V1::Photo]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/streetview/publish"
          #
          #   street_view_publish_client = Google::Streetview::Publish.new(version: :v1)
          #
          #   # TODO: Initialize `photo_id`:
          #   photo_id = ''
          #
          #   # TODO: Initialize `view`:
          #   view = :BASIC
          #   response = street_view_publish_client.get_photo(photo_id, view)

          def get_photo \
              photo_id,
              view,
              language_code: nil,
              options: nil,
              &block
            req = {
              photo_id: photo_id,
              view: view,
              language_code: language_code
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Streetview::Publish::V1::GetPhotoRequest)
            @get_photo.call(req, options, &block)
          end

          # Gets the metadata of the specified
          # {Google::Streetview::Publish::V1::Photo Photo} batch.
          #
          # Note that if
          # {Google::Streetview::Publish::V1::StreetViewPublishService::BatchGetPhotos BatchGetPhotos}
          # fails, either critical fields are missing or there is an authentication
          # error. Even if
          # {Google::Streetview::Publish::V1::StreetViewPublishService::BatchGetPhotos BatchGetPhotos}
          # succeeds, individual photos in the batch may have failures.
          # These failures are specified in each
          # {Google::Streetview::Publish::V1::PhotoResponse#status PhotoResponse#status}
          # in
          # {Google::Streetview::Publish::V1::BatchGetPhotosResponse#results BatchGetPhotosResponse#results}.
          # See
          # {Google::Streetview::Publish::V1::StreetViewPublishService::GetPhoto GetPhoto}
          # for specific failures that can occur per photo.
          #
          # @param photo_ids [Array<String>]
          #   Required. IDs of the {Google::Streetview::Publish::V1::Photo Photos}. HTTP GET
          #   requests require the following syntax for the URL query parameter:
          #   `photoIds=<id1>&photoIds=<id2>&...`.
          # @param view [Google::Streetview::Publish::V1::PhotoView]
          #   Specifies if a download URL for the photo bytes should be returned in the
          #   Photo response.
          # @param language_code [String]
          #   The BCP-47 language code, such as "en-US" or "sr-Latn". For more
          #   information, see
          #   http://www.unicode.org/reports/tr35/#Unicode_locale_identifier.
          #   If language_code is unspecified, the user's language preference for Google
          #   services is used.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Streetview::Publish::V1::BatchGetPhotosResponse]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Streetview::Publish::V1::BatchGetPhotosResponse]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/streetview/publish"
          #
          #   street_view_publish_client = Google::Streetview::Publish.new(version: :v1)
          #
          #   # TODO: Initialize `photo_ids`:
          #   photo_ids = []
          #
          #   # TODO: Initialize `view`:
          #   view = :BASIC
          #   response = street_view_publish_client.batch_get_photos(photo_ids, view)

          def batch_get_photos \
              photo_ids,
              view,
              language_code: nil,
              options: nil,
              &block
            req = {
              photo_ids: photo_ids,
              view: view,
              language_code: language_code
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Streetview::Publish::V1::BatchGetPhotosRequest)
            @batch_get_photos.call(req, options, &block)
          end

          # Lists all the {Google::Streetview::Publish::V1::Photo Photos} that belong to
          # the user.
          #
          # <aside class="note"><b>Note:</b> Recently created photos that are still
          # being indexed are not returned in the response.</aside>
          #
          # @param view [Google::Streetview::Publish::V1::PhotoView]
          #   Specifies if a download URL for the photos bytes should be returned in the
          #   Photos response.
          # @param filter [String]
          #   The filter expression. For example: `placeId=ChIJj61dQgK6j4AR4GeTYWZsKWw`.
          #
          #   The only filter supported at the moment is `placeId`.
          # @param page_size [Integer]
          #   The maximum number of resources contained in the underlying API
          #   response. If page streaming is performed per-resource, this
          #   parameter does not affect the return value. If page streaming is
          #   performed per-page, this determines the maximum number of
          #   resources in a page.
          # @param language_code [String]
          #   The BCP-47 language code, such as "en-US" or "sr-Latn". For more
          #   information, see
          #   http://www.unicode.org/reports/tr35/#Unicode_locale_identifier.
          #   If language_code is unspecified, the user's language preference for Google
          #   services is used.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Streetview::Publish::V1::Photo>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Streetview::Publish::V1::Photo>]
          #   An enumerable of Google::Streetview::Publish::V1::Photo instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/streetview/publish"
          #
          #   street_view_publish_client = Google::Streetview::Publish.new(version: :v1)
          #
          #   # TODO: Initialize `view`:
          #   view = :BASIC
          #
          #   # TODO: Initialize `filter`:
          #   filter = ''
          #
          #   # Iterate over all results.
          #   street_view_publish_client.list_photos(view, filter).each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   street_view_publish_client.list_photos(view, filter).each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_photos \
              view,
              filter,
              page_size: nil,
              language_code: nil,
              options: nil,
              &block
            req = {
              view: view,
              filter: filter,
              page_size: page_size,
              language_code: language_code
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Streetview::Publish::V1::ListPhotosRequest)
            @list_photos.call(req, options, &block)
          end

          # Updates the metadata of a {Google::Streetview::Publish::V1::Photo Photo}, such
          # as pose, place association, connections, etc. Changing the pixels of a
          # photo is not supported.
          #
          # Only the fields specified in the
          # {Google::Streetview::Publish::V1::UpdatePhotoRequest#update_mask updateMask}
          # field are used. If `updateMask` is not present, the update applies to all
          # fields.
          #
          # This method returns the following error codes:
          #
          # * {Google::Rpc::Code::PERMISSION_DENIED} if
          #   the requesting user did not create the requested photo.
          # * {Google::Rpc::Code::INVALID_ARGUMENT} if
          #   the request is malformed.
          # * {Google::Rpc::Code::NOT_FOUND} if the requested
          #   photo does not exist.
          # * {Google::Rpc::Code::UNAVAILABLE} if the
          #   requested {Google::Streetview::Publish::V1::Photo Photo} is still being
          #   indexed.
          #
          # @param photo [Google::Streetview::Publish::V1::Photo | Hash]
          #   Required. {Google::Streetview::Publish::V1::Photo Photo} object containing the
          #   new metadata.
          #   A hash of the same form as `Google::Streetview::Publish::V1::Photo`
          #   can also be provided.
          # @param update_mask [Google::Protobuf::FieldMask | Hash]
          #   Mask that identifies fields on the photo metadata to update.
          #   If not present, the old {Google::Streetview::Publish::V1::Photo Photo}
          #   metadata is entirely replaced with the
          #   new {Google::Streetview::Publish::V1::Photo Photo} metadata in this request.
          #   The update fails if invalid fields are specified. Multiple fields can be
          #   specified in a comma-delimited list.
          #
          #   The following fields are valid:
          #
          #   * `pose.heading`
          #   * `pose.latLngPair`
          #   * `pose.pitch`
          #   * `pose.roll`
          #   * `pose.level`
          #   * `pose.altitude`
          #   * `connections`
          #   * `places`
          #
          #
          #   <aside class="note"><b>Note:</b>  When
          #   {Google::Streetview::Publish::V1::UpdatePhotoRequest#update_mask updateMask}
          #   contains repeated fields, the entire set of repeated values get replaced
          #   with the new contents. For example, if
          #   {Google::Streetview::Publish::V1::UpdatePhotoRequest#update_mask updateMask}
          #   contains `connections` and `UpdatePhotoRequest.photo.connections` is empty,
          #   all connections are removed.</aside>
          #   A hash of the same form as `Google::Protobuf::FieldMask`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Streetview::Publish::V1::Photo]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Streetview::Publish::V1::Photo]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/streetview/publish"
          #
          #   street_view_publish_client = Google::Streetview::Publish.new(version: :v1)
          #
          #   # TODO: Initialize `photo`:
          #   photo = {}
          #
          #   # TODO: Initialize `update_mask`:
          #   update_mask = {}
          #   response = street_view_publish_client.update_photo(photo, update_mask)

          def update_photo \
              photo,
              update_mask,
              options: nil,
              &block
            req = {
              photo: photo,
              update_mask: update_mask
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Streetview::Publish::V1::UpdatePhotoRequest)
            @update_photo.call(req, options, &block)
          end

          # Updates the metadata of {Google::Streetview::Publish::V1::Photo Photos}, such
          # as pose, place association, connections, etc. Changing the pixels of photos
          # is not supported.
          #
          # Note that if
          # {Google::Streetview::Publish::V1::StreetViewPublishService::BatchUpdatePhotos BatchUpdatePhotos}
          # fails, either critical fields are missing or there is an authentication
          # error. Even if
          # {Google::Streetview::Publish::V1::StreetViewPublishService::BatchUpdatePhotos BatchUpdatePhotos}
          # succeeds, individual photos in the batch may have failures.
          # These failures are specified in each
          # {Google::Streetview::Publish::V1::PhotoResponse#status PhotoResponse#status}
          # in
          # {Google::Streetview::Publish::V1::BatchUpdatePhotosResponse#results BatchUpdatePhotosResponse#results}.
          # See
          # {Google::Streetview::Publish::V1::StreetViewPublishService::UpdatePhoto UpdatePhoto}
          # for specific failures that can occur per photo.
          #
          # Only the fields specified in
          # {Google::Streetview::Publish::V1::UpdatePhotoRequest#update_mask updateMask}
          # field are used. If `updateMask` is not present, the update applies to all
          # fields.
          #
          # The number of
          # {Google::Streetview::Publish::V1::UpdatePhotoRequest UpdatePhotoRequest}
          # messages in a
          # {Google::Streetview::Publish::V1::BatchUpdatePhotosRequest BatchUpdatePhotosRequest}
          # must not exceed 20.
          #
          # <aside class="note"><b>Note:</b> To update
          # {Google::Streetview::Publish::V1::Pose#altitude Pose#altitude},
          # {Google::Streetview::Publish::V1::Pose#lat_lng_pair Pose#latLngPair} has to be
          # filled as well. Otherwise, the request will fail.</aside>
          #
          # @param update_photo_requests [Array<Google::Streetview::Publish::V1::UpdatePhotoRequest | Hash>]
          #   Required. List of
          #   {Google::Streetview::Publish::V1::UpdatePhotoRequest UpdatePhotoRequests}.
          #   A hash of the same form as `Google::Streetview::Publish::V1::UpdatePhotoRequest`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Streetview::Publish::V1::BatchUpdatePhotosResponse]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Streetview::Publish::V1::BatchUpdatePhotosResponse]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/streetview/publish"
          #
          #   street_view_publish_client = Google::Streetview::Publish.new(version: :v1)
          #
          #   # TODO: Initialize `update_photo_requests`:
          #   update_photo_requests = []
          #   response = street_view_publish_client.batch_update_photos(update_photo_requests)

          def batch_update_photos \
              update_photo_requests,
              options: nil,
              &block
            req = {
              update_photo_requests: update_photo_requests
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Streetview::Publish::V1::BatchUpdatePhotosRequest)
            @batch_update_photos.call(req, options, &block)
          end

          # Deletes a {Google::Streetview::Publish::V1::Photo Photo} and its metadata.
          #
          # This method returns the following error codes:
          #
          # * {Google::Rpc::Code::PERMISSION_DENIED} if
          #   the requesting user did not create the requested photo.
          # * {Google::Rpc::Code::NOT_FOUND} if the photo ID
          #   does not exist.
          #
          # @param photo_id [String]
          #   Required. ID of the {Google::Streetview::Publish::V1::Photo Photo}.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result []
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/streetview/publish"
          #
          #   street_view_publish_client = Google::Streetview::Publish.new(version: :v1)
          #
          #   # TODO: Initialize `photo_id`:
          #   photo_id = ''
          #   street_view_publish_client.delete_photo(photo_id)

          def delete_photo \
              photo_id,
              options: nil,
              &block
            req = {
              photo_id: photo_id
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Streetview::Publish::V1::DeletePhotoRequest)
            @delete_photo.call(req, options, &block)
            nil
          end

          # Deletes a list of {Google::Streetview::Publish::V1::Photo Photos} and their
          # metadata.
          #
          # Note that if
          # {Google::Streetview::Publish::V1::StreetViewPublishService::BatchDeletePhotos BatchDeletePhotos}
          # fails, either critical fields are missing or there was an authentication
          # error. Even if
          # {Google::Streetview::Publish::V1::StreetViewPublishService::BatchDeletePhotos BatchDeletePhotos}
          # succeeds, individual photos in the batch may have failures.
          # These failures are specified in each
          # {Google::Streetview::Publish::V1::PhotoResponse#status PhotoResponse#status}
          # in
          # {Google::Streetview::Publish::V1::BatchDeletePhotosResponse#status BatchDeletePhotosResponse#results}.
          # See
          # {Google::Streetview::Publish::V1::StreetViewPublishService::DeletePhoto DeletePhoto}
          # for specific failures that can occur per photo.
          #
          # @param photo_ids [Array<String>]
          #   Required. IDs of the {Google::Streetview::Publish::V1::Photo Photos}. HTTP
          #   GET requests require the following syntax for the URL query parameter:
          #   `photoIds=<id1>&photoIds=<id2>&...`.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Streetview::Publish::V1::BatchDeletePhotosResponse]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Streetview::Publish::V1::BatchDeletePhotosResponse]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/streetview/publish"
          #
          #   street_view_publish_client = Google::Streetview::Publish.new(version: :v1)
          #
          #   # TODO: Initialize `photo_ids`:
          #   photo_ids = []
          #   response = street_view_publish_client.batch_delete_photos(photo_ids)

          def batch_delete_photos \
              photo_ids,
              options: nil,
              &block
            req = {
              photo_ids: photo_ids
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Streetview::Publish::V1::BatchDeletePhotosRequest)
            @batch_delete_photos.call(req, options, &block)
          end
        end
      end
    end
  end
end
