<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/bigquery/migration/v2alpha/migration_service.proto

namespace Google\Cloud\Bigquery\Migration\V2alpha;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Response object for a `ListMigrationWorkflows` call.
 *
 * Generated from protobuf message <code>google.cloud.bigquery.migration.v2alpha.ListMigrationWorkflowsResponse</code>
 */
class ListMigrationWorkflowsResponse extends \Google\Protobuf\Internal\Message
{
    /**
     * The migration workflows for the specified project / location.
     *
     * Generated from protobuf field <code>repeated .google.cloud.bigquery.migration.v2alpha.MigrationWorkflow migration_workflows = 1;</code>
     */
    private $migration_workflows;
    /**
     * A token, which can be sent as `page_token` to retrieve the next page.
     * If this field is omitted, there are no subsequent pages.
     *
     * Generated from protobuf field <code>string next_page_token = 2;</code>
     */
    protected $next_page_token = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Cloud\Bigquery\Migration\V2alpha\MigrationWorkflow[]|\Google\Protobuf\Internal\RepeatedField $migration_workflows
     *           The migration workflows for the specified project / location.
     *     @type string $next_page_token
     *           A token, which can be sent as `page_token` to retrieve the next page.
     *           If this field is omitted, there are no subsequent pages.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Bigquery\Migration\V2Alpha\MigrationService::initOnce();
        parent::__construct($data);
    }

    /**
     * The migration workflows for the specified project / location.
     *
     * Generated from protobuf field <code>repeated .google.cloud.bigquery.migration.v2alpha.MigrationWorkflow migration_workflows = 1;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getMigrationWorkflows()
    {
        return $this->migration_workflows;
    }

    /**
     * The migration workflows for the specified project / location.
     *
     * Generated from protobuf field <code>repeated .google.cloud.bigquery.migration.v2alpha.MigrationWorkflow migration_workflows = 1;</code>
     * @param \Google\Cloud\Bigquery\Migration\V2alpha\MigrationWorkflow[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setMigrationWorkflows($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::MESSAGE, \Google\Cloud\Bigquery\Migration\V2alpha\MigrationWorkflow::class);
        $this->migration_workflows = $arr;

        return $this;
    }

    /**
     * A token, which can be sent as `page_token` to retrieve the next page.
     * If this field is omitted, there are no subsequent pages.
     *
     * Generated from protobuf field <code>string next_page_token = 2;</code>
     * @return string
     */
    public function getNextPageToken()
    {
        return $this->next_page_token;
    }

    /**
     * A token, which can be sent as `page_token` to retrieve the next page.
     * If this field is omitted, there are no subsequent pages.
     *
     * Generated from protobuf field <code>string next_page_token = 2;</code>
     * @param string $var
     * @return $this
     */
    public function setNextPageToken($var)
    {
        GPBUtil::checkString($var, True);
        $this->next_page_token = $var;

        return $this;
    }

}

