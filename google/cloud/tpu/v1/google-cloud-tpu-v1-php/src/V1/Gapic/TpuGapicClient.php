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
 * https://github.com/google/googleapis/blob/master/google/cloud/tpu/v1/cloud_tpu.proto
 * and updates to that file get reflected here through a refresh process.
 */

namespace Google\Cloud\Tpu\V1\Gapic;

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
use Google\Cloud\Tpu\V1\AcceleratorType;
use Google\Cloud\Tpu\V1\CreateNodeRequest;
use Google\Cloud\Tpu\V1\DeleteNodeRequest;
use Google\Cloud\Tpu\V1\GetAcceleratorTypeRequest;
use Google\Cloud\Tpu\V1\GetNodeRequest;
use Google\Cloud\Tpu\V1\GetTensorFlowVersionRequest;
use Google\Cloud\Tpu\V1\ListAcceleratorTypesRequest;
use Google\Cloud\Tpu\V1\ListAcceleratorTypesResponse;
use Google\Cloud\Tpu\V1\ListNodesRequest;
use Google\Cloud\Tpu\V1\ListNodesResponse;
use Google\Cloud\Tpu\V1\ListTensorFlowVersionsRequest;
use Google\Cloud\Tpu\V1\ListTensorFlowVersionsResponse;
use Google\Cloud\Tpu\V1\Node;
use Google\Cloud\Tpu\V1\ReimageNodeRequest;
use Google\Cloud\Tpu\V1\StartNodeRequest;
use Google\Cloud\Tpu\V1\StopNodeRequest;
use Google\Cloud\Tpu\V1\TensorFlowVersion;
use Google\LongRunning\Operation;

/**
 * Service Description: Manages TPU nodes and other resources
 *
 * TPU API v1
 *
 * This class provides the ability to make remote calls to the backing service through method
 * calls that map to API methods. Sample code to get started:
 *
 * ```
 * $tpuClient = new TpuClient();
 * try {
 *     $formattedParent = $tpuClient->locationName('[PROJECT]', '[LOCATION]');
 *     $node = new Node();
 *     $operationResponse = $tpuClient->createNode($formattedParent, $node);
 *     $operationResponse->pollUntilComplete();
 *     if ($operationResponse->operationSucceeded()) {
 *         $result = $operationResponse->getResult();
 *     // doSomethingWith($result)
 *     } else {
 *         $error = $operationResponse->getError();
 *         // handleError($error)
 *     }
 *     // Alternatively:
 *     // start the operation, keep the operation name, and resume later
 *     $operationResponse = $tpuClient->createNode($formattedParent, $node);
 *     $operationName = $operationResponse->getName();
 *     // ... do other work
 *     $newOperationResponse = $tpuClient->resumeOperation($operationName, 'createNode');
 *     while (!$newOperationResponse->isDone()) {
 *         // ... do other work
 *         $newOperationResponse->reload();
 *     }
 *     if ($newOperationResponse->operationSucceeded()) {
 *         $result = $newOperationResponse->getResult();
 *     // doSomethingWith($result)
 *     } else {
 *         $error = $newOperationResponse->getError();
 *         // handleError($error)
 *     }
 * } finally {
 *     $tpuClient->close();
 * }
 * ```
 *
 * Many parameters require resource names to be formatted in a particular way. To
 * assistwith these names, this class includes a format method for each type of
 * name, and additionallya parseName method to extract the individual identifiers
 * contained within formatted namesthat are returned by the API.
 */
class TpuGapicClient
{
    use GapicClientTrait;

    /**
     * The name of the service.
     */
    const SERVICE_NAME = 'google.cloud.tpu.v1.Tpu';

    /**
     * The default address of the service.
     */
    const SERVICE_ADDRESS = 'tpu.googleapis.com';

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

    private static $acceleratorTypeNameTemplate;

    private static $locationNameTemplate;

    private static $nodeNameTemplate;

    private static $tensorFlowVersionNameTemplate;

    private static $pathTemplateMap;

    private $operationsClient;

    private static function getClientDefaults()
    {
        return [
            'serviceName' => self::SERVICE_NAME,
            'serviceAddress' => self::SERVICE_ADDRESS . ':' . self::DEFAULT_SERVICE_PORT,
            'clientConfig' => __DIR__ . '/../resources/tpu_client_config.json',
            'descriptorsConfigPath' => __DIR__ . '/../resources/tpu_descriptor_config.php',
            'gcpApiConfigPath' => __DIR__ . '/../resources/tpu_grpc_config.json',
            'credentialsConfig' => [
                'defaultScopes' => self::$serviceScopes,
            ],
            'transportConfig' => [
                'rest' => [
                    'restClientConfigPath' => __DIR__ . '/../resources/tpu_rest_client_config.php',
                ],
            ],
        ];
    }

    private static function getAcceleratorTypeNameTemplate()
    {
        if (self::$acceleratorTypeNameTemplate == null) {
            self::$acceleratorTypeNameTemplate = new PathTemplate('projects/{project}/locations/{location}/acceleratorTypes/{accelerator_type}');
        }

        return self::$acceleratorTypeNameTemplate;
    }

    private static function getLocationNameTemplate()
    {
        if (self::$locationNameTemplate == null) {
            self::$locationNameTemplate = new PathTemplate('projects/{project}/locations/{location}');
        }

        return self::$locationNameTemplate;
    }

    private static function getNodeNameTemplate()
    {
        if (self::$nodeNameTemplate == null) {
            self::$nodeNameTemplate = new PathTemplate('projects/{project}/locations/{location}/nodes/{node}');
        }

        return self::$nodeNameTemplate;
    }

    private static function getTensorFlowVersionNameTemplate()
    {
        if (self::$tensorFlowVersionNameTemplate == null) {
            self::$tensorFlowVersionNameTemplate = new PathTemplate('projects/{project}/locations/{location}/tensorFlowVersions/{tensor_flow_version}');
        }

        return self::$tensorFlowVersionNameTemplate;
    }

    private static function getPathTemplateMap()
    {
        if (self::$pathTemplateMap == null) {
            self::$pathTemplateMap = [
                'acceleratorType' => self::getAcceleratorTypeNameTemplate(),
                'location' => self::getLocationNameTemplate(),
                'node' => self::getNodeNameTemplate(),
                'tensorFlowVersion' => self::getTensorFlowVersionNameTemplate(),
            ];
        }

        return self::$pathTemplateMap;
    }

    /**
     * Formats a string containing the fully-qualified path to represent a
     * accelerator_type resource.
     *
     * @param string $project
     * @param string $location
     * @param string $acceleratorType
     *
     * @return string The formatted accelerator_type resource.
     */
    public static function acceleratorTypeName($project, $location, $acceleratorType)
    {
        return self::getAcceleratorTypeNameTemplate()->render([
            'project' => $project,
            'location' => $location,
            'accelerator_type' => $acceleratorType,
        ]);
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
     * Formats a string containing the fully-qualified path to represent a node
     * resource.
     *
     * @param string $project
     * @param string $location
     * @param string $node
     *
     * @return string The formatted node resource.
     */
    public static function nodeName($project, $location, $node)
    {
        return self::getNodeNameTemplate()->render([
            'project' => $project,
            'location' => $location,
            'node' => $node,
        ]);
    }

    /**
     * Formats a string containing the fully-qualified path to represent a
     * tensor_flow_version resource.
     *
     * @param string $project
     * @param string $location
     * @param string $tensorFlowVersion
     *
     * @return string The formatted tensor_flow_version resource.
     */
    public static function tensorFlowVersionName($project, $location, $tensorFlowVersion)
    {
        return self::getTensorFlowVersionNameTemplate()->render([
            'project' => $project,
            'location' => $location,
            'tensor_flow_version' => $tensorFlowVersion,
        ]);
    }

    /**
     * Parses a formatted name string and returns an associative array of the components in the name.
     * The following name formats are supported:
     * Template: Pattern
     * - acceleratorType: projects/{project}/locations/{location}/acceleratorTypes/{accelerator_type}
     * - location: projects/{project}/locations/{location}
     * - node: projects/{project}/locations/{location}/nodes/{node}
     * - tensorFlowVersion: projects/{project}/locations/{location}/tensorFlowVersions/{tensor_flow_version}
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
     *           as "<uri>:<port>". Default 'tpu.googleapis.com:443'.
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
     * Creates a node.
     *
     * Sample code:
     * ```
     * $tpuClient = new TpuClient();
     * try {
     *     $formattedParent = $tpuClient->locationName('[PROJECT]', '[LOCATION]');
     *     $node = new Node();
     *     $operationResponse = $tpuClient->createNode($formattedParent, $node);
     *     $operationResponse->pollUntilComplete();
     *     if ($operationResponse->operationSucceeded()) {
     *         $result = $operationResponse->getResult();
     *     // doSomethingWith($result)
     *     } else {
     *         $error = $operationResponse->getError();
     *         // handleError($error)
     *     }
     *     // Alternatively:
     *     // start the operation, keep the operation name, and resume later
     *     $operationResponse = $tpuClient->createNode($formattedParent, $node);
     *     $operationName = $operationResponse->getName();
     *     // ... do other work
     *     $newOperationResponse = $tpuClient->resumeOperation($operationName, 'createNode');
     *     while (!$newOperationResponse->isDone()) {
     *         // ... do other work
     *         $newOperationResponse->reload();
     *     }
     *     if ($newOperationResponse->operationSucceeded()) {
     *         $result = $newOperationResponse->getResult();
     *     // doSomethingWith($result)
     *     } else {
     *         $error = $newOperationResponse->getError();
     *         // handleError($error)
     *     }
     * } finally {
     *     $tpuClient->close();
     * }
     * ```
     *
     * @param string $parent       Required. The parent resource name.
     * @param Node   $node         Required. The node.
     * @param array  $optionalArgs {
     *     Optional.
     *
     *     @type string $nodeId
     *           The unqualified resource name.
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
    public function createNode($parent, $node, array $optionalArgs = [])
    {
        $request = new CreateNodeRequest();
        $requestParamHeaders = [];
        $request->setParent($parent);
        $request->setNode($node);
        $requestParamHeaders['parent'] = $parent;
        if (isset($optionalArgs['nodeId'])) {
            $request->setNodeId($optionalArgs['nodeId']);
        }

        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startOperationsCall('CreateNode', $optionalArgs, $request, $this->getOperationsClient())->wait();
    }

    /**
     * Deletes a node.
     *
     * Sample code:
     * ```
     * $tpuClient = new TpuClient();
     * try {
     *     $formattedName = $tpuClient->nodeName('[PROJECT]', '[LOCATION]', '[NODE]');
     *     $operationResponse = $tpuClient->deleteNode($formattedName);
     *     $operationResponse->pollUntilComplete();
     *     if ($operationResponse->operationSucceeded()) {
     *         $result = $operationResponse->getResult();
     *     // doSomethingWith($result)
     *     } else {
     *         $error = $operationResponse->getError();
     *         // handleError($error)
     *     }
     *     // Alternatively:
     *     // start the operation, keep the operation name, and resume later
     *     $operationResponse = $tpuClient->deleteNode($formattedName);
     *     $operationName = $operationResponse->getName();
     *     // ... do other work
     *     $newOperationResponse = $tpuClient->resumeOperation($operationName, 'deleteNode');
     *     while (!$newOperationResponse->isDone()) {
     *         // ... do other work
     *         $newOperationResponse->reload();
     *     }
     *     if ($newOperationResponse->operationSucceeded()) {
     *         $result = $newOperationResponse->getResult();
     *     // doSomethingWith($result)
     *     } else {
     *         $error = $newOperationResponse->getError();
     *         // handleError($error)
     *     }
     * } finally {
     *     $tpuClient->close();
     * }
     * ```
     *
     * @param string $name         Required. The resource name.
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
    public function deleteNode($name, array $optionalArgs = [])
    {
        $request = new DeleteNodeRequest();
        $requestParamHeaders = [];
        $request->setName($name);
        $requestParamHeaders['name'] = $name;
        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startOperationsCall('DeleteNode', $optionalArgs, $request, $this->getOperationsClient())->wait();
    }

    /**
     * Gets AcceleratorType.
     *
     * Sample code:
     * ```
     * $tpuClient = new TpuClient();
     * try {
     *     $formattedName = $tpuClient->acceleratorTypeName('[PROJECT]', '[LOCATION]', '[ACCELERATOR_TYPE]');
     *     $response = $tpuClient->getAcceleratorType($formattedName);
     * } finally {
     *     $tpuClient->close();
     * }
     * ```
     *
     * @param string $name         Required. The resource name.
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
     * @return \Google\Cloud\Tpu\V1\AcceleratorType
     *
     * @throws ApiException if the remote call fails
     */
    public function getAcceleratorType($name, array $optionalArgs = [])
    {
        $request = new GetAcceleratorTypeRequest();
        $requestParamHeaders = [];
        $request->setName($name);
        $requestParamHeaders['name'] = $name;
        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('GetAcceleratorType', AcceleratorType::class, $optionalArgs, $request)->wait();
    }

    /**
     * Gets the details of a node.
     *
     * Sample code:
     * ```
     * $tpuClient = new TpuClient();
     * try {
     *     $formattedName = $tpuClient->nodeName('[PROJECT]', '[LOCATION]', '[NODE]');
     *     $response = $tpuClient->getNode($formattedName);
     * } finally {
     *     $tpuClient->close();
     * }
     * ```
     *
     * @param string $name         Required. The resource name.
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
     * @return \Google\Cloud\Tpu\V1\Node
     *
     * @throws ApiException if the remote call fails
     */
    public function getNode($name, array $optionalArgs = [])
    {
        $request = new GetNodeRequest();
        $requestParamHeaders = [];
        $request->setName($name);
        $requestParamHeaders['name'] = $name;
        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('GetNode', Node::class, $optionalArgs, $request)->wait();
    }

    /**
     * Gets TensorFlow Version.
     *
     * Sample code:
     * ```
     * $tpuClient = new TpuClient();
     * try {
     *     $formattedName = $tpuClient->tensorFlowVersionName('[PROJECT]', '[LOCATION]', '[TENSOR_FLOW_VERSION]');
     *     $response = $tpuClient->getTensorFlowVersion($formattedName);
     * } finally {
     *     $tpuClient->close();
     * }
     * ```
     *
     * @param string $name         Required. The resource name.
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
     * @return \Google\Cloud\Tpu\V1\TensorFlowVersion
     *
     * @throws ApiException if the remote call fails
     */
    public function getTensorFlowVersion($name, array $optionalArgs = [])
    {
        $request = new GetTensorFlowVersionRequest();
        $requestParamHeaders = [];
        $request->setName($name);
        $requestParamHeaders['name'] = $name;
        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('GetTensorFlowVersion', TensorFlowVersion::class, $optionalArgs, $request)->wait();
    }

    /**
     * Lists accelerator types supported by this API.
     *
     * Sample code:
     * ```
     * $tpuClient = new TpuClient();
     * try {
     *     $formattedParent = $tpuClient->acceleratorTypeName('[PROJECT]', '[LOCATION]', '[ACCELERATOR_TYPE]');
     *     // Iterate over pages of elements
     *     $pagedResponse = $tpuClient->listAcceleratorTypes($formattedParent);
     *     foreach ($pagedResponse->iteratePages() as $page) {
     *         foreach ($page as $element) {
     *             // doSomethingWith($element);
     *         }
     *     }
     *     // Alternatively:
     *     // Iterate through all elements
     *     $pagedResponse = $tpuClient->listAcceleratorTypes($formattedParent);
     *     foreach ($pagedResponse->iterateAllElements() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $tpuClient->close();
     * }
     * ```
     *
     * @param string $parent       Required. The parent resource name.
     * @param array  $optionalArgs {
     *     Optional.
     *
     *     @type int $pageSize
     *           The maximum number of resources contained in the underlying API
     *           response. The API may return fewer values in a page, even if
     *           there are additional values to be retrieved.
     *     @type string $pageToken
     *           A page token is used to specify a page of values to be returned.
     *           If no page token is specified (the default), the first page
     *           of values will be returned. Any page token used here must have
     *           been generated by a previous call to the API.
     *     @type string $filter
     *           List filter.
     *     @type string $orderBy
     *           Sort results.
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
    public function listAcceleratorTypes($parent, array $optionalArgs = [])
    {
        $request = new ListAcceleratorTypesRequest();
        $requestParamHeaders = [];
        $request->setParent($parent);
        $requestParamHeaders['parent'] = $parent;
        if (isset($optionalArgs['pageSize'])) {
            $request->setPageSize($optionalArgs['pageSize']);
        }

        if (isset($optionalArgs['pageToken'])) {
            $request->setPageToken($optionalArgs['pageToken']);
        }

        if (isset($optionalArgs['filter'])) {
            $request->setFilter($optionalArgs['filter']);
        }

        if (isset($optionalArgs['orderBy'])) {
            $request->setOrderBy($optionalArgs['orderBy']);
        }

        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->getPagedListResponse('ListAcceleratorTypes', $optionalArgs, ListAcceleratorTypesResponse::class, $request);
    }

    /**
     * Lists nodes.
     *
     * Sample code:
     * ```
     * $tpuClient = new TpuClient();
     * try {
     *     $formattedParent = $tpuClient->nodeName('[PROJECT]', '[LOCATION]', '[NODE]');
     *     // Iterate over pages of elements
     *     $pagedResponse = $tpuClient->listNodes($formattedParent);
     *     foreach ($pagedResponse->iteratePages() as $page) {
     *         foreach ($page as $element) {
     *             // doSomethingWith($element);
     *         }
     *     }
     *     // Alternatively:
     *     // Iterate through all elements
     *     $pagedResponse = $tpuClient->listNodes($formattedParent);
     *     foreach ($pagedResponse->iterateAllElements() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $tpuClient->close();
     * }
     * ```
     *
     * @param string $parent       Required. The parent resource name.
     * @param array  $optionalArgs {
     *     Optional.
     *
     *     @type int $pageSize
     *           The maximum number of resources contained in the underlying API
     *           response. The API may return fewer values in a page, even if
     *           there are additional values to be retrieved.
     *     @type string $pageToken
     *           A page token is used to specify a page of values to be returned.
     *           If no page token is specified (the default), the first page
     *           of values will be returned. Any page token used here must have
     *           been generated by a previous call to the API.
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
    public function listNodes($parent, array $optionalArgs = [])
    {
        $request = new ListNodesRequest();
        $requestParamHeaders = [];
        $request->setParent($parent);
        $requestParamHeaders['parent'] = $parent;
        if (isset($optionalArgs['pageSize'])) {
            $request->setPageSize($optionalArgs['pageSize']);
        }

        if (isset($optionalArgs['pageToken'])) {
            $request->setPageToken($optionalArgs['pageToken']);
        }

        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->getPagedListResponse('ListNodes', $optionalArgs, ListNodesResponse::class, $request);
    }

    /**
     * List TensorFlow versions supported by this API.
     *
     * Sample code:
     * ```
     * $tpuClient = new TpuClient();
     * try {
     *     $formattedParent = $tpuClient->tensorFlowVersionName('[PROJECT]', '[LOCATION]', '[TENSOR_FLOW_VERSION]');
     *     // Iterate over pages of elements
     *     $pagedResponse = $tpuClient->listTensorFlowVersions($formattedParent);
     *     foreach ($pagedResponse->iteratePages() as $page) {
     *         foreach ($page as $element) {
     *             // doSomethingWith($element);
     *         }
     *     }
     *     // Alternatively:
     *     // Iterate through all elements
     *     $pagedResponse = $tpuClient->listTensorFlowVersions($formattedParent);
     *     foreach ($pagedResponse->iterateAllElements() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $tpuClient->close();
     * }
     * ```
     *
     * @param string $parent       Required. The parent resource name.
     * @param array  $optionalArgs {
     *     Optional.
     *
     *     @type int $pageSize
     *           The maximum number of resources contained in the underlying API
     *           response. The API may return fewer values in a page, even if
     *           there are additional values to be retrieved.
     *     @type string $pageToken
     *           A page token is used to specify a page of values to be returned.
     *           If no page token is specified (the default), the first page
     *           of values will be returned. Any page token used here must have
     *           been generated by a previous call to the API.
     *     @type string $filter
     *           List filter.
     *     @type string $orderBy
     *           Sort results.
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
    public function listTensorFlowVersions($parent, array $optionalArgs = [])
    {
        $request = new ListTensorFlowVersionsRequest();
        $requestParamHeaders = [];
        $request->setParent($parent);
        $requestParamHeaders['parent'] = $parent;
        if (isset($optionalArgs['pageSize'])) {
            $request->setPageSize($optionalArgs['pageSize']);
        }

        if (isset($optionalArgs['pageToken'])) {
            $request->setPageToken($optionalArgs['pageToken']);
        }

        if (isset($optionalArgs['filter'])) {
            $request->setFilter($optionalArgs['filter']);
        }

        if (isset($optionalArgs['orderBy'])) {
            $request->setOrderBy($optionalArgs['orderBy']);
        }

        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->getPagedListResponse('ListTensorFlowVersions', $optionalArgs, ListTensorFlowVersionsResponse::class, $request);
    }

    /**
     * Reimages a node's OS.
     *
     * Sample code:
     * ```
     * $tpuClient = new TpuClient();
     * try {
     *     $operationResponse = $tpuClient->reimageNode();
     *     $operationResponse->pollUntilComplete();
     *     if ($operationResponse->operationSucceeded()) {
     *         $result = $operationResponse->getResult();
     *     // doSomethingWith($result)
     *     } else {
     *         $error = $operationResponse->getError();
     *         // handleError($error)
     *     }
     *     // Alternatively:
     *     // start the operation, keep the operation name, and resume later
     *     $operationResponse = $tpuClient->reimageNode();
     *     $operationName = $operationResponse->getName();
     *     // ... do other work
     *     $newOperationResponse = $tpuClient->resumeOperation($operationName, 'reimageNode');
     *     while (!$newOperationResponse->isDone()) {
     *         // ... do other work
     *         $newOperationResponse->reload();
     *     }
     *     if ($newOperationResponse->operationSucceeded()) {
     *         $result = $newOperationResponse->getResult();
     *     // doSomethingWith($result)
     *     } else {
     *         $error = $newOperationResponse->getError();
     *         // handleError($error)
     *     }
     * } finally {
     *     $tpuClient->close();
     * }
     * ```
     *
     * @param array $optionalArgs {
     *     Optional.
     *
     *     @type string $name
     *           The resource name.
     *     @type string $tensorflowVersion
     *           The version for reimage to create.
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
    public function reimageNode(array $optionalArgs = [])
    {
        $request = new ReimageNodeRequest();
        $requestParamHeaders = [];
        if (isset($optionalArgs['name'])) {
            $request->setName($optionalArgs['name']);
            $requestParamHeaders['name'] = $optionalArgs['name'];
        }

        if (isset($optionalArgs['tensorflowVersion'])) {
            $request->setTensorflowVersion($optionalArgs['tensorflowVersion']);
        }

        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startOperationsCall('ReimageNode', $optionalArgs, $request, $this->getOperationsClient())->wait();
    }

    /**
     * Starts a node.
     *
     * Sample code:
     * ```
     * $tpuClient = new TpuClient();
     * try {
     *     $operationResponse = $tpuClient->startNode();
     *     $operationResponse->pollUntilComplete();
     *     if ($operationResponse->operationSucceeded()) {
     *         $result = $operationResponse->getResult();
     *     // doSomethingWith($result)
     *     } else {
     *         $error = $operationResponse->getError();
     *         // handleError($error)
     *     }
     *     // Alternatively:
     *     // start the operation, keep the operation name, and resume later
     *     $operationResponse = $tpuClient->startNode();
     *     $operationName = $operationResponse->getName();
     *     // ... do other work
     *     $newOperationResponse = $tpuClient->resumeOperation($operationName, 'startNode');
     *     while (!$newOperationResponse->isDone()) {
     *         // ... do other work
     *         $newOperationResponse->reload();
     *     }
     *     if ($newOperationResponse->operationSucceeded()) {
     *         $result = $newOperationResponse->getResult();
     *     // doSomethingWith($result)
     *     } else {
     *         $error = $newOperationResponse->getError();
     *         // handleError($error)
     *     }
     * } finally {
     *     $tpuClient->close();
     * }
     * ```
     *
     * @param array $optionalArgs {
     *     Optional.
     *
     *     @type string $name
     *           The resource name.
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
    public function startNode(array $optionalArgs = [])
    {
        $request = new StartNodeRequest();
        $requestParamHeaders = [];
        if (isset($optionalArgs['name'])) {
            $request->setName($optionalArgs['name']);
            $requestParamHeaders['name'] = $optionalArgs['name'];
        }

        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startOperationsCall('StartNode', $optionalArgs, $request, $this->getOperationsClient())->wait();
    }

    /**
     * Stops a node.
     *
     * Sample code:
     * ```
     * $tpuClient = new TpuClient();
     * try {
     *     $operationResponse = $tpuClient->stopNode();
     *     $operationResponse->pollUntilComplete();
     *     if ($operationResponse->operationSucceeded()) {
     *         $result = $operationResponse->getResult();
     *     // doSomethingWith($result)
     *     } else {
     *         $error = $operationResponse->getError();
     *         // handleError($error)
     *     }
     *     // Alternatively:
     *     // start the operation, keep the operation name, and resume later
     *     $operationResponse = $tpuClient->stopNode();
     *     $operationName = $operationResponse->getName();
     *     // ... do other work
     *     $newOperationResponse = $tpuClient->resumeOperation($operationName, 'stopNode');
     *     while (!$newOperationResponse->isDone()) {
     *         // ... do other work
     *         $newOperationResponse->reload();
     *     }
     *     if ($newOperationResponse->operationSucceeded()) {
     *         $result = $newOperationResponse->getResult();
     *     // doSomethingWith($result)
     *     } else {
     *         $error = $newOperationResponse->getError();
     *         // handleError($error)
     *     }
     * } finally {
     *     $tpuClient->close();
     * }
     * ```
     *
     * @param array $optionalArgs {
     *     Optional.
     *
     *     @type string $name
     *           The resource name.
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
    public function stopNode(array $optionalArgs = [])
    {
        $request = new StopNodeRequest();
        $requestParamHeaders = [];
        if (isset($optionalArgs['name'])) {
            $request->setName($optionalArgs['name']);
            $requestParamHeaders['name'] = $optionalArgs['name'];
        }

        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startOperationsCall('StopNode', $optionalArgs, $request, $this->getOperationsClient())->wait();
    }
}
