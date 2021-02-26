// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/example/library/v1/library.proto

package com.google.example.library.v1;

public final class LibraryProto {
  private LibraryProto() {}
  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistryLite registry) {
  }

  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistry registry) {
    registerAllExtensions(
        (com.google.protobuf.ExtensionRegistryLite) registry);
  }
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_example_library_v1_Book_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_example_library_v1_Book_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_example_library_v1_Shelf_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_example_library_v1_Shelf_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_example_library_v1_CreateShelfRequest_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_example_library_v1_CreateShelfRequest_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_example_library_v1_GetShelfRequest_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_example_library_v1_GetShelfRequest_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_example_library_v1_ListShelvesRequest_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_example_library_v1_ListShelvesRequest_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_example_library_v1_ListShelvesResponse_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_example_library_v1_ListShelvesResponse_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_example_library_v1_DeleteShelfRequest_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_example_library_v1_DeleteShelfRequest_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_example_library_v1_MergeShelvesRequest_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_example_library_v1_MergeShelvesRequest_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_example_library_v1_CreateBookRequest_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_example_library_v1_CreateBookRequest_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_example_library_v1_GetBookRequest_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_example_library_v1_GetBookRequest_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_example_library_v1_ListBooksRequest_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_example_library_v1_ListBooksRequest_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_example_library_v1_ListBooksResponse_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_example_library_v1_ListBooksResponse_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_example_library_v1_UpdateBookRequest_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_example_library_v1_UpdateBookRequest_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_example_library_v1_DeleteBookRequest_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_example_library_v1_DeleteBookRequest_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_google_example_library_v1_MoveBookRequest_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_google_example_library_v1_MoveBookRequest_fieldAccessorTable;

  public static com.google.protobuf.Descriptors.FileDescriptor
      getDescriptor() {
    return descriptor;
  }
  private static  com.google.protobuf.Descriptors.FileDescriptor
      descriptor;
  static {
    java.lang.String[] descriptorData = {
      "\n\'google/example/library/v1/library.prot" +
      "o\022\031google.example.library.v1\032\034google/api" +
      "/annotations.proto\032\027google/api/client.pr" +
      "oto\032\037google/api/field_behavior.proto\032\031go" +
      "ogle/api/resource.proto\032\033google/protobuf" +
      "/empty.proto\032 google/protobuf/field_mask" +
      ".proto\"\211\001\n\004Book\022\014\n\004name\030\001 \001(\t\022\016\n\006author\030" +
      "\002 \001(\t\022\r\n\005title\030\003 \001(\t\022\014\n\004read\030\004 \001(\010:F\352AC\n" +
      "#library-example.googleapis.com/Book\022\034sh" +
      "elves/{shelf}/books/{book}\"c\n\005Shelf\022\014\n\004n" +
      "ame\030\001 \001(\t\022\r\n\005theme\030\002 \001(\t:=\352A:\n$library-e" +
      "xample.googleapis.com/Shelf\022\022shelves/{sh" +
      "elf_id}\"J\n\022CreateShelfRequest\0224\n\005shelf\030\001" +
      " \001(\0132 .google.example.library.v1.ShelfB\003" +
      "\340A\002\"M\n\017GetShelfRequest\022:\n\004name\030\001 \001(\tB,\340A" +
      "\002\372A&\n$library-example.googleapis.com/She" +
      "lf\";\n\022ListShelvesRequest\022\021\n\tpage_size\030\001 " +
      "\001(\005\022\022\n\npage_token\030\002 \001(\t\"a\n\023ListShelvesRe" +
      "sponse\0221\n\007shelves\030\001 \003(\0132 .google.example" +
      ".library.v1.Shelf\022\027\n\017next_page_token\030\002 \001" +
      "(\t\"P\n\022DeleteShelfRequest\022:\n\004name\030\001 \001(\tB," +
      "\340A\002\372A&\n$library-example.googleapis.com/S" +
      "helf\"\224\001\n\023MergeShelvesRequest\022:\n\004name\030\001 \001" +
      "(\tB,\340A\002\372A&\n$library-example.googleapis.c" +
      "om/Shelf\022A\n\013other_shelf\030\002 \001(\tB,\340A\002\372A&\n$l" +
      "ibrary-example.googleapis.com/Shelf\"\205\001\n\021" +
      "CreateBookRequest\022<\n\006parent\030\001 \001(\tB,\340A\002\372A" +
      "&\n$library-example.googleapis.com/Shelf\022" +
      "2\n\004book\030\002 \001(\0132\037.google.example.library.v" +
      "1.BookB\003\340A\002\"K\n\016GetBookRequest\0229\n\004name\030\001 " +
      "\001(\tB+\340A\002\372A%\n#library-example.googleapis." +
      "com/Book\"w\n\020ListBooksRequest\022<\n\006parent\030\001" +
      " \001(\tB,\340A\002\372A&\n$library-example.googleapis" +
      ".com/Shelf\022\021\n\tpage_size\030\002 \001(\005\022\022\n\npage_to" +
      "ken\030\003 \001(\t\"\\\n\021ListBooksResponse\022.\n\005books\030" +
      "\001 \003(\0132\037.google.example.library.v1.Book\022\027" +
      "\n\017next_page_token\030\002 \001(\t\"}\n\021UpdateBookReq" +
      "uest\0222\n\004book\030\001 \001(\0132\037.google.example.libr" +
      "ary.v1.BookB\003\340A\002\0224\n\013update_mask\030\002 \001(\0132\032." +
      "google.protobuf.FieldMaskB\003\340A\002\"N\n\021Delete" +
      "BookRequest\0229\n\004name\030\001 \001(\tB+\340A\002\372A%\n#libra" +
      "ry-example.googleapis.com/Book\"\224\001\n\017MoveB" +
      "ookRequest\0229\n\004name\030\001 \001(\tB+\340A\002\372A%\n#librar" +
      "y-example.googleapis.com/Book\022F\n\020other_s" +
      "helf_name\030\002 \001(\tB,\340A\002\372A&\n$library-example" +
      ".googleapis.com/Shelf2\313\014\n\016LibraryService" +
      "\022\202\001\n\013CreateShelf\022-.google.example.librar" +
      "y.v1.CreateShelfRequest\032 .google.example" +
      ".library.v1.Shelf\"\"\202\323\344\223\002\024\"\013/v1/shelves:\005" +
      "shelf\332A\005shelf\022}\n\010GetShelf\022*.google.examp" +
      "le.library.v1.GetShelfRequest\032 .google.e" +
      "xample.library.v1.Shelf\"#\202\323\344\223\002\026\022\024/v1/{na" +
      "me=shelves/*}\332A\004name\022\201\001\n\013ListShelves\022-.g" +
      "oogle.example.library.v1.ListShelvesRequ" +
      "est\032..google.example.library.v1.ListShel" +
      "vesResponse\"\023\202\323\344\223\002\r\022\013/v1/shelves\022y\n\013Dele" +
      "teShelf\022-.google.example.library.v1.Dele" +
      "teShelfRequest\032\026.google.protobuf.Empty\"#" +
      "\202\323\344\223\002\026*\024/v1/{name=shelves/*}\332A\004name\022\232\001\n\014" +
      "MergeShelves\022..google.example.library.v1" +
      ".MergeShelvesRequest\032 .google.example.li" +
      "brary.v1.Shelf\"8\202\323\344\223\002\037\"\032/v1/{name=shelve" +
      "s/*}:merge:\001*\332A\020name,other_shelf\022\225\001\n\nCre" +
      "ateBook\022,.google.example.library.v1.Crea" +
      "teBookRequest\032\037.google.example.library.v" +
      "1.Book\"8\202\323\344\223\002$\"\034/v1/{parent=shelves/*}/b" +
      "ooks:\004book\332A\013parent,book\022\202\001\n\007GetBook\022).g" +
      "oogle.example.library.v1.GetBookRequest\032" +
      "\037.google.example.library.v1.Book\"+\202\323\344\223\002\036" +
      "\022\034/v1/{name=shelves/*/books/*}\332A\004name\022\225\001" +
      "\n\tListBooks\022+.google.example.library.v1." +
      "ListBooksRequest\032,.google.example.librar" +
      "y.v1.ListBooksResponse\"-\202\323\344\223\002\036\022\034/v1/{par" +
      "ent=shelves/*}/books\332A\006parent\022\177\n\nDeleteB" +
      "ook\022,.google.example.library.v1.DeleteBo" +
      "okRequest\032\026.google.protobuf.Empty\"+\202\323\344\223\002" +
      "\036*\034/v1/{name=shelves/*/books/*}\332A\004name\022\237" +
      "\001\n\nUpdateBook\022,.google.example.library.v" +
      "1.UpdateBookRequest\032\037.google.example.lib" +
      "rary.v1.Book\"B\202\323\344\223\002)2!/v1/{book.name=she" +
      "lves/*/books/*}:\004book\332A\020book,update_mask" +
      "\022\235\001\n\010MoveBook\022*.google.example.library.v" +
      "1.MoveBookRequest\032\037.google.example.libra" +
      "ry.v1.Book\"D\202\323\344\223\002&\"!/v1/{name=shelves/*/" +
      "books/*}:move:\001*\332A\025name,other_shelf_name" +
      "\032!\312A\036library-example.googleapis.comBq\n\035c" +
      "om.google.example.library.v1B\014LibraryPro" +
      "toP\001Z@google.golang.org/genproto/googlea" +
      "pis/example/library/v1;libraryb\006proto3"
    };
    descriptor = com.google.protobuf.Descriptors.FileDescriptor
      .internalBuildGeneratedFileFrom(descriptorData,
        new com.google.protobuf.Descriptors.FileDescriptor[] {
          com.google.api.AnnotationsProto.getDescriptor(),
          com.google.api.ClientProto.getDescriptor(),
          com.google.api.FieldBehaviorProto.getDescriptor(),
          com.google.api.ResourceProto.getDescriptor(),
          com.google.protobuf.EmptyProto.getDescriptor(),
          com.google.protobuf.FieldMaskProto.getDescriptor(),
        });
    internal_static_google_example_library_v1_Book_descriptor =
      getDescriptor().getMessageTypes().get(0);
    internal_static_google_example_library_v1_Book_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_example_library_v1_Book_descriptor,
        new java.lang.String[] { "Name", "Author", "Title", "Read", });
    internal_static_google_example_library_v1_Shelf_descriptor =
      getDescriptor().getMessageTypes().get(1);
    internal_static_google_example_library_v1_Shelf_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_example_library_v1_Shelf_descriptor,
        new java.lang.String[] { "Name", "Theme", });
    internal_static_google_example_library_v1_CreateShelfRequest_descriptor =
      getDescriptor().getMessageTypes().get(2);
    internal_static_google_example_library_v1_CreateShelfRequest_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_example_library_v1_CreateShelfRequest_descriptor,
        new java.lang.String[] { "Shelf", });
    internal_static_google_example_library_v1_GetShelfRequest_descriptor =
      getDescriptor().getMessageTypes().get(3);
    internal_static_google_example_library_v1_GetShelfRequest_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_example_library_v1_GetShelfRequest_descriptor,
        new java.lang.String[] { "Name", });
    internal_static_google_example_library_v1_ListShelvesRequest_descriptor =
      getDescriptor().getMessageTypes().get(4);
    internal_static_google_example_library_v1_ListShelvesRequest_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_example_library_v1_ListShelvesRequest_descriptor,
        new java.lang.String[] { "PageSize", "PageToken", });
    internal_static_google_example_library_v1_ListShelvesResponse_descriptor =
      getDescriptor().getMessageTypes().get(5);
    internal_static_google_example_library_v1_ListShelvesResponse_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_example_library_v1_ListShelvesResponse_descriptor,
        new java.lang.String[] { "Shelves", "NextPageToken", });
    internal_static_google_example_library_v1_DeleteShelfRequest_descriptor =
      getDescriptor().getMessageTypes().get(6);
    internal_static_google_example_library_v1_DeleteShelfRequest_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_example_library_v1_DeleteShelfRequest_descriptor,
        new java.lang.String[] { "Name", });
    internal_static_google_example_library_v1_MergeShelvesRequest_descriptor =
      getDescriptor().getMessageTypes().get(7);
    internal_static_google_example_library_v1_MergeShelvesRequest_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_example_library_v1_MergeShelvesRequest_descriptor,
        new java.lang.String[] { "Name", "OtherShelf", });
    internal_static_google_example_library_v1_CreateBookRequest_descriptor =
      getDescriptor().getMessageTypes().get(8);
    internal_static_google_example_library_v1_CreateBookRequest_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_example_library_v1_CreateBookRequest_descriptor,
        new java.lang.String[] { "Parent", "Book", });
    internal_static_google_example_library_v1_GetBookRequest_descriptor =
      getDescriptor().getMessageTypes().get(9);
    internal_static_google_example_library_v1_GetBookRequest_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_example_library_v1_GetBookRequest_descriptor,
        new java.lang.String[] { "Name", });
    internal_static_google_example_library_v1_ListBooksRequest_descriptor =
      getDescriptor().getMessageTypes().get(10);
    internal_static_google_example_library_v1_ListBooksRequest_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_example_library_v1_ListBooksRequest_descriptor,
        new java.lang.String[] { "Parent", "PageSize", "PageToken", });
    internal_static_google_example_library_v1_ListBooksResponse_descriptor =
      getDescriptor().getMessageTypes().get(11);
    internal_static_google_example_library_v1_ListBooksResponse_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_example_library_v1_ListBooksResponse_descriptor,
        new java.lang.String[] { "Books", "NextPageToken", });
    internal_static_google_example_library_v1_UpdateBookRequest_descriptor =
      getDescriptor().getMessageTypes().get(12);
    internal_static_google_example_library_v1_UpdateBookRequest_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_example_library_v1_UpdateBookRequest_descriptor,
        new java.lang.String[] { "Book", "UpdateMask", });
    internal_static_google_example_library_v1_DeleteBookRequest_descriptor =
      getDescriptor().getMessageTypes().get(13);
    internal_static_google_example_library_v1_DeleteBookRequest_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_example_library_v1_DeleteBookRequest_descriptor,
        new java.lang.String[] { "Name", });
    internal_static_google_example_library_v1_MoveBookRequest_descriptor =
      getDescriptor().getMessageTypes().get(14);
    internal_static_google_example_library_v1_MoveBookRequest_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_google_example_library_v1_MoveBookRequest_descriptor,
        new java.lang.String[] { "Name", "OtherShelfName", });
    com.google.protobuf.ExtensionRegistry registry =
        com.google.protobuf.ExtensionRegistry.newInstance();
    registry.add(com.google.api.ClientProto.defaultHost);
    registry.add(com.google.api.FieldBehaviorProto.fieldBehavior);
    registry.add(com.google.api.AnnotationsProto.http);
    registry.add(com.google.api.ClientProto.methodSignature);
    registry.add(com.google.api.ResourceProto.resource);
    registry.add(com.google.api.ResourceProto.resourceReference);
    com.google.protobuf.Descriptors.FileDescriptor
        .internalUpdateFileDescriptor(descriptor, registry);
    com.google.api.AnnotationsProto.getDescriptor();
    com.google.api.ClientProto.getDescriptor();
    com.google.api.FieldBehaviorProto.getDescriptor();
    com.google.api.ResourceProto.getDescriptor();
    com.google.protobuf.EmptyProto.getDescriptor();
    com.google.protobuf.FieldMaskProto.getDescriptor();
  }

  // @@protoc_insertion_point(outer_class_scope)
}
