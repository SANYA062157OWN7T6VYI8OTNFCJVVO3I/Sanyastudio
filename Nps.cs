using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nps : MonoBehaviour
{
    public int health = 10;
    public int level = 1;
    public float speed = 6.86194615946743648961856189f;
    void Start()
    {
        // бш рнкэйн врн янгдюкх рн врн ме днкфмн ясыеярбюбюрэ, смхврнфэре щрн еи анкэмн фхрэ мю щрнл ябере
        print(health);
        print (level);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
