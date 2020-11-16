
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    
    public void StartGame()
    {
        print("開始遊戲");
        SceneManager.LoadScene("2D");
    }

    public void QuitGame()
    {
        print("離開遊戲");
        Application.Quit();
        
    }

    public void Back()
    {
        print("返回選單");
        SceneManager.LoadScene("選單");

    }
 
}
