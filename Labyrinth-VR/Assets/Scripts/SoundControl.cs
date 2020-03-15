using UnityEngine;

public class SoundControl : MonoBehaviour
{
    public AudioSource _MarbleHit;
    public AudioSource _BallRolling;
    private Rigidbody _ThisRigidBody;

    private void Start()
    {
        _ThisRigidBody = GetComponent<Rigidbody>();
    }

    /// <summary>
    /// Sound of ball rolling when the ball
    /// has certain amount of velocity.
    /// </summary>
    void Update()
    {
        
        if (!_BallRolling.isPlaying && _ThisRigidBody.velocity.magnitude > 1f)
        {
            _BallRolling.Play();
        }
        if (_ThisRigidBody.velocity.magnitude < 1f)
        {
            _BallRolling.Stop();
        }
        
    }

    /// <summary>
    /// Whenever the ball hits hard enough to make a sound
    /// play a specific sound.
    /// </summary>
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.impulse.magnitude > 2)
        {
            foreach (ContactPoint contact in collision.contacts)
            {
                if (contact.otherCollider.gameObject.CompareTag("Wall"))
                {
                    _MarbleHit.Play();
                }
            }
        }
    }
}
