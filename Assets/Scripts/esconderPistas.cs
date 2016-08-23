using UnityEngine;
using System.Collections;

public class esconderPistas : MonoBehaviour {

	private GameObject textBackground;
	private GameObject text;

	// Use this for initialization
	void Start () {

		textBackground = GameObject.Find ("PistaTextBackground");
		text = GameObject.Find ("PistaText");

		Show (true);
	
	}

	public void Show(bool shown){

		text.SetActive (shown);
		textBackground.SetActive (shown);
	}
}
