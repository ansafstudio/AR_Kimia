using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiMarkerMgr : MonoBehaviour {

	public GameObject[] atoms;

	public GameObject BeCl2;
	public GameObject BF3;
	public GameObject H20;
	public GameObject NH3;

	public LineGenerator lineGen;

	// Use this for initialization
	void Start () {
		lineGen.pointA = atoms [0].transform.position;
		lineGen.pointB = atoms [1].transform.position;
		lineGen.InstantiateSegments();
	}
	
	// Update is called once per frame
	void Update () {

		if (DefaultTrackableEventHandler.Be && DefaultTrackableEventHandler.Cl && DefaultTrackableEventHandler.Cl2) {
			BeCl2.SetActive (true);
			for (int i = 0; i < atoms.Length; i++) {
				atoms [i].SetActive (false);
			}
		} else {
			BeCl2.SetActive (false);
		}

		if (DefaultTrackableEventHandler.B && DefaultTrackableEventHandler.F && DefaultTrackableEventHandler.F2 && DefaultTrackableEventHandler.F3) {
			BF3.SetActive (true);
			for (int i = 0; i < atoms.Length; i++) {
				atoms [i].SetActive (false);
			}
		} else {
			BF3.SetActive (false);
		}

		if ((DefaultTrackableEventHandler.H || DefaultTrackableEventHandler.H2 || DefaultTrackableEventHandler.H3)
			&& (DefaultTrackableEventHandler.H || DefaultTrackableEventHandler.H2 || DefaultTrackableEventHandler.H3)
			&& DefaultTrackableEventHandler.O
		) {
			H20.SetActive (true);
			for (int i = 0; i < atoms.Length; i++) {
				atoms [i].SetActive (false);
			}
		} else {
			H20.SetActive (false);
		}

		if ((DefaultTrackableEventHandler.H || DefaultTrackableEventHandler.H2 || DefaultTrackableEventHandler.H3)
			&& (DefaultTrackableEventHandler.H || DefaultTrackableEventHandler.H2 || DefaultTrackableEventHandler.H3)
			&& (DefaultTrackableEventHandler.H || DefaultTrackableEventHandler.H2 || DefaultTrackableEventHandler.H3)
			&& DefaultTrackableEventHandler.N
		) {
			NH3.SetActive (true);
		} else {
			NH3.SetActive (false);
		}

		if (!BeCl2.activeSelf &&
			!BF3.activeSelf &&
			!H20.activeSelf &&
			!NH3.activeSelf
		) {
			for (int i = 0; i < atoms.Length; i++) {
				atoms [i].SetActive (true);
			}


			//LineGenerator lineGen2 = new LineGenerator();


		}
		
	}
}
