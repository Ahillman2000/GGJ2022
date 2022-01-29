using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject pauseButton, pausedPanel, levelSelect;
    [SerializeField] private GameObject btmmButton, slButton;
    private Text btmmText, slText;

    // Start is called before the first frame update
    void Start()
    {
        pausedPanel.SetActive(false);
        levelSelect.SetActive(false);
        btmmText = btmmButton.GetComponentInChildren<Text>();
        slText = slButton.GetComponentInChildren<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        print("p");
        pauseButton.SetActive(false);
        pausedPanel.SetActive(true);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        pauseButton.SetActive(true);
        pausedPanel.SetActive(false);
        levelSelect.SetActive(false);
    }

    public void LevelSelect()
    {
        pausedPanel.SetActive(false);
        levelSelect.SetActive(true);
    }

    public void ReturnToTitle()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Title");
    }

    public void BtmmOnHover()
    {
        btmmButton.GetComponent<Image>().color = Color.white;
        btmmText.color = Color.black;
    }

    public void BtmmLeaveHover()
    {
        btmmButton.GetComponent<Image>().color = Color.black;
        btmmText.color = Color.white;
    }

    public void SlOnHover()
    {
        slButton.GetComponent<Image>().color = Color.white;
        slText.color = Color.black;
    }

    public void SlLeaveHover()
    {
        slButton.GetComponent<Image>().color = Color.black;
        slText.color = Color.white;
    }

    public void GotoLevel()
    {
        int level = EventSystem.current.currentSelectedGameObject.GetComponent<Level>().ButtonLevel();
        Time.timeScale = 1;
        SceneManager.LoadScene(level);
    }
}
