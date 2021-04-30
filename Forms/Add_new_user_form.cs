using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HariOmImpex_LMS.Forms
{
    public partial class Add_new_user_form : Form
    {
        public Add_new_user_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
			
				string text = "Data Source=" + global_vars.getDatabasePath();
				string text2 = null;
				text2 = "insert into users_data (user_name, password, af_bm, af_al, af_set, af_ad, af_qb, do_anc, do_dce, do_mce, do_anr, do_dr, do_ecd)values(@user_name, @password, @af_bm,@af_al, @af_set, @af_ad, @af_qb, @do_anc, @do_dce, @do_mce, @do_anr, @do_dr, @do_ecd);";
				SQLiteConnection connection = new SQLiteConnection(text);
				try
				{
					connection.Open();
					SQLiteCommand command = new SQLiteCommand(text2, connection);
					try
					{
						command.Parameters.AddWithValue("@user_name", (object)username_txtbx.Text);
						command.Parameters.AddWithValue("@password", (object)password_txtbx.Text);
						command.Parameters.AddWithValue("@af_bm", (object)Convert.ToInt32(af_bm_checkBox.CheckState));
						command.Parameters.AddWithValue("@af_al", (object)Convert.ToInt32(af_al_checkBox.CheckState));
						command.Parameters.AddWithValue("@af_set", (object)Convert.ToInt32(af_set_checkBox.CheckState));
						command.Parameters.AddWithValue("@af_ad", (object)Convert.ToInt32(af_ad_checkBox.CheckState));

						command.Parameters.AddWithValue("@af_qb", (object)Convert.ToInt32(af_qb_checkBox.CheckState));
						command.Parameters.AddWithValue("@do_anc", (object)Convert.ToInt32(do_anc_checkBox.CheckState));
						command.Parameters.AddWithValue("@do_dce", (object)Convert.ToInt32(do_dce_checkBox.CheckState));
						command.Parameters.AddWithValue("@do_mce", (object)Convert.ToInt32(do_mcd_checkBox.CheckState));
						command.Parameters.AddWithValue("@do_anr", (object)Convert.ToInt32(do_anr_checkBox.CheckState));
						command.Parameters.AddWithValue("@do_dr", (object)Convert.ToInt32(do_dr_checkBox.CheckState));
						command.Parameters.AddWithValue("@do_ecd", (object)Convert.ToInt32(do_ecd_checkBox.CheckState));
					
					
					if (command.ExecuteNonQuery() > 0)
						{
							toolStripStatusLabel1.Text = "New user added..";
							global_functions.Entry_log(0, "add_new_user - success", "");
						}
						else
						{
							MessageBox.Show("No row inserted");
						}
					}
					finally
					{
						command.Dispose();
					}
				}
				catch (Exception ex)
				{
				toolStripStatusLabel1.Text = "User cannot be added.. Please check the user details.";
				global_functions.Entry_log(1, "add_new_client - " + ex.Message, ex.StackTrace);
				}
				finally
				{
					((IDisposable)connection)?.Dispose();
				}
			
		}

        private void button2_Click(object sender, EventArgs e)
        {
			foreach (CheckBox box in groupBox3.Controls)
			{
				box.Checked = false;
			}

			foreach (TextBox box in groupBox1.Controls)
			{
				box.Clear();
			}


		}
    }
}
