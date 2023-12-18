using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerRampScoreController : MonoBehaviour
{
    public float score;
    public ScoreManager scoreManager;
    public Collider bola;

    private void OnTriggerEnter(Collider other)
    {
        if(other == bola)
        {
            scoreManager.AddScore(score);
        }
    }
}
