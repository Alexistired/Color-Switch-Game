using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public float speed;

	public GameObject effect;
	public GameObject effectTwo;

	public string enemyColor;

	private Animator camAnim;

	private void Start()
	{
		camAnim = Camera.main.GetComponent<Animator>();
	}


	private void Update()
	{
		transform.Translate(Vector2.left * speed * Time.deltaTime);
	}

	public void Destruction(){ 
		camAnim.SetTrigger("shake");
		Instantiate(effect, transform.position, Quaternion.identity);
		Instantiate(effectTwo, transform.position, Quaternion.identity);
		Destroy(gameObject);
	}

	public void Restart(){
		camAnim.SetTrigger("shake");
		Instantiate(effectTwo, transform.position, Quaternion.identity);
		StartCoroutine(WaitBeforeRestart());
	}

	IEnumerator WaitBeforeRestart(){ 
		
		yield return new WaitForSeconds(1f);
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
}
