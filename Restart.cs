using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Restart : MonoBehaviour
{
    [SerializeField] public TMP_Text score;
    public ScoreManager sm;
    public TextMeshProUGUI bestScoreTXT;
    public Sprite[] medals; 

    private void Start()
    {
        score.text = ("Ваш счёт: ") + sm.score.ToString();
        int bestScore = PlayerPrefs.GetInt(key: "BestScore");
        if (sm.score > bestScore)
        {
            bestScore = sm.score;
        }

        bestScoreTXT.text = ("Рекорд: ") + bestScore.ToString();
        PlayerPrefs.SetInt("BestScore", bestScore);
    }

    public void OnExitButtonDown()
    {
        SceneManager.LoadScene("Menu");
    }    
}
