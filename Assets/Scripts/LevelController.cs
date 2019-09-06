using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField] GameObject winLabel;
    bool allSpawnersStopped = false;

    private void Start()
    {
        winLabel.SetActive(false);
    }

    IEnumerator HandleWinCondition()
    {
        winLabel.SetActive(true);
        yield return new WaitForSeconds(2);
        FindObjectOfType<LevelLoader>().LoadNextScene();
    }

    public void DetermineResult()
    {
        if (!allSpawnersStopped)
        {
            StopSpawners();
        }
        

        Attacker[] aliveAttackers = FindObjectsOfType<Attacker>();
        if(aliveAttackers.Length == 0)
        {
            StartCoroutine(HandleWinCondition());
        }
    }

    public void StopSpawners()
    {
        AttackerSpawner[] spawnerArray = FindObjectsOfType<AttackerSpawner>();
        foreach(AttackerSpawner spawner in spawnerArray)
        {
            spawner.StopSpawning();
        }
        allSpawnersStopped = true;
    }
}
