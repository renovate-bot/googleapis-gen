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
public class MediaFileName implements ResourceName {
  private static final PathTemplate CUSTOMER_MEDIA_FILE =
      PathTemplate.createWithoutUrlEncoding("customers/{customer}/mediaFiles/{media_file}");
  private volatile Map<String, String> fieldValuesMap;
  private final String customer;
  private final String mediaFile;

  @Deprecated
  protected MediaFileName() {
    customer = null;
    mediaFile = null;
  }

  private MediaFileName(Builder builder) {
    customer = Preconditions.checkNotNull(builder.getCustomer());
    mediaFile = Preconditions.checkNotNull(builder.getMediaFile());
  }

  public String getCustomer() {
    return customer;
  }

  public String getMediaFile() {
    return mediaFile;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static MediaFileName of(String customer, String mediaFile) {
    return newBuilder().setCustomer(customer).setMediaFile(mediaFile).build();
  }

  public static String format(String customer, String mediaFile) {
    return newBuilder().setCustomer(customer).setMediaFile(mediaFile).build().toString();
  }

  public static MediaFileName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        CUSTOMER_MEDIA_FILE.validatedMatch(
            formattedString, "MediaFileName.parse: formattedString not in valid format");
    return of(matchMap.get("customer"), matchMap.get("media_file"));
  }

  public static List<MediaFileName> parseList(List<String> formattedStrings) {
    List<MediaFileName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<MediaFileName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (MediaFileName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return CUSTOMER_MEDIA_FILE.matches(formattedString);
  }

  @Override
  public Map<String, String> getFieldValuesMap() {
    if (fieldValuesMap == null) {
      synchronized (this) {
        if (fieldValuesMap == null) {
          ImmutableMap.Builder<String, String> fieldMapBuilder = ImmutableMap.builder();
          if (customer != null) {
            fieldMapBuilder.put("customer", customer);
          }
          if (mediaFile != null) {
            fieldMapBuilder.put("media_file", mediaFile);
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
    return CUSTOMER_MEDIA_FILE.instantiate("customer", customer, "media_file", mediaFile);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      MediaFileName that = ((MediaFileName) o);
      return Objects.equals(this.customer, that.customer)
          && Objects.equals(this.mediaFile, that.mediaFile);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(customer);
    h *= 1000003;
    h ^= Objects.hashCode(mediaFile);
    return h;
  }

  /** Builder for customers/{customer}/mediaFiles/{media_file}. */
  public static class Builder {
    private String customer;
    private String mediaFile;

    protected Builder() {}

    public String getCustomer() {
      return customer;
    }

    public String getMediaFile() {
      return mediaFile;
    }

    public Builder setCustomer(String customer) {
      this.customer = customer;
      return this;
    }

    public Builder setMediaFile(String mediaFile) {
      this.mediaFile = mediaFile;
      return this;
    }

    private Builder(MediaFileName mediaFileName) {
      customer = mediaFileName.customer;
      mediaFile = mediaFileName.mediaFile;
    }

    public MediaFileName build() {
      return new MediaFileName(this);
    }
  }
}
