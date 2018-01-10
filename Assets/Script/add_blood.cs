using UnityEngine;
using System.Collections;

public class add_blood : MonoBehaviour {
	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.tag == "player") {
			if(RestartController.lifepoint < 5){
			RestartController.lifepoint += 1;
			}
			Destroy(gameObject);
		}
	}

	void Start () {
	
	}
	

	void Update () {
	
	}
}
