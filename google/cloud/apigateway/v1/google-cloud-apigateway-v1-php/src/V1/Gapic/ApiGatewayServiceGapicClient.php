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
 * https://github.com/google/googleapis/blob/master/google/cloud/apigateway/v1/apigateway_service.proto
 * and updates to that file get reflected here through a refresh process.
 *
 * @experimental
 */

namespace Google\Cloud\Apigateway\V1\Gapic;

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
use Google\Cloud\ApiGateway\V1\Api;
use Google\Cloud\ApiGateway\V1\ApiConfig;
use Google\Cloud\ApiGateway\V1\CreateApiConfigRequest;
use Google\Cloud\ApiGateway\V1\CreateApiRequest;
use Google\Cloud\ApiGateway\V1\CreateGatewayRequest;
use Google\Cloud\ApiGateway\V1\DeleteApiConfigRequest;
use Google\Cloud\ApiGateway\V1\DeleteApiRequest;
use Google\Cloud\ApiGateway\V1\DeleteGatewayRequest;
use Google\Cloud\ApiGateway\V1\Gateway;
use Google\Cloud\ApiGateway\V1\GetApiConfigRequest;
use Google\Cloud\ApiGateway\V1\GetApiRequest;
use Google\Cloud\ApiGateway\V1\GetGatewayRequest;
use Google\Cloud\ApiGateway\V1\ListApiConfigsRequest;
use Google\Cloud\ApiGateway\V1\ListApiConfigsResponse;
use Google\Cloud\ApiGateway\V1\ListApisRequest;
use Google\Cloud\ApiGateway\V1\ListApisResponse;
use Google\Cloud\ApiGateway\V1\ListGatewaysRequest;
use Google\Cloud\ApiGateway\V1\ListGatewaysResponse;
use Google\Cloud\ApiGateway\V1\UpdateApiConfigRequest;
use Google\Cloud\ApiGateway\V1\UpdateApiRequest;
use Google\Cloud\ApiGateway\V1\UpdateGatewayRequest;
use Google\LongRunning\Operation;
use Google\Protobuf\FieldMask;

/**
 * Service Description: The API Gateway Service is the interface for managing API Gateways.
 *
 * This class provides the ability to make remote calls to the backing service through method
 * calls that map to API methods. Sample code to get started:
 *
 * ```
 * $apiGatewayServiceClient = new ApiGatewayServiceClient();
 * try {
 *     $formattedParent = $apiGatewayServiceClient->locationName('[PROJECT]', '[LOCATION]');
 *     // Iterate over pages of elements
 *     $pagedResponse = $apiGatewayServiceClient->listGateways($formattedParent);
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
 *     $pagedResponse = $apiGatewayServiceClient->listGateways($formattedParent);
 *     foreach ($pagedResponse->iterateAllElements() as $element) {
 *         // doSomethingWith($element);
 *     }
 * } finally {
 *     $apiGatewayServiceClient->close();
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
class ApiGatewayServiceGapicClient
{
    use GapicClientTrait;

    /**
     * The name of the service.
     */
    const SERVICE_NAME = 'google.cloud.apigateway.v1.ApiGatewayService';

    /**
     * The default address of the service.
     */
    const SERVICE_ADDRESS = 'apigateway.googleapis.com';

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
    private static $apiNameTemplate;
    private static $apiConfigNameTemplate;
    private static $gatewayNameTemplate;
    private static $locationNameTemplate;
    private static $managedServiceNameTemplate;
    private static $serviceNameTemplate;
    private static $serviceAccountNameTemplate;
    private static $pathTemplateMap;

    private $operationsClient;

    private static function getClientDefaults()
    {
        return [
            'serviceName' => self::SERVICE_NAME,
            'serviceAddress' => self::SERVICE_ADDRESS.':'.self::DEFAULT_SERVICE_PORT,
            'clientConfig' => __DIR__.'/../resources/api_gateway_service_client_config.json',
            'descriptorsConfigPath' => __DIR__.'/../resources/api_gateway_service_descriptor_config.php',
            'gcpApiConfigPath' => __DIR__.'/../resources/api_gateway_service_grpc_config.json',
            'credentialsConfig' => [
                'defaultScopes' => self::$serviceScopes,
            ],
            'transportConfig' => [
                'rest' => [
                    'restClientConfigPath' => __DIR__.'/../resources/api_gateway_service_rest_client_config.php',
                ],
            ],
        ];
    }

    private static function getApiNameTemplate()
    {
        if (null == self::$apiNameTemplate) {
            self::$apiNameTemplate = new PathTemplate('projects/{project}/locations/global/apis/{api}');
        }

        return self::$apiNameTemplate;
    }

    private static function getApiConfigNameTemplate()
    {
        if (null == self::$apiConfigNameTemplate) {
            self::$apiConfigNameTemplate = new PathTemplate('projects/{project}/locations/global/apis/{api}/configs/{api_config}');
        }

        return self::$apiConfigNameTemplate;
    }

    private static function getGatewayNameTemplate()
    {
        if (null == self::$gatewayNameTemplate) {
            self::$gatewayNameTemplate = new PathTemplate('projects/{project}/locations/{location}/gateways/{gateway}');
        }

        return self::$gatewayNameTemplate;
    }

    private static function getLocationNameTemplate()
    {
        if (null == self::$locationNameTemplate) {
            self::$locationNameTemplate = new PathTemplate('projects/{project}/locations/{location}');
        }

        return self::$locationNameTemplate;
    }

    private static function getManagedServiceNameTemplate()
    {
        if (null == self::$managedServiceNameTemplate) {
            self::$managedServiceNameTemplate = new PathTemplate('services/{service}');
        }

        return self::$managedServiceNameTemplate;
    }

    private static function getServiceNameTemplate()
    {
        if (null == self::$serviceNameTemplate) {
            self::$serviceNameTemplate = new PathTemplate('services/{service}/configs/{config}');
        }

        return self::$serviceNameTemplate;
    }

    private static function getServiceAccountNameTemplate()
    {
        if (null == self::$serviceAccountNameTemplate) {
            self::$serviceAccountNameTemplate = new PathTemplate('projects/{project}/serviceAccounts/{service_account}');
        }

        return self::$serviceAccountNameTemplate;
    }

    private static function getPathTemplateMap()
    {
        if (null == self::$pathTemplateMap) {
            self::$pathTemplateMap = [
                'api' => self::getApiNameTemplate(),
                'apiConfig' => self::getApiConfigNameTemplate(),
                'gateway' => self::getGatewayNameTemplate(),
                'location' => self::getLocationNameTemplate(),
                'managedService' => self::getManagedServiceNameTemplate(),
                'service' => self::getServiceNameTemplate(),
                'serviceAccount' => self::getServiceAccountNameTemplate(),
            ];
        }

        return self::$pathTemplateMap;
    }

    /**
     * Formats a string containing the fully-qualified path to represent
     * a api resource.
     *
     * @param string $project
     * @param string $api
     *
     * @return string The formatted api resource.
     * @experimental
     */
    public static function apiName($project, $api)
    {
        return self::getApiNameTemplate()->render([
            'project' => $project,
            'api' => $api,
        ]);
    }

    /**
     * Formats a string containing the fully-qualified path to represent
     * a api_config resource.
     *
     * @param string $project
     * @param string $api
     * @param string $apiConfig
     *
     * @return string The formatted api_config resource.
     * @experimental
     */
    public static function apiConfigName($project, $api, $apiConfig)
    {
        return self::getApiConfigNameTemplate()->render([
            'project' => $project,
            'api' => $api,
            'api_config' => $apiConfig,
        ]);
    }

    /**
     * Formats a string containing the fully-qualified path to represent
     * a gateway resource.
     *
     * @param string $project
     * @param string $location
     * @param string $gateway
     *
     * @return string The formatted gateway resource.
     * @experimental
     */
    public static function gatewayName($project, $location, $gateway)
    {
        return self::getGatewayNameTemplate()->render([
            'project' => $project,
            'location' => $location,
            'gateway' => $gateway,
        ]);
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
     * a managed_service resource.
     *
     * @param string $service
     *
     * @return string The formatted managed_service resource.
     * @experimental
     */
    public static function managedServiceName($service)
    {
        return self::getManagedServiceNameTemplate()->render([
            'service' => $service,
        ]);
    }

    /**
     * Formats a string containing the fully-qualified path to represent
     * a service resource.
     *
     * @param string $service
     * @param string $config
     *
     * @return string The formatted service resource.
     * @experimental
     */
    public static function serviceName($service, $config)
    {
        return self::getServiceNameTemplate()->render([
            'service' => $service,
            'config' => $config,
        ]);
    }

    /**
     * Formats a string containing the fully-qualified path to represent
     * a service_account resource.
     *
     * @param string $project
     * @param string $serviceAccount
     *
     * @return string The formatted service_account resource.
     * @experimental
     */
    public static function serviceAccountName($project, $serviceAccount)
    {
        return self::getServiceAccountNameTemplate()->render([
            'project' => $project,
            'service_account' => $serviceAccount,
        ]);
    }

    /**
     * Parses a formatted name string and returns an associative array of the components in the name.
     * The following name formats are supported:
     * Template: Pattern
     * - api: projects/{project}/locations/global/apis/{api}
     * - apiConfig: projects/{project}/locations/global/apis/{api}/configs/{api_config}
     * - gateway: projects/{project}/locations/{location}/gateways/{gateway}
     * - location: projects/{project}/locations/{location}
     * - managedService: services/{service}
     * - service: services/{service}/configs/{config}
     * - serviceAccount: projects/{project}/serviceAccounts/{service_account}.
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
     *           as "<uri>:<port>". Default 'apigateway.googleapis.com:443'.
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
     * Lists Gateways in a given project and location.
     *
     * Sample code:
     * ```
     * $apiGatewayServiceClient = new ApiGatewayServiceClient();
     * try {
     *     $formattedParent = $apiGatewayServiceClient->locationName('[PROJECT]', '[LOCATION]');
     *     // Iterate over pages of elements
     *     $pagedResponse = $apiGatewayServiceClient->listGateways($formattedParent);
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
     *     $pagedResponse = $apiGatewayServiceClient->listGateways($formattedParent);
     *     foreach ($pagedResponse->iterateAllElements() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $apiGatewayServiceClient->close();
     * }
     * ```
     *
     * @param string $parent       Required. Parent resource of the Gateway, of the form:
     *                             `projects/&#42;/locations/*`
     * @param array  $optionalArgs {
     *                             Optional.
     *
     *     @type int $pageSize
     *          The maximum number of resources contained in the underlying API
     *          response. The API may return fewer values in a page, even if
     *          there are additional values to be retrieved.
     *     @type string $pageToken
     *          A page token is used to specify a page of values to be returned.
     *          If no page token is specified (the default), the first page
     *          of values will be returned. Any page token used here must have
     *          been generated by a previous call to the API.
     *     @type string $filter
     *          Filter.
     *     @type string $orderBy
     *          Order by parameters.
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
    public function listGateways($parent, array $optionalArgs = [])
    {
        $request = new ListGatewaysRequest();
        $request->setParent($parent);
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

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->getPagedListResponse(
            'ListGateways',
            $optionalArgs,
            ListGatewaysResponse::class,
            $request
        );
    }

    /**
     * Gets details of a single Gateway.
     *
     * Sample code:
     * ```
     * $apiGatewayServiceClient = new ApiGatewayServiceClient();
     * try {
     *     $formattedName = $apiGatewayServiceClient->gatewayName('[PROJECT]', '[LOCATION]', '[GATEWAY]');
     *     $response = $apiGatewayServiceClient->getGateway($formattedName);
     * } finally {
     *     $apiGatewayServiceClient->close();
     * }
     * ```
     *
     * @param string $name         Required. Resource name of the form:
     *                             `projects/&#42;/locations/&#42;/gateways/*`
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
     * @return \Google\Cloud\ApiGateway\V1\Gateway
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function getGateway($name, array $optionalArgs = [])
    {
        $request = new GetGatewayRequest();
        $request->setName($name);

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'GetGateway',
            Gateway::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Creates a new Gateway in a given project and location.
     *
     * Sample code:
     * ```
     * $apiGatewayServiceClient = new ApiGatewayServiceClient();
     * try {
     *     $formattedParent = $apiGatewayServiceClient->locationName('[PROJECT]', '[LOCATION]');
     *     $gatewayId = '';
     *     $gateway = new Gateway();
     *     $operationResponse = $apiGatewayServiceClient->createGateway($formattedParent, $gatewayId, $gateway);
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
     *     $operationResponse = $apiGatewayServiceClient->createGateway($formattedParent, $gatewayId, $gateway);
     *     $operationName = $operationResponse->getName();
     *     // ... do other work
     *     $newOperationResponse = $apiGatewayServiceClient->resumeOperation($operationName, 'createGateway');
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
     *     $apiGatewayServiceClient->close();
     * }
     * ```
     *
     * @param string  $parent       Required. Parent resource of the Gateway, of the form:
     *                              `projects/&#42;/locations/*`
     * @param string  $gatewayId    Required. Identifier to assign to the Gateway. Must be unique within scope of
     *                              the parent resource.
     * @param Gateway $gateway      Required. Gateway resource.
     * @param array   $optionalArgs {
     *                              Optional.
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
    public function createGateway($parent, $gatewayId, $gateway, array $optionalArgs = [])
    {
        $request = new CreateGatewayRequest();
        $request->setParent($parent);
        $request->setGatewayId($gatewayId);
        $request->setGateway($gateway);

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startOperationsCall(
            'CreateGateway',
            $optionalArgs,
            $request,
            $this->getOperationsClient()
        )->wait();
    }

    /**
     * Updates the parameters of a single Gateway.
     *
     * Sample code:
     * ```
     * $apiGatewayServiceClient = new ApiGatewayServiceClient();
     * try {
     *     $gateway = new Gateway();
     *     $operationResponse = $apiGatewayServiceClient->updateGateway($gateway);
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
     *     $operationResponse = $apiGatewayServiceClient->updateGateway($gateway);
     *     $operationName = $operationResponse->getName();
     *     // ... do other work
     *     $newOperationResponse = $apiGatewayServiceClient->resumeOperation($operationName, 'updateGateway');
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
     *     $apiGatewayServiceClient->close();
     * }
     * ```
     *
     * @param Gateway $gateway      Required. Gateway resource.
     * @param array   $optionalArgs {
     *                              Optional.
     *
     *     @type FieldMask $updateMask
     *          Field mask is used to specify the fields to be overwritten in the
     *          Gateway resource by the update.
     *          The fields specified in the update_mask are relative to the resource, not
     *          the full request. A field will be overwritten if it is in the mask. If the
     *          user does not provide a mask then all fields will be overwritten.
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
    public function updateGateway($gateway, array $optionalArgs = [])
    {
        $request = new UpdateGatewayRequest();
        $request->setGateway($gateway);
        if (isset($optionalArgs['updateMask'])) {
            $request->setUpdateMask($optionalArgs['updateMask']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'gateway.name' => $request->getGateway()->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startOperationsCall(
            'UpdateGateway',
            $optionalArgs,
            $request,
            $this->getOperationsClient()
        )->wait();
    }

    /**
     * Deletes a single Gateway.
     *
     * Sample code:
     * ```
     * $apiGatewayServiceClient = new ApiGatewayServiceClient();
     * try {
     *     $formattedName = $apiGatewayServiceClient->gatewayName('[PROJECT]', '[LOCATION]', '[GATEWAY]');
     *     $operationResponse = $apiGatewayServiceClient->deleteGateway($formattedName);
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
     *     $operationResponse = $apiGatewayServiceClient->deleteGateway($formattedName);
     *     $operationName = $operationResponse->getName();
     *     // ... do other work
     *     $newOperationResponse = $apiGatewayServiceClient->resumeOperation($operationName, 'deleteGateway');
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
     *     $apiGatewayServiceClient->close();
     * }
     * ```
     *
     * @param string $name         Required. Resource name of the form:
     *                             `projects/&#42;/locations/&#42;/gateways/*`
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
    public function deleteGateway($name, array $optionalArgs = [])
    {
        $request = new DeleteGatewayRequest();
        $request->setName($name);

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startOperationsCall(
            'DeleteGateway',
            $optionalArgs,
            $request,
            $this->getOperationsClient()
        )->wait();
    }

    /**
     * Lists Apis in a given project and location.
     *
     * Sample code:
     * ```
     * $apiGatewayServiceClient = new ApiGatewayServiceClient();
     * try {
     *     $formattedParent = $apiGatewayServiceClient->locationName('[PROJECT]', '[LOCATION]');
     *     // Iterate over pages of elements
     *     $pagedResponse = $apiGatewayServiceClient->listApis($formattedParent);
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
     *     $pagedResponse = $apiGatewayServiceClient->listApis($formattedParent);
     *     foreach ($pagedResponse->iterateAllElements() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $apiGatewayServiceClient->close();
     * }
     * ```
     *
     * @param string $parent       Required. Parent resource of the API, of the form:
     *                             `projects/&#42;/locations/global`
     * @param array  $optionalArgs {
     *                             Optional.
     *
     *     @type int $pageSize
     *          The maximum number of resources contained in the underlying API
     *          response. The API may return fewer values in a page, even if
     *          there are additional values to be retrieved.
     *     @type string $pageToken
     *          A page token is used to specify a page of values to be returned.
     *          If no page token is specified (the default), the first page
     *          of values will be returned. Any page token used here must have
     *          been generated by a previous call to the API.
     *     @type string $filter
     *          Filter.
     *     @type string $orderBy
     *          Order by parameters.
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
    public function listApis($parent, array $optionalArgs = [])
    {
        $request = new ListApisRequest();
        $request->setParent($parent);
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

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->getPagedListResponse(
            'ListApis',
            $optionalArgs,
            ListApisResponse::class,
            $request
        );
    }

    /**
     * Gets details of a single Api.
     *
     * Sample code:
     * ```
     * $apiGatewayServiceClient = new ApiGatewayServiceClient();
     * try {
     *     $formattedName = $apiGatewayServiceClient->apiName('[PROJECT]', '[API]');
     *     $response = $apiGatewayServiceClient->getApi($formattedName);
     * } finally {
     *     $apiGatewayServiceClient->close();
     * }
     * ```
     *
     * @param string $name         Required. Resource name of the form:
     *                             `projects/&#42;/locations/global/apis/*`
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
     * @return \Google\Cloud\ApiGateway\V1\Api
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function getApi($name, array $optionalArgs = [])
    {
        $request = new GetApiRequest();
        $request->setName($name);

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'GetApi',
            Api::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Creates a new Api in a given project and location.
     *
     * Sample code:
     * ```
     * $apiGatewayServiceClient = new ApiGatewayServiceClient();
     * try {
     *     $formattedParent = $apiGatewayServiceClient->locationName('[PROJECT]', '[LOCATION]');
     *     $apiId = '';
     *     $api = new Api();
     *     $operationResponse = $apiGatewayServiceClient->createApi($formattedParent, $apiId, $api);
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
     *     $operationResponse = $apiGatewayServiceClient->createApi($formattedParent, $apiId, $api);
     *     $operationName = $operationResponse->getName();
     *     // ... do other work
     *     $newOperationResponse = $apiGatewayServiceClient->resumeOperation($operationName, 'createApi');
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
     *     $apiGatewayServiceClient->close();
     * }
     * ```
     *
     * @param string $parent       Required. Parent resource of the API, of the form:
     *                             `projects/&#42;/locations/global`
     * @param string $apiId        Required. Identifier to assign to the API. Must be unique within scope of
     *                             the parent resource.
     * @param Api    $api          Required. API resource.
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
    public function createApi($parent, $apiId, $api, array $optionalArgs = [])
    {
        $request = new CreateApiRequest();
        $request->setParent($parent);
        $request->setApiId($apiId);
        $request->setApi($api);

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startOperationsCall(
            'CreateApi',
            $optionalArgs,
            $request,
            $this->getOperationsClient()
        )->wait();
    }

    /**
     * Updates the parameters of a single Api.
     *
     * Sample code:
     * ```
     * $apiGatewayServiceClient = new ApiGatewayServiceClient();
     * try {
     *     $api = new Api();
     *     $operationResponse = $apiGatewayServiceClient->updateApi($api);
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
     *     $operationResponse = $apiGatewayServiceClient->updateApi($api);
     *     $operationName = $operationResponse->getName();
     *     // ... do other work
     *     $newOperationResponse = $apiGatewayServiceClient->resumeOperation($operationName, 'updateApi');
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
     *     $apiGatewayServiceClient->close();
     * }
     * ```
     *
     * @param Api   $api          Required. API resource.
     * @param array $optionalArgs {
     *                            Optional.
     *
     *     @type FieldMask $updateMask
     *          Field mask is used to specify the fields to be overwritten in the
     *          Api resource by the update.
     *          The fields specified in the update_mask are relative to the resource, not
     *          the full request. A field will be overwritten if it is in the mask. If the
     *          user does not provide a mask then all fields will be overwritten.
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
    public function updateApi($api, array $optionalArgs = [])
    {
        $request = new UpdateApiRequest();
        $request->setApi($api);
        if (isset($optionalArgs['updateMask'])) {
            $request->setUpdateMask($optionalArgs['updateMask']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'api.name' => $request->getApi()->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startOperationsCall(
            'UpdateApi',
            $optionalArgs,
            $request,
            $this->getOperationsClient()
        )->wait();
    }

    /**
     * Deletes a single Api.
     *
     * Sample code:
     * ```
     * $apiGatewayServiceClient = new ApiGatewayServiceClient();
     * try {
     *     $formattedName = $apiGatewayServiceClient->apiName('[PROJECT]', '[API]');
     *     $operationResponse = $apiGatewayServiceClient->deleteApi($formattedName);
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
     *     $operationResponse = $apiGatewayServiceClient->deleteApi($formattedName);
     *     $operationName = $operationResponse->getName();
     *     // ... do other work
     *     $newOperationResponse = $apiGatewayServiceClient->resumeOperation($operationName, 'deleteApi');
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
     *     $apiGatewayServiceClient->close();
     * }
     * ```
     *
     * @param string $name         Required. Resource name of the form:
     *                             `projects/&#42;/locations/global/apis/*`
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
    public function deleteApi($name, array $optionalArgs = [])
    {
        $request = new DeleteApiRequest();
        $request->setName($name);

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startOperationsCall(
            'DeleteApi',
            $optionalArgs,
            $request,
            $this->getOperationsClient()
        )->wait();
    }

    /**
     * Lists ApiConfigs in a given project and location.
     *
     * Sample code:
     * ```
     * $apiGatewayServiceClient = new ApiGatewayServiceClient();
     * try {
     *     $formattedParent = $apiGatewayServiceClient->apiName('[PROJECT]', '[API]');
     *     // Iterate over pages of elements
     *     $pagedResponse = $apiGatewayServiceClient->listApiConfigs($formattedParent);
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
     *     $pagedResponse = $apiGatewayServiceClient->listApiConfigs($formattedParent);
     *     foreach ($pagedResponse->iterateAllElements() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $apiGatewayServiceClient->close();
     * }
     * ```
     *
     * @param string $parent       Required. Parent resource of the API Config, of the form:
     *                             `projects/&#42;/locations/global/apis/*`
     * @param array  $optionalArgs {
     *                             Optional.
     *
     *     @type int $pageSize
     *          The maximum number of resources contained in the underlying API
     *          response. The API may return fewer values in a page, even if
     *          there are additional values to be retrieved.
     *     @type string $pageToken
     *          A page token is used to specify a page of values to be returned.
     *          If no page token is specified (the default), the first page
     *          of values will be returned. Any page token used here must have
     *          been generated by a previous call to the API.
     *     @type string $filter
     *          Filter.
     *     @type string $orderBy
     *          Order by parameters.
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
    public function listApiConfigs($parent, array $optionalArgs = [])
    {
        $request = new ListApiConfigsRequest();
        $request->setParent($parent);
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

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->getPagedListResponse(
            'ListApiConfigs',
            $optionalArgs,
            ListApiConfigsResponse::class,
            $request
        );
    }

    /**
     * Gets details of a single ApiConfig.
     *
     * Sample code:
     * ```
     * $apiGatewayServiceClient = new ApiGatewayServiceClient();
     * try {
     *     $formattedName = $apiGatewayServiceClient->apiConfigName('[PROJECT]', '[API]', '[API_CONFIG]');
     *     $response = $apiGatewayServiceClient->getApiConfig($formattedName);
     * } finally {
     *     $apiGatewayServiceClient->close();
     * }
     * ```
     *
     * @param string $name         Required. Resource name of the form:
     *                             `projects/&#42;/locations/global/apis/&#42;/configs/*`
     * @param array  $optionalArgs {
     *                             Optional.
     *
     *     @type int $view
     *          Specifies which fields of the API Config are returned in the response.
     *          Defaults to `BASIC` view.
     *          For allowed values, use constants defined on {@see \Google\Cloud\ApiGateway\V1\GetApiConfigRequest\ConfigView}
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\ApiGateway\V1\ApiConfig
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function getApiConfig($name, array $optionalArgs = [])
    {
        $request = new GetApiConfigRequest();
        $request->setName($name);
        if (isset($optionalArgs['view'])) {
            $request->setView($optionalArgs['view']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'GetApiConfig',
            ApiConfig::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Creates a new ApiConfig in a given project and location.
     *
     * Sample code:
     * ```
     * $apiGatewayServiceClient = new ApiGatewayServiceClient();
     * try {
     *     $formattedParent = $apiGatewayServiceClient->apiName('[PROJECT]', '[API]');
     *     $apiConfigId = '';
     *     $apiConfig = new ApiConfig();
     *     $operationResponse = $apiGatewayServiceClient->createApiConfig($formattedParent, $apiConfigId, $apiConfig);
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
     *     $operationResponse = $apiGatewayServiceClient->createApiConfig($formattedParent, $apiConfigId, $apiConfig);
     *     $operationName = $operationResponse->getName();
     *     // ... do other work
     *     $newOperationResponse = $apiGatewayServiceClient->resumeOperation($operationName, 'createApiConfig');
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
     *     $apiGatewayServiceClient->close();
     * }
     * ```
     *
     * @param string    $parent       Required. Parent resource of the API Config, of the form:
     *                                `projects/&#42;/locations/global/apis/*`
     * @param string    $apiConfigId  Required. Identifier to assign to the API Config. Must be unique within scope of
     *                                the parent resource.
     * @param ApiConfig $apiConfig    Required. API resource.
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
     * @return \Google\ApiCore\OperationResponse
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function createApiConfig($parent, $apiConfigId, $apiConfig, array $optionalArgs = [])
    {
        $request = new CreateApiConfigRequest();
        $request->setParent($parent);
        $request->setApiConfigId($apiConfigId);
        $request->setApiConfig($apiConfig);

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startOperationsCall(
            'CreateApiConfig',
            $optionalArgs,
            $request,
            $this->getOperationsClient()
        )->wait();
    }

    /**
     * Updates the parameters of a single ApiConfig.
     *
     * Sample code:
     * ```
     * $apiGatewayServiceClient = new ApiGatewayServiceClient();
     * try {
     *     $apiConfig = new ApiConfig();
     *     $operationResponse = $apiGatewayServiceClient->updateApiConfig($apiConfig);
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
     *     $operationResponse = $apiGatewayServiceClient->updateApiConfig($apiConfig);
     *     $operationName = $operationResponse->getName();
     *     // ... do other work
     *     $newOperationResponse = $apiGatewayServiceClient->resumeOperation($operationName, 'updateApiConfig');
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
     *     $apiGatewayServiceClient->close();
     * }
     * ```
     *
     * @param ApiConfig $apiConfig    Required. API Config resource.
     * @param array     $optionalArgs {
     *                                Optional.
     *
     *     @type FieldMask $updateMask
     *          Field mask is used to specify the fields to be overwritten in the
     *          ApiConfig resource by the update.
     *          The fields specified in the update_mask are relative to the resource, not
     *          the full request. A field will be overwritten if it is in the mask. If the
     *          user does not provide a mask then all fields will be overwritten.
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
    public function updateApiConfig($apiConfig, array $optionalArgs = [])
    {
        $request = new UpdateApiConfigRequest();
        $request->setApiConfig($apiConfig);
        if (isset($optionalArgs['updateMask'])) {
            $request->setUpdateMask($optionalArgs['updateMask']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'api_config.name' => $request->getApiConfig()->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startOperationsCall(
            'UpdateApiConfig',
            $optionalArgs,
            $request,
            $this->getOperationsClient()
        )->wait();
    }

    /**
     * Deletes a single ApiConfig.
     *
     * Sample code:
     * ```
     * $apiGatewayServiceClient = new ApiGatewayServiceClient();
     * try {
     *     $formattedName = $apiGatewayServiceClient->apiConfigName('[PROJECT]', '[API]', '[API_CONFIG]');
     *     $operationResponse = $apiGatewayServiceClient->deleteApiConfig($formattedName);
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
     *     $operationResponse = $apiGatewayServiceClient->deleteApiConfig($formattedName);
     *     $operationName = $operationResponse->getName();
     *     // ... do other work
     *     $newOperationResponse = $apiGatewayServiceClient->resumeOperation($operationName, 'deleteApiConfig');
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
     *     $apiGatewayServiceClient->close();
     * }
     * ```
     *
     * @param string $name         Required. Resource name of the form:
     *                             `projects/&#42;/locations/global/apis/&#42;/configs/*`
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
    public function deleteApiConfig($name, array $optionalArgs = [])
    {
        $request = new DeleteApiConfigRequest();
        $request->setName($name);

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startOperationsCall(
            'DeleteApiConfig',
            $optionalArgs,
            $request,
            $this->getOperationsClient()
        )->wait();
    }
}
