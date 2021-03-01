using System;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class TimeMaximumDeltaTime : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    /*void Update()
    {
        Debug.Log(Time.maximumDeltaTime);
    }

    private void FixedUpdate()
    {
        Debug.Log(Time.maximumDeltaTime);
    }

    private void LateUpdate()
    {
        Debug.Log(Time.maximumDeltaTime); // late update and update function number of calling in times are equal
    }*/


    private readonly string _str = "1+2+34+56";
    private string _constring = "";
    private List<string> _signSepartorArry;

    private string[] _strArray;

    

    private void OnEnable()
    {
        _strArray = new string[_str.Length];

        for (var i = 0; i < _str.Length; i++) _strArray[i] = Convert.ToString(_str[i]);

        for (var i = 0; i < _strArray.Length; i++)
        {
            for (var j = i+1; j < _strArray.Length; j++)
            {
                if (_strArray[i] == "+")
                {
                    print(_strArray[i]);
                    _constring = "";
          
                }
                else
                {
               
                    _constring +=_strArray[i];
                    print(_constring);

                }
            }

            
            
           
        }

        for (int i = 0; i < _signSepartorArry.Count; i++)
        {
            
           // print(_signSepartorArry[i]);
            
        }
    }
    }
