﻿using UnityEngine;

namespace SaguFramework {
	
	public class Menu : MonoBehaviour {

		public void Awake() {
			Objects.RegisterMenu(this);
		}

		public virtual void Close() {
			DestroyImmediate(gameObject);
		}

		public void Hide() {
			gameObject.SetActive(false);
		}
		
		public void OnDestroy() {
			Objects.UnregisterMenu();
		}

		public void OnEnable() {
			Debug.Log("entre: " + GameCamera.GetInstance().GetPosition());
			SetPosition(GameCamera.GetInstance().GetPosition());
		}

		public void OnGUI() {
			GUILayout.BeginArea(Geometry.GetGameRectangleInGui());
			GetBehaviour().OnShowing();
			GUILayout.EndArea();
		}

		public void Show() {
			gameObject.SetActive(true);
		}
		
		private MenuBehaviour GetBehaviour() {
			return GetComponentInChildren<MenuBehaviour>();
		}
		
		private void SetPosition(Vector2 position) {
			transform.position = Utilities.GetPosition(position, transform.position.z);
		}
		
	}
	
}
