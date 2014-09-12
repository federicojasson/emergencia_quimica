﻿using UnityEngine;

namespace SaguFramework {
	
	public abstract class InteractiveBehaviour : MonoBehaviour {

		public virtual void OnCursorClick() {}

		public virtual void OnCursorEnter() {}

		public virtual void OnCursorExit() {}

	}
	
}