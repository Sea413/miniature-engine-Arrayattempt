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
      ['','','',]
      int[] numarray = new int [50];
      char[] outputted = _replacementword.ToCharArray();
      //outputted = ['a']
      char[] inputted = _designatedword.ToCharArray();
      // //inputted = ['n','o','t']
      char[] array = _sentence.ToCharArray();
      //array = ["T','h', 'i', 's", "is", "not", "test"]
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
      // storearray = ['','','','','','n','o','t','','','']
      //num array = [0,,,,,5,6,7]

      for (int i = 0; i < numarray.Length; i++)
      {
        // numarray[i] = numarray[0]
        int replacecoord = numarray[i];
        array[replacecoord] = outputted[i];
        //
      }
      return array.ToString();
    }
    }

  }
