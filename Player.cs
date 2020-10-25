using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public float movspeed = 600f;
    float movment;

    // Update is called once per frame
    void Update()
    {
        movment = Input.GetAxisRaw("Horizontal");
    }

    public void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, movment * Time.fixedDeltaTime*- movspeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
