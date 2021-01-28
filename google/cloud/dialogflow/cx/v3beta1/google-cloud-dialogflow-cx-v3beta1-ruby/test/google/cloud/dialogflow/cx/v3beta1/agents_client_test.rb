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

require "google/cloud/dialogflow/cx"
require "google/cloud/dialogflow/cx/v3beta1/agents_client"
require "google/cloud/dialogflow/cx/v3beta1/agent_services_pb"
require "google/longrunning/operations_pb"

class CustomTestError_v3beta1 < StandardError; end

# Mock for the GRPC::ClientStub class.
class MockGrpcClientStub_v3beta1

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

class MockAgentsCredentials_v3beta1 < Google::Cloud::Dialogflow::Cx::V3beta1::Credentials
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

describe Google::Cloud::Dialogflow::Cx::V3beta1::AgentsClient do

  describe 'list_agents' do
    custom_error = CustomTestError_v3beta1.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3beta1::AgentsClient#list_agents."

    it 'invokes list_agents without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Dialogflow::Cx::V3beta1::AgentsClient.location_path("[PROJECT]", "[LOCATION]")

      # Create expected grpc response
      next_page_token = ""
      agents_element = {}
      agents = [agents_element]
      expected_response = { next_page_token: next_page_token, agents: agents }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::Cx::V3beta1::ListAgentsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::ListAgentsRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:list_agents, mock_method)

      # Mock auth layer
      mock_credentials = MockAgentsCredentials_v3beta1.new("list_agents")

      Google::Cloud::Dialogflow::Cx::V3beta1::Agents::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Agents.new(version: :v3beta1)

          # Call method
          response = client.list_agents(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.agents.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_agents with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Dialogflow::Cx::V3beta1::AgentsClient.location_path("[PROJECT]", "[LOCATION]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::ListAgentsRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:list_agents, mock_method)

      # Mock auth layer
      mock_credentials = MockAgentsCredentials_v3beta1.new("list_agents")

      Google::Cloud::Dialogflow::Cx::V3beta1::Agents::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Agents.new(version: :v3beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3beta1 do
            client.list_agents(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_agent' do
    custom_error = CustomTestError_v3beta1.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3beta1::AgentsClient#get_agent."

    it 'invokes get_agent without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3beta1::AgentsClient.agent_path("[PROJECT]", "[LOCATION]", "[AGENT]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      display_name = "displayName1615086568"
      default_language_code = "defaultLanguageCode856575222"
      time_zone = "timeZone36848094"
      description = "description-1724546052"
      avatar_uri = "avatarUri-402824826"
      start_flow = "startFlow-1573559573"
      security_settings = "securitySettings-595091902"
      enable_stackdriver_logging = true
      enable_spell_correction = false
      expected_response = {
        name: name_2,
        display_name: display_name,
        default_language_code: default_language_code,
        time_zone: time_zone,
        description: description,
        avatar_uri: avatar_uri,
        start_flow: start_flow,
        security_settings: security_settings,
        enable_stackdriver_logging: enable_stackdriver_logging,
        enable_spell_correction: enable_spell_correction
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::Cx::V3beta1::Agent)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::GetAgentRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:get_agent, mock_method)

      # Mock auth layer
      mock_credentials = MockAgentsCredentials_v3beta1.new("get_agent")

      Google::Cloud::Dialogflow::Cx::V3beta1::Agents::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Agents.new(version: :v3beta1)

          # Call method
          response = client.get_agent(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_agent(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_agent with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3beta1::AgentsClient.agent_path("[PROJECT]", "[LOCATION]", "[AGENT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::GetAgentRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:get_agent, mock_method)

      # Mock auth layer
      mock_credentials = MockAgentsCredentials_v3beta1.new("get_agent")

      Google::Cloud::Dialogflow::Cx::V3beta1::Agents::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Agents.new(version: :v3beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3beta1 do
            client.get_agent(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_agent' do
    custom_error = CustomTestError_v3beta1.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3beta1::AgentsClient#create_agent."

    it 'invokes create_agent without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Dialogflow::Cx::V3beta1::AgentsClient.location_path("[PROJECT]", "[LOCATION]")
      agent = {}

      # Create expected grpc response
      name = "name3373707"
      display_name = "displayName1615086568"
      default_language_code = "defaultLanguageCode856575222"
      time_zone = "timeZone36848094"
      description = "description-1724546052"
      avatar_uri = "avatarUri-402824826"
      start_flow = "startFlow-1573559573"
      security_settings = "securitySettings-595091902"
      enable_stackdriver_logging = true
      enable_spell_correction = false
      expected_response = {
        name: name,
        display_name: display_name,
        default_language_code: default_language_code,
        time_zone: time_zone,
        description: description,
        avatar_uri: avatar_uri,
        start_flow: start_flow,
        security_settings: security_settings,
        enable_stackdriver_logging: enable_stackdriver_logging,
        enable_spell_correction: enable_spell_correction
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::Cx::V3beta1::Agent)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::CreateAgentRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(agent, Google::Cloud::Dialogflow::Cx::V3beta1::Agent), request.agent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:create_agent, mock_method)

      # Mock auth layer
      mock_credentials = MockAgentsCredentials_v3beta1.new("create_agent")

      Google::Cloud::Dialogflow::Cx::V3beta1::Agents::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Agents.new(version: :v3beta1)

          # Call method
          response = client.create_agent(formatted_parent, agent)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_agent(formatted_parent, agent) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_agent with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Dialogflow::Cx::V3beta1::AgentsClient.location_path("[PROJECT]", "[LOCATION]")
      agent = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::CreateAgentRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(agent, Google::Cloud::Dialogflow::Cx::V3beta1::Agent), request.agent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:create_agent, mock_method)

      # Mock auth layer
      mock_credentials = MockAgentsCredentials_v3beta1.new("create_agent")

      Google::Cloud::Dialogflow::Cx::V3beta1::Agents::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Agents.new(version: :v3beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3beta1 do
            client.create_agent(formatted_parent, agent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_agent' do
    custom_error = CustomTestError_v3beta1.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3beta1::AgentsClient#update_agent."

    it 'invokes update_agent without error' do
      # Create request parameters
      agent = {}

      # Create expected grpc response
      name = "name3373707"
      display_name = "displayName1615086568"
      default_language_code = "defaultLanguageCode856575222"
      time_zone = "timeZone36848094"
      description = "description-1724546052"
      avatar_uri = "avatarUri-402824826"
      start_flow = "startFlow-1573559573"
      security_settings = "securitySettings-595091902"
      enable_stackdriver_logging = true
      enable_spell_correction = false
      expected_response = {
        name: name,
        display_name: display_name,
        default_language_code: default_language_code,
        time_zone: time_zone,
        description: description,
        avatar_uri: avatar_uri,
        start_flow: start_flow,
        security_settings: security_settings,
        enable_stackdriver_logging: enable_stackdriver_logging,
        enable_spell_correction: enable_spell_correction
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::Cx::V3beta1::Agent)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::UpdateAgentRequest, request)
        assert_equal(Google::Gax::to_proto(agent, Google::Cloud::Dialogflow::Cx::V3beta1::Agent), request.agent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:update_agent, mock_method)

      # Mock auth layer
      mock_credentials = MockAgentsCredentials_v3beta1.new("update_agent")

      Google::Cloud::Dialogflow::Cx::V3beta1::Agents::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Agents.new(version: :v3beta1)

          # Call method
          response = client.update_agent(agent)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.update_agent(agent) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes update_agent with error' do
      # Create request parameters
      agent = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::UpdateAgentRequest, request)
        assert_equal(Google::Gax::to_proto(agent, Google::Cloud::Dialogflow::Cx::V3beta1::Agent), request.agent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:update_agent, mock_method)

      # Mock auth layer
      mock_credentials = MockAgentsCredentials_v3beta1.new("update_agent")

      Google::Cloud::Dialogflow::Cx::V3beta1::Agents::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Agents.new(version: :v3beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3beta1 do
            client.update_agent(agent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_agent' do
    custom_error = CustomTestError_v3beta1.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3beta1::AgentsClient#delete_agent."

    it 'invokes delete_agent without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3beta1::AgentsClient.agent_path("[PROJECT]", "[LOCATION]", "[AGENT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::DeleteAgentRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:delete_agent, mock_method)

      # Mock auth layer
      mock_credentials = MockAgentsCredentials_v3beta1.new("delete_agent")

      Google::Cloud::Dialogflow::Cx::V3beta1::Agents::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Agents.new(version: :v3beta1)

          # Call method
          response = client.delete_agent(formatted_name)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.delete_agent(formatted_name) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes delete_agent with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3beta1::AgentsClient.agent_path("[PROJECT]", "[LOCATION]", "[AGENT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::DeleteAgentRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:delete_agent, mock_method)

      # Mock auth layer
      mock_credentials = MockAgentsCredentials_v3beta1.new("delete_agent")

      Google::Cloud::Dialogflow::Cx::V3beta1::Agents::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Agents.new(version: :v3beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3beta1 do
            client.delete_agent(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'export_agent' do
    custom_error = CustomTestError_v3beta1.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3beta1::AgentsClient#export_agent."

    it 'invokes export_agent without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3beta1::AgentsClient.agent_path("[PROJECT]", "[LOCATION]", "[AGENT]")

      # Create expected grpc response
      agent_uri = "agentUri-1700713166"
      expected_response = { agent_uri: agent_uri }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::Cx::V3beta1::ExportAgentResponse)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/export_agent_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::ExportAgentRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:export_agent, mock_method)

      # Mock auth layer
      mock_credentials = MockAgentsCredentials_v3beta1.new("export_agent")

      Google::Cloud::Dialogflow::Cx::V3beta1::Agents::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Agents.new(version: :v3beta1)

          # Call method
          response = client.export_agent(formatted_name)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes export_agent and returns an operation error.' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3beta1::AgentsClient.agent_path("[PROJECT]", "[LOCATION]", "[AGENT]")

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Dialogflow::Cx::V3beta1::AgentsClient#export_agent.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/export_agent_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::ExportAgentRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:export_agent, mock_method)

      # Mock auth layer
      mock_credentials = MockAgentsCredentials_v3beta1.new("export_agent")

      Google::Cloud::Dialogflow::Cx::V3beta1::Agents::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Agents.new(version: :v3beta1)

          # Call method
          response = client.export_agent(formatted_name)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes export_agent with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3beta1::AgentsClient.agent_path("[PROJECT]", "[LOCATION]", "[AGENT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::ExportAgentRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:export_agent, mock_method)

      # Mock auth layer
      mock_credentials = MockAgentsCredentials_v3beta1.new("export_agent")

      Google::Cloud::Dialogflow::Cx::V3beta1::Agents::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Agents.new(version: :v3beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3beta1 do
            client.export_agent(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'restore_agent' do
    custom_error = CustomTestError_v3beta1.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3beta1::AgentsClient#restore_agent."

    it 'invokes restore_agent without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3beta1::AgentsClient.agent_path("[PROJECT]", "[LOCATION]", "[AGENT]")

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Protobuf::Empty)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/restore_agent_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::RestoreAgentRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:restore_agent, mock_method)

      # Mock auth layer
      mock_credentials = MockAgentsCredentials_v3beta1.new("restore_agent")

      Google::Cloud::Dialogflow::Cx::V3beta1::Agents::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Agents.new(version: :v3beta1)

          # Call method
          response = client.restore_agent(formatted_name)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes restore_agent and returns an operation error.' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3beta1::AgentsClient.agent_path("[PROJECT]", "[LOCATION]", "[AGENT]")

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Dialogflow::Cx::V3beta1::AgentsClient#restore_agent.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/restore_agent_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::RestoreAgentRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:restore_agent, mock_method)

      # Mock auth layer
      mock_credentials = MockAgentsCredentials_v3beta1.new("restore_agent")

      Google::Cloud::Dialogflow::Cx::V3beta1::Agents::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Agents.new(version: :v3beta1)

          # Call method
          response = client.restore_agent(formatted_name)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes restore_agent with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3beta1::AgentsClient.agent_path("[PROJECT]", "[LOCATION]", "[AGENT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::RestoreAgentRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:restore_agent, mock_method)

      # Mock auth layer
      mock_credentials = MockAgentsCredentials_v3beta1.new("restore_agent")

      Google::Cloud::Dialogflow::Cx::V3beta1::Agents::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Agents.new(version: :v3beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3beta1 do
            client.restore_agent(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'validate_agent' do
    custom_error = CustomTestError_v3beta1.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3beta1::AgentsClient#validate_agent."

    it 'invokes validate_agent without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3beta1::AgentsClient.agent_path("[PROJECT]", "[LOCATION]", "[AGENT]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      expected_response = { name: name_2 }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::Cx::V3beta1::AgentValidationResult)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::ValidateAgentRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:validate_agent, mock_method)

      # Mock auth layer
      mock_credentials = MockAgentsCredentials_v3beta1.new("validate_agent")

      Google::Cloud::Dialogflow::Cx::V3beta1::Agents::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Agents.new(version: :v3beta1)

          # Call method
          response = client.validate_agent(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.validate_agent(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes validate_agent with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3beta1::AgentsClient.agent_path("[PROJECT]", "[LOCATION]", "[AGENT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::ValidateAgentRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:validate_agent, mock_method)

      # Mock auth layer
      mock_credentials = MockAgentsCredentials_v3beta1.new("validate_agent")

      Google::Cloud::Dialogflow::Cx::V3beta1::Agents::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Agents.new(version: :v3beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3beta1 do
            client.validate_agent(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_agent_validation_result' do
    custom_error = CustomTestError_v3beta1.new "Custom test error for Google::Cloud::Dialogflow::Cx::V3beta1::AgentsClient#get_agent_validation_result."

    it 'invokes get_agent_validation_result without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3beta1::AgentsClient.agent_validation_result_path("[PROJECT]", "[LOCATION]", "[AGENT]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      expected_response = { name: name_2 }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::Cx::V3beta1::AgentValidationResult)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::GetAgentValidationResultRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:get_agent_validation_result, mock_method)

      # Mock auth layer
      mock_credentials = MockAgentsCredentials_v3beta1.new("get_agent_validation_result")

      Google::Cloud::Dialogflow::Cx::V3beta1::Agents::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Agents.new(version: :v3beta1)

          # Call method
          response = client.get_agent_validation_result(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_agent_validation_result(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_agent_validation_result with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Dialogflow::Cx::V3beta1::AgentsClient.agent_validation_result_path("[PROJECT]", "[LOCATION]", "[AGENT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::Cx::V3beta1::GetAgentValidationResultRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v3beta1.new(:get_agent_validation_result, mock_method)

      # Mock auth layer
      mock_credentials = MockAgentsCredentials_v3beta1.new("get_agent_validation_result")

      Google::Cloud::Dialogflow::Cx::V3beta1::Agents::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::Cx::V3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Cx::Agents.new(version: :v3beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v3beta1 do
            client.get_agent_validation_result(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end