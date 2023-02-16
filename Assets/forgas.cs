
using UnityEngine;

public class forgas : MonoBehaviour
{
    [SerializeField] float angularSpeed = 180;

    // Update is called once per frame
    void Update()
    { // a villogashoz
        transform.Rotate(0, angularSpeed * Time.deltaTime, 0);
        


    }
}
