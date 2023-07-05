using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewTest : MonoBehaviour
{
    //定义Inspect属性
    public string myName;

    string myName2;
    static public string myName3;

    public GameObject myPrefab;
    public int width = 1;
    public int height = 1;

    public GameObject myPrefab2;
    public int count = 20;
    public float radius = 5f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Glp Start:" + myName);

        System.Reflection.MemberInfo info = typeof(NewTest);
        object[] attributes = info.GetCustomAttributes(true);

        for (int i = 0; i < attributes.Length; i++)
        {
            Debug.Log(attributes[i]);
        }

        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                // 实例化为位置 (0, 0, 0) 和零旋转。
                Instantiate(myPrefab, new Vector3(i, j, 0), Quaternion.identity);
            }
        }

        for (int i = 0; i < count; i++)
        {
            float angle = Mathf.PI * 2 * i / count;
            float x = Mathf.Cos(angle) * radius;
            float z = Mathf.Sin(angle) * radius;
            Vector3 pos = transform.position + new Vector3(x, 0, z);
            float degree = angle * Mathf.Rad2Deg;
            Quaternion rot = Quaternion.Euler(0, degree, 0);
            Instantiate(myPrefab2, pos, rot);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
