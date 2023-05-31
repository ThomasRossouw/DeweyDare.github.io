﻿using System;
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
using System.Windows.Shapes;

namespace PROG7312_ST10121910
{
    /// <summary>
    /// Interaction logic for Mix.xaml
    /// </summary>
    public partial class Mix : Window
    {
        public Mix()
        {
            InitializeComponent();

            PosOptbtn1.Visibility = Visibility.Hidden;
            PosOptbtn2.Visibility = Visibility.Hidden;
            PosOptbtn3.Visibility = Visibility.Hidden;
            PosOptbtn4.Visibility = Visibility.Hidden;


            MatchBtn1.Visibility = Visibility.Hidden;
            MatchBtn2.Visibility = Visibility.Hidden;
            MatchBtn3.Visibility = Visibility.Hidden;
            MatchBtn4.Visibility = Visibility.Hidden;
            MatchBtn5.Visibility = Visibility.Hidden;
            MatchBtn6.Visibility = Visibility.Hidden;
            MatchBtn7.Visibility = Visibility.Hidden;

            SelectionLbl.Visibility = Visibility.Hidden;
        }

        string selected1;



        string answered1 = "";
        string answered2 = "";
        string answered3 = "";
        string answered4 = "";
        string answered5 = "";
        string answered6 = "";
        string answered7 = "";

        int final0;
        int final1;
        int final2;
        int final3;
        int final4;
        int final5;
        int final6;

        int total = 0;

        //Dictionary
        IDictionary<string, string> DeweyDictionary = new Dictionary<string, string>();

        // Game begins when the start button is pressed
        private void StartGame_Click(object sender, RoutedEventArgs e)
        {

            SubmitBtn.Visibility = Visibility.Visible;
            BtnSubmit.Visibility = Visibility.Hidden;
            Dude.Source = null;
            total = 0;

            string[] DeweyNumber = { "000 - General Knowledge",
            "100 - Philosophy & Psychology ",
            "200 - Religion",
            "300 - Social Sciences",
            "400 - Languages",
            "500 - Science",
            "600 - Technology",
            "700 - Art & Recreation",
            "800 - Literature",
            "900 - History & Geography" };

            MatchBtn1.IsEnabled = true;
            MatchBtn2.IsEnabled = true;
            MatchBtn3.IsEnabled = true;
            MatchBtn4.IsEnabled = true;
            MatchBtn5.IsEnabled = true;
            MatchBtn6.IsEnabled = true;
            MatchBtn7.IsEnabled = true;



            Random random = new Random();

            int index1 = random.Next(DeweyNumber.Length);
            string opt1 = DeweyNumber[index1];
            string opti1 = DeweyNumber[index1];
            List<string> list = new List<string>(DeweyNumber);
            list.RemoveAt(list.IndexOf(opt1));
            DeweyNumber = list.ToArray();

            int index2 = random.Next(DeweyNumber.Length);
            string opt2 = DeweyNumber[index2];
            string opti2 = DeweyNumber[index2];
            List<string> list1 = new List<string>(DeweyNumber);
            list1.RemoveAt(list1.IndexOf(opt2));
            DeweyNumber = list1.ToArray();

            int index3 = random.Next(DeweyNumber.Length);
            string opt3 = DeweyNumber[index3];
            string opti3 = DeweyNumber[index3];
            List<string> list2 = new List<string>(DeweyNumber);
            list2.RemoveAt(list2.IndexOf(opt3));
            DeweyNumber = list2.ToArray();

            int index4 = random.Next(DeweyNumber.Length);
            string opt4 = DeweyNumber[index4];
            string opti4 = DeweyNumber[index4];
            List<string> list3 = new List<string>(DeweyNumber);
            list3.RemoveAt(list3.IndexOf(opt4));
            DeweyNumber = list3.ToArray();

            int index5 = random.Next(DeweyNumber.Length);
            string opt5 = DeweyNumber[index5];
            string opti5 = DeweyNumber[index5];
            List<string> list4 = new List<string>(DeweyNumber);
            list4.RemoveAt(list4.IndexOf(opt5));
            DeweyNumber = list4.ToArray();


            int index6 = random.Next(DeweyNumber.Length);
            string opt6 = DeweyNumber[index6];
            string opti6 = DeweyNumber[index6];
            List<string> list5 = new List<string>(DeweyNumber);
            list5.RemoveAt(list5.IndexOf(opt6));
            DeweyNumber = list5.ToArray();


            int index7 = random.Next(DeweyNumber.Length);
            string opt7 = DeweyNumber[index7];
            string opti7 = DeweyNumber[index7];

            string Num1 = opt1.Substring(0, 3);
            string Num2 = opt2.Substring(0, 3);
            string Num3 = opt3.Substring(0, 3);
            string Num4 = opt4.Substring(0, 3);
            string Num5 = opt5.Substring(0, 3);
            string Num6 = opt6.Substring(0, 3);
            string Num7 = opt7.Substring(0, 3);


            string Opt1 = opti1.Remove(0, 3);
            string Opt2 = opti2.Remove(0, 3);
            string Opt3 = opti3.Remove(0, 3);
            string Opt4 = opti4.Remove(0, 3);
            string Opt5 = opti5.Remove(0, 3);
            string Opt6 = opti6.Remove(0, 3);
            string Opt7 = opti7.Remove(0, 3);







            string[] lSide = { Num1, Num2, Num3, Num4, Num5, Num6, Num7 };
            string[] rside = { Opt1, Opt2, Opt3, Opt4, Opt5, Opt6, Opt7 };

            int pick1 = random.Next(lSide.Length);
            string cho1 = lSide[pick1];
            List<string> listOptions = new List<string>(lSide);
            listOptions.RemoveAt(listOptions.IndexOf(cho1));
            lSide = listOptions.ToArray();

            int pick2 = random.Next(lSide.Length);
            string cho2 = lSide[pick2];
            List<string> listOptions1 = new List<string>(lSide);
            listOptions1.RemoveAt(listOptions1.IndexOf(cho2));
            lSide = listOptions1.ToArray();


            int pick3 = random.Next(lSide.Length);
            string cho3 = lSide[pick3];
            List<string> listOptions2 = new List<string>(lSide);
            listOptions2.RemoveAt(listOptions2.IndexOf(cho3));
            lSide = listOptions2.ToArray();

            int pick4 = random.Next(lSide.Length);
            string cho4 = lSide[pick4];
            List<string> listOptions3 = new List<string>(lSide);
            listOptions3.RemoveAt(listOptions3.IndexOf(cho4));
            lSide = listOptions3.ToArray();

            PosOptbtn1.Content = cho1;
            PosOptbtn2.Content = cho2;
            PosOptbtn3.Content = cho3;
            PosOptbtn4.Content = cho4;


            int ans1 = random.Next(rside.Length);
            string answer1 = rside[ans1];
            List<string> listAnswers = new List<string>(rside);
            listAnswers.RemoveAt(listAnswers.IndexOf(answer1));
            rside = listAnswers.ToArray();

            int ans2 = random.Next(rside.Length);
            string answer2 = rside[ans2];
            List<string> listAnswers1 = new List<string>(rside);
            listAnswers1.RemoveAt(listAnswers1.IndexOf(answer2));
            rside = listAnswers1.ToArray();

            int ans3 = random.Next(rside.Length);
            string answer3 = rside[ans3];
            List<string> listAnswers2 = new List<string>(rside);
            listAnswers2.RemoveAt(listAnswers2.IndexOf(answer3));
            rside = listAnswers2.ToArray();

            int ans4 = random.Next(rside.Length);
            string answer4 = rside[ans4];
            List<string> listAnswers3 = new List<string>(rside);
            listAnswers3.RemoveAt(listAnswers3.IndexOf(answer4));
            rside = listAnswers3.ToArray();

            int ans5 = random.Next(rside.Length);
            string answer5 = rside[ans5];
            List<string> listAnswers4 = new List<string>(rside);
            listAnswers4.RemoveAt(listAnswers4.IndexOf(answer5));
            rside = listAnswers4.ToArray();

            int ans6 = random.Next(rside.Length);
            string answer6 = rside[ans6];
            List<string> listAnswers5 = new List<string>(rside);
            listAnswers5.RemoveAt(listAnswers5.IndexOf(answer6));
            rside = listAnswers5.ToArray();

            int ans7 = random.Next(rside.Length);
            string answer7 = rside[ans7];
            List<string> listAnswers6 = new List<string>(rside);
            listAnswers6.RemoveAt(listAnswers6.IndexOf(answer7));
            rside = listAnswers6.ToArray();


            MatchBtn1.Content = answer1;
            MatchBtn2.Content = answer2;
            MatchBtn3.Content = answer3;
            MatchBtn4.Content = answer4;
            MatchBtn5.Content = answer5;
            MatchBtn6.Content = answer6;
            MatchBtn7.Content = answer7;

            PosOptbtn1.Visibility = Visibility.Visible;
            PosOptbtn2.Visibility = Visibility.Visible;
            PosOptbtn3.Visibility = Visibility.Visible;
            PosOptbtn4.Visibility = Visibility.Visible;

            MatchBtn1.Visibility = Visibility.Visible;
            MatchBtn2.Visibility = Visibility.Visible;
            MatchBtn3.Visibility = Visibility.Visible;
            MatchBtn4.Visibility = Visibility.Visible;
            MatchBtn5.Visibility = Visibility.Visible;
            MatchBtn6.Visibility = Visibility.Visible;
            MatchBtn7.Visibility = Visibility.Visible;


            BarSort.Value = 0;
          
        }



        // as buttons are selected, the content is pulled and ready to be moved to the answer block

        private void btnOption1_Click(object sender, RoutedEventArgs e)
        {
            var btn1 = (e.Source as Button).Content.ToString();
            selected1 = btn1;
            SelectionLbl.Text = selected1;
        }

        private void btnOption2_Click(object sender, RoutedEventArgs e)
        {
            var btn1 = (e.Source as Button).Content.ToString();
            selected1 = btn1;
            SelectionLbl.Text = selected1;
        }

        private void btnOption3_Click(object sender, RoutedEventArgs e)
        {
            var btn1 = (e.Source as Button).Content.ToString();
            selected1 = btn1;
            SelectionLbl.Text = selected1;
        }

        private void btnOption4_Click(object sender, RoutedEventArgs e)
        {
            var btn1 = (e.Source as Button).Content.ToString();
            selected1 = btn1;
            SelectionLbl.Text = selected1;
        }

        private void MatchBtn1_Click(object sender, RoutedEventArgs e)
        {
            if (SelectionLbl.Text != "")
            {

                var btn1 = (e.Source as Button).Content.ToString();
                string a1 = btn1;
                string b2 = SelectionLbl.Text + btn1;
                MatchBtn1.Content = b2;

                MatchBtn1.IsEnabled = false;

                answered1 = b2;

                SelectionLbl.Text = "";
            }

            else
            {
                MessageBox.Show("Please select a number on the left first.", "Alert");
            }
        }

        private void MatchBtn2_Click(object sender, RoutedEventArgs e)
        {
            if (SelectionLbl.Text != "")
            {


                var btn1 = (e.Source as Button).Content.ToString();
                string a1 = btn1;
                string b2 = SelectionLbl.Text + btn1;
                MatchBtn2.Content = b2;

                MatchBtn2.IsEnabled = false;

                answered2 = b2;

                SelectionLbl.Text = "";
            }

            else
            {
                MessageBox.Show("Please select a number on the left first.", "Alert");
            }
        }

        private void MatchBtn3_Click(object sender, RoutedEventArgs e)
        {

            if (SelectionLbl.Text != "")
            {

                var btn1 = (e.Source as Button).Content.ToString();
                string a1 = btn1;
                string b2 = SelectionLbl.Text + btn1;
                MatchBtn3.Content = b2;

                MatchBtn3.IsEnabled = false;

                answered3 = b2;

                SelectionLbl.Text = "";

            }

            else
            {
                MessageBox.Show("Please select a number on the left first.", "Alert");
            }
        }

        private void MatchBtn4_Click(object sender, RoutedEventArgs e)
        {
            if (SelectionLbl.Text != "")
            {

                var btn1 = (e.Source as Button).Content.ToString();
                string a1 = btn1;
                string b2 = SelectionLbl.Text + btn1;
                MatchBtn4.Content = b2;

                MatchBtn4.IsEnabled = false;

                answered4 = b2;

                SelectionLbl.Text = "";

            }

            else
            {
                MessageBox.Show("Please select a number on the left first.", "Alert");
            }
        }

        private void MatchBtn5_Click(object sender, RoutedEventArgs e)
        {
            if (SelectionLbl.Text != "")
            {

                var btn1 = (e.Source as Button).Content.ToString();
                string a1 = btn1;
                string b2 = SelectionLbl.Text + btn1;
                MatchBtn5.Content = b2;

                MatchBtn5.IsEnabled = false;

                answered5 = b2;

                SelectionLbl.Text = "";

            }

            else
            {
                MessageBox.Show("Please select a number on the left first.", "Alert");
            }
        }

        private void MatchBtn6_Click(object sender, RoutedEventArgs e)
        {
            if (SelectionLbl.Text != "")
            {

                var btn1 = (e.Source as Button).Content.ToString();
                string a1 = btn1;
                string b2 = SelectionLbl.Text + btn1;
                MatchBtn6.Content = b2;

                MatchBtn6.IsEnabled = false;

                answered6 = b2;

                SelectionLbl.Text = "";

            }

            else
            {
                MessageBox.Show("Please select a number on the left first.", "Alert");
            }
        }

        private void MatchBtn7_Click(object sender, RoutedEventArgs e)
        {
            if (SelectionLbl.Text != "")
            {

                var btn1 = (e.Source as Button).Content.ToString();
                string a1 = btn1;
                string b2 = SelectionLbl.Text + btn1;
                MatchBtn7.Content = b2;

                MatchBtn7.IsEnabled = false;

                answered7 = b2;

                SelectionLbl.Text = "";

            }

            else
            {
                MessageBox.Show("Please select a number on the left first.", "Alert");
            }
        }

        private void SubmitBtn_Click(object sender, RoutedEventArgs e)
        {

           
            string[] Answers = { "000 - General Knowledge",
            "100 - Philosophy & Psychology ",
            "200 - Religion",
            "300 - Social Sciences",
            "400 - Languages",
            "500 - Science",
            "600 - Technology",
            "700 - Art & Recreation",
            "800 - Literature",
            "900 - History & Geography" };


            if (Answers.Contains(answered1))
            {
                final0 = 1;
            }

            else
            {
                final0 = 0;
            }

            if (Answers.Contains(answered2))
            {
                final1 = 1;
            }

            else
            {
                final1 = 0;
            }

            if (Answers.Contains(answered3))
            {
                final2 = 1;
            }

            else
            {
                final2 = 0;
            }

            if (Answers.Contains(answered4))
            {
                final3 = 1;
            }

            else
            {
                final3 = 0;
            }

            if (Answers.Contains(answered5))
            {
                final4 = 1;
            }

            else
            {
                final4 = 0;
            }

            if (Answers.Contains(answered6))
            {
                final5 = 1;
            }

            else
            {
                final5 = 0;
            }

            if (Answers.Contains(answered7))
            {
                final6 = 1;
            }

            else
            {
                final6 = 0;
            }



            int total = final0 + final1 + final2 + final3 + final4 + final5 + final6;


            MessageBox.Show(total.ToString(), "Result");

            if(total == 4)
            {
                MessageBox.Show("You got it!", "Congratulations you are correct!");
                BarSort.Value = 100;
                Dude.Source = new BitmapImage(new Uri("/1000.png", UriKind.Relative));

            }
            if(total == 3)
            {
                MessageBox.Show("You almost there!", "Getting there ...");
                BarSort.Value = 75;
                Dude.Source = new BitmapImage(new Uri("/Almost.png", UriKind.Relative));
            }
            if(total == 2)
            {
                MessageBox.Show("Keep going, you are halfway:)", "Halfway");
                BarSort.Value = 50;
                Dude.Source = new BitmapImage(new Uri("/halfway.png", UriKind.Relative));
            }
            if(total == 1)
            {
                MessageBox.Show("You are a quater of the way;)", "Slowly getting there ;)");
                BarSort.Value = 25;
                Dude.Source = new BitmapImage(new Uri("/25.png", UriKind.Relative));
            }
            if (total == 0)
            {
                MessageBox.Show("You are not up to the Dewey Standards!", "Unfortunately");
                BarSort.Value = 0;
                Dude.Source = new BitmapImage(new Uri("/wrong.png", UriKind.Relative));

            }
        }
    


    // The action to change to the Sorting Game
    private void ButtonBook_Click(object sender, RoutedEventArgs e)
        {
            Sort sort = new Sort();
            this.Visibility = Visibility.Hidden;
            sort.Show();
        }

        // The action to change to the Main Window
        private void ButtonHome_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Visibility = Visibility.Hidden;
            main.Show();
        }

        // The action to change to the Mix and Match Game
        private void ButtonMix_Click(object sender, RoutedEventArgs e)
        {
            Mix mix = new Mix();
            this.Visibility = Visibility.Hidden;
            mix.Show();
        }

        //pop up that thanks the user and lets them exit the game
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Thank you for using The Book Game!", "Thank you"); // Ok message box --> Thank you

            this.Close(); // closes the program for the user 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SubmitBtn.Visibility = Visibility.Hidden;
            BtnSubmit.Visibility = Visibility.Visible; 
            Dude.Source = null;
            total = 0;

            BarSort.Value = 0;

            answered1 = "";
            answered2 = "";
            answered3 = "";
            answered4 = "";
            answered5 = "";
            answered6 = "";
            answered7 = "";


            string[] callNumbers = { "000 - Computer Science, Information, & General Works",
            "100 - Philosophy & Psychology  ",
            "200 - Religion",
            "300 - Social Sciences  ",
            "400 - Language",
            "500 - Science",
            "600 - Technology",
            "700 - Arts & Recreation",
            "800 - Literature",
            "900 - History & Geography" };

            MatchBtn1.IsEnabled = true;
            MatchBtn2.IsEnabled = true;
            MatchBtn3.IsEnabled = true;
            MatchBtn4.IsEnabled = true;
            MatchBtn5.IsEnabled = true;
            MatchBtn6.IsEnabled = true;
            MatchBtn7.IsEnabled = true;

            PosOptbtn1.Visibility = Visibility.Hidden;
            PosOptbtn1.Visibility = Visibility.Hidden;
            PosOptbtn1.Visibility = Visibility.Hidden;

            MatchBtn1.IsEnabled = true;
            MatchBtn2.IsEnabled = true;
            MatchBtn3.IsEnabled = true;
            MatchBtn4.IsEnabled = true;
            MatchBtn5.IsEnabled = true;
            MatchBtn6.IsEnabled = true;
            MatchBtn7.IsEnabled = true;





            Random rand = new Random();

            int index1 = rand.Next(callNumbers.Length);
            string opt1 = callNumbers[index1];
            string opti1 = callNumbers[index1];
            List<string> list = new List<string>(callNumbers);
            list.RemoveAt(list.IndexOf(opt1));
            callNumbers = list.ToArray();

            int index2 = rand.Next(callNumbers.Length);
            string opt2 = callNumbers[index2];
            string opti2 = callNumbers[index2];
            List<string> list1 = new List<string>(callNumbers);
            list1.RemoveAt(list1.IndexOf(opt2));
            callNumbers = list1.ToArray();

            int index3 = rand.Next(callNumbers.Length);
            string opt3 = callNumbers[index3];
            string opti3 = callNumbers[index3];
            List<string> list2 = new List<string>(callNumbers);
            list2.RemoveAt(list2.IndexOf(opt3));
            callNumbers = list2.ToArray();

            int index4 = rand.Next(callNumbers.Length);
            string opt4 = callNumbers[index4];
            string opti4 = callNumbers[index4];
            List<string> list3 = new List<string>(callNumbers);
            list3.RemoveAt(list3.IndexOf(opt4));
            callNumbers = list3.ToArray();

            int index5 = rand.Next(callNumbers.Length);
            string opt5 = callNumbers[index5];
            string opti5 = callNumbers[index5];
            List<string> list4 = new List<string>(callNumbers);
            list4.RemoveAt(list4.IndexOf(opt5));
            callNumbers = list4.ToArray();


            int index6 = rand.Next(callNumbers.Length);
            string opt6 = callNumbers[index6];
            string opti6 = callNumbers[index6];
            List<string> list5 = new List<string>(callNumbers);
            list5.RemoveAt(list5.IndexOf(opt6));
            callNumbers = list5.ToArray();


            int index7 = rand.Next(callNumbers.Length);
            string opt7 = callNumbers[index7];
            string opti7 = callNumbers[index7];

            string Num1 = opt1.Substring(0, 3);
            string Num2 = opt2.Substring(0, 3);
            string Num3 = opt3.Substring(0, 3);
            string Num4 = opt4.Substring(0, 3);
            string Num5 = opt5.Substring(0, 3);
            string Num6 = opt6.Substring(0, 3);
            string Num7 = opt7.Substring(0, 3);


            string Opt1 = opti1.Remove(0, 3);
            string Opt2 = opti2.Remove(0, 3);
            string Opt3 = opti3.Remove(0, 3);
            string Opt4 = opti4.Remove(0, 3);
            string Opt5 = opti5.Remove(0, 3);
            string Opt6 = opti6.Remove(0, 3);
            string Opt7 = opti7.Remove(0, 3);







            string[] lSide = { Num1, Num2, Num3, Num4, Num5, Num6, Num7 };
            string[] rside = { Opt1, Opt2, Opt3, Opt4, Opt5, Opt6, Opt7 };

            int pick1 = rand.Next(rside.Length);
            string cho1 = rside[pick1];
            List<string> listOptions = new List<string>(rside);
            listOptions.RemoveAt(listOptions.IndexOf(cho1));
            rside = listOptions.ToArray();

            int pick2 = rand.Next(rside.Length);
            string cho2 = rside[pick2];
            List<string> listOptions1 = new List<string>(rside);
            listOptions1.RemoveAt(listOptions1.IndexOf(cho2));
            rside = listOptions1.ToArray();


            int pick3 = rand.Next(rside.Length);
            string cho3 = rside[pick3];
            List<string> listOptions2 = new List<string>(rside);
            listOptions2.RemoveAt(listOptions2.IndexOf(cho3));
            rside = listOptions2.ToArray();

            int pick4 = rand.Next(rside.Length);
            string cho4 = rside[pick4];
            List<string> listOptions3 = new List<string>(rside);
            listOptions3.RemoveAt(listOptions3.IndexOf(cho4));
            rside = listOptions3.ToArray();




            PosOptbtn1.Content = cho1;
            PosOptbtn2.Content = cho2;
            PosOptbtn3.Content = cho3;
            PosOptbtn4.Content = cho4;



            int ans1 = rand.Next(lSide.Length);
            string answer1 = lSide[ans1];
            List<string> listAnswers = new List<string>(lSide);
            listAnswers.RemoveAt(listAnswers.IndexOf(answer1));
            lSide = listAnswers.ToArray();

            int ans2 = rand.Next(lSide.Length);
            string answer2 = lSide[ans2];
            List<string> listAnswers1 = new List<string>(lSide);
            listAnswers1.RemoveAt(listAnswers1.IndexOf(answer2));
            lSide = listAnswers1.ToArray();

            int ans3 = rand.Next(lSide.Length);
            string answer3 = lSide[ans3];
            List<string> listAnswers2 = new List<string>(lSide);
            listAnswers2.RemoveAt(listAnswers2.IndexOf(answer3));
            lSide = listAnswers2.ToArray();

            int ans4 = rand.Next(lSide.Length);
            string answer4 = lSide[ans4];
            List<string> listAnswers3 = new List<string>(lSide);
            listAnswers3.RemoveAt(listAnswers3.IndexOf(answer4));
            lSide = listAnswers3.ToArray();

            int ans5 = rand.Next(lSide.Length);
            string answer5 = lSide[ans5];
            List<string> listAnswers4 = new List<string>(lSide);
            listAnswers4.RemoveAt(listAnswers4.IndexOf(answer5));
            lSide = listAnswers4.ToArray();

            int ans6 = rand.Next(lSide.Length);
            string answer6 = lSide[ans6];
            List<string> listAnswers5 = new List<string>(lSide);
            listAnswers5.RemoveAt(listAnswers5.IndexOf(answer6));
            lSide = listAnswers5.ToArray();

            int ans7 = rand.Next(lSide.Length);
            string answer7 = lSide[ans7];
            List<string> listAnswers6 = new List<string>(lSide);
            listAnswers6.RemoveAt(listAnswers6.IndexOf(answer7));
            lSide = listAnswers6.ToArray();






            MatchBtn1.Content = answer1;
            MatchBtn2.Content = answer2;
            MatchBtn3.Content = answer3;
            MatchBtn4.Content = answer4;
            MatchBtn5.Content = answer5;
            MatchBtn6.Content = answer6;
            MatchBtn7.Content = answer7;



            PosOptbtn1.Visibility = Visibility.Visible;
            PosOptbtn2.Visibility = Visibility.Visible;
            PosOptbtn3.Visibility = Visibility.Visible;
            PosOptbtn4.Visibility = Visibility.Visible;



            MatchBtn1.Visibility = Visibility.Visible;
            MatchBtn2.Visibility = Visibility.Visible;
            MatchBtn3.Visibility = Visibility.Visible;
            MatchBtn4.Visibility = Visibility.Visible;
            MatchBtn5.Visibility = Visibility.Visible;
            MatchBtn6.Visibility = Visibility.Visible;
            MatchBtn7.Visibility = Visibility.Visible;
        }

        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            string[] Answers = { "000 - Computer Science, Information, & General Works",
            "100 - Philosophy & Psychology  ",
            "200 - Religion",
            "300 - Social Sciences  ",
            "400 - Language",
            "500 - Science",
            "600 - Technology",
            "700 - Arts & Recreation",
            "800 - Literature",
            "900 - History & Geography" };


            if (Answers.Contains(answered1))
            {
                final0 = 1;
            }

            else
            {
                final0 = 0;
            }

            if (Answers.Contains(answered2))
            {
                final1 = 1;
            }

            else
            {
                final1 = 0;
            }

            if (Answers.Contains(answered3))
            {
                final2 = 1;
            }

            else
            {
                final2 = 0;
            }

            if (Answers.Contains(answered4))
            {
                final3 = 1;
            }

            else
            {
                final3 = 0;
            }

            if (Answers.Contains(answered5))
            {
                final4 = 1;
            }

            else
            {
                final4 = 0;
            }

            if (Answers.Contains(answered6))
            {
                final5 = 1;
            }

            else
            {
                final5 = 0;
            }

            if (Answers.Contains(answered7))
            {
                final6 = 1;
            }

            else
            {
                final6 = 0;
            }

        
            total = 0;
            total = final0 + final1 + final2 + final3 + final4 + final5 + final6;


            MatchBtn1.Visibility = Visibility.Hidden;
            MatchBtn2.Visibility = Visibility.Hidden;
            MatchBtn3.Visibility = Visibility.Hidden;
            MatchBtn4.Visibility = Visibility.Hidden;
            MatchBtn5.Visibility = Visibility.Hidden;
            MatchBtn6.Visibility = Visibility.Hidden;
            MatchBtn7.Visibility = Visibility.Hidden;


            if (total == 4)
            {
                MessageBox.Show("You got it!", "Congratulations you are correct!");
                BarSort.Value = 100;
                Dude.Source = new BitmapImage(new Uri("/1000.png", UriKind.Relative));

            }
            if (total == 3)
            {
                MessageBox.Show("You almost there!", "Getting there ...");
                BarSort.Value = 75;
                Dude.Source = new BitmapImage(new Uri("/Almost.png", UriKind.Relative));
            }
            if (total == 2)
            {
                MessageBox.Show("Keep going, you are halfway:)", "Halfway");
                BarSort.Value = 50;
                Dude.Source = new BitmapImage(new Uri("/halfway.png", UriKind.Relative));
            }
            if (total == 1)
            {
                MessageBox.Show("You are a quater of the way;)", "Slowly getting there ;)");
                BarSort.Value = 25;
                Dude.Source = new BitmapImage(new Uri("/25.png", UriKind.Relative));
            }
            if (total == 0)
            {
                MessageBox.Show("You are not up to the Dewey Standards!", "Unfortunately");
                BarSort.Value = 0;
                Dude.Source = new BitmapImage(new Uri("/wrong.png", UriKind.Relative));

            }
        }

        private void ButtonQuiz_Click(object sender, RoutedEventArgs e)
        {
            Knowing know = new Knowing();
            this.Visibility = Visibility.Hidden;
            know.Show(); // loads the Mix page 
        }


    }
    }

