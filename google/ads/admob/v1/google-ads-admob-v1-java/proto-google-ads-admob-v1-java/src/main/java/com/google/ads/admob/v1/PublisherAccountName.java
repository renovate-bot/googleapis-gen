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

package com.google.ads.admob.v1;

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
public class PublisherAccountName implements ResourceName {
  private static final PathTemplate PUBLISHER =
      PathTemplate.createWithoutUrlEncoding("accounts/{publisher}");
  private volatile Map<String, String> fieldValuesMap;
  private final String publisher;

  @Deprecated
  protected PublisherAccountName() {
    publisher = null;
  }

  private PublisherAccountName(Builder builder) {
    publisher = Preconditions.checkNotNull(builder.getPublisher());
  }

  public String getPublisher() {
    return publisher;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static PublisherAccountName of(String publisher) {
    return newBuilder().setPublisher(publisher).build();
  }

  public static String format(String publisher) {
    return newBuilder().setPublisher(publisher).build().toString();
  }

  public static PublisherAccountName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        PUBLISHER.validatedMatch(
            formattedString, "PublisherAccountName.parse: formattedString not in valid format");
    return of(matchMap.get("publisher"));
  }

  public static List<PublisherAccountName> parseList(List<String> formattedStrings) {
    List<PublisherAccountName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<PublisherAccountName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (PublisherAccountName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return PUBLISHER.matches(formattedString);
  }

  @Override
  public Map<String, String> getFieldValuesMap() {
    if (fieldValuesMap == null) {
      synchronized (this) {
        if (fieldValuesMap == null) {
          ImmutableMap.Builder<String, String> fieldMapBuilder = ImmutableMap.builder();
          if (publisher != null) {
            fieldMapBuilder.put("publisher", publisher);
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
    return PUBLISHER.instantiate("publisher", publisher);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      PublisherAccountName that = ((PublisherAccountName) o);
      return Objects.equals(this.publisher, that.publisher);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(publisher);
    return h;
  }

  /** Builder for accounts/{publisher}. */
  public static class Builder {
    private String publisher;

    protected Builder() {}

    public String getPublisher() {
      return publisher;
    }

    public Builder setPublisher(String publisher) {
      this.publisher = publisher;
      return this;
    }

    private Builder(PublisherAccountName publisherAccountName) {
      this.publisher = publisherAccountName.publisher;
    }

    public PublisherAccountName build() {
      return new PublisherAccountName(this);
    }
  }
}
