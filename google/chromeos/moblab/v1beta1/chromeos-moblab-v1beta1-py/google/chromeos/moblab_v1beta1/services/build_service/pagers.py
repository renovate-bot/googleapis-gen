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

from google.chromeos.moblab_v1beta1.types import build_service
from google.chromeos.moblab_v1beta1.types import resources


class ListBuildTargetsPager:
    """A pager for iterating through ``list_build_targets`` requests.

    This class thinly wraps an initial
    :class:`google.chromeos.moblab_v1beta1.types.ListBuildTargetsResponse` object, and
    provides an ``__iter__`` method to iterate through its
    ``build_targets`` field.

    If there are more pages, the ``__iter__`` method will make additional
    ``ListBuildTargets`` requests and continue to iterate
    through the ``build_targets`` field on the
    corresponding responses.

    All the usual :class:`google.chromeos.moblab_v1beta1.types.ListBuildTargetsResponse`
    attributes are available on the pager. If multiple requests are made, only
    the most recent response is retained, and thus used for attribute lookup.
    """
    def __init__(self,
            method: Callable[..., build_service.ListBuildTargetsResponse],
            request: build_service.ListBuildTargetsRequest,
            response: build_service.ListBuildTargetsResponse,
            *,
            metadata: Sequence[Tuple[str, str]] = ()):
        """Instantiate the pager.

        Args:
            method (Callable): The method that was originally called, and
                which instantiated this pager.
            request (google.chromeos.moblab_v1beta1.types.ListBuildTargetsRequest):
                The initial request object.
            response (google.chromeos.moblab_v1beta1.types.ListBuildTargetsResponse):
                The initial response object.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        self._method = method
        self._request = build_service.ListBuildTargetsRequest(request)
        self._response = response
        self._metadata = metadata

    def __getattr__(self, name: str) -> Any:
        return getattr(self._response, name)

    @property
    def pages(self) -> Iterator[build_service.ListBuildTargetsResponse]:
        yield self._response
        while self._response.next_page_token:
            self._request.page_token = self._response.next_page_token
            self._response = self._method(self._request, metadata=self._metadata)
            yield self._response

    def __iter__(self) -> Iterator[resources.BuildTarget]:
        for page in self.pages:
            yield from page.build_targets

    def __repr__(self) -> str:
        return '{0}<{1!r}>'.format(self.__class__.__name__, self._response)


class ListBuildTargetsAsyncPager:
    """A pager for iterating through ``list_build_targets`` requests.

    This class thinly wraps an initial
    :class:`google.chromeos.moblab_v1beta1.types.ListBuildTargetsResponse` object, and
    provides an ``__aiter__`` method to iterate through its
    ``build_targets`` field.

    If there are more pages, the ``__aiter__`` method will make additional
    ``ListBuildTargets`` requests and continue to iterate
    through the ``build_targets`` field on the
    corresponding responses.

    All the usual :class:`google.chromeos.moblab_v1beta1.types.ListBuildTargetsResponse`
    attributes are available on the pager. If multiple requests are made, only
    the most recent response is retained, and thus used for attribute lookup.
    """
    def __init__(self,
            method: Callable[..., Awaitable[build_service.ListBuildTargetsResponse]],
            request: build_service.ListBuildTargetsRequest,
            response: build_service.ListBuildTargetsResponse,
            *,
            metadata: Sequence[Tuple[str, str]] = ()):
        """Instantiates the pager.

        Args:
            method (Callable): The method that was originally called, and
                which instantiated this pager.
            request (google.chromeos.moblab_v1beta1.types.ListBuildTargetsRequest):
                The initial request object.
            response (google.chromeos.moblab_v1beta1.types.ListBuildTargetsResponse):
                The initial response object.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        self._method = method
        self._request = build_service.ListBuildTargetsRequest(request)
        self._response = response
        self._metadata = metadata

    def __getattr__(self, name: str) -> Any:
        return getattr(self._response, name)

    @property
    async def pages(self) -> AsyncIterator[build_service.ListBuildTargetsResponse]:
        yield self._response
        while self._response.next_page_token:
            self._request.page_token = self._response.next_page_token
            self._response = await self._method(self._request, metadata=self._metadata)
            yield self._response

    def __aiter__(self) -> AsyncIterator[resources.BuildTarget]:
        async def async_generator():
            async for page in self.pages:
                for response in page.build_targets:
                    yield response

        return async_generator()

    def __repr__(self) -> str:
        return '{0}<{1!r}>'.format(self.__class__.__name__, self._response)


class ListModelsPager:
    """A pager for iterating through ``list_models`` requests.

    This class thinly wraps an initial
    :class:`google.chromeos.moblab_v1beta1.types.ListModelsResponse` object, and
    provides an ``__iter__`` method to iterate through its
    ``models`` field.

    If there are more pages, the ``__iter__`` method will make additional
    ``ListModels`` requests and continue to iterate
    through the ``models`` field on the
    corresponding responses.

    All the usual :class:`google.chromeos.moblab_v1beta1.types.ListModelsResponse`
    attributes are available on the pager. If multiple requests are made, only
    the most recent response is retained, and thus used for attribute lookup.
    """
    def __init__(self,
            method: Callable[..., build_service.ListModelsResponse],
            request: build_service.ListModelsRequest,
            response: build_service.ListModelsResponse,
            *,
            metadata: Sequence[Tuple[str, str]] = ()):
        """Instantiate the pager.

        Args:
            method (Callable): The method that was originally called, and
                which instantiated this pager.
            request (google.chromeos.moblab_v1beta1.types.ListModelsRequest):
                The initial request object.
            response (google.chromeos.moblab_v1beta1.types.ListModelsResponse):
                The initial response object.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        self._method = method
        self._request = build_service.ListModelsRequest(request)
        self._response = response
        self._metadata = metadata

    def __getattr__(self, name: str) -> Any:
        return getattr(self._response, name)

    @property
    def pages(self) -> Iterator[build_service.ListModelsResponse]:
        yield self._response
        while self._response.next_page_token:
            self._request.page_token = self._response.next_page_token
            self._response = self._method(self._request, metadata=self._metadata)
            yield self._response

    def __iter__(self) -> Iterator[resources.Model]:
        for page in self.pages:
            yield from page.models

    def __repr__(self) -> str:
        return '{0}<{1!r}>'.format(self.__class__.__name__, self._response)


class ListModelsAsyncPager:
    """A pager for iterating through ``list_models`` requests.

    This class thinly wraps an initial
    :class:`google.chromeos.moblab_v1beta1.types.ListModelsResponse` object, and
    provides an ``__aiter__`` method to iterate through its
    ``models`` field.

    If there are more pages, the ``__aiter__`` method will make additional
    ``ListModels`` requests and continue to iterate
    through the ``models`` field on the
    corresponding responses.

    All the usual :class:`google.chromeos.moblab_v1beta1.types.ListModelsResponse`
    attributes are available on the pager. If multiple requests are made, only
    the most recent response is retained, and thus used for attribute lookup.
    """
    def __init__(self,
            method: Callable[..., Awaitable[build_service.ListModelsResponse]],
            request: build_service.ListModelsRequest,
            response: build_service.ListModelsResponse,
            *,
            metadata: Sequence[Tuple[str, str]] = ()):
        """Instantiates the pager.

        Args:
            method (Callable): The method that was originally called, and
                which instantiated this pager.
            request (google.chromeos.moblab_v1beta1.types.ListModelsRequest):
                The initial request object.
            response (google.chromeos.moblab_v1beta1.types.ListModelsResponse):
                The initial response object.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        self._method = method
        self._request = build_service.ListModelsRequest(request)
        self._response = response
        self._metadata = metadata

    def __getattr__(self, name: str) -> Any:
        return getattr(self._response, name)

    @property
    async def pages(self) -> AsyncIterator[build_service.ListModelsResponse]:
        yield self._response
        while self._response.next_page_token:
            self._request.page_token = self._response.next_page_token
            self._response = await self._method(self._request, metadata=self._metadata)
            yield self._response

    def __aiter__(self) -> AsyncIterator[resources.Model]:
        async def async_generator():
            async for page in self.pages:
                for response in page.models:
                    yield response

        return async_generator()

    def __repr__(self) -> str:
        return '{0}<{1!r}>'.format(self.__class__.__name__, self._response)


class ListBuildsPager:
    """A pager for iterating through ``list_builds`` requests.

    This class thinly wraps an initial
    :class:`google.chromeos.moblab_v1beta1.types.ListBuildsResponse` object, and
    provides an ``__iter__`` method to iterate through its
    ``builds`` field.

    If there are more pages, the ``__iter__`` method will make additional
    ``ListBuilds`` requests and continue to iterate
    through the ``builds`` field on the
    corresponding responses.

    All the usual :class:`google.chromeos.moblab_v1beta1.types.ListBuildsResponse`
    attributes are available on the pager. If multiple requests are made, only
    the most recent response is retained, and thus used for attribute lookup.
    """
    def __init__(self,
            method: Callable[..., build_service.ListBuildsResponse],
            request: build_service.ListBuildsRequest,
            response: build_service.ListBuildsResponse,
            *,
            metadata: Sequence[Tuple[str, str]] = ()):
        """Instantiate the pager.

        Args:
            method (Callable): The method that was originally called, and
                which instantiated this pager.
            request (google.chromeos.moblab_v1beta1.types.ListBuildsRequest):
                The initial request object.
            response (google.chromeos.moblab_v1beta1.types.ListBuildsResponse):
                The initial response object.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        self._method = method
        self._request = build_service.ListBuildsRequest(request)
        self._response = response
        self._metadata = metadata

    def __getattr__(self, name: str) -> Any:
        return getattr(self._response, name)

    @property
    def pages(self) -> Iterator[build_service.ListBuildsResponse]:
        yield self._response
        while self._response.next_page_token:
            self._request.page_token = self._response.next_page_token
            self._response = self._method(self._request, metadata=self._metadata)
            yield self._response

    def __iter__(self) -> Iterator[resources.Build]:
        for page in self.pages:
            yield from page.builds

    def __repr__(self) -> str:
        return '{0}<{1!r}>'.format(self.__class__.__name__, self._response)


class ListBuildsAsyncPager:
    """A pager for iterating through ``list_builds`` requests.

    This class thinly wraps an initial
    :class:`google.chromeos.moblab_v1beta1.types.ListBuildsResponse` object, and
    provides an ``__aiter__`` method to iterate through its
    ``builds`` field.

    If there are more pages, the ``__aiter__`` method will make additional
    ``ListBuilds`` requests and continue to iterate
    through the ``builds`` field on the
    corresponding responses.

    All the usual :class:`google.chromeos.moblab_v1beta1.types.ListBuildsResponse`
    attributes are available on the pager. If multiple requests are made, only
    the most recent response is retained, and thus used for attribute lookup.
    """
    def __init__(self,
            method: Callable[..., Awaitable[build_service.ListBuildsResponse]],
            request: build_service.ListBuildsRequest,
            response: build_service.ListBuildsResponse,
            *,
            metadata: Sequence[Tuple[str, str]] = ()):
        """Instantiates the pager.

        Args:
            method (Callable): The method that was originally called, and
                which instantiated this pager.
            request (google.chromeos.moblab_v1beta1.types.ListBuildsRequest):
                The initial request object.
            response (google.chromeos.moblab_v1beta1.types.ListBuildsResponse):
                The initial response object.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        self._method = method
        self._request = build_service.ListBuildsRequest(request)
        self._response = response
        self._metadata = metadata

    def __getattr__(self, name: str) -> Any:
        return getattr(self._response, name)

    @property
    async def pages(self) -> AsyncIterator[build_service.ListBuildsResponse]:
        yield self._response
        while self._response.next_page_token:
            self._request.page_token = self._response.next_page_token
            self._response = await self._method(self._request, metadata=self._metadata)
            yield self._response

    def __aiter__(self) -> AsyncIterator[resources.Build]:
        async def async_generator():
            async for page in self.pages:
                for response in page.builds:
                    yield response

        return async_generator()

    def __repr__(self) -> str:
        return '{0}<{1!r}>'.format(self.__class__.__name__, self._response)
