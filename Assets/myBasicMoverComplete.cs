
using UnityEngine;

public class myBasicMoverComplete : MonoBehaviour
{
   
    void Update()
    {
        Vector3 animar = InputInducator();
        MoveFromInput(animar);
            
    }
    Vector3 InputInducator()
    {
        bool forth = Input.GetKey(KeyCode.UpArrow);
        bool back = Input.GetKey(KeyCode.DownArrow);
        bool right = Input.GetKey(KeyCode.RightArrow);
        bool left = Input.GetKey(KeyCode.LeftArrow);

        bool climb = Input.GetKey(KeyCode.Space); 
        bool dive = Input.GetKey(KeyCode.LeftControl);

      
        float x = 0;
        float y = 0;
        float z = 0;

        if (forth)
        {
            z++;
        }
        if (back)
        {
            z--;
        }
        if (right)
        {
            x++;
        }
        if (left)
        {
            x--;

        }
        if (climb)
        {
            y++;

        }
        if (dive)
        {
            y--;

        }

        Vector3 control = new Vector3(x, y, z); 
        control.Normalize();
        return control;



    }
    void MoveFromInput(Vector3 control)
    {



        Transform modulePosition = transform;

        Vector3 moduleVector = modulePosition.position;


        moduleVector += control * 10 * Time.deltaTime;

        modulePosition.position = moduleVector;




    }
}
