using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
	private GameObject player;
	private bool Chek=false;

	void FixedUpdate(){
		if (Chek){
			player= GameObject.Find("Player");
			transform.position= Vector3.MoveTowards( transform.position, 
				player.transform.position, 1.5f*Time.deltaTime );

		}
	}
	// 1
	void OnTriggerEnter(Collider other)
	{
	//2
		if(other.name == "Player")
		{
			Debug.Log("Attack!");
			Chek= true;
		}
		}
	// 3
	void OnTriggerExit(Collider other)
	{
	// 4
		if(other.name == "Player")
		{
			Debug.Log("Out of range");
		}
	}
	void OnCollisionEnter(Collision collision)
	{
	// 2
		Debug.Log("OnCollisionEnter");
		if(collision.gameObject.name == "Bullet(Clone)")
		{
		// 3
			Destroy(this.gameObject);
			// 4
			Debug.Log("Popadanie!");
		}
	}
}
