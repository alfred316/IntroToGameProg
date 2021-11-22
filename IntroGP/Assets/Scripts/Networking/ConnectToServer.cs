using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;
public class ConnectToServer : MonoBehaviourPunCallbacks
{
    // Connect to the photon server
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    //decide what to do when connected, this will make us join the lobby, triggering the OnJoinedLobby callback
    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
    }

    //now that we have joined the lobby, decide what to do. here we switch scenes to the lobby scene
    public override void OnJoinedLobby()
    {
        SceneManager.LoadScene("Lobby-Network");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
