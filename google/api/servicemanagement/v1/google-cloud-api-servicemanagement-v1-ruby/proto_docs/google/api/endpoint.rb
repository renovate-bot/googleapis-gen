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
  module Api
    # `Endpoint` describes a network endpoint of a service that serves a set of
    # APIs. It is commonly known as a service endpoint. A service may expose
    # any number of service endpoints, and all service endpoints share the same
    # service definition, such as quota limits and monitoring metrics.
    #
    # Example service configuration:
    #
    #     name: library-example.googleapis.com
    #     endpoints:
    #       # Below entry makes 'google.example.library.v1.Library'
    #       # API be served from endpoint address library-example.googleapis.com.
    #       # It also allows HTTP OPTIONS calls to be passed to the backend, for
    #       # it to decide whether the subsequent cross-origin request is
    #       # allowed to proceed.
    #     - name: library-example.googleapis.com
    #       allow_cors: true
    # @!attribute [rw] name
    #   @return [::String]
    #     The canonical name of this endpoint.
    # @!attribute [rw] aliases
    #   @return [::Array<::String>]
    #     Unimplemented. Dot not use.
    #
    #     DEPRECATED: This field is no longer supported. Instead of using aliases,
    #     please specify multiple {::Google::Api::Endpoint google.api.Endpoint} for each of the intended
    #     aliases.
    #
    #     Additional names that this endpoint will be hosted on.
    # @!attribute [rw] target
    #   @return [::String]
    #     The specification of an Internet routable address of API frontend that will
    #     handle requests to this [API
    #     Endpoint](https://cloud.google.com/apis/design/glossary). It should be
    #     either a valid IPv4 address or a fully-qualified domain name. For example,
    #     "8.8.8.8" or "myservice.appspot.com".
    # @!attribute [rw] allow_cors
    #   @return [::Boolean]
    #     Allowing
    #     [CORS](https://en.wikipedia.org/wiki/Cross-origin_resource_sharing), aka
    #     cross-domain traffic, would allow the backends served from this endpoint to
    #     receive and respond to HTTP OPTIONS requests. The response will be used by
    #     the browser to determine whether the subsequent cross-origin request is
    #     allowed to proceed.
    class Endpoint
      include ::Google::Protobuf::MessageExts
      extend ::Google::Protobuf::MessageExts::ClassMethods
    end
  end
end
