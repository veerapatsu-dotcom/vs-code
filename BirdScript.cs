using UnityEngine;
using UnityEngine.InputSystem;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float jumpForce = 5f;

    void Start()
{
    myRigidbody = GetComponent<Rigidbody2D>();
}

    void Update()
  {
      if (Keyboard.current.spaceKey.wasPressedThisFrame)
      {
          myRigidbody.linearVelocity = new Vector2(0, jumpForce * 2);
      }
  }
}