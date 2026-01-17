using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneTeleport : MonoBehaviour
{
    public string sceneName;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(sceneName);
            Debug.Log("Teleporting to scene: " + sceneName);
        }
    }
}