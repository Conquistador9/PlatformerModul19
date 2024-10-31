using UnityEngine;

public class PrincessAnimations : MonoBehaviour
{
    private Animator _anim;

    private void Awake()
    {
        _anim = GetComponent<Animator>();
    }

    public void PrincessUp() => _anim.SetTrigger("Up");

    public void Idle() => _anim.SetTrigger("Idle");
}