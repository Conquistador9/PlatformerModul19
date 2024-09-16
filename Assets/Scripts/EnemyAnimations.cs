using UnityEngine;

public class EnemyAnimations : MonoBehaviour
{
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public void EnemyAttackAnim()
    {
        _animator.SetTrigger("Attack");
    }
}