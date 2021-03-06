﻿using UnityEngine;

namespace SaguFramework {

	/// Represents an image in the game.
	/// As only one SpriteRenderer can be attached to an object, and since entities can have multiple images, objects of
	/// this class are meant to be entity's children.
	/// Images can be animated by setting an animator controller.
	public sealed class Image : MonoBehaviour {

		private Animator animator; // The animator
		private new SpriteRenderer renderer; // The renderer

		public void Awake() {
			// Adds an Animator
			animator = gameObject.AddComponent<Animator>();

			// Adds a SpriteRenderer
			renderer = gameObject.AddComponent<SpriteRenderer>();
		}

		/// Returns the animator.
		/// The animator allows to trigger animations defined through the animator controller.
		public Animator GetAnimator() {
			return animator;
		}

		/// Returns the size in world space.
		public Vector2 GetSize() {
			// Gets the sprite
			Sprite sprite = renderer.sprite;

			// Uses the object's scale and the sprite's size in world space to calculate the width and the height
			float width = transform.localScale.x * sprite.bounds.size.x;
			float height = transform.localScale.y * sprite.bounds.size.y;
			
			return new Vector2(width, height);
		}
		
		/// Returns the texture.
		public Texture2D GetTexture() {
			return renderer.sprite.texture;
		}

		/// Sets a controller for the image animator.
		public void SetAnimatorController(RuntimeAnimatorController animatorController) {
			animator.runtimeAnimatorController = animatorController;
		}

		/// Sets the opacity.
		public void SetOpacity(float opacity) {
			renderer.color = Utilities.GetColor(renderer.color, opacity);
		}
		
		/// Sets the size.
		/// Receives the size in world space.
		public void SetSize(Vector2 size) {
			// Gets the sprite
			Sprite sprite = renderer.sprite;

			// Uses the sprite's size in world space and the expected resulting size to calculate the object's scale
			float scaleX = size.x / sprite.bounds.size.x;
			float scaleY = size.y / sprite.bounds.size.y;

			// Sets the object's scale
			transform.localScale = new Vector3(scaleX, scaleY, transform.localScale.z);
		}
		
		/// Sets the sorting layer.
		/// The sorting layer determines which images are rendered first.
		public void SetSortingLayer(string sortingLayer) {
			renderer.sortingLayerName = sortingLayer;
		}

		/// Sets the sorting order.
		/// The sorting order determines which images of the same sorting layer are rendered first.
		public void SetSortingOrder(int sortingOrder) {
			renderer.sortingOrder = sortingOrder;
		}

		/// Sets the sprite.
		public void SetSprite(Sprite sprite) {
			renderer.sprite = sprite;
		}

	}
	
}
