using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slideVat : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * 10f *Time.deltaTime);
    }

void OnTriggerEnter2D(Collider2D cl){
    if(cl.gameObject.tag == "Player"){
             Debug.Log("Your Die"); 
             Destroy(GameObject.Find("Player"));
    }
}
}
