using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assignment2
{
    class DataFile
    {
        public string filepath = "CS6326Asg2.txt";
        public static List<UserInfo> user_list = new List<UserInfo>();
        public static int total_user_number = 0;

        public void update_data()
        {
            if (File.Exists(filepath))
            {
                StreamReader file = new StreamReader(filepath);
                List<String> lines = File.ReadAllLines(filepath).ToList();
                foreach (var line in lines)
                {
                    string[] entries = line.Split('\t');
                    UserInfo NewUser = new UserInfo();
                    NewUser.UserID = entries[0];
                    NewUser.FirstName = entries[1];
                    NewUser.MiddleName = entries[2];
                    NewUser.LastName = entries[3];
                    NewUser.Gender = entries[4];
                    NewUser.Address1 = entries[5];
                    NewUser.Address2 = entries[6];
                    NewUser.City = entries[7];
                    NewUser.State = entries[8];
                    NewUser.ZipCode = entries[9];
                    NewUser.EmailAdderss = entries[10];
                    NewUser.PhoneNumber = entries[11];
                    NewUser.PoofAttach = entries[12];
                    NewUser.ReceiveDate = entries[13];
                    NewUser.StartTime = entries[14];
                    NewUser.SaveTime = entries[15];
                    NewUser.BackNum = entries[16];
                    user_list.Add(NewUser);
                    total_user_number = total_user_number + 1;
                }
                file.Close();
            }
        }

        public void modify_data(string info, int user_temp_index)
        {
            string[] new_data = File.ReadAllLines(filepath);
            new_data[user_temp_index] = info;
            File.WriteAllLines(filepath, new_data);
        }

        public void add_data(string info)
        {
            System.IO.StreamWriter file_write = new System.IO.StreamWriter(filepath, true);
            file_write.WriteLine(info);
            file_write.Close();
        }

        public void delete_data(int user_temp_index)
        {
            List<String> lines = File.ReadAllLines(filepath).ToList();
            lines.RemoveAt(user_temp_index);
            File.WriteAllLines(filepath, lines);
        }
    }
}
