using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

	public new Text guiText;
	private System.TimeSpan time;
	private TimerDelay timeDelay;
	private GameObject timer;

	// Use this for initialization

	void Awake(){

		timer = GameObject.Find("Canvas");

	}

	void Start () {

		timeDelay = FindObjectOfType<TimerDelay> ();
		
	}
	
	// Update is called once per frame
	void Update () {

		System.TimeSpan time = System.TimeSpan.FromSeconds (Time.realtimeSinceStartup-PlayerPrefs.GetFloat("Tiempo"));
		guiText.text =
			(time.Hours).ToString ("00")
			+ ":"
			+ (time.Minutes).ToString ("00")
			+ ":"
			+ (time.Seconds).ToString ("00");

	}
}
