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

from google.home.enterprise.sdm_v1.types import device
from google.home.enterprise.sdm_v1.types import site
from google.home.enterprise.sdm_v1.types import smart_device_management_service


class ListDevicesPager:
    """A pager for iterating through ``list_devices`` requests.

    This class thinly wraps an initial
    :class:`google.home.enterprise.sdm_v1.types.ListDevicesResponse` object, and
    provides an ``__iter__`` method to iterate through its
    ``devices`` field.

    If there are more pages, the ``__iter__`` method will make additional
    ``ListDevices`` requests and continue to iterate
    through the ``devices`` field on the
    corresponding responses.

    All the usual :class:`google.home.enterprise.sdm_v1.types.ListDevicesResponse`
    attributes are available on the pager. If multiple requests are made, only
    the most recent response is retained, and thus used for attribute lookup.
    """
    def __init__(self,
            method: Callable[..., smart_device_management_service.ListDevicesResponse],
            request: smart_device_management_service.ListDevicesRequest,
            response: smart_device_management_service.ListDevicesResponse,
            *,
            metadata: Sequence[Tuple[str, str]] = ()):
        """Instantiate the pager.

        Args:
            method (Callable): The method that was originally called, and
                which instantiated this pager.
            request (google.home.enterprise.sdm_v1.types.ListDevicesRequest):
                The initial request object.
            response (google.home.enterprise.sdm_v1.types.ListDevicesResponse):
                The initial response object.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        self._method = method
        self._request = smart_device_management_service.ListDevicesRequest(request)
        self._response = response
        self._metadata = metadata

    def __getattr__(self, name: str) -> Any:
        return getattr(self._response, name)

    @property
    def pages(self) -> Iterator[smart_device_management_service.ListDevicesResponse]:
        yield self._response
        while self._response.next_page_token:
            self._request.page_token = self._response.next_page_token
            self._response = self._method(self._request, metadata=self._metadata)
            yield self._response

    def __iter__(self) -> Iterator[device.Device]:
        for page in self.pages:
            yield from page.devices

    def __repr__(self) -> str:
        return '{0}<{1!r}>'.format(self.__class__.__name__, self._response)


class ListDevicesAsyncPager:
    """A pager for iterating through ``list_devices`` requests.

    This class thinly wraps an initial
    :class:`google.home.enterprise.sdm_v1.types.ListDevicesResponse` object, and
    provides an ``__aiter__`` method to iterate through its
    ``devices`` field.

    If there are more pages, the ``__aiter__`` method will make additional
    ``ListDevices`` requests and continue to iterate
    through the ``devices`` field on the
    corresponding responses.

    All the usual :class:`google.home.enterprise.sdm_v1.types.ListDevicesResponse`
    attributes are available on the pager. If multiple requests are made, only
    the most recent response is retained, and thus used for attribute lookup.
    """
    def __init__(self,
            method: Callable[..., Awaitable[smart_device_management_service.ListDevicesResponse]],
            request: smart_device_management_service.ListDevicesRequest,
            response: smart_device_management_service.ListDevicesResponse,
            *,
            metadata: Sequence[Tuple[str, str]] = ()):
        """Instantiates the pager.

        Args:
            method (Callable): The method that was originally called, and
                which instantiated this pager.
            request (google.home.enterprise.sdm_v1.types.ListDevicesRequest):
                The initial request object.
            response (google.home.enterprise.sdm_v1.types.ListDevicesResponse):
                The initial response object.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        self._method = method
        self._request = smart_device_management_service.ListDevicesRequest(request)
        self._response = response
        self._metadata = metadata

    def __getattr__(self, name: str) -> Any:
        return getattr(self._response, name)

    @property
    async def pages(self) -> AsyncIterator[smart_device_management_service.ListDevicesResponse]:
        yield self._response
        while self._response.next_page_token:
            self._request.page_token = self._response.next_page_token
            self._response = await self._method(self._request, metadata=self._metadata)
            yield self._response
    def __aiter__(self) -> AsyncIterator[device.Device]:
        async def async_generator():
            async for page in self.pages:
                for response in page.devices:
                    yield response

        return async_generator()

    def __repr__(self) -> str:
        return '{0}<{1!r}>'.format(self.__class__.__name__, self._response)


class ListStructuresPager:
    """A pager for iterating through ``list_structures`` requests.

    This class thinly wraps an initial
    :class:`google.home.enterprise.sdm_v1.types.ListStructuresResponse` object, and
    provides an ``__iter__`` method to iterate through its
    ``structures`` field.

    If there are more pages, the ``__iter__`` method will make additional
    ``ListStructures`` requests and continue to iterate
    through the ``structures`` field on the
    corresponding responses.

    All the usual :class:`google.home.enterprise.sdm_v1.types.ListStructuresResponse`
    attributes are available on the pager. If multiple requests are made, only
    the most recent response is retained, and thus used for attribute lookup.
    """
    def __init__(self,
            method: Callable[..., smart_device_management_service.ListStructuresResponse],
            request: smart_device_management_service.ListStructuresRequest,
            response: smart_device_management_service.ListStructuresResponse,
            *,
            metadata: Sequence[Tuple[str, str]] = ()):
        """Instantiate the pager.

        Args:
            method (Callable): The method that was originally called, and
                which instantiated this pager.
            request (google.home.enterprise.sdm_v1.types.ListStructuresRequest):
                The initial request object.
            response (google.home.enterprise.sdm_v1.types.ListStructuresResponse):
                The initial response object.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        self._method = method
        self._request = smart_device_management_service.ListStructuresRequest(request)
        self._response = response
        self._metadata = metadata

    def __getattr__(self, name: str) -> Any:
        return getattr(self._response, name)

    @property
    def pages(self) -> Iterator[smart_device_management_service.ListStructuresResponse]:
        yield self._response
        while self._response.next_page_token:
            self._request.page_token = self._response.next_page_token
            self._response = self._method(self._request, metadata=self._metadata)
            yield self._response

    def __iter__(self) -> Iterator[site.Structure]:
        for page in self.pages:
            yield from page.structures

    def __repr__(self) -> str:
        return '{0}<{1!r}>'.format(self.__class__.__name__, self._response)


class ListStructuresAsyncPager:
    """A pager for iterating through ``list_structures`` requests.

    This class thinly wraps an initial
    :class:`google.home.enterprise.sdm_v1.types.ListStructuresResponse` object, and
    provides an ``__aiter__`` method to iterate through its
    ``structures`` field.

    If there are more pages, the ``__aiter__`` method will make additional
    ``ListStructures`` requests and continue to iterate
    through the ``structures`` field on the
    corresponding responses.

    All the usual :class:`google.home.enterprise.sdm_v1.types.ListStructuresResponse`
    attributes are available on the pager. If multiple requests are made, only
    the most recent response is retained, and thus used for attribute lookup.
    """
    def __init__(self,
            method: Callable[..., Awaitable[smart_device_management_service.ListStructuresResponse]],
            request: smart_device_management_service.ListStructuresRequest,
            response: smart_device_management_service.ListStructuresResponse,
            *,
            metadata: Sequence[Tuple[str, str]] = ()):
        """Instantiates the pager.

        Args:
            method (Callable): The method that was originally called, and
                which instantiated this pager.
            request (google.home.enterprise.sdm_v1.types.ListStructuresRequest):
                The initial request object.
            response (google.home.enterprise.sdm_v1.types.ListStructuresResponse):
                The initial response object.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        self._method = method
        self._request = smart_device_management_service.ListStructuresRequest(request)
        self._response = response
        self._metadata = metadata

    def __getattr__(self, name: str) -> Any:
        return getattr(self._response, name)

    @property
    async def pages(self) -> AsyncIterator[smart_device_management_service.ListStructuresResponse]:
        yield self._response
        while self._response.next_page_token:
            self._request.page_token = self._response.next_page_token
            self._response = await self._method(self._request, metadata=self._metadata)
            yield self._response
    def __aiter__(self) -> AsyncIterator[site.Structure]:
        async def async_generator():
            async for page in self.pages:
                for response in page.structures:
                    yield response

        return async_generator()

    def __repr__(self) -> str:
        return '{0}<{1!r}>'.format(self.__class__.__name__, self._response)


class ListRoomsPager:
    """A pager for iterating through ``list_rooms`` requests.

    This class thinly wraps an initial
    :class:`google.home.enterprise.sdm_v1.types.ListRoomsResponse` object, and
    provides an ``__iter__`` method to iterate through its
    ``rooms`` field.

    If there are more pages, the ``__iter__`` method will make additional
    ``ListRooms`` requests and continue to iterate
    through the ``rooms`` field on the
    corresponding responses.

    All the usual :class:`google.home.enterprise.sdm_v1.types.ListRoomsResponse`
    attributes are available on the pager. If multiple requests are made, only
    the most recent response is retained, and thus used for attribute lookup.
    """
    def __init__(self,
            method: Callable[..., smart_device_management_service.ListRoomsResponse],
            request: smart_device_management_service.ListRoomsRequest,
            response: smart_device_management_service.ListRoomsResponse,
            *,
            metadata: Sequence[Tuple[str, str]] = ()):
        """Instantiate the pager.

        Args:
            method (Callable): The method that was originally called, and
                which instantiated this pager.
            request (google.home.enterprise.sdm_v1.types.ListRoomsRequest):
                The initial request object.
            response (google.home.enterprise.sdm_v1.types.ListRoomsResponse):
                The initial response object.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        self._method = method
        self._request = smart_device_management_service.ListRoomsRequest(request)
        self._response = response
        self._metadata = metadata

    def __getattr__(self, name: str) -> Any:
        return getattr(self._response, name)

    @property
    def pages(self) -> Iterator[smart_device_management_service.ListRoomsResponse]:
        yield self._response
        while self._response.next_page_token:
            self._request.page_token = self._response.next_page_token
            self._response = self._method(self._request, metadata=self._metadata)
            yield self._response

    def __iter__(self) -> Iterator[site.Room]:
        for page in self.pages:
            yield from page.rooms

    def __repr__(self) -> str:
        return '{0}<{1!r}>'.format(self.__class__.__name__, self._response)


class ListRoomsAsyncPager:
    """A pager for iterating through ``list_rooms`` requests.

    This class thinly wraps an initial
    :class:`google.home.enterprise.sdm_v1.types.ListRoomsResponse` object, and
    provides an ``__aiter__`` method to iterate through its
    ``rooms`` field.

    If there are more pages, the ``__aiter__`` method will make additional
    ``ListRooms`` requests and continue to iterate
    through the ``rooms`` field on the
    corresponding responses.

    All the usual :class:`google.home.enterprise.sdm_v1.types.ListRoomsResponse`
    attributes are available on the pager. If multiple requests are made, only
    the most recent response is retained, and thus used for attribute lookup.
    """
    def __init__(self,
            method: Callable[..., Awaitable[smart_device_management_service.ListRoomsResponse]],
            request: smart_device_management_service.ListRoomsRequest,
            response: smart_device_management_service.ListRoomsResponse,
            *,
            metadata: Sequence[Tuple[str, str]] = ()):
        """Instantiates the pager.

        Args:
            method (Callable): The method that was originally called, and
                which instantiated this pager.
            request (google.home.enterprise.sdm_v1.types.ListRoomsRequest):
                The initial request object.
            response (google.home.enterprise.sdm_v1.types.ListRoomsResponse):
                The initial response object.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        self._method = method
        self._request = smart_device_management_service.ListRoomsRequest(request)
        self._response = response
        self._metadata = metadata

    def __getattr__(self, name: str) -> Any:
        return getattr(self._response, name)

    @property
    async def pages(self) -> AsyncIterator[smart_device_management_service.ListRoomsResponse]:
        yield self._response
        while self._response.next_page_token:
            self._request.page_token = self._response.next_page_token
            self._response = await self._method(self._request, metadata=self._metadata)
            yield self._response
    def __aiter__(self) -> AsyncIterator[site.Room]:
        async def async_generator():
            async for page in self.pages:
                for response in page.rooms:
                    yield response

        return async_generator()

    def __repr__(self) -> str:
        return '{0}<{1!r}>'.format(self.__class__.__name__, self._response)
