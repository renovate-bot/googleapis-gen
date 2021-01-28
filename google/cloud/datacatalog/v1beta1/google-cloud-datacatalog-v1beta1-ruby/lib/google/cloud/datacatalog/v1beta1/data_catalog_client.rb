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
# https://github.com/googleapis/googleapis/blob/master/google/cloud/datacatalog/v1beta1/datacatalog.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"

require "google/cloud/datacatalog/v1beta1/datacatalog_pb"
require "google/cloud/datacatalog/v1beta1/credentials"

module Google
  module Cloud
    module Datacatalog
      module V1beta1
        # Data Catalog API service allows clients to discover, understand, and manage
        # their data.
        #
        # @!attribute [r] data_catalog_stub
        #   @return [Google::Cloud::Datacatalog::V1beta1::DataCatalog::Stub]
        class DataCatalogClient
          attr_reader :data_catalog_stub

          # The default address of the service.
          SERVICE_ADDRESS = "datacatalog.googleapis.com".freeze

          # The default port of the service.
          DEFAULT_SERVICE_PORT = 443

          # The default set of gRPC interceptors.
          GRPC_INTERCEPTORS = []

          DEFAULT_TIMEOUT = 30

          PAGE_DESCRIPTORS = {
            "search_catalog" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "results"),
            "list_entry_groups" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "entry_groups"),
            "list_entries" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "entries"),
            "list_tags" => Google::Gax::PageDescriptor.new(
              "page_token",
              "next_page_token",
              "tags")
          }.freeze

          private_constant :PAGE_DESCRIPTORS

          # The scopes needed to make gRPC calls to all of the methods defined in
          # this service.
          ALL_SCOPES = [
            "https://www.googleapis.com/auth/cloud-platform"
          ].freeze


          ENTRY_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}/entryGroups/{entry_group}/entries/{entry}"
          )

          private_constant :ENTRY_PATH_TEMPLATE

          ENTRY_GROUP_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}/entryGroups/{entry_group}"
          )

          private_constant :ENTRY_GROUP_PATH_TEMPLATE

          LOCATION_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}"
          )

          private_constant :LOCATION_PATH_TEMPLATE

          TAG_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}/entryGroups/{entry_group}/entries/{entry}/tags/{tag}"
          )

          private_constant :TAG_PATH_TEMPLATE

          TAG_TEMPLATE_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}/tagTemplates/{tag_template}"
          )

          private_constant :TAG_TEMPLATE_PATH_TEMPLATE

          TAG_TEMPLATE_FIELD_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
            "projects/{project}/locations/{location}/tagTemplates/{tag_template}/fields/{field}"
          )

          private_constant :TAG_TEMPLATE_FIELD_PATH_TEMPLATE

          # Returns a fully-qualified entry resource name string.
          # @param project [String]
          # @param location [String]
          # @param entry_group [String]
          # @param entry [String]
          # @return [String]
          def self.entry_path project, location, entry_group, entry
            ENTRY_PATH_TEMPLATE.render(
              :"project" => project,
              :"location" => location,
              :"entry_group" => entry_group,
              :"entry" => entry
            )
          end

          # Returns a fully-qualified entry_group resource name string.
          # @param project [String]
          # @param location [String]
          # @param entry_group [String]
          # @return [String]
          def self.entry_group_path project, location, entry_group
            ENTRY_GROUP_PATH_TEMPLATE.render(
              :"project" => project,
              :"location" => location,
              :"entry_group" => entry_group
            )
          end

          # Returns a fully-qualified location resource name string.
          # @param project [String]
          # @param location [String]
          # @return [String]
          def self.location_path project, location
            LOCATION_PATH_TEMPLATE.render(
              :"project" => project,
              :"location" => location
            )
          end

          # Returns a fully-qualified tag resource name string.
          # @param project [String]
          # @param location [String]
          # @param entry_group [String]
          # @param entry [String]
          # @param tag [String]
          # @return [String]
          def self.tag_path project, location, entry_group, entry, tag
            TAG_PATH_TEMPLATE.render(
              :"project" => project,
              :"location" => location,
              :"entry_group" => entry_group,
              :"entry" => entry,
              :"tag" => tag
            )
          end

          # Returns a fully-qualified tag_template resource name string.
          # @param project [String]
          # @param location [String]
          # @param tag_template [String]
          # @return [String]
          def self.tag_template_path project, location, tag_template
            TAG_TEMPLATE_PATH_TEMPLATE.render(
              :"project" => project,
              :"location" => location,
              :"tag_template" => tag_template
            )
          end

          # Returns a fully-qualified tag_template_field resource name string.
          # @param project [String]
          # @param location [String]
          # @param tag_template [String]
          # @param field [String]
          # @return [String]
          def self.tag_template_field_path project, location, tag_template, field
            TAG_TEMPLATE_FIELD_PATH_TEMPLATE.render(
              :"project" => project,
              :"location" => location,
              :"tag_template" => tag_template,
              :"field" => field
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
            require "google/cloud/datacatalog/v1beta1/datacatalog_services_pb"

            credentials ||= Google::Cloud::Datacatalog::V1beta1::Credentials.default

            if credentials.is_a?(String) || credentials.is_a?(Hash)
              updater_proc = Google::Cloud::Datacatalog::V1beta1::Credentials.new(credentials).updater_proc
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

            package_version = Gem.loaded_specs['google-cloud-datacatalog'].version.version

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
              "data_catalog_client_config.json"
            )
            defaults = client_config_file.open do |f|
              Google::Gax.construct_settings(
                "google.cloud.datacatalog.v1beta1.DataCatalog",
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
            @data_catalog_stub = Google::Gax::Grpc.create_stub(
              service_path,
              port,
              chan_creds: chan_creds,
              channel: channel,
              updater_proc: updater_proc,
              scopes: scopes,
              interceptors: interceptors,
              &Google::Cloud::Datacatalog::V1beta1::DataCatalog::Stub.method(:new)
            )

            @search_catalog = Google::Gax.create_api_call(
              @data_catalog_stub.method(:search_catalog),
              defaults["search_catalog"],
              exception_transformer: exception_transformer
            )
            @get_entry = Google::Gax.create_api_call(
              @data_catalog_stub.method(:get_entry),
              defaults["get_entry"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @lookup_entry = Google::Gax.create_api_call(
              @data_catalog_stub.method(:lookup_entry),
              defaults["lookup_entry"],
              exception_transformer: exception_transformer
            )
            @create_entry_group = Google::Gax.create_api_call(
              @data_catalog_stub.method(:create_entry_group),
              defaults["create_entry_group"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @update_entry_group = Google::Gax.create_api_call(
              @data_catalog_stub.method(:update_entry_group),
              defaults["update_entry_group"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'entry_group.name' => request.entry_group.name}
              end
            )
            @get_entry_group = Google::Gax.create_api_call(
              @data_catalog_stub.method(:get_entry_group),
              defaults["get_entry_group"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @delete_entry_group = Google::Gax.create_api_call(
              @data_catalog_stub.method(:delete_entry_group),
              defaults["delete_entry_group"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @list_entry_groups = Google::Gax.create_api_call(
              @data_catalog_stub.method(:list_entry_groups),
              defaults["list_entry_groups"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @create_entry = Google::Gax.create_api_call(
              @data_catalog_stub.method(:create_entry),
              defaults["create_entry"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @update_entry = Google::Gax.create_api_call(
              @data_catalog_stub.method(:update_entry),
              defaults["update_entry"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'entry.name' => request.entry.name}
              end
            )
            @delete_entry = Google::Gax.create_api_call(
              @data_catalog_stub.method(:delete_entry),
              defaults["delete_entry"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @list_entries = Google::Gax.create_api_call(
              @data_catalog_stub.method(:list_entries),
              defaults["list_entries"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @create_tag_template = Google::Gax.create_api_call(
              @data_catalog_stub.method(:create_tag_template),
              defaults["create_tag_template"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @get_tag_template = Google::Gax.create_api_call(
              @data_catalog_stub.method(:get_tag_template),
              defaults["get_tag_template"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @update_tag_template = Google::Gax.create_api_call(
              @data_catalog_stub.method(:update_tag_template),
              defaults["update_tag_template"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'tag_template.name' => request.tag_template.name}
              end
            )
            @delete_tag_template = Google::Gax.create_api_call(
              @data_catalog_stub.method(:delete_tag_template),
              defaults["delete_tag_template"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @create_tag_template_field = Google::Gax.create_api_call(
              @data_catalog_stub.method(:create_tag_template_field),
              defaults["create_tag_template_field"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @update_tag_template_field = Google::Gax.create_api_call(
              @data_catalog_stub.method(:update_tag_template_field),
              defaults["update_tag_template_field"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @rename_tag_template_field = Google::Gax.create_api_call(
              @data_catalog_stub.method(:rename_tag_template_field),
              defaults["rename_tag_template_field"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @delete_tag_template_field = Google::Gax.create_api_call(
              @data_catalog_stub.method(:delete_tag_template_field),
              defaults["delete_tag_template_field"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @create_tag = Google::Gax.create_api_call(
              @data_catalog_stub.method(:create_tag),
              defaults["create_tag"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @update_tag = Google::Gax.create_api_call(
              @data_catalog_stub.method(:update_tag),
              defaults["update_tag"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'tag.name' => request.tag.name}
              end
            )
            @delete_tag = Google::Gax.create_api_call(
              @data_catalog_stub.method(:delete_tag),
              defaults["delete_tag"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'name' => request.name}
              end
            )
            @list_tags = Google::Gax.create_api_call(
              @data_catalog_stub.method(:list_tags),
              defaults["list_tags"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'parent' => request.parent}
              end
            )
            @set_iam_policy = Google::Gax.create_api_call(
              @data_catalog_stub.method(:set_iam_policy),
              defaults["set_iam_policy"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'resource' => request.resource}
              end
            )
            @get_iam_policy = Google::Gax.create_api_call(
              @data_catalog_stub.method(:get_iam_policy),
              defaults["get_iam_policy"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'resource' => request.resource}
              end
            )
            @test_iam_permissions = Google::Gax.create_api_call(
              @data_catalog_stub.method(:test_iam_permissions),
              defaults["test_iam_permissions"],
              exception_transformer: exception_transformer,
              params_extractor: proc do |request|
                {'resource' => request.resource}
              end
            )
          end

          # Service calls

          # Searches Data Catalog for multiple resources like entries, tags that
          # match a query.
          #
          # This is a custom method
          # (https://cloud.google.com/apis/design/custom_methods) and does not return
          # the complete resource, only the resource identifier and high level
          # fields. Clients can subsequentally call `Get` methods.
          #
          # Note that Data Catalog search queries do not guarantee full recall. Query
          # results that match your query may not be returned, even in subsequent
          # result pages. Also note that results returned (and not returned) can vary
          # across repeated search queries.
          #
          # See [Data Catalog Search
          # Syntax](https://cloud.google.com/data-catalog/docs/how-to/search-reference)
          # for more information.
          #
          # @param scope [Google::Cloud::Datacatalog::V1beta1::SearchCatalogRequest::Scope | Hash]
          #   Required. The scope of this search request. A `scope` that has empty
          #   `include_org_ids`, `include_project_ids` AND false
          #   `include_gcp_public_datasets` is considered invalid. Data Catalog will
          #   return an error in such a case.
          #   A hash of the same form as `Google::Cloud::Datacatalog::V1beta1::SearchCatalogRequest::Scope`
          #   can also be provided.
          # @param query [String]
          #   Required. The query string in search query syntax. The query must be non-empty.
          #
          #   Query strings can be simple as "x" or more qualified as:
          #
          #   * name:x
          #   * column:x
          #   * description:y
          #
          #   Note: Query tokens need to have a minimum of 3 characters for substring
          #   matching to work correctly. See [Data Catalog Search
          #   Syntax](https://cloud.google.com/data-catalog/docs/how-to/search-reference)
          #   for more information.
          # @param page_size [Integer]
          #   The maximum number of resources contained in the underlying API
          #   response. If page streaming is performed per-resource, this
          #   parameter does not affect the return value. If page streaming is
          #   performed per-page, this determines the maximum number of
          #   resources in a page.
          # @param order_by [String]
          #   Specifies the ordering of results, currently supported case-sensitive
          #   choices are:
          #
          #   * `relevance`, only supports descending
          #     * `last_modified_timestamp [asc|desc]`, defaults to descending if not
          #       specified
          #
          #     If not specified, defaults to `relevance` descending.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Datacatalog::V1beta1::SearchCatalogResult>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Cloud::Datacatalog::V1beta1::SearchCatalogResult>]
          #   An enumerable of Google::Cloud::Datacatalog::V1beta1::SearchCatalogResult instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/datacatalog"
          #
          #   data_catalog_client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)
          #
          #   # TODO: Initialize `scope`:
          #   scope = {}
          #
          #   # TODO: Initialize `query`:
          #   query = ''
          #
          #   # Iterate over all results.
          #   data_catalog_client.search_catalog(scope, query).each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   data_catalog_client.search_catalog(scope, query).each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def search_catalog \
              scope,
              query,
              page_size: nil,
              order_by: nil,
              options: nil,
              &block
            req = {
              scope: scope,
              query: query,
              page_size: page_size,
              order_by: order_by
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Datacatalog::V1beta1::SearchCatalogRequest)
            @search_catalog.call(req, options, &block)
          end

          # Gets an entry.
          #
          # @param name [String]
          #   Required. The name of the entry. Example:
          #
          #   * projects/{project_id}/locations/{location}/entryGroups/{entry_group_id}/entries/{entry_id}
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Datacatalog::V1beta1::Entry]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Datacatalog::V1beta1::Entry]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/datacatalog"
          #
          #   data_catalog_client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)
          #   formatted_name = Google::Cloud::Datacatalog::V1beta1::DataCatalogClient.entry_path("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]")
          #   response = data_catalog_client.get_entry(formatted_name)

          def get_entry \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Datacatalog::V1beta1::GetEntryRequest)
            @get_entry.call(req, options, &block)
          end

          # Get an entry by target resource name. This method allows clients to use
          # the resource name from the source Google Cloud Platform service to get the
          # Data Catalog Entry.
          #
          # @param linked_resource [String]
          #   The full name of the Google Cloud Platform resource the Data Catalog
          #   entry represents. See:
          #   https://cloud.google.com/apis/design/resource_names#full_resource_name.
          #   Full names are case-sensitive.
          #
          #   Examples:
          #
          #   * //bigquery.googleapis.com/projects/projectId/datasets/datasetId/tables/tableId
          #     * //pubsub.googleapis.com/projects/projectId/topics/topicId
          # @param sql_resource [String]
          #   The SQL name of the entry. SQL names are case-sensitive.
          #
          #   Examples:
          #
          #   * `pubsub.project_id.topic_id`
          #     * ``pubsub.project_id.`topic.id.with.dots` ``
          #     * `bigquery.table.project_id.dataset_id.table_id`
          #     * `bigquery.dataset.project_id.dataset_id`
          #     * `datacatalog.entry.project_id.location_id.entry_group_id.entry_id`
          #
          #     `*_id`s shoud satisfy the standard SQL rules for identifiers.
          #     https://cloud.google.com/bigquery/docs/reference/standard-sql/lexical.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Datacatalog::V1beta1::Entry]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Datacatalog::V1beta1::Entry]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/datacatalog"
          #
          #   data_catalog_client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)
          #   response = data_catalog_client.lookup_entry

          def lookup_entry \
              linked_resource: nil,
              sql_resource: nil,
              options: nil,
              &block
            req = {
              linked_resource: linked_resource,
              sql_resource: sql_resource
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Datacatalog::V1beta1::LookupEntryRequest)
            @lookup_entry.call(req, options, &block)
          end

          # A maximum of 10,000 entry groups may be created per organization across all
          # locations.
          #
          # Users should enable the Data Catalog API in the project identified by
          # the `parent` parameter (see [Data Catalog Resource Project]
          # (https://cloud.google.com/data-catalog/docs/concepts/resource-project) for
          # more information).
          #
          # @param parent [String]
          #   Required. The name of the project this entry group is in. Example:
          #
          #   * projects/{project_id}/locations/{location}
          #
          #   Note that this EntryGroup and its child resources may not actually be
          #   stored in the location in this name.
          # @param entry_group_id [String]
          #   Required. The id of the entry group to create.
          #   The id must begin with a letter or underscore, contain only English
          #   letters, numbers and underscores, and be at most 64 characters.
          # @param entry_group [Google::Cloud::Datacatalog::V1beta1::EntryGroup | Hash]
          #   The entry group to create. Defaults to an empty entry group.
          #   A hash of the same form as `Google::Cloud::Datacatalog::V1beta1::EntryGroup`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Datacatalog::V1beta1::EntryGroup]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Datacatalog::V1beta1::EntryGroup]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/datacatalog"
          #
          #   data_catalog_client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)
          #   formatted_parent = Google::Cloud::Datacatalog::V1beta1::DataCatalogClient.location_path("[PROJECT]", "[LOCATION]")
          #
          #   # TODO: Initialize `entry_group_id`:
          #   entry_group_id = ''
          #   response = data_catalog_client.create_entry_group(formatted_parent, entry_group_id)

          def create_entry_group \
              parent,
              entry_group_id,
              entry_group: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              entry_group_id: entry_group_id,
              entry_group: entry_group
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Datacatalog::V1beta1::CreateEntryGroupRequest)
            @create_entry_group.call(req, options, &block)
          end

          # Updates an EntryGroup. The user should enable the Data Catalog API in the
          # project identified by the `entry_group.name` parameter (see [Data Catalog
          # Resource Project]
          # (https://cloud.google.com/data-catalog/docs/concepts/resource-project) for
          # more information).
          #
          # @param entry_group [Google::Cloud::Datacatalog::V1beta1::EntryGroup | Hash]
          #   Required. The updated entry group. "name" field must be set.
          #   A hash of the same form as `Google::Cloud::Datacatalog::V1beta1::EntryGroup`
          #   can also be provided.
          # @param update_mask [Google::Protobuf::FieldMask | Hash]
          #   The fields to update on the entry group. If absent or empty, all modifiable
          #   fields are updated.
          #   A hash of the same form as `Google::Protobuf::FieldMask`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Datacatalog::V1beta1::EntryGroup]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Datacatalog::V1beta1::EntryGroup]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/datacatalog"
          #
          #   data_catalog_client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)
          #
          #   # TODO: Initialize `entry_group`:
          #   entry_group = {}
          #   response = data_catalog_client.update_entry_group(entry_group)

          def update_entry_group \
              entry_group,
              update_mask: nil,
              options: nil,
              &block
            req = {
              entry_group: entry_group,
              update_mask: update_mask
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Datacatalog::V1beta1::UpdateEntryGroupRequest)
            @update_entry_group.call(req, options, &block)
          end

          # Gets an EntryGroup.
          #
          # @param name [String]
          #   Required. The name of the entry group. For example,
          #   `projects/{project_id}/locations/{location}/entryGroups/{entry_group_id}`.
          # @param read_mask [Google::Protobuf::FieldMask | Hash]
          #   The fields to return. If not set or empty, all fields are returned.
          #   A hash of the same form as `Google::Protobuf::FieldMask`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Datacatalog::V1beta1::EntryGroup]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Datacatalog::V1beta1::EntryGroup]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/datacatalog"
          #
          #   data_catalog_client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)
          #   formatted_name = Google::Cloud::Datacatalog::V1beta1::DataCatalogClient.entry_group_path("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]")
          #   response = data_catalog_client.get_entry_group(formatted_name)

          def get_entry_group \
              name,
              read_mask: nil,
              options: nil,
              &block
            req = {
              name: name,
              read_mask: read_mask
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Datacatalog::V1beta1::GetEntryGroupRequest)
            @get_entry_group.call(req, options, &block)
          end

          # Deletes an EntryGroup. Only entry groups that do not contain entries can be
          # deleted. Users should enable the Data Catalog API in the project
          # identified by the `name` parameter (see [Data Catalog Resource Project]
          # (https://cloud.google.com/data-catalog/docs/concepts/resource-project) for
          # more information).
          #
          # @param name [String]
          #   Required. The name of the entry group. For example,
          #   `projects/{project_id}/locations/{location}/entryGroups/{entry_group_id}`.
          # @param force [true, false]
          #   Optional. If true, deletes all entries in the entry group.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result []
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/datacatalog"
          #
          #   data_catalog_client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)
          #   formatted_name = Google::Cloud::Datacatalog::V1beta1::DataCatalogClient.entry_group_path("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]")
          #   data_catalog_client.delete_entry_group(formatted_name)

          def delete_entry_group \
              name,
              force: nil,
              options: nil,
              &block
            req = {
              name: name,
              force: force
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Datacatalog::V1beta1::DeleteEntryGroupRequest)
            @delete_entry_group.call(req, options, &block)
            nil
          end

          # Lists entry groups.
          #
          # @param parent [String]
          #   Required. The name of the location that contains the entry groups, which can be
          #   provided in URL format. Example:
          #
          #   * projects/{project_id}/locations/{location}
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
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Datacatalog::V1beta1::EntryGroup>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Cloud::Datacatalog::V1beta1::EntryGroup>]
          #   An enumerable of Google::Cloud::Datacatalog::V1beta1::EntryGroup instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/datacatalog"
          #
          #   data_catalog_client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)
          #   formatted_parent = Google::Cloud::Datacatalog::V1beta1::DataCatalogClient.entry_group_path("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]")
          #
          #   # Iterate over all results.
          #   data_catalog_client.list_entry_groups(formatted_parent).each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   data_catalog_client.list_entry_groups(formatted_parent).each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_entry_groups \
              parent,
              page_size: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              page_size: page_size
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Datacatalog::V1beta1::ListEntryGroupsRequest)
            @list_entry_groups.call(req, options, &block)
          end

          # Creates an entry. Only entries of 'FILESET' type or user-specified type can
          # be created.
          #
          # Users should enable the Data Catalog API in the project identified by
          # the `parent` parameter (see [Data Catalog Resource Project]
          # (https://cloud.google.com/data-catalog/docs/concepts/resource-project) for
          # more information).
          #
          # A maximum of 100,000 entries may be created per entry group.
          #
          # @param parent [String]
          #   Required. The name of the entry group this entry is in. Example:
          #
          #   * projects/{project_id}/locations/{location}/entryGroups/{entry_group_id}
          #
          #   Note that this Entry and its child resources may not actually be stored in
          #   the location in this name.
          # @param entry_id [String]
          #   Required. The id of the entry to create.
          # @param entry [Google::Cloud::Datacatalog::V1beta1::Entry | Hash]
          #   Required. The entry to create.
          #   A hash of the same form as `Google::Cloud::Datacatalog::V1beta1::Entry`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Datacatalog::V1beta1::Entry]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Datacatalog::V1beta1::Entry]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/datacatalog"
          #
          #   data_catalog_client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)
          #   formatted_parent = Google::Cloud::Datacatalog::V1beta1::DataCatalogClient.entry_group_path("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]")
          #
          #   # TODO: Initialize `entry_id`:
          #   entry_id = ''
          #
          #   # TODO: Initialize `entry`:
          #   entry = {}
          #   response = data_catalog_client.create_entry(formatted_parent, entry_id, entry)

          def create_entry \
              parent,
              entry_id,
              entry,
              options: nil,
              &block
            req = {
              parent: parent,
              entry_id: entry_id,
              entry: entry
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Datacatalog::V1beta1::CreateEntryRequest)
            @create_entry.call(req, options, &block)
          end

          # Updates an existing entry.
          # Users should enable the Data Catalog API in the project identified by
          # the `entry.name` parameter (see [Data Catalog Resource Project]
          # (https://cloud.google.com/data-catalog/docs/concepts/resource-project) for
          # more information).
          #
          # @param entry [Google::Cloud::Datacatalog::V1beta1::Entry | Hash]
          #   Required. The updated entry. The "name" field must be set.
          #   A hash of the same form as `Google::Cloud::Datacatalog::V1beta1::Entry`
          #   can also be provided.
          # @param update_mask [Google::Protobuf::FieldMask | Hash]
          #   The fields to update on the entry. If absent or empty, all modifiable
          #   fields are updated.
          #
          #   The following fields are modifiable:
          #   * For entries with type `DATA_STREAM`:
          #     * `schema`
          #   * For entries with type `FILESET`
          #     * `schema`
          #       * `display_name`
          #     * `description`
          #       * `gcs_fileset_spec`
          #     * `gcs_fileset_spec.file_patterns`
          #   * For entries with `user_specified_type`
          #     * `schema`
          #       * `display_name`
          #     * `description`
          #       * user_specified_type
          #     * user_specified_system
          #       * linked_resource
          #     * source_system_timestamps
          #   A hash of the same form as `Google::Protobuf::FieldMask`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Datacatalog::V1beta1::Entry]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Datacatalog::V1beta1::Entry]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/datacatalog"
          #
          #   data_catalog_client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)
          #
          #   # TODO: Initialize `entry`:
          #   entry = {}
          #   response = data_catalog_client.update_entry(entry)

          def update_entry \
              entry,
              update_mask: nil,
              options: nil,
              &block
            req = {
              entry: entry,
              update_mask: update_mask
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Datacatalog::V1beta1::UpdateEntryRequest)
            @update_entry.call(req, options, &block)
          end

          # Deletes an existing entry. Only entries created through
          # {Google::Cloud::Datacatalog::V1beta1::DataCatalog::CreateEntry CreateEntry}
          # method can be deleted.
          # Users should enable the Data Catalog API in the project identified by
          # the `name` parameter (see [Data Catalog Resource Project]
          # (https://cloud.google.com/data-catalog/docs/concepts/resource-project) for
          # more information).
          #
          # @param name [String]
          #   Required. The name of the entry. Example:
          #
          #   * projects/{project_id}/locations/{location}/entryGroups/{entry_group_id}/entries/{entry_id}
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result []
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/datacatalog"
          #
          #   data_catalog_client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)
          #   formatted_name = Google::Cloud::Datacatalog::V1beta1::DataCatalogClient.entry_path("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]")
          #   data_catalog_client.delete_entry(formatted_name)

          def delete_entry \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Datacatalog::V1beta1::DeleteEntryRequest)
            @delete_entry.call(req, options, &block)
            nil
          end

          # Lists entries.
          #
          # @param parent [String]
          #   Required. The name of the entry group that contains the entries, which can
          #   be provided in URL format. Example:
          #
          #   * projects/{project_id}/locations/{location}/entryGroups/{entry_group_id}
          # @param page_size [Integer]
          #   The maximum number of resources contained in the underlying API
          #   response. If page streaming is performed per-resource, this
          #   parameter does not affect the return value. If page streaming is
          #   performed per-page, this determines the maximum number of
          #   resources in a page.
          # @param read_mask [Google::Protobuf::FieldMask | Hash]
          #   The fields to return for each Entry. If not set or empty, all
          #   fields are returned.
          #   For example, setting read_mask to contain only one path "name" will cause
          #   ListEntries to return a list of Entries with only "name" field.
          #   A hash of the same form as `Google::Protobuf::FieldMask`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Datacatalog::V1beta1::Entry>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Cloud::Datacatalog::V1beta1::Entry>]
          #   An enumerable of Google::Cloud::Datacatalog::V1beta1::Entry instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/datacatalog"
          #
          #   data_catalog_client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)
          #   formatted_parent = Google::Cloud::Datacatalog::V1beta1::DataCatalogClient.entry_group_path("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]")
          #
          #   # Iterate over all results.
          #   data_catalog_client.list_entries(formatted_parent).each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   data_catalog_client.list_entries(formatted_parent).each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_entries \
              parent,
              page_size: nil,
              read_mask: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              page_size: page_size,
              read_mask: read_mask
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Datacatalog::V1beta1::ListEntriesRequest)
            @list_entries.call(req, options, &block)
          end

          # Creates a tag template. The user should enable the Data Catalog API in
          # the project identified by the `parent` parameter (see [Data Catalog
          # Resource
          # Project](https://cloud.google.com/data-catalog/docs/concepts/resource-project)
          # for more information).
          #
          # @param parent [String]
          #   Required. The name of the project and the template location
          #   [region](https://cloud.google.com/data-catalog/docs/concepts/regions.
          #
          #   Example:
          #
          #   * projects/{project_id}/locations/us-central1
          # @param tag_template_id [String]
          #   Required. The id of the tag template to create.
          # @param tag_template [Google::Cloud::Datacatalog::V1beta1::TagTemplate | Hash]
          #   Required. The tag template to create.
          #   A hash of the same form as `Google::Cloud::Datacatalog::V1beta1::TagTemplate`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Datacatalog::V1beta1::TagTemplate]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Datacatalog::V1beta1::TagTemplate]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/datacatalog"
          #
          #   data_catalog_client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)
          #   formatted_parent = Google::Cloud::Datacatalog::V1beta1::DataCatalogClient.location_path("[PROJECT]", "[LOCATION]")
          #
          #   # TODO: Initialize `tag_template_id`:
          #   tag_template_id = ''
          #
          #   # TODO: Initialize `tag_template`:
          #   tag_template = {}
          #   response = data_catalog_client.create_tag_template(formatted_parent, tag_template_id, tag_template)

          def create_tag_template \
              parent,
              tag_template_id,
              tag_template,
              options: nil,
              &block
            req = {
              parent: parent,
              tag_template_id: tag_template_id,
              tag_template: tag_template
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Datacatalog::V1beta1::CreateTagTemplateRequest)
            @create_tag_template.call(req, options, &block)
          end

          # Gets a tag template.
          #
          # @param name [String]
          #   Required. The name of the tag template. Example:
          #
          #   * projects/{project_id}/locations/{location}/tagTemplates/{tag_template_id}
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Datacatalog::V1beta1::TagTemplate]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Datacatalog::V1beta1::TagTemplate]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/datacatalog"
          #
          #   data_catalog_client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)
          #   formatted_name = Google::Cloud::Datacatalog::V1beta1::DataCatalogClient.tag_template_path("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]")
          #   response = data_catalog_client.get_tag_template(formatted_name)

          def get_tag_template \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Datacatalog::V1beta1::GetTagTemplateRequest)
            @get_tag_template.call(req, options, &block)
          end

          # Updates a tag template. This method cannot be used to update the fields of
          # a template. The tag template fields are represented as separate resources
          # and should be updated using their own create/update/delete methods.
          # Users should enable the Data Catalog API in the project identified by
          # the `tag_template.name` parameter (see [Data Catalog Resource Project]
          # (https://cloud.google.com/data-catalog/docs/concepts/resource-project) for
          # more information).
          #
          # @param tag_template [Google::Cloud::Datacatalog::V1beta1::TagTemplate | Hash]
          #   Required. The template to update. The "name" field must be set.
          #   A hash of the same form as `Google::Cloud::Datacatalog::V1beta1::TagTemplate`
          #   can also be provided.
          # @param update_mask [Google::Protobuf::FieldMask | Hash]
          #   The field mask specifies the parts of the template to overwrite.
          #
          #   Allowed fields:
          #
          #   * `display_name`
          #
          #   If absent or empty, all of the allowed fields above will be updated.
          #   A hash of the same form as `Google::Protobuf::FieldMask`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Datacatalog::V1beta1::TagTemplate]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Datacatalog::V1beta1::TagTemplate]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/datacatalog"
          #
          #   data_catalog_client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)
          #
          #   # TODO: Initialize `tag_template`:
          #   tag_template = {}
          #   response = data_catalog_client.update_tag_template(tag_template)

          def update_tag_template \
              tag_template,
              update_mask: nil,
              options: nil,
              &block
            req = {
              tag_template: tag_template,
              update_mask: update_mask
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Datacatalog::V1beta1::UpdateTagTemplateRequest)
            @update_tag_template.call(req, options, &block)
          end

          # Deletes a tag template and all tags using the template.
          # Users should enable the Data Catalog API in the project identified by
          # the `name` parameter (see [Data Catalog Resource Project]
          # (https://cloud.google.com/data-catalog/docs/concepts/resource-project) for
          # more information).
          #
          # @param name [String]
          #   Required. The name of the tag template to delete. Example:
          #
          #   * projects/{project_id}/locations/{location}/tagTemplates/{tag_template_id}
          # @param force [true, false]
          #   Required. Currently, this field must always be set to `true`.
          #   This confirms the deletion of any possible tags using this template.
          #   `force = false` will be supported in the future.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result []
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/datacatalog"
          #
          #   data_catalog_client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)
          #   formatted_name = Google::Cloud::Datacatalog::V1beta1::DataCatalogClient.tag_template_path("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]")
          #
          #   # TODO: Initialize `force`:
          #   force = false
          #   data_catalog_client.delete_tag_template(formatted_name, force)

          def delete_tag_template \
              name,
              force,
              options: nil,
              &block
            req = {
              name: name,
              force: force
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Datacatalog::V1beta1::DeleteTagTemplateRequest)
            @delete_tag_template.call(req, options, &block)
            nil
          end

          # Creates a field in a tag template. The user should enable the Data Catalog
          # API in the project identified by the `parent` parameter (see
          # [Data Catalog Resource
          # Project](https://cloud.google.com/data-catalog/docs/concepts/resource-project)
          # for more information).
          #
          # @param parent [String]
          #   Required. The name of the project and the template location
          #   [region](https://cloud.google.com/data-catalog/docs/concepts/regions).
          #
          #   Example:
          #
          #   * projects/{project_id}/locations/us-central1/tagTemplates/{tag_template_id}
          # @param tag_template_field_id [String]
          #   Required. The ID of the tag template field to create.
          #   Field ids can contain letters (both uppercase and lowercase), numbers
          #   (0-9), underscores (_) and dashes (-). Field IDs must be at least 1
          #   character long and at most 128 characters long. Field IDs must also be
          #   unique within their template.
          # @param tag_template_field [Google::Cloud::Datacatalog::V1beta1::TagTemplateField | Hash]
          #   Required. The tag template field to create.
          #   A hash of the same form as `Google::Cloud::Datacatalog::V1beta1::TagTemplateField`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Datacatalog::V1beta1::TagTemplateField]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Datacatalog::V1beta1::TagTemplateField]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/datacatalog"
          #
          #   data_catalog_client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)
          #   formatted_parent = Google::Cloud::Datacatalog::V1beta1::DataCatalogClient.tag_template_path("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]")
          #
          #   # TODO: Initialize `tag_template_field_id`:
          #   tag_template_field_id = ''
          #
          #   # TODO: Initialize `tag_template_field`:
          #   tag_template_field = {}
          #   response = data_catalog_client.create_tag_template_field(formatted_parent, tag_template_field_id, tag_template_field)

          def create_tag_template_field \
              parent,
              tag_template_field_id,
              tag_template_field,
              options: nil,
              &block
            req = {
              parent: parent,
              tag_template_field_id: tag_template_field_id,
              tag_template_field: tag_template_field
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Datacatalog::V1beta1::CreateTagTemplateFieldRequest)
            @create_tag_template_field.call(req, options, &block)
          end

          # Updates a field in a tag template. This method cannot be used to update the
          # field type. Users should enable the Data Catalog API in the project
          # identified by the `name` parameter (see [Data Catalog Resource Project]
          # (https://cloud.google.com/data-catalog/docs/concepts/resource-project) for
          # more information).
          #
          # @param name [String]
          #   Required. The name of the tag template field. Example:
          #
          #   * projects/{project_id}/locations/{location}/tagTemplates/{tag_template_id}/fields/{tag_template_field_id}
          # @param tag_template_field [Google::Cloud::Datacatalog::V1beta1::TagTemplateField | Hash]
          #   Required. The template to update.
          #   A hash of the same form as `Google::Cloud::Datacatalog::V1beta1::TagTemplateField`
          #   can also be provided.
          # @param update_mask [Google::Protobuf::FieldMask | Hash]
          #   Optional. The field mask specifies the parts of the template to be updated.
          #   Allowed fields:
          #
          #   * `display_name`
          #     * `type.enum_type`
          #     * `is_required`
          #
          #     If `update_mask` is not set or empty, all of the allowed fields above will
          #     be updated.
          #
          #   When updating an enum type, the provided values will be merged with the
          #   existing values. Therefore, enum values can only be added, existing enum
          #   values cannot be deleted nor renamed. Updating a template field from
          #   optional to required is NOT allowed.
          #   A hash of the same form as `Google::Protobuf::FieldMask`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Datacatalog::V1beta1::TagTemplateField]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Datacatalog::V1beta1::TagTemplateField]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/datacatalog"
          #
          #   data_catalog_client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)
          #   formatted_name = Google::Cloud::Datacatalog::V1beta1::DataCatalogClient.tag_template_field_path("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]")
          #
          #   # TODO: Initialize `tag_template_field`:
          #   tag_template_field = {}
          #   response = data_catalog_client.update_tag_template_field(formatted_name, tag_template_field)

          def update_tag_template_field \
              name,
              tag_template_field,
              update_mask: nil,
              options: nil,
              &block
            req = {
              name: name,
              tag_template_field: tag_template_field,
              update_mask: update_mask
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Datacatalog::V1beta1::UpdateTagTemplateFieldRequest)
            @update_tag_template_field.call(req, options, &block)
          end

          # Renames a field in a tag template. The user should enable the Data Catalog
          # API in the project identified by the `name` parameter (see [Data Catalog
          # Resource
          # Project](https://cloud.google.com/data-catalog/docs/concepts/resource-project)
          # for more information).
          #
          # @param name [String]
          #   Required. The name of the tag template. Example:
          #
          #   * projects/{project_id}/locations/{location}/tagTemplates/{tag_template_id}/fields/{tag_template_field_id}
          # @param new_tag_template_field_id [String]
          #   Required. The new ID of this tag template field. For example, `my_new_field`.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Datacatalog::V1beta1::TagTemplateField]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Datacatalog::V1beta1::TagTemplateField]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/datacatalog"
          #
          #   data_catalog_client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)
          #   formatted_name = Google::Cloud::Datacatalog::V1beta1::DataCatalogClient.tag_template_field_path("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]")
          #
          #   # TODO: Initialize `new_tag_template_field_id`:
          #   new_tag_template_field_id = ''
          #   response = data_catalog_client.rename_tag_template_field(formatted_name, new_tag_template_field_id)

          def rename_tag_template_field \
              name,
              new_tag_template_field_id,
              options: nil,
              &block
            req = {
              name: name,
              new_tag_template_field_id: new_tag_template_field_id
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Datacatalog::V1beta1::RenameTagTemplateFieldRequest)
            @rename_tag_template_field.call(req, options, &block)
          end

          # Deletes a field in a tag template and all uses of that field.
          # Users should enable the Data Catalog API in the project identified by
          # the `name` parameter (see [Data Catalog Resource Project]
          # (https://cloud.google.com/data-catalog/docs/concepts/resource-project) for
          # more information).
          #
          # @param name [String]
          #   Required. The name of the tag template field to delete. Example:
          #
          #   * projects/{project_id}/locations/{location}/tagTemplates/{tag_template_id}/fields/{tag_template_field_id}
          # @param force [true, false]
          #   Required. Currently, this field must always be set to `true`.
          #   This confirms the deletion of this field from any tags using this field.
          #   `force = false` will be supported in the future.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result []
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/datacatalog"
          #
          #   data_catalog_client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)
          #   formatted_name = Google::Cloud::Datacatalog::V1beta1::DataCatalogClient.tag_template_field_path("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]")
          #
          #   # TODO: Initialize `force`:
          #   force = false
          #   data_catalog_client.delete_tag_template_field(formatted_name, force)

          def delete_tag_template_field \
              name,
              force,
              options: nil,
              &block
            req = {
              name: name,
              force: force
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Datacatalog::V1beta1::DeleteTagTemplateFieldRequest)
            @delete_tag_template_field.call(req, options, &block)
            nil
          end

          # Creates a tag on an {Google::Cloud::Datacatalog::V1beta1::Entry Entry}.
          # Note: The project identified by the `parent` parameter for the
          # [tag](https://cloud.google.com/data-catalog/docs/reference/rest/v1beta1/projects.locations.entryGroups.entries.tags/create#path-parameters)
          # and the
          # [tag
          # template](https://cloud.google.com/data-catalog/docs/reference/rest/v1beta1/projects.locations.tagTemplates/create#path-parameters)
          # used to create the tag must be from the same organization.
          #
          # @param parent [String]
          #   Required. The name of the resource to attach this tag to. Tags can be attached to
          #   Entries. Example:
          #
          #   * projects/{project_id}/locations/{location}/entryGroups/{entry_group_id}/entries/{entry_id}
          #
          #   Note that this Tag and its child resources may not actually be stored in
          #   the location in this name.
          # @param tag [Google::Cloud::Datacatalog::V1beta1::Tag | Hash]
          #   Required. The tag to create.
          #   A hash of the same form as `Google::Cloud::Datacatalog::V1beta1::Tag`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Datacatalog::V1beta1::Tag]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Datacatalog::V1beta1::Tag]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/datacatalog"
          #
          #   data_catalog_client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)
          #   formatted_parent = Google::Cloud::Datacatalog::V1beta1::DataCatalogClient.tag_path("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]", "[TAG]")
          #
          #   # TODO: Initialize `tag`:
          #   tag = {}
          #   response = data_catalog_client.create_tag(formatted_parent, tag)

          def create_tag \
              parent,
              tag,
              options: nil,
              &block
            req = {
              parent: parent,
              tag: tag
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Datacatalog::V1beta1::CreateTagRequest)
            @create_tag.call(req, options, &block)
          end

          # Updates an existing tag.
          #
          # @param tag [Google::Cloud::Datacatalog::V1beta1::Tag | Hash]
          #   Required. The updated tag. The "name" field must be set.
          #   A hash of the same form as `Google::Cloud::Datacatalog::V1beta1::Tag`
          #   can also be provided.
          # @param update_mask [Google::Protobuf::FieldMask | Hash]
          #   The fields to update on the Tag. If absent or empty, all modifiable fields
          #   are updated. Currently the only modifiable field is the field `fields`.
          #   A hash of the same form as `Google::Protobuf::FieldMask`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Cloud::Datacatalog::V1beta1::Tag]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Cloud::Datacatalog::V1beta1::Tag]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/datacatalog"
          #
          #   data_catalog_client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)
          #
          #   # TODO: Initialize `tag`:
          #   tag = {}
          #   response = data_catalog_client.update_tag(tag)

          def update_tag \
              tag,
              update_mask: nil,
              options: nil,
              &block
            req = {
              tag: tag,
              update_mask: update_mask
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Datacatalog::V1beta1::UpdateTagRequest)
            @update_tag.call(req, options, &block)
          end

          # Deletes a tag.
          #
          # @param name [String]
          #   Required. The name of the tag to delete. Example:
          #
          #   * projects/{project_id}/locations/{location}/entryGroups/{entry_group_id}/entries/{entry_id}/tags/{tag_id}
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result []
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/datacatalog"
          #
          #   data_catalog_client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)
          #   formatted_name = Google::Cloud::Datacatalog::V1beta1::DataCatalogClient.entry_path("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]")
          #   data_catalog_client.delete_tag(formatted_name)

          def delete_tag \
              name,
              options: nil,
              &block
            req = {
              name: name
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Datacatalog::V1beta1::DeleteTagRequest)
            @delete_tag.call(req, options, &block)
            nil
          end

          # Lists the tags on an {Google::Cloud::Datacatalog::V1beta1::Entry Entry}.
          #
          # @param parent [String]
          #   Required. The name of the Data Catalog resource to list the tags of. The resource
          #   could be an {Google::Cloud::Datacatalog::V1beta1::Entry Entry} or an
          #   {Google::Cloud::Datacatalog::V1beta1::EntryGroup EntryGroup}.
          #
          #   Examples:
          #
          #   * projects/{project_id}/locations/{location}/entryGroups/{entry_group_id}
          #   * projects/{project_id}/locations/{location}/entryGroups/{entry_group_id}/entries/{entry_id}
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
          # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Datacatalog::V1beta1::Tag>]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Gax::PagedEnumerable<Google::Cloud::Datacatalog::V1beta1::Tag>]
          #   An enumerable of Google::Cloud::Datacatalog::V1beta1::Tag instances.
          #   See Google::Gax::PagedEnumerable documentation for other
          #   operations such as per-page iteration or access to the response
          #   object.
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/datacatalog"
          #
          #   data_catalog_client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)
          #   formatted_parent = Google::Cloud::Datacatalog::V1beta1::DataCatalogClient.entry_path("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]")
          #
          #   # Iterate over all results.
          #   data_catalog_client.list_tags(formatted_parent).each do |element|
          #     # Process element.
          #   end
          #
          #   # Or iterate over results one page at a time.
          #   data_catalog_client.list_tags(formatted_parent).each_page do |page|
          #     # Process each page at a time.
          #     page.each do |element|
          #       # Process element.
          #     end
          #   end

          def list_tags \
              parent,
              page_size: nil,
              options: nil,
              &block
            req = {
              parent: parent,
              page_size: page_size
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Cloud::Datacatalog::V1beta1::ListTagsRequest)
            @list_tags.call(req, options, &block)
          end

          # Sets the access control policy for a resource. Replaces any existing
          # policy.
          # Supported resources are:
          # * Tag templates.
          #   * Entries.
          #   * Entry groups.
          #     Note, this method cannot be used to manage policies for BigQuery, Pub/Sub
          #     and any external Google Cloud Platform resources synced to Data Catalog.
          #
          #   Callers must have following Google IAM permission
          #   * `datacatalog.tagTemplates.setIamPolicy` to set policies on tag
          #     templates.
          #   * `datacatalog.entries.setIamPolicy` to set policies on entries.
          #   * `datacatalog.entryGroups.setIamPolicy` to set policies on entry groups.
          #
          # @param resource [String]
          #   REQUIRED: The resource for which the policy is being specified.
          #   See the operation documentation for the appropriate value for this field.
          # @param policy [Google::Iam::V1::Policy | Hash]
          #   REQUIRED: The complete policy to be applied to the `resource`. The size of
          #   the policy is limited to a few 10s of KB. An empty policy is a
          #   valid policy but certain Cloud Platform services (such as Projects)
          #   might reject them.
          #   A hash of the same form as `Google::Iam::V1::Policy`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Iam::V1::Policy]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Iam::V1::Policy]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/datacatalog"
          #
          #   data_catalog_client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)
          #
          #   # TODO: Initialize `resource`:
          #   resource = ''
          #
          #   # TODO: Initialize `policy`:
          #   policy = {}
          #   response = data_catalog_client.set_iam_policy(resource, policy)

          def set_iam_policy \
              resource,
              policy,
              options: nil,
              &block
            req = {
              resource: resource,
              policy: policy
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Iam::V1::SetIamPolicyRequest)
            @set_iam_policy.call(req, options, &block)
          end

          # Gets the access control policy for a resource. A `NOT_FOUND` error
          # is returned if the resource does not exist. An empty policy is returned
          # if the resource exists but does not have a policy set on it.
          #
          # Supported resources are:
          # * Tag templates.
          #   * Entries.
          #   * Entry groups.
          #     Note, this method cannot be used to manage policies for BigQuery, Pub/Sub
          #     and any external Google Cloud Platform resources synced to Data Catalog.
          #
          #   Callers must have following Google IAM permission
          #   * `datacatalog.tagTemplates.getIamPolicy` to get policies on tag
          #     templates.
          #   * `datacatalog.entries.getIamPolicy` to get policies on entries.
          #   * `datacatalog.entryGroups.getIamPolicy` to get policies on entry groups.
          #
          # @param resource [String]
          #   REQUIRED: The resource for which the policy is being requested.
          #   See the operation documentation for the appropriate value for this field.
          # @param options_ [Google::Iam::V1::GetPolicyOptions | Hash]
          #   OPTIONAL: A `GetPolicyOptions` object for specifying options to
          #   `GetIamPolicy`. This field is only used by Cloud IAM.
          #   A hash of the same form as `Google::Iam::V1::GetPolicyOptions`
          #   can also be provided.
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Iam::V1::Policy]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Iam::V1::Policy]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/datacatalog"
          #
          #   data_catalog_client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)
          #
          #   # TODO: Initialize `resource`:
          #   resource = ''
          #   response = data_catalog_client.get_iam_policy(resource)

          def get_iam_policy \
              resource,
              options_: nil,
              options: nil,
              &block
            req = {
              resource: resource,
              options: options_
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Iam::V1::GetIamPolicyRequest)
            @get_iam_policy.call(req, options, &block)
          end

          # Returns the caller's permissions on a resource.
          # If the resource does not exist, an empty set of permissions is returned
          # (We don't return a `NOT_FOUND` error).
          #
          # Supported resources are:
          # * Tag templates.
          #   * Entries.
          #   * Entry groups.
          #     Note, this method cannot be used to manage policies for BigQuery, Pub/Sub
          #     and any external Google Cloud Platform resources synced to Data Catalog.
          #
          #   A caller is not required to have Google IAM permission to make this
          #   request.
          #
          # @param resource [String]
          #   REQUIRED: The resource for which the policy detail is being requested.
          #   See the operation documentation for the appropriate value for this field.
          # @param permissions [Array<String>]
          #   The set of permissions to check for the `resource`. Permissions with
          #   wildcards (such as '*' or 'storage.*') are not allowed. For more
          #   information see
          #   [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
          # @param options [Google::Gax::CallOptions]
          #   Overrides the default settings for this call, e.g, timeout,
          #   retries, etc.
          # @yield [result, operation] Access the result along with the RPC operation
          # @yieldparam result [Google::Iam::V1::TestIamPermissionsResponse]
          # @yieldparam operation [GRPC::ActiveCall::Operation]
          # @return [Google::Iam::V1::TestIamPermissionsResponse]
          # @raise [Google::Gax::GaxError] if the RPC is aborted.
          # @example
          #   require "google/cloud/datacatalog"
          #
          #   data_catalog_client = Google::Cloud::Datacatalog::DataCatalog.new(version: :v1beta1)
          #
          #   # TODO: Initialize `resource`:
          #   resource = ''
          #
          #   # TODO: Initialize `permissions`:
          #   permissions = []
          #   response = data_catalog_client.test_iam_permissions(resource, permissions)

          def test_iam_permissions \
              resource,
              permissions,
              options: nil,
              &block
            req = {
              resource: resource,
              permissions: permissions
            }.delete_if { |_, v| v.nil? }
            req = Google::Gax::to_proto(req, Google::Iam::V1::TestIamPermissionsRequest)
            @test_iam_permissions.call(req, options, &block)
          end
        end
      end
    end
  end
end
