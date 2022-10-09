using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerBehavior : MonoBehaviour
{

public GameObject bullet;
public float bulletSpeed = 100f;

public bool Strelba= false;


	void Update()
	{
 	


	if (Input.GetMouseButtonDown(0) &&  Strelba )
	{
	// 3
		
		
		GameObject newBullet = Instantiate(bullet,
			this.transform.position + new Vector3(1, 0, 0),
			this.transform.rotation) as GameObject;
		// 4
		
		Rigidbody bulletRB = newBullet.GetComponent<Rigidbody>();
		// 5
		bulletRB.velocity = this.transform.forward * bulletSpeed;
		

	}
	if(transform.position.y<-17){
			Debug.Log("TYT");
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
			
		}
}
}
