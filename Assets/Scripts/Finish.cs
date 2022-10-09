using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{

	private Camera MC;
	private Camera C;

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.name == "Player")
        {
    	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    	MC= GameObject.Find("Main Camera").GetComponent<Camera>();
    	C= GameObject.Find("Camera").GetComponent<Camera>();
        }
    	//MC.enabled= !MC.enabled;
    	//C.enabled= !C.enabled;
    }
    
}
