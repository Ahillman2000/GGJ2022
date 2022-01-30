using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    private Animator animator;
    [SerializeField] private GameObject startButton, quitButton;

    // Start is called before the first frame update
    void Start()
    {
        startButton.SetActive(false);
        quitButton.SetActive(false);
        animator = gameObject.GetComponent<Animator>();
        EventParam audioParam = new EventParam();
        audioParam.string_ = "MenuTheme";
        AudioManager.Instance.Play(audioParam);
    }

    // Update is called once per frame
    void Update()
    {
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Title_black") && animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f)
        {
            startButton.SetActive(true);
            quitButton.SetActive(true);
        }
    }

    public void StartGame()
    {
        EventParam clickAudio = new EventParam { string_ = "Click" };
        AudioManager.Instance.Play(clickAudio);
        EventParam themeAudio = new EventParam { string_ = "MenuTheme" };
        AudioManager.Instance.Stop(themeAudio);
        
        SceneManager.LoadScene("Level_1");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
