using UnityEngine;

public class EnemyAnimations : MonoBehaviour
{
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public void EnemyIdle() => _animator.SetBool("Walk", false);

    public void EnemyAttackAnim() => _animator.SetTrigger("Attack");

    public void EnemyWalk() => _animator.SetBool("Walk", true);
}