using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public string Scenename;

    public void ChangeScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(Scenename);
        Time.timeScale = 1;
    }
}
