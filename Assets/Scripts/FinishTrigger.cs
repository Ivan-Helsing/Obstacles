using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishTrigger : MonoBehaviour
{
    [SerializeField] ParticleSystem particles;
    IEnumerator AppQuitAFterFinish()
    {
        yield return new WaitForSeconds(3);
        Application.Quit();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            ScoreHandler scoreHandler = FindObjectOfType<ScoreHandler>();
            scoreHandler.SetHighScore();
            Instantiate(particles, other.transform);
            StartCoroutine(AppQuitAFterFinish());
        }
    }
}
