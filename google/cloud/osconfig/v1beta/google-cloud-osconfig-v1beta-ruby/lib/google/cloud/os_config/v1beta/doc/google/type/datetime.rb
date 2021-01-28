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
  module Type
    # Represents a time zone from the
    # [IANA Time Zone Database](https://www.iana.org/time-zones).
    # @!attribute [rw] id
    #   @return [String]
    #     IANA Time Zone Database time zone, e.g. "America/New_York".
    # @!attribute [rw] version
    #   @return [String]
    #     Optional. IANA Time Zone Database version number, e.g. "2019a".
    class TimeZone; end
  end
end