using UnityEngine;
using UnityEngine.UI;//介面
using Valve.VR;

public class ScoreManager : MonoBehaviour
{
    [Header("分數介面")]
    public Text TextScore;
    [Header("分數")]
    public int score;
    [Header("投進的分數")]
    public int scoreIn;

    [Header("丟中音效")]
    public AudioClip soundIn;

    private AudioSource aud;

    private void Awake()
    {
        aud = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "內臟"&&other.transform.position.y>2)
        {
            Addscore();
        }

        if (other.transform.root.name == "Player")
        {
            scoreIn = 3;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.transform.root.name == "Player")
        {
            scoreIn = 2;
        }
    }

    //分數
    private void Addscore()
    {
        score += scoreIn;
        TextScore.text = "分數 :" + score;

        aud.PlayOneShot(soundIn,Random.Range(1f,3f));
    }
}
