<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/asset/v1p2beta1/asset_service.proto

namespace Google\Cloud\Asset\V1p2Beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * An asset feed used to export asset updates to a destinations.
 * An asset feed filter controls what updates are exported.
 * The asset feed must be created within a project, organization, or
 * folder. Supported destinations are:
 * Cloud Pub/Sub topics.
 *
 * Generated from protobuf message <code>google.cloud.asset.v1p2beta1.Feed</code>
 */
class Feed extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The format will be
     * projects/{project_number}/feeds/{client-assigned_feed_identifier} or
     * folders/{folder_number}/feeds/{client-assigned_feed_identifier} or
     * organizations/{organization_number}/feeds/{client-assigned_feed_identifier}
     * The client-assigned feed identifier must be unique within the parent
     * project/folder/organization.
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $name = '';
    /**
     * A list of the full names of the assets to receive updates. You must specify
     * either or both of asset_names and asset_types. Only asset updates matching
     * specified asset_names and asset_types are exported to the feed. For
     * example:
     * `//compute.googleapis.com/projects/my_project_123/zones/zone1/instances/instance1`.
     * See [Resource
     * Names](https://cloud.google.com/apis/design/resource_names#full_resource_name)
     * for more info.
     *
     * Generated from protobuf field <code>repeated string asset_names = 2;</code>
     */
    private $asset_names;
    /**
     * A list of types of the assets to receive updates. You must specify either
     * or both of asset_names and asset_types. Only asset updates matching
     * specified asset_names and asset_types are exported to the feed.
     * For example:
     * "compute.googleapis.com/Disk" See [Introduction to Cloud Asset
     * Inventory](https://cloud.google.com/resource-manager/docs/cloud-asset-inventory/overview)
     * for all supported asset types.
     *
     * Generated from protobuf field <code>repeated string asset_types = 3;</code>
     */
    private $asset_types;
    /**
     * Asset content type. If not specified, no content but the asset name and
     * type will be returned.
     *
     * Generated from protobuf field <code>.google.cloud.asset.v1p2beta1.ContentType content_type = 4;</code>
     */
    protected $content_type = 0;
    /**
     * Required. Feed output configuration defining where the asset updates are
     * published to.
     *
     * Generated from protobuf field <code>.google.cloud.asset.v1p2beta1.FeedOutputConfig feed_output_config = 5 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $feed_output_config = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $name
     *           Required. The format will be
     *           projects/{project_number}/feeds/{client-assigned_feed_identifier} or
     *           folders/{folder_number}/feeds/{client-assigned_feed_identifier} or
     *           organizations/{organization_number}/feeds/{client-assigned_feed_identifier}
     *           The client-assigned feed identifier must be unique within the parent
     *           project/folder/organization.
     *     @type string[]|\Google\Protobuf\Internal\RepeatedField $asset_names
     *           A list of the full names of the assets to receive updates. You must specify
     *           either or both of asset_names and asset_types. Only asset updates matching
     *           specified asset_names and asset_types are exported to the feed. For
     *           example:
     *           `//compute.googleapis.com/projects/my_project_123/zones/zone1/instances/instance1`.
     *           See [Resource
     *           Names](https://cloud.google.com/apis/design/resource_names#full_resource_name)
     *           for more info.
     *     @type string[]|\Google\Protobuf\Internal\RepeatedField $asset_types
     *           A list of types of the assets to receive updates. You must specify either
     *           or both of asset_names and asset_types. Only asset updates matching
     *           specified asset_names and asset_types are exported to the feed.
     *           For example:
     *           "compute.googleapis.com/Disk" See [Introduction to Cloud Asset
     *           Inventory](https://cloud.google.com/resource-manager/docs/cloud-asset-inventory/overview)
     *           for all supported asset types.
     *     @type int $content_type
     *           Asset content type. If not specified, no content but the asset name and
     *           type will be returned.
     *     @type \Google\Cloud\Asset\V1p2Beta1\FeedOutputConfig $feed_output_config
     *           Required. Feed output configuration defining where the asset updates are
     *           published to.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Asset\V1P2Beta1\AssetService::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The format will be
     * projects/{project_number}/feeds/{client-assigned_feed_identifier} or
     * folders/{folder_number}/feeds/{client-assigned_feed_identifier} or
     * organizations/{organization_number}/feeds/{client-assigned_feed_identifier}
     * The client-assigned feed identifier must be unique within the parent
     * project/folder/organization.
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return string
     */
    public function getName()
    {
        return $this->name;
    }

    /**
     * Required. The format will be
     * projects/{project_number}/feeds/{client-assigned_feed_identifier} or
     * folders/{folder_number}/feeds/{client-assigned_feed_identifier} or
     * organizations/{organization_number}/feeds/{client-assigned_feed_identifier}
     * The client-assigned feed identifier must be unique within the parent
     * project/folder/organization.
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = REQUIRED];</code>
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
     * A list of the full names of the assets to receive updates. You must specify
     * either or both of asset_names and asset_types. Only asset updates matching
     * specified asset_names and asset_types are exported to the feed. For
     * example:
     * `//compute.googleapis.com/projects/my_project_123/zones/zone1/instances/instance1`.
     * See [Resource
     * Names](https://cloud.google.com/apis/design/resource_names#full_resource_name)
     * for more info.
     *
     * Generated from protobuf field <code>repeated string asset_names = 2;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getAssetNames()
    {
        return $this->asset_names;
    }

    /**
     * A list of the full names of the assets to receive updates. You must specify
     * either or both of asset_names and asset_types. Only asset updates matching
     * specified asset_names and asset_types are exported to the feed. For
     * example:
     * `//compute.googleapis.com/projects/my_project_123/zones/zone1/instances/instance1`.
     * See [Resource
     * Names](https://cloud.google.com/apis/design/resource_names#full_resource_name)
     * for more info.
     *
     * Generated from protobuf field <code>repeated string asset_names = 2;</code>
     * @param string[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setAssetNames($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::STRING);
        $this->asset_names = $arr;

        return $this;
    }

    /**
     * A list of types of the assets to receive updates. You must specify either
     * or both of asset_names and asset_types. Only asset updates matching
     * specified asset_names and asset_types are exported to the feed.
     * For example:
     * "compute.googleapis.com/Disk" See [Introduction to Cloud Asset
     * Inventory](https://cloud.google.com/resource-manager/docs/cloud-asset-inventory/overview)
     * for all supported asset types.
     *
     * Generated from protobuf field <code>repeated string asset_types = 3;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getAssetTypes()
    {
        return $this->asset_types;
    }

    /**
     * A list of types of the assets to receive updates. You must specify either
     * or both of asset_names and asset_types. Only asset updates matching
     * specified asset_names and asset_types are exported to the feed.
     * For example:
     * "compute.googleapis.com/Disk" See [Introduction to Cloud Asset
     * Inventory](https://cloud.google.com/resource-manager/docs/cloud-asset-inventory/overview)
     * for all supported asset types.
     *
     * Generated from protobuf field <code>repeated string asset_types = 3;</code>
     * @param string[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setAssetTypes($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::STRING);
        $this->asset_types = $arr;

        return $this;
    }

    /**
     * Asset content type. If not specified, no content but the asset name and
     * type will be returned.
     *
     * Generated from protobuf field <code>.google.cloud.asset.v1p2beta1.ContentType content_type = 4;</code>
     * @return int
     */
    public function getContentType()
    {
        return $this->content_type;
    }

    /**
     * Asset content type. If not specified, no content but the asset name and
     * type will be returned.
     *
     * Generated from protobuf field <code>.google.cloud.asset.v1p2beta1.ContentType content_type = 4;</code>
     * @param int $var
     * @return $this
     */
    public function setContentType($var)
    {
        GPBUtil::checkEnum($var, \Google\Cloud\Asset\V1p2Beta1\ContentType::class);
        $this->content_type = $var;

        return $this;
    }

    /**
     * Required. Feed output configuration defining where the asset updates are
     * published to.
     *
     * Generated from protobuf field <code>.google.cloud.asset.v1p2beta1.FeedOutputConfig feed_output_config = 5 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Cloud\Asset\V1p2Beta1\FeedOutputConfig|null
     */
    public function getFeedOutputConfig()
    {
        return isset($this->feed_output_config) ? $this->feed_output_config : null;
    }

    public function hasFeedOutputConfig()
    {
        return isset($this->feed_output_config);
    }

    public function clearFeedOutputConfig()
    {
        unset($this->feed_output_config);
    }

    /**
     * Required. Feed output configuration defining where the asset updates are
     * published to.
     *
     * Generated from protobuf field <code>.google.cloud.asset.v1p2beta1.FeedOutputConfig feed_output_config = 5 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param \Google\Cloud\Asset\V1p2Beta1\FeedOutputConfig $var
     * @return $this
     */
    public function setFeedOutputConfig($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Asset\V1p2Beta1\FeedOutputConfig::class);
        $this->feed_output_config = $var;

        return $this;
    }

}

