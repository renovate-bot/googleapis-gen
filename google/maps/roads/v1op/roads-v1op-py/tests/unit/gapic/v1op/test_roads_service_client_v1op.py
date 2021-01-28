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

from google.maps.roads import v1op
from google.maps.roads.v1op.proto import roads_pb2



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


class CustomException(Exception):
    pass


class TestRoadsServiceClient(object):

    def test_snap_to_roads(self):
        # Setup Expected Response
        warning_message = 'warningMessage1427438180'
        expected_response = {'warning_message': warning_message}
        expected_response = roads_pb2.SnapToRoadsResponse(**expected_response)

        # Mock the API response
        channel = ChannelStub(responses = [expected_response])
        patch = mock.patch('google.api_core.grpc_helpers.create_channel')
        with patch as create_channel:
            create_channel.return_value = channel
            client = v1op.RoadsServiceClient()

        # Setup Request
        path = 'path3433509'

        response = client.snap_to_roads(path)
        assert expected_response == response

        assert len(channel.requests) == 1
        expected_request = roads_pb2.SnapToRoadsRequest(path=path)
        actual_request = channel.requests[0][1]
        assert expected_request == actual_request

    def test_snap_to_roads_exception(self):
        # Mock the API response
        channel = ChannelStub(responses = [CustomException()])
        patch = mock.patch('google.api_core.grpc_helpers.create_channel')
        with patch as create_channel:
            create_channel.return_value = channel
            client = v1op.RoadsServiceClient()

        # Setup request
        path = 'path3433509'

        with pytest.raises(CustomException):
            client.snap_to_roads(path)

    def test_list_nearest_roads(self):
        # Setup Expected Response
        expected_response = {}
        expected_response = roads_pb2.ListNearestRoadsResponse(**expected_response)

        # Mock the API response
        channel = ChannelStub(responses = [expected_response])
        patch = mock.patch('google.api_core.grpc_helpers.create_channel')
        with patch as create_channel:
            create_channel.return_value = channel
            client = v1op.RoadsServiceClient()

        # Setup Request
        points = 'points-982754077'

        response = client.list_nearest_roads(points)
        assert expected_response == response

        assert len(channel.requests) == 1
        expected_request = roads_pb2.ListNearestRoadsRequest(points=points)
        actual_request = channel.requests[0][1]
        assert expected_request == actual_request

    def test_list_nearest_roads_exception(self):
        # Mock the API response
        channel = ChannelStub(responses = [CustomException()])
        patch = mock.patch('google.api_core.grpc_helpers.create_channel')
        with patch as create_channel:
            create_channel.return_value = channel
            client = v1op.RoadsServiceClient()

        # Setup request
        points = 'points-982754077'

        with pytest.raises(CustomException):
            client.list_nearest_roads(points)
