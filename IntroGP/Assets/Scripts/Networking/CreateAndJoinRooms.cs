using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using TMPro;

public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{
    public TMP_InputField createInput;
    public TMP_InputField joinInput;

    //to be called from a button
    //creating a room also makes you automatically join it
    public void CreateRoom()
    {
        //give it the name of the input
        PhotonNetwork.CreateRoom(createInput.text);
    }

    //to be called from a button
    //room must exist
    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(joinInput.text);
    }

    //now we handle what to do when we join a room
    //this is a pun callback
    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Network-RollABall");
    }
}
