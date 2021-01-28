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

require "google/cloud/iam/credentials"
require "google/cloud/iam/credentials/v1/iam_credentials_client"
require "google/iam/credentials/v1/iamcredentials_services_pb"

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

class MockIAMCredentialsCredentials_v1 < Google::Cloud::Iam::Credentials::V1::Credentials
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

describe Google::Cloud::Iam::Credentials::V1::IamCredentialsClient do

  describe 'generate_access_token' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Iam::Credentials::V1::IamCredentialsClient#generate_access_token."

    it 'invokes generate_access_token without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Iam::Credentials::V1::IamCredentialsClient.service_account_path("[PROJECT]", "[SERVICE_ACCOUNT]")
      scope = []

      # Create expected grpc response
      access_token = "accessToken-1938933922"
      expected_response = { access_token: access_token }
      expected_response = Google::Gax::to_proto(expected_response, Google::Iam::Credentials::V1::GenerateAccessTokenResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::Credentials::V1::GenerateAccessTokenRequest, request)
        assert_equal(formatted_name, request.name)
        assert_equal(scope, request.scope)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:generate_access_token, mock_method)

      # Mock auth layer
      mock_credentials = MockIAMCredentialsCredentials_v1.new("generate_access_token")

      Google::Iam::Credentials::V1::IAMCredentials::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::Credentials::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::Credentials.new(version: :v1)

          # Call method
          response = client.generate_access_token(formatted_name, scope)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.generate_access_token(formatted_name, scope) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes generate_access_token with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Iam::Credentials::V1::IamCredentialsClient.service_account_path("[PROJECT]", "[SERVICE_ACCOUNT]")
      scope = []

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::Credentials::V1::GenerateAccessTokenRequest, request)
        assert_equal(formatted_name, request.name)
        assert_equal(scope, request.scope)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:generate_access_token, mock_method)

      # Mock auth layer
      mock_credentials = MockIAMCredentialsCredentials_v1.new("generate_access_token")

      Google::Iam::Credentials::V1::IAMCredentials::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::Credentials::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::Credentials.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.generate_access_token(formatted_name, scope)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'generate_id_token' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Iam::Credentials::V1::IamCredentialsClient#generate_id_token."

    it 'invokes generate_id_token without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Iam::Credentials::V1::IamCredentialsClient.service_account_path("[PROJECT]", "[SERVICE_ACCOUNT]")
      audience = ''

      # Create expected grpc response
      token = "token110541305"
      expected_response = { token: token }
      expected_response = Google::Gax::to_proto(expected_response, Google::Iam::Credentials::V1::GenerateIdTokenResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::Credentials::V1::GenerateIdTokenRequest, request)
        assert_equal(formatted_name, request.name)
        assert_equal(audience, request.audience)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:generate_id_token, mock_method)

      # Mock auth layer
      mock_credentials = MockIAMCredentialsCredentials_v1.new("generate_id_token")

      Google::Iam::Credentials::V1::IAMCredentials::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::Credentials::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::Credentials.new(version: :v1)

          # Call method
          response = client.generate_id_token(formatted_name, audience)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.generate_id_token(formatted_name, audience) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes generate_id_token with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Iam::Credentials::V1::IamCredentialsClient.service_account_path("[PROJECT]", "[SERVICE_ACCOUNT]")
      audience = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::Credentials::V1::GenerateIdTokenRequest, request)
        assert_equal(formatted_name, request.name)
        assert_equal(audience, request.audience)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:generate_id_token, mock_method)

      # Mock auth layer
      mock_credentials = MockIAMCredentialsCredentials_v1.new("generate_id_token")

      Google::Iam::Credentials::V1::IAMCredentials::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::Credentials::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::Credentials.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.generate_id_token(formatted_name, audience)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'sign_blob' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Iam::Credentials::V1::IamCredentialsClient#sign_blob."

    it 'invokes sign_blob without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Iam::Credentials::V1::IamCredentialsClient.service_account_path("[PROJECT]", "[SERVICE_ACCOUNT]")
      payload = ''

      # Create expected grpc response
      key_id = "keyId-1134673157"
      signed_blob = "-32"
      expected_response = { key_id: key_id, signed_blob: signed_blob }
      expected_response = Google::Gax::to_proto(expected_response, Google::Iam::Credentials::V1::SignBlobResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::Credentials::V1::SignBlobRequest, request)
        assert_equal(formatted_name, request.name)
        assert_equal(payload, request.payload)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:sign_blob, mock_method)

      # Mock auth layer
      mock_credentials = MockIAMCredentialsCredentials_v1.new("sign_blob")

      Google::Iam::Credentials::V1::IAMCredentials::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::Credentials::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::Credentials.new(version: :v1)

          # Call method
          response = client.sign_blob(formatted_name, payload)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.sign_blob(formatted_name, payload) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes sign_blob with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Iam::Credentials::V1::IamCredentialsClient.service_account_path("[PROJECT]", "[SERVICE_ACCOUNT]")
      payload = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::Credentials::V1::SignBlobRequest, request)
        assert_equal(formatted_name, request.name)
        assert_equal(payload, request.payload)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:sign_blob, mock_method)

      # Mock auth layer
      mock_credentials = MockIAMCredentialsCredentials_v1.new("sign_blob")

      Google::Iam::Credentials::V1::IAMCredentials::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::Credentials::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::Credentials.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.sign_blob(formatted_name, payload)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'sign_jwt' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Iam::Credentials::V1::IamCredentialsClient#sign_jwt."

    it 'invokes sign_jwt without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Iam::Credentials::V1::IamCredentialsClient.service_account_path("[PROJECT]", "[SERVICE_ACCOUNT]")
      payload = ''

      # Create expected grpc response
      key_id = "keyId-1134673157"
      signed_jwt = "signedJwt-979546844"
      expected_response = { key_id: key_id, signed_jwt: signed_jwt }
      expected_response = Google::Gax::to_proto(expected_response, Google::Iam::Credentials::V1::SignJwtResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::Credentials::V1::SignJwtRequest, request)
        assert_equal(formatted_name, request.name)
        assert_equal(payload, request.payload)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:sign_jwt, mock_method)

      # Mock auth layer
      mock_credentials = MockIAMCredentialsCredentials_v1.new("sign_jwt")

      Google::Iam::Credentials::V1::IAMCredentials::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::Credentials::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::Credentials.new(version: :v1)

          # Call method
          response = client.sign_jwt(formatted_name, payload)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.sign_jwt(formatted_name, payload) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes sign_jwt with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Iam::Credentials::V1::IamCredentialsClient.service_account_path("[PROJECT]", "[SERVICE_ACCOUNT]")
      payload = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Iam::Credentials::V1::SignJwtRequest, request)
        assert_equal(formatted_name, request.name)
        assert_equal(payload, request.payload)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:sign_jwt, mock_method)

      # Mock auth layer
      mock_credentials = MockIAMCredentialsCredentials_v1.new("sign_jwt")

      Google::Iam::Credentials::V1::IAMCredentials::Stub.stub(:new, mock_stub) do
        Google::Cloud::Iam::Credentials::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Iam::Credentials.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.sign_jwt(formatted_name, payload)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end