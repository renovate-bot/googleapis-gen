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

require "google/cloud/managedidentities"
require "google/cloud/managedidentities/v1beta1/managed_identities_service_client"
require "google/cloud/managedidentities/v1beta1/managed_identities_service_services_pb"
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

class MockManagedIdentitiesServiceCredentials_v1beta1 < Google::Cloud::Managedidentities::V1beta1::Credentials
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

describe Google::Cloud::Managedidentities::V1beta1::ManagedIdentitiesServiceClient do

  describe 'delete_domain' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Managedidentities::V1beta1::ManagedIdentitiesServiceClient#delete_domain."

    it 'invokes delete_domain without error' do
      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Protobuf::Empty)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/delete_domain_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:delete_domain, mock_method)

      # Mock auth layer
      mock_credentials = MockManagedIdentitiesServiceCredentials_v1beta1.new("delete_domain")

      Google::Cloud::Managedidentities::V1beta1::ManagedIdentitiesService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Managedidentities::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Managedidentities.new(version: :v1beta1)

          # Call method
          response = client.delete_domain

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes delete_domain and returns an operation error.' do
      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Managedidentities::V1beta1::ManagedIdentitiesServiceClient#delete_domain.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/delete_domain_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:delete_domain, mock_method)

      # Mock auth layer
      mock_credentials = MockManagedIdentitiesServiceCredentials_v1beta1.new("delete_domain")

      Google::Cloud::Managedidentities::V1beta1::ManagedIdentitiesService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Managedidentities::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Managedidentities.new(version: :v1beta1)

          # Call method
          response = client.delete_domain

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes delete_domain with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:delete_domain, mock_method)

      # Mock auth layer
      mock_credentials = MockManagedIdentitiesServiceCredentials_v1beta1.new("delete_domain")

      Google::Cloud::Managedidentities::V1beta1::ManagedIdentitiesService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Managedidentities::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Managedidentities.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.delete_domain
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_microsoft_ad_domain' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Managedidentities::V1beta1::ManagedIdentitiesServiceClient#create_microsoft_ad_domain."

    it 'invokes create_microsoft_ad_domain without error' do
      # Create expected grpc response
      name = "name3373707"
      reserved_ip_range = "reservedIpRange-1082940580"
      admin = "admin92668751"
      fqdn = "fqdn3150485"
      status_message = "statusMessage-239442758"
      expected_response = {
        name: name,
        reserved_ip_range: reserved_ip_range,
        admin: admin,
        fqdn: fqdn,
        status_message: status_message
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Managedidentities::V1beta1::Domain)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/create_microsoft_ad_domain_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:create_microsoft_ad_domain, mock_method)

      # Mock auth layer
      mock_credentials = MockManagedIdentitiesServiceCredentials_v1beta1.new("create_microsoft_ad_domain")

      Google::Cloud::Managedidentities::V1beta1::ManagedIdentitiesService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Managedidentities::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Managedidentities.new(version: :v1beta1)

          # Call method
          response = client.create_microsoft_ad_domain

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes create_microsoft_ad_domain and returns an operation error.' do
      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Managedidentities::V1beta1::ManagedIdentitiesServiceClient#create_microsoft_ad_domain.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/create_microsoft_ad_domain_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:create_microsoft_ad_domain, mock_method)

      # Mock auth layer
      mock_credentials = MockManagedIdentitiesServiceCredentials_v1beta1.new("create_microsoft_ad_domain")

      Google::Cloud::Managedidentities::V1beta1::ManagedIdentitiesService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Managedidentities::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Managedidentities.new(version: :v1beta1)

          # Call method
          response = client.create_microsoft_ad_domain

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes create_microsoft_ad_domain with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:create_microsoft_ad_domain, mock_method)

      # Mock auth layer
      mock_credentials = MockManagedIdentitiesServiceCredentials_v1beta1.new("create_microsoft_ad_domain")

      Google::Cloud::Managedidentities::V1beta1::ManagedIdentitiesService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Managedidentities::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Managedidentities.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.create_microsoft_ad_domain
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'reset_admin_password' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Managedidentities::V1beta1::ManagedIdentitiesServiceClient#reset_admin_password."

    it 'invokes reset_admin_password without error' do
      # Create expected grpc response
      password = "password1216985755"
      expected_response = { password: password }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Managedidentities::V1beta1::ResetAdminPasswordResponse)

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:reset_admin_password, mock_method)

      # Mock auth layer
      mock_credentials = MockManagedIdentitiesServiceCredentials_v1beta1.new("reset_admin_password")

      Google::Cloud::Managedidentities::V1beta1::ManagedIdentitiesService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Managedidentities::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Managedidentities.new(version: :v1beta1)

          # Call method
          response = client.reset_admin_password

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.reset_admin_password do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes reset_admin_password with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:reset_admin_password, mock_method)

      # Mock auth layer
      mock_credentials = MockManagedIdentitiesServiceCredentials_v1beta1.new("reset_admin_password")

      Google::Cloud::Managedidentities::V1beta1::ManagedIdentitiesService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Managedidentities::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Managedidentities.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.reset_admin_password
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_domains' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Managedidentities::V1beta1::ManagedIdentitiesServiceClient#list_domains."

    it 'invokes list_domains without error' do
      # Create expected grpc response
      next_page_token = ""
      domains_element = {}
      domains = [domains_element]
      expected_response = { next_page_token: next_page_token, domains: domains }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Managedidentities::V1beta1::ListDomainsResponse)

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:list_domains, mock_method)

      # Mock auth layer
      mock_credentials = MockManagedIdentitiesServiceCredentials_v1beta1.new("list_domains")

      Google::Cloud::Managedidentities::V1beta1::ManagedIdentitiesService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Managedidentities::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Managedidentities.new(version: :v1beta1)

          # Call method
          response = client.list_domains

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.domains.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_domains with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:list_domains, mock_method)

      # Mock auth layer
      mock_credentials = MockManagedIdentitiesServiceCredentials_v1beta1.new("list_domains")

      Google::Cloud::Managedidentities::V1beta1::ManagedIdentitiesService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Managedidentities::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Managedidentities.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.list_domains
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_domain' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Managedidentities::V1beta1::ManagedIdentitiesServiceClient#get_domain."

    it 'invokes get_domain without error' do
      # Create expected grpc response
      name = "name3373707"
      reserved_ip_range = "reservedIpRange-1082940580"
      admin = "admin92668751"
      fqdn = "fqdn3150485"
      status_message = "statusMessage-239442758"
      expected_response = {
        name: name,
        reserved_ip_range: reserved_ip_range,
        admin: admin,
        fqdn: fqdn,
        status_message: status_message
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Managedidentities::V1beta1::Domain)

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:get_domain, mock_method)

      # Mock auth layer
      mock_credentials = MockManagedIdentitiesServiceCredentials_v1beta1.new("get_domain")

      Google::Cloud::Managedidentities::V1beta1::ManagedIdentitiesService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Managedidentities::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Managedidentities.new(version: :v1beta1)

          # Call method
          response = client.get_domain

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_domain do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_domain with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:get_domain, mock_method)

      # Mock auth layer
      mock_credentials = MockManagedIdentitiesServiceCredentials_v1beta1.new("get_domain")

      Google::Cloud::Managedidentities::V1beta1::ManagedIdentitiesService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Managedidentities::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Managedidentities.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.get_domain
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_domain' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Managedidentities::V1beta1::ManagedIdentitiesServiceClient#update_domain."

    it 'invokes update_domain without error' do
      # Create expected grpc response
      name = "name3373707"
      reserved_ip_range = "reservedIpRange-1082940580"
      admin = "admin92668751"
      fqdn = "fqdn3150485"
      status_message = "statusMessage-239442758"
      expected_response = {
        name: name,
        reserved_ip_range: reserved_ip_range,
        admin: admin,
        fqdn: fqdn,
        status_message: status_message
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Managedidentities::V1beta1::Domain)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/update_domain_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:update_domain, mock_method)

      # Mock auth layer
      mock_credentials = MockManagedIdentitiesServiceCredentials_v1beta1.new("update_domain")

      Google::Cloud::Managedidentities::V1beta1::ManagedIdentitiesService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Managedidentities::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Managedidentities.new(version: :v1beta1)

          # Call method
          response = client.update_domain

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes update_domain and returns an operation error.' do
      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Managedidentities::V1beta1::ManagedIdentitiesServiceClient#update_domain.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/update_domain_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:update_domain, mock_method)

      # Mock auth layer
      mock_credentials = MockManagedIdentitiesServiceCredentials_v1beta1.new("update_domain")

      Google::Cloud::Managedidentities::V1beta1::ManagedIdentitiesService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Managedidentities::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Managedidentities.new(version: :v1beta1)

          # Call method
          response = client.update_domain

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes update_domain with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:update_domain, mock_method)

      # Mock auth layer
      mock_credentials = MockManagedIdentitiesServiceCredentials_v1beta1.new("update_domain")

      Google::Cloud::Managedidentities::V1beta1::ManagedIdentitiesService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Managedidentities::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Managedidentities.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.update_domain
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'attach_trust' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Managedidentities::V1beta1::ManagedIdentitiesServiceClient#attach_trust."

    it 'invokes attach_trust without error' do
      # Create expected grpc response
      name = "name3373707"
      reserved_ip_range = "reservedIpRange-1082940580"
      admin = "admin92668751"
      fqdn = "fqdn3150485"
      status_message = "statusMessage-239442758"
      expected_response = {
        name: name,
        reserved_ip_range: reserved_ip_range,
        admin: admin,
        fqdn: fqdn,
        status_message: status_message
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Managedidentities::V1beta1::Domain)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/attach_trust_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:attach_trust, mock_method)

      # Mock auth layer
      mock_credentials = MockManagedIdentitiesServiceCredentials_v1beta1.new("attach_trust")

      Google::Cloud::Managedidentities::V1beta1::ManagedIdentitiesService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Managedidentities::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Managedidentities.new(version: :v1beta1)

          # Call method
          response = client.attach_trust

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes attach_trust and returns an operation error.' do
      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Managedidentities::V1beta1::ManagedIdentitiesServiceClient#attach_trust.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/attach_trust_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:attach_trust, mock_method)

      # Mock auth layer
      mock_credentials = MockManagedIdentitiesServiceCredentials_v1beta1.new("attach_trust")

      Google::Cloud::Managedidentities::V1beta1::ManagedIdentitiesService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Managedidentities::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Managedidentities.new(version: :v1beta1)

          # Call method
          response = client.attach_trust

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes attach_trust with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:attach_trust, mock_method)

      # Mock auth layer
      mock_credentials = MockManagedIdentitiesServiceCredentials_v1beta1.new("attach_trust")

      Google::Cloud::Managedidentities::V1beta1::ManagedIdentitiesService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Managedidentities::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Managedidentities.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.attach_trust
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'reconfigure_trust' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Managedidentities::V1beta1::ManagedIdentitiesServiceClient#reconfigure_trust."

    it 'invokes reconfigure_trust without error' do
      # Create expected grpc response
      name = "name3373707"
      reserved_ip_range = "reservedIpRange-1082940580"
      admin = "admin92668751"
      fqdn = "fqdn3150485"
      status_message = "statusMessage-239442758"
      expected_response = {
        name: name,
        reserved_ip_range: reserved_ip_range,
        admin: admin,
        fqdn: fqdn,
        status_message: status_message
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Managedidentities::V1beta1::Domain)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/reconfigure_trust_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:reconfigure_trust, mock_method)

      # Mock auth layer
      mock_credentials = MockManagedIdentitiesServiceCredentials_v1beta1.new("reconfigure_trust")

      Google::Cloud::Managedidentities::V1beta1::ManagedIdentitiesService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Managedidentities::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Managedidentities.new(version: :v1beta1)

          # Call method
          response = client.reconfigure_trust

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes reconfigure_trust and returns an operation error.' do
      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Managedidentities::V1beta1::ManagedIdentitiesServiceClient#reconfigure_trust.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/reconfigure_trust_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:reconfigure_trust, mock_method)

      # Mock auth layer
      mock_credentials = MockManagedIdentitiesServiceCredentials_v1beta1.new("reconfigure_trust")

      Google::Cloud::Managedidentities::V1beta1::ManagedIdentitiesService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Managedidentities::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Managedidentities.new(version: :v1beta1)

          # Call method
          response = client.reconfigure_trust

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes reconfigure_trust with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:reconfigure_trust, mock_method)

      # Mock auth layer
      mock_credentials = MockManagedIdentitiesServiceCredentials_v1beta1.new("reconfigure_trust")

      Google::Cloud::Managedidentities::V1beta1::ManagedIdentitiesService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Managedidentities::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Managedidentities.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.reconfigure_trust
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'detach_trust' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Managedidentities::V1beta1::ManagedIdentitiesServiceClient#detach_trust."

    it 'invokes detach_trust without error' do
      # Create expected grpc response
      name = "name3373707"
      reserved_ip_range = "reservedIpRange-1082940580"
      admin = "admin92668751"
      fqdn = "fqdn3150485"
      status_message = "statusMessage-239442758"
      expected_response = {
        name: name,
        reserved_ip_range: reserved_ip_range,
        admin: admin,
        fqdn: fqdn,
        status_message: status_message
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Managedidentities::V1beta1::Domain)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/detach_trust_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:detach_trust, mock_method)

      # Mock auth layer
      mock_credentials = MockManagedIdentitiesServiceCredentials_v1beta1.new("detach_trust")

      Google::Cloud::Managedidentities::V1beta1::ManagedIdentitiesService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Managedidentities::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Managedidentities.new(version: :v1beta1)

          # Call method
          response = client.detach_trust

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes detach_trust and returns an operation error.' do
      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Managedidentities::V1beta1::ManagedIdentitiesServiceClient#detach_trust.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/detach_trust_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:detach_trust, mock_method)

      # Mock auth layer
      mock_credentials = MockManagedIdentitiesServiceCredentials_v1beta1.new("detach_trust")

      Google::Cloud::Managedidentities::V1beta1::ManagedIdentitiesService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Managedidentities::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Managedidentities.new(version: :v1beta1)

          # Call method
          response = client.detach_trust

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes detach_trust with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:detach_trust, mock_method)

      # Mock auth layer
      mock_credentials = MockManagedIdentitiesServiceCredentials_v1beta1.new("detach_trust")

      Google::Cloud::Managedidentities::V1beta1::ManagedIdentitiesService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Managedidentities::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Managedidentities.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.detach_trust
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'validate_trust' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Managedidentities::V1beta1::ManagedIdentitiesServiceClient#validate_trust."

    it 'invokes validate_trust without error' do
      # Create expected grpc response
      name = "name3373707"
      reserved_ip_range = "reservedIpRange-1082940580"
      admin = "admin92668751"
      fqdn = "fqdn3150485"
      status_message = "statusMessage-239442758"
      expected_response = {
        name: name,
        reserved_ip_range: reserved_ip_range,
        admin: admin,
        fqdn: fqdn,
        status_message: status_message
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Managedidentities::V1beta1::Domain)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/validate_trust_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:validate_trust, mock_method)

      # Mock auth layer
      mock_credentials = MockManagedIdentitiesServiceCredentials_v1beta1.new("validate_trust")

      Google::Cloud::Managedidentities::V1beta1::ManagedIdentitiesService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Managedidentities::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Managedidentities.new(version: :v1beta1)

          # Call method
          response = client.validate_trust

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes validate_trust and returns an operation error.' do
      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Managedidentities::V1beta1::ManagedIdentitiesServiceClient#validate_trust.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/validate_trust_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:validate_trust, mock_method)

      # Mock auth layer
      mock_credentials = MockManagedIdentitiesServiceCredentials_v1beta1.new("validate_trust")

      Google::Cloud::Managedidentities::V1beta1::ManagedIdentitiesService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Managedidentities::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Managedidentities.new(version: :v1beta1)

          # Call method
          response = client.validate_trust

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes validate_trust with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:validate_trust, mock_method)

      # Mock auth layer
      mock_credentials = MockManagedIdentitiesServiceCredentials_v1beta1.new("validate_trust")

      Google::Cloud::Managedidentities::V1beta1::ManagedIdentitiesService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Managedidentities::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Managedidentities.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.validate_trust
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end