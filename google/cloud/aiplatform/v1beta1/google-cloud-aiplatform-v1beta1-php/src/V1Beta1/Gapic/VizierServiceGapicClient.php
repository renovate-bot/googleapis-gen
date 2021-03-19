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
 * https://github.com/google/googleapis/blob/master/google/cloud/aiplatform/v1beta1/vizier_service.proto
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
use Google\Cloud\Aiplatform\V1beta1\AddTrialMeasurementRequest;
use Google\Cloud\Aiplatform\V1beta1\CheckTrialEarlyStoppingStateRequest;
use Google\Cloud\Aiplatform\V1beta1\CheckTrialEarlyStoppingStateResponse;
use Google\Cloud\Aiplatform\V1beta1\CompleteTrialRequest;
use Google\Cloud\Aiplatform\V1beta1\CreateStudyRequest;
use Google\Cloud\Aiplatform\V1beta1\CreateTrialRequest;
use Google\Cloud\Aiplatform\V1beta1\DeleteStudyRequest;
use Google\Cloud\Aiplatform\V1beta1\DeleteTrialRequest;
use Google\Cloud\Aiplatform\V1beta1\GetStudyRequest;
use Google\Cloud\Aiplatform\V1beta1\GetTrialRequest;
use Google\Cloud\Aiplatform\V1beta1\ListOptimalTrialsRequest;
use Google\Cloud\Aiplatform\V1beta1\ListOptimalTrialsResponse;
use Google\Cloud\Aiplatform\V1beta1\ListStudiesRequest;
use Google\Cloud\Aiplatform\V1beta1\ListStudiesResponse;
use Google\Cloud\Aiplatform\V1beta1\ListTrialsRequest;
use Google\Cloud\Aiplatform\V1beta1\ListTrialsResponse;
use Google\Cloud\Aiplatform\V1beta1\LookupStudyRequest;
use Google\Cloud\Aiplatform\V1beta1\Measurement;
use Google\Cloud\Aiplatform\V1beta1\StopTrialRequest;
use Google\Cloud\Aiplatform\V1beta1\Study;
use Google\Cloud\Aiplatform\V1beta1\SuggestTrialsRequest;
use Google\Cloud\Aiplatform\V1beta1\SuggestTrialsResponse;
use Google\Cloud\Aiplatform\V1beta1\Trial;
use Google\LongRunning\Operation;
use Google\Protobuf\GPBEmpty;

/**
 * Service Description: Cloud AI Platform Vizier API.
 *
 * Vizier service is a GCP service to solve blackbox optimization problems,
 * such as tuning machine learning hyperparameters and searching over deep
 * learning architectures.
 *
 * This class provides the ability to make remote calls to the backing service through method
 * calls that map to API methods. Sample code to get started:
 *
 * ```
 * $vizierServiceClient = new VizierServiceClient();
 * try {
 *     $formattedParent = $vizierServiceClient->locationName('[PROJECT]', '[LOCATION]');
 *     $study = new Study();
 *     $response = $vizierServiceClient->createStudy($formattedParent, $study);
 * } finally {
 *     $vizierServiceClient->close();
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
class VizierServiceGapicClient
{
    use GapicClientTrait;

    /**
     * The name of the service.
     */
    const SERVICE_NAME = 'google.cloud.aiplatform.v1beta1.VizierService';

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
    private static $customJobNameTemplate;
    private static $locationNameTemplate;
    private static $studyNameTemplate;
    private static $trialNameTemplate;
    private static $pathTemplateMap;

    private $operationsClient;

    private static function getClientDefaults()
    {
        return [
            'serviceName' => self::SERVICE_NAME,
            'serviceAddress' => self::SERVICE_ADDRESS.':'.self::DEFAULT_SERVICE_PORT,
            'clientConfig' => __DIR__.'/../resources/vizier_service_client_config.json',
            'descriptorsConfigPath' => __DIR__.'/../resources/vizier_service_descriptor_config.php',
            'gcpApiConfigPath' => __DIR__.'/../resources/vizier_service_grpc_config.json',
            'credentialsConfig' => [
                'defaultScopes' => self::$serviceScopes,
            ],
            'transportConfig' => [
                'rest' => [
                    'restClientConfigPath' => __DIR__.'/../resources/vizier_service_rest_client_config.php',
                ],
            ],
        ];
    }

    private static function getCustomJobNameTemplate()
    {
        if (null == self::$customJobNameTemplate) {
            self::$customJobNameTemplate = new PathTemplate('projects/{project}/locations/{location}/customJobs/{custom_job}');
        }

        return self::$customJobNameTemplate;
    }

    private static function getLocationNameTemplate()
    {
        if (null == self::$locationNameTemplate) {
            self::$locationNameTemplate = new PathTemplate('projects/{project}/locations/{location}');
        }

        return self::$locationNameTemplate;
    }

    private static function getStudyNameTemplate()
    {
        if (null == self::$studyNameTemplate) {
            self::$studyNameTemplate = new PathTemplate('projects/{project}/locations/{location}/studies/{study}');
        }

        return self::$studyNameTemplate;
    }

    private static function getTrialNameTemplate()
    {
        if (null == self::$trialNameTemplate) {
            self::$trialNameTemplate = new PathTemplate('projects/{project}/locations/{location}/studies/{study}/trials/{trial}');
        }

        return self::$trialNameTemplate;
    }

    private static function getPathTemplateMap()
    {
        if (null == self::$pathTemplateMap) {
            self::$pathTemplateMap = [
                'customJob' => self::getCustomJobNameTemplate(),
                'location' => self::getLocationNameTemplate(),
                'study' => self::getStudyNameTemplate(),
                'trial' => self::getTrialNameTemplate(),
            ];
        }

        return self::$pathTemplateMap;
    }

    /**
     * Formats a string containing the fully-qualified path to represent
     * a custom_job resource.
     *
     * @param string $project
     * @param string $location
     * @param string $customJob
     *
     * @return string The formatted custom_job resource.
     * @experimental
     */
    public static function customJobName($project, $location, $customJob)
    {
        return self::getCustomJobNameTemplate()->render([
            'project' => $project,
            'location' => $location,
            'custom_job' => $customJob,
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
     * a study resource.
     *
     * @param string $project
     * @param string $location
     * @param string $study
     *
     * @return string The formatted study resource.
     * @experimental
     */
    public static function studyName($project, $location, $study)
    {
        return self::getStudyNameTemplate()->render([
            'project' => $project,
            'location' => $location,
            'study' => $study,
        ]);
    }

    /**
     * Formats a string containing the fully-qualified path to represent
     * a trial resource.
     *
     * @param string $project
     * @param string $location
     * @param string $study
     * @param string $trial
     *
     * @return string The formatted trial resource.
     * @experimental
     */
    public static function trialName($project, $location, $study, $trial)
    {
        return self::getTrialNameTemplate()->render([
            'project' => $project,
            'location' => $location,
            'study' => $study,
            'trial' => $trial,
        ]);
    }

    /**
     * Parses a formatted name string and returns an associative array of the components in the name.
     * The following name formats are supported:
     * Template: Pattern
     * - customJob: projects/{project}/locations/{location}/customJobs/{custom_job}
     * - location: projects/{project}/locations/{location}
     * - study: projects/{project}/locations/{location}/studies/{study}
     * - trial: projects/{project}/locations/{location}/studies/{study}/trials/{trial}.
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
     * Creates a Study. A resource name will be generated after creation of the
     * Study.
     *
     * Sample code:
     * ```
     * $vizierServiceClient = new VizierServiceClient();
     * try {
     *     $formattedParent = $vizierServiceClient->locationName('[PROJECT]', '[LOCATION]');
     *     $study = new Study();
     *     $response = $vizierServiceClient->createStudy($formattedParent, $study);
     * } finally {
     *     $vizierServiceClient->close();
     * }
     * ```
     *
     * @param string $parent       Required. The resource name of the Location to create the CustomJob in.
     *                             Format: `projects/{project}/locations/{location}`
     * @param Study  $study        Required. The Study configuration used to create the Study.
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
     * @return \Google\Cloud\Aiplatform\V1beta1\Study
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function createStudy($parent, $study, array $optionalArgs = [])
    {
        $request = new CreateStudyRequest();
        $request->setParent($parent);
        $request->setStudy($study);

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'CreateStudy',
            Study::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Gets a Study by name.
     *
     * Sample code:
     * ```
     * $vizierServiceClient = new VizierServiceClient();
     * try {
     *     $formattedName = $vizierServiceClient->studyName('[PROJECT]', '[LOCATION]', '[STUDY]');
     *     $response = $vizierServiceClient->getStudy($formattedName);
     * } finally {
     *     $vizierServiceClient->close();
     * }
     * ```
     *
     * @param string $name         Required. The name of the Study resource.
     *                             Format: `projects/{project}/locations/{location}/studies/{study}`
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
     * @return \Google\Cloud\Aiplatform\V1beta1\Study
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function getStudy($name, array $optionalArgs = [])
    {
        $request = new GetStudyRequest();
        $request->setName($name);

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'GetStudy',
            Study::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Lists all the studies in a region for an associated project.
     *
     * Sample code:
     * ```
     * $vizierServiceClient = new VizierServiceClient();
     * try {
     *     $formattedParent = $vizierServiceClient->locationName('[PROJECT]', '[LOCATION]');
     *     // Iterate over pages of elements
     *     $pagedResponse = $vizierServiceClient->listStudies($formattedParent);
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
     *     $pagedResponse = $vizierServiceClient->listStudies($formattedParent);
     *     foreach ($pagedResponse->iterateAllElements() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $vizierServiceClient->close();
     * }
     * ```
     *
     * @param string $parent       Required. The resource name of the Location to list the Study from.
     *                             Format: `projects/{project}/locations/{location}`
     * @param array  $optionalArgs {
     *                             Optional.
     *
     *     @type string $pageToken
     *          A page token is used to specify a page of values to be returned.
     *          If no page token is specified (the default), the first page
     *          of values will be returned. Any page token used here must have
     *          been generated by a previous call to the API.
     *     @type int $pageSize
     *          The maximum number of resources contained in the underlying API
     *          response. The API may return fewer values in a page, even if
     *          there are additional values to be retrieved.
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
    public function listStudies($parent, array $optionalArgs = [])
    {
        $request = new ListStudiesRequest();
        $request->setParent($parent);
        if (isset($optionalArgs['pageToken'])) {
            $request->setPageToken($optionalArgs['pageToken']);
        }
        if (isset($optionalArgs['pageSize'])) {
            $request->setPageSize($optionalArgs['pageSize']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->getPagedListResponse(
            'ListStudies',
            $optionalArgs,
            ListStudiesResponse::class,
            $request
        );
    }

    /**
     * Deletes a Study.
     *
     * Sample code:
     * ```
     * $vizierServiceClient = new VizierServiceClient();
     * try {
     *     $formattedName = $vizierServiceClient->studyName('[PROJECT]', '[LOCATION]', '[STUDY]');
     *     $vizierServiceClient->deleteStudy($formattedName);
     * } finally {
     *     $vizierServiceClient->close();
     * }
     * ```
     *
     * @param string $name         Required. The name of the Study resource to be deleted.
     *                             Format: `projects/{project}/locations/{location}/studies/{study}`
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
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function deleteStudy($name, array $optionalArgs = [])
    {
        $request = new DeleteStudyRequest();
        $request->setName($name);

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'DeleteStudy',
            GPBEmpty::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Looks a study up using the user-defined display_name field instead of the
     * fully qualified resource name.
     *
     * Sample code:
     * ```
     * $vizierServiceClient = new VizierServiceClient();
     * try {
     *     $formattedParent = $vizierServiceClient->locationName('[PROJECT]', '[LOCATION]');
     *     $displayName = '';
     *     $response = $vizierServiceClient->lookupStudy($formattedParent, $displayName);
     * } finally {
     *     $vizierServiceClient->close();
     * }
     * ```
     *
     * @param string $parent       Required. The resource name of the Location to get the Study from.
     *                             Format: `projects/{project}/locations/{location}`
     * @param string $displayName  Required. The user-defined display name of the Study
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
     * @return \Google\Cloud\Aiplatform\V1beta1\Study
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function lookupStudy($parent, $displayName, array $optionalArgs = [])
    {
        $request = new LookupStudyRequest();
        $request->setParent($parent);
        $request->setDisplayName($displayName);

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'LookupStudy',
            Study::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Adds one or more Trials to a Study, with parameter values
     * suggested by AI Platform Vizier. Returns a long-running
     * operation associated with the generation of Trial suggestions.
     * When this long-running operation succeeds, it will contain
     * a [SuggestTrialsResponse][google.cloud.ml.v1.SuggestTrialsResponse].
     *
     * Sample code:
     * ```
     * $vizierServiceClient = new VizierServiceClient();
     * try {
     *     $formattedParent = $vizierServiceClient->studyName('[PROJECT]', '[LOCATION]', '[STUDY]');
     *     $suggestionCount = 0;
     *     $clientId = '';
     *     $operationResponse = $vizierServiceClient->suggestTrials($formattedParent, $suggestionCount, $clientId);
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
     *     $operationResponse = $vizierServiceClient->suggestTrials($formattedParent, $suggestionCount, $clientId);
     *     $operationName = $operationResponse->getName();
     *     // ... do other work
     *     $newOperationResponse = $vizierServiceClient->resumeOperation($operationName, 'suggestTrials');
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
     *     $vizierServiceClient->close();
     * }
     * ```
     *
     * @param string $parent          Required. The project and location that the Study belongs to.
     *                                Format: `projects/{project}/locations/{location}/studies/{study}`
     * @param int    $suggestionCount Required. The number of suggestions requested.
     * @param string $clientId        Required. The identifier of the client that is requesting the suggestion.
     *
     * If multiple SuggestTrialsRequests have the same `client_id`,
     * the service will return the identical suggested Trial if the Trial is
     * pending, and provide a new Trial if the last suggested Trial was completed.
     * @param array $optionalArgs {
     *                            Optional.
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
    public function suggestTrials($parent, $suggestionCount, $clientId, array $optionalArgs = [])
    {
        $request = new SuggestTrialsRequest();
        $request->setParent($parent);
        $request->setSuggestionCount($suggestionCount);
        $request->setClientId($clientId);

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startOperationsCall(
            'SuggestTrials',
            $optionalArgs,
            $request,
            $this->getOperationsClient()
        )->wait();
    }

    /**
     * Adds a user provided Trial to a Study.
     *
     * Sample code:
     * ```
     * $vizierServiceClient = new VizierServiceClient();
     * try {
     *     $formattedParent = $vizierServiceClient->studyName('[PROJECT]', '[LOCATION]', '[STUDY]');
     *     $trial = new Trial();
     *     $response = $vizierServiceClient->createTrial($formattedParent, $trial);
     * } finally {
     *     $vizierServiceClient->close();
     * }
     * ```
     *
     * @param string $parent       Required. The resource name of the Study to create the Trial in.
     *                             Format: `projects/{project}/locations/{location}/studies/{study}`
     * @param Trial  $trial        Required. The Trial to create.
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
     * @return \Google\Cloud\Aiplatform\V1beta1\Trial
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function createTrial($parent, $trial, array $optionalArgs = [])
    {
        $request = new CreateTrialRequest();
        $request->setParent($parent);
        $request->setTrial($trial);

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'CreateTrial',
            Trial::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Gets a Trial.
     *
     * Sample code:
     * ```
     * $vizierServiceClient = new VizierServiceClient();
     * try {
     *     $formattedName = $vizierServiceClient->trialName('[PROJECT]', '[LOCATION]', '[STUDY]', '[TRIAL]');
     *     $response = $vizierServiceClient->getTrial($formattedName);
     * } finally {
     *     $vizierServiceClient->close();
     * }
     * ```
     *
     * @param string $name         Required. The name of the Trial resource.
     *                             Format:
     *                             `projects/{project}/locations/{location}/studies/{study}/trials/{trial}`
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
     * @return \Google\Cloud\Aiplatform\V1beta1\Trial
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function getTrial($name, array $optionalArgs = [])
    {
        $request = new GetTrialRequest();
        $request->setName($name);

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'GetTrial',
            Trial::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Lists the Trials associated with a Study.
     *
     * Sample code:
     * ```
     * $vizierServiceClient = new VizierServiceClient();
     * try {
     *     $formattedParent = $vizierServiceClient->studyName('[PROJECT]', '[LOCATION]', '[STUDY]');
     *     // Iterate over pages of elements
     *     $pagedResponse = $vizierServiceClient->listTrials($formattedParent);
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
     *     $pagedResponse = $vizierServiceClient->listTrials($formattedParent);
     *     foreach ($pagedResponse->iterateAllElements() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $vizierServiceClient->close();
     * }
     * ```
     *
     * @param string $parent       Required. The resource name of the Study to list the Trial from.
     *                             Format: `projects/{project}/locations/{location}/studies/{study}`
     * @param array  $optionalArgs {
     *                             Optional.
     *
     *     @type string $pageToken
     *          A page token is used to specify a page of values to be returned.
     *          If no page token is specified (the default), the first page
     *          of values will be returned. Any page token used here must have
     *          been generated by a previous call to the API.
     *     @type int $pageSize
     *          The maximum number of resources contained in the underlying API
     *          response. The API may return fewer values in a page, even if
     *          there are additional values to be retrieved.
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
    public function listTrials($parent, array $optionalArgs = [])
    {
        $request = new ListTrialsRequest();
        $request->setParent($parent);
        if (isset($optionalArgs['pageToken'])) {
            $request->setPageToken($optionalArgs['pageToken']);
        }
        if (isset($optionalArgs['pageSize'])) {
            $request->setPageSize($optionalArgs['pageSize']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->getPagedListResponse(
            'ListTrials',
            $optionalArgs,
            ListTrialsResponse::class,
            $request
        );
    }

    /**
     * Adds a measurement of the objective metrics to a Trial. This measurement
     * is assumed to have been taken before the Trial is complete.
     *
     * Sample code:
     * ```
     * $vizierServiceClient = new VizierServiceClient();
     * try {
     *     $formattedTrialName = $vizierServiceClient->trialName('[PROJECT]', '[LOCATION]', '[STUDY]', '[TRIAL]');
     *     $measurement = new Measurement();
     *     $response = $vizierServiceClient->addTrialMeasurement($formattedTrialName, $measurement);
     * } finally {
     *     $vizierServiceClient->close();
     * }
     * ```
     *
     * @param string      $trialName    Required. The name of the trial to add measurement.
     *                                  Format:
     *                                  `projects/{project}/locations/{location}/studies/{study}/trials/{trial}`
     * @param Measurement $measurement  Required. The measurement to be added to a Trial.
     * @param array       $optionalArgs {
     *                                  Optional.
     *
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\Aiplatform\V1beta1\Trial
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function addTrialMeasurement($trialName, $measurement, array $optionalArgs = [])
    {
        $request = new AddTrialMeasurementRequest();
        $request->setTrialName($trialName);
        $request->setMeasurement($measurement);

        $requestParams = new RequestParamsHeaderDescriptor([
          'trial_name' => $request->getTrialName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'AddTrialMeasurement',
            Trial::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Marks a Trial as complete.
     *
     * Sample code:
     * ```
     * $vizierServiceClient = new VizierServiceClient();
     * try {
     *     $formattedName = $vizierServiceClient->trialName('[PROJECT]', '[LOCATION]', '[STUDY]', '[TRIAL]');
     *     $response = $vizierServiceClient->completeTrial($formattedName);
     * } finally {
     *     $vizierServiceClient->close();
     * }
     * ```
     *
     * @param string $name         Required. The Trial's name.
     *                             Format:
     *                             `projects/{project}/locations/{location}/studies/{study}/trials/{trial}`
     * @param array  $optionalArgs {
     *                             Optional.
     *
     *     @type Measurement $finalMeasurement
     *          Optional. If provided, it will be used as the completed Trial's
     *          final_measurement; Otherwise, the service will auto-select a
     *          previously reported measurement as the final-measurement
     *     @type bool $trialInfeasible
     *          Optional. True if the Trial cannot be run with the given Parameter, and
     *          final_measurement will be ignored.
     *     @type string $infeasibleReason
     *          Optional. A human readable reason why the trial was infeasible. This should
     *          only be provided if `trial_infeasible` is true.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\Aiplatform\V1beta1\Trial
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function completeTrial($name, array $optionalArgs = [])
    {
        $request = new CompleteTrialRequest();
        $request->setName($name);
        if (isset($optionalArgs['finalMeasurement'])) {
            $request->setFinalMeasurement($optionalArgs['finalMeasurement']);
        }
        if (isset($optionalArgs['trialInfeasible'])) {
            $request->setTrialInfeasible($optionalArgs['trialInfeasible']);
        }
        if (isset($optionalArgs['infeasibleReason'])) {
            $request->setInfeasibleReason($optionalArgs['infeasibleReason']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'CompleteTrial',
            Trial::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Deletes a Trial.
     *
     * Sample code:
     * ```
     * $vizierServiceClient = new VizierServiceClient();
     * try {
     *     $formattedName = $vizierServiceClient->trialName('[PROJECT]', '[LOCATION]', '[STUDY]', '[TRIAL]');
     *     $vizierServiceClient->deleteTrial($formattedName);
     * } finally {
     *     $vizierServiceClient->close();
     * }
     * ```
     *
     * @param string $name         Required. The Trial's name.
     *                             Format:
     *                             `projects/{project}/locations/{location}/studies/{study}/trials/{trial}`
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
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function deleteTrial($name, array $optionalArgs = [])
    {
        $request = new DeleteTrialRequest();
        $request->setName($name);

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'DeleteTrial',
            GPBEmpty::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Checks  whether a Trial should stop or not. Returns a
     * long-running operation. When the operation is successful,
     * it will contain a
     * [CheckTrialEarlyStoppingStateResponse][google.cloud.ml.v1.CheckTrialEarlyStoppingStateResponse].
     *
     * Sample code:
     * ```
     * $vizierServiceClient = new VizierServiceClient();
     * try {
     *     $formattedTrialName = $vizierServiceClient->trialName('[PROJECT]', '[LOCATION]', '[STUDY]', '[TRIAL]');
     *     $operationResponse = $vizierServiceClient->checkTrialEarlyStoppingState($formattedTrialName);
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
     *     $operationResponse = $vizierServiceClient->checkTrialEarlyStoppingState($formattedTrialName);
     *     $operationName = $operationResponse->getName();
     *     // ... do other work
     *     $newOperationResponse = $vizierServiceClient->resumeOperation($operationName, 'checkTrialEarlyStoppingState');
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
     *     $vizierServiceClient->close();
     * }
     * ```
     *
     * @param string $trialName    Required. The Trial's name.
     *                             Format:
     *                             `projects/{project}/locations/{location}/studies/{study}/trials/{trial}`
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
    public function checkTrialEarlyStoppingState($trialName, array $optionalArgs = [])
    {
        $request = new CheckTrialEarlyStoppingStateRequest();
        $request->setTrialName($trialName);

        $requestParams = new RequestParamsHeaderDescriptor([
          'trial_name' => $request->getTrialName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startOperationsCall(
            'CheckTrialEarlyStoppingState',
            $optionalArgs,
            $request,
            $this->getOperationsClient()
        )->wait();
    }

    /**
     * Stops a Trial.
     *
     * Sample code:
     * ```
     * $vizierServiceClient = new VizierServiceClient();
     * try {
     *     $formattedName = $vizierServiceClient->trialName('[PROJECT]', '[LOCATION]', '[STUDY]', '[TRIAL]');
     *     $response = $vizierServiceClient->stopTrial($formattedName);
     * } finally {
     *     $vizierServiceClient->close();
     * }
     * ```
     *
     * @param string $name         Required. The Trial's name.
     *                             Format:
     *                             `projects/{project}/locations/{location}/studies/{study}/trials/{trial}`
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
     * @return \Google\Cloud\Aiplatform\V1beta1\Trial
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function stopTrial($name, array $optionalArgs = [])
    {
        $request = new StopTrialRequest();
        $request->setName($name);

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'StopTrial',
            Trial::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Lists the pareto-optimal Trials for multi-objective Study or the
     * optimal Trials for single-objective Study. The definition of
     * pareto-optimal can be checked in wiki page.
     * https://en.wikipedia.org/wiki/Pareto_efficiency.
     *
     * Sample code:
     * ```
     * $vizierServiceClient = new VizierServiceClient();
     * try {
     *     $formattedParent = $vizierServiceClient->studyName('[PROJECT]', '[LOCATION]', '[STUDY]');
     *     $response = $vizierServiceClient->listOptimalTrials($formattedParent);
     * } finally {
     *     $vizierServiceClient->close();
     * }
     * ```
     *
     * @param string $parent       Required. The name of the Study that the optimal Trial belongs to.
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
     * @return \Google\Cloud\Aiplatform\V1beta1\ListOptimalTrialsResponse
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function listOptimalTrials($parent, array $optionalArgs = [])
    {
        $request = new ListOptimalTrialsRequest();
        $request->setParent($parent);

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'ListOptimalTrials',
            ListOptimalTrialsResponse::class,
            $optionalArgs,
            $request
        )->wait();
    }
}
