using UnityEngine;
using System.Collections;

public class FloorMove : MonoBehaviour {
	static public Vector3 speed;
	static public float speedup = 0.15f;

	private float floorTimer = 0;
	void Start () {
	
	}
	

	void Update () {

		if (speedup <= 0.05) {
			speedup += Time.deltaTime / 100000;
			speed = new Vector3 (0, 0.01f+speedup, 0);


		}
		transform.position += speed;

	}

	void OnCollisionStay2D(Collision2D collision){
		if (collision.gameObject.name == "Furry" && gameObject.name == "floor2(Clone)")
			collision.gameObject.transform.Translate (0.01f, 0, 0);
		else if (collision.gameObject.name == "Furry" && gameObject.name == "floor3(Clone)")
			collision.gameObject.transform.Translate (0, 0.5f, 0);
		else if (collision.gameObject.name == "Furry" && gameObject.name == "floor4(Clone)") {
			floorTimer += Time.deltaTime;
			if(floorTimer>0.4f){
				Destroy(gameObject);
				floorTimer = 0;
			}
		}
	}
}
