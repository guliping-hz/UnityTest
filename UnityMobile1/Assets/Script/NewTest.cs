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

    public Vector3 direct;
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
                GameObject obj = Instantiate(myPrefab, new Vector3(i, j, 0), Quaternion.identity);
                //点击日志可定位到此对象
                Debug.LogWarning("I'm here y=" + obj.transform.position + ",up=" + Vector3.up, obj);
                //画一条离地面的垂直的线
                // Debug.DrawLine(obj.transform.position, obj.transform.position - Vector3.up * obj.transform.position.y, Color.green, 10000);
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

        // direct.magnitude
        Debug.DrawLine(transform.position, transform.position - Vector3.up * transform.position.y, Color.green, 4);
    }

    void OnDrawGizmosSelected()
    {
        // 选中的时候展示一个黄色的立方体
        // 在变换位置绘制一个黄色立方体
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(transform.position, new Vector3(5, 5, 5));
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.DrawLine(new Vector3(2, 2, 0), new Vector3(2, 0, 0), Color.magenta, 4);
        // Debug.DrawRay(new Vector3(0, 0, 0), new Vector3(2, 2, 0), Color.magenta, 4);
    }
}
