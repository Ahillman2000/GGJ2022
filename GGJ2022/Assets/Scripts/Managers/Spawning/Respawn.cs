using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    //GameObject player;
    //[SerializeField] Transform respawnPoint;

    private void Start()
    {
        //player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            //player.transform.position = respawnPoint.position;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
