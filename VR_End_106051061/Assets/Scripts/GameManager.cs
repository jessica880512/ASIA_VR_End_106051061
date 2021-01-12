using UnityEngine;
using UnityEngine.Networking.Types;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{



    public void RestartGame()
    {
        SceneManager.LoadScene("場景");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
