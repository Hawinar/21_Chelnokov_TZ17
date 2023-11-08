using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rb2d;

    void FixedUpdate()
    {
        Vector2 _playerDirection;
        float directionX = Input.GetAxisRaw("Horizontal");
        _playerDirection.x = Mathf.Clamp(directionX, -3f, 3f);
        float directionY = Input.GetAxisRaw("Vertical");
        _playerDirection.y = Mathf.Clamp(directionY, -4f, 0f);
        _rb2d.MovePosition(_playerDirection * 3);
    }
}
