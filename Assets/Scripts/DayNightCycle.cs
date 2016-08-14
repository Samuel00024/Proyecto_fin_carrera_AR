using UnityEngine;
using System.Collections;

public class DayNightCycle : MonoBehaviour {

	public float speed =10f;

	void Update () {

		transform.Rotate(Vector3.left,speed*Time.deltaTime);

	}
}