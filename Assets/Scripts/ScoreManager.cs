using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public GameObject EndGameMenu;
    public Text textRedScore;
    public Text textBlueScroe;
    private int redScore = 1;
    private int blueScore = 1;
    private int globalScore;

    private void OnEnable()
    {
        RedWall.RedScore += RedScore;
        RedWall.RedScore += Win;
        BlueWall.BlueScore += BlueScore;
        BlueWall.BlueScore += Win;
    }

    private void OnDisable()
    {
        RedWall.RedScore -= RedScore;
        RedWall.RedScore -= Win;
        BlueWall.BlueScore -= BlueScore;
        BlueWall.BlueScore -= Win;
    }

    void RedScore()
    {
        textRedScore.text = "" + redScore;
        redScore++;
    }

    void BlueScore()
    {
        textBlueScroe.text = "" + blueScore;
        blueScore++;
    }

    void Win()
    {
        globalScore++;
        
        if(globalScore == 6)
        {
            EndGameMenu.SetActive(true);
            Time.timeScale = 1f;
        }
    }
}
