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
from typing import Any, AsyncIterator, Awaitable, Callable, Sequence, Tuple, Optional, Iterator

from google.cloud.datafusion_v1beta1.types import v1beta1


class ListAvailableVersionsPager:
    """A pager for iterating through ``list_available_versions`` requests.

    This class thinly wraps an initial
    :class:`google.cloud.datafusion_v1beta1.types.ListAvailableVersionsResponse` object, and
    provides an ``__iter__`` method to iterate through its
    ``available_versions`` field.

    If there are more pages, the ``__iter__`` method will make additional
    ``ListAvailableVersions`` requests and continue to iterate
    through the ``available_versions`` field on the
    corresponding responses.

    All the usual :class:`google.cloud.datafusion_v1beta1.types.ListAvailableVersionsResponse`
    attributes are available on the pager. If multiple requests are made, only
    the most recent response is retained, and thus used for attribute lookup.
    """
    def __init__(self,
            method: Callable[..., v1beta1.ListAvailableVersionsResponse],
            request: v1beta1.ListAvailableVersionsRequest,
            response: v1beta1.ListAvailableVersionsResponse,
            *,
            metadata: Sequence[Tuple[str, str]] = ()):
        """Instantiate the pager.

        Args:
            method (Callable): The method that was originally called, and
                which instantiated this pager.
            request (google.cloud.datafusion_v1beta1.types.ListAvailableVersionsRequest):
                The initial request object.
            response (google.cloud.datafusion_v1beta1.types.ListAvailableVersionsResponse):
                The initial response object.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        self._method = method
        self._request = v1beta1.ListAvailableVersionsRequest(request)
        self._response = response
        self._metadata = metadata

    def __getattr__(self, name: str) -> Any:
        return getattr(self._response, name)

    @property
    def pages(self) -> Iterator[v1beta1.ListAvailableVersionsResponse]:
        yield self._response
        while self._response.next_page_token:
            self._request.page_token = self._response.next_page_token
            self._response = self._method(self._request, metadata=self._metadata)
            yield self._response

    def __iter__(self) -> Iterator[v1beta1.Version]:
        for page in self.pages:
            yield from page.available_versions

    def __repr__(self) -> str:
        return '{0}<{1!r}>'.format(self.__class__.__name__, self._response)


class ListAvailableVersionsAsyncPager:
    """A pager for iterating through ``list_available_versions`` requests.

    This class thinly wraps an initial
    :class:`google.cloud.datafusion_v1beta1.types.ListAvailableVersionsResponse` object, and
    provides an ``__aiter__`` method to iterate through its
    ``available_versions`` field.

    If there are more pages, the ``__aiter__`` method will make additional
    ``ListAvailableVersions`` requests and continue to iterate
    through the ``available_versions`` field on the
    corresponding responses.

    All the usual :class:`google.cloud.datafusion_v1beta1.types.ListAvailableVersionsResponse`
    attributes are available on the pager. If multiple requests are made, only
    the most recent response is retained, and thus used for attribute lookup.
    """
    def __init__(self,
            method: Callable[..., Awaitable[v1beta1.ListAvailableVersionsResponse]],
            request: v1beta1.ListAvailableVersionsRequest,
            response: v1beta1.ListAvailableVersionsResponse,
            *,
            metadata: Sequence[Tuple[str, str]] = ()):
        """Instantiates the pager.

        Args:
            method (Callable): The method that was originally called, and
                which instantiated this pager.
            request (google.cloud.datafusion_v1beta1.types.ListAvailableVersionsRequest):
                The initial request object.
            response (google.cloud.datafusion_v1beta1.types.ListAvailableVersionsResponse):
                The initial response object.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        self._method = method
        self._request = v1beta1.ListAvailableVersionsRequest(request)
        self._response = response
        self._metadata = metadata

    def __getattr__(self, name: str) -> Any:
        return getattr(self._response, name)

    @property
    async def pages(self) -> AsyncIterator[v1beta1.ListAvailableVersionsResponse]:
        yield self._response
        while self._response.next_page_token:
            self._request.page_token = self._response.next_page_token
            self._response = await self._method(self._request, metadata=self._metadata)
            yield self._response
    def __aiter__(self) -> AsyncIterator[v1beta1.Version]:
        async def async_generator():
            async for page in self.pages:
                for response in page.available_versions:
                    yield response

        return async_generator()

    def __repr__(self) -> str:
        return '{0}<{1!r}>'.format(self.__class__.__name__, self._response)


class ListInstancesPager:
    """A pager for iterating through ``list_instances`` requests.

    This class thinly wraps an initial
    :class:`google.cloud.datafusion_v1beta1.types.ListInstancesResponse` object, and
    provides an ``__iter__`` method to iterate through its
    ``instances`` field.

    If there are more pages, the ``__iter__`` method will make additional
    ``ListInstances`` requests and continue to iterate
    through the ``instances`` field on the
    corresponding responses.

    All the usual :class:`google.cloud.datafusion_v1beta1.types.ListInstancesResponse`
    attributes are available on the pager. If multiple requests are made, only
    the most recent response is retained, and thus used for attribute lookup.
    """
    def __init__(self,
            method: Callable[..., v1beta1.ListInstancesResponse],
            request: v1beta1.ListInstancesRequest,
            response: v1beta1.ListInstancesResponse,
            *,
            metadata: Sequence[Tuple[str, str]] = ()):
        """Instantiate the pager.

        Args:
            method (Callable): The method that was originally called, and
                which instantiated this pager.
            request (google.cloud.datafusion_v1beta1.types.ListInstancesRequest):
                The initial request object.
            response (google.cloud.datafusion_v1beta1.types.ListInstancesResponse):
                The initial response object.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        self._method = method
        self._request = v1beta1.ListInstancesRequest(request)
        self._response = response
        self._metadata = metadata

    def __getattr__(self, name: str) -> Any:
        return getattr(self._response, name)

    @property
    def pages(self) -> Iterator[v1beta1.ListInstancesResponse]:
        yield self._response
        while self._response.next_page_token:
            self._request.page_token = self._response.next_page_token
            self._response = self._method(self._request, metadata=self._metadata)
            yield self._response

    def __iter__(self) -> Iterator[v1beta1.Instance]:
        for page in self.pages:
            yield from page.instances

    def __repr__(self) -> str:
        return '{0}<{1!r}>'.format(self.__class__.__name__, self._response)


class ListInstancesAsyncPager:
    """A pager for iterating through ``list_instances`` requests.

    This class thinly wraps an initial
    :class:`google.cloud.datafusion_v1beta1.types.ListInstancesResponse` object, and
    provides an ``__aiter__`` method to iterate through its
    ``instances`` field.

    If there are more pages, the ``__aiter__`` method will make additional
    ``ListInstances`` requests and continue to iterate
    through the ``instances`` field on the
    corresponding responses.

    All the usual :class:`google.cloud.datafusion_v1beta1.types.ListInstancesResponse`
    attributes are available on the pager. If multiple requests are made, only
    the most recent response is retained, and thus used for attribute lookup.
    """
    def __init__(self,
            method: Callable[..., Awaitable[v1beta1.ListInstancesResponse]],
            request: v1beta1.ListInstancesRequest,
            response: v1beta1.ListInstancesResponse,
            *,
            metadata: Sequence[Tuple[str, str]] = ()):
        """Instantiates the pager.

        Args:
            method (Callable): The method that was originally called, and
                which instantiated this pager.
            request (google.cloud.datafusion_v1beta1.types.ListInstancesRequest):
                The initial request object.
            response (google.cloud.datafusion_v1beta1.types.ListInstancesResponse):
                The initial response object.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        self._method = method
        self._request = v1beta1.ListInstancesRequest(request)
        self._response = response
        self._metadata = metadata

    def __getattr__(self, name: str) -> Any:
        return getattr(self._response, name)

    @property
    async def pages(self) -> AsyncIterator[v1beta1.ListInstancesResponse]:
        yield self._response
        while self._response.next_page_token:
            self._request.page_token = self._response.next_page_token
            self._response = await self._method(self._request, metadata=self._metadata)
            yield self._response
    def __aiter__(self) -> AsyncIterator[v1beta1.Instance]:
        async def async_generator():
            async for page in self.pages:
                for response in page.instances:
                    yield response

        return async_generator()

    def __repr__(self) -> str:
        return '{0}<{1!r}>'.format(self.__class__.__name__, self._response)


class ListNamespacesPager:
    """A pager for iterating through ``list_namespaces`` requests.

    This class thinly wraps an initial
    :class:`google.cloud.datafusion_v1beta1.types.ListNamespacesResponse` object, and
    provides an ``__iter__`` method to iterate through its
    ``namespaces`` field.

    If there are more pages, the ``__iter__`` method will make additional
    ``ListNamespaces`` requests and continue to iterate
    through the ``namespaces`` field on the
    corresponding responses.

    All the usual :class:`google.cloud.datafusion_v1beta1.types.ListNamespacesResponse`
    attributes are available on the pager. If multiple requests are made, only
    the most recent response is retained, and thus used for attribute lookup.
    """
    def __init__(self,
            method: Callable[..., v1beta1.ListNamespacesResponse],
            request: v1beta1.ListNamespacesRequest,
            response: v1beta1.ListNamespacesResponse,
            *,
            metadata: Sequence[Tuple[str, str]] = ()):
        """Instantiate the pager.

        Args:
            method (Callable): The method that was originally called, and
                which instantiated this pager.
            request (google.cloud.datafusion_v1beta1.types.ListNamespacesRequest):
                The initial request object.
            response (google.cloud.datafusion_v1beta1.types.ListNamespacesResponse):
                The initial response object.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        self._method = method
        self._request = v1beta1.ListNamespacesRequest(request)
        self._response = response
        self._metadata = metadata

    def __getattr__(self, name: str) -> Any:
        return getattr(self._response, name)

    @property
    def pages(self) -> Iterator[v1beta1.ListNamespacesResponse]:
        yield self._response
        while self._response.next_page_token:
            self._request.page_token = self._response.next_page_token
            self._response = self._method(self._request, metadata=self._metadata)
            yield self._response

    def __iter__(self) -> Iterator[v1beta1.Namespace]:
        for page in self.pages:
            yield from page.namespaces

    def __repr__(self) -> str:
        return '{0}<{1!r}>'.format(self.__class__.__name__, self._response)


class ListNamespacesAsyncPager:
    """A pager for iterating through ``list_namespaces`` requests.

    This class thinly wraps an initial
    :class:`google.cloud.datafusion_v1beta1.types.ListNamespacesResponse` object, and
    provides an ``__aiter__`` method to iterate through its
    ``namespaces`` field.

    If there are more pages, the ``__aiter__`` method will make additional
    ``ListNamespaces`` requests and continue to iterate
    through the ``namespaces`` field on the
    corresponding responses.

    All the usual :class:`google.cloud.datafusion_v1beta1.types.ListNamespacesResponse`
    attributes are available on the pager. If multiple requests are made, only
    the most recent response is retained, and thus used for attribute lookup.
    """
    def __init__(self,
            method: Callable[..., Awaitable[v1beta1.ListNamespacesResponse]],
            request: v1beta1.ListNamespacesRequest,
            response: v1beta1.ListNamespacesResponse,
            *,
            metadata: Sequence[Tuple[str, str]] = ()):
        """Instantiates the pager.

        Args:
            method (Callable): The method that was originally called, and
                which instantiated this pager.
            request (google.cloud.datafusion_v1beta1.types.ListNamespacesRequest):
                The initial request object.
            response (google.cloud.datafusion_v1beta1.types.ListNamespacesResponse):
                The initial response object.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        self._method = method
        self._request = v1beta1.ListNamespacesRequest(request)
        self._response = response
        self._metadata = metadata

    def __getattr__(self, name: str) -> Any:
        return getattr(self._response, name)

    @property
    async def pages(self) -> AsyncIterator[v1beta1.ListNamespacesResponse]:
        yield self._response
        while self._response.next_page_token:
            self._request.page_token = self._response.next_page_token
            self._response = await self._method(self._request, metadata=self._metadata)
            yield self._response
    def __aiter__(self) -> AsyncIterator[v1beta1.Namespace]:
        async def async_generator():
            async for page in self.pages:
                for response in page.namespaces:
                    yield response

        return async_generator()

    def __repr__(self) -> str:
        return '{0}<{1!r}>'.format(self.__class__.__name__, self._response)


class ListDnsPeeringsPager:
    """A pager for iterating through ``list_dns_peerings`` requests.

    This class thinly wraps an initial
    :class:`google.cloud.datafusion_v1beta1.types.ListDnsPeeringsResponse` object, and
    provides an ``__iter__`` method to iterate through its
    ``dns_peerings`` field.

    If there are more pages, the ``__iter__`` method will make additional
    ``ListDnsPeerings`` requests and continue to iterate
    through the ``dns_peerings`` field on the
    corresponding responses.

    All the usual :class:`google.cloud.datafusion_v1beta1.types.ListDnsPeeringsResponse`
    attributes are available on the pager. If multiple requests are made, only
    the most recent response is retained, and thus used for attribute lookup.
    """
    def __init__(self,
            method: Callable[..., v1beta1.ListDnsPeeringsResponse],
            request: v1beta1.ListDnsPeeringsRequest,
            response: v1beta1.ListDnsPeeringsResponse,
            *,
            metadata: Sequence[Tuple[str, str]] = ()):
        """Instantiate the pager.

        Args:
            method (Callable): The method that was originally called, and
                which instantiated this pager.
            request (google.cloud.datafusion_v1beta1.types.ListDnsPeeringsRequest):
                The initial request object.
            response (google.cloud.datafusion_v1beta1.types.ListDnsPeeringsResponse):
                The initial response object.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        self._method = method
        self._request = v1beta1.ListDnsPeeringsRequest(request)
        self._response = response
        self._metadata = metadata

    def __getattr__(self, name: str) -> Any:
        return getattr(self._response, name)

    @property
    def pages(self) -> Iterator[v1beta1.ListDnsPeeringsResponse]:
        yield self._response
        while self._response.next_page_token:
            self._request.page_token = self._response.next_page_token
            self._response = self._method(self._request, metadata=self._metadata)
            yield self._response

    def __iter__(self) -> Iterator[v1beta1.DnsPeering]:
        for page in self.pages:
            yield from page.dns_peerings

    def __repr__(self) -> str:
        return '{0}<{1!r}>'.format(self.__class__.__name__, self._response)


class ListDnsPeeringsAsyncPager:
    """A pager for iterating through ``list_dns_peerings`` requests.

    This class thinly wraps an initial
    :class:`google.cloud.datafusion_v1beta1.types.ListDnsPeeringsResponse` object, and
    provides an ``__aiter__`` method to iterate through its
    ``dns_peerings`` field.

    If there are more pages, the ``__aiter__`` method will make additional
    ``ListDnsPeerings`` requests and continue to iterate
    through the ``dns_peerings`` field on the
    corresponding responses.

    All the usual :class:`google.cloud.datafusion_v1beta1.types.ListDnsPeeringsResponse`
    attributes are available on the pager. If multiple requests are made, only
    the most recent response is retained, and thus used for attribute lookup.
    """
    def __init__(self,
            method: Callable[..., Awaitable[v1beta1.ListDnsPeeringsResponse]],
            request: v1beta1.ListDnsPeeringsRequest,
            response: v1beta1.ListDnsPeeringsResponse,
            *,
            metadata: Sequence[Tuple[str, str]] = ()):
        """Instantiates the pager.

        Args:
            method (Callable): The method that was originally called, and
                which instantiated this pager.
            request (google.cloud.datafusion_v1beta1.types.ListDnsPeeringsRequest):
                The initial request object.
            response (google.cloud.datafusion_v1beta1.types.ListDnsPeeringsResponse):
                The initial response object.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        self._method = method
        self._request = v1beta1.ListDnsPeeringsRequest(request)
        self._response = response
        self._metadata = metadata

    def __getattr__(self, name: str) -> Any:
        return getattr(self._response, name)

    @property
    async def pages(self) -> AsyncIterator[v1beta1.ListDnsPeeringsResponse]:
        yield self._response
        while self._response.next_page_token:
            self._request.page_token = self._response.next_page_token
            self._response = await self._method(self._request, metadata=self._metadata)
            yield self._response
    def __aiter__(self) -> AsyncIterator[v1beta1.DnsPeering]:
        async def async_generator():
            async for page in self.pages:
                for response in page.dns_peerings:
                    yield response

        return async_generator()

    def __repr__(self) -> str:
        return '{0}<{1!r}>'.format(self.__class__.__name__, self._response)
