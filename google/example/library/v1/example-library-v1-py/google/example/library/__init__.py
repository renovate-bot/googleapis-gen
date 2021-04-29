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

from google.example.library_v1.services.library_service.client import LibraryServiceClient
from google.example.library_v1.services.library_service.async_client import LibraryServiceAsyncClient

from google.example.library_v1.types.library import Book
from google.example.library_v1.types.library import CreateBookRequest
from google.example.library_v1.types.library import CreateShelfRequest
from google.example.library_v1.types.library import DeleteBookRequest
from google.example.library_v1.types.library import DeleteShelfRequest
from google.example.library_v1.types.library import GetBookRequest
from google.example.library_v1.types.library import GetShelfRequest
from google.example.library_v1.types.library import ListBooksRequest
from google.example.library_v1.types.library import ListBooksResponse
from google.example.library_v1.types.library import ListShelvesRequest
from google.example.library_v1.types.library import ListShelvesResponse
from google.example.library_v1.types.library import MergeShelvesRequest
from google.example.library_v1.types.library import MoveBookRequest
from google.example.library_v1.types.library import Shelf
from google.example.library_v1.types.library import UpdateBookRequest

__all__ = ('LibraryServiceClient',
    'LibraryServiceAsyncClient',
    'Book',
    'CreateBookRequest',
    'CreateShelfRequest',
    'DeleteBookRequest',
    'DeleteShelfRequest',
    'GetBookRequest',
    'GetShelfRequest',
    'ListBooksRequest',
    'ListBooksResponse',
    'ListShelvesRequest',
    'ListShelvesResponse',
    'MergeShelvesRequest',
    'MoveBookRequest',
    'Shelf',
    'UpdateBookRequest',
)
