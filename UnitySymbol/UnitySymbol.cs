using System.Collections.Generic;
using System.Linq;
using UnityEditor;

namespace Hananoki {
	public static class UnitySymbol {
		static List<string> s_lst;

		public static bool Has( string symbol ) {
			if( s_lst == null ) s_lst = EditorUserBuildSettings.activeScriptCompilationDefines.Where( x => x.StartsWith( "UNITY_" ) ).ToList();
			return s_lst.Contains( symbol );
		}
		
		public static bool UNITY_5_3_OR_NEWER => Has( "UNITY_5_3_OR_NEWER" );
		public static bool UNITY_5_4_OR_NEWER => Has( "UNITY_5_4_OR_NEWER" );
		public static bool UNITY_5_5_OR_NEWER => Has( "UNITY_5_5_OR_NEWER" );
		public static bool UNITY_5_6_OR_NEWER => Has( "UNITY_5_6_OR_NEWER" );

		public static bool UNITY_2017_1_OR_NEWER => Has( "UNITY_2017_1_OR_NEWER" );
		public static bool UNITY_2017_2_OR_NEWER => Has( "UNITY_2017_2_OR_NEWER" );
		public static bool UNITY_2017_3_OR_NEWER => Has( "UNITY_2017_3_OR_NEWER" );
		public static bool UNITY_2017_4_OR_NEWER => Has( "UNITY_2017_4_OR_NEWER" );

		public static bool UNITY_2018_1_OR_NEWER => Has( "UNITY_2018_1_OR_NEWER" );
		public static bool UNITY_2018_2_OR_NEWER => Has( "UNITY_2018_2_OR_NEWER" );
		public static bool UNITY_2018_3_OR_NEWER => Has( "UNITY_2018_3_OR_NEWER" );
		public static bool UNITY_2018_4_OR_NEWER => Has( "UNITY_2018_4_OR_NEWER" );
		
		public static bool UNITY_2019_1_OR_NEWER => Has( "UNITY_2019_1_OR_NEWER" );
		public static bool UNITY_2019_2_OR_NEWER => Has( "UNITY_2019_2_OR_NEWER" );
		public static bool UNITY_2019_3_OR_NEWER => Has( "UNITY_2019_3_OR_NEWER" );
		public static bool UNITY_2019_4_OR_NEWER => Has( "UNITY_2019_4_OR_NEWER" );

		public static bool UNITY_2020_1_OR_NEWER => Has( "UNITY_2020_1_OR_NEWER" );

		/// <summary>
		/// ゲームコードから Unity エディターのスクリプトを呼び出すための #define ディレクティブ
		/// </summary>
		public static bool UNITY_EDITOR => Has( "UNITY_EDITOR" );

		/// <summary>
		/// Windows 版エディターコードのための #define ディレクティブ
		/// </summary>
		public static bool UNITY_EDITOR_WIN => Has( "UNITY_EDITOR_WIN" );

		/// <summary>
		/// Mac OS X 版エディターコードのための #define ディレクティブ
		/// </summary>
		public static bool UNITY_EDITOR_OSX => Has( "UNITY_EDITOR_OSX" );

		/// <summary>
		/// Mac OS X （Univeral、PPC、Intel のアーキテクチャを含む）のコードをコンパイル/実行するための #define ディレクティブ
		/// </summary>
		public static bool UNITY_STANDALONE_OSX => Has( "UNITY_STANDALONE_OSX" );

		/// <summary>
		/// Windows スタンドアロンアプリケーションのコードをコンパイル/実行するための #define ディレクティブ
		/// </summary>
		public static bool UNITY_STANDALONE_WIN => Has( "UNITY_STANDALONE_WIN" );

		/// <summary>
		/// Linux スタンドアロンアプリケーションのコードをコンパイル/実行するための #define ディレクティブ
		/// </summary>
		public static bool UNITY_STANDALONE_LINUX => Has( "UNITY_STANDALONE_LINUX" );

		/// <summary>
		/// あらゆるスタンドアロンプラットフォーム（Mac OS X, Windows, Linux）のコードをコンパイル/実行するための #define ディレクティブ
		/// </summary>
		public static bool UNITY_STANDALONE => Has( "UNITY_STANDALONE" );

		/// <summary>
		/// Wii コンソールのためのコードをコンパイル/実行するための #define ディレクティブ
		/// </summary>
		public static bool UNITY_WII => Has( "UNITY_WII" );

		/// <summary>
		/// iOS プラットフォームのためのコードをコンパイル/実行するための #define ディレクティブ
		/// </summary>
		public static bool UNITY_IOS => Has( "UNITY_IOS" );

		/// <summary>
		/// 非推奨。代わりに UNITY_IOS を使用してください。
		/// </summary>
		public static bool UNITY_IPHONE => Has( "UNITY_IPHONE" );

		/// <summary>
		/// Android プラットフォームのための #define ディレクティブ
		/// </summary>
		public static bool UNITY_ANDROID => Has( "UNITY_ANDROID" );

		/// <summary>
		/// PlayStation 4 のコードを実行するための #define ディレクティブ
		/// </summary>
		public static bool UNITY_PS4 => Has( "UNITY_PS4" );

		/// <summary>
		/// XBox One のコードを実行するための #define ディレクティブ
		/// </summary>
		public static bool UNITY_XBOXONE => Has( "UNITY_XBOXONE" );

		/// <summary>
		/// Tizen プラットフォームのための #define ディレクティブ
		/// </summary>
		public static bool UNITY_TIZEN => Has( "UNITY_TIZEN" );

		/// <summary>
		/// Apple TV プラットフォームのための #define ディレクティブ
		/// </summary>
		public static bool UNITY_TVOS => Has( "UNITY_TVOS" );

		/// <summary>
		/// ユニバーサル Windows プラットフォームのための #define ディレクティブ。さらに、C# ファイルを .NET Core 向けにコンパイルし .NET スクリプティングバックエンドを使用する場合に、NETFX_CORE が定義されます。
		/// </summary>
		public static bool UNITY_WSA => Has( "UNITY_WSA" );

		/// <summary>
		/// ユニバーサル Windows プラットフォームのための #define ディレクティブ。さらに、C# ファイルを .NET Core 向けにコンパイルする場合に、WINDOWS_UWP が定義されます。
		/// </summary>
		public static bool UNITY_WSA_10_0 => Has( "UNITY_WSA_10_0" );

		/// <summary>
		/// UNITY_WSA と同様
		/// </summary>
		public static bool UNITY_WINRT => Has( "UNITY_WINRT" );

		/// <summary>
		/// UNITY_WSA_10_0 に相当
		/// </summary>
		public static bool UNITY_WINRT_10_0 => Has( "UNITY_WINRT_10_0" );

		/// <summary>
		/// WebGL のための #define ディレクティブ
		/// </summary>
		public static bool UNITY_WEBGL => Has( "UNITY_WEBGL" );

		/// <summary>
		/// Facebook プラットフォーム (WebGL か Windows スタンドアロン) のための #define ディレクティブ
		/// </summary>
		public static bool UNITY_FACEBOOK => Has( "UNITY_FACEBOOK" );

		/// <summary>
		/// ゲームコードから Unity Ads メソッドを呼び出すための #define ディレクティブ。Unity 5.2 以降で使用可能。
		/// </summary>
		public static bool UNITY_ADS => Has( "UNITY_ADS" );

		/// <summary>
		/// ゲームコードから Unity Analytics メソッドを呼び出すための #define ディレクティブ。Unity 5.2 以降で使用可能。
		/// </summary>
		public static bool UNITY_ANALYTICS => Has( "UNITY_ANALYTICS" );

		/// <summary>
		/// アサーション制御プロセスの #define ディレクティブ
		/// </summary>
		public static bool UNITY_ASSERTIONS => Has( "UNITY_ASSERTIONS" );
	}
}
