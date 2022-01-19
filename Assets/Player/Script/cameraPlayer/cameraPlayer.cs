using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraPlayer : MonoBehaviour
{
    private Transform player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {

        if (player != null)
        {
            Vector3 pos = transform.position;
            pos.x = player.position.x;
            transform.position = pos;
        }
    }
}
