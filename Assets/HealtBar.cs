using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealtBar : MonoBehaviour
{
    public List<GameObject> hearts;
    public GameObject player;
    void playGameOver()
    {
        if (hearts.Count == 0)
        {
            Destroy(this.player);
        }
        else { }
    }
}
