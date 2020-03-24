using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace assignment2
{
    public partial class RebateForm : Form
    {
        public Regex PhoneNumberCheck = new Regex(@"^(\+0?1\s)?\(?\d{3}\)?[\s.-]\d{3}[\s.-]\d{4}$");
        public Regex EmailCheck = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        public Regex StateCheck = new Regex("^(?-i:A[LKSZRAEP]|C[AOT]|D[EC]|F[LM]|G[AU]|HI|I[ADLN]|K[SY]|LA|M[ADEHINOPST]|N[CDEHJMVY]|O[HKR]|P[ARW]|RI|S[CD]|T[NX]|UT|V[AIT]|W[AIVY])$");
        public Regex ZipCodeCheck = new Regex(@"^\d{5}(?:[-\s]\d{4})?$");
        int backnum = 0;
        bool modify = false;
        public RebateForm()
        {
            InitializeComponent();
        }

        private void Clear_form()
        {
            modify = false;
            SaveButton.Enabled = false;
            DeleteButton.Enabled = false;
            FirstNameBox.Clear();
            MiddleNmeBox.Clear();
            LastNameBox.Clear();
            GenderBox.Clear();
            Address1Box.Clear();
            Address2Box.Clear();
            CityBox.Clear();
            StateBox.Clear();
            ZipCodeBox.Clear();
            EmailBox.Clear();
            PhoneNumberBox.Clear();
            ResultList.SelectedItems.Clear();
            DateReceivedPicker.Value = DateTime.Today;
            StartTimeBox.Clear();
            SaveTimeBox.Clear();
            BackNumBox.Clear();
        }

        private void Update_form()
        {
            SaveButton.Enabled = false;
            Clear_form();
            modify = false;
            DataFile.user_list.Clear();
            ResultList.Items.Clear();
            backnum = 0;
            ProofAttachedDropDownList.SelectedIndex = 1;
            DataFile.total_user_number = 0;
            DataFile f = new DataFile();
            f.update_data();
            foreach (UserInfo NewUser in DataFile.user_list)//add all file data to list view
            {
                string[] new_user = { NewUser.Get_full_name(), NewUser.PhoneNumber };
                ListViewItem n_user = new ListViewItem(new_user);
                n_user.Tag = NewUser.UserID;
                ResultList.Items.Add(n_user);
            }
        }

        private void RebateForm_Load(object sender, EventArgs e)
        {
            backnum = 0;
            Clear_form();
            StartTimeBox.Text = "";
       
            ProofAttachedDropDownList.SelectedIndex = 1;
            DateReceivedPicker.Value = DateTime.Today;
            DateReceivedPicker.MaxDate = DateTime.Today;

            DataFile.user_list.Clear();
            DataFile.total_user_number = 0;
            ResultList.Items.Clear();
            DataFile f = new DataFile();
            f.update_data();
            foreach (UserInfo NewUser in DataFile.user_list)
            {
                string[] new_user = { NewUser.Get_full_name(), NewUser.PhoneNumber };
                ListViewItem n_user = new ListViewItem(new_user);
                n_user.Tag = NewUser.UserID;
                ResultList.Items.Add(n_user);
            }
        }

        private void GetStartTime()
        {
            if(StartTimeBox.Text == "")
            {
                StartTimeBox.Text = DateTime.Now.ToString("HH:mm:ss tt");
            }
        }

        private void CheckSaveButtonValidation()
        {
            bool mark = true;
            if(string.IsNullOrEmpty(FirstNameBox.Text))
            {
                FirstNameBox.BackColor = Color.Red;
               //SaveButton.Enabled = false;
                mark = false;
            }
            else
            {
                FirstNameBox.BackColor = Color.White;
            }

            if (string.IsNullOrEmpty(LastNameBox.Text))
            {
                LastNameBox.BackColor = Color.Red;
                //SaveButton.Enabled = false;
                mark = false;
            }
            else
            {
                LastNameBox.BackColor = Color.White;
            }

            if (string.IsNullOrEmpty(GenderBox.Text) || (GenderBox.Text != "M" && GenderBox.Text != "F"))
            {
                GenderBox.BackColor = Color.Red;
               //SaveButton.Enabled = false;
                mark = false;
            }
            else
            {
                GenderBox.BackColor = Color.White;
            }

            if (string.IsNullOrEmpty(PhoneNumberBox.Text) || !PhoneNumberCheck.IsMatch(PhoneNumberBox.Text))
            {
                PhoneNumberBox.BackColor = Color.Red;
                //SaveButton.Enabled = false;
                mark = false;
            }
            else
            {
                PhoneNumberBox.BackColor = Color.White;
            }

            if (string.IsNullOrEmpty(EmailBox.Text) || !EmailCheck.IsMatch(EmailBox.Text))
            {
                EmailBox.BackColor = Color.Red;
                //SaveButton.Enabled = false;
                mark = false;
            }
            else
            {
                EmailBox.BackColor = Color.White;
            }

            if (string.IsNullOrEmpty(Address1Box.Text))
            {
                Address1Box.BackColor = Color.Red;
                //SaveButton.Enabled = false;
                mark = false;
            }
            else
            {
                Address1Box.BackColor = Color.White;
            }

            if (string.IsNullOrEmpty(CityBox.Text))
            {
                CityBox.BackColor = Color.Red;
               // SaveButton.Enabled = false;
                mark = false;
            }
            else
            {
                CityBox.BackColor = Color.White;
            }

            if (string.IsNullOrEmpty(StateBox.Text) || !StateCheck.IsMatch(StateBox.Text))
            {
                StateBox.BackColor = Color.Red;
               // SaveButton.Enabled = false;
                mark = false;
            }
            else
            {
                StateBox.BackColor = Color.White;
            }

            if (string.IsNullOrEmpty(ZipCodeBox.Text) || !ZipCodeCheck.IsMatch(ZipCodeBox.Text))
            {
                ZipCodeBox.BackColor = Color.Red;
               // SaveButton.Enabled = false;
                mark = false;
            }
            else
            {
                ZipCodeBox.BackColor = Color.White;
            }

            if (string.IsNullOrEmpty(ProofAttachedDropDownList.Text))
            {
                ProofAttachedDropDownList.BackColor = Color.Red;
                //SaveButton.Enabled = false;
                mark = false;
            }
            else
            {
                ProofAttachedDropDownList.BackColor = Color.White;
            }
            SaveButton.Enabled = mark;
            return;
        }

        private void ClearButtonClick(object sender, EventArgs e)
        {
            Clear_form();
        }

        private void BoxTextChanged(object sender, EventArgs e)
        {
            GetStartTime();
            CheckSaveButtonValidation();
        }

        private void RebateForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)8)
            {
                backnum++;
            }
        }

        //make sure no duplicate record
        private bool validation(string first_name, string last_name, string phone_number)
        {
            if (ResultList.SelectedItems.Count > 0)
            {
                string full_name = ResultList.SelectedItems[0].SubItems[1].Text;
                string[] temp_user = full_name.Split(' ');
                string first_name_temp = temp_user[0];
                string last_name_temp = temp_user[temp_user.Length - 1];
                string phone_number_temp = ResultList.SelectedItems[0].SubItems[1].Text; //get the basic user info for sorting
                if (first_name == first_name_temp && last_name == last_name_temp && phone_number == phone_number_temp)//grab the exist data of the select user
                {
                    return true;
                }
            }
            foreach (UserInfo user in DataFile.user_list)
            {
                if (user.FirstName == first_name && user.LastName == last_name && user.PhoneNumber == phone_number)//grab the exist data of the select user
                {
                    return false;
                }
            }
            return true;
        }


        private void SaveButtonClick(object sender, EventArgs e)
        {
            DataFile f = new DataFile();
            string proof_of_purchase_attached = ProofAttachedDropDownList.Text;
            string first_name = FirstNameBox.Text;
            string middle_initial = MiddleNmeBox.Text;
            string last_name = LastNameBox.Text;
            string gender = GenderBox.Text;
            string addr1 = Address1Box.Text;
            string addr2 = Address2Box.Text;
            string city = CityBox.Text;
            string state = StateBox.Text;
            string zip = ZipCodeBox.Text;
            string email = EmailBox.Text;
            string phone = PhoneNumberBox.Text;
            string date_received = DateReceivedPicker.Value.ToString();
            string time_start = StartTimeBox.Text;
            string time_save = DateTime.Now.ToString("HH:mm:ss tt");
            if (modify == true)
            {
                UserInfo user_temp;
                string first_name_temp = ResultList.SelectedItems[0].SubItems[0].Text;
                string last_name_temp = ResultList.SelectedItems[0].SubItems[1].Text;
                string phone_number_temp = ResultList.SelectedItems[0].SubItems[1].Text;
                foreach (var user in DataFile.user_list)
                {
                    if (user.FirstName == first_name_temp && user.LastName == last_name_temp && user.PhoneNumber == phone_number_temp)
                    {
                        user_temp = user;
                        time_start = user_temp.StartTime;
                        time_save = user_temp.SaveTime;
                        backnum = Int32.Parse(user_temp.BackNum);
                        modify = true;
                    }
                }
                int user_temp_index = ResultList.SelectedItems[0].Index;
                string info = String.Join("\t", user_temp_index, first_name, middle_initial, last_name, gender, addr1, addr2, city, state, zip,
                    email, phone, proof_of_purchase_attached, date_received, time_start, time_save, backnum);
                if (validation(first_name, last_name, phone))
                {
                    f.modify_data(info, user_temp_index);    //filo IO function call _modify data
                    DateReceivedPicker.Value = DateTime.Today;
                    Update_form();
                }
            }
            else
            {
                string info = String.Join("\t", DataFile.total_user_number,
                    first_name, middle_initial, last_name, gender, addr1, addr2, city, state, zip,
                    email, phone, proof_of_purchase_attached, date_received, time_start, time_save, backnum);
                if (validation(first_name, last_name, phone))
                {
                    f.add_data(info);
                    DateReceivedPicker.Value = DateTime.Today;
                    Update_form();
                }
            }
        }

        private void DeleteButtonClick(object sender, EventArgs e)
        {
            DataFile f = new DataFile();
            int user_temp_index = ResultList.SelectedItems[0].Index;
            f.delete_data(user_temp_index);
            DateReceivedPicker.Value = DateTime.Today;
            Update_form();
            DeleteButton.Enabled = false;
        }

        private void lstItems_MouseDoubleClick(object sender, ListViewItemSelectionChangedEventArgs e)
        {

        }

        private void ResultList_DoubleClick(object sender, EventArgs e)
        {
            if (ResultList.SelectedItems.Count > 0)
            {
                UserInfo user_temp;
                string[] t = ResultList.SelectedItems[0].SubItems[0].Text.Split();
                string first_name_temp = t[0];
                string last_name_temp = t[2];
                string phone_number_temp = ResultList.SelectedItems[0].SubItems[1].Text;
                foreach (var user in DataFile.user_list)
                {
                    if (user.FirstName == first_name_temp && user.LastName == last_name_temp && user.PhoneNumber == phone_number_temp)
                    {
                        user_temp = user;
                        FirstNameBox.Text = user_temp.FirstName;
                        MiddleNmeBox.Text = user_temp.MiddleName;
                        LastNameBox.Text = user_temp.LastName;
                        Address1Box.Text = user_temp.Address1;
                        Address2Box.Text = user_temp.Address2;
                        CityBox.Text = user_temp.City;
                        StateBox.Text = user_temp.State;
                        ZipCodeBox.Text = user_temp.ZipCode;
                        GenderBox.Text = user_temp.Gender;
                        PhoneNumberBox.Text = user_temp.PhoneNumber;
                        EmailBox.Text = user_temp.EmailAdderss;
                        if (user_temp.PoofAttach == "YES")
                            ProofAttachedDropDownList.SelectedIndex = 0;
                        else
                            ProofAttachedDropDownList.SelectedIndex = 1;
                        DateTime dt = Convert.ToDateTime(user_temp.ReceiveDate);
                        DateReceivedPicker.Value = dt;
                        StartTimeBox.Text = user_temp.StartTime;
                        SaveTimeBox.Text = user_temp.SaveTime;
                        BackNumBox.Text = user_temp.BackNum;
                        modify = true;
                        DeleteButton.Enabled = true;
                    }
                }

            }
        }

    }
}
