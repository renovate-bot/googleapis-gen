// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/streetview/publish/v1/streetview_publish.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Streetview.Publish.V1 {

  /// <summary>Holder for reflection information generated from google/streetview/publish/v1/streetview_publish.proto</summary>
  public static partial class StreetviewPublishReflection {

    #region Descriptor
    /// <summary>File descriptor for google/streetview/publish/v1/streetview_publish.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StreetviewPublishReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjVnb29nbGUvc3RyZWV0dmlldy9wdWJsaXNoL3YxL3N0cmVldHZpZXdfcHVi",
            "bGlzaC5wcm90bxIcZ29vZ2xlLnN0cmVldHZpZXcucHVibGlzaC52MRocZ29v",
            "Z2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90bxoXZ29vZ2xlL2FwaS9jbGllbnQu",
            "cHJvdG8aI2dvb2dsZS9sb25ncnVubmluZy9vcGVyYXRpb25zLnByb3RvGhtn",
            "b29nbGUvcHJvdG9idWYvZW1wdHkucHJvdG8aLGdvb2dsZS9zdHJlZXR2aWV3",
            "L3B1Ymxpc2gvdjEvcmVzb3VyY2VzLnByb3RvGi5nb29nbGUvc3RyZWV0dmll",
            "dy9wdWJsaXNoL3YxL3JwY21lc3NhZ2VzLnByb3RvMuELChhTdHJlZXRWaWV3",
            "UHVibGlzaFNlcnZpY2UScAoLU3RhcnRVcGxvYWQSFi5nb29nbGUucHJvdG9i",
            "dWYuRW1wdHkaJy5nb29nbGUuc3RyZWV0dmlldy5wdWJsaXNoLnYxLlVwbG9h",
            "ZFJlZiIggtPkkwIaIhUvdjEvcGhvdG86c3RhcnRVcGxvYWQ6ASoShgEKC0Ny",
            "ZWF0ZVBob3RvEjAuZ29vZ2xlLnN0cmVldHZpZXcucHVibGlzaC52MS5DcmVh",
            "dGVQaG90b1JlcXVlc3QaIy5nb29nbGUuc3RyZWV0dmlldy5wdWJsaXNoLnYx",
            "LlBob3RvIiCC0+STAhIiCS92MS9waG90bzoFcGhvdG/aQQVwaG90bxKMAQoI",
            "R2V0UGhvdG8SLS5nb29nbGUuc3RyZWV0dmlldy5wdWJsaXNoLnYxLkdldFBo",
            "b3RvUmVxdWVzdBojLmdvb2dsZS5zdHJlZXR2aWV3LnB1Ymxpc2gudjEuUGhv",
            "dG8iLILT5JMCFhIUL3YxL3Bob3RvL3twaG90b19pZH3aQQ1waG90b19pZCx2",
            "aWV3EqkBCg5CYXRjaEdldFBob3RvcxIzLmdvb2dsZS5zdHJlZXR2aWV3LnB1",
            "Ymxpc2gudjEuQmF0Y2hHZXRQaG90b3NSZXF1ZXN0GjQuZ29vZ2xlLnN0cmVl",
            "dHZpZXcucHVibGlzaC52MS5CYXRjaEdldFBob3Rvc1Jlc3BvbnNlIiyC0+ST",
            "AhUSEy92MS9waG90b3M6YmF0Y2hHZXTaQQ52aWV3LHBob3RvX2lkcxKRAQoK",
            "TGlzdFBob3RvcxIvLmdvb2dsZS5zdHJlZXR2aWV3LnB1Ymxpc2gudjEuTGlz",
            "dFBob3Rvc1JlcXVlc3QaMC5nb29nbGUuc3RyZWV0dmlldy5wdWJsaXNoLnYx",
            "Lkxpc3RQaG90b3NSZXNwb25zZSIggtPkkwIMEgovdjEvcGhvdG9z2kELdmll",
            "dyxmaWx0ZXISpgEKC1VwZGF0ZVBob3RvEjAuZ29vZ2xlLnN0cmVldHZpZXcu",
            "cHVibGlzaC52MS5VcGRhdGVQaG90b1JlcXVlc3QaIy5nb29nbGUuc3RyZWV0",
            "dmlldy5wdWJsaXNoLnYxLlBob3RvIkCC0+STAiYaHS92MS9waG90by97cGhv",
            "dG8ucGhvdG9faWQuaWR9OgVwaG90b9pBEXBob3RvLHVwZGF0ZV9tYXNrEr8B",
            "ChFCYXRjaFVwZGF0ZVBob3RvcxI2Lmdvb2dsZS5zdHJlZXR2aWV3LnB1Ymxp",
            "c2gudjEuQmF0Y2hVcGRhdGVQaG90b3NSZXF1ZXN0GjcuZ29vZ2xlLnN0cmVl",
            "dHZpZXcucHVibGlzaC52MS5CYXRjaFVwZGF0ZVBob3Rvc1Jlc3BvbnNlIjmC",
            "0+STAhsiFi92MS9waG90b3M6YmF0Y2hVcGRhdGU6ASraQRV1cGRhdGVfcGhv",
            "dG9fcmVxdWVzdHMSgAEKC0RlbGV0ZVBob3RvEjAuZ29vZ2xlLnN0cmVldHZp",
            "ZXcucHVibGlzaC52MS5EZWxldGVQaG90b1JlcXVlc3QaFi5nb29nbGUucHJv",
            "dG9idWYuRW1wdHkiJ4LT5JMCFioUL3YxL3Bob3RvL3twaG90b19pZH3aQQhw",
            "aG90b19pZBKzAQoRQmF0Y2hEZWxldGVQaG90b3MSNi5nb29nbGUuc3RyZWV0",
            "dmlldy5wdWJsaXNoLnYxLkJhdGNoRGVsZXRlUGhvdG9zUmVxdWVzdBo3Lmdv",
            "b2dsZS5zdHJlZXR2aWV3LnB1Ymxpc2gudjEuQmF0Y2hEZWxldGVQaG90b3NS",
            "ZXNwb25zZSItgtPkkwIbIhYvdjEvcGhvdG9zOmJhdGNoRGVsZXRlOgEq2kEJ",
            "cGhvdG9faWRzGlfKQSBzdHJlZXR2aWV3cHVibGlzaC5nb29nbGVhcGlzLmNv",
            "bdJBMWh0dHBzOi8vd3d3Lmdvb2dsZWFwaXMuY29tL2F1dGgvc3RyZWV0dmll",
            "d3B1Ymxpc2hCggEKKGNvbS5nb29nbGUuZ2VvLnVnYy5zdHJlZXR2aWV3LnB1",
            "Ymxpc2gudjFCEVN0cmVldFZpZXdQdWJsaXNoWkNnb29nbGUuZ29sYW5nLm9y",
            "Zy9nZW5wcm90by9nb29nbGVhcGlzL3N0cmVldHZpZXcvcHVibGlzaC92MTtw",
            "dWJsaXNoYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.LongRunning.OperationsReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, global::Google.Streetview.Publish.V1.ResourcesReflection.Descriptor, global::Google.Streetview.Publish.V1.RpcmessagesReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, null));
    }
    #endregion

  }
}

#endregion Designer generated code
