using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cube : MonoBehaviour
{
    public int c;

    public float Speed = 10f;
  
    public GameObject CUBE;

    public GameObject Sphere;

    public Text x;

    public GameObject Cam;
    public GameObject BasicCam;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * 5*Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * 5 * Speed * Time.deltaTime);
        }
        if (c <= 0)
        {
            Cam.SetActive(true);
            BasicCam.SetActive(false);
            this.gameObject.SetActive(false);
            x.text = "Игра Окончена";
        }
        else x.text = c.ToString();
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

    private void OnCollisionEnter( Collision collision)
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.red;
        c--;
    }

    private void OnCollisionExit(Collision collision)
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.white;
    }

    public void heal()
    {
        c = 6;
    }
    /*private void OnMouseDown()
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.cyan;
    }

    private void OnMouseUp() {
        this.gameObject.GetComponent<Renderer>().material.color = Color.white;
    }                            

    private void OnMouseEnter()
    {
        Sphere.gameObject.GetComponent<Renderer>().material.color = Color.red;
    }*/
}
