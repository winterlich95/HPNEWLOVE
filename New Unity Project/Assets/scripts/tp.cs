using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tp : MonoBehaviour
{
    public GameObject player;

    public void TeleportPlayer()
    {
        player.transform.position = new Vector3(transform.position.x, transform.position.y + 4.2f, transform.position.z);
    }
}
