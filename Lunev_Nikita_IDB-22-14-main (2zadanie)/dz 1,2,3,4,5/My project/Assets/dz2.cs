using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class dz2 : MonoBehaviour
{
   public TextMeshProUGUI schotchik;
   public int hp = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void FixedUpdate()
    {
     
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Ground")
        {
            if (hp == 0) {

                schotchik.text = "Хватит!";
            }
            else
            {
                schotchik.text = "Cчетчик:" + (--hp);
            }
            
        }
        
          
        
    }
}
