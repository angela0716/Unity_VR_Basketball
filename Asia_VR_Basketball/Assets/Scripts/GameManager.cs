using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// 重新開始
/// </summary>
public class GameManager : MonoBehaviour
{
   public void RestartGame ()
    {
        SceneManager.LoadScene("場景");
    }
    /// <summary>
    /// 離開遊戲
    /// </summary>
public void QuitGame()
    {
        Application.Quit();

    }
}
