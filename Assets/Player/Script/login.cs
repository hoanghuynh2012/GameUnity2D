using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class login : MonoBehaviour
{
    // Start is called before the first frame update
    public InputField USERNAME;
    public InputField PASSWORD;
    string php_login = "http://localhost/login/login.php";
    public void loginUser()
    {
        StartCoroutine(connect());
    }
    IEnumerator connect()
    {
        WWWForm form = new WWWForm();
        form.AddField("NAMEUSER", USERNAME.text);
        form.AddField("PASSWORDUSER", PASSWORD.text);
        WWW w = new WWW(php_login, form);
        yield return w;

        string kq = w.text;
        if (kq == "true")
        {
            print("Dang Nhap Thanh Cong");
        }
        else
        {
            print("Dang Nhap Khong Thanh Cong");
        }
    }

}
