<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/channel/v1/service.proto

namespace Google\Cloud\Channel\V1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Request message for [CloudChannelService.UpdateChannelPartnerLink][google.cloud.channel.v1.CloudChannelService.UpdateChannelPartnerLink]
 *
 * Generated from protobuf message <code>google.cloud.channel.v1.UpdateChannelPartnerLinkRequest</code>
 */
class UpdateChannelPartnerLinkRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The resource name of the channel partner link to cancel.
     * The name takes the format: accounts/{account_id}/channelPartnerLinks/{id}
     * where {id} is the Cloud Identity ID of the partner.
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $name = '';
    /**
     * Required. The channel partner link to update. Only field
     * channel_partner_link.link_state is allowed to be updated.
     *
     * Generated from protobuf field <code>.google.cloud.channel.v1.ChannelPartnerLink channel_partner_link = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $channel_partner_link = null;
    /**
     * Required. The update mask that applies to the resource.
     * The only allowable value for update mask is
     * channel_partner_link.link_state.
     *
     * Generated from protobuf field <code>.google.protobuf.FieldMask update_mask = 3 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $update_mask = null;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $name
     *           Required. The resource name of the channel partner link to cancel.
     *           The name takes the format: accounts/{account_id}/channelPartnerLinks/{id}
     *           where {id} is the Cloud Identity ID of the partner.
     *     @type \Google\Cloud\Channel\V1\ChannelPartnerLink $channel_partner_link
     *           Required. The channel partner link to update. Only field
     *           channel_partner_link.link_state is allowed to be updated.
     *     @type \Google\Protobuf\FieldMask $update_mask
     *           Required. The update mask that applies to the resource.
     *           The only allowable value for update mask is
     *           channel_partner_link.link_state.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Channel\V1\Service::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The resource name of the channel partner link to cancel.
     * The name takes the format: accounts/{account_id}/channelPartnerLinks/{id}
     * where {id} is the Cloud Identity ID of the partner.
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return string
     */
    public function getName()
    {
        return $this->name;
    }

    /**
     * Required. The resource name of the channel partner link to cancel.
     * The name takes the format: accounts/{account_id}/channelPartnerLinks/{id}
     * where {id} is the Cloud Identity ID of the partner.
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
     * Required. The channel partner link to update. Only field
     * channel_partner_link.link_state is allowed to be updated.
     *
     * Generated from protobuf field <code>.google.cloud.channel.v1.ChannelPartnerLink channel_partner_link = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Cloud\Channel\V1\ChannelPartnerLink|null
     */
    public function getChannelPartnerLink()
    {
        return isset($this->channel_partner_link) ? $this->channel_partner_link : null;
    }

    public function hasChannelPartnerLink()
    {
        return isset($this->channel_partner_link);
    }

    public function clearChannelPartnerLink()
    {
        unset($this->channel_partner_link);
    }

    /**
     * Required. The channel partner link to update. Only field
     * channel_partner_link.link_state is allowed to be updated.
     *
     * Generated from protobuf field <code>.google.cloud.channel.v1.ChannelPartnerLink channel_partner_link = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param \Google\Cloud\Channel\V1\ChannelPartnerLink $var
     * @return $this
     */
    public function setChannelPartnerLink($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Channel\V1\ChannelPartnerLink::class);
        $this->channel_partner_link = $var;

        return $this;
    }

    /**
     * Required. The update mask that applies to the resource.
     * The only allowable value for update mask is
     * channel_partner_link.link_state.
     *
     * Generated from protobuf field <code>.google.protobuf.FieldMask update_mask = 3 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Protobuf\FieldMask|null
     */
    public function getUpdateMask()
    {
        return isset($this->update_mask) ? $this->update_mask : null;
    }

    public function hasUpdateMask()
    {
        return isset($this->update_mask);
    }

    public function clearUpdateMask()
    {
        unset($this->update_mask);
    }

    /**
     * Required. The update mask that applies to the resource.
     * The only allowable value for update mask is
     * channel_partner_link.link_state.
     *
     * Generated from protobuf field <code>.google.protobuf.FieldMask update_mask = 3 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param \Google\Protobuf\FieldMask $var
     * @return $this
     */
    public function setUpdateMask($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\FieldMask::class);
        $this->update_mask = $var;

        return $this;
    }

}

