using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public float speed;
    public SpriteRenderer spriteRenderer;

    CharacterState state;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        state = GetComponent<IdleState>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        var h = Input.GetAxis("Horizontal");
        var v = Input.GetAxis("Vertical");

        Move(new Vector3(h * speed, 0, v * speed));
    }

    void Move(Vector3 vector) {
        if (vector.magnitude == 0) {
            return;
        }

        animator.SetFloat("speed", vector.x);
        gameObject.transform.position += vector;
    }
}
