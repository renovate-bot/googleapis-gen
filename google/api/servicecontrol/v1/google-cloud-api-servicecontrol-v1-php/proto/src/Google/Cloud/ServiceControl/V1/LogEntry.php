<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/api/servicecontrol/v1/log_entry.proto

namespace Google\Cloud\ServiceControl\V1;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * An individual log entry.
 *
 * Generated from protobuf message <code>google.api.servicecontrol.v1.LogEntry</code>
 */
class LogEntry extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The log to which this log entry belongs. Examples: `"syslog"`,
     * `"book_log"`.
     *
     * Generated from protobuf field <code>string name = 10;</code>
     */
    protected $name = '';
    /**
     * The time the event described by the log entry occurred. If
     * omitted, defaults to operation start time.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp timestamp = 11;</code>
     */
    protected $timestamp = null;
    /**
     * The severity of the log entry. The default value is
     * `LogSeverity.DEFAULT`.
     *
     * Generated from protobuf field <code>.google.logging.type.LogSeverity severity = 12;</code>
     */
    protected $severity = 0;
    /**
     * Optional. Information about the HTTP request associated with this
     * log entry, if applicable.
     *
     * Generated from protobuf field <code>.google.api.servicecontrol.v1.HttpRequest http_request = 14;</code>
     */
    protected $http_request = null;
    /**
     * Optional. Resource name of the trace associated with the log entry, if any.
     * If this field contains a relative resource name, you can assume the name is
     * relative to `//tracing.googleapis.com`. Example:
     * `projects/my-projectid/traces/06796866738c859f2f19b7cfb3214824`
     *
     * Generated from protobuf field <code>string trace = 15;</code>
     */
    protected $trace = '';
    /**
     * A unique ID for the log entry used for deduplication. If omitted,
     * the implementation will generate one based on operation_id.
     *
     * Generated from protobuf field <code>string insert_id = 4;</code>
     */
    protected $insert_id = '';
    /**
     * A set of user-defined (key, value) data that provides additional
     * information about the log entry.
     *
     * Generated from protobuf field <code>map<string, string> labels = 13;</code>
     */
    private $labels;
    /**
     * Optional. Information about an operation associated with the log entry, if
     * applicable.
     *
     * Generated from protobuf field <code>.google.api.servicecontrol.v1.LogEntryOperation operation = 16;</code>
     */
    protected $operation = null;
    /**
     * Optional. Source code location information associated with the log entry,
     * if any.
     *
     * Generated from protobuf field <code>.google.api.servicecontrol.v1.LogEntrySourceLocation source_location = 17;</code>
     */
    protected $source_location = null;
    protected $payload;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $name
     *           Required. The log to which this log entry belongs. Examples: `"syslog"`,
     *           `"book_log"`.
     *     @type \Google\Protobuf\Timestamp $timestamp
     *           The time the event described by the log entry occurred. If
     *           omitted, defaults to operation start time.
     *     @type int $severity
     *           The severity of the log entry. The default value is
     *           `LogSeverity.DEFAULT`.
     *     @type \Google\Cloud\ServiceControl\V1\HttpRequest $http_request
     *           Optional. Information about the HTTP request associated with this
     *           log entry, if applicable.
     *     @type string $trace
     *           Optional. Resource name of the trace associated with the log entry, if any.
     *           If this field contains a relative resource name, you can assume the name is
     *           relative to `//tracing.googleapis.com`. Example:
     *           `projects/my-projectid/traces/06796866738c859f2f19b7cfb3214824`
     *     @type string $insert_id
     *           A unique ID for the log entry used for deduplication. If omitted,
     *           the implementation will generate one based on operation_id.
     *     @type array|\Google\Protobuf\Internal\MapField $labels
     *           A set of user-defined (key, value) data that provides additional
     *           information about the log entry.
     *     @type \Google\Protobuf\Any $proto_payload
     *           The log entry payload, represented as a protocol buffer that is
     *           expressed as a JSON object. The only accepted type currently is
     *           [AuditLog][google.cloud.audit.AuditLog].
     *     @type string $text_payload
     *           The log entry payload, represented as a Unicode string (UTF-8).
     *     @type \Google\Protobuf\Struct $struct_payload
     *           The log entry payload, represented as a structure that
     *           is expressed as a JSON object.
     *     @type \Google\Cloud\ServiceControl\V1\LogEntryOperation $operation
     *           Optional. Information about an operation associated with the log entry, if
     *           applicable.
     *     @type \Google\Cloud\ServiceControl\V1\LogEntrySourceLocation $source_location
     *           Optional. Source code location information associated with the log entry,
     *           if any.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Api\Servicecontrol\V1\LogEntry::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The log to which this log entry belongs. Examples: `"syslog"`,
     * `"book_log"`.
     *
     * Generated from protobuf field <code>string name = 10;</code>
     * @return string
     */
    public function getName()
    {
        return $this->name;
    }

    /**
     * Required. The log to which this log entry belongs. Examples: `"syslog"`,
     * `"book_log"`.
     *
     * Generated from protobuf field <code>string name = 10;</code>
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
     * The time the event described by the log entry occurred. If
     * omitted, defaults to operation start time.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp timestamp = 11;</code>
     * @return \Google\Protobuf\Timestamp|null
     */
    public function getTimestamp()
    {
        return isset($this->timestamp) ? $this->timestamp : null;
    }

    public function hasTimestamp()
    {
        return isset($this->timestamp);
    }

    public function clearTimestamp()
    {
        unset($this->timestamp);
    }

    /**
     * The time the event described by the log entry occurred. If
     * omitted, defaults to operation start time.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp timestamp = 11;</code>
     * @param \Google\Protobuf\Timestamp $var
     * @return $this
     */
    public function setTimestamp($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Timestamp::class);
        $this->timestamp = $var;

        return $this;
    }

    /**
     * The severity of the log entry. The default value is
     * `LogSeverity.DEFAULT`.
     *
     * Generated from protobuf field <code>.google.logging.type.LogSeverity severity = 12;</code>
     * @return int
     */
    public function getSeverity()
    {
        return $this->severity;
    }

    /**
     * The severity of the log entry. The default value is
     * `LogSeverity.DEFAULT`.
     *
     * Generated from protobuf field <code>.google.logging.type.LogSeverity severity = 12;</code>
     * @param int $var
     * @return $this
     */
    public function setSeverity($var)
    {
        GPBUtil::checkEnum($var, \Google\Cloud\Logging\Type\LogSeverity::class);
        $this->severity = $var;

        return $this;
    }

    /**
     * Optional. Information about the HTTP request associated with this
     * log entry, if applicable.
     *
     * Generated from protobuf field <code>.google.api.servicecontrol.v1.HttpRequest http_request = 14;</code>
     * @return \Google\Cloud\ServiceControl\V1\HttpRequest|null
     */
    public function getHttpRequest()
    {
        return isset($this->http_request) ? $this->http_request : null;
    }

    public function hasHttpRequest()
    {
        return isset($this->http_request);
    }

    public function clearHttpRequest()
    {
        unset($this->http_request);
    }

    /**
     * Optional. Information about the HTTP request associated with this
     * log entry, if applicable.
     *
     * Generated from protobuf field <code>.google.api.servicecontrol.v1.HttpRequest http_request = 14;</code>
     * @param \Google\Cloud\ServiceControl\V1\HttpRequest $var
     * @return $this
     */
    public function setHttpRequest($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\ServiceControl\V1\HttpRequest::class);
        $this->http_request = $var;

        return $this;
    }

    /**
     * Optional. Resource name of the trace associated with the log entry, if any.
     * If this field contains a relative resource name, you can assume the name is
     * relative to `//tracing.googleapis.com`. Example:
     * `projects/my-projectid/traces/06796866738c859f2f19b7cfb3214824`
     *
     * Generated from protobuf field <code>string trace = 15;</code>
     * @return string
     */
    public function getTrace()
    {
        return $this->trace;
    }

    /**
     * Optional. Resource name of the trace associated with the log entry, if any.
     * If this field contains a relative resource name, you can assume the name is
     * relative to `//tracing.googleapis.com`. Example:
     * `projects/my-projectid/traces/06796866738c859f2f19b7cfb3214824`
     *
     * Generated from protobuf field <code>string trace = 15;</code>
     * @param string $var
     * @return $this
     */
    public function setTrace($var)
    {
        GPBUtil::checkString($var, True);
        $this->trace = $var;

        return $this;
    }

    /**
     * A unique ID for the log entry used for deduplication. If omitted,
     * the implementation will generate one based on operation_id.
     *
     * Generated from protobuf field <code>string insert_id = 4;</code>
     * @return string
     */
    public function getInsertId()
    {
        return $this->insert_id;
    }

    /**
     * A unique ID for the log entry used for deduplication. If omitted,
     * the implementation will generate one based on operation_id.
     *
     * Generated from protobuf field <code>string insert_id = 4;</code>
     * @param string $var
     * @return $this
     */
    public function setInsertId($var)
    {
        GPBUtil::checkString($var, True);
        $this->insert_id = $var;

        return $this;
    }

    /**
     * A set of user-defined (key, value) data that provides additional
     * information about the log entry.
     *
     * Generated from protobuf field <code>map<string, string> labels = 13;</code>
     * @return \Google\Protobuf\Internal\MapField
     */
    public function getLabels()
    {
        return $this->labels;
    }

    /**
     * A set of user-defined (key, value) data that provides additional
     * information about the log entry.
     *
     * Generated from protobuf field <code>map<string, string> labels = 13;</code>
     * @param array|\Google\Protobuf\Internal\MapField $var
     * @return $this
     */
    public function setLabels($var)
    {
        $arr = GPBUtil::checkMapField($var, \Google\Protobuf\Internal\GPBType::STRING, \Google\Protobuf\Internal\GPBType::STRING);
        $this->labels = $arr;

        return $this;
    }

    /**
     * The log entry payload, represented as a protocol buffer that is
     * expressed as a JSON object. The only accepted type currently is
     * [AuditLog][google.cloud.audit.AuditLog].
     *
     * Generated from protobuf field <code>.google.protobuf.Any proto_payload = 2;</code>
     * @return \Google\Protobuf\Any|null
     */
    public function getProtoPayload()
    {
        return $this->readOneof(2);
    }

    public function hasProtoPayload()
    {
        return $this->hasOneof(2);
    }

    /**
     * The log entry payload, represented as a protocol buffer that is
     * expressed as a JSON object. The only accepted type currently is
     * [AuditLog][google.cloud.audit.AuditLog].
     *
     * Generated from protobuf field <code>.google.protobuf.Any proto_payload = 2;</code>
     * @param \Google\Protobuf\Any $var
     * @return $this
     */
    public function setProtoPayload($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Any::class);
        $this->writeOneof(2, $var);

        return $this;
    }

    /**
     * The log entry payload, represented as a Unicode string (UTF-8).
     *
     * Generated from protobuf field <code>string text_payload = 3;</code>
     * @return string
     */
    public function getTextPayload()
    {
        return $this->readOneof(3);
    }

    public function hasTextPayload()
    {
        return $this->hasOneof(3);
    }

    /**
     * The log entry payload, represented as a Unicode string (UTF-8).
     *
     * Generated from protobuf field <code>string text_payload = 3;</code>
     * @param string $var
     * @return $this
     */
    public function setTextPayload($var)
    {
        GPBUtil::checkString($var, True);
        $this->writeOneof(3, $var);

        return $this;
    }

    /**
     * The log entry payload, represented as a structure that
     * is expressed as a JSON object.
     *
     * Generated from protobuf field <code>.google.protobuf.Struct struct_payload = 6;</code>
     * @return \Google\Protobuf\Struct|null
     */
    public function getStructPayload()
    {
        return $this->readOneof(6);
    }

    public function hasStructPayload()
    {
        return $this->hasOneof(6);
    }

    /**
     * The log entry payload, represented as a structure that
     * is expressed as a JSON object.
     *
     * Generated from protobuf field <code>.google.protobuf.Struct struct_payload = 6;</code>
     * @param \Google\Protobuf\Struct $var
     * @return $this
     */
    public function setStructPayload($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Struct::class);
        $this->writeOneof(6, $var);

        return $this;
    }

    /**
     * Optional. Information about an operation associated with the log entry, if
     * applicable.
     *
     * Generated from protobuf field <code>.google.api.servicecontrol.v1.LogEntryOperation operation = 16;</code>
     * @return \Google\Cloud\ServiceControl\V1\LogEntryOperation|null
     */
    public function getOperation()
    {
        return isset($this->operation) ? $this->operation : null;
    }

    public function hasOperation()
    {
        return isset($this->operation);
    }

    public function clearOperation()
    {
        unset($this->operation);
    }

    /**
     * Optional. Information about an operation associated with the log entry, if
     * applicable.
     *
     * Generated from protobuf field <code>.google.api.servicecontrol.v1.LogEntryOperation operation = 16;</code>
     * @param \Google\Cloud\ServiceControl\V1\LogEntryOperation $var
     * @return $this
     */
    public function setOperation($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\ServiceControl\V1\LogEntryOperation::class);
        $this->operation = $var;

        return $this;
    }

    /**
     * Optional. Source code location information associated with the log entry,
     * if any.
     *
     * Generated from protobuf field <code>.google.api.servicecontrol.v1.LogEntrySourceLocation source_location = 17;</code>
     * @return \Google\Cloud\ServiceControl\V1\LogEntrySourceLocation|null
     */
    public function getSourceLocation()
    {
        return isset($this->source_location) ? $this->source_location : null;
    }

    public function hasSourceLocation()
    {
        return isset($this->source_location);
    }

    public function clearSourceLocation()
    {
        unset($this->source_location);
    }

    /**
     * Optional. Source code location information associated with the log entry,
     * if any.
     *
     * Generated from protobuf field <code>.google.api.servicecontrol.v1.LogEntrySourceLocation source_location = 17;</code>
     * @param \Google\Cloud\ServiceControl\V1\LogEntrySourceLocation $var
     * @return $this
     */
    public function setSourceLocation($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\ServiceControl\V1\LogEntrySourceLocation::class);
        $this->source_location = $var;

        return $this;
    }

    /**
     * @return string
     */
    public function getPayload()
    {
        return $this->whichOneof("payload");
    }

}

