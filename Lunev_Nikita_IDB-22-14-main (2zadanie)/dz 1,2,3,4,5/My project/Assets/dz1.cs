using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dz1 : MonoBehaviour
{
     
    public GameObject sphere;
    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
         
    }
   public void  actsphere()
    {
        sphere.SetActive(!sphere.activeSelf);
    }
    public void actcube()
    {
        cube.SetActive(!cube.activeSelf);
    }

}
