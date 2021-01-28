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
# https://github.com/googleapis/googleapis/blob/master/google/example/library/v1/library.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"

require "google/example/library/v1/library_pb"
require "google/cloud/example/library/v1/credentials"

module Google
  module Cloud
    module Example
      module Library
        module V1
          # This API represents a simple digital library.  It lets you manage Shelf
          # resources and Book resources in the library. It defines the following
          # resource model:
          #
          # * The API has a collection of {Google::Example::Library::V1::Shelf Shelf}
          #   resources, named `shelves/*`
          #
          # * Each Shelf has a collection of {Google::Example::Library::V1::Book Book}
          #   resources, named `shelves/*/books/*`
          #
          # @!attribute [r] library_service_stub
          #   @return [Google::Example::Library::V1::LibraryService::Stub]
          class LibraryServiceClient
            attr_reader :library_service_stub

            # The default address of the service.
            SERVICE_ADDRESS = "library-example.googleapis.com".freeze

            # The default port of the service.
            DEFAULT_SERVICE_PORT = 443

            # The default set of gRPC interceptors.
            GRPC_INTERCEPTORS = []

            DEFAULT_TIMEOUT = 30

            PAGE_DESCRIPTORS = {
              "list_shelves" => Google::Gax::PageDescriptor.new(
                "page_token",
                "next_page_token",
                "shelves"),
              "list_books" => Google::Gax::PageDescriptor.new(
                "page_token",
                "next_page_token",
                "books")
            }.freeze

            private_constant :PAGE_DESCRIPTORS

            # The scopes needed to make gRPC calls to all of the methods defined in
            # this service.
            ALL_SCOPES = [
            ].freeze


            BOOK_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
              "shelves/{shelf}/books/{book}"
            )

            private_constant :BOOK_PATH_TEMPLATE

            SHELF_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
              "shelves/{shelf}"
            )

            private_constant :SHELF_PATH_TEMPLATE

            # Returns a fully-qualified book resource name string.
            # @param shelf [String]
            # @param book [String]
            # @return [String]
            def self.book_path shelf, book
              BOOK_PATH_TEMPLATE.render(
                :"shelf" => shelf,
                :"book" => book
              )
            end

            # Returns a fully-qualified shelf resource name string.
            # @param shelf [String]
            # @return [String]
            def self.shelf_path shelf
              SHELF_PATH_TEMPLATE.render(
                :"shelf" => shelf
              )
            end

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
              require "google/example/library/v1/library_services_pb"

              credentials ||= Google::Cloud::Example::Library::V1::Credentials.default

              if credentials.is_a?(String) || credentials.is_a?(Hash)
                updater_proc = Google::Cloud::Example::Library::V1::Credentials.new(credentials).updater_proc
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

              package_version = Gem.loaded_specs['google-cloud-example-library'].version.version

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
                "library_service_client_config.json"
              )
              defaults = client_config_file.open do |f|
                Google::Gax.construct_settings(
                  "google.example.library.v1.LibraryService",
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
              @library_service_stub = Google::Gax::Grpc.create_stub(
                service_path,
                port,
                chan_creds: chan_creds,
                channel: channel,
                updater_proc: updater_proc,
                scopes: scopes,
                interceptors: interceptors,
                &Google::Example::Library::V1::LibraryService::Stub.method(:new)
              )

              @create_shelf = Google::Gax.create_api_call(
                @library_service_stub.method(:create_shelf),
                defaults["create_shelf"],
                exception_transformer: exception_transformer
              )
              @get_shelf = Google::Gax.create_api_call(
                @library_service_stub.method(:get_shelf),
                defaults["get_shelf"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @list_shelves = Google::Gax.create_api_call(
                @library_service_stub.method(:list_shelves),
                defaults["list_shelves"],
                exception_transformer: exception_transformer
              )
              @delete_shelf = Google::Gax.create_api_call(
                @library_service_stub.method(:delete_shelf),
                defaults["delete_shelf"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @merge_shelves = Google::Gax.create_api_call(
                @library_service_stub.method(:merge_shelves),
                defaults["merge_shelves"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @create_book = Google::Gax.create_api_call(
                @library_service_stub.method(:create_book),
                defaults["create_book"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @get_book = Google::Gax.create_api_call(
                @library_service_stub.method(:get_book),
                defaults["get_book"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @list_books = Google::Gax.create_api_call(
                @library_service_stub.method(:list_books),
                defaults["list_books"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @delete_book = Google::Gax.create_api_call(
                @library_service_stub.method(:delete_book),
                defaults["delete_book"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @update_book = Google::Gax.create_api_call(
                @library_service_stub.method(:update_book),
                defaults["update_book"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'book.name' => request.book.name}
                end
              )
              @move_book = Google::Gax.create_api_call(
                @library_service_stub.method(:move_book),
                defaults["move_book"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
            end

            # Service calls

            # Creates a shelf, and returns the new Shelf.
            #
            # @param shelf [Google::Example::Library::V1::Shelf | Hash]
            #   The shelf to create.
            #   A hash of the same form as `Google::Example::Library::V1::Shelf`
            #   can also be provided.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Example::Library::V1::Shelf]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Example::Library::V1::Shelf]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/example/library"
            #
            #   library_client = Google::Cloud::Example::Library.new(version: :v1)
            #
            #   # TODO: Initialize `shelf`:
            #   shelf = {}
            #   response = library_client.create_shelf(shelf)

            def create_shelf \
                shelf,
                options: nil,
                &block
              req = {
                shelf: shelf
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Example::Library::V1::CreateShelfRequest)
              @create_shelf.call(req, options, &block)
            end

            # Gets a shelf. Returns NOT_FOUND if the shelf does not exist.
            #
            # @param name [String]
            #   The name of the shelf to retrieve.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Example::Library::V1::Shelf]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Example::Library::V1::Shelf]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/example/library"
            #
            #   library_client = Google::Cloud::Example::Library.new(version: :v1)
            #   formatted_name = Google::Cloud::Example::Library::V1::LibraryServiceClient.shelf_path("[SHELF]")
            #   response = library_client.get_shelf(formatted_name)

            def get_shelf \
                name,
                options: nil,
                &block
              req = {
                name: name
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Example::Library::V1::GetShelfRequest)
              @get_shelf.call(req, options, &block)
            end

            # Lists shelves. The order is unspecified but deterministic. Newly created
            # shelves will not necessarily be added to the end of this list.
            #
            # @param page_size [Integer]
            #   The maximum number of resources contained in the underlying API
            #   response. If page streaming is performed per-resource, this
            #   parameter does not affect the return value. If page streaming is
            #   performed per-page, this determines the maximum number of
            #   resources in a page.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Gax::PagedEnumerable<Google::Example::Library::V1::Shelf>]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Gax::PagedEnumerable<Google::Example::Library::V1::Shelf>]
            #   An enumerable of Google::Example::Library::V1::Shelf instances.
            #   See Google::Gax::PagedEnumerable documentation for other
            #   operations such as per-page iteration or access to the response
            #   object.
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/example/library"
            #
            #   library_client = Google::Cloud::Example::Library.new(version: :v1)
            #
            #   # Iterate over all results.
            #   library_client.list_shelves.each do |element|
            #     # Process element.
            #   end
            #
            #   # Or iterate over results one page at a time.
            #   library_client.list_shelves.each_page do |page|
            #     # Process each page at a time.
            #     page.each do |element|
            #       # Process element.
            #     end
            #   end

            def list_shelves \
                page_size: nil,
                options: nil,
                &block
              req = {
                page_size: page_size
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Example::Library::V1::ListShelvesRequest)
              @list_shelves.call(req, options, &block)
            end

            # Deletes a shelf. Returns NOT_FOUND if the shelf does not exist.
            #
            # @param name [String]
            #   The name of the shelf to delete.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result []
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/example/library"
            #
            #   library_client = Google::Cloud::Example::Library.new(version: :v1)
            #   formatted_name = Google::Cloud::Example::Library::V1::LibraryServiceClient.shelf_path("[SHELF]")
            #   library_client.delete_shelf(formatted_name)

            def delete_shelf \
                name,
                options: nil,
                &block
              req = {
                name: name
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Example::Library::V1::DeleteShelfRequest)
              @delete_shelf.call(req, options, &block)
              nil
            end

            # Merges two shelves by adding all books from the shelf named
            # `other_shelf_name` to shelf `name`, and deletes
            # `other_shelf_name`. Returns the updated shelf.
            # The book ids of the moved books may not be the same as the original books.
            #
            # Returns NOT_FOUND if either shelf does not exist.
            # This call is a no-op if the specified shelves are the same.
            #
            # @param name [String]
            #   The name of the shelf we're adding books to.
            # @param other_shelf_name [String]
            #   The name of the shelf we're removing books from and deleting.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Example::Library::V1::Shelf]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Example::Library::V1::Shelf]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/example/library"
            #
            #   library_client = Google::Cloud::Example::Library.new(version: :v1)
            #   formatted_name = Google::Cloud::Example::Library::V1::LibraryServiceClient.shelf_path("[SHELF]")
            #
            #   # TODO: Initialize `other_shelf_name`:
            #   other_shelf_name = ''
            #   response = library_client.merge_shelves(formatted_name, other_shelf_name)

            def merge_shelves \
                name,
                other_shelf_name,
                options: nil,
                &block
              req = {
                name: name,
                other_shelf_name: other_shelf_name
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Example::Library::V1::MergeShelvesRequest)
              @merge_shelves.call(req, options, &block)
            end

            # Creates a book, and returns the new Book.
            #
            # @param name [String]
            #   The name of the shelf in which the book is created.
            # @param book [Google::Example::Library::V1::Book | Hash]
            #   The book to create.
            #   A hash of the same form as `Google::Example::Library::V1::Book`
            #   can also be provided.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Example::Library::V1::Book]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Example::Library::V1::Book]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/example/library"
            #
            #   library_client = Google::Cloud::Example::Library.new(version: :v1)
            #   formatted_name = Google::Cloud::Example::Library::V1::LibraryServiceClient.shelf_path("[SHELF]")
            #
            #   # TODO: Initialize `book`:
            #   book = {}
            #   response = library_client.create_book(formatted_name, book)

            def create_book \
                name,
                book,
                options: nil,
                &block
              req = {
                name: name,
                book: book
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Example::Library::V1::CreateBookRequest)
              @create_book.call(req, options, &block)
            end

            # Gets a book. Returns NOT_FOUND if the book does not exist.
            #
            # @param name [String]
            #   The name of the book to retrieve.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Example::Library::V1::Book]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Example::Library::V1::Book]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/example/library"
            #
            #   library_client = Google::Cloud::Example::Library.new(version: :v1)
            #   formatted_name = Google::Cloud::Example::Library::V1::LibraryServiceClient.book_path("[SHELF]", "[BOOK]")
            #   response = library_client.get_book(formatted_name)

            def get_book \
                name,
                options: nil,
                &block
              req = {
                name: name
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Example::Library::V1::GetBookRequest)
              @get_book.call(req, options, &block)
            end

            # Lists books in a shelf. The order is unspecified but deterministic. Newly
            # created books will not necessarily be added to the end of this list.
            # Returns NOT_FOUND if the shelf does not exist.
            #
            # @param name [String]
            #   The name of the shelf whose books we'd like to list.
            # @param page_size [Integer]
            #   The maximum number of resources contained in the underlying API
            #   response. If page streaming is performed per-resource, this
            #   parameter does not affect the return value. If page streaming is
            #   performed per-page, this determines the maximum number of
            #   resources in a page.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Gax::PagedEnumerable<Google::Example::Library::V1::Book>]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Gax::PagedEnumerable<Google::Example::Library::V1::Book>]
            #   An enumerable of Google::Example::Library::V1::Book instances.
            #   See Google::Gax::PagedEnumerable documentation for other
            #   operations such as per-page iteration or access to the response
            #   object.
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/example/library"
            #
            #   library_client = Google::Cloud::Example::Library.new(version: :v1)
            #   formatted_name = Google::Cloud::Example::Library::V1::LibraryServiceClient.shelf_path("[SHELF]")
            #
            #   # Iterate over all results.
            #   library_client.list_books(formatted_name).each do |element|
            #     # Process element.
            #   end
            #
            #   # Or iterate over results one page at a time.
            #   library_client.list_books(formatted_name).each_page do |page|
            #     # Process each page at a time.
            #     page.each do |element|
            #       # Process element.
            #     end
            #   end

            def list_books \
                name,
                page_size: nil,
                options: nil,
                &block
              req = {
                name: name,
                page_size: page_size
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Example::Library::V1::ListBooksRequest)
              @list_books.call(req, options, &block)
            end

            # Deletes a book. Returns NOT_FOUND if the book does not exist.
            #
            # @param name [String]
            #   The name of the book to delete.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result []
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/example/library"
            #
            #   library_client = Google::Cloud::Example::Library.new(version: :v1)
            #   formatted_name = Google::Cloud::Example::Library::V1::LibraryServiceClient.book_path("[SHELF]", "[BOOK]")
            #   library_client.delete_book(formatted_name)

            def delete_book \
                name,
                options: nil,
                &block
              req = {
                name: name
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Example::Library::V1::DeleteBookRequest)
              @delete_book.call(req, options, &block)
              nil
            end

            # Updates a book. Returns INVALID_ARGUMENT if the name of the book
            # is non-empty and does not equal the existing name.
            #
            # @param name [String]
            #   The name of the book to update.
            # @param book [Google::Example::Library::V1::Book | Hash]
            #   The book to update with. The name must match or be empty.
            #   A hash of the same form as `Google::Example::Library::V1::Book`
            #   can also be provided.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Example::Library::V1::Book]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Example::Library::V1::Book]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/example/library"
            #
            #   library_client = Google::Cloud::Example::Library.new(version: :v1)
            #
            #   # TODO: Initialize `name`:
            #   name = ''
            #
            #   # TODO: Initialize `book`:
            #   book = {}
            #   response = library_client.update_book(name, book)

            def update_book \
                name,
                book,
                options: nil,
                &block
              req = {
                name: name,
                book: book
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Example::Library::V1::UpdateBookRequest)
              @update_book.call(req, options, &block)
            end

            # Moves a book to another shelf, and returns the new book. The book
            # id of the new book may not be the same as the original book.
            #
            # @param name [String]
            #   The name of the book to move.
            # @param other_shelf_name [String]
            #   The name of the destination shelf.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Example::Library::V1::Book]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Example::Library::V1::Book]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/example/library"
            #
            #   library_client = Google::Cloud::Example::Library.new(version: :v1)
            #   formatted_name = Google::Cloud::Example::Library::V1::LibraryServiceClient.book_path("[SHELF]", "[BOOK]")
            #
            #   # TODO: Initialize `other_shelf_name`:
            #   other_shelf_name = ''
            #   response = library_client.move_book(formatted_name, other_shelf_name)

            def move_book \
                name,
                other_shelf_name,
                options: nil,
                &block
              req = {
                name: name,
                other_shelf_name: other_shelf_name
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Example::Library::V1::MoveBookRequest)
              @move_book.call(req, options, &block)
            end
          end
        end
      end
    end
  end
end
