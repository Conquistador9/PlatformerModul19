using System.Collections;
using UnityEngine;

public class EnemyAttackRange : MonoBehaviour
{
    [Header("Setting")]
    [SerializeField] private float _attackRange = 0.44f;
    private EnemyAnimations _enemyAnim;
    private Transform _player;
    private float _damage = 50f;
    private float _attackCoolDown = 1f;
    private bool _canAttack = true;

    private void Awake()
    {
        _player = GameObject.FindGameObjectWithTag("Player").transform;
        _enemyAnim = GetComponent<EnemyAnimations>();
    }

    private void Update()
    {
        if(_player == null)
        {
            return;
        }

        float distance = Vector2.Distance(transform.position, _player.position);

        if (distance <= _attackRange)
        {
            if (_canAttack)
            {
                _enemyAnim.EnemyAttackAnim();
                StartCoroutine(AttackCoolDown());
            }
        }
    }

    public void EnemyDamage()
    {
        if(_player != null)
        {
            _player.GetComponent<PlayerHelth>().TakeDamage(_damage);
            _canAttack = true;
        }
    }

    private IEnumerator AttackCoolDown()
    {
        _canAttack = false;

        yield return new WaitForSeconds(_attackCoolDown);

        _canAttack = true;
    }
}