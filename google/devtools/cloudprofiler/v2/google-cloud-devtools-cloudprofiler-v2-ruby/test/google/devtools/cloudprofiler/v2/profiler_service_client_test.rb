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

require "google/devtools/cloudprofiler"
require "google/devtools/cloudprofiler/v2/profiler_service_client"
require "google/devtools/cloudprofiler/v2/profiler_services_pb"

class CustomTestError_v2 < StandardError; end

# Mock for the GRPC::ClientStub class.
class MockGrpcClientStub_v2

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

class MockProfilerServiceCredentials_v2 < Google::Devtools::Cloudprofiler::V2::Credentials
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

describe Google::Devtools::Cloudprofiler::V2::ProfilerServiceClient do

  describe 'create_profile' do
    custom_error = CustomTestError_v2.new "Custom test error for Google::Devtools::Cloudprofiler::V2::ProfilerServiceClient#create_profile."

    it 'invokes create_profile without error' do
      # Create expected grpc response
      name = "name3373707"
      profile_bytes = "85"
      expected_response = { name: name, profile_bytes: profile_bytes }
      expected_response = Google::Gax::to_proto(expected_response, Google::Devtools::Cloudprofiler::V2::Profile)

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v2.new(:create_profile, mock_method)

      # Mock auth layer
      mock_credentials = MockProfilerServiceCredentials_v2.new("create_profile")

      Google::Devtools::Cloudprofiler::V2::ProfilerService::Stub.stub(:new, mock_stub) do
        Google::Devtools::Cloudprofiler::V2::Credentials.stub(:default, mock_credentials) do
          client = Google::Devtools::Cloudprofiler.new(version: :v2)

          # Call method
          response = client.create_profile

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_profile do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_profile with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2.new(:create_profile, mock_method)

      # Mock auth layer
      mock_credentials = MockProfilerServiceCredentials_v2.new("create_profile")

      Google::Devtools::Cloudprofiler::V2::ProfilerService::Stub.stub(:new, mock_stub) do
        Google::Devtools::Cloudprofiler::V2::Credentials.stub(:default, mock_credentials) do
          client = Google::Devtools::Cloudprofiler.new(version: :v2)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2 do
            client.create_profile
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_offline_profile' do
    custom_error = CustomTestError_v2.new "Custom test error for Google::Devtools::Cloudprofiler::V2::ProfilerServiceClient#create_offline_profile."

    it 'invokes create_offline_profile without error' do
      # Create expected grpc response
      name = "name3373707"
      profile_bytes = "85"
      expected_response = { name: name, profile_bytes: profile_bytes }
      expected_response = Google::Gax::to_proto(expected_response, Google::Devtools::Cloudprofiler::V2::Profile)

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v2.new(:create_offline_profile, mock_method)

      # Mock auth layer
      mock_credentials = MockProfilerServiceCredentials_v2.new("create_offline_profile")

      Google::Devtools::Cloudprofiler::V2::ProfilerService::Stub.stub(:new, mock_stub) do
        Google::Devtools::Cloudprofiler::V2::Credentials.stub(:default, mock_credentials) do
          client = Google::Devtools::Cloudprofiler.new(version: :v2)

          # Call method
          response = client.create_offline_profile

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_offline_profile do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_offline_profile with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2.new(:create_offline_profile, mock_method)

      # Mock auth layer
      mock_credentials = MockProfilerServiceCredentials_v2.new("create_offline_profile")

      Google::Devtools::Cloudprofiler::V2::ProfilerService::Stub.stub(:new, mock_stub) do
        Google::Devtools::Cloudprofiler::V2::Credentials.stub(:default, mock_credentials) do
          client = Google::Devtools::Cloudprofiler.new(version: :v2)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2 do
            client.create_offline_profile
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_profile' do
    custom_error = CustomTestError_v2.new "Custom test error for Google::Devtools::Cloudprofiler::V2::ProfilerServiceClient#update_profile."

    it 'invokes update_profile without error' do
      # Create expected grpc response
      name = "name3373707"
      profile_bytes = "85"
      expected_response = { name: name, profile_bytes: profile_bytes }
      expected_response = Google::Gax::to_proto(expected_response, Google::Devtools::Cloudprofiler::V2::Profile)

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v2.new(:update_profile, mock_method)

      # Mock auth layer
      mock_credentials = MockProfilerServiceCredentials_v2.new("update_profile")

      Google::Devtools::Cloudprofiler::V2::ProfilerService::Stub.stub(:new, mock_stub) do
        Google::Devtools::Cloudprofiler::V2::Credentials.stub(:default, mock_credentials) do
          client = Google::Devtools::Cloudprofiler.new(version: :v2)

          # Call method
          response = client.update_profile

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.update_profile do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes update_profile with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2.new(:update_profile, mock_method)

      # Mock auth layer
      mock_credentials = MockProfilerServiceCredentials_v2.new("update_profile")

      Google::Devtools::Cloudprofiler::V2::ProfilerService::Stub.stub(:new, mock_stub) do
        Google::Devtools::Cloudprofiler::V2::Credentials.stub(:default, mock_credentials) do
          client = Google::Devtools::Cloudprofiler.new(version: :v2)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2 do
            client.update_profile
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end