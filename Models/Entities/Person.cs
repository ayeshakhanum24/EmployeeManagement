﻿namespace DapperMvcDemo.Models.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public string? Address { get; set; }
        public int DeptId { get; set; }
    }
}
