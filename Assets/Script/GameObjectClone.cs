using UnityEngine;
using System.Collections;

public class GameObjectClone : MonoBehaviour {
	public GameObject [] enemy = new GameObject[5];////(1)
	private GameObject Clone;
    private float time=0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        CameraSystem.score += (int)(Time.deltaTime*50);
        int i = Random.Range(2, 6);
        if ((int)(time)==i)
		{
			

        
	
			Vector3 pos = new Vector3(10.0f, -2.5f, 0f);
			Quaternion rot = new Quaternion(0, 0, 0, 0);
			Clone = (GameObject)Instantiate(enemy[0], pos, rot);
            
			Clone.AddComponent<FloorMove>();
            time -= i;
			
		}
	}
}

