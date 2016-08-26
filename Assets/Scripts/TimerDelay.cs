using UnityEngine;
using System.Collections;

public class TimerDelay : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		PlayerPrefs.SetFloat ("Tiempo", Time.realtimeSinceStartup);

	}
}
