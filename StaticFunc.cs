using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace WinFormsApp1
{
    public class StaticFunc
    {
        public static string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public static DataTable ToDataTable<T>(List<T> data)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            DataTable dataTable = new DataTable();
            foreach (PropertyDescriptor prop in properties)
            {
                if(Nullable.GetUnderlyingType(prop.PropertyType) != null)
                {
                    dataTable.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType));
                }
                else if (prop.PropertyType.IsValueType || prop.PropertyType == typeof(string))
                {
                    dataTable.Columns.Add(prop.Name, prop.PropertyType);
                }
            }
            foreach (T item in data)
            {
                DataRow row = dataTable.NewRow();
                foreach (PropertyDescriptor prop in properties)
                {
                    if (prop.PropertyType.IsValueType || prop.PropertyType == typeof(string))
                    {
                        row[prop.Name] = prop.GetValue(item)??DBNull.Value;
                    }
                }
                dataTable.Rows.Add(row);
            }
            return dataTable;
        }

        public static bool SendEmail(string sendMailTo, string subJect, string body)
        {
            try
            {
                string sendMailFrom = "testpblne@gmail.com";
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com", 587);
                SmtpServer.EnableSsl = true;
                SmtpServer.Credentials = new NetworkCredential(sendMailFrom, "wtlnwytgfxcuuwto");
                SmtpServer.Send(new MailMessage(sendMailFrom, sendMailTo, subJect, body));
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static string GenerateRandomString(int length)
        {
            while (true)
            {
                StringBuilder randomStringBuilder = new StringBuilder();
                Random rand = new Random();
                for (int i = 0; i < length; i++)
                {
                    int randValue = rand.Next(33, 127);
                    randomStringBuilder.Append(Convert.ToChar(randValue));
                }
                Regex regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$");
                string stringResult = randomStringBuilder.ToString();
                if (regex.IsMatch(stringResult))
                {
                    return stringResult;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
