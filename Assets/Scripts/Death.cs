using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public GameObject deathScreen;
    public Transform player;
    public float offset = 5;

    private void Update()
    {
        if(player.transform.position.y - offset > transform.position.y)
        {
            transform.position = new Vector3(player.transform.position.x, player.transform.position.y - offset, player.transform.position.z);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            deathScreen.SetActive(true);
            SaveLoad.Save();
        }
    }
}
