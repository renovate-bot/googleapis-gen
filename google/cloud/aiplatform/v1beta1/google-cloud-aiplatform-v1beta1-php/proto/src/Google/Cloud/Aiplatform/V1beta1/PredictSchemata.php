<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/aiplatform/v1beta1/model.proto

namespace Google\Cloud\Aiplatform\V1beta1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Contains the schemata used in Model's predictions and explanations via
 * [PredictionService.Predict][google.cloud.aiplatform.v1beta1.PredictionService.Predict], [PredictionService.Explain][google.cloud.aiplatform.v1beta1.PredictionService.Explain] and
 * [BatchPredictionJob][google.cloud.aiplatform.v1beta1.BatchPredictionJob].
 *
 * Generated from protobuf message <code>google.cloud.aiplatform.v1beta1.PredictSchemata</code>
 */
class PredictSchemata extends \Google\Protobuf\Internal\Message
{
    /**
     * Immutable. Points to a YAML file stored on Google Cloud Storage describing the format
     * of a single instance, which are used in [PredictRequest.instances][google.cloud.aiplatform.v1beta1.PredictRequest.instances],
     * [ExplainRequest.instances][google.cloud.aiplatform.v1beta1.ExplainRequest.instances] and
     * [BatchPredictionJob.input_config][google.cloud.aiplatform.v1beta1.BatchPredictionJob.input_config].
     * The schema is defined as an OpenAPI 3.0.2
     * [Schema Object](https://tinyurl.com/y538mdwt#schema-object).
     * AutoML Models always have this field populated by AI Platform.
     * Note: The URI given on output will be immutable and probably different,
     * including the URI scheme, than the one given on input. The output URI will
     * point to a location where the user only has a read access.
     *
     * Generated from protobuf field <code>string instance_schema_uri = 1 [(.google.api.field_behavior) = IMMUTABLE];</code>
     */
    protected $instance_schema_uri = '';
    /**
     * Immutable. Points to a YAML file stored on Google Cloud Storage describing the
     * parameters of prediction and explanation via
     * [PredictRequest.parameters][google.cloud.aiplatform.v1beta1.PredictRequest.parameters], [ExplainRequest.parameters][google.cloud.aiplatform.v1beta1.ExplainRequest.parameters] and
     * [BatchPredictionJob.model_parameters][google.cloud.aiplatform.v1beta1.BatchPredictionJob.model_parameters].
     * The schema is defined as an OpenAPI 3.0.2
     * [Schema Object](https://tinyurl.com/y538mdwt#schema-object).
     * AutoML Models always have this field populated by AI Platform, if no
     * parameters are supported, then it is set to an empty string.
     * Note: The URI given on output will be immutable and probably different,
     * including the URI scheme, than the one given on input. The output URI will
     * point to a location where the user only has a read access.
     *
     * Generated from protobuf field <code>string parameters_schema_uri = 2 [(.google.api.field_behavior) = IMMUTABLE];</code>
     */
    protected $parameters_schema_uri = '';
    /**
     * Immutable. Points to a YAML file stored on Google Cloud Storage describing the format
     * of a single prediction produced by this Model, which are returned via
     * [PredictResponse.predictions][google.cloud.aiplatform.v1beta1.PredictResponse.predictions], [ExplainResponse.explanations][google.cloud.aiplatform.v1beta1.ExplainResponse.explanations], and
     * [BatchPredictionJob.output_config][google.cloud.aiplatform.v1beta1.BatchPredictionJob.output_config].
     * The schema is defined as an OpenAPI 3.0.2
     * [Schema Object](https://tinyurl.com/y538mdwt#schema-object).
     * AutoML Models always have this field populated by AI Platform.
     * Note: The URI given on output will be immutable and probably different,
     * including the URI scheme, than the one given on input. The output URI will
     * point to a location where the user only has a read access.
     *
     * Generated from protobuf field <code>string prediction_schema_uri = 3 [(.google.api.field_behavior) = IMMUTABLE];</code>
     */
    protected $prediction_schema_uri = '';

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $instance_schema_uri
     *           Immutable. Points to a YAML file stored on Google Cloud Storage describing the format
     *           of a single instance, which are used in [PredictRequest.instances][google.cloud.aiplatform.v1beta1.PredictRequest.instances],
     *           [ExplainRequest.instances][google.cloud.aiplatform.v1beta1.ExplainRequest.instances] and
     *           [BatchPredictionJob.input_config][google.cloud.aiplatform.v1beta1.BatchPredictionJob.input_config].
     *           The schema is defined as an OpenAPI 3.0.2
     *           [Schema Object](https://tinyurl.com/y538mdwt#schema-object).
     *           AutoML Models always have this field populated by AI Platform.
     *           Note: The URI given on output will be immutable and probably different,
     *           including the URI scheme, than the one given on input. The output URI will
     *           point to a location where the user only has a read access.
     *     @type string $parameters_schema_uri
     *           Immutable. Points to a YAML file stored on Google Cloud Storage describing the
     *           parameters of prediction and explanation via
     *           [PredictRequest.parameters][google.cloud.aiplatform.v1beta1.PredictRequest.parameters], [ExplainRequest.parameters][google.cloud.aiplatform.v1beta1.ExplainRequest.parameters] and
     *           [BatchPredictionJob.model_parameters][google.cloud.aiplatform.v1beta1.BatchPredictionJob.model_parameters].
     *           The schema is defined as an OpenAPI 3.0.2
     *           [Schema Object](https://tinyurl.com/y538mdwt#schema-object).
     *           AutoML Models always have this field populated by AI Platform, if no
     *           parameters are supported, then it is set to an empty string.
     *           Note: The URI given on output will be immutable and probably different,
     *           including the URI scheme, than the one given on input. The output URI will
     *           point to a location where the user only has a read access.
     *     @type string $prediction_schema_uri
     *           Immutable. Points to a YAML file stored on Google Cloud Storage describing the format
     *           of a single prediction produced by this Model, which are returned via
     *           [PredictResponse.predictions][google.cloud.aiplatform.v1beta1.PredictResponse.predictions], [ExplainResponse.explanations][google.cloud.aiplatform.v1beta1.ExplainResponse.explanations], and
     *           [BatchPredictionJob.output_config][google.cloud.aiplatform.v1beta1.BatchPredictionJob.output_config].
     *           The schema is defined as an OpenAPI 3.0.2
     *           [Schema Object](https://tinyurl.com/y538mdwt#schema-object).
     *           AutoML Models always have this field populated by AI Platform.
     *           Note: The URI given on output will be immutable and probably different,
     *           including the URI scheme, than the one given on input. The output URI will
     *           point to a location where the user only has a read access.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Aiplatform\V1Beta1\Model::initOnce();
        parent::__construct($data);
    }

    /**
     * Immutable. Points to a YAML file stored on Google Cloud Storage describing the format
     * of a single instance, which are used in [PredictRequest.instances][google.cloud.aiplatform.v1beta1.PredictRequest.instances],
     * [ExplainRequest.instances][google.cloud.aiplatform.v1beta1.ExplainRequest.instances] and
     * [BatchPredictionJob.input_config][google.cloud.aiplatform.v1beta1.BatchPredictionJob.input_config].
     * The schema is defined as an OpenAPI 3.0.2
     * [Schema Object](https://tinyurl.com/y538mdwt#schema-object).
     * AutoML Models always have this field populated by AI Platform.
     * Note: The URI given on output will be immutable and probably different,
     * including the URI scheme, than the one given on input. The output URI will
     * point to a location where the user only has a read access.
     *
     * Generated from protobuf field <code>string instance_schema_uri = 1 [(.google.api.field_behavior) = IMMUTABLE];</code>
     * @return string
     */
    public function getInstanceSchemaUri()
    {
        return $this->instance_schema_uri;
    }

    /**
     * Immutable. Points to a YAML file stored on Google Cloud Storage describing the format
     * of a single instance, which are used in [PredictRequest.instances][google.cloud.aiplatform.v1beta1.PredictRequest.instances],
     * [ExplainRequest.instances][google.cloud.aiplatform.v1beta1.ExplainRequest.instances] and
     * [BatchPredictionJob.input_config][google.cloud.aiplatform.v1beta1.BatchPredictionJob.input_config].
     * The schema is defined as an OpenAPI 3.0.2
     * [Schema Object](https://tinyurl.com/y538mdwt#schema-object).
     * AutoML Models always have this field populated by AI Platform.
     * Note: The URI given on output will be immutable and probably different,
     * including the URI scheme, than the one given on input. The output URI will
     * point to a location where the user only has a read access.
     *
     * Generated from protobuf field <code>string instance_schema_uri = 1 [(.google.api.field_behavior) = IMMUTABLE];</code>
     * @param string $var
     * @return $this
     */
    public function setInstanceSchemaUri($var)
    {
        GPBUtil::checkString($var, True);
        $this->instance_schema_uri = $var;

        return $this;
    }

    /**
     * Immutable. Points to a YAML file stored on Google Cloud Storage describing the
     * parameters of prediction and explanation via
     * [PredictRequest.parameters][google.cloud.aiplatform.v1beta1.PredictRequest.parameters], [ExplainRequest.parameters][google.cloud.aiplatform.v1beta1.ExplainRequest.parameters] and
     * [BatchPredictionJob.model_parameters][google.cloud.aiplatform.v1beta1.BatchPredictionJob.model_parameters].
     * The schema is defined as an OpenAPI 3.0.2
     * [Schema Object](https://tinyurl.com/y538mdwt#schema-object).
     * AutoML Models always have this field populated by AI Platform, if no
     * parameters are supported, then it is set to an empty string.
     * Note: The URI given on output will be immutable and probably different,
     * including the URI scheme, than the one given on input. The output URI will
     * point to a location where the user only has a read access.
     *
     * Generated from protobuf field <code>string parameters_schema_uri = 2 [(.google.api.field_behavior) = IMMUTABLE];</code>
     * @return string
     */
    public function getParametersSchemaUri()
    {
        return $this->parameters_schema_uri;
    }

    /**
     * Immutable. Points to a YAML file stored on Google Cloud Storage describing the
     * parameters of prediction and explanation via
     * [PredictRequest.parameters][google.cloud.aiplatform.v1beta1.PredictRequest.parameters], [ExplainRequest.parameters][google.cloud.aiplatform.v1beta1.ExplainRequest.parameters] and
     * [BatchPredictionJob.model_parameters][google.cloud.aiplatform.v1beta1.BatchPredictionJob.model_parameters].
     * The schema is defined as an OpenAPI 3.0.2
     * [Schema Object](https://tinyurl.com/y538mdwt#schema-object).
     * AutoML Models always have this field populated by AI Platform, if no
     * parameters are supported, then it is set to an empty string.
     * Note: The URI given on output will be immutable and probably different,
     * including the URI scheme, than the one given on input. The output URI will
     * point to a location where the user only has a read access.
     *
     * Generated from protobuf field <code>string parameters_schema_uri = 2 [(.google.api.field_behavior) = IMMUTABLE];</code>
     * @param string $var
     * @return $this
     */
    public function setParametersSchemaUri($var)
    {
        GPBUtil::checkString($var, True);
        $this->parameters_schema_uri = $var;

        return $this;
    }

    /**
     * Immutable. Points to a YAML file stored on Google Cloud Storage describing the format
     * of a single prediction produced by this Model, which are returned via
     * [PredictResponse.predictions][google.cloud.aiplatform.v1beta1.PredictResponse.predictions], [ExplainResponse.explanations][google.cloud.aiplatform.v1beta1.ExplainResponse.explanations], and
     * [BatchPredictionJob.output_config][google.cloud.aiplatform.v1beta1.BatchPredictionJob.output_config].
     * The schema is defined as an OpenAPI 3.0.2
     * [Schema Object](https://tinyurl.com/y538mdwt#schema-object).
     * AutoML Models always have this field populated by AI Platform.
     * Note: The URI given on output will be immutable and probably different,
     * including the URI scheme, than the one given on input. The output URI will
     * point to a location where the user only has a read access.
     *
     * Generated from protobuf field <code>string prediction_schema_uri = 3 [(.google.api.field_behavior) = IMMUTABLE];</code>
     * @return string
     */
    public function getPredictionSchemaUri()
    {
        return $this->prediction_schema_uri;
    }

    /**
     * Immutable. Points to a YAML file stored on Google Cloud Storage describing the format
     * of a single prediction produced by this Model, which are returned via
     * [PredictResponse.predictions][google.cloud.aiplatform.v1beta1.PredictResponse.predictions], [ExplainResponse.explanations][google.cloud.aiplatform.v1beta1.ExplainResponse.explanations], and
     * [BatchPredictionJob.output_config][google.cloud.aiplatform.v1beta1.BatchPredictionJob.output_config].
     * The schema is defined as an OpenAPI 3.0.2
     * [Schema Object](https://tinyurl.com/y538mdwt#schema-object).
     * AutoML Models always have this field populated by AI Platform.
     * Note: The URI given on output will be immutable and probably different,
     * including the URI scheme, than the one given on input. The output URI will
     * point to a location where the user only has a read access.
     *
     * Generated from protobuf field <code>string prediction_schema_uri = 3 [(.google.api.field_behavior) = IMMUTABLE];</code>
     * @param string $var
     * @return $this
     */
    public function setPredictionSchemaUri($var)
    {
        GPBUtil::checkString($var, True);
        $this->prediction_schema_uri = $var;

        return $this;
    }

}

