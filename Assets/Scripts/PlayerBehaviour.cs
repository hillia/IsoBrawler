using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public float speed;
    public SpriteRenderer spriteRenderer;
    public Sprite idleSprite;
    public Sprite moveSprite;
    public Sprite moveForwardSprite;
    public Sprite moveBackwardSprite;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        if ((h != 0 || v != 0) && h >= 0)
        {
            spriteRenderer.sprite = moveForwardSprite;
        }
        else if ((h != 0 || v != 0) && h < 0)
        {
            spriteRenderer.sprite = moveBackwardSprite;
        }
        else
        {
            spriteRenderer.sprite = idleSprite;
        }

        gameObject.transform.position =
            new Vector3(
                transform.position.x + (h * speed),
                transform.position.y,
                transform.position.z + (v * ZSpeed())
            );
    }

    float ZSpeed() {
        return speed;
    }
}
