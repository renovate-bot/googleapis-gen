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
import proto  # type: ignore

from cloud_containers.workflow.analysis.vulnerability.proto import package_pb2  # type: ignore
from google.protobuf import timestamp_pb2  # type: ignore
from grafeas.v1 import grafeas_pb2  # type: ignore


__protobuf__ = proto.module(
    package='google.cloud.ondemandscanning.v1',
    manifest={
        'AnalyzePackagesRequest',
        'AnalyzePackagesResponse',
        'AnalyzePackagesMetadata',
        'ListVulnerabilitiesRequest',
        'ListVulnerabilitiesResponse',
    },
)


class AnalyzePackagesRequest(proto.Message):
    r"""AnalyzePackagesRequest is the request to analyze a list of
    packages and create Vulnerability Occurrences for it.

    Attributes:
        parent (str):
            Required. The parent of the resource for which analysis is
            requested. Format:
            projects/[project_name]/locations/[location]
        resource_uri (str):
            Required. The resource URI of the container
            image being scanned.
        packages (Sequence[cloud_containers.workflow.analysis.vulnerability.proto.package_pb2.PackageData]):
            The packages to analyze.
    """

    parent = proto.Field(
        proto.STRING,
        number=1,
    )
    resource_uri = proto.Field(
        proto.STRING,
        number=2,
    )
    packages = proto.RepeatedField(
        proto.MESSAGE,
        number=3,
        message=package_pb2.PackageData,
    )


class AnalyzePackagesResponse(proto.Message):
    r"""AnalyzePackagesResponse contains the information necessary to
    find results for the given scan.

    Attributes:
        scan (str):
            The name of the scan resource created by this
            successful scan.
    """

    scan = proto.Field(
        proto.STRING,
        number=1,
    )


class AnalyzePackagesMetadata(proto.Message):
    r"""AnalyzePackagesMetadata contains metadata for an active scan
    of a container image.

    Attributes:
        resource_uri (str):
            The resource URI of the container image being
            scanned.
        create_time (google.protobuf.timestamp_pb2.Timestamp):
            When the scan was created.
    """

    resource_uri = proto.Field(
        proto.STRING,
        number=1,
    )
    create_time = proto.Field(
        proto.MESSAGE,
        number=2,
        message=timestamp_pb2.Timestamp,
    )


class ListVulnerabilitiesRequest(proto.Message):
    r"""ListVulnerabilitiesRequest is the request to retrieve the
    vulnerabilities resulting from a scan.

    Attributes:
        parent (str):
            Required. The parent of the collection of Vulnerabilities
            being requested. Format:
            projects/[project_name]/locations/[location]/scans/[scan_id]
        page_size (int):
            The number of vulnerabilities to retrieve.
        page_token (str):
            The page token, resulting from a previous
            call to ListVulnerabilities.
    """

    parent = proto.Field(
        proto.STRING,
        number=1,
    )
    page_size = proto.Field(
        proto.INT32,
        number=2,
    )
    page_token = proto.Field(
        proto.STRING,
        number=3,
    )


class ListVulnerabilitiesResponse(proto.Message):
    r"""ListVulnerabilitiesResponse contains a single page of
    vulnerabilities resulting from a scan.

    Attributes:
        occurrences (Sequence[grafeas.v1.grafeas_pb2.Occurrence]):
            The list of Vulnerability Occurrences
            resulting from a scan.
        next_page_token (str):
            A page token that can be used in a subsequent
            call to ListVulnerabilities to continue
            retrieving results.
    """

    @property
    def raw_page(self):
        return self

    occurrences = proto.RepeatedField(
        proto.MESSAGE,
        number=1,
        message=grafeas_pb2.Occurrence,
    )
    next_page_token = proto.Field(
        proto.STRING,
        number=2,
    )


__all__ = tuple(sorted(__protobuf__.manifest))
