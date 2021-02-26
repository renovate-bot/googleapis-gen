<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/v2/intent.proto

namespace Google\Cloud\Dialogflow\V2\Intent\Message\BrowseCarouselCard;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Browsing carousel tile
 *
 * Generated from protobuf message <code>google.cloud.dialogflow.v2.Intent.Message.BrowseCarouselCard.BrowseCarouselCardItem</code>
 */
class BrowseCarouselCardItem extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. Action to present to the user.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.v2.Intent.Message.BrowseCarouselCard.BrowseCarouselCardItem.OpenUrlAction open_uri_action = 1;</code>
     */
    protected $open_uri_action = null;
    /**
     * Required. Title of the carousel item. Maximum of two lines of text.
     *
     * Generated from protobuf field <code>string title = 2;</code>
     */
    protected $title = '';
    /**
     * Optional. Description of the carousel item. Maximum of four lines of
     * text.
     *
     * Generated from protobuf field <code>string description = 3 [(.google.api.field_behavior) = OPTIONAL];</code>
     */
    protected $description = '';
    /**
     * Optional. Hero image for the carousel item.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.v2.Intent.Message.Image image = 4 [(.google.api.field_behavior) = OPTIONAL];</code>
     */
    protected $image = null;
    /**
     * Optional. Text that appears at the bottom of the Browse Carousel
     * Card. Maximum of one line of text.
     *
     * Generated from protobuf field <code>string footer = 5 [(.google.api.field_behavior) = OPTIONAL];</code>
     */
    protected $footer = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Cloud\Dialogflow\V2\Intent\Message\BrowseCarouselCard\BrowseCarouselCardItem\OpenUrlAction $open_uri_action
     *           Required. Action to present to the user.
     *     @type string $title
     *           Required. Title of the carousel item. Maximum of two lines of text.
     *     @type string $description
     *           Optional. Description of the carousel item. Maximum of four lines of
     *           text.
     *     @type \Google\Cloud\Dialogflow\V2\Intent\Message\Image $image
     *           Optional. Hero image for the carousel item.
     *     @type string $footer
     *           Optional. Text that appears at the bottom of the Browse Carousel
     *           Card. Maximum of one line of text.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Dialogflow\V2\Intent::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. Action to present to the user.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.v2.Intent.Message.BrowseCarouselCard.BrowseCarouselCardItem.OpenUrlAction open_uri_action = 1;</code>
     * @return \Google\Cloud\Dialogflow\V2\Intent\Message\BrowseCarouselCard\BrowseCarouselCardItem\OpenUrlAction|null
     */
    public function getOpenUriAction()
    {
        return isset($this->open_uri_action) ? $this->open_uri_action : null;
    }

    public function hasOpenUriAction()
    {
        return isset($this->open_uri_action);
    }

    public function clearOpenUriAction()
    {
        unset($this->open_uri_action);
    }

    /**
     * Required. Action to present to the user.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.v2.Intent.Message.BrowseCarouselCard.BrowseCarouselCardItem.OpenUrlAction open_uri_action = 1;</code>
     * @param \Google\Cloud\Dialogflow\V2\Intent\Message\BrowseCarouselCard\BrowseCarouselCardItem\OpenUrlAction $var
     * @return $this
     */
    public function setOpenUriAction($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Dialogflow\V2\Intent\Message\BrowseCarouselCard\BrowseCarouselCardItem\OpenUrlAction::class);
        $this->open_uri_action = $var;

        return $this;
    }

    /**
     * Required. Title of the carousel item. Maximum of two lines of text.
     *
     * Generated from protobuf field <code>string title = 2;</code>
     * @return string
     */
    public function getTitle()
    {
        return $this->title;
    }

    /**
     * Required. Title of the carousel item. Maximum of two lines of text.
     *
     * Generated from protobuf field <code>string title = 2;</code>
     * @param string $var
     * @return $this
     */
    public function setTitle($var)
    {
        GPBUtil::checkString($var, True);
        $this->title = $var;

        return $this;
    }

    /**
     * Optional. Description of the carousel item. Maximum of four lines of
     * text.
     *
     * Generated from protobuf field <code>string description = 3 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @return string
     */
    public function getDescription()
    {
        return $this->description;
    }

    /**
     * Optional. Description of the carousel item. Maximum of four lines of
     * text.
     *
     * Generated from protobuf field <code>string description = 3 [(.google.api.field_behavior) = OPTIONAL];</code>
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
     * Optional. Hero image for the carousel item.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.v2.Intent.Message.Image image = 4 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @return \Google\Cloud\Dialogflow\V2\Intent\Message\Image|null
     */
    public function getImage()
    {
        return isset($this->image) ? $this->image : null;
    }

    public function hasImage()
    {
        return isset($this->image);
    }

    public function clearImage()
    {
        unset($this->image);
    }

    /**
     * Optional. Hero image for the carousel item.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.v2.Intent.Message.Image image = 4 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @param \Google\Cloud\Dialogflow\V2\Intent\Message\Image $var
     * @return $this
     */
    public function setImage($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Dialogflow\V2\Intent\Message\Image::class);
        $this->image = $var;

        return $this;
    }

    /**
     * Optional. Text that appears at the bottom of the Browse Carousel
     * Card. Maximum of one line of text.
     *
     * Generated from protobuf field <code>string footer = 5 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @return string
     */
    public function getFooter()
    {
        return $this->footer;
    }

    /**
     * Optional. Text that appears at the bottom of the Browse Carousel
     * Card. Maximum of one line of text.
     *
     * Generated from protobuf field <code>string footer = 5 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @param string $var
     * @return $this
     */
    public function setFooter($var)
    {
        GPBUtil::checkString($var, True);
        $this->footer = $var;

        return $this;
    }

}

// Adding a class alias for backwards compatibility with the previous class name.
class_alias(BrowseCarouselCardItem::class, \Google\Cloud\Dialogflow\V2\Intent_Message_BrowseCarouselCard_BrowseCarouselCardItem::class);

