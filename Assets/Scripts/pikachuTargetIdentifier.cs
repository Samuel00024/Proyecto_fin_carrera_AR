using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Vuforia;
	
public class pikachuTargetIdentifier : MonoBehaviour, ITrackableEventHandler{

	private TrackableBehaviour mTrackableBehaviour;

	private Text texto;

	// Use this for initialization
	void Start () {

		texto = GameObject.Find ("targetText").GetComponent<Text>();

		mTrackableBehaviour = GetComponent<TrackableBehaviour> ();
		if (mTrackableBehaviour) {

			mTrackableBehaviour.RegisterTrackableEventHandler (this);

		}
	
	}

	public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus){

		if (newStatus == TrackableBehaviour.Status.DETECTED ||
		    newStatus == TrackableBehaviour.Status.TRACKED ||
		    newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED) {

			texto.text = "O";

		} else {

			texto.text = "X";
		}

	}
}