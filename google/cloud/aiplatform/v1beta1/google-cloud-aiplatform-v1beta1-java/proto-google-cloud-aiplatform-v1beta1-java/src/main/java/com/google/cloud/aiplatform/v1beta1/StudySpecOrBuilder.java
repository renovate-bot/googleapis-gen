// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/cloud/aiplatform/v1beta1/study.proto

package com.google.cloud.aiplatform.v1beta1;

public interface StudySpecOrBuilder extends
    // @@protoc_insertion_point(interface_extends:google.cloud.aiplatform.v1beta1.StudySpec)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <pre>
   * The automated early stopping spec using decay curve rule.
   * </pre>
   *
   * <code>.google.cloud.aiplatform.v1beta1.StudySpec.DecayCurveAutomatedStoppingSpec decay_curve_stopping_spec = 4;</code>
   * @return Whether the decayCurveStoppingSpec field is set.
   */
  boolean hasDecayCurveStoppingSpec();
  /**
   * <pre>
   * The automated early stopping spec using decay curve rule.
   * </pre>
   *
   * <code>.google.cloud.aiplatform.v1beta1.StudySpec.DecayCurveAutomatedStoppingSpec decay_curve_stopping_spec = 4;</code>
   * @return The decayCurveStoppingSpec.
   */
  com.google.cloud.aiplatform.v1beta1.StudySpec.DecayCurveAutomatedStoppingSpec getDecayCurveStoppingSpec();
  /**
   * <pre>
   * The automated early stopping spec using decay curve rule.
   * </pre>
   *
   * <code>.google.cloud.aiplatform.v1beta1.StudySpec.DecayCurveAutomatedStoppingSpec decay_curve_stopping_spec = 4;</code>
   */
  com.google.cloud.aiplatform.v1beta1.StudySpec.DecayCurveAutomatedStoppingSpecOrBuilder getDecayCurveStoppingSpecOrBuilder();

  /**
   * <pre>
   * The automated early stopping spec using median rule.
   * </pre>
   *
   * <code>.google.cloud.aiplatform.v1beta1.StudySpec.MedianAutomatedStoppingSpec median_automated_stopping_spec = 5;</code>
   * @return Whether the medianAutomatedStoppingSpec field is set.
   */
  boolean hasMedianAutomatedStoppingSpec();
  /**
   * <pre>
   * The automated early stopping spec using median rule.
   * </pre>
   *
   * <code>.google.cloud.aiplatform.v1beta1.StudySpec.MedianAutomatedStoppingSpec median_automated_stopping_spec = 5;</code>
   * @return The medianAutomatedStoppingSpec.
   */
  com.google.cloud.aiplatform.v1beta1.StudySpec.MedianAutomatedStoppingSpec getMedianAutomatedStoppingSpec();
  /**
   * <pre>
   * The automated early stopping spec using median rule.
   * </pre>
   *
   * <code>.google.cloud.aiplatform.v1beta1.StudySpec.MedianAutomatedStoppingSpec median_automated_stopping_spec = 5;</code>
   */
  com.google.cloud.aiplatform.v1beta1.StudySpec.MedianAutomatedStoppingSpecOrBuilder getMedianAutomatedStoppingSpecOrBuilder();

  /**
   * <pre>
   * Deprecated.
   * The automated early stopping using convex stopping rule.
   * </pre>
   *
   * <code>.google.cloud.aiplatform.v1beta1.StudySpec.ConvexStopConfig convex_stop_config = 8 [deprecated = true];</code>
   * @return Whether the convexStopConfig field is set.
   */
  @java.lang.Deprecated boolean hasConvexStopConfig();
  /**
   * <pre>
   * Deprecated.
   * The automated early stopping using convex stopping rule.
   * </pre>
   *
   * <code>.google.cloud.aiplatform.v1beta1.StudySpec.ConvexStopConfig convex_stop_config = 8 [deprecated = true];</code>
   * @return The convexStopConfig.
   */
  @java.lang.Deprecated com.google.cloud.aiplatform.v1beta1.StudySpec.ConvexStopConfig getConvexStopConfig();
  /**
   * <pre>
   * Deprecated.
   * The automated early stopping using convex stopping rule.
   * </pre>
   *
   * <code>.google.cloud.aiplatform.v1beta1.StudySpec.ConvexStopConfig convex_stop_config = 8 [deprecated = true];</code>
   */
  @java.lang.Deprecated com.google.cloud.aiplatform.v1beta1.StudySpec.ConvexStopConfigOrBuilder getConvexStopConfigOrBuilder();

  /**
   * <pre>
   * Required. Metric specs for the Study.
   * </pre>
   *
   * <code>repeated .google.cloud.aiplatform.v1beta1.StudySpec.MetricSpec metrics = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   */
  java.util.List<com.google.cloud.aiplatform.v1beta1.StudySpec.MetricSpec> 
      getMetricsList();
  /**
   * <pre>
   * Required. Metric specs for the Study.
   * </pre>
   *
   * <code>repeated .google.cloud.aiplatform.v1beta1.StudySpec.MetricSpec metrics = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   */
  com.google.cloud.aiplatform.v1beta1.StudySpec.MetricSpec getMetrics(int index);
  /**
   * <pre>
   * Required. Metric specs for the Study.
   * </pre>
   *
   * <code>repeated .google.cloud.aiplatform.v1beta1.StudySpec.MetricSpec metrics = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   */
  int getMetricsCount();
  /**
   * <pre>
   * Required. Metric specs for the Study.
   * </pre>
   *
   * <code>repeated .google.cloud.aiplatform.v1beta1.StudySpec.MetricSpec metrics = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   */
  java.util.List<? extends com.google.cloud.aiplatform.v1beta1.StudySpec.MetricSpecOrBuilder> 
      getMetricsOrBuilderList();
  /**
   * <pre>
   * Required. Metric specs for the Study.
   * </pre>
   *
   * <code>repeated .google.cloud.aiplatform.v1beta1.StudySpec.MetricSpec metrics = 1 [(.google.api.field_behavior) = REQUIRED];</code>
   */
  com.google.cloud.aiplatform.v1beta1.StudySpec.MetricSpecOrBuilder getMetricsOrBuilder(
      int index);

  /**
   * <pre>
   * Required. The set of parameters to tune.
   * </pre>
   *
   * <code>repeated .google.cloud.aiplatform.v1beta1.StudySpec.ParameterSpec parameters = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   */
  java.util.List<com.google.cloud.aiplatform.v1beta1.StudySpec.ParameterSpec> 
      getParametersList();
  /**
   * <pre>
   * Required. The set of parameters to tune.
   * </pre>
   *
   * <code>repeated .google.cloud.aiplatform.v1beta1.StudySpec.ParameterSpec parameters = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   */
  com.google.cloud.aiplatform.v1beta1.StudySpec.ParameterSpec getParameters(int index);
  /**
   * <pre>
   * Required. The set of parameters to tune.
   * </pre>
   *
   * <code>repeated .google.cloud.aiplatform.v1beta1.StudySpec.ParameterSpec parameters = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   */
  int getParametersCount();
  /**
   * <pre>
   * Required. The set of parameters to tune.
   * </pre>
   *
   * <code>repeated .google.cloud.aiplatform.v1beta1.StudySpec.ParameterSpec parameters = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   */
  java.util.List<? extends com.google.cloud.aiplatform.v1beta1.StudySpec.ParameterSpecOrBuilder> 
      getParametersOrBuilderList();
  /**
   * <pre>
   * Required. The set of parameters to tune.
   * </pre>
   *
   * <code>repeated .google.cloud.aiplatform.v1beta1.StudySpec.ParameterSpec parameters = 2 [(.google.api.field_behavior) = REQUIRED];</code>
   */
  com.google.cloud.aiplatform.v1beta1.StudySpec.ParameterSpecOrBuilder getParametersOrBuilder(
      int index);

  /**
   * <pre>
   * The search algorithm specified for the Study.
   * </pre>
   *
   * <code>.google.cloud.aiplatform.v1beta1.StudySpec.Algorithm algorithm = 3;</code>
   * @return The enum numeric value on the wire for algorithm.
   */
  int getAlgorithmValue();
  /**
   * <pre>
   * The search algorithm specified for the Study.
   * </pre>
   *
   * <code>.google.cloud.aiplatform.v1beta1.StudySpec.Algorithm algorithm = 3;</code>
   * @return The algorithm.
   */
  com.google.cloud.aiplatform.v1beta1.StudySpec.Algorithm getAlgorithm();

  /**
   * <pre>
   * The observation noise level of the study.
   * Currently only supported by the Vertex AI Vizier service. Not supported by
   * HyperparamterTuningJob or TrainingPipeline.
   * </pre>
   *
   * <code>.google.cloud.aiplatform.v1beta1.StudySpec.ObservationNoise observation_noise = 6;</code>
   * @return The enum numeric value on the wire for observationNoise.
   */
  int getObservationNoiseValue();
  /**
   * <pre>
   * The observation noise level of the study.
   * Currently only supported by the Vertex AI Vizier service. Not supported by
   * HyperparamterTuningJob or TrainingPipeline.
   * </pre>
   *
   * <code>.google.cloud.aiplatform.v1beta1.StudySpec.ObservationNoise observation_noise = 6;</code>
   * @return The observationNoise.
   */
  com.google.cloud.aiplatform.v1beta1.StudySpec.ObservationNoise getObservationNoise();

  /**
   * <pre>
   * Describe which measurement selection type will be used
   * </pre>
   *
   * <code>.google.cloud.aiplatform.v1beta1.StudySpec.MeasurementSelectionType measurement_selection_type = 7;</code>
   * @return The enum numeric value on the wire for measurementSelectionType.
   */
  int getMeasurementSelectionTypeValue();
  /**
   * <pre>
   * Describe which measurement selection type will be used
   * </pre>
   *
   * <code>.google.cloud.aiplatform.v1beta1.StudySpec.MeasurementSelectionType measurement_selection_type = 7;</code>
   * @return The measurementSelectionType.
   */
  com.google.cloud.aiplatform.v1beta1.StudySpec.MeasurementSelectionType getMeasurementSelectionType();

  public com.google.cloud.aiplatform.v1beta1.StudySpec.AutomatedStoppingSpecCase getAutomatedStoppingSpecCase();
}
