<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/recommendationengine/v1beta1/user_event.proto

namespace Google\Cloud\RecommendationEngine\V1beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * UserEvent captures all metadata information recommendation engine needs to
 * know about how end users interact with customers' website.
 *
 * Generated from protobuf message <code>google.cloud.recommendationengine.v1beta1.UserEvent</code>
 */
class UserEvent extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. User event type. Allowed values are:
     * * `add-to-cart` Products being added to cart.
     * * `add-to-list` Items being added to a list (shopping list, favorites
     *   etc).
     * * `category-page-view` Special pages such as sale or promotion pages
     *   viewed.
     * * `checkout-start` User starting a checkout process.
     * * `detail-page-view` Products detail page viewed.
     * * `home-page-view` Homepage viewed.
     * * `page-visit` Generic page visits not included in the event types above.
     * * `purchase-complete` User finishing a purchase.
     * * `refund` Purchased items being refunded or returned.
     * * `remove-from-cart` Products being removed from cart.
     * * `remove-from-list` Items being removed from a list.
     * * `search` Product search.
     * * `shopping-cart-page-view` User viewing a shopping cart.
     * * `impression` List of items displayed. Used by Google Tag Manager.
     *
     * Generated from protobuf field <code>string event_type = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $event_type = '';
    /**
     * Required. User information.
     *
     * Generated from protobuf field <code>.google.cloud.recommendationengine.v1beta1.UserInfo user_info = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $user_info = null;
    /**
     * Optional. User event detailed information common across different
     * recommendation types.
     *
     * Generated from protobuf field <code>.google.cloud.recommendationengine.v1beta1.EventDetail event_detail = 3 [(.google.api.field_behavior) = OPTIONAL];</code>
     */
    protected $event_detail = null;
    /**
     * Optional. Retail product specific user event metadata.
     * This field is required for the following event types:
     * * `add-to-cart`
     * * `add-to-list`
     * * `category-page-view`
     * * `checkout-start`
     * * `detail-page-view`
     * * `purchase-complete`
     * * `refund`
     * * `remove-from-cart`
     * * `remove-from-list`
     * * `search`
     * This field is optional for the following event types:
     * * `page-visit`
     * * `shopping-cart-page-view` - note that 'product_event_detail' should be
     *   set for this unless the shopping cart is empty.
     * This field is not allowed for the following event types:
     * * `home-page-view`
     *
     * Generated from protobuf field <code>.google.cloud.recommendationengine.v1beta1.ProductEventDetail product_event_detail = 4 [(.google.api.field_behavior) = OPTIONAL];</code>
     */
    protected $product_event_detail = null;
    /**
     * Optional. Only required for ImportUserEvents method. Timestamp of user
     * event created.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp event_time = 5 [(.google.api.field_behavior) = OPTIONAL];</code>
     */
    protected $event_time = null;
    /**
     * Optional. This field should *not* be set when using JavaScript pixel
     * or the Recommendations AI Tag. Defaults to `EVENT_SOURCE_UNSPECIFIED`.
     *
     * Generated from protobuf field <code>.google.cloud.recommendationengine.v1beta1.UserEvent.EventSource event_source = 6 [(.google.api.field_behavior) = OPTIONAL];</code>
     */
    protected $event_source = 0;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $event_type
     *           Required. User event type. Allowed values are:
     *           * `add-to-cart` Products being added to cart.
     *           * `add-to-list` Items being added to a list (shopping list, favorites
     *             etc).
     *           * `category-page-view` Special pages such as sale or promotion pages
     *             viewed.
     *           * `checkout-start` User starting a checkout process.
     *           * `detail-page-view` Products detail page viewed.
     *           * `home-page-view` Homepage viewed.
     *           * `page-visit` Generic page visits not included in the event types above.
     *           * `purchase-complete` User finishing a purchase.
     *           * `refund` Purchased items being refunded or returned.
     *           * `remove-from-cart` Products being removed from cart.
     *           * `remove-from-list` Items being removed from a list.
     *           * `search` Product search.
     *           * `shopping-cart-page-view` User viewing a shopping cart.
     *           * `impression` List of items displayed. Used by Google Tag Manager.
     *     @type \Google\Cloud\RecommendationEngine\V1beta1\UserInfo $user_info
     *           Required. User information.
     *     @type \Google\Cloud\RecommendationEngine\V1beta1\EventDetail $event_detail
     *           Optional. User event detailed information common across different
     *           recommendation types.
     *     @type \Google\Cloud\RecommendationEngine\V1beta1\ProductEventDetail $product_event_detail
     *           Optional. Retail product specific user event metadata.
     *           This field is required for the following event types:
     *           * `add-to-cart`
     *           * `add-to-list`
     *           * `category-page-view`
     *           * `checkout-start`
     *           * `detail-page-view`
     *           * `purchase-complete`
     *           * `refund`
     *           * `remove-from-cart`
     *           * `remove-from-list`
     *           * `search`
     *           This field is optional for the following event types:
     *           * `page-visit`
     *           * `shopping-cart-page-view` - note that 'product_event_detail' should be
     *             set for this unless the shopping cart is empty.
     *           This field is not allowed for the following event types:
     *           * `home-page-view`
     *     @type \Google\Protobuf\Timestamp $event_time
     *           Optional. Only required for ImportUserEvents method. Timestamp of user
     *           event created.
     *     @type int $event_source
     *           Optional. This field should *not* be set when using JavaScript pixel
     *           or the Recommendations AI Tag. Defaults to `EVENT_SOURCE_UNSPECIFIED`.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Recommendationengine\V1Beta1\UserEvent::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. User event type. Allowed values are:
     * * `add-to-cart` Products being added to cart.
     * * `add-to-list` Items being added to a list (shopping list, favorites
     *   etc).
     * * `category-page-view` Special pages such as sale or promotion pages
     *   viewed.
     * * `checkout-start` User starting a checkout process.
     * * `detail-page-view` Products detail page viewed.
     * * `home-page-view` Homepage viewed.
     * * `page-visit` Generic page visits not included in the event types above.
     * * `purchase-complete` User finishing a purchase.
     * * `refund` Purchased items being refunded or returned.
     * * `remove-from-cart` Products being removed from cart.
     * * `remove-from-list` Items being removed from a list.
     * * `search` Product search.
     * * `shopping-cart-page-view` User viewing a shopping cart.
     * * `impression` List of items displayed. Used by Google Tag Manager.
     *
     * Generated from protobuf field <code>string event_type = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return string
     */
    public function getEventType()
    {
        return $this->event_type;
    }

    /**
     * Required. User event type. Allowed values are:
     * * `add-to-cart` Products being added to cart.
     * * `add-to-list` Items being added to a list (shopping list, favorites
     *   etc).
     * * `category-page-view` Special pages such as sale or promotion pages
     *   viewed.
     * * `checkout-start` User starting a checkout process.
     * * `detail-page-view` Products detail page viewed.
     * * `home-page-view` Homepage viewed.
     * * `page-visit` Generic page visits not included in the event types above.
     * * `purchase-complete` User finishing a purchase.
     * * `refund` Purchased items being refunded or returned.
     * * `remove-from-cart` Products being removed from cart.
     * * `remove-from-list` Items being removed from a list.
     * * `search` Product search.
     * * `shopping-cart-page-view` User viewing a shopping cart.
     * * `impression` List of items displayed. Used by Google Tag Manager.
     *
     * Generated from protobuf field <code>string event_type = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param string $var
     * @return $this
     */
    public function setEventType($var)
    {
        GPBUtil::checkString($var, True);
        $this->event_type = $var;

        return $this;
    }

    /**
     * Required. User information.
     *
     * Generated from protobuf field <code>.google.cloud.recommendationengine.v1beta1.UserInfo user_info = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Cloud\RecommendationEngine\V1beta1\UserInfo|null
     */
    public function getUserInfo()
    {
        return isset($this->user_info) ? $this->user_info : null;
    }

    public function hasUserInfo()
    {
        return isset($this->user_info);
    }

    public function clearUserInfo()
    {
        unset($this->user_info);
    }

    /**
     * Required. User information.
     *
     * Generated from protobuf field <code>.google.cloud.recommendationengine.v1beta1.UserInfo user_info = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param \Google\Cloud\RecommendationEngine\V1beta1\UserInfo $var
     * @return $this
     */
    public function setUserInfo($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\RecommendationEngine\V1beta1\UserInfo::class);
        $this->user_info = $var;

        return $this;
    }

    /**
     * Optional. User event detailed information common across different
     * recommendation types.
     *
     * Generated from protobuf field <code>.google.cloud.recommendationengine.v1beta1.EventDetail event_detail = 3 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @return \Google\Cloud\RecommendationEngine\V1beta1\EventDetail|null
     */
    public function getEventDetail()
    {
        return isset($this->event_detail) ? $this->event_detail : null;
    }

    public function hasEventDetail()
    {
        return isset($this->event_detail);
    }

    public function clearEventDetail()
    {
        unset($this->event_detail);
    }

    /**
     * Optional. User event detailed information common across different
     * recommendation types.
     *
     * Generated from protobuf field <code>.google.cloud.recommendationengine.v1beta1.EventDetail event_detail = 3 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @param \Google\Cloud\RecommendationEngine\V1beta1\EventDetail $var
     * @return $this
     */
    public function setEventDetail($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\RecommendationEngine\V1beta1\EventDetail::class);
        $this->event_detail = $var;

        return $this;
    }

    /**
     * Optional. Retail product specific user event metadata.
     * This field is required for the following event types:
     * * `add-to-cart`
     * * `add-to-list`
     * * `category-page-view`
     * * `checkout-start`
     * * `detail-page-view`
     * * `purchase-complete`
     * * `refund`
     * * `remove-from-cart`
     * * `remove-from-list`
     * * `search`
     * This field is optional for the following event types:
     * * `page-visit`
     * * `shopping-cart-page-view` - note that 'product_event_detail' should be
     *   set for this unless the shopping cart is empty.
     * This field is not allowed for the following event types:
     * * `home-page-view`
     *
     * Generated from protobuf field <code>.google.cloud.recommendationengine.v1beta1.ProductEventDetail product_event_detail = 4 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @return \Google\Cloud\RecommendationEngine\V1beta1\ProductEventDetail|null
     */
    public function getProductEventDetail()
    {
        return isset($this->product_event_detail) ? $this->product_event_detail : null;
    }

    public function hasProductEventDetail()
    {
        return isset($this->product_event_detail);
    }

    public function clearProductEventDetail()
    {
        unset($this->product_event_detail);
    }

    /**
     * Optional. Retail product specific user event metadata.
     * This field is required for the following event types:
     * * `add-to-cart`
     * * `add-to-list`
     * * `category-page-view`
     * * `checkout-start`
     * * `detail-page-view`
     * * `purchase-complete`
     * * `refund`
     * * `remove-from-cart`
     * * `remove-from-list`
     * * `search`
     * This field is optional for the following event types:
     * * `page-visit`
     * * `shopping-cart-page-view` - note that 'product_event_detail' should be
     *   set for this unless the shopping cart is empty.
     * This field is not allowed for the following event types:
     * * `home-page-view`
     *
     * Generated from protobuf field <code>.google.cloud.recommendationengine.v1beta1.ProductEventDetail product_event_detail = 4 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @param \Google\Cloud\RecommendationEngine\V1beta1\ProductEventDetail $var
     * @return $this
     */
    public function setProductEventDetail($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\RecommendationEngine\V1beta1\ProductEventDetail::class);
        $this->product_event_detail = $var;

        return $this;
    }

    /**
     * Optional. Only required for ImportUserEvents method. Timestamp of user
     * event created.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp event_time = 5 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @return \Google\Protobuf\Timestamp|null
     */
    public function getEventTime()
    {
        return isset($this->event_time) ? $this->event_time : null;
    }

    public function hasEventTime()
    {
        return isset($this->event_time);
    }

    public function clearEventTime()
    {
        unset($this->event_time);
    }

    /**
     * Optional. Only required for ImportUserEvents method. Timestamp of user
     * event created.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp event_time = 5 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @param \Google\Protobuf\Timestamp $var
     * @return $this
     */
    public function setEventTime($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Timestamp::class);
        $this->event_time = $var;

        return $this;
    }

    /**
     * Optional. This field should *not* be set when using JavaScript pixel
     * or the Recommendations AI Tag. Defaults to `EVENT_SOURCE_UNSPECIFIED`.
     *
     * Generated from protobuf field <code>.google.cloud.recommendationengine.v1beta1.UserEvent.EventSource event_source = 6 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @return int
     */
    public function getEventSource()
    {
        return $this->event_source;
    }

    /**
     * Optional. This field should *not* be set when using JavaScript pixel
     * or the Recommendations AI Tag. Defaults to `EVENT_SOURCE_UNSPECIFIED`.
     *
     * Generated from protobuf field <code>.google.cloud.recommendationengine.v1beta1.UserEvent.EventSource event_source = 6 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @param int $var
     * @return $this
     */
    public function setEventSource($var)
    {
        GPBUtil::checkEnum($var, \Google\Cloud\RecommendationEngine\V1beta1\UserEvent\EventSource::class);
        $this->event_source = $var;

        return $this;
    }

}

