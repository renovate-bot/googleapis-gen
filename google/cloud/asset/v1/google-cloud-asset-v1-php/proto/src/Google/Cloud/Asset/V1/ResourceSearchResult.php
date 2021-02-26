<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/asset/v1/assets.proto

namespace Google\Cloud\Asset\V1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * A result of Resource Search, containing information of a cloud resource.
 *
 * Generated from protobuf message <code>google.cloud.asset.v1.ResourceSearchResult</code>
 */
class ResourceSearchResult extends \Google\Protobuf\Internal\Message
{
    /**
     * The full resource name of this resource. Example:
     * `//compute.googleapis.com/projects/my_project_123/zones/zone1/instances/instance1`.
     * See [Cloud Asset Inventory Resource Name
     * Format](https://cloud.google.com/asset-inventory/docs/resource-name-format)
     * for more information.
     * To search against the `name`:
     * * use a field query. Example: `name:instance1`
     * * use a free text query. Example: `instance1`
     *
     * Generated from protobuf field <code>string name = 1;</code>
     */
    protected $name = '';
    /**
     * The type of this resource. Example: `compute.googleapis.com/Disk`.
     * To search against the `asset_type`:
     * * specify the `asset_type` field in your search request.
     *
     * Generated from protobuf field <code>string asset_type = 2;</code>
     */
    protected $asset_type = '';
    /**
     * The project that this resource belongs to, in the form of
     * projects/{PROJECT_NUMBER}.
     * To search against the `project`:
     * * specify the `scope` field as this project in your search request.
     *
     * Generated from protobuf field <code>string project = 3;</code>
     */
    protected $project = '';
    /**
     * The display name of this resource.
     * To search against the `display_name`:
     * * use a field query. Example: `displayName:"My Instance"`
     * * use a free text query. Example: `"My Instance"`
     *
     * Generated from protobuf field <code>string display_name = 4;</code>
     */
    protected $display_name = '';
    /**
     * One or more paragraphs of text description of this resource. Maximum length
     * could be up to 1M bytes.
     * To search against the `description`:
     * * use a field query. Example: `description:"*important instance*"`
     * * use a free text query. Example: `"*important instance*"`
     *
     * Generated from protobuf field <code>string description = 5;</code>
     */
    protected $description = '';
    /**
     * Location can be `global`, regional like `us-east1`, or zonal like
     * `us-west1-b`.
     * To search against the `location`:
     * * use a field query. Example: `location:us-west*`
     * * use a free text query. Example: `us-west*`
     *
     * Generated from protobuf field <code>string location = 6;</code>
     */
    protected $location = '';
    /**
     * Labels associated with this resource. See [Labelling and grouping GCP
     * resources](https://cloud.google.com/blog/products/gcp/labelling-and-grouping-your-google-cloud-platform-resources)
     * for more information.
     * To search against the `labels`:
     * * use a field query:
     *     - query on any label's key or value. Example: `labels:prod`
     *     - query by a given label. Example: `labels.env:prod`
     *     - query by a given label's existence. Example: `labels.env:*`
     * * use a free text query. Example: `prod`
     *
     * Generated from protobuf field <code>map<string, string> labels = 7;</code>
     */
    private $labels;
    /**
     * Network tags associated with this resource. Like labels, network tags are a
     * type of annotations used to group GCP resources. See [Labelling GCP
     * resources](https://cloud.google.com/blog/products/gcp/labelling-and-grouping-your-google-cloud-platform-resources)
     * for more information.
     * To search against the `network_tags`:
     * * use a field query. Example: `networkTags:internal`
     * * use a free text query. Example: `internal`
     *
     * Generated from protobuf field <code>repeated string network_tags = 8;</code>
     */
    private $network_tags;
    /**
     * The additional searchable attributes of this resource. The attributes may
     * vary from one resource type to another. Examples: `projectId` for Project,
     * `dnsName` for DNS ManagedZone. This field contains a subset of the resource
     * metadata fields that are returned by the List or Get APIs provided by the
     * corresponding GCP service (e.g., Compute Engine). see [API references and
     * supported searchable
     * attributes](https://cloud.google.com/asset-inventory/docs/supported-asset-types#searchable_asset_types)
     * for more information.
     * You can search values of these fields through free text search. However,
     * you should not consume the field programically as the field names and
     * values may change as the GCP service updates to a new incompatible API
     * version.
     * To search against the `additional_attributes`:
     * * use a free text query to match the attributes values. Example: to search
     *   `additional_attributes = { dnsName: "foobar" }`, you can issue a query
     *   `foobar`.
     *
     * Generated from protobuf field <code>.google.protobuf.Struct additional_attributes = 9;</code>
     */
    protected $additional_attributes = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $name
     *           The full resource name of this resource. Example:
     *           `//compute.googleapis.com/projects/my_project_123/zones/zone1/instances/instance1`.
     *           See [Cloud Asset Inventory Resource Name
     *           Format](https://cloud.google.com/asset-inventory/docs/resource-name-format)
     *           for more information.
     *           To search against the `name`:
     *           * use a field query. Example: `name:instance1`
     *           * use a free text query. Example: `instance1`
     *     @type string $asset_type
     *           The type of this resource. Example: `compute.googleapis.com/Disk`.
     *           To search against the `asset_type`:
     *           * specify the `asset_type` field in your search request.
     *     @type string $project
     *           The project that this resource belongs to, in the form of
     *           projects/{PROJECT_NUMBER}.
     *           To search against the `project`:
     *           * specify the `scope` field as this project in your search request.
     *     @type string $display_name
     *           The display name of this resource.
     *           To search against the `display_name`:
     *           * use a field query. Example: `displayName:"My Instance"`
     *           * use a free text query. Example: `"My Instance"`
     *     @type string $description
     *           One or more paragraphs of text description of this resource. Maximum length
     *           could be up to 1M bytes.
     *           To search against the `description`:
     *           * use a field query. Example: `description:"*important instance*"`
     *           * use a free text query. Example: `"*important instance*"`
     *     @type string $location
     *           Location can be `global`, regional like `us-east1`, or zonal like
     *           `us-west1-b`.
     *           To search against the `location`:
     *           * use a field query. Example: `location:us-west*`
     *           * use a free text query. Example: `us-west*`
     *     @type array|\Google\Protobuf\Internal\MapField $labels
     *           Labels associated with this resource. See [Labelling and grouping GCP
     *           resources](https://cloud.google.com/blog/products/gcp/labelling-and-grouping-your-google-cloud-platform-resources)
     *           for more information.
     *           To search against the `labels`:
     *           * use a field query:
     *               - query on any label's key or value. Example: `labels:prod`
     *               - query by a given label. Example: `labels.env:prod`
     *               - query by a given label's existence. Example: `labels.env:*`
     *           * use a free text query. Example: `prod`
     *     @type string[]|\Google\Protobuf\Internal\RepeatedField $network_tags
     *           Network tags associated with this resource. Like labels, network tags are a
     *           type of annotations used to group GCP resources. See [Labelling GCP
     *           resources](https://cloud.google.com/blog/products/gcp/labelling-and-grouping-your-google-cloud-platform-resources)
     *           for more information.
     *           To search against the `network_tags`:
     *           * use a field query. Example: `networkTags:internal`
     *           * use a free text query. Example: `internal`
     *     @type \Google\Protobuf\Struct $additional_attributes
     *           The additional searchable attributes of this resource. The attributes may
     *           vary from one resource type to another. Examples: `projectId` for Project,
     *           `dnsName` for DNS ManagedZone. This field contains a subset of the resource
     *           metadata fields that are returned by the List or Get APIs provided by the
     *           corresponding GCP service (e.g., Compute Engine). see [API references and
     *           supported searchable
     *           attributes](https://cloud.google.com/asset-inventory/docs/supported-asset-types#searchable_asset_types)
     *           for more information.
     *           You can search values of these fields through free text search. However,
     *           you should not consume the field programically as the field names and
     *           values may change as the GCP service updates to a new incompatible API
     *           version.
     *           To search against the `additional_attributes`:
     *           * use a free text query to match the attributes values. Example: to search
     *             `additional_attributes = { dnsName: "foobar" }`, you can issue a query
     *             `foobar`.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Asset\V1\Assets::initOnce();
        parent::__construct($data);
    }

    /**
     * The full resource name of this resource. Example:
     * `//compute.googleapis.com/projects/my_project_123/zones/zone1/instances/instance1`.
     * See [Cloud Asset Inventory Resource Name
     * Format](https://cloud.google.com/asset-inventory/docs/resource-name-format)
     * for more information.
     * To search against the `name`:
     * * use a field query. Example: `name:instance1`
     * * use a free text query. Example: `instance1`
     *
     * Generated from protobuf field <code>string name = 1;</code>
     * @return string
     */
    public function getName()
    {
        return $this->name;
    }

    /**
     * The full resource name of this resource. Example:
     * `//compute.googleapis.com/projects/my_project_123/zones/zone1/instances/instance1`.
     * See [Cloud Asset Inventory Resource Name
     * Format](https://cloud.google.com/asset-inventory/docs/resource-name-format)
     * for more information.
     * To search against the `name`:
     * * use a field query. Example: `name:instance1`
     * * use a free text query. Example: `instance1`
     *
     * Generated from protobuf field <code>string name = 1;</code>
     * @param string $var
     * @return $this
     */
    public function setName($var)
    {
        GPBUtil::checkString($var, True);
        $this->name = $var;

        return $this;
    }

    /**
     * The type of this resource. Example: `compute.googleapis.com/Disk`.
     * To search against the `asset_type`:
     * * specify the `asset_type` field in your search request.
     *
     * Generated from protobuf field <code>string asset_type = 2;</code>
     * @return string
     */
    public function getAssetType()
    {
        return $this->asset_type;
    }

    /**
     * The type of this resource. Example: `compute.googleapis.com/Disk`.
     * To search against the `asset_type`:
     * * specify the `asset_type` field in your search request.
     *
     * Generated from protobuf field <code>string asset_type = 2;</code>
     * @param string $var
     * @return $this
     */
    public function setAssetType($var)
    {
        GPBUtil::checkString($var, True);
        $this->asset_type = $var;

        return $this;
    }

    /**
     * The project that this resource belongs to, in the form of
     * projects/{PROJECT_NUMBER}.
     * To search against the `project`:
     * * specify the `scope` field as this project in your search request.
     *
     * Generated from protobuf field <code>string project = 3;</code>
     * @return string
     */
    public function getProject()
    {
        return $this->project;
    }

    /**
     * The project that this resource belongs to, in the form of
     * projects/{PROJECT_NUMBER}.
     * To search against the `project`:
     * * specify the `scope` field as this project in your search request.
     *
     * Generated from protobuf field <code>string project = 3;</code>
     * @param string $var
     * @return $this
     */
    public function setProject($var)
    {
        GPBUtil::checkString($var, True);
        $this->project = $var;

        return $this;
    }

    /**
     * The display name of this resource.
     * To search against the `display_name`:
     * * use a field query. Example: `displayName:"My Instance"`
     * * use a free text query. Example: `"My Instance"`
     *
     * Generated from protobuf field <code>string display_name = 4;</code>
     * @return string
     */
    public function getDisplayName()
    {
        return $this->display_name;
    }

    /**
     * The display name of this resource.
     * To search against the `display_name`:
     * * use a field query. Example: `displayName:"My Instance"`
     * * use a free text query. Example: `"My Instance"`
     *
     * Generated from protobuf field <code>string display_name = 4;</code>
     * @param string $var
     * @return $this
     */
    public function setDisplayName($var)
    {
        GPBUtil::checkString($var, True);
        $this->display_name = $var;

        return $this;
    }

    /**
     * One or more paragraphs of text description of this resource. Maximum length
     * could be up to 1M bytes.
     * To search against the `description`:
     * * use a field query. Example: `description:"*important instance*"`
     * * use a free text query. Example: `"*important instance*"`
     *
     * Generated from protobuf field <code>string description = 5;</code>
     * @return string
     */
    public function getDescription()
    {
        return $this->description;
    }

    /**
     * One or more paragraphs of text description of this resource. Maximum length
     * could be up to 1M bytes.
     * To search against the `description`:
     * * use a field query. Example: `description:"*important instance*"`
     * * use a free text query. Example: `"*important instance*"`
     *
     * Generated from protobuf field <code>string description = 5;</code>
     * @param string $var
     * @return $this
     */
    public function setDescription($var)
    {
        GPBUtil::checkString($var, True);
        $this->description = $var;

        return $this;
    }

    /**
     * Location can be `global`, regional like `us-east1`, or zonal like
     * `us-west1-b`.
     * To search against the `location`:
     * * use a field query. Example: `location:us-west*`
     * * use a free text query. Example: `us-west*`
     *
     * Generated from protobuf field <code>string location = 6;</code>
     * @return string
     */
    public function getLocation()
    {
        return $this->location;
    }

    /**
     * Location can be `global`, regional like `us-east1`, or zonal like
     * `us-west1-b`.
     * To search against the `location`:
     * * use a field query. Example: `location:us-west*`
     * * use a free text query. Example: `us-west*`
     *
     * Generated from protobuf field <code>string location = 6;</code>
     * @param string $var
     * @return $this
     */
    public function setLocation($var)
    {
        GPBUtil::checkString($var, True);
        $this->location = $var;

        return $this;
    }

    /**
     * Labels associated with this resource. See [Labelling and grouping GCP
     * resources](https://cloud.google.com/blog/products/gcp/labelling-and-grouping-your-google-cloud-platform-resources)
     * for more information.
     * To search against the `labels`:
     * * use a field query:
     *     - query on any label's key or value. Example: `labels:prod`
     *     - query by a given label. Example: `labels.env:prod`
     *     - query by a given label's existence. Example: `labels.env:*`
     * * use a free text query. Example: `prod`
     *
     * Generated from protobuf field <code>map<string, string> labels = 7;</code>
     * @return \Google\Protobuf\Internal\MapField
     */
    public function getLabels()
    {
        return $this->labels;
    }

    /**
     * Labels associated with this resource. See [Labelling and grouping GCP
     * resources](https://cloud.google.com/blog/products/gcp/labelling-and-grouping-your-google-cloud-platform-resources)
     * for more information.
     * To search against the `labels`:
     * * use a field query:
     *     - query on any label's key or value. Example: `labels:prod`
     *     - query by a given label. Example: `labels.env:prod`
     *     - query by a given label's existence. Example: `labels.env:*`
     * * use a free text query. Example: `prod`
     *
     * Generated from protobuf field <code>map<string, string> labels = 7;</code>
     * @param array|\Google\Protobuf\Internal\MapField $var
     * @return $this
     */
    public function setLabels($var)
    {
        $arr = GPBUtil::checkMapField($var, \Google\Protobuf\Internal\GPBType::STRING, \Google\Protobuf\Internal\GPBType::STRING);
        $this->labels = $arr;

        return $this;
    }

    /**
     * Network tags associated with this resource. Like labels, network tags are a
     * type of annotations used to group GCP resources. See [Labelling GCP
     * resources](https://cloud.google.com/blog/products/gcp/labelling-and-grouping-your-google-cloud-platform-resources)
     * for more information.
     * To search against the `network_tags`:
     * * use a field query. Example: `networkTags:internal`
     * * use a free text query. Example: `internal`
     *
     * Generated from protobuf field <code>repeated string network_tags = 8;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getNetworkTags()
    {
        return $this->network_tags;
    }

    /**
     * Network tags associated with this resource. Like labels, network tags are a
     * type of annotations used to group GCP resources. See [Labelling GCP
     * resources](https://cloud.google.com/blog/products/gcp/labelling-and-grouping-your-google-cloud-platform-resources)
     * for more information.
     * To search against the `network_tags`:
     * * use a field query. Example: `networkTags:internal`
     * * use a free text query. Example: `internal`
     *
     * Generated from protobuf field <code>repeated string network_tags = 8;</code>
     * @param string[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setNetworkTags($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::STRING);
        $this->network_tags = $arr;

        return $this;
    }

    /**
     * The additional searchable attributes of this resource. The attributes may
     * vary from one resource type to another. Examples: `projectId` for Project,
     * `dnsName` for DNS ManagedZone. This field contains a subset of the resource
     * metadata fields that are returned by the List or Get APIs provided by the
     * corresponding GCP service (e.g., Compute Engine). see [API references and
     * supported searchable
     * attributes](https://cloud.google.com/asset-inventory/docs/supported-asset-types#searchable_asset_types)
     * for more information.
     * You can search values of these fields through free text search. However,
     * you should not consume the field programically as the field names and
     * values may change as the GCP service updates to a new incompatible API
     * version.
     * To search against the `additional_attributes`:
     * * use a free text query to match the attributes values. Example: to search
     *   `additional_attributes = { dnsName: "foobar" }`, you can issue a query
     *   `foobar`.
     *
     * Generated from protobuf field <code>.google.protobuf.Struct additional_attributes = 9;</code>
     * @return \Google\Protobuf\Struct|null
     */
    public function getAdditionalAttributes()
    {
        return isset($this->additional_attributes) ? $this->additional_attributes : null;
    }

    public function hasAdditionalAttributes()
    {
        return isset($this->additional_attributes);
    }

    public function clearAdditionalAttributes()
    {
        unset($this->additional_attributes);
    }

    /**
     * The additional searchable attributes of this resource. The attributes may
     * vary from one resource type to another. Examples: `projectId` for Project,
     * `dnsName` for DNS ManagedZone. This field contains a subset of the resource
     * metadata fields that are returned by the List or Get APIs provided by the
     * corresponding GCP service (e.g., Compute Engine). see [API references and
     * supported searchable
     * attributes](https://cloud.google.com/asset-inventory/docs/supported-asset-types#searchable_asset_types)
     * for more information.
     * You can search values of these fields through free text search. However,
     * you should not consume the field programically as the field names and
     * values may change as the GCP service updates to a new incompatible API
     * version.
     * To search against the `additional_attributes`:
     * * use a free text query to match the attributes values. Example: to search
     *   `additional_attributes = { dnsName: "foobar" }`, you can issue a query
     *   `foobar`.
     *
     * Generated from protobuf field <code>.google.protobuf.Struct additional_attributes = 9;</code>
     * @param \Google\Protobuf\Struct $var
     * @return $this
     */
    public function setAdditionalAttributes($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Struct::class);
        $this->additional_attributes = $var;

        return $this;
    }

}

