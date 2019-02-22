    using UnityEngine;
    using System.Collections;
     
    public class playerMovement : MonoBehaviour {
     
        public float speed;
        public float jump;
        public GameObject rayOrigin;
        public float rayCheckDistance;
        public Rigidbody2D rb;
        public bool jumping;
        private float jumpDelay;
     
        void Start () {
            //rb = GetComponent <Rigidbody2D> ();
        }
     
        void FixedUpdate () {
            float x = Input.GetAxis ("Horizontal");
            if (Input.GetAxis ("Jump") > 0) {
                RaycastHit2D hit = Physics2D.Raycast(rayOrigin.transform.position, Vector2.down, rayCheckDistance);
                if (hit.collider != null) {
                    
                    rb.AddForce (Vector2.up * jump, ForceMode2D.Impulse);
                }
                
            }
            rb.velocity = new Vector3 (x * speed, rb.velocity.y, 0);
     
        }
    }

