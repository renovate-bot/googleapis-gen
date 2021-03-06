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

package com.google.cloud.bigquery.reservation.v1beta1;

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
public class BiReservationName implements ResourceName {
  private static final PathTemplate PROJECT_LOCATION_BIRESERVATION =
      PathTemplate.createWithoutUrlEncoding(
          "projects/{project}/locations/{location}/bireservation/{bireservation}");
  private volatile Map<String, String> fieldValuesMap;
  private final String project;
  private final String location;
  private final String bireservation;

  @Deprecated
  protected BiReservationName() {
    project = null;
    location = null;
    bireservation = null;
  }

  private BiReservationName(Builder builder) {
    project = Preconditions.checkNotNull(builder.getProject());
    location = Preconditions.checkNotNull(builder.getLocation());
    bireservation = Preconditions.checkNotNull(builder.getBireservation());
  }

  public String getProject() {
    return project;
  }

  public String getLocation() {
    return location;
  }

  public String getBireservation() {
    return bireservation;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static BiReservationName of(String project, String location, String bireservation) {
    return newBuilder()
        .setProject(project)
        .setLocation(location)
        .setBireservation(bireservation)
        .build();
  }

  public static String format(String project, String location, String bireservation) {
    return newBuilder()
        .setProject(project)
        .setLocation(location)
        .setBireservation(bireservation)
        .build()
        .toString();
  }

  public static BiReservationName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        PROJECT_LOCATION_BIRESERVATION.validatedMatch(
            formattedString, "BiReservationName.parse: formattedString not in valid format");
    return of(matchMap.get("project"), matchMap.get("location"), matchMap.get("bireservation"));
  }

  public static List<BiReservationName> parseList(List<String> formattedStrings) {
    List<BiReservationName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<BiReservationName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (BiReservationName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return PROJECT_LOCATION_BIRESERVATION.matches(formattedString);
  }

  @Override
  public Map<String, String> getFieldValuesMap() {
    if (fieldValuesMap == null) {
      synchronized (this) {
        if (fieldValuesMap == null) {
          ImmutableMap.Builder<String, String> fieldMapBuilder = ImmutableMap.builder();
          if (project != null) {
            fieldMapBuilder.put("project", project);
          }
          if (location != null) {
            fieldMapBuilder.put("location", location);
          }
          if (bireservation != null) {
            fieldMapBuilder.put("bireservation", bireservation);
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
    return PROJECT_LOCATION_BIRESERVATION.instantiate(
        "project", project, "location", location, "bireservation", bireservation);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      BiReservationName that = ((BiReservationName) o);
      return Objects.equals(this.project, that.project)
          && Objects.equals(this.location, that.location)
          && Objects.equals(this.bireservation, that.bireservation);
    }
    return false;
  }

  @Override
  public int hashCode() {
    int h = 1;
    h *= 1000003;
    h ^= Objects.hashCode(project);
    h *= 1000003;
    h ^= Objects.hashCode(location);
    h *= 1000003;
    h ^= Objects.hashCode(bireservation);
    return h;
  }

  /** Builder for projects/{project}/locations/{location}/bireservation/{bireservation}. */
  public static class Builder {
    private String project;
    private String location;
    private String bireservation;

    protected Builder() {}

    public String getProject() {
      return project;
    }

    public String getLocation() {
      return location;
    }

    public String getBireservation() {
      return bireservation;
    }

    public Builder setProject(String project) {
      this.project = project;
      return this;
    }

    public Builder setLocation(String location) {
      this.location = location;
      return this;
    }

    public Builder setBireservation(String bireservation) {
      this.bireservation = bireservation;
      return this;
    }

    private Builder(BiReservationName biReservationName) {
      this.project = biReservationName.project;
      this.location = biReservationName.location;
      this.bireservation = biReservationName.bireservation;
    }

    public BiReservationName build() {
      return new BiReservationName(this);
    }
  }
}
