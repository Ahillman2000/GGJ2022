using UnityEngine;

public class MainTheme : MonoBehaviour
{
    private void Start()
    {
        EventParam audioParam = new EventParam(); 
        audioParam.string_ = "GameTheme";
        
        AudioManager.Instance.Play(audioParam);
    }
}

