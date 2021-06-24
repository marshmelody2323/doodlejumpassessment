using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayScript : MonoBehaviour
{
    [SerializeField] private Text highScoreText;

    private void Start()
    {
        // Load the high scores
        SaveLoad.Load();

        highScoreText.text = highScoreText.text.Replace("{SCORE}", SaveLoad.data.score.ToString());
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
}
