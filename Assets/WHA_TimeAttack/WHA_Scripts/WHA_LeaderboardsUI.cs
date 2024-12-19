using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WHA_LeaderboardsUI : MonoBehaviour
{
    public void OnRestartClick()
    {
        SceneManager.LoadScene("WHA_ChristmasTrack");
    }
    public void OnMenuQuitClick()
    {
        Application.Quit();
    }

    public void OnQuitClick()
    {
        SceneManager.LoadScene(0);
    }
}
