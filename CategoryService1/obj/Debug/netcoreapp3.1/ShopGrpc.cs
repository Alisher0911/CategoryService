// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/shop.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace CategoryService1 {
  public static partial class Shop
  {
    static readonly string __ServiceName = "Shop";

    static readonly grpc::Marshaller<global::CategoryService1.CategoryCreate> __Marshaller_CategoryCreate = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::CategoryService1.CategoryCreate.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::CategoryService1.CategoryInfo> __Marshaller_CategoryInfo = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::CategoryService1.CategoryInfo.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::CategoryService1.CategoryLookUp> __Marshaller_CategoryLookUp = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::CategoryService1.CategoryLookUp.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::CategoryService1.ProductCreate> __Marshaller_ProductCreate = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::CategoryService1.ProductCreate.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::CategoryService1.ProductInfo> __Marshaller_ProductInfo = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::CategoryService1.ProductInfo.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::CategoryService1.ProductLookUp> __Marshaller_ProductLookUp = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::CategoryService1.ProductLookUp.Parser.ParseFrom);

    static readonly grpc::Method<global::CategoryService1.CategoryCreate, global::CategoryService1.CategoryInfo> __Method_AddCategory = new grpc::Method<global::CategoryService1.CategoryCreate, global::CategoryService1.CategoryInfo>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddCategory",
        __Marshaller_CategoryCreate,
        __Marshaller_CategoryInfo);

    static readonly grpc::Method<global::CategoryService1.CategoryLookUp, global::CategoryService1.CategoryInfo> __Method_GetCategoryById = new grpc::Method<global::CategoryService1.CategoryLookUp, global::CategoryService1.CategoryInfo>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetCategoryById",
        __Marshaller_CategoryLookUp,
        __Marshaller_CategoryInfo);

    static readonly grpc::Method<global::CategoryService1.ProductCreate, global::CategoryService1.ProductInfo> __Method_AddProduct = new grpc::Method<global::CategoryService1.ProductCreate, global::CategoryService1.ProductInfo>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddProduct",
        __Marshaller_ProductCreate,
        __Marshaller_ProductInfo);

    static readonly grpc::Method<global::CategoryService1.ProductLookUp, global::CategoryService1.ProductInfo> __Method_getProdcutById = new grpc::Method<global::CategoryService1.ProductLookUp, global::CategoryService1.ProductInfo>(
        grpc::MethodType.Unary,
        __ServiceName,
        "getProdcutById",
        __Marshaller_ProductLookUp,
        __Marshaller_ProductInfo);

    static readonly grpc::Method<global::CategoryService1.CategoryLookUp, global::CategoryService1.ProductInfo> __Method_getProductsByCategoryId = new grpc::Method<global::CategoryService1.CategoryLookUp, global::CategoryService1.ProductInfo>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "getProductsByCategoryId",
        __Marshaller_CategoryLookUp,
        __Marshaller_ProductInfo);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::CategoryService1.ShopReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Shop</summary>
    [grpc::BindServiceMethod(typeof(Shop), "BindService")]
    public abstract partial class ShopBase
    {
      public virtual global::System.Threading.Tasks.Task<global::CategoryService1.CategoryInfo> AddCategory(global::CategoryService1.CategoryCreate request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::CategoryService1.CategoryInfo> GetCategoryById(global::CategoryService1.CategoryLookUp request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::CategoryService1.ProductInfo> AddProduct(global::CategoryService1.ProductCreate request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::CategoryService1.ProductInfo> getProdcutById(global::CategoryService1.ProductLookUp request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task getProductsByCategoryId(global::CategoryService1.CategoryLookUp request, grpc::IServerStreamWriter<global::CategoryService1.ProductInfo> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(ShopBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_AddCategory, serviceImpl.AddCategory)
          .AddMethod(__Method_GetCategoryById, serviceImpl.GetCategoryById)
          .AddMethod(__Method_AddProduct, serviceImpl.AddProduct)
          .AddMethod(__Method_getProdcutById, serviceImpl.getProdcutById)
          .AddMethod(__Method_getProductsByCategoryId, serviceImpl.getProductsByCategoryId).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ShopBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_AddCategory, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CategoryService1.CategoryCreate, global::CategoryService1.CategoryInfo>(serviceImpl.AddCategory));
      serviceBinder.AddMethod(__Method_GetCategoryById, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CategoryService1.CategoryLookUp, global::CategoryService1.CategoryInfo>(serviceImpl.GetCategoryById));
      serviceBinder.AddMethod(__Method_AddProduct, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CategoryService1.ProductCreate, global::CategoryService1.ProductInfo>(serviceImpl.AddProduct));
      serviceBinder.AddMethod(__Method_getProdcutById, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CategoryService1.ProductLookUp, global::CategoryService1.ProductInfo>(serviceImpl.getProdcutById));
      serviceBinder.AddMethod(__Method_getProductsByCategoryId, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::CategoryService1.CategoryLookUp, global::CategoryService1.ProductInfo>(serviceImpl.getProductsByCategoryId));
    }

  }
}
#endregion