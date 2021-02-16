<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dialogflow/cx/v3/security_settings.proto

namespace Google\Cloud\Dialogflow\Cx\V3;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * Represents the settings related to security issues, such as data redaction
 * and data retention. It may take hours for updates on the settings to
 * propagate to all the related components and take effect.
 *
 * Generated from protobuf message <code>google.cloud.dialogflow.cx.v3.SecuritySettings</code>
 */
class SecuritySettings extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. Resource name of the settings.
     * Format: `projects/<Project ID>/locations/<Location
     * ID>/securitySettings/<Security Settings ID>`.
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $name = '';
    /**
     * Required. The human-readable name of the security settings, unique within the
     * location.
     *
     * Generated from protobuf field <code>string display_name = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $display_name = '';
    /**
     * Strategy that defines how we do redaction.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.SecuritySettings.RedactionStrategy redaction_strategy = 3;</code>
     */
    protected $redaction_strategy = 0;
    /**
     * Defines on what data we apply redaction. Note that we don't
     * redact data to which we don't have access, e.g., Stackdriver logs.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.SecuritySettings.RedactionScope redaction_scope = 4;</code>
     */
    protected $redaction_scope = 0;
    /**
     * DLP inspect template name. Use this template to define inspect base
     * settings.
     * If empty, we use the default DLP inspect config.
     * The template name will have one of the following formats:
     * `projects/PROJECT_ID/inspectTemplates/TEMPLATE_ID` OR
     * `organizations/ORGANIZATION_ID/inspectTemplates/TEMPLATE_ID`
     *
     * Generated from protobuf field <code>string inspect_template = 9;</code>
     */
    protected $inspect_template = '';
    /**
     * List of types of data to remove when retention settings triggers purge.
     *
     * Generated from protobuf field <code>repeated .google.cloud.dialogflow.cx.v3.SecuritySettings.PurgeDataType purge_data_types = 8;</code>
     */
    private $purge_data_types;
    protected $data_retention;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $name
     *           Required. Resource name of the settings.
     *           Format: `projects/<Project ID>/locations/<Location
     *           ID>/securitySettings/<Security Settings ID>`.
     *     @type string $display_name
     *           Required. The human-readable name of the security settings, unique within the
     *           location.
     *     @type int $redaction_strategy
     *           Strategy that defines how we do redaction.
     *     @type int $redaction_scope
     *           Defines on what data we apply redaction. Note that we don't
     *           redact data to which we don't have access, e.g., Stackdriver logs.
     *     @type string $inspect_template
     *           DLP inspect template name. Use this template to define inspect base
     *           settings.
     *           If empty, we use the default DLP inspect config.
     *           The template name will have one of the following formats:
     *           `projects/PROJECT_ID/inspectTemplates/TEMPLATE_ID` OR
     *           `organizations/ORGANIZATION_ID/inspectTemplates/TEMPLATE_ID`
     *     @type int $retention_window_days
     *           Retains the data for the specified number of days.
     *           User must Set a value lower than Dialogflow's default 30d TTL. Setting a
     *           value higher than that has no effect.
     *           A missing value or setting to 0 also means we use Dialogflow's default
     *           TTL.
     *     @type int[]|\Google\Protobuf\Internal\RepeatedField $purge_data_types
     *           List of types of data to remove when retention settings triggers purge.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Cloud\Dialogflow\Cx\V3\SecuritySettings::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. Resource name of the settings.
     * Format: `projects/<Project ID>/locations/<Location
     * ID>/securitySettings/<Security Settings ID>`.
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return string
     */
    public function getName()
    {
        return $this->name;
    }

    /**
     * Required. Resource name of the settings.
     * Format: `projects/<Project ID>/locations/<Location
     * ID>/securitySettings/<Security Settings ID>`.
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = REQUIRED];</code>
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
     * Required. The human-readable name of the security settings, unique within the
     * location.
     *
     * Generated from protobuf field <code>string display_name = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return string
     */
    public function getDisplayName()
    {
        return $this->display_name;
    }

    /**
     * Required. The human-readable name of the security settings, unique within the
     * location.
     *
     * Generated from protobuf field <code>string display_name = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param string $var
     * @return $this
     */
    public function setDisplayName($var)
    {
        GPBUtil::checkString($var, True);
        $this->display_name = $var;

        return $this;
    }

    /**
     * Strategy that defines how we do redaction.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.SecuritySettings.RedactionStrategy redaction_strategy = 3;</code>
     * @return int
     */
    public function getRedactionStrategy()
    {
        return $this->redaction_strategy;
    }

    /**
     * Strategy that defines how we do redaction.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.SecuritySettings.RedactionStrategy redaction_strategy = 3;</code>
     * @param int $var
     * @return $this
     */
    public function setRedactionStrategy($var)
    {
        GPBUtil::checkEnum($var, \Google\Cloud\Dialogflow\Cx\V3\SecuritySettings\RedactionStrategy::class);
        $this->redaction_strategy = $var;

        return $this;
    }

    /**
     * Defines on what data we apply redaction. Note that we don't
     * redact data to which we don't have access, e.g., Stackdriver logs.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.SecuritySettings.RedactionScope redaction_scope = 4;</code>
     * @return int
     */
    public function getRedactionScope()
    {
        return $this->redaction_scope;
    }

    /**
     * Defines on what data we apply redaction. Note that we don't
     * redact data to which we don't have access, e.g., Stackdriver logs.
     *
     * Generated from protobuf field <code>.google.cloud.dialogflow.cx.v3.SecuritySettings.RedactionScope redaction_scope = 4;</code>
     * @param int $var
     * @return $this
     */
    public function setRedactionScope($var)
    {
        GPBUtil::checkEnum($var, \Google\Cloud\Dialogflow\Cx\V3\SecuritySettings\RedactionScope::class);
        $this->redaction_scope = $var;

        return $this;
    }

    /**
     * DLP inspect template name. Use this template to define inspect base
     * settings.
     * If empty, we use the default DLP inspect config.
     * The template name will have one of the following formats:
     * `projects/PROJECT_ID/inspectTemplates/TEMPLATE_ID` OR
     * `organizations/ORGANIZATION_ID/inspectTemplates/TEMPLATE_ID`
     *
     * Generated from protobuf field <code>string inspect_template = 9;</code>
     * @return string
     */
    public function getInspectTemplate()
    {
        return $this->inspect_template;
    }

    /**
     * DLP inspect template name. Use this template to define inspect base
     * settings.
     * If empty, we use the default DLP inspect config.
     * The template name will have one of the following formats:
     * `projects/PROJECT_ID/inspectTemplates/TEMPLATE_ID` OR
     * `organizations/ORGANIZATION_ID/inspectTemplates/TEMPLATE_ID`
     *
     * Generated from protobuf field <code>string inspect_template = 9;</code>
     * @param string $var
     * @return $this
     */
    public function setInspectTemplate($var)
    {
        GPBUtil::checkString($var, True);
        $this->inspect_template = $var;

        return $this;
    }

    /**
     * Retains the data for the specified number of days.
     * User must Set a value lower than Dialogflow's default 30d TTL. Setting a
     * value higher than that has no effect.
     * A missing value or setting to 0 also means we use Dialogflow's default
     * TTL.
     *
     * Generated from protobuf field <code>int32 retention_window_days = 6;</code>
     * @return int
     */
    public function getRetentionWindowDays()
    {
        return $this->readOneof(6);
    }

    public function hasRetentionWindowDays()
    {
        return $this->hasOneof(6);
    }

    /**
     * Retains the data for the specified number of days.
     * User must Set a value lower than Dialogflow's default 30d TTL. Setting a
     * value higher than that has no effect.
     * A missing value or setting to 0 also means we use Dialogflow's default
     * TTL.
     *
     * Generated from protobuf field <code>int32 retention_window_days = 6;</code>
     * @param int $var
     * @return $this
     */
    public function setRetentionWindowDays($var)
    {
        GPBUtil::checkInt32($var);
        $this->writeOneof(6, $var);

        return $this;
    }

    /**
     * List of types of data to remove when retention settings triggers purge.
     *
     * Generated from protobuf field <code>repeated .google.cloud.dialogflow.cx.v3.SecuritySettings.PurgeDataType purge_data_types = 8;</code>
     * @return \Google\Protobuf\Internal\RepeatedField
     */
    public function getPurgeDataTypes()
    {
        return $this->purge_data_types;
    }

    /**
     * List of types of data to remove when retention settings triggers purge.
     *
     * Generated from protobuf field <code>repeated .google.cloud.dialogflow.cx.v3.SecuritySettings.PurgeDataType purge_data_types = 8;</code>
     * @param int[]|\Google\Protobuf\Internal\RepeatedField $var
     * @return $this
     */
    public function setPurgeDataTypes($var)
    {
        $arr = GPBUtil::checkRepeatedField($var, \Google\Protobuf\Internal\GPBType::ENUM, \Google\Cloud\Dialogflow\Cx\V3\SecuritySettings\PurgeDataType::class);
        $this->purge_data_types = $arr;

        return $this;
    }

    /**
     * @return string
     */
    public function getDataRetention()
    {
        return $this->whichOneof("data_retention");
    }

}
