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

from google.storage_v1.types import storage
from google.storage_v1.types import storage_resources


class ListBucketsPager:
    """A pager for iterating through ``list_buckets`` requests.

    This class thinly wraps an initial
    :class:`google.storage_v1.types.ListBucketsResponse` object, and
    provides an ``__iter__`` method to iterate through its
    ``items`` field.

    If there are more pages, the ``__iter__`` method will make additional
    ``ListBuckets`` requests and continue to iterate
    through the ``items`` field on the
    corresponding responses.

    All the usual :class:`google.storage_v1.types.ListBucketsResponse`
    attributes are available on the pager. If multiple requests are made, only
    the most recent response is retained, and thus used for attribute lookup.
    """
    def __init__(self,
            method: Callable[..., storage_resources.ListBucketsResponse],
            request: storage.ListBucketsRequest,
            response: storage_resources.ListBucketsResponse,
            *,
            metadata: Sequence[Tuple[str, str]] = ()):
        """Instantiate the pager.

        Args:
            method (Callable): The method that was originally called, and
                which instantiated this pager.
            request (google.storage_v1.types.ListBucketsRequest):
                The initial request object.
            response (google.storage_v1.types.ListBucketsResponse):
                The initial response object.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        self._method = method
        self._request = storage.ListBucketsRequest(request)
        self._response = response
        self._metadata = metadata

    def __getattr__(self, name: str) -> Any:
        return getattr(self._response, name)

    @property
    def pages(self) -> Iterable[storage_resources.ListBucketsResponse]:
        yield self._response
        while self._response.next_page_token:
            self._request.page_token = self._response.next_page_token
            self._response = self._method(self._request, metadata=self._metadata)
            yield self._response

    def __iter__(self) -> Iterable[storage_resources.Bucket]:
        for page in self.pages:
            yield from page.items

    def __repr__(self) -> str:
        return '{0}<{1!r}>'.format(self.__class__.__name__, self._response)


class ListBucketsAsyncPager:
    """A pager for iterating through ``list_buckets`` requests.

    This class thinly wraps an initial
    :class:`google.storage_v1.types.ListBucketsResponse` object, and
    provides an ``__aiter__`` method to iterate through its
    ``items`` field.

    If there are more pages, the ``__aiter__`` method will make additional
    ``ListBuckets`` requests and continue to iterate
    through the ``items`` field on the
    corresponding responses.

    All the usual :class:`google.storage_v1.types.ListBucketsResponse`
    attributes are available on the pager. If multiple requests are made, only
    the most recent response is retained, and thus used for attribute lookup.
    """
    def __init__(self,
            method: Callable[..., Awaitable[storage_resources.ListBucketsResponse]],
            request: storage.ListBucketsRequest,
            response: storage_resources.ListBucketsResponse,
            *,
            metadata: Sequence[Tuple[str, str]] = ()):
        """Instantiate the pager.

        Args:
            method (Callable): The method that was originally called, and
                which instantiated this pager.
            request (google.storage_v1.types.ListBucketsRequest):
                The initial request object.
            response (google.storage_v1.types.ListBucketsResponse):
                The initial response object.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        self._method = method
        self._request = storage.ListBucketsRequest(request)
        self._response = response
        self._metadata = metadata

    def __getattr__(self, name: str) -> Any:
        return getattr(self._response, name)

    @property
    async def pages(self) -> AsyncIterable[storage_resources.ListBucketsResponse]:
        yield self._response
        while self._response.next_page_token:
            self._request.page_token = self._response.next_page_token
            self._response = await self._method(self._request, metadata=self._metadata)
            yield self._response

    def __aiter__(self) -> AsyncIterable[storage_resources.Bucket]:
        async def async_generator():
            async for page in self.pages:
                for response in page.items:
                    yield response

        return async_generator()

    def __repr__(self) -> str:
        return '{0}<{1!r}>'.format(self.__class__.__name__, self._response)


class ListObjectsPager:
    """A pager for iterating through ``list_objects`` requests.

    This class thinly wraps an initial
    :class:`google.storage_v1.types.ListObjectsResponse` object, and
    provides an ``__iter__`` method to iterate through its
    ``prefixes`` field.

    If there are more pages, the ``__iter__`` method will make additional
    ``ListObjects`` requests and continue to iterate
    through the ``prefixes`` field on the
    corresponding responses.

    All the usual :class:`google.storage_v1.types.ListObjectsResponse`
    attributes are available on the pager. If multiple requests are made, only
    the most recent response is retained, and thus used for attribute lookup.
    """
    def __init__(self,
            method: Callable[..., storage_resources.ListObjectsResponse],
            request: storage.ListObjectsRequest,
            response: storage_resources.ListObjectsResponse,
            *,
            metadata: Sequence[Tuple[str, str]] = ()):
        """Instantiate the pager.

        Args:
            method (Callable): The method that was originally called, and
                which instantiated this pager.
            request (google.storage_v1.types.ListObjectsRequest):
                The initial request object.
            response (google.storage_v1.types.ListObjectsResponse):
                The initial response object.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        self._method = method
        self._request = storage.ListObjectsRequest(request)
        self._response = response
        self._metadata = metadata

    def __getattr__(self, name: str) -> Any:
        return getattr(self._response, name)

    @property
    def pages(self) -> Iterable[storage_resources.ListObjectsResponse]:
        yield self._response
        while self._response.next_page_token:
            self._request.page_token = self._response.next_page_token
            self._response = self._method(self._request, metadata=self._metadata)
            yield self._response

    def __iter__(self) -> Iterable[str]:
        for page in self.pages:
            yield from page.prefixes

    def __repr__(self) -> str:
        return '{0}<{1!r}>'.format(self.__class__.__name__, self._response)


class ListObjectsAsyncPager:
    """A pager for iterating through ``list_objects`` requests.

    This class thinly wraps an initial
    :class:`google.storage_v1.types.ListObjectsResponse` object, and
    provides an ``__aiter__`` method to iterate through its
    ``prefixes`` field.

    If there are more pages, the ``__aiter__`` method will make additional
    ``ListObjects`` requests and continue to iterate
    through the ``prefixes`` field on the
    corresponding responses.

    All the usual :class:`google.storage_v1.types.ListObjectsResponse`
    attributes are available on the pager. If multiple requests are made, only
    the most recent response is retained, and thus used for attribute lookup.
    """
    def __init__(self,
            method: Callable[..., Awaitable[storage_resources.ListObjectsResponse]],
            request: storage.ListObjectsRequest,
            response: storage_resources.ListObjectsResponse,
            *,
            metadata: Sequence[Tuple[str, str]] = ()):
        """Instantiate the pager.

        Args:
            method (Callable): The method that was originally called, and
                which instantiated this pager.
            request (google.storage_v1.types.ListObjectsRequest):
                The initial request object.
            response (google.storage_v1.types.ListObjectsResponse):
                The initial response object.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        self._method = method
        self._request = storage.ListObjectsRequest(request)
        self._response = response
        self._metadata = metadata

    def __getattr__(self, name: str) -> Any:
        return getattr(self._response, name)

    @property
    async def pages(self) -> AsyncIterable[storage_resources.ListObjectsResponse]:
        yield self._response
        while self._response.next_page_token:
            self._request.page_token = self._response.next_page_token
            self._response = await self._method(self._request, metadata=self._metadata)
            yield self._response

    def __aiter__(self) -> AsyncIterable[str]:
        async def async_generator():
            async for page in self.pages:
                for response in page.prefixes:
                    yield response

        return async_generator()

    def __repr__(self) -> str:
        return '{0}<{1!r}>'.format(self.__class__.__name__, self._response)


class ListHmacKeysPager:
    """A pager for iterating through ``list_hmac_keys`` requests.

    This class thinly wraps an initial
    :class:`google.storage_v1.types.ListHmacKeysResponse` object, and
    provides an ``__iter__`` method to iterate through its
    ``items`` field.

    If there are more pages, the ``__iter__`` method will make additional
    ``ListHmacKeys`` requests and continue to iterate
    through the ``items`` field on the
    corresponding responses.

    All the usual :class:`google.storage_v1.types.ListHmacKeysResponse`
    attributes are available on the pager. If multiple requests are made, only
    the most recent response is retained, and thus used for attribute lookup.
    """
    def __init__(self,
            method: Callable[..., storage.ListHmacKeysResponse],
            request: storage.ListHmacKeysRequest,
            response: storage.ListHmacKeysResponse,
            *,
            metadata: Sequence[Tuple[str, str]] = ()):
        """Instantiate the pager.

        Args:
            method (Callable): The method that was originally called, and
                which instantiated this pager.
            request (google.storage_v1.types.ListHmacKeysRequest):
                The initial request object.
            response (google.storage_v1.types.ListHmacKeysResponse):
                The initial response object.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        self._method = method
        self._request = storage.ListHmacKeysRequest(request)
        self._response = response
        self._metadata = metadata

    def __getattr__(self, name: str) -> Any:
        return getattr(self._response, name)

    @property
    def pages(self) -> Iterable[storage.ListHmacKeysResponse]:
        yield self._response
        while self._response.next_page_token:
            self._request.page_token = self._response.next_page_token
            self._response = self._method(self._request, metadata=self._metadata)
            yield self._response

    def __iter__(self) -> Iterable[storage_resources.HmacKeyMetadata]:
        for page in self.pages:
            yield from page.items

    def __repr__(self) -> str:
        return '{0}<{1!r}>'.format(self.__class__.__name__, self._response)


class ListHmacKeysAsyncPager:
    """A pager for iterating through ``list_hmac_keys`` requests.

    This class thinly wraps an initial
    :class:`google.storage_v1.types.ListHmacKeysResponse` object, and
    provides an ``__aiter__`` method to iterate through its
    ``items`` field.

    If there are more pages, the ``__aiter__`` method will make additional
    ``ListHmacKeys`` requests and continue to iterate
    through the ``items`` field on the
    corresponding responses.

    All the usual :class:`google.storage_v1.types.ListHmacKeysResponse`
    attributes are available on the pager. If multiple requests are made, only
    the most recent response is retained, and thus used for attribute lookup.
    """
    def __init__(self,
            method: Callable[..., Awaitable[storage.ListHmacKeysResponse]],
            request: storage.ListHmacKeysRequest,
            response: storage.ListHmacKeysResponse,
            *,
            metadata: Sequence[Tuple[str, str]] = ()):
        """Instantiate the pager.

        Args:
            method (Callable): The method that was originally called, and
                which instantiated this pager.
            request (google.storage_v1.types.ListHmacKeysRequest):
                The initial request object.
            response (google.storage_v1.types.ListHmacKeysResponse):
                The initial response object.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        self._method = method
        self._request = storage.ListHmacKeysRequest(request)
        self._response = response
        self._metadata = metadata

    def __getattr__(self, name: str) -> Any:
        return getattr(self._response, name)

    @property
    async def pages(self) -> AsyncIterable[storage.ListHmacKeysResponse]:
        yield self._response
        while self._response.next_page_token:
            self._request.page_token = self._response.next_page_token
            self._response = await self._method(self._request, metadata=self._metadata)
            yield self._response

    def __aiter__(self) -> AsyncIterable[storage_resources.HmacKeyMetadata]:
        async def async_generator():
            async for page in self.pages:
                for response in page.items:
                    yield response

        return async_generator()

    def __repr__(self) -> str:
        return '{0}<{1!r}>'.format(self.__class__.__name__, self._response)
