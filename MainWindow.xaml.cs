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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        modelMessage d = new modelMessage();
        public MainWindow()
        {  
            InitializeComponent();
            
            string line;
            string words;
           // loading of Dictionary
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\Swanand\Desktop\words.txt");
            while ((line = file.ReadLine()) != null)
            {
                words = line;
                d.buildTrie(words);   //building Trie for each word in dictionary
            }
            Console.WriteLine( "done" );
        }
     string digit="";
    //modelMessage b = new modelMessage();
    //object of Controller
     ControllerMessage a = new ControllerMessage();
    // output string--Actual typed output
     String outputStore;
    // output string--Predicted output
     string outputStore2;
    // Event to handle button "2 abc"
     private void click_Click(object sender, RoutedEventArgs e)
        {
            if (check1.IsChecked==true) // if non-predictive checkbox=checked
            {
                // call controller logic
                outputStore = a.use(sender, e, "a", "b", "c", "2");
                //Logic to restrict size of output shown in the textbox.
                if(outputStore.Length<32)
                {
                    Scre.Text = outputStore;   
                }
                else
                {
                    outputStore = outputStore.Substring(outputStore.Length - 32);
                    Scre.Text = outputStore;
                }
            }
            else // if Predictive-->checkbox=Unchecked
            {
                digit = digit + "2";
                // passing string of digits pressed in the predictive mode
                outputStore2 = d.showWords(digit);
                //Logic to restrict size of output shown in the textbox.
                if (outputStore2.Length < 45)
                {
                    textboxup.Text = outputStore2;
                }
                else
                {
                    outputStore2 = outputStore2.Substring(outputStore2.Length - 45);
                    textboxup.Text = outputStore2;
                }
                

            }
        }
     // Event to handle button backspace "* <"
        private void back_Click(object sender, RoutedEventArgs e)
        {
            if (check1.IsChecked == true) // non -predictive
            {
                outputStore = a.backspace();
                if (outputStore.Length < 32)
                {
                    Scre.Text = outputStore;
                }
                else
                {
              
                    outputStore = outputStore.Substring(outputStore.Length - 32);
                    Scre.Text = outputStore;
                }
            }
            else //predictive
            {
                int size;
                string temp="";
                string[] s1 = outputStore.Split(' ');
                size = s1.Length;
                for(int i=0;i<size-1;i++)               //code to go back one whole word in predictive
                {
                    temp = temp + " " + s1[i];
                }
                outputStore = temp;
                Scre.Text = outputStore;
            }
        }
        // Event to handle button space "#"
        private void spaceahead_Click(object sender, RoutedEventArgs e)
        {

            if (check1.IsChecked == true)
            {
                outputStore = a.spaceAhead();
                if (outputStore.Length < 32)
                {
                    Scre.Text = outputStore;
                }
                else
                {
                    outputStore = outputStore.Substring(outputStore.Length - 32);
                    Scre.Text = outputStore;
                }
            }
            else
            {
                outputStore += " ";
                Scre.Text = outputStore;
            }
            
           
            
        }
        // Event to handle button "3 def"
        private void two_Click(object sender, RoutedEventArgs e)
        {
            if (check1.IsChecked == true)
            {
                outputStore = a.use(sender, e, "d", "e", "f", "3");
                if (outputStore.Length < 32)
                {
                    Scre.Text = outputStore;
                }
                else
                {
                    outputStore = outputStore.Substring(outputStore.Length - 32);
                    Scre.Text = outputStore;
                }
            }
            else
            {
                digit = digit + "3";
                outputStore2 = d.showWords(digit);
                if (outputStore2.Length < 45)
                {
                    textboxup.Text = outputStore2;
                }
                else
                {
                    outputStore2 = outputStore2.Substring(outputStore2.Length - 45);
                    textboxup.Text = outputStore2;
                }

            }
        }
        // Event to handle button "4 ghi"
        private void three_Click(object sender, RoutedEventArgs e)
        {
            if (check1.IsChecked == true)
            {
                outputStore = a.use(sender, e, "g", "h", "i", "4");
                if (outputStore.Length < 32)
                {
                    Scre.Text = outputStore;
                }
                else
                {
                    outputStore = outputStore.Substring(outputStore.Length - 32);
                    Scre.Text = outputStore;
                }

            }
            else
            {
                digit = digit + "4";
                outputStore2 = d.showWords(digit);
                if (outputStore2.Length < 45)
                {
                    textboxup.Text = outputStore2;
                }
                else
                {
                    outputStore2 = outputStore2.Substring(outputStore2.Length - 45);
                    textboxup.Text = outputStore2;
                }

            }
        }
        // Event to handle button "5 jkl"
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (check1.IsChecked == true)
            {
                outputStore = a.use(sender, e, "j", "k", "l", "5");
                if (outputStore.Length < 32)
                {
                    Scre.Text = outputStore;
                }
                else
                {
                    outputStore = outputStore.Substring(outputStore.Length - 32);
                    Scre.Text = outputStore;
                }

            }
            else
            {
                digit = digit + "5";
                outputStore2 = d.showWords(digit);
                if (outputStore2.Length < 45)
                {
                    textboxup.Text = outputStore2;
                }
                else
                {
                    outputStore2 = outputStore2.Substring(outputStore2.Length - 45);
                    textboxup.Text = outputStore2;
                }

            }
        }
        // Event to handle button "6 mno"
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (check1.IsChecked == true)
            {
                outputStore= a.use(sender, e, "m", "n", "o", "6");
                if (outputStore.Length < 32)
                {
                    Scre.Text = outputStore;
                }
                else
                {
                    outputStore = outputStore.Substring(outputStore.Length - 32);
                    Scre.Text = outputStore;
                }
            }
            else
            {
                digit = digit + "6";
                outputStore2 = d.showWords(digit);
                if (outputStore2.Length < 45)
                {
                    textboxup.Text = outputStore2;
                }
                else
                {
                    outputStore2 = outputStore2.Substring(outputStore2.Length - 45);
                    textboxup.Text = outputStore2;
                }

            }
        }
        // Event to handle button "9 wxyz"
        private void nine_Click(object sender, RoutedEventArgs e)
        {
            if (check1.IsChecked == true)
            {
                outputStore = a.use1(sender, e, "w","x", "y", "z", "9");
                if (outputStore.Length < 32)
                {
                    Scre.Text = outputStore;
                }
                else
                {
                    outputStore = outputStore.Substring(outputStore.Length - 32);
                    Scre.Text = outputStore;
                }
            }
            else
            {
                digit = digit + "9";
                outputStore2 = d.showWords(digit);
                if (outputStore2.Length < 45)
                {
                    textboxup.Text = outputStore2;
                }
                else
                {
                    outputStore2 = outputStore2.Substring(outputStore2.Length - 45);
                    textboxup.Text = outputStore2;
                }

            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (check1.IsChecked == true)
            {
                outputStore = a.oneClick();
                if (outputStore.Length < 32)
                {
                    Scre.Text = outputStore;
                }
                else
                {
                    outputStore = outputStore.Substring(outputStore.Length - 32);
                    Scre.Text = outputStore;
                }
            }
        }
        // Event to handle button "7 pqrs"
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (check1.IsChecked == true)
            {
                outputStore = a.use1(sender, e, "p", "q", "r", "s", "7");
                if (outputStore.Length < 32)
                {
                    Scre.Text = outputStore;
                }
                else
                {
                    outputStore = outputStore.Substring(outputStore.Length - 32);
                    Scre.Text = outputStore;
                }
            }
            else
            {
                digit = digit + "7";
                outputStore2 = d.showWords(digit);
                if (outputStore2.Length < 45)
                {
                    textboxup.Text = outputStore2;
                }
                else
                {
                    outputStore2 = outputStore2.Substring(outputStore2.Length - 45);
                    textboxup.Text = outputStore2;
                }

            }
        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (check1.IsChecked == true)
            {
                outputStore = a.use(sender, e, "t", "u", "v", "8");
                if (outputStore.Length < 32)
                {
                    Scre.Text = outputStore;
                }
                else
                {
                    outputStore = outputStore.Substring(outputStore.Length - 32);
                    Scre.Text = outputStore;
                }
            }
            else
            {
                digit = digit + "8";
                outputStore2 = d.showWords(digit);
                if (outputStore2.Length < 45)
                {
                    textboxup.Text = outputStore2;
                }
                else
                {
                    outputStore2 = outputStore2.Substring(outputStore2.Length - 45);
                    textboxup.Text = outputStore2;
                }

            }
        }
        //button 0/~ zero.. go to next
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
          
            if (check1.IsChecked == false)
            {
                int size;
                string temp1 = "";
                string[] s = outputStore2.Split(' ');
                size = s.Length;
                for (int i = 1; i < size; i++)
                {
                    temp1 = temp1 + " " + s[i];
                }
                outputStore2 = temp1;
                textboxup.Text = outputStore2;
                outputStore = outputStore + " " + s[0];
                Scre.Text = outputStore;
                digit = "";
                d.initDisplay();

                
             }
          
        }

       
       
       

      
    }
    
    
    
    
    }
        
      
    

