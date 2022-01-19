using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.Threading;


public class QuaTrai : MonoBehaviour
{

    public float dichuyen = 3f;
     public AudioSource aSdie;
    // Start is called before the first frame update
    void Start()
    {
       aSdie = GetComponent<AudioSource>();
    }
    void Update()
    {
        transform.Translate(-Time.deltaTime * dichuyen, 0, 0);

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "GioiHanTrai")
        {
            dichuyen = -3f;
          
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (other.gameObject.tag == "GioiHanPhai")
        {
            dichuyen = 3f;
           
            transform.localScale = new Vector3(1, 1, 1);
        }
        // else if(other.gameObject.tag =="Player"){
        //      aSdie.Play();
        //      Debug.Log("Quai Vat Giet Player"); 
        //     //  Destroy(GameObject.Find("Player"));
        //     SceneManager.LoadScene("Scenes/DieScene");
             
        // }
        
    }
   
}
