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
 * https://github.com/google/googleapis/blob/master/google/cloud/osconfig/v1beta/osconfig_service.proto
 * and updates to that file get reflected here through a refresh process.
 *
 * @experimental
 */

namespace Google\Cloud\Osconfig\V1beta\Gapic;

use Google\ApiCore\ApiException;
use Google\ApiCore\CredentialsWrapper;
use Google\ApiCore\GapicClientTrait;

use Google\ApiCore\PathTemplate;
use Google\ApiCore\RequestParamsHeaderDescriptor;
use Google\ApiCore\RetrySettings;
use Google\ApiCore\Transport\TransportInterface;
use Google\ApiCore\ValidationException;
use Google\Auth\FetchAuthTokenInterface;
use Google\Cloud\Osconfig\V1beta\CancelPatchJobRequest;
use Google\Cloud\Osconfig\V1beta\CreateGuestPolicyRequest;
use Google\Cloud\Osconfig\V1beta\CreatePatchDeploymentRequest;
use Google\Cloud\Osconfig\V1beta\DeleteGuestPolicyRequest;
use Google\Cloud\Osconfig\V1beta\DeletePatchDeploymentRequest;
use Google\Cloud\Osconfig\V1beta\EffectiveGuestPolicy;
use Google\Cloud\Osconfig\V1beta\ExecutePatchJobRequest;
use Google\Cloud\Osconfig\V1beta\GetGuestPolicyRequest;
use Google\Cloud\Osconfig\V1beta\GetPatchDeploymentRequest;
use Google\Cloud\Osconfig\V1beta\GetPatchJobRequest;
use Google\Cloud\Osconfig\V1beta\GuestPolicy;
use Google\Cloud\Osconfig\V1beta\ListGuestPoliciesRequest;
use Google\Cloud\Osconfig\V1beta\ListGuestPoliciesResponse;
use Google\Cloud\Osconfig\V1beta\ListPatchDeploymentsRequest;
use Google\Cloud\Osconfig\V1beta\ListPatchDeploymentsResponse;
use Google\Cloud\Osconfig\V1beta\ListPatchJobInstanceDetailsRequest;
use Google\Cloud\Osconfig\V1beta\ListPatchJobInstanceDetailsResponse;
use Google\Cloud\Osconfig\V1beta\ListPatchJobsRequest;
use Google\Cloud\Osconfig\V1beta\ListPatchJobsResponse;
use Google\Cloud\Osconfig\V1beta\LookupEffectiveGuestPolicyRequest;
use Google\Cloud\Osconfig\V1beta\PatchConfig;
use Google\Cloud\Osconfig\V1beta\PatchDeployment;
use Google\Cloud\Osconfig\V1beta\PatchInstanceFilter;
use Google\Cloud\Osconfig\V1beta\PatchJob;
use Google\Cloud\Osconfig\V1beta\UpdateGuestPolicyRequest;
use Google\Protobuf\Duration;
use Google\Protobuf\FieldMask;
use Google\Protobuf\GPBEmpty;

/**
 * Service Description: OS Config API
 *
 * The OS Config service is a server-side component that you can use to
 * manage package installations and patch jobs for virtual machine instances.
 *
 * This class provides the ability to make remote calls to the backing service through method
 * calls that map to API methods. Sample code to get started:
 *
 * ```
 * $osConfigServiceClient = new OsConfigServiceClient();
 * try {
 *     $name = 'name';
 *     $response = $osConfigServiceClient->cancelPatchJob($name);
 * } finally {
 *     $osConfigServiceClient->close();
 * }
 * ```
 *
 * Many parameters require resource names to be formatted in a particular way. To
 * assistwith these names, this class includes a format method for each type of
 * name, and additionallya parseName method to extract the individual identifiers
 * contained within formatted namesthat are returned by the API.
 *
 * @experimental
 */
class OsConfigServiceGapicClient
{
    use GapicClientTrait;

    /**
     * The name of the service.
     */
    const SERVICE_NAME = 'google.cloud.osconfig.v1beta.OsConfigService';

    /**
     * The default address of the service.
     */
    const SERVICE_ADDRESS = 'osconfig.googleapis.com';

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

    private static $guestPolicyNameTemplate;

    private static $projectNameTemplate;

    private static $pathTemplateMap;

    private static function getClientDefaults()
    {
        return [
            'serviceName' => self::SERVICE_NAME,
            'serviceAddress' => self::SERVICE_ADDRESS . ':' . self::DEFAULT_SERVICE_PORT,
            'clientConfig' => __DIR__ . '/../resources/os_config_service_client_config.json',
            'descriptorsConfigPath' => __DIR__ . '/../resources/os_config_service_descriptor_config.php',
            'gcpApiConfigPath' => __DIR__ . '/../resources/os_config_service_grpc_config.json',
            'credentialsConfig' => [
                'defaultScopes' => self::$serviceScopes,
            ],
            'transportConfig' => [
                'rest' => [
                    'restClientConfigPath' => __DIR__ . '/../resources/os_config_service_rest_client_config.php',
                ],
            ],
        ];
    }

    private static function getGuestPolicyNameTemplate()
    {
        if (self::$guestPolicyNameTemplate == null) {
            self::$guestPolicyNameTemplate = new PathTemplate('projects/{project}/guestPolicies/{guest_policy}');
        }

        return self::$guestPolicyNameTemplate;
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
                'guestPolicy' => self::getGuestPolicyNameTemplate(),
                'project' => self::getProjectNameTemplate(),
            ];
        }

        return self::$pathTemplateMap;
    }

    /**
     * Formats a string containing the fully-qualified path to represent a guest_policy
     * resource.
     *
     * @param string $project
     * @param string $guestPolicy
     *
     * @return string The formatted guest_policy resource.
     *
     * @experimental
     */
    public static function guestPolicyName($project, $guestPolicy)
    {
        return self::getGuestPolicyNameTemplate()->render([
            'project' => $project,
            'guest_policy' => $guestPolicy,
        ]);
    }

    /**
     * Formats a string containing the fully-qualified path to represent a project
     * resource.
     *
     * @param string $project
     *
     * @return string The formatted project resource.
     *
     * @experimental
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
     * - guestPolicy: projects/{project}/guestPolicies/{guest_policy}
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
     *
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
     * Constructor.
     *
     * @param array $options {
     *     Optional. Options for configuring the service API wrapper.
     *
     *     @type string $serviceAddress
     *           The address of the API remote host. May optionally include the port, formatted
     *           as "<uri>:<port>". Default 'osconfig.googleapis.com:443'.
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
     *
     * @experimental
     */
    public function __construct(array $options = [])
    {
        $clientOptions = $this->buildClientOptions($options);
        $this->setClientOptions($clientOptions);
    }

    /**
     * Cancel a patch job. The patch job must be active. Canceled patch jobs
     * cannot be restarted.
     *
     * Sample code:
     * ```
     * $osConfigServiceClient = new OsConfigServiceClient();
     * try {
     *     $name = 'name';
     *     $response = $osConfigServiceClient->cancelPatchJob($name);
     * } finally {
     *     $osConfigServiceClient->close();
     * }
     * ```
     *
     * @param string $name         Required. Name of the patch in the form `projects/&#42;/patchJobs/*`
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
     * @return \Google\Cloud\Osconfig\V1beta\PatchJob
     *
     * @throws ApiException if the remote call fails
     *
     * @experimental
     */
    public function cancelPatchJob($name, array $optionalArgs = [])
    {
        $request = new CancelPatchJobRequest();
        $requestParamHeaders = [];
        $request->setName($name);
        $requestParamHeaders['name'] = $name;
        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('CancelPatchJob', PatchJob::class, $optionalArgs, $request)->wait();
    }

    /**
     * Create an OS Config guest policy.
     *
     * Sample code:
     * ```
     * $osConfigServiceClient = new OsConfigServiceClient();
     * try {
     *     $formattedParent = $osConfigServiceClient->projectName('[PROJECT]');
     *     $guestPolicyId = 'guest_policy_id';
     *     $guestPolicy = new GuestPolicy();
     *     $response = $osConfigServiceClient->createGuestPolicy($formattedParent, $guestPolicyId, $guestPolicy);
     * } finally {
     *     $osConfigServiceClient->close();
     * }
     * ```
     *
     * @param string      $parent        Required. The resource name of the parent using one of the following forms:
     *                                   `projects/{project_number}`.
     * @param string      $guestPolicyId Required. The logical name of the guest policy in the project
     *                                   with the following restrictions:
     *
     *                                   * Must contain only lowercase letters, numbers, and hyphens.
     *                                   * Must start with a letter.
     *                                   * Must be between 1-63 characters.
     *                                   * Must end with a number or a letter.
     *                                   * Must be unique within the project.
     * @param GuestPolicy $guestPolicy   Required. The GuestPolicy to create.
     * @param array       $optionalArgs  {
     *     Optional.
     *
     *     @type RetrySettings|array $retrySettings
     *           Retry settings to use for this call. Can be a
     *           {@see Google\ApiCore\RetrySettings} object, or an associative array of retry
     *           settings parameters. See the documentation on
     *           {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\Osconfig\V1beta\GuestPolicy
     *
     * @throws ApiException if the remote call fails
     *
     * @experimental
     */
    public function createGuestPolicy($parent, $guestPolicyId, $guestPolicy, array $optionalArgs = [])
    {
        $request = new CreateGuestPolicyRequest();
        $requestParamHeaders = [];
        $request->setParent($parent);
        $request->setGuestPolicyId($guestPolicyId);
        $request->setGuestPolicy($guestPolicy);
        $requestParamHeaders['parent'] = $parent;
        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('CreateGuestPolicy', GuestPolicy::class, $optionalArgs, $request)->wait();
    }

    /**
     * Create an OS Config patch deployment.
     *
     * Sample code:
     * ```
     * $osConfigServiceClient = new OsConfigServiceClient();
     * try {
     *     $parent = 'parent';
     *     $patchDeploymentId = 'patch_deployment_id';
     *     $patchDeployment = new PatchDeployment();
     *     $response = $osConfigServiceClient->createPatchDeployment($parent, $patchDeploymentId, $patchDeployment);
     * } finally {
     *     $osConfigServiceClient->close();
     * }
     * ```
     *
     * @param string          $parent            Required. The project to apply this patch deployment to in the form `projects/*`.
     * @param string          $patchDeploymentId Required. A name for the patch deployment in the project. When creating a name
     *                                           the following rules apply:
     *                                           * Must contain only lowercase letters, numbers, and hyphens.
     *                                           * Must start with a letter.
     *                                           * Must be between 1-63 characters.
     *                                           * Must end with a number or a letter.
     *                                           * Must be unique within the project.
     * @param PatchDeployment $patchDeployment   Required. The patch deployment to create.
     * @param array           $optionalArgs      {
     *     Optional.
     *
     *     @type RetrySettings|array $retrySettings
     *           Retry settings to use for this call. Can be a
     *           {@see Google\ApiCore\RetrySettings} object, or an associative array of retry
     *           settings parameters. See the documentation on
     *           {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\Osconfig\V1beta\PatchDeployment
     *
     * @throws ApiException if the remote call fails
     *
     * @experimental
     */
    public function createPatchDeployment($parent, $patchDeploymentId, $patchDeployment, array $optionalArgs = [])
    {
        $request = new CreatePatchDeploymentRequest();
        $requestParamHeaders = [];
        $request->setParent($parent);
        $request->setPatchDeploymentId($patchDeploymentId);
        $request->setPatchDeployment($patchDeployment);
        $requestParamHeaders['parent'] = $parent;
        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('CreatePatchDeployment', PatchDeployment::class, $optionalArgs, $request)->wait();
    }

    /**
     * Delete an OS Config guest policy.
     *
     * Sample code:
     * ```
     * $osConfigServiceClient = new OsConfigServiceClient();
     * try {
     *     $formattedName = $osConfigServiceClient->guestPolicyName('[PROJECT]', '[GUEST_POLICY]');
     *     $osConfigServiceClient->deleteGuestPolicy($formattedName);
     * } finally {
     *     $osConfigServiceClient->close();
     * }
     * ```
     *
     * @param string $name         Required. The resource name of the guest policy  using one of the following forms:
     *                             `projects/{project_number}/guestPolicies/{guest_policy_id}`.
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
     *
     * @experimental
     */
    public function deleteGuestPolicy($name, array $optionalArgs = [])
    {
        $request = new DeleteGuestPolicyRequest();
        $requestParamHeaders = [];
        $request->setName($name);
        $requestParamHeaders['name'] = $name;
        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('DeleteGuestPolicy', GPBEmpty::class, $optionalArgs, $request)->wait();
    }

    /**
     * Delete an OS Config patch deployment.
     *
     * Sample code:
     * ```
     * $osConfigServiceClient = new OsConfigServiceClient();
     * try {
     *     $name = 'name';
     *     $osConfigServiceClient->deletePatchDeployment($name);
     * } finally {
     *     $osConfigServiceClient->close();
     * }
     * ```
     *
     * @param string $name         Required. The resource name of the patch deployment in the form
     *                             `projects/&#42;/patchDeployments/*`.
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
     *
     * @experimental
     */
    public function deletePatchDeployment($name, array $optionalArgs = [])
    {
        $request = new DeletePatchDeploymentRequest();
        $requestParamHeaders = [];
        $request->setName($name);
        $requestParamHeaders['name'] = $name;
        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('DeletePatchDeployment', GPBEmpty::class, $optionalArgs, $request)->wait();
    }

    /**
     * Patch VM instances by creating and running a patch job.
     *
     * Sample code:
     * ```
     * $osConfigServiceClient = new OsConfigServiceClient();
     * try {
     *     $parent = 'parent';
     *     $instanceFilter = new PatchInstanceFilter();
     *     $response = $osConfigServiceClient->executePatchJob($parent, $instanceFilter);
     * } finally {
     *     $osConfigServiceClient->close();
     * }
     * ```
     *
     * @param string              $parent         Required. The project in which to run this patch in the form `projects/*`
     * @param PatchInstanceFilter $instanceFilter Required. Instances to patch, either explicitly or filtered by some criteria such
     *                                            as zone or labels.
     * @param array               $optionalArgs   {
     *     Optional.
     *
     *     @type string $description
     *           Description of the patch job. Length of the description is limited
     *           to 1024 characters.
     *     @type PatchConfig $patchConfig
     *           Patch configuration being applied. If omitted, instances are
     *           patched using the default configurations.
     *     @type Duration $duration
     *           Duration of the patch job. After the duration ends, the patch job
     *           times out.
     *     @type bool $dryRun
     *           If this patch is a dry-run only, instances are contacted but
     *           will do nothing.
     *     @type string $displayName
     *           Display name for this patch job. This does not have to be unique.
     *     @type RetrySettings|array $retrySettings
     *           Retry settings to use for this call. Can be a
     *           {@see Google\ApiCore\RetrySettings} object, or an associative array of retry
     *           settings parameters. See the documentation on
     *           {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\Osconfig\V1beta\PatchJob
     *
     * @throws ApiException if the remote call fails
     *
     * @experimental
     */
    public function executePatchJob($parent, $instanceFilter, array $optionalArgs = [])
    {
        $request = new ExecutePatchJobRequest();
        $requestParamHeaders = [];
        $request->setParent($parent);
        $request->setInstanceFilter($instanceFilter);
        $requestParamHeaders['parent'] = $parent;
        if (isset($optionalArgs['description'])) {
            $request->setDescription($optionalArgs['description']);
        }

        if (isset($optionalArgs['patchConfig'])) {
            $request->setPatchConfig($optionalArgs['patchConfig']);
        }

        if (isset($optionalArgs['duration'])) {
            $request->setDuration($optionalArgs['duration']);
        }

        if (isset($optionalArgs['dryRun'])) {
            $request->setDryRun($optionalArgs['dryRun']);
        }

        if (isset($optionalArgs['displayName'])) {
            $request->setDisplayName($optionalArgs['displayName']);
        }

        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('ExecutePatchJob', PatchJob::class, $optionalArgs, $request)->wait();
    }

    /**
     * Get an OS Config guest policy.
     *
     * Sample code:
     * ```
     * $osConfigServiceClient = new OsConfigServiceClient();
     * try {
     *     $formattedName = $osConfigServiceClient->guestPolicyName('[PROJECT]', '[GUEST_POLICY]');
     *     $response = $osConfigServiceClient->getGuestPolicy($formattedName);
     * } finally {
     *     $osConfigServiceClient->close();
     * }
     * ```
     *
     * @param string $name         Required. The resource name of the guest policy using one of the following forms:
     *                             `projects/{project_number}/guestPolicies/{guest_policy_id}`.
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
     * @return \Google\Cloud\Osconfig\V1beta\GuestPolicy
     *
     * @throws ApiException if the remote call fails
     *
     * @experimental
     */
    public function getGuestPolicy($name, array $optionalArgs = [])
    {
        $request = new GetGuestPolicyRequest();
        $requestParamHeaders = [];
        $request->setName($name);
        $requestParamHeaders['name'] = $name;
        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('GetGuestPolicy', GuestPolicy::class, $optionalArgs, $request)->wait();
    }

    /**
     * Get an OS Config patch deployment.
     *
     * Sample code:
     * ```
     * $osConfigServiceClient = new OsConfigServiceClient();
     * try {
     *     $name = 'name';
     *     $response = $osConfigServiceClient->getPatchDeployment($name);
     * } finally {
     *     $osConfigServiceClient->close();
     * }
     * ```
     *
     * @param string $name         Required. The resource name of the patch deployment in the form
     *                             `projects/&#42;/patchDeployments/*`.
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
     * @return \Google\Cloud\Osconfig\V1beta\PatchDeployment
     *
     * @throws ApiException if the remote call fails
     *
     * @experimental
     */
    public function getPatchDeployment($name, array $optionalArgs = [])
    {
        $request = new GetPatchDeploymentRequest();
        $requestParamHeaders = [];
        $request->setName($name);
        $requestParamHeaders['name'] = $name;
        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('GetPatchDeployment', PatchDeployment::class, $optionalArgs, $request)->wait();
    }

    /**
     * Get the patch job. This can be used to track the progress of an
     * ongoing patch job or review the details of completed jobs.
     *
     * Sample code:
     * ```
     * $osConfigServiceClient = new OsConfigServiceClient();
     * try {
     *     $name = 'name';
     *     $response = $osConfigServiceClient->getPatchJob($name);
     * } finally {
     *     $osConfigServiceClient->close();
     * }
     * ```
     *
     * @param string $name         Required. Name of the patch in the form `projects/&#42;/patchJobs/*`
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
     * @return \Google\Cloud\Osconfig\V1beta\PatchJob
     *
     * @throws ApiException if the remote call fails
     *
     * @experimental
     */
    public function getPatchJob($name, array $optionalArgs = [])
    {
        $request = new GetPatchJobRequest();
        $requestParamHeaders = [];
        $request->setName($name);
        $requestParamHeaders['name'] = $name;
        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('GetPatchJob', PatchJob::class, $optionalArgs, $request)->wait();
    }

    /**
     * Get a page of OS Config guest policies.
     *
     * Sample code:
     * ```
     * $osConfigServiceClient = new OsConfigServiceClient();
     * try {
     *     $formattedParent = $osConfigServiceClient->projectName('[PROJECT]');
     *     // Iterate over pages of elements
     *     $pagedResponse = $osConfigServiceClient->listGuestPolicies($formattedParent);
     *     foreach ($pagedResponse->iteratePages() as $page) {
     *         foreach ($page as $element) {
     *             // doSomethingWith($element);
     *         }
     *     }
     *     // Alternatively:
     *     // Iterate through all elements
     *     $pagedResponse = $osConfigServiceClient->listGuestPolicies($formattedParent);
     *     foreach ($pagedResponse->iterateAllElements() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $osConfigServiceClient->close();
     * }
     * ```
     *
     * @param string $parent       Required. The resource name of the parent using one of the following forms:
     *                             `projects/{project_number}`.
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
     *
     * @experimental
     */
    public function listGuestPolicies($parent, array $optionalArgs = [])
    {
        $request = new ListGuestPoliciesRequest();
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
        return $this->getPagedListResponse('ListGuestPolicies', $optionalArgs, ListGuestPoliciesResponse::class, $request);
    }

    /**
     * Get a page of OS Config patch deployments.
     *
     * Sample code:
     * ```
     * $osConfigServiceClient = new OsConfigServiceClient();
     * try {
     *     $parent = 'parent';
     *     // Iterate over pages of elements
     *     $pagedResponse = $osConfigServiceClient->listPatchDeployments($parent);
     *     foreach ($pagedResponse->iteratePages() as $page) {
     *         foreach ($page as $element) {
     *             // doSomethingWith($element);
     *         }
     *     }
     *     // Alternatively:
     *     // Iterate through all elements
     *     $pagedResponse = $osConfigServiceClient->listPatchDeployments($parent);
     *     foreach ($pagedResponse->iterateAllElements() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $osConfigServiceClient->close();
     * }
     * ```
     *
     * @param string $parent       Required. The resource name of the parent in the form `projects/*`.
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
     *
     * @experimental
     */
    public function listPatchDeployments($parent, array $optionalArgs = [])
    {
        $request = new ListPatchDeploymentsRequest();
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
        return $this->getPagedListResponse('ListPatchDeployments', $optionalArgs, ListPatchDeploymentsResponse::class, $request);
    }

    /**
     * Get a list of instance details for a given patch job.
     *
     * Sample code:
     * ```
     * $osConfigServiceClient = new OsConfigServiceClient();
     * try {
     *     $parent = 'parent';
     *     // Iterate over pages of elements
     *     $pagedResponse = $osConfigServiceClient->listPatchJobInstanceDetails($parent);
     *     foreach ($pagedResponse->iteratePages() as $page) {
     *         foreach ($page as $element) {
     *             // doSomethingWith($element);
     *         }
     *     }
     *     // Alternatively:
     *     // Iterate through all elements
     *     $pagedResponse = $osConfigServiceClient->listPatchJobInstanceDetails($parent);
     *     foreach ($pagedResponse->iterateAllElements() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $osConfigServiceClient->close();
     * }
     * ```
     *
     * @param string $parent       Required. The parent for the instances are in the form of `projects/&#42;/patchJobs/*`.
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
     *           A filter expression that filters results listed in the response. This
     *           field supports filtering results by instance zone, name, state, or
     *           `failure_reason`.
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
     *
     * @experimental
     */
    public function listPatchJobInstanceDetails($parent, array $optionalArgs = [])
    {
        $request = new ListPatchJobInstanceDetailsRequest();
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

        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->getPagedListResponse('ListPatchJobInstanceDetails', $optionalArgs, ListPatchJobInstanceDetailsResponse::class, $request);
    }

    /**
     * Get a list of patch jobs.
     *
     * Sample code:
     * ```
     * $osConfigServiceClient = new OsConfigServiceClient();
     * try {
     *     $parent = 'parent';
     *     // Iterate over pages of elements
     *     $pagedResponse = $osConfigServiceClient->listPatchJobs($parent);
     *     foreach ($pagedResponse->iteratePages() as $page) {
     *         foreach ($page as $element) {
     *             // doSomethingWith($element);
     *         }
     *     }
     *     // Alternatively:
     *     // Iterate through all elements
     *     $pagedResponse = $osConfigServiceClient->listPatchJobs($parent);
     *     foreach ($pagedResponse->iterateAllElements() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $osConfigServiceClient->close();
     * }
     * ```
     *
     * @param string $parent       Required. In the form of `projects/*`
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
     *           If provided, this field specifies the criteria that must be met by patch
     *           jobs to be included in the response.
     *           Currently, filtering is only available on the patch_deployment field.
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
     *
     * @experimental
     */
    public function listPatchJobs($parent, array $optionalArgs = [])
    {
        $request = new ListPatchJobsRequest();
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

        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->getPagedListResponse('ListPatchJobs', $optionalArgs, ListPatchJobsResponse::class, $request);
    }

    /**
     * Lookup the effective guest policy that applies to a VM instance. This
     * lookup merges all policies that are assigned to the instance ancestry.
     *
     * Sample code:
     * ```
     * $osConfigServiceClient = new OsConfigServiceClient();
     * try {
     *     $instance = 'instance';
     *     $response = $osConfigServiceClient->lookupEffectiveGuestPolicy($instance);
     * } finally {
     *     $osConfigServiceClient->close();
     * }
     * ```
     *
     * @param string $instance     Required. The VM instance whose policies are being looked up.
     * @param array  $optionalArgs {
     *     Optional.
     *
     *     @type string $osShortName
     *           Short name of the OS running on the instance. The OS Config agent only
     *           provides this field for targeting if OS Inventory is enabled for that
     *           instance.
     *     @type string $osVersion
     *           Version of the OS running on the instance. The OS Config agent only
     *           provides this field for targeting if OS Inventory is enabled for that
     *           VM instance.
     *     @type string $osArchitecture
     *           Architecture of OS running on the instance. The OS Config agent only
     *           provides this field for targeting if OS Inventory is enabled for that
     *           instance.
     *     @type RetrySettings|array $retrySettings
     *           Retry settings to use for this call. Can be a
     *           {@see Google\ApiCore\RetrySettings} object, or an associative array of retry
     *           settings parameters. See the documentation on
     *           {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\Osconfig\V1beta\EffectiveGuestPolicy
     *
     * @throws ApiException if the remote call fails
     *
     * @experimental
     */
    public function lookupEffectiveGuestPolicy($instance, array $optionalArgs = [])
    {
        $request = new LookupEffectiveGuestPolicyRequest();
        $requestParamHeaders = [];
        $request->setInstance($instance);
        $requestParamHeaders['instance'] = $instance;
        if (isset($optionalArgs['osShortName'])) {
            $request->setOsShortName($optionalArgs['osShortName']);
        }

        if (isset($optionalArgs['osVersion'])) {
            $request->setOsVersion($optionalArgs['osVersion']);
        }

        if (isset($optionalArgs['osArchitecture'])) {
            $request->setOsArchitecture($optionalArgs['osArchitecture']);
        }

        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('LookupEffectiveGuestPolicy', EffectiveGuestPolicy::class, $optionalArgs, $request)->wait();
    }

    /**
     * Update an OS Config guest policy.
     *
     * Sample code:
     * ```
     * $osConfigServiceClient = new OsConfigServiceClient();
     * try {
     *     $guestPolicy = new GuestPolicy();
     *     $response = $osConfigServiceClient->updateGuestPolicy($guestPolicy);
     * } finally {
     *     $osConfigServiceClient->close();
     * }
     * ```
     *
     * @param GuestPolicy $guestPolicy  Required. The updated GuestPolicy.
     * @param array       $optionalArgs {
     *     Optional.
     *
     *     @type FieldMask $updateMask
     *           Field mask that controls which fields of the guest policy should be
     *           updated.
     *     @type RetrySettings|array $retrySettings
     *           Retry settings to use for this call. Can be a
     *           {@see Google\ApiCore\RetrySettings} object, or an associative array of retry
     *           settings parameters. See the documentation on
     *           {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\Osconfig\V1beta\GuestPolicy
     *
     * @throws ApiException if the remote call fails
     *
     * @experimental
     */
    public function updateGuestPolicy($guestPolicy, array $optionalArgs = [])
    {
        $request = new UpdateGuestPolicyRequest();
        $requestParamHeaders = [];
        $request->setGuestPolicy($guestPolicy);
        $requestParamHeaders['guest_policy.name'] = $guestPolicy->getName();
        if (isset($optionalArgs['updateMask'])) {
            $request->setUpdateMask($optionalArgs['updateMask']);
        }

        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('UpdateGuestPolicy', GuestPolicy::class, $optionalArgs, $request)->wait();
    }
}
