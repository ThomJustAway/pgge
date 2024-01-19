using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayManager : MonoBehaviour
{
    public string mPlayerPrefabName;
    public PlayerSpawnPoints mSpawnPoints;
    [HideInInspector]
    public GameObject mPlayerGameObject;
    [HideInInspector]
    private ThirdPersonCamera mThirdPersonCamera;

    private void Start()
    {
        mPlayerGameObject =
        PhotonNetwork.Instantiate(mPlayerPrefabName,
        mSpawnPoints.GetSpawnPoint().position,
        mSpawnPoints.GetSpawnPoint().rotation,
        0);

        mPlayerGameObject.GetComponent<PlayerMovement>().mFollowCameraForward = false;

        mThirdPersonCamera =
        Camera.main.gameObject.AddComponent<ThirdPersonCamera>();
        mThirdPersonCamera.mPlayer = mPlayerGameObject.transform;
        mThirdPersonCamera.mDamping = 20.0f;
        mThirdPersonCamera.mCameraType = CameraType.Follow_Track_Pos_Rot;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
