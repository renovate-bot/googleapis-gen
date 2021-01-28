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
# https://github.com/googleapis/googleapis/blob/master/google/cloud/billing/budgets/v1/budget_service.proto,
# and updates to that file get reflected here through a refresh process.
# For the short term, the refresh process will only be runnable by Google
# engineers.

require "json"
require "pathname"

require "google/gax"

require "google/cloud/billing/budgets/v1/budget_service_pb"
require "google/cloud/billing/budgets/v1/credentials"

module Google
  module Cloud
    module Billing
      module Budgets
        module V1
          # BudgetService stores Cloud Billing budgets, which define a
          # budget plan and rules to execute as we track spend against that plan.
          #
          # @!attribute [r] budget_service_stub
          #   @return [Google::Cloud::Billing::Budgets::V1::BudgetService::Stub]
          class BudgetServiceClient
            attr_reader :budget_service_stub

            # The default address of the service.
            SERVICE_ADDRESS = "billingbudgets.googleapis.com".freeze

            # The default port of the service.
            DEFAULT_SERVICE_PORT = 443

            # The default set of gRPC interceptors.
            GRPC_INTERCEPTORS = []

            DEFAULT_TIMEOUT = 30

            PAGE_DESCRIPTORS = {
              "list_budgets" => Google::Gax::PageDescriptor.new(
                "page_token",
                "next_page_token",
                "budgets")
            }.freeze

            private_constant :PAGE_DESCRIPTORS

            # The scopes needed to make gRPC calls to all of the methods defined in
            # this service.
            ALL_SCOPES = [
              "https://www.googleapis.com/auth/cloud-billing",
              "https://www.googleapis.com/auth/cloud-platform"
            ].freeze


            BILLING_ACCOUNT_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
              "billingAccounts/{billing_account}"
            )

            private_constant :BILLING_ACCOUNT_PATH_TEMPLATE

            BUDGET_PATH_TEMPLATE = Google::Gax::PathTemplate.new(
              "billingAccounts/{billing_account}/budgets/{budget}"
            )

            private_constant :BUDGET_PATH_TEMPLATE

            # Returns a fully-qualified billing_account resource name string.
            # @param billing_account [String]
            # @return [String]
            def self.billing_account_path billing_account
              BILLING_ACCOUNT_PATH_TEMPLATE.render(
                :"billing_account" => billing_account
              )
            end

            # Returns a fully-qualified budget resource name string.
            # @param billing_account [String]
            # @param budget [String]
            # @return [String]
            def self.budget_path billing_account, budget
              BUDGET_PATH_TEMPLATE.render(
                :"billing_account" => billing_account,
                :"budget" => budget
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
              require "google/cloud/billing/budgets/v1/budget_service_services_pb"

              credentials ||= Google::Cloud::Billing::Budgets::V1::Credentials.default

              if credentials.is_a?(String) || credentials.is_a?(Hash)
                updater_proc = Google::Cloud::Billing::Budgets::V1::Credentials.new(credentials).updater_proc
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

              package_version = Gem.loaded_specs['google-cloud-billing-budgets'].version.version

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
                "budget_service_client_config.json"
              )
              defaults = client_config_file.open do |f|
                Google::Gax.construct_settings(
                  "google.cloud.billing.budgets.v1.BudgetService",
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
              @budget_service_stub = Google::Gax::Grpc.create_stub(
                service_path,
                port,
                chan_creds: chan_creds,
                channel: channel,
                updater_proc: updater_proc,
                scopes: scopes,
                interceptors: interceptors,
                &Google::Cloud::Billing::Budgets::V1::BudgetService::Stub.method(:new)
              )

              @create_budget = Google::Gax.create_api_call(
                @budget_service_stub.method(:create_budget),
                defaults["create_budget"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'parent' => request.parent}
                end
              )
              @update_budget = Google::Gax.create_api_call(
                @budget_service_stub.method(:update_budget),
                defaults["update_budget"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'budget.name' => request.budget.name}
                end
              )
              @get_budget = Google::Gax.create_api_call(
                @budget_service_stub.method(:get_budget),
                defaults["get_budget"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
              @list_budgets = Google::Gax.create_api_call(
                @budget_service_stub.method(:list_budgets),
                defaults["list_budgets"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'parent' => request.parent}
                end
              )
              @delete_budget = Google::Gax.create_api_call(
                @budget_service_stub.method(:delete_budget),
                defaults["delete_budget"],
                exception_transformer: exception_transformer,
                params_extractor: proc do |request|
                  {'name' => request.name}
                end
              )
            end

            # Service calls

            # Creates a new budget. See
            # [Quotas and limits](https://cloud.google.com/billing/quotas)
            # for more information on the limits of the number of budgets you can create.
            #
            # @param parent [String]
            #   Required. The name of the billing account to create the budget in. Values
            #   are of the form `billingAccounts/{billingAccountId}`.
            # @param budget [Google::Cloud::Billing::Budgets::V1::Budget | Hash]
            #   Required. Budget to create.
            #   A hash of the same form as `Google::Cloud::Billing::Budgets::V1::Budget`
            #   can also be provided.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Billing::Budgets::V1::Budget]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Billing::Budgets::V1::Budget]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/billing/budgets"
            #
            #   budget_client = Google::Cloud::Billing::Budgets.new(version: :v1)
            #   formatted_parent = Google::Cloud::Billing::Budgets::V1::BudgetServiceClient.billing_account_path("[BILLING_ACCOUNT]")
            #
            #   # TODO: Initialize `budget`:
            #   budget = {}
            #   response = budget_client.create_budget(formatted_parent, budget)

            def create_budget \
                parent,
                budget,
                options: nil,
                &block
              req = {
                parent: parent,
                budget: budget
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Billing::Budgets::V1::CreateBudgetRequest)
              @create_budget.call(req, options, &block)
            end

            # Updates a budget and returns the updated budget.
            #
            # WARNING: There are some fields exposed on the Google Cloud Console that
            # aren't available on this API. Budget fields that are not exposed in
            # this API will not be changed by this method.
            #
            # @param budget [Google::Cloud::Billing::Budgets::V1::Budget | Hash]
            #   Required. The updated budget object.
            #   The budget to update is specified by the budget name in the budget.
            #   A hash of the same form as `Google::Cloud::Billing::Budgets::V1::Budget`
            #   can also be provided.
            # @param update_mask [Google::Protobuf::FieldMask | Hash]
            #   Optional. Indicates which fields in the provided budget to update.
            #   Read-only fields (such as `name`) cannot be changed. If this is not
            #   provided, then only fields with non-default values from the request are
            #   updated. See
            #   https://developers.google.com/protocol-buffers/docs/proto3#default for more
            #   details about default values.
            #   A hash of the same form as `Google::Protobuf::FieldMask`
            #   can also be provided.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Billing::Budgets::V1::Budget]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Billing::Budgets::V1::Budget]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/billing/budgets"
            #
            #   budget_client = Google::Cloud::Billing::Budgets.new(version: :v1)
            #
            #   # TODO: Initialize `budget`:
            #   budget = {}
            #   response = budget_client.update_budget(budget)

            def update_budget \
                budget,
                update_mask: nil,
                options: nil,
                &block
              req = {
                budget: budget,
                update_mask: update_mask
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Billing::Budgets::V1::UpdateBudgetRequest)
              @update_budget.call(req, options, &block)
            end

            # Returns a budget.
            #
            # WARNING: There are some fields exposed on the Google Cloud Console that
            # aren't available on this API. When reading from the API, you will not
            # see these fields in the return value, though they may have been set
            # in the Cloud Console.
            #
            # @param name [String]
            #   Required. Name of budget to get. Values are of the form
            #   `billingAccounts/{billingAccountId}/budgets/{budgetId}`.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result [Google::Cloud::Billing::Budgets::V1::Budget]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Cloud::Billing::Budgets::V1::Budget]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/billing/budgets"
            #
            #   budget_client = Google::Cloud::Billing::Budgets.new(version: :v1)
            #   formatted_name = Google::Cloud::Billing::Budgets::V1::BudgetServiceClient.budget_path("[BILLING_ACCOUNT]", "[BUDGET]")
            #   response = budget_client.get_budget(formatted_name)

            def get_budget \
                name,
                options: nil,
                &block
              req = {
                name: name
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Billing::Budgets::V1::GetBudgetRequest)
              @get_budget.call(req, options, &block)
            end

            # Returns a list of budgets for a billing account.
            #
            # WARNING: There are some fields exposed on the Google Cloud Console that
            # aren't available on this API. When reading from the API, you will not
            # see these fields in the return value, though they may have been set
            # in the Cloud Console.
            #
            # @param parent [String]
            #   Required. Name of billing account to list budgets under. Values
            #   are of the form `billingAccounts/{billingAccountId}`.
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
            # @yieldparam result [Google::Gax::PagedEnumerable<Google::Cloud::Billing::Budgets::V1::Budget>]
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @return [Google::Gax::PagedEnumerable<Google::Cloud::Billing::Budgets::V1::Budget>]
            #   An enumerable of Google::Cloud::Billing::Budgets::V1::Budget instances.
            #   See Google::Gax::PagedEnumerable documentation for other
            #   operations such as per-page iteration or access to the response
            #   object.
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/billing/budgets"
            #
            #   budget_client = Google::Cloud::Billing::Budgets.new(version: :v1)
            #   formatted_parent = Google::Cloud::Billing::Budgets::V1::BudgetServiceClient.billing_account_path("[BILLING_ACCOUNT]")
            #
            #   # Iterate over all results.
            #   budget_client.list_budgets(formatted_parent).each do |element|
            #     # Process element.
            #   end
            #
            #   # Or iterate over results one page at a time.
            #   budget_client.list_budgets(formatted_parent).each_page do |page|
            #     # Process each page at a time.
            #     page.each do |element|
            #       # Process element.
            #     end
            #   end

            def list_budgets \
                parent,
                page_size: nil,
                options: nil,
                &block
              req = {
                parent: parent,
                page_size: page_size
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Billing::Budgets::V1::ListBudgetsRequest)
              @list_budgets.call(req, options, &block)
            end

            # Deletes a budget. Returns successfully if already deleted.
            #
            # @param name [String]
            #   Required. Name of the budget to delete. Values are of the form
            #   `billingAccounts/{billingAccountId}/budgets/{budgetId}`.
            # @param options [Google::Gax::CallOptions]
            #   Overrides the default settings for this call, e.g, timeout,
            #   retries, etc.
            # @yield [result, operation] Access the result along with the RPC operation
            # @yieldparam result []
            # @yieldparam operation [GRPC::ActiveCall::Operation]
            # @raise [Google::Gax::GaxError] if the RPC is aborted.
            # @example
            #   require "google/cloud/billing/budgets"
            #
            #   budget_client = Google::Cloud::Billing::Budgets.new(version: :v1)
            #   formatted_name = Google::Cloud::Billing::Budgets::V1::BudgetServiceClient.budget_path("[BILLING_ACCOUNT]", "[BUDGET]")
            #   budget_client.delete_budget(formatted_name)

            def delete_budget \
                name,
                options: nil,
                &block
              req = {
                name: name
              }.delete_if { |_, v| v.nil? }
              req = Google::Gax::to_proto(req, Google::Cloud::Billing::Budgets::V1::DeleteBudgetRequest)
              @delete_budget.call(req, options, &block)
              nil
            end
          end
        end
      end
    end
  end
end
