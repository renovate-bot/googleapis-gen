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

require "google/cloud/retail/v2alpha"
require "google/cloud/retail/v2alpha/user_event_service_client"
require "google/cloud/retail/v2alpha/user_event_service_services_pb"
require "google/longrunning/operations_pb"

class CustomTestError_v2alpha < StandardError; end

# Mock for the GRPC::ClientStub class.
class MockGrpcClientStub_v2alpha

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

class MockUserEventServiceCredentials_v2alpha < Google::Cloud::Retail::V2alpha::Credentials
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

describe Google::Cloud::Retail::V2alpha::UserEventServiceClient do

  describe 'write_user_event' do
    custom_error = CustomTestError_v2alpha.new "Custom test error for Google::Cloud::Retail::V2alpha::UserEventServiceClient#write_user_event."

    it 'invokes write_user_event without error' do
      # Create request parameters
      parent = ''
      user_event = {}

      # Create expected grpc response
      event_type = "eventType984376767"
      visitor_id = "visitorId-1832599924"
      attribution_token = "attributionToken-729411015"
      cart_id = "cartId554410650"
      search_query = "searchQuery461177713"
      uri = "uri116076"
      referrer_uri = "referrerUri-2093856436"
      page_view_id = "pageViewId948896581"
      expected_response = {
        event_type: event_type,
        visitor_id: visitor_id,
        attribution_token: attribution_token,
        cart_id: cart_id,
        search_query: search_query,
        uri: uri,
        referrer_uri: referrer_uri,
        page_view_id: page_view_id
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Retail::V2alpha::UserEvent)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Retail::V2alpha::WriteUserEventRequest, request)
        assert_equal(parent, request.parent)
        assert_equal(Google::Gax::to_proto(user_event, Google::Cloud::Retail::V2alpha::UserEvent), request.user_event)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v2alpha.new(:write_user_event, mock_method)

      # Mock auth layer
      mock_credentials = MockUserEventServiceCredentials_v2alpha.new("write_user_event")

      Google::Cloud::Retail::V2alpha::UserEventService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Retail::V2alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Retail::V2alpha::UserEvent.new

          # Call method
          response = client.write_user_event(parent, user_event)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.write_user_event(parent, user_event) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes write_user_event with error' do
      # Create request parameters
      parent = ''
      user_event = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Retail::V2alpha::WriteUserEventRequest, request)
        assert_equal(parent, request.parent)
        assert_equal(Google::Gax::to_proto(user_event, Google::Cloud::Retail::V2alpha::UserEvent), request.user_event)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2alpha.new(:write_user_event, mock_method)

      # Mock auth layer
      mock_credentials = MockUserEventServiceCredentials_v2alpha.new("write_user_event")

      Google::Cloud::Retail::V2alpha::UserEventService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Retail::V2alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Retail::V2alpha::UserEvent.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2alpha do
            client.write_user_event(parent, user_event)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'collect_user_event' do
    custom_error = CustomTestError_v2alpha.new "Custom test error for Google::Cloud::Retail::V2alpha::UserEventServiceClient#collect_user_event."

    it 'invokes collect_user_event without error' do
      # Create request parameters
      parent = ''
      user_event = ''

      # Create expected grpc response
      content_type = "contentType831846208"
      data = "-86"
      expected_response = { content_type: content_type, data: data }
      expected_response = Google::Gax::to_proto(expected_response, Google::Api::HttpBody)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Retail::V2alpha::CollectUserEventRequest, request)
        assert_equal(parent, request.parent)
        assert_equal(user_event, request.user_event)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v2alpha.new(:collect_user_event, mock_method)

      # Mock auth layer
      mock_credentials = MockUserEventServiceCredentials_v2alpha.new("collect_user_event")

      Google::Cloud::Retail::V2alpha::UserEventService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Retail::V2alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Retail::V2alpha::UserEvent.new

          # Call method
          response = client.collect_user_event(parent, user_event)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.collect_user_event(parent, user_event) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes collect_user_event with error' do
      # Create request parameters
      parent = ''
      user_event = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Retail::V2alpha::CollectUserEventRequest, request)
        assert_equal(parent, request.parent)
        assert_equal(user_event, request.user_event)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2alpha.new(:collect_user_event, mock_method)

      # Mock auth layer
      mock_credentials = MockUserEventServiceCredentials_v2alpha.new("collect_user_event")

      Google::Cloud::Retail::V2alpha::UserEventService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Retail::V2alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Retail::V2alpha::UserEvent.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2alpha do
            client.collect_user_event(parent, user_event)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'purge_user_events' do
    custom_error = CustomTestError_v2alpha.new "Custom test error for Google::Cloud::Retail::V2alpha::UserEventServiceClient#purge_user_events."

    it 'invokes purge_user_events without error' do
      # Create request parameters
      parent = ''
      filter = ''

      # Create expected grpc response
      purged_events_count = 310774833
      expected_response = { purged_events_count: purged_events_count }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Retail::V2alpha::PurgeUserEventsResponse)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/purge_user_events_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Retail::V2alpha::PurgeUserEventsRequest, request)
        assert_equal(parent, request.parent)
        assert_equal(filter, request.filter)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v2alpha.new(:purge_user_events, mock_method)

      # Mock auth layer
      mock_credentials = MockUserEventServiceCredentials_v2alpha.new("purge_user_events")

      Google::Cloud::Retail::V2alpha::UserEventService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Retail::V2alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Retail::V2alpha::UserEvent.new

          # Call method
          response = client.purge_user_events(parent, filter)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes purge_user_events and returns an operation error.' do
      # Create request parameters
      parent = ''
      filter = ''

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Retail::V2alpha::UserEventServiceClient#purge_user_events.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/purge_user_events_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Retail::V2alpha::PurgeUserEventsRequest, request)
        assert_equal(parent, request.parent)
        assert_equal(filter, request.filter)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v2alpha.new(:purge_user_events, mock_method)

      # Mock auth layer
      mock_credentials = MockUserEventServiceCredentials_v2alpha.new("purge_user_events")

      Google::Cloud::Retail::V2alpha::UserEventService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Retail::V2alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Retail::V2alpha::UserEvent.new

          # Call method
          response = client.purge_user_events(parent, filter)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes purge_user_events with error' do
      # Create request parameters
      parent = ''
      filter = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Retail::V2alpha::PurgeUserEventsRequest, request)
        assert_equal(parent, request.parent)
        assert_equal(filter, request.filter)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2alpha.new(:purge_user_events, mock_method)

      # Mock auth layer
      mock_credentials = MockUserEventServiceCredentials_v2alpha.new("purge_user_events")

      Google::Cloud::Retail::V2alpha::UserEventService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Retail::V2alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Retail::V2alpha::UserEvent.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2alpha do
            client.purge_user_events(parent, filter)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'import_user_events' do
    custom_error = CustomTestError_v2alpha.new "Custom test error for Google::Cloud::Retail::V2alpha::UserEventServiceClient#import_user_events."

    it 'invokes import_user_events without error' do
      # Create request parameters
      parent = ''
      input_config = {}

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Retail::V2alpha::ImportUserEventsResponse)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/import_user_events_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Retail::V2alpha::ImportUserEventsRequest, request)
        assert_equal(parent, request.parent)
        assert_equal(Google::Gax::to_proto(input_config, Google::Cloud::Retail::V2alpha::UserEventInputConfig), request.input_config)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v2alpha.new(:import_user_events, mock_method)

      # Mock auth layer
      mock_credentials = MockUserEventServiceCredentials_v2alpha.new("import_user_events")

      Google::Cloud::Retail::V2alpha::UserEventService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Retail::V2alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Retail::V2alpha::UserEvent.new

          # Call method
          response = client.import_user_events(parent, input_config)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes import_user_events and returns an operation error.' do
      # Create request parameters
      parent = ''
      input_config = {}

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Retail::V2alpha::UserEventServiceClient#import_user_events.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/import_user_events_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Retail::V2alpha::ImportUserEventsRequest, request)
        assert_equal(parent, request.parent)
        assert_equal(Google::Gax::to_proto(input_config, Google::Cloud::Retail::V2alpha::UserEventInputConfig), request.input_config)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v2alpha.new(:import_user_events, mock_method)

      # Mock auth layer
      mock_credentials = MockUserEventServiceCredentials_v2alpha.new("import_user_events")

      Google::Cloud::Retail::V2alpha::UserEventService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Retail::V2alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Retail::V2alpha::UserEvent.new

          # Call method
          response = client.import_user_events(parent, input_config)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes import_user_events with error' do
      # Create request parameters
      parent = ''
      input_config = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Retail::V2alpha::ImportUserEventsRequest, request)
        assert_equal(parent, request.parent)
        assert_equal(Google::Gax::to_proto(input_config, Google::Cloud::Retail::V2alpha::UserEventInputConfig), request.input_config)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2alpha.new(:import_user_events, mock_method)

      # Mock auth layer
      mock_credentials = MockUserEventServiceCredentials_v2alpha.new("import_user_events")

      Google::Cloud::Retail::V2alpha::UserEventService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Retail::V2alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Retail::V2alpha::UserEvent.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2alpha do
            client.import_user_events(parent, input_config)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'rejoin_user_events' do
    custom_error = CustomTestError_v2alpha.new "Custom test error for Google::Cloud::Retail::V2alpha::UserEventServiceClient#rejoin_user_events."

    it 'invokes rejoin_user_events without error' do
      # Create request parameters
      parent = ''

      # Create expected grpc response
      rejoined_user_events_count = 1152281574
      expected_response = { rejoined_user_events_count: rejoined_user_events_count }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Retail::V2alpha::RejoinUserEventsResponse)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/rejoin_user_events_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Retail::V2alpha::RejoinUserEventsRequest, request)
        assert_equal(parent, request.parent)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v2alpha.new(:rejoin_user_events, mock_method)

      # Mock auth layer
      mock_credentials = MockUserEventServiceCredentials_v2alpha.new("rejoin_user_events")

      Google::Cloud::Retail::V2alpha::UserEventService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Retail::V2alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Retail::V2alpha::UserEvent.new

          # Call method
          response = client.rejoin_user_events(parent)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes rejoin_user_events and returns an operation error.' do
      # Create request parameters
      parent = ''

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Retail::V2alpha::UserEventServiceClient#rejoin_user_events.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/rejoin_user_events_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Retail::V2alpha::RejoinUserEventsRequest, request)
        assert_equal(parent, request.parent)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v2alpha.new(:rejoin_user_events, mock_method)

      # Mock auth layer
      mock_credentials = MockUserEventServiceCredentials_v2alpha.new("rejoin_user_events")

      Google::Cloud::Retail::V2alpha::UserEventService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Retail::V2alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Retail::V2alpha::UserEvent.new

          # Call method
          response = client.rejoin_user_events(parent)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes rejoin_user_events with error' do
      # Create request parameters
      parent = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Retail::V2alpha::RejoinUserEventsRequest, request)
        assert_equal(parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2alpha.new(:rejoin_user_events, mock_method)

      # Mock auth layer
      mock_credentials = MockUserEventServiceCredentials_v2alpha.new("rejoin_user_events")

      Google::Cloud::Retail::V2alpha::UserEventService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Retail::V2alpha::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Retail::V2alpha::UserEvent.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2alpha do
            client.rejoin_user_events(parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end