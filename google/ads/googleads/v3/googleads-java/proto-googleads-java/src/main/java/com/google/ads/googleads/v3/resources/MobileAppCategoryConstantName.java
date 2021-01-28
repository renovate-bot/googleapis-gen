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

package com.google.ads.googleads.v3.resources;

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
public class MobileAppCategoryConstantName implements ResourceName {
  private static final PathTemplate MOBILE_APP_CATEGORY_CONSTANT =
      PathTemplate.createWithoutUrlEncoding(
          "mobileAppCategoryConstants/{mobile_app_category_constant}");
  private volatile Map<String, String> fieldValuesMap;
  private final String mobileAppCategoryConstant;

  @Deprecated
  protected MobileAppCategoryConstantName() {
    mobileAppCategoryConstant = null;
  }

  private MobileAppCategoryConstantName(Builder builder) {
    mobileAppCategoryConstant = Preconditions.checkNotNull(builder.getMobileAppCategoryConstant());
  }

  public String getMobileAppCategoryConstant() {
    return mobileAppCategoryConstant;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static MobileAppCategoryConstantName of(String mobileAppCategoryConstant) {
    return newBuilder().setMobileAppCategoryConstant(mobileAppCategoryConstant).build();
  }

  public static String format(String mobileAppCategoryConstant) {
    return newBuilder().setMobileAppCategoryConstant(mobileAppCategoryConstant).build().toString();
  }

  public static MobileAppCategoryConstantName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        MOBILE_APP_CATEGORY_CONSTANT.validatedMatch(
            formattedString,
            "MobileAppCategoryConstantName.parse: formattedString not in valid format");
    return of(matchMap.get("mobile_app_category_constant"));
  }

  public static List<MobileAppCategoryConstantName> parseList(List<String> formattedStrings) {
    List<MobileAppCategoryConstantName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<MobileAppCategoryConstantName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (MobileAppCategoryConstantName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return MOBILE_APP_CATEGORY_CONSTANT.matches(formattedString);
  }

  @Override
  public Map<String, String> getFieldValuesMap() {
    if (fieldValuesMap == null) {
      synchronized (this) {
        if (fieldValuesMap == null) {
          ImmutableMap.Builder<String, String> fieldMapBuilder = ImmutableMap.builder();
          if (mobileAppCategoryConstant != null) {
            fieldMapBuilder.put("mobile_app_category_constant", mobileAppCategoryConstant);
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
    return MOBILE_APP_CATEGORY_CONSTANT.instantiate(
        "mobile_app_category_constant", mobileAppCategoryConstant);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      MobileAppCategoryConstantName that = ((MobileAppCategoryConstantName) o);
      return Objects.equals(this.mobileAppCategoryConstant, that.mobileAppCategoryConstant);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(mobileAppCategoryConstant);
    return h;
  }

  /** Builder for mobileAppCategoryConstants/{mobile_app_category_constant}. */
  public static class Builder {
    private String mobileAppCategoryConstant;

    protected Builder() {}

    public String getMobileAppCategoryConstant() {
      return mobileAppCategoryConstant;
    }

    public Builder setMobileAppCategoryConstant(String mobileAppCategoryConstant) {
      this.mobileAppCategoryConstant = mobileAppCategoryConstant;
      return this;
    }

    private Builder(MobileAppCategoryConstantName mobileAppCategoryConstantName) {
      mobileAppCategoryConstant = mobileAppCategoryConstantName.mobileAppCategoryConstant;
    }

    public MobileAppCategoryConstantName build() {
      return new MobileAppCategoryConstantName(this);
    }
  }
}
