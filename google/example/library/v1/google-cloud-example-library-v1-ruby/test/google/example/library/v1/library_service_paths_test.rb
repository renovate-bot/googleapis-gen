# frozen_string_literal: true

# Copyright 2021 Google LLC
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

# Auto-generated by gapic-generator-ruby. DO NOT EDIT!

require "helper"

require "gapic/grpc/service_stub"

require "google/example/library/v1/library_service"

class ::Google::Example::Library::V1::LibraryService::ClientPathsTest < Minitest::Test
  def test_book_path
    grpc_channel = ::GRPC::Core::Channel.new "localhost:8888", nil, :this_channel_is_insecure
    ::Gapic::ServiceStub.stub :new, nil do
      client = ::Google::Example::Library::V1::LibraryService::Client.new do |config|
        config.credentials = grpc_channel
      end

      path = client.book_path shelf: "value0", book: "value1"
      assert_equal "shelves/value0/books/value1", path
    end
  end

  def test_shelf_path
    grpc_channel = ::GRPC::Core::Channel.new "localhost:8888", nil, :this_channel_is_insecure
    ::Gapic::ServiceStub.stub :new, nil do
      client = ::Google::Example::Library::V1::LibraryService::Client.new do |config|
        config.credentials = grpc_channel
      end

      path = client.shelf_path shelf_id: "value0"
      assert_equal "shelves/value0", path
    end
  end
end
