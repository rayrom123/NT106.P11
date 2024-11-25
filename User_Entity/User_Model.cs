using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace User_Entity
{
    public class User_Model
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public int Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Interests { get; set; }
        public string ImagePath { get; set; }
        public string Location { get; set; }
        public string MatchList { get; set; }
        public string DislikeList {  get; set; }

        public 

        public User_Model() { }
        public User_Model(string username, string password)
        {
            this.UserName = username;
            this.Password = password;

        }
        public User_Model(string userName, string password, string fullName, int gender) : this(userName, password)
        {
            FullName = fullName;
            Gender = gender;

        }
        public User_Model(string userName, string password, string fullName, int gender, DateTime dateOfBirth, string interests, string imagePath, string location)
        : this(userName, password, fullName, gender)
        {
            DateOfBirth = dateOfBirth;
            Interests = interests;
            ImagePath = imagePath;
            Location = location;
            
        }
        public User_Model(string userName, string password, string fullName, int gender, DateTime dateOfBirth, string interests, string imagePath, string location, string matchList)
            : this(userName, password, fullName, gender, dateOfBirth, interests, imagePath, location)
        {
            MatchList = matchList;
        }
        public string encrypt(string pass)
        {
            var md5 = new MD5CryptoServiceProvider();
            byte[] encrypt;
            ASCIIEncoding encode = new ASCIIEncoding();
            encrypt = md5.ComputeHash(encode.GetBytes(pass));
            StringBuilder encryptdata = new StringBuilder();
            for (int i = 0; i < encrypt.Length; i++)
            {
                encryptdata.Append(encrypt[i].ToString("x3"));
            }
            return encryptdata.ToString();
        }

    }
};
