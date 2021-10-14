using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    void Start()
    {
        Book b1 = new Book();
        b1.title = "a history of programming languages";

        Book b2 = new Book();
        b2.title = "Java aint C";

        print("------------ initial values -----------");
        print("b1 = " + b1);
        print("b2 = " + b2);

        swap(ref b1, ref b2);
        print("------------ after attempted swap -----------");
        print("b1 = " + b1);
        print("b2 = " + b2);
    }

    public static void swap(ref Book object1, ref Book object2)
    {
        Book temp = object1;
        object1 = object2;
        object2 = temp;
    }

}
