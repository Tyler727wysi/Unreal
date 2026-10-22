using Unity.VisualScripting;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour

{
    public float playerSpeed = 3;
    float horizontalInput = 0;
    float verticalInput = 0;
    Transform playerTransform;
    Vector3 playerPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerTransform = this.gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = (Input.GetAxis("Vertical"));
        horizontalInput = (Input.GetAxis("Horizontal"));

        if (horizontalInput != 0)
        {
            playerPosition.x += horizontalInput;
        }

        else if (verticalInput != 0)
        {
            playerPosition.z += verticalInput;
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            playerSpeed = 6;
        }

        else if (Input.GetKey(KeyCode.LeftControl))
        {
            playerSpeed = 1.5f;
        }

        else
        {
            playerSpeed = 3;
        }

        playerTransform.Translate(playerPosition.normalized * playerSpeed * Time.deltaTime, Space.World);
        playerPosition = Vector3.zero;

        Vector3 mouseDirection = Input.mousePosition - Camera.main.WorldToScreenPoint(this.transform.position);

        float angle = Mathf.Atan2(mouseDirection.x, mouseDirection.y) * Mathf.Rad2Deg;
        this.transform.rotation = Quaternion.Euler(0f, angle, 0f);
    }
}
