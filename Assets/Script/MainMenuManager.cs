using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public GameObject instructionPanel;
    public void Start()
    {
        instructionPanel.SetActive(false);
    }

     public void Update()
     {
        if(Input.GetKey(KeyCode.I)){
            instructionPanel.SetActive(false);
        }
     }

    public void ShowInstructions()
    {
        instructionPanel.SetActive(true);
    }
   public void StartGame()
   {
    SceneManager.LoadScene(1);
   }
   public void Quitgame()
   {
    Application.Quit();
    Debug.Log("Quit");
   }
}
