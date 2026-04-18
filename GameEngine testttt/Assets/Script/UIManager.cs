using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour
{
    public GameObject HelpPanel;
    public void GameStartButtonAction()
    {
        // 본인 첫 씬 이름 쓰기
        SceneManager.LoadScene("Level_1");
    }
    public void OpenHelpPanel()
    {
        
    }

    // Update is called once per frame
    public void CloseHelpPanel()
    {
       
    }
}
