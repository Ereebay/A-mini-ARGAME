using UnityEngine;
using System.Collections;

public static class GameManager
{
    //场景信息以及场景对应提示
    public static int currentScene = 0;
    public static string[] tips = { "努力加载中", "开始游戏吧", "你找到一个拼盘", "信息已经发送到你的手机了", "恭喜你解开了密码", "恭喜你，游戏已经通关" };
    public static string[] scene = { "Open", "SceneOne", "SceneTwo", "SceneThree", "SceneFour", "SceneEnd" };

    //对目标跟踪丢失的响应
    public static void TrackLost(string information)
    {
        switch (currentScene)
        {
            case 0:
                break;
            case 1:
                if (information == "Table")
                {
                    currentScene = 2;
                    Application.LoadLevel("LoadScene");
                }
                break;
            case 2:
                if (information == "Computer")
                {
                    currentScene = 3;
                    Application.LoadLevel("LoadScene");
                }
                break;
            case 3:
                if (information == "Answer")
                {
                    currentScene = 4;
                    Application.LoadLevel("LoadScene");
                }
                break;
            default:
                break;
        }
    }
}
