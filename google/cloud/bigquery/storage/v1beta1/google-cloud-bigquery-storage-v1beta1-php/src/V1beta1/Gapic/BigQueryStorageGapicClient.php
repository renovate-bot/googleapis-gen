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
 * https://github.com/googleapis/googleapis/blob/master/google/cloud/bigquery/storage/v1beta1/storage.proto
 * Updates to the above are reflected here through a refresh process.
 *
 * @experimental
 */

namespace Google\Cloud\Bigquery\Storage\V1beta1\Gapic;

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
use Google\Cloud\Bigquery\Storage\V1beta1\BatchCreateReadSessionStreamsRequest;
use Google\Cloud\Bigquery\Storage\V1beta1\BatchCreateReadSessionStreamsResponse;
use Google\Cloud\Bigquery\Storage\V1beta1\CreateReadSessionRequest;
use Google\Cloud\Bigquery\Storage\V1beta1\FinalizeStreamRequest;
use Google\Cloud\Bigquery\Storage\V1beta1\ReadRowsRequest;
use Google\Cloud\Bigquery\Storage\V1beta1\ReadRowsResponse;
use Google\Cloud\Bigquery\Storage\V1beta1\ReadSession;
use Google\Cloud\Bigquery\Storage\V1beta1\SplitReadStreamRequest;
use Google\Cloud\Bigquery\Storage\V1beta1\SplitReadStreamResponse;

use Google\Cloud\Bigquery\Storage\V1beta1\Stream;
use Google\Cloud\Bigquery\Storage\V1beta1\StreamPosition;
use Google\Cloud\Bigquery\Storage\V1beta1\TableModifiers;
use Google\Cloud\Bigquery\Storage\V1beta1\TableReadOptions;
use Google\Cloud\Bigquery\Storage\V1beta1\TableReference;
use Google\Protobuf\GPBEmpty;

/**
 * Service Description: BigQuery storage API.
 *
 * The BigQuery storage API can be used to read data stored in BigQuery.
 *
 * This class provides the ability to make remote calls to the backing service through method
 * calls that map to API methods. Sample code to get started:
 *
 * ```
 * $bigQueryStorageClient = new BigQueryStorageClient();
 * try {
 *     $session = new ReadSession();
 *     $requestedStreams = 0;
 *     $response = $bigQueryStorageClient->batchCreateReadSessionStreams($session, $requestedStreams);
 * } finally {
 *     $bigQueryStorageClient->close();
 * }
 * ```
 *
 * Many parameters require resource names to be formatted in a particular way. To
 * assist with these names, this class includes a format method for each type of
 * name, and additionally a parseName method to extract the individual identifiers
 * contained within formatted names that are returned by the API.
 *
 * @experimental
 */
class BigQueryStorageGapicClient
{
    use GapicClientTrait;

    /**
     * The name of the service.
     */
    const SERVICE_NAME = 'google.cloud.bigquery.storage.v1beta1.BigQueryStorage';

    /**
     * The default address of the service.
     */
    const SERVICE_ADDRESS = 'bigquerystorage.googleapis.com';

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
        'https://www.googleapis.com/auth/bigquery',
        'https://www.googleapis.com/auth/bigquery.readonly',
        'https://www.googleapis.com/auth/cloud-platform',
    ];

    private static $projectNameTemplate;

    private static $readSessionNameTemplate;

    private static $streamNameTemplate;

    private static $pathTemplateMap;

    private static function getClientDefaults()
    {
        return [
            'serviceName' => self::SERVICE_NAME,
            'serviceAddress' => self::SERVICE_ADDRESS . ':' . self::DEFAULT_SERVICE_PORT,
            'clientConfig' => __DIR__ . '/../resources/big_query_storage_client_config.json',
            'descriptorsConfigPath' => __DIR__ . '/../resources/big_query_storage_descriptor_config.php',
            'gcpApiConfigPath' => __DIR__ . '/../resources/big_query_storage_grpc_config.json',
            'credentialsConfig' => [
                'defaultScopes' => self::$serviceScopes,
            ],
            'transportConfig' => [
                'rest' => [
                    'restClientConfigPath' => __DIR__ . '/../resources/big_query_storage_rest_client_config.php',
                ],
            ],
        ];
    }

    private static function getProjectNameTemplate()
    {
        if (self::$projectNameTemplate == null) {
            self::$projectNameTemplate = new PathTemplate('projects/{project}');
        }

        return self::$projectNameTemplate;
    }

    private static function getReadSessionNameTemplate()
    {
        if (self::$readSessionNameTemplate == null) {
            self::$readSessionNameTemplate = new PathTemplate('projects/{project}/locations/{location}/sessions/{session}');
        }

        return self::$readSessionNameTemplate;
    }

    private static function getStreamNameTemplate()
    {
        if (self::$streamNameTemplate == null) {
            self::$streamNameTemplate = new PathTemplate('projects/{project}/locations/{location}/streams/{stream}');
        }

        return self::$streamNameTemplate;
    }

    private static function getPathTemplateMap()
    {
        if (self::$pathTemplateMap == null) {
            self::$pathTemplateMap = [
                'project' => self::getProjectNameTemplate(),
                'readSession' => self::getReadSessionNameTemplate(),
                'stream' => self::getStreamNameTemplate(),
            ];
        }

        return self::$pathTemplateMap;
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
     * Formats a string containing the fully-qualified path to represent a read_session
     * resource.
     *
     * @param string $project
     * @param string $location
     * @param string $session
     *
     * @return string The formatted read_session resource.
     *
     * @experimental
     */
    public static function readSessionName($project, $location, $session)
    {
        return self::getReadSessionNameTemplate()->render([
            'project' => $project,
            'location' => $location,
            'session' => $session,
        ]);
    }

    /**
     * Formats a string containing the fully-qualified path to represent a stream
     * resource.
     *
     * @param string $project
     * @param string $location
     * @param string $stream
     *
     * @return string The formatted stream resource.
     *
     * @experimental
     */
    public static function streamName($project, $location, $stream)
    {
        return self::getStreamNameTemplate()->render([
            'project' => $project,
            'location' => $location,
            'stream' => $stream,
        ]);
    }

    /**
     * Parses a formatted name string and returns an associative array of the components in the name.
     * The following name formats are supported:
     * Template: Pattern
     * - project: projects/{project}
     * - readSession: projects/{project}/locations/{location}/sessions/{session}
     * - stream: projects/{project}/locations/{location}/streams/{stream}
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
     *           as "<uri>:<port>". Default 'bigquerystorage.googleapis.com:443'.
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
     *
     * @experimental
     */
    public function __construct(array $options = [])
    {
        $clientOptions = $this->buildClientOptions($options);
        $this->setClientOptions($clientOptions);
    }

    /**
     * Creates additional streams for a ReadSession. This API can be used to
     * dynamically adjust the parallelism of a batch processing task upwards by
     * adding additional workers.
     *
     * Sample code:
     * ```
     * $bigQueryStorageClient = new BigQueryStorageClient();
     * try {
     *     $session = new ReadSession();
     *     $requestedStreams = 0;
     *     $response = $bigQueryStorageClient->batchCreateReadSessionStreams($session, $requestedStreams);
     * } finally {
     *     $bigQueryStorageClient->close();
     * }
     * ```
     *
     * @param ReadSession $session          Required. Must be a non-expired session obtained from a call to
     *                                      CreateReadSession. Only the name field needs to be set.
     * @param int         $requestedStreams Required. Number of new streams requested. Must be positive.
     *                                      Number of added streams may be less than this, see CreateReadSessionRequest
     *                                      for more information.
     * @param array       $optionalArgs     {
     *     Optional.
     *
     *     @type RetrySettings|array $retrySettings
     *           Retry settings to use for this call. Can be a
     *           {@see Google\ApiCore\RetrySettings} object, or an associative array of retry
     *           settings parameters. See the documentation on
     *           {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\Bigquery\Storage\V1beta1\BatchCreateReadSessionStreamsResponse
     *
     * @throws ApiException if the remote call fails
     *
     * @experimental
     */
    public function batchCreateReadSessionStreams($session, $requestedStreams, array $optionalArgs = [])
    {
        $request = new BatchCreateReadSessionStreamsRequest();
        $requestParamHeaders = [];
        $request->setSession($session);
        $request->setRequestedStreams($requestedStreams);
        $requestParamHeaders['session.name'] = $session->getName();
        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('BatchCreateReadSessionStreams', BatchCreateReadSessionStreamsResponse::class, $optionalArgs, $request)->wait();
    }

    /**
     * Creates a new read session. A read session divides the contents of a
     * BigQuery table into one or more streams, which can then be used to read
     * data from the table. The read session also specifies properties of the
     * data to be read, such as a list of columns or a push-down filter describing
     * the rows to be returned.
     *
     * A particular row can be read by at most one stream. When the caller has
     * reached the end of each stream in the session, then all the data in the
     * table has been read.
     *
     * Read sessions automatically expire 24 hours after they are created and do
     * not require manual clean-up by the caller.
     *
     * Sample code:
     * ```
     * $bigQueryStorageClient = new BigQueryStorageClient();
     * try {
     *     $tableReference = new TableReference();
     *     $formattedParent = $bigQueryStorageClient->projectName('[PROJECT]');
     *     $response = $bigQueryStorageClient->createReadSession($tableReference, $formattedParent);
     * } finally {
     *     $bigQueryStorageClient->close();
     * }
     * ```
     *
     * @param TableReference $tableReference Required. Reference to the table to read.
     * @param string         $parent         Required. String of the form `projects/{project_id}` indicating the
     *                                       project this ReadSession is associated with. This is the project that will
     *                                       be billed for usage.
     * @param array          $optionalArgs   {
     *     Optional.
     *
     *     @type TableModifiers $tableModifiers
     *           Any modifiers to the Table (e.g. snapshot timestamp).
     *     @type int $requestedStreams
     *           Initial number of streams. If unset or 0, we will
     *           provide a value of streams so as to produce reasonable throughput. Must be
     *           non-negative. The number of streams may be lower than the requested number,
     *           depending on the amount parallelism that is reasonable for the table and
     *           the maximum amount of parallelism allowed by the system.
     *
     *           Streams must be read starting from offset 0.
     *     @type TableReadOptions $readOptions
     *           Read options for this session (e.g. column selection, filters).
     *     @type int $format
     *           Data output format. Currently default to Avro.
     *           For allowed values, use constants defined on {@see \Google\Cloud\Bigquery\Storage\V1beta1\DataFormat}
     *     @type int $shardingStrategy
     *           The strategy to use for distributing data among multiple streams. Currently
     *           defaults to liquid sharding.
     *           For allowed values, use constants defined on {@see \Google\Cloud\Bigquery\Storage\V1beta1\ShardingStrategy}
     *     @type RetrySettings|array $retrySettings
     *           Retry settings to use for this call. Can be a
     *           {@see Google\ApiCore\RetrySettings} object, or an associative array of retry
     *           settings parameters. See the documentation on
     *           {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\Bigquery\Storage\V1beta1\ReadSession
     *
     * @throws ApiException if the remote call fails
     *
     * @experimental
     */
    public function createReadSession($tableReference, $parent, array $optionalArgs = [])
    {
        $request = new CreateReadSessionRequest();
        $requestParamHeaders = [];
        $request->setTableReference($tableReference);
        $request->setParent($parent);
        $requestParamHeaders['table_reference.dataset_id'] = $tableReference->getDatasetId();
        $requestParamHeaders['table_reference.project_id'] = $tableReference->getProjectId();
        if (isset($optionalArgs['tableModifiers'])) {
            $request->setTableModifiers($optionalArgs['tableModifiers']);
        }

        if (isset($optionalArgs['requestedStreams'])) {
            $request->setRequestedStreams($optionalArgs['requestedStreams']);
        }

        if (isset($optionalArgs['readOptions'])) {
            $request->setReadOptions($optionalArgs['readOptions']);
        }

        if (isset($optionalArgs['format'])) {
            $request->setFormat($optionalArgs['format']);
        }

        if (isset($optionalArgs['shardingStrategy'])) {
            $request->setShardingStrategy($optionalArgs['shardingStrategy']);
        }

        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('CreateReadSession', ReadSession::class, $optionalArgs, $request)->wait();
    }

    /**
     * Triggers the graceful termination of a single stream in a ReadSession. This
     * API can be used to dynamically adjust the parallelism of a batch processing
     * task downwards without losing data.
     *
     * This API does not delete the stream -- it remains visible in the
     * ReadSession, and any data processed by the stream is not released to other
     * streams. However, no additional data will be assigned to the stream once
     * this call completes. Callers must continue reading data on the stream until
     * the end of the stream is reached so that data which has already been
     * assigned to the stream will be processed.
     *
     * This method will return an error if there are no other live streams
     * in the Session, or if SplitReadStream() has been called on the given
     * Stream.
     *
     * Sample code:
     * ```
     * $bigQueryStorageClient = new BigQueryStorageClient();
     * try {
     *     $stream = new Stream();
     *     $bigQueryStorageClient->finalizeStream($stream);
     * } finally {
     *     $bigQueryStorageClient->close();
     * }
     * ```
     *
     * @param Stream $stream       Required. Stream to finalize.
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
    public function finalizeStream($stream, array $optionalArgs = [])
    {
        $request = new FinalizeStreamRequest();
        $requestParamHeaders = [];
        $request->setStream($stream);
        $requestParamHeaders['stream.name'] = $stream->getName();
        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('FinalizeStream', GPBEmpty::class, $optionalArgs, $request)->wait();
    }

    /**
     * Reads rows from the table in the format prescribed by the read session.
     * Each response contains one or more table rows, up to a maximum of 10 MiB
     * per response; read requests which attempt to read individual rows larger
     * than this will fail.
     *
     * Each request also returns a set of stream statistics reflecting the
     * estimated total number of rows in the read stream. This number is computed
     * based on the total table size and the number of active streams in the read
     * session, and may change as other streams continue to read data.
     *
     * Sample code:
     * ```
     * $bigQueryStorageClient = new BigQueryStorageClient();
     * try {
     *     $readPosition = new StreamPosition();
     *     // Read all responses until the stream is complete
     *     $stream = $bigQueryStorageClient->readRows($readPosition);
     *     foreach ($stream->readAll() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $bigQueryStorageClient->close();
     * }
     * ```
     *
     * @param StreamPosition $readPosition Required. Identifier of the position in the stream to start reading from.
     *                                     The offset requested must be less than the last row read from ReadRows.
     *                                     Requesting a larger offset is undefined.
     * @param array          $optionalArgs {
     *     Optional.
     *
     *     @type int $timeoutMillis
     *           Timeout to use for this call.
     * }
     *
     * @return \Google\ApiCore\ServerStream
     *
     * @throws ApiException if the remote call fails
     *
     * @experimental
     */
    public function readRows($readPosition, array $optionalArgs = [])
    {
        $request = new ReadRowsRequest();
        $requestParamHeaders = [];
        $request->setReadPosition($readPosition);
        $requestParamHeaders['read_position.stream.name'] = $readPosition->getStream()->getName();
        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('ReadRows', ReadRowsResponse::class, $optionalArgs, $request, Call::SERVER_STREAMING_CALL);
    }

    /**
     * Splits a given read stream into two Streams. These streams are referred to
     * as the primary and the residual of the split. The original stream can still
     * be read from in the same manner as before. Both of the returned streams can
     * also be read from, and the total rows return by both child streams will be
     * the same as the rows read from the original stream.
     *
     * Moreover, the two child streams will be allocated back to back in the
     * original Stream. Concretely, it is guaranteed that for streams Original,
     * Primary, and Residual, that Original[0-j] = Primary[0-j] and
     * Original[j-n] = Residual[0-m] once the streams have been read to
     * completion.
     *
     * This method is guaranteed to be idempotent.
     *
     * Sample code:
     * ```
     * $bigQueryStorageClient = new BigQueryStorageClient();
     * try {
     *     $originalStream = new Stream();
     *     $response = $bigQueryStorageClient->splitReadStream($originalStream);
     * } finally {
     *     $bigQueryStorageClient->close();
     * }
     * ```
     *
     * @param Stream $originalStream Required. Stream to split.
     * @param array  $optionalArgs   {
     *     Optional.
     *
     *     @type float $fraction
     *           A value in the range (0.0, 1.0) that specifies the fractional point at
     *           which the original stream should be split. The actual split point is
     *           evaluated on pre-filtered rows, so if a filter is provided, then there is
     *           no guarantee that the division of the rows between the new child streams
     *           will be proportional to this fractional value. Additionally, because the
     *           server-side unit for assigning data is collections of rows, this fraction
     *           will always map to to a data storage boundary on the server side.
     *     @type RetrySettings|array $retrySettings
     *           Retry settings to use for this call. Can be a
     *           {@see Google\ApiCore\RetrySettings} object, or an associative array of retry
     *           settings parameters. See the documentation on
     *           {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\Bigquery\Storage\V1beta1\SplitReadStreamResponse
     *
     * @throws ApiException if the remote call fails
     *
     * @experimental
     */
    public function splitReadStream($originalStream, array $optionalArgs = [])
    {
        $request = new SplitReadStreamRequest();
        $requestParamHeaders = [];
        $request->setOriginalStream($originalStream);
        $requestParamHeaders['original_stream.name'] = $originalStream->getName();
        if (isset($optionalArgs['fraction'])) {
            $request->setFraction($optionalArgs['fraction']);
        }

        $requestParams = new RequestParamsHeaderDescriptor($requestParamHeaders);
        $optionalArgs['headers'] = isset($optionalArgs['headers']) ? array_merge($requestParams->getHeader(), $optionalArgs['headers']) : $requestParams->getHeader();
        return $this->startCall('SplitReadStream', SplitReadStreamResponse::class, $optionalArgs, $request)->wait();
    }
}
