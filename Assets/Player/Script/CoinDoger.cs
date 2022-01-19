using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinDoger : MonoBehaviour
{
    private bool daan = false;
   
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (daan)
        {
            transform.Translate(0, 10 * Time.deltaTime, 0);
            
        }
      
    }
    private void OnTriggerEnter2D(Collider2D cl)
    {
        if (cl.gameObject.tag == "Player")
        { 
            Destroy(gameObject, 0.2f);
            daan = true;
        
        }
    }
}
