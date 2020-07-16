/// UnityEditor.TextureUtil : 2019.3.0f6

#if UNITY_EDITOR

using Hananoki.Reflection;
using System;

namespace Hananoki {
  public static partial class UnityTextureUtil {
    delegate int Method_GetStorageMemorySize0( UnityEngine.Texture t );
    static Method_GetStorageMemorySize0 __GetStorageMemorySize0;
    public static int GetStorageMemorySize( UnityEngine.Texture t ) {
      if( __GetStorageMemorySize0 == null ) {
        __GetStorageMemorySize0 = (Method_GetStorageMemorySize0) Delegate.CreateDelegate( typeof( Method_GetStorageMemorySize0 ), null, R.Method("GetStorageMemorySize", "UnityEditor.TextureUtil", "UnityEditor.dll") );
      }
      return __GetStorageMemorySize0(  t  );
    }



    delegate System.Int64 Method_GetStorageMemorySizeLong0( UnityEngine.Texture t );
    static Method_GetStorageMemorySizeLong0 __GetStorageMemorySizeLong0;
    public static System.Int64 GetStorageMemorySizeLong( UnityEngine.Texture t ) {
      if( __GetStorageMemorySizeLong0 == null ) {
        __GetStorageMemorySizeLong0 = (Method_GetStorageMemorySizeLong0) Delegate.CreateDelegate( typeof( Method_GetStorageMemorySizeLong0 ), null, R.Method("GetStorageMemorySizeLong", "UnityEditor.TextureUtil", "UnityEditor.dll") );
      }
      return __GetStorageMemorySizeLong0(  t  );
    }



    delegate int Method_GetRuntimeMemorySize0( UnityEngine.Texture t );
    static Method_GetRuntimeMemorySize0 __GetRuntimeMemorySize0;
    public static int GetRuntimeMemorySize( UnityEngine.Texture t ) {
      if( __GetRuntimeMemorySize0 == null ) {
        __GetRuntimeMemorySize0 = (Method_GetRuntimeMemorySize0) Delegate.CreateDelegate( typeof( Method_GetRuntimeMemorySize0 ), null, R.Method("GetRuntimeMemorySize", "UnityEditor.TextureUtil", "UnityEditor.dll") );
      }
      return __GetRuntimeMemorySize0(  t  );
    }



    delegate System.Int64 Method_GetRuntimeMemorySizeLong0( UnityEngine.Texture t );
    static Method_GetRuntimeMemorySizeLong0 __GetRuntimeMemorySizeLong0;
    public static System.Int64 GetRuntimeMemorySizeLong( UnityEngine.Texture t ) {
      if( __GetRuntimeMemorySizeLong0 == null ) {
        __GetRuntimeMemorySizeLong0 = (Method_GetRuntimeMemorySizeLong0) Delegate.CreateDelegate( typeof( Method_GetRuntimeMemorySizeLong0 ), null, R.Method("GetRuntimeMemorySizeLong", "UnityEditor.TextureUtil", "UnityEditor.dll") );
      }
      return __GetRuntimeMemorySizeLong0(  t  );
    }



    delegate bool Method_IsNonPowerOfTwo0( UnityEngine.Texture2D t );
    static Method_IsNonPowerOfTwo0 __IsNonPowerOfTwo0;
    public static bool IsNonPowerOfTwo( UnityEngine.Texture2D t ) {
      if( __IsNonPowerOfTwo0 == null ) {
        __IsNonPowerOfTwo0 = (Method_IsNonPowerOfTwo0) Delegate.CreateDelegate( typeof( Method_IsNonPowerOfTwo0 ), null, R.Method("IsNonPowerOfTwo", "UnityEditor.TextureUtil", "UnityEditor.dll") );
      }
      return __IsNonPowerOfTwo0(  t  );
    }



    //delegate UnityEditor.TextureUsageMode Method_GetUsageMode0( UnityEngine.Texture t );
    //static Method_GetUsageMode0 __GetUsageMode0;
    //public static UnityEditor.TextureUsageMode GetUsageMode( UnityEngine.Texture t ) {
    //  if( __GetUsageMode0 == null ) {
    //    __GetUsageMode0 = (Method_GetUsageMode0) Delegate.CreateDelegate( typeof( Method_GetUsageMode0 ), null, R.Method("GetUsageMode", "UnityEditor.TextureUtil", "UnityEditor.dll") );
    //  }
    //  return __GetUsageMode0(  t  );
    //}



    delegate int Method_GetBytesFromTextureFormat0( UnityEngine.TextureFormat inFormat );
    static Method_GetBytesFromTextureFormat0 __GetBytesFromTextureFormat0;
    public static int GetBytesFromTextureFormat( UnityEngine.TextureFormat inFormat ) {
      if( __GetBytesFromTextureFormat0 == null ) {
        __GetBytesFromTextureFormat0 = (Method_GetBytesFromTextureFormat0) Delegate.CreateDelegate( typeof( Method_GetBytesFromTextureFormat0 ), null, R.Method("GetBytesFromTextureFormat", "UnityEditor.TextureUtil", "UnityEditor.dll") );
      }
      return __GetBytesFromTextureFormat0(  inFormat  );
    }



    delegate int Method_GetRowBytesFromWidthAndFormat0( int width, UnityEngine.TextureFormat format );
    static Method_GetRowBytesFromWidthAndFormat0 __GetRowBytesFromWidthAndFormat0;
    public static int GetRowBytesFromWidthAndFormat( int width, UnityEngine.TextureFormat format ) {
      if( __GetRowBytesFromWidthAndFormat0 == null ) {
        __GetRowBytesFromWidthAndFormat0 = (Method_GetRowBytesFromWidthAndFormat0) Delegate.CreateDelegate( typeof( Method_GetRowBytesFromWidthAndFormat0 ), null, R.Method("GetRowBytesFromWidthAndFormat", "UnityEditor.TextureUtil", "UnityEditor.dll") );
      }
      return __GetRowBytesFromWidthAndFormat0(  width, format  );
    }



    delegate bool Method_IsValidTextureFormat0( UnityEngine.TextureFormat format );
    static Method_IsValidTextureFormat0 __IsValidTextureFormat0;
    public static bool IsValidTextureFormat( UnityEngine.TextureFormat format ) {
      if( __IsValidTextureFormat0 == null ) {
        __IsValidTextureFormat0 = (Method_IsValidTextureFormat0) Delegate.CreateDelegate( typeof( Method_IsValidTextureFormat0 ), null, R.Method("IsValidTextureFormat", "UnityEditor.TextureUtil", "UnityEditor.dll") );
      }
      return __IsValidTextureFormat0(  format  );
    }



    delegate bool Method_IsCompressedTextureFormat0( UnityEngine.TextureFormat format );
    static Method_IsCompressedTextureFormat0 __IsCompressedTextureFormat0;
    public static bool IsCompressedTextureFormat( UnityEngine.TextureFormat format ) {
      if( __IsCompressedTextureFormat0 == null ) {
        __IsCompressedTextureFormat0 = (Method_IsCompressedTextureFormat0) Delegate.CreateDelegate( typeof( Method_IsCompressedTextureFormat0 ), null, R.Method("IsCompressedTextureFormat", "UnityEditor.TextureUtil", "UnityEditor.dll") );
      }
      return __IsCompressedTextureFormat0(  format  );
    }



    delegate bool Method_IsCompressedCrunchTextureFormat0( UnityEngine.TextureFormat format );
    static Method_IsCompressedCrunchTextureFormat0 __IsCompressedCrunchTextureFormat0;
    public static bool IsCompressedCrunchTextureFormat( UnityEngine.TextureFormat format ) {
      if( __IsCompressedCrunchTextureFormat0 == null ) {
        __IsCompressedCrunchTextureFormat0 = (Method_IsCompressedCrunchTextureFormat0) Delegate.CreateDelegate( typeof( Method_IsCompressedCrunchTextureFormat0 ), null, R.Method("IsCompressedCrunchTextureFormat", "UnityEditor.TextureUtil", "UnityEditor.dll") );
      }
      return __IsCompressedCrunchTextureFormat0(  format  );
    }



    delegate UnityEngine.TextureFormat Method_GetTextureFormat0( UnityEngine.Texture texture );
    static Method_GetTextureFormat0 __GetTextureFormat0;
    public static UnityEngine.TextureFormat GetTextureFormat( UnityEngine.Texture texture ) {
      if( __GetTextureFormat0 == null ) {
        __GetTextureFormat0 = (Method_GetTextureFormat0) Delegate.CreateDelegate( typeof( Method_GetTextureFormat0 ), null, R.Method("GetTextureFormat", "UnityEditor.TextureUtil", "UnityEditor.dll") );
      }
      return __GetTextureFormat0(  texture  );
    }



    delegate bool Method_IsAlphaOnlyTextureFormat0( UnityEngine.TextureFormat format );
    static Method_IsAlphaOnlyTextureFormat0 __IsAlphaOnlyTextureFormat0;
    public static bool IsAlphaOnlyTextureFormat( UnityEngine.TextureFormat format ) {
      if( __IsAlphaOnlyTextureFormat0 == null ) {
        __IsAlphaOnlyTextureFormat0 = (Method_IsAlphaOnlyTextureFormat0) Delegate.CreateDelegate( typeof( Method_IsAlphaOnlyTextureFormat0 ), null, R.Method("IsAlphaOnlyTextureFormat", "UnityEditor.TextureUtil", "UnityEditor.dll") );
      }
      return __IsAlphaOnlyTextureFormat0(  format  );
    }



    delegate bool Method_HasAlphaTextureFormat0( UnityEngine.TextureFormat format );
    static Method_HasAlphaTextureFormat0 __HasAlphaTextureFormat0;
    public static bool HasAlphaTextureFormat( UnityEngine.TextureFormat format ) {
      if( __HasAlphaTextureFormat0 == null ) {
        __HasAlphaTextureFormat0 = (Method_HasAlphaTextureFormat0) Delegate.CreateDelegate( typeof( Method_HasAlphaTextureFormat0 ), null, R.Method("HasAlphaTextureFormat", "UnityEditor.TextureUtil", "UnityEditor.dll") );
      }
      return __HasAlphaTextureFormat0(  format  );
    }



    delegate string Method_GetTextureFormatString0( UnityEngine.TextureFormat format );
    static Method_GetTextureFormatString0 __GetTextureFormatString0;
    public static string GetTextureFormatString( UnityEngine.TextureFormat format ) {
      if( __GetTextureFormatString0 == null ) {
        __GetTextureFormatString0 = (Method_GetTextureFormatString0) Delegate.CreateDelegate( typeof( Method_GetTextureFormatString0 ), null, R.Method("GetTextureFormatString", "UnityEditor.TextureUtil", "UnityEditor.dll") );
      }
      return __GetTextureFormatString0(  format  );
    }



    delegate string Method_GetTextureColorSpaceString0( UnityEngine.Texture texture );
    static Method_GetTextureColorSpaceString0 __GetTextureColorSpaceString0;
    public static string GetTextureColorSpaceString( UnityEngine.Texture texture ) {
      if( __GetTextureColorSpaceString0 == null ) {
        __GetTextureColorSpaceString0 = (Method_GetTextureColorSpaceString0) Delegate.CreateDelegate( typeof( Method_GetTextureColorSpaceString0 ), null, R.Method("GetTextureColorSpaceString", "UnityEditor.TextureUtil", "UnityEditor.dll") );
      }
      return __GetTextureColorSpaceString0(  texture  );
    }



    delegate UnityEngine.TextureFormat Method_ConvertToAlphaTextureFormat0( UnityEngine.TextureFormat format );
    static Method_ConvertToAlphaTextureFormat0 __ConvertToAlphaTextureFormat0;
    public static UnityEngine.TextureFormat ConvertToAlphaTextureFormat( UnityEngine.TextureFormat format ) {
      if( __ConvertToAlphaTextureFormat0 == null ) {
        __ConvertToAlphaTextureFormat0 = (Method_ConvertToAlphaTextureFormat0) Delegate.CreateDelegate( typeof( Method_ConvertToAlphaTextureFormat0 ), null, R.Method("ConvertToAlphaTextureFormat", "UnityEditor.TextureUtil", "UnityEditor.dll") );
      }
      return __ConvertToAlphaTextureFormat0(  format  );
    }



    delegate bool Method_IsDepthRTFormat0( UnityEngine.RenderTextureFormat format );
    static Method_IsDepthRTFormat0 __IsDepthRTFormat0;
    public static bool IsDepthRTFormat( UnityEngine.RenderTextureFormat format ) {
      if( __IsDepthRTFormat0 == null ) {
        __IsDepthRTFormat0 = (Method_IsDepthRTFormat0) Delegate.CreateDelegate( typeof( Method_IsDepthRTFormat0 ), null, R.Method("IsDepthRTFormat", "UnityEditor.TextureUtil", "UnityEditor.dll") );
      }
      return __IsDepthRTFormat0(  format  );
    }



    delegate bool Method_HasMipMap0( UnityEngine.Texture t );
    static Method_HasMipMap0 __HasMipMap0;
    public static bool HasMipMap( UnityEngine.Texture t ) {
      if( __HasMipMap0 == null ) {
        __HasMipMap0 = (Method_HasMipMap0) Delegate.CreateDelegate( typeof( Method_HasMipMap0 ), null, R.Method("HasMipMap", "UnityEditor.TextureUtil", "UnityEditor.dll") );
      }
      return __HasMipMap0(  t  );
    }



    delegate int Method_GetGPUWidth0( UnityEngine.Texture t );
    static Method_GetGPUWidth0 __GetGPUWidth0;
    public static int GetGPUWidth( UnityEngine.Texture t ) {
      if( __GetGPUWidth0 == null ) {
        __GetGPUWidth0 = (Method_GetGPUWidth0) Delegate.CreateDelegate( typeof( Method_GetGPUWidth0 ), null, R.Method("GetGPUWidth", "UnityEditor.TextureUtil", "UnityEditor.dll") );
      }
      return __GetGPUWidth0(  t  );
    }



    delegate int Method_GetGPUHeight0( UnityEngine.Texture t );
    static Method_GetGPUHeight0 __GetGPUHeight0;
    public static int GetGPUHeight( UnityEngine.Texture t ) {
      if( __GetGPUHeight0 == null ) {
        __GetGPUHeight0 = (Method_GetGPUHeight0) Delegate.CreateDelegate( typeof( Method_GetGPUHeight0 ), null, R.Method("GetGPUHeight", "UnityEditor.TextureUtil", "UnityEditor.dll") );
      }
      return __GetGPUHeight0(  t  );
    }



    delegate int Method_GetMipmapCount0( UnityEngine.Texture t );
    static Method_GetMipmapCount0 __GetMipmapCount0;
    public static int GetMipmapCount( UnityEngine.Texture t ) {
      if( __GetMipmapCount0 == null ) {
        __GetMipmapCount0 = (Method_GetMipmapCount0) Delegate.CreateDelegate( typeof( Method_GetMipmapCount0 ), null, R.Method("GetMipmapCount", "UnityEditor.TextureUtil", "UnityEditor.dll") );
      }
      return __GetMipmapCount0(  t  );
    }



    delegate bool Method_GetLinearSampled0( UnityEngine.Texture t );
    static Method_GetLinearSampled0 __GetLinearSampled0;
    public static bool GetLinearSampled( UnityEngine.Texture t ) {
      if( __GetLinearSampled0 == null ) {
        __GetLinearSampled0 = (Method_GetLinearSampled0) Delegate.CreateDelegate( typeof( Method_GetLinearSampled0 ), null, R.Method("GetLinearSampled", "UnityEditor.TextureUtil", "UnityEditor.dll") );
      }
      return __GetLinearSampled0(  t  );
    }



    delegate int Method_GetDefaultCompressionQuality0();
    static Method_GetDefaultCompressionQuality0 __GetDefaultCompressionQuality0;
    public static int GetDefaultCompressionQuality() {
      if( __GetDefaultCompressionQuality0 == null ) {
        __GetDefaultCompressionQuality0 = (Method_GetDefaultCompressionQuality0) Delegate.CreateDelegate( typeof( Method_GetDefaultCompressionQuality0 ), null, R.Method("GetDefaultCompressionQuality", "UnityEditor.TextureUtil", "UnityEditor.dll") );
      }
      return __GetDefaultCompressionQuality0(  );
    }



    delegate UnityEngine.Vector4 Method_GetTexelSizeVector0( UnityEngine.Texture t );
    static Method_GetTexelSizeVector0 __GetTexelSizeVector0;
    public static UnityEngine.Vector4 GetTexelSizeVector( UnityEngine.Texture t ) {
      if( __GetTexelSizeVector0 == null ) {
        __GetTexelSizeVector0 = (Method_GetTexelSizeVector0) Delegate.CreateDelegate( typeof( Method_GetTexelSizeVector0 ), null, R.Method("GetTexelSizeVector", "UnityEditor.TextureUtil", "UnityEditor.dll") );
      }
      return __GetTexelSizeVector0(  t  );
    }



    delegate UnityEngine.Texture2D Method_GetSourceTexture0( UnityEngine.Cubemap cubemapRef, UnityEngine.CubemapFace face );
    static Method_GetSourceTexture0 __GetSourceTexture0;
    public static UnityEngine.Texture2D GetSourceTexture( UnityEngine.Cubemap cubemapRef, UnityEngine.CubemapFace face ) {
      if( __GetSourceTexture0 == null ) {
        __GetSourceTexture0 = (Method_GetSourceTexture0) Delegate.CreateDelegate( typeof( Method_GetSourceTexture0 ), null, R.Method("GetSourceTexture", "UnityEditor.TextureUtil", "UnityEditor.dll") );
      }
      return __GetSourceTexture0(  cubemapRef, face  );
    }



    delegate void Method_SetSourceTexture0( UnityEngine.Cubemap cubemapRef, UnityEngine.CubemapFace face, UnityEngine.Texture2D tex );
    static Method_SetSourceTexture0 __SetSourceTexture0;
    public static void SetSourceTexture( UnityEngine.Cubemap cubemapRef, UnityEngine.CubemapFace face, UnityEngine.Texture2D tex ) {
      if( __SetSourceTexture0 == null ) {
        __SetSourceTexture0 = (Method_SetSourceTexture0) Delegate.CreateDelegate( typeof( Method_SetSourceTexture0 ), null, R.Method("SetSourceTexture", "UnityEditor.TextureUtil", "UnityEditor.dll") );
      }
      __SetSourceTexture0(  cubemapRef, face, tex  );
    }



    delegate void Method_CopyTextureIntoCubemapFace0( UnityEngine.Texture2D textureRef, UnityEngine.Cubemap cubemapRef, UnityEngine.CubemapFace face );
    static Method_CopyTextureIntoCubemapFace0 __CopyTextureIntoCubemapFace0;
    public static void CopyTextureIntoCubemapFace( UnityEngine.Texture2D textureRef, UnityEngine.Cubemap cubemapRef, UnityEngine.CubemapFace face ) {
      if( __CopyTextureIntoCubemapFace0 == null ) {
        __CopyTextureIntoCubemapFace0 = (Method_CopyTextureIntoCubemapFace0) Delegate.CreateDelegate( typeof( Method_CopyTextureIntoCubemapFace0 ), null, R.Method("CopyTextureIntoCubemapFace", "UnityEditor.TextureUtil", "UnityEditor.dll") );
      }
      __CopyTextureIntoCubemapFace0(  textureRef, cubemapRef, face  );
    }



    delegate void Method_CopyCubemapFaceIntoTexture0( UnityEngine.Cubemap cubemapRef, UnityEngine.CubemapFace face, UnityEngine.Texture2D textureRef );
    static Method_CopyCubemapFaceIntoTexture0 __CopyCubemapFaceIntoTexture0;
    public static void CopyCubemapFaceIntoTexture( UnityEngine.Cubemap cubemapRef, UnityEngine.CubemapFace face, UnityEngine.Texture2D textureRef ) {
      if( __CopyCubemapFaceIntoTexture0 == null ) {
        __CopyCubemapFaceIntoTexture0 = (Method_CopyCubemapFaceIntoTexture0) Delegate.CreateDelegate( typeof( Method_CopyCubemapFaceIntoTexture0 ), null, R.Method("CopyCubemapFaceIntoTexture", "UnityEditor.TextureUtil", "UnityEditor.dll") );
      }
      __CopyCubemapFaceIntoTexture0(  cubemapRef, face, textureRef  );
    }



    delegate bool Method_ReformatCubemap0( UnityEngine.Cubemap cubemap, int width, int height, UnityEngine.TextureFormat textureFormat, bool useMipmap, bool linear );
    static Method_ReformatCubemap0 __ReformatCubemap0;
    public static bool ReformatCubemap( UnityEngine.Cubemap cubemap, int width, int height, UnityEngine.TextureFormat textureFormat, bool useMipmap, bool linear ) {
      if( __ReformatCubemap0 == null ) {
        __ReformatCubemap0 = (Method_ReformatCubemap0) Delegate.CreateDelegate( typeof( Method_ReformatCubemap0 ), null, R.Method("ReformatCubemap", "UnityEditor.TextureUtil", "UnityEditor.dll") );
      }
      return __ReformatCubemap0(  cubemap, width, height, textureFormat, useMipmap, linear  );
    }



    delegate bool Method_ReformatTexture0( ref UnityEngine.Texture2D texture, int width, int height, UnityEngine.TextureFormat textureFormat, bool useMipmap, bool linear );
    static Method_ReformatTexture0 __ReformatTexture0;
    public static bool ReformatTexture( ref UnityEngine.Texture2D texture, int width, int height, UnityEngine.TextureFormat textureFormat, bool useMipmap, bool linear ) {
      if( __ReformatTexture0 == null ) {
        __ReformatTexture0 = (Method_ReformatTexture0) Delegate.CreateDelegate( typeof( Method_ReformatTexture0 ), null, R.Method("ReformatTexture", "UnityEditor.TextureUtil", "UnityEditor.dll") );
      }
      return __ReformatTexture0(  ref texture, width, height, textureFormat, useMipmap, linear  );
    }



    delegate void Method_SetAnisoLevelNoDirty0( UnityEngine.Texture tex, int level );
    static Method_SetAnisoLevelNoDirty0 __SetAnisoLevelNoDirty0;
    public static void SetAnisoLevelNoDirty( UnityEngine.Texture tex, int level ) {
      if( __SetAnisoLevelNoDirty0 == null ) {
        __SetAnisoLevelNoDirty0 = (Method_SetAnisoLevelNoDirty0) Delegate.CreateDelegate( typeof( Method_SetAnisoLevelNoDirty0 ), null, R.Method("SetAnisoLevelNoDirty", "UnityEditor.TextureUtil", "UnityEditor.dll") );
      }
      __SetAnisoLevelNoDirty0(  tex, level  );
    }



    delegate void Method_SetWrapModeNoDirty0( UnityEngine.Texture tex, UnityEngine.TextureWrapMode u, UnityEngine.TextureWrapMode v, UnityEngine.TextureWrapMode w );
    static Method_SetWrapModeNoDirty0 __SetWrapModeNoDirty0;
    public static void SetWrapModeNoDirty( UnityEngine.Texture tex, UnityEngine.TextureWrapMode u, UnityEngine.TextureWrapMode v, UnityEngine.TextureWrapMode w ) {
      if( __SetWrapModeNoDirty0 == null ) {
        __SetWrapModeNoDirty0 = (Method_SetWrapModeNoDirty0) Delegate.CreateDelegate( typeof( Method_SetWrapModeNoDirty0 ), null, R.Method("SetWrapModeNoDirty", "UnityEditor.TextureUtil", "UnityEditor.dll") );
      }
      __SetWrapModeNoDirty0(  tex, u, v, w  );
    }



    delegate void Method_SetMipMapBiasNoDirty0( UnityEngine.Texture tex, float bias );
    static Method_SetMipMapBiasNoDirty0 __SetMipMapBiasNoDirty0;
    public static void SetMipMapBiasNoDirty( UnityEngine.Texture tex, float bias ) {
      if( __SetMipMapBiasNoDirty0 == null ) {
        __SetMipMapBiasNoDirty0 = (Method_SetMipMapBiasNoDirty0) Delegate.CreateDelegate( typeof( Method_SetMipMapBiasNoDirty0 ), null, R.Method("SetMipMapBiasNoDirty", "UnityEditor.TextureUtil", "UnityEditor.dll") );
      }
      __SetMipMapBiasNoDirty0(  tex, bias  );
    }



    delegate void Method_SetFilterModeNoDirty0( UnityEngine.Texture tex, UnityEngine.FilterMode mode );
    static Method_SetFilterModeNoDirty0 __SetFilterModeNoDirty0;
    public static void SetFilterModeNoDirty( UnityEngine.Texture tex, UnityEngine.FilterMode mode ) {
      if( __SetFilterModeNoDirty0 == null ) {
        __SetFilterModeNoDirty0 = (Method_SetFilterModeNoDirty0) Delegate.CreateDelegate( typeof( Method_SetFilterModeNoDirty0 ), null, R.Method("SetFilterModeNoDirty", "UnityEditor.TextureUtil", "UnityEditor.dll") );
      }
      __SetFilterModeNoDirty0(  tex, mode  );
    }



    delegate bool Method_DoesTextureStillNeedToBeCompressed0( string assetPath );
    static Method_DoesTextureStillNeedToBeCompressed0 __DoesTextureStillNeedToBeCompressed0;
    public static bool DoesTextureStillNeedToBeCompressed( string assetPath ) {
      if( __DoesTextureStillNeedToBeCompressed0 == null ) {
        __DoesTextureStillNeedToBeCompressed0 = (Method_DoesTextureStillNeedToBeCompressed0) Delegate.CreateDelegate( typeof( Method_DoesTextureStillNeedToBeCompressed0 ), null, R.Method("DoesTextureStillNeedToBeCompressed", "UnityEditor.TextureUtil", "UnityEditor.dll") );
      }
      return __DoesTextureStillNeedToBeCompressed0(  assetPath  );
    }



    delegate bool Method_IsCubemapReadable0( UnityEngine.Cubemap cubemapRef );
    static Method_IsCubemapReadable0 __IsCubemapReadable0;
    public static bool IsCubemapReadable( UnityEngine.Cubemap cubemapRef ) {
      if( __IsCubemapReadable0 == null ) {
        __IsCubemapReadable0 = (Method_IsCubemapReadable0) Delegate.CreateDelegate( typeof( Method_IsCubemapReadable0 ), null, R.Method("IsCubemapReadable", "UnityEditor.TextureUtil", "UnityEditor.dll") );
      }
      return __IsCubemapReadable0(  cubemapRef  );
    }



    delegate void Method_MarkCubemapReadable0( UnityEngine.Cubemap cubemapRef, bool readable );
    static Method_MarkCubemapReadable0 __MarkCubemapReadable0;
    public static void MarkCubemapReadable( UnityEngine.Cubemap cubemapRef, bool readable ) {
      if( __MarkCubemapReadable0 == null ) {
        __MarkCubemapReadable0 = (Method_MarkCubemapReadable0) Delegate.CreateDelegate( typeof( Method_MarkCubemapReadable0 ), null, R.Method("MarkCubemapReadable", "UnityEditor.TextureUtil", "UnityEditor.dll") );
      }
      __MarkCubemapReadable0(  cubemapRef, readable  );
    }



    delegate bool Method_GetTexture2DStreamingMipmaps0( UnityEngine.Texture2D texture );
    static Method_GetTexture2DStreamingMipmaps0 __GetTexture2DStreamingMipmaps0;
    public static bool GetTexture2DStreamingMipmaps( UnityEngine.Texture2D texture ) {
      if( __GetTexture2DStreamingMipmaps0 == null ) {
        __GetTexture2DStreamingMipmaps0 = (Method_GetTexture2DStreamingMipmaps0) Delegate.CreateDelegate( typeof( Method_GetTexture2DStreamingMipmaps0 ), null, R.Method("GetTexture2DStreamingMipmaps", "UnityEditor.TextureUtil", "UnityEditor.dll") );
      }
      return __GetTexture2DStreamingMipmaps0(  texture  );
    }



    delegate int Method_GetTexture2DStreamingMipmapsPriority0( UnityEngine.Texture2D texture );
    static Method_GetTexture2DStreamingMipmapsPriority0 __GetTexture2DStreamingMipmapsPriority0;
    public static int GetTexture2DStreamingMipmapsPriority( UnityEngine.Texture2D texture ) {
      if( __GetTexture2DStreamingMipmapsPriority0 == null ) {
        __GetTexture2DStreamingMipmapsPriority0 = (Method_GetTexture2DStreamingMipmapsPriority0) Delegate.CreateDelegate( typeof( Method_GetTexture2DStreamingMipmapsPriority0 ), null, R.Method("GetTexture2DStreamingMipmapsPriority", "UnityEditor.TextureUtil", "UnityEditor.dll") );
      }
      return __GetTexture2DStreamingMipmapsPriority0(  texture  );
    }



    delegate bool Method_GetCubemapStreamingMipmaps0( UnityEngine.Cubemap cubemap );
    static Method_GetCubemapStreamingMipmaps0 __GetCubemapStreamingMipmaps0;
    public static bool GetCubemapStreamingMipmaps( UnityEngine.Cubemap cubemap ) {
      if( __GetCubemapStreamingMipmaps0 == null ) {
        __GetCubemapStreamingMipmaps0 = (Method_GetCubemapStreamingMipmaps0) Delegate.CreateDelegate( typeof( Method_GetCubemapStreamingMipmaps0 ), null, R.Method("GetCubemapStreamingMipmaps", "UnityEditor.TextureUtil", "UnityEditor.dll") );
      }
      return __GetCubemapStreamingMipmaps0(  cubemap  );
    }



    delegate int Method_GetCubemapStreamingMipmapsPriority0( UnityEngine.Cubemap cubemap );
    static Method_GetCubemapStreamingMipmapsPriority0 __GetCubemapStreamingMipmapsPriority0;
    public static int GetCubemapStreamingMipmapsPriority( UnityEngine.Cubemap cubemap ) {
      if( __GetCubemapStreamingMipmapsPriority0 == null ) {
        __GetCubemapStreamingMipmapsPriority0 = (Method_GetCubemapStreamingMipmapsPriority0) Delegate.CreateDelegate( typeof( Method_GetCubemapStreamingMipmapsPriority0 ), null, R.Method("GetCubemapStreamingMipmapsPriority", "UnityEditor.TextureUtil", "UnityEditor.dll") );
      }
      return __GetCubemapStreamingMipmapsPriority0(  cubemap  );
    }



    delegate void Method_SetTexture2DStreamingMipmaps0( UnityEngine.Texture2D textureRef, bool streaming );
    static Method_SetTexture2DStreamingMipmaps0 __SetTexture2DStreamingMipmaps0;
    public static void SetTexture2DStreamingMipmaps( UnityEngine.Texture2D textureRef, bool streaming ) {
      if( __SetTexture2DStreamingMipmaps0 == null ) {
        __SetTexture2DStreamingMipmaps0 = (Method_SetTexture2DStreamingMipmaps0) Delegate.CreateDelegate( typeof( Method_SetTexture2DStreamingMipmaps0 ), null, R.Method("SetTexture2DStreamingMipmaps", "UnityEditor.TextureUtil", "UnityEditor.dll") );
      }
      __SetTexture2DStreamingMipmaps0(  textureRef, streaming  );
    }



    delegate void Method_SetTexture2DStreamingMipmapsPriority0( UnityEngine.Texture2D textureRef, int priority );
    static Method_SetTexture2DStreamingMipmapsPriority0 __SetTexture2DStreamingMipmapsPriority0;
    public static void SetTexture2DStreamingMipmapsPriority( UnityEngine.Texture2D textureRef, int priority ) {
      if( __SetTexture2DStreamingMipmapsPriority0 == null ) {
        __SetTexture2DStreamingMipmapsPriority0 = (Method_SetTexture2DStreamingMipmapsPriority0) Delegate.CreateDelegate( typeof( Method_SetTexture2DStreamingMipmapsPriority0 ), null, R.Method("SetTexture2DStreamingMipmapsPriority", "UnityEditor.TextureUtil", "UnityEditor.dll") );
      }
      __SetTexture2DStreamingMipmapsPriority0(  textureRef, priority  );
    }



    delegate void Method_SetCubemapStreamingMipmaps0( UnityEngine.Cubemap cubemapRef, bool streaming );
    static Method_SetCubemapStreamingMipmaps0 __SetCubemapStreamingMipmaps0;
    public static void SetCubemapStreamingMipmaps( UnityEngine.Cubemap cubemapRef, bool streaming ) {
      if( __SetCubemapStreamingMipmaps0 == null ) {
        __SetCubemapStreamingMipmaps0 = (Method_SetCubemapStreamingMipmaps0) Delegate.CreateDelegate( typeof( Method_SetCubemapStreamingMipmaps0 ), null, R.Method("SetCubemapStreamingMipmaps", "UnityEditor.TextureUtil", "UnityEditor.dll") );
      }
      __SetCubemapStreamingMipmaps0(  cubemapRef, streaming  );
    }



    delegate void Method_SetCubemapStreamingMipmapsPriority0( UnityEngine.Cubemap cubemapRef, int priority );
    static Method_SetCubemapStreamingMipmapsPriority0 __SetCubemapStreamingMipmapsPriority0;
    public static void SetCubemapStreamingMipmapsPriority( UnityEngine.Cubemap cubemapRef, int priority ) {
      if( __SetCubemapStreamingMipmapsPriority0 == null ) {
        __SetCubemapStreamingMipmapsPriority0 = (Method_SetCubemapStreamingMipmapsPriority0) Delegate.CreateDelegate( typeof( Method_SetCubemapStreamingMipmapsPriority0 ), null, R.Method("SetCubemapStreamingMipmapsPriority", "UnityEditor.TextureUtil", "UnityEditor.dll") );
      }
      __SetCubemapStreamingMipmapsPriority0(  cubemapRef, priority  );
    }



	}
}

#endif

