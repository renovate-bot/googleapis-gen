# -*- coding: utf-8 -*-

# Copyright 2020 Google LLC
#
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
#
#     http://www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
#

from google.devtools.cloudtrace_v1.services.trace_service.async_client import TraceServiceAsyncClient
from google.devtools.cloudtrace_v1.services.trace_service.client import TraceServiceClient
from google.devtools.cloudtrace_v1.types.trace import GetTraceRequest
from google.devtools.cloudtrace_v1.types.trace import ListTracesRequest
from google.devtools.cloudtrace_v1.types.trace import ListTracesResponse
from google.devtools.cloudtrace_v1.types.trace import PatchTracesRequest
from google.devtools.cloudtrace_v1.types.trace import Trace
from google.devtools.cloudtrace_v1.types.trace import TraceSpan
from google.devtools.cloudtrace_v1.types.trace import Traces

__all__ = (
    'GetTraceRequest',
    'ListTracesRequest',
    'ListTracesResponse',
    'PatchTracesRequest',
    'Trace',
    'TraceServiceAsyncClient',
    'TraceServiceClient',
    'TraceSpan',
    'Traces',
)