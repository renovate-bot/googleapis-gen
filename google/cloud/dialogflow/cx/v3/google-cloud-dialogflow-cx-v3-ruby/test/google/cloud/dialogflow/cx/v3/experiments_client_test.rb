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

require "google/cloud/dialogflow/cx"
require "google/cloud/dialogflow/cx/v3/experiments_client"
require "google/cloud/dialogflow/cx/v3/experiment_services_pb"

class CustomTestError_v3 < StandardError; end

# Mock for the GRPC::ClientStub class.
class MockGrpcClientStub_v3

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

class MockExperimentsCredentials_v3 < Google::Cloud::Dialogflow::Cx::V3::Credentials
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

describe Google::Cloud::Dialogflow::Cx::V3::ExperimentsClient do

  describe 'list_experiments' do
    custom_error = CustomTestError_v3.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3::ExperimentsClient#list_experiments."

    it 'invokes list_experiments without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Dialogflow::Cx::V3::ExperimentsClient.environment_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]")

      # Create expected grpc response
      next_page_token = ""
      experiments_element = {}
      experiments = [experiments_element]
      expected_response = { next_page_token: next_page_token, experiments: experiments }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::Cx::V3::ListExperimentsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::ListExperimentsRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v3.new(:list_experiments, mock_method)

      # Mock auth layer
      mock_credentials = MockExperimentsCredentials_v3.new("list_experiments")

      Google::Cloud::Dialogflow::Cx::V3::Experiments::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Experiments.new(version: :v3)

          # Call method
          response = client.list_experiments(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.experiments.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_experiments with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Dialogflow::Cx::V3::ExperimentsClient.environment_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::ListExperimentsRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3.new(:list_experiments, mock_method)

      # Mock auth layer
      mock_credentials = MockExperimentsCredentials_v3.new("list_experiments")

      Google::Cloud::Dialogflow::Cx::V3::Experiments::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Experiments.new(version: :v3)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3 do
            client.list_experiments(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_experiment' do
    custom_error = CustomTestError_v3.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3::ExperimentsClient#get_experiment."

    it 'invokes get_experiment without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3::ExperimentsClient.experiment_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      display_name = "displayName1615086568"
      description = "description-1724546052"
      expected_response = {
        name: name_2,
        display_name: display_name,
        description: description
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::Cx::V3::Experiment)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::GetExperimentRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v3.new(:get_experiment, mock_method)

      # Mock auth layer
      mock_credentials = MockExperimentsCredentials_v3.new("get_experiment")

      Google::Cloud::Dialogflow::Cx::V3::Experiments::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Experiments.new(version: :v3)

          # Call method
          response = client.get_experiment(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_experiment(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_experiment with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3::ExperimentsClient.experiment_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::GetExperimentRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3.new(:get_experiment, mock_method)

      # Mock auth layer
      mock_credentials = MockExperimentsCredentials_v3.new("get_experiment")

      Google::Cloud::Dialogflow::Cx::V3::Experiments::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Experiments.new(version: :v3)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3 do
            client.get_experiment(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_experiment' do
    custom_error = CustomTestError_v3.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3::ExperimentsClient#create_experiment."

    it 'invokes create_experiment without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Dialogflow::Cx::V3::ExperimentsClient.environment_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]")
      experiment = {}

      # Create expected grpc response
      name = "name3373707"
      display_name = "displayName1615086568"
      description = "description-1724546052"
      expected_response = {
        name: name,
        display_name: display_name,
        description: description
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::Cx::V3::Experiment)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::CreateExperimentRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(experiment, Google::Cloud::Dialogflow::Cx::V3::Experiment), request.experiment)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v3.new(:create_experiment, mock_method)

      # Mock auth layer
      mock_credentials = MockExperimentsCredentials_v3.new("create_experiment")

      Google::Cloud::Dialogflow::Cx::V3::Experiments::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Experiments.new(version: :v3)

          # Call method
          response = client.create_experiment(formatted_parent, experiment)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_experiment(formatted_parent, experiment) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_experiment with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Dialogflow::Cx::V3::ExperimentsClient.environment_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]")
      experiment = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::CreateExperimentRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(experiment, Google::Cloud::Dialogflow::Cx::V3::Experiment), request.experiment)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3.new(:create_experiment, mock_method)

      # Mock auth layer
      mock_credentials = MockExperimentsCredentials_v3.new("create_experiment")

      Google::Cloud::Dialogflow::Cx::V3::Experiments::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Experiments.new(version: :v3)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3 do
            client.create_experiment(formatted_parent, experiment)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_experiment' do
    custom_error = CustomTestError_v3.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3::ExperimentsClient#update_experiment."

    it 'invokes update_experiment without error' do
      # Create request parameters
      experiment = {}
      update_mask = {}

      # Create expected grpc response
      name = "name3373707"
      display_name = "displayName1615086568"
      description = "description-1724546052"
      expected_response = {
        name: name,
        display_name: display_name,
        description: description
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::Cx::V3::Experiment)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::UpdateExperimentRequest, request)
        assert_equal(Google::Gax::to_proto(experiment, Google::Cloud::Dialogflow::Cx::V3::Experiment), request.experiment)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v3.new(:update_experiment, mock_method)

      # Mock auth layer
      mock_credentials = MockExperimentsCredentials_v3.new("update_experiment")

      Google::Cloud::Dialogflow::Cx::V3::Experiments::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Experiments.new(version: :v3)

          # Call method
          response = client.update_experiment(experiment, update_mask)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.update_experiment(experiment, update_mask) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes update_experiment with error' do
      # Create request parameters
      experiment = {}
      update_mask = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::UpdateExperimentRequest, request)
        assert_equal(Google::Gax::to_proto(experiment, Google::Cloud::Dialogflow::Cx::V3::Experiment), request.experiment)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3.new(:update_experiment, mock_method)

      # Mock auth layer
      mock_credentials = MockExperimentsCredentials_v3.new("update_experiment")

      Google::Cloud::Dialogflow::Cx::V3::Experiments::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Experiments.new(version: :v3)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3 do
            client.update_experiment(experiment, update_mask)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_experiment' do
    custom_error = CustomTestError_v3.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3::ExperimentsClient#delete_experiment."

    it 'invokes delete_experiment without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3::ExperimentsClient.experiment_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::DeleteExperimentRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v3.new(:delete_experiment, mock_method)

      # Mock auth layer
      mock_credentials = MockExperimentsCredentials_v3.new("delete_experiment")

      Google::Cloud::Dialogflow::Cx::V3::Experiments::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Experiments.new(version: :v3)

          # Call method
          response = client.delete_experiment(formatted_name)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.delete_experiment(formatted_name) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes delete_experiment with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3::ExperimentsClient.experiment_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::DeleteExperimentRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3.new(:delete_experiment, mock_method)

      # Mock auth layer
      mock_credentials = MockExperimentsCredentials_v3.new("delete_experiment")

      Google::Cloud::Dialogflow::Cx::V3::Experiments::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Experiments.new(version: :v3)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3 do
            client.delete_experiment(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'start_experiment' do
    custom_error = CustomTestError_v3.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3::ExperimentsClient#start_experiment."

    it 'invokes start_experiment without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3::ExperimentsClient.experiment_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      display_name = "displayName1615086568"
      description = "description-1724546052"
      expected_response = {
        name: name_2,
        display_name: display_name,
        description: description
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::Cx::V3::Experiment)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::StartExperimentRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v3.new(:start_experiment, mock_method)

      # Mock auth layer
      mock_credentials = MockExperimentsCredentials_v3.new("start_experiment")

      Google::Cloud::Dialogflow::Cx::V3::Experiments::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Experiments.new(version: :v3)

          # Call method
          response = client.start_experiment(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.start_experiment(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes start_experiment with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3::ExperimentsClient.experiment_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::StartExperimentRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3.new(:start_experiment, mock_method)

      # Mock auth layer
      mock_credentials = MockExperimentsCredentials_v3.new("start_experiment")

      Google::Cloud::Dialogflow::Cx::V3::Experiments::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Experiments.new(version: :v3)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3 do
            client.start_experiment(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'stop_experiment' do
    custom_error = CustomTestError_v3.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3::ExperimentsClient#stop_experiment."

    it 'invokes stop_experiment without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3::ExperimentsClient.experiment_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      display_name = "displayName1615086568"
      description = "description-1724546052"
      expected_response = {
        name: name_2,
        display_name: display_name,
        description: description
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::Cx::V3::Experiment)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::StopExperimentRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v3.new(:stop_experiment, mock_method)

      # Mock auth layer
      mock_credentials = MockExperimentsCredentials_v3.new("stop_experiment")

      Google::Cloud::Dialogflow::Cx::V3::Experiments::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Experiments.new(version: :v3)

          # Call method
          response = client.stop_experiment(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.stop_experiment(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes stop_experiment with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3::ExperimentsClient.experiment_path("[PROJECT]", "[LOCATION]", "[AGENT]", "[ENVIRONMENT]", "[EXPERIMENT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3::StopExperimentRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3.new(:stop_experiment, mock_method)

      # Mock auth layer
      mock_credentials = MockExperimentsCredentials_v3.new("stop_experiment")

      Google::Cloud::Dialogflow::Cx::V3::Experiments::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Experiments.new(version: :v3)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3 do
            client.stop_experiment(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end