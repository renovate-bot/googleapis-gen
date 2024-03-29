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
from collections import OrderedDict
import os
import re
from typing import Callable, Dict, Optional, Sequence, Tuple, Type, Union
import pkg_resources

from google.api_core import client_options as client_options_lib
from google.api_core import exceptions as core_exceptions
from google.api_core import gapic_v1
from google.api_core import retry as retries
from google.auth import credentials as ga_credentials             # type: ignore
from google.auth.transport import mtls                            # type: ignore
from google.auth.transport.grpc import SslCredentials             # type: ignore
from google.auth.exceptions import MutualTLSChannelError          # type: ignore
from google.oauth2 import service_account                         # type: ignore

try:
    OptionalRetry = Union[retries.Retry, gapic_v1.method._MethodDefault]
except AttributeError:  # pragma: NO COVER
    OptionalRetry = Union[retries.Retry, object]  # type: ignore

from google.ads.googleads.v8.enums.types import campaign_experiment_status
from google.ads.googleads.v8.enums.types import campaign_experiment_traffic_split_type
from google.ads.googleads.v8.resources.types import campaign_experiment
from google.ads.googleads.v8.resources.types import campaign_experiment as gagr_campaign_experiment
from google.ads.googleads.v8.services.services.campaign_experiment_service import pagers
from google.ads.googleads.v8.services.types import campaign_experiment_service
from google.api_core import operation  # type: ignore
from google.api_core import operation_async  # type: ignore
from google.protobuf import empty_pb2  # type: ignore
from google.rpc import status_pb2  # type: ignore
from .transports.base import CampaignExperimentServiceTransport, DEFAULT_CLIENT_INFO
from .transports.grpc import CampaignExperimentServiceGrpcTransport


class CampaignExperimentServiceClientMeta(type):
    """Metaclass for the CampaignExperimentService client.

    This provides class-level methods for building and retrieving
    support objects (e.g. transport) without polluting the client instance
    objects.
    """
    _transport_registry = OrderedDict()  # type: Dict[str, Type[CampaignExperimentServiceTransport]]
    _transport_registry['grpc'] = CampaignExperimentServiceGrpcTransport

    def get_transport_class(cls,
            label: str = None,
            ) -> Type[CampaignExperimentServiceTransport]:
        """Returns an appropriate transport class.

        Args:
            label: The name of the desired transport. If none is
                provided, then the first transport in the registry is used.

        Returns:
            The transport class to use.
        """
        # If a specific transport is requested, return that one.
        if label:
            return cls._transport_registry[label]

        # No transport is requested; return the default (that is, the first one
        # in the dictionary).
        return next(iter(cls._transport_registry.values()))


class CampaignExperimentServiceClient(metaclass=CampaignExperimentServiceClientMeta):
    """CampaignExperimentService manages the life cycle of campaign
    experiments. It is used to create new experiments from drafts,
    modify experiment properties, promote changes in an experiment
    back to its base campaign, graduate experiments into new stand-
    alone campaigns, and to remove an experiment.

    An experiment consists of two variants or arms - the base
    campaign and the experiment campaign, directing a fixed share of
    traffic to each arm. A campaign experiment is created from a
    draft of changes to the base campaign and will be a snapshot of
    changes in the draft at the time of creation.
    """

    @staticmethod
    def _get_default_mtls_endpoint(api_endpoint):
        """Converts api endpoint to mTLS endpoint.

        Convert "*.sandbox.googleapis.com" and "*.googleapis.com" to
        "*.mtls.sandbox.googleapis.com" and "*.mtls.googleapis.com" respectively.
        Args:
            api_endpoint (Optional[str]): the api endpoint to convert.
        Returns:
            str: converted mTLS api endpoint.
        """
        if not api_endpoint:
            return api_endpoint

        mtls_endpoint_re = re.compile(
            r"(?P<name>[^.]+)(?P<mtls>\.mtls)?(?P<sandbox>\.sandbox)?(?P<googledomain>\.googleapis\.com)?"
        )

        m = mtls_endpoint_re.match(api_endpoint)
        name, mtls, sandbox, googledomain = m.groups()
        if mtls or not googledomain:
            return api_endpoint

        if sandbox:
            return api_endpoint.replace(
                "sandbox.googleapis.com", "mtls.sandbox.googleapis.com"
            )

        return api_endpoint.replace(".googleapis.com", ".mtls.googleapis.com")

    DEFAULT_ENDPOINT = "googleads.googleapis.com"
    DEFAULT_MTLS_ENDPOINT = _get_default_mtls_endpoint.__func__(  # type: ignore
        DEFAULT_ENDPOINT
    )

    @classmethod
    def from_service_account_info(cls, info: dict, *args, **kwargs):
        """Creates an instance of this client using the provided credentials
            info.

        Args:
            info (dict): The service account private key info.
            args: Additional arguments to pass to the constructor.
            kwargs: Additional arguments to pass to the constructor.

        Returns:
            CampaignExperimentServiceClient: The constructed client.
        """
        credentials = service_account.Credentials.from_service_account_info(info)
        kwargs["credentials"] = credentials
        return cls(*args, **kwargs)

    @classmethod
    def from_service_account_file(cls, filename: str, *args, **kwargs):
        """Creates an instance of this client using the provided credentials
        file.

        Args:
            filename (str): The path to the service account private key json
                file.
            args: Additional arguments to pass to the constructor.
            kwargs: Additional arguments to pass to the constructor.

        Returns:
            CampaignExperimentServiceClient: The constructed client.
        """
        credentials = service_account.Credentials.from_service_account_file(
            filename)
        kwargs["credentials"] = credentials
        return cls(*args, **kwargs)

    from_service_account_json = from_service_account_file

    @property
    def transport(self) -> CampaignExperimentServiceTransport:
        """Returns the transport used by the client instance.

        Returns:
            CampaignExperimentServiceTransport: The transport used by the client
                instance.
        """
        return self._transport

    def __enter__(self):
        return self

    def __exit__(self, type, value, traceback):
        """Releases underlying transport's resources.

        .. warning::
            ONLY use as a context manager if the transport is NOT shared
            with other clients! Exiting the with block will CLOSE the transport
            and may cause errors in other clients!
        """
        self.transport.close()

    @staticmethod
    def campaign_path(customer_id: str,campaign_id: str,) -> str:
        """Returns a fully-qualified campaign string."""
        return "customers/{customer_id}/campaigns/{campaign_id}".format(customer_id=customer_id, campaign_id=campaign_id, )

    @staticmethod
    def parse_campaign_path(path: str) -> Dict[str,str]:
        """Parses a campaign path into its component segments."""
        m = re.match(r"^customers/(?P<customer_id>.+?)/campaigns/(?P<campaign_id>.+?)$", path)
        return m.groupdict() if m else {}

    @staticmethod
    def campaign_draft_path(customer_id: str,base_campaign_id: str,draft_id: str,) -> str:
        """Returns a fully-qualified campaign_draft string."""
        return "customers/{customer_id}/campaignDrafts/{base_campaign_id}~{draft_id}".format(customer_id=customer_id, base_campaign_id=base_campaign_id, draft_id=draft_id, )

    @staticmethod
    def parse_campaign_draft_path(path: str) -> Dict[str,str]:
        """Parses a campaign_draft path into its component segments."""
        m = re.match(r"^customers/(?P<customer_id>.+?)/campaignDrafts/(?P<base_campaign_id>.+?)~(?P<draft_id>.+?)$", path)
        return m.groupdict() if m else {}

    @staticmethod
    def campaign_experiment_path(customer_id: str,campaign_experiment_id: str,) -> str:
        """Returns a fully-qualified campaign_experiment string."""
        return "customers/{customer_id}/campaignExperiments/{campaign_experiment_id}".format(customer_id=customer_id, campaign_experiment_id=campaign_experiment_id, )

    @staticmethod
    def parse_campaign_experiment_path(path: str) -> Dict[str,str]:
        """Parses a campaign_experiment path into its component segments."""
        m = re.match(r"^customers/(?P<customer_id>.+?)/campaignExperiments/(?P<campaign_experiment_id>.+?)$", path)
        return m.groupdict() if m else {}

    @staticmethod
    def common_billing_account_path(billing_account: str, ) -> str:
        """Returns a fully-qualified billing_account string."""
        return "billingAccounts/{billing_account}".format(billing_account=billing_account, )

    @staticmethod
    def parse_common_billing_account_path(path: str) -> Dict[str,str]:
        """Parse a billing_account path into its component segments."""
        m = re.match(r"^billingAccounts/(?P<billing_account>.+?)$", path)
        return m.groupdict() if m else {}

    @staticmethod
    def common_folder_path(folder: str, ) -> str:
        """Returns a fully-qualified folder string."""
        return "folders/{folder}".format(folder=folder, )

    @staticmethod
    def parse_common_folder_path(path: str) -> Dict[str,str]:
        """Parse a folder path into its component segments."""
        m = re.match(r"^folders/(?P<folder>.+?)$", path)
        return m.groupdict() if m else {}

    @staticmethod
    def common_organization_path(organization: str, ) -> str:
        """Returns a fully-qualified organization string."""
        return "organizations/{organization}".format(organization=organization, )

    @staticmethod
    def parse_common_organization_path(path: str) -> Dict[str,str]:
        """Parse a organization path into its component segments."""
        m = re.match(r"^organizations/(?P<organization>.+?)$", path)
        return m.groupdict() if m else {}

    @staticmethod
    def common_project_path(project: str, ) -> str:
        """Returns a fully-qualified project string."""
        return "projects/{project}".format(project=project, )

    @staticmethod
    def parse_common_project_path(path: str) -> Dict[str,str]:
        """Parse a project path into its component segments."""
        m = re.match(r"^projects/(?P<project>.+?)$", path)
        return m.groupdict() if m else {}

    @staticmethod
    def common_location_path(project: str, location: str, ) -> str:
        """Returns a fully-qualified location string."""
        return "projects/{project}/locations/{location}".format(project=project, location=location, )

    @staticmethod
    def parse_common_location_path(path: str) -> Dict[str,str]:
        """Parse a location path into its component segments."""
        m = re.match(r"^projects/(?P<project>.+?)/locations/(?P<location>.+?)$", path)
        return m.groupdict() if m else {}

    def __init__(self, *,
            credentials: Optional[ga_credentials.Credentials] = None,
            transport: Union[str, CampaignExperimentServiceTransport, None] = None,
            client_options: Optional[client_options_lib.ClientOptions] = None,
            client_info: gapic_v1.client_info.ClientInfo = DEFAULT_CLIENT_INFO,
            ) -> None:
        """Instantiates the campaign experiment service client.

        Args:
            credentials (Optional[google.auth.credentials.Credentials]): The
                authorization credentials to attach to requests. These
                credentials identify the application to the service; if none
                are specified, the client will attempt to ascertain the
                credentials from the environment.
            transport (Union[str, CampaignExperimentServiceTransport]): The
                transport to use. If set to None, a transport is chosen
                automatically.
            client_options (google.api_core.client_options.ClientOptions): Custom options for the
                client. It won't take effect if a ``transport`` instance is provided.
                (1) The ``api_endpoint`` property can be used to override the
                default endpoint provided by the client. GOOGLE_API_USE_MTLS_ENDPOINT
                environment variable can also be used to override the endpoint:
                "always" (always use the default mTLS endpoint), "never" (always
                use the default regular endpoint) and "auto" (auto switch to the
                default mTLS endpoint if client certificate is present, this is
                the default value). However, the ``api_endpoint`` property takes
                precedence if provided.
                (2) If GOOGLE_API_USE_CLIENT_CERTIFICATE environment variable
                is "true", then the ``client_cert_source`` property can be used
                to provide client certificate for mutual TLS transport. If
                not provided, the default SSL client certificate will be used if
                present. If GOOGLE_API_USE_CLIENT_CERTIFICATE is "false" or not
                set, no client certificate will be used.
            client_info (google.api_core.gapic_v1.client_info.ClientInfo):
                The client info used to send a user-agent string along with
                API requests. If ``None``, then default info will be used.
                Generally, you only need to set this if you're developing
                your own client library.

        Raises:
            google.auth.exceptions.MutualTLSChannelError: If mutual TLS transport
                creation failed for any reason.
        """
        if isinstance(client_options, dict):
            client_options = client_options_lib.from_dict(client_options)
        if client_options is None:
            client_options = client_options_lib.ClientOptions()

        # Create SSL credentials for mutual TLS if needed.
        if os.getenv("GOOGLE_API_USE_CLIENT_CERTIFICATE", "false") not in ("true", "false"):
            raise ValueError("Environment variable `GOOGLE_API_USE_CLIENT_CERTIFICATE` must be either `true` or `false`")
        use_client_cert = os.getenv("GOOGLE_API_USE_CLIENT_CERTIFICATE", "false") == "true"

        client_cert_source_func = None
        is_mtls = False
        if use_client_cert:
            if client_options.client_cert_source:
                is_mtls = True
                client_cert_source_func = client_options.client_cert_source
            else:
                is_mtls = mtls.has_default_client_cert_source()
                if is_mtls:
                    client_cert_source_func = mtls.default_client_cert_source()
                else:
                    client_cert_source_func = None

        # Figure out which api endpoint to use.
        if client_options.api_endpoint is not None:
            api_endpoint = client_options.api_endpoint
        else:
            use_mtls_env = os.getenv("GOOGLE_API_USE_MTLS_ENDPOINT", "auto")
            if use_mtls_env == "never":
                api_endpoint = self.DEFAULT_ENDPOINT
            elif use_mtls_env == "always":
                api_endpoint = self.DEFAULT_MTLS_ENDPOINT
            elif use_mtls_env == "auto":
                api_endpoint = self.DEFAULT_MTLS_ENDPOINT if is_mtls else self.DEFAULT_ENDPOINT
            else:
                raise MutualTLSChannelError(
                    "Unsupported GOOGLE_API_USE_MTLS_ENDPOINT value. Accepted "
                    "values: never, auto, always"
                )

        # Save or instantiate the transport.
        # Ordinarily, we provide the transport, but allowing a custom transport
        # instance provides an extensibility point for unusual situations.
        if isinstance(transport, CampaignExperimentServiceTransport):
            # transport is a CampaignExperimentServiceTransport instance.
            if credentials or client_options.credentials_file:
                raise ValueError("When providing a transport instance, "
                                 "provide its credentials directly.")
            if client_options.scopes:
                raise ValueError(
                    "When providing a transport instance, provide its scopes "
                    "directly."
                )
            self._transport = transport
        else:
            Transport = type(self).get_transport_class(transport)
            self._transport = Transport(
                credentials=credentials,
                credentials_file=client_options.credentials_file,
                host=api_endpoint,
                scopes=client_options.scopes,
                client_cert_source_for_mtls=client_cert_source_func,
                quota_project_id=client_options.quota_project_id,
                client_info=client_info,
                always_use_jwt_access=True,
              )

    def get_campaign_experiment(self,
            request: Union[campaign_experiment_service.GetCampaignExperimentRequest, dict] = None,
            *,
            resource_name: str = None,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> campaign_experiment.CampaignExperiment:
        r"""Returns the requested campaign experiment in full detail.

        List of thrown errors: `AuthenticationError <>`__
        `AuthorizationError <>`__ `HeaderError <>`__
        `InternalError <>`__ `QuotaError <>`__ `RequestError <>`__

        Args:
            request (Union[google.ads.googleads.v8.services.types.GetCampaignExperimentRequest, dict]):
                The request object. Request message for
                [CampaignExperimentService.GetCampaignExperiment][google.ads.googleads.v8.services.CampaignExperimentService.GetCampaignExperiment].
            resource_name (str):
                Required. The resource name of the
                campaign experiment to fetch.

                This corresponds to the ``resource_name`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.ads.googleads.v8.resources.types.CampaignExperiment:
                An A/B experiment that compares the
                performance of the base campaign (the
                control) and a variation of that
                campaign (the experiment).

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([resource_name])
        if request is not None and has_flattened_params:
            raise ValueError('If the `request` argument is set, then none of '
                             'the individual field arguments should be set.')

        # Minor optimization to avoid making a copy if the user passes
        # in a campaign_experiment_service.GetCampaignExperimentRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, campaign_experiment_service.GetCampaignExperimentRequest):
            request = campaign_experiment_service.GetCampaignExperimentRequest(request)
             # If we have keyword arguments corresponding to fields on the
            # request, apply these.
            if resource_name is not None:
                request.resource_name = resource_name

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.get_campaign_experiment]

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("resource_name", request.resource_name),
            )),
        )

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def create_campaign_experiment(self,
            request: Union[campaign_experiment_service.CreateCampaignExperimentRequest, dict] = None,
            *,
            customer_id: str = None,
            campaign_experiment: gagr_campaign_experiment.CampaignExperiment = None,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation.Operation:
        r"""Creates a campaign experiment based on a campaign draft. The
        draft campaign will be forked into a real campaign (called the
        experiment campaign) that will begin serving ads if successfully
        created.

        The campaign experiment is created immediately with status
        INITIALIZING. This method return a long running operation that
        tracks the forking of the draft campaign. If the forking fails,
        a list of errors can be retrieved using the
        ListCampaignExperimentAsyncErrors method. The operation's
        metadata will be a StringValue containing the resource name of
        the created campaign experiment.

        List of thrown errors: `AuthenticationError <>`__
        `AuthorizationError <>`__ `CampaignExperimentError <>`__
        `DatabaseError <>`__ `DateError <>`__ `DateRangeError <>`__
        `FieldError <>`__ `HeaderError <>`__ `InternalError <>`__
        `QuotaError <>`__ `RangeError <>`__ `RequestError <>`__

        Args:
            request (Union[google.ads.googleads.v8.services.types.CreateCampaignExperimentRequest, dict]):
                The request object. Request message for
                [CampaignExperimentService.CreateCampaignExperiment][google.ads.googleads.v8.services.CampaignExperimentService.CreateCampaignExperiment].
            customer_id (str):
                Required. The ID of the customer
                whose campaign experiment is being
                created.

                This corresponds to the ``customer_id`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            campaign_experiment (google.ads.googleads.v8.resources.types.CampaignExperiment):
                Required. The campaign experiment to
                be created.

                This corresponds to the ``campaign_experiment`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.api_core.operation.Operation:
                An object representing a long-running operation.

                The result type for the operation will be :class:`google.protobuf.empty_pb2.Empty` A generic empty message that you can re-use to avoid defining duplicated
                   empty messages in your APIs. A typical example is to
                   use it as the request or the response type of an API
                   method. For instance:

                      service Foo {
                         rpc Bar(google.protobuf.Empty) returns
                         (google.protobuf.Empty);

                      }

                   The JSON representation for Empty is empty JSON
                   object {}.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([customer_id, campaign_experiment])
        if request is not None and has_flattened_params:
            raise ValueError('If the `request` argument is set, then none of '
                             'the individual field arguments should be set.')

        # Minor optimization to avoid making a copy if the user passes
        # in a campaign_experiment_service.CreateCampaignExperimentRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, campaign_experiment_service.CreateCampaignExperimentRequest):
            request = campaign_experiment_service.CreateCampaignExperimentRequest(request)
             # If we have keyword arguments corresponding to fields on the
            # request, apply these.
            if customer_id is not None:
                request.customer_id = customer_id
            if campaign_experiment is not None:
                request.campaign_experiment = campaign_experiment

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.create_campaign_experiment]

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("customer_id", request.customer_id),
            )),
        )

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Wrap the response in an operation future.
        response = operation.from_gapic(
            response,
            self._transport.operations_client,
            empty_pb2.Empty,
            metadata_type=campaign_experiment_service.CreateCampaignExperimentMetadata,
        )

        # Done; return the response.
        return response

    def mutate_campaign_experiments(self,
            request: Union[campaign_experiment_service.MutateCampaignExperimentsRequest, dict] = None,
            *,
            customer_id: str = None,
            operations: Sequence[campaign_experiment_service.CampaignExperimentOperation] = None,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> campaign_experiment_service.MutateCampaignExperimentsResponse:
        r"""Updates campaign experiments. Operation statuses are returned.

        List of thrown errors: `AuthenticationError <>`__
        `AuthorizationError <>`__ `CampaignExperimentError <>`__
        `HeaderError <>`__ `InternalError <>`__ `QuotaError <>`__
        `RequestError <>`__

        Args:
            request (Union[google.ads.googleads.v8.services.types.MutateCampaignExperimentsRequest, dict]):
                The request object. Request message for
                [CampaignExperimentService.MutateCampaignExperiments][google.ads.googleads.v8.services.CampaignExperimentService.MutateCampaignExperiments].
            customer_id (str):
                Required. The ID of the customer
                whose campaign experiments are being
                modified.

                This corresponds to the ``customer_id`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            operations (Sequence[google.ads.googleads.v8.services.types.CampaignExperimentOperation]):
                Required. The list of operations to
                perform on individual campaign
                experiments.

                This corresponds to the ``operations`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.ads.googleads.v8.services.types.MutateCampaignExperimentsResponse:
                Response message for campaign
                experiment mutate.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([customer_id, operations])
        if request is not None and has_flattened_params:
            raise ValueError('If the `request` argument is set, then none of '
                             'the individual field arguments should be set.')

        # Minor optimization to avoid making a copy if the user passes
        # in a campaign_experiment_service.MutateCampaignExperimentsRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, campaign_experiment_service.MutateCampaignExperimentsRequest):
            request = campaign_experiment_service.MutateCampaignExperimentsRequest(request)
             # If we have keyword arguments corresponding to fields on the
            # request, apply these.
            if customer_id is not None:
                request.customer_id = customer_id
            if operations is not None:
                request.operations = operations

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.mutate_campaign_experiments]

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("customer_id", request.customer_id),
            )),
        )

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def graduate_campaign_experiment(self,
            request: Union[campaign_experiment_service.GraduateCampaignExperimentRequest, dict] = None,
            *,
            campaign_experiment: str = None,
            campaign_budget: str = None,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> campaign_experiment_service.GraduateCampaignExperimentResponse:
        r"""Graduates a campaign experiment to a full campaign. The base and
        experiment campaigns will start running independently with their
        own budgets.

        List of thrown errors: `AuthenticationError <>`__
        `AuthorizationError <>`__ `CampaignExperimentError <>`__
        `HeaderError <>`__ `InternalError <>`__ `MutateError <>`__
        `QuotaError <>`__ `RequestError <>`__

        Args:
            request (Union[google.ads.googleads.v8.services.types.GraduateCampaignExperimentRequest, dict]):
                The request object. Request message for
                [CampaignExperimentService.GraduateCampaignExperiment][google.ads.googleads.v8.services.CampaignExperimentService.GraduateCampaignExperiment].
            campaign_experiment (str):
                Required. The resource name of the
                campaign experiment to graduate.

                This corresponds to the ``campaign_experiment`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            campaign_budget (str):
                Required. Resource name of the budget
                to attach to the campaign graduated from
                the experiment.

                This corresponds to the ``campaign_budget`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.ads.googleads.v8.services.types.GraduateCampaignExperimentResponse:
                Response message for campaign
                experiment graduate.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([campaign_experiment, campaign_budget])
        if request is not None and has_flattened_params:
            raise ValueError('If the `request` argument is set, then none of '
                             'the individual field arguments should be set.')

        # Minor optimization to avoid making a copy if the user passes
        # in a campaign_experiment_service.GraduateCampaignExperimentRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, campaign_experiment_service.GraduateCampaignExperimentRequest):
            request = campaign_experiment_service.GraduateCampaignExperimentRequest(request)
             # If we have keyword arguments corresponding to fields on the
            # request, apply these.
            if campaign_experiment is not None:
                request.campaign_experiment = campaign_experiment
            if campaign_budget is not None:
                request.campaign_budget = campaign_budget

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.graduate_campaign_experiment]

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("campaign_experiment", request.campaign_experiment),
            )),
        )

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Done; return the response.
        return response

    def promote_campaign_experiment(self,
            request: Union[campaign_experiment_service.PromoteCampaignExperimentRequest, dict] = None,
            *,
            campaign_experiment: str = None,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> operation.Operation:
        r"""Promotes the changes in a experiment campaign back to the base
        campaign.

        The campaign experiment is updated immediately with status
        PROMOTING. This method return a long running operation that
        tracks the promoting of the experiment campaign. If the
        promoting fails, a list of errors can be retrieved using the
        ListCampaignExperimentAsyncErrors method.

        List of thrown errors: `AuthenticationError <>`__
        `AuthorizationError <>`__ `HeaderError <>`__
        `InternalError <>`__ `QuotaError <>`__ `RequestError <>`__

        Args:
            request (Union[google.ads.googleads.v8.services.types.PromoteCampaignExperimentRequest, dict]):
                The request object. Request message for
                [CampaignExperimentService.PromoteCampaignExperiment][google.ads.googleads.v8.services.CampaignExperimentService.PromoteCampaignExperiment].
            campaign_experiment (str):
                Required. The resource name of the
                campaign experiment to promote.

                This corresponds to the ``campaign_experiment`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.api_core.operation.Operation:
                An object representing a long-running operation.

                The result type for the operation will be :class:`google.protobuf.empty_pb2.Empty` A generic empty message that you can re-use to avoid defining duplicated
                   empty messages in your APIs. A typical example is to
                   use it as the request or the response type of an API
                   method. For instance:

                      service Foo {
                         rpc Bar(google.protobuf.Empty) returns
                         (google.protobuf.Empty);

                      }

                   The JSON representation for Empty is empty JSON
                   object {}.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([campaign_experiment])
        if request is not None and has_flattened_params:
            raise ValueError('If the `request` argument is set, then none of '
                             'the individual field arguments should be set.')

        # Minor optimization to avoid making a copy if the user passes
        # in a campaign_experiment_service.PromoteCampaignExperimentRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, campaign_experiment_service.PromoteCampaignExperimentRequest):
            request = campaign_experiment_service.PromoteCampaignExperimentRequest(request)
             # If we have keyword arguments corresponding to fields on the
            # request, apply these.
            if campaign_experiment is not None:
                request.campaign_experiment = campaign_experiment

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.promote_campaign_experiment]

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("campaign_experiment", request.campaign_experiment),
            )),
        )

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # Wrap the response in an operation future.
        response = operation.from_gapic(
            response,
            self._transport.operations_client,
            empty_pb2.Empty,
            metadata_type=empty_pb2.Empty,
        )

        # Done; return the response.
        return response

    def end_campaign_experiment(self,
            request: Union[campaign_experiment_service.EndCampaignExperimentRequest, dict] = None,
            *,
            campaign_experiment: str = None,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> None:
        r"""Immediately ends a campaign experiment, changing the
        experiment's scheduled end date and without waiting for end of
        day. End date is updated to be the time of the request.

        List of thrown errors: `AuthenticationError <>`__
        `AuthorizationError <>`__ `CampaignExperimentError <>`__
        `HeaderError <>`__ `InternalError <>`__ `QuotaError <>`__
        `RequestError <>`__

        Args:
            request (Union[google.ads.googleads.v8.services.types.EndCampaignExperimentRequest, dict]):
                The request object. Request message for
                [CampaignExperimentService.EndCampaignExperiment][google.ads.googleads.v8.services.CampaignExperimentService.EndCampaignExperiment].
            campaign_experiment (str):
                Required. The resource name of the
                campaign experiment to end.

                This corresponds to the ``campaign_experiment`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.
        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([campaign_experiment])
        if request is not None and has_flattened_params:
            raise ValueError('If the `request` argument is set, then none of '
                             'the individual field arguments should be set.')

        # Minor optimization to avoid making a copy if the user passes
        # in a campaign_experiment_service.EndCampaignExperimentRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, campaign_experiment_service.EndCampaignExperimentRequest):
            request = campaign_experiment_service.EndCampaignExperimentRequest(request)
             # If we have keyword arguments corresponding to fields on the
            # request, apply these.
            if campaign_experiment is not None:
                request.campaign_experiment = campaign_experiment

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.end_campaign_experiment]

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("campaign_experiment", request.campaign_experiment),
            )),
        )

        # Send the request.
        rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

    def list_campaign_experiment_async_errors(self,
            request: Union[campaign_experiment_service.ListCampaignExperimentAsyncErrorsRequest, dict] = None,
            *,
            resource_name: str = None,
            retry: OptionalRetry = gapic_v1.method.DEFAULT,
            timeout: float = None,
            metadata: Sequence[Tuple[str, str]] = (),
            ) -> pagers.ListCampaignExperimentAsyncErrorsPager:
        r"""Returns all errors that occurred during CampaignExperiment
        create or promote (whichever occurred last). Supports standard
        list paging.

        List of thrown errors: `AuthenticationError <>`__
        `AuthorizationError <>`__ `HeaderError <>`__
        `InternalError <>`__ `QuotaError <>`__ `RequestError <>`__

        Args:
            request (Union[google.ads.googleads.v8.services.types.ListCampaignExperimentAsyncErrorsRequest, dict]):
                The request object. Request message for
                [CampaignExperimentService.ListCampaignExperimentAsyncErrors][google.ads.googleads.v8.services.CampaignExperimentService.ListCampaignExperimentAsyncErrors].
            resource_name (str):
                Required. The name of the campaign
                experiment from which to retrieve the
                async errors.

                This corresponds to the ``resource_name`` field
                on the ``request`` instance; if ``request`` is provided, this
                should not be set.
            retry (google.api_core.retry.Retry): Designation of what errors, if any,
                should be retried.
            timeout (float): The timeout for this request.
            metadata (Sequence[Tuple[str, str]]): Strings which should be
                sent along with the request as metadata.

        Returns:
            google.ads.googleads.v8.services.services.campaign_experiment_service.pagers.ListCampaignExperimentAsyncErrorsPager:
                Response message for
                   [CampaignExperimentService.ListCampaignExperimentAsyncErrors][google.ads.googleads.v8.services.CampaignExperimentService.ListCampaignExperimentAsyncErrors].

                Iterating over this object will yield results and
                resolve additional pages automatically.

        """
        # Create or coerce a protobuf request object.
        # Sanity check: If we got a request object, we should *not* have
        # gotten any keyword arguments that map to the request.
        has_flattened_params = any([resource_name])
        if request is not None and has_flattened_params:
            raise ValueError('If the `request` argument is set, then none of '
                             'the individual field arguments should be set.')

        # Minor optimization to avoid making a copy if the user passes
        # in a campaign_experiment_service.ListCampaignExperimentAsyncErrorsRequest.
        # There's no risk of modifying the input as we've already verified
        # there are no flattened fields.
        if not isinstance(request, campaign_experiment_service.ListCampaignExperimentAsyncErrorsRequest):
            request = campaign_experiment_service.ListCampaignExperimentAsyncErrorsRequest(request)
             # If we have keyword arguments corresponding to fields on the
            # request, apply these.
            if resource_name is not None:
                request.resource_name = resource_name

        # Wrap the RPC method; this adds retry and timeout information,
        # and friendly error handling.
        rpc = self._transport._wrapped_methods[self._transport.list_campaign_experiment_async_errors]

        # Certain fields should be provided within the metadata header;
        # add these here.
        metadata = tuple(metadata) + (
            gapic_v1.routing_header.to_grpc_metadata((
                ("resource_name", request.resource_name),
            )),
        )

        # Send the request.
        response = rpc(
            request,
            retry=retry,
            timeout=timeout,
            metadata=metadata,
        )

        # This method is paged; wrap the response in a pager, which provides
        # an `__iter__` convenience method.
        response = pagers.ListCampaignExperimentAsyncErrorsPager(
            method=rpc,
            request=request,
            response=response,
            metadata=metadata,
        )

        # Done; return the response.
        return response





try:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo(
        gapic_version=pkg_resources.get_distribution(
            "google-ads",
        ).version,
    )
except pkg_resources.DistributionNotFound:
    DEFAULT_CLIENT_INFO = gapic_v1.client_info.ClientInfo()


__all__ = (
    "CampaignExperimentServiceClient",
)
