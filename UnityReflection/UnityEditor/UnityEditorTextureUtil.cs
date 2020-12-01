/// UnityEditor.TextureUtil : 2019.4.5f1

using Hananoki;
using Hananoki.Reflection;
using System;
using UnityEngine;

namespace UnityReflection {
  public sealed partial class UnityEditorTextureUtil {
    
		public static int GetStorageMemorySize( Texture t ) {
			if( __GetStorageMemorySize_0_1 == null ) {
				__GetStorageMemorySize_0_1 = (Func<Texture, int>) Delegate.CreateDelegate( typeof( Func<Texture, int> ), null, UnityTypes.UnityEditor_TextureUtil.GetMethod( "GetStorageMemorySize", R.StaticMembers, null, new Type[]{ typeof( Texture ) }, null ) );
			}
			return __GetStorageMemorySize_0_1( t );
		}
		
		public static long GetStorageMemorySizeLong( Texture t ) {
			if( __GetStorageMemorySizeLong_0_1 == null ) {
				__GetStorageMemorySizeLong_0_1 = (Func<Texture, long>) Delegate.CreateDelegate( typeof( Func<Texture, long> ), null, UnityTypes.UnityEditor_TextureUtil.GetMethod( "GetStorageMemorySizeLong", R.StaticMembers, null, new Type[]{ typeof( Texture ) }, null ) );
			}
			return __GetStorageMemorySizeLong_0_1( t );
		}
		
		public static int GetRuntimeMemorySize( Texture t ) {
			if( __GetRuntimeMemorySize_0_1 == null ) {
				__GetRuntimeMemorySize_0_1 = (Func<Texture, int>) Delegate.CreateDelegate( typeof( Func<Texture, int> ), null, UnityTypes.UnityEditor_TextureUtil.GetMethod( "GetRuntimeMemorySize", R.StaticMembers, null, new Type[]{ typeof( Texture ) }, null ) );
			}
			return __GetRuntimeMemorySize_0_1( t );
		}
		
		public static long GetRuntimeMemorySizeLong( Texture t ) {
			if( __GetRuntimeMemorySizeLong_0_1 == null ) {
				__GetRuntimeMemorySizeLong_0_1 = (Func<Texture, long>) Delegate.CreateDelegate( typeof( Func<Texture, long> ), null, UnityTypes.UnityEditor_TextureUtil.GetMethod( "GetRuntimeMemorySizeLong", R.StaticMembers, null, new Type[]{ typeof( Texture ) }, null ) );
			}
			return __GetRuntimeMemorySizeLong_0_1( t );
		}
		
		public static bool IsNonPowerOfTwo( Texture2D t ) {
			if( __IsNonPowerOfTwo_0_1 == null ) {
				__IsNonPowerOfTwo_0_1 = (Func<Texture2D, bool>) Delegate.CreateDelegate( typeof( Func<Texture2D, bool> ), null, UnityTypes.UnityEditor_TextureUtil.GetMethod( "IsNonPowerOfTwo", R.StaticMembers, null, new Type[]{ typeof( Texture2D ) }, null ) );
			}
			return __IsNonPowerOfTwo_0_1( t );
		}
		
		public static object GetUsageMode( Texture t ) {
			if( __GetUsageMode_0_1 == null ) {
				__GetUsageMode_0_1 = (Func<Texture, object>) Delegate.CreateDelegate( typeof( Func<Texture, object> ), null, UnityTypes.UnityEditor_TextureUtil.GetMethod( "GetUsageMode", R.StaticMembers, null, new Type[]{ typeof( Texture ) }, null ) );
			}
			return __GetUsageMode_0_1( t );
		}
		
		public static int GetBytesFromTextureFormat( TextureFormat inFormat ) {
			if( __GetBytesFromTextureFormat_0_1 == null ) {
				__GetBytesFromTextureFormat_0_1 = (Func<TextureFormat, int>) Delegate.CreateDelegate( typeof( Func<TextureFormat, int> ), null, UnityTypes.UnityEditor_TextureUtil.GetMethod( "GetBytesFromTextureFormat", R.StaticMembers, null, new Type[]{ typeof( TextureFormat ) }, null ) );
			}
			return __GetBytesFromTextureFormat_0_1( inFormat );
		}
		
		public static int GetRowBytesFromWidthAndFormat( int width, TextureFormat format ) {
			if( __GetRowBytesFromWidthAndFormat_0_2 == null ) {
				__GetRowBytesFromWidthAndFormat_0_2 = (Func<int,TextureFormat, int>) Delegate.CreateDelegate( typeof( Func<int,TextureFormat, int> ), null, UnityTypes.UnityEditor_TextureUtil.GetMethod( "GetRowBytesFromWidthAndFormat", R.StaticMembers, null, new Type[]{ typeof( int ), typeof( TextureFormat ) }, null ) );
			}
			return __GetRowBytesFromWidthAndFormat_0_2( width, format );
		}
		
		public static bool IsValidTextureFormat( TextureFormat format ) {
			if( __IsValidTextureFormat_0_1 == null ) {
				__IsValidTextureFormat_0_1 = (Func<TextureFormat, bool>) Delegate.CreateDelegate( typeof( Func<TextureFormat, bool> ), null, UnityTypes.UnityEditor_TextureUtil.GetMethod( "IsValidTextureFormat", R.StaticMembers, null, new Type[]{ typeof( TextureFormat ) }, null ) );
			}
			return __IsValidTextureFormat_0_1( format );
		}
		
		public static bool IsCompressedTextureFormat( TextureFormat format ) {
			if( __IsCompressedTextureFormat_0_1 == null ) {
				__IsCompressedTextureFormat_0_1 = (Func<TextureFormat, bool>) Delegate.CreateDelegate( typeof( Func<TextureFormat, bool> ), null, UnityTypes.UnityEditor_TextureUtil.GetMethod( "IsCompressedTextureFormat", R.StaticMembers, null, new Type[]{ typeof( TextureFormat ) }, null ) );
			}
			return __IsCompressedTextureFormat_0_1( format );
		}
		
		public static bool IsCompressedCrunchTextureFormat( TextureFormat format ) {
			if( __IsCompressedCrunchTextureFormat_0_1 == null ) {
				__IsCompressedCrunchTextureFormat_0_1 = (Func<TextureFormat, bool>) Delegate.CreateDelegate( typeof( Func<TextureFormat, bool> ), null, UnityTypes.UnityEditor_TextureUtil.GetMethod( "IsCompressedCrunchTextureFormat", R.StaticMembers, null, new Type[]{ typeof( TextureFormat ) }, null ) );
			}
			return __IsCompressedCrunchTextureFormat_0_1( format );
		}
		
		public static TextureFormat GetTextureFormat( Texture texture ) {
			if( __GetTextureFormat_0_1 == null ) {
				__GetTextureFormat_0_1 = (Func<Texture, TextureFormat>) Delegate.CreateDelegate( typeof( Func<Texture, TextureFormat> ), null, UnityTypes.UnityEditor_TextureUtil.GetMethod( "GetTextureFormat", R.StaticMembers, null, new Type[]{ typeof( Texture ) }, null ) );
			}
			return __GetTextureFormat_0_1( texture );
		}
		
		public static bool IsAlphaOnlyTextureFormat( TextureFormat format ) {
			if( __IsAlphaOnlyTextureFormat_0_1 == null ) {
				__IsAlphaOnlyTextureFormat_0_1 = (Func<TextureFormat, bool>) Delegate.CreateDelegate( typeof( Func<TextureFormat, bool> ), null, UnityTypes.UnityEditor_TextureUtil.GetMethod( "IsAlphaOnlyTextureFormat", R.StaticMembers, null, new Type[]{ typeof( TextureFormat ) }, null ) );
			}
			return __IsAlphaOnlyTextureFormat_0_1( format );
		}
		
		public static bool HasAlphaTextureFormat( TextureFormat format ) {
			if( __HasAlphaTextureFormat_0_1 == null ) {
				__HasAlphaTextureFormat_0_1 = (Func<TextureFormat, bool>) Delegate.CreateDelegate( typeof( Func<TextureFormat, bool> ), null, UnityTypes.UnityEditor_TextureUtil.GetMethod( "HasAlphaTextureFormat", R.StaticMembers, null, new Type[]{ typeof( TextureFormat ) }, null ) );
			}
			return __HasAlphaTextureFormat_0_1( format );
		}
		
		public static string GetTextureFormatString( TextureFormat format ) {
			if( __GetTextureFormatString_0_1 == null ) {
				__GetTextureFormatString_0_1 = (Func<TextureFormat, string>) Delegate.CreateDelegate( typeof( Func<TextureFormat, string> ), null, UnityTypes.UnityEditor_TextureUtil.GetMethod( "GetTextureFormatString", R.StaticMembers, null, new Type[]{ typeof( TextureFormat ) }, null ) );
			}
			return __GetTextureFormatString_0_1( format );
		}
		
		public static string GetTextureColorSpaceString( Texture texture ) {
			if( __GetTextureColorSpaceString_0_1 == null ) {
				__GetTextureColorSpaceString_0_1 = (Func<Texture, string>) Delegate.CreateDelegate( typeof( Func<Texture, string> ), null, UnityTypes.UnityEditor_TextureUtil.GetMethod( "GetTextureColorSpaceString", R.StaticMembers, null, new Type[]{ typeof( Texture ) }, null ) );
			}
			return __GetTextureColorSpaceString_0_1( texture );
		}
		
		public static TextureFormat ConvertToAlphaTextureFormat( TextureFormat format ) {
			if( __ConvertToAlphaTextureFormat_0_1 == null ) {
				__ConvertToAlphaTextureFormat_0_1 = (Func<TextureFormat, TextureFormat>) Delegate.CreateDelegate( typeof( Func<TextureFormat, TextureFormat> ), null, UnityTypes.UnityEditor_TextureUtil.GetMethod( "ConvertToAlphaTextureFormat", R.StaticMembers, null, new Type[]{ typeof( TextureFormat ) }, null ) );
			}
			return __ConvertToAlphaTextureFormat_0_1( format );
		}
		
		public static bool IsDepthRTFormat( RenderTextureFormat format ) {
			if( __IsDepthRTFormat_0_1 == null ) {
				__IsDepthRTFormat_0_1 = (Func<RenderTextureFormat, bool>) Delegate.CreateDelegate( typeof( Func<RenderTextureFormat, bool> ), null, UnityTypes.UnityEditor_TextureUtil.GetMethod( "IsDepthRTFormat", R.StaticMembers, null, new Type[]{ typeof( RenderTextureFormat ) }, null ) );
			}
			return __IsDepthRTFormat_0_1( format );
		}
		
		public static bool HasMipMap( Texture t ) {
			if( __HasMipMap_0_1 == null ) {
				__HasMipMap_0_1 = (Func<Texture, bool>) Delegate.CreateDelegate( typeof( Func<Texture, bool> ), null, UnityTypes.UnityEditor_TextureUtil.GetMethod( "HasMipMap", R.StaticMembers, null, new Type[]{ typeof( Texture ) }, null ) );
			}
			return __HasMipMap_0_1( t );
		}
		
		public static int GetGPUWidth( Texture t ) {
			if( __GetGPUWidth_0_1 == null ) {
				__GetGPUWidth_0_1 = (Func<Texture, int>) Delegate.CreateDelegate( typeof( Func<Texture, int> ), null, UnityTypes.UnityEditor_TextureUtil.GetMethod( "GetGPUWidth", R.StaticMembers, null, new Type[]{ typeof( Texture ) }, null ) );
			}
			return __GetGPUWidth_0_1( t );
		}
		
		public static int GetGPUHeight( Texture t ) {
			if( __GetGPUHeight_0_1 == null ) {
				__GetGPUHeight_0_1 = (Func<Texture, int>) Delegate.CreateDelegate( typeof( Func<Texture, int> ), null, UnityTypes.UnityEditor_TextureUtil.GetMethod( "GetGPUHeight", R.StaticMembers, null, new Type[]{ typeof( Texture ) }, null ) );
			}
			return __GetGPUHeight_0_1( t );
		}
		
		public static int GetMipmapCount( Texture t ) {
			if( __GetMipmapCount_0_1 == null ) {
				__GetMipmapCount_0_1 = (Func<Texture, int>) Delegate.CreateDelegate( typeof( Func<Texture, int> ), null, UnityTypes.UnityEditor_TextureUtil.GetMethod( "GetMipmapCount", R.StaticMembers, null, new Type[]{ typeof( Texture ) }, null ) );
			}
			return __GetMipmapCount_0_1( t );
		}
		
		public static bool GetLinearSampled( Texture t ) {
			if( __GetLinearSampled_0_1 == null ) {
				__GetLinearSampled_0_1 = (Func<Texture, bool>) Delegate.CreateDelegate( typeof( Func<Texture, bool> ), null, UnityTypes.UnityEditor_TextureUtil.GetMethod( "GetLinearSampled", R.StaticMembers, null, new Type[]{ typeof( Texture ) }, null ) );
			}
			return __GetLinearSampled_0_1( t );
		}
		
		public static int GetDefaultCompressionQuality() {
			if( __GetDefaultCompressionQuality_0_0 == null ) {
				__GetDefaultCompressionQuality_0_0 = (Func<int>) Delegate.CreateDelegate( typeof( Func<int> ), null, UnityTypes.UnityEditor_TextureUtil.GetMethod( "GetDefaultCompressionQuality", R.StaticMembers, null, new Type[]{  }, null ) );
			}
			return __GetDefaultCompressionQuality_0_0(  );
		}
		
		public static Vector4 GetTexelSizeVector( Texture t ) {
			if( __GetTexelSizeVector_0_1 == null ) {
				__GetTexelSizeVector_0_1 = (Func<Texture, Vector4>) Delegate.CreateDelegate( typeof( Func<Texture, Vector4> ), null, UnityTypes.UnityEditor_TextureUtil.GetMethod( "GetTexelSizeVector", R.StaticMembers, null, new Type[]{ typeof( Texture ) }, null ) );
			}
			return __GetTexelSizeVector_0_1( t );
		}
		
		public static Texture2D GetSourceTexture( Cubemap cubemapRef, CubemapFace face ) {
			if( __GetSourceTexture_0_2 == null ) {
				__GetSourceTexture_0_2 = (Func<Cubemap,CubemapFace, Texture2D>) Delegate.CreateDelegate( typeof( Func<Cubemap,CubemapFace, Texture2D> ), null, UnityTypes.UnityEditor_TextureUtil.GetMethod( "GetSourceTexture", R.StaticMembers, null, new Type[]{ typeof( Cubemap ), typeof( CubemapFace ) }, null ) );
			}
			return __GetSourceTexture_0_2( cubemapRef, face );
		}
		
		public static void SetSourceTexture( Cubemap cubemapRef, CubemapFace face, Texture2D tex ) {
			if( __SetSourceTexture_0_3 == null ) {
				__SetSourceTexture_0_3 = (Action<Cubemap,CubemapFace,Texture2D>) Delegate.CreateDelegate( typeof( Action<Cubemap,CubemapFace,Texture2D> ), null, UnityTypes.UnityEditor_TextureUtil.GetMethod( "SetSourceTexture", R.StaticMembers, null, new Type[]{ typeof( Cubemap ), typeof( CubemapFace ), typeof( Texture2D ) }, null ) );
			}
			__SetSourceTexture_0_3( cubemapRef, face, tex );
		}
		
		public static void CopyTextureIntoCubemapFace( Texture2D textureRef, Cubemap cubemapRef, CubemapFace face ) {
			if( __CopyTextureIntoCubemapFace_0_3 == null ) {
				__CopyTextureIntoCubemapFace_0_3 = (Action<Texture2D,Cubemap,CubemapFace>) Delegate.CreateDelegate( typeof( Action<Texture2D,Cubemap,CubemapFace> ), null, UnityTypes.UnityEditor_TextureUtil.GetMethod( "CopyTextureIntoCubemapFace", R.StaticMembers, null, new Type[]{ typeof( Texture2D ), typeof( Cubemap ), typeof( CubemapFace ) }, null ) );
			}
			__CopyTextureIntoCubemapFace_0_3( textureRef, cubemapRef, face );
		}
		
		public static void CopyCubemapFaceIntoTexture( Cubemap cubemapRef, CubemapFace face, Texture2D textureRef ) {
			if( __CopyCubemapFaceIntoTexture_0_3 == null ) {
				__CopyCubemapFaceIntoTexture_0_3 = (Action<Cubemap,CubemapFace,Texture2D>) Delegate.CreateDelegate( typeof( Action<Cubemap,CubemapFace,Texture2D> ), null, UnityTypes.UnityEditor_TextureUtil.GetMethod( "CopyCubemapFaceIntoTexture", R.StaticMembers, null, new Type[]{ typeof( Cubemap ), typeof( CubemapFace ), typeof( Texture2D ) }, null ) );
			}
			__CopyCubemapFaceIntoTexture_0_3( cubemapRef, face, textureRef );
		}
		
		public static bool ReformatCubemap( Cubemap cubemap, int width, int height, TextureFormat textureFormat, bool useMipmap, bool linear ) {
			if( __ReformatCubemap_0_6 == null ) {
				__ReformatCubemap_0_6 = (Func<Cubemap,int,int,TextureFormat,bool,bool, bool>) Delegate.CreateDelegate( typeof( Func<Cubemap,int,int,TextureFormat,bool,bool, bool> ), null, UnityTypes.UnityEditor_TextureUtil.GetMethod( "ReformatCubemap", R.StaticMembers, null, new Type[]{ typeof( Cubemap ), typeof( int ), typeof( int ), typeof( TextureFormat ), typeof( bool ), typeof( bool ) }, null ) );
			}
			return __ReformatCubemap_0_6( cubemap, width, height, textureFormat, useMipmap, linear );
		}
		
		public static bool ReformatTexture( ref Texture2D texture, int width, int height, TextureFormat textureFormat, bool useMipmap, bool linear ) {
			if( __ReformatTexture_0_6 == null ) {
				__ReformatTexture_0_6 = (Method_ReformatTexture_0_6) Delegate.CreateDelegate( typeof( Method_ReformatTexture_0_6 ), null, UnityTypes.UnityEditor_TextureUtil.GetMethod( "ReformatTexture", R.StaticMembers, null, new Type[]{ typeof( Texture2D ).MakeByRefType(), typeof( int ), typeof( int ), typeof( TextureFormat ), typeof( bool ), typeof( bool ) }, null ) );
			}
			return __ReformatTexture_0_6( ref texture, width, height, textureFormat, useMipmap, linear );
		}
		
		public static void SetAnisoLevelNoDirty( Texture tex, int level ) {
			if( __SetAnisoLevelNoDirty_0_2 == null ) {
				__SetAnisoLevelNoDirty_0_2 = (Action<Texture,int>) Delegate.CreateDelegate( typeof( Action<Texture,int> ), null, UnityTypes.UnityEditor_TextureUtil.GetMethod( "SetAnisoLevelNoDirty", R.StaticMembers, null, new Type[]{ typeof( Texture ), typeof( int ) }, null ) );
			}
			__SetAnisoLevelNoDirty_0_2( tex, level );
		}
		
		public static void SetWrapModeNoDirty( Texture tex, TextureWrapMode u, TextureWrapMode v, TextureWrapMode w ) {
			if( __SetWrapModeNoDirty_0_4 == null ) {
				__SetWrapModeNoDirty_0_4 = (Action<Texture,TextureWrapMode,TextureWrapMode,TextureWrapMode>) Delegate.CreateDelegate( typeof( Action<Texture,TextureWrapMode,TextureWrapMode,TextureWrapMode> ), null, UnityTypes.UnityEditor_TextureUtil.GetMethod( "SetWrapModeNoDirty", R.StaticMembers, null, new Type[]{ typeof( Texture ), typeof( TextureWrapMode ), typeof( TextureWrapMode ), typeof( TextureWrapMode ) }, null ) );
			}
			__SetWrapModeNoDirty_0_4( tex, u, v, w );
		}
		
		public static void SetMipMapBiasNoDirty( Texture tex, float bias ) {
			if( __SetMipMapBiasNoDirty_0_2 == null ) {
				__SetMipMapBiasNoDirty_0_2 = (Action<Texture,float>) Delegate.CreateDelegate( typeof( Action<Texture,float> ), null, UnityTypes.UnityEditor_TextureUtil.GetMethod( "SetMipMapBiasNoDirty", R.StaticMembers, null, new Type[]{ typeof( Texture ), typeof( float ) }, null ) );
			}
			__SetMipMapBiasNoDirty_0_2( tex, bias );
		}
		
		public static void SetFilterModeNoDirty( Texture tex, FilterMode mode ) {
			if( __SetFilterModeNoDirty_0_2 == null ) {
				__SetFilterModeNoDirty_0_2 = (Action<Texture,FilterMode>) Delegate.CreateDelegate( typeof( Action<Texture,FilterMode> ), null, UnityTypes.UnityEditor_TextureUtil.GetMethod( "SetFilterModeNoDirty", R.StaticMembers, null, new Type[]{ typeof( Texture ), typeof( FilterMode ) }, null ) );
			}
			__SetFilterModeNoDirty_0_2( tex, mode );
		}
		
		public static bool DoesTextureStillNeedToBeCompressed( string assetPath ) {
			if( __DoesTextureStillNeedToBeCompressed_0_1 == null ) {
				__DoesTextureStillNeedToBeCompressed_0_1 = (Func<string, bool>) Delegate.CreateDelegate( typeof( Func<string, bool> ), null, UnityTypes.UnityEditor_TextureUtil.GetMethod( "DoesTextureStillNeedToBeCompressed", R.StaticMembers, null, new Type[]{ typeof( string ) }, null ) );
			}
			return __DoesTextureStillNeedToBeCompressed_0_1( assetPath );
		}
		
		public static bool IsCubemapReadable( Cubemap cubemapRef ) {
			if( __IsCubemapReadable_0_1 == null ) {
				__IsCubemapReadable_0_1 = (Func<Cubemap, bool>) Delegate.CreateDelegate( typeof( Func<Cubemap, bool> ), null, UnityTypes.UnityEditor_TextureUtil.GetMethod( "IsCubemapReadable", R.StaticMembers, null, new Type[]{ typeof( Cubemap ) }, null ) );
			}
			return __IsCubemapReadable_0_1( cubemapRef );
		}
		
		public static void MarkCubemapReadable( Cubemap cubemapRef, bool readable ) {
			if( __MarkCubemapReadable_0_2 == null ) {
				__MarkCubemapReadable_0_2 = (Action<Cubemap,bool>) Delegate.CreateDelegate( typeof( Action<Cubemap,bool> ), null, UnityTypes.UnityEditor_TextureUtil.GetMethod( "MarkCubemapReadable", R.StaticMembers, null, new Type[]{ typeof( Cubemap ), typeof( bool ) }, null ) );
			}
			__MarkCubemapReadable_0_2( cubemapRef, readable );
		}
		
		public static bool GetTexture2DStreamingMipmaps( Texture2D texture ) {
			if( __GetTexture2DStreamingMipmaps_0_1 == null ) {
				__GetTexture2DStreamingMipmaps_0_1 = (Func<Texture2D, bool>) Delegate.CreateDelegate( typeof( Func<Texture2D, bool> ), null, UnityTypes.UnityEditor_TextureUtil.GetMethod( "GetTexture2DStreamingMipmaps", R.StaticMembers, null, new Type[]{ typeof( Texture2D ) }, null ) );
			}
			return __GetTexture2DStreamingMipmaps_0_1( texture );
		}
		
		public static int GetTexture2DStreamingMipmapsPriority( Texture2D texture ) {
			if( __GetTexture2DStreamingMipmapsPriority_0_1 == null ) {
				__GetTexture2DStreamingMipmapsPriority_0_1 = (Func<Texture2D, int>) Delegate.CreateDelegate( typeof( Func<Texture2D, int> ), null, UnityTypes.UnityEditor_TextureUtil.GetMethod( "GetTexture2DStreamingMipmapsPriority", R.StaticMembers, null, new Type[]{ typeof( Texture2D ) }, null ) );
			}
			return __GetTexture2DStreamingMipmapsPriority_0_1( texture );
		}
		
		public static bool GetCubemapStreamingMipmaps( Cubemap cubemap ) {
			if( __GetCubemapStreamingMipmaps_0_1 == null ) {
				__GetCubemapStreamingMipmaps_0_1 = (Func<Cubemap, bool>) Delegate.CreateDelegate( typeof( Func<Cubemap, bool> ), null, UnityTypes.UnityEditor_TextureUtil.GetMethod( "GetCubemapStreamingMipmaps", R.StaticMembers, null, new Type[]{ typeof( Cubemap ) }, null ) );
			}
			return __GetCubemapStreamingMipmaps_0_1( cubemap );
		}
		
		public static int GetCubemapStreamingMipmapsPriority( Cubemap cubemap ) {
			if( __GetCubemapStreamingMipmapsPriority_0_1 == null ) {
				__GetCubemapStreamingMipmapsPriority_0_1 = (Func<Cubemap, int>) Delegate.CreateDelegate( typeof( Func<Cubemap, int> ), null, UnityTypes.UnityEditor_TextureUtil.GetMethod( "GetCubemapStreamingMipmapsPriority", R.StaticMembers, null, new Type[]{ typeof( Cubemap ) }, null ) );
			}
			return __GetCubemapStreamingMipmapsPriority_0_1( cubemap );
		}
		
		public static void SetTexture2DStreamingMipmaps( Texture2D textureRef, bool streaming ) {
			if( __SetTexture2DStreamingMipmaps_0_2 == null ) {
				__SetTexture2DStreamingMipmaps_0_2 = (Action<Texture2D,bool>) Delegate.CreateDelegate( typeof( Action<Texture2D,bool> ), null, UnityTypes.UnityEditor_TextureUtil.GetMethod( "SetTexture2DStreamingMipmaps", R.StaticMembers, null, new Type[]{ typeof( Texture2D ), typeof( bool ) }, null ) );
			}
			__SetTexture2DStreamingMipmaps_0_2( textureRef, streaming );
		}
		
		public static void SetTexture2DStreamingMipmapsPriority( Texture2D textureRef, int priority ) {
			if( __SetTexture2DStreamingMipmapsPriority_0_2 == null ) {
				__SetTexture2DStreamingMipmapsPriority_0_2 = (Action<Texture2D,int>) Delegate.CreateDelegate( typeof( Action<Texture2D,int> ), null, UnityTypes.UnityEditor_TextureUtil.GetMethod( "SetTexture2DStreamingMipmapsPriority", R.StaticMembers, null, new Type[]{ typeof( Texture2D ), typeof( int ) }, null ) );
			}
			__SetTexture2DStreamingMipmapsPriority_0_2( textureRef, priority );
		}
		
		public static void SetCubemapStreamingMipmaps( Cubemap cubemapRef, bool streaming ) {
			if( __SetCubemapStreamingMipmaps_0_2 == null ) {
				__SetCubemapStreamingMipmaps_0_2 = (Action<Cubemap,bool>) Delegate.CreateDelegate( typeof( Action<Cubemap,bool> ), null, UnityTypes.UnityEditor_TextureUtil.GetMethod( "SetCubemapStreamingMipmaps", R.StaticMembers, null, new Type[]{ typeof( Cubemap ), typeof( bool ) }, null ) );
			}
			__SetCubemapStreamingMipmaps_0_2( cubemapRef, streaming );
		}
		
		public static void SetCubemapStreamingMipmapsPriority( Cubemap cubemapRef, int priority ) {
			if( __SetCubemapStreamingMipmapsPriority_0_2 == null ) {
				__SetCubemapStreamingMipmapsPriority_0_2 = (Action<Cubemap,int>) Delegate.CreateDelegate( typeof( Action<Cubemap,int> ), null, UnityTypes.UnityEditor_TextureUtil.GetMethod( "SetCubemapStreamingMipmapsPriority", R.StaticMembers, null, new Type[]{ typeof( Cubemap ), typeof( int ) }, null ) );
			}
			__SetCubemapStreamingMipmapsPriority_0_2( cubemapRef, priority );
		}
		
		
		
		static Func<Texture, int> __GetStorageMemorySize_0_1;
		static Func<Texture, long> __GetStorageMemorySizeLong_0_1;
		static Func<Texture, int> __GetRuntimeMemorySize_0_1;
		static Func<Texture, long> __GetRuntimeMemorySizeLong_0_1;
		static Func<Texture2D, bool> __IsNonPowerOfTwo_0_1;
		static Func<Texture, object> __GetUsageMode_0_1;
		static Func<TextureFormat, int> __GetBytesFromTextureFormat_0_1;
		static Func<int,TextureFormat, int> __GetRowBytesFromWidthAndFormat_0_2;
		static Func<TextureFormat, bool> __IsValidTextureFormat_0_1;
		static Func<TextureFormat, bool> __IsCompressedTextureFormat_0_1;
		static Func<TextureFormat, bool> __IsCompressedCrunchTextureFormat_0_1;
		static Func<Texture, TextureFormat> __GetTextureFormat_0_1;
		static Func<TextureFormat, bool> __IsAlphaOnlyTextureFormat_0_1;
		static Func<TextureFormat, bool> __HasAlphaTextureFormat_0_1;
		static Func<TextureFormat, string> __GetTextureFormatString_0_1;
		static Func<Texture, string> __GetTextureColorSpaceString_0_1;
		static Func<TextureFormat, TextureFormat> __ConvertToAlphaTextureFormat_0_1;
		static Func<RenderTextureFormat, bool> __IsDepthRTFormat_0_1;
		static Func<Texture, bool> __HasMipMap_0_1;
		static Func<Texture, int> __GetGPUWidth_0_1;
		static Func<Texture, int> __GetGPUHeight_0_1;
		static Func<Texture, int> __GetMipmapCount_0_1;
		static Func<Texture, bool> __GetLinearSampled_0_1;
		static Func<int> __GetDefaultCompressionQuality_0_0;
		static Func<Texture, Vector4> __GetTexelSizeVector_0_1;
		static Func<Cubemap,CubemapFace, Texture2D> __GetSourceTexture_0_2;
		static Action<Cubemap,CubemapFace,Texture2D> __SetSourceTexture_0_3;
		static Action<Texture2D,Cubemap,CubemapFace> __CopyTextureIntoCubemapFace_0_3;
		static Action<Cubemap,CubemapFace,Texture2D> __CopyCubemapFaceIntoTexture_0_3;
		static Func<Cubemap,int,int,TextureFormat,bool,bool, bool> __ReformatCubemap_0_6;
		delegate bool Method_ReformatTexture_0_6(  ref Texture2D texture, int width, int height, TextureFormat textureFormat, bool useMipmap, bool linear  );
		static Method_ReformatTexture_0_6 __ReformatTexture_0_6;
		static Action<Texture,int> __SetAnisoLevelNoDirty_0_2;
		static Action<Texture,TextureWrapMode,TextureWrapMode,TextureWrapMode> __SetWrapModeNoDirty_0_4;
		static Action<Texture,float> __SetMipMapBiasNoDirty_0_2;
		static Action<Texture,FilterMode> __SetFilterModeNoDirty_0_2;
		static Func<string, bool> __DoesTextureStillNeedToBeCompressed_0_1;
		static Func<Cubemap, bool> __IsCubemapReadable_0_1;
		static Action<Cubemap,bool> __MarkCubemapReadable_0_2;
		static Func<Texture2D, bool> __GetTexture2DStreamingMipmaps_0_1;
		static Func<Texture2D, int> __GetTexture2DStreamingMipmapsPriority_0_1;
		static Func<Cubemap, bool> __GetCubemapStreamingMipmaps_0_1;
		static Func<Cubemap, int> __GetCubemapStreamingMipmapsPriority_0_1;
		static Action<Texture2D,bool> __SetTexture2DStreamingMipmaps_0_2;
		static Action<Texture2D,int> __SetTexture2DStreamingMipmapsPriority_0_2;
		static Action<Cubemap,bool> __SetCubemapStreamingMipmaps_0_2;
		static Action<Cubemap,int> __SetCubemapStreamingMipmapsPriority_0_2;
	}
}

