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

require "google/cloud/domains"
require "google/cloud/domains/v1alpha2/domains_client"
require "google/cloud/domains/v1alpha2/domains_services_pb"
require "google/longrunning/operations_pb"

class CustomTestError_v1alpha2 < StandardError; end

# Mock for the GRPC::ClientStub class.
class MockGrpcClientStub_v1alpha2

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

class MockDomainsCredentials_v1alpha2 < Google::Cloud::Domains::V1alpha2::Credentials
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

describe Google::Cloud::Domains::V1alpha2::DomainsClient do

  describe 'search_domains' do
    custom_error = CustomTestError_v1alpha2.new "Custom test error for Google::Cloud::Domains::V1alpha2::DomainsClient#search_domains."

    it 'invokes search_domains without error' do
      # Create request parameters
      query = ''
      formatted_location = Google::Cloud::Domains::V1alpha2::DomainsClient.location_path("[PROJECT]", "[LOCATION]")

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Domains::V1alpha2::SearchDomainsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Domains::V1alpha2::SearchDomainsRequest, request)
        assert_equal(query, request.query)
        assert_equal(formatted_location, request.location)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha2.new(:search_domains, mock_method)

      # Mock auth layer
      mock_credentials = MockDomainsCredentials_v1alpha2.new("search_domains")

      Google::Cloud::Domains::V1alpha2::Domains::Stub.stub(:new, mock_stub) do
        Google::Cloud::Domains::V1alpha2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Domains.new(version: :v1alpha2)

          # Call method
          response = client.search_domains(query, formatted_location)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.search_domains(query, formatted_location) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes search_domains with error' do
      # Create request parameters
      query = ''
      formatted_location = Google::Cloud::Domains::V1alpha2::DomainsClient.location_path("[PROJECT]", "[LOCATION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Domains::V1alpha2::SearchDomainsRequest, request)
        assert_equal(query, request.query)
        assert_equal(formatted_location, request.location)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha2.new(:search_domains, mock_method)

      # Mock auth layer
      mock_credentials = MockDomainsCredentials_v1alpha2.new("search_domains")

      Google::Cloud::Domains::V1alpha2::Domains::Stub.stub(:new, mock_stub) do
        Google::Cloud::Domains::V1alpha2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Domains.new(version: :v1alpha2)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha2 do
            client.search_domains(query, formatted_location)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'retrieve_register_parameters' do
    custom_error = CustomTestError_v1alpha2.new "Custom test error for Google::Cloud::Domains::V1alpha2::DomainsClient#retrieve_register_parameters."

    it 'invokes retrieve_register_parameters without error' do
      # Create request parameters
      domain_name = ''
      formatted_location = Google::Cloud::Domains::V1alpha2::DomainsClient.location_path("[PROJECT]", "[LOCATION]")

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Domains::V1alpha2::RetrieveRegisterParametersResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Domains::V1alpha2::RetrieveRegisterParametersRequest, request)
        assert_equal(domain_name, request.domain_name)
        assert_equal(formatted_location, request.location)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha2.new(:retrieve_register_parameters, mock_method)

      # Mock auth layer
      mock_credentials = MockDomainsCredentials_v1alpha2.new("retrieve_register_parameters")

      Google::Cloud::Domains::V1alpha2::Domains::Stub.stub(:new, mock_stub) do
        Google::Cloud::Domains::V1alpha2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Domains.new(version: :v1alpha2)

          # Call method
          response = client.retrieve_register_parameters(domain_name, formatted_location)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.retrieve_register_parameters(domain_name, formatted_location) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes retrieve_register_parameters with error' do
      # Create request parameters
      domain_name = ''
      formatted_location = Google::Cloud::Domains::V1alpha2::DomainsClient.location_path("[PROJECT]", "[LOCATION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Domains::V1alpha2::RetrieveRegisterParametersRequest, request)
        assert_equal(domain_name, request.domain_name)
        assert_equal(formatted_location, request.location)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha2.new(:retrieve_register_parameters, mock_method)

      # Mock auth layer
      mock_credentials = MockDomainsCredentials_v1alpha2.new("retrieve_register_parameters")

      Google::Cloud::Domains::V1alpha2::Domains::Stub.stub(:new, mock_stub) do
        Google::Cloud::Domains::V1alpha2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Domains.new(version: :v1alpha2)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha2 do
            client.retrieve_register_parameters(domain_name, formatted_location)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'register_domain' do
    custom_error = CustomTestError_v1alpha2.new "Custom test error for Google::Cloud::Domains::V1alpha2::DomainsClient#register_domain."

    it 'invokes register_domain without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Domains::V1alpha2::DomainsClient.location_path("[PROJECT]", "[LOCATION]")
      registration = {}
      yearly_price = {}

      # Create expected grpc response
      name = "name3373707"
      domain_name = "domainName104118566"
      expected_response = { name: name, domain_name: domain_name }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Domains::V1alpha2::Registration)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/register_domain_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Domains::V1alpha2::RegisterDomainRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(registration, Google::Cloud::Domains::V1alpha2::Registration), request.registration)
        assert_equal(Google::Gax::to_proto(yearly_price, Google::Type::Money), request.yearly_price)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1alpha2.new(:register_domain, mock_method)

      # Mock auth layer
      mock_credentials = MockDomainsCredentials_v1alpha2.new("register_domain")

      Google::Cloud::Domains::V1alpha2::Domains::Stub.stub(:new, mock_stub) do
        Google::Cloud::Domains::V1alpha2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Domains.new(version: :v1alpha2)

          # Call method
          response = client.register_domain(
            formatted_parent,
            registration,
            yearly_price
          )

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes register_domain and returns an operation error.' do
      # Create request parameters
      formatted_parent = Google::Cloud::Domains::V1alpha2::DomainsClient.location_path("[PROJECT]", "[LOCATION]")
      registration = {}
      yearly_price = {}

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Domains::V1alpha2::DomainsClient#register_domain.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/register_domain_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Domains::V1alpha2::RegisterDomainRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(registration, Google::Cloud::Domains::V1alpha2::Registration), request.registration)
        assert_equal(Google::Gax::to_proto(yearly_price, Google::Type::Money), request.yearly_price)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1alpha2.new(:register_domain, mock_method)

      # Mock auth layer
      mock_credentials = MockDomainsCredentials_v1alpha2.new("register_domain")

      Google::Cloud::Domains::V1alpha2::Domains::Stub.stub(:new, mock_stub) do
        Google::Cloud::Domains::V1alpha2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Domains.new(version: :v1alpha2)

          # Call method
          response = client.register_domain(
            formatted_parent,
            registration,
            yearly_price
          )

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes register_domain with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Domains::V1alpha2::DomainsClient.location_path("[PROJECT]", "[LOCATION]")
      registration = {}
      yearly_price = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Domains::V1alpha2::RegisterDomainRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(registration, Google::Cloud::Domains::V1alpha2::Registration), request.registration)
        assert_equal(Google::Gax::to_proto(yearly_price, Google::Type::Money), request.yearly_price)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha2.new(:register_domain, mock_method)

      # Mock auth layer
      mock_credentials = MockDomainsCredentials_v1alpha2.new("register_domain")

      Google::Cloud::Domains::V1alpha2::Domains::Stub.stub(:new, mock_stub) do
        Google::Cloud::Domains::V1alpha2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Domains.new(version: :v1alpha2)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha2 do
            client.register_domain(
              formatted_parent,
              registration,
              yearly_price
            )
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_registrations' do
    custom_error = CustomTestError_v1alpha2.new "Custom test error for Google::Cloud::Domains::V1alpha2::DomainsClient#list_registrations."

    it 'invokes list_registrations without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Domains::V1alpha2::DomainsClient.location_path("[PROJECT]", "[LOCATION]")

      # Create expected grpc response
      next_page_token = ""
      registrations_element = {}
      registrations = [registrations_element]
      expected_response = { next_page_token: next_page_token, registrations: registrations }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Domains::V1alpha2::ListRegistrationsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Domains::V1alpha2::ListRegistrationsRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha2.new(:list_registrations, mock_method)

      # Mock auth layer
      mock_credentials = MockDomainsCredentials_v1alpha2.new("list_registrations")

      Google::Cloud::Domains::V1alpha2::Domains::Stub.stub(:new, mock_stub) do
        Google::Cloud::Domains::V1alpha2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Domains.new(version: :v1alpha2)

          # Call method
          response = client.list_registrations(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.registrations.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_registrations with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Domains::V1alpha2::DomainsClient.location_path("[PROJECT]", "[LOCATION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Domains::V1alpha2::ListRegistrationsRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha2.new(:list_registrations, mock_method)

      # Mock auth layer
      mock_credentials = MockDomainsCredentials_v1alpha2.new("list_registrations")

      Google::Cloud::Domains::V1alpha2::Domains::Stub.stub(:new, mock_stub) do
        Google::Cloud::Domains::V1alpha2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Domains.new(version: :v1alpha2)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha2 do
            client.list_registrations(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_registration' do
    custom_error = CustomTestError_v1alpha2.new "Custom test error for Google::Cloud::Domains::V1alpha2::DomainsClient#get_registration."

    it 'invokes get_registration without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Domains::V1alpha2::DomainsClient.registration_path("[PROJECT]", "[LOCATION]", "[REGISTRATION]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      domain_name = "domainName104118566"
      expected_response = { name: name_2, domain_name: domain_name }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Domains::V1alpha2::Registration)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Domains::V1alpha2::GetRegistrationRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha2.new(:get_registration, mock_method)

      # Mock auth layer
      mock_credentials = MockDomainsCredentials_v1alpha2.new("get_registration")

      Google::Cloud::Domains::V1alpha2::Domains::Stub.stub(:new, mock_stub) do
        Google::Cloud::Domains::V1alpha2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Domains.new(version: :v1alpha2)

          # Call method
          response = client.get_registration(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_registration(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_registration with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Domains::V1alpha2::DomainsClient.registration_path("[PROJECT]", "[LOCATION]", "[REGISTRATION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Domains::V1alpha2::GetRegistrationRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha2.new(:get_registration, mock_method)

      # Mock auth layer
      mock_credentials = MockDomainsCredentials_v1alpha2.new("get_registration")

      Google::Cloud::Domains::V1alpha2::Domains::Stub.stub(:new, mock_stub) do
        Google::Cloud::Domains::V1alpha2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Domains.new(version: :v1alpha2)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha2 do
            client.get_registration(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_registration' do
    custom_error = CustomTestError_v1alpha2.new "Custom test error for Google::Cloud::Domains::V1alpha2::DomainsClient#update_registration."

    it 'invokes update_registration without error' do
      # Create request parameters
      update_mask = {}

      # Create expected grpc response
      name = "name3373707"
      domain_name = "domainName104118566"
      expected_response = { name: name, domain_name: domain_name }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Domains::V1alpha2::Registration)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/update_registration_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Domains::V1alpha2::UpdateRegistrationRequest, request)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1alpha2.new(:update_registration, mock_method)

      # Mock auth layer
      mock_credentials = MockDomainsCredentials_v1alpha2.new("update_registration")

      Google::Cloud::Domains::V1alpha2::Domains::Stub.stub(:new, mock_stub) do
        Google::Cloud::Domains::V1alpha2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Domains.new(version: :v1alpha2)

          # Call method
          response = client.update_registration(update_mask)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes update_registration and returns an operation error.' do
      # Create request parameters
      update_mask = {}

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Domains::V1alpha2::DomainsClient#update_registration.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/update_registration_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Domains::V1alpha2::UpdateRegistrationRequest, request)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1alpha2.new(:update_registration, mock_method)

      # Mock auth layer
      mock_credentials = MockDomainsCredentials_v1alpha2.new("update_registration")

      Google::Cloud::Domains::V1alpha2::Domains::Stub.stub(:new, mock_stub) do
        Google::Cloud::Domains::V1alpha2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Domains.new(version: :v1alpha2)

          # Call method
          response = client.update_registration(update_mask)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes update_registration with error' do
      # Create request parameters
      update_mask = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Domains::V1alpha2::UpdateRegistrationRequest, request)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha2.new(:update_registration, mock_method)

      # Mock auth layer
      mock_credentials = MockDomainsCredentials_v1alpha2.new("update_registration")

      Google::Cloud::Domains::V1alpha2::Domains::Stub.stub(:new, mock_stub) do
        Google::Cloud::Domains::V1alpha2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Domains.new(version: :v1alpha2)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha2 do
            client.update_registration(update_mask)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'configure_management_settings' do
    custom_error = CustomTestError_v1alpha2.new "Custom test error for Google::Cloud::Domains::V1alpha2::DomainsClient#configure_management_settings."

    it 'invokes configure_management_settings without error' do
      # Create request parameters
      formatted_registration = Google::Cloud::Domains::V1alpha2::DomainsClient.registration_path("[PROJECT]", "[LOCATION]", "[REGISTRATION]")
      update_mask = {}

      # Create expected grpc response
      name = "name3373707"
      domain_name = "domainName104118566"
      expected_response = { name: name, domain_name: domain_name }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Domains::V1alpha2::Registration)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/configure_management_settings_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Domains::V1alpha2::ConfigureManagementSettingsRequest, request)
        assert_equal(formatted_registration, request.registration)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1alpha2.new(:configure_management_settings, mock_method)

      # Mock auth layer
      mock_credentials = MockDomainsCredentials_v1alpha2.new("configure_management_settings")

      Google::Cloud::Domains::V1alpha2::Domains::Stub.stub(:new, mock_stub) do
        Google::Cloud::Domains::V1alpha2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Domains.new(version: :v1alpha2)

          # Call method
          response = client.configure_management_settings(formatted_registration, update_mask)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes configure_management_settings and returns an operation error.' do
      # Create request parameters
      formatted_registration = Google::Cloud::Domains::V1alpha2::DomainsClient.registration_path("[PROJECT]", "[LOCATION]", "[REGISTRATION]")
      update_mask = {}

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Domains::V1alpha2::DomainsClient#configure_management_settings.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/configure_management_settings_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Domains::V1alpha2::ConfigureManagementSettingsRequest, request)
        assert_equal(formatted_registration, request.registration)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1alpha2.new(:configure_management_settings, mock_method)

      # Mock auth layer
      mock_credentials = MockDomainsCredentials_v1alpha2.new("configure_management_settings")

      Google::Cloud::Domains::V1alpha2::Domains::Stub.stub(:new, mock_stub) do
        Google::Cloud::Domains::V1alpha2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Domains.new(version: :v1alpha2)

          # Call method
          response = client.configure_management_settings(formatted_registration, update_mask)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes configure_management_settings with error' do
      # Create request parameters
      formatted_registration = Google::Cloud::Domains::V1alpha2::DomainsClient.registration_path("[PROJECT]", "[LOCATION]", "[REGISTRATION]")
      update_mask = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Domains::V1alpha2::ConfigureManagementSettingsRequest, request)
        assert_equal(formatted_registration, request.registration)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha2.new(:configure_management_settings, mock_method)

      # Mock auth layer
      mock_credentials = MockDomainsCredentials_v1alpha2.new("configure_management_settings")

      Google::Cloud::Domains::V1alpha2::Domains::Stub.stub(:new, mock_stub) do
        Google::Cloud::Domains::V1alpha2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Domains.new(version: :v1alpha2)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha2 do
            client.configure_management_settings(formatted_registration, update_mask)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'configure_dns_settings' do
    custom_error = CustomTestError_v1alpha2.new "Custom test error for Google::Cloud::Domains::V1alpha2::DomainsClient#configure_dns_settings."

    it 'invokes configure_dns_settings without error' do
      # Create request parameters
      formatted_registration = Google::Cloud::Domains::V1alpha2::DomainsClient.registration_path("[PROJECT]", "[LOCATION]", "[REGISTRATION]")
      update_mask = {}

      # Create expected grpc response
      name = "name3373707"
      domain_name = "domainName104118566"
      expected_response = { name: name, domain_name: domain_name }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Domains::V1alpha2::Registration)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/configure_dns_settings_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Domains::V1alpha2::ConfigureDnsSettingsRequest, request)
        assert_equal(formatted_registration, request.registration)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1alpha2.new(:configure_dns_settings, mock_method)

      # Mock auth layer
      mock_credentials = MockDomainsCredentials_v1alpha2.new("configure_dns_settings")

      Google::Cloud::Domains::V1alpha2::Domains::Stub.stub(:new, mock_stub) do
        Google::Cloud::Domains::V1alpha2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Domains.new(version: :v1alpha2)

          # Call method
          response = client.configure_dns_settings(formatted_registration, update_mask)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes configure_dns_settings and returns an operation error.' do
      # Create request parameters
      formatted_registration = Google::Cloud::Domains::V1alpha2::DomainsClient.registration_path("[PROJECT]", "[LOCATION]", "[REGISTRATION]")
      update_mask = {}

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Domains::V1alpha2::DomainsClient#configure_dns_settings.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/configure_dns_settings_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Domains::V1alpha2::ConfigureDnsSettingsRequest, request)
        assert_equal(formatted_registration, request.registration)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1alpha2.new(:configure_dns_settings, mock_method)

      # Mock auth layer
      mock_credentials = MockDomainsCredentials_v1alpha2.new("configure_dns_settings")

      Google::Cloud::Domains::V1alpha2::Domains::Stub.stub(:new, mock_stub) do
        Google::Cloud::Domains::V1alpha2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Domains.new(version: :v1alpha2)

          # Call method
          response = client.configure_dns_settings(formatted_registration, update_mask)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes configure_dns_settings with error' do
      # Create request parameters
      formatted_registration = Google::Cloud::Domains::V1alpha2::DomainsClient.registration_path("[PROJECT]", "[LOCATION]", "[REGISTRATION]")
      update_mask = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Domains::V1alpha2::ConfigureDnsSettingsRequest, request)
        assert_equal(formatted_registration, request.registration)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha2.new(:configure_dns_settings, mock_method)

      # Mock auth layer
      mock_credentials = MockDomainsCredentials_v1alpha2.new("configure_dns_settings")

      Google::Cloud::Domains::V1alpha2::Domains::Stub.stub(:new, mock_stub) do
        Google::Cloud::Domains::V1alpha2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Domains.new(version: :v1alpha2)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha2 do
            client.configure_dns_settings(formatted_registration, update_mask)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'configure_contact_settings' do
    custom_error = CustomTestError_v1alpha2.new "Custom test error for Google::Cloud::Domains::V1alpha2::DomainsClient#configure_contact_settings."

    it 'invokes configure_contact_settings without error' do
      # Create request parameters
      formatted_registration = Google::Cloud::Domains::V1alpha2::DomainsClient.registration_path("[PROJECT]", "[LOCATION]", "[REGISTRATION]")
      update_mask = {}

      # Create expected grpc response
      name = "name3373707"
      domain_name = "domainName104118566"
      expected_response = { name: name, domain_name: domain_name }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Domains::V1alpha2::Registration)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/configure_contact_settings_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Domains::V1alpha2::ConfigureContactSettingsRequest, request)
        assert_equal(formatted_registration, request.registration)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1alpha2.new(:configure_contact_settings, mock_method)

      # Mock auth layer
      mock_credentials = MockDomainsCredentials_v1alpha2.new("configure_contact_settings")

      Google::Cloud::Domains::V1alpha2::Domains::Stub.stub(:new, mock_stub) do
        Google::Cloud::Domains::V1alpha2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Domains.new(version: :v1alpha2)

          # Call method
          response = client.configure_contact_settings(formatted_registration, update_mask)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes configure_contact_settings and returns an operation error.' do
      # Create request parameters
      formatted_registration = Google::Cloud::Domains::V1alpha2::DomainsClient.registration_path("[PROJECT]", "[LOCATION]", "[REGISTRATION]")
      update_mask = {}

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Domains::V1alpha2::DomainsClient#configure_contact_settings.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/configure_contact_settings_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Domains::V1alpha2::ConfigureContactSettingsRequest, request)
        assert_equal(formatted_registration, request.registration)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1alpha2.new(:configure_contact_settings, mock_method)

      # Mock auth layer
      mock_credentials = MockDomainsCredentials_v1alpha2.new("configure_contact_settings")

      Google::Cloud::Domains::V1alpha2::Domains::Stub.stub(:new, mock_stub) do
        Google::Cloud::Domains::V1alpha2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Domains.new(version: :v1alpha2)

          # Call method
          response = client.configure_contact_settings(formatted_registration, update_mask)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes configure_contact_settings with error' do
      # Create request parameters
      formatted_registration = Google::Cloud::Domains::V1alpha2::DomainsClient.registration_path("[PROJECT]", "[LOCATION]", "[REGISTRATION]")
      update_mask = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Domains::V1alpha2::ConfigureContactSettingsRequest, request)
        assert_equal(formatted_registration, request.registration)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha2.new(:configure_contact_settings, mock_method)

      # Mock auth layer
      mock_credentials = MockDomainsCredentials_v1alpha2.new("configure_contact_settings")

      Google::Cloud::Domains::V1alpha2::Domains::Stub.stub(:new, mock_stub) do
        Google::Cloud::Domains::V1alpha2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Domains.new(version: :v1alpha2)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha2 do
            client.configure_contact_settings(formatted_registration, update_mask)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'export_registration' do
    custom_error = CustomTestError_v1alpha2.new "Custom test error for Google::Cloud::Domains::V1alpha2::DomainsClient#export_registration."

    it 'invokes export_registration without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Domains::V1alpha2::DomainsClient.registration_path("[PROJECT]", "[LOCATION]", "[REGISTRATION]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      domain_name = "domainName104118566"
      expected_response = { name: name_2, domain_name: domain_name }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Domains::V1alpha2::Registration)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/export_registration_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Domains::V1alpha2::ExportRegistrationRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1alpha2.new(:export_registration, mock_method)

      # Mock auth layer
      mock_credentials = MockDomainsCredentials_v1alpha2.new("export_registration")

      Google::Cloud::Domains::V1alpha2::Domains::Stub.stub(:new, mock_stub) do
        Google::Cloud::Domains::V1alpha2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Domains.new(version: :v1alpha2)

          # Call method
          response = client.export_registration(formatted_name)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes export_registration and returns an operation error.' do
      # Create request parameters
      formatted_name = Google::Cloud::Domains::V1alpha2::DomainsClient.registration_path("[PROJECT]", "[LOCATION]", "[REGISTRATION]")

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Domains::V1alpha2::DomainsClient#export_registration.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/export_registration_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Domains::V1alpha2::ExportRegistrationRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1alpha2.new(:export_registration, mock_method)

      # Mock auth layer
      mock_credentials = MockDomainsCredentials_v1alpha2.new("export_registration")

      Google::Cloud::Domains::V1alpha2::Domains::Stub.stub(:new, mock_stub) do
        Google::Cloud::Domains::V1alpha2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Domains.new(version: :v1alpha2)

          # Call method
          response = client.export_registration(formatted_name)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes export_registration with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Domains::V1alpha2::DomainsClient.registration_path("[PROJECT]", "[LOCATION]", "[REGISTRATION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Domains::V1alpha2::ExportRegistrationRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha2.new(:export_registration, mock_method)

      # Mock auth layer
      mock_credentials = MockDomainsCredentials_v1alpha2.new("export_registration")

      Google::Cloud::Domains::V1alpha2::Domains::Stub.stub(:new, mock_stub) do
        Google::Cloud::Domains::V1alpha2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Domains.new(version: :v1alpha2)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha2 do
            client.export_registration(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_registration' do
    custom_error = CustomTestError_v1alpha2.new "Custom test error for Google::Cloud::Domains::V1alpha2::DomainsClient#delete_registration."

    it 'invokes delete_registration without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Domains::V1alpha2::DomainsClient.registration_path("[PROJECT]", "[LOCATION]", "[REGISTRATION]")

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Protobuf::Empty)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/delete_registration_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Domains::V1alpha2::DeleteRegistrationRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1alpha2.new(:delete_registration, mock_method)

      # Mock auth layer
      mock_credentials = MockDomainsCredentials_v1alpha2.new("delete_registration")

      Google::Cloud::Domains::V1alpha2::Domains::Stub.stub(:new, mock_stub) do
        Google::Cloud::Domains::V1alpha2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Domains.new(version: :v1alpha2)

          # Call method
          response = client.delete_registration(formatted_name)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes delete_registration and returns an operation error.' do
      # Create request parameters
      formatted_name = Google::Cloud::Domains::V1alpha2::DomainsClient.registration_path("[PROJECT]", "[LOCATION]", "[REGISTRATION]")

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Domains::V1alpha2::DomainsClient#delete_registration.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/delete_registration_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Domains::V1alpha2::DeleteRegistrationRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v1alpha2.new(:delete_registration, mock_method)

      # Mock auth layer
      mock_credentials = MockDomainsCredentials_v1alpha2.new("delete_registration")

      Google::Cloud::Domains::V1alpha2::Domains::Stub.stub(:new, mock_stub) do
        Google::Cloud::Domains::V1alpha2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Domains.new(version: :v1alpha2)

          # Call method
          response = client.delete_registration(formatted_name)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes delete_registration with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Domains::V1alpha2::DomainsClient.registration_path("[PROJECT]", "[LOCATION]", "[REGISTRATION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Domains::V1alpha2::DeleteRegistrationRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha2.new(:delete_registration, mock_method)

      # Mock auth layer
      mock_credentials = MockDomainsCredentials_v1alpha2.new("delete_registration")

      Google::Cloud::Domains::V1alpha2::Domains::Stub.stub(:new, mock_stub) do
        Google::Cloud::Domains::V1alpha2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Domains.new(version: :v1alpha2)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha2 do
            client.delete_registration(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'retrieve_authorization_code' do
    custom_error = CustomTestError_v1alpha2.new "Custom test error for Google::Cloud::Domains::V1alpha2::DomainsClient#retrieve_authorization_code."

    it 'invokes retrieve_authorization_code without error' do
      # Create request parameters
      formatted_registration = Google::Cloud::Domains::V1alpha2::DomainsClient.registration_path("[PROJECT]", "[LOCATION]", "[REGISTRATION]")

      # Create expected grpc response
      code = "code3059181"
      expected_response = { code: code }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Domains::V1alpha2::AuthorizationCode)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Domains::V1alpha2::RetrieveAuthorizationCodeRequest, request)
        assert_equal(formatted_registration, request.registration)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha2.new(:retrieve_authorization_code, mock_method)

      # Mock auth layer
      mock_credentials = MockDomainsCredentials_v1alpha2.new("retrieve_authorization_code")

      Google::Cloud::Domains::V1alpha2::Domains::Stub.stub(:new, mock_stub) do
        Google::Cloud::Domains::V1alpha2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Domains.new(version: :v1alpha2)

          # Call method
          response = client.retrieve_authorization_code(formatted_registration)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.retrieve_authorization_code(formatted_registration) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes retrieve_authorization_code with error' do
      # Create request parameters
      formatted_registration = Google::Cloud::Domains::V1alpha2::DomainsClient.registration_path("[PROJECT]", "[LOCATION]", "[REGISTRATION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Domains::V1alpha2::RetrieveAuthorizationCodeRequest, request)
        assert_equal(formatted_registration, request.registration)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha2.new(:retrieve_authorization_code, mock_method)

      # Mock auth layer
      mock_credentials = MockDomainsCredentials_v1alpha2.new("retrieve_authorization_code")

      Google::Cloud::Domains::V1alpha2::Domains::Stub.stub(:new, mock_stub) do
        Google::Cloud::Domains::V1alpha2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Domains.new(version: :v1alpha2)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha2 do
            client.retrieve_authorization_code(formatted_registration)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'reset_authorization_code' do
    custom_error = CustomTestError_v1alpha2.new "Custom test error for Google::Cloud::Domains::V1alpha2::DomainsClient#reset_authorization_code."

    it 'invokes reset_authorization_code without error' do
      # Create request parameters
      formatted_registration = Google::Cloud::Domains::V1alpha2::DomainsClient.registration_path("[PROJECT]", "[LOCATION]", "[REGISTRATION]")

      # Create expected grpc response
      code = "code3059181"
      expected_response = { code: code }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Domains::V1alpha2::AuthorizationCode)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Domains::V1alpha2::ResetAuthorizationCodeRequest, request)
        assert_equal(formatted_registration, request.registration)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1alpha2.new(:reset_authorization_code, mock_method)

      # Mock auth layer
      mock_credentials = MockDomainsCredentials_v1alpha2.new("reset_authorization_code")

      Google::Cloud::Domains::V1alpha2::Domains::Stub.stub(:new, mock_stub) do
        Google::Cloud::Domains::V1alpha2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Domains.new(version: :v1alpha2)

          # Call method
          response = client.reset_authorization_code(formatted_registration)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.reset_authorization_code(formatted_registration) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes reset_authorization_code with error' do
      # Create request parameters
      formatted_registration = Google::Cloud::Domains::V1alpha2::DomainsClient.registration_path("[PROJECT]", "[LOCATION]", "[REGISTRATION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Domains::V1alpha2::ResetAuthorizationCodeRequest, request)
        assert_equal(formatted_registration, request.registration)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1alpha2.new(:reset_authorization_code, mock_method)

      # Mock auth layer
      mock_credentials = MockDomainsCredentials_v1alpha2.new("reset_authorization_code")

      Google::Cloud::Domains::V1alpha2::Domains::Stub.stub(:new, mock_stub) do
        Google::Cloud::Domains::V1alpha2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Domains.new(version: :v1alpha2)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1alpha2 do
            client.reset_authorization_code(formatted_registration)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end