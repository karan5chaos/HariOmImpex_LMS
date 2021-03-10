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
    public partial class Add_new_client_form : Form
    {
        public Add_new_client_form()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
			if (!check_empty())
			{
				string text = "Data Source=" + global_vars.getDatabasePath();
				string text2 = null;
				text2 = "insert into client_data (Company_name, Client_name, Phone_number,MailID, PAN_number, Aadhar_number, IEC_number, GST_number, GST_login_id, GST_login_password, Bank_name, Bank_ifs_code, Bank_account_no, DGFT_login_id, DGFT_login_password,DGFT_digital_exp, ICEGATE_id, ICEGATE_password)values(@Company_name, @Client_name, @Phone_number, @MailID, @PAN_number, @Aadhar_number, @IEC_number, @GST_number, @GST_login_id,@GST_login_password, @Bank_name, @Bank_ifs_code, @Bank_account_no, @DGFT_login_id, @DGFT_login_password,@DGFT_digital_exp, @ICEGATE_id, @ICEGATE_password);";
				SQLiteConnection connection = new SQLiteConnection(text);
				try
				{
					connection.Open();
					SQLiteCommand command = new SQLiteCommand(text2, connection);
					try
					{
						command.Parameters.AddWithValue("@Company_name", (object)company_name_txtbx.Text);
						command.Parameters.AddWithValue("@Client_name", (object)client_name_txtbx.Text);
						command.Parameters.AddWithValue("@Phone_number", (object)phone_txtbx.Text);
						command.Parameters.AddWithValue("@MailID", (object)mai_txtbx.Text);
						command.Parameters.AddWithValue("@PAN_number", (object)pan_txtbx.Text);
						command.Parameters.AddWithValue("@Aadhar_number", (object)adh_txtbx.Text);
						command.Parameters.AddWithValue("@IEC_number", (object)iec_txtbx.Text);
						command.Parameters.AddWithValue("@GST_number", (object)gstnum_txtbx.Text);
						command.Parameters.AddWithValue("@GST_login_id", (object)gstid_txtbx.Text);
						command.Parameters.AddWithValue("@GST_login_password", (object)gstpass_txtbx.Text);
						command.Parameters.AddWithValue("@Bank_name", (object)bankname_txtbx.Text);
						command.Parameters.AddWithValue("@Bank_ifs_code", (object)ifsc_txtbx.Text);
						command.Parameters.AddWithValue("@Bank_account_no", (object)banknum_txtbx.Text);
						command.Parameters.AddWithValue("@DGFT_login_id", (object)dgftid_txtbx.Text);
						command.Parameters.AddWithValue("@DGFT_login_password", (object)dgftpass_txtbx.Text);
						command.Parameters.AddWithValue("@DGFT_digital_exp", (object)dgftdate_txtbx.Text);
						command.Parameters.AddWithValue("@ICEGATE_id", (object)icegateid_txtbx.Text);
						command.Parameters.AddWithValue("@ICEGATE_password", (object)icegatepass_txtbx.Text);
						if (command.ExecuteNonQuery() > 0)
						{
							toolStripStatusLabel1.Text = "New client data recorded..";
							global_functions.Entry_log(0, "add_new_client - success", "");
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
					MessageBox.Show("ERROR:" + ex.Message);
					global_functions.Entry_log(1, "add_new_client - " + ex.Message, ex.StackTrace);
				}
				finally
				{
					((IDisposable)connection)?.Dispose();
				}
			}
			else
			{
				MessageBox.Show("All fields cannot be empty..");
			}
		}

        private void button1_Click(object sender, EventArgs e)
        {
			foreach (Control control6 in groupBox2.Controls)
			{
				if (control6 is TextBox)
				{
					control6.Text = "";
				}
			}
			foreach (Control control7 in groupBox3.Controls)
			{
				if (control7 is TextBox)
				{
					control7.Text = "";
				}
			}
			foreach (Control control8 in groupBox4.Controls)
			{
				if (control8 is TextBox)
				{
					control8.Text = "";
				}
			}
			foreach (Control control9 in groupBox5.Controls)
			{
				if (control9 is TextBox)
				{
					control9.Text = "";
				}
			}
			foreach (Control control10 in groupBox6.Controls)
			{
				if (control10 is TextBox)
				{
					control10.Text = "";
				}
			}

			global_functions.Entry_log(0, "clear_all_fields - success", "");
		}

		private bool check_empty()
		{
			
			int num = 0;
			foreach (Control control6 in groupBox2.Controls)
			{
				if (control6 is TextBox && control6.Text != "" && control6.Text != null)
				{
					num++;
				}
			}
			foreach (Control control7 in groupBox3.Controls)
			{
				if (control7 is TextBox && control7.Text != "" && control7.Text != null)
				{
					num++;
				}
			}
			foreach (Control control8 in groupBox4.Controls)
			{
				if (control8 is TextBox && control8.Text != "" && control8.Text != null)
				{
					num++;
				}
			}
			foreach (Control control9 in groupBox5.Controls)
			{
				if (control9 is TextBox && control9.Text != "" && control9.Text != null)
				{
					num++;
				}
			}
			foreach (Control control10 in groupBox6.Controls)
			{
				if (control10 is TextBox && control10.Text != "" && control10.Text != null)
				{
					num++;
				}
			}
			if (num == 0)
			{
				return true;
			}
			return false;
		}
	}
}
