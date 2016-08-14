using UnityEngine;
using System.Collections;

public class GUI_base : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){

		GUI.backgroundColor = Color.yellow;
		GUI.color = Color.yellow;
		GUI.Box (new Rect (10, 10, 170, 170), "Realidad Aumentada");

	}
}
