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

require "google/cloud/bigquery/reservation"
require "google/cloud/bigquery/reservation/v1beta1/reservation_service_client"
require "google/cloud/bigquery/reservation/v1beta1/reservation_services_pb"

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

class MockReservationServiceCredentials_v1beta1 < Google::Cloud::Bigquery::Reservation::V1beta1::Credentials
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

describe Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient do

  describe 'create_reservation' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient#create_reservation."

    it 'invokes create_reservation without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient.location_path("[PROJECT]", "[LOCATION]")

      # Create expected grpc response
      name = "name3373707"
      slot_capacity = 1516717605
      ignore_idle_slots = false
      expected_response = {
        name: name,
        slot_capacity: slot_capacity,
        ignore_idle_slots: ignore_idle_slots
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Bigquery::Reservation::V1beta1::Reservation)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Bigquery::Reservation::V1beta1::CreateReservationRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:create_reservation, mock_method)

      # Mock auth layer
      mock_credentials = MockReservationServiceCredentials_v1beta1.new("create_reservation")

      Google::Cloud::Bigquery::Reservation::V1beta1::ReservationService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Reservation::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Reservation.new(version: :v1beta1)

          # Call method
          response = client.create_reservation(formatted_parent)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_reservation(formatted_parent) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_reservation with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient.location_path("[PROJECT]", "[LOCATION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Bigquery::Reservation::V1beta1::CreateReservationRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:create_reservation, mock_method)

      # Mock auth layer
      mock_credentials = MockReservationServiceCredentials_v1beta1.new("create_reservation")

      Google::Cloud::Bigquery::Reservation::V1beta1::ReservationService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Reservation::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Reservation.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.create_reservation(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_reservations' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient#list_reservations."

    it 'invokes list_reservations without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient.location_path("[PROJECT]", "[LOCATION]")

      # Create expected grpc response
      next_page_token = ""
      reservations_element = {}
      reservations = [reservations_element]
      expected_response = { next_page_token: next_page_token, reservations: reservations }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Bigquery::Reservation::V1beta1::ListReservationsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Bigquery::Reservation::V1beta1::ListReservationsRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:list_reservations, mock_method)

      # Mock auth layer
      mock_credentials = MockReservationServiceCredentials_v1beta1.new("list_reservations")

      Google::Cloud::Bigquery::Reservation::V1beta1::ReservationService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Reservation::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Reservation.new(version: :v1beta1)

          # Call method
          response = client.list_reservations(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.reservations.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_reservations with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient.location_path("[PROJECT]", "[LOCATION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Bigquery::Reservation::V1beta1::ListReservationsRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:list_reservations, mock_method)

      # Mock auth layer
      mock_credentials = MockReservationServiceCredentials_v1beta1.new("list_reservations")

      Google::Cloud::Bigquery::Reservation::V1beta1::ReservationService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Reservation::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Reservation.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.list_reservations(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_reservation' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient#get_reservation."

    it 'invokes get_reservation without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient.reservation_path("[PROJECT]", "[LOCATION]", "[RESERVATION]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      slot_capacity = 1516717605
      ignore_idle_slots = false
      expected_response = {
        name: name_2,
        slot_capacity: slot_capacity,
        ignore_idle_slots: ignore_idle_slots
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Bigquery::Reservation::V1beta1::Reservation)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Bigquery::Reservation::V1beta1::GetReservationRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:get_reservation, mock_method)

      # Mock auth layer
      mock_credentials = MockReservationServiceCredentials_v1beta1.new("get_reservation")

      Google::Cloud::Bigquery::Reservation::V1beta1::ReservationService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Reservation::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Reservation.new(version: :v1beta1)

          # Call method
          response = client.get_reservation(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_reservation(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_reservation with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient.reservation_path("[PROJECT]", "[LOCATION]", "[RESERVATION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Bigquery::Reservation::V1beta1::GetReservationRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:get_reservation, mock_method)

      # Mock auth layer
      mock_credentials = MockReservationServiceCredentials_v1beta1.new("get_reservation")

      Google::Cloud::Bigquery::Reservation::V1beta1::ReservationService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Reservation::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Reservation.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.get_reservation(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_reservation' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient#delete_reservation."

    it 'invokes delete_reservation without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient.reservation_path("[PROJECT]", "[LOCATION]", "[RESERVATION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Bigquery::Reservation::V1beta1::DeleteReservationRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:delete_reservation, mock_method)

      # Mock auth layer
      mock_credentials = MockReservationServiceCredentials_v1beta1.new("delete_reservation")

      Google::Cloud::Bigquery::Reservation::V1beta1::ReservationService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Reservation::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Reservation.new(version: :v1beta1)

          # Call method
          response = client.delete_reservation(formatted_name)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.delete_reservation(formatted_name) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes delete_reservation with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient.reservation_path("[PROJECT]", "[LOCATION]", "[RESERVATION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Bigquery::Reservation::V1beta1::DeleteReservationRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:delete_reservation, mock_method)

      # Mock auth layer
      mock_credentials = MockReservationServiceCredentials_v1beta1.new("delete_reservation")

      Google::Cloud::Bigquery::Reservation::V1beta1::ReservationService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Reservation::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Reservation.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.delete_reservation(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_reservation' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient#update_reservation."

    it 'invokes update_reservation without error' do
      # Create expected grpc response
      name = "name3373707"
      slot_capacity = 1516717605
      ignore_idle_slots = false
      expected_response = {
        name: name,
        slot_capacity: slot_capacity,
        ignore_idle_slots: ignore_idle_slots
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Bigquery::Reservation::V1beta1::Reservation)

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:update_reservation, mock_method)

      # Mock auth layer
      mock_credentials = MockReservationServiceCredentials_v1beta1.new("update_reservation")

      Google::Cloud::Bigquery::Reservation::V1beta1::ReservationService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Reservation::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Reservation.new(version: :v1beta1)

          # Call method
          response = client.update_reservation

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.update_reservation do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes update_reservation with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:update_reservation, mock_method)

      # Mock auth layer
      mock_credentials = MockReservationServiceCredentials_v1beta1.new("update_reservation")

      Google::Cloud::Bigquery::Reservation::V1beta1::ReservationService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Reservation::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Reservation.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.update_reservation
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_capacity_commitment' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient#create_capacity_commitment."

    it 'invokes create_capacity_commitment without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient.location_path("[PROJECT]", "[LOCATION]")

      # Create expected grpc response
      name = "name3373707"
      slot_count = 191518834
      expected_response = { name: name, slot_count: slot_count }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Bigquery::Reservation::V1beta1::CapacityCommitment)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Bigquery::Reservation::V1beta1::CreateCapacityCommitmentRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:create_capacity_commitment, mock_method)

      # Mock auth layer
      mock_credentials = MockReservationServiceCredentials_v1beta1.new("create_capacity_commitment")

      Google::Cloud::Bigquery::Reservation::V1beta1::ReservationService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Reservation::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Reservation.new(version: :v1beta1)

          # Call method
          response = client.create_capacity_commitment(formatted_parent)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_capacity_commitment(formatted_parent) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_capacity_commitment with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient.location_path("[PROJECT]", "[LOCATION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Bigquery::Reservation::V1beta1::CreateCapacityCommitmentRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:create_capacity_commitment, mock_method)

      # Mock auth layer
      mock_credentials = MockReservationServiceCredentials_v1beta1.new("create_capacity_commitment")

      Google::Cloud::Bigquery::Reservation::V1beta1::ReservationService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Reservation::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Reservation.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.create_capacity_commitment(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_capacity_commitments' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient#list_capacity_commitments."

    it 'invokes list_capacity_commitments without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient.location_path("[PROJECT]", "[LOCATION]")

      # Create expected grpc response
      next_page_token = ""
      capacity_commitments_element = {}
      capacity_commitments = [capacity_commitments_element]
      expected_response = { next_page_token: next_page_token, capacity_commitments: capacity_commitments }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Bigquery::Reservation::V1beta1::ListCapacityCommitmentsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Bigquery::Reservation::V1beta1::ListCapacityCommitmentsRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:list_capacity_commitments, mock_method)

      # Mock auth layer
      mock_credentials = MockReservationServiceCredentials_v1beta1.new("list_capacity_commitments")

      Google::Cloud::Bigquery::Reservation::V1beta1::ReservationService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Reservation::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Reservation.new(version: :v1beta1)

          # Call method
          response = client.list_capacity_commitments(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.capacity_commitments.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_capacity_commitments with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient.location_path("[PROJECT]", "[LOCATION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Bigquery::Reservation::V1beta1::ListCapacityCommitmentsRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:list_capacity_commitments, mock_method)

      # Mock auth layer
      mock_credentials = MockReservationServiceCredentials_v1beta1.new("list_capacity_commitments")

      Google::Cloud::Bigquery::Reservation::V1beta1::ReservationService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Reservation::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Reservation.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.list_capacity_commitments(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_capacity_commitment' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient#get_capacity_commitment."

    it 'invokes get_capacity_commitment without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient.capacity_commitment_path("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      slot_count = 191518834
      expected_response = { name: name_2, slot_count: slot_count }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Bigquery::Reservation::V1beta1::CapacityCommitment)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Bigquery::Reservation::V1beta1::GetCapacityCommitmentRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:get_capacity_commitment, mock_method)

      # Mock auth layer
      mock_credentials = MockReservationServiceCredentials_v1beta1.new("get_capacity_commitment")

      Google::Cloud::Bigquery::Reservation::V1beta1::ReservationService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Reservation::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Reservation.new(version: :v1beta1)

          # Call method
          response = client.get_capacity_commitment(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_capacity_commitment(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_capacity_commitment with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient.capacity_commitment_path("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Bigquery::Reservation::V1beta1::GetCapacityCommitmentRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:get_capacity_commitment, mock_method)

      # Mock auth layer
      mock_credentials = MockReservationServiceCredentials_v1beta1.new("get_capacity_commitment")

      Google::Cloud::Bigquery::Reservation::V1beta1::ReservationService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Reservation::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Reservation.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.get_capacity_commitment(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_capacity_commitment' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient#delete_capacity_commitment."

    it 'invokes delete_capacity_commitment without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient.capacity_commitment_path("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Bigquery::Reservation::V1beta1::DeleteCapacityCommitmentRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:delete_capacity_commitment, mock_method)

      # Mock auth layer
      mock_credentials = MockReservationServiceCredentials_v1beta1.new("delete_capacity_commitment")

      Google::Cloud::Bigquery::Reservation::V1beta1::ReservationService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Reservation::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Reservation.new(version: :v1beta1)

          # Call method
          response = client.delete_capacity_commitment(formatted_name)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.delete_capacity_commitment(formatted_name) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes delete_capacity_commitment with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient.capacity_commitment_path("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Bigquery::Reservation::V1beta1::DeleteCapacityCommitmentRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:delete_capacity_commitment, mock_method)

      # Mock auth layer
      mock_credentials = MockReservationServiceCredentials_v1beta1.new("delete_capacity_commitment")

      Google::Cloud::Bigquery::Reservation::V1beta1::ReservationService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Reservation::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Reservation.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.delete_capacity_commitment(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_capacity_commitment' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient#update_capacity_commitment."

    it 'invokes update_capacity_commitment without error' do
      # Create expected grpc response
      name = "name3373707"
      slot_count = 191518834
      expected_response = { name: name, slot_count: slot_count }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Bigquery::Reservation::V1beta1::CapacityCommitment)

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:update_capacity_commitment, mock_method)

      # Mock auth layer
      mock_credentials = MockReservationServiceCredentials_v1beta1.new("update_capacity_commitment")

      Google::Cloud::Bigquery::Reservation::V1beta1::ReservationService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Reservation::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Reservation.new(version: :v1beta1)

          # Call method
          response = client.update_capacity_commitment

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.update_capacity_commitment do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes update_capacity_commitment with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:update_capacity_commitment, mock_method)

      # Mock auth layer
      mock_credentials = MockReservationServiceCredentials_v1beta1.new("update_capacity_commitment")

      Google::Cloud::Bigquery::Reservation::V1beta1::ReservationService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Reservation::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Reservation.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.update_capacity_commitment
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'split_capacity_commitment' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient#split_capacity_commitment."

    it 'invokes split_capacity_commitment without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient.capacity_commitment_path("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]")

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Bigquery::Reservation::V1beta1::SplitCapacityCommitmentResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Bigquery::Reservation::V1beta1::SplitCapacityCommitmentRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:split_capacity_commitment, mock_method)

      # Mock auth layer
      mock_credentials = MockReservationServiceCredentials_v1beta1.new("split_capacity_commitment")

      Google::Cloud::Bigquery::Reservation::V1beta1::ReservationService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Reservation::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Reservation.new(version: :v1beta1)

          # Call method
          response = client.split_capacity_commitment(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.split_capacity_commitment(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes split_capacity_commitment with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient.capacity_commitment_path("[PROJECT]", "[LOCATION]", "[CAPACITY_COMMITMENT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Bigquery::Reservation::V1beta1::SplitCapacityCommitmentRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:split_capacity_commitment, mock_method)

      # Mock auth layer
      mock_credentials = MockReservationServiceCredentials_v1beta1.new("split_capacity_commitment")

      Google::Cloud::Bigquery::Reservation::V1beta1::ReservationService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Reservation::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Reservation.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.split_capacity_commitment(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'merge_capacity_commitments' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient#merge_capacity_commitments."

    it 'invokes merge_capacity_commitments without error' do
      # Create expected grpc response
      name = "name3373707"
      slot_count = 191518834
      expected_response = { name: name, slot_count: slot_count }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Bigquery::Reservation::V1beta1::CapacityCommitment)

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:merge_capacity_commitments, mock_method)

      # Mock auth layer
      mock_credentials = MockReservationServiceCredentials_v1beta1.new("merge_capacity_commitments")

      Google::Cloud::Bigquery::Reservation::V1beta1::ReservationService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Reservation::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Reservation.new(version: :v1beta1)

          # Call method
          response = client.merge_capacity_commitments

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.merge_capacity_commitments do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes merge_capacity_commitments with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:merge_capacity_commitments, mock_method)

      # Mock auth layer
      mock_credentials = MockReservationServiceCredentials_v1beta1.new("merge_capacity_commitments")

      Google::Cloud::Bigquery::Reservation::V1beta1::ReservationService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Reservation::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Reservation.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.merge_capacity_commitments
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_assignment' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient#create_assignment."

    it 'invokes create_assignment without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient.reservation_path("[PROJECT]", "[LOCATION]", "[RESERVATION]")

      # Create expected grpc response
      name = "name3373707"
      assignee = "assignee-369881649"
      expected_response = { name: name, assignee: assignee }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Bigquery::Reservation::V1beta1::Assignment)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Bigquery::Reservation::V1beta1::CreateAssignmentRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:create_assignment, mock_method)

      # Mock auth layer
      mock_credentials = MockReservationServiceCredentials_v1beta1.new("create_assignment")

      Google::Cloud::Bigquery::Reservation::V1beta1::ReservationService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Reservation::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Reservation.new(version: :v1beta1)

          # Call method
          response = client.create_assignment(formatted_parent)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_assignment(formatted_parent) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_assignment with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient.reservation_path("[PROJECT]", "[LOCATION]", "[RESERVATION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Bigquery::Reservation::V1beta1::CreateAssignmentRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:create_assignment, mock_method)

      # Mock auth layer
      mock_credentials = MockReservationServiceCredentials_v1beta1.new("create_assignment")

      Google::Cloud::Bigquery::Reservation::V1beta1::ReservationService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Reservation::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Reservation.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.create_assignment(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_assignments' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient#list_assignments."

    it 'invokes list_assignments without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient.reservation_path("[PROJECT]", "[LOCATION]", "[RESERVATION]")

      # Create expected grpc response
      next_page_token = ""
      assignments_element = {}
      assignments = [assignments_element]
      expected_response = { next_page_token: next_page_token, assignments: assignments }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Bigquery::Reservation::V1beta1::ListAssignmentsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Bigquery::Reservation::V1beta1::ListAssignmentsRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:list_assignments, mock_method)

      # Mock auth layer
      mock_credentials = MockReservationServiceCredentials_v1beta1.new("list_assignments")

      Google::Cloud::Bigquery::Reservation::V1beta1::ReservationService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Reservation::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Reservation.new(version: :v1beta1)

          # Call method
          response = client.list_assignments(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.assignments.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_assignments with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient.reservation_path("[PROJECT]", "[LOCATION]", "[RESERVATION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Bigquery::Reservation::V1beta1::ListAssignmentsRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:list_assignments, mock_method)

      # Mock auth layer
      mock_credentials = MockReservationServiceCredentials_v1beta1.new("list_assignments")

      Google::Cloud::Bigquery::Reservation::V1beta1::ReservationService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Reservation::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Reservation.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.list_assignments(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_assignment' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient#delete_assignment."

    it 'invokes delete_assignment without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient.assignment_path("[PROJECT]", "[LOCATION]", "[RESERVATION]", "[ASSIGNMENT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Bigquery::Reservation::V1beta1::DeleteAssignmentRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:delete_assignment, mock_method)

      # Mock auth layer
      mock_credentials = MockReservationServiceCredentials_v1beta1.new("delete_assignment")

      Google::Cloud::Bigquery::Reservation::V1beta1::ReservationService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Reservation::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Reservation.new(version: :v1beta1)

          # Call method
          response = client.delete_assignment(formatted_name)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.delete_assignment(formatted_name) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes delete_assignment with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient.assignment_path("[PROJECT]", "[LOCATION]", "[RESERVATION]", "[ASSIGNMENT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Bigquery::Reservation::V1beta1::DeleteAssignmentRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:delete_assignment, mock_method)

      # Mock auth layer
      mock_credentials = MockReservationServiceCredentials_v1beta1.new("delete_assignment")

      Google::Cloud::Bigquery::Reservation::V1beta1::ReservationService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Reservation::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Reservation.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.delete_assignment(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'search_assignments' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient#search_assignments."

    it 'invokes search_assignments without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient.location_path("[PROJECT]", "[LOCATION]")

      # Create expected grpc response
      next_page_token = ""
      assignments_element = {}
      assignments = [assignments_element]
      expected_response = { next_page_token: next_page_token, assignments: assignments }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Bigquery::Reservation::V1beta1::SearchAssignmentsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Bigquery::Reservation::V1beta1::SearchAssignmentsRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:search_assignments, mock_method)

      # Mock auth layer
      mock_credentials = MockReservationServiceCredentials_v1beta1.new("search_assignments")

      Google::Cloud::Bigquery::Reservation::V1beta1::ReservationService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Reservation::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Reservation.new(version: :v1beta1)

          # Call method
          response = client.search_assignments(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.assignments.to_a, response.to_a)
        end
      end
    end

    it 'invokes search_assignments with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient.location_path("[PROJECT]", "[LOCATION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Bigquery::Reservation::V1beta1::SearchAssignmentsRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:search_assignments, mock_method)

      # Mock auth layer
      mock_credentials = MockReservationServiceCredentials_v1beta1.new("search_assignments")

      Google::Cloud::Bigquery::Reservation::V1beta1::ReservationService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Reservation::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Reservation.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.search_assignments(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'move_assignment' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient#move_assignment."

    it 'invokes move_assignment without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient.assignment_path("[PROJECT]", "[LOCATION]", "[RESERVATION]", "[ASSIGNMENT]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      assignee = "assignee-369881649"
      expected_response = { name: name_2, assignee: assignee }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Bigquery::Reservation::V1beta1::Assignment)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Bigquery::Reservation::V1beta1::MoveAssignmentRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:move_assignment, mock_method)

      # Mock auth layer
      mock_credentials = MockReservationServiceCredentials_v1beta1.new("move_assignment")

      Google::Cloud::Bigquery::Reservation::V1beta1::ReservationService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Reservation::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Reservation.new(version: :v1beta1)

          # Call method
          response = client.move_assignment(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.move_assignment(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes move_assignment with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient.assignment_path("[PROJECT]", "[LOCATION]", "[RESERVATION]", "[ASSIGNMENT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Bigquery::Reservation::V1beta1::MoveAssignmentRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:move_assignment, mock_method)

      # Mock auth layer
      mock_credentials = MockReservationServiceCredentials_v1beta1.new("move_assignment")

      Google::Cloud::Bigquery::Reservation::V1beta1::ReservationService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Reservation::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Reservation.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.move_assignment(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_bi_reservation' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient#get_bi_reservation."

    it 'invokes get_bi_reservation without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient.bi_reservation_path("[PROJECT]", "[LOCATION]", "[BIRESERVATION]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      size = 3530753
      expected_response = { name: name_2, size: size }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Bigquery::Reservation::V1beta1::BiReservation)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Bigquery::Reservation::V1beta1::GetBiReservationRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:get_bi_reservation, mock_method)

      # Mock auth layer
      mock_credentials = MockReservationServiceCredentials_v1beta1.new("get_bi_reservation")

      Google::Cloud::Bigquery::Reservation::V1beta1::ReservationService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Reservation::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Reservation.new(version: :v1beta1)

          # Call method
          response = client.get_bi_reservation(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_bi_reservation(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_bi_reservation with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient.bi_reservation_path("[PROJECT]", "[LOCATION]", "[BIRESERVATION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Bigquery::Reservation::V1beta1::GetBiReservationRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:get_bi_reservation, mock_method)

      # Mock auth layer
      mock_credentials = MockReservationServiceCredentials_v1beta1.new("get_bi_reservation")

      Google::Cloud::Bigquery::Reservation::V1beta1::ReservationService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Reservation::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Reservation.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.get_bi_reservation(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_bi_reservation' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Bigquery::Reservation::V1beta1::ReservationServiceClient#update_bi_reservation."

    it 'invokes update_bi_reservation without error' do
      # Create expected grpc response
      name = "name3373707"
      size = 3530753
      expected_response = { name: name, size: size }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Bigquery::Reservation::V1beta1::BiReservation)

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:update_bi_reservation, mock_method)

      # Mock auth layer
      mock_credentials = MockReservationServiceCredentials_v1beta1.new("update_bi_reservation")

      Google::Cloud::Bigquery::Reservation::V1beta1::ReservationService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Reservation::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Reservation.new(version: :v1beta1)

          # Call method
          response = client.update_bi_reservation

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.update_bi_reservation do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes update_bi_reservation with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:update_bi_reservation, mock_method)

      # Mock auth layer
      mock_credentials = MockReservationServiceCredentials_v1beta1.new("update_bi_reservation")

      Google::Cloud::Bigquery::Reservation::V1beta1::ReservationService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Bigquery::Reservation::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Bigquery::Reservation.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.update_bi_reservation
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end