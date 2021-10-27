using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

namespace UnityEngine.XR.ARSubsystems {

	public class MainGameSystem : MonoBehaviour {
		[SerializeField] public List<XRReferenceImage> imageLib;
		public bool beenSeen;
		int count = 0;
		GameObject openUI;
		GameObject gameover;
		public float timer, interval = 2f;
		private int x = 0;

		public void Start() {

			foreach (XRReferenceImage xr in imageLib) {
				x++;
			}
		}

		public void Update() {
			timer += Time.deltaTime;
			if (timer >= interval) {
				for (int interval = 0; interval < 15; interval++) {
					Invoke("CallTriggered", 15.0f);
				}
			}
		}
		public void CallTriggered() {
			Button btn;
			if (openUI.activeSelf) {

			}

		}
		//creating the image library so we can check if the images have been seen
		public void AddImages() {
			count = 0;
			while (count < x) {
				count++;
			}
			if (count == x) {
				openUI.SetActive(true);
			}
		}
	}
}