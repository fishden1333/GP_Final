using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour {

	public Text scoreText;
	private float time;
	public float score;

	// Use this for initialization
	void Start () {
		time = 0;
	}

	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		score = Mathf.Round(time);
		if (score < 20)
		{
			scoreText.text = "Score: " + "<color=#FF8080FF>" + score.ToString() + "</color>";
		}
		else
		{
			scoreText.text = "Score: " + "<color=#80FF80FF>" + score.ToString() + "</color>";
		}


	}
}
