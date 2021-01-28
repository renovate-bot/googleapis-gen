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

require "google/cloud/devtools/remoteworkers/v1test2"
require "google/cloud/devtools/remoteworkers/v1test2/bots_client"
require "google/devtools/remoteworkers/v1test2/bots_services_pb"

class CustomTestError_v1test2 < StandardError; end

# Mock for the GRPC::ClientStub class.
class MockGrpcClientStub_v1test2

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

class MockBotsCredentials_v1test2 < Google::Cloud::Devtools::Remoteworkers::V1test2::Credentials
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

describe Google::Cloud::Devtools::Remoteworkers::V1test2::BotsClient do

  describe 'create_bot_session' do
    custom_error = CustomTestError_v1test2.new "Custom test error for Google::Cloud::Devtools::Remoteworkers::V1test2::BotsClient#create_bot_session."

    it 'invokes create_bot_session without error' do
      # Create request parameters
      parent = ''
      bot_session = {}

      # Create expected grpc response
      name = "name3373707"
      bot_id = "botId-1383249261"
      version = "version351608024"
      expected_response = {
        name: name,
        bot_id: bot_id,
        version: version
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Devtools::Remoteworkers::V1test2::BotSession)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Devtools::Remoteworkers::V1test2::CreateBotSessionRequest, request)
        assert_equal(parent, request.parent)
        assert_equal(Google::Gax::to_proto(bot_session, Google::Devtools::Remoteworkers::V1test2::BotSession), request.bot_session)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1test2.new(:create_bot_session, mock_method)

      # Mock auth layer
      mock_credentials = MockBotsCredentials_v1test2.new("create_bot_session")

      Google::Devtools::Remoteworkers::V1test2::Bots::Stub.stub(:new, mock_stub) do
        Google::Cloud::Devtools::Remoteworkers::V1test2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Devtools::Remoteworkers::V1test2.new

          # Call method
          response = client.create_bot_session(parent, bot_session)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_bot_session(parent, bot_session) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_bot_session with error' do
      # Create request parameters
      parent = ''
      bot_session = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Devtools::Remoteworkers::V1test2::CreateBotSessionRequest, request)
        assert_equal(parent, request.parent)
        assert_equal(Google::Gax::to_proto(bot_session, Google::Devtools::Remoteworkers::V1test2::BotSession), request.bot_session)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1test2.new(:create_bot_session, mock_method)

      # Mock auth layer
      mock_credentials = MockBotsCredentials_v1test2.new("create_bot_session")

      Google::Devtools::Remoteworkers::V1test2::Bots::Stub.stub(:new, mock_stub) do
        Google::Cloud::Devtools::Remoteworkers::V1test2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Devtools::Remoteworkers::V1test2.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1test2 do
            client.create_bot_session(parent, bot_session)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_bot_session' do
    custom_error = CustomTestError_v1test2.new "Custom test error for Google::Cloud::Devtools::Remoteworkers::V1test2::BotsClient#update_bot_session."

    it 'invokes update_bot_session without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Devtools::Remoteworkers::V1test2::BotsClient.bot_session_path("[UNKNOWN_PATH]", "[BOT_SESSION]")
      bot_session = {}
      update_mask = {}

      # Create expected grpc response
      name_2 = "name2-1052831874"
      bot_id = "botId-1383249261"
      version = "version351608024"
      expected_response = {
        name: name_2,
        bot_id: bot_id,
        version: version
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Devtools::Remoteworkers::V1test2::BotSession)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Devtools::Remoteworkers::V1test2::UpdateBotSessionRequest, request)
        assert_equal(formatted_name, request.name)
        assert_equal(Google::Gax::to_proto(bot_session, Google::Devtools::Remoteworkers::V1test2::BotSession), request.bot_session)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1test2.new(:update_bot_session, mock_method)

      # Mock auth layer
      mock_credentials = MockBotsCredentials_v1test2.new("update_bot_session")

      Google::Devtools::Remoteworkers::V1test2::Bots::Stub.stub(:new, mock_stub) do
        Google::Cloud::Devtools::Remoteworkers::V1test2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Devtools::Remoteworkers::V1test2.new

          # Call method
          response = client.update_bot_session(
            formatted_name,
            bot_session,
            update_mask
          )

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.update_bot_session(
            formatted_name,
            bot_session,
            update_mask
          ) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes update_bot_session with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Devtools::Remoteworkers::V1test2::BotsClient.bot_session_path("[UNKNOWN_PATH]", "[BOT_SESSION]")
      bot_session = {}
      update_mask = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Devtools::Remoteworkers::V1test2::UpdateBotSessionRequest, request)
        assert_equal(formatted_name, request.name)
        assert_equal(Google::Gax::to_proto(bot_session, Google::Devtools::Remoteworkers::V1test2::BotSession), request.bot_session)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1test2.new(:update_bot_session, mock_method)

      # Mock auth layer
      mock_credentials = MockBotsCredentials_v1test2.new("update_bot_session")

      Google::Devtools::Remoteworkers::V1test2::Bots::Stub.stub(:new, mock_stub) do
        Google::Cloud::Devtools::Remoteworkers::V1test2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Devtools::Remoteworkers::V1test2.new

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1test2 do
            client.update_bot_session(
              formatted_name,
              bot_session,
              update_mask
            )
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end