using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game2 : MonoBehaviour {

	// Use this for initialization

	private Renderer rend;
	private List<RaycastHit> piezas;
	private List<GameObject> puzzle;
	private List<Vector3> posiciones;
	private bool fin;
	private bool puntos;

	public int numero_piezas_ancho;
	public int numero_piezas_alto;

	void Start () {

		piezas = new List<RaycastHit> ();
		puzzle = new List<GameObject> ();
		posiciones = new List<Vector3> ();

		fin = false;
	
		for (int i = 0; i < numero_piezas_alto; i++) {

			for (int j = 0; j < numero_piezas_ancho; j++) {

				puzzle.Add ((GameObject)GameObject.Find(i.ToString()+j.ToString()));
				posiciones.Add (puzzle [puzzle.Count - 1].transform.localPosition);

				//posiciones.Add (new Vector3 (j * 100, i * 100, 0));

				//puzzle [puzzle.Count - 1].transform.localPosition = posiciones [posiciones.Count - 1];


			}

		}

		mezclaPiezas ();


	}

	private void mezclaPiezas(){

		foreach (GameObject pieza in puzzle) {

			int r = Random.Range (0, posiciones.Count);
			pieza.transform.localPosition = posiciones [r];
			posiciones.RemoveAt (r);


		}

	}
	
	// Update is called once per frame
	void Update () {

		if (!fin) {

			if (Input.GetMouseButtonDown (0)) {
				//rend.material.color = Color.yellow;
				RaycastHit hitInfo = new RaycastHit ();
				bool hit = Physics.Raycast (Camera.main.ScreenPointToRay (Input.mousePosition), out hitInfo);

				if (hit) {

					piezas.Add (hitInfo);
					//new Rect (new Vector2 (0, 0), new Vector2 (100, 100));
					rend = hitInfo.collider.GetComponent<Renderer> ();
					rend.material.color = Color.red;
					
				}

				else {
					piezas.Clear ();
					rend.material.color = Color.white;
				}

				if (piezas.Count == 2) {

					Vector3 aux = piezas [0].transform.localPosition;
					piezas [0].transform.localPosition = piezas [1].transform.localPosition;
					piezas [1].transform.localPosition = aux;

					rend = piezas [0].collider.GetComponent<Renderer> ();
					rend.material.color = Color.white;
					rend = piezas [1].collider.GetComponent<Renderer> ();
					rend.material.color = Color.white;

					piezas.Clear ();

				}

			}

			//COMPROBAR POSICION DE TODAS LAS PIEZAS

			puntos = true;

			foreach (GameObject obj in puzzle) {

				if (puntos) {
				
					int x = Mathf.FloorToInt ((float)char.GetNumericValue (obj.transform.gameObject.name [1]));
					int y = Mathf.FloorToInt ((float)char.GetNumericValue (obj.transform.gameObject.name [0]));

					if (!(x * 100 == Mathf.FloorToInt (obj.transform.localPosition.x)) ||
					   !(y * 100 == Mathf.FloorToInt (obj.transform.localPosition.y))) {

						puntos = false;

					}
				}

			}

			if (puntos) {

				fin = true;
				PlayerPrefs.SetInt ("Puntos", PlayerPrefs.GetInt ("Puntos") + 10);

			}

		}
	}

	public void reset(){

		SceneManager.LoadScene ("Level0");

	}

}

