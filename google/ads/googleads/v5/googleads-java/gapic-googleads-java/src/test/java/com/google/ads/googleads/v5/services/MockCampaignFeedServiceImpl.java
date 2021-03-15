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

package com.google.ads.googleads.v5.services;

import com.google.ads.googleads.v5.resources.CampaignFeed;
import com.google.ads.googleads.v5.services.CampaignFeedServiceGrpc.CampaignFeedServiceImplBase;
import com.google.api.core.BetaApi;
import com.google.protobuf.AbstractMessage;
import io.grpc.stub.StreamObserver;
import java.util.ArrayList;
import java.util.LinkedList;
import java.util.List;
import java.util.Queue;
import javax.annotation.Generated;

@BetaApi
@Generated("by gapic-generator-java")
public class MockCampaignFeedServiceImpl extends CampaignFeedServiceImplBase {
  private List<AbstractMessage> requests;
  private Queue<Object> responses;

  public MockCampaignFeedServiceImpl() {
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
  public void getCampaignFeed(
      GetCampaignFeedRequest request, StreamObserver<CampaignFeed> responseObserver) {
    Object response = responses.poll();
    if (response instanceof CampaignFeed) {
      requests.add(request);
      responseObserver.onNext(((CampaignFeed) response));
      responseObserver.onCompleted();
    } else if (response instanceof Exception) {
      responseObserver.onError(((Exception) response));
    } else {
      responseObserver.onError(
          new IllegalArgumentException(
              String.format(
                  "Unrecognized response type %s for method GetCampaignFeed, expected %s or %s",
                  response == null ? "null" : response.getClass().getName(),
                  CampaignFeed.class.getName(),
                  Exception.class.getName())));
    }
  }

  @Override
  public void mutateCampaignFeeds(
      MutateCampaignFeedsRequest request,
      StreamObserver<MutateCampaignFeedsResponse> responseObserver) {
    Object response = responses.poll();
    if (response instanceof MutateCampaignFeedsResponse) {
      requests.add(request);
      responseObserver.onNext(((MutateCampaignFeedsResponse) response));
      responseObserver.onCompleted();
    } else if (response instanceof Exception) {
      responseObserver.onError(((Exception) response));
    } else {
      responseObserver.onError(
          new IllegalArgumentException(
              String.format(
                  "Unrecognized response type %s for method MutateCampaignFeeds, expected %s or %s",
                  response == null ? "null" : response.getClass().getName(),
                  MutateCampaignFeedsResponse.class.getName(),
                  Exception.class.getName())));
    }
  }
}
