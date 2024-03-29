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

package asset

import (
	"context"
	"fmt"
	"math"
	"net/url"
	"time"

	"cloud.google.com/go/longrunning"
	lroauto "cloud.google.com/go/longrunning/autogen"
	gax "github.com/googleapis/gax-go/v2"
	"google.golang.org/api/option"
	"google.golang.org/api/option/internaloption"
	gtransport "google.golang.org/api/transport/grpc"
	assetpb "google.golang.org/genproto/googleapis/cloud/asset/v1p4beta1"
	longrunningpb "google.golang.org/genproto/googleapis/longrunning"
	"google.golang.org/grpc"
	"google.golang.org/grpc/codes"
	"google.golang.org/grpc/metadata"
)

var newClientHook clientHook

// CallOptions contains the retry settings for each method of Client.
type CallOptions struct {
	AnalyzeIamPolicy        []gax.CallOption
	ExportIamPolicyAnalysis []gax.CallOption
}

func defaultGRPCClientOptions() []option.ClientOption {
	return []option.ClientOption{
		internaloption.WithDefaultEndpoint("cloudasset.googleapis.com:443"),
		internaloption.WithDefaultMTLSEndpoint("cloudasset.mtls.googleapis.com:443"),
		internaloption.WithDefaultAudience("https://cloudasset.googleapis.com/"),
		internaloption.WithDefaultScopes(DefaultAuthScopes()...),
		internaloption.EnableJwtWithScope(),
		option.WithGRPCDialOption(grpc.WithDefaultCallOptions(
			grpc.MaxCallRecvMsgSize(math.MaxInt32))),
	}
}

func defaultCallOptions() *CallOptions {
	return &CallOptions{
		AnalyzeIamPolicy: []gax.CallOption{
			gax.WithRetry(func() gax.Retryer {
				return gax.OnCodes([]codes.Code{
					codes.Unavailable,
				}, gax.Backoff{
					Initial:    100 * time.Millisecond,
					Max:        60000 * time.Millisecond,
					Multiplier: 1.30,
				})
			}),
		},
		ExportIamPolicyAnalysis: []gax.CallOption{},
	}
}

// internalClient is an interface that defines the methods availaible from Cloud Asset API.
type internalClient interface {
	Close() error
	setGoogleClientInfo(...string)
	Connection() *grpc.ClientConn
	AnalyzeIamPolicy(context.Context, *assetpb.AnalyzeIamPolicyRequest, ...gax.CallOption) (*assetpb.AnalyzeIamPolicyResponse, error)
	ExportIamPolicyAnalysis(context.Context, *assetpb.ExportIamPolicyAnalysisRequest, ...gax.CallOption) (*ExportIamPolicyAnalysisOperation, error)
	ExportIamPolicyAnalysisOperation(name string) *ExportIamPolicyAnalysisOperation
}

// Client is a client for interacting with Cloud Asset API.
// Methods, except Close, may be called concurrently. However, fields must not be modified concurrently with method calls.
//
// Asset service definition.
type Client struct {
	// The internal transport-dependent client.
	internalClient internalClient

	// The call options for this service.
	CallOptions *CallOptions

	// LROClient is used internally to handle long-running operations.
	// It is exposed so that its CallOptions can be modified if required.
	// Users should not Close this client.
	LROClient *lroauto.OperationsClient
}

// Wrapper methods routed to the internal client.

// Close closes the connection to the API service. The user should invoke this when
// the client is no longer required.
func (c *Client) Close() error {
	return c.internalClient.Close()
}

// setGoogleClientInfo sets the name and version of the application in
// the `x-goog-api-client` header passed on each request. Intended for
// use by Google-written clients.
func (c *Client) setGoogleClientInfo(keyval ...string) {
	c.internalClient.setGoogleClientInfo(keyval...)
}

// Connection returns a connection to the API service.
//
// Deprecated.
func (c *Client) Connection() *grpc.ClientConn {
	return c.internalClient.Connection()
}

// AnalyzeIamPolicy analyzes IAM policies based on the specified request. Returns
// a list of IamPolicyAnalysisResult matching the request.
func (c *Client) AnalyzeIamPolicy(ctx context.Context, req *assetpb.AnalyzeIamPolicyRequest, opts ...gax.CallOption) (*assetpb.AnalyzeIamPolicyResponse, error) {
	return c.internalClient.AnalyzeIamPolicy(ctx, req, opts...)
}

// ExportIamPolicyAnalysis exports IAM policy analysis based on the specified request. This API
// implements the google.longrunning.Operation API allowing you to keep
// track of the export. The metadata contains the request to help callers to
// map responses to requests.
func (c *Client) ExportIamPolicyAnalysis(ctx context.Context, req *assetpb.ExportIamPolicyAnalysisRequest, opts ...gax.CallOption) (*ExportIamPolicyAnalysisOperation, error) {
	return c.internalClient.ExportIamPolicyAnalysis(ctx, req, opts...)
}

// ExportIamPolicyAnalysisOperation returns a new ExportIamPolicyAnalysisOperation from a given name.
// The name must be that of a previously created ExportIamPolicyAnalysisOperation, possibly from a different process.
func (c *Client) ExportIamPolicyAnalysisOperation(name string) *ExportIamPolicyAnalysisOperation {
	return c.internalClient.ExportIamPolicyAnalysisOperation(name)
}

// gRPCClient is a client for interacting with Cloud Asset API over gRPC transport.
//
// Methods, except Close, may be called concurrently. However, fields must not be modified concurrently with method calls.
type gRPCClient struct {
	// Connection pool of gRPC connections to the service.
	connPool gtransport.ConnPool

	// flag to opt out of default deadlines via GOOGLE_API_GO_EXPERIMENTAL_DISABLE_DEFAULT_DEADLINE
	disableDeadlines bool

	// Points back to the CallOptions field of the containing Client
	CallOptions **CallOptions

	// The gRPC API client.
	client assetpb.AssetServiceClient

	// LROClient is used internally to handle long-running operations.
	// It is exposed so that its CallOptions can be modified if required.
	// Users should not Close this client.
	LROClient **lroauto.OperationsClient

	// The x-goog-* metadata to be sent with each request.
	xGoogMetadata metadata.MD
}

// NewClient creates a new asset service client based on gRPC.
// The returned client must be Closed when it is done being used to clean up its underlying connections.
//
// Asset service definition.
func NewClient(ctx context.Context, opts ...option.ClientOption) (*Client, error) {
	clientOpts := defaultGRPCClientOptions()
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
	client := Client{CallOptions: defaultCallOptions()}

	c := &gRPCClient{
		connPool:         connPool,
		disableDeadlines: disableDeadlines,
		client:           assetpb.NewAssetServiceClient(connPool),
		CallOptions:      &client.CallOptions,
	}
	c.setGoogleClientInfo()

	client.internalClient = c

	client.LROClient, err = lroauto.NewOperationsClient(ctx, gtransport.WithConnPool(connPool))
	if err != nil {
		// This error "should not happen", since we are just reusing old connection pool
		// and never actually need to dial.
		// If this does happen, we could leak connp. However, we cannot close conn:
		// If the user invoked the constructor with option.WithGRPCConn,
		// we would close a connection that's still in use.
		// TODO: investigate error conditions.
		return nil, err
	}
	c.LROClient = &client.LROClient
	return &client, nil
}

// Connection returns a connection to the API service.
//
// Deprecated.
func (c *gRPCClient) Connection() *grpc.ClientConn {
	return c.connPool.Conn()
}

// setGoogleClientInfo sets the name and version of the application in
// the `x-goog-api-client` header passed on each request. Intended for
// use by Google-written clients.
func (c *gRPCClient) setGoogleClientInfo(keyval ...string) {
	kv := append([]string{"gl-go", versionGo()}, keyval...)
	kv = append(kv, "gapic", versionClient, "gax", gax.Version, "grpc", grpc.Version)
	c.xGoogMetadata = metadata.Pairs("x-goog-api-client", gax.XGoogHeader(kv...))
}

// Close closes the connection to the API service. The user should invoke this when
// the client is no longer required.
func (c *gRPCClient) Close() error {
	return c.connPool.Close()
}

func (c *gRPCClient) AnalyzeIamPolicy(ctx context.Context, req *assetpb.AnalyzeIamPolicyRequest, opts ...gax.CallOption) (*assetpb.AnalyzeIamPolicyResponse, error) {
	if _, ok := ctx.Deadline(); !ok && !c.disableDeadlines {
		cctx, cancel := context.WithTimeout(ctx, 300000*time.Millisecond)
		defer cancel()
		ctx = cctx
	}
	md := metadata.Pairs("x-goog-request-params", fmt.Sprintf("%s=%v", "analysis_query.parent", url.QueryEscape(req.GetAnalysisQuery().GetParent())))
	ctx = insertMetadata(ctx, c.xGoogMetadata, md)
	opts = append((*c.CallOptions).AnalyzeIamPolicy[0:len((*c.CallOptions).AnalyzeIamPolicy):len((*c.CallOptions).AnalyzeIamPolicy)], opts...)
	var resp *assetpb.AnalyzeIamPolicyResponse
	err := gax.Invoke(ctx, func(ctx context.Context, settings gax.CallSettings) error {
		var err error
		resp, err = c.client.AnalyzeIamPolicy(ctx, req, settings.GRPC...)
		return err
	}, opts...)
	if err != nil {
		return nil, err
	}
	return resp, nil
}

func (c *gRPCClient) ExportIamPolicyAnalysis(ctx context.Context, req *assetpb.ExportIamPolicyAnalysisRequest, opts ...gax.CallOption) (*ExportIamPolicyAnalysisOperation, error) {
	if _, ok := ctx.Deadline(); !ok && !c.disableDeadlines {
		cctx, cancel := context.WithTimeout(ctx, 60000*time.Millisecond)
		defer cancel()
		ctx = cctx
	}
	md := metadata.Pairs("x-goog-request-params", fmt.Sprintf("%s=%v", "analysis_query.parent", url.QueryEscape(req.GetAnalysisQuery().GetParent())))
	ctx = insertMetadata(ctx, c.xGoogMetadata, md)
	opts = append((*c.CallOptions).ExportIamPolicyAnalysis[0:len((*c.CallOptions).ExportIamPolicyAnalysis):len((*c.CallOptions).ExportIamPolicyAnalysis)], opts...)
	var resp *longrunningpb.Operation
	err := gax.Invoke(ctx, func(ctx context.Context, settings gax.CallSettings) error {
		var err error
		resp, err = c.client.ExportIamPolicyAnalysis(ctx, req, settings.GRPC...)
		return err
	}, opts...)
	if err != nil {
		return nil, err
	}
	return &ExportIamPolicyAnalysisOperation{
		lro: longrunning.InternalNewOperation(*c.LROClient, resp),
	}, nil
}

// ExportIamPolicyAnalysisOperation manages a long-running operation from ExportIamPolicyAnalysis.
type ExportIamPolicyAnalysisOperation struct {
	lro *longrunning.Operation
}

// ExportIamPolicyAnalysisOperation returns a new ExportIamPolicyAnalysisOperation from a given name.
// The name must be that of a previously created ExportIamPolicyAnalysisOperation, possibly from a different process.
func (c *gRPCClient) ExportIamPolicyAnalysisOperation(name string) *ExportIamPolicyAnalysisOperation {
	return &ExportIamPolicyAnalysisOperation{
		lro: longrunning.InternalNewOperation(*c.LROClient, &longrunningpb.Operation{Name: name}),
	}
}

// Wait blocks until the long-running operation is completed, returning the response and any errors encountered.
//
// See documentation of Poll for error-handling information.
func (op *ExportIamPolicyAnalysisOperation) Wait(ctx context.Context, opts ...gax.CallOption) (*assetpb.ExportIamPolicyAnalysisResponse, error) {
	var resp assetpb.ExportIamPolicyAnalysisResponse
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
func (op *ExportIamPolicyAnalysisOperation) Poll(ctx context.Context, opts ...gax.CallOption) (*assetpb.ExportIamPolicyAnalysisResponse, error) {
	var resp assetpb.ExportIamPolicyAnalysisResponse
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
func (op *ExportIamPolicyAnalysisOperation) Metadata() (*assetpb.ExportIamPolicyAnalysisRequest, error) {
	var meta assetpb.ExportIamPolicyAnalysisRequest
	if err := op.lro.Metadata(&meta); err == longrunning.ErrNoMetadata {
		return nil, nil
	} else if err != nil {
		return nil, err
	}
	return &meta, nil
}

// Done reports whether the long-running operation has completed.
func (op *ExportIamPolicyAnalysisOperation) Done() bool {
	return op.lro.Done()
}

// Name returns the name of the long-running operation.
// The name is assigned by the server and is unique within the service from which the operation is created.
func (op *ExportIamPolicyAnalysisOperation) Name() string {
	return op.lro.Name()
}
