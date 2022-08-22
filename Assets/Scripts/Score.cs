using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public Transform player;
    public int score;
    public int highScore;
    public TextMeshProUGUI scoreText, highscoretext;
    public Color[] colors;

    void Start()
    {
        highScore = PlayerPrefs.GetInt("Score");
        highscoretext.text = "Highscore: " + highScore.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        if (score > highScore && highScore != 0)
        {
            RandomColor();
        }

        score = Mathf.RoundToInt(player.transform.position.x - transform.position.x);
        scoreText.text = "Score: " + score.ToString();
    }
    void RandomColor()
    {
        colors = new[] {
    Color.blue,
    Color.magenta,
    Color.red,
    Color.green,
    Color.yellow};

        int rand = Random.Range(0, colors.Length);
        for (int i = 0; i <= colors.Length; i++)
        {
            player.GetComponent<SpriteRenderer>().color = colors[rand];
        }
    }
    public void End()
    {
        if (score > highScore)
        {
            highScore = score;
            highscoretext.text = "Highscore: " + highScore.ToString();
            PlayerPrefs.SetInt("Score", highScore);
            PlayerPrefs.Save();
        }
    }
}
