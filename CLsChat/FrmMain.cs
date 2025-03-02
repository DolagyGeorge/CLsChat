using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CLsChat
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {

            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            labelfromSent.Visible=false;
            labeltoSent.Visible=false;
            labfromSent.Visible=false;
            labtoSent.Visible=false;
            txtToSent.Visible=false;
            txtSRcSent.Enabled=false;

            txtSrc.Enabled = false;
            labFrom.Visible = false;
            labTo.Visible = false;
            txtTime.Visible = false;
            labeldate1.Visible = false;
            labelDate2.Visible = false;
            string inbox = $"select MessageID,UserName sender,Subj,Body,DateSent,IsRead " +
                $"from Users inner join Messages on SenderID = UserID " +
                $"where RecipientID = {DB.UserID}";
            DB.FillGrid(inbox, dataGridInbox);
            string sent = $"select UserName recipient,Subj,Body,DateSent,IsRead " +
                $"from Users inner join Messages on RecipientID = UserID " +
                $"where SenderID = {DB.UserID}";
            DB.FillGrid(sent, dataGridsent);

        }



        private void listIndev_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            List<string> rec = new List<string>();

            if (txtSubject.Text == "")
            {
                MessageBox.Show("Please enter Subject");
                txtSubject.Focus();
                return;
            }
            if (txtmessage.Text == "")
            {
                MessageBox.Show("Please enter message");
                txtmessage.Focus();
                return;
            }

            bool isChecked = checkBox1.Checked;
            if (isChecked)
            {
                for (int i = 0; i < listIndev.Items.Count; i++)
                {

                    listIndev.SetSelected(i, true);
                    rec.Add(listIndev.GetItemText(listIndev.Items[i]));
                }

            }

            else
            {
               
                foreach (var selecteditem in listIndev.SelectedItems)
                {
                   rec.Add(listIndev.GetItemText(selecteditem));
                }
            }
            if (rec.Count < 1)
            {
                MessageBox.Show("Please choose user or a group");
                return;
            }

            if (rec.Count > 0 && radioButtonindv.Checked)
            {
                foreach (string recipient in rec)
                {

                    string to = $"select UserID from Users where UserName ='{recipient}' ";
                    string touser = DB.Searchscaler(to);


                    string sl = $"INSERT INTO Messages ( SenderID, RecipientID, Subj, Body, DateSent, IsRead)" +
                        $"VALUES({DB.UserID},{touser},N'{txtSubject.Text}',N'{txtmessage.Text}',GETDATE(),0) ";

                    DB.execute(sl);

                    
                }
                MessageBox.Show("messege entered succssefully");
            }
            else if (rec.Count > 0 && radioButtongrp.Checked)
            {
                foreach (string recipient in rec)
                {

                    string grp = $"select groupid from Groups where GroupName ='{recipient}' ";
                    string togrp = DB.Searchscaler(grp);

                    string usrGrp = $"select u.UserID  from Groups g join Users u " +
                        $"on u.GroupID = g.GroupID where g.GroupID = {togrp}";
                    DataTable tousrgrp = DB.SearchTable(usrGrp);

                    for (int i = 0; i < tousrgrp.Rows.Count; i++)
                    {
                        for (int j = 0; j < tousrgrp.Columns.Count; j++)
                        {
                            
                            string r = tousrgrp.Rows[i][j].ToString();
                            string sl = $"INSERT INTO Messages ( SenderID, RecipientID, Subj, Body, DateSent, IsRead)" +
                                $"VALUES({DB.UserID},{tousrgrp.Rows[i][j].ToString()},N'{txtSubject.Text}',N'{txtmessage.Text}',GETDATE(),0) ";

                            DB.execute(sl);
                        }

                    }



                }
                MessageBox.Show("messege entered succssefully");

            }


        }

        private void dataGridInbox_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string inbox = $"select MessageID,UserName,Subj,Body,DateSent,IsRead " +
              $"from Users inner join Messages on SenderID = UserID " +
              $"where RecipientID = {DB.UserID}";
            DB.FillGrid(inbox, dataGridInbox);
            dataGridInbox.Refresh();
        }

        private void dataGridsent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sentrefresh_Click(object sender, EventArgs e)
        {
            string sent = $"select UserName,Subj,Body,DateSent,IsRead " +
                $"from Users inner join Messages on RecipientID = UserID " +
                $"where SenderID = {DB.UserID}";
            DB.FillGrid(sent, dataGridsent);
            dataGridInbox.Refresh();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = checkBox1.Checked;

        }

        private void radioButtonindv_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = radioButtonindv.Checked;
            if (isChecked)
            {
                string sl = $"select * from Users";
                DB.FillList(sl, listIndev);
            }
        }

        private void radioButtongrp_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = radioButtongrp.Checked;
            if (isChecked)
            {
                string sl = "select * from Groups";
                DB.FillList(sl, listIndev);
            }

        }

        private void txtSrcSent_TextChanged(object sender, EventArgs e)
        {

        }



        private void btnsrcIN_Click(object sender, EventArgs e)
        {
            if (txtSrc.Text== "")
            {
                MessageBox.Show("enter (date/rec/content)");
                return;
            }
            if (comboBoxSent.SelectedIndex == 0 && txtToSent.Text == "")
            {
                MessageBox.Show("enter TO Date");
                return;
            }
            if (comboBoxIN.SelectedIndex == 0)
            {
                string sl = $"select UserName sender,Subj,Body,DateSent,IsRead" +
                $" from Users inner join Messages on SenderID = UserID" +
                $" where RecipientID = {DB.UserID} and DateSent between " +
                $" '{txtSrc.Text}' and '{txtTime.Text}' ";
                DB.FillGrid(sl, dataGridInbox);
                dataGridInbox.Refresh();
                labFrom.Visible = false;
                labTo.Visible = false;
                txtTime.Visible = false;
                labeldate1.Visible = false;
                labelDate2.Visible = false;
            }
            if (comboBoxIN.SelectedIndex == 1)
            {
                string sl = $"select UserName sender,Subj,Body,DateSent,IsRead " +
                    $"from Users inner join Messages on SenderID = UserID " +
                    $"where RecipientID = {DB.UserID} and UserName like N'%{txtSrc.Text}%' ";
                DB.FillGrid(sl, dataGridInbox);
                dataGridInbox.Refresh();
            }
            if (comboBoxIN.SelectedIndex == 2)
            {
                string sl = $"select UserName sender,Subj,Body,DateSent,IsRead" +
                    $" from Users inner join Messages on SenderID = UserID" +
                    $" where RecipientID = {DB.UserID} and Subj like N'%{txtSrc.Text}%'  ";
                DB.FillGrid(sl, dataGridInbox);
                dataGridInbox.Refresh();
            }

        }

        private void comboBoxIN_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSrc.Enabled = true;
            if(comboBoxIN.SelectedIndex == 0)
            {
                labFrom.Visible = true;
                labTo.Visible = true;
                txtTime.Visible = true;
                labelDate2.Visible = true;
                labeldate1.Visible = true;

            }
            else
            {
                labFrom.Visible = false;
                labTo.Visible = false;
                txtTime.Visible = false;
                labelDate2.Visible = false;
                labeldate1.Visible = false;
            }


        }

        private void comboBoxSent_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSRcSent.Enabled = true;
            if (comboBoxSent.SelectedIndex == 0)
            {
                labelfromSent.Visible = true;
                labeltoSent.Visible = true;
                labfromSent.Visible = true;
                labtoSent.Visible = true;
                txtToSent.Visible = true;
            }
            else
            {
                labelfromSent.Visible = false;
                labeltoSent.Visible = false;
                labfromSent.Visible = false;
                labtoSent.Visible = false;
                txtToSent.Visible = false;
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtSrc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTime_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsrcSent_Click(object sender, EventArgs e)
        {
            if (txtSRcSent.Text == "")
            {
                MessageBox.Show("enter (date/rec/content)");
                return;
            }
            if (comboBoxSent.SelectedIndex == 0 && txtToSent.Text=="")
            {
                MessageBox.Show("enter TO Date");
                return;
            }

                if (comboBoxSent.SelectedIndex == 0)
            {
                string sl = $"select UserName recipient,Subj,Body,DateSent,IsRead" +
                $" from Users inner join Messages on RecipientID = UserID" +
                $" where SenderID = {DB.UserID} and DateSent between " +
                $" '{txtSRcSent.Text}' and '{txtToSent.Text}' ";

                DB.FillGrid(sl, dataGridsent);
                dataGridsent.Refresh();

            }
            if (comboBoxSent.SelectedIndex == 1)
            {
                string sl = $"select UserName recipient,Subj,Body,DateSent,IsRead " +
                    $"from Users inner join Messages on RecipientID = UserID " +
                    $"where SenderID = {DB.UserID} and UserName like N'%{txtSRcSent.Text}%' ";
                DB.FillGrid(sl, dataGridsent);
                dataGridsent.Refresh();
            }
            if (comboBoxSent.SelectedIndex == 2)
            {
                string sl = $"select UserName recipient,Subj,Body,DateSent,IsRead" +
                    $" from Users inner join Messages on RecipientID = UserID" +
                    $" where SenderID = {DB.UserID} and Subj like N'%{txtSRcSent.Text}%'  ";
                DB.FillGrid(sl, dataGridsent);
                dataGridsent.Refresh();
            }
        }

        /*private void dataGridInbox_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        { }*/

        private void dataGridInbox_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridInbox.Columns["IsRead"].Index && e.RowIndex >= 0)
            {
                bool isChecked = (bool)dataGridInbox.Rows[e.RowIndex].Cells["IsRead"].Value;
                int messageId = (int)dataGridInbox.Rows[e.RowIndex].Cells["MessageID"].Value;

                // Log to the console
                Console.WriteLine($"Row {e.RowIndex} marked as {(isChecked ? "Read" : "Unread")}");

                // Update the database
                if (isChecked)
                {
                    string sl = $"update Messages set IsRead= 1 where MessageID = {messageId}";
                    DB.execute(sl);
                }
            }


        }
    }
}
