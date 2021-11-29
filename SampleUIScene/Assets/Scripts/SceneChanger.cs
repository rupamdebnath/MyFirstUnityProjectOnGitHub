using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{

    public void OnClick1()
    {
        SceneManager.LoadScene("Scene1");
    }

    public void OnClick2()
    {
        SceneManager.LoadScene("Scene2");
    }

    public void OnClick3()
    {
        SceneManager.LoadScene("Scene3");
    }

    public void OnClickBack()
    {
        SceneManager.LoadScene("MasterScene");
    }
}
