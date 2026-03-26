using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ss : MonoBehaviour
{

    public GameObject hlepPannel;
public void ButtonLog()
{
    Debug.Log("BUTTON CLICKED!");
}

public void OpenHelp()
    {
        hlepPannel.SetActive(true);
    }

    public void CloseHelp()
    {
        hlepPannel.SetActive(false);
    }

    public void GameStart()
    {
        SceneManager.LoadScene("PlayScene_Door1");
    }

     public void TitleScene()
     {
         SceneManager.LoadScene("c");
     }
}