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

require "google/home/enterprise/sdm"
require "google/home/enterprise/sdm/v1/smart_device_management_service_client"
require "google/home/enterprise/sdm/v1/smart_device_management_service_services_pb"

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

class MockSmartDeviceManagementServiceCredentials_v1 < Google::Home::Enterprise::Sdm::V1::Credentials
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

describe Google::Home::Enterprise::Sdm::V1::SmartDeviceManagementServiceClient do

  describe 'get_device' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Home::Enterprise::Sdm::V1::SmartDeviceManagementServiceClient#get_device."

    it 'invokes get_device without error' do
      # Create expected grpc response
      name = "name3373707"
      type = "type3575610"
      expected_response = { name: name, type: type }
      expected_response = Google::Gax::to_proto(expected_response, Google::Home::Enterprise::Sdm::V1::Device)

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_device, mock_method)

      # Mock auth layer
      mock_credentials = MockSmartDeviceManagementServiceCredentials_v1.new("get_device")

      Google::Home::Enterprise::Sdm::V1::SmartDeviceManagementService::Stub.stub(:new, mock_stub) do
        Google::Home::Enterprise::Sdm::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Home::Enterprise::Sdm.new(version: :v1)

          # Call method
          response = client.get_device

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_device do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_device with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_device, mock_method)

      # Mock auth layer
      mock_credentials = MockSmartDeviceManagementServiceCredentials_v1.new("get_device")

      Google::Home::Enterprise::Sdm::V1::SmartDeviceManagementService::Stub.stub(:new, mock_stub) do
        Google::Home::Enterprise::Sdm::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Home::Enterprise::Sdm.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.get_device
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_devices' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Home::Enterprise::Sdm::V1::SmartDeviceManagementServiceClient#list_devices."

    it 'invokes list_devices without error' do
      # Create expected grpc response
      next_page_token = ""
      devices_element = {}
      devices = [devices_element]
      expected_response = { next_page_token: next_page_token, devices: devices }
      expected_response = Google::Gax::to_proto(expected_response, Google::Home::Enterprise::Sdm::V1::ListDevicesResponse)

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_devices, mock_method)

      # Mock auth layer
      mock_credentials = MockSmartDeviceManagementServiceCredentials_v1.new("list_devices")

      Google::Home::Enterprise::Sdm::V1::SmartDeviceManagementService::Stub.stub(:new, mock_stub) do
        Google::Home::Enterprise::Sdm::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Home::Enterprise::Sdm.new(version: :v1)

          # Call method
          response = client.list_devices

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.devices.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_devices with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_devices, mock_method)

      # Mock auth layer
      mock_credentials = MockSmartDeviceManagementServiceCredentials_v1.new("list_devices")

      Google::Home::Enterprise::Sdm::V1::SmartDeviceManagementService::Stub.stub(:new, mock_stub) do
        Google::Home::Enterprise::Sdm::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Home::Enterprise::Sdm.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.list_devices
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'execute_device_command' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Home::Enterprise::Sdm::V1::SmartDeviceManagementServiceClient#execute_device_command."

    it 'invokes execute_device_command without error' do
      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Home::Enterprise::Sdm::V1::ExecuteDeviceCommandResponse)

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:execute_device_command, mock_method)

      # Mock auth layer
      mock_credentials = MockSmartDeviceManagementServiceCredentials_v1.new("execute_device_command")

      Google::Home::Enterprise::Sdm::V1::SmartDeviceManagementService::Stub.stub(:new, mock_stub) do
        Google::Home::Enterprise::Sdm::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Home::Enterprise::Sdm.new(version: :v1)

          # Call method
          response = client.execute_device_command

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.execute_device_command do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes execute_device_command with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:execute_device_command, mock_method)

      # Mock auth layer
      mock_credentials = MockSmartDeviceManagementServiceCredentials_v1.new("execute_device_command")

      Google::Home::Enterprise::Sdm::V1::SmartDeviceManagementService::Stub.stub(:new, mock_stub) do
        Google::Home::Enterprise::Sdm::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Home::Enterprise::Sdm.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.execute_device_command
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_structure' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Home::Enterprise::Sdm::V1::SmartDeviceManagementServiceClient#get_structure."

    it 'invokes get_structure without error' do
      # Create expected grpc response
      name = "name3373707"
      expected_response = { name: name }
      expected_response = Google::Gax::to_proto(expected_response, Google::Home::Enterprise::Sdm::V1::Structure)

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_structure, mock_method)

      # Mock auth layer
      mock_credentials = MockSmartDeviceManagementServiceCredentials_v1.new("get_structure")

      Google::Home::Enterprise::Sdm::V1::SmartDeviceManagementService::Stub.stub(:new, mock_stub) do
        Google::Home::Enterprise::Sdm::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Home::Enterprise::Sdm.new(version: :v1)

          # Call method
          response = client.get_structure

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_structure do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_structure with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_structure, mock_method)

      # Mock auth layer
      mock_credentials = MockSmartDeviceManagementServiceCredentials_v1.new("get_structure")

      Google::Home::Enterprise::Sdm::V1::SmartDeviceManagementService::Stub.stub(:new, mock_stub) do
        Google::Home::Enterprise::Sdm::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Home::Enterprise::Sdm.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.get_structure
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_structures' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Home::Enterprise::Sdm::V1::SmartDeviceManagementServiceClient#list_structures."

    it 'invokes list_structures without error' do
      # Create expected grpc response
      next_page_token = ""
      structures_element = {}
      structures = [structures_element]
      expected_response = { next_page_token: next_page_token, structures: structures }
      expected_response = Google::Gax::to_proto(expected_response, Google::Home::Enterprise::Sdm::V1::ListStructuresResponse)

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_structures, mock_method)

      # Mock auth layer
      mock_credentials = MockSmartDeviceManagementServiceCredentials_v1.new("list_structures")

      Google::Home::Enterprise::Sdm::V1::SmartDeviceManagementService::Stub.stub(:new, mock_stub) do
        Google::Home::Enterprise::Sdm::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Home::Enterprise::Sdm.new(version: :v1)

          # Call method
          response = client.list_structures

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.structures.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_structures with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_structures, mock_method)

      # Mock auth layer
      mock_credentials = MockSmartDeviceManagementServiceCredentials_v1.new("list_structures")

      Google::Home::Enterprise::Sdm::V1::SmartDeviceManagementService::Stub.stub(:new, mock_stub) do
        Google::Home::Enterprise::Sdm::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Home::Enterprise::Sdm.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.list_structures
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_room' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Home::Enterprise::Sdm::V1::SmartDeviceManagementServiceClient#get_room."

    it 'invokes get_room without error' do
      # Create expected grpc response
      name = "name3373707"
      expected_response = { name: name }
      expected_response = Google::Gax::to_proto(expected_response, Google::Home::Enterprise::Sdm::V1::Room)

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_room, mock_method)

      # Mock auth layer
      mock_credentials = MockSmartDeviceManagementServiceCredentials_v1.new("get_room")

      Google::Home::Enterprise::Sdm::V1::SmartDeviceManagementService::Stub.stub(:new, mock_stub) do
        Google::Home::Enterprise::Sdm::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Home::Enterprise::Sdm.new(version: :v1)

          # Call method
          response = client.get_room

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_room do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_room with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_room, mock_method)

      # Mock auth layer
      mock_credentials = MockSmartDeviceManagementServiceCredentials_v1.new("get_room")

      Google::Home::Enterprise::Sdm::V1::SmartDeviceManagementService::Stub.stub(:new, mock_stub) do
        Google::Home::Enterprise::Sdm::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Home::Enterprise::Sdm.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.get_room
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_rooms' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Home::Enterprise::Sdm::V1::SmartDeviceManagementServiceClient#list_rooms."

    it 'invokes list_rooms without error' do
      # Create expected grpc response
      next_page_token = ""
      rooms_element = {}
      rooms = [rooms_element]
      expected_response = { next_page_token: next_page_token, rooms: rooms }
      expected_response = Google::Gax::to_proto(expected_response, Google::Home::Enterprise::Sdm::V1::ListRoomsResponse)

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_rooms, mock_method)

      # Mock auth layer
      mock_credentials = MockSmartDeviceManagementServiceCredentials_v1.new("list_rooms")

      Google::Home::Enterprise::Sdm::V1::SmartDeviceManagementService::Stub.stub(:new, mock_stub) do
        Google::Home::Enterprise::Sdm::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Home::Enterprise::Sdm.new(version: :v1)

          # Call method
          response = client.list_rooms

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.rooms.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_rooms with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_rooms, mock_method)

      # Mock auth layer
      mock_credentials = MockSmartDeviceManagementServiceCredentials_v1.new("list_rooms")

      Google::Home::Enterprise::Sdm::V1::SmartDeviceManagementService::Stub.stub(:new, mock_stub) do
        Google::Home::Enterprise::Sdm::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Home::Enterprise::Sdm.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.list_rooms
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end