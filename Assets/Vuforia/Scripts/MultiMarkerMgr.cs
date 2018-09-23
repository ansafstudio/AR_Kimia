using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiMarkerMgr : MonoBehaviour {

	public GameObject[] atoms;

	public GameObject BeCl2;
	public GameObject BF3;
	public GameObject H20;
	public GameObject NH3;

	/*
	public AudioSource H;
	public AudioSource O;
	public AudioSource N;
	public AudioSource Cl;
	public AudioSource Be;
	public AudioSource B; 
	public AudioSource NH3;
	public AudioSource BeCl2;
	public AudioSource BF3;
	public AudioSource H2O;
*/

	//public LineGenerator lineGen;

	public GameObject line;
	LineRenderer activatedLine;
	GameObject objLine;

	// Use this for initialization
	void Start () {
		//lineGen.pointA = atoms [0].transform.position;
		//lineGen.pointB = atoms [1].transform.position;
		//lineGen.InstantiateSegments();
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

		if (DefaultTrackableEventHandler.H && DefaultTrackableEventHandler.H2 && DefaultTrackableEventHandler.O) {
			H20.SetActive (true);
			for (int i = 0; i < atoms.Length; i++) {
				atoms [i].SetActive (false);
			}
		} else {
			H20.SetActive (false);
		}

		//if ((DefaultTrackableEventHandler.H || DefaultTrackableEventHandler.H2 || DefaultTrackableEventHandler.H3)
		//	&& (DefaultTrackableEventHandler.H || DefaultTrackableEventHandler.H2 || DefaultTrackableEventHandler.H3)
		//	&& DefaultTrackableEventHandler.O
		//) {
		//	H20.SetActive (true);
		//	for (int i = 0; i < atoms.Length; i++) {
		//		atoms [i].SetActive (false);
		//	}
		//} else {
		//	H20.SetActive (false);
		//}

		if (DefaultTrackableEventHandler.H	&& DefaultTrackableEventHandler.H2 && DefaultTrackableEventHandler.H3 && DefaultTrackableEventHandler.N
		) {
			NH3.SetActive (true);
			for (int i = 0; i < atoms.Length; i++) {
				atoms [i].SetActive (false);
			}
		} else {
			NH3.SetActive (false);
		}

		if (!BeCl2.activeSelf &&
			!BF3.activeSelf &&
			!H20.activeSelf &&
			!NH3.activeSelf
		) 
		{
			for (int i = 0; i < atoms.Length; i++) 
			{
				atoms [i].SetActive (true);
				/*
				if (atoms[0].activeSelf && atoms[1].activeSelf) 
				{
					if (!activatedLine) 
					{
						objLine = Instantiate (line, Vector3.zero, Quaternion.identity);
						activatedLine = objLine.GetComponent<LineRenderer> ();	
					}
					LineGenerate (atoms [0].transform.position, atoms [1].transform.position);
				} else {
					Destroy (objLine);
				}
				*/
			}
		

			//LineGenerator lineGen2 = new LineGenerator();
		} 
		/*else 
		{
				
			for (int i = 0; i < atoms.Length; i++) {
				atoms [i].SetActive (false);
			}
		} */

	}

	void LineGenerate(Vector3 pos1, Vector3 pos2)
	{
		
		//GameObject a = Instantiate (line, Vector3.zero, Quaternion.identity);

		activatedLine.SetPosition (0, pos1);
		activatedLine.SetPosition (1, pos2);

	}
}
