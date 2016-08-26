using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour {

	private string[] preguntas;
	private string[,] respuestas;
	private Button[] errores;
	private Button acierto;
	private Text pregunta;
	private Text r1;
	private Text r2;
	private Text r3;
	private Text r4;
	private Text timerText;
	private System.TimeSpan gameTime;
	private int idPregunta;
	private List<Vector3> posiciones;
	private Marcador marcador;
	private bool started;


	// Use this for initialization
	void Start () {

		started = false;

		marcador = FindObjectOfType<Marcador>();

		posiciones = new List<Vector3>();

		//Cantidad de preguntas y respuestas (x preguntas y x,4 respuestas).
		preguntas = new string[7];
		respuestas = new string[7,4];

		prepararPreguntas ();

		pregunta = GameObject.Find ("Pregunta").GetComponent<Text> ();
	
		errores = new Button[3];
		errores [0] = GameObject.Find ("Respuesta2").GetComponent<Button> ();
		errores[1] = GameObject.Find ("Respuesta3").GetComponent<Button> ();
		errores[2] = GameObject.Find ("Respuesta4").GetComponent<Button> ();
		acierto = GameObject.Find ("Respuesta1").GetComponent<Button> ();

		posiciones.Add(errores[0].transform.position);
		posiciones.Add(errores[1].transform.position);
		posiciones.Add(errores[2].transform.position);
		posiciones.Add(acierto.transform.position);

		idPregunta = 0;

		acierto.onClick.AddListener (delegate {
			aciertoClick (acierto);
		});
		errores [0].onClick.AddListener (delegate {
			errorClick ();
		});
		errores [1].onClick.AddListener (delegate {
			errorClick ();
		});
		errores [2].onClick.AddListener (delegate {
			errorClick ();
		});

		mostrarPregunta ();


	}

	public void startTimer(){

		if (!started) {

			started = true;
			timerText = GameObject.Find ("TiempoPrueba").GetComponent<Text> ();
			gameTime = System.TimeSpan.FromMinutes (2);

		}

	}

	private void prepararPreguntas(){

		preguntas [0] = "¿Qué cantidad de puertas hay en la fachada principal?";
		//respuestas incorrectas
		respuestas [0,0] = "5";
		respuestas [0,1] = "1";
		respuestas [0,2] = "2";
		//respuesta correcta
		respuestas [0,3] = "3";

		preguntas [1] = "¿Qué estilo arquitectónico presenta la Catedral en la actualidad?";
		//respuestas incorrectas
		respuestas [1,0] = "Barroco";
		respuestas [1,1] = "Árabe";
		respuestas [1,2] = "Gótico";
		//respuesta correcta
		respuestas [1,3] = "Renacentista";

		preguntas [2] = "¿Cuántas torres tiene la Catedral?";
		//respuestas incorrectas
		respuestas [2,0] = "1";
		respuestas [2,1] = "5";
		respuestas [2,2] = "4";
		//respuesta correcta
		respuestas [2,3] = "2";

		preguntas [3] = "¿Cuántas columnas hay en la fachada de la catedral?";
		//respuestas incorrectas
		respuestas [3,0] = "10";
		respuestas [3,1] = "6";
		respuestas [3,2] = "4";
		//respuesta correcta
		respuestas [3,3] = "8";

		preguntas [4] = "En la parte superior de la fachada de la Catedral, ¿Cuántas esculturas se pueden encontrar?";
		//respuestas incorrectas
		respuestas [4,0] = "11";
		respuestas [4,1] = "8";
		respuestas [4,2] = "10";
		//respuesta correcta
		respuestas [4,3] = "9";

		preguntas [5] = "En la fachada de la Catedral, ¿A qué rey representa la escultura central?";
		//respuestas incorrectas
		respuestas [5,0] = "Felipe II";
		respuestas [5,1] = "Carlos I";
		respuestas [5,2] = "Luis I";
		//respuesta correcta
		respuestas [5,3] = "Fernando III";

		preguntas [6] = "¿Cuáles de estos objetos no porta la escultura de Fernando III?";
		//respuestas incorrectas
		respuestas [6,0] = "Una bola";
		respuestas [6,1] = "Una espada";
		respuestas [6,2] = "Una corona";
		//respuesta correcta
		respuestas [6,3] = "Un libro";

	}

	private void mostrarPregunta(){

		if (idPregunta < preguntas.Length) {

			pregunta.text = "Bienvenido a la Catedral de Jaén\n\n"+preguntas [idPregunta];

			errores [0].GetComponentInChildren<Text> ().text = respuestas [idPregunta, 0];
			errores [1].GetComponentInChildren<Text> ().text = respuestas [idPregunta, 1];
			errores [2].GetComponentInChildren<Text> ().text = respuestas [idPregunta, 2];
			acierto.GetComponentInChildren<Text> ().text = respuestas [idPregunta, 3];

			mezclar ();
		} else {
			
			idPregunta = -1;
			//marcador.addPuntos (10);
			PlayerPrefs.SetInt("Puntos",10);

			loadNextLevel ();
			//cargar siguiente nivel

		}


	}

	private void mezclar(){

		int r;

		r = Random.Range (0, posiciones.Count);
		errores [0].transform.position = posiciones [r];
		posiciones.RemoveAt (r);

		r = Random.Range (0, posiciones.Count);
		errores [1].transform.position = posiciones [r];
		posiciones.RemoveAt (r);

		r = Random.Range (0, posiciones.Count);
		errores [2].transform.position = posiciones [r];
		posiciones.RemoveAt (r);

		acierto.transform.position = posiciones [0];
		posiciones.RemoveAt (0);

		posiciones.Add(errores[0].transform.position);
		posiciones.Add(errores[1].transform.position);
		posiciones.Add(errores[2].transform.position);
		posiciones.Add(acierto.transform.position);
	}

	private void errorClick(){

		if (idPregunta != -1) {
			
			Debug.Log ("Error");
			idPregunta = 0;
			mostrarPregunta ();

		}

	}

	private void aciertoClick(Button button){

		if (idPregunta != -1) {
			
			Debug.Log ("Acierto");
			idPregunta++;
			mostrarPregunta ();
		}
	}

	public void loadNextLevel(){

		//Application.UnloadLevel ("Level1");
		//Application.LoadLevel ("Level2");
		//SceneManager.UnloadScene ("Level1");
		SceneManager.LoadScene ("Level2");
	}

	// Update is called once per frame
	void Update () {

		gameTime = gameTime - System.TimeSpan.FromSeconds (Time.deltaTime);

		if (gameTime > System.TimeSpan.FromSeconds(0)) {
			timerText.text=
				(gameTime.Minutes).ToString ("00")
				+ ":"
				+ (gameTime.Seconds).ToString ("00");
		} else {
			loadNextLevel ();
		}
	}
	

}
