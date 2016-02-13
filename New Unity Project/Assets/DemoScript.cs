using UnityEngine;
using System.Collections;

public class DemoScript : MonoBehaviour
{
    public class Cat
    {
        public int age;
        public int test2;
        public Color hairColor;

        public Cat()
        {
            age = 0;
            hairColor = Color.black;
        }

        public Cat(int _age, Color _hair)
        {
            age = _age;
            hairColor = _hair;
        }
    }

    // Use this for initialization
    void Start()
    {
        

        int num1 = 5;
        int num2 = num1;
        num2 = 100;

        Cat fluffy = new Cat(12, Color.gray);

        Func(num1, fluffy);

        //Debug.Log("num1 " + num1);
        //Debug.Log("fluffy " + fluffy.hairColor);

        fluffy.age = fluffy.test2 = 1000;
        Debug.Log("fluffy.age " + fluffy.age);
        Debug.Log("fluffy.test2 " + fluffy.test2);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Func(int _numb, Cat _cat)
    {
        _numb = 200;
        _cat.hairColor = Color.blue;
    }
}
