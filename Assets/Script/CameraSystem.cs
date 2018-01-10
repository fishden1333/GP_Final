using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSystem : MonoBehaviour {

	private GameObject player;
    public float camstage;
	public float xMin;
	public float xMax;
	public float yMin;
	public float yMax;
    static public int score = 0;

    // Use this for initialization
    void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
        score = 0;
    }
    void Update()
    {
    }

        // Update is called once per frame
        void LateUpdate () {
        if (camstage == 0)
        {
            float x = Mathf.Clamp(player.transform.position.x, xMin, xMax);
            float y = Mathf.Clamp(player.transform.position.y, yMin, yMax);
            gameObject.transform.position = new Vector3(x, y, gameObject.transform.position.z);
        }
	}
}
