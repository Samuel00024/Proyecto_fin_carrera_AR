using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pista : MonoBehaviour {

	private string poema="          - Bernardo López García -\n\nLos años pasando van,\ny el templo su mole ostenta;\nlo que por Dios se sustenta\nlos años no lo hundirán.\n\nCorren y corren edades\njunto a la Iglesia grandiosa;\npor su cúpula ostentosa\nresbalan las tempestades,\n\nY eterna y firme levanta\nsu continente sereno;\nni la hace temblar el trueno,\nni la muerte la quebranta.\n\nY es porque la alta piedad\nlos frutos del bien aprueba;\ny lo que por Dios se eleva,\ntiene luz de eternidad.";
	private string place="Tu siguiente destino es:\n\nLA CATEDRAL DE JAÉN";

	//Tiempo de espera hasta que desaparezca la pista y aparezca el lugar al que dirigirse de forma directa
	//Para evitar que alguien no pueda realizar el circuito.
	//Penalización por tiempo.
	public double nextPlaceTimer;

	private Text texto;
	private esconderPistas scriptPistas;

	private int i, j, k;

	private System.TimeSpan endTime;

	// Use this for initialization
	void Start () {

		scriptPistas = FindObjectOfType<esconderPistas>();
		texto = GameObject.Find ("PistaText").GetComponent<Text>();
		endTime = System.TimeSpan.FromSeconds (Time.time) + System.TimeSpan.FromSeconds(nextPlaceTimer);

		texto.text = "";

		i = 0;
		j = -1;
		k = 0;

		scriptPistas.Show (true);
	
	}
	
	// Update is called once per frame
	void Update () {

		if (System.TimeSpan.FromSeconds (Time.time) >= endTime) {

			nextPlace ();

		}else if(!texto.text.Equals(poema)){

			j++;

			if (j >= 2) {

				if (poema [i] == '\n' && k < 20) {

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

		texto.text = texto.text + poema [i];
		i++;

	}

	void nextPlace(){

		texto.text = place;

	}

	void endButton(){

	}
}
