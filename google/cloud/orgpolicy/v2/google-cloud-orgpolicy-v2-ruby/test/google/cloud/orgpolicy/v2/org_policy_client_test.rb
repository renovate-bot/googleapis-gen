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

require "google/cloud/orgpolicy"
require "google/cloud/orgpolicy/v2/org_policy_client"
require "google/cloud/orgpolicy/v2/orgpolicy_services_pb"

class CustomTestError_v2 < StandardError; end

# Mock for the GRPC::ClientStub class.
class MockGrpcClientStub_v2

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

class MockOrgPolicyCredentials_v2 < Google::Cloud::Orgpolicy::V2::Credentials
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

describe Google::Cloud::Orgpolicy::V2::OrgPolicyClient do

  describe 'list_constraints' do
    custom_error = CustomTestError_v2.new "Custom test error for Google::Cloud::Orgpolicy::V2::OrgPolicyClient#list_constraints."

    it 'invokes list_constraints without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Orgpolicy::V2::OrgPolicyClient.project_path("[PROJECT]")

      # Create expected grpc response
      next_page_token = ""
      constraints_element = {}
      constraints = [constraints_element]
      expected_response = { next_page_token: next_page_token, constraints: constraints }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Orgpolicy::V2::ListConstraintsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Orgpolicy::V2::ListConstraintsRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v2.new(:list_constraints, mock_method)

      # Mock auth layer
      mock_credentials = MockOrgPolicyCredentials_v2.new("list_constraints")

      Google::Cloud::Orgpolicy::V2::OrgPolicy::Stub.stub(:new, mock_stub) do
        Google::Cloud::Orgpolicy::V2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Orgpolicy.new(version: :v2)

          # Call method
          response = client.list_constraints(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.constraints.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_constraints with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Orgpolicy::V2::OrgPolicyClient.project_path("[PROJECT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Orgpolicy::V2::ListConstraintsRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2.new(:list_constraints, mock_method)

      # Mock auth layer
      mock_credentials = MockOrgPolicyCredentials_v2.new("list_constraints")

      Google::Cloud::Orgpolicy::V2::OrgPolicy::Stub.stub(:new, mock_stub) do
        Google::Cloud::Orgpolicy::V2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Orgpolicy.new(version: :v2)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2 do
            client.list_constraints(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_policies' do
    custom_error = CustomTestError_v2.new "Custom test error for Google::Cloud::Orgpolicy::V2::OrgPolicyClient#list_policies."

    it 'invokes list_policies without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Orgpolicy::V2::OrgPolicyClient.project_path("[PROJECT]")

      # Create expected grpc response
      next_page_token = ""
      policies_element = {}
      policies = [policies_element]
      expected_response = { next_page_token: next_page_token, policies: policies }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Orgpolicy::V2::ListPoliciesResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Orgpolicy::V2::ListPoliciesRequest, request)
        assert_equal(formatted_parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v2.new(:list_policies, mock_method)

      # Mock auth layer
      mock_credentials = MockOrgPolicyCredentials_v2.new("list_policies")

      Google::Cloud::Orgpolicy::V2::OrgPolicy::Stub.stub(:new, mock_stub) do
        Google::Cloud::Orgpolicy::V2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Orgpolicy.new(version: :v2)

          # Call method
          response = client.list_policies(formatted_parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.policies.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_policies with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Orgpolicy::V2::OrgPolicyClient.project_path("[PROJECT]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Orgpolicy::V2::ListPoliciesRequest, request)
        assert_equal(formatted_parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2.new(:list_policies, mock_method)

      # Mock auth layer
      mock_credentials = MockOrgPolicyCredentials_v2.new("list_policies")

      Google::Cloud::Orgpolicy::V2::OrgPolicy::Stub.stub(:new, mock_stub) do
        Google::Cloud::Orgpolicy::V2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Orgpolicy.new(version: :v2)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2 do
            client.list_policies(formatted_parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_policy' do
    custom_error = CustomTestError_v2.new "Custom test error for Google::Cloud::Orgpolicy::V2::OrgPolicyClient#get_policy."

    it 'invokes get_policy without error' do
      # Create request parameters
      name = ''

      # Create expected grpc response
      name_2 = "name2-1052831874"
      expected_response = { name: name_2 }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Orgpolicy::V2::Policy)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Orgpolicy::V2::GetPolicyRequest, request)
        assert_equal(name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v2.new(:get_policy, mock_method)

      # Mock auth layer
      mock_credentials = MockOrgPolicyCredentials_v2.new("get_policy")

      Google::Cloud::Orgpolicy::V2::OrgPolicy::Stub.stub(:new, mock_stub) do
        Google::Cloud::Orgpolicy::V2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Orgpolicy.new(version: :v2)

          # Call method
          response = client.get_policy(name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_policy(name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_policy with error' do
      # Create request parameters
      name = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Orgpolicy::V2::GetPolicyRequest, request)
        assert_equal(name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2.new(:get_policy, mock_method)

      # Mock auth layer
      mock_credentials = MockOrgPolicyCredentials_v2.new("get_policy")

      Google::Cloud::Orgpolicy::V2::OrgPolicy::Stub.stub(:new, mock_stub) do
        Google::Cloud::Orgpolicy::V2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Orgpolicy.new(version: :v2)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2 do
            client.get_policy(name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_effective_policy' do
    custom_error = CustomTestError_v2.new "Custom test error for Google::Cloud::Orgpolicy::V2::OrgPolicyClient#get_effective_policy."

    it 'invokes get_effective_policy without error' do
      # Create request parameters
      name = ''

      # Create expected grpc response
      name_2 = "name2-1052831874"
      expected_response = { name: name_2 }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Orgpolicy::V2::Policy)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Orgpolicy::V2::GetEffectivePolicyRequest, request)
        assert_equal(name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v2.new(:get_effective_policy, mock_method)

      # Mock auth layer
      mock_credentials = MockOrgPolicyCredentials_v2.new("get_effective_policy")

      Google::Cloud::Orgpolicy::V2::OrgPolicy::Stub.stub(:new, mock_stub) do
        Google::Cloud::Orgpolicy::V2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Orgpolicy.new(version: :v2)

          # Call method
          response = client.get_effective_policy(name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_effective_policy(name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_effective_policy with error' do
      # Create request parameters
      name = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Orgpolicy::V2::GetEffectivePolicyRequest, request)
        assert_equal(name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2.new(:get_effective_policy, mock_method)

      # Mock auth layer
      mock_credentials = MockOrgPolicyCredentials_v2.new("get_effective_policy")

      Google::Cloud::Orgpolicy::V2::OrgPolicy::Stub.stub(:new, mock_stub) do
        Google::Cloud::Orgpolicy::V2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Orgpolicy.new(version: :v2)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2 do
            client.get_effective_policy(name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_policy' do
    custom_error = CustomTestError_v2.new "Custom test error for Google::Cloud::Orgpolicy::V2::OrgPolicyClient#create_policy."

    it 'invokes create_policy without error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Orgpolicy::V2::OrgPolicyClient.project_path("[PROJECT]")
      policy = {}

      # Create expected grpc response
      name = "name3373707"
      expected_response = { name: name }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Orgpolicy::V2::Policy)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Orgpolicy::V2::CreatePolicyRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(policy, Google::Cloud::Orgpolicy::V2::Policy), request.policy)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v2.new(:create_policy, mock_method)

      # Mock auth layer
      mock_credentials = MockOrgPolicyCredentials_v2.new("create_policy")

      Google::Cloud::Orgpolicy::V2::OrgPolicy::Stub.stub(:new, mock_stub) do
        Google::Cloud::Orgpolicy::V2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Orgpolicy.new(version: :v2)

          # Call method
          response = client.create_policy(formatted_parent, policy)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_policy(formatted_parent, policy) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_policy with error' do
      # Create request parameters
      formatted_parent = Google::Cloud::Orgpolicy::V2::OrgPolicyClient.project_path("[PROJECT]")
      policy = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Orgpolicy::V2::CreatePolicyRequest, request)
        assert_equal(formatted_parent, request.parent)
        assert_equal(Google::Gax::to_proto(policy, Google::Cloud::Orgpolicy::V2::Policy), request.policy)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2.new(:create_policy, mock_method)

      # Mock auth layer
      mock_credentials = MockOrgPolicyCredentials_v2.new("create_policy")

      Google::Cloud::Orgpolicy::V2::OrgPolicy::Stub.stub(:new, mock_stub) do
        Google::Cloud::Orgpolicy::V2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Orgpolicy.new(version: :v2)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2 do
            client.create_policy(formatted_parent, policy)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_policy' do
    custom_error = CustomTestError_v2.new "Custom test error for Google::Cloud::Orgpolicy::V2::OrgPolicyClient#update_policy."

    it 'invokes update_policy without error' do
      # Create request parameters
      policy = {}

      # Create expected grpc response
      name = "name3373707"
      expected_response = { name: name }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Orgpolicy::V2::Policy)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Orgpolicy::V2::UpdatePolicyRequest, request)
        assert_equal(Google::Gax::to_proto(policy, Google::Cloud::Orgpolicy::V2::Policy), request.policy)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v2.new(:update_policy, mock_method)

      # Mock auth layer
      mock_credentials = MockOrgPolicyCredentials_v2.new("update_policy")

      Google::Cloud::Orgpolicy::V2::OrgPolicy::Stub.stub(:new, mock_stub) do
        Google::Cloud::Orgpolicy::V2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Orgpolicy.new(version: :v2)

          # Call method
          response = client.update_policy(policy)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.update_policy(policy) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes update_policy with error' do
      # Create request parameters
      policy = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Orgpolicy::V2::UpdatePolicyRequest, request)
        assert_equal(Google::Gax::to_proto(policy, Google::Cloud::Orgpolicy::V2::Policy), request.policy)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2.new(:update_policy, mock_method)

      # Mock auth layer
      mock_credentials = MockOrgPolicyCredentials_v2.new("update_policy")

      Google::Cloud::Orgpolicy::V2::OrgPolicy::Stub.stub(:new, mock_stub) do
        Google::Cloud::Orgpolicy::V2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Orgpolicy.new(version: :v2)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2 do
            client.update_policy(policy)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_policy' do
    custom_error = CustomTestError_v2.new "Custom test error for Google::Cloud::Orgpolicy::V2::OrgPolicyClient#delete_policy."

    it 'invokes delete_policy without error' do
      # Create request parameters
      name = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Orgpolicy::V2::DeletePolicyRequest, request)
        assert_equal(name, request.name)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v2.new(:delete_policy, mock_method)

      # Mock auth layer
      mock_credentials = MockOrgPolicyCredentials_v2.new("delete_policy")

      Google::Cloud::Orgpolicy::V2::OrgPolicy::Stub.stub(:new, mock_stub) do
        Google::Cloud::Orgpolicy::V2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Orgpolicy.new(version: :v2)

          # Call method
          response = client.delete_policy(name)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.delete_policy(name) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes delete_policy with error' do
      # Create request parameters
      name = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Orgpolicy::V2::DeletePolicyRequest, request)
        assert_equal(name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2.new(:delete_policy, mock_method)

      # Mock auth layer
      mock_credentials = MockOrgPolicyCredentials_v2.new("delete_policy")

      Google::Cloud::Orgpolicy::V2::OrgPolicy::Stub.stub(:new, mock_stub) do
        Google::Cloud::Orgpolicy::V2::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Orgpolicy.new(version: :v2)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2 do
            client.delete_policy(name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end