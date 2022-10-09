using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Sfera;
    private bool Selected;

    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Ray ray= Camera.main.ScreenPointToRay(Input.mousePosition);
       // Debug.DrawRay(transform.position, transform.forward*100f, Color.yellow);
        
        if (MatOdinHod(ray, "Tyra_l", "Kletka", "Partiua" ))
            Okteviryem();

        if (MatOdinHod(ray, "Tyra_l", "Kletka_l", "Partiua (1)" ))
            Destroy(GameObject.Find("Doska"));

        if ( MatOdinHod(ray, "Tyra_l", "Kletka_ll", "Partiua (2)" ))
            Destroy(GameObject.Find("Doska (1)"));

    }

    bool MatOdinHod(Ray ray, string sFigyra, string Kletka, string destroy)
    {
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit)){
            //Sfera.position= hit.point;
            if (hit.collider.gameObject.name==sFigyra && Input.GetMouseButtonDown(0))
            {   
                if ( Selected == false)
                {
                    Vector3 dv= (hit.collider.gameObject.GetComponent<Transform>().position- Camera.main.GetComponent<Transform>().position)/2;
                    hit.collider.gameObject.GetComponent<Transform>().position= hit.collider.gameObject.GetComponent<Transform>().position-dv;
                    Selected= true;
                    Debug.Log( sFigyra );
                }
            }
            if (hit.collider.gameObject.name== Kletka && Input.GetMouseButtonDown(0) && Selected )
            {
                Debug.Log( "destroy" );
                Selected= false;
                Destroy(GameObject.Find(destroy));
                return true;

            }
            
        } 
        return false;
    }
    void Okteviryem()
    {
        GameObject.Find("Pivot").GetComponent<Open>().Otrivaem= true;
        GameObject.Find("Pivot_l").GetComponent<Open>().Otrivaem= true;
        GameObject.Find("Shape017").GetComponent<Door>().Zakritie= true;
    }

}
