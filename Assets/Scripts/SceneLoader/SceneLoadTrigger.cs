using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class SceneLoadTrigger : MonoBehaviour
{
    public string targetScene = null;
    private string currenPressed = null;
    private string presceneName = "level";

    public void LoadScene()
    {
        currenPressed = EventSystem.current.currentSelectedGameObject.name;
        //Debug.Log(currenPressed);
        LoadingData.sceneToLoad = presceneName + currenPressed.Substring(5);
        SceneManager.LoadScene("LoadingScene");
    }
}