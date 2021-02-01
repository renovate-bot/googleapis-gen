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

from .services.library_service import LibraryServiceClient
from .types.library import Book
from .types.library import CreateBookRequest
from .types.library import CreateShelfRequest
from .types.library import DeleteBookRequest
from .types.library import DeleteShelfRequest
from .types.library import GetBookRequest
from .types.library import GetShelfRequest
from .types.library import ListBooksRequest
from .types.library import ListBooksResponse
from .types.library import ListShelvesRequest
from .types.library import ListShelvesResponse
from .types.library import MergeShelvesRequest
from .types.library import MoveBookRequest
from .types.library import Shelf
from .types.library import UpdateBookRequest


__all__ = (
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
'LibraryServiceClient',
)
