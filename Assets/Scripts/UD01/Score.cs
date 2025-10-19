using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Score : MonoBehaviour
{

    public int PlayerScore;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CheckScore(PlayerScore);
    }

    void CheckScore(int score)
    {
        if (score >= 45)
        {
            Debug.Log("¡Has alcanzado o superado los 45 puntos!");
        }
        else
        {
            Debug.Log("Aún no has llegado a los 45 puntos. Sigue jugando...");
        }
    }
}
