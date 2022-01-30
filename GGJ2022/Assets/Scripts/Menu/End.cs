using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        EventParam audioParam = new EventParam();
        audioParam.string_ = "GameTheme";
        AudioManager.Instance.Stop(audioParam);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetButton("Jump"))
        {
            SceneManager.LoadScene("Title");
        }
    }
}
