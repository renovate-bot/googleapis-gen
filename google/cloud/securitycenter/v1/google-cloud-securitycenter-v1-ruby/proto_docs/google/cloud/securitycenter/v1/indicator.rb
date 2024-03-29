# frozen_string_literal: true

# Copyright 2022 Google LLC
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
  module Cloud
    module SecurityCenter
      module V1
        # Represents what's commonly known as an Indicator of compromise (IoC) in
        # computer forensics. This is an artifact observed on a network or in an
        # operating system that, with high confidence, indicates a computer intrusion.
        # Reference: https://en.wikipedia.org/wiki/Indicator_of_compromise
        # @!attribute [rw] ip_addresses
        #   @return [::Array<::String>]
        #     List of ip addresses associated to the Finding.
        # @!attribute [rw] domains
        #   @return [::Array<::String>]
        #     List of domains associated to the Finding.
        class Indicator
          include ::Google::Protobuf::MessageExts
          extend ::Google::Protobuf::MessageExts::ClassMethods
        end
      end
    end
  end
end
