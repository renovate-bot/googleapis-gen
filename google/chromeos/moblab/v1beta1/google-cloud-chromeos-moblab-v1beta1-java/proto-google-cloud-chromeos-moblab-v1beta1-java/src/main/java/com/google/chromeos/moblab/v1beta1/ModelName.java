/*
 * Copyright 2021 Google LLC
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      https://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

package com.google.chromeos.moblab.v1beta1;

import com.google.api.pathtemplate.PathTemplate;
import com.google.api.resourcenames.ResourceName;
import com.google.common.base.Preconditions;
import com.google.common.collect.ImmutableMap;
import java.util.ArrayList;
import java.util.List;
import java.util.Map;
import java.util.Objects;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
@Generated("by gapic-generator-java")
public class ModelName implements ResourceName {
  private static final PathTemplate BUILD_TARGET_MODEL =
      PathTemplate.createWithoutUrlEncoding("buildTargets/{build_target}/models/{model}");
  private volatile Map<String, String> fieldValuesMap;
  private final String buildTarget;
  private final String model;

  @Deprecated
  protected ModelName() {
    buildTarget = null;
    model = null;
  }

  private ModelName(Builder builder) {
    buildTarget = Preconditions.checkNotNull(builder.getBuildTarget());
    model = Preconditions.checkNotNull(builder.getModel());
  }

  public String getBuildTarget() {
    return buildTarget;
  }

  public String getModel() {
    return model;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static ModelName of(String buildTarget, String model) {
    return newBuilder().setBuildTarget(buildTarget).setModel(model).build();
  }

  public static String format(String buildTarget, String model) {
    return newBuilder().setBuildTarget(buildTarget).setModel(model).build().toString();
  }

  public static ModelName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        BUILD_TARGET_MODEL.validatedMatch(
            formattedString, "ModelName.parse: formattedString not in valid format");
    return of(matchMap.get("build_target"), matchMap.get("model"));
  }

  public static List<ModelName> parseList(List<String> formattedStrings) {
    List<ModelName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<ModelName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (ModelName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return BUILD_TARGET_MODEL.matches(formattedString);
  }

  @Override
  public Map<String, String> getFieldValuesMap() {
    if (fieldValuesMap == null) {
      synchronized (this) {
        if (fieldValuesMap == null) {
          ImmutableMap.Builder<String, String> fieldMapBuilder = ImmutableMap.builder();
          if (buildTarget != null) {
            fieldMapBuilder.put("build_target", buildTarget);
          }
          if (model != null) {
            fieldMapBuilder.put("model", model);
          }
          fieldValuesMap = fieldMapBuilder.build();
        }
      }
    }
    return fieldValuesMap;
  }

  public String getFieldValue(String fieldName) {
    return getFieldValuesMap().get(fieldName);
  }

  @Override
  public String toString() {
    return BUILD_TARGET_MODEL.instantiate("build_target", buildTarget, "model", model);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      ModelName that = ((ModelName) o);
      return Objects.equals(this.buildTarget, that.buildTarget)
          && Objects.equals(this.model, that.model);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(buildTarget);
    h *= 1000003;
    h ^= Objects.hashCode(model);
    return h;
  }

  /** Builder for buildTargets/{build_target}/models/{model}. */
  public static class Builder {
    private String buildTarget;
    private String model;

    protected Builder() {}

    public String getBuildTarget() {
      return buildTarget;
    }

    public String getModel() {
      return model;
    }

    public Builder setBuildTarget(String buildTarget) {
      this.buildTarget = buildTarget;
      return this;
    }

    public Builder setModel(String model) {
      this.model = model;
      return this;
    }

    private Builder(ModelName modelName) {
      buildTarget = modelName.buildTarget;
      model = modelName.model;
    }

    public ModelName build() {
      return new ModelName(this);
    }
  }
}
