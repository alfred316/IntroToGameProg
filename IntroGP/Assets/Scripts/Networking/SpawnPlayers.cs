using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviour
{
    public GameObject playerPrefab;

    //boundaries for spawning the player
    public float minX;
    public float maxX;
    public float minZ;
    public float maxZ;

    // Start is called before the first frame update
    void Start()
    {
        //get a random position within our boundaries
        Vector2 randomPosition = new Vector2(Random.Range(minX, maxX), Random.Range(minZ, maxZ));
        //spawn the networked player
        PhotonNetwork.Instantiate("Prefabs/Player/" + playerPrefab.name, randomPosition, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
