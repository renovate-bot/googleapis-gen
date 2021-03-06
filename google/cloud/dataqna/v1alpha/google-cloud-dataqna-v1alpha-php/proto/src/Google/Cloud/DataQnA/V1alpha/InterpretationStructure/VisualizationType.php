<?php
# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: google/cloud/dataqna/v1alpha/question.proto

namespace Google\Cloud\DataQnA\V1alpha\InterpretationStructure;

use UnexpectedValueException;

/**
 * Enumeration of visualzation types to use for query response data.
 *
 * Protobuf type <code>google.cloud.dataqna.v1alpha.InterpretationStructure.VisualizationType</code>
 */
class VisualizationType
{
    /**
     * No visualization type was specified.
     *
     * Generated from protobuf enum <code>VISUALIZATION_TYPE_UNSPECIFIED = 0;</code>
     */
    const VISUALIZATION_TYPE_UNSPECIFIED = 0;
    /**
     * Show a table.
     *
     * Generated from protobuf enum <code>TABLE = 1;</code>
     */
    const TABLE = 1;
    /**
     * Show a [bar
     * chart](https://developers.google.com/chart/interactive/docs/gallery/barchart).
     *
     * Generated from protobuf enum <code>BAR_CHART = 2;</code>
     */
    const BAR_CHART = 2;
    /**
     * Show a [column
     * chart](https://developers.google.com/chart/interactive/docs/gallery/columnchart).
     *
     * Generated from protobuf enum <code>COLUMN_CHART = 3;</code>
     */
    const COLUMN_CHART = 3;
    /**
     * Show a
     * [timeline](https://developers.google.com/chart/interactive/docs/gallery/timeline).
     *
     * Generated from protobuf enum <code>TIMELINE = 4;</code>
     */
    const TIMELINE = 4;
    /**
     * Show a [scatter
     * plot](https://developers.google.com/chart/interactive/docs/gallery/scatterchart).
     *
     * Generated from protobuf enum <code>SCATTER_PLOT = 5;</code>
     */
    const SCATTER_PLOT = 5;
    /**
     * Show a [pie
     * chart](https://developers.google.com/chart/interactive/docs/gallery/piechart).
     *
     * Generated from protobuf enum <code>PIE_CHART = 6;</code>
     */
    const PIE_CHART = 6;
    /**
     * Show a [line
     * chart](https://developers.google.com/chart/interactive/docs/gallery/linechart).
     *
     * Generated from protobuf enum <code>LINE_CHART = 7;</code>
     */
    const LINE_CHART = 7;
    /**
     * Show an [area
     * chart](https://developers.google.com/chart/interactive/docs/gallery/areachart).
     *
     * Generated from protobuf enum <code>AREA_CHART = 8;</code>
     */
    const AREA_CHART = 8;
    /**
     * Show a [combo
     * chart](https://developers.google.com/chart/interactive/docs/gallery/combochart).
     *
     * Generated from protobuf enum <code>COMBO_CHART = 9;</code>
     */
    const COMBO_CHART = 9;
    /**
     * Show a
     * [histogram](https://developers.google.com/chart/interactive/docs/gallery/histogram).
     *
     * Generated from protobuf enum <code>HISTOGRAM = 10;</code>
     */
    const HISTOGRAM = 10;
    /**
     * This denotes queries when the user has not specified the particular type
     * of chart and has mentioned only a generic chart name such as "Chart",
     * "Plot", "Graph", etc. This will differentiate it from specific charting
     * terms such as "Bar chart", "Pie chart", etc.
     *
     * Generated from protobuf enum <code>GENERIC_CHART = 11;</code>
     */
    const GENERIC_CHART = 11;
    /**
     * The user tried to specify a chart type, but the interpreter could not
     * understand the type. The client should display a generic chart and may
     * give a hint to the user that the requested type was not understood.
     *
     * Generated from protobuf enum <code>CHART_NOT_UNDERSTOOD = 12;</code>
     */
    const CHART_NOT_UNDERSTOOD = 12;

    private static $valueToName = [
        self::VISUALIZATION_TYPE_UNSPECIFIED => 'VISUALIZATION_TYPE_UNSPECIFIED',
        self::TABLE => 'TABLE',
        self::BAR_CHART => 'BAR_CHART',
        self::COLUMN_CHART => 'COLUMN_CHART',
        self::TIMELINE => 'TIMELINE',
        self::SCATTER_PLOT => 'SCATTER_PLOT',
        self::PIE_CHART => 'PIE_CHART',
        self::LINE_CHART => 'LINE_CHART',
        self::AREA_CHART => 'AREA_CHART',
        self::COMBO_CHART => 'COMBO_CHART',
        self::HISTOGRAM => 'HISTOGRAM',
        self::GENERIC_CHART => 'GENERIC_CHART',
        self::CHART_NOT_UNDERSTOOD => 'CHART_NOT_UNDERSTOOD',
    ];

    public static function name($value)
    {
        if (!isset(self::$valueToName[$value])) {
            throw new UnexpectedValueException(sprintf(
                    'Enum %s has no name defined for value %s', __CLASS__, $value));
        }
        return self::$valueToName[$value];
    }


    public static function value($name)
    {
        $const = __CLASS__ . '::' . strtoupper($name);
        if (!defined($const)) {
            throw new UnexpectedValueException(sprintf(
                    'Enum %s has no value defined for name %s', __CLASS__, $name));
        }
        return constant($const);
    }
}

// Adding a class alias for backwards compatibility with the previous class name.
class_alias(VisualizationType::class, \Google\Cloud\DataQnA\V1alpha\InterpretationStructure_VisualizationType::class);

