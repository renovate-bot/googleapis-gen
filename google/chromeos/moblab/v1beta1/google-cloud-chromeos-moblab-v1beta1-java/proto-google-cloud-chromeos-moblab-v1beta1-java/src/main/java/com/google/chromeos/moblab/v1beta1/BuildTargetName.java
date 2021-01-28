/*
 * Copyright 2020 Google LLC
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
public class BuildTargetName implements ResourceName {
  private static final PathTemplate BUILD_TARGET =
      PathTemplate.createWithoutUrlEncoding("buildTargets/{build_target}");
  private volatile Map<String, String> fieldValuesMap;
  private final String buildTarget;

  @Deprecated
  protected BuildTargetName() {
    buildTarget = null;
  }

  private BuildTargetName(Builder builder) {
    buildTarget = Preconditions.checkNotNull(builder.getBuildTarget());
  }

  public String getBuildTarget() {
    return buildTarget;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static BuildTargetName of(String buildTarget) {
    return newBuilder().setBuildTarget(buildTarget).build();
  }

  public static String format(String buildTarget) {
    return newBuilder().setBuildTarget(buildTarget).build().toString();
  }

  public static BuildTargetName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        BUILD_TARGET.validatedMatch(
            formattedString, "BuildTargetName.parse: formattedString not in valid format");
    return of(matchMap.get("build_target"));
  }

  public static List<BuildTargetName> parseList(List<String> formattedStrings) {
    List<BuildTargetName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<BuildTargetName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (BuildTargetName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return BUILD_TARGET.matches(formattedString);
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
    return BUILD_TARGET.instantiate("build_target", buildTarget);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      BuildTargetName that = ((BuildTargetName) o);
      return Objects.equals(this.buildTarget, that.buildTarget);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(buildTarget);
    return h;
  }

  /** Builder for buildTargets/{build_target}. */
  public static class Builder {
    private String buildTarget;

    protected Builder() {}

    public String getBuildTarget() {
      return buildTarget;
    }

    public Builder setBuildTarget(String buildTarget) {
      this.buildTarget = buildTarget;
      return this;
    }

    private Builder(BuildTargetName buildTargetName) {
      buildTarget = buildTargetName.buildTarget;
    }

    public BuildTargetName build() {
      return new BuildTargetName(this);
    }
  }
}
