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

require "google/cloud/aiplatform"
require "google/cloud/aiplatform/v1/job_service_client"
require "google/cloud/aiplatform/v1/job_service_services_pb"
require "google/longrunning/operations_pb"

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

class MockJobServiceCredentials_v1 < Google::Cloud::Aiplatform::V1::Credentials
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

describe Google::Cloud::Aiplatform::V1::JobServiceClient do

  describe 'create_custom_job' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Aiplatform::V1::JobServiceClient#create_custom_job."

    it 'invokes create_custom_job without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1::JobServiceClient.location_path("[PROJECT]", "[LOCATION]")
      custom_job = {}

      # Create expected grpc response
      name = "name3373707"
      display_name = "displayName1615086568"
      expected_response = { name: name, display_name: display_name }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Aiplatform::V1::CustomJob)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::CreateCustomJobRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(custom_job, Google::Cloud::Aiplatform::V1::CustomJob), request.custom_job)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:create_custom_job, mock_method)

      # Mock auth layer
      mock_credentials = MockJobServiceCredentials_v1.new("create_custom_job")

      Google::Cloud::Aiplatform::V1::JobService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Job.new(version: :v1)

          # Call method
          response = client.create_custom_job(formatted_parent, custom_job)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_custom_job(formatted_parent, custom_job) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_custom_job with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1::JobServiceClient.location_path("[PROJECT]", "[LOCATION]")
      custom_job = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::CreateCustomJobRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(custom_job, Google::Cloud::Aiplatform::V1::CustomJob), request.custom_job)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:create_custom_job, mock_method)

      # Mock auth layer
      mock_credentials = MockJobServiceCredentials_v1.new("create_custom_job")

      Google::Cloud::Aiplatform::V1::JobService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Job.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.create_custom_job(formatted_parent, custom_job)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_custom_job' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Aiplatform::V1::JobServiceClient#get_custom_job."

    it 'invokes get_custom_job without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1::JobServiceClient.custom_job_path("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      display_name = "displayName1615086568"
      expected_response = { name: name_2, display_name: display_name }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Aiplatform::V1::CustomJob)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::GetCustomJobRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_custom_job, mock_method)

      # Mock auth layer
      mock_credentials = MockJobServiceCredentials_v1.new("get_custom_job")

      Google::Cloud::Aiplatform::V1::JobService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Job.new(version: :v1)

          # Call method
          response = client.get_custom_job(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_custom_job(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_custom_job with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1::JobServiceClient.custom_job_path("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::GetCustomJobRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_custom_job, mock_method)

      # Mock auth layer
      mock_credentials = MockJobServiceCredentials_v1.new("get_custom_job")

      Google::Cloud::Aiplatform::V1::JobService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Job.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.get_custom_job(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_custom_jobs' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Aiplatform::V1::JobServiceClient#list_custom_jobs."

    it 'invokes list_custom_jobs without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1::JobServiceClient.location_path("[PROJECT]", "[LOCATION]")

      # Create expected grpc response
      next_page_token = ""
      custom_jobs_element = {}
      custom_jobs = [custom_jobs_element]
      expected_response = { next_page_token: next_page_token, custom_jobs: custom_jobs }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Aiplatform::V1::ListCustomJobsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::ListCustomJobsRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_custom_jobs, mock_method)

      # Mock auth layer
      mock_credentials = MockJobServiceCredentials_v1.new("list_custom_jobs")

      Google::Cloud::Aiplatform::V1::JobService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Job.new(version: :v1)

          # Call method
          response = client.list_custom_jobs(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.custom_jobs.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_custom_jobs with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1::JobServiceClient.location_path("[PROJECT]", "[LOCATION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::ListCustomJobsRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_custom_jobs, mock_method)

      # Mock auth layer
      mock_credentials = MockJobServiceCredentials_v1.new("list_custom_jobs")

      Google::Cloud::Aiplatform::V1::JobService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Job.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.list_custom_jobs(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_custom_job' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Aiplatform::V1::JobServiceClient#delete_custom_job."

    it 'invokes delete_custom_job without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1::JobServiceClient.custom_job_path("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]")

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Protobuf::Empty)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/delete_custom_job_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::DeleteCustomJobRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_custom_job, mock_method)

      # Mock auth layer
      mock_credentials = MockJobServiceCredentials_v1.new("delete_custom_job")

      Google::Cloud::Aiplatform::V1::JobService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Job.new(version: :v1)

          # Call method
          response = client.delete_custom_job(formatted_name)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes delete_custom_job and returns an operation error.' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1::JobServiceClient.custom_job_path("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]")

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Aiplatform::V1::JobServiceClient#delete_custom_job.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/delete_custom_job_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::DeleteCustomJobRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_custom_job, mock_method)

      # Mock auth layer
      mock_credentials = MockJobServiceCredentials_v1.new("delete_custom_job")

      Google::Cloud::Aiplatform::V1::JobService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Job.new(version: :v1)

          # Call method
          response = client.delete_custom_job(formatted_name)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes delete_custom_job with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1::JobServiceClient.custom_job_path("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::DeleteCustomJobRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_custom_job, mock_method)

      # Mock auth layer
      mock_credentials = MockJobServiceCredentials_v1.new("delete_custom_job")

      Google::Cloud::Aiplatform::V1::JobService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Job.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.delete_custom_job(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'cancel_custom_job' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Aiplatform::V1::JobServiceClient#cancel_custom_job."

    it 'invokes cancel_custom_job without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1::JobServiceClient.custom_job_path("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::CancelCustomJobRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v1.new(:cancel_custom_job, mock_method)

      # Mock auth layer
      mock_credentials = MockJobServiceCredentials_v1.new("cancel_custom_job")

      Google::Cloud::Aiplatform::V1::JobService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Job.new(version: :v1)

          # Call method
          response = client.cancel_custom_job(formatted_name)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.cancel_custom_job(formatted_name) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes cancel_custom_job with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1::JobServiceClient.custom_job_path("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::CancelCustomJobRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:cancel_custom_job, mock_method)

      # Mock auth layer
      mock_credentials = MockJobServiceCredentials_v1.new("cancel_custom_job")

      Google::Cloud::Aiplatform::V1::JobService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Job.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.cancel_custom_job(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_data_labeling_job' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Aiplatform::V1::JobServiceClient#create_data_labeling_job."

    it 'invokes create_data_labeling_job without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1::JobServiceClient.location_path("[PROJECT]", "[LOCATION]")
      data_labeling_job = {}

      # Create expected grpc response
      name = "name3373707"
      display_name = "displayName1615086568"
      labeler_count = 1457777167
      instruction_uri = "instructionUri1537272379"
      inputs_schema_uri = "inputsSchemaUri990382564"
      labeling_progress = 685978914
      expected_response = {
        name: name,
        display_name: display_name,
        labeler_count: labeler_count,
        instruction_uri: instruction_uri,
        inputs_schema_uri: inputs_schema_uri,
        labeling_progress: labeling_progress
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Aiplatform::V1::DataLabelingJob)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::CreateDataLabelingJobRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(data_labeling_job, Google::Cloud::Aiplatform::V1::DataLabelingJob), request.data_labeling_job)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:create_data_labeling_job, mock_method)

      # Mock auth layer
      mock_credentials = MockJobServiceCredentials_v1.new("create_data_labeling_job")

      Google::Cloud::Aiplatform::V1::JobService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Job.new(version: :v1)

          # Call method
          response = client.create_data_labeling_job(formatted_parent, data_labeling_job)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_data_labeling_job(formatted_parent, data_labeling_job) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_data_labeling_job with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1::JobServiceClient.location_path("[PROJECT]", "[LOCATION]")
      data_labeling_job = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::CreateDataLabelingJobRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(data_labeling_job, Google::Cloud::Aiplatform::V1::DataLabelingJob), request.data_labeling_job)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:create_data_labeling_job, mock_method)

      # Mock auth layer
      mock_credentials = MockJobServiceCredentials_v1.new("create_data_labeling_job")

      Google::Cloud::Aiplatform::V1::JobService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Job.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.create_data_labeling_job(formatted_parent, data_labeling_job)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_data_labeling_job' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Aiplatform::V1::JobServiceClient#get_data_labeling_job."

    it 'invokes get_data_labeling_job without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1::JobServiceClient.data_labeling_job_path("[PROJECT]", "[LOCATION]", "[DATA_LABELING_JOB]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      display_name = "displayName1615086568"
      labeler_count = 1457777167
      instruction_uri = "instructionUri1537272379"
      inputs_schema_uri = "inputsSchemaUri990382564"
      labeling_progress = 685978914
      expected_response = {
        name: name_2,
        display_name: display_name,
        labeler_count: labeler_count,
        instruction_uri: instruction_uri,
        inputs_schema_uri: inputs_schema_uri,
        labeling_progress: labeling_progress
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Aiplatform::V1::DataLabelingJob)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::GetDataLabelingJobRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_data_labeling_job, mock_method)

      # Mock auth layer
      mock_credentials = MockJobServiceCredentials_v1.new("get_data_labeling_job")

      Google::Cloud::Aiplatform::V1::JobService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Job.new(version: :v1)

          # Call method
          response = client.get_data_labeling_job(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_data_labeling_job(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_data_labeling_job with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1::JobServiceClient.data_labeling_job_path("[PROJECT]", "[LOCATION]", "[DATA_LABELING_JOB]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::GetDataLabelingJobRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_data_labeling_job, mock_method)

      # Mock auth layer
      mock_credentials = MockJobServiceCredentials_v1.new("get_data_labeling_job")

      Google::Cloud::Aiplatform::V1::JobService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Job.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.get_data_labeling_job(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_data_labeling_jobs' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Aiplatform::V1::JobServiceClient#list_data_labeling_jobs."

    it 'invokes list_data_labeling_jobs without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1::JobServiceClient.location_path("[PROJECT]", "[LOCATION]")

      # Create expected grpc response
      next_page_token = ""
      data_labeling_jobs_element = {}
      data_labeling_jobs = [data_labeling_jobs_element]
      expected_response = { next_page_token: next_page_token, data_labeling_jobs: data_labeling_jobs }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Aiplatform::V1::ListDataLabelingJobsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::ListDataLabelingJobsRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_data_labeling_jobs, mock_method)

      # Mock auth layer
      mock_credentials = MockJobServiceCredentials_v1.new("list_data_labeling_jobs")

      Google::Cloud::Aiplatform::V1::JobService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Job.new(version: :v1)

          # Call method
          response = client.list_data_labeling_jobs(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.data_labeling_jobs.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_data_labeling_jobs with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1::JobServiceClient.location_path("[PROJECT]", "[LOCATION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::ListDataLabelingJobsRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_data_labeling_jobs, mock_method)

      # Mock auth layer
      mock_credentials = MockJobServiceCredentials_v1.new("list_data_labeling_jobs")

      Google::Cloud::Aiplatform::V1::JobService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Job.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.list_data_labeling_jobs(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_data_labeling_job' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Aiplatform::V1::JobServiceClient#delete_data_labeling_job."

    it 'invokes delete_data_labeling_job without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1::JobServiceClient.data_labeling_job_path("[PROJECT]", "[LOCATION]", "[DATA_LABELING_JOB]")

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Protobuf::Empty)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/delete_data_labeling_job_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::DeleteDataLabelingJobRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_data_labeling_job, mock_method)

      # Mock auth layer
      mock_credentials = MockJobServiceCredentials_v1.new("delete_data_labeling_job")

      Google::Cloud::Aiplatform::V1::JobService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Job.new(version: :v1)

          # Call method
          response = client.delete_data_labeling_job(formatted_name)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes delete_data_labeling_job and returns an operation error.' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1::JobServiceClient.data_labeling_job_path("[PROJECT]", "[LOCATION]", "[DATA_LABELING_JOB]")

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Aiplatform::V1::JobServiceClient#delete_data_labeling_job.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/delete_data_labeling_job_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::DeleteDataLabelingJobRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_data_labeling_job, mock_method)

      # Mock auth layer
      mock_credentials = MockJobServiceCredentials_v1.new("delete_data_labeling_job")

      Google::Cloud::Aiplatform::V1::JobService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Job.new(version: :v1)

          # Call method
          response = client.delete_data_labeling_job(formatted_name)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes delete_data_labeling_job with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1::JobServiceClient.data_labeling_job_path("[PROJECT]", "[LOCATION]", "[DATA_LABELING_JOB]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::DeleteDataLabelingJobRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_data_labeling_job, mock_method)

      # Mock auth layer
      mock_credentials = MockJobServiceCredentials_v1.new("delete_data_labeling_job")

      Google::Cloud::Aiplatform::V1::JobService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Job.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.delete_data_labeling_job(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'cancel_data_labeling_job' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Aiplatform::V1::JobServiceClient#cancel_data_labeling_job."

    it 'invokes cancel_data_labeling_job without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1::JobServiceClient.data_labeling_job_path("[PROJECT]", "[LOCATION]", "[DATA_LABELING_JOB]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::CancelDataLabelingJobRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v1.new(:cancel_data_labeling_job, mock_method)

      # Mock auth layer
      mock_credentials = MockJobServiceCredentials_v1.new("cancel_data_labeling_job")

      Google::Cloud::Aiplatform::V1::JobService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Job.new(version: :v1)

          # Call method
          response = client.cancel_data_labeling_job(formatted_name)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.cancel_data_labeling_job(formatted_name) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes cancel_data_labeling_job with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1::JobServiceClient.data_labeling_job_path("[PROJECT]", "[LOCATION]", "[DATA_LABELING_JOB]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::CancelDataLabelingJobRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:cancel_data_labeling_job, mock_method)

      # Mock auth layer
      mock_credentials = MockJobServiceCredentials_v1.new("cancel_data_labeling_job")

      Google::Cloud::Aiplatform::V1::JobService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Job.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.cancel_data_labeling_job(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_hyperparameter_tuning_job' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Aiplatform::V1::JobServiceClient#create_hyperparameter_tuning_job."

    it 'invokes create_hyperparameter_tuning_job without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1::JobServiceClient.location_path("[PROJECT]", "[LOCATION]")
      hyperparameter_tuning_job = {}

      # Create expected grpc response
      name = "name3373707"
      display_name = "displayName1615086568"
      max_trial_count = 445994933
      parallel_trial_count = 1813795950
      max_failed_trial_count = 887662497
      expected_response = {
        name: name,
        display_name: display_name,
        max_trial_count: max_trial_count,
        parallel_trial_count: parallel_trial_count,
        max_failed_trial_count: max_failed_trial_count
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Aiplatform::V1::HyperparameterTuningJob)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::CreateHyperparameterTuningJobRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(hyperparameter_tuning_job, Google::Cloud::Aiplatform::V1::HyperparameterTuningJob), request.hyperparameter_tuning_job)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:create_hyperparameter_tuning_job, mock_method)

      # Mock auth layer
      mock_credentials = MockJobServiceCredentials_v1.new("create_hyperparameter_tuning_job")

      Google::Cloud::Aiplatform::V1::JobService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Job.new(version: :v1)

          # Call method
          response = client.create_hyperparameter_tuning_job(formatted_parent, hyperparameter_tuning_job)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_hyperparameter_tuning_job(formatted_parent, hyperparameter_tuning_job) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_hyperparameter_tuning_job with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1::JobServiceClient.location_path("[PROJECT]", "[LOCATION]")
      hyperparameter_tuning_job = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::CreateHyperparameterTuningJobRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(hyperparameter_tuning_job, Google::Cloud::Aiplatform::V1::HyperparameterTuningJob), request.hyperparameter_tuning_job)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:create_hyperparameter_tuning_job, mock_method)

      # Mock auth layer
      mock_credentials = MockJobServiceCredentials_v1.new("create_hyperparameter_tuning_job")

      Google::Cloud::Aiplatform::V1::JobService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Job.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.create_hyperparameter_tuning_job(formatted_parent, hyperparameter_tuning_job)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_hyperparameter_tuning_job' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Aiplatform::V1::JobServiceClient#get_hyperparameter_tuning_job."

    it 'invokes get_hyperparameter_tuning_job without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1::JobServiceClient.hyperparameter_tuning_job_path("[PROJECT]", "[LOCATION]", "[HYPERPARAMETER_TUNING_JOB]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      display_name = "displayName1615086568"
      max_trial_count = 445994933
      parallel_trial_count = 1813795950
      max_failed_trial_count = 887662497
      expected_response = {
        name: name_2,
        display_name: display_name,
        max_trial_count: max_trial_count,
        parallel_trial_count: parallel_trial_count,
        max_failed_trial_count: max_failed_trial_count
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Aiplatform::V1::HyperparameterTuningJob)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::GetHyperparameterTuningJobRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_hyperparameter_tuning_job, mock_method)

      # Mock auth layer
      mock_credentials = MockJobServiceCredentials_v1.new("get_hyperparameter_tuning_job")

      Google::Cloud::Aiplatform::V1::JobService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Job.new(version: :v1)

          # Call method
          response = client.get_hyperparameter_tuning_job(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_hyperparameter_tuning_job(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_hyperparameter_tuning_job with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1::JobServiceClient.hyperparameter_tuning_job_path("[PROJECT]", "[LOCATION]", "[HYPERPARAMETER_TUNING_JOB]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::GetHyperparameterTuningJobRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_hyperparameter_tuning_job, mock_method)

      # Mock auth layer
      mock_credentials = MockJobServiceCredentials_v1.new("get_hyperparameter_tuning_job")

      Google::Cloud::Aiplatform::V1::JobService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Job.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.get_hyperparameter_tuning_job(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_hyperparameter_tuning_jobs' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Aiplatform::V1::JobServiceClient#list_hyperparameter_tuning_jobs."

    it 'invokes list_hyperparameter_tuning_jobs without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1::JobServiceClient.location_path("[PROJECT]", "[LOCATION]")

      # Create expected grpc response
      next_page_token = ""
      hyperparameter_tuning_jobs_element = {}
      hyperparameter_tuning_jobs = [hyperparameter_tuning_jobs_element]
      expected_response = { next_page_token: next_page_token, hyperparameter_tuning_jobs: hyperparameter_tuning_jobs }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Aiplatform::V1::ListHyperparameterTuningJobsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::ListHyperparameterTuningJobsRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_hyperparameter_tuning_jobs, mock_method)

      # Mock auth layer
      mock_credentials = MockJobServiceCredentials_v1.new("list_hyperparameter_tuning_jobs")

      Google::Cloud::Aiplatform::V1::JobService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Job.new(version: :v1)

          # Call method
          response = client.list_hyperparameter_tuning_jobs(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.hyperparameter_tuning_jobs.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_hyperparameter_tuning_jobs with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1::JobServiceClient.location_path("[PROJECT]", "[LOCATION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::ListHyperparameterTuningJobsRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_hyperparameter_tuning_jobs, mock_method)

      # Mock auth layer
      mock_credentials = MockJobServiceCredentials_v1.new("list_hyperparameter_tuning_jobs")

      Google::Cloud::Aiplatform::V1::JobService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Job.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.list_hyperparameter_tuning_jobs(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_hyperparameter_tuning_job' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Aiplatform::V1::JobServiceClient#delete_hyperparameter_tuning_job."

    it 'invokes delete_hyperparameter_tuning_job without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1::JobServiceClient.hyperparameter_tuning_job_path("[PROJECT]", "[LOCATION]", "[HYPERPARAMETER_TUNING_JOB]")

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Protobuf::Empty)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/delete_hyperparameter_tuning_job_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::DeleteHyperparameterTuningJobRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_hyperparameter_tuning_job, mock_method)

      # Mock auth layer
      mock_credentials = MockJobServiceCredentials_v1.new("delete_hyperparameter_tuning_job")

      Google::Cloud::Aiplatform::V1::JobService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Job.new(version: :v1)

          # Call method
          response = client.delete_hyperparameter_tuning_job(formatted_name)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes delete_hyperparameter_tuning_job and returns an operation error.' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1::JobServiceClient.hyperparameter_tuning_job_path("[PROJECT]", "[LOCATION]", "[HYPERPARAMETER_TUNING_JOB]")

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Aiplatform::V1::JobServiceClient#delete_hyperparameter_tuning_job.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/delete_hyperparameter_tuning_job_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::DeleteHyperparameterTuningJobRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_hyperparameter_tuning_job, mock_method)

      # Mock auth layer
      mock_credentials = MockJobServiceCredentials_v1.new("delete_hyperparameter_tuning_job")

      Google::Cloud::Aiplatform::V1::JobService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Job.new(version: :v1)

          # Call method
          response = client.delete_hyperparameter_tuning_job(formatted_name)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes delete_hyperparameter_tuning_job with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1::JobServiceClient.hyperparameter_tuning_job_path("[PROJECT]", "[LOCATION]", "[HYPERPARAMETER_TUNING_JOB]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::DeleteHyperparameterTuningJobRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_hyperparameter_tuning_job, mock_method)

      # Mock auth layer
      mock_credentials = MockJobServiceCredentials_v1.new("delete_hyperparameter_tuning_job")

      Google::Cloud::Aiplatform::V1::JobService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Job.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.delete_hyperparameter_tuning_job(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'cancel_hyperparameter_tuning_job' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Aiplatform::V1::JobServiceClient#cancel_hyperparameter_tuning_job."

    it 'invokes cancel_hyperparameter_tuning_job without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1::JobServiceClient.hyperparameter_tuning_job_path("[PROJECT]", "[LOCATION]", "[HYPERPARAMETER_TUNING_JOB]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::CancelHyperparameterTuningJobRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v1.new(:cancel_hyperparameter_tuning_job, mock_method)

      # Mock auth layer
      mock_credentials = MockJobServiceCredentials_v1.new("cancel_hyperparameter_tuning_job")

      Google::Cloud::Aiplatform::V1::JobService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Job.new(version: :v1)

          # Call method
          response = client.cancel_hyperparameter_tuning_job(formatted_name)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.cancel_hyperparameter_tuning_job(formatted_name) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes cancel_hyperparameter_tuning_job with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1::JobServiceClient.hyperparameter_tuning_job_path("[PROJECT]", "[LOCATION]", "[HYPERPARAMETER_TUNING_JOB]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::CancelHyperparameterTuningJobRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:cancel_hyperparameter_tuning_job, mock_method)

      # Mock auth layer
      mock_credentials = MockJobServiceCredentials_v1.new("cancel_hyperparameter_tuning_job")

      Google::Cloud::Aiplatform::V1::JobService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Job.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.cancel_hyperparameter_tuning_job(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_batch_prediction_job' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Aiplatform::V1::JobServiceClient#create_batch_prediction_job."

    it 'invokes create_batch_prediction_job without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1::JobServiceClient.location_path("[PROJECT]", "[LOCATION]")
      batch_prediction_job = {}

      # Create expected grpc response
      name = "name3373707"
      display_name = "displayName1615086568"
      model = "model104069929"
      expected_response = {
        name: name,
        display_name: display_name,
        model: model
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Aiplatform::V1::BatchPredictionJob)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::CreateBatchPredictionJobRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(batch_prediction_job, Google::Cloud::Aiplatform::V1::BatchPredictionJob), request.batch_prediction_job)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:create_batch_prediction_job, mock_method)

      # Mock auth layer
      mock_credentials = MockJobServiceCredentials_v1.new("create_batch_prediction_job")

      Google::Cloud::Aiplatform::V1::JobService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Job.new(version: :v1)

          # Call method
          response = client.create_batch_prediction_job(formatted_parent, batch_prediction_job)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_batch_prediction_job(formatted_parent, batch_prediction_job) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_batch_prediction_job with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1::JobServiceClient.location_path("[PROJECT]", "[LOCATION]")
      batch_prediction_job = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::CreateBatchPredictionJobRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(batch_prediction_job, Google::Cloud::Aiplatform::V1::BatchPredictionJob), request.batch_prediction_job)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:create_batch_prediction_job, mock_method)

      # Mock auth layer
      mock_credentials = MockJobServiceCredentials_v1.new("create_batch_prediction_job")

      Google::Cloud::Aiplatform::V1::JobService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Job.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.create_batch_prediction_job(formatted_parent, batch_prediction_job)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_batch_prediction_job' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Aiplatform::V1::JobServiceClient#get_batch_prediction_job."

    it 'invokes get_batch_prediction_job without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1::JobServiceClient.batch_prediction_job_path("[PROJECT]", "[LOCATION]", "[BATCH_PREDICTION_JOB]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      display_name = "displayName1615086568"
      model = "model104069929"
      expected_response = {
        name: name_2,
        display_name: display_name,
        model: model
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Aiplatform::V1::BatchPredictionJob)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::GetBatchPredictionJobRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_batch_prediction_job, mock_method)

      # Mock auth layer
      mock_credentials = MockJobServiceCredentials_v1.new("get_batch_prediction_job")

      Google::Cloud::Aiplatform::V1::JobService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Job.new(version: :v1)

          # Call method
          response = client.get_batch_prediction_job(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_batch_prediction_job(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_batch_prediction_job with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1::JobServiceClient.batch_prediction_job_path("[PROJECT]", "[LOCATION]", "[BATCH_PREDICTION_JOB]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::GetBatchPredictionJobRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_batch_prediction_job, mock_method)

      # Mock auth layer
      mock_credentials = MockJobServiceCredentials_v1.new("get_batch_prediction_job")

      Google::Cloud::Aiplatform::V1::JobService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Job.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.get_batch_prediction_job(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_batch_prediction_jobs' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Aiplatform::V1::JobServiceClient#list_batch_prediction_jobs."

    it 'invokes list_batch_prediction_jobs without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1::JobServiceClient.location_path("[PROJECT]", "[LOCATION]")

      # Create expected grpc response
      next_page_token = ""
      batch_prediction_jobs_element = {}
      batch_prediction_jobs = [batch_prediction_jobs_element]
      expected_response = { next_page_token: next_page_token, batch_prediction_jobs: batch_prediction_jobs }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Aiplatform::V1::ListBatchPredictionJobsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::ListBatchPredictionJobsRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_batch_prediction_jobs, mock_method)

      # Mock auth layer
      mock_credentials = MockJobServiceCredentials_v1.new("list_batch_prediction_jobs")

      Google::Cloud::Aiplatform::V1::JobService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Job.new(version: :v1)

          # Call method
          response = client.list_batch_prediction_jobs(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.batch_prediction_jobs.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_batch_prediction_jobs with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Aiplatform::V1::JobServiceClient.location_path("[PROJECT]", "[LOCATION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::ListBatchPredictionJobsRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_batch_prediction_jobs, mock_method)

      # Mock auth layer
      mock_credentials = MockJobServiceCredentials_v1.new("list_batch_prediction_jobs")

      Google::Cloud::Aiplatform::V1::JobService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Job.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.list_batch_prediction_jobs(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_batch_prediction_job' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Aiplatform::V1::JobServiceClient#delete_batch_prediction_job."

    it 'invokes delete_batch_prediction_job without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1::JobServiceClient.batch_prediction_job_path("[PROJECT]", "[LOCATION]", "[BATCH_PREDICTION_JOB]")

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Protobuf::Empty)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/delete_batch_prediction_job_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::DeleteBatchPredictionJobRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_batch_prediction_job, mock_method)

      # Mock auth layer
      mock_credentials = MockJobServiceCredentials_v1.new("delete_batch_prediction_job")

      Google::Cloud::Aiplatform::V1::JobService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Job.new(version: :v1)

          # Call method
          response = client.delete_batch_prediction_job(formatted_name)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes delete_batch_prediction_job and returns an operation error.' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1::JobServiceClient.batch_prediction_job_path("[PROJECT]", "[LOCATION]", "[BATCH_PREDICTION_JOB]")

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Aiplatform::V1::JobServiceClient#delete_batch_prediction_job.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/delete_batch_prediction_job_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::DeleteBatchPredictionJobRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_batch_prediction_job, mock_method)

      # Mock auth layer
      mock_credentials = MockJobServiceCredentials_v1.new("delete_batch_prediction_job")

      Google::Cloud::Aiplatform::V1::JobService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Job.new(version: :v1)

          # Call method
          response = client.delete_batch_prediction_job(formatted_name)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes delete_batch_prediction_job with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1::JobServiceClient.batch_prediction_job_path("[PROJECT]", "[LOCATION]", "[BATCH_PREDICTION_JOB]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::DeleteBatchPredictionJobRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_batch_prediction_job, mock_method)

      # Mock auth layer
      mock_credentials = MockJobServiceCredentials_v1.new("delete_batch_prediction_job")

      Google::Cloud::Aiplatform::V1::JobService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Job.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.delete_batch_prediction_job(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'cancel_batch_prediction_job' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Aiplatform::V1::JobServiceClient#cancel_batch_prediction_job."

    it 'invokes cancel_batch_prediction_job without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1::JobServiceClient.batch_prediction_job_path("[PROJECT]", "[LOCATION]", "[BATCH_PREDICTION_JOB]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::CancelBatchPredictionJobRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v1.new(:cancel_batch_prediction_job, mock_method)

      # Mock auth layer
      mock_credentials = MockJobServiceCredentials_v1.new("cancel_batch_prediction_job")

      Google::Cloud::Aiplatform::V1::JobService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Job.new(version: :v1)

          # Call method
          response = client.cancel_batch_prediction_job(formatted_name)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.cancel_batch_prediction_job(formatted_name) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes cancel_batch_prediction_job with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Aiplatform::V1::JobServiceClient.batch_prediction_job_path("[PROJECT]", "[LOCATION]", "[BATCH_PREDICTION_JOB]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Aiplatform::V1::CancelBatchPredictionJobRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:cancel_batch_prediction_job, mock_method)

      # Mock auth layer
      mock_credentials = MockJobServiceCredentials_v1.new("cancel_batch_prediction_job")

      Google::Cloud::Aiplatform::V1::JobService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Aiplatform::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Aiplatform::Job.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.cancel_batch_prediction_job(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end