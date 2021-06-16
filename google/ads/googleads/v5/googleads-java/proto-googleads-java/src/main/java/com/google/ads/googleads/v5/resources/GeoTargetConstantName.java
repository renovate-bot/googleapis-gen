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

package com.google.ads.googleads.v5.resources;

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
public class GeoTargetConstantName implements ResourceName {
  private static final PathTemplate GEO_TARGET_CONSTANT =
      PathTemplate.createWithoutUrlEncoding("geoTargetConstants/{geo_target_constant}");
  private volatile Map<String, String> fieldValuesMap;
  private final String geoTargetConstant;

  @Deprecated
  protected GeoTargetConstantName() {
    geoTargetConstant = null;
  }

  private GeoTargetConstantName(Builder builder) {
    geoTargetConstant = Preconditions.checkNotNull(builder.getGeoTargetConstant());
  }

  public String getGeoTargetConstant() {
    return geoTargetConstant;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static GeoTargetConstantName of(String geoTargetConstant) {
    return newBuilder().setGeoTargetConstant(geoTargetConstant).build();
  }

  public static String format(String geoTargetConstant) {
    return newBuilder().setGeoTargetConstant(geoTargetConstant).build().toString();
  }

  public static GeoTargetConstantName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        GEO_TARGET_CONSTANT.validatedMatch(
            formattedString, "GeoTargetConstantName.parse: formattedString not in valid format");
    return of(matchMap.get("geo_target_constant"));
  }

  public static List<GeoTargetConstantName> parseList(List<String> formattedStrings) {
    List<GeoTargetConstantName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<GeoTargetConstantName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (GeoTargetConstantName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return GEO_TARGET_CONSTANT.matches(formattedString);
  }

  @Override
  public Map<String, String> getFieldValuesMap() {
    if (fieldValuesMap == null) {
      synchronized (this) {
        if (fieldValuesMap == null) {
          ImmutableMap.Builder<String, String> fieldMapBuilder = ImmutableMap.builder();
          if (geoTargetConstant != null) {
            fieldMapBuilder.put("geo_target_constant", geoTargetConstant);
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
    return GEO_TARGET_CONSTANT.instantiate("geo_target_constant", geoTargetConstant);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      GeoTargetConstantName that = ((GeoTargetConstantName) o);
      return Objects.equals(this.geoTargetConstant, that.geoTargetConstant);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(geoTargetConstant);
    return h;
  }

  /** Builder for geoTargetConstants/{geo_target_constant}. */
  public static class Builder {
    private String geoTargetConstant;

    protected Builder() {}

    public String getGeoTargetConstant() {
      return geoTargetConstant;
    }

    public Builder setGeoTargetConstant(String geoTargetConstant) {
      this.geoTargetConstant = geoTargetConstant;
      return this;
    }

    private Builder(GeoTargetConstantName geoTargetConstantName) {
      this.geoTargetConstant = geoTargetConstantName.geoTargetConstant;
    }

    public GeoTargetConstantName build() {
      return new GeoTargetConstantName(this);
    }
  }
}
