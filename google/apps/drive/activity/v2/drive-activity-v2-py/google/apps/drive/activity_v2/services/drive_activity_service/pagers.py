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
from typing import Any, AsyncIterable, Awaitable, Callable, Iterable, Sequence, Tuple, Optional

from google.apps.drive.activity_v2.types import query_drive_activity_request
from google.apps.drive.activity_v2.types import query_drive_activity_response


class QueryDriveActivityPager:
    """A pager for iterating through ``query_drive_activity`` requests.

    This class thinly wraps an initial
    :class:`google.apps.drive.activity_v2.types.QueryDriveActivityResponse` object, and
    provides an ``__iter__`` method to iterate through its
    ``activities`` field.

    If there are more pages, the ``__iter__`` method will make additional
    ``QueryDriveActivity`` requests and continue to iterate
    through the ``activities`` field on the
    corresponding responses.

    All the usual :class:`google.apps.drive.activity_v2.types.QueryDriveActivityResponse`
    attributes are available on the pager. If multiple requests are made, only
    the most recent response is retained, and thus used for attribute lookup.
    """
    def __init__(self,
            method: Callable[..., query_drive_activity_response.QueryDriveActivityResponse],
            request: query_drive_activity_request.QueryDriveActivityRequest,
            response: query_drive_activity_response.QueryDriveActivityResponse,
            *,
            metadata: Sequence[Tuple[str, str]] = ()):
        """Instantiate the pager.

        Args:
            method (Callable): The method that was originally called, and
                which instantiated this pager.
            request (google.apps.drive.activity_v2.types.QueryDriveActivityRequest):
                The initial request object.
            response (google.apps.drive.activity_v2.types.QueryDriveActivityResponse):
                The initial response object.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        self._method = method
        self._request = query_drive_activity_request.QueryDriveActivityRequest(request)
        self._response = response
        self._metadata = metadata

    def __getattr__(self, name: str) -> Any:
        return getattr(self._response, name)

    @property
    def pages(self) -> Iterable[query_drive_activity_response.QueryDriveActivityResponse]:
        yield self._response
        while self._response.next_page_token:
            self._request.page_token = self._response.next_page_token
            self._response = self._method(self._request, metadata=self._metadata)
            yield self._response

    def __iter__(self) -> Iterable[query_drive_activity_response.DriveActivity]:
        for page in self.pages:
            yield from page.activities

    def __repr__(self) -> str:
        return '{0}<{1!r}>'.format(self.__class__.__name__, self._response)


class QueryDriveActivityAsyncPager:
    """A pager for iterating through ``query_drive_activity`` requests.

    This class thinly wraps an initial
    :class:`google.apps.drive.activity_v2.types.QueryDriveActivityResponse` object, and
    provides an ``__aiter__`` method to iterate through its
    ``activities`` field.

    If there are more pages, the ``__aiter__`` method will make additional
    ``QueryDriveActivity`` requests and continue to iterate
    through the ``activities`` field on the
    corresponding responses.

    All the usual :class:`google.apps.drive.activity_v2.types.QueryDriveActivityResponse`
    attributes are available on the pager. If multiple requests are made, only
    the most recent response is retained, and thus used for attribute lookup.
    """
    def __init__(self,
            method: Callable[..., Awaitable[query_drive_activity_response.QueryDriveActivityResponse]],
            request: query_drive_activity_request.QueryDriveActivityRequest,
            response: query_drive_activity_response.QueryDriveActivityResponse,
            *,
            metadata: Sequence[Tuple[str, str]] = ()):
        """Instantiate the pager.

        Args:
            method (Callable): The method that was originally called, and
                which instantiated this pager.
            request (google.apps.drive.activity_v2.types.QueryDriveActivityRequest):
                The initial request object.
            response (google.apps.drive.activity_v2.types.QueryDriveActivityResponse):
                The initial response object.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        self._method = method
        self._request = query_drive_activity_request.QueryDriveActivityRequest(request)
        self._response = response
        self._metadata = metadata

    def __getattr__(self, name: str) -> Any:
        return getattr(self._response, name)

    @property
    async def pages(self) -> AsyncIterable[query_drive_activity_response.QueryDriveActivityResponse]:
        yield self._response
        while self._response.next_page_token:
            self._request.page_token = self._response.next_page_token
            self._response = await self._method(self._request, metadata=self._metadata)
            yield self._response

    def __aiter__(self) -> AsyncIterable[query_drive_activity_response.DriveActivity]:
        async def async_generator():
            async for page in self.pages:
                for response in page.activities:
                    yield response

        return async_generator()

    def __repr__(self) -> str:
        return '{0}<{1!r}>'.format(self.__class__.__name__, self._response)
