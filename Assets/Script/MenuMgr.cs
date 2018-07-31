using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMgr : MonoBehaviour {
    public GameObject playMenu;
    public GameObject geometriMenu;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OpenPlayMenu()
    {
        playMenu.SetActive(true);
        geometriMenu.SetActive(false);
    }

    public void OpenGeometriMenu()
    {
        playMenu.SetActive(false);
        geometriMenu.SetActive(true);
    }

	public void Quit()
	{
		Application.Quit ();
	}

	public void StartScan()
	{
		playMenu.SetActive(false);
		geometriMenu.SetActive(false);
	}
}
