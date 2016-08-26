using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Marcador : MonoBehaviour {

	private int puntos;
	private Text marcador;

	// Use this for initialization
	void Start () {
	
		marcador = GameObject.Find ("GUIScore").GetComponent<Text>();
		puntos = 0;

	}

	public int getPuntos(){

		return puntos;

	}

	public void addPuntos(int cantidad){

		puntos = puntos + cantidad;

	}

	void Update(){

		//marcador.text = puntos.ToString () + " puntos";
		marcador.text=PlayerPrefs.GetInt("Puntos") +" puntos";

	}
}
