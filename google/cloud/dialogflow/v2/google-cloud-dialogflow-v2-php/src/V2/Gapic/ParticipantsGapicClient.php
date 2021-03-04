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
 * https://github.com/google/googleapis/blob/master/google/cloud/dialogflow/v2/participant.proto
 * and updates to that file get reflected here through a refresh process.
 *
 * @experimental
 */

namespace Google\Cloud\Dialogflow\V2\Gapic;

use Google\ApiCore\ApiException;
use Google\ApiCore\Call;
use Google\ApiCore\CredentialsWrapper;
use Google\ApiCore\GapicClientTrait;
use Google\ApiCore\PathTemplate;
use Google\ApiCore\RequestParamsHeaderDescriptor;
use Google\ApiCore\RetrySettings;
use Google\ApiCore\Transport\TransportInterface;
use Google\ApiCore\ValidationException;
use Google\Auth\FetchAuthTokenInterface;
use Google\Cloud\Dialogflow\V2\AnalyzeContentRequest;
use Google\Cloud\Dialogflow\V2\AnalyzeContentResponse;
use Google\Cloud\Dialogflow\V2\AudioInput;
use Google\Cloud\Dialogflow\V2\CreateParticipantRequest;
use Google\Cloud\Dialogflow\V2\EventInput;
use Google\Cloud\Dialogflow\V2\GetParticipantRequest;
use Google\Cloud\Dialogflow\V2\ListParticipantsRequest;
use Google\Cloud\Dialogflow\V2\ListParticipantsResponse;
use Google\Cloud\Dialogflow\V2\OutputAudioConfig;
use Google\Cloud\Dialogflow\V2\Participant;
use Google\Cloud\Dialogflow\V2\QueryParameters;
use Google\Cloud\Dialogflow\V2\StreamingAnalyzeContentRequest;
use Google\Cloud\Dialogflow\V2\StreamingAnalyzeContentResponse;
use Google\Cloud\Dialogflow\V2\SuggestArticlesRequest;
use Google\Cloud\Dialogflow\V2\SuggestArticlesResponse;
use Google\Cloud\Dialogflow\V2\SuggestFaqAnswersRequest;
use Google\Cloud\Dialogflow\V2\SuggestFaqAnswersResponse;
use Google\Cloud\Dialogflow\V2\TextInput;
use Google\Cloud\Dialogflow\V2\UpdateParticipantRequest;
use Google\Protobuf\FieldMask;

/**
 * Service Description: Service for managing [Participants][google.cloud.dialogflow.v2.Participant].
 *
 * This class provides the ability to make remote calls to the backing service through method
 * calls that map to API methods. Sample code to get started:
 *
 * ```
 * $participantsClient = new ParticipantsClient();
 * try {
 *     $parent = '';
 *     $participant = new Participant();
 *     $response = $participantsClient->createParticipant($parent, $participant);
 * } finally {
 *     $participantsClient->close();
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
class ParticipantsGapicClient
{
    use GapicClientTrait;

    /**
     * The name of the service.
     */
    const SERVICE_NAME = 'google.cloud.dialogflow.v2.Participants';

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
    private static $conversationNameTemplate;
    private static $messageNameTemplate;
    private static $participantNameTemplate;
    private static $projectConversationNameTemplate;
    private static $projectConversationMessageNameTemplate;
    private static $projectConversationParticipantNameTemplate;
    private static $projectLocationConversationNameTemplate;
    private static $projectLocationConversationMessageNameTemplate;
    private static $projectLocationConversationParticipantNameTemplate;
    private static $pathTemplateMap;

    private static function getClientDefaults()
    {
        return [
            'serviceName' => self::SERVICE_NAME,
            'serviceAddress' => self::SERVICE_ADDRESS.':'.self::DEFAULT_SERVICE_PORT,
            'clientConfig' => __DIR__.'/../resources/participants_client_config.json',
            'descriptorsConfigPath' => __DIR__.'/../resources/participants_descriptor_config.php',
            'gcpApiConfigPath' => __DIR__.'/../resources/participants_grpc_config.json',
            'credentialsConfig' => [
                'defaultScopes' => self::$serviceScopes,
            ],
            'transportConfig' => [
                'rest' => [
                    'restClientConfigPath' => __DIR__.'/../resources/participants_rest_client_config.php',
                ],
            ],
        ];
    }

    private static function getConversationNameTemplate()
    {
        if (null == self::$conversationNameTemplate) {
            self::$conversationNameTemplate = new PathTemplate('projects/{project}/conversations/{conversation}');
        }

        return self::$conversationNameTemplate;
    }

    private static function getMessageNameTemplate()
    {
        if (null == self::$messageNameTemplate) {
            self::$messageNameTemplate = new PathTemplate('projects/{project}/conversations/{conversation}/messages/{message}');
        }

        return self::$messageNameTemplate;
    }

    private static function getParticipantNameTemplate()
    {
        if (null == self::$participantNameTemplate) {
            self::$participantNameTemplate = new PathTemplate('projects/{project}/conversations/{conversation}/participants/{participant}');
        }

        return self::$participantNameTemplate;
    }

    private static function getProjectConversationNameTemplate()
    {
        if (null == self::$projectConversationNameTemplate) {
            self::$projectConversationNameTemplate = new PathTemplate('projects/{project}/conversations/{conversation}');
        }

        return self::$projectConversationNameTemplate;
    }

    private static function getProjectConversationMessageNameTemplate()
    {
        if (null == self::$projectConversationMessageNameTemplate) {
            self::$projectConversationMessageNameTemplate = new PathTemplate('projects/{project}/conversations/{conversation}/messages/{message}');
        }

        return self::$projectConversationMessageNameTemplate;
    }

    private static function getProjectConversationParticipantNameTemplate()
    {
        if (null == self::$projectConversationParticipantNameTemplate) {
            self::$projectConversationParticipantNameTemplate = new PathTemplate('projects/{project}/conversations/{conversation}/participants/{participant}');
        }

        return self::$projectConversationParticipantNameTemplate;
    }

    private static function getProjectLocationConversationNameTemplate()
    {
        if (null == self::$projectLocationConversationNameTemplate) {
            self::$projectLocationConversationNameTemplate = new PathTemplate('projects/{project}/locations/{location}/conversations/{conversation}');
        }

        return self::$projectLocationConversationNameTemplate;
    }

    private static function getProjectLocationConversationMessageNameTemplate()
    {
        if (null == self::$projectLocationConversationMessageNameTemplate) {
            self::$projectLocationConversationMessageNameTemplate = new PathTemplate('projects/{project}/locations/{location}/conversations/{conversation}/messages/{message}');
        }

        return self::$projectLocationConversationMessageNameTemplate;
    }

    private static function getProjectLocationConversationParticipantNameTemplate()
    {
        if (null == self::$projectLocationConversationParticipantNameTemplate) {
            self::$projectLocationConversationParticipantNameTemplate = new PathTemplate('projects/{project}/locations/{location}/conversations/{conversation}/participants/{participant}');
        }

        return self::$projectLocationConversationParticipantNameTemplate;
    }

    private static function getPathTemplateMap()
    {
        if (null == self::$pathTemplateMap) {
            self::$pathTemplateMap = [
                'conversation' => self::getConversationNameTemplate(),
                'message' => self::getMessageNameTemplate(),
                'participant' => self::getParticipantNameTemplate(),
                'projectConversation' => self::getProjectConversationNameTemplate(),
                'projectConversationMessage' => self::getProjectConversationMessageNameTemplate(),
                'projectConversationParticipant' => self::getProjectConversationParticipantNameTemplate(),
                'projectLocationConversation' => self::getProjectLocationConversationNameTemplate(),
                'projectLocationConversationMessage' => self::getProjectLocationConversationMessageNameTemplate(),
                'projectLocationConversationParticipant' => self::getProjectLocationConversationParticipantNameTemplate(),
            ];
        }

        return self::$pathTemplateMap;
    }

    /**
     * Formats a string containing the fully-qualified path to represent
     * a conversation resource.
     *
     * @param string $project
     * @param string $conversation
     *
     * @return string The formatted conversation resource.
     * @experimental
     */
    public static function conversationName($project, $conversation)
    {
        return self::getConversationNameTemplate()->render([
            'project' => $project,
            'conversation' => $conversation,
        ]);
    }

    /**
     * Formats a string containing the fully-qualified path to represent
     * a message resource.
     *
     * @param string $project
     * @param string $conversation
     * @param string $message
     *
     * @return string The formatted message resource.
     * @experimental
     */
    public static function messageName($project, $conversation, $message)
    {
        return self::getMessageNameTemplate()->render([
            'project' => $project,
            'conversation' => $conversation,
            'message' => $message,
        ]);
    }

    /**
     * Formats a string containing the fully-qualified path to represent
     * a participant resource.
     *
     * @param string $project
     * @param string $conversation
     * @param string $participant
     *
     * @return string The formatted participant resource.
     * @experimental
     */
    public static function participantName($project, $conversation, $participant)
    {
        return self::getParticipantNameTemplate()->render([
            'project' => $project,
            'conversation' => $conversation,
            'participant' => $participant,
        ]);
    }

    /**
     * Formats a string containing the fully-qualified path to represent
     * a project_conversation resource.
     *
     * @param string $project
     * @param string $conversation
     *
     * @return string The formatted project_conversation resource.
     * @experimental
     */
    public static function projectConversationName($project, $conversation)
    {
        return self::getProjectConversationNameTemplate()->render([
            'project' => $project,
            'conversation' => $conversation,
        ]);
    }

    /**
     * Formats a string containing the fully-qualified path to represent
     * a project_conversation_message resource.
     *
     * @param string $project
     * @param string $conversation
     * @param string $message
     *
     * @return string The formatted project_conversation_message resource.
     * @experimental
     */
    public static function projectConversationMessageName($project, $conversation, $message)
    {
        return self::getProjectConversationMessageNameTemplate()->render([
            'project' => $project,
            'conversation' => $conversation,
            'message' => $message,
        ]);
    }

    /**
     * Formats a string containing the fully-qualified path to represent
     * a project_conversation_participant resource.
     *
     * @param string $project
     * @param string $conversation
     * @param string $participant
     *
     * @return string The formatted project_conversation_participant resource.
     * @experimental
     */
    public static function projectConversationParticipantName($project, $conversation, $participant)
    {
        return self::getProjectConversationParticipantNameTemplate()->render([
            'project' => $project,
            'conversation' => $conversation,
            'participant' => $participant,
        ]);
    }

    /**
     * Formats a string containing the fully-qualified path to represent
     * a project_location_conversation resource.
     *
     * @param string $project
     * @param string $location
     * @param string $conversation
     *
     * @return string The formatted project_location_conversation resource.
     * @experimental
     */
    public static function projectLocationConversationName($project, $location, $conversation)
    {
        return self::getProjectLocationConversationNameTemplate()->render([
            'project' => $project,
            'location' => $location,
            'conversation' => $conversation,
        ]);
    }

    /**
     * Formats a string containing the fully-qualified path to represent
     * a project_location_conversation_message resource.
     *
     * @param string $project
     * @param string $location
     * @param string $conversation
     * @param string $message
     *
     * @return string The formatted project_location_conversation_message resource.
     * @experimental
     */
    public static function projectLocationConversationMessageName($project, $location, $conversation, $message)
    {
        return self::getProjectLocationConversationMessageNameTemplate()->render([
            'project' => $project,
            'location' => $location,
            'conversation' => $conversation,
            'message' => $message,
        ]);
    }

    /**
     * Formats a string containing the fully-qualified path to represent
     * a project_location_conversation_participant resource.
     *
     * @param string $project
     * @param string $location
     * @param string $conversation
     * @param string $participant
     *
     * @return string The formatted project_location_conversation_participant resource.
     * @experimental
     */
    public static function projectLocationConversationParticipantName($project, $location, $conversation, $participant)
    {
        return self::getProjectLocationConversationParticipantNameTemplate()->render([
            'project' => $project,
            'location' => $location,
            'conversation' => $conversation,
            'participant' => $participant,
        ]);
    }

    /**
     * Parses a formatted name string and returns an associative array of the components in the name.
     * The following name formats are supported:
     * Template: Pattern
     * - conversation: projects/{project}/conversations/{conversation}
     * - message: projects/{project}/conversations/{conversation}/messages/{message}
     * - participant: projects/{project}/conversations/{conversation}/participants/{participant}
     * - projectConversation: projects/{project}/conversations/{conversation}
     * - projectConversationMessage: projects/{project}/conversations/{conversation}/messages/{message}
     * - projectConversationParticipant: projects/{project}/conversations/{conversation}/participants/{participant}
     * - projectLocationConversation: projects/{project}/locations/{location}/conversations/{conversation}
     * - projectLocationConversationMessage: projects/{project}/locations/{location}/conversations/{conversation}/messages/{message}
     * - projectLocationConversationParticipant: projects/{project}/locations/{location}/conversations/{conversation}/participants/{participant}.
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
     * Creates a new participant in a conversation.
     *
     * Sample code:
     * ```
     * $participantsClient = new ParticipantsClient();
     * try {
     *     $parent = '';
     *     $participant = new Participant();
     *     $response = $participantsClient->createParticipant($parent, $participant);
     * } finally {
     *     $participantsClient->close();
     * }
     * ```
     *
     * @param string      $parent       Required. Resource identifier of the conversation adding the participant.
     *                                  Format: `projects/<Project ID>/locations/<Location
     *                                  ID>/conversations/<Conversation ID>`.
     * @param Participant $participant  Required. The participant to create.
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
     * @return \Google\Cloud\Dialogflow\V2\Participant
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function createParticipant($parent, $participant, array $optionalArgs = [])
    {
        $request = new CreateParticipantRequest();
        $request->setParent($parent);
        $request->setParticipant($participant);

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'CreateParticipant',
            Participant::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Retrieves a conversation participant.
     *
     * Sample code:
     * ```
     * $participantsClient = new ParticipantsClient();
     * try {
     *     $name = '';
     *     $response = $participantsClient->getParticipant($name);
     * } finally {
     *     $participantsClient->close();
     * }
     * ```
     *
     * @param string $name         Required. The name of the participant. Format:
     *                             `projects/<Project ID>/locations/<Location ID>/conversations/<Conversation
     *                             ID>/participants/<Participant ID>`.
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
     * @return \Google\Cloud\Dialogflow\V2\Participant
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function getParticipant($name, array $optionalArgs = [])
    {
        $request = new GetParticipantRequest();
        $request->setName($name);

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'GetParticipant',
            Participant::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Returns the list of all participants in the specified conversation.
     *
     * Sample code:
     * ```
     * $participantsClient = new ParticipantsClient();
     * try {
     *     $parent = '';
     *     // Iterate over pages of elements
     *     $pagedResponse = $participantsClient->listParticipants($parent);
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
     *     $pagedResponse = $participantsClient->listParticipants($parent);
     *     foreach ($pagedResponse->iterateAllElements() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $participantsClient->close();
     * }
     * ```
     *
     * @param string $parent       Required. The conversation to list all participants from.
     *                             Format: `projects/<Project ID>/locations/<Location
     *                             ID>/conversations/<Conversation ID>`.
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
    public function listParticipants($parent, array $optionalArgs = [])
    {
        $request = new ListParticipantsRequest();
        $request->setParent($parent);
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
            'ListParticipants',
            $optionalArgs,
            ListParticipantsResponse::class,
            $request
        );
    }

    /**
     * Updates the specified participant.
     *
     * Sample code:
     * ```
     * $participantsClient = new ParticipantsClient();
     * try {
     *     $participant = new Participant();
     *     $updateMask = new FieldMask();
     *     $response = $participantsClient->updateParticipant($participant, $updateMask);
     * } finally {
     *     $participantsClient->close();
     * }
     * ```
     *
     * @param Participant $participant  Required. The participant to update.
     * @param FieldMask   $updateMask   Required. The mask to specify which fields to update.
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
     * @return \Google\Cloud\Dialogflow\V2\Participant
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function updateParticipant($participant, $updateMask, array $optionalArgs = [])
    {
        $request = new UpdateParticipantRequest();
        $request->setParticipant($participant);
        $request->setUpdateMask($updateMask);

        $requestParams = new RequestParamsHeaderDescriptor([
          'participant.name' => $request->getParticipant()->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'UpdateParticipant',
            Participant::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Adds a text (chat, for example), or audio (phone recording, for example)
     * message from a participant into the conversation.
     *
     * Note: Always use agent versions for production traffic
     * sent to virtual agents. See [Versions and
     * environments(https://cloud.google.com/dialogflow/es/docs/agents-versions).
     *
     * Sample code:
     * ```
     * $participantsClient = new ParticipantsClient();
     * try {
     *     $participant = '';
     *     $response = $participantsClient->analyzeContent($participant);
     * } finally {
     *     $participantsClient->close();
     * }
     * ```
     *
     * @param string $participant  Required. The name of the participant this text comes from.
     *                             Format: `projects/<Project ID>/locations/<Location
     *                             ID>/conversations/<Conversation ID>/participants/<Participant ID>`.
     * @param array  $optionalArgs {
     *                             Optional.
     *
     *     @type TextInput $textInput
     *          The natural language text to be processed.
     *     @type AudioInput $audioInput
     *          The natural language speech audio to be processed.
     *     @type EventInput $eventInput
     *          An input event to send to Dialogflow.
     *     @type OutputAudioConfig $replyAudioConfig
     *          Speech synthesis configuration.
     *          The speech synthesis settings for a virtual agent that may be configured
     *          for the associated conversation profile are not used when calling
     *          AnalyzeContent. If this configuration is not supplied, speech synthesis
     *          is disabled.
     *     @type QueryParameters $queryParams
     *          Parameters for a Dialogflow virtual-agent query.
     *     @type string $requestId
     *          A unique identifier for this request. Restricted to 36 ASCII characters.
     *          A random UUID is recommended.
     *          This request is only idempotent if a `request_id` is provided.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\Dialogflow\V2\AnalyzeContentResponse
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function analyzeContent($participant, array $optionalArgs = [])
    {
        $request = new AnalyzeContentRequest();
        $request->setParticipant($participant);
        if (isset($optionalArgs['textInput'])) {
            $request->setTextInput($optionalArgs['textInput']);
        }
        if (isset($optionalArgs['audioInput'])) {
            $request->setAudioInput($optionalArgs['audioInput']);
        }
        if (isset($optionalArgs['eventInput'])) {
            $request->setEventInput($optionalArgs['eventInput']);
        }
        if (isset($optionalArgs['replyAudioConfig'])) {
            $request->setReplyAudioConfig($optionalArgs['replyAudioConfig']);
        }
        if (isset($optionalArgs['queryParams'])) {
            $request->setQueryParams($optionalArgs['queryParams']);
        }
        if (isset($optionalArgs['requestId'])) {
            $request->setRequestId($optionalArgs['requestId']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'participant' => $request->getParticipant(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'AnalyzeContent',
            AnalyzeContentResponse::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Adds a text (chat, for example), or audio (phone recording, for example)
     * message from a participant into the conversation.
     * Note: This method is only available through the gRPC API (not REST).
     *
     * The top-level message sent to the client by the server is
     * `StreamingAnalyzeContentResponse`. Multiple response messages can be
     * returned in order. The first one or more messages contain the
     * `recognition_result` field. Each result represents a more complete
     * transcript of what the user said. The next message contains the
     * `reply_text` field and potentially the `reply_audio` field. The message can
     * also contain the `automated_agent_reply` field.
     *
     * Note: Always use agent versions for production traffic
     * sent to virtual agents. See [Versions and
     * environments(https://cloud.google.com/dialogflow/es/docs/agents-versions).
     *
     * Sample code:
     * ```
     * $participantsClient = new ParticipantsClient();
     * try {
     *     $participant = '';
     *     $request = new StreamingAnalyzeContentRequest();
     *     $request->setParticipant($participant);
     *     // Write all requests to the server, then read all responses until the
     *     // stream is complete
     *     $requests = [$request];
     *     $stream = $participantsClient->streamingAnalyzeContent();
     *     $stream->writeAll($requests);
     *     foreach ($stream->closeWriteAndReadAll() as $element) {
     *         // doSomethingWith($element);
     *     }
     *
     *
     *     // Alternatively:
     *
     *     // Write requests individually, making read() calls if
     *     // required. Call closeWrite() once writes are complete, and read the
     *     // remaining responses from the server.
     *     $requests = [$request];
     *     $stream = $participantsClient->streamingAnalyzeContent();
     *     foreach ($requests as $request) {
     *         $stream->write($request);
     *         // if required, read a single response from the stream
     *         $element = $stream->read();
     *         // doSomethingWith($element)
     *     }
     *     $stream->closeWrite();
     *     $element = $stream->read();
     *     while (!is_null($element)) {
     *         // doSomethingWith($element)
     *         $element = $stream->read();
     *     }
     * } finally {
     *     $participantsClient->close();
     * }
     * ```
     *
     * @param array $optionalArgs {
     *                            Optional.
     *
     *     @type int $timeoutMillis
     *          Timeout to use for this call.
     * }
     *
     * @return \Google\ApiCore\BidiStream
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function streamingAnalyzeContent(array $optionalArgs = [])
    {
        return $this->startCall(
            'StreamingAnalyzeContent',
            StreamingAnalyzeContentResponse::class,
            $optionalArgs,
            null,
            Call::BIDI_STREAMING_CALL
        );
    }

    /**
     * Gets suggested articles for a participant based on specific historical
     * messages.
     *
     * Sample code:
     * ```
     * $participantsClient = new ParticipantsClient();
     * try {
     *     $parent = '';
     *     $response = $participantsClient->suggestArticles($parent);
     * } finally {
     *     $participantsClient->close();
     * }
     * ```
     *
     * @param string $parent       Required. The name of the participant to fetch suggestion for.
     *                             Format: `projects/<Project ID>/locations/<Location
     *                             ID>/conversations/<Conversation ID>/participants/<Participant ID>`.
     * @param array  $optionalArgs {
     *                             Optional.
     *
     *     @type string $latestMessage
     *          The name of the latest conversation message to compile suggestion
     *          for. If empty, it will be the latest message of the conversation.
     *
     *          Format: `projects/<Project ID>/locations/<Location
     *          ID>/conversations/<Conversation ID>/messages/<Message ID>`.
     *     @type int $contextSize
     *          Max number of messages prior to and including
     *          [latest_message][google.cloud.dialogflow.v2.SuggestArticlesRequest.latest_message] to use as context
     *          when compiling the suggestion. By default 20 and at most 50.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\Dialogflow\V2\SuggestArticlesResponse
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function suggestArticles($parent, array $optionalArgs = [])
    {
        $request = new SuggestArticlesRequest();
        $request->setParent($parent);
        if (isset($optionalArgs['latestMessage'])) {
            $request->setLatestMessage($optionalArgs['latestMessage']);
        }
        if (isset($optionalArgs['contextSize'])) {
            $request->setContextSize($optionalArgs['contextSize']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'SuggestArticles',
            SuggestArticlesResponse::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Gets suggested faq answers for a participant based on specific historical
     * messages.
     *
     * Sample code:
     * ```
     * $participantsClient = new ParticipantsClient();
     * try {
     *     $parent = '';
     *     $response = $participantsClient->suggestFaqAnswers($parent);
     * } finally {
     *     $participantsClient->close();
     * }
     * ```
     *
     * @param string $parent       Required. The name of the participant to fetch suggestion for.
     *                             Format: `projects/<Project ID>/locations/<Location
     *                             ID>/conversations/<Conversation ID>/participants/<Participant ID>`.
     * @param array  $optionalArgs {
     *                             Optional.
     *
     *     @type string $latestMessage
     *          The name of the latest conversation message to compile suggestion
     *          for. If empty, it will be the latest message of the conversation.
     *
     *          Format: `projects/<Project ID>/locations/<Location
     *          ID>/conversations/<Conversation ID>/messages/<Message ID>`.
     *     @type int $contextSize
     *          Max number of messages prior to and including
     *          [latest_message] to use as context when compiling the
     *          suggestion. By default 20 and at most 50.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\Dialogflow\V2\SuggestFaqAnswersResponse
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function suggestFaqAnswers($parent, array $optionalArgs = [])
    {
        $request = new SuggestFaqAnswersRequest();
        $request->setParent($parent);
        if (isset($optionalArgs['latestMessage'])) {
            $request->setLatestMessage($optionalArgs['latestMessage']);
        }
        if (isset($optionalArgs['contextSize'])) {
            $request->setContextSize($optionalArgs['contextSize']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'SuggestFaqAnswers',
            SuggestFaqAnswersResponse::class,
            $optionalArgs,
            $request
        )->wait();
    }
}
