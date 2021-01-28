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
# https://github.com/googleapis/googleapis/blob/master/google/cloud/bigquery/reservation/v1beta1/reservation.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"

require "google/cloud/bigquery/reservation/v1beta1/reservation_pb"
require "google/cloud/bigquery/reservation/v1beta1/credentials"

module Google
  module Cloud
    module Bigquery
      module Reservation
        module V1beta1
          # This API allows users to manage their flat-rate BigQuery reservations.
          #
          # A reservation provides computational resource guarantees, in the form of
          # [slots](https://cloud.google.com/bigquery/docs/slots), to users. A slot is a
          # unit of computational power in BigQuery, and serves as the basic unit of
          # parallelism. In a scan of a multi-partitioned table, a single slot operates
          # on a single partition of the table. A reservation resource exists as a child
          # resource of the admin project and location, e.g.:
          #   `projects/myproject/locations/US/reservations/reservationName`.
          #
          # A capacity commitment is a way to purchase compute capacity for BigQuery jobs
          # (in the form of slots) with some committed period of usage. A capacity
          # commitment resource exists as a child resource of the admin project and
          # location, e.g.:
          #   `projects/myproject/locations/US/capacityCommitments/id`.
          #
          # @!attribute [r] reservation_service_stub
          #   @return [Google::Cloud::Bigquery::Reservation::V1beta1::ReservationService::Stub]
          class ReservationServiceClient
            attr_reader :reservation_service_stub

            # The default address of the service.
            SERVICE_ADDRESS = "bigqueryreservation.googleapis.com".freeze

            # The default port of the service.
            DEFAULT_SERVICE_PORT = 443

            # The default set of gRPC interceptors.
            GRPC_INTERCEPTORS = []

            DEFAULT_TIMEOUT = 30

            PAGE_DESCRIPTORS = {
              "list_reservations" => Google::Gax::PageDescriptor.new(
                "page_token",
                "next_page_token",
                "reservations"),
              "list_capacity_commitments" => Google::Gax::PageDescriptor.new(
                "page_token",
                "next_page_token",
                "capacity_commitments"),
              "list_assignments" => Google::Gax::PageDescriptor.new(
                "page_token",
                "next_page_token",
                "assignments"),
              "search_assignments" => Google::Gax::PageDescriptor.new(
                "page_token",
                "next_page_token",
                "assignments")
            }.freeze

            private_constant :PAGE_DESCRIPTORS

            # The scopes needed to make gRPC calls to all of the methods defined in
            # this service.
            ALL_SCOPES = [
              "https://www.googleapis.com/auth/bigquery",
              "https://www.googleapis.com/auth/cloud-platform"
            ].freeze


            ASSIGNMENT_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
              "projects/{project}/locations/{location}/reservations/{reservation}/assignments/{assignment}"
            )

            private_constant :ASSIGNMENT_PATH_TEMPLATE

            BI_RESERVATION_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
              "projects/{project}/locations/{location}/bireservation/{bireservation}"
            )

            private_constant :BI_RESERVATION_PATH_TEMPLATE

            CAPACITY_COMMITMENT_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
              "projects/{project}/locations/{location}/capacityCommitments/{capacity_commitment}"
            )

            private_constant :CAPACITY_COMMITMENT_PATH_TEMPLATE

            LOCATION_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
              "projects/{project}/locations/{location}"
            )

            private_constant :LOCATION_PATH_TEMPLATE

            RESERVATION_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
              "projects/{project}/locations/{location}/reservations/{reservation}"
            )

            private_constant :RESERVATION_PATH_TEMPLATE

            # Returns a fully-qualified assignment resource name string.
            # @param project [String]
            # @param location [String]
            # @param reservation [String]
            # @param assignment [String]
            # @return [String]
            def self.assignment_path project, location, reservation, assignment
              ASSIGNMENT_PATH_TEMPLATE.render(
                :"project" => project,
                :"location" => location,
                :"reservation" => reservation,
                :"assignment" => assignment
              )
            end

            # Returns a fully-qualified bi_reservation resource name string.
            # @param project [String]
            # @param location [String]
            # @param bireservation [String]
            # @return [String]
            def self.bi_reservation_path project, location, bireservation
              BI_RESERVATION_PATH_TEMPLATE.render(
                :"project" => project,
                :"location" => location,
                :"bireservation" => bireservation
              )
            end

            # Returns a fully-qualified capacity_commitment resource name string.
            # @param project [String]
            # @param location [String]
            # @param capacity_commitment [String]
            # @return [String]
            def self.capacity_commitment_path project, location, capacity_commitment
              CAPACITY_COMMITMENT_PATH_TEMPLATE.render(
                :"project" => project,
                :"location" => location,
                :"capacity_commitment" => capacity_commitment
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

            # Returns a fully-qualified reservation resource name string.
            # @param project [String]
            # @param location [String]
            # @param reservation [String]
            # @return [String]
            def self.reservation_path project, location, reservation
              RESERVATION_PATH_TEMPLATE.render(
                :"project" => project,
                :"location" => location,
                :"reservation" => reservation
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
              require "google/cloud/bigquery/reservation/v1beta1/reservation_services_pb"

              credentials ||= Google::Cloud::Bigquery::Reservation::V1beta1::Credentials.default

              if credentials.is_a?(String) || credentials.is_a?(Hash)
                updater_proc = Google::Cloud::Bigquery::Reservation::V1beta1::Credentials.new(credentials).updater_proc
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

              package_version = Gem.loaded_specs['google-cloud-bigquery-reservation'].version.version

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
                "reservation_service_client_config.json"
              )
              defaults = client_config_file.open do |f|
                Google::Gax.construct_settings(
                  "google.cloud.bigquery.reservation.v1beta1.ReservationService",
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
              @reservation_service_stub = Google::Gax::Grpc.create_stub(
                service_path,
                port,
                chan_creds: chan_creds,
                channel: channel,
                updater_proc: updater_proc,
                scopes: scopes,
                interceptors: interceptors,
                &Google::Cloud::Bigquery::Reservation::V1beta1::ReservationService::Stub.method(:new)
              )

              @create_reservation = Google::Gax.create_api_call(
                @reservation_service_stub.method(:create_reservation),
                defaults["create_reservation"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'parent' => request.parent}
                end
              )
              @list_reservations = Google::Gax.create_api_call(
                @reservation_service_stub.method(:list_reservations),
                defaults["list_reservations"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'parent' => request.parent}
                end
              )
              @get_reservation = Google::Gax.create_api_call(
                @reservation_service_stub.method(:get_reservation),
                defaults["get_reservation"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @delete_reservation = Google::Gax.create_api_call(
                @reservation_service_stub.method(:delete_reservation),
                defaults["delete_reservation"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @update_reservation = Google::Gax.create_api_call(
                @reservation_service_stub.method(:update_reservation),
                defaults["update_reservation"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'reservation.name' => request.reservation.name}
                end
              )
              @create_capacity_commitment = Google::Gax.create_api_call(
                @reservation_service_stub.method(:create_capacity_commitment),
                defaults["create_capacity_commitment"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'parent' => request.parent}
                end
              )
              @list_capacity_commitments = Google::Gax.create_api_call(
                @reservation_service_stub.method(:list_capacity_commitments),
                defaults["list_capacity_commitments"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'parent' => request.parent}
                end
              )
              @get_capacity_commitment = Google::Gax.create_api_call(
                @reservation_service_stub.method(:get_capacity_commitment),
                defaults["get_capacity_commitment"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @delete_capacity_commitment = Google::Gax.create_api_call(
                @reservation_service_stub.method(:delete_capacity_commitment),
                defaults["delete_capacity_commitment"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @update_capacity_commitment = Google::Gax.create_api_call(
                @reservation_service_stub.method(:update_capacity_commitment),
                defaults["update_capacity_commitment"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'capacity_commitment.name' => request.capacity_commitment.name}
                end
              )
              @split_capacity_commitment = Google::Gax.create_api_call(
                @reservation_service_stub.method(:split_capacity_commitment),
                defaults["split_capacity_commitment"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @merge_capacity_commitments = Google::Gax.create_api_call(
                @reservation_service_stub.method(:merge_capacity_commitments),
                defaults["merge_capacity_commitments"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'parent' => request.parent}
                end
              )
              @create_assignment = Google::Gax.create_api_call(
                @reservation_service_stub.method(:create_assignment),
                defaults["create_assignment"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'parent' => request.parent}
                end
              )
              @list_assignments = Google::Gax.create_api_call(
                @reservation_service_stub.method(:list_assignments),
                defaults["list_assignments"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'parent' => request.parent}
                end
              )
              @delete_assignment = Google::Gax.create_api_call(
                @reservation_service_stub.method(:delete_assignment),
                defaults["delete_assignment"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @search_assignments = Google::Gax.create_api_call(
                @reservation_service_stub.method(:search_assignments),
                defaults["search_assignments"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'parent' => request.parent}
                end
              )
              @move_assignment = Google::Gax.create_api_call(
                @reservation_service_stub.method(:move_assignment),
                defaults["move_assignment"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @get_bi_reservation = Google::Gax.create_api_call(
                @reservation_service_stub.method(:get_bi_reservation),
                defaults["get_bi_reservation"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @update_bi_reservation = Google::Gax.create_api_call(
                @reservation_service_stub.method(:update_bi_reservation),
                defaults["update_bi_reservation"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'reservation.name' => request.reservation.name}
                end
              )
            end

            # Service calls

            # Creates a new reservation resource.
            #
            # @param parent [String]
            #   Required. Project, location. E.g.,
            #   `projects/myproject/locations/US`
            # @param reservation_id [String]
            #   The reservation ID. This field must only contain lower case alphanumeric
            #   characters or dash. Max length is 64 characters.
            # @param reservation [Google::Cloud::Bigquery::Reservation::V1beta1::Reservation | Hash]
            #   Content of the new reservation to create.
            #   A hash of the same form as `Google::Cloud::Bigquery::Reservation::V1beta1::Reservation`
            #   can also be provided.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Bigquery::Reservation::V1beta1::Reservation]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Bigquery::Reservation::V1beta1::Reservation]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/bigquery/reservation"
            #
            #   reservation_client = Google::Cloud::Bigquery::Reservation.new(version: :v1beta1)
            #   formatted_parent = Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient.location_path("[PROJECT]", "[LOCATION]")
            #   response = reservation_client.create_reservation(formatted_parent)

            def create_reservation \
                parent,
                reservation_id: nil,
                reservation: nil,
                options: nil,
                &block
              req = {
                parent: parent,
                reservation_id: reservation_id,
                reservation: reservation
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Bigquery::Reservation::V1beta1::CreateReservationRequest)
              @create_reservation.call(req, options, &block)
            end

            # Lists all the reservations for the project in the specified location.
            #
            # @param parent [String]
            #   Required. The parent resource name containing project and location, e.g.:
            #     `projects/myproject/locations/US`
            # @param page_size [Integer]
            #   The maximum number of resources contained in the underlying API
            #   response. If page streaming is performed per-resource, this
            #   parameter does not affect the return value. If page streaming is
            #   performed per-page, this determines the maximum number of
            #   resources in a page.
            # @param filter [String]
            #   Can be used to filter out reservations based on names, capacity, etc, e.g.:
            #   filter="reservation.slot_capacity > 200"
            #   filter="reservation.name = \"*dev/*\""
            #   Advanced filtering syntax can be
            #   [here](https://cloud.google.com/logging/docs/view/advanced-filters).
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Bigquery::Reservation::V1beta1::Reservation>]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Gax::PagedEnumerable<Google::Cloud::Bigquery::Reservation::V1beta1::Reservation>]
            #   An enumerable of Google::Cloud::Bigquery::Reservation::V1beta1::Reservation instances.
            #   See Google::Gax::PagedEnumerable documentation for other
            #   operations such as per-page iteration or access to the response
            #   object.
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/bigquery/reservation"
            #
            #   reservation_client = Google::Cloud::Bigquery::Reservation.new(version: :v1beta1)
            #   formatted_parent = Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient.location_path("[PROJECT]", "[LOCATION]")
            #
            #   # Iterate over all results.
            #   reservation_client.list_reservations(formatted_parent).each do |element|
            #     # Process element.
            #   end
            #
            #   # Or iterate over results one page at a time.
            #   reservation_client.list_reservations(formatted_parent).each_page do |page|
            #     # Process each page at a time.
            #     page.each do |element|
            #       # Process element.
            #     end
            #   end

            def list_reservations \
                parent,
                page_size: nil,
                filter: nil,
                options: nil,
                &block
              req = {
                parent: parent,
                page_size: page_size,
                filter: filter
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Bigquery::Reservation::V1beta1::ListReservationsRequest)
              @list_reservations.call(req, options, &block)
            end

            # Returns information about the reservation.
            #
            # @param name [String]
            #   Required. Resource name of the reservation to retrieve. E.g.,
            #      `projects/myproject/locations/US/reservations/team1-prod`
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Bigquery::Reservation::V1beta1::Reservation]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Bigquery::Reservation::V1beta1::Reservation]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/bigquery/reservation"
            #
            #   reservation_client = Google::Cloud::Bigquery::Reservation.new(version: :v1beta1)
            #   formatted_name = Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient.reservation_path("[PROJECT]", "[LOCATION]", "[RESERVATION]")
            #   response = reservation_client.get_reservation(formatted_name)

            def get_reservation \
                name,
                options: nil,
                &block
              req = {
                name: name
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Bigquery::Reservation::V1beta1::GetReservationRequest)
              @get_reservation.call(req, options, &block)
            end

            # Deletes a reservation.
            # Returns `google.rpc.Code.FAILED_PRECONDITION` when reservation has
            # assignments.
            #
            # @param name [String]
            #   Required. Resource name of the reservation to retrieve. E.g.,
            #      `projects/myproject/locations/US/reservations/team1-prod`
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result []
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/bigquery/reservation"
            #
            #   reservation_client = Google::Cloud::Bigquery::Reservation.new(version: :v1beta1)
            #   formatted_name = Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient.reservation_path("[PROJECT]", "[LOCATION]", "[RESERVATION]")
            #   reservation_client.delete_reservation(formatted_name)

            def delete_reservation \
                name,
                options: nil,
                &block
              req = {
                name: name
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Bigquery::Reservation::V1beta1::DeleteReservationRequest)
              @delete_reservation.call(req, options, &block)
              nil
            end

            # Updates an existing reservation resource.
            #
            # @param reservation [Google::Cloud::Bigquery::Reservation::V1beta1::Reservation | Hash]
            #   Content of the reservation to update.
            #   A hash of the same form as `Google::Cloud::Bigquery::Reservation::V1beta1::Reservation`
            #   can also be provided.
            # @param update_mask [Google::Protobuf::FieldMask | Hash]
            #   Standard field mask for the set of fields to be updated.
            #   A hash of the same form as `Google::Protobuf::FieldMask`
            #   can also be provided.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Bigquery::Reservation::V1beta1::Reservation]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Bigquery::Reservation::V1beta1::Reservation]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/bigquery/reservation"
            #
            #   reservation_client = Google::Cloud::Bigquery::Reservation.new(version: :v1beta1)
            #   response = reservation_client.update_reservation

            def update_reservation \
                reservation: nil,
                update_mask: nil,
                options: nil,
                &block
              req = {
                reservation: reservation,
                update_mask: update_mask
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Bigquery::Reservation::V1beta1::UpdateReservationRequest)
              @update_reservation.call(req, options, &block)
            end

            # Creates a new capacity commitment resource.
            #
            # @param parent [String]
            #   Required. Resource name of the parent reservation. E.g.,
            #      `projects/myproject/locations/US`
            # @param capacity_commitment [Google::Cloud::Bigquery::Reservation::V1beta1::CapacityCommitment | Hash]
            #   Content of the capacity commitment to create.
            #   A hash of the same form as `Google::Cloud::Bigquery::Reservation::V1beta1::CapacityCommitment`
            #   can also be provided.
            # @param enforce_single_admin_project_per_org [true, false]
            #   If true, fail the request if another project in the organization has a
            #   capacity commitment.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Bigquery::Reservation::V1beta1::CapacityCommitment]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Bigquery::Reservation::V1beta1::CapacityCommitment]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/bigquery/reservation"
            #
            #   reservation_client = Google::Cloud::Bigquery::Reservation.new(version: :v1beta1)
            #   formatted_parent = Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient.location_path("[PROJECT]", "[LOCATION]")
            #   response = reservation_client.create_capacity_commitment(formatted_parent)

            def create_capacity_commitment \
                parent,
                capacity_commitment: nil,
                enforce_single_admin_project_per_org: nil,
                options: nil,
                &block
              req = {
                parent: parent,
                capacity_commitment: capacity_commitment,
                enforce_single_admin_project_per_org: enforce_single_admin_project_per_org
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Bigquery::Reservation::V1beta1::CreateCapacityCommitmentRequest)
              @create_capacity_commitment.call(req, options, &block)
            end

            # Lists all the capacity commitments for the admin project.
            #
            # @param parent [String]
            #   Required. Resource name of the parent reservation. E.g.,
            #      `projects/myproject/locations/US`
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
            # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Bigquery::Reservation::V1beta1::CapacityCommitment>]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Gax::PagedEnumerable<Google::Cloud::Bigquery::Reservation::V1beta1::CapacityCommitment>]
            #   An enumerable of Google::Cloud::Bigquery::Reservation::V1beta1::CapacityCommitment instances.
            #   See Google::Gax::PagedEnumerable documentation for other
            #   operations such as per-page iteration or access to the response
            #   object.
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/bigquery/reservation"
            #
            #   reservation_client = Google::Cloud::Bigquery::Reservation.new(version: :v1beta1)
            #   formatted_parent = Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient.location_path("[PROJECT]", "[LOCATION]")
            #
            #   # Iterate over all results.
            #   reservation_client.list_capacity_commitments(formatted_parent).each do |element|
            #     # Process element.
            #   end
            #
            #   # Or iterate over results one page at a time.
            #   reservation_client.list_capacity_commitments(formatted_parent).each_page do |page|
            #     # Process each page at a time.
            #     page.each do |element|
            #       # Process element.
            #     end
            #   end

            def list_capacity_commitments \
                parent,
                page_size: nil,
                options: nil,
                &block
              req = {
                parent: parent,
                page_size: page_size
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Bigquery::Reservation::V1beta1::ListCapacityCommitmentsRequest)
              @list_capacity_commitments.call(req, options, &block)
            end

            # Returns information about the capacity commitment.
            #
            # @param name [String]
            #   Required. Resource name of the capacity commitment to retrieve. E.g.,
            #      `projects/myproject/locations/US/capacityCommitments/123`
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Bigquery::Reservation::V1beta1::CapacityCommitment]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Bigquery::Reservation::V1beta1::CapacityCommitment]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/bigquery/reservation"
            #
            #   reservation_client = Google::Cloud::Bigquery::Reservation.new(version: :v1beta1)
            #   formatted_name = Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient.capacity_commitment_path("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]")
            #   response = reservation_client.get_capacity_commitment(formatted_name)

            def get_capacity_commitment \
                name,
                options: nil,
                &block
              req = {
                name: name
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Bigquery::Reservation::V1beta1::GetCapacityCommitmentRequest)
              @get_capacity_commitment.call(req, options, &block)
            end

            # Deletes a capacity commitment. Attempting to delete capacity commitment
            # before its commitment_end_time will fail with the error code
            # `google.rpc.Code.FAILED_PRECONDITION`.
            #
            # @param name [String]
            #   Required. Resource name of the capacity commitment to delete. E.g.,
            #      `projects/myproject/locations/US/capacityCommitments/123`
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result []
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/bigquery/reservation"
            #
            #   reservation_client = Google::Cloud::Bigquery::Reservation.new(version: :v1beta1)
            #   formatted_name = Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient.capacity_commitment_path("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]")
            #   reservation_client.delete_capacity_commitment(formatted_name)

            def delete_capacity_commitment \
                name,
                options: nil,
                &block
              req = {
                name: name
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Bigquery::Reservation::V1beta1::DeleteCapacityCommitmentRequest)
              @delete_capacity_commitment.call(req, options, &block)
              nil
            end

            # Updates an existing capacity commitment.
            #
            # Only `plan` and `renewal_plan` fields can be updated.
            #
            # Plan can only be changed to a plan of a longer commitment period.
            # Attempting to change to a plan with shorter commitment period will fail
            # with the error code `google.rpc.Code.FAILED_PRECONDITION`.
            #
            # @param capacity_commitment [Google::Cloud::Bigquery::Reservation::V1beta1::CapacityCommitment | Hash]
            #   Content of the capacity commitment to update.
            #   A hash of the same form as `Google::Cloud::Bigquery::Reservation::V1beta1::CapacityCommitment`
            #   can also be provided.
            # @param update_mask [Google::Protobuf::FieldMask | Hash]
            #   Standard field mask for the set of fields to be updated.
            #   A hash of the same form as `Google::Protobuf::FieldMask`
            #   can also be provided.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Bigquery::Reservation::V1beta1::CapacityCommitment]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Bigquery::Reservation::V1beta1::CapacityCommitment]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/bigquery/reservation"
            #
            #   reservation_client = Google::Cloud::Bigquery::Reservation.new(version: :v1beta1)
            #   response = reservation_client.update_capacity_commitment

            def update_capacity_commitment \
                capacity_commitment: nil,
                update_mask: nil,
                options: nil,
                &block
              req = {
                capacity_commitment: capacity_commitment,
                update_mask: update_mask
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Bigquery::Reservation::V1beta1::UpdateCapacityCommitmentRequest)
              @update_capacity_commitment.call(req, options, &block)
            end

            # Splits capacity commitment to two commitments of the same plan and
            # `commitment_end_time`.
            #
            # A common use case is to enable downgrading commitments.
            #
            # For example, in order to downgrade from 10000 slots to 8000, you might
            # split a 10000 capacity commitment into commitments of 2000 and 8000. Then,
            # you would change the plan of the first one to `FLEX` and then delete it.
            #
            # @param name [String]
            #   Required. The resource name e.g.,:
            #    `projects/myproject/locations/US/capacityCommitments/123`
            # @param slot_count [Integer]
            #   Number of slots in the capacity commitment after the split.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Bigquery::Reservation::V1beta1::SplitCapacityCommitmentResponse]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Bigquery::Reservation::V1beta1::SplitCapacityCommitmentResponse]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/bigquery/reservation"
            #
            #   reservation_client = Google::Cloud::Bigquery::Reservation.new(version: :v1beta1)
            #   formatted_name = Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient.capacity_commitment_path("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]")
            #   response = reservation_client.split_capacity_commitment(formatted_name)

            def split_capacity_commitment \
                name,
                slot_count: nil,
                options: nil,
                &block
              req = {
                name: name,
                slot_count: slot_count
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Bigquery::Reservation::V1beta1::SplitCapacityCommitmentRequest)
              @split_capacity_commitment.call(req, options, &block)
            end

            # Merges capacity commitments of the same plan into a single commitment.
            #
            # The resulting capacity commitment has the greater commitment_end_time
            # out of the to-be-merged capacity commitments.
            #
            # Attempting to merge capacity commitments of different plan will fail
            # with the error code `google.rpc.Code.FAILED_PRECONDITION`.
            #
            # @param parent [String]
            #   Parent resource that identifies admin project and location e.g.,
            #    `projects/myproject/locations/us`
            # @param capacity_commitment_ids [Array<String>]
            #   Ids of capacity commitments to merge.
            #   These capacity commitments must exist under admin project and location
            #   specified in the parent.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Bigquery::Reservation::V1beta1::CapacityCommitment]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Bigquery::Reservation::V1beta1::CapacityCommitment]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/bigquery/reservation"
            #
            #   reservation_client = Google::Cloud::Bigquery::Reservation.new(version: :v1beta1)
            #   response = reservation_client.merge_capacity_commitments

            def merge_capacity_commitments \
                parent: nil,
                capacity_commitment_ids: nil,
                options: nil,
                &block
              req = {
                parent: parent,
                capacity_commitment_ids: capacity_commitment_ids
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Bigquery::Reservation::V1beta1::MergeCapacityCommitmentsRequest)
              @merge_capacity_commitments.call(req, options, &block)
            end

            # Creates an assignment object which allows the given project to submit jobs
            # of a certain type using slots from the specified reservation.
            #
            # Currently a
            # resource (project, folder, organization) can only have one assignment per
            # each (job_type, location) combination, and that reservation will be used
            # for all jobs of the matching type.
            #
            # Different assignments can be created on different levels of the
            # projects, folders or organization hierarchy.  During query execution,
            # the assignment is looked up at the project, folder and organization levels
            # in that order. The first assignment found is applied to the query.
            #
            # When creating assignments, it does not matter if other assignments exist at
            # higher levels.
            #
            # Example:
            #
            # * The organization `organizationA` contains two projects, `project1`
            #   and `project2`.
            # * Assignments for all three entities (`organizationA`, `project1`, and
            #   `project2`) could all be created and mapped to the same or different
            #   reservations.
            #
            # Returns `google.rpc.Code.PERMISSION_DENIED` if user does not have
            # 'bigquery.admin' permissions on the project using the reservation
            # and the project that owns this reservation.
            #
            # Returns `google.rpc.Code.INVALID_ARGUMENT` when location of the assignment
            # does not match location of the reservation.
            #
            # @param parent [String]
            #   Required. The parent resource name of the assignment
            #   E.g. `projects/myproject/locations/US/reservations/team1-prod`
            # @param assignment [Google::Cloud::Bigquery::Reservation::V1beta1::Assignment | Hash]
            #   Assignment resource to create.
            #   A hash of the same form as `Google::Cloud::Bigquery::Reservation::V1beta1::Assignment`
            #   can also be provided.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Bigquery::Reservation::V1beta1::Assignment]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Bigquery::Reservation::V1beta1::Assignment]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/bigquery/reservation"
            #
            #   reservation_client = Google::Cloud::Bigquery::Reservation.new(version: :v1beta1)
            #   formatted_parent = Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient.reservation_path("[PROJECT]", "[LOCATION]", "[RESERVATION]")
            #   response = reservation_client.create_assignment(formatted_parent)

            def create_assignment \
                parent,
                assignment: nil,
                options: nil,
                &block
              req = {
                parent: parent,
                assignment: assignment
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Bigquery::Reservation::V1beta1::CreateAssignmentRequest)
              @create_assignment.call(req, options, &block)
            end

            # Lists assignments.
            #
            # Only explicitly created assignments will be returned.
            #
            # Example:
            #
            # * Organization `organizationA` contains two projects, `project1` and
            #   `project2`.
            # * Reservation `res1` exists and was created previously.
            # * CreateAssignment was used previously to define the following
            #   associations between entities and reservations: `<organizationA, res1>`
            #   and `<project1, res1>`
            #
            # In this example, ListAssignments will just return the above two assignments
            # for reservation `res1`, and no expansion/merge will happen.
            #
            # The wildcard "-" can be used for
            # reservations in the request. In that case all assignments belongs to the
            # specified project and location will be listed.
            #
            # **Note** "-" cannot be used for projects nor locations.
            #
            # @param parent [String]
            #   Required. The parent resource name e.g.:
            #
            #   `projects/myproject/locations/US/reservations/team1-prod`
            #
            #   Or:
            #
            #   `projects/myproject/locations/US/reservations/-`
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
            # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Bigquery::Reservation::V1beta1::Assignment>]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Gax::PagedEnumerable<Google::Cloud::Bigquery::Reservation::V1beta1::Assignment>]
            #   An enumerable of Google::Cloud::Bigquery::Reservation::V1beta1::Assignment instances.
            #   See Google::Gax::PagedEnumerable documentation for other
            #   operations such as per-page iteration or access to the response
            #   object.
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/bigquery/reservation"
            #
            #   reservation_client = Google::Cloud::Bigquery::Reservation.new(version: :v1beta1)
            #   formatted_parent = Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient.reservation_path("[PROJECT]", "[LOCATION]", "[RESERVATION]")
            #
            #   # Iterate over all results.
            #   reservation_client.list_assignments(formatted_parent).each do |element|
            #     # Process element.
            #   end
            #
            #   # Or iterate over results one page at a time.
            #   reservation_client.list_assignments(formatted_parent).each_page do |page|
            #     # Process each page at a time.
            #     page.each do |element|
            #       # Process element.
            #     end
            #   end

            def list_assignments \
                parent,
                page_size: nil,
                options: nil,
                &block
              req = {
                parent: parent,
                page_size: page_size
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Bigquery::Reservation::V1beta1::ListAssignmentsRequest)
              @list_assignments.call(req, options, &block)
            end

            # Deletes a assignment. No expansion will happen.
            #
            # Example:
            #
            # * Organization `organizationA` contains two projects, `project1` and
            #   `project2`.
            # * Reservation `res1` exists and was created previously.
            # * CreateAssignment was used previously to define the following
            #   associations between entities and reservations: `<organizationA, res1>`
            #   and `<project1, res1>`
            #
            # In this example, deletion of the `<organizationA, res1>` assignment won't
            # affect the other assignment `<project1, res1>`. After said deletion,
            # queries from `project1` will still use `res1` while queries from
            # `project2` will switch to use on-demand mode.
            #
            # @param name [String]
            #   Required. Name of the resource, e.g.
            #     `projects/myproject/locations/US/reservations/team1-prod/assignments/123`
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result []
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/bigquery/reservation"
            #
            #   reservation_client = Google::Cloud::Bigquery::Reservation.new(version: :v1beta1)
            #   formatted_name = Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient.assignment_path("[PROJECT]", "[LOCATION]", "[RESERVATION]", "[ASSIGNMENT]")
            #   reservation_client.delete_assignment(formatted_name)

            def delete_assignment \
                name,
                options: nil,
                &block
              req = {
                name: name
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Bigquery::Reservation::V1beta1::DeleteAssignmentRequest)
              @delete_assignment.call(req, options, &block)
              nil
            end

            # Looks up assignments for a specified resource for a particular region.
            # If the request is about a project:
            #
            # 1. Assignments created on the project will be returned if they exist.
            # 2. Otherwise assignments created on the closest ancestor will be
            #    returned.
            # 3. Assignments for different JobTypes will all be returned.
            #
            # The same logic applies if the request is about a folder.
            #
            # If the request is about an organization, then assignments created on the
            # organization will be returned (organization doesn't have ancestors).
            #
            # Comparing to ListAssignments, there are some behavior
            # differences:
            #
            # 1. permission on the assignee will be verified in this API.
            # 2. Hierarchy lookup (project->folder->organization) happens in this API.
            # 3. Parent here is `projects/*/locations/*`, instead of
            #    `projects/*/locations/*reservations/*`.
            #
            # **Note** "-" cannot be used for projects
            # nor locations.
            #
            # @param parent [String]
            #   Required. The resource name of the admin project(containing project and
            #   location), e.g.:
            #     `projects/myproject/locations/US`.
            # @param query [String]
            #   Please specify resource name as assignee in the query.
            #
            #   Examples:
            #
            #   * `assignee=projects/myproject`
            #   * `assignee=folders/123`
            #   * `assignee=organizations/456`
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
            # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Bigquery::Reservation::V1beta1::Assignment>]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Gax::PagedEnumerable<Google::Cloud::Bigquery::Reservation::V1beta1::Assignment>]
            #   An enumerable of Google::Cloud::Bigquery::Reservation::V1beta1::Assignment instances.
            #   See Google::Gax::PagedEnumerable documentation for other
            #   operations such as per-page iteration or access to the response
            #   object.
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/bigquery/reservation"
            #
            #   reservation_client = Google::Cloud::Bigquery::Reservation.new(version: :v1beta1)
            #   formatted_parent = Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient.location_path("[PROJECT]", "[LOCATION]")
            #
            #   # Iterate over all results.
            #   reservation_client.search_assignments(formatted_parent).each do |element|
            #     # Process element.
            #   end
            #
            #   # Or iterate over results one page at a time.
            #   reservation_client.search_assignments(formatted_parent).each_page do |page|
            #     # Process each page at a time.
            #     page.each do |element|
            #       # Process element.
            #     end
            #   end

            def search_assignments \
                parent,
                query: nil,
                page_size: nil,
                options: nil,
                &block
              req = {
                parent: parent,
                query: query,
                page_size: page_size
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Bigquery::Reservation::V1beta1::SearchAssignmentsRequest)
              @search_assignments.call(req, options, &block)
            end

            # Moves an assignment under a new reservation.
            #
            # This differs from removing an existing assignment and recreating a new one
            # by providing a transactional change that ensures an assignee always has an
            # associated reservation.
            #
            # @param name [String]
            #   Required. The resource name of the assignment,
            #   e.g.
            #   `projects/myproject/locations/US/reservations/team1-prod/assignments/123`
            # @param destination_id [String]
            #   The new reservation ID, e.g.:
            #     `projects/myotherproject/locations/US/reservations/team2-prod`
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Bigquery::Reservation::V1beta1::Assignment]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Bigquery::Reservation::V1beta1::Assignment]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/bigquery/reservation"
            #
            #   reservation_client = Google::Cloud::Bigquery::Reservation.new(version: :v1beta1)
            #   formatted_name = Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient.assignment_path("[PROJECT]", "[LOCATION]", "[RESERVATION]", "[ASSIGNMENT]")
            #   response = reservation_client.move_assignment(formatted_name)

            def move_assignment \
                name,
                destination_id: nil,
                options: nil,
                &block
              req = {
                name: name,
                destination_id: destination_id
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Bigquery::Reservation::V1beta1::MoveAssignmentRequest)
              @move_assignment.call(req, options, &block)
            end

            # Retrieves a BI reservation.
            #
            # @param name [String]
            #   Required. Name of the requested reservation, for example:
            #   `projects/{project_id}/locations/{location_id}/bireservation`
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Bigquery::Reservation::V1beta1::BiReservation]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Bigquery::Reservation::V1beta1::BiReservation]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/bigquery/reservation"
            #
            #   reservation_client = Google::Cloud::Bigquery::Reservation.new(version: :v1beta1)
            #   formatted_name = Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient.bi_reservation_path("[PROJECT]", "[LOCATION]", "[BIRESERVATION]")
            #   response = reservation_client.get_bi_reservation(formatted_name)

            def get_bi_reservation \
                name,
                options: nil,
                &block
              req = {
                name: name
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Bigquery::Reservation::V1beta1::GetBiReservationRequest)
              @get_bi_reservation.call(req, options, &block)
            end

            # Updates a BI reservation.
            #
            # Only fields specified in the `field_mask` are updated.
            #
            # A singleton BI reservation always exists with default size 0.
            # In order to reserve BI capacity it needs to be updated to an amount
            # greater than 0. In order to release BI capacity reservation size
            # must be set to 0.
            #
            # @param reservation [Google::Cloud::Bigquery::Reservation::V1beta1::BiReservation | Hash]
            #   A reservation to update.
            #   A hash of the same form as `Google::Cloud::Bigquery::Reservation::V1beta1::BiReservation`
            #   can also be provided.
            # @param update_mask [Google::Protobuf::FieldMask | Hash]
            #   A list of fields to be updated in this request.
            #   A hash of the same form as `Google::Protobuf::FieldMask`
            #   can also be provided.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Bigquery::Reservation::V1beta1::BiReservation]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Bigquery::Reservation::V1beta1::BiReservation]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/bigquery/reservation"
            #
            #   reservation_client = Google::Cloud::Bigquery::Reservation.new(version: :v1beta1)
            #   response = reservation_client.update_bi_reservation

            def update_bi_reservation \
                reservation: nil,
                update_mask: nil,
                options: nil,
                &block
              req = {
                reservation: reservation,
                update_mask: update_mask
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Bigquery::Reservation::V1beta1::UpdateBiReservationRequest)
              @update_bi_reservation.call(req, options, &block)
            end
          end
        end
      end
    end
  end
end
