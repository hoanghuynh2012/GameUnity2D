using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
using System.Threading;


public class playerController : MonoBehaviour
{
    private Animator player;

    public float speed = 10f;
    public float jump = 30f;
    private bool dangtrenmatdat;
    private bool chuachet = true;
    private bool daan = false;
    public int score;
    public int heart = 3;
    public GameObject btnRestart;
    public AudioSource aScoin;
    public Text txtScoce;
    public Text txtHeart;
    public Text error;
    public Rigidbody2D rb;
    void Start()
    {
        player = GetComponent<Animator>();
        txtScoce = GameObject.Find("txtScoce").GetComponent<Text>();
        txtHeart = GameObject.Find("txtHeart").GetComponent<Text>();
        error = GameObject.Find("error").GetComponent<Text>();
        aScoin = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
        txtHeart.text = heart.ToString();
    }
    void Update()
    {
        // Debug.Log("heart: " + heart + "coin: " + score);

        if (heart > 3)
        {
            txtHeart.text = "3";
        }



        if (daan)
        {

        }
        if (chuachet)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {

                player.SetBool("Walking", true);
                player.SetBool("Idle", false);
                gameObject.transform.Translate(Vector3.right * speed * Time.deltaTime);
                if (gameObject.transform.localScale.x < 0)
                {
                    gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x * -1, gameObject.transform.localScale.y, gameObject.transform.localScale.z);
                }
            }
            else
          if (Input.GetKey(KeyCode.LeftArrow))
            {

                player.SetBool("Walking", true);
                player.SetBool("Idle", false);
                gameObject.transform.Translate(Vector3.left * speed * Time.deltaTime);
                if (gameObject.transform.localScale.x > 0)
                {
                    gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x * -1, gameObject.transform.localScale.y, gameObject.transform.localScale.z);
                }
            }
            else if (Input.GetKey(KeyCode.Space))
            {
                if (dangtrenmatdat)
                {
                    player.SetBool("Jumping", true);
                    player.SetBool("Idle", false);
                    gameObject.GetComponent<Rigidbody2D>().velocity =
                    new Vector2(gameObject.GetComponent<Rigidbody2D>().velocity.x, jump);
                    dangtrenmatdat = false;
                }

            }
            else
            {
                player.SetBool("Walking", false);
                player.SetBool("Idle", true);
                player.SetBool("Jumping", false);
            }
        }
        else
        {

        }

    }
    private void OnCollisionEnter2D(Collision2D cl)
    {
        if (cl.gameObject.tag == "Map")
        {
            dangtrenmatdat = true;
        }
        if (cl.gameObject.tag == "Die")
        {

            player.SetBool("Idle", false);
            player.SetBool("Die", true);
            chuachet = false;
            btnRestart.SetActive(true);
        }
    }
    void OnTriggerEnter2D(Collider2D cl)
    {
        if (cl.gameObject.tag == "Coin")
        {
            score += 1;
            txtScoce.text = "X" + score.ToString();
            Destroy(cl.gameObject, 0.2f);
            aScoin.Play();
        }
        if (cl.gameObject.tag == "BenCanh")
        {
            heart -= 1;
            txtHeart.text = heart.ToString();
            if (heart == 0)
            {
                Debug.Log("I Die");
                player.SetBool("Idle", false);
                player.SetBool("Walking", false);
                player.SetBool("Jumping", false);
                player.SetBool("Die", true);
                rb.velocity = Vector2.zero;
                rb.bodyType = RigidbodyType2D.Kinematic;
                //    Destroy(GameObject.Find("Player"));
                //    SceneManager.LoadScene("Scenes/DieScene");
                btnRestart.SetActive(true);
                chuachet = false;
                GetComponent<Collider2D>().enabled = false;
            }


        }
        if (cl.gameObject.tag == "Top")
        {
            Debug.Log("An Diem");
            Destroy(GameObject.Find("QuaiVat"));
        }
        if (cl.gameObject.tag == "Top1")
        {
            Debug.Log("An Diem");
            Destroy(GameObject.Find("QuaiVat1"));
        }
        if (cl.gameObject.tag == "Top2")
        {
            Debug.Log("An Diem");
            Destroy(GameObject.Find("QuaiVat2"));
        }
        if (cl.gameObject.tag == "Top3")
        {
            Debug.Log("An Diem");
            Destroy(GameObject.Find("QuaiVat3"));
        }

    }
    public void buyHeart()

    {
        if (score > 5)
        {
            score -= 5;
            heart += 1;
            txtScoce.text = "X" + score.ToString();
            txtHeart.text = heart.ToString();
        }


    }
}
