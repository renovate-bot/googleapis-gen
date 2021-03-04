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

require "google/cloud/dialogflow"
require "google/cloud/dialogflow/v2beta1/documents_client"
require "google/cloud/dialogflow/v2beta1/document_services_pb"
require "google/longrunning/operations_pb"

class CustomTestError_v2beta1 < StandardError; end

# Mock for the GRPC::ClientStub class.
class MockGrpcClientStub_v2beta1

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

class MockDocumentsCredentials_v2beta1 < Google::Cloud::Dialogflow::V2beta1::Credentials
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

describe Google::Cloud::Dialogflow::V2beta1::DocumentsClient do

  describe 'list_documents' do
    custom_error = CustomTestError_v2beta1.new "Custom test error for Google::Cloud::Dialogflow::V2beta1::DocumentsClient#list_documents."

    it 'invokes list_documents without error' do
      # Create request parameters
      parent = ''

      # Create expected grpc response
      next_page_token = ""
      documents_element = {}
      documents = [documents_element]
      expected_response = { next_page_token: next_page_token, documents: documents }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::V2beta1::ListDocumentsResponse)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::V2beta1::ListDocumentsRequest, request)
        assert_equal(parent, request.parent)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:list_documents, mock_method)

      # Mock auth layer
      mock_credentials = MockDocumentsCredentials_v2beta1.new("list_documents")

      Google::Cloud::Dialogflow::V2beta1::Documents::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Documents.new(version: :v2beta1)

          # Call method
          response = client.list_documents(parent)

          # Verify the response
          assert(response.instance_of?(Google::Gax::PagedEnumerable))
          assert_equal(expected_response, response.page.response)
          assert_nil(response.next_page)
          assert_equal(expected_response.documents.to_a, response.to_a)
        end
      end
    end

    it 'invokes list_documents with error' do
      # Create request parameters
      parent = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::V2beta1::ListDocumentsRequest, request)
        assert_equal(parent, request.parent)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:list_documents, mock_method)

      # Mock auth layer
      mock_credentials = MockDocumentsCredentials_v2beta1.new("list_documents")

      Google::Cloud::Dialogflow::V2beta1::Documents::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Documents.new(version: :v2beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2beta1 do
            client.list_documents(parent)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'get_document' do
    custom_error = CustomTestError_v2beta1.new "Custom test error for Google::Cloud::Dialogflow::V2beta1::DocumentsClient#get_document."

    it 'invokes get_document without error' do
      # Create request parameters
      name = ''

      # Create expected grpc response
      name_2 = "name2-1052831874"
      display_name = "displayName1615086568"
      mime_type = "mimeType-196041627"
      content_uri = "contentUri-388807514"
      enable_auto_reload = false
      expected_response = {
        name: name_2,
        display_name: display_name,
        mime_type: mime_type,
        content_uri: content_uri,
        enable_auto_reload: enable_auto_reload
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::V2beta1::Document)

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::V2beta1::GetDocumentRequest, request)
        assert_equal(name, request.name)
        OpenStruct.new(execute: expected_response)
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:get_document, mock_method)

      # Mock auth layer
      mock_credentials = MockDocumentsCredentials_v2beta1.new("get_document")

      Google::Cloud::Dialogflow::V2beta1::Documents::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Documents.new(version: :v2beta1)

          # Call method
          response = client.get_document(name)

          # Verify the response
          assert_equal(expected_response, response)

          # Call method with block
          client.get_document(name) do |response, operation|
            # Verify the response
            assert_equal(expected_response, response)
            refute_nil(operation)
          end
        end
      end
    end

    it 'invokes get_document with error' do
      # Create request parameters
      name = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::V2beta1::GetDocumentRequest, request)
        assert_equal(name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:get_document, mock_method)

      # Mock auth layer
      mock_credentials = MockDocumentsCredentials_v2beta1.new("get_document")

      Google::Cloud::Dialogflow::V2beta1::Documents::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Documents.new(version: :v2beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2beta1 do
            client.get_document(name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'create_document' do
    custom_error = CustomTestError_v2beta1.new "Custom test error for Google::Cloud::Dialogflow::V2beta1::DocumentsClient#create_document."

    it 'invokes create_document without error' do
      # Create request parameters
      parent = ''
      document = {}

      # Create expected grpc response
      name = "name3373707"
      display_name = "displayName1615086568"
      mime_type = "mimeType-196041627"
      content_uri = "contentUri-388807514"
      enable_auto_reload = false
      expected_response = {
        name: name,
        display_name: display_name,
        mime_type: mime_type,
        content_uri: content_uri,
        enable_auto_reload: enable_auto_reload
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::V2beta1::Document)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/create_document_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::V2beta1::CreateDocumentRequest, request)
        assert_equal(parent, request.parent)
        assert_equal(Google::Gax::to_proto(document, Google::Cloud::Dialogflow::V2beta1::Document), request.document)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:create_document, mock_method)

      # Mock auth layer
      mock_credentials = MockDocumentsCredentials_v2beta1.new("create_document")

      Google::Cloud::Dialogflow::V2beta1::Documents::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Documents.new(version: :v2beta1)

          # Call method
          response = client.create_document(parent, document)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes create_document and returns an operation error.' do
      # Create request parameters
      parent = ''
      document = {}

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Dialogflow::V2beta1::DocumentsClient#create_document.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/create_document_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::V2beta1::CreateDocumentRequest, request)
        assert_equal(parent, request.parent)
        assert_equal(Google::Gax::to_proto(document, Google::Cloud::Dialogflow::V2beta1::Document), request.document)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:create_document, mock_method)

      # Mock auth layer
      mock_credentials = MockDocumentsCredentials_v2beta1.new("create_document")

      Google::Cloud::Dialogflow::V2beta1::Documents::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Documents.new(version: :v2beta1)

          # Call method
          response = client.create_document(parent, document)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes create_document with error' do
      # Create request parameters
      parent = ''
      document = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::V2beta1::CreateDocumentRequest, request)
        assert_equal(parent, request.parent)
        assert_equal(Google::Gax::to_proto(document, Google::Cloud::Dialogflow::V2beta1::Document), request.document)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:create_document, mock_method)

      # Mock auth layer
      mock_credentials = MockDocumentsCredentials_v2beta1.new("create_document")

      Google::Cloud::Dialogflow::V2beta1::Documents::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Documents.new(version: :v2beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2beta1 do
            client.create_document(parent, document)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'import_documents' do
    custom_error = CustomTestError_v2beta1.new "Custom test error for Google::Cloud::Dialogflow::V2beta1::DocumentsClient#import_documents."

    it 'invokes import_documents without error' do
      # Create request parameters
      parent = ''
      document_template = {}

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::V2beta1::ImportDocumentsResponse)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/import_documents_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::V2beta1::ImportDocumentsRequest, request)
        assert_equal(parent, request.parent)
        assert_equal(Google::Gax::to_proto(document_template, Google::Cloud::Dialogflow::V2beta1::ImportDocumentTemplate), request.document_template)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:import_documents, mock_method)

      # Mock auth layer
      mock_credentials = MockDocumentsCredentials_v2beta1.new("import_documents")

      Google::Cloud::Dialogflow::V2beta1::Documents::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Documents.new(version: :v2beta1)

          # Call method
          response = client.import_documents(parent, document_template)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes import_documents and returns an operation error.' do
      # Create request parameters
      parent = ''
      document_template = {}

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Dialogflow::V2beta1::DocumentsClient#import_documents.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/import_documents_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::V2beta1::ImportDocumentsRequest, request)
        assert_equal(parent, request.parent)
        assert_equal(Google::Gax::to_proto(document_template, Google::Cloud::Dialogflow::V2beta1::ImportDocumentTemplate), request.document_template)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:import_documents, mock_method)

      # Mock auth layer
      mock_credentials = MockDocumentsCredentials_v2beta1.new("import_documents")

      Google::Cloud::Dialogflow::V2beta1::Documents::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Documents.new(version: :v2beta1)

          # Call method
          response = client.import_documents(parent, document_template)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes import_documents with error' do
      # Create request parameters
      parent = ''
      document_template = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::V2beta1::ImportDocumentsRequest, request)
        assert_equal(parent, request.parent)
        assert_equal(Google::Gax::to_proto(document_template, Google::Cloud::Dialogflow::V2beta1::ImportDocumentTemplate), request.document_template)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:import_documents, mock_method)

      # Mock auth layer
      mock_credentials = MockDocumentsCredentials_v2beta1.new("import_documents")

      Google::Cloud::Dialogflow::V2beta1::Documents::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Documents.new(version: :v2beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2beta1 do
            client.import_documents(parent, document_template)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'delete_document' do
    custom_error = CustomTestError_v2beta1.new "Custom test error for Google::Cloud::Dialogflow::V2beta1::DocumentsClient#delete_document."

    it 'invokes delete_document without error' do
      # Create request parameters
      name = ''

      # Create expected grpc response
      expected_response = {}
      expected_response = Google::Gax::to_proto(expected_response, Google::Protobuf::Empty)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/delete_document_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::V2beta1::DeleteDocumentRequest, request)
        assert_equal(name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:delete_document, mock_method)

      # Mock auth layer
      mock_credentials = MockDocumentsCredentials_v2beta1.new("delete_document")

      Google::Cloud::Dialogflow::V2beta1::Documents::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Documents.new(version: :v2beta1)

          # Call method
          response = client.delete_document(name)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes delete_document and returns an operation error.' do
      # Create request parameters
      name = ''

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Dialogflow::V2beta1::DocumentsClient#delete_document.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/delete_document_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::V2beta1::DeleteDocumentRequest, request)
        assert_equal(name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:delete_document, mock_method)

      # Mock auth layer
      mock_credentials = MockDocumentsCredentials_v2beta1.new("delete_document")

      Google::Cloud::Dialogflow::V2beta1::Documents::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Documents.new(version: :v2beta1)

          # Call method
          response = client.delete_document(name)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes delete_document with error' do
      # Create request parameters
      name = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::V2beta1::DeleteDocumentRequest, request)
        assert_equal(name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:delete_document, mock_method)

      # Mock auth layer
      mock_credentials = MockDocumentsCredentials_v2beta1.new("delete_document")

      Google::Cloud::Dialogflow::V2beta1::Documents::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Documents.new(version: :v2beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2beta1 do
            client.delete_document(name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'update_document' do
    custom_error = CustomTestError_v2beta1.new "Custom test error for Google::Cloud::Dialogflow::V2beta1::DocumentsClient#update_document."

    it 'invokes update_document without error' do
      # Create request parameters
      document = {}

      # Create expected grpc response
      name = "name3373707"
      display_name = "displayName1615086568"
      mime_type = "mimeType-196041627"
      content_uri = "contentUri-388807514"
      enable_auto_reload = false
      expected_response = {
        name: name,
        display_name: display_name,
        mime_type: mime_type,
        content_uri: content_uri,
        enable_auto_reload: enable_auto_reload
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::V2beta1::Document)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/update_document_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::V2beta1::UpdateDocumentRequest, request)
        assert_equal(Google::Gax::to_proto(document, Google::Cloud::Dialogflow::V2beta1::Document), request.document)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:update_document, mock_method)

      # Mock auth layer
      mock_credentials = MockDocumentsCredentials_v2beta1.new("update_document")

      Google::Cloud::Dialogflow::V2beta1::Documents::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Documents.new(version: :v2beta1)

          # Call method
          response = client.update_document(document)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes update_document and returns an operation error.' do
      # Create request parameters
      document = {}

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Dialogflow::V2beta1::DocumentsClient#update_document.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/update_document_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::V2beta1::UpdateDocumentRequest, request)
        assert_equal(Google::Gax::to_proto(document, Google::Cloud::Dialogflow::V2beta1::Document), request.document)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:update_document, mock_method)

      # Mock auth layer
      mock_credentials = MockDocumentsCredentials_v2beta1.new("update_document")

      Google::Cloud::Dialogflow::V2beta1::Documents::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Documents.new(version: :v2beta1)

          # Call method
          response = client.update_document(document)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes update_document with error' do
      # Create request parameters
      document = {}

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::V2beta1::UpdateDocumentRequest, request)
        assert_equal(Google::Gax::to_proto(document, Google::Cloud::Dialogflow::V2beta1::Document), request.document)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:update_document, mock_method)

      # Mock auth layer
      mock_credentials = MockDocumentsCredentials_v2beta1.new("update_document")

      Google::Cloud::Dialogflow::V2beta1::Documents::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Documents.new(version: :v2beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2beta1 do
            client.update_document(document)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end

  describe 'reload_document' do
    custom_error = CustomTestError_v2beta1.new "Custom test error for Google::Cloud::Dialogflow::V2beta1::DocumentsClient#reload_document."

    it 'invokes reload_document without error' do
      # Create request parameters
      name = ''

      # Create expected grpc response
      name_2 = "name2-1052831874"
      display_name = "displayName1615086568"
      mime_type = "mimeType-196041627"
      content_uri = "contentUri-388807514"
      enable_auto_reload = false
      expected_response = {
        name: name_2,
        display_name: display_name,
        mime_type: mime_type,
        content_uri: content_uri,
        enable_auto_reload: enable_auto_reload
      }
      expected_response = Google::Gax::to_proto(expected_response, Google::Cloud::Dialogflow::V2beta1::Document)
      result = Google::Protobuf::Any.new
      result.pack(expected_response)
      operation = Google::Longrunning::Operation.new(
        name: 'operations/reload_document_test',
        done: true,
        response: result
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::V2beta1::ReloadDocumentRequest, request)
        assert_equal(name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:reload_document, mock_method)

      # Mock auth layer
      mock_credentials = MockDocumentsCredentials_v2beta1.new("reload_document")

      Google::Cloud::Dialogflow::V2beta1::Documents::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Documents.new(version: :v2beta1)

          # Call method
          response = client.reload_document(name)

          # Verify the response
          assert_equal(expected_response, response.response)
        end
      end
    end

    it 'invokes reload_document and returns an operation error.' do
      # Create request parameters
      name = ''

      # Create expected grpc response
      operation_error = Google::Rpc::Status.new(
        message: 'Operation error for Google::Cloud::Dialogflow::V2beta1::DocumentsClient#reload_document.'
      )
      operation = Google::Longrunning::Operation.new(
        name: 'operations/reload_document_test',
        done: true,
        error: operation_error
      )

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::V2beta1::ReloadDocumentRequest, request)
        assert_equal(name, request.name)
        OpenStruct.new(execute: operation)
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:reload_document, mock_method)

      # Mock auth layer
      mock_credentials = MockDocumentsCredentials_v2beta1.new("reload_document")

      Google::Cloud::Dialogflow::V2beta1::Documents::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Documents.new(version: :v2beta1)

          # Call method
          response = client.reload_document(name)

          # Verify the response
          assert(response.error?)
          assert_equal(operation_error, response.error)
        end
      end
    end

    it 'invokes reload_document with error' do
      # Create request parameters
      name = ''

      # Mock Grpc layer
      mock_method = proc do |request|
        assert_instance_of(Google::Cloud::Dialogflow::V2beta1::ReloadDocumentRequest, request)
        assert_equal(name, request.name)
        raise custom_error
      end
      mock_stub = MockGrpcClientStub_v2beta1.new(:reload_document, mock_method)

      # Mock auth layer
      mock_credentials = MockDocumentsCredentials_v2beta1.new("reload_document")

      Google::Cloud::Dialogflow::V2beta1::Documents::Stub.stub(:new, mock_stub) do
        Google::Cloud::Dialogflow::V2beta1::Credentials.stub(:default, mock_credentials) do
          client = Google::Cloud::Dialogflow::Documents.new(version: :v2beta1)

          # Call method
          err = assert_raises Google::Gax::GaxError, CustomTestError_v2beta1 do
            client.reload_document(name)
          end

          # Verify the GaxError wrapped the custom error that was raised.
          assert_match(custom_error.message, err.message)
        end
      end
    end
  end
end