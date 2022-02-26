using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoadTrigger : MonoBehaviour
{
    public string targetScene;
    public void LoadScene()
    {
        LoadingData.sceneToLoad = targetScene;
        SceneManager.LoadScene("LoadingScene");
    }
}