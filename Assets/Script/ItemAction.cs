using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemAction : MonoBehaviour {

	private float yPos;

	// Use this for initialization
	void Start () {
		yPos = gameObject.transform.position.y;
	}

	// Update is called once per frame
	void FixedUpdate () {
		//StartCoroutine("Movement");
	}

	IEnumerator Movement()
	{
		yPos += 0.1f;
		gameObject.transform.position = new Vector2(gameObject.transform.position.x, yPos);
		yield return new WaitForSeconds(1);
		yPos -= 0.1f;
		gameObject.transform.position = new Vector2(gameObject.transform.position.x, yPos);
	}
}
