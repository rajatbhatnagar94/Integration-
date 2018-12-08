using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Integration2.Resources;
using Jace;
using Coding4Fun.Toolkit.Controls;
using System.Windows.Shapes;
using System.Windows.Media;


namespace Integration2
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            BuildLocalizedApplicationBar();
        }

        private void BuildLocalizedApplicationBar()
        {
            ApplicationBar = new ApplicationBar();
            ApplicationBarIconButton Integrate = new ApplicationBarIconButton();
            Integrate.IconUri = new Uri("/Assets/appbar.calculator.png", UriKind.Relative);
            Integrate.Text = "Integrate";
            Integrate.Click += Integrate_Click;
            ApplicationBar.Buttons.Add(Integrate);
            ApplicationBarMenuItem appBarHelp = new ApplicationBarMenuItem("Help");
            ApplicationBar.MenuItems.Add(appBarHelp);
            
            appBarHelp.Click += appBarHelp_Click;
        }

        void appBarHelp_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Help.xaml",UriKind.Relative));
        }

        void Integrate_Click(object sender, EventArgs e)
        {
            {
            if (result.Text == "")
            {
                MessageBox.Show("Enter the Expression!!");
                return;
            }
            flag = 1;
            string k = result.Text;
            int c = 0;
            k = k.Replace(" ", "");
            ShowValues();
            if (a == -6567 && b == -6567)
            {
                MessageBox.Show("Enter the limits!!");
                return;
            }
            if (a == -6567)
            {
                MessageBox.Show("Enter the lower limit!!");
                return;
            }
            if (b == -6567)
            {
                MessageBox.Show("Enter the Upper limit!!");
                return;
            }

            //See for expressions like 1+y, (1+y)/y, 3y+1+y , y,Log(y,10) , Sin(3X) Sin(x)->See
            try
            {
                while (true)
                {
                    if (k.Contains("y"))
                    {
                        int j = k.IndexOf("y");
                        if (j == 0)
                        {
                            k = k.Insert(j, "~");
                            k = k.Remove(k.IndexOf('y'), 1);
                            continue;
                        }
                        if (!(k.ElementAt(j - 1) == '+' || k.ElementAt(j - 1) == '-' || k.ElementAt(j - 1) == '/' || k.ElementAt(j - 1) == '*' ||
                            k.ElementAt(j - 1) == '('))
                        {
                            k = k.Insert(j, "*" + "~");
                            k = k.Remove(k.IndexOf('y'), 1);
                        }
                        else
                        {
                            k = k.Insert(j, "~");
                            k = k.Remove(k.IndexOf('y'), 1);
                        }
                    }
                    else break;
                }

            }
            catch (Exception)
            {
                throw;
            }


            int n = 0;
            double h = b - a;
            if (h <= 100)
            {
                n = 1000;
            }
            else n = 1000;

            h = h / n;

            //values = new double[b-a+1];
            values = new double[n + 1];

            for (double i = a; i <= b; i = i + h)
            {
                string temp = k.Replace("~", i.ToString());

                CalculationEngine engine = new CalculationEngine();
                try
                {
                    double func = engine.Calculate(temp);
                    if (func.ToString().Contains('E'))
                    {
                        func = 0;
                    }
                    if (func.ToString().Equals("Infinity")||func.ToString().Equals("-Infinity"))
                    {
                        func = 0;
                    }

                    values[c] = new double();
                    values[c] = func;
                }
                catch (Exception)
                {
                    result.FontSize = 30;
                    result1.FontSize = 30;
                    result.Text = "Format Not Correct";
                    flag = 1;
                    return;
                }
                c++;
            }

            Integrate(values);
            result1.Text = result.Text;
            result.FontSize = 30;
            result1.FontSize = 30;
        }
        }

        string[] prev = new string[80]; int top = -1;
        double a = -6567, b = -6567, flag = 0, vari = -6567;
        public double[] values;  //int a = 1, b = 10;

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }
        
        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            Button pressed = sender as Button;
            if (top == 79)
            {
                return;
            }

            result.Text += pressed.Content;
            result1.Text = result.Text;
            flag = 0;
            checkHeightTb();
            //If brackets are pressed then previous argument is not saved else it is saved.
            if (pressed.Content.ToString().Equals(")") || pressed.Content.ToString().Equals("("))
                return;
            prev[++top] = pressed.Content.ToString();
        }

        private void checkHeightTb()
        {
            if (result.Text.Length < 13)
            {
                result.FontSize = 50;
                result1.FontSize = result.FontSize;
            }
            else if (result.Text.Length >= 13 && result.Text.Length < 16)
            {
                result.FontSize = 40;
                result1.FontSize = result.FontSize;
            }
            else if (result.Text.Length >= 16 && result.Text.Length < 21)
            {
                result.FontSize = 30;
                result1.FontSize = result.FontSize;
            }
            else
            {
                result.FontSize = 20;
                result1.FontSize = result.FontSize;
            }

        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            result.FontSize = 50;
            result1.FontSize = 50;
            result.Text = "";
            result1.Text = result.Text;
            top = -1;
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (flag == 1)
            {
                result.Text = "";
                result.FontSize = 50;
                result1.FontSize = 50;
                flag = 0;
                top = -1;
                return;
            }
            if (result.Text == "")
            {
                result.FontSize = 50;
                result1.FontSize = 50;
                top = -1;
                return;
            }

            int j = -1;
            //Check if top ==-1
            if (top < 0)
            {
                top = -1;
                result.Text = "";
                return;
            }
            switch (prev[top])
            {
                case "Tan": j = result.Text.LastIndexOf("Tan"); top--; break;
                case "Sin": j = result.Text.LastIndexOf("Sin"); top--; break;
                case "Cos": j = result.Text.LastIndexOf("Cos"); top--; break;
                case "Acos": j = result.Text.LastIndexOf("Acos"); top--; break;
                case "Asin": j = result.Text.LastIndexOf("Asin"); top--; break;
                case "Atan": j = result.Text.LastIndexOf("Atan"); top--; break;
                case "Log10": j = result.Text.LastIndexOf("Log10"); top--; break;
                case "Loge": j = result.Text.LastIndexOf("Loge"); top--; break;
                case "PI": j = result.Text.LastIndexOf("PI"); top--; break;
                default: j = -1;
                    break;
            }

            if (j == -1)
            {
                if (!(result.Text.Substring(result.Text.Length - 1, 1) == ")"))
                    top--;
                result.Text = result.Text.Remove(result.Text.Length - 1);
            }
            else
            {
                result.Text = result.Text.Remove(j, result.Text.Length - j);
            }
            checkHeightTb();
            result1.Text = result.Text;
        }

        private void Integrate(double[] val)
        {
            //Check if it is log or Asin(0) or 
            int n = 0;
            double h = b - a;
            n = 1000;

            h = h / n;
            double answer = 0;
            for (int i = 1; i < val.Length - 1; i++)
            {
                answer += val[i];
            }
            answer = answer * 2;
            answer += (val[0] + val[val.Length - 1]);
            answer = (answer) / 2.0;
            answer = answer * h;
            if (answer.ToString().Equals("NaN"))
            {
                result.Text = "Math Error";
                return;
            }
            result.Text = answer.ToString();
            result1.Text = result.Text;
        }

        private void EvaluateFunction(object sender, RoutedEventArgs e)
        {
            if (result.Text == "")
            {
                MessageBox.Show("Enter the Expression!!");
                return;
            }
            flag = 1;
            string k = result.Text;
            k = k.Replace(" ", "");
            int contains = 0;
            //See for expressions like 1+y, (1+y)/y, 3y+1+y , y,Log(y,10) , Sin(3X) Sin(x)->See

            while (true)
            {
                if (k.Contains("y"))
                {
                    contains = 1;
                    int j = k.IndexOf("y");
                    if (j == 0)
                    {
                        k = k.Insert(j, "~");
                        k = k.Remove(k.IndexOf('y'), 1);
                        continue;
                    }
                    if (!(k.ElementAt(j - 1) == '+' || k.ElementAt(j - 1) == '-' || k.ElementAt(j - 1) == '/' || k.ElementAt(j - 1) == '*' ||
                        k.ElementAt(j - 1) == '('))
                    {
                        k = k.Insert(j, "*" + "~");
                        k = k.Remove(k.IndexOf('y'), 1);
                    }
                    else
                    {
                        k = k.Insert(j, "~");
                        k = k.Remove(k.IndexOf('y'), 1);
                    }
                }
                else break;
            }


            if (contains == 1)
            {
                //Ask the value of y
                ShowValues();
                
                if (vari == -6567)
                {
                  MessageBox.Show("Please enter the value of y");
                  return;
                }
                string temp = k.Replace("~", vari.ToString());

                CalculationEngine engine = new CalculationEngine();
                try
                {
                    double func = engine.Calculate(temp);
                    result.Text = func.ToString();
                }
                catch (Exception)
                {
                    result.FontSize = 30;
                    result1.FontSize = 30;
                    result.Text = "Format Not Correct";
                    flag = 1;
                    return;
                }
            }
            else
            {
                CalculationEngine engine = new CalculationEngine();
                try
                {
                    string temp = k;
                    double func = engine.Calculate(temp);
                    result.Text = func.ToString();
                }
                catch (Exception)
                {
                    result.FontSize = 30;
                    result1.FontSize = 30;
                    result.Text = "Format Not Correct";
                    flag = 1;
                    return;
                }
            }

            result1.Text = result.Text;
            result.FontSize = 30;
            result1.FontSize = 30;
        }

        private void ShowValues()
        {
            //string lo = "", up = "", y1 = "";
            //lo = lower.Text;
            //up = upper.Text;
            //y1 = y.Text;
            double lo = a;
            double up = b;
            double y1 = vari;
            //double.TryParse(lo, out a);
            //double.TryParse(up, out b);
            //double.TryParse(y1, out vari);

            /*b = double.Parse(up);
            vari = double.Parse(y1);*/
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            int sel = piv.SelectedIndex;
            if (sel == 0)
            {
                sel = 1;
                piv.SelectedIndex = sel;
                return;
            }
            if (sel == 1)
            {
                sel = 0;
                piv.SelectedIndex = sel;
                return;
            }
        }

        private void LowerLimit_Click(object sender, RoutedEventArgs e)
        {
            InputPrompt input = new InputPrompt();
            input.Title = "Lower Limit";
            input.Message = "Enter the lower limit";
            input.Completed += input_Completed;
            input.Show();

        }

        void input_Completed(object sender, PopUpEventArgs<string, PopUpResult> e)
        {
            if (e.PopUpResult == PopUpResult.Ok)
            {
                try
                {
                    string temp = e.Result;
                    CalculationEngine engine = new CalculationEngine();
                    a = engine.Calculate(temp); 
                }
                catch (Exception)
                {
                    MessageBox.Show("Enter only numeric values!!!");
                }
            }
        }

        private void UpperLimit_Click(object sender, RoutedEventArgs e)
        {
            InputPrompt input = new InputPrompt();
            input.Title = "Upper Limit";
            input.Message = "Enter the Upper limit";
            input.Completed += input_Completed2;
            input.Show();
        }

        private void input_Completed2(object sender, PopUpEventArgs<string, PopUpResult> e)
        {
            if (e.PopUpResult == PopUpResult.Ok)
            {
                try
                {
                    string temp = e.Result;
                    CalculationEngine engine = new CalculationEngine();
                    b = engine.Calculate(temp); 
                }
                catch (Exception)
                {
                    MessageBox.Show("Enter only numeric values!!!");
                }
            }
        }

        private void Variable1_Click_1(object sender, RoutedEventArgs e)
        {
            InputPrompt input = new InputPrompt();
            input.Title = "Value of y";
            input.Message = "Enter the Value of y";
            input.Completed += input_Completed3;
            input.Show();
        }

        private void input_Completed3(object sender, PopUpEventArgs<string, PopUpResult> e)
        {
            if (e.PopUpResult == PopUpResult.Ok)
            {
                try
                {
                    string temp = e.Result;
                    CalculationEngine engine = new CalculationEngine();
                    vari = engine.Calculate(temp); 
                }
                catch (Exception)
                {
                    MessageBox.Show("Enter only numeric values!!!");
                }
            }
        }

        
    }

}