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

package migration_test

import (
	"context"

	migration "cloud.google.com/go/bigquery/migration/apiv2alpha"
	"google.golang.org/api/iterator"
	migrationpb "google.golang.org/genproto/googleapis/cloud/bigquery/migration/v2alpha"
)

func ExampleNewClient() {
	ctx := context.Background()
	c, err := migration.NewClient(ctx)
	if err != nil {
		// TODO: Handle error.
	}
	// TODO: Use client.
	_ = c
}

func ExampleClient_CreateMigrationWorkflow() {
	// import migrationpb "google.golang.org/genproto/googleapis/cloud/bigquery/migration/v2alpha"

	ctx := context.Background()
	c, err := migration.NewClient(ctx)
	if err != nil {
		// TODO: Handle error.
	}

	req := &migrationpb.CreateMigrationWorkflowRequest{
		// TODO: Fill request struct fields.
	}
	resp, err := c.CreateMigrationWorkflow(ctx, req)
	if err != nil {
		// TODO: Handle error.
	}
	// TODO: Use resp.
	_ = resp
}

func ExampleClient_GetMigrationWorkflow() {
	// import migrationpb "google.golang.org/genproto/googleapis/cloud/bigquery/migration/v2alpha"

	ctx := context.Background()
	c, err := migration.NewClient(ctx)
	if err != nil {
		// TODO: Handle error.
	}

	req := &migrationpb.GetMigrationWorkflowRequest{
		// TODO: Fill request struct fields.
	}
	resp, err := c.GetMigrationWorkflow(ctx, req)
	if err != nil {
		// TODO: Handle error.
	}
	// TODO: Use resp.
	_ = resp
}

func ExampleClient_ListMigrationWorkflows() {
	// import migrationpb "google.golang.org/genproto/googleapis/cloud/bigquery/migration/v2alpha"
	// import "google.golang.org/api/iterator"

	ctx := context.Background()
	c, err := migration.NewClient(ctx)
	if err != nil {
		// TODO: Handle error.
	}

	req := &migrationpb.ListMigrationWorkflowsRequest{
		// TODO: Fill request struct fields.
	}
	it := c.ListMigrationWorkflows(ctx, req)
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

func ExampleClient_DeleteMigrationWorkflow() {
	ctx := context.Background()
	c, err := migration.NewClient(ctx)
	if err != nil {
		// TODO: Handle error.
	}

	req := &migrationpb.DeleteMigrationWorkflowRequest{
		// TODO: Fill request struct fields.
	}
	err = c.DeleteMigrationWorkflow(ctx, req)
	if err != nil {
		// TODO: Handle error.
	}
}

func ExampleClient_StartMigrationWorkflow() {
	ctx := context.Background()
	c, err := migration.NewClient(ctx)
	if err != nil {
		// TODO: Handle error.
	}

	req := &migrationpb.StartMigrationWorkflowRequest{
		// TODO: Fill request struct fields.
	}
	err = c.StartMigrationWorkflow(ctx, req)
	if err != nil {
		// TODO: Handle error.
	}
}

func ExampleClient_GetMigrationSubtask() {
	// import migrationpb "google.golang.org/genproto/googleapis/cloud/bigquery/migration/v2alpha"

	ctx := context.Background()
	c, err := migration.NewClient(ctx)
	if err != nil {
		// TODO: Handle error.
	}

	req := &migrationpb.GetMigrationSubtaskRequest{
		// TODO: Fill request struct fields.
	}
	resp, err := c.GetMigrationSubtask(ctx, req)
	if err != nil {
		// TODO: Handle error.
	}
	// TODO: Use resp.
	_ = resp
}

func ExampleClient_ListMigrationSubtasks() {
	// import migrationpb "google.golang.org/genproto/googleapis/cloud/bigquery/migration/v2alpha"
	// import "google.golang.org/api/iterator"

	ctx := context.Background()
	c, err := migration.NewClient(ctx)
	if err != nil {
		// TODO: Handle error.
	}

	req := &migrationpb.ListMigrationSubtasksRequest{
		// TODO: Fill request struct fields.
	}
	it := c.ListMigrationSubtasks(ctx, req)
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
