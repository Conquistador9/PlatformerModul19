using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public void Run() => _animator.SetBool("Run", true);

    public void RunEnd() => _animator.SetBool("Run", false);

    public void Jumping() => _animator.SetBool("Jump", true);

    public void JumpingEnd() => _animator.SetBool("Jump", false);
}