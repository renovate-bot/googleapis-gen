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
 * https://github.com/google/googleapis/blob/master/google/cloud/bigquery/storage/v1beta2/storage.proto
 * and updates to that file get reflected here through a refresh process.
 *
 * @experimental
 */

namespace Google\Cloud\Bigquery\Storage\V1beta2\Gapic;

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
use Google\Cloud\Bigquery\Storage\V1beta2\AppendRowsRequest;
use Google\Cloud\Bigquery\Storage\V1beta2\AppendRowsResponse;
use Google\Cloud\Bigquery\Storage\V1beta2\BatchCommitWriteStreamsRequest;
use Google\Cloud\Bigquery\Storage\V1beta2\BatchCommitWriteStreamsResponse;
use Google\Cloud\Bigquery\Storage\V1beta2\CreateWriteStreamRequest;
use Google\Cloud\Bigquery\Storage\V1beta2\FinalizeWriteStreamRequest;
use Google\Cloud\Bigquery\Storage\V1beta2\FinalizeWriteStreamResponse;
use Google\Cloud\Bigquery\Storage\V1beta2\FlushRowsRequest;
use Google\Cloud\Bigquery\Storage\V1beta2\FlushRowsResponse;
use Google\Cloud\Bigquery\Storage\V1beta2\GetWriteStreamRequest;
use Google\Cloud\Bigquery\Storage\V1beta2\WriteStream;
use Google\Protobuf\Int64Value;

/**
 * Service Description: BigQuery Write API.
 *
 * The Write API can be used to write data to BigQuery.
 *
 * This class provides the ability to make remote calls to the backing service through method
 * calls that map to API methods. Sample code to get started:
 *
 * ```
 * $bigQueryWriteClient = new BigQueryWriteClient();
 * try {
 *     $formattedParent = $bigQueryWriteClient->tableName('[PROJECT]', '[DATASET]', '[TABLE]');
 *     $writeStream = new WriteStream();
 *     $response = $bigQueryWriteClient->createWriteStream($formattedParent, $writeStream);
 * } finally {
 *     $bigQueryWriteClient->close();
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
class BigQueryWriteGapicClient
{
    use GapicClientTrait;

    /**
     * The name of the service.
     */
    const SERVICE_NAME = 'google.cloud.bigquery.storage.v1beta2.BigQueryWrite';

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
        'https://www.googleapis.com/auth/bigquery.insertdata',
        'https://www.googleapis.com/auth/bigquery.readonly',
        'https://www.googleapis.com/auth/cloud-platform',
    ];
    private static $tableNameTemplate;
    private static $writeStreamNameTemplate;
    private static $pathTemplateMap;

    private static function getClientDefaults()
    {
        return [
            'serviceName' => self::SERVICE_NAME,
            'serviceAddress' => self::SERVICE_ADDRESS.':'.self::DEFAULT_SERVICE_PORT,
            'clientConfig' => __DIR__.'/../resources/big_query_write_client_config.json',
            'descriptorsConfigPath' => __DIR__.'/../resources/big_query_write_descriptor_config.php',
            'gcpApiConfigPath' => __DIR__.'/../resources/big_query_write_grpc_config.json',
            'credentialsConfig' => [
                'defaultScopes' => self::$serviceScopes,
            ],
            'transportConfig' => [
                'rest' => [
                    'restClientConfigPath' => __DIR__.'/../resources/big_query_write_rest_client_config.php',
                ],
            ],
        ];
    }

    private static function getTableNameTemplate()
    {
        if (null == self::$tableNameTemplate) {
            self::$tableNameTemplate = new PathTemplate('projects/{project}/datasets/{dataset}/tables/{table}');
        }

        return self::$tableNameTemplate;
    }

    private static function getWriteStreamNameTemplate()
    {
        if (null == self::$writeStreamNameTemplate) {
            self::$writeStreamNameTemplate = new PathTemplate('projects/{project}/datasets/{dataset}/tables/{table}/streams/{stream}');
        }

        return self::$writeStreamNameTemplate;
    }

    private static function getPathTemplateMap()
    {
        if (null == self::$pathTemplateMap) {
            self::$pathTemplateMap = [
                'table' => self::getTableNameTemplate(),
                'writeStream' => self::getWriteStreamNameTemplate(),
            ];
        }

        return self::$pathTemplateMap;
    }

    /**
     * Formats a string containing the fully-qualified path to represent
     * a table resource.
     *
     * @param string $project
     * @param string $dataset
     * @param string $table
     *
     * @return string The formatted table resource.
     * @experimental
     */
    public static function tableName($project, $dataset, $table)
    {
        return self::getTableNameTemplate()->render([
            'project' => $project,
            'dataset' => $dataset,
            'table' => $table,
        ]);
    }

    /**
     * Formats a string containing the fully-qualified path to represent
     * a write_stream resource.
     *
     * @param string $project
     * @param string $dataset
     * @param string $table
     * @param string $stream
     *
     * @return string The formatted write_stream resource.
     * @experimental
     */
    public static function writeStreamName($project, $dataset, $table, $stream)
    {
        return self::getWriteStreamNameTemplate()->render([
            'project' => $project,
            'dataset' => $dataset,
            'table' => $table,
            'stream' => $stream,
        ]);
    }

    /**
     * Parses a formatted name string and returns an associative array of the components in the name.
     * The following name formats are supported:
     * Template: Pattern
     * - table: projects/{project}/datasets/{dataset}/tables/{table}
     * - writeStream: projects/{project}/datasets/{dataset}/tables/{table}/streams/{stream}.
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
     * Creates a write stream to the given table.
     * Additionally, every table has a special COMMITTED stream named '_default'
     * to which data can be written. This stream doesn't need to be created using
     * CreateWriteStream. It is a stream that can be used simultaneously by any
     * number of clients. Data written to this stream is considered committed as
     * soon as an acknowledgement is received.
     *
     * Sample code:
     * ```
     * $bigQueryWriteClient = new BigQueryWriteClient();
     * try {
     *     $formattedParent = $bigQueryWriteClient->tableName('[PROJECT]', '[DATASET]', '[TABLE]');
     *     $writeStream = new WriteStream();
     *     $response = $bigQueryWriteClient->createWriteStream($formattedParent, $writeStream);
     * } finally {
     *     $bigQueryWriteClient->close();
     * }
     * ```
     *
     * @param string      $parent       Required. Reference to the table to which the stream belongs, in the format
     *                                  of `projects/{project}/datasets/{dataset}/tables/{table}`.
     * @param WriteStream $writeStream  Required. Stream to be created.
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
     * @return \Google\Cloud\Bigquery\Storage\V1beta2\WriteStream
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function createWriteStream($parent, $writeStream, array $optionalArgs = [])
    {
        $request = new CreateWriteStreamRequest();
        $request->setParent($parent);
        $request->setWriteStream($writeStream);

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'CreateWriteStream',
            WriteStream::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Appends data to the given stream.
     *
     * If `offset` is specified, the `offset` is checked against the end of
     * stream. The server returns `OUT_OF_RANGE` in `AppendRowsResponse` if an
     * attempt is made to append to an offset beyond the current end of the stream
     * or `ALREADY_EXISTS` if user provids an `offset` that has already been
     * written to. User can retry with adjusted offset within the same RPC
     * stream. If `offset` is not specified, append happens at the end of the
     * stream.
     *
     * The response contains the offset at which the append happened. Responses
     * are received in the same order in which requests are sent. There will be
     * one response for each successful request. If the `offset` is not set in
     * response, it means append didn't happen due to some errors. If one request
     * fails, all the subsequent requests will also fail until a success request
     * is made again.
     *
     * If the stream is of `PENDING` type, data will only be available for read
     * operations after the stream is committed.
     *
     * Sample code:
     * ```
     * $bigQueryWriteClient = new BigQueryWriteClient();
     * try {
     *     $formattedWriteStream = $bigQueryWriteClient->writeStreamName('[PROJECT]', '[DATASET]', '[TABLE]', '[STREAM]');
     *     $request = new AppendRowsRequest();
     *     $request->setWriteStream($formattedWriteStream);
     *     // Write all requests to the server, then read all responses until the
     *     // stream is complete
     *     $requests = [$request];
     *     $stream = $bigQueryWriteClient->appendRows();
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
     *     $stream = $bigQueryWriteClient->appendRows();
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
     *     $bigQueryWriteClient->close();
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
    public function appendRows(array $optionalArgs = [])
    {
        return $this->startCall(
            'AppendRows',
            AppendRowsResponse::class,
            $optionalArgs,
            null,
            Call::BIDI_STREAMING_CALL
        );
    }

    /**
     * Gets a write stream.
     *
     * Sample code:
     * ```
     * $bigQueryWriteClient = new BigQueryWriteClient();
     * try {
     *     $formattedName = $bigQueryWriteClient->writeStreamName('[PROJECT]', '[DATASET]', '[TABLE]', '[STREAM]');
     *     $response = $bigQueryWriteClient->getWriteStream($formattedName);
     * } finally {
     *     $bigQueryWriteClient->close();
     * }
     * ```
     *
     * @param string $name         Required. Name of the stream to get, in the form of
     *                             `projects/{project}/datasets/{dataset}/tables/{table}/streams/{stream}`.
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
     * @return \Google\Cloud\Bigquery\Storage\V1beta2\WriteStream
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function getWriteStream($name, array $optionalArgs = [])
    {
        $request = new GetWriteStreamRequest();
        $request->setName($name);

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'GetWriteStream',
            WriteStream::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Finalize a write stream so that no new data can be appended to the
     * stream. Finalize is not supported on the '_default' stream.
     *
     * Sample code:
     * ```
     * $bigQueryWriteClient = new BigQueryWriteClient();
     * try {
     *     $formattedName = $bigQueryWriteClient->writeStreamName('[PROJECT]', '[DATASET]', '[TABLE]', '[STREAM]');
     *     $response = $bigQueryWriteClient->finalizeWriteStream($formattedName);
     * } finally {
     *     $bigQueryWriteClient->close();
     * }
     * ```
     *
     * @param string $name         Required. Name of the stream to finalize, in the form of
     *                             `projects/{project}/datasets/{dataset}/tables/{table}/streams/{stream}`.
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
     * @return \Google\Cloud\Bigquery\Storage\V1beta2\FinalizeWriteStreamResponse
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function finalizeWriteStream($name, array $optionalArgs = [])
    {
        $request = new FinalizeWriteStreamRequest();
        $request->setName($name);

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'FinalizeWriteStream',
            FinalizeWriteStreamResponse::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Atomically commits a group of `PENDING` streams that belong to the same
     * `parent` table.
     * Streams must be finalized before commit and cannot be committed multiple
     * times. Once a stream is committed, data in the stream becomes available
     * for read operations.
     *
     * Sample code:
     * ```
     * $bigQueryWriteClient = new BigQueryWriteClient();
     * try {
     *     $parent = '';
     *     $writeStreams = [];
     *     $response = $bigQueryWriteClient->batchCommitWriteStreams($parent, $writeStreams);
     * } finally {
     *     $bigQueryWriteClient->close();
     * }
     * ```
     *
     * @param string   $parent       Required. Parent table that all the streams should belong to, in the form
     *                               of `projects/{project}/datasets/{dataset}/tables/{table}`.
     * @param string[] $writeStreams Required. The group of streams that will be committed atomically.
     * @param array    $optionalArgs {
     *                               Optional.
     *
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\Bigquery\Storage\V1beta2\BatchCommitWriteStreamsResponse
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function batchCommitWriteStreams($parent, $writeStreams, array $optionalArgs = [])
    {
        $request = new BatchCommitWriteStreamsRequest();
        $request->setParent($parent);
        $request->setWriteStreams($writeStreams);

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'BatchCommitWriteStreams',
            BatchCommitWriteStreamsResponse::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Flushes rows to a BUFFERED stream.
     * If users are appending rows to BUFFERED stream, flush operation is
     * required in order for the rows to become available for reading. A
     * Flush operation flushes up to any previously flushed offset in a BUFFERED
     * stream, to the offset specified in the request.
     * Flush is not supported on the _default stream, since it is not BUFFERED.
     *
     * Sample code:
     * ```
     * $bigQueryWriteClient = new BigQueryWriteClient();
     * try {
     *     $formattedWriteStream = $bigQueryWriteClient->writeStreamName('[PROJECT]', '[DATASET]', '[TABLE]', '[STREAM]');
     *     $response = $bigQueryWriteClient->flushRows($formattedWriteStream);
     * } finally {
     *     $bigQueryWriteClient->close();
     * }
     * ```
     *
     * @param string $writeStream  Required. The stream that is the target of the flush operation.
     * @param array  $optionalArgs {
     *                             Optional.
     *
     *     @type Int64Value $offset
     *          Ending offset of the flush operation. Rows before this offset(including
     *          this offset) will be flushed.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\Bigquery\Storage\V1beta2\FlushRowsResponse
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function flushRows($writeStream, array $optionalArgs = [])
    {
        $request = new FlushRowsRequest();
        $request->setWriteStream($writeStream);
        if (isset($optionalArgs['offset'])) {
            $request->setOffset($optionalArgs['offset']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'write_stream' => $request->getWriteStream(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'FlushRows',
            FlushRowsResponse::class,
            $optionalArgs,
            $request
        )->wait();
    }
}
