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

require "google/cloud/g_suite_add_ons"
require "google/cloud/g_suite_add_ons/v1/g_suite_add_ons_client"
require "google/cloud/gsuiteaddons/v1/gsuiteaddons_services_pb"

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

class MockGSuiteAddOnsCredentials_v1 < Google::Cloud::GSuiteAddOns::V1::Credentials
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

describe Google::Cloud::GSuiteAddOns::V1::GSuiteAddOnsClient do

  describe 'get_authorization' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::GSuiteAddOns::V1::GSuiteAddOnsClient#get_authorization."

    it 'invokes get_authorization without error' do
      # Create request parameters
      formatted_name = Google::Cloud::GSuiteAddOns::V1::GSuiteAddOnsClient.authorization_path("[PROJECT]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      service_account_email = "serviceAccountEmail-1300473088"
      oauth_client_id = "oauthClientId-1137123737"
      expected_response = {
        name: name_2,
        service_account_email: service_account_email,
        oauth_client_id: oauth_client_id
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Gsuiteaddons::V1::Authorization)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gsuiteaddons::V1::GetAuthorizationRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_authorization, mock_method)

      # Mock auth layer
      mock_credentials = MockGSuiteAddOnsCredentials_v1.new("get_authorization")

      Google::Cloud::Gsuiteaddons::V1::GSuiteAddOns::Stub.stub(:new, mock_stub) do
        Google::Cloud::GSuiteAddOns::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::GSuiteAddOns.new(version: :v1)

          # Call method
          response = client.get_authorization(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_authorization(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_authorization with error' do
      # Create request parameters
      formatted_name = Google::Cloud::GSuiteAddOns::V1::GSuiteAddOnsClient.authorization_path("[PROJECT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gsuiteaddons::V1::GetAuthorizationRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_authorization, mock_method)

      # Mock auth layer
      mock_credentials = MockGSuiteAddOnsCredentials_v1.new("get_authorization")

      Google::Cloud::Gsuiteaddons::V1::GSuiteAddOns::Stub.stub(:new, mock_stub) do
        Google::Cloud::GSuiteAddOns::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::GSuiteAddOns.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.get_authorization(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_deployment' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::GSuiteAddOns::V1::GSuiteAddOnsClient#create_deployment."

    it 'invokes create_deployment without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::GSuiteAddOns::V1::GSuiteAddOnsClient.project_path("[PROJECT]")
      deployment_id = ''
      deployment = {}

      # Create expected grpc response
      name = "name3373707"
      etag = "etag3123477"
      expected_response = { name: name, etag: etag }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Gsuiteaddons::V1::Deployment)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gsuiteaddons::V1::CreateDeploymentRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(deployment_id, request.deployment_id)
        assert_equal(Google::Gax::to_proto(deployment, Google::Cloud::Gsuiteaddons::V1::Deployment), request.deployment)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:create_deployment, mock_method)

      # Mock auth layer
      mock_credentials = MockGSuiteAddOnsCredentials_v1.new("create_deployment")

      Google::Cloud::Gsuiteaddons::V1::GSuiteAddOns::Stub.stub(:new, mock_stub) do
        Google::Cloud::GSuiteAddOns::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::GSuiteAddOns.new(version: :v1)

          # Call method
          response = client.create_deployment(
            formatted_parent,
            deployment_id,
            deployment
          )

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_deployment(
            formatted_parent,
            deployment_id,
            deployment
          ) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_deployment with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::GSuiteAddOns::V1::GSuiteAddOnsClient.project_path("[PROJECT]")
      deployment_id = ''
      deployment = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gsuiteaddons::V1::CreateDeploymentRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(deployment_id, request.deployment_id)
        assert_equal(Google::Gax::to_proto(deployment, Google::Cloud::Gsuiteaddons::V1::Deployment), request.deployment)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:create_deployment, mock_method)

      # Mock auth layer
      mock_credentials = MockGSuiteAddOnsCredentials_v1.new("create_deployment")

      Google::Cloud::Gsuiteaddons::V1::GSuiteAddOns::Stub.stub(:new, mock_stub) do
        Google::Cloud::GSuiteAddOns::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::GSuiteAddOns.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.create_deployment(
              formatted_parent,
              deployment_id,
              deployment
            )
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'replace_deployment' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::GSuiteAddOns::V1::GSuiteAddOnsClient#replace_deployment."

    it 'invokes replace_deployment without error' do
      # Create request parameters
      deployment = {}

      # Create expected grpc response
      name = "name3373707"
      etag = "etag3123477"
      expected_response = { name: name, etag: etag }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Gsuiteaddons::V1::Deployment)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gsuiteaddons::V1::ReplaceDeploymentRequest, request)
        assert_equal(Google::Gax::to_proto(deployment, Google::Cloud::Gsuiteaddons::V1::Deployment), request.deployment)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:replace_deployment, mock_method)

      # Mock auth layer
      mock_credentials = MockGSuiteAddOnsCredentials_v1.new("replace_deployment")

      Google::Cloud::Gsuiteaddons::V1::GSuiteAddOns::Stub.stub(:new, mock_stub) do
        Google::Cloud::GSuiteAddOns::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::GSuiteAddOns.new(version: :v1)

          # Call method
          response = client.replace_deployment(deployment)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.replace_deployment(deployment) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes replace_deployment with error' do
      # Create request parameters
      deployment = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gsuiteaddons::V1::ReplaceDeploymentRequest, request)
        assert_equal(Google::Gax::to_proto(deployment, Google::Cloud::Gsuiteaddons::V1::Deployment), request.deployment)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:replace_deployment, mock_method)

      # Mock auth layer
      mock_credentials = MockGSuiteAddOnsCredentials_v1.new("replace_deployment")

      Google::Cloud::Gsuiteaddons::V1::GSuiteAddOns::Stub.stub(:new, mock_stub) do
        Google::Cloud::GSuiteAddOns::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::GSuiteAddOns.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.replace_deployment(deployment)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_deployment' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::GSuiteAddOns::V1::GSuiteAddOnsClient#get_deployment."

    it 'invokes get_deployment without error' do
      # Create request parameters
      formatted_name = Google::Cloud::GSuiteAddOns::V1::GSuiteAddOnsClient.deployment_path("[PROJECT]", "[DEPLOYMENT]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      etag = "etag3123477"
      expected_response = { name: name_2, etag: etag }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Gsuiteaddons::V1::Deployment)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gsuiteaddons::V1::GetDeploymentRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_deployment, mock_method)

      # Mock auth layer
      mock_credentials = MockGSuiteAddOnsCredentials_v1.new("get_deployment")

      Google::Cloud::Gsuiteaddons::V1::GSuiteAddOns::Stub.stub(:new, mock_stub) do
        Google::Cloud::GSuiteAddOns::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::GSuiteAddOns.new(version: :v1)

          # Call method
          response = client.get_deployment(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_deployment(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_deployment with error' do
      # Create request parameters
      formatted_name = Google::Cloud::GSuiteAddOns::V1::GSuiteAddOnsClient.deployment_path("[PROJECT]", "[DEPLOYMENT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gsuiteaddons::V1::GetDeploymentRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_deployment, mock_method)

      # Mock auth layer
      mock_credentials = MockGSuiteAddOnsCredentials_v1.new("get_deployment")

      Google::Cloud::Gsuiteaddons::V1::GSuiteAddOns::Stub.stub(:new, mock_stub) do
        Google::Cloud::GSuiteAddOns::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::GSuiteAddOns.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.get_deployment(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_deployments' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::GSuiteAddOns::V1::GSuiteAddOnsClient#list_deployments."

    it 'invokes list_deployments without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::GSuiteAddOns::V1::GSuiteAddOnsClient.project_path("[PROJECT]")

      # Create expected grpc response
      next_page_token = ""
      deployments_element = {}
      deployments = [deployments_element]
      expected_response = { next_page_token: next_page_token, deployments: deployments }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Gsuiteaddons::V1::ListDeploymentsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gsuiteaddons::V1::ListDeploymentsRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_deployments, mock_method)

      # Mock auth layer
      mock_credentials = MockGSuiteAddOnsCredentials_v1.new("list_deployments")

      Google::Cloud::Gsuiteaddons::V1::GSuiteAddOns::Stub.stub(:new, mock_stub) do
        Google::Cloud::GSuiteAddOns::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::GSuiteAddOns.new(version: :v1)

          # Call method
          response = client.list_deployments(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.deployments.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_deployments with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::GSuiteAddOns::V1::GSuiteAddOnsClient.project_path("[PROJECT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gsuiteaddons::V1::ListDeploymentsRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_deployments, mock_method)

      # Mock auth layer
      mock_credentials = MockGSuiteAddOnsCredentials_v1.new("list_deployments")

      Google::Cloud::Gsuiteaddons::V1::GSuiteAddOns::Stub.stub(:new, mock_stub) do
        Google::Cloud::GSuiteAddOns::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::GSuiteAddOns.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.list_deployments(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_deployment' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::GSuiteAddOns::V1::GSuiteAddOnsClient#delete_deployment."

    it 'invokes delete_deployment without error' do
      # Create request parameters
      formatted_name = Google::Cloud::GSuiteAddOns::V1::GSuiteAddOnsClient.deployment_path("[PROJECT]", "[DEPLOYMENT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gsuiteaddons::V1::DeleteDeploymentRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_deployment, mock_method)

      # Mock auth layer
      mock_credentials = MockGSuiteAddOnsCredentials_v1.new("delete_deployment")

      Google::Cloud::Gsuiteaddons::V1::GSuiteAddOns::Stub.stub(:new, mock_stub) do
        Google::Cloud::GSuiteAddOns::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::GSuiteAddOns.new(version: :v1)

          # Call method
          response = client.delete_deployment(formatted_name)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.delete_deployment(formatted_name) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes delete_deployment with error' do
      # Create request parameters
      formatted_name = Google::Cloud::GSuiteAddOns::V1::GSuiteAddOnsClient.deployment_path("[PROJECT]", "[DEPLOYMENT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gsuiteaddons::V1::DeleteDeploymentRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_deployment, mock_method)

      # Mock auth layer
      mock_credentials = MockGSuiteAddOnsCredentials_v1.new("delete_deployment")

      Google::Cloud::Gsuiteaddons::V1::GSuiteAddOns::Stub.stub(:new, mock_stub) do
        Google::Cloud::GSuiteAddOns::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::GSuiteAddOns.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.delete_deployment(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'install_deployment' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::GSuiteAddOns::V1::GSuiteAddOnsClient#install_deployment."

    it 'invokes install_deployment without error' do
      # Create request parameters
      formatted_name = Google::Cloud::GSuiteAddOns::V1::GSuiteAddOnsClient.deployment_path("[PROJECT]", "[DEPLOYMENT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gsuiteaddons::V1::InstallDeploymentRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v1.new(:install_deployment, mock_method)

      # Mock auth layer
      mock_credentials = MockGSuiteAddOnsCredentials_v1.new("install_deployment")

      Google::Cloud::Gsuiteaddons::V1::GSuiteAddOns::Stub.stub(:new, mock_stub) do
        Google::Cloud::GSuiteAddOns::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::GSuiteAddOns.new(version: :v1)

          # Call method
          response = client.install_deployment(formatted_name)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.install_deployment(formatted_name) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes install_deployment with error' do
      # Create request parameters
      formatted_name = Google::Cloud::GSuiteAddOns::V1::GSuiteAddOnsClient.deployment_path("[PROJECT]", "[DEPLOYMENT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gsuiteaddons::V1::InstallDeploymentRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:install_deployment, mock_method)

      # Mock auth layer
      mock_credentials = MockGSuiteAddOnsCredentials_v1.new("install_deployment")

      Google::Cloud::Gsuiteaddons::V1::GSuiteAddOns::Stub.stub(:new, mock_stub) do
        Google::Cloud::GSuiteAddOns::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::GSuiteAddOns.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.install_deployment(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'uninstall_deployment' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::GSuiteAddOns::V1::GSuiteAddOnsClient#uninstall_deployment."

    it 'invokes uninstall_deployment without error' do
      # Create request parameters
      formatted_name = Google::Cloud::GSuiteAddOns::V1::GSuiteAddOnsClient.deployment_path("[PROJECT]", "[DEPLOYMENT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gsuiteaddons::V1::UninstallDeploymentRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v1.new(:uninstall_deployment, mock_method)

      # Mock auth layer
      mock_credentials = MockGSuiteAddOnsCredentials_v1.new("uninstall_deployment")

      Google::Cloud::Gsuiteaddons::V1::GSuiteAddOns::Stub.stub(:new, mock_stub) do
        Google::Cloud::GSuiteAddOns::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::GSuiteAddOns.new(version: :v1)

          # Call method
          response = client.uninstall_deployment(formatted_name)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.uninstall_deployment(formatted_name) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes uninstall_deployment with error' do
      # Create request parameters
      formatted_name = Google::Cloud::GSuiteAddOns::V1::GSuiteAddOnsClient.deployment_path("[PROJECT]", "[DEPLOYMENT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gsuiteaddons::V1::UninstallDeploymentRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:uninstall_deployment, mock_method)

      # Mock auth layer
      mock_credentials = MockGSuiteAddOnsCredentials_v1.new("uninstall_deployment")

      Google::Cloud::Gsuiteaddons::V1::GSuiteAddOns::Stub.stub(:new, mock_stub) do
        Google::Cloud::GSuiteAddOns::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::GSuiteAddOns.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.uninstall_deployment(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_install_status' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::GSuiteAddOns::V1::GSuiteAddOnsClient#get_install_status."

    it 'invokes get_install_status without error' do
      # Create request parameters
      formatted_name = Google::Cloud::GSuiteAddOns::V1::GSuiteAddOnsClient.install_status_path("[PROJECT]", "[DEPLOYMENT]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      expected_response = { name: name_2 }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Gsuiteaddons::V1::InstallStatus)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gsuiteaddons::V1::GetInstallStatusRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_install_status, mock_method)

      # Mock auth layer
      mock_credentials = MockGSuiteAddOnsCredentials_v1.new("get_install_status")

      Google::Cloud::Gsuiteaddons::V1::GSuiteAddOns::Stub.stub(:new, mock_stub) do
        Google::Cloud::GSuiteAddOns::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::GSuiteAddOns.new(version: :v1)

          # Call method
          response = client.get_install_status(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_install_status(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_install_status with error' do
      # Create request parameters
      formatted_name = Google::Cloud::GSuiteAddOns::V1::GSuiteAddOnsClient.install_status_path("[PROJECT]", "[DEPLOYMENT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Gsuiteaddons::V1::GetInstallStatusRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_install_status, mock_method)

      # Mock auth layer
      mock_credentials = MockGSuiteAddOnsCredentials_v1.new("get_install_status")

      Google::Cloud::Gsuiteaddons::V1::GSuiteAddOns::Stub.stub(:new, mock_stub) do
        Google::Cloud::GSuiteAddOns::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::GSuiteAddOns.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.get_install_status(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end