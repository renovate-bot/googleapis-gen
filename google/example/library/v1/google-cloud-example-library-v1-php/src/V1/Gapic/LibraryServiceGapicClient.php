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
 * https://github.com/google/googleapis/blob/master/google/example/library/v1/library.proto
 * and updates to that file get reflected here through a refresh process.
 *
 * @experimental
 */

namespace Google\Cloud\Example\Library\V1\Gapic;

use Google\ApiCore\ApiException;
use Google\ApiCore\CredentialsWrapper;
use Google\ApiCore\GapicClientTrait;
use Google\ApiCore\PathTemplate;
use Google\ApiCore\RequestParamsHeaderDescriptor;
use Google\ApiCore\RetrySettings;
use Google\ApiCore\Transport\TransportInterface;
use Google\ApiCore\ValidationException;
use Google\Auth\FetchAuthTokenInterface;
use Google\Example\Library\V1\Book;
use Google\Example\Library\V1\CreateBookRequest;
use Google\Example\Library\V1\CreateShelfRequest;
use Google\Example\Library\V1\DeleteBookRequest;
use Google\Example\Library\V1\DeleteShelfRequest;
use Google\Example\Library\V1\GetBookRequest;
use Google\Example\Library\V1\GetShelfRequest;
use Google\Example\Library\V1\ListBooksRequest;
use Google\Example\Library\V1\ListBooksResponse;
use Google\Example\Library\V1\ListShelvesRequest;
use Google\Example\Library\V1\ListShelvesResponse;
use Google\Example\Library\V1\MergeShelvesRequest;
use Google\Example\Library\V1\MoveBookRequest;
use Google\Example\Library\V1\Shelf;
use Google\Example\Library\V1\UpdateBookRequest;
use Google\Protobuf\FieldMask;
use Google\Protobuf\GPBEmpty;

/**
 * Service Description: This API represents a simple digital library.  It lets you manage Shelf
 * resources and Book resources in the library. It defines the following
 * resource model:.
 *
 * - The API has a collection of [Shelf][google.example.library.v1.Shelf]
 *   resources, named `shelves/*`
 *
 * - Each Shelf has a collection of [Book][google.example.library.v1.Book]
 *   resources, named `shelves/&#42;/books/*`
 *
 * This class provides the ability to make remote calls to the backing service through method
 * calls that map to API methods. Sample code to get started:
 *
 * ```
 * $libraryServiceClient = new LibraryServiceClient();
 * try {
 *     $shelf = new Shelf();
 *     $response = $libraryServiceClient->createShelf($shelf);
 * } finally {
 *     $libraryServiceClient->close();
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
class LibraryServiceGapicClient
{
    use GapicClientTrait;

    /**
     * The name of the service.
     */
    const SERVICE_NAME = 'google.example.library.v1.LibraryService';

    /**
     * The default address of the service.
     */
    const SERVICE_ADDRESS = 'library-example.googleapis.com';

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
    ];
    private static $bookNameTemplate;
    private static $shelfNameTemplate;
    private static $pathTemplateMap;

    private static function getClientDefaults()
    {
        return [
            'serviceName' => self::SERVICE_NAME,
            'serviceAddress' => self::SERVICE_ADDRESS.':'.self::DEFAULT_SERVICE_PORT,
            'clientConfig' => __DIR__.'/../resources/library_service_client_config.json',
            'descriptorsConfigPath' => __DIR__.'/../resources/library_service_descriptor_config.php',
            'gcpApiConfigPath' => __DIR__.'/../resources/library_service_grpc_config.json',
            'credentialsConfig' => [
                'defaultScopes' => self::$serviceScopes,
            ],
            'transportConfig' => [
                'rest' => [
                    'restClientConfigPath' => __DIR__.'/../resources/library_service_rest_client_config.php',
                ],
            ],
        ];
    }

    private static function getBookNameTemplate()
    {
        if (null == self::$bookNameTemplate) {
            self::$bookNameTemplate = new PathTemplate('shelves/{shelf}/books/{book}');
        }

        return self::$bookNameTemplate;
    }

    private static function getShelfNameTemplate()
    {
        if (null == self::$shelfNameTemplate) {
            self::$shelfNameTemplate = new PathTemplate('shelves/{shelf_id}');
        }

        return self::$shelfNameTemplate;
    }

    private static function getPathTemplateMap()
    {
        if (null == self::$pathTemplateMap) {
            self::$pathTemplateMap = [
                'book' => self::getBookNameTemplate(),
                'shelf' => self::getShelfNameTemplate(),
            ];
        }

        return self::$pathTemplateMap;
    }

    /**
     * Formats a string containing the fully-qualified path to represent
     * a book resource.
     *
     * @param string $shelf
     * @param string $book
     *
     * @return string The formatted book resource.
     * @experimental
     */
    public static function bookName($shelf, $book)
    {
        return self::getBookNameTemplate()->render([
            'shelf' => $shelf,
            'book' => $book,
        ]);
    }

    /**
     * Formats a string containing the fully-qualified path to represent
     * a shelf resource.
     *
     * @param string $shelfId
     *
     * @return string The formatted shelf resource.
     * @experimental
     */
    public static function shelfName($shelfId)
    {
        return self::getShelfNameTemplate()->render([
            'shelf_id' => $shelfId,
        ]);
    }

    /**
     * Parses a formatted name string and returns an associative array of the components in the name.
     * The following name formats are supported:
     * Template: Pattern
     * - book: shelves/{shelf}/books/{book}
     * - shelf: shelves/{shelf_id}.
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
     *           as "<uri>:<port>". Default 'library-example.googleapis.com:443'.
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
     * Creates a shelf, and returns the new Shelf.
     *
     * Sample code:
     * ```
     * $libraryServiceClient = new LibraryServiceClient();
     * try {
     *     $shelf = new Shelf();
     *     $response = $libraryServiceClient->createShelf($shelf);
     * } finally {
     *     $libraryServiceClient->close();
     * }
     * ```
     *
     * @param Shelf $shelf        The shelf to create.
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
     * @return \Google\Example\Library\V1\Shelf
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function createShelf($shelf, array $optionalArgs = [])
    {
        $request = new CreateShelfRequest();
        $request->setShelf($shelf);

        return $this->startCall(
            'CreateShelf',
            Shelf::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Gets a shelf. Returns NOT_FOUND if the shelf does not exist.
     *
     * Sample code:
     * ```
     * $libraryServiceClient = new LibraryServiceClient();
     * try {
     *     $formattedName = $libraryServiceClient->shelfName('[SHELF_ID]');
     *     $response = $libraryServiceClient->getShelf($formattedName);
     * } finally {
     *     $libraryServiceClient->close();
     * }
     * ```
     *
     * @param string $name         The name of the shelf to retrieve.
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
     * @return \Google\Example\Library\V1\Shelf
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function getShelf($name, array $optionalArgs = [])
    {
        $request = new GetShelfRequest();
        $request->setName($name);

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'GetShelf',
            Shelf::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Lists shelves. The order is unspecified but deterministic. Newly created
     * shelves will not necessarily be added to the end of this list.
     *
     * Sample code:
     * ```
     * $libraryServiceClient = new LibraryServiceClient();
     * try {
     *     // Iterate over pages of elements
     *     $pagedResponse = $libraryServiceClient->listShelves();
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
     *     $pagedResponse = $libraryServiceClient->listShelves();
     *     foreach ($pagedResponse->iterateAllElements() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $libraryServiceClient->close();
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
    public function listShelves(array $optionalArgs = [])
    {
        $request = new ListShelvesRequest();
        if (isset($optionalArgs['pageSize'])) {
            $request->setPageSize($optionalArgs['pageSize']);
        }
        if (isset($optionalArgs['pageToken'])) {
            $request->setPageToken($optionalArgs['pageToken']);
        }

        return $this->getPagedListResponse(
            'ListShelves',
            $optionalArgs,
            ListShelvesResponse::class,
            $request
        );
    }

    /**
     * Deletes a shelf. Returns NOT_FOUND if the shelf does not exist.
     *
     * Sample code:
     * ```
     * $libraryServiceClient = new LibraryServiceClient();
     * try {
     *     $formattedName = $libraryServiceClient->shelfName('[SHELF_ID]');
     *     $libraryServiceClient->deleteShelf($formattedName);
     * } finally {
     *     $libraryServiceClient->close();
     * }
     * ```
     *
     * @param string $name         The name of the shelf to delete.
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
    public function deleteShelf($name, array $optionalArgs = [])
    {
        $request = new DeleteShelfRequest();
        $request->setName($name);

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'DeleteShelf',
            GPBEmpty::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Merges two shelves by adding all books from the shelf named
     * `other_shelf_name` to shelf `name`, and deletes
     * `other_shelf_name`. Returns the updated shelf.
     * The book ids of the moved books may not be the same as the original books.
     *
     * Returns NOT_FOUND if either shelf does not exist.
     * This call is a no-op if the specified shelves are the same.
     *
     * Sample code:
     * ```
     * $libraryServiceClient = new LibraryServiceClient();
     * try {
     *     $formattedName = $libraryServiceClient->shelfName('[SHELF_ID]');
     *     $formattedOtherShelf = $libraryServiceClient->shelfName('[SHELF_ID]');
     *     $response = $libraryServiceClient->mergeShelves($formattedName, $formattedOtherShelf);
     * } finally {
     *     $libraryServiceClient->close();
     * }
     * ```
     *
     * @param string $name         The name of the shelf we're adding books to.
     * @param string $otherShelf   The name of the shelf we're removing books from and deleting.
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
     * @return \Google\Example\Library\V1\Shelf
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function mergeShelves($name, $otherShelf, array $optionalArgs = [])
    {
        $request = new MergeShelvesRequest();
        $request->setName($name);
        $request->setOtherShelf($otherShelf);

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'MergeShelves',
            Shelf::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Creates a book, and returns the new Book.
     *
     * Sample code:
     * ```
     * $libraryServiceClient = new LibraryServiceClient();
     * try {
     *     $formattedParent = $libraryServiceClient->shelfName('[SHELF_ID]');
     *     $book = new Book();
     *     $response = $libraryServiceClient->createBook($formattedParent, $book);
     * } finally {
     *     $libraryServiceClient->close();
     * }
     * ```
     *
     * @param string $parent       The name of the shelf in which the book is created.
     * @param Book   $book         The book to create.
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
     * @return \Google\Example\Library\V1\Book
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function createBook($parent, $book, array $optionalArgs = [])
    {
        $request = new CreateBookRequest();
        $request->setParent($parent);
        $request->setBook($book);

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'CreateBook',
            Book::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Gets a book. Returns NOT_FOUND if the book does not exist.
     *
     * Sample code:
     * ```
     * $libraryServiceClient = new LibraryServiceClient();
     * try {
     *     $formattedName = $libraryServiceClient->bookName('[SHELF]', '[BOOK]');
     *     $response = $libraryServiceClient->getBook($formattedName);
     * } finally {
     *     $libraryServiceClient->close();
     * }
     * ```
     *
     * @param string $name         The name of the book to retrieve.
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
     * @return \Google\Example\Library\V1\Book
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function getBook($name, array $optionalArgs = [])
    {
        $request = new GetBookRequest();
        $request->setName($name);

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'GetBook',
            Book::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Lists books in a shelf. The order is unspecified but deterministic. Newly
     * created books will not necessarily be added to the end of this list.
     * Returns NOT_FOUND if the shelf does not exist.
     *
     * Sample code:
     * ```
     * $libraryServiceClient = new LibraryServiceClient();
     * try {
     *     $formattedParent = $libraryServiceClient->shelfName('[SHELF_ID]');
     *     // Iterate over pages of elements
     *     $pagedResponse = $libraryServiceClient->listBooks($formattedParent);
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
     *     $pagedResponse = $libraryServiceClient->listBooks($formattedParent);
     *     foreach ($pagedResponse->iterateAllElements() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $libraryServiceClient->close();
     * }
     * ```
     *
     * @param string $parent       The name of the shelf whose books we'd like to list.
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
    public function listBooks($parent, array $optionalArgs = [])
    {
        $request = new ListBooksRequest();
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
            'ListBooks',
            $optionalArgs,
            ListBooksResponse::class,
            $request
        );
    }

    /**
     * Deletes a book. Returns NOT_FOUND if the book does not exist.
     *
     * Sample code:
     * ```
     * $libraryServiceClient = new LibraryServiceClient();
     * try {
     *     $formattedName = $libraryServiceClient->bookName('[SHELF]', '[BOOK]');
     *     $libraryServiceClient->deleteBook($formattedName);
     * } finally {
     *     $libraryServiceClient->close();
     * }
     * ```
     *
     * @param string $name         The name of the book to delete.
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
    public function deleteBook($name, array $optionalArgs = [])
    {
        $request = new DeleteBookRequest();
        $request->setName($name);

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'DeleteBook',
            GPBEmpty::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Updates a book. Returns INVALID_ARGUMENT if the name of the book
     * is non-empty and does not equal the existing name.
     *
     * Sample code:
     * ```
     * $libraryServiceClient = new LibraryServiceClient();
     * try {
     *     $book = new Book();
     *     $updateMask = new FieldMask();
     *     $response = $libraryServiceClient->updateBook($book, $updateMask);
     * } finally {
     *     $libraryServiceClient->close();
     * }
     * ```
     *
     * @param Book      $book         The name of the book to update.
     * @param FieldMask $updateMask   Required. Mask of fields to update.
     * @param array     $optionalArgs {
     *                                Optional.
     *
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Example\Library\V1\Book
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function updateBook($book, $updateMask, array $optionalArgs = [])
    {
        $request = new UpdateBookRequest();
        $request->setBook($book);
        $request->setUpdateMask($updateMask);

        $requestParams = new RequestParamsHeaderDescriptor([
          'book.name' => $request->getBook()->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'UpdateBook',
            Book::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Moves a book to another shelf, and returns the new book. The book
     * id of the new book may not be the same as the original book.
     *
     * Sample code:
     * ```
     * $libraryServiceClient = new LibraryServiceClient();
     * try {
     *     $formattedName = $libraryServiceClient->bookName('[SHELF]', '[BOOK]');
     *     $formattedOtherShelfName = $libraryServiceClient->shelfName('[SHELF_ID]');
     *     $response = $libraryServiceClient->moveBook($formattedName, $formattedOtherShelfName);
     * } finally {
     *     $libraryServiceClient->close();
     * }
     * ```
     *
     * @param string $name           The name of the book to move.
     * @param string $otherShelfName The name of the destination shelf.
     * @param array  $optionalArgs   {
     *                               Optional.
     *
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Example\Library\V1\Book
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function moveBook($name, $otherShelfName, array $optionalArgs = [])
    {
        $request = new MoveBookRequest();
        $request->setName($name);
        $request->setOtherShelfName($otherShelfName);

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'MoveBook',
            Book::class,
            $optionalArgs,
            $request
        )->wait();
    }
}
