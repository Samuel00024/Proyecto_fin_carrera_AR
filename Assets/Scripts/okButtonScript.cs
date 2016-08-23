using UnityEngine;
using System.Collections;

public class okButtonScript : MonoBehaviour {

	private GameObject textBackground;
	private GameObject text;
	private GameObject button;

	private esconderPistas scriptPistas;

	// Use this for initialization
	void Start () {

		textBackground = GameObject.Find ("PistaTextBackground");
		text = GameObject.Find ("PistaText");
		button = GameObject.Find ("okButton");

		scriptPistas = FindObjectOfType<esconderPistas>();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ClickBehaviour(){

		scriptPistas.Show (false);
		button.SetActive (false);

	}
}
