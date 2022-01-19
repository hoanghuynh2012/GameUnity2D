using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class registration : MonoBehaviour
{
    public InputField  USERNAME;
    public InputField  PASSWORD;

    string php_addUser = "http://localhost/addUser/addUser.php";

    public void addData(){
        StartCoroutine(connect());
    }

    IEnumerator connect(){
        WWWForm form = new WWWForm();
        form.AddField("NAMEUSER",USERNAME.text);
        form.AddField("PASSWORDUSER",PASSWORD.text);


        WWW w = new WWW(php_addUser,form);
        yield return w;
        string kq = w.text;
        if(kq == "true"){
            print("Dang Ki Thanh Cong");
            SceneManager.LoadScene("List");
        } else {
             print("Dang Ki Khong Thanh Cong");
        }
    }

     public void gotoDangKi(){
         SceneManager.LoadScene("DEMO");
    }

}
