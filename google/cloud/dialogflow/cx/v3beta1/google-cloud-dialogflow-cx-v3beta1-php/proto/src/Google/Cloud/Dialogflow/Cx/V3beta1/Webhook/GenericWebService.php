<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/cx/v3beta1/webhook.proto

namespace Google\Cloud\Dialogflow\Cx\V3beta1\Webhook;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Represents configuration for a generic web service.
 *
 * Generated from protobuf message <code>google.cloud.dialogflow.cx.v3beta1.Webhook.GenericWebService</code>
 */
class GenericWebService extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The webhook URI for receiving POST requests. It must use https protocol.
     *
     * Generated from protobuf field <code>string uri = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $uri = '';
    /**
     * The user name for HTTP Basic authentication.
     *
     * Generated from protobuf field <code>string username = 2 [deprecated = true];</code>
     */
    protected $username = '';
    /**
     * The password for HTTP Basic authentication.
     *
     * Generated from protobuf field <code>string password = 3 [deprecated = true];</code>
     */
    protected $password = '';
    /**
     * The HTTP request headers to send together with webhook
     * requests.
     *
     * Generated from protobuf field <code>map<string, string> request_headers = 4;</code>
     */
    private $request_headers;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $uri
     *           Required. The webhook URI for receiving POST requests. It must use https protocol.
     *     @type string $username
     *           The user name for HTTP Basic authentication.
     *     @type string $password
     *           The password for HTTP Basic authentication.
     *     @type array|\Google\Protobuf\Internal\MapField $request_headers
     *           The HTTP request headers to send together with webhook
     *           requests.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Dialogflow\Cx\V3Beta1\Webhook::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The webhook URI for receiving POST requests. It must use https protocol.
     *
     * Generated from protobuf field <code>string uri = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return string
     */
    public function getUri()
    {
        return $this->uri;
    }

    /**
     * Required. The webhook URI for receiving POST requests. It must use https protocol.
     *
     * Generated from protobuf field <code>string uri = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param string $var
     * @return $this
     */
    public function setUri($var)
    {
        GPBUtil::checkString($var, True);
        $this->uri = $var;

        return $this;
    }

    /**
     * The user name for HTTP Basic authentication.
     *
     * Generated from protobuf field <code>string username = 2 [deprecated = true];</code>
     * @return string
     */
    public function getUsername()
    {
        return $this->username;
    }

    /**
     * The user name for HTTP Basic authentication.
     *
     * Generated from protobuf field <code>string username = 2 [deprecated = true];</code>
     * @param string $var
     * @return $this
     */
    public function setUsername($var)
    {
        GPBUtil::checkString($var, True);
        $this->username = $var;

        return $this;
    }

    /**
     * The password for HTTP Basic authentication.
     *
     * Generated from protobuf field <code>string password = 3 [deprecated = true];</code>
     * @return string
     */
    public function getPassword()
    {
        return $this->password;
    }

    /**
     * The password for HTTP Basic authentication.
     *
     * Generated from protobuf field <code>string password = 3 [deprecated = true];</code>
     * @param string $var
     * @return $this
     */
    public function setPassword($var)
    {
        GPBUtil::checkString($var, True);
        $this->password = $var;

        return $this;
    }

    /**
     * The HTTP request headers to send together with webhook
     * requests.
     *
     * Generated from protobuf field <code>map<string, string> request_headers = 4;</code>
     * @return \Google\Protobuf\Internal\MapField
     */
    public function getRequestHeaders()
    {
        return $this->request_headers;
    }

    /**
     * The HTTP request headers to send together with webhook
     * requests.
     *
     * Generated from protobuf field <code>map<string, string> request_headers = 4;</code>
     * @param array|\Google\Protobuf\Internal\MapField $var
     * @return $this
     */
    public function setRequestHeaders($var)
    {
        $arr = GPBUtil::checkMapField($var, \Google\Protobuf\Internal\GPBType::STRING, \Google\Protobuf\Internal\GPBType::STRING);
        $this->request_headers = $arr;

        return $this;
    }

}

// Adding a class alias for backwards compatibility with the previous class name.
class_alias(GenericWebService::class, \Google\Cloud\Dialogflow\Cx\V3beta1\Webhook_GenericWebService::class);
