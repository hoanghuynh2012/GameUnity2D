using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newVat : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject hinhdang;
    public GameObject viTri;
    void Start()
    {
        StartCoroutine(connect());
    }

    IEnumerator connect()
    {
        yield return new WaitForSeconds(2);

        //
        Vector3 temp = viTri.transform.position;

        temp.y = Random.Range(-5f, 4f);
        //
        Instantiate(hinhdang, temp, Quaternion.identity);
        StartCoroutine(connect());
    }

    // Update is called once per frame
    void Update()
    {

    }
}
