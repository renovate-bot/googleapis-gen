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

require "google/cloud/recommender"
require "google/cloud/recommender/v1beta1/recommender_client"
require "google/cloud/recommender/v1beta1/recommender_service_services_pb"

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

class MockRecommenderCredentials_v1beta1 < Google::Cloud::Recommender::V1beta1::Credentials
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

describe Google::Cloud::Recommender::V1beta1::RecommenderClient do

  describe 'list_insights' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Recommender::V1beta1::RecommenderClient#list_insights."

    it 'invokes list_insights without error' do
      # Create request parameters
      parent = ''

      # Create expected grpc response
      next_page_token = ""
      insights_element = {}
      insights = [insights_element]
      expected_response = { next_page_token: next_page_token, insights: insights }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Recommender::V1beta1::ListInsightsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Recommender::V1beta1::ListInsightsRequest, request)
        assert_equal(parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:list_insights, mock_method)

      # Mock auth layer
      mock_credentials = MockRecommenderCredentials_v1beta1.new("list_insights")

      Google::Cloud::Recommender::V1beta1::Recommender::Stub.stub(:new, mock_stub) do
        Google::Cloud::Recommender::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Recommender.new(version: :v1beta1)

          # Call method
          response = client.list_insights(parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.insights.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_insights with error' do
      # Create request parameters
      parent = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Recommender::V1beta1::ListInsightsRequest, request)
        assert_equal(parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:list_insights, mock_method)

      # Mock auth layer
      mock_credentials = MockRecommenderCredentials_v1beta1.new("list_insights")

      Google::Cloud::Recommender::V1beta1::Recommender::Stub.stub(:new, mock_stub) do
        Google::Cloud::Recommender::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Recommender.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.list_insights(parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_insight' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Recommender::V1beta1::RecommenderClient#get_insight."

    it 'invokes get_insight without error' do
      # Create request parameters
      name = ''

      # Create expected grpc response
      name_2 = "name2-1052831874"
      description = "description-1724546052"
      insight_subtype = "insightSubtype-1491142701"
      etag = "etag3123477"
      expected_response = {
        name: name_2,
        description: description,
        insight_subtype: insight_subtype,
        etag: etag
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Recommender::V1beta1::Insight)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Recommender::V1beta1::GetInsightRequest, request)
        assert_equal(name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:get_insight, mock_method)

      # Mock auth layer
      mock_credentials = MockRecommenderCredentials_v1beta1.new("get_insight")

      Google::Cloud::Recommender::V1beta1::Recommender::Stub.stub(:new, mock_stub) do
        Google::Cloud::Recommender::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Recommender.new(version: :v1beta1)

          # Call method
          response = client.get_insight(name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_insight(name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_insight with error' do
      # Create request parameters
      name = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Recommender::V1beta1::GetInsightRequest, request)
        assert_equal(name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:get_insight, mock_method)

      # Mock auth layer
      mock_credentials = MockRecommenderCredentials_v1beta1.new("get_insight")

      Google::Cloud::Recommender::V1beta1::Recommender::Stub.stub(:new, mock_stub) do
        Google::Cloud::Recommender::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Recommender.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.get_insight(name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'mark_insight_accepted' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Recommender::V1beta1::RecommenderClient#mark_insight_accepted."

    it 'invokes mark_insight_accepted without error' do
      # Create request parameters
      name = ''
      etag = ''

      # Create expected grpc response
      name_2 = "name2-1052831874"
      description = "description-1724546052"
      insight_subtype = "insightSubtype-1491142701"
      etag_2 = "etag2-1293302904"
      expected_response = {
        name: name_2,
        description: description,
        insight_subtype: insight_subtype,
        etag: etag_2
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Recommender::V1beta1::Insight)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Recommender::V1beta1::MarkInsightAcceptedRequest, request)
        assert_equal(name, request.name)
        assert_equal(etag, request.etag)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:mark_insight_accepted, mock_method)

      # Mock auth layer
      mock_credentials = MockRecommenderCredentials_v1beta1.new("mark_insight_accepted")

      Google::Cloud::Recommender::V1beta1::Recommender::Stub.stub(:new, mock_stub) do
        Google::Cloud::Recommender::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Recommender.new(version: :v1beta1)

          # Call method
          response = client.mark_insight_accepted(name, etag)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.mark_insight_accepted(name, etag) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes mark_insight_accepted with error' do
      # Create request parameters
      name = ''
      etag = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Recommender::V1beta1::MarkInsightAcceptedRequest, request)
        assert_equal(name, request.name)
        assert_equal(etag, request.etag)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:mark_insight_accepted, mock_method)

      # Mock auth layer
      mock_credentials = MockRecommenderCredentials_v1beta1.new("mark_insight_accepted")

      Google::Cloud::Recommender::V1beta1::Recommender::Stub.stub(:new, mock_stub) do
        Google::Cloud::Recommender::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Recommender.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.mark_insight_accepted(name, etag)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_recommendations' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Recommender::V1beta1::RecommenderClient#list_recommendations."

    it 'invokes list_recommendations without error' do
      # Create request parameters
      parent = ''

      # Create expected grpc response
      next_page_token = ""
      recommendations_element = {}
      recommendations = [recommendations_element]
      expected_response = { next_page_token: next_page_token, recommendations: recommendations }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Recommender::V1beta1::ListRecommendationsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Recommender::V1beta1::ListRecommendationsRequest, request)
        assert_equal(parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:list_recommendations, mock_method)

      # Mock auth layer
      mock_credentials = MockRecommenderCredentials_v1beta1.new("list_recommendations")

      Google::Cloud::Recommender::V1beta1::Recommender::Stub.stub(:new, mock_stub) do
        Google::Cloud::Recommender::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Recommender.new(version: :v1beta1)

          # Call method
          response = client.list_recommendations(parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.recommendations.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_recommendations with error' do
      # Create request parameters
      parent = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Recommender::V1beta1::ListRecommendationsRequest, request)
        assert_equal(parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:list_recommendations, mock_method)

      # Mock auth layer
      mock_credentials = MockRecommenderCredentials_v1beta1.new("list_recommendations")

      Google::Cloud::Recommender::V1beta1::Recommender::Stub.stub(:new, mock_stub) do
        Google::Cloud::Recommender::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Recommender.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.list_recommendations(parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_recommendation' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Recommender::V1beta1::RecommenderClient#get_recommendation."

    it 'invokes get_recommendation without error' do
      # Create request parameters
      name = ''

      # Create expected grpc response
      name_2 = "name2-1052831874"
      description = "description-1724546052"
      recommender_subtype = "recommenderSubtype-1488504412"
      etag = "etag3123477"
      expected_response = {
        name: name_2,
        description: description,
        recommender_subtype: recommender_subtype,
        etag: etag
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Recommender::V1beta1::Recommendation)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Recommender::V1beta1::GetRecommendationRequest, request)
        assert_equal(name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:get_recommendation, mock_method)

      # Mock auth layer
      mock_credentials = MockRecommenderCredentials_v1beta1.new("get_recommendation")

      Google::Cloud::Recommender::V1beta1::Recommender::Stub.stub(:new, mock_stub) do
        Google::Cloud::Recommender::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Recommender.new(version: :v1beta1)

          # Call method
          response = client.get_recommendation(name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_recommendation(name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_recommendation with error' do
      # Create request parameters
      name = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Recommender::V1beta1::GetRecommendationRequest, request)
        assert_equal(name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:get_recommendation, mock_method)

      # Mock auth layer
      mock_credentials = MockRecommenderCredentials_v1beta1.new("get_recommendation")

      Google::Cloud::Recommender::V1beta1::Recommender::Stub.stub(:new, mock_stub) do
        Google::Cloud::Recommender::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Recommender.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.get_recommendation(name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'mark_recommendation_claimed' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Recommender::V1beta1::RecommenderClient#mark_recommendation_claimed."

    it 'invokes mark_recommendation_claimed without error' do
      # Create request parameters
      name = ''
      etag = ''

      # Create expected grpc response
      name_2 = "name2-1052831874"
      description = "description-1724546052"
      recommender_subtype = "recommenderSubtype-1488504412"
      etag_2 = "etag2-1293302904"
      expected_response = {
        name: name_2,
        description: description,
        recommender_subtype: recommender_subtype,
        etag: etag_2
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Recommender::V1beta1::Recommendation)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Recommender::V1beta1::MarkRecommendationClaimedRequest, request)
        assert_equal(name, request.name)
        assert_equal(etag, request.etag)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:mark_recommendation_claimed, mock_method)

      # Mock auth layer
      mock_credentials = MockRecommenderCredentials_v1beta1.new("mark_recommendation_claimed")

      Google::Cloud::Recommender::V1beta1::Recommender::Stub.stub(:new, mock_stub) do
        Google::Cloud::Recommender::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Recommender.new(version: :v1beta1)

          # Call method
          response = client.mark_recommendation_claimed(name, etag)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.mark_recommendation_claimed(name, etag) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes mark_recommendation_claimed with error' do
      # Create request parameters
      name = ''
      etag = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Recommender::V1beta1::MarkRecommendationClaimedRequest, request)
        assert_equal(name, request.name)
        assert_equal(etag, request.etag)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:mark_recommendation_claimed, mock_method)

      # Mock auth layer
      mock_credentials = MockRecommenderCredentials_v1beta1.new("mark_recommendation_claimed")

      Google::Cloud::Recommender::V1beta1::Recommender::Stub.stub(:new, mock_stub) do
        Google::Cloud::Recommender::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Recommender.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.mark_recommendation_claimed(name, etag)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'mark_recommendation_succeeded' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Recommender::V1beta1::RecommenderClient#mark_recommendation_succeeded."

    it 'invokes mark_recommendation_succeeded without error' do
      # Create request parameters
      name = ''
      etag = ''

      # Create expected grpc response
      name_2 = "name2-1052831874"
      description = "description-1724546052"
      recommender_subtype = "recommenderSubtype-1488504412"
      etag_2 = "etag2-1293302904"
      expected_response = {
        name: name_2,
        description: description,
        recommender_subtype: recommender_subtype,
        etag: etag_2
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Recommender::V1beta1::Recommendation)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Recommender::V1beta1::MarkRecommendationSucceededRequest, request)
        assert_equal(name, request.name)
        assert_equal(etag, request.etag)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:mark_recommendation_succeeded, mock_method)

      # Mock auth layer
      mock_credentials = MockRecommenderCredentials_v1beta1.new("mark_recommendation_succeeded")

      Google::Cloud::Recommender::V1beta1::Recommender::Stub.stub(:new, mock_stub) do
        Google::Cloud::Recommender::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Recommender.new(version: :v1beta1)

          # Call method
          response = client.mark_recommendation_succeeded(name, etag)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.mark_recommendation_succeeded(name, etag) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes mark_recommendation_succeeded with error' do
      # Create request parameters
      name = ''
      etag = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Recommender::V1beta1::MarkRecommendationSucceededRequest, request)
        assert_equal(name, request.name)
        assert_equal(etag, request.etag)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:mark_recommendation_succeeded, mock_method)

      # Mock auth layer
      mock_credentials = MockRecommenderCredentials_v1beta1.new("mark_recommendation_succeeded")

      Google::Cloud::Recommender::V1beta1::Recommender::Stub.stub(:new, mock_stub) do
        Google::Cloud::Recommender::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Recommender.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.mark_recommendation_succeeded(name, etag)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'mark_recommendation_failed' do
    custom_error = CustomTestError_v1beta1.new "Custom test error for Google::Cloud::Recommender::V1beta1::RecommenderClient#mark_recommendation_failed."

    it 'invokes mark_recommendation_failed without error' do
      # Create request parameters
      name = ''
      etag = ''

      # Create expected grpc response
      name_2 = "name2-1052831874"
      description = "description-1724546052"
      recommender_subtype = "recommenderSubtype-1488504412"
      etag_2 = "etag2-1293302904"
      expected_response = {
        name: name_2,
        description: description,
        recommender_subtype: recommender_subtype,
        etag: etag_2
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Recommender::V1beta1::Recommendation)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Recommender::V1beta1::MarkRecommendationFailedRequest, request)
        assert_equal(name, request.name)
        assert_equal(etag, request.etag)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:mark_recommendation_failed, mock_method)

      # Mock auth layer
      mock_credentials = MockRecommenderCredentials_v1beta1.new("mark_recommendation_failed")

      Google::Cloud::Recommender::V1beta1::Recommender::Stub.stub(:new, mock_stub) do
        Google::Cloud::Recommender::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Recommender.new(version: :v1beta1)

          # Call method
          response = client.mark_recommendation_failed(name, etag)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.mark_recommendation_failed(name, etag) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes mark_recommendation_failed with error' do
      # Create request parameters
      name = ''
      etag = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Recommender::V1beta1::MarkRecommendationFailedRequest, request)
        assert_equal(name, request.name)
        assert_equal(etag, request.etag)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1beta1.new(:mark_recommendation_failed, mock_method)

      # Mock auth layer
      mock_credentials = MockRecommenderCredentials_v1beta1.new("mark_recommendation_failed")

      Google::Cloud::Recommender::V1beta1::Recommender::Stub.stub(:new, mock_stub) do
        Google::Cloud::Recommender::V1beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Recommender.new(version: :v1beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1beta1 do
            client.mark_recommendation_failed(name, etag)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end