using UnityEngine.UI;
using System.Collections;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    public float speed;  //Allows us to change the spped within the editor
    private Rigidbody rb;  //Allows us access to RigidBody
    private int count;
    public Text countText;
    public GameManager gameManager;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Collectible"))
        {
            other.gameObject.SetActive(false);
            count += 1;
            SetCountText();
            End();
        }
    } //This will deactivate the collectible game objects when we make contact with them

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
    }

    void End()
    {
        if(count == 8)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
