using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

	public Text guiText;

	// Use this for initialization
	void Start () {

		guiText.color = Color.yellow;
		
	}
	
	// Update is called once per frame
	void Update () {

		System.TimeSpan time = System.TimeSpan.FromSeconds (Time.timeSinceLevelLoad);
		guiText.text =
			(time.Hours).ToString ("00")
			+ ":"
			+ (time.Minutes).ToString ("00")
			+ ":"
			+ (time.Seconds).ToString ("00");

	}
}
