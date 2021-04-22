using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    // Configuration Parameters
    [SerializeField] Paddle paddle1;
    [SerializeField] float velocityX = 5f;
    [SerializeField] float velocityY = 15f;

    // State Variables
    Vector2 paddleToBallVector;
    bool hasStarted = false;

    // Start is called before the first frame update
    void Start() {
        paddleToBallVector = transform.position - paddle1.transform.position;
    }

    // Update is called once per frame
    void Update() {
        if(!hasStarted){
            LockBallToPaddle();
            LaunchBallOnClick();
        }
    }

    private void LockBallToPaddle() {
        // This will lock the ball to the paddle at the start of the round.
        Vector2 paddlePosition = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y);
        transform.position = paddleToBallVector + paddlePosition;
    }

    private void LaunchBallOnClick() {
        // When the user clicks the LMB, then the ball will be launched.

        // We use 0 here as 0 is often tied to the LMB
        if(Input.GetMouseButtonDown(0)) {
            hasStarted = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(velocityX, velocityY);
        }
    }
}
