<?php
/*
 * Copyright 2022 Google LLC
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
 * Generated by gapic-generator-php from the file
 * https://github.com/googleapis/googleapis/blob/master/google/cloud/gsuiteaddons/v1/gsuiteaddons.proto
 * Updates to the above are reflected here through a refresh process.
 */

namespace Google\Cloud\GSuiteAddOns\V1\Gapic;

use Google\ApiCore\ApiException;
use Google\ApiCore\CredentialsWrapper;
use Google\ApiCore\GapicClientTrait;

use Google\ApiCore\PathTemplate;
use Google\ApiCore\RequestParamsHeaderDescriptor;
use Google\ApiCore\RetrySettings;
use Google\ApiCore\Transport\TransportInterface;
use Google\ApiCore\ValidationException;
use Google\Auth\FetchAuthTokenInterface;
use Google\Cloud\GSuiteAddOns\V1\Authorization;
use Google\Cloud\GSuiteAddOns\V1\CreateDeploymentRequest;
use Google\Cloud\GSuiteAddOns\V1\DeleteDeploymentRequest;
use Google\Cloud\GSuiteAddOns\V1\Deployment;
use Google\Cloud\GSuiteAddOns\V1\GetAuthorizationRequest;
use Google\Cloud\GSuiteAddOns\V1\GetDeploymentRequest;
use Google\Cloud\GSuiteAddOns\V1\GetInstallStatusRequest;
use Google\Cloud\GSuiteAddOns\V1\InstallDeploymentRequest;
use Google\Cloud\GSuiteAddOns\V1\InstallStatus;
use Google\Cloud\GSuiteAddOns\V1\ListDeploymentsRequest;
use Google\Cloud\GSuiteAddOns\V1\ListDeploymentsResponse;
use Google\Cloud\GSuiteAddOns\V1\ReplaceDeploymentRequest;
use Google\Cloud\GSuiteAddOns\V1\UninstallDeploymentRequest;
use Google\Protobuf\GPBEmpty;

/**
 * Service Description: A service for managing Google Workspace Add-ons deployments.
 *
 * A Google Workspace Add-on is a third-party embedded component that can be
 * installed in Google Workspace Applications like Gmail, Calendar, Drive, and
 * the Google Docs, Sheets, and Slides editors. Google Workspace Add-ons can
 * display UI cards, receive contextual information from the host application,
 * and perform actions in the host application (See:
 * https://developers.google.com/gsuite/add-ons/overview for more information).
 *
 * A Google Workspace Add-on deployment resource specifies metadata about the
 * add-on, including a specification of the entry points in the host application
 * that trigger add-on executions (see:
 * https://developers.google.com/gsuite/add-ons/concepts/gsuite-manifests).
 * Add-on deployments defined via the Google Workspace Add-ons API define their
 * entrypoints using HTTPS URLs (See:
 * https://developers.google.com/gsuite/add-ons/guides/alternate-runtimes),
 *
 * A Google Workspace Add-on deployment can be installed in developer mode,
 * which allows an add-on developer to test the experience an end-user would see
 * when installing and running the add-on in their G Suite applications.  When
 * running in developer mode, more detailed error messages are exposed in the
 * add-on UI to aid in debugging.
 *
 * A Google Workspace Add-on deployment can be published to Google Workspace
 * Marketplace, which allows other Google Workspace users to discover and
 * install the add-on.  See:
 * https://developers.google.com/gsuite/add-ons/how-tos/publish-add-on-overview
 * for details.
 *
 * This class provides the ability to make remote calls to the backing service through method
 * calls that map to API methods. Sample code to get started:
 *
 * ```
 * $gSuiteAddOnsClient = new GSuiteAddOnsClient();
 * try {
 *     $formattedParent = $gSuiteAddOnsClient->projectName('[PROJECT]');
 *     $deploymentId = 'deployment_id';
 *     $deployment = new Deployment();
 *     $response = $gSuiteAddOnsClient->createDeployment($formattedParent, $deploymentId, $deployment);
 * } finally {
 *     $gSuiteAddOnsClient->close();
 * }
 * ```
 *
 * Many parameters require resource names to be formatted in a particular way. To
 * assist with these names, this class includes a format method for each type of
 * name, and additionally a parseName method to extract the individual identifiers
 * contained within formatted names that are returned by the API.
 */
class GSuiteAddOnsGapicClient
{
    use GapicClientTrait;

    /**
     * The name of the service.
     */
    const SERVICE_NAME = 'google.cloud.gsuiteaddons.v1.GSuiteAddOns';

    /**
     * The default address of the service.
     */
    const SERVICE_ADDRESS = 'gsuiteaddons.googleapis.com';

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

    private static $authorizationNameTemplate;

    private static $deploymentNameTemplate;

    private static $installStatusNameTemplate;

    private static $projectNameTemplate;

    private static $pathTemplateMap;

    private static function getClientDefaults()
    {
        return [
            'serviceName' => self::SERVICE_NAME,
            'serviceAddress' => self::SERVICE_ADDRESS . ':' . self::DEFAULT_SERVICE_PORT,
            'clientConfig' => __DIR__ . '/../resources/g_suite_add_ons_client_config.json',
            'descriptorsConfigPath' => __DIR__ . '/../resources/g_suite_add_ons_descriptor_config.php',
            'gcpApiConfigPath' => __DIR__ . '/../resources/g_suite_add_ons_grpc_config.json',
            'credentialsConfig' => [
                'defaultScopes' => self::$serviceScopes,
            ],
            'transportConfig' => [
                'rest' => [
                    'restClientConfigPath' => __DIR__ . '/../resources/g_suite_add_ons_rest_client_config.php',
                ],
            ],
        ];
    }

    private static function getAuthorizationNameTemplate()
    {
        if (self::$authorizationNameTemplate == null) {
            self::$authorizationNameTemplate = new PathTemplate('projects/{project}/authorization');
        }

        return self::$authorizationNameTemplate;
    }

    private static function getDeploymentNameTemplate()
    {
        if (self::$deploymentNameTemplate == null) {
            self::$deploymentNameTemplate = new PathTemplate('projects/{project}/deployments/{deployment}');
        }

        return self::$deploymentNameTemplate;
    }

    private static function getInstallStatusNameTemplate()
    {
        if (self::$installStatusNameTemplate == null) {
            self::$installStatusNameTemplate = new PathTemplate('projects/{project}/deployments/{deployment}/installStatus');
        }

        return self::$installStatusNameTemplate;
    }

    private static function getProjectNameTemplate()
    {
        if (self::$projectNameTemplate == null) {
            self::$projectNameTemplate = new PathTemplate('projects/{project}');
        }

        return self::$projectNameTemplate;
    }

    private static function getPathTemplateMap()
    {
        if (self::$pathTemplateMap == null) {
            self::$pathTemplateMap = [
                'authorization' => self::getAuthorizationNameTemplate(),
                'deployment' => self::getDeploymentNameTemplate(),
                'installStatus' => self::getInstallStatusNameTemplate(),
                'project' => self::getProjectNameTemplate(),
            ];
        }

        return self::$pathTemplateMap;
    }

    /**
     * Formats a string containing the fully-qualified path to represent a
     * authorization resource.
     *
     * @param string $project
     *
     * @return string The formatted authorization resource.
     */
    public static function authorizationName($project)
    {
        return self::getAuthorizationNameTemplate()->render([
            'project' => $project,
        ]);
    }

    /**
     * Formats a string containing the fully-qualified path to represent a deployment
     * resource.
     *
     * @param string $project
     * @param string $deployment
     *
     * @return string The formatted deployment resource.
     */
    public static function deploymentName($project, $deployment)
    {
        return self::getDeploymentNameTemplate()->render([
            'project' => $project,
            'deployment' => $deployment,
        ]);
    }

    /**
     * Formats a string containing the fully-qualified path to represent a
     * install_status resource.
     *
     * @param string $project
     * @param string $deployment
     *
     * @return string The formatted install_status resource.
     */
    public static function installStatusName($project, $deployment)
    {
        return self::getInstallStatusNameTemplate()->render([
            'project' => $project,
            'deployment' => $deployment,
        ]);
    }

    /**
     * Formats a string containing the fully-qualified path to represent a project
     * resource.
     *
     * @param string $project
     *
     * @return string The formatted project resource.
     */
    public static function projectName($project)
    {
        return self::getProjectNameTemplate()->render([
            'project' => $project,
        ]);
    }

    /**
     * Parses a formatted name string and returns an associative array of the components in the name.
     * The following name formats are supported:
     * Template: Pattern
     * - authorization: projects/{project}/authorization
     * - deployment: projects/{project}/deployments/{deployment}
     * - installStatus: projects/{project}/deployments/{deployment}/installStatus
     * - project: projects/{project}
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
     * Constructor.
     *
     * @param array $options {
     *     Optional. Options for configuring the service API wrapper.
     *
     *     @type string $serviceAddress
     *           The address of the API remote host. May optionally include the port, formatted
     *           as "<uri>:<port>". Default 'gsuiteaddons.googleapis.com:443'.
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
     *     @type callable $clientCertSource
     *           A callable which returns the client cert as a string. This can be used to
     *           provide a certificate and private key to the transport layer for mTLS.
     * }
     *
     * @throws ValidationException
     */
    public function __construct(array $options = [])
    {
        $clientOptions = $this->buildClientOptions($options);
        $this->setClientOptions($clientOptions);
    }

    /**
     * Creates a deployment with the specified name and configuration.
     *
     * Sample code:
     * ```
     * $gSuiteAddOnsClient = new GSuiteAddOnsClient();
     * try {
     *     $formattedParent = $gSuiteAddOnsClient->projectName('[PROJECT]');
     *     $deploymentId = 'deployment_id';
     *     $deployment = new Deployment();
     *     $response = $gSuiteAddOnsClient->createDeployment($formattedParent, $deploymentId, $deployment);
     * } finally {
     *     $gSuiteAddOnsClient->close();
     * }
     * ```
     *
     * @param string     $parent       Required. Name of the project in which to create the deployment.
     *
     *                                 Example: `projects/my_project`.
     * @param string     $deploymentId Required. The id to use for this deployment.  The full name of the created
     *                                 resource will be `projects/<project_number>/deployments/<deployment_id>`.
     * @param Deployment $deployment   Required. The deployment to create (deployment.name cannot be set).
     * @param array      $optionalArgs {
     *     Optional.
     *
     *     @type RetrySettings|array $retrySettings
     *           Retry settings to use for this call. Can be a
     *           {@see Google\ApiCore\RetrySettings} object, or an associative array of retry
     *           settings parameters. See the documentation on
     *           {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\GSuiteAddOns\V1\Deployment
     *
     * @throws ApiException if the remote call fails
     */
    public function createDeployment($parent, $deploymentId, $deployment, array $optionalArgs = [])
    {
        $request = new CreateDeploymentRequest();
        $requestParamHeaders = [];
        $request->setParent($parent);
        $request->setDeploymentId($deploymentId);
        $request->setDeployment($deployment);
        $requestParamHeaders['parent'] = $parent;
        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('CreateDeployment', Deployment::class, $optionalArgs, $request)->wait();
    }

    /**
     * Deletes the deployment with the given name.
     *
     * Sample code:
     * ```
     * $gSuiteAddOnsClient = new GSuiteAddOnsClient();
     * try {
     *     $formattedName = $gSuiteAddOnsClient->deploymentName('[PROJECT]', '[DEPLOYMENT]');
     *     $gSuiteAddOnsClient->deleteDeployment($formattedName);
     * } finally {
     *     $gSuiteAddOnsClient->close();
     * }
     * ```
     *
     * @param string $name         Required. The full resource name of the deployment to delete.
     *
     *                             Example:  `projects/my_project/deployments/my_deployment`.
     * @param array  $optionalArgs {
     *     Optional.
     *
     *     @type string $etag
     *           The etag of the deployment to delete.
     *           If this is provided, it must match the server's etag.
     *     @type RetrySettings|array $retrySettings
     *           Retry settings to use for this call. Can be a
     *           {@see Google\ApiCore\RetrySettings} object, or an associative array of retry
     *           settings parameters. See the documentation on
     *           {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @throws ApiException if the remote call fails
     */
    public function deleteDeployment($name, array $optionalArgs = [])
    {
        $request = new DeleteDeploymentRequest();
        $requestParamHeaders = [];
        $request->setName($name);
        $requestParamHeaders['name'] = $name;
        if (isset($optionalArgs['etag'])) {
            $request->setEtag($optionalArgs['etag']);
        }

        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('DeleteDeployment', GPBEmpty::class, $optionalArgs, $request)->wait();
    }

    /**
     * Gets the authorization information for deployments in a given project.
     *
     * Sample code:
     * ```
     * $gSuiteAddOnsClient = new GSuiteAddOnsClient();
     * try {
     *     $formattedName = $gSuiteAddOnsClient->authorizationName('[PROJECT]');
     *     $response = $gSuiteAddOnsClient->getAuthorization($formattedName);
     * } finally {
     *     $gSuiteAddOnsClient->close();
     * }
     * ```
     *
     * @param string $name         Required. Name of the project for which to get the Google Workspace Add-ons
     *                             authorization information.
     *
     *                             Example: `projects/my_project/authorization`.
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
     * @return \Google\Cloud\GSuiteAddOns\V1\Authorization
     *
     * @throws ApiException if the remote call fails
     */
    public function getAuthorization($name, array $optionalArgs = [])
    {
        $request = new GetAuthorizationRequest();
        $requestParamHeaders = [];
        $request->setName($name);
        $requestParamHeaders['name'] = $name;
        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('GetAuthorization', Authorization::class, $optionalArgs, $request)->wait();
    }

    /**
     * Gets the deployment with the specified name.
     *
     * Sample code:
     * ```
     * $gSuiteAddOnsClient = new GSuiteAddOnsClient();
     * try {
     *     $formattedName = $gSuiteAddOnsClient->deploymentName('[PROJECT]', '[DEPLOYMENT]');
     *     $response = $gSuiteAddOnsClient->getDeployment($formattedName);
     * } finally {
     *     $gSuiteAddOnsClient->close();
     * }
     * ```
     *
     * @param string $name         Required. The full resource name of the deployment to get.
     *
     *                             Example:  `projects/my_project/deployments/my_deployment`.
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
     * @return \Google\Cloud\GSuiteAddOns\V1\Deployment
     *
     * @throws ApiException if the remote call fails
     */
    public function getDeployment($name, array $optionalArgs = [])
    {
        $request = new GetDeploymentRequest();
        $requestParamHeaders = [];
        $request->setName($name);
        $requestParamHeaders['name'] = $name;
        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('GetDeployment', Deployment::class, $optionalArgs, $request)->wait();
    }

    /**
     * Fetches the install status of a developer mode deployment.
     *
     * Sample code:
     * ```
     * $gSuiteAddOnsClient = new GSuiteAddOnsClient();
     * try {
     *     $formattedName = $gSuiteAddOnsClient->installStatusName('[PROJECT]', '[DEPLOYMENT]');
     *     $response = $gSuiteAddOnsClient->getInstallStatus($formattedName);
     * } finally {
     *     $gSuiteAddOnsClient->close();
     * }
     * ```
     *
     * @param string $name         Required. The full resource name of the deployment.
     *
     *                             Example:  `projects/my_project/deployments/my_deployment/installStatus`.
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
     * @return \Google\Cloud\GSuiteAddOns\V1\InstallStatus
     *
     * @throws ApiException if the remote call fails
     */
    public function getInstallStatus($name, array $optionalArgs = [])
    {
        $request = new GetInstallStatusRequest();
        $requestParamHeaders = [];
        $request->setName($name);
        $requestParamHeaders['name'] = $name;
        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('GetInstallStatus', InstallStatus::class, $optionalArgs, $request)->wait();
    }

    /**
     * Installs a deployment in developer mode.
     * See:
     * https://developers.google.com/gsuite/add-ons/how-tos/testing-gsuite-addons.
     *
     * Sample code:
     * ```
     * $gSuiteAddOnsClient = new GSuiteAddOnsClient();
     * try {
     *     $formattedName = $gSuiteAddOnsClient->deploymentName('[PROJECT]', '[DEPLOYMENT]');
     *     $gSuiteAddOnsClient->installDeployment($formattedName);
     * } finally {
     *     $gSuiteAddOnsClient->close();
     * }
     * ```
     *
     * @param string $name         Required. The full resource name of the deployment to install.
     *
     *                             Example:  `projects/my_project/deployments/my_deployment`.
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
    public function installDeployment($name, array $optionalArgs = [])
    {
        $request = new InstallDeploymentRequest();
        $requestParamHeaders = [];
        $request->setName($name);
        $requestParamHeaders['name'] = $name;
        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('InstallDeployment', GPBEmpty::class, $optionalArgs, $request)->wait();
    }

    /**
     * Lists all deployments in a particular project.
     *
     * Sample code:
     * ```
     * $gSuiteAddOnsClient = new GSuiteAddOnsClient();
     * try {
     *     $formattedParent = $gSuiteAddOnsClient->projectName('[PROJECT]');
     *     // Iterate over pages of elements
     *     $pagedResponse = $gSuiteAddOnsClient->listDeployments($formattedParent);
     *     foreach ($pagedResponse->iteratePages() as $page) {
     *         foreach ($page as $element) {
     *             // doSomethingWith($element);
     *         }
     *     }
     *     // Alternatively:
     *     // Iterate through all elements
     *     $pagedResponse = $gSuiteAddOnsClient->listDeployments($formattedParent);
     *     foreach ($pagedResponse->iterateAllElements() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $gSuiteAddOnsClient->close();
     * }
     * ```
     *
     * @param string $parent       Required. Name of the project in which to create the deployment.
     *
     *                             Example: `projects/my_project`.
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
    public function listDeployments($parent, array $optionalArgs = [])
    {
        $request = new ListDeploymentsRequest();
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
        return $this->getPagedListResponse('ListDeployments', $optionalArgs, ListDeploymentsResponse::class, $request);
    }

    /**
     * Creates or replaces a deployment with the specified name.
     *
     * Sample code:
     * ```
     * $gSuiteAddOnsClient = new GSuiteAddOnsClient();
     * try {
     *     $deployment = new Deployment();
     *     $response = $gSuiteAddOnsClient->replaceDeployment($deployment);
     * } finally {
     *     $gSuiteAddOnsClient->close();
     * }
     * ```
     *
     * @param Deployment $deployment   Required. The deployment to create or replace.
     * @param array      $optionalArgs {
     *     Optional.
     *
     *     @type RetrySettings|array $retrySettings
     *           Retry settings to use for this call. Can be a
     *           {@see Google\ApiCore\RetrySettings} object, or an associative array of retry
     *           settings parameters. See the documentation on
     *           {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\GSuiteAddOns\V1\Deployment
     *
     * @throws ApiException if the remote call fails
     */
    public function replaceDeployment($deployment, array $optionalArgs = [])
    {
        $request = new ReplaceDeploymentRequest();
        $requestParamHeaders = [];
        $request->setDeployment($deployment);
        $requestParamHeaders['deployment.name'] = $deployment->getName();
        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('ReplaceDeployment', Deployment::class, $optionalArgs, $request)->wait();
    }

    /**
     * Uninstalls a developer mode deployment.
     * See:
     * https://developers.google.com/gsuite/add-ons/how-tos/testing-gsuite-addons.
     *
     * Sample code:
     * ```
     * $gSuiteAddOnsClient = new GSuiteAddOnsClient();
     * try {
     *     $formattedName = $gSuiteAddOnsClient->deploymentName('[PROJECT]', '[DEPLOYMENT]');
     *     $gSuiteAddOnsClient->uninstallDeployment($formattedName);
     * } finally {
     *     $gSuiteAddOnsClient->close();
     * }
     * ```
     *
     * @param string $name         Required. The full resource name of the deployment to install.
     *
     *                             Example:  `projects/my_project/deployments/my_deployment`.
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
    public function uninstallDeployment($name, array $optionalArgs = [])
    {
        $request = new UninstallDeploymentRequest();
        $requestParamHeaders = [];
        $request->setName($name);
        $requestParamHeaders['name'] = $name;
        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('UninstallDeployment', GPBEmpty::class, $optionalArgs, $request)->wait();
    }
}
