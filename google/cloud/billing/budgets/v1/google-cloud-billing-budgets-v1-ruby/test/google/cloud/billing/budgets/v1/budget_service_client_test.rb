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

require "minitest/autorun"
require "minitest/spec"

require "google/gax"

require "google/cloud/billing/budgets"
require "google/cloud/billing/budgets/v1/budget_service_client"
require "google/cloud/billing/budgets/v1/budget_service_services_pb"

class CustomTestError_v1 < StandardError; end

# Mock for the GRPC::ClientStub class.
class MockGrpcClientStub_v1

  # @param expected_symbol [Symbol] the symbol of the grpc method to be mocked.
  # @param mock_method [Proc] The method that is being mocked.
  def initialize(expected_symbol, mock_method)
    @expected_symbol = expected_symbol
    @mock_method = mock_method
  end

  # This overrides the Object#method method to return the mocked method when the mocked method
  # is being requested. For methods that aren't being tested, this method returns a proc that
  # will raise an error when called. This is to assure that only the mocked grpc method is being
  # called.
  #
  # @param symbol [Symbol] The symbol of the method being requested.
  # @return [Proc] The proc of the requested method. If the requested method is not being mocked
  #   the proc returned will raise when called.
  def method(symbol)
    return @mock_method if symbol == @expected_symbol

    # The requested method is not being tested, raise if it called.
    proc do
      raise "The method #{symbol} was unexpectedly called during the " \
        "test for #{@expected_symbol}."
    end
  end
end

class MockBudgetServiceCredentials_v1 < Google::Cloud::Billing::Budgets::V1::Credentials
  def initialize(method_name)
    @method_name = method_name
  end

  def updater_proc
    proc do
      raise "The method `#{@method_name}` was trying to make a grpc request. This should not " \
          "happen since the grpc layer is being mocked."
    end
  end
end

describe Google::Cloud::Billing::Budgets::V1::BudgetServiceClient do

  describe 'create_budget' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Billing::Budgets::V1::BudgetServiceClient#create_budget."

    it 'invokes create_budget without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Billing::Budgets::V1::BudgetServiceClient.billing_account_path("[BILLING_ACCOUNT]")
      budget = {}

      # Create expected grpc response
      name = "name3373707"
      display_name = "displayName1615086568"
      etag = "etag3123477"
      expected_response = {
        name: name,
        display_name: display_name,
        etag: etag
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Billing::Budgets::V1::Budget)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Billing::Budgets::V1::CreateBudgetRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(budget, Google::Cloud::Billing::Budgets::V1::Budget), request.budget)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:create_budget, mock_method)

      # Mock auth layer
      mock_credentials = MockBudgetServiceCredentials_v1.new("create_budget")

      Google::Cloud::Billing::Budgets::V1::BudgetService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Billing::Budgets::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Billing::Budgets.new(version: :v1)

          # Call method
          response = client.create_budget(formatted_parent, budget)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_budget(formatted_parent, budget) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_budget with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Billing::Budgets::V1::BudgetServiceClient.billing_account_path("[BILLING_ACCOUNT]")
      budget = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Billing::Budgets::V1::CreateBudgetRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(budget, Google::Cloud::Billing::Budgets::V1::Budget), request.budget)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:create_budget, mock_method)

      # Mock auth layer
      mock_credentials = MockBudgetServiceCredentials_v1.new("create_budget")

      Google::Cloud::Billing::Budgets::V1::BudgetService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Billing::Budgets::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Billing::Budgets.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.create_budget(formatted_parent, budget)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_budget' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Billing::Budgets::V1::BudgetServiceClient#update_budget."

    it 'invokes update_budget without error' do
      # Create request parameters
      budget = {}

      # Create expected grpc response
      name = "name3373707"
      display_name = "displayName1615086568"
      etag = "etag3123477"
      expected_response = {
        name: name,
        display_name: display_name,
        etag: etag
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Billing::Budgets::V1::Budget)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Billing::Budgets::V1::UpdateBudgetRequest, request)
        assert_equal(Google::Gax::to_proto(budget, Google::Cloud::Billing::Budgets::V1::Budget), request.budget)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:update_budget, mock_method)

      # Mock auth layer
      mock_credentials = MockBudgetServiceCredentials_v1.new("update_budget")

      Google::Cloud::Billing::Budgets::V1::BudgetService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Billing::Budgets::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Billing::Budgets.new(version: :v1)

          # Call method
          response = client.update_budget(budget)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.update_budget(budget) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes update_budget with error' do
      # Create request parameters
      budget = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Billing::Budgets::V1::UpdateBudgetRequest, request)
        assert_equal(Google::Gax::to_proto(budget, Google::Cloud::Billing::Budgets::V1::Budget), request.budget)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:update_budget, mock_method)

      # Mock auth layer
      mock_credentials = MockBudgetServiceCredentials_v1.new("update_budget")

      Google::Cloud::Billing::Budgets::V1::BudgetService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Billing::Budgets::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Billing::Budgets.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.update_budget(budget)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_budget' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Billing::Budgets::V1::BudgetServiceClient#get_budget."

    it 'invokes get_budget without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Billing::Budgets::V1::BudgetServiceClient.budget_path("[BILLING_ACCOUNT]", "[BUDGET]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      display_name = "displayName1615086568"
      etag = "etag3123477"
      expected_response = {
        name: name_2,
        display_name: display_name,
        etag: etag
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Billing::Budgets::V1::Budget)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Billing::Budgets::V1::GetBudgetRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_budget, mock_method)

      # Mock auth layer
      mock_credentials = MockBudgetServiceCredentials_v1.new("get_budget")

      Google::Cloud::Billing::Budgets::V1::BudgetService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Billing::Budgets::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Billing::Budgets.new(version: :v1)

          # Call method
          response = client.get_budget(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_budget(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_budget with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Billing::Budgets::V1::BudgetServiceClient.budget_path("[BILLING_ACCOUNT]", "[BUDGET]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Billing::Budgets::V1::GetBudgetRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_budget, mock_method)

      # Mock auth layer
      mock_credentials = MockBudgetServiceCredentials_v1.new("get_budget")

      Google::Cloud::Billing::Budgets::V1::BudgetService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Billing::Budgets::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Billing::Budgets.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.get_budget(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_budgets' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Billing::Budgets::V1::BudgetServiceClient#list_budgets."

    it 'invokes list_budgets without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Billing::Budgets::V1::BudgetServiceClient.billing_account_path("[BILLING_ACCOUNT]")

      # Create expected grpc response
      next_page_token = ""
      budgets_element = {}
      budgets = [budgets_element]
      expected_response = { next_page_token: next_page_token, budgets: budgets }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Billing::Budgets::V1::ListBudgetsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Billing::Budgets::V1::ListBudgetsRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_budgets, mock_method)

      # Mock auth layer
      mock_credentials = MockBudgetServiceCredentials_v1.new("list_budgets")

      Google::Cloud::Billing::Budgets::V1::BudgetService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Billing::Budgets::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Billing::Budgets.new(version: :v1)

          # Call method
          response = client.list_budgets(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.budgets.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_budgets with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Billing::Budgets::V1::BudgetServiceClient.billing_account_path("[BILLING_ACCOUNT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Billing::Budgets::V1::ListBudgetsRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_budgets, mock_method)

      # Mock auth layer
      mock_credentials = MockBudgetServiceCredentials_v1.new("list_budgets")

      Google::Cloud::Billing::Budgets::V1::BudgetService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Billing::Budgets::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Billing::Budgets.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.list_budgets(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_budget' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Billing::Budgets::V1::BudgetServiceClient#delete_budget."

    it 'invokes delete_budget without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Billing::Budgets::V1::BudgetServiceClient.budget_path("[BILLING_ACCOUNT]", "[BUDGET]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Billing::Budgets::V1::DeleteBudgetRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_budget, mock_method)

      # Mock auth layer
      mock_credentials = MockBudgetServiceCredentials_v1.new("delete_budget")

      Google::Cloud::Billing::Budgets::V1::BudgetService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Billing::Budgets::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Billing::Budgets.new(version: :v1)

          # Call method
          response = client.delete_budget(formatted_name)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.delete_budget(formatted_name) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes delete_budget with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Billing::Budgets::V1::BudgetServiceClient.budget_path("[BILLING_ACCOUNT]", "[BUDGET]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Billing::Budgets::V1::DeleteBudgetRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_budget, mock_method)

      # Mock auth layer
      mock_credentials = MockBudgetServiceCredentials_v1.new("delete_budget")

      Google::Cloud::Billing::Budgets::V1::BudgetService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Billing::Budgets::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Billing::Budgets.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.delete_budget(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end