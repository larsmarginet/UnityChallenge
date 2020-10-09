using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Text message;
    private void LoadScene()
    {
        //Restarts the scene when game over
        SceneManager.LoadScene("scene");
    }

    public void EndGame()
    {
        Debug.Log("Game Over");
        LoadScene();
        message.text = "GAME OVER";
    }

    public void WinGame()
    {
        Debug.Log("You Win!");
        LoadScene();
        message.text = "YOU WIN";
    }

}
