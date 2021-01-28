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

require "google/cloud/os_config/v1beta"
require "google/cloud/os_config/v1beta/os_config_service_client"
require "google/cloud/osconfig/v1beta/osconfig_service_services_pb"

class CustomTestError_v1beta < StandardError; end

# Mock for the GRPC::ClientStub class.
class MockGrpcClientStub_v1beta

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

class MockOsConfigServiceCredentials_v1beta < Google::Cloud::OsConfig::V1beta::Credentials
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

describe Google::Cloud::OsConfig::V1beta::OsConfigServiceClient do

  describe 'delete_patch_deployment' do
    custom_error = CustomTestError_v1beta.new "Custom test error for Google::Cloud::OsConfig::V1beta::OsConfigServiceClient#delete_patch_deployment."

    it 'invokes delete_patch_deployment without error' do
      # Create request parameters
      name = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Osconfig::V1beta::DeletePatchDeploymentRequest, request)
        assert_equal(name, request.name)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:delete_patch_deployment, mock_method)

      # Mock auth layer
      mock_credentials = MockOsConfigServiceCredentials_v1beta.new("delete_patch_deployment")

      Google::Cloud::Osconfig::V1beta::OsConfigService::Stub.stub(:new, mock_stub) do
        Google::Cloud::OsConfig::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::OsConfig::V1beta.new

          # Call method
          response = client.delete_patch_deployment(name)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.delete_patch_deployment(name) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes delete_patch_deployment with error' do
      # Create request parameters
      name = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Osconfig::V1beta::DeletePatchDeploymentRequest, request)
        assert_equal(name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:delete_patch_deployment, mock_method)

      # Mock auth layer
      mock_credentials = MockOsConfigServiceCredentials_v1beta.new("delete_patch_deployment")

      Google::Cloud::Osconfig::V1beta::OsConfigService::Stub.stub(:new, mock_stub) do
        Google::Cloud::OsConfig::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::OsConfig::V1beta.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta do
            client.delete_patch_deployment(name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_guest_policy' do
    custom_error = CustomTestError_v1beta.new "Custom test error for Google::Cloud::OsConfig::V1beta::OsConfigServiceClient#delete_guest_policy."

    it 'invokes delete_guest_policy without error' do
      # Create request parameters
      formatted_name = Google::Cloud::OsConfig::V1beta::OsConfigServiceClient.guest_policy_path("[PROJECT]", "[GUEST_POLICY]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Osconfig::V1beta::DeleteGuestPolicyRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:delete_guest_policy, mock_method)

      # Mock auth layer
      mock_credentials = MockOsConfigServiceCredentials_v1beta.new("delete_guest_policy")

      Google::Cloud::Osconfig::V1beta::OsConfigService::Stub.stub(:new, mock_stub) do
        Google::Cloud::OsConfig::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::OsConfig::V1beta.new

          # Call method
          response = client.delete_guest_policy(formatted_name)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.delete_guest_policy(formatted_name) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes delete_guest_policy with error' do
      # Create request parameters
      formatted_name = Google::Cloud::OsConfig::V1beta::OsConfigServiceClient.guest_policy_path("[PROJECT]", "[GUEST_POLICY]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Osconfig::V1beta::DeleteGuestPolicyRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:delete_guest_policy, mock_method)

      # Mock auth layer
      mock_credentials = MockOsConfigServiceCredentials_v1beta.new("delete_guest_policy")

      Google::Cloud::Osconfig::V1beta::OsConfigService::Stub.stub(:new, mock_stub) do
        Google::Cloud::OsConfig::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::OsConfig::V1beta.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta do
            client.delete_guest_policy(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'execute_patch_job' do
    custom_error = CustomTestError_v1beta.new "Custom test error for Google::Cloud::OsConfig::V1beta::OsConfigServiceClient#execute_patch_job."

    it 'invokes execute_patch_job without error' do
      # Create request parameters
      parent = ''
      instance_filter = {}

      # Create expected grpc response
      name = "name3373707"
      display_name = "displayName1615086568"
      description = "description-1724546052"
      dry_run = false
      error_message = "errorMessage-1938755376"
      percent_complete = -1.96096922E8
      patch_deployment = "patchDeployment633565980"
      expected_response = {
        name: name,
        display_name: display_name,
        description: description,
        dry_run: dry_run,
        error_message: error_message,
        percent_complete: percent_complete,
        patch_deployment: patch_deployment
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Osconfig::V1beta::PatchJob)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Osconfig::V1beta::ExecutePatchJobRequest, request)
        assert_equal(parent, request.parent)
        assert_equal(Google::Gax::to_proto(instance_filter, Google::Cloud::Osconfig::V1beta::PatchInstanceFilter), request.instance_filter)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:execute_patch_job, mock_method)

      # Mock auth layer
      mock_credentials = MockOsConfigServiceCredentials_v1beta.new("execute_patch_job")

      Google::Cloud::Osconfig::V1beta::OsConfigService::Stub.stub(:new, mock_stub) do
        Google::Cloud::OsConfig::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::OsConfig::V1beta.new

          # Call method
          response = client.execute_patch_job(parent, instance_filter)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.execute_patch_job(parent, instance_filter) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes execute_patch_job with error' do
      # Create request parameters
      parent = ''
      instance_filter = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Osconfig::V1beta::ExecutePatchJobRequest, request)
        assert_equal(parent, request.parent)
        assert_equal(Google::Gax::to_proto(instance_filter, Google::Cloud::Osconfig::V1beta::PatchInstanceFilter), request.instance_filter)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:execute_patch_job, mock_method)

      # Mock auth layer
      mock_credentials = MockOsConfigServiceCredentials_v1beta.new("execute_patch_job")

      Google::Cloud::Osconfig::V1beta::OsConfigService::Stub.stub(:new, mock_stub) do
        Google::Cloud::OsConfig::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::OsConfig::V1beta.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta do
            client.execute_patch_job(parent, instance_filter)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_patch_job' do
    custom_error = CustomTestError_v1beta.new "Custom test error for Google::Cloud::OsConfig::V1beta::OsConfigServiceClient#get_patch_job."

    it 'invokes get_patch_job without error' do
      # Create request parameters
      name = ''

      # Create expected grpc response
      name_2 = "name2-1052831874"
      display_name = "displayName1615086568"
      description = "description-1724546052"
      dry_run = false
      error_message = "errorMessage-1938755376"
      percent_complete = -1.96096922E8
      patch_deployment = "patchDeployment633565980"
      expected_response = {
        name: name_2,
        display_name: display_name,
        description: description,
        dry_run: dry_run,
        error_message: error_message,
        percent_complete: percent_complete,
        patch_deployment: patch_deployment
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Osconfig::V1beta::PatchJob)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Osconfig::V1beta::GetPatchJobRequest, request)
        assert_equal(name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:get_patch_job, mock_method)

      # Mock auth layer
      mock_credentials = MockOsConfigServiceCredentials_v1beta.new("get_patch_job")

      Google::Cloud::Osconfig::V1beta::OsConfigService::Stub.stub(:new, mock_stub) do
        Google::Cloud::OsConfig::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::OsConfig::V1beta.new

          # Call method
          response = client.get_patch_job(name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_patch_job(name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_patch_job with error' do
      # Create request parameters
      name = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Osconfig::V1beta::GetPatchJobRequest, request)
        assert_equal(name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:get_patch_job, mock_method)

      # Mock auth layer
      mock_credentials = MockOsConfigServiceCredentials_v1beta.new("get_patch_job")

      Google::Cloud::Osconfig::V1beta::OsConfigService::Stub.stub(:new, mock_stub) do
        Google::Cloud::OsConfig::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::OsConfig::V1beta.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta do
            client.get_patch_job(name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'cancel_patch_job' do
    custom_error = CustomTestError_v1beta.new "Custom test error for Google::Cloud::OsConfig::V1beta::OsConfigServiceClient#cancel_patch_job."

    it 'invokes cancel_patch_job without error' do
      # Create request parameters
      name = ''

      # Create expected grpc response
      name_2 = "name2-1052831874"
      display_name = "displayName1615086568"
      description = "description-1724546052"
      dry_run = false
      error_message = "errorMessage-1938755376"
      percent_complete = -1.96096922E8
      patch_deployment = "patchDeployment633565980"
      expected_response = {
        name: name_2,
        display_name: display_name,
        description: description,
        dry_run: dry_run,
        error_message: error_message,
        percent_complete: percent_complete,
        patch_deployment: patch_deployment
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Osconfig::V1beta::PatchJob)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Osconfig::V1beta::CancelPatchJobRequest, request)
        assert_equal(name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:cancel_patch_job, mock_method)

      # Mock auth layer
      mock_credentials = MockOsConfigServiceCredentials_v1beta.new("cancel_patch_job")

      Google::Cloud::Osconfig::V1beta::OsConfigService::Stub.stub(:new, mock_stub) do
        Google::Cloud::OsConfig::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::OsConfig::V1beta.new

          # Call method
          response = client.cancel_patch_job(name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.cancel_patch_job(name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes cancel_patch_job with error' do
      # Create request parameters
      name = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Osconfig::V1beta::CancelPatchJobRequest, request)
        assert_equal(name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:cancel_patch_job, mock_method)

      # Mock auth layer
      mock_credentials = MockOsConfigServiceCredentials_v1beta.new("cancel_patch_job")

      Google::Cloud::Osconfig::V1beta::OsConfigService::Stub.stub(:new, mock_stub) do
        Google::Cloud::OsConfig::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::OsConfig::V1beta.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta do
            client.cancel_patch_job(name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_patch_jobs' do
    custom_error = CustomTestError_v1beta.new "Custom test error for Google::Cloud::OsConfig::V1beta::OsConfigServiceClient#list_patch_jobs."

    it 'invokes list_patch_jobs without error' do
      # Create request parameters
      parent = ''

      # Create expected grpc response
      next_page_token = ""
      patch_jobs_element = {}
      patch_jobs = [patch_jobs_element]
      expected_response = { next_page_token: next_page_token, patch_jobs: patch_jobs }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Osconfig::V1beta::ListPatchJobsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Osconfig::V1beta::ListPatchJobsRequest, request)
        assert_equal(parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:list_patch_jobs, mock_method)

      # Mock auth layer
      mock_credentials = MockOsConfigServiceCredentials_v1beta.new("list_patch_jobs")

      Google::Cloud::Osconfig::V1beta::OsConfigService::Stub.stub(:new, mock_stub) do
        Google::Cloud::OsConfig::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::OsConfig::V1beta.new

          # Call method
          response = client.list_patch_jobs(parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.patch_jobs.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_patch_jobs with error' do
      # Create request parameters
      parent = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Osconfig::V1beta::ListPatchJobsRequest, request)
        assert_equal(parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:list_patch_jobs, mock_method)

      # Mock auth layer
      mock_credentials = MockOsConfigServiceCredentials_v1beta.new("list_patch_jobs")

      Google::Cloud::Osconfig::V1beta::OsConfigService::Stub.stub(:new, mock_stub) do
        Google::Cloud::OsConfig::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::OsConfig::V1beta.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta do
            client.list_patch_jobs(parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_patch_job_instance_details' do
    custom_error = CustomTestError_v1beta.new "Custom test error for Google::Cloud::OsConfig::V1beta::OsConfigServiceClient#list_patch_job_instance_details."

    it 'invokes list_patch_job_instance_details without error' do
      # Create request parameters
      parent = ''

      # Create expected grpc response
      next_page_token = ""
      patch_job_instance_details_element = {}
      patch_job_instance_details = [patch_job_instance_details_element]
      expected_response = { next_page_token: next_page_token, patch_job_instance_details: patch_job_instance_details }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Osconfig::V1beta::ListPatchJobInstanceDetailsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Osconfig::V1beta::ListPatchJobInstanceDetailsRequest, request)
        assert_equal(parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:list_patch_job_instance_details, mock_method)

      # Mock auth layer
      mock_credentials = MockOsConfigServiceCredentials_v1beta.new("list_patch_job_instance_details")

      Google::Cloud::Osconfig::V1beta::OsConfigService::Stub.stub(:new, mock_stub) do
        Google::Cloud::OsConfig::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::OsConfig::V1beta.new

          # Call method
          response = client.list_patch_job_instance_details(parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.patch_job_instance_details.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_patch_job_instance_details with error' do
      # Create request parameters
      parent = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Osconfig::V1beta::ListPatchJobInstanceDetailsRequest, request)
        assert_equal(parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:list_patch_job_instance_details, mock_method)

      # Mock auth layer
      mock_credentials = MockOsConfigServiceCredentials_v1beta.new("list_patch_job_instance_details")

      Google::Cloud::Osconfig::V1beta::OsConfigService::Stub.stub(:new, mock_stub) do
        Google::Cloud::OsConfig::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::OsConfig::V1beta.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta do
            client.list_patch_job_instance_details(parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_patch_deployment' do
    custom_error = CustomTestError_v1beta.new "Custom test error for Google::Cloud::OsConfig::V1beta::OsConfigServiceClient#create_patch_deployment."

    it 'invokes create_patch_deployment without error' do
      # Create request parameters
      parent = ''
      patch_deployment_id = ''
      patch_deployment = {}

      # Create expected grpc response
      name = "name3373707"
      description = "description-1724546052"
      expected_response = { name: name, description: description }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Osconfig::V1beta::PatchDeployment)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Osconfig::V1beta::CreatePatchDeploymentRequest, request)
        assert_equal(parent, request.parent)
        assert_equal(patch_deployment_id, request.patch_deployment_id)
        assert_equal(Google::Gax::to_proto(patch_deployment, Google::Cloud::Osconfig::V1beta::PatchDeployment), request.patch_deployment)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:create_patch_deployment, mock_method)

      # Mock auth layer
      mock_credentials = MockOsConfigServiceCredentials_v1beta.new("create_patch_deployment")

      Google::Cloud::Osconfig::V1beta::OsConfigService::Stub.stub(:new, mock_stub) do
        Google::Cloud::OsConfig::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::OsConfig::V1beta.new

          # Call method
          response = client.create_patch_deployment(
            parent,
            patch_deployment_id,
            patch_deployment
          )

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_patch_deployment(
            parent,
            patch_deployment_id,
            patch_deployment
          ) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_patch_deployment with error' do
      # Create request parameters
      parent = ''
      patch_deployment_id = ''
      patch_deployment = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Osconfig::V1beta::CreatePatchDeploymentRequest, request)
        assert_equal(parent, request.parent)
        assert_equal(patch_deployment_id, request.patch_deployment_id)
        assert_equal(Google::Gax::to_proto(patch_deployment, Google::Cloud::Osconfig::V1beta::PatchDeployment), request.patch_deployment)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:create_patch_deployment, mock_method)

      # Mock auth layer
      mock_credentials = MockOsConfigServiceCredentials_v1beta.new("create_patch_deployment")

      Google::Cloud::Osconfig::V1beta::OsConfigService::Stub.stub(:new, mock_stub) do
        Google::Cloud::OsConfig::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::OsConfig::V1beta.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta do
            client.create_patch_deployment(
              parent,
              patch_deployment_id,
              patch_deployment
            )
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_patch_deployment' do
    custom_error = CustomTestError_v1beta.new "Custom test error for Google::Cloud::OsConfig::V1beta::OsConfigServiceClient#get_patch_deployment."

    it 'invokes get_patch_deployment without error' do
      # Create request parameters
      name = ''

      # Create expected grpc response
      name_2 = "name2-1052831874"
      description = "description-1724546052"
      expected_response = { name: name_2, description: description }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Osconfig::V1beta::PatchDeployment)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Osconfig::V1beta::GetPatchDeploymentRequest, request)
        assert_equal(name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:get_patch_deployment, mock_method)

      # Mock auth layer
      mock_credentials = MockOsConfigServiceCredentials_v1beta.new("get_patch_deployment")

      Google::Cloud::Osconfig::V1beta::OsConfigService::Stub.stub(:new, mock_stub) do
        Google::Cloud::OsConfig::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::OsConfig::V1beta.new

          # Call method
          response = client.get_patch_deployment(name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_patch_deployment(name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_patch_deployment with error' do
      # Create request parameters
      name = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Osconfig::V1beta::GetPatchDeploymentRequest, request)
        assert_equal(name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:get_patch_deployment, mock_method)

      # Mock auth layer
      mock_credentials = MockOsConfigServiceCredentials_v1beta.new("get_patch_deployment")

      Google::Cloud::Osconfig::V1beta::OsConfigService::Stub.stub(:new, mock_stub) do
        Google::Cloud::OsConfig::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::OsConfig::V1beta.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta do
            client.get_patch_deployment(name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_patch_deployments' do
    custom_error = CustomTestError_v1beta.new "Custom test error for Google::Cloud::OsConfig::V1beta::OsConfigServiceClient#list_patch_deployments."

    it 'invokes list_patch_deployments without error' do
      # Create request parameters
      parent = ''

      # Create expected grpc response
      next_page_token = ""
      patch_deployments_element = {}
      patch_deployments = [patch_deployments_element]
      expected_response = { next_page_token: next_page_token, patch_deployments: patch_deployments }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Osconfig::V1beta::ListPatchDeploymentsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Osconfig::V1beta::ListPatchDeploymentsRequest, request)
        assert_equal(parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:list_patch_deployments, mock_method)

      # Mock auth layer
      mock_credentials = MockOsConfigServiceCredentials_v1beta.new("list_patch_deployments")

      Google::Cloud::Osconfig::V1beta::OsConfigService::Stub.stub(:new, mock_stub) do
        Google::Cloud::OsConfig::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::OsConfig::V1beta.new

          # Call method
          response = client.list_patch_deployments(parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.patch_deployments.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_patch_deployments with error' do
      # Create request parameters
      parent = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Osconfig::V1beta::ListPatchDeploymentsRequest, request)
        assert_equal(parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:list_patch_deployments, mock_method)

      # Mock auth layer
      mock_credentials = MockOsConfigServiceCredentials_v1beta.new("list_patch_deployments")

      Google::Cloud::Osconfig::V1beta::OsConfigService::Stub.stub(:new, mock_stub) do
        Google::Cloud::OsConfig::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::OsConfig::V1beta.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta do
            client.list_patch_deployments(parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_guest_policy' do
    custom_error = CustomTestError_v1beta.new "Custom test error for Google::Cloud::OsConfig::V1beta::OsConfigServiceClient#create_guest_policy."

    it 'invokes create_guest_policy without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::OsConfig::V1beta::OsConfigServiceClient.project_path("[PROJECT]")
      guest_policy_id = ''
      guest_policy = {}

      # Create expected grpc response
      name = "name3373707"
      description = "description-1724546052"
      etag = "etag3123477"
      expected_response = {
        name: name,
        description: description,
        etag: etag
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Osconfig::V1beta::GuestPolicy)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Osconfig::V1beta::CreateGuestPolicyRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(guest_policy_id, request.guest_policy_id)
        assert_equal(Google::Gax::to_proto(guest_policy, Google::Cloud::Osconfig::V1beta::GuestPolicy), request.guest_policy)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:create_guest_policy, mock_method)

      # Mock auth layer
      mock_credentials = MockOsConfigServiceCredentials_v1beta.new("create_guest_policy")

      Google::Cloud::Osconfig::V1beta::OsConfigService::Stub.stub(:new, mock_stub) do
        Google::Cloud::OsConfig::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::OsConfig::V1beta.new

          # Call method
          response = client.create_guest_policy(
            formatted_parent,
            guest_policy_id,
            guest_policy
          )

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_guest_policy(
            formatted_parent,
            guest_policy_id,
            guest_policy
          ) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_guest_policy with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::OsConfig::V1beta::OsConfigServiceClient.project_path("[PROJECT]")
      guest_policy_id = ''
      guest_policy = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Osconfig::V1beta::CreateGuestPolicyRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(guest_policy_id, request.guest_policy_id)
        assert_equal(Google::Gax::to_proto(guest_policy, Google::Cloud::Osconfig::V1beta::GuestPolicy), request.guest_policy)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:create_guest_policy, mock_method)

      # Mock auth layer
      mock_credentials = MockOsConfigServiceCredentials_v1beta.new("create_guest_policy")

      Google::Cloud::Osconfig::V1beta::OsConfigService::Stub.stub(:new, mock_stub) do
        Google::Cloud::OsConfig::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::OsConfig::V1beta.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta do
            client.create_guest_policy(
              formatted_parent,
              guest_policy_id,
              guest_policy
            )
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_guest_policy' do
    custom_error = CustomTestError_v1beta.new "Custom test error for Google::Cloud::OsConfig::V1beta::OsConfigServiceClient#get_guest_policy."

    it 'invokes get_guest_policy without error' do
      # Create request parameters
      formatted_name = Google::Cloud::OsConfig::V1beta::OsConfigServiceClient.guest_policy_path("[PROJECT]", "[GUEST_POLICY]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      description = "description-1724546052"
      etag = "etag3123477"
      expected_response = {
        name: name_2,
        description: description,
        etag: etag
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Osconfig::V1beta::GuestPolicy)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Osconfig::V1beta::GetGuestPolicyRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:get_guest_policy, mock_method)

      # Mock auth layer
      mock_credentials = MockOsConfigServiceCredentials_v1beta.new("get_guest_policy")

      Google::Cloud::Osconfig::V1beta::OsConfigService::Stub.stub(:new, mock_stub) do
        Google::Cloud::OsConfig::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::OsConfig::V1beta.new

          # Call method
          response = client.get_guest_policy(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_guest_policy(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_guest_policy with error' do
      # Create request parameters
      formatted_name = Google::Cloud::OsConfig::V1beta::OsConfigServiceClient.guest_policy_path("[PROJECT]", "[GUEST_POLICY]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Osconfig::V1beta::GetGuestPolicyRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:get_guest_policy, mock_method)

      # Mock auth layer
      mock_credentials = MockOsConfigServiceCredentials_v1beta.new("get_guest_policy")

      Google::Cloud::Osconfig::V1beta::OsConfigService::Stub.stub(:new, mock_stub) do
        Google::Cloud::OsConfig::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::OsConfig::V1beta.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta do
            client.get_guest_policy(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_guest_policies' do
    custom_error = CustomTestError_v1beta.new "Custom test error for Google::Cloud::OsConfig::V1beta::OsConfigServiceClient#list_guest_policies."

    it 'invokes list_guest_policies without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::OsConfig::V1beta::OsConfigServiceClient.project_path("[PROJECT]")

      # Create expected grpc response
      next_page_token = ""
      guest_policies_element = {}
      guest_policies = [guest_policies_element]
      expected_response = { next_page_token: next_page_token, guest_policies: guest_policies }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Osconfig::V1beta::ListGuestPoliciesResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Osconfig::V1beta::ListGuestPoliciesRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:list_guest_policies, mock_method)

      # Mock auth layer
      mock_credentials = MockOsConfigServiceCredentials_v1beta.new("list_guest_policies")

      Google::Cloud::Osconfig::V1beta::OsConfigService::Stub.stub(:new, mock_stub) do
        Google::Cloud::OsConfig::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::OsConfig::V1beta.new

          # Call method
          response = client.list_guest_policies(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.guest_policies.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_guest_policies with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::OsConfig::V1beta::OsConfigServiceClient.project_path("[PROJECT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Osconfig::V1beta::ListGuestPoliciesRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:list_guest_policies, mock_method)

      # Mock auth layer
      mock_credentials = MockOsConfigServiceCredentials_v1beta.new("list_guest_policies")

      Google::Cloud::Osconfig::V1beta::OsConfigService::Stub.stub(:new, mock_stub) do
        Google::Cloud::OsConfig::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::OsConfig::V1beta.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta do
            client.list_guest_policies(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_guest_policy' do
    custom_error = CustomTestError_v1beta.new "Custom test error for Google::Cloud::OsConfig::V1beta::OsConfigServiceClient#update_guest_policy."

    it 'invokes update_guest_policy without error' do
      # Create request parameters
      guest_policy = {}

      # Create expected grpc response
      name = "name3373707"
      description = "description-1724546052"
      etag = "etag3123477"
      expected_response = {
        name: name,
        description: description,
        etag: etag
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Osconfig::V1beta::GuestPolicy)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Osconfig::V1beta::UpdateGuestPolicyRequest, request)
        assert_equal(Google::Gax::to_proto(guest_policy, Google::Cloud::Osconfig::V1beta::GuestPolicy), request.guest_policy)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:update_guest_policy, mock_method)

      # Mock auth layer
      mock_credentials = MockOsConfigServiceCredentials_v1beta.new("update_guest_policy")

      Google::Cloud::Osconfig::V1beta::OsConfigService::Stub.stub(:new, mock_stub) do
        Google::Cloud::OsConfig::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::OsConfig::V1beta.new

          # Call method
          response = client.update_guest_policy(guest_policy)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.update_guest_policy(guest_policy) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes update_guest_policy with error' do
      # Create request parameters
      guest_policy = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Osconfig::V1beta::UpdateGuestPolicyRequest, request)
        assert_equal(Google::Gax::to_proto(guest_policy, Google::Cloud::Osconfig::V1beta::GuestPolicy), request.guest_policy)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:update_guest_policy, mock_method)

      # Mock auth layer
      mock_credentials = MockOsConfigServiceCredentials_v1beta.new("update_guest_policy")

      Google::Cloud::Osconfig::V1beta::OsConfigService::Stub.stub(:new, mock_stub) do
        Google::Cloud::OsConfig::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::OsConfig::V1beta.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta do
            client.update_guest_policy(guest_policy)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'lookup_effective_guest_policy' do
    custom_error = CustomTestError_v1beta.new "Custom test error for Google::Cloud::OsConfig::V1beta::OsConfigServiceClient#lookup_effective_guest_policy."

    it 'invokes lookup_effective_guest_policy without error' do
      # Create request parameters
      instance = ''

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Osconfig::V1beta::EffectiveGuestPolicy)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Osconfig::V1beta::LookupEffectiveGuestPolicyRequest, request)
        assert_equal(instance, request.instance)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:lookup_effective_guest_policy, mock_method)

      # Mock auth layer
      mock_credentials = MockOsConfigServiceCredentials_v1beta.new("lookup_effective_guest_policy")

      Google::Cloud::Osconfig::V1beta::OsConfigService::Stub.stub(:new, mock_stub) do
        Google::Cloud::OsConfig::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::OsConfig::V1beta.new

          # Call method
          response = client.lookup_effective_guest_policy(instance)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.lookup_effective_guest_policy(instance) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes lookup_effective_guest_policy with error' do
      # Create request parameters
      instance = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Osconfig::V1beta::LookupEffectiveGuestPolicyRequest, request)
        assert_equal(instance, request.instance)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta.new(:lookup_effective_guest_policy, mock_method)

      # Mock auth layer
      mock_credentials = MockOsConfigServiceCredentials_v1beta.new("lookup_effective_guest_policy")

      Google::Cloud::Osconfig::V1beta::OsConfigService::Stub.stub(:new, mock_stub) do
        Google::Cloud::OsConfig::V1beta::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::OsConfig::V1beta.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta do
            client.lookup_effective_guest_policy(instance)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end