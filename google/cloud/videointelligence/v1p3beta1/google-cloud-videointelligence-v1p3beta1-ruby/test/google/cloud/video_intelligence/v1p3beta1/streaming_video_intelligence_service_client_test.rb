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

require "google/cloud/video_intelligence"
require "google/cloud/video_intelligence/v1p3beta1/streaming_video_intelligence_service_client"
require "google/cloud/videointelligence/v1p3beta1/video_intelligence_services_pb"

class CustomTestError_v1p3beta1 < StandardError; end

# Mock for the GRPC::ClientStub class.
class MockGrpcClientStub_v1p3beta1

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

class MockStreamingVideoIntelligenceServiceCredentials_v1p3beta1 < Google::Cloud::VideoIntelligence::V1p3beta1::Credentials
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

describe Google::Cloud::VideoIntelligence::V1p3beta1::StreamingVideoIntelligenceServiceClient do

  describe 'streaming_annotate_video' do
    custom_error = CustomTestError_v1p3beta1.new "Custom test error for Google::Cloud::VideoIntelligence::V1p3beta1::StreamingVideoIntelligenceServiceClient#streaming_annotate_video."

    it 'invokes streaming_annotate_video without error' do
      # Create request parameters
      request = {}

      # Create expected grpc response
      annotation_results_uri = "annotationResultsUri-238075757"
      expected_response = { annotation_results_uri: annotation_results_uri }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Videointelligence::V1p3beta1::StreamingAnnotateVideoResponse)

      # Mock Grpc layer
      mock_method = proc do |requests|
        request = requests.first
        OpenStruct.new(execute: [expected_response])
      end
      mock_stub = MockGrpcClientStub_v1p3beta1.new(:streaming_annotate_video, mock_method)

      # Mock auth layer
      mock_credentials = MockStreamingVideoIntelligenceServiceCredentials_v1p3beta1.new("streaming_annotate_video")

      Google::Cloud::Videointelligence::V1p3beta1::StreamingVideoIntelligenceService::Stub.stub(:new, mock_stub) do
        Google::Cloud::VideoIntelligence::V1p3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::VideoIntelligence::StreamingVideoIntelligence.new(version: :v1p3beta1)

          # Call method
          response = client.streaming_annotate_video([request])

          # Verify the response
          assert_equal(1, response.count)
          assert_equal(expected_response, response.first)
        end
      end
    end

    it 'invokes streaming_annotate_video with error' do
      # Create request parameters
      request = {}

      # Mock Grpc layer
      mock_method = proc do |requests|
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1p3beta1.new(:streaming_annotate_video, mock_method)

      # Mock auth layer
      mock_credentials = MockStreamingVideoIntelligenceServiceCredentials_v1p3beta1.new("streaming_annotate_video")

      Google::Cloud::Videointelligence::V1p3beta1::StreamingVideoIntelligenceService::Stub.stub(:new, mock_stub) do
        Google::Cloud::VideoIntelligence::V1p3beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::VideoIntelligence::StreamingVideoIntelligence.new(version: :v1p3beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1p3beta1 do
            client.streaming_annotate_video([request])
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end