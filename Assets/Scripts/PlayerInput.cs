using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]
public class PlayerInput : MonoBehaviour
{
    private PlayerMovement _playerMovement;
    private Shooter _shooter;

    private void Awake()
    {
        _playerMovement = GetComponent<PlayerMovement>();
        _shooter = GetComponent<Shooter>();
    }

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        bool isJump = Input.GetButtonDown("Jump");

        if (horizontal < 0)
        {
            FlipXLeft();
            _shooter.EnergySpriteLeft();
        }
        else if (horizontal > 0)
        {
            FlipXRight();
            _shooter.EnergySpriteRight();
        }

        if (Input.GetButtonDown("Fire1"))
        {
            _shooter.Shoot(horizontal);
        }

        _playerMovement.Movement(horizontal, isJump);
    }

    private void FlipXRight()
    {
        Vector3 rotate = transform.eulerAngles;
        rotate.y = 0;
        transform.rotation = Quaternion.Euler(rotate);
    }

    private void FlipXLeft()
    {
        Vector3 rotate = transform.eulerAngles;
        rotate.y = 180;
        transform.rotation = Quaternion.Euler(rotate);
    }
}