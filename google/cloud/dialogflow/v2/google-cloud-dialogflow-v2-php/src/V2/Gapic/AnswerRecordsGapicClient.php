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
 * https://github.com/google/googleapis/blob/master/google/cloud/dialogflow/v2/answer_record.proto
 * and updates to that file get reflected here through a refresh process.
 *
 * @experimental
 */

namespace Google\Cloud\Dialogflow\V2\Gapic;

use Google\ApiCore\ApiException;
use Google\ApiCore\CredentialsWrapper;
use Google\ApiCore\GapicClientTrait;
use Google\ApiCore\PathTemplate;
use Google\ApiCore\RequestParamsHeaderDescriptor;
use Google\ApiCore\RetrySettings;
use Google\ApiCore\Transport\TransportInterface;
use Google\ApiCore\ValidationException;
use Google\Auth\FetchAuthTokenInterface;
use Google\Cloud\Dialogflow\V2\AnswerRecord;
use Google\Cloud\Dialogflow\V2\ListAnswerRecordsRequest;
use Google\Cloud\Dialogflow\V2\ListAnswerRecordsResponse;
use Google\Cloud\Dialogflow\V2\UpdateAnswerRecordRequest;
use Google\Protobuf\FieldMask;

/**
 * Service Description: Service for managing [AnswerRecords][google.cloud.dialogflow.v2.AnswerRecord].
 *
 * This class provides the ability to make remote calls to the backing service through method
 * calls that map to API methods. Sample code to get started:
 *
 * ```
 * $answerRecordsClient = new AnswerRecordsClient();
 * try {
 *     $formattedParent = $answerRecordsClient->projectName('[PROJECT]');
 *     $filter = '';
 *     // Iterate over pages of elements
 *     $pagedResponse = $answerRecordsClient->listAnswerRecords($formattedParent, $filter);
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
 *     $pagedResponse = $answerRecordsClient->listAnswerRecords($formattedParent, $filter);
 *     foreach ($pagedResponse->iterateAllElements() as $element) {
 *         // doSomethingWith($element);
 *     }
 * } finally {
 *     $answerRecordsClient->close();
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
class AnswerRecordsGapicClient
{
    use GapicClientTrait;

    /**
     * The name of the service.
     */
    const SERVICE_NAME = 'google.cloud.dialogflow.v2.AnswerRecords';

    /**
     * The default address of the service.
     */
    const SERVICE_ADDRESS = 'dialogflow.googleapis.com';

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
        'https://www.googleapis.com/auth/dialogflow',
    ];
    private static $answerRecordNameTemplate;
    private static $locationNameTemplate;
    private static $projectNameTemplate;
    private static $projectAnswerRecordNameTemplate;
    private static $projectLocationAnswerRecordNameTemplate;
    private static $pathTemplateMap;

    private static function getClientDefaults()
    {
        return [
            'serviceName' => self::SERVICE_NAME,
            'serviceAddress' => self::SERVICE_ADDRESS.':'.self::DEFAULT_SERVICE_PORT,
            'clientConfig' => __DIR__.'/../resources/answer_records_client_config.json',
            'descriptorsConfigPath' => __DIR__.'/../resources/answer_records_descriptor_config.php',
            'gcpApiConfigPath' => __DIR__.'/../resources/answer_records_grpc_config.json',
            'credentialsConfig' => [
                'defaultScopes' => self::$serviceScopes,
            ],
            'transportConfig' => [
                'rest' => [
                    'restClientConfigPath' => __DIR__.'/../resources/answer_records_rest_client_config.php',
                ],
            ],
        ];
    }

    private static function getAnswerRecordNameTemplate()
    {
        if (null == self::$answerRecordNameTemplate) {
            self::$answerRecordNameTemplate = new PathTemplate('projects/{project}/answerRecords/{answer_record}');
        }

        return self::$answerRecordNameTemplate;
    }

    private static function getLocationNameTemplate()
    {
        if (null == self::$locationNameTemplate) {
            self::$locationNameTemplate = new PathTemplate('projects/{project}/locations/{location}');
        }

        return self::$locationNameTemplate;
    }

    private static function getProjectNameTemplate()
    {
        if (null == self::$projectNameTemplate) {
            self::$projectNameTemplate = new PathTemplate('projects/{project}');
        }

        return self::$projectNameTemplate;
    }

    private static function getProjectAnswerRecordNameTemplate()
    {
        if (null == self::$projectAnswerRecordNameTemplate) {
            self::$projectAnswerRecordNameTemplate = new PathTemplate('projects/{project}/answerRecords/{answer_record}');
        }

        return self::$projectAnswerRecordNameTemplate;
    }

    private static function getProjectLocationAnswerRecordNameTemplate()
    {
        if (null == self::$projectLocationAnswerRecordNameTemplate) {
            self::$projectLocationAnswerRecordNameTemplate = new PathTemplate('projects/{project}/locations/{location}/answerRecords/{answer_record}');
        }

        return self::$projectLocationAnswerRecordNameTemplate;
    }

    private static function getPathTemplateMap()
    {
        if (null == self::$pathTemplateMap) {
            self::$pathTemplateMap = [
                'answerRecord' => self::getAnswerRecordNameTemplate(),
                'location' => self::getLocationNameTemplate(),
                'project' => self::getProjectNameTemplate(),
                'projectAnswerRecord' => self::getProjectAnswerRecordNameTemplate(),
                'projectLocationAnswerRecord' => self::getProjectLocationAnswerRecordNameTemplate(),
            ];
        }

        return self::$pathTemplateMap;
    }

    /**
     * Formats a string containing the fully-qualified path to represent
     * a answer_record resource.
     *
     * @param string $project
     * @param string $answerRecord
     *
     * @return string The formatted answer_record resource.
     * @experimental
     */
    public static function answerRecordName($project, $answerRecord)
    {
        return self::getAnswerRecordNameTemplate()->render([
            'project' => $project,
            'answer_record' => $answerRecord,
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
     * a project resource.
     *
     * @param string $project
     *
     * @return string The formatted project resource.
     * @experimental
     */
    public static function projectName($project)
    {
        return self::getProjectNameTemplate()->render([
            'project' => $project,
        ]);
    }

    /**
     * Formats a string containing the fully-qualified path to represent
     * a project_answer_record resource.
     *
     * @param string $project
     * @param string $answerRecord
     *
     * @return string The formatted project_answer_record resource.
     * @experimental
     */
    public static function projectAnswerRecordName($project, $answerRecord)
    {
        return self::getProjectAnswerRecordNameTemplate()->render([
            'project' => $project,
            'answer_record' => $answerRecord,
        ]);
    }

    /**
     * Formats a string containing the fully-qualified path to represent
     * a project_location_answer_record resource.
     *
     * @param string $project
     * @param string $location
     * @param string $answerRecord
     *
     * @return string The formatted project_location_answer_record resource.
     * @experimental
     */
    public static function projectLocationAnswerRecordName($project, $location, $answerRecord)
    {
        return self::getProjectLocationAnswerRecordNameTemplate()->render([
            'project' => $project,
            'location' => $location,
            'answer_record' => $answerRecord,
        ]);
    }

    /**
     * Parses a formatted name string and returns an associative array of the components in the name.
     * The following name formats are supported:
     * Template: Pattern
     * - answerRecord: projects/{project}/answerRecords/{answer_record}
     * - location: projects/{project}/locations/{location}
     * - project: projects/{project}
     * - projectAnswerRecord: projects/{project}/answerRecords/{answer_record}
     * - projectLocationAnswerRecord: projects/{project}/locations/{location}/answerRecords/{answer_record}.
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
     * Constructor.
     *
     * @param array $options {
     *                       Optional. Options for configuring the service API wrapper.
     *
     *     @type string $serviceAddress
     *           The address of the API remote host. May optionally include the port, formatted
     *           as "<uri>:<port>". Default 'dialogflow.googleapis.com:443'.
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
    }

    /**
     * Returns the list of all answer records in the specified project in reverse
     * chronological order.
     *
     * Sample code:
     * ```
     * $answerRecordsClient = new AnswerRecordsClient();
     * try {
     *     $formattedParent = $answerRecordsClient->projectName('[PROJECT]');
     *     $filter = '';
     *     // Iterate over pages of elements
     *     $pagedResponse = $answerRecordsClient->listAnswerRecords($formattedParent, $filter);
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
     *     $pagedResponse = $answerRecordsClient->listAnswerRecords($formattedParent, $filter);
     *     foreach ($pagedResponse->iterateAllElements() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $answerRecordsClient->close();
     * }
     * ```
     *
     * @param string $parent Required. The project to list all answer records for in reverse
     *                       chronological order. Format: `projects/<Project ID>/locations/<Location
     *                       ID>`.
     * @param string $filter Required. Filters to restrict results to specific answer records.
     *                       Filter on answer record type. Currently predicates on `type` is supported,
     *                       valid values are `ARTICLE_ANSWER`, `FAQ_ANSWER`.
     *
     * For more information about filtering, see
     * [API Filtering](https://aip.dev/160).
     * @param array $optionalArgs {
     *                            Optional.
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
    public function listAnswerRecords($parent, $filter, array $optionalArgs = [])
    {
        $request = new ListAnswerRecordsRequest();
        $request->setParent($parent);
        $request->setFilter($filter);
        if (isset($optionalArgs['pageSize'])) {
            $request->setPageSize($optionalArgs['pageSize']);
        }
        if (isset($optionalArgs['pageToken'])) {
            $request->setPageToken($optionalArgs['pageToken']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->getPagedListResponse(
            'ListAnswerRecords',
            $optionalArgs,
            ListAnswerRecordsResponse::class,
            $request
        );
    }

    /**
     * Updates the specified answer record.
     *
     * Sample code:
     * ```
     * $answerRecordsClient = new AnswerRecordsClient();
     * try {
     *     $answerRecord = new AnswerRecord();
     *     $updateMask = new FieldMask();
     *     $response = $answerRecordsClient->updateAnswerRecord($answerRecord, $updateMask);
     * } finally {
     *     $answerRecordsClient->close();
     * }
     * ```
     *
     * @param AnswerRecord $answerRecord Required. Answer record to update.
     * @param FieldMask    $updateMask   Required. The mask to control which fields get updated.
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
     * @return \Google\Cloud\Dialogflow\V2\AnswerRecord
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function updateAnswerRecord($answerRecord, $updateMask, array $optionalArgs = [])
    {
        $request = new UpdateAnswerRecordRequest();
        $request->setAnswerRecord($answerRecord);
        $request->setUpdateMask($updateMask);

        $requestParams = new RequestParamsHeaderDescriptor([
          'answer_record.name' => $request->getAnswerRecord()->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'UpdateAnswerRecord',
            AnswerRecord::class,
            $optionalArgs,
            $request
        )->wait();
    }
}
