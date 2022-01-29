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
        SceneManager.LoadScene("Level_1");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
