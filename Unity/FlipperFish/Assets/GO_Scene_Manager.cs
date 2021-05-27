using UnityEngine;
using UnityEngine.SceneManagement;

public class GO_Scene_Manager : MonoBehaviour
{
    [SerializeField]
    Object SplashScreen;
    [SerializeField]
    Object MainScreen;
    [SerializeField]
    Object[] Levels;

    void Awake()
    {

        if (SplashScreen != null)
        {
            LoadScene(SplashScreen.name, LoadSceneMode.Single);
        }
        else if (MainScreen != null)
        {
            LoadScene(MainScreen.name, LoadSceneMode.Single);
        }
        else if (Levels != null && Levels.Length > 0)
        {
            LoadScene(Levels[0].name, LoadSceneMode.Single);
        }
        else
        {
#if UNITY_EDITOR
            Debug.LogWarning("GO_Scene_Manager: No scene to load.");
#endif
        }
    }

    public void LoadScene(string name, LoadSceneMode mode)
    {

#if UNITY_EDITOR
        Debug.Log("SceneManager.LoadScene(\"" + name + "\")");
#endif

        SceneManager.LoadScene(name, mode);

    }


}
