<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/securitycenter/v1p1beta1/securitycenter_service.proto

namespace Google\Cloud\SecurityCenter\V1p1beta1\ListAssetsResponse;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Result containing the Asset and its State.
 *
 * Generated from protobuf message <code>google.cloud.securitycenter.v1p1beta1.ListAssetsResponse.ListAssetsResult</code>
 */
class ListAssetsResult extends \Google\Protobuf\Internal\Message
{
    /**
     * Asset matching the search request.
     *
     * Generated from protobuf field <code>.google.cloud.securitycenter.v1p1beta1.Asset asset = 1;</code>
     */
    protected $asset = null;
    /**
     * State change of the asset between the points in time.
     *
     * Generated from protobuf field <code>.google.cloud.securitycenter.v1p1beta1.ListAssetsResponse.ListAssetsResult.StateChange state_change = 2;</code>
     */
    protected $state_change = 0;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Cloud\SecurityCenter\V1p1beta1\Asset $asset
     *           Asset matching the search request.
     *     @type int $state_change
     *           State change of the asset between the points in time.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Securitycenter\V1P1Beta1\SecuritycenterService::initOnce();
        parent::__construct($data);
    }

    /**
     * Asset matching the search request.
     *
     * Generated from protobuf field <code>.google.cloud.securitycenter.v1p1beta1.Asset asset = 1;</code>
     * @return \Google\Cloud\SecurityCenter\V1p1beta1\Asset|null
     */
    public function getAsset()
    {
        return isset($this->asset) ? $this->asset : null;
    }

    public function hasAsset()
    {
        return isset($this->asset);
    }

    public function clearAsset()
    {
        unset($this->asset);
    }

    /**
     * Asset matching the search request.
     *
     * Generated from protobuf field <code>.google.cloud.securitycenter.v1p1beta1.Asset asset = 1;</code>
     * @param \Google\Cloud\SecurityCenter\V1p1beta1\Asset $var
     * @return $this
     */
    public function setAsset($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\SecurityCenter\V1p1beta1\Asset::class);
        $this->asset = $var;

        return $this;
    }

    /**
     * State change of the asset between the points in time.
     *
     * Generated from protobuf field <code>.google.cloud.securitycenter.v1p1beta1.ListAssetsResponse.ListAssetsResult.StateChange state_change = 2;</code>
     * @return int
     */
    public function getStateChange()
    {
        return $this->state_change;
    }

    /**
     * State change of the asset between the points in time.
     *
     * Generated from protobuf field <code>.google.cloud.securitycenter.v1p1beta1.ListAssetsResponse.ListAssetsResult.StateChange state_change = 2;</code>
     * @param int $var
     * @return $this
     */
    public function setStateChange($var)
    {
        GPBUtil::checkEnum($var, \Google\Cloud\SecurityCenter\V1p1beta1\ListAssetsResponse\ListAssetsResult\StateChange::class);
        $this->state_change = $var;

        return $this;
    }

}

// Adding a class alias for backwards compatibility with the previous class name.
class_alias(ListAssetsResult::class, \Google\Cloud\SecurityCenter\V1p1beta1\ListAssetsResponse_ListAssetsResult::class);

