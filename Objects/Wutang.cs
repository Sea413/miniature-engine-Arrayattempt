using System;
using System.Linq;
using System.Collections.Generic;

namespace FindReplaceNameSpace
{
  public class Wutang
  {
    private string _sentence;
    private string _designatedword;
    private string _replacementword;


    public Wutang(string sentence, string desigword, string replacword)
    {
      _sentence = sentence;
      _designatedword =desigword;
      _replacementword = replacword;
    }

    public string ArrayShift()
    {
      char[] storearray = new char[50];
      int[] numarray = new int [50];
      char[] outputted = _replacementword.ToCharArray();
      char[] inputted = _designatedword.ToCharArray();
      char[] array = _sentence.ToCharArray();
      int inputtedtest = 0;
      for (int i = 0; i < array.Length; i++)
      {
        if (array[i] == inputted[inputtedtest])
        {
          storearray[inputtedtest] = array[i];
          numarray[inputtedtest]= i;
          inputtedtest++;
          // torearray[i]=array[i];

          Console.WriteLine("Length of arrays "+ " " + array.Length +  " "  + outputted.Length + " "  + inputted.Length + " " + numarray.Length);
            Console.WriteLine(storearray[inputtedtest]);
        }
      }

      for (int i = 0; i < numarray.Length; i++)
      {
        int replacecoord = numarray[i];
        array[replacecoord] = outputted[i];
      }
      return array.ToString();
    }
    }

  }
