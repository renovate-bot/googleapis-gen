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

from google.ads.googleads.v7.common.types import offline_user_data
from google.ads.googleads.v7.enums.types import offline_user_data_job_failure_reason
from google.ads.googleads.v7.enums.types import offline_user_data_job_status
from google.ads.googleads.v7.enums.types import offline_user_data_job_type
from google.ads.googleads.v7.enums.types import user_identifier_source
from google.ads.googleads.v7.resources.types import offline_user_data_job
from google.ads.googleads.v7.services.services.offline_user_data_job_service import OfflineUserDataJobServiceClient
from google.ads.googleads.v7.services.services.offline_user_data_job_service import transports
from google.ads.googleads.v7.services.types import offline_user_data_job_service
from google.api_core import client_options
from google.api_core import future
from google.api_core import gapic_v1
from google.api_core import grpc_helpers
from google.api_core import operation_async  # type: ignore
from google.api_core import operations_v1
from google.auth import credentials as ga_credentials
from google.auth.exceptions import MutualTLSChannelError
from google.longrunning import operations_pb2
from google.oauth2 import service_account
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

    assert OfflineUserDataJobServiceClient._get_default_mtls_endpoint(None) is None
    assert OfflineUserDataJobServiceClient._get_default_mtls_endpoint(api_endpoint) == api_mtls_endpoint
    assert OfflineUserDataJobServiceClient._get_default_mtls_endpoint(api_mtls_endpoint) == api_mtls_endpoint
    assert OfflineUserDataJobServiceClient._get_default_mtls_endpoint(sandbox_endpoint) == sandbox_mtls_endpoint
    assert OfflineUserDataJobServiceClient._get_default_mtls_endpoint(sandbox_mtls_endpoint) == sandbox_mtls_endpoint
    assert OfflineUserDataJobServiceClient._get_default_mtls_endpoint(non_googleapi) == non_googleapi


def test_offline_user_data_job_service_client_from_service_account_info():
    creds = ga_credentials.AnonymousCredentials()
    with mock.patch.object(service_account.Credentials, 'from_service_account_info') as factory:
        factory.return_value = creds
        info = {"valid": True}
        client = OfflineUserDataJobServiceClient.from_service_account_info(info)
        assert client.transport._credentials == creds

        assert client.transport._host == 'googleads.googleapis.com:443'


def test_offline_user_data_job_service_client_from_service_account_file():
    creds = ga_credentials.AnonymousCredentials()
    with mock.patch.object(service_account.Credentials, 'from_service_account_file') as factory:
        factory.return_value = creds
        client = OfflineUserDataJobServiceClient.from_service_account_file("dummy/file/path.json")
        assert client.transport._credentials == creds

        client = OfflineUserDataJobServiceClient.from_service_account_json("dummy/file/path.json")
        assert client.transport._credentials == creds

        assert client.transport._host == 'googleads.googleapis.com:443'


def test_offline_user_data_job_service_client_get_transport_class():
    transport = OfflineUserDataJobServiceClient.get_transport_class()
    assert transport == transports.OfflineUserDataJobServiceGrpcTransport

    transport = OfflineUserDataJobServiceClient.get_transport_class("grpc")
    assert transport == transports.OfflineUserDataJobServiceGrpcTransport


@mock.patch.object(OfflineUserDataJobServiceClient, "DEFAULT_ENDPOINT", modify_default_endpoint(OfflineUserDataJobServiceClient))
def test_offline_user_data_job_service_client_client_options():
    # Check that if channel is provided we won't create a new one.
    with mock.patch('google.ads.googleads.v7.services.services.offline_user_data_job_service.OfflineUserDataJobServiceClient.get_transport_class') as gtc:
        transport = transports.OfflineUserDataJobServiceGrpcTransport(
            credentials=ga_credentials.AnonymousCredentials()
        )
        client = OfflineUserDataJobServiceClient(transport=transport)
        gtc.assert_not_called()

    # Check that if channel is provided via str we will create a new one.
    with mock.patch('google.ads.googleads.v7.services.services.offline_user_data_job_service.OfflineUserDataJobServiceClient.get_transport_class') as gtc:
        client = OfflineUserDataJobServiceClient(transport="grpc")
        gtc.assert_called()

    # Check the case api_endpoint is provided.
    options = client_options.ClientOptions(api_endpoint="squid.clam.whelk")
    with mock.patch('google.ads.googleads.v7.services.services.offline_user_data_job_service.transports.OfflineUserDataJobServiceGrpcTransport.__init__') as grpc_transport:
        grpc_transport.return_value = None
        client = OfflineUserDataJobServiceClient(client_options=options)
        grpc_transport.assert_called_once_with(
            ssl_channel_credentials=None,
            credentials=None,
            host="squid.clam.whelk",
            client_info=transports.base.DEFAULT_CLIENT_INFO,
        )

    # Check the case api_endpoint is not provided and GOOGLE_API_USE_MTLS_ENDPOINT
    # is "never".
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_MTLS_ENDPOINT": "never"}):
        with mock.patch('google.ads.googleads.v7.services.services.offline_user_data_job_service.transports.OfflineUserDataJobServiceGrpcTransport.__init__') as grpc_transport:
            grpc_transport.return_value = None
            client = OfflineUserDataJobServiceClient()
            grpc_transport.assert_called_once_with(
                ssl_channel_credentials=None,
                credentials=None,
                host=client.DEFAULT_ENDPOINT,
                client_info=transports.base.DEFAULT_CLIENT_INFO,
            )

    # Check the case api_endpoint is not provided and GOOGLE_API_USE_MTLS_ENDPOINT is
    # "always".
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_MTLS_ENDPOINT": "always"}):
        with mock.patch('google.ads.googleads.v7.services.services.offline_user_data_job_service.transports.OfflineUserDataJobServiceGrpcTransport.__init__') as grpc_transport:
            grpc_transport.return_value = None
            client = OfflineUserDataJobServiceClient()
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
            client = OfflineUserDataJobServiceClient()

    # Check the case GOOGLE_API_USE_CLIENT_CERTIFICATE has unsupported value.
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_CLIENT_CERTIFICATE": "Unsupported"}):
        with pytest.raises(ValueError):
            client = OfflineUserDataJobServiceClient()


@mock.patch.object(OfflineUserDataJobServiceClient, "DEFAULT_ENDPOINT", modify_default_endpoint(OfflineUserDataJobServiceClient))
@mock.patch.dict(os.environ, {"GOOGLE_API_USE_MTLS_ENDPOINT": "auto"})
@pytest.mark.parametrize("use_client_cert_env", ["true", "false"])
def test_offline_user_data_job_service_client_mtls_env_auto(use_client_cert_env):
    # This tests the endpoint autoswitch behavior. Endpoint is autoswitched to the default
    # mtls endpoint, if GOOGLE_API_USE_CLIENT_CERTIFICATE is "true" and client cert exists.

    # Check the case client_cert_source is provided. Whether client cert is used depends on
    # GOOGLE_API_USE_CLIENT_CERTIFICATE value.
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_CLIENT_CERTIFICATE": use_client_cert_env}):
        options = client_options.ClientOptions(client_cert_source=client_cert_source_callback)
        with mock.patch('google.ads.googleads.v7.services.services.offline_user_data_job_service.transports.OfflineUserDataJobServiceGrpcTransport.__init__') as grpc_transport:
            ssl_channel_creds = mock.Mock()
            with mock.patch('grpc.ssl_channel_credentials', return_value=ssl_channel_creds):
                grpc_transport.return_value = None
                client = OfflineUserDataJobServiceClient(client_options=options)

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
        with mock.patch('google.ads.googleads.v7.services.services.offline_user_data_job_service.transports.OfflineUserDataJobServiceGrpcTransport.__init__') as grpc_transport:
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
                        client = OfflineUserDataJobServiceClient()
                        grpc_transport.assert_called_once_with(
                            ssl_channel_credentials=expected_ssl_channel_creds,
                            credentials=None,
                            host=expected_host,
                            client_info=transports.base.DEFAULT_CLIENT_INFO,
                        )

    # Check the case client_cert_source and ADC client cert are not provided.
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_CLIENT_CERTIFICATE": use_client_cert_env}):
        with mock.patch('google.ads.googleads.v7.services.services.offline_user_data_job_service.transports.OfflineUserDataJobServiceGrpcTransport.__init__') as grpc_transport:
            with mock.patch('google.auth.transport.grpc.SslCredentials.__init__', return_value=None):
                with mock.patch('google.auth.transport.grpc.SslCredentials.is_mtls', new_callable=mock.PropertyMock) as is_mtls_mock:
                    is_mtls_mock.return_value = False
                    grpc_transport.return_value = None
                    client = OfflineUserDataJobServiceClient()
                    grpc_transport.assert_called_once_with(
                        ssl_channel_credentials=None,
                        credentials=None,
                        host=client.DEFAULT_ENDPOINT,
                        client_info=transports.base.DEFAULT_CLIENT_INFO,
                    )


def test_offline_user_data_job_service_client_client_options_from_dict():
    with mock.patch('google.ads.googleads.v7.services.services.offline_user_data_job_service.transports.OfflineUserDataJobServiceGrpcTransport.__init__') as grpc_transport:
        grpc_transport.return_value = None
        client = OfflineUserDataJobServiceClient(
            client_options={'api_endpoint': 'squid.clam.whelk'}
        )
        grpc_transport.assert_called_once_with(
            ssl_channel_credentials=None,
            credentials=None,
            host="squid.clam.whelk",
            client_info=transports.base.DEFAULT_CLIENT_INFO,
        )


def test_create_offline_user_data_job(transport: str = 'grpc', request_type=offline_user_data_job_service.CreateOfflineUserDataJobRequest):
    client = OfflineUserDataJobServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_offline_user_data_job),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = offline_user_data_job_service.CreateOfflineUserDataJobResponse(
            resource_name='resource_name_value',
        )
        response = client.create_offline_user_data_job(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == offline_user_data_job_service.CreateOfflineUserDataJobRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, offline_user_data_job_service.CreateOfflineUserDataJobResponse)
    assert response.resource_name == 'resource_name_value'


def test_create_offline_user_data_job_from_dict():
    test_create_offline_user_data_job(request_type=dict)


def test_create_offline_user_data_job_field_headers():
    client = OfflineUserDataJobServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = offline_user_data_job_service.CreateOfflineUserDataJobRequest()

    request.customer_id = 'customer_id/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_offline_user_data_job),
            '__call__') as call:
        call.return_value = offline_user_data_job_service.CreateOfflineUserDataJobResponse()
        client.create_offline_user_data_job(request)

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


def test_create_offline_user_data_job_flattened():
    client = OfflineUserDataJobServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_offline_user_data_job),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = offline_user_data_job_service.CreateOfflineUserDataJobResponse()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.create_offline_user_data_job(
            customer_id='customer_id_value',
            job=offline_user_data_job.OfflineUserDataJob(resource_name='resource_name_value'),
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0].customer_id == 'customer_id_value'
        assert args[0].job == offline_user_data_job.OfflineUserDataJob(resource_name='resource_name_value')


def test_create_offline_user_data_job_flattened_error():
    client = OfflineUserDataJobServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.create_offline_user_data_job(
            offline_user_data_job_service.CreateOfflineUserDataJobRequest(),
            customer_id='customer_id_value',
            job=offline_user_data_job.OfflineUserDataJob(resource_name='resource_name_value'),
        )


def test_get_offline_user_data_job(transport: str = 'grpc', request_type=offline_user_data_job_service.GetOfflineUserDataJobRequest):
    client = OfflineUserDataJobServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_offline_user_data_job),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = offline_user_data_job.OfflineUserDataJob(
            resource_name='resource_name_value',
            id=205,
            external_id=1167,
            type_=offline_user_data_job_type.OfflineUserDataJobTypeEnum.OfflineUserDataJobType.UNKNOWN,
            status=offline_user_data_job_status.OfflineUserDataJobStatusEnum.OfflineUserDataJobStatus.UNKNOWN,
            failure_reason=offline_user_data_job_failure_reason.OfflineUserDataJobFailureReasonEnum.OfflineUserDataJobFailureReason.UNKNOWN,
            customer_match_user_list_metadata=offline_user_data.CustomerMatchUserListMetadata(user_list='user_list_value'),
        )
        response = client.get_offline_user_data_job(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == offline_user_data_job_service.GetOfflineUserDataJobRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, offline_user_data_job.OfflineUserDataJob)
    assert response.resource_name == 'resource_name_value'
    assert response.id == 205
    assert response.external_id == 1167
    assert response.type_ == offline_user_data_job_type.OfflineUserDataJobTypeEnum.OfflineUserDataJobType.UNKNOWN
    assert response.status == offline_user_data_job_status.OfflineUserDataJobStatusEnum.OfflineUserDataJobStatus.UNKNOWN
    assert response.failure_reason == offline_user_data_job_failure_reason.OfflineUserDataJobFailureReasonEnum.OfflineUserDataJobFailureReason.UNKNOWN


def test_get_offline_user_data_job_from_dict():
    test_get_offline_user_data_job(request_type=dict)


def test_get_offline_user_data_job_field_headers():
    client = OfflineUserDataJobServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = offline_user_data_job_service.GetOfflineUserDataJobRequest()

    request.resource_name = 'resource_name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_offline_user_data_job),
            '__call__') as call:
        call.return_value = offline_user_data_job.OfflineUserDataJob()
        client.get_offline_user_data_job(request)

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


def test_get_offline_user_data_job_flattened():
    client = OfflineUserDataJobServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_offline_user_data_job),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = offline_user_data_job.OfflineUserDataJob()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.get_offline_user_data_job(
            resource_name='resource_name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0].resource_name == 'resource_name_value'


def test_get_offline_user_data_job_flattened_error():
    client = OfflineUserDataJobServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.get_offline_user_data_job(
            offline_user_data_job_service.GetOfflineUserDataJobRequest(),
            resource_name='resource_name_value',
        )


def test_add_offline_user_data_job_operations(transport: str = 'grpc', request_type=offline_user_data_job_service.AddOfflineUserDataJobOperationsRequest):
    client = OfflineUserDataJobServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.add_offline_user_data_job_operations),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = offline_user_data_job_service.AddOfflineUserDataJobOperationsResponse(
        )
        response = client.add_offline_user_data_job_operations(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == offline_user_data_job_service.AddOfflineUserDataJobOperationsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, offline_user_data_job_service.AddOfflineUserDataJobOperationsResponse)


def test_add_offline_user_data_job_operations_from_dict():
    test_add_offline_user_data_job_operations(request_type=dict)


def test_add_offline_user_data_job_operations_field_headers():
    client = OfflineUserDataJobServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = offline_user_data_job_service.AddOfflineUserDataJobOperationsRequest()

    request.resource_name = 'resource_name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.add_offline_user_data_job_operations),
            '__call__') as call:
        call.return_value = offline_user_data_job_service.AddOfflineUserDataJobOperationsResponse()
        client.add_offline_user_data_job_operations(request)

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


def test_add_offline_user_data_job_operations_flattened():
    client = OfflineUserDataJobServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.add_offline_user_data_job_operations),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = offline_user_data_job_service.AddOfflineUserDataJobOperationsResponse()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.add_offline_user_data_job_operations(
            resource_name='resource_name_value',
            operations=[offline_user_data_job_service.OfflineUserDataJobOperation(create=offline_user_data.UserData(user_identifiers=[offline_user_data.UserIdentifier(user_identifier_source=user_identifier_source.UserIdentifierSourceEnum.UserIdentifierSource.UNKNOWN)]))],
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0].resource_name == 'resource_name_value'
        assert args[0].operations == [offline_user_data_job_service.OfflineUserDataJobOperation(create=offline_user_data.UserData(user_identifiers=[offline_user_data.UserIdentifier(user_identifier_source=user_identifier_source.UserIdentifierSourceEnum.UserIdentifierSource.UNKNOWN)]))]


def test_add_offline_user_data_job_operations_flattened_error():
    client = OfflineUserDataJobServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.add_offline_user_data_job_operations(
            offline_user_data_job_service.AddOfflineUserDataJobOperationsRequest(),
            resource_name='resource_name_value',
            operations=[offline_user_data_job_service.OfflineUserDataJobOperation(create=offline_user_data.UserData(user_identifiers=[offline_user_data.UserIdentifier(user_identifier_source=user_identifier_source.UserIdentifierSourceEnum.UserIdentifierSource.UNKNOWN)]))],
        )


def test_run_offline_user_data_job(transport: str = 'grpc', request_type=offline_user_data_job_service.RunOfflineUserDataJobRequest):
    client = OfflineUserDataJobServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.run_offline_user_data_job),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/spam')
        response = client.run_offline_user_data_job(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == offline_user_data_job_service.RunOfflineUserDataJobRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


def test_run_offline_user_data_job_from_dict():
    test_run_offline_user_data_job(request_type=dict)


def test_run_offline_user_data_job_field_headers():
    client = OfflineUserDataJobServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = offline_user_data_job_service.RunOfflineUserDataJobRequest()

    request.resource_name = 'resource_name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.run_offline_user_data_job),
            '__call__') as call:
        call.return_value = operations_pb2.Operation(name='operations/op')
        client.run_offline_user_data_job(request)

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


def test_run_offline_user_data_job_flattened():
    client = OfflineUserDataJobServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.run_offline_user_data_job),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/op')
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.run_offline_user_data_job(
            resource_name='resource_name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0].resource_name == 'resource_name_value'


def test_run_offline_user_data_job_flattened_error():
    client = OfflineUserDataJobServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.run_offline_user_data_job(
            offline_user_data_job_service.RunOfflineUserDataJobRequest(),
            resource_name='resource_name_value',
        )


def test_credentials_transport_error():
    # It is an error to provide credentials and a transport instance.
    transport = transports.OfflineUserDataJobServiceGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = OfflineUserDataJobServiceClient(
            credentials=ga_credentials.AnonymousCredentials(),
            transport=transport,
        )


def test_transport_instance():
    # A client may be instantiated with a custom transport instance.
    transport = transports.OfflineUserDataJobServiceGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    client = OfflineUserDataJobServiceClient(transport=transport)
    assert client.transport is transport


def test_transport_get_channel():
    # A client may be instantiated with a custom transport instance.
    transport = transports.OfflineUserDataJobServiceGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    channel = transport.grpc_channel
    assert channel


def test_transport_grpc_default():
    # A client should use the gRPC transport by default.
    client = OfflineUserDataJobServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    assert isinstance(
        client.transport,
        transports.OfflineUserDataJobServiceGrpcTransport,
    )

@pytest.mark.parametrize("transport_class", [
    transports.OfflineUserDataJobServiceGrpcTransport,
])
def test_transport_adc(transport_class):
    # Test default credentials are used if not provided.
    with mock.patch.object(google.auth, 'default') as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport_class()
        adc.assert_called_once()


def test_offline_user_data_job_service_base_transport():
    # Instantiate the base transport.
    with mock.patch('google.ads.googleads.v7.services.services.offline_user_data_job_service.transports.OfflineUserDataJobServiceTransport.__init__') as Transport:
        Transport.return_value = None
        transport = transports.OfflineUserDataJobServiceTransport(
            credentials=ga_credentials.AnonymousCredentials(),
        )

    # Every method on the transport should just blindly
    # raise NotImplementedError.
    methods = (
        'create_offline_user_data_job',
        'get_offline_user_data_job',
        'add_offline_user_data_job_operations',
        'run_offline_user_data_job',
    )
    for method in methods:
        with pytest.raises(NotImplementedError):
            getattr(transport, method)(request=object())

    with pytest.raises(NotImplementedError):
        transport.close()

    # Additionally, the LRO client (a property) should
    # also raise NotImplementedError
    with pytest.raises(NotImplementedError):
        transport.operations_client


def test_offline_user_data_job_service_base_transport_with_adc():
    # Test the default credentials are used if credentials and credentials_file are None.
    with mock.patch.object(google.auth, 'default') as adc, mock.patch('google.ads.googleads.v7.services.services.offline_user_data_job_service.transports.OfflineUserDataJobServiceTransport._prep_wrapped_messages') as Transport:
        Transport.return_value = None
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport = transports.OfflineUserDataJobServiceTransport()
        adc.assert_called_once()


def test_offline_user_data_job_service_auth_adc():
    # If no credentials are provided, we should use ADC credentials.
    with mock.patch.object(google.auth, 'default') as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        OfflineUserDataJobServiceClient()
        adc.assert_called_once_with(scopes=(
            'https://www.googleapis.com/auth/adwords',
        ))


def test_offline_user_data_job_service_transport_auth_adc():
    # If credentials and host are not provided, the transport class should use
    # ADC credentials.
    with mock.patch.object(google.auth, 'default') as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        transports.OfflineUserDataJobServiceGrpcTransport(host="squid.clam.whelk")
        adc.assert_called_once_with(scopes=(
            'https://www.googleapis.com/auth/adwords',
        ))


def test_offline_user_data_job_service_host_no_port():
    client = OfflineUserDataJobServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        client_options=client_options.ClientOptions(api_endpoint='googleads.googleapis.com'),
    )
    assert client.transport._host == 'googleads.googleapis.com:443'


def test_offline_user_data_job_service_host_with_port():
    client = OfflineUserDataJobServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        client_options=client_options.ClientOptions(api_endpoint='googleads.googleapis.com:8000'),
    )
    assert client.transport._host == 'googleads.googleapis.com:8000'


def test_offline_user_data_job_service_grpc_transport_channel():
    channel = grpc.insecure_channel('http://localhost/')

    # Check that channel is used if provided.
    transport = transports.OfflineUserDataJobServiceGrpcTransport(
        host="squid.clam.whelk",
        channel=channel,
    )
    assert transport.grpc_channel == channel
    assert transport._host == "squid.clam.whelk:443"
    assert transport._ssl_channel_credentials == None


@pytest.mark.parametrize("transport_class", [transports.OfflineUserDataJobServiceGrpcTransport])
def test_offline_user_data_job_service_transport_channel_mtls_with_client_cert_source(
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


@pytest.mark.parametrize("transport_class", [transports.OfflineUserDataJobServiceGrpcTransport,])
def test_offline_user_data_job_service_transport_channel_mtls_with_adc(
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


def test_offline_user_data_job_service_grpc_lro_client():
    client = OfflineUserDataJobServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
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


def test_offline_user_data_job_path():
    customer_id = "squid"
    offline_user_data_update_id = "clam"
    expected = "customers/{customer_id}/offlineUserDataJobs/{offline_user_data_update_id}".format(customer_id=customer_id, offline_user_data_update_id=offline_user_data_update_id, )
    actual = OfflineUserDataJobServiceClient.offline_user_data_job_path(customer_id, offline_user_data_update_id)
    assert expected == actual


def test_parse_offline_user_data_job_path():
    expected = {
        "customer_id": "whelk",
        "offline_user_data_update_id": "octopus",
    }
    path = OfflineUserDataJobServiceClient.offline_user_data_job_path(**expected)

    # Check that the path construction is reversible.
    actual = OfflineUserDataJobServiceClient.parse_offline_user_data_job_path(path)
    assert expected == actual

def test_common_billing_account_path():
    billing_account = "oyster"
    expected = "billingAccounts/{billing_account}".format(billing_account=billing_account, )
    actual = OfflineUserDataJobServiceClient.common_billing_account_path(billing_account)
    assert expected == actual


def test_parse_common_billing_account_path():
    expected = {
        "billing_account": "nudibranch",
    }
    path = OfflineUserDataJobServiceClient.common_billing_account_path(**expected)

    # Check that the path construction is reversible.
    actual = OfflineUserDataJobServiceClient.parse_common_billing_account_path(path)
    assert expected == actual

def test_common_folder_path():
    folder = "cuttlefish"
    expected = "folders/{folder}".format(folder=folder, )
    actual = OfflineUserDataJobServiceClient.common_folder_path(folder)
    assert expected == actual


def test_parse_common_folder_path():
    expected = {
        "folder": "mussel",
    }
    path = OfflineUserDataJobServiceClient.common_folder_path(**expected)

    # Check that the path construction is reversible.
    actual = OfflineUserDataJobServiceClient.parse_common_folder_path(path)
    assert expected == actual

def test_common_organization_path():
    organization = "winkle"
    expected = "organizations/{organization}".format(organization=organization, )
    actual = OfflineUserDataJobServiceClient.common_organization_path(organization)
    assert expected == actual


def test_parse_common_organization_path():
    expected = {
        "organization": "nautilus",
    }
    path = OfflineUserDataJobServiceClient.common_organization_path(**expected)

    # Check that the path construction is reversible.
    actual = OfflineUserDataJobServiceClient.parse_common_organization_path(path)
    assert expected == actual

def test_common_project_path():
    project = "scallop"
    expected = "projects/{project}".format(project=project, )
    actual = OfflineUserDataJobServiceClient.common_project_path(project)
    assert expected == actual


def test_parse_common_project_path():
    expected = {
        "project": "abalone",
    }
    path = OfflineUserDataJobServiceClient.common_project_path(**expected)

    # Check that the path construction is reversible.
    actual = OfflineUserDataJobServiceClient.parse_common_project_path(path)
    assert expected == actual

def test_common_location_path():
    project = "squid"
    location = "clam"
    expected = "projects/{project}/locations/{location}".format(project=project, location=location, )
    actual = OfflineUserDataJobServiceClient.common_location_path(project, location)
    assert expected == actual


def test_parse_common_location_path():
    expected = {
        "project": "whelk",
        "location": "octopus",
    }
    path = OfflineUserDataJobServiceClient.common_location_path(**expected)

    # Check that the path construction is reversible.
    actual = OfflineUserDataJobServiceClient.parse_common_location_path(path)
    assert expected == actual


def test_client_withDEFAULT_CLIENT_INFO():
    client_info = gapic_v1.client_info.ClientInfo()

    with mock.patch.object(transports.OfflineUserDataJobServiceTransport, '_prep_wrapped_messages') as prep:
        client = OfflineUserDataJobServiceClient(
            credentials=ga_credentials.AnonymousCredentials(),
            client_info=client_info,
        )
        prep.assert_called_once_with(client_info)

    with mock.patch.object(transports.OfflineUserDataJobServiceTransport, '_prep_wrapped_messages') as prep:
        transport_class = OfflineUserDataJobServiceClient.get_transport_class()
        transport = transport_class(
            credentials=ga_credentials.AnonymousCredentials(),
            client_info=client_info,
        )
        prep.assert_called_once_with(client_info)

def test_grpc_transport_close():
    client = OfflineUserDataJobServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )
    with mock.patch.object(type(client.transport._grpc_channel), 'close') as chan_close:
        with client as _:
            chan_close.assert_not_called()
        chan_close.assert_called_once()

def test_grpc_client_ctx():
    client = OfflineUserDataJobServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )
    # Test client calls underlying transport.
    with mock.patch.object(type(client.transport), "close") as close:
        close.assert_not_called()
        with client as _:
            pass
        close.assert_called()
