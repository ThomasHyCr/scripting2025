using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> mediumOrHardEnemies;
    [SerializeField] private List<GameObject> hardOnlyEnemies;

    private void Start()
    {
        ApplyDifficulty();
    }

    private void ApplyDifficulty()
    {
        Difficulty current = DifficultyManager.Instance.CurrentDifficulty;

        foreach (GameObject enemy in mediumOrHardEnemies)
            enemy.SetActive(current == Difficulty.Medium || current == Difficulty.Hard);

        foreach (GameObject enemy in hardOnlyEnemies)
            enemy.SetActive(current == Difficulty.Hard);
    }
}
