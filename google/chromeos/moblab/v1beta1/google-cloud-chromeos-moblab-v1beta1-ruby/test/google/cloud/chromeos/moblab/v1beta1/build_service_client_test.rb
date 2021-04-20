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

require "google/cloud/chromeos/moblab"
require "google/cloud/chromeos/moblab/v1beta1/build_service_client"
require "google/chromeos/moblab/v1beta1/build_service_services_pb"
require "google/longrunning/operations_pb"

class CustomTestError_v1beta1 < StandardError; end

# Mock for the GRPC::ClientStub class.
class MockGrpcClientStub_v1beta1

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

class MockBuildServiceCredentials_v1beta1 < Google::Cloud::Chromeos::Moblab::V1beta1::Credentials
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

describe Google::Cloud::Chromeos::Moblab::V1beta1::BuildServiceClient do

  describe 'list_builds' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Chromeos::Moblab::V1beta1::BuildServiceClient#list_builds."

    it 'invokes list_builds without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Chromeos::Moblab::V1beta1::BuildServiceClient.model_path("[BUILD_TARGET]", "[MODEL]")

      # Create expected grpc response
      next_page_token = ""
      total_size = 705419236
      builds_element = {}
      builds = [builds_element]
      expected_response = {
        next_page_token: next_page_token,
        total_size: total_size,
        builds: builds
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Chromeos::Moblab::V1beta1::ListBuildsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Chromeos::Moblab::V1beta1::ListBuildsRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:list_builds, mock_method)

      # Mock auth layer
      mock_credentials = MockBuildServiceCredentials_v1beta1.new("list_builds")

      Google::Chromeos::Moblab::V1beta1::BuildService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Chromeos::Moblab::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Chromeos::Moblab.new(version: :v1beta1)

          # Call method
          response = client.list_builds(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.builds.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_builds with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Chromeos::Moblab::V1beta1::BuildServiceClient.model_path("[BUILD_TARGET]", "[MODEL]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Chromeos::Moblab::V1beta1::ListBuildsRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:list_builds, mock_method)

      # Mock auth layer
      mock_credentials = MockBuildServiceCredentials_v1beta1.new("list_builds")

      Google::Chromeos::Moblab::V1beta1::BuildService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Chromeos::Moblab::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Chromeos::Moblab.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.list_builds(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'check_build_stage_status' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Chromeos::Moblab::V1beta1::BuildServiceClient#check_build_stage_status."

    it 'invokes check_build_stage_status without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Chromeos::Moblab::V1beta1::BuildServiceClient.build_artifact_path("[BUILD_TARGET]", "[MODEL]", "[BUILD]", "[ARTIFACT]")

      # Create expected grpc response
      is_build_staged = true
      expected_response = { is_build_staged: is_build_staged }
      expected_response = Google::Gax::to_proto(expected_response, Google::Chromeos::Moblab::V1beta1::CheckBuildStageStatusResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Chromeos::Moblab::V1beta1::CheckBuildStageStatusRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:check_build_stage_status, mock_method)

      # Mock auth layer
      mock_credentials = MockBuildServiceCredentials_v1beta1.new("check_build_stage_status")

      Google::Chromeos::Moblab::V1beta1::BuildService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Chromeos::Moblab::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Chromeos::Moblab.new(version: :v1beta1)

          # Call method
          response = client.check_build_stage_status(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.check_build_stage_status(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes check_build_stage_status with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Chromeos::Moblab::V1beta1::BuildServiceClient.build_artifact_path("[BUILD_TARGET]", "[MODEL]", "[BUILD]", "[ARTIFACT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Chromeos::Moblab::V1beta1::CheckBuildStageStatusRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:check_build_stage_status, mock_method)

      # Mock auth layer
      mock_credentials = MockBuildServiceCredentials_v1beta1.new("check_build_stage_status")

      Google::Chromeos::Moblab::V1beta1::BuildService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Chromeos::Moblab::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Chromeos::Moblab.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.check_build_stage_status(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'stage_build' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Chromeos::Moblab::V1beta1::BuildServiceClient#stage_build."

    it 'invokes stage_build without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Chromeos::Moblab::V1beta1::BuildServiceClient.build_artifact_path("[BUILD_TARGET]", "[MODEL]", "[BUILD]", "[ARTIFACT]")

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Chromeos::Moblab::V1beta1::StageBuildResponse)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/stage_build_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Chromeos::Moblab::V1beta1::StageBuildRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:stage_build, mock_method)

      # Mock auth layer
      mock_credentials = MockBuildServiceCredentials_v1beta1.new("stage_build")

      Google::Chromeos::Moblab::V1beta1::BuildService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Chromeos::Moblab::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Chromeos::Moblab.new(version: :v1beta1)

          # Call method
          response = client.stage_build(formatted_name)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes stage_build and returns an operation error.' do
      # Create request parameters
      formatted_name = Google::Cloud::Chromeos::Moblab::V1beta1::BuildServiceClient.build_artifact_path("[BUILD_TARGET]", "[MODEL]", "[BUILD]", "[ARTIFACT]")

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Chromeos::Moblab::V1beta1::BuildServiceClient#stage_build.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/stage_build_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Chromeos::Moblab::V1beta1::StageBuildRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:stage_build, mock_method)

      # Mock auth layer
      mock_credentials = MockBuildServiceCredentials_v1beta1.new("stage_build")

      Google::Chromeos::Moblab::V1beta1::BuildService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Chromeos::Moblab::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Chromeos::Moblab.new(version: :v1beta1)

          # Call method
          response = client.stage_build(formatted_name)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes stage_build with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Chromeos::Moblab::V1beta1::BuildServiceClient.build_artifact_path("[BUILD_TARGET]", "[MODEL]", "[BUILD]", "[ARTIFACT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Chromeos::Moblab::V1beta1::StageBuildRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:stage_build, mock_method)

      # Mock auth layer
      mock_credentials = MockBuildServiceCredentials_v1beta1.new("stage_build")

      Google::Chromeos::Moblab::V1beta1::BuildService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Chromeos::Moblab::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Chromeos::Moblab.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.stage_build(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end