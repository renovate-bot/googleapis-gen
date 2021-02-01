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

from typing import Any, AsyncIterable, Awaitable, Callable, Iterable, Sequence, Tuple

from google.example.library_v1.types import library


class ListShelvesPager:
    """A pager for iterating through ``list_shelves`` requests.

    This class thinly wraps an initial
    :class:`google.example.library_v1.types.ListShelvesResponse` object, and
    provides an ``__iter__`` method to iterate through its
    ``shelves`` field.

    If there are more pages, the ``__iter__`` method will make additional
    ``ListShelves`` requests and continue to iterate
    through the ``shelves`` field on the
    corresponding responses.

    All the usual :class:`google.example.library_v1.types.ListShelvesResponse`
    attributes are available on the pager. If multiple requests are made, only
    the most recent response is retained, and thus used for attribute lookup.
    """
    def __init__(self,
            method: Callable[..., library.ListShelvesResponse],
            request: library.ListShelvesRequest,
            response: library.ListShelvesResponse,
            *,
            metadata: Sequence[Tuple[str, str]] = ()):
        """Instantiate the pager.

        Args:
            method (Callable): The method that was originally called, and
                which instantiated this pager.
            request (google.example.library_v1.types.ListShelvesRequest):
                The initial request object.
            response (google.example.library_v1.types.ListShelvesResponse):
                The initial response object.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        self._method = method
        self._request = library.ListShelvesRequest(request)
        self._response = response
        self._metadata = metadata

    def __getattr__(self, name: str) -> Any:
        return getattr(self._response, name)

    @property
    def pages(self) -> Iterable[library.ListShelvesResponse]:
        yield self._response
        while self._response.next_page_token:
            self._request.page_token = self._response.next_page_token
            self._response = self._method(self._request, metadata=self._metadata)
            yield self._response

    def __iter__(self) -> Iterable[library.Shelf]:
        for page in self.pages:
            yield from page.shelves

    def __repr__(self) -> str:
        return '{0}<{1!r}>'.format(self.__class__.__name__, self._response)


class ListShelvesAsyncPager:
    """A pager for iterating through ``list_shelves`` requests.

    This class thinly wraps an initial
    :class:`google.example.library_v1.types.ListShelvesResponse` object, and
    provides an ``__aiter__`` method to iterate through its
    ``shelves`` field.

    If there are more pages, the ``__aiter__`` method will make additional
    ``ListShelves`` requests and continue to iterate
    through the ``shelves`` field on the
    corresponding responses.

    All the usual :class:`google.example.library_v1.types.ListShelvesResponse`
    attributes are available on the pager. If multiple requests are made, only
    the most recent response is retained, and thus used for attribute lookup.
    """
    def __init__(self,
            method: Callable[..., Awaitable[library.ListShelvesResponse]],
            request: library.ListShelvesRequest,
            response: library.ListShelvesResponse,
            *,
            metadata: Sequence[Tuple[str, str]] = ()):
        """Instantiate the pager.

        Args:
            method (Callable): The method that was originally called, and
                which instantiated this pager.
            request (google.example.library_v1.types.ListShelvesRequest):
                The initial request object.
            response (google.example.library_v1.types.ListShelvesResponse):
                The initial response object.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        self._method = method
        self._request = library.ListShelvesRequest(request)
        self._response = response
        self._metadata = metadata

    def __getattr__(self, name: str) -> Any:
        return getattr(self._response, name)

    @property
    async def pages(self) -> AsyncIterable[library.ListShelvesResponse]:
        yield self._response
        while self._response.next_page_token:
            self._request.page_token = self._response.next_page_token
            self._response = await self._method(self._request, metadata=self._metadata)
            yield self._response

    def __aiter__(self) -> AsyncIterable[library.Shelf]:
        async def async_generator():
            async for page in self.pages:
                for response in page.shelves:
                    yield response

        return async_generator()

    def __repr__(self) -> str:
        return '{0}<{1!r}>'.format(self.__class__.__name__, self._response)


class ListBooksPager:
    """A pager for iterating through ``list_books`` requests.

    This class thinly wraps an initial
    :class:`google.example.library_v1.types.ListBooksResponse` object, and
    provides an ``__iter__`` method to iterate through its
    ``books`` field.

    If there are more pages, the ``__iter__`` method will make additional
    ``ListBooks`` requests and continue to iterate
    through the ``books`` field on the
    corresponding responses.

    All the usual :class:`google.example.library_v1.types.ListBooksResponse`
    attributes are available on the pager. If multiple requests are made, only
    the most recent response is retained, and thus used for attribute lookup.
    """
    def __init__(self,
            method: Callable[..., library.ListBooksResponse],
            request: library.ListBooksRequest,
            response: library.ListBooksResponse,
            *,
            metadata: Sequence[Tuple[str, str]] = ()):
        """Instantiate the pager.

        Args:
            method (Callable): The method that was originally called, and
                which instantiated this pager.
            request (google.example.library_v1.types.ListBooksRequest):
                The initial request object.
            response (google.example.library_v1.types.ListBooksResponse):
                The initial response object.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        self._method = method
        self._request = library.ListBooksRequest(request)
        self._response = response
        self._metadata = metadata

    def __getattr__(self, name: str) -> Any:
        return getattr(self._response, name)

    @property
    def pages(self) -> Iterable[library.ListBooksResponse]:
        yield self._response
        while self._response.next_page_token:
            self._request.page_token = self._response.next_page_token
            self._response = self._method(self._request, metadata=self._metadata)
            yield self._response

    def __iter__(self) -> Iterable[library.Book]:
        for page in self.pages:
            yield from page.books

    def __repr__(self) -> str:
        return '{0}<{1!r}>'.format(self.__class__.__name__, self._response)


class ListBooksAsyncPager:
    """A pager for iterating through ``list_books`` requests.

    This class thinly wraps an initial
    :class:`google.example.library_v1.types.ListBooksResponse` object, and
    provides an ``__aiter__`` method to iterate through its
    ``books`` field.

    If there are more pages, the ``__aiter__`` method will make additional
    ``ListBooks`` requests and continue to iterate
    through the ``books`` field on the
    corresponding responses.

    All the usual :class:`google.example.library_v1.types.ListBooksResponse`
    attributes are available on the pager. If multiple requests are made, only
    the most recent response is retained, and thus used for attribute lookup.
    """
    def __init__(self,
            method: Callable[..., Awaitable[library.ListBooksResponse]],
            request: library.ListBooksRequest,
            response: library.ListBooksResponse,
            *,
            metadata: Sequence[Tuple[str, str]] = ()):
        """Instantiate the pager.

        Args:
            method (Callable): The method that was originally called, and
                which instantiated this pager.
            request (google.example.library_v1.types.ListBooksRequest):
                The initial request object.
            response (google.example.library_v1.types.ListBooksResponse):
                The initial response object.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        self._method = method
        self._request = library.ListBooksRequest(request)
        self._response = response
        self._metadata = metadata

    def __getattr__(self, name: str) -> Any:
        return getattr(self._response, name)

    @property
    async def pages(self) -> AsyncIterable[library.ListBooksResponse]:
        yield self._response
        while self._response.next_page_token:
            self._request.page_token = self._response.next_page_token
            self._response = await self._method(self._request, metadata=self._metadata)
            yield self._response

    def __aiter__(self) -> AsyncIterable[library.Book]:
        async def async_generator():
            async for page in self.pages:
                for response in page.books:
                    yield response

        return async_generator()

    def __repr__(self) -> str:
        return '{0}<{1!r}>'.format(self.__class__.__name__, self._response)
