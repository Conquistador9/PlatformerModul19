using System.Collections;
using UnityEngine;

public class FixedJointDeactive : MonoBehaviour
{
    private FixedJoint2D _fixedJoint;

    private void Awake()
    {
        _fixedJoint = GetComponent<FixedJoint2D>();
    }

    private void Update()
    {
        if(transform.position.y <= -2.5f)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            StartCoroutine(DeactiveTime());
        }
    }

    private IEnumerator DeactiveTime()
    {
        yield return new WaitForSeconds(0.5f);
        _fixedJoint.enabled = false;
    }
}