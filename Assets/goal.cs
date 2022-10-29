using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goal : MonoBehaviour
{
    private bool is_collided = false;

    public float GOAL_MIN = 5.0f;
    public float GOAL_MAX = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        float rnd = Random.Range(GOAL_MIN, GOAL_MAX);
        this.transform.position = new Vector3(rnd, -1.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionStay(Collision other)
    {
        this.is_collided = true;
    }

    void OnGUI()
    {
        if (is_collided)
        {
            GUI.Label(new Rect(Screen.width / 2, 80, 100, 20), "성공");
        }
    }
}
