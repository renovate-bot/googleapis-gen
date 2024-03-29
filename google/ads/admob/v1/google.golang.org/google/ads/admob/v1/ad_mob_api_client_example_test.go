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

package admob_test

import (
	"context"

	"google.golang.org/api/iterator"
	admobpb "google.golang.org/genproto/googleapis/ads/admob/v1"
	admob "google.golang.org/google/ads/admob/v1"
)

func ExampleNewAdMobApiClient() {
	ctx := context.Background()
	c, err := admob.NewAdMobApiClient(ctx)
	if err != nil {
		// TODO: Handle error.
	}
	defer c.Close()

	// TODO: Use client.
	_ = c
}

func ExampleAdMobApiClient_GetPublisherAccount() {
	ctx := context.Background()
	c, err := admob.NewAdMobApiClient(ctx)
	if err != nil {
		// TODO: Handle error.
	}
	defer c.Close()

	req := &admobpb.GetPublisherAccountRequest{
		// TODO: Fill request struct fields.
		// See https://pkg.go.dev/google.golang.org/genproto/googleapis/ads/admob/v1#GetPublisherAccountRequest.
	}
	resp, err := c.GetPublisherAccount(ctx, req)
	if err != nil {
		// TODO: Handle error.
	}
	// TODO: Use resp.
	_ = resp
}

func ExampleAdMobApiClient_ListPublisherAccounts() {
	ctx := context.Background()
	c, err := admob.NewAdMobApiClient(ctx)
	if err != nil {
		// TODO: Handle error.
	}
	defer c.Close()

	req := &admobpb.ListPublisherAccountsRequest{
		// TODO: Fill request struct fields.
		// See https://pkg.go.dev/google.golang.org/genproto/googleapis/ads/admob/v1#ListPublisherAccountsRequest.
	}
	it := c.ListPublisherAccounts(ctx, req)
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
