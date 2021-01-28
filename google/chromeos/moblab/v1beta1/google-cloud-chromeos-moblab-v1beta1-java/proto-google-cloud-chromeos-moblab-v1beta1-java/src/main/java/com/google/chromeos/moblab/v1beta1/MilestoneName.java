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
public class MilestoneName implements ResourceName {
  private static final PathTemplate MILESTONE =
      PathTemplate.createWithoutUrlEncoding("milestones/{milestone}");
  private volatile Map<String, String> fieldValuesMap;
  private final String milestone;

  @Deprecated
  protected MilestoneName() {
    milestone = null;
  }

  private MilestoneName(Builder builder) {
    milestone = Preconditions.checkNotNull(builder.getMilestone());
  }

  public String getMilestone() {
    return milestone;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static MilestoneName of(String milestone) {
    return newBuilder().setMilestone(milestone).build();
  }

  public static String format(String milestone) {
    return newBuilder().setMilestone(milestone).build().toString();
  }

  public static MilestoneName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        MILESTONE.validatedMatch(
            formattedString, "MilestoneName.parse: formattedString not in valid format");
    return of(matchMap.get("milestone"));
  }

  public static List<MilestoneName> parseList(List<String> formattedStrings) {
    List<MilestoneName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<MilestoneName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (MilestoneName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return MILESTONE.matches(formattedString);
  }

  @Override
  public Map<String, String> getFieldValuesMap() {
    if (fieldValuesMap == null) {
      synchronized (this) {
        if (fieldValuesMap == null) {
          ImmutableMap.Builder<String, String> fieldMapBuilder = ImmutableMap.builder();
          if (milestone != null) {
            fieldMapBuilder.put("milestone", milestone);
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
    return MILESTONE.instantiate("milestone", milestone);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      MilestoneName that = ((MilestoneName) o);
      return Objects.equals(this.milestone, that.milestone);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(milestone);
    return h;
  }

  /** Builder for milestones/{milestone}. */
  public static class Builder {
    private String milestone;

    protected Builder() {}

    public String getMilestone() {
      return milestone;
    }

    public Builder setMilestone(String milestone) {
      this.milestone = milestone;
      return this;
    }

    private Builder(MilestoneName milestoneName) {
      milestone = milestoneName.milestone;
    }

    public MilestoneName build() {
      return new MilestoneName(this);
    }
  }
}
