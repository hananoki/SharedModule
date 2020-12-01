using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Hananoki;
using System;

namespace Tests {
	public class NewTestScript {
		// A Test behaves as an ordinary method
		[Test]
		public void NewTestScriptSimplePasses() {
			// Use the Assert class to test conditions
			//try {
				var com = UnityEditorEditorUserBuildSettings.GetCompressionType( UnityEditor.BuildTargetGroup.Standalone );
			Debug.Log( com );
			//}
			//catch(Exception e) {
			//	Debug.Log( e );
			//	Assert.
			//}
		}

		// A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
		// `yield return null;` to skip a frame.
		//[UnityTest]
		//public IEnumerator NewTestScriptWithEnumeratorPasses() {
		//	// Use the Assert class to test conditions.
		//	// Use yield to skip a frame.
		//	yield return null;
		//}
	}
}
