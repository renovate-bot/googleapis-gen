<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/cx/v3beta1/session_entity_type.proto

namespace Google\Cloud\Dialogflow\Cx\V3beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * The request message for [SessionEntityTypes.DeleteSessionEntityType][google.cloud.dialogflow.cx.v3beta1.SessionEntityTypes.DeleteSessionEntityType].
 *
 * Generated from protobuf message <code>google.cloud.dialogflow.cx.v3beta1.DeleteSessionEntityTypeRequest</code>
 */
class DeleteSessionEntityTypeRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The name of the session entity type to delete.
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     * ID>/sessions/<Session ID>/entityTypes/<Entity Type ID>` or
     * `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     * ID>/environments/<Environment ID>/sessions/<Session ID>/entityTypes/<Entity
     * Type ID>`. If `Environment ID` is not specified, we assume default 'draft'
     * environment.
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     */
    protected $name = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $name
     *           Required. The name of the session entity type to delete.
     *           Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     *           ID>/sessions/<Session ID>/entityTypes/<Entity Type ID>` or
     *           `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     *           ID>/environments/<Environment ID>/sessions/<Session ID>/entityTypes/<Entity
     *           Type ID>`. If `Environment ID` is not specified, we assume default 'draft'
     *           environment.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Dialogflow\Cx\V3Beta1\SessionEntityType::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The name of the session entity type to delete.
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     * ID>/sessions/<Session ID>/entityTypes/<Entity Type ID>` or
     * `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     * ID>/environments/<Environment ID>/sessions/<Session ID>/entityTypes/<Entity
     * Type ID>`. If `Environment ID` is not specified, we assume default 'draft'
     * environment.
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getName()
    {
        return $this->name;
    }

    /**
     * Required. The name of the session entity type to delete.
     * Format: `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     * ID>/sessions/<Session ID>/entityTypes/<Entity Type ID>` or
     * `projects/<Project ID>/locations/<Location ID>/agents/<Agent
     * ID>/environments/<Environment ID>/sessions/<Session ID>/entityTypes/<Entity
     * Type ID>`. If `Environment ID` is not specified, we assume default 'draft'
     * environment.
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @param string $var
     * @return $this
     */
    public function setName($var)
    {
        GPBUtil::checkString($var, True);
        $this->name = $var;

        return $this;
    }

}

