using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterHealth : MonoBehaviour {

	public float bottom;
	private bool isDead;
	private int levelNum;
	public ShowScore sc;

	// Use this for initialization
	void Start () {
		isDead = false;
		bottom = -7;
		levelNum = 1;
		sc = GetComponent<ShowScore>();
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
			if (sc != null)
			{
				if (sc.score >= 20)
				{
					Debug.Log(sc.score);
					StartCoroutine("GameOver");
				}

				else
				{
					StartCoroutine("GameOver");
				}
				
			}
			else
			{
				StartCoroutine("GameOver");
			}
		}
  }

	void OnTriggerEnter2D(Collider2D coll)
	{
		if (coll.gameObject.tag == "Items")
		{
			StartCoroutine("NextLevel");
		}
	}

	IEnumerator GameOver()
	{
		yield return new WaitForSeconds(0.1f);
		SceneManager.LoadSceneAsync("GameOver");
	}

	IEnumerator NextLevel()
	{
		yield return new WaitForSeconds(1);
		levelNum = levelNum + 1;
		SceneManager.LoadSceneAsync("Level" + levelNum);
	}

	IEnumerator Win()
	{
		yield return new WaitForSeconds(0.1f);
		SceneManager.LoadSceneAsync("Win");
	}
}
