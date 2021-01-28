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

require "google/cloud/video/transcoder"
require "google/cloud/video/transcoder/v1beta1/transcoder_service_client"
require "google/cloud/video/transcoder/v1beta1/services_services_pb"

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

class MockTranscoderServiceCredentials_v1beta1 < Google::Cloud::Video::Transcoder::V1beta1::Credentials
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

describe Google::Cloud::Video::Transcoder::V1beta1::TranscoderServiceClient do

  describe 'create_job' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Video::Transcoder::V1beta1::TranscoderServiceClient#create_job."

    it 'invokes create_job without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Video::Transcoder::V1beta1::TranscoderServiceClient.location_path("[PROJECT]", "[LOCATION]")
      job = {}

      # Create expected grpc response
      name = "name3373707"
      input_uri = "inputUri1707300727"
      output_uri = "outputUri-1273518802"
      template_id = "templateId1769642752"
      priority = 1165461084
      failure_reason = "failureReason1743941273"
      expected_response = {
        name: name,
        input_uri: input_uri,
        output_uri: output_uri,
        template_id: template_id,
        priority: priority,
        failure_reason: failure_reason
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Video::Transcoder::V1beta1::Job)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Video::Transcoder::V1beta1::CreateJobRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(job, Google::Cloud::Video::Transcoder::V1beta1::Job), request.job)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:create_job, mock_method)

      # Mock auth layer
      mock_credentials = MockTranscoderServiceCredentials_v1beta1.new("create_job")

      Google::Cloud::Video::Transcoder::V1beta1::TranscoderService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Video::Transcoder::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Video::Transcoder.new(version: :v1beta1)

          # Call method
          response = client.create_job(formatted_parent, job)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_job(formatted_parent, job) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_job with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Video::Transcoder::V1beta1::TranscoderServiceClient.location_path("[PROJECT]", "[LOCATION]")
      job = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Video::Transcoder::V1beta1::CreateJobRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(job, Google::Cloud::Video::Transcoder::V1beta1::Job), request.job)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:create_job, mock_method)

      # Mock auth layer
      mock_credentials = MockTranscoderServiceCredentials_v1beta1.new("create_job")

      Google::Cloud::Video::Transcoder::V1beta1::TranscoderService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Video::Transcoder::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Video::Transcoder.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.create_job(formatted_parent, job)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_jobs' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Video::Transcoder::V1beta1::TranscoderServiceClient#list_jobs."

    it 'invokes list_jobs without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Video::Transcoder::V1beta1::TranscoderServiceClient.location_path("[PROJECT]", "[LOCATION]")

      # Create expected grpc response
      next_page_token = ""
      jobs_element = {}
      jobs = [jobs_element]
      expected_response = { next_page_token: next_page_token, jobs: jobs }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Video::Transcoder::V1beta1::ListJobsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Video::Transcoder::V1beta1::ListJobsRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:list_jobs, mock_method)

      # Mock auth layer
      mock_credentials = MockTranscoderServiceCredentials_v1beta1.new("list_jobs")

      Google::Cloud::Video::Transcoder::V1beta1::TranscoderService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Video::Transcoder::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Video::Transcoder.new(version: :v1beta1)

          # Call method
          response = client.list_jobs(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.jobs.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_jobs with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Video::Transcoder::V1beta1::TranscoderServiceClient.location_path("[PROJECT]", "[LOCATION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Video::Transcoder::V1beta1::ListJobsRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:list_jobs, mock_method)

      # Mock auth layer
      mock_credentials = MockTranscoderServiceCredentials_v1beta1.new("list_jobs")

      Google::Cloud::Video::Transcoder::V1beta1::TranscoderService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Video::Transcoder::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Video::Transcoder.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.list_jobs(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_job' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Video::Transcoder::V1beta1::TranscoderServiceClient#get_job."

    it 'invokes get_job without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Video::Transcoder::V1beta1::TranscoderServiceClient.job_path("[PROJECT]", "[LOCATION]", "[JOB]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      input_uri = "inputUri1707300727"
      output_uri = "outputUri-1273518802"
      template_id = "templateId1769642752"
      priority = 1165461084
      failure_reason = "failureReason1743941273"
      expected_response = {
        name: name_2,
        input_uri: input_uri,
        output_uri: output_uri,
        template_id: template_id,
        priority: priority,
        failure_reason: failure_reason
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Video::Transcoder::V1beta1::Job)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Video::Transcoder::V1beta1::GetJobRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:get_job, mock_method)

      # Mock auth layer
      mock_credentials = MockTranscoderServiceCredentials_v1beta1.new("get_job")

      Google::Cloud::Video::Transcoder::V1beta1::TranscoderService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Video::Transcoder::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Video::Transcoder.new(version: :v1beta1)

          # Call method
          response = client.get_job(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_job(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_job with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Video::Transcoder::V1beta1::TranscoderServiceClient.job_path("[PROJECT]", "[LOCATION]", "[JOB]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Video::Transcoder::V1beta1::GetJobRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:get_job, mock_method)

      # Mock auth layer
      mock_credentials = MockTranscoderServiceCredentials_v1beta1.new("get_job")

      Google::Cloud::Video::Transcoder::V1beta1::TranscoderService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Video::Transcoder::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Video::Transcoder.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.get_job(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_job' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Video::Transcoder::V1beta1::TranscoderServiceClient#delete_job."

    it 'invokes delete_job without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Video::Transcoder::V1beta1::TranscoderServiceClient.job_path("[PROJECT]", "[LOCATION]", "[JOB]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Video::Transcoder::V1beta1::DeleteJobRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:delete_job, mock_method)

      # Mock auth layer
      mock_credentials = MockTranscoderServiceCredentials_v1beta1.new("delete_job")

      Google::Cloud::Video::Transcoder::V1beta1::TranscoderService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Video::Transcoder::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Video::Transcoder.new(version: :v1beta1)

          # Call method
          response = client.delete_job(formatted_name)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.delete_job(formatted_name) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes delete_job with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Video::Transcoder::V1beta1::TranscoderServiceClient.job_path("[PROJECT]", "[LOCATION]", "[JOB]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Video::Transcoder::V1beta1::DeleteJobRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:delete_job, mock_method)

      # Mock auth layer
      mock_credentials = MockTranscoderServiceCredentials_v1beta1.new("delete_job")

      Google::Cloud::Video::Transcoder::V1beta1::TranscoderService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Video::Transcoder::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Video::Transcoder.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.delete_job(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_job_template' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Video::Transcoder::V1beta1::TranscoderServiceClient#create_job_template."

    it 'invokes create_job_template without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Video::Transcoder::V1beta1::TranscoderServiceClient.location_path("[PROJECT]", "[LOCATION]")
      job_template = {}
      job_template_id = ''

      # Create expected grpc response
      name = "name3373707"
      expected_response = { name: name }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Video::Transcoder::V1beta1::JobTemplate)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Video::Transcoder::V1beta1::CreateJobTemplateRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(job_template, Google::Cloud::Video::Transcoder::V1beta1::JobTemplate), request.job_template)
        assert_equal(job_template_id, request.job_template_id)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:create_job_template, mock_method)

      # Mock auth layer
      mock_credentials = MockTranscoderServiceCredentials_v1beta1.new("create_job_template")

      Google::Cloud::Video::Transcoder::V1beta1::TranscoderService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Video::Transcoder::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Video::Transcoder.new(version: :v1beta1)

          # Call method
          response = client.create_job_template(
            formatted_parent,
            job_template,
            job_template_id
          )

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_job_template(
            formatted_parent,
            job_template,
            job_template_id
          ) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_job_template with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Video::Transcoder::V1beta1::TranscoderServiceClient.location_path("[PROJECT]", "[LOCATION]")
      job_template = {}
      job_template_id = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Video::Transcoder::V1beta1::CreateJobTemplateRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(job_template, Google::Cloud::Video::Transcoder::V1beta1::JobTemplate), request.job_template)
        assert_equal(job_template_id, request.job_template_id)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:create_job_template, mock_method)

      # Mock auth layer
      mock_credentials = MockTranscoderServiceCredentials_v1beta1.new("create_job_template")

      Google::Cloud::Video::Transcoder::V1beta1::TranscoderService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Video::Transcoder::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Video::Transcoder.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.create_job_template(
              formatted_parent,
              job_template,
              job_template_id
            )
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_job_templates' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Video::Transcoder::V1beta1::TranscoderServiceClient#list_job_templates."

    it 'invokes list_job_templates without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Video::Transcoder::V1beta1::TranscoderServiceClient.location_path("[PROJECT]", "[LOCATION]")

      # Create expected grpc response
      next_page_token = ""
      job_templates_element = {}
      job_templates = [job_templates_element]
      expected_response = { next_page_token: next_page_token, job_templates: job_templates }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Video::Transcoder::V1beta1::ListJobTemplatesResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Video::Transcoder::V1beta1::ListJobTemplatesRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:list_job_templates, mock_method)

      # Mock auth layer
      mock_credentials = MockTranscoderServiceCredentials_v1beta1.new("list_job_templates")

      Google::Cloud::Video::Transcoder::V1beta1::TranscoderService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Video::Transcoder::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Video::Transcoder.new(version: :v1beta1)

          # Call method
          response = client.list_job_templates(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.job_templates.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_job_templates with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Video::Transcoder::V1beta1::TranscoderServiceClient.location_path("[PROJECT]", "[LOCATION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Video::Transcoder::V1beta1::ListJobTemplatesRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:list_job_templates, mock_method)

      # Mock auth layer
      mock_credentials = MockTranscoderServiceCredentials_v1beta1.new("list_job_templates")

      Google::Cloud::Video::Transcoder::V1beta1::TranscoderService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Video::Transcoder::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Video::Transcoder.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.list_job_templates(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_job_template' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Video::Transcoder::V1beta1::TranscoderServiceClient#get_job_template."

    it 'invokes get_job_template without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Video::Transcoder::V1beta1::TranscoderServiceClient.job_template_path("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      expected_response = { name: name_2 }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Video::Transcoder::V1beta1::JobTemplate)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Video::Transcoder::V1beta1::GetJobTemplateRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:get_job_template, mock_method)

      # Mock auth layer
      mock_credentials = MockTranscoderServiceCredentials_v1beta1.new("get_job_template")

      Google::Cloud::Video::Transcoder::V1beta1::TranscoderService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Video::Transcoder::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Video::Transcoder.new(version: :v1beta1)

          # Call method
          response = client.get_job_template(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_job_template(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_job_template with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Video::Transcoder::V1beta1::TranscoderServiceClient.job_template_path("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Video::Transcoder::V1beta1::GetJobTemplateRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:get_job_template, mock_method)

      # Mock auth layer
      mock_credentials = MockTranscoderServiceCredentials_v1beta1.new("get_job_template")

      Google::Cloud::Video::Transcoder::V1beta1::TranscoderService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Video::Transcoder::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Video::Transcoder.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.get_job_template(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_job_template' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Video::Transcoder::V1beta1::TranscoderServiceClient#delete_job_template."

    it 'invokes delete_job_template without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Video::Transcoder::V1beta1::TranscoderServiceClient.job_template_path("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Video::Transcoder::V1beta1::DeleteJobTemplateRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:delete_job_template, mock_method)

      # Mock auth layer
      mock_credentials = MockTranscoderServiceCredentials_v1beta1.new("delete_job_template")

      Google::Cloud::Video::Transcoder::V1beta1::TranscoderService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Video::Transcoder::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Video::Transcoder.new(version: :v1beta1)

          # Call method
          response = client.delete_job_template(formatted_name)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.delete_job_template(formatted_name) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes delete_job_template with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Video::Transcoder::V1beta1::TranscoderServiceClient.job_template_path("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Video::Transcoder::V1beta1::DeleteJobTemplateRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:delete_job_template, mock_method)

      # Mock auth layer
      mock_credentials = MockTranscoderServiceCredentials_v1beta1.new("delete_job_template")

      Google::Cloud::Video::Transcoder::V1beta1::TranscoderService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Video::Transcoder::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Video::Transcoder.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.delete_job_template(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end