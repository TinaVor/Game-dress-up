using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;

public class tog : MonoBehaviour
{
    [SerializeField] private Toggle _toggle;

    void Start()
    {

    }

    private void Awake()
    {
        string keyName = UnityEngine.SceneManagement.SceneManager.GetActiveScene().name + gameObject.name;
        if (PlayerPrefs.GetInt(keyName) == 0 && gameObject.name != "Hair2")
            gameObject.SetActive(false);
        _toggle.onValueChanged.AddListener(OnToggleChangeds);
    }

    private void OnToggleChangeds(bool active)
    {
        if (_toggle )
        {
            string keyName = UnityEngine.SceneManagement.SceneManager.GetActiveScene().name + gameObject.name;
            PlayerPrefs.SetInt(keyName, active  ? -1 : 0);
            gameObject.SetActive(active);
        }
    }

}
