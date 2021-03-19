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

require "google/cloud/aiplatform/v1_beta1"
require "google/cloud/aiplatform/v1_beta1/vizier_service_client"
require "google/cloud/aiplatform/v1beta1/vizier_service_services_pb"
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

class MockVizierServiceCredentials_v1beta1 < Google::Cloud::Aiplatform::V1Beta1::Credentials
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

describe Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient do

  describe 'create_study' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient#create_study."

    it 'invokes create_study without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient.location_path("[PROJECT]", "[LOCATION]")
      study = {}

      # Create expected grpc response
      name = "name3373707"
      display_name = "displayName1615086568"
      inactive_reason = "inactiveReason-1468304232"
      expected_response = {
        name: name,
        display_name: display_name,
        inactive_reason: inactive_reason
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Aiplatform::V1beta1::Study)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::CreateStudyRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(study, Google::Cloud::Aiplatform::V1beta1::Study), request.study)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:create_study, mock_method)

      # Mock auth layer
      mock_credentials = MockVizierServiceCredentials_v1beta1.new("create_study")

      Google::Cloud::Aiplatform::V1beta1::VizierService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Vizier.new(version: :v1beta1)

          # Call method
          response = client.create_study(formatted_parent, study)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_study(formatted_parent, study) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_study with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient.location_path("[PROJECT]", "[LOCATION]")
      study = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::CreateStudyRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(study, Google::Cloud::Aiplatform::V1beta1::Study), request.study)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:create_study, mock_method)

      # Mock auth layer
      mock_credentials = MockVizierServiceCredentials_v1beta1.new("create_study")

      Google::Cloud::Aiplatform::V1beta1::VizierService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Vizier.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.create_study(formatted_parent, study)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_study' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient#get_study."

    it 'invokes get_study without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient.study_path("[PROJECT]", "[LOCATION]", "[STUDY]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      display_name = "displayName1615086568"
      inactive_reason = "inactiveReason-1468304232"
      expected_response = {
        name: name_2,
        display_name: display_name,
        inactive_reason: inactive_reason
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Aiplatform::V1beta1::Study)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::GetStudyRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:get_study, mock_method)

      # Mock auth layer
      mock_credentials = MockVizierServiceCredentials_v1beta1.new("get_study")

      Google::Cloud::Aiplatform::V1beta1::VizierService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Vizier.new(version: :v1beta1)

          # Call method
          response = client.get_study(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_study(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_study with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient.study_path("[PROJECT]", "[LOCATION]", "[STUDY]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::GetStudyRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:get_study, mock_method)

      # Mock auth layer
      mock_credentials = MockVizierServiceCredentials_v1beta1.new("get_study")

      Google::Cloud::Aiplatform::V1beta1::VizierService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Vizier.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.get_study(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_studies' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient#list_studies."

    it 'invokes list_studies without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient.location_path("[PROJECT]", "[LOCATION]")

      # Create expected grpc response
      next_page_token = ""
      studies_element = {}
      studies = [studies_element]
      expected_response = { next_page_token: next_page_token, studies: studies }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Aiplatform::V1beta1::ListStudiesResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::ListStudiesRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:list_studies, mock_method)

      # Mock auth layer
      mock_credentials = MockVizierServiceCredentials_v1beta1.new("list_studies")

      Google::Cloud::Aiplatform::V1beta1::VizierService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Vizier.new(version: :v1beta1)

          # Call method
          response = client.list_studies(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.studies.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_studies with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient.location_path("[PROJECT]", "[LOCATION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::ListStudiesRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:list_studies, mock_method)

      # Mock auth layer
      mock_credentials = MockVizierServiceCredentials_v1beta1.new("list_studies")

      Google::Cloud::Aiplatform::V1beta1::VizierService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Vizier.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.list_studies(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_study' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient#delete_study."

    it 'invokes delete_study without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient.study_path("[PROJECT]", "[LOCATION]", "[STUDY]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::DeleteStudyRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:delete_study, mock_method)

      # Mock auth layer
      mock_credentials = MockVizierServiceCredentials_v1beta1.new("delete_study")

      Google::Cloud::Aiplatform::V1beta1::VizierService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Vizier.new(version: :v1beta1)

          # Call method
          response = client.delete_study(formatted_name)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.delete_study(formatted_name) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes delete_study with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient.study_path("[PROJECT]", "[LOCATION]", "[STUDY]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::DeleteStudyRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:delete_study, mock_method)

      # Mock auth layer
      mock_credentials = MockVizierServiceCredentials_v1beta1.new("delete_study")

      Google::Cloud::Aiplatform::V1beta1::VizierService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Vizier.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.delete_study(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'lookup_study' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient#lookup_study."

    it 'invokes lookup_study without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient.location_path("[PROJECT]", "[LOCATION]")
      display_name = ''

      # Create expected grpc response
      name = "name3373707"
      display_name_2 = "displayName21615000987"
      inactive_reason = "inactiveReason-1468304232"
      expected_response = {
        name: name,
        display_name: display_name_2,
        inactive_reason: inactive_reason
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Aiplatform::V1beta1::Study)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::LookupStudyRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(display_name, request.display_name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:lookup_study, mock_method)

      # Mock auth layer
      mock_credentials = MockVizierServiceCredentials_v1beta1.new("lookup_study")

      Google::Cloud::Aiplatform::V1beta1::VizierService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Vizier.new(version: :v1beta1)

          # Call method
          response = client.lookup_study(formatted_parent, display_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.lookup_study(formatted_parent, display_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes lookup_study with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient.location_path("[PROJECT]", "[LOCATION]")
      display_name = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::LookupStudyRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(display_name, request.display_name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:lookup_study, mock_method)

      # Mock auth layer
      mock_credentials = MockVizierServiceCredentials_v1beta1.new("lookup_study")

      Google::Cloud::Aiplatform::V1beta1::VizierService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Vizier.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.lookup_study(formatted_parent, display_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'suggest_trials' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient#suggest_trials."

    it 'invokes suggest_trials without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient.study_path("[PROJECT]", "[LOCATION]", "[STUDY]")
      suggestion_count = 0
      client_id = ''

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Aiplatform::V1beta1::SuggestTrialsResponse)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/suggest_trials_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::SuggestTrialsRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(suggestion_count, request.suggestion_count)
        assert_equal(client_id, request.client_id)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:suggest_trials, mock_method)

      # Mock auth layer
      mock_credentials = MockVizierServiceCredentials_v1beta1.new("suggest_trials")

      Google::Cloud::Aiplatform::V1beta1::VizierService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Vizier.new(version: :v1beta1)

          # Call method
          response = client.suggest_trials(
            formatted_parent,
            suggestion_count,
            client_id
          )

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes suggest_trials and returns an operation error.' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient.study_path("[PROJECT]", "[LOCATION]", "[STUDY]")
      suggestion_count = 0
      client_id = ''

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient#suggest_trials.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/suggest_trials_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::SuggestTrialsRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(suggestion_count, request.suggestion_count)
        assert_equal(client_id, request.client_id)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:suggest_trials, mock_method)

      # Mock auth layer
      mock_credentials = MockVizierServiceCredentials_v1beta1.new("suggest_trials")

      Google::Cloud::Aiplatform::V1beta1::VizierService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Vizier.new(version: :v1beta1)

          # Call method
          response = client.suggest_trials(
            formatted_parent,
            suggestion_count,
            client_id
          )

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes suggest_trials with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient.study_path("[PROJECT]", "[LOCATION]", "[STUDY]")
      suggestion_count = 0
      client_id = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::SuggestTrialsRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(suggestion_count, request.suggestion_count)
        assert_equal(client_id, request.client_id)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:suggest_trials, mock_method)

      # Mock auth layer
      mock_credentials = MockVizierServiceCredentials_v1beta1.new("suggest_trials")

      Google::Cloud::Aiplatform::V1beta1::VizierService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Vizier.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.suggest_trials(
              formatted_parent,
              suggestion_count,
              client_id
            )
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_trial' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient#create_trial."

    it 'invokes create_trial without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient.study_path("[PROJECT]", "[LOCATION]", "[STUDY]")
      trial = {}

      # Create expected grpc response
      name = "name3373707"
      id = "id3355"
      custom_job = "customJob-1581369873"
      expected_response = {
        name: name,
        id: id,
        custom_job: custom_job
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Aiplatform::V1beta1::Trial)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::CreateTrialRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(trial, Google::Cloud::Aiplatform::V1beta1::Trial), request.trial)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:create_trial, mock_method)

      # Mock auth layer
      mock_credentials = MockVizierServiceCredentials_v1beta1.new("create_trial")

      Google::Cloud::Aiplatform::V1beta1::VizierService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Vizier.new(version: :v1beta1)

          # Call method
          response = client.create_trial(formatted_parent, trial)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_trial(formatted_parent, trial) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_trial with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient.study_path("[PROJECT]", "[LOCATION]", "[STUDY]")
      trial = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::CreateTrialRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(trial, Google::Cloud::Aiplatform::V1beta1::Trial), request.trial)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:create_trial, mock_method)

      # Mock auth layer
      mock_credentials = MockVizierServiceCredentials_v1beta1.new("create_trial")

      Google::Cloud::Aiplatform::V1beta1::VizierService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Vizier.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.create_trial(formatted_parent, trial)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_trial' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient#get_trial."

    it 'invokes get_trial without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient.trial_path("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      id = "id3355"
      custom_job = "customJob-1581369873"
      expected_response = {
        name: name_2,
        id: id,
        custom_job: custom_job
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Aiplatform::V1beta1::Trial)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::GetTrialRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:get_trial, mock_method)

      # Mock auth layer
      mock_credentials = MockVizierServiceCredentials_v1beta1.new("get_trial")

      Google::Cloud::Aiplatform::V1beta1::VizierService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Vizier.new(version: :v1beta1)

          # Call method
          response = client.get_trial(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_trial(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_trial with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient.trial_path("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::GetTrialRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:get_trial, mock_method)

      # Mock auth layer
      mock_credentials = MockVizierServiceCredentials_v1beta1.new("get_trial")

      Google::Cloud::Aiplatform::V1beta1::VizierService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Vizier.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.get_trial(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_trials' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient#list_trials."

    it 'invokes list_trials without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient.study_path("[PROJECT]", "[LOCATION]", "[STUDY]")

      # Create expected grpc response
      next_page_token = ""
      trials_element = {}
      trials = [trials_element]
      expected_response = { next_page_token: next_page_token, trials: trials }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Aiplatform::V1beta1::ListTrialsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::ListTrialsRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:list_trials, mock_method)

      # Mock auth layer
      mock_credentials = MockVizierServiceCredentials_v1beta1.new("list_trials")

      Google::Cloud::Aiplatform::V1beta1::VizierService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Vizier.new(version: :v1beta1)

          # Call method
          response = client.list_trials(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.trials.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_trials with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient.study_path("[PROJECT]", "[LOCATION]", "[STUDY]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::ListTrialsRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:list_trials, mock_method)

      # Mock auth layer
      mock_credentials = MockVizierServiceCredentials_v1beta1.new("list_trials")

      Google::Cloud::Aiplatform::V1beta1::VizierService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Vizier.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.list_trials(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'add_trial_measurement' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient#add_trial_measurement."

    it 'invokes add_trial_measurement without error' do
      # Create request parameters
      formatted_trial_name = Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient.trial_path("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]")
      measurement = {}

      # Create expected grpc response
      name = "name3373707"
      id = "id3355"
      custom_job = "customJob-1581369873"
      expected_response = {
        name: name,
        id: id,
        custom_job: custom_job
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Aiplatform::V1beta1::Trial)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::AddTrialMeasurementRequest, request)
        assert_equal(formatted_trial_name, request.trial_name)
        assert_equal(Google::Gax::to_proto(measurement, Google::Cloud::Aiplatform::V1beta1::Measurement), request.measurement)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:add_trial_measurement, mock_method)

      # Mock auth layer
      mock_credentials = MockVizierServiceCredentials_v1beta1.new("add_trial_measurement")

      Google::Cloud::Aiplatform::V1beta1::VizierService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Vizier.new(version: :v1beta1)

          # Call method
          response = client.add_trial_measurement(formatted_trial_name, measurement)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.add_trial_measurement(formatted_trial_name, measurement) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes add_trial_measurement with error' do
      # Create request parameters
      formatted_trial_name = Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient.trial_path("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]")
      measurement = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::AddTrialMeasurementRequest, request)
        assert_equal(formatted_trial_name, request.trial_name)
        assert_equal(Google::Gax::to_proto(measurement, Google::Cloud::Aiplatform::V1beta1::Measurement), request.measurement)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:add_trial_measurement, mock_method)

      # Mock auth layer
      mock_credentials = MockVizierServiceCredentials_v1beta1.new("add_trial_measurement")

      Google::Cloud::Aiplatform::V1beta1::VizierService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Vizier.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.add_trial_measurement(formatted_trial_name, measurement)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'complete_trial' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient#complete_trial."

    it 'invokes complete_trial without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient.trial_path("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      id = "id3355"
      custom_job = "customJob-1581369873"
      expected_response = {
        name: name_2,
        id: id,
        custom_job: custom_job
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Aiplatform::V1beta1::Trial)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::CompleteTrialRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:complete_trial, mock_method)

      # Mock auth layer
      mock_credentials = MockVizierServiceCredentials_v1beta1.new("complete_trial")

      Google::Cloud::Aiplatform::V1beta1::VizierService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Vizier.new(version: :v1beta1)

          # Call method
          response = client.complete_trial(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.complete_trial(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes complete_trial with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient.trial_path("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::CompleteTrialRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:complete_trial, mock_method)

      # Mock auth layer
      mock_credentials = MockVizierServiceCredentials_v1beta1.new("complete_trial")

      Google::Cloud::Aiplatform::V1beta1::VizierService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Vizier.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.complete_trial(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_trial' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient#delete_trial."

    it 'invokes delete_trial without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient.trial_path("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::DeleteTrialRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:delete_trial, mock_method)

      # Mock auth layer
      mock_credentials = MockVizierServiceCredentials_v1beta1.new("delete_trial")

      Google::Cloud::Aiplatform::V1beta1::VizierService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Vizier.new(version: :v1beta1)

          # Call method
          response = client.delete_trial(formatted_name)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.delete_trial(formatted_name) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes delete_trial with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient.trial_path("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::DeleteTrialRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:delete_trial, mock_method)

      # Mock auth layer
      mock_credentials = MockVizierServiceCredentials_v1beta1.new("delete_trial")

      Google::Cloud::Aiplatform::V1beta1::VizierService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Vizier.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.delete_trial(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'check_trial_early_stopping_state' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient#check_trial_early_stopping_state."

    it 'invokes check_trial_early_stopping_state without error' do
      # Create request parameters
      formatted_trial_name = Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient.trial_path("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]")

      # Create expected grpc response
      should_stop = true
      expected_response = { should_stop: should_stop }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Aiplatform::V1beta1::CheckTrialEarlyStoppingStateResponse)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/check_trial_early_stopping_state_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::CheckTrialEarlyStoppingStateRequest, request)
        assert_equal(formatted_trial_name, request.trial_name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:check_trial_early_stopping_state, mock_method)

      # Mock auth layer
      mock_credentials = MockVizierServiceCredentials_v1beta1.new("check_trial_early_stopping_state")

      Google::Cloud::Aiplatform::V1beta1::VizierService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Vizier.new(version: :v1beta1)

          # Call method
          response = client.check_trial_early_stopping_state(formatted_trial_name)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes check_trial_early_stopping_state and returns an operation error.' do
      # Create request parameters
      formatted_trial_name = Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient.trial_path("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]")

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient#check_trial_early_stopping_state.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/check_trial_early_stopping_state_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::CheckTrialEarlyStoppingStateRequest, request)
        assert_equal(formatted_trial_name, request.trial_name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:check_trial_early_stopping_state, mock_method)

      # Mock auth layer
      mock_credentials = MockVizierServiceCredentials_v1beta1.new("check_trial_early_stopping_state")

      Google::Cloud::Aiplatform::V1beta1::VizierService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Vizier.new(version: :v1beta1)

          # Call method
          response = client.check_trial_early_stopping_state(formatted_trial_name)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes check_trial_early_stopping_state with error' do
      # Create request parameters
      formatted_trial_name = Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient.trial_path("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::CheckTrialEarlyStoppingStateRequest, request)
        assert_equal(formatted_trial_name, request.trial_name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:check_trial_early_stopping_state, mock_method)

      # Mock auth layer
      mock_credentials = MockVizierServiceCredentials_v1beta1.new("check_trial_early_stopping_state")

      Google::Cloud::Aiplatform::V1beta1::VizierService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Vizier.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.check_trial_early_stopping_state(formatted_trial_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'stop_trial' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient#stop_trial."

    it 'invokes stop_trial without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient.trial_path("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      id = "id3355"
      custom_job = "customJob-1581369873"
      expected_response = {
        name: name_2,
        id: id,
        custom_job: custom_job
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Aiplatform::V1beta1::Trial)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::StopTrialRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:stop_trial, mock_method)

      # Mock auth layer
      mock_credentials = MockVizierServiceCredentials_v1beta1.new("stop_trial")

      Google::Cloud::Aiplatform::V1beta1::VizierService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Vizier.new(version: :v1beta1)

          # Call method
          response = client.stop_trial(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.stop_trial(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes stop_trial with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient.trial_path("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::StopTrialRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:stop_trial, mock_method)

      # Mock auth layer
      mock_credentials = MockVizierServiceCredentials_v1beta1.new("stop_trial")

      Google::Cloud::Aiplatform::V1beta1::VizierService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Vizier.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.stop_trial(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_optimal_trials' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient#list_optimal_trials."

    it 'invokes list_optimal_trials without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient.study_path("[PROJECT]", "[LOCATION]", "[STUDY]")

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Aiplatform::V1beta1::ListOptimalTrialsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::ListOptimalTrialsRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:list_optimal_trials, mock_method)

      # Mock auth layer
      mock_credentials = MockVizierServiceCredentials_v1beta1.new("list_optimal_trials")

      Google::Cloud::Aiplatform::V1beta1::VizierService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Vizier.new(version: :v1beta1)

          # Call method
          response = client.list_optimal_trials(formatted_parent)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.list_optimal_trials(formatted_parent) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes list_optimal_trials with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1Beta1::VizierServiceClient.study_path("[PROJECT]", "[LOCATION]", "[STUDY]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1beta1::ListOptimalTrialsRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:list_optimal_trials, mock_method)

      # Mock auth layer
      mock_credentials = MockVizierServiceCredentials_v1beta1.new("list_optimal_trials")

      Google::Cloud::Aiplatform::V1beta1::VizierService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1Beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::V1Beta1::Vizier.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.list_optimal_trials(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end