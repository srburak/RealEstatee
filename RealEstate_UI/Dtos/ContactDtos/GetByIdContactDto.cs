﻿namespace RealEstate_UI.Dtos.ContactDtos
{
    public class GetByIdContactDto
    {
        public int ContactID { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public DateTime SendDate { get; set; }
    }
}
