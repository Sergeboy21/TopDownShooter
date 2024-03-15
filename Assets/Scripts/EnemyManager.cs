using UnityEngine.SceneManagement;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public int totalEnemies;

    void Start()
    {
        totalEnemies = GameObject.FindGameObjectsWithTag("Enemy").Length;
    }

    public void EnemyDefeated()
    {
        totalEnemies--;
        if (totalEnemies == 0)
        {
            LoadNextScene();
        }
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene("Won");
    }
}