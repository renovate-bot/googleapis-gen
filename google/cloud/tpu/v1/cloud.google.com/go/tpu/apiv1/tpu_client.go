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

package tpu

import (
	"context"
	"fmt"
	"math"
	"net/url"
	"time"

	"cloud.google.com/go/longrunning"
	lroauto "cloud.google.com/go/longrunning/autogen"
	"github.com/golang/protobuf/proto"
	gax "github.com/googleapis/gax-go/v2"
	"google.golang.org/api/iterator"
	"google.golang.org/api/option"
	"google.golang.org/api/option/internaloption"
	gtransport "google.golang.org/api/transport/grpc"
	tpupb "google.golang.org/genproto/googleapis/cloud/tpu/v1"
	longrunningpb "google.golang.org/genproto/googleapis/longrunning"
	"google.golang.org/grpc"
	"google.golang.org/grpc/metadata"
)

var newClientHook clientHook

// CallOptions contains the retry settings for each method of Client.
type CallOptions struct {
	ListNodes              []gax.CallOption
	GetNode                []gax.CallOption
	CreateNode             []gax.CallOption
	DeleteNode             []gax.CallOption
	ReimageNode            []gax.CallOption
	StopNode               []gax.CallOption
	StartNode              []gax.CallOption
	ListTensorFlowVersions []gax.CallOption
	GetTensorFlowVersion   []gax.CallOption
	ListAcceleratorTypes   []gax.CallOption
	GetAcceleratorType     []gax.CallOption
}

func defaultClientOptions() []option.ClientOption {
	return []option.ClientOption{
		internaloption.WithDefaultEndpoint("tpu.googleapis.com:443"),
		internaloption.WithDefaultMTLSEndpoint("tpu.mtls.googleapis.com:443"),
		internaloption.WithDefaultAudience("https://tpu.googleapis.com/"),
		internaloption.WithDefaultScopes(DefaultAuthScopes()...),
		option.WithGRPCDialOption(grpc.WithDisableServiceConfig()),
		option.WithGRPCDialOption(grpc.WithDefaultCallOptions(
			grpc.MaxCallRecvMsgSize(math.MaxInt32))),
	}
}

func defaultCallOptions() *CallOptions {
	return &CallOptions{
		ListNodes:              []gax.CallOption{},
		GetNode:                []gax.CallOption{},
		CreateNode:             []gax.CallOption{},
		DeleteNode:             []gax.CallOption{},
		ReimageNode:            []gax.CallOption{},
		StopNode:               []gax.CallOption{},
		StartNode:              []gax.CallOption{},
		ListTensorFlowVersions: []gax.CallOption{},
		GetTensorFlowVersion:   []gax.CallOption{},
		ListAcceleratorTypes:   []gax.CallOption{},
		GetAcceleratorType:     []gax.CallOption{},
	}
}

// Client is a client for interacting with Cloud TPU API.
//
// Methods, except Close, may be called concurrently. However, fields must not be modified concurrently with method calls.
type Client struct {
	// Connection pool of gRPC connections to the service.
	connPool gtransport.ConnPool

	// flag to opt out of default deadlines via GOOGLE_API_GO_EXPERIMENTAL_DISABLE_DEFAULT_DEADLINE
	disableDeadlines bool

	// The gRPC API client.
	client tpupb.TpuClient

	// LROClient is used internally to handle longrunning operations.
	// It is exposed so that its CallOptions can be modified if required.
	// Users should not Close this client.
	LROClient *lroauto.OperationsClient

	// The call options for this service.
	CallOptions *CallOptions

	// The x-goog-* metadata to be sent with each request.
	xGoogMetadata metadata.MD
}

// NewClient creates a new tpu client.
//
// Manages TPU nodes and other resources
//
// TPU API v1
func NewClient(ctx context.Context, opts ...option.ClientOption) (*Client, error) {
	clientOpts := defaultClientOptions()

	if newClientHook != nil {
		hookOpts, err := newClientHook(ctx, clientHookParams{})
		if err != nil {
			return nil, err
		}
		clientOpts = append(clientOpts, hookOpts...)
	}

	disableDeadlines, err := checkDisableDeadlines()
	if err != nil {
		return nil, err
	}

	connPool, err := gtransport.DialPool(ctx, append(clientOpts, opts...)...)
	if err != nil {
		return nil, err
	}
	c := &Client{
		connPool:         connPool,
		disableDeadlines: disableDeadlines,
		CallOptions:      defaultCallOptions(),

		client: tpupb.NewTpuClient(connPool),
	}
	c.setGoogleClientInfo()

	c.LROClient, err = lroauto.NewOperationsClient(ctx, gtransport.WithConnPool(connPool))
	if err != nil {
		// This error "should not happen", since we are just reusing old connection pool
		// and never actually need to dial.
		// If this does happen, we could leak connp. However, we cannot close conn:
		// If the user invoked the constructor with option.WithGRPCConn,
		// we would close a connection that's still in use.
		// TODO: investigate error conditions.
		return nil, err
	}
	return c, nil
}

// Connection returns a connection to the API service.
//
// Deprecated.
func (c *Client) Connection() *grpc.ClientConn {
	return c.connPool.Conn()
}

// Close closes the connection to the API service. The user should invoke this when
// the client is no longer required.
func (c *Client) Close() error {
	return c.connPool.Close()
}

// setGoogleClientInfo sets the name and version of the application in
// the `x-goog-api-client` header passed on each request. Intended for
// use by Google-written clients.
func (c *Client) setGoogleClientInfo(keyval ...string) {
	kv := append([]string{"gl-go", versionGo()}, keyval...)
	kv = append(kv, "gapic", versionClient, "gax", gax.Version, "grpc", grpc.Version)
	c.xGoogMetadata = metadata.Pairs("x-goog-api-client", gax.XGoogHeader(kv...))
}

// ListNodes lists nodes.
func (c *Client) ListNodes(ctx context.Context, req *tpupb.ListNodesRequest, opts ...gax.CallOption) *NodeIterator {
	md := metadata.Pairs("x-goog-request-params", fmt.Sprintf("%s=%v", "parent", url.QueryEscape(req.GetParent())))
	ctx = insertMetadata(ctx, c.xGoogMetadata, md)
	opts = append(c.CallOptions.ListNodes[0:len(c.CallOptions.ListNodes):len(c.CallOptions.ListNodes)], opts...)
	it := &NodeIterator{}
	req = proto.Clone(req).(*tpupb.ListNodesRequest)
	it.InternalFetch = func(pageSize int, pageToken string) ([]*tpupb.Node, string, error) {
		var resp *tpupb.ListNodesResponse
		req.PageToken = pageToken
		if pageSize > math.MaxInt32 {
			req.PageSize = math.MaxInt32
		} else {
			req.PageSize = int32(pageSize)
		}
		err := gax.Invoke(ctx, func(ctx context.Context, settings gax.CallSettings) error {
			var err error
			resp, err = c.client.ListNodes(ctx, req, settings.GRPC...)
			return err
		}, opts...)
		if err != nil {
			return nil, "", err
		}

		it.Response = resp
		return resp.GetNodes(), resp.GetNextPageToken(), nil
	}
	fetch := func(pageSize int, pageToken string) (string, error) {
		items, nextPageToken, err := it.InternalFetch(pageSize, pageToken)
		if err != nil {
			return "", err
		}
		it.items = append(it.items, items...)
		return nextPageToken, nil
	}
	it.pageInfo, it.nextFunc = iterator.NewPageInfo(fetch, it.bufLen, it.takeBuf)
	it.pageInfo.MaxSize = int(req.GetPageSize())
	it.pageInfo.Token = req.GetPageToken()
	return it
}

// GetNode gets the details of a node.
func (c *Client) GetNode(ctx context.Context, req *tpupb.GetNodeRequest, opts ...gax.CallOption) (*tpupb.Node, error) {
	if _, ok := ctx.Deadline(); !ok && !c.disableDeadlines {
		cctx, cancel := context.WithTimeout(ctx, 60000*time.Millisecond)
		defer cancel()
		ctx = cctx
	}
	md := metadata.Pairs("x-goog-request-params", fmt.Sprintf("%s=%v", "name", url.QueryEscape(req.GetName())))
	ctx = insertMetadata(ctx, c.xGoogMetadata, md)
	opts = append(c.CallOptions.GetNode[0:len(c.CallOptions.GetNode):len(c.CallOptions.GetNode)], opts...)
	var resp *tpupb.Node
	err := gax.Invoke(ctx, func(ctx context.Context, settings gax.CallSettings) error {
		var err error
		resp, err = c.client.GetNode(ctx, req, settings.GRPC...)
		return err
	}, opts...)
	if err != nil {
		return nil, err
	}
	return resp, nil
}

// CreateNode creates a node.
func (c *Client) CreateNode(ctx context.Context, req *tpupb.CreateNodeRequest, opts ...gax.CallOption) (*CreateNodeOperation, error) {
	if _, ok := ctx.Deadline(); !ok && !c.disableDeadlines {
		cctx, cancel := context.WithTimeout(ctx, 60000*time.Millisecond)
		defer cancel()
		ctx = cctx
	}
	md := metadata.Pairs("x-goog-request-params", fmt.Sprintf("%s=%v", "parent", url.QueryEscape(req.GetParent())))
	ctx = insertMetadata(ctx, c.xGoogMetadata, md)
	opts = append(c.CallOptions.CreateNode[0:len(c.CallOptions.CreateNode):len(c.CallOptions.CreateNode)], opts...)
	var resp *longrunningpb.Operation
	err := gax.Invoke(ctx, func(ctx context.Context, settings gax.CallSettings) error {
		var err error
		resp, err = c.client.CreateNode(ctx, req, settings.GRPC...)
		return err
	}, opts...)
	if err != nil {
		return nil, err
	}
	return &CreateNodeOperation{
		lro: longrunning.InternalNewOperation(c.LROClient, resp),
	}, nil
}

// DeleteNode deletes a node.
func (c *Client) DeleteNode(ctx context.Context, req *tpupb.DeleteNodeRequest, opts ...gax.CallOption) (*DeleteNodeOperation, error) {
	if _, ok := ctx.Deadline(); !ok && !c.disableDeadlines {
		cctx, cancel := context.WithTimeout(ctx, 60000*time.Millisecond)
		defer cancel()
		ctx = cctx
	}
	md := metadata.Pairs("x-goog-request-params", fmt.Sprintf("%s=%v", "name", url.QueryEscape(req.GetName())))
	ctx = insertMetadata(ctx, c.xGoogMetadata, md)
	opts = append(c.CallOptions.DeleteNode[0:len(c.CallOptions.DeleteNode):len(c.CallOptions.DeleteNode)], opts...)
	var resp *longrunningpb.Operation
	err := gax.Invoke(ctx, func(ctx context.Context, settings gax.CallSettings) error {
		var err error
		resp, err = c.client.DeleteNode(ctx, req, settings.GRPC...)
		return err
	}, opts...)
	if err != nil {
		return nil, err
	}
	return &DeleteNodeOperation{
		lro: longrunning.InternalNewOperation(c.LROClient, resp),
	}, nil
}

// ReimageNode reimages a node’s OS.
func (c *Client) ReimageNode(ctx context.Context, req *tpupb.ReimageNodeRequest, opts ...gax.CallOption) (*ReimageNodeOperation, error) {
	if _, ok := ctx.Deadline(); !ok && !c.disableDeadlines {
		cctx, cancel := context.WithTimeout(ctx, 60000*time.Millisecond)
		defer cancel()
		ctx = cctx
	}
	md := metadata.Pairs("x-goog-request-params", fmt.Sprintf("%s=%v", "name", url.QueryEscape(req.GetName())))
	ctx = insertMetadata(ctx, c.xGoogMetadata, md)
	opts = append(c.CallOptions.ReimageNode[0:len(c.CallOptions.ReimageNode):len(c.CallOptions.ReimageNode)], opts...)
	var resp *longrunningpb.Operation
	err := gax.Invoke(ctx, func(ctx context.Context, settings gax.CallSettings) error {
		var err error
		resp, err = c.client.ReimageNode(ctx, req, settings.GRPC...)
		return err
	}, opts...)
	if err != nil {
		return nil, err
	}
	return &ReimageNodeOperation{
		lro: longrunning.InternalNewOperation(c.LROClient, resp),
	}, nil
}

// StopNode stops a node.
func (c *Client) StopNode(ctx context.Context, req *tpupb.StopNodeRequest, opts ...gax.CallOption) (*StopNodeOperation, error) {
	if _, ok := ctx.Deadline(); !ok && !c.disableDeadlines {
		cctx, cancel := context.WithTimeout(ctx, 60000*time.Millisecond)
		defer cancel()
		ctx = cctx
	}
	md := metadata.Pairs("x-goog-request-params", fmt.Sprintf("%s=%v", "name", url.QueryEscape(req.GetName())))
	ctx = insertMetadata(ctx, c.xGoogMetadata, md)
	opts = append(c.CallOptions.StopNode[0:len(c.CallOptions.StopNode):len(c.CallOptions.StopNode)], opts...)
	var resp *longrunningpb.Operation
	err := gax.Invoke(ctx, func(ctx context.Context, settings gax.CallSettings) error {
		var err error
		resp, err = c.client.StopNode(ctx, req, settings.GRPC...)
		return err
	}, opts...)
	if err != nil {
		return nil, err
	}
	return &StopNodeOperation{
		lro: longrunning.InternalNewOperation(c.LROClient, resp),
	}, nil
}

// StartNode starts a node.
func (c *Client) StartNode(ctx context.Context, req *tpupb.StartNodeRequest, opts ...gax.CallOption) (*StartNodeOperation, error) {
	if _, ok := ctx.Deadline(); !ok && !c.disableDeadlines {
		cctx, cancel := context.WithTimeout(ctx, 60000*time.Millisecond)
		defer cancel()
		ctx = cctx
	}
	md := metadata.Pairs("x-goog-request-params", fmt.Sprintf("%s=%v", "name", url.QueryEscape(req.GetName())))
	ctx = insertMetadata(ctx, c.xGoogMetadata, md)
	opts = append(c.CallOptions.StartNode[0:len(c.CallOptions.StartNode):len(c.CallOptions.StartNode)], opts...)
	var resp *longrunningpb.Operation
	err := gax.Invoke(ctx, func(ctx context.Context, settings gax.CallSettings) error {
		var err error
		resp, err = c.client.StartNode(ctx, req, settings.GRPC...)
		return err
	}, opts...)
	if err != nil {
		return nil, err
	}
	return &StartNodeOperation{
		lro: longrunning.InternalNewOperation(c.LROClient, resp),
	}, nil
}

// ListTensorFlowVersions list TensorFlow versions supported by this API.
func (c *Client) ListTensorFlowVersions(ctx context.Context, req *tpupb.ListTensorFlowVersionsRequest, opts ...gax.CallOption) *TensorFlowVersionIterator {
	md := metadata.Pairs("x-goog-request-params", fmt.Sprintf("%s=%v", "parent", url.QueryEscape(req.GetParent())))
	ctx = insertMetadata(ctx, c.xGoogMetadata, md)
	opts = append(c.CallOptions.ListTensorFlowVersions[0:len(c.CallOptions.ListTensorFlowVersions):len(c.CallOptions.ListTensorFlowVersions)], opts...)
	it := &TensorFlowVersionIterator{}
	req = proto.Clone(req).(*tpupb.ListTensorFlowVersionsRequest)
	it.InternalFetch = func(pageSize int, pageToken string) ([]*tpupb.TensorFlowVersion, string, error) {
		var resp *tpupb.ListTensorFlowVersionsResponse
		req.PageToken = pageToken
		if pageSize > math.MaxInt32 {
			req.PageSize = math.MaxInt32
		} else {
			req.PageSize = int32(pageSize)
		}
		err := gax.Invoke(ctx, func(ctx context.Context, settings gax.CallSettings) error {
			var err error
			resp, err = c.client.ListTensorFlowVersions(ctx, req, settings.GRPC...)
			return err
		}, opts...)
		if err != nil {
			return nil, "", err
		}

		it.Response = resp
		return resp.GetTensorflowVersions(), resp.GetNextPageToken(), nil
	}
	fetch := func(pageSize int, pageToken string) (string, error) {
		items, nextPageToken, err := it.InternalFetch(pageSize, pageToken)
		if err != nil {
			return "", err
		}
		it.items = append(it.items, items...)
		return nextPageToken, nil
	}
	it.pageInfo, it.nextFunc = iterator.NewPageInfo(fetch, it.bufLen, it.takeBuf)
	it.pageInfo.MaxSize = int(req.GetPageSize())
	it.pageInfo.Token = req.GetPageToken()
	return it
}

// GetTensorFlowVersion gets TensorFlow Version.
func (c *Client) GetTensorFlowVersion(ctx context.Context, req *tpupb.GetTensorFlowVersionRequest, opts ...gax.CallOption) (*tpupb.TensorFlowVersion, error) {
	if _, ok := ctx.Deadline(); !ok && !c.disableDeadlines {
		cctx, cancel := context.WithTimeout(ctx, 60000*time.Millisecond)
		defer cancel()
		ctx = cctx
	}
	md := metadata.Pairs("x-goog-request-params", fmt.Sprintf("%s=%v", "name", url.QueryEscape(req.GetName())))
	ctx = insertMetadata(ctx, c.xGoogMetadata, md)
	opts = append(c.CallOptions.GetTensorFlowVersion[0:len(c.CallOptions.GetTensorFlowVersion):len(c.CallOptions.GetTensorFlowVersion)], opts...)
	var resp *tpupb.TensorFlowVersion
	err := gax.Invoke(ctx, func(ctx context.Context, settings gax.CallSettings) error {
		var err error
		resp, err = c.client.GetTensorFlowVersion(ctx, req, settings.GRPC...)
		return err
	}, opts...)
	if err != nil {
		return nil, err
	}
	return resp, nil
}

// ListAcceleratorTypes lists accelerator types supported by this API.
func (c *Client) ListAcceleratorTypes(ctx context.Context, req *tpupb.ListAcceleratorTypesRequest, opts ...gax.CallOption) *AcceleratorTypeIterator {
	md := metadata.Pairs("x-goog-request-params", fmt.Sprintf("%s=%v", "parent", url.QueryEscape(req.GetParent())))
	ctx = insertMetadata(ctx, c.xGoogMetadata, md)
	opts = append(c.CallOptions.ListAcceleratorTypes[0:len(c.CallOptions.ListAcceleratorTypes):len(c.CallOptions.ListAcceleratorTypes)], opts...)
	it := &AcceleratorTypeIterator{}
	req = proto.Clone(req).(*tpupb.ListAcceleratorTypesRequest)
	it.InternalFetch = func(pageSize int, pageToken string) ([]*tpupb.AcceleratorType, string, error) {
		var resp *tpupb.ListAcceleratorTypesResponse
		req.PageToken = pageToken
		if pageSize > math.MaxInt32 {
			req.PageSize = math.MaxInt32
		} else {
			req.PageSize = int32(pageSize)
		}
		err := gax.Invoke(ctx, func(ctx context.Context, settings gax.CallSettings) error {
			var err error
			resp, err = c.client.ListAcceleratorTypes(ctx, req, settings.GRPC...)
			return err
		}, opts...)
		if err != nil {
			return nil, "", err
		}

		it.Response = resp
		return resp.GetAcceleratorTypes(), resp.GetNextPageToken(), nil
	}
	fetch := func(pageSize int, pageToken string) (string, error) {
		items, nextPageToken, err := it.InternalFetch(pageSize, pageToken)
		if err != nil {
			return "", err
		}
		it.items = append(it.items, items...)
		return nextPageToken, nil
	}
	it.pageInfo, it.nextFunc = iterator.NewPageInfo(fetch, it.bufLen, it.takeBuf)
	it.pageInfo.MaxSize = int(req.GetPageSize())
	it.pageInfo.Token = req.GetPageToken()
	return it
}

// GetAcceleratorType gets AcceleratorType.
func (c *Client) GetAcceleratorType(ctx context.Context, req *tpupb.GetAcceleratorTypeRequest, opts ...gax.CallOption) (*tpupb.AcceleratorType, error) {
	if _, ok := ctx.Deadline(); !ok && !c.disableDeadlines {
		cctx, cancel := context.WithTimeout(ctx, 60000*time.Millisecond)
		defer cancel()
		ctx = cctx
	}
	md := metadata.Pairs("x-goog-request-params", fmt.Sprintf("%s=%v", "name", url.QueryEscape(req.GetName())))
	ctx = insertMetadata(ctx, c.xGoogMetadata, md)
	opts = append(c.CallOptions.GetAcceleratorType[0:len(c.CallOptions.GetAcceleratorType):len(c.CallOptions.GetAcceleratorType)], opts...)
	var resp *tpupb.AcceleratorType
	err := gax.Invoke(ctx, func(ctx context.Context, settings gax.CallSettings) error {
		var err error
		resp, err = c.client.GetAcceleratorType(ctx, req, settings.GRPC...)
		return err
	}, opts...)
	if err != nil {
		return nil, err
	}
	return resp, nil
}

// CreateNodeOperation manages a long-running operation from CreateNode.
type CreateNodeOperation struct {
	lro *longrunning.Operation
}

// CreateNodeOperation returns a new CreateNodeOperation from a given name.
// The name must be that of a previously created CreateNodeOperation, possibly from a different process.
func (c *Client) CreateNodeOperation(name string) *CreateNodeOperation {
	return &CreateNodeOperation{
		lro: longrunning.InternalNewOperation(c.LROClient, &longrunningpb.Operation{Name: name}),
	}
}

// Wait blocks until the long-running operation is completed, returning the response and any errors encountered.
//
// See documentation of Poll for error-handling information.
func (op *CreateNodeOperation) Wait(ctx context.Context, opts ...gax.CallOption) (*tpupb.Node, error) {
	var resp tpupb.Node
	if err := op.lro.WaitWithInterval(ctx, &resp, time.Minute, opts...); err != nil {
		return nil, err
	}
	return &resp, nil
}

// Poll fetches the latest state of the long-running operation.
//
// Poll also fetches the latest metadata, which can be retrieved by Metadata.
//
// If Poll fails, the error is returned and op is unmodified. If Poll succeeds and
// the operation has completed with failure, the error is returned and op.Done will return true.
// If Poll succeeds and the operation has completed successfully,
// op.Done will return true, and the response of the operation is returned.
// If Poll succeeds and the operation has not completed, the returned response and error are both nil.
func (op *CreateNodeOperation) Poll(ctx context.Context, opts ...gax.CallOption) (*tpupb.Node, error) {
	var resp tpupb.Node
	if err := op.lro.Poll(ctx, &resp, opts...); err != nil {
		return nil, err
	}
	if !op.Done() {
		return nil, nil
	}
	return &resp, nil
}

// Metadata returns metadata associated with the long-running operation.
// Metadata itself does not contact the server, but Poll does.
// To get the latest metadata, call this method after a successful call to Poll.
// If the metadata is not available, the returned metadata and error are both nil.
func (op *CreateNodeOperation) Metadata() (*tpupb.OperationMetadata, error) {
	var meta tpupb.OperationMetadata
	if err := op.lro.Metadata(&meta); err == longrunning.ErrNoMetadata {
		return nil, nil
	} else if err != nil {
		return nil, err
	}
	return &meta, nil
}

// Done reports whether the long-running operation has completed.
func (op *CreateNodeOperation) Done() bool {
	return op.lro.Done()
}

// Name returns the name of the long-running operation.
// The name is assigned by the server and is unique within the service from which the operation is created.
func (op *CreateNodeOperation) Name() string {
	return op.lro.Name()
}

// DeleteNodeOperation manages a long-running operation from DeleteNode.
type DeleteNodeOperation struct {
	lro *longrunning.Operation
}

// DeleteNodeOperation returns a new DeleteNodeOperation from a given name.
// The name must be that of a previously created DeleteNodeOperation, possibly from a different process.
func (c *Client) DeleteNodeOperation(name string) *DeleteNodeOperation {
	return &DeleteNodeOperation{
		lro: longrunning.InternalNewOperation(c.LROClient, &longrunningpb.Operation{Name: name}),
	}
}

// Wait blocks until the long-running operation is completed, returning the response and any errors encountered.
//
// See documentation of Poll for error-handling information.
func (op *DeleteNodeOperation) Wait(ctx context.Context, opts ...gax.CallOption) (*tpupb.Node, error) {
	var resp tpupb.Node
	if err := op.lro.WaitWithInterval(ctx, &resp, time.Minute, opts...); err != nil {
		return nil, err
	}
	return &resp, nil
}

// Poll fetches the latest state of the long-running operation.
//
// Poll also fetches the latest metadata, which can be retrieved by Metadata.
//
// If Poll fails, the error is returned and op is unmodified. If Poll succeeds and
// the operation has completed with failure, the error is returned and op.Done will return true.
// If Poll succeeds and the operation has completed successfully,
// op.Done will return true, and the response of the operation is returned.
// If Poll succeeds and the operation has not completed, the returned response and error are both nil.
func (op *DeleteNodeOperation) Poll(ctx context.Context, opts ...gax.CallOption) (*tpupb.Node, error) {
	var resp tpupb.Node
	if err := op.lro.Poll(ctx, &resp, opts...); err != nil {
		return nil, err
	}
	if !op.Done() {
		return nil, nil
	}
	return &resp, nil
}

// Metadata returns metadata associated with the long-running operation.
// Metadata itself does not contact the server, but Poll does.
// To get the latest metadata, call this method after a successful call to Poll.
// If the metadata is not available, the returned metadata and error are both nil.
func (op *DeleteNodeOperation) Metadata() (*tpupb.OperationMetadata, error) {
	var meta tpupb.OperationMetadata
	if err := op.lro.Metadata(&meta); err == longrunning.ErrNoMetadata {
		return nil, nil
	} else if err != nil {
		return nil, err
	}
	return &meta, nil
}

// Done reports whether the long-running operation has completed.
func (op *DeleteNodeOperation) Done() bool {
	return op.lro.Done()
}

// Name returns the name of the long-running operation.
// The name is assigned by the server and is unique within the service from which the operation is created.
func (op *DeleteNodeOperation) Name() string {
	return op.lro.Name()
}

// ReimageNodeOperation manages a long-running operation from ReimageNode.
type ReimageNodeOperation struct {
	lro *longrunning.Operation
}

// ReimageNodeOperation returns a new ReimageNodeOperation from a given name.
// The name must be that of a previously created ReimageNodeOperation, possibly from a different process.
func (c *Client) ReimageNodeOperation(name string) *ReimageNodeOperation {
	return &ReimageNodeOperation{
		lro: longrunning.InternalNewOperation(c.LROClient, &longrunningpb.Operation{Name: name}),
	}
}

// Wait blocks until the long-running operation is completed, returning the response and any errors encountered.
//
// See documentation of Poll for error-handling information.
func (op *ReimageNodeOperation) Wait(ctx context.Context, opts ...gax.CallOption) (*tpupb.Node, error) {
	var resp tpupb.Node
	if err := op.lro.WaitWithInterval(ctx, &resp, time.Minute, opts...); err != nil {
		return nil, err
	}
	return &resp, nil
}

// Poll fetches the latest state of the long-running operation.
//
// Poll also fetches the latest metadata, which can be retrieved by Metadata.
//
// If Poll fails, the error is returned and op is unmodified. If Poll succeeds and
// the operation has completed with failure, the error is returned and op.Done will return true.
// If Poll succeeds and the operation has completed successfully,
// op.Done will return true, and the response of the operation is returned.
// If Poll succeeds and the operation has not completed, the returned response and error are both nil.
func (op *ReimageNodeOperation) Poll(ctx context.Context, opts ...gax.CallOption) (*tpupb.Node, error) {
	var resp tpupb.Node
	if err := op.lro.Poll(ctx, &resp, opts...); err != nil {
		return nil, err
	}
	if !op.Done() {
		return nil, nil
	}
	return &resp, nil
}

// Metadata returns metadata associated with the long-running operation.
// Metadata itself does not contact the server, but Poll does.
// To get the latest metadata, call this method after a successful call to Poll.
// If the metadata is not available, the returned metadata and error are both nil.
func (op *ReimageNodeOperation) Metadata() (*tpupb.OperationMetadata, error) {
	var meta tpupb.OperationMetadata
	if err := op.lro.Metadata(&meta); err == longrunning.ErrNoMetadata {
		return nil, nil
	} else if err != nil {
		return nil, err
	}
	return &meta, nil
}

// Done reports whether the long-running operation has completed.
func (op *ReimageNodeOperation) Done() bool {
	return op.lro.Done()
}

// Name returns the name of the long-running operation.
// The name is assigned by the server and is unique within the service from which the operation is created.
func (op *ReimageNodeOperation) Name() string {
	return op.lro.Name()
}

// StartNodeOperation manages a long-running operation from StartNode.
type StartNodeOperation struct {
	lro *longrunning.Operation
}

// StartNodeOperation returns a new StartNodeOperation from a given name.
// The name must be that of a previously created StartNodeOperation, possibly from a different process.
func (c *Client) StartNodeOperation(name string) *StartNodeOperation {
	return &StartNodeOperation{
		lro: longrunning.InternalNewOperation(c.LROClient, &longrunningpb.Operation{Name: name}),
	}
}

// Wait blocks until the long-running operation is completed, returning the response and any errors encountered.
//
// See documentation of Poll for error-handling information.
func (op *StartNodeOperation) Wait(ctx context.Context, opts ...gax.CallOption) (*tpupb.Node, error) {
	var resp tpupb.Node
	if err := op.lro.WaitWithInterval(ctx, &resp, time.Minute, opts...); err != nil {
		return nil, err
	}
	return &resp, nil
}

// Poll fetches the latest state of the long-running operation.
//
// Poll also fetches the latest metadata, which can be retrieved by Metadata.
//
// If Poll fails, the error is returned and op is unmodified. If Poll succeeds and
// the operation has completed with failure, the error is returned and op.Done will return true.
// If Poll succeeds and the operation has completed successfully,
// op.Done will return true, and the response of the operation is returned.
// If Poll succeeds and the operation has not completed, the returned response and error are both nil.
func (op *StartNodeOperation) Poll(ctx context.Context, opts ...gax.CallOption) (*tpupb.Node, error) {
	var resp tpupb.Node
	if err := op.lro.Poll(ctx, &resp, opts...); err != nil {
		return nil, err
	}
	if !op.Done() {
		return nil, nil
	}
	return &resp, nil
}

// Metadata returns metadata associated with the long-running operation.
// Metadata itself does not contact the server, but Poll does.
// To get the latest metadata, call this method after a successful call to Poll.
// If the metadata is not available, the returned metadata and error are both nil.
func (op *StartNodeOperation) Metadata() (*tpupb.OperationMetadata, error) {
	var meta tpupb.OperationMetadata
	if err := op.lro.Metadata(&meta); err == longrunning.ErrNoMetadata {
		return nil, nil
	} else if err != nil {
		return nil, err
	}
	return &meta, nil
}

// Done reports whether the long-running operation has completed.
func (op *StartNodeOperation) Done() bool {
	return op.lro.Done()
}

// Name returns the name of the long-running operation.
// The name is assigned by the server and is unique within the service from which the operation is created.
func (op *StartNodeOperation) Name() string {
	return op.lro.Name()
}

// StopNodeOperation manages a long-running operation from StopNode.
type StopNodeOperation struct {
	lro *longrunning.Operation
}

// StopNodeOperation returns a new StopNodeOperation from a given name.
// The name must be that of a previously created StopNodeOperation, possibly from a different process.
func (c *Client) StopNodeOperation(name string) *StopNodeOperation {
	return &StopNodeOperation{
		lro: longrunning.InternalNewOperation(c.LROClient, &longrunningpb.Operation{Name: name}),
	}
}

// Wait blocks until the long-running operation is completed, returning the response and any errors encountered.
//
// See documentation of Poll for error-handling information.
func (op *StopNodeOperation) Wait(ctx context.Context, opts ...gax.CallOption) (*tpupb.Node, error) {
	var resp tpupb.Node
	if err := op.lro.WaitWithInterval(ctx, &resp, time.Minute, opts...); err != nil {
		return nil, err
	}
	return &resp, nil
}

// Poll fetches the latest state of the long-running operation.
//
// Poll also fetches the latest metadata, which can be retrieved by Metadata.
//
// If Poll fails, the error is returned and op is unmodified. If Poll succeeds and
// the operation has completed with failure, the error is returned and op.Done will return true.
// If Poll succeeds and the operation has completed successfully,
// op.Done will return true, and the response of the operation is returned.
// If Poll succeeds and the operation has not completed, the returned response and error are both nil.
func (op *StopNodeOperation) Poll(ctx context.Context, opts ...gax.CallOption) (*tpupb.Node, error) {
	var resp tpupb.Node
	if err := op.lro.Poll(ctx, &resp, opts...); err != nil {
		return nil, err
	}
	if !op.Done() {
		return nil, nil
	}
	return &resp, nil
}

// Metadata returns metadata associated with the long-running operation.
// Metadata itself does not contact the server, but Poll does.
// To get the latest metadata, call this method after a successful call to Poll.
// If the metadata is not available, the returned metadata and error are both nil.
func (op *StopNodeOperation) Metadata() (*tpupb.OperationMetadata, error) {
	var meta tpupb.OperationMetadata
	if err := op.lro.Metadata(&meta); err == longrunning.ErrNoMetadata {
		return nil, nil
	} else if err != nil {
		return nil, err
	}
	return &meta, nil
}

// Done reports whether the long-running operation has completed.
func (op *StopNodeOperation) Done() bool {
	return op.lro.Done()
}

// Name returns the name of the long-running operation.
// The name is assigned by the server and is unique within the service from which the operation is created.
func (op *StopNodeOperation) Name() string {
	return op.lro.Name()
}

// AcceleratorTypeIterator manages a stream of *tpupb.AcceleratorType.
type AcceleratorTypeIterator struct {
	items    []*tpupb.AcceleratorType
	pageInfo *iterator.PageInfo
	nextFunc func() error

	// Response is the raw response for the current page.
	// It must be cast to the RPC response type.
	// Calling Next() or InternalFetch() updates this value.
	Response interface{}

	// InternalFetch is for use by the Google Cloud Libraries only.
	// It is not part of the stable interface of this package.
	//
	// InternalFetch returns results from a single call to the underlying RPC.
	// The number of results is no greater than pageSize.
	// If there are no more results, nextPageToken is empty and err is nil.
	InternalFetch func(pageSize int, pageToken string) (results []*tpupb.AcceleratorType, nextPageToken string, err error)
}

// PageInfo supports pagination. See the google.golang.org/api/iterator package for details.
func (it *AcceleratorTypeIterator) PageInfo() *iterator.PageInfo {
	return it.pageInfo
}

// Next returns the next result. Its second return value is iterator.Done if there are no more
// results. Once Next returns Done, all subsequent calls will return Done.
func (it *AcceleratorTypeIterator) Next() (*tpupb.AcceleratorType, error) {
	var item *tpupb.AcceleratorType
	if err := it.nextFunc(); err != nil {
		return item, err
	}
	item = it.items[0]
	it.items = it.items[1:]
	return item, nil
}

func (it *AcceleratorTypeIterator) bufLen() int {
	return len(it.items)
}

func (it *AcceleratorTypeIterator) takeBuf() interface{} {
	b := it.items
	it.items = nil
	return b
}

// NodeIterator manages a stream of *tpupb.Node.
type NodeIterator struct {
	items    []*tpupb.Node
	pageInfo *iterator.PageInfo
	nextFunc func() error

	// Response is the raw response for the current page.
	// It must be cast to the RPC response type.
	// Calling Next() or InternalFetch() updates this value.
	Response interface{}

	// InternalFetch is for use by the Google Cloud Libraries only.
	// It is not part of the stable interface of this package.
	//
	// InternalFetch returns results from a single call to the underlying RPC.
	// The number of results is no greater than pageSize.
	// If there are no more results, nextPageToken is empty and err is nil.
	InternalFetch func(pageSize int, pageToken string) (results []*tpupb.Node, nextPageToken string, err error)
}

// PageInfo supports pagination. See the google.golang.org/api/iterator package for details.
func (it *NodeIterator) PageInfo() *iterator.PageInfo {
	return it.pageInfo
}

// Next returns the next result. Its second return value is iterator.Done if there are no more
// results. Once Next returns Done, all subsequent calls will return Done.
func (it *NodeIterator) Next() (*tpupb.Node, error) {
	var item *tpupb.Node
	if err := it.nextFunc(); err != nil {
		return item, err
	}
	item = it.items[0]
	it.items = it.items[1:]
	return item, nil
}

func (it *NodeIterator) bufLen() int {
	return len(it.items)
}

func (it *NodeIterator) takeBuf() interface{} {
	b := it.items
	it.items = nil
	return b
}

// TensorFlowVersionIterator manages a stream of *tpupb.TensorFlowVersion.
type TensorFlowVersionIterator struct {
	items    []*tpupb.TensorFlowVersion
	pageInfo *iterator.PageInfo
	nextFunc func() error

	// Response is the raw response for the current page.
	// It must be cast to the RPC response type.
	// Calling Next() or InternalFetch() updates this value.
	Response interface{}

	// InternalFetch is for use by the Google Cloud Libraries only.
	// It is not part of the stable interface of this package.
	//
	// InternalFetch returns results from a single call to the underlying RPC.
	// The number of results is no greater than pageSize.
	// If there are no more results, nextPageToken is empty and err is nil.
	InternalFetch func(pageSize int, pageToken string) (results []*tpupb.TensorFlowVersion, nextPageToken string, err error)
}

// PageInfo supports pagination. See the google.golang.org/api/iterator package for details.
func (it *TensorFlowVersionIterator) PageInfo() *iterator.PageInfo {
	return it.pageInfo
}

// Next returns the next result. Its second return value is iterator.Done if there are no more
// results. Once Next returns Done, all subsequent calls will return Done.
func (it *TensorFlowVersionIterator) Next() (*tpupb.TensorFlowVersion, error) {
	var item *tpupb.TensorFlowVersion
	if err := it.nextFunc(); err != nil {
		return item, err
	}
	item = it.items[0]
	it.items = it.items[1:]
	return item, nil
}

func (it *TensorFlowVersionIterator) bufLen() int {
	return len(it.items)
}

func (it *TensorFlowVersionIterator) takeBuf() interface{} {
	b := it.items
	it.items = nil
	return b
}
