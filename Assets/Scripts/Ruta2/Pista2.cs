using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pista2 : MonoBehaviour {

	private Image imagen;
	private Text texto;

	public Sprite[] sp;
	public Sprite sp1;
	public Sprite sp2;
	public Sprite sp3;
	public Sprite sp4;
	private int index;
	private System.TimeSpan timer;
	private System.TimeSpan deltaTime;

	private string place="Tu siguiente destino es:\n\nLA PLAZA DE LA CONSTITUCIÓN";
	private int secondForNextImg = 3;

	// Use this for initialization
	void Start () {

		index = 0;

		sp = new Sprite[4];
		sp [0] = sp1;
		sp [1] = sp2;
		sp [2] = sp3;
		sp [3] = sp4;

		imagen = GameObject.Find ("PistaImagen").GetComponent<Image>();
		timer = System.TimeSpan.FromSeconds (Time.time);
		texto = GameObject.Find ("PistaText").GetComponent<Text>();

		loadNextImg ();
	
	}

	private void loadNextImg(){
		imagen.sprite = sp[index];
		index++;
	}
	
	// Update is called once per frame
	void Update () {

		if (index < 4) {

			deltaTime = deltaTime + System.TimeSpan.FromSeconds (Time.deltaTime);

			if (timer + System.TimeSpan.FromSeconds (secondForNextImg) <= timer + deltaTime) {

				timer = System.TimeSpan.FromSeconds (Time.time);
				deltaTime = System.TimeSpan.FromSeconds (0);
				loadNextImg ();

			}


		} else if (index < 5) {

			deltaTime = deltaTime + System.TimeSpan.FromSeconds (Time.deltaTime);

			if (timer + System.TimeSpan.FromSeconds (secondForNextImg) <= timer + deltaTime) {
				
				index++;
				imagen.transform.localScale = new Vector3 (0, 0, 0);
				texto.text = place;

			}
		}
	
	}
}
