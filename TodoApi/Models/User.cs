﻿namespace TodoApi.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public List<TodoItem>? TodoItems { get; set; }
    }
}