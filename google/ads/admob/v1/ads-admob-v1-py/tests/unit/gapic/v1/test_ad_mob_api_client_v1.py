# -*- coding: utf-8 -*-
#
# Copyright 2020 Google LLC
#
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
#
#     https://www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.

"""Unit tests."""

import mock
import pytest

from google.ads import admob_v1
from google.ads.admob_v1.proto import admob_api_pb2
from google.ads.admob_v1.proto import admob_resources_pb2



class MultiCallableStub(object):
    """Stub for the grpc.UnaryUnaryMultiCallable interface."""
    def __init__(self, method, channel_stub):
        self.method = method
        self.channel_stub = channel_stub

    def __call__(self, request, timeout=None, metadata=None, credentials=None):
        self.channel_stub.requests.append((self.method, request))

        response = None
        if self.channel_stub.responses:
            response = self.channel_stub.responses.pop()

        if isinstance(response, Exception):
            raise response

        if response:
            return response


class ChannelStub(object):
    """Stub for the grpc.Channel interface."""
    def __init__(self, responses = []):
        self.responses = responses
        self.requests = []

    def unary_unary(
            self, method, request_serializer=None, response_deserializer=None):
        return MultiCallableStub(method, self)

    def unary_stream(
            self, method, request_serializer=None, response_deserializer=None):
        return MultiCallableStub(method, self)


class CustomException(Exception):
    pass


class TestAdMobApiClient(object):

    def test_get_publisher_account(self):
        # Setup Expected Response
        name_2 = 'name2-1052831874'
        publisher_id = 'publisherId-1858159042'
        reporting_time_zone = 'reportingTimeZone1270653197'
        currency_code = 'currencyCode1108728155'
        expected_response = {'name': name_2, 'publisher_id': publisher_id, 'reporting_time_zone': reporting_time_zone, 'currency_code': currency_code}
        expected_response = admob_resources_pb2.PublisherAccount(**expected_response)

        # Mock the API response
        channel = ChannelStub(responses = [expected_response])
        patch = mock.patch('google.api_core.grpc_helpers.create_channel')
        with patch as create_channel:
            create_channel.return_value = channel
            client = admob_v1.AdMobApiClient()

        # Setup Request
        name = client.account_path('[ACCOUNT]')

        response = client.get_publisher_account(name)
        assert expected_response == response

        assert len(channel.requests) == 1
        expected_request = admob_api_pb2.GetPublisherAccountRequest(name=name)
        actual_request = channel.requests[0][1]
        assert expected_request == actual_request

    def test_get_publisher_account_exception(self):
        # Mock the API response
        channel = ChannelStub(responses = [CustomException()])
        patch = mock.patch('google.api_core.grpc_helpers.create_channel')
        with patch as create_channel:
            create_channel.return_value = channel
            client = admob_v1.AdMobApiClient()

        # Setup request
        name = client.account_path('[ACCOUNT]')

        with pytest.raises(CustomException):
            client.get_publisher_account(name)

    def test_list_publisher_accounts(self):
        # Setup Expected Response
        next_page_token = ''
        account_element = {}
        account = [account_element]
        expected_response = {'next_page_token': next_page_token, 'account': account}
        expected_response = admob_api_pb2.ListPublisherAccountsResponse(**expected_response)

        # Mock the API response
        channel = ChannelStub(responses = [expected_response])
        patch = mock.patch('google.api_core.grpc_helpers.create_channel')
        with patch as create_channel:
            create_channel.return_value = channel
            client = admob_v1.AdMobApiClient()

        paged_list_response = client.list_publisher_accounts()
        resources = list(paged_list_response)
        assert len(resources) == 1

        assert expected_response.account[0] == resources[0]

        assert len(channel.requests) == 1
        expected_request = admob_api_pb2.ListPublisherAccountsRequest()
        actual_request = channel.requests[0][1]
        assert expected_request == actual_request

    def test_list_publisher_accounts_exception(self):
        channel = ChannelStub(responses = [CustomException()])
        patch = mock.patch('google.api_core.grpc_helpers.create_channel')
        with patch as create_channel:
            create_channel.return_value = channel
            client = admob_v1.AdMobApiClient()

        paged_list_response = client.list_publisher_accounts()
        with pytest.raises(CustomException):
            list(paged_list_response)

    def test_generate_network_report(self):
        # Setup Expected Response
        expected_response = {}
        expected_response = admob_api_pb2.GenerateNetworkReportResponse(**expected_response)

        # Mock the API response
        channel = ChannelStub(responses = [iter([expected_response])])
        patch = mock.patch('google.api_core.grpc_helpers.create_channel')
        with patch as create_channel:
            create_channel.return_value = channel
            client = admob_v1.AdMobApiClient()


        # Setup Request
        parent = client.account_path('[ACCOUNT]')
        report_spec = {}

        response = client.generate_network_report(parent, report_spec)
        resources = list(response)
        assert len(resources) == 1
        assert expected_response == resources[0]

        assert len(channel.requests) == 1
        expected_request = admob_api_pb2.GenerateNetworkReportRequest(parent=parent, report_spec=report_spec)
        actual_request = channel.requests[0][1]
        assert expected_request == actual_request

    def test_generate_network_report_exception(self):
        # Mock the API response
        channel = ChannelStub(responses = [CustomException()])
        patch = mock.patch('google.api_core.grpc_helpers.create_channel')
        with patch as create_channel:
            create_channel.return_value = channel
            client = admob_v1.AdMobApiClient()

        # Setup request
        parent = client.account_path('[ACCOUNT]')
        report_spec = {}

        with pytest.raises(CustomException):
            client.generate_network_report(parent, report_spec)

    def test_generate_mediation_report(self):
        # Setup Expected Response
        expected_response = {}
        expected_response = admob_api_pb2.GenerateMediationReportResponse(**expected_response)

        # Mock the API response
        channel = ChannelStub(responses = [iter([expected_response])])
        patch = mock.patch('google.api_core.grpc_helpers.create_channel')
        with patch as create_channel:
            create_channel.return_value = channel
            client = admob_v1.AdMobApiClient()


        # Setup Request
        parent = client.account_path('[ACCOUNT]')
        report_spec = {}

        response = client.generate_mediation_report(parent, report_spec)
        resources = list(response)
        assert len(resources) == 1
        assert expected_response == resources[0]

        assert len(channel.requests) == 1
        expected_request = admob_api_pb2.GenerateMediationReportRequest(parent=parent, report_spec=report_spec)
        actual_request = channel.requests[0][1]
        assert expected_request == actual_request

    def test_generate_mediation_report_exception(self):
        # Mock the API response
        channel = ChannelStub(responses = [CustomException()])
        patch = mock.patch('google.api_core.grpc_helpers.create_channel')
        with patch as create_channel:
            create_channel.return_value = channel
            client = admob_v1.AdMobApiClient()

        # Setup request
        parent = client.account_path('[ACCOUNT]')
        report_spec = {}

        with pytest.raises(CustomException):
            client.generate_mediation_report(parent, report_spec)
