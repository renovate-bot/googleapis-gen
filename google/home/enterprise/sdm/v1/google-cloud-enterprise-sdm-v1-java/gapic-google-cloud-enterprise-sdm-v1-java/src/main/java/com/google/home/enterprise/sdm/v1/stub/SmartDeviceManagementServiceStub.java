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

package com.google.home.enterprise.sdm.v1.stub;

import static com.google.home.enterprise.sdm.v1.SmartDeviceManagementServiceClient.ListDevicesPagedResponse;
import static com.google.home.enterprise.sdm.v1.SmartDeviceManagementServiceClient.ListRoomsPagedResponse;
import static com.google.home.enterprise.sdm.v1.SmartDeviceManagementServiceClient.ListStructuresPagedResponse;

import com.google.api.gax.core.BackgroundResource;
import com.google.api.gax.rpc.UnaryCallable;
import com.google.home.enterprise.sdm.v1.Device;
import com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandRequest;
import com.google.home.enterprise.sdm.v1.ExecuteDeviceCommandResponse;
import com.google.home.enterprise.sdm.v1.GetDeviceRequest;
import com.google.home.enterprise.sdm.v1.GetRoomRequest;
import com.google.home.enterprise.sdm.v1.GetStructureRequest;
import com.google.home.enterprise.sdm.v1.ListDevicesRequest;
import com.google.home.enterprise.sdm.v1.ListDevicesResponse;
import com.google.home.enterprise.sdm.v1.ListRoomsRequest;
import com.google.home.enterprise.sdm.v1.ListRoomsResponse;
import com.google.home.enterprise.sdm.v1.ListStructuresRequest;
import com.google.home.enterprise.sdm.v1.ListStructuresResponse;
import com.google.home.enterprise.sdm.v1.Room;
import com.google.home.enterprise.sdm.v1.Structure;
import javax.annotation.Generated;

// AUTO-GENERATED DOCUMENTATION AND CLASS.
/**
 * Base stub class for the SmartDeviceManagementService service API.
 *
 * <p>This class is for advanced usage and reflects the underlying API directly.
 */
@Generated("by gapic-generator-java")
public abstract class SmartDeviceManagementServiceStub implements BackgroundResource {

  public UnaryCallable<GetDeviceRequest, Device> getDeviceCallable() {
    throw new UnsupportedOperationException("Not implemented: getDeviceCallable()");
  }

  public UnaryCallable<ListDevicesRequest, ListDevicesPagedResponse> listDevicesPagedCallable() {
    throw new UnsupportedOperationException("Not implemented: listDevicesPagedCallable()");
  }

  public UnaryCallable<ListDevicesRequest, ListDevicesResponse> listDevicesCallable() {
    throw new UnsupportedOperationException("Not implemented: listDevicesCallable()");
  }

  public UnaryCallable<ExecuteDeviceCommandRequest, ExecuteDeviceCommandResponse>
      executeDeviceCommandCallable() {
    throw new UnsupportedOperationException("Not implemented: executeDeviceCommandCallable()");
  }

  public UnaryCallable<GetStructureRequest, Structure> getStructureCallable() {
    throw new UnsupportedOperationException("Not implemented: getStructureCallable()");
  }

  public UnaryCallable<ListStructuresRequest, ListStructuresPagedResponse>
      listStructuresPagedCallable() {
    throw new UnsupportedOperationException("Not implemented: listStructuresPagedCallable()");
  }

  public UnaryCallable<ListStructuresRequest, ListStructuresResponse> listStructuresCallable() {
    throw new UnsupportedOperationException("Not implemented: listStructuresCallable()");
  }

  public UnaryCallable<GetRoomRequest, Room> getRoomCallable() {
    throw new UnsupportedOperationException("Not implemented: getRoomCallable()");
  }

  public UnaryCallable<ListRoomsRequest, ListRoomsPagedResponse> listRoomsPagedCallable() {
    throw new UnsupportedOperationException("Not implemented: listRoomsPagedCallable()");
  }

  public UnaryCallable<ListRoomsRequest, ListRoomsResponse> listRoomsCallable() {
    throw new UnsupportedOperationException("Not implemented: listRoomsCallable()");
  }

  @Override
  public abstract void close();
}
