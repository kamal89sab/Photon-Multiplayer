using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class spawnPlayers : MonoBehaviour
{
    [SerializeField] GameObject spawnPlayerPrefab;
    [SerializeField] float minX;
    [SerializeField] float maxX;
    [SerializeField] float minZ;
    [SerializeField] float maxZ;


    private void Start()
    {
        Vector3 randomPosition=new Vector3(Random.Range(minX, maxX), 2f, Random.Range(minZ, maxZ));
        GameObject _player=PhotonNetwork.Instantiate(spawnPlayerPrefab.name, randomPosition, Quaternion.identity);
        _player.GetComponent<playerSetup>().isLocalPlayer();
    }
}
