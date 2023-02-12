using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repeat : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // el�z� �r�b�l:
        // vektorok;
        // sz�mol�s vektorokkal
        // update haszn�lata


        // hozzunk l�tre  vektorokat. Egy h�romdimenzi�sat (�gy kell mint a k�t dimenzi�sat)

        Vector3 my3dVectorX = new Vector3(3,3,3); // ez a vektor a z�r�jelben megadott poz�ci�ban helyezkedik el a "t�r" ben. 
        Vector3 my3dVectorY = new Vector3(4,7,12);

        //csin�ljunk  2 dimenzi�s vektorokat.

        Vector2 my2dVectorX = new Vector2(23,5);
        Vector2 my2dVectorY = new Vector2(55,6);


        //ezekkel matematikai m�veleteket v�gezhet�nk: Vector 2 vagy 2 d-s Vector 2 vagy 3d-ssel.
        //                                             Vector2 vagy 3 d-s oszt�sa / szorz�sa skal�rral, azaz sz�mmal.

        // Vector2  + Vector2 -> van k�t koordin�t�ja x,y x x el �s y y-al lesz �sszeadva vagy a kivon�s elv�gezve.

        // pl.: my3dVectorX + my3dVectorY = 3+4; 3+7; 3+12
        // pl.: my2dVectorX - my2dVectorY = 23-55; 5-6 =x= -32; y = -1  !!! a  t�vols�g ink�bb az, ha a nagyobb�l vonjuk ki a kisebbet

        Debug.Log(my2dVectorX - my2dVectorY);
        Debug.Log(my3dVectorX - my3dVectorY);


        // N�zz�nk hosszt: 
        Vector2 my2dVectorZ = new Vector2(3,4);
        float my2dVectorZmagnitude = my2dVectorZ.magnitude;
        Debug.Log(my2dVectorZmagnitude);


        float a = 3, b = 4;
        float m = a*a + b * b;
        float f = Mathf.Sqrt(m);
        Debug.Log(f); // �tfog�    f == my2dVectorZmagnitude a hossz(magnitude) = a valahonn�t (de elvileg nem null�b�l) indul� �s a koordintapontba mutat� vektor hossz�val.

        //Ezt szok�s egyenl�re szabni, hogy minden ir�nyba ugyanakkora hossz� legyen. normalze


        Vector3 v3d = new Vector3(3,5,10);

        Vector3 v3dNorm = v3d.normalized;
        Debug.Log(v3dNorm);

        Vector3 vektorpeldaI = new Vector3(3, 5, 10); 
        Vector3 normal = vektorpeldaI.normalized;
        Debug.Log(normal);


        //T�vsz�m�t�s: ehhez k�t vektort vesz�k �s ezek �sszehasonl�tott �rt�k�t egy m�sik Vektor veszi fel
        



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
