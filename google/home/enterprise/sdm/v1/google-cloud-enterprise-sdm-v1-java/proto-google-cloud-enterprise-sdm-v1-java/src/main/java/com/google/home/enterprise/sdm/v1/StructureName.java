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

package com.google.home.enterprise.sdm.v1;

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
public class StructureName implements ResourceName {
  private static final PathTemplate ENTERPRISE_STRUCTURE =
      PathTemplate.createWithoutUrlEncoding("enterprises/{enterprise}/structures/{structure}");
  private volatile Map<String, String> fieldValuesMap;
  private final String enterprise;
  private final String structure;

  @Deprecated
  protected StructureName() {
    enterprise = null;
    structure = null;
  }

  private StructureName(Builder builder) {
    enterprise = Preconditions.checkNotNull(builder.getEnterprise());
    structure = Preconditions.checkNotNull(builder.getStructure());
  }

  public String getEnterprise() {
    return enterprise;
  }

  public String getStructure() {
    return structure;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static StructureName of(String enterprise, String structure) {
    return newBuilder().setEnterprise(enterprise).setStructure(structure).build();
  }

  public static String format(String enterprise, String structure) {
    return newBuilder().setEnterprise(enterprise).setStructure(structure).build().toString();
  }

  public static StructureName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        ENTERPRISE_STRUCTURE.validatedMatch(
            formattedString, "StructureName.parse: formattedString not in valid format");
    return of(matchMap.get("enterprise"), matchMap.get("structure"));
  }

  public static List<StructureName> parseList(List<String> formattedStrings) {
    List<StructureName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<StructureName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (StructureName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return ENTERPRISE_STRUCTURE.matches(formattedString);
  }

  @Override
  public Map<String, String> getFieldValuesMap() {
    if (fieldValuesMap == null) {
      synchronized (this) {
        if (fieldValuesMap == null) {
          ImmutableMap.Builder<String, String> fieldMapBuilder = ImmutableMap.builder();
          if (enterprise != null) {
            fieldMapBuilder.put("enterprise", enterprise);
          }
          if (structure != null) {
            fieldMapBuilder.put("structure", structure);
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
    return ENTERPRISE_STRUCTURE.instantiate("enterprise", enterprise, "structure", structure);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      StructureName that = ((StructureName) o);
      return Objects.equals(this.enterprise, that.enterprise)
          && Objects.equals(this.structure, that.structure);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(enterprise);
    h *= 1000003;
    h ^= Objects.hashCode(structure);
    return h;
  }

  /** Builder for enterprises/{enterprise}/structures/{structure}. */
  public static class Builder {
    private String enterprise;
    private String structure;

    protected Builder() {}

    public String getEnterprise() {
      return enterprise;
    }

    public String getStructure() {
      return structure;
    }

    public Builder setEnterprise(String enterprise) {
      this.enterprise = enterprise;
      return this;
    }

    public Builder setStructure(String structure) {
      this.structure = structure;
      return this;
    }

    private Builder(StructureName structureName) {
      enterprise = structureName.enterprise;
      structure = structureName.structure;
    }

    public StructureName build() {
      return new StructureName(this);
    }
  }
}
