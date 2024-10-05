using UnityEngine;

public class Shooter : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private GameObject _fireEnergy;
    [SerializeField] private Transform _firePoint;

    [Header("Setting")]
    [SerializeField] private float _fireSpeed;

    private void Awake()
    {
        EnergySpriteRight();
    }

    public void Shoot(float direction) 
    {
        GameObject currentBullet = Instantiate(_fireEnergy, _firePoint.position, Quaternion.identity);
        Rigidbody2D currentBulletVelocity = currentBullet.GetComponent<Rigidbody2D>();
        Vector3 line;

        if (direction >= 0)  
        {
            currentBulletVelocity.velocity = new Vector2(_fireSpeed * 1, currentBulletVelocity.velocity.y);
        }
        else
        {
            currentBulletVelocity.velocity = new Vector2(_fireSpeed * -1, currentBulletVelocity.velocity.y);
        }

        if(transform.localScale.x < 0)
        {
            line = -_firePoint.right;
        }
        else
        {
            line = _firePoint.right;
        }

        currentBulletVelocity.GetComponent<Rigidbody2D>().velocity = line * _fireSpeed;
    }

    public void EnergySpriteRight() => _fireEnergy.GetComponent<SpriteRenderer>().flipX = false;

    public void EnergySpriteLeft() => _fireEnergy.GetComponent<SpriteRenderer>().flipX = true;
}