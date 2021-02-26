<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/datalabeling/v1beta1/data_labeling_service.proto

namespace Google\Cloud\DataLabeling\V1beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Request message for ImportData API.
 *
 * Generated from protobuf message <code>google.cloud.datalabeling.v1beta1.ImportDataRequest</code>
 */
class ImportDataRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. Dataset resource name, format:
     * projects/{project_id}/datasets/{dataset_id}
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     */
    protected $name = '';
    /**
     * Required. Specify the input source of the data.
     *
     * Generated from protobuf field <code>.google.cloud.datalabeling.v1beta1.InputConfig input_config = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $input_config = null;
    /**
     * Email of the user who started the import task and should be notified by
     * email. If empty no notification will be sent.
     *
     * Generated from protobuf field <code>string user_email_address = 3;</code>
     */
    protected $user_email_address = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $name
     *           Required. Dataset resource name, format:
     *           projects/{project_id}/datasets/{dataset_id}
     *     @type \Google\Cloud\DataLabeling\V1beta1\InputConfig $input_config
     *           Required. Specify the input source of the data.
     *     @type string $user_email_address
     *           Email of the user who started the import task and should be notified by
     *           email. If empty no notification will be sent.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Datalabeling\V1Beta1\DataLabelingService::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. Dataset resource name, format:
     * projects/{project_id}/datasets/{dataset_id}
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getName()
    {
        return $this->name;
    }

    /**
     * Required. Dataset resource name, format:
     * projects/{project_id}/datasets/{dataset_id}
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

    /**
     * Required. Specify the input source of the data.
     *
     * Generated from protobuf field <code>.google.cloud.datalabeling.v1beta1.InputConfig input_config = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Cloud\DataLabeling\V1beta1\InputConfig|null
     */
    public function getInputConfig()
    {
        return isset($this->input_config) ? $this->input_config : null;
    }

    public function hasInputConfig()
    {
        return isset($this->input_config);
    }

    public function clearInputConfig()
    {
        unset($this->input_config);
    }

    /**
     * Required. Specify the input source of the data.
     *
     * Generated from protobuf field <code>.google.cloud.datalabeling.v1beta1.InputConfig input_config = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param \Google\Cloud\DataLabeling\V1beta1\InputConfig $var
     * @return $this
     */
    public function setInputConfig($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\DataLabeling\V1beta1\InputConfig::class);
        $this->input_config = $var;

        return $this;
    }

    /**
     * Email of the user who started the import task and should be notified by
     * email. If empty no notification will be sent.
     *
     * Generated from protobuf field <code>string user_email_address = 3;</code>
     * @return string
     */
    public function getUserEmailAddress()
    {
        return $this->user_email_address;
    }

    /**
     * Email of the user who started the import task and should be notified by
     * email. If empty no notification will be sent.
     *
     * Generated from protobuf field <code>string user_email_address = 3;</code>
     * @param string $var
     * @return $this
     */
    public function setUserEmailAddress($var)
    {
        GPBUtil::checkString($var, True);
        $this->user_email_address = $var;

        return $this;
    }

}

