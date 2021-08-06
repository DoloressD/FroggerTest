using UnityEngine;
using UnityEngine.UI;

public class Stats : MonoBehaviour
{
    public static int Score = 0;
    public static int Deaths = 0;

    public Text scoreText;
    public Text deathText;

    void Start() // game starts a level when we win/lose
    {
        scoreText.text = Score.ToString();
        deathText.text = Deaths.ToString();
    }

}
