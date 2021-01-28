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

require "google/cloud/example/library"
require "google/cloud/example/library/v1/library_service_client"
require "google/example/library/v1/library_services_pb"

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

class MockLibraryServiceCredentials_v1 < Google::Cloud::Example::Library::V1::Credentials
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

describe Google::Cloud::Example::Library::V1::LibraryServiceClient do

  describe 'create_shelf' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Example::Library::V1::LibraryServiceClient#create_shelf."

    it 'invokes create_shelf without error' do
      # Create request parameters
      shelf = {}

      # Create expected grpc response
      name = "name3373707"
      theme = "theme110327241"
      expected_response = { name: name, theme: theme }
      expected_response = Google::Gax::to_proto(expected_response, Google::Example::Library::V1::Shelf)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Example::Library::V1::CreateShelfRequest, request)
        assert_equal(Google::Gax::to_proto(shelf, Google::Example::Library::V1::Shelf), request.shelf)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:create_shelf, mock_method)

      # Mock auth layer
      mock_credentials = MockLibraryServiceCredentials_v1.new("create_shelf")

      Google::Example::Library::V1::LibraryService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Example::Library::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Example::Library.new(version: :v1)

          # Call method
          response = client.create_shelf(shelf)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_shelf(shelf) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_shelf with error' do
      # Create request parameters
      shelf = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Example::Library::V1::CreateShelfRequest, request)
        assert_equal(Google::Gax::to_proto(shelf, Google::Example::Library::V1::Shelf), request.shelf)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:create_shelf, mock_method)

      # Mock auth layer
      mock_credentials = MockLibraryServiceCredentials_v1.new("create_shelf")

      Google::Example::Library::V1::LibraryService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Example::Library::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Example::Library.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.create_shelf(shelf)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_shelf' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Example::Library::V1::LibraryServiceClient#get_shelf."

    it 'invokes get_shelf without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Example::Library::V1::LibraryServiceClient.shelf_path("[SHELF]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      theme = "theme110327241"
      expected_response = { name: name_2, theme: theme }
      expected_response = Google::Gax::to_proto(expected_response, Google::Example::Library::V1::Shelf)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Example::Library::V1::GetShelfRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_shelf, mock_method)

      # Mock auth layer
      mock_credentials = MockLibraryServiceCredentials_v1.new("get_shelf")

      Google::Example::Library::V1::LibraryService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Example::Library::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Example::Library.new(version: :v1)

          # Call method
          response = client.get_shelf(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_shelf(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_shelf with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Example::Library::V1::LibraryServiceClient.shelf_path("[SHELF]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Example::Library::V1::GetShelfRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_shelf, mock_method)

      # Mock auth layer
      mock_credentials = MockLibraryServiceCredentials_v1.new("get_shelf")

      Google::Example::Library::V1::LibraryService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Example::Library::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Example::Library.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.get_shelf(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_shelves' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Example::Library::V1::LibraryServiceClient#list_shelves."

    it 'invokes list_shelves without error' do
      # Create expected grpc response
      next_page_token = ""
      shelves_element = {}
      shelves = [shelves_element]
      expected_response = { next_page_token: next_page_token, shelves: shelves }
      expected_response = Google::Gax::to_proto(expected_response, Google::Example::Library::V1::ListShelvesResponse)

      # Mock Grpc layer
      mock_method = proc do
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_shelves, mock_method)

      # Mock auth layer
      mock_credentials = MockLibraryServiceCredentials_v1.new("list_shelves")

      Google::Example::Library::V1::LibraryService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Example::Library::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Example::Library.new(version: :v1)

          # Call method
          response = client.list_shelves

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.shelves.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_shelves with error' do
      # Mock Grpc layer
      mock_method = proc do
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_shelves, mock_method)

      # Mock auth layer
      mock_credentials = MockLibraryServiceCredentials_v1.new("list_shelves")

      Google::Example::Library::V1::LibraryService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Example::Library::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Example::Library.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.list_shelves
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_shelf' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Example::Library::V1::LibraryServiceClient#delete_shelf."

    it 'invokes delete_shelf without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Example::Library::V1::LibraryServiceClient.shelf_path("[SHELF]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Example::Library::V1::DeleteShelfRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_shelf, mock_method)

      # Mock auth layer
      mock_credentials = MockLibraryServiceCredentials_v1.new("delete_shelf")

      Google::Example::Library::V1::LibraryService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Example::Library::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Example::Library.new(version: :v1)

          # Call method
          response = client.delete_shelf(formatted_name)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.delete_shelf(formatted_name) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes delete_shelf with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Example::Library::V1::LibraryServiceClient.shelf_path("[SHELF]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Example::Library::V1::DeleteShelfRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_shelf, mock_method)

      # Mock auth layer
      mock_credentials = MockLibraryServiceCredentials_v1.new("delete_shelf")

      Google::Example::Library::V1::LibraryService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Example::Library::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Example::Library.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.delete_shelf(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'merge_shelves' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Example::Library::V1::LibraryServiceClient#merge_shelves."

    it 'invokes merge_shelves without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Example::Library::V1::LibraryServiceClient.shelf_path("[SHELF]")
      other_shelf_name = ''

      # Create expected grpc response
      name_2 = "name2-1052831874"
      theme = "theme110327241"
      expected_response = { name: name_2, theme: theme }
      expected_response = Google::Gax::to_proto(expected_response, Google::Example::Library::V1::Shelf)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Example::Library::V1::MergeShelvesRequest, request)
        assert_equal(formatted_name, request.name)
        assert_equal(other_shelf_name, request.other_shelf_name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:merge_shelves, mock_method)

      # Mock auth layer
      mock_credentials = MockLibraryServiceCredentials_v1.new("merge_shelves")

      Google::Example::Library::V1::LibraryService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Example::Library::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Example::Library.new(version: :v1)

          # Call method
          response = client.merge_shelves(formatted_name, other_shelf_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.merge_shelves(formatted_name, other_shelf_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes merge_shelves with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Example::Library::V1::LibraryServiceClient.shelf_path("[SHELF]")
      other_shelf_name = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Example::Library::V1::MergeShelvesRequest, request)
        assert_equal(formatted_name, request.name)
        assert_equal(other_shelf_name, request.other_shelf_name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:merge_shelves, mock_method)

      # Mock auth layer
      mock_credentials = MockLibraryServiceCredentials_v1.new("merge_shelves")

      Google::Example::Library::V1::LibraryService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Example::Library::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Example::Library.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.merge_shelves(formatted_name, other_shelf_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_book' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Example::Library::V1::LibraryServiceClient#create_book."

    it 'invokes create_book without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Example::Library::V1::LibraryServiceClient.shelf_path("[SHELF]")
      book = {}

      # Create expected grpc response
      name_2 = "name2-1052831874"
      author = "author-1406328437"
      title = "title110371416"
      read = true
      expected_response = {
        name: name_2,
        author: author,
        title: title,
        read: read
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Example::Library::V1::Book)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Example::Library::V1::CreateBookRequest, request)
        assert_equal(formatted_name, request.name)
        assert_equal(Google::Gax::to_proto(book, Google::Example::Library::V1::Book), request.book)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:create_book, mock_method)

      # Mock auth layer
      mock_credentials = MockLibraryServiceCredentials_v1.new("create_book")

      Google::Example::Library::V1::LibraryService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Example::Library::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Example::Library.new(version: :v1)

          # Call method
          response = client.create_book(formatted_name, book)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.create_book(formatted_name, book) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes create_book with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Example::Library::V1::LibraryServiceClient.shelf_path("[SHELF]")
      book = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Example::Library::V1::CreateBookRequest, request)
        assert_equal(formatted_name, request.name)
        assert_equal(Google::Gax::to_proto(book, Google::Example::Library::V1::Book), request.book)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:create_book, mock_method)

      # Mock auth layer
      mock_credentials = MockLibraryServiceCredentials_v1.new("create_book")

      Google::Example::Library::V1::LibraryService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Example::Library::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Example::Library.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.create_book(formatted_name, book)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_book' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Example::Library::V1::LibraryServiceClient#get_book."

    it 'invokes get_book without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Example::Library::V1::LibraryServiceClient.book_path("[SHELF]", "[BOOK]")

      # Create expected grpc response
      name_2 = "name2-1052831874"
      author = "author-1406328437"
      title = "title110371416"
      read = true
      expected_response = {
        name: name_2,
        author: author,
        title: title,
        read: read
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Example::Library::V1::Book)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Example::Library::V1::GetBookRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_book, mock_method)

      # Mock auth layer
      mock_credentials = MockLibraryServiceCredentials_v1.new("get_book")

      Google::Example::Library::V1::LibraryService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Example::Library::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Example::Library.new(version: :v1)

          # Call method
          response = client.get_book(formatted_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_book(formatted_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_book with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Example::Library::V1::LibraryServiceClient.book_path("[SHELF]", "[BOOK]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Example::Library::V1::GetBookRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:get_book, mock_method)

      # Mock auth layer
      mock_credentials = MockLibraryServiceCredentials_v1.new("get_book")

      Google::Example::Library::V1::LibraryService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Example::Library::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Example::Library.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.get_book(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'list_books' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Example::Library::V1::LibraryServiceClient#list_books."

    it 'invokes list_books without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Example::Library::V1::LibraryServiceClient.shelf_path("[SHELF]")

      # Create expected grpc response
      next_page_token = ""
      books_element = {}
      books = [books_element]
      expected_response = { next_page_token: next_page_token, books: books }
      expected_response = Google::Gax::to_proto(expected_response, Google::Example::Library::V1::ListBooksResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Example::Library::V1::ListBooksRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_books, mock_method)

      # Mock auth layer
      mock_credentials = MockLibraryServiceCredentials_v1.new("list_books")

      Google::Example::Library::V1::LibraryService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Example::Library::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Example::Library.new(version: :v1)

          # Call method
          response = client.list_books(formatted_name)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.books.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_books with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Example::Library::V1::LibraryServiceClient.shelf_path("[SHELF]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Example::Library::V1::ListBooksRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:list_books, mock_method)

      # Mock auth layer
      mock_credentials = MockLibraryServiceCredentials_v1.new("list_books")

      Google::Example::Library::V1::LibraryService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Example::Library::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Example::Library.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.list_books(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_book' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Example::Library::V1::LibraryServiceClient#delete_book."

    it 'invokes delete_book without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Example::Library::V1::LibraryServiceClient.book_path("[SHELF]", "[BOOK]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Example::Library::V1::DeleteBookRequest, request)
        assert_equal(formatted_name, request.name)
        OpenStruct.new(execute: nil)
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_book, mock_method)

      # Mock auth layer
      mock_credentials = MockLibraryServiceCredentials_v1.new("delete_book")

      Google::Example::Library::V1::LibraryService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Example::Library::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Example::Library.new(version: :v1)

          # Call method
          response = client.delete_book(formatted_name)

          # Verify the response
          assert_nil(response)

          # Call method with block
          client.delete_book(formatted_name) do |response, operation|
            # Verify the response
            assert_nil(response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes delete_book with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Example::Library::V1::LibraryServiceClient.book_path("[SHELF]", "[BOOK]")

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Example::Library::V1::DeleteBookRequest, request)
        assert_equal(formatted_name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:delete_book, mock_method)

      # Mock auth layer
      mock_credentials = MockLibraryServiceCredentials_v1.new("delete_book")

      Google::Example::Library::V1::LibraryService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Example::Library::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Example::Library.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.delete_book(formatted_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_book' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Example::Library::V1::LibraryServiceClient#update_book."

    it 'invokes update_book without error' do
      # Create request parameters
      name = ''
      book = {}

      # Create expected grpc response
      name_2 = "name2-1052831874"
      author = "author-1406328437"
      title = "title110371416"
      read = true
      expected_response = {
        name: name_2,
        author: author,
        title: title,
        read: read
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Example::Library::V1::Book)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Example::Library::V1::UpdateBookRequest, request)
        assert_equal(name, request.name)
        assert_equal(Google::Gax::to_proto(book, Google::Example::Library::V1::Book), request.book)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:update_book, mock_method)

      # Mock auth layer
      mock_credentials = MockLibraryServiceCredentials_v1.new("update_book")

      Google::Example::Library::V1::LibraryService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Example::Library::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Example::Library.new(version: :v1)

          # Call method
          response = client.update_book(name, book)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.update_book(name, book) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes update_book with error' do
      # Create request parameters
      name = ''
      book = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Example::Library::V1::UpdateBookRequest, request)
        assert_equal(name, request.name)
        assert_equal(Google::Gax::to_proto(book, Google::Example::Library::V1::Book), request.book)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:update_book, mock_method)

      # Mock auth layer
      mock_credentials = MockLibraryServiceCredentials_v1.new("update_book")

      Google::Example::Library::V1::LibraryService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Example::Library::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Example::Library.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.update_book(name, book)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'move_book' do
    custom_error = CustomTestError_v1.new "Custom test error for Google::Cloud::Example::Library::V1::LibraryServiceClient#move_book."

    it 'invokes move_book without error' do
      # Create request parameters
      formatted_name = Google::Cloud::Example::Library::V1::LibraryServiceClient.book_path("[SHELF]", "[BOOK]")
      other_shelf_name = ''

      # Create expected grpc response
      name_2 = "name2-1052831874"
      author = "author-1406328437"
      title = "title110371416"
      read = true
      expected_response = {
        name: name_2,
        author: author,
        title: title,
        read: read
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Example::Library::V1::Book)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Example::Library::V1::MoveBookRequest, request)
        assert_equal(formatted_name, request.name)
        assert_equal(other_shelf_name, request.other_shelf_name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v1.new(:move_book, mock_method)

      # Mock auth layer
      mock_credentials = MockLibraryServiceCredentials_v1.new("move_book")

      Google::Example::Library::V1::LibraryService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Example::Library::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Example::Library.new(version: :v1)

          # Call method
          response = client.move_book(formatted_name, other_shelf_name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.move_book(formatted_name, other_shelf_name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes move_book with error' do
      # Create request parameters
      formatted_name = Google::Cloud::Example::Library::V1::LibraryServiceClient.book_path("[SHELF]", "[BOOK]")
      other_shelf_name = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Example::Library::V1::MoveBookRequest, request)
        assert_equal(formatted_name, request.name)
        assert_equal(other_shelf_name, request.other_shelf_name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v1.new(:move_book, mock_method)

      # Mock auth layer
      mock_credentials = MockLibraryServiceCredentials_v1.new("move_book")

      Google::Example::Library::V1::LibraryService::Stub.stub(:new, mock_stub) do
        Google::Cloud::Example::Library::V1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Example::Library.new(version: :v1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v1 do
            client.move_book(formatted_name, other_shelf_name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end