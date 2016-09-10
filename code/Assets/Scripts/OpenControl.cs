using UnityEngine;
using System.Collections;

public class OpenControl : MonoBehaviour
{
    //游戏开始
    public void StartGame()
    {
        GameManager.currentScene = GameManager.currentScene + 1;
        Application.LoadLevel("LoadScene");
    }
}
