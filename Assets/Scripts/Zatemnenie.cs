using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zatemnenie : MonoBehaviour
{
    // Start is called before the first frame update
    public bool OdinRaz;
    private Material Mat;
    private float StartZn;
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    	//StartZn+= 0,
        if (OdinRaz== true)
        {
			Temnee();
        	//OdinRaz= false;

        }
    }
    void Temnee()
    {
    	StartZn+= Time.deltaTime;
    	GetComponent<Renderer>().material.SetFloat("_Metallic", StartZn);
    }
}
