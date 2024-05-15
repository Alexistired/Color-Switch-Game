using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private SpriteRenderer rend;
	private Animator anim;

	public Color[] colors;

	public string playerColor;


	private void Start()
	{
		anim = GetComponent<Animator>();
		rend = GetComponent<SpriteRenderer>();
	}

	void Update()
    {
        if(Input.GetKeyDown(KeyCode.I)){ 
			anim.SetTrigger("change");
            rend.color = colors[0];
			playerColor = "r";
        }

		if (Input.GetKeyDown(KeyCode.O))
		{
			anim.SetTrigger("change");
			rend.color = colors[1];
			playerColor = "g";
		}

		if (Input.GetKeyDown(KeyCode.P))
		{
			anim.SetTrigger("change");
			rend.color = colors[2];
			playerColor = "b";
		}
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log("col");

		if (other.GetComponent<Enemy>().enemyColor == playerColor){
			other.GetComponent<Enemy>().Destruction();
		
		
		}
		else
		{
			other.GetComponent<Enemy>().Restart();
			Destroy(gameObject);
		}
	}
}
