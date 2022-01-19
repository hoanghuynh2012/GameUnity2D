using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class listUser : MonoBehaviour
{
    public GameObject n_row;
    string url = "http://localhost/list/lab3.php";
    void Start()
    {
        Receive_data();
    }

    public void Receive_data()
    {

        StartCoroutine(connect());

    }

    IEnumerator connect()
    {
        WWWForm form = new WWWForm();
        WWW w = new WWW(url);
        yield return w;
        //w tra ve day
        string ketqua = w.text;

        string[] listUser = new string[] { };

        listUser = ketqua.Split(',');
        //
        for (int i = 0; i < listUser.Length - 1; i++)
        {
            string list = listUser[i];
            string[] data = new string[] { };
            data = list.Split('-');
            GameObject dulieu = (GameObject)Instantiate(n_row);
            dulieu.transform.SetParent(this.transform); //
            dulieu.transform.Find("ID").GetComponent<Text>().text = data[0];
            dulieu.transform.Find("Name").GetComponent<Text>().text = data[1];
            dulieu.transform.Find("Scoce").GetComponent<Text>().text = data[2];
            dulieu.transform.Find("Level").GetComponent<Text>().text = data[3];
        }


    }

}
