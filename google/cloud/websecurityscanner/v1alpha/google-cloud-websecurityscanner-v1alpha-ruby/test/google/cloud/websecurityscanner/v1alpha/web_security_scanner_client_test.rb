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

require "google/cloud/websecurityscanner/v1alpha"
require "google/cloud/websecurityscanner/v1alpha/web_security_scanner_client"
require "google/cloud/websecurityscanner/v1alpha/web_security_scanner_services_pb"

class CustomTestError_v1alpha < StandardError; end

# Mock for the GRPC::ClientStub class.
class MockGrpcClientStub_v1alpha

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

class MockWebSecurityScannerCredentials_v1alpha < Google::Cloud::Websecurityscanner::V1alpha::Credentials
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

describe Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScannerClient do

  describe 'create_scan_config' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScannerClient#create_scan_config."

    it 'invokes create_scan_config without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScannerClient.project_path("[PROJECT]")
      scan_config = {}

      # Create expected grpc response
      name = "name3373707"
      display_name = "displayName1615086568"
      max_qps = 844445913
      expected_response = {
        name: name,
        display_name: display_name,
        max_qps: max_qps
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Websecurityscanner::V1alpha::ScanConfig)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Websecurityscanner::V1alpha::CreateScanConfigRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(scan_config, Google::Cloud::Websecurityscanner::V1alpha::ScanConfig), request.scan_config)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:create_scan_config, mock_method)

      # Mock auth layer
      mock_credentials = MockWebSecurityScannerCredentials_v1alpha.new("create_scan_config")

      Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScanner::Stub.stub(:new, mock_stub) do
        Google::Cloud::Websecurityscanner::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Websecurityscanner::V1alpha.new

          # Call method
          response = client.create_scan_config(formatted_parent, scan_config)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_scan_config(formatted_parent, scan_config) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_scan_config with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScannerClient.project_path("[PROJECT]")
      scan_config = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Websecurityscanner::V1alpha::CreateScanConfigRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(scan_config, Google::Cloud::Websecurityscanner::V1alpha::ScanConfig), request.scan_config)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:create_scan_config, mock_method)

      # Mock auth layer
      mock_credentials = MockWebSecurityScannerCredentials_v1alpha.new("create_scan_config")

      Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScanner::Stub.stub(:new, mock_stub) do
        Google::Cloud::Websecurityscanner::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Websecurityscanner::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.create_scan_config(formatted_parent, scan_config)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_scan_config' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScannerClient#delete_scan_config."

    it 'invokes delete_scan_config without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScannerClient.scan_config_path("[PROJECT]", "[SCAN_CONFIG]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Websecurityscanner::V1alpha::DeleteScanConfigRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:delete_scan_config, mock_method)

      # Mock auth layer
      mock_credentials = MockWebSecurityScannerCredentials_v1alpha.new("delete_scan_config")

      Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScanner::Stub.stub(:new, mock_stub) do
        Google::Cloud::Websecurityscanner::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Websecurityscanner::V1alpha.new

          # Call method
          response = client.delete_scan_config(formatted_name)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.delete_scan_config(formatted_name) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes delete_scan_config with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScannerClient.scan_config_path("[PROJECT]", "[SCAN_CONFIG]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Websecurityscanner::V1alpha::DeleteScanConfigRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:delete_scan_config, mock_method)

      # Mock auth layer
      mock_credentials = MockWebSecurityScannerCredentials_v1alpha.new("delete_scan_config")

      Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScanner::Stub.stub(:new, mock_stub) do
        Google::Cloud::Websecurityscanner::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Websecurityscanner::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.delete_scan_config(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_scan_config' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScannerClient#get_scan_config."

    it 'invokes get_scan_config without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScannerClient.scan_config_path("[PROJECT]", "[SCAN_CONFIG]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      display_name = "displayName1615086568"
      max_qps = 844445913
      expected_response = {
        name: name_2,
        display_name: display_name,
        max_qps: max_qps
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Websecurityscanner::V1alpha::ScanConfig)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Websecurityscanner::V1alpha::GetScanConfigRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:get_scan_config, mock_method)

      # Mock auth layer
      mock_credentials = MockWebSecurityScannerCredentials_v1alpha.new("get_scan_config")

      Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScanner::Stub.stub(:new, mock_stub) do
        Google::Cloud::Websecurityscanner::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Websecurityscanner::V1alpha.new

          # Call method
          response = client.get_scan_config(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_scan_config(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_scan_config with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScannerClient.scan_config_path("[PROJECT]", "[SCAN_CONFIG]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Websecurityscanner::V1alpha::GetScanConfigRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:get_scan_config, mock_method)

      # Mock auth layer
      mock_credentials = MockWebSecurityScannerCredentials_v1alpha.new("get_scan_config")

      Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScanner::Stub.stub(:new, mock_stub) do
        Google::Cloud::Websecurityscanner::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Websecurityscanner::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.get_scan_config(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_scan_configs' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScannerClient#list_scan_configs."

    it 'invokes list_scan_configs without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScannerClient.project_path("[PROJECT]")

      # Create expected grpc response
      next_page_token = ""
      scan_configs_element = {}
      scan_configs = [scan_configs_element]
      expected_response = { next_page_token: next_page_token, scan_configs: scan_configs }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Websecurityscanner::V1alpha::ListScanConfigsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Websecurityscanner::V1alpha::ListScanConfigsRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:list_scan_configs, mock_method)

      # Mock auth layer
      mock_credentials = MockWebSecurityScannerCredentials_v1alpha.new("list_scan_configs")

      Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScanner::Stub.stub(:new, mock_stub) do
        Google::Cloud::Websecurityscanner::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Websecurityscanner::V1alpha.new

          # Call method
          response = client.list_scan_configs(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.scan_configs.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_scan_configs with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScannerClient.project_path("[PROJECT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Websecurityscanner::V1alpha::ListScanConfigsRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:list_scan_configs, mock_method)

      # Mock auth layer
      mock_credentials = MockWebSecurityScannerCredentials_v1alpha.new("list_scan_configs")

      Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScanner::Stub.stub(:new, mock_stub) do
        Google::Cloud::Websecurityscanner::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Websecurityscanner::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.list_scan_configs(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_scan_config' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScannerClient#update_scan_config."

    it 'invokes update_scan_config without error' do
      # Create request parameters
      scan_config = {}
      update_mask = {}

      # Create expected grpc response
      name = "name3373707"
      display_name = "displayName1615086568"
      max_qps = 844445913
      expected_response = {
        name: name,
        display_name: display_name,
        max_qps: max_qps
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Websecurityscanner::V1alpha::ScanConfig)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Websecurityscanner::V1alpha::UpdateScanConfigRequest, request)
        assert_equal(Google::Gax::to_proto(scan_config, Google::Cloud::Websecurityscanner::V1alpha::ScanConfig), request.scan_config)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:update_scan_config, mock_method)

      # Mock auth layer
      mock_credentials = MockWebSecurityScannerCredentials_v1alpha.new("update_scan_config")

      Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScanner::Stub.stub(:new, mock_stub) do
        Google::Cloud::Websecurityscanner::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Websecurityscanner::V1alpha.new

          # Call method
          response = client.update_scan_config(scan_config, update_mask)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.update_scan_config(scan_config, update_mask) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes update_scan_config with error' do
      # Create request parameters
      scan_config = {}
      update_mask = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Websecurityscanner::V1alpha::UpdateScanConfigRequest, request)
        assert_equal(Google::Gax::to_proto(scan_config, Google::Cloud::Websecurityscanner::V1alpha::ScanConfig), request.scan_config)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:update_scan_config, mock_method)

      # Mock auth layer
      mock_credentials = MockWebSecurityScannerCredentials_v1alpha.new("update_scan_config")

      Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScanner::Stub.stub(:new, mock_stub) do
        Google::Cloud::Websecurityscanner::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Websecurityscanner::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.update_scan_config(scan_config, update_mask)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'start_scan_run' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScannerClient#start_scan_run."

    it 'invokes start_scan_run without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScannerClient.scan_config_path("[PROJECT]", "[SCAN_CONFIG]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      urls_crawled_count = 1749797253
      urls_tested_count = 1498664068
      has_vulnerabilities = false
      progress_percent = 2137894861
      expected_response = {
        name: name_2,
        urls_crawled_count: urls_crawled_count,
        urls_tested_count: urls_tested_count,
        has_vulnerabilities: has_vulnerabilities,
        progress_percent: progress_percent
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Websecurityscanner::V1alpha::ScanRun)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Websecurityscanner::V1alpha::StartScanRunRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:start_scan_run, mock_method)

      # Mock auth layer
      mock_credentials = MockWebSecurityScannerCredentials_v1alpha.new("start_scan_run")

      Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScanner::Stub.stub(:new, mock_stub) do
        Google::Cloud::Websecurityscanner::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Websecurityscanner::V1alpha.new

          # Call method
          response = client.start_scan_run(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.start_scan_run(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes start_scan_run with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScannerClient.scan_config_path("[PROJECT]", "[SCAN_CONFIG]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Websecurityscanner::V1alpha::StartScanRunRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:start_scan_run, mock_method)

      # Mock auth layer
      mock_credentials = MockWebSecurityScannerCredentials_v1alpha.new("start_scan_run")

      Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScanner::Stub.stub(:new, mock_stub) do
        Google::Cloud::Websecurityscanner::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Websecurityscanner::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.start_scan_run(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_scan_run' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScannerClient#get_scan_run."

    it 'invokes get_scan_run without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScannerClient.scan_run_path("[PROJECT]", "[SCAN_CONFIG]", "[SCAN_RUN]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      urls_crawled_count = 1749797253
      urls_tested_count = 1498664068
      has_vulnerabilities = false
      progress_percent = 2137894861
      expected_response = {
        name: name_2,
        urls_crawled_count: urls_crawled_count,
        urls_tested_count: urls_tested_count,
        has_vulnerabilities: has_vulnerabilities,
        progress_percent: progress_percent
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Websecurityscanner::V1alpha::ScanRun)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Websecurityscanner::V1alpha::GetScanRunRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:get_scan_run, mock_method)

      # Mock auth layer
      mock_credentials = MockWebSecurityScannerCredentials_v1alpha.new("get_scan_run")

      Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScanner::Stub.stub(:new, mock_stub) do
        Google::Cloud::Websecurityscanner::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Websecurityscanner::V1alpha.new

          # Call method
          response = client.get_scan_run(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_scan_run(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_scan_run with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScannerClient.scan_run_path("[PROJECT]", "[SCAN_CONFIG]", "[SCAN_RUN]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Websecurityscanner::V1alpha::GetScanRunRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:get_scan_run, mock_method)

      # Mock auth layer
      mock_credentials = MockWebSecurityScannerCredentials_v1alpha.new("get_scan_run")

      Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScanner::Stub.stub(:new, mock_stub) do
        Google::Cloud::Websecurityscanner::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Websecurityscanner::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.get_scan_run(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_scan_runs' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScannerClient#list_scan_runs."

    it 'invokes list_scan_runs without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScannerClient.scan_config_path("[PROJECT]", "[SCAN_CONFIG]")

      # Create expected grpc response
      next_page_token = ""
      scan_runs_element = {}
      scan_runs = [scan_runs_element]
      expected_response = { next_page_token: next_page_token, scan_runs: scan_runs }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Websecurityscanner::V1alpha::ListScanRunsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Websecurityscanner::V1alpha::ListScanRunsRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:list_scan_runs, mock_method)

      # Mock auth layer
      mock_credentials = MockWebSecurityScannerCredentials_v1alpha.new("list_scan_runs")

      Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScanner::Stub.stub(:new, mock_stub) do
        Google::Cloud::Websecurityscanner::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Websecurityscanner::V1alpha.new

          # Call method
          response = client.list_scan_runs(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.scan_runs.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_scan_runs with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScannerClient.scan_config_path("[PROJECT]", "[SCAN_CONFIG]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Websecurityscanner::V1alpha::ListScanRunsRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:list_scan_runs, mock_method)

      # Mock auth layer
      mock_credentials = MockWebSecurityScannerCredentials_v1alpha.new("list_scan_runs")

      Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScanner::Stub.stub(:new, mock_stub) do
        Google::Cloud::Websecurityscanner::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Websecurityscanner::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.list_scan_runs(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'stop_scan_run' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScannerClient#stop_scan_run."

    it 'invokes stop_scan_run without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScannerClient.scan_run_path("[PROJECT]", "[SCAN_CONFIG]", "[SCAN_RUN]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      urls_crawled_count = 1749797253
      urls_tested_count = 1498664068
      has_vulnerabilities = false
      progress_percent = 2137894861
      expected_response = {
        name: name_2,
        urls_crawled_count: urls_crawled_count,
        urls_tested_count: urls_tested_count,
        has_vulnerabilities: has_vulnerabilities,
        progress_percent: progress_percent
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Websecurityscanner::V1alpha::ScanRun)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Websecurityscanner::V1alpha::StopScanRunRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:stop_scan_run, mock_method)

      # Mock auth layer
      mock_credentials = MockWebSecurityScannerCredentials_v1alpha.new("stop_scan_run")

      Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScanner::Stub.stub(:new, mock_stub) do
        Google::Cloud::Websecurityscanner::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Websecurityscanner::V1alpha.new

          # Call method
          response = client.stop_scan_run(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.stop_scan_run(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes stop_scan_run with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScannerClient.scan_run_path("[PROJECT]", "[SCAN_CONFIG]", "[SCAN_RUN]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Websecurityscanner::V1alpha::StopScanRunRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:stop_scan_run, mock_method)

      # Mock auth layer
      mock_credentials = MockWebSecurityScannerCredentials_v1alpha.new("stop_scan_run")

      Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScanner::Stub.stub(:new, mock_stub) do
        Google::Cloud::Websecurityscanner::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Websecurityscanner::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.stop_scan_run(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_crawled_urls' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScannerClient#list_crawled_urls."

    it 'invokes list_crawled_urls without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScannerClient.scan_run_path("[PROJECT]", "[SCAN_CONFIG]", "[SCAN_RUN]")

      # Create expected grpc response
      next_page_token = ""
      crawled_urls_element = {}
      crawled_urls = [crawled_urls_element]
      expected_response = { next_page_token: next_page_token, crawled_urls: crawled_urls }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Websecurityscanner::V1alpha::ListCrawledUrlsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Websecurityscanner::V1alpha::ListCrawledUrlsRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:list_crawled_urls, mock_method)

      # Mock auth layer
      mock_credentials = MockWebSecurityScannerCredentials_v1alpha.new("list_crawled_urls")

      Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScanner::Stub.stub(:new, mock_stub) do
        Google::Cloud::Websecurityscanner::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Websecurityscanner::V1alpha.new

          # Call method
          response = client.list_crawled_urls(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.crawled_urls.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_crawled_urls with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScannerClient.scan_run_path("[PROJECT]", "[SCAN_CONFIG]", "[SCAN_RUN]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Websecurityscanner::V1alpha::ListCrawledUrlsRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:list_crawled_urls, mock_method)

      # Mock auth layer
      mock_credentials = MockWebSecurityScannerCredentials_v1alpha.new("list_crawled_urls")

      Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScanner::Stub.stub(:new, mock_stub) do
        Google::Cloud::Websecurityscanner::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Websecurityscanner::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.list_crawled_urls(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_finding' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScannerClient#get_finding."

    it 'invokes get_finding without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScannerClient.finding_path("[PROJECT]", "[SCAN_CONFIG]", "[SCAN_RUN]", "[FINDING]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      http_method = "httpMethod820747384"
      fuzzed_url = "fuzzedUrl-2120677666"
      body = "body3029410"
      description = "description-1724546052"
      reproduction_url = "reproductionUrl-244934180"
      frame_url = "frameUrl545464221"
      final_url = "finalUrl355601190"
      tracking_id = "trackingId1878901667"
      expected_response = {
        name: name_2,
        http_method: http_method,
        fuzzed_url: fuzzed_url,
        body: body,
        description: description,
        reproduction_url: reproduction_url,
        frame_url: frame_url,
        final_url: final_url,
        tracking_id: tracking_id
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Websecurityscanner::V1alpha::Finding)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Websecurityscanner::V1alpha::GetFindingRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:get_finding, mock_method)

      # Mock auth layer
      mock_credentials = MockWebSecurityScannerCredentials_v1alpha.new("get_finding")

      Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScanner::Stub.stub(:new, mock_stub) do
        Google::Cloud::Websecurityscanner::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Websecurityscanner::V1alpha.new

          # Call method
          response = client.get_finding(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_finding(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_finding with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScannerClient.finding_path("[PROJECT]", "[SCAN_CONFIG]", "[SCAN_RUN]", "[FINDING]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Websecurityscanner::V1alpha::GetFindingRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:get_finding, mock_method)

      # Mock auth layer
      mock_credentials = MockWebSecurityScannerCredentials_v1alpha.new("get_finding")

      Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScanner::Stub.stub(:new, mock_stub) do
        Google::Cloud::Websecurityscanner::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Websecurityscanner::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.get_finding(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_findings' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScannerClient#list_findings."

    it 'invokes list_findings without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScannerClient.scan_run_path("[PROJECT]", "[SCAN_CONFIG]", "[SCAN_RUN]")
      filter = ''

      # Create expected grpc response
      next_page_token = ""
      findings_element = {}
      findings = [findings_element]
      expected_response = { next_page_token: next_page_token, findings: findings }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Websecurityscanner::V1alpha::ListFindingsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Websecurityscanner::V1alpha::ListFindingsRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(filter, request.filter)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:list_findings, mock_method)

      # Mock auth layer
      mock_credentials = MockWebSecurityScannerCredentials_v1alpha.new("list_findings")

      Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScanner::Stub.stub(:new, mock_stub) do
        Google::Cloud::Websecurityscanner::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Websecurityscanner::V1alpha.new

          # Call method
          response = client.list_findings(formatted_parent, filter)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.findings.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_findings with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScannerClient.scan_run_path("[PROJECT]", "[SCAN_CONFIG]", "[SCAN_RUN]")
      filter = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Websecurityscanner::V1alpha::ListFindingsRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(filter, request.filter)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:list_findings, mock_method)

      # Mock auth layer
      mock_credentials = MockWebSecurityScannerCredentials_v1alpha.new("list_findings")

      Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScanner::Stub.stub(:new, mock_stub) do
        Google::Cloud::Websecurityscanner::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Websecurityscanner::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.list_findings(formatted_parent, filter)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_finding_type_stats' do
    custom_error = CustomTestError_v1alpha.new "Custom test error for Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScannerClient#list_finding_type_stats."

    it 'invokes list_finding_type_stats without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScannerClient.scan_run_path("[PROJECT]", "[SCAN_CONFIG]", "[SCAN_RUN]")

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Websecurityscanner::V1alpha::ListFindingTypeStatsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Websecurityscanner::V1alpha::ListFindingTypeStatsRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:list_finding_type_stats, mock_method)

      # Mock auth layer
      mock_credentials = MockWebSecurityScannerCredentials_v1alpha.new("list_finding_type_stats")

      Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScanner::Stub.stub(:new, mock_stub) do
        Google::Cloud::Websecurityscanner::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Websecurityscanner::V1alpha.new

          # Call method
          response = client.list_finding_type_stats(formatted_parent)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.list_finding_type_stats(formatted_parent) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes list_finding_type_stats with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScannerClient.scan_run_path("[PROJECT]", "[SCAN_CONFIG]", "[SCAN_RUN]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Websecurityscanner::V1alpha::ListFindingTypeStatsRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha.new(:list_finding_type_stats, mock_method)

      # Mock auth layer
      mock_credentials = MockWebSecurityScannerCredentials_v1alpha.new("list_finding_type_stats")

      Google::Cloud::Websecurityscanner::V1alpha::WebSecurityScanner::Stub.stub(:new, mock_stub) do
        Google::Cloud::Websecurityscanner::V1alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Websecurityscanner::V1alpha.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha do
            client.list_finding_type_stats(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end