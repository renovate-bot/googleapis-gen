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

package cloudprofiler

import (
	"context"
	"fmt"
	"math"
	"net/url"
	"time"

	gax "github.com/googleapis/gax-go/v2"
	"google.golang.org/api/option"
	"google.golang.org/api/option/internaloption"
	gtransport "google.golang.org/api/transport/grpc"
	cloudprofilerpb "google.golang.org/genproto/googleapis/devtools/cloudprofiler/v2"
	"google.golang.org/grpc"
	"google.golang.org/grpc/metadata"
)

var newProfilerClientHook clientHook

// ProfilerCallOptions contains the retry settings for each method of ProfilerClient.
type ProfilerCallOptions struct {
	CreateProfile        []gax.CallOption
	CreateOfflineProfile []gax.CallOption
	UpdateProfile        []gax.CallOption
}

func defaultProfilerGRPCClientOptions() []option.ClientOption {
	return []option.ClientOption{
		internaloption.WithDefaultEndpoint("cloudprofiler.googleapis.com:443"),
		internaloption.WithDefaultMTLSEndpoint("cloudprofiler.mtls.googleapis.com:443"),
		internaloption.WithDefaultAudience("https://cloudprofiler.googleapis.com/"),
		internaloption.WithDefaultScopes(DefaultAuthScopes()...),
		internaloption.EnableJwtWithScope(),
		option.WithGRPCDialOption(grpc.WithDefaultCallOptions(
			grpc.MaxCallRecvMsgSize(math.MaxInt32))),
	}
}

func defaultProfilerCallOptions() *ProfilerCallOptions {
	return &ProfilerCallOptions{
		CreateProfile:        []gax.CallOption{},
		CreateOfflineProfile: []gax.CallOption{},
		UpdateProfile:        []gax.CallOption{},
	}
}

// internalProfilerClient is an interface that defines the methods availaible from Cloud Profiler API.
type internalProfilerClient interface {
	Close() error
	setGoogleClientInfo(...string)
	Connection() *grpc.ClientConn
	CreateProfile(context.Context, *cloudprofilerpb.CreateProfileRequest, ...gax.CallOption) (*cloudprofilerpb.Profile, error)
	CreateOfflineProfile(context.Context, *cloudprofilerpb.CreateOfflineProfileRequest, ...gax.CallOption) (*cloudprofilerpb.Profile, error)
	UpdateProfile(context.Context, *cloudprofilerpb.UpdateProfileRequest, ...gax.CallOption) (*cloudprofilerpb.Profile, error)
}

// ProfilerClient is a client for interacting with Cloud Profiler API.
// Methods, except Close, may be called concurrently. However, fields must not be modified concurrently with method calls.
//
// Manage the collection of continuous profiling data provided by profiling
// agents running in the cloud or by an offline provider of profiling data.
//
// General guidelines:
//
//   Profiles for a single deployment must be created in ascending time order.
//
//   Profiles can be created in either online or offline mode, see below.
type ProfilerClient struct {
	// The internal transport-dependent client.
	internalClient internalProfilerClient

	// The call options for this service.
	CallOptions *ProfilerCallOptions
}

// Wrapper methods routed to the internal client.

// Close closes the connection to the API service. The user should invoke this when
// the client is no longer required.
func (c *ProfilerClient) Close() error {
	return c.internalClient.Close()
}

// setGoogleClientInfo sets the name and version of the application in
// the `x-goog-api-client` header passed on each request. Intended for
// use by Google-written clients.
func (c *ProfilerClient) setGoogleClientInfo(keyval ...string) {
	c.internalClient.setGoogleClientInfo(keyval...)
}

// Connection returns a connection to the API service.
//
// Deprecated.
func (c *ProfilerClient) Connection() *grpc.ClientConn {
	return c.internalClient.Connection()
}

// CreateProfile createProfile creates a new profile resource in the online mode.
//
// The server ensures that the new profiles are created at a constant rate per
// deployment, so the creation request may hang for some time until the next
// profile session is available.
//
// The request may fail with ABORTED error if the creation is not available
// within ~1m, the response will indicate the duration of the backoff the
// client should take before attempting creating a profile again. The backoff
// duration is returned in google.rpc.RetryInfo extension on the response
// status. To a gRPC client, the extension will be return as a
// binary-serialized proto in the trailing metadata item named
// “google.rpc.retryinfo-bin”.
func (c *ProfilerClient) CreateProfile(ctx context.Context, req *cloudprofilerpb.CreateProfileRequest, opts ...gax.CallOption) (*cloudprofilerpb.Profile, error) {
	return c.internalClient.CreateProfile(ctx, req, opts...)
}

// CreateOfflineProfile createOfflineProfile creates a new profile resource in the offline mode.
// The client provides the profile to create along with the profile bytes, the
// server records it.
func (c *ProfilerClient) CreateOfflineProfile(ctx context.Context, req *cloudprofilerpb.CreateOfflineProfileRequest, opts ...gax.CallOption) (*cloudprofilerpb.Profile, error) {
	return c.internalClient.CreateOfflineProfile(ctx, req, opts...)
}

// UpdateProfile updateProfile updates the profile bytes and labels on the profile resource
// created in the online mode. Updating the bytes for profiles created in the
// offline mode is currently not supported: the profile content must be
// provided at the time of the profile creation.
func (c *ProfilerClient) UpdateProfile(ctx context.Context, req *cloudprofilerpb.UpdateProfileRequest, opts ...gax.CallOption) (*cloudprofilerpb.Profile, error) {
	return c.internalClient.UpdateProfile(ctx, req, opts...)
}

// profilerGRPCClient is a client for interacting with Cloud Profiler API over gRPC transport.
//
// Methods, except Close, may be called concurrently. However, fields must not be modified concurrently with method calls.
type profilerGRPCClient struct {
	// Connection pool of gRPC connections to the service.
	connPool gtransport.ConnPool

	// flag to opt out of default deadlines via GOOGLE_API_GO_EXPERIMENTAL_DISABLE_DEFAULT_DEADLINE
	disableDeadlines bool

	// Points back to the CallOptions field of the containing ProfilerClient
	CallOptions **ProfilerCallOptions

	// The gRPC API client.
	profilerClient cloudprofilerpb.ProfilerServiceClient

	// The x-goog-* metadata to be sent with each request.
	xGoogMetadata metadata.MD
}

// NewProfilerClient creates a new profiler service client based on gRPC.
// The returned client must be Closed when it is done being used to clean up its underlying connections.
//
// Manage the collection of continuous profiling data provided by profiling
// agents running in the cloud or by an offline provider of profiling data.
//
// General guidelines:
//
//   Profiles for a single deployment must be created in ascending time order.
//
//   Profiles can be created in either online or offline mode, see below.
func NewProfilerClient(ctx context.Context, opts ...option.ClientOption) (*ProfilerClient, error) {
	clientOpts := defaultProfilerGRPCClientOptions()
	if newProfilerClientHook != nil {
		hookOpts, err := newProfilerClientHook(ctx, clientHookParams{})
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
	client := ProfilerClient{CallOptions: defaultProfilerCallOptions()}

	c := &profilerGRPCClient{
		connPool:         connPool,
		disableDeadlines: disableDeadlines,
		profilerClient:   cloudprofilerpb.NewProfilerServiceClient(connPool),
		CallOptions:      &client.CallOptions,
	}
	c.setGoogleClientInfo()

	client.internalClient = c

	return &client, nil
}

// Connection returns a connection to the API service.
//
// Deprecated.
func (c *profilerGRPCClient) Connection() *grpc.ClientConn {
	return c.connPool.Conn()
}

// setGoogleClientInfo sets the name and version of the application in
// the `x-goog-api-client` header passed on each request. Intended for
// use by Google-written clients.
func (c *profilerGRPCClient) setGoogleClientInfo(keyval ...string) {
	kv := append([]string{"gl-go", versionGo()}, keyval...)
	kv = append(kv, "gapic", versionClient, "gax", gax.Version, "grpc", grpc.Version)
	c.xGoogMetadata = metadata.Pairs("x-goog-api-client", gax.XGoogHeader(kv...))
}

// Close closes the connection to the API service. The user should invoke this when
// the client is no longer required.
func (c *profilerGRPCClient) Close() error {
	return c.connPool.Close()
}

func (c *profilerGRPCClient) CreateProfile(ctx context.Context, req *cloudprofilerpb.CreateProfileRequest, opts ...gax.CallOption) (*cloudprofilerpb.Profile, error) {
	if _, ok := ctx.Deadline(); !ok && !c.disableDeadlines {
		cctx, cancel := context.WithTimeout(ctx, 3600000*time.Millisecond)
		defer cancel()
		ctx = cctx
	}
	md := metadata.Pairs("x-goog-request-params", fmt.Sprintf("%s=%v", "parent", url.QueryEscape(req.GetParent())))
	ctx = insertMetadata(ctx, c.xGoogMetadata, md)
	opts = append((*c.CallOptions).CreateProfile[0:len((*c.CallOptions).CreateProfile):len((*c.CallOptions).CreateProfile)], opts...)
	var resp *cloudprofilerpb.Profile
	err := gax.Invoke(ctx, func(ctx context.Context, settings gax.CallSettings) error {
		var err error
		resp, err = c.profilerClient.CreateProfile(ctx, req, settings.GRPC...)
		return err
	}, opts...)
	if err != nil {
		return nil, err
	}
	return resp, nil
}

func (c *profilerGRPCClient) CreateOfflineProfile(ctx context.Context, req *cloudprofilerpb.CreateOfflineProfileRequest, opts ...gax.CallOption) (*cloudprofilerpb.Profile, error) {
	if _, ok := ctx.Deadline(); !ok && !c.disableDeadlines {
		cctx, cancel := context.WithTimeout(ctx, 30000*time.Millisecond)
		defer cancel()
		ctx = cctx
	}
	md := metadata.Pairs("x-goog-request-params", fmt.Sprintf("%s=%v", "parent", url.QueryEscape(req.GetParent())))
	ctx = insertMetadata(ctx, c.xGoogMetadata, md)
	opts = append((*c.CallOptions).CreateOfflineProfile[0:len((*c.CallOptions).CreateOfflineProfile):len((*c.CallOptions).CreateOfflineProfile)], opts...)
	var resp *cloudprofilerpb.Profile
	err := gax.Invoke(ctx, func(ctx context.Context, settings gax.CallSettings) error {
		var err error
		resp, err = c.profilerClient.CreateOfflineProfile(ctx, req, settings.GRPC...)
		return err
	}, opts...)
	if err != nil {
		return nil, err
	}
	return resp, nil
}

func (c *profilerGRPCClient) UpdateProfile(ctx context.Context, req *cloudprofilerpb.UpdateProfileRequest, opts ...gax.CallOption) (*cloudprofilerpb.Profile, error) {
	if _, ok := ctx.Deadline(); !ok && !c.disableDeadlines {
		cctx, cancel := context.WithTimeout(ctx, 30000*time.Millisecond)
		defer cancel()
		ctx = cctx
	}
	md := metadata.Pairs("x-goog-request-params", fmt.Sprintf("%s=%v", "profile.name", url.QueryEscape(req.GetProfile().GetName())))
	ctx = insertMetadata(ctx, c.xGoogMetadata, md)
	opts = append((*c.CallOptions).UpdateProfile[0:len((*c.CallOptions).UpdateProfile):len((*c.CallOptions).UpdateProfile)], opts...)
	var resp *cloudprofilerpb.Profile
	err := gax.Invoke(ctx, func(ctx context.Context, settings gax.CallSettings) error {
		var err error
		resp, err = c.profilerClient.UpdateProfile(ctx, req, settings.GRPC...)
		return err
	}, opts...)
	if err != nil {
		return nil, err
	}
	return resp, nil
}
