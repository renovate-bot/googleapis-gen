<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/datalabeling/v1beta1/evaluation.proto

namespace Google\Cloud\DataLabeling\V1beta1\ConfusionMatrix;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Generated from protobuf message <code>google.cloud.datalabeling.v1beta1.ConfusionMatrix.ConfusionMatrixEntry</code>
 */
class ConfusionMatrixEntry extends \Google\Protobuf\Internal\Message
{
    /**
     * The annotation spec of a predicted label.
     *
     * Generated from protobuf field <code>.google.cloud.datalabeling.v1beta1.AnnotationSpec annotation_spec = 1;</code>
     */
    protected $annotation_spec = null;
    /**
     * Number of items predicted to have this label. (The ground truth label for
     * these items is the `Row.annotationSpec` of this entry's parent.)
     *
     * Generated from protobuf field <code>int32 item_count = 2;</code>
     */
    protected $item_count = 0;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type \Google\Cloud\DataLabeling\V1beta1\AnnotationSpec $annotation_spec
     *           The annotation spec of a predicted label.
     *     @type int $item_count
     *           Number of items predicted to have this label. (The ground truth label for
     *           these items is the `Row.annotationSpec` of this entry's parent.)
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Datalabeling\V1Beta1\Evaluation::initOnce();
        parent::__construct($data);
    }

    /**
     * The annotation spec of a predicted label.
     *
     * Generated from protobuf field <code>.google.cloud.datalabeling.v1beta1.AnnotationSpec annotation_spec = 1;</code>
     * @return \Google\Cloud\DataLabeling\V1beta1\AnnotationSpec|null
     */
    public function getAnnotationSpec()
    {
        return isset($this->annotation_spec) ? $this->annotation_spec : null;
    }

    public function hasAnnotationSpec()
    {
        return isset($this->annotation_spec);
    }

    public function clearAnnotationSpec()
    {
        unset($this->annotation_spec);
    }

    /**
     * The annotation spec of a predicted label.
     *
     * Generated from protobuf field <code>.google.cloud.datalabeling.v1beta1.AnnotationSpec annotation_spec = 1;</code>
     * @param \Google\Cloud\DataLabeling\V1beta1\AnnotationSpec $var
     * @return $this
     */
    public function setAnnotationSpec($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\DataLabeling\V1beta1\AnnotationSpec::class);
        $this->annotation_spec = $var;

        return $this;
    }

    /**
     * Number of items predicted to have this label. (The ground truth label for
     * these items is the `Row.annotationSpec` of this entry's parent.)
     *
     * Generated from protobuf field <code>int32 item_count = 2;</code>
     * @return int
     */
    public function getItemCount()
    {
        return $this->item_count;
    }

    /**
     * Number of items predicted to have this label. (The ground truth label for
     * these items is the `Row.annotationSpec` of this entry's parent.)
     *
     * Generated from protobuf field <code>int32 item_count = 2;</code>
     * @param int $var
     * @return $this
     */
    public function setItemCount($var)
    {
        GPBUtil::checkInt32($var);
        $this->item_count = $var;

        return $this;
    }

}

// Adding a class alias for backwards compatibility with the previous class name.
class_alias(ConfusionMatrixEntry::class, \Google\Cloud\DataLabeling\V1beta1\ConfusionMatrix_ConfusionMatrixEntry::class);

