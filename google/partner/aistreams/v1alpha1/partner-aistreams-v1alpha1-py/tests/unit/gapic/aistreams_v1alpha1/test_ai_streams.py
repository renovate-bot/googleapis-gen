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

import os
import mock

import grpc
from grpc.experimental import aio
import math
import pytest
from proto.marshal.rules.dates import DurationRule, TimestampRule

from google import auth
from google.api_core import client_options
from google.api_core import exceptions
from google.api_core import future
from google.api_core import gapic_v1
from google.api_core import grpc_helpers
from google.api_core import grpc_helpers_async
from google.api_core import operation_async  # type: ignore
from google.api_core import operations_v1
from google.auth import credentials
from google.auth.exceptions import MutualTLSChannelError
from google.longrunning import operations_pb2
from google.oauth2 import service_account
from google.partner.aistreams_v1alpha1.services.ai_streams import AIStreamsAsyncClient
from google.partner.aistreams_v1alpha1.services.ai_streams import AIStreamsClient
from google.partner.aistreams_v1alpha1.services.ai_streams import pagers
from google.partner.aistreams_v1alpha1.services.ai_streams import transports
from google.partner.aistreams_v1alpha1.types import aistreams
from google.protobuf import field_mask_pb2 as field_mask  # type: ignore
from google.protobuf import timestamp_pb2 as timestamp  # type: ignore


def client_cert_source_callback():
    return b"cert bytes", b"key bytes"


# If default endpoint is localhost, then default mtls endpoint will be the same.
# This method modifies the default endpoint so the client can produce a different
# mtls endpoint for endpoint testing purposes.
def modify_default_endpoint(client):
    return "foo.googleapis.com" if ("localhost" in client.DEFAULT_ENDPOINT) else client.DEFAULT_ENDPOINT


def test__get_default_mtls_endpoint():
    api_endpoint = "example.googleapis.com"
    api_mtls_endpoint = "example.mtls.googleapis.com"
    sandbox_endpoint = "example.sandbox.googleapis.com"
    sandbox_mtls_endpoint = "example.mtls.sandbox.googleapis.com"
    non_googleapi = "api.example.com"

    assert AIStreamsClient._get_default_mtls_endpoint(None) is None
    assert AIStreamsClient._get_default_mtls_endpoint(api_endpoint) == api_mtls_endpoint
    assert AIStreamsClient._get_default_mtls_endpoint(api_mtls_endpoint) == api_mtls_endpoint
    assert AIStreamsClient._get_default_mtls_endpoint(sandbox_endpoint) == sandbox_mtls_endpoint
    assert AIStreamsClient._get_default_mtls_endpoint(sandbox_mtls_endpoint) == sandbox_mtls_endpoint
    assert AIStreamsClient._get_default_mtls_endpoint(non_googleapi) == non_googleapi


@pytest.mark.parametrize("client_class", [
    AIStreamsClient,
    AIStreamsAsyncClient,
])
def test_ai_streams_client_from_service_account_info(client_class):
    creds = credentials.AnonymousCredentials()
    with mock.patch.object(service_account.Credentials, 'from_service_account_info') as factory:
        factory.return_value = creds
        info = {"valid": True}
        client = client_class.from_service_account_info(info)
        assert client.transport._credentials == creds
        assert isinstance(client, client_class)

        assert client.transport._host == 'aistreams.googleapis.com:443'


@pytest.mark.parametrize("client_class", [
    AIStreamsClient,
    AIStreamsAsyncClient,
])
def test_ai_streams_client_from_service_account_file(client_class):
    creds = credentials.AnonymousCredentials()
    with mock.patch.object(service_account.Credentials, 'from_service_account_file') as factory:
        factory.return_value = creds
        client = client_class.from_service_account_file("dummy/file/path.json")
        assert client.transport._credentials == creds
        assert isinstance(client, client_class)

        client = client_class.from_service_account_json("dummy/file/path.json")
        assert client.transport._credentials == creds
        assert isinstance(client, client_class)

        assert client.transport._host == 'aistreams.googleapis.com:443'


def test_ai_streams_client_get_transport_class():
    transport = AIStreamsClient.get_transport_class()
    available_transports = [
        transports.AIStreamsGrpcTransport,
    ]
    assert transport in available_transports

    transport = AIStreamsClient.get_transport_class("grpc")
    assert transport == transports.AIStreamsGrpcTransport


@pytest.mark.parametrize("client_class,transport_class,transport_name", [
    (AIStreamsClient, transports.AIStreamsGrpcTransport, "grpc"),
    (AIStreamsAsyncClient, transports.AIStreamsGrpcAsyncIOTransport, "grpc_asyncio"),
])
@mock.patch.object(AIStreamsClient, "DEFAULT_ENDPOINT", modify_default_endpoint(AIStreamsClient))
@mock.patch.object(AIStreamsAsyncClient, "DEFAULT_ENDPOINT", modify_default_endpoint(AIStreamsAsyncClient))
def test_ai_streams_client_client_options(client_class, transport_class, transport_name):
    # Check that if channel is provided we won't create a new one.
    with mock.patch.object(AIStreamsClient, 'get_transport_class') as gtc:
        transport = transport_class(
            credentials=credentials.AnonymousCredentials()
        )
        client = client_class(transport=transport)
        gtc.assert_not_called()

    # Check that if channel is provided via str we will create a new one.
    with mock.patch.object(AIStreamsClient, 'get_transport_class') as gtc:
        client = client_class(transport=transport_name)
        gtc.assert_called()

    # Check the case api_endpoint is provided.
    options = client_options.ClientOptions(api_endpoint="squid.clam.whelk")
    with mock.patch.object(transport_class, '__init__') as patched:
        patched.return_value = None
        client = client_class(client_options=options)
        patched.assert_called_once_with(
            credentials=None,
            credentials_file=None,
            host="squid.clam.whelk",
            scopes=None,
            client_cert_source_for_mtls=None,
            quota_project_id=None,
            client_info=transports.base.DEFAULT_CLIENT_INFO,
        )

    # Check the case api_endpoint is not provided and GOOGLE_API_USE_MTLS_ENDPOINT is
    # "never".
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_MTLS_ENDPOINT": "never"}):
        with mock.patch.object(transport_class, '__init__') as patched:
            patched.return_value = None
            client = client_class()
            patched.assert_called_once_with(
                credentials=None,
                credentials_file=None,
                host=client.DEFAULT_ENDPOINT,
                scopes=None,
                client_cert_source_for_mtls=None,
                quota_project_id=None,
                client_info=transports.base.DEFAULT_CLIENT_INFO,
            )

    # Check the case api_endpoint is not provided and GOOGLE_API_USE_MTLS_ENDPOINT is
    # "always".
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_MTLS_ENDPOINT": "always"}):
        with mock.patch.object(transport_class, '__init__') as patched:
            patched.return_value = None
            client = client_class()
            patched.assert_called_once_with(
                credentials=None,
                credentials_file=None,
                host=client.DEFAULT_MTLS_ENDPOINT,
                scopes=None,
                client_cert_source_for_mtls=None,
                quota_project_id=None,
                client_info=transports.base.DEFAULT_CLIENT_INFO,
            )

    # Check the case api_endpoint is not provided and GOOGLE_API_USE_MTLS_ENDPOINT has
    # unsupported value.
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_MTLS_ENDPOINT": "Unsupported"}):
        with pytest.raises(MutualTLSChannelError):
            client = client_class()

    # Check the case GOOGLE_API_USE_CLIENT_CERTIFICATE has unsupported value.
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_CLIENT_CERTIFICATE": "Unsupported"}):
        with pytest.raises(ValueError):
            client = client_class()

    # Check the case quota_project_id is provided
    options = client_options.ClientOptions(quota_project_id="octopus")
    with mock.patch.object(transport_class, '__init__') as patched:
        patched.return_value = None
        client = client_class(client_options=options)
        patched.assert_called_once_with(
            credentials=None,
            credentials_file=None,
            host=client.DEFAULT_ENDPOINT,
            scopes=None,
            client_cert_source_for_mtls=None,
            quota_project_id="octopus",
            client_info=transports.base.DEFAULT_CLIENT_INFO,
        )

@pytest.mark.parametrize("client_class,transport_class,transport_name,use_client_cert_env", [

    (AIStreamsClient, transports.AIStreamsGrpcTransport, "grpc", "true"),
    (AIStreamsAsyncClient, transports.AIStreamsGrpcAsyncIOTransport, "grpc_asyncio", "true"),
    (AIStreamsClient, transports.AIStreamsGrpcTransport, "grpc", "false"),
    (AIStreamsAsyncClient, transports.AIStreamsGrpcAsyncIOTransport, "grpc_asyncio", "false"),

])
@mock.patch.object(AIStreamsClient, "DEFAULT_ENDPOINT", modify_default_endpoint(AIStreamsClient))
@mock.patch.object(AIStreamsAsyncClient, "DEFAULT_ENDPOINT", modify_default_endpoint(AIStreamsAsyncClient))
@mock.patch.dict(os.environ, {"GOOGLE_API_USE_MTLS_ENDPOINT": "auto"})
def test_ai_streams_client_mtls_env_auto(client_class, transport_class, transport_name, use_client_cert_env):
    # This tests the endpoint autoswitch behavior. Endpoint is autoswitched to the default
    # mtls endpoint, if GOOGLE_API_USE_CLIENT_CERTIFICATE is "true" and client cert exists.

    # Check the case client_cert_source is provided. Whether client cert is used depends on
    # GOOGLE_API_USE_CLIENT_CERTIFICATE value.
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_CLIENT_CERTIFICATE": use_client_cert_env}):
        options = client_options.ClientOptions(client_cert_source=client_cert_source_callback)
        with mock.patch.object(transport_class, '__init__') as patched:
            patched.return_value = None
            client = client_class(client_options=options)

            if use_client_cert_env == "false":
                expected_client_cert_source = None
                expected_host = client.DEFAULT_ENDPOINT
            else:
                expected_client_cert_source = client_cert_source_callback
                expected_host = client.DEFAULT_MTLS_ENDPOINT

            patched.assert_called_once_with(
                credentials=None,
                credentials_file=None,
                host=expected_host,
                scopes=None,
                client_cert_source_for_mtls=expected_client_cert_source,
                quota_project_id=None,
                client_info=transports.base.DEFAULT_CLIENT_INFO,
            )

    # Check the case ADC client cert is provided. Whether client cert is used depends on
    # GOOGLE_API_USE_CLIENT_CERTIFICATE value.
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_CLIENT_CERTIFICATE": use_client_cert_env}):
        with mock.patch.object(transport_class, '__init__') as patched:
            with mock.patch('google.auth.transport.mtls.has_default_client_cert_source', return_value=True):
                with mock.patch('google.auth.transport.mtls.default_client_cert_source', return_value=client_cert_source_callback):
                    if use_client_cert_env == "false":
                        expected_host = client.DEFAULT_ENDPOINT
                        expected_client_cert_source = None
                    else:
                        expected_host = client.DEFAULT_MTLS_ENDPOINT
                        expected_client_cert_source = client_cert_source_callback

                    patched.return_value = None
                    client = client_class()
                    patched.assert_called_once_with(
                        credentials=None,
                        credentials_file=None,
                        host=expected_host,
                        scopes=None,
                        client_cert_source_for_mtls=expected_client_cert_source,
                        quota_project_id=None,
                        client_info=transports.base.DEFAULT_CLIENT_INFO,
                    )

    # Check the case client_cert_source and ADC client cert are not provided.
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_CLIENT_CERTIFICATE": use_client_cert_env}):
        with mock.patch.object(transport_class, '__init__') as patched:
            with mock.patch("google.auth.transport.mtls.has_default_client_cert_source", return_value=False):
                patched.return_value = None
                client = client_class()
                patched.assert_called_once_with(
                    credentials=None,
                    credentials_file=None,
                    host=client.DEFAULT_ENDPOINT,
                    scopes=None,
                    client_cert_source_for_mtls=None,
                    quota_project_id=None,
                    client_info=transports.base.DEFAULT_CLIENT_INFO,
                )


@pytest.mark.parametrize("client_class,transport_class,transport_name", [
    (AIStreamsClient, transports.AIStreamsGrpcTransport, "grpc"),
    (AIStreamsAsyncClient, transports.AIStreamsGrpcAsyncIOTransport, "grpc_asyncio"),
])
def test_ai_streams_client_client_options_scopes(client_class, transport_class, transport_name):
    # Check the case scopes are provided.
    options = client_options.ClientOptions(
        scopes=["1", "2"],
    )
    with mock.patch.object(transport_class, '__init__') as patched:
        patched.return_value = None
        client = client_class(client_options=options)
        patched.assert_called_once_with(
            credentials=None,
            credentials_file=None,
            host=client.DEFAULT_ENDPOINT,
            scopes=["1", "2"],
            client_cert_source_for_mtls=None,
            quota_project_id=None,
            client_info=transports.base.DEFAULT_CLIENT_INFO,
        )

@pytest.mark.parametrize("client_class,transport_class,transport_name", [
    (AIStreamsClient, transports.AIStreamsGrpcTransport, "grpc"),
    (AIStreamsAsyncClient, transports.AIStreamsGrpcAsyncIOTransport, "grpc_asyncio"),
])
def test_ai_streams_client_client_options_credentials_file(client_class, transport_class, transport_name):
    # Check the case credentials file is provided.
    options = client_options.ClientOptions(
        credentials_file="credentials.json"
    )
    with mock.patch.object(transport_class, '__init__') as patched:
        patched.return_value = None
        client = client_class(client_options=options)
        patched.assert_called_once_with(
            credentials=None,
            credentials_file="credentials.json",
            host=client.DEFAULT_ENDPOINT,
            scopes=None,
            client_cert_source_for_mtls=None,
            quota_project_id=None,
            client_info=transports.base.DEFAULT_CLIENT_INFO,
        )


def test_ai_streams_client_client_options_from_dict():
    with mock.patch('google.partner.aistreams_v1alpha1.services.ai_streams.transports.AIStreamsGrpcTransport.__init__') as grpc_transport:
        grpc_transport.return_value = None
        client = AIStreamsClient(
            client_options={'api_endpoint': 'squid.clam.whelk'}
        )
        grpc_transport.assert_called_once_with(
            credentials=None,
            credentials_file=None,
            host="squid.clam.whelk",
            scopes=None,
            client_cert_source_for_mtls=None,
            quota_project_id=None,
            client_info=transports.base.DEFAULT_CLIENT_INFO,
        )


def test_list_clusters(transport: str = 'grpc', request_type=aistreams.ListClustersRequest):
    client = AIStreamsClient(
        credentials=credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_clusters),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = aistreams.ListClustersResponse(
            next_page_token='next_page_token_value',

            unreachable=['unreachable_value'],

        )

        response = client.list_clusters(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0] == aistreams.ListClustersRequest()

    # Establish that the response is the type that we expect.

    assert isinstance(response, pagers.ListClustersPager)

    assert response.next_page_token == 'next_page_token_value'

    assert response.unreachable == ['unreachable_value']


def test_list_clusters_from_dict():
    test_list_clusters(request_type=dict)


def test_list_clusters_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = AIStreamsClient(
        credentials=credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_clusters),
            '__call__') as call:
        client.list_clusters()
        call.assert_called()
        _, args, _ = call.mock_calls[0]

        assert args[0] == aistreams.ListClustersRequest()

@pytest.mark.asyncio
async def test_list_clusters_async(transport: str = 'grpc_asyncio', request_type=aistreams.ListClustersRequest):
    client = AIStreamsAsyncClient(
        credentials=credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_clusters),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(aistreams.ListClustersResponse(
            next_page_token='next_page_token_value',
            unreachable=['unreachable_value'],
        ))

        response = await client.list_clusters(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]

        assert args[0] == aistreams.ListClustersRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListClustersAsyncPager)

    assert response.next_page_token == 'next_page_token_value'

    assert response.unreachable == ['unreachable_value']


@pytest.mark.asyncio
async def test_list_clusters_async_from_dict():
    await test_list_clusters_async(request_type=dict)


def test_list_clusters_field_headers():
    client = AIStreamsClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = aistreams.ListClustersRequest()
    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_clusters),
            '__call__') as call:
        call.return_value = aistreams.ListClustersResponse()

        client.list_clusters(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'parent=parent/value',
    ) in kw['metadata']


@pytest.mark.asyncio
async def test_list_clusters_field_headers_async():
    client = AIStreamsAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = aistreams.ListClustersRequest()
    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_clusters),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(aistreams.ListClustersResponse())

        await client.list_clusters(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'parent=parent/value',
    ) in kw['metadata']


def test_list_clusters_flattened():
    client = AIStreamsClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_clusters),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = aistreams.ListClustersResponse()

        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.list_clusters(
            parent='parent_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0].parent == 'parent_value'


def test_list_clusters_flattened_error():
    client = AIStreamsClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.list_clusters(
            aistreams.ListClustersRequest(),
            parent='parent_value',
        )


@pytest.mark.asyncio
async def test_list_clusters_flattened_async():
    client = AIStreamsAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_clusters),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = aistreams.ListClustersResponse()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(aistreams.ListClustersResponse())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.list_clusters(
            parent='parent_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]

        assert args[0].parent == 'parent_value'


@pytest.mark.asyncio
async def test_list_clusters_flattened_error_async():
    client = AIStreamsAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.list_clusters(
            aistreams.ListClustersRequest(),
            parent='parent_value',
        )


def test_list_clusters_pager():
    client = AIStreamsClient(
        credentials=credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_clusters),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            aistreams.ListClustersResponse(
                clusters=[
                    aistreams.Cluster(),
                    aistreams.Cluster(),
                    aistreams.Cluster(),
                ],
                next_page_token='abc',
            ),
            aistreams.ListClustersResponse(
                clusters=[],
                next_page_token='def',
            ),
            aistreams.ListClustersResponse(
                clusters=[
                    aistreams.Cluster(),
                ],
                next_page_token='ghi',
            ),
            aistreams.ListClustersResponse(
                clusters=[
                    aistreams.Cluster(),
                    aistreams.Cluster(),
                ],
            ),
            RuntimeError,
        )

        metadata = ()
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ('parent', ''),
            )),
        )
        pager = client.list_clusters(request={})

        assert pager._metadata == metadata

        results = [i for i in pager]
        assert len(results) == 6
        assert all(isinstance(i, aistreams.Cluster)
                   for i in results)

def test_list_clusters_pages():
    client = AIStreamsClient(
        credentials=credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_clusters),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            aistreams.ListClustersResponse(
                clusters=[
                    aistreams.Cluster(),
                    aistreams.Cluster(),
                    aistreams.Cluster(),
                ],
                next_page_token='abc',
            ),
            aistreams.ListClustersResponse(
                clusters=[],
                next_page_token='def',
            ),
            aistreams.ListClustersResponse(
                clusters=[
                    aistreams.Cluster(),
                ],
                next_page_token='ghi',
            ),
            aistreams.ListClustersResponse(
                clusters=[
                    aistreams.Cluster(),
                    aistreams.Cluster(),
                ],
            ),
            RuntimeError,
        )
        pages = list(client.list_clusters(request={}).pages)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

@pytest.mark.asyncio
async def test_list_clusters_async_pager():
    client = AIStreamsAsyncClient(
        credentials=credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_clusters),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            aistreams.ListClustersResponse(
                clusters=[
                    aistreams.Cluster(),
                    aistreams.Cluster(),
                    aistreams.Cluster(),
                ],
                next_page_token='abc',
            ),
            aistreams.ListClustersResponse(
                clusters=[],
                next_page_token='def',
            ),
            aistreams.ListClustersResponse(
                clusters=[
                    aistreams.Cluster(),
                ],
                next_page_token='ghi',
            ),
            aistreams.ListClustersResponse(
                clusters=[
                    aistreams.Cluster(),
                    aistreams.Cluster(),
                ],
            ),
            RuntimeError,
        )
        async_pager = await client.list_clusters(request={},)
        assert async_pager.next_page_token == 'abc'
        responses = []
        async for response in async_pager:
            responses.append(response)

        assert len(responses) == 6
        assert all(isinstance(i, aistreams.Cluster)
                   for i in responses)

@pytest.mark.asyncio
async def test_list_clusters_async_pages():
    client = AIStreamsAsyncClient(
        credentials=credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_clusters),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            aistreams.ListClustersResponse(
                clusters=[
                    aistreams.Cluster(),
                    aistreams.Cluster(),
                    aistreams.Cluster(),
                ],
                next_page_token='abc',
            ),
            aistreams.ListClustersResponse(
                clusters=[],
                next_page_token='def',
            ),
            aistreams.ListClustersResponse(
                clusters=[
                    aistreams.Cluster(),
                ],
                next_page_token='ghi',
            ),
            aistreams.ListClustersResponse(
                clusters=[
                    aistreams.Cluster(),
                    aistreams.Cluster(),
                ],
            ),
            RuntimeError,
        )
        pages = []
        async for page_ in (await client.list_clusters(request={})).pages:
            pages.append(page_)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token


def test_get_cluster(transport: str = 'grpc', request_type=aistreams.GetClusterRequest):
    client = AIStreamsClient(
        credentials=credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_cluster),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = aistreams.Cluster(
            name='name_value',

            certificate='certificate_value',

            service_endpoint='service_endpoint_value',

        )

        response = client.get_cluster(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0] == aistreams.GetClusterRequest()

    # Establish that the response is the type that we expect.

    assert isinstance(response, aistreams.Cluster)

    assert response.name == 'name_value'

    assert response.certificate == 'certificate_value'

    assert response.service_endpoint == 'service_endpoint_value'


def test_get_cluster_from_dict():
    test_get_cluster(request_type=dict)


def test_get_cluster_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = AIStreamsClient(
        credentials=credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_cluster),
            '__call__') as call:
        client.get_cluster()
        call.assert_called()
        _, args, _ = call.mock_calls[0]

        assert args[0] == aistreams.GetClusterRequest()

@pytest.mark.asyncio
async def test_get_cluster_async(transport: str = 'grpc_asyncio', request_type=aistreams.GetClusterRequest):
    client = AIStreamsAsyncClient(
        credentials=credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_cluster),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(aistreams.Cluster(
            name='name_value',
            certificate='certificate_value',
            service_endpoint='service_endpoint_value',
        ))

        response = await client.get_cluster(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]

        assert args[0] == aistreams.GetClusterRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, aistreams.Cluster)

    assert response.name == 'name_value'

    assert response.certificate == 'certificate_value'

    assert response.service_endpoint == 'service_endpoint_value'


@pytest.mark.asyncio
async def test_get_cluster_async_from_dict():
    await test_get_cluster_async(request_type=dict)


def test_get_cluster_field_headers():
    client = AIStreamsClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = aistreams.GetClusterRequest()
    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_cluster),
            '__call__') as call:
        call.return_value = aistreams.Cluster()

        client.get_cluster(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'name=name/value',
    ) in kw['metadata']


@pytest.mark.asyncio
async def test_get_cluster_field_headers_async():
    client = AIStreamsAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = aistreams.GetClusterRequest()
    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_cluster),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(aistreams.Cluster())

        await client.get_cluster(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'name=name/value',
    ) in kw['metadata']


def test_get_cluster_flattened():
    client = AIStreamsClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_cluster),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = aistreams.Cluster()

        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.get_cluster(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0].name == 'name_value'


def test_get_cluster_flattened_error():
    client = AIStreamsClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.get_cluster(
            aistreams.GetClusterRequest(),
            name='name_value',
        )


@pytest.mark.asyncio
async def test_get_cluster_flattened_async():
    client = AIStreamsAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_cluster),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = aistreams.Cluster()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(aistreams.Cluster())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.get_cluster(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]

        assert args[0].name == 'name_value'


@pytest.mark.asyncio
async def test_get_cluster_flattened_error_async():
    client = AIStreamsAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.get_cluster(
            aistreams.GetClusterRequest(),
            name='name_value',
        )


def test_create_cluster(transport: str = 'grpc', request_type=aistreams.CreateClusterRequest):
    client = AIStreamsClient(
        credentials=credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_cluster),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/spam')

        response = client.create_cluster(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0] == aistreams.CreateClusterRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


def test_create_cluster_from_dict():
    test_create_cluster(request_type=dict)


def test_create_cluster_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = AIStreamsClient(
        credentials=credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_cluster),
            '__call__') as call:
        client.create_cluster()
        call.assert_called()
        _, args, _ = call.mock_calls[0]

        assert args[0] == aistreams.CreateClusterRequest()

@pytest.mark.asyncio
async def test_create_cluster_async(transport: str = 'grpc_asyncio', request_type=aistreams.CreateClusterRequest):
    client = AIStreamsAsyncClient(
        credentials=credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_cluster),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )

        response = await client.create_cluster(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]

        assert args[0] == aistreams.CreateClusterRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


@pytest.mark.asyncio
async def test_create_cluster_async_from_dict():
    await test_create_cluster_async(request_type=dict)


def test_create_cluster_field_headers():
    client = AIStreamsClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = aistreams.CreateClusterRequest()
    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_cluster),
            '__call__') as call:
        call.return_value = operations_pb2.Operation(name='operations/op')

        client.create_cluster(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'parent=parent/value',
    ) in kw['metadata']


@pytest.mark.asyncio
async def test_create_cluster_field_headers_async():
    client = AIStreamsAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = aistreams.CreateClusterRequest()
    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_cluster),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(operations_pb2.Operation(name='operations/op'))

        await client.create_cluster(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'parent=parent/value',
    ) in kw['metadata']


def test_create_cluster_flattened():
    client = AIStreamsClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_cluster),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/op')

        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.create_cluster(
            parent='parent_value',
            cluster=aistreams.Cluster(name='name_value'),
            cluster_id='cluster_id_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0].parent == 'parent_value'

        assert args[0].cluster == aistreams.Cluster(name='name_value')

        assert args[0].cluster_id == 'cluster_id_value'


def test_create_cluster_flattened_error():
    client = AIStreamsClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.create_cluster(
            aistreams.CreateClusterRequest(),
            parent='parent_value',
            cluster=aistreams.Cluster(name='name_value'),
            cluster_id='cluster_id_value',
        )


@pytest.mark.asyncio
async def test_create_cluster_flattened_async():
    client = AIStreamsAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_cluster),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/op')

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.create_cluster(
            parent='parent_value',
            cluster=aistreams.Cluster(name='name_value'),
            cluster_id='cluster_id_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]

        assert args[0].parent == 'parent_value'

        assert args[0].cluster == aistreams.Cluster(name='name_value')

        assert args[0].cluster_id == 'cluster_id_value'


@pytest.mark.asyncio
async def test_create_cluster_flattened_error_async():
    client = AIStreamsAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.create_cluster(
            aistreams.CreateClusterRequest(),
            parent='parent_value',
            cluster=aistreams.Cluster(name='name_value'),
            cluster_id='cluster_id_value',
        )


def test_update_cluster(transport: str = 'grpc', request_type=aistreams.UpdateClusterRequest):
    client = AIStreamsClient(
        credentials=credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_cluster),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/spam')

        response = client.update_cluster(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0] == aistreams.UpdateClusterRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


def test_update_cluster_from_dict():
    test_update_cluster(request_type=dict)


def test_update_cluster_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = AIStreamsClient(
        credentials=credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_cluster),
            '__call__') as call:
        client.update_cluster()
        call.assert_called()
        _, args, _ = call.mock_calls[0]

        assert args[0] == aistreams.UpdateClusterRequest()

@pytest.mark.asyncio
async def test_update_cluster_async(transport: str = 'grpc_asyncio', request_type=aistreams.UpdateClusterRequest):
    client = AIStreamsAsyncClient(
        credentials=credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_cluster),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )

        response = await client.update_cluster(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]

        assert args[0] == aistreams.UpdateClusterRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


@pytest.mark.asyncio
async def test_update_cluster_async_from_dict():
    await test_update_cluster_async(request_type=dict)


def test_update_cluster_field_headers():
    client = AIStreamsClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = aistreams.UpdateClusterRequest()
    request.cluster.name = 'cluster.name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_cluster),
            '__call__') as call:
        call.return_value = operations_pb2.Operation(name='operations/op')

        client.update_cluster(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'cluster.name=cluster.name/value',
    ) in kw['metadata']


@pytest.mark.asyncio
async def test_update_cluster_field_headers_async():
    client = AIStreamsAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = aistreams.UpdateClusterRequest()
    request.cluster.name = 'cluster.name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_cluster),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(operations_pb2.Operation(name='operations/op'))

        await client.update_cluster(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'cluster.name=cluster.name/value',
    ) in kw['metadata']


def test_update_cluster_flattened():
    client = AIStreamsClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_cluster),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/op')

        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.update_cluster(
            cluster=aistreams.Cluster(name='name_value'),
            update_mask=field_mask.FieldMask(paths=['paths_value']),
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0].cluster == aistreams.Cluster(name='name_value')

        assert args[0].update_mask == field_mask.FieldMask(paths=['paths_value'])


def test_update_cluster_flattened_error():
    client = AIStreamsClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.update_cluster(
            aistreams.UpdateClusterRequest(),
            cluster=aistreams.Cluster(name='name_value'),
            update_mask=field_mask.FieldMask(paths=['paths_value']),
        )


@pytest.mark.asyncio
async def test_update_cluster_flattened_async():
    client = AIStreamsAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_cluster),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/op')

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.update_cluster(
            cluster=aistreams.Cluster(name='name_value'),
            update_mask=field_mask.FieldMask(paths=['paths_value']),
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]

        assert args[0].cluster == aistreams.Cluster(name='name_value')

        assert args[0].update_mask == field_mask.FieldMask(paths=['paths_value'])


@pytest.mark.asyncio
async def test_update_cluster_flattened_error_async():
    client = AIStreamsAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.update_cluster(
            aistreams.UpdateClusterRequest(),
            cluster=aistreams.Cluster(name='name_value'),
            update_mask=field_mask.FieldMask(paths=['paths_value']),
        )


def test_delete_cluster(transport: str = 'grpc', request_type=aistreams.DeleteClusterRequest):
    client = AIStreamsClient(
        credentials=credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_cluster),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/spam')

        response = client.delete_cluster(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0] == aistreams.DeleteClusterRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


def test_delete_cluster_from_dict():
    test_delete_cluster(request_type=dict)


def test_delete_cluster_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = AIStreamsClient(
        credentials=credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_cluster),
            '__call__') as call:
        client.delete_cluster()
        call.assert_called()
        _, args, _ = call.mock_calls[0]

        assert args[0] == aistreams.DeleteClusterRequest()

@pytest.mark.asyncio
async def test_delete_cluster_async(transport: str = 'grpc_asyncio', request_type=aistreams.DeleteClusterRequest):
    client = AIStreamsAsyncClient(
        credentials=credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_cluster),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )

        response = await client.delete_cluster(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]

        assert args[0] == aistreams.DeleteClusterRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


@pytest.mark.asyncio
async def test_delete_cluster_async_from_dict():
    await test_delete_cluster_async(request_type=dict)


def test_delete_cluster_field_headers():
    client = AIStreamsClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = aistreams.DeleteClusterRequest()
    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_cluster),
            '__call__') as call:
        call.return_value = operations_pb2.Operation(name='operations/op')

        client.delete_cluster(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'name=name/value',
    ) in kw['metadata']


@pytest.mark.asyncio
async def test_delete_cluster_field_headers_async():
    client = AIStreamsAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = aistreams.DeleteClusterRequest()
    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_cluster),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(operations_pb2.Operation(name='operations/op'))

        await client.delete_cluster(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'name=name/value',
    ) in kw['metadata']


def test_delete_cluster_flattened():
    client = AIStreamsClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_cluster),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/op')

        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.delete_cluster(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0].name == 'name_value'


def test_delete_cluster_flattened_error():
    client = AIStreamsClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.delete_cluster(
            aistreams.DeleteClusterRequest(),
            name='name_value',
        )


@pytest.mark.asyncio
async def test_delete_cluster_flattened_async():
    client = AIStreamsAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_cluster),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/op')

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.delete_cluster(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]

        assert args[0].name == 'name_value'


@pytest.mark.asyncio
async def test_delete_cluster_flattened_error_async():
    client = AIStreamsAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.delete_cluster(
            aistreams.DeleteClusterRequest(),
            name='name_value',
        )


def test_list_streams(transport: str = 'grpc', request_type=aistreams.ListStreamsRequest):
    client = AIStreamsClient(
        credentials=credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_streams),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = aistreams.ListStreamsResponse(
            next_page_token='next_page_token_value',

            unreachable=['unreachable_value'],

        )

        response = client.list_streams(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0] == aistreams.ListStreamsRequest()

    # Establish that the response is the type that we expect.

    assert isinstance(response, pagers.ListStreamsPager)

    assert response.next_page_token == 'next_page_token_value'

    assert response.unreachable == ['unreachable_value']


def test_list_streams_from_dict():
    test_list_streams(request_type=dict)


def test_list_streams_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = AIStreamsClient(
        credentials=credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_streams),
            '__call__') as call:
        client.list_streams()
        call.assert_called()
        _, args, _ = call.mock_calls[0]

        assert args[0] == aistreams.ListStreamsRequest()

@pytest.mark.asyncio
async def test_list_streams_async(transport: str = 'grpc_asyncio', request_type=aistreams.ListStreamsRequest):
    client = AIStreamsAsyncClient(
        credentials=credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_streams),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(aistreams.ListStreamsResponse(
            next_page_token='next_page_token_value',
            unreachable=['unreachable_value'],
        ))

        response = await client.list_streams(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]

        assert args[0] == aistreams.ListStreamsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListStreamsAsyncPager)

    assert response.next_page_token == 'next_page_token_value'

    assert response.unreachable == ['unreachable_value']


@pytest.mark.asyncio
async def test_list_streams_async_from_dict():
    await test_list_streams_async(request_type=dict)


def test_list_streams_field_headers():
    client = AIStreamsClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = aistreams.ListStreamsRequest()
    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_streams),
            '__call__') as call:
        call.return_value = aistreams.ListStreamsResponse()

        client.list_streams(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'parent=parent/value',
    ) in kw['metadata']


@pytest.mark.asyncio
async def test_list_streams_field_headers_async():
    client = AIStreamsAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = aistreams.ListStreamsRequest()
    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_streams),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(aistreams.ListStreamsResponse())

        await client.list_streams(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'parent=parent/value',
    ) in kw['metadata']


def test_list_streams_flattened():
    client = AIStreamsClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_streams),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = aistreams.ListStreamsResponse()

        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.list_streams(
            parent='parent_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0].parent == 'parent_value'


def test_list_streams_flattened_error():
    client = AIStreamsClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.list_streams(
            aistreams.ListStreamsRequest(),
            parent='parent_value',
        )


@pytest.mark.asyncio
async def test_list_streams_flattened_async():
    client = AIStreamsAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_streams),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = aistreams.ListStreamsResponse()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(aistreams.ListStreamsResponse())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.list_streams(
            parent='parent_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]

        assert args[0].parent == 'parent_value'


@pytest.mark.asyncio
async def test_list_streams_flattened_error_async():
    client = AIStreamsAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.list_streams(
            aistreams.ListStreamsRequest(),
            parent='parent_value',
        )


def test_list_streams_pager():
    client = AIStreamsClient(
        credentials=credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_streams),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            aistreams.ListStreamsResponse(
                streams=[
                    aistreams.Stream(),
                    aistreams.Stream(),
                    aistreams.Stream(),
                ],
                next_page_token='abc',
            ),
            aistreams.ListStreamsResponse(
                streams=[],
                next_page_token='def',
            ),
            aistreams.ListStreamsResponse(
                streams=[
                    aistreams.Stream(),
                ],
                next_page_token='ghi',
            ),
            aistreams.ListStreamsResponse(
                streams=[
                    aistreams.Stream(),
                    aistreams.Stream(),
                ],
            ),
            RuntimeError,
        )

        metadata = ()
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ('parent', ''),
            )),
        )
        pager = client.list_streams(request={})

        assert pager._metadata == metadata

        results = [i for i in pager]
        assert len(results) == 6
        assert all(isinstance(i, aistreams.Stream)
                   for i in results)

def test_list_streams_pages():
    client = AIStreamsClient(
        credentials=credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_streams),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            aistreams.ListStreamsResponse(
                streams=[
                    aistreams.Stream(),
                    aistreams.Stream(),
                    aistreams.Stream(),
                ],
                next_page_token='abc',
            ),
            aistreams.ListStreamsResponse(
                streams=[],
                next_page_token='def',
            ),
            aistreams.ListStreamsResponse(
                streams=[
                    aistreams.Stream(),
                ],
                next_page_token='ghi',
            ),
            aistreams.ListStreamsResponse(
                streams=[
                    aistreams.Stream(),
                    aistreams.Stream(),
                ],
            ),
            RuntimeError,
        )
        pages = list(client.list_streams(request={}).pages)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

@pytest.mark.asyncio
async def test_list_streams_async_pager():
    client = AIStreamsAsyncClient(
        credentials=credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_streams),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            aistreams.ListStreamsResponse(
                streams=[
                    aistreams.Stream(),
                    aistreams.Stream(),
                    aistreams.Stream(),
                ],
                next_page_token='abc',
            ),
            aistreams.ListStreamsResponse(
                streams=[],
                next_page_token='def',
            ),
            aistreams.ListStreamsResponse(
                streams=[
                    aistreams.Stream(),
                ],
                next_page_token='ghi',
            ),
            aistreams.ListStreamsResponse(
                streams=[
                    aistreams.Stream(),
                    aistreams.Stream(),
                ],
            ),
            RuntimeError,
        )
        async_pager = await client.list_streams(request={},)
        assert async_pager.next_page_token == 'abc'
        responses = []
        async for response in async_pager:
            responses.append(response)

        assert len(responses) == 6
        assert all(isinstance(i, aistreams.Stream)
                   for i in responses)

@pytest.mark.asyncio
async def test_list_streams_async_pages():
    client = AIStreamsAsyncClient(
        credentials=credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_streams),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            aistreams.ListStreamsResponse(
                streams=[
                    aistreams.Stream(),
                    aistreams.Stream(),
                    aistreams.Stream(),
                ],
                next_page_token='abc',
            ),
            aistreams.ListStreamsResponse(
                streams=[],
                next_page_token='def',
            ),
            aistreams.ListStreamsResponse(
                streams=[
                    aistreams.Stream(),
                ],
                next_page_token='ghi',
            ),
            aistreams.ListStreamsResponse(
                streams=[
                    aistreams.Stream(),
                    aistreams.Stream(),
                ],
            ),
            RuntimeError,
        )
        pages = []
        async for page_ in (await client.list_streams(request={})).pages:
            pages.append(page_)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token


def test_get_stream(transport: str = 'grpc', request_type=aistreams.GetStreamRequest):
    client = AIStreamsClient(
        credentials=credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_stream),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = aistreams.Stream(
            name='name_value',

        )

        response = client.get_stream(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0] == aistreams.GetStreamRequest()

    # Establish that the response is the type that we expect.

    assert isinstance(response, aistreams.Stream)

    assert response.name == 'name_value'


def test_get_stream_from_dict():
    test_get_stream(request_type=dict)


def test_get_stream_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = AIStreamsClient(
        credentials=credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_stream),
            '__call__') as call:
        client.get_stream()
        call.assert_called()
        _, args, _ = call.mock_calls[0]

        assert args[0] == aistreams.GetStreamRequest()

@pytest.mark.asyncio
async def test_get_stream_async(transport: str = 'grpc_asyncio', request_type=aistreams.GetStreamRequest):
    client = AIStreamsAsyncClient(
        credentials=credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_stream),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(aistreams.Stream(
            name='name_value',
        ))

        response = await client.get_stream(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]

        assert args[0] == aistreams.GetStreamRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, aistreams.Stream)

    assert response.name == 'name_value'


@pytest.mark.asyncio
async def test_get_stream_async_from_dict():
    await test_get_stream_async(request_type=dict)


def test_get_stream_field_headers():
    client = AIStreamsClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = aistreams.GetStreamRequest()
    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_stream),
            '__call__') as call:
        call.return_value = aistreams.Stream()

        client.get_stream(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'name=name/value',
    ) in kw['metadata']


@pytest.mark.asyncio
async def test_get_stream_field_headers_async():
    client = AIStreamsAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = aistreams.GetStreamRequest()
    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_stream),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(aistreams.Stream())

        await client.get_stream(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'name=name/value',
    ) in kw['metadata']


def test_get_stream_flattened():
    client = AIStreamsClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_stream),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = aistreams.Stream()

        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.get_stream(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0].name == 'name_value'


def test_get_stream_flattened_error():
    client = AIStreamsClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.get_stream(
            aistreams.GetStreamRequest(),
            name='name_value',
        )


@pytest.mark.asyncio
async def test_get_stream_flattened_async():
    client = AIStreamsAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_stream),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = aistreams.Stream()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(aistreams.Stream())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.get_stream(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]

        assert args[0].name == 'name_value'


@pytest.mark.asyncio
async def test_get_stream_flattened_error_async():
    client = AIStreamsAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.get_stream(
            aistreams.GetStreamRequest(),
            name='name_value',
        )


def test_create_stream(transport: str = 'grpc', request_type=aistreams.CreateStreamRequest):
    client = AIStreamsClient(
        credentials=credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_stream),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/spam')

        response = client.create_stream(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0] == aistreams.CreateStreamRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


def test_create_stream_from_dict():
    test_create_stream(request_type=dict)


def test_create_stream_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = AIStreamsClient(
        credentials=credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_stream),
            '__call__') as call:
        client.create_stream()
        call.assert_called()
        _, args, _ = call.mock_calls[0]

        assert args[0] == aistreams.CreateStreamRequest()

@pytest.mark.asyncio
async def test_create_stream_async(transport: str = 'grpc_asyncio', request_type=aistreams.CreateStreamRequest):
    client = AIStreamsAsyncClient(
        credentials=credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_stream),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )

        response = await client.create_stream(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]

        assert args[0] == aistreams.CreateStreamRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


@pytest.mark.asyncio
async def test_create_stream_async_from_dict():
    await test_create_stream_async(request_type=dict)


def test_create_stream_field_headers():
    client = AIStreamsClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = aistreams.CreateStreamRequest()
    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_stream),
            '__call__') as call:
        call.return_value = operations_pb2.Operation(name='operations/op')

        client.create_stream(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'parent=parent/value',
    ) in kw['metadata']


@pytest.mark.asyncio
async def test_create_stream_field_headers_async():
    client = AIStreamsAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = aistreams.CreateStreamRequest()
    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_stream),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(operations_pb2.Operation(name='operations/op'))

        await client.create_stream(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'parent=parent/value',
    ) in kw['metadata']


def test_create_stream_flattened():
    client = AIStreamsClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_stream),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/op')

        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.create_stream(
            parent='parent_value',
            stream=aistreams.Stream(name='name_value'),
            stream_id='stream_id_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0].parent == 'parent_value'

        assert args[0].stream == aistreams.Stream(name='name_value')

        assert args[0].stream_id == 'stream_id_value'


def test_create_stream_flattened_error():
    client = AIStreamsClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.create_stream(
            aistreams.CreateStreamRequest(),
            parent='parent_value',
            stream=aistreams.Stream(name='name_value'),
            stream_id='stream_id_value',
        )


@pytest.mark.asyncio
async def test_create_stream_flattened_async():
    client = AIStreamsAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_stream),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/op')

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.create_stream(
            parent='parent_value',
            stream=aistreams.Stream(name='name_value'),
            stream_id='stream_id_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]

        assert args[0].parent == 'parent_value'

        assert args[0].stream == aistreams.Stream(name='name_value')

        assert args[0].stream_id == 'stream_id_value'


@pytest.mark.asyncio
async def test_create_stream_flattened_error_async():
    client = AIStreamsAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.create_stream(
            aistreams.CreateStreamRequest(),
            parent='parent_value',
            stream=aistreams.Stream(name='name_value'),
            stream_id='stream_id_value',
        )


def test_update_stream(transport: str = 'grpc', request_type=aistreams.UpdateStreamRequest):
    client = AIStreamsClient(
        credentials=credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_stream),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/spam')

        response = client.update_stream(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0] == aistreams.UpdateStreamRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


def test_update_stream_from_dict():
    test_update_stream(request_type=dict)


def test_update_stream_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = AIStreamsClient(
        credentials=credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_stream),
            '__call__') as call:
        client.update_stream()
        call.assert_called()
        _, args, _ = call.mock_calls[0]

        assert args[0] == aistreams.UpdateStreamRequest()

@pytest.mark.asyncio
async def test_update_stream_async(transport: str = 'grpc_asyncio', request_type=aistreams.UpdateStreamRequest):
    client = AIStreamsAsyncClient(
        credentials=credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_stream),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )

        response = await client.update_stream(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]

        assert args[0] == aistreams.UpdateStreamRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


@pytest.mark.asyncio
async def test_update_stream_async_from_dict():
    await test_update_stream_async(request_type=dict)


def test_update_stream_field_headers():
    client = AIStreamsClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = aistreams.UpdateStreamRequest()
    request.stream.name = 'stream.name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_stream),
            '__call__') as call:
        call.return_value = operations_pb2.Operation(name='operations/op')

        client.update_stream(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'stream.name=stream.name/value',
    ) in kw['metadata']


@pytest.mark.asyncio
async def test_update_stream_field_headers_async():
    client = AIStreamsAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = aistreams.UpdateStreamRequest()
    request.stream.name = 'stream.name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_stream),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(operations_pb2.Operation(name='operations/op'))

        await client.update_stream(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'stream.name=stream.name/value',
    ) in kw['metadata']


def test_update_stream_flattened():
    client = AIStreamsClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_stream),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/op')

        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.update_stream(
            stream=aistreams.Stream(name='name_value'),
            update_mask=field_mask.FieldMask(paths=['paths_value']),
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0].stream == aistreams.Stream(name='name_value')

        assert args[0].update_mask == field_mask.FieldMask(paths=['paths_value'])


def test_update_stream_flattened_error():
    client = AIStreamsClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.update_stream(
            aistreams.UpdateStreamRequest(),
            stream=aistreams.Stream(name='name_value'),
            update_mask=field_mask.FieldMask(paths=['paths_value']),
        )


@pytest.mark.asyncio
async def test_update_stream_flattened_async():
    client = AIStreamsAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_stream),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/op')

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.update_stream(
            stream=aistreams.Stream(name='name_value'),
            update_mask=field_mask.FieldMask(paths=['paths_value']),
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]

        assert args[0].stream == aistreams.Stream(name='name_value')

        assert args[0].update_mask == field_mask.FieldMask(paths=['paths_value'])


@pytest.mark.asyncio
async def test_update_stream_flattened_error_async():
    client = AIStreamsAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.update_stream(
            aistreams.UpdateStreamRequest(),
            stream=aistreams.Stream(name='name_value'),
            update_mask=field_mask.FieldMask(paths=['paths_value']),
        )


def test_delete_stream(transport: str = 'grpc', request_type=aistreams.DeleteStreamRequest):
    client = AIStreamsClient(
        credentials=credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_stream),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/spam')

        response = client.delete_stream(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0] == aistreams.DeleteStreamRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


def test_delete_stream_from_dict():
    test_delete_stream(request_type=dict)


def test_delete_stream_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = AIStreamsClient(
        credentials=credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_stream),
            '__call__') as call:
        client.delete_stream()
        call.assert_called()
        _, args, _ = call.mock_calls[0]

        assert args[0] == aistreams.DeleteStreamRequest()

@pytest.mark.asyncio
async def test_delete_stream_async(transport: str = 'grpc_asyncio', request_type=aistreams.DeleteStreamRequest):
    client = AIStreamsAsyncClient(
        credentials=credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_stream),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )

        response = await client.delete_stream(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]

        assert args[0] == aistreams.DeleteStreamRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


@pytest.mark.asyncio
async def test_delete_stream_async_from_dict():
    await test_delete_stream_async(request_type=dict)


def test_delete_stream_field_headers():
    client = AIStreamsClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = aistreams.DeleteStreamRequest()
    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_stream),
            '__call__') as call:
        call.return_value = operations_pb2.Operation(name='operations/op')

        client.delete_stream(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'name=name/value',
    ) in kw['metadata']


@pytest.mark.asyncio
async def test_delete_stream_field_headers_async():
    client = AIStreamsAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = aistreams.DeleteStreamRequest()
    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_stream),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(operations_pb2.Operation(name='operations/op'))

        await client.delete_stream(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'name=name/value',
    ) in kw['metadata']


def test_delete_stream_flattened():
    client = AIStreamsClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_stream),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/op')

        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.delete_stream(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0].name == 'name_value'


def test_delete_stream_flattened_error():
    client = AIStreamsClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.delete_stream(
            aistreams.DeleteStreamRequest(),
            name='name_value',
        )


@pytest.mark.asyncio
async def test_delete_stream_flattened_async():
    client = AIStreamsAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_stream),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/op')

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(
            operations_pb2.Operation(name='operations/spam')
        )
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.delete_stream(
            name='name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]

        assert args[0].name == 'name_value'


@pytest.mark.asyncio
async def test_delete_stream_flattened_error_async():
    client = AIStreamsAsyncClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.delete_stream(
            aistreams.DeleteStreamRequest(),
            name='name_value',
        )


def test_credentials_transport_error():
    # It is an error to provide credentials and a transport instance.
    transport = transports.AIStreamsGrpcTransport(
        credentials=credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = AIStreamsClient(
            credentials=credentials.AnonymousCredentials(),
            transport=transport,
        )

    # It is an error to provide a credentials file and a transport instance.
    transport = transports.AIStreamsGrpcTransport(
        credentials=credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = AIStreamsClient(
            client_options={"credentials_file": "credentials.json"},
            transport=transport,
        )

    # It is an error to provide scopes and a transport instance.
    transport = transports.AIStreamsGrpcTransport(
        credentials=credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = AIStreamsClient(
            client_options={"scopes": ["1", "2"]},
            transport=transport,
        )


def test_transport_instance():
    # A client may be instantiated with a custom transport instance.
    transport = transports.AIStreamsGrpcTransport(
        credentials=credentials.AnonymousCredentials(),
    )
    client = AIStreamsClient(transport=transport)
    assert client.transport is transport


def test_transport_get_channel():
    # A client may be instantiated with a custom transport instance.
    transport = transports.AIStreamsGrpcTransport(
        credentials=credentials.AnonymousCredentials(),
    )
    channel = transport.grpc_channel
    assert channel

    transport = transports.AIStreamsGrpcAsyncIOTransport(
        credentials=credentials.AnonymousCredentials(),
    )
    channel = transport.grpc_channel
    assert channel


@pytest.mark.parametrize("transport_class", [
    transports.AIStreamsGrpcTransport,
    transports.AIStreamsGrpcAsyncIOTransport,
])
def test_transport_adc(transport_class):
    # Test default credentials are used if not provided.
    with mock.patch.object(auth, 'default') as adc:
        adc.return_value = (credentials.AnonymousCredentials(), None)
        transport_class()
        adc.assert_called_once()


def test_transport_grpc_default():
    # A client should use the gRPC transport by default.
    client = AIStreamsClient(
        credentials=credentials.AnonymousCredentials(),
    )
    assert isinstance(
        client.transport,
        transports.AIStreamsGrpcTransport,
    )


def test_ai_streams_base_transport_error():
    # Passing both a credentials object and credentials_file should raise an error
    with pytest.raises(exceptions.DuplicateCredentialArgs):
        transport = transports.AIStreamsTransport(
            credentials=credentials.AnonymousCredentials(),
            credentials_file="credentials.json"
        )


def test_ai_streams_base_transport():
    # Instantiate the base transport.
    with mock.patch('google.partner.aistreams_v1alpha1.services.ai_streams.transports.AIStreamsTransport.__init__') as Transport:
        Transport.return_value = None
        transport = transports.AIStreamsTransport(
            credentials=credentials.AnonymousCredentials(),
        )

    # Every method on the transport should just blindly
    # raise NotImplementedError.
    methods = (
        'list_clusters',
        'get_cluster',
        'create_cluster',
        'update_cluster',
        'delete_cluster',
        'list_streams',
        'get_stream',
        'create_stream',
        'update_stream',
        'delete_stream',
        )
    for method in methods:
        with pytest.raises(NotImplementedError):
            getattr(transport, method)(request=object())

    # Additionally, the LRO client (a property) should
    # also raise NotImplementedError
    with pytest.raises(NotImplementedError):
        transport.operations_client


def test_ai_streams_base_transport_with_credentials_file():
    # Instantiate the base transport with a credentials file
    with mock.patch.object(auth, 'load_credentials_from_file') as load_creds, mock.patch('google.partner.aistreams_v1alpha1.services.ai_streams.transports.AIStreamsTransport._prep_wrapped_messages') as Transport:
        Transport.return_value = None
        load_creds.return_value = (credentials.AnonymousCredentials(), None)
        transport = transports.AIStreamsTransport(
            credentials_file="credentials.json",
            quota_project_id="octopus",
        )
        load_creds.assert_called_once_with("credentials.json", scopes=(
            'https://www.googleapis.com/auth/cloud-platform',
            ),
            quota_project_id="octopus",
        )


def test_ai_streams_base_transport_with_adc():
    # Test the default credentials are used if credentials and credentials_file are None.
    with mock.patch.object(auth, 'default') as adc, mock.patch('google.partner.aistreams_v1alpha1.services.ai_streams.transports.AIStreamsTransport._prep_wrapped_messages') as Transport:
        Transport.return_value = None
        adc.return_value = (credentials.AnonymousCredentials(), None)
        transport = transports.AIStreamsTransport()
        adc.assert_called_once()


def test_ai_streams_auth_adc():
    # If no credentials are provided, we should use ADC credentials.
    with mock.patch.object(auth, 'default') as adc:
        adc.return_value = (credentials.AnonymousCredentials(), None)
        AIStreamsClient()
        adc.assert_called_once_with(scopes=(
            'https://www.googleapis.com/auth/cloud-platform',),
            quota_project_id=None,
        )


def test_ai_streams_transport_auth_adc():
    # If credentials and host are not provided, the transport class should use
    # ADC credentials.
    with mock.patch.object(auth, 'default') as adc:
        adc.return_value = (credentials.AnonymousCredentials(), None)
        transports.AIStreamsGrpcTransport(host="squid.clam.whelk", quota_project_id="octopus")
        adc.assert_called_once_with(scopes=(
            'https://www.googleapis.com/auth/cloud-platform',),
            quota_project_id="octopus",
        )


@pytest.mark.parametrize("transport_class", [transports.AIStreamsGrpcTransport, transports.AIStreamsGrpcAsyncIOTransport])
def test_ai_streams_grpc_transport_client_cert_source_for_mtls(
    transport_class
):
    cred = credentials.AnonymousCredentials()

    # Check ssl_channel_credentials is used if provided.
    with mock.patch.object(transport_class, "create_channel") as mock_create_channel:
        mock_ssl_channel_creds = mock.Mock()
        transport_class(
            host="squid.clam.whelk",
            credentials=cred,
            ssl_channel_credentials=mock_ssl_channel_creds
        )
        mock_create_channel.assert_called_once_with(
            "squid.clam.whelk:443",
            credentials=cred,
            credentials_file=None,
            scopes=(
                'https://www.googleapis.com/auth/cloud-platform',
            ),
            ssl_credentials=mock_ssl_channel_creds,
            quota_project_id=None,
            options=[
                ("grpc.max_send_message_length", -1),
                ("grpc.max_receive_message_length", -1),
            ],
        )

    # Check if ssl_channel_credentials is not provided, then client_cert_source_for_mtls
    # is used.
    with mock.patch.object(transport_class, "create_channel", return_value=mock.Mock()):
        with mock.patch("grpc.ssl_channel_credentials") as mock_ssl_cred:
            transport_class(
                credentials=cred,
                client_cert_source_for_mtls=client_cert_source_callback
            )
            expected_cert, expected_key = client_cert_source_callback()
            mock_ssl_cred.assert_called_once_with(
                certificate_chain=expected_cert,
                private_key=expected_key
            )


def test_ai_streams_host_no_port():
    client = AIStreamsClient(
        credentials=credentials.AnonymousCredentials(),
        client_options=client_options.ClientOptions(api_endpoint='aistreams.googleapis.com'),
    )
    assert client.transport._host == 'aistreams.googleapis.com:443'


def test_ai_streams_host_with_port():
    client = AIStreamsClient(
        credentials=credentials.AnonymousCredentials(),
        client_options=client_options.ClientOptions(api_endpoint='aistreams.googleapis.com:8000'),
    )
    assert client.transport._host == 'aistreams.googleapis.com:8000'


def test_ai_streams_grpc_transport_channel():
    channel = grpc.secure_channel('http://localhost/', grpc.local_channel_credentials())

    # Check that channel is used if provided.
    transport = transports.AIStreamsGrpcTransport(
        host="squid.clam.whelk",
        channel=channel,
    )
    assert transport.grpc_channel == channel
    assert transport._host == "squid.clam.whelk:443"
    assert transport._ssl_channel_credentials == None


def test_ai_streams_grpc_asyncio_transport_channel():
    channel = aio.secure_channel('http://localhost/', grpc.local_channel_credentials())

    # Check that channel is used if provided.
    transport = transports.AIStreamsGrpcAsyncIOTransport(
        host="squid.clam.whelk",
        channel=channel,
    )
    assert transport.grpc_channel == channel
    assert transport._host == "squid.clam.whelk:443"
    assert transport._ssl_channel_credentials == None


# Remove this test when deprecated arguments (api_mtls_endpoint, client_cert_source) are
# removed from grpc/grpc_asyncio transport constructor.
@pytest.mark.parametrize("transport_class", [transports.AIStreamsGrpcTransport, transports.AIStreamsGrpcAsyncIOTransport])
def test_ai_streams_transport_channel_mtls_with_client_cert_source(
    transport_class
):
    with mock.patch("grpc.ssl_channel_credentials", autospec=True) as grpc_ssl_channel_cred:
        with mock.patch.object(transport_class, "create_channel") as grpc_create_channel:
            mock_ssl_cred = mock.Mock()
            grpc_ssl_channel_cred.return_value = mock_ssl_cred

            mock_grpc_channel = mock.Mock()
            grpc_create_channel.return_value = mock_grpc_channel

            cred = credentials.AnonymousCredentials()
            with pytest.warns(DeprecationWarning):
                with mock.patch.object(auth, 'default') as adc:
                    adc.return_value = (cred, None)
                    transport = transport_class(
                        host="squid.clam.whelk",
                        api_mtls_endpoint="mtls.squid.clam.whelk",
                        client_cert_source=client_cert_source_callback,
                    )
                    adc.assert_called_once()

            grpc_ssl_channel_cred.assert_called_once_with(
                certificate_chain=b"cert bytes", private_key=b"key bytes"
            )
            grpc_create_channel.assert_called_once_with(
                "mtls.squid.clam.whelk:443",
                credentials=cred,
                credentials_file=None,
                scopes=(
                    'https://www.googleapis.com/auth/cloud-platform',
                ),
                ssl_credentials=mock_ssl_cred,
                quota_project_id=None,
                options=[
                    ("grpc.max_send_message_length", -1),
                    ("grpc.max_receive_message_length", -1),
                ],
            )
            assert transport.grpc_channel == mock_grpc_channel
            assert transport._ssl_channel_credentials == mock_ssl_cred


# Remove this test when deprecated arguments (api_mtls_endpoint, client_cert_source) are
# removed from grpc/grpc_asyncio transport constructor.
@pytest.mark.parametrize("transport_class", [transports.AIStreamsGrpcTransport, transports.AIStreamsGrpcAsyncIOTransport])
def test_ai_streams_transport_channel_mtls_with_adc(
    transport_class
):
    mock_ssl_cred = mock.Mock()
    with mock.patch.multiple(
        "google.auth.transport.grpc.SslCredentials",
        __init__=mock.Mock(return_value=None),
        ssl_credentials=mock.PropertyMock(return_value=mock_ssl_cred),
    ):
        with mock.patch.object(transport_class, "create_channel") as grpc_create_channel:
            mock_grpc_channel = mock.Mock()
            grpc_create_channel.return_value = mock_grpc_channel
            mock_cred = mock.Mock()

            with pytest.warns(DeprecationWarning):
                transport = transport_class(
                    host="squid.clam.whelk",
                    credentials=mock_cred,
                    api_mtls_endpoint="mtls.squid.clam.whelk",
                    client_cert_source=None,
                )

            grpc_create_channel.assert_called_once_with(
                "mtls.squid.clam.whelk:443",
                credentials=mock_cred,
                credentials_file=None,
                scopes=(
                    'https://www.googleapis.com/auth/cloud-platform',
                ),
                ssl_credentials=mock_ssl_cred,
                quota_project_id=None,
                options=[
                    ("grpc.max_send_message_length", -1),
                    ("grpc.max_receive_message_length", -1),
                ],
            )
            assert transport.grpc_channel == mock_grpc_channel


def test_ai_streams_grpc_lro_client():
    client = AIStreamsClient(
        credentials=credentials.AnonymousCredentials(),
        transport='grpc',
    )
    transport = client.transport

    # Ensure that we have a api-core operations client.
    assert isinstance(
        transport.operations_client,
        operations_v1.OperationsClient,
    )

    # Ensure that subsequent calls to the property send the exact same object.
    assert transport.operations_client is transport.operations_client


def test_ai_streams_grpc_lro_async_client():
    client = AIStreamsAsyncClient(
        credentials=credentials.AnonymousCredentials(),
        transport='grpc_asyncio',
    )
    transport = client.transport

    # Ensure that we have a api-core operations client.
    assert isinstance(
        transport.operations_client,
        operations_v1.OperationsAsyncClient,
    )

    # Ensure that subsequent calls to the property send the exact same object.
    assert transport.operations_client is transport.operations_client


def test_cluster_path():
    project = "squid"
    location = "clam"
    cluster = "whelk"

    expected = "projects/{project}/locations/{location}/clusters/{cluster}".format(project=project, location=location, cluster=cluster, )
    actual = AIStreamsClient.cluster_path(project, location, cluster)
    assert expected == actual


def test_parse_cluster_path():
    expected = {
    "project": "octopus",
    "location": "oyster",
    "cluster": "nudibranch",

    }
    path = AIStreamsClient.cluster_path(**expected)

    # Check that the path construction is reversible.
    actual = AIStreamsClient.parse_cluster_path(path)
    assert expected == actual

def test_stream_path():
    project = "cuttlefish"
    location = "mussel"
    cluster = "winkle"
    stream = "nautilus"

    expected = "projects/{project}/locations/{location}/clusters/{cluster}/streams/{stream}".format(project=project, location=location, cluster=cluster, stream=stream, )
    actual = AIStreamsClient.stream_path(project, location, cluster, stream)
    assert expected == actual


def test_parse_stream_path():
    expected = {
    "project": "scallop",
    "location": "abalone",
    "cluster": "squid",
    "stream": "clam",

    }
    path = AIStreamsClient.stream_path(**expected)

    # Check that the path construction is reversible.
    actual = AIStreamsClient.parse_stream_path(path)
    assert expected == actual

def test_common_billing_account_path():
    billing_account = "whelk"

    expected = "billingAccounts/{billing_account}".format(billing_account=billing_account, )
    actual = AIStreamsClient.common_billing_account_path(billing_account)
    assert expected == actual


def test_parse_common_billing_account_path():
    expected = {
    "billing_account": "octopus",

    }
    path = AIStreamsClient.common_billing_account_path(**expected)

    # Check that the path construction is reversible.
    actual = AIStreamsClient.parse_common_billing_account_path(path)
    assert expected == actual

def test_common_folder_path():
    folder = "oyster"

    expected = "folders/{folder}".format(folder=folder, )
    actual = AIStreamsClient.common_folder_path(folder)
    assert expected == actual


def test_parse_common_folder_path():
    expected = {
    "folder": "nudibranch",

    }
    path = AIStreamsClient.common_folder_path(**expected)

    # Check that the path construction is reversible.
    actual = AIStreamsClient.parse_common_folder_path(path)
    assert expected == actual

def test_common_organization_path():
    organization = "cuttlefish"

    expected = "organizations/{organization}".format(organization=organization, )
    actual = AIStreamsClient.common_organization_path(organization)
    assert expected == actual


def test_parse_common_organization_path():
    expected = {
    "organization": "mussel",

    }
    path = AIStreamsClient.common_organization_path(**expected)

    # Check that the path construction is reversible.
    actual = AIStreamsClient.parse_common_organization_path(path)
    assert expected == actual

def test_common_project_path():
    project = "winkle"

    expected = "projects/{project}".format(project=project, )
    actual = AIStreamsClient.common_project_path(project)
    assert expected == actual


def test_parse_common_project_path():
    expected = {
    "project": "nautilus",

    }
    path = AIStreamsClient.common_project_path(**expected)

    # Check that the path construction is reversible.
    actual = AIStreamsClient.parse_common_project_path(path)
    assert expected == actual

def test_common_location_path():
    project = "scallop"
    location = "abalone"

    expected = "projects/{project}/locations/{location}".format(project=project, location=location, )
    actual = AIStreamsClient.common_location_path(project, location)
    assert expected == actual


def test_parse_common_location_path():
    expected = {
    "project": "squid",
    "location": "clam",

    }
    path = AIStreamsClient.common_location_path(**expected)

    # Check that the path construction is reversible.
    actual = AIStreamsClient.parse_common_location_path(path)
    assert expected == actual


def test_client_withDEFAULT_CLIENT_INFO():
    client_info = gapic_v1.client_info.ClientInfo()

    with mock.patch.object(transports.AIStreamsTransport, '_prep_wrapped_messages') as prep:
        client = AIStreamsClient(
            credentials=credentials.AnonymousCredentials(),
            client_info=client_info,
        )
        prep.assert_called_once_with(client_info)

    with mock.patch.object(transports.AIStreamsTransport, '_prep_wrapped_messages') as prep:
        transport_class = AIStreamsClient.get_transport_class()
        transport = transport_class(
            credentials=credentials.AnonymousCredentials(),
            client_info=client_info,
        )
        prep.assert_called_once_with(client_info)
