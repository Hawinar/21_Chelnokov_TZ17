using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainView : MonoBehaviour
{
    [SerializeField] private Button _playBtn;
    [SerializeField] private Button _settingsBtn;
    [SerializeField] private Button _leadersBtn;

    [SerializeField] private GameObject _playUI;
    [SerializeField] private GameObject _settingsUI;
    [SerializeField] private GameObject _leadersUI;
    private void Start()
    {
        _playUI.SetActive(false);
        _settingsUI.SetActive(false);
        _leadersUI.SetActive(false);

        _playBtn.onClick.AddListener(() => ShowPlayUI());
        _settingsBtn.onClick.AddListener(() => GoSettings());
        _leadersBtn.onClick.AddListener(() => GoLeaders());

    }

    private void ShowPlayUI()
    {
        this.gameObject.SetActive(false);
        _playUI.SetActive(true);
    }
    private void GoSettings()
    {
        this.gameObject.SetActive(false);
        _settingsUI.SetActive(true);
    }
    private void GoLeaders()
    {
        this.gameObject.SetActive(false);
        _leadersUI.SetActive(true);
    }

}
