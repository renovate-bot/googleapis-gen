<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/devtools/cloudtrace/v2/trace.proto

namespace Google\Cloud\Trace\V2;

use Google\Protobuf\Internal\GPBType;
use Google\Protobuf\Internal\RepeatedField;
use Google\Protobuf\Internal\GPBUtil;

/**
 * A span represents a single operation within a trace. Spans can be
 * nested to form a trace tree. Often, a trace contains a root span
 * that describes the end-to-end latency, and one or more subspans for
 * its sub-operations. A trace can also contain multiple root spans,
 * or none at all. Spans do not need to be contiguous&mdash;there may be
 * gaps or overlaps between spans in a trace.
 *
 * Generated from protobuf message <code>google.devtools.cloudtrace.v2.Span</code>
 */
class Span extends \Google\Protobuf\Internal\Message
{
    /**
     * Required. The resource name of the span in the following format:
     *     projects/[PROJECT_ID]/traces/[TRACE_ID]/spans/[SPAN_ID]
     * [TRACE_ID] is a unique identifier for a trace within a project;
     * it is a 32-character hexadecimal encoding of a 16-byte array.
     * [SPAN_ID] is a unique identifier for a span within a trace; it
     * is a 16-character hexadecimal encoding of an 8-byte array.
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $name = '';
    /**
     * Required. The [SPAN_ID] portion of the span's resource name.
     *
     * Generated from protobuf field <code>string span_id = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $span_id = '';
    /**
     * The [SPAN_ID] of this span's parent span. If this is a root span,
     * then this field must be empty.
     *
     * Generated from protobuf field <code>string parent_span_id = 3;</code>
     */
    protected $parent_span_id = '';
    /**
     * Required. A description of the span's operation (up to 128 bytes).
     * Stackdriver Trace displays the description in the
     * Google Cloud Platform Console.
     * For example, the display name can be a qualified method name or a file name
     * and a line number where the operation is called. A best practice is to use
     * the same display name within an application and at the same call point.
     * This makes it easier to correlate spans in different traces.
     *
     * Generated from protobuf field <code>.google.devtools.cloudtrace.v2.TruncatableString display_name = 4 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $display_name = null;
    /**
     * Required. The start time of the span. On the client side, this is the time kept by
     * the local machine where the span execution starts. On the server side, this
     * is the time when the server's application handler starts running.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp start_time = 5 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $start_time = null;
    /**
     * Required. The end time of the span. On the client side, this is the time kept by
     * the local machine where the span execution ends. On the server side, this
     * is the time when the server application handler stops running.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp end_time = 6 [(.google.api.field_behavior) = REQUIRED];</code>
     */
    protected $end_time = null;
    /**
     * A set of attributes on the span. You can have up to 32 attributes per
     * span.
     *
     * Generated from protobuf field <code>.google.devtools.cloudtrace.v2.Span.Attributes attributes = 7;</code>
     */
    protected $attributes = null;
    /**
     * Stack trace captured at the start of the span.
     *
     * Generated from protobuf field <code>.google.devtools.cloudtrace.v2.StackTrace stack_trace = 8;</code>
     */
    protected $stack_trace = null;
    /**
     * A set of time events. You can have up to 32 annotations and 128 message
     * events per span.
     *
     * Generated from protobuf field <code>.google.devtools.cloudtrace.v2.Span.TimeEvents time_events = 9;</code>
     */
    protected $time_events = null;
    /**
     * Links associated with the span. You can have up to 128 links per Span.
     *
     * Generated from protobuf field <code>.google.devtools.cloudtrace.v2.Span.Links links = 10;</code>
     */
    protected $links = null;
    /**
     * Optional. The final status for this span.
     *
     * Generated from protobuf field <code>.google.rpc.Status status = 11 [(.google.api.field_behavior) = OPTIONAL];</code>
     */
    protected $status = null;
    /**
     * Optional. Set this parameter to indicate whether this span is in
     * the same process as its parent. If you do not set this parameter,
     * Stackdriver Trace is unable to take advantage of this helpful
     * information.
     *
     * Generated from protobuf field <code>.google.protobuf.BoolValue same_process_as_parent_span = 12 [(.google.api.field_behavior) = OPTIONAL];</code>
     */
    protected $same_process_as_parent_span = null;
    /**
     * Optional. The number of child spans that were generated while this span
     * was active. If set, allows implementation to detect missing child spans.
     *
     * Generated from protobuf field <code>.google.protobuf.Int32Value child_span_count = 13 [(.google.api.field_behavior) = OPTIONAL];</code>
     */
    protected $child_span_count = null;
    /**
     * Optional. Distinguishes between spans generated in a particular context. For example,
     * two spans with the same name may be distinguished using `CLIENT` (caller)
     * and `SERVER` (callee) to identify an RPC call.
     *
     * Generated from protobuf field <code>.google.devtools.cloudtrace.v2.Span.SpanKind span_kind = 14 [(.google.api.field_behavior) = OPTIONAL];</code>
     */
    protected $span_kind = 0;

    /**
     * Constructor.
     *
     * @param array $data {
     *     Optional. Data for populating the Message object.
     *
     *     @type string $name
     *           Required. The resource name of the span in the following format:
     *               projects/[PROJECT_ID]/traces/[TRACE_ID]/spans/[SPAN_ID]
     *           [TRACE_ID] is a unique identifier for a trace within a project;
     *           it is a 32-character hexadecimal encoding of a 16-byte array.
     *           [SPAN_ID] is a unique identifier for a span within a trace; it
     *           is a 16-character hexadecimal encoding of an 8-byte array.
     *     @type string $span_id
     *           Required. The [SPAN_ID] portion of the span's resource name.
     *     @type string $parent_span_id
     *           The [SPAN_ID] of this span's parent span. If this is a root span,
     *           then this field must be empty.
     *     @type \Google\Cloud\Trace\V2\TruncatableString $display_name
     *           Required. A description of the span's operation (up to 128 bytes).
     *           Stackdriver Trace displays the description in the
     *           Google Cloud Platform Console.
     *           For example, the display name can be a qualified method name or a file name
     *           and a line number where the operation is called. A best practice is to use
     *           the same display name within an application and at the same call point.
     *           This makes it easier to correlate spans in different traces.
     *     @type \Google\Protobuf\Timestamp $start_time
     *           Required. The start time of the span. On the client side, this is the time kept by
     *           the local machine where the span execution starts. On the server side, this
     *           is the time when the server's application handler starts running.
     *     @type \Google\Protobuf\Timestamp $end_time
     *           Required. The end time of the span. On the client side, this is the time kept by
     *           the local machine where the span execution ends. On the server side, this
     *           is the time when the server application handler stops running.
     *     @type \Google\Cloud\Trace\V2\Span\Attributes $attributes
     *           A set of attributes on the span. You can have up to 32 attributes per
     *           span.
     *     @type \Google\Cloud\Trace\V2\StackTrace $stack_trace
     *           Stack trace captured at the start of the span.
     *     @type \Google\Cloud\Trace\V2\Span\TimeEvents $time_events
     *           A set of time events. You can have up to 32 annotations and 128 message
     *           events per span.
     *     @type \Google\Cloud\Trace\V2\Span\Links $links
     *           Links associated with the span. You can have up to 128 links per Span.
     *     @type \Google\Rpc\Status $status
     *           Optional. The final status for this span.
     *     @type \Google\Protobuf\BoolValue $same_process_as_parent_span
     *           Optional. Set this parameter to indicate whether this span is in
     *           the same process as its parent. If you do not set this parameter,
     *           Stackdriver Trace is unable to take advantage of this helpful
     *           information.
     *     @type \Google\Protobuf\Int32Value $child_span_count
     *           Optional. The number of child spans that were generated while this span
     *           was active. If set, allows implementation to detect missing child spans.
     *     @type int $span_kind
     *           Optional. Distinguishes between spans generated in a particular context. For example,
     *           two spans with the same name may be distinguished using `CLIENT` (caller)
     *           and `SERVER` (callee) to identify an RPC call.
     * }
     */
    public function __construct($data = NULL) {
        \GPBMetadata\Google\Devtools\Cloudtrace\V2\Trace::initOnce();
        parent::__construct($data);
    }

    /**
     * Required. The resource name of the span in the following format:
     *     projects/[PROJECT_ID]/traces/[TRACE_ID]/spans/[SPAN_ID]
     * [TRACE_ID] is a unique identifier for a trace within a project;
     * it is a 32-character hexadecimal encoding of a 16-byte array.
     * [SPAN_ID] is a unique identifier for a span within a trace; it
     * is a 16-character hexadecimal encoding of an 8-byte array.
     *
     * Generated from protobuf field <code>string name = 1 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return string
     */
    public function getName()
    {
        return $this->name;
    }

    /**
     * Required. The resource name of the span in the following format:
     *     projects/[PROJECT_ID]/traces/[TRACE_ID]/spans/[SPAN_ID]
     * [TRACE_ID] is a unique identifier for a trace within a project;
     * it is a 32-character hexadecimal encoding of a 16-byte array.
     * [SPAN_ID] is a unique identifier for a span within a trace; it
     * is a 16-character hexadecimal encoding of an 8-byte array.
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
     * Required. The [SPAN_ID] portion of the span's resource name.
     *
     * Generated from protobuf field <code>string span_id = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return string
     */
    public function getSpanId()
    {
        return $this->span_id;
    }

    /**
     * Required. The [SPAN_ID] portion of the span's resource name.
     *
     * Generated from protobuf field <code>string span_id = 2 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param string $var
     * @return $this
     */
    public function setSpanId($var)
    {
        GPBUtil::checkString($var, True);
        $this->span_id = $var;

        return $this;
    }

    /**
     * The [SPAN_ID] of this span's parent span. If this is a root span,
     * then this field must be empty.
     *
     * Generated from protobuf field <code>string parent_span_id = 3;</code>
     * @return string
     */
    public function getParentSpanId()
    {
        return $this->parent_span_id;
    }

    /**
     * The [SPAN_ID] of this span's parent span. If this is a root span,
     * then this field must be empty.
     *
     * Generated from protobuf field <code>string parent_span_id = 3;</code>
     * @param string $var
     * @return $this
     */
    public function setParentSpanId($var)
    {
        GPBUtil::checkString($var, True);
        $this->parent_span_id = $var;

        return $this;
    }

    /**
     * Required. A description of the span's operation (up to 128 bytes).
     * Stackdriver Trace displays the description in the
     * Google Cloud Platform Console.
     * For example, the display name can be a qualified method name or a file name
     * and a line number where the operation is called. A best practice is to use
     * the same display name within an application and at the same call point.
     * This makes it easier to correlate spans in different traces.
     *
     * Generated from protobuf field <code>.google.devtools.cloudtrace.v2.TruncatableString display_name = 4 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Cloud\Trace\V2\TruncatableString|null
     */
    public function getDisplayName()
    {
        return isset($this->display_name) ? $this->display_name : null;
    }

    public function hasDisplayName()
    {
        return isset($this->display_name);
    }

    public function clearDisplayName()
    {
        unset($this->display_name);
    }

    /**
     * Required. A description of the span's operation (up to 128 bytes).
     * Stackdriver Trace displays the description in the
     * Google Cloud Platform Console.
     * For example, the display name can be a qualified method name or a file name
     * and a line number where the operation is called. A best practice is to use
     * the same display name within an application and at the same call point.
     * This makes it easier to correlate spans in different traces.
     *
     * Generated from protobuf field <code>.google.devtools.cloudtrace.v2.TruncatableString display_name = 4 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param \Google\Cloud\Trace\V2\TruncatableString $var
     * @return $this
     */
    public function setDisplayName($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Trace\V2\TruncatableString::class);
        $this->display_name = $var;

        return $this;
    }

    /**
     * Required. The start time of the span. On the client side, this is the time kept by
     * the local machine where the span execution starts. On the server side, this
     * is the time when the server's application handler starts running.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp start_time = 5 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Protobuf\Timestamp|null
     */
    public function getStartTime()
    {
        return isset($this->start_time) ? $this->start_time : null;
    }

    public function hasStartTime()
    {
        return isset($this->start_time);
    }

    public function clearStartTime()
    {
        unset($this->start_time);
    }

    /**
     * Required. The start time of the span. On the client side, this is the time kept by
     * the local machine where the span execution starts. On the server side, this
     * is the time when the server's application handler starts running.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp start_time = 5 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param \Google\Protobuf\Timestamp $var
     * @return $this
     */
    public function setStartTime($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Timestamp::class);
        $this->start_time = $var;

        return $this;
    }

    /**
     * Required. The end time of the span. On the client side, this is the time kept by
     * the local machine where the span execution ends. On the server side, this
     * is the time when the server application handler stops running.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp end_time = 6 [(.google.api.field_behavior) = REQUIRED];</code>
     * @return \Google\Protobuf\Timestamp|null
     */
    public function getEndTime()
    {
        return isset($this->end_time) ? $this->end_time : null;
    }

    public function hasEndTime()
    {
        return isset($this->end_time);
    }

    public function clearEndTime()
    {
        unset($this->end_time);
    }

    /**
     * Required. The end time of the span. On the client side, this is the time kept by
     * the local machine where the span execution ends. On the server side, this
     * is the time when the server application handler stops running.
     *
     * Generated from protobuf field <code>.google.protobuf.Timestamp end_time = 6 [(.google.api.field_behavior) = REQUIRED];</code>
     * @param \Google\Protobuf\Timestamp $var
     * @return $this
     */
    public function setEndTime($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Timestamp::class);
        $this->end_time = $var;

        return $this;
    }

    /**
     * A set of attributes on the span. You can have up to 32 attributes per
     * span.
     *
     * Generated from protobuf field <code>.google.devtools.cloudtrace.v2.Span.Attributes attributes = 7;</code>
     * @return \Google\Cloud\Trace\V2\Span\Attributes|null
     */
    public function getAttributes()
    {
        return isset($this->attributes) ? $this->attributes : null;
    }

    public function hasAttributes()
    {
        return isset($this->attributes);
    }

    public function clearAttributes()
    {
        unset($this->attributes);
    }

    /**
     * A set of attributes on the span. You can have up to 32 attributes per
     * span.
     *
     * Generated from protobuf field <code>.google.devtools.cloudtrace.v2.Span.Attributes attributes = 7;</code>
     * @param \Google\Cloud\Trace\V2\Span\Attributes $var
     * @return $this
     */
    public function setAttributes($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Trace\V2\Span\Attributes::class);
        $this->attributes = $var;

        return $this;
    }

    /**
     * Stack trace captured at the start of the span.
     *
     * Generated from protobuf field <code>.google.devtools.cloudtrace.v2.StackTrace stack_trace = 8;</code>
     * @return \Google\Cloud\Trace\V2\StackTrace|null
     */
    public function getStackTrace()
    {
        return isset($this->stack_trace) ? $this->stack_trace : null;
    }

    public function hasStackTrace()
    {
        return isset($this->stack_trace);
    }

    public function clearStackTrace()
    {
        unset($this->stack_trace);
    }

    /**
     * Stack trace captured at the start of the span.
     *
     * Generated from protobuf field <code>.google.devtools.cloudtrace.v2.StackTrace stack_trace = 8;</code>
     * @param \Google\Cloud\Trace\V2\StackTrace $var
     * @return $this
     */
    public function setStackTrace($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Trace\V2\StackTrace::class);
        $this->stack_trace = $var;

        return $this;
    }

    /**
     * A set of time events. You can have up to 32 annotations and 128 message
     * events per span.
     *
     * Generated from protobuf field <code>.google.devtools.cloudtrace.v2.Span.TimeEvents time_events = 9;</code>
     * @return \Google\Cloud\Trace\V2\Span\TimeEvents|null
     */
    public function getTimeEvents()
    {
        return isset($this->time_events) ? $this->time_events : null;
    }

    public function hasTimeEvents()
    {
        return isset($this->time_events);
    }

    public function clearTimeEvents()
    {
        unset($this->time_events);
    }

    /**
     * A set of time events. You can have up to 32 annotations and 128 message
     * events per span.
     *
     * Generated from protobuf field <code>.google.devtools.cloudtrace.v2.Span.TimeEvents time_events = 9;</code>
     * @param \Google\Cloud\Trace\V2\Span\TimeEvents $var
     * @return $this
     */
    public function setTimeEvents($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Trace\V2\Span\TimeEvents::class);
        $this->time_events = $var;

        return $this;
    }

    /**
     * Links associated with the span. You can have up to 128 links per Span.
     *
     * Generated from protobuf field <code>.google.devtools.cloudtrace.v2.Span.Links links = 10;</code>
     * @return \Google\Cloud\Trace\V2\Span\Links|null
     */
    public function getLinks()
    {
        return isset($this->links) ? $this->links : null;
    }

    public function hasLinks()
    {
        return isset($this->links);
    }

    public function clearLinks()
    {
        unset($this->links);
    }

    /**
     * Links associated with the span. You can have up to 128 links per Span.
     *
     * Generated from protobuf field <code>.google.devtools.cloudtrace.v2.Span.Links links = 10;</code>
     * @param \Google\Cloud\Trace\V2\Span\Links $var
     * @return $this
     */
    public function setLinks($var)
    {
        GPBUtil::checkMessage($var, \Google\Cloud\Trace\V2\Span\Links::class);
        $this->links = $var;

        return $this;
    }

    /**
     * Optional. The final status for this span.
     *
     * Generated from protobuf field <code>.google.rpc.Status status = 11 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @return \Google\Rpc\Status|null
     */
    public function getStatus()
    {
        return isset($this->status) ? $this->status : null;
    }

    public function hasStatus()
    {
        return isset($this->status);
    }

    public function clearStatus()
    {
        unset($this->status);
    }

    /**
     * Optional. The final status for this span.
     *
     * Generated from protobuf field <code>.google.rpc.Status status = 11 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @param \Google\Rpc\Status $var
     * @return $this
     */
    public function setStatus($var)
    {
        GPBUtil::checkMessage($var, \Google\Rpc\Status::class);
        $this->status = $var;

        return $this;
    }

    /**
     * Optional. Set this parameter to indicate whether this span is in
     * the same process as its parent. If you do not set this parameter,
     * Stackdriver Trace is unable to take advantage of this helpful
     * information.
     *
     * Generated from protobuf field <code>.google.protobuf.BoolValue same_process_as_parent_span = 12 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @return \Google\Protobuf\BoolValue|null
     */
    public function getSameProcessAsParentSpan()
    {
        return isset($this->same_process_as_parent_span) ? $this->same_process_as_parent_span : null;
    }

    public function hasSameProcessAsParentSpan()
    {
        return isset($this->same_process_as_parent_span);
    }

    public function clearSameProcessAsParentSpan()
    {
        unset($this->same_process_as_parent_span);
    }

    /**
     * Returns the unboxed value from <code>getSameProcessAsParentSpan()</code>

     * Optional. Set this parameter to indicate whether this span is in
     * the same process as its parent. If you do not set this parameter,
     * Stackdriver Trace is unable to take advantage of this helpful
     * information.
     *
     * Generated from protobuf field <code>.google.protobuf.BoolValue same_process_as_parent_span = 12 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @return bool|null
     */
    public function getSameProcessAsParentSpanUnwrapped()
    {
        return $this->readWrapperValue("same_process_as_parent_span");
    }

    /**
     * Optional. Set this parameter to indicate whether this span is in
     * the same process as its parent. If you do not set this parameter,
     * Stackdriver Trace is unable to take advantage of this helpful
     * information.
     *
     * Generated from protobuf field <code>.google.protobuf.BoolValue same_process_as_parent_span = 12 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @param \Google\Protobuf\BoolValue $var
     * @return $this
     */
    public function setSameProcessAsParentSpan($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\BoolValue::class);
        $this->same_process_as_parent_span = $var;

        return $this;
    }

    /**
     * Sets the field by wrapping a primitive type in a Google\Protobuf\BoolValue object.

     * Optional. Set this parameter to indicate whether this span is in
     * the same process as its parent. If you do not set this parameter,
     * Stackdriver Trace is unable to take advantage of this helpful
     * information.
     *
     * Generated from protobuf field <code>.google.protobuf.BoolValue same_process_as_parent_span = 12 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @param bool|null $var
     * @return $this
     */
    public function setSameProcessAsParentSpanUnwrapped($var)
    {
        $this->writeWrapperValue("same_process_as_parent_span", $var);
        return $this;}

    /**
     * Optional. The number of child spans that were generated while this span
     * was active. If set, allows implementation to detect missing child spans.
     *
     * Generated from protobuf field <code>.google.protobuf.Int32Value child_span_count = 13 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @return \Google\Protobuf\Int32Value|null
     */
    public function getChildSpanCount()
    {
        return isset($this->child_span_count) ? $this->child_span_count : null;
    }

    public function hasChildSpanCount()
    {
        return isset($this->child_span_count);
    }

    public function clearChildSpanCount()
    {
        unset($this->child_span_count);
    }

    /**
     * Returns the unboxed value from <code>getChildSpanCount()</code>

     * Optional. The number of child spans that were generated while this span
     * was active. If set, allows implementation to detect missing child spans.
     *
     * Generated from protobuf field <code>.google.protobuf.Int32Value child_span_count = 13 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @return int|null
     */
    public function getChildSpanCountUnwrapped()
    {
        return $this->readWrapperValue("child_span_count");
    }

    /**
     * Optional. The number of child spans that were generated while this span
     * was active. If set, allows implementation to detect missing child spans.
     *
     * Generated from protobuf field <code>.google.protobuf.Int32Value child_span_count = 13 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @param \Google\Protobuf\Int32Value $var
     * @return $this
     */
    public function setChildSpanCount($var)
    {
        GPBUtil::checkMessage($var, \Google\Protobuf\Int32Value::class);
        $this->child_span_count = $var;

        return $this;
    }

    /**
     * Sets the field by wrapping a primitive type in a Google\Protobuf\Int32Value object.

     * Optional. The number of child spans that were generated while this span
     * was active. If set, allows implementation to detect missing child spans.
     *
     * Generated from protobuf field <code>.google.protobuf.Int32Value child_span_count = 13 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @param int|null $var
     * @return $this
     */
    public function setChildSpanCountUnwrapped($var)
    {
        $this->writeWrapperValue("child_span_count", $var);
        return $this;}

    /**
     * Optional. Distinguishes between spans generated in a particular context. For example,
     * two spans with the same name may be distinguished using `CLIENT` (caller)
     * and `SERVER` (callee) to identify an RPC call.
     *
     * Generated from protobuf field <code>.google.devtools.cloudtrace.v2.Span.SpanKind span_kind = 14 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @return int
     */
    public function getSpanKind()
    {
        return $this->span_kind;
    }

    /**
     * Optional. Distinguishes between spans generated in a particular context. For example,
     * two spans with the same name may be distinguished using `CLIENT` (caller)
     * and `SERVER` (callee) to identify an RPC call.
     *
     * Generated from protobuf field <code>.google.devtools.cloudtrace.v2.Span.SpanKind span_kind = 14 [(.google.api.field_behavior) = OPTIONAL];</code>
     * @param int $var
     * @return $this
     */
    public function setSpanKind($var)
    {
        GPBUtil::checkEnum($var, \Google\Cloud\Trace\V2\Span\SpanKind::class);
        $this->span_kind = $var;

        return $this;
    }

}

