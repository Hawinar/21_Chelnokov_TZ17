using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DifficultyLevelController : MonoBehaviour
{
    [SerializeField] private int _diffId;
    [SerializeField] private Button _btn;
    private void Start()
    {
        _btn.onClick.AddListener(() => ChangeDiffuculty(_diffId));

        if (_diffId == GameManager.DifficultyLevel)
            _btn.image.color = Color.green;
        else
            _btn.image.color = Color.gray;
    }
    private void ChangeDiffuculty(int id)
    {
        GameManager.DifficultyLevel = id;
        SceneManager.LoadScene("MainMenu");
    }
}
