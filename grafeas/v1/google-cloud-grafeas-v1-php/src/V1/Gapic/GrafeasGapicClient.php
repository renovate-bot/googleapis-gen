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
 * https://github.com/google/googleapis/blob/master/grafeas/v1/grafeas.proto
 * and updates to that file get reflected here through a refresh process.
 */

namespace Grafeas\V1\Gapic;

use Google\ApiCore\ApiException;
use Google\ApiCore\CredentialsWrapper;
use Google\ApiCore\GapicClientTrait;

use Google\ApiCore\PathTemplate;

use Google\ApiCore\RequestParamsHeaderDescriptor;
use Google\ApiCore\RetrySettings;
use Google\ApiCore\Transport\TransportInterface;
use Google\ApiCore\ValidationException;
use Google\Auth\FetchAuthTokenInterface;
use Google\Protobuf\FieldMask;
use Google\Protobuf\GPBEmpty;
use Grafeas\V1\BatchCreateNotesRequest;
use Grafeas\V1\BatchCreateNotesResponse;
use Grafeas\V1\BatchCreateOccurrencesRequest;
use Grafeas\V1\BatchCreateOccurrencesResponse;
use Grafeas\V1\CreateNoteRequest;
use Grafeas\V1\CreateOccurrenceRequest;
use Grafeas\V1\DeleteNoteRequest;
use Grafeas\V1\DeleteOccurrenceRequest;
use Grafeas\V1\GetNoteRequest;
use Grafeas\V1\GetOccurrenceNoteRequest;
use Grafeas\V1\GetOccurrenceRequest;
use Grafeas\V1\ListNoteOccurrencesRequest;
use Grafeas\V1\ListNoteOccurrencesResponse;
use Grafeas\V1\ListNotesRequest;
use Grafeas\V1\ListNotesResponse;
use Grafeas\V1\ListOccurrencesRequest;
use Grafeas\V1\ListOccurrencesResponse;
use Grafeas\V1\Note;
use Grafeas\V1\Occurrence;
use Grafeas\V1\UpdateNoteRequest;
use Grafeas\V1\UpdateOccurrenceRequest;

/**
 * Service Description: [Grafeas](https://grafeas.io) API.
 *
 * Retrieves analysis results of Cloud components such as Docker container
 * images.
 *
 * Analysis results are stored as a series of occurrences. An `Occurrence`
 * contains information about a specific analysis instance on a resource. An
 * occurrence refers to a `Note`. A note contains details describing the
 * analysis and is generally stored in a separate project, called a `Provider`.
 * Multiple occurrences can refer to the same note.
 *
 * For example, an SSL vulnerability could affect multiple images. In this case,
 * there would be one note for the vulnerability and an occurrence for each
 * image with the vulnerability referring to that note.
 *
 * This class provides the ability to make remote calls to the backing service through method
 * calls that map to API methods. Sample code to get started:
 *
 * ```
 * $grafeasClient = new GrafeasClient();
 * try {
 *     $formattedParent = $grafeasClient->projectName('[PROJECT]');
 *     $notes = [];
 *     $response = $grafeasClient->batchCreateNotes($formattedParent, $notes);
 * } finally {
 *     $grafeasClient->close();
 * }
 * ```
 *
 * Many parameters require resource names to be formatted in a particular way. To
 * assistwith these names, this class includes a format method for each type of
 * name, and additionallya parseName method to extract the individual identifiers
 * contained within formatted namesthat are returned by the API.
 */
class GrafeasGapicClient
{
    use GapicClientTrait;

    /**
     * The name of the service.
     */
    const SERVICE_NAME = 'grafeas.v1.Grafeas';

    /**
     * The default address of the service.
     */
    const SERVICE_ADDRESS = 'containeranalysis.googleapis.com';

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
    public static $serviceScopes = [];

    private static $noteNameTemplate;

    private static $occurrenceNameTemplate;

    private static $projectNameTemplate;

    private static $pathTemplateMap;

    private static function getClientDefaults()
    {
        return [
            'serviceName' => self::SERVICE_NAME,
            'serviceAddress' => self::SERVICE_ADDRESS . ':' . self::DEFAULT_SERVICE_PORT,
            'clientConfig' => __DIR__ . '/../resources/grafeas_client_config.json',
            'descriptorsConfigPath' => __DIR__ . '/../resources/grafeas_descriptor_config.php',
            'gcpApiConfigPath' => __DIR__ . '/../resources/grafeas_grpc_config.json',
            'credentialsConfig' => [
                'defaultScopes' => self::$serviceScopes,
            ],
            'transportConfig' => [
                'rest' => [
                    'restClientConfigPath' => __DIR__ . '/../resources/grafeas_rest_client_config.php',
                ],
            ],
        ];
    }

    private static function getNoteNameTemplate()
    {
        if (self::$noteNameTemplate == null) {
            self::$noteNameTemplate = new PathTemplate('projects/{project}/notes/{note}');
        }

        return self::$noteNameTemplate;
    }

    private static function getOccurrenceNameTemplate()
    {
        if (self::$occurrenceNameTemplate == null) {
            self::$occurrenceNameTemplate = new PathTemplate('projects/{project}/occurrences/{occurrence}');
        }

        return self::$occurrenceNameTemplate;
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
                'note' => self::getNoteNameTemplate(),
                'occurrence' => self::getOccurrenceNameTemplate(),
                'project' => self::getProjectNameTemplate(),
            ];
        }

        return self::$pathTemplateMap;
    }

    /**
     * Formats a string containing the fully-qualified path to represent a note
     * resource.
     *
     * @param string $project
     * @param string $note
     *
     * @return string The formatted note resource.
     */
    public static function noteName($project, $note)
    {
        return self::getNoteNameTemplate()->render([
            'project' => $project,
            'note' => $note,
        ]);
    }

    /**
     * Formats a string containing the fully-qualified path to represent a occurrence
     * resource.
     *
     * @param string $project
     * @param string $occurrence
     *
     * @return string The formatted occurrence resource.
     */
    public static function occurrenceName($project, $occurrence)
    {
        return self::getOccurrenceNameTemplate()->render([
            'project' => $project,
            'occurrence' => $occurrence,
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
     * - note: projects/{project}/notes/{note}
     * - occurrence: projects/{project}/occurrences/{occurrence}
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
     *           as "<uri>:<port>". Default 'containeranalysis.googleapis.com:443'.
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
     * Creates new notes in batch.
     *
     * Sample code:
     * ```
     * $grafeasClient = new GrafeasClient();
     * try {
     *     $formattedParent = $grafeasClient->projectName('[PROJECT]');
     *     $notes = [];
     *     $response = $grafeasClient->batchCreateNotes($formattedParent, $notes);
     * } finally {
     *     $grafeasClient->close();
     * }
     * ```
     *
     * @param string $parent       The name of the project in the form of `projects/[PROJECT_ID]`, under which
     *                             the notes are to be created.
     * @param array  $notes        The notes to create. Max allowed length is 1000.
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
     * @return \Grafeas\V1\BatchCreateNotesResponse
     *
     * @throws ApiException if the remote call fails
     */
    public function batchCreateNotes($parent, $notes, array $optionalArgs = [])
    {
        $request = new BatchCreateNotesRequest();
        $requestParamHeaders = [];
        $request->setParent($parent);
        $request->setNotes($notes);
        $requestParamHeaders['parent'] = $parent;
        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('BatchCreateNotes', BatchCreateNotesResponse::class, $optionalArgs, $request)->wait();
    }

    /**
     * Creates new occurrences in batch.
     *
     * Sample code:
     * ```
     * $grafeasClient = new GrafeasClient();
     * try {
     *     $formattedParent = $grafeasClient->projectName('[PROJECT]');
     *     $occurrences = [];
     *     $response = $grafeasClient->batchCreateOccurrences($formattedParent, $occurrences);
     * } finally {
     *     $grafeasClient->close();
     * }
     * ```
     *
     * @param string       $parent       The name of the project in the form of `projects/[PROJECT_ID]`, under which
     *                                   the occurrences are to be created.
     * @param Occurrence[] $occurrences  The occurrences to create. Max allowed length is 1000.
     * @param array        $optionalArgs {
     *     Optional.
     *
     *     @type RetrySettings|array $retrySettings
     *           Retry settings to use for this call. Can be a
     *           {@see Google\ApiCore\RetrySettings} object, or an associative array of retry
     *           settings parameters. See the documentation on
     *           {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Grafeas\V1\BatchCreateOccurrencesResponse
     *
     * @throws ApiException if the remote call fails
     */
    public function batchCreateOccurrences($parent, $occurrences, array $optionalArgs = [])
    {
        $request = new BatchCreateOccurrencesRequest();
        $requestParamHeaders = [];
        $request->setParent($parent);
        $request->setOccurrences($occurrences);
        $requestParamHeaders['parent'] = $parent;
        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('BatchCreateOccurrences', BatchCreateOccurrencesResponse::class, $optionalArgs, $request)->wait();
    }

    /**
     * Creates a new note.
     *
     * Sample code:
     * ```
     * $grafeasClient = new GrafeasClient();
     * try {
     *     $formattedParent = $grafeasClient->projectName('[PROJECT]');
     *     $noteId = 'note_id';
     *     $note = new Note();
     *     $response = $grafeasClient->createNote($formattedParent, $noteId, $note);
     * } finally {
     *     $grafeasClient->close();
     * }
     * ```
     *
     * @param string $parent       The name of the project in the form of `projects/[PROJECT_ID]`, under which
     *                             the note is to be created.
     * @param string $noteId       The ID to use for this note.
     * @param Note   $note         The note to create.
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
     * @return \Grafeas\V1\Note
     *
     * @throws ApiException if the remote call fails
     */
    public function createNote($parent, $noteId, $note, array $optionalArgs = [])
    {
        $request = new CreateNoteRequest();
        $requestParamHeaders = [];
        $request->setParent($parent);
        $request->setNoteId($noteId);
        $request->setNote($note);
        $requestParamHeaders['parent'] = $parent;
        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('CreateNote', Note::class, $optionalArgs, $request)->wait();
    }

    /**
     * Creates a new occurrence.
     *
     * Sample code:
     * ```
     * $grafeasClient = new GrafeasClient();
     * try {
     *     $formattedParent = $grafeasClient->projectName('[PROJECT]');
     *     $occurrence = new Occurrence();
     *     $response = $grafeasClient->createOccurrence($formattedParent, $occurrence);
     * } finally {
     *     $grafeasClient->close();
     * }
     * ```
     *
     * @param string     $parent       The name of the project in the form of `projects/[PROJECT_ID]`, under which
     *                                 the occurrence is to be created.
     * @param Occurrence $occurrence   The occurrence to create.
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
     * @return \Grafeas\V1\Occurrence
     *
     * @throws ApiException if the remote call fails
     */
    public function createOccurrence($parent, $occurrence, array $optionalArgs = [])
    {
        $request = new CreateOccurrenceRequest();
        $requestParamHeaders = [];
        $request->setParent($parent);
        $request->setOccurrence($occurrence);
        $requestParamHeaders['parent'] = $parent;
        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('CreateOccurrence', Occurrence::class, $optionalArgs, $request)->wait();
    }

    /**
     * Deletes the specified note.
     *
     * Sample code:
     * ```
     * $grafeasClient = new GrafeasClient();
     * try {
     *     $formattedName = $grafeasClient->noteName('[PROJECT]', '[NOTE]');
     *     $grafeasClient->deleteNote($formattedName);
     * } finally {
     *     $grafeasClient->close();
     * }
     * ```
     *
     * @param string $name         The name of the note in the form of
     *                             `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
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
    public function deleteNote($name, array $optionalArgs = [])
    {
        $request = new DeleteNoteRequest();
        $requestParamHeaders = [];
        $request->setName($name);
        $requestParamHeaders['name'] = $name;
        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('DeleteNote', GPBEmpty::class, $optionalArgs, $request)->wait();
    }

    /**
     * Deletes the specified occurrence. For example, use this method to delete an
     * occurrence when the occurrence is no longer applicable for the given
     * resource.
     *
     * Sample code:
     * ```
     * $grafeasClient = new GrafeasClient();
     * try {
     *     $formattedName = $grafeasClient->occurrenceName('[PROJECT]', '[OCCURRENCE]');
     *     $grafeasClient->deleteOccurrence($formattedName);
     * } finally {
     *     $grafeasClient->close();
     * }
     * ```
     *
     * @param string $name         The name of the occurrence in the form of
     *                             `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
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
    public function deleteOccurrence($name, array $optionalArgs = [])
    {
        $request = new DeleteOccurrenceRequest();
        $requestParamHeaders = [];
        $request->setName($name);
        $requestParamHeaders['name'] = $name;
        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('DeleteOccurrence', GPBEmpty::class, $optionalArgs, $request)->wait();
    }

    /**
     * Gets the specified note.
     *
     * Sample code:
     * ```
     * $grafeasClient = new GrafeasClient();
     * try {
     *     $formattedName = $grafeasClient->noteName('[PROJECT]', '[NOTE]');
     *     $response = $grafeasClient->getNote($formattedName);
     * } finally {
     *     $grafeasClient->close();
     * }
     * ```
     *
     * @param string $name         The name of the note in the form of
     *                             `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
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
     * @return \Grafeas\V1\Note
     *
     * @throws ApiException if the remote call fails
     */
    public function getNote($name, array $optionalArgs = [])
    {
        $request = new GetNoteRequest();
        $requestParamHeaders = [];
        $request->setName($name);
        $requestParamHeaders['name'] = $name;
        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('GetNote', Note::class, $optionalArgs, $request)->wait();
    }

    /**
     * Gets the specified occurrence.
     *
     * Sample code:
     * ```
     * $grafeasClient = new GrafeasClient();
     * try {
     *     $formattedName = $grafeasClient->occurrenceName('[PROJECT]', '[OCCURRENCE]');
     *     $response = $grafeasClient->getOccurrence($formattedName);
     * } finally {
     *     $grafeasClient->close();
     * }
     * ```
     *
     * @param string $name         The name of the occurrence in the form of
     *                             `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
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
     * @return \Grafeas\V1\Occurrence
     *
     * @throws ApiException if the remote call fails
     */
    public function getOccurrence($name, array $optionalArgs = [])
    {
        $request = new GetOccurrenceRequest();
        $requestParamHeaders = [];
        $request->setName($name);
        $requestParamHeaders['name'] = $name;
        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('GetOccurrence', Occurrence::class, $optionalArgs, $request)->wait();
    }

    /**
     * Gets the note attached to the specified occurrence. Consumer projects can
     * use this method to get a note that belongs to a provider project.
     *
     * Sample code:
     * ```
     * $grafeasClient = new GrafeasClient();
     * try {
     *     $formattedName = $grafeasClient->occurrenceName('[PROJECT]', '[OCCURRENCE]');
     *     $response = $grafeasClient->getOccurrenceNote($formattedName);
     * } finally {
     *     $grafeasClient->close();
     * }
     * ```
     *
     * @param string $name         The name of the occurrence in the form of
     *                             `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
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
     * @return \Grafeas\V1\Note
     *
     * @throws ApiException if the remote call fails
     */
    public function getOccurrenceNote($name, array $optionalArgs = [])
    {
        $request = new GetOccurrenceNoteRequest();
        $requestParamHeaders = [];
        $request->setName($name);
        $requestParamHeaders['name'] = $name;
        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('GetOccurrenceNote', Note::class, $optionalArgs, $request)->wait();
    }

    /**
     * Lists occurrences referencing the specified note. Provider projects can use
     * this method to get all occurrences across consumer projects referencing the
     * specified note.
     *
     * Sample code:
     * ```
     * $grafeasClient = new GrafeasClient();
     * try {
     *     $formattedName = $grafeasClient->noteName('[PROJECT]', '[NOTE]');
     *     // Iterate over pages of elements
     *     $pagedResponse = $grafeasClient->listNoteOccurrences($formattedName);
     *     foreach ($pagedResponse->iteratePages() as $page) {
     *         foreach ($page as $element) {
     *             // doSomethingWith($element);
     *         }
     *     }
     *     // Alternatively:
     *     // Iterate through all elements
     *     $pagedResponse = $grafeasClient->listNoteOccurrences($formattedName);
     *     foreach ($pagedResponse->iterateAllElements() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $grafeasClient->close();
     * }
     * ```
     *
     * @param string $name         The name of the note to list occurrences for in the form of
     *                             `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
     * @param array  $optionalArgs {
     *     Optional.
     *
     *     @type string $filter
     *           The filter expression.
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
    public function listNoteOccurrences($name, array $optionalArgs = [])
    {
        $request = new ListNoteOccurrencesRequest();
        $requestParamHeaders = [];
        $request->setName($name);
        $requestParamHeaders['name'] = $name;
        if (isset($optionalArgs['filter'])) {
            $request->setFilter($optionalArgs['filter']);
        }

        if (isset($optionalArgs['pageSize'])) {
            $request->setPageSize($optionalArgs['pageSize']);
        }

        if (isset($optionalArgs['pageToken'])) {
            $request->setPageToken($optionalArgs['pageToken']);
        }

        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->getPagedListResponse('ListNoteOccurrences', $optionalArgs, ListNoteOccurrencesResponse::class, $request);
    }

    /**
     * Lists notes for the specified project.
     *
     * Sample code:
     * ```
     * $grafeasClient = new GrafeasClient();
     * try {
     *     $formattedParent = $grafeasClient->projectName('[PROJECT]');
     *     // Iterate over pages of elements
     *     $pagedResponse = $grafeasClient->listNotes($formattedParent);
     *     foreach ($pagedResponse->iteratePages() as $page) {
     *         foreach ($page as $element) {
     *             // doSomethingWith($element);
     *         }
     *     }
     *     // Alternatively:
     *     // Iterate through all elements
     *     $pagedResponse = $grafeasClient->listNotes($formattedParent);
     *     foreach ($pagedResponse->iterateAllElements() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $grafeasClient->close();
     * }
     * ```
     *
     * @param string $parent       The name of the project to list notes for in the form of
     *                             `projects/[PROJECT_ID]`.
     * @param array  $optionalArgs {
     *     Optional.
     *
     *     @type string $filter
     *           The filter expression.
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
    public function listNotes($parent, array $optionalArgs = [])
    {
        $request = new ListNotesRequest();
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

        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->getPagedListResponse('ListNotes', $optionalArgs, ListNotesResponse::class, $request);
    }

    /**
     * Lists occurrences for the specified project.
     *
     * Sample code:
     * ```
     * $grafeasClient = new GrafeasClient();
     * try {
     *     $formattedParent = $grafeasClient->projectName('[PROJECT]');
     *     // Iterate over pages of elements
     *     $pagedResponse = $grafeasClient->listOccurrences($formattedParent);
     *     foreach ($pagedResponse->iteratePages() as $page) {
     *         foreach ($page as $element) {
     *             // doSomethingWith($element);
     *         }
     *     }
     *     // Alternatively:
     *     // Iterate through all elements
     *     $pagedResponse = $grafeasClient->listOccurrences($formattedParent);
     *     foreach ($pagedResponse->iterateAllElements() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $grafeasClient->close();
     * }
     * ```
     *
     * @param string $parent       The name of the project to list occurrences for in the form of
     *                             `projects/[PROJECT_ID]`.
     * @param array  $optionalArgs {
     *     Optional.
     *
     *     @type string $filter
     *           The filter expression.
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
    public function listOccurrences($parent, array $optionalArgs = [])
    {
        $request = new ListOccurrencesRequest();
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

        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->getPagedListResponse('ListOccurrences', $optionalArgs, ListOccurrencesResponse::class, $request);
    }

    /**
     * Updates the specified note.
     *
     * Sample code:
     * ```
     * $grafeasClient = new GrafeasClient();
     * try {
     *     $formattedName = $grafeasClient->noteName('[PROJECT]', '[NOTE]');
     *     $note = new Note();
     *     $response = $grafeasClient->updateNote($formattedName, $note);
     * } finally {
     *     $grafeasClient->close();
     * }
     * ```
     *
     * @param string $name         The name of the note in the form of
     *                             `projects/[PROVIDER_ID]/notes/[NOTE_ID]`.
     * @param Note   $note         The updated note.
     * @param array  $optionalArgs {
     *     Optional.
     *
     *     @type FieldMask $updateMask
     *           The fields to update.
     *     @type RetrySettings|array $retrySettings
     *           Retry settings to use for this call. Can be a
     *           {@see Google\ApiCore\RetrySettings} object, or an associative array of retry
     *           settings parameters. See the documentation on
     *           {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Grafeas\V1\Note
     *
     * @throws ApiException if the remote call fails
     */
    public function updateNote($name, $note, array $optionalArgs = [])
    {
        $request = new UpdateNoteRequest();
        $requestParamHeaders = [];
        $request->setName($name);
        $request->setNote($note);
        $requestParamHeaders['name'] = $name;
        if (isset($optionalArgs['updateMask'])) {
            $request->setUpdateMask($optionalArgs['updateMask']);
        }

        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('UpdateNote', Note::class, $optionalArgs, $request)->wait();
    }

    /**
     * Updates the specified occurrence.
     *
     * Sample code:
     * ```
     * $grafeasClient = new GrafeasClient();
     * try {
     *     $formattedName = $grafeasClient->occurrenceName('[PROJECT]', '[OCCURRENCE]');
     *     $occurrence = new Occurrence();
     *     $response = $grafeasClient->updateOccurrence($formattedName, $occurrence);
     * } finally {
     *     $grafeasClient->close();
     * }
     * ```
     *
     * @param string     $name         The name of the occurrence in the form of
     *                                 `projects/[PROJECT_ID]/occurrences/[OCCURRENCE_ID]`.
     * @param Occurrence $occurrence   The updated occurrence.
     * @param array      $optionalArgs {
     *     Optional.
     *
     *     @type FieldMask $updateMask
     *           The fields to update.
     *     @type RetrySettings|array $retrySettings
     *           Retry settings to use for this call. Can be a
     *           {@see Google\ApiCore\RetrySettings} object, or an associative array of retry
     *           settings parameters. See the documentation on
     *           {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Grafeas\V1\Occurrence
     *
     * @throws ApiException if the remote call fails
     */
    public function updateOccurrence($name, $occurrence, array $optionalArgs = [])
    {
        $request = new UpdateOccurrenceRequest();
        $requestParamHeaders = [];
        $request->setName($name);
        $request->setOccurrence($occurrence);
        $requestParamHeaders['name'] = $name;
        if (isset($optionalArgs['updateMask'])) {
            $request->setUpdateMask($optionalArgs['updateMask']);
        }

        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('UpdateOccurrence', Occurrence::class, $optionalArgs, $request)->wait();
    }
}
