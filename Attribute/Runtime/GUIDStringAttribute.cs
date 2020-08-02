
using UnityEngine;
using System;

namespace Hananoki {
	public class GUIDStringAttribute : PropertyAttribute {
		public Type m_type;
		public GUIDStringAttribute( Type t ) {
			m_type = t;
		}
	}
}

