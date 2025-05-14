using UnityEngine;

public class DifficultyButtons : MonoBehaviour
{
    public void SelectEasy()
    {
        DifficultyManager.Instance.SetDifficulty(Difficulty.Easy);
    }

    public void SelectMedium()
    {
        DifficultyManager.Instance.SetDifficulty(Difficulty.Medium);
    }

    public void SelectHard()
    {
        DifficultyManager.Instance.SetDifficulty(Difficulty.Hard);
    }
}

