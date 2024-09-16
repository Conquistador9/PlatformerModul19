using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [Header("Jump Settings")]
    [SerializeField] Transform _legsCollider;
    [SerializeField] private LayerMask _layerMask;
    [SerializeField] private float _jumpOffset;
    [SerializeField] private float _jump;
    [SerializeField] private bool _isGrounded = false;

    [Header("Settings")]
    [SerializeField] private AnimationCurve _curve;
    private PlayerAnimations _animations;
    private Rigidbody2D _rb;


    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _animations = GetComponent<PlayerAnimations>();
    }

    private void FixedUpdate()
    {
        Vector3 overlapCirclePosition = _legsCollider.position;
        _isGrounded = Physics2D.OverlapCircle(overlapCirclePosition, _jumpOffset, _layerMask);

        JumpAnimCheck();
    }

    public void Movement(float horizontal, bool isJump)
    {
        if (isJump)
        {
            Jump();
        }

        if ((Mathf.Abs(horizontal) > 0.01f) && _isGrounded)
        {
            HorizontalMovement(horizontal);
            _animations.Run();
            _animations.JumpingEnd();
        }
        else
        {
            _animations.RunEnd();
        }
    }

    private void HorizontalMovement(float direction)
    {
        _rb.velocity = new Vector2(_curve.Evaluate(direction), _rb.velocity.y);
    }

    private void Jump()
    {
        if (_isGrounded)
        {
            _rb.velocity = new Vector2(_rb.velocity.x, _jump);
        }
    }

    private void JumpAnimCheck()
    {
        if (_isGrounded)
        {
            _animations.JumpingEnd();
        }
        else
        {
            _animations.Jumping();
        }
    }
}