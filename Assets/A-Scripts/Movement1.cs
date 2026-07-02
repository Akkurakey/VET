using UnityEngine;

public class MoveToTarget1 : MonoBehaviour
{
    public Transform target; // Target position
    public float speed = 0.1f; // Movement speed
    private Animator animator; // Animator component
    private bool hasStartedMoving = false; // Flag to check if the movement has started
    private Vector3 initialPosition; // Initial position of the object

    void Start()
    {
        animator = GetComponent<Animator>(); // Get the Animator component
        initialPosition = transform.position; // Store the initial position
    }

    void Update()
    {
        float distanceToTarget = Vector3.Distance(transform.position, target.position);

        // Check if the object has moved from its initial position
        if (!hasStartedMoving)
        {
            if (Vector3.Distance(transform.position, initialPosition) > 0.01f)
            {
                hasStartedMoving = true; // Update the moving status
            }
        }

        if (hasStartedMoving)
        {
            if (distanceToTarget > 0.01f) // Continue moving if the distance to the target is greater than 0.1 units
            {
                Vector3 direction = (target.position - transform.position).normalized;
                transform.position += direction * speed * Time.deltaTime;
                animator.SetBool("IsWalking", true); // Play walking animation
            }
            else
            {
                animator.SetBool("IsWalking", false); // Play idle animation
            }

            transform.LookAt(target); // Make the front of the object always face the target
        }
    }
}
