<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/retail/v2alpha/product_service.proto

namespace Google\Cloud\Retail\V2alpha;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Response message for
 * [ProductService.ListProducts][google.cloud.retail.v2alpha.ProductService.ListProducts]
 * method.
 *
 * Generated from protobuf message <code>google.cloud.retail.v2alpha.ListProductsResponse</code>
 */
class ListProductsResponse extends \Google\Protobuf\Internal\Message
{
    /**
     * The [Product][google.cloud.retail.v2alpha.Product]s.
     *
     * Generated from protobuf field <code>repeated .google.cloud.retail.v2alpha.Product products = 1;</code>
     */
    private $products;
    /**
     * A token that can be sent as
     * [ListProductsRequest.page_token][google.cloud.retail.v2alpha.ListProductsRequest.page_token]
     * to retrieve the next page. If this field is omitted, there are no
     * subsequent pages.
     *
     * Generated from protobuf field <code>string next_page_token = 2;</code>
     */
    protected $next_page_token = '';
    /**
     * The total count of matched [Product][google.cloud.retail.v2alpha.Product]s
     * irrespective of pagination. The total number of
     * [Product][google.cloud.retail.v2alpha.Product]s returned by pagination may
     * be less than the
     * [total_size][google.cloud.retail.v2alpha.ListProductsResponse.total_size]
     * that matches.
     * This field is ignored if
     * [ListProductsRequest.require_total_size][google.cloud.retail.v2alpha.ListProductsRequest.require_total_size]
     * is not set or
     * [ListProductsRequest.page_token][google.cloud.retail.v2alpha.ListProductsRequest.page_token]
     * is not empty.
     *
     * Generated from protobuf field <code>int32 total_size = 3;</code>
     */
    protected $total_size = 0;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Cloud\Retail\V2alpha\Product[]|\Google\Protobuf\Internal\RepeatedField $products
     *           The [Product][google.cloud.retail.v2alpha.Product]s.
     *     @type string $next_page_token
     *           A token that can be sent as
     *           [ListProductsRequest.page_token][google.cloud.retail.v2alpha.ListProductsRequest.page_token]
     *           to retrieve the next page. If this field is omitted, there are no
     *           subsequent pages.
     *     @type int $total_size
     *           The total count of matched [Product][google.cloud.retail.v2alpha.Product]s
     *           irrespective of pagination. The total number of
     *           [Product][google.cloud.retail.v2alpha.Product]s returned by pagination may
     *           be less than the
     *           [total_size][google.cloud.retail.v2alpha.ListProductsResponse.total_size]
     *           that matches.
     *           This field is ignored if
     *           [ListProductsRequest.require_total_size][google.cloud.retail.v2alpha.ListProductsRequest.require_total_size]
     *           is not set or
     *           [ListProductsRequest.page_token][google.cloud.retail.v2alpha.ListProductsRequest.page_token]
     *           is not empty.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Retail\V2Alpha\ProductService::initOnce();
        parent::__construct($data);
    }

    /**
     * The [Product][google.cloud.retail.v2alpha.Product]s.
     *
     * Generated from protobuf field <code>repeated .google.cloud.retail.v2alpha.Product products = 1;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getProducts()
    {
        return $this->products;
    }

    /**
     * The [Product][google.cloud.retail.v2alpha.Product]s.
     *
     * Generated from protobuf field <code>repeated .google.cloud.retail.v2alpha.Product products = 1;</code>
     * @param \Google\Cloud\Retail\V2alpha\Product[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setProducts($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::MESSAGE, \Google\Cloud\Retail\V2alpha\Product::class);
        $this->products = $arr;

        return $this;
    }

    /**
     * A token that can be sent as
     * [ListProductsRequest.page_token][google.cloud.retail.v2alpha.ListProductsRequest.page_token]
     * to retrieve the next page. If this field is omitted, there are no
     * subsequent pages.
     *
     * Generated from protobuf field <code>string next_page_token = 2;</code>
     * @return string
     */
    public function getNextPageToken()
    {
        return $this->next_page_token;
    }

    /**
     * A token that can be sent as
     * [ListProductsRequest.page_token][google.cloud.retail.v2alpha.ListProductsRequest.page_token]
     * to retrieve the next page. If this field is omitted, there are no
     * subsequent pages.
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

    /**
     * The total count of matched [Product][google.cloud.retail.v2alpha.Product]s
     * irrespective of pagination. The total number of
     * [Product][google.cloud.retail.v2alpha.Product]s returned by pagination may
     * be less than the
     * [total_size][google.cloud.retail.v2alpha.ListProductsResponse.total_size]
     * that matches.
     * This field is ignored if
     * [ListProductsRequest.require_total_size][google.cloud.retail.v2alpha.ListProductsRequest.require_total_size]
     * is not set or
     * [ListProductsRequest.page_token][google.cloud.retail.v2alpha.ListProductsRequest.page_token]
     * is not empty.
     *
     * Generated from protobuf field <code>int32 total_size = 3;</code>
     * @return int
     */
    public function getTotalSize()
    {
        return $this->total_size;
    }

    /**
     * The total count of matched [Product][google.cloud.retail.v2alpha.Product]s
     * irrespective of pagination. The total number of
     * [Product][google.cloud.retail.v2alpha.Product]s returned by pagination may
     * be less than the
     * [total_size][google.cloud.retail.v2alpha.ListProductsResponse.total_size]
     * that matches.
     * This field is ignored if
     * [ListProductsRequest.require_total_size][google.cloud.retail.v2alpha.ListProductsRequest.require_total_size]
     * is not set or
     * [ListProductsRequest.page_token][google.cloud.retail.v2alpha.ListProductsRequest.page_token]
     * is not empty.
     *
     * Generated from protobuf field <code>int32 total_size = 3;</code>
     * @param int $var
     * @return $this
     */
    public function setTotalSize($var)
    {
        GPBUtil::checkInt32($var);
        $this->total_size = $var;

        return $this;
    }

}

