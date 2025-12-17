using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleSceneTrigger : MonoBehaviour
{
    [Range(0f, 1f)]
    public float battleChance = 0.25f; // 25%

    public string battleSceneName = "BattleScene2";

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player"))
            return;

        float randomValue = Random.value; // número entre 0 y 1

        if (randomValue <= battleChance)
        {
            SceneManager.LoadScene(battleSceneName);
        }
        // si no, no pasa nada y el jugador sigue caminando
    }
}


