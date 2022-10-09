using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open : MonoBehaviour
{
	public int  Max;
	private int  Ygl;
	private bool brake;
	public bool inversiua;
	public bool Otrivaem;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Vector3 newDirection= Vector3.RotateTowards( transform.forward,  Otrkitie, 1f * Time.deltaTime, 0f);
        if(Otrivaem)
    		Fn();

    }
    void Fn()
    {
    	if(!brake)
	        {
	        	Ygl++;

	        	if (inversiua==true){
	        		transform.rotation = Quaternion.Euler(0, -Ygl, 0);
	        	}
	        	 else {
	        		transform.rotation = Quaternion.Euler(0, Ygl, 0);
	        	}
	        }
	        if ( Max == Ygl )
	        	{
	       		 brake= true;
	        	}
	    
    }
}
