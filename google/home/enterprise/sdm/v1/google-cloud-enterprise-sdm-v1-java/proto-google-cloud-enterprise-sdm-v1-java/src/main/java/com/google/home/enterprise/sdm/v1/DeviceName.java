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
public class DeviceName implements ResourceName {
  private static final PathTemplate ENTERPRISE_DEVICE =
      PathTemplate.createWithoutUrlEncoding("enterprises/{enterprise}/devices/{device}");
  private volatile Map<String, String> fieldValuesMap;
  private final String enterprise;
  private final String device;

  @Deprecated
  protected DeviceName() {
    enterprise = null;
    device = null;
  }

  private DeviceName(Builder builder) {
    enterprise = Preconditions.checkNotNull(builder.getEnterprise());
    device = Preconditions.checkNotNull(builder.getDevice());
  }

  public String getEnterprise() {
    return enterprise;
  }

  public String getDevice() {
    return device;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static DeviceName of(String enterprise, String device) {
    return newBuilder().setEnterprise(enterprise).setDevice(device).build();
  }

  public static String format(String enterprise, String device) {
    return newBuilder().setEnterprise(enterprise).setDevice(device).build().toString();
  }

  public static DeviceName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        ENTERPRISE_DEVICE.validatedMatch(
            formattedString, "DeviceName.parse: formattedString not in valid format");
    return of(matchMap.get("enterprise"), matchMap.get("device"));
  }

  public static List<DeviceName> parseList(List<String> formattedStrings) {
    List<DeviceName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<DeviceName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (DeviceName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return ENTERPRISE_DEVICE.matches(formattedString);
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
          if (device != null) {
            fieldMapBuilder.put("device", device);
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
    return ENTERPRISE_DEVICE.instantiate("enterprise", enterprise, "device", device);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      DeviceName that = ((DeviceName) o);
      return Objects.equals(this.enterprise, that.enterprise)
          && Objects.equals(this.device, that.device);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(enterprise);
    h *= 1000003;
    h ^= Objects.hashCode(device);
    return h;
  }

  /** Builder for enterprises/{enterprise}/devices/{device}. */
  public static class Builder {
    private String enterprise;
    private String device;

    protected Builder() {}

    public String getEnterprise() {
      return enterprise;
    }

    public String getDevice() {
      return device;
    }

    public Builder setEnterprise(String enterprise) {
      this.enterprise = enterprise;
      return this;
    }

    public Builder setDevice(String device) {
      this.device = device;
      return this;
    }

    private Builder(DeviceName deviceName) {
      enterprise = deviceName.enterprise;
      device = deviceName.device;
    }

    public DeviceName build() {
      return new DeviceName(this);
    }
  }
}
