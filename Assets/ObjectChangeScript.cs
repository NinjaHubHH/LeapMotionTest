using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class ObjectChangeScript : MonoBehaviour {

    public UnityEvent EventOnEnter;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.name.Equals("bone3") && other.transform.parent.name.Equals("index") && other.transform.parent.parent.Equals("RigidRoundHand_R"))
        {
            EventOnEnter.Invoke();
            Debug.Log("Triggered");
        }
    }
}
