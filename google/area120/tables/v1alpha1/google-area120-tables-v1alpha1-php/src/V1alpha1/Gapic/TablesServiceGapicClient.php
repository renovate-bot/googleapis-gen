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
 * https://github.com/google/googleapis/blob/master/google/area120/tables/v1alpha1/tables.proto
 * and updates to that file get reflected here through a refresh process.
 *
 * @experimental
 */

namespace Google\Cloud\Area120\Tables\V1alpha1\Gapic;

use Google\ApiCore\ApiException;
use Google\ApiCore\CredentialsWrapper;
use Google\ApiCore\GapicClientTrait;
use Google\ApiCore\PathTemplate;
use Google\ApiCore\RequestParamsHeaderDescriptor;
use Google\ApiCore\RetrySettings;
use Google\ApiCore\Transport\TransportInterface;
use Google\ApiCore\ValidationException;
use Google\Area120\Tables\V1alpha1\BatchCreateRowsRequest;
use Google\Area120\Tables\V1alpha1\BatchCreateRowsResponse;
use Google\Area120\Tables\V1alpha1\BatchUpdateRowsRequest;
use Google\Area120\Tables\V1alpha1\BatchUpdateRowsResponse;
use Google\Area120\Tables\V1alpha1\CreateRowRequest;
use Google\Area120\Tables\V1alpha1\DeleteRowRequest;
use Google\Area120\Tables\V1alpha1\GetRowRequest;
use Google\Area120\Tables\V1alpha1\GetTableRequest;
use Google\Area120\Tables\V1alpha1\ListRowsRequest;
use Google\Area120\Tables\V1alpha1\ListRowsResponse;
use Google\Area120\Tables\V1alpha1\ListTablesRequest;
use Google\Area120\Tables\V1alpha1\ListTablesResponse;
use Google\Area120\Tables\V1alpha1\Row;
use Google\Area120\Tables\V1alpha1\Table;
use Google\Area120\Tables\V1alpha1\UpdateRowRequest;
use Google\Area120\Tables\V1alpha1\View;
use Google\Auth\FetchAuthTokenInterface;
use Google\Protobuf\FieldMask;
use Google\Protobuf\GPBEmpty;

/**
 * Service Description: The Tables Service provides an API for reading and updating tables.
 * It defines the following resource model:.
 *
 * - The API has a collection of [Table][google.area120.tables.v1alpha1.Table]
 *   resources, named `tables/*`
 *
 * - Each Table has a collection of [Row][google.area120.tables.v1alpha1.Row]
 *   resources, named `tables/&#42;/rows/*`
 *
 * This class provides the ability to make remote calls to the backing service through method
 * calls that map to API methods. Sample code to get started:
 *
 * ```
 * $tablesServiceClient = new TablesServiceClient();
 * try {
 *     $name = '';
 *     $response = $tablesServiceClient->getTable($name);
 * } finally {
 *     $tablesServiceClient->close();
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
class TablesServiceGapicClient
{
    use GapicClientTrait;

    /**
     * The name of the service.
     */
    const SERVICE_NAME = 'google.area120.tables.v1alpha1.TablesService';

    /**
     * The default address of the service.
     */
    const SERVICE_ADDRESS = 'area120tables.googleapis.com';

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
        'https://www.googleapis.com/auth/drive',
        'https://www.googleapis.com/auth/drive.file',
        'https://www.googleapis.com/auth/drive.readonly',
        'https://www.googleapis.com/auth/spreadsheets',
        'https://www.googleapis.com/auth/spreadsheets.readonly',
    ];
    private static $rowNameTemplate;
    private static $pathTemplateMap;

    private static function getClientDefaults()
    {
        return [
            'serviceName' => self::SERVICE_NAME,
            'serviceAddress' => self::SERVICE_ADDRESS.':'.self::DEFAULT_SERVICE_PORT,
            'clientConfig' => __DIR__.'/../resources/tables_service_client_config.json',
            'descriptorsConfigPath' => __DIR__.'/../resources/tables_service_descriptor_config.php',
            'gcpApiConfigPath' => __DIR__.'/../resources/tables_service_grpc_config.json',
            'credentialsConfig' => [
                'defaultScopes' => self::$serviceScopes,
            ],
            'transportConfig' => [
                'rest' => [
                    'restClientConfigPath' => __DIR__.'/../resources/tables_service_rest_client_config.php',
                ],
            ],
        ];
    }

    private static function getRowNameTemplate()
    {
        if (null == self::$rowNameTemplate) {
            self::$rowNameTemplate = new PathTemplate('tables/{table}/rows/{row}');
        }

        return self::$rowNameTemplate;
    }

    private static function getPathTemplateMap()
    {
        if (null == self::$pathTemplateMap) {
            self::$pathTemplateMap = [
                'row' => self::getRowNameTemplate(),
            ];
        }

        return self::$pathTemplateMap;
    }

    /**
     * Formats a string containing the fully-qualified path to represent
     * a row resource.
     *
     * @param string $table
     * @param string $row
     *
     * @return string The formatted row resource.
     * @experimental
     */
    public static function rowName($table, $row)
    {
        return self::getRowNameTemplate()->render([
            'table' => $table,
            'row' => $row,
        ]);
    }

    /**
     * Parses a formatted name string and returns an associative array of the components in the name.
     * The following name formats are supported:
     * Template: Pattern
     * - row: tables/{table}/rows/{row}.
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
     *           as "<uri>:<port>". Default 'area120tables.googleapis.com:443'.
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
     * Gets a table. Returns NOT_FOUND if the table does not exist.
     *
     * Sample code:
     * ```
     * $tablesServiceClient = new TablesServiceClient();
     * try {
     *     $name = '';
     *     $response = $tablesServiceClient->getTable($name);
     * } finally {
     *     $tablesServiceClient->close();
     * }
     * ```
     *
     * @param string $name         Required. The name of the table to retrieve.
     *                             Format: tables/{table}
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
     * @return \Google\Area120\Tables\V1alpha1\Table
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function getTable($name, array $optionalArgs = [])
    {
        $request = new GetTableRequest();
        $request->setName($name);

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'GetTable',
            Table::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Lists tables for the user.
     *
     * Sample code:
     * ```
     * $tablesServiceClient = new TablesServiceClient();
     * try {
     *     // Iterate over pages of elements
     *     $pagedResponse = $tablesServiceClient->listTables();
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
     *     $pagedResponse = $tablesServiceClient->listTables();
     *     foreach ($pagedResponse->iterateAllElements() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $tablesServiceClient->close();
     * }
     * ```
     *
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
    public function listTables(array $optionalArgs = [])
    {
        $request = new ListTablesRequest();
        if (isset($optionalArgs['pageSize'])) {
            $request->setPageSize($optionalArgs['pageSize']);
        }
        if (isset($optionalArgs['pageToken'])) {
            $request->setPageToken($optionalArgs['pageToken']);
        }

        return $this->getPagedListResponse(
            'ListTables',
            $optionalArgs,
            ListTablesResponse::class,
            $request
        );
    }

    /**
     * Gets a row. Returns NOT_FOUND if the row does not exist in the table.
     *
     * Sample code:
     * ```
     * $tablesServiceClient = new TablesServiceClient();
     * try {
     *     $name = '';
     *     $response = $tablesServiceClient->getRow($name);
     * } finally {
     *     $tablesServiceClient->close();
     * }
     * ```
     *
     * @param string $name         Required. The name of the row to retrieve.
     *                             Format: tables/{table}/rows/{row}
     * @param array  $optionalArgs {
     *                             Optional.
     *
     *     @type int $view
     *          Optional. Column key to use for values in the row.
     *          Defaults to user entered name.
     *          For allowed values, use constants defined on {@see \Google\Area120\Tables\V1alpha1\View}
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Area120\Tables\V1alpha1\Row
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function getRow($name, array $optionalArgs = [])
    {
        $request = new GetRowRequest();
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
            'GetRow',
            Row::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Lists rows in a table. Returns NOT_FOUND if the table does not exist.
     *
     * Sample code:
     * ```
     * $tablesServiceClient = new TablesServiceClient();
     * try {
     *     $parent = '';
     *     // Iterate over pages of elements
     *     $pagedResponse = $tablesServiceClient->listRows($parent);
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
     *     $pagedResponse = $tablesServiceClient->listRows($parent);
     *     foreach ($pagedResponse->iterateAllElements() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $tablesServiceClient->close();
     * }
     * ```
     *
     * @param string $parent       Required. The parent table.
     *                             Format: tables/{table}
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
     *     @type int $view
     *          Optional. Column key to use for values in the row.
     *          Defaults to user entered name.
     *          For allowed values, use constants defined on {@see \Google\Area120\Tables\V1alpha1\View}
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
    public function listRows($parent, array $optionalArgs = [])
    {
        $request = new ListRowsRequest();
        $request->setParent($parent);
        if (isset($optionalArgs['pageSize'])) {
            $request->setPageSize($optionalArgs['pageSize']);
        }
        if (isset($optionalArgs['pageToken'])) {
            $request->setPageToken($optionalArgs['pageToken']);
        }
        if (isset($optionalArgs['view'])) {
            $request->setView($optionalArgs['view']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->getPagedListResponse(
            'ListRows',
            $optionalArgs,
            ListRowsResponse::class,
            $request
        );
    }

    /**
     * Creates a row.
     *
     * Sample code:
     * ```
     * $tablesServiceClient = new TablesServiceClient();
     * try {
     *     $parent = '';
     *     $row = new Row();
     *     $response = $tablesServiceClient->createRow($parent, $row);
     * } finally {
     *     $tablesServiceClient->close();
     * }
     * ```
     *
     * @param string $parent       Required. The parent table where this row will be created.
     *                             Format: tables/{table}
     * @param Row    $row          Required. The row to create.
     * @param array  $optionalArgs {
     *                             Optional.
     *
     *     @type int $view
     *          Optional. Column key to use for values in the row.
     *          Defaults to user entered name.
     *          For allowed values, use constants defined on {@see \Google\Area120\Tables\V1alpha1\View}
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Area120\Tables\V1alpha1\Row
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function createRow($parent, $row, array $optionalArgs = [])
    {
        $request = new CreateRowRequest();
        $request->setParent($parent);
        $request->setRow($row);
        if (isset($optionalArgs['view'])) {
            $request->setView($optionalArgs['view']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'CreateRow',
            Row::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Creates multiple rows.
     *
     * Sample code:
     * ```
     * $tablesServiceClient = new TablesServiceClient();
     * try {
     *     $parent = '';
     *     $requests = [];
     *     $response = $tablesServiceClient->batchCreateRows($parent, $requests);
     * } finally {
     *     $tablesServiceClient->close();
     * }
     * ```
     *
     * @param string             $parent   Required. The parent table where the rows will be created.
     *                                     Format: tables/{table}
     * @param CreateRowRequest[] $requests Required. The request message specifying the rows to create.
     *
     * A maximum of 500 rows can be created in a single batch.
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
     * @return \Google\Area120\Tables\V1alpha1\BatchCreateRowsResponse
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function batchCreateRows($parent, $requests, array $optionalArgs = [])
    {
        $request = new BatchCreateRowsRequest();
        $request->setParent($parent);
        $request->setRequests($requests);

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'BatchCreateRows',
            BatchCreateRowsResponse::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Updates a row.
     *
     * Sample code:
     * ```
     * $tablesServiceClient = new TablesServiceClient();
     * try {
     *     $row = new Row();
     *     $response = $tablesServiceClient->updateRow($row);
     * } finally {
     *     $tablesServiceClient->close();
     * }
     * ```
     *
     * @param Row   $row          Required. The row to update.
     * @param array $optionalArgs {
     *                            Optional.
     *
     *     @type FieldMask $updateMask
     *          The list of fields to update.
     *     @type int $view
     *          Optional. Column key to use for values in the row.
     *          Defaults to user entered name.
     *          For allowed values, use constants defined on {@see \Google\Area120\Tables\V1alpha1\View}
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Area120\Tables\V1alpha1\Row
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function updateRow($row, array $optionalArgs = [])
    {
        $request = new UpdateRowRequest();
        $request->setRow($row);
        if (isset($optionalArgs['updateMask'])) {
            $request->setUpdateMask($optionalArgs['updateMask']);
        }
        if (isset($optionalArgs['view'])) {
            $request->setView($optionalArgs['view']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'row.name' => $request->getRow()->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'UpdateRow',
            Row::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Updates multiple rows.
     *
     * Sample code:
     * ```
     * $tablesServiceClient = new TablesServiceClient();
     * try {
     *     $parent = '';
     *     $requests = [];
     *     $response = $tablesServiceClient->batchUpdateRows($parent, $requests);
     * } finally {
     *     $tablesServiceClient->close();
     * }
     * ```
     *
     * @param string             $parent   Required. The parent table shared by all rows being updated.
     *                                     Format: tables/{table}
     * @param UpdateRowRequest[] $requests Required. The request messages specifying the rows to update.
     *
     * A maximum of 500 rows can be modified in a single batch.
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
     * @return \Google\Area120\Tables\V1alpha1\BatchUpdateRowsResponse
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function batchUpdateRows($parent, $requests, array $optionalArgs = [])
    {
        $request = new BatchUpdateRowsRequest();
        $request->setParent($parent);
        $request->setRequests($requests);

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'BatchUpdateRows',
            BatchUpdateRowsResponse::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Deletes a row.
     *
     * Sample code:
     * ```
     * $tablesServiceClient = new TablesServiceClient();
     * try {
     *     $formattedName = $tablesServiceClient->rowName('[TABLE]', '[ROW]');
     *     $tablesServiceClient->deleteRow($formattedName);
     * } finally {
     *     $tablesServiceClient->close();
     * }
     * ```
     *
     * @param string $name         Required. The name of the row to delete.
     *                             Format: tables/{table}/rows/{row}
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
    public function deleteRow($name, array $optionalArgs = [])
    {
        $request = new DeleteRowRequest();
        $request->setName($name);

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'DeleteRow',
            GPBEmpty::class,
            $optionalArgs,
            $request
        )->wait();
    }
}
