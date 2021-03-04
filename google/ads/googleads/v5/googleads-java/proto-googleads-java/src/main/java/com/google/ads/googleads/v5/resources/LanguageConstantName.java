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
public class LanguageConstantName implements ResourceName {
  private static final PathTemplate LANGUAGE_CONSTANT =
      PathTemplate.createWithoutUrlEncoding("languageConstants/{language_constant}");
  private volatile Map<String, String> fieldValuesMap;
  private final String languageConstant;

  @Deprecated
  protected LanguageConstantName() {
    languageConstant = null;
  }

  private LanguageConstantName(Builder builder) {
    languageConstant = Preconditions.checkNotNull(builder.getLanguageConstant());
  }

  public String getLanguageConstant() {
    return languageConstant;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static LanguageConstantName of(String languageConstant) {
    return newBuilder().setLanguageConstant(languageConstant).build();
  }

  public static String format(String languageConstant) {
    return newBuilder().setLanguageConstant(languageConstant).build().toString();
  }

  public static LanguageConstantName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        LANGUAGE_CONSTANT.validatedMatch(
            formattedString, "LanguageConstantName.parse: formattedString not in valid format");
    return of(matchMap.get("language_constant"));
  }

  public static List<LanguageConstantName> parseList(List<String> formattedStrings) {
    List<LanguageConstantName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<LanguageConstantName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (LanguageConstantName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return LANGUAGE_CONSTANT.matches(formattedString);
  }

  @Override
  public Map<String, String> getFieldValuesMap() {
    if (fieldValuesMap == null) {
      synchronized (this) {
        if (fieldValuesMap == null) {
          ImmutableMap.Builder<String, String> fieldMapBuilder = ImmutableMap.builder();
          if (languageConstant != null) {
            fieldMapBuilder.put("language_constant", languageConstant);
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
    return LANGUAGE_CONSTANT.instantiate("language_constant", languageConstant);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      LanguageConstantName that = ((LanguageConstantName) o);
      return Objects.equals(this.languageConstant, that.languageConstant);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(languageConstant);
    return h;
  }

  /** Builder for languageConstants/{language_constant}. */
  public static class Builder {
    private String languageConstant;

    protected Builder() {}

    public String getLanguageConstant() {
      return languageConstant;
    }

    public Builder setLanguageConstant(String languageConstant) {
      this.languageConstant = languageConstant;
      return this;
    }

    private Builder(LanguageConstantName languageConstantName) {
      languageConstant = languageConstantName.languageConstant;
    }

    public LanguageConstantName build() {
      return new LanguageConstantName(this);
    }
  }
}
