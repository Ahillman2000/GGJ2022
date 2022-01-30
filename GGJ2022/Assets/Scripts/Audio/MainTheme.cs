using UnityEngine;

public class MainTheme : MonoBehaviour
{
    private void Start()
    {
        EventParam audioParam = new EventParam(); 
        audioParam.string_ = "MenuTheme";
        
        AudioManager.Instance.Play(audioParam);
    }
}

