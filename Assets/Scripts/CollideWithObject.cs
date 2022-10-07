using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideWithObject : MonoBehaviour
{
    Material currentMat;
    ScoreHandler scoreHandler;

    private void Start()
    {
        scoreHandler = FindObjectOfType<ScoreHandler>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            currentMat = GetComponent<Renderer>().material;
            currentMat.color = Color.red;
            scoreHandler.ScoreDecreesing();
        }
    }
}
