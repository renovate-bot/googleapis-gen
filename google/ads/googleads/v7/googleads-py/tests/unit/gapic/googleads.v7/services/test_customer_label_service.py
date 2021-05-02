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

from google import auth
from google.ads.googleads.v7.resources.types import customer_label
from google.ads.googleads.v7.services.services.customer_label_service import CustomerLabelServiceClient
from google.ads.googleads.v7.services.services.customer_label_service import transports
from google.ads.googleads.v7.services.types import customer_label_service
from google.api_core import client_options
from google.api_core import gapic_v1
from google.api_core import grpc_helpers
from google.auth import credentials
from google.auth.exceptions import MutualTLSChannelError
from google.oauth2 import service_account
from google.rpc import status_pb2 as status  # type: ignore


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

    assert CustomerLabelServiceClient._get_default_mtls_endpoint(None) is None
    assert CustomerLabelServiceClient._get_default_mtls_endpoint(api_endpoint) == api_mtls_endpoint
    assert CustomerLabelServiceClient._get_default_mtls_endpoint(api_mtls_endpoint) == api_mtls_endpoint
    assert CustomerLabelServiceClient._get_default_mtls_endpoint(sandbox_endpoint) == sandbox_mtls_endpoint
    assert CustomerLabelServiceClient._get_default_mtls_endpoint(sandbox_mtls_endpoint) == sandbox_mtls_endpoint
    assert CustomerLabelServiceClient._get_default_mtls_endpoint(non_googleapi) == non_googleapi


def test_customer_label_service_client_from_service_account_info():
    creds = credentials.AnonymousCredentials()
    with mock.patch.object(service_account.Credentials, 'from_service_account_info') as factory:
        factory.return_value = creds
        info = {"valid": True}
        client = CustomerLabelServiceClient.from_service_account_info(info)
        assert client.transport._credentials == creds

        assert client.transport._host == 'googleads.googleapis.com:443'


def test_customer_label_service_client_from_service_account_file():
    creds = credentials.AnonymousCredentials()
    with mock.patch.object(service_account.Credentials, 'from_service_account_file') as factory:
        factory.return_value = creds
        client = CustomerLabelServiceClient.from_service_account_file("dummy/file/path.json")
        assert client.transport._credentials == creds

        client = CustomerLabelServiceClient.from_service_account_json("dummy/file/path.json")
        assert client.transport._credentials == creds

        assert client.transport._host == 'googleads.googleapis.com:443'


def test_customer_label_service_client_get_transport_class():
    transport = CustomerLabelServiceClient.get_transport_class()
    assert transport == transports.CustomerLabelServiceGrpcTransport

    transport = CustomerLabelServiceClient.get_transport_class("grpc")
    assert transport == transports.CustomerLabelServiceGrpcTransport


@mock.patch.object(CustomerLabelServiceClient, "DEFAULT_ENDPOINT", modify_default_endpoint(CustomerLabelServiceClient))
def test_customer_label_service_client_client_options():
    # Check that if channel is provided we won't create a new one.
    with mock.patch('google.ads.googleads.v7.services.services.customer_label_service.CustomerLabelServiceClient.get_transport_class') as gtc:
        transport = transports.CustomerLabelServiceGrpcTransport(
            credentials=credentials.AnonymousCredentials()
        )
        client = CustomerLabelServiceClient(transport=transport)
        gtc.assert_not_called()

    # Check that if channel is provided via str we will create a new one.
    with mock.patch('google.ads.googleads.v7.services.services.customer_label_service.CustomerLabelServiceClient.get_transport_class') as gtc:
        client = CustomerLabelServiceClient(transport="grpc")
        gtc.assert_called()

    # Check the case api_endpoint is provided.
    options = client_options.ClientOptions(api_endpoint="squid.clam.whelk")
    with mock.patch('google.ads.googleads.v7.services.services.customer_label_service.transports.CustomerLabelServiceGrpcTransport.__init__') as grpc_transport:
        grpc_transport.return_value = None
        client = CustomerLabelServiceClient(client_options=options)
        grpc_transport.assert_called_once_with(
            ssl_channel_credentials=None,
            credentials=None,
            host="squid.clam.whelk",
            client_info=transports.base.DEFAULT_CLIENT_INFO,
        )

    # Check the case api_endpoint is not provided and GOOGLE_API_USE_MTLS_ENDPOINT
    # is "never".
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_MTLS_ENDPOINT": "never"}):
        with mock.patch('google.ads.googleads.v7.services.services.customer_label_service.transports.CustomerLabelServiceGrpcTransport.__init__') as grpc_transport:
            grpc_transport.return_value = None
            client = CustomerLabelServiceClient()
            grpc_transport.assert_called_once_with(
                ssl_channel_credentials=None,
                credentials=None,
                host=client.DEFAULT_ENDPOINT,
                client_info=transports.base.DEFAULT_CLIENT_INFO,
            )

    # Check the case api_endpoint is not provided and GOOGLE_API_USE_MTLS_ENDPOINT is
    # "always".
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_MTLS_ENDPOINT": "always"}):
        with mock.patch('google.ads.googleads.v7.services.services.customer_label_service.transports.CustomerLabelServiceGrpcTransport.__init__') as grpc_transport:
            grpc_transport.return_value = None
            client = CustomerLabelServiceClient()
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
            client = CustomerLabelServiceClient()

    # Check the case GOOGLE_API_USE_CLIENT_CERTIFICATE has unsupported value.
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_CLIENT_CERTIFICATE": "Unsupported"}):
        with pytest.raises(ValueError):
            client = CustomerLabelServiceClient()


@mock.patch.object(CustomerLabelServiceClient, "DEFAULT_ENDPOINT", modify_default_endpoint(CustomerLabelServiceClient))
@mock.patch.dict(os.environ, {"GOOGLE_API_USE_MTLS_ENDPOINT": "auto"})
@pytest.mark.parametrize("use_client_cert_env", ["true", "false"])
def test_customer_label_service_client_mtls_env_auto(use_client_cert_env):
    # This tests the endpoint autoswitch behavior. Endpoint is autoswitched to the default
    # mtls endpoint, if GOOGLE_API_USE_CLIENT_CERTIFICATE is "true" and client cert exists.

    # Check the case client_cert_source is provided. Whether client cert is used depends on
    # GOOGLE_API_USE_CLIENT_CERTIFICATE value.
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_CLIENT_CERTIFICATE": use_client_cert_env}):
        options = client_options.ClientOptions(client_cert_source=client_cert_source_callback)
        with mock.patch('google.ads.googleads.v7.services.services.customer_label_service.transports.CustomerLabelServiceGrpcTransport.__init__') as grpc_transport:
            ssl_channel_creds = mock.Mock()
            with mock.patch('grpc.ssl_channel_credentials', return_value=ssl_channel_creds):
                grpc_transport.return_value = None
                client = CustomerLabelServiceClient(client_options=options)

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
        with mock.patch('google.ads.googleads.v7.services.services.customer_label_service.transports.CustomerLabelServiceGrpcTransport.__init__') as grpc_transport:
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
                        client = CustomerLabelServiceClient()
                        grpc_transport.assert_called_once_with(
                            ssl_channel_credentials=expected_ssl_channel_creds,
                            credentials=None,
                            host=expected_host,
                            client_info=transports.base.DEFAULT_CLIENT_INFO,
                        )

    # Check the case client_cert_source and ADC client cert are not provided.
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_CLIENT_CERTIFICATE": use_client_cert_env}):
        with mock.patch('google.ads.googleads.v7.services.services.customer_label_service.transports.CustomerLabelServiceGrpcTransport.__init__') as grpc_transport:
            with mock.patch('google.auth.transport.grpc.SslCredentials.__init__', return_value=None):
                with mock.patch('google.auth.transport.grpc.SslCredentials.is_mtls', new_callable=mock.PropertyMock) as is_mtls_mock:
                    is_mtls_mock.return_value = False
                    grpc_transport.return_value = None
                    client = CustomerLabelServiceClient()
                    grpc_transport.assert_called_once_with(
                        ssl_channel_credentials=None,
                        credentials=None,
                        host=client.DEFAULT_ENDPOINT,
                        client_info=transports.base.DEFAULT_CLIENT_INFO,
                    )


def test_customer_label_service_client_client_options_from_dict():
    with mock.patch('google.ads.googleads.v7.services.services.customer_label_service.transports.CustomerLabelServiceGrpcTransport.__init__') as grpc_transport:
        grpc_transport.return_value = None
        client = CustomerLabelServiceClient(
            client_options={'api_endpoint': 'squid.clam.whelk'}
        )
        grpc_transport.assert_called_once_with(
            ssl_channel_credentials=None,
            credentials=None,
            host="squid.clam.whelk",
            client_info=transports.base.DEFAULT_CLIENT_INFO,
        )


def test_get_customer_label(transport: str = 'grpc', request_type=customer_label_service.GetCustomerLabelRequest):
    client = CustomerLabelServiceClient(
        credentials=credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_customer_label),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = customer_label.CustomerLabel(
            resource_name='resource_name_value',

            customer='customer_value',

            label='label_value',

        )

        response = client.get_customer_label(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0] == customer_label_service.GetCustomerLabelRequest()

    # Establish that the response is the type that we expect.

    assert isinstance(response, customer_label.CustomerLabel)

    assert response.resource_name == 'resource_name_value'

    assert response.customer == 'customer_value'

    assert response.label == 'label_value'


def test_get_customer_label_from_dict():
    test_get_customer_label(request_type=dict)


def test_get_customer_label_field_headers():
    client = CustomerLabelServiceClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = customer_label_service.GetCustomerLabelRequest()
    request.resource_name = 'resource_name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_customer_label),
            '__call__') as call:
        call.return_value = customer_label.CustomerLabel()

        client.get_customer_label(request)

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


def test_get_customer_label_flattened():
    client = CustomerLabelServiceClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_customer_label),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = customer_label.CustomerLabel()

        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.get_customer_label(
            resource_name='resource_name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0].resource_name == 'resource_name_value'


def test_get_customer_label_flattened_error():
    client = CustomerLabelServiceClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.get_customer_label(
            customer_label_service.GetCustomerLabelRequest(),
            resource_name='resource_name_value',
        )


def test_mutate_customer_labels(transport: str = 'grpc', request_type=customer_label_service.MutateCustomerLabelsRequest):
    client = CustomerLabelServiceClient(
        credentials=credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.mutate_customer_labels),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = customer_label_service.MutateCustomerLabelsResponse(
        )

        response = client.mutate_customer_labels(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0] == customer_label_service.MutateCustomerLabelsRequest()

    # Establish that the response is the type that we expect.

    assert isinstance(response, customer_label_service.MutateCustomerLabelsResponse)


def test_mutate_customer_labels_from_dict():
    test_mutate_customer_labels(request_type=dict)


def test_mutate_customer_labels_field_headers():
    client = CustomerLabelServiceClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = customer_label_service.MutateCustomerLabelsRequest()
    request.customer_id = 'customer_id/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.mutate_customer_labels),
            '__call__') as call:
        call.return_value = customer_label_service.MutateCustomerLabelsResponse()

        client.mutate_customer_labels(request)

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


def test_mutate_customer_labels_flattened():
    client = CustomerLabelServiceClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.mutate_customer_labels),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = customer_label_service.MutateCustomerLabelsResponse()

        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.mutate_customer_labels(
            customer_id='customer_id_value',
            operations=[customer_label_service.CustomerLabelOperation(create=customer_label.CustomerLabel(resource_name='resource_name_value'))],
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]

        assert args[0].customer_id == 'customer_id_value'

        assert args[0].operations == [customer_label_service.CustomerLabelOperation(create=customer_label.CustomerLabel(resource_name='resource_name_value'))]


def test_mutate_customer_labels_flattened_error():
    client = CustomerLabelServiceClient(
        credentials=credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.mutate_customer_labels(
            customer_label_service.MutateCustomerLabelsRequest(),
            customer_id='customer_id_value',
            operations=[customer_label_service.CustomerLabelOperation(create=customer_label.CustomerLabel(resource_name='resource_name_value'))],
        )


def test_credentials_transport_error():
    # It is an error to provide credentials and a transport instance.
    transport = transports.CustomerLabelServiceGrpcTransport(
        credentials=credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = CustomerLabelServiceClient(
            credentials=credentials.AnonymousCredentials(),
            transport=transport,
        )


def test_transport_instance():
    # A client may be instantiated with a custom transport instance.
    transport = transports.CustomerLabelServiceGrpcTransport(
        credentials=credentials.AnonymousCredentials(),
    )
    client = CustomerLabelServiceClient(transport=transport)
    assert client.transport is transport


def test_transport_get_channel():
    # A client may be instantiated with a custom transport instance.
    transport = transports.CustomerLabelServiceGrpcTransport(
        credentials=credentials.AnonymousCredentials(),
    )
    channel = transport.grpc_channel
    assert channel


def test_transport_grpc_default():
    # A client should use the gRPC transport by default.
    client = CustomerLabelServiceClient(
        credentials=credentials.AnonymousCredentials(),
    )
    assert isinstance(
        client.transport,
        transports.CustomerLabelServiceGrpcTransport,
    )

@pytest.mark.parametrize("transport_class", [
    transports.CustomerLabelServiceGrpcTransport,
])
def test_transport_adc(transport_class):
    # Test default credentials are used if not provided.
    with mock.patch.object(auth, 'default') as adc:
        adc.return_value = (credentials.AnonymousCredentials(), None)
        transport_class()
        adc.assert_called_once()


def test_customer_label_service_base_transport():
    # Instantiate the base transport.
    with mock.patch('google.ads.googleads.v7.services.services.customer_label_service.transports.CustomerLabelServiceTransport.__init__') as Transport:
        Transport.return_value = None
        transport = transports.CustomerLabelServiceTransport(
            credentials=credentials.AnonymousCredentials(),
        )

    # Every method on the transport should just blindly
    # raise NotImplementedError.
    methods = (
        'get_customer_label',
        'mutate_customer_labels',
        )
    for method in methods:
        with pytest.raises(NotImplementedError):
            getattr(transport, method)(request=object())


def test_customer_label_service_base_transport_with_adc():
    # Test the default credentials are used if credentials and credentials_file are None.
    with mock.patch.object(auth, 'default') as adc, mock.patch('google.ads.googleads.v7.services.services.customer_label_service.transports.CustomerLabelServiceTransport._prep_wrapped_messages') as Transport:
        Transport.return_value = None
        adc.return_value = (credentials.AnonymousCredentials(), None)
        transport = transports.CustomerLabelServiceTransport()
        adc.assert_called_once()


def test_customer_label_service_auth_adc():
    # If no credentials are provided, we should use ADC credentials.
    with mock.patch.object(auth, 'default') as adc:
        adc.return_value = (credentials.AnonymousCredentials(), None)
        CustomerLabelServiceClient()
        adc.assert_called_once_with(scopes=(
            'https://www.googleapis.com/auth/adwords',
        ))


def test_customer_label_service_transport_auth_adc():
    # If credentials and host are not provided, the transport class should use
    # ADC credentials.
    with mock.patch.object(auth, 'default') as adc:
        adc.return_value = (credentials.AnonymousCredentials(), None)
        transports.CustomerLabelServiceGrpcTransport(host="squid.clam.whelk")
        adc.assert_called_once_with(scopes=(
            'https://www.googleapis.com/auth/adwords',
        ))


def test_customer_label_service_host_no_port():
    client = CustomerLabelServiceClient(
        credentials=credentials.AnonymousCredentials(),
        client_options=client_options.ClientOptions(api_endpoint='googleads.googleapis.com'),
    )
    assert client.transport._host == 'googleads.googleapis.com:443'


def test_customer_label_service_host_with_port():
    client = CustomerLabelServiceClient(
        credentials=credentials.AnonymousCredentials(),
        client_options=client_options.ClientOptions(api_endpoint='googleads.googleapis.com:8000'),
    )
    assert client.transport._host == 'googleads.googleapis.com:8000'


def test_customer_label_service_grpc_transport_channel():
    channel = grpc.insecure_channel('http://localhost/')

    # Check that channel is used if provided.
    transport = transports.CustomerLabelServiceGrpcTransport(
        host="squid.clam.whelk",
        channel=channel,
    )
    assert transport.grpc_channel == channel
    assert transport._host == "squid.clam.whelk:443"
    assert transport._ssl_channel_credentials == None


@pytest.mark.parametrize("transport_class", [transports.CustomerLabelServiceGrpcTransport])
def test_customer_label_service_transport_channel_mtls_with_client_cert_source(
    transport_class
):
    with mock.patch("grpc.ssl_channel_credentials", autospec=True) as grpc_ssl_channel_cred:
        with mock.patch.object(transport_class, "create_channel", autospec=True) as grpc_create_channel:
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


@pytest.mark.parametrize("transport_class", [transports.CustomerLabelServiceGrpcTransport,])
def test_customer_label_service_transport_channel_mtls_with_adc(
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


def test_customer_path():
    customer_id = "squid"

    expected = "customers/{customer_id}".format(customer_id=customer_id, )
    actual = CustomerLabelServiceClient.customer_path(customer_id)
    assert expected == actual


def test_parse_customer_path():
    expected = {
    "customer_id": "clam",

    }
    path = CustomerLabelServiceClient.customer_path(**expected)

    # Check that the path construction is reversible.
    actual = CustomerLabelServiceClient.parse_customer_path(path)
    assert expected == actual

def test_customer_label_path():
    customer_id = "whelk"
    label_id = "octopus"

    expected = "customers/{customer_id}/customerLabels/{label_id}".format(customer_id=customer_id, label_id=label_id, )
    actual = CustomerLabelServiceClient.customer_label_path(customer_id, label_id)
    assert expected == actual


def test_parse_customer_label_path():
    expected = {
    "customer_id": "oyster",
    "label_id": "nudibranch",

    }
    path = CustomerLabelServiceClient.customer_label_path(**expected)

    # Check that the path construction is reversible.
    actual = CustomerLabelServiceClient.parse_customer_label_path(path)
    assert expected == actual

def test_label_path():
    customer_id = "cuttlefish"
    label_id = "mussel"

    expected = "customers/{customer_id}/labels/{label_id}".format(customer_id=customer_id, label_id=label_id, )
    actual = CustomerLabelServiceClient.label_path(customer_id, label_id)
    assert expected == actual


def test_parse_label_path():
    expected = {
    "customer_id": "winkle",
    "label_id": "nautilus",

    }
    path = CustomerLabelServiceClient.label_path(**expected)

    # Check that the path construction is reversible.
    actual = CustomerLabelServiceClient.parse_label_path(path)
    assert expected == actual

def test_common_billing_account_path():
    billing_account = "scallop"

    expected = "billingAccounts/{billing_account}".format(billing_account=billing_account, )
    actual = CustomerLabelServiceClient.common_billing_account_path(billing_account)
    assert expected == actual


def test_parse_common_billing_account_path():
    expected = {
    "billing_account": "abalone",

    }
    path = CustomerLabelServiceClient.common_billing_account_path(**expected)

    # Check that the path construction is reversible.
    actual = CustomerLabelServiceClient.parse_common_billing_account_path(path)
    assert expected == actual

def test_common_folder_path():
    folder = "squid"

    expected = "folders/{folder}".format(folder=folder, )
    actual = CustomerLabelServiceClient.common_folder_path(folder)
    assert expected == actual


def test_parse_common_folder_path():
    expected = {
    "folder": "clam",

    }
    path = CustomerLabelServiceClient.common_folder_path(**expected)

    # Check that the path construction is reversible.
    actual = CustomerLabelServiceClient.parse_common_folder_path(path)
    assert expected == actual

def test_common_organization_path():
    organization = "whelk"

    expected = "organizations/{organization}".format(organization=organization, )
    actual = CustomerLabelServiceClient.common_organization_path(organization)
    assert expected == actual


def test_parse_common_organization_path():
    expected = {
    "organization": "octopus",

    }
    path = CustomerLabelServiceClient.common_organization_path(**expected)

    # Check that the path construction is reversible.
    actual = CustomerLabelServiceClient.parse_common_organization_path(path)
    assert expected == actual

def test_common_project_path():
    project = "oyster"

    expected = "projects/{project}".format(project=project, )
    actual = CustomerLabelServiceClient.common_project_path(project)
    assert expected == actual


def test_parse_common_project_path():
    expected = {
    "project": "nudibranch",

    }
    path = CustomerLabelServiceClient.common_project_path(**expected)

    # Check that the path construction is reversible.
    actual = CustomerLabelServiceClient.parse_common_project_path(path)
    assert expected == actual

def test_common_location_path():
    project = "cuttlefish"
    location = "mussel"

    expected = "projects/{project}/locations/{location}".format(project=project, location=location, )
    actual = CustomerLabelServiceClient.common_location_path(project, location)
    assert expected == actual


def test_parse_common_location_path():
    expected = {
    "project": "winkle",
    "location": "nautilus",

    }
    path = CustomerLabelServiceClient.common_location_path(**expected)

    # Check that the path construction is reversible.
    actual = CustomerLabelServiceClient.parse_common_location_path(path)
    assert expected == actual


def test_client_withDEFAULT_CLIENT_INFO():
    client_info = gapic_v1.client_info.ClientInfo()

    with mock.patch.object(transports.CustomerLabelServiceTransport, '_prep_wrapped_messages') as prep:
        client = CustomerLabelServiceClient(
            credentials=credentials.AnonymousCredentials(),
            client_info=client_info,
        )
        prep.assert_called_once_with(client_info)

    with mock.patch.object(transports.CustomerLabelServiceTransport, '_prep_wrapped_messages') as prep:
        transport_class = CustomerLabelServiceClient.get_transport_class()
        transport = transport_class(
            credentials=credentials.AnonymousCredentials(),
            client_info=client_info,
        )
        prep.assert_called_once_with(client_info)
