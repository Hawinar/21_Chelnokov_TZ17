using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerUIController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreTMP;

    [SerializeField] private GameObject _panel;
    [SerializeField] private Button _restartBtn;
    [SerializeField] private Button _backBtn;

    void Start()
    {
        _panel.SetActive(false);
        
        Time.timeScale = 1f;

        _restartBtn.onClick.AddListener(() => Restart());
        _backBtn.onClick.AddListener(() => Back());

    }
    private void Update()
    {
        if (GameManager.HP <= 0)
        {
            _scoreTMP.text = $"¬ан счЄт: {GameManager.Score.ToString()}";
            _panel.SetActive(true);
            Time.timeScale = 0f;
        }
    }
    private void Restart()
    {
        SceneManager.LoadScene("Game");
        GameManager.HP = 3;
        GameManager.Score = 0;
    }
    private void Back()
    {
        SceneManager.LoadScene("MainMenu");
        GameManager.HP = 3;
        GameManager.Score = 0;
    }
}
