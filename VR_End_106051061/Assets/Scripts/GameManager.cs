using UnityEngine;
using UnityEngine.Networking.Types;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Header("人物動畫")]
    public Animator Ani;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == ("內臟"))
        {
            Ani.SetTrigger("fall觸發器");
        }
    }
    public void RestartGame()
    {
        SceneManager.LoadScene("場景");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
