using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

	public Text guiText;
	public Camera cam;
	public GameObject background;
	//private System.TimeSpan timeTemp = new System.TimeSpan(0,59,56);

	// Use this for initialization
	void Start () {

		guiText.color = Color.yellow;
		//guiText.transform.localPosition = new Vector2 (-(cam.pixelWidth/2), (cam.pixelHeight/2));
		
	}
	
	// Update is called once per frame
	void Update () {

		System.TimeSpan time = System.TimeSpan.FromSeconds (Time.timeSinceLevelLoad);
		//time = time+timeTemp;
		guiText.text =
			(time.Hours).ToString ("00")
			+ ":"
			+ (time.Minutes).ToString ("00")
			+ ":"
			+ (time.Seconds).ToString ("00");

	}
}
