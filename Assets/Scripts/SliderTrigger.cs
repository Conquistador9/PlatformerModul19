using UnityEngine;

public class SliderTrigger : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private SliderJoint2D _sliderJoint;
    [SerializeField] private Rigidbody2D _rb;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            _rb.bodyType = RigidbodyType2D.Dynamic;
            _sliderJoint.enabled = true;
        }
    }
}