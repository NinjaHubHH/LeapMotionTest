using UnityEngine;
using System.Collections;

public class AufgabenManager : MonoBehaviour {

    public GameObject Cube;
    public Color Farbe;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void changeMaterial()
    {
        Cube.GetComponent<Renderer>().material.color = Farbe;
    }

  
}
