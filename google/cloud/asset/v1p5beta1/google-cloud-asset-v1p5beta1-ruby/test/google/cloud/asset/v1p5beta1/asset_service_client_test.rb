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

require "google/cloud/asset"
require "google/cloud/asset/v1p5beta1/asset_service_client"
require "google/cloud/asset/v1p5beta1/asset_service_services_pb"

class CustomTestError_v1p5beta1 < StandardError; end

# Mock for the GRPC::ClientStub class.
class MockGrpcClientStub_v1p5beta1

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

class MockAssetServiceCredentials_v1p5beta1 < Google::Cloud::Asset::V1p5beta1::Credentials
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

describe Google::Cloud::Asset::V1p5beta1::AssetServiceClient do

  describe 'list_assets' do
    custom_error = CustomTestError_v1p5beta1.new "Custom test error for Google::Cloud::Asset::V1p5beta1::AssetServiceClient#list_assets."

    it 'invokes list_assets without error' do
      # Create request parameters
      parent = ''

      # Create expected grpc response
      next_page_token = ""
      assets_element = {}
      assets = [assets_element]
      expected_response = { next_page_token: next_page_token, assets: assets }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Asset::V1p5beta1::ListAssetsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Asset::V1p5beta1::ListAssetsRequest, request)
        assert_equal(parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1p5beta1.new(:list_assets, mock_method)

      # Mock auth layer
      mock_credentials = MockAssetServiceCredentials_v1p5beta1.new("list_assets")

      Google::Cloud::Asset::V1p5beta1::AssetService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Asset::V1p5beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Asset.new(version: :v1p5beta1)

          # Call method
          response = client.list_assets(parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.assets.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_assets with error' do
      # Create request parameters
      parent = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Asset::V1p5beta1::ListAssetsRequest, request)
        assert_equal(parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1p5beta1.new(:list_assets, mock_method)

      # Mock auth layer
      mock_credentials = MockAssetServiceCredentials_v1p5beta1.new("list_assets")

      Google::Cloud::Asset::V1p5beta1::AssetService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Asset::V1p5beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Asset.new(version: :v1p5beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1p5beta1 do
            client.list_assets(parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end