using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    GameObject player;
    bool followPlayer = true;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        
    }

    
    void Update()
    {
        if (followPlayer == true)
        {
            camFollowPlayer();
        }

    }
    public void setFollowPlayer(bool val)
    {
        followPlayer = val;
    }
    void camFollowPlayer()
    {
        Vector3 newPos = new Vector3(player.transform.position.x, player.transform.position.y, this.transform.position.z);
        this.transform.position = newPos;
    }
}

