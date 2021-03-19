<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/aiplatform/v1beta1/migration_service.proto

namespace Google\Cloud\Aiplatform\V1beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Request message for [MigrationService.SearchMigratableResources][google.cloud.aiplatform.v1beta1.MigrationService.SearchMigratableResources].
 *
 * Generated from protobuf message <code>google.cloud.aiplatform.v1beta1.SearchMigratableResourcesRequest</code>
 */
class SearchMigratableResourcesRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The location that the migratable resources should be searched from.
     * It's the AI Platform location that the resources can be migrated to, not
     * the resources' original location.
     * Format:
     * `projects/{project}/locations/{location}`
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     */
    protected $parent = '';
    /**
     * The standard page size.
     * The default and maximum value is 100.
     *
     * Generated from protobuf field <code>int32 page_size = 2;</code>
     */
    protected $page_size = 0;
    /**
     * The standard page token.
     *
     * Generated from protobuf field <code>string page_token = 3;</code>
     */
    protected $page_token = '';
    /**
     * Supported filters are:
     * * Resource type: For a specific type of MigratableResource.
     *   * `ml_engine_model_version:*`
     *   * `automl_model:*`,
     *   * `automl_dataset:*`
     *   * `data_labeling_dataset:*`.
     * * Migrated or not: Filter migrated resource or not by last_migrate_time.
     *   * `last_migrate_time:*` will filter migrated resources.
     *   * `NOT last_migrate_time:*` will filter not yet migrated resources.
     *
     * Generated from protobuf field <code>string filter = 4;</code>
     */
    protected $filter = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $parent
     *           Required. The location that the migratable resources should be searched from.
     *           It's the AI Platform location that the resources can be migrated to, not
     *           the resources' original location.
     *           Format:
     *           `projects/{project}/locations/{location}`
     *     @type int $page_size
     *           The standard page size.
     *           The default and maximum value is 100.
     *     @type string $page_token
     *           The standard page token.
     *     @type string $filter
     *           Supported filters are:
     *           * Resource type: For a specific type of MigratableResource.
     *             * `ml_engine_model_version:*`
     *             * `automl_model:*`,
     *             * `automl_dataset:*`
     *             * `data_labeling_dataset:*`.
     *           * Migrated or not: Filter migrated resource or not by last_migrate_time.
     *             * `last_migrate_time:*` will filter migrated resources.
     *             * `NOT last_migrate_time:*` will filter not yet migrated resources.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Aiplatform\V1Beta1\MigrationService::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The location that the migratable resources should be searched from.
     * It's the AI Platform location that the resources can be migrated to, not
     * the resources' original location.
     * Format:
     * `projects/{project}/locations/{location}`
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getParent()
    {
        return $this->parent;
    }

    /**
     * Required. The location that the migratable resources should be searched from.
     * It's the AI Platform location that the resources can be migrated to, not
     * the resources' original location.
     * Format:
     * `projects/{project}/locations/{location}`
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @param string $var
     * @return $this
     */
    public function setParent($var)
    {
        GPBUtil::checkString($var, True);
        $this->parent = $var;

        return $this;
    }

    /**
     * The standard page size.
     * The default and maximum value is 100.
     *
     * Generated from protobuf field <code>int32 page_size = 2;</code>
     * @return int
     */
    public function getPageSize()
    {
        return $this->page_size;
    }

    /**
     * The standard page size.
     * The default and maximum value is 100.
     *
     * Generated from protobuf field <code>int32 page_size = 2;</code>
     * @param int $var
     * @return $this
     */
    public function setPageSize($var)
    {
        GPBUtil::checkInt32($var);
        $this->page_size = $var;

        return $this;
    }

    /**
     * The standard page token.
     *
     * Generated from protobuf field <code>string page_token = 3;</code>
     * @return string
     */
    public function getPageToken()
    {
        return $this->page_token;
    }

    /**
     * The standard page token.
     *
     * Generated from protobuf field <code>string page_token = 3;</code>
     * @param string $var
     * @return $this
     */
    public function setPageToken($var)
    {
        GPBUtil::checkString($var, True);
        $this->page_token = $var;

        return $this;
    }

    /**
     * Supported filters are:
     * * Resource type: For a specific type of MigratableResource.
     *   * `ml_engine_model_version:*`
     *   * `automl_model:*`,
     *   * `automl_dataset:*`
     *   * `data_labeling_dataset:*`.
     * * Migrated or not: Filter migrated resource or not by last_migrate_time.
     *   * `last_migrate_time:*` will filter migrated resources.
     *   * `NOT last_migrate_time:*` will filter not yet migrated resources.
     *
     * Generated from protobuf field <code>string filter = 4;</code>
     * @return string
     */
    public function getFilter()
    {
        return $this->filter;
    }

    /**
     * Supported filters are:
     * * Resource type: For a specific type of MigratableResource.
     *   * `ml_engine_model_version:*`
     *   * `automl_model:*`,
     *   * `automl_dataset:*`
     *   * `data_labeling_dataset:*`.
     * * Migrated or not: Filter migrated resource or not by last_migrate_time.
     *   * `last_migrate_time:*` will filter migrated resources.
     *   * `NOT last_migrate_time:*` will filter not yet migrated resources.
     *
     * Generated from protobuf field <code>string filter = 4;</code>
     * @param string $var
     * @return $this
     */
    public function setFilter($var)
    {
        GPBUtil::checkString($var, True);
        $this->filter = $var;

        return $this;
    }

}

