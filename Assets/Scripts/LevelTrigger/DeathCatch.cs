using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathCatch : MonoBehaviour {
    public List<GameObject> hearts;
    public GameObject player;
    public Transform Respawn;
	void OnTriggerEnter2D(Collider2D other)
    {
        /*
         * instead of destroying player just move player position back to spawn and remove on of the heart object arrays
         */
        if (hearts.Count!=1) {
            player.transform.position = Respawn.position;
            var hearttoremove = hearts[hearts.Count - 1];
            GameObject.Destroy(hearttoremove);
            hearts.Remove(hearttoremove);
        }
        else { 
        Destroy(other.gameObject);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);}
    }
}
