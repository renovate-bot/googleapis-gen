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
from unittest import mock

import grpc
import math
import pytest
from proto.marshal.rules.dates import DurationRule, TimestampRule

from google.ads.googleads.v8.enums.types import conversion_value_rule_status
from google.ads.googleads.v8.enums.types import response_content_type
from google.ads.googleads.v8.enums.types import value_rule_device_type
from google.ads.googleads.v8.enums.types import value_rule_geo_location_match_type
from google.ads.googleads.v8.enums.types import value_rule_operation
from google.ads.googleads.v8.resources.types import conversion_value_rule
from google.ads.googleads.v8.services.services.conversion_value_rule_service import ConversionValueRuleServiceClient
from google.ads.googleads.v8.services.services.conversion_value_rule_service import transports
from google.ads.googleads.v8.services.types import conversion_value_rule_service
from google.api_core import client_options
from google.api_core import gapic_v1
from google.api_core import grpc_helpers
from google.auth import credentials as ga_credentials
from google.auth.exceptions import MutualTLSChannelError
from google.oauth2 import service_account
from google.protobuf import field_mask_pb2  # type: ignore
from google.rpc import status_pb2  # type: ignore
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

    assert ConversionValueRuleServiceClient._get_default_mtls_endpoint(None) is None
    assert ConversionValueRuleServiceClient._get_default_mtls_endpoint(api_endpoint) == api_mtls_endpoint
    assert ConversionValueRuleServiceClient._get_default_mtls_endpoint(api_mtls_endpoint) == api_mtls_endpoint
    assert ConversionValueRuleServiceClient._get_default_mtls_endpoint(sandbox_endpoint) == sandbox_mtls_endpoint
    assert ConversionValueRuleServiceClient._get_default_mtls_endpoint(sandbox_mtls_endpoint) == sandbox_mtls_endpoint
    assert ConversionValueRuleServiceClient._get_default_mtls_endpoint(non_googleapi) == non_googleapi


def test_conversion_value_rule_service_client_from_service_account_info():
    creds = ga_credentials.AnonymousCredentials()
    with mock.patch.object(service_account.Credentials, 'from_service_account_info') as factory:
        factory.return_value = creds
        info = {"valid": True}
        client = ConversionValueRuleServiceClient.from_service_account_info(info)
        assert client.transport._credentials == creds

        assert client.transport._host == 'googleads.googleapis.com:443'


def test_conversion_value_rule_service_client_from_service_account_file():
    creds = ga_credentials.AnonymousCredentials()
    with mock.patch.object(service_account.Credentials, 'from_service_account_file') as factory:
        factory.return_value = creds
        client = ConversionValueRuleServiceClient.from_service_account_file("dummy/file/path.json")
        assert client.transport._credentials == creds

        client = ConversionValueRuleServiceClient.from_service_account_json("dummy/file/path.json")
        assert client.transport._credentials == creds

        assert client.transport._host == 'googleads.googleapis.com:443'


def test_conversion_value_rule_service_client_get_transport_class():
    transport = ConversionValueRuleServiceClient.get_transport_class()
    assert transport == transports.ConversionValueRuleServiceGrpcTransport

    transport = ConversionValueRuleServiceClient.get_transport_class("grpc")
    assert transport == transports.ConversionValueRuleServiceGrpcTransport


@mock.patch.object(ConversionValueRuleServiceClient, "DEFAULT_ENDPOINT", modify_default_endpoint(ConversionValueRuleServiceClient))
def test_conversion_value_rule_service_client_client_options():
    # Check that if channel is provided we won't create a new one.
    with mock.patch('google.ads.googleads.v8.services.services.conversion_value_rule_service.ConversionValueRuleServiceClient.get_transport_class') as gtc:
        transport = transports.ConversionValueRuleServiceGrpcTransport(
            credentials=ga_credentials.AnonymousCredentials()
        )
        client = ConversionValueRuleServiceClient(transport=transport)
        gtc.assert_not_called()

    # Check that if channel is provided via str we will create a new one.
    with mock.patch('google.ads.googleads.v8.services.services.conversion_value_rule_service.ConversionValueRuleServiceClient.get_transport_class') as gtc:
        client = ConversionValueRuleServiceClient(transport="grpc")
        gtc.assert_called()

    # Check the case api_endpoint is provided.
    options = client_options.ClientOptions(api_endpoint="squid.clam.whelk")
    with mock.patch('google.ads.googleads.v8.services.services.conversion_value_rule_service.transports.ConversionValueRuleServiceGrpcTransport.__init__') as grpc_transport:
        grpc_transport.return_value = None
        client = ConversionValueRuleServiceClient(client_options=options)
        grpc_transport.assert_called_once_with(
            ssl_channel_credentials=None,
            credentials=None,
            host="squid.clam.whelk",
            client_info=transports.base.DEFAULT_CLIENT_INFO,
        )

    # Check the case api_endpoint is not provided and GOOGLE_API_USE_MTLS_ENDPOINT
    # is "never".
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_MTLS_ENDPOINT": "never"}):
        with mock.patch('google.ads.googleads.v8.services.services.conversion_value_rule_service.transports.ConversionValueRuleServiceGrpcTransport.__init__') as grpc_transport:
            grpc_transport.return_value = None
            client = ConversionValueRuleServiceClient()
            grpc_transport.assert_called_once_with(
                ssl_channel_credentials=None,
                credentials=None,
                host=client.DEFAULT_ENDPOINT,
                client_info=transports.base.DEFAULT_CLIENT_INFO,
            )

    # Check the case api_endpoint is not provided and GOOGLE_API_USE_MTLS_ENDPOINT is
    # "always".
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_MTLS_ENDPOINT": "always"}):
        with mock.patch('google.ads.googleads.v8.services.services.conversion_value_rule_service.transports.ConversionValueRuleServiceGrpcTransport.__init__') as grpc_transport:
            grpc_transport.return_value = None
            client = ConversionValueRuleServiceClient()
            grpc_transport.assert_called_once_with(
                ssl_channel_credentials=None,
                credentials=None,
                host=client.DEFAULT_MTLS_ENDPOINT,
                client_info=transports.base.DEFAULT_CLIENT_INFO,
            )

    # Check the case api_endpoint is not provided and GOOGLE_API_USE_MTLS_ENDPOINT has
    # unsupported value.
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_MTLS_ENDPOINT": "Unsupported"}):
        with pytest.raises(MutualTLSChannelError):
            client = ConversionValueRuleServiceClient()

    # Check the case GOOGLE_API_USE_CLIENT_CERTIFICATE has unsupported value.
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_CLIENT_CERTIFICATE": "Unsupported"}):
        with pytest.raises(ValueError):
            client = ConversionValueRuleServiceClient()


@mock.patch.object(ConversionValueRuleServiceClient, "DEFAULT_ENDPOINT", modify_default_endpoint(ConversionValueRuleServiceClient))
@mock.patch.dict(os.environ, {"GOOGLE_API_USE_MTLS_ENDPOINT": "auto"})
@pytest.mark.parametrize("use_client_cert_env", ["true", "false"])
def test_conversion_value_rule_service_client_mtls_env_auto(use_client_cert_env):
    # This tests the endpoint autoswitch behavior. Endpoint is autoswitched to the default
    # mtls endpoint, if GOOGLE_API_USE_CLIENT_CERTIFICATE is "true" and client cert exists.

    # Check the case client_cert_source is provided. Whether client cert is used depends on
    # GOOGLE_API_USE_CLIENT_CERTIFICATE value.
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_CLIENT_CERTIFICATE": use_client_cert_env}):
        options = client_options.ClientOptions(client_cert_source=client_cert_source_callback)
        with mock.patch('google.ads.googleads.v8.services.services.conversion_value_rule_service.transports.ConversionValueRuleServiceGrpcTransport.__init__') as grpc_transport:
            ssl_channel_creds = mock.Mock()
            with mock.patch('grpc.ssl_channel_credentials', return_value=ssl_channel_creds):
                grpc_transport.return_value = None
                client = ConversionValueRuleServiceClient(client_options=options)

                if use_client_cert_env == "false":
                    expected_ssl_channel_creds = None
                    expected_host = client.DEFAULT_ENDPOINT
                else:
                    expected_ssl_channel_creds = ssl_channel_creds
                    expected_host = client.DEFAULT_MTLS_ENDPOINT

                grpc_transport.assert_called_once_with(
                    ssl_channel_credentials=expected_ssl_channel_creds,
                    credentials=None,
                    host=expected_host,
                    client_info=transports.base.DEFAULT_CLIENT_INFO,
                )

    # Check the case ADC client cert is provided. Whether client cert is used depends on
    # GOOGLE_API_USE_CLIENT_CERTIFICATE value.
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_CLIENT_CERTIFICATE": use_client_cert_env}):
        with mock.patch('google.ads.googleads.v8.services.services.conversion_value_rule_service.transports.ConversionValueRuleServiceGrpcTransport.__init__') as grpc_transport:
            with mock.patch('google.auth.transport.grpc.SslCredentials.__init__', return_value=None):
                with mock.patch('google.auth.transport.grpc.SslCredentials.is_mtls', new_callable=mock.PropertyMock) as is_mtls_mock:
                    with mock.patch('google.auth.transport.grpc.SslCredentials.ssl_credentials', new_callable=mock.PropertyMock) as ssl_credentials_mock:
                        if use_client_cert_env == "false":
                            is_mtls_mock.return_value = False
                            ssl_credentials_mock.return_value = None
                            expected_host = client.DEFAULT_ENDPOINT
                            expected_ssl_channel_creds = None
                        else:
                            is_mtls_mock.return_value = True
                            ssl_credentials_mock.return_value = mock.Mock()
                            expected_host = client.DEFAULT_MTLS_ENDPOINT
                            expected_ssl_channel_creds = ssl_credentials_mock.return_value

                        grpc_transport.return_value = None
                        client = ConversionValueRuleServiceClient()
                        grpc_transport.assert_called_once_with(
                            ssl_channel_credentials=expected_ssl_channel_creds,
                            credentials=None,
                            host=expected_host,
                            client_info=transports.base.DEFAULT_CLIENT_INFO,
                        )

    # Check the case client_cert_source and ADC client cert are not provided.
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_CLIENT_CERTIFICATE": use_client_cert_env}):
        with mock.patch('google.ads.googleads.v8.services.services.conversion_value_rule_service.transports.ConversionValueRuleServiceGrpcTransport.__init__') as grpc_transport:
            with mock.patch('google.auth.transport.grpc.SslCredentials.__init__', return_value=None):
                with mock.patch('google.auth.transport.grpc.SslCredentials.is_mtls', new_callable=mock.PropertyMock) as is_mtls_mock:
                    is_mtls_mock.return_value = False
                    grpc_transport.return_value = None
                    client = ConversionValueRuleServiceClient()
                    grpc_transport.assert_called_once_with(
                        ssl_channel_credentials=None,
                        credentials=None,
                        host=client.DEFAULT_ENDPOINT,
                        client_info=transports.base.DEFAULT_CLIENT_INFO,
                    )


def test_conversion_value_rule_service_client_client_options_from_dict():
    with mock.patch('google.ads.googleads.v8.services.services.conversion_value_rule_service.transports.ConversionValueRuleServiceGrpcTransport.__init__') as grpc_transport:
        grpc_transport.return_value = None
        client = ConversionValueRuleServiceClient(
            client_options={'api_endpoint': 'squid.clam.whelk'}
        )
        grpc_transport.assert_called_once_with(
            ssl_channel_credentials=None,
            credentials=None,
            host="squid.clam.whelk",
            client_info=transports.base.DEFAULT_CLIENT_INFO,
        )


def test_get_conversion_value_rule(transport: str = 'grpc', request_type=conversion_value_rule_service.GetConversionValueRuleRequest):
    client = ConversionValueRuleServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_conversion_value_rule),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = conversion_value_rule.ConversionValueRule(
            resource_name='resource_name_value',
            id=205,
            owner_customer='owner_customer_value',
            status=conversion_value_rule_status.ConversionValueRuleStatusEnum.ConversionValueRuleStatus.UNKNOWN,
        )
        response = client.get_conversion_value_rule(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == conversion_value_rule_service.GetConversionValueRuleRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, conversion_value_rule.ConversionValueRule)
    assert response.resource_name == 'resource_name_value'
    assert response.id == 205
    assert response.owner_customer == 'owner_customer_value'
    assert response.status == conversion_value_rule_status.ConversionValueRuleStatusEnum.ConversionValueRuleStatus.UNKNOWN


def test_get_conversion_value_rule_from_dict():
    test_get_conversion_value_rule(request_type=dict)


def test_get_conversion_value_rule_field_headers():
    client = ConversionValueRuleServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = conversion_value_rule_service.GetConversionValueRuleRequest()

    request.resource_name = 'resource_name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_conversion_value_rule),
            '__call__') as call:
        call.return_value = conversion_value_rule.ConversionValueRule()
        client.get_conversion_value_rule(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'resource_name=resource_name/value',
    ) in kw['metadata']


def test_get_conversion_value_rule_flattened():
    client = ConversionValueRuleServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_conversion_value_rule),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = conversion_value_rule.ConversionValueRule()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.get_conversion_value_rule(
            resource_name='resource_name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0].resource_name == 'resource_name_value'


def test_get_conversion_value_rule_flattened_error():
    client = ConversionValueRuleServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.get_conversion_value_rule(
            conversion_value_rule_service.GetConversionValueRuleRequest(),
            resource_name='resource_name_value',
        )


def test_mutate_conversion_value_rules(transport: str = 'grpc', request_type=conversion_value_rule_service.MutateConversionValueRulesRequest):
    client = ConversionValueRuleServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.mutate_conversion_value_rules),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = conversion_value_rule_service.MutateConversionValueRulesResponse(
        )
        response = client.mutate_conversion_value_rules(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == conversion_value_rule_service.MutateConversionValueRulesRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, conversion_value_rule_service.MutateConversionValueRulesResponse)


def test_mutate_conversion_value_rules_from_dict():
    test_mutate_conversion_value_rules(request_type=dict)


def test_mutate_conversion_value_rules_field_headers():
    client = ConversionValueRuleServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = conversion_value_rule_service.MutateConversionValueRulesRequest()

    request.customer_id = 'customer_id/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.mutate_conversion_value_rules),
            '__call__') as call:
        call.return_value = conversion_value_rule_service.MutateConversionValueRulesResponse()
        client.mutate_conversion_value_rules(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'customer_id=customer_id/value',
    ) in kw['metadata']


def test_mutate_conversion_value_rules_flattened():
    client = ConversionValueRuleServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.mutate_conversion_value_rules),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = conversion_value_rule_service.MutateConversionValueRulesResponse()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.mutate_conversion_value_rules(
            customer_id='customer_id_value',
            operations=[conversion_value_rule_service.ConversionValueRuleOperation(update_mask=field_mask_pb2.FieldMask(paths=['paths_value']))],
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0].customer_id == 'customer_id_value'
        assert args[0].operations == [conversion_value_rule_service.ConversionValueRuleOperation(update_mask=field_mask_pb2.FieldMask(paths=['paths_value']))]


def test_mutate_conversion_value_rules_flattened_error():
    client = ConversionValueRuleServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.mutate_conversion_value_rules(
            conversion_value_rule_service.MutateConversionValueRulesRequest(),
            customer_id='customer_id_value',
            operations=[conversion_value_rule_service.ConversionValueRuleOperation(update_mask=field_mask_pb2.FieldMask(paths=['paths_value']))],
        )


def test_credentials_transport_error():
    # It is an error to provide credentials and a transport instance.
    transport = transports.ConversionValueRuleServiceGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = ConversionValueRuleServiceClient(
            credentials=ga_credentials.AnonymousCredentials(),
            transport=transport,
        )


def test_transport_instance():
    # A client may be instantiated with a custom transport instance.
    transport = transports.ConversionValueRuleServiceGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    client = ConversionValueRuleServiceClient(transport=transport)
    assert client.transport is transport


def test_transport_get_channel():
    # A client may be instantiated with a custom transport instance.
    transport = transports.ConversionValueRuleServiceGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    channel = transport.grpc_channel
    assert channel


def test_transport_grpc_default():
    # A client should use the gRPC transport by default.
    client = ConversionValueRuleServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    assert isinstance(
        client.transport,
        transports.ConversionValueRuleServiceGrpcTransport,
    )

@pytest.mark.parametrize("transport_class", [
    transports.ConversionValueRuleServiceGrpcTransport,
])
def test_transport_adc(transport_class):
    # Test default credentials are used if not provided.
    with mock.patch.object(google.auth, 'default') as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport_class()
        adc.assert_called_once()


def test_conversion_value_rule_service_base_transport():
    # Instantiate the base transport.
    with mock.patch('google.ads.googleads.v8.services.services.conversion_value_rule_service.transports.ConversionValueRuleServiceTransport.__init__') as Transport:
        Transport.return_value = None
        transport = transports.ConversionValueRuleServiceTransport(
            credentials=ga_credentials.AnonymousCredentials(),
        )

    # Every method on the transport should just blindly
    # raise NotImplementedError.
    methods = (
        'get_conversion_value_rule',
        'mutate_conversion_value_rules',
    )
    for method in methods:
        with pytest.raises(NotImplementedError):
            getattr(transport, method)(request=object())


def test_conversion_value_rule_service_base_transport_with_adc():
    # Test the default credentials are used if credentials and credentials_file are None.
    with mock.patch.object(google.auth, 'default') as adc, mock.patch('google.ads.googleads.v8.services.services.conversion_value_rule_service.transports.ConversionValueRuleServiceTransport._prep_wrapped_messages') as Transport:
        Transport.return_value = None
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport = transports.ConversionValueRuleServiceTransport()
        adc.assert_called_once()


def test_conversion_value_rule_service_auth_adc():
    # If no credentials are provided, we should use ADC credentials.
    with mock.patch.object(google.auth, 'default') as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        ConversionValueRuleServiceClient()
        adc.assert_called_once_with(scopes=(
            'https://www.googleapis.com/auth/adwords',
        ))


def test_conversion_value_rule_service_transport_auth_adc():
    # If credentials and host are not provided, the transport class should use
    # ADC credentials.
    with mock.patch.object(google.auth, 'default') as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        transports.ConversionValueRuleServiceGrpcTransport(host="squid.clam.whelk")
        adc.assert_called_once_with(scopes=(
            'https://www.googleapis.com/auth/adwords',
        ))


def test_conversion_value_rule_service_host_no_port():
    client = ConversionValueRuleServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        client_options=client_options.ClientOptions(api_endpoint='googleads.googleapis.com'),
    )
    assert client.transport._host == 'googleads.googleapis.com:443'


def test_conversion_value_rule_service_host_with_port():
    client = ConversionValueRuleServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        client_options=client_options.ClientOptions(api_endpoint='googleads.googleapis.com:8000'),
    )
    assert client.transport._host == 'googleads.googleapis.com:8000'


def test_conversion_value_rule_service_grpc_transport_channel():
    channel = grpc.insecure_channel('http://localhost/')

    # Check that channel is used if provided.
    transport = transports.ConversionValueRuleServiceGrpcTransport(
        host="squid.clam.whelk",
        channel=channel,
    )
    assert transport.grpc_channel == channel
    assert transport._host == "squid.clam.whelk:443"
    assert transport._ssl_channel_credentials == None


@pytest.mark.parametrize("transport_class", [transports.ConversionValueRuleServiceGrpcTransport])
def test_conversion_value_rule_service_transport_channel_mtls_with_client_cert_source(
    transport_class
):
    with mock.patch("grpc.ssl_channel_credentials", autospec=True) as grpc_ssl_channel_cred:
        with mock.patch.object(transport_class, "create_channel", autospec=True) as grpc_create_channel:
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
                scopes=(
                    'https://www.googleapis.com/auth/adwords',
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


@pytest.mark.parametrize("transport_class", [transports.ConversionValueRuleServiceGrpcTransport,])
def test_conversion_value_rule_service_transport_channel_mtls_with_adc(
    transport_class
):
    mock_ssl_cred = mock.Mock()
    with mock.patch.multiple(
        "google.auth.transport.grpc.SslCredentials",
        __init__=mock.Mock(return_value=None),
        ssl_credentials=mock.PropertyMock(return_value=mock_ssl_cred),
    ):
        with mock.patch.object(transport_class, "create_channel", autospec=True) as grpc_create_channel:
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
                    'https://www.googleapis.com/auth/adwords',
                ),
                ssl_credentials=mock_ssl_cred,
                quota_project_id=None,
                options=[
                    ("grpc.max_send_message_length", -1),
                    ("grpc.max_receive_message_length", -1),
                ],
            )
            assert transport.grpc_channel == mock_grpc_channel


def test_conversion_value_rule_path():
    customer_id = "squid"
    conversion_value_rule_id = "clam"
    expected = "customers/{customer_id}/conversionValueRules/{conversion_value_rule_id}".format(customer_id=customer_id, conversion_value_rule_id=conversion_value_rule_id, )
    actual = ConversionValueRuleServiceClient.conversion_value_rule_path(customer_id, conversion_value_rule_id)
    assert expected == actual


def test_parse_conversion_value_rule_path():
    expected = {
        "customer_id": "whelk",
        "conversion_value_rule_id": "octopus",
    }
    path = ConversionValueRuleServiceClient.conversion_value_rule_path(**expected)

    # Check that the path construction is reversible.
    actual = ConversionValueRuleServiceClient.parse_conversion_value_rule_path(path)
    assert expected == actual

def test_customer_path():
    customer_id = "oyster"
    expected = "customers/{customer_id}".format(customer_id=customer_id, )
    actual = ConversionValueRuleServiceClient.customer_path(customer_id)
    assert expected == actual


def test_parse_customer_path():
    expected = {
        "customer_id": "nudibranch",
    }
    path = ConversionValueRuleServiceClient.customer_path(**expected)

    # Check that the path construction is reversible.
    actual = ConversionValueRuleServiceClient.parse_customer_path(path)
    assert expected == actual

def test_geo_target_constant_path():
    criterion_id = "cuttlefish"
    expected = "geoTargetConstants/{criterion_id}".format(criterion_id=criterion_id, )
    actual = ConversionValueRuleServiceClient.geo_target_constant_path(criterion_id)
    assert expected == actual


def test_parse_geo_target_constant_path():
    expected = {
        "criterion_id": "mussel",
    }
    path = ConversionValueRuleServiceClient.geo_target_constant_path(**expected)

    # Check that the path construction is reversible.
    actual = ConversionValueRuleServiceClient.parse_geo_target_constant_path(path)
    assert expected == actual

def test_user_interest_path():
    customer_id = "winkle"
    user_interest_id = "nautilus"
    expected = "customers/{customer_id}/userInterests/{user_interest_id}".format(customer_id=customer_id, user_interest_id=user_interest_id, )
    actual = ConversionValueRuleServiceClient.user_interest_path(customer_id, user_interest_id)
    assert expected == actual


def test_parse_user_interest_path():
    expected = {
        "customer_id": "scallop",
        "user_interest_id": "abalone",
    }
    path = ConversionValueRuleServiceClient.user_interest_path(**expected)

    # Check that the path construction is reversible.
    actual = ConversionValueRuleServiceClient.parse_user_interest_path(path)
    assert expected == actual

def test_user_list_path():
    customer_id = "squid"
    user_list_id = "clam"
    expected = "customers/{customer_id}/userLists/{user_list_id}".format(customer_id=customer_id, user_list_id=user_list_id, )
    actual = ConversionValueRuleServiceClient.user_list_path(customer_id, user_list_id)
    assert expected == actual


def test_parse_user_list_path():
    expected = {
        "customer_id": "whelk",
        "user_list_id": "octopus",
    }
    path = ConversionValueRuleServiceClient.user_list_path(**expected)

    # Check that the path construction is reversible.
    actual = ConversionValueRuleServiceClient.parse_user_list_path(path)
    assert expected == actual

def test_common_billing_account_path():
    billing_account = "oyster"
    expected = "billingAccounts/{billing_account}".format(billing_account=billing_account, )
    actual = ConversionValueRuleServiceClient.common_billing_account_path(billing_account)
    assert expected == actual


def test_parse_common_billing_account_path():
    expected = {
        "billing_account": "nudibranch",
    }
    path = ConversionValueRuleServiceClient.common_billing_account_path(**expected)

    # Check that the path construction is reversible.
    actual = ConversionValueRuleServiceClient.parse_common_billing_account_path(path)
    assert expected == actual

def test_common_folder_path():
    folder = "cuttlefish"
    expected = "folders/{folder}".format(folder=folder, )
    actual = ConversionValueRuleServiceClient.common_folder_path(folder)
    assert expected == actual


def test_parse_common_folder_path():
    expected = {
        "folder": "mussel",
    }
    path = ConversionValueRuleServiceClient.common_folder_path(**expected)

    # Check that the path construction is reversible.
    actual = ConversionValueRuleServiceClient.parse_common_folder_path(path)
    assert expected == actual

def test_common_organization_path():
    organization = "winkle"
    expected = "organizations/{organization}".format(organization=organization, )
    actual = ConversionValueRuleServiceClient.common_organization_path(organization)
    assert expected == actual


def test_parse_common_organization_path():
    expected = {
        "organization": "nautilus",
    }
    path = ConversionValueRuleServiceClient.common_organization_path(**expected)

    # Check that the path construction is reversible.
    actual = ConversionValueRuleServiceClient.parse_common_organization_path(path)
    assert expected == actual

def test_common_project_path():
    project = "scallop"
    expected = "projects/{project}".format(project=project, )
    actual = ConversionValueRuleServiceClient.common_project_path(project)
    assert expected == actual


def test_parse_common_project_path():
    expected = {
        "project": "abalone",
    }
    path = ConversionValueRuleServiceClient.common_project_path(**expected)

    # Check that the path construction is reversible.
    actual = ConversionValueRuleServiceClient.parse_common_project_path(path)
    assert expected == actual

def test_common_location_path():
    project = "squid"
    location = "clam"
    expected = "projects/{project}/locations/{location}".format(project=project, location=location, )
    actual = ConversionValueRuleServiceClient.common_location_path(project, location)
    assert expected == actual


def test_parse_common_location_path():
    expected = {
        "project": "whelk",
        "location": "octopus",
    }
    path = ConversionValueRuleServiceClient.common_location_path(**expected)

    # Check that the path construction is reversible.
    actual = ConversionValueRuleServiceClient.parse_common_location_path(path)
    assert expected == actual


def test_client_withDEFAULT_CLIENT_INFO():
    client_info = gapic_v1.client_info.ClientInfo()

    with mock.patch.object(transports.ConversionValueRuleServiceTransport, '_prep_wrapped_messages') as prep:
        client = ConversionValueRuleServiceClient(
            credentials=ga_credentials.AnonymousCredentials(),
            client_info=client_info,
        )
        prep.assert_called_once_with(client_info)

    with mock.patch.object(transports.ConversionValueRuleServiceTransport, '_prep_wrapped_messages') as prep:
        transport_class = ConversionValueRuleServiceClient.get_transport_class()
        transport = transport_class(
            credentials=ga_credentials.AnonymousCredentials(),
            client_info=client_info,
        )
        prep.assert_called_once_with(client_info)
