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


module Google
  module Example
    module Library
      module V1
        module LibraryService
          # Path helper methods for the LibraryService API.
          module Paths
            ##
            # Create a fully-qualified Book resource string.
            #
            # The resource will be in the following format:
            #
            # `shelves/{shelf}/books/{book}`
            #
            # @param shelf [String]
            # @param book [String]
            #
            # @return [::String]
            def book_path shelf:, book:
              raise ::ArgumentError, "shelf cannot contain /" if shelf.to_s.include? "/"

              "shelves/#{shelf}/books/#{book}"
            end

            ##
            # Create a fully-qualified Shelf resource string.
            #
            # The resource will be in the following format:
            #
            # `shelves/{shelf_id}`
            #
            # @param shelf_id [String]
            #
            # @return [::String]
            def shelf_path shelf_id:
              "shelves/#{shelf_id}"
            end

            extend self
          end
        end
      end
    end
  end
end
