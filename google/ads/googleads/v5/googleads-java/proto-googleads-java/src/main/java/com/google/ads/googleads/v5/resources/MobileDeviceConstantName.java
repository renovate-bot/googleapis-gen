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
public class MobileDeviceConstantName implements ResourceName {
  private static final PathTemplate MOBILE_DEVICE_CONSTANT =
      PathTemplate.createWithoutUrlEncoding("mobileDeviceConstants/{mobile_device_constant}");
  private volatile Map<String, String> fieldValuesMap;
  private final String mobileDeviceConstant;

  @Deprecated
  protected MobileDeviceConstantName() {
    mobileDeviceConstant = null;
  }

  private MobileDeviceConstantName(Builder builder) {
    mobileDeviceConstant = Preconditions.checkNotNull(builder.getMobileDeviceConstant());
  }

  public String getMobileDeviceConstant() {
    return mobileDeviceConstant;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static MobileDeviceConstantName of(String mobileDeviceConstant) {
    return newBuilder().setMobileDeviceConstant(mobileDeviceConstant).build();
  }

  public static String format(String mobileDeviceConstant) {
    return newBuilder().setMobileDeviceConstant(mobileDeviceConstant).build().toString();
  }

  public static MobileDeviceConstantName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        MOBILE_DEVICE_CONSTANT.validatedMatch(
            formattedString, "MobileDeviceConstantName.parse: formattedString not in valid format");
    return of(matchMap.get("mobile_device_constant"));
  }

  public static List<MobileDeviceConstantName> parseList(List<String> formattedStrings) {
    List<MobileDeviceConstantName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<MobileDeviceConstantName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (MobileDeviceConstantName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return MOBILE_DEVICE_CONSTANT.matches(formattedString);
  }

  @Override
  public Map<String, String> getFieldValuesMap() {
    if (fieldValuesMap == null) {
      synchronized (this) {
        if (fieldValuesMap == null) {
          ImmutableMap.Builder<String, String> fieldMapBuilder = ImmutableMap.builder();
          if (mobileDeviceConstant != null) {
            fieldMapBuilder.put("mobile_device_constant", mobileDeviceConstant);
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
    return MOBILE_DEVICE_CONSTANT.instantiate("mobile_device_constant", mobileDeviceConstant);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      MobileDeviceConstantName that = ((MobileDeviceConstantName) o);
      return Objects.equals(this.mobileDeviceConstant, that.mobileDeviceConstant);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(mobileDeviceConstant);
    return h;
  }

  /** Builder for mobileDeviceConstants/{mobile_device_constant}. */
  public static class Builder {
    private String mobileDeviceConstant;

    protected Builder() {}

    public String getMobileDeviceConstant() {
      return mobileDeviceConstant;
    }

    public Builder setMobileDeviceConstant(String mobileDeviceConstant) {
      this.mobileDeviceConstant = mobileDeviceConstant;
      return this;
    }

    private Builder(MobileDeviceConstantName mobileDeviceConstantName) {
      mobileDeviceConstant = mobileDeviceConstantName.mobileDeviceConstant;
    }

    public MobileDeviceConstantName build() {
      return new MobileDeviceConstantName(this);
    }
  }
}
