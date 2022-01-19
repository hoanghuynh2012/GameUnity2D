using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 10f;
    public float jump = 20f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.Translate(Vector3.right * speed * Time.deltaTime);
            if (gameObject.transform.localScale.x < 0)
            {
                gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x * -1, gameObject.transform.localScale.y, gameObject.transform.localScale.z);
            }
        }
        else
               if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.Translate(Vector3.left * speed * Time.deltaTime);
            if (gameObject.transform.localScale.x > 0)
            {
                gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x * -1, gameObject.transform.localScale.y, gameObject.transform.localScale.z);
            }
        }
        else if (Input.GetKey(KeyCode.Space))
        {


            gameObject.GetComponent<Rigidbody2D>().velocity =
            new Vector2(gameObject.GetComponent<Rigidbody2D>().velocity.x, jump);



        }
    }

    void OnTriggerEnter2D(Collider2D cl)
    {
        if (cl.gameObject.tag == "Vat")
        {
            Debug.Log("Your Die");
            Destroy(GameObject.Find("Player"));
        }
    }
}
