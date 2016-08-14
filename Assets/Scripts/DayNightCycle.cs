using UnityEngine;
using System.Collections;

public class DayNightCycle : MonoBehaviour {

	public float speed =10f;
	private float lBaseValue = 1f;
	private float lValue = 0f;
    

	void Update () {
		
		//lValue = lBaseValue*Mathf.Sin(Time.time);


		transform.Rotate(Vector3.left,speed*Time.deltaTime);
		print(this.transform.rotation.x);
		lValue = lBaseValue * Mathf.Sin (this.transform.rotation.x);
		this.GetComponent<Light> ().intensity = lValue;
	}
}