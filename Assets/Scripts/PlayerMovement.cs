using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    private bool alive = true;
    public float speed = 10;
    public Rigidbody rb;
    public float horizontalInput;
    private float horizontalMultiplier = 2;

    private void FixedUpdate()
    {
        if (!alive) return;
        
        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime * horizontalMultiplier;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);
    }

    public void Die()
    {
        alive = false;
        Invoke("Restart",1);
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        if (transform.position.y < -5)
        {
            Die();
        }
    }
}
