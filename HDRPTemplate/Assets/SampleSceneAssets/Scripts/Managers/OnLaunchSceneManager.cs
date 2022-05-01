/// <summary>
/// @note Once load scene from any scene (for debug)
/// @see [Unityでの複数シーンを使ったゲームの実装方法とメモリリークについて](https://madnesslabo.net/utage/?page_id=11109#i-10)
/// </summary>

using UnityEngine;
using UnityEngine.SceneManagement;

public class OnLaunchSceneManager : MonoBehaviour
{
    private AsyncOperation _optionSceneOperation;
    private static bool Loaded { get; set; }

    void Awake()
    {
        // Do once on launch
        if (Loaded)
        {
            return;
        }
        else
        {
            Loaded = true;
        }

        // Load scenes
        SceneManager.LoadScene(SceneName.GameManager, LoadSceneMode.Additive);
        _optionSceneOperation = SceneManager.LoadSceneAsync(SceneName.Option, LoadSceneMode.Additive);

        // deactivate option scene on launch
        deactivateOptionScene();
    }

    public void activateOptionScene()
    {
        _optionSceneOperation.allowSceneActivation = true;
    }
    public void deactivateOptionScene()
    {
        _optionSceneOperation.allowSceneActivation = false;
    }
}
