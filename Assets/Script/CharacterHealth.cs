using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterHealth : MonoBehaviour {

	public float bottom;
	private bool isDead;

	// Use this for initialization
	void Start () {
		isDead = false;
		bottom = -7;
	}

	// Update is called once per frame
	void Update () {
		if (gameObject.transform.position.y < bottom)
		{
			isDead = true;
		}
		if (isDead)
		{
			StartCoroutine("GameOver");
		}
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
    if (coll.gameObject.tag == "Enemies")
		{
			isDead = true;
			StartCoroutine("GameOver");
		}
  }

	void OnTriggerEnter2D(Collider2D coll)
	{
		if (coll.gameObject.tag == "Items")
		{
			StartCoroutine("Win");
		}
	}

	IEnumerator GameOver()
	{
		yield return new WaitForSeconds(0.1f);
		SceneManager.LoadSceneAsync("GameOver");
	}

	IEnumerator Win()
	{
		yield return new WaitForSeconds(1);
		SceneManager.LoadSceneAsync("GameOver");
	}
}
