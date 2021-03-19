// Copyright 2021 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Code generated by protoc-gen-go_gapic. DO NOT EDIT.

package aiplatform_test

import (
	"context"

	aiplatform "cloud.google.com/go/aiplatform/apiv1beta1"
	"google.golang.org/api/iterator"
	aiplatformpb "google.golang.org/genproto/googleapis/cloud/aiplatform/v1beta1"
)

func ExampleNewVizierClient() {
	ctx := context.Background()
	c, err := aiplatform.NewVizierClient(ctx)
	if err != nil {
		// TODO: Handle error.
	}
	// TODO: Use client.
	_ = c
}

func ExampleVizierClient_CreateStudy() {
	// import aiplatformpb "google.golang.org/genproto/googleapis/cloud/aiplatform/v1beta1"

	ctx := context.Background()
	c, err := aiplatform.NewVizierClient(ctx)
	if err != nil {
		// TODO: Handle error.
	}

	req := &aiplatformpb.CreateStudyRequest{
		// TODO: Fill request struct fields.
	}
	resp, err := c.CreateStudy(ctx, req)
	if err != nil {
		// TODO: Handle error.
	}
	// TODO: Use resp.
	_ = resp
}

func ExampleVizierClient_GetStudy() {
	// import aiplatformpb "google.golang.org/genproto/googleapis/cloud/aiplatform/v1beta1"

	ctx := context.Background()
	c, err := aiplatform.NewVizierClient(ctx)
	if err != nil {
		// TODO: Handle error.
	}

	req := &aiplatformpb.GetStudyRequest{
		// TODO: Fill request struct fields.
	}
	resp, err := c.GetStudy(ctx, req)
	if err != nil {
		// TODO: Handle error.
	}
	// TODO: Use resp.
	_ = resp
}

func ExampleVizierClient_ListStudies() {
	// import aiplatformpb "google.golang.org/genproto/googleapis/cloud/aiplatform/v1beta1"
	// import "google.golang.org/api/iterator"

	ctx := context.Background()
	c, err := aiplatform.NewVizierClient(ctx)
	if err != nil {
		// TODO: Handle error.
	}

	req := &aiplatformpb.ListStudiesRequest{
		// TODO: Fill request struct fields.
	}
	it := c.ListStudies(ctx, req)
	for {
		resp, err := it.Next()
		if err == iterator.Done {
			break
		}
		if err != nil {
			// TODO: Handle error.
		}
		// TODO: Use resp.
		_ = resp
	}
}

func ExampleVizierClient_DeleteStudy() {
	ctx := context.Background()
	c, err := aiplatform.NewVizierClient(ctx)
	if err != nil {
		// TODO: Handle error.
	}

	req := &aiplatformpb.DeleteStudyRequest{
		// TODO: Fill request struct fields.
	}
	err = c.DeleteStudy(ctx, req)
	if err != nil {
		// TODO: Handle error.
	}
}

func ExampleVizierClient_LookupStudy() {
	// import aiplatformpb "google.golang.org/genproto/googleapis/cloud/aiplatform/v1beta1"

	ctx := context.Background()
	c, err := aiplatform.NewVizierClient(ctx)
	if err != nil {
		// TODO: Handle error.
	}

	req := &aiplatformpb.LookupStudyRequest{
		// TODO: Fill request struct fields.
	}
	resp, err := c.LookupStudy(ctx, req)
	if err != nil {
		// TODO: Handle error.
	}
	// TODO: Use resp.
	_ = resp
}

func ExampleVizierClient_SuggestTrials() {
	// import aiplatformpb "google.golang.org/genproto/googleapis/cloud/aiplatform/v1beta1"

	ctx := context.Background()
	c, err := aiplatform.NewVizierClient(ctx)
	if err != nil {
		// TODO: Handle error.
	}

	req := &aiplatformpb.SuggestTrialsRequest{
		// TODO: Fill request struct fields.
	}
	op, err := c.SuggestTrials(ctx, req)
	if err != nil {
		// TODO: Handle error.
	}

	resp, err := op.Wait(ctx)
	if err != nil {
		// TODO: Handle error.
	}
	// TODO: Use resp.
	_ = resp
}

func ExampleVizierClient_CreateTrial() {
	// import aiplatformpb "google.golang.org/genproto/googleapis/cloud/aiplatform/v1beta1"

	ctx := context.Background()
	c, err := aiplatform.NewVizierClient(ctx)
	if err != nil {
		// TODO: Handle error.
	}

	req := &aiplatformpb.CreateTrialRequest{
		// TODO: Fill request struct fields.
	}
	resp, err := c.CreateTrial(ctx, req)
	if err != nil {
		// TODO: Handle error.
	}
	// TODO: Use resp.
	_ = resp
}

func ExampleVizierClient_GetTrial() {
	// import aiplatformpb "google.golang.org/genproto/googleapis/cloud/aiplatform/v1beta1"

	ctx := context.Background()
	c, err := aiplatform.NewVizierClient(ctx)
	if err != nil {
		// TODO: Handle error.
	}

	req := &aiplatformpb.GetTrialRequest{
		// TODO: Fill request struct fields.
	}
	resp, err := c.GetTrial(ctx, req)
	if err != nil {
		// TODO: Handle error.
	}
	// TODO: Use resp.
	_ = resp
}

func ExampleVizierClient_ListTrials() {
	// import aiplatformpb "google.golang.org/genproto/googleapis/cloud/aiplatform/v1beta1"
	// import "google.golang.org/api/iterator"

	ctx := context.Background()
	c, err := aiplatform.NewVizierClient(ctx)
	if err != nil {
		// TODO: Handle error.
	}

	req := &aiplatformpb.ListTrialsRequest{
		// TODO: Fill request struct fields.
	}
	it := c.ListTrials(ctx, req)
	for {
		resp, err := it.Next()
		if err == iterator.Done {
			break
		}
		if err != nil {
			// TODO: Handle error.
		}
		// TODO: Use resp.
		_ = resp
	}
}

func ExampleVizierClient_AddTrialMeasurement() {
	// import aiplatformpb "google.golang.org/genproto/googleapis/cloud/aiplatform/v1beta1"

	ctx := context.Background()
	c, err := aiplatform.NewVizierClient(ctx)
	if err != nil {
		// TODO: Handle error.
	}

	req := &aiplatformpb.AddTrialMeasurementRequest{
		// TODO: Fill request struct fields.
	}
	resp, err := c.AddTrialMeasurement(ctx, req)
	if err != nil {
		// TODO: Handle error.
	}
	// TODO: Use resp.
	_ = resp
}

func ExampleVizierClient_CompleteTrial() {
	// import aiplatformpb "google.golang.org/genproto/googleapis/cloud/aiplatform/v1beta1"

	ctx := context.Background()
	c, err := aiplatform.NewVizierClient(ctx)
	if err != nil {
		// TODO: Handle error.
	}

	req := &aiplatformpb.CompleteTrialRequest{
		// TODO: Fill request struct fields.
	}
	resp, err := c.CompleteTrial(ctx, req)
	if err != nil {
		// TODO: Handle error.
	}
	// TODO: Use resp.
	_ = resp
}

func ExampleVizierClient_DeleteTrial() {
	ctx := context.Background()
	c, err := aiplatform.NewVizierClient(ctx)
	if err != nil {
		// TODO: Handle error.
	}

	req := &aiplatformpb.DeleteTrialRequest{
		// TODO: Fill request struct fields.
	}
	err = c.DeleteTrial(ctx, req)
	if err != nil {
		// TODO: Handle error.
	}
}

func ExampleVizierClient_CheckTrialEarlyStoppingState() {
	// import aiplatformpb "google.golang.org/genproto/googleapis/cloud/aiplatform/v1beta1"

	ctx := context.Background()
	c, err := aiplatform.NewVizierClient(ctx)
	if err != nil {
		// TODO: Handle error.
	}

	req := &aiplatformpb.CheckTrialEarlyStoppingStateRequest{
		// TODO: Fill request struct fields.
	}
	op, err := c.CheckTrialEarlyStoppingState(ctx, req)
	if err != nil {
		// TODO: Handle error.
	}

	resp, err := op.Wait(ctx)
	if err != nil {
		// TODO: Handle error.
	}
	// TODO: Use resp.
	_ = resp
}

func ExampleVizierClient_StopTrial() {
	// import aiplatformpb "google.golang.org/genproto/googleapis/cloud/aiplatform/v1beta1"

	ctx := context.Background()
	c, err := aiplatform.NewVizierClient(ctx)
	if err != nil {
		// TODO: Handle error.
	}

	req := &aiplatformpb.StopTrialRequest{
		// TODO: Fill request struct fields.
	}
	resp, err := c.StopTrial(ctx, req)
	if err != nil {
		// TODO: Handle error.
	}
	// TODO: Use resp.
	_ = resp
}

func ExampleVizierClient_ListOptimalTrials() {
	// import aiplatformpb "google.golang.org/genproto/googleapis/cloud/aiplatform/v1beta1"

	ctx := context.Background()
	c, err := aiplatform.NewVizierClient(ctx)
	if err != nil {
		// TODO: Handle error.
	}

	req := &aiplatformpb.ListOptimalTrialsRequest{
		// TODO: Fill request struct fields.
	}
	resp, err := c.ListOptimalTrials(ctx, req)
	if err != nil {
		// TODO: Handle error.
	}
	// TODO: Use resp.
	_ = resp
}
