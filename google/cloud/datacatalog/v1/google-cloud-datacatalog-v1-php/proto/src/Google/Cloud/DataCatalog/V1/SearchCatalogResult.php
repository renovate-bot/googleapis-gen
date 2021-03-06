<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/datacatalog/v1/search.proto

namespace Google\Cloud\DataCatalog\V1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * A result that appears in the response of a search request. Each result
 * captures details of one entry that matches the search.
 *
 * Generated from protobuf message <code>google.cloud.datacatalog.v1.SearchCatalogResult</code>
 */
class SearchCatalogResult extends \Google\Protobuf\Internal\Message
{
    /**
     * Type of the search result. This field can be used to determine which Get
     * method to call to fetch the full resource.
     *
     * Generated from protobuf field <code>.google.cloud.datacatalog.v1.SearchResultType search_result_type = 1;</code>
     */
    protected $search_result_type = 0;
    /**
     * Sub-type of the search result. This is a dot-delimited description of the
     * resource's full type, and is the same as the value callers would provide in
     * the "type" search facet.  Examples: `entry.table`, `entry.dataStream`,
     * `tagTemplate`.
     *
     * Generated from protobuf field <code>string search_result_subtype = 2;</code>
     */
    protected $search_result_subtype = '';
    /**
     * The relative resource name of the resource in URL format.
     * Examples:
     *  * `projects/{project_id}/locations/{location_id}/entryGroups/{entry_group_id}/entries/{entry_id}`
     *  * `projects/{project_id}/tagTemplates/{tag_template_id}`
     *
     * Generated from protobuf field <code>string relative_resource_name = 3;</code>
     */
    protected $relative_resource_name = '';
    /**
     * The full name of the cloud resource the entry belongs to. See:
     * https://cloud.google.com/apis/design/resource_names#full_resource_name.
     * Example:
     *  * `//bigquery.googleapis.com/projects/projectId/datasets/datasetId/tables/tableId`
     *
     * Generated from protobuf field <code>string linked_resource = 4;</code>
     */
    protected $linked_resource = '';
    /**
     * Last-modified timestamp of the entry from the managing system.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp modify_time = 7;</code>
     */
    protected $modify_time = null;
    /**
     * Fully Qualified Name of the resource.
     * There are two main forms of FQNs:
     * {system}:{project}.{dot-separated path to resource}
     *     for non-regionalized resources
     * {system}:{project}.{location id}.{dot-separated path to resource}
     *     for regionalized resources
     * Examples:
     * * dataproc_metastore:projectId.locationId.instanceId.databaseId.tableId
     * * bigquery:table.project_id.dataset_id.table_id
     *
     * Generated from protobuf field <code>string fully_qualified_name = 10;</code>
     */
    protected $fully_qualified_name = '';
    protected $system;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type int $search_result_type
     *           Type of the search result. This field can be used to determine which Get
     *           method to call to fetch the full resource.
     *     @type string $search_result_subtype
     *           Sub-type of the search result. This is a dot-delimited description of the
     *           resource's full type, and is the same as the value callers would provide in
     *           the "type" search facet.  Examples: `entry.table`, `entry.dataStream`,
     *           `tagTemplate`.
     *     @type string $relative_resource_name
     *           The relative resource name of the resource in URL format.
     *           Examples:
     *            * `projects/{project_id}/locations/{location_id}/entryGroups/{entry_group_id}/entries/{entry_id}`
     *            * `projects/{project_id}/tagTemplates/{tag_template_id}`
     *     @type string $linked_resource
     *           The full name of the cloud resource the entry belongs to. See:
     *           https://cloud.google.com/apis/design/resource_names#full_resource_name.
     *           Example:
     *            * `//bigquery.googleapis.com/projects/projectId/datasets/datasetId/tables/tableId`
     *     @type \Google\Protobuf\Timestamp $modify_time
     *           Last-modified timestamp of the entry from the managing system.
     *     @type int $integrated_system
     *           Output only. This field indicates the entry's source system that Data Catalog
     *           integrates with, such as BigQuery or Cloud Pub/Sub.
     *     @type string $user_specified_system
     *           This field indicates the entry's source system that Data Catalog does not
     *           integrate with.
     *     @type string $fully_qualified_name
     *           Fully Qualified Name of the resource.
     *           There are two main forms of FQNs:
     *           {system}:{project}.{dot-separated path to resource}
     *               for non-regionalized resources
     *           {system}:{project}.{location id}.{dot-separated path to resource}
     *               for regionalized resources
     *           Examples:
     *           * dataproc_metastore:projectId.locationId.instanceId.databaseId.tableId
     *           * bigquery:table.project_id.dataset_id.table_id
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Datacatalog\V1\Search::initOnce();
        parent::__construct($data);
    }

    /**
     * Type of the search result. This field can be used to determine which Get
     * method to call to fetch the full resource.
     *
     * Generated from protobuf field <code>.google.cloud.datacatalog.v1.SearchResultType search_result_type = 1;</code>
     * @return int
     */
    public function getSearchResultType()
    {
        return $this->search_result_type;
    }

    /**
     * Type of the search result. This field can be used to determine which Get
     * method to call to fetch the full resource.
     *
     * Generated from protobuf field <code>.google.cloud.datacatalog.v1.SearchResultType search_result_type = 1;</code>
     * @param int $var
     * @return $this
     */
    public function setSearchResultType($var)
    {
        GPBUtil::checkEnum($var, \Google\Cloud\DataCatalog\V1\SearchResultType::class);
        $this->search_result_type = $var;

        return $this;
    }

    /**
     * Sub-type of the search result. This is a dot-delimited description of the
     * resource's full type, and is the same as the value callers would provide in
     * the "type" search facet.  Examples: `entry.table`, `entry.dataStream`,
     * `tagTemplate`.
     *
     * Generated from protobuf field <code>string search_result_subtype = 2;</code>
     * @return string
     */
    public function getSearchResultSubtype()
    {
        return $this->search_result_subtype;
    }

    /**
     * Sub-type of the search result. This is a dot-delimited description of the
     * resource's full type, and is the same as the value callers would provide in
     * the "type" search facet.  Examples: `entry.table`, `entry.dataStream`,
     * `tagTemplate`.
     *
     * Generated from protobuf field <code>string search_result_subtype = 2;</code>
     * @param string $var
     * @return $this
     */
    public function setSearchResultSubtype($var)
    {
        GPBUtil::checkString($var, True);
        $this->search_result_subtype = $var;

        return $this;
    }

    /**
     * The relative resource name of the resource in URL format.
     * Examples:
     *  * `projects/{project_id}/locations/{location_id}/entryGroups/{entry_group_id}/entries/{entry_id}`
     *  * `projects/{project_id}/tagTemplates/{tag_template_id}`
     *
     * Generated from protobuf field <code>string relative_resource_name = 3;</code>
     * @return string
     */
    public function getRelativeResourceName()
    {
        return $this->relative_resource_name;
    }

    /**
     * The relative resource name of the resource in URL format.
     * Examples:
     *  * `projects/{project_id}/locations/{location_id}/entryGroups/{entry_group_id}/entries/{entry_id}`
     *  * `projects/{project_id}/tagTemplates/{tag_template_id}`
     *
     * Generated from protobuf field <code>string relative_resource_name = 3;</code>
     * @param string $var
     * @return $this
     */
    public function setRelativeResourceName($var)
    {
        GPBUtil::checkString($var, True);
        $this->relative_resource_name = $var;

        return $this;
    }

    /**
     * The full name of the cloud resource the entry belongs to. See:
     * https://cloud.google.com/apis/design/resource_names#full_resource_name.
     * Example:
     *  * `//bigquery.googleapis.com/projects/projectId/datasets/datasetId/tables/tableId`
     *
     * Generated from protobuf field <code>string linked_resource = 4;</code>
     * @return string
     */
    public function getLinkedResource()
    {
        return $this->linked_resource;
    }

    /**
     * The full name of the cloud resource the entry belongs to. See:
     * https://cloud.google.com/apis/design/resource_names#full_resource_name.
     * Example:
     *  * `//bigquery.googleapis.com/projects/projectId/datasets/datasetId/tables/tableId`
     *
     * Generated from protobuf field <code>string linked_resource = 4;</code>
     * @param string $var
     * @return $this
     */
    public function setLinkedResource($var)
    {
        GPBUtil::checkString($var, True);
        $this->linked_resource = $var;

        return $this;
    }

    /**
     * Last-modified timestamp of the entry from the managing system.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp modify_time = 7;</code>
     * @return \Google\Protobuf\Timestamp|null
     */
    public function getModifyTime()
    {
        return isset($this->modify_time) ? $this->modify_time : null;
    }

    public function hasModifyTime()
    {
        return isset($this->modify_time);
    }

    public function clearModifyTime()
    {
        unset($this->modify_time);
    }

    /**
     * Last-modified timestamp of the entry from the managing system.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp modify_time = 7;</code>
     * @param \Google\Protobuf\Timestamp $var
     * @return $this
     */
    public function setModifyTime($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Timestamp::class);
        $this->modify_time = $var;

        return $this;
    }

    /**
     * Output only. This field indicates the entry's source system that Data Catalog
     * integrates with, such as BigQuery or Cloud Pub/Sub.
     *
     * Generated from protobuf field <code>.google.cloud.datacatalog.v1.IntegratedSystem integrated_system = 8 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @return int
     */
    public function getIntegratedSystem()
    {
        return $this->readOneof(8);
    }

    public function hasIntegratedSystem()
    {
        return $this->hasOneof(8);
    }

    /**
     * Output only. This field indicates the entry's source system that Data Catalog
     * integrates with, such as BigQuery or Cloud Pub/Sub.
     *
     * Generated from protobuf field <code>.google.cloud.datacatalog.v1.IntegratedSystem integrated_system = 8 [(.google.api.field_behavior) = OUTPUT_ONLY];</code>
     * @param int $var
     * @return $this
     */
    public function setIntegratedSystem($var)
    {
        GPBUtil::checkEnum($var, \Google\Cloud\DataCatalog\V1\IntegratedSystem::class);
        $this->writeOneof(8, $var);

        return $this;
    }

    /**
     * This field indicates the entry's source system that Data Catalog does not
     * integrate with.
     *
     * Generated from protobuf field <code>string user_specified_system = 9;</code>
     * @return string
     */
    public function getUserSpecifiedSystem()
    {
        return $this->readOneof(9);
    }

    public function hasUserSpecifiedSystem()
    {
        return $this->hasOneof(9);
    }

    /**
     * This field indicates the entry's source system that Data Catalog does not
     * integrate with.
     *
     * Generated from protobuf field <code>string user_specified_system = 9;</code>
     * @param string $var
     * @return $this
     */
    public function setUserSpecifiedSystem($var)
    {
        GPBUtil::checkString($var, True);
        $this->writeOneof(9, $var);

        return $this;
    }

    /**
     * Fully Qualified Name of the resource.
     * There are two main forms of FQNs:
     * {system}:{project}.{dot-separated path to resource}
     *     for non-regionalized resources
     * {system}:{project}.{location id}.{dot-separated path to resource}
     *     for regionalized resources
     * Examples:
     * * dataproc_metastore:projectId.locationId.instanceId.databaseId.tableId
     * * bigquery:table.project_id.dataset_id.table_id
     *
     * Generated from protobuf field <code>string fully_qualified_name = 10;</code>
     * @return string
     */
    public function getFullyQualifiedName()
    {
        return $this->fully_qualified_name;
    }

    /**
     * Fully Qualified Name of the resource.
     * There are two main forms of FQNs:
     * {system}:{project}.{dot-separated path to resource}
     *     for non-regionalized resources
     * {system}:{project}.{location id}.{dot-separated path to resource}
     *     for regionalized resources
     * Examples:
     * * dataproc_metastore:projectId.locationId.instanceId.databaseId.tableId
     * * bigquery:table.project_id.dataset_id.table_id
     *
     * Generated from protobuf field <code>string fully_qualified_name = 10;</code>
     * @param string $var
     * @return $this
     */
    public function setFullyQualifiedName($var)
    {
        GPBUtil::checkString($var, True);
        $this->fully_qualified_name = $var;

        return $this;
    }

    /**
     * @return string
     */
    public function getSystem()
    {
        return $this->whichOneof("system");
    }

}

