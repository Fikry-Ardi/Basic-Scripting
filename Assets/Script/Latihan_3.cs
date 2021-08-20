using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Latihan_3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int C = Jumlah(60, 40);
        Debug.Log("Hasil Jumlah a dan b adalah " + C);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /// <summary>
    /// fungsi jumlah untuk menjumlahkan int A dan B
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    int Jumlah(int a, int b)
    {
        return a + b;
    }
}
