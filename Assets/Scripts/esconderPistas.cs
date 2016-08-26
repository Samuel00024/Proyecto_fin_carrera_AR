using UnityEngine;
using System.Collections;

public class esconderPistas : MonoBehaviour {

	//private GameObject textBackground;
	//private GameObject text;
	private GameObject canv;

	// Use this for initialization
	void Start () {

		//textBackground = GameObject.Find ("PistaTextBackground");
		//text = GameObject.Find ("PistaText");
		canv = GameObject.Find ("Pistas");

		Show (true);
	
	}

	public void Show(bool shown){

		canv.SetActive (shown);
		//text.SetActive (shown);
		//textBackground.SetActive (shown);
	}
}
