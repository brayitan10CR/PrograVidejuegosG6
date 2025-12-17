using UnityEngine;
using UnityEngine.SceneManagement;

public class GrassBattleTrigger : MonoBehaviour
{
    [Range(0f, 1f)]
    public float battleChance = 0.25f; 

    public string battleSceneName = "BattleScene";

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player"))
            return;

        float randomValue = Random.value; 

        if (randomValue <= battleChance)
        {
            SceneManager.LoadScene(battleSceneName);
        }
    }
}
