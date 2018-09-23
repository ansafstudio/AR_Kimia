using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class line : MonoBehaviour {
	public GameObject garis;
	LineRenderer garisaktif;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.A)) {
			garisan ();
		}
		if (garisaktif) {
			garisaktif.SetPosition (1, transform.position);
		}
	}

	void garisan (){
		GameObject a = Instantiate (garis, Vector3.zero, Quaternion.identity);
		a.GetComponent<LineRenderer> ().SetPosition (0, Vector3.zero);
		garisaktif = a.GetComponent<LineRenderer> ();
	}
}
