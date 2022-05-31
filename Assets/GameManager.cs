using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int coinCount;
    public Text textComponent;
    private string color;
    private string r = "<color=#ff0000>";
    private string b = "<color=#0000ff>";
    private string g = "<color=#00ff00>";

    public void SceneReset()
    {
        string activeSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(activeSceneName);
    }
    public void ChangeScene(string nextScene)
    {
        SceneManager.LoadScene(nextScene);
    }
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        Screen.SetResolution(1920, 1080, false);
        coinCount = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddCoinCount()
    {
        coinCount++;
        if (coinCount % 3 == 0)
        {
            color = r;
        }
        else if (coinCount % 3 == 1)
        {
            color = g;
        }
        else
        {
            color = b;
        }
        Debug.Log("coinCount:" + coinCount);
        textComponent.text = "<color=#ff0000>C</color><color=#00ff00>o</color><color=#0000ff>i</color><color=#000000>n</color><color=#ffffff>C</color><color=#ffff00>o</color><color=#00ffff>u</color><color=#ff00ff>n</color><color=#000000>t</color> <color=#0fffb0>:</color>" + color + coinCount + "</color>";
    }
}
