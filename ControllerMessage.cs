using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace message
{
    class ControllerMessage
    {
        int[] flagIndex = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }; //int array used to store separate falgs fro each button
        int lengthOutput, index;        // int vales used to store lendex and index
        String output, previous;
        DateTime saveNow;
        DateTime saveNow1;
        DateTime savenow3;
        DateTime savenow4;
        DateTime savenow5;
        // logic when button '1' clicked in the non-predictive mode
        public string oneClick()
        {
            output = output + "1";
            return output;
        }
        // logic when # (space) pressed in the non-predictive mode
        public string spaceAhead()
        {
            output = output + " ";
            return output;
        }
        // logic when < * (backspace) pressed in the non-predictive mode
        public string backspace()
        {
            lengthOutput = output.Length;
            if (lengthOutput > 0)
            {
                output = output.Remove(lengthOutput - 1);
                return output;
            }
            else
            {
                return output;
            }
        }
        // logic when any button with 3 characters and one numeric character pressed in the non-predictive mode
        public string use(object sender, RoutedEventArgs e, string one, string two, string three, string four)
        {

            // Checking first string passed to select correct button's flagIndex value using index
            if (one.Equals("a"))
            {
                index = 0;
            }
            else if (one.Equals("d"))
            {
                index = 1;
            }
            else if (one.Equals("g"))
            {
                index = 2;
            }
            else if (one.Equals("j"))
            {
                index = 3;
            }
            else if (one.Equals("m"))
            {
                index = 4;
            }
            else if(one.Equals("t"))
            {
                index = 5;
            }
            // incrementing value of flagIndex to keep tab of which char to print next
            flagIndex[index] = flagIndex[index] + 1;
            // Setting current dateTime for latest mouse click based on flagIndex value
            if (flagIndex[index] % 4 == 1)
            {
                flagIndex[index] = 1;

                saveNow = DateTime.Now;
            }
            else if (flagIndex[index] % 4 == 2)
            {
                flagIndex[index] = 2;
                saveNow1 = DateTime.Now;
            }
            else if (flagIndex[index] % 4 == 3)
            {
                flagIndex[index] = 3;
                savenow3 = DateTime.Now;
            }
            else if (flagIndex[index] % 4 == 0)
            {
                flagIndex[index] = 4;
                savenow4 = DateTime.Now;
            }
            // Based on the flagIndex value and the previous mouseclick time, printing correct character.
             if (flagIndex[index] == 1)
            {
                output = output + one;
                previous = one;
                return output;
               
            }
             else if (flagIndex[index] == 2)
            {// if pressed after earlier click and in a gap of 1 sec
                if (saveNow1 <= saveNow.AddMilliseconds(1000) && one.Equals(previous))
                {
                    lengthOutput = output.Length;
                    output = output.Remove(lengthOutput - 1);
                    output = output + two;
                    previous = one;
                    return output;
                  
                }
                else
                {
                    output = output + one;

                    saveNow = saveNow1;
                    flagIndex[index] = 1;
                    previous = one;
                    return output;
                }
            }
            else if (flagIndex[index] == 3)
             {// if pressed after earlier click and in a gap of 1 sec
                if (savenow3 <= saveNow1.AddMilliseconds(1000) && one.Equals(previous))
                {
                    lengthOutput = output.Length;
                    output = output.Remove(lengthOutput - 1);
                    output = output + three;
                    previous = one;
                    return output;
                }
                else
                {
                    output = output + one;
                    saveNow = savenow3;
                    flagIndex[index] = 1;
                    previous = one;
                    return output;
                }
            }
            else if (flagIndex[index] == 4)
             {// if pressed after earlier click and in a gap of 1 sec
                if (savenow4 <= savenow3.AddMilliseconds(1000) && one.Equals(previous))
                {
                    lengthOutput = output.Length;
                    output = output.Remove(lengthOutput - 1);
                    output = output + four; 
                    flagIndex[index] = 0;
                    previous = one;
                    return output;
                }
                else
                {
                    output = output + one;    
                    saveNow = savenow4;
                    flagIndex[index] = 1;
                    previous = one;
                    return output;
                }
            }
            else
            {
                return output;
            }
          
        }

        // logic when any button with 4 characters and one numeric character pressed in the non-predictive mode
        public string use1(object sender, RoutedEventArgs e, string one, string two, string three, string four, string five)
        {

            // Checking first string passed to select correct button's flagIndex value using index
                if (one.Equals("p"))
                {
                    index = 6;
                }
                else if (one.Equals("w"))
                {
                    index = 7;
                }
            //incrementing the flagIndex value 
                flagIndex[index] = flagIndex[index] + 1;

                if (flagIndex[index] % 5 == 1)
                {
                    flagIndex[index] = 1;

                    saveNow = DateTime.Now;
                }

                else if (flagIndex[index] % 5 == 2)
                {
                    flagIndex[index] = 2;
                    saveNow1 = DateTime.Now;
                }
                else if (flagIndex[index] % 5 == 3)
                {
                    flagIndex[index] = 3;
                    savenow3 = DateTime.Now;
                }
                else if (flagIndex[index] % 5 == 4)
                {
                    flagIndex[index] = 4;
                    savenow4 = DateTime.Now;
                }
                else if (flagIndex[index] % 5 == 0)
                {
                    flagIndex[index] = 5;
                    savenow5 = DateTime.Now;
                }
              

                if (flagIndex[index] == 1)
                {
                    output = output + one;
                    previous = one;
                    return output;
                }
                else if (flagIndex[index] == 2)
                {// if pressed after earlier click and in a gap of 1 sec
                    if (saveNow1 <= saveNow.AddMilliseconds(1000) && one.Equals(previous))
                    {
                        lengthOutput = output.Length;
                        output = output.Remove(lengthOutput - 1);
                        output = output + two;
                        previous = one;
                        return output;
                    }
                    else
                    {
                        output = output + one;
                        saveNow = saveNow1;
                        flagIndex[index] = 1;
                        previous = one;
                        return output;
                    }
                }
                else if (flagIndex[index] == 3)
                {// if pressed after earlier click and in a gap of 1 sec
                    if (savenow3 <= saveNow1.AddMilliseconds(1000) && one.Equals(previous))
                    {
                        lengthOutput = output.Length;
                        output = output.Remove(lengthOutput - 1);
                        output = output + three;
                        previous = one;
                        return output;
                    }
                    else
                    {
                        output = output + one;
                        saveNow = savenow3;
                        flagIndex[index] = 1;
                        previous = one;
                        return output;
                    }
                }
                else if (flagIndex[index] == 4)
                {
                    if (savenow4 <= savenow3.AddMilliseconds(1000) && one.Equals(previous))
                    {
                        lengthOutput = output.Length;
                        output = output.Remove(lengthOutput - 1);
                        output = output + four;
                        previous = one;
                        return output;
                    }
                    else
                    {
                        output = output + one;
                        saveNow = savenow4;
                        flagIndex[index] = 1;
                        previous = one;
                        return output;
                    }
                }
                else if (flagIndex[index] == 5)
                {
                    if (savenow5 <= savenow4.AddMilliseconds(1000) && one.Equals(previous))
                    {
                        lengthOutput = output.Length;
                        output = output.Remove(lengthOutput - 1);
                        output = output + five;
                        flagIndex[index] = 0;
                        previous = one;
                        return output;
                    }
                    else
                    {
                        output = output + one;
                        saveNow = savenow5;
                        flagIndex[index] = 1;
                        previous = one;
                        return output;
                    }
                }
               else
                {
                    return output;
                }
                
        
            }
           
        
    
    }
}
