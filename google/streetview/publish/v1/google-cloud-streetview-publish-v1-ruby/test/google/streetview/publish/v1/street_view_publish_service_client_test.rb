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

require "google/streetview/publish"
require "google/streetview/publish/v1/street_view_publish_service_client"
require "google/streetview/publish/v1/streetview_publish_services_pb"

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

class MockStreetViewPublishServiceCredentials_v1 < Google::Streetview::Publish::V1::Credentials
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

describe Google::Streetview::Publish::V1::StreetViewPublishServiceClient do

  describe 'start_upload' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Streetview::Publish::V1::StreetViewPublishServiceClient#start_upload."

    it 'invokes start_upload without error' do
      # Create expected grpc response
      upload_url = "uploadUrl-242738639"
      expected_response = { upload_url: upload_url }
      expected_response = Google::Gax::to_proto(expected_response, Google::Streetview::Publish::V1::UploadRef)

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:start_upload, mock_method)

      # Mock auth layer
      mock_credentials = MockStreetViewPublishServiceCredentials_v1.new("start_upload")

      Google::Streetview::Publish::V1::StreetViewPublishService::Stub.stub(:new, mock_stub) do
        Google::Streetview::Publish::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Streetview::Publish.new(version: :v1)

          # Call method
          response = client.start_upload

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.start_upload do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes start_upload with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:start_upload, mock_method)

      # Mock auth layer
      mock_credentials = MockStreetViewPublishServiceCredentials_v1.new("start_upload")

      Google::Streetview::Publish::V1::StreetViewPublishService::Stub.stub(:new, mock_stub) do
        Google::Streetview::Publish::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Streetview::Publish.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.start_upload
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_photo' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Streetview::Publish::V1::StreetViewPublishServiceClient#create_photo."

    it 'invokes create_photo without error' do
      # Create request parameters
      photo = {}

      # Create expected grpc response
      download_url = "downloadUrl1109408056"
      thumbnail_url = "thumbnailUrl1825632156"
      share_link = "shareLink-1788203942"
      view_count = 1534353675
      expected_response = {
        download_url: download_url,
        thumbnail_url: thumbnail_url,
        share_link: share_link,
        view_count: view_count
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Streetview::Publish::V1::Photo)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Streetview::Publish::V1::CreatePhotoRequest, request)
        assert_equal(Google::Gax::to_proto(photo, Google::Streetview::Publish::V1::Photo), request.photo)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:create_photo, mock_method)

      # Mock auth layer
      mock_credentials = MockStreetViewPublishServiceCredentials_v1.new("create_photo")

      Google::Streetview::Publish::V1::StreetViewPublishService::Stub.stub(:new, mock_stub) do
        Google::Streetview::Publish::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Streetview::Publish.new(version: :v1)

          # Call method
          response = client.create_photo(photo)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_photo(photo) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_photo with error' do
      # Create request parameters
      photo = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Streetview::Publish::V1::CreatePhotoRequest, request)
        assert_equal(Google::Gax::to_proto(photo, Google::Streetview::Publish::V1::Photo), request.photo)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:create_photo, mock_method)

      # Mock auth layer
      mock_credentials = MockStreetViewPublishServiceCredentials_v1.new("create_photo")

      Google::Streetview::Publish::V1::StreetViewPublishService::Stub.stub(:new, mock_stub) do
        Google::Streetview::Publish::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Streetview::Publish.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.create_photo(photo)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_photo' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Streetview::Publish::V1::StreetViewPublishServiceClient#get_photo."

    it 'invokes get_photo without error' do
      # Create request parameters
      photo_id = ''
      view = :BASIC

      # Create expected grpc response
      download_url = "downloadUrl1109408056"
      thumbnail_url = "thumbnailUrl1825632156"
      share_link = "shareLink-1788203942"
      view_count = 1534353675
      expected_response = {
        download_url: download_url,
        thumbnail_url: thumbnail_url,
        share_link: share_link,
        view_count: view_count
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Streetview::Publish::V1::Photo)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Streetview::Publish::V1::GetPhotoRequest, request)
        assert_equal(photo_id, request.photo_id)
        assert_equal(view, request.view)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_photo, mock_method)

      # Mock auth layer
      mock_credentials = MockStreetViewPublishServiceCredentials_v1.new("get_photo")

      Google::Streetview::Publish::V1::StreetViewPublishService::Stub.stub(:new, mock_stub) do
        Google::Streetview::Publish::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Streetview::Publish.new(version: :v1)

          # Call method
          response = client.get_photo(photo_id, view)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_photo(photo_id, view) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_photo with error' do
      # Create request parameters
      photo_id = ''
      view = :BASIC

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Streetview::Publish::V1::GetPhotoRequest, request)
        assert_equal(photo_id, request.photo_id)
        assert_equal(view, request.view)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_photo, mock_method)

      # Mock auth layer
      mock_credentials = MockStreetViewPublishServiceCredentials_v1.new("get_photo")

      Google::Streetview::Publish::V1::StreetViewPublishService::Stub.stub(:new, mock_stub) do
        Google::Streetview::Publish::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Streetview::Publish.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.get_photo(photo_id, view)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'batch_get_photos' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Streetview::Publish::V1::StreetViewPublishServiceClient#batch_get_photos."

    it 'invokes batch_get_photos without error' do
      # Create request parameters
      photo_ids = []
      view = :BASIC

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Streetview::Publish::V1::BatchGetPhotosResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Streetview::Publish::V1::BatchGetPhotosRequest, request)
        assert_equal(photo_ids, request.photo_ids)
        assert_equal(view, request.view)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:batch_get_photos, mock_method)

      # Mock auth layer
      mock_credentials = MockStreetViewPublishServiceCredentials_v1.new("batch_get_photos")

      Google::Streetview::Publish::V1::StreetViewPublishService::Stub.stub(:new, mock_stub) do
        Google::Streetview::Publish::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Streetview::Publish.new(version: :v1)

          # Call method
          response = client.batch_get_photos(photo_ids, view)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.batch_get_photos(photo_ids, view) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes batch_get_photos with error' do
      # Create request parameters
      photo_ids = []
      view = :BASIC

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Streetview::Publish::V1::BatchGetPhotosRequest, request)
        assert_equal(photo_ids, request.photo_ids)
        assert_equal(view, request.view)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:batch_get_photos, mock_method)

      # Mock auth layer
      mock_credentials = MockStreetViewPublishServiceCredentials_v1.new("batch_get_photos")

      Google::Streetview::Publish::V1::StreetViewPublishService::Stub.stub(:new, mock_stub) do
        Google::Streetview::Publish::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Streetview::Publish.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.batch_get_photos(photo_ids, view)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_photos' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Streetview::Publish::V1::StreetViewPublishServiceClient#list_photos."

    it 'invokes list_photos without error' do
      # Create request parameters
      view = :BASIC
      filter = ''

      # Create expected grpc response
      next_page_token = ""
      photos_element = {}
      photos = [photos_element]
      expected_response = { next_page_token: next_page_token, photos: photos }
      expected_response = Google::Gax::to_proto(expected_response, Google::Streetview::Publish::V1::ListPhotosResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Streetview::Publish::V1::ListPhotosRequest, request)
        assert_equal(view, request.view)
        assert_equal(filter, request.filter)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_photos, mock_method)

      # Mock auth layer
      mock_credentials = MockStreetViewPublishServiceCredentials_v1.new("list_photos")

      Google::Streetview::Publish::V1::StreetViewPublishService::Stub.stub(:new, mock_stub) do
        Google::Streetview::Publish::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Streetview::Publish.new(version: :v1)

          # Call method
          response = client.list_photos(view, filter)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.photos.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_photos with error' do
      # Create request parameters
      view = :BASIC
      filter = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Streetview::Publish::V1::ListPhotosRequest, request)
        assert_equal(view, request.view)
        assert_equal(filter, request.filter)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_photos, mock_method)

      # Mock auth layer
      mock_credentials = MockStreetViewPublishServiceCredentials_v1.new("list_photos")

      Google::Streetview::Publish::V1::StreetViewPublishService::Stub.stub(:new, mock_stub) do
        Google::Streetview::Publish::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Streetview::Publish.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.list_photos(view, filter)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_photo' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Streetview::Publish::V1::StreetViewPublishServiceClient#update_photo."

    it 'invokes update_photo without error' do
      # Create request parameters
      photo = {}
      update_mask = {}

      # Create expected grpc response
      download_url = "downloadUrl1109408056"
      thumbnail_url = "thumbnailUrl1825632156"
      share_link = "shareLink-1788203942"
      view_count = 1534353675
      expected_response = {
        download_url: download_url,
        thumbnail_url: thumbnail_url,
        share_link: share_link,
        view_count: view_count
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Streetview::Publish::V1::Photo)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Streetview::Publish::V1::UpdatePhotoRequest, request)
        assert_equal(Google::Gax::to_proto(photo, Google::Streetview::Publish::V1::Photo), request.photo)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:update_photo, mock_method)

      # Mock auth layer
      mock_credentials = MockStreetViewPublishServiceCredentials_v1.new("update_photo")

      Google::Streetview::Publish::V1::StreetViewPublishService::Stub.stub(:new, mock_stub) do
        Google::Streetview::Publish::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Streetview::Publish.new(version: :v1)

          # Call method
          response = client.update_photo(photo, update_mask)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.update_photo(photo, update_mask) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes update_photo with error' do
      # Create request parameters
      photo = {}
      update_mask = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Streetview::Publish::V1::UpdatePhotoRequest, request)
        assert_equal(Google::Gax::to_proto(photo, Google::Streetview::Publish::V1::Photo), request.photo)
        assert_equal(Google::Gax::to_proto(update_mask, Google::Protobuf::FieldMask), request.update_mask)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:update_photo, mock_method)

      # Mock auth layer
      mock_credentials = MockStreetViewPublishServiceCredentials_v1.new("update_photo")

      Google::Streetview::Publish::V1::StreetViewPublishService::Stub.stub(:new, mock_stub) do
        Google::Streetview::Publish::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Streetview::Publish.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.update_photo(photo, update_mask)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'batch_update_photos' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Streetview::Publish::V1::StreetViewPublishServiceClient#batch_update_photos."

    it 'invokes batch_update_photos without error' do
      # Create request parameters
      update_photo_requests = []

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Streetview::Publish::V1::BatchUpdatePhotosResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Streetview::Publish::V1::BatchUpdatePhotosRequest, request)
        update_photo_requests = update_photo_requests.map do |req|
          Google::Gax::to_proto(req, Google::Streetview::Publish::V1::UpdatePhotoRequest)
        end
        assert_equal(update_photo_requests, request.update_photo_requests)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:batch_update_photos, mock_method)

      # Mock auth layer
      mock_credentials = MockStreetViewPublishServiceCredentials_v1.new("batch_update_photos")

      Google::Streetview::Publish::V1::StreetViewPublishService::Stub.stub(:new, mock_stub) do
        Google::Streetview::Publish::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Streetview::Publish.new(version: :v1)

          # Call method
          response = client.batch_update_photos(update_photo_requests)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.batch_update_photos(update_photo_requests) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes batch_update_photos with error' do
      # Create request parameters
      update_photo_requests = []

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Streetview::Publish::V1::BatchUpdatePhotosRequest, request)
        update_photo_requests = update_photo_requests.map do |req|
          Google::Gax::to_proto(req, Google::Streetview::Publish::V1::UpdatePhotoRequest)
        end
        assert_equal(update_photo_requests, request.update_photo_requests)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:batch_update_photos, mock_method)

      # Mock auth layer
      mock_credentials = MockStreetViewPublishServiceCredentials_v1.new("batch_update_photos")

      Google::Streetview::Publish::V1::StreetViewPublishService::Stub.stub(:new, mock_stub) do
        Google::Streetview::Publish::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Streetview::Publish.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.batch_update_photos(update_photo_requests)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_photo' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Streetview::Publish::V1::StreetViewPublishServiceClient#delete_photo."

    it 'invokes delete_photo without error' do
      # Create request parameters
      photo_id = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Streetview::Publish::V1::DeletePhotoRequest, request)
        assert_equal(photo_id, request.photo_id)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_photo, mock_method)

      # Mock auth layer
      mock_credentials = MockStreetViewPublishServiceCredentials_v1.new("delete_photo")

      Google::Streetview::Publish::V1::StreetViewPublishService::Stub.stub(:new, mock_stub) do
        Google::Streetview::Publish::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Streetview::Publish.new(version: :v1)

          # Call method
          response = client.delete_photo(photo_id)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.delete_photo(photo_id) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes delete_photo with error' do
      # Create request parameters
      photo_id = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Streetview::Publish::V1::DeletePhotoRequest, request)
        assert_equal(photo_id, request.photo_id)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_photo, mock_method)

      # Mock auth layer
      mock_credentials = MockStreetViewPublishServiceCredentials_v1.new("delete_photo")

      Google::Streetview::Publish::V1::StreetViewPublishService::Stub.stub(:new, mock_stub) do
        Google::Streetview::Publish::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Streetview::Publish.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.delete_photo(photo_id)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'batch_delete_photos' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Streetview::Publish::V1::StreetViewPublishServiceClient#batch_delete_photos."

    it 'invokes batch_delete_photos without error' do
      # Create request parameters
      photo_ids = []

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Streetview::Publish::V1::BatchDeletePhotosResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Streetview::Publish::V1::BatchDeletePhotosRequest, request)
        assert_equal(photo_ids, request.photo_ids)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:batch_delete_photos, mock_method)

      # Mock auth layer
      mock_credentials = MockStreetViewPublishServiceCredentials_v1.new("batch_delete_photos")

      Google::Streetview::Publish::V1::StreetViewPublishService::Stub.stub(:new, mock_stub) do
        Google::Streetview::Publish::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Streetview::Publish.new(version: :v1)

          # Call method
          response = client.batch_delete_photos(photo_ids)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.batch_delete_photos(photo_ids) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes batch_delete_photos with error' do
      # Create request parameters
      photo_ids = []

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Streetview::Publish::V1::BatchDeletePhotosRequest, request)
        assert_equal(photo_ids, request.photo_ids)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:batch_delete_photos, mock_method)

      # Mock auth layer
      mock_credentials = MockStreetViewPublishServiceCredentials_v1.new("batch_delete_photos")

      Google::Streetview::Publish::V1::StreetViewPublishService::Stub.stub(:new, mock_stub) do
        Google::Streetview::Publish::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Streetview::Publish.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.batch_delete_photos(photo_ids)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end