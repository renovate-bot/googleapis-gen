<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/iam/v1beta/workload_identity_pool.proto

namespace Google\Iam\V1beta;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Request message for CreateWorkloadIdentityPool.
 *
 * Generated from protobuf message <code>google.iam.v1beta.CreateWorkloadIdentityPoolRequest</code>
 */
class CreateWorkloadIdentityPoolRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The parent resource to create the pool in. The only supported
     * location is `global`.
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     */
    protected $parent = '';
    /**
     * Required. The pool to create.
     *
     * Generated from protobuf field <code>.google.iam.v1beta.WorkloadIdentityPool workload_identity_pool = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $workload_identity_pool = null;
    /**
     * Required. The ID to use for the pool, which becomes the
     * final component of the resource name. This value should be 4-32 characters,
     * and may contain the characters [a-z0-9-]. The prefix `gcp-` is
     * reserved for use by Google, and may not be specified.
     *
     * Generated from protobuf field <code>string workload_identity_pool_id = 3 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $workload_identity_pool_id = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $parent
     *           Required. The parent resource to create the pool in. The only supported
     *           location is `global`.
     *     @type \Google\Iam\V1beta\WorkloadIdentityPool $workload_identity_pool
     *           Required. The pool to create.
     *     @type string $workload_identity_pool_id
     *           Required. The ID to use for the pool, which becomes the
     *           final component of the resource name. This value should be 4-32 characters,
     *           and may contain the characters [a-z0-9-]. The prefix `gcp-` is
     *           reserved for use by Google, and may not be specified.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Iam\V1Beta\WorkloadIdentityPool::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The parent resource to create the pool in. The only supported
     * location is `global`.
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getParent()
    {
        return $this->parent;
    }

    /**
     * Required. The parent resource to create the pool in. The only supported
     * location is `global`.
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
     * Required. The pool to create.
     *
     * Generated from protobuf field <code>.google.iam.v1beta.WorkloadIdentityPool workload_identity_pool = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Iam\V1beta\WorkloadIdentityPool|null
     */
    public function getWorkloadIdentityPool()
    {
        return $this->workload_identity_pool;
    }

    public function hasWorkloadIdentityPool()
    {
        return isset($this->workload_identity_pool);
    }

    public function clearWorkloadIdentityPool()
    {
        unset($this->workload_identity_pool);
    }

    /**
     * Required. The pool to create.
     *
     * Generated from protobuf field <code>.google.iam.v1beta.WorkloadIdentityPool workload_identity_pool = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param \Google\Iam\V1beta\WorkloadIdentityPool $var
     * @return $this
     */
    public function setWorkloadIdentityPool($var)
    {
        GPBUtil::checkMessage($var, \Google\Iam\V1beta\WorkloadIdentityPool::class);
        $this->workload_identity_pool = $var;

        return $this;
    }

    /**
     * Required. The ID to use for the pool, which becomes the
     * final component of the resource name. This value should be 4-32 characters,
     * and may contain the characters [a-z0-9-]. The prefix `gcp-` is
     * reserved for use by Google, and may not be specified.
     *
     * Generated from protobuf field <code>string workload_identity_pool_id = 3 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return string
     */
    public function getWorkloadIdentityPoolId()
    {
        return $this->workload_identity_pool_id;
    }

    /**
     * Required. The ID to use for the pool, which becomes the
     * final component of the resource name. This value should be 4-32 characters,
     * and may contain the characters [a-z0-9-]. The prefix `gcp-` is
     * reserved for use by Google, and may not be specified.
     *
     * Generated from protobuf field <code>string workload_identity_pool_id = 3 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param string $var
     * @return $this
     */
    public function setWorkloadIdentityPoolId($var)
    {
        GPBUtil::checkString($var, True);
        $this->workload_identity_pool_id = $var;

        return $this;
    }

}

