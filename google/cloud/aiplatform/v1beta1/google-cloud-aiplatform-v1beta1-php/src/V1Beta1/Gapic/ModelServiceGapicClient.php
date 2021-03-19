<?php
/*
 * Copyright 2020 Google LLC
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
 * https://github.com/google/googleapis/blob/master/google/cloud/aiplatform/v1beta1/model_service.proto
 * and updates to that file get reflected here through a refresh process.
 *
 * @experimental
 */

namespace Google\Cloud\Aiplatform\V1Beta1\Gapic;

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
use Google\Cloud\Aiplatform\V1beta1\DeleteModelRequest;
use Google\Cloud\Aiplatform\V1beta1\ExportModelRequest;
use Google\Cloud\Aiplatform\V1beta1\ExportModelRequest\OutputConfig;
use Google\Cloud\Aiplatform\V1beta1\GetModelEvaluationRequest;
use Google\Cloud\Aiplatform\V1beta1\GetModelEvaluationSliceRequest;
use Google\Cloud\Aiplatform\V1beta1\GetModelRequest;
use Google\Cloud\Aiplatform\V1beta1\ListModelEvaluationSlicesRequest;
use Google\Cloud\Aiplatform\V1beta1\ListModelEvaluationSlicesResponse;
use Google\Cloud\Aiplatform\V1beta1\ListModelEvaluationsRequest;
use Google\Cloud\Aiplatform\V1beta1\ListModelEvaluationsResponse;
use Google\Cloud\Aiplatform\V1beta1\ListModelsRequest;
use Google\Cloud\Aiplatform\V1beta1\ListModelsResponse;
use Google\Cloud\Aiplatform\V1beta1\Model;
use Google\Cloud\Aiplatform\V1beta1\ModelEvaluation;
use Google\Cloud\Aiplatform\V1beta1\ModelEvaluationSlice;
use Google\Cloud\Aiplatform\V1beta1\UpdateModelRequest;
use Google\Cloud\Aiplatform\V1beta1\UploadModelRequest;
use Google\LongRunning\Operation;
use Google\Protobuf\FieldMask;

/**
 * Service Description: A service for managing AI Platform's machine learning Models.
 *
 * This class provides the ability to make remote calls to the backing service through method
 * calls that map to API methods. Sample code to get started:
 *
 * ```
 * $modelServiceClient = new ModelServiceClient();
 * try {
 *     $formattedParent = $modelServiceClient->locationName('[PROJECT]', '[LOCATION]');
 *     $model = new Model();
 *     $operationResponse = $modelServiceClient->uploadModel($formattedParent, $model);
 *     $operationResponse->pollUntilComplete();
 *     if ($operationResponse->operationSucceeded()) {
 *         $result = $operationResponse->getResult();
 *         // doSomethingWith($result)
 *     } else {
 *         $error = $operationResponse->getError();
 *         // handleError($error)
 *     }
 *
 *
 *     // Alternatively:
 *
 *     // start the operation, keep the operation name, and resume later
 *     $operationResponse = $modelServiceClient->uploadModel($formattedParent, $model);
 *     $operationName = $operationResponse->getName();
 *     // ... do other work
 *     $newOperationResponse = $modelServiceClient->resumeOperation($operationName, 'uploadModel');
 *     while (!$newOperationResponse->isDone()) {
 *         // ... do other work
 *         $newOperationResponse->reload();
 *     }
 *     if ($newOperationResponse->operationSucceeded()) {
 *       $result = $newOperationResponse->getResult();
 *       // doSomethingWith($result)
 *     } else {
 *       $error = $newOperationResponse->getError();
 *       // handleError($error)
 *     }
 * } finally {
 *     $modelServiceClient->close();
 * }
 * ```
 *
 * Many parameters require resource names to be formatted in a particular way. To assist
 * with these names, this class includes a format method for each type of name, and additionally
 * a parseName method to extract the individual identifiers contained within formatted names
 * that are returned by the API.
 *
 * @experimental
 */
class ModelServiceGapicClient
{
    use GapicClientTrait;

    /**
     * The name of the service.
     */
    const SERVICE_NAME = 'google.cloud.aiplatform.v1beta1.ModelService';

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
    private static $modelNameTemplate;
    private static $modelEvaluationNameTemplate;
    private static $modelEvaluationSliceNameTemplate;
    private static $trainingPipelineNameTemplate;
    private static $pathTemplateMap;

    private $operationsClient;

    private static function getClientDefaults()
    {
        return [
            'serviceName' => self::SERVICE_NAME,
            'serviceAddress' => self::SERVICE_ADDRESS.':'.self::DEFAULT_SERVICE_PORT,
            'clientConfig' => __DIR__.'/../resources/model_service_client_config.json',
            'descriptorsConfigPath' => __DIR__.'/../resources/model_service_descriptor_config.php',
            'gcpApiConfigPath' => __DIR__.'/../resources/model_service_grpc_config.json',
            'credentialsConfig' => [
                'defaultScopes' => self::$serviceScopes,
            ],
            'transportConfig' => [
                'rest' => [
                    'restClientConfigPath' => __DIR__.'/../resources/model_service_rest_client_config.php',
                ],
            ],
        ];
    }

    private static function getLocationNameTemplate()
    {
        if (null == self::$locationNameTemplate) {
            self::$locationNameTemplate = new PathTemplate('projects/{project}/locations/{location}');
        }

        return self::$locationNameTemplate;
    }

    private static function getModelNameTemplate()
    {
        if (null == self::$modelNameTemplate) {
            self::$modelNameTemplate = new PathTemplate('projects/{project}/locations/{location}/models/{model}');
        }

        return self::$modelNameTemplate;
    }

    private static function getModelEvaluationNameTemplate()
    {
        if (null == self::$modelEvaluationNameTemplate) {
            self::$modelEvaluationNameTemplate = new PathTemplate('projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}');
        }

        return self::$modelEvaluationNameTemplate;
    }

    private static function getModelEvaluationSliceNameTemplate()
    {
        if (null == self::$modelEvaluationSliceNameTemplate) {
            self::$modelEvaluationSliceNameTemplate = new PathTemplate('projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}/slices/{slice}');
        }

        return self::$modelEvaluationSliceNameTemplate;
    }

    private static function getTrainingPipelineNameTemplate()
    {
        if (null == self::$trainingPipelineNameTemplate) {
            self::$trainingPipelineNameTemplate = new PathTemplate('projects/{project}/locations/{location}/trainingPipelines/{training_pipeline}');
        }

        return self::$trainingPipelineNameTemplate;
    }

    private static function getPathTemplateMap()
    {
        if (null == self::$pathTemplateMap) {
            self::$pathTemplateMap = [
                'location' => self::getLocationNameTemplate(),
                'model' => self::getModelNameTemplate(),
                'modelEvaluation' => self::getModelEvaluationNameTemplate(),
                'modelEvaluationSlice' => self::getModelEvaluationSliceNameTemplate(),
                'trainingPipeline' => self::getTrainingPipelineNameTemplate(),
            ];
        }

        return self::$pathTemplateMap;
    }

    /**
     * Formats a string containing the fully-qualified path to represent
     * a location resource.
     *
     * @param string $project
     * @param string $location
     *
     * @return string The formatted location resource.
     * @experimental
     */
    public static function locationName($project, $location)
    {
        return self::getLocationNameTemplate()->render([
            'project' => $project,
            'location' => $location,
        ]);
    }

    /**
     * Formats a string containing the fully-qualified path to represent
     * a model resource.
     *
     * @param string $project
     * @param string $location
     * @param string $model
     *
     * @return string The formatted model resource.
     * @experimental
     */
    public static function modelName($project, $location, $model)
    {
        return self::getModelNameTemplate()->render([
            'project' => $project,
            'location' => $location,
            'model' => $model,
        ]);
    }

    /**
     * Formats a string containing the fully-qualified path to represent
     * a model_evaluation resource.
     *
     * @param string $project
     * @param string $location
     * @param string $model
     * @param string $evaluation
     *
     * @return string The formatted model_evaluation resource.
     * @experimental
     */
    public static function modelEvaluationName($project, $location, $model, $evaluation)
    {
        return self::getModelEvaluationNameTemplate()->render([
            'project' => $project,
            'location' => $location,
            'model' => $model,
            'evaluation' => $evaluation,
        ]);
    }

    /**
     * Formats a string containing the fully-qualified path to represent
     * a model_evaluation_slice resource.
     *
     * @param string $project
     * @param string $location
     * @param string $model
     * @param string $evaluation
     * @param string $slice
     *
     * @return string The formatted model_evaluation_slice resource.
     * @experimental
     */
    public static function modelEvaluationSliceName($project, $location, $model, $evaluation, $slice)
    {
        return self::getModelEvaluationSliceNameTemplate()->render([
            'project' => $project,
            'location' => $location,
            'model' => $model,
            'evaluation' => $evaluation,
            'slice' => $slice,
        ]);
    }

    /**
     * Formats a string containing the fully-qualified path to represent
     * a training_pipeline resource.
     *
     * @param string $project
     * @param string $location
     * @param string $trainingPipeline
     *
     * @return string The formatted training_pipeline resource.
     * @experimental
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
     * - model: projects/{project}/locations/{location}/models/{model}
     * - modelEvaluation: projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}
     * - modelEvaluationSlice: projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}/slices/{slice}
     * - trainingPipeline: projects/{project}/locations/{location}/trainingPipelines/{training_pipeline}.
     *
     * The optional $template argument can be supplied to specify a particular pattern, and must
     * match one of the templates listed above. If no $template argument is provided, or if the
     * $template argument does not match one of the templates listed, then parseName will check
     * each of the supported templates, and return the first match.
     *
     * @param string $formattedName The formatted name string
     * @param string $template      Optional name of template to match
     *
     * @return array An associative array from name component IDs to component values.
     *
     * @throws ValidationException If $formattedName could not be matched.
     * @experimental
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
     * @experimental
     */
    public function getOperationsClient()
    {
        return $this->operationsClient;
    }

    /**
     * Resume an existing long running operation that was previously started
     * by a long running API method. If $methodName is not provided, or does
     * not match a long running API method, then the operation can still be
     * resumed, but the OperationResponse object will not deserialize the
     * final response.
     *
     * @param string $operationName The name of the long running operation
     * @param string $methodName    The name of the method used to start the operation
     *
     * @return OperationResponse
     * @experimental
     */
    public function resumeOperation($operationName, $methodName = null)
    {
        $options = isset($this->descriptors[$methodName]['longRunning'])
            ? $this->descriptors[$methodName]['longRunning']
            : [];
        $operation = new OperationResponse($operationName, $this->getOperationsClient(), $options);
        $operation->reload();

        return $operation;
    }

    /**
     * Constructor.
     *
     * @param array $options {
     *                       Optional. Options for configuring the service API wrapper.
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
     *           Options used to configure credentials, including auth token caching, for the client.
     *           For a full list of supporting configuration options, see
     *           {@see \Google\ApiCore\CredentialsWrapper::build()}.
     *     @type bool $disableRetries
     *           Determines whether or not retries defined by the client configuration should be
     *           disabled. Defaults to `false`.
     *     @type string|array $clientConfig
     *           Client method configuration, including retry settings. This option can be either a
     *           path to a JSON file, or a PHP array containing the decoded JSON data.
     *           By default this settings points to the default client config file, which is provided
     *           in the resources folder.
     *     @type string|TransportInterface $transport
     *           The transport used for executing network requests. May be either the string `rest`
     *           or `grpc`. Defaults to `grpc` if gRPC support is detected on the system.
     *           *Advanced usage*: Additionally, it is possible to pass in an already instantiated
     *           {@see \Google\ApiCore\Transport\TransportInterface} object. Note that when this
     *           object is provided, any settings in $transportConfig, and any $serviceAddress
     *           setting, will be ignored.
     *     @type array $transportConfig
     *           Configuration options that will be used to construct the transport. Options for
     *           each supported transport type should be passed in a key for that transport. For
     *           example:
     *           $transportConfig = [
     *               'grpc' => [...],
     *               'rest' => [...]
     *           ];
     *           See the {@see \Google\ApiCore\Transport\GrpcTransport::build()} and
     *           {@see \Google\ApiCore\Transport\RestTransport::build()} methods for the
     *           supported options.
     * }
     *
     * @throws ValidationException
     * @experimental
     */
    public function __construct(array $options = [])
    {
        $clientOptions = $this->buildClientOptions($options);
        $this->setClientOptions($clientOptions);
        $this->operationsClient = $this->createOperationsClient($clientOptions);
    }

    /**
     * Uploads a Model artifact into AI Platform.
     *
     * Sample code:
     * ```
     * $modelServiceClient = new ModelServiceClient();
     * try {
     *     $formattedParent = $modelServiceClient->locationName('[PROJECT]', '[LOCATION]');
     *     $model = new Model();
     *     $operationResponse = $modelServiceClient->uploadModel($formattedParent, $model);
     *     $operationResponse->pollUntilComplete();
     *     if ($operationResponse->operationSucceeded()) {
     *         $result = $operationResponse->getResult();
     *         // doSomethingWith($result)
     *     } else {
     *         $error = $operationResponse->getError();
     *         // handleError($error)
     *     }
     *
     *
     *     // Alternatively:
     *
     *     // start the operation, keep the operation name, and resume later
     *     $operationResponse = $modelServiceClient->uploadModel($formattedParent, $model);
     *     $operationName = $operationResponse->getName();
     *     // ... do other work
     *     $newOperationResponse = $modelServiceClient->resumeOperation($operationName, 'uploadModel');
     *     while (!$newOperationResponse->isDone()) {
     *         // ... do other work
     *         $newOperationResponse->reload();
     *     }
     *     if ($newOperationResponse->operationSucceeded()) {
     *       $result = $newOperationResponse->getResult();
     *       // doSomethingWith($result)
     *     } else {
     *       $error = $newOperationResponse->getError();
     *       // handleError($error)
     *     }
     * } finally {
     *     $modelServiceClient->close();
     * }
     * ```
     *
     * @param string $parent       Required. The resource name of the Location into which to upload the Model.
     *                             Format: `projects/{project}/locations/{location}`
     * @param Model  $model        Required. The Model to create.
     * @param array  $optionalArgs {
     *                             Optional.
     *
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\ApiCore\OperationResponse
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function uploadModel($parent, $model, array $optionalArgs = [])
    {
        $request = new UploadModelRequest();
        $request->setParent($parent);
        $request->setModel($model);

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startOperationsCall(
            'UploadModel',
            $optionalArgs,
            $request,
            $this->getOperationsClient()
        )->wait();
    }

    /**
     * Gets a Model.
     *
     * Sample code:
     * ```
     * $modelServiceClient = new ModelServiceClient();
     * try {
     *     $formattedName = $modelServiceClient->modelName('[PROJECT]', '[LOCATION]', '[MODEL]');
     *     $response = $modelServiceClient->getModel($formattedName);
     * } finally {
     *     $modelServiceClient->close();
     * }
     * ```
     *
     * @param string $name         Required. The name of the Model resource.
     *                             Format: `projects/{project}/locations/{location}/models/{model}`
     * @param array  $optionalArgs {
     *                             Optional.
     *
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\Aiplatform\V1beta1\Model
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function getModel($name, array $optionalArgs = [])
    {
        $request = new GetModelRequest();
        $request->setName($name);

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'GetModel',
            Model::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Lists Models in a Location.
     *
     * Sample code:
     * ```
     * $modelServiceClient = new ModelServiceClient();
     * try {
     *     $formattedParent = $modelServiceClient->locationName('[PROJECT]', '[LOCATION]');
     *     // Iterate over pages of elements
     *     $pagedResponse = $modelServiceClient->listModels($formattedParent);
     *     foreach ($pagedResponse->iteratePages() as $page) {
     *         foreach ($page as $element) {
     *             // doSomethingWith($element);
     *         }
     *     }
     *
     *
     *     // Alternatively:
     *
     *     // Iterate through all elements
     *     $pagedResponse = $modelServiceClient->listModels($formattedParent);
     *     foreach ($pagedResponse->iterateAllElements() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $modelServiceClient->close();
     * }
     * ```
     *
     * @param string $parent       Required. The resource name of the Location to list the Models from.
     *                             Format: `projects/{project}/locations/{location}`
     * @param array  $optionalArgs {
     *                             Optional.
     *
     *     @type string $filter
     *          An expression for filtering the results of the request. For field names
     *          both snake_case and camelCase are supported.
     *
     *            * `model` supports = and !=. `model` represents the Model ID,
     *              i.e. the last segment of the Model's [resource name][google.cloud.aiplatform.v1beta1.Model.name].
     *            * `display_name` supports = and !=
     *            * `labels` supports general map functions that is:
     *              * `labels.key=value` - key:value equality
     *              * `labels.key:* or labels:key - key existence
     *              * A key including a space must be quoted. `labels."a key"`.
     *
     *          Some examples:
     *            * `model=1234`
     *            * `displayName="myDisplayName"`
     *            * `labels.myKey="myValue"`
     *     @type int $pageSize
     *          The maximum number of resources contained in the underlying API
     *          response. The API may return fewer values in a page, even if
     *          there are additional values to be retrieved.
     *     @type string $pageToken
     *          A page token is used to specify a page of values to be returned.
     *          If no page token is specified (the default), the first page
     *          of values will be returned. Any page token used here must have
     *          been generated by a previous call to the API.
     *     @type FieldMask $readMask
     *          Mask specifying which fields to read.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\ApiCore\PagedListResponse
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function listModels($parent, array $optionalArgs = [])
    {
        $request = new ListModelsRequest();
        $request->setParent($parent);
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

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->getPagedListResponse(
            'ListModels',
            $optionalArgs,
            ListModelsResponse::class,
            $request
        );
    }

    /**
     * Updates a Model.
     *
     * Sample code:
     * ```
     * $modelServiceClient = new ModelServiceClient();
     * try {
     *     $model = new Model();
     *     $updateMask = new FieldMask();
     *     $response = $modelServiceClient->updateModel($model, $updateMask);
     * } finally {
     *     $modelServiceClient->close();
     * }
     * ```
     *
     * @param Model     $model        Required. The Model which replaces the resource on the server.
     * @param FieldMask $updateMask   Required. The update mask applies to the resource.
     *                                For the `FieldMask` definition, see
     *                                [FieldMask](https://tinyurl.com/protobufs/google.protobuf#fieldmask).
     * @param array     $optionalArgs {
     *                                Optional.
     *
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\Aiplatform\V1beta1\Model
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function updateModel($model, $updateMask, array $optionalArgs = [])
    {
        $request = new UpdateModelRequest();
        $request->setModel($model);
        $request->setUpdateMask($updateMask);

        $requestParams = new RequestParamsHeaderDescriptor([
          'model.name' => $request->getModel()->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'UpdateModel',
            Model::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Deletes a Model.
     * Note: Model can only be deleted if there are no DeployedModels created
     * from it.
     *
     * Sample code:
     * ```
     * $modelServiceClient = new ModelServiceClient();
     * try {
     *     $formattedName = $modelServiceClient->modelName('[PROJECT]', '[LOCATION]', '[MODEL]');
     *     $operationResponse = $modelServiceClient->deleteModel($formattedName);
     *     $operationResponse->pollUntilComplete();
     *     if ($operationResponse->operationSucceeded()) {
     *         // operation succeeded and returns no value
     *     } else {
     *         $error = $operationResponse->getError();
     *         // handleError($error)
     *     }
     *
     *
     *     // Alternatively:
     *
     *     // start the operation, keep the operation name, and resume later
     *     $operationResponse = $modelServiceClient->deleteModel($formattedName);
     *     $operationName = $operationResponse->getName();
     *     // ... do other work
     *     $newOperationResponse = $modelServiceClient->resumeOperation($operationName, 'deleteModel');
     *     while (!$newOperationResponse->isDone()) {
     *         // ... do other work
     *         $newOperationResponse->reload();
     *     }
     *     if ($newOperationResponse->operationSucceeded()) {
     *       // operation succeeded and returns no value
     *     } else {
     *       $error = $newOperationResponse->getError();
     *       // handleError($error)
     *     }
     * } finally {
     *     $modelServiceClient->close();
     * }
     * ```
     *
     * @param string $name         Required. The name of the Model resource to be deleted.
     *                             Format: `projects/{project}/locations/{location}/models/{model}`
     * @param array  $optionalArgs {
     *                             Optional.
     *
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\ApiCore\OperationResponse
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function deleteModel($name, array $optionalArgs = [])
    {
        $request = new DeleteModelRequest();
        $request->setName($name);

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startOperationsCall(
            'DeleteModel',
            $optionalArgs,
            $request,
            $this->getOperationsClient()
        )->wait();
    }

    /**
     * Exports a trained, exportable, Model to a location specified by the
     * user. A Model is considered to be exportable if it has at least one
     * [supported export format][google.cloud.aiplatform.v1beta1.Model.supported_export_formats].
     *
     * Sample code:
     * ```
     * $modelServiceClient = new ModelServiceClient();
     * try {
     *     $formattedName = $modelServiceClient->modelName('[PROJECT]', '[LOCATION]', '[MODEL]');
     *     $outputConfig = new OutputConfig();
     *     $operationResponse = $modelServiceClient->exportModel($formattedName, $outputConfig);
     *     $operationResponse->pollUntilComplete();
     *     if ($operationResponse->operationSucceeded()) {
     *         $result = $operationResponse->getResult();
     *         // doSomethingWith($result)
     *     } else {
     *         $error = $operationResponse->getError();
     *         // handleError($error)
     *     }
     *
     *
     *     // Alternatively:
     *
     *     // start the operation, keep the operation name, and resume later
     *     $operationResponse = $modelServiceClient->exportModel($formattedName, $outputConfig);
     *     $operationName = $operationResponse->getName();
     *     // ... do other work
     *     $newOperationResponse = $modelServiceClient->resumeOperation($operationName, 'exportModel');
     *     while (!$newOperationResponse->isDone()) {
     *         // ... do other work
     *         $newOperationResponse->reload();
     *     }
     *     if ($newOperationResponse->operationSucceeded()) {
     *       $result = $newOperationResponse->getResult();
     *       // doSomethingWith($result)
     *     } else {
     *       $error = $newOperationResponse->getError();
     *       // handleError($error)
     *     }
     * } finally {
     *     $modelServiceClient->close();
     * }
     * ```
     *
     * @param string       $name         Required. The resource name of the Model to export.
     *                                   Format: `projects/{project}/locations/{location}/models/{model}`
     * @param OutputConfig $outputConfig Required. The desired output location and configuration.
     * @param array        $optionalArgs {
     *                                   Optional.
     *
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\ApiCore\OperationResponse
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function exportModel($name, $outputConfig, array $optionalArgs = [])
    {
        $request = new ExportModelRequest();
        $request->setName($name);
        $request->setOutputConfig($outputConfig);

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startOperationsCall(
            'ExportModel',
            $optionalArgs,
            $request,
            $this->getOperationsClient()
        )->wait();
    }

    /**
     * Gets a ModelEvaluation.
     *
     * Sample code:
     * ```
     * $modelServiceClient = new ModelServiceClient();
     * try {
     *     $formattedName = $modelServiceClient->modelEvaluationName('[PROJECT]', '[LOCATION]', '[MODEL]', '[EVALUATION]');
     *     $response = $modelServiceClient->getModelEvaluation($formattedName);
     * } finally {
     *     $modelServiceClient->close();
     * }
     * ```
     *
     * @param string $name         Required. The name of the ModelEvaluation resource.
     *                             Format:
     *                             `projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}`
     * @param array  $optionalArgs {
     *                             Optional.
     *
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\Aiplatform\V1beta1\ModelEvaluation
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function getModelEvaluation($name, array $optionalArgs = [])
    {
        $request = new GetModelEvaluationRequest();
        $request->setName($name);

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'GetModelEvaluation',
            ModelEvaluation::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Lists ModelEvaluations in a Model.
     *
     * Sample code:
     * ```
     * $modelServiceClient = new ModelServiceClient();
     * try {
     *     $formattedParent = $modelServiceClient->modelName('[PROJECT]', '[LOCATION]', '[MODEL]');
     *     // Iterate over pages of elements
     *     $pagedResponse = $modelServiceClient->listModelEvaluations($formattedParent);
     *     foreach ($pagedResponse->iteratePages() as $page) {
     *         foreach ($page as $element) {
     *             // doSomethingWith($element);
     *         }
     *     }
     *
     *
     *     // Alternatively:
     *
     *     // Iterate through all elements
     *     $pagedResponse = $modelServiceClient->listModelEvaluations($formattedParent);
     *     foreach ($pagedResponse->iterateAllElements() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $modelServiceClient->close();
     * }
     * ```
     *
     * @param string $parent       Required. The resource name of the Model to list the ModelEvaluations from.
     *                             Format: `projects/{project}/locations/{location}/models/{model}`
     * @param array  $optionalArgs {
     *                             Optional.
     *
     *     @type string $filter
     *          The standard list filter.
     *     @type int $pageSize
     *          The maximum number of resources contained in the underlying API
     *          response. The API may return fewer values in a page, even if
     *          there are additional values to be retrieved.
     *     @type string $pageToken
     *          A page token is used to specify a page of values to be returned.
     *          If no page token is specified (the default), the first page
     *          of values will be returned. Any page token used here must have
     *          been generated by a previous call to the API.
     *     @type FieldMask $readMask
     *          Mask specifying which fields to read.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\ApiCore\PagedListResponse
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function listModelEvaluations($parent, array $optionalArgs = [])
    {
        $request = new ListModelEvaluationsRequest();
        $request->setParent($parent);
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

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->getPagedListResponse(
            'ListModelEvaluations',
            $optionalArgs,
            ListModelEvaluationsResponse::class,
            $request
        );
    }

    /**
     * Gets a ModelEvaluationSlice.
     *
     * Sample code:
     * ```
     * $modelServiceClient = new ModelServiceClient();
     * try {
     *     $formattedName = $modelServiceClient->modelEvaluationSliceName('[PROJECT]', '[LOCATION]', '[MODEL]', '[EVALUATION]', '[SLICE]');
     *     $response = $modelServiceClient->getModelEvaluationSlice($formattedName);
     * } finally {
     *     $modelServiceClient->close();
     * }
     * ```
     *
     * @param string $name         Required. The name of the ModelEvaluationSlice resource.
     *                             Format:
     *                             `projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}/slices/{slice}`
     * @param array  $optionalArgs {
     *                             Optional.
     *
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\Aiplatform\V1beta1\ModelEvaluationSlice
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function getModelEvaluationSlice($name, array $optionalArgs = [])
    {
        $request = new GetModelEvaluationSliceRequest();
        $request->setName($name);

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'GetModelEvaluationSlice',
            ModelEvaluationSlice::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Lists ModelEvaluationSlices in a ModelEvaluation.
     *
     * Sample code:
     * ```
     * $modelServiceClient = new ModelServiceClient();
     * try {
     *     $formattedParent = $modelServiceClient->modelEvaluationName('[PROJECT]', '[LOCATION]', '[MODEL]', '[EVALUATION]');
     *     // Iterate over pages of elements
     *     $pagedResponse = $modelServiceClient->listModelEvaluationSlices($formattedParent);
     *     foreach ($pagedResponse->iteratePages() as $page) {
     *         foreach ($page as $element) {
     *             // doSomethingWith($element);
     *         }
     *     }
     *
     *
     *     // Alternatively:
     *
     *     // Iterate through all elements
     *     $pagedResponse = $modelServiceClient->listModelEvaluationSlices($formattedParent);
     *     foreach ($pagedResponse->iterateAllElements() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $modelServiceClient->close();
     * }
     * ```
     *
     * @param string $parent       Required. The resource name of the ModelEvaluation to list the ModelEvaluationSlices
     *                             from. Format:
     *                             `projects/{project}/locations/{location}/models/{model}/evaluations/{evaluation}`
     * @param array  $optionalArgs {
     *                             Optional.
     *
     *     @type string $filter
     *          The standard list filter.
     *
     *            * `slice.dimension` - for =.
     *     @type int $pageSize
     *          The maximum number of resources contained in the underlying API
     *          response. The API may return fewer values in a page, even if
     *          there are additional values to be retrieved.
     *     @type string $pageToken
     *          A page token is used to specify a page of values to be returned.
     *          If no page token is specified (the default), the first page
     *          of values will be returned. Any page token used here must have
     *          been generated by a previous call to the API.
     *     @type FieldMask $readMask
     *          Mask specifying which fields to read.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\ApiCore\PagedListResponse
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function listModelEvaluationSlices($parent, array $optionalArgs = [])
    {
        $request = new ListModelEvaluationSlicesRequest();
        $request->setParent($parent);
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

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->getPagedListResponse(
            'ListModelEvaluationSlices',
            $optionalArgs,
            ListModelEvaluationSlicesResponse::class,
            $request
        );
    }
}
