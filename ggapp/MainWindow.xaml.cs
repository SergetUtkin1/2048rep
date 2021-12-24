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

namespace ggapp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int[] mArray = new int[16];
        static int[] dValues = { 2, 4 };

        public void SetterOFValues()
        {
            TB1.Text = (mArray[0] == 0 ? null : mArray[0].ToString());
            TB2.Text = (mArray[1] == 0 ? null : mArray[1].ToString());
            TB3.Text = (mArray[2] == 0 ? null : mArray[2].ToString());
            TB4.Text = (mArray[3] == 0 ? null : mArray[3].ToString());

            TB5.Text = (mArray[4] == 0 ? null : mArray[4].ToString());
            TB6.Text = (mArray[5] == 0 ? null : mArray[5].ToString());
            TB7.Text = (mArray[6] == 0 ? null : mArray[6].ToString());
            TB8.Text = (mArray[7] == 0 ? null : mArray[7].ToString());

            TB9.Text = (mArray[8] == 0 ? null : mArray[8].ToString());
            TB10.Text = (mArray[9] == 0 ? null : mArray[9].ToString());
            TB11.Text = (mArray[10] == 0 ? null : mArray[10].ToString());
            TB12.Text = (mArray[11] == 0 ? null : mArray[11].ToString());

            TB13.Text = (mArray[12] == 0 ? null : mArray[12].ToString());
            TB14.Text = (mArray[13] == 0 ? null : mArray[13].ToString());
            TB15.Text = (mArray[14] == 0 ? null : mArray[14].ToString());
            TB16.Text = (mArray[15] == 0 ? null : mArray[15].ToString());
        }

        public MainWindow()
        {
            InitializeComponent();
            Random random = new Random();
            mArray[random.Next(0, 16)] = dValues[random.Next(0,2)];
            SetterOFValues();
        }

        public void Adder()
        {
            Random random = new Random();
            int mCnt = mArray.Count(x => x == 0);
            while (mArray.Count(x => x == 0) == mCnt && mCnt > 0)
            {
                int index = random.Next(0, 16);
                mArray[index] = mArray[index] == 0 ? dValues[random.Next(0, 2)] : mArray[index];
            }
            SetterOFValues();
        }

        private void UP_Click(object sender, RoutedEventArgs e)
        {
            bool action = false;
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 12; i++)
                {
                    if (mArray[i] == 0 && mArray[i + 4] != 0)
                    {
                        action = true;
                    }
                }
            }
            for (int i = 0; i < 12; i++)
            {
                if ((mArray[i] == 0 || mArray[i] == mArray[i + 4]) && mArray[i] != 0)
                {
                    action = true;
                }
            }

            if (action)
            {
               

                for (int j = 0; j < 4; j++)
                {
                    for (int i = 0; i < 12; i++)
                    {
                        if (mArray[i] == 0 && mArray[i + 4] != 0)
                        {
                            mArray[i] = mArray[i + 4];
                            mArray[i + 4] = 0;
                        }
                    }
                }
                for (int i = 0; i < 12; i++)
                {
                    
                    if ((mArray[i] == 0 || mArray[i] == mArray[i + 4]) && mArray[i + 4] != 0)
                    {
                        mArray[i] += mArray[i + 4];
                        mArray[i + 4] = 0;
                        for (int k = 0; k < 12; k++)
                        {
                            if (mArray[k] == 0 && mArray[k + 4] != 0)
                            {
                                mArray[k] = mArray[k + 4];
                                mArray[k + 4] = 0;
                            }
                        }
                    }
                }

                SetterOFValues();
                Adder();
            }
        }

        private void DOWN_Click(object sender, RoutedEventArgs e)
        {
            bool action = false;

            for (int j = 0; j < 4; j++)
            {
                for (int i = 15; i > 3; i--)
                {
                    if (mArray[i] == 0 && mArray[i - 4] != 0)
                    {
                        action = true;
                    }
                }
            }

            for (int i = 15; i > 3; i--)
            {
                if ((mArray[i] == 0 || mArray[i] == mArray[i - 4]) && mArray[i - 4] != 0)
                {
                    action = true;
                }
            }

            if (action)
            {
                for (int j = 0; j < 4; j++)
                {
                    for (int i = 15; i > 3; i--)
                    {
                        if (mArray[i] == 0 && mArray[i - 4] != 0)
                        {
                            mArray[i] = mArray[i - 4];
                            mArray[i - 4] = 0;
                        }
                    }
                }

                for (int i = 15; i > 3; i--)
                {                   
                    if ((mArray[i] == 0 || mArray[i] == mArray[i - 4]) && mArray[i - 4] != 0)
                    {
                        mArray[i] += mArray[i - 4];
                        mArray[i - 4] = 0;
                        for (int k = 15; k > 3; k--)
                        {
                            if (mArray[k] == 0 && mArray[k - 4] != 0)
                            {
                                mArray[k] = mArray[k - 4];
                                mArray[k - 4] = 0;
                            }
                        }
                    }
                }

                SetterOFValues();
                Adder();
            }
        }

        private void RIGHT_Click(object sender, RoutedEventArgs e)
        {
            bool action = false;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 15; j >= 1; j--)
                {
                    if (mArray[j] == 0 && j % 4 != 0 && mArray[j - 1] != 0)
                    {
                        action = true;
                    }
                }
            }

            for (int i = 15; i>= 1; i--)
            {
                if ((mArray[i] == 0 || mArray[i] == mArray[i-1]) && mArray[i - 1] != 0 && i % 4 != 0)
                {
                    action = true;
                }
            }


            if (action)
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 15; j >= 1; j--)
                    {
                        if (mArray[j] == 0 && j % 4 != 0 && mArray[j - 1] != 0)
                        {
                            mArray[j] = mArray[j - 1];
                            mArray[j - 1] = 0;
                        }
                    }
                }

                for (int i = 15; i >= 1; i--)
                {
                    if ((mArray[i] == 0 || mArray[i] == mArray[i - 1]) && mArray[i - 1] != 0 && i % 4 != 0)
                    {
                        mArray[i] += mArray[i - 1];
                        mArray[i - 1] = 0;
                        for (int j = 15; j >= 1; j--)
                        {
                            if (mArray[j] == 0 && j % 4 != 0 && mArray[j - 1] != 0)
                            {
                                mArray[j] = mArray[j - 1];
                                mArray[j - 1] = 0;
                            }
                        }
                    } 
                }

                SetterOFValues();
                Adder();
            }
        }

        private void LEFT_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
