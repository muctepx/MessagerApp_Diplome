﻿namespace UserService.Model
{
    public class User
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public byte[] Password { get; set; }
        public byte[] Salt { get; set; }
        public virtual RoleId RoleId { get; set; }
        public virtual Role Role { get; set; }
        
    }
}
