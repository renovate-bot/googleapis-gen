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

module Google
  module Cloud
    module Websecurityscanner
      module V1alpha
        # A CrawledUrl resource represents a URL that was crawled during a ScanRun. Web
        # Security Scanner Service crawls the web applications, following all links
        # within the scope of sites, to find the URLs to test against.
        # @!attribute [rw] http_method
        #   @return [String]
        #     Output only. The http method of the request that was used to visit the URL, in
        #     uppercase.
        # @!attribute [rw] url
        #   @return [String]
        #     Output only. The URL that was crawled.
        # @!attribute [rw] body
        #   @return [String]
        #     Output only. The body of the request that was used to visit the URL.
        class CrawledUrl; end
      end
    end
  end
end