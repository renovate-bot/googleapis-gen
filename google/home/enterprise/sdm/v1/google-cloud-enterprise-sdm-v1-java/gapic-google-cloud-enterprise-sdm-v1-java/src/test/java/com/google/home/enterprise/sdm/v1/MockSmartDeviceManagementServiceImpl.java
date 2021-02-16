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

import com.google.api.core.BetaApi;
import com.google.home.enterprise.sdm.v1.SmartDeviceManagementServiceGrpc.SmartDeviceManagementServiceImplBase;
import com.google.protobuf.AbstractMessage;
import io.grpc.stub.StreamObserver;
import java.util.ArrayList;
import java.util.LinkedList;
import java.util.List;
import java.util.Queue;
import javax.annotation.Generated;

@BetaApi
@Generated("by gapic-generator-java")
public class MockSmartDeviceManagementServiceImpl extends SmartDeviceManagementServiceImplBase {
  private List<AbstractMessage> requests;
  private Queue<Object> responses;

  public MockSmartDeviceManagementServiceImpl() {
    requests = new ArrayList<>();
    responses = new LinkedList<>();
  }

  public List<AbstractMessage> getRequests() {
    return requests;
  }

  public void addResponse(AbstractMessage response) {
    responses.add(response);
  }

  public void setResponses(List<AbstractMessage> responses) {
    this.responses = new LinkedList<Object>(responses);
  }

  public void addException(Exception exception) {
    responses.add(exception);
  }

  public void reset() {
    requests = new ArrayList<>();
    responses = new LinkedList<>();
  }

  @Override
  public void getDevice(GetDeviceRequest request, StreamObserver<Device> responseObserver) {
    Object response = responses.remove();
    if (response instanceof Device) {
      requests.add(request);
      responseObserver.onNext(((Device) response));
      responseObserver.onCompleted();
    } else if (response instanceof Exception) {
      responseObserver.onError(((Exception) response));
    } else {
      responseObserver.onError(
          new IllegalArgumentException(
              String.format(
                  "Unrecognized response type %s for method GetDevice, expected %s or %s",
                  response.getClass().getName(),
                  Device.class.getName(),
                  Exception.class.getName())));
    }
  }

  @Override
  public void listDevices(
      ListDevicesRequest request, StreamObserver<ListDevicesResponse> responseObserver) {
    Object response = responses.remove();
    if (response instanceof ListDevicesResponse) {
      requests.add(request);
      responseObserver.onNext(((ListDevicesResponse) response));
      responseObserver.onCompleted();
    } else if (response instanceof Exception) {
      responseObserver.onError(((Exception) response));
    } else {
      responseObserver.onError(
          new IllegalArgumentException(
              String.format(
                  "Unrecognized response type %s for method ListDevices, expected %s or %s",
                  response.getClass().getName(),
                  ListDevicesResponse.class.getName(),
                  Exception.class.getName())));
    }
  }

  @Override
  public void executeDeviceCommand(
      ExecuteDeviceCommandRequest request,
      StreamObserver<ExecuteDeviceCommandResponse> responseObserver) {
    Object response = responses.remove();
    if (response instanceof ExecuteDeviceCommandResponse) {
      requests.add(request);
      responseObserver.onNext(((ExecuteDeviceCommandResponse) response));
      responseObserver.onCompleted();
    } else if (response instanceof Exception) {
      responseObserver.onError(((Exception) response));
    } else {
      responseObserver.onError(
          new IllegalArgumentException(
              String.format(
                  "Unrecognized response type %s for method ExecuteDeviceCommand, expected %s or %s",
                  response.getClass().getName(),
                  ExecuteDeviceCommandResponse.class.getName(),
                  Exception.class.getName())));
    }
  }

  @Override
  public void getStructure(
      GetStructureRequest request, StreamObserver<Structure> responseObserver) {
    Object response = responses.remove();
    if (response instanceof Structure) {
      requests.add(request);
      responseObserver.onNext(((Structure) response));
      responseObserver.onCompleted();
    } else if (response instanceof Exception) {
      responseObserver.onError(((Exception) response));
    } else {
      responseObserver.onError(
          new IllegalArgumentException(
              String.format(
                  "Unrecognized response type %s for method GetStructure, expected %s or %s",
                  response.getClass().getName(),
                  Structure.class.getName(),
                  Exception.class.getName())));
    }
  }

  @Override
  public void listStructures(
      ListStructuresRequest request, StreamObserver<ListStructuresResponse> responseObserver) {
    Object response = responses.remove();
    if (response instanceof ListStructuresResponse) {
      requests.add(request);
      responseObserver.onNext(((ListStructuresResponse) response));
      responseObserver.onCompleted();
    } else if (response instanceof Exception) {
      responseObserver.onError(((Exception) response));
    } else {
      responseObserver.onError(
          new IllegalArgumentException(
              String.format(
                  "Unrecognized response type %s for method ListStructures, expected %s or %s",
                  response.getClass().getName(),
                  ListStructuresResponse.class.getName(),
                  Exception.class.getName())));
    }
  }

  @Override
  public void getRoom(GetRoomRequest request, StreamObserver<Room> responseObserver) {
    Object response = responses.remove();
    if (response instanceof Room) {
      requests.add(request);
      responseObserver.onNext(((Room) response));
      responseObserver.onCompleted();
    } else if (response instanceof Exception) {
      responseObserver.onError(((Exception) response));
    } else {
      responseObserver.onError(
          new IllegalArgumentException(
              String.format(
                  "Unrecognized response type %s for method GetRoom, expected %s or %s",
                  response.getClass().getName(), Room.class.getName(), Exception.class.getName())));
    }
  }

  @Override
  public void listRooms(
      ListRoomsRequest request, StreamObserver<ListRoomsResponse> responseObserver) {
    Object response = responses.remove();
    if (response instanceof ListRoomsResponse) {
      requests.add(request);
      responseObserver.onNext(((ListRoomsResponse) response));
      responseObserver.onCompleted();
    } else if (response instanceof Exception) {
      responseObserver.onError(((Exception) response));
    } else {
      responseObserver.onError(
          new IllegalArgumentException(
              String.format(
                  "Unrecognized response type %s for method ListRooms, expected %s or %s",
                  response.getClass().getName(),
                  ListRoomsResponse.class.getName(),
                  Exception.class.getName())));
    }
  }
}
