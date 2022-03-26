using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class generatorTest : MonoBehaviour
{

    [SerializeField] NameGenerator NameGenerator;
    [SerializeField] UnityEngine.UI.Text Text;
    int n = 0;

    // Start is called before the first frame update
    private void Start()
    {
        Text.text = "";
        for(int i = 0; i < 20; i++)
        {
            Text.text += NameGenerator.generateName() + " ";
        }
    }

    void FixedUpdate()
    {
    }
}
