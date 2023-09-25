using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using TMPro;

public class createAndJoinRooms : MonoBehaviourPunCallbacks
{
    [SerializeField] TMP_InputField createRoom;
    [SerializeField] TMP_InputField joinRoom;
    

    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom(createRoom.text);

    }

    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(joinRoom.text);
        
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Game");    
    }
}
