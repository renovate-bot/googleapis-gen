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
    module Dialogflow
      module V2beta1
        # Google Cloud Storage locations for the inputs.
        # @!attribute [rw] uris
        #   @return [Array<String>]
        #     Required. Google Cloud Storage URIs for the inputs. A URI is of the
        #     form:
        #       gs://bucket/object-prefix-or-name
        #     Whether a prefix or name is used depends on the use case.
        class GcsSources; end

        # Google Cloud Storage location for single input.
        # @!attribute [rw] uri
        #   @return [String]
        #     Required. The Google Cloud Storage URIs for the inputs. A URI is of the
        #     form:
        #       gs://bucket/object-prefix-or-name
        #     Whether a prefix or name is used depends on the use case.
        class GcsSource; end
      end
    end
  end
end