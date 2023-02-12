
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class mover : MonoBehaviour
{
    [SerializeField] Vector3 velocity;
    [SerializeField] float speed;
    
    // Update is called once per frame
    void Update()
    {
        Vector3 d = GetInputDirection();
        VektorMozgas(d);



        //__________Forgas
        

       

    }

    Vector3 GetInputDirection()
    {
        bool up = Input.GetKey(KeyCode.UpArrow);
        bool down = Input.GetKey(KeyCode.DownArrow);

        bool left = Input.GetKey(KeyCode.LeftArrow);
        bool right = Input.GetKey(KeyCode.RightArrow);

        float x = 0;
        float z = 0;

        if (right)
            x += 1;
        if (left)
            x -= 1;



        if (up)
            z += 1;
        if (down)
            z -= 1;


Vector3 direction = new Vector3(x, 0, z);
        direction.Normalize();

        return direction;

        
    }

    void VektorMozgas(Vector3 direction)
    {  
        Transform t = transform;



        Vector3 pos = t.position;


        Vector3 velocity = direction * speed;
        pos += velocity * Time.deltaTime;

        t.position = pos;

        Quaternion rotation = t.rotation;
        t.rotation = Quaternion.LookRotation(direction);

        if (direction == Vector3.zero)
            t.rotation = Quaternion.LookRotation(direction);





    }
}
