<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/partner/aistreams/v1alpha1/aistreams.proto

namespace Google\Cloud\Partner\Aistreams\V1alpha1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Request message for 'ListClusters'.
 *
 * Generated from protobuf message <code>google.partner.aistreams.v1alpha1.ListClustersRequest</code>
 */
class ListClustersRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The parent that owns the collection of Clusters.
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     */
    protected $parent = '';
    /**
     * Maximum number of Clusters to return.
     *
     * Generated from protobuf field <code>int32 page_size = 2;</code>
     */
    protected $page_size = 0;
    /**
     * Page token received from a previous `ListClusters` call. Provide this to
     * retrieve the subsequent page. When paginating, all other parameters
     * provided to `ListClusters` must match the call that provided the page
     * token.
     *
     * Generated from protobuf field <code>string page_token = 3;</code>
     */
    protected $page_token = '';
    /**
     * Filter request.
     *
     * Generated from protobuf field <code>string filter = 4;</code>
     */
    protected $filter = '';
    /**
     * Order by fields for the result.
     *
     * Generated from protobuf field <code>string order_by = 5;</code>
     */
    protected $order_by = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $parent
     *           Required. The parent that owns the collection of Clusters.
     *     @type int $page_size
     *           Maximum number of Clusters to return.
     *     @type string $page_token
     *           Page token received from a previous `ListClusters` call. Provide this to
     *           retrieve the subsequent page. When paginating, all other parameters
     *           provided to `ListClusters` must match the call that provided the page
     *           token.
     *     @type string $filter
     *           Filter request.
     *     @type string $order_by
     *           Order by fields for the result.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Partner\Aistreams\V1Alpha1\Aistreams::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The parent that owns the collection of Clusters.
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getParent()
    {
        return $this->parent;
    }

    /**
     * Required. The parent that owns the collection of Clusters.
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
     * Maximum number of Clusters to return.
     *
     * Generated from protobuf field <code>int32 page_size = 2;</code>
     * @return int
     */
    public function getPageSize()
    {
        return $this->page_size;
    }

    /**
     * Maximum number of Clusters to return.
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
     * Page token received from a previous `ListClusters` call. Provide this to
     * retrieve the subsequent page. When paginating, all other parameters
     * provided to `ListClusters` must match the call that provided the page
     * token.
     *
     * Generated from protobuf field <code>string page_token = 3;</code>
     * @return string
     */
    public function getPageToken()
    {
        return $this->page_token;
    }

    /**
     * Page token received from a previous `ListClusters` call. Provide this to
     * retrieve the subsequent page. When paginating, all other parameters
     * provided to `ListClusters` must match the call that provided the page
     * token.
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
     * Filter request.
     *
     * Generated from protobuf field <code>string filter = 4;</code>
     * @return string
     */
    public function getFilter()
    {
        return $this->filter;
    }

    /**
     * Filter request.
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

    /**
     * Order by fields for the result.
     *
     * Generated from protobuf field <code>string order_by = 5;</code>
     * @return string
     */
    public function getOrderBy()
    {
        return $this->order_by;
    }

    /**
     * Order by fields for the result.
     *
     * Generated from protobuf field <code>string order_by = 5;</code>
     * @param string $var
     * @return $this
     */
    public function setOrderBy($var)
    {
        GPBUtil::checkString($var, True);
        $this->order_by = $var;

        return $this;
    }

}

