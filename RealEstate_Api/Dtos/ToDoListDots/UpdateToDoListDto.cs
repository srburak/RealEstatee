﻿namespace RealEstate_Api.Dtos.ToDoListDots
{
    public class UpdateToDoListDto
    {
        public int ToDoListID { get; set; }
        public string Description { get; set; }
        public bool ToDoListStasus { get; set; }
    }
}