using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] float timeToReload = 1f;
    public static GameManager instance;
    void Awake()
    {
        instance = this; 
    }
    public void ReloadGame()
    {
        StartCoroutine(Dead());
    }
    public void ReloadHome()
    {
        StartCoroutine(Menu());
    }
    public IEnumerator Dead()
    {
        yield return new WaitForSeconds(timeToReload);
        int indexScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(indexScene);
        
    }
    public void LoadNextLevel()
    {
        StartCoroutine(NextLevel());
    } 
    public IEnumerator NextLevel()
    {
        yield return new WaitForSeconds(timeToReload);
        int indexScene = SceneManager.GetActiveScene().buildIndex;
        int indexNextLevel = indexScene + 1;
        if (indexNextLevel >= SceneManager.sceneCountInBuildSettings)
        {
            indexNextLevel = 0;
        }
        SceneManager.LoadScene(indexNextLevel);
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public IEnumerator Menu()
    {
        yield return new WaitForSeconds(timeToReload);
        SceneManager.LoadScene(0);
    }
}
