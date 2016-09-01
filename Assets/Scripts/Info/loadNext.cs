using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class loadNext : MonoBehaviour {

	private GameObject canv;

	// Use this for initialization
	void Start () {

		canv = GameObject.Find ("Pistas");
		PlayerPrefs.SetInt ("Puntos", 0);
	
	}

	public void loadLevel(){

		canv.SetActive (false);
		//SceneManager.UnloadScene ("Level0");
		//SceneManager.LoadScene ("Level1");
		SceneManager.UnloadScene("Level0");
		SceneManager.LoadScene ("Escena_de_pruebas1_proyecto");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
