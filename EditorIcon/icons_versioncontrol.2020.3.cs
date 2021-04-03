#if UNITY_2020_3

using UnityEngine;
using UnityEditor;
using System;

namespace HananokiEditor {
	public static partial class EditorIcon {
		public static Texture2D file                              => Icon.GetOrLoadFromBuiltin( "icons/versioncontrol/file.png" );
		public static Texture2D file_2x                           => Icon.GetOrLoadFromBuiltin( "icons/versioncontrol/file@2x.png" );
		public static Texture2D incoming_icon                     => Icon.GetOrLoadFromBuiltin( "icons/versioncontrol/incoming icon.png" );
		public static Texture2D incoming_icon_2x                  => Icon.GetOrLoadFromBuiltin( "icons/versioncontrol/incoming icon@2x.png" );
		public static Texture2D outgoing_icon_2x                  => Icon.GetOrLoadFromBuiltin( "icons/versioncontrol/outgoing icon@2x.png" );
		public static Texture2D p4_addedlocal                     => Icon.GetOrLoadFromBuiltin( "icons/versioncontrol/p4_addedlocal.png" );
		public static Texture2D p4_addedlocal_2x                  => Icon.GetOrLoadFromBuiltin( "icons/versioncontrol/p4_addedlocal@2x.png" );
		public static Texture2D p4_addedremote                    => Icon.GetOrLoadFromBuiltin( "icons/versioncontrol/p4_addedremote.png" );
		public static Texture2D p4_addedremote_2x                 => Icon.GetOrLoadFromBuiltin( "icons/versioncontrol/p4_addedremote@2x.png" );
		public static Texture2D p4_blueleftparenthesis            => Icon.GetOrLoadFromBuiltin( "icons/versioncontrol/p4_blueleftparenthesis.png" );
		public static Texture2D p4_blueleftparenthesis_2x         => Icon.GetOrLoadFromBuiltin( "icons/versioncontrol/p4_blueleftparenthesis@2x.png" );
		public static Texture2D p4_bluerightparenthesis           => Icon.GetOrLoadFromBuiltin( "icons/versioncontrol/p4_bluerightparenthesis.png" );
		public static Texture2D p4_bluerightparenthesis_2x        => Icon.GetOrLoadFromBuiltin( "icons/versioncontrol/p4_bluerightparenthesis@2x.png" );
		public static Texture2D p4_checkoutlocal                  => Icon.GetOrLoadFromBuiltin( "icons/versioncontrol/p4_checkoutlocal.png" );
		public static Texture2D p4_checkoutlocal_2x               => Icon.GetOrLoadFromBuiltin( "icons/versioncontrol/p4_checkoutlocal@2x.png" );
		public static Texture2D p4_checkoutremote                 => Icon.GetOrLoadFromBuiltin( "icons/versioncontrol/p4_checkoutremote.png" );
		public static Texture2D p4_checkoutremote_2x              => Icon.GetOrLoadFromBuiltin( "icons/versioncontrol/p4_checkoutremote@2x.png" );
		public static Texture2D p4_conflicted                     => Icon.GetOrLoadFromBuiltin( "icons/versioncontrol/p4_conflicted.png" );
		public static Texture2D p4_conflicted_2x                  => Icon.GetOrLoadFromBuiltin( "icons/versioncontrol/p4_conflicted@2x.png" );
		public static Texture2D p4_deletedlocal                   => Icon.GetOrLoadFromBuiltin( "icons/versioncontrol/p4_deletedlocal.png" );
		public static Texture2D p4_deletedlocal_2x                => Icon.GetOrLoadFromBuiltin( "icons/versioncontrol/p4_deletedlocal@2x.png" );
		public static Texture2D p4_deletedremote                  => Icon.GetOrLoadFromBuiltin( "icons/versioncontrol/p4_deletedremote.png" );
		public static Texture2D p4_deletedremote_2x               => Icon.GetOrLoadFromBuiltin( "icons/versioncontrol/p4_deletedremote@2x.png" );
		public static Texture2D p4_local                          => Icon.GetOrLoadFromBuiltin( "icons/versioncontrol/p4_local.png" );
		public static Texture2D p4_local_2x                       => Icon.GetOrLoadFromBuiltin( "icons/versioncontrol/p4_local@2x.png" );
		public static Texture2D p4_lockedlocal                    => Icon.GetOrLoadFromBuiltin( "icons/versioncontrol/p4_lockedlocal.png" );
		public static Texture2D p4_lockedlocal_2x                 => Icon.GetOrLoadFromBuiltin( "icons/versioncontrol/p4_lockedlocal@2x.png" );
		public static Texture2D p4_lockedremote                   => Icon.GetOrLoadFromBuiltin( "icons/versioncontrol/p4_lockedremote.png" );
		public static Texture2D p4_lockedremote_2x                => Icon.GetOrLoadFromBuiltin( "icons/versioncontrol/p4_lockedremote@2x.png" );
		public static Texture2D p4_offline                        => Icon.GetOrLoadFromBuiltin( "icons/versioncontrol/p4_offline.png" );
		public static Texture2D p4_offline_2x                     => Icon.GetOrLoadFromBuiltin( "icons/versioncontrol/p4_offline@2x.png" );
		public static Texture2D p4_outofsync                      => Icon.GetOrLoadFromBuiltin( "icons/versioncontrol/p4_outofsync.png" );
		public static Texture2D p4_outofsync_2x                   => Icon.GetOrLoadFromBuiltin( "icons/versioncontrol/p4_outofsync@2x.png" );
		public static Texture2D p4_redleftparenthesis             => Icon.GetOrLoadFromBuiltin( "icons/versioncontrol/p4_redleftparenthesis.png" );
		public static Texture2D p4_redleftparenthesis_2x          => Icon.GetOrLoadFromBuiltin( "icons/versioncontrol/p4_redleftparenthesis@2x.png" );
		public static Texture2D p4_redrightparenthesis            => Icon.GetOrLoadFromBuiltin( "icons/versioncontrol/p4_redrightparenthesis.png" );
		public static Texture2D p4_redrightparenthesis_2x         => Icon.GetOrLoadFromBuiltin( "icons/versioncontrol/p4_redrightparenthesis@2x.png" );
		public static Texture2D p4_updating                       => Icon.GetOrLoadFromBuiltin( "icons/versioncontrol/p4_updating.png" );
		public static Texture2D p4_updating_2x                    => Icon.GetOrLoadFromBuiltin( "icons/versioncontrol/p4_updating@2x.png" );
	}
}

#endif // UNITY_2020_3