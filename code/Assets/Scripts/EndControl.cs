using UnityEngine;
using System.Collections;

public class EndControl : MonoBehaviour
{
    //场景结束后的控制，分别为再来一次，退出与其他
    public void Again()
    {
        GameManager.currentScene = 0;
        Application.LoadLevel("LoadScene");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Blog()
    {
        Application.OpenURL("http://www.ereebay.me");
    }
}
