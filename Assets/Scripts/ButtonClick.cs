using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

namespace UnityEngine.XR.ARSubsystems {
	public class ButtonClick : MonoBehaviour {
		// Start is called before the first frame update
		Button keyButton;
		GameObject openUI;
		GameObject codeUI;
		private float timer = 0f;
		
		void Start() {
			Button btn = keyButton.GetComponent<Button>();
			btn.onClick.AddListener(TriggerCall);
			openUI.SetActive(false);
			codeUI.SetActive(false);

		}

		// Update is called once per frame
		void Update() {
		}

		public bool TriggerCall() {
			openUI.SetActive(true);
			return true;//Audio source component
		}

		public void TriggerGameEnd() {
			codeUI.SetActive(true);
        }
	}
}