using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAction : MonoBehaviour {

	public float enemySpeed;
	private int xDir;
	private Animator anim;

	void Awake()
	{
		anim = GetComponent<Animator> ();
	}
	// Use this for initialization
	void Start () {
		xDir = -1;
	}

	// Update is called once per frame
	void Update () {
		gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(xDir, 0) * enemySpeed;
		/*
		RaycastHit2D hit = Physics2D.Raycast(transform.position, new Vector2(xDir, 0));

		if (hit.distance < 1.0f)
		{
			Flip();
		}*/
	}

	void FixedUpdate()
	{
		anim.SetFloat("Speed", Mathf.Abs(enemySpeed));
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "VerticalWall")
		{
			Flip();
		}
  }

	void Flip()
	{
		xDir = (xDir > 0) ? -1 : 1;
		Vector3 characterScale = transform.localScale;
		characterScale.x *= -1;
		transform.localScale = characterScale;
	}
}
