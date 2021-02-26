<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/networkconnectivity/v1alpha1/hub.proto

namespace Google\Cloud\NetworkConnectivity\V1alpha1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Request for [HubService.CreateHub][google.cloud.networkconnectivity.v1alpha1.HubService.CreateHub] method.
 *
 * Generated from protobuf message <code>google.cloud.networkconnectivity.v1alpha1.CreateHubRequest</code>
 */
class CreateHubRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The parent resource's name of the Hub.
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     */
    protected $parent = '';
    /**
     * Optional. Unique id for the Hub to create.
     *
     * Generated from protobuf field <code>string hub_id = 2 [(.google.api.field_behavior) = OPTIONAL];</code>
     */
    protected $hub_id = '';
    /**
     * Required. Initial values for a new Hub.
     *
     * Generated from protobuf field <code>.google.cloud.networkconnectivity.v1alpha1.Hub hub = 3 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $hub = null;
    /**
     * Optional. An optional request ID to identify requests. Specify a unique request ID
     * so that if you must retry your request, the server will know to ignore
     * the request if it has already been completed. The server will guarantee
     * that for at least 60 minutes since the first request.
     * For example, consider a situation where you make an initial request and t
     * he request times out. If you make the request again with the same request
     * ID, the server can check if original operation with the same request ID
     * was received, and if so, will ignore the second request. This prevents
     * clients from accidentally creating duplicate commitments.
     * The request ID must be a valid UUID with the exception that zero UUID is
     * not supported (00000000-0000-0000-0000-000000000000).
     *
     * Generated from protobuf field <code>string request_id = 4 [(.google.api.field_behavior) = OPTIONAL];</code>
     */
    protected $request_id = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $parent
     *           Required. The parent resource's name of the Hub.
     *     @type string $hub_id
     *           Optional. Unique id for the Hub to create.
     *     @type \Google\Cloud\NetworkConnectivity\V1alpha1\Hub $hub
     *           Required. Initial values for a new Hub.
     *     @type string $request_id
     *           Optional. An optional request ID to identify requests. Specify a unique request ID
     *           so that if you must retry your request, the server will know to ignore
     *           the request if it has already been completed. The server will guarantee
     *           that for at least 60 minutes since the first request.
     *           For example, consider a situation where you make an initial request and t
     *           he request times out. If you make the request again with the same request
     *           ID, the server can check if original operation with the same request ID
     *           was received, and if so, will ignore the second request. This prevents
     *           clients from accidentally creating duplicate commitments.
     *           The request ID must be a valid UUID with the exception that zero UUID is
     *           not supported (00000000-0000-0000-0000-000000000000).
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Networkconnectivity\V1Alpha1\Hub::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The parent resource's name of the Hub.
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getParent()
    {
        return $this->parent;
    }

    /**
     * Required. The parent resource's name of the Hub.
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
     * Optional. Unique id for the Hub to create.
     *
     * Generated from protobuf field <code>string hub_id = 2 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @return string
     */
    public function getHubId()
    {
        return $this->hub_id;
    }

    /**
     * Optional. Unique id for the Hub to create.
     *
     * Generated from protobuf field <code>string hub_id = 2 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @param string $var
     * @return $this
     */
    public function setHubId($var)
    {
        GPBUtil::checkString($var, True);
        $this->hub_id = $var;

        return $this;
    }

    /**
     * Required. Initial values for a new Hub.
     *
     * Generated from protobuf field <code>.google.cloud.networkconnectivity.v1alpha1.Hub hub = 3 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Cloud\NetworkConnectivity\V1alpha1\Hub|null
     */
    public function getHub()
    {
        return isset($this->hub) ? $this->hub : null;
    }

    public function hasHub()
    {
        return isset($this->hub);
    }

    public function clearHub()
    {
        unset($this->hub);
    }

    /**
     * Required. Initial values for a new Hub.
     *
     * Generated from protobuf field <code>.google.cloud.networkconnectivity.v1alpha1.Hub hub = 3 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param \Google\Cloud\NetworkConnectivity\V1alpha1\Hub $var
     * @return $this
     */
    public function setHub($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\NetworkConnectivity\V1alpha1\Hub::class);
        $this->hub = $var;

        return $this;
    }

    /**
     * Optional. An optional request ID to identify requests. Specify a unique request ID
     * so that if you must retry your request, the server will know to ignore
     * the request if it has already been completed. The server will guarantee
     * that for at least 60 minutes since the first request.
     * For example, consider a situation where you make an initial request and t
     * he request times out. If you make the request again with the same request
     * ID, the server can check if original operation with the same request ID
     * was received, and if so, will ignore the second request. This prevents
     * clients from accidentally creating duplicate commitments.
     * The request ID must be a valid UUID with the exception that zero UUID is
     * not supported (00000000-0000-0000-0000-000000000000).
     *
     * Generated from protobuf field <code>string request_id = 4 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @return string
     */
    public function getRequestId()
    {
        return $this->request_id;
    }

    /**
     * Optional. An optional request ID to identify requests. Specify a unique request ID
     * so that if you must retry your request, the server will know to ignore
     * the request if it has already been completed. The server will guarantee
     * that for at least 60 minutes since the first request.
     * For example, consider a situation where you make an initial request and t
     * he request times out. If you make the request again with the same request
     * ID, the server can check if original operation with the same request ID
     * was received, and if so, will ignore the second request. This prevents
     * clients from accidentally creating duplicate commitments.
     * The request ID must be a valid UUID with the exception that zero UUID is
     * not supported (00000000-0000-0000-0000-000000000000).
     *
     * Generated from protobuf field <code>string request_id = 4 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @param string $var
     * @return $this
     */
    public function setRequestId($var)
    {
        GPBUtil::checkString($var, True);
        $this->request_id = $var;

        return $this;
    }

}

