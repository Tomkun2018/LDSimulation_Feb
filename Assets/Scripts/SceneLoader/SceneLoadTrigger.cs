using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using System;

public class SceneLoadTrigger : MonoBehaviour
{
    public string targetScene = null;
    private string currenPressed = null;
    private string presceneName = "level";

    public void LoadScene()
    {
        currenPressed = EventSystem.current.currentSelectedGameObject.name;
        if (currenPressed == "NextLevelBtn")
        {
            Scene scene = SceneManager.GetActiveScene();
            int nextLevelNum = Convert.ToInt32(scene.name.ToString().Substring(5))+1;
            LoadingData.sceneToLoad = presceneName + nextLevelNum.ToString();
            SceneManager.LoadScene("LoadingScene");
            return;
        }
        //Debug.Log(currenPressed);

        LoadingData.sceneToLoad = presceneName + currenPressed.Substring(5);
        SceneManager.LoadScene("LoadingScene");
    }
}