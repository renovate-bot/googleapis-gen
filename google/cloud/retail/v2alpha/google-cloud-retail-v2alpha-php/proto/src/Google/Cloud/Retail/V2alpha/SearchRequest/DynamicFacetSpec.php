<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/retail/v2alpha/search_service.proto

namespace Google\Cloud\Retail\V2alpha\SearchRequest;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * The specifications of dynamically generated facets.
 *
 * Generated from protobuf message <code>google.cloud.retail.v2alpha.SearchRequest.DynamicFacetSpec</code>
 */
class DynamicFacetSpec extends \Google\Protobuf\Internal\Message
{
    /**
     * Mode of the DynamicFacet feature.
     * Defaults to
     * [Mode.DISABLED][google.cloud.retail.v2alpha.SearchRequest.DynamicFacetSpec.Mode.DISABLED]
     * if it's unset.
     *
     * Generated from protobuf field <code>.google.cloud.retail.v2alpha.SearchRequest.DynamicFacetSpec.Mode mode = 1;</code>
     */
    protected $mode = 0;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type int $mode
     *           Mode of the DynamicFacet feature.
     *           Defaults to
     *           [Mode.DISABLED][google.cloud.retail.v2alpha.SearchRequest.DynamicFacetSpec.Mode.DISABLED]
     *           if it's unset.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Retail\V2Alpha\SearchService::initOnce();
        parent::__construct($data);
    }

    /**
     * Mode of the DynamicFacet feature.
     * Defaults to
     * [Mode.DISABLED][google.cloud.retail.v2alpha.SearchRequest.DynamicFacetSpec.Mode.DISABLED]
     * if it's unset.
     *
     * Generated from protobuf field <code>.google.cloud.retail.v2alpha.SearchRequest.DynamicFacetSpec.Mode mode = 1;</code>
     * @return int
     */
    public function getMode()
    {
        return $this->mode;
    }

    /**
     * Mode of the DynamicFacet feature.
     * Defaults to
     * [Mode.DISABLED][google.cloud.retail.v2alpha.SearchRequest.DynamicFacetSpec.Mode.DISABLED]
     * if it's unset.
     *
     * Generated from protobuf field <code>.google.cloud.retail.v2alpha.SearchRequest.DynamicFacetSpec.Mode mode = 1;</code>
     * @param int $var
     * @return $this
     */
    public function setMode($var)
    {
        GPBUtil::checkEnum($var, \Google\Cloud\Retail\V2alpha\SearchRequest\DynamicFacetSpec\Mode::class);
        $this->mode = $var;

        return $this;
    }

}

// Adding a class alias for backwards compatibility with the previous class name.
class_alias(DynamicFacetSpec::class, \Google\Cloud\Retail\V2alpha\SearchRequest_DynamicFacetSpec::class);

