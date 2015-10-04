using UnityEngine;
using System.Collections;

public class NetworkController : Photon.PunBehaviour
{
    string _room = "Factory";
    private PhotonView myPhotonView;
    void Start()
    {
        PhotonNetwork.logLevel = PhotonLogLevel.Full;
        PhotonNetwork.ConnectUsingSettings("0.1");
    }
    void OnGUI()
    {
        GUILayout.Label(PhotonNetwork.connectionStateDetailed.ToString());
        if (PhotonNetwork.connectionStateDetailed == PeerState.Joined)
        {
            if (GUILayout.Button("Marco!"))
            {
                this.myPhotonView.RPC("Marco", PhotonTargets.All);
            }
            if (GUILayout.Button("Polo!"))
            {
                this.myPhotonView.RPC("Polo", PhotonTargets.All);
            }
        }
    } 
    public override void OnJoinedLobby()
    {
        PhotonNetwork.JoinRandomRoom();
    }
    void OnPhotonRandomJoinFailed()
    {
        Debug.Log("Can't join random room!");
        PhotonNetwork.CreateRoom(null);
    }
    //void OnJoinedRoom()
    //{
    //PhotonNetwork.Instantiate("NetworkedPlayer", Vector3.zero, Quaternion.identity, 0);
    //}
}