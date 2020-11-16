using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void NextLevel(string nameLv)
    {
        SceneManager.LoadScene(nameLv);
    }

    
}