using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class info : MonoBehaviour {

	private string instrucciones="Instrucciones antes de empezar:\n\n" +
		"La ruta se divide en diferentes fases, cada una de las cuales consta de dos partes.\n\n" +
		"En la primera parte se muestra una pista del destino al que hay que llegar. Si no se descifra en un cierto tiempo, se mostrará el lugar al que dirigirse de forma directa.\n\n" +
		"Cuando se llegue al destino, hay que buscar el punto con el logo de la carrera y situarse sobre el mismo.\n\n" +
		"Una vez alcanzado el lugar, se debe apuntar con el dispositivo hacia un lugar en los alrededores de la zona para descubrir una prueba oculta que se debe superar.\n\n" +
		"Cuando resuelvas el ejercicio, obtendrás la pista para dirigirte al siguiente lugar. Además, si se supera el ejercicio, se obtendrá una cierta cantidad de puntos, pero si no se supera el ejercicio en un tiempo concreto, no se sumarán puntos al marcador y se mostrará la pista hacia el siguiente objetivo.\n\n" +
		"Ganará la partida quien acumule más puntos y realice el recorrido en el menor tiempo posible.";

	private Text texto;

	//private int i, j, k;

	// Use this for initialization
	void Start () {

		texto = GameObject.Find ("PistaText").GetComponent<Text>();

		texto.text = instrucciones;

		/*i = 0;
		j = -1;
		k = 0;*/


	}

	// Update is called once per frame
	/*void Update () {

		if(!texto.text.Equals(instrucciones)){

			j++;

			if (j >= 1) {

				if (instrucciones [i] == '\n' && k < 10) {

					k++;

				}
				else {

					insertOnText ();
					j = 0;
					k = 0;
				}
			}
		}

	}

	void insertOnText(){

		texto.text = texto.text + instrucciones [i];
		i++;

	}*/
}
