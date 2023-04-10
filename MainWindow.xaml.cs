using System;
using System.Collections.Generic;
using System.IO;
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
using static System.Net.Mime.MediaTypeNames;

namespace classwork2_07_04_23
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        bool caps_lock_on = false;

        string buffer_string; 


        static string text_path = "Text_1.txt";

        StreamReader sr = new StreamReader(text_path);

        public bool case_sens = false;

        static string Check_Line_Status(string Current_Line, StreamReader sr)
        {
            
            

            if (Current_Line == "")
            {

                if (sr.EndOfStream!=true)
                {
                    Current_Line = Read_string(sr);
                }
                else { 

                    sr.BaseStream.Position = 0; 
                    Current_Line = Read_string(sr); 
                }
            }
            return Current_Line;
        }

        static string Read_string(StreamReader sr)
        {

            
            string line;

            line = sr.ReadLine();

            if (line != "" | line!=null) return line;
            else return null;
        }



        static string Caps_Check(string input, bool caps_lock_on)
        {

            if (caps_lock_on)
            {
                return input.ToUpper();
            }
            else return input;

        }

        static string Check_Remove_Symbol(string input, string pressed,bool sens)
        {

            if (sens==true)
            {

                if (input != "")
                {
                    if (input.First() == pressed.First())
                    {
                        return input.Remove(0, 1);
                    }

                    else return input;

                }
                else return input;

            }
            else
            {

                if (input != "")
                {
                    if (input.First().ToString().ToLower() == pressed.First().ToString().ToLower())
                    {
                        return input.Remove(0, 1);
                    }

                    else return input;

                }
                else return input;

            }

            
        }

        

        private void Button_1_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text = Check_Remove_Symbol(main_textbox.Text, Caps_Check(Button_1.Content.ToString(),caps_lock_on),case_sens);

            main_textbox.Text = Check_Line_Status(main_textbox.Text, sr);

        }
        private void Button_apostrof_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text = Check_Remove_Symbol(main_textbox.Text, Caps_Check(Button_apostrof.Content.ToString(),caps_lock_on), case_sens);

            main_textbox.Text = Check_Line_Status(main_textbox.Text, sr);
        }

        private void Button_2_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text = Check_Remove_Symbol(main_textbox.Text, Caps_Check(Button_2.Content.ToString(), caps_lock_on), case_sens);

            main_textbox.Text = Check_Line_Status(main_textbox.Text, sr);
        }

        private void Button_3_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text = Check_Remove_Symbol(main_textbox.Text, Caps_Check(Button_3.Content.ToString(), caps_lock_on), case_sens);

            main_textbox.Text = Check_Line_Status(main_textbox.Text, sr);
        }

        private void Button_4_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text = Check_Remove_Symbol(main_textbox.Text, Caps_Check(Button_4.Content.ToString(), caps_lock_on), case_sens);

            main_textbox.Text = Check_Line_Status(main_textbox.Text, sr);
        }

        private void Button_5_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text = Check_Remove_Symbol(main_textbox.Text, Caps_Check(Button_5.Content.ToString(), caps_lock_on), case_sens);

            main_textbox.Text = Check_Line_Status(main_textbox.Text, sr);
        }

        private void Button_6_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text = Check_Remove_Symbol(main_textbox.Text, Caps_Check(Button_6.Content.ToString(), caps_lock_on), case_sens);

            main_textbox.Text = Check_Line_Status(main_textbox.Text, sr);
        }

        private void Button_7_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text = Check_Remove_Symbol(main_textbox.Text, Caps_Check(Button_7.Content.ToString(), caps_lock_on), case_sens);

            main_textbox.Text = Check_Line_Status(main_textbox.Text, sr);
        }

        private void Button_8_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text = Check_Remove_Symbol(main_textbox.Text, Caps_Check(Button_8.Content.ToString(), caps_lock_on), case_sens);

            main_textbox.Text = Check_Line_Status(main_textbox.Text, sr);
        }

        private void Button_9_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text = Check_Remove_Symbol(main_textbox.Text, Caps_Check(Button_9.Content.ToString(), caps_lock_on), case_sens);

            main_textbox.Text = Check_Line_Status(main_textbox.Text, sr);
        }

        private void Button_0_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text = Check_Remove_Symbol(main_textbox.Text, Caps_Check(Button_0.Content.ToString(), caps_lock_on), case_sens);

            main_textbox.Text = Check_Line_Status(main_textbox.Text, sr);
        }

        private void Button_minus_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text = Check_Remove_Symbol(main_textbox.Text, Caps_Check(Button_minus.Content.ToString(), caps_lock_on), case_sens);

            main_textbox.Text = Check_Line_Status(main_textbox.Text, sr);
        }

        private void Button_equals_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text = Check_Remove_Symbol(main_textbox.Text, Caps_Check(Button_equals.Content.ToString(), caps_lock_on), case_sens);

            main_textbox.Text = Check_Line_Status(main_textbox.Text, sr);
        }

        private void Button_backspace_Click(object sender, RoutedEventArgs e)
        {

            if (main_textbox.Text!="") {

                main_textbox.Text = main_textbox.Text.Remove(main_textbox.Text.Length - 1, 1);

            }
            
        }









        private void Button_tab_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text += "    ";
        }

        private void Button_q_Click(object sender, RoutedEventArgs e)
        
        {
            main_textbox.Text = Check_Remove_Symbol(main_textbox.Text, Caps_Check(Button_q.Content.ToString(), caps_lock_on), case_sens);

            main_textbox.Text = Check_Line_Status(main_textbox.Text, sr);
        }

        private void Button_w_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text = Check_Remove_Symbol(main_textbox.Text, Caps_Check(Button_w.Content.ToString(), caps_lock_on), case_sens);

            main_textbox.Text = Check_Line_Status(main_textbox.Text, sr);
        }

        private void Button_e_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text = Check_Remove_Symbol(main_textbox.Text, Caps_Check(Button_e.Content.ToString(), caps_lock_on), case_sens);

            main_textbox.Text = Check_Line_Status(main_textbox.Text, sr);
        }

        private void Button_r_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text = Check_Remove_Symbol(main_textbox.Text, Caps_Check(Button_r.Content.ToString(), caps_lock_on), case_sens);

            main_textbox.Text = Check_Line_Status(main_textbox.Text, sr);
        }

        private void Button_t_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text = Check_Remove_Symbol(main_textbox.Text, Caps_Check(Button_t.Content.ToString(), caps_lock_on), case_sens);

            main_textbox.Text = Check_Line_Status(main_textbox.Text, sr);
        }

        private void Button_y_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text = Check_Remove_Symbol(main_textbox.Text, Caps_Check(Button_y.Content.ToString(), caps_lock_on), case_sens);

            main_textbox.Text = Check_Line_Status(main_textbox.Text, sr);
        }

        private void Button_u_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text = Check_Remove_Symbol(main_textbox.Text, Caps_Check(Button_u.Content.ToString(), caps_lock_on), case_sens);

            main_textbox.Text = Check_Line_Status(main_textbox.Text, sr);
        }

        private void Button_i_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text = Check_Remove_Symbol(main_textbox.Text, Caps_Check(Button_i.Content.ToString(), caps_lock_on), case_sens);

            main_textbox.Text = Check_Line_Status(main_textbox.Text, sr);
        }

        private void Button_o_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text = Check_Remove_Symbol(main_textbox.Text, Caps_Check(Button_o.Content.ToString(), caps_lock_on), case_sens);

            main_textbox.Text = Check_Line_Status(main_textbox.Text, sr);
        }

        private void Button_p_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text = Check_Remove_Symbol(main_textbox.Text, Caps_Check(Button_p.Content.ToString(), caps_lock_on), case_sens);

            main_textbox.Text = Check_Line_Status(main_textbox.Text, sr);
        }

        private void Button_square_left_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text = Check_Remove_Symbol(main_textbox.Text, Caps_Check(Button_square_left.Content.ToString(), caps_lock_on), case_sens);

            main_textbox.Text = Check_Line_Status(main_textbox.Text, sr);
        }

        private void Button_square_right_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text = Check_Remove_Symbol(main_textbox.Text, Caps_Check(Button_square_right.Content.ToString(), caps_lock_on), case_sens);

            main_textbox.Text = Check_Line_Status(main_textbox.Text, sr);
        }

        private void Button_slash_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text = Check_Remove_Symbol(main_textbox.Text, Caps_Check(Button_slash.Content.ToString(), caps_lock_on), case_sens);

            main_textbox.Text = Check_Line_Status(main_textbox.Text, sr);
        }







        private void Button_Caps_Lock_Click(object sender, RoutedEventArgs e)
        {
           

            if (caps_lock_on)
            {
                Button_Caps_Lock.Background = new SolidColorBrush(Colors.LightGray);
                caps_lock_on = false;

            }
            else
            {
                Button_Caps_Lock.Background = new SolidColorBrush(Colors.IndianRed);
                caps_lock_on = true;
            }


        }


        private void Button_a_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text = Check_Remove_Symbol(main_textbox.Text, Caps_Check(Button_a.Content.ToString(), caps_lock_on), case_sens);

            main_textbox.Text = Check_Line_Status(main_textbox.Text, sr);
        }

        private void Button_s_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text = Check_Remove_Symbol(main_textbox.Text, Caps_Check(Button_s.Content.ToString(), caps_lock_on), case_sens);

            main_textbox.Text = Check_Line_Status(main_textbox.Text, sr);
        }

        private void Button_d_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text = Check_Remove_Symbol(main_textbox.Text, Caps_Check(Button_d.Content.ToString(), caps_lock_on), case_sens);

            main_textbox.Text = Check_Line_Status(main_textbox.Text, sr);
        }

        private void Button_f_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text = Check_Remove_Symbol(main_textbox.Text, Caps_Check(Button_f.Content.ToString(), caps_lock_on), case_sens);

            main_textbox.Text = Check_Line_Status(main_textbox.Text, sr);
        }

        private void Button_g_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text = Check_Remove_Symbol(main_textbox.Text, Caps_Check(Button_g.Content.ToString(), caps_lock_on), case_sens);

            main_textbox.Text = Check_Line_Status(main_textbox.Text, sr);
        }

        private void Button_h_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text = Check_Remove_Symbol(main_textbox.Text, Caps_Check(Button_h.Content.ToString(), caps_lock_on), case_sens);

            main_textbox.Text = Check_Line_Status(main_textbox.Text, sr);
        }

        private void Button_j_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text = Check_Remove_Symbol(main_textbox.Text, Caps_Check(Button_j.Content.ToString(), caps_lock_on), case_sens);

            main_textbox.Text = Check_Line_Status(main_textbox.Text, sr);
        }

        private void Button_k_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text = Check_Remove_Symbol(main_textbox.Text, Caps_Check(Button_k.Content.ToString(), caps_lock_on), case_sens);

            main_textbox.Text = Check_Line_Status(main_textbox.Text, sr);
        }

        private void Button_l_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text = Check_Remove_Symbol(main_textbox.Text, Caps_Check(Button_l.Content.ToString(), caps_lock_on), case_sens);

            main_textbox.Text = Check_Line_Status(main_textbox.Text, sr);
        }

        private void Button_dot_coma_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text = Check_Line_Status(main_textbox.Text, sr);

            main_textbox.Text = Check_Remove_Symbol(main_textbox.Text, Button_dot_coma.Content.ToString(), case_sens);

            main_textbox.Text = Check_Line_Status(main_textbox.Text, sr);
        }
        private void Button_enter_click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text += "\n";
        }





        private void Button_z_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text = Check_Remove_Symbol(main_textbox.Text, Caps_Check(Button_z.Content.ToString(), caps_lock_on), case_sens);

            main_textbox.Text = Check_Line_Status(main_textbox.Text, sr);
        }

        private void Button_x_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text = Check_Remove_Symbol(main_textbox.Text, Caps_Check(Button_x.Content.ToString(), caps_lock_on), case_sens);

            main_textbox.Text = Check_Line_Status(main_textbox.Text, sr);
        }

        private void Button_c_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text = Check_Remove_Symbol(main_textbox.Text, Caps_Check(Button_c.Content.ToString(), caps_lock_on), case_sens);

            main_textbox.Text = Check_Line_Status(main_textbox.Text, sr);
        }

        private void Button_v_Click(object sender, RoutedEventArgs e)
        {


            main_textbox.Text = Check_Remove_Symbol(main_textbox.Text, Caps_Check(Button_v.Content.ToString(), caps_lock_on), case_sens);

            main_textbox.Text = Check_Line_Status(main_textbox.Text, sr);
        }

        private void Button_b_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text = Check_Remove_Symbol(main_textbox.Text, Caps_Check(Button_b.Content.ToString(), caps_lock_on), case_sens);

            main_textbox.Text = Check_Line_Status(main_textbox.Text, sr);
        }

        private void Button_n_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text = Check_Remove_Symbol(main_textbox.Text, Caps_Check(Button_n.Content.ToString(), caps_lock_on ), case_sens);

            main_textbox.Text = Check_Line_Status(main_textbox.Text, sr);
        }

        private void Button_m_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text = Check_Remove_Symbol(main_textbox.Text, Caps_Check(Button_m.Content.ToString(), caps_lock_on), case_sens);

            main_textbox.Text = Check_Line_Status(main_textbox.Text, sr);
        }

        private void Button_coma_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text = Check_Remove_Symbol(main_textbox.Text, Caps_Check(Button_coma.Content.ToString(), caps_lock_on), case_sens);

            main_textbox.Text = Check_Line_Status(main_textbox.Text, sr);
        }

        private void Button_dot_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text = Check_Remove_Symbol(main_textbox.Text, Button_dot.Content.ToString(), case_sens);

            main_textbox.Text = Check_Line_Status(main_textbox.Text, sr);
        }

        private void Button_back_slash_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text = Check_Remove_Symbol(main_textbox.Text, Button_back_slash.Content.ToString(), case_sens);

            main_textbox.Text = Check_Line_Status(main_textbox.Text, sr);
        }

        private void Button_space_Click(object sender, RoutedEventArgs e)
        {

            main_textbox.Text = Check_Remove_Symbol(main_textbox.Text, " ",case_sens);

            main_textbox.Text = Check_Line_Status(main_textbox.Text, sr);
        }



        private void Case_Sens_Check_box_Checked(object sender, RoutedEventArgs e)
        {
            case_sens = true;
        }

        private void Case_Sens_Check_box_Unchecked(object sender, RoutedEventArgs e)
        {
            case_sens = false;
        }


        private void Button_Start_Click(object sender, RoutedEventArgs e)
        {
            main_textbox.Text = buffer_string;

            main_textbox.Text = Check_Line_Status(main_textbox.Text, sr);

            Keyboard.IsEnabled = true;

            Button_Start.IsEnabled = false; Button_Stop.IsEnabled = true;
        }

        private void Button_Stop_Click(object sender, RoutedEventArgs e)
        {
            buffer_string = main_textbox.Text;

            main_textbox.Text = null;

            Keyboard.IsEnabled = false;

            Button_Start.IsEnabled = true; Button_Stop.IsEnabled = false;


        }
    }
}
