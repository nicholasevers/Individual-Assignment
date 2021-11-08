using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    //[SerializeField] private Transform Player;
    //[SerializeField] private Transform respawnPoint;

    //respawn the player when they fall of the map or hit a trap
    private void OnTriggerEnter(Collider other)
    {
        //Player.transform.position = respawnPoint.transform.position;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
