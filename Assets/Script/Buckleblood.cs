using UnityEngine;
using System.Collections;

public class Buckleblood : MonoBehaviour {
	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.tag == "player") {

				RestartController.lifepoint -= 1;
			
			Destroy(gameObject);
		}
	}
	void Start () {
	
	}
	

	void Update () {
	
	}
}
