using MLAPI;
using MLAPI.Transports.UNET;
using MLAPI.SceneManagement;
using MLAPI.Spawning;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ConnectionManager : MonoBehaviour
{
    public GameObject hostPanel;
    public GameObject joinPanel;
    public GameObject prefab;

    public TMP_InputField ipInputField;
    public int port = 1741;

    private UNetTransport transport;


    public void Host()
    {
        Debug.Log("Hosting...");

        NetworkManager.Singleton.ConnectionApprovalCallback += ApprovalCheck;
        NetworkManager.Singleton.StartHost(Vector3.zero, Quaternion.identity, false);

        hostPanel.SetActive(true);

    }

    private void ApprovalCheck(byte[] connectionData, ulong clientId, MLAPI.NetworkManager.ConnectionApprovedDelegate callback)
    {
        Debug.Log("Approving connection...");

        bool approve = System.Text.Encoding.ASCII.GetString(connectionData) == "MyPassword";
        approve = true;

        bool createPlayerObject = true;
        createPlayerObject = false;

        ulong? prefabHash = null;
        prefabHash = NetworkSpawnManager.GetPrefabHashFromGenerator("Inhabot");

        callback(createPlayerObject, prefabHash, approve, Vector3.zero, Quaternion.identity);
    }

    public void Join()
    {
        Debug.Log("Joining...");
        transport = NetworkManager.Singleton.GetComponent<UNetTransport>();

        transport.ConnectAddress = ipInputField.text;

        transport.ConnectPort = port;
        transport.ServerListenPort = port;

        NetworkManager.Singleton.NetworkConfig.ConnectionData = System.Text.Encoding.ASCII.GetBytes("MyPassword");
        NetworkManager.Singleton.StartClient();

        joinPanel.SetActive(true);

    }

    public void StartGame()
    {
        NetworkSceneManager.OnSceneSwitched += SpawnPlayer;
        NetworkSceneManager.SwitchScene("WorkInProgressScene");

        foreach (var item in NetworkManager.Singleton.ConnectedClients.Keys)
        {
            Debug.Log(item);
        }
    }

    private void SpawnPlayer()
    {
        foreach (var clientId in NetworkManager.Singleton.ConnectedClients.Keys)
        {
            GameObject go = Instantiate(prefab, Vector3.zero, Quaternion.identity);
            go.GetComponent<NetworkObject>().SpawnAsPlayerObject(clientId);
            go.name += " " + clientId;
        }
    }



}
