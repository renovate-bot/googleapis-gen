<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/retail/v2/user_event.proto

namespace Google\Cloud\Retail\V2;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Detailed product information associated with a user event.
 *
 * Generated from protobuf message <code>google.cloud.retail.v2.ProductDetail</code>
 */
class ProductDetail extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. [Product][google.cloud.retail.v2.Product] information.
     * Only [Product.id][google.cloud.retail.v2.Product.id] field is used when
     * ingesting an event, all other product fields are ignored as we will look
     * them up from the catalog.
     *
     * Generated from protobuf field <code>.google.cloud.retail.v2.Product product = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $product = null;
    /**
     * Quantity of the product associated with the user event.
     * For example, this field will be 2 if two products are added to the shopping
     * cart for `purchase-complete` event. Required for `add-to-cart` and
     * `purchase-complete` event types.
     *
     * Generated from protobuf field <code>.google.protobuf.Int32Value quantity = 2;</code>
     */
    protected $quantity = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Cloud\Retail\V2\Product $product
     *           Required. [Product][google.cloud.retail.v2.Product] information.
     *           Only [Product.id][google.cloud.retail.v2.Product.id] field is used when
     *           ingesting an event, all other product fields are ignored as we will look
     *           them up from the catalog.
     *     @type \Google\Protobuf\Int32Value $quantity
     *           Quantity of the product associated with the user event.
     *           For example, this field will be 2 if two products are added to the shopping
     *           cart for `purchase-complete` event. Required for `add-to-cart` and
     *           `purchase-complete` event types.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Retail\V2\UserEvent::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. [Product][google.cloud.retail.v2.Product] information.
     * Only [Product.id][google.cloud.retail.v2.Product.id] field is used when
     * ingesting an event, all other product fields are ignored as we will look
     * them up from the catalog.
     *
     * Generated from protobuf field <code>.google.cloud.retail.v2.Product product = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Cloud\Retail\V2\Product|null
     */
    public function getProduct()
    {
        return isset($this->product) ? $this->product : null;
    }

    public function hasProduct()
    {
        return isset($this->product);
    }

    public function clearProduct()
    {
        unset($this->product);
    }

    /**
     * Required. [Product][google.cloud.retail.v2.Product] information.
     * Only [Product.id][google.cloud.retail.v2.Product.id] field is used when
     * ingesting an event, all other product fields are ignored as we will look
     * them up from the catalog.
     *
     * Generated from protobuf field <code>.google.cloud.retail.v2.Product product = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param \Google\Cloud\Retail\V2\Product $var
     * @return $this
     */
    public function setProduct($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Retail\V2\Product::class);
        $this->product = $var;

        return $this;
    }

    /**
     * Quantity of the product associated with the user event.
     * For example, this field will be 2 if two products are added to the shopping
     * cart for `purchase-complete` event. Required for `add-to-cart` and
     * `purchase-complete` event types.
     *
     * Generated from protobuf field <code>.google.protobuf.Int32Value quantity = 2;</code>
     * @return \Google\Protobuf\Int32Value|null
     */
    public function getQuantity()
    {
        return isset($this->quantity) ? $this->quantity : null;
    }

    public function hasQuantity()
    {
        return isset($this->quantity);
    }

    public function clearQuantity()
    {
        unset($this->quantity);
    }

    /**
     * Returns the unboxed value from <code>getQuantity()</code>

     * Quantity of the product associated with the user event.
     * For example, this field will be 2 if two products are added to the shopping
     * cart for `purchase-complete` event. Required for `add-to-cart` and
     * `purchase-complete` event types.
     *
     * Generated from protobuf field <code>.google.protobuf.Int32Value quantity = 2;</code>
     * @return int|null
     */
    public function getQuantityUnwrapped()
    {
        return $this->readWrapperValue("quantity");
    }

    /**
     * Quantity of the product associated with the user event.
     * For example, this field will be 2 if two products are added to the shopping
     * cart for `purchase-complete` event. Required for `add-to-cart` and
     * `purchase-complete` event types.
     *
     * Generated from protobuf field <code>.google.protobuf.Int32Value quantity = 2;</code>
     * @param \Google\Protobuf\Int32Value $var
     * @return $this
     */
    public function setQuantity($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Int32Value::class);
        $this->quantity = $var;

        return $this;
    }

    /**
     * Sets the field by wrapping a primitive type in a Google\Protobuf\Int32Value object.

     * Quantity of the product associated with the user event.
     * For example, this field will be 2 if two products are added to the shopping
     * cart for `purchase-complete` event. Required for `add-to-cart` and
     * `purchase-complete` event types.
     *
     * Generated from protobuf field <code>.google.protobuf.Int32Value quantity = 2;</code>
     * @param int|null $var
     * @return $this
     */
    public function setQuantityUnwrapped($var)
    {
        $this->writeWrapperValue("quantity", $var);
        return $this;}

}

