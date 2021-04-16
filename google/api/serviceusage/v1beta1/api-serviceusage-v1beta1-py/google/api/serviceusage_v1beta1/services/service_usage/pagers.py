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

from google.api.serviceusage_v1beta1.types import resources
from google.api.serviceusage_v1beta1.types import serviceusage


class ListServicesPager:
    """A pager for iterating through ``list_services`` requests.

    This class thinly wraps an initial
    :class:`google.api.serviceusage_v1beta1.types.ListServicesResponse` object, and
    provides an ``__iter__`` method to iterate through its
    ``services`` field.

    If there are more pages, the ``__iter__`` method will make additional
    ``ListServices`` requests and continue to iterate
    through the ``services`` field on the
    corresponding responses.

    All the usual :class:`google.api.serviceusage_v1beta1.types.ListServicesResponse`
    attributes are available on the pager. If multiple requests are made, only
    the most recent response is retained, and thus used for attribute lookup.
    """
    def __init__(self,
            method: Callable[..., serviceusage.ListServicesResponse],
            request: serviceusage.ListServicesRequest,
            response: serviceusage.ListServicesResponse,
            *,
            metadata: Sequence[Tuple[str, str]] = ()):
        """Instantiate the pager.

        Args:
            method (Callable): The method that was originally called, and
                which instantiated this pager.
            request (google.api.serviceusage_v1beta1.types.ListServicesRequest):
                The initial request object.
            response (google.api.serviceusage_v1beta1.types.ListServicesResponse):
                The initial response object.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        self._method = method
        self._request = serviceusage.ListServicesRequest(request)
        self._response = response
        self._metadata = metadata

    def __getattr__(self, name: str) -> Any:
        return getattr(self._response, name)

    @property
    def pages(self) -> Iterable[serviceusage.ListServicesResponse]:
        yield self._response
        while self._response.next_page_token:
            self._request.page_token = self._response.next_page_token
            self._response = self._method(self._request, metadata=self._metadata)
            yield self._response

    def __iter__(self) -> Iterable[resources.Service]:
        for page in self.pages:
            yield from page.services

    def __repr__(self) -> str:
        return '{0}<{1!r}>'.format(self.__class__.__name__, self._response)


class ListServicesAsyncPager:
    """A pager for iterating through ``list_services`` requests.

    This class thinly wraps an initial
    :class:`google.api.serviceusage_v1beta1.types.ListServicesResponse` object, and
    provides an ``__aiter__`` method to iterate through its
    ``services`` field.

    If there are more pages, the ``__aiter__`` method will make additional
    ``ListServices`` requests and continue to iterate
    through the ``services`` field on the
    corresponding responses.

    All the usual :class:`google.api.serviceusage_v1beta1.types.ListServicesResponse`
    attributes are available on the pager. If multiple requests are made, only
    the most recent response is retained, and thus used for attribute lookup.
    """
    def __init__(self,
            method: Callable[..., Awaitable[serviceusage.ListServicesResponse]],
            request: serviceusage.ListServicesRequest,
            response: serviceusage.ListServicesResponse,
            *,
            metadata: Sequence[Tuple[str, str]] = ()):
        """Instantiate the pager.

        Args:
            method (Callable): The method that was originally called, and
                which instantiated this pager.
            request (google.api.serviceusage_v1beta1.types.ListServicesRequest):
                The initial request object.
            response (google.api.serviceusage_v1beta1.types.ListServicesResponse):
                The initial response object.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        self._method = method
        self._request = serviceusage.ListServicesRequest(request)
        self._response = response
        self._metadata = metadata

    def __getattr__(self, name: str) -> Any:
        return getattr(self._response, name)

    @property
    async def pages(self) -> AsyncIterable[serviceusage.ListServicesResponse]:
        yield self._response
        while self._response.next_page_token:
            self._request.page_token = self._response.next_page_token
            self._response = await self._method(self._request, metadata=self._metadata)
            yield self._response

    def __aiter__(self) -> AsyncIterable[resources.Service]:
        async def async_generator():
            async for page in self.pages:
                for response in page.services:
                    yield response

        return async_generator()

    def __repr__(self) -> str:
        return '{0}<{1!r}>'.format(self.__class__.__name__, self._response)


class ListConsumerQuotaMetricsPager:
    """A pager for iterating through ``list_consumer_quota_metrics`` requests.

    This class thinly wraps an initial
    :class:`google.api.serviceusage_v1beta1.types.ListConsumerQuotaMetricsResponse` object, and
    provides an ``__iter__`` method to iterate through its
    ``metrics`` field.

    If there are more pages, the ``__iter__`` method will make additional
    ``ListConsumerQuotaMetrics`` requests and continue to iterate
    through the ``metrics`` field on the
    corresponding responses.

    All the usual :class:`google.api.serviceusage_v1beta1.types.ListConsumerQuotaMetricsResponse`
    attributes are available on the pager. If multiple requests are made, only
    the most recent response is retained, and thus used for attribute lookup.
    """
    def __init__(self,
            method: Callable[..., serviceusage.ListConsumerQuotaMetricsResponse],
            request: serviceusage.ListConsumerQuotaMetricsRequest,
            response: serviceusage.ListConsumerQuotaMetricsResponse,
            *,
            metadata: Sequence[Tuple[str, str]] = ()):
        """Instantiate the pager.

        Args:
            method (Callable): The method that was originally called, and
                which instantiated this pager.
            request (google.api.serviceusage_v1beta1.types.ListConsumerQuotaMetricsRequest):
                The initial request object.
            response (google.api.serviceusage_v1beta1.types.ListConsumerQuotaMetricsResponse):
                The initial response object.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        self._method = method
        self._request = serviceusage.ListConsumerQuotaMetricsRequest(request)
        self._response = response
        self._metadata = metadata

    def __getattr__(self, name: str) -> Any:
        return getattr(self._response, name)

    @property
    def pages(self) -> Iterable[serviceusage.ListConsumerQuotaMetricsResponse]:
        yield self._response
        while self._response.next_page_token:
            self._request.page_token = self._response.next_page_token
            self._response = self._method(self._request, metadata=self._metadata)
            yield self._response

    def __iter__(self) -> Iterable[resources.ConsumerQuotaMetric]:
        for page in self.pages:
            yield from page.metrics

    def __repr__(self) -> str:
        return '{0}<{1!r}>'.format(self.__class__.__name__, self._response)


class ListConsumerQuotaMetricsAsyncPager:
    """A pager for iterating through ``list_consumer_quota_metrics`` requests.

    This class thinly wraps an initial
    :class:`google.api.serviceusage_v1beta1.types.ListConsumerQuotaMetricsResponse` object, and
    provides an ``__aiter__`` method to iterate through its
    ``metrics`` field.

    If there are more pages, the ``__aiter__`` method will make additional
    ``ListConsumerQuotaMetrics`` requests and continue to iterate
    through the ``metrics`` field on the
    corresponding responses.

    All the usual :class:`google.api.serviceusage_v1beta1.types.ListConsumerQuotaMetricsResponse`
    attributes are available on the pager. If multiple requests are made, only
    the most recent response is retained, and thus used for attribute lookup.
    """
    def __init__(self,
            method: Callable[..., Awaitable[serviceusage.ListConsumerQuotaMetricsResponse]],
            request: serviceusage.ListConsumerQuotaMetricsRequest,
            response: serviceusage.ListConsumerQuotaMetricsResponse,
            *,
            metadata: Sequence[Tuple[str, str]] = ()):
        """Instantiate the pager.

        Args:
            method (Callable): The method that was originally called, and
                which instantiated this pager.
            request (google.api.serviceusage_v1beta1.types.ListConsumerQuotaMetricsRequest):
                The initial request object.
            response (google.api.serviceusage_v1beta1.types.ListConsumerQuotaMetricsResponse):
                The initial response object.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        self._method = method
        self._request = serviceusage.ListConsumerQuotaMetricsRequest(request)
        self._response = response
        self._metadata = metadata

    def __getattr__(self, name: str) -> Any:
        return getattr(self._response, name)

    @property
    async def pages(self) -> AsyncIterable[serviceusage.ListConsumerQuotaMetricsResponse]:
        yield self._response
        while self._response.next_page_token:
            self._request.page_token = self._response.next_page_token
            self._response = await self._method(self._request, metadata=self._metadata)
            yield self._response

    def __aiter__(self) -> AsyncIterable[resources.ConsumerQuotaMetric]:
        async def async_generator():
            async for page in self.pages:
                for response in page.metrics:
                    yield response

        return async_generator()

    def __repr__(self) -> str:
        return '{0}<{1!r}>'.format(self.__class__.__name__, self._response)


class ListAdminOverridesPager:
    """A pager for iterating through ``list_admin_overrides`` requests.

    This class thinly wraps an initial
    :class:`google.api.serviceusage_v1beta1.types.ListAdminOverridesResponse` object, and
    provides an ``__iter__`` method to iterate through its
    ``overrides`` field.

    If there are more pages, the ``__iter__`` method will make additional
    ``ListAdminOverrides`` requests and continue to iterate
    through the ``overrides`` field on the
    corresponding responses.

    All the usual :class:`google.api.serviceusage_v1beta1.types.ListAdminOverridesResponse`
    attributes are available on the pager. If multiple requests are made, only
    the most recent response is retained, and thus used for attribute lookup.
    """
    def __init__(self,
            method: Callable[..., serviceusage.ListAdminOverridesResponse],
            request: serviceusage.ListAdminOverridesRequest,
            response: serviceusage.ListAdminOverridesResponse,
            *,
            metadata: Sequence[Tuple[str, str]] = ()):
        """Instantiate the pager.

        Args:
            method (Callable): The method that was originally called, and
                which instantiated this pager.
            request (google.api.serviceusage_v1beta1.types.ListAdminOverridesRequest):
                The initial request object.
            response (google.api.serviceusage_v1beta1.types.ListAdminOverridesResponse):
                The initial response object.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        self._method = method
        self._request = serviceusage.ListAdminOverridesRequest(request)
        self._response = response
        self._metadata = metadata

    def __getattr__(self, name: str) -> Any:
        return getattr(self._response, name)

    @property
    def pages(self) -> Iterable[serviceusage.ListAdminOverridesResponse]:
        yield self._response
        while self._response.next_page_token:
            self._request.page_token = self._response.next_page_token
            self._response = self._method(self._request, metadata=self._metadata)
            yield self._response

    def __iter__(self) -> Iterable[resources.QuotaOverride]:
        for page in self.pages:
            yield from page.overrides

    def __repr__(self) -> str:
        return '{0}<{1!r}>'.format(self.__class__.__name__, self._response)


class ListAdminOverridesAsyncPager:
    """A pager for iterating through ``list_admin_overrides`` requests.

    This class thinly wraps an initial
    :class:`google.api.serviceusage_v1beta1.types.ListAdminOverridesResponse` object, and
    provides an ``__aiter__`` method to iterate through its
    ``overrides`` field.

    If there are more pages, the ``__aiter__`` method will make additional
    ``ListAdminOverrides`` requests and continue to iterate
    through the ``overrides`` field on the
    corresponding responses.

    All the usual :class:`google.api.serviceusage_v1beta1.types.ListAdminOverridesResponse`
    attributes are available on the pager. If multiple requests are made, only
    the most recent response is retained, and thus used for attribute lookup.
    """
    def __init__(self,
            method: Callable[..., Awaitable[serviceusage.ListAdminOverridesResponse]],
            request: serviceusage.ListAdminOverridesRequest,
            response: serviceusage.ListAdminOverridesResponse,
            *,
            metadata: Sequence[Tuple[str, str]] = ()):
        """Instantiate the pager.

        Args:
            method (Callable): The method that was originally called, and
                which instantiated this pager.
            request (google.api.serviceusage_v1beta1.types.ListAdminOverridesRequest):
                The initial request object.
            response (google.api.serviceusage_v1beta1.types.ListAdminOverridesResponse):
                The initial response object.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        self._method = method
        self._request = serviceusage.ListAdminOverridesRequest(request)
        self._response = response
        self._metadata = metadata

    def __getattr__(self, name: str) -> Any:
        return getattr(self._response, name)

    @property
    async def pages(self) -> AsyncIterable[serviceusage.ListAdminOverridesResponse]:
        yield self._response
        while self._response.next_page_token:
            self._request.page_token = self._response.next_page_token
            self._response = await self._method(self._request, metadata=self._metadata)
            yield self._response

    def __aiter__(self) -> AsyncIterable[resources.QuotaOverride]:
        async def async_generator():
            async for page in self.pages:
                for response in page.overrides:
                    yield response

        return async_generator()

    def __repr__(self) -> str:
        return '{0}<{1!r}>'.format(self.__class__.__name__, self._response)


class ListConsumerOverridesPager:
    """A pager for iterating through ``list_consumer_overrides`` requests.

    This class thinly wraps an initial
    :class:`google.api.serviceusage_v1beta1.types.ListConsumerOverridesResponse` object, and
    provides an ``__iter__`` method to iterate through its
    ``overrides`` field.

    If there are more pages, the ``__iter__`` method will make additional
    ``ListConsumerOverrides`` requests and continue to iterate
    through the ``overrides`` field on the
    corresponding responses.

    All the usual :class:`google.api.serviceusage_v1beta1.types.ListConsumerOverridesResponse`
    attributes are available on the pager. If multiple requests are made, only
    the most recent response is retained, and thus used for attribute lookup.
    """
    def __init__(self,
            method: Callable[..., serviceusage.ListConsumerOverridesResponse],
            request: serviceusage.ListConsumerOverridesRequest,
            response: serviceusage.ListConsumerOverridesResponse,
            *,
            metadata: Sequence[Tuple[str, str]] = ()):
        """Instantiate the pager.

        Args:
            method (Callable): The method that was originally called, and
                which instantiated this pager.
            request (google.api.serviceusage_v1beta1.types.ListConsumerOverridesRequest):
                The initial request object.
            response (google.api.serviceusage_v1beta1.types.ListConsumerOverridesResponse):
                The initial response object.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        self._method = method
        self._request = serviceusage.ListConsumerOverridesRequest(request)
        self._response = response
        self._metadata = metadata

    def __getattr__(self, name: str) -> Any:
        return getattr(self._response, name)

    @property
    def pages(self) -> Iterable[serviceusage.ListConsumerOverridesResponse]:
        yield self._response
        while self._response.next_page_token:
            self._request.page_token = self._response.next_page_token
            self._response = self._method(self._request, metadata=self._metadata)
            yield self._response

    def __iter__(self) -> Iterable[resources.QuotaOverride]:
        for page in self.pages:
            yield from page.overrides

    def __repr__(self) -> str:
        return '{0}<{1!r}>'.format(self.__class__.__name__, self._response)


class ListConsumerOverridesAsyncPager:
    """A pager for iterating through ``list_consumer_overrides`` requests.

    This class thinly wraps an initial
    :class:`google.api.serviceusage_v1beta1.types.ListConsumerOverridesResponse` object, and
    provides an ``__aiter__`` method to iterate through its
    ``overrides`` field.

    If there are more pages, the ``__aiter__`` method will make additional
    ``ListConsumerOverrides`` requests and continue to iterate
    through the ``overrides`` field on the
    corresponding responses.

    All the usual :class:`google.api.serviceusage_v1beta1.types.ListConsumerOverridesResponse`
    attributes are available on the pager. If multiple requests are made, only
    the most recent response is retained, and thus used for attribute lookup.
    """
    def __init__(self,
            method: Callable[..., Awaitable[serviceusage.ListConsumerOverridesResponse]],
            request: serviceusage.ListConsumerOverridesRequest,
            response: serviceusage.ListConsumerOverridesResponse,
            *,
            metadata: Sequence[Tuple[str, str]] = ()):
        """Instantiate the pager.

        Args:
            method (Callable): The method that was originally called, and
                which instantiated this pager.
            request (google.api.serviceusage_v1beta1.types.ListConsumerOverridesRequest):
                The initial request object.
            response (google.api.serviceusage_v1beta1.types.ListConsumerOverridesResponse):
                The initial response object.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        self._method = method
        self._request = serviceusage.ListConsumerOverridesRequest(request)
        self._response = response
        self._metadata = metadata

    def __getattr__(self, name: str) -> Any:
        return getattr(self._response, name)

    @property
    async def pages(self) -> AsyncIterable[serviceusage.ListConsumerOverridesResponse]:
        yield self._response
        while self._response.next_page_token:
            self._request.page_token = self._response.next_page_token
            self._response = await self._method(self._request, metadata=self._metadata)
            yield self._response

    def __aiter__(self) -> AsyncIterable[resources.QuotaOverride]:
        async def async_generator():
            async for page in self.pages:
                for response in page.overrides:
                    yield response

        return async_generator()

    def __repr__(self) -> str:
        return '{0}<{1!r}>'.format(self.__class__.__name__, self._response)
