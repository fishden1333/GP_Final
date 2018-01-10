using UnityEngine;
using System.Collections;

public class Character2DControl : MonoBehaviour
{
	private Character2D character;
	private bool jump;
	private float movingSpeed;
    public float charstage;

	// Use this for initialization
	void Start ()
	{
		character = GetComponent<Character2D> ();
	}

	// Update is called once per frame
	void Update ()
	{
		//get jump input by "jump" button set in input setting
		if (Input.GetButtonDown("Jump")) jump = true;
	}

	void FixedUpdate()
	{
        movingSpeed = Input.GetAxis("Horizontal");
        if (charstage == 0)
				{
					character.Move(movingSpeed, jump);
        }
        else
        {
            character.Move(0, jump);
        }

        //jump is reset after each time that physical engine updated
        jump = false;
	}
}
