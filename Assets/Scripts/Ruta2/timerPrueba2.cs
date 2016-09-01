using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timerPrueba2 : MonoBehaviour {

	private Text timerText;
	private System.TimeSpan gameTime;
	private Game2 juego;

	// Use this for initialization
	void Start () {

		juego = FindObjectOfType<Game2>();
		timerText = GameObject.Find ("TiempoPrueba").GetComponent<Text> ();
		gameTime = System.TimeSpan.FromMinutes (2);


	}

	// Update is called once per frame
	void Update () {

		System.TimeSpan time = gameTime - System.TimeSpan.FromSeconds (Time.timeSinceLevelLoad);

		if (time > System.TimeSpan.FromSeconds(0)) {
			timerText.text =
				(time.Hours).ToString ("00")
				+ ":"
				+ (time.Minutes).ToString ("00")
				+ ":"
				+ (time.Seconds).ToString ("00");
		} else {
			juego.reset ();
		}
	}
}
