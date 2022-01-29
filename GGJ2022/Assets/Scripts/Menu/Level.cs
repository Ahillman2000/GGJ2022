using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] private int level;

    public int ButtonLevel()
    {
        return level;
    }
}
