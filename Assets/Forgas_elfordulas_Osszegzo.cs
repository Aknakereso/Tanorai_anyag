
using UnityEngine;

public class Forgas_elfordulas_Osszegzo : MonoBehaviour
{
    [SerializeField] float spin;
    [SerializeField] Transform Target;
    // Update is called once per frame
    void Update()
    {
        // Az elfordul�st 'Quaternion' ban "n�zz�k.
        // ha van egy objektum, annak a Quaternion j�t lek�rhetj�k,
        // Ezt �tkonvert�lhatjuk Vector3 �,
        // ezek ut�n az �rt�keken alak�thatunk tengelyenk�nt,

        // ? majd vissza Quaternion ba?

        /* Tov�bb a Quaternion ment�n:
         * 
      
         */
        /*Egyik: "q4" -es
            Vector3 minta = new Vector3(10,20,1);    
            Quaternion q4 = Quaternion.AngleAxis(30,Vector3.up); // ezzel l�trehoztunk egy Quaterniont, de m�g nem forgunk
            Vector3 mintaB = q4.ToEulerAngles();               //konvert�l�s mert a lenti dolog nem t�r quaternion form�t
            transform.Rotate(mintaB); //  "m�k�dik" Vector-al, Quaternionnal NEM,
                                      // �s lassan is p�r�g Time.deltaime n�lk�l
       
         */



        /* q6 os: * Quaternonba rakjuk k�t vektor k�l�nbs�g�t (ir�nyVektor lesz ez); ezt a Quaternion �rt�ket hozz�rendelj�k a transform.rotation-hoz;
            Transform t = transform;
            Vector3 relativePos = t.position;
            Vector3 targetPos = Target.position;
            Vector3 iranyVektor = targetPos - relativePos;
            valami.Normalize();
            Quaternion qLookRotation = Quaternion.LookRotation(iranyVektor);  //ide akkor Vector(3) kell| nem tudom mire j�
            transform.rotation = qLookRotation; // itt quaternionnal ford�tottuk el a target fel�
         */



        /*    // q7-es Quaternion l�trehoz�s: ua mint q6
            Vector3 ownPos = transform.position;

            Vector3 targetPos = Target.position;
            Vector3 elfordulas = targetPos - ownPos;
            Quaternion q7 = Quaternion.LookRotation(elfordulas); // ha a z�r�jelbe rakok egy vektort amihez k�pest szeretn�m az elfodul�s�t, nem m�k�dik
            transform.rotation = q7; // Quaternion �rt�ket haszn�lva fordultunk el.
           */

        // Quaternionnal r� tuduk fordulni c�l objektumokra, amikre Transform (+ n�v)  k�nt utalunk serialized mez�ben



    
       

    }

}


