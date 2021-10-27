using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class EndGame : MonoBehaviour
{
	public InputField exitCode;
	UnityEvent gameOver;
	UnityEvent winGame;

	public void endGame(string exitCode) {
		exitCode = this.exitCode.ToString();
		if (exitCode.ToString().Equals(51003)){
			gameOver.Invoke();
		} else {
			winGame.Invoke();
		}
	}
}
