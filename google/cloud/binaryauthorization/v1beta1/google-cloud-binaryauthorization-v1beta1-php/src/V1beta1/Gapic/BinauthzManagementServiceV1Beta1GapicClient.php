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
 * https://github.com/google/googleapis/blob/master/google/cloud/binaryauthorization/v1beta1/service.proto
 * and updates to that file get reflected here through a refresh process.
 *
 * @experimental
 */

namespace Google\Cloud\BinaryAuthorization\V1beta1\Gapic;

use Google\ApiCore\ApiException;
use Google\ApiCore\CredentialsWrapper;
use Google\ApiCore\GapicClientTrait;

use Google\ApiCore\PathTemplate;
use Google\ApiCore\RequestParamsHeaderDescriptor;
use Google\ApiCore\RetrySettings;
use Google\ApiCore\Transport\TransportInterface;
use Google\ApiCore\ValidationException;
use Google\Auth\FetchAuthTokenInterface;
use Google\Cloud\BinaryAuthorization\V1beta1\Attestor;
use Google\Cloud\BinaryAuthorization\V1beta1\CreateAttestorRequest;
use Google\Cloud\BinaryAuthorization\V1beta1\DeleteAttestorRequest;
use Google\Cloud\BinaryAuthorization\V1beta1\GetAttestorRequest;
use Google\Cloud\BinaryAuthorization\V1beta1\GetPolicyRequest;
use Google\Cloud\BinaryAuthorization\V1beta1\ListAttestorsRequest;
use Google\Cloud\BinaryAuthorization\V1beta1\ListAttestorsResponse;
use Google\Cloud\BinaryAuthorization\V1beta1\Policy;
use Google\Cloud\BinaryAuthorization\V1beta1\UpdateAttestorRequest;
use Google\Cloud\BinaryAuthorization\V1beta1\UpdatePolicyRequest;
use Google\Protobuf\GPBEmpty;

/**
 * Service Description: Google Cloud Management Service for Binary Authorization admission policies
 * and attestation authorities.
 *
 * This API implements a REST model with the following objects:
 *
 * * [Policy][google.cloud.binaryauthorization.v1beta1.Policy]
 * * [Attestor][google.cloud.binaryauthorization.v1beta1.Attestor]
 *
 * This class provides the ability to make remote calls to the backing service through method
 * calls that map to API methods. Sample code to get started:
 *
 * ```
 * $binauthzManagementServiceV1Beta1Client = new BinauthzManagementServiceV1Beta1Client();
 * try {
 *     $formattedParent = $binauthzManagementServiceV1Beta1Client->projectName('[PROJECT]');
 *     $attestorId = 'attestor_id';
 *     $attestor = new Attestor();
 *     $response = $binauthzManagementServiceV1Beta1Client->createAttestor($formattedParent, $attestorId, $attestor);
 * } finally {
 *     $binauthzManagementServiceV1Beta1Client->close();
 * }
 * ```
 *
 * Many parameters require resource names to be formatted in a particular way. To
 * assistwith these names, this class includes a format method for each type of
 * name, and additionallya parseName method to extract the individual identifiers
 * contained within formatted namesthat are returned by the API.
 */
class BinauthzManagementServiceV1Beta1GapicClient
{
    use GapicClientTrait;

    /**
     * The name of the service.
     */
    const SERVICE_NAME = 'google.cloud.binaryauthorization.v1beta1.BinauthzManagementServiceV1Beta1';

    /**
     * The default address of the service.
     */
    const SERVICE_ADDRESS = 'binaryauthorization.googleapis.com';

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

    private static $attestorNameTemplate;

    private static $policyNameTemplate;

    private static $projectNameTemplate;

    private static $pathTemplateMap;

    private static function getClientDefaults()
    {
        return [
            'serviceName' => self::SERVICE_NAME,
            'serviceAddress' => self::SERVICE_ADDRESS . ':' . self::DEFAULT_SERVICE_PORT,
            'clientConfig' => __DIR__ . '/../resources/binauthz_management_service_v1_beta1_client_config.json',
            'descriptorsConfigPath' => __DIR__ . '/../resources/binauthz_management_service_v1_beta1_descriptor_config.php',
            'gcpApiConfigPath' => __DIR__ . '/../resources/binauthz_management_service_v1_beta1_grpc_config.json',
            'credentialsConfig' => [
                'defaultScopes' => self::$serviceScopes,
            ],
            'transportConfig' => [
                'rest' => [
                    'restClientConfigPath' => __DIR__ . '/../resources/binauthz_management_service_v1_beta1_rest_client_config.php',
                ],
            ],
        ];
    }

    private static function getAttestorNameTemplate()
    {
        if (self::$attestorNameTemplate == null) {
            self::$attestorNameTemplate = new PathTemplate('projects/{project}/attestors/{attestor}');
        }

        return self::$attestorNameTemplate;
    }

    private static function getPolicyNameTemplate()
    {
        if (self::$policyNameTemplate == null) {
            self::$policyNameTemplate = new PathTemplate('projects/{project}/policy');
        }

        return self::$policyNameTemplate;
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
                'attestor' => self::getAttestorNameTemplate(),
                'policy' => self::getPolicyNameTemplate(),
                'project' => self::getProjectNameTemplate(),
            ];
        }

        return self::$pathTemplateMap;
    }

    /**
     * Formats a string containing the fully-qualified path to represent a attestor
     * resource.
     *
     * @param string $project
     * @param string $attestor
     *
     * @return string The formatted attestor resource.
     */
    public static function attestorName($project, $attestor)
    {
        return self::getAttestorNameTemplate()->render([
            'project' => $project,
            'attestor' => $attestor,
        ]);
    }

    /**
     * Formats a string containing the fully-qualified path to represent a policy
     * resource.
     *
     * @param string $project
     *
     * @return string The formatted policy resource.
     */
    public static function policyName($project)
    {
        return self::getPolicyNameTemplate()->render([
            'project' => $project,
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
     * - attestor: projects/{project}/attestors/{attestor}
     * - policy: projects/{project}/policy
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
     *           as "<uri>:<port>". Default 'binaryauthorization.googleapis.com:443'.
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
    }

    /**
     * Creates an [attestor][google.cloud.binaryauthorization.v1beta1.Attestor], and returns a copy of the new
     * [attestor][google.cloud.binaryauthorization.v1beta1.Attestor]. Returns NOT_FOUND if the project does not exist,
     * INVALID_ARGUMENT if the request is malformed, ALREADY_EXISTS if the
     * [attestor][google.cloud.binaryauthorization.v1beta1.Attestor] already exists.
     *
     * Sample code:
     * ```
     * $binauthzManagementServiceV1Beta1Client = new BinauthzManagementServiceV1Beta1Client();
     * try {
     *     $formattedParent = $binauthzManagementServiceV1Beta1Client->projectName('[PROJECT]');
     *     $attestorId = 'attestor_id';
     *     $attestor = new Attestor();
     *     $response = $binauthzManagementServiceV1Beta1Client->createAttestor($formattedParent, $attestorId, $attestor);
     * } finally {
     *     $binauthzManagementServiceV1Beta1Client->close();
     * }
     * ```
     *
     * @param string   $parent       Required. The parent of this [attestor][google.cloud.binaryauthorization.v1beta1.Attestor].
     * @param string   $attestorId   Required. The [attestors][google.cloud.binaryauthorization.v1beta1.Attestor] ID.
     * @param Attestor $attestor     Required. The initial [attestor][google.cloud.binaryauthorization.v1beta1.Attestor] value. The service will
     *                               overwrite the [attestor name][google.cloud.binaryauthorization.v1beta1.Attestor.name] field with the resource name,
     *                               in the format `projects/&#42;/attestors/*`.
     * @param array    $optionalArgs {
     *     Optional.
     *
     *     @type RetrySettings|array $retrySettings
     *           Retry settings to use for this call. Can be a
     *           {@see Google\ApiCore\RetrySettings} object, or an associative array of retry
     *           settings parameters. See the documentation on
     *           {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\BinaryAuthorization\V1beta1\Attestor
     *
     * @throws ApiException if the remote call fails
     */
    public function createAttestor($parent, $attestorId, $attestor, array $optionalArgs = [])
    {
        $request = new CreateAttestorRequest();
        $requestParamHeaders = [];
        $request->setParent($parent);
        $request->setAttestorId($attestorId);
        $request->setAttestor($attestor);
        $requestParamHeaders['parent'] = $parent;
        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('CreateAttestor', Attestor::class, $optionalArgs, $request)->wait();
    }

    /**
     * Deletes an [attestor][google.cloud.binaryauthorization.v1beta1.Attestor]. Returns NOT_FOUND if the
     * [attestor][google.cloud.binaryauthorization.v1beta1.Attestor] does not exist.
     *
     * Sample code:
     * ```
     * $binauthzManagementServiceV1Beta1Client = new BinauthzManagementServiceV1Beta1Client();
     * try {
     *     $formattedName = $binauthzManagementServiceV1Beta1Client->attestorName('[PROJECT]', '[ATTESTOR]');
     *     $binauthzManagementServiceV1Beta1Client->deleteAttestor($formattedName);
     * } finally {
     *     $binauthzManagementServiceV1Beta1Client->close();
     * }
     * ```
     *
     * @param string $name         Required. The name of the [attestors][google.cloud.binaryauthorization.v1beta1.Attestor] to delete, in the format
     *                             `projects/&#42;/attestors/*`.
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
    public function deleteAttestor($name, array $optionalArgs = [])
    {
        $request = new DeleteAttestorRequest();
        $requestParamHeaders = [];
        $request->setName($name);
        $requestParamHeaders['name'] = $name;
        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('DeleteAttestor', GPBEmpty::class, $optionalArgs, $request)->wait();
    }

    /**
     * Gets an [attestor][google.cloud.binaryauthorization.v1beta1.Attestor].
     * Returns NOT_FOUND if the [attestor][google.cloud.binaryauthorization.v1beta1.Attestor] does not exist.
     *
     * Sample code:
     * ```
     * $binauthzManagementServiceV1Beta1Client = new BinauthzManagementServiceV1Beta1Client();
     * try {
     *     $formattedName = $binauthzManagementServiceV1Beta1Client->attestorName('[PROJECT]', '[ATTESTOR]');
     *     $response = $binauthzManagementServiceV1Beta1Client->getAttestor($formattedName);
     * } finally {
     *     $binauthzManagementServiceV1Beta1Client->close();
     * }
     * ```
     *
     * @param string $name         Required. The name of the [attestor][google.cloud.binaryauthorization.v1beta1.Attestor] to retrieve, in the format
     *                             `projects/&#42;/attestors/*`.
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
     * @return \Google\Cloud\BinaryAuthorization\V1beta1\Attestor
     *
     * @throws ApiException if the remote call fails
     */
    public function getAttestor($name, array $optionalArgs = [])
    {
        $request = new GetAttestorRequest();
        $requestParamHeaders = [];
        $request->setName($name);
        $requestParamHeaders['name'] = $name;
        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('GetAttestor', Attestor::class, $optionalArgs, $request)->wait();
    }

    /**
     * A [policy][google.cloud.binaryauthorization.v1beta1.Policy] specifies the [attestors][google.cloud.binaryauthorization.v1beta1.Attestor] that must attest to
     * a container image, before the project is allowed to deploy that
     * image. There is at most one policy per project. All image admission
     * requests are permitted if a project has no policy.
     *
     * Gets the [policy][google.cloud.binaryauthorization.v1beta1.Policy] for this project. Returns a default
     * [policy][google.cloud.binaryauthorization.v1beta1.Policy] if the project does not have one.
     *
     * Sample code:
     * ```
     * $binauthzManagementServiceV1Beta1Client = new BinauthzManagementServiceV1Beta1Client();
     * try {
     *     $formattedName = $binauthzManagementServiceV1Beta1Client->policyName('[PROJECT]');
     *     $response = $binauthzManagementServiceV1Beta1Client->getPolicy($formattedName);
     * } finally {
     *     $binauthzManagementServiceV1Beta1Client->close();
     * }
     * ```
     *
     * @param string $name         Required. The resource name of the [policy][google.cloud.binaryauthorization.v1beta1.Policy] to retrieve,
     *                             in the format `projects/&#42;/policy`.
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
     * @return \Google\Cloud\BinaryAuthorization\V1beta1\Policy
     *
     * @throws ApiException if the remote call fails
     */
    public function getPolicy($name, array $optionalArgs = [])
    {
        $request = new GetPolicyRequest();
        $requestParamHeaders = [];
        $request->setName($name);
        $requestParamHeaders['name'] = $name;
        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('GetPolicy', Policy::class, $optionalArgs, $request)->wait();
    }

    /**
     * Lists [attestors][google.cloud.binaryauthorization.v1beta1.Attestor].
     * Returns INVALID_ARGUMENT if the project does not exist.
     *
     * Sample code:
     * ```
     * $binauthzManagementServiceV1Beta1Client = new BinauthzManagementServiceV1Beta1Client();
     * try {
     *     $formattedParent = $binauthzManagementServiceV1Beta1Client->projectName('[PROJECT]');
     *     // Iterate over pages of elements
     *     $pagedResponse = $binauthzManagementServiceV1Beta1Client->listAttestors($formattedParent);
     *     foreach ($pagedResponse->iteratePages() as $page) {
     *         foreach ($page as $element) {
     *             // doSomethingWith($element);
     *         }
     *     }
     *     // Alternatively:
     *     // Iterate through all elements
     *     $pagedResponse = $binauthzManagementServiceV1Beta1Client->listAttestors($formattedParent);
     *     foreach ($pagedResponse->iterateAllElements() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $binauthzManagementServiceV1Beta1Client->close();
     * }
     * ```
     *
     * @param string $parent       Required. The resource name of the project associated with the
     *                             [attestors][google.cloud.binaryauthorization.v1beta1.Attestor], in the format `projects/*`.
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
    public function listAttestors($parent, array $optionalArgs = [])
    {
        $request = new ListAttestorsRequest();
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
        return $this->getPagedListResponse('ListAttestors', $optionalArgs, ListAttestorsResponse::class, $request);
    }

    /**
     * Updates an [attestor][google.cloud.binaryauthorization.v1beta1.Attestor].
     * Returns NOT_FOUND if the [attestor][google.cloud.binaryauthorization.v1beta1.Attestor] does not exist.
     *
     * Sample code:
     * ```
     * $binauthzManagementServiceV1Beta1Client = new BinauthzManagementServiceV1Beta1Client();
     * try {
     *     $attestor = new Attestor();
     *     $response = $binauthzManagementServiceV1Beta1Client->updateAttestor($attestor);
     * } finally {
     *     $binauthzManagementServiceV1Beta1Client->close();
     * }
     * ```
     *
     * @param Attestor $attestor     Required. The updated [attestor][google.cloud.binaryauthorization.v1beta1.Attestor] value. The service will
     *                               overwrite the [attestor name][google.cloud.binaryauthorization.v1beta1.Attestor.name] field with the resource name
     *                               in the request URL, in the format `projects/&#42;/attestors/*`.
     * @param array    $optionalArgs {
     *     Optional.
     *
     *     @type RetrySettings|array $retrySettings
     *           Retry settings to use for this call. Can be a
     *           {@see Google\ApiCore\RetrySettings} object, or an associative array of retry
     *           settings parameters. See the documentation on
     *           {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\BinaryAuthorization\V1beta1\Attestor
     *
     * @throws ApiException if the remote call fails
     */
    public function updateAttestor($attestor, array $optionalArgs = [])
    {
        $request = new UpdateAttestorRequest();
        $requestParamHeaders = [];
        $request->setAttestor($attestor);
        $requestParamHeaders['attestor.name'] = $attestor->getName();
        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('UpdateAttestor', Attestor::class, $optionalArgs, $request)->wait();
    }

    /**
     * Creates or updates a project's [policy][google.cloud.binaryauthorization.v1beta1.Policy], and returns a copy of the
     * new [policy][google.cloud.binaryauthorization.v1beta1.Policy]. A policy is always updated as a whole, to avoid race
     * conditions with concurrent policy enforcement (or management!)
     * requests. Returns NOT_FOUND if the project does not exist, INVALID_ARGUMENT
     * if the request is malformed.
     *
     * Sample code:
     * ```
     * $binauthzManagementServiceV1Beta1Client = new BinauthzManagementServiceV1Beta1Client();
     * try {
     *     $policy = new Policy();
     *     $response = $binauthzManagementServiceV1Beta1Client->updatePolicy($policy);
     * } finally {
     *     $binauthzManagementServiceV1Beta1Client->close();
     * }
     * ```
     *
     * @param Policy $policy       Required. A new or updated [policy][google.cloud.binaryauthorization.v1beta1.Policy] value. The service will
     *                             overwrite the [policy name][google.cloud.binaryauthorization.v1beta1.Policy.name] field with the resource name in
     *                             the request URL, in the format `projects/&#42;/policy`.
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
     * @return \Google\Cloud\BinaryAuthorization\V1beta1\Policy
     *
     * @throws ApiException if the remote call fails
     */
    public function updatePolicy($policy, array $optionalArgs = [])
    {
        $request = new UpdatePolicyRequest();
        $requestParamHeaders = [];
        $request->setPolicy($policy);
        $requestParamHeaders['policy.name'] = $policy->getName();
        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('UpdatePolicy', Policy::class, $optionalArgs, $request)->wait();
    }
}
