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
 * https://github.com/google/googleapis/blob/master/google/cloud/datacatalog/v1/policytagmanager.proto
 * and updates to that file get reflected here through a refresh process.
 *
 * @experimental
 */

namespace Google\Cloud\DataCatalog\V1\Gapic;

use Google\ApiCore\ApiException;
use Google\ApiCore\CredentialsWrapper;
use Google\ApiCore\GapicClientTrait;
use Google\ApiCore\PathTemplate;
use Google\ApiCore\RequestParamsHeaderDescriptor;
use Google\ApiCore\RetrySettings;
use Google\ApiCore\Transport\TransportInterface;
use Google\ApiCore\ValidationException;
use Google\Auth\FetchAuthTokenInterface;
use Google\Cloud\DataCatalog\V1\CreatePolicyTagRequest;
use Google\Cloud\DataCatalog\V1\CreateTaxonomyRequest;
use Google\Cloud\DataCatalog\V1\DeletePolicyTagRequest;
use Google\Cloud\DataCatalog\V1\DeleteTaxonomyRequest;
use Google\Cloud\DataCatalog\V1\GetPolicyTagRequest;
use Google\Cloud\DataCatalog\V1\GetTaxonomyRequest;
use Google\Cloud\DataCatalog\V1\ListPolicyTagsRequest;
use Google\Cloud\DataCatalog\V1\ListPolicyTagsResponse;
use Google\Cloud\DataCatalog\V1\ListTaxonomiesRequest;
use Google\Cloud\DataCatalog\V1\ListTaxonomiesResponse;
use Google\Cloud\DataCatalog\V1\PolicyTag;
use Google\Cloud\DataCatalog\V1\Taxonomy;
use Google\Cloud\DataCatalog\V1\UpdatePolicyTagRequest;
use Google\Cloud\DataCatalog\V1\UpdateTaxonomyRequest;
use Google\Cloud\Iam\V1\GetIamPolicyRequest;
use Google\Cloud\Iam\V1\GetPolicyOptions;
use Google\Cloud\Iam\V1\Policy;
use Google\Cloud\Iam\V1\SetIamPolicyRequest;
use Google\Cloud\Iam\V1\TestIamPermissionsRequest;
use Google\Cloud\Iam\V1\TestIamPermissionsResponse;
use Google\Protobuf\FieldMask;
use Google\Protobuf\GPBEmpty;

/**
 * Service Description: Policy Tag Manager API service allows clients to manage their policy tags and
 * taxonomies.
 *
 * Policy tags are used to tag BigQuery columns and apply additional access
 * control policies. A taxonomy is a hierarchical grouping of policy tags that
 * classify data along a common axis.
 *
 * This class provides the ability to make remote calls to the backing service through method
 * calls that map to API methods. Sample code to get started:
 *
 * ```
 * $policyTagManagerClient = new PolicyTagManagerClient();
 * try {
 *     $formattedParent = $policyTagManagerClient->locationName('[PROJECT]', '[LOCATION]');
 *     $response = $policyTagManagerClient->createTaxonomy($formattedParent);
 * } finally {
 *     $policyTagManagerClient->close();
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
class PolicyTagManagerGapicClient
{
    use GapicClientTrait;

    /**
     * The name of the service.
     */
    const SERVICE_NAME = 'google.cloud.datacatalog.v1.PolicyTagManager';

    /**
     * The default address of the service.
     */
    const SERVICE_ADDRESS = 'datacatalog.googleapis.com';

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
    private static $locationNameTemplate;
    private static $policyTagNameTemplate;
    private static $taxonomyNameTemplate;
    private static $pathTemplateMap;

    private static function getClientDefaults()
    {
        return [
            'serviceName' => self::SERVICE_NAME,
            'serviceAddress' => self::SERVICE_ADDRESS.':'.self::DEFAULT_SERVICE_PORT,
            'clientConfig' => __DIR__.'/../resources/policy_tag_manager_client_config.json',
            'descriptorsConfigPath' => __DIR__.'/../resources/policy_tag_manager_descriptor_config.php',
            'gcpApiConfigPath' => __DIR__.'/../resources/policy_tag_manager_grpc_config.json',
            'credentialsConfig' => [
                'defaultScopes' => self::$serviceScopes,
            ],
            'transportConfig' => [
                'rest' => [
                    'restClientConfigPath' => __DIR__.'/../resources/policy_tag_manager_rest_client_config.php',
                ],
            ],
        ];
    }

    private static function getLocationNameTemplate()
    {
        if (null == self::$locationNameTemplate) {
            self::$locationNameTemplate = new PathTemplate('projects/{project}/locations/{location}');
        }

        return self::$locationNameTemplate;
    }

    private static function getPolicyTagNameTemplate()
    {
        if (null == self::$policyTagNameTemplate) {
            self::$policyTagNameTemplate = new PathTemplate('projects/{project}/locations/{location}/taxonomies/{taxonomy}/policyTags/{policy_tag}');
        }

        return self::$policyTagNameTemplate;
    }

    private static function getTaxonomyNameTemplate()
    {
        if (null == self::$taxonomyNameTemplate) {
            self::$taxonomyNameTemplate = new PathTemplate('projects/{project}/locations/{location}/taxonomies/{taxonomy}');
        }

        return self::$taxonomyNameTemplate;
    }

    private static function getPathTemplateMap()
    {
        if (null == self::$pathTemplateMap) {
            self::$pathTemplateMap = [
                'location' => self::getLocationNameTemplate(),
                'policyTag' => self::getPolicyTagNameTemplate(),
                'taxonomy' => self::getTaxonomyNameTemplate(),
            ];
        }

        return self::$pathTemplateMap;
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
     * a policy_tag resource.
     *
     * @param string $project
     * @param string $location
     * @param string $taxonomy
     * @param string $policyTag
     *
     * @return string The formatted policy_tag resource.
     * @experimental
     */
    public static function policyTagName($project, $location, $taxonomy, $policyTag)
    {
        return self::getPolicyTagNameTemplate()->render([
            'project' => $project,
            'location' => $location,
            'taxonomy' => $taxonomy,
            'policy_tag' => $policyTag,
        ]);
    }

    /**
     * Formats a string containing the fully-qualified path to represent
     * a taxonomy resource.
     *
     * @param string $project
     * @param string $location
     * @param string $taxonomy
     *
     * @return string The formatted taxonomy resource.
     * @experimental
     */
    public static function taxonomyName($project, $location, $taxonomy)
    {
        return self::getTaxonomyNameTemplate()->render([
            'project' => $project,
            'location' => $location,
            'taxonomy' => $taxonomy,
        ]);
    }

    /**
     * Parses a formatted name string and returns an associative array of the components in the name.
     * The following name formats are supported:
     * Template: Pattern
     * - location: projects/{project}/locations/{location}
     * - policyTag: projects/{project}/locations/{location}/taxonomies/{taxonomy}/policyTags/{policy_tag}
     * - taxonomy: projects/{project}/locations/{location}/taxonomies/{taxonomy}.
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
     *           as "<uri>:<port>". Default 'datacatalog.googleapis.com:443'.
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
     * Creates a taxonomy in a specified project. The taxonomy is initially empty,
     * i.e., does not contain policy tags.
     *
     * Sample code:
     * ```
     * $policyTagManagerClient = new PolicyTagManagerClient();
     * try {
     *     $formattedParent = $policyTagManagerClient->locationName('[PROJECT]', '[LOCATION]');
     *     $response = $policyTagManagerClient->createTaxonomy($formattedParent);
     * } finally {
     *     $policyTagManagerClient->close();
     * }
     * ```
     *
     * @param string $parent       Required. Resource name of the project that the taxonomy will belong to.
     * @param array  $optionalArgs {
     *                             Optional.
     *
     *     @type Taxonomy $taxonomy
     *          The taxonomy to be created.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\DataCatalog\V1\Taxonomy
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function createTaxonomy($parent, array $optionalArgs = [])
    {
        $request = new CreateTaxonomyRequest();
        $request->setParent($parent);
        if (isset($optionalArgs['taxonomy'])) {
            $request->setTaxonomy($optionalArgs['taxonomy']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'CreateTaxonomy',
            Taxonomy::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Deletes a taxonomy. This method will also delete all policy tags in this
     * taxonomy, their associated policies, and the policy tags references from
     * BigQuery columns.
     *
     * Sample code:
     * ```
     * $policyTagManagerClient = new PolicyTagManagerClient();
     * try {
     *     $formattedName = $policyTagManagerClient->taxonomyName('[PROJECT]', '[LOCATION]', '[TAXONOMY]');
     *     $policyTagManagerClient->deleteTaxonomy($formattedName);
     * } finally {
     *     $policyTagManagerClient->close();
     * }
     * ```
     *
     * @param string $name         Required. Resource name of the taxonomy to be deleted. All policy tags in
     *                             this taxonomy will also be deleted.
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
    public function deleteTaxonomy($name, array $optionalArgs = [])
    {
        $request = new DeleteTaxonomyRequest();
        $request->setName($name);

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'DeleteTaxonomy',
            GPBEmpty::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Updates a taxonomy. This method can update the taxonomy's display name,
     * description, and activated policy types.
     *
     * Sample code:
     * ```
     * $policyTagManagerClient = new PolicyTagManagerClient();
     * try {
     *     $response = $policyTagManagerClient->updateTaxonomy();
     * } finally {
     *     $policyTagManagerClient->close();
     * }
     * ```
     *
     * @param array $optionalArgs {
     *                            Optional.
     *
     *     @type Taxonomy $taxonomy
     *          The taxonomy to update. Only description, display_name, and activated
     *          policy types can be updated.
     *     @type FieldMask $updateMask
     *          The update mask applies to the resource. For the `FieldMask` definition,
     *          see
     *          https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
     *          If not set, defaults to all of the fields that are allowed to update.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\DataCatalog\V1\Taxonomy
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function updateTaxonomy(array $optionalArgs = [])
    {
        $request = new UpdateTaxonomyRequest();
        if (isset($optionalArgs['taxonomy'])) {
            $request->setTaxonomy($optionalArgs['taxonomy']);
        }
        if (isset($optionalArgs['updateMask'])) {
            $request->setUpdateMask($optionalArgs['updateMask']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'taxonomy.name' => $request->getTaxonomy()->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'UpdateTaxonomy',
            Taxonomy::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Lists all taxonomies in a project in a particular location that the caller
     * has permission to view.
     *
     * Sample code:
     * ```
     * $policyTagManagerClient = new PolicyTagManagerClient();
     * try {
     *     $formattedParent = $policyTagManagerClient->locationName('[PROJECT]', '[LOCATION]');
     *     // Iterate over pages of elements
     *     $pagedResponse = $policyTagManagerClient->listTaxonomies($formattedParent);
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
     *     $pagedResponse = $policyTagManagerClient->listTaxonomies($formattedParent);
     *     foreach ($pagedResponse->iterateAllElements() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $policyTagManagerClient->close();
     * }
     * ```
     *
     * @param string $parent       Required. Resource name of the project to list the taxonomies of.
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
    public function listTaxonomies($parent, array $optionalArgs = [])
    {
        $request = new ListTaxonomiesRequest();
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
            'ListTaxonomies',
            $optionalArgs,
            ListTaxonomiesResponse::class,
            $request
        );
    }

    /**
     * Gets a taxonomy.
     *
     * Sample code:
     * ```
     * $policyTagManagerClient = new PolicyTagManagerClient();
     * try {
     *     $formattedName = $policyTagManagerClient->taxonomyName('[PROJECT]', '[LOCATION]', '[TAXONOMY]');
     *     $response = $policyTagManagerClient->getTaxonomy($formattedName);
     * } finally {
     *     $policyTagManagerClient->close();
     * }
     * ```
     *
     * @param string $name         Required. Resource name of the requested taxonomy.
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
     * @return \Google\Cloud\DataCatalog\V1\Taxonomy
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function getTaxonomy($name, array $optionalArgs = [])
    {
        $request = new GetTaxonomyRequest();
        $request->setName($name);

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'GetTaxonomy',
            Taxonomy::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Creates a policy tag in a taxonomy.
     *
     * Sample code:
     * ```
     * $policyTagManagerClient = new PolicyTagManagerClient();
     * try {
     *     $formattedParent = $policyTagManagerClient->taxonomyName('[PROJECT]', '[LOCATION]', '[TAXONOMY]');
     *     $response = $policyTagManagerClient->createPolicyTag($formattedParent);
     * } finally {
     *     $policyTagManagerClient->close();
     * }
     * ```
     *
     * @param string $parent       Required. Resource name of the taxonomy that the policy tag will belong to.
     * @param array  $optionalArgs {
     *                             Optional.
     *
     *     @type PolicyTag $policyTag
     *          The policy tag to be created.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\DataCatalog\V1\PolicyTag
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function createPolicyTag($parent, array $optionalArgs = [])
    {
        $request = new CreatePolicyTagRequest();
        $request->setParent($parent);
        if (isset($optionalArgs['policyTag'])) {
            $request->setPolicyTag($optionalArgs['policyTag']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'parent' => $request->getParent(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'CreatePolicyTag',
            PolicyTag::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Deletes a policy tag. This method also deletes:.
     *
     * * all of its descendant policy tags, if any
     * * the policies associated with the policy tag and its descendants
     * * references from BigQuery table schema of the policy tag and its
     *   descendants.
     *
     * Sample code:
     * ```
     * $policyTagManagerClient = new PolicyTagManagerClient();
     * try {
     *     $formattedName = $policyTagManagerClient->policyTagName('[PROJECT]', '[LOCATION]', '[TAXONOMY]', '[POLICY_TAG]');
     *     $policyTagManagerClient->deletePolicyTag($formattedName);
     * } finally {
     *     $policyTagManagerClient->close();
     * }
     * ```
     *
     * @param string $name         Required. Resource name of the policy tag to be deleted. All of its descendant
     *                             policy tags will also be deleted.
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
    public function deletePolicyTag($name, array $optionalArgs = [])
    {
        $request = new DeletePolicyTagRequest();
        $request->setName($name);

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'DeletePolicyTag',
            GPBEmpty::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Updates a policy tag. This method can update the policy tag's display
     * name, description, and parent policy tag.
     *
     * Sample code:
     * ```
     * $policyTagManagerClient = new PolicyTagManagerClient();
     * try {
     *     $response = $policyTagManagerClient->updatePolicyTag();
     * } finally {
     *     $policyTagManagerClient->close();
     * }
     * ```
     *
     * @param array $optionalArgs {
     *                            Optional.
     *
     *     @type PolicyTag $policyTag
     *          The policy tag to update. Only the description, display_name, and
     *          parent_policy_tag fields can be updated.
     *     @type FieldMask $updateMask
     *          The update mask applies to the resource. Only display_name, description and
     *          parent_policy_tag can be updated and thus can be listed in the mask. If
     *          update_mask is not provided, all allowed fields (i.e. display_name,
     *          description and parent) will be updated. For more information including the
     *          `FieldMask` definition, see
     *          https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#fieldmask
     *          If not set, defaults to all of the fields that are allowed to update.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\DataCatalog\V1\PolicyTag
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function updatePolicyTag(array $optionalArgs = [])
    {
        $request = new UpdatePolicyTagRequest();
        if (isset($optionalArgs['policyTag'])) {
            $request->setPolicyTag($optionalArgs['policyTag']);
        }
        if (isset($optionalArgs['updateMask'])) {
            $request->setUpdateMask($optionalArgs['updateMask']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'policy_tag.name' => $request->getPolicyTag()->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'UpdatePolicyTag',
            PolicyTag::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Lists all policy tags in a taxonomy.
     *
     * Sample code:
     * ```
     * $policyTagManagerClient = new PolicyTagManagerClient();
     * try {
     *     $formattedParent = $policyTagManagerClient->taxonomyName('[PROJECT]', '[LOCATION]', '[TAXONOMY]');
     *     // Iterate over pages of elements
     *     $pagedResponse = $policyTagManagerClient->listPolicyTags($formattedParent);
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
     *     $pagedResponse = $policyTagManagerClient->listPolicyTags($formattedParent);
     *     foreach ($pagedResponse->iterateAllElements() as $element) {
     *         // doSomethingWith($element);
     *     }
     * } finally {
     *     $policyTagManagerClient->close();
     * }
     * ```
     *
     * @param string $parent       Required. Resource name of the taxonomy to list the policy tags of.
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
    public function listPolicyTags($parent, array $optionalArgs = [])
    {
        $request = new ListPolicyTagsRequest();
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
            'ListPolicyTags',
            $optionalArgs,
            ListPolicyTagsResponse::class,
            $request
        );
    }

    /**
     * Gets a policy tag.
     *
     * Sample code:
     * ```
     * $policyTagManagerClient = new PolicyTagManagerClient();
     * try {
     *     $formattedName = $policyTagManagerClient->policyTagName('[PROJECT]', '[LOCATION]', '[TAXONOMY]', '[POLICY_TAG]');
     *     $response = $policyTagManagerClient->getPolicyTag($formattedName);
     * } finally {
     *     $policyTagManagerClient->close();
     * }
     * ```
     *
     * @param string $name         Required. Resource name of the requested policy tag.
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
     * @return \Google\Cloud\DataCatalog\V1\PolicyTag
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function getPolicyTag($name, array $optionalArgs = [])
    {
        $request = new GetPolicyTagRequest();
        $request->setName($name);

        $requestParams = new RequestParamsHeaderDescriptor([
          'name' => $request->getName(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'GetPolicyTag',
            PolicyTag::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Gets the IAM policy for a policy tag or a taxonomy.
     *
     * Sample code:
     * ```
     * $policyTagManagerClient = new PolicyTagManagerClient();
     * try {
     *     $resource = '';
     *     $response = $policyTagManagerClient->getIamPolicy($resource);
     * } finally {
     *     $policyTagManagerClient->close();
     * }
     * ```
     *
     * @param string $resource     REQUIRED: The resource for which the policy is being requested.
     *                             See the operation documentation for the appropriate value for this field.
     * @param array  $optionalArgs {
     *                             Optional.
     *
     *     @type GetPolicyOptions $options
     *          OPTIONAL: A `GetPolicyOptions` object for specifying options to
     *          `GetIamPolicy`. This field is only used by Cloud IAM.
     *     @type RetrySettings|array $retrySettings
     *          Retry settings to use for this call. Can be a
     *          {@see Google\ApiCore\RetrySettings} object, or an associative array
     *          of retry settings parameters. See the documentation on
     *          {@see Google\ApiCore\RetrySettings} for example usage.
     * }
     *
     * @return \Google\Cloud\Iam\V1\Policy
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function getIamPolicy($resource, array $optionalArgs = [])
    {
        $request = new GetIamPolicyRequest();
        $request->setResource($resource);
        if (isset($optionalArgs['options'])) {
            $request->setOptions($optionalArgs['options']);
        }

        $requestParams = new RequestParamsHeaderDescriptor([
          'resource' => $request->getResource(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'GetIamPolicy',
            Policy::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Sets the IAM policy for a policy tag or a taxonomy.
     *
     * Sample code:
     * ```
     * $policyTagManagerClient = new PolicyTagManagerClient();
     * try {
     *     $resource = '';
     *     $policy = new Policy();
     *     $response = $policyTagManagerClient->setIamPolicy($resource, $policy);
     * } finally {
     *     $policyTagManagerClient->close();
     * }
     * ```
     *
     * @param string $resource     REQUIRED: The resource for which the policy is being specified.
     *                             See the operation documentation for the appropriate value for this field.
     * @param Policy $policy       REQUIRED: The complete policy to be applied to the `resource`. The size of
     *                             the policy is limited to a few 10s of KB. An empty policy is a
     *                             valid policy but certain Cloud Platform services (such as Projects)
     *                             might reject them.
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
     * @return \Google\Cloud\Iam\V1\Policy
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function setIamPolicy($resource, $policy, array $optionalArgs = [])
    {
        $request = new SetIamPolicyRequest();
        $request->setResource($resource);
        $request->setPolicy($policy);

        $requestParams = new RequestParamsHeaderDescriptor([
          'resource' => $request->getResource(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'SetIamPolicy',
            Policy::class,
            $optionalArgs,
            $request
        )->wait();
    }

    /**
     * Returns the permissions that a caller has on a specified policy tag or
     * taxonomy.
     *
     * Sample code:
     * ```
     * $policyTagManagerClient = new PolicyTagManagerClient();
     * try {
     *     $resource = '';
     *     $permissions = [];
     *     $response = $policyTagManagerClient->testIamPermissions($resource, $permissions);
     * } finally {
     *     $policyTagManagerClient->close();
     * }
     * ```
     *
     * @param string   $resource     REQUIRED: The resource for which the policy detail is being requested.
     *                               See the operation documentation for the appropriate value for this field.
     * @param string[] $permissions  The set of permissions to check for the `resource`. Permissions with
     *                               wildcards (such as '*' or 'storage.*') are not allowed. For more
     *                               information see
     *                               [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
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
     * @return \Google\Cloud\Iam\V1\TestIamPermissionsResponse
     *
     * @throws ApiException if the remote call fails
     * @experimental
     */
    public function testIamPermissions($resource, $permissions, array $optionalArgs = [])
    {
        $request = new TestIamPermissionsRequest();
        $request->setResource($resource);
        $request->setPermissions($permissions);

        $requestParams = new RequestParamsHeaderDescriptor([
          'resource' => $request->getResource(),
        ]);
        $optionalArgs['headers'] = isset($optionalArgs['headers'])
            ? array_merge($requestParams->getHeader(), $optionalArgs['headers'])
            : $requestParams->getHeader();

        return $this->startCall(
            'TestIamPermissions',
            TestIamPermissionsResponse::class,
            $optionalArgs,
            $request
        )->wait();
    }
}
