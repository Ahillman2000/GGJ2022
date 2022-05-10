using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialQCheck : MonoBehaviour
{
    private ColourChange colourChange;

    // Start is called before the first frame update
    void Start()
    {
        colourChange = GameObject.FindGameObjectWithTag("Player").GetComponent<ColourChange>();
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (colourChange.GetColour() == ColourChange.Colour.BLACK)
        {
            gameObject.SetActive(false);
        }
    }
}
