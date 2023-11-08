using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayView : MonoBehaviour
{
    [SerializeField] private InputField _inputNickame;
    [SerializeField] private Button _play;
    void Start()
    {
        _play.onClick.AddListener(() => Play());
    }

    private void Play()
    {
        if (_inputNickame.text != "")
        {
            GameManager.Nickname = _inputNickame.text;
            SceneManager.LoadScene("Game");
        }
    }
}
