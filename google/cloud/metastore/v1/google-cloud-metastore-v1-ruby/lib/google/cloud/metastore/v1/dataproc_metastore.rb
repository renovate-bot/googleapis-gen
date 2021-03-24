# frozen_string_literal: true

# Copyright 2021 Google LLC
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

# Auto-generated by gapic-generator-ruby. DO NOT EDIT!

require "gapic/common"
require "gapic/config"
require "gapic/config/method"

require "google/cloud/metastore/v1/version"

require "google/cloud/metastore/v1/dataproc_metastore/credentials"
require "google/cloud/metastore/v1/dataproc_metastore/paths"
require "google/cloud/metastore/v1/dataproc_metastore/operations"
require "google/cloud/metastore/v1/dataproc_metastore/client"

module Google
  module Cloud
    module Metastore
      module V1
        ##
        # Configures and manages metastore services.
        # Metastore services are fully managed, highly available, auto-scaled,
        # auto-healing, OSS-native deployments of technical metadata management
        # software. Each metastore service exposes a network endpoint through which
        # metadata queries are served. Metadata queries can originate from a variety
        # of sources, including Apache Hive, Apache Presto, and Apache Spark.
        #
        # The Dataproc Metastore API defines the following resource model:
        #
        # * The service works with a collection of Google Cloud projects, named:
        # `/projects/*`
        # * Each project has a collection of available locations, named: `/locations/*`
        #   (a location must refer to a Google Cloud `region`)
        # * Each location has a collection of services, named: `/services/*`
        # * Dataproc Metastore services are resources with names of the form:
        #
        #   `/projects/{project_number}/locations/{location_id}/services/{service_id}`.
        #
        # To load this service and instantiate a client:
        #
        #     require "google/cloud/metastore/v1/dataproc_metastore"
        #     client = ::Google::Cloud::Metastore::V1::DataprocMetastore::Client.new
        #
        module DataprocMetastore
        end
      end
    end
  end
end

helper_path = ::File.join __dir__, "dataproc_metastore", "helpers.rb"
require "google/cloud/metastore/v1/dataproc_metastore/helpers" if ::File.file? helper_path
