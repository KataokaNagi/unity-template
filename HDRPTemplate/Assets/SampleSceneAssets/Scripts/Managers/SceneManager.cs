using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private AsyncOperation _titleSceneOperation;
    private AsyncOperation _loadSceneOperation;
    private AsyncOperation _ingameSceneOperation;
    private AsyncOperation _stage1SceneOperation;
    private AsyncOperation _stage2SceneOperation;
    private AsyncOperation _stage3SceneOperation;
    private AsyncOperation _resultSceneOperation;

    public void loadTitleScene()
    {
        loadScene(SceneName.Title, _titleSceneOperation);
    }

    // Load Scene
    public void loadLoadScene()
    {
        // Async
        loadScene(SceneName.Load, _loadSceneOperation);
    }
    public void loadIngameScene()
    {
        loadScene(SceneName.Ingame, _ingameSceneOperation);
    }
    public void loadStage1Scene()
    {
        loadScene(SceneName.Stage1, _stage1SceneOperation);
    }
    public void loadStage2Scene()
    {
        loadScene(SceneName.Stage2, _stage2SceneOperation);
    }
    public void loadStage3Scene()
    {
        loadScene(SceneName.Stage3, _stage3SceneOperation);
    }
    public void loadResultScene()
    {
        loadScene(SceneName.Result, _resultSceneOperation);
    }

    // TODO: Progress bar @see [UnityでNowLoading画面を作成する](https://gametukurikata.com/program/nowloading#google_vignette)
    // TODO: Activate Scene
    // TODO: Deactivate Scene
    // TODO: Unload Scene

    private void loadScene(string sceneName, AsyncOperation sceneOperation)
    {
        SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);
        sceneOperation.allowSceneActivation = false;
    }
}
