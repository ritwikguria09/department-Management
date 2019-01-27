using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace depertment
{
    public partial class Form1 : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=root");
        public Form1()
        {
            InitializeComponent();
            tabControl3.DrawItem += new DrawItemEventHandler(tabControl3_DrawItem);
            tabControl4.DrawItem += new DrawItemEventHandler(tabControl4_DrawItem);
            tabControl5.DrawItem += new DrawItemEventHandler(tabControl5_DrawItem);
            tabControl6.DrawItem += new DrawItemEventHandler(tabControl6_DrawItem);
            tabControl7.DrawItem += new DrawItemEventHandler(tabControl7_DrawItem);
            tabControl8.DrawItem += new DrawItemEventHandler(tabControl8_DrawItem);

            st_entry_cource_combo.Items.Add("B.sc(H)");
            st_entry_cource_combo.Items.Add("B.sc (G)");
            st_entry_cryr_combo.Items.Add("1st Year");
            st_entry_cryr_combo.Items.Add("2nd Year");
            st_entry_cryr_combo.Items.Add("3rd Year");
            st_entry_cryr_combo.Items.Add("Pass out");
            st_entry_cryr_combo.Items.Add("TC");

            st_edit_cource_combo.Items.Add("B.sc(H)");
            st_edit_cource_combo.Items.Add("B.sc (G)");
            st_edit_cryr_combo.Items.Add("1st Year");
            st_edit_cryr_combo.Items.Add("2nd Year");
            st_edit_cryr_combo.Items.Add("3rd Year");
            st_edit_cryr_combo.Items.Add("Pass out");
            st_edit_cryr_combo.Items.Add("TC");

            li_entry_sourse_combo.Items.Add("Donate");
            li_entry_sourse_combo.Items.Add("Buy");
            li_edit_sourse_combo.Items.Add("Donate");
            li_edit_sourse_combo.Items.Add("Buy");

            ch_entry_quantity_combo.Items.Add("Volume");
            ch_entry_quantity_combo.Items.Add("Pis");
            ch_edit_quantity_combo.Items.Add("Volume");
            ch_edit_quantity_combo.Items.Add("Pis");

            st_entry_img.ImageLocation = "rs\\profile.png";
            li_entry_img.ImageLocation = "rs\\book.jpg";
            in_entry_img.ImageLocation = "rs\\instument.jpg";
            gl_entry_img.ImageLocation = "rs\\glassware.jpg";
            ch_entry_img.ImageLocation = "rs\\chemical.jpg";
            mu_entry_img.ImageLocation = "rs\\museum.jpg";

            admin_password_text.PasswordChar = '*';

            studentview();
            libraryview();
            instumentview();
            glasswareview();
            chemicalview();
            museumview();

            home_panel.Visible = true;
            time();
            issu_date.Text = DateTime.Now.ToLongDateString();
            issu_date.ReadOnly = true;

            issuview();

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label52_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox41_TextChanged(object sender, EventArgs e)
        {

        }

        private void label45_Click(object sender, EventArgs e)
        {

        }

        private void textBox40_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox39_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox38_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox37_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox36_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox35_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox34_TextChanged(object sender, EventArgs e)
        {

        }

        private void label52_Click_1(object sender, EventArgs e)
        {

        }

        private void label51_Click(object sender, EventArgs e)
        {

        }

        private void textBox41_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label49_Click(object sender, EventArgs e)
        {

        }

        private void label48_Click(object sender, EventArgs e)
        {

        }

        private void label47_Click(object sender, EventArgs e)
        {

        }

        private void label46_Click(object sender, EventArgs e)
        {

        }

        private void label50_Click(object sender, EventArgs e)
        {

        }

        private void label60_Click(object sender, EventArgs e)
        {

        }

        private void label59_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void tabControl3_DrawItem(object sender, DrawItemEventArgs e)
        {
            var g = e.Graphics;
            var text = this.tabControl3.TabPages[e.Index].Text;
            var sizeText = g.MeasureString(text, this.tabControl3.Font);

            var x = e.Bounds.Left + 3;
            var y = e.Bounds.Top + (e.Bounds.Height - sizeText.Height) / 2;

            g.DrawString(text, this.tabControl3.Font, Brushes.Black, x, y);
        }

        private void tabControl4_DrawItem(object sender, DrawItemEventArgs e)
        {
            var g = e.Graphics;
            var text = this.tabControl4.TabPages[e.Index].Text;
            var sizeText = g.MeasureString(text, this.tabControl4.Font);

            var x = e.Bounds.Left + 3;
            var y = e.Bounds.Top + (e.Bounds.Height - sizeText.Height) / 2;

            g.DrawString(text, this.tabControl4.Font, Brushes.Black, x, y);
        }
        private void tabControl5_DrawItem(object sender, DrawItemEventArgs e)
        {
            var g = e.Graphics;
            var text = this.tabControl5.TabPages[e.Index].Text;
            var sizeText = g.MeasureString(text, this.tabControl5.Font);

            var x = e.Bounds.Left + 3;
            var y = e.Bounds.Top + (e.Bounds.Height - sizeText.Height) / 2;

            g.DrawString(text, this.tabControl5.Font, Brushes.Black, x, y);
        }
        private void tabControl6_DrawItem(object sender, DrawItemEventArgs e)
        {
            var g = e.Graphics;
            var text = this.tabControl6.TabPages[e.Index].Text;
            var sizeText = g.MeasureString(text, this.tabControl6.Font);

            var x = e.Bounds.Left + 3;
            var y = e.Bounds.Top + (e.Bounds.Height - sizeText.Height) / 2;

            g.DrawString(text, this.tabControl6.Font, Brushes.Black, x, y);
        }
        private void tabControl7_DrawItem(object sender, DrawItemEventArgs e)
        {
            var g = e.Graphics;
            var text = this.tabControl7.TabPages[e.Index].Text;
            var sizeText = g.MeasureString(text, this.tabControl7.Font);

            var x = e.Bounds.Left + 3;
            var y = e.Bounds.Top + (e.Bounds.Height - sizeText.Height) / 2;

            g.DrawString(text, this.tabControl7.Font, Brushes.Black, x, y);
        }
        private void tabControl8_DrawItem(object sender, DrawItemEventArgs e)
        {
            var g = e.Graphics;
            var text = this.tabControl8.TabPages[e.Index].Text;
            var sizeText = g.MeasureString(text, this.tabControl8.Font);

            var x = e.Bounds.Left + 3;
            var y = e.Bounds.Top + (e.Bounds.Height - sizeText.Height) / 2;

            g.DrawString(text, this.tabControl8.Font, Brushes.Black, x, y);
        }

        private void tabPage12_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage14_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            byte[] imageBt = null;
            FileStream fstream = new FileStream(Picpath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
            imageBt = br.ReadBytes((int)fstream.Length);
            String query = "insert into data.student (name,course,roll,session,reg,current_yr,address,phn,email,pass_out,mark1,mark2,mark3,blood,status,img) values('" + this.st_entry_name_text.Text + "','" + this.st_entry_cource_combo.Text + "','" + this.st_entry_clgrool_text.Text + "','" + this.st_entry_session_text.Text + "','" + this.st_entry_regno_text.Text + "','" + this.st_entry_cryr_combo.Text + "','" + this.st_entry_address_text.Text + "','" + this.st_entry_phnno_text.Text + "','" + this.st_entry_email_text.Text + "','" + this.st_entry_yrpasout_text.Text + "','" + this.st_entry_mark1_text.Text + "','" + this.st_entry_mark2_text.Text + "','" + this.st_entry_mark3_text.Text + "','" + this.st_entry_blood_text.Text + "','" + this.st_entry_status_text.Text + "',@IMG);";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader mdr;
            try
            {
                con.Open();
                cmd.Parameters.Add(new MySqlParameter("@IMG", imageBt));
                mdr = cmd.ExecuteReader();
                if (mdr.RecordsAffected == 1)
                {
                    MessageBox.Show("Sucessfully saved");
                    st_entry_img.ImageLocation = "rs\\profile.png";

                    st_entry_name_text.Clear();
                    st_entry_cource_combo.Text = "";
                    st_entry_clgrool_text.Clear();
                    st_entry_session_text.Clear();
                    st_entry_regno_text.Clear();
                    st_entry_cryr_combo.Text = "";
                    st_entry_address_text.Clear();
                    st_entry_phnno_text.Clear();
                    st_entry_email_text.Clear();
                    st_entry_yrpasout_text.Clear();
                    st_entry_mark1_text.Clear();
                    st_entry_mark2_text.Clear();
                    st_entry_mark3_text.Clear();
                    st_entry_blood_text.Clear();
                    st_entry_status_text.Clear();

                    Picpath = "rs\\profile.png";

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                studentview();
            }
        }

        String Picpath = "rs\\profile.png";
        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Picpath = dlg.FileName.ToString();
                st_entry_img.ImageLocation = Picpath;
            }
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            home_panel.Visible = true;
            student_log_panel.Visible = false;
            admin_log_panel.Visible = false;
            student_control_panel.Visible = false;
            admin_control_panel.Visible = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void tabPage11_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

            String query = "select *from data.student where roll = '" + this.st_edit_search_text.Text + "';";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader mdr;
            try
            {
                con.Open();
                mdr = cmd.ExecuteReader();
                if (mdr.Read() == true)
                {
                    st_edit_name_text.Text = mdr.GetString("name");
                    st_edit_cource_combo.Text = mdr.GetString("course");
                    st_edit_clgrool_text.Text = mdr.GetString("roll");
                    st_edit_session_text.Text = mdr.GetString("session");
                    st_edit_regno_text.Text = mdr.GetString("reg");
                    st_edit_cryr_combo.Text = mdr.GetString("current_yr");
                    st_edit_address_text.Text = mdr.GetString("address");
                    st_edit_phnno_text.Text = mdr.GetString("phn");
                    st_edit_email_text.Text = mdr.GetString("email");
                    st_edit_yrpasout_text.Text = mdr.GetString("pass_out");
                    st_edit_mark1_text.Text = mdr.GetString("mark1");
                    st_edit_mark2_text.Text = mdr.GetString("mark2");
                    st_edit_mark3_text.Text = mdr.GetString("mark3");
                    st_edit_blood_text.Text = mdr.GetString("blood");
                    st_edit_status_text.Text = mdr.GetString("status");
                    byte[] imgg = (byte[])(mdr["img"]);
                    if (imgg == null)
                        st_edit_img.ImageLocation = "rs\\profile.png";
                    else
                    {
                        MemoryStream mStream = new MemoryStream(imgg);
                        st_edit_img.Image = System.Drawing.Image.FromStream(mStream);
                    }

                    st_edit_search_text.Clear();

                }
                else
                {
                    MessageBox.Show("Not Found");
                    st_edit_search_text.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            String query = "delete from data.student where roll='" + this.st_edit_clgrool_text.Text + "';";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader mdr;
            try
            {
                con.Open();
                mdr = cmd.ExecuteReader();
                if (mdr.RecordsAffected == 1)
                {
                    MessageBox.Show("Sucessfully Deleted");
                    st_edit_name_text.Clear();
                    st_edit_cource_combo.Text = "";
                    st_edit_clgrool_text.Clear();
                    st_edit_session_text.Clear();
                    st_edit_regno_text.Clear();
                    st_edit_cryr_combo.Text = "";
                    st_edit_address_text.Clear();
                    st_edit_phnno_text.Clear();
                    st_edit_email_text.Clear();
                    st_edit_yrpasout_text.Clear();
                    st_edit_mark1_text.Clear();
                    st_edit_mark2_text.Clear();
                    st_edit_mark3_text.Clear();
                    st_edit_blood_text.Clear();
                    st_edit_status_text.Clear();
                    st_edit_img.ImageLocation = "rs\\profile.png";

                }
                else
                {
                    MessageBox.Show("Not Fond");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                studentview();
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            byte[] imageBt2 = null;
            MySqlCommand cmd2 = new MySqlCommand("select *from data.student where roll='" + this.st_edit_clgrool_text.Text + "'", con);
            MySqlDataReader mdr2;
            try
            {
                con.Open();
                mdr2 = cmd2.ExecuteReader();
                if (mdr2.Read() == true)
                {
                    imageBt2 = (byte[])(mdr2["img"]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            byte[] imageBt = null;
            FileStream fstream = new FileStream(Picpath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
            imageBt = br.ReadBytes((int)fstream.Length);
            String query = "update data.student set name='" + this.st_edit_name_text.Text + "',course='" + this.st_edit_cource_combo.Text + "',roll='" + this.st_edit_clgrool_text.Text + "',session='" + this.st_edit_session_text.Text + "',reg='" + this.st_edit_regno_text.Text + "',current_yr='" + this.st_edit_cryr_combo.Text + "',address='" + this.st_edit_address_text.Text + "',phn='" + this.st_edit_phnno_text.Text + "',email='" + this.st_edit_email_text.Text + "',pass_out='" + this.st_edit_yrpasout_text.Text + "',mark1='" + this.st_edit_mark1_text.Text + "',mark2='" + this.st_edit_mark2_text.Text + "',mark3='" + this.st_edit_mark3_text.Text + "',blood='" + this.st_edit_blood_text.Text + "',status='" + this.st_edit_status_text.Text + "',img=@IMG where roll='" + this.st_edit_clgrool_text.Text + "';";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader mdr;
            try
            {
                con.Open();
                if (Picpath != "rs\\profile.png")
                {
                    cmd.Parameters.Add(new MySqlParameter("@IMG", imageBt));
                }
                else
                {
                    cmd.Parameters.Add(new MySqlParameter("@IMG", imageBt2));
                }
                mdr = cmd.ExecuteReader();
                if (mdr.RecordsAffected == 1)
                {
                    MessageBox.Show("Sucessfully Update");
                    st_edit_name_text.Clear();
                    st_edit_cource_combo.Text = "";
                    st_edit_clgrool_text.Clear();
                    st_edit_session_text.Clear();
                    st_edit_regno_text.Clear();
                    st_edit_cryr_combo.Text = "";
                    st_edit_address_text.Clear();
                    st_edit_phnno_text.Clear();
                    st_edit_email_text.Clear();
                    st_edit_yrpasout_text.Clear();
                    st_edit_mark1_text.Clear();
                    st_edit_mark2_text.Clear();
                    st_edit_mark3_text.Clear();
                    st_edit_blood_text.Clear();
                    st_edit_status_text.Clear();
                    st_edit_img.ImageLocation = "rs\\profile.png";

                    Picpath = "rs\\profile.png";

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                studentview();
            }

        }

        private void button22_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Picpath = dlg.FileName.ToString();
                st_edit_img.ImageLocation = Picpath;
            }
        }

        DataTable dt;
        private void studentview()
        {
            String query = "select name as 'Name', roll as 'Clg Roll',reg as 'Reg No',session as 'Session',course as 'Course',current_yr as 'Now In', phn as 'Phn No',email as 'Email ID',mark1 as 'Part-I',mark2 as 'Part-II',mark3 as 'Part-III',status as 'Status' from data.student;";
            MySqlCommand cmd = new MySqlCommand(query, con);
            try
            {
                con.Open();
                MySqlDataAdapter sda = new MySqlDataAdapter();
                dt = new DataTable();
                BindingSource bSourse = new BindingSource();
                sda.SelectCommand = cmd;
                sda.Fill(dt);
                bSourse.DataSource = dt;
                st_dataview.DataSource = bSourse;
                sda.Update(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void st_view_text_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dt);
            DV.RowFilter = String.Format("name LIKE '%{0}%'", st_view_text.Text);
            st_dataview.DataSource = DV;

        }

        String Select;
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Select = "admin";

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Select = "student";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Select == "admin")
            {
                home_panel.Visible = false;
                student_log_panel.Visible = false;
                admin_log_panel.Visible = true;
                student_control_panel.Visible = false;
                admin_control_panel.Visible = false;
            }
            if (Select == "student")
            {
                home_panel.Visible = false;
                student_log_panel.Visible = true;
                admin_log_panel.Visible = false;
                student_control_panel.Visible = false;
                admin_control_panel.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (admin_user_text.Text == "admin" && admin_password_text.Text == "root")
            {
                home_panel.Visible = false;
                student_log_panel.Visible = false;
                admin_log_panel.Visible = false;
                student_control_panel.Visible = false;
                admin_control_panel.Visible = true;
                Form1 f1 = new Form1();
                f1.WindowState = FormWindowState.Normal;
                admin_password_text.Clear();
                admin_user_text.Clear();
            }
            else
            {
                MessageBox.Show("Wrong Username and Password");
                admin_password_text.Clear();
                admin_user_text.Clear();
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            home_panel.Visible = true;
            student_log_panel.Visible = false;
            admin_log_panel.Visible = false;
            student_control_panel.Visible = false;
            admin_control_panel.Visible = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            home_panel.Visible = true;
            student_log_panel.Visible = false;
            admin_log_panel.Visible = false;
            student_control_panel.Visible = false;
            admin_control_panel.Visible = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            home_panel.Visible = true;
            student_log_panel.Visible = false;
            admin_log_panel.Visible = false;
            student_control_panel.Visible = false;
            admin_control_panel.Visible = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            home_panel.Visible = true;
            student_log_panel.Visible = false;
            admin_log_panel.Visible = false;
            student_control_panel.Visible = false;
            admin_control_panel.Visible = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            home_panel.Visible = true;
            student_log_panel.Visible = false;
            admin_log_panel.Visible = false;
            student_control_panel.Visible = false;
            admin_control_panel.Visible = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            home_panel.Visible = true;
            student_log_panel.Visible = false;
            admin_log_panel.Visible = false;
            student_control_panel.Visible = false;
            admin_control_panel.Visible = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void tabPage20_Click(object sender, EventArgs e)
        {

        }

        private void tabPage12_Click_1(object sender, EventArgs e)
        {

        }

        private void li_entry_sourse_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (li_entry_sourse_combo.Text == "Donate")
            {
                li_entry_cost_text.ReadOnly = true;
            }
            if (li_entry_sourse_combo.Text == "Buy")
            {
                li_entry_cost_text.ReadOnly = false;
            }
        }

        private void li_edit_sourse_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (li_edit_sourse_combo.Text == "Donate")
            {
                li_edit_cost_text.ReadOnly = true;
            }
            if (li_edit_sourse_combo.Text == "Buy")
            {
                li_edit_cost_text.ReadOnly = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            byte[] imageBt = null;
            FileStream fstream = new FileStream(li_picpath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
            imageBt = br.ReadBytes((int)fstream.Length);
            String query = "insert into data.library (id,name,auther,edition,isbn,date,sourse,cost,wis,remark,img) values('" + this.li_entry_id_text.Text + "','" + this.li_entry_name_text.Text + "','" + this.li_entry_auther_text.Text + "','" + this.li_entry_edition_text.Text + "','" + this.li_entry_isbn_text.Text + "','" + this.li_entry_date_text.Text + "','" + this.li_entry_sourse_combo.Text + "','" + this.li_entry_cost_text.Text + "','" + this.li_entry_wis_text.Text + "','" + this.li_entry_remark_text.Text + "',@IMG);";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader mdr;
            try
            {
                con.Open();
                cmd.Parameters.Add(new MySqlParameter("@IMG", imageBt));
                mdr = cmd.ExecuteReader();
                if (mdr.RecordsAffected == 1)
                {
                    MessageBox.Show("Sucessfully saved");
                    li_entry_img.ImageLocation = "rs\\book.jpg";

                    li_entry_id_text.Clear();
                    li_entry_name_text.Clear();
                    li_entry_auther_text.Clear();
                    li_entry_edition_text.Clear();
                    li_entry_isbn_text.Clear();
                    li_entry_date_text.Clear();
                    li_entry_sourse_combo.Text = "";
                    li_entry_cost_text.Clear();
                    li_entry_wis_text.Clear();
                    li_entry_remark_text.Clear();

                    li_picpath = "rs\\book.jpg";

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
        String li_picpath = "rs\\book.jpg";
        private void button9_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                li_picpath = dlg.FileName.ToString();
                li_entry_img.ImageLocation = li_picpath;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            byte[] imageBt = null;
            FileStream fstream = new FileStream(in_picpath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
            imageBt = br.ReadBytes((int)fstream.Length);
            String query = "insert into data.instument (id,name,company,date,fun,status,img) values('" + this.in_entry_id_text.Text + "','" + this.in_entry_name_text.Text + "','" + this.in_entry_company_text.Text + "','" + this.in_entry_date_text.Text + "','" + this.in_entry_fun_text.Text + "','" + this.in_entry_status_text.Text + "',@IMG);";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader mdr;
            try
            {
                con.Open();
                cmd.Parameters.Add(new MySqlParameter("@IMG", imageBt));
                mdr = cmd.ExecuteReader();
                if (mdr.RecordsAffected == 1)
                {
                    MessageBox.Show("Sucessfully saved");
                    in_entry_img.ImageLocation = "rs\\instument.jpg";

                    in_entry_id_text.Clear();
                    in_entry_name_text.Clear();
                    in_entry_company_text.Clear();
                    in_entry_date_text.Clear();
                    in_entry_fun_text.Clear();
                    in_entry_status_text.Clear();
                    

                    in_picpath = "rs\\instument.jpg";

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                libraryview();
            }
        }

        String in_picpath = "rs\\instument.jpg";
        private void button20_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                in_picpath = dlg.FileName.ToString();
                in_entry_img.ImageLocation = in_picpath;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            byte[] imageBt = null;
            FileStream fstream = new FileStream(gl_picpath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
            imageBt = br.ReadBytes((int)fstream.Length);
            String query = "insert into data.glassware (id,name,company,date,fun,status,img) values('" + this.gl_entry_id_text.Text + "','" + this.gl_entry_name_text.Text + "','" + this.gl_entry_company_text.Text + "','" + this.gl_entry_date_text.Text + "','" + this.gl_entry_fun_text.Text + "','" + this.gl_entry_status_text.Text + "',@IMG);";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader mdr;
            try
            {
                con.Open();
                cmd.Parameters.Add(new MySqlParameter("@IMG", imageBt));
                mdr = cmd.ExecuteReader();
                if (mdr.RecordsAffected == 1)
                {
                    MessageBox.Show("Sucessfully saved");
                    gl_entry_img.ImageLocation = "rs\\glassware.jpg";

                    gl_entry_id_text.Clear();
                    gl_entry_name_text.Clear();
                    gl_entry_company_text.Clear();
                    gl_entry_date_text.Clear();
                    gl_entry_fun_text.Clear();
                    gl_entry_status_text.Clear();


                    gl_picpath = "rs\\glassware.jpg";

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                glasswareview();
            }
        }

        String gl_picpath = "rs\\glassware.jpg";
        private void button18_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                gl_picpath = dlg.FileName.ToString();
                gl_entry_img.ImageLocation = gl_picpath;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            byte[] imageBt = null;
            FileStream fstream = new FileStream(ch_picpath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
            imageBt = br.ReadBytes((int)fstream.Length);
            String query = "insert into data.chemical (id,name,formula,company,quantity,amount,datei,datep,ststus,img) values('" + this.ch_entry_id_text.Text + "','" + this.ch_entry_name_text.Text + "','" + this.ch_entry_formula_text.Text + "','" + this.ch_entry_company_text.Text + "','" + this.ch_entry_quantity_combo.Text + "','" + this.ch_entry_amount_text.Text + "','"+this.ch_entry_dateissu_text.Text+"','"+this.ch_entry_datepur_text.Text+"','"+this.ch_entry_status_text.Text+"',@IMG);";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader mdr;
            try
            {
                con.Open();
                cmd.Parameters.Add(new MySqlParameter("@IMG", imageBt));
                mdr = cmd.ExecuteReader();
                if (mdr.RecordsAffected == 1)
                {
                    MessageBox.Show("Sucessfully saved");
                    ch_entry_img.ImageLocation = "rs\\chemical.jpg";

                    ch_entry_id_text.Clear();
                    ch_entry_name_text.Clear();
                    ch_entry_formula_text.Clear();
                    ch_entry_company_text.Clear();
                    ch_entry_quantity_combo.Text = "";
                    ch_entry_amount_text.Clear();
                    ch_entry_dateissu_text.Clear();
                    ch_entry_datepur_text.Clear();
                    ch_entry_status_text.Clear();


                    ch_picpath = "rs\\chemical.jpg";

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                chemicalview();
            }
        }

        String ch_picpath = "rs\\chemical.jpg";
        private void button14_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                ch_picpath = dlg.FileName.ToString();
                ch_entry_img.ImageLocation = ch_picpath;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            byte[] imageBt = null;
            FileStream fstream = new FileStream(mu_picpath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
            imageBt = br.ReadBytes((int)fstream.Length);
            String query = "insert into data.museum (id,name,syname,source,date,type,selfno,remark,img) values('" + this.mu_entry_id_text.Text + "','" + this.mu_entry_name_text.Text + "','" + this.mu_entry_syname_text.Text + "','" + this.mu_entry_source_text.Text + "','" + this.mu_entry_date_text.Text + "','" + this.mu_entry_type_text.Text + "','" + this.mu_entry_selfno_text.Text + "','" + this.mu_entry_remark_text.Text + "',@IMG);";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader mdr;
            try
            {
                con.Open();
                cmd.Parameters.Add(new MySqlParameter("@IMG", imageBt));
                mdr = cmd.ExecuteReader();
                if (mdr.RecordsAffected == 1)
                {
                    MessageBox.Show("Sucessfully saved");
                    mu_entry_img.ImageLocation = "rs\\museum.jpg";

                    mu_entry_id_text.Clear();
                    mu_entry_name_text.Clear();
                    mu_entry_syname_text.Clear();
                    mu_entry_source_text.Clear();
                    mu_entry_date_text.Clear();
                    mu_entry_type_text.Clear();
                    mu_entry_selfno_text.Clear();
                    mu_entry_remark_text.Clear();

                    mu_picpath = "rs\\museum.jpg";

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                museumview();
            }
        }

        String mu_picpath = "rs\\museum.jpg";
        private void button16_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                mu_picpath = dlg.FileName.ToString();
                mu_entry_img.ImageLocation = mu_picpath;
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            String query = "select *from data.library where id = '" + this.li_search_text.Text + "';";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader mdr;
            try
            {
                con.Open();
                mdr = cmd.ExecuteReader();
                if (mdr.Read() == true)
                {
                    li_edit_id_text.Text = mdr.GetString("id");
                    li_edit_name_text.Text = mdr.GetString("name");
                    li_edit_auther_text.Text = mdr.GetString("auther");
                    li_edit_edition_text.Text = mdr.GetString("edition");
                    li_edit_isbn_text.Text = mdr.GetString("isbn");
                    li_edit_date_text.Text = mdr.GetString("date");
                    li_edit_sourse_combo.Text = mdr.GetString("sourse");
                    li_edit_cost_text.Text = mdr.GetString("cost");
                    li_edit_wis_text.Text = mdr.GetString("wis");
                    li_edit_remark_text.Text = mdr.GetString("remark");

                    byte[] imgg = (byte[])(mdr["img"]);
                    if (imgg == null)
                        li_edit_img.ImageLocation = "rs\\library.jpg";
                    else
                    {
                        MemoryStream mStream = new MemoryStream(imgg);
                        li_edit_img.Image = System.Drawing.Image.FromStream(mStream);
                    }

                    li_search_text.Clear();

                }
                else
                {
                    MessageBox.Show("Not Found");
                    li_search_text.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button43_Click(object sender, EventArgs e)
        {
            String query = "select *from data.instument where id = '" + this.in_search_text.Text + "';";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader mdr;
            try
            {
                con.Open();
                mdr = cmd.ExecuteReader();
                if (mdr.Read() == true)
                {
                    in_edit_id_text.Text = mdr.GetString("id");
                    in_edit_name_text.Text = mdr.GetString("name");
                    in_edit_company_text.Text = mdr.GetString("company");
                    in_edit_date_text.Text = mdr.GetString("date");
                    in_edit_fun_text.Text = mdr.GetString("fun");
                    in_edit_status_text.Text = mdr.GetString("status");

                    byte[] imgg = (byte[])(mdr["img"]);
                    if (imgg == null)
                        in_edit_img.ImageLocation = "rs\\instument.jpg";
                    else
                    {
                        MemoryStream mStream = new MemoryStream(imgg);
                        in_edit_img.Image = System.Drawing.Image.FromStream(mStream);
                    }

                    in_search_text.Clear();

                }
                else
                {
                    MessageBox.Show("Not Found");
                    in_search_text.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            String query = "select *from data.glassware where id = '" + this.gl_search_text.Text + "';";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader mdr;
            try
            {
                con.Open();
                mdr = cmd.ExecuteReader();
                if (mdr.Read() == true)
                {
                    gl_edit_id_text.Text = mdr.GetString("id");
                    gl_edit_name_text.Text = mdr.GetString("name");
                    gl_edit_company_text.Text = mdr.GetString("company");
                    gl_edit_date_text.Text = mdr.GetString("date");
                    gl_edit_fun_text.Text = mdr.GetString("fun");
                    gl_edit_status_text.Text = mdr.GetString("status");

                    byte[] imgg = (byte[])(mdr["img"]);
                    if (imgg == null)
                        gl_edit_img.ImageLocation = "rs\\glassware.jpg";
                    else
                    {
                        MemoryStream mStream = new MemoryStream(imgg);
                        in_edit_img.Image = System.Drawing.Image.FromStream(mStream);
                    }

                    gl_search_text.Clear();

                }
                else
                {
                    MessageBox.Show("Not Found");
                    gl_search_text.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button45_Click(object sender, EventArgs e)
        {
            String query = "select *from data.chemical where id = '" + this.ch_search_text.Text + "';";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader mdr;
            try
            {
                con.Open();
                mdr = cmd.ExecuteReader();
                if (mdr.Read() == true)
                {
                    ch_edit_id_text.Text = mdr.GetString("id");
                    ch_edit_name_text.Text = mdr.GetString("name");
                    ch_edit_formula_text.Text = mdr.GetString("formula");
                    ch_edit_company_text.Text = mdr.GetString("company");
                    ch_edit_quantity_combo.Text = mdr.GetString("quantity");
                    ch_edit_amount_text.Text = mdr.GetString("amount");
                    ch_edit_dateissu_text.Text = mdr.GetString("datei");
                    ch_edit_datepur_text.Text = mdr.GetString("datep");
                    ch_edit_status_text.Text = mdr.GetString("ststus");

                    byte[] imgg = (byte[])(mdr["img"]);
                    if (imgg == null)
                        ch_edit_img.ImageLocation = "rs\\chemical.jpg";
                    else
                    {
                        MemoryStream mStream = new MemoryStream(imgg);
                        ch_edit_img.Image = System.Drawing.Image.FromStream(mStream);
                    }

                    ch_search_text.Clear();

                }
                else
                {
                    MessageBox.Show("Not Found");
                    ch_search_text.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button46_Click(object sender, EventArgs e)
        {
            String query = "select *from data.museum where id = '" + this.mu_search_text.Text + "';";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader mdr;
            try
            {
                con.Open();
                mdr = cmd.ExecuteReader();
                if (mdr.Read() == true)
                {
                    mu_edit_id_text.Text = mdr.GetString("id");
                    mu_edit_name_text.Text = mdr.GetString("name");
                    mu_edit_syname_text.Text = mdr.GetString("syname");
                    mu_edit_source_text.Text = mdr.GetString("source");
                    mu_edit_date_text.Text = mdr.GetString("date");
                    mu_edit_type_text.Text = mdr.GetString("type");
                    mu_edit_selfno_text.Text = mdr.GetString("selfno");
                    mu_edit_remark_text.Text = mdr.GetString("remark");

                    byte[] imgg = (byte[])(mdr["img"]);
                    if (imgg == null)
                        mu_edit_img.ImageLocation = "rs\\museum.jpg";
                    else
                    {
                        MemoryStream mStream = new MemoryStream(imgg);
                        mu_edit_img.Image = System.Drawing.Image.FromStream(mStream);
                    }

                    mu_search_text.Clear();

                }
                else
                {
                    MessageBox.Show("Not Found");
                    mu_search_text.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            byte[] imageBt2 = null;
            MySqlCommand cmd2 = new MySqlCommand("select *from data.library where id='" + this.li_edit_id_text.Text + "'", con);
            MySqlDataReader mdr2;
            try
            {
                con.Open();
                mdr2 = cmd2.ExecuteReader();
                if (mdr2.Read() == true)
                {
                    imageBt2 = (byte[])(mdr2["img"]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            byte[] imageBt = null;
            FileStream fstream = new FileStream(li_picpath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
            imageBt = br.ReadBytes((int)fstream.Length);
            String query = "update data.library set id='" + this.li_entry_id_text.Text + "',name='" + this.li_edit_name_text.Text + "',auther='" + this.li_edit_auther_text.Text + "',edition='" + this.li_edit_edition_text.Text + "',isbn='" + this.li_edit_isbn_text.Text + "',date='" + this.li_edit_date_text.Text + "',sourse='" + this.li_edit_sourse_combo.Text + "',cost='" + this.li_edit_cost_text.Text + "',wis='" + this.li_edit_wis_text.Text + "',remark='" + this.li_edit_remark_text.Text + "',img=@IMG where id='" + this.li_edit_id_text.Text + "';";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader mdr;
            try
            {
                con.Open();
                if (li_picpath != "rs\\book.jpg")
                {
                    cmd.Parameters.Add(new MySqlParameter("@IMG", imageBt));
                }
                else
                {
                    cmd.Parameters.Add(new MySqlParameter("@IMG", imageBt2));
                }
                mdr = cmd.ExecuteReader();
                if (mdr.RecordsAffected == 1)
                {
                    MessageBox.Show("Sucessfully Update");
                    li_edit_id_text.Clear();
                    li_edit_name_text.Clear();
                    li_edit_auther_text.Clear();
                    li_edit_edition_text.Clear();
                    li_edit_isbn_text.Clear();
                    li_edit_date_text.Clear();
                    li_edit_sourse_combo.Text = "";
                    li_edit_cost_text.Clear();
                    li_edit_wis_text.Clear();
                    li_edit_remark_text.Clear();

                    li_edit_img.ImageLocation = "rs\\book.jpg";

                    li_picpath = "rs\\book.jpg";

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                libraryview();
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                li_picpath = dlg.FileName.ToString();
                li_edit_img.ImageLocation = li_picpath;
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            byte[] imageBt2 = null;
            MySqlCommand cmd2 = new MySqlCommand("select *from data.instument where id='" + this.in_edit_id_text.Text + "'", con);
            MySqlDataReader mdr2;
            try
            {
                con.Open();
                mdr2 = cmd2.ExecuteReader();
                if (mdr2.Read() == true)
                {
                    imageBt2 = (byte[])(mdr2["img"]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            byte[] imageBt = null;
            FileStream fstream = new FileStream(in_picpath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
            imageBt = br.ReadBytes((int)fstream.Length);
            String query = "update data.instument set id='" + this.in_edit_id_text.Text + "',name='" + this.in_edit_name_text.Text + "',company='" + this.in_edit_company_text.Text + "',date='" + this.in_edit_date_text.Text + "',fun='" + this.in_edit_fun_text.Text + "',status='" + this.in_edit_status_text.Text + "',img=@IMG where id='" + this.in_edit_id_text.Text + "';";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader mdr;
            try
            {
                con.Open();
                if (in_picpath != "rs\\instument.jpg")
                {
                    cmd.Parameters.Add(new MySqlParameter("@IMG", imageBt));
                }
                else
                {
                    cmd.Parameters.Add(new MySqlParameter("@IMG", imageBt2));
                }
                mdr = cmd.ExecuteReader();
                if (mdr.RecordsAffected == 1)
                {
                    MessageBox.Show("Sucessfully Update");
                    in_edit_id_text.Clear();
                    in_edit_name_text.Clear();
                    in_edit_company_text.Clear();
                    in_edit_date_text.Clear();
                    in_edit_fun_text.Clear();
                    in_edit_status_text.Clear();
                    

                    in_edit_img.ImageLocation = "rs\\instument.jpg";

                    in_picpath = "rs\\instument.jpg";

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                instumentview();
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                in_picpath = dlg.FileName.ToString();
                in_edit_img.ImageLocation = in_picpath;
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            byte[] imageBt2 = null;
            MySqlCommand cmd2 = new MySqlCommand("select *from data.glassware where id='" + this.gl_edit_id_text.Text + "'", con);
            MySqlDataReader mdr2;
            try
            {
                con.Open();
                mdr2 = cmd2.ExecuteReader();
                if (mdr2.Read() == true)
                {
                    imageBt2 = (byte[])(mdr2["img"]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            byte[] imageBt = null;
            FileStream fstream = new FileStream(gl_picpath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
            imageBt = br.ReadBytes((int)fstream.Length);
            String query = "update data.glassware set id='" + this.gl_edit_id_text.Text + "',name='" + this.gl_edit_name_text.Text + "',company='" + this.gl_edit_company_text.Text + "',date='" + this.gl_edit_date_text.Text + "',fun='" + this.gl_edit_fun_text.Text + "',status='" + this.gl_edit_status_text.Text + "',img=@IMG where id='" + this.gl_edit_id_text.Text + "';";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader mdr;
            try
            {
                con.Open();
                if (gl_picpath != "rs\\glassware.jpg")
                {
                    cmd.Parameters.Add(new MySqlParameter("@IMG", imageBt));
                }
                else
                {
                    cmd.Parameters.Add(new MySqlParameter("@IMG", imageBt2));
                }
                mdr = cmd.ExecuteReader();
                if (mdr.RecordsAffected == 1)
                {
                    MessageBox.Show("Sucessfully Update");
                    gl_edit_id_text.Clear();
                    gl_edit_name_text.Clear();
                    gl_edit_company_text.Clear();
                    gl_edit_date_text.Clear();
                    gl_edit_fun_text.Clear();
                    gl_edit_status_text.Clear();


                    gl_edit_img.ImageLocation = "rs\\glassware.jpg";

                    gl_picpath = "rs\\glassware.jpg";

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                glasswareview();
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                gl_picpath = dlg.FileName.ToString();
                gl_edit_img.ImageLocation = gl_picpath;
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            byte[] imageBt2 = null;
            MySqlCommand cmd2 = new MySqlCommand("select *from data.chemical where id='" + this.ch_edit_id_text.Text + "'", con);
            MySqlDataReader mdr2;
            try
            {
                con.Open();
                mdr2 = cmd2.ExecuteReader();
                if (mdr2.Read() == true)
                {
                    imageBt2 = (byte[])(mdr2["img"]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            byte[] imageBt = null;
            FileStream fstream = new FileStream(ch_picpath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
            imageBt = br.ReadBytes((int)fstream.Length);
            String query = "update data.chemical set id='" + this.ch_edit_id_text.Text + "',name='" + this.ch_edit_name_text.Text + "',formula='" + this.ch_edit_formula_text.Text + "',company='" + this.ch_edit_company_text.Text + "',quantity='" + this.ch_edit_quantity_combo.Text + "',amount='" + this.ch_edit_amount_text.Text + "',datei='" + this.ch_edit_dateissu_text.Text + "',datep='" + this.ch_edit_datepur_text.Text + "',ststus='" + this.ch_edit_status_text.Text + "',img=@IMG where id='" + this.ch_edit_id_text.Text + "';";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader mdr;
            try
            {
                con.Open();
                if (ch_picpath != "rs\\chemical.jpg")
                {
                    cmd.Parameters.Add(new MySqlParameter("@IMG", imageBt));
                }
                else
                {
                    cmd.Parameters.Add(new MySqlParameter("@IMG", imageBt2));
                }
                mdr = cmd.ExecuteReader();
                if (mdr.RecordsAffected == 1)
                {
                    MessageBox.Show("Sucessfully Update");
                    ch_edit_id_text.Clear();
                    ch_edit_name_text.Clear();
                    ch_edit_formula_text.Clear();
                    ch_edit_company_text.Clear();
                    ch_edit_quantity_combo.Text = "";
                    ch_edit_amount_text.Clear();
                    ch_edit_dateissu_text.Clear();
                    ch_edit_datepur_text.Clear();
                    ch_edit_status_text.Clear();

                    ch_edit_img.ImageLocation = "rs\\chemical.jpg";

                    ch_picpath = "rs\\chemical.jpg";

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                chemicalview();
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                ch_picpath = dlg.FileName.ToString();
                ch_edit_img.ImageLocation = ch_picpath;
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            byte[] imageBt2 = null;
            MySqlCommand cmd2 = new MySqlCommand("select *from data.museum where id='" + this.mu_edit_id_text.Text + "'", con);
            MySqlDataReader mdr2;
            try
            {
                con.Open();
                mdr2 = cmd2.ExecuteReader();
                if (mdr2.Read() == true)
                {
                    imageBt2 = (byte[])(mdr2["img"]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            byte[] imageBt = null;
            FileStream fstream = new FileStream(mu_picpath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
            imageBt = br.ReadBytes((int)fstream.Length);
            String query = "update data.museum set id='" + this.mu_edit_id_text.Text + "',name='" + this.mu_edit_name_text.Text + "',syname='" + this.mu_edit_syname_text.Text + "',source='" + this.mu_edit_source_text.Text + "',date='" + this.mu_edit_date_text.Text + "',type='" + this.mu_edit_type_text.Text + "',selfno='" + this.mu_edit_selfno_text.Text + "',remark='" + this.mu_edit_remark_text.Text + "',img=@IMG where id='" + this.mu_edit_id_text.Text + "';";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader mdr;
            try
            {
                con.Open();
                if (mu_picpath != "rs\\museum.jpg")
                {
                    cmd.Parameters.Add(new MySqlParameter("@IMG", imageBt));
                }
                else
                {
                    cmd.Parameters.Add(new MySqlParameter("@IMG", imageBt2));
                }
                mdr = cmd.ExecuteReader();
                if (mdr.RecordsAffected == 1)
                {
                    MessageBox.Show("Sucessfully Update");
                    mu_edit_id_text.Clear();
                    mu_edit_name_text.Clear();
                    mu_edit_syname_text.Clear();
                    mu_edit_source_text.Clear();
                    mu_edit_date_text.Clear();
                    mu_edit_type_text.Clear();
                    mu_edit_selfno_text.Clear();
                    mu_edit_remark_text.Clear();

                    mu_edit_img.ImageLocation = "rs\\museum.jpg";

                    mu_picpath = "rs\\museum.jpg";

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                museumview();
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                mu_picpath = dlg.FileName.ToString();
                mu_edit_img.ImageLocation = mu_picpath;
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            String query = "delete from data.library where id='" + this.li_edit_id_text.Text + "';";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader mdr;
            try
            {
                con.Open();
                mdr = cmd.ExecuteReader();
                if (mdr.RecordsAffected == 1)
                {
                    MessageBox.Show("Sucessfully Deleted");
                    li_edit_id_text.Clear();
                    li_edit_name_text.Clear();
                    li_edit_auther_text.Clear();
                    li_edit_edition_text.Clear();
                    li_edit_isbn_text.Clear();
                    li_edit_date_text.Clear();
                    li_edit_sourse_combo.Text = "";
                    li_edit_cost_text.Clear();
                    li_edit_wis_text.Clear();
                    li_edit_remark_text.Clear();
                   li_edit_img.ImageLocation = "rs\\book.jpg";

                }
                else
                {
                    MessageBox.Show("Not Fond");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                libraryview();
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            String query = "delete from data.instument where id='" + this.in_edit_id_text.Text + "';";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader mdr;
            try
            {
                con.Open();
                mdr = cmd.ExecuteReader();
                if (mdr.RecordsAffected == 1)
                {
                    MessageBox.Show("Sucessfully Deleted");
                    in_edit_id_text.Clear();
                    in_edit_name_text.Clear();
                    in_edit_company_text.Clear();
                    in_edit_date_text.Clear();
                    in_edit_fun_text.Clear();
                    in_edit_status_text.Clear();
                    in_edit_img.ImageLocation = "rs\\instument.jpg";

                }
                else
                {
                    MessageBox.Show("Not Fond");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                instumentview();
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            String query = "delete from data.glassware where id='" + this.gl_edit_id_text.Text + "';";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader mdr;
            try
            {
                con.Open();
                mdr = cmd.ExecuteReader();
                if (mdr.RecordsAffected == 1)
                {
                    MessageBox.Show("Sucessfully Deleted");
                    gl_edit_id_text.Clear();
                    gl_edit_name_text.Clear();
                    gl_edit_company_text.Clear();
                    gl_edit_date_text.Clear();
                    gl_edit_fun_text.Clear();
                    gl_edit_status_text.Clear();
                    gl_edit_img.ImageLocation = "rs\\glassware.jpg";

                }
                else
                {
                    MessageBox.Show("Not Fond");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                glasswareview();
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            String query = "delete from data.chemical where id='" + this.ch_edit_id_text.Text + "';";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader mdr;
            try
            {
                con.Open();
                mdr = cmd.ExecuteReader();
                if (mdr.RecordsAffected == 1)
                {
                    MessageBox.Show("Sucessfully Deleted");
                    ch_edit_id_text.Clear();
                    ch_edit_name_text.Clear();
                    ch_edit_formula_text.Clear();
                    ch_edit_company_text.Clear();
                    ch_edit_quantity_combo.Text = "";
                    ch_edit_amount_text.Clear();
                    ch_edit_dateissu_text.Clear();
                    ch_edit_datepur_text.Clear();
                    ch_edit_status_text.Clear();
                    ch_edit_img.ImageLocation = "rs\\chemical.jpg";

                }
                else
                {
                    MessageBox.Show("Not Fond");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                chemicalview();
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            String query = "delete from data.museum where id='" + this.mu_edit_id_text.Text + "';";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader mdr;
            try
            {
                con.Open();
                mdr = cmd.ExecuteReader();
                if (mdr.RecordsAffected == 1)
                {
                    MessageBox.Show("Sucessfully Deleted");
                    mu_edit_id_text.Clear();
                    mu_edit_name_text.Clear();
                    mu_edit_syname_text.Clear();
                    mu_edit_source_text.Clear();
                    mu_edit_date_text.Clear();
                    mu_edit_type_text.Clear();
                    mu_edit_selfno_text.Clear();
                    mu_edit_remark_text.Clear();
                    mu_edit_img.ImageLocation = "rs\\museum.jpg";

                }
                else
                {
                    MessageBox.Show("Not Fond");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                museumview();
            }
        }

        DataTable li_dt;
        void libraryview()
        {
            String query = "select id as 'ID', name as 'Name',auther as 'Author',edition as 'Edition',isbn as 'ISBN/ISSN',date as 'Entry Date',sourse 'Source',cost as 'Cost',wis as 'Now in',remark as 'Remark' from data.library;";
            MySqlCommand cmd = new MySqlCommand(query, con);
            try
            {
                con.Open();
                MySqlDataAdapter sda = new MySqlDataAdapter();
                li_dt = new DataTable();
                BindingSource bSourse = new BindingSource();
                sda.SelectCommand = cmd;
                sda.Fill(li_dt);
                bSourse.DataSource = li_dt;
                li_dataview.DataSource = bSourse;
                st_li_dataview.DataSource = bSourse;
                sda.Update(li_dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        DataTable in_dt;
        void instumentview()
        {
            String query = "select id as 'ID', name as 'Name',company as 'Company',date as 'Entry Date',fun as 'Function',status as 'Status' from data.instument;";
            MySqlCommand cmd = new MySqlCommand(query, con);
            try
            {
                con.Open();
                MySqlDataAdapter sda = new MySqlDataAdapter();
                in_dt = new DataTable();
                BindingSource bSourse = new BindingSource();
                sda.SelectCommand = cmd;
                sda.Fill(in_dt);
                bSourse.DataSource = in_dt;
                in_dataview.DataSource = bSourse;
                st_in_dataview.DataSource = bSourse;
                sda.Update(in_dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        DataTable gl_dt;
        void glasswareview()
        {
            String query = "select id as 'ID', name as 'Name',company as 'Company',date as 'Entry Date',fun as 'Function',status as 'Status' from data.glassware;";
            MySqlCommand cmd = new MySqlCommand(query, con);
            try
            {
                con.Open();
                MySqlDataAdapter sda = new MySqlDataAdapter();
                gl_dt = new DataTable();
                BindingSource bSourse = new BindingSource();
                sda.SelectCommand = cmd;
                sda.Fill(gl_dt);
                bSourse.DataSource = gl_dt;
                gl_dataview.DataSource = bSourse;
                st_gl_dataview.DataSource = bSourse;
                sda.Update(gl_dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        DataTable ch_dt;
        void chemicalview()
        {
            String query = "select id as 'ID', name as 'Name',formula as 'Formula',company as 'Company',quantity as 'Quantity',amount as 'Amount',datei as 'Date of issue',datep as'Date of purchase',ststus as 'Status' from data.chemical;";
            MySqlCommand cmd = new MySqlCommand(query, con);
            try
            {
                con.Open();
                MySqlDataAdapter sda = new MySqlDataAdapter();
                ch_dt = new DataTable();
                BindingSource bSourse = new BindingSource();
                sda.SelectCommand = cmd;
                sda.Fill(ch_dt);
                bSourse.DataSource = ch_dt;
                ch_dataview.DataSource = bSourse;
                st_ch_dataview.DataSource = bSourse;
                sda.Update(ch_dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        DataTable mu_dt;
        void museumview()
        {
            String query = "select id as 'ID', name as 'Name',syname as 'Scientific name',source as 'Source',date as 'Entry Date',type as 'Type',selfno as 'Self or Almirah no',remark as'Remark' from data.museum;";
            MySqlCommand cmd = new MySqlCommand(query, con);
            try
            {
                con.Open();
                MySqlDataAdapter sda = new MySqlDataAdapter();
                mu_dt = new DataTable();
                BindingSource bSourse = new BindingSource();
                sda.SelectCommand = cmd;
                sda.Fill(mu_dt);
                bSourse.DataSource = mu_dt;
                mu_dataview.DataSource = bSourse;
                st_mu_dataview.DataSource = bSourse;
                sda.Update(mu_dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void st_dataview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox83_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(li_dt);
            DV.RowFilter = String.Format("name LIKE '%{0}%'", textBox83.Text);
            li_dataview.DataSource = DV;
        }

        private void textBox84_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(in_dt);
            DV.RowFilter = String.Format("name LIKE '%{0}%'", textBox84.Text);
            in_dataview.DataSource = DV;
        }

        private void textBox85_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(gl_dt);
            DV.RowFilter = String.Format("name LIKE '%{0}%'", textBox85.Text);
            gl_dataview.DataSource = DV;
        }

        private void textBox86_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(ch_dt);
            DV.RowFilter = String.Format("name LIKE '%{0}%'", textBox86.Text);
            ch_dataview.DataSource = DV;
        }

        private void textBox87_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(mu_dt);
            DV.RowFilter = String.Format("name LIKE '%{0}%'", textBox87.Text);
            mu_dataview.DataSource = DV;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dt);
            DV.RowFilter = String.Format("session LIKE '%{0}%'", textBox5.Text);
            st_dataview.DataSource = DV;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(li_dt);
            DV.RowFilter = String.Format("auther LIKE '%{0}%'", textBox6.Text);
            li_dataview.DataSource = DV;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String query = "select *from data.student where roll='" + this.st_log_roll.Text + "';";
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader mdr;

            try
            {
                con.Open();
                mdr = cmd.ExecuteReader();
                if (mdr.Read() == true)
                {
                    home_panel.Visible = false;
                    student_log_panel.Visible = false;
                    admin_log_panel.Visible = false;
                    student_control_panel.Visible = true;
                    admin_control_panel.Visible = false;
                    this.WindowState = System.Windows.Forms.FormWindowState.Normal;
                    st_log_roll.Clear();
                }
                else if (this.st_log_roll.Text == "admin")
                {
                    home_panel.Visible = false;
                    student_log_panel.Visible = false;
                    admin_log_panel.Visible = false;
                    student_control_panel.Visible = true;
                    admin_control_panel.Visible = false;
                    this.WindowState = System.Windows.Forms.FormWindowState.Normal;
                    st_log_roll.Clear();
                }
                else
                {
                    st_log_roll.Clear();
                    MessageBox.Show("Sorry You are not in Database");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(li_dt);
            DV.RowFilter = String.Format("name LIKE '%{0}%'", textBox7.Text);
            st_li_dataview.DataSource = DV;
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
            DataView DV = new DataView(li_dt);
            DV.RowFilter = String.Format("auther LIKE '%{0}%'", textBox4.Text);
            st_li_dataview.DataSource = DV;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(in_dt);
            DV.RowFilter = String.Format("name LIKE '%{0}%'", textBox8.Text);
            st_in_dataview.DataSource = DV;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(gl_dt);
            DV.RowFilter = String.Format("name LIKE '%{0}%'", textBox9.Text);
            st_gl_dataview.DataSource = DV;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(ch_dt);
            DV.RowFilter = String.Format("name LIKE '%{0}%'", textBox10.Text);
            st_ch_dataview.DataSource = DV;
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(mu_dt);
            DV.RowFilter = String.Format("name LIKE '%{0}%'", textBox11.Text);
            st_mu_dataview.DataSource = DV;
        }

        private void label148_Click(object sender, EventArgs e)
        {

        }

        private void label150_Click(object sender, EventArgs e)
        {

        }

        String str;
        int i, len;
        private void time()
        {
            str = "Welcome To Mahishadal Raj College Department of Zoology";
            len = str.Length;
            i = 0;
            timer1.Enabled = true;
            lblTime.Text = DateTime.Now.ToLongDateString();

        }

        private void highlight()
        {
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (i < len)
            {
                header_label.Text += str.Substring(i, 1);
                i++;
            }
            else
            {
                header_label.Text = string.Empty;
                i = 0;
            }
        }

        private void home_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void footer_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage30_Click(object sender, EventArgs e)
        {

        }

        private void button47_Click(object sender, EventArgs e)
        {
            String id, b_name, s_name, roll, s_year;
            String query = "select *from data.library where id='" + this.issu_id.Text + "';";
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader mdr;
            try
            {
                con.Open();
                mdr = cmd.ExecuteReader();
                if (mdr.Read() == true)
                {
                    id = issu_id.Text;
                    b_name = mdr.GetString("name");
                    query = "select * from data.student where roll='" + this.issu_roll.Text + "';";
                    MySqlCommand cmd2 = new MySqlCommand(query, con);
                    mdr.Close();
                    mdr = cmd2.ExecuteReader();
                    if (mdr.Read() == true)
                    {
                        roll = issu_roll.Text;
                        s_name = mdr.GetString("name");
                        s_year = mdr.GetString("current_yr");
                        if (s_year == "1st Year" || s_year == "2nd Year" || s_year == "3rd Year")
                        {
                            query = "insert into data.issu (id,b_name,s_name,roll,s_year,date) values('"+id+"','"+b_name+"','"+s_name+"','"+roll+"','"+s_year+"','" + this.issu_date.Text + "');";
                            MySqlCommand cmd3 = new MySqlCommand(query, con);
                            mdr.Close();
                            mdr = cmd3.ExecuteReader();
                            if (mdr.RecordsAffected == 1)
                            {
                                issu_id.Clear();
                                issu_roll.Clear();
                                MessageBox.Show("Sucessefully Issued");
                            }
                            else
                                MessageBox.Show("There is some problem to issu");
                        }
                        else
                            MessageBox.Show("This student not present in college");
                    }
                    else
                        MessageBox.Show("This Student doesnot existe");
                }
                else
                    MessageBox.Show("This Book ID dose not existe");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                issuview();
            }
        }

        private void button48_Click(object sender, EventArgs e)
        {
            String query = "delete from data.issu where id='" + this.deposite_id.Text + "';";
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader mdr;
            try
            {
                con.Open();
                mdr = cmd.ExecuteReader();
                if (mdr.RecordsAffected == 1)
                {
                    deposite_id.Clear();
                    MessageBox.Show("Sucessefully Deposited");
                }
                else
                    MessageBox.Show("Theare is some problem to deposite");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                issuview();
            }
        }

        DataTable is_dt;
        void issuview()
        {
            String query = "select id as 'Book ID',b_name as 'Book Name',s_name as 'Issued By',roll as 'Roll No',s_year as 'Student Of', date as 'Date of Issu' from data.issu ;";
            MySqlCommand cmd = new MySqlCommand(query, con);
            try
            {
                con.Open();
                MySqlDataAdapter sda = new MySqlDataAdapter();
                is_dt = new DataTable();
                BindingSource bSourse = new BindingSource();
                sda.SelectCommand = cmd;
                sda.Fill(is_dt);
                bSourse.DataSource = is_dt;
                issu_view.DataSource = bSourse;
                sda.Update(is_dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void li_dataview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button49_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Filter = "pdf Files(*.pdf)|*.pdf";
            savefile.FileName = "Student List";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                String path = savefile.FileName.ToString();
                Document doc = new Document(iTextSharp.text.PageSize.A4, 10, 10, 10, 10);
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));
                doc.Open();
                PdfPTable table = new PdfPTable(st_dataview.Columns.Count);
                table.WidthPercentage = 100;
                for (int j = 0; j < st_dataview.Columns.Count; j++)
                {
                    table.AddCell(new Phrase(st_dataview.Columns[j].HeaderText, FontFactory.GetFont("arial", 10)));
                }
                table.HeaderRows = 1;
                for (int i = 0; i < st_dataview.Rows.Count; i++)
                {
                    for (int k = 0; k < st_dataview.Columns.Count; k++)
                    {
                        if (st_dataview[k, i].Value != null)
                        {
                            table.AddCell(new Phrase(st_dataview[k, i].Value.ToString(), FontFactory.GetFont("arial", 6)));
                        }
                    }
                }
                doc.Add(table);
                doc.Close();
            }
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to close ?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Form1 f = new Form1();
                f.Close();
            }
            if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button50_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Filter = "pdf Files(*.pdf)|*.pdf";
            savefile.FileName = "Book List";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                String path = savefile.FileName.ToString();
                Document doc = new Document(iTextSharp.text.PageSize.A4, 10, 10, 10, 10);
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));
                doc.Open();
                PdfPTable table = new PdfPTable(li_dataview.Columns.Count);
                table.WidthPercentage = 100;
                for (int j = 0; j < li_dataview.Columns.Count; j++)
                {
                    table.AddCell(new Phrase(li_dataview.Columns[j].HeaderText, FontFactory.GetFont("arial", 10)));
                }
                table.HeaderRows = 1;
                for (int i = 0; i < li_dataview.Rows.Count; i++)
                {
                    for (int k = 0; k < li_dataview.Columns.Count; k++)
                    {
                        if (li_dataview[k, i].Value != null)
                        {
                            table.AddCell(new Phrase(li_dataview[k, i].Value.ToString(), FontFactory.GetFont("arial", 6)));
                        }
                    }
                }
                doc.Add(table);
                doc.Close();
            }

        }

        private void button52_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Filter = "pdf Files(*.pdf)|*.pdf";
            savefile.FileName = "Instument List";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                String path = savefile.FileName.ToString();
                Document doc = new Document(iTextSharp.text.PageSize.A4, 10, 10, 10, 10);
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));
                doc.Open();
                PdfPTable table = new PdfPTable(in_dataview.Columns.Count);
                table.WidthPercentage = 100;
                for (int j = 0; j < in_dataview.Columns.Count; j++)
                {
                    table.AddCell(new Phrase(in_dataview.Columns[j].HeaderText, FontFactory.GetFont("arial", 10)));
                }
                table.HeaderRows = 1;
                for (int i = 0; i < in_dataview.Rows.Count; i++)
                {
                    for (int k = 0; k < in_dataview.Columns.Count; k++)
                    {
                        if (in_dataview[k, i].Value != null)
                        {
                            table.AddCell(new Phrase(in_dataview[k, i].Value.ToString(), FontFactory.GetFont("arial", 6)));
                        }
                    }
                }
                doc.Add(table);
                doc.Close();
            }
        }

        private void button53_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Filter = "pdf Files(*.pdf)|*.pdf";
            savefile.FileName = "Glassware List";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                String path = savefile.FileName.ToString();
                Document doc = new Document(iTextSharp.text.PageSize.A4, 10, 10, 10, 10);
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));
                doc.Open();
                PdfPTable table = new PdfPTable(gl_dataview.Columns.Count);
                table.WidthPercentage = 100;
                for (int j = 0; j < gl_dataview.Columns.Count; j++)
                {
                    table.AddCell(new Phrase(gl_dataview.Columns[j].HeaderText, FontFactory.GetFont("arial", 10)));
                }
                table.HeaderRows = 1;
                for (int i = 0; i < gl_dataview.Rows.Count; i++)
                {
                    for (int k = 0; k < gl_dataview.Columns.Count; k++)
                    {
                        if (gl_dataview[k, i].Value != null)
                        {
                            table.AddCell(new Phrase(gl_dataview[k, i].Value.ToString(), FontFactory.GetFont("arial", 6)));
                        }
                    }
                }
                doc.Add(table);
                doc.Close();
            }
        }

        private void button54_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Filter = "pdf Files(*.pdf)|*.pdf";
            savefile.FileName = "Chemical List";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                String path = savefile.FileName.ToString();
                Document doc = new Document(iTextSharp.text.PageSize.A4, 10, 10, 10, 10);
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));
                doc.Open();
                PdfPTable table = new PdfPTable(ch_dataview.Columns.Count);
                table.WidthPercentage = 100;
                for (int j = 0; j < ch_dataview.Columns.Count; j++)
                {
                    table.AddCell(new Phrase(ch_dataview.Columns[j].HeaderText, FontFactory.GetFont("arial", 10)));
                }
                table.HeaderRows = 1;
                for (int i = 0; i < ch_dataview.Rows.Count; i++)
                {
                    for (int k = 0; k < ch_dataview.Columns.Count; k++)
                    {
                        if (ch_dataview[k, i].Value != null)
                        {
                            table.AddCell(new Phrase(ch_dataview[k, i].Value.ToString(), FontFactory.GetFont("arial", 6)));
                        }
                    }
                }
                doc.Add(table);
                doc.Close();
            }
        }

        private void button55_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Filter = "pdf Files(*.pdf)|*.pdf";
            savefile.FileName = "Museum List";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                String path = savefile.FileName.ToString();
                Document doc = new Document(iTextSharp.text.PageSize.A4, 10, 10, 10, 10);
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));
                doc.Open();
                PdfPTable table = new PdfPTable(mu_dataview.Columns.Count);
                table.WidthPercentage = 100;
                for (int j = 0; j < mu_dataview.Columns.Count; j++)
                {
                    table.AddCell(new Phrase(mu_dataview.Columns[j].HeaderText, FontFactory.GetFont("arial", 10)));
                }
                table.HeaderRows = 1;
                for (int i = 0; i < mu_dataview.Rows.Count; i++)
                {
                    for (int k = 0; k < mu_dataview.Columns.Count; k++)
                    {
                        if (mu_dataview[k, i].Value != null)
                        {
                            table.AddCell(new Phrase(mu_dataview[k, i].Value.ToString(), FontFactory.GetFont("arial", 6)));
                        }
                    }
                }
                doc.Add(table);
                doc.Close();
            }
        }

        private void button51_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Filter = "pdf Files(*.pdf)|*.pdf";
            savefile.FileName = "Issu List";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                String path = savefile.FileName.ToString();
                Document doc = new Document(iTextSharp.text.PageSize.A4, 10, 10, 10, 10);
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));
                doc.Open();
                PdfPTable table = new PdfPTable(issu_view.Columns.Count);
                table.WidthPercentage = 100;
                for (int j = 0; j < issu_view.Columns.Count; j++)
                {
                    table.AddCell(new Phrase(issu_view.Columns[j].HeaderText, FontFactory.GetFont("arial", 10)));
                }
                table.HeaderRows = 1;
                for (int i = 0; i < issu_view.Rows.Count; i++)
                {
                    for (int k = 0; k < issu_view.Columns.Count; k++)
                    {
                        if (issu_view[k, i].Value != null)
                        {
                            table.AddCell(new Phrase(issu_view[k, i].Value.ToString(), FontFactory.GetFont("arial", 6)));
                        }
                    }
                }
                doc.Add(table);
                doc.Close();
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Resize(object sender, EventArgs e)
        {
        }

        
    }
}
