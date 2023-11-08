using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LeaderboardView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _leadersTMP;
    [SerializeField] private Button _back;
    private void Start()
    {
        _back.onClick.AddListener(() => Back());
    }

    private void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
