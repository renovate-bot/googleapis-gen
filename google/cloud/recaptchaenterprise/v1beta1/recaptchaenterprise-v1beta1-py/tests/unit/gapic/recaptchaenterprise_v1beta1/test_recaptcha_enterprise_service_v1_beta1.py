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
import json
import math
import pytest
from proto.marshal.rules.dates import DurationRule, TimestampRule


from google.api_core import client_options
from google.api_core import exceptions as core_exceptions
from google.api_core import gapic_v1
from google.api_core import grpc_helpers
from google.api_core import grpc_helpers_async
from google.api_core import path_template
from google.auth import credentials as ga_credentials
from google.auth.exceptions import MutualTLSChannelError
from google.cloud.recaptchaenterprise_v1beta1.services.recaptcha_enterprise_service_v1_beta1 import RecaptchaEnterpriseServiceV1Beta1AsyncClient
from google.cloud.recaptchaenterprise_v1beta1.services.recaptcha_enterprise_service_v1_beta1 import RecaptchaEnterpriseServiceV1Beta1Client
from google.cloud.recaptchaenterprise_v1beta1.services.recaptcha_enterprise_service_v1_beta1 import pagers
from google.cloud.recaptchaenterprise_v1beta1.services.recaptcha_enterprise_service_v1_beta1 import transports
from google.cloud.recaptchaenterprise_v1beta1.types import recaptchaenterprise
from google.oauth2 import service_account
from google.protobuf import field_mask_pb2  # type: ignore
from google.protobuf import timestamp_pb2  # type: ignore
import google.auth


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

    assert RecaptchaEnterpriseServiceV1Beta1Client._get_default_mtls_endpoint(None) is None
    assert RecaptchaEnterpriseServiceV1Beta1Client._get_default_mtls_endpoint(api_endpoint) == api_mtls_endpoint
    assert RecaptchaEnterpriseServiceV1Beta1Client._get_default_mtls_endpoint(api_mtls_endpoint) == api_mtls_endpoint
    assert RecaptchaEnterpriseServiceV1Beta1Client._get_default_mtls_endpoint(sandbox_endpoint) == sandbox_mtls_endpoint
    assert RecaptchaEnterpriseServiceV1Beta1Client._get_default_mtls_endpoint(sandbox_mtls_endpoint) == sandbox_mtls_endpoint
    assert RecaptchaEnterpriseServiceV1Beta1Client._get_default_mtls_endpoint(non_googleapi) == non_googleapi


@pytest.mark.parametrize("client_class", [
    RecaptchaEnterpriseServiceV1Beta1Client,
    RecaptchaEnterpriseServiceV1Beta1AsyncClient,
])
def test_recaptcha_enterprise_service_v1_beta1_client_from_service_account_info(client_class):
    creds = ga_credentials.AnonymousCredentials()
    with mock.patch.object(service_account.Credentials, 'from_service_account_info') as factory:
        factory.return_value = creds
        info = {"valid": True}
        client = client_class.from_service_account_info(info)
        assert client.transport._credentials == creds
        assert isinstance(client, client_class)

        assert client.transport._host == 'recaptchaenterprise.googleapis.com:443'


@pytest.mark.parametrize("transport_class,transport_name", [
    (transports.RecaptchaEnterpriseServiceV1Beta1GrpcTransport, "grpc"),
    (transports.RecaptchaEnterpriseServiceV1Beta1GrpcAsyncIOTransport, "grpc_asyncio"),
])
def test_recaptcha_enterprise_service_v1_beta1_client_service_account_always_use_jwt(transport_class, transport_name):
    with mock.patch.object(service_account.Credentials, 'with_always_use_jwt_access', create=True) as use_jwt:
        creds = service_account.Credentials(None, None, None)
        transport = transport_class(credentials=creds, always_use_jwt_access=True)
        use_jwt.assert_called_once_with(True)

    with mock.patch.object(service_account.Credentials, 'with_always_use_jwt_access', create=True) as use_jwt:
        creds = service_account.Credentials(None, None, None)
        transport = transport_class(credentials=creds, always_use_jwt_access=False)
        use_jwt.assert_not_called()


@pytest.mark.parametrize("client_class", [
    RecaptchaEnterpriseServiceV1Beta1Client,
    RecaptchaEnterpriseServiceV1Beta1AsyncClient,
])
def test_recaptcha_enterprise_service_v1_beta1_client_from_service_account_file(client_class):
    creds = ga_credentials.AnonymousCredentials()
    with mock.patch.object(service_account.Credentials, 'from_service_account_file') as factory:
        factory.return_value = creds
        client = client_class.from_service_account_file("dummy/file/path.json")
        assert client.transport._credentials == creds
        assert isinstance(client, client_class)

        client = client_class.from_service_account_json("dummy/file/path.json")
        assert client.transport._credentials == creds
        assert isinstance(client, client_class)

        assert client.transport._host == 'recaptchaenterprise.googleapis.com:443'


def test_recaptcha_enterprise_service_v1_beta1_client_get_transport_class():
    transport = RecaptchaEnterpriseServiceV1Beta1Client.get_transport_class()
    available_transports = [
        transports.RecaptchaEnterpriseServiceV1Beta1GrpcTransport,
    ]
    assert transport in available_transports

    transport = RecaptchaEnterpriseServiceV1Beta1Client.get_transport_class("grpc")
    assert transport == transports.RecaptchaEnterpriseServiceV1Beta1GrpcTransport


@pytest.mark.parametrize("client_class,transport_class,transport_name", [
    (RecaptchaEnterpriseServiceV1Beta1Client, transports.RecaptchaEnterpriseServiceV1Beta1GrpcTransport, "grpc"),
    (RecaptchaEnterpriseServiceV1Beta1AsyncClient, transports.RecaptchaEnterpriseServiceV1Beta1GrpcAsyncIOTransport, "grpc_asyncio"),
])
@mock.patch.object(RecaptchaEnterpriseServiceV1Beta1Client, "DEFAULT_ENDPOINT", modify_default_endpoint(RecaptchaEnterpriseServiceV1Beta1Client))
@mock.patch.object(RecaptchaEnterpriseServiceV1Beta1AsyncClient, "DEFAULT_ENDPOINT", modify_default_endpoint(RecaptchaEnterpriseServiceV1Beta1AsyncClient))
def test_recaptcha_enterprise_service_v1_beta1_client_client_options(client_class, transport_class, transport_name):
    # Check that if channel is provided we won't create a new one.
    with mock.patch.object(RecaptchaEnterpriseServiceV1Beta1Client, 'get_transport_class') as gtc:
        transport = transport_class(
            credentials=ga_credentials.AnonymousCredentials()
        )
        client = client_class(transport=transport)
        gtc.assert_not_called()

    # Check that if channel is provided via str we will create a new one.
    with mock.patch.object(RecaptchaEnterpriseServiceV1Beta1Client, 'get_transport_class') as gtc:
        client = client_class(transport=transport_name)
        gtc.assert_called()

    # Check the case api_endpoint is provided.
    options = client_options.ClientOptions(api_endpoint="squid.clam.whelk")
    with mock.patch.object(transport_class, '__init__') as patched:
        patched.return_value = None
        client = client_class(transport=transport_name, client_options=options)
        patched.assert_called_once_with(
            credentials=None,
            credentials_file=None,
            host="squid.clam.whelk",
            scopes=None,
            client_cert_source_for_mtls=None,
            quota_project_id=None,
            client_info=transports.base.DEFAULT_CLIENT_INFO,
            always_use_jwt_access=True,
        )

    # Check the case api_endpoint is not provided and GOOGLE_API_USE_MTLS_ENDPOINT is
    # "never".
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_MTLS_ENDPOINT": "never"}):
        with mock.patch.object(transport_class, '__init__') as patched:
            patched.return_value = None
            client = client_class(transport=transport_name)
            patched.assert_called_once_with(
                credentials=None,
                credentials_file=None,
                host=client.DEFAULT_ENDPOINT,
                scopes=None,
                client_cert_source_for_mtls=None,
                quota_project_id=None,
                client_info=transports.base.DEFAULT_CLIENT_INFO,
                always_use_jwt_access=True,
            )

    # Check the case api_endpoint is not provided and GOOGLE_API_USE_MTLS_ENDPOINT is
    # "always".
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_MTLS_ENDPOINT": "always"}):
        with mock.patch.object(transport_class, '__init__') as patched:
            patched.return_value = None
            client = client_class(transport=transport_name)
            patched.assert_called_once_with(
                credentials=None,
                credentials_file=None,
                host=client.DEFAULT_MTLS_ENDPOINT,
                scopes=None,
                client_cert_source_for_mtls=None,
                quota_project_id=None,
                client_info=transports.base.DEFAULT_CLIENT_INFO,
                always_use_jwt_access=True,
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
        client = client_class(transport=transport_name, client_options=options)
        patched.assert_called_once_with(
            credentials=None,
            credentials_file=None,
            host=client.DEFAULT_ENDPOINT,
            scopes=None,
            client_cert_source_for_mtls=None,
            quota_project_id="octopus",
            client_info=transports.base.DEFAULT_CLIENT_INFO,
            always_use_jwt_access=True,
        )

@pytest.mark.parametrize("client_class,transport_class,transport_name,use_client_cert_env", [
    (RecaptchaEnterpriseServiceV1Beta1Client, transports.RecaptchaEnterpriseServiceV1Beta1GrpcTransport, "grpc", "true"),
    (RecaptchaEnterpriseServiceV1Beta1AsyncClient, transports.RecaptchaEnterpriseServiceV1Beta1GrpcAsyncIOTransport, "grpc_asyncio", "true"),
    (RecaptchaEnterpriseServiceV1Beta1Client, transports.RecaptchaEnterpriseServiceV1Beta1GrpcTransport, "grpc", "false"),
    (RecaptchaEnterpriseServiceV1Beta1AsyncClient, transports.RecaptchaEnterpriseServiceV1Beta1GrpcAsyncIOTransport, "grpc_asyncio", "false"),
])
@mock.patch.object(RecaptchaEnterpriseServiceV1Beta1Client, "DEFAULT_ENDPOINT", modify_default_endpoint(RecaptchaEnterpriseServiceV1Beta1Client))
@mock.patch.object(RecaptchaEnterpriseServiceV1Beta1AsyncClient, "DEFAULT_ENDPOINT", modify_default_endpoint(RecaptchaEnterpriseServiceV1Beta1AsyncClient))
@mock.patch.dict(os.environ, {"GOOGLE_API_USE_MTLS_ENDPOINT": "auto"})
def test_recaptcha_enterprise_service_v1_beta1_client_mtls_env_auto(client_class, transport_class, transport_name, use_client_cert_env):
    # This tests the endpoint autoswitch behavior. Endpoint is autoswitched to the default
    # mtls endpoint, if GOOGLE_API_USE_CLIENT_CERTIFICATE is "true" and client cert exists.

    # Check the case client_cert_source is provided. Whether client cert is used depends on
    # GOOGLE_API_USE_CLIENT_CERTIFICATE value.
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_CLIENT_CERTIFICATE": use_client_cert_env}):
        options = client_options.ClientOptions(client_cert_source=client_cert_source_callback)
        with mock.patch.object(transport_class, '__init__') as patched:
            patched.return_value = None
            client = client_class(transport=transport_name, client_options=options)

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
                always_use_jwt_access=True,
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
                    client = client_class(transport=transport_name)
                    patched.assert_called_once_with(
                        credentials=None,
                        credentials_file=None,
                        host=expected_host,
                        scopes=None,
                        client_cert_source_for_mtls=expected_client_cert_source,
                        quota_project_id=None,
                        client_info=transports.base.DEFAULT_CLIENT_INFO,
                        always_use_jwt_access=True,
                    )

    # Check the case client_cert_source and ADC client cert are not provided.
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_CLIENT_CERTIFICATE": use_client_cert_env}):
        with mock.patch.object(transport_class, '__init__') as patched:
            with mock.patch("google.auth.transport.mtls.has_default_client_cert_source", return_value=False):
                patched.return_value = None
                client = client_class(transport=transport_name)
                patched.assert_called_once_with(
                    credentials=None,
                    credentials_file=None,
                    host=client.DEFAULT_ENDPOINT,
                    scopes=None,
                    client_cert_source_for_mtls=None,
                    quota_project_id=None,
                    client_info=transports.base.DEFAULT_CLIENT_INFO,
                    always_use_jwt_access=True,
                )


@pytest.mark.parametrize("client_class,transport_class,transport_name", [
    (RecaptchaEnterpriseServiceV1Beta1Client, transports.RecaptchaEnterpriseServiceV1Beta1GrpcTransport, "grpc"),
    (RecaptchaEnterpriseServiceV1Beta1AsyncClient, transports.RecaptchaEnterpriseServiceV1Beta1GrpcAsyncIOTransport, "grpc_asyncio"),
])
def test_recaptcha_enterprise_service_v1_beta1_client_client_options_scopes(client_class, transport_class, transport_name):
    # Check the case scopes are provided.
    options = client_options.ClientOptions(
        scopes=["1", "2"],
    )
    with mock.patch.object(transport_class, '__init__') as patched:
        patched.return_value = None
        client = client_class(transport=transport_name, client_options=options)
        patched.assert_called_once_with(
            credentials=None,
            credentials_file=None,
            host=client.DEFAULT_ENDPOINT,
            scopes=["1", "2"],
            client_cert_source_for_mtls=None,
            quota_project_id=None,
            client_info=transports.base.DEFAULT_CLIENT_INFO,
            always_use_jwt_access=True,
        )

@pytest.mark.parametrize("client_class,transport_class,transport_name", [
    (RecaptchaEnterpriseServiceV1Beta1Client, transports.RecaptchaEnterpriseServiceV1Beta1GrpcTransport, "grpc"),
    (RecaptchaEnterpriseServiceV1Beta1AsyncClient, transports.RecaptchaEnterpriseServiceV1Beta1GrpcAsyncIOTransport, "grpc_asyncio"),
])
def test_recaptcha_enterprise_service_v1_beta1_client_client_options_credentials_file(client_class, transport_class, transport_name):
    # Check the case credentials file is provided.
    options = client_options.ClientOptions(
        credentials_file="credentials.json"
    )
    with mock.patch.object(transport_class, '__init__') as patched:
        patched.return_value = None
        client = client_class(transport=transport_name, client_options=options)
        patched.assert_called_once_with(
            credentials=None,
            credentials_file="credentials.json",
            host=client.DEFAULT_ENDPOINT,
            scopes=None,
            client_cert_source_for_mtls=None,
            quota_project_id=None,
            client_info=transports.base.DEFAULT_CLIENT_INFO,
            always_use_jwt_access=True,
        )


def test_recaptcha_enterprise_service_v1_beta1_client_client_options_from_dict():
    with mock.patch('google.cloud.recaptchaenterprise_v1beta1.services.recaptcha_enterprise_service_v1_beta1.transports.RecaptchaEnterpriseServiceV1Beta1GrpcTransport.__init__') as grpc_transport:
        grpc_transport.return_value = None
        client = RecaptchaEnterpriseServiceV1Beta1Client(
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
            always_use_jwt_access=True,
        )


def test_create_assessment(transport: str = 'grpc', request_type=recaptchaenterprise.CreateAssessmentRequest):
    client = RecaptchaEnterpriseServiceV1Beta1Client(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_assessment),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = recaptchaenterprise.Assessment(
            name='name_value',
            score=0.54,
            reasons=[recaptchaenterprise.Assessment.ClassificationReason.AUTOMATION],
        )
        response = client.create_assessment(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == recaptchaenterprise.CreateAssessmentRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, recaptchaenterprise.Assessment)
    assert response.name == 'name_value'
    assert math.isclose(response.score, 0.54, rel_tol=1e-6)
    assert response.reasons == [recaptchaenterprise.Assessment.ClassificationReason.AUTOMATION]


def test_create_assessment_from_dict():
    test_create_assessment(request_type=dict)


def test_create_assessment_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = RecaptchaEnterpriseServiceV1Beta1Client(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_assessment),
            '__call__') as call:
        client.create_assessment()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == recaptchaenterprise.CreateAssessmentRequest()


@pytest.mark.asyncio
async def test_create_assessment_async(transport: str = 'grpc_asyncio', request_type=recaptchaenterprise.CreateAssessmentRequest):
    client = RecaptchaEnterpriseServiceV1Beta1AsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_assessment),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(recaptchaenterprise.Assessment(
            name='name_value',
            score=0.54,
            reasons=[recaptchaenterprise.Assessment.ClassificationReason.AUTOMATION],
        ))
        response = await client.create_assessment(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == recaptchaenterprise.CreateAssessmentRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, recaptchaenterprise.Assessment)
    assert response.name == 'name_value'
    assert math.isclose(response.score, 0.54, rel_tol=1e-6)
    assert response.reasons == [recaptchaenterprise.Assessment.ClassificationReason.AUTOMATION]


@pytest.mark.asyncio
async def test_create_assessment_async_from_dict():
    await test_create_assessment_async(request_type=dict)


def test_create_assessment_field_headers():
    client = RecaptchaEnterpriseServiceV1Beta1Client(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = recaptchaenterprise.CreateAssessmentRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_assessment),
            '__call__') as call:
        call.return_value = recaptchaenterprise.Assessment()
        client.create_assessment(request)

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
async def test_create_assessment_field_headers_async():
    client = RecaptchaEnterpriseServiceV1Beta1AsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = recaptchaenterprise.CreateAssessmentRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_assessment),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(recaptchaenterprise.Assessment())
        await client.create_assessment(request)

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


def test_create_assessment_flattened():
    client = RecaptchaEnterpriseServiceV1Beta1Client(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_assessment),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = recaptchaenterprise.Assessment()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.create_assessment(
            parent='parent_value',
            assessment=recaptchaenterprise.Assessment(name='name_value'),
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].parent
        mock_val = 'parent_value'
        assert arg == mock_val
        arg = args[0].assessment
        mock_val = recaptchaenterprise.Assessment(name='name_value')
        assert arg == mock_val


def test_create_assessment_flattened_error():
    client = RecaptchaEnterpriseServiceV1Beta1Client(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.create_assessment(
            recaptchaenterprise.CreateAssessmentRequest(),
            parent='parent_value',
            assessment=recaptchaenterprise.Assessment(name='name_value'),
        )


@pytest.mark.asyncio
async def test_create_assessment_flattened_async():
    client = RecaptchaEnterpriseServiceV1Beta1AsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_assessment),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = recaptchaenterprise.Assessment()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(recaptchaenterprise.Assessment())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.create_assessment(
            parent='parent_value',
            assessment=recaptchaenterprise.Assessment(name='name_value'),
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        arg = args[0].parent
        mock_val = 'parent_value'
        assert arg == mock_val
        arg = args[0].assessment
        mock_val = recaptchaenterprise.Assessment(name='name_value')
        assert arg == mock_val


@pytest.mark.asyncio
async def test_create_assessment_flattened_error_async():
    client = RecaptchaEnterpriseServiceV1Beta1AsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.create_assessment(
            recaptchaenterprise.CreateAssessmentRequest(),
            parent='parent_value',
            assessment=recaptchaenterprise.Assessment(name='name_value'),
        )


def test_annotate_assessment(transport: str = 'grpc', request_type=recaptchaenterprise.AnnotateAssessmentRequest):
    client = RecaptchaEnterpriseServiceV1Beta1Client(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.annotate_assessment),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = recaptchaenterprise.AnnotateAssessmentResponse(
        )
        response = client.annotate_assessment(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == recaptchaenterprise.AnnotateAssessmentRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, recaptchaenterprise.AnnotateAssessmentResponse)


def test_annotate_assessment_from_dict():
    test_annotate_assessment(request_type=dict)


def test_annotate_assessment_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = RecaptchaEnterpriseServiceV1Beta1Client(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.annotate_assessment),
            '__call__') as call:
        client.annotate_assessment()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == recaptchaenterprise.AnnotateAssessmentRequest()


@pytest.mark.asyncio
async def test_annotate_assessment_async(transport: str = 'grpc_asyncio', request_type=recaptchaenterprise.AnnotateAssessmentRequest):
    client = RecaptchaEnterpriseServiceV1Beta1AsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.annotate_assessment),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(recaptchaenterprise.AnnotateAssessmentResponse(
        ))
        response = await client.annotate_assessment(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == recaptchaenterprise.AnnotateAssessmentRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, recaptchaenterprise.AnnotateAssessmentResponse)


@pytest.mark.asyncio
async def test_annotate_assessment_async_from_dict():
    await test_annotate_assessment_async(request_type=dict)


def test_annotate_assessment_field_headers():
    client = RecaptchaEnterpriseServiceV1Beta1Client(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = recaptchaenterprise.AnnotateAssessmentRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.annotate_assessment),
            '__call__') as call:
        call.return_value = recaptchaenterprise.AnnotateAssessmentResponse()
        client.annotate_assessment(request)

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
async def test_annotate_assessment_field_headers_async():
    client = RecaptchaEnterpriseServiceV1Beta1AsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = recaptchaenterprise.AnnotateAssessmentRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.annotate_assessment),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(recaptchaenterprise.AnnotateAssessmentResponse())
        await client.annotate_assessment(request)

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


def test_annotate_assessment_flattened():
    client = RecaptchaEnterpriseServiceV1Beta1Client(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.annotate_assessment),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = recaptchaenterprise.AnnotateAssessmentResponse()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.annotate_assessment(
            name='name_value',
            annotation=recaptchaenterprise.AnnotateAssessmentRequest.Annotation.LEGITIMATE,
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].name
        mock_val = 'name_value'
        assert arg == mock_val
        arg = args[0].annotation
        mock_val = recaptchaenterprise.AnnotateAssessmentRequest.Annotation.LEGITIMATE
        assert arg == mock_val


def test_annotate_assessment_flattened_error():
    client = RecaptchaEnterpriseServiceV1Beta1Client(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.annotate_assessment(
            recaptchaenterprise.AnnotateAssessmentRequest(),
            name='name_value',
            annotation=recaptchaenterprise.AnnotateAssessmentRequest.Annotation.LEGITIMATE,
        )


@pytest.mark.asyncio
async def test_annotate_assessment_flattened_async():
    client = RecaptchaEnterpriseServiceV1Beta1AsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.annotate_assessment),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = recaptchaenterprise.AnnotateAssessmentResponse()

        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(recaptchaenterprise.AnnotateAssessmentResponse())
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        response = await client.annotate_assessment(
            name='name_value',
            annotation=recaptchaenterprise.AnnotateAssessmentRequest.Annotation.LEGITIMATE,
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        arg = args[0].name
        mock_val = 'name_value'
        assert arg == mock_val
        arg = args[0].annotation
        mock_val = recaptchaenterprise.AnnotateAssessmentRequest.Annotation.LEGITIMATE
        assert arg == mock_val


@pytest.mark.asyncio
async def test_annotate_assessment_flattened_error_async():
    client = RecaptchaEnterpriseServiceV1Beta1AsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        await client.annotate_assessment(
            recaptchaenterprise.AnnotateAssessmentRequest(),
            name='name_value',
            annotation=recaptchaenterprise.AnnotateAssessmentRequest.Annotation.LEGITIMATE,
        )


def test_create_key(transport: str = 'grpc', request_type=recaptchaenterprise.CreateKeyRequest):
    client = RecaptchaEnterpriseServiceV1Beta1Client(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_key),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = recaptchaenterprise.Key(
            name='name_value',
            display_name='display_name_value',
            web_settings=recaptchaenterprise.WebKeySettings(enforce_allowed_domains=True),
        )
        response = client.create_key(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == recaptchaenterprise.CreateKeyRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, recaptchaenterprise.Key)
    assert response.name == 'name_value'
    assert response.display_name == 'display_name_value'


def test_create_key_from_dict():
    test_create_key(request_type=dict)


def test_create_key_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = RecaptchaEnterpriseServiceV1Beta1Client(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_key),
            '__call__') as call:
        client.create_key()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == recaptchaenterprise.CreateKeyRequest()


@pytest.mark.asyncio
async def test_create_key_async(transport: str = 'grpc_asyncio', request_type=recaptchaenterprise.CreateKeyRequest):
    client = RecaptchaEnterpriseServiceV1Beta1AsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_key),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(recaptchaenterprise.Key(
            name='name_value',
            display_name='display_name_value',
        ))
        response = await client.create_key(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == recaptchaenterprise.CreateKeyRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, recaptchaenterprise.Key)
    assert response.name == 'name_value'
    assert response.display_name == 'display_name_value'


@pytest.mark.asyncio
async def test_create_key_async_from_dict():
    await test_create_key_async(request_type=dict)


def test_create_key_field_headers():
    client = RecaptchaEnterpriseServiceV1Beta1Client(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = recaptchaenterprise.CreateKeyRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_key),
            '__call__') as call:
        call.return_value = recaptchaenterprise.Key()
        client.create_key(request)

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
async def test_create_key_field_headers_async():
    client = RecaptchaEnterpriseServiceV1Beta1AsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = recaptchaenterprise.CreateKeyRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_key),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(recaptchaenterprise.Key())
        await client.create_key(request)

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


def test_list_keys(transport: str = 'grpc', request_type=recaptchaenterprise.ListKeysRequest):
    client = RecaptchaEnterpriseServiceV1Beta1Client(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_keys),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = recaptchaenterprise.ListKeysResponse(
            next_page_token='next_page_token_value',
        )
        response = client.list_keys(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == recaptchaenterprise.ListKeysRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListKeysPager)
    assert response.next_page_token == 'next_page_token_value'


def test_list_keys_from_dict():
    test_list_keys(request_type=dict)


def test_list_keys_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = RecaptchaEnterpriseServiceV1Beta1Client(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_keys),
            '__call__') as call:
        client.list_keys()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == recaptchaenterprise.ListKeysRequest()


@pytest.mark.asyncio
async def test_list_keys_async(transport: str = 'grpc_asyncio', request_type=recaptchaenterprise.ListKeysRequest):
    client = RecaptchaEnterpriseServiceV1Beta1AsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_keys),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(recaptchaenterprise.ListKeysResponse(
            next_page_token='next_page_token_value',
        ))
        response = await client.list_keys(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == recaptchaenterprise.ListKeysRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListKeysAsyncPager)
    assert response.next_page_token == 'next_page_token_value'


@pytest.mark.asyncio
async def test_list_keys_async_from_dict():
    await test_list_keys_async(request_type=dict)


def test_list_keys_field_headers():
    client = RecaptchaEnterpriseServiceV1Beta1Client(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = recaptchaenterprise.ListKeysRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_keys),
            '__call__') as call:
        call.return_value = recaptchaenterprise.ListKeysResponse()
        client.list_keys(request)

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
async def test_list_keys_field_headers_async():
    client = RecaptchaEnterpriseServiceV1Beta1AsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = recaptchaenterprise.ListKeysRequest()

    request.parent = 'parent/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_keys),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(recaptchaenterprise.ListKeysResponse())
        await client.list_keys(request)

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


def test_list_keys_pager():
    client = RecaptchaEnterpriseServiceV1Beta1Client(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_keys),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            recaptchaenterprise.ListKeysResponse(
                keys=[
                    recaptchaenterprise.Key(),
                    recaptchaenterprise.Key(),
                    recaptchaenterprise.Key(),
                ],
                next_page_token='abc',
            ),
            recaptchaenterprise.ListKeysResponse(
                keys=[],
                next_page_token='def',
            ),
            recaptchaenterprise.ListKeysResponse(
                keys=[
                    recaptchaenterprise.Key(),
                ],
                next_page_token='ghi',
            ),
            recaptchaenterprise.ListKeysResponse(
                keys=[
                    recaptchaenterprise.Key(),
                    recaptchaenterprise.Key(),
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
        pager = client.list_keys(request={})

        assert pager._metadata == metadata

        results = [i for i in pager]
        assert len(results) == 6
        assert all(isinstance(i, recaptchaenterprise.Key)
                   for i in results)

def test_list_keys_pages():
    client = RecaptchaEnterpriseServiceV1Beta1Client(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_keys),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            recaptchaenterprise.ListKeysResponse(
                keys=[
                    recaptchaenterprise.Key(),
                    recaptchaenterprise.Key(),
                    recaptchaenterprise.Key(),
                ],
                next_page_token='abc',
            ),
            recaptchaenterprise.ListKeysResponse(
                keys=[],
                next_page_token='def',
            ),
            recaptchaenterprise.ListKeysResponse(
                keys=[
                    recaptchaenterprise.Key(),
                ],
                next_page_token='ghi',
            ),
            recaptchaenterprise.ListKeysResponse(
                keys=[
                    recaptchaenterprise.Key(),
                    recaptchaenterprise.Key(),
                ],
            ),
            RuntimeError,
        )
        pages = list(client.list_keys(request={}).pages)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

@pytest.mark.asyncio
async def test_list_keys_async_pager():
    client = RecaptchaEnterpriseServiceV1Beta1AsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_keys),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            recaptchaenterprise.ListKeysResponse(
                keys=[
                    recaptchaenterprise.Key(),
                    recaptchaenterprise.Key(),
                    recaptchaenterprise.Key(),
                ],
                next_page_token='abc',
            ),
            recaptchaenterprise.ListKeysResponse(
                keys=[],
                next_page_token='def',
            ),
            recaptchaenterprise.ListKeysResponse(
                keys=[
                    recaptchaenterprise.Key(),
                ],
                next_page_token='ghi',
            ),
            recaptchaenterprise.ListKeysResponse(
                keys=[
                    recaptchaenterprise.Key(),
                    recaptchaenterprise.Key(),
                ],
            ),
            RuntimeError,
        )
        async_pager = await client.list_keys(request={},)
        assert async_pager.next_page_token == 'abc'
        responses = []
        async for response in async_pager:
            responses.append(response)

        assert len(responses) == 6
        assert all(isinstance(i, recaptchaenterprise.Key)
                   for i in responses)

@pytest.mark.asyncio
async def test_list_keys_async_pages():
    client = RecaptchaEnterpriseServiceV1Beta1AsyncClient(
        credentials=ga_credentials.AnonymousCredentials,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_keys),
            '__call__', new_callable=mock.AsyncMock) as call:
        # Set the response to a series of pages.
        call.side_effect = (
            recaptchaenterprise.ListKeysResponse(
                keys=[
                    recaptchaenterprise.Key(),
                    recaptchaenterprise.Key(),
                    recaptchaenterprise.Key(),
                ],
                next_page_token='abc',
            ),
            recaptchaenterprise.ListKeysResponse(
                keys=[],
                next_page_token='def',
            ),
            recaptchaenterprise.ListKeysResponse(
                keys=[
                    recaptchaenterprise.Key(),
                ],
                next_page_token='ghi',
            ),
            recaptchaenterprise.ListKeysResponse(
                keys=[
                    recaptchaenterprise.Key(),
                    recaptchaenterprise.Key(),
                ],
            ),
            RuntimeError,
        )
        pages = []
        async for page_ in (await client.list_keys(request={})).pages:
            pages.append(page_)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token

def test_get_key(transport: str = 'grpc', request_type=recaptchaenterprise.GetKeyRequest):
    client = RecaptchaEnterpriseServiceV1Beta1Client(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_key),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = recaptchaenterprise.Key(
            name='name_value',
            display_name='display_name_value',
            web_settings=recaptchaenterprise.WebKeySettings(enforce_allowed_domains=True),
        )
        response = client.get_key(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == recaptchaenterprise.GetKeyRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, recaptchaenterprise.Key)
    assert response.name == 'name_value'
    assert response.display_name == 'display_name_value'


def test_get_key_from_dict():
    test_get_key(request_type=dict)


def test_get_key_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = RecaptchaEnterpriseServiceV1Beta1Client(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_key),
            '__call__') as call:
        client.get_key()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == recaptchaenterprise.GetKeyRequest()


@pytest.mark.asyncio
async def test_get_key_async(transport: str = 'grpc_asyncio', request_type=recaptchaenterprise.GetKeyRequest):
    client = RecaptchaEnterpriseServiceV1Beta1AsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_key),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(recaptchaenterprise.Key(
            name='name_value',
            display_name='display_name_value',
        ))
        response = await client.get_key(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == recaptchaenterprise.GetKeyRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, recaptchaenterprise.Key)
    assert response.name == 'name_value'
    assert response.display_name == 'display_name_value'


@pytest.mark.asyncio
async def test_get_key_async_from_dict():
    await test_get_key_async(request_type=dict)


def test_get_key_field_headers():
    client = RecaptchaEnterpriseServiceV1Beta1Client(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = recaptchaenterprise.GetKeyRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_key),
            '__call__') as call:
        call.return_value = recaptchaenterprise.Key()
        client.get_key(request)

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
async def test_get_key_field_headers_async():
    client = RecaptchaEnterpriseServiceV1Beta1AsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = recaptchaenterprise.GetKeyRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_key),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(recaptchaenterprise.Key())
        await client.get_key(request)

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


def test_update_key(transport: str = 'grpc', request_type=recaptchaenterprise.UpdateKeyRequest):
    client = RecaptchaEnterpriseServiceV1Beta1Client(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_key),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = recaptchaenterprise.Key(
            name='name_value',
            display_name='display_name_value',
            web_settings=recaptchaenterprise.WebKeySettings(enforce_allowed_domains=True),
        )
        response = client.update_key(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == recaptchaenterprise.UpdateKeyRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, recaptchaenterprise.Key)
    assert response.name == 'name_value'
    assert response.display_name == 'display_name_value'


def test_update_key_from_dict():
    test_update_key(request_type=dict)


def test_update_key_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = RecaptchaEnterpriseServiceV1Beta1Client(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_key),
            '__call__') as call:
        client.update_key()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == recaptchaenterprise.UpdateKeyRequest()


@pytest.mark.asyncio
async def test_update_key_async(transport: str = 'grpc_asyncio', request_type=recaptchaenterprise.UpdateKeyRequest):
    client = RecaptchaEnterpriseServiceV1Beta1AsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_key),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value =grpc_helpers_async.FakeUnaryUnaryCall(recaptchaenterprise.Key(
            name='name_value',
            display_name='display_name_value',
        ))
        response = await client.update_key(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == recaptchaenterprise.UpdateKeyRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, recaptchaenterprise.Key)
    assert response.name == 'name_value'
    assert response.display_name == 'display_name_value'


@pytest.mark.asyncio
async def test_update_key_async_from_dict():
    await test_update_key_async(request_type=dict)


def test_update_key_field_headers():
    client = RecaptchaEnterpriseServiceV1Beta1Client(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = recaptchaenterprise.UpdateKeyRequest()

    request.key.name = 'key.name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_key),
            '__call__') as call:
        call.return_value = recaptchaenterprise.Key()
        client.update_key(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'key.name=key.name/value',
    ) in kw['metadata']


@pytest.mark.asyncio
async def test_update_key_field_headers_async():
    client = RecaptchaEnterpriseServiceV1Beta1AsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = recaptchaenterprise.UpdateKeyRequest()

    request.key.name = 'key.name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.update_key),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(recaptchaenterprise.Key())
        await client.update_key(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'key.name=key.name/value',
    ) in kw['metadata']


def test_delete_key(transport: str = 'grpc', request_type=recaptchaenterprise.DeleteKeyRequest):
    client = RecaptchaEnterpriseServiceV1Beta1Client(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_key),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = None
        response = client.delete_key(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == recaptchaenterprise.DeleteKeyRequest()

    # Establish that the response is the type that we expect.
    assert response is None


def test_delete_key_from_dict():
    test_delete_key(request_type=dict)


def test_delete_key_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = RecaptchaEnterpriseServiceV1Beta1Client(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_key),
            '__call__') as call:
        client.delete_key()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == recaptchaenterprise.DeleteKeyRequest()


@pytest.mark.asyncio
async def test_delete_key_async(transport: str = 'grpc_asyncio', request_type=recaptchaenterprise.DeleteKeyRequest):
    client = RecaptchaEnterpriseServiceV1Beta1AsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_key),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(None)
        response = await client.delete_key(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls)
        _, args, _ = call.mock_calls[0]
        assert args[0] == recaptchaenterprise.DeleteKeyRequest()

    # Establish that the response is the type that we expect.
    assert response is None


@pytest.mark.asyncio
async def test_delete_key_async_from_dict():
    await test_delete_key_async(request_type=dict)


def test_delete_key_field_headers():
    client = RecaptchaEnterpriseServiceV1Beta1Client(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = recaptchaenterprise.DeleteKeyRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_key),
            '__call__') as call:
        call.return_value = None
        client.delete_key(request)

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
async def test_delete_key_field_headers_async():
    client = RecaptchaEnterpriseServiceV1Beta1AsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = recaptchaenterprise.DeleteKeyRequest()

    request.name = 'name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.delete_key),
            '__call__') as call:
        call.return_value = grpc_helpers_async.FakeUnaryUnaryCall(None)
        await client.delete_key(request)

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


def test_credentials_transport_error():
    # It is an error to provide credentials and a transport instance.
    transport = transports.RecaptchaEnterpriseServiceV1Beta1GrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = RecaptchaEnterpriseServiceV1Beta1Client(
            credentials=ga_credentials.AnonymousCredentials(),
            transport=transport,
        )

    # It is an error to provide a credentials file and a transport instance.
    transport = transports.RecaptchaEnterpriseServiceV1Beta1GrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = RecaptchaEnterpriseServiceV1Beta1Client(
            client_options={"credentials_file": "credentials.json"},
            transport=transport,
        )

    # It is an error to provide scopes and a transport instance.
    transport = transports.RecaptchaEnterpriseServiceV1Beta1GrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = RecaptchaEnterpriseServiceV1Beta1Client(
            client_options={"scopes": ["1", "2"]},
            transport=transport,
        )


def test_transport_instance():
    # A client may be instantiated with a custom transport instance.
    transport = transports.RecaptchaEnterpriseServiceV1Beta1GrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    client = RecaptchaEnterpriseServiceV1Beta1Client(transport=transport)
    assert client.transport is transport

def test_transport_get_channel():
    # A client may be instantiated with a custom transport instance.
    transport = transports.RecaptchaEnterpriseServiceV1Beta1GrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    channel = transport.grpc_channel
    assert channel

    transport = transports.RecaptchaEnterpriseServiceV1Beta1GrpcAsyncIOTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    channel = transport.grpc_channel
    assert channel

@pytest.mark.parametrize("transport_class", [
    transports.RecaptchaEnterpriseServiceV1Beta1GrpcTransport,
    transports.RecaptchaEnterpriseServiceV1Beta1GrpcAsyncIOTransport,
])
def test_transport_adc(transport_class):
    # Test default credentials are used if not provided.
    with mock.patch.object(google.auth, 'default') as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport_class()
        adc.assert_called_once()

def test_transport_grpc_default():
    # A client should use the gRPC transport by default.
    client = RecaptchaEnterpriseServiceV1Beta1Client(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    assert isinstance(
        client.transport,
        transports.RecaptchaEnterpriseServiceV1Beta1GrpcTransport,
    )

def test_recaptcha_enterprise_service_v1_beta1_base_transport_error():
    # Passing both a credentials object and credentials_file should raise an error
    with pytest.raises(core_exceptions.DuplicateCredentialArgs):
        transport = transports.RecaptchaEnterpriseServiceV1Beta1Transport(
            credentials=ga_credentials.AnonymousCredentials(),
            credentials_file="credentials.json"
        )


def test_recaptcha_enterprise_service_v1_beta1_base_transport():
    # Instantiate the base transport.
    with mock.patch('google.cloud.recaptchaenterprise_v1beta1.services.recaptcha_enterprise_service_v1_beta1.transports.RecaptchaEnterpriseServiceV1Beta1Transport.__init__') as Transport:
        Transport.return_value = None
        transport = transports.RecaptchaEnterpriseServiceV1Beta1Transport(
            credentials=ga_credentials.AnonymousCredentials(),
        )

    # Every method on the transport should just blindly
    # raise NotImplementedError.
    methods = (
        'create_assessment',
        'annotate_assessment',
        'create_key',
        'list_keys',
        'get_key',
        'update_key',
        'delete_key',
    )
    for method in methods:
        with pytest.raises(NotImplementedError):
            getattr(transport, method)(request=object())

    with pytest.raises(NotImplementedError):
        transport.close()


def test_recaptcha_enterprise_service_v1_beta1_base_transport_with_credentials_file():
    # Instantiate the base transport with a credentials file
    with mock.patch.object(google.auth, 'load_credentials_from_file', autospec=True) as load_creds, mock.patch('google.cloud.recaptchaenterprise_v1beta1.services.recaptcha_enterprise_service_v1_beta1.transports.RecaptchaEnterpriseServiceV1Beta1Transport._prep_wrapped_messages') as Transport:
        Transport.return_value = None
        load_creds.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport = transports.RecaptchaEnterpriseServiceV1Beta1Transport(
            credentials_file="credentials.json",
            quota_project_id="octopus",
        )
        load_creds.assert_called_once_with("credentials.json",
            scopes=None,
            default_scopes=(
            'https://www.googleapis.com/auth/cloud-platform',
),
            quota_project_id="octopus",
        )


def test_recaptcha_enterprise_service_v1_beta1_base_transport_with_adc():
    # Test the default credentials are used if credentials and credentials_file are None.
    with mock.patch.object(google.auth, 'default', autospec=True) as adc, mock.patch('google.cloud.recaptchaenterprise_v1beta1.services.recaptcha_enterprise_service_v1_beta1.transports.RecaptchaEnterpriseServiceV1Beta1Transport._prep_wrapped_messages') as Transport:
        Transport.return_value = None
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport = transports.RecaptchaEnterpriseServiceV1Beta1Transport()
        adc.assert_called_once()


def test_recaptcha_enterprise_service_v1_beta1_auth_adc():
    # If no credentials are provided, we should use ADC credentials.
    with mock.patch.object(google.auth, 'default', autospec=True) as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        RecaptchaEnterpriseServiceV1Beta1Client()
        adc.assert_called_once_with(
            scopes=None,
            default_scopes=(
            'https://www.googleapis.com/auth/cloud-platform',
),
            quota_project_id=None,
        )


@pytest.mark.parametrize(
    "transport_class",
    [
        transports.RecaptchaEnterpriseServiceV1Beta1GrpcTransport,
        transports.RecaptchaEnterpriseServiceV1Beta1GrpcAsyncIOTransport,
    ],
)
def test_recaptcha_enterprise_service_v1_beta1_transport_auth_adc(transport_class):
    # If credentials and host are not provided, the transport class should use
    # ADC credentials.
    with mock.patch.object(google.auth, 'default', autospec=True) as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport_class(quota_project_id="octopus", scopes=["1", "2"])
        adc.assert_called_once_with(
            scopes=["1", "2"],
            default_scopes=(                'https://www.googleapis.com/auth/cloud-platform',),
            quota_project_id="octopus",
        )


@pytest.mark.parametrize(
    "transport_class,grpc_helpers",
    [
        (transports.RecaptchaEnterpriseServiceV1Beta1GrpcTransport, grpc_helpers),
        (transports.RecaptchaEnterpriseServiceV1Beta1GrpcAsyncIOTransport, grpc_helpers_async)
    ],
)
def test_recaptcha_enterprise_service_v1_beta1_transport_create_channel(transport_class, grpc_helpers):
    # If credentials and host are not provided, the transport class should use
    # ADC credentials.
    with mock.patch.object(google.auth, "default", autospec=True) as adc, mock.patch.object(
        grpc_helpers, "create_channel", autospec=True
    ) as create_channel:
        creds = ga_credentials.AnonymousCredentials()
        adc.return_value = (creds, None)
        transport_class(
            quota_project_id="octopus",
            scopes=["1", "2"]
        )

        create_channel.assert_called_with(
            "recaptchaenterprise.googleapis.com:443",
            credentials=creds,
            credentials_file=None,
            quota_project_id="octopus",
            default_scopes=(
                'https://www.googleapis.com/auth/cloud-platform',
),
            scopes=["1", "2"],
            default_host="recaptchaenterprise.googleapis.com",
            ssl_credentials=None,
            options=[
                ("grpc.max_send_message_length", -1),
                ("grpc.max_receive_message_length", -1),
            ],
        )


@pytest.mark.parametrize("transport_class", [transports.RecaptchaEnterpriseServiceV1Beta1GrpcTransport, transports.RecaptchaEnterpriseServiceV1Beta1GrpcAsyncIOTransport])
def test_recaptcha_enterprise_service_v1_beta1_grpc_transport_client_cert_source_for_mtls(
    transport_class
):
    cred = ga_credentials.AnonymousCredentials()

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
            scopes=None,
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


def test_recaptcha_enterprise_service_v1_beta1_host_no_port():
    client = RecaptchaEnterpriseServiceV1Beta1Client(
        credentials=ga_credentials.AnonymousCredentials(),
        client_options=client_options.ClientOptions(api_endpoint='recaptchaenterprise.googleapis.com'),
    )
    assert client.transport._host == 'recaptchaenterprise.googleapis.com:443'


def test_recaptcha_enterprise_service_v1_beta1_host_with_port():
    client = RecaptchaEnterpriseServiceV1Beta1Client(
        credentials=ga_credentials.AnonymousCredentials(),
        client_options=client_options.ClientOptions(api_endpoint='recaptchaenterprise.googleapis.com:8000'),
    )
    assert client.transport._host == 'recaptchaenterprise.googleapis.com:8000'

def test_recaptcha_enterprise_service_v1_beta1_grpc_transport_channel():
    channel = grpc.secure_channel('http://localhost/', grpc.local_channel_credentials())

    # Check that channel is used if provided.
    transport = transports.RecaptchaEnterpriseServiceV1Beta1GrpcTransport(
        host="squid.clam.whelk",
        channel=channel,
    )
    assert transport.grpc_channel == channel
    assert transport._host == "squid.clam.whelk:443"
    assert transport._ssl_channel_credentials == None


def test_recaptcha_enterprise_service_v1_beta1_grpc_asyncio_transport_channel():
    channel = aio.secure_channel('http://localhost/', grpc.local_channel_credentials())

    # Check that channel is used if provided.
    transport = transports.RecaptchaEnterpriseServiceV1Beta1GrpcAsyncIOTransport(
        host="squid.clam.whelk",
        channel=channel,
    )
    assert transport.grpc_channel == channel
    assert transport._host == "squid.clam.whelk:443"
    assert transport._ssl_channel_credentials == None


# Remove this test when deprecated arguments (api_mtls_endpoint, client_cert_source) are
# removed from grpc/grpc_asyncio transport constructor.
@pytest.mark.parametrize("transport_class", [transports.RecaptchaEnterpriseServiceV1Beta1GrpcTransport, transports.RecaptchaEnterpriseServiceV1Beta1GrpcAsyncIOTransport])
def test_recaptcha_enterprise_service_v1_beta1_transport_channel_mtls_with_client_cert_source(
    transport_class
):
    with mock.patch("grpc.ssl_channel_credentials", autospec=True) as grpc_ssl_channel_cred:
        with mock.patch.object(transport_class, "create_channel") as grpc_create_channel:
            mock_ssl_cred = mock.Mock()
            grpc_ssl_channel_cred.return_value = mock_ssl_cred

            mock_grpc_channel = mock.Mock()
            grpc_create_channel.return_value = mock_grpc_channel

            cred = ga_credentials.AnonymousCredentials()
            with pytest.warns(DeprecationWarning):
                with mock.patch.object(google.auth, 'default') as adc:
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
                scopes=None,
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
@pytest.mark.parametrize("transport_class", [transports.RecaptchaEnterpriseServiceV1Beta1GrpcTransport, transports.RecaptchaEnterpriseServiceV1Beta1GrpcAsyncIOTransport])
def test_recaptcha_enterprise_service_v1_beta1_transport_channel_mtls_with_adc(
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
                scopes=None,
                ssl_credentials=mock_ssl_cred,
                quota_project_id=None,
                options=[
                    ("grpc.max_send_message_length", -1),
                    ("grpc.max_receive_message_length", -1),
                ],
            )
            assert transport.grpc_channel == mock_grpc_channel


def test_assessment_path():
    project = "squid"
    assessment = "clam"
    expected = "projects/{project}/assessments/{assessment}".format(project=project, assessment=assessment, )
    actual = RecaptchaEnterpriseServiceV1Beta1Client.assessment_path(project, assessment)
    assert expected == actual


def test_parse_assessment_path():
    expected = {
        "project": "whelk",
        "assessment": "octopus",
    }
    path = RecaptchaEnterpriseServiceV1Beta1Client.assessment_path(**expected)

    # Check that the path construction is reversible.
    actual = RecaptchaEnterpriseServiceV1Beta1Client.parse_assessment_path(path)
    assert expected == actual

def test_key_path():
    project = "oyster"
    key = "nudibranch"
    expected = "projects/{project}/keys/{key}".format(project=project, key=key, )
    actual = RecaptchaEnterpriseServiceV1Beta1Client.key_path(project, key)
    assert expected == actual


def test_parse_key_path():
    expected = {
        "project": "cuttlefish",
        "key": "mussel",
    }
    path = RecaptchaEnterpriseServiceV1Beta1Client.key_path(**expected)

    # Check that the path construction is reversible.
    actual = RecaptchaEnterpriseServiceV1Beta1Client.parse_key_path(path)
    assert expected == actual

def test_common_billing_account_path():
    billing_account = "winkle"
    expected = "billingAccounts/{billing_account}".format(billing_account=billing_account, )
    actual = RecaptchaEnterpriseServiceV1Beta1Client.common_billing_account_path(billing_account)
    assert expected == actual


def test_parse_common_billing_account_path():
    expected = {
        "billing_account": "nautilus",
    }
    path = RecaptchaEnterpriseServiceV1Beta1Client.common_billing_account_path(**expected)

    # Check that the path construction is reversible.
    actual = RecaptchaEnterpriseServiceV1Beta1Client.parse_common_billing_account_path(path)
    assert expected == actual

def test_common_folder_path():
    folder = "scallop"
    expected = "folders/{folder}".format(folder=folder, )
    actual = RecaptchaEnterpriseServiceV1Beta1Client.common_folder_path(folder)
    assert expected == actual


def test_parse_common_folder_path():
    expected = {
        "folder": "abalone",
    }
    path = RecaptchaEnterpriseServiceV1Beta1Client.common_folder_path(**expected)

    # Check that the path construction is reversible.
    actual = RecaptchaEnterpriseServiceV1Beta1Client.parse_common_folder_path(path)
    assert expected == actual

def test_common_organization_path():
    organization = "squid"
    expected = "organizations/{organization}".format(organization=organization, )
    actual = RecaptchaEnterpriseServiceV1Beta1Client.common_organization_path(organization)
    assert expected == actual


def test_parse_common_organization_path():
    expected = {
        "organization": "clam",
    }
    path = RecaptchaEnterpriseServiceV1Beta1Client.common_organization_path(**expected)

    # Check that the path construction is reversible.
    actual = RecaptchaEnterpriseServiceV1Beta1Client.parse_common_organization_path(path)
    assert expected == actual

def test_common_project_path():
    project = "whelk"
    expected = "projects/{project}".format(project=project, )
    actual = RecaptchaEnterpriseServiceV1Beta1Client.common_project_path(project)
    assert expected == actual


def test_parse_common_project_path():
    expected = {
        "project": "octopus",
    }
    path = RecaptchaEnterpriseServiceV1Beta1Client.common_project_path(**expected)

    # Check that the path construction is reversible.
    actual = RecaptchaEnterpriseServiceV1Beta1Client.parse_common_project_path(path)
    assert expected == actual

def test_common_location_path():
    project = "oyster"
    location = "nudibranch"
    expected = "projects/{project}/locations/{location}".format(project=project, location=location, )
    actual = RecaptchaEnterpriseServiceV1Beta1Client.common_location_path(project, location)
    assert expected == actual


def test_parse_common_location_path():
    expected = {
        "project": "cuttlefish",
        "location": "mussel",
    }
    path = RecaptchaEnterpriseServiceV1Beta1Client.common_location_path(**expected)

    # Check that the path construction is reversible.
    actual = RecaptchaEnterpriseServiceV1Beta1Client.parse_common_location_path(path)
    assert expected == actual


def test_client_withDEFAULT_CLIENT_INFO():
    client_info = gapic_v1.client_info.ClientInfo()

    with mock.patch.object(transports.RecaptchaEnterpriseServiceV1Beta1Transport, '_prep_wrapped_messages') as prep:
        client = RecaptchaEnterpriseServiceV1Beta1Client(
            credentials=ga_credentials.AnonymousCredentials(),
            client_info=client_info,
        )
        prep.assert_called_once_with(client_info)

    with mock.patch.object(transports.RecaptchaEnterpriseServiceV1Beta1Transport, '_prep_wrapped_messages') as prep:
        transport_class = RecaptchaEnterpriseServiceV1Beta1Client.get_transport_class()
        transport = transport_class(
            credentials=ga_credentials.AnonymousCredentials(),
            client_info=client_info,
        )
        prep.assert_called_once_with(client_info)


@pytest.mark.asyncio
async def test_transport_close_async():
    client = RecaptchaEnterpriseServiceV1Beta1AsyncClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport="grpc_asyncio",
    )
    with mock.patch.object(type(getattr(client.transport, "grpc_channel")), "close") as close:
        async with client:
            close.assert_not_called()
        close.assert_called_once()

def test_transport_close():
    transports = {
        "grpc": "_grpc_channel",
    }

    for transport, close_name in transports.items():
        client = RecaptchaEnterpriseServiceV1Beta1Client(
            credentials=ga_credentials.AnonymousCredentials(),
            transport=transport
        )
        with mock.patch.object(type(getattr(client.transport, close_name)), "close") as close:
            with client:
                close.assert_not_called()
            close.assert_called_once()

def test_client_ctx():
    transports = [
        'grpc',
    ]
    for transport in transports:
        client = RecaptchaEnterpriseServiceV1Beta1Client(
            credentials=ga_credentials.AnonymousCredentials(),
            transport=transport
        )
        # Test client calls underlying transport.
        with mock.patch.object(type(client.transport), "close") as close:
            close.assert_not_called()
            with client:
                pass
            close.assert_called()
