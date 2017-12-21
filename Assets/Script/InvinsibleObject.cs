using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvinsibleObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if(gameObject.GetComponent<Renderer>() != null)
    {
      gameObject.GetComponent<Renderer>().enabled = false;
    }
	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter2D(Collision2D coll)
	{
    if (coll.gameObject.tag == "Player")
		{
			gameObject.GetComponent<Renderer>().enabled = true;
		}
  }
}
