<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/devtools/testing/v1/test_execution.proto

namespace Google\Devtools\Testing\V1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Information about the client which invoked the test.
 *
 * Generated from protobuf message <code>google.devtools.testing.v1.ClientInfo</code>
 */
class ClientInfo extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. Client name, such as gcloud.
     *
     * Generated from protobuf field <code>string name = 1;</code>
     */
    protected $name = '';
    /**
     * The list of detailed information about client.
     *
     * Generated from protobuf field <code>repeated .google.devtools.testing.v1.ClientInfoDetail client_info_details = 2;</code>
     */
    private $client_info_details;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $name
     *           Required. Client name, such as gcloud.
     *     @type \Google\Devtools\Testing\V1\ClientInfoDetail[]|\Google\Protobuf\Internal\RepeatedField $client_info_details
     *           The list of detailed information about client.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Devtools\Testing\V1\TestExecution::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. Client name, such as gcloud.
     *
     * Generated from protobuf field <code>string name = 1;</code>
     * @return string
     */
    public function getName()
    {
        return $this->name;
    }

    /**
     * Required. Client name, such as gcloud.
     *
     * Generated from protobuf field <code>string name = 1;</code>
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
     * The list of detailed information about client.
     *
     * Generated from protobuf field <code>repeated .google.devtools.testing.v1.ClientInfoDetail client_info_details = 2;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getClientInfoDetails()
    {
        return $this->client_info_details;
    }

    /**
     * The list of detailed information about client.
     *
     * Generated from protobuf field <code>repeated .google.devtools.testing.v1.ClientInfoDetail client_info_details = 2;</code>
     * @param \Google\Devtools\Testing\V1\ClientInfoDetail[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setClientInfoDetails($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::MESSAGE, \Google\Devtools\Testing\V1\ClientInfoDetail::class);
        $this->client_info_details = $arr;

        return $this;
    }

}

