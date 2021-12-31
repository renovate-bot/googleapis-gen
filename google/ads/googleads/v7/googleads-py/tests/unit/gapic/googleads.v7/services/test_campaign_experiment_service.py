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


from google.ads.googleads.v7.enums.types import campaign_experiment_status
from google.ads.googleads.v7.enums.types import campaign_experiment_traffic_split_type
from google.ads.googleads.v7.enums.types import response_content_type
from google.ads.googleads.v7.resources.types import campaign_experiment
from google.ads.googleads.v7.resources.types import campaign_experiment as gagr_campaign_experiment
from google.ads.googleads.v7.services.services.campaign_experiment_service import CampaignExperimentServiceClient
from google.ads.googleads.v7.services.services.campaign_experiment_service import pagers
from google.ads.googleads.v7.services.services.campaign_experiment_service import transports
from google.ads.googleads.v7.services.types import campaign_experiment_service
from google.api_core import client_options
from google.api_core import exceptions as core_exceptions
from google.api_core import future
from google.api_core import gapic_v1
from google.api_core import grpc_helpers
from google.api_core import operation_async  # type: ignore
from google.api_core import operations_v1
from google.api_core import path_template
from google.auth import credentials as ga_credentials
from google.auth.exceptions import MutualTLSChannelError
from google.longrunning import operations_pb2
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

    assert CampaignExperimentServiceClient._get_default_mtls_endpoint(None) is None
    assert CampaignExperimentServiceClient._get_default_mtls_endpoint(api_endpoint) == api_mtls_endpoint
    assert CampaignExperimentServiceClient._get_default_mtls_endpoint(api_mtls_endpoint) == api_mtls_endpoint
    assert CampaignExperimentServiceClient._get_default_mtls_endpoint(sandbox_endpoint) == sandbox_mtls_endpoint
    assert CampaignExperimentServiceClient._get_default_mtls_endpoint(sandbox_mtls_endpoint) == sandbox_mtls_endpoint
    assert CampaignExperimentServiceClient._get_default_mtls_endpoint(non_googleapi) == non_googleapi


@pytest.mark.parametrize("client_class", [
    CampaignExperimentServiceClient,
])
def test_campaign_experiment_service_client_from_service_account_info(client_class):
    creds = ga_credentials.AnonymousCredentials()
    with mock.patch.object(service_account.Credentials, 'from_service_account_info') as factory:
        factory.return_value = creds
        info = {"valid": True}
        client = client_class.from_service_account_info(info)
        assert client.transport._credentials == creds
        assert isinstance(client, client_class)

        assert client.transport._host == 'googleads.googleapis.com:443'


@pytest.mark.parametrize("transport_class,transport_name", [
    (transports.CampaignExperimentServiceGrpcTransport, "grpc"),
])
def test_campaign_experiment_service_client_service_account_always_use_jwt(transport_class, transport_name):
    with mock.patch.object(service_account.Credentials, 'with_always_use_jwt_access', create=True) as use_jwt:
        creds = service_account.Credentials(None, None, None)
        transport = transport_class(credentials=creds, always_use_jwt_access=True)
        use_jwt.assert_called_once_with(True)

    with mock.patch.object(service_account.Credentials, 'with_always_use_jwt_access', create=True) as use_jwt:
        creds = service_account.Credentials(None, None, None)
        transport = transport_class(credentials=creds, always_use_jwt_access=False)
        use_jwt.assert_not_called()


@pytest.mark.parametrize("client_class", [
    CampaignExperimentServiceClient,
])
def test_campaign_experiment_service_client_from_service_account_file(client_class):
    creds = ga_credentials.AnonymousCredentials()
    with mock.patch.object(service_account.Credentials, 'from_service_account_file') as factory:
        factory.return_value = creds
        client = client_class.from_service_account_file("dummy/file/path.json")
        assert client.transport._credentials == creds
        assert isinstance(client, client_class)

        client = client_class.from_service_account_json("dummy/file/path.json")
        assert client.transport._credentials == creds
        assert isinstance(client, client_class)

        assert client.transport._host == 'googleads.googleapis.com:443'


def test_campaign_experiment_service_client_get_transport_class():
    transport = CampaignExperimentServiceClient.get_transport_class()
    available_transports = [
        transports.CampaignExperimentServiceGrpcTransport,
    ]
    assert transport in available_transports

    transport = CampaignExperimentServiceClient.get_transport_class("grpc")
    assert transport == transports.CampaignExperimentServiceGrpcTransport


@pytest.mark.parametrize("client_class,transport_class,transport_name", [
    (CampaignExperimentServiceClient, transports.CampaignExperimentServiceGrpcTransport, "grpc"),
])
@mock.patch.object(CampaignExperimentServiceClient, "DEFAULT_ENDPOINT", modify_default_endpoint(CampaignExperimentServiceClient))
def test_campaign_experiment_service_client_client_options(client_class, transport_class, transport_name):
    # Check that if channel is provided we won't create a new one.
    with mock.patch.object(CampaignExperimentServiceClient, 'get_transport_class') as gtc:
        transport = transport_class(
            credentials=ga_credentials.AnonymousCredentials()
        )
        client = client_class(transport=transport)
        gtc.assert_not_called()

    # Check that if channel is provided via str we will create a new one.
    with mock.patch.object(CampaignExperimentServiceClient, 'get_transport_class') as gtc:
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
            client = client_class(transport=transport_name)

    # Check the case GOOGLE_API_USE_CLIENT_CERTIFICATE has unsupported value.
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_CLIENT_CERTIFICATE": "Unsupported"}):
        with pytest.raises(ValueError):
            client = client_class(transport=transport_name)

    # Check the case quota_project_id is provided
    options = client_options.ClientOptions(quota_project_id="octopus")
    with mock.patch.object(transport_class, '__init__') as patched:
        patched.return_value = None
        client = client_class(client_options=options, transport=transport_name)
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
    (CampaignExperimentServiceClient, transports.CampaignExperimentServiceGrpcTransport, "grpc", "true"),
    (CampaignExperimentServiceClient, transports.CampaignExperimentServiceGrpcTransport, "grpc", "false"),
])
@mock.patch.object(CampaignExperimentServiceClient, "DEFAULT_ENDPOINT", modify_default_endpoint(CampaignExperimentServiceClient))
@mock.patch.dict(os.environ, {"GOOGLE_API_USE_MTLS_ENDPOINT": "auto"})
def test_campaign_experiment_service_client_mtls_env_auto(client_class, transport_class, transport_name, use_client_cert_env):
    # This tests the endpoint autoswitch behavior. Endpoint is autoswitched to the default
    # mtls endpoint, if GOOGLE_API_USE_CLIENT_CERTIFICATE is "true" and client cert exists.

    # Check the case client_cert_source is provided. Whether client cert is used depends on
    # GOOGLE_API_USE_CLIENT_CERTIFICATE value.
    with mock.patch.dict(os.environ, {"GOOGLE_API_USE_CLIENT_CERTIFICATE": use_client_cert_env}):
        options = client_options.ClientOptions(client_cert_source=client_cert_source_callback)
        with mock.patch.object(transport_class, '__init__') as patched:
            patched.return_value = None
            client = client_class(client_options=options, transport=transport_name)

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
    (CampaignExperimentServiceClient, transports.CampaignExperimentServiceGrpcTransport, "grpc"),
])
def test_campaign_experiment_service_client_client_options_scopes(client_class, transport_class, transport_name):
    # Check the case scopes are provided.
    options = client_options.ClientOptions(
        scopes=["1", "2"],
    )
    with mock.patch.object(transport_class, '__init__') as patched:
        patched.return_value = None
        client = client_class(client_options=options, transport=transport_name)
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
    (CampaignExperimentServiceClient, transports.CampaignExperimentServiceGrpcTransport, "grpc"),
])
def test_campaign_experiment_service_client_client_options_credentials_file(client_class, transport_class, transport_name):
    # Check the case credentials file is provided.
    options = client_options.ClientOptions(
        credentials_file="credentials.json"
    )
    with mock.patch.object(transport_class, '__init__') as patched:
        patched.return_value = None
        client = client_class(client_options=options, transport=transport_name)
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

def test_campaign_experiment_service_client_client_options_from_dict():
    with mock.patch('google.ads.googleads.v7.services.services.campaign_experiment_service.transports.CampaignExperimentServiceGrpcTransport.__init__') as grpc_transport:
        grpc_transport.return_value = None
        client = CampaignExperimentServiceClient(
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


@pytest.mark.parametrize("request_type", [
  campaign_experiment_service.GetCampaignExperimentRequest,
  dict,
])
def test_get_campaign_experiment(request_type, transport: str = 'grpc'):
    client = CampaignExperimentServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_campaign_experiment),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = campaign_experiment.CampaignExperiment(
            resource_name='resource_name_value',
            id=205,
            campaign_draft='campaign_draft_value',
            name='name_value',
            description='description_value',
            traffic_split_percent=2234,
            traffic_split_type=campaign_experiment_traffic_split_type.CampaignExperimentTrafficSplitTypeEnum.CampaignExperimentTrafficSplitType.UNKNOWN,
            experiment_campaign='experiment_campaign_value',
            status=campaign_experiment_status.CampaignExperimentStatusEnum.CampaignExperimentStatus.UNKNOWN,
            long_running_operation='long_running_operation_value',
            start_date='start_date_value',
            end_date='end_date_value',
        )
        response = client.get_campaign_experiment(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == campaign_experiment_service.GetCampaignExperimentRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, campaign_experiment.CampaignExperiment)
    assert response.resource_name == 'resource_name_value'
    assert response.id == 205
    assert response.campaign_draft == 'campaign_draft_value'
    assert response.name == 'name_value'
    assert response.description == 'description_value'
    assert response.traffic_split_percent == 2234
    assert response.traffic_split_type == campaign_experiment_traffic_split_type.CampaignExperimentTrafficSplitTypeEnum.CampaignExperimentTrafficSplitType.UNKNOWN
    assert response.experiment_campaign == 'experiment_campaign_value'
    assert response.status == campaign_experiment_status.CampaignExperimentStatusEnum.CampaignExperimentStatus.UNKNOWN
    assert response.long_running_operation == 'long_running_operation_value'
    assert response.start_date == 'start_date_value'
    assert response.end_date == 'end_date_value'


def test_get_campaign_experiment_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = CampaignExperimentServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_campaign_experiment),
            '__call__') as call:
        client.get_campaign_experiment()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == campaign_experiment_service.GetCampaignExperimentRequest()


def test_get_campaign_experiment_field_headers():
    client = CampaignExperimentServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = campaign_experiment_service.GetCampaignExperimentRequest()

    request.resource_name = 'resource_name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_campaign_experiment),
            '__call__') as call:
        call.return_value = campaign_experiment.CampaignExperiment()
        client.get_campaign_experiment(request)

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


def test_get_campaign_experiment_flattened():
    client = CampaignExperimentServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.get_campaign_experiment),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = campaign_experiment.CampaignExperiment()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.get_campaign_experiment(
            resource_name='resource_name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].resource_name
        mock_val = 'resource_name_value'
        assert arg == mock_val


def test_get_campaign_experiment_flattened_error():
    client = CampaignExperimentServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.get_campaign_experiment(
            campaign_experiment_service.GetCampaignExperimentRequest(),
            resource_name='resource_name_value',
        )


@pytest.mark.parametrize("request_type", [
  campaign_experiment_service.CreateCampaignExperimentRequest,
  dict,
])
def test_create_campaign_experiment(request_type, transport: str = 'grpc'):
    client = CampaignExperimentServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_campaign_experiment),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/spam')
        response = client.create_campaign_experiment(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == campaign_experiment_service.CreateCampaignExperimentRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


def test_create_campaign_experiment_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = CampaignExperimentServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_campaign_experiment),
            '__call__') as call:
        client.create_campaign_experiment()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == campaign_experiment_service.CreateCampaignExperimentRequest()


def test_create_campaign_experiment_field_headers():
    client = CampaignExperimentServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = campaign_experiment_service.CreateCampaignExperimentRequest()

    request.customer_id = 'customer_id/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_campaign_experiment),
            '__call__') as call:
        call.return_value = operations_pb2.Operation(name='operations/op')
        client.create_campaign_experiment(request)

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


def test_create_campaign_experiment_flattened():
    client = CampaignExperimentServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.create_campaign_experiment),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/op')
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.create_campaign_experiment(
            customer_id='customer_id_value',
            campaign_experiment=gagr_campaign_experiment.CampaignExperiment(resource_name='resource_name_value'),
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].customer_id
        mock_val = 'customer_id_value'
        assert arg == mock_val
        arg = args[0].campaign_experiment
        mock_val = gagr_campaign_experiment.CampaignExperiment(resource_name='resource_name_value')
        assert arg == mock_val


def test_create_campaign_experiment_flattened_error():
    client = CampaignExperimentServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.create_campaign_experiment(
            campaign_experiment_service.CreateCampaignExperimentRequest(),
            customer_id='customer_id_value',
            campaign_experiment=gagr_campaign_experiment.CampaignExperiment(resource_name='resource_name_value'),
        )


@pytest.mark.parametrize("request_type", [
  campaign_experiment_service.MutateCampaignExperimentsRequest,
  dict,
])
def test_mutate_campaign_experiments(request_type, transport: str = 'grpc'):
    client = CampaignExperimentServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.mutate_campaign_experiments),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = campaign_experiment_service.MutateCampaignExperimentsResponse(
        )
        response = client.mutate_campaign_experiments(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == campaign_experiment_service.MutateCampaignExperimentsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, campaign_experiment_service.MutateCampaignExperimentsResponse)


def test_mutate_campaign_experiments_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = CampaignExperimentServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.mutate_campaign_experiments),
            '__call__') as call:
        client.mutate_campaign_experiments()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == campaign_experiment_service.MutateCampaignExperimentsRequest()


def test_mutate_campaign_experiments_field_headers():
    client = CampaignExperimentServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = campaign_experiment_service.MutateCampaignExperimentsRequest()

    request.customer_id = 'customer_id/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.mutate_campaign_experiments),
            '__call__') as call:
        call.return_value = campaign_experiment_service.MutateCampaignExperimentsResponse()
        client.mutate_campaign_experiments(request)

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


def test_mutate_campaign_experiments_flattened():
    client = CampaignExperimentServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.mutate_campaign_experiments),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = campaign_experiment_service.MutateCampaignExperimentsResponse()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.mutate_campaign_experiments(
            customer_id='customer_id_value',
            operations=[campaign_experiment_service.CampaignExperimentOperation(update_mask=field_mask_pb2.FieldMask(paths=['paths_value']))],
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].customer_id
        mock_val = 'customer_id_value'
        assert arg == mock_val
        arg = args[0].operations
        mock_val = [campaign_experiment_service.CampaignExperimentOperation(update_mask=field_mask_pb2.FieldMask(paths=['paths_value']))]
        assert arg == mock_val


def test_mutate_campaign_experiments_flattened_error():
    client = CampaignExperimentServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.mutate_campaign_experiments(
            campaign_experiment_service.MutateCampaignExperimentsRequest(),
            customer_id='customer_id_value',
            operations=[campaign_experiment_service.CampaignExperimentOperation(update_mask=field_mask_pb2.FieldMask(paths=['paths_value']))],
        )


@pytest.mark.parametrize("request_type", [
  campaign_experiment_service.GraduateCampaignExperimentRequest,
  dict,
])
def test_graduate_campaign_experiment(request_type, transport: str = 'grpc'):
    client = CampaignExperimentServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.graduate_campaign_experiment),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = campaign_experiment_service.GraduateCampaignExperimentResponse(
            graduated_campaign='graduated_campaign_value',
        )
        response = client.graduate_campaign_experiment(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == campaign_experiment_service.GraduateCampaignExperimentRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, campaign_experiment_service.GraduateCampaignExperimentResponse)
    assert response.graduated_campaign == 'graduated_campaign_value'


def test_graduate_campaign_experiment_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = CampaignExperimentServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.graduate_campaign_experiment),
            '__call__') as call:
        client.graduate_campaign_experiment()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == campaign_experiment_service.GraduateCampaignExperimentRequest()


def test_graduate_campaign_experiment_field_headers():
    client = CampaignExperimentServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = campaign_experiment_service.GraduateCampaignExperimentRequest()

    request.campaign_experiment = 'campaign_experiment/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.graduate_campaign_experiment),
            '__call__') as call:
        call.return_value = campaign_experiment_service.GraduateCampaignExperimentResponse()
        client.graduate_campaign_experiment(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'campaign_experiment=campaign_experiment/value',
    ) in kw['metadata']


def test_graduate_campaign_experiment_flattened():
    client = CampaignExperimentServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.graduate_campaign_experiment),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = campaign_experiment_service.GraduateCampaignExperimentResponse()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.graduate_campaign_experiment(
            campaign_experiment='campaign_experiment_value',
            campaign_budget='campaign_budget_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].campaign_experiment
        mock_val = 'campaign_experiment_value'
        assert arg == mock_val
        arg = args[0].campaign_budget
        mock_val = 'campaign_budget_value'
        assert arg == mock_val


def test_graduate_campaign_experiment_flattened_error():
    client = CampaignExperimentServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.graduate_campaign_experiment(
            campaign_experiment_service.GraduateCampaignExperimentRequest(),
            campaign_experiment='campaign_experiment_value',
            campaign_budget='campaign_budget_value',
        )


@pytest.mark.parametrize("request_type", [
  campaign_experiment_service.PromoteCampaignExperimentRequest,
  dict,
])
def test_promote_campaign_experiment(request_type, transport: str = 'grpc'):
    client = CampaignExperimentServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.promote_campaign_experiment),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/spam')
        response = client.promote_campaign_experiment(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == campaign_experiment_service.PromoteCampaignExperimentRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, future.Future)


def test_promote_campaign_experiment_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = CampaignExperimentServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.promote_campaign_experiment),
            '__call__') as call:
        client.promote_campaign_experiment()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == campaign_experiment_service.PromoteCampaignExperimentRequest()


def test_promote_campaign_experiment_field_headers():
    client = CampaignExperimentServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = campaign_experiment_service.PromoteCampaignExperimentRequest()

    request.campaign_experiment = 'campaign_experiment/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.promote_campaign_experiment),
            '__call__') as call:
        call.return_value = operations_pb2.Operation(name='operations/op')
        client.promote_campaign_experiment(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'campaign_experiment=campaign_experiment/value',
    ) in kw['metadata']


def test_promote_campaign_experiment_flattened():
    client = CampaignExperimentServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.promote_campaign_experiment),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = operations_pb2.Operation(name='operations/op')
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.promote_campaign_experiment(
            campaign_experiment='campaign_experiment_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].campaign_experiment
        mock_val = 'campaign_experiment_value'
        assert arg == mock_val


def test_promote_campaign_experiment_flattened_error():
    client = CampaignExperimentServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.promote_campaign_experiment(
            campaign_experiment_service.PromoteCampaignExperimentRequest(),
            campaign_experiment='campaign_experiment_value',
        )


@pytest.mark.parametrize("request_type", [
  campaign_experiment_service.EndCampaignExperimentRequest,
  dict,
])
def test_end_campaign_experiment(request_type, transport: str = 'grpc'):
    client = CampaignExperimentServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.end_campaign_experiment),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = None
        response = client.end_campaign_experiment(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == campaign_experiment_service.EndCampaignExperimentRequest()

    # Establish that the response is the type that we expect.
    assert response is None


def test_end_campaign_experiment_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = CampaignExperimentServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.end_campaign_experiment),
            '__call__') as call:
        client.end_campaign_experiment()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == campaign_experiment_service.EndCampaignExperimentRequest()


def test_end_campaign_experiment_field_headers():
    client = CampaignExperimentServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = campaign_experiment_service.EndCampaignExperimentRequest()

    request.campaign_experiment = 'campaign_experiment/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.end_campaign_experiment),
            '__call__') as call:
        call.return_value = None
        client.end_campaign_experiment(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == request

    # Establish that the field header was sent.
    _, _, kw = call.mock_calls[0]
    assert (
        'x-goog-request-params',
        'campaign_experiment=campaign_experiment/value',
    ) in kw['metadata']


def test_end_campaign_experiment_flattened():
    client = CampaignExperimentServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.end_campaign_experiment),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = None
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.end_campaign_experiment(
            campaign_experiment='campaign_experiment_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].campaign_experiment
        mock_val = 'campaign_experiment_value'
        assert arg == mock_val


def test_end_campaign_experiment_flattened_error():
    client = CampaignExperimentServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.end_campaign_experiment(
            campaign_experiment_service.EndCampaignExperimentRequest(),
            campaign_experiment='campaign_experiment_value',
        )


@pytest.mark.parametrize("request_type", [
  campaign_experiment_service.ListCampaignExperimentAsyncErrorsRequest,
  dict,
])
def test_list_campaign_experiment_async_errors(request_type, transport: str = 'grpc'):
    client = CampaignExperimentServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport=transport,
    )

    # Everything is optional in proto3 as far as the runtime is concerned,
    # and we are mocking out the actual API, so just send an empty request.
    request = request_type()

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_campaign_experiment_async_errors),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = campaign_experiment_service.ListCampaignExperimentAsyncErrorsResponse(
            next_page_token='next_page_token_value',
        )
        response = client.list_campaign_experiment_async_errors(request)

        # Establish that the underlying gRPC stub method was called.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        assert args[0] == campaign_experiment_service.ListCampaignExperimentAsyncErrorsRequest()

    # Establish that the response is the type that we expect.
    assert isinstance(response, pagers.ListCampaignExperimentAsyncErrorsPager)
    assert response.next_page_token == 'next_page_token_value'


def test_list_campaign_experiment_async_errors_empty_call():
    # This test is a coverage failsafe to make sure that totally empty calls,
    # i.e. request == None and no flattened fields passed, work.
    client = CampaignExperimentServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        transport='grpc',
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_campaign_experiment_async_errors),
            '__call__') as call:
        client.list_campaign_experiment_async_errors()
        call.assert_called()
        _, args, _ = call.mock_calls[0]
        assert args[0] == campaign_experiment_service.ListCampaignExperimentAsyncErrorsRequest()


def test_list_campaign_experiment_async_errors_field_headers():
    client = CampaignExperimentServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Any value that is part of the HTTP/1.1 URI should be sent as
    # a field header. Set these to a non-empty value.
    request = campaign_experiment_service.ListCampaignExperimentAsyncErrorsRequest()

    request.resource_name = 'resource_name/value'

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_campaign_experiment_async_errors),
            '__call__') as call:
        call.return_value = campaign_experiment_service.ListCampaignExperimentAsyncErrorsResponse()
        client.list_campaign_experiment_async_errors(request)

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


def test_list_campaign_experiment_async_errors_flattened():
    client = CampaignExperimentServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_campaign_experiment_async_errors),
            '__call__') as call:
        # Designate an appropriate return value for the call.
        call.return_value = campaign_experiment_service.ListCampaignExperimentAsyncErrorsResponse()
        # Call the method with a truthy value for each flattened field,
        # using the keyword arguments to the method.
        client.list_campaign_experiment_async_errors(
            resource_name='resource_name_value',
        )

        # Establish that the underlying call was made with the expected
        # request object values.
        assert len(call.mock_calls) == 1
        _, args, _ = call.mock_calls[0]
        arg = args[0].resource_name
        mock_val = 'resource_name_value'
        assert arg == mock_val


def test_list_campaign_experiment_async_errors_flattened_error():
    client = CampaignExperimentServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )

    # Attempting to call a method with both a request object and flattened
    # fields is an error.
    with pytest.raises(ValueError):
        client.list_campaign_experiment_async_errors(
            campaign_experiment_service.ListCampaignExperimentAsyncErrorsRequest(),
            resource_name='resource_name_value',
        )


def test_list_campaign_experiment_async_errors_pager(transport_name: str = "grpc"):
    client = CampaignExperimentServiceClient(
        credentials=ga_credentials.AnonymousCredentials,
        transport=transport_name,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
            type(client.transport.list_campaign_experiment_async_errors),
            '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            campaign_experiment_service.ListCampaignExperimentAsyncErrorsResponse(
                errors=[
                    status_pb2.Status(),
                    status_pb2.Status(),
                    status_pb2.Status(),
                ],
                next_page_token='abc',
            ),
            campaign_experiment_service.ListCampaignExperimentAsyncErrorsResponse(
                errors=[],
                next_page_token='def',
            ),
            campaign_experiment_service.ListCampaignExperimentAsyncErrorsResponse(
                errors=[
                    status_pb2.Status(),
                ],
                next_page_token='ghi',
            ),
            campaign_experiment_service.ListCampaignExperimentAsyncErrorsResponse(
                errors=[
                    status_pb2.Status(),
                    status_pb2.Status(),
                ],
            ),
            RuntimeError,
        )

        metadata = ()
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ('resource_name', ''),
            )),
        )
        pager = client.list_campaign_experiment_async_errors(request={})

        assert pager._metadata == metadata

        results = [i for i in pager]
        assert len(results) == 6
        assert all(isinstance(i, status_pb2.Status)
                   for i in results)


def test_list_campaign_experiment_async_errors_pages(transport_name: str = "grpc"):
    client = CampaignExperimentServiceClient(
        credentials=ga_credentials.AnonymousCredentials,
        transport=transport_name,
    )

    # Mock the actual call within the gRPC stub, and fake the request.
    with mock.patch.object(
         type(client.transport.list_campaign_experiment_async_errors),
        '__call__') as call:
        # Set the response to a series of pages.
        call.side_effect = (
            campaign_experiment_service.ListCampaignExperimentAsyncErrorsResponse(
                errors=[
                    status_pb2.Status(),
                    status_pb2.Status(),
                    status_pb2.Status(),
                ],
                next_page_token='abc',
            ),
            campaign_experiment_service.ListCampaignExperimentAsyncErrorsResponse(
                errors=[],
                next_page_token='def',
            ),
            campaign_experiment_service.ListCampaignExperimentAsyncErrorsResponse(
                errors=[
                    status_pb2.Status(),
                ],
                next_page_token='ghi',
            ),
            campaign_experiment_service.ListCampaignExperimentAsyncErrorsResponse(
                errors=[
                    status_pb2.Status(),
                    status_pb2.Status(),
                ],
            ),
            RuntimeError,
        )
        pages = list(client.list_campaign_experiment_async_errors(request={}).pages)
        for page_, token in zip(pages, ['abc','def','ghi', '']):
            assert page_.raw_page.next_page_token == token


def test_credentials_transport_error():
    # It is an error to provide credentials and a transport instance.
    transport = transports.CampaignExperimentServiceGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = CampaignExperimentServiceClient(
            credentials=ga_credentials.AnonymousCredentials(),
            transport=transport,
        )

    # It is an error to provide a credentials file and a transport instance.
    transport = transports.CampaignExperimentServiceGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = CampaignExperimentServiceClient(
            client_options={"credentials_file": "credentials.json"},
            transport=transport,
        )

    # It is an error to provide scopes and a transport instance.
    transport = transports.CampaignExperimentServiceGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    with pytest.raises(ValueError):
        client = CampaignExperimentServiceClient(
            client_options={"scopes": ["1", "2"]},
            transport=transport,
        )


def test_transport_instance():
    # A client may be instantiated with a custom transport instance.
    transport = transports.CampaignExperimentServiceGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    client = CampaignExperimentServiceClient(transport=transport)
    assert client.transport is transport

def test_transport_get_channel():
    # A client may be instantiated with a custom transport instance.
    transport = transports.CampaignExperimentServiceGrpcTransport(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    channel = transport.grpc_channel
    assert channel


@pytest.mark.parametrize("transport_class", [
    transports.CampaignExperimentServiceGrpcTransport,
])
def test_transport_adc(transport_class):
    # Test default credentials are used if not provided.
    with mock.patch.object(google.auth, 'default') as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport_class()
        adc.assert_called_once()

def test_transport_grpc_default():
    # A client should use the gRPC transport by default.
    client = CampaignExperimentServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
    )
    assert isinstance(
        client.transport,
        transports.CampaignExperimentServiceGrpcTransport,
    )

def test_campaign_experiment_service_base_transport_error():
    # Passing both a credentials object and credentials_file should raise an error
    with pytest.raises(core_exceptions.DuplicateCredentialArgs):
        transport = transports.CampaignExperimentServiceTransport(
            credentials=ga_credentials.AnonymousCredentials(),
            credentials_file="credentials.json"
        )


def test_campaign_experiment_service_base_transport():
    # Instantiate the base transport.
    with mock.patch('google.ads.googleads.v7.services.services.campaign_experiment_service.transports.CampaignExperimentServiceTransport.__init__') as Transport:
        Transport.return_value = None
        transport = transports.CampaignExperimentServiceTransport(
            credentials=ga_credentials.AnonymousCredentials(),
        )

    # Every method on the transport should just blindly
    # raise NotImplementedError.
    methods = (
        'get_campaign_experiment',
        'create_campaign_experiment',
        'mutate_campaign_experiments',
        'graduate_campaign_experiment',
        'promote_campaign_experiment',
        'end_campaign_experiment',
        'list_campaign_experiment_async_errors',
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


def test_campaign_experiment_service_base_transport_with_credentials_file():
    # Instantiate the base transport with a credentials file
    with mock.patch.object(google.auth, 'load_credentials_from_file', autospec=True) as load_creds, mock.patch('google.ads.googleads.v7.services.services.campaign_experiment_service.transports.CampaignExperimentServiceTransport._prep_wrapped_messages') as Transport:
        Transport.return_value = None
        load_creds.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport = transports.CampaignExperimentServiceTransport(
            credentials_file="credentials.json",
            quota_project_id="octopus",
        )
        load_creds.assert_called_once_with("credentials.json",
            scopes=None,
            default_scopes=(
            'https://www.googleapis.com/auth/adwords',
),
            quota_project_id="octopus",
        )


def test_campaign_experiment_service_base_transport_with_adc():
    # Test the default credentials are used if credentials and credentials_file are None.
    with mock.patch.object(google.auth, 'default', autospec=True) as adc, mock.patch('google.ads.googleads.v7.services.services.campaign_experiment_service.transports.CampaignExperimentServiceTransport._prep_wrapped_messages') as Transport:
        Transport.return_value = None
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport = transports.CampaignExperimentServiceTransport()
        adc.assert_called_once()


def test_campaign_experiment_service_auth_adc():
    # If no credentials are provided, we should use ADC credentials.
    with mock.patch.object(google.auth, 'default', autospec=True) as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        CampaignExperimentServiceClient()
        adc.assert_called_once_with(
            scopes=None,
            default_scopes=(
            'https://www.googleapis.com/auth/adwords',
),
            quota_project_id=None,
        )


@pytest.mark.parametrize(
    "transport_class",
    [
        transports.CampaignExperimentServiceGrpcTransport,
    ],
)
def test_campaign_experiment_service_transport_auth_adc(transport_class):
    # If credentials and host are not provided, the transport class should use
    # ADC credentials.
    with mock.patch.object(google.auth, 'default', autospec=True) as adc:
        adc.return_value = (ga_credentials.AnonymousCredentials(), None)
        transport_class(quota_project_id="octopus", scopes=["1", "2"])
        adc.assert_called_once_with(
            scopes=["1", "2"],
            default_scopes=(                'https://www.googleapis.com/auth/adwords',),
            quota_project_id="octopus",
        )


@pytest.mark.parametrize(
    "transport_class,grpc_helpers",
    [
        (transports.CampaignExperimentServiceGrpcTransport, grpc_helpers),
    ],
)
def test_campaign_experiment_service_transport_create_channel(transport_class, grpc_helpers):
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
            "googleads.googleapis.com:443",
            credentials=creds,
            credentials_file=None,
            quota_project_id="octopus",
            default_scopes=(
                'https://www.googleapis.com/auth/adwords',
),
            scopes=["1", "2"],
            default_host="googleads.googleapis.com",
            ssl_credentials=None,
            options=[
                ("grpc.max_send_message_length", -1),
                ("grpc.max_receive_message_length", -1),
            ],
        )


@pytest.mark.parametrize("transport_class",
    [
      transports.CampaignExperimentServiceGrpcTransport,
])
def test_campaign_experiment_service_grpc_transport_client_cert_source_for_mtls(
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


def test_campaign_experiment_service_host_no_port():
    client = CampaignExperimentServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        client_options=client_options.ClientOptions(api_endpoint='googleads.googleapis.com'),
    )
    assert client.transport._host == 'googleads.googleapis.com:443'


def test_campaign_experiment_service_host_with_port():
    client = CampaignExperimentServiceClient(
        credentials=ga_credentials.AnonymousCredentials(),
        client_options=client_options.ClientOptions(api_endpoint='googleads.googleapis.com:8000'),
    )
    assert client.transport._host == 'googleads.googleapis.com:8000'

def test_campaign_experiment_service_grpc_transport_channel():
    channel = grpc.secure_channel('http://localhost/', grpc.local_channel_credentials())

    # Check that channel is used if provided.
    transport = transports.CampaignExperimentServiceGrpcTransport(
        host="squid.clam.whelk",
        channel=channel,
    )
    assert transport.grpc_channel == channel
    assert transport._host == "squid.clam.whelk:443"
    assert transport._ssl_channel_credentials == None


# Remove this test when deprecated arguments (api_mtls_endpoint, client_cert_source) are
# removed from grpc/grpc_asyncio transport constructor.
@pytest.mark.parametrize("transport_class",
    [
      transports.CampaignExperimentServiceGrpcTransport,
    ])
def test_campaign_experiment_service_transport_channel_mtls_with_client_cert_source(
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
@pytest.mark.parametrize("transport_class",
    [
      transports.CampaignExperimentServiceGrpcTransport,
    ])
def test_campaign_experiment_service_transport_channel_mtls_with_adc(
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


def test_campaign_experiment_service_grpc_lro_client():
    client = CampaignExperimentServiceClient(
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


def test_campaign_path():
    customer_id = "squid"
    campaign_id = "clam"
    expected = "customers/{customer_id}/campaigns/{campaign_id}".format(customer_id=customer_id, campaign_id=campaign_id, )
    actual = CampaignExperimentServiceClient.campaign_path(customer_id, campaign_id)
    assert expected == actual


def test_parse_campaign_path():
    expected = {
        "customer_id": "whelk",
        "campaign_id": "octopus",
    }
    path = CampaignExperimentServiceClient.campaign_path(**expected)

    # Check that the path construction is reversible.
    actual = CampaignExperimentServiceClient.parse_campaign_path(path)
    assert expected == actual

def test_campaign_draft_path():
    customer_id = "oyster"
    base_campaign_id = "nudibranch"
    draft_id = "cuttlefish"
    expected = "customers/{customer_id}/campaignDrafts/{base_campaign_id}~{draft_id}".format(customer_id=customer_id, base_campaign_id=base_campaign_id, draft_id=draft_id, )
    actual = CampaignExperimentServiceClient.campaign_draft_path(customer_id, base_campaign_id, draft_id)
    assert expected == actual


def test_parse_campaign_draft_path():
    expected = {
        "customer_id": "mussel",
        "base_campaign_id": "winkle",
        "draft_id": "nautilus",
    }
    path = CampaignExperimentServiceClient.campaign_draft_path(**expected)

    # Check that the path construction is reversible.
    actual = CampaignExperimentServiceClient.parse_campaign_draft_path(path)
    assert expected == actual

def test_campaign_experiment_path():
    customer_id = "scallop"
    campaign_experiment_id = "abalone"
    expected = "customers/{customer_id}/campaignExperiments/{campaign_experiment_id}".format(customer_id=customer_id, campaign_experiment_id=campaign_experiment_id, )
    actual = CampaignExperimentServiceClient.campaign_experiment_path(customer_id, campaign_experiment_id)
    assert expected == actual


def test_parse_campaign_experiment_path():
    expected = {
        "customer_id": "squid",
        "campaign_experiment_id": "clam",
    }
    path = CampaignExperimentServiceClient.campaign_experiment_path(**expected)

    # Check that the path construction is reversible.
    actual = CampaignExperimentServiceClient.parse_campaign_experiment_path(path)
    assert expected == actual

def test_common_billing_account_path():
    billing_account = "whelk"
    expected = "billingAccounts/{billing_account}".format(billing_account=billing_account, )
    actual = CampaignExperimentServiceClient.common_billing_account_path(billing_account)
    assert expected == actual


def test_parse_common_billing_account_path():
    expected = {
        "billing_account": "octopus",
    }
    path = CampaignExperimentServiceClient.common_billing_account_path(**expected)

    # Check that the path construction is reversible.
    actual = CampaignExperimentServiceClient.parse_common_billing_account_path(path)
    assert expected == actual

def test_common_folder_path():
    folder = "oyster"
    expected = "folders/{folder}".format(folder=folder, )
    actual = CampaignExperimentServiceClient.common_folder_path(folder)
    assert expected == actual


def test_parse_common_folder_path():
    expected = {
        "folder": "nudibranch",
    }
    path = CampaignExperimentServiceClient.common_folder_path(**expected)

    # Check that the path construction is reversible.
    actual = CampaignExperimentServiceClient.parse_common_folder_path(path)
    assert expected == actual

def test_common_organization_path():
    organization = "cuttlefish"
    expected = "organizations/{organization}".format(organization=organization, )
    actual = CampaignExperimentServiceClient.common_organization_path(organization)
    assert expected == actual


def test_parse_common_organization_path():
    expected = {
        "organization": "mussel",
    }
    path = CampaignExperimentServiceClient.common_organization_path(**expected)

    # Check that the path construction is reversible.
    actual = CampaignExperimentServiceClient.parse_common_organization_path(path)
    assert expected == actual

def test_common_project_path():
    project = "winkle"
    expected = "projects/{project}".format(project=project, )
    actual = CampaignExperimentServiceClient.common_project_path(project)
    assert expected == actual


def test_parse_common_project_path():
    expected = {
        "project": "nautilus",
    }
    path = CampaignExperimentServiceClient.common_project_path(**expected)

    # Check that the path construction is reversible.
    actual = CampaignExperimentServiceClient.parse_common_project_path(path)
    assert expected == actual

def test_common_location_path():
    project = "scallop"
    location = "abalone"
    expected = "projects/{project}/locations/{location}".format(project=project, location=location, )
    actual = CampaignExperimentServiceClient.common_location_path(project, location)
    assert expected == actual


def test_parse_common_location_path():
    expected = {
        "project": "squid",
        "location": "clam",
    }
    path = CampaignExperimentServiceClient.common_location_path(**expected)

    # Check that the path construction is reversible.
    actual = CampaignExperimentServiceClient.parse_common_location_path(path)
    assert expected == actual


def test_client_with_default_client_info():
    client_info = gapic_v1.client_info.ClientInfo()

    with mock.patch.object(transports.CampaignExperimentServiceTransport, '_prep_wrapped_messages') as prep:
        client = CampaignExperimentServiceClient(
            credentials=ga_credentials.AnonymousCredentials(),
            client_info=client_info,
        )
        prep.assert_called_once_with(client_info)

    with mock.patch.object(transports.CampaignExperimentServiceTransport, '_prep_wrapped_messages') as prep:
        transport_class = CampaignExperimentServiceClient.get_transport_class()
        transport = transport_class(
            credentials=ga_credentials.AnonymousCredentials(),
            client_info=client_info,
        )
        prep.assert_called_once_with(client_info)


def test_transport_close():
    transports = {
        "grpc": "_grpc_channel",
    }

    for transport, close_name in transports.items():
        client = CampaignExperimentServiceClient(
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
        client = CampaignExperimentServiceClient(
            credentials=ga_credentials.AnonymousCredentials(),
            transport=transport
        )
        # Test client calls underlying transport.
        with mock.patch.object(type(client.transport), "close") as close:
            close.assert_not_called()
            with client:
                pass
            close.assert_called()
