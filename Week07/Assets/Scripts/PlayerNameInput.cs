using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon;
using UnityEngine.UI;
using Photon.Pun;
using static UnityEngine.ParticleSystem;

public class PlayerNameInput : MonoBehaviour
{
    const string playerNamePrefKey = "PlayerName";
    private InputField mInputField;

    void Start()
    {
        string defaultName = string.Empty;
        mInputField = this.GetComponent<InputField>();
        if (mInputField != null)
        {
            if (PlayerPrefs.HasKey(playerNamePrefKey))
            {
                defaultName =
                PlayerPrefs.GetString(playerNamePrefKey);
                mInputField.text = defaultName;
            }
        }
        PhotonNetwork.NickName = defaultName;
    }
    public void SetPlayerName()
    {
        string value = mInputField.text;
        if (string.IsNullOrEmpty(value))
        {
            Debug.LogError("Player Name is null or empty");
            return;
        }
        PhotonNetwork.NickName = value;
        PlayerPrefs.SetString(playerNamePrefKey, value);
    }

}
