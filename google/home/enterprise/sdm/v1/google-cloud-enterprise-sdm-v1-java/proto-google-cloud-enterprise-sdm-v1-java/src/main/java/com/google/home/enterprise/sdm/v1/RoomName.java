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
public class RoomName implements ResourceName {
  private static final PathTemplate ENTERPRISE_STRUCTURE_ROOM =
      PathTemplate.createWithoutUrlEncoding(
          "enterprises/{enterprise}/structures/{structure}/rooms/{room}");
  private volatile Map<String, String> fieldValuesMap;
  private final String enterprise;
  private final String structure;
  private final String room;

  @Deprecated
  protected RoomName() {
    enterprise = null;
    structure = null;
    room = null;
  }

  private RoomName(Builder builder) {
    enterprise = Preconditions.checkNotNull(builder.getEnterprise());
    structure = Preconditions.checkNotNull(builder.getStructure());
    room = Preconditions.checkNotNull(builder.getRoom());
  }

  public String getEnterprise() {
    return enterprise;
  }

  public String getStructure() {
    return structure;
  }

  public String getRoom() {
    return room;
  }

  public static Builder newBuilder() {
    return new Builder();
  }

  public Builder toBuilder() {
    return new Builder(this);
  }

  public static RoomName of(String enterprise, String structure, String room) {
    return newBuilder().setEnterprise(enterprise).setStructure(structure).setRoom(room).build();
  }

  public static String format(String enterprise, String structure, String room) {
    return newBuilder()
        .setEnterprise(enterprise)
        .setStructure(structure)
        .setRoom(room)
        .build()
        .toString();
  }

  public static RoomName parse(String formattedString) {
    if (formattedString.isEmpty()) {
      return null;
    }
    Map<String, String> matchMap =
        ENTERPRISE_STRUCTURE_ROOM.validatedMatch(
            formattedString, "RoomName.parse: formattedString not in valid format");
    return of(matchMap.get("enterprise"), matchMap.get("structure"), matchMap.get("room"));
  }

  public static List<RoomName> parseList(List<String> formattedStrings) {
    List<RoomName> list = new ArrayList<>(formattedStrings.size());
    for (String formattedString : formattedStrings) {
      list.add(parse(formattedString));
    }
    return list;
  }

  public static List<String> toStringList(List<RoomName> values) {
    List<String> list = new ArrayList<>(values.size());
    for (RoomName value : values) {
      if (value == null) {
        list.add("");
      } else {
        list.add(value.toString());
      }
    }
    return list;
  }

  public static boolean isParsableFrom(String formattedString) {
    return ENTERPRISE_STRUCTURE_ROOM.matches(formattedString);
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
          if (room != null) {
            fieldMapBuilder.put("room", room);
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
    return ENTERPRISE_STRUCTURE_ROOM.instantiate(
        "enterprise", enterprise, "structure", structure, "room", room);
  }

  @Override
  public boolean equals(Object o) {
    if (o == this) {
      return true;
    }
    if (o != null || getClass() == o.getClass()) {
      RoomName that = ((RoomName) o);
      return Objects.equals(this.enterprise, that.enterprise)
          && Objects.equals(this.structure, that.structure)
          && Objects.equals(this.room, that.room);
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
    h *= 1000003;
    h ^= Objects.hashCode(room);
    return h;
  }

  /** Builder for enterprises/{enterprise}/structures/{structure}/rooms/{room}. */
  public static class Builder {
    private String enterprise;
    private String structure;
    private String room;

    protected Builder() {}

    public String getEnterprise() {
      return enterprise;
    }

    public String getStructure() {
      return structure;
    }

    public String getRoom() {
      return room;
    }

    public Builder setEnterprise(String enterprise) {
      this.enterprise = enterprise;
      return this;
    }

    public Builder setStructure(String structure) {
      this.structure = structure;
      return this;
    }

    public Builder setRoom(String room) {
      this.room = room;
      return this;
    }

    private Builder(RoomName roomName) {
      enterprise = roomName.enterprise;
      structure = roomName.structure;
      room = roomName.room;
    }

    public RoomName build() {
      return new RoomName(this);
    }
  }
}
