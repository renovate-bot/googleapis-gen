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

require "google/cloud/bigquery/reservation/v1beta1/reservation_service_client"

module Google
  module Cloud
    module Bigquery
      module Reservation
        # rubocop:disable LineLength

        ##
        # # Ruby Client for BigQuery Reservation API ([Beta](https://github.com/GoogleCloudPlatform/google-cloud-ruby#versioning))
        #
        # [BigQuery Reservation API][Product Documentation]:
        # A service to modify your BigQuery flat-rate reservations.
        # - [Product Documentation][]
        #
        # ## Quick Start
        # In order to use this library, you first need to go through the following
        # steps:
        #
        # 1. [Select or create a Cloud Platform project.](https://console.cloud.google.com/project)
        # 2. [Enable billing for your project.](https://cloud.google.com/billing/docs/how-to/modify-project#enable_billing_for_a_project)
        # 3. [Enable the BigQuery Reservation API.](https://console.cloud.google.com/apis/library/bigquery-reservation.googleapis.com)
        # 4. [Setup Authentication.](https://googlecloudplatform.github.io/google-cloud-ruby/#/docs/google-cloud/master/guides/authentication)
        #
        # ### Installation
        # ```
        # $ gem install google-cloud-bigquery-reservation
        # ```
        #
        # ### Next Steps
        # - Read the [BigQuery Reservation API Product documentation][Product Documentation]
        #   to learn more about the product and see How-to Guides.
        # - View this [repository's main README](https://github.com/GoogleCloudPlatform/google-cloud-ruby/blob/master/README.md)
        #   to see the full list of Cloud APIs that we cover.
        #
        # [Product Documentation]: https://cloud.google.com/bigquery-reservation
        #
        # ## Enabling Logging
        #
        # To enable logging for this library, set the logger for the underlying [gRPC](https://github.com/grpc/grpc/tree/master/src/ruby) library.
        # The logger that you set may be a Ruby stdlib [`Logger`](https://ruby-doc.org/stdlib-2.5.0/libdoc/logger/rdoc/Logger.html) as shown below,
        # or a [`Google::Cloud::Logging::Logger`](https://googlecloudplatform.github.io/google-cloud-ruby/#/docs/google-cloud-logging/latest/google/cloud/logging/logger)
        # that will write logs to [Stackdriver Logging](https://cloud.google.com/logging/). See [grpc/logconfig.rb](https://github.com/grpc/grpc/blob/master/src/ruby/lib/grpc/logconfig.rb)
        # and the gRPC [spec_helper.rb](https://github.com/grpc/grpc/blob/master/src/ruby/spec/spec_helper.rb) for additional information.
        #
        # Configuring a Ruby stdlib logger:
        #
        # ```ruby
        # require "logger"
        #
        # module MyLogger
        #   LOGGER = Logger.new $stderr, level: Logger::WARN
        #   def logger
        #     LOGGER
        #   end
        # end
        #
        # # Define a gRPC module-level logger method before grpc/logconfig.rb loads.
        # module GRPC
        #   extend MyLogger
        # end
        # ```
        #
        module V1beta1
          # rubocop:enable LineLength

          ##
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
          def self.new \
              credentials: nil,
              scopes: nil,
              client_config: nil,
              timeout: nil,
              metadata: nil,
              exception_transformer: nil,
              lib_name: nil,
              lib_version: nil
            kwargs = {
              credentials: credentials,
              scopes: scopes,
              client_config: client_config,
              timeout: timeout,
              metadata: metadata,
              exception_transformer: exception_transformer,
              lib_name: lib_name,
              lib_version: lib_version
            }.select { |_, v| v != nil }
            Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient.new(**kwargs)
          end
        end
      end
    end
  end
end
