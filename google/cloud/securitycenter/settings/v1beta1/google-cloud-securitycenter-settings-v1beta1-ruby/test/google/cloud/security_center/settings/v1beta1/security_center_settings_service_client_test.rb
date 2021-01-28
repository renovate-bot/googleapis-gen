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

require "google/cloud/security_center/settings"
require "google/cloud/security_center/settings/v1beta1/security_center_settings_service_client"
require "google/cloud/securitycenter/settings/v1beta1/securitycenter_settings_service_services_pb"

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

class MockSecurityCenterSettingsServiceCredentials_v1beta1 < Google::Cloud::SecurityCenter::Settings::V1beta1::Credentials
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

describe Google::Cloud::SecurityCenter::Settings::V1beta1::SecurityCenterSettingsServiceClient do

  describe 'get_service_account' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::SecurityCenter::Settings::V1beta1::SecurityCenterSettingsServiceClient#get_service_account."

    it 'invokes get_service_account without error' do
      # Create request parameters
      formatted_name = Google::Cloud::SecurityCenter::Settings::V1beta1::SecurityCenterSettingsServiceClient.service_account_path("[ORGANIZATION]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      service_account = "serviceAccount-1948028253"
      expected_response = { name: name_2, service_account: service_account }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Securitycenter::Settings::V1beta1::ServiceAccount)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Securitycenter::Settings::V1beta1::GetServiceAccountRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:get_service_account, mock_method)

      # Mock auth layer
      mock_credentials = MockSecurityCenterSettingsServiceCredentials_v1beta1.new("get_service_account")

      Google::Cloud::Securitycenter::Settings::V1beta1::SecurityCenterSettingsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::SecurityCenter::Settings::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::SecurityCenter::Settings.new(version: :v1beta1)

          # Call method
          response = client.get_service_account(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_service_account(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_service_account with error' do
      # Create request parameters
      formatted_name = Google::Cloud::SecurityCenter::Settings::V1beta1::SecurityCenterSettingsServiceClient.service_account_path("[ORGANIZATION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Securitycenter::Settings::V1beta1::GetServiceAccountRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:get_service_account, mock_method)

      # Mock auth layer
      mock_credentials = MockSecurityCenterSettingsServiceCredentials_v1beta1.new("get_service_account")

      Google::Cloud::Securitycenter::Settings::V1beta1::SecurityCenterSettingsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::SecurityCenter::Settings::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::SecurityCenter::Settings.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.get_service_account(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_settings' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::SecurityCenter::Settings::V1beta1::SecurityCenterSettingsServiceClient#get_settings."

    it 'invokes get_settings without error' do
      # Create request parameters
      name = ''

      # Create expected grpc response
      name_2 = "name2-1052831874"
      org_service_account = "orgServiceAccount1798582088"
      etag = "etag3123477"
      expected_response = {
        name: name_2,
        org_service_account: org_service_account,
        etag: etag
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Securitycenter::Settings::V1beta1::Settings)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Securitycenter::Settings::V1beta1::GetSettingsRequest, request)
        assert_equal(name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:get_settings, mock_method)

      # Mock auth layer
      mock_credentials = MockSecurityCenterSettingsServiceCredentials_v1beta1.new("get_settings")

      Google::Cloud::Securitycenter::Settings::V1beta1::SecurityCenterSettingsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::SecurityCenter::Settings::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::SecurityCenter::Settings.new(version: :v1beta1)

          # Call method
          response = client.get_settings(name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_settings(name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_settings with error' do
      # Create request parameters
      name = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Securitycenter::Settings::V1beta1::GetSettingsRequest, request)
        assert_equal(name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:get_settings, mock_method)

      # Mock auth layer
      mock_credentials = MockSecurityCenterSettingsServiceCredentials_v1beta1.new("get_settings")

      Google::Cloud::Securitycenter::Settings::V1beta1::SecurityCenterSettingsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::SecurityCenter::Settings::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::SecurityCenter::Settings.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.get_settings(name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_settings' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::SecurityCenter::Settings::V1beta1::SecurityCenterSettingsServiceClient#update_settings."

    it 'invokes update_settings without error' do
      # Create request parameters
      settings = {}

      # Create expected grpc response
      name = "name3373707"
      org_service_account = "orgServiceAccount1798582088"
      etag = "etag3123477"
      expected_response = {
        name: name,
        org_service_account: org_service_account,
        etag: etag
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Securitycenter::Settings::V1beta1::Settings)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Securitycenter::Settings::V1beta1::UpdateSettingsRequest, request)
        assert_equal(Google::Gax::to_proto(settings, Google::Cloud::Securitycenter::Settings::V1beta1::Settings), request.settings)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:update_settings, mock_method)

      # Mock auth layer
      mock_credentials = MockSecurityCenterSettingsServiceCredentials_v1beta1.new("update_settings")

      Google::Cloud::Securitycenter::Settings::V1beta1::SecurityCenterSettingsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::SecurityCenter::Settings::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::SecurityCenter::Settings.new(version: :v1beta1)

          # Call method
          response = client.update_settings(settings)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.update_settings(settings) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes update_settings with error' do
      # Create request parameters
      settings = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Securitycenter::Settings::V1beta1::UpdateSettingsRequest, request)
        assert_equal(Google::Gax::to_proto(settings, Google::Cloud::Securitycenter::Settings::V1beta1::Settings), request.settings)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:update_settings, mock_method)

      # Mock auth layer
      mock_credentials = MockSecurityCenterSettingsServiceCredentials_v1beta1.new("update_settings")

      Google::Cloud::Securitycenter::Settings::V1beta1::SecurityCenterSettingsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::SecurityCenter::Settings::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::SecurityCenter::Settings.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.update_settings(settings)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'reset_settings' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::SecurityCenter::Settings::V1beta1::SecurityCenterSettingsServiceClient#reset_settings."

    it 'invokes reset_settings without error' do
      # Create request parameters
      name = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Securitycenter::Settings::V1beta1::ResetSettingsRequest, request)
        assert_equal(name, request.name)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:reset_settings, mock_method)

      # Mock auth layer
      mock_credentials = MockSecurityCenterSettingsServiceCredentials_v1beta1.new("reset_settings")

      Google::Cloud::Securitycenter::Settings::V1beta1::SecurityCenterSettingsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::SecurityCenter::Settings::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::SecurityCenter::Settings.new(version: :v1beta1)

          # Call method
          response = client.reset_settings(name)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.reset_settings(name) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes reset_settings with error' do
      # Create request parameters
      name = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Securitycenter::Settings::V1beta1::ResetSettingsRequest, request)
        assert_equal(name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:reset_settings, mock_method)

      # Mock auth layer
      mock_credentials = MockSecurityCenterSettingsServiceCredentials_v1beta1.new("reset_settings")

      Google::Cloud::Securitycenter::Settings::V1beta1::SecurityCenterSettingsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::SecurityCenter::Settings::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::SecurityCenter::Settings.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.reset_settings(name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'batch_get_settings' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::SecurityCenter::Settings::V1beta1::SecurityCenterSettingsServiceClient#batch_get_settings."

    it 'invokes batch_get_settings without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::SecurityCenter::Settings::V1beta1::SecurityCenterSettingsServiceClient.organization_path("[ORGANIZATION]")

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Securitycenter::Settings::V1beta1::BatchGetSettingsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Securitycenter::Settings::V1beta1::BatchGetSettingsRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:batch_get_settings, mock_method)

      # Mock auth layer
      mock_credentials = MockSecurityCenterSettingsServiceCredentials_v1beta1.new("batch_get_settings")

      Google::Cloud::Securitycenter::Settings::V1beta1::SecurityCenterSettingsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::SecurityCenter::Settings::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::SecurityCenter::Settings.new(version: :v1beta1)

          # Call method
          response = client.batch_get_settings(formatted_parent)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.batch_get_settings(formatted_parent) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes batch_get_settings with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::SecurityCenter::Settings::V1beta1::SecurityCenterSettingsServiceClient.organization_path("[ORGANIZATION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Securitycenter::Settings::V1beta1::BatchGetSettingsRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:batch_get_settings, mock_method)

      # Mock auth layer
      mock_credentials = MockSecurityCenterSettingsServiceCredentials_v1beta1.new("batch_get_settings")

      Google::Cloud::Securitycenter::Settings::V1beta1::SecurityCenterSettingsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::SecurityCenter::Settings::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::SecurityCenter::Settings.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.batch_get_settings(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'calculate_effective_settings' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::SecurityCenter::Settings::V1beta1::SecurityCenterSettingsServiceClient#calculate_effective_settings."

    it 'invokes calculate_effective_settings without error' do
      # Create request parameters
      name = ''

      # Create expected grpc response
      name_2 = "name2-1052831874"
      org_service_account = "orgServiceAccount1798582088"
      etag = "etag3123477"
      expected_response = {
        name: name_2,
        org_service_account: org_service_account,
        etag: etag
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Securitycenter::Settings::V1beta1::Settings)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Securitycenter::Settings::V1beta1::CalculateEffectiveSettingsRequest, request)
        assert_equal(name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:calculate_effective_settings, mock_method)

      # Mock auth layer
      mock_credentials = MockSecurityCenterSettingsServiceCredentials_v1beta1.new("calculate_effective_settings")

      Google::Cloud::Securitycenter::Settings::V1beta1::SecurityCenterSettingsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::SecurityCenter::Settings::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::SecurityCenter::Settings.new(version: :v1beta1)

          # Call method
          response = client.calculate_effective_settings(name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.calculate_effective_settings(name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes calculate_effective_settings with error' do
      # Create request parameters
      name = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Securitycenter::Settings::V1beta1::CalculateEffectiveSettingsRequest, request)
        assert_equal(name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:calculate_effective_settings, mock_method)

      # Mock auth layer
      mock_credentials = MockSecurityCenterSettingsServiceCredentials_v1beta1.new("calculate_effective_settings")

      Google::Cloud::Securitycenter::Settings::V1beta1::SecurityCenterSettingsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::SecurityCenter::Settings::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::SecurityCenter::Settings.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.calculate_effective_settings(name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'batch_calculate_effective_settings' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::SecurityCenter::Settings::V1beta1::SecurityCenterSettingsServiceClient#batch_calculate_effective_settings."

    it 'invokes batch_calculate_effective_settings without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::SecurityCenter::Settings::V1beta1::SecurityCenterSettingsServiceClient.organization_path("[ORGANIZATION]")

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Securitycenter::Settings::V1beta1::BatchCalculateEffectiveSettingsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Securitycenter::Settings::V1beta1::BatchCalculateEffectiveSettingsRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:batch_calculate_effective_settings, mock_method)

      # Mock auth layer
      mock_credentials = MockSecurityCenterSettingsServiceCredentials_v1beta1.new("batch_calculate_effective_settings")

      Google::Cloud::Securitycenter::Settings::V1beta1::SecurityCenterSettingsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::SecurityCenter::Settings::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::SecurityCenter::Settings.new(version: :v1beta1)

          # Call method
          response = client.batch_calculate_effective_settings(formatted_parent)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.batch_calculate_effective_settings(formatted_parent) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes batch_calculate_effective_settings with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::SecurityCenter::Settings::V1beta1::SecurityCenterSettingsServiceClient.organization_path("[ORGANIZATION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Securitycenter::Settings::V1beta1::BatchCalculateEffectiveSettingsRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:batch_calculate_effective_settings, mock_method)

      # Mock auth layer
      mock_credentials = MockSecurityCenterSettingsServiceCredentials_v1beta1.new("batch_calculate_effective_settings")

      Google::Cloud::Securitycenter::Settings::V1beta1::SecurityCenterSettingsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::SecurityCenter::Settings::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::SecurityCenter::Settings.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.batch_calculate_effective_settings(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_component_settings' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::SecurityCenter::Settings::V1beta1::SecurityCenterSettingsServiceClient#get_component_settings."

    it 'invokes get_component_settings without error' do
      # Create request parameters
      name = ''

      # Create expected grpc response
      name_2 = "name2-1052831874"
      project_service_account = "projectServiceAccount-1288322691"
      etag = "etag3123477"
      expected_response = {
        name: name_2,
        project_service_account: project_service_account,
        etag: etag
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Securitycenter::Settings::V1beta1::ComponentSettings)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Securitycenter::Settings::V1beta1::GetComponentSettingsRequest, request)
        assert_equal(name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:get_component_settings, mock_method)

      # Mock auth layer
      mock_credentials = MockSecurityCenterSettingsServiceCredentials_v1beta1.new("get_component_settings")

      Google::Cloud::Securitycenter::Settings::V1beta1::SecurityCenterSettingsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::SecurityCenter::Settings::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::SecurityCenter::Settings.new(version: :v1beta1)

          # Call method
          response = client.get_component_settings(name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_component_settings(name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_component_settings with error' do
      # Create request parameters
      name = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Securitycenter::Settings::V1beta1::GetComponentSettingsRequest, request)
        assert_equal(name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:get_component_settings, mock_method)

      # Mock auth layer
      mock_credentials = MockSecurityCenterSettingsServiceCredentials_v1beta1.new("get_component_settings")

      Google::Cloud::Securitycenter::Settings::V1beta1::SecurityCenterSettingsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::SecurityCenter::Settings::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::SecurityCenter::Settings.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.get_component_settings(name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_component_settings' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::SecurityCenter::Settings::V1beta1::SecurityCenterSettingsServiceClient#update_component_settings."

    it 'invokes update_component_settings without error' do
      # Create request parameters
      component_settings = {}

      # Create expected grpc response
      name = "name3373707"
      project_service_account = "projectServiceAccount-1288322691"
      etag = "etag3123477"
      expected_response = {
        name: name,
        project_service_account: project_service_account,
        etag: etag
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Securitycenter::Settings::V1beta1::ComponentSettings)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Securitycenter::Settings::V1beta1::UpdateComponentSettingsRequest, request)
        assert_equal(Google::Gax::to_proto(component_settings, Google::Cloud::Securitycenter::Settings::V1beta1::ComponentSettings), request.component_settings)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:update_component_settings, mock_method)

      # Mock auth layer
      mock_credentials = MockSecurityCenterSettingsServiceCredentials_v1beta1.new("update_component_settings")

      Google::Cloud::Securitycenter::Settings::V1beta1::SecurityCenterSettingsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::SecurityCenter::Settings::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::SecurityCenter::Settings.new(version: :v1beta1)

          # Call method
          response = client.update_component_settings(component_settings)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.update_component_settings(component_settings) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes update_component_settings with error' do
      # Create request parameters
      component_settings = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Securitycenter::Settings::V1beta1::UpdateComponentSettingsRequest, request)
        assert_equal(Google::Gax::to_proto(component_settings, Google::Cloud::Securitycenter::Settings::V1beta1::ComponentSettings), request.component_settings)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:update_component_settings, mock_method)

      # Mock auth layer
      mock_credentials = MockSecurityCenterSettingsServiceCredentials_v1beta1.new("update_component_settings")

      Google::Cloud::Securitycenter::Settings::V1beta1::SecurityCenterSettingsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::SecurityCenter::Settings::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::SecurityCenter::Settings.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.update_component_settings(component_settings)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'reset_component_settings' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::SecurityCenter::Settings::V1beta1::SecurityCenterSettingsServiceClient#reset_component_settings."

    it 'invokes reset_component_settings without error' do
      # Create request parameters
      name = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Securitycenter::Settings::V1beta1::ResetComponentSettingsRequest, request)
        assert_equal(name, request.name)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:reset_component_settings, mock_method)

      # Mock auth layer
      mock_credentials = MockSecurityCenterSettingsServiceCredentials_v1beta1.new("reset_component_settings")

      Google::Cloud::Securitycenter::Settings::V1beta1::SecurityCenterSettingsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::SecurityCenter::Settings::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::SecurityCenter::Settings.new(version: :v1beta1)

          # Call method
          response = client.reset_component_settings(name)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.reset_component_settings(name) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes reset_component_settings with error' do
      # Create request parameters
      name = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Securitycenter::Settings::V1beta1::ResetComponentSettingsRequest, request)
        assert_equal(name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:reset_component_settings, mock_method)

      # Mock auth layer
      mock_credentials = MockSecurityCenterSettingsServiceCredentials_v1beta1.new("reset_component_settings")

      Google::Cloud::Securitycenter::Settings::V1beta1::SecurityCenterSettingsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::SecurityCenter::Settings::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::SecurityCenter::Settings.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.reset_component_settings(name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'calculate_effective_component_settings' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::SecurityCenter::Settings::V1beta1::SecurityCenterSettingsServiceClient#calculate_effective_component_settings."

    it 'invokes calculate_effective_component_settings without error' do
      # Create request parameters
      name = ''

      # Create expected grpc response
      name_2 = "name2-1052831874"
      project_service_account = "projectServiceAccount-1288322691"
      etag = "etag3123477"
      expected_response = {
        name: name_2,
        project_service_account: project_service_account,
        etag: etag
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Securitycenter::Settings::V1beta1::ComponentSettings)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Securitycenter::Settings::V1beta1::CalculateEffectiveComponentSettingsRequest, request)
        assert_equal(name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:calculate_effective_component_settings, mock_method)

      # Mock auth layer
      mock_credentials = MockSecurityCenterSettingsServiceCredentials_v1beta1.new("calculate_effective_component_settings")

      Google::Cloud::Securitycenter::Settings::V1beta1::SecurityCenterSettingsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::SecurityCenter::Settings::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::SecurityCenter::Settings.new(version: :v1beta1)

          # Call method
          response = client.calculate_effective_component_settings(name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.calculate_effective_component_settings(name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes calculate_effective_component_settings with error' do
      # Create request parameters
      name = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Securitycenter::Settings::V1beta1::CalculateEffectiveComponentSettingsRequest, request)
        assert_equal(name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:calculate_effective_component_settings, mock_method)

      # Mock auth layer
      mock_credentials = MockSecurityCenterSettingsServiceCredentials_v1beta1.new("calculate_effective_component_settings")

      Google::Cloud::Securitycenter::Settings::V1beta1::SecurityCenterSettingsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::SecurityCenter::Settings::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::SecurityCenter::Settings.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.calculate_effective_component_settings(name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_detectors' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::SecurityCenter::Settings::V1beta1::SecurityCenterSettingsServiceClient#list_detectors."

    it 'invokes list_detectors without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::SecurityCenter::Settings::V1beta1::SecurityCenterSettingsServiceClient.organization_path("[ORGANIZATION]")

      # Create expected grpc response
      next_page_token = ""
      detectors_element = {}
      detectors = [detectors_element]
      expected_response = { next_page_token: next_page_token, detectors: detectors }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Securitycenter::Settings::V1beta1::ListDetectorsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Securitycenter::Settings::V1beta1::ListDetectorsRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:list_detectors, mock_method)

      # Mock auth layer
      mock_credentials = MockSecurityCenterSettingsServiceCredentials_v1beta1.new("list_detectors")

      Google::Cloud::Securitycenter::Settings::V1beta1::SecurityCenterSettingsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::SecurityCenter::Settings::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::SecurityCenter::Settings.new(version: :v1beta1)

          # Call method
          response = client.list_detectors(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.detectors.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_detectors with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::SecurityCenter::Settings::V1beta1::SecurityCenterSettingsServiceClient.organization_path("[ORGANIZATION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Securitycenter::Settings::V1beta1::ListDetectorsRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:list_detectors, mock_method)

      # Mock auth layer
      mock_credentials = MockSecurityCenterSettingsServiceCredentials_v1beta1.new("list_detectors")

      Google::Cloud::Securitycenter::Settings::V1beta1::SecurityCenterSettingsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::SecurityCenter::Settings::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::SecurityCenter::Settings.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.list_detectors(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_components' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::SecurityCenter::Settings::V1beta1::SecurityCenterSettingsServiceClient#list_components."

    it 'invokes list_components without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::SecurityCenter::Settings::V1beta1::SecurityCenterSettingsServiceClient.organization_path("[ORGANIZATION]")

      # Create expected grpc response
      next_page_token = ""
      components_element = "componentsElement1031131859"
      components = [components_element]
      expected_response = { next_page_token: next_page_token, components: components }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Securitycenter::Settings::V1beta1::ListComponentsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Securitycenter::Settings::V1beta1::ListComponentsRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:list_components, mock_method)

      # Mock auth layer
      mock_credentials = MockSecurityCenterSettingsServiceCredentials_v1beta1.new("list_components")

      Google::Cloud::Securitycenter::Settings::V1beta1::SecurityCenterSettingsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::SecurityCenter::Settings::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::SecurityCenter::Settings.new(version: :v1beta1)

          # Call method
          response = client.list_components(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.components.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_components with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::SecurityCenter::Settings::V1beta1::SecurityCenterSettingsServiceClient.organization_path("[ORGANIZATION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Securitycenter::Settings::V1beta1::ListComponentsRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:list_components, mock_method)

      # Mock auth layer
      mock_credentials = MockSecurityCenterSettingsServiceCredentials_v1beta1.new("list_components")

      Google::Cloud::Securitycenter::Settings::V1beta1::SecurityCenterSettingsService::Stub.stub(:new, mock_stub) do
        Google::Cloud::SecurityCenter::Settings::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::SecurityCenter::Settings.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.list_components(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end