<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dataproc/v1beta2/clusters.proto

namespace Google\Cloud\Dataproc\V1beta2;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * A request to update a cluster.
 *
 * Generated from protobuf message <code>google.cloud.dataproc.v1beta2.UpdateClusterRequest</code>
 */
class UpdateClusterRequest extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The ID of the Google Cloud Platform project the
     * cluster belongs to.
     *
     * Generated from protobuf field <code>string project_id = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $project_id = '';
    /**
     * Required. The Dataproc region in which to handle the request.
     *
     * Generated from protobuf field <code>string region = 5 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $region = '';
    /**
     * Required. The cluster name.
     *
     * Generated from protobuf field <code>string cluster_name = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $cluster_name = '';
    /**
     * Required. The changes to the cluster.
     *
     * Generated from protobuf field <code>.google.cloud.dataproc.v1beta2.Cluster cluster = 3 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $cluster = null;
    /**
     * Optional. Timeout for graceful YARN decomissioning. Graceful
     * decommissioning allows removing nodes from the cluster without
     * interrupting jobs in progress. Timeout specifies how long to wait for jobs
     * in progress to finish before forcefully removing nodes (and potentially
     * interrupting jobs). Default timeout is 0 (for forceful decommission), and
     * the maximum allowed timeout is 1 day (see JSON representation of
     * [Duration](https://developers.google.com/protocol-buffers/docs/proto3#json)).
     * Only supported on Dataproc image versions 1.2 and higher.
     *
     * Generated from protobuf field <code>.google.protobuf.Duration graceful_decommission_timeout = 6 [(.google.api.field_behavior) = OPTIONAL];</code>
     */
    protected $graceful_decommission_timeout = null;
    /**
     * Required. Specifies the path, relative to `Cluster`, of
     * the field to update. For example, to change the number of workers
     * in a cluster to 5, the `update_mask` parameter would be
     * specified as `config.worker_config.num_instances`,
     * and the `PATCH` request body would specify the new value, as follows:
     *     {
     *       "config":{
     *         "workerConfig":{
     *           "numInstances":"5"
     *         }
     *       }
     *     }
     * Similarly, to change the number of preemptible workers in a cluster to 5,
     * the `update_mask` parameter would be
     * `config.secondary_worker_config.num_instances`, and the `PATCH` request
     * body would be set as follows:
     *     {
     *       "config":{
     *         "secondaryWorkerConfig":{
     *           "numInstances":"5"
     *         }
     *       }
     *     }
     * <strong>Note:</strong> currently only the following fields can be updated:
     * <table>
     * <tr>
     * <td><strong>Mask</strong></td><td><strong>Purpose</strong></td>
     * </tr>
     * <tr>
     * <td>labels</td><td>Updates labels</td>
     * </tr>
     * <tr>
     * <td>config.worker_config.num_instances</td><td>Resize primary worker
     * group</td>
     * </tr>
     * <tr>
     * <td>config.secondary_worker_config.num_instances</td><td>Resize secondary
     * worker group</td>
     * </tr>
     * <tr>
     * <td>config.lifecycle_config.auto_delete_ttl</td><td>Reset MAX TTL
     * duration</td>
     * </tr>
     * <tr>
     * <td>config.lifecycle_config.auto_delete_time</td><td>Update MAX TTL
     * deletion timestamp</td>
     * </tr>
     * <tr>
     * <td>config.lifecycle_config.idle_delete_ttl</td><td>Update Idle TTL
     * duration</td>
     * </tr>
     * <tr>
     * <td>config.autoscaling_config.policy_uri</td><td>Use, stop using, or change
     * autoscaling policies</td>
     * </tr>
     * </table>
     *
     * Generated from protobuf field <code>.google.protobuf.FieldMask update_mask = 4 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $update_mask = null;
    /**
     * Optional. A unique id used to identify the request. If the server
     * receives two
     * [UpdateClusterRequest][google.cloud.dataproc.v1beta2.UpdateClusterRequest]
     * requests  with the same id, then the second request will be ignored and the
     * first [google.longrunning.Operation][google.longrunning.Operation] created
     * and stored in the backend is returned.
     * It is recommended to always set this value to a
     * [UUID](https://en.wikipedia.org/wiki/Universally_unique_identifier).
     * The id must contain only letters (a-z, A-Z), numbers (0-9),
     * underscores (_), and hyphens (-). The maximum length is 40 characters.
     *
     * Generated from protobuf field <code>string request_id = 7 [(.google.api.field_behavior) = OPTIONAL];</code>
     */
    protected $request_id = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $project_id
     *           Required. The ID of the Google Cloud Platform project the
     *           cluster belongs to.
     *     @type string $region
     *           Required. The Dataproc region in which to handle the request.
     *     @type string $cluster_name
     *           Required. The cluster name.
     *     @type \Google\Cloud\Dataproc\V1beta2\Cluster $cluster
     *           Required. The changes to the cluster.
     *     @type \Google\Protobuf\Duration $graceful_decommission_timeout
     *           Optional. Timeout for graceful YARN decomissioning. Graceful
     *           decommissioning allows removing nodes from the cluster without
     *           interrupting jobs in progress. Timeout specifies how long to wait for jobs
     *           in progress to finish before forcefully removing nodes (and potentially
     *           interrupting jobs). Default timeout is 0 (for forceful decommission), and
     *           the maximum allowed timeout is 1 day (see JSON representation of
     *           [Duration](https://developers.google.com/protocol-buffers/docs/proto3#json)).
     *           Only supported on Dataproc image versions 1.2 and higher.
     *     @type \Google\Protobuf\FieldMask $update_mask
     *           Required. Specifies the path, relative to `Cluster`, of
     *           the field to update. For example, to change the number of workers
     *           in a cluster to 5, the `update_mask` parameter would be
     *           specified as `config.worker_config.num_instances`,
     *           and the `PATCH` request body would specify the new value, as follows:
     *               {
     *                 "config":{
     *                   "workerConfig":{
     *                     "numInstances":"5"
     *                   }
     *                 }
     *               }
     *           Similarly, to change the number of preemptible workers in a cluster to 5,
     *           the `update_mask` parameter would be
     *           `config.secondary_worker_config.num_instances`, and the `PATCH` request
     *           body would be set as follows:
     *               {
     *                 "config":{
     *                   "secondaryWorkerConfig":{
     *                     "numInstances":"5"
     *                   }
     *                 }
     *               }
     *           <strong>Note:</strong> currently only the following fields can be updated:
     *           <table>
     *           <tr>
     *           <td><strong>Mask</strong></td><td><strong>Purpose</strong></td>
     *           </tr>
     *           <tr>
     *           <td>labels</td><td>Updates labels</td>
     *           </tr>
     *           <tr>
     *           <td>config.worker_config.num_instances</td><td>Resize primary worker
     *           group</td>
     *           </tr>
     *           <tr>
     *           <td>config.secondary_worker_config.num_instances</td><td>Resize secondary
     *           worker group</td>
     *           </tr>
     *           <tr>
     *           <td>config.lifecycle_config.auto_delete_ttl</td><td>Reset MAX TTL
     *           duration</td>
     *           </tr>
     *           <tr>
     *           <td>config.lifecycle_config.auto_delete_time</td><td>Update MAX TTL
     *           deletion timestamp</td>
     *           </tr>
     *           <tr>
     *           <td>config.lifecycle_config.idle_delete_ttl</td><td>Update Idle TTL
     *           duration</td>
     *           </tr>
     *           <tr>
     *           <td>config.autoscaling_config.policy_uri</td><td>Use, stop using, or change
     *           autoscaling policies</td>
     *           </tr>
     *           </table>
     *     @type string $request_id
     *           Optional. A unique id used to identify the request. If the server
     *           receives two
     *           [UpdateClusterRequest][google.cloud.dataproc.v1beta2.UpdateClusterRequest]
     *           requests  with the same id, then the second request will be ignored and the
     *           first [google.longrunning.Operation][google.longrunning.Operation] created
     *           and stored in the backend is returned.
     *           It is recommended to always set this value to a
     *           [UUID](https://en.wikipedia.org/wiki/Universally_unique_identifier).
     *           The id must contain only letters (a-z, A-Z), numbers (0-9),
     *           underscores (_), and hyphens (-). The maximum length is 40 characters.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Dataproc\V1Beta2\Clusters::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The ID of the Google Cloud Platform project the
     * cluster belongs to.
     *
     * Generated from protobuf field <code>string project_id = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return string
     */
    public function getProjectId()
    {
        return $this->project_id;
    }

    /**
     * Required. The ID of the Google Cloud Platform project the
     * cluster belongs to.
     *
     * Generated from protobuf field <code>string project_id = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param string $var
     * @return $this
     */
    public function setProjectId($var)
    {
        GPBUtil::checkString($var, True);
        $this->project_id = $var;

        return $this;
    }

    /**
     * Required. The Dataproc region in which to handle the request.
     *
     * Generated from protobuf field <code>string region = 5 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return string
     */
    public function getRegion()
    {
        return $this->region;
    }

    /**
     * Required. The Dataproc region in which to handle the request.
     *
     * Generated from protobuf field <code>string region = 5 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param string $var
     * @return $this
     */
    public function setRegion($var)
    {
        GPBUtil::checkString($var, True);
        $this->region = $var;

        return $this;
    }

    /**
     * Required. The cluster name.
     *
     * Generated from protobuf field <code>string cluster_name = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return string
     */
    public function getClusterName()
    {
        return $this->cluster_name;
    }

    /**
     * Required. The cluster name.
     *
     * Generated from protobuf field <code>string cluster_name = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param string $var
     * @return $this
     */
    public function setClusterName($var)
    {
        GPBUtil::checkString($var, True);
        $this->cluster_name = $var;

        return $this;
    }

    /**
     * Required. The changes to the cluster.
     *
     * Generated from protobuf field <code>.google.cloud.dataproc.v1beta2.Cluster cluster = 3 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Cloud\Dataproc\V1beta2\Cluster|null
     */
    public function getCluster()
    {
        return isset($this->cluster) ? $this->cluster : null;
    }

    public function hasCluster()
    {
        return isset($this->cluster);
    }

    public function clearCluster()
    {
        unset($this->cluster);
    }

    /**
     * Required. The changes to the cluster.
     *
     * Generated from protobuf field <code>.google.cloud.dataproc.v1beta2.Cluster cluster = 3 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param \Google\Cloud\Dataproc\V1beta2\Cluster $var
     * @return $this
     */
    public function setCluster($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Dataproc\V1beta2\Cluster::class);
        $this->cluster = $var;

        return $this;
    }

    /**
     * Optional. Timeout for graceful YARN decomissioning. Graceful
     * decommissioning allows removing nodes from the cluster without
     * interrupting jobs in progress. Timeout specifies how long to wait for jobs
     * in progress to finish before forcefully removing nodes (and potentially
     * interrupting jobs). Default timeout is 0 (for forceful decommission), and
     * the maximum allowed timeout is 1 day (see JSON representation of
     * [Duration](https://developers.google.com/protocol-buffers/docs/proto3#json)).
     * Only supported on Dataproc image versions 1.2 and higher.
     *
     * Generated from protobuf field <code>.google.protobuf.Duration graceful_decommission_timeout = 6 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @return \Google\Protobuf\Duration|null
     */
    public function getGracefulDecommissionTimeout()
    {
        return isset($this->graceful_decommission_timeout) ? $this->graceful_decommission_timeout : null;
    }

    public function hasGracefulDecommissionTimeout()
    {
        return isset($this->graceful_decommission_timeout);
    }

    public function clearGracefulDecommissionTimeout()
    {
        unset($this->graceful_decommission_timeout);
    }

    /**
     * Optional. Timeout for graceful YARN decomissioning. Graceful
     * decommissioning allows removing nodes from the cluster without
     * interrupting jobs in progress. Timeout specifies how long to wait for jobs
     * in progress to finish before forcefully removing nodes (and potentially
     * interrupting jobs). Default timeout is 0 (for forceful decommission), and
     * the maximum allowed timeout is 1 day (see JSON representation of
     * [Duration](https://developers.google.com/protocol-buffers/docs/proto3#json)).
     * Only supported on Dataproc image versions 1.2 and higher.
     *
     * Generated from protobuf field <code>.google.protobuf.Duration graceful_decommission_timeout = 6 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @param \Google\Protobuf\Duration $var
     * @return $this
     */
    public function setGracefulDecommissionTimeout($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Duration::class);
        $this->graceful_decommission_timeout = $var;

        return $this;
    }

    /**
     * Required. Specifies the path, relative to `Cluster`, of
     * the field to update. For example, to change the number of workers
     * in a cluster to 5, the `update_mask` parameter would be
     * specified as `config.worker_config.num_instances`,
     * and the `PATCH` request body would specify the new value, as follows:
     *     {
     *       "config":{
     *         "workerConfig":{
     *           "numInstances":"5"
     *         }
     *       }
     *     }
     * Similarly, to change the number of preemptible workers in a cluster to 5,
     * the `update_mask` parameter would be
     * `config.secondary_worker_config.num_instances`, and the `PATCH` request
     * body would be set as follows:
     *     {
     *       "config":{
     *         "secondaryWorkerConfig":{
     *           "numInstances":"5"
     *         }
     *       }
     *     }
     * <strong>Note:</strong> currently only the following fields can be updated:
     * <table>
     * <tr>
     * <td><strong>Mask</strong></td><td><strong>Purpose</strong></td>
     * </tr>
     * <tr>
     * <td>labels</td><td>Updates labels</td>
     * </tr>
     * <tr>
     * <td>config.worker_config.num_instances</td><td>Resize primary worker
     * group</td>
     * </tr>
     * <tr>
     * <td>config.secondary_worker_config.num_instances</td><td>Resize secondary
     * worker group</td>
     * </tr>
     * <tr>
     * <td>config.lifecycle_config.auto_delete_ttl</td><td>Reset MAX TTL
     * duration</td>
     * </tr>
     * <tr>
     * <td>config.lifecycle_config.auto_delete_time</td><td>Update MAX TTL
     * deletion timestamp</td>
     * </tr>
     * <tr>
     * <td>config.lifecycle_config.idle_delete_ttl</td><td>Update Idle TTL
     * duration</td>
     * </tr>
     * <tr>
     * <td>config.autoscaling_config.policy_uri</td><td>Use, stop using, or change
     * autoscaling policies</td>
     * </tr>
     * </table>
     *
     * Generated from protobuf field <code>.google.protobuf.FieldMask update_mask = 4 [(.google.api.field_behavior) = REQUIRED];</code>
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
     * Required. Specifies the path, relative to `Cluster`, of
     * the field to update. For example, to change the number of workers
     * in a cluster to 5, the `update_mask` parameter would be
     * specified as `config.worker_config.num_instances`,
     * and the `PATCH` request body would specify the new value, as follows:
     *     {
     *       "config":{
     *         "workerConfig":{
     *           "numInstances":"5"
     *         }
     *       }
     *     }
     * Similarly, to change the number of preemptible workers in a cluster to 5,
     * the `update_mask` parameter would be
     * `config.secondary_worker_config.num_instances`, and the `PATCH` request
     * body would be set as follows:
     *     {
     *       "config":{
     *         "secondaryWorkerConfig":{
     *           "numInstances":"5"
     *         }
     *       }
     *     }
     * <strong>Note:</strong> currently only the following fields can be updated:
     * <table>
     * <tr>
     * <td><strong>Mask</strong></td><td><strong>Purpose</strong></td>
     * </tr>
     * <tr>
     * <td>labels</td><td>Updates labels</td>
     * </tr>
     * <tr>
     * <td>config.worker_config.num_instances</td><td>Resize primary worker
     * group</td>
     * </tr>
     * <tr>
     * <td>config.secondary_worker_config.num_instances</td><td>Resize secondary
     * worker group</td>
     * </tr>
     * <tr>
     * <td>config.lifecycle_config.auto_delete_ttl</td><td>Reset MAX TTL
     * duration</td>
     * </tr>
     * <tr>
     * <td>config.lifecycle_config.auto_delete_time</td><td>Update MAX TTL
     * deletion timestamp</td>
     * </tr>
     * <tr>
     * <td>config.lifecycle_config.idle_delete_ttl</td><td>Update Idle TTL
     * duration</td>
     * </tr>
     * <tr>
     * <td>config.autoscaling_config.policy_uri</td><td>Use, stop using, or change
     * autoscaling policies</td>
     * </tr>
     * </table>
     *
     * Generated from protobuf field <code>.google.protobuf.FieldMask update_mask = 4 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param \Google\Protobuf\FieldMask $var
     * @return $this
     */
    public function setUpdateMask($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\FieldMask::class);
        $this->update_mask = $var;

        return $this;
    }

    /**
     * Optional. A unique id used to identify the request. If the server
     * receives two
     * [UpdateClusterRequest][google.cloud.dataproc.v1beta2.UpdateClusterRequest]
     * requests  with the same id, then the second request will be ignored and the
     * first [google.longrunning.Operation][google.longrunning.Operation] created
     * and stored in the backend is returned.
     * It is recommended to always set this value to a
     * [UUID](https://en.wikipedia.org/wiki/Universally_unique_identifier).
     * The id must contain only letters (a-z, A-Z), numbers (0-9),
     * underscores (_), and hyphens (-). The maximum length is 40 characters.
     *
     * Generated from protobuf field <code>string request_id = 7 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @return string
     */
    public function getRequestId()
    {
        return $this->request_id;
    }

    /**
     * Optional. A unique id used to identify the request. If the server
     * receives two
     * [UpdateClusterRequest][google.cloud.dataproc.v1beta2.UpdateClusterRequest]
     * requests  with the same id, then the second request will be ignored and the
     * first [google.longrunning.Operation][google.longrunning.Operation] created
     * and stored in the backend is returned.
     * It is recommended to always set this value to a
     * [UUID](https://en.wikipedia.org/wiki/Universally_unique_identifier).
     * The id must contain only letters (a-z, A-Z), numbers (0-9),
     * underscores (_), and hyphens (-). The maximum length is 40 characters.
     *
     * Generated from protobuf field <code>string request_id = 7 [(.google.api.field_behavior) = OPTIONAL];</code>
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

