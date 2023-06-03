using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public string mainMenuScene;
    public string loadGameScene;
    public Button button;
    
    // Start is called before the first frame update
    void Start()
    {
        AudioManager.instance.PlayBGM(2);
        button.interactable = false;

        /*PlayerController.instance.gameObject.SetActive(false);
        GameMenu.instance.gameObject.SetActive(false);
        BattleManager.instance.gameObject.SetActive(false);*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void QuitToMain()
    {
        Destroy(GameManager.instance.gameObject);
        Destroy(PlayerController.instance.gameObject);
        Destroy(GameMenu.instance.gameObject);
        Destroy(AudioManager.instance.gameObject);
        Destroy(BattleManager.instance.gameObject);
        SceneManager.LoadScene(mainMenuScene);
    }

    public void LoadLastSave()
    {
        button.interactable = false;
        if (HasSaveFile())
        {        
        button.interactable = true;
        Destroy(GameManager.instance.gameObject);
        Destroy(PlayerController.instance.gameObject);
        Destroy(GameMenu.instance.gameObject);
        //Destroy(BattleManager.instance.gameObject);
        SceneManager.LoadScene(loadGameScene);
        }
        else
        {
            Debug.Log("Nie ma zapisu");
        }
    }

    public bool HasSaveFile()
    {
        return false;
    }
}
