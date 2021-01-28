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

module Google
  module Cloud
    module Aiplatform
      module V1beta1
        # Represents a job that runs custom workloads such as a Docker container or a
        # Python package. A CustomJob can have multiple worker pools and each worker
        # pool can have its own machine and input spec. A CustomJob will be cleaned up
        # once the job enters terminal state (failed or succeeded).
        # @!attribute [rw] name
        #   @return [String]
        #     Output only. Resource name of a CustomJob.
        # @!attribute [rw] display_name
        #   @return [String]
        #     Required. The display name of the CustomJob.
        #     The name can be up to 128 characters long and can be consist of any UTF-8
        #     characters.
        # @!attribute [rw] job_spec
        #   @return [Google::Cloud::Aiplatform::V1beta1::CustomJobSpec]
        #     Required. Job spec.
        # @!attribute [rw] state
        #   @return [Google::Cloud::Aiplatform::V1beta1::JobState]
        #     Output only. The detailed state of the job.
        # @!attribute [rw] create_time
        #   @return [Google::Protobuf::Timestamp]
        #     Output only. Time when the CustomJob was created.
        # @!attribute [rw] start_time
        #   @return [Google::Protobuf::Timestamp]
        #     Output only. Time when the CustomJob for the first time entered the
        #     `JOB_STATE_RUNNING` state.
        # @!attribute [rw] end_time
        #   @return [Google::Protobuf::Timestamp]
        #     Output only. Time when the CustomJob entered any of the following states:
        #     `JOB_STATE_SUCCEEDED`, `JOB_STATE_FAILED`, `JOB_STATE_CANCELLED`.
        # @!attribute [rw] update_time
        #   @return [Google::Protobuf::Timestamp]
        #     Output only. Time when the CustomJob was most recently updated.
        # @!attribute [rw] error
        #   @return [Google::Rpc::Status]
        #     Output only. Only populated when job's state is `JOB_STATE_FAILED` or
        #     `JOB_STATE_CANCELLED`.
        # @!attribute [rw] labels
        #   @return [Hash{String => String}]
        #     The labels with user-defined metadata to organize CustomJobs.
        #
        #     Label keys and values can be no longer than 64 characters
        #     (Unicode codepoints), can only contain lowercase letters, numeric
        #     characters, underscores and dashes. International characters are allowed.
        #
        #     See https://goo.gl/xmQnxf for more information and examples of labels.
        class CustomJob; end

        # Represents the spec of a CustomJob.
        # @!attribute [rw] worker_pool_specs
        #   @return [Array<Google::Cloud::Aiplatform::V1beta1::WorkerPoolSpec>]
        #     Required. The spec of the worker pools including machine type and Docker image.
        # @!attribute [rw] scheduling
        #   @return [Google::Cloud::Aiplatform::V1beta1::Scheduling]
        #     Scheduling options for a CustomJob.
        # @!attribute [rw] service_account
        #   @return [String]
        #     Specifies the service account for workload run-as account.
        #     Users submitting jobs must have act-as permission on this run-as account.
        # @!attribute [rw] network
        #   @return [String]
        #     The full name of the Compute Engine
        #     [network](https://cloud.google.com/compute/docs/networks-and-firewalls#networks) to which the Job
        #     should be peered. For example, projects/12345/global/networks/myVPC.
        #
        #     [Format](https:
        #     //cloud.google.com/compute/docs/reference/rest/v1/networks/insert)
        #     is of the form projects/{project}/global/networks/{network}.
        #     Where {project} is a project number, as in '12345', and {network} is
        #     network name.
        #
        #     Private services access must already be configured for the network. If left
        #     unspecified, the job is not peered with any network.
        # @!attribute [rw] base_output_directory
        #   @return [Google::Cloud::Aiplatform::V1beta1::GcsDestination]
        #     The Google Cloud Storage location to store the output of this CustomJob or
        #     HyperparameterTuningJob. For HyperparameterTuningJob,
        #     {CustomJob#job_spec#base_output_directory base_output_directory} of
        #     each child CustomJob backing a Trial is set to a subdirectory of name
        #     {Google::Cloud::Aiplatform::V1beta1::Trial#id id} under parent HyperparameterTuningJob's
        #
        #     {HyperparameterTuningJob#trial_job_spec#base_output_directory base_output_directory}.
        #
        #     Following AI Platform environment variables will be passed to containers or
        #     python modules when this field is set:
        #
        #       For CustomJob:
        #     * AIP_MODEL_DIR = `<base_output_directory>/model/`
        #       * AIP_CHECKPOINT_DIR = `<base_output_directory>/checkpoints/`
        #       * AIP_TENSORBOARD_LOG_DIR = `<base_output_directory>/logs/`
        #
        #       For CustomJob backing a Trial of HyperparameterTuningJob:
        #       * AIP_MODEL_DIR = `<base_output_directory>/<trial_id>/model/`
        #       * AIP_CHECKPOINT_DIR = `<base_output_directory>/<trial_id>/checkpoints/`
        #       * AIP_TENSORBOARD_LOG_DIR = `<base_output_directory>/<trial_id>/logs/`
        class CustomJobSpec; end

        # Represents the spec of a worker pool in a job.
        # @!attribute [rw] container_spec
        #   @return [Google::Cloud::Aiplatform::V1beta1::ContainerSpec]
        #     The custom container task.
        # @!attribute [rw] python_package_spec
        #   @return [Google::Cloud::Aiplatform::V1beta1::PythonPackageSpec]
        #     The Python packaged task.
        # @!attribute [rw] machine_spec
        #   @return [Google::Cloud::Aiplatform::V1beta1::MachineSpec]
        #     Required. Immutable. The specification of a single machine.
        # @!attribute [rw] replica_count
        #   @return [Integer]
        #     Required. The number of worker replicas to use for this worker pool.
        # @!attribute [rw] disk_spec
        #   @return [Google::Cloud::Aiplatform::V1beta1::DiskSpec]
        #     Disk spec.
        class WorkerPoolSpec; end

        # The spec of a Container.
        # @!attribute [rw] image_uri
        #   @return [String]
        #     Required. The URI of a container image in the Container Registry that is to be run on
        #     each worker replica.
        # @!attribute [rw] command
        #   @return [Array<String>]
        #     The command to be invoked when the container is started.
        #     It overrides the entrypoint instruction in Dockerfile when provided.
        # @!attribute [rw] args
        #   @return [Array<String>]
        #     The arguments to be passed when starting the container.
        class ContainerSpec; end

        # The spec of a Python packaged code.
        # @!attribute [rw] executor_image_uri
        #   @return [String]
        #     Required. The URI of a container image in the Container Registry that will run the
        #     provided python package. AI Platform provides wide range of executor images
        #     with pre-installed packages to meet users' various use cases. Only one of
        #     the provided images can be set here.
        # @!attribute [rw] package_uris
        #   @return [Array<String>]
        #     Required. The Google Cloud Storage location of the Python package files which are
        #     the training program and its dependent packages.
        #     The maximum number of package URIs is 100.
        # @!attribute [rw] python_module
        #   @return [String]
        #     Required. The Python module name to run after installing the packages.
        # @!attribute [rw] args
        #   @return [Array<String>]
        #     Command line arguments to be passed to the Python task.
        class PythonPackageSpec; end

        # All parameters related to queuing and scheduling of custom jobs.
        # @!attribute [rw] timeout
        #   @return [Google::Protobuf::Duration]
        #     The maximum job running time. The default is 7 days.
        # @!attribute [rw] restart_job_on_worker_restart
        #   @return [true, false]
        #     Restarts the entire CustomJob if a worker gets restarted.
        #     This feature can be used by distributed training jobs that are not
        #     resilient to workers leaving and joining a job.
        class Scheduling; end
      end
    end
  end
end