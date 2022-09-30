using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_purdelivery
{
    public class T_User
    {
        [Key]
        [StringLength(8)]
        public string username { get; set; }
        [NotMapped]
        [DataType(DataType.Password)]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        public string password { get; set; }
        [NotMapped]
        [DataType(DataType.Password)]
        [Compare("password", ErrorMessage = "Confirm password does not match, type again")]
        public string confirmpassword { get; set; }
        public string passwordhash { get; set; }
        public byte[] storedsalt { get; set; }
        public bool? active { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? created_at { get; set; }
        public string created_by { get; set; }
        public DateTime? reset_password_at { get; set; }
        public string reset_password_by { get; set; }
        public string name { get; set; }
        public string dept { get; set; }
        [EmailAddress]
        public string email { get; set; }
        public List<T_Role_Claim> roles { get; set; }
    }
    public class T_Role
    {
        [Key]
        public string role { get; set; }
        public string description { get; set; }
        public List<T_Role_Claim> users { get; set; }
    }
    [Keyless]
    public class T_Role_Claim
    {
        public string username { get; set; }
        public T_User users { get; set; }
        public string role { get; set; }
        public T_Role roles { get; set; }
    }
    [Keyless]
    public class Login
    {
        [StringLength(8)]
        public string username { get; set; }
        public string password { get; set; }
    }
    [Keyless]
    public class Register
    {
        [StringLength(8)]
        public string username { get; set; }
        public List<string> roles { get; set; }
    }
    [Keyless]
    public class ChangePassword
    {
        public string username { get; set; }
        public string current_password { get; set; }
        public string new_password { get; set; }
    }
}