<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/bigtable/admin/v2/bigtable_instance_admin.proto

namespace Google\Cloud\Bigtable\Admin\V2;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Request message for BigtableInstanceAdmin.CreateInstance.
 *
 * Generated from protobuf message <code>google.bigtable.admin.v2.CreateInstanceRequest</code>
 */
class CreateInstanceRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The unique name of the project in which to create the new instance.
     * Values are of the form `projects/{project}`.
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     */
    protected $parent = '';
    /**
     * Required. The ID to be used when referring to the new instance within its project,
     * e.g., just `myinstance` rather than
     * `projects/myproject/instances/myinstance`.
     *
     * Generated from protobuf field <code>string instance_id = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $instance_id = '';
    /**
     * Required. The instance to create.
     * Fields marked `OutputOnly` must be left blank.
     *
     * Generated from protobuf field <code>.google.bigtable.admin.v2.Instance instance = 3 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $instance = null;
    /**
     * Required. The clusters to be created within the instance, mapped by desired
     * cluster ID, e.g., just `mycluster` rather than
     * `projects/myproject/instances/myinstance/clusters/mycluster`.
     * Fields marked `OutputOnly` must be left blank.
     * Currently, at most four clusters can be specified.
     *
     * Generated from protobuf field <code>map<string, .google.bigtable.admin.v2.Cluster> clusters = 4 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    private $clusters;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $parent
     *           Required. The unique name of the project in which to create the new instance.
     *           Values are of the form `projects/{project}`.
     *     @type string $instance_id
     *           Required. The ID to be used when referring to the new instance within its project,
     *           e.g., just `myinstance` rather than
     *           `projects/myproject/instances/myinstance`.
     *     @type \Google\Cloud\Bigtable\Admin\V2\Instance $instance
     *           Required. The instance to create.
     *           Fields marked `OutputOnly` must be left blank.
     *     @type array|\Google\Protobuf\Internal\MapField $clusters
     *           Required. The clusters to be created within the instance, mapped by desired
     *           cluster ID, e.g., just `mycluster` rather than
     *           `projects/myproject/instances/myinstance/clusters/mycluster`.
     *           Fields marked `OutputOnly` must be left blank.
     *           Currently, at most four clusters can be specified.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Bigtable\Admin\V2\BigtableInstanceAdmin::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The unique name of the project in which to create the new instance.
     * Values are of the form `projects/{project}`.
     *
     * Generated from protobuf field <code>string parent = 1 [(.google.api.field_behavior) = REQUIRED, (.google.api.resource_reference) = {</code>
     * @return string
     */
    public function getParent()
    {
        return $this->parent;
    }

    /**
     * Required. The unique name of the project in which to create the new instance.
     * Values are of the form `projects/{project}`.
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
     * Required. The ID to be used when referring to the new instance within its project,
     * e.g., just `myinstance` rather than
     * `projects/myproject/instances/myinstance`.
     *
     * Generated from protobuf field <code>string instance_id = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return string
     */
    public function getInstanceId()
    {
        return $this->instance_id;
    }

    /**
     * Required. The ID to be used when referring to the new instance within its project,
     * e.g., just `myinstance` rather than
     * `projects/myproject/instances/myinstance`.
     *
     * Generated from protobuf field <code>string instance_id = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param string $var
     * @return $this
     */
    public function setInstanceId($var)
    {
        GPBUtil::checkString($var, True);
        $this->instance_id = $var;

        return $this;
    }

    /**
     * Required. The instance to create.
     * Fields marked `OutputOnly` must be left blank.
     *
     * Generated from protobuf field <code>.google.bigtable.admin.v2.Instance instance = 3 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Cloud\Bigtable\Admin\V2\Instance|null
     */
    public function getInstance()
    {
        return isset($this->instance) ? $this->instance : null;
    }

    public function hasInstance()
    {
        return isset($this->instance);
    }

    public function clearInstance()
    {
        unset($this->instance);
    }

    /**
     * Required. The instance to create.
     * Fields marked `OutputOnly` must be left blank.
     *
     * Generated from protobuf field <code>.google.bigtable.admin.v2.Instance instance = 3 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param \Google\Cloud\Bigtable\Admin\V2\Instance $var
     * @return $this
     */
    public function setInstance($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Bigtable\Admin\V2\Instance::class);
        $this->instance = $var;

        return $this;
    }

    /**
     * Required. The clusters to be created within the instance, mapped by desired
     * cluster ID, e.g., just `mycluster` rather than
     * `projects/myproject/instances/myinstance/clusters/mycluster`.
     * Fields marked `OutputOnly` must be left blank.
     * Currently, at most four clusters can be specified.
     *
     * Generated from protobuf field <code>map<string, .google.bigtable.admin.v2.Cluster> clusters = 4 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Protobuf\Internal\MapField
     */
    public function getClusters()
    {
        return $this->clusters;
    }

    /**
     * Required. The clusters to be created within the instance, mapped by desired
     * cluster ID, e.g., just `mycluster` rather than
     * `projects/myproject/instances/myinstance/clusters/mycluster`.
     * Fields marked `OutputOnly` must be left blank.
     * Currently, at most four clusters can be specified.
     *
     * Generated from protobuf field <code>map<string, .google.bigtable.admin.v2.Cluster> clusters = 4 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param array|\Google\Protobuf\Internal\MapField $var
     * @return $this
     */
    public function setClusters($var)
    {
        $arr = GPBUtil::checkMapField($var, \Google\Protobuf\Internal\GPBType::STRING, \Google\Protobuf\Internal\GPBType::MESSAGE, \Google\Cloud\Bigtable\Admin\V2\Cluster::class);
        $this->clusters = $arr;

        return $this;
    }

}

