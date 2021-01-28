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

require "google/ads/admob"
require "google/ads/admob/v1/ad_mob_api_client"
require "google/ads/admob/v1/admob_api_services_pb"

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

class MockAdMobApiCredentials_v1 < Google::Ads::Admob::V1::Credentials
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

describe Google::Ads::Admob::V1::AdMobApiClient do

  describe 'get_publisher_account' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Ads::Admob::V1::AdMobApiClient#get_publisher_account."

    it 'invokes get_publisher_account without error' do
      # Create request parameters
      formatted_name = Google::Ads::Admob::V1::AdMobApiClient.account_path("[ACCOUNT]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      publisher_id = "publisherId-1858159042"
      reporting_time_zone = "reportingTimeZone1270653197"
      currency_code = "currencyCode1108728155"
      expected_response = {
        name: name_2,
        publisher_id: publisher_id,
        reporting_time_zone: reporting_time_zone,
        currency_code: currency_code
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Ads::Admob::V1::PublisherAccount)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Ads::Admob::V1::GetPublisherAccountRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_publisher_account, mock_method)

      # Mock auth layer
      mock_credentials = MockAdMobApiCredentials_v1.new("get_publisher_account")

      Google::Ads::Admob::V1::AdMobApi::Stub.stub(:new, mock_stub) do
        Google::Ads::Admob::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Ads::Admob.new(version: :v1)

          # Call method
          response = client.get_publisher_account(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_publisher_account(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_publisher_account with error' do
      # Create request parameters
      formatted_name = Google::Ads::Admob::V1::AdMobApiClient.account_path("[ACCOUNT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Ads::Admob::V1::GetPublisherAccountRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_publisher_account, mock_method)

      # Mock auth layer
      mock_credentials = MockAdMobApiCredentials_v1.new("get_publisher_account")

      Google::Ads::Admob::V1::AdMobApi::Stub.stub(:new, mock_stub) do
        Google::Ads::Admob::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Ads::Admob.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.get_publisher_account(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_publisher_accounts' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Ads::Admob::V1::AdMobApiClient#list_publisher_accounts."

    it 'invokes list_publisher_accounts without error' do
      # Create expected grpc response
      next_page_token = ""
      account_element = {}
      account = [account_element]
      expected_response = { next_page_token: next_page_token, account: account }
      expected_response = Google::Gax::to_proto(expected_response, Google::Ads::Admob::V1::ListPublisherAccountsResponse)

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_publisher_accounts, mock_method)

      # Mock auth layer
      mock_credentials = MockAdMobApiCredentials_v1.new("list_publisher_accounts")

      Google::Ads::Admob::V1::AdMobApi::Stub.stub(:new, mock_stub) do
        Google::Ads::Admob::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Ads::Admob.new(version: :v1)

          # Call method
          response = client.list_publisher_accounts

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.account.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_publisher_accounts with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_publisher_accounts, mock_method)

      # Mock auth layer
      mock_credentials = MockAdMobApiCredentials_v1.new("list_publisher_accounts")

      Google::Ads::Admob::V1::AdMobApi::Stub.stub(:new, mock_stub) do
        Google::Ads::Admob::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Ads::Admob.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.list_publisher_accounts
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'generate_network_report' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Ads::Admob::V1::AdMobApiClient#generate_network_report."

    it 'invokes generate_network_report without error' do
      # Create request parameters
      formatted_parent = Google::Ads::Admob::V1::AdMobApiClient.account_path("[ACCOUNT]")
      report_spec = {}

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Ads::Admob::V1::GenerateNetworkReportResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Ads::Admob::V1::GenerateNetworkReportRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(report_spec, Google::Ads::Admob::V1::NetworkReportSpec), request.report_spec)
        OpenStruct.new(execute: [expected_response])
      end
      mock_stub = MockGrpcClientStub_v1.new(:generate_network_report, mock_method)

      # Mock auth layer
      mock_credentials = MockAdMobApiCredentials_v1.new("generate_network_report")

      Google::Ads::Admob::V1::AdMobApi::Stub.stub(:new, mock_stub) do
        Google::Ads::Admob::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Ads::Admob.new(version: :v1)

          # Call method
          response = client.generate_network_report(formatted_parent, report_spec)

          # Verify the response
          assert_equal(1, response.count)
          assert_equal(expected_response, response.first)
        end
      end
    end

    it 'invokes generate_network_report with error' do
      # Create request parameters
      formatted_parent = Google::Ads::Admob::V1::AdMobApiClient.account_path("[ACCOUNT]")
      report_spec = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Ads::Admob::V1::GenerateNetworkReportRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(report_spec, Google::Ads::Admob::V1::NetworkReportSpec), request.report_spec)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:generate_network_report, mock_method)

      # Mock auth layer
      mock_credentials = MockAdMobApiCredentials_v1.new("generate_network_report")

      Google::Ads::Admob::V1::AdMobApi::Stub.stub(:new, mock_stub) do
        Google::Ads::Admob::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Ads::Admob.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.generate_network_report(formatted_parent, report_spec)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'generate_mediation_report' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Ads::Admob::V1::AdMobApiClient#generate_mediation_report."

    it 'invokes generate_mediation_report without error' do
      # Create request parameters
      formatted_parent = Google::Ads::Admob::V1::AdMobApiClient.account_path("[ACCOUNT]")
      report_spec = {}

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Ads::Admob::V1::GenerateMediationReportResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Ads::Admob::V1::GenerateMediationReportRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(report_spec, Google::Ads::Admob::V1::MediationReportSpec), request.report_spec)
        OpenStruct.new(execute: [expected_response])
      end
      mock_stub = MockGrpcClientStub_v1.new(:generate_mediation_report, mock_method)

      # Mock auth layer
      mock_credentials = MockAdMobApiCredentials_v1.new("generate_mediation_report")

      Google::Ads::Admob::V1::AdMobApi::Stub.stub(:new, mock_stub) do
        Google::Ads::Admob::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Ads::Admob.new(version: :v1)

          # Call method
          response = client.generate_mediation_report(formatted_parent, report_spec)

          # Verify the response
          assert_equal(1, response.count)
          assert_equal(expected_response, response.first)
        end
      end
    end

    it 'invokes generate_mediation_report with error' do
      # Create request parameters
      formatted_parent = Google::Ads::Admob::V1::AdMobApiClient.account_path("[ACCOUNT]")
      report_spec = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Ads::Admob::V1::GenerateMediationReportRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(report_spec, Google::Ads::Admob::V1::MediationReportSpec), request.report_spec)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:generate_mediation_report, mock_method)

      # Mock auth layer
      mock_credentials = MockAdMobApiCredentials_v1.new("generate_mediation_report")

      Google::Ads::Admob::V1::AdMobApi::Stub.stub(:new, mock_stub) do
        Google::Ads::Admob::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Ads::Admob.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.generate_mediation_report(formatted_parent, report_spec)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end