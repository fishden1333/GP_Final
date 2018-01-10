using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAction : MonoBehaviour {

	public float enemySpeed;
	public float enemySpeedAdd;
	public int xDir;
    public float enemystage;
	private Animator anim;

	void Awake()
	{
		anim = GetComponent<Animator> ();
	}
	// Use this for initialization
	void Start () {
        if(enemystage==2)
            anim.SetFloat("Speed", 1);

    }

	// Update is called once per frame
	void Update () {
		enemySpeed = enemySpeed + enemySpeedAdd;
	}

	void FixedUpdate()
	{
        if(enemystage==0)
		    anim.SetFloat("Speed", Mathf.Abs(enemySpeed));
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(xDir, 0) * enemySpeed;
    }

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "VerticalWall" && enemystage==0)
		{
			Flip();
		}
        if (coll.gameObject.tag == "enemy")
        {
            Destroy(gameObject);
            CameraSystem.score += 500;
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
