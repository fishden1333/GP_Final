using UnityEngine;
using System.Collections;

public class RestartController : MonoBehaviour {
	static public int lifepoint = 5;

	public TextMesh lifeText;////(1)
	public TextMesh timerText;
	private float timer = 0;
	public GameObject player;////(1)
	public TextMesh GameOverText;
	public bool timer1 = false;
	void Start () {
		timer1 = true;
        player.SetActive(true);
        player.transform.position = new Vector3(0, 2, -2.5f);
        lifepoint = 5;
        timer1 = true;
        timer = 0;
        FloorMove.speed = new Vector3(0, 0.03f, 0);
        FloorMove.speedup = 0;
    }
	

	void Update () {
		if (timer1) {
						timer += Time.deltaTime;/////(2)
				}
		lifeText.text = "生命:"+lifepoint.ToString();////(3)
		timerText.text = "時間:"+((int)timer).ToString();
		GameOverText.text = "";////(2)
		if (lifepoint <= 0 )////(3)
		{
			GameOverText.text = "遊戲結束\n按R重新開始\n或ESC離開遊戲";
			player.SetActive(false);
			timer1 = false;
            if (Input.GetKey (KeyCode.R)) 
			{
                Application.LoadLevel("Game");
			}

            if (Input.GetKey(KeyCode.Escape))
            {
                Application.Quit();
            }

        }

}

}
