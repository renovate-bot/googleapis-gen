<?php
/*
 * Copyright 2021 Google LLC
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     https://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

/*
 * GENERATED CODE WARNING
 * This file was generated from the file
 * https://github.com/google/googleapis/blob/master/google/cloud/aiplatform/v1/pipeline_service.proto
 * and updates to that file get reflected here through a refresh process.
 */

namespace Google\Cloud\Aiplatform\V1\Gapic;

use Google\ApiCore\ApiException;
use Google\ApiCore\CredentialsWrapper;
use Google\ApiCore\GapicClientTrait;

use Google\ApiCore\LongRunning\OperationsClient;
use Google\ApiCore\OperationResponse;

use Google\ApiCore\PathTemplate;
use Google\ApiCore\RequestParamsHeaderDescriptor;
use Google\ApiCore\RetrySettings;
use Google\ApiCore\Transport\TransportInterface;
use Google\ApiCore\ValidationException;
use Google\Auth\FetchAuthTokenInterface;
use Google\Cloud\Aiplatform\V1\CancelTrainingPipelineRequest;
use Google\Cloud\Aiplatform\V1\CreateTrainingPipelineRequest;
use Google\Cloud\Aiplatform\V1\DeleteTrainingPipelineRequest;
use Google\Cloud\Aiplatform\V1\GetTrainingPipelineRequest;
use Google\Cloud\Aiplatform\V1\ListTrainingPipelinesRequest;
use Google\Cloud\Aiplatform\V1\ListTrainingPipelinesResponse;
use Google\Cloud\Aiplatform\V1\TrainingPipeline;
use Google\LongRunning\Operation;
use Google\Protobuf\FieldMask;
use Google\Protobuf\GPBEmpty;

/**
 * Service Description: A service for creating and managing AI Platform's pipelines.
 *
 * This class provides the ability to make remote calls to the backing service through method
 * calls that map to API methods. Sample code to get started:
 *
 * ```
 * $pipelineServiceClient = new PipelineServiceClient();
 * try {
 *     $formattedName = $pipelineServiceClient->trainingPipelineName('[PROJECT]', '[LOCATION]', '[TRAINING_PIPELINE]');
 *     $pipelineServiceClient->cancelTrainingPipeline($formattedName);
 * } finally {
 *     $pipelineServiceClient->close();
 * }
 * ```
 *
 * Many parameters require resource names to be formatted in a particular way. To
 * assistwith these names, this class includes a format method for each type of
 * name, and additionallya parseName method to extract the individual identifiers
 * contained within formatted namesthat are returned by the API.
 */
class PipelineServiceGapicClient
{
    use GapicClientTrait;

    /**
     * The name of the service.
     */
    const SERVICE_NAME = 'google.cloud.aiplatform.v1.PipelineService';

    /**
     * The default address of the service.
     */
    const SERVICE_ADDRESS = 'aiplatform.googleapis.com';

    /**
     * The default port of the service.
     */
    const DEFAULT_SERVICE_PORT = 443;

    /**
     * The name of the code generator, to be included in the agent header.
     */
    const CODEGEN_NAME = 'gapic';

    /**
     * The default scopes required by the service.
     */
    public static $serviceScopes = [
        'https://www.googleapis.com/auth/cloud-platform',
    ];

    private static $locationNameTemplate;

    private static $trainingPipelineNameTemplate;

    private static $pathTemplateMap;

    private $operationsClient;

    private static function getClientDefaults()
    {
        return [
            'serviceName' => self::SERVICE_NAME,
            'serviceAddress' => self::SERVICE_ADDRESS . ':' . self::DEFAULT_SERVICE_PORT,
            'clientConfig' => __DIR__ . '/../resources/pipeline_service_client_config.json',
            'descriptorsConfigPath' => __DIR__ . '/../resources/pipeline_service_descriptor_config.php',
            'gcpApiConfigPath' => __DIR__ . '/../resources/pipeline_service_grpc_config.json',
            'credentialsConfig' => [
                'defaultScopes' => self::$serviceScopes,
            ],
            'transportConfig' => [
                'rest' => [
                    'restClientConfigPath' => __DIR__ . '/../resources/pipeline_service_rest_client_config.php',
                ],
            ],
        ];
    }

    private static function getLocationNameTemplate()
    {
        if (self::$locationNameTemplate == null) {
            self::$locationNameTemplate = new PathTemplate('projects/{project}/locations/{location}');
        }

        return self::$locationNameTemplate;
    }

    private static function getTrainingPipelineNameTemplate()
    {
        if (self::$trainingPipelineNameTemplate == null) {
            self::$trainingPipelineNameTemplate = new PathTemplate('projects/{project}/locations/{location}/trainingPipelines/{training_pipeline}');
        }

        return self::$trainingPipelineNameTemplate;
    }

    private static function getPathTemplateMap()
    {
        if (self::$pathTemplateMap == null) {
            self::$pathTemplateMap = [
                'location' => self::getLocationNameTemplate(),
                'trainingPipeline' => self::getTrainingPipelineNameTemplate(),
            ];
        }

        return self::$pathTemplateMap;
    }

    /**
     * Formats a string containing the fully-qualified path to represent a location
     * resource.
     *
     * @param string $project
     * @param string $location
     *
     * @return string The formatted location resource.
     */
    public static function locationName($project, $location)
    {
        return self::getLocationNameTemplate()->render([
            'project' => $project,
            'location' => $location,
        ]);
    }

    /**
     * Formats a string containing the fully-qualified path to represent a
     * training_pipeline resource.
     *
     * @param string $project
     * @param string $location
     * @param string $trainingPipeline
     *
     * @return string The formatted training_pipeline resource.
     */
    public static function trainingPipelineName($project, $location, $trainingPipeline)
    {
        return self::getTrainingPipelineNameTemplate()->render([
            'project' => $project,
            'location' => $location,
            'training_pipeline' => $trainingPipeline,
        ]);
    }

    /**
     * Parses a formatted name string and returns an associative array of the components in the name.
     * The following name formats are supported:
     * Template: Pattern
     * - location: projects/{project}/locations/{location}
     * - trainingPipeline: projects/{project}/locations/{location}/trainingPipelines/{training_pipeline}
     *
     * The optional $template argument can be supplied to specify a particular pattern,
     * and must match one of the templates listed above. If no $template argument is
     * provided, or if the $template argument does not match one of the templates
     * listed, then parseName will check each of the supported templates, and return
     * the first match.
     *
     * @param string $formattedName The formatted name string
     * @param string $template      Optional name of template to match
     *
     * @return array An associative array from name component IDs to component values.
     *
     * @throws ValidationException If $formattedName could not be matched.
     */
    public static function parseName($formattedName, $template = null)
    {
        $templateMap = self::getPathTemplateMap();
        if ($template) {
            if (!isset($templateMap[$template])) {
                throw new ValidationException("Template name $template does not exist");
            }

            return $templateMap[$template]->match($formattedName);
        }

        foreach ($templateMap as $templateName => $pathTemplate) {
            try {
                return $pathTemplate->match($formattedName);
            } catch (ValidationException $ex) {
                // Swallow the exception to continue trying other path templates
            }
        }

        throw new ValidationException("Input did not match any known format. Input: $formattedName");
    }

    /**
     * Return an OperationsClient object with the same endpoint as $this.
     *
     * @return OperationsClient
     */
    public function getOperationsClient()
    {
        return $this->operationsClient;
    }

    /**
     * Resume an existing long running operation that was previously started by a long
     * running API method. If $methodName is not provided, or does not match a long
     * running API method, then the operation can still be resumed, but the
     * OperationResponse object will not deserialize the final response.
     *
     * @param string $operationName The name of the long running operation
     * @param string $methodName    The name of the method used to start the operation
     *
     * @return OperationResponse
     */
    public function resumeOperation($operationName, $methodName = null)
    {
        $options = isset($this->descriptors[$methodName]['longRunning']) ? $this->descriptors[$methodName]['longRunning'] : [];
        $operation = new OperationResponse($operationName, $this->getOperationsClient(), $options);
        $operation->reload();
        return $operation;
    }

    /**
     * Constructor.
     *
     * @param array $options {
     *     Optional. Options for configuring the service API wrapper.
     *
     *     @type string $serviceAddress
     *           The address of the API remote host. May optionally include the port, formatted
     *           as "<uri>:<port>". Default 'aiplatform.googleapis.com:443'.
     *     @type string|array|FetchAuthTokenInterface|CredentialsWrapper $credentials
     *           The credentials to be used by the client to authorize API calls. This option
     *           accepts either a path to a credentials file, or a decoded credentials file as a
     *           PHP array.
     *           *Advanced usage*: In addition, this option can also accept a pre-constructed
     *           {@see \Google\Auth\FetchAuthTokenInterface} object or
     *           {@see \Google\ApiCore\CredentialsWrapper} object. Note that when one of these
     *           objects are provided, any settings in $credentialsConfig will be ignored.
     *     @type array $credentialsConfig
     *           Options used to configure credentials, including auth token caching, for the
     *           client. For a full list of supporting configuration options, see
     *           {@see \Google\ApiCore\CredentialsWrapper::build()} .
     *     @type bool $disableRetries
     *           Determines whether or not retries defined by the client configuration should be
     *           disabled. Defaults to `false`.
     *     @type string|array $clientConfig
     *           Client method configuration, including retry settings. This option can be either
     *           a path to a JSON file, or a PHP array containing the decoded JSON data. By
     *           default this settings points to the default client config file, which is
     *           provided in the resources folder.
     *     @type string|TransportInterface $transport
     *           The transport used for executing network requests. May be either the string
     *           `rest` or `grpc`. Defaults to `grpc` if gRPC support is detected on the system.
     *           *Advanced usage*: Additionally, it is possible to pass in an already
     *           instantiated {@see \Google\ApiCore\Transport\TransportInterface} object. Note
     *           that when this object is provided, any settings in $transportConfig, and any
     *           $serviceAddress setting, will be ignored.
     *     @type array $transportConfig
     *           Configuration options that will be used to construct the transport. Options for
     *           each supported transport type should be passed in a key for that transport. For
     *           example:
     *           $transportConfig = [
     *               'grpc' => [...],
     *               'rest' => [...],
     *           ];
     *           See the {@see \Google\ApiCore\Transport\GrpcTransport::build()} and
     *           {@see \Google\ApiCore\Transport\RestTransport::build()} methods for the
     *           supported options.
     * }
     *
     * @throws ValidationException
     */
    public function __construct(array $options = [])
    {
        $clientOptions = $this->buildClientOptions($options);
        $this->setClientOptions($clientOptions);
        $this->operationsClient = $this->createOperationsClient($clientOptions);
    }

    /**
     * Cancels a TrainingPipeline.
     * Starts asynchronous cancellation on the TrainingPipeline. The server
     * makes a best effort to cancel the pipeline, but success is not
     * guaranteed. Clients can use [PipelineService.GetTrainingPipeline][google.cloud.aiplatform.v1.PipelineService.GetTrainingPipeline] or
     * other methods to check whether the cancellation succeeded or whether the
     * pipeline completed despite cancellation. On successful cancellation,
     * the TrainingPipeline is not deleted; instead it becomes a pipeline with
     * a [TrainingPipeline.error][google.cloud.aiplatform.v1.TrainingPipeline.error] value with a [google.rpc.Status.code][google.rpc.Status.code] of 1,
     * corresponding to `Code.CANCELLED`, and [TrainingPipeline.state][google.cloud.aiplatform.v1.TrainingPipeline.state] is set to
     * `CANCELLED`.
     *
     * Sample code:
     * ```
     * $pipelineServiceClient = new PipelineServiceClient();
     * try {
     *     $formattedName = $pipelineServiceClient->trainingPipelineName('[PROJECT]', '[LOCATION]', '[TRAINING_PIPELINE]');
     *     $pipelineServiceClient->cancelTrainingPipeline($formattedName);
     * } finally {
     *     $pipelineServiceClient->close();
     * }
     * ```
     *
     * @param string $name         Required. The name of the TrainingPipeline to cancel.
     *                             Format:
     *
     *                             `projects/{project}/locations/{location}/trainingPipelines/{training_pipeline}`
     * @param array  $optionalArgs {
     *     Optional.
     *
     *     @type RetrySettings|array $retrySettings
     *           Retry settings to use for this call. Can be a
     *           {@see Google\ApiCore\RetrySettings} object, or an associative array of retry
     *           settings parameters. See the documentation on
     *           {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @throws ApiException if the remote call fails
     */
    public function cancelTrainingPipeline($name, array $optionalArgs = [])
    {
        $request = new CancelTrainingPipelineRequest();
        $requestParamHeaders = [];
        $request->setName($name);
        $requestParamHeaders['name'] = $name;
        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('CancelTrainingPipeline', GPBEmpty::class, $optionalArgs, $request)->wait();
    }

    /**
     * Creates a TrainingPipeline. A created TrainingPipeline right away will be
     * attempted to be run.
     *
     * Sample code:
     * ```
     * $pipelineServiceClient = new PipelineServiceClient();
     * try {
     *     $formattedParent = $pipelineServiceClient->locationName('[PROJECT]', '[LOCATION]');
     *     $trainingPipeline = new TrainingPipeline();
     *     $response = $pipelineServiceClient->createTrainingPipeline($formattedParent, $trainingPipeline);
     * } finally {
     *     $pipelineServiceClient->close();
     * }
     * ```
     *
     * @param string           $parent           Required. The resource name of the Location to create the TrainingPipeline in.
     *                                           Format: `projects/{project}/locations/{location}`
     * @param TrainingPipeline $trainingPipeline Required. The TrainingPipeline to create.
     * @param array            $optionalArgs     {
     *     Optional.
     *
     *     @type RetrySettings|array $retrySettings
     *           Retry settings to use for this call. Can be a
     *           {@see Google\ApiCore\RetrySettings} object, or an associative array of retry
     *           settings parameters. See the documentation on
     *           {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\Aiplatform\V1\TrainingPipeline
     *
     * @throws ApiException if the remote call fails
     */
    public function createTrainingPipeline($parent, $trainingPipeline, array $optionalArgs = [])
    {
        $request = new CreateTrainingPipelineRequest();
        $requestParamHeaders = [];
        $request->setParent($parent);
        $request->setTrainingPipeline($trainingPipeline);
        $requestParamHeaders['parent'] = $parent;
        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('CreateTrainingPipeline', TrainingPipeline::class, $optionalArgs, $request)->wait();
    }

    /**
     * Deletes a TrainingPipeline.
     *
     * Sample code:
     * ```
     * $pipelineServiceClient = new PipelineServiceClient();
     * try {
     *     $formattedName = $pipelineServiceClient->trainingPipelineName('[PROJECT]', '[LOCATION]', '[TRAINING_PIPELINE]');
     *     $operationResponse = $pipelineServiceClient->deleteTrainingPipeline($formattedName);
     *     $operationResponse->pollUntilComplete();
     *     if ($operationResponse->operationSucceeded()) {
     *         // operation succeeded and returns no value
     *     } else {
     *         $error = $operationResponse->getError();
     *         // handleError($error)
     *     }
     *     // Alternatively:
     *     // start the operation, keep the operation name, and resume later
     *     $operationResponse = $pipelineServiceClient->deleteTrainingPipeline($formattedName);
     *     $operationName = $operationResponse->getName();
     *     // ... do other work
     *     $newOperationResponse = $pipelineServiceClient->resumeOperation($operationName, 'deleteTrainingPipeline');
     *     while (!$newOperationResponse->isDone()) {
     *         // ... do other work
     *         $newOperationResponse->reload();
     *     }
     *     if ($newOperationResponse->operationSucceeded()) {
     *         // operation succeeded and returns no value
     *     } else {
     *         $error = $newOperationResponse->getError();
     *         // handleError($error)
     *     }
     * } finally {
     *     $pipelineServiceClient->close();
     * }
     * ```
     *
     * @param string $name         Required. The name of the TrainingPipeline resource to be deleted.
     *                             Format:
     *
     *                             `projects/{project}/locations/{location}/trainingPipelines/{training_pipeline}`
     * @param array  $optionalArgs {
     *     Optional.
     *
     *     @type RetrySettings|array $retrySettings
     *           Retry settings to use for this call. Can be a
     *           {@see Google\ApiCore\RetrySettings} object, or an associative array of retry
     *           settings parameters. See the documentation on
     *           {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\ApiCore\OperationResponse
     *
     * @throws ApiException if the remote call fails
     */
    public function deleteTrainingPipeline($name, array $optionalArgs = [])
    {
        $request = new DeleteTrainingPipelineRequest();
        $requestParamHeaders = [];
        $request->setName($name);
        $requestParamHeaders['name'] = $name;
        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startOperationsCall('DeleteTrainingPipeline', $optionalArgs, $request, $this->getOperationsClient())->wait();
    }

    /**
     * Gets a TrainingPipeline.
     *
     * Sample code:
     * ```
     * $pipelineServiceClient = new PipelineServiceClient();
     * try {
     *     $formattedName = $pipelineServiceClient->trainingPipelineName('[PROJECT]', '[LOCATION]', '[TRAINING_PIPELINE]');
     *     $response = $pipelineServiceClient->getTrainingPipeline($formattedName);
     * } finally {
     *     $pipelineServiceClient->close();
     * }
     * ```
     *
     * @param string $name         Required. The name of the TrainingPipeline resource.
     *                             Format:
     *
     *                             `projects/{project}/locations/{location}/trainingPipelines/{training_pipeline}`
     * @param array  $optionalArgs {
     *     Optional.
     *
     *     @type RetrySettings|array $retrySettings
     *           Retry settings to use for this call. Can be a
     *           {@see Google\ApiCore\RetrySettings} object, or an associative array of retry
     *           settings parameters. See the documentation on
     *           {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\Aiplatform\V1\TrainingPipeline
     *
     * @throws ApiException if the remote call fails
     */
    public function getTrainingPipeline($name, array $optionalArgs = [])
    {
        $request = new GetTrainingPipelineRequest();
        $requestParamHeaders = [];
        $request->setName($name);
        $requestParamHeaders['name'] = $name;
        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('GetTrainingPipeline', TrainingPipeline::class, $optionalArgs, $request)->wait();
    }

    /**
     * Lists TrainingPipelines in a Location.
     *
     * Sample code:
     * ```
     * $pipelineServiceClient = new PipelineServiceClient();
     * try {
     *     $formattedParent = $pipelineServiceClient->locationName('[PROJECT]', '[LOCATION]');
     *     // Iterate over pages of elements
     *     $pagedResponse = $pipelineServiceClient->listTrainingPipelines($formattedParent);
     *     foreach ($pagedResponse->iteratePages() as $page) {
     *         foreach ($page as $element) {
     *             // doSomethingWith($element);
     *         }
     *     }
     *     // Alternatively:
     *     // Iterate through all elements
     *     $pagedResponse = $pipelineServiceClient->listTrainingPipelines($formattedParent);
     *     foreach ($pagedResponse->iterateAllElements() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $pipelineServiceClient->close();
     * }
     * ```
     *
     * @param string $parent       Required. The resource name of the Location to list the TrainingPipelines from.
     *                             Format: `projects/{project}/locations/{location}`
     * @param array  $optionalArgs {
     *     Optional.
     *
     *     @type string $filter
     *           The standard list filter.
     *           Supported fields:
     *
     *           * `display_name` supports = and !=.
     *
     *           * `state` supports = and !=.
     *
     *           Some examples of using the filter are:
     *
     *           * `state="PIPELINE_STATE_SUCCEEDED" AND display_name="my_pipeline"`
     *
     *           * `state="PIPELINE_STATE_RUNNING" OR display_name="my_pipeline"`
     *
     *           * `NOT display_name="my_pipeline"`
     *
     *           * `state="PIPELINE_STATE_FAILED"`
     *     @type int $pageSize
     *           The maximum number of resources contained in the underlying API
     *           response. The API may return fewer values in a page, even if
     *           there are additional values to be retrieved.
     *     @type string $pageToken
     *           A page token is used to specify a page of values to be returned.
     *           If no page token is specified (the default), the first page
     *           of values will be returned. Any page token used here must have
     *           been generated by a previous call to the API.
     *     @type FieldMask $readMask
     *           Mask specifying which fields to read.
     *     @type RetrySettings|array $retrySettings
     *           Retry settings to use for this call. Can be a
     *           {@see Google\ApiCore\RetrySettings} object, or an associative array of retry
     *           settings parameters. See the documentation on
     *           {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\ApiCore\PagedListResponse
     *
     * @throws ApiException if the remote call fails
     */
    public function listTrainingPipelines($parent, array $optionalArgs = [])
    {
        $request = new ListTrainingPipelinesRequest();
        $requestParamHeaders = [];
        $request->setParent($parent);
        $requestParamHeaders['parent'] = $parent;
        if (isset($optionalArgs['filter'])) {
            $request->setFilter($optionalArgs['filter']);
        }

        if (isset($optionalArgs['pageSize'])) {
            $request->setPageSize($optionalArgs['pageSize']);
        }

        if (isset($optionalArgs['pageToken'])) {
            $request->setPageToken($optionalArgs['pageToken']);
        }

        if (isset($optionalArgs['readMask'])) {
            $request->setReadMask($optionalArgs['readMask']);
        }

        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->getPagedListResponse('ListTrainingPipelines', $optionalArgs, ListTrainingPipelinesResponse::class, $request);
    }
}
