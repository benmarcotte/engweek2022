using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameGenerator : MonoBehaviour
{
    int _maxSyllables = 8;
    int nSyllables;
    string generatedName = "";
    string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "qu", "r", "s", "t", "v", "w", "x", "y", "z", "th", "ch", "sh" };
    string[] vowels = { "a", "e", "i", "o", "u", "y" };
    
    // Start is called before the first frame update
    string getVowel()
    {
        return vowels[Random.Range(0, vowels.Length)];
    }

    string getConsonant()
    {
        return consonants[Random.Range(0, consonants.Length)];
    }

    string generateSyllable()
    {
        string tempSyllable = "";
        if (generatedName == "")
        {
            if(Random.Range(0,2) == 1)
            {
                tempSyllable += getVowel();
                if(Random.Range(0, 9) == 1)
                {
                    tempSyllable += getVowel();
                }
            }
            else
            {
                tempSyllable += getConsonant();
                if(Random.Range(0, 20) == 0)
                {
                    tempSyllable += getConsonant();
                }
                tempSyllable += getVowel();
            }
        }
        else
        {
            tempSyllable += getConsonant();
            if (Random.Range(0, 20) == 0)
            {
                tempSyllable += getConsonant();
            }
            tempSyllable += getVowel();
        }
        return tempSyllable;
    }

    public string generateName()
    {
        nSyllables = 0;
        generatedName = "";
        generatedName += generateSyllable();
        nSyllables++;
        while(nSyllables <= _maxSyllables)
        {
            float n = Random.Range(0, nSyllables) * Random.Range(0f, 0.7f);
            if (n < 1.5f)
            {
                string t = generateSyllable();
                Debug.Log(n);
                generatedName += t;
                nSyllables++;
            }
            else
            {
                return generatedName;
            }
        }
        return generatedName;
    }
}
