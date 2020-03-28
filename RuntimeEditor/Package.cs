
using UnityEditor;

namespace Hananoki.SharedModule {
  public static class Package {
    public const string name = "SharedModule";
    public const string editorPrefName = "Hananoki.SharedModule";
    public const string version = "1.0.1";
  }
  
  [EditorLocalizeClass]
  public class LocalizeEvent {
    [EditorLocalizeMethod]
    public static void Changed() {
      foreach( var filename in DirectoryUtils.GetFiles( AssetDatabase.GUIDToAssetPath( "95cedfc7731853946b0b3650f175d73a" ), "*.csv" ) ) {
        if( filename.Contains( EditorLocalize.GetLocalizeName() ) ) {
          EditorLocalize.Load( Package.name, AssetDatabase.AssetPathToGUID( filename ), "2ca67e52d0e4c5a439729c95e8bf5e45" );
        }
      }
    }
  }
}
