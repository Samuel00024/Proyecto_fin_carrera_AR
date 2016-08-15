using UnityEngine;
using System.Collections;

public class GUI_base : MonoBehaviour {

	GUIStyle estilo = new GUIStyle();

	// Use this for initialization
	void Start () {

		estilo.fontSize = 60;
		//Input.location.Start ();
		//Input.compass.enabled = true;

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){


		//Debug.Log(Input.compass.trueHeading);

		GUI.backgroundColor = Color.yellow;
		GUI.color = Color.yellow;
		GUI.Box (new Rect (10, 10, 170, 170),"Texto GUI");

	}
}
