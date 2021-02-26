<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/aiplatform/v1beta1/explanation.proto

namespace Google\Cloud\Aiplatform\V1beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Config for SmoothGrad approximation of gradients.
 * When enabled, the gradients are approximated by averaging the gradients from
 * noisy samples in the vicinity of the inputs. Adding noise can help improve
 * the computed gradients. Refer to this paper for more details:
 * https://arxiv.org/pdf/1706.03825.pdf
 *
 * Generated from protobuf message <code>google.cloud.aiplatform.v1beta1.SmoothGradConfig</code>
 */
class SmoothGradConfig extends \Google\Protobuf\Internal\Message
{
    /**
     * The number of gradient samples to use for
     * approximation. The higher this number, the more accurate the gradient
     * is, but the runtime complexity increases by this factor as well.
     * Valid range of its value is [1, 50]. Defaults to 3.
     *
     * Generated from protobuf field <code>int32 noisy_sample_count = 3;</code>
     */
    protected $noisy_sample_count = 0;
    protected $GradientNoiseSigma;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type float $noise_sigma
     *           This is a single float value and will be used to add noise to all the
     *           features. Use this field when all features are normalized to have the
     *           same distribution: scale to range [0, 1], [-1, 1] or z-scoring, where
     *           features are normalized to have 0-mean and 1-variance. For more details
     *           about normalization:
     *           https://tinyurl.com/dgc-normalization.
     *           For best results the recommended value is about 10% - 20% of the standard
     *           deviation of the input feature. Refer to section 3.2 of the SmoothGrad
     *           paper: https://arxiv.org/pdf/1706.03825.pdf. Defaults to 0.1.
     *           If the distribution is different per feature, set
     *           [feature_noise_sigma][google.cloud.aiplatform.v1beta1.SmoothGradConfig.feature_noise_sigma] instead
     *           for each feature.
     *     @type \Google\Cloud\Aiplatform\V1beta1\FeatureNoiseSigma $feature_noise_sigma
     *           This is similar to [noise_sigma][google.cloud.aiplatform.v1beta1.SmoothGradConfig.noise_sigma], but
     *           provides additional flexibility. A separate noise sigma can be provided
     *           for each feature, which is useful if their distributions are different.
     *           No noise is added to features that are not set. If this field is unset,
     *           [noise_sigma][google.cloud.aiplatform.v1beta1.SmoothGradConfig.noise_sigma] will be used for all
     *           features.
     *     @type int $noisy_sample_count
     *           The number of gradient samples to use for
     *           approximation. The higher this number, the more accurate the gradient
     *           is, but the runtime complexity increases by this factor as well.
     *           Valid range of its value is [1, 50]. Defaults to 3.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Aiplatform\V1Beta1\Explanation::initOnce();
        parent::__construct($data);
    }

    /**
     * This is a single float value and will be used to add noise to all the
     * features. Use this field when all features are normalized to have the
     * same distribution: scale to range [0, 1], [-1, 1] or z-scoring, where
     * features are normalized to have 0-mean and 1-variance. For more details
     * about normalization:
     * https://tinyurl.com/dgc-normalization.
     * For best results the recommended value is about 10% - 20% of the standard
     * deviation of the input feature. Refer to section 3.2 of the SmoothGrad
     * paper: https://arxiv.org/pdf/1706.03825.pdf. Defaults to 0.1.
     * If the distribution is different per feature, set
     * [feature_noise_sigma][google.cloud.aiplatform.v1beta1.SmoothGradConfig.feature_noise_sigma] instead
     * for each feature.
     *
     * Generated from protobuf field <code>float noise_sigma = 1;</code>
     * @return float
     */
    public function getNoiseSigma()
    {
        return $this->readOneof(1);
    }

    public function hasNoiseSigma()
    {
        return $this->hasOneof(1);
    }

    /**
     * This is a single float value and will be used to add noise to all the
     * features. Use this field when all features are normalized to have the
     * same distribution: scale to range [0, 1], [-1, 1] or z-scoring, where
     * features are normalized to have 0-mean and 1-variance. For more details
     * about normalization:
     * https://tinyurl.com/dgc-normalization.
     * For best results the recommended value is about 10% - 20% of the standard
     * deviation of the input feature. Refer to section 3.2 of the SmoothGrad
     * paper: https://arxiv.org/pdf/1706.03825.pdf. Defaults to 0.1.
     * If the distribution is different per feature, set
     * [feature_noise_sigma][google.cloud.aiplatform.v1beta1.SmoothGradConfig.feature_noise_sigma] instead
     * for each feature.
     *
     * Generated from protobuf field <code>float noise_sigma = 1;</code>
     * @param float $var
     * @return $this
     */
    public function setNoiseSigma($var)
    {
        GPBUtil::checkFloat($var);
        $this->writeOneof(1, $var);

        return $this;
    }

    /**
     * This is similar to [noise_sigma][google.cloud.aiplatform.v1beta1.SmoothGradConfig.noise_sigma], but
     * provides additional flexibility. A separate noise sigma can be provided
     * for each feature, which is useful if their distributions are different.
     * No noise is added to features that are not set. If this field is unset,
     * [noise_sigma][google.cloud.aiplatform.v1beta1.SmoothGradConfig.noise_sigma] will be used for all
     * features.
     *
     * Generated from protobuf field <code>.google.cloud.aiplatform.v1beta1.FeatureNoiseSigma feature_noise_sigma = 2;</code>
     * @return \Google\Cloud\Aiplatform\V1beta1\FeatureNoiseSigma|null
     */
    public function getFeatureNoiseSigma()
    {
        return $this->readOneof(2);
    }

    public function hasFeatureNoiseSigma()
    {
        return $this->hasOneof(2);
    }

    /**
     * This is similar to [noise_sigma][google.cloud.aiplatform.v1beta1.SmoothGradConfig.noise_sigma], but
     * provides additional flexibility. A separate noise sigma can be provided
     * for each feature, which is useful if their distributions are different.
     * No noise is added to features that are not set. If this field is unset,
     * [noise_sigma][google.cloud.aiplatform.v1beta1.SmoothGradConfig.noise_sigma] will be used for all
     * features.
     *
     * Generated from protobuf field <code>.google.cloud.aiplatform.v1beta1.FeatureNoiseSigma feature_noise_sigma = 2;</code>
     * @param \Google\Cloud\Aiplatform\V1beta1\FeatureNoiseSigma $var
     * @return $this
     */
    public function setFeatureNoiseSigma($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Aiplatform\V1beta1\FeatureNoiseSigma::class);
        $this->writeOneof(2, $var);

        return $this;
    }

    /**
     * The number of gradient samples to use for
     * approximation. The higher this number, the more accurate the gradient
     * is, but the runtime complexity increases by this factor as well.
     * Valid range of its value is [1, 50]. Defaults to 3.
     *
     * Generated from protobuf field <code>int32 noisy_sample_count = 3;</code>
     * @return int
     */
    public function getNoisySampleCount()
    {
        return $this->noisy_sample_count;
    }

    /**
     * The number of gradient samples to use for
     * approximation. The higher this number, the more accurate the gradient
     * is, but the runtime complexity increases by this factor as well.
     * Valid range of its value is [1, 50]. Defaults to 3.
     *
     * Generated from protobuf field <code>int32 noisy_sample_count = 3;</code>
     * @param int $var
     * @return $this
     */
    public function setNoisySampleCount($var)
    {
        GPBUtil::checkInt32($var);
        $this->noisy_sample_count = $var;

        return $this;
    }

    /**
     * @return string
     */
    public function getGradientNoiseSigma()
    {
        return $this->whichOneof("GradientNoiseSigma");
    }

}

