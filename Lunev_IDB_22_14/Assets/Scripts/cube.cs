using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cube : MonoBehaviour
{
    public GameObject CUBE;




    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    public void Scene()
    { 
        if (CUBE.gameObject.activeSelf)
        {
            CUBE.gameObject.SetActive(false);
            
        }
        else
        {
            CUBE.gameObject.SetActive(true);
           
        }
            
    }

}
